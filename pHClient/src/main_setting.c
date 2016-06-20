#include "ph1.h"
#include "sockettest.h"
#include "connection.h"
#include "timerecord.h"
#include "autoconnection.h"
#include <device/power.h>
#include <app_preference.h>


typedef struct appdata {
   Evas_Object *win;
   Evas_Object *conform;
   Evas_Object *naviframe;
   Evas_Object *label;
   Evas_Object *button;
   Elm_Object_Item *nf_it;

} appdata_s;


static void win_delete_request_cb(void *data, Evas_Object *obj,void *event_info) {
   ui_app_exit();
}

static Eina_Bool naviframe_pop_cb(void *data, Elm_Object_Item *it) {
   ui_app_exit();
   return EINA_FALSE;
}

static void left_hand_cb(void *data, Evas_Object *obj, void *event_info) {
//   elm_exit();
   struct appdata *ad = data;
   hand = 0;
   elm_object_text_set(ad->button, "<align = center><color=#E1FF36FF>왼손잡이</color></align>");
   preference_set_int("hand", hand);
   // 앞으로 더 추가해야함!!!!
}
static void right_hand_cb(void *data, Evas_Object *obj, void *event_info) {
//   elm_exit();
   struct appdata *ad = data;
   hand = 1;
   elm_object_text_set(ad->button, "<align = center><color=#E1FF36FF>오른손잡이</color></align>");
   preference_set_int("hand", hand);
   // 앞으로 더 추가해야함!!!!
}

