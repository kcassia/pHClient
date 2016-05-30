S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 18036
Date: 2016-05-29 14:40:15+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2f656a64

Register Information
r0   = 0x00000000, r1   = 0x41431708
r2   = 0x41431700, r3   = 0x00000000
r4   = 0x6c706d61, r5   = 0x68702e65
r6   = 0x65722f31, r7   = 0x652f2f73
r8   = 0x419420a0, r9   = 0x41887088
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4142def4, sp   = 0xbee69658
lr   = 0x400953f8, pc   = 0x2f656a64
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     13508 KB
Buffers:     50128 KB
Cached:     113200 KB
VmPeak:      83100 KB
VmSize:      51452 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19812 KB
VmRSS:       17076 KB
VmData:      25520 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       18704 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18036 TID = 18036
18036 18102 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40055000 40061000 r-xp /usr/lib/libaul.so.0.1.0
4006b000 4006d000 r-xp /lib/libdl-2.13.so
40076000 40079000 r-xp /usr/lib/libbundle.so.0.1.22
40081000 40083000 r-xp /usr/lib/libdlog.so.0.0.0
4008b000 4009f000 r-xp /lib/libpthread-2.13.so
400aa000 401e4000 r-xp /usr/lib/libelementary.so.1.7.99
401fa000 402c8000 r-xp /usr/lib/libevas.so.1.7.99
402ed000 40304000 r-xp /usr/lib/libecore.so.1.7.99
4031b000 40378000 r-xp /usr/lib/libedje.so.1.7.99
40382000 40452000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40453000 40459000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40461000 40464000 r-xp /usr/lib/libsmack.so.1.0.0
4046c000 40474000 r-xp /lib/libgcc_s-4.6.so.1
40475000 40590000 r-xp /lib/libc-2.13.so
4059e000 405da000 r-xp /usr/lib/libsystemd.so.0.4.0
405e3000 405ee000 r-xp /lib/libunwind.so.8.0.1
4061b000 40632000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4063a000 40664000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066d000 40672000 r-xp /usr/lib/libxdgmime.so.1.1.0
4067a000 4069c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a4000 406a7000 r-xp /usr/lib/libproc-stat.so.0.2.86
406af000 406b5000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406be000 40727000 r-xp /lib/libm-2.13.so
40730000 40749000 r-xp /usr/lib/libeet.so.1.7.99
4075a000 4079b000 r-xp /usr/lib/libeina.so.1.7.99
407a4000 407c6000 r-xp /usr/lib/libecore_evas.so.1.7.99
407cf000 407d4000 r-xp /usr/lib/libecore_file.so.1.7.99
407dc000 407ed000 r-xp /usr/lib/libecore_input.so.1.7.99
407f5000 407f9000 r-xp /usr/lib/libvconf.so.0.2.45
40801000 40851000 r-xp /usr/lib/libecore_x.so.1.7.99
40853000 4085c000 r-xp /usr/lib/libedbus.so.1.7.99
40864000 4087e000 r-xp /usr/lib/libecore_con.so.1.7.99
40887000 4089a000 r-xp /usr/lib/libfribidi.so.0.3.1
408a2000 408df000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a58000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a60000 40a63000 r-xp /lib/libcap.so.2.21
40a6b000 40a83000 r-xp /usr/lib/liblzma.so.5.0.3
40a8b000 40b07000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b13000 40b23000 r-xp /lib/libresolv-2.13.so
40b27000 40bfa000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40c05000 40c39000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c42000 40c58000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c60000 40cd5000 r-xp /usr/lib/libsqlite3.so.0.8.6
40cdf000 40cf5000 r-xp /lib/libz.so.1.2.5
40cfd000 40d20000 r-xp /usr/lib/libjpeg.so.8.0.2
40d38000 40e19000 r-xp /usr/lib/libX11.so.6.3.0
40e24000 40e29000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e32000 40e36000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e3f000 40e42000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e4a000 40e51000 r-xp /usr/lib/libXcursor.so.1.0.2
40e59000 40e5b000 r-xp /usr/lib/libXdamage.so.1.1.0
40e63000 40e65000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e6d000 40e6f000 r-xp /usr/lib/libXgesture.so.7.0.0
40e77000 40e7a000 r-xp /usr/lib/libXfixes.so.3.1.0
40e82000 40e8b000 r-xp /usr/lib/libXi.so.6.1.0
40e93000 40e94000 r-xp /usr/lib/libXinerama.so.1.0.0
40e9d000 40ea3000 r-xp /usr/lib/libXrandr.so.2.2.0
40eab000 40eb1000 r-xp /usr/lib/libXrender.so.1.3.0
40eb9000 40ebd000 r-xp /usr/lib/libXtst.so.6.1.0
40ec5000 40ecf000 r-xp /usr/lib/libXext.so.6.4.0
40ed8000 40f1c000 r-xp /usr/lib/libcurl.so.4.3.0
40f25000 40f3b000 r-xp /lib/libexpat.so.1.5.2
40f45000 40f5d000 r-xp /usr/lib/libpng12.so.0.50.0
40f65000 40f82000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f8b000 4101f000 r-xp /usr/lib/libstdc++.so.6.0.16
41033000 41036000 r-xp /lib/libattr.so.1.1.0
4103e000 41049000 r-xp /usr/lib/libgpg-error.so.0.15.0
41051000 41052000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4105a000 4105f000 r-xp /usr/lib/libffi.so.5.0.10
41067000 41069000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41072000 4113e000 r-xp /usr/lib/libxml2.so.2.7.8
4114b000 4114d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41156000 41158000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41160000 41173000 r-xp /usr/lib/libxcb.so.1.1.0
4117d000 41186000 r-xp /usr/lib/libcares.so.2.1.0
4118f000 411bd000 r-xp /usr/lib/libidn.so.11.5.44
411c5000 41212000 r-xp /usr/lib/libssl.so.1.0.0
4121e000 413c6000 r-xp /usr/lib/libcrypto.so.1.0.0
413df000 413e1000 r-xp /usr/lib/libiri.so
413ea000 413f1000 r-xp /lib/libcrypt-2.13.so
41421000 41423000 r-xp /usr/lib/libXau.so.6.0.0
41530000 41534000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41545000 4154a000 r-xp /usr/lib/libappcore-common.so.1.1
41552000 41554000 r-xp /usr/lib/libiniparser.so.0
41572000 41576000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4157f000 41581000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4158a000 41590000 r-xp /usr/lib/libappsvc.so.0.1.0
41598000 415bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415c5000 41694000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416aa000 416b4000 r-xp /lib/libnss_files-2.13.so
41b96000 41b9d000 r-xp /usr/lib/libtbm.so.1.0.0
41e39000 41e41000 r-xp /usr/lib/libdrm.so.2.4.0
433eb000 433ed000 r-xp /usr/lib/libdri2.so.0.0.0
43436000 43500000 r-xp /usr/lib/libCOREGL.so.4.0
43857000 4385b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44092000 44891000 rwxp [stack:18102]
bee49000 bee6a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:18036)
Call Stack Count: 1
 0: (0x2f656a64) (null)
