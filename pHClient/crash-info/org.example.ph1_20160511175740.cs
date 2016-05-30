S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 7494
Date: 2016-05-11 17:57:40+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0x41468d28

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x418ff4e8, r5   = 0x41561db1
r6   = 0x418ffde8, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x418fe768
r10  = 0x41885ec0, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbecec630
lr   = 0x404e41e8, pc   = 0x41468d28
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     16532 KB
Buffers:     25088 KB
Cached:     135256 KB
VmPeak:      96656 KB
VmSize:      90436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23340 KB
VmRSS:       21424 KB
VmData:      36112 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23928 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 7494 TID = 7494
7494 7586 7833 

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
43882000 44081000 rwxp [stack:7833]
44c94000 45493000 rwxp [stack:7586]
45634000 45637000 r-xp /usr/lib/libpulse-simple.so.0.0.4
456aa000 456e2000 r-xp /usr/lib/libpulse.so.0.16.2
4585e000 45863000 r-xp /usr/lib/libjson.so.0.0.1
4586b000 458b3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
458b4000 458f7000 r-xp /usr/lib/libsndfile.so.1.0.25
45904000 45926000 r-xp /usr/lib/libvorbis.so.0.4.3
4592e000 45932000 r-xp /usr/lib/libogg.so.0.7.1
beccc000 beced000 rwxp [stack]
End of Maps Information

