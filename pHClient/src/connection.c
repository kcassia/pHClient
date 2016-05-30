#include "connection.h"
#include "ph1.h"
#include "timerecord.h"
#include "sockettest.h"
#include <string.h>
#include <stdio.h>
#include <dlog.h>

typedef struct appdata {
   Evas_Object *win;
   Evas_Object *conform;
   Evas_Object *naviframe;
   Evas_Object *label;
   Elm_Object_Item *nf_it;
} appdata_s;

Evas_Object *ipEntry1;
Evas_Object *ipEntry2;
Evas_Object *ipEntry3;
Evas_Object *ipEntry4;
Evas_Object *portEntry;

const char *ipEntry_1;
const char *ipEntry_2;
const char *ipEntry_3;
const char *ipEntry_4;
const char *port_final;



void _connect_button_click_cb(void *data, Evas_Object *connect_button, void *ev) {
   int check = -1;
   //int autoCheck =0;
   char ip_final[16] = { 0, };

   ipEntry_1 = elm_entry_entry_get(ipEntry1);
   ipEntry_2 = elm_entry_entry_get(ipEntry2);
   ipEntry_3 = elm_entry_entry_get(ipEntry3);
   ipEntry_4 = elm_entry_entry_get(ipEntry4);

   strcpy(ip_final, ipEntry_1);
   strcat(ip_final, ".");
   strcat(ip_final, ipEntry_2);
   strcat(ip_final, ".");
   strcat(ip_final, ipEntry_3);
   strcat(ip_final, ".");
   strcat(ip_final, ipEntry_4);

   port_final = elm_entry_entry_get(portEntry);

   //dlog_print(DLOG_DEBUG, "IP", ip_final);
   //dlog_print(DLOG_DEBUG, "PORT", port_final);

   check = inputIP(&ip_final);
   initiate();

   if(check == 2){
      elm_object_text_set(connect_button, "Connected");
   }

   remote_control_cb(1);

}

