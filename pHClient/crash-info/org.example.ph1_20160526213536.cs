S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 1648
Date: 2016-05-26 21:35:36+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1648, uid 5000)

Register Information
r0   = 0x702f6374, r1   = 0x00000025
r2   = 0xbeae720c, r3   = 0x0000feff
r4   = 0x702f6370, r5   = 0x702f6374
r6   = 0xbeae6cd8, r7   = 0x25252525
r8   = 0x00000000, r9   = 0x4142dec0
r10  = 0x702f6374, fp   = 0xbeae6ccc
ip   = 0x702f6374, sp   = 0xbeae6758
lr   = 0x404b1f5c, pc   = 0x404ec6dc
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     14968 KB
Buffers:     20692 KB
Cached:     177240 KB
VmPeak:      95652 KB
VmSize:      93824 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22092 KB
VmRSS:       22092 KB
VmData:      34488 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25096 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 1648 TID = 1648
1648 1760 

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
43843000 4384e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43857000 4385b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43863000 4387a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43887000 43889000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
448da000 448db000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
448ea000 448eb000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
448f3000 448f4000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44a8c000 4528b000 rwxp [stack:1760]
453a0000 453a7000 r-xp /usr/lib/libfeedback.so.0.1.4
453b0000 453b2000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
453ba000 453c4000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
453cc000 453d3000 r-xp /usr/lib/libmmfcommon.so.0.0.0
453db000 453f1000 r-xp /usr/lib/libmmfsound.so.0.1.0
45403000 45408000 r-xp /usr/lib/libmmfsession.so.0.0.0
45410000 4541a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45426000 4542a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45433000 45449000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45452000 45457000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
4545f000 45462000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4546a000 4546d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45475000 45482000 r-xp /usr/lib/libail.so.0.1.0
4589c000 458fd000 r-xp /usr/lib/libasound.so.2.0.0
45907000 4593f000 r-xp /usr/lib/libpulse.so.0.16.2
45940000 45950000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
45971000 45979000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
45988000 4598b000 r-xp /usr/lib/libcompress.so.0.2.0
45993000 45998000 r-xp /usr/lib/libjson.so.0.0.1
459a0000 459e8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
459e9000 45a2c000 r-xp /usr/lib/libsndfile.so.1.0.25
45a39000 45a5b000 r-xp /usr/lib/libvorbis.so.0.4.3
45a63000 45a67000 r-xp /usr/lib/libogg.so.0.7.1
beac7000 beae8000 rwxp [stack]
End of Maps Information

