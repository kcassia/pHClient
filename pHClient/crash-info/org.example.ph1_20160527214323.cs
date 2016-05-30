S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 20893
Date: 2016-05-27 21:43:23+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x4387c858, r5   = 0x41461fb9
r6   = 0x4387d158, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x4387bad8
r10  = 0x41be4468, fp   = 0x00000000
ip   = 0x4143b490, sp   = 0xbeaf5630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     30948 KB
Buffers:     43216 KB
Cached:     140020 KB
VmPeak:      92508 KB
VmSize:      86384 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20104 KB
VmRSS:       17928 KB
VmData:      33104 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22996 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20893 TID = 20893
20893 20974 

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
419e8000 419eb000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
419f3000 419fb000 r-xp /usr/lib/libdrm.so.2.4.0
41a03000 41a08000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41a11000 41a16000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41a1e000 41a20000 r-xp /usr/lib/libdri2.so.0.0.0
41a28000 41a49000 r-xp /usr/lib/libexif.so.12.3.3
41a5c000 41a61000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41a7d000 41a81000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41aba000 41bec000 rw-p [heap]
41bec000 41d29000 r-xp /usr/lib/libicui18n.so.51.1
41d39000 41e1d000 r-xp /usr/lib/libicuuc.so.51.1
433b9000 43483000 r-xp /usr/lib/libCOREGL.so.4.0
44b94000 45393000 rwxp [stack:20974]
bead5000 beaf6000 rwxp [stack]
End of Maps Information

