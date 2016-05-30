S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 15735
Date: 2016-05-09 20:22:47+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 15735, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x418ab450
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x45047060, r5   = 0x418ab450
r6   = 0x4187d978, r7   = 0xbe9de328
r8   = 0x00000000, r9   = 0x41946e00
r10  = 0x418bf3c0, fp   = 0x00000001
ip   = 0x00000000, sp   = 0xbe9de2e8
lr   = 0x4022f591, pc   = 0x4155ebb0
cpsr = 0x60000030

Memory Information
MemTotal:   490584 KB
MemFree:     16368 KB
Buffers:     47760 KB
Cached:     156040 KB
VmPeak:      92076 KB
VmSize:      90040 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20032 KB
VmRSS:       20028 KB
VmData:      31340 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       24888 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15735 TID = 15735
15735 15787 

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
4155d000 41562000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
41572000 41576000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4157f000 41581000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4158a000 41590000 r-xp /usr/lib/libappsvc.so.0.1.0
41598000 415bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415c5000 41694000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416aa000 416b4000 r-xp /lib/libnss_files-2.13.so
4195c000 41967000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41971000 4197e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41986000 4198b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41993000 419b4000 r-xp /usr/lib/libefl-extension.so.0.1.0
419bc000 419d3000 r-xp /usr/lib/libnetwork.so.0.0.0
419db000 419e0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
419e8000 419fa000 r-xp /usr/lib/libefl-assist.so.0.1.0
41a02000 41aba000 r-xp /usr/lib/libcairo.so.2.11200.14
41ac5000 41af6000 r-xp /usr/lib/libmdm.so.1.1.85
41afe000 41b10000 r-xp /usr/lib/libtts.so
41b18000 41b39000 r-xp /usr/lib/libui-extension.so.0.1.0
41b42000 41b49000 r-xp /usr/lib/libtbm.so.1.0.0
41b51000 41b5f000 r-xp /usr/lib/libGLESv2.so.2.0
41b68000 41b69000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41b72000 41b78000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b80000 41b83000 r-xp /usr/lib/libEGL.so.1.4
41b8b000 41b93000 r-xp /usr/lib/libmdm-common.so.1.0.89
41b94000 41cd1000 r-xp /usr/lib/libicui18n.so.51.1
41ce1000 41dc5000 r-xp /usr/lib/libicuuc.so.51.1
41dda000 41ddd000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41de5000 41ded000 r-xp /usr/lib/libdrm.so.2.4.0
4337c000 43381000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4338a000 4338f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43397000 43399000 r-xp /usr/lib/libdri2.so.0.0.0
433a1000 433c2000 r-xp /usr/lib/libexif.so.12.3.3
433d5000 433da000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433e2000 434ac000 r-xp /usr/lib/libCOREGL.so.4.0
434bf000 43cbe000 rwxp [stack:15787]
43fef000 43ffa000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44003000 44007000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4400f000 44026000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44033000 44035000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
4555f000 45560000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4557d000 45584000 r-xp /usr/lib/libfeedback.so.0.1.4
4558d000 4558e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45596000 45598000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
455a0000 455aa000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
455b2000 455b9000 r-xp /usr/lib/libmmfcommon.so.0.0.0
455c1000 455d7000 r-xp /usr/lib/libmmfsound.so.0.1.0
455e9000 455ee000 r-xp /usr/lib/libmmfsession.so.0.0.0
455f6000 45600000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4560c000 45610000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45619000 4562f000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45638000 4563d000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
45645000 45648000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45650000 456b1000 r-xp /usr/lib/libasound.so.2.0.0
456bb000 456f3000 r-xp /usr/lib/libpulse.so.0.16.2
456f4000 456f7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
456ff000 4570c000 r-xp /usr/lib/libail.so.0.1.0
45715000 45725000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
45746000 4574e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
4575d000 45760000 r-xp /usr/lib/libcompress.so.0.2.0
45768000 4576d000 r-xp /usr/lib/libjson.so.0.0.1
45775000 457bd000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
457be000 45801000 r-xp /usr/lib/libsndfile.so.1.0.25
4580e000 45830000 r-xp /usr/lib/libvorbis.so.0.4.3
45838000 4583c000 r-xp /usr/lib/libogg.so.0.7.1
be9be000 be9df000 rwxp [stack]
End of Maps Information

