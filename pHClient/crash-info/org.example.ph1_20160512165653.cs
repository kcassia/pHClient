S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 4028
Date: 2016-05-12 16:56:53+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x652f2f72

Register Information
r0   = 0x00000000, r1   = 0x41431708
r2   = 0x41431700, r3   = 0x00000000
r4   = 0x78652e67, r5   = 0x6c706d61
r6   = 0x68702e65, r7   = 0x65722f31
r8   = 0x4186e610, r9   = 0x4186e190
r10  = 0x41885808, fp   = 0x00000000
ip   = 0x4142def4, sp   = 0xbeedf658
lr   = 0x400953f8, pc   = 0x652f2f72
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     42996 KB
Buffers:     27384 KB
Cached:     122648 KB
VmPeak:      91256 KB
VmSize:      86124 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19824 KB
VmRSS:       17772 KB
VmData:      32936 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22964 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4028 TID = 4028
4028 4186 

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
44ba3000 453a2000 rwxp [stack:4186]
beebf000 beee0000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4028)
Call Stack Count: 1
 0: (0x652f2f72) (null)
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
essage(291) > _MessagePortService::SendMessage
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-12 16:56:16.858+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:56:16.858+0900 W/W_HOME  (  732): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-12 16:56:16.858+0900 E/W_HOME  (  732): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-12 16:56:16.863+0900 W/W_HOME  (  732): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-12 16:56:16.863+0900 E/W_HOME  (  732): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-12 16:56:16.998+0900 W/W_HOME  (  732): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-12 16:56:16.998+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-12 16:56:16.998+0900 W/W_HOME  (  732): rotary.c: rotary_deattach(156) > rotary_deattach:0x47b24b50
05-12 16:56:16.998+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-12 16:56:16.998+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47b24b50, elm_layout, func : 0x4004b469
05-12 16:56:16.998+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-12 16:56:16.998+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-12 16:56:16.998+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-12 16:56:16.998+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c95f90, elm_box, _activated_obj : 0x47b24b50, activated : 1
05-12 16:56:16.998+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-12 16:56:16.998+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 16:56:16.998+0900 I/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 119, 218.
05-12 16:56:16.998+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-12 16:56:16.998+0900 W/W_HOME  (  732): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-12 16:56:16.998+0900 W/W_HOME  (  732): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-12 16:56:16.998+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:16.998+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:16.998+0900 W/W_HOME  (  732): main.c: home_pause(751) > clock/widget paused
05-12 16:56:16.998+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:16.998+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 16:56:16.998+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x46f639e0
05-12 16:56:16.998+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46f639e0, elm_layout, _activated_obj : 0x45c95f90, activated : 1
05-12 16:56:16.998+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-12 16:56:16.998+0900 W/W_HOME  (  732): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-12 16:56:16.998+0900 W/W_HOME  (  732): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-12 16:56:16.998+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-12 16:56:16.998+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 16:56:16.998+0900 I/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_close_second_depth_view(5438) > wnotib_action_drawer_hidden_get(): 1, page_popup: 0x0
05-12 16:56:16.998+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4494) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 16:56:16.998+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 16:56:16.998+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_is_available(4795) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 16:56:16.998+0900 I/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-12 16:56:16.998+0900 E/APPS    (  732): apps_main.c: apps_main_resume(621) >  resumed already
05-12 16:56:17.003+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 16:56:17.003+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 16:56:17.003+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 16:56:17.003+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 16:56:17.178+0900 W/W_HOME  (  732): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-12 16:56:17.383+0900 I/GESTURE (  144): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-12 16:56:17.398+0900 E/EFL     (  732): evas_main<732> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3388579 button=1 downs=1
05-12 16:56:17.398+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [163, 187]
05-12 16:56:17.438+0900 E/EFL     (  732): evas_main<732> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3388631 button=1 downs=0
05-12 16:56:17.438+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [163, 187]->[163, 193]
05-12 16:56:17.443+0900 W/APPS    (  732): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-12 16:56:17.443+0900 E/APPS    (  732): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-12 16:56:17.443+0900 W/APPS    (  732): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-12 16:56:17.448+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 0
05-12 16:56:17.448+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(1702) > caller pid : 732
05-12 16:56:17.448+0900 I/AUL_AMD (  493): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-12 16:56:17.458+0900 E/RESOURCED(  494): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 2
05-12 16:56:17.458+0900 E/RESOURCED(  494): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-12 16:56:17.463+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(2080) > pad pid(-5)
05-12 16:56:17.463+0900 W/AUL_PAD ( 1132): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-12 16:56:17.463+0900 W/AUL_PAD ( 1132): launchpad.c: __send_result_to_caller(272) > Check app launching
05-12 16:56:17.498+0900 I/efl-extension( 4028): efl_extension.c: eext_mod_init(40) > Init
05-12 16:56:17.498+0900 I/UXT     ( 4028): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-12 16:56:17.508+0900 I/CAPI_APPFW_APPLICATION( 4028): app_main.c: ui_app_main(704) > app_efl_main
05-12 16:56:17.513+0900 I/CAPI_APPFW_APPLICATION( 4028): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-12 16:56:17.558+0900 E/TBM     ( 4028): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-12 16:56:17.563+0900 E/AUL     (  493): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-12 16:56:17.563+0900 E/RESOURCED(  494): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-12 16:56:17.618+0900 E/EFL     ( 4028): <4028> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-12 16:56:17.623+0900 E/EFL     ( 4028): <4028> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-12 16:56:17.623+0900 E/EFL     ( 4028): <4028> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-12 16:56:17.623+0900 E/EFL     ( 4028): <4028> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-12 16:56:17.628+0900 E/EFL     ( 4028): <4028> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-12 16:56:17.628+0900 E/EFL     ( 4028): <4028> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-12 16:56:17.668+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x02e00002)
05-12 16:56:17.708+0900 I/APP_CORE( 4028): appcore-efl.c: __do_app(429) > [APP 4028] Event: RESET State: CREATED
05-12 16:56:17.708+0900 I/CAPI_APPFW_APPLICATION( 4028): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-12 16:56:17.718+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1518] swap changed from sync to async
05-12 16:56:17.718+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-12 16:56:17.718+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:17.718+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:17.718+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:17.718+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-12 16:56:17.723+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 16:56:17.723+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 16:56:17.728+0900 I/APP_CORE( 4028): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-12 16:56:17.728+0900 I/APP_CORE( 4028): appcore-efl.c: __do_app(474) > [APP 4028] Initial Launching, call the resume_cb
05-12 16:56:17.728+0900 I/CAPI_APPFW_APPLICATION( 4028): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-12 16:56:17.793+0900 W/APP_CORE( 4028): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00002
05-12 16:56:17.883+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-12 16:56:17.883+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-12 16:56:17.888+0900 I/APP_CORE( 4028): appcore-efl.c: __do_app(429) > [APP 4028] Event: RESUME State: RUNNING
05-12 16:56:17.893+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-12 16:56:17.893+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-12 16:56:17.893+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:17.893+0900 W/W_HOME  (  732): event_manager.c: _state_control(333) > appcore paused manually
05-12 16:56:17.893+0900 W/W_HOME  (  732): main.c: home_appcore_pause(717) > Home Appcore Paused
05-12 16:56:17.893+0900 W/W_HOME  (  732): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-12 16:56:17.893+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:17.893+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:17.893+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:17.893+0900 W/W_HOME  (  732): rotary.c: rotary_deattach(156) > rotary_deattach:0x46f639e0
05-12 16:56:17.893+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-12 16:56:17.893+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46f639e0, elm_layout, func : 0x4004b469
05-12 16:56:17.893+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-12 16:56:17.893+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-12 16:56:17.893+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-12 16:56:17.893+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c95f90, elm_box, _activated_obj : 0x46f639e0, activated : 1
05-12 16:56:17.893+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-12 16:56:17.893+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 16:56:17.893+0900 I/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 119, 218.
05-12 16:56:17.893+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-12 16:56:17.898+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:56:17.898+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:56:17.898+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:56:17.898+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-12 16:56:17.898+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-12 16:56:17.898+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:56:17.898+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-12 16:56:17.898+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:56:17.903+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 16:56:17.903+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 16:56:17.903+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 16:56:17.903+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-12 16:56:17.903+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-12 16:56:17.903+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 16:56:17.903+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-12 16:56:17.903+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-12 16:56:17.903+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-12 16:56:17.903+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 16:56:17.903+0900 E/CAPI_APPFW_APP_CONTROL( 1163): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-12 16:56:17.903+0900 W/MUSIC_CONTROL_SERVICE( 1163): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1163]   [com.samsung.w-home]register msg port [false][0m
05-12 16:56:17.903+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-12 16:56:17.903+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 16:56:17.903+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 16:56:17.903+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: PAUSE State: RUNNING
05-12 16:56:17.903+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-12 16:56:17.903+0900 W/W_HOME  (  732): main.c: _appcore_pause_cb(690) > appcore pause
05-12 16:56:17.903+0900 E/W_HOME  (  732): main.c: _pause_cb(668) > paused already
05-12 16:56:17.963+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-12 16:56:17.963+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 16:56:17.978+0900 W/APPS    (  732): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-12 16:56:18.273+0900 E/AUL     (  493): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-12 16:56:18.403+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-12 16:56:18.493+0900 E/EFL     ( 4028): evas_main<4028> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3389687 button=1 downs=1
05-12 16:56:18.533+0900 E/EFL     ( 4028): evas_main<4028> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3389728 button=1 downs=0
05-12 16:56:18.553+0900 D/TIMER   ( 4028): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-12 16:56:18.553+0900 D/TIMER   ( 4028): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-12 16:56:18.618+0900 D/TIMER   ( 4028): Digital create
05-12 16:56:18.633+0900 D/TIMER   ( 4028): Initialize the rotary event
05-12 16:56:18.633+0900 I/efl-extension( 4028): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-12 16:56:18.633+0900 I/efl-extension( 4028): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-12 16:56:18.633+0900 I/efl-extension( 4028): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-12 16:56:18.638+0900 I/efl-extension( 4028): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-12 16:56:18.638+0900 I/efl-extension( 4028): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4189b470, elm_layout, _activated_obj : 0x0, activated : 1
05-12 16:56:18.653+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:56:18.658+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4028
05-12 16:56:18.663+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-12 16:56:18.888+0900 I/AUL_PAD ( 4187): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-12 16:56:19.763+0900 E/EFL     ( 4028): evas_main<4028> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3390952 button=1 downs=1
05-12 16:56:19.763+0900 D/TIMER   ( 4028): Hour selected
05-12 16:56:19.793+0900 E/EFL     ( 4028): evas_main<4028> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3390988 button=1 downs=0
05-12 16:56:20.448+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.448+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.448+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3391641
05-12 16:56:20.448+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:20.448+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:20.453+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.493+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.493+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.493+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3391684
05-12 16:56:20.493+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:20.493+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:20.493+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.538+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.538+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.538+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3391730
05-12 16:56:20.538+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:20.538+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:20.538+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.613+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.613+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.613+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3391804
05-12 16:56:20.613+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:20.613+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:20.613+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.683+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.683+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.683+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3391875
05-12 16:56:20.683+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:20.683+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:20.683+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.738+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.738+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.738+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3391929
05-12 16:56:20.738+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:20.738+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:20.738+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.793+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.793+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.793+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3391987
05-12 16:56:20.793+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:20.793+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:20.793+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.898+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.903+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:20.903+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3392093
05-12 16:56:20.903+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:20.903+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:20.903+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.273+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.273+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.273+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3392462
05-12 16:56:21.273+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:21.273+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:21.273+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.323+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.323+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.323+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3392515
05-12 16:56:21.323+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:21.323+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:21.323+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.368+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.368+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.368+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3392561
05-12 16:56:21.368+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:21.368+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:21.368+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.983+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.988+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:21.988+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3393178
05-12 16:56:21.988+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:21.988+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:21.988+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:22.058+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:22.058+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:22.058+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3393253
05-12 16:56:22.058+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:22.058+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:22.058+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:22.158+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:22.163+0900 I/efl-extension( 4028): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:22.163+0900 I/efl-extension( 4028): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4189b470, elm_layout, time_stamp : 3393353
05-12 16:56:22.163+0900 D/TIMER   ( 4028): Rotary callback is called
05-12 16:56:22.163+0900 E/TIMER   ( 4028): (ad->timer) -> _rotary_cb() return
05-12 16:56:22.163+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:56:22.903+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-12 16:56:24.228+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 16:56:24.228+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 16:56:24.763+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 16:56:24.763+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 16:56:27.118+0900 E/WMS     (  485): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-12 16:56:27.123+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-12 16:56:27.123+0900 E/WMS     (  485): ==========
05-12 16:56:27.123+0900 E/WMS     (  485): ##WMS SEND : mgr_gear_wear_onoff_req
05-12 16:56:27.123+0900 E/WMS     (  485): ==========
05-12 16:56:27.123+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-12 16:56:27.208+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-12 16:56:27.208+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-12 16:56:27.208+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-12 16:56:27.213+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [63 / 63] bytes. 
05-12 16:56:30.628+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 84 -> 83 1463039790 120
05-12 16:56:30.633+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 83 1962 374 2714
05-12 16:56:30.633+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 83 0 0 3239
05-12 16:56:30.633+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 83 1554 636 2150
05-12 16:56:30.633+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 83 210 5 291
05-12 16:56:30.633+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 83 659 16 912
05-12 16:56:45.058+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 16:56:52.563+0900 E/PKGMGR_SERVER( 4251): pkgmgr-server.c: main(2131) > package manager server start
05-12 16:56:52.648+0900 E/PKGMGR_SERVER( 4251): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_-2142338899], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[IzleVvHL3ay576qEKaRbpeD5GUg=], backend_flag=[0]
05-12 16:56:52.658+0900 E/PKGMGR_SERVER( 4253): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-12 16:56:52.658+0900 E/PKGMGR  ( 4245): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-12 16:56:52.723+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:56:52.733+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4028
05-12 16:56:52.733+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-12 16:56:52.738+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 5
05-12 16:56:52.738+0900 I/APP_CORE( 4028): appcore-efl.c: __do_app(429) > [APP 4028] Event: TERMINATE State: RUNNING
05-12 16:56:52.738+0900 W/AUL_AMD (  493): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(4028), cmd(4)
05-12 16:56:52.743+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-12 16:56:52.743+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-12 16:56:52.743+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:56:52.753+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4028
05-12 16:56:52.858+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:56:52.863+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4028
05-12 16:56:52.968+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:56:52.968+0900 I/APP_CORE( 4028): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-12 16:56:52.968+0900 I/CAPI_APPFW_APPLICATION( 4028): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-12 16:56:53.033+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4028
05-12 16:56:53.043+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-12 16:56:53.043+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-12 16:56:53.088+0900 I/efl-extension( 4028): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4189b470
05-12 16:56:53.088+0900 I/efl-extension( 4028): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4189b470, obj: 0x4189b470
05-12 16:56:53.088+0900 I/efl-extension( 4028): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-12 16:56:53.088+0900 I/efl-extension( 4028): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-12 16:56:53.088+0900 I/efl-extension( 4028): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-12 16:56:53.088+0900 I/efl-extension( 4028): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-12 16:56:53.133+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:56:53.143+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4028
05-12 16:56:53.173+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-12 16:56:53.173+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-12 16:56:53.173+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:53.173+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:53.173+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:53.173+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-12 16:56:53.178+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-12 16:56:53.178+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
05-12 16:56:53.203+0900 I/UXT     ( 4028): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-12 16:56:53.203+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-12 16:56:53.203+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-12 16:56:53.203+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:53.203+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-12 16:56:53.203+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-12 16:56:53.203+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-12 16:56:53.203+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-12 16:56:53.203+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-12 16:56:53.203+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:53.203+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:53.203+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 16:56:53.228+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 16:56:53.228+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x46f639e0
05-12 16:56:53.228+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46f639e0, elm_layout, _activated_obj : 0x45c95f90, activated : 1
05-12 16:56:53.228+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-12 16:56:53.228+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-12 16:56:53.228+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 16:56:53.228+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-12 16:56:53.228+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 16:56:53.228+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 16:56:53.228+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 16:56:53.228+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 16:56:53.248+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:56:53.253+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4028
05-12 16:56:53.363+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:56:53.378+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4028
05-12 16:56:53.478+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:56:53.493+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4028
05-12 16:56:53.593+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:56:53.603+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-12 16:56:53.608+0900 E/PKGMGR_SERVER( 4253): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-12 16:56:53.638+0900 E/PKGMGR_SERVER( 4251): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4253]
05-12 16:56:53.673+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1518] swap changed from async to sync
05-12 16:56:53.733+0900 W/CRASH_MANAGER( 4258): worker.c: worker_job(1199) > 1104028706831146303981