End of Call Stack

Package Information
Package Name: org.example.ph1
Package ID : org.example.ph1
Version: 0.9.0
Package Type: rpm
App Name: pH
App ID: org.example.ph1
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
et: 0x0)
05-29 14:39:24.345+0900 W/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 14:39:24.345+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 14:39:24.345+0900 I/HIGEAR  ( 1102): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 14:39:24.405+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 14:39:24.405+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 14:39:24.405+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 14:39:24.405+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 14:39:24.420+0900 I/APP_CORE(18036): appcore-efl.c: __do_app(429) > [APP 18036] Event: PAUSE State: RUNNING
05-29 14:39:24.420+0900 I/CAPI_APPFW_APPLICATION(18036): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 14:39:24.420+0900 I/SCREENTEST(18036): start_screen = 0
05-29 14:39:24.480+0900 E/ALARM_MANAGER(  682): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 14:39:44), repeat(1), interval(20), type(-1073741822)
05-29 14:39:24.495+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:39:24.495+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:39:24.540+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 14:39:24.545+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 14:39:24.545+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 14:39:24.570+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 27224275, next duetime: 1464500384
05-29 14:39:24.570+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(27224275)
05-29 14:39:24.570+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464500510), due_time(1464500384)
05-29 14:39:24.570+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:39:24.570+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:39:44 (UTC).
05-29 14:39:24.570+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:39:24.885+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 14:39:24.885+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 14:39:24.895+0900 I/RESOURCED(  488): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-29 14:39:26.310+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-29 14:39:26.335+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
05-29 14:39:26.360+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-29 14:39:26.360+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-29 14:39:26.360+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 14:39:26.360+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 14:39:26.360+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 14:39:26.365+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-29 14:39:26.365+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-29 14:39:26.365+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 14:39:26.365+0900 W/W_HOME  (  714): gesture.c: _apps_status_get(123) > apps status:0
05-29 14:39:26.365+0900 W/W_HOME  (  714): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:2167
05-29 14:39:26.365+0900 W/W_HOME  (  714): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-29 14:39:26.365+0900 W/W_HOME  (  714): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-29 14:39:26.365+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:39:26.370+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [2167]ms
05-29 14:39:26.370+0900 W/STARTER (  682): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-29 14:39:26.390+0900 I/APP_CORE(18036): appcore-efl.c: __do_app(429) > [APP 18036] Event: RESUME State: PAUSED
05-29 14:39:26.390+0900 I/CAPI_APPFW_APPLICATION(18036): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 14:39:26.390+0900 I/SCREENTEST(18036): start_screen = 0
05-29 14:39:26.415+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:39:26.420+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:39:26.420+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(27224275)
05-29 14:39:26.420+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:39:26.420+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:41:50 (UTC).
05-29 14:39:26.420+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:39:26.420+0900 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[27224275] is removed.
05-29 14:39:26.465+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-29 14:39:26.465+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-29 14:39:26.470+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 14:39:26.485+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-29 14:39:26.485+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-29 14:39:26.490+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-29 14:39:26.490+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 14:39:26.525+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 14:39:26.530+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 14:39:26.530+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 14:39:26.530+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-29 14:39:26.530+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:39:26.530+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:39:26.530+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-29 14:39:26.530+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:39:26.530+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:39:26.530+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-29 14:39:26.565+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-29 14:39:26.565+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 0
05-29 14:39:27.850+0900 E/EFL     (18036): evas_main<18036> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=18748326 button=1 downs=1
05-29 14:39:27.905+0900 E/EFL     (18036): evas_main<18036> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=18748384 button=1 downs=0
05-29 14:39:27.905+0900 E/SCREENTEST(18036): start_screen = 1
05-29 14:39:27.925+0900 D/TIMER   (18036): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-29 14:39:27.925+0900 D/TIMER   (18036): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-29 14:39:27.995+0900 I/efl-extension(18036): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 14:39:27.995+0900 I/efl-extension(18036): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-29 14:39:27.995+0900 I/efl-extension(18036): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-29 14:39:27.995+0900 I/efl-extension(18036): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-29 14:39:28.005+0900 I/efl-extension(18036): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41923100, elm_layout, _activated_obj : 0x0, activated : 1
05-29 14:39:41.470+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 14:39:42.490+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 14:39:42.500+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 14:39:42.505+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 14:39:42.505+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 1
05-29 14:39:42.505+0900 W/W_HOME  (  714): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 14:39:42.505+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:39:42.510+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-29 14:39:42.510+0900 W/STARTER (  682): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 14:39:42.520+0900 E/STARTER (  682): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 14:39:42.520+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 14:39:42.520+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 14:39:42.590+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 14:39:42.590+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 14:39:42.590+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 14:39:42.590+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 14:39:42.605+0900 I/APP_CORE(18036): appcore-efl.c: __do_app(429) > [APP 18036] Event: PAUSE State: RUNNING
05-29 14:39:42.610+0900 I/CAPI_APPFW_APPLICATION(18036): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 14:39:42.610+0900 I/SCREENTEST(18036): start_screen = 1
05-29 14:39:42.625+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 14:39:42.650+0900 E/ALARM_MANAGER(  682): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 14:40:03), repeat(1), interval(20), type(-1073741822)
05-29 14:39:42.670+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 14:39:42.675+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 14:39:42.675+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 14:39:42.675+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 14:39:42.675+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 14:39:42.690+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 14:39:42.695+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 14:39:42.695+0900 W/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 14:39:42.695+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 14:39:42.705+0900 I/HIGEAR  ( 1102): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 14:39:42.715+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:39:42.715+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:39:42.785+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 990083000, next duetime: 1464500403
05-29 14:39:42.785+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(990083000)
05-29 14:39:42.785+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464500510), due_time(1464500403)
05-29 14:39:42.785+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:39:42.785+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:40:03 (UTC).
05-29 14:39:42.785+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:39:47.730+0900 I/APP_CORE(18036): appcore-efl.c: __do_app(429) > [APP 18036] Event: MEM_FLUSH State: PAUSED
05-29 14:39:56.040+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-29 14:39:56.075+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
05-29 14:39:56.090+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-29 14:39:56.090+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-29 14:39:56.090+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 14:39:56.090+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 14:39:56.090+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 14:39:56.095+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-29 14:39:56.095+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-29 14:39:56.095+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 14:39:56.095+0900 W/W_HOME  (  714): gesture.c: _apps_status_get(123) > apps status:0
05-29 14:39:56.095+0900 W/W_HOME  (  714): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:13675
05-29 14:39:56.095+0900 W/W_HOME  (  714): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-29 14:39:56.095+0900 W/W_HOME  (  714): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-29 14:39:56.095+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:39:56.100+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [13675]ms
05-29 14:39:56.100+0900 W/STARTER (  682): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-29 14:39:56.115+0900 I/APP_CORE(18036): appcore-efl.c: __do_app(429) > [APP 18036] Event: RESUME State: PAUSED
05-29 14:39:56.115+0900 I/CAPI_APPFW_APPLICATION(18036): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 14:39:56.115+0900 I/SCREENTEST(18036): start_screen = 1
05-29 14:39:56.130+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:39:56.130+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:39:56.130+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(990083000)
05-29 14:39:56.130+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:39:56.130+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:41:50 (UTC).
05-29 14:39:56.135+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:39:56.135+0900 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[990083000] is removed.
05-29 14:39:56.185+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-29 14:39:56.185+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-29 14:39:56.190+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 14:39:56.205+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-29 14:39:56.205+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 14:39:56.205+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-29 14:39:56.205+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-29 14:39:56.240+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 14:39:56.240+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 14:39:56.240+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-29 14:39:56.240+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:39:56.240+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:39:56.240+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-29 14:39:56.240+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:39:56.240+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:39:56.240+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-29 14:39:56.295+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-29 14:39:56.295+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 0
05-29 14:40:00.300+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 14:40:00.905+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 14:40:00.910+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 14:40:00.915+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-29 14:40:00.915+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:40:00.920+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:40:00.920+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-29 14:40:00.920+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:40:00.925+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:40:00.925+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-29 14:40:01.440+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 14:40:01.440+0900 I/efl-extension(18036): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 14:40:01.440+0900 I/efl-extension(18036): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x41923100, elm_layout, time_stamp : 18781920
05-29 14:40:01.440+0900 E/TIMER   (18036): (!ad->selected) -> _rotary_cb() return
05-29 14:40:11.895+0900 I/efl-extension(18036): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x41923100
05-29 14:40:11.895+0900 I/efl-extension(18036): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x41923100, obj: 0x41923100
05-29 14:40:11.895+0900 I/efl-extension(18036): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 14:40:11.895+0900 I/efl-extension(18036): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 14:40:11.895+0900 I/efl-extension(18036): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 14:40:11.895+0900 I/efl-extension(18036): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 14:40:12.240+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-29 14:40:12.240+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-29 14:40:12.250+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-29 14:40:12.250+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-29 14:40:12.310+0900 W/STARTER (  682): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-29 14:40:12.400+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-29 14:40:12.400+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-29 14:40:12.405+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-29 14:40:12.405+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-29 14:40:12.510+0900 W/STARTER (  682): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-29 14:40:12.770+0900 W/STARTER (  682): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-29 14:40:12.775+0900 W/STARTER (  682): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-29 14:40:12.820+0900 E/STARTER (  682): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-29 14:40:12.820+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 14:40:12.835+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 682
05-29 14:40:12.840+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 14:40:12.840+0900 W/AUL_PAD (11703): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 14:40:12.840+0900 W/AUL_PAD (11703): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 14:40:12.855+0900 E/RESOURCED(  488): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 14:40:12.860+0900 I/CAPI_APPFW_APPLICATION(17918): app_main.c: app_efl_main(129) > app_efl_main
05-29 14:40:12.865+0900 I/CAPI_APPFW_APPLICATION(17918): app_main.c: app_appcore_create(152) > app_appcore_create
05-29 14:40:12.945+0900 E/AUL     (  682): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 14:40:12.950+0900 E/RESOURCED(  488): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-29 14:40:13.045+0900 I/efl-extension(17918): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445deef0 = w: 0 h: 0  obj 0x445bf388 w: 360 h: 360
05-29 14:40:13.050+0900 I/efl-extension(17918): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 14:40:13.050+0900 I/efl-extension(17918): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 14:40:13.050+0900 I/efl-extension(17918): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-29 14:40:13.050+0900 I/efl-extension(17918): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-29 14:40:13.055+0900 I/efl-extension(17918): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-29 14:40:13.060+0900 I/efl-extension(17918): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445bf388, elm_image, _activated_obj : 0x0, activated : 1
05-29 14:40:13.165+0900 E/W_TASKMANAGER(17918): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-29 14:40:13.170+0900 E/W_TASKMANAGER(17918): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-29 14:40:13.170+0900 E/W_TASKMANAGER(17918): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-29 14:40:13.220+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.225+0900 E/W_TASKMANAGER(17918): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 14:40:13.230+0900 E/RUA     (17918): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 23, ncols : 5
05-29 14:40:13.265+0900 E/EFL     (17918): elementary<17918> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c1008 into part 'elm.swallow.event.0'
05-29 14:40:13.305+0900 E/E17     (  382): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04a00003)
05-29 14:40:13.305+0900 I/APP_CORE(17918): appcore-efl.c: __do_app(429) > [APP 17918] Event: RESET State: CREATED
05-29 14:40:13.305+0900 I/CAPI_APPFW_APPLICATION(17918): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 14:40:13.325+0900 I/APP_CORE(17918): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 14:40:13.325+0900 I/APP_CORE(17918): appcore-efl.c: __do_app(474) > [APP 17918] Initial Launching, call the resume_cb
05-29 14:40:13.325+0900 I/CAPI_APPFW_APPLICATION(17918): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 14:40:13.375+0900 E/E17     (  382): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04a00003)
05-29 14:40:13.385+0900 W/APP_CORE(17918): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4a00003
05-29 14:40:13.460+0900 I/APP_CORE(18036): appcore-efl.c: __do_app(429) > [APP 18036] Event: PAUSE State: RUNNING
05-29 14:40:13.460+0900 I/CAPI_APPFW_APPLICATION(18036): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 14:40:13.460+0900 I/SCREENTEST(18036): start_screen = 1
05-29 14:40:13.480+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 14:40:13.480+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 14:40:13.490+0900 I/APP_CORE(17918): appcore-efl.c: __do_app(429) > [APP 17918] Event: RESUME State: RUNNING
05-29 14:40:13.880+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 14:40:13.925+0900 I/MALI    (17918): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x433d4668] swap changed from async to sync
05-29 14:40:13.960+0900 E/EFL     (17918): evas_main<17918> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=18794427 button=1 downs=1
05-29 14:40:14.000+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:40:14.015+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17918
05-29 14:40:14.020+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 14:40:14.025+0900 E/EFL     (17918): evas_main<17918> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=18794502 button=1 downs=0
05-29 14:40:14.255+0900 E/EFL     (17918): elementary<17918> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44574028), freeze(1)
05-29 14:40:14.255+0900 E/EFL     (17918): elementary<17918> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44574028), freeze(1)
05-29 14:40:14.440+0900 I/efl-extension(18135): efl_extension.c: eext_mod_init(40) > Init
05-29 14:40:14.495+0900 I/UXT     (18135): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-29 14:40:14.610+0900 I/AUL_PAD (18135): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 14:40:14.630+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:40:14.640+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18036
05-29 14:40:14.640+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 27
05-29 14:40:14.645+0900 I/APP_CORE(18036): appcore-efl.c: __do_app(429) > [APP 18036] Event: TERMINATE State: PAUSED
05-29 14:40:14.650+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 14:40:14.650+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 14:40:14.665+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 14:40:14.665+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 14:40:14.665+0900 E/APP_CORE(17918): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 14:40:14.665+0900 I/APP_CORE(17918): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 14:40:14.665+0900 I/APP_CORE(17918): appcore-efl.c: __after_loop(1090) > [APP 17918] PAUSE before termination
05-29 14:40:14.665+0900 I/CAPI_APPFW_APPLICATION(17918): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 14:40:14.665+0900 I/CAPI_APPFW_APPLICATION(17918): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-29 14:40:14.670+0900 I/efl-extension(17918): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44574028, obj: 0x44574028
05-29 14:40:14.670+0900 I/efl-extension(17918): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 14:40:14.670+0900 I/efl-extension(17918): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 14:40:14.670+0900 I/efl-extension(17918): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 14:40:14.670+0900 I/efl-extension(17918): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 14:40:14.680+0900 I/efl-extension(17918): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445bf388
05-29 14:40:14.680+0900 I/efl-extension(17918): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 14:40:14.680+0900 I/efl-extension(17918): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445deef0 is freed
05-29 14:40:14.680+0900 I/efl-extension(17918): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 14:40:14.685+0900 I/efl-extension(17918): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44574028, elm_scroller, func : 0x437eaef1
05-29 14:40:14.685+0900 I/efl-extension(17918): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 14:40:14.685+0900 I/efl-extension(17918): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 14:40:14.685+0900 I/efl-extension(17918): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445bf388, elm_image, func : 0x437eaef1
05-29 14:40:14.685+0900 I/efl-extension(17918): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 14:40:14.685+0900 I/efl-extension(17918): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44574028 : elm_scroller] rotary callabck is deleted
05-29 14:40:14.745+0900 E/TBM     (18135): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 14:40:14.825+0900 I/APP_CORE(18036): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 14:40:14.825+0900 I/CAPI_APPFW_APPLICATION(18036): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-29 14:40:14.840+0900 I/MALI    (17918): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x433d4668] swap changed from sync to async
05-29 14:40:14.875+0900 W/PROCESSMGR(  382): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-29 14:40:14.880+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 14:40:14.880+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:40:14.880+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:40:14.880+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-29 14:40:14.880+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-29 14:40:14.880+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 14:40:14.880+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 14:40:14.880+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 14:40:14.880+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:40:14.880+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 14:40:14.895+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 14:40:14.895+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 14:40:14.895+0900 I/MALI    (17918): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 14:40:14.895+0900 I/MALI    (17918): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=17918   close drm_fd=21 
05-29 14:40:14.895+0900 I/MALI    (17918): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 14:40:14.930+0900 I/UXT     (18036): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 14:40:14.940+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 14:40:14.940+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 14:40:14.940+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:40:14.940+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 14:40:14.940+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
05-29 14:40:14.940+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 14:40:14.940+0900 W/W_HOME  (  714): main.c: _appcore_resume_cb(681) > appcore resume
05-29 14:40:14.940+0900 W/W_HOME  (  714): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-29 14:40:14.940+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:40:14.940+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:40:14.940+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:40:14.940+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 14:40:14.940+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x45d34090
05-29 14:40:14.940+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d34090, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-29 14:40:14.940+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 14:40:14.945+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 14:40:14.945+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 14:40:14.945+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 14:40:14.945+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 14:40:14.945+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 14:40:14.945+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 14:40:14.945+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 14:40:15.020+0900 I/UXT     (17918): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 14:40:15.160+0900 I/efl-extension(18036): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 14:40:15.310+0900 I/efl-extension(17918): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 14:40:15.405+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-29 14:40:15.475+0900 W/CRASH_MANAGER(18141): worker.c: worker_job(1199) > 1118036706831146450041
