S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 10806
Date: 2016-05-26 22:23:00+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10806, uid 5000)

Register Information
r0   = 0x00000064, r1   = 0x00000025
r2   = 0xbe9b31fc, r3   = 0x0000feff
r4   = 0x00000060, r5   = 0x00000064
r6   = 0xbe9b2cc8, r7   = 0x25252525
r8   = 0x00000000, r9   = 0x4142dec0
r10  = 0x00000064, fp   = 0xbe9b2cbc
ip   = 0x00000064, sp   = 0xbe9b2748
lr   = 0x404b1f5c, pc   = 0x404ec6dc
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     17520 KB
Buffers:     31824 KB
Cached:     164748 KB
VmPeak:      96056 KB
VmSize:      94020 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22264 KB
VmRSS:       22264 KB
VmData:      34684 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25096 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10806 TID = 10806
10806 10890 

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
415bd000 415c8000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
415d2000 415da000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.2.5
415e2000 415ef000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
415f7000 415fc000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41604000 41608000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41611000 41632000 r-xp /usr/lib/libefl-extension.so.0.1.0
4163a000 41651000 r-xp /usr/lib/libnetwork.so.0.0.0
41659000 4165e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41666000 41684000 r-xp /usr/lib/libsensor.so.1.1.0
4168e000 41695000 r-xp /usr/lib/libsensord-share.so
4169d000 4174c000 rw-p [heap]
419eb000 419fd000 r-xp /usr/lib/libefl-assist.so.0.1.0
41a05000 41abd000 r-xp /usr/lib/libcairo.so.2.11200.14
41ac8000 41af9000 r-xp /usr/lib/libmdm.so.1.1.85
41b01000 41b13000 r-xp /usr/lib/libtts.so
41b1b000 41b3c000 r-xp /usr/lib/libui-extension.so.0.1.0
41b45000 41b4c000 r-xp /usr/lib/libtbm.so.1.0.0
41b54000 41b62000 r-xp /usr/lib/libGLESv2.so.2.0
41b6b000 41b6c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41b75000 41b7b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b83000 41b86000 r-xp /usr/lib/libEGL.so.1.4
41b8e000 41b96000 r-xp /usr/lib/libmdm-common.so.1.0.89
41b97000 41cd4000 r-xp /usr/lib/libicui18n.so.51.1
41ce4000 41dc8000 r-xp /usr/lib/libicuuc.so.51.1
41ddd000 41de0000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41de8000 41df0000 r-xp /usr/lib/libdrm.so.2.4.0
4337f000 43384000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4338d000 43392000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4339a000 4339c000 r-xp /usr/lib/libdri2.so.0.0.0
433a4000 433c5000 r-xp /usr/lib/libexif.so.12.3.3
433d8000 433dd000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433e5000 434af000 r-xp /usr/lib/libCOREGL.so.4.0
437f2000 437fd000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43806000 4380a000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43812000 43829000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43836000 43838000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
448d5000 448d6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
448de000 448df000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44b8c000 4538b000 rwxp [stack:10890]
45489000 45490000 r-xp /usr/lib/libfeedback.so.0.1.4
45499000 4549a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
454a2000 454a4000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
454ac000 454b6000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
454be000 454c5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
454cd000 454e3000 r-xp /usr/lib/libmmfsound.so.0.1.0
454f5000 454fa000 r-xp /usr/lib/libmmfsession.so.0.0.0
45502000 4550c000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45518000 4551c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45525000 4553b000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45544000 45549000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
45551000 45554000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4555c000 4555f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45567000 45574000 r-xp /usr/lib/libail.so.0.1.0
4557d000 45580000 r-xp /usr/lib/libcompress.so.0.2.0
4591b000 4597c000 r-xp /usr/lib/libasound.so.2.0.0
45986000 459be000 r-xp /usr/lib/libpulse.so.0.16.2
459bf000 459cf000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
459f0000 459f8000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
45a07000 45a0c000 r-xp /usr/lib/libjson.so.0.0.1
45a14000 45a5c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a5d000 45aa0000 r-xp /usr/lib/libsndfile.so.1.0.25
45aad000 45acf000 r-xp /usr/lib/libvorbis.so.0.4.3
45ad7000 45adb000 r-xp /usr/lib/libogg.so.0.7.1
be993000 be9b4000 rwxp [stack]
End of Maps Information

Callstack Information (PID:10806)
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
 e5933114 - <UNKNOWN>
