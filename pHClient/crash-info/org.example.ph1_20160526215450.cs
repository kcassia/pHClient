S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 6325
Date: 2016-05-26 21:54:50+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x44b01e18, r5   = 0x41561d39
r6   = 0x44b02718, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x44b01098
r10  = 0x41885bc8, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbe9b3630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:      9808 KB
Buffers:     24268 KB
Cached:     168560 KB
VmPeak:      94712 KB
VmSize:      89456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21348 KB
VmRSS:       20148 KB
VmData:      35040 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23960 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6325 TID = 6325
6325 6362 6429 

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
43892000 44091000 rwxp [stack:6429]
44c9a000 45499000 rwxp [stack:6362]
45838000 4583b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
458ae000 458e6000 r-xp /usr/lib/libpulse.so.0.16.2
4595b000 45960000 r-xp /usr/lib/libjson.so.0.0.1
45968000 459b0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
459b1000 459f4000 r-xp /usr/lib/libsndfile.so.1.0.25
45a01000 45a23000 r-xp /usr/lib/libvorbis.so.0.4.3
45a2b000 45a2f000 r-xp /usr/lib/libogg.so.0.7.1
be993000 be9b4000 rwxp [stack]
End of Maps Information

Callstack Information (PID:6325)
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
 ( 1155): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 21:53:25.271+0900 W/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 21:53:25.311+0900 I/efl-extension( 6325): efl_extension.c: eext_mod_init(40) > Init
