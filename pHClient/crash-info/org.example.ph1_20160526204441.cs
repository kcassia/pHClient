S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 25907
Date: 2016-05-26 20:44:41+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x45673978, r5   = 0x41561c69
r6   = 0x45674278, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x45672bf8
r10  = 0x45672178, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbe8ae630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     30596 KB
Buffers:     47684 KB
Cached:     133064 KB
VmPeak:     100852 KB
VmSize:      93504 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26036 KB
VmRSS:       23676 KB
VmData:      39152 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23928 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 25907 TID = 25907
25907 26037 26113 

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
43882000 44081000 rwxp [stack:26113]
44a1c000 4521b000 rwxp [stack:26037]
458ba000 458bd000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45930000 45968000 r-xp /usr/lib/libpulse.so.0.16.2
459dd000 459e2000 r-xp /usr/lib/libjson.so.0.0.1
459ea000 45a32000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a33000 45a76000 r-xp /usr/lib/libsndfile.so.1.0.25
45a83000 45aa5000 r-xp /usr/lib/libvorbis.so.0.4.3
45aad000 45ab1000 r-xp /usr/lib/libogg.so.0.7.1
be88e000 be8af000 rwxp [stack]
End of Maps Information

Callstack Information (PID:25907)
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
:20.839+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:21.459+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:21.459+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:21.459+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:21.459+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:21.459+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:21.464+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 20:44:21.464+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 20:44:21.464+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 20:44:21.469+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 20:44:25.609+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:25.689+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:25.759+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:25.794+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:25.794+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:25.799+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:25.799+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:25.799+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:25.799+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 20:44:25.804+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 20:44:25.804+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 20:44:25.804+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 20:44:25.809+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:25.844+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:25.869+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:25.874+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:25.889+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:25.949+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:25.989+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:26.104+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:26.179+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:26.244+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:26.264+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:26.264+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:26.264+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:26.264+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:26.264+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:26.294+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:26.294+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:26.304+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:26.329+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:26.559+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:26.559+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:26.559+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:26.559+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:26.559+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:26.639+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:27.369+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:27.399+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:27.434+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:27.474+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:27.529+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:27.544+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:27.819+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:27.819+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:27.819+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:27.819+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:27.819+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:28.304+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:28.739+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:28.784+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:28.784+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:28.789+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:28.789+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:28.789+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:28.804+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:28.849+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:28.884+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:28.914+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:28.939+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:28.944+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:28.959+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:29.179+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:29.179+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:29.179+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:29.179+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:29.179+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:29.184+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 20:44:29.189+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 20:44:29.189+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 20:44:29.189+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 20:44:30.349+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:30.349+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:30.349+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:30.349+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:30.349+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:30.364+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:30.414+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:30.444+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:30.474+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:30.499+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 20:44:30.499+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 20:44:30.509+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:30.544+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:30.554+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:30.559+0900 I/RESOURCED(  475): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-26 20:44:30.594+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:30.614+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:30.644+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:30.674+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:30.704+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:30.734+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:30.764+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:30.774+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:30.789+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:31.054+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:31.054+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:31.059+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:31.059+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:31.059+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:31.659+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:31.719+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:31.784+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:31.824+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:31.854+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:31.894+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:31.899+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:31.919+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:32.029+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 20:44:32.029+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:32.029+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 20:44:32.029+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:32.034+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 20:44:32.034+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:32.034+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:32.034+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:32.039+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 20:44:32.309+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:32.309+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:32.309+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:32.309+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:32.309+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:32.394+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:32.419+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:32.454+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:32.484+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:32.514+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:32.544+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:32.549+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:32.569+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:32.954+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:33.009+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:33.014+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:33.014+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:33.014+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:33.014+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:33.024+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 20:44:33.024+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 20:44:33.024+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 20:44:33.024+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 20:44:33.059+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:33.124+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:33.159+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:33.204+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:33.244+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:33.259+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:33.279+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:33.314+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:33.349+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:33.404+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:33.449+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:33.489+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:33.529+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:33.539+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:33.579+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:33.959+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:34.019+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:34.079+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:34.119+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:34.149+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:34.184+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:34.189+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:34.209+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:34.284+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:34.329+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:34.349+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:34.349+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:34.349+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:34.349+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:34.349+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:34.389+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:34.424+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:34.449+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:34.479+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:34.484+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:34.499+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:34.774+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:34.774+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:34.774+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:34.774+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:34.774+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:34.844+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:34.879+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:34.909+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:34.939+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:34.969+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:34.999+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:35.009+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:35.024+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:35.414+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:35.449+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:35.449+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:35.449+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:35.449+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:35.449+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:35.479+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:35.524+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:35.559+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:35.589+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:35.619+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:35.629+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:35.644+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:35.744+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:35.744+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:35.749+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:35.749+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:35.749+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:35.834+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:35.859+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:35.889+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:35.924+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:35.954+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:35.984+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:35.994+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:36.009+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:36.104+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:36.104+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:36.109+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:36.109+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:36.109+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:36.214+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:36.239+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:36.269+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:36.299+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:36.329+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:36.359+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:36.364+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:36.384+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:36.804+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:36.869+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:36.954+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:36.954+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:36.954+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:36.954+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:36.954+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:36.969+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:37.004+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:37.029+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:37.059+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:37.064+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:37.079+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:37.264+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:37.264+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:37.264+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:37.264+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:37.264+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:37.339+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:37.374+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:37.404+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:37.434+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:37.464+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:37.499+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:37.504+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:37.519+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:37.964+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:37.964+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:37.964+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:37.964+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:37.964+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:38.029+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:38.054+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:38.089+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:38.119+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:38.149+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:38.179+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:38.189+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:38.204+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:38.579+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:38.639+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:44:38.639+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:44:38.639+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:38.639+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:38.639+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:38.649+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 20:44:38.649+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 20:44:38.649+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 20:44:38.649+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 20:44:38.699+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:38.739+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:38.774+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:38.814+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:38.869+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:38.874+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:38.899+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:39.094+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:40.319+0900 I/CAPI_APPFW_APPLICATION(25907): app_main.c: ui_app_exit(715) > ui_app_exit
05-26 20:44:40.319+0900 I/CAPI_APPFW_APPLICATION(25907): app_main.c: app_efl_exit(145) > app_efl_exit
05-26 20:44:40.324+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 20:44:40.324+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 20:44:40.524+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:44:40.564+0900 I/APP_CORE(25907): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 20:44:40.564+0900 I/APP_CORE(25907): appcore-efl.c: __after_loop(1090) > [APP 25907] PAUSE before termination
05-26 20:44:40.564+0900 I/CAPI_APPFW_APPLICATION(25907): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-26 20:44:40.574+0900 I/CAPI_APPFW_APPLICATION(25907): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 20:44:40.589+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 20:44:40.589+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 20:44:40.604+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:44:40.639+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:40.704+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 20:44:40.704+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 20:44:40.704+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:44:40.704+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:44:40.709+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:44:40.709+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 20:44:40.709+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 20:44:40.709+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 20:44:40.709+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:44:40.709+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:44:40.709+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:44:40.719+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:40.734+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-26 20:44:40.744+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 20:44:40.744+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:44:40.744+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-26 20:44:40.744+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESUME State: PAUSED
05-26 20:44:40.744+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 20:44:40.744+0900 W/W_HOME  (  726): main.c: _appcore_resume_cb(681) > appcore resume
05-26 20:44:40.744+0900 W/W_HOME  (  726): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 20:44:40.744+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:44:40.744+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:44:40.744+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:44:40.744+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 20:44:40.764+0900 W/W_HOME  (  726): rotary.c: rotary_attach(138) > rotary_attach:0x478904a8
05-26 20:44:40.769+0900 I/UXT     (25907): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 20:44:40.769+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x478904a8, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-26 20:44:40.769+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 20:44:40.774+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 20:44:40.774+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 20:44:40.774+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 20:44:40.774+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 20:44:40.774+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 20:44:40.774+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 20:44:40.774+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 20:44:40.819+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:44:40.849+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:44:40.859+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:44:40.889+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:44:41.194+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 20:44:41.404+0900 W/CRASH_MANAGER(26751): worker.c: worker_job(1199) > 1125907706831146426308
