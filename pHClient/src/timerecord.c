#include "timerecord.h"
#include "ph1.h"
#include "connection.h"
#include "sockettest.h"
#include <app_preference.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>

typedef struct appdata {
   Evas_Object *win;
   Evas_Object *conform;
   Evas_Object *naviframe;
   Eext_Circle_Surface *circle_surface;
   Evas_Object *circle_genlist;
   Evas_Object *label;
   Elm_Object_Item *nf_it;

   int startNum;
} appdata_s;

typedef struct _item_data
{
   int index;
   Elm_Object_Item *item;
} item_data;

char time_record_contents[][30] = {

   "1. --:-- / --:--",
   "2. --:-- / --:--",
   "3. --:-- / --:--",
   "4. --:-- / --:--",
   "5. --:-- / --:--",
   NULL
};


static void win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
   ui_app_exit();
}

static char* _gl_title_text_get(void *data, Evas_Object *obj, const char *part)
{
   char buf[1024];

   snprintf(buf, 1023, "%s", "<color=#F5D6FFFF>Time Record</color>");

   return strdup(buf);
}

static char * _gl_main_text_get(void *data, Evas_Object *obj, const char *part)
{
   char buf[1024];
   item_data *id = data;
   int index = id->index;

   if (!strcmp(part, "elm.text")) {
      snprintf(buf, 1023, "%s", time_record_contents[index]);
      return strdup(buf);
   }
   return NULL;
}

char* calTime(int time){
   char str[30] = "";
   int hms[3] = {0,};
   char hms_str[5] = "";
//   hms[0] = time/3600;
//   hms[1] = (time%3600)/60;
//   hms[2] = (time%3600)%60;
   hms[0] = (time/3600)*60 + (time%3600)/60;
   hms[1] = (time%3600)%60;
   //dlog_print(DLOG_INFO, "ResetCalTime", "m s %d %d", hms[0], hms[1]);

   for(int i=0; i<2; i++){
      if(hms[i]<10){
         strcat(str, "0");
      }

      snprintf(hms_str, sizeof(hms_str), "%d", hms[i]);
      strcat(str, hms_str);

      if(i<1){
         strcat(str, ":");
      }
   }
   //dlog_print(DLOG_INFO, "ResetCalTime","str %s", str);
   return str;
}

void input_record() {
   //dlog_print(DLOG_INFO, "ResetClicked", "input_ record start");
   int count = 0;
   bool existing = false;
    char num[2] = "";
    char total[4] = "";

    char jum[5] = ". ";
    char slash[5] = " / ";

   if ((preference_is_existing("numrecord", &existing) == 0) && existing) {
         preference_get_int("numrecord", &count);
         //dlog_print(DLOG_INFO, "2ResetClicked", "count : %d", count);
   }
   //dlog_print(DLOG_INFO, "3ResetClicked", "end input record function");

   if (count >= 1) {
      for (int i = 1; i <= count; i++) {
         int time_value = 0;
         int total_value = 0;
         char clock_time[10] = "";
         char clock_total[10] = "";
         snprintf(num, sizeof(num), "%d", i);
         if ((preference_is_existing(num, &existing) == 0) && existing) {
            preference_get_int(num, &time_value);
            //dlog_print(DLOG_INFO, "4ResetClicked","timevalue, i, num %d %d %s %s", time_value, i, num,calTime(time_value));
             strcat(clock_time, calTime(time_value));
             //dlog_print(DLOG_INFO, "ResetClicked", "clock_time %s", clock_time);
         }
         //dlog_print(DLOG_INFO, "ResetClicked", "2clock_timee %s", clock_time);
         snprintf(total, sizeof(total), "%d", i * 100);
         if ((preference_is_existing(total, &existing) == 0) && existing) {
            preference_get_int(total, &total_value);
            //dlog_print(DLOG_INFO, "5ResetClicked","totalvalue, i, num %d %d %s %s", total_value, i, total,calTime(total_value));
            //dlog_print(DLOG_INFO, "ResetClicked", "3clock_timee %s", clock_time);
            strcat(clock_total,calTime(total_value));
            //dlog_print(DLOG_INFO, "ResetClicked", "4clock_timee %s", clock_time);
            //dlog_print(DLOG_INFO, "ResetClicked", "clock_total %s", clock_total);
         }

         //dlog_print(DLOG_INFO, "ResetClicked", "5clock_timee %s", clock_time);
         //   "1. xx:xx:xx / yy:yy:yy",

         //sprintf(time_record_contents[i-1], "%s%s%s%s%s",num,jum,clock_time,   slash, clock_total);
         sprintf(time_record_contents[i-1], "%s%s%s\n%s%s",num,jum,clock_time,slash,clock_total);

         //dlog_print(DLOG_INFO, "11ResetClicked", "?? %d ???? %s", i,time_record_contents[i-1]);

      }
   }
}
static void _gl_del(void *data, Evas_Object *obj)
{
   // FIXME: Unrealized callback can be called after this.
   // Accessing Item_Data can be dangerous on unrealized callback.
   item_data *id = data;
   if (id) free(id);
}


