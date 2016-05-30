S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 15633
Date: 2016-05-26 22:51:13+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x4186ef10, r5   = 0x41561c21
r6   = 0x4186f810, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x4186e190
r10  = 0x41885808, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbee31630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     19048 KB
Buffers:     37824 KB
Cached:     146208 KB
VmPeak:     100700 KB
VmSize:      94512 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26584 KB
VmRSS:       24428 KB
VmData:      40160 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23928 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 15633 TID = 15633
15633 15698 15763 

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
43882000 44081000 rwxp [stack:15763]
44b86000 44b89000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44c94000 45493000 rwxp [stack:15698]
4559e000 455d6000 r-xp /usr/lib/libpulse.so.0.16.2
459c5000 459ca000 r-xp /usr/lib/libjson.so.0.0.1
459d2000 45a1a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a1b000 45a5e000 r-xp /usr/lib/libsndfile.so.1.0.25
45a6b000 45a8d000 r-xp /usr/lib/libvorbis.so.0.4.3
45a95000 45a99000 r-xp /usr/lib/libogg.so.0.7.1
bee11000 bee32000 rwxp [stack]
End of Maps Information

Callstack Information (PID:15633)
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
c-control-service-message-port]
05-26 22:49:29.676+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:49:29.681+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:49:29.681+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:49:29.681+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:49:29.681+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:49:29.681+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:49:29.681+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:49:29.681+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:49:29.681+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:49:29.681+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:49:29.681+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:49:29.681+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 22:49:29.681+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 22:49:29.681+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 22:49:29.681+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:49:29.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:49:29.711+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05c00002)
05-26 22:49:29.711+0900 I/APP_CORE(15633): appcore-efl.c: __do_app(429) > [APP 15633] Event: RESET State: CREATED
05-26 22:49:29.711+0900 I/CAPI_APPFW_APPLICATION(15633): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 22:49:29.736+0900 I/APP_CORE(15633): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 22:49:29.736+0900 I/APP_CORE(15633): appcore-efl.c: __do_app(474) > [APP 15633] Initial Launching, call the resume_cb
05-26 22:49:29.736+0900 I/CAPI_APPFW_APPLICATION(15633): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 22:49:29.776+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 22:49:29.781+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 22:49:29.781+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:49:29.781+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:49:29.781+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:49:29.781+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 22:49:29.786+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:49:29.786+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:49:29.811+0900 W/APP_CORE(15633): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
05-26 22:49:29.851+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 22:49:29.851+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 22:49:29.851+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:49:29.851+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 22:49:29.856+0900 I/APP_CORE(15633): appcore-efl.c: __do_app(429) > [APP 15633] Event: RESUME State: RUNNING
05-26 22:49:29.856+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 22:49:29.856+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:49:29.856+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 22:49:29.856+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 22:49:29.856+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:49:29.856+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:49:29.856+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:49:29.856+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 22:49:29.856+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:49:29.856+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 22:49:29.856+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:49:29.856+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:49:29.856+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:49:29.856+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 22:49:29.856+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:49:29.856+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:49:29.856+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:49:29.886+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:49:29.886+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:49:29.886+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:49:29.886+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:49:29.886+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 22:49:29.971+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 22:49:29.971+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:49:29.981+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 22:49:30.186+0900 W/AUL_AMD (  496): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-26 22:49:30.211+0900 W/AUL_AMD (  496): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-26 22:49:30.251+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:49:30.386+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:49:30.721+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:49:30.741+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15633
05-26 22:49:30.746+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:49:31.091+0900 I/AUL_PAD (15701): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 22:49:32.526+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4609572 button=1 downs=1
05-26 22:49:32.601+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4609652 button=1 downs=0
05-26 22:49:33.856+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4610907 button=1 downs=1
05-26 22:49:33.926+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4610979 button=1 downs=0
05-26 22:49:34.231+0900 I/CAPI_NETWORK_CONNECTION(15633): connection.c: connection_create(372) > New handle created[0x4571b2d0]
05-26 22:49:34.251+0900 I/SOCKETTEST(15633): IP : 
05-26 22:49:34.251+0900 I/SOCKETTEST(15633): Success to create UDP socket
05-26 22:49:34.251+0900 I/SOCKETTEST(15633): Bind Success
05-26 22:49:34.251+0900 I/SOCKETTEST(15633): Waiting DATA...
05-26 22:49:34.891+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:49:35.856+0900 I/SOCKETTEST(15633): Receive Data : 192.168.0.47
05-26 22:49:35.856+0900 I/SOCKETTEST(15633): Changed IP : 192.168.0.47
05-26 22:49:35.921+0900 I/SOCKETTEST(15633): Success to create socket
05-26 22:49:35.926+0900 I/SOCKETTEST(15633): Success to socket connection
05-26 22:49:35.931+0900 I/SOCKETTEST(15633): write() 성공
05-26 22:49:38.656+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4615707 button=1 downs=1
05-26 22:49:38.741+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4615789 button=1 downs=0
05-26 22:49:38.756+0900 D/TIMER   (15633): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:49:38.756+0900 D/TIMER   (15633): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:49:38.811+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:49:38.811+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:49:38.811+0900 I/efl-extension(15633): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:49:38.816+0900 I/efl-extension(15633): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:49:38.816+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x418973a8, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:49:39.571+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4616622 button=1 downs=1
05-26 22:49:39.621+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4616671 button=1 downs=0
05-26 22:49:40.251+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4617298 button=1 downs=1
05-26 22:49:40.301+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4617352 button=1 downs=0
05-26 22:49:40.756+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4617803 button=1 downs=1
05-26 22:49:40.796+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4617846 button=1 downs=0
05-26 22:49:41.346+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4618390 button=1 downs=1
05-26 22:49:41.431+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4618481 button=1 downs=0
05-26 22:49:41.971+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4619019 button=1 downs=1
05-26 22:49:42.026+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4619074 button=1 downs=0
05-26 22:49:42.831+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:42.831+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:42.836+0900 I/efl-extension(15633): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:42.836+0900 I/efl-extension(15633): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418973a8, elm_layout, time_stamp : 4619882
05-26 22:49:42.836+0900 E/TIMER   (15633): (ad->timer) -> _rotary_cb() return
05-26 22:49:42.896+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:42.896+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:42.896+0900 I/efl-extension(15633): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:42.896+0900 I/efl-extension(15633): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418973a8, elm_layout, time_stamp : 4619945
05-26 22:49:42.896+0900 E/TIMER   (15633): (ad->timer) -> _rotary_cb() return
05-26 22:49:42.951+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:42.951+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:42.951+0900 I/efl-extension(15633): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:42.951+0900 I/efl-extension(15633): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418973a8, elm_layout, time_stamp : 4620001
05-26 22:49:42.951+0900 E/TIMER   (15633): (ad->timer) -> _rotary_cb() return
05-26 22:49:43.011+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:43.011+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:43.016+0900 I/efl-extension(15633): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:43.016+0900 I/efl-extension(15633): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418973a8, elm_layout, time_stamp : 4620063
05-26 22:49:43.016+0900 E/TIMER   (15633): (ad->timer) -> _rotary_cb() return
05-26 22:49:43.456+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4620508 button=1 downs=1
05-26 22:49:43.471+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4620519 button=1 downs=0
05-26 22:49:43.471+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:49:43.471+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x418973a8, elm_layout, func : 0x41560781
05-26 22:49:43.471+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:49:43.471+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:49:43.471+0900 I/efl-extension(15633): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:49:43.471+0900 I/efl-extension(15633): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:49:43.471+0900 I/efl-extension(15633): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:49:43.471+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:49:43.471+0900 E/EFL     (15633): ecore<15633> ecore.c:574 _ecore_magic_fail() 
05-26 22:49:43.471+0900 E/EFL     (15633): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:49:43.471+0900 E/EFL     (15633): *** IN FUNCTION: ecore_timer_del()
05-26 22:49:43.471+0900 E/EFL     (15633): ecore<15633> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:49:43.471+0900 E/EFL     (15633):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:49:43.471+0900 E/EFL     (15633):     Supplied: 0049a1bd - <UNKNOWN>
05-26 22:49:43.471+0900 E/EFL     (15633): ecore<15633> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:49:43.471+0900 E/EFL     (15633): *** SPANK SPANK SPANK!!!
05-26 22:49:43.471+0900 E/EFL     (15633): *** Now go fix your code. Tut tut tut!
05-26 22:49:43.471+0900 I/SOCKETTEST(15633): Success to create socket
05-26 22:49:43.476+0900 I/SOCKETTEST(15633): Success to socket connection
05-26 22:49:43.476+0900 I/SOCKETTEST(15633): write() 성공
05-26 22:49:43.481+0900 I/TimeRecord(15633): time : 1882153844
05-26 22:49:43.976+0900 I/efl-extension(15633): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x418973a8
05-26 22:49:43.976+0900 I/efl-extension(15633): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x418973a8, obj: 0x418973a8
05-26 22:49:43.976+0900 I/efl-extension(15633): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 22:49:46.271+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4623317 button=1 downs=1
05-26 22:49:46.356+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4623407 button=1 downs=0
05-26 22:49:46.361+0900 D/TIMER   (15633): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:49:46.361+0900 D/TIMER   (15633): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:49:46.371+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:49:46.371+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41897528, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:49:50.866+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4627913 button=1 downs=1
05-26 22:49:50.946+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4627993 button=1 downs=0
05-26 22:49:51.521+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4628567 button=1 downs=1
05-26 22:49:51.566+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4628613 button=1 downs=0
05-26 22:49:52.086+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4629132 button=1 downs=1
05-26 22:49:52.191+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4629242 button=1 downs=0
05-26 22:49:52.611+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4629658 button=1 downs=1
05-26 22:49:52.676+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4629726 button=1 downs=0
05-26 22:49:53.346+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4630395 button=1 downs=1
05-26 22:49:53.446+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4630496 button=1 downs=0
05-26 22:49:53.781+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4630830 button=1 downs=1
05-26 22:49:53.871+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4630920 button=1 downs=0
05-26 22:49:54.336+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4631383 button=1 downs=1
05-26 22:49:54.401+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4631450 button=1 downs=0
05-26 22:49:55.341+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.341+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.341+0900 I/efl-extension(15633): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.341+0900 I/efl-extension(15633): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897528, elm_layout, time_stamp : 4632389
05-26 22:49:55.386+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.386+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.391+0900 I/efl-extension(15633): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.391+0900 I/efl-extension(15633): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897528, elm_layout, time_stamp : 4632436
05-26 22:49:55.421+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.421+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.426+0900 I/efl-extension(15633): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.426+0900 I/efl-extension(15633): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897528, elm_layout, time_stamp : 4632471
05-26 22:49:55.461+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.461+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.461+0900 I/efl-extension(15633): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.461+0900 I/efl-extension(15633): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897528, elm_layout, time_stamp : 4632512
05-26 22:49:55.531+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.531+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.531+0900 I/efl-extension(15633): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:49:55.531+0900 I/efl-extension(15633): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897528, elm_layout, time_stamp : 4632580
05-26 22:49:57.196+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4634244 button=1 downs=1
05-26 22:49:57.236+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4634285 button=1 downs=0
05-26 22:49:58.136+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4635186 button=1 downs=1
05-26 22:49:58.146+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4635197 button=1 downs=0
05-26 22:49:58.146+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:49:58.146+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x41897528, elm_layout, func : 0x41560781
05-26 22:49:58.151+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:49:58.151+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:49:58.151+0900 I/efl-extension(15633): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:49:58.151+0900 I/efl-extension(15633): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:49:58.151+0900 I/efl-extension(15633): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:49:58.151+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:49:58.151+0900 D/TIMER   (15633): Setting time is 5
05-26 22:49:58.241+0900 I/SOCKETTEST(15633): Success to create socket
05-26 22:49:58.276+0900 I/SOCKETTEST(15633): Success to socket connection
05-26 22:49:58.276+0900 I/SOCKETTEST(15633): write() 성공
05-26 22:49:58.341+0900 I/SENSOR  (15633): 2.030000, -0.910000, 3.150000
05-26 22:49:58.421+0900 I/SENSOR  (15633): 4.130000, -0.770000, 5.950000
05-26 22:49:58.521+0900 I/SENSOR  (15633): 4.550000, -0.420000, 5.950000
05-26 22:49:58.681+0900 I/SENSOR  (15633): 1.120000, -1.820000, 1.750000
05-26 22:49:58.731+0900 I/SENSOR  (15633): 3.430000, -1.050000, 4.690000
05-26 22:49:58.881+0900 I/SENSOR  (15633): 3.430000, -0.700000, 4.620000
05-26 22:49:58.936+0900 I/SENSOR  (15633): 3.500000, -1.050000, 4.690000
05-26 22:49:59.021+0900 I/SENSOR  (15633): 3.710000, -0.910000, 4.200000
05-26 22:49:59.181+0900 I/SENSOR  (15633): 3.780000, -0.840000, 4.480000
05-26 22:49:59.266+0900 I/SENSOR  (15633): 3.290000, -0.840000, 3.780000
05-26 22:49:59.321+0900 I/SENSOR  (15633): 3.780000, -1.050000, 4.060000
05-26 22:49:59.421+0900 I/SENSOR  (15633): 3.430000, -1.120000, 4.130000
05-26 22:49:59.521+0900 I/SENSOR  (15633): 3.640000, -1.190000, 4.760000
05-26 22:49:59.676+0900 I/SENSOR  (15633): 3.710000, -1.190000, 4.480000
05-26 22:49:59.756+0900 I/SENSOR  (15633): 3.500000, -0.980000, 4.200000
05-26 22:49:59.856+0900 I/SENSOR  (15633): 3.430000, -0.840000, 4.270000
05-26 22:49:59.921+0900 I/SENSOR  (15633): 3.920000, -0.840000, 4.480000
05-26 22:50:00.021+0900 I/SENSOR  (15633): 3.290000, -0.910000, 4.270000
05-26 22:50:00.151+0900 I/SENSOR  (15633): 3.570000, -0.980000, 4.340000
05-26 22:50:00.306+0900 I/SENSOR  (15633): 3.710000, -0.980000, 4.340000
05-26 22:50:00.416+0900 I/SENSOR  (15633): 3.570000, -1.190000, 4.340000
05-26 22:50:00.496+0900 I/SENSOR  (15633): 3.640000, -0.840000, 4.340000
05-26 22:50:00.536+0900 I/SENSOR  (15633): 4.130000, -0.910000, 4.410000
05-26 22:50:00.641+0900 I/SENSOR  (15633): 3.780000, -0.980000, 4.270000
05-26 22:50:00.736+0900 I/SENSOR  (15633): 3.290000, -0.980000, 4.480000
05-26 22:50:00.826+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:50:00.896+0900 I/SENSOR  (15633): 3.080000, -1.120000, 4.410000
05-26 22:50:00.966+0900 I/SENSOR  (15633): 3.990000, -0.490000, 4.550000
05-26 22:50:01.021+0900 I/SENSOR  (15633): 3.920000, -0.980000, 4.690000
05-26 22:50:01.161+0900 I/SENSOR  (15633): 3.570000, -1.120000, 3.990000
05-26 22:50:01.291+0900 I/SENSOR  (15633): 3.640000, -0.980000, 4.340000
05-26 22:50:01.326+0900 I/SENSOR  (15633): 4.200000, -1.120000, 5.040000
05-26 22:50:01.421+0900 I/SENSOR  (15633): 3.430000, -0.910000, 3.920000
05-26 22:50:01.521+0900 I/SENSOR  (15633): 4.130000, -0.560000, 5.110000
05-26 22:50:01.621+0900 I/SENSOR  (15633): 3.640000, -0.630000, 3.640000
05-26 22:50:01.736+0900 I/SENSOR  (15633): 3.360000, -0.700000, 3.990000
05-26 22:50:01.836+0900 I/SENSOR  (15633): 3.710000, -0.840000, 4.690000
05-26 22:50:01.931+0900 I/SENSOR  (15633): 3.780000, -0.770000, 3.920000
05-26 22:50:02.021+0900 I/SENSOR  (15633): 3.290000, -0.770000, 3.150000
05-26 22:50:02.126+0900 I/SENSOR  (15633): 3.640000, -0.840000, 4.480000
05-26 22:50:02.231+0900 I/SENSOR  (15633): 3.850000, -0.910000, 4.480000
05-26 22:50:02.386+0900 I/SENSOR  (15633): 3.570000, -0.910000, 4.270000
05-26 22:50:02.456+0900 I/SENSOR  (15633): 3.710000, -1.400000, 4.760000
05-26 22:50:02.521+0900 I/SENSOR  (15633): 3.710000, -0.980000, 4.900000
05-26 22:50:02.621+0900 I/SENSOR  (15633): 3.920000, -0.770000, 4.480000
05-26 22:50:02.791+0900 I/SENSOR  (15633): 3.850000, -0.980000, 5.880000
05-26 22:50:02.841+0900 I/SENSOR  (15633): 4.480000, -0.490000, 5.950000
05-26 22:50:02.921+0900 I/SENSOR  (15633): 2.590000, -1.120000, 3.710000
05-26 22:50:03.026+0900 I/SENSOR  (15633): 4.270000, -0.770000, 4.550000
05-26 22:50:03.126+0900 I/SENSOR  (15633): 0.980000, -1.820000, 2.030000
05-26 22:50:03.176+0900 E/EFL     (15633): evas_main<15633> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4640214 button=1 downs=1
05-26 22:50:03.226+0900 I/SENSOR  (15633): 4.340000, -0.910000, 4.690000
05-26 22:50:03.251+0900 E/EFL     (15633): evas_main<15633> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4640299 button=1 downs=0
05-26 22:50:03.251+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:50:03.251+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x41897528, elm_layout, func : 0x41560781
05-26 22:50:03.251+0900 I/efl-extension(15633): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:50:03.266+0900 I/SOCKETTEST(15633): Success to create socket
05-26 22:50:03.351+0900 I/SOCKETTEST(15633): Success to socket connection
05-26 22:50:03.351+0900 I/SOCKETTEST(15633): write() 성공
05-26 22:50:03.361+0900 I/TimeRecord(15633): time : 4
05-26 22:50:03.861+0900 I/efl-extension(15633): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x41897528
05-26 22:50:03.861+0900 I/efl-extension(15633): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x41897528, obj: 0x41897528
05-26 22:50:03.861+0900 I/efl-extension(15633): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 22:50:04.931+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 22:50:04.931+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 22:50:27.096+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 17 -> 18 1464270627 146
05-26 22:50:27.101+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 18 91 55 124
05-26 22:50:27.111+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 18 0 0 110
05-26 22:50:27.111+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 18 0 0 0
05-26 22:50:27.111+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 18 119 5 163
05-26 22:50:27.111+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 18 0 0 0
05-26 22:51:00.896+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:51:04.961+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 22:51:04.966+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 22:51:04.966+0900 I/RESOURCED(  497): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-26 22:51:13.301+0900 E/PKGMGR_SERVER(15828): pkgmgr-server.c: main(2131) > package manager server start
05-26 22:51:13.381+0900 E/PKGMGR_SERVER(15828): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_357838377], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[KO3gV5U2qSAAO+vB9nZ2m4HQqtc=], backend_flag=[0]
05-26 22:51:13.386+0900 E/PKGMGR_SERVER(15830): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-26 22:51:13.391+0900 E/PKGMGR  (15822): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-26 22:51:13.451+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:51:13.456+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15633
05-26 22:51:13.461+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:51:13.461+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 5
05-26 22:51:13.466+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(15633), cmd(4)
05-26 22:51:13.466+0900 I/APP_CORE(15633): appcore-efl.c: __do_app(429) > [APP 15633] Event: TERMINATE State: RUNNING
05-26 22:51:13.466+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 22:51:13.466+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 22:51:13.466+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:51:13.476+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15633
05-26 22:51:13.551+0900 I/APP_CORE(15633): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 22:51:13.551+0900 I/CAPI_APPFW_APPLICATION(15633): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 22:51:13.566+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:51:13.566+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 22:51:13.576+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:51:13.586+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15633
05-26 22:51:13.651+0900 I/UXT     (15633): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 22:51:13.656+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 22:51:13.666+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 22:51:13.666+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:51:13.666+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:51:13.666+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:51:13.666+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 22:51:13.681+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(0)
05-26 22:51:13.681+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 22:51:13.681+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:51:13.681+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(0)
05-26 22:51:13.681+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESUME State: PAUSED
05-26 22:51:13.681+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 22:51:13.681+0900 W/W_HOME  (  737): main.c: _appcore_resume_cb(681) > appcore resume
05-26 22:51:13.681+0900 W/W_HOME  (  737): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 22:51:13.681+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:51:13.681+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:51:13.681+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:51:13.681+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:51:13.681+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 22:51:13.681+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:51:13.681+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:51:13.686+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:51:13.696+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 22:51:13.696+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 22:51:13.696+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:51:13.696+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:51:13.696+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 22:51:13.696+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15633
05-26 22:51:13.696+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 22:51:13.696+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:51:13.696+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 22:51:13.701+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:51:13.701+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:51:13.701+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:51:13.701+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:51:13.796+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:51:13.811+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15633
05-26 22:51:13.911+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:51:13.936+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15633
05-26 22:51:14.036+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:51:14.046+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15633
05-26 22:51:14.166+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:51:14.181+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 22:51:14.181+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 22:51:14.196+0900 E/PKGMGR_SERVER(15830): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-26 22:51:14.246+0900 E/PKGMGR_SERVER(15828): pkgmgr-server.c: sighandler(409) > child NORMAL exit [15830]
05-26 22:51:14.296+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 15633
05-26 22:51:14.336+0900 W/CRASH_MANAGER(15832): worker.c: worker_job(1199) > 1115633706831146427067
