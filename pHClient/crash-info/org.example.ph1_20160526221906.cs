S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 9813
Date: 2016-05-26 22:19:06+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9813, uid 5000)

Register Information
r0   = 0x702f6374, r1   = 0x00000025
r2   = 0xbeb921fc, r3   = 0x0000feff
r4   = 0x702f6370, r5   = 0x702f6374
r6   = 0xbeb91cc8, r7   = 0x25252525
r8   = 0x00000000, r9   = 0x4142dec0
r10  = 0x702f6374, fp   = 0xbeb91cbc
ip   = 0x702f6374, sp   = 0xbeb91748
lr   = 0x404b1f5c, pc   = 0x404ec6dc
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     17544 KB
Buffers:     30648 KB
Cached:     165464 KB
VmPeak:      95344 KB
VmSize:      93308 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22676 KB
VmRSS:       22676 KB
VmData:      33972 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25096 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9813 TID = 9813
9813 9906 

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
448b0000 448b1000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
448ce000 448d5000 r-xp /usr/lib/libfeedback.so.0.1.4
448de000 448df000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
448e7000 448e9000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
448f1000 448f8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44b0a000 44b14000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
44b1c000 44b32000 r-xp /usr/lib/libmmfsound.so.0.1.0
44b44000 44b49000 r-xp /usr/lib/libmmfsession.so.0.0.0
44b51000 44b5b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44b67000 44b6b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44b74000 44b8a000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44b93000 44b98000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
44ba0000 44ba3000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44bab000 44be3000 r-xp /usr/lib/libpulse.so.0.16.2
44be4000 44be7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44bef000 44bfc000 r-xp /usr/lib/libail.so.0.1.0
44c05000 44c08000 r-xp /usr/lib/libcompress.so.0.2.0
44c13000 45412000 rwxp [stack:9906]
4589a000 458fb000 r-xp /usr/lib/libasound.so.2.0.0
45905000 45915000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
45936000 4593e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
4594d000 45952000 r-xp /usr/lib/libjson.so.0.0.1
4595a000 459a2000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
459a3000 459e6000 r-xp /usr/lib/libsndfile.so.1.0.25
459f3000 45a15000 r-xp /usr/lib/libvorbis.so.0.4.3
45a1d000 45a21000 r-xp /usr/lib/libogg.so.0.7.1
beb72000 beb93000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9813)
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
dResponse
05-26 22:18:47.471+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:47.476+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:18:47.476+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [true][0m
05-26 22:18:47.476+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:18:47.486+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 737
05-26 22:18:47.491+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT][0m
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:18:47.496+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:47.501+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 22:18:47.501+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 22:18:47.501+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT][0m
05-26 22:18:47.501+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:47.501+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:47.501+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:47.501+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:18:47.501+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:18:47.501+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:47.501+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:47.501+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:47.506+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 22:18:47.506+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:47.506+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:47.511+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:47.511+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:47.511+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:47.511+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:18:47.511+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:18:47.511+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:47.511+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:47.511+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:18:47.511+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:18:47.511+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:47.581+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:18:47.581+0900 I/efl-extension(  737): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x47911dc0, elm_layout, time_stamp : 2764631
05-26 22:18:47.581+0900 W/APPS    (  737): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
05-26 22:18:47.581+0900 W/APPS    (  737): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3169) >  __nIsEditMode[0], __focusPage[2], __focusIndex[20], __pAppsItemList.size[21]
05-26 22:18:47.581+0900 W/APPS    (  737): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[19]
05-26 22:18:47.591+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:18:47.751+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:18:47.751+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:18:47.756+0900 I/efl-extension(  737): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x47911dc0, elm_layout, time_stamp : 2764798
05-26 22:18:47.756+0900 W/APPS    (  737): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3169) >  __nIsEditMode[0], __focusPage[2], __focusIndex[19], __pAppsItemList.size[21]
05-26 22:18:47.756+0900 W/APPS    (  737): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[18]
05-26 22:18:47.756+0900 W/APPS    (  737): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 22:18:47.986+0900 W/APPS    (  737): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 22:18:48.301+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:48.301+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:48.301+0900 I/efl-extension(  737): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x47911dc0, elm_layout, time_stamp : 2765348
05-26 22:18:48.301+0900 W/APPS    (  737): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[18], __pAppsItemList.size[21]
05-26 22:18:48.301+0900 W/APPS    (  737): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[19]
05-26 22:18:48.531+0900 W/APPS    (  737): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 22:18:48.831+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 22:18:48.831+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2765880 button=1 downs=1
05-26 22:18:48.831+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [142, 150]
05-26 22:18:48.896+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2765945 button=1 downs=0
05-26 22:18:48.896+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [142, 150]->[148, 165]
05-26 22:18:48.901+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-26 22:18:48.901+0900 E/APPS    (  737): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-26 22:18:48.901+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-26 22:18:48.906+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:18:48.906+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 737
05-26 22:18:48.906+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:18:48.921+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-26 22:18:48.921+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 22:18:48.921+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 22:18:48.921+0900 W/AUL_PAD ( 1155): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 22:18:48.926+0900 W/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 22:18:48.961+0900 I/efl-extension( 9813): efl_extension.c: eext_mod_init(40) > Init
05-26 22:18:48.961+0900 I/UXT     ( 9813): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 22:18:48.971+0900 I/CAPI_APPFW_APPLICATION( 9813): app_main.c: ui_app_main(704) > app_efl_main
05-26 22:18:48.976+0900 I/CAPI_APPFW_APPLICATION( 9813): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-26 22:18:49.026+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:18:49.036+0900 E/RESOURCED(  497): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-26 22:18:49.036+0900 E/TBM     ( 9813): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 22:18:49.161+0900 E/EFL     ( 9813): <9813> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-26 22:18:49.181+0900 E/EFL     ( 9813): <9813> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:18:49.186+0900 E/EFL     ( 9813): <9813> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:18:49.186+0900 E/EFL     ( 9813): <9813> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:18:49.196+0900 E/EFL     ( 9813): <9813> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:18:49.201+0900 E/EFL     ( 9813): <9813> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:18:49.286+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04a00002)
05-26 22:18:49.346+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 22:18:49.346+0900 I/APP_CORE( 9813): appcore-efl.c: __do_app(429) > [APP 9813] Event: RESET State: CREATED
05-26 22:18:49.346+0900 I/CAPI_APPFW_APPLICATION( 9813): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 22:18:49.346+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:49.346+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:49.351+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:49.351+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 22:18:49.361+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:18:49.361+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:18:49.366+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 22:18:49.386+0900 I/APP_CORE( 9813): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 22:18:49.386+0900 I/APP_CORE( 9813): appcore-efl.c: __do_app(474) > [APP 9813] Initial Launching, call the resume_cb
05-26 22:18:49.386+0900 I/CAPI_APPFW_APPLICATION( 9813): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 22:18:49.481+0900 W/APP_CORE( 9813): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4a00002
05-26 22:18:49.546+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 22:18:49.546+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 22:18:49.546+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:49.546+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 22:18:49.551+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 22:18:49.551+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:18:49.551+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 22:18:49.551+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 22:18:49.551+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:49.551+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:49.551+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:49.551+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 22:18:49.551+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:18:49.551+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 22:18:49.551+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:18:49.551+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:18:49.551+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:18:49.551+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 22:18:49.551+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:18:49.551+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:18:49.551+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:18:49.566+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:49.566+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:49.566+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:49.566+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:18:49.566+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:18:49.566+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:49.566+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:18:49.566+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:49.571+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:49.571+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:49.571+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:49.571+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:18:49.571+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:18:49.571+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:49.571+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:18:49.571+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:18:49.571+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:18:49.571+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:49.571+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:18:49.571+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:18:49.606+0900 I/APP_CORE( 9813): appcore-efl.c: __do_app(429) > [APP 9813] Event: RESUME State: RUNNING
05-26 22:18:49.696+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 22:18:49.696+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:18:49.711+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 22:18:49.736+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:18:49.736+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 22:18:49.931+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:18:50.071+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:18:50.311+0900 I/AUL_PAD ( 9907): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 22:18:50.376+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:18:50.381+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9813
05-26 22:18:50.391+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:18:50.461+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2767509 button=1 downs=1
05-26 22:18:50.501+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2767552 button=1 downs=0
05-26 22:18:51.381+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2768432 button=1 downs=1
05-26 22:18:51.511+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2768563 button=1 downs=0
05-26 22:18:51.741+0900 I/CAPI_NETWORK_CONNECTION( 9813): connection.c: connection_create(372) > New handle created[0x4188a978]
05-26 22:18:51.756+0900 I/SOCKETTEST( 9813): IP : 
05-26 22:18:51.756+0900 I/SOCKETTEST( 9813): Success to create UDP socket
05-26 22:18:51.756+0900 I/SOCKETTEST( 9813): Bind Success
05-26 22:18:51.756+0900 I/SOCKETTEST( 9813): Waiting DATA...
05-26 22:18:54.026+0900 I/SOCKETTEST( 9813): Receive Data : 192.168.0.47
05-26 22:18:54.026+0900 I/SOCKETTEST( 9813): Changed IP : 192.168.0.47
05-26 22:18:54.036+0900 I/SOCKETTEST( 9813): Success to create socket
05-26 22:18:54.041+0900 I/SOCKETTEST( 9813): Success to socket connection
05-26 22:18:54.041+0900 I/SOCKETTEST( 9813): write() 성공
05-26 22:18:54.586+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:18:59.766+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 22:18:59.771+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 22:18:59.776+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : pedometer_inactive_period error
05-26 22:18:59.781+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 22:18:59.781+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 22:18:59.791+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_10min_precaution_millisec error
05-26 22:18:59.796+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 22:18:59.796+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 22:18:59.801+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_before_10min_precaution_millisec error
05-26 22:18:59.881+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2776930 button=1 downs=1
05-26 22:18:59.991+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2777042 button=1 downs=0
05-26 22:19:00.016+0900 D/TIMER   ( 9813): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:19:00.016+0900 D/TIMER   ( 9813): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:19:00.066+0900 I/efl-extension( 9813): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:19:00.066+0900 I/efl-extension( 9813): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:19:00.066+0900 I/efl-extension( 9813): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:19:00.071+0900 I/efl-extension( 9813): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:19:00.071+0900 I/efl-extension( 9813): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41897968, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:19:00.106+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:19:01.606+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2778650 button=1 downs=1
05-26 22:19:01.661+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2778708 button=1 downs=0
05-26 22:19:02.416+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.416+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.416+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.421+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779463
05-26 22:19:02.421+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.486+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.486+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.486+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779533
05-26 22:19:02.486+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.486+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.546+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.546+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.546+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779596
05-26 22:19:02.546+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.546+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.591+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.591+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.591+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779641
05-26 22:19:02.591+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.591+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.636+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.636+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.636+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779686
05-26 22:19:02.636+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.636+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.671+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.671+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.671+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779721
05-26 22:19:02.671+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.671+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.696+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.696+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.696+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779747
05-26 22:19:02.696+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.696+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.716+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.716+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.716+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779765
05-26 22:19:02.716+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.716+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.766+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.766+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.766+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779813
05-26 22:19:02.766+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.766+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.831+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.831+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.831+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779881
05-26 22:19:02.831+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.831+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.881+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.881+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779930
05-26 22:19:02.881+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.881+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.881+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.936+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.936+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:02.936+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2779984
05-26 22:19:02.936+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:02.936+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:03.006+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:03.006+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:03.006+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2780053
05-26 22:19:03.006+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:03.006+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:03.111+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:03.111+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:03.111+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2780162
05-26 22:19:03.111+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:03.111+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:03.751+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2780798 button=1 downs=1
05-26 22:19:03.816+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2780863 button=1 downs=0
05-26 22:19:04.936+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 22:19:04.936+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 22:19:05.151+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.151+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.151+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782201
05-26 22:19:05.151+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.151+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.201+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.201+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.201+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782249
05-26 22:19:05.201+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.201+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.241+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.241+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.241+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782291
05-26 22:19:05.241+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.241+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.276+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.276+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.276+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782326
05-26 22:19:05.276+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.276+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.301+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.301+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.301+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782349
05-26 22:19:05.301+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.301+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.316+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.316+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.316+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782364
05-26 22:19:05.316+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.316+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.336+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.336+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.336+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782385
05-26 22:19:05.336+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.336+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.406+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.406+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.406+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782455
05-26 22:19:05.406+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.406+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.451+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.451+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.451+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782499
05-26 22:19:05.451+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.451+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.491+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.496+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.496+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782543
05-26 22:19:05.496+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.496+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.536+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.541+0900 I/efl-extension( 9813): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:05.541+0900 I/efl-extension( 9813): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897968, elm_layout, time_stamp : 2782588
05-26 22:19:05.541+0900 E/TIMER   ( 9813): (ad->timer) -> _rotary_cb() return
05-26 22:19:05.541+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:19:06.616+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2783664 button=1 downs=1
05-26 22:19:06.681+0900 E/EFL     ( 9813): evas_main<9813> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2783732 button=1 downs=0
05-26 22:19:06.686+0900 I/efl-extension( 9813): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:19:06.686+0900 I/efl-extension( 9813): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x41897968, elm_layout, func : 0x415608d9
05-26 22:19:06.686+0900 I/efl-extension( 9813): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:19:06.686+0900 I/efl-extension( 9813): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:19:06.686+0900 I/efl-extension( 9813): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:19:06.686+0900 I/efl-extension( 9813): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:19:06.686+0900 I/efl-extension( 9813): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:19:06.686+0900 I/efl-extension( 9813): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:19:06.686+0900 E/EFL     ( 9813): ecore<9813> ecore.c:574 _ecore_magic_fail() 
05-26 22:19:06.686+0900 E/EFL     ( 9813): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:19:06.686+0900 E/EFL     ( 9813): *** IN FUNCTION: ecore_timer_del()
05-26 22:19:06.686+0900 E/EFL     ( 9813): ecore<9813> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:19:06.686+0900 E/EFL     ( 9813):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:19:06.686+0900 E/EFL     ( 9813):     Supplied: 0049a1bd - <UNKNOWN>
05-26 22:19:06.686+0900 E/EFL     ( 9813): ecore<9813> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:19:06.686+0900 E/EFL     ( 9813): *** SPANK SPANK SPANK!!!
05-26 22:19:06.686+0900 E/EFL     ( 9813): *** Now go fix your code. Tut tut tut!
05-26 22:19:06.686+0900 I/SOCKETTEST( 9813): Success to create socket
05-26 22:19:06.701+0900 I/SOCKETTEST( 9813): Success to socket connection
05-26 22:19:06.701+0900 I/SOCKETTEST( 9813): write() 성공
05-26 22:19:06.871+0900 W/CRASH_MANAGER( 9884): worker.c: worker_job(1199) > 1109813706831146426874
