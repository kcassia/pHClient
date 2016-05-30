S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 22431
Date: 2016-05-27 21:53:02+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x45a53398, r5   = 0x41561ff1
r6   = 0x45a53c98, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x45a52618
r10  = 0x418855a8, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbec38630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     36032 KB
Buffers:     36484 KB
Cached:     130224 KB
VmPeak:      96160 KB
VmSize:      88448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21700 KB
VmRSS:       19492 KB
VmData:      34032 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23960 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 22431 TID = 22431
22431 22552 22620 22625 

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
43892000 44091000 rwxp [stack:22620]
44092000 44891000 rwxp [stack:22625]
44a2c000 4522b000 rwxp [stack:22552]
457b1000 457b4000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45827000 4585f000 r-xp /usr/lib/libpulse.so.0.16.2
458d4000 458d9000 r-xp /usr/lib/libjson.so.0.0.1
458e1000 45929000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4592a000 4596d000 r-xp /usr/lib/libsndfile.so.1.0.25
4597a000 4599c000 r-xp /usr/lib/libvorbis.so.0.4.3
459a4000 459a8000 r-xp /usr/lib/libogg.so.0.7.1
bec18000 bec39000 rwxp [stack]
End of Maps Information

Callstack Information (PID:22431)
Call Stack Count: 2
 0: cfree + 0xc8 (0x404e41e8) [/lib/libc.so.6] + 0x6f1e8
 1: (0x1) (null)
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
button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-27 21:53:00.789+0900 E/W_TASKMANAGER(22503): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-27 21:53:00.789+0900 E/W_TASKMANAGER(22503): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-27 21:53:00.834+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.834+0900 E/W_TASKMANAGER(22503): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:53:00.839+0900 E/RUA     (22503): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 17, ncols : 5
05-27 21:53:00.869+0900 E/EFL     (22503): elementary<22503> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c0f00 into part 'elm.swallow.event.0'
05-27 21:53:00.909+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05000003)
05-27 21:53:00.909+0900 I/APP_CORE(22503): appcore-efl.c: __do_app(429) > [APP 22503] Event: RESET State: CREATED
05-27 21:53:00.914+0900 I/CAPI_APPFW_APPLICATION(22503): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-27 21:53:00.929+0900 I/APP_CORE(22503): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-27 21:53:00.929+0900 I/APP_CORE(22503): appcore-efl.c: __do_app(474) > [APP 22503] Initial Launching, call the resume_cb
05-27 21:53:00.929+0900 I/CAPI_APPFW_APPLICATION(22503): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 21:53:00.954+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x05000003)
05-27 21:53:00.984+0900 W/APP_CORE(22503): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5000003
05-27 21:53:01.079+0900 I/APP_CORE(22503): appcore-efl.c: __do_app(429) > [APP 22503] Event: RESUME State: RUNNING
05-27 21:53:01.084+0900 I/APP_CORE(22431): appcore-efl.c: __do_app(429) > [APP 22431] Event: PAUSE State: RUNNING
05-27 21:53:01.084+0900 I/CAPI_APPFW_APPLICATION(22431): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-27 21:53:01.099+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 21:53:01.099+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 21:53:01.489+0900 E/AUL     (  492): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 21:53:01.529+0900 I/MALI    (22503): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-27 21:53:01.604+0900 E/EFL     (22503): evas_main<22503> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9658589 button=1 downs=1
05-27 21:53:01.644+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 21:53:01.654+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.654+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.659+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22503
05-27 21:53:01.659+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.659+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 21:53:01.664+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.669+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.669+0900 E/EFL     (22503): evas_main<22503> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9658663 button=1 downs=0
05-27 21:53:01.669+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.679+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.679+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.679+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.684+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.684+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.689+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.699+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.699+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.699+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.704+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.704+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.709+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.714+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.714+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.719+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.719+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.719+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.724+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.729+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.734+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.739+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.739+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.739+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.744+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.749+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.749+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.749+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.769+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.769+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.769+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.779+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.779+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.784+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.789+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.789+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.789+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.799+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.799+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.804+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.809+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.809+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.814+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.814+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.814+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.819+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.824+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.824+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.824+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.834+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.834+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.844+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.869+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.869+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.874+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.879+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.879+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.879+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.884+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.884+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.884+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.889+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.894+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.894+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.899+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.899+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.904+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.909+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.909+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.909+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.914+0900 E/EFL     (22503): elementary<22503> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573e40), freeze(1)
05-27 21:53:01.914+0900 E/EFL     (22503): elementary<22503> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573e40), freeze(1)
05-27 21:53:01.914+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.914+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.924+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.929+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.929+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.929+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.934+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.934+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.944+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.959+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.959+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.959+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.964+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.964+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.969+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.969+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.969+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.974+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.984+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.984+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.984+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.989+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.989+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.989+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:01.994+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:01.994+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:01.999+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.009+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.009+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.014+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.019+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.019+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.019+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.024+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.024+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.029+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.034+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.039+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.044+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.049+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.049+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.049+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.054+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.054+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.059+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.059+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.059+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.064+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.069+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.069+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.074+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.074+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.074+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.079+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.084+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.084+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.089+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.099+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.099+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.109+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.114+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.114+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.119+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.124+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.124+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.124+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.129+0900 I/SOCKETTEST(22431): Success to socket connection
05-27 21:53:02.129+0900 I/SOCKETTEST(22431): write() check msg success
05-27 21:53:02.129+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.139+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.139+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.139+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.144+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.144+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.149+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.154+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.154+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.159+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.159+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.159+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.164+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.169+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.169+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.169+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.174+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.174+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.174+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.179+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.179+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.184+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.194+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.194+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.194+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.199+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.199+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.204+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.214+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.214+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.219+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.244+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.244+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.249+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.254+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.254+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.254+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.269+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.274+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.279+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.279+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.284+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.284+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 21:53:02.294+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22431
05-27 21:53:02.294+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 27
05-27 21:53:02.299+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.304+0900 I/APP_CORE(22431): appcore-efl.c: __do_app(429) > [APP 22431] Event: TERMINATE State: PAUSED
05-27 21:53:02.304+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 21:53:02.304+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 21:53:02.309+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.309+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.309+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.314+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.314+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.314+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.319+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.319+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.324+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.324+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 21:53:02.324+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 21:53:02.324+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.324+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.329+0900 E/APP_CORE(22503): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-27 21:53:02.329+0900 I/APP_CORE(22503): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 21:53:02.329+0900 I/APP_CORE(22503): appcore-efl.c: __after_loop(1090) > [APP 22503] PAUSE before termination
05-27 21:53:02.329+0900 I/CAPI_APPFW_APPLICATION(22503): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 21:53:02.329+0900 I/CAPI_APPFW_APPLICATION(22503): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-27 21:53:02.329+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.334+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.334+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.334+0900 I/efl-extension(22503): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44573e40, obj: 0x44573e40
05-27 21:53:02.334+0900 I/efl-extension(22503): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 21:53:02.334+0900 I/efl-extension(22503): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 21:53:02.334+0900 I/efl-extension(22503): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 21:53:02.334+0900 I/efl-extension(22503): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 21:53:02.334+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.339+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.339+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.339+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.344+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.344+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.349+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.349+0900 I/efl-extension(22503): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445bf280
05-27 21:53:02.349+0900 I/efl-extension(22503): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 21:53:02.349+0900 I/efl-extension(22503): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445b3ea8 is freed
05-27 21:53:02.349+0900 I/efl-extension(22503): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 21:53:02.349+0900 I/efl-extension(22503): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44573e40, elm_scroller, func : 0x437c8ef1
05-27 21:53:02.349+0900 I/efl-extension(22503): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 21:53:02.349+0900 I/efl-extension(22503): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 21:53:02.349+0900 I/efl-extension(22503): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445bf280, elm_image, func : 0x437c8ef1
05-27 21:53:02.349+0900 I/efl-extension(22503): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 21:53:02.349+0900 I/efl-extension(22503): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44573e40 : elm_scroller] rotary callabck is deleted
05-27 21:53:02.349+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.349+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.354+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.359+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.359+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.359+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.364+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.364+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.369+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.369+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.369+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.374+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.379+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.379+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.379+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.384+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.384+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.384+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.389+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.389+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.389+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.394+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.394+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.394+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.399+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.399+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.399+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.404+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.404+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.404+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.404+0900 I/efl-extension(22639): efl_extension.c: eext_mod_init(40) > Init
05-27 21:53:02.409+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.409+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.409+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.414+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.414+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.419+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.419+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.419+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.424+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.429+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.429+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.429+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.434+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.434+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.434+0900 I/APP_CORE(22431): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 21:53:02.434+0900 I/CAPI_APPFW_APPLICATION(22431): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 21:53:02.434+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.449+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.449+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.449+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.454+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.454+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.454+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.459+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.459+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.459+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.464+0900 I/UXT     (22639): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-27 21:53:02.464+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.464+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.469+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.469+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.469+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.474+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.474+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-27 21:53:02.479+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.479+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.479+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.484+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.484+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.484+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.489+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.489+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.489+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.494+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.494+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.494+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.499+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.499+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.499+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.504+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.504+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.509+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.514+0900 I/MALI    (22503): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-27 21:53:02.514+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.514+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.519+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.524+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.524+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.524+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.529+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.529+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.534+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.539+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.539+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.539+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.544+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-27 21:53:02.544+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 21:53:02.544+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:53:02.544+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:53:02.544+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:53:02.544+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.549+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.549+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.549+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.549+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.554+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.554+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 21:53:02.554+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 21:53:02.559+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.559+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.564+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.564+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.564+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.569+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.569+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.569+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.574+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.574+0900 I/MALI    (22503): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-27 21:53:02.574+0900 I/MALI    (22503): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=22503   close drm_fd=22 
05-27 21:53:02.574+0900 I/MALI    (22503): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-27 21:53:02.579+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.579+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.579+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.584+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.584+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.589+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.594+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.594+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.594+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.599+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.599+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.599+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.609+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.609+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.614+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.614+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.614+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.614+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 21:53:02.614+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:53:02.614+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:53:02.614+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.619+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:53:02.619+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 21:53:02.619+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 21:53:02.619+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 21:53:02.619+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:53:02.619+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 21:53:02.619+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-27 21:53:02.619+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 21:53:02.619+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-27 21:53:02.619+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-27 21:53:02.619+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:53:02.619+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:53:02.619+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 21:53:02.619+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 21:53:02.619+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x45d4d480
05-27 21:53:02.619+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d4d480, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 21:53:02.619+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 21:53:02.619+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 21:53:02.619+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 21:53:02.619+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 21:53:02.624+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 21:53:02.624+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 21:53:02.624+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 21:53:02.624+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 21:53:02.629+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.629+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.629+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.634+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.634+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.634+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.639+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.639+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.639+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.644+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.644+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.644+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.669+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.669+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.669+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.669+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.669+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.674+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.674+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.674+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.679+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.679+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.679+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.684+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.684+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.684+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.689+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.689+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.689+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.694+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.694+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.694+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.694+0900 I/UXT     (22503): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 21:53:02.694+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.699+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.699+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.699+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.704+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.704+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.704+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.709+0900 I/UXT     (22431): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 21:53:02.709+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.709+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.709+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.714+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.714+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.714+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.719+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.719+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.724+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.729+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.729+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.729+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.729+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.729+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.734+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.739+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.739+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.739+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.744+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.744+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.744+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.749+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.749+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.749+0900 I/AUL_PAD (22639): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-27 21:53:02.749+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.754+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.754+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.754+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.759+0900 I/SOCKETTEST(22431): socket connect error: Connection refused
05-27 21:53:02.759+0900 I/SOCKETTEST(22431): write() check msg error: Bad file descriptor
05-27 21:53:02.759+0900 I/SOCKETTEST(22431): Success to create check socket
05-27 21:53:02.789+0900 E/TBM     (22639): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-27 21:53:03.009+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 21:53:03.024+0900 I/efl-extension(22503): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-27 21:53:03.109+0900 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-27 21:53:03.114+0900 E/EFL     (  732): evas_main<732> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9660109 button=1 downs=1
05-27 21:53:03.114+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [166, 183]
05-27 21:53:03.134+0900 W/CRASH_MANAGER(22524): worker.c: worker_job(1199) > 1122431706831146435358