Callstack Information (PID:20893)
Call Stack Count: 2
 0: cfree + 0xc8 (0x404e41e8) [/lib/libc.so.6] + 0x6f1e8
 1: (0x20) (null)
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
21:43:19.294+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 21:43:19.299+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:19.299+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:19.324+0900 I/APP_CORE(20893): appcore-efl.c: __do_app(429) > [APP 20893] Event: PAUSE State: RUNNING
05-27 21:43:19.324+0900 I/CAPI_APPFW_APPLICATION(20893): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-27 21:43:19.344+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 21:43:19.344+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:19.344+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:19.349+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:19.349+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 21:43:19.349+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4469) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-27 21:43:19.349+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 21:43:19.349+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 21:43:19.349+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:19.349+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 21:43:19.349+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: RUNNING
05-27 21:43:19.349+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 21:43:19.349+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 21:43:19.349+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 21:43:19.364+0900 W/W_HOME  (  732): event_manager.c: _home_scroll_cb(564) > scroll,done
05-27 21:43:19.459+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:19.459+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:19.649+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:19.649+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:19.724+0900 W/W_HOME  (  732): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
05-27 21:43:19.799+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 21:43:19.839+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:19.839+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:20.034+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:20.034+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-27 21:43:20.214+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:43:20.214+0900 E/CAPI_APPFW_APP_CONTROL( 1241): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-27 21:43:20.214+0900 W/MUSIC_CONTROL_SERVICE( 1241): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1241]   [com.samsung.w-home]register msg port [true][0m
05-27 21:43:20.219+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 21:43:20.219+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 732
05-27 21:43:20.224+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:20.224+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:20.229+0900 W/MUSIC_CONTROL_SERVICE( 1241): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1241]   [MUSIC_PLAYER_EVENT][0m
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-27 21:43:20.229+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:43:20.234+0900 W/MUSIC_CONTROL_SERVICE( 1241): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1241]   [MUSIC_PLAYER_EVENT][0m
05-27 21:43:20.234+0900 W/W_HOME  (  732): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-27 21:43:20.234+0900 E/W_HOME  (  732): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:43:20.234+0900 W/W_HOME  (  732): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-27 21:43:20.234+0900 E/W_HOME  (  732): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-27 21:43:20.234+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:43:20.249+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-27 21:43:20.249+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-27 21:43:20.249+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-27 21:43:20.249+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-27 21:43:20.319+0900 W/STARTER (  711): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-27 21:43:20.404+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-27 21:43:20.404+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-27 21:43:20.404+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-27 21:43:20.404+0900 W/STARTER (  711): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-27 21:43:20.419+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:20.419+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:20.514+0900 W/STARTER (  711): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-27 21:43:20.614+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:20.614+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:20.764+0900 W/STARTER (  711): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-27 21:43:20.769+0900 W/STARTER (  711): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-27 21:43:20.779+0900 E/STARTER (  711): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-27 21:43:20.784+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 0
05-27 21:43:20.814+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:20.814+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:20.814+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 711
05-27 21:43:20.824+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(2080) > pad pid(-5)
05-27 21:43:20.824+0900 W/AUL_PAD ( 1171): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-27 21:43:20.824+0900 W/AUL_PAD ( 1171): launchpad.c: __send_result_to_caller(272) > Check app launching
05-27 21:43:20.824+0900 E/RESOURCED(  493): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-27 21:43:20.839+0900 I/CAPI_APPFW_APPLICATION(20360): app_main.c: app_efl_main(129) > app_efl_main
05-27 21:43:20.844+0900 I/CAPI_APPFW_APPLICATION(20360): app_main.c: app_appcore_create(152) > app_appcore_create
05-27 21:43:20.929+0900 E/AUL     (  711): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 21:43:20.929+0900 E/RESOURCED(  493): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-27 21:43:21.009+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:21.009+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:21.029+0900 I/efl-extension(20360): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445d7e88 = w: 0 h: 0  obj 0x445bf178 w: 360 h: 360
05-27 21:43:21.029+0900 I/efl-extension(20360): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-27 21:43:21.039+0900 I/efl-extension(20360): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-27 21:43:21.039+0900 I/efl-extension(20360): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-27 21:43:21.039+0900 I/efl-extension(20360): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-27 21:43:21.044+0900 I/efl-extension(20360): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-27 21:43:21.049+0900 I/efl-extension(20360): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445bf178, elm_image, _activated_obj : 0x0, activated : 1
05-27 21:43:21.159+0900 E/W_TASKMANAGER(20360): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-27 21:43:21.164+0900 E/W_TASKMANAGER(20360): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-27 21:43:21.164+0900 E/W_TASKMANAGER(20360): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-27 21:43:21.204+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.204+0900 E/W_TASKMANAGER(20360): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-27 21:43:21.209+0900 E/RUA     (20360): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 17, ncols : 5
05-27 21:43:21.209+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:21.209+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:21.239+0900 E/EFL     (20360): elementary<20360> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c0df8 into part 'elm.swallow.event.0'
05-27 21:43:21.289+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04400003)
05-27 21:43:21.289+0900 I/APP_CORE(20360): appcore-efl.c: __do_app(429) > [APP 20360] Event: RESET State: CREATED
05-27 21:43:21.294+0900 I/CAPI_APPFW_APPLICATION(20360): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-27 21:43:21.304+0900 I/APP_CORE(20360): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-27 21:43:21.304+0900 I/APP_CORE(20360): appcore-efl.c: __do_app(474) > [APP 20360] Initial Launching, call the resume_cb
05-27 21:43:21.304+0900 I/CAPI_APPFW_APPLICATION(20360): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 21:43:21.324+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-27 21:43:21.324+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:21.324+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:21.324+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:21.324+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-27 21:43:21.324+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-27 21:43:21.329+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04400003)
05-27 21:43:21.359+0900 W/APP_CORE(20360): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4400003
05-27 21:43:21.409+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:21.409+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:21.429+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-27 21:43:21.429+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-27 21:43:21.429+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:21.429+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-27 21:43:21.429+0900 I/APP_CORE(20360): appcore-efl.c: __do_app(429) > [APP 20360] Event: RESUME State: RUNNING
05-27 21:43:21.434+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: PAUSE State: RUNNING
05-27 21:43:21.434+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 21:43:21.434+0900 W/W_HOME  (  732): main.c: _appcore_pause_cb(690) > appcore pause
05-27 21:43:21.434+0900 W/W_HOME  (  732): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-27 21:43:21.434+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:21.434+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:21.434+0900 W/W_HOME  (  732): main.c: home_pause(751) > clock/widget paused
05-27 21:43:21.434+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:21.439+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:43:21.439+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:43:21.439+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:43:21.439+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-27 21:43:21.439+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-27 21:43:21.439+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:43:21.439+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-27 21:43:21.439+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:43:21.444+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 21:43:21.444+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 21:43:21.444+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 21:43:21.444+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 21:43:21.444+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 21:43:21.444+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-27 21:43:21.444+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-27 21:43:21.444+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 21:43:21.444+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-27 21:43:21.449+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-27 21:43:21.449+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-27 21:43:21.449+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 21:43:21.459+0900 E/CAPI_APPFW_APP_CONTROL( 1241): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-27 21:43:21.459+0900 W/MUSIC_CONTROL_SERVICE( 1241): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1241]   [com.samsung.w-home]register msg port [false][0m
05-27 21:43:21.524+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-27 21:43:21.529+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 21:43:21.529+0900 W/WATCH_CORE(  762): appcore-watch.c: __widget_pause(1001) > widget_pause
05-27 21:43:21.529+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppPause(713) > 
05-27 21:43:21.529+0900 E/watchface-viewer(  762): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-27 21:43:21.529+0900 E/watchface-viewer(  762): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-27 21:43:21.529+0900 E/watchface-viewer(  762): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-27 21:43:21.529+0900 E/watchface-viewer(  762): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-27 21:43:21.529+0900 E/watchface-viewer(  762): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-27 21:43:21.839+0900 E/AUL     (  492): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 21:43:21.874+0900 E/EFL     (20360): evas_main<20360> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9078859 button=1 downs=1
05-27 21:43:21.879+0900 I/MALI    (20360): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-27 21:43:21.924+0900 E/EFL     (20360): evas_main<20360> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9078921 button=1 downs=0
05-27 21:43:21.954+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-27 21:43:21.964+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 21:43:21.984+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20360
05-27 21:43:21.984+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 21:43:22.174+0900 E/EFL     (20360): elementary<20360> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573db0), freeze(1)
05-27 21:43:22.174+0900 E/EFL     (20360): elementary<20360> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573db0), freeze(1)
05-27 21:43:22.394+0900 I/efl-extension(21124): efl_extension.c: eext_mod_init(40) > Init
05-27 21:43:22.444+0900 I/UXT     (21124): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-27 21:43:22.489+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 21:43:22.489+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 21:43:22.489+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 21:43:22.489+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 21:43:22.489+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 21:43:22.519+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-27 21:43:22.519+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-27 21:43:22.519+0900 W/W_HOME  (  732): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-27 21:43:22.519+0900 W/W_HOME  (  732): gesture.c: _manual_render_enable(133) > 1
05-27 21:43:22.519+0900 W/W_HOME  (  732): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-27 21:43:22.519+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:22.519+0900 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
05-27 21:43:22.519+0900 W/STARTER (  711): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-27 21:43:22.519+0900 E/STARTER (  711): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-27 21:43:22.519+0900 W/STARTER (  711): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-27 21:43:22.519+0900 W/STARTER (  711): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-27 21:43:22.529+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-27 21:43:22.529+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-27 21:43:22.529+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-27 21:43:22.534+0900 I/TIZEN_N_SOUND_MANAGER( 1132): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-27 21:43:22.539+0900 I/TIZEN_N_SOUND_MANAGER( 1132): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-27 21:43:22.539+0900 W/TIZEN_N_SOUND_MANAGER( 1132): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-27 21:43:22.539+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-27 21:43:22.539+0900 I/HIGEAR  ( 1132): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-27 21:43:22.674+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 21:43:22.674+0900 W/MUSIC_CONTROL_SERVICE( 1241): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1241]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-27 21:43:22.679+0900 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
05-27 21:43:22.679+0900 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-27 21:43:22.679+0900 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-27 21:43:22.679+0900 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-27 21:43:22.709+0900 E/ALARM_MANAGER(  711): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(27-5-2016, 21:43:43), repeat(1), interval(20), type(-1073741822)
05-27 21:43:22.719+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-27 21:43:22.719+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-27 21:43:22.724+0900 I/SHealth_Common( 1061): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-27 21:43:22.724+0900 I/SHealth_Service( 1061): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-27 21:43:22.729+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20893
05-27 21:43:22.729+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 27
05-27 21:43:22.759+0900 I/APP_CORE(20893): appcore-efl.c: __do_app(429) > [APP 20893] Event: TERMINATE State: PAUSED
05-27 21:43:22.759+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 21:43:22.759+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 21:43:22.779+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 21:43:22.779+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 21:43:22.779+0900 E/APP_CORE(20360): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-27 21:43:22.779+0900 I/APP_CORE(20360): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 21:43:22.779+0900 I/APP_CORE(20360): appcore-efl.c: __after_loop(1090) > [APP 20360] PAUSE before termination
05-27 21:43:22.779+0900 I/CAPI_APPFW_APPLICATION(20360): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 21:43:22.779+0900 I/CAPI_APPFW_APPLICATION(20360): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-27 21:43:22.784+0900 I/efl-extension(20360): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44573db0, obj: 0x44573db0
05-27 21:43:22.784+0900 I/efl-extension(20360): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 21:43:22.784+0900 I/efl-extension(20360): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 21:43:22.784+0900 I/efl-extension(20360): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 21:43:22.784+0900 I/efl-extension(20360): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 21:43:22.794+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 989523903, next duetime: 1464353023
05-27 21:43:22.794+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(989523903)
05-27 21:43:22.794+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464353447), due_time(1464353023)
05-27 21:43:22.794+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 21:43:22.794+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 12:43:43 (UTC).
05-27 21:43:22.794+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 21:43:22.799+0900 I/efl-extension(20360): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445bf178
05-27 21:43:22.799+0900 I/efl-extension(20360): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 21:43:22.799+0900 I/efl-extension(20360): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445d7e88 is freed
05-27 21:43:22.799+0900 I/efl-extension(20360): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 21:43:22.799+0900 I/efl-extension(20360): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44573db0, elm_scroller, func : 0x437c8ef1
05-27 21:43:22.799+0900 I/efl-extension(20360): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 21:43:22.799+0900 I/efl-extension(20360): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 21:43:22.799+0900 I/efl-extension(20360): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445bf178, elm_image, func : 0x437c8ef1
05-27 21:43:22.799+0900 I/efl-extension(20360): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 21:43:22.799+0900 I/efl-extension(20360): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44573db0 : elm_scroller] rotary callabck is deleted
05-27 21:43:22.814+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 21:43:22.814+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 21:43:22.829+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-27 21:43:22.874+0900 I/AUL_PAD (21124): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-27 21:43:22.889+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 21:43:22.889+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:22.889+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:22.889+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:22.889+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 21:43:22.894+0900 I/MALI    (20360): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-27 21:43:22.919+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 21:43:22.919+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 21:43:22.919+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 21:43:22.919+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 21:43:22.919+0900 I/APP_CORE(  732): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-27 21:43:22.919+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 21:43:22.919+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 21:43:22.919+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 21:43:22.924+0900 I/MALI    (20360): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-27 21:43:22.924+0900 I/MALI    (20360): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=20360   close drm_fd=22 
05-27 21:43:22.924+0900 I/MALI    (20360): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-27 21:43:22.939+0900 I/APP_CORE(20360): appcore-efl.c: __do_app(429) > [APP 20360] Event: PAUSE State: DYING
05-27 21:43:22.939+0900 E/APP_CORE(20360): appcore-efl.c: __do_app(446) > Skip the event in dying state
05-27 21:43:22.979+0900 I/UXT     (20360): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 21:43:22.989+0900 I/APP_CORE(20893): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 21:43:22.989+0900 I/CAPI_APPFW_APPLICATION(20893): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 21:43:23.014+0900 I/efl-extension(20893): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x438520a0
05-27 21:43:23.014+0900 I/efl-extension(20893): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x438520a0, obj: 0x438520a0
05-27 21:43:23.019+0900 I/efl-extension(20893): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 21:43:23.019+0900 I/efl-extension(20893): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 21:43:23.019+0900 I/efl-extension(20893): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 21:43:23.019+0900 I/efl-extension(20893): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 21:43:23.019+0900 E/TBM     (21124): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-27 21:43:23.059+0900 I/UXT     (20893): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 21:43:23.234+0900 I/efl-extension(20360): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-27 21:43:23.239+0900 I/RESOURCED(  493): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-27 21:43:23.239+0900 I/RESOURCED(  493): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-27 21:43:23.404+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 21:43:23.529+0900 I/AUL_AMD (  492): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 20360
05-27 21:43:23.604+0900 I/AUL_AMD (  492): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 20893
05-27 21:43:23.664+0900 W/CRASH_MANAGER(21131): worker.c: worker_job(1199) > 1120893706831146435300