void create_list_view(appdata_s *ad)
{
   Evas_Object *genlist = NULL;
   Evas_Object *naviframe = ad->naviframe;
   Elm_Object_Item *nf_it = NULL;
   Elm_Genlist_Item_Class *itc = elm_genlist_item_class_new();
   Elm_Genlist_Item_Class *titc = elm_genlist_item_class_new();
   Elm_Genlist_Item_Class *pitc = elm_genlist_item_class_new();
   item_data *id = NULL;
   int index = 0;

   // Genlist
   genlist = elm_genlist_add(naviframe);
   elm_genlist_mode_set(genlist, ELM_LIST_COMPRESS);

   ad->circle_genlist = eext_circle_object_genlist_add(genlist,ad->circle_surface);
   eext_circle_object_genlist_scroller_policy_set(ad->circle_genlist,ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
   eext_rotary_object_event_activated_set(ad->circle_genlist, EINA_TRUE);

   // Genlist item style
   itc->item_style = "default";
   itc->func.text_get = _gl_main_text_get;
   itc->func.del = _gl_del;

   // Genlist title item style
   titc->item_style = "title";
   titc->func.text_get = _gl_title_text_get;
   titc->func.del = _gl_del;

   // Genlist padding item style
   pitc->item_style = "padding";

   // Title item here
   elm_genlist_item_append(genlist, titc, NULL, NULL, ELM_GENLIST_ITEM_NONE,NULL, ad);

   // Main menu items here
   id = calloc(sizeof(item_data), 1);
   id->index = index++;
   id->item = elm_genlist_item_append(genlist, itc, id, NULL,ELM_GENLIST_ITEM_NONE, NULL, ad);
   id = calloc(sizeof(item_data), 1);
   id->index = index++;
   id->item = elm_genlist_item_append(genlist, itc, id, NULL,ELM_GENLIST_ITEM_NONE, NULL, ad);
   id = calloc(sizeof(item_data), 1);
   id->index = index++;
   id->item = elm_genlist_item_append(genlist, itc, id, NULL,ELM_GENLIST_ITEM_NONE, NULL, ad);
   id = calloc(sizeof(item_data), 1);
   id->index = index++;
   id->item = elm_genlist_item_append(genlist, itc, id, NULL,ELM_GENLIST_ITEM_NONE, NULL, ad);
   id = calloc(sizeof(item_data), 1);
   id->index = index++;
   id->item = elm_genlist_item_append(genlist, itc, id, NULL,ELM_GENLIST_ITEM_NONE, NULL, ad);

   // Padding item here
   elm_genlist_item_append(genlist, pitc, NULL, NULL, ELM_GENLIST_ITEM_NONE,NULL, ad);

   nf_it = elm_naviframe_item_push(ad->naviframe, NULL, NULL, NULL, genlist,"empty");
   //elm_naviframe_item_pop_cb_set(nf_it, _naviframe_pop_cb, NULL);
}

void create_forth_page(void *data, Evas_Object *obj, void *event_info)
{

      struct appdata *ad = data;
      //Elm_Object_Item *nf_it = NULL;

      //Evas_Object *layout = elm_box_add(ad->naviframe);
      input_record();
      // Eext Circle Surface
      ad->circle_surface = eext_circle_surface_naviframe_add(ad->naviframe);

      // Main View
      create_list_view(ad);

      eext_object_event_callback_add(ad->naviframe, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);
      eext_object_event_callback_add(ad->naviframe, EEXT_CALLBACK_MORE, eext_naviframe_more_cb, NULL);

      //nf_it = elm_naviframe_item_push(ad->naviframe,NULL, NULL, NULL, NULL, NULL);

      // Show the window after the base GUI is set up
      evas_object_show(ad->win);

}
