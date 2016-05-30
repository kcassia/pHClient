S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 11297
Date: 2016-05-26 22:24:57+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 11297, uid 5000)

Register Information
r0   = 0x702f6374, r1   = 0x00000025
r2   = 0xbed98224, r3   = 0x0000feff
r4   = 0x702f6370, r5   = 0x702f6374
r6   = 0xbed97cf0, r7   = 0x25252525
r8   = 0x00000000, r9   = 0x4142dec0
r10  = 0x702f6374, fp   = 0xbed97ce4
ip   = 0x702f6374, sp   = 0xbed97770
lr   = 0x404b1f5c, pc   = 0x404ec6dc
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     15876 KB
Buffers:     32356 KB
Cached:     164952 KB
VmPeak:      96908 KB
VmSize:      94872 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23504 KB
VmRSS:       23504 KB
VmData:      35536 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25096 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11297 TID = 11297
11297 11315 

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
44a00000 44a0a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
44a12000 44a28000 r-xp /usr/lib/libmmfsound.so.0.1.0
44a3a000 44a3f000 r-xp /usr/lib/libmmfsession.so.0.0.0
44a47000 44a51000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44a5d000 44a61000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44a6a000 44a80000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44a89000 44a8e000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
44a96000 44a99000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44aa1000 44ad9000 r-xp /usr/lib/libpulse.so.0.16.2
44ada000 44add000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44ae5000 44af2000 r-xp /usr/lib/libail.so.0.1.0
44afb000 44afe000 r-xp /usr/lib/libcompress.so.0.2.0
44c94000 45493000 rwxp [stack:11315]
4559e000 455ae000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
455cf000 455d7000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
455e6000 455eb000 r-xp /usr/lib/libjson.so.0.0.1
455f3000 455f7000 r-xp /usr/lib/libogg.so.0.7.1
4597d000 459de000 r-xp /usr/lib/libasound.so.2.0.0
459e8000 45a30000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a31000 45a74000 r-xp /usr/lib/libsndfile.so.1.0.25
45a81000 45aa3000 r-xp /usr/lib/libvorbis.so.0.4.3
bed78000 bed99000 rwxp [stack]
End of Maps Information

Callstack Information (PID:11297)
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
 is null
