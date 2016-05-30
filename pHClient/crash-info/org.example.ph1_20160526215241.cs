S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 5648
Date: 2016-05-26 21:52:41+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x652f2f72

Register Information
r0   = 0x00000000, r1   = 0x41c6b708
r2   = 0x41c6b700, r3   = 0x00000000
r4   = 0x78652e67, r5   = 0x6c706d61
r6   = 0x68702e65, r7   = 0x65722f31
r8   = 0x438a5990, r9   = 0x438a4c10
r10  = 0x41d939a8, fp   = 0x00000000
ip   = 0x4142def4, sp   = 0xbed23658
lr   = 0x400953f8, pc   = 0x652f2f72
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     12124 KB
Buffers:     23404 KB
Cached:     168032 KB
VmPeak:      94312 KB
VmSize:      88688 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20572 KB
VmRSS:       19600 KB
VmData:      34272 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23960 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5648 TID = 5648
5648 5957 

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
41771000 41779000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.2.5
41781000 4178e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41796000 4179b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
417a3000 417a7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417b0000 417d1000 r-xp /usr/lib/libefl-extension.so.0.1.0
417d9000 417f0000 r-xp /usr/lib/libnetwork.so.0.0.0
417f8000 417fd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41805000 41823000 r-xp /usr/lib/libsensor.so.1.1.0
4182d000 4183f000 r-xp /usr/lib/libefl-assist.so.0.1.0
41847000 418ff000 r-xp /usr/lib/libcairo.so.2.11200.14
4190a000 4193b000 r-xp /usr/lib/libmdm.so.1.1.85
41943000 4194a000 r-xp /usr/lib/libsensord-share.so
41952000 41964000 r-xp /usr/lib/libtts.so
4196c000 4198d000 r-xp /usr/lib/libui-extension.so.0.1.0
41996000 4199d000 r-xp /usr/lib/libtbm.so.1.0.0
419a5000 419b3000 r-xp /usr/lib/libGLESv2.so.2.0
419bc000 419bd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
419c6000 419cc000 r-xp /usr/lib/libxcb-render.so.0.0.0
419d4000 419d7000 r-xp /usr/lib/libEGL.so.1.4
419df000 419e7000 r-xp /usr/lib/libmdm-common.so.1.0.89
419e8000 41b25000 r-xp /usr/lib/libicui18n.so.51.1
41b35000 41c19000 r-xp /usr/lib/libicuuc.so.51.1
41c2e000 41c31000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41c39000 41c41000 r-xp /usr/lib/libdrm.so.2.4.0
41c49000 41c4e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41c57000 41c5c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41c6a000 41d9c000 rw-p [heap]
43323000 43325000 r-xp /usr/lib/libdri2.so.0.0.0
4332d000 4334e000 r-xp /usr/lib/libexif.so.12.3.3
43361000 43366000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4336e000 43438000 r-xp /usr/lib/libCOREGL.so.4.0
4378f000 43793000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44ad4000 44ad7000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44b94000 45393000 rwxp [stack:5957]
4579c000 457d4000 r-xp /usr/lib/libpulse.so.0.16.2
4581d000 45822000 r-xp /usr/lib/libjson.so.0.0.1
4582a000 45872000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45873000 458b6000 r-xp /usr/lib/libsndfile.so.1.0.25
458c3000 458e5000 r-xp /usr/lib/libvorbis.so.0.4.3
458ed000 458f1000 r-xp /usr/lib/libogg.so.0.7.1
bed03000 bed24000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5648)
Call Stack Count: 1
 0: (0x652f2f72) (null)
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
n_create(372) > New handle created[0x438507d8]
05-26 21:51:19.016+0900 I/SOCKETTEST( 5648): IP : 
05-26 21:51:19.016+0900 I/SOCKETTEST( 5648): Success to create UDP socket
05-26 21:51:19.016+0900 I/SOCKETTEST( 5648): Bind Success
05-26 21:51:19.016+0900 I/SOCKETTEST( 5648): Waiting DATA...
05-26 21:51:19.051+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_cb(2104) > ::UI:: end show animation
05-26 21:51:19.051+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-26 21:51:19.051+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 3 3
05-26 21:51:19.056+0900 E/wnoti-service(  855): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
05-26 21:51:19.061+0900 E/wnoti-service(  855): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 2
05-26 21:51:19.066+0900 E/wnoti-service(  855): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-26 21:51:19.071+0900 E/wnoti-proxy( 3950): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
05-26 21:51:19.076+0900 E/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(916) > ::DATA:: No categories available.
05-26 21:51:19.076+0900 W/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 0, list count : 3
05-26 21:51:19.471+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:51:19.471+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-26 21:51:20.121+0900 E/wnoti-service(  855): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
05-26 21:51:20.836+0900 I/SOCKETTEST( 5648): Receive Data : 192.168.0.47
05-26 21:51:20.836+0900 I/SOCKETTEST( 5648): Changed IP : 192.168.0.47
05-26 21:51:20.901+0900 I/SOCKETTEST( 5648): Success to create socket
05-26 21:51:20.941+0900 I/SOCKETTEST( 5648): Success to socket connection
05-26 21:51:20.941+0900 I/SOCKETTEST( 5648): write() 성공
05-26 21:51:21.591+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-26 21:51:21.596+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_main_popup_timer_cb(2324) > ::UI:: start hiding animation
05-26 21:51:21.646+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:51:21.916+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_hide_animator_cb(2255) > ::UI:: end hiding animation
05-26 21:51:21.916+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-26 21:51:21.916+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 3 3
05-26 21:51:21.916+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (8, 1, 0)
05-26 21:51:21.926+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=0, view_state=0
05-26 21:51:21.926+0900 I/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(903) > ::UI:: it is invalid object.
05-26 21:51:21.926+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [invalid object] is UNLOCK , 0000 <=== ]]]
05-26 21:51:21.926+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 3 3
05-26 21:51:21.926+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 762
05-26 21:51:21.941+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 2, 2
05-26 21:51:21.966+0900 I/efl-extension( 3950): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44341778, obj: 0x44341778
05-26 21:51:21.966+0900 I/efl-extension( 3950): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:51:22.021+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:22.021+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44341778, elm_genlist, func : 0x41a25dfd
05-26 21:51:22.021+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:22.031+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:51:22.031+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(998) > ::UI:: lock state = 0000
05-26 21:51:22.031+0900 I/efl-extension( 3950): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-26 21:51:22.031+0900 I/wnotibp ( 3950): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4568) > Panel open state: 0 for 34, 218
05-26 21:51:22.031+0900 I/efl-extension( 3950): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-26 21:51:22.031+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(2024) > ::INFO:: call lower
05-26 21:51:22.081+0900 W/APP_CORE( 3950): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:5600008
05-26 21:51:22.081+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: PAUSE State: RUNNING
05-26 21:51:22.081+0900 I/CAPI_APPFW_APPLICATION( 3950): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 21:51:22.126+0900 E/wnoti-service(  855): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
05-26 21:51:22.151+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-26 21:51:22.161+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:51:22.161+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [2, 2, 15, 0000]
05-26 21:51:22.161+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 0]
05-26 21:51:22.161+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1371) > [0, 1, 0, 2, 0]
05-26 21:51:22.616+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1119662 button=1 downs=1
05-26 21:51:22.706+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1119757 button=1 downs=0
05-26 21:51:22.726+0900 D/TIMER   ( 5648): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:51:22.726+0900 D/TIMER   ( 5648): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:51:22.781+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:51:22.781+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:51:22.781+0900 I/efl-extension( 5648): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:51:22.781+0900 I/efl-extension( 5648): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:51:22.786+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44904790, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:51:24.651+0900 I/efl-extension( 5648): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44904790
05-26 21:51:24.651+0900 I/efl-extension( 5648): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44904790, obj: 0x44904790
05-26 21:51:24.651+0900 I/efl-extension( 5648): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:51:24.651+0900 I/efl-extension( 5648): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:51:24.651+0900 I/efl-extension( 5648): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:51:24.651+0900 I/efl-extension( 5648): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:51:24.831+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1121880 button=1 downs=1
05-26 21:51:24.931+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1121982 button=1 downs=0
05-26 21:51:24.931+0900 D/TIMER   ( 5648): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:51:24.931+0900 D/TIMER   ( 5648): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:51:24.941+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:51:24.941+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44904910, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:51:25.686+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1122730 button=1 downs=1
05-26 21:51:25.741+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1122788 button=1 downs=0
05-26 21:51:26.416+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.416+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.421+0900 I/efl-extension( 5648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.421+0900 I/efl-extension( 5648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904910, elm_layout, time_stamp : 1123466
05-26 21:51:26.421+0900 E/TIMER   ( 5648): (ad->timer) -> _rotary_cb() return
05-26 21:51:26.446+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.446+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.446+0900 I/efl-extension( 5648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.446+0900 I/efl-extension( 5648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904910, elm_layout, time_stamp : 1123495
05-26 21:51:26.446+0900 E/TIMER   ( 5648): (ad->timer) -> _rotary_cb() return
05-26 21:51:26.471+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.471+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.471+0900 I/efl-extension( 5648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.471+0900 I/efl-extension( 5648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904910, elm_layout, time_stamp : 1123519
05-26 21:51:26.471+0900 E/TIMER   ( 5648): (ad->timer) -> _rotary_cb() return
05-26 21:51:26.496+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.496+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.496+0900 I/efl-extension( 5648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.496+0900 I/efl-extension( 5648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904910, elm_layout, time_stamp : 1123545
05-26 21:51:26.496+0900 E/TIMER   ( 5648): (ad->timer) -> _rotary_cb() return
05-26 21:51:26.516+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.521+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.521+0900 I/efl-extension( 5648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.521+0900 I/efl-extension( 5648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904910, elm_layout, time_stamp : 1123568
05-26 21:51:26.521+0900 E/TIMER   ( 5648): (ad->timer) -> _rotary_cb() return
05-26 21:51:26.556+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.556+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.556+0900 I/efl-extension( 5648): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:26.556+0900 I/efl-extension( 5648): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44904910, elm_layout, time_stamp : 1123604
05-26 21:51:26.556+0900 E/TIMER   ( 5648): (ad->timer) -> _rotary_cb() return
05-26 21:51:27.031+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1124079 button=1 downs=1
05-26 21:51:27.086+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1124137 button=1 downs=0
05-26 21:51:27.086+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:27.086+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:27.086+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:51:27.086+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:51:27.086+0900 I/efl-extension( 5648): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:51:27.086+0900 I/efl-extension( 5648): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:51:27.086+0900 I/efl-extension( 5648): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:51:27.086+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:27.086+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:27.086+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:27.166+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: MEM_FLUSH State: PAUSED
05-26 21:51:27.726+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.726+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.776+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.776+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.811+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.811+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.836+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.836+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.856+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.856+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.911+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:27.911+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:28.026+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:28.026+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:51:29.731+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1126781 button=1 downs=1
05-26 21:51:29.741+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1126792 button=1 downs=0
05-26 21:51:29.746+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:29.746+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:29.746+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:29.746+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:29.746+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:31.591+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1128639 button=1 downs=1
05-26 21:51:31.736+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1128784 button=1 downs=0
05-26 21:51:31.736+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:31.736+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:31.736+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:31.736+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:31.736+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:32.316+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1129363 button=1 downs=1
05-26 21:51:32.391+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1129442 button=1 downs=0
05-26 21:51:32.491+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1129538 button=1 downs=1
05-26 21:51:32.576+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1129625 button=1 downs=0
05-26 21:51:32.681+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1129732 button=1 downs=1
05-26 21:51:32.766+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1129818 button=1 downs=0
05-26 21:51:32.861+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1129908 button=1 downs=1
05-26 21:51:32.956+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1130006 button=1 downs=0
05-26 21:51:33.046+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1130093 button=1 downs=1
05-26 21:51:33.151+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1130202 button=1 downs=0
05-26 21:51:39.766+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1136816 button=1 downs=1
05-26 21:51:39.836+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1136884 button=1 downs=0
05-26 21:51:39.836+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:39.836+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:39.836+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:39.836+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:39.836+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:40.216+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1137263 button=1 downs=1
05-26 21:51:40.306+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1137353 button=1 downs=0
05-26 21:51:40.306+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:40.306+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:40.306+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:40.306+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:40.306+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:40.396+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1137446 button=1 downs=1
05-26 21:51:40.486+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1137533 button=1 downs=0
05-26 21:51:40.486+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:40.486+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:40.486+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:40.486+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:40.486+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:40.566+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1137613 button=1 downs=1
05-26 21:51:40.651+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1137701 button=1 downs=0
05-26 21:51:40.651+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:40.651+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:40.651+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:40.656+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:40.656+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:40.736+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1137783 button=1 downs=1
05-26 21:51:40.821+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1137870 button=1 downs=0
05-26 21:51:40.821+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:40.821+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:40.821+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:40.821+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:40.826+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:40.916+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1137964 button=1 downs=1
05-26 21:51:40.971+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1138018 button=1 downs=0
05-26 21:51:40.971+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:40.971+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:40.971+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:40.971+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:40.971+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:41.556+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1138607 button=1 downs=1
05-26 21:51:41.626+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1138675 button=1 downs=0
05-26 21:51:41.626+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:41.626+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:41.626+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:41.626+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:41.626+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:41.741+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1138789 button=1 downs=1
05-26 21:51:41.816+0900 E/EFL     ( 5648): evas_main<5648> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1138865 button=1 downs=0
05-26 21:51:41.816+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:51:41.816+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44904910, elm_layout, func : 0x414607e1
05-26 21:51:41.816+0900 I/efl-extension( 5648): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:51:41.816+0900 D/TIMER   ( 5648): Setting time is 0
05-26 21:51:41.816+0900 E/TIMER   ( 5648): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:51:44.956+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-26 21:51:44.956+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-26 21:51:44.956+0900 E/WMS     (  491): ==========
05-26 21:51:44.956+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
05-26 21:51:44.956+0900 E/WMS     (  491): ==========
05-26 21:51:44.956+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-26 21:51:44.996+0900 W/SCSD    ( 1200): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-26 21:51:44.996+0900 W/SCSD    ( 1200): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-26 21:51:44.996+0900 W/SCSD    ( 1200): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-26 21:51:45.001+0900 W/SCSD    ( 1200): <util_scs_send:975> sent [63 / 63] bytes. 
05-26 21:51:45.026+0900 W/SHealth_Service( 1055): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-26 21:51:45.026+0900 E/SHealth_Service( 1055): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-26 21:51:59.726+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 21:51:59.731+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 21:51:59.736+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : pedometer_inactive_period error
05-26 21:51:59.746+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:51:59.751+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:51:59.756+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_10min_precaution_millisec error
05-26 21:51:59.766+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:51:59.766+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:51:59.766+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_before_10min_precaution_millisec error
05-26 21:52:00.791+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:52:04.946+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:52:04.946+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:52:14.961+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 21:52:21.646+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 34 -> 33 1464267141 150
05-26 21:52:21.651+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 1151 323 633
05-26 21:52:21.651+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 0 0 808
05-26 21:52:21.651+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 1012 205 557
05-26 21:52:21.651+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 114 5 63
05-26 21:52:21.651+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 310 42 171
05-26 21:52:41.221+0900 E/PKGMGR_SERVER( 6043): pkgmgr-server.c: main(2131) > package manager server start
05-26 21:52:41.311+0900 E/PKGMGR_SERVER( 6043): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_1140699739], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[1FX8HVtyh6e5DgwWw+o85P5N0Tk=], backend_flag=[0]
05-26 21:52:41.321+0900 E/PKGMGR_SERVER( 6044): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-26 21:52:41.326+0900 E/PKGMGR  ( 6041): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-26 21:52:41.391+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:52:41.401+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5648
05-26 21:52:41.406+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:52:41.406+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 5
05-26 21:52:41.411+0900 I/APP_CORE( 5648): appcore-efl.c: __do_app(429) > [APP 5648] Event: TERMINATE State: RUNNING
05-26 21:52:41.416+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 21:52:41.416+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 21:52:41.416+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(5648), cmd(4)
05-26 21:52:41.416+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:52:41.431+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5648
05-26 21:52:41.481+0900 I/APP_CORE( 5648): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 21:52:41.481+0900 I/CAPI_APPFW_APPLICATION( 5648): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 21:52:41.501+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:52:41.501+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:52:41.511+0900 I/efl-extension( 5648): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44904910
05-26 21:52:41.511+0900 I/efl-extension( 5648): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44904910, obj: 0x44904910
05-26 21:52:41.511+0900 I/efl-extension( 5648): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:52:41.531+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:52:41.541+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5648
05-26 21:52:41.591+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 21:52:41.596+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 21:52:41.596+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 21:52:41.596+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 21:52:41.596+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 21:52:41.596+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 21:52:41.601+0900 I/UXT     ( 5648): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 21:52:41.641+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:52:41.651+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5648
05-26 21:52:41.656+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 21:52:41.656+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:52:41.661+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:52:41.661+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:52:41.661+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 21:52:41.666+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(0)
05-26 21:52:41.666+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 21:52:41.666+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:52:41.666+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(0)
05-26 21:52:41.666+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESUME State: PAUSED
05-26 21:52:41.666+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 21:52:41.666+0900 W/W_HOME  (  737): main.c: _appcore_resume_cb(681) > appcore resume
05-26 21:52:41.666+0900 W/W_HOME  (  737): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 21:52:41.666+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:52:41.666+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:52:41.666+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:52:41.666+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:52:41.671+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 21:52:41.671+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 21:52:41.671+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:52:41.676+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 21:52:41.676+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:52:41.676+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1692) > Do the postponed update job.
05-26 21:52:41.676+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1059) > idler for type: 0
05-26 21:52:41.676+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:52:41.676+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:52:41.676+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:52:41.676+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:52:41.701+0900 I/wnoti-proxy(  737): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-26 21:52:41.701+0900 I/wnoti-proxy(  737): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-26 21:52:41.701+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1106) > unread_count: 2
05-26 21:52:41.701+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(626) > category_id: 34, application_id: 218, application_name: 카카오톡, time_stamp: 1464267076, content_id: 0, spannable_string_version: 1
05-26 21:52:41.701+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  34, 카카오톡.
05-26 21:52:41.706+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 34, application_id: 218, type: 1
05-26 21:52:41.716+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 21:52:41.716+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:52:41.716+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 21:52:41.716+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 21:52:41.721+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-26 21:52:41.721+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 34, application_id: 218, type: 13
05-26 21:52:41.721+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 21:52:41.721+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:52:41.721+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 21:52:41.721+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 21:52:41.721+0900 I/wnotib  (  737): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:52:41.726+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1378) > This noti will be removed from panel: 34, 카카오톡.
05-26 21:52:41.726+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 34, application_id: 218, type: 2
05-26 21:52:41.726+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2986) > We don't need to delete the item for second_depth_type: 0.
05-26 21:52:41.731+0900 E/EFL     (  737): elementary<737> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
05-26 21:52:41.731+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 34, application_id: 218, type: 12
05-26 21:52:41.731+0900 I/wnotib  (  737): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:52:41.731+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1387) > Num categories: 1, num total noti: 2
05-26 21:52:41.736+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(871) > Free noti manager data.
05-26 21:52:41.736+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(876) > Free previous notifications.
05-26 21:52:41.736+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(897) > Free previous categories.
05-26 21:52:41.736+0900 I/wnotib  (  737): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
05-26 21:52:41.736+0900 I/wnotib  (  737): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
05-26 21:52:41.736+0900 I/wnotib  (  737): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
05-26 21:52:41.736+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1412) > num_total_panel: 1.
05-26 21:52:41.736+0900 W/W_HOME  (  737): noti_broker.c: _handler_indicator_update(562) > 0x1
05-26 21:52:41.756+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:52:41.761+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5648
05-26 21:52:41.771+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1416) > unread_count_for_home: 2
05-26 21:52:41.771+0900 W/W_HOME  (  737): noti_broker.c: _handler_noti_indicator_show(478) > 
05-26 21:52:41.781+0900 W/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-26 21:52:41.866+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:52:41.871+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5648
05-26 21:52:41.976+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:52:41.991+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 21:52:42.001+0900 E/PKGMGR_SERVER( 6044): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-26 21:52:42.046+0900 E/PKGMGR_SERVER( 6043): pkgmgr-server.c: sighandler(409) > child NORMAL exit [6044]
05-26 21:52:42.091+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 21:52:42.141+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 5648
05-26 21:52:42.181+0900 W/CRASH_MANAGER( 6047): worker.c: worker_job(1199) > 1105648706831146426716
