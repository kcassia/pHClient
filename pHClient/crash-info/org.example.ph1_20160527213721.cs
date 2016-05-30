S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 20202
Date: 2016-05-27 21:37:21+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0x41469100

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x449795d8, r5   = 0x41561fb9
r6   = 0x44979ed8, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x44978858
r10  = 0x418870a8, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbee4f630
lr   = 0x404e41e8, pc   = 0x41469100
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     31636 KB
Buffers:     42548 KB
Cached:     138996 KB
VmPeak:      91788 KB
VmSize:      86204 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20776 KB
VmRSS:       18260 KB
VmData:      32952 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22996 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 20202 TID = 20202
20202 20251 20277 

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
44092000 44891000 rwxp [stack:20277]
44c94000 45493000 rwxp [stack:20251]
bee2f000 bee50000 rwxp [stack]
End of Maps Information

Callstack Information (PID:20202)
Call Stack Count: 1
 0: (0x41469100) (null)
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
fo.is_win_on_top: 0
05-27 21:37:02.823+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 21:37:02.823+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 21:37:02.828+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-27 21:37:02.903+0900 W/APP_CORE(20202): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
05-27 21:37:02.998+0900 I/APP_CORE(20202): appcore-efl.c: __do_app(429) > [APP 20202] Event: RESUME State: RUNNING
05-27 21:37:03.003+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-27 21:37:03.003+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-27 21:37:03.003+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:03.003+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-27 21:37:03.003+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: PAUSE State: RUNNING
05-27 21:37:03.003+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 21:37:03.003+0900 W/W_HOME  (  732): main.c: _appcore_pause_cb(690) > appcore pause
05-27 21:37:03.003+0900 W/W_HOME  (  732): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-27 21:37:03.003+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:03.008+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:03.008+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:03.008+0900 W/W_HOME  (  732): rotary.c: rotary_deattach(156) > rotary_deattach:0x45d4d480
05-27 21:37:03.008+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 21:37:03.008+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45d4d480, elm_layout, func : 0x4004b469
05-27 21:37:03.008+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 21:37:03.008+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 21:37:03.008+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 21:37:03.008+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96570, elm_box, _activated_obj : 0x45d4d480, activated : 1
05-27 21:37:03.008+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 21:37:03.008+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 21:37:03.008+0900 I/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 39, 218.
05-27 21:37:03.008+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-27 21:37:03.013+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:37:03.013+0900 E/CAPI_APPFW_APP_CONTROL( 1241): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-27 21:37:03.013+0900 W/MUSIC_CONTROL_SERVICE( 1241): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1241]   [com.samsung.w-home]register msg port [false][0m
05-27 21:37:03.013+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 21:37:03.013+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 21:37:03.093+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-27 21:37:03.093+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 21:37:03.103+0900 W/APPS    (  732): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-27 21:37:03.338+0900 E/AUL     (  492): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 21:37:03.433+0900 E/EFL     (20202): evas_main<20202> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8744326 button=1 downs=1
05-27 21:37:03.473+0900 E/EFL     (20202): evas_main<20202> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8744411 button=1 downs=0
05-27 21:37:03.488+0900 D/TIMER   (20202): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-27 21:37:03.488+0900 D/TIMER   (20202): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-27 21:37:03.513+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-27 21:37:03.548+0900 I/efl-extension(20202): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-27 21:37:03.548+0900 I/efl-extension(20202): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-27 21:37:03.548+0900 I/efl-extension(20202): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-27 21:37:03.553+0900 I/efl-extension(20202): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-27 21:37:03.553+0900 I/efl-extension(20202): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41897588, elm_layout, _activated_obj : 0x0, activated : 1
05-27 21:37:03.658+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 21:37:03.673+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20202
05-27 21:37:03.673+0900 W/AUL_AMD (  492): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-27 21:37:03.673+0900 W/AUL_AMD (  492): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-27 21:37:03.673+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 21:37:03.943+0900 I/AUL_PAD (20255): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-27 21:37:04.288+0900 E/EFL     (20202): evas_main<20202> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8745225 button=1 downs=1
05-27 21:37:04.333+0900 E/EFL     (20202): evas_main<20202> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8745269 button=1 downs=0
05-27 21:37:04.713+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.713+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.713+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745649
05-27 21:37:04.753+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.753+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.753+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745691
05-27 21:37:04.778+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.783+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.783+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745717
05-27 21:37:04.803+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.803+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.803+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745740
05-27 21:37:04.838+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.838+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.838+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745775
05-27 21:37:04.903+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.903+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.903+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745839
05-27 21:37:04.948+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.948+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.948+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745883
05-27 21:37:04.968+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.968+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.968+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745906
05-27 21:37:04.998+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.998+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:04.998+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745937
05-27 21:37:05.018+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:05.018+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:05.018+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745955
05-27 21:37:05.048+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:05.048+0900 I/efl-extension(20202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:37:05.048+0900 I/efl-extension(20202): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897588, elm_layout, time_stamp : 8745984
05-27 21:37:06.228+0900 E/EFL     (20202): evas_main<20202> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8747161 button=1 downs=1
05-27 21:37:06.348+0900 E/EFL     (20202): evas_main<20202> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8747285 button=1 downs=0
05-27 21:37:06.348+0900 D/TIMER   (20202): Setting time is 660
05-27 21:37:06.348+0900 I/efl-extension(20202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 21:37:06.348+0900 I/efl-extension(20202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x41897588, elm_layout, func : 0x41560b09
05-27 21:37:06.348+0900 I/efl-extension(20202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 21:37:06.348+0900 I/efl-extension(20202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 21:37:06.348+0900 I/efl-extension(20202): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 21:37:06.348+0900 I/efl-extension(20202): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 21:37:06.348+0900 I/efl-extension(20202): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 21:37:06.348+0900 I/efl-extension(20202): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 21:37:06.428+0900 I/SOCKETTEST(20202): Success to create socket
05-27 21:37:06.428+0900 I/SOCKETTEST(20202): socket connect error: Network is unreachable
05-27 21:37:06.428+0900 I/SOCKETTEST(20202): write() error: Bad file descriptor
05-27 21:37:06.483+0900 I/SENSOR  (20202): -137.270004, 9.940000, 23.309999
05-27 21:37:06.568+0900 I/SENSOR  (20202): 0.630000, -27.299999, 4.130000
05-27 21:37:06.673+0900 I/SENSOR  (20202): 0.630000, -12.740000, 7.770000
05-27 21:37:06.718+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-27 21:37:06.773+0900 I/SENSOR  (20202): -3.010000, -7.980000, 4.480000
05-27 21:37:06.873+0900 I/SENSOR  (20202): -2.870000, -2.940000, 3.920000
05-27 21:37:06.978+0900 I/SENSOR  (20202): -1.960000, -8.120000, 4.620000
05-27 21:37:07.078+0900 I/SENSOR  (20202): -3.430000, -38.290001, -4.480000
05-27 21:37:07.178+0900 I/SENSOR  (20202): 0.700000, -37.450001, -3.990000
05-27 21:37:07.278+0900 I/SENSOR  (20202): -2.310000, -17.570000, -0.280000
05-27 21:37:07.378+0900 I/SENSOR  (20202): -0.770000, -5.880000, 2.310000
05-27 21:37:07.548+0900 I/SENSOR  (20202): -1.400000, -4.130000, 1.540000
05-27 21:37:07.573+0900 I/SENSOR  (20202): -5.040000, 1.540000, 4.830000
05-27 21:37:07.678+0900 I/SENSOR  (20202): -0.070000, -2.240000, 4.480000
05-27 21:37:07.778+0900 I/SENSOR  (20202): -0.560000, -1.960000, 3.500000
05-27 21:37:07.878+0900 I/SENSOR  (20202): -1.330000, -3.220000, 3.920000
05-27 21:37:07.978+0900 I/SENSOR  (20202): -5.600000, -4.200000, 1.680000
05-27 21:37:08.018+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-27 21:37:08.078+0900 I/SENSOR  (20202): -2.660000, -2.870000, 4.060000
05-27 21:37:08.178+0900 I/SENSOR  (20202): -0.770000, -1.890000, 3.360000
05-27 21:37:08.278+0900 I/SENSOR  (20202): -2.380000, -3.430000, 5.250000
05-27 21:37:08.378+0900 I/SENSOR  (20202): -1.540000, -2.730000, 3.990000
05-27 21:37:08.548+0900 I/SENSOR  (20202): -0.700000, -2.940000, 3.360000
05-27 21:37:08.573+0900 I/SENSOR  (20202): -1.540000, -2.870000, 3.010000
05-27 21:37:08.673+0900 I/SENSOR  (20202): -2.170000, -4.550000, 4.340000
05-27 21:37:08.778+0900 I/SENSOR  (20202): -1.400000, -4.200000, 5.950000
05-27 21:37:08.878+0900 I/SENSOR  (20202): -1.470000, -3.500000, 4.900000
05-27 21:37:08.978+0900 I/SENSOR  (20202): -0.210000, -4.270000, 3.360000
05-27 21:37:09.078+0900 I/SENSOR  (20202): -1.890000, -3.570000, 3.710000
05-27 21:37:09.178+0900 I/SENSOR  (20202): -1.890000, -3.920000, 5.530000
05-27 21:37:09.278+0900 I/SENSOR  (20202): 1.190000, -2.520000, 5.040000
05-27 21:37:09.378+0900 I/SENSOR  (20202): -0.070000, -5.040000, 4.760000
05-27 21:37:09.563+0900 I/SENSOR  (20202): -5.180000, -7.420000, 3.920000
05-27 21:37:09.573+0900 I/SENSOR  (20202): -0.980000, -3.990000, 3.430000
05-27 21:37:09.673+0900 I/SENSOR  (20202): -0.630000, -2.520000, 2.660000
05-27 21:37:09.778+0900 I/SENSOR  (20202): -1.890000, -3.080000, 2.940000
05-27 21:37:09.878+0900 I/SENSOR  (20202): -3.990000, -1.470000, 2.870000
05-27 21:37:09.978+0900 I/SENSOR  (20202): -1.610000, -1.890000, 4.270000
05-27 21:37:10.078+0900 I/SENSOR  (20202): -1.400000, -3.290000, 4.060000
05-27 21:37:10.178+0900 I/SENSOR  (20202): -0.350000, -3.850000, 2.660000
05-27 21:37:10.278+0900 I/SENSOR  (20202): -0.980000, -6.300000, 3.080000
05-27 21:37:10.378+0900 I/SENSOR  (20202): -0.840000, -3.220000, 3.080000
05-27 21:37:10.538+0900 I/SENSOR  (20202): -2.450000, -4.270000, 4.130000
05-27 21:37:10.573+0900 I/SENSOR  (20202): 0.210000, -4.200000, 3.710000
05-27 21:37:10.678+0900 I/SENSOR  (20202): -0.210000, -3.500000, 4.340000
05-27 21:37:10.783+0900 I/SENSOR  (20202): 0.490000, -3.780000, 3.290000
05-27 21:37:10.878+0900 I/SENSOR  (20202): -0.560000, -3.570000, 3.430000
05-27 21:37:10.978+0900 I/SENSOR  (20202): -1.120000, -3.150000, 2.660000
05-27 21:37:11.083+0900 I/SENSOR  (20202): -0.560000, -2.590000, 2.660000
05-27 21:37:11.178+0900 I/SENSOR  (20202): 0.280000, -2.450000, 1.050000
05-27 21:37:11.278+0900 I/SENSOR  (20202): -1.120000, -3.850000, 1.960000
05-27 21:37:11.378+0900 I/SENSOR  (20202): -1.120000, -2.590000, 2.240000
05-27 21:37:11.483+0900 I/SENSOR  (20202): 1.330000, -2.380000, 2.310000
05-27 21:37:11.578+0900 I/SENSOR  (20202): 0.350000, -2.100000, 3.150000
05-27 21:37:11.683+0900 I/SENSOR  (20202): 0.420000, -2.940000, 3.920000
05-27 21:37:11.783+0900 I/SENSOR  (20202): -1.400000, -4.060000, 4.760000
05-27 21:37:11.883+0900 I/SENSOR  (20202): 1.050000, -3.290000, 5.180000
05-27 21:37:11.978+0900 I/SENSOR  (20202): -0.490000, -2.520000, 3.920000
05-27 21:37:12.083+0900 I/SENSOR  (20202): -0.840000, -2.590000, 4.270000
05-27 21:37:12.183+0900 I/SENSOR  (20202): -0.840000, -5.670000, 4.410000
05-27 21:37:12.283+0900 I/SENSOR  (20202): 0.560000, -5.740000, 5.530000
05-27 21:37:12.383+0900 I/SENSOR  (20202): 0.560000, -5.390000, 4.200000
05-27 21:37:12.483+0900 I/SENSOR  (20202): -0.700000, -3.500000, 5.040000
05-27 21:37:12.578+0900 I/SENSOR  (20202): -0.350000, 0.420000, 2.170000
05-27 21:37:12.683+0900 I/SENSOR  (20202): -3.150000, -5.110000, 7.420000
05-27 21:37:12.783+0900 I/SENSOR  (20202): -2.030000, -1.750000, 6.580000
05-27 21:37:12.883+0900 I/SENSOR  (20202): -0.210000, -0.140000, 3.290000
05-27 21:37:12.983+0900 I/SENSOR  (20202): -3.710000, -2.380000, 3.500000
05-27 21:37:13.083+0900 I/SENSOR  (20202): 0.560000, -1.750000, 2.170000
05-27 21:37:13.193+0900 I/SENSOR  (20202): -0.980000, -2.870000, 3.780000
05-27 21:37:13.283+0900 I/SENSOR  (20202): -1.470000, -2.170000, 4.760000
05-27 21:37:13.393+0900 I/SENSOR  (20202): -1.610000, -1.470000, 4.060000
05-27 21:37:13.483+0900 I/SENSOR  (20202): -0.490000, -2.310000, 4.760000
05-27 21:37:13.578+0900 I/SENSOR  (20202): -0.980000, -2.660000, 4.480000
05-27 21:37:13.683+0900 I/SENSOR  (20202): -0.490000, -4.060000, 4.200000
05-27 21:37:13.783+0900 I/SENSOR  (20202): 0.490000, -2.240000, 3.850000
05-27 21:37:13.883+0900 I/SENSOR  (20202): 1.120000, -1.470000, 2.940000
05-27 21:37:13.983+0900 I/SENSOR  (20202): 0.910000, -4.760000, 1.820000
05-27 21:37:14.083+0900 I/SENSOR  (20202): -0.070000, -5.390000, 1.540000
05-27 21:37:14.183+0900 I/SENSOR  (20202): -1.190000, -3.500000, 3.850000
05-27 21:37:14.283+0900 I/SENSOR  (20202): -1.610000, -3.430000, 0.490000
05-27 21:37:14.383+0900 I/SENSOR  (20202): -1.260000, -3.010000, 1.890000
05-27 21:37:14.483+0900 I/SENSOR  (20202): -2.030000, -3.570000, 3.360000
05-27 21:37:14.578+0900 I/SENSOR  (20202): -1.680000, -3.500000, 4.340000
05-27 21:37:14.683+0900 I/SENSOR  (20202): -0.700000, -2.240000, 2.730000
05-27 21:37:14.783+0900 I/SENSOR  (20202): -1.540000, -3.360000, 3.500000
05-27 21:37:14.883+0900 I/SENSOR  (20202): -1.050000, -3.430000, 3.780000
05-27 21:37:14.988+0900 I/SENSOR  (20202): -1.190000, -3.010000, 4.270000
05-27 21:37:15.083+0900 I/SENSOR  (20202): -0.140000, -2.940000, 4.620000
05-27 21:37:15.188+0900 I/SENSOR  (20202): 0.700000, -3.080000, 4.760000
05-27 21:37:15.283+0900 I/SENSOR  (20202): 0.560000, -3.570000, 3.850000
05-27 21:37:15.388+0900 I/SENSOR  (20202): 0.210000, -3.500000, 4.760000
05-27 21:37:15.483+0900 I/SENSOR  (20202): 0.350000, -2.870000, 5.390000
05-27 21:37:15.583+0900 I/SENSOR  (20202): 0.280000, -3.290000, 5.320000
05-27 21:37:15.683+0900 I/SENSOR  (20202): -0.770000, -1.890000, 2.940000
05-27 21:37:15.783+0900 I/SENSOR  (20202): 0.210000, -3.080000, 4.550000
05-27 21:37:15.883+0900 I/SENSOR  (20202): -1.400000, -3.710000, 5.390000
05-27 21:37:15.978+0900 I/SENSOR  (20202): -0.280000, -1.820000, 4.130000
05-27 21:37:16.083+0900 I/SENSOR  (20202): 0.630000, -2.310000, 4.830000
05-27 21:37:16.188+0900 I/SENSOR  (20202): -0.630000, -3.220000, 3.360000
05-27 21:37:16.283+0900 I/SENSOR  (20202): 0.980000, -1.820000, 3.080000
05-27 21:37:16.383+0900 I/SENSOR  (20202): -1.190000, -2.730000, 3.500000
05-27 21:37:16.483+0900 I/SENSOR  (20202): -1.470000, -3.290000, 3.570000
05-27 21:37:16.583+0900 I/SENSOR  (20202): -0.420000, -3.010000, 4.130000
05-27 21:37:16.683+0900 I/SENSOR  (20202): -0.910000, -3.710000, 4.550000
05-27 21:37:16.783+0900 I/SENSOR  (20202): -1.750000, -3.570000, 3.920000
05-27 21:37:16.888+0900 I/SENSOR  (20202): 0.980000, -2.380000, 3.290000
05-27 21:37:16.988+0900 I/SENSOR  (20202): 0.350000, -1.960000, 2.730000
05-27 21:37:17.088+0900 I/SENSOR  (20202): -0.350000, -3.710000, 4.200000
05-27 21:37:17.183+0900 I/SENSOR  (20202): -1.050000, -3.570000, 5.320000
05-27 21:37:17.283+0900 I/SENSOR  (20202): -0.280000, -1.960000, 4.620000
05-27 21:37:17.383+0900 I/SENSOR  (20202): -2.730000, -3.150000, 4.410000
05-27 21:37:17.553+0900 I/SENSOR  (20202): -0.980000, -2.240000, 6.230000
05-27 21:37:17.583+0900 I/SENSOR  (20202): 3.010000, -4.970000, 6.510000
05-27 21:37:17.683+0900 I/SENSOR  (20202): -0.700000, -2.730000, 5.320000
05-27 21:37:17.783+0900 I/SENSOR  (20202): -4.620000, -6.230000, 4.410000
05-27 21:37:17.883+0900 I/SENSOR  (20202): -0.910000, -2.800000, 10.500000
05-27 21:37:17.983+0900 I/SENSOR  (20202): 10.080000, 15.400000, 16.030001
05-27 21:37:18.093+0900 I/SENSOR  (20202): 15.960000, 54.389999, 9.380000
05-27 21:37:18.193+0900 I/SENSOR  (20202): 38.639999, 23.940001, -17.639999
05-27 21:37:18.288+0900 I/SENSOR  (20202): 51.170002, 32.900002, 14.420000
05-27 21:37:18.388+0900 I/SENSOR  (20202): 41.090000, 18.690001, 3.710000
05-27 21:37:18.523+0900 I/SENSOR  (20202): -7.280000, -21.840000, 5.110000
05-27 21:37:18.583+0900 I/SENSOR  (20202): 37.520000, -47.950001, 19.530001
05-27 21:37:18.623+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-27 21:37:18.623+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-27 21:37:18.623+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-27 21:37:18.623+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-27 21:37:18.688+0900 I/SENSOR  (20202): 35.000000, 21.559999, 18.900000
05-27 21:37:18.738+0900 W/STARTER (  711): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-27 21:37:18.783+0900 I/SENSOR  (20202): -29.960001, -13.930000, -15.540000
05-27 21:37:18.838+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-27 21:37:18.838+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-27 21:37:18.838+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-27 21:37:18.838+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-27 21:37:18.883+0900 I/SENSOR  (20202): -1.750000, 8.820000, 24.500000
05-27 21:37:18.938+0900 W/STARTER (  711): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-27 21:37:18.983+0900 I/SENSOR  (20202): -48.090000, 6.020000, 0.840000
05-27 21:37:19.083+0900 I/SENSOR  (20202): -12.250000, -10.570000, 10.920000
05-27 21:37:19.193+0900 W/STARTER (  711): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-27 21:37:19.198+0900 I/SENSOR  (20202): -3.850000, -4.690000, -5.250000
05-27 21:37:19.203+0900 W/STARTER (  711): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-27 21:37:19.238+0900 E/STARTER (  711): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-27 21:37:19.238+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 0
05-27 21:37:19.248+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 711
05-27 21:37:19.253+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(2080) > pad pid(-5)
05-27 21:37:19.253+0900 W/AUL_PAD ( 1171): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-27 21:37:19.253+0900 W/AUL_PAD ( 1171): launchpad.c: __send_result_to_caller(272) > Check app launching
05-27 21:37:19.273+0900 E/RESOURCED(  493): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-27 21:37:19.273+0900 I/CAPI_APPFW_APPLICATION(20231): app_main.c: app_efl_main(129) > app_efl_main
05-27 21:37:19.278+0900 I/CAPI_APPFW_APPLICATION(20231): app_main.c: app_appcore_create(152) > app_appcore_create
05-27 21:37:19.283+0900 I/SENSOR  (20202): 4.060000, 14.210000, 24.710001
05-27 21:37:19.358+0900 E/AUL     (  711): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 21:37:19.358+0900 E/RESOURCED(  493): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-27 21:37:19.383+0900 I/SENSOR  (20202): 3.150000, 12.880000, -1.750000
05-27 21:37:19.453+0900 I/efl-extension(20231): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445dada0 = w: 0 h: 0  obj 0x445be750 w: 360 h: 360
05-27 21:37:19.453+0900 I/efl-extension(20231): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-27 21:37:19.458+0900 I/efl-extension(20231): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-27 21:37:19.458+0900 I/efl-extension(20231): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-27 21:37:19.458+0900 I/efl-extension(20231): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-27 21:37:19.458+0900 I/efl-extension(20231): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-27 21:37:19.458+0900 I/efl-extension(20231): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445be750, elm_image, _activated_obj : 0x0, activated : 1
05-27 21:37:19.483+0900 I/SENSOR  (20202): 0.490000, 6.790000, 4.270000
05-27 21:37:19.553+0900 E/W_TASKMANAGER(20231): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-27 21:37:19.558+0900 E/W_TASKMANAGER(20231): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-27 21:37:19.558+0900 E/W_TASKMANAGER(20231): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-27 21:37:19.583+0900 I/SENSOR  (20202): -20.860001, 27.719999, 9.940000
05-27 21:37:19.598+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.598+0900 E/W_TASKMANAGER(20231): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:37:19.603+0900 E/RUA     (20231): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 17, ncols : 5
05-27 21:37:19.633+0900 E/EFL     (20231): elementary<20231> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c03d0 into part 'elm.swallow.event.0'
05-27 21:37:19.678+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05a00003)
05-27 21:37:19.678+0900 I/APP_CORE(20231): appcore-efl.c: __do_app(429) > [APP 20231] Event: RESET State: CREATED
05-27 21:37:19.678+0900 I/CAPI_APPFW_APPLICATION(20231): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-27 21:37:19.683+0900 I/SENSOR  (20202): -4.130000, 25.830000, 26.530001
05-27 21:37:19.698+0900 I/APP_CORE(20231): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-27 21:37:19.698+0900 I/APP_CORE(20231): appcore-efl.c: __do_app(474) > [APP 20231] Initial Launching, call the resume_cb
05-27 21:37:19.698+0900 I/CAPI_APPFW_APPLICATION(20231): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 21:37:19.713+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x05a00003)
05-27 21:37:19.748+0900 W/APP_CORE(20231): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5a00003
05-27 21:37:19.783+0900 I/SENSOR  (20202): -13.370000, 15.680000, 8.190000
05-27 21:37:19.813+0900 I/APP_CORE(20202): appcore-efl.c: __do_app(429) > [APP 20202] Event: PAUSE State: RUNNING
05-27 21:37:19.813+0900 I/CAPI_APPFW_APPLICATION(20202): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-27 21:37:19.828+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 21:37:19.828+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 21:37:19.833+0900 I/APP_CORE(20231): appcore-efl.c: __do_app(429) > [APP 20231] Event: RESUME State: RUNNING
05-27 21:37:19.978+0900 I/SENSOR  (20202): -4.270000, 25.129999, 16.590000
05-27 21:37:19.988+0900 I/SENSOR  (20202): 0.420000, -0.490000, -1.750000
05-27 21:37:20.083+0900 I/SENSOR  (20202): 0.420000, 1.820000, 1.400000
05-27 21:37:20.183+0900 I/SENSOR  (20202): -1.330000, 8.610000, 52.150002
05-27 21:37:20.218+0900 E/AUL     (  492): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 21:37:20.253+0900 I/MALI    (20231): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-27 21:37:20.288+0900 I/SENSOR  (20202): -16.520000, 15.540000, 31.780001
05-27 21:37:20.393+0900 I/SENSOR  (20202): 18.549999, -21.000000, -3.710000
05-27 21:37:20.433+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 21:37:20.443+0900 E/EFL     (20231): evas_main<20231> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8761381 button=1 downs=1
05-27 21:37:20.448+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20231
05-27 21:37:20.468+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 21:37:20.478+0900 E/EFL     (20231): evas_main<20231> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8761402 button=1 downs=0
05-27 21:37:20.483+0900 I/SENSOR  (20202): 9.100000, 0.630000, 3.570000
05-27 21:37:20.583+0900 I/SENSOR  (20202): 9.450000, -9.730000, -6.580000
05-27 21:37:20.683+0900 I/SENSOR  (20202): 1.610000, -14.980000, -1.120000
05-27 21:37:20.768+0900 E/EFL     (20231): elementary<20231> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573568), freeze(1)
05-27 21:37:20.768+0900 E/EFL     (20231): elementary<20231> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573568), freeze(1)
05-27 21:37:20.783+0900 I/SENSOR  (20202): 9.100000, -22.540001, -4.340000
05-27 21:37:20.828+0900 I/efl-extension(20326): efl_extension.c: eext_mod_init(40) > Init
05-27 21:37:20.878+0900 I/UXT     (20326): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-27 21:37:20.888+0900 I/SENSOR  (20202): 6.160000, -12.040000, -4.270000
05-27 21:37:20.988+0900 I/SENSOR  (20202): 16.240000, -16.100000, -6.860000
05-27 21:37:20.988+0900 I/AUL_PAD (20326): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-27 21:37:21.028+0900 E/TBM     (20326): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-27 21:37:21.083+0900 I/SENSOR  (20202): 10.850000, -10.220000, -2.380000
05-27 21:37:21.143+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 21:37:21.148+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20202
05-27 21:37:21.153+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 27
05-27 21:37:21.153+0900 I/APP_CORE(20202): appcore-efl.c: __do_app(429) > [APP 20202] Event: TERMINATE State: PAUSED
05-27 21:37:21.158+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 21:37:21.158+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 21:37:21.173+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 21:37:21.173+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 21:37:21.178+0900 E/APP_CORE(20231): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-27 21:37:21.178+0900 I/APP_CORE(20231): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 21:37:21.178+0900 I/APP_CORE(20231): appcore-efl.c: __after_loop(1090) > [APP 20231] PAUSE before termination
05-27 21:37:21.178+0900 I/CAPI_APPFW_APPLICATION(20231): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 21:37:21.178+0900 I/CAPI_APPFW_APPLICATION(20231): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-27 21:37:21.178+0900 I/efl-extension(20231): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44573568, obj: 0x44573568
05-27 21:37:21.178+0900 I/efl-extension(20231): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 21:37:21.178+0900 I/efl-extension(20231): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 21:37:21.178+0900 I/efl-extension(20231): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 21:37:21.178+0900 I/efl-extension(20231): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 21:37:21.203+0900 I/efl-extension(20231): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445be750
05-27 21:37:21.203+0900 I/efl-extension(20231): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 21:37:21.203+0900 I/efl-extension(20231): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445dada0 is freed
05-27 21:37:21.203+0900 I/efl-extension(20231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 21:37:21.203+0900 I/efl-extension(20231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44573568, elm_scroller, func : 0x437c8ef1
05-27 21:37:21.203+0900 I/efl-extension(20231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 21:37:21.203+0900 I/efl-extension(20231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 21:37:21.203+0900 I/efl-extension(20231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445be750, elm_image, func : 0x437c8ef1
05-27 21:37:21.203+0900 I/efl-extension(20231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 21:37:21.203+0900 I/efl-extension(20231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44573568 : elm_scroller] rotary callabck is deleted
05-27 21:37:21.253+0900 I/APP_CORE(20202): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 21:37:21.253+0900 I/CAPI_APPFW_APPLICATION(20202): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 21:37:21.293+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-27 21:37:21.298+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-27 21:37:21.298+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 21:37:21.303+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:37:21.303+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:37:21.303+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:37:21.308+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 21:37:21.308+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 21:37:21.353+0900 I/efl-extension(20202): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x41897588
05-27 21:37:21.353+0900 I/efl-extension(20202): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x41897588, obj: 0x41897588
05-27 21:37:21.353+0900 I/efl-extension(20202): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 21:37:21.363+0900 I/SENSOR  (20202): 8.260000, -12.110000, -5.250000
05-27 21:37:21.363+0900 I/SENSOR  (20202): 5.320000, -13.230000, -2.310000
05-27 21:37:21.368+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 21:37:21.368+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:21.368+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:21.373+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:21.373+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 21:37:21.393+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 21:37:21.393+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 21:37:21.393+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:21.393+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 21:37:21.393+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-27 21:37:21.393+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 21:37:21.393+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-27 21:37:21.393+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-27 21:37:21.393+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:21.398+0900 I/MALI    (20231): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-27 21:37:21.408+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:21.408+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:37:21.408+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 21:37:21.408+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x45d4d480
05-27 21:37:21.408+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d4d480, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 21:37:21.408+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 21:37:21.413+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 21:37:21.413+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 21:37:21.413+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 21:37:21.413+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 21:37:21.413+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 21:37:21.413+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 21:37:21.413+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 21:37:21.423+0900 I/MALI    (20231): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-27 21:37:21.423+0900 I/MALI    (20231): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=20231   close drm_fd=22 
05-27 21:37:21.423+0900 I/MALI    (20231): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-27 21:37:21.453+0900 I/UXT     (20202): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 21:37:21.473+0900 I/UXT     (20231): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 21:37:21.738+0900 I/efl-extension(20231): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-27 21:37:21.818+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 21:37:21.843+0900 W/CRASH_MANAGER(20184): worker.c: worker_job(1199) > 1120202706831146435264
