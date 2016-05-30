S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 29797
Date: 2016-05-26 21:30:43+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 29797, uid 5000)

Register Information
r0   = 0x702f6374, r1   = 0x00000025
r2   = 0xbebef20c, r3   = 0x0000feff
r4   = 0x702f6370, r5   = 0x702f6374
r6   = 0xbebeecd8, r7   = 0x25252525
r8   = 0x00000000, r9   = 0x4142dec0
r10  = 0x702f6374, fp   = 0xbebeeccc
ip   = 0x702f6374, sp   = 0xbebee758
lr   = 0x404b1f5c, pc   = 0x404ec6dc
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     40224 KB
Buffers:     45608 KB
Cached:     130156 KB
VmPeak:      96908 KB
VmSize:      94872 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23200 KB
VmRSS:       23200 KB
VmData:      35536 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25096 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 29797 TID = 29797
29797 30073 

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
44c94000 45493000 rwxp [stack:30073]
456a6000 456b0000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
456b8000 456ce000 r-xp /usr/lib/libmmfsound.so.0.1.0
456e0000 456e5000 r-xp /usr/lib/libmmfsession.so.0.0.0
456ed000 456f1000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
4587f000 45889000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45895000 458ab000 r-xp /usr/lib/libavsysaudio.so.0.0.1
458b4000 458b9000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
458c1000 458c4000 r-xp /usr/lib/libpulse-simple.so.0.0.4
458cc000 458cf000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
458d7000 458e4000 r-xp /usr/lib/libail.so.0.1.0
458ed000 458f0000 r-xp /usr/lib/libcompress.so.0.2.0
45a00000 45a61000 r-xp /usr/lib/libasound.so.2.0.0
45a6b000 45aa3000 r-xp /usr/lib/libpulse.so.0.16.2
45aa4000 45ab4000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
45ad5000 45add000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
45aec000 45af1000 r-xp /usr/lib/libjson.so.0.0.1
45af9000 45b41000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45b42000 45b85000 r-xp /usr/lib/libsndfile.so.1.0.25
45b92000 45bb4000 r-xp /usr/lib/libvorbis.so.0.4.3
45bbc000 45bc0000 r-xp /usr/lib/libogg.so.0.7.1
bebcf000 bebf0000 rwxp [stack]
End of Maps Information

