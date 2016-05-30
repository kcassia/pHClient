S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 16218
Date: 2016-05-29 14:31:33+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2f656a64

Register Information
r0   = 0x00000000, r1   = 0x41fc4708
r2   = 0x41fc4700, r3   = 0x00000000
r4   = 0x6c706d61, r5   = 0x68702e65
r6   = 0x65722f31, r7   = 0x652f2f73
r8   = 0x438c17d0, r9   = 0x420edf28
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4142def4, sp   = 0xbe9b9658
lr   = 0x400953f8, pc   = 0x2f656a64
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     19300 KB
Buffers:     51096 KB
Cached:     113192 KB
VmPeak:      82784 KB
VmSize:      50636 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19468 KB
VmRSS:       16028 KB
VmData:      24704 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       18704 KB
VmPTE:          48 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16218 TID = 16218
16218 16615 

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
41430000 41434000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41445000 4144a000 r-xp /usr/lib/libappcore-common.so.1.1
41452000 41454000 r-xp /usr/lib/libiniparser.so.0
41472000 41476000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4147f000 41481000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4148a000 41490000 r-xp /usr/lib/libappsvc.so.0.1.0
41498000 414bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414c5000 41594000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415aa000 415b4000 r-xp /lib/libnss_files-2.13.so
41996000 4199d000 r-xp /usr/lib/libtbm.so.1.0.0
41c39000 41c41000 r-xp /usr/lib/libdrm.so.2.4.0
41c64000 41c66000 r-xp /usr/lib/libdri2.so.0.0.0
41caf000 41d79000 r-xp /usr/lib/libCOREGL.so.4.0
41f9f000 41fa3000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41fc3000 420f5000 rw-p [heap]
440d2000 448d1000 rwxp [stack:16615]
be999000 be9ba000 rwxp [stack]
End of Maps Information

