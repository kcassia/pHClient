S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 13439
Date: 2016-05-27 20:32:27+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x4494fd00, r5   = 0x41561d89
r6   = 0x44950600, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x4494ef80
r10  = 0x418855c8, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbeeb6630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     21948 KB
Buffers:     43964 KB
Cached:     140516 KB
VmPeak:      95644 KB
VmSize:      89448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22068 KB
VmRSS:       20336 KB
VmData:      35032 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23960 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 13439 TID = 13439
13439 13487 13524 

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
4153c000 41544000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41545000 4154a000 r-xp /usr/lib/libappcore-common.so.1.1
41552000 41554000 r-xp /usr/lib/libiniparser.so.0
4155d000 41564000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
41572000 41576000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4157f000 41581000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4158a000 41590000 r-xp /usr/lib/libappsvc.so.0.1.0
41598000 415bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415c5000 41694000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416aa000 416b4000 r-xp /lib/libnss_files-2.13.so
41971000 41979000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.2.5
41981000 4198e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41996000 4199b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
419a3000 419a7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
419b0000 419d1000 r-xp /usr/lib/libefl-extension.so.0.1.0
419d9000 419f0000 r-xp /usr/lib/libnetwork.so.0.0.0
419f8000 419fd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a05000 41a23000 r-xp /usr/lib/libsensor.so.1.1.0
41a2d000 41a3f000 r-xp /usr/lib/libefl-assist.so.0.1.0
41a47000 41aff000 r-xp /usr/lib/libcairo.so.2.11200.14
41b0a000 41b3b000 r-xp /usr/lib/libmdm.so.1.1.85
41b43000 41b4a000 r-xp /usr/lib/libsensord-share.so
41b52000 41b64000 r-xp /usr/lib/libtts.so
41b6c000 41b8d000 r-xp /usr/lib/libui-extension.so.0.1.0
41b96000 41b9d000 r-xp /usr/lib/libtbm.so.1.0.0
41ba5000 41bb3000 r-xp /usr/lib/libGLESv2.so.2.0
41bbc000 41bbd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41bc6000 41bcc000 r-xp /usr/lib/libxcb-render.so.0.0.0
41bd4000 41bd7000 r-xp /usr/lib/libEGL.so.1.4
41bdf000 41be7000 r-xp /usr/lib/libmdm-common.so.1.0.89
41be8000 41d25000 r-xp /usr/lib/libicui18n.so.51.1
41d35000 41e19000 r-xp /usr/lib/libicuuc.so.51.1
41e2e000 41e31000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41e39000 41e41000 r-xp /usr/lib/libdrm.so.2.4.0
433d0000 433d5000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
433de000 433e3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
433eb000 433ed000 r-xp /usr/lib/libdri2.so.0.0.0
433f5000 43416000 r-xp /usr/lib/libexif.so.12.3.3
43429000 4342e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43436000 43500000 r-xp /usr/lib/libCOREGL.so.4.0
43857000 4385b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43892000 44091000 rwxp [stack:13524]
44c94000 45493000 rwxp [stack:13487]
458b3000 458b6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45929000 45961000 r-xp /usr/lib/libpulse.so.0.16.2
459d6000 459db000 r-xp /usr/lib/libjson.so.0.0.1
459e3000 45a2b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a2c000 45a6f000 r-xp /usr/lib/libsndfile.so.1.0.25
45a7c000 45a9e000 r-xp /usr/lib/libvorbis.so.0.4.3
45aa6000 45aaa000 r-xp /usr/lib/libogg.so.0.7.1
bee96000 beeb7000 rwxp [stack]
End of Maps Information

