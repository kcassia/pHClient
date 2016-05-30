S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 21355
Date: 2016-05-23 15:47:48+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 21355, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000009
r2   = 0x0000000a, r3   = 0x00000000
r4   = 0x4030c9c0, r5   = 0x4059a4b8
r6   = 0x4030c16c, r7   = 0x00000000
r8   = 0x437022e4, r9   = 0x41468a98
r10  = 0x4031ab18, fp   = 0x00000000
ip   = 0x4059a4b8, sp   = 0xbee28278
lr   = 0x404a808c, pc   = 0x404a81f4
cpsr = 0x80000010

Memory Information
MemTotal:   491012 KB
MemFree:     38488 KB
Buffers:     16172 KB
Cached:     109672 KB
VmPeak:      96792 KB
VmSize:      94756 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23324 KB
VmRSS:       23324 KB
VmData:      35512 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25064 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 21355 TID = 21355
21355 21559 21635 

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
4195c000 41967000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
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
43833000 4383e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43847000 4384b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43853000 4386a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43877000 43879000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44082000 44881000 rwxp [stack:21635]
44a1c000 4521b000 rwxp [stack:21559]
4529a000 4529b000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
452a3000 452a4000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
452c1000 452c8000 r-xp /usr/lib/libfeedback.so.0.1.4
452d1000 452d2000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
452da000 452dc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
452e4000 452ee000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
452f6000 452fd000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45305000 4531b000 r-xp /usr/lib/libmmfsound.so.0.1.0
4532d000 45332000 r-xp /usr/lib/libmmfsession.so.0.0.0
4533a000 45344000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45350000 45354000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
4535d000 45373000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4537c000 45381000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
45389000 4538c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45394000 453f5000 r-xp /usr/lib/libasound.so.2.0.0
453ff000 45402000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4540a000 45417000 r-xp /usr/lib/libail.so.0.1.0
4582a000 45862000 r-xp /usr/lib/libpulse.so.0.16.2
45863000 45873000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
45894000 4589c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
458ab000 458ae000 r-xp /usr/lib/libcompress.so.0.2.0
458b6000 458bb000 r-xp /usr/lib/libjson.so.0.0.1
458c3000 4590b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4590c000 4594f000 r-xp /usr/lib/libsndfile.so.1.0.25
4595c000 4597e000 r-xp /usr/lib/libvorbis.so.0.4.3
45986000 4598a000 r-xp /usr/lib/libogg.so.0.7.1
bee08000 bee29000 rwxp [stack]
End of Maps Information

