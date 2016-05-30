S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 9308
Date: 2016-05-11 18:08:32+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000009
r2   = 0x0000000a, r3   = 0x00000000
r4   = 0x4030c9c0, r5   = 0x4059a4b8
r6   = 0x4030c16c, r7   = 0x00000000
r8   = 0x437022e4, r9   = 0x41469100
r10  = 0x4031ab18, fp   = 0x00000000
ip   = 0x4059a4b8, sp   = 0xbed0c278
lr   = 0x404a808c, pc   = 0x404a81f4
cpsr = 0x80000010

Memory Information
MemTotal:   491012 KB
MemFree:     11828 KB
Buffers:     30340 KB
Cached:     140120 KB
VmPeak:      93792 KB
VmSize:      91760 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23128 KB
VmRSS:       23128 KB
VmData:      35160 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23156 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9308 TID = 9308
9308 9909 9949 

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
43833000 4383e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43847000 4384b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43853000 4386a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43877000 43879000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43882000 44081000 rwxp [stack:9949]
44a1c000 4521b000 rwxp [stack:9909]
453dc000 453dd000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
becec000 bed0d000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9308)
Call Stack Count: 1
 0: (0x404a81f4) [/lib/libc.so.6] + 0x331f4
End of Call Stack

Package Information
Package Name: org.example.ph1
Package ID : org.example.ph1
Version: 0.8.0
Package Type: rpm
App Name: pH
App ID: org.example.ph1
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
07) > _MessagePortService::CheckRemotePort
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-11 18:08:14.790+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 18:08:14.795+0900 W/W_HOME  (  688): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-11 18:08:14.795+0900 E/W_HOME  (  688): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-11 18:08:14.795+0900 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 18:08:14.795+0900 W/W_HOME  (  688): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-11 18:08:14.795+0900 E/W_HOME  (  688): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-11 18:08:14.795+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 18:08:14.800+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 18:08:14.800+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 18:08:14.800+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 18:08:14.800+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-11 18:08:14.800+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-11 18:08:14.800+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 18:08:14.800+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-11 18:08:14.800+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-11 18:08:14.800+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-11 18:08:14.800+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 18:08:14.860+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-11 18:08:14.860+0900 E/EFL     (  688): evas_main<688> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4043021 button=1 downs=1
05-11 18:08:14.860+0900 W/APPS    (  688): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [175, 172]
05-11 18:08:14.905+0900 E/EFL     (  688): evas_main<688> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4043054 button=1 downs=0
05-11 18:08:14.905+0900 W/APPS    (  688): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [175, 172]->[176, 173]
05-11 18:08:14.905+0900 W/APPS    (  688): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-11 18:08:14.905+0900 E/APPS    (  688): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-11 18:08:14.905+0900 W/APPS    (  688): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-11 18:08:14.910+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 0
05-11 18:08:14.910+0900 W/AUL_AMD (  484): amd_launch.c: _start_app(1702) > caller pid : 688
05-11 18:08:14.910+0900 I/AUL_AMD (  484): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-11 18:08:14.925+0900 E/RESOURCED(  485): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-11 18:08:14.925+0900 E/RESOURCED(  485): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-11 18:08:14.925+0900 W/AUL_AMD (  484): amd_launch.c: _start_app(2080) > pad pid(-5)
05-11 18:08:14.925+0900 W/AUL_PAD ( 1103): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-11 18:08:14.925+0900 W/AUL_PAD ( 1103): launchpad.c: __send_result_to_caller(272) > Check app launching
05-11 18:08:14.965+0900 I/efl-extension( 9308): efl_extension.c: eext_mod_init(40) > Init
05-11 18:08:14.965+0900 I/UXT     ( 9308): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-11 18:08:14.975+0900 I/CAPI_APPFW_APPLICATION( 9308): app_main.c: ui_app_main(704) > app_efl_main
05-11 18:08:14.980+0900 I/CAPI_APPFW_APPLICATION( 9308): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-11 18:08:15.030+0900 E/AUL     (  484): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-11 18:08:15.045+0900 E/RESOURCED(  485): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-11 18:08:15.060+0900 E/TBM     ( 9308): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-11 18:08:15.150+0900 E/EFL     ( 9308): <9308> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-11 18:08:15.160+0900 E/EFL     ( 9308): <9308> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-11 18:08:15.160+0900 E/EFL     ( 9308): <9308> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-11 18:08:15.160+0900 E/EFL     ( 9308): <9308> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-11 18:08:15.160+0900 E/EFL     ( 9308): <9308> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-11 18:08:15.160+0900 E/EFL     ( 9308): <9308> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-11 18:08:15.215+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04a00002)
05-11 18:08:15.215+0900 I/APP_CORE( 9308): appcore-efl.c: __do_app(429) > [APP 9308] Event: RESET State: CREATED
05-11 18:08:15.215+0900 I/CAPI_APPFW_APPLICATION( 9308): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-11 18:08:15.250+0900 I/APP_CORE( 9308): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-11 18:08:15.250+0900 I/APP_CORE( 9308): appcore-efl.c: __do_app(474) > [APP 9308] Initial Launching, call the resume_cb
05-11 18:08:15.250+0900 I/CAPI_APPFW_APPLICATION( 9308): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-11 18:08:15.265+0900 I/MALI    (  688): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-11 18:08:15.270+0900 W/W_HOME  (  688): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-11 18:08:15.270+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:15.270+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:15.270+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:15.270+0900 W/W_HOME  (  688): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-11 18:08:15.275+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 18:08:15.275+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 18:08:15.365+0900 W/APP_CORE( 9308): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4a00002
05-11 18:08:15.415+0900 W/W_HOME  (  688): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-11 18:08:15.415+0900 W/W_HOME  (  688): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-11 18:08:15.415+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:15.415+0900 W/W_HOME  (  688): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-11 18:08:15.420+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: PAUSE State: RUNNING
05-11 18:08:15.420+0900 I/CAPI_APPFW_APPLICATION(  688): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-11 18:08:15.420+0900 W/W_HOME  (  688): main.c: _appcore_pause_cb(690) > appcore pause
05-11 18:08:15.420+0900 W/W_HOME  (  688): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-11 18:08:15.420+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:15.420+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:15.420+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:15.420+0900 W/W_HOME  (  688): rotary.c: rotary_deattach(156) > rotary_deattach:0x476bd370
05-11 18:08:15.420+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 18:08:15.420+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x476bd370, elm_layout, func : 0x4004b469
05-11 18:08:15.420+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-11 18:08:15.420+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-11 18:08:15.420+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 18:08:15.420+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x476bd370, activated : 1
05-11 18:08:15.420+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-11 18:08:15.420+0900 E/wnotib  (  688): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-11 18:08:15.420+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 115, 218.
05-11 18:08:15.420+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-11 18:08:15.455+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 18:08:15.455+0900 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-11 18:08:15.455+0900 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
05-11 18:08:15.460+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 18:08:15.460+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 18:08:15.500+0900 I/APP_CORE( 9308): appcore-efl.c: __do_app(429) > [APP 9308] Event: RESUME State: RUNNING
05-11 18:08:15.545+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-11 18:08:15.545+0900 E/wnotib  (  688): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-11 18:08:15.565+0900 W/APPS    (  688): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-11 18:08:15.810+0900 E/AUL     (  484): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-11 18:08:15.960+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: MEM_FLUSH State: PAUSED
05-11 18:08:16.085+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 14
05-11 18:08:16.095+0900 W/AUL_AMD (  484): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9308
05-11 18:08:16.100+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 12
05-11 18:08:16.270+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4044429 button=1 downs=1
05-11 18:08:16.320+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4044483 button=1 downs=0
05-11 18:08:16.335+0900 D/TIMER   ( 9308): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-11 18:08:16.335+0900 D/TIMER   ( 9308): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-11 18:08:16.370+0900 D/TIMER   ( 9308): Digital create
05-11 18:08:16.380+0900 D/TIMER   ( 9308): Initialize the rotary event
05-11 18:08:16.380+0900 I/efl-extension( 9308): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-11 18:08:16.380+0900 I/efl-extension( 9308): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-11 18:08:16.380+0900 I/efl-extension( 9308): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-11 18:08:16.380+0900 I/efl-extension( 9308): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-11 18:08:16.380+0900 I/efl-extension( 9308): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41897180, elm_layout, _activated_obj : 0x0, activated : 1
05-11 18:08:16.860+0900 I/AUL_PAD ( 9911): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-11 18:08:17.860+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4046018 button=1 downs=1
05-11 18:08:17.900+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4046061 button=1 downs=0
05-11 18:08:17.900+0900 D/TIMER   ( 9308): Start clicked
05-11 18:08:17.900+0900 E/EFL     ( 9308): ecore<9308> ecore.c:574 _ecore_magic_fail() 
05-11 18:08:17.900+0900 E/EFL     ( 9308): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-11 18:08:17.900+0900 E/EFL     ( 9308): *** IN FUNCTION: ecore_timer_del()
05-11 18:08:17.900+0900 E/EFL     ( 9308): ecore<9308> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-11 18:08:17.900+0900 E/EFL     ( 9308):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-11 18:08:17.900+0900 E/EFL     ( 9308):     Supplied: 0049a1bd - <UNKNOWN>
05-11 18:08:17.900+0900 E/EFL     ( 9308): ecore<9308> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-11 18:08:17.900+0900 E/EFL     ( 9308): *** SPANK SPANK SPANK!!!
05-11 18:08:17.900+0900 E/EFL     ( 9308): *** Now go fix your code. Tut tut tut!
05-11 18:08:17.900+0900 I/SOCKETTEST( 9308): Success to create socket
05-11 18:08:17.900+0900 I/SOCKETTEST( 9308): socket connect error: Network is unreachable
05-11 18:08:17.900+0900 I/SOCKETTEST( 9308): write() error: Bad file descriptor
05-11 18:08:18.595+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4046755 button=1 downs=1
05-11 18:08:18.640+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4046799 button=1 downs=0
05-11 18:08:18.685+0900 I/APP_CORE( 9285): appcore-efl.c: __do_app(429) > [APP 9285] Event: MEM_FLUSH State: PAUSED
05-11 18:08:19.060+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4047218 button=1 downs=1
05-11 18:08:19.145+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4047305 button=1 downs=0
05-11 18:08:19.410+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4047568 button=1 downs=1
05-11 18:08:19.410+0900 D/TIMER   ( 9308): Minute selected
05-11 18:08:19.475+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4047633 button=1 downs=0
05-11 18:08:20.005+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.005+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.005+0900 I/efl-extension( 9308): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.005+0900 I/efl-extension( 9308): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897180, elm_layout, time_stamp : 4048166
05-11 18:08:20.005+0900 D/TIMER   ( 9308): Rotary callback is called
05-11 18:08:20.005+0900 D/TIMER   ( 9308): Detent detected, obj[0x41897180], direction[0], time_stamp[4048166]
05-11 18:08:20.005+0900 D/TIMER   ( 9308): Pre change num: 00
05-11 18:08:20.005+0900 D/TIMER   ( 9308): Post change num: 0
05-11 18:08:20.020+0900 I/efl-extension( 9285): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.065+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.065+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.065+0900 I/efl-extension( 9308): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.065+0900 I/efl-extension( 9308): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897180, elm_layout, time_stamp : 4048224
05-11 18:08:20.065+0900 D/TIMER   ( 9308): Rotary callback is called
05-11 18:08:20.065+0900 D/TIMER   ( 9308): Detent detected, obj[0x41897180], direction[0], time_stamp[4048224]
05-11 18:08:20.065+0900 D/TIMER   ( 9308): Pre change num: 1
05-11 18:08:20.065+0900 D/TIMER   ( 9308): Post change num: 1
05-11 18:08:20.070+0900 I/efl-extension( 9285): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.125+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.125+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.125+0900 I/efl-extension( 9308): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.125+0900 I/efl-extension( 9308): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897180, elm_layout, time_stamp : 4048287
05-11 18:08:20.125+0900 D/TIMER   ( 9308): Rotary callback is called
05-11 18:08:20.125+0900 D/TIMER   ( 9308): Detent detected, obj[0x41897180], direction[0], time_stamp[4048287]
05-11 18:08:20.125+0900 D/TIMER   ( 9308): Pre change num: 2
05-11 18:08:20.125+0900 D/TIMER   ( 9308): Post change num: 2
05-11 18:08:20.130+0900 I/efl-extension( 9285): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.195+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.195+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.195+0900 I/efl-extension( 9308): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.195+0900 I/efl-extension( 9308): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897180, elm_layout, time_stamp : 4048354
05-11 18:08:20.195+0900 D/TIMER   ( 9308): Rotary callback is called
05-11 18:08:20.195+0900 D/TIMER   ( 9308): Detent detected, obj[0x41897180], direction[0], time_stamp[4048354]
05-11 18:08:20.195+0900 D/TIMER   ( 9308): Pre change num: 3
05-11 18:08:20.195+0900 D/TIMER   ( 9308): Post change num: 3
05-11 18:08:20.195+0900 I/efl-extension( 9285): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:20.465+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: MEM_FLUSH State: PAUSED
05-11 18:08:20.810+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4048969 button=1 downs=1
05-11 18:08:20.840+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4049000 button=1 downs=0
05-11 18:08:20.840+0900 D/TIMER   ( 9308): Start clicked
05-11 18:08:20.840+0900 D/TIMER   ( 9308): Setting time is 240
05-11 18:08:20.920+0900 I/SENSOR  ( 9308): Sensor is Started
05-11 18:08:20.920+0900 I/SOCKETTEST( 9308): Success to create socket
05-11 18:08:20.920+0900 I/SOCKETTEST( 9308): socket connect error: Network is unreachable
05-11 18:08:20.920+0900 I/SOCKETTEST( 9308): write() error: Bad file descriptor
05-11 18:08:20.920+0900 D/TIMER   ( 9308): Start clicked
05-11 18:08:20.970+0900 I/SENSOR  ( 9308): -191.589996, 29.820000, 31.920000
05-11 18:08:21.055+0900 I/SENSOR  ( 9308): -2.940000, -5.950000, 4.620000
05-11 18:08:21.160+0900 I/SENSOR  ( 9308): -1.470000, -3.640000, 4.900000
05-11 18:08:21.260+0900 I/SENSOR  ( 9308): -1.820000, -5.040000, 3.150000
05-11 18:08:21.380+0900 I/SENSOR  ( 9308): -1.820000, -4.690000, 2.240000
05-11 18:08:21.460+0900 I/SENSOR  ( 9308): -1.120000, -4.060000, 3.360000
05-11 18:08:21.560+0900 I/SENSOR  ( 9308): 5.460000, 4.410000, 11.060000
05-11 18:08:21.660+0900 I/SENSOR  ( 9308): 1.120000, -4.480000, 3.990000
05-11 18:08:21.710+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4049868 button=1 downs=1
05-11 18:08:21.765+0900 I/SENSOR  ( 9308): 1.330000, 12.110000, 6.300000
05-11 18:08:21.775+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4049937 button=1 downs=0
05-11 18:08:21.780+0900 D/TIMER   ( 9308): Start clicked
05-11 18:08:21.795+0900 I/SOCKETTEST( 9308): Success to create socket
05-11 18:08:21.795+0900 I/SOCKETTEST( 9308): socket connect error: Network is unreachable
05-11 18:08:21.795+0900 I/SOCKETTEST( 9308): write() error: Bad file descriptor
05-11 18:08:24.440+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4052598 button=1 downs=1
05-11 18:08:24.440+0900 D/TIMER   ( 9308): Minute selected
05-11 18:08:24.475+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4052633 button=1 downs=0
05-11 18:08:25.150+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4053306 button=1 downs=1
05-11 18:08:25.195+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4053353 button=1 downs=0
05-11 18:08:25.195+0900 D/TIMER   ( 9308): Start clicked
05-11 18:08:25.195+0900 D/TIMER   ( 9308): Setting time is 0
05-11 18:08:25.195+0900 E/TIMER   ( 9308): (!ad->setting_time) -> _start_clicked_cb() return
05-11 18:08:26.110+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.110+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.110+0900 I/efl-extension( 9285): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.110+0900 I/efl-extension( 9308): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.110+0900 I/efl-extension( 9308): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897180, elm_layout, time_stamp : 4054268
05-11 18:08:26.110+0900 D/TIMER   ( 9308): Rotary callback is called
05-11 18:08:26.110+0900 D/TIMER   ( 9308): Detent detected, obj[0x41897180], direction[0], time_stamp[4054268]
05-11 18:08:26.110+0900 D/TIMER   ( 9308): Pre change num: 00
05-11 18:08:26.110+0900 D/TIMER   ( 9308): Post change num: 0
05-11 18:08:26.145+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.145+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.145+0900 I/efl-extension( 9285): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.145+0900 I/efl-extension( 9308): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.145+0900 I/efl-extension( 9308): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897180, elm_layout, time_stamp : 4054303
05-11 18:08:26.145+0900 D/TIMER   ( 9308): Rotary callback is called
05-11 18:08:26.145+0900 D/TIMER   ( 9308): Detent detected, obj[0x41897180], direction[0], time_stamp[4054303]
05-11 18:08:26.145+0900 D/TIMER   ( 9308): Pre change num: 1
05-11 18:08:26.145+0900 D/TIMER   ( 9308): Post change num: 1
05-11 18:08:26.195+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.195+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.195+0900 I/efl-extension( 9308): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.195+0900 I/efl-extension( 9308): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897180, elm_layout, time_stamp : 4054354
05-11 18:08:26.195+0900 D/TIMER   ( 9308): Rotary callback is called
05-11 18:08:26.195+0900 D/TIMER   ( 9308): Detent detected, obj[0x41897180], direction[0], time_stamp[4054354]
05-11 18:08:26.195+0900 D/TIMER   ( 9308): Pre change num: 2
05-11 18:08:26.195+0900 D/TIMER   ( 9308): Post change num: 2
05-11 18:08:26.195+0900 I/efl-extension( 9285): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.250+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.250+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.250+0900 I/efl-extension( 9308): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.250+0900 I/efl-extension( 9308): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897180, elm_layout, time_stamp : 4054411
05-11 18:08:26.250+0900 D/TIMER   ( 9308): Rotary callback is called
05-11 18:08:26.250+0900 D/TIMER   ( 9308): Detent detected, obj[0x41897180], direction[0], time_stamp[4054411]
05-11 18:08:26.250+0900 D/TIMER   ( 9308): Pre change num: 3
05-11 18:08:26.250+0900 D/TIMER   ( 9308): Post change num: 3
05-11 18:08:26.255+0900 I/efl-extension( 9285): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:26.730+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4054891 button=1 downs=1
05-11 18:08:26.790+0900 E/EFL     ( 9308): evas_main<9308> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4054949 button=1 downs=0
05-11 18:08:26.790+0900 D/TIMER   ( 9308): Start clicked
05-11 18:08:26.790+0900 D/TIMER   ( 9308): Setting time is 240
05-11 18:08:26.800+0900 I/SENSOR  ( 9308): Sensor is Started
05-11 18:08:26.800+0900 I/SOCKETTEST( 9308): Success to create socket
05-11 18:08:26.800+0900 I/SOCKETTEST( 9308): socket connect error: Network is unreachable
05-11 18:08:26.800+0900 I/SOCKETTEST( 9308): write() error: Bad file descriptor
05-11 18:08:26.800+0900 D/TIMER   ( 9308): Start clicked
05-11 18:08:26.865+0900 I/SENSOR  ( 9308): -3.990000, -7.980000, 6.580000
05-11 18:08:26.965+0900 I/SENSOR  ( 9308): -0.980000, -4.410000, 3.430000
05-11 18:08:27.065+0900 I/SENSOR  ( 9308): 1.680000, -4.270000, 5.320000
05-11 18:08:27.170+0900 I/SENSOR  ( 9308): -4.270000, -4.340000, 2.800000
05-11 18:08:27.270+0900 I/SENSOR  ( 9308): 3.150000, -3.150000, 6.160000
05-11 18:08:27.370+0900 I/SENSOR  ( 9308): -2.450000, -4.480000, 1.890000
05-11 18:08:27.475+0900 I/SENSOR  ( 9308): -2.170000, -4.340000, 2.590000
05-11 18:08:27.565+0900 I/SENSOR  ( 9308): -1.540000, -2.800000, 4.970000
05-11 18:08:27.670+0900 I/SENSOR  ( 9308): -1.540000, -3.570000, 3.360000
05-11 18:08:27.765+0900 I/SENSOR  ( 9308): 0.770000, -4.550000, 3.850000
05-11 18:08:27.805+0900 D/TIMER   ( 9308): Timer is start
05-11 18:08:27.805+0900 D/TIMER   ( 9308): Remind time: 240
05-11 18:08:27.930+0900 I/SENSOR  ( 9308): -6.300000, -2.380000, 2.520000
05-11 18:08:27.965+0900 I/SENSOR  ( 9308): -6.720000, -4.900000, -1.190000
05-11 18:08:28.070+0900 I/SENSOR  ( 9308): 6.790000, 0.140000, 2.310000
05-11 18:08:28.165+0900 I/SENSOR  ( 9308): -1.050000, -9.450000, 4.690000
05-11 18:08:28.240+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-11 18:08:28.240+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-11 18:08:28.240+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1866408386)
05-11 18:08:28.245+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-11 18:08:28.245+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 11-5-2016, 09:09:08 (UTC).
05-11 18:08:28.245+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-11 18:08:28.245+0900 E/ALARM_MANAGER(  482): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1866408386] is removed.
05-11 18:08:28.260+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-11 18:08:28.265+0900 I/SENSOR  ( 9308): 0.700000, -3.640000, 5.180000
05-11 18:08:28.265+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-11 18:08:28.300+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.320+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.335+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.355+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.355+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-11 18:08:28.360+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-11 18:08:28.365+0900 I/SENSOR  ( 9308): -0.770000, -2.030000, 6.020000
05-11 18:08:28.375+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.400+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.400+0900 E/ALARM_MANAGER(  482): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1462957712, Wed May 11 18:08:32 2016
05-11 18:08:28.400+0900 E/ALARM_MANAGER(  482): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1930957395, next duetime: 1462957712
05-11 18:08:28.400+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1930957395)
05-11 18:08:28.400+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1462957748), due_time(1462957712)
05-11 18:08:28.400+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-11 18:08:28.400+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 11-5-2016, 09:08:32 (UTC).
05-11 18:08:28.400+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-11 18:08:28.410+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-11 18:08:28.410+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-11 18:08:28.410+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1930957395)
05-11 18:08:28.410+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-11 18:08:28.410+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 11-5-2016, 09:09:08 (UTC).
05-11 18:08:28.410+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-11 18:08:28.410+0900 E/ALARM_MANAGER(  482): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1930957395] is removed.
05-11 18:08:28.420+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-11 18:08:28.420+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-11 18:08:28.435+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.445+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.455+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.465+0900 I/SENSOR  ( 9308): -2.800000, -1.400000, 4.130000
05-11 18:08:28.465+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.465+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-11 18:08:28.470+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-11 18:08:28.480+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.490+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-11 18:08:28.490+0900 E/ALARM_MANAGER(  482): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1462959508, Wed May 11 18:38:28 2016
05-11 18:08:28.490+0900 E/ALARM_MANAGER(  482): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1930957395, next duetime: 1462959508
05-11 18:08:28.490+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1930957395)
05-11 18:08:28.490+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1462957748), due_time(1462959508)
05-11 18:08:28.490+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-11 18:08:28.490+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 11-5-2016, 09:09:08 (UTC).
05-11 18:08:28.490+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-11 18:08:28.565+0900 I/SENSOR  ( 9308): -3.850000, -3.710000, 3.080000
05-11 18:08:28.665+0900 I/SENSOR  ( 9308): -5.880000, -4.480000, 2.100000
05-11 18:08:28.765+0900 I/SENSOR  ( 9308): -1.680000, -3.710000, 5.040000
05-11 18:08:28.805+0900 D/TIMER   ( 9308): Timer is start
05-11 18:08:28.805+0900 D/TIMER   ( 9308): Remind time: 239
05-11 18:08:28.930+0900 I/SENSOR  ( 9308): -3.920000, -8.610000, 2.660000
05-11 18:08:28.965+0900 I/SENSOR  ( 9308): 2.170000, -0.280000, 5.110000
05-11 18:08:29.070+0900 I/SENSOR  ( 9308): 1.330000, -2.380000, 5.250000
05-11 18:08:29.170+0900 I/SENSOR  ( 9308): -3.010000, -6.440000, 6.020000
05-11 18:08:29.275+0900 I/SENSOR  ( 9308): -1.050000, -4.060000, 4.830000
05-11 18:08:29.380+0900 I/SENSOR  ( 9308): -1.470000, -3.150000, 5.250000
05-11 18:08:29.475+0900 I/SENSOR  ( 9308): -6.020000, -5.180000, 5.880000
05-11 18:08:29.570+0900 I/SENSOR  ( 9308): -8.050000, -6.790000, 6.440000
05-11 18:08:29.670+0900 I/SENSOR  ( 9308): -9.800000, -3.640000, 7.210000
05-11 18:08:29.770+0900 I/SENSOR  ( 9308): -8.050000, -0.560000, 6.650000
05-11 18:08:29.805+0900 D/TIMER   ( 9308): Timer is start
05-11 18:08:29.805+0900 D/TIMER   ( 9308): Remind time: 238
05-11 18:08:29.935+0900 I/SENSOR  ( 9308): -3.780000, 1.470000, 2.170000
05-11 18:08:29.970+0900 I/SENSOR  ( 9308): -2.380000, -1.750000, 0.700000
05-11 18:08:30.070+0900 I/SENSOR  ( 9308): -0.770000, -3.500000, 6.370000
05-11 18:08:30.175+0900 I/SENSOR  ( 9308): -2.660000, -3.290000, 9.310000
05-11 18:08:30.270+0900 I/SENSOR  ( 9308): -2.730000, -1.890000, 5.250000
05-11 18:08:30.370+0900 I/SENSOR  ( 9308): -3.010000, -3.640000, 2.170000
05-11 18:08:30.475+0900 I/SENSOR  ( 9308): -0.700000, -5.180000, 0.280000
05-11 18:08:30.575+0900 I/SENSOR  ( 9308): -3.010000, -8.400000, 2.940000
05-11 18:08:30.670+0900 I/SENSOR  ( 9308): -2.380000, -4.270000, 2.870000
05-11 18:08:30.775+0900 I/SENSOR  ( 9308): -0.980000, -4.200000, 2.940000
05-11 18:08:30.805+0900 D/TIMER   ( 9308): Timer is start
05-11 18:08:30.805+0900 D/TIMER   ( 9308): Remind time: 237
05-11 18:08:30.805+0900 D/TIMER   ( 9308): Start clicked
05-11 18:08:30.930+0900 I/SENSOR  ( 9308): 0.490000, -6.930000, 5.460000
05-11 18:08:30.970+0900 I/SENSOR  ( 9308): -2.100000, -7.000000, 6.300000
05-11 18:08:31.070+0900 I/SENSOR  ( 9308): -1.610000, -5.740000, 7.280000
05-11 18:08:31.175+0900 I/SENSOR  ( 9308): -0.070000, -7.350000, 7.840000
05-11 18:08:31.275+0900 I/SENSOR  ( 9308): 11.970000, -7.000000, 7.000000
05-11 18:08:31.370+0900 I/SENSOR  ( 9308): 9.100000, -23.590000, 11.480000
05-11 18:08:31.475+0900 I/SENSOR  ( 9308): 12.110000, -16.799999, 9.030000
05-11 18:08:31.575+0900 I/SENSOR  ( 9308): 9.100000, -12.530000, 1.540000
05-11 18:08:31.675+0900 I/SENSOR  ( 9308): -5.670000, -6.930000, 7.840000
05-11 18:08:31.775+0900 I/SENSOR  ( 9308): 13.650000, 6.090000, 44.310001
05-11 18:08:31.805+0900 D/TIMER   ( 9308): Timer is start
05-11 18:08:31.805+0900 D/TIMER   ( 9308): Remind time: 236
05-11 18:08:31.905+0900 I/SENSOR  ( 9308): 1.400000, 6.720000, 16.309999
05-11 18:08:32.055+0900 I/SENSOR  ( 9308): -9.450000, -6.440000, -20.860001
05-11 18:08:32.085+0900 I/SENSOR  ( 9308): -5.110000, -6.230000, 6.230000
05-11 18:08:32.185+0900 I/SENSOR  ( 9308): 0.630000, -5.530000, 6.930000
05-11 18:08:32.280+0900 I/SENSOR  ( 9308): 0.350000, -2.870000, 3.220000
05-11 18:08:32.365+0900 I/efl-extension( 9308): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x41897180
05-11 18:08:32.365+0900 I/efl-extension( 9308): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x41897180, obj: 0x41897180
05-11 18:08:32.365+0900 I/efl-extension( 9308): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-11 18:08:32.380+0900 I/SENSOR  ( 9308): 0.490000, -0.070000, -1.540000
05-11 18:08:32.470+0900 I/SENSOR  ( 9308): 4.900000, 3.640000, -6.160000
05-11 18:08:32.575+0900 I/SENSOR  ( 9308): 8.050000, 0.840000, -0.630000
05-11 18:08:32.670+0900 I/SENSOR  ( 9308): -5.460000, -11.620000, -0.210000
05-11 18:08:32.780+0900 I/SENSOR  ( 9308): 5.530000, -2.170000, -0.420000
05-11 18:08:32.800+0900 D/TIMER   ( 9308): Timer is start
05-11 18:08:32.800+0900 D/TIMER   ( 9308): Remind time: 235
05-11 18:08:32.800+0900 F/EFL     ( 9308): evas_main<9308> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
05-11 18:08:33.065+0900 W/CRASH_MANAGER( 9882): worker.c: worker_job(1199) > 1109308706831146295771
