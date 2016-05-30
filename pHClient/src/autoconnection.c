#include "connection.h"
#include "ph1.h"
#include "timerecord.h"
#include "sockettest.h"
#include "autoconnection.h"
#include <string.h>
#include <stdio.h>
#include <dlog.h>

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *naviframe;
	Eext_Circle_Surface *circle_surface;
	Evas_Object *circle_progressbar;
	Evas_Object *label;
	Elm_Object_Item *nf_it;
} appdata_s;


Evas_Object *progressbar;
char ip_final[16] = { 0, };


void _auto_connect_button_click_cb(void *data, Evas_Object *connect_button, void *ev) {


	int autoCheck = 0;

	//dlog_print(DLOG_DEBUG, "IP", ip_final);

	initiate();
	autoCheck = findIp();


	if(autoCheck == 1 ){
		elm_object_text_set(connect_button, "Connected");
		elm_progressbar_pulse(progressbar, EINA_FALSE);
	}else{
		elm_object_text_set(connect_button, "Auto Connect");
	}

	remote_control_cb(1);

}

void create_fifth_page(void *data, Evas_Object *connect_button, void *ev) {

   struct appdata *ad = data;
   Elm_Object_Item *nf_it = NULL;

   Evas_Object *layout = elm_layout_add(ad->naviframe);
   evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   elm_layout_theme_set(layout, "layout", "bottom_button", "default");
   evas_object_show(layout);

   progressbar = elm_progressbar_add(layout);
   elm_object_style_set(progressbar, "process/small");
   elm_object_part_content_set(layout, "elm.swallow.content", progressbar);
   elm_progressbar_pulse_set(progressbar, EINA_TRUE);
   elm_progressbar_pulse(progressbar, EINA_TRUE);
   evas_object_show(progressbar);

   Evas_Object* connection_button = elm_button_add(layout);
   elm_object_style_set(connection_button, "bottom");
   elm_object_text_set(connection_button, "Auto Connect");

   elm_object_part_content_set(layout, "elm.swallow.button", connection_button);
   evas_object_smart_callback_add(connection_button, "clicked", _auto_connect_button_click_cb, NULL);
   evas_object_show(connection_button);



   nf_it = elm_naviframe_item_push(ad->naviframe,"<color=#F5D6FFFF>Auto Connection</color>", NULL, NULL, layout, NULL);
}


