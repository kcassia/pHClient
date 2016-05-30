/*
 * timer.h
 *
 *  Created on: May 10, 2016
 *      Author: ajou
 */


/*
 * Samsung API
 * Copyright (c) 2009-2015 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include "connection.h"
#include "ph1.h"
#include "timerecord.h"
#include "sockettest.h"
#include "autoconnection.h"
#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "timer"

#if !defined(PACKAGE)
#define PACKAGE "org.tizen.rotary-timer"
#endif

#define TIMER_EDJ "/edje/timer.edj"
#define GRP_MAIN "main"
#define RES_DIR "/usr/apps/org.tizen.rotary-timer/res"
#define CONTROL_DOT "/time_picker_control_dot.png"
#define MAX_PATH_LEN 1024

typedef enum {
      SAMPLE_APP_ERROR_OK = 0,
      SAMPLE_APP_ERROR_FAIL = -1,

      SAMPLE_APP_ERROR_INVALID_PARAMETER = -2,
      SAMPLE_APP_ERROR_OUT_OF_MEMORY = -3,
      SAMPLE_APP_ERROR_NO_DATA = -4,
} sample_app_error_e;