Callstack Information (PID:15735)
Call Stack Count: 1
 0: _auto_connect_button_click_cb + 0x13 (0x4155ebb0) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x1bb0
End of Call Stack

Package Information
Package Name: org.example.ph1
Package ID : org.example.ph1
Version: 1.0.0
Package Type: rpm
App Name: pHp
App ID: org.example.ph1
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-09 20:22:40.078+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c960a0, elm_box, _activated_obj : 0x47abcda8, activated : 1
05-09 20:22:40.078+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-09 20:22:40.078+0900 E/wnotib  (  680): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-09 20:22:40.078+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-09 20:22:40.078+0900 W/W_HOME  (  680): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-09 20:22:40.083+0900 W/W_HOME  (  680): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-09 20:22:40.083+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.083+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.083+0900 W/W_HOME  (  680): main.c: home_pause(751) > clock/widget paused
05-09 20:22:40.083+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.083+0900 W/APPS    (  680): apps_main.c: _time_changed_cb(295) >  date : 9->9
05-09 20:22:40.083+0900 W/W_HOME  (  680): rotary.c: rotary_attach(138) > rotary_attach:0x46663768
05-09 20:22:40.083+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46663768, elm_layout, _activated_obj : 0x45c960a0, activated : 1
05-09 20:22:40.083+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-09 20:22:40.088+0900 W/W_HOME  (  680): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-09 20:22:40.088+0900 W/W_HOME  (  680): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-09 20:22:40.088+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-09 20:22:40.088+0900 I/wnotib  (  680): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-09 20:22:40.088+0900 E/APPS    (  680): apps_main.c: apps_main_resume(621) >  resumed already
05-09 20:22:40.088+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:40.088+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:40.088+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:40.088+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:40.258+0900 W/W_HOME  (  680): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-09 20:22:40.418+0900 I/GESTURE (  142): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-09 20:22:40.428+0900 E/EFL     (  680): evas_main<680> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8060625 button=1 downs=1
05-09 20:22:40.428+0900 W/APPS    (  680): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [218, 201]
05-09 20:22:40.503+0900 E/EFL     (  680): evas_main<680> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8060700 button=1 downs=0
05-09 20:22:40.503+0900 W/APPS    (  680): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [218, 201]->[212, 205]
05-09 20:22:40.503+0900 W/APPS    (  680): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,20]
05-09 20:22:40.503+0900 E/APPS    (  680): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-09 20:22:40.503+0900 W/APPS    (  680): AppsItem.cpp: onItemClicked(410) >  item(pHp) launched, open(0)
05-09 20:22:40.508+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-09 20:22:40.508+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 680
05-09 20:22:40.508+0900 I/AUL_AMD (  487): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-09 20:22:40.518+0900 W/AUL_AMD (  487): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 15724
05-09 20:22:40.518+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(15724), cmd(0)
05-09 20:22:40.523+0900 I/APP_CORE(15724): appcore-efl.c: __do_app(429) > [APP 15724] Event: RESET State: PAUSED
05-09 20:22:40.523+0900 I/CAPI_APPFW_APPLICATION(15724): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-09 20:22:40.523+0900 I/APP_CORE(15724): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-09 20:22:40.523+0900 I/APP_CORE(15724): appcore-efl.c: __do_app(481) > [APP 15724] App already running, raise the window
05-09 20:22:40.523+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-09 20:22:40.533+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x03c00003)
05-09 20:22:40.533+0900 I/APP_CORE(15724): appcore-efl.c: __do_app(485) > [APP 15724] Call the resume_cb
05-09 20:22:40.533+0900 I/CAPI_APPFW_APPLICATION(15724): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-09 20:22:40.548+0900 W/W_HOME  (  680): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-09 20:22:40.548+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.548+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.548+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.548+0900 W/W_HOME  (  680): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-09 20:22:40.553+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:40.553+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:40.588+0900 I/MALI    (  680): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-09 20:22:40.588+0900 I/APP_CORE(15724): appcore-efl.c: __do_app(429) > [APP 15724] Event: RESUME State: RUNNING
05-09 20:22:40.588+0900 W/W_HOME  (  680): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-09 20:22:40.588+0900 W/W_HOME  (  680): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-09 20:22:40.588+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.588+0900 W/W_HOME  (  680): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-09 20:22:40.588+0900 I/APP_CORE(  680): appcore-efl.c: __do_app(429) > [APP 680] Event: PAUSE State: RUNNING
05-09 20:22:40.588+0900 I/CAPI_APPFW_APPLICATION(  680): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-09 20:22:40.588+0900 W/W_HOME  (  680): main.c: _appcore_pause_cb(690) > appcore pause
05-09 20:22:40.588+0900 W/W_HOME  (  680): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-09 20:22:40.588+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.593+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.593+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.593+0900 W/W_HOME  (  680): rotary.c: rotary_deattach(156) > rotary_deattach:0x46663768
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46663768, elm_layout, func : 0x4004b469
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c960a0, elm_box, _activated_obj : 0x46663768, activated : 1
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-09 20:22:40.593+0900 E/wnotib  (  680): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-09 20:22:40.593+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:40.603+0900 E/CAPI_APPFW_APP_CONTROL( 1082): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-09 20:22:40.603+0900 W/MUSIC_CONTROL_SERVICE( 1082): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1082]   [com.samsung.w-home]register msg port [false][0m
05-09 20:22:40.608+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:40.608+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:40.658+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-09 20:22:40.658+0900 E/wnotib  (  680): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-09 20:22:40.668+0900 W/APPS    (  680): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-09 20:22:40.783+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-09 20:22:40.783+0900 W/AUL_AMD (  487): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-09 20:22:40.978+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-09 20:22:41.108+0900 I/APP_CORE(  680): appcore-efl.c: __do_app(429) > [APP 680] Event: MEM_FLUSH State: PAUSED
05-09 20:22:41.113+0900 E/EFL     (15724): evas_main<15724> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8061318 button=1 downs=1
05-09 20:22:41.183+0900 E/EFL     (15724): evas_main<15724> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8061393 button=1 downs=0
05-09 20:22:42.248+0900 E/EFL     (15724): evas_main<15724> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8062452 button=1 downs=1
05-09 20:22:42.313+0900 E/EFL     (15724): evas_main<15724> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8062521 button=1 downs=0
05-09 20:22:42.738+0900 W/CRASH_MANAGER(15765): worker.c: worker_job(1199) > 11157247068311462792962
05-09 20:22:42.898+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-09 20:22:42.898+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-09 20:22:42.913+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 23
05-09 20:22:42.913+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
05-09 20:22:42.913+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 15724
05-09 20:22:42.913+0900 W/AUL_AMD (  487): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-09 20:22:42.918+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 15724
05-09 20:22:42.958+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-09 20:22:42.963+0900 W/WATCH_CORE(  722): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-09 20:22:42.963+0900 I/WATCH_CORE(  722): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-09 20:22:42.963+0900 I/CAPI_WATCH_APPLICATION(  722): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-09 20:22:42.963+0900 E/watchface-loader(  722): watchface-loader.cpp: OnAppTimeTick(740) > 
05-09 20:22:42.963+0900 I/watchface-loader(  722): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-09 20:22:42.983+0900 W/W_HOME  (  680): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-09 20:22:42.983+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:42.983+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:42.983+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:42.983+0900 W/W_HOME  (  680): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-09 20:22:42.993+0900 W/W_HOME  (  680): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-09 20:22:42.993+0900 W/W_HOME  (  680): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-09 20:22:42.993+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:42.993+0900 W/W_HOME  (  680): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-09 20:22:42.993+0900 I/APP_CORE(  680): appcore-efl.c: __do_app(429) > [APP 680] Event: RESUME State: PAUSED
05-09 20:22:42.993+0900 I/CAPI_APPFW_APPLICATION(  680): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-09 20:22:42.993+0900 W/W_HOME  (  680): main.c: _appcore_resume_cb(681) > appcore resume
05-09 20:22:42.993+0900 W/W_HOME  (  680): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-09 20:22:42.993+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:42.998+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:42.998+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:42.998+0900 W/APPS    (  680): apps_main.c: _time_changed_cb(295) >  date : 9->9
05-09 20:22:42.998+0900 W/W_HOME  (  680): rotary.c: rotary_attach(138) > rotary_attach:0x46663768
05-09 20:22:42.998+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46663768, elm_layout, _activated_obj : 0x45c960a0, activated : 1
05-09 20:22:42.998+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-09 20:22:42.998+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-09 20:22:42.998+0900 E/wnotib  (  680): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-09 20:22:42.998+0900 W/wnotib  (  680): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-09 20:22:42.998+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:42.998+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:42.998+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:42.998+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:43.478+0900 I/MALI    (  680): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-09 20:22:43.643+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-09 20:22:43.648+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-09 20:22:43.998+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:43.998+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:43.998+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:43.998+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:43.998+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:43.998+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:43.998+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-09 20:22:43.998+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:44.003+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:44.003+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:44.003+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:44.003+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:44.003+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:44.003+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:44.003+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-09 20:22:44.003+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:44.003+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:44.003+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:44.003+0900 E/CAPI_APPFW_APP_CONTROL( 1082): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-09 20:22:44.003+0900 W/MUSIC_CONTROL_SERVICE( 1082): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1082]   [com.samsung.w-home]register msg port [true][0m
05-09 20:22:44.008+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-09 20:22:44.018+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 680
05-09 20:22:44.023+0900 W/MUSIC_CONTROL_SERVICE( 1082): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1082]   [MUSIC_PLAYER_EVENT][0m
05-09 20:22:44.028+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:44.028+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:44.028+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:44.028+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:44.028+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:44.028+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:44.028+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:44.028+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:44.033+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:44.033+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:44.033+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:44.033+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:44.033+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:44.033+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:44.033+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:44.033+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:44.033+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:44.033+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:44.033+0900 W/W_HOME  (  680): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-09 20:22:44.033+0900 E/W_HOME  (  680): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-09 20:22:44.038+0900 W/MUSIC_CONTROL_SERVICE( 1082): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1082]   [MUSIC_PLAYER_EVENT][0m
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:44.038+0900 W/W_HOME  (  680): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-09 20:22:44.038+0900 E/W_HOME  (  680): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:44.038+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:44.043+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:44.043+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:44.043+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:44.043+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:44.043+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:44.043+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:44.043+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:44.043+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:44.043+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:44.043+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:45.363+0900 I/GESTURE (  142): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-09 20:22:45.368+0900 E/EFL     (  680): evas_main<680> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8065573 button=1 downs=1
05-09 20:22:45.368+0900 W/APPS    (  680): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [194, 150]
05-09 20:22:45.483+0900 E/EFL     (  680): evas_main<680> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8065682 button=1 downs=0
05-09 20:22:45.483+0900 W/APPS    (  680): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [194, 150]->[183, 152]
05-09 20:22:45.488+0900 W/APPS    (  680): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,20]
05-09 20:22:45.488+0900 E/APPS    (  680): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-09 20:22:45.488+0900 W/APPS    (  680): AppsItem.cpp: onItemClicked(410) >  item(pHp) launched, open(0)
05-09 20:22:45.488+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-09 20:22:45.493+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 680
05-09 20:22:45.493+0900 I/AUL_AMD (  487): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-09 20:22:45.503+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(2080) > pad pid(-5)
05-09 20:22:45.503+0900 W/AUL_PAD ( 1073): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-09 20:22:45.503+0900 W/AUL_PAD ( 1073): launchpad.c: __send_result_to_caller(272) > Check app launching
05-09 20:22:45.503+0900 E/RESOURCED(  488): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-09 20:22:45.503+0900 E/RESOURCED(  488): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-09 20:22:45.538+0900 I/efl-extension(15735): efl_extension.c: eext_mod_init(40) > Init
05-09 20:22:45.538+0900 I/UXT     (15735): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-09 20:22:45.598+0900 I/CAPI_APPFW_APPLICATION(15735): app_main.c: ui_app_main(704) > app_efl_main
05-09 20:22:45.598+0900 I/CAPI_APPFW_APPLICATION(15735): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-09 20:22:45.608+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-09 20:22:45.663+0900 E/RESOURCED(  488): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-09 20:22:45.678+0900 E/TBM     (15735): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-09 20:22:45.793+0900 E/EFL     (15735): <15735> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-09 20:22:45.798+0900 E/EFL     (15735): <15735> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-09 20:22:45.798+0900 E/EFL     (15735): <15735> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-09 20:22:45.803+0900 E/EFL     (15735): <15735> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-09 20:22:45.803+0900 E/EFL     (15735): <15735> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-09 20:22:45.843+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05800002)
05-09 20:22:45.868+0900 W/W_HOME  (  680): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-09 20:22:45.868+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:45.868+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:45.868+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:45.868+0900 W/W_HOME  (  680): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-09 20:22:45.868+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:45.868+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:45.893+0900 I/APP_CORE(15735): appcore-efl.c: __do_app(429) > [APP 15735] Event: RESET State: CREATED
05-09 20:22:45.893+0900 I/CAPI_APPFW_APPLICATION(15735): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-09 20:22:45.903+0900 I/APP_CORE(15735): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-09 20:22:45.903+0900 I/APP_CORE(15735): appcore-efl.c: __do_app(474) > [APP 15735] Initial Launching, call the resume_cb
05-09 20:22:45.903+0900 I/CAPI_APPFW_APPLICATION(15735): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-09 20:22:45.908+0900 W/APP_CORE(15735): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
05-09 20:22:45.943+0900 W/W_HOME  (  680): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-09 20:22:45.943+0900 W/W_HOME  (  680): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-09 20:22:45.943+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:45.943+0900 W/W_HOME  (  680): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-09 20:22:45.948+0900 I/APP_CORE(  680): appcore-efl.c: __do_app(429) > [APP 680] Event: PAUSE State: RUNNING
05-09 20:22:45.948+0900 I/CAPI_APPFW_APPLICATION(  680): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-09 20:22:45.948+0900 W/W_HOME  (  680): main.c: _appcore_pause_cb(690) > appcore pause
05-09 20:22:45.948+0900 W/W_HOME  (  680): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-09 20:22:45.948+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:45.948+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:45.948+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:45.948+0900 W/W_HOME  (  680): rotary.c: rotary_deattach(156) > rotary_deattach:0x46663768
05-09 20:22:45.948+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-09 20:22:45.948+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46663768, elm_layout, func : 0x4004b469
05-09 20:22:45.948+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-09 20:22:45.948+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-09 20:22:45.948+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-09 20:22:45.948+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c960a0, elm_box, _activated_obj : 0x46663768, activated : 1
05-09 20:22:45.948+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-09 20:22:45.948+0900 E/wnotib  (  680): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-09 20:22:45.948+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-09 20:22:45.958+0900 I/APP_CORE(15735): appcore-efl.c: __do_app(429) > [APP 15735] Event: RESUME State: RUNNING
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:45.968+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:45.968+0900 E/CAPI_APPFW_APP_CONTROL( 1082): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-09 20:22:45.968+0900 W/MUSIC_CONTROL_SERVICE( 1082): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1082]   [com.samsung.w-home]register msg port [false][0m
05-09 20:22:45.973+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:45.973+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:46.043+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-09 20:22:46.043+0900 E/wnotib  (  680): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-09 20:22:46.058+0900 W/APPS    (  680): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-09 20:22:46.338+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-09 20:22:46.463+0900 E/EFL     (15735): evas_main<15735> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8066669 button=1 downs=1
05-09 20:22:46.473+0900 I/APP_CORE(  680): appcore-efl.c: __do_app(429) > [APP 680] Event: MEM_FLUSH State: PAUSED
05-09 20:22:46.638+0900 E/EFL     (15735): evas_main<15735> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8066845 button=1 downs=0
05-09 20:22:46.638+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-09 20:22:46.648+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15735
05-09 20:22:46.653+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-09 20:22:46.968+0900 I/AUL_PAD (15790): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-09 20:22:47.493+0900 E/EFL     (15735): evas_main<15735> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8067698 button=1 downs=1
05-09 20:22:47.643+0900 E/EFL     (15735): evas_main<15735> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8067850 button=1 downs=0
05-09 20:22:47.883+0900 W/CRASH_MANAGER(15765): worker.c: worker_job(1199) > 1115735706831146279296
