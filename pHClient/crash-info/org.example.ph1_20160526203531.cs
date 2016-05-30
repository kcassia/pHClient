S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 24474
Date: 2016-05-26 20:35:31+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x448f0e68, r5   = 0x41561c61
r6   = 0x448f1768, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x448f00e8
r10  = 0x41886338, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbee96630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     22840 KB
Buffers:     46092 KB
Cached:     133560 KB
VmPeak:     100700 KB
VmSize:      94520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26916 KB
VmRSS:       24932 KB
VmData:      40168 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23928 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24474 TID = 24474
24474 24611 

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
41971000 4197e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41986000 4198b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41993000 41997000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
419a0000 419c1000 r-xp /usr/lib/libefl-extension.so.0.1.0
419c9000 419e0000 r-xp /usr/lib/libnetwork.so.0.0.0
419e8000 419ed000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
419f5000 41a13000 r-xp /usr/lib/libsensor.so.1.1.0
41a1d000 41a2f000 r-xp /usr/lib/libefl-assist.so.0.1.0
41a37000 41aef000 r-xp /usr/lib/libcairo.so.2.11200.14
41afa000 41b2b000 r-xp /usr/lib/libmdm.so.1.1.85
41b33000 41b3a000 r-xp /usr/lib/libsensord-share.so
41b42000 41b54000 r-xp /usr/lib/libtts.so
41b5c000 41b7d000 r-xp /usr/lib/libui-extension.so.0.1.0
41b86000 41b8d000 r-xp /usr/lib/libtbm.so.1.0.0
41b95000 41ba3000 r-xp /usr/lib/libGLESv2.so.2.0
41bac000 41bad000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41bb6000 41bbc000 r-xp /usr/lib/libxcb-render.so.0.0.0
41bc4000 41bc7000 r-xp /usr/lib/libEGL.so.1.4
41bcf000 41bd7000 r-xp /usr/lib/libmdm-common.so.1.0.89
41bd8000 41d15000 r-xp /usr/lib/libicui18n.so.51.1
41d25000 41e09000 r-xp /usr/lib/libicuuc.so.51.1
41e1e000 41e21000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41e29000 41e31000 r-xp /usr/lib/libdrm.so.2.4.0
433c0000 433c5000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
433ce000 433d3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
433db000 433dd000 r-xp /usr/lib/libdri2.so.0.0.0
433e5000 43406000 r-xp /usr/lib/libexif.so.12.3.3
43419000 4341e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43426000 434f0000 r-xp /usr/lib/libCOREGL.so.4.0
43847000 4384b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44c93000 44c96000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44c9e000 44cd6000 r-xp /usr/lib/libpulse.so.0.16.2
44d09000 45508000 rwxp [stack:24611]
459c5000 459ca000 r-xp /usr/lib/libjson.so.0.0.1
459d2000 45a1a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a1b000 45a5e000 r-xp /usr/lib/libsndfile.so.1.0.25
45a6b000 45a8d000 r-xp /usr/lib/libvorbis.so.0.4.3
45a95000 45a99000 r-xp /usr/lib/libogg.so.0.7.1
bee76000 bee97000 rwxp [stack]
End of Maps Information