05-26 21:53:25.311+0900 I/UXT     ( 6325): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 21:53:25.321+0900 I/CAPI_APPFW_APPLICATION( 6325): app_main.c: ui_app_main(704) > app_efl_main
05-26 21:53:25.326+0900 I/CAPI_APPFW_APPLICATION( 6325): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-26 21:53:25.361+0900 E/TBM     ( 6325): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 21:53:25.376+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:53:25.376+0900 E/RESOURCED(  497): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-26 21:53:25.436+0900 E/EFL     ( 6325): <6325> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-26 21:53:25.446+0900 E/EFL     ( 6325): <6325> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 21:53:25.446+0900 E/EFL     ( 6325): <6325> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 21:53:25.446+0900 E/EFL     ( 6325): <6325> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 21:53:25.446+0900 E/EFL     ( 6325): <6325> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 21:53:25.446+0900 E/EFL     ( 6325): <6325> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 21:53:25.491+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03e00002)
05-26 21:53:25.516+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 21:53:25.521+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:53:25.521+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:53:25.521+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:53:25.521+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 21:53:25.521+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:53:25.521+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:53:25.546+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 21:53:25.546+0900 I/APP_CORE( 6325): appcore-efl.c: __do_app(429) > [APP 6325] Event: RESET State: CREATED
05-26 21:53:25.546+0900 I/CAPI_APPFW_APPLICATION( 6325): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 21:53:25.571+0900 I/APP_CORE( 6325): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 21:53:25.571+0900 I/APP_CORE( 6325): appcore-efl.c: __do_app(474) > [APP 6325] Initial Launching, call the resume_cb
05-26 21:53:25.571+0900 I/CAPI_APPFW_APPLICATION( 6325): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 21:53:25.651+0900 W/APP_CORE( 6325): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00002
05-26 21:53:25.741+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 21:53:25.746+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:53:25.746+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:53:25.756+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 21:53:25.756+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:53:25.756+0900 W/W_HOME  (  737): event_manager.c: _state_control(333) > appcore paused manually
05-26 21:53:25.756+0900 W/W_HOME  (  737): main.c: home_appcore_pause(717) > Home Appcore Paused
05-26 21:53:25.756+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 21:53:25.756+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:53:25.756+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:53:25.756+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:53:25.756+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 21:53:25.756+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:53:25.756+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 21:53:25.756+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:53:25.761+0900 I/APP_CORE( 6325): appcore-efl.c: __do_app(429) > [APP 6325] Event: RESUME State: RUNNING
05-26 21:53:25.761+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:53:25.761+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:53:25.761+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 21:53:25.761+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:53:25.761+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:53:25.761+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 34, 218.
05-26 21:53:25.761+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:53:25.771+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:53:25.771+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 21:53:25.776+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:53:25.776+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:53:25.776+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 21:53:25.776+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 21:53:25.776+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 21:53:25.776+0900 E/W_HOME  (  737): main.c: _pause_cb(668) > paused already
05-26 21:53:25.796+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 21:53:25.816+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 21:53:25.826+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 21:53:25.826+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:53:25.841+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 21:53:26.131+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:53:26.271+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:53:26.451+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1243499 button=1 downs=1
05-26 21:53:26.476+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:53:26.491+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6325
05-26 21:53:26.501+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1243548 button=1 downs=0
05-26 21:53:26.516+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:53:26.766+0900 I/AUL_PAD ( 6363): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 21:53:27.056+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1244102 button=1 downs=1
05-26 21:53:27.146+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1244199 button=1 downs=0
05-26 21:53:27.431+0900 I/CAPI_NETWORK_CONNECTION( 6325): connection.c: connection_create(372) > New handle created[0x44b37050]
05-26 21:53:27.456+0900 I/SOCKETTEST( 6325): IP : 
05-26 21:53:27.461+0900 I/SOCKETTEST( 6325): Success to create UDP socket
05-26 21:53:27.461+0900 I/SOCKETTEST( 6325): Bind Success
05-26 21:53:27.461+0900 I/SOCKETTEST( 6325): Waiting DATA...
05-26 21:53:29.251+0900 I/SOCKETTEST( 6325): Receive Data : 192.168.0.47
05-26 21:53:29.251+0900 I/SOCKETTEST( 6325): Changed IP : 192.168.0.47
05-26 21:53:29.316+0900 I/SOCKETTEST( 6325): Success to create socket
05-26 21:53:29.326+0900 I/SOCKETTEST( 6325): Success to socket connection
05-26 21:53:29.326+0900 I/SOCKETTEST( 6325): write() 성공
05-26 21:53:29.511+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:29.511+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:30.561+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1247609 button=1 downs=1
05-26 21:53:30.601+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1247651 button=1 downs=0
05-26 21:53:30.621+0900 D/TIMER   ( 6325): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:53:30.621+0900 D/TIMER   ( 6325): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:53:30.676+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:53:30.676+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:53:30.681+0900 I/efl-extension( 6325): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:53:30.681+0900 I/efl-extension( 6325): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:53:30.681+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x41897768, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:53:30.776+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:53:31.526+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1248577 button=1 downs=1
05-26 21:53:31.616+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1248665 button=1 downs=0
05-26 21:53:32.116+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.121+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.121+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.121+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897768, elm_layout, time_stamp : 1249167
05-26 21:53:32.121+0900 E/TIMER   ( 6325): (ad->timer) -> _rotary_cb() return
05-26 21:53:32.126+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.126+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.126+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897768, elm_layout, time_stamp : 1249177
05-26 21:53:32.126+0900 E/TIMER   ( 6325): (ad->timer) -> _rotary_cb() return
05-26 21:53:32.126+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.146+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.146+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.146+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897768, elm_layout, time_stamp : 1249197
05-26 21:53:32.146+0900 E/TIMER   ( 6325): (ad->timer) -> _rotary_cb() return
05-26 21:53:32.146+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.201+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.201+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.206+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897768, elm_layout, time_stamp : 1249253
05-26 21:53:32.206+0900 E/TIMER   ( 6325): (ad->timer) -> _rotary_cb() return
05-26 21:53:32.206+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.341+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.341+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.341+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.341+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897768, elm_layout, time_stamp : 1249388
05-26 21:53:32.341+0900 E/TIMER   ( 6325): (ad->timer) -> _rotary_cb() return
05-26 21:53:32.386+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.386+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.386+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897768, elm_layout, time_stamp : 1249433
05-26 21:53:32.386+0900 E/TIMER   ( 6325): (ad->timer) -> _rotary_cb() return
05-26 21:53:32.386+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.426+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.426+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.426+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897768, elm_layout, time_stamp : 1249475
05-26 21:53:32.426+0900 E/TIMER   ( 6325): (ad->timer) -> _rotary_cb() return
05-26 21:53:32.426+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:32.836+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1249882 button=1 downs=1
05-26 21:53:32.861+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1249908 button=1 downs=0
05-26 21:53:32.861+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:53:32.861+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x41897768, elm_layout, func : 0x41560871
05-26 21:53:32.861+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:53:32.861+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:53:32.861+0900 I/efl-extension( 6325): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:53:32.861+0900 I/efl-extension( 6325): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:53:32.861+0900 I/efl-extension( 6325): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:53:32.861+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:53:32.861+0900 E/EFL     ( 6325): ecore<6325> ecore.c:574 _ecore_magic_fail() 
05-26 21:53:32.861+0900 E/EFL     ( 6325): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:53:32.861+0900 E/EFL     ( 6325): *** IN FUNCTION: ecore_timer_del()
05-26 21:53:32.861+0900 E/EFL     ( 6325): ecore<6325> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:53:32.861+0900 E/EFL     ( 6325):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:53:32.861+0900 E/EFL     ( 6325):     Supplied: 0049a1bd - <UNKNOWN>
05-26 21:53:32.861+0900 E/EFL     ( 6325): ecore<6325> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:53:32.861+0900 E/EFL     ( 6325): *** SPANK SPANK SPANK!!!
05-26 21:53:32.861+0900 E/EFL     ( 6325): *** Now go fix your code. Tut tut tut!
05-26 21:53:32.861+0900 I/SOCKETTEST( 6325): Success to create socket
05-26 21:53:32.871+0900 I/SOCKETTEST( 6325): Success to socket connection
05-26 21:53:32.871+0900 I/SOCKETTEST( 6325): write() 성공
05-26 21:53:33.351+0900 I/efl-extension( 6325): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x41897768
05-26 21:53:33.351+0900 I/efl-extension( 6325): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x41897768, obj: 0x41897768
05-26 21:53:33.356+0900 I/efl-extension( 6325): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:53:34.041+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1251086 button=1 downs=1
05-26 21:53:34.096+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1251144 button=1 downs=0
05-26 21:53:34.096+0900 D/TIMER   ( 6325): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:53:34.096+0900 D/TIMER   ( 6325): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:53:34.111+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:53:34.111+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x418978e8, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:53:34.766+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1251817 button=1 downs=1
05-26 21:53:34.826+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1251877 button=1 downs=0
05-26 21:53:35.476+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1252525 button=1 downs=1
05-26 21:53:35.541+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1252591 button=1 downs=0
05-26 21:53:36.006+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.006+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.006+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.006+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418978e8, elm_layout, time_stamp : 1253056
05-26 21:53:36.051+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.051+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.051+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.051+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418978e8, elm_layout, time_stamp : 1253099
05-26 21:53:36.101+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.101+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.101+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418978e8, elm_layout, time_stamp : 1253152
05-26 21:53:36.106+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.146+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.146+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.146+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418978e8, elm_layout, time_stamp : 1253194
05-26 21:53:36.146+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.201+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.201+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.201+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418978e8, elm_layout, time_stamp : 1253251
05-26 21:53:36.206+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.356+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.356+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.361+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.361+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418978e8, elm_layout, time_stamp : 1253408
05-26 21:53:36.491+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.491+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.491+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.491+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418978e8, elm_layout, time_stamp : 1253538
05-26 21:53:36.646+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.646+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.646+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:36.646+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418978e8, elm_layout, time_stamp : 1253694
05-26 21:53:37.591+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:37.591+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:37.591+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418978e8, elm_layout, time_stamp : 1254637
05-26 21:53:37.591+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:37.701+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:37.701+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:37.701+0900 I/efl-extension( 6325): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:53:37.701+0900 I/efl-extension( 6325): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418978e8, elm_layout, time_stamp : 1254749
05-26 21:53:38.441+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1255487 button=1 downs=1
05-26 21:53:38.496+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1255545 button=1 downs=0
05-26 21:53:38.496+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:53:38.496+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x418978e8, elm_layout, func : 0x41560871
05-26 21:53:38.496+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:53:38.501+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:53:38.501+0900 I/efl-extension( 6325): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:53:38.501+0900 I/efl-extension( 6325): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:53:38.501+0900 I/efl-extension( 6325): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:53:38.501+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:53:38.501+0900 D/TIMER   ( 6325): Setting time is 600
05-26 21:53:38.586+0900 I/SOCKETTEST( 6325): Success to create socket
05-26 21:53:38.611+0900 I/SOCKETTEST( 6325): Success to socket connection
05-26 21:53:38.611+0900 I/SOCKETTEST( 6325): write() 성공
05-26 21:53:38.651+0900 I/SENSOR  ( 6325): 199.149994, 160.720001, 50.680000
05-26 21:53:38.701+0900 I/SENSOR  ( 6325): -17.780001, 9.590000, 24.219999
05-26 21:53:38.801+0900 I/SENSOR  ( 6325): -1.050000, -7.140000, 5.810000
05-26 21:53:38.911+0900 I/SENSOR  ( 6325): -2.590000, -3.500000, 4.270000
05-26 21:53:39.006+0900 I/SENSOR  ( 6325): 6.790000, -11.130000, -1.330000
05-26 21:53:39.106+0900 I/SENSOR  ( 6325): 14.210000, -22.540001, -16.240000
05-26 21:53:39.201+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1256244 button=1 downs=1
05-26 21:53:39.201+0900 I/SENSOR  ( 6325): -18.620001, -13.720000, -18.969999
05-26 21:53:39.286+0900 E/EFL     ( 6325): evas_main<6325> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1256336 button=1 downs=0
05-26 21:53:39.286+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:53:39.286+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x418978e8, elm_layout, func : 0x41560871
05-26 21:53:39.286+0900 I/efl-extension( 6325): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:53:39.291+0900 I/efl-extension( 6325): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:53:39.291+0900 I/efl-extension( 6325): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:53:39.291+0900 I/efl-extension( 6325): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:53:39.306+0900 I/SOCKETTEST( 6325): Success to create socket
05-26 21:53:39.336+0900 I/SOCKETTEST( 6325): Success to socket connection
05-26 21:53:39.336+0900 I/SOCKETTEST( 6325): write() 성공
05-26 21:53:39.811+0900 I/efl-extension( 6325): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x418978e8
05-26 21:53:39.811+0900 I/efl-extension( 6325): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x418978e8, obj: 0x418978e8
05-26 21:53:39.816+0900 I/efl-extension( 6325): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:53:40.736+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 21:53:40.736+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 21:53:40.736+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 21:53:40.736+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 21:53:40.736+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 21:53:51.826+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 33 -> 32 1464267231 90
05-26 21:53:51.831+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 32 1147 324 612
05-26 21:53:51.836+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 32 0 0 780
05-26 21:53:51.836+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 32 1007 206 537
05-26 21:53:51.846+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 32 120 5 64
05-26 21:53:51.846+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 32 307 43 164
05-26 21:53:59.686+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 21:53:59.691+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 21:53:59.696+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : pedometer_inactive_period error
05-26 21:53:59.696+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:53:59.701+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:53:59.701+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_10min_precaution_millisec error
05-26 21:53:59.706+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:53:59.706+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:53:59.711+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_before_10min_precaution_millisec error
05-26 21:54:00.706+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-26 21:54:00.711+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-26 21:54:00.711+0900 E/WMS     (  491): ==========
05-26 21:54:00.711+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
05-26 21:54:00.711+0900 E/WMS     (  491): ==========
05-26 21:54:00.721+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-26 21:54:00.821+0900 W/SCSD    ( 1200): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-26 21:54:00.821+0900 W/SCSD    ( 1200): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-26 21:54:00.821+0900 W/SCSD    ( 1200): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-26 21:54:00.826+0900 W/SCSD    ( 1200): <util_scs_send:975> sent [63 / 63] bytes. 
05-26 21:54:00.841+0900 W/SHealth_Service( 1055): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-26 21:54:00.841+0900 E/SHealth_Service( 1055): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-26 21:54:01.001+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:54:04.926+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:54:04.926+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:54:04.926+0900 I/RESOURCED(  497): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-26 21:54:24.516+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 21:54:49.836+0900 E/PKGMGR_SERVER( 6502): pkgmgr-server.c: main(2131) > package manager server start
05-26 21:54:49.926+0900 E/PKGMGR_SERVER( 6502): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_1269345830], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[Pj/YCXf56+KNODyFtDY6a9gqN/c=], backend_flag=[0]
05-26 21:54:49.931+0900 E/PKGMGR_SERVER( 6504): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-26 21:54:49.936+0900 E/PKGMGR  ( 6496): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-26 21:54:50.016+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:54:50.026+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6325
05-26 21:54:50.026+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:54:50.031+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 5
05-26 21:54:50.031+0900 I/APP_CORE( 6325): appcore-efl.c: __do_app(429) > [APP 6325] Event: TERMINATE State: RUNNING
05-26 21:54:50.036+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 21:54:50.036+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 21:54:50.036+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(6325), cmd(4)
05-26 21:54:50.036+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:54:50.051+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6325
05-26 21:54:50.121+0900 I/APP_CORE( 6325): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 21:54:50.121+0900 I/CAPI_APPFW_APPLICATION( 6325): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 21:54:50.141+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:54:50.141+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:54:50.151+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:54:50.161+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6325
05-26 21:54:50.211+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 21:54:50.216+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 21:54:50.216+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:54:50.216+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:54:50.216+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:54:50.216+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 21:54:50.216+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 21:54:50.216+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 21:54:50.221+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 21:54:50.221+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 21:54:50.221+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 21:54:50.236+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(0)
05-26 21:54:50.236+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 21:54:50.236+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:54:50.236+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(0)
05-26 21:54:50.236+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESUME State: PAUSED
05-26 21:54:50.236+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 21:54:50.236+0900 W/W_HOME  (  737): main.c: _appcore_resume_cb(681) > appcore resume
05-26 21:54:50.236+0900 W/W_HOME  (  737): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 21:54:50.236+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:54:50.241+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:54:50.241+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:54:50.241+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:54:50.241+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 21:54:50.241+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 21:54:50.241+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:54:50.246+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 21:54:50.251+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:54:50.251+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 21:54:50.251+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:54:50.251+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:54:50.251+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:54:50.251+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:54:50.251+0900 I/UXT     ( 6325): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 21:54:50.261+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:54:50.271+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6325
05-26 21:54:50.371+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:54:50.391+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6325
05-26 21:54:50.496+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:54:50.526+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6325
05-26 21:54:50.631+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:54:50.641+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6325
05-26 21:54:50.716+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 21:54:50.741+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:54:50.751+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 21:54:50.761+0900 E/PKGMGR_SERVER( 6504): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-26 21:54:50.786+0900 E/PKGMGR_SERVER( 6502): pkgmgr-server.c: sighandler(409) > child NORMAL exit [6504]
05-26 21:54:50.876+0900 W/CRASH_MANAGER( 6509): worker.c: worker_job(1199) > 1106325706831146426729