05-26 22:24:45.126+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.136+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.136+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.151+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.151+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.166+0900 W/W_HOME  (  737): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
05-26 22:24:45.166+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.166+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.181+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.181+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.201+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.201+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.211+0900 E/weather-widget(  801): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1574) > [0;40;31mUpdateWidgetInstanceTimerCb[0;m
05-26 22:24:45.221+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.221+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.226+0900 E/weather-widget(  801): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1615) > [0;40;31mcontent is NULL[0;m
05-26 22:24:45.241+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.241+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.256+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.256+0900 E/weather-widget(  801): WidgetView.cpp: UpdateViewPage(299) > [0;40;31mUpdateViewPage locationId : 4111000000[0;m
05-26 22:24:45.256+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.276+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.276+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.296+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.296+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.316+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.316+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.326+0900 E/weather-widget(  801): WidgetView.cpp: SetBackgroundImage(155) > [0;40;31mbackground color code:AO098[0;m
05-26 22:24:45.331+0900 E/weather-widget(  801): WidgetView.cpp: SetBackgroundImage(165) > [0;40;31mbackground image color code:AO0953[0;m
05-26 22:24:45.331+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.331+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.341+0900 W/LOCATION(  801): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
05-26 22:24:45.341+0900 E/weather-common(  801): Location.cpp: IsLocationServiceAvailable(297) > [0;40;31menabled : 0[0;m
05-26 22:24:45.341+0900 E/weather-widget(  801): WidgetMain.cpp: CheckAndRequestAutoRefresh(1151) > [0;40;31m[CheckAndRequestAutoRefresh(): 1151] (locationPtr->IsLocationServiceAvailable() == false) [break][0;m
05-26 22:24:45.346+0900 E/EFL     (  801): edje<801> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'timeSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 22:24:45.346+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.346+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.351+0900 E/EFL     (  801): edje<801> edje_util.c:3770 edje_object_size_min_restricted_calc() group highLowTemperature has a non-fixed part 'low'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 22:24:45.351+0900 E/EFL     (  801): edje<801> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'weatherIconSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 22:24:45.361+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:24:45.361+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:24:45.376+0900 E/weather-widget(  801): WidgetMain.cpp: PauseWidgetInstance(1395) > [0;40;31mPauseWidgetInstance[0;m
05-26 22:24:45.381+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 22:24:45.381+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93c20 : elm_scroller] CurrentPage(2)
05-26 22:24:45.386+0900 E/weather-widget(  801): WidgetView.cpp: HideActivityIndicator(753) > [0;40;31m[HideActivityIndicator(): 753] (refreshButtonLayout == NULL) [return][0;m
05-26 22:24:45.386+0900 E/weather-widget(  801): WidgetView.cpp: Pause(1739) > [0;40;31mOnClosed[0;m
05-26 22:24:45.386+0900 E/weather-widget(  801): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-26 22:24:45.396+0900 E/weather-widget(  801): WidgetMain.cpp: PauseWidgetInstance(1436) > [0;40;31mlocationID : 4111000000[0;m
05-26 22:24:45.396+0900 I/CAPI_WIDGET_APPLICATION(  801): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-26 22:24:45.396+0900 I/CAPI_WIDGET_APPLICATION(  801): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-26 22:24:45.501+0900 W/W_HOME  (  737): event_manager.c: _home_scroll_cb(564) > scroll,done
05-26 22:24:45.601+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:24:45.601+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(200) ev->cur.canvas.y(99)
05-26 22:24:45.601+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:24:45.601+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3122648 button=1 downs=1
05-26 22:24:45.606+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:24:45.606+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(205) ev->cur.canvas.y(98)
05-26 22:24:45.606+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:24:45.616+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:24:45.616+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(206) ev->cur.canvas.y(98)
05-26 22:24:45.616+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:24:45.626+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:24:45.626+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(204) ev->cur.canvas.y(103)
05-26 22:24:45.626+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:24:45.641+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:24:45.641+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(204) ev->cur.canvas.y(105)
05-26 22:24:45.641+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:24:45.641+0900 E/EFL     (  797): evas_main<797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3122645 button=1 downs=1
05-26 22:24:45.641+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:24:45.641+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:24:45.641+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:24:45.651+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3122700 button=1 downs=0
05-26 22:24:45.666+0900 E/EFL     (  797): evas_main<797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3122704 button=1 downs=0
05-26 22:24:45.676+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:24:45.681+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 797
05-26 22:24:45.681+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:24:45.686+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 737
05-26 22:24:45.691+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESET State: RUNNING
05-26 22:24:45.691+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 22:24:45.691+0900 W/W_HOME  (  737): main.c: _app_control(1726) > Service value : launch_apps
05-26 22:24:45.691+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(737), cmd(0)
05-26 22:24:45.696+0900 W/W_HOME  (  737): move.c: move_move_to_apps(216) > move to apps
05-26 22:24:45.696+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47740530
05-26 22:24:45.696+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47740530, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:24:45.696+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:24:45.696+0900 W/W_HOME  (  737): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-26 22:24:45.696+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:24:45.696+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:24:45.711+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-26 22:24:45.711+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-26 22:24:45.711+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-26 22:24:45.711+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:24:45.716+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:24:45.716+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:24:45.716+0900 W/W_HOME  (  737): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
05-26 22:24:45.716+0900 W/W_HOME  (  737): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-26 22:24:45.716+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-26 22:24:45.716+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-26 22:24:45.981+0900 W/W_HOME  (  737): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-26 22:24:45.981+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:24:45.981+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47740530
05-26 22:24:45.981+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:24:45.981+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47740530, elm_layout, func : 0x4004b469
05-26 22:24:45.981+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:24:45.981+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:24:45.981+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:24:45.981+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47740530, activated : 1
05-26 22:24:45.981+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:24:45.981+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:24:45.981+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:24:45.981+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-26 22:24:45.986+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-26 22:24:45.986+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:24:45.986+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:24:45.986+0900 W/W_HOME  (  737): main.c: home_pause(751) > clock/widget paused
05-26 22:24:45.986+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:24:45.986+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:24:45.991+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 22:24:45.991+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:24:45.991+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:24:45.991+0900 W/W_HOME  (  737): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-26 22:24:45.996+0900 W/W_HOME  (  737): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-26 22:24:45.996+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-26 22:24:45.996+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-26 22:24:45.996+0900 E/APPS    (  737): apps_main.c: apps_main_resume(621) >  resumed already
05-26 22:24:46.001+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:24:46.001+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:24:46.001+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:24:46.001+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:24:46.151+0900 W/W_HOME  (  737): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-26 22:24:46.211+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 22:24:46.216+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3123263 button=1 downs=1
05-26 22:24:46.221+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [177, 185]
05-26 22:24:46.276+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3123324 button=1 downs=0
05-26 22:24:46.276+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [177, 185]->[179, 185]
05-26 22:24:46.281+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-26 22:24:46.281+0900 E/APPS    (  737): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-26 22:24:46.281+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-26 22:24:46.286+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:24:46.291+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 737
05-26 22:24:46.291+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:24:46.301+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-26 22:24:46.301+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 22:24:46.301+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 22:24:46.306+0900 W/AUL_PAD ( 1155): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 22:24:46.306+0900 W/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 22:24:46.341+0900 I/efl-extension(11297): efl_extension.c: eext_mod_init(40) > Init
05-26 22:24:46.341+0900 I/UXT     (11297): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 22:24:46.356+0900 I/CAPI_APPFW_APPLICATION(11297): app_main.c: ui_app_main(704) > app_efl_main
05-26 22:24:46.361+0900 I/CAPI_APPFW_APPLICATION(11297): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-26 22:24:46.401+0900 E/TBM     (11297): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 22:24:46.406+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:24:46.411+0900 E/RESOURCED(  497): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-26 22:24:46.481+0900 E/EFL     (11297): <11297> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-26 22:24:46.491+0900 E/EFL     (11297): <11297> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:24:46.491+0900 E/EFL     (11297): <11297> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:24:46.491+0900 E/EFL     (11297): <11297> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:24:46.496+0900 E/EFL     (11297): <11297> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:24:46.496+0900 E/EFL     (11297): <11297> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:24:46.546+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03e00002)
05-26 22:24:46.551+0900 I/APP_CORE(11297): appcore-efl.c: __do_app(429) > [APP 11297] Event: RESET State: CREATED
05-26 22:24:46.551+0900 I/CAPI_APPFW_APPLICATION(11297): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 22:24:46.571+0900 I/APP_CORE(11297): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 22:24:46.571+0900 I/APP_CORE(11297): appcore-efl.c: __do_app(474) > [APP 11297] Initial Launching, call the resume_cb
05-26 22:24:46.576+0900 I/CAPI_APPFW_APPLICATION(11297): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 22:24:46.606+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 22:24:46.616+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 22:24:46.616+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:24:46.616+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:24:46.616+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:24:46.616+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 22:24:46.616+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:24:46.616+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:24:46.651+0900 W/APP_CORE(11297): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00002
05-26 22:24:46.721+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 22:24:46.721+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 22:24:46.726+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:24:46.726+0900 W/W_HOME  (  737): event_manager.c: _state_control(333) > appcore paused manually
05-26 22:24:46.726+0900 W/W_HOME  (  737): main.c: home_appcore_pause(717) > Home Appcore Paused
05-26 22:24:46.726+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 22:24:46.726+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:24:46.731+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:24:46.731+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 22:24:46.736+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:24:46.736+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:24:46.736+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 22:24:46.736+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:24:46.736+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 22:24:46.736+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:24:46.736+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:24:46.736+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:24:46.736+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 22:24:46.736+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:24:46.736+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:24:46.736+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:24:46.756+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:24:46.756+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:24:46.756+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:24:46.756+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:24:46.756+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:24:46.756+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:24:46.756+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:24:46.756+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:24:46.761+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:24:46.761+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:24:46.761+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:24:46.761+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:24:46.761+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:24:46.761+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:24:46.761+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:24:46.761+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:24:46.761+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:24:46.761+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:24:46.761+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:24:46.761+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 22:24:46.761+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 22:24:46.761+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:24:46.761+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:24:46.761+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 22:24:46.761+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:24:46.761+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 22:24:46.761+0900 E/W_HOME  (  737): main.c: _pause_cb(668) > paused already
05-26 22:24:46.796+0900 I/APP_CORE(11297): appcore-efl.c: __do_app(429) > [APP 11297] Event: RESUME State: RUNNING
05-26 22:24:46.831+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 22:24:46.831+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:24:46.841+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 22:24:47.106+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:24:47.226+0900 E/EFL     (11297): evas_main<11297> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3124258 button=1 downs=1
05-26 22:24:47.261+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:24:47.286+0900 E/EFL     (11297): evas_main<11297> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3124334 button=1 downs=0
05-26 22:24:47.446+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:24:47.461+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11297
05-26 22:24:47.471+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:24:47.721+0900 I/AUL_PAD (11316): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 22:24:51.656+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 22:24:51.766+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:24:52.411+0900 E/EFL     (11297): evas_main<11297> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3129456 button=1 downs=1
05-26 22:24:52.476+0900 E/EFL     (11297): evas_main<11297> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3129525 button=1 downs=0
05-26 22:24:52.796+0900 I/CAPI_NETWORK_CONNECTION(11297): connection.c: connection_create(372) > New handle created[0x456f9538]
05-26 22:24:52.831+0900 I/SOCKETTEST(11297): IP : 
05-26 22:24:52.831+0900 I/SOCKETTEST(11297): Success to create UDP socket
05-26 22:24:52.831+0900 I/SOCKETTEST(11297): Bind Success
05-26 22:24:52.831+0900 I/SOCKETTEST(11297): Waiting DATA...
05-26 22:24:53.676+0900 I/SOCKETTEST(11297): Receive Data : 192.168.0.47
05-26 22:24:53.676+0900 I/SOCKETTEST(11297): Changed IP : 192.168.0.47
05-26 22:24:53.741+0900 I/SOCKETTEST(11297): Success to create socket
05-26 22:24:53.751+0900 I/SOCKETTEST(11297): Success to socket connection
05-26 22:24:53.751+0900 I/SOCKETTEST(11297): write() 성공
05-26 22:24:55.126+0900 E/EFL     (11297): evas_main<11297> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3132177 button=1 downs=1
05-26 22:24:55.161+0900 E/EFL     (11297): evas_main<11297> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3132209 button=1 downs=0
05-26 22:24:55.181+0900 D/TIMER   (11297): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:24:55.181+0900 D/TIMER   (11297): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:24:55.241+0900 I/efl-extension(11297): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:24:55.241+0900 I/efl-extension(11297): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:24:55.246+0900 I/efl-extension(11297): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:24:55.251+0900 I/efl-extension(11297): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:24:55.251+0900 I/efl-extension(11297): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4191a488, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:24:56.056+0900 E/EFL     (11297): evas_main<11297> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3133102 button=1 downs=1
05-26 22:24:56.126+0900 E/EFL     (11297): evas_main<11297> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3133176 button=1 downs=0
05-26 22:24:57.031+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.031+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.036+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.036+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134082
05-26 22:24:57.036+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.066+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.066+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.066+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134116
05-26 22:24:57.066+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.066+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.091+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.091+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.091+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134141
05-26 22:24:57.091+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.091+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.141+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.141+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.141+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134191
05-26 22:24:57.141+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.141+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.186+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.186+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.186+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134233
05-26 22:24:57.186+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.186+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.211+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.211+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.211+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134260
05-26 22:24:57.211+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.211+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.236+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.236+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.236+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134287
05-26 22:24:57.236+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.236+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.256+0900 E/GESTURE (  143): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=19   flick_area=55 ---> SET value to 1
05-26 22:24:57.256+0900 E/GESTURE (  143): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
05-26 22:24:57.256+0900 E/GESTURE (  143): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=19   flick_area=55 ---> SET value to 1
05-26 22:24:57.261+0900 I/GESTURE (  143): gesture.c: GestureHandleMTSyncEvent(3251) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
05-26 22:24:57.261+0900 E/GESTURE (  143): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
05-26 22:24:57.266+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.266+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.266+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134312
05-26 22:24:57.266+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.266+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.281+0900 I/GESTURE (  143): gesture.c: GestureHandleMTSyncEvent(3251) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
05-26 22:24:57.281+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.286+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.286+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134333
05-26 22:24:57.286+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.286+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.311+0900 I/GESTURE (  143): gesture.c: GestureHandleMTSyncEvent(3251) > [GestureHandleMTSyncEvent] Rotary finished. But touch events are still dropped until SYNC_END.
05-26 22:24:57.311+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.311+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.311+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134360
05-26 22:24:57.311+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.311+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.336+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.336+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.336+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134384
05-26 22:24:57.336+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.336+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.371+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.371+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.371+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134419
05-26 22:24:57.371+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.371+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.396+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.396+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.396+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.396+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134446
05-26 22:24:57.396+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.441+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.441+0900 I/efl-extension(11297): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.441+0900 I/efl-extension(11297): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191a488, elm_layout, time_stamp : 3134489
05-26 22:24:57.441+0900 E/TIMER   (11297): (ad->timer) -> _rotary_cb() return
05-26 22:24:57.441+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:24:57.721+0900 E/EFL     (11297): evas_main<11297> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3134769 button=1 downs=1
05-26 22:24:57.816+0900 E/EFL     (11297): evas_main<11297> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3134864 button=1 downs=0
05-26 22:24:57.816+0900 I/efl-extension(11297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:24:57.816+0900 I/efl-extension(11297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4191a488, elm_layout, func : 0x41560869
05-26 22:24:57.816+0900 I/efl-extension(11297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:24:57.816+0900 I/efl-extension(11297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:24:57.816+0900 I/efl-extension(11297): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:24:57.816+0900 I/efl-extension(11297): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:24:57.816+0900 I/efl-extension(11297): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:24:57.816+0900 I/efl-extension(11297): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:24:57.816+0900 E/EFL     (11297): ecore<11297> ecore.c:574 _ecore_magic_fail() 
05-26 22:24:57.816+0900 E/EFL     (11297): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:24:57.816+0900 E/EFL     (11297): *** IN FUNCTION: ecore_timer_del()
05-26 22:24:57.816+0900 E/EFL     (11297): ecore<11297> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:24:57.816+0900 E/EFL     (11297):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:24:57.816+0900 E/EFL     (11297):     Supplied: 0049a1bd - <UNKNOWN>
05-26 22:24:57.816+0900 E/EFL     (11297): ecore<11297> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:24:57.816+0900 E/EFL     (11297): *** SPANK SPANK SPANK!!!
05-26 22:24:57.816+0900 E/EFL     (11297): *** Now go fix your code. Tut tut tut!
05-26 22:24:57.821+0900 I/SOCKETTEST(11297): Success to create socket
05-26 22:24:57.836+0900 I/SOCKETTEST(11297): Success to socket connection
05-26 22:24:57.836+0900 I/SOCKETTEST(11297): write() 성공
05-26 22:24:58.121+0900 W/CRASH_MANAGER(11361): worker.c: worker_job(1199) > 1111297706831146426909
