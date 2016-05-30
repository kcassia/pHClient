S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 7736
Date: 2016-05-26 22:03:26+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7736, uid 5000)

Register Information
r0   = 0x414631d8, r1   = 0x414631e2
r2   = 0x00000031, r3   = 0xbed4b06a
r4   = 0x0000000a, r5   = 0xbed4b120
r6   = 0xbed4b06a, r7   = 0x0000000a
r8   = 0x0000000a, r9   = 0x4142dec0
r10  = 0x414632c2, fp   = 0xbed4b114
ip   = 0xbed4b074, sp   = 0xbed4ab98
lr   = 0x404b5be8, pc   = 0x404dcbb8
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     19056 KB
Buffers:     27412 KB
Cached:     167500 KB
VmPeak:      94520 KB
VmSize:      92484 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22260 KB
VmRSS:       22256 KB
VmData:      33148 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25096 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7736 TID = 7736
7736 7800 

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
4175c000 41767000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41771000 41779000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.2.5
41781000 4178e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41796000 4179b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
417a3000 417a7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417b0000 417d1000 r-xp /usr/lib/libefl-extension.so.0.1.0
417d9000 417f0000 r-xp /usr/lib/libnetwork.so.0.0.0
417f8000 417fd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41805000 41823000 r-xp /usr/lib/libsensor.so.1.1.0
4182d000 4183f000 r-xp /usr/lib/libefl-assist.so.0.1.0
41847000 41878000 r-xp /usr/lib/libmdm.so.1.1.85
41880000 41887000 r-xp /usr/lib/libsensord-share.so
4188f000 418a1000 r-xp /usr/lib/libtts.so
418a9000 418b0000 r-xp /usr/lib/libtbm.so.1.0.0
418b8000 418c6000 r-xp /usr/lib/libGLESv2.so.2.0
418cf000 418d1000 rw-p [heap]
418d1000 41a03000 rw-p [heap]
41a03000 41abb000 r-xp /usr/lib/libcairo.so.2.11200.14
41ac6000 41ae7000 r-xp /usr/lib/libui-extension.so.0.1.0
41af0000 41af1000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41afa000 41b00000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b08000 41b0b000 r-xp /usr/lib/libEGL.so.1.4
41b13000 41b1b000 r-xp /usr/lib/libmdm-common.so.1.0.89
41b1c000 41c59000 r-xp /usr/lib/libicui18n.so.51.1
41c69000 41d4d000 r-xp /usr/lib/libicuuc.so.51.1
41d62000 41d65000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41d6d000 41d75000 r-xp /usr/lib/libdrm.so.2.4.0
43304000 43309000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43312000 43317000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4331f000 43321000 r-xp /usr/lib/libdri2.so.0.0.0
43329000 4334a000 r-xp /usr/lib/libexif.so.12.3.3
4335d000 43362000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4336a000 43434000 r-xp /usr/lib/libCOREGL.so.4.0
43777000 43782000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4378b000 4378f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43797000 437ae000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
438bb000 438bd000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44a60000 4525f000 rwxp [stack:7800]
452e5000 452e6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
452ee000 452ef000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4530c000 45313000 r-xp /usr/lib/libfeedback.so.0.1.4
4531c000 4531d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45325000 45327000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
4532f000 45339000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
45341000 45348000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45350000 45366000 r-xp /usr/lib/libmmfsound.so.0.1.0
45378000 4537d000 r-xp /usr/lib/libmmfsession.so.0.0.0
45385000 4538f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4539b000 4539f000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
453a8000 453be000 r-xp /usr/lib/libavsysaudio.so.0.0.1
453c7000 453cc000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
453d4000 453d7000 r-xp /usr/lib/libpulse-simple.so.0.0.4
453df000 45440000 r-xp /usr/lib/libasound.so.2.0.0
4544a000 4544d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45455000 45458000 r-xp /usr/lib/libcompress.so.0.2.0
4586e000 458a6000 r-xp /usr/lib/libpulse.so.0.16.2
458a7000 458b4000 r-xp /usr/lib/libail.so.0.1.0
458bd000 458cd000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
458ee000 458f6000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
45905000 4590a000 r-xp /usr/lib/libjson.so.0.0.1
45912000 4595a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4595b000 4599e000 r-xp /usr/lib/libsndfile.so.1.0.25
459ab000 459cd000 r-xp /usr/lib/libvorbis.so.0.4.3
459d5000 459d9000 r-xp /usr/lib/libogg.so.0.7.1
bed2b000 bed4c000 rwxp [stack]
End of Maps Information