Callstack Information (PID:1648)
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
21:35:19.176+0900 I/efl-extension( 1299): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
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
05-26 21:35:19.676+0900 W/CRASH_MANAGER( 1736): worker.c: worker_job(1199) > 11012997068311464266119
05-26 21:35:19.686+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 21:35:19.696+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 21:35:19.696+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:19.696+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:19.701+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:19.701+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 21:35:19.726+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(0)
05-26 21:35:19.726+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 21:35:19.726+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:19.726+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(0)
05-26 21:35:19.726+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESUME State: PAUSED
05-26 21:35:19.726+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 21:35:19.726+0900 W/W_HOME  (  737): main.c: _appcore_resume_cb(681) > appcore resume
05-26 21:35:19.726+0900 W/W_HOME  (  737): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 21:35:19.731+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:19.731+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:19.731+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:19.731+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:35:19.731+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 21:35:19.731+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 21:35:19.731+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:35:19.736+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 21:35:19.736+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:35:19.736+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 21:35:19.736+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:35:19.736+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:35:19.736+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:35:19.736+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:35:19.741+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 21:35:19.741+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 21:35:19.741+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 21:35:19.741+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 21:35:19.741+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 21:35:20.186+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 21:35:20.441+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 21:35:20.446+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=157490 button=1 downs=1
05-26 21:35:20.446+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [179, 184]
05-26 21:35:20.521+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=157561 button=1 downs=0
05-26 21:35:20.521+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [179, 184]->[177, 187]
05-26 21:35:20.526+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-26 21:35:20.526+0900 E/APPS    (  737): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-26 21:35:20.526+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-26 21:35:20.531+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 21:35:20.531+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 737
05-26 21:35:20.531+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 21:35:20.546+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-26 21:35:20.546+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 21:35:20.546+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 21:35:20.546+0900 W/AUL_PAD ( 1155): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 21:35:20.546+0900 W/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 21:35:20.616+0900 I/efl-extension( 1648): efl_extension.c: eext_mod_init(40) > Init
05-26 21:35:20.616+0900 I/UXT     ( 1648): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 21:35:20.631+0900 I/CAPI_APPFW_APPLICATION( 1648): app_main.c: ui_app_main(704) > app_efl_main
05-26 21:35:20.631+0900 I/CAPI_APPFW_APPLICATION( 1648): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-26 21:35:20.651+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:35:20.676+0900 E/RESOURCED(  497): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-26 21:35:20.691+0900 E/TBM     ( 1648): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:35:20.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:20.746+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 21:35:20.746+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [true][0m
05-26 21:35:20.766+0900 E/EFL     ( 1648): <1648> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-26 21:35:20.776+0900 E/EFL     ( 1648): <1648> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 21:35:20.781+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:35:20.786+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 737
05-26 21:35:20.796+0900 E/EFL     ( 1648): <1648> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 21:35:20.801+0900 E/EFL     ( 1648): <1648> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 21:35:20.806+0900 E/EFL     ( 1648): <1648> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 21:35:20.806+0900 E/EFL     ( 1648): <1648> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 21:35:20.836+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT][0m
05-26 21:35:20.836+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:20.841+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:20.841+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:20.841+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 21:35:20.841+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:35:20.841+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:20.841+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 21:35:20.841+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:20.861+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05e00002)
05-26 21:35:20.901+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 21:35:20.901+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:20.901+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:20.901+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:20.901+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:35:20.901+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:35:20.901+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:20.901+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 21:35:20.901+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:35:20.901+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:35:20.901+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:20.901+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT][0m
05-26 21:35:20.901+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 21:35:20.901+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 21:35:20.906+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 21:35:20.906+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:20.906+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:20.906+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:20.906+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 21:35:20.911+0900 I/APP_CORE( 1648): appcore-efl.c: __do_app(429) > [APP 1648] Event: RESET State: CREATED
05-26 21:35:20.911+0900 I/CAPI_APPFW_APPLICATION( 1648): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 21:35:20.931+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:35:20.931+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:35:20.951+0900 I/APP_CORE( 1648): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 21:35:20.951+0900 I/APP_CORE( 1648): appcore-efl.c: __do_app(474) > [APP 1648] Initial Launching, call the resume_cb
05-26 21:35:20.951+0900 I/CAPI_APPFW_APPLICATION( 1648): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 21:35:20.951+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:20.951+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:20.951+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:20.951+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 21:35:20.951+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:35:20.951+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:20.951+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 21:35:20.951+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:20.961+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:20.961+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:20.961+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:20.961+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:35:20.961+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:35:20.961+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:20.961+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 21:35:20.961+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:35:20.961+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:35:20.961+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:20.966+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 21:35:20.966+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 21:35:20.981+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:20.981+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:20.981+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:20.981+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 21:35:20.981+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:35:20.981+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:20.981+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 21:35:20.981+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:21.006+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:21.006+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:21.006+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:21.006+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:35:21.006+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:35:21.006+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:21.006+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 21:35:21.006+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:35:21.006+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:35:21.006+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:21.041+0900 W/APP_CORE( 1648): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
05-26 21:35:21.081+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 21:35:21.081+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 21:35:21.081+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:21.081+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 21:35:21.081+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 21:35:21.081+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 21:35:21.081+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 21:35:21.081+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 21:35:21.081+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:21.081+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:21.081+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 21:35:21.081+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 21:35:21.081+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:35:21.081+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 21:35:21.081+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:35:21.081+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:35:21.081+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:35:21.081+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 21:35:21.081+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:35:21.081+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:35:21.081+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 21:35:21.091+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:21.096+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:21.096+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:21.096+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 21:35:21.096+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:35:21.096+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:21.096+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:35:21.096+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:21.106+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:35:21.106+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:35:21.106+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:35:21.106+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:35:21.106+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:35:21.106+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:35:21.106+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:35:21.106+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:35:21.106+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:35:21.106+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:35:21.106+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:35:21.106+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:35:21.126+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 21:35:21.126+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 21:35:21.186+0900 I/APP_CORE( 1648): appcore-efl.c: __do_app(429) > [APP 1648] Event: RESUME State: RUNNING
05-26 21:35:21.241+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 21:35:21.241+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:35:21.281+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 21:35:21.471+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:35:21.606+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:35:21.716+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:35:21.726+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1648
05-26 21:35:21.726+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:35:21.966+0900 I/AUL_PAD ( 1761): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 21:35:22.001+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=159051 button=1 downs=1
05-26 21:35:22.046+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=159094 button=1 downs=0
05-26 21:35:22.061+0900 D/TIMER   ( 1648): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:35:22.061+0900 D/TIMER   ( 1648): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:35:22.106+0900 I/efl-extension( 1648): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:35:22.106+0900 I/efl-extension( 1648): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:35:22.106+0900 I/efl-extension( 1648): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:35:22.106+0900 I/efl-extension( 1648): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:35:22.106+0900 I/efl-extension( 1648): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x449038b0, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:35:23.216+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=160267 button=1 downs=1
05-26 21:35:23.271+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=160320 button=1 downs=0
05-26 21:35:24.776+0900 I/efl-extension( 1648): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x449038b0
05-26 21:35:24.776+0900 I/efl-extension( 1648): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x449038b0, obj: 0x449038b0
05-26 21:35:24.776+0900 I/efl-extension( 1648): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:35:24.776+0900 I/efl-extension( 1648): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:35:24.776+0900 I/efl-extension( 1648): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:35:24.776+0900 I/efl-extension( 1648): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:35:25.041+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=162089 button=1 downs=1
05-26 21:35:25.081+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=162133 button=1 downs=0
05-26 21:35:26.111+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:35:26.166+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=163217 button=1 downs=1
05-26 21:35:26.196+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=163238 button=1 downs=0
05-26 21:35:26.521+0900 I/CAPI_NETWORK_CONNECTION( 1648): connection.c: connection_create(372) > New handle created[0x4490e658]
05-26 21:35:26.541+0900 I/SOCKETTEST( 1648): IP : 
05-26 21:35:26.541+0900 I/SOCKETTEST( 1648): Success to create UDP socket
05-26 21:35:26.541+0900 I/SOCKETTEST( 1648): Bind Success
05-26 21:35:26.541+0900 I/SOCKETTEST( 1648): Waiting DATA...
05-26 21:35:28.181+0900 I/SOCKETTEST( 1648): Receive Data : 192.168.0.47
05-26 21:35:28.181+0900 I/SOCKETTEST( 1648): Changed IP : 192.168.0.47
05-26 21:35:28.246+0900 I/SOCKETTEST( 1648): Success to create socket
05-26 21:35:28.266+0900 I/SOCKETTEST( 1648): Success to socket connection
05-26 21:35:28.266+0900 I/SOCKETTEST( 1648): write() 성공
05-26 21:35:32.001+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=169047 button=1 downs=1
05-26 21:35:32.056+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=169105 button=1 downs=0
05-26 21:35:32.056+0900 D/TIMER   ( 1648): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:35:32.056+0900 D/TIMER   ( 1648): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:35:32.066+0900 I/efl-extension( 1648): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:35:32.071+0900 I/efl-extension( 1648): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44903bb0, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:35:32.861+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=169908 button=1 downs=1
05-26 21:35:32.941+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=169988 button=1 downs=0
05-26 21:35:33.481+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=170530 button=1 downs=1
05-26 21:35:33.536+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=170587 button=1 downs=0
05-26 21:35:33.736+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-26 21:35:33.741+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-26 21:35:33.741+0900 E/WMS     (  491): ==========
05-26 21:35:33.741+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
05-26 21:35:33.741+0900 E/WMS     (  491): ==========
05-26 21:35:33.741+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-26 21:35:33.766+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=170778 button=1 downs=1
05-26 21:35:33.781+0900 W/SCSD    ( 1200): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-26 21:35:33.781+0900 W/SCSD    ( 1200): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-26 21:35:33.781+0900 W/SCSD    ( 1200): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-26 21:35:33.781+0900 W/SCSD    ( 1200): <util_scs_send:975> sent [63 / 63] bytes. 
05-26 21:35:33.786+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=170821 button=1 downs=0
05-26 21:35:33.826+0900 W/SHealth_Service( 1055): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-26 21:35:33.831+0900 E/SHealth_Service( 1055): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-26 21:35:34.091+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.091+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.091+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.091+0900 I/efl-extension( 1648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.091+0900 I/efl-extension( 1648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bb0, elm_layout, time_stamp : 171139
05-26 21:35:34.091+0900 E/TIMER   ( 1648): (ad->timer) -> _rotary_cb() return
05-26 21:35:34.196+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.196+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.201+0900 I/efl-extension( 1648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.201+0900 I/efl-extension( 1648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bb0, elm_layout, time_stamp : 171247
05-26 21:35:34.201+0900 E/TIMER   ( 1648): (ad->timer) -> _rotary_cb() return
05-26 21:35:34.201+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.241+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.241+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.241+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.241+0900 I/efl-extension( 1648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.241+0900 I/efl-extension( 1648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bb0, elm_layout, time_stamp : 171292
05-26 21:35:34.241+0900 E/TIMER   ( 1648): (ad->timer) -> _rotary_cb() return
05-26 21:35:34.276+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.276+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.276+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.276+0900 I/efl-extension( 1648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.276+0900 I/efl-extension( 1648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bb0, elm_layout, time_stamp : 171324
05-26 21:35:34.276+0900 E/TIMER   ( 1648): (ad->timer) -> _rotary_cb() return
05-26 21:35:34.306+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.306+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.306+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.306+0900 I/efl-extension( 1648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.306+0900 I/efl-extension( 1648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bb0, elm_layout, time_stamp : 171353
05-26 21:35:34.306+0900 E/TIMER   ( 1648): (ad->timer) -> _rotary_cb() return
05-26 21:35:34.351+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.351+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.351+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.351+0900 I/efl-extension( 1648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.351+0900 I/efl-extension( 1648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bb0, elm_layout, time_stamp : 171401
05-26 21:35:34.351+0900 E/TIMER   ( 1648): (ad->timer) -> _rotary_cb() return
05-26 21:35:34.606+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.611+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.611+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.611+0900 I/efl-extension( 1648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.611+0900 I/efl-extension( 1648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bb0, elm_layout, time_stamp : 171657
05-26 21:35:34.611+0900 E/TIMER   ( 1648): (ad->timer) -> _rotary_cb() return
05-26 21:35:34.641+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.641+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.641+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.641+0900 I/efl-extension( 1648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.641+0900 I/efl-extension( 1648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bb0, elm_layout, time_stamp : 171691
05-26 21:35:34.641+0900 E/TIMER   ( 1648): (ad->timer) -> _rotary_cb() return
05-26 21:35:34.691+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.691+0900 I/efl-extension( 1156): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.691+0900 I/efl-extension( 1157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.691+0900 I/efl-extension( 1648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:35:34.691+0900 I/efl-extension( 1648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44903bb0, elm_layout, time_stamp : 171741
05-26 21:35:34.691+0900 E/TIMER   ( 1648): (ad->timer) -> _rotary_cb() return
05-26 21:35:35.031+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=172079 button=1 downs=1
05-26 21:35:35.096+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=172147 button=1 downs=0
05-26 21:35:35.786+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=172837 button=1 downs=1
05-26 21:35:35.851+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=172898 button=1 downs=0
05-26 21:35:36.211+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=173259 button=1 downs=1
05-26 21:35:36.291+0900 E/EFL     ( 1648): evas_main<1648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=173339 button=1 downs=0
05-26 21:35:36.291+0900 I/efl-extension( 1648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:35:36.291+0900 I/efl-extension( 1648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44903bb0, elm_layout, func : 0x415608e1
05-26 21:35:36.291+0900 I/efl-extension( 1648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:35:36.291+0900 I/efl-extension( 1648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:35:36.291+0900 I/efl-extension( 1648): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:35:36.291+0900 I/efl-extension( 1648): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:35:36.291+0900 I/efl-extension( 1648): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:35:36.291+0900 I/efl-extension( 1648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:35:36.296+0900 E/EFL     ( 1648): ecore<1648> ecore.c:574 _ecore_magic_fail() 
05-26 21:35:36.296+0900 E/EFL     ( 1648): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:35:36.296+0900 E/EFL     ( 1648): *** IN FUNCTION: ecore_timer_del()
05-26 21:35:36.296+0900 E/EFL     ( 1648): ecore<1648> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:35:36.296+0900 E/EFL     ( 1648):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:35:36.296+0900 E/EFL     ( 1648):     Supplied: 0049a1bd - <UNKNOWN>
05-26 21:35:36.296+0900 E/EFL     ( 1648): ecore<1648> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:35:36.296+0900 E/EFL     ( 1648): *** SPANK SPANK SPANK!!!
05-26 21:35:36.296+0900 E/EFL     ( 1648): *** Now go fix your code. Tut tut tut!
05-26 21:35:36.296+0900 I/SOCKETTEST( 1648): Success to create socket
05-26 21:35:36.301+0900 I/SOCKETTEST( 1648): Success to socket connection
05-26 21:35:36.301+0900 I/SOCKETTEST( 1648): write() 성공
05-26 21:35:36.446+0900 W/CRASH_MANAGER( 1736): worker.c: worker_job(1199) > 1101648706831146426613
