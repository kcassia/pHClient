S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 26038
Date: 2016-05-26 20:46:02+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x419e4608, r5   = 0x41461c69
r6   = 0x419e4f08, r7   = 0x40003ac4
r8   = 0x419e4f08, r9   = 0x419e3888
r10  = 0x41a07140, fp   = 0x00000000
ip   = 0x4143b490, sp   = 0xbeb19630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     29608 KB
Buffers:     47820 KB
Cached:     133352 KB
VmPeak:      91424 KB
VmSize:      87376 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20092 KB
VmRSS:       18636 KB
VmData:      34160 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22964 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 26038 TID = 26038
26038 26891 

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
41771000 4177e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41786000 4178b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41793000 41797000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417a0000 417c1000 r-xp /usr/lib/libefl-extension.so.0.1.0
417c9000 417e0000 r-xp /usr/lib/libnetwork.so.0.0.0
417e8000 417ed000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
417f5000 41813000 r-xp /usr/lib/libsensor.so.1.1.0
4181d000 4182f000 r-xp /usr/lib/libefl-assist.so.0.1.0
41837000 41868000 r-xp /usr/lib/libmdm.so.1.1.85
41870000 41877000 r-xp /usr/lib/libsensord-share.so
4187f000 41891000 r-xp /usr/lib/libtts.so
41899000 418ba000 r-xp /usr/lib/libui-extension.so.0.1.0
418c3000 418ca000 r-xp /usr/lib/libtbm.so.1.0.0
418d2000 418d3000 r-xp /usr/lib/libxcb-shm.so.0.0.0
418dd000 41a0f000 rw-p [heap]
41a0f000 41ac7000 r-xp /usr/lib/libcairo.so.2.11200.14
41ad2000 41ae0000 r-xp /usr/lib/libGLESv2.so.2.0
41ae9000 41aef000 r-xp /usr/lib/libxcb-render.so.0.0.0
41af7000 41afa000 r-xp /usr/lib/libEGL.so.1.4
41b02000 41b0a000 r-xp /usr/lib/libmdm-common.so.1.0.89
41b0b000 41c48000 r-xp /usr/lib/libicui18n.so.51.1
41c58000 41d3c000 r-xp /usr/lib/libicuuc.so.51.1
41d51000 41d54000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41d5c000 41d64000 r-xp /usr/lib/libdrm.so.2.4.0
432f3000 432f8000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43301000 43306000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4330e000 43310000 r-xp /usr/lib/libdri2.so.0.0.0
43318000 43339000 r-xp /usr/lib/libexif.so.12.3.3
4334c000 43351000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43359000 43423000 r-xp /usr/lib/libCOREGL.so.4.0
4377a000 4377e000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44b94000 45393000 rwxp [stack:26891]
beaf9000 beb1a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:26038)
Call Stack Count: 2
 0: cfree + 0xc8 (0x404e41e8) [/lib/libc.so.6] + 0x6f1e8
 1: (0x20) (null)
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
tension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:50.874+0900 I/efl-extension(26038): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:50.874+0900 I/efl-extension(26038): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b7610, elm_layout, time_stamp : 11261363
05-26 20:45:50.874+0900 E/TIMER   (26038): (ad->timer) -> _rotary_cb() return
05-26 20:45:51.354+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11261837 button=1 downs=1
05-26 20:45:51.394+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11261882 button=1 downs=0
05-26 20:45:51.399+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:45:51.399+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x437b7610, elm_layout, func : 0x414607d1
05-26 20:45:51.399+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 20:45:51.399+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 20:45:51.399+0900 I/efl-extension(26038): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 20:45:51.399+0900 I/efl-extension(26038): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 20:45:51.399+0900 I/efl-extension(26038): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 20:45:51.399+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:45:51.399+0900 E/EFL     (26038): ecore<26038> ecore.c:574 _ecore_magic_fail() 
05-26 20:45:51.399+0900 E/EFL     (26038): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 20:45:51.399+0900 E/EFL     (26038): *** IN FUNCTION: ecore_timer_del()
05-26 20:45:51.399+0900 E/EFL     (26038): ecore<26038> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 20:45:51.399+0900 E/EFL     (26038):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 20:45:51.399+0900 E/EFL     (26038):     Supplied: 0049a1bd - <UNKNOWN>
05-26 20:45:51.399+0900 E/EFL     (26038): ecore<26038> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 20:45:51.399+0900 E/EFL     (26038): *** SPANK SPANK SPANK!!!
05-26 20:45:51.399+0900 E/EFL     (26038): *** Now go fix your code. Tut tut tut!
05-26 20:45:51.399+0900 I/SOCKETTEST(26038): Success to create socket
05-26 20:45:51.399+0900 I/SOCKETTEST(26038): socket connect error: Network is unreachable
05-26 20:45:51.399+0900 I/SOCKETTEST(26038): write() error: Bad file descriptor
05-26 20:45:51.399+0900 W/efl-extension(26038): efl_extension_events.c: eext_object_event_callback_del(319) > This object(0x437b7610) hasn't been registered before
05-26 20:45:51.534+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: MEM_FLUSH State: PAUSED
05-26 20:45:51.919+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11262403 button=1 downs=1
05-26 20:45:51.974+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11262462 button=1 downs=0
05-26 20:45:51.974+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:45:51.974+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x437b7610, elm_layout, func : 0x414607d1
05-26 20:45:51.974+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:45:51.974+0900 D/TIMER   (26038): Setting time is 0
05-26 20:45:51.979+0900 E/TIMER   (26038): (!ad->setting_time) -> _start_clicked_cb() return
05-26 20:45:52.429+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11262914 button=1 downs=1
05-26 20:45:52.489+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11262977 button=1 downs=0
05-26 20:45:52.489+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:45:52.489+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x437b7610, elm_layout, func : 0x414607d1
05-26 20:45:52.489+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:45:52.489+0900 D/TIMER   (26038): Setting time is 0
05-26 20:45:52.489+0900 E/TIMER   (26038): (!ad->setting_time) -> _start_clicked_cb() return
05-26 20:45:52.639+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11263124 button=1 downs=1
05-26 20:45:52.659+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11263146 button=1 downs=0
05-26 20:45:52.659+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:45:52.659+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x437b7610, elm_layout, func : 0x414607d1
05-26 20:45:52.659+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:45:52.659+0900 D/TIMER   (26038): Setting time is 0
05-26 20:45:52.659+0900 E/TIMER   (26038): (!ad->setting_time) -> _start_clicked_cb() return
05-26 20:45:52.749+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11263236 button=1 downs=1
05-26 20:45:52.804+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11263290 button=1 downs=0
05-26 20:45:52.804+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:45:52.804+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x437b7610, elm_layout, func : 0x414607d1
05-26 20:45:52.804+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:45:52.804+0900 D/TIMER   (26038): Setting time is 0
05-26 20:45:52.804+0900 E/TIMER   (26038): (!ad->setting_time) -> _start_clicked_cb() return
05-26 20:45:52.939+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11263392 button=1 downs=1
05-26 20:45:52.939+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11263424 button=1 downs=0
05-26 20:45:53.269+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:53.284+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:53.319+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:54.444+0900 I/efl-extension(26038): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x437b7610
05-26 20:45:54.444+0900 I/efl-extension(26038): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x437b7610, obj: 0x437b7610
05-26 20:45:54.444+0900 I/efl-extension(26038): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 20:45:54.639+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11265121 button=1 downs=1
05-26 20:45:54.704+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11265191 button=1 downs=0
05-26 20:45:54.704+0900 D/TIMER   (26038): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 20:45:54.704+0900 D/TIMER   (26038): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 20:45:54.714+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 20:45:54.714+0900 I/efl-extension(26038): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437b7790, elm_layout, _activated_obj : 0x0, activated : 1
05-26 20:45:55.384+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11265869 button=1 downs=1
05-26 20:45:55.464+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11265951 button=1 downs=0
05-26 20:45:55.844+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11266331 button=1 downs=1
05-26 20:45:55.909+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11266396 button=1 downs=0
05-26 20:45:56.369+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11266854 button=1 downs=1
05-26 20:45:56.409+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11266898 button=1 downs=0
05-26 20:45:56.764+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11267247 button=1 downs=1
05-26 20:45:56.819+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11267305 button=1 downs=0
05-26 20:45:57.124+0900 E/EFL     (26038): evas_main<26038> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11267611 button=1 downs=1
05-26 20:45:57.184+0900 E/EFL     (26038): evas_main<26038> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11267669 button=1 downs=0
05-26 20:45:57.629+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.629+0900 I/efl-extension(26038): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.629+0900 I/efl-extension(26038): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b7790, elm_layout, time_stamp : 11268115
05-26 20:45:57.674+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.674+0900 I/efl-extension(26038): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.674+0900 I/efl-extension(26038): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b7790, elm_layout, time_stamp : 11268161
05-26 20:45:57.699+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.699+0900 I/efl-extension(26038): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.699+0900 I/efl-extension(26038): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b7790, elm_layout, time_stamp : 11268183
05-26 20:45:57.719+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.719+0900 I/efl-extension(26038): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.719+0900 I/efl-extension(26038): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b7790, elm_layout, time_stamp : 11268205
05-26 20:45:57.744+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.749+0900 I/efl-extension(26038): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.749+0900 I/efl-extension(26038): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b7790, elm_layout, time_stamp : 11268232
05-26 20:45:57.769+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.769+0900 I/efl-extension(26038): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.769+0900 I/efl-extension(26038): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b7790, elm_layout, time_stamp : 11268256
05-26 20:45:57.799+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.799+0900 I/efl-extension(26038): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.799+0900 I/efl-extension(26038): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b7790, elm_layout, time_stamp : 11268284
05-26 20:45:57.849+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.849+0900 I/efl-extension(26038): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.849+0900 I/efl-extension(26038): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b7790, elm_layout, time_stamp : 11268337
05-26 20:45:57.959+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.964+0900 I/efl-extension(26038): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:45:57.964+0900 I/efl-extension(26038): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b7790, elm_layout, time_stamp : 11268448
05-26 20:45:59.359+0900 I/efl-extension(26038): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x437b7790
05-26 20:45:59.359+0900 I/efl-extension(26038): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x437b7790, obj: 0x437b7790
05-26 20:45:59.359+0900 I/efl-extension(26038): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 20:45:59.359+0900 I/efl-extension(26038): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 20:45:59.359+0900 I/efl-extension(26038): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 20:45:59.359+0900 I/efl-extension(26038): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 20:45:59.579+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-26 20:45:59.579+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-26 20:45:59.579+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-26 20:45:59.579+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-26 20:45:59.674+0900 W/STARTER (  696): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-26 20:45:59.759+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-26 20:45:59.759+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-26 20:45:59.759+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-26 20:45:59.759+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-26 20:45:59.854+0900 W/STARTER (  696): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-26 20:46:00.114+0900 W/STARTER (  696): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-26 20:46:00.119+0900 W/STARTER (  696): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-26 20:46:00.144+0900 E/STARTER (  696): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-26 20:46:00.144+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 20:46:00.154+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(1702) > caller pid : 696
05-26 20:46:00.159+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 20:46:00.159+0900 W/AUL_PAD (24473): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 20:46:00.159+0900 W/AUL_PAD (24473): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 20:46:00.174+0900 E/RESOURCED(  475): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 20:46:00.174+0900 I/CAPI_APPFW_APPLICATION(26772): app_main.c: app_efl_main(129) > app_efl_main
05-26 20:46:00.179+0900 I/CAPI_APPFW_APPLICATION(26772): app_main.c: app_appcore_create(152) > app_appcore_create
05-26 20:46:00.264+0900 E/AUL     (  696): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 20:46:00.264+0900 E/RESOURCED(  475): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-26 20:46:00.349+0900 I/efl-extension(26772): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445dda88 = w: 0 h: 0  obj 0x445beb78 w: 360 h: 360
05-26 20:46:00.349+0900 I/efl-extension(26772): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-26 20:46:00.349+0900 I/efl-extension(26772): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 20:46:00.349+0900 I/efl-extension(26772): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 20:46:00.349+0900 I/efl-extension(26772): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 20:46:00.359+0900 I/efl-extension(26772): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 20:46:00.359+0900 I/efl-extension(26772): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445beb78, elm_image, _activated_obj : 0x0, activated : 1
05-26 20:46:00.389+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 20:46:00.459+0900 E/W_TASKMANAGER(26772): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-26 20:46:00.464+0900 E/W_TASKMANAGER(26772): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-26 20:46:00.464+0900 E/W_TASKMANAGER(26772): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-26 20:46:00.509+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.509+0900 E/W_TASKMANAGER(26772): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:46:00.514+0900 E/RUA     (26772): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 28, ncols : 5
05-26 20:46:00.544+0900 E/EFL     (26772): elementary<26772> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c07f8 into part 'elm.swallow.event.0'
05-26 20:46:00.554+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 20:46:00.554+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 20:46:00.554+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : pedometer_inactive_period error
05-26 20:46:00.554+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 20:46:00.554+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 20:46:00.554+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_10min_precaution_millisec error
05-26 20:46:00.554+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 20:46:00.554+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 20:46:00.554+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_before_10min_precaution_millisec error
05-26 20:46:00.584+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05200003)
05-26 20:46:00.594+0900 I/APP_CORE(26772): appcore-efl.c: __do_app(429) > [APP 26772] Event: RESET State: CREATED
05-26 20:46:00.594+0900 I/CAPI_APPFW_APPLICATION(26772): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 20:46:00.609+0900 I/APP_CORE(26772): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 20:46:00.609+0900 I/APP_CORE(26772): appcore-efl.c: __do_app(474) > [APP 26772] Initial Launching, call the resume_cb
05-26 20:46:00.609+0900 I/CAPI_APPFW_APPLICATION(26772): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 20:46:00.649+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x05200003)
05-26 20:46:00.649+0900 W/APP_CORE(26772): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200003
05-26 20:46:00.719+0900 I/APP_CORE(26038): appcore-efl.c: __do_app(429) > [APP 26038] Event: PAUSE State: RUNNING
05-26 20:46:00.719+0900 I/CAPI_APPFW_APPLICATION(26038): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-26 20:46:00.729+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 20:46:00.729+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 20:46:00.749+0900 I/APP_CORE(26772): appcore-efl.c: __do_app(429) > [APP 26772] Event: RESUME State: RUNNING
05-26 20:46:01.139+0900 E/AUL     (  474): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 20:46:01.184+0900 I/MALI    (26772): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-26 20:46:01.244+0900 E/EFL     (26772): evas_main<26772> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11271724 button=1 downs=1
05-26 20:46:01.289+0900 E/EFL     (26772): evas_main<26772> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11271773 button=1 downs=0
05-26 20:46:01.324+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 20:46:01.334+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26772
05-26 20:46:01.339+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 20:46:01.549+0900 E/EFL     (26772): elementary<26772> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573630), freeze(1)
05-26 20:46:01.549+0900 E/EFL     (26772): elementary<26772> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573630), freeze(1)
05-26 20:46:01.714+0900 I/efl-extension(26934): efl_extension.c: eext_mod_init(40) > Init
05-26 20:46:01.759+0900 I/UXT     (26934): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 20:46:01.879+0900 I/AUL_PAD (26934): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 20:46:01.909+0900 E/TBM     (26934): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 20:46:01.924+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 20:46:01.934+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26038
05-26 20:46:01.939+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 27
05-26 20:46:01.944+0900 I/APP_CORE(26038): appcore-efl.c: __do_app(429) > [APP 26038] Event: TERMINATE State: PAUSED
05-26 20:46:01.944+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 20:46:01.944+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 20:46:01.964+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 20:46:01.964+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 20:46:01.969+0900 E/APP_CORE(26772): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-26 20:46:01.969+0900 I/APP_CORE(26772): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 20:46:01.969+0900 I/APP_CORE(26772): appcore-efl.c: __after_loop(1090) > [APP 26772] PAUSE before termination
05-26 20:46:01.969+0900 I/CAPI_APPFW_APPLICATION(26772): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 20:46:01.969+0900 I/CAPI_APPFW_APPLICATION(26772): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-26 20:46:01.969+0900 I/efl-extension(26772): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44573630, obj: 0x44573630
05-26 20:46:01.969+0900 I/efl-extension(26772): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 20:46:01.969+0900 I/efl-extension(26772): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 20:46:01.969+0900 I/efl-extension(26772): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 20:46:01.969+0900 I/efl-extension(26772): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 20:46:01.974+0900 I/efl-extension(26772): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445beb78
05-26 20:46:01.974+0900 I/efl-extension(26772): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-26 20:46:01.974+0900 I/efl-extension(26772): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445dda88 is freed
05-26 20:46:01.974+0900 I/efl-extension(26772): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:46:01.974+0900 I/efl-extension(26772): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44573630, elm_scroller, func : 0x437c8ef1
05-26 20:46:01.974+0900 I/efl-extension(26772): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:46:01.974+0900 I/efl-extension(26772): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:46:01.974+0900 I/efl-extension(26772): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445beb78, elm_image, func : 0x437c8ef1
05-26 20:46:01.974+0900 I/efl-extension(26772): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:46:01.974+0900 I/efl-extension(26772): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44573630 : elm_scroller] rotary callabck is deleted
05-26 20:46:02.134+0900 I/APP_CORE(26038): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 20:46:02.134+0900 I/CAPI_APPFW_APPLICATION(26038): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 20:46:02.189+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 20:46:02.189+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 20:46:02.189+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 20:46:02.189+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:46:02.189+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:46:02.189+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:46:02.229+0900 I/MALI    (26772): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-26 20:46:02.234+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 20:46:02.234+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 20:46:02.334+0900 I/MALI    (26772): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 20:46:02.334+0900 I/MALI    (26772): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=26772   close drm_fd=22 
05-26 20:46:02.334+0900 I/MALI    (26772): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 20:46:02.369+0900 I/UXT     (26038): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 20:46:02.374+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 20:46:02.374+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.374+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.374+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.374+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 20:46:02.379+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-26 20:46:02.379+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 20:46:02.379+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.379+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-26 20:46:02.379+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESUME State: PAUSED
05-26 20:46:02.379+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 20:46:02.379+0900 W/W_HOME  (  726): main.c: _appcore_resume_cb(681) > appcore resume
05-26 20:46:02.379+0900 W/W_HOME  (  726): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 20:46:02.379+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.379+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.379+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.379+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 20:46:02.379+0900 W/W_HOME  (  726): rotary.c: rotary_attach(138) > rotary_attach:0x478904a8
05-26 20:46:02.379+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x478904a8, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-26 20:46:02.379+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 20:46:02.384+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 20:46:02.384+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 20:46:02.384+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 20:46:02.384+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 20:46:02.389+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 20:46:02.389+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 20:46:02.389+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 20:46:02.424+0900 I/UXT     (26772): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 20:46:02.494+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:46:02.494+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:46:02.494+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:46:02.494+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:46:02.494+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:46:02.514+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-26 20:46:02.514+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-26 20:46:02.514+0900 W/W_HOME  (  726): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-26 20:46:02.514+0900 W/W_HOME  (  726): gesture.c: _manual_render_enable(133) > 1
05-26 20:46:02.514+0900 W/W_HOME  (  726): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-26 20:46:02.514+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.514+0900 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
05-26 20:46:02.514+0900 W/STARTER (  696): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-26 20:46:02.514+0900 E/STARTER (  696): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-26 20:46:02.514+0900 W/STARTER (  696): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-26 20:46:02.514+0900 W/STARTER (  696): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-26 20:46:02.519+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-26 20:46:02.519+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-26 20:46:02.519+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-26 20:46:02.524+0900 I/TIZEN_N_SOUND_MANAGER( 1090): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-26 20:46:02.524+0900 I/TIZEN_N_SOUND_MANAGER( 1090): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-26 20:46:02.524+0900 W/TIZEN_N_SOUND_MANAGER( 1090): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-26 20:46:02.524+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-26 20:46:02.524+0900 I/HIGEAR  ( 1090): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-26 20:46:02.679+0900 I/efl-extension(26772): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-26 20:46:02.724+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: PAUSE State: RUNNING
05-26 20:46:02.724+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 20:46:02.724+0900 W/W_HOME  (  726): main.c: _appcore_pause_cb(690) > appcore pause
05-26 20:46:02.724+0900 W/W_HOME  (  726): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 20:46:02.724+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.724+0900 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
05-26 20:46:02.724+0900 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-26 20:46:02.724+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.724+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 20:46:02.724+0900 W/W_HOME  (  726): rotary.c: rotary_deattach(156) > rotary_deattach:0x478904a8
05-26 20:46:02.724+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:46:02.724+0900 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-26 20:46:02.724+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x478904a8, elm_layout, func : 0x4004b469
05-26 20:46:02.724+0900 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-26 20:46:02.724+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 20:46:02.724+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 20:46:02.724+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:46:02.724+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x478904a8, activated : 1
05-26 20:46:02.724+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 20:46:02.724+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 20:46:02.724+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 20:46:02.734+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:46:02.734+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:46:02.734+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:46:02.734+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 20:46:02.734+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 20:46:02.734+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:46:02.734+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 20:46:02.734+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:46:02.749+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:46:02.749+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:46:02.749+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:46:02.749+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 20:46:02.749+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 20:46:02.749+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:46:02.749+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 20:46:02.749+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 20:46:02.749+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 20:46:02.749+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:46:02.749+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 20:46:02.749+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 20:46:02.749+0900 E/ALARM_MANAGER(  696): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(26-5-2016, 20:46:23), repeat(1), interval(20), type(-1073741822)
05-26 20:46:02.759+0900 W/ALARM_MANAGER(  470): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-26 20:46:02.759+0900 W/ALARM_MANAGER(  470): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-26 20:46:02.819+0900 I/SHealth_Common( 1056): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-26 20:46:02.819+0900 I/SHealth_Service( 1056): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-26 20:46:02.849+0900 W/APPS    (  726): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 20:46:02.884+0900 E/ALARM_MANAGER(  470): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 278035774, next duetime: 1464263183
05-26 20:46:02.884+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(278035774)
05-26 20:46:02.884+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464264709), due_time(1464263183)
05-26 20:46:02.884+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-26 20:46:02.884+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 26-5-2016, 11:46:23 (UTC).
05-26 20:46:02.884+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-26 20:46:02.894+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1445]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-26 20:46:02.894+0900 E/CAPI_APPFW_APP_CONTROL( 1445): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 20:46:02.894+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1445]   [com.samsung.w-home]register msg port [false][0m
05-26 20:46:02.904+0900 W/CRASH_MANAGER(26940): worker.c: worker_job(1199) > 1126038706831146426316
