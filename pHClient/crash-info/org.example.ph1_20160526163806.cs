S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 5820
Date: 2016-05-26 16:38:06+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x652f2f72

Register Information
r0   = 0x00000000, r1   = 0x41431708
r2   = 0x41431700, r3   = 0x00000000
r4   = 0x78652e67, r5   = 0x6c706d61
r6   = 0x68702e65, r7   = 0x65722f31
r8   = 0x00000000, r9   = 0x449345c0
r10  = 0x41886288, fp   = 0x00000000
ip   = 0x4142def4, sp   = 0xbef07658
lr   = 0x400953f8, pc   = 0x652f2f72
cpsr = 0x60000030

Memory Information
MemTotal:   489992 KB
MemFree:     36076 KB
Buffers:     36688 KB
Cached:     128052 KB
VmPeak:      90748 KB
VmSize:      86132 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19784 KB
VmRSS:       18248 KB
VmData:      32944 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22964 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5820 TID = 5820
5820 5884 

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
44c94000 45493000 rwxp [stack:5884]
beee7000 bef08000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5820)
Call Stack Count: 1
 0: (0x652f2f72) (null)
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
) > _MessagePortIpcServer::Stop
05-26 16:37:58.170+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1445]   [MUSIC_PLAYER_EVENT][0m
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 16:37:58.170+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 16:37:58.175+0900 W/W_HOME  (  726): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 16:37:58.175+0900 E/W_HOME  (  726): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 16:37:58.175+0900 W/W_HOME  (  726): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 16:37:58.175+0900 E/W_HOME  (  726): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 16:37:58.180+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.180+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.185+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.185+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1178790
05-26 16:37:58.185+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[2], __pAppsItemList.size[21]
05-26 16:37:58.185+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[1], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[7]
05-26 16:37:58.185+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:37:58.195+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1178821
05-26 16:37:58.195+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4676) >  Rotary: fast moving
05-26 16:37:58.230+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.235+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.235+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1178869
05-26 16:37:58.235+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4676) >  Rotary: fast moving
05-26 16:37:58.280+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.295+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.295+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1178922
05-26 16:37:58.295+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4676) >  Rotary: fast moving
05-26 16:37:58.325+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.330+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.330+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1178967
05-26 16:37:58.330+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4676) >  Rotary: fast moving
05-26 16:37:58.360+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.370+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.370+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179000
05-26 16:37:58.370+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4676) >  Rotary: fast moving
05-26 16:37:58.380+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.385+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.385+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179021
05-26 16:37:58.385+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4676) >  Rotary: fast moving
05-26 16:37:58.405+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.420+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.420+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179046
05-26 16:37:58.420+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4676) >  Rotary: fast moving
05-26 16:37:58.420+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:37:58.435+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.435+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.435+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179078
05-26 16:37:58.435+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
05-26 16:37:58.435+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[7], __pAppsItemList.size[21]
05-26 16:37:58.435+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[8]
05-26 16:37:58.450+0900 E/APPS    (  726): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3513) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
05-26 16:37:58.520+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.525+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.525+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179161
05-26 16:37:58.525+0900 E/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
05-26 16:37:58.565+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.575+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.575+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179205
05-26 16:37:58.575+0900 E/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
05-26 16:37:58.610+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.620+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:58.620+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179249
05-26 16:37:58.620+0900 E/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
05-26 16:37:58.685+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:37:58.960+0900 W/AUL_AMD (  474): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-26 16:37:58.990+0900 W/AUL_AMD (  474): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-26 16:37:59.000+0900 W/AUL_AMD (  474): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-26 16:37:59.010+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.010+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179652
05-26 16:37:59.010+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
05-26 16:37:59.010+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[8], __pAppsItemList.size[21]
05-26 16:37:59.010+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[9]
05-26 16:37:59.010+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.050+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.060+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.060+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179691
05-26 16:37:59.060+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[9], __pAppsItemList.size[21]
05-26 16:37:59.060+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[10]
05-26 16:37:59.065+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:37:59.095+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.105+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.105+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179734
05-26 16:37:59.105+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[10], __pAppsItemList.size[21]
05-26 16:37:59.105+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[11]
05-26 16:37:59.110+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:37:59.140+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.140+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.140+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179778
05-26 16:37:59.140+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[11], __pAppsItemList.size[21]
05-26 16:37:59.140+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[12]
05-26 16:37:59.145+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:37:59.180+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.195+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.195+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179819
05-26 16:37:59.195+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[12], __pAppsItemList.size[21]
05-26 16:37:59.195+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[13]
05-26 16:37:59.200+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:37:59.215+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.225+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.230+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179853
05-26 16:37:59.230+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[13], __pAppsItemList.size[21]
05-26 16:37:59.230+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[1], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[15]
05-26 16:37:59.230+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:37:59.245+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.255+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.255+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179884
05-26 16:37:59.255+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4676) >  Rotary: fast moving
05-26 16:37:59.275+0900 W/AUL_AMD (  474): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-26 16:37:59.285+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.285+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.285+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1179923
05-26 16:37:59.285+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4676) >  Rotary: fast moving
05-26 16:37:59.465+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:37:59.630+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.630+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.630+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1180271
05-26 16:37:59.630+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
05-26 16:37:59.630+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[15], __pAppsItemList.size[21]
05-26 16:37:59.630+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[16]
05-26 16:37:59.645+0900 E/APPS    (  726): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3513) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
05-26 16:37:59.695+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.700+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.700+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1180336
05-26 16:37:59.700+0900 E/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
05-26 16:37:59.740+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.755+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.755+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1180380
05-26 16:37:59.755+0900 E/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
05-26 16:37:59.790+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.805+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:37:59.810+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1180430
05-26 16:37:59.810+0900 E/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
05-26 16:37:59.880+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:38:00.040+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 16:38:00.160+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:38:00.160+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:38:00.160+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1180800
05-26 16:38:00.160+0900 W/APPS    (  726): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
05-26 16:38:00.160+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[16], __pAppsItemList.size[21]
05-26 16:38:00.160+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[17]
05-26 16:38:00.265+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:38:00.265+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:38:00.265+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1180903
05-26 16:38:00.265+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[17], __pAppsItemList.size[21]
05-26 16:38:00.265+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[18]
05-26 16:38:00.265+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:38:00.505+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:38:00.550+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 16:38:00.550+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 16:38:00.550+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : pedometer_inactive_period error
05-26 16:38:00.550+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 16:38:00.550+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 16:38:00.550+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_10min_precaution_millisec error
05-26 16:38:00.550+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 16:38:00.550+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 16:38:00.550+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_before_10min_precaution_millisec error
05-26 16:38:00.660+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:38:00.660+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 1181300
05-26 16:38:00.660+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[18], __pAppsItemList.size[21]
05-26 16:38:00.660+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[19]
05-26 16:38:00.660+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 16:38:00.900+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 16:38:01.145+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 16:38:01.150+0900 E/EFL     (  726): evas_main<726> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1181787 button=1 downs=1
05-26 16:38:01.150+0900 W/APPS    (  726): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [170, 189]
05-26 16:38:01.190+0900 E/EFL     (  726): evas_main<726> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1181814 button=1 downs=0
05-26 16:38:01.190+0900 W/APPS    (  726): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [170, 189]->[174, 183]
05-26 16:38:01.190+0900 W/APPS    (  726): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-26 16:38:01.190+0900 E/APPS    (  726): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-26 16:38:01.190+0900 W/APPS    (  726): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-26 16:38:01.195+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 16:38:01.195+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(1702) > caller pid : 726
05-26 16:38:01.195+0900 I/AUL_AMD (  474): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 16:38:01.205+0900 E/RESOURCED(  475): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-26 16:38:01.210+0900 E/RESOURCED(  475): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 16:38:01.210+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 16:38:01.210+0900 W/AUL_PAD ( 1199): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 16:38:01.210+0900 W/AUL_PAD ( 1199): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 16:38:01.245+0900 I/efl-extension( 5820): efl_extension.c: eext_mod_init(40) > Init
05-26 16:38:01.245+0900 I/UXT     ( 5820): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 16:38:01.255+0900 I/CAPI_APPFW_APPLICATION( 5820): app_main.c: ui_app_main(704) > app_efl_main
05-26 16:38:01.260+0900 I/CAPI_APPFW_APPLICATION( 5820): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-26 16:38:01.300+0900 E/TBM     ( 5820): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 16:38:01.315+0900 E/AUL     (  474): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 16:38:01.315+0900 E/RESOURCED(  475): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-26 16:38:01.375+0900 E/EFL     ( 5820): <5820> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-26 16:38:01.380+0900 E/EFL     ( 5820): <5820> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 16:38:01.380+0900 E/EFL     ( 5820): <5820> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 16:38:01.380+0900 E/EFL     ( 5820): <5820> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 16:38:01.380+0900 E/EFL     ( 5820): <5820> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 16:38:01.380+0900 E/EFL     ( 5820): <5820> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 16:38:01.420+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x06200002)
05-26 16:38:01.420+0900 I/APP_CORE( 5820): appcore-efl.c: __do_app(429) > [APP 5820] Event: RESET State: CREATED
05-26 16:38:01.420+0900 I/CAPI_APPFW_APPLICATION( 5820): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 16:38:01.445+0900 I/APP_CORE( 5820): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 16:38:01.445+0900 I/APP_CORE( 5820): appcore-efl.c: __do_app(474) > [APP 5820] Initial Launching, call the resume_cb
05-26 16:38:01.445+0900 I/CAPI_APPFW_APPLICATION( 5820): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 16:38:01.470+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 16:38:01.475+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 16:38:01.475+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:01.475+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:01.475+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:01.475+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 16:38:01.480+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 16:38:01.480+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 16:38:01.515+0900 W/APP_CORE( 5820): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6200002
05-26 16:38:01.595+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-26 16:38:01.595+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 16:38:01.595+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:01.595+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-26 16:38:01.595+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: PAUSE State: RUNNING
05-26 16:38:01.595+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 16:38:01.595+0900 W/W_HOME  (  726): main.c: _appcore_pause_cb(690) > appcore pause
05-26 16:38:01.595+0900 W/W_HOME  (  726): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 16:38:01.595+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:01.595+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:01.595+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:01.595+0900 W/W_HOME  (  726): rotary.c: rotary_deattach(156) > rotary_deattach:0x478904a8
05-26 16:38:01.595+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 16:38:01.595+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x478904a8, elm_layout, func : 0x4004b469
05-26 16:38:01.595+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 16:38:01.595+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 16:38:01.595+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 16:38:01.595+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x478904a8, activated : 1
05-26 16:38:01.595+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 16:38:01.595+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 16:38:01.595+0900 I/wnotib  (  726): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 31, 101.
05-26 16:38:01.595+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 16:38:01.600+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 16:38:01.600+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 16:38:01.600+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 16:38:01.600+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 16:38:01.600+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 16:38:01.600+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 16:38:01.600+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 16:38:01.600+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 16:38:01.605+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 16:38:01.605+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 16:38:01.605+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 16:38:01.605+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 16:38:01.605+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 16:38:01.605+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 16:38:01.605+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 16:38:01.605+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 16:38:01.605+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 16:38:01.605+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 16:38:01.605+0900 E/CAPI_APPFW_APP_CONTROL( 1445): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 16:38:01.605+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1445]   [com.samsung.w-home]register msg port [false][0m
05-26 16:38:01.605+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 16:38:01.605+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 16:38:01.625+0900 I/APP_CORE( 5820): appcore-efl.c: __do_app(429) > [APP 5820] Event: RESUME State: RUNNING
05-26 16:38:01.685+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 16:38:01.685+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 16:38:01.695+0900 W/APPS    (  726): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 16:38:01.965+0900 E/AUL     (  474): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 16:38:02.105+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: MEM_FLUSH State: PAUSED
05-26 16:38:02.470+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 16:38:02.490+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5820
05-26 16:38:02.495+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 16:38:02.835+0900 I/AUL_PAD ( 5887): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 16:38:02.940+0900 E/EFL     ( 5820): evas_main<5820> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1183578 button=1 downs=1
05-26 16:38:02.990+0900 E/EFL     ( 5820): evas_main<5820> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1183632 button=1 downs=0
05-26 16:38:03.010+0900 D/TIMER   ( 5820): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 16:38:03.010+0900 D/TIMER   ( 5820): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 16:38:03.060+0900 D/TIMER   ( 5820): Digital create
05-26 16:38:03.070+0900 D/TIMER   ( 5820): Initialize the rotary event
05-26 16:38:03.070+0900 I/efl-extension( 5820): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 16:38:03.070+0900 I/efl-extension( 5820): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 16:38:03.070+0900 I/efl-extension( 5820): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 16:38:03.070+0900 I/efl-extension( 5820): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 16:38:03.075+0900 I/efl-extension( 5820): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41897228, elm_layout, _activated_obj : 0x0, activated : 1
05-26 16:38:04.680+0900 I/efl-extension( 5820): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x41897228
05-26 16:38:04.680+0900 I/efl-extension( 5820): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x41897228, obj: 0x41897228
05-26 16:38:04.680+0900 I/efl-extension( 5820): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 16:38:04.680+0900 I/efl-extension( 5820): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 16:38:04.680+0900 I/efl-extension( 5820): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 16:38:04.680+0900 I/efl-extension( 5820): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 16:38:05.485+0900 I/CAPI_APPFW_APPLICATION( 5820): app_main.c: ui_app_exit(715) > ui_app_exit
05-26 16:38:05.485+0900 I/CAPI_APPFW_APPLICATION( 5820): app_main.c: app_efl_exit(145) > app_efl_exit
05-26 16:38:05.490+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 16:38:05.490+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 16:38:05.685+0900 I/APP_CORE( 5820): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 16:38:05.685+0900 I/APP_CORE( 5820): appcore-efl.c: __after_loop(1090) > [APP 5820] PAUSE before termination
05-26 16:38:05.685+0900 I/CAPI_APPFW_APPLICATION( 5820): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-26 16:38:05.690+0900 I/CAPI_APPFW_APPLICATION( 5820): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 16:38:05.705+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 16:38:05.705+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 16:38:05.785+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 16:38:05.785+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 16:38:05.785+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:05.785+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:05.785+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:05.785+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 16:38:05.785+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 16:38:05.785+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 16:38:05.785+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:38:05.785+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:38:05.785+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:38:05.805+0900 I/UXT     ( 5820): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 16:38:05.810+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-26 16:38:05.810+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 16:38:05.810+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:05.810+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-26 16:38:05.810+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESUME State: PAUSED
05-26 16:38:05.810+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 16:38:05.810+0900 W/W_HOME  (  726): main.c: _appcore_resume_cb(681) > appcore resume
05-26 16:38:05.810+0900 W/W_HOME  (  726): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 16:38:05.810+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:05.810+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:05.810+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:38:05.830+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 16:38:05.830+0900 W/W_HOME  (  726): rotary.c: rotary_attach(138) > rotary_attach:0x478904a8
05-26 16:38:05.830+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x478904a8, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-26 16:38:05.830+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 16:38:05.830+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 16:38:05.830+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 16:38:05.830+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 16:38:05.830+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 16:38:05.830+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 16:38:05.830+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 16:38:05.830+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 16:38:06.275+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 16:38:06.385+0900 I/AUL_AMD (  474): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 5820
05-26 16:38:06.390+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 16:38:06.395+0900 E/EFL     (  726): evas_main<726> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1187033 button=1 downs=1
05-26 16:38:06.395+0900 W/APPS    (  726): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [140, 175]
05-26 16:38:06.445+0900 W/CRASH_MANAGER( 5912): worker.c: worker_job(1199) > 1105820706831146424828