Callstack Information (PID:7494)
Call Stack Count: 1
 0: (0x41468d28) (null)
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
dler(646) > __request_handler: 12
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.075+0900 E/W_TASKMANAGER( 7472): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:57:38.080+0900 D/TIMER   ( 7494): Timer is start
05-11 17:57:38.080+0900 D/TIMER   ( 7494): Remind time: 1185
05-11 17:57:38.080+0900 E/RUA     ( 7472): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 17, ncols : 5
05-11 17:57:38.105+0900 I/SENSOR  ( 7494): 1.840081, 2.770889, 9.056834
05-11 17:57:38.130+0900 E/EFL     ( 7472): elementary<7472> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445bb408 into part 'elm.swallow.event.0'
05-11 17:57:38.170+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600003)
05-11 17:57:38.175+0900 I/APP_CORE( 7472): appcore-efl.c: __do_app(429) > [APP 7472] Event: RESET State: CREATED
05-11 17:57:38.175+0900 I/CAPI_APPFW_APPLICATION( 7472): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-11 17:57:38.190+0900 I/APP_CORE( 7472): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-11 17:57:38.190+0900 I/APP_CORE( 7472): appcore-efl.c: __do_app(474) > [APP 7472] Initial Launching, call the resume_cb
05-11 17:57:38.190+0900 I/CAPI_APPFW_APPLICATION( 7472): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-11 17:57:38.205+0900 I/SENSOR  ( 7494): 1.808974, 2.780460, 9.188439
05-11 17:57:38.245+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-11 17:57:38.250+0900 W/APP_CORE( 7472): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600003
05-11 17:57:38.300+0900 I/SENSOR  ( 7494): 1.818545, 2.847459, 9.044869
05-11 17:57:38.315+0900 I/APP_CORE( 7494): appcore-efl.c: __do_app(429) > [APP 7494] Event: PAUSE State: RUNNING
05-11 17:57:38.315+0900 I/CAPI_APPFW_APPLICATION( 7494): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-11 17:57:38.330+0900 I/APP_CORE( 7472): appcore-efl.c: __do_app(429) > [APP 7472] Event: RESUME State: RUNNING
05-11 17:57:38.330+0900 W/AUL_AMD (  484): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-11 17:57:38.330+0900 W/AUL_AMD (  484): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-11 17:57:38.410+0900 I/SENSOR  ( 7494): 1.892723, 2.861816, 9.047262
05-11 17:57:38.505+0900 I/SENSOR  ( 7494): 1.730011, 2.876173, 9.097511
05-11 17:57:38.605+0900 I/SENSOR  ( 7494): 1.741975, 2.825923, 8.977871
05-11 17:57:38.705+0900 I/SENSOR  ( 7494): 1.816152, 2.742175, 9.109475
05-11 17:57:38.745+0900 E/AUL     (  484): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-11 17:57:38.785+0900 I/MALI    ( 7472): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-11 17:57:38.805+0900 I/SENSOR  ( 7494): 1.739582, 2.792424, 9.052048
05-11 17:57:38.875+0900 E/EFL     ( 7472): evas_main<7472> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3407031 button=1 downs=1
05-11 17:57:38.900+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 14
05-11 17:57:38.905+0900 I/SENSOR  ( 7494): 1.481157, 3.175276, 9.030513
05-11 17:57:38.920+0900 W/AUL_AMD (  484): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7472
05-11 17:57:38.920+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 12
05-11 17:57:38.950+0900 E/EFL     ( 7472): evas_main<7472> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3407101 button=1 downs=0
05-11 17:57:39.005+0900 I/SENSOR  ( 7494): 2.067399, 2.634498, 9.111869
05-11 17:57:39.080+0900 D/TIMER   ( 7494): Timer is start
05-11 17:57:39.080+0900 D/TIMER   ( 7494): Remind time: 1184
05-11 17:57:39.105+0900 I/SENSOR  ( 7494): 1.938186, 2.914458, 9.078369
05-11 17:57:39.180+0900 E/EFL     ( 7472): elementary<7472> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(4456e2c8), freeze(1)
05-11 17:57:39.180+0900 E/EFL     ( 7472): elementary<7472> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(4456e2c8), freeze(1)
05-11 17:57:39.205+0900 I/SENSOR  ( 7494): 1.959722, 2.770889, 9.114261
05-11 17:57:39.305+0900 I/SENSOR  ( 7494): 1.940579, 2.672783, 9.128618
05-11 17:57:39.405+0900 I/SENSOR  ( 7494): 1.859223, 2.797210, 9.111869
05-11 17:57:39.425+0900 I/efl-extension( 7960): efl_extension.c: eext_mod_init(40) > Init
05-11 17:57:39.470+0900 I/UXT     ( 7960): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-11 17:57:39.505+0900 I/SENSOR  ( 7494): 4.211368, 3.019742, 9.135797
05-11 17:57:39.545+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 14
05-11 17:57:39.555+0900 W/AUL_AMD (  484): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6216
05-11 17:57:39.555+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 27
05-11 17:57:39.560+0900 I/APP_CORE( 6216): appcore-efl.c: __do_app(429) > [APP 6216] Event: TERMINATE State: PAUSED
05-11 17:57:39.565+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 22
05-11 17:57:39.565+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(890) > app status : 4
05-11 17:57:39.580+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 14
05-11 17:57:39.590+0900 W/AUL_AMD (  484): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7494
05-11 17:57:39.590+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 27
05-11 17:57:39.595+0900 I/APP_CORE( 7494): appcore-efl.c: __do_app(429) > [APP 7494] Event: TERMINATE State: PAUSED
05-11 17:57:39.595+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 22
05-11 17:57:39.595+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(890) > app status : 4
05-11 17:57:39.620+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 22
05-11 17:57:39.620+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(890) > app status : 4
05-11 17:57:39.625+0900 E/APP_CORE( 7472): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-11 17:57:39.625+0900 I/APP_CORE( 7472): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-11 17:57:39.625+0900 I/APP_CORE( 7472): appcore-efl.c: __after_loop(1090) > [APP 7472] PAUSE before termination
05-11 17:57:39.625+0900 I/CAPI_APPFW_APPLICATION( 7472): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-11 17:57:39.625+0900 I/CAPI_APPFW_APPLICATION( 7472): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-11 17:57:39.625+0900 I/efl-extension( 7472): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4456e2c8, obj: 0x4456e2c8
05-11 17:57:39.625+0900 I/efl-extension( 7472): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-11 17:57:39.625+0900 I/efl-extension( 7472): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-11 17:57:39.625+0900 I/efl-extension( 7472): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-11 17:57:39.625+0900 I/efl-extension( 7472): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-11 17:57:39.635+0900 I/efl-extension( 7472): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445b9788
05-11 17:57:39.635+0900 I/efl-extension( 7472): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-11 17:57:39.635+0900 I/efl-extension( 7472): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445d28a0 is freed
05-11 17:57:39.635+0900 I/efl-extension( 7472): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 17:57:39.635+0900 I/efl-extension( 7472): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4456e2c8, elm_scroller, func : 0x437c8ef1
05-11 17:57:39.635+0900 I/efl-extension( 7472): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 17:57:39.635+0900 I/efl-extension( 7472): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 17:57:39.635+0900 I/efl-extension( 7472): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445b9788, elm_image, func : 0x437c8ef1
05-11 17:57:39.635+0900 I/efl-extension( 7472): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 17:57:39.635+0900 I/efl-extension( 7472): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x4456e2c8 : elm_scroller] rotary callabck is deleted
05-11 17:57:39.660+0900 E/APP_CORE( 6216): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-11 17:57:39.660+0900 I/APP_CORE( 6216): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-11 17:57:39.660+0900 I/CAPI_APPFW_APPLICATION( 6216): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-11 17:57:39.680+0900 I/efl-extension( 6216): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-11 17:57:39.680+0900 I/efl-extension( 6216): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x45407520], circle_obj[0x45428168]!
05-11 17:57:39.680+0900 I/efl-extension( 6216): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x454d6a50 = w: 0 h: 0  obj 0x45407520 w: 360 h: 360
05-11 17:57:39.680+0900 I/efl-extension( 6216): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-11 17:57:39.685+0900 I/efl-extension( 6216): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44615738 is freed
05-11 17:57:39.685+0900 I/efl-extension( 6216): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x455c77d0 is freed
05-11 17:57:39.685+0900 I/efl-extension( 6216): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x442e6c00 is freed
05-11 17:57:39.685+0900 I/efl-extension( 6216): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44575a30 is freed
05-11 17:57:39.685+0900 I/APP_CORE( 7494): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-11 17:57:39.685+0900 I/CAPI_APPFW_APPLICATION( 7494): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-11 17:57:39.690+0900 I/efl-extension( 6216): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4456f9a8, obj: 0x4456f9a8
05-11 17:57:39.690+0900 I/efl-extension( 6216): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-11 17:57:39.690+0900 I/efl-extension( 6216): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-11 17:57:39.690+0900 I/efl-extension( 6216): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-11 17:57:39.690+0900 I/efl-extension( 6216): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-11 17:57:39.705+0900 I/efl-extension( 6216): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-11 17:57:39.705+0900 I/efl-extension( 6216): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x454d6a50 is freed
05-11 17:57:39.705+0900 I/efl-extension( 6216): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x45407520
05-11 17:57:39.705+0900 I/efl-extension( 6216): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 17:57:39.705+0900 I/efl-extension( 6216): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4456f9a8, elm_genlist, func : 0x437e9dfd
05-11 17:57:39.705+0900 I/efl-extension( 6216): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 17:57:39.720+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-11 17:57:39.750+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-11 17:57:39.750+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
05-11 17:57:39.755+0900 W/AUL_AMD (  484): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-11 17:57:39.755+0900 W/AUL_AMD (  484): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-11 17:57:39.765+0900 I/efl-extension( 7494): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44106878
05-11 17:57:39.765+0900 I/efl-extension( 7494): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44106878, obj: 0x44106878
05-11 17:57:39.765+0900 I/efl-extension( 7494): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-11 17:57:39.770+0900 I/SENSOR  ( 7494): 1.564906, 2.888137, 9.207582
05-11 17:57:39.775+0900 I/MALI    ( 6216): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-11 17:57:39.775+0900 I/MALI    ( 6216): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=6216   close drm_fd=22 
05-11 17:57:39.775+0900 I/MALI    ( 6216): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-11 17:57:39.780+0900 I/SENSOR  ( 7494): -1.217947, 1.538585, 11.088341
05-11 17:57:39.780+0900 W/W_HOME  (  688): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-11 17:57:39.780+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:39.780+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:39.785+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:39.785+0900 W/W_HOME  (  688): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-11 17:57:39.795+0900 W/W_HOME  (  688): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-11 17:57:39.795+0900 W/W_HOME  (  688): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-11 17:57:39.795+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:39.795+0900 W/W_HOME  (  688): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-11 17:57:39.795+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: RESUME State: PAUSED
05-11 17:57:39.795+0900 I/CAPI_APPFW_APPLICATION(  688): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-11 17:57:39.795+0900 W/W_HOME  (  688): main.c: _appcore_resume_cb(681) > appcore resume
05-11 17:57:39.795+0900 W/W_HOME  (  688): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-11 17:57:39.795+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:39.795+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:39.795+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:39.795+0900 W/APPS    (  688): apps_main.c: _time_changed_cb(295) >  date : 11->11
05-11 17:57:39.795+0900 W/W_HOME  (  688): rotary.c: rotary_attach(138) > rotary_attach:0x476bd370
05-11 17:57:39.795+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x476bd370, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-11 17:57:39.795+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-11 17:57:39.800+0900 I/MALI    ( 7472): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-11 17:57:39.800+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-11 17:57:39.800+0900 E/wnotib  (  688): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-11 17:57:39.800+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1692) > Do the postponed update job.
05-11 17:57:39.820+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 17:57:39.820+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:57:39.820+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:57:39.820+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:57:39.820+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1059) > idler for type: 0
05-11 17:57:39.850+0900 I/MALI    ( 7472): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-11 17:57:39.870+0900 I/MALI    ( 7472): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=7472   close drm_fd=21 
05-11 17:57:39.870+0900 I/MALI    ( 7472): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-11 17:57:39.870+0900 I/UXT     ( 7494): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-11 17:57:39.870+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 17:57:39.885+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 17:57:39.890+0900 I/UXT     ( 6216): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-11 17:57:39.900+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 17:57:39.900+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 17:57:39.935+0900 I/AUL_PAD ( 7960): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-11 17:57:39.935+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 17:57:39.945+0900 I/wnoti-proxy(  688): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 17:57:39.955+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1106) > unread_count: 6
05-11 17:57:39.955+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(626) > category_id: 115, application_id: 218, application_name: 카카오톡, time_stamp: 1462957042, content_id: 0, spannable_string_version: 1
05-11 17:57:39.955+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 17:57:39.955+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 17:57:39.955+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 17:57:39.960+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 17:57:39.965+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 17:57:39.965+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 17:57:39.965+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 17:57:39.965+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 17:57:39.965+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 17:57:39.965+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 17:57:39.970+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 17:57:39.970+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 17:57:39.970+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 17:57:39.970+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 17:57:39.970+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 17:57:39.975+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 17:57:39.975+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 17:57:39.975+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 17:57:39.980+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 17:57:39.980+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 17:57:39.980+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 17:57:39.980+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 17:57:39.980+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 17:57:39.980+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 17:57:39.980+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  115, 카카오톡.
05-11 17:57:39.980+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 1
05-11 17:57:39.995+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 17:57:39.995+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 17:57:39.995+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 17:57:39.995+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 17:57:39.995+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-11 17:57:39.995+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 17:57:39.995+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 17:57:39.995+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 17:57:39.995+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 17:57:39.995+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 17:57:39.995+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 17:57:39.995+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  115, 카카오톡.
05-11 17:57:39.995+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 1
05-11 17:57:40.005+0900 I/UXT     ( 7472): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-11 17:57:40.010+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 17:57:40.010+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 17:57:40.010+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 17:57:40.010+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 17:57:40.010+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-11 17:57:40.015+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-11 17:57:40.015+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-11 17:57:40.015+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-11 17:57:40.015+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-11 17:57:40.015+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-11 17:57:40.015+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-11 17:57:40.015+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  115, 카카오톡.
05-11 17:57:40.015+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 1
05-11 17:57:40.030+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 17:57:40.030+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 17:57:40.030+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 17:57:40.030+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 17:57:40.030+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-11 17:57:40.030+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 13
05-11 17:57:40.035+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 17:57:40.035+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 17:57:40.035+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 17:57:40.035+0900 E/TIZEN_N_SYSTEM_SETTINGS(  688): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 17:57:40.035+0900 I/wnotib  (  688): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-11 17:57:40.045+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1378) > This noti will be removed from panel: 115, 카카오톡.
05-11 17:57:40.045+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 2
05-11 17:57:40.045+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2986) > We don't need to delete the item for second_depth_type: 0.
05-11 17:57:40.045+0900 E/EFL     (  688): elementary<688> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
05-11 17:57:40.045+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1378) > This noti will be removed from panel: 115, 카카오톡.
05-11 17:57:40.045+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 2
05-11 17:57:40.045+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2986) > We don't need to delete the item for second_depth_type: 0.
05-11 17:57:40.045+0900 E/EFL     (  688): elementary<688> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
05-11 17:57:40.045+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1378) > This noti will be removed from panel: 115, 카카오톡.
05-11 17:57:40.045+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 2
05-11 17:57:40.045+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2986) > We don't need to delete the item for second_depth_type: 0.
05-11 17:57:40.050+0900 E/EFL     (  688): elementary<688> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
05-11 17:57:40.050+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 115, application_id: 218, type: 12
05-11 17:57:40.050+0900 I/wnotib  (  688): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-11 17:57:40.050+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1387) > Num categories: 1, num total noti: 6
05-11 17:57:40.050+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(871) > Free noti manager data.
05-11 17:57:40.050+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(876) > Free previous notifications.
05-11 17:57:40.055+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(897) > Free previous categories.
05-11 17:57:40.055+0900 I/wnotib  (  688): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
05-11 17:57:40.055+0900 I/wnotib  (  688): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
05-11 17:57:40.055+0900 I/wnotib  (  688): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
05-11 17:57:40.055+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1412) > num_total_panel: 1.
05-11 17:57:40.055+0900 W/W_HOME  (  688): noti_broker.c: _handler_indicator_update(562) > 0x1
05-11 17:57:40.060+0900 E/TBM     ( 7960): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-11 17:57:40.075+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1416) > unread_count_for_home: 6
05-11 17:57:40.075+0900 W/W_HOME  (  688): noti_broker.c: _handler_noti_indicator_show(478) > 
05-11 17:57:40.080+0900 W/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-11 17:57:40.130+0900 I/efl-extension( 6216): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-11 17:57:40.150+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 17:57:40.150+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 17:57:40.175+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-11 17:57:40.175+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-11 17:57:40.175+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-11 17:57:40.180+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-11 17:57:40.180+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
05-11 17:57:40.180+0900 W/W_HOME  (  688): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-11 17:57:40.180+0900 W/W_HOME  (  688): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-11 17:57:40.180+0900 W/W_HOME  (  688): gesture.c: _manual_render_enable(133) > 1
05-11 17:57:40.180+0900 W/W_HOME  (  688): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-11 17:57:40.180+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:40.180+0900 W/STARTER (  678): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
05-11 17:57:40.180+0900 W/STARTER (  678): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-11 17:57:40.180+0900 E/STARTER (  678): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-11 17:57:40.180+0900 W/STARTER (  678): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-11 17:57:40.180+0900 W/STARTER (  678): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-11 17:57:40.230+0900 I/TIZEN_N_SOUND_MANAGER( 1059): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-11 17:57:40.255+0900 I/TIZEN_N_SOUND_MANAGER( 1059): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-11 17:57:40.255+0900 W/TIZEN_N_SOUND_MANAGER( 1059): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-11 17:57:40.255+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-11 17:57:40.255+0900 I/HIGEAR  ( 1059): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-11 17:57:40.350+0900 I/SHealth_Common( 1004): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-11 17:57:40.360+0900 I/efl-extension( 7472): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-11 17:57:40.370+0900 W/MUSIC_CONTROL_SERVICE( 1061): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-11 17:57:40.370+0900 I/SHealth_Service( 1004): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-11 17:57:40.375+0900 W/STARTER (  678): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
05-11 17:57:40.375+0900 W/STARTER (  678): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-11 17:57:40.375+0900 W/STARTER (  678): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-11 17:57:40.375+0900 W/STARTER (  678): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-11 17:57:40.390+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: PAUSE State: RUNNING
05-11 17:57:40.390+0900 I/CAPI_APPFW_APPLICATION(  688): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-11 17:57:40.390+0900 W/W_HOME  (  688): main.c: _appcore_pause_cb(690) > appcore pause
05-11 17:57:40.390+0900 W/W_HOME  (  688): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-11 17:57:40.390+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:40.390+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:40.390+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:57:40.390+0900 W/W_HOME  (  688): rotary.c: rotary_deattach(156) > rotary_deattach:0x476bd370
05-11 17:57:40.390+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 17:57:40.390+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x476bd370, elm_layout, func : 0x4004b469
05-11 17:57:40.390+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-11 17:57:40.390+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-11 17:57:40.390+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 17:57:40.390+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x476bd370, activated : 1
05-11 17:57:40.390+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-11 17:57:40.390+0900 E/wnotib  (  688): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-11 17:57:40.390+0900 I/wnotib  (  688): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 115, 218.
05-11 17:57:40.390+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-11 17:57:40.420+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 17:57:40.420+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 17:57:40.420+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 17:57:40.420+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-11 17:57:40.420+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-11 17:57:40.420+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 17:57:40.420+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-11 17:57:40.420+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 17:57:40.425+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 17:57:40.425+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 17:57:40.425+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 17:57:40.425+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-11 17:57:40.425+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-11 17:57:40.425+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 17:57:40.425+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-11 17:57:40.425+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-11 17:57:40.425+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-11 17:57:40.425+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 17:57:40.425+0900 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-11 17:57:40.425+0900 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
05-11 17:57:40.430+0900 E/ALARM_MANAGER(  678): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(11-5-2016, 17:58:00), repeat(1), interval(20), type(-1073741822)
05-11 17:57:40.440+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:57:40.440+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 17:57:40.445+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-11 17:57:40.450+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-11 17:57:40.505+0900 I/AUL_AMD (  484): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7494
05-11 17:57:40.540+0900 E/ALARM_MANAGER(  482): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 362731511, next duetime: 1462957080
05-11 17:57:40.540+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(362731511)
05-11 17:57:40.540+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1462957748), due_time(1462957080)
05-11 17:57:40.540+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-11 17:57:40.540+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 11-5-2016, 08:58:00 (UTC).
05-11 17:57:40.540+0900 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-11 17:57:40.555+0900 W/APPS    (  688): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-11 17:57:40.640+0900 W/CRASH_MANAGER( 7967): worker.c: worker_job(1199) > 1107494706831146295706