void clicked_cb(void *data, Evas_Object *obj, void *event_info) {
   struct appdata *ad = data;
   Elm_Object_Item *nf_it = NULL;
   char buf[PATH_MAX];

   Evas_Object* img1;
   Evas_Object* img2;
   Evas_Object *layout = elm_box_add(ad->naviframe);
   Evas_Object *box = elm_box_add(layout);
   int current_hand =0;;
   bool existing = false;

   elm_box_horizontal_set(box, EINA_FALSE);
   evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
   evas_object_show(box);

   Evas_Object* box1 = elm_box_add(ad->naviframe);
   elm_box_horizontal_set(box1, EINA_TRUE);
   evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, 0.1);

   snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/65.png", PACKAGE);

   img1 = elm_image_add(box1);
   evas_object_size_hint_weight_set(img1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(img1, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_image_file_set(img1, buf, NULL);
   elm_object_content_set(box1, img1);
   evas_object_show(img1);
   evas_object_smart_callback_add(img1, "clicked", left_hand_cb, ad);
   elm_object_part_content_set(box1, "elm.swallow.btn", img1);
   elm_box_pack_end(box1, img1);
   evas_object_show(img1);

   snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/66.png", PACKAGE);

   img2 = elm_image_add(box1);
   evas_object_size_hint_weight_set(img2, EVAS_HINT_EXPAND, 0.3);
   evas_object_size_hint_align_set(img2, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_image_file_set(img2, buf, NULL);
   elm_object_content_set(box1, img2);
   evas_object_show(img2);
   evas_object_smart_callback_add(img2, "clicked", right_hand_cb, ad);
   elm_object_part_content_set(box1, "elm.swallow.btn", img2);
   elm_box_pack_end(box1, img2);
   evas_object_show(img2);


   evas_object_show(box1);
   evas_object_size_hint_weight_set(box1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(box1, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_box_pack_end(box, box1);

   ad->label = elm_label_add(box);
   elm_object_style_set(ad->label, "bottom");
   elm_object_text_set(ad->label, "<align = center>현재 설정</align>");
   elm_box_pack_end(box, ad->label);
   evas_object_show(ad->label);
   ad->button = elm_label_add(box);
   elm_object_style_set(ad->button, "bottom");

   if ((preference_is_existing("hand", &existing) == 0) && existing) {
            preference_get_int("hand", &current_hand);
   }
   if (current_hand == 0)
      elm_object_text_set(ad->button, "<align = center><color=#E1FF36FF>왼손잡이</color></align>");
   else if (current_hand == 1)
      elm_object_text_set(ad->button, "<align = center><color=#E1FF36FF>오른손잡이</color></align>");
   elm_box_pack_end(box, ad->button);
   evas_object_show(ad->button);

   Evas_Object* label = elm_label_add(box);
   elm_object_style_set(label, "bottom");
   //elm_object_text_set(label, "<align = center>현재 설정</align>");
   elm_box_pack_end(box, label);
   evas_object_show(label);

   //evas_object_show(box);
   evas_object_show(box);

   nf_it = elm_naviframe_item_push(ad->naviframe,"<color=#F5D6FFFF>Setting</color>", NULL, NULL, box, NULL);

}

static void create_main_gui (void *data, Evas_Object *obj, void *event_info) {
   /* Window */
   appdata_s *ad = data;
   Elm_Object_Item *nf_it;
   Evas_Object *layout;

   char buf[PATH_MAX];
   layout = elm_layout_add(ad->naviframe);
   Evas_Object *box = elm_box_add(ad->naviframe);
   elm_box_horizontal_set(box, EINA_FALSE);
   evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);

   evas_object_show(box);

   Evas_Object* box1 = elm_box_add(ad->naviframe);
   elm_box_horizontal_set(box1, EINA_TRUE);
   evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, 0.1);

   snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/71.png", PACKAGE);

   Evas_Object *img1 = elm_image_add(box1);
   evas_object_size_hint_weight_set(img1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(img1, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_image_file_set(img1, buf, NULL);
   elm_object_content_set(box1, img1);
   evas_object_show(img1);

   elm_object_part_content_set(layout, "elm.swallow.btn", img1);

   elm_box_pack_end(box1, img1);
   evas_object_show(img1);

   snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/74.png", PACKAGE);

   Evas_Object *img2 = elm_image_add(box1);
   evas_object_size_hint_weight_set(img2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(img2, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_image_file_set(img2, buf, NULL);
   elm_object_content_set(box1, img2);
   evas_object_show(img2);

   elm_object_part_content_set(layout, "elm.swallow.btn", img2);

   elm_box_pack_end(box1, img2);
   evas_object_show(img2);

   evas_object_show(box1);
   evas_object_size_hint_weight_set(box1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(box1, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_box_pack_end(box, box1);


   Evas_Object* box3 = elm_box_add(ad->naviframe);
   elm_box_horizontal_set(box3, EINA_TRUE);
   evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, 0.1);

   snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/72.png", PACKAGE);

   Evas_Object *img5 = elm_image_add(box3);
   evas_object_size_hint_weight_set(img5, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(img5, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_image_file_set(img5, buf, NULL);
   elm_object_content_set(box3, img5);
   evas_object_show(img5);

   elm_object_part_content_set(layout, "elm.swallow.btn", img5);

   elm_box_pack_end(box3, img5);
   evas_object_show(img5);

   evas_object_show(box3);
   evas_object_size_hint_weight_set(box3, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(box3, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_box_pack_end(box, box3);

   Evas_Object* box2 = elm_box_add(ad->naviframe);
   elm_box_horizontal_set(box2, EINA_TRUE);

   snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/73.png", PACKAGE);

   Evas_Object *img3 = elm_image_add(box2);
   evas_object_size_hint_weight_set(img3, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(img3, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_object_style_set(img3, "bottom");
   elm_image_file_set(img3, buf, NULL);
   elm_object_content_set(box2, img3);
   evas_object_show(img3);

   elm_object_part_content_set(layout, "elm.swallow.btn", img3);

   elm_box_pack_end(box2, img3);
   evas_object_show(img3);

//////////////////////////////////////////////////////////
   snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/75.png", PACKAGE);

   Evas_Object *img4 = elm_image_add(box2);
   evas_object_size_hint_weight_set(img4, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(img4,EVAS_HINT_FILL,EVAS_HINT_FILL);
   elm_image_file_set(img4, buf, NULL);
   elm_object_content_set(box2, img4);
   evas_object_show(img4);

   elm_object_part_content_set(layout, "elm.swallow.btn", img4);

   evas_object_smart_callback_add(img5, "clicked", create_third_page, ad);
   evas_object_smart_callback_add(img2, "clicked", create_forth_page, ad);
   evas_object_smart_callback_add(img1, "clicked", create_fifth_page, ad);
   evas_object_smart_callback_add(img3, "clicked", clicked_cb, ad);
   evas_object_smart_callback_add(img4, "clicked", create_second_page, ad);

   elm_box_pack_end(box2, img4);
   evas_object_show(img4);

   evas_object_show(box2);
   evas_object_size_hint_weight_set(box2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(box2, EVAS_HINT_FILL, EVAS_HINT_FILL);
   elm_box_pack_end(box, box2);

//   nf_it = elm_naviframe_item_push(ad->naviframe, "잉?", NULL, NULL, box, NULL);

   nf_it = elm_naviframe_item_push(ad->naviframe,NULL,NULL,NULL,box,NULL);
   elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);
   elm_naviframe_item_pop_cb_set(nf_it, naviframe_pop_cb, NULL);
}


void create_popup (appdata_s *ad)
{
	   Evas_Object *popup;
	   popup = elm_popup_add(ad->conform);
	   elm_object_style_set(popup, "circle");
	   Evas_Object *layout = elm_layout_add(popup);
	   elm_layout_theme_set(layout, "layout", "popup", "content/circle");
	   evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	   Evas_Object *pop = elm_image_add(popup);
	   char buf[PATH_MAX];
	   snprintf(buf, sizeof(buf), "/opt/usr/apps/%s/res/images/logo.png", PACKAGE);
	   elm_image_file_set(pop, buf, NULL);
	   evas_object_show(pop);
	   evas_object_size_hint_align_set(pop, EVAS_HINT_FILL, EVAS_HINT_FILL);
	   evas_object_size_hint_weight_set(pop, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	   elm_object_part_content_set(layout, "elm.swallow.content", pop);
	   elm_object_content_set(popup, layout);
	   evas_object_show(popup);
	   elm_popup_timeout_set(popup, 2.0);

	   evas_object_smart_callback_add(popup, "timeout", create_main_gui, ad);
}


static void create_base_gui(void* data) {
	/* Window */
	appdata_s *ad = data;
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win,
				(const int *) (&rots), 4);
	}
	evas_object_smart_callback_add(ad->win, "delete,request",
			win_delete_request_cb, NULL);
	//      eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);
	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	//   elm_layout_theme_set(layout,)
	ad->naviframe = elm_naviframe_add(ad->conform);

	eext_object_event_callback_add(ad->naviframe, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);
	elm_object_content_set(ad->conform, ad->naviframe);
	evas_object_show(ad->conform);
	create_popup (ad);

	evas_object_show(ad->win);
}


static bool app_create(void *data) {
   /* Hook to take necessary actions before main event loop starts
    Initialize UI resources and application's data
    If this function returns true, the main loop of application starts
    If this function returns false, the application is terminated */
   hand = 0;
   create_base_gui(data);

   return true;
}

static void app_control(app_control_h app_control, void *data) {
   /* Handle the launch request. */
}

static void app_pause(void *data) {
   /* Take necessary actions when application becomes invisible. */
   device_power_release_lock(POWER_LOCK_DISPLAY);
}


static void app_resume(void *data) {
   /* Take necessary actions when application becomes visible. */
   device_power_request_lock(POWER_LOCK_DISPLAY, 0);

}



static void app_terminate(void *data) {
   /* Release all resources. */
}

static void ui_app_lang_changed(app_event_info_h event_info, void *user_data) {
   /*APP_EVENT_LANGUAGE_CHANGED*/
   char *locale = NULL;
   system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE,
         &locale);
   elm_language_set(locale);
   free(locale);
   return;
}

static void ui_app_orient_changed(app_event_info_h event_info, void *user_data) {
   /*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
   return;
}

static void ui_app_region_changed(app_event_info_h event_info, void *user_data) {
   /*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void ui_app_low_battery(app_event_info_h event_info, void *user_data) {
   /*APP_EVENT_LOW_BATTERY*/
}

static void ui_app_low_memory(app_event_info_h event_info, void *user_data) {
   /*APP_EVENT_LOW_MEMORY*/
}

int main(int argc, char *argv[]) {
   appdata_s ad = { 0, };
   int ret = 0;

   ui_app_lifecycle_callback_s event_callback = { 0, };
   app_event_handler_h handlers[5] = { NULL, };

   event_callback.create = app_create;
   event_callback.terminate = app_terminate;
   event_callback.pause = app_pause;
   event_callback.resume = app_resume;


   event_callback.app_control = app_control;

   ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY],
         APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
   ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY],
         APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
   ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED],
         APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
   ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
         APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
   ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
         APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
   ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

   ret = ui_app_main(argc, argv, &event_callback, &ad);
   if (ret != APP_ERROR_NONE) {
      //dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
   }

   return ret;
}