Callstack Information (PID:24474)
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
_effect(2955) > tobj_item_01 is null
05-26 20:35:26.904+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:35:26.909+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 20:35:26.909+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 20:35:26.909+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 20:35:26.909+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93cc8 : elm_scroller] CurrentPage(1)
05-26 20:35:26.964+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_resume(1012) > widget_resume
05-26 20:35:26.964+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppResume(721) > 
05-26 20:35:26.969+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:26.969+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:26.984+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 20:35:26.984+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 20:35:26.984+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 20:35:26.984+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:26.984+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:27.004+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 20:35:27.004+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:27.004+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:27.004+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:27.004+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 20:35:27.009+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4469) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-26 20:35:27.014+0900 I/APP_CORE(24474): appcore-efl.c: __do_app(429) > [APP 24474] Event: PAUSE State: RUNNING
05-26 20:35:27.014+0900 I/CAPI_APPFW_APPLICATION(24474): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-26 20:35:27.059+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-26 20:35:27.059+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 20:35:27.059+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:27.059+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-26 20:35:27.059+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESUME State: RUNNING
05-26 20:35:27.059+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 20:35:27.059+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 20:35:27.059+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 20:35:27.084+0900 W/W_HOME  (  726): event_manager.c: _home_scroll_cb(564) > scroll,done
05-26 20:35:27.134+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:27.134+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:27.309+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:27.309+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:27.409+0900 W/W_HOME  (  726): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
05-26 20:35:27.489+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:27.489+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:27.494+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 20:35:27.669+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:27.669+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:27.859+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:27.859+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 20:35:27.894+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:35:27.894+0900 E/CAPI_APPFW_APP_CONTROL( 1445): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 20:35:27.894+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1445]   [com.samsung.w-home]register msg port [true][0m
05-26 20:35:27.899+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 20:35:27.904+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 726
05-26 20:35:27.909+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1445]   [MUSIC_PLAYER_EVENT][0m
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 20:35:27.909+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:35:27.914+0900 W/W_HOME  (  726): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 20:35:27.914+0900 E/W_HOME  (  726): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 20:35:27.914+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1445]   [MUSIC_PLAYER_EVENT][0m
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 20:35:27.914+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:35:27.914+0900 W/W_HOME  (  726): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 20:35:27.914+0900 E/W_HOME  (  726): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 20:35:28.044+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:28.044+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:28.219+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-26 20:35:28.219+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-26 20:35:28.219+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-26 20:35:28.219+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-26 20:35:28.239+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:28.239+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:28.249+0900 W/STARTER (  696): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-26 20:35:28.404+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-26 20:35:28.404+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-26 20:35:28.409+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-26 20:35:28.409+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-26 20:35:28.434+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:28.434+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:28.469+0900 W/STARTER (  696): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-26 20:35:28.639+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:28.639+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:28.729+0900 W/STARTER (  696): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-26 20:35:28.734+0900 W/STARTER (  696): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-26 20:35:28.744+0900 E/STARTER (  696): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-26 20:35:28.749+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 20:35:28.764+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(1702) > caller pid : 696
05-26 20:35:28.774+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 20:35:28.774+0900 W/AUL_PAD (24473): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 20:35:28.774+0900 W/AUL_PAD (24473): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 20:35:28.774+0900 E/RESOURCED(  475): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 20:35:28.784+0900 I/CAPI_APPFW_APPLICATION(24585): app_main.c: app_efl_main(129) > app_efl_main
05-26 20:35:28.789+0900 I/CAPI_APPFW_APPLICATION(24585): app_main.c: app_appcore_create(152) > app_appcore_create
05-26 20:35:28.834+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:28.834+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:28.874+0900 E/AUL     (  696): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 20:35:28.874+0900 E/RESOURCED(  475): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-26 20:35:28.964+0900 I/efl-extension(24585): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445b46b8 = w: 0 h: 0  obj 0x445bde38 w: 360 h: 360
05-26 20:35:28.964+0900 I/efl-extension(24585): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-26 20:35:28.964+0900 I/efl-extension(24585): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 20:35:28.964+0900 I/efl-extension(24585): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 20:35:28.964+0900 I/efl-extension(24585): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 20:35:28.969+0900 I/efl-extension(24585): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 20:35:28.969+0900 I/efl-extension(24585): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445bde38, elm_image, _activated_obj : 0x0, activated : 1
05-26 20:35:29.024+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:29.024+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:29.069+0900 E/W_TASKMANAGER(24585): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-26 20:35:29.074+0900 E/W_TASKMANAGER(24585): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-26 20:35:29.074+0900 E/W_TASKMANAGER(24585): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-26 20:35:29.129+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.129+0900 E/W_TASKMANAGER(24585): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:35:29.134+0900 E/RUA     (24585): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 28, ncols : 5
05-26 20:35:29.164+0900 E/EFL     (24585): elementary<24585> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445bfab8 into part 'elm.swallow.event.0'
05-26 20:35:29.199+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05800003)
05-26 20:35:29.199+0900 I/APP_CORE(24585): appcore-efl.c: __do_app(429) > [APP 24585] Event: RESET State: CREATED
05-26 20:35:29.199+0900 I/CAPI_APPFW_APPLICATION(24585): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 20:35:29.214+0900 I/APP_CORE(24585): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 20:35:29.214+0900 I/APP_CORE(24585): appcore-efl.c: __do_app(474) > [APP 24585] Initial Launching, call the resume_cb
05-26 20:35:29.214+0900 I/CAPI_APPFW_APPLICATION(24585): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 20:35:29.224+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:29.224+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:29.229+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 20:35:29.229+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:29.229+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:29.229+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:29.229+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 20:35:29.229+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-26 20:35:29.239+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x05800003)
05-26 20:35:29.254+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 20:35:29.279+0900 W/APP_CORE(24585): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800003
05-26 20:35:29.344+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-26 20:35:29.344+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 20:35:29.344+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:29.344+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-26 20:35:29.344+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: PAUSE State: RUNNING
05-26 20:35:29.344+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 20:35:29.344+0900 W/W_HOME  (  726): main.c: _appcore_pause_cb(690) > appcore pause
05-26 20:35:29.344+0900 W/W_HOME  (  726): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 20:35:29.344+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:29.344+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:29.344+0900 W/W_HOME  (  726): main.c: home_pause(751) > clock/widget paused
05-26 20:35:29.344+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 20:35:29.349+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:35:29.349+0900 I/APP_CORE(24585): appcore-efl.c: __do_app(429) > [APP 24585] Event: RESUME State: RUNNING
05-26 20:35:29.359+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 20:35:29.359+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 20:35:29.364+0900 E/CAPI_APPFW_APP_CONTROL( 1445): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 20:35:29.369+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1445]   [com.samsung.w-home]register msg port [false][0m
05-26 20:35:29.419+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:29.419+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:29.434+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 20:35:29.434+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 20:35:29.434+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_pause(1001) > widget_pause
05-26 20:35:29.434+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppPause(713) > 
05-26 20:35:29.434+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:35:29.434+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:35:29.434+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:35:29.434+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:35:29.434+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:35:29.759+0900 E/AUL     (  474): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 20:35:29.809+0900 I/MALI    (24585): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x432fd5f8] swap changed from async to sync
05-26 20:35:29.849+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: MEM_FLUSH State: PAUSED
05-26 20:35:29.929+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 20:35:29.944+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24585
05-26 20:35:29.949+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 20:35:30.379+0900 I/efl-extension(24687): efl_extension.c: eext_mod_init(40) > Init
05-26 20:35:30.424+0900 I/UXT     (24687): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 20:35:30.449+0900 E/EFL     (24585): evas_main<24585> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=10640936 button=1 downs=1
05-26 20:35:30.454+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 20:35:30.454+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 20:35:30.524+0900 E/EFL     (24585): evas_main<24585> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=10641011 button=1 downs=0
05-26 20:35:30.544+0900 I/AUL_PAD (24687): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 20:35:30.579+0900 E/TBM     (24687): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 20:35:30.784+0900 E/EFL     (24585): elementary<24585> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573008), freeze(1)
05-26 20:35:30.784+0900 E/EFL     (24585): elementary<24585> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573008), freeze(1)
05-26 20:35:31.159+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 20:35:31.169+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24474
05-26 20:35:31.169+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 27
05-26 20:35:31.174+0900 I/APP_CORE(24474): appcore-efl.c: __do_app(429) > [APP 24474] Event: TERMINATE State: PAUSED
05-26 20:35:31.174+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 20:35:31.174+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 20:35:31.224+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 20:35:31.224+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 20:35:31.229+0900 E/APP_CORE(24585): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-26 20:35:31.229+0900 I/APP_CORE(24585): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 20:35:31.229+0900 I/APP_CORE(24585): appcore-efl.c: __after_loop(1090) > [APP 24585] PAUSE before termination
05-26 20:35:31.229+0900 I/CAPI_APPFW_APPLICATION(24585): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 20:35:31.229+0900 I/CAPI_APPFW_APPLICATION(24585): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-26 20:35:31.229+0900 I/efl-extension(24585): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44573008, obj: 0x44573008
05-26 20:35:31.229+0900 I/efl-extension(24585): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 20:35:31.229+0900 I/efl-extension(24585): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 20:35:31.229+0900 I/efl-extension(24585): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 20:35:31.229+0900 I/efl-extension(24585): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 20:35:31.234+0900 I/efl-extension(24585): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445bde38
05-26 20:35:31.234+0900 I/efl-extension(24585): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-26 20:35:31.234+0900 I/efl-extension(24585): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445b46b8 is freed
05-26 20:35:31.234+0900 I/efl-extension(24585): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:35:31.234+0900 I/efl-extension(24585): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44573008, elm_scroller, func : 0x437f2ef1
05-26 20:35:31.234+0900 I/efl-extension(24585): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:35:31.234+0900 I/efl-extension(24585): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:35:31.234+0900 I/efl-extension(24585): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445bde38, elm_image, func : 0x437f2ef1
05-26 20:35:31.234+0900 I/efl-extension(24585): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:35:31.234+0900 I/efl-extension(24585): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44573008 : elm_scroller] rotary callabck is deleted
05-26 20:35:31.254+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 20:35:31.254+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 20:35:31.274+0900 I/APP_CORE(24474): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 20:35:31.274+0900 I/CAPI_APPFW_APPLICATION(24474): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 20:35:31.369+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 20:35:31.374+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 20:35:31.374+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:31.374+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:31.374+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:31.374+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 20:35:31.374+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 20:35:31.374+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 20:35:31.374+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:31.374+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:31.374+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:35:31.379+0900 I/UXT     (24474): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 20:35:31.399+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-26 20:35:31.399+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 20:35:31.399+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:31.399+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-26 20:35:31.399+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESUME State: PAUSED
05-26 20:35:31.399+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 20:35:31.399+0900 W/W_HOME  (  726): main.c: _appcore_resume_cb(681) > appcore resume
05-26 20:35:31.399+0900 W/W_HOME  (  726): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 20:35:31.399+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:31.404+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:31.404+0900 W/W_HOME  (  726): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
05-26 20:35:31.404+0900 W/W_HOME  (  726): main.c: home_resume(733) > clock/widget resumed
05-26 20:35:31.404+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:31.404+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 20:35:31.404+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 20:35:31.404+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 20:35:31.409+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4469) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-26 20:35:31.424+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_resume(1012) > widget_resume
05-26 20:35:31.429+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppResume(721) > 
05-26 20:35:31.429+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:31.429+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:31.454+0900 I/MALI    (24585): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x432fd5f8] swap changed from sync to async
05-26 20:35:31.504+0900 I/MALI    (24585): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 20:35:31.504+0900 I/MALI    (24585): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=24585   close drm_fd=22 
05-26 20:35:31.504+0900 I/MALI    (24585): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 20:35:31.569+0900 I/UXT     (24585): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 20:35:31.624+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:35:31.624+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:35:31.699+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:35:31.699+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45c96248, elm_box, time_stamp : 10642173
05-26 20:35:31.699+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_rotary_cb(568) > Pass rotary event to home.
05-26 20:35:31.719+0900 W/W_HOME  (  726): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0x45ce3638 -> 360 0 0x4662f968
05-26 20:35:31.719+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45c93cc8 : elm_scroller] rotary callabck is called.
05-26 20:35:31.719+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45c93cc8 : elm_scroller] block(2)
05-26 20:35:31.719+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45c93cc8 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-26 20:35:31.719+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45c93cc8 : elm_scroller] content size (w, h)(2520, 360)
05-26 20:35:31.719+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45c93cc8 : elm_scroller] viewport size (w, h)(360, 360)
05-26 20:35:31.719+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45c93cc8 : elm_scroller] CurrentPage(1) DetentCount(1)
05-26 20:35:31.719+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-26 20:35:31.719+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-26 20:35:31.719+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-26 20:35:31.719+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45c93cc8 : elm_scroller] bring in 2 page
05-26 20:35:31.719+0900 W/W_HOME  (  726): event_manager.c: _home_scroll_cb(564) > scroll,start
05-26 20:35:31.724+0900 W/W_HOME  (  726): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
05-26 20:35:31.724+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:35:31.724+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:35:31.724+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:35:31.729+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-26 20:35:31.754+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:35:31.754+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:35:31.764+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:35:31.764+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:35:31.779+0900 W/W_HOME  (  726): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
05-26 20:35:31.784+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:35:31.784+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:35:31.799+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:35:31.799+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:35:31.814+0900 W/CRASH_MANAGER(24591): worker.c: worker_job(1199) > 1124474706831146426253