Callstack Information (PID:13439)
Call Stack Count: 2
 0: cfree + 0xc8 (0x404e41e8) [/lib/libc.so.6] + 0x6f1e8
 1: (0x1) (null)
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
.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-27 20:31:18.384+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 20:31:18.419+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:31:18.419+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:31:18.619+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:31:18.619+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:31:18.629+0900 W/STARTER (  711): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[1]
05-27 20:31:18.629+0900 W/STARTER (  711): hw_key.c: _powerkey_timer_cb(963) > [_powerkey_timer_cb:963] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
05-27 20:31:18.629+0900 E/STARTER (  711): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-27 20:31:18.629+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 0
05-27 20:31:18.634+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 711
05-27 20:31:18.639+0900 W/AUL_AMD (  492): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 732
05-27 20:31:18.639+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESET State: RUNNING
05-27 20:31:18.639+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-27 20:31:18.639+0900 W/W_HOME  (  732): main.c: _app_control(1726) > Service value : powerkey
05-27 20:31:18.639+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x40001
05-27 20:31:18.639+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4494) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:31:18.639+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:31:18.639+0900 W/W_HOME  (  732): noti_broker.c: _noti_broker_home_cb(781) > continue the home key execution
05-27 20:31:18.639+0900 E/W_HOME  (  732): cs_broker.c: _cs_broker_home_cb(256) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
05-27 20:31:18.639+0900 W/W_HOME  (  732): move.c: move_move_to_apps(216) > move to apps
05-27 20:31:18.639+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x479122d0
05-27 20:31:18.639+0900 W/AUL_AMD (  492): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(732), cmd(0)
05-27 20:31:18.639+0900 E/AUL     (  711): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 20:31:18.639+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x479122d0, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 20:31:18.639+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:31:18.639+0900 W/W_HOME  (  732): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-27 20:31:18.639+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:31:18.639+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:31:18.644+0900 E/AUL     (  492): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 20:31:18.649+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-27 20:31:18.649+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-27 20:31:18.649+0900 W/W_HOME  (  732): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-27 20:31:18.649+0900 W/W_HOME  (  732): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-27 20:31:18.649+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:31:18.654+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:31:18.654+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:31:18.654+0900 W/W_HOME  (  732): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
05-27 20:31:18.654+0900 W/W_HOME  (  732): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-27 20:31:18.654+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-27 20:31:18.654+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-27 20:31:18.814+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:31:18.814+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:31:18.934+0900 W/W_HOME  (  732): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-27 20:31:18.934+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:31:18.934+0900 W/W_HOME  (  732): rotary.c: rotary_deattach(156) > rotary_deattach:0x479122d0
05-27 20:31:18.934+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:31:18.934+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x479122d0, elm_layout, func : 0x4004b469
05-27 20:31:18.934+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 20:31:18.934+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 20:31:18.934+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:31:18.934+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96570, elm_box, _activated_obj : 0x479122d0, activated : 1
05-27 20:31:18.934+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:31:18.934+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:31:18.934+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-27 20:31:18.934+0900 W/W_HOME  (  732): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-27 20:31:18.934+0900 W/W_HOME  (  732): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-27 20:31:18.934+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:31:18.939+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:31:18.939+0900 W/W_HOME  (  732): main.c: home_pause(751) > clock/widget paused
05-27 20:31:18.939+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:31:18.939+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 20:31:18.939+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x45d4d480
05-27 20:31:18.939+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d4d480, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 20:31:18.939+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:31:18.939+0900 W/W_HOME  (  732): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-27 20:31:18.939+0900 W/W_HOME  (  732): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-27 20:31:18.939+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-27 20:31:18.939+0900 I/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-27 20:31:18.939+0900 E/APPS    (  732): apps_main.c: apps_main_resume(621) >  resumed already
05-27 20:31:18.944+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:31:18.944+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:31:18.944+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:31:18.944+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:31:18.954+0900 W/WATCH_CORE(  762): appcore-watch.c: __widget_pause(1001) > widget_pause
05-27 20:31:18.959+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppPause(713) > 
05-27 20:31:18.959+0900 E/watchface-viewer(  762): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-27 20:31:18.959+0900 E/watchface-viewer(  762): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-27 20:31:18.959+0900 E/watchface-viewer(  762): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-27 20:31:18.959+0900 E/watchface-viewer(  762): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-27 20:31:18.959+0900 E/watchface-viewer(  762): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-27 20:31:19.289+0900 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-27 20:31:19.289+0900 E/EFL     (  732): evas_main<732> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4905291 button=1 downs=1
05-27 20:31:19.294+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [185, 197]
05-27 20:31:19.374+0900 E/EFL     (  732): evas_main<732> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4905378 button=1 downs=0
05-27 20:31:19.374+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [185, 197]->[198, 198]
05-27 20:31:19.379+0900 W/APPS    (  732): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-27 20:31:19.379+0900 E/APPS    (  732): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-27 20:31:19.379+0900 W/APPS    (  732): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-27 20:31:19.384+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 0
05-27 20:31:19.384+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 732
05-27 20:31:19.384+0900 I/AUL_AMD (  492): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-27 20:31:19.399+0900 E/RESOURCED(  493): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-27 20:31:19.399+0900 E/RESOURCED(  493): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-27 20:31:19.399+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(2080) > pad pid(-5)
05-27 20:31:19.404+0900 W/AUL_PAD ( 1171): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-27 20:31:19.404+0900 W/AUL_PAD ( 1171): launchpad.c: __send_result_to_caller(272) > Check app launching
05-27 20:31:19.444+0900 I/efl-extension(13439): efl_extension.c: eext_mod_init(40) > Init
05-27 20:31:19.444+0900 I/UXT     (13439): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-27 20:31:19.454+0900 I/CAPI_APPFW_APPLICATION(13439): app_main.c: ui_app_main(704) > app_efl_main
05-27 20:31:19.459+0900 I/CAPI_APPFW_APPLICATION(13439): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-27 20:31:19.494+0900 E/TBM     (13439): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-27 20:31:19.509+0900 E/AUL     (  492): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 20:31:19.509+0900 E/RESOURCED(  493): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-27 20:31:19.569+0900 E/EFL     (13439): <13439> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-27 20:31:19.579+0900 E/EFL     (13439): <13439> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-27 20:31:19.579+0900 E/EFL     (13439): <13439> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-27 20:31:19.584+0900 E/EFL     (13439): <13439> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-27 20:31:19.584+0900 E/EFL     (13439): <13439> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-27 20:31:19.584+0900 E/EFL     (13439): <13439> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-27 20:31:19.664+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03e00002)
05-27 20:31:19.669+0900 I/APP_CORE(13439): appcore-efl.c: __do_app(429) > [APP 13439] Event: RESET State: CREATED
05-27 20:31:19.669+0900 I/CAPI_APPFW_APPLICATION(13439): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-27 20:31:19.689+0900 I/APP_CORE(13439): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-27 20:31:19.689+0900 I/APP_CORE(13439): appcore-efl.c: __do_app(474) > [APP 13439] Initial Launching, call the resume_cb
05-27 20:31:19.689+0900 I/CAPI_APPFW_APPLICATION(13439): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-27 20:31:19.724+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-27 20:31:19.729+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-27 20:31:19.729+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:31:19.729+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:31:19.729+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:31:19.729+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-27 20:31:19.734+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:31:19.734+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:31:19.779+0900 W/APP_CORE(13439): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00002
05-27 20:31:19.854+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-27 20:31:19.854+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-27 20:31:19.854+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:31:19.854+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-27 20:31:19.859+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: PAUSE State: RUNNING
05-27 20:31:19.859+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 20:31:19.859+0900 W/W_HOME  (  732): main.c: _appcore_pause_cb(690) > appcore pause
05-27 20:31:19.859+0900 W/W_HOME  (  732): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-27 20:31:19.859+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:31:19.874+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 20:31:19.874+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 20:31:19.874+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:31:19.874+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:31:19.874+0900 W/W_HOME  (  732): rotary.c: rotary_deattach(156) > rotary_deattach:0x45d4d480
05-27 20:31:19.874+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:31:19.874+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45d4d480, elm_layout, func : 0x4004b469
05-27 20:31:19.874+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 20:31:19.874+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 20:31:19.874+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:31:19.874+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96570, elm_box, _activated_obj : 0x45d4d480, activated : 1
05-27 20:31:19.874+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:31:19.874+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:31:19.874+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-27 20:31:19.889+0900 I/APP_CORE(13439): appcore-efl.c: __do_app(429) > [APP 13439] Event: RESUME State: RUNNING
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-27 20:31:19.899+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 20:31:19.904+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:31:19.904+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:31:19.904+0900 E/CAPI_APPFW_APP_CONTROL( 1241): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-27 20:31:19.904+0900 W/MUSIC_CONTROL_SERVICE( 1241): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1241]   [com.samsung.w-home]register msg port [false][0m
05-27 20:31:19.974+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-27 20:31:19.974+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:31:19.984+0900 W/APPS    (  732): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-27 20:31:20.244+0900 E/AUL     (  492): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 20:31:20.404+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-27 20:31:20.434+0900 E/EFL     (13439): evas_main<13439> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4906434 button=1 downs=1
05-27 20:31:20.514+0900 E/EFL     (13439): evas_main<13439> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4906517 button=1 downs=0
05-27 20:31:20.544+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:31:20.559+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13439
05-27 20:31:20.564+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:31:20.864+0900 I/AUL_PAD (13488): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-27 20:31:21.579+0900 E/EFL     (13439): evas_main<13439> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4907572 button=1 downs=1
05-27 20:31:21.714+0900 E/EFL     (13439): evas_main<13439> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4907712 button=1 downs=0
05-27 20:31:21.964+0900 I/CAPI_NETWORK_CONNECTION(13439): connection.c: connection_create(372) > New handle created[0x4491ffc8]
05-27 20:31:21.979+0900 I/SOCKETTEST(13439): IP : 
05-27 20:31:21.979+0900 I/SOCKETTEST(13439): Success to create UDP socket
05-27 20:31:21.979+0900 I/SOCKETTEST(13439): Bind Success
05-27 20:31:21.979+0900 I/SOCKETTEST(13439): Waiting DATA...
05-27 20:31:22.539+0900 I/APP_CORE(11594): appcore-efl.c: __do_app(429) > [APP 11594] Event: MEM_FLUSH State: PAUSED
05-27 20:31:23.869+0900 I/SOCKETTEST(13439): Receive Data : 192.168.43.140
05-27 20:31:23.869+0900 I/SOCKETTEST(13439): Changed IP : 192.168.43.140
05-27 20:31:23.924+0900 I/SOCKETTEST(13439): Success to create socket
05-27 20:31:23.934+0900 I/SOCKETTEST(13439): Success to socket connection
05-27 20:31:23.939+0900 I/SOCKETTEST(13439): write() 성공
05-27 20:31:24.909+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-27 20:31:26.334+0900 E/GESTURE (  138): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=28   flick_area=55 ---> SET value to 1
05-27 20:31:26.334+0900 E/GESTURE (  138): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
05-27 20:31:26.334+0900 E/GESTURE (  138): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=28   flick_area=55 ---> SET value to 1
05-27 20:31:26.394+0900 E/GESTURE (  138): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
05-27 20:31:26.394+0900 E/EFL     (13439): evas_main<13439> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4912336 button=1 downs=1
05-27 20:31:26.394+0900 E/EFL     (13439): evas_main<13439> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4912394 button=1 downs=0
05-27 20:31:26.419+0900 D/TIMER   (13439): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-27 20:31:26.419+0900 D/TIMER   (13439): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-27 20:31:26.474+0900 I/efl-extension(13439): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-27 20:31:26.474+0900 I/efl-extension(13439): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-27 20:31:26.474+0900 I/efl-extension(13439): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-27 20:31:26.484+0900 I/efl-extension(13439): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-27 20:31:26.484+0900 I/efl-extension(13439): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44902400, elm_layout, _activated_obj : 0x0, activated : 1
05-27 20:31:28.294+0900 E/EFL     (13439): evas_main<13439> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4914292 button=1 downs=1
05-27 20:31:28.369+0900 E/EFL     (13439): evas_main<13439> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4914372 button=1 downs=0
05-27 20:31:28.839+0900 E/EFL     (13439): evas_main<13439> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4914840 button=1 downs=1
05-27 20:31:28.964+0900 E/EFL     (13439): evas_main<13439> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4914964 button=1 downs=0
05-27 20:31:29.499+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:29.499+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:29.504+0900 I/efl-extension(13439): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:29.504+0900 I/efl-extension(13439): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44902400, elm_layout, time_stamp : 4915502
05-27 20:31:29.844+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:29.849+0900 I/efl-extension(13439): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:29.849+0900 I/efl-extension(13439): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44902400, elm_layout, time_stamp : 4915847
05-27 20:31:29.849+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:29.924+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:29.929+0900 I/efl-extension(13439): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:29.929+0900 I/efl-extension(13439): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44902400, elm_layout, time_stamp : 4915928
05-27 20:31:29.929+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:30.004+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:30.004+0900 I/efl-extension(13439): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:30.004+0900 I/efl-extension(13439): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44902400, elm_layout, time_stamp : 4916005
05-27 20:31:30.009+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:30.089+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:30.089+0900 I/efl-extension(13439): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:30.089+0900 I/efl-extension(13439): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44902400, elm_layout, time_stamp : 4916089
05-27 20:31:30.089+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:30.154+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:30.159+0900 I/efl-extension(13439): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:30.159+0900 I/efl-extension(13439): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44902400, elm_layout, time_stamp : 4916157
05-27 20:31:30.169+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:31:31.059+0900 E/EFL     (13439): evas_main<13439> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4917060 button=1 downs=1
05-27 20:31:31.174+0900 E/EFL     (13439): evas_main<13439> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4917173 button=1 downs=0
05-27 20:31:32.084+0900 E/EFL     (13439): evas_main<13439> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4918082 button=1 downs=1
05-27 20:31:32.214+0900 E/EFL     (13439): evas_main<13439> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4918217 button=1 downs=0
05-27 20:31:32.934+0900 E/EFL     (13439): evas_main<13439> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4918931 button=1 downs=1
05-27 20:31:33.074+0900 E/EFL     (13439): evas_main<13439> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4919078 button=1 downs=0
05-27 20:31:33.079+0900 D/TIMER   (13439): Setting time is 360
05-27 20:31:33.179+0900 I/SOCKETTEST(13439): Success to create socket
05-27 20:31:34.199+0900 I/SOCKETTEST(13439): Success to socket connection
05-27 20:31:34.199+0900 I/SOCKETTEST(13439): write() 성공
05-27 20:31:34.374+0900 I/SENSOR  (13439): 1.190000, -0.910000, 3.150000
05-27 20:31:34.374+0900 I/SENSOR  (13439): 3.500000, -0.560000, 3.920000
05-27 20:31:34.379+0900 I/SENSOR  (13439): 4.760000, -0.420000, 3.990000
05-27 20:31:34.379+0900 I/SENSOR  (13439): 4.200000, -0.280000, 3.920000
05-27 20:31:34.379+0900 I/SENSOR  (13439): 2.800000, -0.350000, 3.570000
05-27 20:31:34.379+0900 I/SENSOR  (13439): 3.360000, -0.630000, 3.500000
05-27 20:31:34.389+0900 I/SENSOR  (13439): 5.040000, 5.320000, 3.430000
05-27 20:31:34.389+0900 I/SENSOR  (13439): 4.690000, -1.050000, 4.060000
05-27 20:31:34.389+0900 I/SENSOR  (13439): 3.080000, -0.210000, 3.850000
05-27 20:31:34.389+0900 I/SENSOR  (13439): 2.940000, -0.210000, 3.570000
05-27 20:31:34.389+0900 I/SENSOR  (13439): 1.680000, -0.420000, 3.430000
05-27 20:31:34.394+0900 I/SENSOR  (13439): 4.270000, -4.340000, 3.570000
05-27 20:31:34.394+0900 E/EFL     (13439): evas_main<13439> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4919817 button=1 downs=1
05-27 20:31:34.394+0900 E/EFL     (13439): evas_main<13439> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4919963 button=1 downs=0
05-27 20:31:34.394+0900 I/efl-extension(13439): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:31:34.394+0900 I/efl-extension(13439): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44902400, elm_layout, func : 0x415608d9
05-27 20:31:34.394+0900 I/efl-extension(13439): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 20:31:34.399+0900 I/efl-extension(13439): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 20:31:34.399+0900 I/efl-extension(13439): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:31:34.399+0900 I/efl-extension(13439): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 20:31:34.399+0900 I/efl-extension(13439): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 20:31:34.399+0900 I/efl-extension(13439): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 20:31:34.419+0900 I/SOCKETTEST(13439): Success to create socket
05-27 20:31:34.424+0900 I/SOCKETTEST(13439): Success to socket connection
05-27 20:31:34.429+0900 I/SOCKETTEST(13439): write() 성공
05-27 20:31:34.444+0900 I/TimeRecord(13439): String_ time : 0
05-27 20:31:34.444+0900 I/TimeRecord(13439): Preference_ time : �s�D
05-27 20:31:34.444+0900 I/TimeRecord(13439): time : 0
05-27 20:31:34.914+0900 I/efl-extension(13439): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44902400
05-27 20:31:34.914+0900 I/efl-extension(13439): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44902400, obj: 0x44902400
05-27 20:31:34.919+0900 I/efl-extension(13439): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 20:31:43.674+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 48 -> 49 1464348703 83
05-27 20:31:43.699+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 49 100 92 85
05-27 20:31:43.699+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 49 0 0 0
05-27 20:31:43.704+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 49 109 40 93
05-27 20:31:43.709+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 49 100 5 85
05-27 20:31:43.709+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 49 115 28 98
05-27 20:31:54.309+0900 I/RESOURCED(  493): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-27 20:31:54.309+0900 I/RESOURCED(  493): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-27 20:32:00.969+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 20:32:27.164+0900 E/PKGMGR_SERVER(13593): pkgmgr-server.c: main(2131) > package manager server start
05-27 20:32:27.254+0900 E/PKGMGR_SERVER(13593): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_1122294133], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[VRiMRYcPY7JvR/9zLshyLXONRJ8=], backend_flag=[0]
05-27 20:32:27.259+0900 E/PKGMGR_SERVER(13595): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-27 20:32:27.264+0900 E/PKGMGR  (13587): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-27 20:32:27.334+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:32:27.344+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13439
05-27 20:32:27.344+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:32:27.349+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 5
05-27 20:32:27.354+0900 W/AUL_AMD (  492): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(13439), cmd(4)
05-27 20:32:27.354+0900 I/APP_CORE(13439): appcore-efl.c: __do_app(429) > [APP 13439] Event: TERMINATE State: RUNNING
05-27 20:32:27.354+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 20:32:27.354+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 20:32:27.354+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:32:27.364+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13439
05-27 20:32:27.424+0900 I/APP_CORE(13439): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 20:32:27.424+0900 I/CAPI_APPFW_APPLICATION(13439): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 20:32:27.459+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 20:32:27.459+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 20:32:27.469+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:32:27.479+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13439
05-27 20:32:27.544+0900 I/UXT     (13439): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 20:32:27.544+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-27 20:32:27.544+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-27 20:32:27.544+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 20:32:27.549+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:32:27.549+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:32:27.549+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:32:27.549+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 20:32:27.549+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:32:27.549+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:32:27.549+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:32:27.549+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 20:32:27.579+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:32:27.589+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13439
05-27 20:32:27.634+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 20:32:27.634+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 20:32:27.634+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:32:27.634+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 20:32:27.634+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-27 20:32:27.634+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 20:32:27.634+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-27 20:32:27.634+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-27 20:32:27.634+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:32:27.639+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:32:27.639+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:32:27.639+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 20:32:27.639+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x45d4d480
05-27 20:32:27.639+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d4d480, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 20:32:27.639+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:32:27.644+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 20:32:27.644+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:32:27.644+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 20:32:27.644+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:32:27.644+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:32:27.644+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:32:27.644+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:32:27.689+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:32:27.694+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13439
05-27 20:32:27.799+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:32:27.819+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13439
05-27 20:32:27.929+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:32:27.944+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13439
05-27 20:32:28.044+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:32:28.059+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-27 20:32:28.064+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 20:32:28.069+0900 E/PKGMGR_SERVER(13595): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-27 20:32:28.099+0900 E/PKGMGR_SERVER(13593): pkgmgr-server.c: sighandler(409) > child NORMAL exit [13595]
05-27 20:32:28.164+0900 W/CRASH_MANAGER(13600): worker.c: worker_job(1199) > 1113439706831146434874