05-26 22:22:48.931+0900 E/EFL     (10798): ecore<10798> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:22:48.931+0900 E/EFL     (10798): *** SPANK SPANK SPANK!!!
05-26 22:22:48.931+0900 E/EFL     (10798): *** Now go fix your code. Tut tut tut!
05-26 22:22:48.931+0900 E/EFL     (10798): ecore<10798> ecore.c:574 _ecore_magic_fail() 
05-26 22:22:48.931+0900 E/EFL     (10798): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:22:48.931+0900 E/EFL     (10798): *** IN FUNCTION: ecore_timer_del()
05-26 22:22:48.931+0900 E/EFL     (10798): ecore<10798> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:22:48.931+0900 E/EFL     (10798):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:22:48.931+0900 E/EFL     (10798):     Supplied: 403e8280 - <UNKNOWN>
05-26 22:22:48.931+0900 E/EFL     (10798): ecore<10798> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:22:48.931+0900 E/EFL     (10798): *** SPANK SPANK SPANK!!!
05-26 22:22:48.931+0900 E/EFL     (10798): *** Now go fix your code. Tut tut tut!
05-26 22:22:48.931+0900 I/SOCKETTEST(10798): Success to create socket
05-26 22:22:48.936+0900 I/SOCKETTEST(10798): Success to socket connection
05-26 22:22:48.936+0900 I/SOCKETTEST(10798): write() 성공
05-26 22:22:49.281+0900 W/CRASH_MANAGER(10868): worker.c: worker_job(1199) > 11107987068311464268968
05-26 22:22:49.446+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 23
05-26 22:22:49.446+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
05-26 22:22:49.446+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 10798
05-26 22:22:49.446+0900 W/AUL_AMD (  496): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-26 22:22:49.506+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:22:49.506+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 22:22:49.511+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 10798
05-26 22:22:49.581+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 22:22:49.586+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 22:22:49.586+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 22:22:49.586+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:22:49.586+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:22:49.586+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 22:22:49.586+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 22:22:49.586+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:49.586+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:49.586+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:49.586+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 22:22:49.626+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(0)
05-26 22:22:49.626+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 22:22:49.626+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:49.626+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(0)
05-26 22:22:49.626+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESUME State: PAUSED
05-26 22:22:49.626+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 22:22:49.626+0900 W/W_HOME  (  737): main.c: _appcore_resume_cb(681) > appcore resume
05-26 22:22:49.626+0900 W/W_HOME  (  737): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 22:22:49.626+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:49.626+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:49.626+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:49.626+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:22:49.626+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 22:22:49.626+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:22:49.626+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:22:49.626+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 22:22:49.626+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:22:49.626+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 22:22:49.626+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:22:49.626+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:22:49.626+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:22:49.626+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:22:50.111+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:22:50.631+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:22:50.636+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:22:50.636+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [true][0m
05-26 22:22:50.636+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:22:50.651+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 737
05-26 22:22:50.656+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT][0m
05-26 22:22:50.661+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:22:50.661+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:22:50.661+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:22:50.661+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:22:50.661+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:22:50.661+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:22:50.661+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:22:50.661+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:22:50.666+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:22:50.666+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:22:50.666+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:22:50.666+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:22:50.666+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:22:50.666+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:22:50.666+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:22:50.666+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:22:50.666+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:22:50.666+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:22:50.666+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 22:22:50.666+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 22:22:50.671+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT][0m
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:22:50.676+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:22:50.681+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 22:22:50.681+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:22:50.681+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:22:50.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:22:50.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:22:50.686+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:22:50.686+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:22:50.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:22:50.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:22:50.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:22:50.686+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:22:50.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:22:50.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:22:51.261+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 22:22:51.261+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3008310 button=1 downs=1
05-26 22:22:51.261+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [163, 198]
05-26 22:22:51.356+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3008397 button=1 downs=0
05-26 22:22:51.356+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [163, 198]->[168, 196]
05-26 22:22:51.361+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-26 22:22:51.366+0900 E/APPS    (  737): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-26 22:22:51.366+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-26 22:22:51.371+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:22:51.371+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 737
05-26 22:22:51.371+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:22:51.386+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-26 22:22:51.386+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 22:22:51.386+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 22:22:51.386+0900 W/AUL_PAD ( 1155): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 22:22:51.386+0900 W/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 22:22:51.426+0900 I/efl-extension(10806): efl_extension.c: eext_mod_init(40) > Init
05-26 22:22:51.431+0900 I/UXT     (10806): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 22:22:51.441+0900 I/CAPI_APPFW_APPLICATION(10806): app_main.c: ui_app_main(704) > app_efl_main
05-26 22:22:51.441+0900 I/CAPI_APPFW_APPLICATION(10806): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-26 22:22:51.491+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:22:51.501+0900 E/RESOURCED(  497): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-26 22:22:51.506+0900 E/TBM     (10806): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 22:22:51.636+0900 E/EFL     (10806): <10806> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-26 22:22:51.651+0900 E/EFL     (10806): <10806> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:22:51.651+0900 E/EFL     (10806): <10806> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:22:51.651+0900 E/EFL     (10806): <10806> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:22:51.651+0900 E/EFL     (10806): <10806> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:22:51.651+0900 E/EFL     (10806): <10806> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:22:51.776+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05c00002)
05-26 22:22:51.831+0900 I/APP_CORE(10806): appcore-efl.c: __do_app(429) > [APP 10806] Event: RESET State: CREATED
05-26 22:22:51.831+0900 I/CAPI_APPFW_APPLICATION(10806): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 22:22:51.836+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 22:22:51.846+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 22:22:51.851+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:51.851+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:51.851+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:51.856+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 22:22:51.856+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:22:51.856+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:22:51.861+0900 I/APP_CORE(10806): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 22:22:51.861+0900 I/APP_CORE(10806): appcore-efl.c: __do_app(474) > [APP 10806] Initial Launching, call the resume_cb
05-26 22:22:51.861+0900 I/CAPI_APPFW_APPLICATION(10806): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 22:22:51.891+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 22:22:51.936+0900 W/APP_CORE(10806): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
05-26 22:22:51.971+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 22:22:51.971+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 22:22:51.971+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:51.971+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 22:22:51.971+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 22:22:51.971+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:22:51.971+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 22:22:51.971+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 22:22:51.971+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:51.971+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:51.971+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:22:51.971+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 22:22:51.971+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:22:51.971+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 22:22:51.971+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:22:51.971+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:22:51.971+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:22:51.971+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 22:22:51.971+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:22:51.971+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:22:51.971+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:22:51.991+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:22:51.991+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:22:51.991+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:22:51.991+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:22:51.991+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:22:51.991+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:22:51.991+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:22:51.991+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:22:51.996+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:22:51.996+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:22:51.996+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:22:51.996+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:22:51.996+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:22:51.996+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:22:51.996+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:22:51.996+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:22:51.996+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:22:51.996+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:22:52.001+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:22:52.001+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:22:52.006+0900 I/APP_CORE(10806): appcore-efl.c: __do_app(429) > [APP 10806] Event: RESUME State: RUNNING
05-26 22:22:52.136+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 22:22:52.136+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:22:52.161+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 22:22:52.166+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:22:52.176+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 22:22:52.371+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:22:52.501+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:22:52.526+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:22:52.531+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10806
05-26 22:22:52.536+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:22:52.796+0900 I/AUL_PAD (10891): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 22:22:52.881+0900 E/EFL     (10806): evas_main<10806> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3009929 button=1 downs=1
05-26 22:22:52.941+0900 E/EFL     (10806): evas_main<10806> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3009994 button=1 downs=0
05-26 22:22:53.566+0900 E/EFL     (10806): evas_main<10806> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3010617 button=1 downs=1
05-26 22:22:53.676+0900 E/EFL     (10806): evas_main<10806> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3010726 button=1 downs=0
05-26 22:22:53.926+0900 I/CAPI_NETWORK_CONNECTION(10806): connection.c: connection_create(372) > New handle created[0x44af7810]
05-26 22:22:53.941+0900 I/SOCKETTEST(10806): IP : 
05-26 22:22:53.941+0900 I/SOCKETTEST(10806): Success to create UDP socket
05-26 22:22:53.941+0900 I/SOCKETTEST(10806): Bind Success
05-26 22:22:53.941+0900 I/SOCKETTEST(10806): Waiting DATA...
05-26 22:22:55.086+0900 I/SOCKETTEST(10806): Receive Data : 192.168.0.47
05-26 22:22:55.086+0900 I/SOCKETTEST(10806): Changed IP : 192.168.0.47
05-26 22:22:55.096+0900 I/SOCKETTEST(10806): Success to create socket
05-26 22:22:55.101+0900 I/SOCKETTEST(10806): Success to socket connection
05-26 22:22:55.101+0900 I/SOCKETTEST(10806): write() 성공
05-26 22:22:55.161+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 22 -> 21 1464268975 91
05-26 22:22:55.161+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 21 1115 335 390
05-26 22:22:55.161+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 21 0 0 508
05-26 22:22:55.161+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 21 964 217 337
05-26 22:22:55.161+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 21 174 5 61
05-26 22:22:55.161+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 21 211 52 74
05-26 22:22:57.016+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:22:57.691+0900 E/EFL     (10806): evas_main<10806> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3014737 button=1 downs=1
05-26 22:22:57.751+0900 E/EFL     (10806): evas_main<10806> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3014802 button=1 downs=0
05-26 22:22:57.766+0900 D/TIMER   (10806): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:22:57.766+0900 D/TIMER   (10806): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:22:57.821+0900 I/efl-extension(10806): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:22:57.821+0900 I/efl-extension(10806): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:22:57.821+0900 I/efl-extension(10806): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:22:57.821+0900 I/efl-extension(10806): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:22:57.821+0900 I/efl-extension(10806): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41978688, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:22:58.851+0900 E/EFL     (10806): evas_main<10806> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3015897 button=1 downs=1
05-26 22:22:58.901+0900 E/EFL     (10806): evas_main<10806> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3015949 button=1 downs=0
05-26 22:22:59.791+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 22:22:59.796+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 22:22:59.801+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : pedometer_inactive_period error
05-26 22:22:59.806+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 22:22:59.806+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 22:22:59.806+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_10min_precaution_millisec error
05-26 22:22:59.821+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 22:22:59.821+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 22:22:59.826+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_before_10min_precaution_millisec error
05-26 22:22:59.986+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:22:59.986+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:22:59.986+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:22:59.986+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017032
05-26 22:22:59.986+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.051+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.051+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.051+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.051+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017099
05-26 22:23:00.051+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.106+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.106+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.106+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017153
05-26 22:23:00.106+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.106+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.141+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.141+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.141+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.141+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017191
05-26 22:23:00.141+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.181+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.186+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.186+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.186+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017233
05-26 22:23:00.186+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.231+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.231+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.231+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017278
05-26 22:23:00.231+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.231+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.261+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.261+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.261+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017311
05-26 22:23:00.261+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.261+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.286+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.286+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.286+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017336
05-26 22:23:00.286+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.286+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.321+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.321+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.321+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.321+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017370
05-26 22:23:00.321+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.346+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.346+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.346+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.346+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017397
05-26 22:23:00.346+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.391+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.391+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.391+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.391+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017440
05-26 22:23:00.391+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.431+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.431+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.431+0900 I/efl-extension(10806): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:23:00.431+0900 I/efl-extension(10806): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41978688, elm_layout, time_stamp : 3017481
05-26 22:23:00.431+0900 E/TIMER   (10806): (ad->timer) -> _rotary_cb() return
05-26 22:23:00.796+0900 E/EFL     (10806): evas_main<10806> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3017846 button=1 downs=1
05-26 22:23:00.856+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:23:00.881+0900 E/EFL     (10806): evas_main<10806> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3017927 button=1 downs=0
05-26 22:23:00.881+0900 I/efl-extension(10806): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:23:00.881+0900 I/efl-extension(10806): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x41978688, elm_layout, func : 0x414608a9
05-26 22:23:00.881+0900 I/efl-extension(10806): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:23:00.881+0900 I/efl-extension(10806): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:23:00.881+0900 I/efl-extension(10806): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:23:00.881+0900 I/efl-extension(10806): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:23:00.881+0900 I/efl-extension(10806): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:23:00.881+0900 I/efl-extension(10806): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:23:00.881+0900 E/EFL     (10806): ecore<10806> ecore.c:574 _ecore_magic_fail() 
05-26 22:23:00.881+0900 E/EFL     (10806): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:23:00.881+0900 E/EFL     (10806): *** IN FUNCTION: ecore_timer_del()
05-26 22:23:00.881+0900 E/EFL     (10806): ecore<10806> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:23:00.881+0900 E/EFL     (10806):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:23:00.881+0900 E/EFL     (10806):     Supplied: 0049a1bd - <UNKNOWN>
05-26 22:23:00.881+0900 E/EFL     (10806): ecore<10806> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:23:00.881+0900 E/EFL     (10806): *** SPANK SPANK SPANK!!!
05-26 22:23:00.881+0900 E/EFL     (10806): *** Now go fix your code. Tut tut tut!
05-26 22:23:00.881+0900 I/SOCKETTEST(10806): Success to create socket
05-26 22:23:00.886+0900 I/SOCKETTEST(10806): Success to socket connection
05-26 22:23:00.886+0900 I/SOCKETTEST(10806): write() 성공
05-26 22:23:01.036+0900 W/CRASH_MANAGER(10868): worker.c: worker_job(1199) > 1110806706831146426898
