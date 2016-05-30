S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 14318
Date: 2016-05-27 20:35:40+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x45c14938, r5   = 0x41461d89
r6   = 0x45c15238, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x45c13bb8
r10  = 0x41c44510, fp   = 0x00000000
ip   = 0x4143b490, sp   = 0xbe96a630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     33896 KB
Buffers:     44536 KB
Cached:     140936 KB
VmPeak:     102504 KB
VmSize:      91760 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26096 KB
VmRSS:       21964 KB
VmData:      37344 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23960 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14318 TID = 14318
14318 14356 14405 

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
4143c000 41444000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41445000 4144a000 r-xp /usr/lib/libappcore-common.so.1.1
41452000 41454000 r-xp /usr/lib/libiniparser.so.0
4145d000 41464000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
41472000 41476000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4147f000 41481000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4148a000 41490000 r-xp /usr/lib/libappsvc.so.0.1.0
41498000 414bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414c5000 41594000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415aa000 415b4000 r-xp /lib/libnss_files-2.13.so
41771000 41779000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.2.5
41781000 4178e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41796000 4179b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
417a3000 417a7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417b0000 417d1000 r-xp /usr/lib/libefl-extension.so.0.1.0
417d9000 417f0000 r-xp /usr/lib/libnetwork.so.0.0.0
417f8000 417fd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41805000 41823000 r-xp /usr/lib/libsensor.so.1.1.0
4182d000 4183f000 r-xp /usr/lib/libefl-assist.so.0.1.0
41847000 418ff000 r-xp /usr/lib/libcairo.so.2.11200.14
4190a000 4193b000 r-xp /usr/lib/libmdm.so.1.1.85
41943000 4194a000 r-xp /usr/lib/libsensord-share.so
41952000 41964000 r-xp /usr/lib/libtts.so
4196c000 4198d000 r-xp /usr/lib/libui-extension.so.0.1.0
41996000 4199d000 r-xp /usr/lib/libtbm.so.1.0.0
419a5000 419b3000 r-xp /usr/lib/libGLESv2.so.2.0
419bc000 419bd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
419c6000 419cc000 r-xp /usr/lib/libxcb-render.so.0.0.0
419d4000 419d7000 r-xp /usr/lib/libEGL.so.1.4
419df000 419e7000 r-xp /usr/lib/libmdm-common.so.1.0.89
419e8000 41acc000 r-xp /usr/lib/libicuuc.so.51.1
41ae1000 41ae4000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41aec000 41af4000 r-xp /usr/lib/libdrm.so.2.4.0
41afc000 41b01000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41b0a000 41b0f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41b1a000 41c4c000 rw-p [heap]
41c4c000 41d89000 r-xp /usr/lib/libicui18n.so.51.1
43320000 43322000 r-xp /usr/lib/libdri2.so.0.0.0
4332a000 4334b000 r-xp /usr/lib/libexif.so.12.3.3
4335e000 43363000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4336b000 43435000 r-xp /usr/lib/libCOREGL.so.4.0
4378c000 43790000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44201000 44a00000 rwxp [stack:14405]
44b94000 45393000 rwxp [stack:14356]
459e8000 459eb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45a5e000 45a96000 r-xp /usr/lib/libpulse.so.0.16.2
45b0b000 45b10000 r-xp /usr/lib/libjson.so.0.0.1
45b18000 45b60000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45b61000 45ba4000 r-xp /usr/lib/libsndfile.so.1.0.25
45bb1000 45bd3000 r-xp /usr/lib/libvorbis.so.0.4.3
45bdb000 45bdf000 r-xp /usr/lib/libogg.so.0.7.1
be94a000 be96b000 rwxp [stack]
End of Maps Information

