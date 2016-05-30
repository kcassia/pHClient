#ifndef __timerecord_H__
#define __timerecord_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "timerecord"

#if !defined(PACKAGE)
#define PACKAGE "org.example.timerecord"
#endif

void create_forth_page(void *data, Evas_Object *obj, void *event_info);
void input_record();

#endif /* __timerecord_H__ */
