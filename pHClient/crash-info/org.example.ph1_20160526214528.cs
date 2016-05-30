S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 4614
Date: 2016-05-26 21:45:28+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x702f6374

Register Information
r0   = 0x702f6374, r1   = 0x00000025
r2   = 0xbe9cc1fc, r3   = 0x0000feff
r4   = 0x702f6370, r5   = 0x702f6374
r6   = 0xbe9cbcc8, r7   = 0x25252525
r8   = 0x00000000, r9   = 0x4142dec0
r10  = 0x702f6374, fp   = 0xbe9cbcbc
ip   = 0x702f6374, sp   = 0xbe9cb748
lr   = 0x404b1f5c, pc   = 0x404ec6dc
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     18816 KB
Buffers:     20924 KB
Cached:     171276 KB
VmPeak:      91172 KB
VmSize:      89644 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20048 KB
VmRSS:       20048 KB
VmData:      33008 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23188 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4614 TID = 4614
4614 4634 

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
4195c000 41967000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
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
43843000 4384e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43857000 4385b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43863000 4387a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43887000 43889000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
448da000 448db000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44a8c000 4528b000 rwxp [stack:4634]
be9ac000 be9cd000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4614)
Call Stack Count: 1
 0: strchrnul + 0xb8 (0x404ec6dc) [/lib/libc.so.6] + 0x776dc
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
.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:45:13.436+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:45:13.436+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:45:13.436+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 21:45:13.436+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:45:13.436+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 21:45:13.436+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:45:13.436+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:45:13.436+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:45:13.436+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 21:45:13.436+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:45:13.436+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:45:13.436+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 34, 218.
05-26 21:45:13.436+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:45:13.456+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:45:13.456+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 21:45:13.456+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 21:45:13.461+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:45:13.461+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:45:13.481+0900 I/APP_CORE( 4614): appcore-efl.c: __do_app(429) > [APP 4614] Event: RESUME State: RUNNING
05-26 21:45:13.596+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 21:45:13.596+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:45:13.616+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 21:45:13.846+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:45:13.966+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:45:14.276+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:45:14.286+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4614
05-26 21:45:14.291+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:45:14.486+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=751533 button=1 downs=1
05-26 21:45:14.506+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=751554 button=1 downs=0
05-26 21:45:14.521+0900 D/TIMER   ( 4614): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:45:14.521+0900 D/TIMER   ( 4614): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:45:14.571+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:45:14.571+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:45:14.571+0900 I/efl-extension( 4614): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:45:14.576+0900 I/efl-extension( 4614): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:45:14.576+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44903a58, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:45:15.236+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=752285 button=1 downs=1
05-26 21:45:15.311+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=752360 button=1 downs=0
05-26 21:45:15.766+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=752814 button=1 downs=1
05-26 21:45:15.841+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=752890 button=1 downs=0
05-26 21:45:15.911+0900 I/AUL_PAD ( 4636): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 21:45:16.386+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=753437 button=1 downs=1
05-26 21:45:16.441+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=753491 button=1 downs=0
05-26 21:45:17.531+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=754578 button=1 downs=1
05-26 21:45:17.626+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=754675 button=1 downs=0
05-26 21:45:17.996+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=755046 button=1 downs=1
05-26 21:45:18.091+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=755143 button=1 downs=0
05-26 21:45:18.476+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:45:18.891+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:18.891+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:18.891+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903a58, elm_layout, time_stamp : 755942
05-26 21:45:18.896+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:18.966+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:18.971+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:18.971+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903a58, elm_layout, time_stamp : 756014
05-26 21:45:18.971+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:19.016+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:19.016+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:19.016+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903a58, elm_layout, time_stamp : 756067
05-26 21:45:19.016+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:19.081+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:19.081+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:19.081+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903a58, elm_layout, time_stamp : 756132
05-26 21:45:19.081+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:19.466+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:19.466+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:19.466+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903a58, elm_layout, time_stamp : 756517
05-26 21:45:19.466+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:19.516+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:19.516+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:19.516+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903a58, elm_layout, time_stamp : 756564
05-26 21:45:19.516+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:19.571+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:19.571+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:19.571+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903a58, elm_layout, time_stamp : 756621
05-26 21:45:19.571+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:20.541+0900 I/efl-extension( 4614): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44903a58
05-26 21:45:20.541+0900 I/efl-extension( 4614): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44903a58, obj: 0x44903a58
05-26 21:45:20.541+0900 I/efl-extension( 4614): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:45:20.541+0900 I/efl-extension( 4614): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:45:20.541+0900 I/efl-extension( 4614): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:45:20.541+0900 I/efl-extension( 4614): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:45:20.651+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=757702 button=1 downs=1
05-26 21:45:20.671+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=757722 button=1 downs=0
05-26 21:45:20.671+0900 D/TIMER   ( 4614): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:45:20.676+0900 D/TIMER   ( 4614): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:45:20.681+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:45:20.681+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x452903f0, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:45:20.851+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 37 -> 36 1464266720 90
05-26 21:45:20.851+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 36 1160 320 696
05-26 21:45:20.851+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 36 0 0 895
05-26 21:45:20.851+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 36 1025 202 615
05-26 21:45:20.851+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 36 128 5 77
05-26 21:45:20.851+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 36 325 39 195
05-26 21:45:21.291+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=758340 button=1 downs=1
05-26 21:45:21.351+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=758400 button=1 downs=0
05-26 21:45:21.811+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.816+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.816+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 758862
05-26 21:45:21.816+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:21.846+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.851+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.851+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 758898
05-26 21:45:21.851+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:21.876+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.876+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.876+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 758926
05-26 21:45:21.876+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:21.891+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.891+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.891+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 758941
05-26 21:45:21.891+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:21.916+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.916+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.916+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 758965
05-26 21:45:21.916+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:21.951+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.951+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:21.951+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 758998
05-26 21:45:21.951+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.001+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.001+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759048
05-26 21:45:22.001+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.001+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.031+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.031+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.031+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759080
05-26 21:45:22.031+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.071+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.071+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.071+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759122
05-26 21:45:22.071+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.111+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.111+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.111+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759159
05-26 21:45:22.111+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.146+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.146+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.146+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759195
05-26 21:45:22.146+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.176+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.176+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.176+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759226
05-26 21:45:22.176+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.201+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.201+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759252
05-26 21:45:22.201+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.201+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.226+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.226+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.226+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759274
05-26 21:45:22.226+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.251+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.251+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.251+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759298
05-26 21:45:22.251+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.276+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.276+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759324
05-26 21:45:22.276+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.276+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.301+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.301+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.301+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759352
05-26 21:45:22.301+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.326+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.326+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759376
05-26 21:45:22.326+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.326+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.346+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.346+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.346+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759397
05-26 21:45:22.346+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.371+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.371+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.371+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759419
05-26 21:45:22.371+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.391+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.391+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.391+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759441
05-26 21:45:22.391+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.421+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.421+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.421+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759470
05-26 21:45:22.421+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.441+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.441+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.441+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759492
05-26 21:45:22.441+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.471+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.471+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.471+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759520
05-26 21:45:22.471+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.511+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.511+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.511+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759562
05-26 21:45:22.511+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.546+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.546+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759595
05-26 21:45:22.546+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.546+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.586+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.591+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:22.591+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 759638
05-26 21:45:22.591+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:22.916+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=759964 button=1 downs=1
05-26 21:45:22.966+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=760017 button=1 downs=0
05-26 21:45:23.476+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.476+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.476+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760527
05-26 21:45:23.476+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.511+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.511+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760559
05-26 21:45:23.511+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.511+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.541+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.541+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.541+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760590
05-26 21:45:23.541+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.576+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.576+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.576+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760626
05-26 21:45:23.576+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.616+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.616+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.616+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760668
05-26 21:45:23.616+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.661+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.661+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.661+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760708
05-26 21:45:23.661+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.686+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.691+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.691+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760738
05-26 21:45:23.691+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.721+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.721+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.721+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760771
05-26 21:45:23.721+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.756+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.756+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.756+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760806
05-26 21:45:23.756+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.786+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.786+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.786+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760837
05-26 21:45:23.786+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.826+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.826+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.826+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760874
05-26 21:45:23.826+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.866+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.866+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.866+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760917
05-26 21:45:23.866+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.906+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.906+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.906+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760956
05-26 21:45:23.906+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.941+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.941+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.941+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 760989
05-26 21:45:23.941+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:23.976+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.981+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:23.981+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x452903f0, elm_layout, time_stamp : 761028
05-26 21:45:23.981+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:25.046+0900 I/efl-extension( 4614): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x452903f0
05-26 21:45:25.046+0900 I/efl-extension( 4614): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x452903f0, obj: 0x452903f0
05-26 21:45:25.046+0900 I/efl-extension( 4614): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:45:25.046+0900 I/efl-extension( 4614): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:45:25.046+0900 I/efl-extension( 4614): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:45:25.046+0900 I/efl-extension( 4614): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:45:25.211+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=762262 button=1 downs=1
05-26 21:45:25.281+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=762332 button=1 downs=0
05-26 21:45:25.286+0900 D/TIMER   ( 4614): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:45:25.286+0900 D/TIMER   ( 4614): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:45:25.296+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:45:25.296+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44903bd8, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:45:25.791+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=762840 button=1 downs=1
05-26 21:45:25.856+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=762905 button=1 downs=0
05-26 21:45:26.336+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.336+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.336+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763387
05-26 21:45:26.336+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.376+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.376+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763425
05-26 21:45:26.376+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.376+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.401+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.401+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.401+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763449
05-26 21:45:26.401+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.441+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.441+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.441+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763493
05-26 21:45:26.441+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.491+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.491+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.491+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763540
05-26 21:45:26.491+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.531+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.531+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.531+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763580
05-26 21:45:26.531+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.566+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.571+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.571+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763618
05-26 21:45:26.571+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.626+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.626+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.626+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763674
05-26 21:45:26.626+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.666+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.666+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.666+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763717
05-26 21:45:26.666+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.701+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.701+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.701+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763750
05-26 21:45:26.701+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.726+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.726+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.726+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763777
05-26 21:45:26.726+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.761+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.761+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.761+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763809
05-26 21:45:26.761+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:26.791+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.796+0900 I/efl-extension( 4614): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:26.796+0900 I/efl-extension( 4614): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bd8, elm_layout, time_stamp : 763843
05-26 21:45:26.796+0900 E/TIMER   ( 4614): (ad->timer) -> _rotary_cb() return
05-26 21:45:27.066+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=764113 button=1 downs=1
05-26 21:45:27.116+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=764164 button=1 downs=0
05-26 21:45:28.331+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=765377 button=1 downs=1
05-26 21:45:28.366+0900 E/EFL     ( 4614): evas_main<4614> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=765413 button=1 downs=0
05-26 21:45:28.366+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:45:28.366+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44903bd8, elm_layout, func : 0x415608e1
05-26 21:45:28.366+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:45:28.366+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:45:28.366+0900 I/efl-extension( 4614): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:45:28.366+0900 I/efl-extension( 4614): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:45:28.366+0900 I/efl-extension( 4614): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:45:28.366+0900 I/efl-extension( 4614): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:45:28.366+0900 E/EFL     ( 4614): ecore<4614> ecore.c:574 _ecore_magic_fail() 
05-26 21:45:28.366+0900 E/EFL     ( 4614): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:45:28.366+0900 E/EFL     ( 4614): *** IN FUNCTION: ecore_timer_del()
05-26 21:45:28.366+0900 E/EFL     ( 4614): ecore<4614> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:45:28.366+0900 E/EFL     ( 4614):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:45:28.366+0900 E/EFL     ( 4614):     Supplied: 0049a1bd - <UNKNOWN>
05-26 21:45:28.366+0900 E/EFL     ( 4614): ecore<4614> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:45:28.366+0900 E/EFL     ( 4614): *** SPANK SPANK SPANK!!!
05-26 21:45:28.366+0900 E/EFL     ( 4614): *** Now go fix your code. Tut tut tut!
05-26 21:45:28.366+0900 I/SOCKETTEST( 4614): Success to create socket
05-26 21:45:28.366+0900 I/SOCKETTEST( 4614): socket connect error: Network is unreachable
05-26 21:45:28.366+0900 I/SOCKETTEST( 4614): write() error: Bad file descriptor
05-26 21:45:28.511+0900 W/CRASH_MANAGER( 4588): worker.c: worker_job(1199) > 1104614706831146426672
