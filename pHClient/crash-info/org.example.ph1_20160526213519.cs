S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 1299
Date: 2016-05-26 21:35:19+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1299, uid 5000)

Register Information
r0   = 0x702f6374, r1   = 0x00000025
r2   = 0xbed8a20c, r3   = 0x0000feff
r4   = 0x702f6370, r5   = 0x702f6374
r6   = 0xbed89cd8, r7   = 0x25252525
r8   = 0x00000000, r9   = 0x4142dec0
r10  = 0x702f6374, fp   = 0xbed89ccc
ip   = 0x702f6374, sp   = 0xbed89758
lr   = 0x404b1f5c, pc   = 0x404ec6dc
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     13884 KB
Buffers:     21056 KB
Cached:     177096 KB
VmPeak:      96176 KB
VmSize:      94648 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23232 KB
VmRSS:       23232 KB
VmData:      35232 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25112 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 1299 TID = 1299
1299 1647 

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
41604000 41605000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4160e000 41610000 rw-p [heap]
41610000 416be000 rw-p [heap]
4195d000 41961000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
4196a000 4198b000 r-xp /usr/lib/libefl-extension.so.0.1.0
41993000 419aa000 r-xp /usr/lib/libnetwork.so.0.0.0
419b2000 419b7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
419bf000 419dd000 r-xp /usr/lib/libsensor.so.1.1.0
419e7000 419f9000 r-xp /usr/lib/libefl-assist.so.0.1.0
41a01000 41ab9000 r-xp /usr/lib/libcairo.so.2.11200.14
41ac4000 41af5000 r-xp /usr/lib/libmdm.so.1.1.85
41afd000 41b04000 r-xp /usr/lib/libsensord-share.so
41b0c000 41b1e000 r-xp /usr/lib/libtts.so
41b26000 41b47000 r-xp /usr/lib/libui-extension.so.0.1.0
41b50000 41b57000 r-xp /usr/lib/libtbm.so.1.0.0
41b5f000 41b6d000 r-xp /usr/lib/libGLESv2.so.2.0
41b76000 41b7c000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b84000 41b87000 r-xp /usr/lib/libEGL.so.1.4
41b8f000 41b97000 r-xp /usr/lib/libmdm-common.so.1.0.89
41b98000 41cd5000 r-xp /usr/lib/libicui18n.so.51.1
41ce5000 41dc9000 r-xp /usr/lib/libicuuc.so.51.1
41dde000 41de1000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41de9000 41df1000 r-xp /usr/lib/libdrm.so.2.4.0
43380000 43385000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4338e000 43393000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4339b000 4339d000 r-xp /usr/lib/libdri2.so.0.0.0
433a5000 433c6000 r-xp /usr/lib/libexif.so.12.3.3
433d9000 433de000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433e6000 434b0000 r-xp /usr/lib/libCOREGL.so.4.0
437f3000 437fe000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43807000 4380b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43813000 4382a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43837000 43839000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
448cf000 448d2000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
448da000 448db000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
448ea000 448eb000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
448f3000 448f4000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44b94000 45393000 rwxp [stack:1647]
454b3000 454ba000 r-xp /usr/lib/libfeedback.so.0.1.4
454c3000 454c4000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
454cc000 454ce000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
454d6000 454e0000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
454e8000 454ef000 r-xp /usr/lib/libmmfcommon.so.0.0.0
454f7000 454fc000 r-xp /usr/lib/libmmfsession.so.0.0.0
45504000 45507000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4568f000 456a5000 r-xp /usr/lib/libmmfsound.so.0.1.0
456b7000 456c1000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
456cd000 456d1000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
456da000 456f0000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45900000 45905000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
4590d000 4596e000 r-xp /usr/lib/libasound.so.2.0.0
45978000 459b0000 r-xp /usr/lib/libpulse.so.0.16.2
459b1000 459b4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
459bc000 459c9000 r-xp /usr/lib/libail.so.0.1.0
459d2000 459e2000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
45a03000 45a0b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
45a1a000 45a1d000 r-xp /usr/lib/libcompress.so.0.2.0
45a25000 45a2a000 r-xp /usr/lib/libjson.so.0.0.1
45a32000 45a7a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a7b000 45abe000 r-xp /usr/lib/libsndfile.so.1.0.25
45acb000 45aed000 r-xp /usr/lib/libvorbis.so.0.4.3
45af5000 45af9000 r-xp /usr/lib/libogg.so.0.7.1
bed6a000 bed8b000 rwxp [stack]
End of Maps Information