void create_second_page(void *data, Evas_Object *connect_button, void *ev) {


   struct appdata *ad = data;
   Elm_Object_Item *nf_it = NULL;

   Evas_Object *layout = elm_layout_add(ad->naviframe);

   // Outer Box
   Evas_Object* box = elm_box_add(layout);
   evas_object_size_hint_weight_set(box, EVAS_HINT_FILL, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_box_align_set(box, 0.5, 0.5);

   // Port Box
   Evas_Object* box2 = elm_box_add(layout);
   elm_box_horizontal_set(box2, EINA_TRUE);

   // Port Label
   Evas_Object* portLabel = elm_label_add(box);
   elm_object_text_set(portLabel, "<align = center>Port </align>");
   elm_box_pack_end(box2, portLabel);
   evas_object_show(portLabel);

   // Port Entry
   portEntry = elm_entry_add(box2);
   elm_entry_entry_set(portEntry, "7777");
   elm_entry_single_line_set(portEntry, EINA_FALSE);
   elm_entry_line_wrap_set(portEntry, ELM_WRAP_NONE);
   static Elm_Entry_Filter_Limit_Size portLimit_size = { .max_char_count = 5,
.max_byte_count = 0 };
   elm_entry_markup_filter_append(portEntry, elm_entry_filter_limit_size,
         &portLimit_size);
   elm_box_pack_end(box2, portEntry);
   evas_object_show(portEntry);

   evas_object_show(box2);
   evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, 0.3);
   evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_box_pack_end(box, box2);

   // IP Box
   Evas_Object* box1 = elm_box_add(layout);
   elm_box_horizontal_set(box1, EINA_TRUE);

   // IP Label
   Evas_Object* ipLabel = elm_label_add(box1);
   elm_object_text_set(ipLabel, "<align = center>IP </align>");
   elm_box_pack_end(box1, ipLabel);
   evas_object_show(ipLabel);

   static Elm_Entry_Filter_Limit_Size ipLimit_size = { .max_char_count = 3, // 3글자 까지
         .max_byte_count = 0 };

   // IP Entry
   ipEntry1 = elm_entry_add(box1);
   //elm_entry_entry_set(ipEntry1, "127");
   elm_entry_single_line_set(ipEntry1, EINA_FALSE);
   elm_entry_line_wrap_set(ipEntry1, ELM_WRAP_NONE);
   elm_entry_markup_filter_append(ipEntry1, elm_entry_filter_limit_size,
         &ipLimit_size);
   elm_box_pack_end(box1, ipEntry1);
   evas_object_show(ipEntry1);

   // IP Label
   Evas_Object* ipPeriod1 = elm_label_add(box1);
   elm_object_text_set(ipPeriod1, "<align = center>.</align>");
   elm_box_pack_end(box1, ipPeriod1);
   evas_object_show(ipPeriod1);

   // IP Entry
   ipEntry2 = elm_entry_add(box1);
   //elm_entry_entry_set(ipEntry2, "  0");
   elm_entry_single_line_set(ipEntry2, EINA_FALSE);
   elm_entry_line_wrap_set(ipEntry2, ELM_WRAP_NONE);
   elm_entry_markup_filter_append(ipEntry2, elm_entry_filter_limit_size,
         &ipLimit_size);
   elm_box_pack_end(box1, ipEntry2);
   evas_object_show(ipEntry2);

   // IP Label
   Evas_Object* ipPeriod2 = elm_label_add(box1);
   elm_object_text_set(ipPeriod2, "<align = center>.</align>");
   elm_box_pack_end(box1, ipPeriod2);
   evas_object_show(ipPeriod2);

   // IP Entry
   ipEntry3 = elm_entry_add(box1);
   //elm_entry_entry_set(ipEntry3, "  0");
   elm_entry_single_line_set(ipEntry3, EINA_FALSE);
   elm_entry_line_wrap_set(ipEntry3, ELM_WRAP_NONE);
   elm_entry_markup_filter_append(ipEntry3, elm_entry_filter_limit_size,
         &ipLimit_size);
   elm_box_pack_end(box1, ipEntry3);
   evas_object_show(ipEntry3);

   // IP Label
   Evas_Object* ipPeriod3 = elm_label_add(box1);
   elm_object_text_set(ipPeriod3, "<align = center>.</align>");
   elm_box_pack_end(box1, ipPeriod3);
   evas_object_show(ipPeriod3);

   // IP Entry
   ipEntry4 = elm_entry_add(box1);
   //elm_entry_entry_set(ipEntry4, "  1");
   elm_entry_single_line_set(ipEntry4, EINA_FALSE);
   elm_entry_line_wrap_set(ipEntry4, ELM_WRAP_NONE);
   elm_entry_markup_filter_append(ipEntry4, elm_entry_filter_limit_size,
         &ipLimit_size);
   elm_box_pack_end(box1, ipEntry4);
   evas_object_show(ipEntry4);

   evas_object_show(box1);
   evas_object_size_hint_weight_set(box1, EVAS_HINT_EXPAND, 0.3);
   evas_object_size_hint_align_set(box1, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_box_pack_end(box, box1);

   // Connect Button
   Evas_Object* connection_button = elm_button_add(box);
   elm_object_style_set(connection_button, "bottom");
   elm_object_text_set(connection_button, "Connection");
   elm_object_part_content_set(layout, "elm.swallow.button", connection_button);
   //evas_object_size_hint_weight_set(connection_button, EVAS_HINT_EXPAND, 1.0);
   evas_object_size_hint_align_set(connection_button, EVAS_HINT_FILL, EVAS_HINT_FILL);
   evas_object_smart_callback_add(connection_button, "clicked", _connect_button_click_cb, NULL);
   elm_box_pack_end(box, connection_button);

   evas_object_show(connection_button);

   evas_object_show(box);

   elm_entry_input_panel_layout_set(ipEntry1,ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);
   elm_entry_input_panel_layout_set(ipEntry2,ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);
   elm_entry_input_panel_layout_set(ipEntry3,ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);
   elm_entry_input_panel_layout_set(ipEntry4,ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);
   elm_entry_input_panel_layout_set(portEntry,ELM_INPUT_PANEL_LAYOUT_NUMBERONLY);

   nf_it = elm_naviframe_item_push(ad->naviframe,"<color=#F5D6FFFF>Connection</color>", NULL, NULL, box, NULL);

//   evas_object_show(ad->win);
}
