S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 9864
Date: 2016-05-28 21:27:15+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x4381b698, r5   = 0x41461fe9
r6   = 0x4381bf98, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x4381a918
r10  = 0x41d3b098, fp   = 0x00000000
ip   = 0x4143b490, sp   = 0xbefe2630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     24280 KB
Buffers:     38384 KB
Cached:     154360 KB
VmPeak:      99000 KB
VmSize:      92748 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26148 KB
VmRSS:       23852 KB
VmData:      38328 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23960 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9864 TID = 9864
9864 9965 10067 

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
419e8000 41b25000 r-xp /usr/lib/libicui18n.so.51.1
41b35000 41b38000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b40000 41b48000 r-xp /usr/lib/libdrm.so.2.4.0
41b50000 41b55000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41b5e000 41b63000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41b6b000 41b6d000 r-xp /usr/lib/libdri2.so.0.0.0
41b75000 41b96000 r-xp /usr/lib/libexif.so.12.3.3
41ba9000 41bae000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41bca000 41bce000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41c12000 41d44000 rw-p [heap]
41d44000 41e28000 r-xp /usr/lib/libicuuc.so.51.1
433c4000 4348e000 r-xp /usr/lib/libCOREGL.so.4.0
44201000 44a00000 rwxp [stack:10067]
44b8c000 4538b000 rwxp [stack:9965]
457f9000 457fc000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4586f000 458a7000 r-xp /usr/lib/libpulse.so.0.16.2
4591c000 45921000 r-xp /usr/lib/libjson.so.0.0.1
45929000 45971000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45972000 459b5000 r-xp /usr/lib/libsndfile.so.1.0.25
459c2000 459e4000 r-xp /usr/lib/libvorbis.so.0.4.3
459ec000 459f0000 r-xp /usr/lib/libogg.so.0.7.1
befc2000 befe3000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9864)
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
:44.428+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:25:44.428+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:25:44.428+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:25:44.483+0900 I/SENSOR  ( 9864): 84.279999, 47.880001, -3.640000
05-28 21:25:44.583+0900 I/SENSOR  ( 9864): 6.860000, -4.970000, 14.840000
05-28 21:25:44.693+0900 I/SENSOR  ( 9864): -130.270004, 9.660000, 13.580000
05-28 21:25:44.798+0900 I/SENSOR  ( 9864): -1441.859985, -203.350006, 34.160000
05-28 21:25:44.798+0900 I/SENSOR  ( 9864): 앞으로 
05-28 21:25:44.798+0900 I/SOCKETTEST( 9864): Success to create socket
05-28 21:25:44.983+0900 I/SOCKETTEST( 9864): Success to socket connection
05-28 21:25:44.993+0900 I/SOCKETTEST( 9864): write() 성공
05-28 21:25:44.998+0900 I/SENSOR  ( 9864): 450.029999, 3.150000, -55.439999
05-28 21:25:45.003+0900 I/SENSOR  ( 9864): 279.299988, 24.710001, 16.379999
05-28 21:25:45.058+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:25:45.058+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:25:45.058+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:25:45.058+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:25:45.058+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:25:45.083+0900 I/SENSOR  ( 9864): 532.909973, 58.799999, -14.420000
05-28 21:25:45.183+0900 I/SENSOR  ( 9864): 617.119995, 25.830000, -66.220001
05-28 21:25:45.268+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:25:45.268+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:25:45.268+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:25:45.273+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:25:45.273+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:25:45.273+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:25:45.273+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:25:45.273+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:25:45.273+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:25:45.283+0900 I/SENSOR  ( 9864): -50.049999, -29.190001, -27.510000
05-28 21:25:45.383+0900 I/SENSOR  ( 9864): -13.300000, -20.230000, 7.700000
05-28 21:25:45.603+0900 I/SENSOR  ( 9864): -14.630000, -4.620000, 18.620001
05-28 21:25:45.603+0900 I/SENSOR  ( 9864): -27.020000, 8.470000, 52.220001
05-28 21:25:45.688+0900 I/SENSOR  ( 9864): 30.940001, 14.910000, 11.900000
05-28 21:25:45.793+0900 I/SENSOR  ( 9864): -26.880001, 18.129999, 10.920000
05-28 21:25:45.893+0900 I/SENSOR  ( 9864): 0.210000, -13.090000, 1.400000
05-28 21:25:45.988+0900 I/SENSOR  ( 9864): 13.650000, -40.740002, -11.900000
05-28 21:25:46.088+0900 I/SENSOR  ( 9864): -41.509998, -42.209999, -5.040000
05-28 21:25:46.193+0900 I/SENSOR  ( 9864): -1141.699951, -190.330002, -48.160000
05-28 21:25:46.193+0900 I/SENSOR  ( 9864): 앞으로 
05-28 21:25:46.193+0900 I/SOCKETTEST( 9864): Success to create socket
05-28 21:25:46.223+0900 I/SOCKETTEST( 9864): Success to socket connection
05-28 21:25:46.233+0900 I/SOCKETTEST( 9864): write() 성공
05-28 21:25:46.293+0900 I/SENSOR  ( 9864): -75.529999, -24.850000, -43.189999
05-28 21:25:46.393+0900 I/SENSOR  ( 9864): -37.799999, -26.320000, 41.930000
05-28 21:25:46.533+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:25:46.533+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:25:46.533+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:25:46.533+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:25:46.533+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:25:46.553+0900 I/SENSOR  ( 9864): 520.729980, 19.530001, 11.690000
05-28 21:25:46.583+0900 I/SENSOR  ( 9864): 821.169983, 39.759998, -3.850000
05-28 21:25:46.688+0900 I/SENSOR  ( 9864): 17.500000, 45.639999, 25.059999
05-28 21:25:46.783+0900 I/SENSOR  ( 9864): -25.059999, -7.910000, 26.670000
05-28 21:25:46.888+0900 I/SENSOR  ( 9864): 6.230000, -1.750000, 3.850000
05-28 21:25:46.988+0900 I/SENSOR  ( 9864): 9.520000, -7.000000, -3.220000
05-28 21:25:47.088+0900 I/SENSOR  ( 9864): -8.260000, -34.090000, 3.990000
05-28 21:25:47.193+0900 I/SENSOR  ( 9864): -169.330002, -19.670000, 2.100000
05-28 21:25:47.293+0900 I/SENSOR  ( 9864): -1280.300049, -161.699997, -14.770000
05-28 21:25:47.293+0900 I/SENSOR  ( 9864): 앞으로 
05-28 21:25:47.293+0900 I/SOCKETTEST( 9864): Success to create socket
05-28 21:25:47.303+0900 I/SOCKETTEST( 9864): Success to socket connection
05-28 21:25:47.308+0900 I/SOCKETTEST( 9864): write() 성공
05-28 21:25:47.393+0900 I/SENSOR  ( 9864): 435.119995, 24.010000, -21.910000
05-28 21:25:47.563+0900 I/SENSOR  ( 9864): 310.730011, 29.330000, -4.760000
05-28 21:25:47.563+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:25:47.563+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:25:47.568+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:25:47.568+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:25:47.568+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:25:47.588+0900 I/SENSOR  ( 9864): 783.229980, 39.759998, -13.370000
05-28 21:25:47.688+0900 I/SENSOR  ( 9864): 61.599998, 42.840000, -25.059999
05-28 21:25:47.788+0900 I/SENSOR  ( 9864): 17.150000, 7.980000, 5.810000
05-28 21:25:47.888+0900 I/SENSOR  ( 9864): -4.130000, -10.570000, 5.180000
05-28 21:25:47.988+0900 I/SENSOR  ( 9864): -34.930000, -11.270000, 3.500000
05-28 21:25:48.088+0900 I/SENSOR  ( 9864): -936.250000, -72.519997, -23.660000
05-28 21:25:48.188+0900 I/SENSOR  ( 9864): -96.110001, -20.860001, -60.060001
05-28 21:25:48.293+0900 I/SENSOR  ( 9864): -70.699997, -29.610001, 39.200001
05-28 21:25:48.388+0900 I/SENSOR  ( 9864): 353.709991, 17.360001, -5.670000
05-28 21:25:48.413+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:25:48.413+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:25:48.413+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:25:48.413+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:25:48.413+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:25:48.498+0900 I/SENSOR  ( 9864): 653.450012, 40.529999, -49.070000
05-28 21:25:48.588+0900 I/SENSOR  ( 9864): 332.360016, 56.139999, -45.920002
05-28 21:25:48.633+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:25:48.633+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:25:48.633+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:25:48.633+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:25:48.633+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:25:48.633+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:25:48.633+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:25:48.633+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:25:48.633+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:25:48.688+0900 I/SENSOR  ( 9864): 44.869999, 11.270000, -18.129999
05-28 21:25:48.788+0900 I/SENSOR  ( 9864): 23.590000, 7.000000, 4.690000
05-28 21:25:48.888+0900 I/SENSOR  ( 9864): 5.110000, 6.930000, 8.610000
05-28 21:25:48.998+0900 I/SENSOR  ( 9864): -75.110001, -5.530000, 25.480000
05-28 21:25:49.093+0900 I/SENSOR  ( 9864): -1322.790039, -178.289993, 17.290001
05-28 21:25:49.093+0900 I/SENSOR  ( 9864): 앞으로 
05-28 21:25:49.093+0900 I/SOCKETTEST( 9864): Success to create socket
05-28 21:25:49.103+0900 I/SOCKETTEST( 9864): Success to socket connection
05-28 21:25:49.108+0900 I/SOCKETTEST( 9864): write() 성공
05-28 21:25:49.203+0900 I/SENSOR  ( 9864): 375.690002, -31.920000, -37.450001
05-28 21:25:49.253+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:25:49.253+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:25:49.253+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:25:49.253+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:25:49.253+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:25:49.288+0900 I/SENSOR  ( 9864): 253.399994, 11.200000, 47.810001
05-28 21:25:49.388+0900 I/SENSOR  ( 9864): 762.580017, 107.660004, 2.240000
05-28 21:25:49.498+0900 I/SENSOR  ( 9864): 493.220001, 138.110001, -88.620003
05-28 21:25:49.533+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:25:49.533+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:25:49.533+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:25:49.533+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:25:49.533+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:25:49.533+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:25:49.533+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:25:49.533+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:25:49.538+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:25:49.588+0900 I/SENSOR  ( 9864): 119.770004, 65.800003, -43.610001
05-28 21:25:49.693+0900 I/SENSOR  ( 9864): 22.049999, -12.390000, -11.900000
05-28 21:25:49.793+0900 I/SENSOR  ( 9864): -24.219999, -33.180000, -2.240000
05-28 21:25:49.893+0900 I/SENSOR  ( 9864): -22.680000, -17.850000, 4.620000
05-28 21:25:49.998+0900 I/SENSOR  ( 9864): -12.250000, -8.540000, 4.620000
05-28 21:25:50.093+0900 I/SENSOR  ( 9864): -3.080000, -3.780000, -5.180000
05-28 21:25:50.193+0900 I/SENSOR  ( 9864): -9.380000, -7.700000, 4.200000
05-28 21:25:50.293+0900 I/SENSOR  ( 9864): -4.200000, -4.760000, -0.210000
05-28 21:25:50.393+0900 I/SENSOR  ( 9864): 4.340000, -2.660000, -0.700000
05-28 21:25:50.518+0900 I/SENSOR  ( 9864): -31.920000, -21.559999, 9.380000
05-28 21:25:50.518+0900 E/EFL     ( 9864): evas_main<9864> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3849768 button=1 downs=1
05-28 21:25:50.543+0900 E/EFL     ( 9864): evas_main<9864> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3849806 button=1 downs=0
05-28 21:25:50.543+0900 I/PTESTResetClicked( 9864): 1start_clicked
05-28 21:25:50.543+0900 I/PTESTResetClicked( 9864): 2before if
05-28 21:25:50.543+0900 I/PTESTResetClicked( 9864): 3adtimer if
05-28 21:25:50.543+0900 I/efl-extension( 9864): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-28 21:25:50.543+0900 I/efl-extension( 9864): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-28 21:25:50.543+0900 I/efl-extension( 9864): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-28 21:25:50.563+0900 I/SOCKETTEST( 9864): Success to create socket
05-28 21:25:50.563+0900 I/SOCKETTEST( 9864): Success to socket connection
05-28 21:25:50.563+0900 I/SOCKETTEST( 9864): write() 성공
05-28 21:25:50.568+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 9864): preference.c: preference_is_existing(1514) > Error : key(numrecord) is not exist
05-28 21:25:50.608+0900 I/ResetClicked( 9864): Reset_Clicked_cb / num,time 1 39
05-28 21:25:51.073+0900 I/efl-extension( 9864): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x441063f8
05-28 21:25:51.073+0900 I/efl-extension( 9864): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x441063f8, obj: 0x441063f8
05-28 21:25:51.073+0900 I/efl-extension( 9864): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-28 21:25:51.378+0900 E/EFL     ( 9864): evas_main<9864> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3850638 button=1 downs=1
05-28 21:25:51.423+0900 E/EFL     ( 9864): evas_main<9864> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3850683 button=1 downs=0
05-28 21:25:51.423+0900 I/ResetClicked( 9864): input_ record start
05-28 21:25:51.423+0900 I/2ResetClicked( 9864): count : 1
05-28 21:25:51.423+0900 I/3ResetClicked( 9864): end input record function
05-28 21:25:51.428+0900 I/ResetCalTime( 9864): str 00:39
05-28 21:25:51.428+0900 I/ResetClicked( 9864): clock_time 00:39
05-28 21:25:51.428+0900 I/ResetClicked( 9864): 2clock_timee 00:39
05-28 21:25:51.428+0900 I/ResetClicked( 9864): 3clock_timee 00:39
05-28 21:25:51.428+0900 I/ResetCalTime( 9864): str 15:05
05-28 21:25:51.428+0900 I/ResetClicked( 9864): 4clock_timee 00:39
05-28 21:25:51.433+0900 I/ResetClicked( 9864): clock_total 15:05
05-28 21:25:51.433+0900 I/ResetClicked( 9864): 5clock_timee 00:39
05-28 21:25:51.433+0900 I/11ResetClicked( 9864): ?? 1 ???? 1. 00:39
05-28 21:25:51.433+0900 I/11ResetClicked( 9864):  / 15:05
05-28 21:25:51.473+0900 I/efl-extension( 9864): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-28 21:25:51.473+0900 I/efl-extension( 9864): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44af5078, elm_image, _activated_obj : 0x0, activated : 1
05-28 21:25:51.498+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x455804a8]'s widget[0x4557b930] to layout widget[0x44af54f8]
05-28 21:25:51.498+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x455804a8 = w: 0 h: 0  obj 0x4557b930 w: 360 h: 360
05-28 21:25:51.503+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-28 21:26:00.673+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 28->28
05-28 21:26:01.583+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:26:01.583+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:26:01.583+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:26:01.583+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:26:01.583+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:26:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-28 21:26:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-28 21:26:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-28 21:26:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:26:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:26:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-28 21:26:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:26:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:26:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-28 21:26:04.063+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:26:04.063+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:26:04.063+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:26:04.063+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:26:04.063+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:26:04.393+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:26:04.393+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:26:04.393+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:26:04.393+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:26:04.393+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:26:06.158+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-28 21:26:06.163+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-28 21:26:06.173+0900 I/RESOURCED(  488): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-28 21:26:25.293+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-28 21:26:49.383+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:26:49.383+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:26:49.383+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:26:49.383+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:26:49.383+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:26:51.003+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:26:51.003+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:26:51.003+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:26:51.003+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:26:51.003+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:27:00.688+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 28->28
05-28 21:27:01.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-28 21:27:01.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-28 21:27:01.558+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-28 21:27:01.558+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:27:01.563+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:27:01.563+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-28 21:27:01.573+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:27:01.583+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:27:01.588+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-28 21:27:06.173+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-28 21:27:06.173+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-28 21:27:06.933+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:27:06.933+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:27:06.938+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:27:06.938+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:27:06.938+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:27:06.938+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:27:06.968+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:27:07.018+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:27:07.018+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:27:12.398+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-28 21:27:12.398+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-28 21:27:12.398+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-28 21:27:12.398+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-28 21:27:12.498+0900 W/STARTER (  682): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-28 21:27:12.593+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-28 21:27:12.593+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-28 21:27:12.598+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-28 21:27:12.598+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-28 21:27:12.728+0900 W/STARTER (  682): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-28 21:27:13.013+0900 W/STARTER (  682): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-28 21:27:13.023+0900 W/STARTER (  682): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-28 21:27:13.048+0900 E/STARTER (  682): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-28 21:27:13.048+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-28 21:27:13.058+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 682
05-28 21:27:13.068+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(2080) > pad pid(-5)
05-28 21:27:13.068+0900 W/AUL_PAD ( 1134): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-28 21:27:13.068+0900 W/AUL_PAD ( 1134): launchpad.c: __send_result_to_caller(272) > Check app launching
05-28 21:27:13.078+0900 E/RESOURCED(  488): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-28 21:27:13.083+0900 I/CAPI_APPFW_APPLICATION( 9865): app_main.c: app_efl_main(129) > app_efl_main
05-28 21:27:13.088+0900 I/CAPI_APPFW_APPLICATION( 9865): app_main.c: app_appcore_create(152) > app_appcore_create
05-28 21:27:13.173+0900 E/AUL     (  682): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-28 21:27:13.173+0900 E/RESOURCED(  488): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-28 21:27:13.258+0900 I/efl-extension( 9865): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445dc180 = w: 0 h: 0  obj 0x445beab0 w: 360 h: 360
05-28 21:27:13.258+0900 I/efl-extension( 9865): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-28 21:27:13.263+0900 I/efl-extension( 9865): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-28 21:27:13.263+0900 I/efl-extension( 9865): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-28 21:27:13.263+0900 I/efl-extension( 9865): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-28 21:27:13.268+0900 I/efl-extension( 9865): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-28 21:27:13.268+0900 I/efl-extension( 9865): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445beab0, elm_image, _activated_obj : 0x0, activated : 1
05-28 21:27:13.368+0900 E/W_TASKMANAGER( 9865): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-28 21:27:13.373+0900 E/W_TASKMANAGER( 9865): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-28 21:27:13.373+0900 E/W_TASKMANAGER( 9865): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-28 21:27:13.418+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.423+0900 E/W_TASKMANAGER( 9865): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-28 21:27:13.428+0900 E/RUA     ( 9865): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 17, ncols : 5
05-28 21:27:13.463+0900 E/EFL     ( 9865): elementary<9865> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c0730 into part 'elm.swallow.event.0'
05-28 21:27:13.503+0900 E/E17     (  382): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03600003)
05-28 21:27:13.503+0900 I/APP_CORE( 9865): appcore-efl.c: __do_app(429) > [APP 9865] Event: RESET State: CREATED
05-28 21:27:13.503+0900 I/CAPI_APPFW_APPLICATION( 9865): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-28 21:27:13.518+0900 I/APP_CORE( 9865): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-28 21:27:13.518+0900 I/APP_CORE( 9865): appcore-efl.c: __do_app(474) > [APP 9865] Initial Launching, call the resume_cb
05-28 21:27:13.523+0900 I/CAPI_APPFW_APPLICATION( 9865): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-28 21:27:13.548+0900 E/E17     (  382): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x03600003)
05-28 21:27:13.578+0900 W/APP_CORE( 9865): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600003
05-28 21:27:13.638+0900 I/APP_CORE( 9864): appcore-efl.c: __do_app(429) > [APP 9864] Event: PAUSE State: RUNNING
05-28 21:27:13.638+0900 I/CAPI_APPFW_APPLICATION( 9864): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-28 21:27:13.653+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-28 21:27:13.653+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-28 21:27:13.688+0900 I/APP_CORE( 9865): appcore-efl.c: __do_app(429) > [APP 9865] Event: RESUME State: RUNNING
05-28 21:27:14.053+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-28 21:27:14.098+0900 E/EFL     ( 9865): evas_main<9865> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3933357 button=1 downs=1
05-28 21:27:14.108+0900 I/MALI    ( 9865): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-28 21:27:14.148+0900 E/EFL     ( 9865): evas_main<9865> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3933409 button=1 downs=0
05-28 21:27:14.218+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:27:14.233+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9865
05-28 21:27:14.233+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-28 21:27:14.408+0900 E/EFL     ( 9865): elementary<9865> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573578), freeze(1)
05-28 21:27:14.408+0900 E/EFL     ( 9865): elementary<9865> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573578), freeze(1)
05-28 21:27:14.608+0900 I/efl-extension(10213): efl_extension.c: eext_mod_init(40) > Init
05-28 21:27:14.648+0900 I/UXT     (10213): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-28 21:27:14.758+0900 I/AUL_PAD (10213): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-28 21:27:14.783+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:27:14.793+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9864
05-28 21:27:14.793+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 27
05-28 21:27:14.798+0900 I/APP_CORE( 9864): appcore-efl.c: __do_app(429) > [APP 9864] Event: TERMINATE State: PAUSED
05-28 21:27:14.803+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-28 21:27:14.803+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-28 21:27:14.828+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-28 21:27:14.828+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-28 21:27:14.828+0900 E/APP_CORE( 9865): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-28 21:27:14.828+0900 I/APP_CORE( 9865): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-28 21:27:14.828+0900 I/APP_CORE( 9865): appcore-efl.c: __after_loop(1090) > [APP 9865] PAUSE before termination
05-28 21:27:14.828+0900 I/CAPI_APPFW_APPLICATION( 9865): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-28 21:27:14.828+0900 I/CAPI_APPFW_APPLICATION( 9865): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-28 21:27:14.833+0900 I/efl-extension( 9865): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44573578, obj: 0x44573578
05-28 21:27:14.833+0900 I/efl-extension( 9865): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-28 21:27:14.833+0900 I/efl-extension( 9865): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-28 21:27:14.833+0900 I/efl-extension( 9865): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-28 21:27:14.833+0900 I/efl-extension( 9865): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-28 21:27:14.838+0900 I/efl-extension( 9865): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445beab0
05-28 21:27:14.838+0900 I/efl-extension( 9865): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-28 21:27:14.838+0900 I/efl-extension( 9865): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445dc180 is freed
05-28 21:27:14.838+0900 I/efl-extension( 9865): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-28 21:27:14.838+0900 I/efl-extension( 9865): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44573578, elm_scroller, func : 0x437c8ef1
05-28 21:27:14.838+0900 I/efl-extension( 9865): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-28 21:27:14.838+0900 I/efl-extension( 9865): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-28 21:27:14.838+0900 I/efl-extension( 9865): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445beab0, elm_image, func : 0x437c8ef1
05-28 21:27:14.838+0900 I/efl-extension( 9865): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-28 21:27:14.838+0900 I/efl-extension( 9865): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44573578 : elm_scroller] rotary callabck is deleted
05-28 21:27:14.858+0900 E/TBM     (10213): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-28 21:27:14.878+0900 I/APP_CORE( 9864): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-28 21:27:14.878+0900 I/CAPI_APPFW_APPLICATION( 9864): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-28 21:27:14.883+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-28 21:27:14.888+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x44af5078], circle_obj[0x44af2400]!
05-28 21:27:14.888+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44a51e70 = w: 0 h: 0  obj 0x44af5078 w: 360 h: 360
05-28 21:27:14.888+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-28 21:27:14.888+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x455804a8 is freed
05-28 21:27:14.888+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x43854eb8 is freed
05-28 21:27:14.893+0900 I/efl-extension( 9864): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44106578, obj: 0x44106578
05-28 21:27:14.893+0900 I/efl-extension( 9864): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-28 21:27:14.893+0900 I/efl-extension( 9864): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-28 21:27:14.893+0900 I/efl-extension( 9864): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-28 21:27:14.893+0900 I/efl-extension( 9864): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-28 21:27:14.903+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-28 21:27:14.903+0900 I/efl-extension( 9864): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44a51e70 is freed
05-28 21:27:14.903+0900 I/efl-extension( 9864): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44af5078
05-28 21:27:14.903+0900 I/efl-extension( 9864): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-28 21:27:14.903+0900 I/efl-extension( 9864): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44106578, elm_genlist, func : 0x417bddfd
05-28 21:27:14.903+0900 I/efl-extension( 9864): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-28 21:27:14.908+0900 W/PROCESSMGR(  382): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-28 21:27:14.908+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-28 21:27:14.908+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-28 21:27:14.908+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:27:14.908+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:27:14.908+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:27:14.933+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-28 21:27:14.933+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-28 21:27:14.958+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-28 21:27:14.958+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:27:14.958+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:27:14.958+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:27:14.958+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-28 21:27:14.963+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-28 21:27:14.963+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-28 21:27:14.963+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:27:14.963+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-28 21:27:14.963+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
05-28 21:27:14.963+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-28 21:27:14.963+0900 W/W_HOME  (  714): main.c: _appcore_resume_cb(681) > appcore resume
05-28 21:27:14.963+0900 W/W_HOME  (  714): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-28 21:27:14.963+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:27:14.968+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:27:14.968+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:27:14.968+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 28->28
05-28 21:27:14.968+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x45d34090
05-28 21:27:14.968+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d34090, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-28 21:27:14.968+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-28 21:27:14.968+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-28 21:27:14.973+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-28 21:27:14.973+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-28 21:27:14.973+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-28 21:27:14.973+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-28 21:27:14.973+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-28 21:27:14.973+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-28 21:27:14.988+0900 I/UXT     ( 9864): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-28 21:27:15.013+0900 I/MALI    ( 9865): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-28 21:27:15.028+0900 I/MALI    ( 9865): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-28 21:27:15.028+0900 I/MALI    ( 9865): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=9865   close drm_fd=21 
05-28 21:27:15.028+0900 I/MALI    ( 9865): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-28 21:27:15.068+0900 I/UXT     ( 9865): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-28 21:27:15.353+0900 I/efl-extension( 9865): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-28 21:27:15.398+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-28 21:27:15.608+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 9864
05-28 21:27:15.613+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 9865
05-28 21:27:15.653+0900 W/CRASH_MANAGER(10218): worker.c: worker_job(1199) > 1109864706831146443843