Callstack Information (PID:1299)
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
5:00.531+0900 I/APP_CORE( 1299): appcore-efl.c: __do_app(481) > [APP 1299] App already running, raise the window
05-26 21:35:00.531+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(1299), cmd(0)
05-26 21:35:00.551+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:35:00.551+0900 E/E17     (  381): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x05c00002)
05-26 21:35:00.556+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:35:00.561+0900 I/APP_CORE( 1299): appcore-efl.c: __do_app(485) > [APP 1299] Call the resume_cb
05-26 21:35:00.561+0900 I/CAPI_APPFW_APPLICATION( 1299): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 21:35:00.576+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 21:35:00.576+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:00.576+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:00.576+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:00.576+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 21:35:00.581+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:35:00.581+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:35:00.581+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 21:35:00.621+0900 I/APP_CORE( 1299): appcore-efl.c: __do_app(429) > [APP 1299] Event: RESUME State: RUNNING
05-26 21:35:00.641+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 21:35:00.641+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 21:35:00.641+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:00.641+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 21:35:00.641+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 21:35:00.641+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 21:35:00.641+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 21:35:00.641+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 21:35:00.641+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:00.641+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:00.641+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:00.641+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 21:35:00.646+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:35:00.646+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 21:35:00.646+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:35:00.646+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:35:00.646+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:35:00.646+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 21:35:00.646+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:35:00.646+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:35:00.646+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:35:00.656+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:00.661+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 21:35:00.661+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 21:35:00.661+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:35:00.661+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:35:00.731+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 21:35:00.731+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:35:00.746+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 21:35:00.991+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:35:01.156+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=138197 button=1 downs=1
05-26 21:35:01.161+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:35:01.211+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=138263 button=1 downs=0
05-26 21:35:02.511+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=139559 button=1 downs=1
05-26 21:35:02.571+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=139620 button=1 downs=0
05-26 21:35:02.861+0900 I/CAPI_NETWORK_CONNECTION( 1299): connection.c: connection_create(372) > New handle created[0x4554ab78]
05-26 21:35:02.881+0900 I/SOCKETTEST( 1299): IP : 
05-26 21:35:02.881+0900 I/SOCKETTEST( 1299): Success to create UDP socket
05-26 21:35:02.881+0900 I/SOCKETTEST( 1299): Bind Success
05-26 21:35:02.881+0900 I/SOCKETTEST( 1299): Waiting DATA...
05-26 21:35:03.486+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-26 21:35:03.511+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-26 21:35:03.511+0900 E/WMS     (  491): ==========
05-26 21:35:03.511+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
05-26 21:35:03.511+0900 E/WMS     (  491): ==========
05-26 21:35:03.536+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-26 21:35:03.601+0900 W/SCSD    ( 1200): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-26 21:35:03.601+0900 W/SCSD    ( 1200): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-26 21:35:03.601+0900 W/SCSD    ( 1200): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-26 21:35:03.606+0900 W/SCSD    ( 1200): <util_scs_send:975> sent [63 / 63] bytes. 
05-26 21:35:03.616+0900 W/SHealth_Service( 1055): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
05-26 21:35:03.621+0900 E/SHealth_Service( 1055): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-26 21:35:04.836+0900 I/SOCKETTEST( 1299): Receive Data : 192.168.0.47
05-26 21:35:04.836+0900 I/SOCKETTEST( 1299): Changed IP : 192.168.0.47
05-26 21:35:04.891+0900 I/SOCKETTEST( 1299): Success to create socket
05-26 21:35:04.901+0900 I/SOCKETTEST( 1299): Success to socket connection
05-26 21:35:04.901+0900 I/SOCKETTEST( 1299): write() 성공
05-26 21:35:04.926+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:35:04.926+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:35:05.666+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:35:06.501+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=143550 button=1 downs=1
05-26 21:35:06.556+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=143603 button=1 downs=0
05-26 21:35:06.571+0900 D/TIMER   ( 1299): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:35:06.571+0900 D/TIMER   ( 1299): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:35:06.636+0900 I/efl-extension( 1299): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:35:06.636+0900 I/efl-extension( 1299): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:35:06.641+0900 I/efl-extension( 1299): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:35:06.641+0900 I/efl-extension( 1299): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:35:06.641+0900 I/efl-extension( 1299): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44904a60, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:35:07.656+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=144702 button=1 downs=1
05-26 21:35:07.701+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=144749 button=1 downs=0
05-26 21:35:08.456+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=145506 button=1 downs=1
05-26 21:35:08.526+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=145575 button=1 downs=0
05-26 21:35:09.026+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=146078 button=1 downs=1
05-26 21:35:09.106+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=146154 button=1 downs=0
05-26 21:35:09.546+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=146596 button=1 downs=1
05-26 21:35:09.606+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=146655 button=1 downs=0
05-26 21:35:10.231+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.231+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.231+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.236+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.236+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 147281
05-26 21:35:10.236+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:10.256+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.256+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.256+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.256+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.256+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 147305
05-26 21:35:10.256+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:10.286+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.286+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.286+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.286+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.286+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 147336
05-26 21:35:10.286+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:10.326+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.326+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.326+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.326+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.326+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 147377
05-26 21:35:10.326+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:10.361+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.361+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.361+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.361+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.361+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 147411
05-26 21:35:10.361+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:10.391+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.391+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.391+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.391+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.391+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 147439
05-26 21:35:10.391+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:10.426+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.426+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.426+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.426+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:10.426+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 147475
05-26 21:35:10.426+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:10.866+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=147914 button=1 downs=1
05-26 21:35:10.911+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=147961 button=1 downs=0
05-26 21:35:11.501+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.501+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.501+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.501+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.501+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 148551
05-26 21:35:11.506+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:11.591+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.591+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.591+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.591+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.591+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 148642
05-26 21:35:11.591+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:11.651+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.651+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.651+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.651+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.651+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 148699
05-26 21:35:11.651+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:11.691+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.691+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.691+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.691+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.691+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 148742
05-26 21:35:11.691+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:11.746+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.746+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.746+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.746+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.746+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 148794
05-26 21:35:11.746+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:11.831+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.831+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.831+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.836+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:11.836+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 148882
05-26 21:35:11.836+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:12.441+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.441+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.441+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.441+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.441+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 149491
05-26 21:35:12.441+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:12.496+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.496+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.496+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 149547
05-26 21:35:12.496+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:12.496+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.501+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.566+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.566+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.566+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.566+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.566+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 149616
05-26 21:35:12.566+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:12.611+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.611+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.611+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.611+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:12.611+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904a60, elm_layout, time_stamp : 149662
05-26 21:35:12.611+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:13.421+0900 I/efl-extension( 1299): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44904a60
05-26 21:35:13.421+0900 I/efl-extension( 1299): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44904a60, obj: 0x44904a60
05-26 21:35:13.421+0900 I/efl-extension( 1299): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:35:13.426+0900 I/efl-extension( 1299): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:35:13.426+0900 I/efl-extension( 1299): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:35:13.426+0900 I/efl-extension( 1299): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:35:13.526+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=150575 button=1 downs=1
05-26 21:35:13.596+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=150647 button=1 downs=0
05-26 21:35:13.596+0900 D/TIMER   ( 1299): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:35:13.601+0900 D/TIMER   ( 1299): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:35:13.606+0900 I/efl-extension( 1299): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:35:13.606+0900 I/efl-extension( 1299): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45534c58, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:35:14.481+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=151526 button=1 downs=1
05-26 21:35:14.556+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=151607 button=1 downs=0
05-26 21:35:14.911+0900 I/DOWNLOAD_PROVIDER(  832): download-provider-client-manager.c: dp_client_manager(738) > client-manager's working is done
05-26 21:35:14.916+0900 W/WIFI_DIRECT_MANAGER( 1030): wifi-direct-client.c: wfd_client_process_request(869) > Client request [3:WIFI_DIRECT_CMD_DEREGISTER], 28 bytes read from socket[6]
05-26 21:35:15.021+0900 I/CAPI_NETWORK_CONNECTION(  832): connection.c: __connection_set_type_changed_callback(163) > Successfully de-registered(0)
05-26 21:35:15.041+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=152086 button=1 downs=1
05-26 21:35:15.091+0900 I/CAPI_NETWORK_CONNECTION(  832): connection.c: __connection_set_ip_changed_callback(248) > Successfully de-registered(0)
05-26 21:35:15.101+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=152150 button=1 downs=0
05-26 21:35:15.111+0900 I/CAPI_NETWORK_CONNECTION(  832): connection.c: connection_destroy(390) > Destroy handle: 0x4251ca78
05-26 21:35:15.116+0900 I/DOWNLOAD_PROVIDER(  832): download-provider-main.c: main(64) > download-provider's working is done
05-26 21:35:15.591+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.591+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.591+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.591+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 152639
05-26 21:35:15.591+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:15.596+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.621+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.621+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.621+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.621+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 152672
05-26 21:35:15.621+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:15.626+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.656+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.656+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.661+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.661+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 152708
05-26 21:35:15.661+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:15.661+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.691+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.691+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.691+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.691+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 152741
05-26 21:35:15.691+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:15.691+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.731+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.736+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.736+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.736+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 152783
05-26 21:35:15.736+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:15.736+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.761+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 21:35:15.791+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.791+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.791+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.791+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 152840
05-26 21:35:15.791+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:15.796+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.846+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.846+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.846+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.846+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 152893
05-26 21:35:15.846+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:15.846+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.886+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.886+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.886+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:15.886+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 152934
05-26 21:35:15.886+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:15.886+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.241+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=153288 button=1 downs=1
05-26 21:35:16.341+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=153390 button=1 downs=0
05-26 21:35:16.841+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.841+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.841+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.846+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.846+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 153891
05-26 21:35:16.846+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:16.901+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.901+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.901+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 153950
05-26 21:35:16.901+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:16.901+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.901+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.971+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.971+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.971+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.971+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:16.971+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 154021
05-26 21:35:16.971+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:17.011+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.011+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.011+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.011+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.011+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 154059
05-26 21:35:17.011+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:17.041+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.041+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.041+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.041+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.041+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 154090
05-26 21:35:17.041+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:17.076+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.076+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.076+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.076+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.076+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 154125
05-26 21:35:17.076+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:17.116+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.116+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.116+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.116+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.116+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 154164
05-26 21:35:17.116+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:17.211+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.211+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.211+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.211+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:17.211+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 154260
05-26 21:35:17.211+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:17.681+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=154728 button=1 downs=1
05-26 21:35:17.736+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=154786 button=1 downs=0
05-26 21:35:18.631+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.636+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.636+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.636+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.636+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 155682
05-26 21:35:18.636+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:18.676+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.676+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.676+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 155727
05-26 21:35:18.676+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:18.676+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.681+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.711+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.711+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.711+0900 I/efl-extension( 1299): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:18.711+0900 I/efl-extension( 1299): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45534c58, elm_layout, time_stamp : 155760
05-26 21:35:18.711+0900 E/TIMER   ( 1299): (ad->timer) -> _rotary_cb() return
05-26 21:35:18.711+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:19.116+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=156165 button=1 downs=1
05-26 21:35:19.171+0900 E/EFL     ( 1299): evas_main<1299> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=156223 button=1 downs=0
05-26 21:35:19.176+0900 I/efl-extension( 1299): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:35:19.176+0900 I/efl-extension( 1299): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45534c58, elm_layout, func : 0x414608e1
05-26 21:35:19.176+0900 I/efl-extension( 1299): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:35:19.176+0900 I/efl-extension( 1299): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:35:19.176+0900 I/efl-extension( 1299): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:35:19.176+0900 I/efl-extension( 1299): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:35:19.176+0900 I/efl-extension( 1299): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:35:19.176+0900 I/efl-extension( 1299): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:35:19.176+0900 E/EFL     ( 1299): ecore<1299> ecore.c:574 _ecore_magic_fail() 
05-26 21:35:19.176+0900 E/EFL     ( 1299): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:35:19.176+0900 E/EFL     ( 1299): *** IN FUNCTION: ecore_timer_del()
05-26 21:35:19.176+0900 E/EFL     ( 1299): ecore<1299> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:35:19.176+0900 E/EFL     ( 1299):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:35:19.176+0900 E/EFL     ( 1299):     Supplied: 0049a1bd - <UNKNOWN>
05-26 21:35:19.176+0900 E/EFL     ( 1299): ecore<1299> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:35:19.176+0900 E/EFL     ( 1299): *** SPANK SPANK SPANK!!!
05-26 21:35:19.176+0900 E/EFL     ( 1299): *** Now go fix your code. Tut tut tut!
05-26 21:35:19.176+0900 I/SOCKETTEST( 1299): Success to create socket
05-26 21:35:19.186+0900 I/SOCKETTEST( 1299): Success to socket connection
05-26 21:35:19.186+0900 I/SOCKETTEST( 1299): write() 성공
05-26 21:35:19.541+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:35:19.541+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:35:19.616+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1299
05-26 21:35:19.676+0900 W/CRASH_MANAGER( 1736): worker.c: worker_job(1199) > 1101299706831146426611
