S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 3697
Date: 2016-05-12 16:55:15+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000009
r2   = 0x0000000a, r3   = 0x00000000
r4   = 0x4030c9c0, r5   = 0x4059a4b8
r6   = 0x4030c16c, r7   = 0x00000000
r8   = 0x436342e4, r9   = 0x418f8100
r10  = 0x4031ab18, fp   = 0x00000000
ip   = 0x4059a4b8, sp   = 0xbed0b278
lr   = 0x404a808c, pc   = 0x404a81f4
cpsr = 0x80000010

Memory Information
MemTotal:   491012 KB
MemFree:     15224 KB
Buffers:     27084 KB
Cached:     122436 KB
VmPeak:      92896 KB
VmSize:      91372 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21712 KB
VmRSS:       21712 KB
VmData:      34772 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23156 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3697 TID = 3697
3697 4027 4069 

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
4175c000 41767000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41771000 4177e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
41786000 4178b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41793000 41797000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417a0000 417c1000 r-xp /usr/lib/libefl-extension.so.0.1.0
417c9000 417e0000 r-xp /usr/lib/libnetwork.so.0.0.0
417e8000 417ed000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
417f5000 41813000 r-xp /usr/lib/libsensor.so.1.1.0
4181d000 4182f000 r-xp /usr/lib/libefl-assist.so.0.1.0
41837000 41868000 r-xp /usr/lib/libmdm.so.1.1.85
41870000 41877000 r-xp /usr/lib/libsensord-share.so
4187f000 41891000 r-xp /usr/lib/libtts.so
41899000 418a0000 r-xp /usr/lib/libtbm.so.1.0.0
418a8000 418b6000 r-xp /usr/lib/libGLESv2.so.2.0
418bf000 419f1000 rw-p [heap]
419f1000 41aa9000 r-xp /usr/lib/libcairo.so.2.11200.14
41ab4000 41ad5000 r-xp /usr/lib/libui-extension.so.0.1.0
41ade000 41adf000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41ae8000 41aee000 r-xp /usr/lib/libxcb-render.so.0.0.0
41af6000 41af9000 r-xp /usr/lib/libEGL.so.1.4
41b01000 41b09000 r-xp /usr/lib/libmdm-common.so.1.0.89
41b0a000 41c47000 r-xp /usr/lib/libicui18n.so.51.1
41c57000 41d3b000 r-xp /usr/lib/libicuuc.so.51.1
41d50000 41d53000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41d5b000 41d63000 r-xp /usr/lib/libdrm.so.2.4.0
432f2000 432f7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43300000 43305000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4330d000 4330f000 r-xp /usr/lib/libdri2.so.0.0.0
43317000 43338000 r-xp /usr/lib/libexif.so.12.3.3
4334b000 43350000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43358000 43422000 r-xp /usr/lib/libCOREGL.so.4.0
43765000 43770000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43779000 4377d000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43785000 4379c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
438a9000 438ab000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
438b4000 440b3000 rwxp [stack:4069]
44a8c000 4528b000 rwxp [stack:4027]
4530a000 4530b000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
beceb000 bed0c000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3697)
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
00 E/TIZEN_N_SYSTEM_SETTINGS(  732): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-12 16:55:01.853+0900 E/TIZEN_N_SYSTEM_SETTINGS(  732): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-12 16:55:01.853+0900 E/TIZEN_N_SYSTEM_SETTINGS(  732): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-12 16:55:01.853+0900 E/TIZEN_N_SYSTEM_SETTINGS(  732): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-12 16:55:01.853+0900 I/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-12 16:55:01.853+0900 I/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 119, application_id: 218, type: 13
05-12 16:55:01.853+0900 E/TIZEN_N_SYSTEM_SETTINGS(  732): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-12 16:55:01.853+0900 E/TIZEN_N_SYSTEM_SETTINGS(  732): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-12 16:55:01.853+0900 E/TIZEN_N_SYSTEM_SETTINGS(  732): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-12 16:55:01.853+0900 E/TIZEN_N_SYSTEM_SETTINGS(  732): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-12 16:55:01.858+0900 I/wnotib  (  732): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-12 16:55:01.863+0900 I/wnotib  (  732): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-12 16:55:01.868+0900 I/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 119, application_id: 218, type: 12
05-12 16:55:01.868+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1387) > Num categories: 1, num total noti: 1
05-12 16:55:01.868+0900 I/wnotib  (  732): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(871) > Free noti manager data.
05-12 16:55:01.868+0900 I/wnotib  (  732): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(876) > Free previous notifications.
05-12 16:55:01.868+0900 I/wnotib  (  732): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(897) > Free previous categories.
05-12 16:55:01.868+0900 I/wnotib  (  732): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
05-12 16:55:01.868+0900 I/wnotib  (  732): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
05-12 16:55:01.868+0900 W/wnotib  (  732): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(206) > Summary board was disabled. But receive update request
05-12 16:55:01.868+0900 I/wnotib  (  732): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
05-12 16:55:01.868+0900 I/wnotib  (  732): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1412) > num_total_panel: 1.
05-12 16:55:01.868+0900 W/W_HOME  (  732): noti_broker.c: _handler_indicator_update(562) > 0x1
05-12 16:55:01.893+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1416) > unread_count_for_home: 1
05-12 16:55:01.893+0900 W/W_HOME  (  732): noti_broker.c: _handler_noti_indicator_show(478) > 
05-12 16:55:01.928+0900 W/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-12 16:55:01.953+0900 W/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-12 16:55:02.263+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1518] swap changed from async to sync
05-12 16:55:02.663+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 16:55:02.663+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 16:55:02.663+0900 I/efl-extension(  732): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x46f639e0, elm_layout, time_stamp : 3313856
05-12 16:55:02.663+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 16:55:02.663+0900 W/APPS    (  732): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3169) >  __nIsEditMode[0], __focusPage[2], __focusIndex[19], __pAppsItemList.size[21]
05-12 16:55:02.663+0900 W/APPS    (  732): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[18]
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-12 16:55:02.803+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:55:02.803+0900 E/CAPI_APPFW_APP_CONTROL( 1163): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-12 16:55:02.803+0900 W/MUSIC_CONTROL_SERVICE( 1163): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1163]   [com.samsung.w-home]register msg port [true][0m
05-12 16:55:02.813+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:55:02.823+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 732
05-12 16:55:02.858+0900 W/MUSIC_CONTROL_SERVICE( 1163): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1163]   [MUSIC_PLAYER_EVENT][0m
05-12 16:55:02.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:55:02.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:55:02.858+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:55:02.858+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-12 16:55:02.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-12 16:55:02.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:55:02.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-12 16:55:02.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:55:02.878+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:55:02.878+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:55:02.878+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:55:02.878+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-12 16:55:02.878+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-12 16:55:02.878+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:55:02.878+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-12 16:55:02.878+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-12 16:55:02.878+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-12 16:55:02.878+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:55:02.888+0900 W/W_HOME  (  732): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-12 16:55:02.888+0900 E/W_HOME  (  732): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-12 16:55:02.888+0900 W/APPS    (  732): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-12 16:55:02.893+0900 W/MUSIC_CONTROL_SERVICE( 1163): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1163]   [MUSIC_PLAYER_EVENT][0m
05-12 16:55:02.893+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:55:02.893+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:55:02.893+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:55:02.893+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-12 16:55:02.893+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-12 16:55:02.893+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:55:02.893+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-12 16:55:02.893+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:55:02.908+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:55:02.908+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:55:02.908+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:55:02.908+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-12 16:55:02.908+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-12 16:55:02.908+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:55:02.908+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-12 16:55:02.908+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-12 16:55:02.908+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-12 16:55:02.908+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:55:02.923+0900 W/W_HOME  (  732): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-12 16:55:02.923+0900 E/W_HOME  (  732): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-12 16:55:02.928+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:55:02.928+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:55:02.928+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:55:02.928+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-12 16:55:02.928+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-12 16:55:02.928+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:55:02.928+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-12 16:55:02.928+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:55:02.943+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:55:02.943+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:55:02.943+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:55:02.943+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-12 16:55:02.943+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-12 16:55:02.943+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:55:02.943+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-12 16:55:02.943+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-12 16:55:02.943+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-12 16:55:02.943+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:55:03.258+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:03.258+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:03.258+0900 I/efl-extension(  732): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x46f639e0, elm_layout, time_stamp : 3314450
05-12 16:55:03.258+0900 W/APPS    (  732): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[18], __pAppsItemList.size[21]
05-12 16:55:03.258+0900 W/APPS    (  732): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[19]
05-12 16:55:03.258+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:03.493+0900 W/APPS    (  732): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-12 16:55:03.738+0900 I/GESTURE (  144): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-12 16:55:03.743+0900 E/EFL     (  732): evas_main<732> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3314932 button=1 downs=1
05-12 16:55:03.743+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [161, 204]
05-12 16:55:03.798+0900 E/EFL     (  732): evas_main<732> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3314986 button=1 downs=0
05-12 16:55:03.798+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [161, 204]->[164, 207]
05-12 16:55:03.798+0900 W/APPS    (  732): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-12 16:55:03.798+0900 E/APPS    (  732): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-12 16:55:03.798+0900 W/APPS    (  732): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-12 16:55:03.803+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 0
05-12 16:55:03.803+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(1702) > caller pid : 732
05-12 16:55:03.803+0900 I/AUL_AMD (  493): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-12 16:55:03.818+0900 E/RESOURCED(  494): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 2
05-12 16:55:03.818+0900 E/RESOURCED(  494): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-12 16:55:03.823+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(2080) > pad pid(-5)
05-12 16:55:03.823+0900 W/AUL_PAD ( 1132): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-12 16:55:03.823+0900 W/AUL_PAD ( 1132): launchpad.c: __send_result_to_caller(272) > Check app launching
05-12 16:55:03.858+0900 I/efl-extension( 3697): efl_extension.c: eext_mod_init(40) > Init
05-12 16:55:03.858+0900 I/UXT     ( 3697): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-12 16:55:03.868+0900 I/CAPI_APPFW_APPLICATION( 3697): app_main.c: ui_app_main(704) > app_efl_main
05-12 16:55:03.873+0900 I/CAPI_APPFW_APPLICATION( 3697): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-12 16:55:03.923+0900 E/AUL     (  493): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-12 16:55:03.933+0900 E/RESOURCED(  494): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-12 16:55:03.943+0900 E/TBM     ( 3697): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-12 16:55:04.058+0900 E/EFL     ( 3697): <3697> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-12 16:55:04.068+0900 E/EFL     ( 3697): <3697> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-12 16:55:04.068+0900 E/EFL     ( 3697): <3697> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-12 16:55:04.068+0900 E/EFL     ( 3697): <3697> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-12 16:55:04.073+0900 E/EFL     ( 3697): <3697> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-12 16:55:04.073+0900 E/EFL     ( 3697): <3697> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-12 16:55:04.148+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05e00002)
05-12 16:55:04.173+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-12 16:55:04.173+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:55:04.173+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:55:04.178+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:55:04.178+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-12 16:55:04.183+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 16:55:04.183+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 16:55:04.198+0900 I/APP_CORE( 3697): appcore-efl.c: __do_app(429) > [APP 3697] Event: RESET State: CREATED
05-12 16:55:04.198+0900 I/CAPI_APPFW_APPLICATION( 3697): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-12 16:55:04.198+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1518] swap changed from sync to async
05-12 16:55:04.228+0900 I/APP_CORE( 3697): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-12 16:55:04.228+0900 I/APP_CORE( 3697): appcore-efl.c: __do_app(474) > [APP 3697] Initial Launching, call the resume_cb
05-12 16:55:04.228+0900 I/CAPI_APPFW_APPLICATION( 3697): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-12 16:55:04.318+0900 W/APP_CORE( 3697): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
05-12 16:55:04.353+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-12 16:55:04.353+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-12 16:55:04.353+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:55:04.353+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-12 16:55:04.353+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: PAUSE State: RUNNING
05-12 16:55:04.353+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-12 16:55:04.353+0900 W/W_HOME  (  732): main.c: _appcore_pause_cb(690) > appcore pause
05-12 16:55:04.353+0900 W/W_HOME  (  732): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-12 16:55:04.353+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:55:04.353+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:55:04.353+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:55:04.353+0900 W/W_HOME  (  732): rotary.c: rotary_deattach(156) > rotary_deattach:0x46f639e0
05-12 16:55:04.353+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-12 16:55:04.353+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46f639e0, elm_layout, func : 0x4004b469
05-12 16:55:04.353+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-12 16:55:04.353+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-12 16:55:04.353+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-12 16:55:04.353+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c95f90, elm_box, _activated_obj : 0x46f639e0, activated : 1
05-12 16:55:04.353+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-12 16:55:04.353+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 16:55:04.353+0900 I/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 119, 218.
05-12 16:55:04.353+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-12 16:55:04.378+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:55:04.378+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:55:04.378+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:55:04.378+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-12 16:55:04.378+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-12 16:55:04.378+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:55:04.378+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-12 16:55:04.378+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:55:04.378+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:55:04.378+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:55:04.383+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:55:04.383+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-12 16:55:04.383+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-12 16:55:04.383+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:55:04.383+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-12 16:55:04.383+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-12 16:55:04.383+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-12 16:55:04.383+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:55:04.388+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 16:55:04.388+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 16:55:04.413+0900 I/APP_CORE( 3697): appcore-efl.c: __do_app(429) > [APP 3697] Event: RESUME State: RUNNING
05-12 16:55:04.433+0900 E/CAPI_APPFW_APP_CONTROL( 1163): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-12 16:55:04.433+0900 W/MUSIC_CONTROL_SERVICE( 1163): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1163]   [com.samsung.w-home]register msg port [false][0m
05-12 16:55:04.488+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-12 16:55:04.488+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 16:55:04.508+0900 W/APPS    (  732): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-12 16:55:04.758+0900 E/AUL     (  493): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-12 16:55:04.883+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-12 16:55:04.948+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:55:04.958+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3697
05-12 16:55:04.958+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-12 16:55:05.243+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3316434 button=1 downs=1
05-12 16:55:05.283+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3316476 button=1 downs=0
05-12 16:55:05.298+0900 D/TIMER   ( 3697): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-12 16:55:05.298+0900 D/TIMER   ( 3697): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-12 16:55:05.338+0900 D/TIMER   ( 3697): Digital create
05-12 16:55:05.348+0900 D/TIMER   ( 3697): Initialize the rotary event
05-12 16:55:05.348+0900 I/efl-extension( 3697): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-12 16:55:05.348+0900 I/efl-extension( 3697): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-12 16:55:05.348+0900 I/efl-extension( 3697): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-12 16:55:05.348+0900 I/efl-extension( 3697): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-12 16:55:05.348+0900 I/efl-extension( 3697): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x437b20f8, elm_layout, _activated_obj : 0x0, activated : 1
05-12 16:55:05.818+0900 I/AUL_PAD ( 4028): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-12 16:55:06.133+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3317323 button=1 downs=1
05-12 16:55:06.208+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3317398 button=1 downs=0
05-12 16:55:07.333+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3318526 button=1 downs=1
05-12 16:55:07.378+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3318569 button=1 downs=0
05-12 16:55:07.883+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3319074 button=1 downs=1
05-12 16:55:07.978+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3319171 button=1 downs=0
05-12 16:55:08.393+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3319584 button=1 downs=1
05-12 16:55:08.478+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3319671 button=1 downs=0
05-12 16:55:08.928+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3320118 button=1 downs=1
05-12 16:55:09.033+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3320227 button=1 downs=0
05-12 16:55:09.288+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3320481 button=1 downs=1
05-12 16:55:09.363+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3320556 button=1 downs=0
05-12 16:55:09.388+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-12 16:55:09.518+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3320708 button=1 downs=1
05-12 16:55:09.593+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3320784 button=1 downs=0
05-12 16:55:09.683+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3320875 button=1 downs=1
05-12 16:55:09.683+0900 D/TIMER   ( 3697): Minute selected
05-12 16:55:09.758+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3320951 button=1 downs=0
05-12 16:55:10.323+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 16:55:10.323+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 16:55:10.408+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.408+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.413+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.413+0900 I/efl-extension( 3697): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.413+0900 I/efl-extension( 3697): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b20f8, elm_layout, time_stamp : 3321602
05-12 16:55:10.413+0900 D/TIMER   ( 3697): Rotary callback is called
05-12 16:55:10.413+0900 E/TIMER   ( 3697): (ad->timer) -> _rotary_cb() return
05-12 16:55:10.473+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.473+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.473+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.473+0900 I/efl-extension( 3697): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.473+0900 I/efl-extension( 3697): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b20f8, elm_layout, time_stamp : 3321665
05-12 16:55:10.473+0900 D/TIMER   ( 3697): Rotary callback is called
05-12 16:55:10.473+0900 E/TIMER   ( 3697): (ad->timer) -> _rotary_cb() return
05-12 16:55:10.548+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.548+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.548+0900 I/efl-extension( 3697): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.548+0900 I/efl-extension( 3697): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b20f8, elm_layout, time_stamp : 3321739
05-12 16:55:10.548+0900 D/TIMER   ( 3697): Rotary callback is called
05-12 16:55:10.548+0900 E/TIMER   ( 3697): (ad->timer) -> _rotary_cb() return
05-12 16:55:10.548+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.733+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.738+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.738+0900 I/efl-extension( 3697): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.738+0900 I/efl-extension( 3697): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b20f8, elm_layout, time_stamp : 3321928
05-12 16:55:10.738+0900 D/TIMER   ( 3697): Rotary callback is called
05-12 16:55:10.738+0900 E/TIMER   ( 3697): (ad->timer) -> _rotary_cb() return
05-12 16:55:10.738+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.793+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.793+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.793+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.793+0900 I/efl-extension( 3697): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.793+0900 I/efl-extension( 3697): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b20f8, elm_layout, time_stamp : 3321986
05-12 16:55:10.793+0900 D/TIMER   ( 3697): Rotary callback is called
05-12 16:55:10.793+0900 E/TIMER   ( 3697): (ad->timer) -> _rotary_cb() return
05-12 16:55:10.873+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.873+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.873+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.873+0900 I/efl-extension( 3697): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.873+0900 I/efl-extension( 3697): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b20f8, elm_layout, time_stamp : 3322065
05-12 16:55:10.873+0900 D/TIMER   ( 3697): Rotary callback is called
05-12 16:55:10.873+0900 E/TIMER   ( 3697): (ad->timer) -> _rotary_cb() return
05-12 16:55:10.933+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.933+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.933+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.933+0900 I/efl-extension( 3697): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:10.933+0900 I/efl-extension( 3697): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b20f8, elm_layout, time_stamp : 3322126
05-12 16:55:10.933+0900 D/TIMER   ( 3697): Rotary callback is called
05-12 16:55:10.933+0900 E/TIMER   ( 3697): (ad->timer) -> _rotary_cb() return
05-12 16:55:12.088+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3323280 button=1 downs=1
05-12 16:55:12.133+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3323327 button=1 downs=0
05-12 16:55:12.133+0900 D/TIMER   ( 3697): Start clicked
05-12 16:55:12.133+0900 E/EFL     ( 3697): ecore<3697> ecore.c:574 _ecore_magic_fail() 
05-12 16:55:12.133+0900 E/EFL     ( 3697): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-12 16:55:12.133+0900 E/EFL     ( 3697): *** IN FUNCTION: ecore_timer_del()
05-12 16:55:12.133+0900 E/EFL     ( 3697): ecore<3697> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-12 16:55:12.133+0900 E/EFL     ( 3697):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-12 16:55:12.133+0900 E/EFL     ( 3697):     Supplied: 0049a1bd - <UNKNOWN>
05-12 16:55:12.133+0900 E/EFL     ( 3697): ecore<3697> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-12 16:55:12.133+0900 E/EFL     ( 3697): *** SPANK SPANK SPANK!!!
05-12 16:55:12.133+0900 E/EFL     ( 3697): *** Now go fix your code. Tut tut tut!
05-12 16:55:12.138+0900 I/SOCKETTEST( 3697): Success to create socket
05-12 16:55:12.138+0900 I/SOCKETTEST( 3697): socket connect error: Network is unreachable
05-12 16:55:12.138+0900 I/SOCKETTEST( 3697): write() error: Bad file descriptor
05-12 16:55:12.553+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.553+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.553+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.558+0900 I/efl-extension( 3697): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.558+0900 I/efl-extension( 3697): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b20f8, elm_layout, time_stamp : 3323746
05-12 16:55:12.558+0900 D/TIMER   ( 3697): Rotary callback is called
05-12 16:55:12.558+0900 D/TIMER   ( 3697): Detent detected, obj[0x437b20f8], direction[0], time_stamp[3323746]
05-12 16:55:12.558+0900 D/TIMER   ( 3697): Pre change num: 00
05-12 16:55:12.558+0900 D/TIMER   ( 3697): Post change num: 0
05-12 16:55:12.663+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.663+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.663+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.663+0900 I/efl-extension( 3697): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.663+0900 I/efl-extension( 3697): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b20f8, elm_layout, time_stamp : 3323853
05-12 16:55:12.663+0900 D/TIMER   ( 3697): Rotary callback is called
05-12 16:55:12.663+0900 D/TIMER   ( 3697): Detent detected, obj[0x437b20f8], direction[0], time_stamp[3323853]
05-12 16:55:12.663+0900 D/TIMER   ( 3697): Pre change num: 1
05-12 16:55:12.663+0900 D/TIMER   ( 3697): Post change num: 1
05-12 16:55:12.728+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.728+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.733+0900 I/efl-extension( 3697): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:12.733+0900 I/efl-extension( 3697): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x437b20f8, elm_layout, time_stamp : 3323922
05-12 16:55:12.733+0900 D/TIMER   ( 3697): Rotary callback is called
05-12 16:55:12.733+0900 D/TIMER   ( 3697): Detent detected, obj[0x437b20f8], direction[0], time_stamp[3323922]
05-12 16:55:12.733+0900 D/TIMER   ( 3697): Pre change num: 2
05-12 16:55:12.733+0900 D/TIMER   ( 3697): Post change num: 2
05-12 16:55:12.738+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:55:13.548+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3324739 button=1 downs=1
05-12 16:55:13.573+0900 E/EFL     ( 3697): evas_main<3697> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3324765 button=1 downs=0
05-12 16:55:13.573+0900 D/TIMER   ( 3697): Start clicked
05-12 16:55:13.573+0900 D/TIMER   ( 3697): Setting time is 180
05-12 16:55:13.668+0900 I/SENSOR  ( 3697): Sensor is Started
05-12 16:55:13.668+0900 I/SOCKETTEST( 3697): Success to create socket
05-12 16:55:13.668+0900 I/SOCKETTEST( 3697): socket connect error: Network is unreachable
05-12 16:55:13.668+0900 I/SOCKETTEST( 3697): write() error: Bad file descriptor
05-12 16:55:13.668+0900 D/TIMER   ( 3697): Start clicked
05-12 16:55:13.723+0900 I/SENSOR  ( 3697): -10.150000, 0.350000, 2.100000
05-12 16:55:13.823+0900 I/SENSOR  ( 3697): -9.310000, -4.200000, 6.720000
05-12 16:55:13.923+0900 I/SENSOR  ( 3697): -5.390000, -4.620000, 4.970000
05-12 16:55:14.023+0900 I/SENSOR  ( 3697): -0.280000, -2.450000, 2.030000
05-12 16:55:14.123+0900 I/SENSOR  ( 3697): -11.410000, -6.020000, 6.020000
05-12 16:55:14.233+0900 I/SENSOR  ( 3697): 0.490000, -14.070000, -5.040000
05-12 16:55:14.328+0900 I/SENSOR  ( 3697): 4.760000, -30.870001, -30.799999
05-12 16:55:14.428+0900 I/SENSOR  ( 3697): 29.260000, -73.849998, -84.840004
05-12 16:55:14.523+0900 I/SENSOR  ( 3697): 2.170000, -33.740002, -27.160000
05-12 16:55:14.628+0900 I/SENSOR  ( 3697): -2.590000, -38.430000, -12.110000
05-12 16:55:14.673+0900 D/TIMER   ( 3697): Timer is start
05-12 16:55:14.673+0900 D/TIMER   ( 3697): Remind time: 180
05-12 16:55:14.773+0900 I/SENSOR  ( 3697): 5.460000, 2.590000, 52.990002
05-12 16:55:14.863+0900 I/SENSOR  ( 3697): -24.639999, 43.259998, 66.220001
05-12 16:55:14.943+0900 I/SENSOR  ( 3697): -37.240002, 27.370001, 46.130001
05-12 16:55:15.038+0900 I/SENSOR  ( 3697): -24.570000, 6.720000, 28.000000
05-12 16:55:15.138+0900 I/SENSOR  ( 3697): -11.340000, 10.570000, 19.809999
05-12 16:55:15.208+0900 I/efl-extension( 3697): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x437b20f8
05-12 16:55:15.208+0900 I/efl-extension( 3697): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x437b20f8, obj: 0x437b20f8
05-12 16:55:15.208+0900 I/efl-extension( 3697): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-12 16:55:15.223+0900 I/SENSOR  ( 3697): -8.260000, 1.820000, 13.930000
05-12 16:55:15.328+0900 I/SENSOR  ( 3697): -1.190000, 4.270000, 17.290001
05-12 16:55:15.428+0900 I/SENSOR  ( 3697): -8.820000, 3.290000, 16.100000
05-12 16:55:15.528+0900 I/SENSOR  ( 3697): -5.180000, 4.060000, 15.400000
05-12 16:55:15.628+0900 I/SENSOR  ( 3697): -4.200000, -1.890000, 8.960000
05-12 16:55:15.673+0900 D/TIMER   ( 3697): Timer is start
05-12 16:55:15.673+0900 D/TIMER   ( 3697): Remind time: 179
05-12 16:55:15.673+0900 F/EFL     ( 3697): evas_main<3697> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
05-12 16:55:15.948+0900 W/CRASH_MANAGER( 4004): worker.c: worker_job(1199) > 1103697706831146303971
