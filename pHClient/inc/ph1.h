#ifndef __ph1_H__
#define __ph1_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "ph1"

#if !defined(PACKAGE)
#define PACKAGE "org.example.ph1"
#endif

int hand;
void clicked_cb(void *data, Evas_Object *obj, void *event_info);
void layout_back_cb (void *data, Evas_Object *obj, void *event_info);
//void create_base_gui(void *data);

#endif /* __ph1_H__ */
