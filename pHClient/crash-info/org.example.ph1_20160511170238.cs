S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 4249
Date: 2016-05-11 17:02:38+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x652f2f72

Register Information
r0   = 0x00000000, r1   = 0x41920708
r2   = 0x41920700, r3   = 0x00000000
r4   = 0x78652e67, r5   = 0x6c706d61
r6   = 0x68702e65, r7   = 0x65722f31
r8   = 0x00000000, r9   = 0x4553aa78
r10  = 0x449888a0, fp   = 0x00000000
ip   = 0x4142def4, sp   = 0xbe94a658
lr   = 0x4001c064, pc   = 0x652f2f72
cpsr = 0x20000030

Memory Information
MemTotal:   491012 KB
MemFree:     29360 KB
Buffers:     20168 KB
Cached:     164128 KB
VmPeak:      92276 KB
VmSize:      86332 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21012 KB
VmRSS:       18968 KB
VmData:      33144 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22964 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4249 TID = 4249
4249 4333 

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
41771000 4177e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41786000 4178b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41793000 41797000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417a0000 417c1000 r-xp /usr/lib/libefl-extension.so.0.1.0
417c9000 417e0000 r-xp /usr/lib/libnetwork.so.0.0.0
417e8000 417ed000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
417f5000 41813000 r-xp /usr/lib/libsensor.so.1.1.0
4181d000 4182f000 r-xp /usr/lib/libefl-assist.so.0.1.0
41837000 418ef000 r-xp /usr/lib/libcairo.so.2.11200.14
418fa000 41901000 r-xp /usr/lib/libsensord-share.so
41909000 41910000 r-xp /usr/lib/libtbm.so.1.0.0
4191f000 41a51000 rw-p [heap]
41a51000 41a82000 r-xp /usr/lib/libmdm.so.1.1.85
41a8a000 41a9c000 r-xp /usr/lib/libtts.so
41aa4000 41ac5000 r-xp /usr/lib/libui-extension.so.0.1.0
41ace000 41adc000 r-xp /usr/lib/libGLESv2.so.2.0
41ae5000 41ae6000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41aef000 41af5000 r-xp /usr/lib/libxcb-render.so.0.0.0
41afd000 41b00000 r-xp /usr/lib/libEGL.so.1.4
41b08000 41b10000 r-xp /usr/lib/libmdm-common.so.1.0.89
41b11000 41c4e000 r-xp /usr/lib/libicui18n.so.51.1
41c5e000 41d42000 r-xp /usr/lib/libicuuc.so.51.1
41d57000 41d5a000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41d62000 41d6a000 r-xp /usr/lib/libdrm.so.2.4.0
432f9000 432fe000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43307000 4330c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43314000 43316000 r-xp /usr/lib/libdri2.so.0.0.0
4331e000 4333f000 r-xp /usr/lib/libexif.so.12.3.3
43352000 43357000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4335f000 43429000 r-xp /usr/lib/libCOREGL.so.4.0
43780000 43784000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44a55000 45254000 rwxp [stack:4333]
be92a000 be94b000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4249)
Call Stack Count: 1
 0: (0x652f2f72) shared object not open
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
_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-11 17:02:23.820+0900 W/AUL_AMD (  484): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-11 17:02:24.010+0900 W/W_HOME  (  688): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-11 17:02:24.010+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-11 17:02:24.010+0900 W/W_HOME  (  688): rotary.c: rotary_deattach(156) > rotary_deattach:0x4779b410
05-11 17:02:24.010+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 17:02:24.010+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4779b410, elm_layout, func : 0x4004b469
05-11 17:02:24.010+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-11 17:02:24.010+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-11 17:02:24.010+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 17:02:24.010+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x4779b410, activated : 1
05-11 17:02:24.010+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-11 17:02:24.010+0900 E/wnotib  (  688): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-11 17:02:24.010+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-11 17:02:24.010+0900 W/W_HOME  (  688): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-11 17:02:24.010+0900 W/W_HOME  (  688): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-11 17:02:24.015+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:24.015+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:24.015+0900 W/W_HOME  (  688): main.c: home_pause(751) > clock/widget paused
05-11 17:02:24.015+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:24.015+0900 W/APPS    (  688): apps_main.c: _time_changed_cb(295) >  date : 11->11
05-11 17:02:24.015+0900 W/W_HOME  (  688): rotary.c: rotary_attach(138) > rotary_attach:0x476bd370
05-11 17:02:24.015+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x476bd370, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-11 17:02:24.015+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-11 17:02:24.020+0900 W/W_HOME  (  688): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-11 17:02:24.020+0900 W/W_HOME  (  688): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-11 17:02:24.020+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-11 17:02:24.020+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-11 17:02:24.020+0900 E/APPS    (  688): apps_main.c: apps_main_resume(621) >  resumed already
05-11 17:02:24.025+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 17:02:24.025+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:02:24.025+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:02:24.025+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:02:24.135+0900 W/W_HOME  (  688): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-11 17:02:24.415+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-11 17:02:24.420+0900 E/EFL     (  688): evas_main<688> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1938237 button=1 downs=1
05-11 17:02:24.420+0900 W/APPS    (  688): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [201, 177]
05-11 17:02:24.500+0900 E/EFL     (  688): evas_main<688> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1938313 button=1 downs=0
05-11 17:02:24.500+0900 W/APPS    (  688): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [201, 177]->[199, 174]
05-11 17:02:24.505+0900 W/APPS    (  688): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-11 17:02:24.505+0900 E/APPS    (  688): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-11 17:02:24.505+0900 W/APPS    (  688): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-11 17:02:24.510+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 0
05-11 17:02:24.515+0900 W/AUL_AMD (  484): amd_launch.c: _start_app(1702) > caller pid : 688
05-11 17:02:24.515+0900 I/AUL_AMD (  484): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-11 17:02:24.525+0900 E/RESOURCED(  485): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-11 17:02:24.525+0900 E/RESOURCED(  485): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-11 17:02:24.530+0900 W/AUL_AMD (  484): amd_launch.c: _start_app(2080) > pad pid(-5)
05-11 17:02:24.530+0900 W/AUL_PAD ( 1103): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-11 17:02:24.530+0900 W/AUL_PAD ( 1103): launchpad.c: __send_result_to_caller(272) > Check app launching
05-11 17:02:24.605+0900 I/efl-extension( 4249): efl_extension.c: eext_mod_init(40) > Init
05-11 17:02:24.605+0900 I/UXT     ( 4249): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-11 17:02:24.640+0900 I/CAPI_APPFW_APPLICATION( 4249): app_main.c: ui_app_main(704) > app_efl_main
05-11 17:02:24.645+0900 I/CAPI_APPFW_APPLICATION( 4249): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-11 17:02:24.690+0900 E/TBM     ( 4249): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-11 17:02:24.735+0900 E/RESOURCED(  485): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-11 17:02:24.740+0900 E/AUL     (  484): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-11 17:02:24.760+0900 E/EFL     ( 4249): <4249> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-11 17:02:24.765+0900 E/EFL     ( 4249): <4249> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-11 17:02:24.775+0900 E/EFL     ( 4249): <4249> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-11 17:02:24.775+0900 E/EFL     ( 4249): <4249> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-11 17:02:24.775+0900 E/EFL     ( 4249): <4249> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-11 17:02:24.775+0900 E/EFL     ( 4249): <4249> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-11 17:02:24.860+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04e00002)
05-11 17:02:24.900+0900 I/APP_CORE( 4249): appcore-efl.c: __do_app(429) > [APP 4249] Event: RESET State: CREATED
05-11 17:02:24.900+0900 I/CAPI_APPFW_APPLICATION( 4249): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-11 17:02:24.915+0900 W/W_HOME  (  688): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-11 17:02:24.915+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:24.915+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:24.915+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:24.915+0900 W/W_HOME  (  688): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-11 17:02:24.915+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:02:24.915+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 17:02:24.920+0900 I/MALI    (  688): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-11 17:02:24.930+0900 I/APP_CORE( 4249): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-11 17:02:24.930+0900 I/APP_CORE( 4249): appcore-efl.c: __do_app(474) > [APP 4249] Initial Launching, call the resume_cb
05-11 17:02:24.930+0900 I/CAPI_APPFW_APPLICATION( 4249): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-11 17:02:25.010+0900 W/APP_CORE( 4249): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4e00002
05-11 17:02:25.065+0900 W/AUL_AMD (  484): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-11 17:02:25.065+0900 W/AUL_AMD (  484): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-11 17:02:25.070+0900 I/APP_CORE( 4249): appcore-efl.c: __do_app(429) > [APP 4249] Event: RESUME State: RUNNING
05-11 17:02:25.075+0900 W/W_HOME  (  688): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-11 17:02:25.075+0900 W/W_HOME  (  688): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-11 17:02:25.075+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:25.075+0900 W/W_HOME  (  688): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-11 17:02:25.075+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: PAUSE State: RUNNING
05-11 17:02:25.075+0900 I/CAPI_APPFW_APPLICATION(  688): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-11 17:02:25.075+0900 W/W_HOME  (  688): main.c: _appcore_pause_cb(690) > appcore pause
05-11 17:02:25.075+0900 W/W_HOME  (  688): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-11 17:02:25.075+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:25.075+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:25.075+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:25.075+0900 W/W_HOME  (  688): rotary.c: rotary_deattach(156) > rotary_deattach:0x476bd370
05-11 17:02:25.075+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 17:02:25.075+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x476bd370, elm_layout, func : 0x4004b469
05-11 17:02:25.075+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-11 17:02:25.075+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-11 17:02:25.075+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 17:02:25.075+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x476bd370, activated : 1
05-11 17:02:25.075+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-11 17:02:25.075+0900 E/wnotib  (  688): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-11 17:02:25.075+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-11 17:02:25.085+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 17:02:25.085+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 17:02:25.085+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 17:02:25.085+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-11 17:02:25.085+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-11 17:02:25.085+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 17:02:25.085+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-11 17:02:25.085+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 17:02:25.090+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-11 17:02:25.090+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-11 17:02:25.090+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-11 17:02:25.090+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-11 17:02:25.090+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-11 17:02:25.090+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-11 17:02:25.090+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-11 17:02:25.090+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-11 17:02:25.090+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-11 17:02:25.090+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-11 17:02:25.090+0900 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-11 17:02:25.090+0900 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
05-11 17:02:25.090+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 17:02:25.090+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 17:02:25.160+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-11 17:02:25.160+0900 E/wnotib  (  688): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-11 17:02:25.180+0900 W/APPS    (  688): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-11 17:02:25.440+0900 E/AUL     (  484): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-11 17:02:25.590+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: MEM_FLUSH State: PAUSED
05-11 17:02:25.765+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 17:02:25.765+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 17:02:25.765+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-11 17:02:25.765+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-11 17:02:25.765+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-11 17:02:25.765+0900 W/W_HOME  (  688): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-11 17:02:25.780+0900 E/EFL     ( 4249): evas_main<4249> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1939601 button=1 downs=1
05-11 17:02:25.815+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 14
05-11 17:02:25.820+0900 W/AUL_AMD (  484): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4249
05-11 17:02:25.825+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 12
05-11 17:02:25.855+0900 E/EFL     ( 4249): evas_main<4249> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1939676 button=1 downs=0
05-11 17:02:25.885+0900 I/efl-extension( 4249): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-11 17:02:25.885+0900 I/efl-extension( 4249): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-11 17:02:25.885+0900 I/efl-extension( 4249): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-11 17:02:25.890+0900 I/efl-extension( 4249): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-11 17:02:25.890+0900 I/efl-extension( 4249): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x449ad5c8, elm_image, _activated_obj : 0x0, activated : 1
05-11 17:02:25.915+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x449c8bd0]'s widget[0x449baed8] to layout widget[0x449ada48]
05-11 17:02:25.920+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x449c8bd0 = w: 0 h: 0  obj 0x449baed8 w: 360 h: 360
05-11 17:02:25.920+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-11 17:02:26.625+0900 I/AUL_PAD ( 4334): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-11 17:02:27.230+0900 I/efl-extension( 4249): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x437b9130, obj: 0x437b9130
05-11 17:02:27.230+0900 I/efl-extension( 4249): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-11 17:02:27.230+0900 I/efl-extension( 4249): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-11 17:02:27.230+0900 I/efl-extension( 4249): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-11 17:02:27.230+0900 I/efl-extension( 4249): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-11 17:02:27.240+0900 I/efl-extension( 4249): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x449ad5c8
05-11 17:02:27.240+0900 I/efl-extension( 4249): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 17:02:27.240+0900 I/efl-extension( 4249): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x437b9130, elm_genlist, func : 0x417addfd
05-11 17:02:27.240+0900 I/efl-extension( 4249): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 17:02:27.490+0900 E/EFL     ( 4249): evas_main<4249> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1941310 button=1 downs=1
05-11 17:02:27.520+0900 E/EFL     ( 4249): evas_main<4249> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1941342 button=1 downs=0
05-11 17:02:27.585+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x449baa18]'s widget[0x44988120] to layout widget[0x4553bf78]
05-11 17:02:27.585+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x449baa18 = w: 0 h: 0  obj 0x44988120 w: 360 h: 360
05-11 17:02:27.585+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-11 17:02:28.220+0900 I/RESOURCED(  485): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-11 17:02:28.220+0900 I/RESOURCED(  485): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-11 17:02:28.805+0900 E/EFL     ( 4249): evas_main<4249> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1942626 button=1 downs=1
05-11 17:02:28.870+0900 E/EFL     ( 4249): evas_main<4249> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1942691 button=1 downs=0
05-11 17:02:28.885+0900 D/TIMER   ( 4249): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-11 17:02:28.885+0900 D/TIMER   ( 4249): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-11 17:02:28.885+0900 E/EFL     ( 4249): elementary<4249> elm_layout.c:1673 elm_layout_file_set() failed to set edje file '/opt/usr/apps/org.example.ph1/res//edje/timer.edj', group 'main': No Error
05-11 17:02:28.890+0900 E/EFL     ( 4249): elementary<4249> elm_layout.c:1673 elm_layout_file_set() failed to set edje file '/opt/usr/apps/org.example.ph1/res//edje/timer.edj', group 'start_btn': No Error
05-11 17:02:28.895+0900 E/EFL     ( 4249): elementary<4249> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x449888a0 into part 'start_button'
05-11 17:02:28.895+0900 E/EFL     ( 4249): elementary<4249> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x4553aa78 into part 'btn'
05-11 17:02:28.895+0900 D/TIMER   ( 4249): Digital create
05-11 17:02:28.895+0900 E/EFL     ( 4249): elementary<4249> elm_layout.c:1673 elm_layout_file_set() failed to set edje file '/opt/usr/apps/org.example.ph1/res//edje/timer.edj', group 'hour': No Error
05-11 17:02:28.895+0900 E/EFL     ( 4249): elementary<4249> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x4553a5f8 into part 'hour'
05-11 17:02:28.895+0900 E/EFL     ( 4249): elementary<4249> elm_layout.c:1673 elm_layout_file_set() failed to set edje file '/opt/usr/apps/org.example.ph1/res//edje/timer.edj', group 'minute': No Error
05-11 17:02:28.895+0900 E/EFL     ( 4249): elementary<4249> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x449826c0 into part 'minute'
05-11 17:02:28.895+0900 E/EFL     ( 4249): elementary<4249> elm_layout.c:1673 elm_layout_file_set() failed to set edje file '/opt/usr/apps/org.example.ph1/res//edje/timer.edj', group 'second': No Error
05-11 17:02:28.895+0900 E/EFL     ( 4249): elementary<4249> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x44982b40 into part 'second'
05-11 17:02:28.895+0900 D/TIMER   ( 4249): Initialize the rotary event
05-11 17:02:28.895+0900 I/efl-extension( 4249): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-11 17:02:28.895+0900 I/efl-extension( 4249): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44988ba0, elm_layout, _activated_obj : 0x0, activated : 1
05-11 17:02:28.910+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x44973720]'s widget[0x456d2d00] to layout widget[0x44982fc0]
05-11 17:02:28.910+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44973720 = w: 0 h: 0  obj 0x456d2d00 w: 360 h: 360
05-11 17:02:28.910+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-11 17:02:30.095+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: MEM_FLUSH State: PAUSED
05-11 17:02:30.775+0900 I/efl-extension( 4249): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44988ba0
05-11 17:02:30.775+0900 I/efl-extension( 4249): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44988ba0, obj: 0x44988ba0
05-11 17:02:30.775+0900 I/efl-extension( 4249): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-11 17:02:30.775+0900 I/efl-extension( 4249): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-11 17:02:30.775+0900 I/efl-extension( 4249): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-11 17:02:30.775+0900 I/efl-extension( 4249): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-11 17:02:35.780+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-11 17:02:35.785+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-11 17:02:35.785+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-11 17:02:35.785+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-11 17:02:35.900+0900 W/STARTER (  678): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-11 17:02:35.970+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-11 17:02:35.970+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-11 17:02:35.975+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-11 17:02:35.975+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-11 17:02:36.105+0900 W/STARTER (  678): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-11 17:02:36.365+0900 W/STARTER (  678): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-11 17:02:36.365+0900 W/STARTER (  678): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-11 17:02:36.395+0900 E/STARTER (  678): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-11 17:02:36.395+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 0
05-11 17:02:36.405+0900 W/AUL_AMD (  484): amd_launch.c: _start_app(1702) > caller pid : 678
05-11 17:02:36.410+0900 W/AUL_AMD (  484): amd_launch.c: _start_app(2080) > pad pid(-5)
05-11 17:02:36.415+0900 W/AUL_PAD ( 1103): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-11 17:02:36.415+0900 W/AUL_PAD ( 1103): launchpad.c: __send_result_to_caller(272) > Check app launching
05-11 17:02:36.425+0900 E/RESOURCED(  485): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-11 17:02:36.425+0900 I/CAPI_APPFW_APPLICATION( 4320): app_main.c: app_efl_main(129) > app_efl_main
05-11 17:02:36.430+0900 I/CAPI_APPFW_APPLICATION( 4320): app_main.c: app_appcore_create(152) > app_appcore_create
05-11 17:02:36.515+0900 E/AUL     (  678): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-11 17:02:36.520+0900 E/RESOURCED(  485): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-11 17:02:36.565+0900 I/efl-extension( 4320): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44598650 = w: 0 h: 0  obj 0x4458e7b0 w: 360 h: 360
05-11 17:02:36.565+0900 I/efl-extension( 4320): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-11 17:02:36.565+0900 I/efl-extension( 4320): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-11 17:02:36.565+0900 I/efl-extension( 4320): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-11 17:02:36.565+0900 I/efl-extension( 4320): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-11 17:02:36.565+0900 I/efl-extension( 4320): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-11 17:02:36.570+0900 I/efl-extension( 4320): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4458e7b0, elm_image, _activated_obj : 0x0, activated : 1
05-11 17:02:36.665+0900 E/W_TASKMANAGER( 4320): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-11 17:02:36.670+0900 E/W_TASKMANAGER( 4320): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-11 17:02:36.670+0900 E/W_TASKMANAGER( 4320): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-11 17:02:36.710+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 12
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/W_TASKMANAGER( 4320): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-11 17:02:36.715+0900 E/RUA     ( 4320): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 15, ncols : 5
05-11 17:02:36.750+0900 E/EFL     ( 4320): elementary<4320> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x44590430 into part 'elm.swallow.event.0'
05-11 17:02:36.795+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x02e00003)
05-11 17:02:36.795+0900 I/APP_CORE( 4320): appcore-efl.c: __do_app(429) > [APP 4320] Event: RESET State: CREATED
05-11 17:02:36.795+0900 I/CAPI_APPFW_APPLICATION( 4320): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-11 17:02:36.810+0900 I/APP_CORE( 4320): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-11 17:02:36.810+0900 I/APP_CORE( 4320): appcore-efl.c: __do_app(474) > [APP 4320] Initial Launching, call the resume_cb
05-11 17:02:36.810+0900 I/CAPI_APPFW_APPLICATION( 4320): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-11 17:02:36.860+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02e00003)
05-11 17:02:36.865+0900 W/APP_CORE( 4320): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00003
05-11 17:02:36.920+0900 I/APP_CORE( 4249): appcore-efl.c: __do_app(429) > [APP 4249] Event: PAUSE State: RUNNING
05-11 17:02:36.920+0900 I/CAPI_APPFW_APPLICATION( 4249): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-11 17:02:36.950+0900 I/APP_CORE( 4320): appcore-efl.c: __do_app(429) > [APP 4320] Event: RESUME State: RUNNING
05-11 17:02:36.960+0900 W/AUL_AMD (  484): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-11 17:02:36.960+0900 W/AUL_AMD (  484): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-11 17:02:37.335+0900 E/AUL     (  484): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-11 17:02:37.380+0900 I/MALI    ( 4320): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x432f9620] swap changed from async to sync
05-11 17:02:37.405+0900 E/EFL     ( 4320): evas_main<4320> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1951222 button=1 downs=1
05-11 17:02:37.470+0900 E/EFL     ( 4320): evas_main<4320> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1951283 button=1 downs=0
05-11 17:02:37.585+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 14
05-11 17:02:37.600+0900 W/AUL_AMD (  484): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4320
05-11 17:02:37.600+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 12
05-11 17:02:37.715+0900 E/EFL     ( 4320): elementary<4320> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44543378), freeze(1)
05-11 17:02:37.715+0900 E/EFL     ( 4320): elementary<4320> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44543378), freeze(1)
05-11 17:02:37.975+0900 I/efl-extension( 4391): efl_extension.c: eext_mod_init(40) > Init
05-11 17:02:38.015+0900 I/UXT     ( 4391): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-11 17:02:38.085+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 14
05-11 17:02:38.090+0900 W/AUL_AMD (  484): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4249
05-11 17:02:38.095+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 27
05-11 17:02:38.100+0900 I/APP_CORE( 4249): appcore-efl.c: __do_app(429) > [APP 4249] Event: TERMINATE State: PAUSED
05-11 17:02:38.100+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 22
05-11 17:02:38.100+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(890) > app status : 4
05-11 17:02:38.115+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 22
05-11 17:02:38.115+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(890) > app status : 4
05-11 17:02:38.115+0900 E/APP_CORE( 4320): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-11 17:02:38.115+0900 I/APP_CORE( 4320): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-11 17:02:38.115+0900 I/APP_CORE( 4320): appcore-efl.c: __after_loop(1090) > [APP 4320] PAUSE before termination
05-11 17:02:38.115+0900 I/CAPI_APPFW_APPLICATION( 4320): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-11 17:02:38.115+0900 I/CAPI_APPFW_APPLICATION( 4320): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-11 17:02:38.120+0900 I/efl-extension( 4320): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44543378, obj: 0x44543378
05-11 17:02:38.120+0900 I/efl-extension( 4320): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-11 17:02:38.120+0900 I/efl-extension( 4320): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-11 17:02:38.120+0900 I/efl-extension( 4320): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-11 17:02:38.120+0900 I/efl-extension( 4320): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-11 17:02:38.125+0900 I/efl-extension( 4320): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4458e7b0
05-11 17:02:38.125+0900 I/efl-extension( 4320): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-11 17:02:38.125+0900 I/efl-extension( 4320): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44598650 is freed
05-11 17:02:38.125+0900 I/efl-extension( 4320): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 17:02:38.125+0900 I/efl-extension( 4320): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44543378, elm_scroller, func : 0x437eeef1
05-11 17:02:38.125+0900 I/efl-extension( 4320): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 17:02:38.125+0900 I/efl-extension( 4320): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 17:02:38.125+0900 I/efl-extension( 4320): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4458e7b0, elm_image, func : 0x437eeef1
05-11 17:02:38.125+0900 I/efl-extension( 4320): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 17:02:38.125+0900 I/efl-extension( 4320): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44543378 : elm_scroller] rotary callabck is deleted
05-11 17:02:38.180+0900 I/AUL_PAD ( 4391): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-11 17:02:38.205+0900 E/TBM     ( 4391): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-11 17:02:38.285+0900 I/MALI    ( 4320): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x432f9620] swap changed from sync to async
05-11 17:02:38.310+0900 I/MALI    ( 4320): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-11 17:02:38.310+0900 I/MALI    ( 4320): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=4320   close drm_fd=22 
05-11 17:02:38.310+0900 I/MALI    ( 4320): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-11 17:02:38.340+0900 I/APP_CORE( 4249): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-11 17:02:38.340+0900 I/CAPI_APPFW_APPLICATION( 4249): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-11 17:02:38.365+0900 I/UXT     ( 4320): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-11 17:02:38.380+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-11 17:02:38.385+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-11 17:02:38.385+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x449c8bd0 is freed
05-11 17:02:38.385+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x449baa18 is freed
05-11 17:02:38.385+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44973720 is freed
05-11 17:02:38.385+0900 I/efl-extension( 4249): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x43884c10 is freed
05-11 17:02:38.390+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-11 17:02:38.390+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
05-11 17:02:38.395+0900 W/AUL_AMD (  484): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-11 17:02:38.395+0900 W/AUL_AMD (  484): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-11 17:02:38.435+0900 W/W_HOME  (  688): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-11 17:02:38.435+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:38.435+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:38.435+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:38.435+0900 W/W_HOME  (  688): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-11 17:02:38.440+0900 W/W_HOME  (  688): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-11 17:02:38.440+0900 W/W_HOME  (  688): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-11 17:02:38.440+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:38.440+0900 W/W_HOME  (  688): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-11 17:02:38.440+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: RESUME State: PAUSED
05-11 17:02:38.440+0900 I/CAPI_APPFW_APPLICATION(  688): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-11 17:02:38.440+0900 W/W_HOME  (  688): main.c: _appcore_resume_cb(681) > appcore resume
05-11 17:02:38.440+0900 W/W_HOME  (  688): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-11 17:02:38.440+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:38.440+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:38.440+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-11 17:02:38.440+0900 W/APPS    (  688): apps_main.c: _time_changed_cb(295) >  date : 11->11
05-11 17:02:38.440+0900 W/W_HOME  (  688): rotary.c: rotary_attach(138) > rotary_attach:0x476bd370
05-11 17:02:38.440+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x476bd370, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-11 17:02:38.440+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-11 17:02:38.445+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-11 17:02:38.445+0900 E/wnotib  (  688): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-11 17:02:38.445+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-11 17:02:38.445+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-11 17:02:38.445+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:02:38.445+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:02:38.445+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-11 17:02:38.545+0900 I/UXT     ( 4249): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-11 17:02:38.630+0900 I/efl-extension( 4320): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-11 17:02:38.835+0900 I/AUL_AMD (  484): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4320
05-11 17:02:38.835+0900 W/CRASH_MANAGER( 4299): worker.c: worker_job(1199) > 1104249706831146295375
