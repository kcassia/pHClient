S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 4446
Date: 2016-05-26 21:45:06+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4446, uid 5000)

Register Information
r0   = 0x702f6374, r1   = 0x00000025
r2   = 0xbe9fd1fc, r3   = 0x0000feff
r4   = 0x702f6370, r5   = 0x702f6374
r6   = 0xbe9fccc8, r7   = 0x25252525
r8   = 0x00000000, r9   = 0x4142dec0
r10  = 0x702f6374, fp   = 0xbe9fccbc
ip   = 0x702f6374, sp   = 0xbe9fc748
lr   = 0x404b1f5c, pc   = 0x404ec6dc
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     19384 KB
Buffers:     20584 KB
Cached:     171128 KB
VmPeak:      95480 KB
VmSize:      93444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22536 KB
VmRSS:       22536 KB
VmData:      34108 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25096 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4446 TID = 4446
4446 4506 

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
448a7000 448a8000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
448d4000 448d5000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
448f2000 448f3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44afe000 44b00000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
44c94000 45493000 rwxp [stack:4506]
4579e000 457a5000 r-xp /usr/lib/libfeedback.so.0.1.4
457ae000 457b8000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
457c0000 457c7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
457cf000 457e5000 r-xp /usr/lib/libmmfsound.so.0.1.0
457f7000 457fc000 r-xp /usr/lib/libmmfsession.so.0.0.0
45804000 4580e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4581a000 4581e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45827000 4583d000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45846000 4584b000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
45853000 45856000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4585e000 458bf000 r-xp /usr/lib/libasound.so.2.0.0
458c9000 45901000 r-xp /usr/lib/libpulse.so.0.16.2
45902000 45905000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4590d000 4591a000 r-xp /usr/lib/libail.so.0.1.0
45923000 45933000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
45954000 4595c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
4596b000 4596e000 r-xp /usr/lib/libcompress.so.0.2.0
45976000 4597b000 r-xp /usr/lib/libjson.so.0.0.1
45983000 459cb000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
459cc000 45a0f000 r-xp /usr/lib/libsndfile.so.1.0.25
45a1c000 45a3e000 r-xp /usr/lib/libvorbis.so.0.4.3
45a46000 45a4a000 r-xp /usr/lib/libogg.so.0.7.1
be9dd000 be9fe000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4446)
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
tate : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:44:39.156+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:44:39.156+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 21:44:39.156+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:44:39.156+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 21:44:39.156+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:44:39.156+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:44:39.156+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:44:39.156+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 21:44:39.156+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:44:39.156+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:44:39.161+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 34, 218.
05-26 21:44:39.161+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 21:44:39.161+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:44:39.161+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:44:39.176+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:44:39.176+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:44:39.176+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:44:39.176+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 21:44:39.176+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:44:39.176+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:44:39.176+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:44:39.176+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:44:39.181+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:44:39.181+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:44:39.181+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:44:39.181+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:44:39.181+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:44:39.181+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:44:39.181+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:44:39.181+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:44:39.181+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:44:39.181+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:44:39.181+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 21:44:39.181+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 21:44:39.181+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:44:39.181+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:44:39.206+0900 I/APP_CORE( 4446): appcore-efl.c: __do_app(429) > [APP 4446] Event: RESUME State: RUNNING
05-26 21:44:39.256+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 21:44:39.256+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:44:39.271+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 21:44:39.351+0900 W/AUL_AMD (  496): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-26 21:44:39.366+0900 W/AUL_AMD (  496): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-26 21:44:39.551+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:44:39.556+0900 E/EFL     ( 4446): evas_main<4446> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=716606 button=1 downs=1
05-26 21:44:39.651+0900 E/EFL     ( 4446): evas_main<4446> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=716671 button=1 downs=0
05-26 21:44:39.681+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:44:39.866+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:44:39.876+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4446
05-26 21:44:39.881+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:44:40.131+0900 I/AUL_PAD ( 4507): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 21:44:40.326+0900 E/EFL     ( 4446): evas_main<4446> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=717376 button=1 downs=1
05-26 21:44:40.426+0900 E/EFL     ( 4446): evas_main<4446> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=717467 button=1 downs=0
05-26 21:44:40.676+0900 I/CAPI_NETWORK_CONNECTION( 4446): connection.c: connection_create(372) > New handle created[0x44c04720]
05-26 21:44:40.696+0900 I/SOCKETTEST( 4446): IP : 
05-26 21:44:40.696+0900 I/SOCKETTEST( 4446): Success to create UDP socket
05-26 21:44:40.696+0900 I/SOCKETTEST( 4446): Bind Success
05-26 21:44:40.696+0900 I/SOCKETTEST( 4446): Waiting DATA...
05-26 21:44:42.601+0900 W/SCSD    ( 1200): <_data_cb:507>  - length: 607
05-26 21:44:42.601+0900 W/SCSD    ( 1200): <sap_socket_send:137> sent [607 / 607] bytes
05-26 21:44:42.711+0900 E/wnoti-service(  855): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(596)
05-26 21:44:42.711+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
05-26 21:44:42.721+0900 E/wnoti-service(  855): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-26 21:44:42.731+0900 E/wnoti-service(  855): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 21:44:42.736+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/150
05-26 21:44:42.741+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
05-26 21:44:42.751+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 142
05-26 21:44:42.751+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 21:44:42.756+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/150
05-26 21:44:42.761+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_100.png
05-26 21:44:42.776+0900 E/wnoti-service(  855): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 1002/0
05-26 21:44:42.776+0900 E/wnoti-service(  855): wnoti-sap-client.c: _add_exception_handling(581) > type : 1002, application_id : 218
05-26 21:44:42.786+0900 E/wnoti-service(  855): wnoti-sap-client.c: publish_received_noti(1848) > 1002, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229636, noti_flag : 528, g_span_version : 1
05-26 21:44:42.786+0900 E/wnoti-service(  855): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-26 21:44:42.786+0900 E/wnoti-service(  855): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 1
05-26 21:44:42.786+0900 E/wnoti-service(  855): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 1
05-26 21:44:42.916+0900 W/SCSD    ( 1200): <_data_cb:507>  - length: 1962
05-26 21:44:42.916+0900 W/SCSD    ( 1200): <sap_socket_send:137> sent [1962 / 1962] bytes
05-26 21:44:43.006+0900 E/wnoti-service(  855): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(1951)
05-26 21:44:43.006+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
05-26 21:44:43.011+0900 E/wnoti-service(  855): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 1
05-26 21:44:43.031+0900 E/wnoti-service(  855): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 21:44:43.046+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/146
05-26 21:44:43.046+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 2
05-26 21:44:43.056+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 1440
05-26 21:44:43.061+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 21:44:43.066+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/146
05-26 21:44:43.071+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_98.png
05-26 21:44:43.076+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/145
05-26 21:44:43.096+0900 E/wnoti-service(  855): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 5/0
05-26 21:44:43.101+0900 E/wnoti-service(  855): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 218
05-26 21:44:43.106+0900 E/wnoti-service(  855): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
05-26 21:44:43.106+0900 E/wnoti-service(  855): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 0, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229637, noti_flag : 16, g_span_version : 1
05-26 21:44:43.111+0900 E/wnoti-service(  855): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 1
05-26 21:44:43.171+0900 E/wnoti-service(  855): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 1
05-26 21:44:43.921+0900 I/SOCKETTEST( 4446): Receive Data : 192.168.0.47
05-26 21:44:43.921+0900 I/SOCKETTEST( 4446): Changed IP : 192.168.0.47
05-26 21:44:43.986+0900 I/SOCKETTEST( 4446): Success to create socket
05-26 21:44:43.996+0900 I/SOCKETTEST( 4446): Success to socket connection
05-26 21:44:43.996+0900 I/SOCKETTEST( 4446): write() 성공
05-26 21:44:44.191+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:44:44.271+0900 W/SCSD    ( 1200): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x05)
05-26 21:44:44.271+0900 W/SCSD    ( 1200): <on_sap_socket_recv:30>  - remain length: 5, crc_size: 4
05-26 21:44:44.271+0900 W/SCSD    ( 1200): <on_sap_socket_recv:62>  - recv 9 bytes [9 / 9] 
05-26 21:44:44.281+0900 W/SCSD    ( 1200): <util_scs_send:975> sent [11 / 11] bytes. 
05-26 21:44:44.291+0900 E/wnoti-service(  855): wnoti-sap-client.c: _get_latest_notification_card(1700) > id : 743, status : 0
05-26 21:44:44.326+0900 I/wnoti-service(  855): wnoti-sap-client.c: launch_alert_view(398) > timer_id : 0, emergency_cb_mode : 0, blocking_mode : 0 
05-26 21:44:44.326+0900 E/wnoti-service(  855): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 1
05-26 21:44:44.326+0900 I/wnoti-service(  855): wnoti-msg-builder.c: _publish_notification(1394) > operation_type : 0, source : 0, application_id : 0, display_count : 0
05-26 21:44:44.346+0900 E/wnoti-proxy(  737): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 737, caller_id : 0, listener_type : 0
05-26 21:44:44.346+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1501) > Change type : 0, op_type: 0, category_id: 0, display count: 0
05-26 21:44:44.346+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1556) > Handle this change type in idler.
05-26 21:44:44.346+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1561) > Home is background. Postpone the board update.
05-26 21:44:44.351+0900 E/wnoti-proxy( 3950): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 3950, caller_id : 0, listener_type : 0
05-26 21:44:44.351+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1502) > Handle this change type in idler.
05-26 21:44:44.356+0900 E/wnoti-service(  855): wnoti-sap-client.c: on_timer(291) > is_exist_alert_list : 0, g_launch_popup_time : 1464266684, g_use_aul_launch : 0
05-26 21:44:44.356+0900 E/wnoti-service(  855): wnoti-sap-client.c: on_timer(293) > >> launching notification popup
05-26 21:44:44.361+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 21:44:44.381+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-26 21:44:44.401+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-26 21:44:44.401+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-26 21:44:44.401+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 855
05-26 21:44:44.416+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 3950
05-26 21:44:44.416+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: RESET State: PAUSED
05-26 21:44:44.416+0900 I/CAPI_APPFW_APPLICATION( 3950): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 21:44:44.426+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(3950), cmd(0)
05-26 21:44:44.461+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-26 21:44:44.466+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:44:44.476+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 21:44:44.476+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: wnotiboard_popup_get_block_mode(2354) > Returning false.
05-26 21:44:44.481+0900 E/wnoti-service(  855): wnoti-db-client.c: wnoti_get_alert_categories(712) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 218, db_id : 743, is_duplicated : 0
05-26 21:44:44.486+0900 E/wnoti-service(  855): wnoti-db-client.c: wnoti_get_alert_categories(851) > view_type : 1, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 0
05-26 21:44:44.511+0900 I/wnoti-proxy( 3950): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-26 21:44:44.511+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(813) > application_name: 카카오톡, application_id: 218, category_id: 34, time: 1464266682, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_218.jpg, icon_color: -5730296
05-26 21:44:44.511+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(820) > noti_type: 1
05-26 21:44:44.511+0900 W/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(77) > db_id = 743, alert_type: 1, app_feedback_type: 0
05-26 21:44:44.511+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(372) > Activity fetch finished: -1
05-26 21:44:44.511+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(377) > activity action count: 1
05-26 21:44:44.511+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(382) > 1 activities retrieved.
05-26 21:44:44.516+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(473) > Page fetch finished: -1
05-26 21:44:44.516+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(478) > wearable_page_cnt: 1
05-26 21:44:44.516+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(483) > 1 pages retrieved.
05-26 21:44:44.516+0900 W/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 1, list count : 1
05-26 21:44:44.516+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_control(1131) > ::DATA:: CHECK IN APP CONTROL : 1, 0, 1
05-26 21:44:44.516+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_control(1143) > ::APP:: CHECK STATE : 8, 0, (null)
05-26 21:44:44.516+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:44:44.516+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:44:44.516+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(628) > [743, 1, 1, 2, 0000]
05-26 21:44:44.516+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(629) > [0, 1, 0, 0]
05-26 21:44:44.516+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(630) > [1, 0, 0, 0]
05-26 21:44:44.516+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-26 21:44:44.516+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4443) > wnotiboard_popup_vi_type: 2
05-26 21:44:44.516+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4449) > (743, 743)
05-26 21:44:44.556+0900 I/efl-extension( 3950): efl_extension_circle_surface.c: eext_circle_surface_layout_add(1293) > Put the surface[0x451ad390]'s widget[0x45b4f6d0] to layout widget[0x45b4ffd0]
05-26 21:44:44.566+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_create_genlist(4377) > (743, 743)
05-26 21:44:44.571+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:44:44.591+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_create_card_data(3979) > 0x451051b8, 0x45105038, 0x45105038
05-26 21:44:44.591+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 21:44:44.591+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:44:44.591+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 21:44:44.591+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 21:44:44.606+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: wnotiboard_popup_draw_small_view(3659) > ::UI:: window type is changed by unknown causes
05-26 21:44:44.606+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05600008)
05-26 21:44:44.606+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-26 21:44:44.646+0900 W/wnotibp ( 3950): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2201) > Unhandled part: stack.separator
05-26 21:44:44.646+0900 I/wnotibp ( 3950): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:44:44.646+0900 E/E17     (  381): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x05600008)
05-26 21:44:44.651+0900 I/wnotibp ( 3950): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:44:44.656+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 21:44:44.656+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:44:44.656+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 21:44:44.656+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 21:44:44.691+0900 W/APP_CORE( 3950): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5600008
05-26 21:44:44.706+0900 E/EFL     ( 3950): evas_main<3950> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 21:44:44.706+0900 E/EFL     ( 3950): evas_main<3950> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 21:44:44.706+0900 E/EFL     ( 3950): evas_main<3950> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 21:44:44.706+0900 I/wnotibp ( 3950): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:44:44.706+0900 I/wnotibp ( 3950): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:44:44.706+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 21:44:44.706+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:44:44.706+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 21:44:44.706+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 21:44:44.751+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3713) > ::UI:: VI TYPE : 2
05-26 21:44:44.751+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3719) > alert_type : 1, is_source_companion: 1
05-26 21:44:44.751+0900 W/TIZEN_N_RECORDER( 3950): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
05-26 21:44:44.751+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1272) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
05-26 21:44:44.756+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1281) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
05-26 21:44:44.756+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1315) > ::APP:: Determined feedback: sound 0, vibration: 0
05-26 21:44:44.756+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1319) > No feedback.
05-26 21:44:44.766+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:44:44.766+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:44:44.796+0900 I/wnotibp ( 3950): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1037) > fully_obscured: 0 [0x5600008 0x560000a 0x5600008 ]
05-26 21:44:44.796+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: RESUME State: RUNNING
05-26 21:44:44.796+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_lock(856) > ::UI:: [[[ ===> already [small popup] is LOCK, 0010 ]]]
05-26 21:44:44.796+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_pre_cb(2194) > ::UI:: start showing animation
05-26 21:44:45.116+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_cb(2104) > ::UI:: end show animation
05-26 21:44:45.116+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-26 21:44:45.116+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-26 21:44:45.136+0900 E/wnoti-service(  855): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
05-26 21:44:45.146+0900 E/wnoti-service(  855): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 2
05-26 21:44:45.156+0900 E/wnoti-service(  855): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-26 21:44:45.181+0900 E/wnoti-proxy( 3950): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
05-26 21:44:45.181+0900 E/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(916) > ::DATA:: No categories available.
05-26 21:44:45.181+0900 W/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 0, list count : 1
05-26 21:44:46.326+0900 E/wnoti-service(  855): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
05-26 21:44:47.601+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-26 21:44:47.601+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_main_popup_timer_cb(2324) > ::UI:: start hiding animation
05-26 21:44:47.916+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_hide_animator_cb(2255) > ::UI:: end hiding animation
05-26 21:44:47.916+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-26 21:44:47.916+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-26 21:44:47.916+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (8, 1, 0)
05-26 21:44:47.916+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=0, view_state=0
05-26 21:44:47.916+0900 I/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(903) > ::UI:: it is invalid object.
05-26 21:44:47.916+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [invalid object] is UNLOCK , 0000 <=== ]]]
05-26 21:44:47.916+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-26 21:44:47.916+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 743
05-26 21:44:47.916+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 0, 0
05-26 21:44:47.931+0900 I/efl-extension( 3950): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45b4e350, obj: 0x45b4e350
05-26 21:44:47.931+0900 I/efl-extension( 3950): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:44:47.931+0900 I/efl-extension( 3950): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:44:47.931+0900 I/efl-extension( 3950): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:44:47.931+0900 I/efl-extension( 3950): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:44:47.956+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:44:47.956+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45b4e350, elm_genlist, func : 0x41a25dfd
05-26 21:44:47.956+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:44:47.961+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:44:47.961+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(998) > ::UI:: lock state = 0000
05-26 21:44:47.966+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(2024) > ::INFO:: call lower
05-26 21:44:48.001+0900 W/APP_CORE( 3950): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:5600008
05-26 21:44:48.001+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: PAUSE State: RUNNING
05-26 21:44:48.001+0900 I/CAPI_APPFW_APPLICATION( 3950): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 21:44:48.051+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-26 21:44:48.056+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:44:48.056+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [0, 0, 2, 0000]
05-26 21:44:48.056+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 0]
05-26 21:44:48.056+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1371) > [0, 1, 0, 2, 0]
05-26 21:44:48.331+0900 E/wnoti-service(  855): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
05-26 21:44:53.066+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: MEM_FLUSH State: PAUSED
05-26 21:44:59.706+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 21:44:59.706+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 21:44:59.711+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : pedometer_inactive_period error
05-26 21:44:59.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:44:59.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:44:59.721+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_10min_precaution_millisec error
05-26 21:44:59.721+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:44:59.721+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:44:59.726+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_before_10min_precaution_millisec error
05-26 21:45:00.336+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:45:03.346+0900 E/EFL     ( 4446): evas_main<4446> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=740393 button=1 downs=1
05-26 21:45:03.411+0900 E/EFL     ( 4446): evas_main<4446> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=740461 button=1 downs=0
05-26 21:45:03.431+0900 D/TIMER   ( 4446): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:45:03.431+0900 D/TIMER   ( 4446): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:45:03.491+0900 I/efl-extension( 4446): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:45:03.491+0900 I/efl-extension( 4446): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:45:03.491+0900 I/efl-extension( 4446): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:45:03.496+0900 I/efl-extension( 4446): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:45:03.496+0900 I/efl-extension( 4446): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4191a4e8, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:45:04.411+0900 E/EFL     ( 4446): evas_main<4446> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=741458 button=1 downs=1
05-26 21:45:04.491+0900 E/EFL     ( 4446): evas_main<4446> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=741539 button=1 downs=0
05-26 21:45:04.946+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:45:04.946+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:45:05.056+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.056+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.056+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742104
05-26 21:45:05.056+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.101+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.101+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.101+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742149
05-26 21:45:05.101+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.161+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.161+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.161+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742210
05-26 21:45:05.161+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.221+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.221+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.221+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742269
05-26 21:45:05.221+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.271+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.271+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.271+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742319
05-26 21:45:05.271+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.321+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.326+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.326+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742373
05-26 21:45:05.326+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.411+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.411+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.411+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742461
05-26 21:45:05.411+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.576+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.576+0900 E/GESTURE (  143): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=30   flick_area=55 ---> SET value to 1
05-26 21:45:05.576+0900 E/GESTURE (  143): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
05-26 21:45:05.576+0900 E/GESTURE (  143): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=30   flick_area=55 ---> SET value to 1
05-26 21:45:05.576+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.576+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742622
05-26 21:45:05.576+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.626+0900 E/GESTURE (  143): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
05-26 21:45:05.651+0900 I/GESTURE (  143): gesture.c: GestureHandleMTSyncEvent(3251) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
05-26 21:45:05.651+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.651+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742700
05-26 21:45:05.651+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.651+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.696+0900 I/GESTURE (  143): gesture.c: GestureHandleMTSyncEvent(3251) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
05-26 21:45:05.696+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.696+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.696+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742745
05-26 21:45:05.696+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.721+0900 I/GESTURE (  143): gesture.c: GestureHandleMTSyncEvent(3251) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
05-26 21:45:05.721+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.726+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.726+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742773
05-26 21:45:05.726+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.751+0900 I/GESTURE (  143): gesture.c: GestureHandleMTSyncEvent(3251) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
05-26 21:45:05.756+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.756+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.756+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742804
05-26 21:45:05.756+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.796+0900 I/GESTURE (  143): gesture.c: GestureHandleMTSyncEvent(3251) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
05-26 21:45:05.796+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.796+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.796+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742844
05-26 21:45:05.796+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.846+0900 I/GESTURE (  143): gesture.c: GestureHandleMTSyncEvent(3251) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
05-26 21:45:05.846+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.846+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.846+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742895
05-26 21:45:05.846+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.896+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.901+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.901+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742948
05-26 21:45:05.901+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.946+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.946+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.946+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 742996
05-26 21:45:05.946+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:05.996+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.996+0900 I/efl-extension( 4446): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:45:05.996+0900 I/efl-extension( 4446): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a4e8, elm_layout, time_stamp : 743046
05-26 21:45:05.996+0900 E/TIMER   ( 4446): (ad->timer) -> _rotary_cb() return
05-26 21:45:06.771+0900 E/EFL     ( 4446): evas_main<4446> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=743822 button=1 downs=1
05-26 21:45:06.841+0900 E/EFL     ( 4446): evas_main<4446> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=743888 button=1 downs=0
05-26 21:45:06.841+0900 I/efl-extension( 4446): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:45:06.841+0900 I/efl-extension( 4446): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4191a4e8, elm_layout, func : 0x415608e1
05-26 21:45:06.841+0900 I/efl-extension( 4446): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:45:06.841+0900 I/efl-extension( 4446): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:45:06.841+0900 I/efl-extension( 4446): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:45:06.841+0900 I/efl-extension( 4446): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:45:06.841+0900 I/efl-extension( 4446): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:45:06.841+0900 I/efl-extension( 4446): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:45:06.841+0900 E/EFL     ( 4446): ecore<4446> ecore.c:574 _ecore_magic_fail() 
05-26 21:45:06.841+0900 E/EFL     ( 4446): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:45:06.841+0900 E/EFL     ( 4446): *** IN FUNCTION: ecore_timer_del()
05-26 21:45:06.841+0900 E/EFL     ( 4446): ecore<4446> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:45:06.841+0900 E/EFL     ( 4446):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:45:06.841+0900 E/EFL     ( 4446):     Supplied: 0049a1bd - <UNKNOWN>
05-26 21:45:06.841+0900 E/EFL     ( 4446): ecore<4446> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:45:06.841+0900 E/EFL     ( 4446): *** SPANK SPANK SPANK!!!
05-26 21:45:06.841+0900 E/EFL     ( 4446): *** Now go fix your code. Tut tut tut!
05-26 21:45:06.841+0900 I/SOCKETTEST( 4446): Success to create socket
05-26 21:45:06.846+0900 I/SOCKETTEST( 4446): Success to socket connection
05-26 21:45:06.851+0900 I/SOCKETTEST( 4446): write() 성공
05-26 21:45:07.201+0900 W/CRASH_MANAGER( 4588): worker.c: worker_job(1199) > 1104446706831146426670