Callstack Information (PID:7736)
Call Stack Count: 4
 0: _IO_default_xsputn + 0x50 (0x404dcbb8) [/lib/libc.so.6] + 0x67bb8
 1: _IO_vfprintf + 0x3d24 (0x404b5be8) [/lib/libc.so.6] + 0x40be8
 2: vsprintf + 0x64 (0x404d1944) [/lib/libc.so.6] + 0x5c944
 3: $d + 0x0 (0x414631d8) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x61d8
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
 return
05-26 22:03:15.816+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:03:15.816+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:03:15.821+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:15.821+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:15.826+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:15.826+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:03:15.826+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:03:15.826+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:15.826+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:03:15.826+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:03:15.826+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:03:15.826+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:15.831+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:03:15.831+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:03:15.851+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:03:15.851+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:03:15.851+0900 E/weather-widget(  801): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1574) > [0;40;31mUpdateWidgetInstanceTimerCb[0;m
05-26 22:03:15.866+0900 E/weather-widget(  801): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1615) > [0;40;31mcontent is NULL[0;m
05-26 22:03:15.881+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:03:15.881+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:03:15.891+0900 E/weather-widget(  801): WidgetView.cpp: UpdateViewPage(299) > [0;40;31mUpdateViewPage locationId : 4111000000[0;m
05-26 22:03:15.901+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 22:03:15.901+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93c20 : elm_scroller] CurrentPage(2)
05-26 22:03:15.981+0900 E/weather-widget(  801): WidgetView.cpp: SetBackgroundImage(155) > [0;40;31mbackground color code:AO098[0;m
05-26 22:03:15.986+0900 E/weather-widget(  801): WidgetView.cpp: SetBackgroundImage(165) > [0;40;31mbackground image color code:AO0953[0;m
05-26 22:03:15.996+0900 W/LOCATION(  801): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
05-26 22:03:15.996+0900 E/weather-common(  801): Location.cpp: IsLocationServiceAvailable(297) > [0;40;31menabled : 0[0;m
05-26 22:03:15.996+0900 E/weather-widget(  801): WidgetMain.cpp: CheckAndRequestAutoRefresh(1151) > [0;40;31m[CheckAndRequestAutoRefresh(): 1151] (locationPtr->IsLocationServiceAvailable() == false) [break][0;m
05-26 22:03:16.001+0900 E/EFL     (  801): edje<801> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'timeSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 22:03:16.011+0900 E/EFL     (  801): edje<801> edje_util.c:3770 edje_object_size_min_restricted_calc() group highLowTemperature has a non-fixed part 'low'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 22:03:16.021+0900 E/EFL     (  801): edje<801> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'weatherIconSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 22:03:16.036+0900 W/W_HOME  (  737): event_manager.c: _home_scroll_cb(564) > scroll,done
05-26 22:03:16.046+0900 E/weather-widget(  801): WidgetMain.cpp: PauseWidgetInstance(1395) > [0;40;31mPauseWidgetInstance[0;m
05-26 22:03:16.056+0900 E/weather-widget(  801): WidgetView.cpp: HideActivityIndicator(753) > [0;40;31m[HideActivityIndicator(): 753] (refreshButtonLayout == NULL) [return][0;m
05-26 22:03:16.056+0900 E/weather-widget(  801): WidgetView.cpp: Pause(1739) > [0;40;31mOnClosed[0;m
05-26 22:03:16.056+0900 E/weather-widget(  801): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-26 22:03:16.066+0900 E/weather-widget(  801): WidgetMain.cpp: PauseWidgetInstance(1436) > [0;40;31mlocationID : 4111000000[0;m
05-26 22:03:16.066+0900 I/CAPI_WIDGET_APPLICATION(  801): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-26 22:03:16.076+0900 I/CAPI_WIDGET_APPLICATION(  801): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-26 22:03:16.406+0900 W/W_HOME  (  737): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-26 22:03:16.571+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:03:16.571+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(150) ev->cur.canvas.y(81)
05-26 22:03:16.571+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:03:16.571+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1833619 button=1 downs=1
05-26 22:03:16.591+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:03:16.596+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(150) ev->cur.canvas.y(84)
05-26 22:03:16.596+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:03:16.611+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:03:16.611+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(154) ev->cur.canvas.y(90)
05-26 22:03:16.616+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:03:16.631+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1833663 button=1 downs=0
05-26 22:03:16.641+0900 E/EFL     (  797): evas_main<797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1833618 button=1 downs=1
05-26 22:03:16.641+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:03:16.646+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:03:16.646+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:03:16.661+0900 E/EFL     (  797): evas_main<797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1833686 button=1 downs=0
05-26 22:03:16.666+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:03:16.666+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 797
05-26 22:03:16.666+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:03:16.671+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 737
05-26 22:03:16.676+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESET State: RUNNING
05-26 22:03:16.676+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 22:03:16.676+0900 W/W_HOME  (  737): main.c: _app_control(1726) > Service value : launch_apps
05-26 22:03:16.676+0900 W/W_HOME  (  737): move.c: move_move_to_apps(216) > move to apps
05-26 22:03:16.676+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47740530
05-26 22:03:16.676+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47740530, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:03:16.676+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:03:16.676+0900 W/W_HOME  (  737): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-26 22:03:16.676+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:16.676+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:16.676+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(737), cmd(0)
05-26 22:03:16.686+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-26 22:03:16.686+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-26 22:03:16.686+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-26 22:03:16.686+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:16.686+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:16.686+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:16.686+0900 W/W_HOME  (  737): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
05-26 22:03:16.686+0900 W/W_HOME  (  737): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-26 22:03:16.686+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-26 22:03:16.686+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-26 22:03:16.966+0900 W/W_HOME  (  737): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-26 22:03:16.966+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:16.966+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47740530
05-26 22:03:16.966+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:03:16.966+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47740530, elm_layout, func : 0x4004b469
05-26 22:03:16.966+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:03:16.966+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:03:16.966+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:03:16.966+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47740530, activated : 1
05-26 22:03:16.966+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:03:16.971+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:03:16.971+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 34, 218.
05-26 22:03:16.971+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:03:16.971+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-26 22:03:16.976+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-26 22:03:16.976+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:03:16.976+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:03:16.976+0900 W/W_HOME  (  737): main.c: home_pause(751) > clock/widget paused
05-26 22:03:16.976+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:03:16.976+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:03:16.981+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 22:03:16.981+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:03:16.981+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:03:16.981+0900 W/W_HOME  (  737): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-26 22:03:16.981+0900 W/W_HOME  (  737): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-26 22:03:16.981+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-26 22:03:16.986+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:03:16.986+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_close_second_depth_view(5438) > wnotib_action_drawer_hidden_get(): 1, page_popup: 0x0
05-26 22:03:16.986+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4494) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:03:16.986+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:03:16.986+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_is_available(4795) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:03:16.986+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-26 22:03:16.986+0900 E/APPS    (  737): apps_main.c: apps_main_resume(621) >  resumed already
05-26 22:03:16.991+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:03:16.991+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:03:16.991+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:03:16.991+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:03:17.136+0900 W/W_HOME  (  737): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
05-26 22:03:17.221+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 22:03:17.221+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1834270 button=1 downs=1
05-26 22:03:17.221+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [149, 178]
05-26 22:03:17.291+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1834336 button=1 downs=0
05-26 22:03:17.291+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [149, 178]->[156, 187]
05-26 22:03:17.296+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-26 22:03:17.296+0900 E/APPS    (  737): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-26 22:03:17.296+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-26 22:03:17.301+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:03:17.301+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 737
05-26 22:03:17.301+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:03:17.316+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-26 22:03:17.316+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 22:03:17.316+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 22:03:17.321+0900 W/AUL_PAD ( 1155): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 22:03:17.321+0900 W/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 22:03:17.361+0900 I/efl-extension( 7736): efl_extension.c: eext_mod_init(40) > Init
05-26 22:03:17.361+0900 I/UXT     ( 7736): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 22:03:17.376+0900 I/CAPI_APPFW_APPLICATION( 7736): app_main.c: ui_app_main(704) > app_efl_main
05-26 22:03:17.381+0900 I/CAPI_APPFW_APPLICATION( 7736): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-26 22:03:17.426+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:03:17.436+0900 E/RESOURCED(  497): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-26 22:03:17.441+0900 E/TBM     ( 7736): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 22:03:17.571+0900 E/EFL     ( 7736): <7736> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-26 22:03:17.591+0900 E/EFL     ( 7736): <7736> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:03:17.591+0900 E/EFL     ( 7736): <7736> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:03:17.591+0900 E/EFL     ( 7736): <7736> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:03:17.611+0900 E/EFL     ( 7736): <7736> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:03:17.611+0900 E/EFL     ( 7736): <7736> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:03:17.696+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05c00002)
05-26 22:03:17.731+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 22:03:17.741+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:03:17.741+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:03:17.746+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:03:17.746+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 22:03:17.746+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:03:17.746+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:03:17.751+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 22:03:17.756+0900 I/APP_CORE( 7736): appcore-efl.c: __do_app(429) > [APP 7736] Event: RESET State: CREATED
05-26 22:03:17.756+0900 I/CAPI_APPFW_APPLICATION( 7736): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 22:03:17.806+0900 I/APP_CORE( 7736): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 22:03:17.806+0900 I/APP_CORE( 7736): appcore-efl.c: __do_app(474) > [APP 7736] Initial Launching, call the resume_cb
05-26 22:03:17.806+0900 I/CAPI_APPFW_APPLICATION( 7736): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 22:03:17.871+0900 W/APP_CORE( 7736): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
05-26 22:03:17.911+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:03:17.911+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 22:03:17.916+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 22:03:17.916+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 22:03:17.916+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:03:17.916+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 22:03:17.916+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 22:03:17.916+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:03:17.916+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 22:03:17.916+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 22:03:17.916+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:03:17.916+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:03:17.916+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:03:17.916+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 22:03:17.916+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:03:17.916+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 22:03:17.916+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:03:17.916+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:03:17.916+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:03:17.916+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 22:03:17.916+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:03:17.916+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:03:17.916+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 34, 218.
05-26 22:03:17.916+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:03:17.941+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:17.951+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:03:17.951+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:03:17.971+0900 I/APP_CORE( 7736): appcore-efl.c: __do_app(429) > [APP 7736] Event: RESUME State: RUNNING
05-26 22:03:17.986+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:03:18.031+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 22:03:18.031+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:03:18.041+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 22:03:18.056+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 22:03:18.301+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:03:18.441+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:03:18.451+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:03:18.461+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7736
05-26 22:03:18.701+0900 E/EFL     ( 7736): evas_main<7736> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1835750 button=1 downs=1
05-26 22:03:18.741+0900 I/AUL_PAD ( 7801): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 22:03:18.766+0900 E/EFL     ( 7736): evas_main<7736> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1835815 button=1 downs=0
05-26 22:03:19.361+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:03:19.376+0900 E/EFL     ( 7736): evas_main<7736> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1836423 button=1 downs=1
05-26 22:03:19.461+0900 E/EFL     ( 7736): evas_main<7736> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1836511 button=1 downs=0
05-26 22:03:19.736+0900 I/CAPI_NETWORK_CONNECTION( 7736): connection.c: connection_create(372) > New handle created[0x419eb700]
05-26 22:03:19.756+0900 I/SOCKETTEST( 7736): IP : 
05-26 22:03:19.756+0900 I/SOCKETTEST( 7736): Success to create UDP socket
05-26 22:03:19.756+0900 I/SOCKETTEST( 7736): Bind Success
05-26 22:03:19.756+0900 I/SOCKETTEST( 7736): Waiting DATA...
05-26 22:03:22.566+0900 I/SOCKETTEST( 7736): Receive Data : 192.168.0.47
05-26 22:03:22.566+0900 I/SOCKETTEST( 7736): Changed IP : 192.168.0.47
05-26 22:03:22.576+0900 I/SOCKETTEST( 7736): Success to create socket
05-26 22:03:22.581+0900 I/SOCKETTEST( 7736): Success to socket connection
05-26 22:03:22.581+0900 I/SOCKETTEST( 7736): write() 성공
05-26 22:03:22.946+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 30 -> 29 1464267802 150
05-26 22:03:22.951+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 29 1139 327 551
05-26 22:03:22.951+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 29 0 0 700
05-26 22:03:22.951+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 29 996 209 481
05-26 22:03:22.951+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 29 174 5 84
05-26 22:03:22.951+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 29 298 46 144
05-26 22:03:22.961+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:03:23.676+0900 E/EFL     ( 7736): evas_main<7736> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1840726 button=1 downs=1
05-26 22:03:23.751+0900 E/EFL     ( 7736): evas_main<7736> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1840803 button=1 downs=0
05-26 22:03:23.771+0900 D/TIMER   ( 7736): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:03:23.771+0900 D/TIMER   ( 7736): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:03:23.831+0900 I/efl-extension( 7736): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:03:23.831+0900 I/efl-extension( 7736): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:03:23.831+0900 I/efl-extension( 7736): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:03:23.831+0900 I/efl-extension( 7736): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:03:23.831+0900 I/efl-extension( 7736): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x43868f78, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:03:24.611+0900 E/EFL     ( 7736): evas_main<7736> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1841650 button=1 downs=1
05-26 22:03:24.661+0900 E/EFL     ( 7736): evas_main<7736> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1841709 button=1 downs=0
05-26 22:03:25.256+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.256+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.261+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.261+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842305
05-26 22:03:25.261+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.316+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.316+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.316+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.321+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842367
05-26 22:03:25.321+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.356+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.356+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.356+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.356+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842406
05-26 22:03:25.356+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.386+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.386+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.386+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.386+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842436
05-26 22:03:25.386+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.411+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.411+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.411+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.411+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842460
05-26 22:03:25.411+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.446+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.446+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.451+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.451+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842498
05-26 22:03:25.451+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.506+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.506+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.506+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.506+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842554
05-26 22:03:25.506+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.541+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.546+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.546+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.546+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842593
05-26 22:03:25.546+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.576+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.576+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.576+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.576+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842625
05-26 22:03:25.576+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.611+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.611+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.611+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.611+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842659
05-26 22:03:25.611+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.636+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.636+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.636+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.636+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842686
05-26 22:03:25.636+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.666+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.666+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.666+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.666+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842717
05-26 22:03:25.666+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.706+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.711+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.711+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.711+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842758
05-26 22:03:25.711+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.736+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.736+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.736+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.736+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842786
05-26 22:03:25.736+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.771+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.771+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.771+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.771+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842820
05-26 22:03:25.771+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:25.826+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.826+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.826+0900 I/efl-extension( 7736): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:25.826+0900 I/efl-extension( 7736): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x43868f78, elm_layout, time_stamp : 1842876
05-26 22:03:25.826+0900 E/TIMER   ( 7736): (ad->timer) -> _rotary_cb() return
05-26 22:03:26.301+0900 E/EFL     ( 7736): evas_main<7736> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1843347 button=1 downs=1
05-26 22:03:26.346+0900 E/EFL     ( 7736): evas_main<7736> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1843394 button=1 downs=0
05-26 22:03:26.346+0900 I/efl-extension( 7736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:03:26.346+0900 I/efl-extension( 7736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x43868f78, elm_layout, func : 0x414608e1
05-26 22:03:26.346+0900 I/efl-extension( 7736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:03:26.346+0900 I/efl-extension( 7736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:03:26.346+0900 I/efl-extension( 7736): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:03:26.346+0900 I/efl-extension( 7736): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:03:26.346+0900 I/efl-extension( 7736): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:03:26.346+0900 I/efl-extension( 7736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:03:26.346+0900 E/EFL     ( 7736): ecore<7736> ecore.c:574 _ecore_magic_fail() 
05-26 22:03:26.346+0900 E/EFL     ( 7736): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:03:26.346+0900 E/EFL     ( 7736): *** IN FUNCTION: ecore_timer_del()
05-26 22:03:26.346+0900 E/EFL     ( 7736): ecore<7736> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:03:26.346+0900 E/EFL     ( 7736):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:03:26.346+0900 E/EFL     ( 7736):     Supplied: 0049a1bd - <UNKNOWN>
05-26 22:03:26.346+0900 E/EFL     ( 7736): ecore<7736> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:03:26.346+0900 E/EFL     ( 7736): *** SPANK SPANK SPANK!!!
05-26 22:03:26.346+0900 E/EFL     ( 7736): *** Now go fix your code. Tut tut tut!
05-26 22:03:26.346+0900 I/SOCKETTEST( 7736): Success to create socket
05-26 22:03:26.466+0900 I/SOCKETTEST( 7736): Success to socket connection
05-26 22:03:26.471+0900 I/SOCKETTEST( 7736): write() 성공
05-26 22:03:26.686+0900 W/CRASH_MANAGER( 7778): worker.c: worker_job(1199) > 1107736706831146426780