Callstack Information (PID:16218)
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
) to ungrab key(XF86Stop)
05-29 14:30:24.241+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 14:30:24.256+0900 I/wnotibp (16510): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1037) > fully_obscured: 0 [0x3400008 0x340000a 0x3400008 ]
05-29 14:30:24.256+0900 I/APP_CORE(16510): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 14:30:24.266+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3713) > ::UI:: VI TYPE : 2
05-29 14:30:24.266+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3719) > alert_type : 1, is_source_companion: 1
05-29 14:30:24.271+0900 W/TIZEN_N_RECORDER(16510): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
05-29 14:30:24.271+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1272) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
05-29 14:30:24.271+0900 I/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1281) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
05-29 14:30:24.271+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1315) > ::APP:: Determined feedback: sound 0, vibration: 0
05-29 14:30:24.271+0900 I/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1319) > No feedback.
05-29 14:30:24.306+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_view_lock(856) > ::UI:: [[[ ===> already [small popup] is LOCK, 0010 ]]]
05-29 14:30:24.306+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_pre_cb(2194) > ::UI:: start showing animation
05-29 14:30:24.551+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:30:24.556+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16510
05-29 14:30:24.571+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 14:30:24.616+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_cb(2104) > ::UI:: end show animation
05-29 14:30:24.616+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-29 14:30:24.616+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-29 14:30:24.646+0900 E/wnoti-service(  844): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
05-29 14:30:24.651+0900 E/wnoti-service(  844): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 2
05-29 14:30:24.651+0900 E/wnoti-service(  844): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-29 14:30:24.656+0900 E/wnoti-proxy(16510): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
05-29 14:30:24.656+0900 E/wnotibp (16510): wnotiboard-popup-data.c: wnotibp_get_alert_list(916) > ::DATA:: No categories available.
05-29 14:30:24.656+0900 W/wnotibp (16510): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 0, list count : 1
05-29 14:30:24.761+0900 I/AUL_PAD (16575): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 14:30:24.766+0900 E/wnoti-service(  844): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
05-29 14:30:26.771+0900 E/wnoti-service(  844): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
05-29 14:30:26.876+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-29 14:30:26.876+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_main_popup_timer_cb(2324) > ::UI:: start hiding animation
05-29 14:30:27.146+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 1, 0
05-29 14:30:27.176+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-29 14:30:27.176+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-29 14:30:27.176+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 14:30:27.176+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 14:30:27.176+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 14:30:27.176+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-29 14:30:27.176+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-29 14:30:27.176+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 14:30:27.176+0900 W/W_HOME  (  714): gesture.c: _apps_status_get(123) > apps status:0
05-29 14:30:27.176+0900 W/W_HOME  (  714): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:3465
05-29 14:30:27.176+0900 W/W_HOME  (  714): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-29 14:30:27.176+0900 W/W_HOME  (  714): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-29 14:30:27.176+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:30:27.201+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_hide_animator_cb(2255) > ::UI:: end hiding animation
05-29 14:30:27.201+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [3465]ms
05-29 14:30:27.201+0900 W/STARTER (  682): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-29 14:30:27.206+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-29 14:30:27.206+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-29 14:30:27.206+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (8, 1, 0)
05-29 14:30:27.206+0900 I/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=0, view_state=0
05-29 14:30:27.206+0900 I/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_view_unlock(903) > ::UI:: it is invalid object.
05-29 14:30:27.226+0900 I/APP_CORE(16218): appcore-efl.c: __do_app(429) > [APP 16218] Event: RESUME State: RUNNING
05-29 14:30:27.231+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [invalid object] is UNLOCK , 0000 <=== ]]]
05-29 14:30:27.236+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-29 14:30:27.236+0900 I/wnotibp (16510): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 859
05-29 14:30:27.236+0900 I/wnotibp (16510): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 0, 0
05-29 14:30:27.251+0900 I/efl-extension(16510): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4517ad38, obj: 0x4517ad38
05-29 14:30:27.261+0900 I/efl-extension(16510): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 14:30:27.261+0900 I/efl-extension(16510): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 14:30:27.261+0900 I/efl-extension(16510): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 14:30:27.266+0900 I/efl-extension(16510): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 14:30:27.271+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-29 14:30:27.271+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-29 14:30:27.271+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 14:30:27.286+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-29 14:30:27.291+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:30:27.296+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:30:27.296+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1352366434)
05-29 14:30:27.296+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:30:27.296+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:37:00 (UTC).
05-29 14:30:27.296+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:30:27.296+0900 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1352366434] is removed.
05-29 14:30:27.301+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-29 14:30:27.301+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-29 14:30:27.301+0900 I/efl-extension(16510): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 14:30:27.301+0900 I/efl-extension(16510): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4517ad38, elm_genlist, func : 0x41a25dfd
05-29 14:30:27.301+0900 I/efl-extension(16510): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 14:30:27.306+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-29 14:30:27.306+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(998) > ::UI:: lock state = 0000
05-29 14:30:27.306+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-29 14:30:27.306+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 14:30:27.326+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 14:30:27.326+0900 I/wnotibp (16510): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(2024) > ::INFO:: call lower
05-29 14:30:27.331+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 14:30:27.336+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-29 14:30:27.336+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:30:27.336+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:30:27.336+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-29 14:30:27.336+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:30:27.336+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:30:27.336+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-29 14:30:27.346+0900 I/APP_CORE(16510): appcore-efl.c: __do_app(429) > [APP 16510] Event: RESUME State: RUNNING
05-29 14:30:27.346+0900 W/APP_CORE(16510): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:3400008
05-29 14:30:27.346+0900 I/APP_CORE(16510): appcore-efl.c: __do_app(429) > [APP 16510] Event: PAUSE State: RUNNING
05-29 14:30:27.346+0900 I/CAPI_APPFW_APPLICATION(16510): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 14:30:27.376+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-29 14:30:27.376+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 0
05-29 14:30:27.396+0900 W/wnotibp (16510): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-29 14:30:27.396+0900 W/wnotibp (16510): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-29 14:30:27.396+0900 W/wnotibp (16510): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [0, 0, 1, 0000]
05-29 14:30:27.401+0900 W/wnotibp (16510): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 0]
05-29 14:30:27.401+0900 W/wnotibp (16510): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1371) > [0, 1, 0, 2, 0]
05-29 14:30:30.186+0900 E/EFL     (16218): evas_main<16218> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=18214531 button=1 downs=1
05-29 14:30:30.201+0900 E/EFL     (16218): evas_main<16218> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=18214549 button=1 downs=0
05-29 14:30:30.201+0900 E/SCREENTEST(16218): start_screen = 1
05-29 14:30:30.221+0900 D/TIMER   (16218): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-29 14:30:30.226+0900 D/TIMER   (16218): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-29 14:30:30.291+0900 I/efl-extension(16218): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 14:30:30.291+0900 I/efl-extension(16218): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-29 14:30:30.291+0900 I/efl-extension(16218): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-29 14:30:30.296+0900 I/efl-extension(16218): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-29 14:30:30.296+0900 I/efl-extension(16218): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437de5b8, elm_layout, _activated_obj : 0x0, activated : 1
05-29 14:30:32.411+0900 I/APP_CORE(16510): appcore-efl.c: __do_app(429) > [APP 16510] Event: MEM_FLUSH State: PAUSED
05-29 14:30:37.611+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 14:30:44.836+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 14:30:44.836+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 14:30:44.836+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 14:30:44.836+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 1
05-29 14:30:44.836+0900 W/W_HOME  (  714): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 14:30:44.836+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:30:44.841+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-29 14:30:44.841+0900 W/STARTER (  682): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 14:30:44.846+0900 E/STARTER (  682): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 14:30:44.846+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 14:30:44.846+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 14:30:44.876+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 14:30:44.881+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 14:30:44.886+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 14:30:44.891+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 14:30:44.941+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 14:30:44.956+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 14:30:44.956+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 14:30:44.956+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 14:30:44.956+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 14:30:44.971+0900 I/APP_CORE(16218): appcore-efl.c: __do_app(429) > [APP 16218] Event: PAUSE State: RUNNING
05-29 14:30:44.971+0900 I/CAPI_APPFW_APPLICATION(16218): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 14:30:45.021+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 14:30:45.021+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 14:30:45.031+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 14:30:45.031+0900 E/ALARM_MANAGER(  682): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 14:31:05), repeat(1), interval(20), type(-1073741822)
05-29 14:30:45.031+0900 W/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 14:30:45.036+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 14:30:45.036+0900 I/HIGEAR  ( 1102): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 14:30:45.066+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:30:45.066+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:30:45.171+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 37646385, next duetime: 1464499865
05-29 14:30:45.171+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(37646385)
05-29 14:30:45.171+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464500220), due_time(1464499865)
05-29 14:30:45.171+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:30:45.171+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:31:05 (UTC).
05-29 14:30:45.171+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:30:50.096+0900 I/APP_CORE(16218): appcore-efl.c: __do_app(429) > [APP 16218] Event: MEM_FLUSH State: PAUSED
05-29 14:31:00.481+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 14:31:04.996+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-29 14:31:05.061+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-29 14:31:05.126+0900 E/RESOURCED(  488): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 682
05-29 14:31:05.141+0900 E/ALARM_MANAGER(  682): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [37646385]
05-29 14:31:05.141+0900 W/STARTER (  682): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(927) > [__starter_clock_mgr_homescreen_alarm_cb:927] homescreen alarm timer expired [37646385]
05-29 14:31:05.156+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 14:31:05.161+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 682
05-29 14:31:05.171+0900 W/AUL_AMD (  487): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 714
05-29 14:31:05.176+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESET State: PAUSED
05-29 14:31:05.176+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 14:31:05.176+0900 W/W_HOME  (  714): main.c: _app_control(1726) > Service value : show_clock
05-29 14:31:05.176+0900 W/W_HOME  (  714): main.c: _app_control(1762) > Show clock operation
05-29 14:31:05.176+0900 W/W_HOME  (  714): gesture.c: _clock_show(228) > clock show
05-29 14:31:05.181+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(714), cmd(0)
05-29 14:31:05.206+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_expired(1322) > alarm_id[37646385] is expired.
05-29 14:31:05.211+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 37646385, next duetime: 1464499885
05-29 14:31:05.211+0900 W/W_HOME  (  714): gesture.c: _clock_show(243) > home raise
05-29 14:31:05.211+0900 E/W_HOME  (  714): gesture.c: gesture_win_aux_set(396) > wm.policy.win.do.not.use.deiconify.approve:-1
05-29 14:31:05.216+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:31:05.216+0900 W/W_HOME  (  714): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
05-29 14:31:05.216+0900 W/W_HOME  (  714): gesture.c: _clock_show(246) > home raise done
05-29 14:31:05.216+0900 W/W_HOME  (  714): gesture.c: _clock_show(253) > show clock
05-29 14:31:05.216+0900 W/W_HOME  (  714): move.c: move_back_to_home_no_anim(274) > back to home no anim
05-29 14:31:05.216+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x4778eb48
05-29 14:31:05.216+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4778eb48, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-29 14:31:05.216+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 14:31:05.216+0900 W/W_HOME  (  714): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-29 14:31:05.216+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:3, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:31:05.216+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:31:05.216+0900 W/W_HOME  (  714): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-29 14:31:05.216+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:3, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.216+0900 W/W_HOME  (  714): rotary.c: rotary_deattach(156) > rotary_deattach:0x4778eb48
05-29 14:31:05.216+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 14:31:05.216+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4778eb48, elm_layout, func : 0x4004b469
05-29 14:31:05.216+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-29 14:31:05.216+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-29 14:31:05.216+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 14:31:05.216+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x4778eb48, activated : 1
05-29 14:31:05.216+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 14:31:05.216+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 14:31:05.216+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-29 14:31:05.216+0900 W/W_HOME  (  714): scroller.c: _get_index_in_list(1913) > page:0x45ce3638 idx:1 total7 exist:1
05-29 14:31:05.216+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c93cc8), origin_x(0), origin_y(0)
05-29 14:31:05.231+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:31:25 (UTC).
05-29 14:31:05.231+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:31:05.231+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-29 14:31:05.246+0900 E/wnotibp (16510): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 14:31:05.246+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1735) > [0, 2, 1]
05-29 14:31:05.251+0900 W/W_HOME  (  714): gesture.c: _widget_updated_cb(190) > widget updated
05-29 14:31:05.251+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 14:31:05.251+0900 W/W_HOME  (  714): gesture.c: _manual_render(176) > 
05-29 14:31:05.276+0900 E/E17     (  382): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02600003)
05-29 14:31:05.286+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-29 14:31:05.286+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:31:05.291+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:31:05.291+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(37646385)
05-29 14:31:05.291+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:31:05.291+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:37:00 (UTC).
05-29 14:31:05.291+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:31:05.291+0900 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[37646385] is removed.
05-29 14:31:05.296+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 14:31:05.296+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 14:31:05.321+0900 W/W_HOME  (  714): gesture.c: _manual_render(176) > 
05-29 14:31:05.336+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 0
05-29 14:31:05.336+0900 W/W_HOME  (  714): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
05-29 14:31:05.336+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.341+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 14:31:05.341+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 14:31:05.341+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-29 14:31:05.346+0900 W/W_HOME  (  714): event_manager.c: _apptray_visibility_cb(578) > apps,hide,start
05-29 14:31:05.346+0900 W/W_HOME  (  714): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-29 14:31:05.346+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.346+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.346+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.346+0900 W/W_HOME  (  714): noti_broker.c: _apptray_visibility_cb(788) > apps,hide,start
05-29 14:31:05.346+0900 W/W_HOME  (  714): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-29 14:31:05.346+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-29 14:31:05.346+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-29 14:31:05.346+0900 W/W_HOME  (  714): event_manager.c: _apptray_visibility_cb(578) > apps,hide
05-29 14:31:05.346+0900 W/W_HOME  (  714): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-29 14:31:05.346+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.346+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.346+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.346+0900 W/W_HOME  (  714): noti_broker.c: _apptray_visibility_cb(788) > apps,hide
05-29 14:31:05.346+0900 W/W_HOME  (  714): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80001
05-29 14:31:05.346+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80001
05-29 14:31:05.346+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 0
05-29 14:31:05.351+0900 E/APPS    (  714): apps_main.c: apps_main_pause(587) >  paused already
05-29 14:31:05.386+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 14:31:05.386+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.386+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.386+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.386+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 14:31:05.421+0900 I/APP_CORE(16218): appcore-efl.c: __do_app(429) > [APP 16218] Event: PAUSE State: PAUSED
05-29 14:31:05.421+0900 I/APP_CORE(16218): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
05-29 14:31:05.431+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 14:31:05.431+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 14:31:05.431+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:31:05.431+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 14:31:05.436+0900 I/APP_CORE(  714): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 14:31:05.436+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 14:31:05.436+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 14:31:05.436+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1692) > Do the postponed update job.
05-29 14:31:05.456+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-29 14:31:05.471+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1059) > idler for type: 0
05-29 14:31:05.491+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-29 14:31:05.491+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1106) > unread_count: 1
05-29 14:31:05.491+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(626) > category_id: 42, application_id: 218, application_name: 카카오톡, time_stamp: 1464499823, content_id: 0, spannable_string_version: 1
05-29 14:31:05.491+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-29 14:31:05.491+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-29 14:31:05.491+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-29 14:31:05.496+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-29 14:31:05.496+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-29 14:31:05.496+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-29 14:31:05.496+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  42, 카카오톡.
05-29 14:31:05.496+0900 W/wnotib  (  714): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(260) > Create a panel for panel_id: 1, instance_id: 42
05-29 14:31:05.496+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_initialize(4998) > Initialize the panel with id: 42
05-29 14:31:05.496+0900 W/wnotib  (  714): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(275) > Page instance, instance_id [42] has been created.
05-29 14:31:05.496+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 42, application_id: 218, type: 1
05-29 14:31:05.516+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-29 14:31:05.516+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-29 14:31:05.516+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-29 14:31:05.516+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-29 14:31:05.516+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-29 14:31:05.516+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 42, application_id: 218, type: 13
05-29 14:31:05.516+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-29 14:31:05.516+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-29 14:31:05.516+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-29 14:31:05.516+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-29 14:31:05.521+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-29 14:31:05.526+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-29 14:31:05.531+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 42, application_id: 218, type: 12
05-29 14:31:05.531+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1387) > Num categories: 1, num total noti: 1
05-29 14:31:05.531+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(871) > Free noti manager data.
05-29 14:31:05.531+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(876) > Free previous notifications.
05-29 14:31:05.531+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(897) > Free previous categories.
05-29 14:31:05.531+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
05-29 14:31:05.531+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
05-29 14:31:05.531+0900 W/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(206) > Summary board was disabled. But receive update request
05-29 14:31:05.531+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
05-29 14:31:05.531+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1412) > num_total_panel: 1.
05-29 14:31:05.531+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x1
05-29 14:31:05.546+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1416) > unread_count_for_home: 1
05-29 14:31:05.546+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_show(478) > 
05-29 14:31:05.576+0900 W/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-29 14:31:05.606+0900 W/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-29 14:31:21.031+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 14:31:21.036+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 14:31:32.791+0900 E/PKGMGR_SERVER(16685): pkgmgr-server.c: main(2131) > package manager server start
05-29 14:31:32.861+0900 E/PKGMGR_SERVER(16685): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_1944066644], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[KP9WoCeZtAzNKwAEjuZsFUyekLY=], backend_flag=[0]
05-29 14:31:32.866+0900 E/PKGMGR_SERVER(16686): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-29 14:31:32.871+0900 E/PKGMGR  (16683): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-29 14:31:32.936+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:31:32.946+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16218
05-29 14:31:32.946+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 14:31:32.951+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 5
05-29 14:31:32.956+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(16218), cmd(4)
05-29 14:31:32.956+0900 I/APP_CORE(16218): appcore-efl.c: __do_app(429) > [APP 16218] Event: TERMINATE State: PAUSED
05-29 14:31:32.961+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 14:31:32.961+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 14:31:32.961+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:31:32.971+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16218
05-29 14:31:33.071+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:31:33.081+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16218
05-29 14:31:33.126+0900 I/APP_CORE(16218): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 14:31:33.126+0900 I/CAPI_APPFW_APPLICATION(16218): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-29 14:31:33.186+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:31:33.216+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16218
05-29 14:31:33.241+0900 I/efl-extension(16218): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x437de5b8
05-29 14:31:33.241+0900 I/efl-extension(16218): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x437de5b8, obj: 0x437de5b8
05-29 14:31:33.241+0900 I/efl-extension(16218): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 14:31:33.241+0900 I/efl-extension(16218): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 14:31:33.241+0900 I/efl-extension(16218): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 14:31:33.241+0900 I/efl-extension(16218): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 14:31:33.321+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:31:33.331+0900 I/UXT     (16218): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 14:31:33.336+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16218
05-29 14:31:33.441+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:31:33.501+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16218
05-29 14:31:33.551+0900 I/efl-extension(16218): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 14:31:33.606+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:31:33.651+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16218
05-29 14:31:33.756+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:31:33.771+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16218
05-29 14:31:33.876+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:31:33.881+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 14:31:33.891+0900 E/PKGMGR_SERVER(16686): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-29 14:31:33.906+0900 E/PKGMGR_SERVER(16685): pkgmgr-server.c: sighandler(409) > child NORMAL exit [16686]
05-29 14:31:33.951+0900 W/CRASH_MANAGER(16691): worker.c: worker_job(1199) > 1116218706831146449989
