S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 9268
Date: 2016-05-11 18:08:10+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x44b3ff28, r5   = 0x41561d4d
r6   = 0x44b40828, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x44b3f1a8
r10  = 0x418861e0, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbea19630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     18328 KB
Buffers:     30016 KB
Cached:     139336 KB
VmPeak:      98624 KB
VmSize:      92472 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24648 KB
VmRSS:       22660 KB
VmData:      38120 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23928 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9268 TID = 9268
9268 9306 9352 

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
44082000 44881000 rwxp [stack:9352]
44c94000 45493000 rwxp [stack:9306]
457a1000 457a4000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45817000 4584f000 r-xp /usr/lib/libpulse.so.0.16.2
458c4000 458c9000 r-xp /usr/lib/libjson.so.0.0.1
458d1000 45919000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4591a000 4595d000 r-xp /usr/lib/libsndfile.so.1.0.25
4596a000 4598c000 r-xp /usr/lib/libvorbis.so.0.4.3
45994000 45998000 r-xp /usr/lib/libogg.so.0.7.1
be9f9000 bea1a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9268)
Call Stack Count: 2
 0: cfree + 0xc8 (0x404e41e8) [/lib/libc.so.6] + 0x6f1e8
 1: ((nil)) (null)
End of Call Stack

Package Information
Package Name: org.example.ph1
Package ID : org.example.ph1
Version: 0.8.0
Package Type: rpm
App Name: pH
App ID: org.example.ph1
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
07:42.625+0900 I/SENSOR  ( 9268): 51.799999, -25.760000, 4.200000
05-11 18:07:42.720+0900 I/SENSOR  ( 9268): 213.080002, -3.990000, -29.469999
05-11 18:07:42.825+0900 I/SENSOR  ( 9268): -1114.540039, -93.099998, 16.309999
05-11 18:07:42.825+0900 I/SENSOR  ( 9268): 앞으로 
05-11 18:07:42.825+0900 I/SOCKETTEST( 9268): Success to create socket
05-11 18:07:42.840+0900 I/SOCKETTEST( 9268): Success to socket connection
05-11 18:07:42.845+0900 I/SOCKETTEST( 9268): write() 성공
05-11 18:07:42.925+0900 I/SENSOR  ( 9268): 363.019989, 84.489998, -59.010002
05-11 18:07:43.025+0900 I/SENSOR  ( 9268): 383.809998, 41.509998, 5.880000
05-11 18:07:43.120+0900 I/SENSOR  ( 9268): 249.690002, 15.610000, -13.440001
05-11 18:07:43.135+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:07:43.135+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:07:43.220+0900 I/SENSOR  ( 9268): 325.290009, 21.490000, -28.490000
05-11 18:07:43.320+0900 I/SENSOR  ( 9268): -686.349976, 78.820000, 19.950001
05-11 18:07:43.420+0900 I/SENSOR  ( 9268): -81.199997, 39.410000, -42.420002
05-11 18:07:43.520+0900 I/SENSOR  ( 9268): 595.840027, 44.099998, 20.299999
05-11 18:07:43.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:43.585+0900 D/TIMER   ( 9268): Remind time: 471
05-11 18:07:43.585+0900 D/TIMER   ( 9268): Start clicked
05-11 18:07:43.665+0900 I/SENSOR  ( 9268): 442.610016, 46.900002, -37.029999
05-11 18:07:43.720+0900 I/SENSOR  ( 9268): -2.450000, 1.750000, 21.070000
05-11 18:07:43.820+0900 I/SENSOR  ( 9268): 9.520000, -1.260000, 21.000000
05-11 18:07:43.930+0900 I/SENSOR  ( 9268): 15.890000, -1.820000, 19.600000
05-11 18:07:44.030+0900 I/SENSOR  ( 9268): -334.529999, 74.690002, 15.190001
05-11 18:07:44.125+0900 I/SENSOR  ( 9268): -395.360016, -61.320000, -68.879997
05-11 18:07:44.225+0900 I/SENSOR  ( 9268): 419.579987, -85.190002, 33.320000
05-11 18:07:44.325+0900 I/SENSOR  ( 9268): 513.239990, 31.360001, 64.750000
05-11 18:07:44.395+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:07:44.395+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:07:44.425+0900 I/SENSOR  ( 9268): 168.279999, 150.570007, 152.600006
05-11 18:07:44.525+0900 I/SENSOR  ( 9268): 23.030001, 205.589996, 206.430008
05-11 18:07:44.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:44.585+0900 D/TIMER   ( 9268): Remind time: 470
05-11 18:07:44.620+0900 I/SENSOR  ( 9268): -53.480000, 215.460007, 150.009995
05-11 18:07:44.685+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:07:44.685+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:07:44.720+0900 I/SENSOR  ( 9268): -457.309998, 74.760002, 117.669998
05-11 18:07:44.825+0900 I/SENSOR  ( 9268): -337.260010, 79.029999, 17.080000
05-11 18:07:44.925+0900 I/SENSOR  ( 9268): -32.830002, 156.660004, -40.110001
05-11 18:07:45.025+0900 I/SENSOR  ( 9268): -111.020004, 28.139999, 49.070000
05-11 18:07:45.125+0900 I/SENSOR  ( 9268): 13.090000, 33.740002, 67.900002
05-11 18:07:45.225+0900 I/SENSOR  ( 9268): 3.360000, 14.280000, 10.010000
05-11 18:07:45.325+0900 I/SENSOR  ( 9268): 3.570000, -0.630000, -6.300000
05-11 18:07:45.425+0900 I/SENSOR  ( 9268): 28.000000, -3.990000, 9.380000
05-11 18:07:45.525+0900 I/SENSOR  ( 9268): 181.440002, -85.400002, -6.580000
05-11 18:07:45.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:45.585+0900 D/TIMER   ( 9268): Remind time: 469
05-11 18:07:45.670+0900 I/SENSOR  ( 9268): 577.989990, -74.550003, -87.639999
05-11 18:07:45.725+0900 I/SENSOR  ( 9268): 654.289978, -154.070007, 6.930000
05-11 18:07:45.825+0900 I/SENSOR  ( 9268): -690.830017, -96.320000, 53.760002
05-11 18:07:45.925+0900 I/SENSOR  ( 9268): -20.299999, 68.389999, -12.670000
05-11 18:07:46.025+0900 I/SENSOR  ( 9268): 122.290001, -21.490000, 87.360001
05-11 18:07:46.120+0900 I/SENSOR  ( 9268): 778.679993, 92.400002, 29.820000
05-11 18:07:46.140+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:07:46.140+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:07:46.225+0900 I/SENSOR  ( 9268): 193.759995, 115.500000, 25.830000
05-11 18:07:46.320+0900 I/SENSOR  ( 9268): -443.589996, 111.930000, 14.560000
05-11 18:07:46.410+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:07:46.410+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:07:46.420+0900 I/SENSOR  ( 9268): -333.899994, 69.860001, 25.830000
05-11 18:07:46.525+0900 I/SENSOR  ( 9268): -246.540009, 72.870003, -2.100000
05-11 18:07:46.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:46.585+0900 D/TIMER   ( 9268): Remind time: 468
05-11 18:07:46.625+0900 I/SENSOR  ( 9268): -147.210007, 30.240000, 34.369999
05-11 18:07:46.725+0900 I/SENSOR  ( 9268): -3.780000, 8.540000, 54.320000
05-11 18:07:46.820+0900 I/SENSOR  ( 9268): -1.750000, 3.080000, 14.000000
05-11 18:07:46.925+0900 I/SENSOR  ( 9268): -1.610000, 2.100000, -4.550000
05-11 18:07:47.025+0900 I/SENSOR  ( 9268): -0.630000, -3.570000, 4.900000
05-11 18:07:47.125+0900 I/SENSOR  ( 9268): 0.700000, -7.280000, 6.160000
05-11 18:07:47.225+0900 I/SENSOR  ( 9268): 3.290000, -3.430000, -2.450000
05-11 18:07:47.325+0900 I/SENSOR  ( 9268): 14.770000, -7.770000, -7.560000
05-11 18:07:47.430+0900 I/SENSOR  ( 9268): 120.470001, -72.379997, -24.360001
05-11 18:07:47.515+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:07:47.515+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:07:47.520+0900 I/SENSOR  ( 9268): 556.500000, -52.990002, -95.269997
05-11 18:07:47.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:47.585+0900 D/TIMER   ( 9268): Remind time: 467
05-11 18:07:47.625+0900 I/SENSOR  ( 9268): 439.250000, -184.729996, -30.940001
05-11 18:07:47.725+0900 I/SENSOR  ( 9268): 152.740005, -107.660004, 54.389999
05-11 18:07:47.825+0900 I/SENSOR  ( 9268): -1547.910034, -212.800003, -98.279999
05-11 18:07:47.825+0900 I/SENSOR  ( 9268): 앞으로 
05-11 18:07:47.825+0900 I/SOCKETTEST( 9268): Success to create socket
05-11 18:07:47.855+0900 I/SOCKETTEST( 9268): Success to socket connection
05-11 18:07:47.855+0900 I/SOCKETTEST( 9268): write() 성공
05-11 18:07:47.920+0900 I/SENSOR  ( 9268): 731.849976, 285.459991, 2.170000
05-11 18:07:48.025+0900 I/SENSOR  ( 9268): 452.690002, 28.630001, 61.180000
05-11 18:07:48.125+0900 I/SENSOR  ( 9268): 731.220032, 26.040001, -16.870001
05-11 18:07:48.155+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:07:48.155+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:07:48.225+0900 I/SENSOR  ( 9268): -91.419998, 10.500000, 0.980000
05-11 18:07:48.325+0900 I/SENSOR  ( 9268): 104.930000, 97.720001, 3.430000
05-11 18:07:48.425+0900 I/SENSOR  ( 9268): 64.610001, 89.529999, -17.010000
05-11 18:07:48.525+0900 I/SENSOR  ( 9268): -91.070000, 22.820000, -3.010000
05-11 18:07:48.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:48.585+0900 D/TIMER   ( 9268): Remind time: 466
05-11 18:07:48.650+0900 I/SENSOR  ( 9268): 67.690002, 41.720001, 16.940001
05-11 18:07:48.725+0900 I/SENSOR  ( 9268): 9.030000, 31.360001, 6.090000
05-11 18:07:48.830+0900 I/SENSOR  ( 9268): 39.689999, 32.549999, -15.820000
05-11 18:07:48.930+0900 I/SENSOR  ( 9268): -12.460000, 4.340000, -58.799999
05-11 18:07:49.030+0900 I/SENSOR  ( 9268): 51.099998, 16.940001, 37.170002
05-11 18:07:49.125+0900 I/SENSOR  ( 9268): -12.040000, -12.740000, 3.220000
05-11 18:07:49.190+0900 I/SHealth_Service( 1004): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-11 18:07:49.225+0900 I/SENSOR  ( 9268): -9.310000, 1.960000, -0.700000
05-11 18:07:49.250+0900 E/SHealth_Common( 1004): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-11 18:07:49.305+0900 W/SHealth_Common( 1004): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-11 18:07:49.325+0900 I/SENSOR  ( 9268): -3.220000, -2.730000, 6.370000
05-11 18:07:49.350+0900 W/SHealth_Common( 1004): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-11 18:07:49.385+0900 W/SHealth_Common( 1004): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-11 18:07:49.420+0900 I/CAPI_WIDGET_APPLICATION(  736): widget_app.c: __provider_update_cb(279) > received updating signal
05-11 18:07:49.425+0900 I/SENSOR  ( 9268): -6.930000, -4.690000, 6.440000
05-11 18:07:49.430+0900 I/HealthDataService( 1014): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-11 18:07:49.455+0900 I/healthData( 1004): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-11 18:07:49.525+0900 I/SENSOR  ( 9268): -2.730000, -1.120000, 2.870000
05-11 18:07:49.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:49.585+0900 D/TIMER   ( 9268): Remind time: 465
05-11 18:07:49.625+0900 I/SENSOR  ( 9268): -2.870000, -4.550000, 5.040000
05-11 18:07:49.725+0900 I/SENSOR  ( 9268): -5.740000, -4.480000, 7.560000
05-11 18:07:49.825+0900 I/SENSOR  ( 9268): -0.070000, -3.010000, 4.410000
05-11 18:07:49.930+0900 I/SENSOR  ( 9268): 5.040000, -0.280000, 6.790000
05-11 18:07:50.030+0900 I/SENSOR  ( 9268): 8.890000, 0.350000, 7.490000
05-11 18:07:50.135+0900 I/SENSOR  ( 9268): 9.590000, -5.530000, 10.360000
05-11 18:07:50.230+0900 I/SENSOR  ( 9268): -2.310000, -10.990000, 9.940000
05-11 18:07:50.330+0900 I/SENSOR  ( 9268): -4.340000, -9.730000, 6.930000
05-11 18:07:50.430+0900 I/SENSOR  ( 9268): -2.660000, -9.730000, 8.680000
05-11 18:07:50.530+0900 I/SENSOR  ( 9268): -0.770000, -5.460000, 7.140000
05-11 18:07:50.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:50.585+0900 D/TIMER   ( 9268): Remind time: 464
05-11 18:07:50.630+0900 I/SENSOR  ( 9268): -2.590000, -1.330000, 2.310000
05-11 18:07:50.730+0900 I/SENSOR  ( 9268): -0.560000, -1.820000, 0.140000
05-11 18:07:50.830+0900 I/SENSOR  ( 9268): 1.260000, -2.100000, -1.470000
05-11 18:07:50.925+0900 I/SENSOR  ( 9268): 5.460000, -1.190000, -2.240000
05-11 18:07:50.985+0900 I/SHealth_Service( 1004): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-11 18:07:51.010+0900 E/SHealth_Common( 1004): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-11 18:07:51.025+0900 I/SENSOR  ( 9268): 4.690000, -2.380000, -1.470000
05-11 18:07:51.075+0900 W/SHealth_Common( 1004): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-11 18:07:51.125+0900 W/SHealth_Common( 1004): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-11 18:07:51.125+0900 I/SENSOR  ( 9268): 3.010000, 0.700000, -2.240000
05-11 18:07:51.160+0900 W/SHealth_Common( 1004): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-11 18:07:51.185+0900 I/CAPI_WIDGET_APPLICATION(  736): widget_app.c: __provider_update_cb(279) > received updating signal
05-11 18:07:51.195+0900 I/HealthDataService( 1014): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-11 18:07:51.215+0900 I/healthData( 1004): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-11 18:07:51.225+0900 I/SENSOR  ( 9268): 9.660000, 0.280000, 1.050000
05-11 18:07:51.330+0900 I/SENSOR  ( 9268): 90.230003, -47.880001, 51.099998
05-11 18:07:51.430+0900 I/SENSOR  ( 9268): 57.610001, -82.389999, 80.639999
05-11 18:07:51.530+0900 I/SENSOR  ( 9268): 7.070000, -54.740002, 18.969999
05-11 18:07:51.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:51.585+0900 D/TIMER   ( 9268): Remind time: 463
05-11 18:07:51.665+0900 I/SENSOR  ( 9268): -124.040001, -33.950001, 13.440001
05-11 18:07:51.725+0900 I/SENSOR  ( 9268): -1385.719971, -102.129997, -84.699997
05-11 18:07:51.725+0900 I/SENSOR  ( 9268): 앞으로 
05-11 18:07:51.725+0900 I/SOCKETTEST( 9268): Success to create socket
05-11 18:07:51.740+0900 I/SOCKETTEST( 9268): Success to socket connection
05-11 18:07:51.740+0900 I/SOCKETTEST( 9268): write() 성공
05-11 18:07:51.835+0900 I/SENSOR  ( 9268): 753.970032, 41.299999, 55.090000
05-11 18:07:51.870+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:07:51.870+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:07:51.925+0900 I/SENSOR  ( 9268): 364.000000, 30.030001, -42.770000
05-11 18:07:52.030+0900 I/SENSOR  ( 9268): 345.940002, 63.420002, -14.140000
05-11 18:07:52.130+0900 I/SENSOR  ( 9268): -3.570000, 28.070000, 7.700000
05-11 18:07:52.230+0900 I/SENSOR  ( 9268): -2.240000, 50.049999, -4.620000
05-11 18:07:52.330+0900 I/SENSOR  ( 9268): 43.259998, 94.849998, 2.520000
05-11 18:07:52.435+0900 I/SENSOR  ( 9268): 22.889999, 73.220001, -53.480000
05-11 18:07:52.535+0900 I/SENSOR  ( 9268): -64.400002, 3.570000, -37.939999
05-11 18:07:52.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:52.585+0900 D/TIMER   ( 9268): Remind time: 462
05-11 18:07:52.630+0900 I/SENSOR  ( 9268): 8.540000, 27.160000, 22.960001
05-11 18:07:52.730+0900 I/SENSOR  ( 9268): 16.660000, 4.830000, -4.270000
05-11 18:07:52.835+0900 I/SENSOR  ( 9268): 136.080002, -66.570000, 61.110001
05-11 18:07:52.940+0900 I/SENSOR  ( 9268): 127.260002, -88.620003, 75.389999
05-11 18:07:53.035+0900 I/SENSOR  ( 9268): 83.860001, -83.019997, 35.000000
05-11 18:07:53.130+0900 I/SENSOR  ( 9268): 61.320000, -42.349998, 14.840000
05-11 18:07:53.235+0900 I/SENSOR  ( 9268): 15.610000, -38.150002, 9.870000
05-11 18:07:53.335+0900 I/SENSOR  ( 9268): 5.880000, -18.549999, 4.200000
05-11 18:07:53.430+0900 I/SENSOR  ( 9268): -3.640000, -5.320000, -3.080000
05-11 18:07:53.530+0900 I/SENSOR  ( 9268): -3.640000, -2.870000, -0.840000
05-11 18:07:53.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:53.585+0900 D/TIMER   ( 9268): Remind time: 461
05-11 18:07:53.585+0900 D/TIMER   ( 9268): Start clicked
05-11 18:07:53.695+0900 I/SENSOR  ( 9268): -5.320000, -4.480000, 2.660000
05-11 18:07:53.730+0900 I/SENSOR  ( 9268): -1.190000, -2.660000, 5.670000
05-11 18:07:53.830+0900 I/SENSOR  ( 9268): -1.470000, -1.750000, 4.620000
05-11 18:07:53.935+0900 I/SENSOR  ( 9268): -5.110000, -3.500000, 5.530000
05-11 18:07:54.045+0900 I/SENSOR  ( 9268): -3.080000, -3.360000, 6.790000
05-11 18:07:54.135+0900 I/SENSOR  ( 9268): -11.830000, -7.070000, 10.780000
05-11 18:07:54.235+0900 I/SENSOR  ( 9268): -28.490000, -10.920000, 32.130001
05-11 18:07:54.335+0900 I/SENSOR  ( 9268): -620.200012, 32.759998, 37.730000
05-11 18:07:54.435+0900 I/SENSOR  ( 9268): -1309.349976, -62.720001, -53.060001
05-11 18:07:54.435+0900 I/SENSOR  ( 9268): 앞으로 
05-11 18:07:54.435+0900 I/SOCKETTEST( 9268): Success to create socket
05-11 18:07:54.450+0900 I/SOCKETTEST( 9268): Success to socket connection
05-11 18:07:54.455+0900 I/SOCKETTEST( 9268): write() 성공
05-11 18:07:54.535+0900 I/SENSOR  ( 9268): 419.649994, -10.640000, 53.060001
05-11 18:07:54.565+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:07:54.565+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:07:54.580+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:54.580+0900 D/TIMER   ( 9268): Remind time: 460
05-11 18:07:54.630+0900 I/SENSOR  ( 9268): 822.010010, 71.190002, -50.540001
05-11 18:07:54.730+0900 I/SENSOR  ( 9268): -2.800000, -9.030000, -5.110000
05-11 18:07:54.830+0900 I/SENSOR  ( 9268): 64.959999, 13.790000, 8.330000
05-11 18:07:54.935+0900 I/SENSOR  ( 9268): 26.950001, 2.310000, -1.050000
05-11 18:07:55.035+0900 I/SENSOR  ( 9268): 33.810001, 1.890000, -0.420000
05-11 18:07:55.135+0900 I/SENSOR  ( 9268): 26.530001, -10.570000, 1.260000
05-11 18:07:55.235+0900 I/SENSOR  ( 9268): 6.300000, -14.770000, -8.680000
05-11 18:07:55.335+0900 I/SENSOR  ( 9268): 8.960000, -8.960000, -10.500000
05-11 18:07:55.435+0900 I/SENSOR  ( 9268): 1.190000, -10.850000, -2.310000
05-11 18:07:55.535+0900 I/SENSOR  ( 9268): -5.530000, -2.870000, -9.380000
05-11 18:07:55.585+0900 D/TIMER   ( 9268): Timer is start
05-11 18:07:55.585+0900 D/TIMER   ( 9268): Remind time: 459
05-11 18:07:55.670+0900 I/SENSOR  ( 9268): -1.750000, 5.040000, -17.290001
05-11 18:07:55.735+0900 I/SENSOR  ( 9268): 0.910000, 9.730000, -2.800000
05-11 18:07:55.835+0900 I/SENSOR  ( 9268): -0.910000, 0.910000, -1.750000
05-11 18:07:55.935+0900 I/SENSOR  ( 9268): 2.870000, -4.620000, 3.500000
05-11 18:07:56.035+0900 I/SENSOR  ( 9268): 0.560000, -7.770000, 4.130000
05-11 18:07:56.100+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4024258 button=1 downs=1
05-11 18:07:56.125+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4024283 button=1 downs=0
05-11 18:07:56.125+0900 D/TIMER   ( 9268): Start clicked
05-11 18:07:56.140+0900 I/SOCKETTEST( 9268): Success to create socket
05-11 18:07:56.220+0900 I/SOCKETTEST( 9268): Success to socket connection
05-11 18:07:56.220+0900 I/SOCKETTEST( 9268): write() 성공
05-11 18:07:59.750+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4027911 button=1 downs=1
05-11 18:07:59.775+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4027936 button=1 downs=0
05-11 18:07:59.775+0900 D/TIMER   ( 9268): Start clicked
05-11 18:07:59.775+0900 D/TIMER   ( 9268): Setting time is 0
05-11 18:07:59.775+0900 E/TIMER   ( 9268): (!ad->setting_time) -> _start_clicked_cb() return
05-11 18:08:00.135+0900 W/APPS    (  688): apps_main.c: _time_changed_cb(295) >  date : 11->11
05-11 18:08:01.095+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.095+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.095+0900 I/efl-extension( 9268): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.095+0900 I/efl-extension( 9268): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41923010, elm_layout, time_stamp : 4029253
05-11 18:08:01.095+0900 D/TIMER   ( 9268): Rotary callback is called
05-11 18:08:01.095+0900 E/TIMER   ( 9268): (!ad->selected) -> _rotary_cb() return
05-11 18:08:01.140+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.140+0900 I/efl-extension( 9268): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.140+0900 I/efl-extension( 9268): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41923010, elm_layout, time_stamp : 4029298
05-11 18:08:01.140+0900 D/TIMER   ( 9268): Rotary callback is called
05-11 18:08:01.140+0900 E/TIMER   ( 9268): (!ad->selected) -> _rotary_cb() return
05-11 18:08:01.140+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.190+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.190+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.190+0900 I/efl-extension( 9268): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.190+0900 I/efl-extension( 9268): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41923010, elm_layout, time_stamp : 4029348
05-11 18:08:01.190+0900 D/TIMER   ( 9268): Rotary callback is called
05-11 18:08:01.190+0900 E/TIMER   ( 9268): (!ad->selected) -> _rotary_cb() return
05-11 18:08:01.390+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.390+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.395+0900 I/efl-extension( 9268): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:01.395+0900 I/efl-extension( 9268): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41923010, elm_layout, time_stamp : 4029552
05-11 18:08:01.395+0900 D/TIMER   ( 9268): Rotary callback is called
05-11 18:08:01.395+0900 E/TIMER   ( 9268): (!ad->selected) -> _rotary_cb() return
05-11 18:08:01.995+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4030153 button=1 downs=1
05-11 18:08:02.070+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4030227 button=1 downs=0
05-11 18:08:02.070+0900 D/TIMER   ( 9268): Start clicked
05-11 18:08:02.070+0900 D/TIMER   ( 9268): Setting time is 0
05-11 18:08:02.070+0900 E/TIMER   ( 9268): (!ad->setting_time) -> _start_clicked_cb() return
05-11 18:08:02.910+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4031069 button=1 downs=1
05-11 18:08:02.965+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4031127 button=1 downs=0
05-11 18:08:02.965+0900 D/TIMER   ( 9268): Start clicked
05-11 18:08:02.965+0900 D/TIMER   ( 9268): Setting time is 0
05-11 18:08:02.965+0900 E/TIMER   ( 9268): (!ad->setting_time) -> _start_clicked_cb() return
05-11 18:08:03.405+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4031566 button=1 downs=1
05-11 18:08:03.475+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4031632 button=1 downs=0
05-11 18:08:03.685+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4031845 button=1 downs=1
05-11 18:08:03.740+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4031900 button=1 downs=0
05-11 18:08:03.740+0900 D/TIMER   ( 9268): Start clicked
05-11 18:08:03.740+0900 D/TIMER   ( 9268): Setting time is 0
05-11 18:08:03.740+0900 E/TIMER   ( 9268): (!ad->setting_time) -> _start_clicked_cb() return
05-11 18:08:03.875+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4032037 button=1 downs=1
05-11 18:08:03.930+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4032092 button=1 downs=0
05-11 18:08:03.930+0900 D/TIMER   ( 9268): Start clicked
05-11 18:08:03.930+0900 D/TIMER   ( 9268): Setting time is 0
05-11 18:08:03.930+0900 E/TIMER   ( 9268): (!ad->setting_time) -> _start_clicked_cb() return
05-11 18:08:04.045+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4032206 button=1 downs=1
05-11 18:08:04.110+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4032270 button=1 downs=0
05-11 18:08:04.110+0900 D/TIMER   ( 9268): Start clicked
05-11 18:08:04.110+0900 D/TIMER   ( 9268): Setting time is 0
05-11 18:08:04.110+0900 E/TIMER   ( 9268): (!ad->setting_time) -> _start_clicked_cb() return
05-11 18:08:04.495+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4032655 button=1 downs=1
05-11 18:08:04.550+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4032710 button=1 downs=0
05-11 18:08:04.680+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4032837 button=1 downs=1
05-11 18:08:04.725+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4032887 button=1 downs=0
05-11 18:08:04.725+0900 D/TIMER   ( 9268): Start clicked
05-11 18:08:04.725+0900 D/TIMER   ( 9268): Setting time is 0
05-11 18:08:04.725+0900 E/TIMER   ( 9268): (!ad->setting_time) -> _start_clicked_cb() return
05-11 18:08:04.850+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4033009 button=1 downs=1
05-11 18:08:04.905+0900 E/EFL     ( 9268): evas_main<9268> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4033063 button=1 downs=0
05-11 18:08:04.905+0900 D/TIMER   ( 9268): Start clicked
05-11 18:08:04.905+0900 D/TIMER   ( 9268): Setting time is 0
05-11 18:08:04.905+0900 E/TIMER   ( 9268): (!ad->setting_time) -> _start_clicked_cb() return
05-11 18:08:06.575+0900 E/SHealth_Common( 1004): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-11 18:08:06.750+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:06.750+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:06.750+0900 I/efl-extension( 9268): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:06.750+0900 I/efl-extension( 9268): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41923010, elm_layout, time_stamp : 4034906
05-11 18:08:06.750+0900 D/TIMER   ( 9268): Rotary callback is called
05-11 18:08:06.750+0900 E/TIMER   ( 9268): (!ad->selected) -> _rotary_cb() return
05-11 18:08:06.765+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:06.765+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:06.765+0900 I/efl-extension( 9268): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:06.765+0900 I/efl-extension( 9268): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41923010, elm_layout, time_stamp : 4034924
05-11 18:08:06.765+0900 D/TIMER   ( 9268): Rotary callback is called
05-11 18:08:06.765+0900 E/TIMER   ( 9268): (!ad->selected) -> _rotary_cb() return
05-11 18:08:06.795+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:06.795+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:06.795+0900 I/efl-extension( 9268): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:08:06.795+0900 I/efl-extension( 9268): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41923010, elm_layout, time_stamp : 4034955
05-11 18:08:06.795+0900 D/TIMER   ( 9268): Rotary callback is called
05-11 18:08:06.795+0900 E/TIMER   ( 9268): (!ad->selected) -> _rotary_cb() return
05-11 18:08:07.760+0900 I/efl-extension( 9268): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x41923010
05-11 18:08:07.760+0900 I/efl-extension( 9268): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x41923010, obj: 0x41923010
05-11 18:08:07.760+0900 I/efl-extension( 9268): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-11 18:08:07.760+0900 I/efl-extension( 9268): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-11 18:08:07.760+0900 I/efl-extension( 9268): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-11 18:08:07.760+0900 I/efl-extension( 9268): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-11 18:08:09.915+0900 I/CAPI_APPFW_APPLICATION( 9268): app_main.c: ui_app_exit(715) > ui_app_exit
05-11 18:08:09.915+0900 I/CAPI_APPFW_APPLICATION( 9268): app_main.c: app_efl_exit(145) > app_efl_exit
05-11 18:08:09.920+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 22
05-11 18:08:09.920+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(890) > app status : 4
05-11 18:08:10.110+0900 I/APP_CORE( 9268): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-11 18:08:10.110+0900 I/APP_CORE( 9268): appcore-efl.c: __after_loop(1090) > [APP 9268] PAUSE before termination
05-11 18:08:10.110+0900 I/CAPI_APPFW_APPLICATION( 9268): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-11 18:08:10.115+0900 I/CAPI_APPFW_APPLICATION( 9268): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-11 18:08:10.135+0900 W/AUL_AMD (  484): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-11 18:08:10.135+0900 W/AUL_AMD (  484): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-11 18:08:10.220+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-11 18:08:10.225+0900 W/W_HOME  (  688): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-11 18:08:10.225+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:10.225+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:10.225+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:10.225+0900 W/W_HOME  (  688): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-11 18:08:10.225+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-11 18:08:10.225+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
05-11 18:08:10.235+0900 I/UXT     ( 9268): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-11 18:08:10.250+0900 W/W_HOME  (  688): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-11 18:08:10.250+0900 W/W_HOME  (  688): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-11 18:08:10.250+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:10.250+0900 W/W_HOME  (  688): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-11 18:08:10.250+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: RESUME State: PAUSED
05-11 18:08:10.250+0900 I/CAPI_APPFW_APPLICATION(  688): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-11 18:08:10.250+0900 W/W_HOME  (  688): main.c: _appcore_resume_cb(681) > appcore resume
05-11 18:08:10.250+0900 W/W_HOME  (  688): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-11 18:08:10.250+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:10.250+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:10.250+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 18:08:10.250+0900 W/APPS    (  688): apps_main.c: _time_changed_cb(295) >  date : 11->11
05-11 18:08:10.275+0900 W/W_HOME  (  688): rotary.c: rotary_attach(138) > rotary_attach:0x476bd370
05-11 18:08:10.275+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x476bd370, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-11 18:08:10.275+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-11 18:08:10.280+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-11 18:08:10.280+0900 E/wnotib  (  688): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-11 18:08:10.280+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1692) > Do the postponed update job.
05-11 18:08:10.280+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 18:08:10.280+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 18:08:10.280+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 18:08:10.280+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 18:08:10.280+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1059) > idler for type: 0
05-11 18:08:10.315+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 18:08:10.315+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 18:08:10.320+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 18:08:10.320+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 18:08:10.320+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 18:08:10.325+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 18:08:10.325+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1106) > unread_count: 6
05-11 18:08:10.325+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(626) > category_id: 115, application_id: 218, application_name: 카카오톡, time_stamp: 1462957567, content_id: 0, spannable_string_version: 1
05-11 18:08:10.325+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 18:08:10.325+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 18:08:10.325+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 18:08:10.325+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 18:08:10.325+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 18:08:10.325+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 18:08:10.325+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 18:08:10.325+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 18:08:10.325+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 18:08:10.330+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 18:08:10.335+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 18:08:10.335+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 18:08:10.335+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 18:08:10.335+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 18:08:10.335+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 18:08:10.335+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 18:08:10.335+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  115, 카카오톡.
05-11 18:08:10.335+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 1
05-11 18:08:10.340+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 18:08:10.340+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 18:08:10.340+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 18:08:10.340+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 18:08:10.340+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-11 18:08:10.340+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 18:08:10.340+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 18:08:10.345+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 18:08:10.345+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 18:08:10.345+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 18:08:10.345+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 18:08:10.345+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  115, 카카오톡.
05-11 18:08:10.345+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 1
05-11 18:08:10.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 18:08:10.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 18:08:10.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 18:08:10.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 18:08:10.350+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-11 18:08:10.350+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 13
05-11 18:08:10.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 18:08:10.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 18:08:10.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 18:08:10.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 18:08:10.350+0900 I/wnotib  (  688): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-11 18:08:10.355+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1378) > This noti will be removed from panel: 115, 카카오톡.
05-11 18:08:10.355+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 2
05-11 18:08:10.355+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2986) > We don't need to delete the item for second_depth_type: 0.
05-11 18:08:10.355+0900 E/EFL     (  688): elementary<688> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
05-11 18:08:10.355+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1378) > This noti will be removed from panel: 115, 카카오톡.
05-11 18:08:10.355+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 2
05-11 18:08:10.355+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2986) > We don't need to delete the item for second_depth_type: 0.
05-11 18:08:10.355+0900 E/EFL     (  688): elementary<688> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
05-11 18:08:10.355+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 12
05-11 18:08:10.355+0900 I/wnotib  (  688): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-11 18:08:10.360+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1387) > Num categories: 1, num total noti: 6
05-11 18:08:10.360+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(871) > Free noti manager data.
05-11 18:08:10.360+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(876) > Free previous notifications.
05-11 18:08:10.360+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(897) > Free previous categories.
05-11 18:08:10.360+0900 I/wnotib  (  688): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
05-11 18:08:10.360+0900 I/wnotib  (  688): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
05-11 18:08:10.360+0900 I/wnotib  (  688): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
05-11 18:08:10.360+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1412) > num_total_panel: 1.
05-11 18:08:10.360+0900 W/W_HOME  (  688): noti_broker.c: _handler_indicator_update(562) > 0x1
05-11 18:08:10.375+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1416) > unread_count_for_home: 5
05-11 18:08:10.375+0900 W/W_HOME  (  688): noti_broker.c: _handler_noti_indicator_show(478) > 
05-11 18:08:10.380+0900 W/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-11 18:08:10.720+0900 I/MALI    (  688): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-11 18:08:10.850+0900 W/CRASH_MANAGER( 9882): worker.c: worker_job(1199) > 1109268706831146295769