Callstack Information (PID:29797)
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
955) > tobj_item_01 is null
05-26 21:30:29.899+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:29.914+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:29.914+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:29.929+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:29.929+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:29.949+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:29.949+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:29.964+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:29.964+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:29.984+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:29.984+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:29.999+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:29.999+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.024+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.024+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.029+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 21:30:30.029+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93cc8 : elm_scroller] CurrentPage(3)
05-26 21:30:30.114+0900 E/weather-widget(  783): WidgetMain.cpp: ResumeWidgetInstance(1447) > [0;40;31mResumeWidgetInstance[0;m
05-26 21:30:30.114+0900 E/weather-widget(  783): WidgetMain.cpp: GetUpdateTimerData(243) > [0;40;31m[GetUpdateTimerData(): 243] (size < 1) [return][0;m
05-26 21:30:30.114+0900 E/weather-widget(  783): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-26 21:30:30.114+0900 E/weather-widget(  783): WidgetMain.cpp: ResumeWidgetInstance(1474) > [0;40;31mhomerun[0;m
05-26 21:30:30.114+0900 I/CAPI_WIDGET_APPLICATION(  783): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
05-26 21:30:30.119+0900 I/CAPI_WIDGET_APPLICATION(  783): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
05-26 21:30:30.159+0900 W/W_HOME  (  726): event_manager.c: _home_scroll_cb(564) > scroll,done
05-26 21:30:30.314+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 21:30:30.314+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x45c96248, elm_box, time_stamp : 13940798
05-26 21:30:30.314+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_rotary_cb(568) > Pass rotary event to home.
05-26 21:30:30.324+0900 W/W_HOME  (  726): home_navigation.c: _is_rightedge(188) > (1080 360) not right edge: 0 0 0x45222398 -> 360 0 0x47940030
05-26 21:30:30.324+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45c93cc8 : elm_scroller] rotary callabck is called.
05-26 21:30:30.324+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45c93cc8 : elm_scroller] block(2)
05-26 21:30:30.324+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45c93cc8 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-26 21:30:30.324+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45c93cc8 : elm_scroller] content size (w, h)(2520, 360)
05-26 21:30:30.324+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45c93cc8 : elm_scroller] viewport size (w, h)(360, 360)
05-26 21:30:30.324+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45c93cc8 : elm_scroller] CurrentPage(3) DetentCount(-1)
05-26 21:30:30.324+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(1080), py(0)
05-26 21:30:30.324+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(1080), py(0)
05-26 21:30:30.324+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(1080), py(0)
05-26 21:30:30.324+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45c93cc8 : elm_scroller] bring in 2 page
05-26 21:30:30.324+0900 W/W_HOME  (  726): event_manager.c: _home_scroll_cb(564) > scroll,start
05-26 21:30:30.324+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.324+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.339+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.339+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.354+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.354+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.369+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.369+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.374+0900 W/W_HOME  (  726): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
05-26 21:30:30.389+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.389+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.404+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.404+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.419+0900 E/weather-widget(  783): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1574) > [0;40;31mUpdateWidgetInstanceTimerCb[0;m
05-26 21:30:30.424+0900 E/weather-widget(  783): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1615) > [0;40;31mcontent is NULL[0;m
05-26 21:30:30.424+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.424+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.439+0900 E/weather-widget(  783): WidgetView.cpp: UpdateViewPage(299) > [0;40;31mUpdateViewPage locationId : 4111000000[0;m
05-26 21:30:30.439+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.444+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.459+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.459+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.474+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.474+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.484+0900 E/weather-widget(  783): WidgetView.cpp: SetBackgroundImage(155) > [0;40;31mbackground color code:AO098[0;m
05-26 21:30:30.484+0900 E/weather-widget(  783): WidgetView.cpp: SetBackgroundImage(165) > [0;40;31mbackground image color code:AO0953[0;m
05-26 21:30:30.494+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.494+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.494+0900 W/LOCATION(  783): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
05-26 21:30:30.499+0900 E/weather-common(  783): Location.cpp: IsLocationServiceAvailable(297) > [0;40;31menabled : 0[0;m
05-26 21:30:30.499+0900 E/weather-widget(  783): WidgetMain.cpp: CheckAndRequestAutoRefresh(1151) > [0;40;31m[CheckAndRequestAutoRefresh(): 1151] (locationPtr->IsLocationServiceAvailable() == false) [break][0;m
05-26 21:30:30.499+0900 E/EFL     (  783): edje<783> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'timeSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 21:30:30.504+0900 E/EFL     (  783): edje<783> edje_util.c:3770 edje_object_size_min_restricted_calc() group highLowTemperature has a non-fixed part 'low'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 21:30:30.504+0900 E/EFL     (  783): edje<783> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'weatherIconSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 21:30:30.504+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.504+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.509+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:30:30.509+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:30:30.524+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.524+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.539+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.539+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.559+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.559+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.574+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 21:30:30.574+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 21:30:30.589+0900 E/weather-widget(  783): WidgetMain.cpp: PauseWidgetInstance(1395) > [0;40;31mPauseWidgetInstance[0;m
05-26 21:30:30.594+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 21:30:30.594+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93cc8 : elm_scroller] CurrentPage(2)
05-26 21:30:30.599+0900 E/weather-widget(  783): WidgetView.cpp: HideActivityIndicator(753) > [0;40;31m[HideActivityIndicator(): 753] (refreshButtonLayout == NULL) [return][0;m
05-26 21:30:30.599+0900 E/weather-widget(  783): WidgetView.cpp: Pause(1739) > [0;40;31mOnClosed[0;m
05-26 21:30:30.599+0900 E/weather-widget(  783): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-26 21:30:30.614+0900 E/weather-widget(  783): WidgetMain.cpp: PauseWidgetInstance(1436) > [0;40;31mlocationID : 4111000000[0;m
05-26 21:30:30.614+0900 I/CAPI_WIDGET_APPLICATION(  783): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-26 21:30:30.614+0900 I/CAPI_WIDGET_APPLICATION(  783): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-26 21:30:30.704+0900 W/W_HOME  (  726): event_manager.c: _home_scroll_cb(564) > scroll,done
05-26 21:30:30.759+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-26 21:30:30.759+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(191) ev->cur.canvas.y(68)
05-26 21:30:30.759+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-26 21:30:30.759+0900 E/EFL     (  726): evas_main<726> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13941244 button=1 downs=1
05-26 21:30:30.769+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-26 21:30:30.769+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(190) ev->cur.canvas.y(69)
05-26 21:30:30.769+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-26 21:30:30.779+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-26 21:30:30.779+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(188) ev->cur.canvas.y(71)
05-26 21:30:30.779+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-26 21:30:30.789+0900 E/EFL     (  780): evas_main<780> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13941243 button=1 downs=1
05-26 21:30:30.789+0900 E/EFL     (  780): evas_main<780> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 21:30:30.789+0900 E/EFL     (  780): evas_main<780> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 21:30:30.789+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-26 21:30:30.789+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(188) ev->cur.canvas.y(72)
05-26 21:30:30.789+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-26 21:30:30.789+0900 E/EFL     (  780): evas_main<780> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 21:30:30.809+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-26 21:30:30.809+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(186) ev->cur.canvas.y(74)
05-26 21:30:30.809+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-26 21:30:30.819+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), block(2)
05-26 21:30:30.819+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), ev->cur.canvas.x(183) ev->cur.canvas.y(80)
05-26 21:30:30.819+0900 E/EFL     (  726): elementary<726> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93cc8), hold(0) freeze(0)
05-26 21:30:30.824+0900 E/EFL     (  726): evas_main<726> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13941309 button=1 downs=0
05-26 21:30:30.839+0900 E/EFL     (  780): evas_main<780> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13941314 button=1 downs=0
05-26 21:30:30.844+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 21:30:30.844+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(1702) > caller pid : 780
05-26 21:30:30.844+0900 I/AUL_AMD (  474): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 21:30:30.854+0900 W/AUL_AMD (  474): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 726
05-26 21:30:30.859+0900 W/AUL_AMD (  474): amd_launch.c: __reply_handler(916) > listen fd(22) , send fd(21), pid(726), cmd(0)
05-26 21:30:30.864+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESET State: RUNNING
05-26 21:30:30.864+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 21:30:30.864+0900 W/W_HOME  (  726): main.c: _app_control(1726) > Service value : launch_apps
05-26 21:30:30.864+0900 W/W_HOME  (  726): move.c: move_move_to_apps(216) > move to apps
05-26 21:30:30.864+0900 W/W_HOME  (  726): rotary.c: rotary_attach(138) > rotary_attach:0x47965b38
05-26 21:30:30.864+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47965b38, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-26 21:30:30.864+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:30:30.864+0900 W/W_HOME  (  726): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-26 21:30:30.864+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 21:30:30.869+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 21:30:30.884+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-26 21:30:30.884+0900 W/W_HOME  (  726): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-26 21:30:30.884+0900 W/W_HOME  (  726): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-26 21:30:30.884+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 21:30:30.889+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 21:30:30.889+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 21:30:30.889+0900 W/W_HOME  (  726): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
05-26 21:30:30.889+0900 W/W_HOME  (  726): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-26 21:30:30.889+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-26 21:30:30.889+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-26 21:30:31.164+0900 W/W_HOME  (  726): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-26 21:30:31.164+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 21:30:31.164+0900 W/W_HOME  (  726): rotary.c: rotary_deattach(156) > rotary_deattach:0x47965b38
05-26 21:30:31.164+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:30:31.164+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47965b38, elm_layout, func : 0x4004b469
05-26 21:30:31.164+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:30:31.164+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:30:31.164+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:30:31.164+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x47965b38, activated : 1
05-26 21:30:31.164+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:30:31.164+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:30:31.164+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 21:30:31.169+0900 W/W_HOME  (  726): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-26 21:30:31.169+0900 W/W_HOME  (  726): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-26 21:30:31.169+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:30:31.169+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:30:31.169+0900 W/W_HOME  (  726): main.c: home_pause(751) > clock/widget paused
05-26 21:30:31.169+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:30:31.169+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:30:31.169+0900 W/W_HOME  (  726): rotary.c: rotary_attach(138) > rotary_attach:0x478904a8
05-26 21:30:31.169+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x478904a8, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-26 21:30:31.169+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:30:31.169+0900 W/W_HOME  (  726): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-26 21:30:31.169+0900 W/W_HOME  (  726): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-26 21:30:31.169+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-26 21:30:31.169+0900 I/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-26 21:30:31.169+0900 E/APPS    (  726): apps_main.c: apps_main_resume(621) >  resumed already
05-26 21:30:31.179+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:30:31.179+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:30:31.179+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:30:31.179+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:30:31.329+0900 W/W_HOME  (  726): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-26 21:30:31.844+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 21:30:31.844+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x478904a8, elm_layout, time_stamp : 13942330
05-26 21:30:31.844+0900 W/APPS    (  726): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3169) >  __nIsEditMode[0], __focusPage[2], __focusIndex[20], __pAppsItemList.size[21]
05-26 21:30:31.844+0900 W/APPS    (  726): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[19]
05-26 21:30:31.859+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:30:31.859+0900 W/AUL_AMD (  474): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-26 21:30:32.079+0900 W/APPS    (  726): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 21:30:32.274+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 21:30:32.279+0900 E/EFL     (  726): evas_main<726> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13942763 button=1 downs=1
05-26 21:30:32.279+0900 W/APPS    (  726): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [183, 193]
05-26 21:30:32.324+0900 E/EFL     (  726): evas_main<726> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13942800 button=1 downs=0
05-26 21:30:32.324+0900 W/APPS    (  726): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [183, 193]->[176, 195]
05-26 21:30:32.329+0900 W/APPS    (  726): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-26 21:30:32.334+0900 E/APPS    (  726): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-26 21:30:32.334+0900 W/APPS    (  726): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-26 21:30:32.334+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 21:30:32.339+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(1702) > caller pid : 726
05-26 21:30:32.339+0900 I/AUL_AMD (  474): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 21:30:32.349+0900 W/AUL_AMD (  474): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 29797
05-26 21:30:32.354+0900 I/APP_CORE(29797): appcore-efl.c: __do_app(429) > [APP 29797] Event: RESET State: PAUSED
05-26 21:30:32.354+0900 I/CAPI_APPFW_APPLICATION(29797): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 21:30:32.354+0900 I/APP_CORE(29797): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-26 21:30:32.354+0900 I/APP_CORE(29797): appcore-efl.c: __do_app(481) > [APP 29797] App already running, raise the window
05-26 21:30:32.354+0900 W/AUL_AMD (  474): amd_launch.c: __reply_handler(916) > listen fd(22) , send fd(21), pid(29797), cmd(0)
05-26 21:30:32.354+0900 E/AUL     (  474): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:30:32.369+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x03a00002)
05-26 21:30:32.369+0900 I/APP_CORE(29797): appcore-efl.c: __do_app(485) > [APP 29797] Call the resume_cb
05-26 21:30:32.369+0900 I/CAPI_APPFW_APPLICATION(29797): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 21:30:32.389+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 21:30:32.389+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:30:32.389+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:30:32.394+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:30:32.394+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 21:30:32.399+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:30:32.399+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:30:32.444+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 21:30:32.449+0900 I/APP_CORE(29797): appcore-efl.c: __do_app(429) > [APP 29797] Event: RESUME State: RUNNING
05-26 21:30:32.469+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-26 21:30:32.469+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 21:30:32.469+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:30:32.469+0900 W/W_HOME  (  726): event_manager.c: _state_control(333) > appcore paused manually
05-26 21:30:32.469+0900 W/W_HOME  (  726): main.c: home_appcore_pause(717) > Home Appcore Paused
05-26 21:30:32.469+0900 W/W_HOME  (  726): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 21:30:32.469+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:30:32.469+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:30:32.469+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:30:32.469+0900 W/W_HOME  (  726): rotary.c: rotary_deattach(156) > rotary_deattach:0x478904a8
05-26 21:30:32.469+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:30:32.469+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x478904a8, elm_layout, func : 0x4004b469
05-26 21:30:32.469+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:30:32.469+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:30:32.469+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:30:32.469+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x478904a8, activated : 1
05-26 21:30:32.469+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:30:32.469+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:30:32.469+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:30:32.479+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:30:32.484+0900 E/CAPI_APPFW_APP_CONTROL( 1445): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 21:30:32.484+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1445]   [com.samsung.w-home]register msg port [false][0m
05-26 21:30:32.484+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-26 21:30:32.484+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:30:32.484+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:30:32.484+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: PAUSE State: RUNNING
05-26 21:30:32.484+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 21:30:32.484+0900 W/W_HOME  (  726): main.c: _appcore_pause_cb(690) > appcore pause
05-26 21:30:32.484+0900 E/W_HOME  (  726): main.c: _pause_cb(668) > paused already
05-26 21:30:32.529+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 21:30:32.529+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:30:32.539+0900 W/APPS    (  726): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 21:30:32.824+0900 E/AUL     (  474): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:30:32.984+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: MEM_FLUSH State: PAUSED
05-26 21:30:34.489+0900 E/EFL     (29797): evas_main<29797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13944974 button=1 downs=1
05-26 21:30:34.524+0900 E/EFL     (29797): evas_main<29797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13945012 button=1 downs=0
05-26 21:30:35.164+0900 E/EFL     (29797): evas_main<29797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13945646 button=1 downs=1
05-26 21:30:35.259+0900 E/EFL     (29797): evas_main<29797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13945743 button=1 downs=0
05-26 21:30:35.514+0900 I/CAPI_NETWORK_CONNECTION(29797): connection.c: connection_create(372) > New handle created[0x44921100]
05-26 21:30:35.529+0900 I/SOCKETTEST(29797): IP : 
05-26 21:30:35.529+0900 I/SOCKETTEST(29797): Success to create UDP socket
05-26 21:30:35.529+0900 I/SOCKETTEST(29797): Bind Success
05-26 21:30:35.529+0900 I/SOCKETTEST(29797): Waiting DATA...
05-26 21:30:37.489+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: MEM_FLUSH State: PAUSED
05-26 21:30:37.639+0900 I/SOCKETTEST(29797): Receive Data : 192.168.0.47
05-26 21:30:37.639+0900 I/SOCKETTEST(29797): Changed IP : 192.168.0.47
05-26 21:30:37.699+0900 I/SOCKETTEST(29797): Success to create socket
05-26 21:30:37.709+0900 I/SOCKETTEST(29797): Success to socket connection
05-26 21:30:37.709+0900 I/SOCKETTEST(29797): write() 성공
05-26 21:30:39.544+0900 E/EFL     (29797): evas_main<29797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13950029 button=1 downs=1
05-26 21:30:39.604+0900 E/EFL     (29797): evas_main<29797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13950089 button=1 downs=0
05-26 21:30:39.619+0900 D/TIMER   (29797): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:30:39.619+0900 D/TIMER   (29797): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:30:39.674+0900 I/efl-extension(29797): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:30:39.674+0900 I/efl-extension(29797): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:30:39.674+0900 I/efl-extension(29797): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:30:39.674+0900 I/efl-extension(29797): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:30:39.674+0900 I/efl-extension(29797): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44904760, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:30:40.709+0900 E/EFL     (29797): evas_main<29797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13951193 button=1 downs=1
05-26 21:30:40.744+0900 E/EFL     (29797): evas_main<29797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13951230 button=1 downs=0
05-26 21:30:41.169+0900 E/EFL     (29797): evas_main<29797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13951649 button=1 downs=1
05-26 21:30:41.219+0900 E/EFL     (29797): evas_main<29797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13951707 button=1 downs=0
05-26 21:30:41.534+0900 E/EFL     (29797): evas_main<29797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13952018 button=1 downs=1
05-26 21:30:41.594+0900 E/EFL     (29797): evas_main<29797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13952081 button=1 downs=0
05-26 21:30:41.929+0900 E/EFL     (29797): evas_main<29797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13952413 button=1 downs=1
05-26 21:30:42.004+0900 E/EFL     (29797): evas_main<29797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13952493 button=1 downs=0
05-26 21:30:42.609+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.609+0900 I/efl-extension(29797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.609+0900 I/efl-extension(29797): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904760, elm_layout, time_stamp : 13953094
05-26 21:30:42.614+0900 E/TIMER   (29797): (ad->timer) -> _rotary_cb() return
05-26 21:30:42.659+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.659+0900 I/efl-extension(29797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.659+0900 I/efl-extension(29797): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904760, elm_layout, time_stamp : 13953143
05-26 21:30:42.659+0900 E/TIMER   (29797): (ad->timer) -> _rotary_cb() return
05-26 21:30:42.699+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.699+0900 I/efl-extension(29797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.699+0900 I/efl-extension(29797): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904760, elm_layout, time_stamp : 13953186
05-26 21:30:42.699+0900 E/TIMER   (29797): (ad->timer) -> _rotary_cb() return
05-26 21:30:42.739+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.739+0900 I/efl-extension(29797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.739+0900 I/efl-extension(29797): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904760, elm_layout, time_stamp : 13953226
05-26 21:30:42.739+0900 E/TIMER   (29797): (ad->timer) -> _rotary_cb() return
05-26 21:30:42.769+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.769+0900 I/efl-extension(29797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.769+0900 I/efl-extension(29797): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904760, elm_layout, time_stamp : 13953256
05-26 21:30:42.769+0900 E/TIMER   (29797): (ad->timer) -> _rotary_cb() return
05-26 21:30:42.799+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.799+0900 I/efl-extension(29797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.799+0900 I/efl-extension(29797): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904760, elm_layout, time_stamp : 13953284
05-26 21:30:42.799+0900 E/TIMER   (29797): (ad->timer) -> _rotary_cb() return
05-26 21:30:42.844+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.844+0900 I/efl-extension(29797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:42.844+0900 I/efl-extension(29797): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904760, elm_layout, time_stamp : 13953330
05-26 21:30:42.844+0900 E/TIMER   (29797): (ad->timer) -> _rotary_cb() return
05-26 21:30:43.179+0900 E/EFL     (29797): evas_main<29797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13953667 button=1 downs=1
05-26 21:30:43.249+0900 E/EFL     (29797): evas_main<29797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13953737 button=1 downs=0
05-26 21:30:43.249+0900 I/efl-extension(29797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:30:43.249+0900 I/efl-extension(29797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904760, elm_layout, func : 0x415608e1
05-26 21:30:43.254+0900 I/efl-extension(29797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:30:43.254+0900 I/efl-extension(29797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:30:43.254+0900 I/efl-extension(29797): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:30:43.254+0900 I/efl-extension(29797): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:30:43.254+0900 I/efl-extension(29797): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:30:43.254+0900 I/efl-extension(29797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:30:43.254+0900 E/EFL     (29797): ecore<29797> ecore.c:574 _ecore_magic_fail() 
05-26 21:30:43.254+0900 E/EFL     (29797): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:30:43.254+0900 E/EFL     (29797): *** IN FUNCTION: ecore_timer_del()
05-26 21:30:43.254+0900 E/EFL     (29797): ecore<29797> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:30:43.254+0900 E/EFL     (29797):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:30:43.254+0900 E/EFL     (29797):     Supplied: 0049a1bd - <UNKNOWN>
05-26 21:30:43.254+0900 E/EFL     (29797): ecore<29797> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:30:43.254+0900 E/EFL     (29797): *** SPANK SPANK SPANK!!!
05-26 21:30:43.254+0900 E/EFL     (29797): *** Now go fix your code. Tut tut tut!
05-26 21:30:43.254+0900 I/SOCKETTEST(29797): Success to create socket
05-26 21:30:43.264+0900 I/SOCKETTEST(29797): Success to socket connection
05-26 21:30:43.264+0900 I/SOCKETTEST(29797): write() 성공
05-26 21:30:43.594+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:43.634+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:30:43.664+0900 W/CRASH_MANAGER(30182): worker.c: worker_job(1199) > 1129797706831146426584
