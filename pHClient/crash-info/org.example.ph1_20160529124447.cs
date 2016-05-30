S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 5705
Date: 2016-05-29 12:44:47+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x414e6208, r5   = 0x44973ff8
r6   = 0x4000c948, r7   = 0x00000000
r8   = 0x44972978, r9   = 0x41885588
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbed5e630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     40232 KB
Buffers:     48740 KB
Cached:     107672 KB
VmPeak:      97696 KB
VmSize:      90508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23956 KB
VmRSS:       21784 KB
VmData:      36088 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23964 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5705 TID = 5705
5705 5943 5993 

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
4155d000 41565000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
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
44092000 44891000 rwxp [stack:5993]
44b64000 45363000 rwxp [stack:5943]
458bb000 458be000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45931000 45969000 r-xp /usr/lib/libpulse.so.0.16.2
459de000 459e3000 r-xp /usr/lib/libjson.so.0.0.1
459eb000 45a33000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a34000 45a77000 r-xp /usr/lib/libsndfile.so.1.0.25
45a84000 45aa6000 r-xp /usr/lib/libvorbis.so.0.4.3
45aae000 45ab2000 r-xp /usr/lib/libogg.so.0.7.1
bed3e000 bed5f000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5705)
Call Stack Count: 2
 0: cfree + 0xc8 (0x404e41e8) [/lib/libc.so.6] + 0x6f1e8
 1: ((nil)) (null)
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
downs=1
05-29 12:44:22.311+0900 E/EFL     ( 5705): evas_main<5705> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12695626 button=1 downs=0
05-29 12:44:22.311+0900 I/PTESTResetClicked( 5705): 1start_clicked
05-29 12:44:22.311+0900 I/PTESTResetClicked( 5705): 2before if
05-29 12:44:22.311+0900 I/PTESTResetClicked( 5705): 4if
05-29 12:44:22.311+0900 D/TIMER   ( 5705): Setting time is 360
05-29 12:44:22.311+0900 I/ResetClicked( 5705): save_setting _time  : 360
05-29 12:44:22.331+0900 I/BUG     ( 5705): sett : 100, settiingTime : 360
05-29 12:44:22.331+0900 I/efl-extension( 5705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 12:44:22.331+0900 I/efl-extension( 5705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x41897728, elm_layout, func : 0x41560969
05-29 12:44:22.331+0900 I/efl-extension( 5705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-29 12:44:22.331+0900 I/efl-extension( 5705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-29 12:44:22.331+0900 I/efl-extension( 5705): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 12:44:22.331+0900 I/efl-extension( 5705): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 12:44:22.331+0900 I/efl-extension( 5705): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 12:44:22.331+0900 I/efl-extension( 5705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 12:44:22.346+0900 I/SENSOR  ( 5705): 모션 인식 방향 0
05-29 12:44:22.416+0900 I/SOCKETTEST( 5705): Success to create socket
05-29 12:44:22.421+0900 I/SOCKETTEST( 5705): Success to socket connection
05-29 12:44:22.421+0900 I/SOCKETTEST( 5705): write() 성공
05-29 12:44:22.506+0900 I/SENSOR  ( 5705): -3.990000, 1.120000, -5.880000
05-29 12:44:22.606+0900 I/SENSOR  ( 5705): -4.690000, 0.980000, 1.330000
05-29 12:44:22.711+0900 I/SENSOR  ( 5705): 1.190000, -0.490000, -1.050000
05-29 12:44:22.811+0900 I/SENSOR  ( 5705): -3.080000, 1.470000, 0.490000
05-29 12:44:22.916+0900 I/SENSOR  ( 5705): -1.050000, 0.350000, 1.260000
05-29 12:44:23.011+0900 I/SENSOR  ( 5705): -1.190000, -0.630000, -0.980000
05-29 12:44:23.111+0900 I/SENSOR  ( 5705): -0.070000, -0.840000, -0.350000
05-29 12:44:23.211+0900 I/SENSOR  ( 5705): -1.680000, 0.070000, 1.610000
05-29 12:44:23.311+0900 I/SENSOR  ( 5705): 1.330000, -0.420000, -0.280000
05-29 12:44:23.411+0900 I/SENSOR  ( 5705): -0.910000, 0.140000, 1.820000
05-29 12:44:23.551+0900 I/SENSOR  ( 5705): 1.330000, 0.420000, -0.490000
05-29 12:44:23.606+0900 I/SENSOR  ( 5705): 15.960000, -4.760000, -6.790000
05-29 12:44:23.711+0900 I/SENSOR  ( 5705): -0.980000, 2.450000, 0.280000
05-29 12:44:23.811+0900 I/SENSOR  ( 5705): 5.320000, 2.100000, 3.430000
05-29 12:44:23.911+0900 I/SENSOR  ( 5705): 5.600000, -4.760000, 1.610000
05-29 12:44:24.011+0900 I/SENSOR  ( 5705): -6.790000, -0.630000, 2.660000
05-29 12:44:24.111+0900 I/SENSOR  ( 5705): -2.660000, -1.960000, -1.680000
05-29 12:44:24.211+0900 I/SENSOR  ( 5705): -0.210000, -0.420000, 1.960000
05-29 12:44:24.316+0900 I/SENSOR  ( 5705): 1.400000, -1.330000, 1.120000
05-29 12:44:24.411+0900 I/SENSOR  ( 5705): -0.910000, 0.140000, -0.140000
05-29 12:44:24.561+0900 I/SENSOR  ( 5705): -1.190000, -0.070000, -0.210000
05-29 12:44:24.611+0900 I/SENSOR  ( 5705): 0.770000, 0.490000, -0.840000
05-29 12:44:24.716+0900 I/SENSOR  ( 5705): -3.220000, 2.380000, -1.330000
05-29 12:44:24.811+0900 I/SENSOR  ( 5705): 1.260000, 2.380000, -0.350000
05-29 12:44:24.911+0900 I/SENSOR  ( 5705): -0.420000, 2.380000, 0.140000
05-29 12:44:25.016+0900 I/SENSOR  ( 5705): -0.490000, 0.700000, -0.070000
05-29 12:44:25.116+0900 I/SENSOR  ( 5705): 0.420000, -0.070000, 1.190000
05-29 12:44:25.211+0900 I/SENSOR  ( 5705): -0.140000, -0.210000, 0.560000
05-29 12:44:25.316+0900 I/SENSOR  ( 5705): -2.450000, 0.070000, 0.070000
05-29 12:44:25.411+0900 I/SENSOR  ( 5705): -0.840000, 0.070000, 0.420000
05-29 12:44:25.551+0900 I/SENSOR  ( 5705): -0.700000, 0.770000, -0.280000
05-29 12:44:25.611+0900 I/SENSOR  ( 5705): 44.310001, -15.750000, -50.400002
05-29 12:44:25.716+0900 I/SENSOR  ( 5705): -30.520000, 51.380001, -75.879997
05-29 12:44:25.816+0900 I/SENSOR  ( 5705): 42.700001, 57.889999, -163.100006
05-29 12:44:25.911+0900 I/SENSOR  ( 5705): 105.699997, -21.000000, -148.470001
05-29 12:44:26.011+0900 I/SENSOR  ( 5705): 49.349998, -49.349998, -88.410004
05-29 12:44:26.116+0900 I/SENSOR  ( 5705): 6.580000, -25.340000, -35.279999
05-29 12:44:26.211+0900 I/SENSOR  ( 5705): 4.410000, -6.650000, -12.460000
05-29 12:44:26.316+0900 I/SENSOR  ( 5705): -160.089996, -7.000000, -39.200001
05-29 12:44:26.416+0900 I/SENSOR  ( 5705): -1219.329956, 170.380005, 63.490002
05-29 12:44:26.416+0900 I/SENSOR  ( 5705): 왼손 모션 앞으로 
05-29 12:44:26.416+0900 I/SOCKETTEST( 5705): Success to create socket
05-29 12:44:26.426+0900 I/SOCKETTEST( 5705): Success to socket connection
05-29 12:44:26.436+0900 I/SOCKETTEST( 5705): write() 성공
05-29 12:44:26.526+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:44:26.526+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:44:26.526+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:44:26.531+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:44:26.531+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:44:26.566+0900 I/SENSOR  ( 5705): 13.020000, 10.920000, 16.799999
05-29 12:44:26.611+0900 I/SENSOR  ( 5705): 86.519997, -2.030000, -22.750000
05-29 12:44:26.711+0900 I/SENSOR  ( 5705): 158.130005, -30.520000, -20.160000
05-29 12:44:26.811+0900 I/SENSOR  ( 5705): 548.099976, -103.599998, -12.600000
05-29 12:44:26.911+0900 I/SENSOR  ( 5705): 408.589996, -55.230000, 62.230000
05-29 12:44:26.981+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:44:26.981+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:44:26.981+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:44:26.981+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:44:26.981+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:44:26.986+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-29 12:44:26.986+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-29 12:44:26.991+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-29 12:44:26.991+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 12:44:27.011+0900 I/SENSOR  ( 5705): 45.849998, -6.860000, 23.590000
05-29 12:44:27.111+0900 I/SENSOR  ( 5705): 33.250000, -23.799999, 5.040000
05-29 12:44:27.211+0900 I/SENSOR  ( 5705): 15.750000, -19.740000, -2.730000
05-29 12:44:27.321+0900 I/SENSOR  ( 5705): -18.059999, 2.870000, -12.040000
05-29 12:44:27.421+0900 I/SENSOR  ( 5705): -8.330000, -6.580000, -0.420000
05-29 12:44:27.511+0900 I/SENSOR  ( 5705): 0.280000, -2.940000, 0.140000
05-29 12:44:27.611+0900 I/SENSOR  ( 5705): -1.680000, -0.420000, -2.240000
05-29 12:44:27.721+0900 I/SENSOR  ( 5705): 2.030000, -0.420000, -0.140000
05-29 12:44:27.811+0900 I/SENSOR  ( 5705): 2.730000, -0.350000, 0.210000
05-29 12:44:27.911+0900 I/SENSOR  ( 5705): 4.200000, -0.140000, -0.140000
05-29 12:44:28.016+0900 I/SENSOR  ( 5705): -2.660000, -0.070000, -0.630000
05-29 12:44:28.116+0900 I/SENSOR  ( 5705): 1.190000, -0.630000, -0.980000
05-29 12:44:28.216+0900 I/SENSOR  ( 5705): -0.910000, 0.560000, 0.490000
05-29 12:44:28.316+0900 I/SENSOR  ( 5705): 0.910000, -0.070000, 0.210000
05-29 12:44:28.416+0900 I/SENSOR  ( 5705): -1.050000, 0.840000, -0.140000
05-29 12:44:28.561+0900 I/SENSOR  ( 5705): -2.380000, 0.280000, 0.280000
05-29 12:44:28.611+0900 I/SENSOR  ( 5705): -1.750000, 0.560000, 0.070000
05-29 12:44:28.716+0900 I/SENSOR  ( 5705): 0.070000, 0.280000, 0.280000
05-29 12:44:28.821+0900 I/SENSOR  ( 5705): 1.890000, -0.140000, 0.560000
05-29 12:44:28.921+0900 I/SENSOR  ( 5705): 49.630001, 4.060000, 11.900000
05-29 12:44:29.016+0900 I/SENSOR  ( 5705): 34.020000, 27.160000, 7.140000
05-29 12:44:29.116+0900 I/SENSOR  ( 5705): 23.379999, 19.530001, 7.980000
05-29 12:44:29.216+0900 I/SENSOR  ( 5705): -37.099998, 11.690000, -12.670000
05-29 12:44:29.286+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:44:29.291+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:44:29.291+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:44:29.291+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:44:29.291+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:44:29.316+0900 I/SENSOR  ( 5705): -1409.800049, 144.759995, -7.770000
05-29 12:44:29.316+0900 I/SENSOR  ( 5705): 왼손 모션 앞으로 
05-29 12:44:29.316+0900 I/SOCKETTEST( 5705): Success to create socket
05-29 12:44:29.326+0900 I/SOCKETTEST( 5705): Success to socket connection
05-29 12:44:29.326+0900 I/SOCKETTEST( 5705): write() 성공
05-29 12:44:29.336+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-29 12:44:29.396+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-29 12:44:29.396+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-29 12:44:29.401+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 12:44:29.416+0900 I/SENSOR  ( 5705): 308.839996, -14.980000, 34.509998
05-29 12:44:29.511+0900 I/SENSOR  ( 5705): 132.020004, -6.580000, -25.340000
05-29 12:44:29.556+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:44:29.556+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:44:29.556+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:44:29.556+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:44:29.556+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:44:29.616+0900 I/SENSOR  ( 5705): 159.809998, -33.529999, -25.480000
05-29 12:44:29.716+0900 I/SENSOR  ( 5705): 539.000000, -73.919998, -7.140000
05-29 12:44:29.811+0900 I/SENSOR  ( 5705): 414.190002, -25.969999, 35.630001
05-29 12:44:29.861+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-29 12:44:29.861+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-29 12:44:29.866+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:44:29.866+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:44:29.866+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:44:29.866+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:44:29.866+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:44:29.871+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-29 12:44:29.871+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 12:44:29.911+0900 I/SENSOR  ( 5705): -61.110001, -2.310000, -1.120000
05-29 12:44:30.016+0900 I/SENSOR  ( 5705): 29.260000, -11.970000, -7.490000
05-29 12:44:30.116+0900 I/SENSOR  ( 5705): -39.549999, -1.610000, -1.120000
05-29 12:44:30.221+0900 I/SENSOR  ( 5705): -12.040000, 1.610000, -3.710000
05-29 12:44:30.316+0900 I/SENSOR  ( 5705): -2.380000, 0.350000, -3.080000
05-29 12:44:30.421+0900 I/SENSOR  ( 5705): -0.140000, -0.070000, -0.630000
05-29 12:44:30.521+0900 I/SENSOR  ( 5705): 1.260000, 0.420000, 0.210000
05-29 12:44:30.616+0900 I/SENSOR  ( 5705): 2.240000, 0.070000, 0.770000
05-29 12:44:30.721+0900 I/SENSOR  ( 5705): 0.910000, 0.280000, -0.280000
05-29 12:44:30.821+0900 I/SENSOR  ( 5705): 1.890000, 0.350000, 0.490000
05-29 12:44:30.926+0900 I/SENSOR  ( 5705): 4.200000, 1.540000, 2.380000
05-29 12:44:31.021+0900 I/SENSOR  ( 5705): 18.340000, 1.190000, 3.570000
05-29 12:44:31.116+0900 I/SENSOR  ( 5705): 17.850000, -1.120000, 4.200000
05-29 12:44:31.216+0900 I/SENSOR  ( 5705): -1.890000, -0.910000, 0.140000
05-29 12:44:31.321+0900 I/SENSOR  ( 5705): 17.780001, 2.310000, 3.360000
05-29 12:44:31.421+0900 I/SENSOR  ( 5705): 105.279999, 10.080000, 16.240000
05-29 12:44:31.521+0900 I/SENSOR  ( 5705): 76.510002, 28.910000, 14.350000
05-29 12:44:31.616+0900 I/SENSOR  ( 5705): -36.400002, 34.509998, -3.570000
05-29 12:44:31.706+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:44:31.711+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-29 12:44:31.721+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:44:31.746+0900 I/SENSOR  ( 5705): -966.419983, 36.189999, 15.330000
05-29 12:44:31.751+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:44:31.751+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:44:31.751+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:44:31.761+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-29 12:44:31.796+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-29 12:44:31.796+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 12:44:31.821+0900 I/SENSOR  ( 5705): -198.029999, -6.720000, 48.650002
05-29 12:44:31.871+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:44:31.871+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:44:31.871+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:44:31.871+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:44:31.876+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:44:31.916+0900 I/SENSOR  ( 5705): -16.379999, 15.960000, -17.219999
05-29 12:44:32.016+0900 I/SENSOR  ( 5705): 225.190002, -18.900000, 0.070000
05-29 12:44:32.116+0900 I/SENSOR  ( 5705): 248.850006, -35.000000, -2.730000
05-29 12:44:32.216+0900 I/SENSOR  ( 5705): 449.959991, -22.469999, 6.090000
05-29 12:44:32.326+0900 I/SENSOR  ( 5705): 71.120003, -7.630000, 15.960000
05-29 12:44:32.396+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:44:32.396+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-29 12:44:32.401+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:44:32.406+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:44:32.406+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:44:32.406+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:44:32.416+0900 I/SENSOR  ( 5705): 21.210001, 0.070000, 8.120000
05-29 12:44:32.426+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-29 12:44:32.506+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-29 12:44:32.506+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 12:44:32.516+0900 I/SENSOR  ( 5705): 26.180000, -7.630000, 4.690000
05-29 12:44:32.616+0900 I/SENSOR  ( 5705): 5.320000, -1.750000, 1.680000
05-29 12:44:32.731+0900 I/SENSOR  ( 5705): -9.940000, 1.400000, -2.730000
05-29 12:44:32.826+0900 I/SENSOR  ( 5705): -11.340000, 0.070000, -1.750000
05-29 12:44:32.921+0900 I/SENSOR  ( 5705): -6.720000, 0.700000, 0.210000
05-29 12:44:33.021+0900 I/SENSOR  ( 5705): -0.070000, 0.840000, -0.490000
05-29 12:44:33.121+0900 I/SENSOR  ( 5705): 37.450001, 0.280000, 9.590000
05-29 12:44:33.221+0900 I/SENSOR  ( 5705): 28.210001, 5.110000, 14.490000
05-29 12:44:33.321+0900 I/SENSOR  ( 5705): 36.959999, -16.309999, -22.889999
05-29 12:44:33.421+0900 I/SENSOR  ( 5705): 23.520000, -21.910000, -37.590000
05-29 12:44:33.516+0900 I/SENSOR  ( 5705): -42.840000, -23.379999, -12.670000
05-29 12:44:33.621+0900 I/SENSOR  ( 5705): -48.650002, -6.510000, -2.100000
05-29 12:44:33.721+0900 I/SENSOR  ( 5705): -1.890000, 20.090000, -0.560000
05-29 12:44:33.821+0900 I/SENSOR  ( 5705): -11.900000, -6.440000, -0.490000
05-29 12:44:33.926+0900 I/SENSOR  ( 5705): 14.770000, 1.050000, -0.140000
05-29 12:44:34.031+0900 I/SENSOR  ( 5705): -4.620000, 0.910000, -0.280000
05-29 12:44:34.121+0900 I/SENSOR  ( 5705): 1.050000, -0.070000, 0.280000
05-29 12:44:34.221+0900 I/SENSOR  ( 5705): -0.350000, 0.560000, 0.280000
05-29 12:44:34.321+0900 I/SENSOR  ( 5705): 0.560000, 0.630000, 0.140000
05-29 12:44:34.421+0900 I/SENSOR  ( 5705): 1.750000, -0.070000, 0.420000
05-29 12:44:34.566+0900 I/SENSOR  ( 5705): 0.350000, -1.820000, 0.770000
05-29 12:44:34.621+0900 I/SENSOR  ( 5705): 1.400000, -2.380000, 0.700000
05-29 12:44:34.721+0900 I/SENSOR  ( 5705): -2.100000, -3.640000, 0.700000
05-29 12:44:34.826+0900 I/SENSOR  ( 5705): -0.910000, 1.120000, 0.420000
05-29 12:44:34.921+0900 I/SENSOR  ( 5705): -0.280000, 1.050000, -0.210000
05-29 12:44:35.021+0900 I/SENSOR  ( 5705): 0.980000, -3.710000, 1.120000
05-29 12:44:35.126+0900 I/SENSOR  ( 5705): -10.570000, 1.820000, -0.140000
05-29 12:44:35.221+0900 I/SENSOR  ( 5705): 4.550000, -3.150000, 0.700000
05-29 12:44:35.321+0900 I/SENSOR  ( 5705): -5.250000, -2.170000, -0.140000
05-29 12:44:35.421+0900 I/SENSOR  ( 5705): 0.140000, -1.680000, 0.350000
05-29 12:44:35.546+0900 I/SENSOR  ( 5705): -2.380000, 0.910000, -0.070000
05-29 12:44:35.621+0900 I/SENSOR  ( 5705): 4.970000, -0.840000, 0.350000
05-29 12:44:35.731+0900 I/SENSOR  ( 5705): 0.280000, 1.470000, -0.070000
05-29 12:44:35.826+0900 I/SENSOR  ( 5705): 0.350000, 0.770000, 0.350000
05-29 12:44:35.921+0900 I/SENSOR  ( 5705): 0.700000, 0.980000, 0.210000
05-29 12:44:36.021+0900 I/SENSOR  ( 5705): 0.070000, 0.560000, 0.210000
05-29 12:44:36.121+0900 I/SENSOR  ( 5705): -7.210000, 4.410000, -0.700000
05-29 12:44:36.226+0900 I/SENSOR  ( 5705): -2.590000, 1.260000, 0.140000
05-29 12:44:36.326+0900 I/SENSOR  ( 5705): -4.480000, 1.470000, 0.140000
05-29 12:44:36.426+0900 I/SENSOR  ( 5705): -0.560000, 0.070000, 0.210000
05-29 12:44:36.541+0900 I/SENSOR  ( 5705): -5.530000, 0.840000, 0.420000
05-29 12:44:36.621+0900 I/SENSOR  ( 5705): -2.310000, -0.700000, 0.560000
05-29 12:44:36.726+0900 I/SENSOR  ( 5705): 1.680000, 0.560000, 0.210000
05-29 12:44:36.826+0900 I/SENSOR  ( 5705): 4.480000, -2.520000, 0.490000
05-29 12:44:36.926+0900 I/SENSOR  ( 5705): -0.980000, 1.260000, 0.070000
05-29 12:44:37.021+0900 I/SENSOR  ( 5705): -0.770000, 2.660000, 0.140000
05-29 12:44:37.126+0900 I/SENSOR  ( 5705): -0.700000, 0.770000, 0.140000
05-29 12:44:37.221+0900 I/SENSOR  ( 5705): -4.620000, 1.470000, 0.210000
05-29 12:44:37.326+0900 I/SENSOR  ( 5705): 1.260000, -1.400000, 0.280000
05-29 12:44:37.421+0900 I/SENSOR  ( 5705): 2.170000, 0.840000, 0.560000
05-29 12:44:37.536+0900 I/SENSOR  ( 5705): -3.500000, -1.890000, -0.280000
05-29 12:44:37.626+0900 I/SENSOR  ( 5705): -1.680000, -1.820000, 0.070000
05-29 12:44:37.726+0900 I/SENSOR  ( 5705): 3.990000, 3.290000, 0.980000
05-29 12:44:37.821+0900 I/SENSOR  ( 5705): -12.670000, -0.350000, 0.070000
05-29 12:44:37.926+0900 I/SENSOR  ( 5705): 1.050000, -0.560000, 0.350000
05-29 12:44:38.021+0900 I/SENSOR  ( 5705): -1.260000, 0.420000, 0.140000
05-29 12:44:38.126+0900 I/SENSOR  ( 5705): -0.420000, -2.240000, 0.070000
05-29 12:44:38.226+0900 I/SENSOR  ( 5705): -2.380000, 0.490000, -0.070000
05-29 12:44:38.326+0900 I/SENSOR  ( 5705): 0.910000, 0.490000, 0.140000
05-29 12:44:38.426+0900 I/SENSOR  ( 5705): -0.770000, -0.980000, 0.350000
05-29 12:44:38.521+0900 I/SENSOR  ( 5705): 0.770000, -0.560000, 0.280000
05-29 12:44:38.621+0900 I/SENSOR  ( 5705): 1.050000, -0.070000, 0.210000
05-29 12:44:38.731+0900 I/SENSOR  ( 5705): -0.980000, 0.280000, 0.140000
05-29 12:44:38.831+0900 I/SENSOR  ( 5705): 4.060000, -0.840000, 0.490000
05-29 12:44:38.926+0900 I/SENSOR  ( 5705): -3.920000, 1.470000, 0.210000
05-29 12:44:39.031+0900 I/SENSOR  ( 5705): 0.630000, 1.260000, 0.210000
05-29 12:44:39.126+0900 I/SENSOR  ( 5705): 1.680000, 0.070000, 0.070000
05-29 12:44:39.226+0900 I/SENSOR  ( 5705): 0.560000, -2.030000, 0.210000
05-29 12:44:39.326+0900 I/SENSOR  ( 5705): 0.420000, -0.280000, 0.280000
05-29 12:44:39.426+0900 I/SENSOR  ( 5705): -1.050000, 0.420000, 0.070000
05-29 12:44:39.526+0900 I/SENSOR  ( 5705): -0.560000, -0.350000, 0.210000
05-29 12:44:39.626+0900 I/SENSOR  ( 5705): 0.280000, -0.070000, 0.490000
05-29 12:44:39.731+0900 I/SENSOR  ( 5705): 0.700000, -0.350000, 0.280000
05-29 12:44:39.831+0900 I/SENSOR  ( 5705): 1.260000, -0.420000, 0.280000
05-29 12:44:39.931+0900 I/SENSOR  ( 5705): 1.610000, -0.210000, 0.560000
05-29 12:44:40.031+0900 I/SENSOR  ( 5705): 0.280000, 0.280000, 0.280000
05-29 12:44:40.126+0900 I/SENSOR  ( 5705): -0.630000, 0.980000, 0.210000
05-29 12:44:40.226+0900 I/SENSOR  ( 5705): -0.840000, 0.980000, 0.070000
05-29 12:44:40.326+0900 I/SENSOR  ( 5705): -0.490000, 0.980000, 0.070000
05-29 12:44:40.466+0900 I/SENSOR  ( 5705): 0.350000, -0.350000, 0.070000
05-29 12:44:40.556+0900 I/SENSOR  ( 5705): -0.070000, 0.210000, 0.070000
05-29 12:44:40.626+0900 I/SENSOR  ( 5705): -1.540000, -0.350000, -0.070000
05-29 12:44:40.731+0900 I/SENSOR  ( 5705): -1.610000, 0.350000, 0.210000
05-29 12:44:40.831+0900 I/SENSOR  ( 5705): 0.350000, -0.420000, 0.210000
05-29 12:44:40.926+0900 I/SENSOR  ( 5705): 0.490000, -0.490000, 0.140000
05-29 12:44:41.026+0900 I/SENSOR  ( 5705): 0.840000, 0.980000, 0.210000
05-29 12:44:41.126+0900 I/SENSOR  ( 5705): 1.540000, -4.410000, 0.210000
05-29 12:44:41.231+0900 I/SENSOR  ( 5705): 0.700000, -0.770000, -0.140000
05-29 12:44:41.331+0900 I/SENSOR  ( 5705): -3.710000, 4.410000, -0.210000
05-29 12:44:41.516+0900 I/SENSOR  ( 5705): 0.980000, 8.330000, 0.210000
05-29 12:44:41.531+0900 I/SENSOR  ( 5705): -3.990000, 0.070000, 0.350000
05-29 12:44:41.626+0900 I/SENSOR  ( 5705): -3.990000, 2.310000, 0.490000
05-29 12:44:41.731+0900 I/SENSOR  ( 5705): -4.550000, 5.390000, 0.630000
05-29 12:44:41.831+0900 I/SENSOR  ( 5705): -1.400000, 0.420000, 0.490000
05-29 12:44:41.931+0900 I/SENSOR  ( 5705): -1.610000, 4.340000, 0.350000
05-29 12:44:42.036+0900 I/SENSOR  ( 5705): 2.730000, 1.050000, -0.070000
05-29 12:44:42.131+0900 I/SENSOR  ( 5705): -0.490000, -0.700000, 0.140000
05-29 12:44:42.231+0900 I/SENSOR  ( 5705): 1.820000, -0.700000, 0.140000
05-29 12:44:42.331+0900 I/SENSOR  ( 5705): 1.190000, -0.700000, 0.140000
05-29 12:44:42.431+0900 I/SENSOR  ( 5705): 1.050000, -1.610000, 0.140000
05-29 12:44:42.551+0900 I/SENSOR  ( 5705): -1.190000, 1.050000, 0.350000
05-29 12:44:42.626+0900 I/SENSOR  ( 5705): -2.100000, -0.420000, 0.070000
05-29 12:44:42.736+0900 I/SENSOR  ( 5705): -2.100000, 1.960000, 0.210000
05-29 12:44:42.826+0900 I/SENSOR  ( 5705): -0.280000, -0.980000, -0.070000
05-29 12:44:42.931+0900 I/SENSOR  ( 5705): -0.280000, 1.190000, 0.280000
05-29 12:44:43.036+0900 I/SENSOR  ( 5705): -1.120000, 0.070000, 0.280000
05-29 12:44:43.131+0900 I/SENSOR  ( 5705): 8.540000, -3.850000, -0.560000
05-29 12:44:43.231+0900 I/SENSOR  ( 5705): 12.040000, -1.610000, -0.700000
05-29 12:44:43.331+0900 I/SENSOR  ( 5705): 16.730000, -2.240000, -0.490000
05-29 12:44:43.526+0900 I/SENSOR  ( 5705): 12.600000, 12.180000, 0.140000
05-29 12:44:43.531+0900 I/SENSOR  ( 5705): -8.470000, 8.470000, -0.070000
05-29 12:44:43.631+0900 I/SENSOR  ( 5705): -10.500000, 5.740000, 1.820000
05-29 12:44:43.736+0900 I/SENSOR  ( 5705): -3.360000, 1.820000, 1.120000
05-29 12:44:43.831+0900 I/SENSOR  ( 5705): -9.870000, 3.710000, 0.700000
05-29 12:44:43.931+0900 I/SENSOR  ( 5705): -14.280000, 12.180000, 0.770000
05-29 12:44:43.951+0900 E/EFL     ( 5705): evas_main<5705> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12717261 button=1 downs=1
05-29 12:44:43.996+0900 E/EFL     ( 5705): evas_main<5705> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12717310 button=1 downs=0
05-29 12:44:43.996+0900 I/PTESTResetClicked( 5705): 1start_clicked
05-29 12:44:43.996+0900 I/PTESTResetClicked( 5705): 2before if
05-29 12:44:43.996+0900 I/PTESTResetClicked( 5705): 3adtimer if
05-29 12:44:43.996+0900 I/efl-extension( 5705): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 12:44:43.996+0900 I/efl-extension( 5705): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 12:44:43.996+0900 I/efl-extension( 5705): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 12:44:44.016+0900 I/SOCKETTEST( 5705): Success to create socket
05-29 12:44:44.016+0900 I/SOCKETTEST( 5705): Success to socket connection
05-29 12:44:44.016+0900 I/SOCKETTEST( 5705): write() 성공
05-29 12:44:44.026+0900 I/BUG     ( 5705): set_num : 1, ad->crecord : 21
05-29 12:44:44.026+0900 I/ResetClicked( 5705): Reset_Clicked_cb / num,time 1 21
05-29 12:44:44.521+0900 I/efl-extension( 5705): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x41897728
05-29 12:44:44.521+0900 I/efl-extension( 5705): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x41897728, obj: 0x41897728
05-29 12:44:44.526+0900 I/efl-extension( 5705): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 12:44:44.701+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-29 12:44:44.706+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-29 12:44:44.706+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-29 12:44:44.706+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-29 12:44:44.796+0900 W/STARTER (  682): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-29 12:44:44.871+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-29 12:44:44.876+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-29 12:44:44.876+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-29 12:44:44.876+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-29 12:44:44.996+0900 W/STARTER (  682): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-29 12:44:45.256+0900 W/STARTER (  682): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-29 12:44:45.261+0900 W/STARTER (  682): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-29 12:44:45.306+0900 E/STARTER (  682): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-29 12:44:45.306+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 12:44:45.321+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 682
05-29 12:44:45.331+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 12:44:45.331+0900 W/AUL_PAD (13314): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 12:44:45.331+0900 W/AUL_PAD (13314): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 12:44:45.346+0900 I/CAPI_APPFW_APPLICATION( 5911): app_main.c: app_efl_main(129) > app_efl_main
05-29 12:44:45.351+0900 E/RESOURCED(  488): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 12:44:45.356+0900 I/CAPI_APPFW_APPLICATION( 5911): app_main.c: app_appcore_create(152) > app_appcore_create
05-29 12:44:45.436+0900 E/AUL     (  682): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 12:44:45.436+0900 E/RESOURCED(  488): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-29 12:44:45.536+0900 I/efl-extension( 5911): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445dc9d0 = w: 0 h: 0  obj 0x445be818 w: 360 h: 360
05-29 12:44:45.536+0900 I/efl-extension( 5911): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 12:44:45.541+0900 I/efl-extension( 5911): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 12:44:45.541+0900 I/efl-extension( 5911): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-29 12:44:45.541+0900 I/efl-extension( 5911): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-29 12:44:45.546+0900 I/efl-extension( 5911): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-29 12:44:45.551+0900 I/efl-extension( 5911): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445be818, elm_image, _activated_obj : 0x0, activated : 1
05-29 12:44:45.646+0900 E/W_TASKMANAGER( 5911): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-29 12:44:45.651+0900 E/W_TASKMANAGER( 5911): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-29 12:44:45.651+0900 E/W_TASKMANAGER( 5911): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-29 12:44:45.696+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.701+0900 E/W_TASKMANAGER( 5911): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:44:45.706+0900 E/RUA     ( 5911): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 22, ncols : 5
05-29 12:44:45.741+0900 E/EFL     ( 5911): elementary<5911> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c0498 into part 'elm.swallow.event.0'
05-29 12:44:45.781+0900 E/E17     (  382): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05c00003)
05-29 12:44:45.781+0900 I/APP_CORE( 5911): appcore-efl.c: __do_app(429) > [APP 5911] Event: RESET State: CREATED
05-29 12:44:45.781+0900 I/CAPI_APPFW_APPLICATION( 5911): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 12:44:45.801+0900 I/APP_CORE( 5911): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 12:44:45.801+0900 I/APP_CORE( 5911): appcore-efl.c: __do_app(474) > [APP 5911] Initial Launching, call the resume_cb
05-29 12:44:45.801+0900 I/CAPI_APPFW_APPLICATION( 5911): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 12:44:45.826+0900 W/APP_CORE( 5911): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00003
05-29 12:44:45.831+0900 E/E17     (  382): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x05c00003)
05-29 12:44:45.911+0900 I/APP_CORE( 5705): appcore-efl.c: __do_app(429) > [APP 5705] Event: PAUSE State: RUNNING
05-29 12:44:45.911+0900 I/CAPI_APPFW_APPLICATION( 5705): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 12:44:45.946+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 12:44:45.946+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 12:44:45.966+0900 I/APP_CORE( 5911): appcore-efl.c: __do_app(429) > [APP 5911] Event: RESUME State: RUNNING
05-29 12:44:46.316+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 12:44:46.361+0900 I/MALI    ( 5911): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-29 12:44:46.476+0900 E/EFL     ( 5911): evas_main<5911> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12719786 button=1 downs=1
05-29 12:44:46.501+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 12:44:46.521+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5911
05-29 12:44:46.521+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 12:44:46.586+0900 E/EFL     ( 5911): evas_main<5911> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12719901 button=1 downs=0
05-29 12:44:46.791+0900 E/EFL     ( 5911): elementary<5911> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(445735b0), freeze(1)
05-29 12:44:46.791+0900 E/EFL     ( 5911): elementary<5911> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(445735b0), freeze(1)
05-29 12:44:46.926+0900 I/efl-extension( 6050): efl_extension.c: eext_mod_init(40) > Init
05-29 12:44:46.976+0900 I/UXT     ( 6050): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-29 12:44:47.076+0900 I/AUL_PAD ( 6050): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 12:44:47.116+0900 E/TBM     ( 6050): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 12:44:47.166+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 12:44:47.176+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5705
05-29 12:44:47.181+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 27
05-29 12:44:47.181+0900 I/APP_CORE( 5705): appcore-efl.c: __do_app(429) > [APP 5705] Event: TERMINATE State: PAUSED
05-29 12:44:47.186+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 12:44:47.186+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 12:44:47.211+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 12:44:47.211+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 12:44:47.211+0900 E/APP_CORE( 5911): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 12:44:47.211+0900 I/APP_CORE( 5911): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 12:44:47.211+0900 I/APP_CORE( 5911): appcore-efl.c: __after_loop(1090) > [APP 5911] PAUSE before termination
05-29 12:44:47.211+0900 I/CAPI_APPFW_APPLICATION( 5911): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 12:44:47.211+0900 I/CAPI_APPFW_APPLICATION( 5911): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-29 12:44:47.211+0900 I/efl-extension( 5911): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x445735b0, obj: 0x445735b0
05-29 12:44:47.211+0900 I/efl-extension( 5911): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 12:44:47.211+0900 I/efl-extension( 5911): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 12:44:47.211+0900 I/efl-extension( 5911): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 12:44:47.211+0900 I/efl-extension( 5911): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 12:44:47.221+0900 I/efl-extension( 5911): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445be818
05-29 12:44:47.221+0900 I/efl-extension( 5911): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 12:44:47.221+0900 I/efl-extension( 5911): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445dc9d0 is freed
05-29 12:44:47.221+0900 I/efl-extension( 5911): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 12:44:47.221+0900 I/efl-extension( 5911): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445735b0, elm_scroller, func : 0x437c8ef1
05-29 12:44:47.221+0900 I/efl-extension( 5911): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 12:44:47.221+0900 I/efl-extension( 5911): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 12:44:47.221+0900 I/efl-extension( 5911): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445be818, elm_image, func : 0x437c8ef1
05-29 12:44:47.221+0900 I/efl-extension( 5911): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 12:44:47.221+0900 I/efl-extension( 5911): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x445735b0 : elm_scroller] rotary callabck is deleted
05-29 12:44:47.311+0900 I/APP_CORE( 5705): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 12:44:47.311+0900 I/CAPI_APPFW_APPLICATION( 5705): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-29 12:44:47.366+0900 W/PROCESSMGR(  382): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-29 12:44:47.381+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-29 12:44:47.381+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-29 12:44:47.381+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:44:47.381+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:44:47.381+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:44:47.381+0900 I/MALI    ( 5911): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-29 12:44:47.401+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 12:44:47.401+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 12:44:47.446+0900 I/MALI    ( 5911): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 12:44:47.446+0900 I/MALI    ( 5911): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=5911   close drm_fd=22 
05-29 12:44:47.451+0900 I/MALI    ( 5911): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 12:44:47.531+0900 I/UXT     ( 5705): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 12:44:47.546+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 12:44:47.546+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:44:47.546+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:44:47.546+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:44:47.546+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 12:44:47.546+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 12:44:47.551+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 12:44:47.551+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:44:47.551+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 12:44:47.551+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
05-29 12:44:47.551+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 12:44:47.551+0900 W/W_HOME  (  714): main.c: _appcore_resume_cb(681) > appcore resume
05-29 12:44:47.556+0900 W/W_HOME  (  714): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-29 12:44:47.556+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:44:47.556+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:44:47.556+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:44:47.556+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 12:44:47.556+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x45d34090
05-29 12:44:47.556+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d34090, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-29 12:44:47.556+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 12:44:47.556+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 12:44:47.561+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 12:44:47.561+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 12:44:47.561+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 12:44:47.561+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 12:44:47.561+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 12:44:47.561+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 12:44:47.566+0900 I/UXT     ( 5911): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 12:44:47.826+0900 I/efl-extension( 5911): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 12:44:47.891+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-29 12:44:48.216+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 5705
05-29 12:44:48.216+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 5911
05-29 12:44:48.271+0900 W/CRASH_MANAGER( 6055): worker.c: worker_job(1199) > 1105705706831146449348