Callstack Information (PID:14318)
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
_mouse_down() ButtonEvent:down time=5144791 button=1 downs=1
05-27 20:35:18.814+0900 E/EFL     (14318): evas_main<14318> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5144813 button=1 downs=0
05-27 20:35:18.834+0900 D/TIMER   (14318): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-27 20:35:18.834+0900 D/TIMER   (14318): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-27 20:35:18.884+0900 I/efl-extension(14318): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-27 20:35:18.884+0900 I/efl-extension(14318): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44105358, elm_layout, _activated_obj : 0x0, activated : 1
05-27 20:35:18.894+0900 I/efl-extension(14318): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x45c211a8]'s widget[0x45c1b528] to layout widget[0x45c15b38]
05-27 20:35:18.899+0900 I/efl-extension(14318): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x45c211a8 = w: 0 h: 0  obj 0x45c1b528 w: 360 h: 360
05-27 20:35:18.899+0900 I/efl-extension(14318): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-27 20:35:19.629+0900 E/EFL     (14318): evas_main<14318> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5145628 button=1 downs=1
05-27 20:35:19.699+0900 E/EFL     (14318): evas_main<14318> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5145701 button=1 downs=0
05-27 20:35:20.059+0900 I/efl-extension(14318): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:35:20.059+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:35:20.064+0900 I/efl-extension(14318): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105358, elm_layout, time_stamp : 5146062
05-27 20:35:20.064+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:35:20.839+0900 E/EFL     (14318): evas_main<14318> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5146838 button=1 downs=1
05-27 20:35:20.889+0900 E/EFL     (14318): evas_main<14318> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5146892 button=1 downs=0
05-27 20:35:20.894+0900 D/TIMER   (14318): Setting time is 60
05-27 20:35:20.979+0900 I/SOCKETTEST(14318): Success to create socket
05-27 20:35:20.984+0900 I/SOCKETTEST(14318): Success to socket connection
05-27 20:35:20.984+0900 I/SOCKETTEST(14318): write() 성공
05-27 20:35:21.074+0900 W/WG-CONSUMER(13058): [34m[F:consumer-app.cpp L:  303][_HIGH]Checking consumer's state.[0m
05-27 20:35:21.074+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  332][_HIGH]Not BT/WFD connected. Cur type=16[0m
05-27 20:35:21.079+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  172][_HIGH]Device dis-connected. WMS=1 BT=0 [0m
05-27 20:35:21.079+0900 I/SENSOR  (14318): 2.870000, -0.210000, 3.290000
05-27 20:35:21.079+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  113][_HIGH]SAP is not conneced.[0m
05-27 20:35:21.079+0900 W/WG-CONSUMER(13058): [34m[F:consumer-app.cpp L:  312][_HIGH]Transfer can be exit[0m
05-27 20:35:21.079+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  332][_HIGH]Not BT/WFD connected. Cur type=16[0m
05-27 20:35:21.079+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  172][_HIGH]Device dis-connected. WMS=1 BT=0 [0m
05-27 20:35:21.079+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  113][_HIGH]SAP is not conneced.[0m
05-27 20:35:21.079+0900 W/WG-CONSUMER(13058): [34m[F:consumer-app.cpp L:  317][_HIGH]Receiver can be exit[0m
05-27 20:35:21.079+0900 W/WG-CONSUMER(13058): [34m[F:consumer-app.cpp L:  320][_HIGH]Exit Condition. Tx=1 Rx=1[0m
05-27 20:35:21.079+0900 I/CAPI_APPFW_APPLICATION(13058): service_app_main.c: service_app_exit(441) > service_app_exit
05-27 20:35:21.084+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 20:35:21.084+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 20:35:21.084+0900 W/WG-CONSUMER(13058): [34m[F:consumer-app.cpp L:  165][_HIGH]Gallery consumer SVC is terminated[0m
05-27 20:35:21.084+0900 W/WG-CONSUMER(13058): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
05-27 20:35:21.084+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
05-27 20:35:21.084+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0x42e77878) Disconnect(155)[0m
05-27 20:35:21.084+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
05-27 20:35:21.084+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
05-27 20:35:21.084+0900 W/WG-CONSUMER(13058): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
05-27 20:35:21.084+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
05-27 20:35:21.124+0900 W/WG-CONSUMER(13058): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
05-27 20:35:21.124+0900 W/WG-CONSUMER(13058): [34m[F:ReceiverCtrl.cpp L:  502][_HIGH][RX]Disconnect to Peer[0m
05-27 20:35:21.129+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
05-27 20:35:21.129+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e78928) Disconnect(155)[0m
05-27 20:35:21.129+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
05-27 20:35:21.129+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
05-27 20:35:21.129+0900 W/WG-CONSUMER(13058): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
05-27 20:35:21.129+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
05-27 20:35:21.134+0900 I/CAPI_CONTENT_MEDIA_CONTENT(13058): media_content.c: media_content_disconnect(948) > [32m[13058]ref count changed to: 0
05-27 20:35:21.179+0900 I/SENSOR  (14318): 2.940000, -0.770000, 4.550000
05-27 20:35:21.244+0900 E/WG-CONSUMER(13058): [31m[F:consumer-app.cpp L:  389][ERROR]Terminate main. nRet=0[0m
05-27 20:35:21.244+0900 W/WG-CONSUMER(13058): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
05-27 20:35:21.244+0900 W/WG-CONSUMER(13058): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e789d4)[0m
05-27 20:35:21.244+0900 W/WG-CONSUMER(13058): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
05-27 20:35:21.249+0900 W/WG-CONSUMER(13058): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
05-27 20:35:21.249+0900 W/WG-CONSUMER(13058): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e76844)[0m
05-27 20:35:21.279+0900 I/SENSOR  (14318): 2.730000, -0.560000, 3.430000
05-27 20:35:21.379+0900 I/SENSOR  (14318): 2.660000, 0.140000, 3.080000
05-27 20:35:21.484+0900 I/SENSOR  (14318): 2.730000, -0.140000, 3.920000
05-27 20:35:21.544+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 23
05-27 20:35:21.549+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
05-27 20:35:21.549+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 13058
05-27 20:35:21.549+0900 W/AUL_AMD (  492): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-27 20:35:21.579+0900 I/SENSOR  (14318): 3.080000, -0.280000, 3.640000
05-27 20:35:21.599+0900 I/AUL_AMD (  492): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13058
05-27 20:35:21.684+0900 I/SENSOR  (14318): 2.660000, -0.420000, 1.960000
05-27 20:35:21.784+0900 I/SENSOR  (14318): 3.010000, -0.910000, 4.690000
05-27 20:35:21.884+0900 I/SENSOR  (14318): 2.730000, -1.260000, 5.320000
05-27 20:35:21.984+0900 I/SENSOR  (14318): 2.450000, -0.280000, 5.740000
05-27 20:35:22.119+0900 I/SENSOR  (14318): 3.710000, -0.070000, 0.840000
05-27 20:35:22.179+0900 I/SENSOR  (14318): 2.380000, 0.210000, 1.890000
05-27 20:35:22.279+0900 I/SENSOR  (14318): 2.520000, 0.210000, 8.050000
05-27 20:35:22.379+0900 I/SENSOR  (14318): 3.290000, -0.420000, 1.890000
05-27 20:35:22.489+0900 I/SENSOR  (14318): 2.800000, -1.750000, 2.730000
05-27 20:35:22.584+0900 I/SENSOR  (14318): 2.800000, -1.120000, 3.360000
05-27 20:35:22.679+0900 I/SENSOR  (14318): 2.870000, -0.420000, 5.250000
05-27 20:35:22.784+0900 I/SENSOR  (14318): 2.660000, 0.350000, 3.220000
05-27 20:35:22.884+0900 I/SENSOR  (14318): 3.220000, -0.490000, 3.220000
05-27 20:35:22.984+0900 I/SENSOR  (14318): 3.220000, -0.350000, 3.990000
05-27 20:35:23.084+0900 W/AUL_AMD (  492): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-27 20:35:23.114+0900 I/SENSOR  (14318): 3.080000, 0.140000, 3.010000
05-27 20:35:23.179+0900 I/SENSOR  (14318): 2.870000, 0.490000, 3.220000
05-27 20:35:23.279+0900 I/SENSOR  (14318): 2.870000, 0.140000, 3.290000
05-27 20:35:23.389+0900 I/SENSOR  (14318): 2.940000, -1.050000, 4.130000
05-27 20:35:23.489+0900 I/SENSOR  (14318): 2.660000, -1.050000, 2.240000
05-27 20:35:23.584+0900 I/SENSOR  (14318): 2.590000, -0.770000, 5.810000
05-27 20:35:23.694+0900 I/SENSOR  (14318): 2.800000, -0.560000, 3.010000
05-27 20:35:23.784+0900 I/SENSOR  (14318): 2.590000, -1.330000, 5.180000
05-27 20:35:23.884+0900 I/SENSOR  (14318): 3.010000, -0.070000, 3.430000
05-27 20:35:23.984+0900 I/SENSOR  (14318): 3.010000, -0.420000, 3.570000
05-27 20:35:24.094+0900 I/SENSOR  (14318): 3.080000, -0.420000, 3.430000
05-27 20:35:24.179+0900 I/SENSOR  (14318): 2.940000, -0.420000, 4.830000
05-27 20:35:24.284+0900 I/SENSOR  (14318): 2.660000, 0.140000, 2.240000
05-27 20:35:24.389+0900 I/SENSOR  (14318): 2.800000, -0.700000, 4.410000
05-27 20:35:24.489+0900 I/SENSOR  (14318): 3.010000, -0.700000, 1.610000
05-27 20:35:24.584+0900 I/SENSOR  (14318): 2.800000, -0.280000, 5.110000
05-27 20:35:24.684+0900 I/SENSOR  (14318): 2.940000, -0.210000, 3.920000
05-27 20:35:24.784+0900 I/SENSOR  (14318): 2.940000, -0.560000, 3.710000
05-27 20:35:24.884+0900 I/SENSOR  (14318): 2.870000, -0.140000, 3.920000
05-27 20:35:24.984+0900 I/SENSOR  (14318): 2.870000, -0.070000, 3.290000
05-27 20:35:25.099+0900 I/SENSOR  (14318): 2.940000, -0.070000, 4.130000
05-27 20:35:25.179+0900 I/SENSOR  (14318): 3.150000, -0.070000, 3.990000
05-27 20:35:25.279+0900 I/SENSOR  (14318): 3.010000, -0.770000, 4.200000
05-27 20:35:25.299+0900 E/EFL     (14318): evas_main<14318> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5151297 button=1 downs=1
05-27 20:35:25.379+0900 I/SENSOR  (14318): 3.430000, -0.560000, 4.900000
05-27 20:35:25.434+0900 E/EFL     (14318): evas_main<14318> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5151434 button=1 downs=0
05-27 20:35:25.434+0900 I/efl-extension(14318): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:35:25.434+0900 I/efl-extension(14318): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44105358, elm_layout, func : 0x414608d9
05-27 20:35:25.434+0900 I/efl-extension(14318): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 20:35:25.434+0900 I/efl-extension(14318): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 20:35:25.434+0900 I/efl-extension(14318): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:35:25.434+0900 I/efl-extension(14318): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 20:35:25.434+0900 I/efl-extension(14318): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 20:35:25.434+0900 I/efl-extension(14318): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 20:35:25.454+0900 I/SOCKETTEST(14318): Success to create socket
05-27 20:35:25.454+0900 I/SOCKETTEST(14318): Success to socket connection
05-27 20:35:25.459+0900 I/SOCKETTEST(14318): write() 성공
05-27 20:35:25.464+0900 I/TimeRecord(14318): String_ time : 4
05-27 20:35:25.464+0900 I/TimeRecord(14318): Preference_ time : ظD
05-27 20:35:25.464+0900 I/TimeRecord(14318): time : 4
05-27 20:35:25.914+0900 I/efl-extension(14318): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44105358
05-27 20:35:25.914+0900 I/efl-extension(14318): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44105358, obj: 0x44105358
05-27 20:35:25.914+0900 I/efl-extension(14318): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 20:35:35.879+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 20:35:35.884+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 20:35:35.884+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:35:35.899+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:35:35.899+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:35:35.914+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 20:35:35.979+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 20:35:35.994+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-27 20:35:35.994+0900 W/W_HOME  (  732): dbox.c: _dbus_rotation_cb(1302) > invalid angle, skipped:0
05-27 20:35:36.009+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 20:35:36.009+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 20:35:36.049+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(72) > [_charging_ui_update:72] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
05-27 20:35:36.054+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 50 -> 50 1464348936 110
05-27 20:35:36.059+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 50 102 93 85
05-27 20:35:36.059+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 50 0 0 0
05-27 20:35:36.059+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 50 111 41 93
05-27 20:35:36.059+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 50 113 5 94
05-27 20:35:36.059+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 50 114 30 95
05-27 20:35:36.099+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 50 1046 395 872
05-27 20:35:36.099+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 50 0 0 1341
05-27 20:35:36.099+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 50 873 273 728
05-27 20:35:36.099+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 50 2120 5 1767
05-27 20:35:36.099+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 50 0 0 0
05-27 20:35:36.124+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-27 20:35:36.124+0900 W/W_HOME  (  732): dbox.c: _dbus_rotation_cb(1299) > angle changed:0
05-27 20:35:36.159+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(81) > [_charging_ui_update:81] [HIDE charging icon] Not connected or Battery full (5)
05-27 20:35:36.169+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(72) > [_charging_ui_update:72] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
05-27 20:35:36.169+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(81) > [_charging_ui_update:81] [HIDE charging icon] Not connected or Battery full (5)
05-27 20:35:36.169+0900 W/W_INDICATOR(  717): windicator_battery.c: _battery_charger_status_changed_cb(165) > [_battery_charger_status_changed_cb:165] Show Moment View to display TA status(unconnected)
05-27 20:35:36.174+0900 E/W_INDICATOR(  717): windicator_moment_view.c: windicator_moment_view_show(578) > [windicator_moment_view_show:578] Show Moment View : dynamic_layout(0x446a4960), type(1)
05-27 20:35:36.174+0900 W/W_INDICATOR(  717): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(155) > [wnidicator_moment_view_battery_image_update:155] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
05-27 20:35:36.174+0900 W/W_INDICATOR(  717): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(164) > [wnidicator_moment_view_battery_image_update:164] [HIDE charging icon] Not connected or Battery full (5)
05-27 20:35:36.179+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x0200000d)
05-27 20:35:36.209+0900 W/APP_CORE(  717): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000d
05-27 20:35:36.319+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: RESUME State: PAUSED
05-27 20:35:36.319+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 20:35:37.574+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-27 20:35:37.574+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-27 20:35:37.574+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-27 20:35:37.574+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-27 20:35:37.684+0900 W/STARTER (  711): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-27 20:35:37.749+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-27 20:35:37.749+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-27 20:35:37.749+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-27 20:35:37.749+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-27 20:35:37.864+0900 W/STARTER (  711): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-27 20:35:38.119+0900 W/STARTER (  711): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-27 20:35:38.124+0900 W/STARTER (  711): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-27 20:35:38.169+0900 E/STARTER (  711): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-27 20:35:38.174+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 0
05-27 20:35:38.184+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 711
05-27 20:35:38.189+0900 E/W_INDICATOR(  717): windicator_moment_view.c: windicator_moment_view_hide(634) > [windicator_moment_view_hide:634] Hide Moment View : dynamic_layout(0x446a4960),Type(1)
05-27 20:35:38.189+0900 E/W_INDICATOR(  717): windicator_connection.c: windi_connection_pause(1552) > [windi_connection_pause:1552] There is no handle
05-27 20:35:38.189+0900 E/W_INDICATOR(  717): windicator_util.c: windi_x_input_event_unregister(223) > [windi_x_input_event_unregister:223] not registered
05-27 20:35:38.214+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(2080) > pad pid(-5)
05-27 20:35:38.214+0900 W/AUL_PAD ( 1171): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-27 20:35:38.214+0900 W/AUL_PAD ( 1171): launchpad.c: __send_result_to_caller(272) > Check app launching
05-27 20:35:38.244+0900 E/RESOURCED(  493): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-27 20:35:38.264+0900 I/CAPI_APPFW_APPLICATION(14174): app_main.c: app_efl_main(129) > app_efl_main
05-27 20:35:38.269+0900 W/APP_CORE(  717): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000d
05-27 20:35:38.269+0900 I/CAPI_APPFW_APPLICATION(14174): app_main.c: app_appcore_create(152) > app_appcore_create
05-27 20:35:38.284+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
05-27 20:35:38.284+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 20:35:38.319+0900 E/AUL     (  711): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 20:35:38.324+0900 E/RESOURCED(  493): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-27 20:35:38.449+0900 I/efl-extension(14174): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445d8168 = w: 0 h: 0  obj 0x445bf0b0 w: 360 h: 360
05-27 20:35:38.449+0900 I/efl-extension(14174): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-27 20:35:38.454+0900 I/efl-extension(14174): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-27 20:35:38.454+0900 I/efl-extension(14174): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-27 20:35:38.459+0900 I/efl-extension(14174): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-27 20:35:38.459+0900 I/efl-extension(14174): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-27 20:35:38.464+0900 I/efl-extension(14174): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445bf0b0, elm_image, _activated_obj : 0x0, activated : 1
05-27 20:35:38.564+0900 E/W_TASKMANAGER(14174): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-27 20:35:38.569+0900 E/W_TASKMANAGER(14174): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-27 20:35:38.569+0900 E/W_TASKMANAGER(14174): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-27 20:35:38.614+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.619+0900 E/W_TASKMANAGER(14174): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 20:35:38.624+0900 E/RUA     (14174): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 17, ncols : 5
05-27 20:35:38.669+0900 E/EFL     (14174): elementary<14174> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c0d30 into part 'elm.swallow.event.0'
05-27 20:35:38.709+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04000003)
05-27 20:35:38.719+0900 I/APP_CORE(14174): appcore-efl.c: __do_app(429) > [APP 14174] Event: RESET State: CREATED
05-27 20:35:38.719+0900 I/CAPI_APPFW_APPLICATION(14174): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-27 20:35:38.739+0900 I/APP_CORE(14174): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-27 20:35:38.739+0900 I/APP_CORE(14174): appcore-efl.c: __do_app(474) > [APP 14174] Initial Launching, call the resume_cb
05-27 20:35:38.739+0900 I/CAPI_APPFW_APPLICATION(14174): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 20:35:38.774+0900 W/APP_CORE(14174): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000003
05-27 20:35:38.774+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04000003)
05-27 20:35:38.849+0900 I/APP_CORE(14318): appcore-efl.c: __do_app(429) > [APP 14318] Event: PAUSE State: RUNNING
05-27 20:35:38.849+0900 I/CAPI_APPFW_APPLICATION(14318): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-27 20:35:38.864+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 20:35:38.869+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 20:35:38.869+0900 I/APP_CORE(14174): appcore-efl.c: __do_app(429) > [APP 14174] Event: RESUME State: RUNNING
05-27 20:35:39.254+0900 E/AUL     (  492): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 20:35:39.294+0900 I/MALI    (14174): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-27 20:35:39.419+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:35:39.439+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14174
05-27 20:35:39.444+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:35:39.464+0900 E/EFL     (14174): evas_main<14174> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5165458 button=1 downs=1
05-27 20:35:39.494+0900 E/EFL     (14174): evas_main<14174> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5165496 button=1 downs=0
05-27 20:35:39.769+0900 E/EFL     (14174): elementary<14174> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573cd0), freeze(1)
05-27 20:35:39.769+0900 E/EFL     (14174): elementary<14174> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573cd0), freeze(1)
05-27 20:35:39.864+0900 I/efl-extension(14457): efl_extension.c: eext_mod_init(40) > Init
05-27 20:35:39.909+0900 I/UXT     (14457): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-27 20:35:40.019+0900 I/AUL_PAD (14457): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-27 20:35:40.054+0900 E/TBM     (14457): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-27 20:35:40.144+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:35:40.154+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11594
05-27 20:35:40.154+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 27
05-27 20:35:40.164+0900 I/APP_CORE(11594): appcore-efl.c: __do_app(429) > [APP 11594] Event: TERMINATE State: PAUSED
05-27 20:35:40.169+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 20:35:40.169+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 20:35:40.174+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:35:40.184+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14318
05-27 20:35:40.184+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 27
05-27 20:35:40.189+0900 I/APP_CORE(14318): appcore-efl.c: __do_app(429) > [APP 14318] Event: TERMINATE State: PAUSED
05-27 20:35:40.194+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 20:35:40.194+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 20:35:40.204+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 20:35:40.204+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 20:35:40.209+0900 E/APP_CORE(14174): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-27 20:35:40.209+0900 I/APP_CORE(14174): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 20:35:40.209+0900 I/APP_CORE(14174): appcore-efl.c: __after_loop(1090) > [APP 14174] PAUSE before termination
05-27 20:35:40.209+0900 I/CAPI_APPFW_APPLICATION(14174): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 20:35:40.209+0900 I/CAPI_APPFW_APPLICATION(14174): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-27 20:35:40.209+0900 I/efl-extension(14174): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44573cd0, obj: 0x44573cd0
05-27 20:35:40.214+0900 I/efl-extension(14174): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 20:35:40.214+0900 I/efl-extension(14174): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 20:35:40.214+0900 I/efl-extension(14174): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 20:35:40.214+0900 I/efl-extension(14174): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 20:35:40.224+0900 I/efl-extension(14174): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445bf0b0
05-27 20:35:40.224+0900 I/efl-extension(14174): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 20:35:40.224+0900 I/efl-extension(14174): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445d8168 is freed
05-27 20:35:40.224+0900 I/efl-extension(14174): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:35:40.224+0900 I/efl-extension(14174): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44573cd0, elm_scroller, func : 0x437c8ef1
05-27 20:35:40.229+0900 I/efl-extension(14174): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:35:40.229+0900 I/efl-extension(14174): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:35:40.229+0900 I/efl-extension(14174): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445bf0b0, elm_image, func : 0x437c8ef1
05-27 20:35:40.229+0900 I/efl-extension(14174): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:35:40.229+0900 I/efl-extension(14174): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44573cd0 : elm_scroller] rotary callabck is deleted
05-27 20:35:40.294+0900 E/APP_CORE(11594): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-27 20:35:40.294+0900 I/APP_CORE(11594): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 20:35:40.294+0900 I/CAPI_APPFW_APPLICATION(11594): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-27 20:35:40.324+0900 I/APP_CORE(14318): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 20:35:40.324+0900 I/CAPI_APPFW_APPLICATION(14318): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 20:35:40.339+0900 I/efl-extension(14318): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 20:35:40.344+0900 I/efl-extension(14318): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x454162b8 is freed
05-27 20:35:40.344+0900 I/efl-extension(14318): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45496f90 is freed
05-27 20:35:40.344+0900 I/efl-extension(14318): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45c211a8 is freed
05-27 20:35:40.344+0900 I/efl-extension(14318): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x441474d0 is freed
05-27 20:35:40.354+0900 I/efl-extension(11594): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 20:35:40.354+0900 I/efl-extension(11594): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x45407478], circle_obj[0x454257c0]!
05-27 20:35:40.354+0900 I/efl-extension(11594): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44581a98 = w: 0 h: 0  obj 0x45407478 w: 360 h: 360
05-27 20:35:40.359+0900 I/efl-extension(11594): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-27 20:35:40.364+0900 I/efl-extension(11594): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445e9998 is freed
05-27 20:35:40.364+0900 I/efl-extension(11594): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x455a7310 is freed
05-27 20:35:40.364+0900 I/efl-extension(11594): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44567e28 is freed
05-27 20:35:40.364+0900 I/efl-extension(11594): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44549a40 is freed
05-27 20:35:40.364+0900 I/efl-extension(11594): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44543988, obj: 0x44543988
05-27 20:35:40.364+0900 I/efl-extension(11594): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 20:35:40.364+0900 I/efl-extension(11594): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 20:35:40.364+0900 I/efl-extension(11594): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 20:35:40.364+0900 I/efl-extension(11594): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 20:35:40.369+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-27 20:35:40.374+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-27 20:35:40.374+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 20:35:40.374+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:35:40.374+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:35:40.374+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:35:40.399+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 20:35:40.399+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 20:35:40.419+0900 I/efl-extension(11594): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 20:35:40.424+0900 I/efl-extension(11594): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44581a98 is freed
05-27 20:35:40.424+0900 I/efl-extension(11594): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x45407478
05-27 20:35:40.434+0900 I/efl-extension(11594): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:35:40.434+0900 I/efl-extension(11594): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44543988, elm_genlist, func : 0x437eddfd
05-27 20:35:40.434+0900 I/efl-extension(11594): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:35:40.464+0900 I/MALI    (14174): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-27 20:35:40.524+0900 I/MALI    (14174): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-27 20:35:40.524+0900 I/MALI    (14174): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=14174   close drm_fd=21 
05-27 20:35:40.529+0900 I/MALI    (14174): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-27 20:35:40.539+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 20:35:40.539+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:35:40.539+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:35:40.539+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:35:40.539+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 20:35:40.539+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 20:35:40.539+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 20:35:40.539+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:35:40.539+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 20:35:40.544+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-27 20:35:40.544+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 20:35:40.544+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-27 20:35:40.544+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-27 20:35:40.544+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:35:40.544+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:35:40.544+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:35:40.544+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 20:35:40.544+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x45d4d480
05-27 20:35:40.544+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d4d480, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 20:35:40.544+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:35:40.544+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 20:35:40.544+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:35:40.544+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 20:35:40.544+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:35:40.544+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:35:40.544+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:35:40.544+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:35:40.569+0900 I/MALI    (11594): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-27 20:35:40.569+0900 I/MALI    (11594): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=11594   close drm_fd=22 
05-27 20:35:40.569+0900 I/MALI    (11594): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-27 20:35:40.589+0900 I/UXT     (14318): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 20:35:40.624+0900 I/UXT     (14174): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 20:35:40.659+0900 I/UXT     (11594): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 20:35:40.874+0900 I/efl-extension(14174): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-27 20:35:40.899+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 20:35:40.934+0900 I/efl-extension(11594): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-27 20:35:41.064+0900 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-27 20:35:41.069+0900 E/EFL     (  732): evas_main<732> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5167067 button=1 downs=1
05-27 20:35:41.069+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [183, 194]
05-27 20:35:41.119+0900 E/EFL     (  732): evas_main<732> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5167088 button=1 downs=0
05-27 20:35:41.119+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [183, 194]->[184, 194]
05-27 20:35:41.124+0900 W/APPS    (  732): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-27 20:35:41.134+0900 E/APPS    (  732): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-27 20:35:41.134+0900 W/APPS    (  732): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-27 20:35:41.134+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 0
05-27 20:35:41.134+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 732
05-27 20:35:41.134+0900 I/AUL_AMD (  492): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-27 20:35:41.219+0900 E/RESOURCED(  493): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-27 20:35:41.219+0900 E/RESOURCED(  493): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-27 20:35:41.254+0900 E/WMS     (  488): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-27 20:35:41.254+0900 E/WMS     (  488): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-27 20:35:41.254+0900 E/WMS     (  488): ==========
05-27 20:35:41.254+0900 E/WMS     (  488): ##WMS SEND : mgr_gear_wear_onoff_req
05-27 20:35:41.254+0900 E/WMS     (  488): ==========
05-27 20:35:41.254+0900 E/WMS     (  488): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-27 20:35:41.259+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(2080) > pad pid(-5)
05-27 20:35:41.264+0900 W/AUL_PAD ( 1171): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-27 20:35:41.264+0900 W/AUL_PAD ( 1171): launchpad.c: __send_result_to_caller(272) > Check app launching
05-27 20:35:41.274+0900 W/SCSD    ( 4809): <util_sms_send:223> Send message('nc-rq') to [SAP_BAEBD3336BC039746928BD8DC2E133B7 / 39kc4o8c10] peer
05-27 20:35:41.284+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: sms_e - Call TargetInstanceID( 39kc4o8c10 ), SMS_Size( 5 )
05-27 20:35:41.284+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: send_msg - ( 0x34 ), type( 0x01 ), res( 232 ), seq( 1010 )
05-27 20:35:41.284+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Call()
05-27 20:35:41.284+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Res( 0 )
05-27 20:35:41.289+0900 W/SNL_W   ( 4809): <presSendNotify_i:994> presSendNotify_w ( 3532130a434bf7f1bd119f41 ) - begin
05-27 20:35:41.289+0900 W/SNL_W   ( 4809): <presSendNotify_i:999> presSendNotify_w ( 3532130a434bf7f1bd119f41 ) - Interrupt (Not SKA)
05-27 20:35:41.289+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Call()
05-27 20:35:41.289+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Res( 0 )
05-27 20:35:41.289+0900 W/SNL_W   ( 4809): <releaseAlarm:493> stop alarm_id(1161054382)
05-27 20:35:41.319+0900 I/efl-extension(14357): efl_extension.c: eext_mod_init(40) > Init
05-27 20:35:41.319+0900 I/UXT     (14357): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-27 20:35:41.324+0900 W/CRASH_MANAGER(14463): worker.c: worker_job(1199) > 1114318706831146434894
