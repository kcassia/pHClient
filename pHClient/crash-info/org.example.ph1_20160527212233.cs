S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 18804
Date: 2016-05-27 21:22:33+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x453c6290, r5   = 0x41561d89
r6   = 0x453c6b90, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x453c5510
r10  = 0x41885ba8, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbecc6630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     15816 KB
Buffers:     42172 KB
Cached:     139088 KB
VmPeak:     101940 KB
VmSize:      94600 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28172 KB
VmRSS:       25960 KB
VmData:      40184 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23960 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 18804 TID = 18804
18804 18833 18953 

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
43857000 4385b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44201000 44a00000 rwxp [stack:18953]
44b21000 44b24000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44b2c000 44b64000 r-xp /usr/lib/libpulse.so.0.16.2
44b94000 45393000 rwxp [stack:18833]
459ce000 459d3000 r-xp /usr/lib/libjson.so.0.0.1
459db000 45a23000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a24000 45a67000 r-xp /usr/lib/libsndfile.so.1.0.25
45a74000 45a96000 r-xp /usr/lib/libvorbis.so.0.4.3
45a9e000 45aa2000 r-xp /usr/lib/libogg.so.0.7.1
beca6000 becc7000 rwxp [stack]
End of Maps Information

Callstack Information (PID:18804)
Call Stack Count: 2
 0: cfree + 0xc8 (0x404e41e8) [/lib/libc.so.6] + 0x6f1e8
 1: (0x16800) (null)
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
ection: Clockwise
05-27 21:22:09.343+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.343+0900 I/efl-extension(18804): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44106a30, elm_layout, time_stamp : 7850280
05-27 21:22:09.373+0900 I/efl-extension(18804): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.373+0900 I/efl-extension(18804): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44106a30, elm_layout, time_stamp : 7850311
05-27 21:22:09.373+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.393+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.398+0900 I/efl-extension(18804): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.398+0900 I/efl-extension(18804): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44106a30, elm_layout, time_stamp : 7850332
05-27 21:22:09.428+0900 I/efl-extension(18804): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.428+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.428+0900 I/efl-extension(18804): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44106a30, elm_layout, time_stamp : 7850364
05-27 21:22:09.463+0900 I/efl-extension(18804): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.463+0900 I/efl-extension(18804): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44106a30, elm_layout, time_stamp : 7850402
05-27 21:22:09.463+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.503+0900 I/efl-extension(18804): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.503+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.508+0900 I/efl-extension(18804): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44106a30, elm_layout, time_stamp : 7850443
05-27 21:22:09.548+0900 I/efl-extension(18804): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.548+0900 I/efl-extension(18804): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44106a30, elm_layout, time_stamp : 7850484
05-27 21:22:09.548+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.598+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.598+0900 I/efl-extension(18804): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.598+0900 I/efl-extension(18804): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44106a30, elm_layout, time_stamp : 7850538
05-27 21:22:09.678+0900 I/efl-extension(18804): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.678+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 21:22:09.678+0900 I/efl-extension(18804): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44106a30, elm_layout, time_stamp : 7850613
05-27 21:22:10.333+0900 E/EFL     (18804): evas_main<18804> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7851270 button=1 downs=1
05-27 21:22:10.358+0900 E/EFL     (18804): evas_main<18804> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7851295 button=1 downs=0
05-27 21:22:11.338+0900 E/EFL     (18804): evas_main<18804> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7852274 button=1 downs=1
05-27 21:22:11.403+0900 E/EFL     (18804): evas_main<18804> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7852340 button=1 downs=0
05-27 21:22:11.403+0900 D/TIMER   (18804): Setting time is 35
05-27 21:22:11.403+0900 I/efl-extension(18804): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 21:22:11.403+0900 I/efl-extension(18804): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44106a30, elm_layout, func : 0x415608d9
05-27 21:22:11.403+0900 I/efl-extension(18804): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 21:22:11.403+0900 I/efl-extension(18804): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 21:22:11.403+0900 I/efl-extension(18804): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 21:22:11.403+0900 I/efl-extension(18804): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 21:22:11.403+0900 I/efl-extension(18804): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 21:22:11.403+0900 I/efl-extension(18804): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 21:22:11.413+0900 I/SOCKETTEST(18804): Success to create socket
05-27 21:22:11.468+0900 I/SOCKETTEST(18804): Success to socket connection
05-27 21:22:11.468+0900 I/SOCKETTEST(18804): write() 성공
05-27 21:22:11.503+0900 I/SENSOR  (18804): -4.550000, -9.310000, 7.070000
05-27 21:22:11.563+0900 I/SENSOR  (18804): -1.190000, -4.410000, 4.340000
05-27 21:22:11.683+0900 I/SENSOR  (18804): -0.210000, -4.340000, 4.620000
05-27 21:22:11.768+0900 I/SENSOR  (18804): -0.980000, -3.430000, 3.990000
05-27 21:22:11.873+0900 I/SENSOR  (18804): -3.010000, -5.600000, 5.250000
05-27 21:22:11.968+0900 I/SENSOR  (18804): 2.100000, -1.680000, 3.920000
05-27 21:22:12.178+0900 I/SENSOR  (18804): -1.050000, -1.750000, 3.850000
05-27 21:22:12.178+0900 I/SENSOR  (18804): -3.150000, -3.920000, 4.760000
05-27 21:22:12.268+0900 I/SENSOR  (18804): -10.990000, -6.510000, 5.740000
05-27 21:22:12.373+0900 I/SENSOR  (18804): -111.580002, -78.820000, 48.230000
05-27 21:22:12.583+0900 I/SENSOR  (18804): -30.590000, -94.570000, 92.190002
05-27 21:22:12.583+0900 I/SENSOR  (18804): -99.610001, -80.919998, 51.099998
05-27 21:22:12.713+0900 I/SENSOR  (18804): -1275.119995, -230.369995, 10.640000
05-27 21:22:12.713+0900 I/SENSOR  (18804): 앞으로 
05-27 21:22:12.718+0900 I/SOCKETTEST(18804): Success to create socket
05-27 21:22:12.973+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:12.973+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:12.973+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:12.973+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:12.973+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:13.903+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:13.908+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:13.908+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:13.908+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:13.908+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:13.923+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 21:22:13.928+0900 I/SOCKETTEST(18804): Success to socket connection
05-27 21:22:13.938+0900 I/SOCKETTEST(18804): write() 성공
05-27 21:22:14.003+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 21:22:14.023+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 21:22:14.048+0900 I/SENSOR  (18804): 310.029999, 9.310000, -26.670000
05-27 21:22:14.048+0900 I/SENSOR  (18804): 240.940002, 44.380001, 53.970001
05-27 21:22:14.048+0900 I/SENSOR  (18804): 851.059998, 136.220001, -41.860001
05-27 21:22:14.048+0900 I/SENSOR  (18804): 114.099998, 43.889999, -33.110001
05-27 21:22:14.048+0900 I/SENSOR  (18804): 75.459999, 31.360001, -3.990000
05-27 21:22:14.048+0900 I/SENSOR  (18804): 30.520000, 12.110000, -3.710000
05-27 21:22:14.048+0900 I/SENSOR  (18804): 29.120001, 10.990000, -7.280000
05-27 21:22:14.048+0900 I/SENSOR  (18804): 25.270000, 7.000000, -13.580000
05-27 21:22:14.048+0900 I/SENSOR  (18804): 23.870001, 5.390000, -16.799999
05-27 21:22:14.048+0900 I/SENSOR  (18804): 14.630000, 1.400000, -11.270000
05-27 21:22:14.053+0900 I/SENSOR  (18804): -3.920000, -8.540000, 1.260000
05-27 21:22:14.053+0900 I/SENSOR  (18804): -111.650002, -26.950001, 53.830002
05-27 21:22:14.053+0900 I/SENSOR  (18804): -1955.729980, -452.200012, -57.889999
05-27 21:22:14.058+0900 I/SENSOR  (18804): 앞으로 
05-27 21:22:14.058+0900 I/SOCKETTEST(18804): Success to create socket
05-27 21:22:14.058+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 21:22:14.128+0900 I/SOCKETTEST(18804): Success to socket connection
05-27 21:22:14.128+0900 I/SOCKETTEST(18804): write() 성공
05-27 21:22:14.238+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:14.238+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:14.243+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:14.243+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:14.243+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:14.253+0900 I/SENSOR  (18804): 181.860001, 3.920000, 28.420000
05-27 21:22:14.253+0900 I/SENSOR  (18804): 533.260010, 61.389999, 39.340000
05-27 21:22:14.288+0900 I/SENSOR  (18804): 544.390015, 97.440002, -26.460001
05-27 21:22:14.368+0900 I/SENSOR  (18804): 257.809998, 99.330002, -28.630001
05-27 21:22:14.468+0900 I/SENSOR  (18804): -107.590004, 132.649994, 4.690000
05-27 21:22:14.568+0900 I/SENSOR  (18804): 27.580000, 13.720000, 5.810000
05-27 21:22:14.668+0900 I/SENSOR  (18804): 12.460000, 7.700000, 3.150000
05-27 21:22:14.773+0900 I/SENSOR  (18804): 0.630000, -8.330000, 5.530000
05-27 21:22:14.878+0900 I/SENSOR  (18804): -12.950000, -9.590000, 5.740000
05-27 21:22:15.088+0900 I/SENSOR  (18804): -1.260000, -1.680000, 3.780000
05-27 21:22:15.088+0900 I/SENSOR  (18804): -2.100000, -2.730000, 4.550000
05-27 21:22:15.168+0900 I/SENSOR  (18804): 7.560000, -3.010000, 3.220000
05-27 21:22:15.273+0900 I/SENSOR  (18804): 108.849998, 7.910000, -25.900000
05-27 21:22:15.383+0900 I/SENSOR  (18804): -30.170000, -68.949997, 48.439999
05-27 21:22:15.508+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:15.508+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 21:22:15.513+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:15.533+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:15.533+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:15.548+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:15.553+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 21:22:15.633+0900 I/SENSOR  (18804): -1581.020020, -341.390015, -43.259998
05-27 21:22:15.633+0900 I/SENSOR  (18804): 앞으로 
05-27 21:22:15.638+0900 I/SOCKETTEST(18804): Success to create socket
05-27 21:22:15.638+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 21:22:15.638+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 21:22:15.643+0900 I/SOCKETTEST(18804): Success to socket connection
05-27 21:22:15.643+0900 I/SOCKETTEST(18804): write() 성공
05-27 21:22:15.643+0900 I/SENSOR  (18804): 383.529999, 37.660000, 19.320000
05-27 21:22:15.678+0900 I/SENSOR  (18804): 676.479980, 144.479996, 18.969999
05-27 21:22:15.773+0900 I/SENSOR  (18804): 416.989990, 117.529999, -28.770000
05-27 21:22:15.873+0900 I/SENSOR  (18804): -102.760002, -47.670002, 14.140000
05-27 21:22:15.978+0900 I/SENSOR  (18804): 2.870000, 3.150000, 5.250000
05-27 21:22:16.073+0900 I/SENSOR  (18804): 3.850000, -8.820000, 6.440000
05-27 21:22:16.263+0900 I/SENSOR  (18804): 1.330000, -9.520000, 4.830000
05-27 21:22:16.278+0900 I/SENSOR  (18804): 4.200000, -4.270000, 3.570000
05-27 21:22:16.373+0900 I/SENSOR  (18804): 7.560000, -1.330000, 3.080000
05-27 21:22:16.578+0900 I/SENSOR  (18804): 10.220000, -8.400000, 1.050000
05-27 21:22:16.578+0900 I/SENSOR  (18804): 64.959999, -10.990000, -0.210000
05-27 21:22:16.673+0900 I/SENSOR  (18804): 0.630000, -63.910000, 28.980000
05-27 21:22:16.848+0900 I/SENSOR  (18804): -1516.199951, -256.059998, -48.439999
05-27 21:22:16.848+0900 I/SENSOR  (18804): 앞으로 
05-27 21:22:16.848+0900 I/SOCKETTEST(18804): Success to create socket
05-27 21:22:16.858+0900 I/SOCKETTEST(18804): Success to socket connection
05-27 21:22:16.858+0900 I/SOCKETTEST(18804): write() 성공
05-27 21:22:16.868+0900 I/SENSOR  (18804): 188.509995, 26.740000, 43.259998
05-27 21:22:16.903+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:16.903+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:16.903+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:16.903+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:16.903+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:16.913+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 21:22:16.938+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 21:22:16.938+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 21:22:16.963+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 21:22:16.973+0900 I/SENSOR  (18804): 970.619995, 184.100006, 34.650002
05-27 21:22:17.068+0900 I/SENSOR  (18804): 509.529999, 150.220001, -27.510000
05-27 21:22:17.173+0900 I/SENSOR  (18804): -220.990005, -30.240000, 28.770000
05-27 21:22:17.273+0900 I/SENSOR  (18804): 35.000000, 10.360000, 1.260000
05-27 21:22:17.428+0900 I/SENSOR  (18804): 8.750000, -0.420000, 5.950000
05-27 21:22:17.533+0900 I/SENSOR  (18804): 8.750000, -6.790000, 4.830000
05-27 21:22:17.573+0900 I/SENSOR  (18804): -2.380000, -5.600000, 4.200000
05-27 21:22:17.678+0900 I/SENSOR  (18804): -13.580000, -16.520000, -2.590000
05-27 21:22:17.778+0900 I/SENSOR  (18804): 67.199997, -32.830002, 22.330000
05-27 21:22:17.873+0900 I/SENSOR  (18804): -910.210022, -148.539993, 18.270000
05-27 21:22:18.023+0900 I/SENSOR  (18804): -163.729996, -46.410000, -21.350000
05-27 21:22:18.073+0900 I/SENSOR  (18804): 361.059998, 71.889999, 47.320000
05-27 21:22:18.118+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:18.118+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:18.123+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:18.123+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:18.123+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:18.173+0900 I/SENSOR  (18804): 418.320007, 135.380005, 7.910000
05-27 21:22:18.273+0900 I/SENSOR  (18804): -7.070000, -10.430000, 9.590000
05-27 21:22:18.373+0900 I/SENSOR  (18804): 3.640000, -5.180000, 0.350000
05-27 21:22:18.493+0900 I/SENSOR  (18804): -2.660000, -4.480000, 7.070000
05-27 21:22:18.573+0900 I/SENSOR  (18804): -3.640000, -5.180000, 4.270000
05-27 21:22:18.673+0900 I/SENSOR  (18804): -0.980000, -3.080000, 4.620000
05-27 21:22:18.773+0900 I/SENSOR  (18804): 0.700000, -3.990000, 3.780000
05-27 21:22:18.883+0900 I/SENSOR  (18804): -2.380000, -3.500000, 4.550000
05-27 21:22:18.983+0900 I/SENSOR  (18804): -2.240000, -4.410000, 4.760000
05-27 21:22:19.188+0900 I/SENSOR  (18804): -3.010000, -2.870000, 5.110000
05-27 21:22:19.188+0900 I/SENSOR  (18804): 1.820000, -6.370000, 3.150000
05-27 21:22:19.273+0900 I/SENSOR  (18804): 148.889999, -8.750000, -14.350000
05-27 21:22:19.383+0900 I/SENSOR  (18804): 143.919998, -35.000000, 11.270000
05-27 21:22:19.538+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:19.538+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:19.538+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:19.538+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:19.538+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:19.548+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 21:22:19.623+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 21:22:19.643+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 21:22:19.658+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 21:22:19.658+0900 I/SENSOR  (18804): -284.829987, -39.900002, 46.900002
05-27 21:22:19.663+0900 I/SENSOR  (18804): -602.700012, -129.990005, -44.450001
05-27 21:22:19.708+0900 I/SENSOR  (18804): 189.279999, 52.360001, 85.959999
05-27 21:22:19.773+0900 I/SENSOR  (18804): 667.450012, 156.520004, 27.020000
05-27 21:22:19.873+0900 I/SENSOR  (18804): -83.090004, 70.489998, 38.779999
05-27 21:22:19.983+0900 I/SENSOR  (18804): 8.330000, 14.140000, -2.100000
05-27 21:22:20.083+0900 I/SENSOR  (18804): 19.879999, 0.770000, 6.090000
05-27 21:22:20.178+0900 I/SENSOR  (18804): -5.670000, -11.060000, 3.570000
05-27 21:22:20.333+0900 I/SENSOR  (18804): -9.800000, -6.510000, 4.480000
05-27 21:22:20.373+0900 I/SENSOR  (18804): -5.600000, -5.320000, 4.270000
05-27 21:22:20.598+0900 I/SENSOR  (18804): -8.190000, -6.230000, 4.550000
05-27 21:22:20.598+0900 I/SENSOR  (18804): 3.290000, -4.900000, 3.920000
05-27 21:22:20.678+0900 I/SENSOR  (18804): -0.910000, -4.760000, 3.500000
05-27 21:22:20.778+0900 I/SENSOR  (18804): 5.180000, -4.900000, 2.240000
05-27 21:22:20.938+0900 I/SENSOR  (18804): 78.750000, -15.820000, -2.240000
05-27 21:22:20.973+0900 I/SENSOR  (18804): -29.680000, -88.129997, 26.389999
05-27 21:22:21.078+0900 I/SENSOR  (18804): -810.039978, -178.850006, 35.630001
05-27 21:22:21.183+0900 I/SENSOR  (18804): 49.700001, -54.950001, -35.700001
05-27 21:22:21.283+0900 I/SENSOR  (18804): 198.869995, 52.920002, 59.570000
05-27 21:22:21.378+0900 I/SENSOR  (18804): 557.059998, 137.830002, -12.040000
05-27 21:22:21.503+0900 I/SENSOR  (18804): 328.860016, 118.090004, -40.320000
05-27 21:22:21.578+0900 I/SENSOR  (18804): -71.260002, 5.250000, 15.400000
05-27 21:22:21.673+0900 I/SENSOR  (18804): -2.310000, -3.920000, 3.430000
05-27 21:22:21.783+0900 I/SENSOR  (18804): 26.460001, 1.680000, 9.100000
05-27 21:22:21.878+0900 I/SENSOR  (18804): 101.290001, 23.590000, -19.600000
05-27 21:22:22.083+0900 I/SENSOR  (18804): 84.349998, -35.910000, 18.410000
05-27 21:22:22.083+0900 I/SENSOR  (18804): -1164.589966, -250.320007, -21.070000
05-27 21:22:22.088+0900 I/SENSOR  (18804): 앞으로 
05-27 21:22:22.088+0900 I/SOCKETTEST(18804): Success to create socket
05-27 21:22:22.098+0900 I/SOCKETTEST(18804): Success to socket connection
05-27 21:22:22.098+0900 I/SOCKETTEST(18804): write() 성공
05-27 21:22:22.178+0900 I/SENSOR  (18804): -58.590000, -31.920000, -28.910000
05-27 21:22:22.283+0900 I/SENSOR  (18804): 339.429993, 51.799999, 63.630001
05-27 21:22:22.383+0900 I/SENSOR  (18804): 681.169983, 134.960007, -7.700000
05-27 21:22:22.573+0900 I/SENSOR  (18804): -251.860001, 2.660000, 26.180000
05-27 21:22:22.603+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:22.603+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:22.603+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:22.603+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:22.603+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:22.658+0900 I/SENSOR  (18804): -16.379999, 14.560000, 2.380000
05-27 21:22:22.673+0900 I/SENSOR  (18804): 6.510000, -8.330000, 4.550000
05-27 21:22:22.778+0900 I/SENSOR  (18804): -3.990000, -10.150000, 3.850000
05-27 21:22:22.878+0900 I/SENSOR  (18804): -12.880000, -7.140000, 4.130000
05-27 21:22:22.978+0900 I/SENSOR  (18804): -3.080000, -2.030000, 4.550000
05-27 21:22:23.078+0900 I/SENSOR  (18804): -3.150000, -3.220000, 4.340000
05-27 21:22:23.248+0900 I/SENSOR  (18804): 4.200000, -4.270000, 4.970000
05-27 21:22:23.278+0900 I/SENSOR  (18804): 1.120000, -1.330000, 4.480000
05-27 21:22:23.383+0900 I/SENSOR  (18804): -1.540000, -1.540000, 4.760000
05-27 21:22:23.593+0900 I/SENSOR  (18804): 0.700000, -4.270000, 4.060000
05-27 21:22:23.593+0900 I/SENSOR  (18804): 0.910000, -2.730000, 4.690000
05-27 21:22:23.678+0900 I/SENSOR  (18804): -0.490000, -3.990000, 4.200000
05-27 21:22:23.833+0900 I/SENSOR  (18804): -0.350000, -4.410000, 3.920000
05-27 21:22:23.878+0900 I/SENSOR  (18804): 4.340000, -3.080000, 2.940000
05-27 21:22:23.988+0900 I/SENSOR  (18804): -8.820000, -8.470000, -2.660000
05-27 21:22:24.083+0900 I/SENSOR  (18804): -92.889999, -78.750000, 16.520000
05-27 21:22:24.183+0900 I/SENSOR  (18804): 55.160000, -97.720001, -23.379999
05-27 21:22:24.283+0900 I/SENSOR  (18804): -247.869995, -105.349998, -5.180000
05-27 21:22:24.438+0900 I/SENSOR  (18804): -843.570007, -165.550003, -60.410000
05-27 21:22:24.518+0900 I/SENSOR  (18804): 181.789993, 33.670002, 63.910000
05-27 21:22:24.578+0900 I/SENSOR  (18804): 745.220032, 156.660004, -15.190001
05-27 21:22:24.628+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:24.628+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:24.633+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:24.633+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:24.633+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:24.678+0900 I/SENSOR  (18804): -5.670000, 96.110001, -26.670000
05-27 21:22:24.778+0900 I/SENSOR  (18804): -51.660000, 172.479996, 25.549999
05-27 21:22:24.878+0900 I/SENSOR  (18804): -76.300003, -51.380001, 2.870000
05-27 21:22:24.978+0900 I/SENSOR  (18804): -4.830000, -5.880000, -0.700000
05-27 21:22:25.078+0900 I/SENSOR  (18804): -6.720000, -6.720000, 4.410000
05-27 21:22:25.183+0900 I/SENSOR  (18804): -8.540000, -9.240000, 3.570000
05-27 21:22:25.283+0900 I/SENSOR  (18804): -12.950000, -11.130000, 2.520000
05-27 21:22:25.383+0900 I/SENSOR  (18804): 2.310000, -20.580000, 2.940000
05-27 21:22:25.513+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:25.513+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:25.518+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:25.518+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:25.518+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:25.523+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 21:22:25.543+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 21:22:25.643+0900 I/SENSOR  (18804): -1294.300049, -355.459991, -31.850000
05-27 21:22:25.643+0900 I/SENSOR  (18804): 앞으로 
05-27 21:22:25.643+0900 I/SOCKETTEST(18804): Success to create socket
05-27 21:22:25.648+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 21:22:25.648+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 21:22:25.713+0900 I/SOCKETTEST(18804): Success to socket connection
05-27 21:22:25.718+0900 I/SOCKETTEST(18804): write() 성공
05-27 21:22:25.718+0900 I/SENSOR  (18804): 283.290009, 78.470001, -77.629997
05-27 21:22:25.803+0900 I/SENSOR  (18804): 518.770020, 87.430000, 75.669998
05-27 21:22:25.803+0900 I/SENSOR  (18804): 493.149994, 143.500000, -7.490000
05-27 21:22:25.878+0900 I/SENSOR  (18804): -36.959999, 66.360001, -0.910000
05-27 21:22:25.988+0900 I/SENSOR  (18804): -1.540000, 12.180000, 17.150000
05-27 21:22:26.183+0900 I/SENSOR  (18804): 3.220000, 8.120000, 7.840000
05-27 21:22:26.183+0900 I/SENSOR  (18804): -26.460001, -6.510000, 19.110001
05-27 21:22:26.278+0900 I/SENSOR  (18804): -24.150000, -7.980000, 28.280001
05-27 21:22:26.388+0900 I/SENSOR  (18804): -27.510000, -5.180000, 40.950001
05-27 21:22:26.578+0900 I/SENSOR  (18804): -14.280000, 4.830000, 35.209999
05-27 21:22:26.583+0900 I/SENSOR  (18804): -6.650000, 11.550000, 27.790001
05-27 21:22:26.748+0900 I/SENSOR  (18804): -9.450000, 5.180000, 39.410000
05-27 21:22:26.783+0900 I/SENSOR  (18804): 12.320000, 4.270000, 35.910000
05-27 21:22:26.883+0900 I/SENSOR  (18804): 27.580000, -10.710000, 10.360000
05-27 21:22:26.988+0900 I/SENSOR  (18804): 42.980000, -22.540001, 16.100000
05-27 21:22:27.083+0900 I/SENSOR  (18804): 54.670002, -3.780000, 31.850000
05-27 21:22:27.188+0900 I/SENSOR  (18804): -1.190000, 27.860001, 26.530001
05-27 21:22:27.338+0900 I/SENSOR  (18804): -27.860001, 30.799999, 36.540001
05-27 21:22:27.383+0900 I/SENSOR  (18804): -54.670002, 13.510000, 53.060001
05-27 21:22:27.578+0900 I/SENSOR  (18804): -34.369999, 5.810000, 52.849998
05-27 21:22:27.583+0900 I/SENSOR  (18804): -29.120001, -5.880000, 44.590000
05-27 21:22:27.683+0900 I/SENSOR  (18804): -17.290001, 3.640000, 31.920000
05-27 21:22:27.788+0900 I/SENSOR  (18804): -13.230000, -4.480000, 20.090000
05-27 21:22:27.888+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:27.888+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:27.888+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:27.888+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:27.888+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:27.923+0900 I/SENSOR  (18804): -84.629997, -24.290001, 21.210001
05-27 21:22:27.983+0900 I/SENSOR  (18804): 7.700000, 4.480000, 6.090000
05-27 21:22:28.083+0900 I/SENSOR  (18804): 60.480000, 3.290000, -10.220000
05-27 21:22:28.183+0900 I/SENSOR  (18804): 114.590004, -37.310001, -27.719999
05-27 21:22:28.283+0900 I/SENSOR  (18804): 116.690002, -71.680000, -42.349998
05-27 21:22:28.508+0900 I/SENSOR  (18804): -1326.989990, -234.149994, -112.770004
05-27 21:22:28.508+0900 I/SENSOR  (18804): 앞으로 
05-27 21:22:28.513+0900 I/SOCKETTEST(18804): Success to create socket
05-27 21:22:28.553+0900 I/SOCKETTEST(18804): Success to socket connection
05-27 21:22:28.553+0900 I/SOCKETTEST(18804): write() 성공
05-27 21:22:28.558+0900 I/SENSOR  (18804): 406.769989, 145.250000, -22.260000
05-27 21:22:28.623+0900 I/SENSOR  (18804): 768.950012, 179.899994, 73.570000
05-27 21:22:28.658+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:28.658+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:28.663+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:28.663+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:28.663+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:28.683+0900 I/SENSOR  (18804): 411.529999, 165.690002, -22.400000
05-27 21:22:28.783+0900 I/SENSOR  (18804): 119.629997, 169.820007, 27.090000
05-27 21:22:28.883+0900 I/SENSOR  (18804): -40.389999, -68.739998, 15.820000
05-27 21:22:28.998+0900 I/SENSOR  (18804): -13.510000, -51.520000, 30.799999
05-27 21:22:29.083+0900 I/SENSOR  (18804): -49.490002, -75.180000, 46.200001
05-27 21:22:29.183+0900 I/SENSOR  (18804): -54.810001, -114.449997, 9.590000
05-27 21:22:29.288+0900 I/SENSOR  (18804): 36.400002, -48.790001, -25.620001
05-27 21:22:29.388+0900 I/SENSOR  (18804): -13.230000, -46.270000, -3.150000
05-27 21:22:29.573+0900 I/SENSOR  (18804): 9.800000, -20.160000, -29.260000
05-27 21:22:29.638+0900 I/SENSOR  (18804): 7.980000, -39.830002, -21.210001
05-27 21:22:29.693+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:29.693+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:29.698+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:29.698+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:29.698+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:29.708+0900 I/SENSOR  (18804): 0.420000, -54.180000, -19.180000
05-27 21:22:29.783+0900 I/SENSOR  (18804): -1617.699951, -279.579987, -74.830002
05-27 21:22:29.783+0900 I/SENSOR  (18804): 앞으로 
05-27 21:22:29.783+0900 I/SOCKETTEST(18804): Success to create socket
05-27 21:22:29.788+0900 I/SOCKETTEST(18804): Success to socket connection
05-27 21:22:29.788+0900 I/SOCKETTEST(18804): write() 성공
05-27 21:22:29.883+0900 I/SENSOR  (18804): 683.409973, 117.110001, -19.530001
05-27 21:22:29.983+0900 I/SENSOR  (18804): 876.750000, 162.610001, 56.209999
05-27 21:22:30.083+0900 I/SENSOR  (18804): 356.299988, 165.690002, -18.620001
05-27 21:22:30.088+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:30.088+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:30.093+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:30.093+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:30.093+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:30.098+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 21:22:30.098+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 21:22:30.098+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 21:22:30.098+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 21:22:30.183+0900 I/SENSOR  (18804): -16.030001, 10.360000, 7.700000
05-27 21:22:30.283+0900 I/SENSOR  (18804): -64.120003, -27.790001, 3.080000
05-27 21:22:30.388+0900 I/SENSOR  (18804): -21.490000, -36.680000, -11.970000
05-27 21:22:30.513+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:30.513+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:30.513+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:30.513+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:30.513+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:30.568+0900 I/SENSOR  (18804): 53.689999, -6.720000, -45.639999
05-27 21:22:30.583+0900 I/SENSOR  (18804): 173.529999, 86.870003, -103.459999
05-27 21:22:30.683+0900 I/SENSOR  (18804): 74.900002, 55.439999, -104.930000
05-27 21:22:30.753+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:30.753+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:30.753+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:30.753+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:30.753+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:30.753+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 21:22:30.753+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 21:22:30.758+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 21:22:30.758+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 21:22:30.783+0900 I/SENSOR  (18804): 5.460000, 9.800000, -18.620001
05-27 21:22:30.883+0900 I/SENSOR  (18804): -22.610001, -21.700001, 11.270000
05-27 21:22:30.983+0900 I/SENSOR  (18804): -8.050000, -5.390000, -0.770000
05-27 21:22:31.093+0900 I/SENSOR  (18804): -0.420000, -1.610000, -3.710000
05-27 21:22:31.193+0900 I/SENSOR  (18804): 2.030000, -2.590000, 0.560000
05-27 21:22:31.288+0900 I/SENSOR  (18804): -14.420000, -8.260000, -3.780000
05-27 21:22:31.358+0900 E/EFL     (18804): evas_main<18804> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7872253 button=1 downs=1
05-27 21:22:31.358+0900 E/EFL     (18804): evas_main<18804> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7872277 button=1 downs=0
05-27 21:22:31.363+0900 I/efl-extension(18804): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 21:22:31.363+0900 I/efl-extension(18804): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 21:22:31.363+0900 I/efl-extension(18804): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 21:22:31.383+0900 I/SOCKETTEST(18804): Success to create socket
05-27 21:22:31.388+0900 I/SOCKETTEST(18804): Success to socket connection
05-27 21:22:31.388+0900 I/SOCKETTEST(18804): write() 성공
05-27 21:22:31.863+0900 I/efl-extension(18804): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44106a30
05-27 21:22:31.863+0900 I/efl-extension(18804): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44106a30, obj: 0x44106a30
05-27 21:22:31.863+0900 I/efl-extension(18804): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 21:22:32.803+0900 I/CAPI_APPFW_APPLICATION(18804): app_main.c: ui_app_exit(715) > ui_app_exit
05-27 21:22:32.803+0900 I/CAPI_APPFW_APPLICATION(18804): app_main.c: app_efl_exit(145) > app_efl_exit
05-27 21:22:32.808+0900 I/CAPI_APPFW_APPLICATION(18804): app_main.c: ui_app_exit(715) > ui_app_exit
05-27 21:22:32.808+0900 I/CAPI_APPFW_APPLICATION(18804): app_main.c: app_efl_exit(145) > app_efl_exit
05-27 21:22:32.818+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 21:22:32.818+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 21:22:33.023+0900 I/APP_CORE(18804): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 21:22:33.023+0900 I/APP_CORE(18804): appcore-efl.c: __after_loop(1090) > [APP 18804] PAUSE before termination
05-27 21:22:33.038+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:33.038+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:33.038+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:33.038+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:33.038+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:33.043+0900 I/CAPI_APPFW_APPLICATION(18804): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-27 21:22:33.053+0900 I/CAPI_APPFW_APPLICATION(18804): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 21:22:33.093+0900 I/efl-extension(18804): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 21:22:33.093+0900 I/efl-extension(18804): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x458f3af8 is freed
05-27 21:22:33.108+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 21:22:33.108+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 21:22:33.108+0900 I/efl-extension(18804): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x41945c20 is freed
05-27 21:22:33.118+0900 I/efl-extension(18804): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x41871560 is freed
05-27 21:22:33.203+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-27 21:22:33.203+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-27 21:22:33.203+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 21:22:33.203+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:33.203+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:33.203+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:33.213+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 21:22:33.213+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:22:33.213+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:22:33.213+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:22:33.213+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 21:22:33.233+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 21:22:33.233+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 21:22:33.233+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:22:33.233+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 21:22:33.238+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-27 21:22:33.238+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 21:22:33.238+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-27 21:22:33.238+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-27 21:22:33.238+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:22:33.243+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:22:33.243+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:22:33.243+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 21:22:33.243+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x45d4d480
05-27 21:22:33.243+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d4d480, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 21:22:33.243+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 21:22:33.253+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 21:22:33.253+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 21:22:33.253+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 21:22:33.253+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 21:22:33.253+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 21:22:33.253+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 21:22:33.253+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 21:22:33.268+0900 I/UXT     (18804): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 21:22:33.698+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 21:22:33.713+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:22:33.713+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:22:33.713+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:22:33.713+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:22:33.713+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:22:33.753+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-27 21:22:33.758+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-27 21:22:33.758+0900 W/W_HOME  (  732): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-27 21:22:33.758+0900 W/W_HOME  (  732): gesture.c: _manual_render_enable(133) > 1
05-27 21:22:33.758+0900 W/W_HOME  (  732): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-27 21:22:33.758+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 21:22:33.758+0900 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
05-27 21:22:33.758+0900 W/STARTER (  711): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-27 21:22:33.758+0900 E/STARTER (  711): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-27 21:22:33.758+0900 W/STARTER (  711): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-27 21:22:33.758+0900 W/STARTER (  711): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-27 21:22:33.788+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-27 21:22:33.793+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-27 21:22:33.793+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-27 21:22:33.793+0900 I/TIZEN_N_SOUND_MANAGER( 1132): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-27 21:22:33.803+0900 I/TIZEN_N_SOUND_MANAGER( 1132): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-27 21:22:33.803+0900 W/TIZEN_N_SOUND_MANAGER( 1132): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-27 21:22:33.803+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-27 21:22:33.803+0900 I/HIGEAR  ( 1132): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-27 21:22:33.853+0900 W/CRASH_MANAGER(19574): worker.c: worker_job(1199) > 1118804706831146435175