Callstack Information (PID:21355)
Call Stack Count: 1
 0: (0x404a81f4) [/lib/libc.so.6] + 0x331f4
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
temByTouchIndex(6178) >  Can't Find AppsItem at [23]
05-23 15:47:20.424+0900 E/APPS    (  730): AppsViewNecklace.cpp: __GetAppsItemByTouchIndex(6178) >  Can't Find AppsItem at [23]
05-23 15:47:20.434+0900 E/APPS    (  730): AppsViewNecklace.cpp: __GetAppsItemByTouchIndex(6178) >  Can't Find AppsItem at [23]
05-23 15:47:20.479+0900 E/APPS    (  730): AppsViewNecklace.cpp: __GetAppsItemByTouchIndex(6178) >  Can't Find AppsItem at [23]
05-23 15:47:20.489+0900 E/EFL     (  730): evas_main<730> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12534507 button=1 downs=0
05-23 15:47:20.489+0900 W/APPS    (  730): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [61, 163]->[83, 173]
05-23 15:47:20.489+0900 E/APPS    (  730): AppsViewNecklace.cpp: __GetAppsItemByTouchIndex(6178) >  Can't Find AppsItem at [23]
05-23 15:47:20.644+0900 W/AUL_AMD (  493): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-23 15:47:21.084+0900 I/GESTURE (  140): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-23 15:47:21.089+0900 E/EFL     (  730): evas_main<730> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12535102 button=1 downs=1
05-23 15:47:21.089+0900 W/APPS    (  730): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [164, 173]
05-23 15:47:21.184+0900 E/EFL     (  730): evas_main<730> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12535188 button=1 downs=0
05-23 15:47:21.184+0900 W/APPS    (  730): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [164, 173]->[163, 179]
05-23 15:47:21.184+0900 W/APPS    (  730): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-23 15:47:21.184+0900 E/APPS    (  730): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-23 15:47:21.184+0900 W/APPS    (  730): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-23 15:47:21.189+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 0
05-23 15:47:21.189+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(1702) > caller pid : 730
05-23 15:47:21.189+0900 I/AUL_AMD (  493): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-23 15:47:21.199+0900 E/RESOURCED(  496): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-23 15:47:21.199+0900 E/RESOURCED(  496): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-23 15:47:21.204+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(2080) > pad pid(-5)
05-23 15:47:21.204+0900 W/AUL_PAD ( 1199): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-23 15:47:21.204+0900 W/AUL_PAD ( 1199): launchpad.c: __send_result_to_caller(272) > Check app launching
05-23 15:47:21.239+0900 I/efl-extension(21355): efl_extension.c: eext_mod_init(40) > Init
05-23 15:47:21.244+0900 I/UXT     (21355): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-23 15:47:21.254+0900 I/CAPI_APPFW_APPLICATION(21355): app_main.c: ui_app_main(704) > app_efl_main
05-23 15:47:21.254+0900 I/CAPI_APPFW_APPLICATION(21355): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-23 15:47:21.304+0900 E/TBM     (21355): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-23 15:47:21.304+0900 E/AUL     (  493): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-23 15:47:21.314+0900 E/RESOURCED(  496): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-23 15:47:21.389+0900 E/EFL     (21355): <21355> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-23 15:47:21.394+0900 E/EFL     (21355): <21355> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-23 15:47:21.399+0900 E/EFL     (21355): <21355> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-23 15:47:21.404+0900 E/EFL     (21355): <21355> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-23 15:47:21.404+0900 E/EFL     (21355): <21355> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-23 15:47:21.404+0900 E/EFL     (21355): <21355> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-23 15:47:21.459+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x06800002)
05-23 15:47:21.499+0900 I/MALI    (  730): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-23 15:47:21.499+0900 W/W_HOME  (  730): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-23 15:47:21.499+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:21.499+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:21.499+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:21.499+0900 W/W_HOME  (  730): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-23 15:47:21.504+0900 I/APP_CORE(21355): appcore-efl.c: __do_app(429) > [APP 21355] Event: RESET State: CREATED
05-23 15:47:21.504+0900 I/CAPI_APPFW_APPLICATION(21355): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-23 15:47:21.504+0900 W/GESTURE (  140): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-23 15:47:21.504+0900 W/GESTURE (  140): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-23 15:47:21.534+0900 I/APP_CORE(21355): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-23 15:47:21.534+0900 I/APP_CORE(21355): appcore-efl.c: __do_app(474) > [APP 21355] Initial Launching, call the resume_cb
05-23 15:47:21.534+0900 I/CAPI_APPFW_APPLICATION(21355): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-23 15:47:21.614+0900 W/APP_CORE(21355): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6800002
05-23 15:47:21.659+0900 I/APP_CORE(21355): appcore-efl.c: __do_app(429) > [APP 21355] Event: RESUME State: RUNNING
05-23 15:47:21.664+0900 W/W_HOME  (  730): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-23 15:47:21.664+0900 W/W_HOME  (  730): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-23 15:47:21.664+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:21.664+0900 W/W_HOME  (  730): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-23 15:47:21.664+0900 I/APP_CORE(  730): appcore-efl.c: __do_app(429) > [APP 730] Event: PAUSE State: RUNNING
05-23 15:47:21.664+0900 I/CAPI_APPFW_APPLICATION(  730): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-23 15:47:21.664+0900 W/W_HOME  (  730): main.c: _appcore_pause_cb(690) > appcore pause
05-23 15:47:21.664+0900 W/W_HOME  (  730): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-23 15:47:21.664+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:21.669+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:21.669+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:21.669+0900 W/W_HOME  (  730): rotary.c: rotary_deattach(156) > rotary_deattach:0x46646dc8
05-23 15:47:21.669+0900 I/efl-extension(  730): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-23 15:47:21.669+0900 I/efl-extension(  730): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46646dc8, elm_layout, func : 0x4004b469
05-23 15:47:21.669+0900 I/efl-extension(  730): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-23 15:47:21.669+0900 I/efl-extension(  730): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-23 15:47:21.669+0900 I/efl-extension(  730): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-23 15:47:21.669+0900 I/efl-extension(  730): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c968c0, elm_box, _activated_obj : 0x46646dc8, activated : 1
05-23 15:47:21.669+0900 I/efl-extension(  730): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-23 15:47:21.669+0900 E/wnotib  (  730): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-23 15:47:21.669+0900 I/wnotib  (  730): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-23 15:47:21.684+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 15:47:21.684+0900 E/CAPI_APPFW_APP_CONTROL( 1166): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-23 15:47:21.689+0900 W/GESTURE (  140): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-23 15:47:21.689+0900 W/GESTURE (  140): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-23 15:47:21.699+0900 W/MUSIC_CONTROL_SERVICE( 1166): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1166]   [com.samsung.w-home]register msg port [false][0m
05-23 15:47:21.784+0900 I/wnotib  (  730): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-23 15:47:21.784+0900 E/wnotib  (  730): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-23 15:47:21.799+0900 W/APPS    (  730): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-23 15:47:22.049+0900 E/AUL     (  493): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-23 15:47:22.189+0900 I/APP_CORE(  730): appcore-efl.c: __do_app(429) > [APP 730] Event: MEM_FLUSH State: PAUSED
05-23 15:47:22.419+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-23 15:47:22.429+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 21355
05-23 15:47:22.434+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-23 15:47:22.609+0900 I/AUL_PAD (21562): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-23 15:47:22.784+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12536800 button=1 downs=1
05-23 15:47:22.859+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12536876 button=1 downs=0
05-23 15:47:23.589+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12537604 button=1 downs=1
05-23 15:47:23.689+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12537700 button=1 downs=0
05-23 15:47:23.949+0900 I/CAPI_NETWORK_CONNECTION(21355): connection.c: connection_create(372) > New handle created[0x44926d40]
05-23 15:47:23.964+0900 I/SOCKETTEST(21355): IP : 
05-23 15:47:23.964+0900 I/SOCKETTEST(21355): Success to create UDP socket
05-23 15:47:23.964+0900 I/SOCKETTEST(21355): Bind Success
05-23 15:47:23.964+0900 I/SOCKETTEST(21355): Waiting DATA...
05-23 15:47:26.069+0900 E/PKGMGR  (20371): comm_client_gdbus.c: comm_client_free(283) > Invalid gdbus connection
05-23 15:47:26.069+0900 E/PKGMGR  (20371): pkgmgr.c: pkgmgr_client_free(1520) > [0;31m[pkgmgr_client_free(): 1520](ret < 0) comm_client_free() failed[0;m
05-23 15:47:26.084+0900 I/efl-extension(20371): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-23 15:47:26.689+0900 I/APP_CORE(  730): appcore-efl.c: __do_app(429) > [APP 730] Event: MEM_FLUSH State: PAUSED
05-23 15:47:32.509+0900 W/WATCH_CORE(  763): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-23 15:47:32.509+0900 I/WATCH_CORE(  763): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-23 15:47:32.509+0900 I/CAPI_WATCH_APPLICATION(  763): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-23 15:47:32.509+0900 E/watchface-loader(  763): watchface-loader.cpp: OnAppTimeTick(740) > 
05-23 15:47:32.509+0900 I/watchface-loader(  763): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-23 15:47:32.579+0900 E/GESTURE (  140): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=38   flick_area=55 ---> SET value to 1
05-23 15:47:32.579+0900 E/GESTURE (  140): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
05-23 15:47:32.579+0900 E/GESTURE (  140): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=38   flick_area=55 ---> SET value to 1
05-23 15:47:32.719+0900 E/GESTURE (  140): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
05-23 15:47:32.964+0900 I/SOCKETTEST(21355): Receive Data : 
05-23 15:47:32.964+0900 I/SOCKETTEST(21355): Changed IP : 
05-23 15:47:32.989+0900 I/SOCKETTEST(21355): Success to create socket
05-23 15:47:32.989+0900 I/SOCKETTEST(21355): socket connect error: Network is unreachable
05-23 15:47:32.989+0900 I/SOCKETTEST(21355): write() error: Bad file descriptor
05-23 15:47:33.074+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12544266 button=1 downs=1
05-23 15:47:33.074+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12544405 button=1 downs=0
05-23 15:47:33.074+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12545735 button=1 downs=1
05-23 15:47:33.074+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12545856 button=1 downs=0
05-23 15:47:33.074+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12546377 button=1 downs=1
05-23 15:47:33.074+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12546527 button=1 downs=0
05-23 15:47:33.074+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12546597 button=1 downs=1
05-23 15:47:33.074+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12546737 button=1 downs=0
05-23 15:47:33.529+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-23 15:47:33.529+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-23 15:47:33.529+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-23 15:47:33.529+0900 W/WATCH_CORE(  763): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-23 15:47:33.529+0900 I/WATCH_CORE(  763): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-23 15:47:33.529+0900 I/CAPI_WATCH_APPLICATION(  763): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-23 15:47:33.529+0900 E/watchface-loader(  763): watchface-loader.cpp: OnAppTimeTick(740) > 
05-23 15:47:33.529+0900 I/watchface-loader(  763): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-23 15:47:33.529+0900 W/W_HOME  (  730): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-23 15:47:34.249+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12548264 button=1 downs=1
05-23 15:47:34.339+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12548354 button=1 downs=0
05-23 15:47:34.354+0900 D/TIMER   (21355): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-23 15:47:34.354+0900 D/TIMER   (21355): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-23 15:47:34.409+0900 D/TIMER   (21355): Digital create
05-23 15:47:34.419+0900 D/TIMER   (21355): Initialize the rotary event
05-23 15:47:34.419+0900 I/efl-extension(21355): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-23 15:47:34.419+0900 I/efl-extension(21355): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-23 15:47:34.419+0900 I/efl-extension(21355): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-23 15:47:34.424+0900 I/efl-extension(21355): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-23 15:47:34.424+0900 I/efl-extension(21355): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4191e690, elm_layout, _activated_obj : 0x0, activated : 1
05-23 15:47:35.249+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12549266 button=1 downs=1
05-23 15:47:35.294+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12549309 button=1 downs=0
05-23 15:47:35.294+0900 D/TIMER   (21355): Start clicked
05-23 15:47:35.294+0900 E/EFL     (21355): ecore<21355> ecore.c:574 _ecore_magic_fail() 
05-23 15:47:35.294+0900 E/EFL     (21355): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-23 15:47:35.294+0900 E/EFL     (21355): *** IN FUNCTION: ecore_timer_del()
05-23 15:47:35.294+0900 E/EFL     (21355): ecore<21355> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-23 15:47:35.294+0900 E/EFL     (21355):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-23 15:47:35.294+0900 E/EFL     (21355):     Supplied: 0049a1bd - <UNKNOWN>
05-23 15:47:35.294+0900 E/EFL     (21355): ecore<21355> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-23 15:47:35.294+0900 E/EFL     (21355): *** SPANK SPANK SPANK!!!
05-23 15:47:35.294+0900 E/EFL     (21355): *** Now go fix your code. Tut tut tut!
05-23 15:47:35.294+0900 I/SOCKETTEST(21355): Success to create socket
05-23 15:47:35.294+0900 I/SOCKETTEST(21355): socket connect error: Network is unreachable
05-23 15:47:35.294+0900 I/SOCKETTEST(21355): write() error: Bad file descriptor
05-23 15:47:36.289+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:36.289+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:36.294+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:36.294+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12550305
05-23 15:47:36.294+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:36.294+0900 E/TIMER   (21355): (!ad->selected) -> _rotary_cb() return
05-23 15:47:37.229+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12551242 button=1 downs=1
05-23 15:47:37.229+0900 D/TIMER   (21355): Minute selected
05-23 15:47:37.294+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12551311 button=1 downs=0
05-23 15:47:37.494+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12551508 button=1 downs=1
05-23 15:47:37.589+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12551605 button=1 downs=0
05-23 15:47:37.589+0900 D/TIMER   (21355): Start clicked
05-23 15:47:37.589+0900 D/TIMER   (21355): Setting time is 0
05-23 15:47:37.589+0900 E/TIMER   (21355): (!ad->setting_time) -> _start_clicked_cb() return
05-23 15:47:37.894+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:37.894+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:37.904+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:37.904+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12551911
05-23 15:47:37.904+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:37.904+0900 D/TIMER   (21355): Detent detected, obj[0x4191e690], direction[0], time_stamp[12551911]
05-23 15:47:37.904+0900 D/TIMER   (21355): Pre change num: 00
05-23 15:47:37.904+0900 D/TIMER   (21355): Post change num: 0
05-23 15:47:38.034+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.034+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.034+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.034+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12552051
05-23 15:47:38.034+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:38.034+0900 D/TIMER   (21355): Detent detected, obj[0x4191e690], direction[0], time_stamp[12552051]
05-23 15:47:38.034+0900 D/TIMER   (21355): Pre change num: 1
05-23 15:47:38.034+0900 D/TIMER   (21355): Post change num: 1
05-23 15:47:38.099+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.099+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.099+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.099+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12552113
05-23 15:47:38.099+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:38.099+0900 D/TIMER   (21355): Detent detected, obj[0x4191e690], direction[0], time_stamp[12552113]
05-23 15:47:38.099+0900 D/TIMER   (21355): Pre change num: 2
05-23 15:47:38.099+0900 D/TIMER   (21355): Post change num: 2
05-23 15:47:38.159+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.159+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.159+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.159+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12552174
05-23 15:47:38.159+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:38.159+0900 D/TIMER   (21355): Detent detected, obj[0x4191e690], direction[0], time_stamp[12552174]
05-23 15:47:38.159+0900 D/TIMER   (21355): Pre change num: 3
05-23 15:47:38.159+0900 D/TIMER   (21355): Post change num: 3
05-23 15:47:38.269+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.274+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.274+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.274+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12552288
05-23 15:47:38.274+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:38.274+0900 D/TIMER   (21355): Detent detected, obj[0x4191e690], direction[0], time_stamp[12552288]
05-23 15:47:38.274+0900 D/TIMER   (21355): Pre change num: 4
05-23 15:47:38.274+0900 D/TIMER   (21355): Post change num: 4
05-23 15:47:38.459+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.459+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.459+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:38.459+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12552475
05-23 15:47:38.459+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:38.459+0900 D/TIMER   (21355): Detent detected, obj[0x4191e690], direction[0], time_stamp[12552475]
05-23 15:47:38.459+0900 D/TIMER   (21355): Pre change num: 5
05-23 15:47:38.459+0900 D/TIMER   (21355): Post change num: 5
05-23 15:47:39.169+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12553186 button=1 downs=1
05-23 15:47:39.304+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12553321 button=1 downs=0
05-23 15:47:40.224+0900 E/EFL     (21355): evas_main<21355> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12554238 button=1 downs=1
05-23 15:47:40.339+0900 E/EFL     (21355): evas_main<21355> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12554355 button=1 downs=0
05-23 15:47:40.339+0900 D/TIMER   (21355): Start clicked
05-23 15:47:40.339+0900 D/TIMER   (21355): Setting time is 360
05-23 15:47:40.424+0900 I/SENSOR  (21355): Sensor is Started
05-23 15:47:40.424+0900 I/SOCKETTEST(21355): Success to create socket
05-23 15:47:40.424+0900 I/SOCKETTEST(21355): socket connect error: Network is unreachable
05-23 15:47:40.424+0900 I/SOCKETTEST(21355): write() error: Bad file descriptor
05-23 15:47:40.424+0900 D/TIMER   (21355): Start clicked
05-23 15:47:40.474+0900 I/SENSOR  (21355): -16.170000, 48.369999, 34.160000
05-23 15:47:40.534+0900 I/SENSOR  (21355): -3.640000, -14.420000, 8.540000
05-23 15:47:40.634+0900 I/SENSOR  (21355): 1.050000, -2.940000, 9.730000
05-23 15:47:40.739+0900 I/SENSOR  (21355): -2.450000, -8.470000, 1.540000
05-23 15:47:40.844+0900 I/SENSOR  (21355): -5.110000, -24.710001, -1.260000
05-23 15:47:40.939+0900 I/SENSOR  (21355): -2.100000, -5.600000, 5.670000
05-23 15:47:41.039+0900 I/SENSOR  (21355): 4.270000, -3.150000, 8.260000
05-23 15:47:41.134+0900 I/SENSOR  (21355): 0.560000, -7.210000, 3.500000
05-23 15:47:41.239+0900 I/SENSOR  (21355): -1.680000, -3.290000, 5.250000
05-23 15:47:41.339+0900 I/SENSOR  (21355): 9.660000, -6.160000, 6.160000
05-23 15:47:41.429+0900 D/TIMER   (21355): Timer is start
05-23 15:47:41.429+0900 D/TIMER   (21355): Remind time: 360
05-23 15:47:41.554+0900 I/SENSOR  (21355): -2.660000, -1.610000, 7.070000
05-23 15:47:41.554+0900 I/SENSOR  (21355): -8.750000, -11.340000, 1.330000
05-23 15:47:41.584+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:41.584+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:41.584+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:41.584+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12555601
05-23 15:47:41.584+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:41.584+0900 E/TIMER   (21355): (!ad->selected) -> _rotary_cb() return
05-23 15:47:41.634+0900 I/SENSOR  (21355): -1.610000, 1.680000, 5.250000
05-23 15:47:41.734+0900 I/SENSOR  (21355): -0.700000, -5.880000, 4.970000
05-23 15:47:41.734+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:41.734+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:41.734+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12555751
05-23 15:47:41.734+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:41.734+0900 E/TIMER   (21355): (!ad->selected) -> _rotary_cb() return
05-23 15:47:41.734+0900 I/SOCKETTEST(21355): Success to create socket
05-23 15:47:41.734+0900 I/SOCKETTEST(21355): socket connect error: Network is unreachable
05-23 15:47:41.734+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:41.734+0900 I/SOCKETTEST(21355): write() error: Bad file descriptor
05-23 15:47:41.734+0900 I/ROTARTY (21355): 앞으로
05-23 15:47:41.834+0900 I/SENSOR  (21355): -19.740000, -28.280001, 1.820000
05-23 15:47:41.934+0900 I/SENSOR  (21355): -8.750000, -7.350000, 4.760000
05-23 15:47:42.044+0900 I/SENSOR  (21355): -10.640000, 7.070000, 4.620000
05-23 15:47:42.154+0900 I/SENSOR  (21355): -6.860000, 7.560000, 2.450000
05-23 15:47:42.184+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:42.189+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:42.189+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:42.189+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12556203
05-23 15:47:42.189+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:42.189+0900 E/TIMER   (21355): (!ad->selected) -> _rotary_cb() return
05-23 15:47:42.234+0900 I/SENSOR  (21355): 8.890000, 2.030000, 2.100000
05-23 15:47:42.289+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:42.289+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:42.289+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:42.289+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12556306
05-23 15:47:42.289+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:42.289+0900 E/TIMER   (21355): (!ad->selected) -> _rotary_cb() return
05-23 15:47:42.289+0900 I/SOCKETTEST(21355): Success to create socket
05-23 15:47:42.289+0900 I/SOCKETTEST(21355): socket connect error: Network is unreachable
05-23 15:47:42.289+0900 I/SOCKETTEST(21355): write() error: Bad file descriptor
05-23 15:47:42.289+0900 I/ROTARTY (21355): 뒤로
05-23 15:47:42.334+0900 I/SENSOR  (21355): -16.379999, -27.160000, 4.550000
05-23 15:47:42.424+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:42.424+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:42.424+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:42.424+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12556439
05-23 15:47:42.424+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:42.424+0900 E/TIMER   (21355): (!ad->selected) -> _rotary_cb() return
05-23 15:47:42.424+0900 D/TIMER   (21355): Timer is start
05-23 15:47:42.424+0900 D/TIMER   (21355): Remind time: 359
05-23 15:47:42.454+0900 I/SENSOR  (21355): -5.670000, -18.969999, 3.640000
05-23 15:47:42.534+0900 I/SENSOR  (21355): -7.000000, -13.580000, 4.550000
05-23 15:47:42.614+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:42.614+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:42.614+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:42.614+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12556628
05-23 15:47:42.614+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:42.614+0900 E/TIMER   (21355): (!ad->selected) -> _rotary_cb() return
05-23 15:47:42.614+0900 I/SOCKETTEST(21355): Success to create socket
05-23 15:47:42.614+0900 I/SOCKETTEST(21355): socket connect error: Network is unreachable
05-23 15:47:42.614+0900 I/SOCKETTEST(21355): write() error: Bad file descriptor
05-23 15:47:42.614+0900 I/ROTARTY (21355): 앞으로
05-23 15:47:42.634+0900 I/SENSOR  (21355): -3.640000, -31.150000, 8.120000
05-23 15:47:42.694+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:42.694+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:42.699+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:42.699+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12556712
05-23 15:47:42.699+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:42.699+0900 E/TIMER   (21355): (!ad->selected) -> _rotary_cb() return
05-23 15:47:42.734+0900 I/SENSOR  (21355): 2.030000, -55.369999, -4.060000
05-23 15:47:42.789+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:42.789+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:42.789+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:42.789+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12556803
05-23 15:47:42.789+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:42.789+0900 E/TIMER   (21355): (!ad->selected) -> _rotary_cb() return
05-23 15:47:42.789+0900 I/SOCKETTEST(21355): Success to create socket
05-23 15:47:42.789+0900 I/SOCKETTEST(21355): socket connect error: Network is unreachable
05-23 15:47:42.789+0900 I/SOCKETTEST(21355): write() error: Bad file descriptor
05-23 15:47:42.789+0900 I/ROTARTY (21355): 앞으로
05-23 15:47:42.834+0900 I/SENSOR  (21355): -54.389999, -125.160004, -8.890000
05-23 15:47:42.934+0900 I/SENSOR  (21355): -27.510000, -31.570000, -11.130000
05-23 15:47:43.039+0900 I/SENSOR  (21355): 16.309999, 7.840000, 8.750000
05-23 15:47:43.149+0900 I/SENSOR  (21355): 11.550000, 20.370001, 9.450000
05-23 15:47:43.244+0900 I/SENSOR  (21355): -3.220000, -0.210000, 4.480000
05-23 15:47:43.339+0900 I/SENSOR  (21355): -11.830000, 25.620001, 4.690000
05-23 15:47:43.429+0900 D/TIMER   (21355): Timer is start
05-23 15:47:43.429+0900 D/TIMER   (21355): Remind time: 358
05-23 15:47:43.564+0900 I/SENSOR  (21355): -2.310000, 18.690001, 3.850000
05-23 15:47:43.564+0900 I/SENSOR  (21355): 2.380000, 20.299999, 2.800000
05-23 15:47:43.639+0900 I/SENSOR  (21355): 3.080000, 23.170000, 7.700000
05-23 15:47:43.734+0900 I/SENSOR  (21355): -10.570000, 18.200001, 7.980000
05-23 15:47:43.809+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:43.809+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:43.809+0900 I/efl-extension(21355): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-23 15:47:43.809+0900 I/efl-extension(21355): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4191e690, elm_layout, time_stamp : 12557823
05-23 15:47:43.809+0900 D/TIMER   (21355): Rotary callback is called
05-23 15:47:43.809+0900 E/TIMER   (21355): (!ad->selected) -> _rotary_cb() return
05-23 15:47:43.839+0900 I/SENSOR  (21355): -23.870001, -277.410004, -60.619999
05-23 15:47:43.939+0900 I/SENSOR  (21355): -69.650002, -234.430008, -66.360001
05-23 15:47:44.039+0900 I/SENSOR  (21355): -26.180000, -199.919998, -23.240000
05-23 15:47:44.099+0900 E/WMS     (  489): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-23 15:47:44.104+0900 E/WMS     (  489): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-23 15:47:44.104+0900 E/WMS     (  489): ==========
05-23 15:47:44.104+0900 E/WMS     (  489): ##WMS SEND : mgr_gear_wear_onoff_req
05-23 15:47:44.104+0900 E/WMS     (  489): ==========
05-23 15:47:44.104+0900 E/WMS     (  489): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-23 15:47:44.139+0900 I/SENSOR  (21355): 6.090000, -48.020000, 1.400000
05-23 15:47:44.159+0900 W/WATCH_CORE(  763): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-23 15:47:44.159+0900 I/WATCH_CORE(  763): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-23 15:47:44.159+0900 I/CAPI_WATCH_APPLICATION(  763): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-23 15:47:44.159+0900 E/watchface-loader(  763): watchface-loader.cpp: OnAppTimeTick(740) > 
05-23 15:47:44.159+0900 I/watchface-loader(  763): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-23 15:47:44.189+0900 W/SCSD    (20776): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-23 15:47:44.189+0900 W/SCSD    (20776): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-23 15:47:44.189+0900 W/SCSD    (20776): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-23 15:47:44.189+0900 W/SCSD    (20776): <util_scs_send:975> sent [63 / 63] bytes. 
05-23 15:47:44.194+0900 W/SHealth_Service( 1060): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-23 15:47:44.194+0900 E/SHealth_Service( 1060): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-23 15:47:44.239+0900 I/SENSOR  (21355): -4.900000, -6.650000, 45.990002
05-23 15:47:44.339+0900 I/SENSOR  (21355): 33.459999, 91.910004, 84.139999
05-23 15:47:44.424+0900 D/TIMER   (21355): Timer is start
05-23 15:47:44.424+0900 D/TIMER   (21355): Remind time: 357
05-23 15:47:44.449+0900 I/SENSOR  (21355): 54.250000, 49.490002, 76.230003
05-23 15:47:44.534+0900 I/SENSOR  (21355): 27.580000, 9.170000, 0.630000
05-23 15:47:44.644+0900 I/SENSOR  (21355): -17.570000, -10.780000, 7.700000
05-23 15:47:44.739+0900 I/SENSOR  (21355): -7.350000, -8.960000, 2.940000
05-23 15:47:44.844+0900 I/SENSOR  (21355): -11.200000, -1.680000, -2.240000
05-23 15:47:44.939+0900 I/SENSOR  (21355): 14.140000, -4.060000, -3.360000
05-23 15:47:45.044+0900 I/SENSOR  (21355): -0.420000, 5.110000, -7.910000
05-23 15:47:45.144+0900 I/SENSOR  (21355): -7.070000, 6.230000, -5.390000
05-23 15:47:45.244+0900 I/SENSOR  (21355): 7.910000, 72.099998, 9.170000
05-23 15:47:45.344+0900 I/SENSOR  (21355): 42.980000, 170.169998, -4.550000
05-23 15:47:45.424+0900 D/TIMER   (21355): Timer is start
05-23 15:47:45.424+0900 D/TIMER   (21355): Remind time: 356
05-23 15:47:45.474+0900 I/SENSOR  (21355): 23.170000, 180.600006, 39.830002
05-23 15:47:45.539+0900 I/SENSOR  (21355): -0.490000, 84.419998, 53.410000
05-23 15:47:45.644+0900 I/SENSOR  (21355): 14.350000, 46.340000, 12.250000
05-23 15:47:45.749+0900 I/SENSOR  (21355): 20.160000, 12.250000, 8.680000
05-23 15:47:45.844+0900 I/SENSOR  (21355): 19.389999, 0.210000, -27.860001
05-23 15:47:45.944+0900 I/SENSOR  (21355): -40.180000, 20.650000, -83.300003
05-23 15:47:46.044+0900 I/SENSOR  (21355): 58.099998, 22.680000, 12.040000
05-23 15:47:46.144+0900 I/SENSOR  (21355): 18.129999, -11.060000, 4.060000
05-23 15:47:46.244+0900 I/SENSOR  (21355): 38.570000, -0.490000, 11.690000
05-23 15:47:46.344+0900 I/SENSOR  (21355): 11.550000, 15.960000, 35.630001
05-23 15:47:46.429+0900 D/TIMER   (21355): Timer is start
05-23 15:47:46.429+0900 D/TIMER   (21355): Remind time: 355
05-23 15:47:46.429+0900 D/TIMER   (21355): Start clicked
05-23 15:47:46.469+0900 I/SENSOR  (21355): 6.930000, 4.130000, 37.799999
05-23 15:47:46.554+0900 I/SENSOR  (21355): 3.990000, 3.710000, 18.410000
05-23 15:47:46.639+0900 I/SENSOR  (21355): -12.110000, -4.900000, 19.950001
05-23 15:47:46.744+0900 I/SENSOR  (21355): -5.180000, -9.940000, 6.580000
05-23 15:47:46.844+0900 I/SENSOR  (21355): 0.280000, 0.070000, 3.920000
05-23 15:47:46.944+0900 I/SENSOR  (21355): 5.530000, 2.730000, 3.710000
05-23 15:47:47.044+0900 I/SENSOR  (21355): 1.540000, -4.340000, 4.830000
05-23 15:47:47.134+0900 I/RESOURCED(  496): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 14 -> 13 1463986067 270
05-23 15:47:47.139+0900 I/RESOURCED(  496): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 13 1431 189 310
05-23 15:47:47.144+0900 I/SENSOR  (21355): -3.920000, -4.620000, 6.440000
05-23 15:47:47.154+0900 I/RESOURCED(  496): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 13 0 0 585
05-23 15:47:47.154+0900 I/RESOURCED(  496): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 13 1419 189 307
05-23 15:47:47.154+0900 I/RESOURCED(  496): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 13 418 5 91
05-23 15:47:47.154+0900 I/RESOURCED(  496): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 13 796 14 172
05-23 15:47:47.244+0900 I/SENSOR  (21355): -20.580000, 18.480000, -5.530000
05-23 15:47:47.344+0900 I/SENSOR  (21355): 1.820000, -4.270000, -8.330000
05-23 15:47:47.424+0900 D/TIMER   (21355): Timer is start
05-23 15:47:47.424+0900 D/TIMER   (21355): Remind time: 354
05-23 15:47:47.504+0900 I/SENSOR  (21355): 40.740002, -4.130000, 10.430000
05-23 15:47:47.539+0900 I/SENSOR  (21355): -22.610001, 2.170000, -14.770000
05-23 15:47:47.644+0900 I/SENSOR  (21355): -25.270000, -35.349998, -11.830000
05-23 15:47:47.774+0900 I/SENSOR  (21355): -7.350000, -30.450001, 2.100000
05-23 15:47:47.854+0900 I/SENSOR  (21355): -3.570000, -9.240000, -0.910000
05-23 15:47:47.949+0900 I/RESOURCED(  496): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-23 15:47:47.949+0900 I/RESOURCED(  496): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-23 15:47:47.954+0900 I/SENSOR  (21355): -0.560000, -13.720000, 7.770000
05-23 15:47:48.044+0900 I/SENSOR  (21355): -3.780000, -5.880000, 6.020000
05-23 15:47:48.074+0900 I/efl-extension(21355): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4191e690
05-23 15:47:48.074+0900 I/efl-extension(21355): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4191e690, obj: 0x4191e690
05-23 15:47:48.074+0900 I/efl-extension(21355): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-23 15:47:48.139+0900 I/SENSOR  (21355): -1.260000, -0.350000, 3.990000
05-23 15:47:48.244+0900 I/SENSOR  (21355): -2.030000, -2.520000, 3.710000
05-23 15:47:48.344+0900 I/SENSOR  (21355): -5.390000, -1.470000, 2.520000
05-23 15:47:48.424+0900 D/TIMER   (21355): Timer is start
05-23 15:47:48.424+0900 D/TIMER   (21355): Remind time: 353
05-23 15:47:48.424+0900 F/EFL     (21355): evas_main<21355> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
05-23 15:47:48.714+0900 W/CRASH_MANAGER(21531): worker.c: worker_job(1199) > 1121355706831146398606
