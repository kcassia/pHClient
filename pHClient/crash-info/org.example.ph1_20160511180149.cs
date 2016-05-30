S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 8368
Date: 2016-05-11 18:01:49+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 8368, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000009
r2   = 0x0000000a, r3   = 0x00000000
r4   = 0x4030c9c0, r5   = 0x4059a4b8
r6   = 0x4030c16c, r7   = 0x00000000
r8   = 0x437022e4, r9   = 0x41468e70
r10  = 0x4031ab18, fp   = 0x00000000
ip   = 0x4059a4b8, sp   = 0xbe83e278
lr   = 0x404a808c, pc   = 0x404a81f4
cpsr = 0x80000010

Memory Information
MemTotal:   491012 KB
MemFree:     23908 KB
Buffers:     26764 KB
Cached:     138364 KB
VmPeak:      96784 KB
VmSize:      94748 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23520 KB
VmRSS:       23520 KB
VmData:      35504 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25064 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 8368 TID = 8368
8368 8449 8543 

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
44082000 44881000 rwxp [stack:8543]
44890000 44891000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44899000 4489a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
448b7000 448be000 r-xp /usr/lib/libfeedback.so.0.1.4
448c7000 448c8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
448d0000 448d2000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
448da000 448e4000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
448ec000 448f3000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44b8b000 44ba1000 r-xp /usr/lib/libmmfsound.so.0.1.0
44bb3000 44bb8000 r-xp /usr/lib/libmmfsession.so.0.0.0
44bc0000 44bca000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
44bd6000 44bda000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44be3000 44bf9000 r-xp /usr/lib/libavsysaudio.so.0.0.1
44c02000 44c07000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
44c0f000 44c12000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44c1a000 44c7b000 r-xp /usr/lib/libasound.so.2.0.0
44c85000 44c88000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44c94000 45493000 rwxp [stack:8449]
4571d000 45755000 r-xp /usr/lib/libpulse.so.0.16.2
45756000 45763000 r-xp /usr/lib/libail.so.0.1.0
4576c000 4577c000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
4579d000 457a5000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
457b4000 457b7000 r-xp /usr/lib/libcompress.so.0.2.0
457bf000 457c4000 r-xp /usr/lib/libjson.so.0.0.1
457cc000 45814000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45815000 45858000 r-xp /usr/lib/libsndfile.so.1.0.25
45865000 45887000 r-xp /usr/lib/libvorbis.so.0.4.3
4588f000 45893000 r-xp /usr/lib/libogg.so.0.7.1
be81e000 be83f000 rwxp [stack]
End of Maps Information

Callstack Information (PID:8368)
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
fore_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-11 18:01:00.880+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1004): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-11 18:01:00.885+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1004): preference.c: preference_get_double(1214) > preference_get_double(1004) : inactive_before_10min_precaution_millisec error
05-11 18:01:01.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:01.330+0900 D/TIMER   ( 8368): Remind time: 1169
05-11 18:01:02.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:02.330+0900 D/TIMER   ( 8368): Remind time: 1168
05-11 18:01:02.765+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:02.765+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:02.855+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:02.855+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:02.855+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-11 18:01:02.855+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-11 18:01:02.855+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-11 18:01:02.860+0900 W/W_HOME  (  688): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-11 18:01:03.335+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:03.335+0900 D/TIMER   ( 8368): Remind time: 1167
05-11 18:01:04.335+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:04.335+0900 D/TIMER   ( 8368): Remind time: 1166
05-11 18:01:04.620+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:04.625+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:04.635+0900 W/W_HOME  (  688): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-11 18:01:04.675+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-11 18:01:04.680+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-11 18:01:04.680+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-11 18:01:05.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:05.330+0900 D/TIMER   ( 8368): Remind time: 1165
05-11 18:01:05.480+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:05.485+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:05.485+0900 I/efl-extension( 8368): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:05.485+0900 I/efl-extension( 8368): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897830, elm_layout, time_stamp : 3613642
05-11 18:01:05.485+0900 D/TIMER   ( 8368): Rotary callback is called
05-11 18:01:05.485+0900 E/TIMER   ( 8368): (!ad->selected) -> _rotary_cb() return
05-11 18:01:05.650+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:05.650+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:05.650+0900 I/efl-extension( 8368): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:05.650+0900 I/efl-extension( 8368): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897830, elm_layout, time_stamp : 3613807
05-11 18:01:05.650+0900 D/TIMER   ( 8368): Rotary callback is called
05-11 18:01:05.650+0900 E/TIMER   ( 8368): (!ad->selected) -> _rotary_cb() return
05-11 18:01:05.650+0900 I/SOCKETTEST( 8368): Success to create socket
05-11 18:01:05.655+0900 I/SOCKETTEST( 8368): Success to socket connection
05-11 18:01:05.655+0900 I/SOCKETTEST( 8368): write() 성공
05-11 18:01:05.655+0900 I/ROTARTY ( 8368): 앞으로
05-11 18:01:05.955+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:05.955+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:05.955+0900 I/efl-extension( 8368): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:05.955+0900 I/efl-extension( 8368): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897830, elm_layout, time_stamp : 3614112
05-11 18:01:05.955+0900 D/TIMER   ( 8368): Rotary callback is called
05-11 18:01:05.955+0900 E/TIMER   ( 8368): (!ad->selected) -> _rotary_cb() return
05-11 18:01:06.325+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:06.325+0900 D/TIMER   ( 8368): Remind time: 1164
05-11 18:01:06.570+0900 E/SHealth_Common( 1004): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-11 18:01:07.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:07.330+0900 D/TIMER   ( 8368): Remind time: 1163
05-11 18:01:08.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:08.330+0900 D/TIMER   ( 8368): Remind time: 1162
05-11 18:01:09.250+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:09.250+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:09.255+0900 I/efl-extension( 8368): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:09.255+0900 I/efl-extension( 8368): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897830, elm_layout, time_stamp : 3617411
05-11 18:01:09.255+0900 D/TIMER   ( 8368): Rotary callback is called
05-11 18:01:09.255+0900 E/TIMER   ( 8368): (!ad->selected) -> _rotary_cb() return
05-11 18:01:09.260+0900 I/SOCKETTEST( 8368): Success to create socket
05-11 18:01:09.315+0900 I/SOCKETTEST( 8368): Success to socket connection
05-11 18:01:09.315+0900 I/SOCKETTEST( 8368): write() 성공
05-11 18:01:09.315+0900 I/ROTARTY ( 8368): 앞으로
05-11 18:01:09.325+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:09.325+0900 D/TIMER   ( 8368): Remind time: 1161
05-11 18:01:09.325+0900 D/TIMER   ( 8368): Start clicked
05-11 18:01:09.410+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:09.410+0900 I/efl-extension( 8368): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:09.410+0900 I/efl-extension( 8368): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897830, elm_layout, time_stamp : 3617569
05-11 18:01:09.410+0900 D/TIMER   ( 8368): Rotary callback is called
05-11 18:01:09.410+0900 E/TIMER   ( 8368): (!ad->selected) -> _rotary_cb() return
05-11 18:01:09.410+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:09.565+0900 I/efl-extension( 8368): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:09.565+0900 I/efl-extension( 8368): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x41897830, elm_layout, time_stamp : 3617723
05-11 18:01:09.565+0900 D/TIMER   ( 8368): Rotary callback is called
05-11 18:01:09.565+0900 E/TIMER   ( 8368): (!ad->selected) -> _rotary_cb() return
05-11 18:01:09.565+0900 I/SOCKETTEST( 8368): Success to create socket
05-11 18:01:09.565+0900 I/efl-extension( 4334): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:09.565+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-11 18:01:09.575+0900 I/SOCKETTEST( 8368): Success to socket connection
05-11 18:01:09.575+0900 I/SOCKETTEST( 8368): write() 성공
05-11 18:01:09.575+0900 I/ROTARTY ( 8368): 앞으로
05-11 18:01:10.325+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:10.330+0900 D/TIMER   ( 8368): Remind time: 1160
05-11 18:01:11.115+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:11.115+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:11.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:11.330+0900 D/TIMER   ( 8368): Remind time: 1159
05-11 18:01:11.505+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:11.505+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:11.510+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-11 18:01:11.510+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-11 18:01:11.510+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-11 18:01:11.510+0900 W/W_HOME  (  688): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-11 18:01:12.325+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:12.335+0900 D/TIMER   ( 8368): Remind time: 1158
05-11 18:01:13.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:13.330+0900 D/TIMER   ( 8368): Remind time: 1157
05-11 18:01:13.925+0900 I/RESOURCED(  485): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-11 18:01:13.925+0900 I/RESOURCED(  485): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-11 18:01:14.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:14.330+0900 D/TIMER   ( 8368): Remind time: 1156
05-11 18:01:15.340+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:15.340+0900 D/TIMER   ( 8368): Remind time: 1155
05-11 18:01:15.350+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:15.350+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:15.800+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:15.800+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:15.800+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-11 18:01:15.800+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-11 18:01:15.810+0900 W/W_HOME  (  688): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-11 18:01:15.840+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-11 18:01:16.340+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:16.340+0900 D/TIMER   ( 8368): Remind time: 1154
05-11 18:01:16.345+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:16.345+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:17.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:17.330+0900 D/TIMER   ( 8368): Remind time: 1153
05-11 18:01:18.335+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:18.335+0900 D/TIMER   ( 8368): Remind time: 1152
05-11 18:01:19.335+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:19.335+0900 D/TIMER   ( 8368): Remind time: 1151
05-11 18:01:20.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:20.335+0900 D/TIMER   ( 8368): Remind time: 1150
05-11 18:01:21.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:21.335+0900 D/TIMER   ( 8368): Remind time: 1149
05-11 18:01:22.335+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:22.335+0900 D/TIMER   ( 8368): Remind time: 1148
05-11 18:01:23.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:23.330+0900 D/TIMER   ( 8368): Remind time: 1147
05-11 18:01:24.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:24.330+0900 D/TIMER   ( 8368): Remind time: 1146
05-11 18:01:25.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:25.330+0900 D/TIMER   ( 8368): Remind time: 1145
05-11 18:01:26.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:26.330+0900 D/TIMER   ( 8368): Remind time: 1144
05-11 18:01:26.400+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:26.400+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:26.725+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:26.725+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:27.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:27.330+0900 D/TIMER   ( 8368): Remind time: 1143
05-11 18:01:28.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:28.330+0900 D/TIMER   ( 8368): Remind time: 1142
05-11 18:01:29.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:29.330+0900 D/TIMER   ( 8368): Remind time: 1141
05-11 18:01:29.340+0900 D/TIMER   ( 8368): Start clicked
05-11 18:01:30.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:30.330+0900 D/TIMER   ( 8368): Remind time: 1140
05-11 18:01:31.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:31.330+0900 D/TIMER   ( 8368): Remind time: 1139
05-11 18:01:32.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:32.330+0900 D/TIMER   ( 8368): Remind time: 1138
05-11 18:01:32.745+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:32.745+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:32.790+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-11 18:01:32.790+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:32.790+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:32.790+0900 W/W_HOME  (  688): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-11 18:01:32.790+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-11 18:01:32.790+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-11 18:01:33.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:33.330+0900 D/TIMER   ( 8368): Remind time: 1137
05-11 18:01:34.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:34.330+0900 D/TIMER   ( 8368): Remind time: 1136
05-11 18:01:35.335+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:35.335+0900 D/TIMER   ( 8368): Remind time: 1135
05-11 18:01:36.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:36.330+0900 D/TIMER   ( 8368): Remind time: 1134
05-11 18:01:37.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:37.330+0900 D/TIMER   ( 8368): Remind time: 1133
05-11 18:01:38.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:38.330+0900 D/TIMER   ( 8368): Remind time: 1132
05-11 18:01:39.335+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:39.335+0900 D/TIMER   ( 8368): Remind time: 1131
05-11 18:01:39.695+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:39.695+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:40.130+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:40.130+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:40.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:40.330+0900 D/TIMER   ( 8368): Remind time: 1130
05-11 18:01:40.495+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:40.495+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-11 18:01:40.495+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:40.495+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-11 18:01:40.495+0900 W/WAKEUP-SERVICE( 1059): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-11 18:01:40.500+0900 W/W_HOME  (  688): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-11 18:01:41.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:41.330+0900 D/TIMER   ( 8368): Remind time: 1129
05-11 18:01:42.090+0900 W/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-11 18:01:42.090+0900 I/WATCH_CORE(  716): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-11 18:01:42.195+0900 W/SCSD    ( 6923): <_data_cb:507>  - length: 594
05-11 18:01:42.195+0900 W/SCSD    ( 6923): <sap_socket_send:137> sent [594 / 594] bytes
05-11 18:01:42.210+0900 E/wnoti-service(  812): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(583)
05-11 18:01:42.210+0900 E/wnoti-service(  812): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
05-11 18:01:42.215+0900 E/wnoti-service(  812): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-11 18:01:42.215+0900 E/wnoti-service(  812): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1676
05-11 18:01:42.220+0900 W/SCSD    ( 6923): <_data_cb:507>  - length: 2139
05-11 18:01:42.220+0900 W/SCSD    ( 6923): <sap_socket_send:137> sent [2139 / 2139] bytes
05-11 18:01:42.220+0900 E/wnoti-service(  812): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1689
05-11 18:01:42.220+0900 E/wnoti-service(  812): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
05-11 18:01:42.220+0900 E/wnoti-service(  812): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 143
05-11 18:01:42.230+0900 E/wnoti-service(  812): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1676
05-11 18:01:42.230+0900 E/wnoti-service(  812): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1689
05-11 18:01:42.230+0900 E/wnoti-service(  812): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_180.png
05-11 18:01:42.240+0900 E/wnoti-service(  812): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 1002/0
05-11 18:01:42.240+0900 E/wnoti-service(  812): wnoti-sap-client.c: _add_exception_handling(581) > type : 1002, application_id : 218
05-11 18:01:42.245+0900 E/wnoti-service(  812): wnoti-sap-client.c: publish_received_noti(1848) > 1002, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229673, noti_flag : 528, g_span_version : 1
05-11 18:01:42.245+0900 E/wnoti-service(  812): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-11 18:01:42.245+0900 E/wnoti-service(  812): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 1
05-11 18:01:42.245+0900 E/wnoti-service(  812): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 1
05-11 18:01:42.245+0900 E/wnoti-service(  812): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(2128)
05-11 18:01:42.250+0900 E/wnoti-service(  812): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
05-11 18:01:42.250+0900 E/wnoti-service(  812): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 1
05-11 18:01:42.250+0900 E/wnoti-service(  812): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1676
05-11 18:01:42.250+0900 E/wnoti-service(  812): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1678
05-11 18:01:42.250+0900 E/wnoti-service(  812): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 2
05-11 18:01:42.250+0900 E/wnoti-service(  812): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 1631
05-11 18:01:42.255+0900 E/wnoti-service(  812): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1676
05-11 18:01:42.255+0900 E/wnoti-service(  812): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1678
05-11 18:01:42.255+0900 E/wnoti-service(  812): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_167.png
05-11 18:01:42.255+0900 E/wnoti-service(  812): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1677
05-11 18:01:42.280+0900 E/wnoti-service(  812): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 5/229672
05-11 18:01:42.280+0900 E/wnoti-service(  812): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 218
05-11 18:01:42.290+0900 E/wnoti-service(  812): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
05-11 18:01:42.290+0900 E/wnoti-service(  812): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 0, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229674, noti_flag : 16, g_span_version : 1
05-11 18:01:42.290+0900 E/wnoti-service(  812): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 1
05-11 18:01:42.310+0900 E/wnoti-service(  812): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 1
05-11 18:01:42.325+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:42.325+0900 D/TIMER   ( 8368): Remind time: 1128
05-11 18:01:43.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:43.330+0900 D/TIMER   ( 8368): Remind time: 1127
05-11 18:01:43.760+0900 E/wnoti-service(  812): wnoti-sap-client.c: _get_latest_notification_card(1700) > id : 2146, status : 0
05-11 18:01:43.780+0900 W/SCSD    ( 6923): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x05)
05-11 18:01:43.780+0900 W/SCSD    ( 6923): <on_sap_socket_recv:30>  - remain length: 5, crc_size: 4
05-11 18:01:43.780+0900 W/SCSD    ( 6923): <on_sap_socket_recv:62>  - recv 9 bytes [9 / 9] 
05-11 18:01:43.790+0900 W/SCSD    ( 6923): <util_scs_send:975> sent [11 / 11] bytes. 
05-11 18:01:43.830+0900 I/wnoti-service(  812): wnoti-sap-client.c: launch_alert_view(398) > timer_id : 0, emergency_cb_mode : 0, blocking_mode : 0 
05-11 18:01:43.830+0900 E/wnoti-service(  812): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 1
05-11 18:01:43.830+0900 I/wnoti-service(  812): wnoti-msg-builder.c: _publish_notification(1394) > operation_type : 0, source : 0, application_id : 0, display_count : 0
05-11 18:01:43.850+0900 E/wnoti-proxy(  688): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 688, caller_id : 0, listener_type : 0
05-11 18:01:43.850+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1501) > Change type : 0, op_type: 0, category_id: 0, display count: 0
05-11 18:01:43.850+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1556) > Handle this change type in idler.
05-11 18:01:43.850+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1561) > Home is background. Postpone the board update.
05-11 18:01:43.855+0900 E/wnoti-proxy( 4334): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 4334, caller_id : 0, listener_type : 0
05-11 18:01:43.855+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1502) > Handle this change type in idler.
05-11 18:01:43.855+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 2145
05-11 18:01:43.855+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 0, 0
05-11 18:01:43.860+0900 E/wnoti-service(  812): wnoti-sap-client.c: on_timer(291) > is_exist_alert_list : 0, g_launch_popup_time : 1462957303, g_use_aul_launch : 0
05-11 18:01:43.860+0900 E/wnoti-service(  812): wnoti-sap-client.c: on_timer(293) > >> launching notification popup
05-11 18:01:43.865+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 0
05-11 18:01:43.890+0900 I/AUL_AMD (  484): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-11 18:01:43.905+0900 I/AUL_AMD (  484): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-11 18:01:43.905+0900 E/AUL_AMD (  484): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-11 18:01:43.905+0900 W/AUL_AMD (  484): amd_launch.c: _start_app(1702) > caller pid : 812
05-11 18:01:43.920+0900 W/AUL_AMD (  484): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 4334
05-11 18:01:43.925+0900 I/APP_CORE( 4334): appcore-efl.c: __do_app(429) > [APP 4334] Event: RESET State: PAUSED
05-11 18:01:43.925+0900 I/CAPI_APPFW_APPLICATION( 4334): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-11 18:01:43.935+0900 W/AUL_AMD (  484): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(4334), cmd(0)
05-11 18:01:43.965+0900 W/wnotibp ( 4334): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-11 18:01:43.975+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 14
05-11 18:01:43.985+0900 W/AUL_AMD (  484): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-11 18:01:43.985+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: wnotiboard_popup_get_block_mode(2354) > Returning false.
05-11 18:01:43.995+0900 E/wnoti-service(  812): wnoti-db-client.c: wnoti_get_alert_categories(712) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 218, db_id : 2146, is_duplicated : 0
05-11 18:01:44.000+0900 E/wnoti-service(  812): wnoti-db-client.c: wnoti_get_alert_categories(851) > view_type : 1, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 0
05-11 18:01:44.020+0900 I/wnoti-proxy( 4334): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-11 18:01:44.020+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_get_alert_list(813) > application_name: 카카오톡, application_id: 218, category_id: 115, time: 1462957301, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_218.jpg, icon_color: -5730296
05-11 18:01:44.020+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_get_alert_list(820) > noti_type: 1
05-11 18:01:44.020+0900 W/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_convert_alert_data(77) > db_id = 2146, alert_type: 1, app_feedback_type: 0
05-11 18:01:44.020+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_convert_alert_data(372) > Activity fetch finished: -1
05-11 18:01:44.020+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_convert_alert_data(377) > activity action count: 1
05-11 18:01:44.020+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_convert_alert_data(382) > 1 activities retrieved.
05-11 18:01:44.025+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_convert_alert_data(473) > Page fetch finished: -1
05-11 18:01:44.025+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_convert_alert_data(478) > wearable_page_cnt: 1
05-11 18:01:44.025+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_convert_alert_data(483) > 1 pages retrieved.
05-11 18:01:44.025+0900 W/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 1, list count : 1
05-11 18:01:44.025+0900 W/wnotibp ( 4334): wnotiboard-popup.c: _wnotiboard_popup_app_control(1131) > ::DATA:: CHECK IN APP CONTROL : 1, 0, 1
05-11 18:01:44.025+0900 W/wnotibp ( 4334): wnotiboard-popup.c: _wnotiboard_popup_app_control(1143) > ::APP:: CHECK STATE : 8, 0, (null)
05-11 18:01:44.025+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-11 18:01:44.025+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-11 18:01:44.025+0900 W/wnotibp ( 4334): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(628) > [2146, 1, 1, 12, 0000]
05-11 18:01:44.025+0900 W/wnotibp ( 4334): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(629) > [0, 1, 0, 0]
05-11 18:01:44.025+0900 W/wnotibp ( 4334): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(630) > [1, 0, 0, 0]
05-11 18:01:44.025+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-11 18:01:44.025+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4443) > wnotiboard_popup_vi_type: 2
05-11 18:01:44.025+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4449) > (2146, 2146)
05-11 18:01:44.030+0900 I/efl-extension( 4334): efl_extension_circle_surface.c: eext_circle_surface_layout_add(1293) > Put the surface[0x469089f8]'s widget[0x46956748] to layout widget[0x446d1548]
05-11 18:01:44.040+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_create_genlist(4377) > (2146, 2146)
05-11 18:01:44.045+0900 I/efl-extension( 4334): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-11 18:01:44.060+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_create_card_data(3979) > 0x450e81b8, 0x450e8038, 0x450e8038
05-11 18:01:44.060+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 18:01:44.060+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 18:01:44.060+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 18:01:44.060+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 18:01:44.070+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: wnotiboard_popup_draw_small_view(3659) > ::UI:: window type is changed by unknown causes
05-11 18:01:44.070+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03400008)
05-11 18:01:44.070+0900 I/APP_CORE( 4334): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-11 18:01:44.090+0900 W/wnotibp ( 4334): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2201) > Unhandled part: stack.separator
05-11 18:01:44.090+0900 I/wnotibp ( 4334): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-11 18:01:44.095+0900 I/wnotibp ( 4334): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-11 18:01:44.100+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 18:01:44.100+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 18:01:44.100+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 18:01:44.100+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 18:01:44.120+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x03400008)
05-11 18:01:44.125+0900 W/APP_CORE( 4334): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400008
05-11 18:01:44.145+0900 E/EFL     ( 4334): evas_main<4334> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-11 18:01:44.145+0900 E/EFL     ( 4334): evas_main<4334> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-11 18:01:44.145+0900 E/EFL     ( 4334): evas_main<4334> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-11 18:01:44.145+0900 I/wnotibp ( 4334): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-11 18:01:44.145+0900 I/wnotibp ( 4334): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-11 18:01:44.150+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-11 18:01:44.150+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-11 18:01:44.150+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-11 18:01:44.150+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4334): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-11 18:01:44.190+0900 E/EFL     ( 4334): evas_main<4334> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x45b51038 is not stable during recalc loop
05-11 18:01:44.195+0900 E/EFL     ( 4334): evas_main<4334> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x45b51038 is not stable during recalc loop
05-11 18:01:44.215+0900 W/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3713) > ::UI:: VI TYPE : 2
05-11 18:01:44.215+0900 W/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3719) > alert_type : 1, is_source_companion: 1
05-11 18:01:44.215+0900 W/TIZEN_N_RECORDER( 4334): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
05-11 18:01:44.215+0900 W/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1272) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
05-11 18:01:44.215+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1281) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
05-11 18:01:44.215+0900 W/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1315) > ::APP:: Determined feedback: sound 0, vibration: 0
05-11 18:01:44.215+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1319) > No feedback.
05-11 18:01:44.225+0900 W/AUL_AMD (  484): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-11 18:01:44.225+0900 W/AUL_AMD (  484): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-11 18:01:44.230+0900 I/wnotibp ( 4334): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1037) > fully_obscured: 0 [0x3400008 0x340000a 0x3400008 ]
05-11 18:01:44.235+0900 I/APP_CORE( 4334): appcore-efl.c: __do_app(429) > [APP 4334] Event: RESUME State: RUNNING
05-11 18:01:44.270+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_view_lock(856) > ::UI:: [[[ ===> already [small popup] is LOCK, 0010 ]]]
05-11 18:01:44.270+0900 W/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_pre_cb(2194) > ::UI:: start showing animation
05-11 18:01:44.325+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:44.325+0900 D/TIMER   ( 8368): Remind time: 1126
05-11 18:01:44.575+0900 W/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_cb(2104) > ::UI:: end show animation
05-11 18:01:44.575+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-11 18:01:44.575+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-11 18:01:44.580+0900 E/wnoti-service(  812): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
05-11 18:01:44.585+0900 E/wnoti-service(  812): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 2
05-11 18:01:44.590+0900 E/wnoti-service(  812): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-11 18:01:44.600+0900 E/wnoti-proxy( 4334): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
05-11 18:01:44.600+0900 E/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_get_alert_list(916) > ::DATA:: No categories available.
05-11 18:01:44.600+0900 W/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 0, list count : 1
05-11 18:01:45.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:45.330+0900 D/TIMER   ( 8368): Remind time: 1125
05-11 18:01:45.835+0900 E/wnoti-service(  812): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
05-11 18:01:46.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:46.330+0900 D/TIMER   ( 8368): Remind time: 1124
05-11 18:01:47.065+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-11 18:01:47.065+0900 W/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_main_popup_timer_cb(2324) > ::UI:: start hiding animation
05-11 18:01:47.185+0900 E/EFL     ( 4334): elementary<4334> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(46956a48), block(2)
05-11 18:01:47.185+0900 E/EFL     ( 4334): elementary<4334> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(46956a48), ev->cur.canvas.x(197) ev->cur.canvas.y(160)
05-11 18:01:47.185+0900 E/EFL     ( 4334): elementary<4334> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(46956a48), hold(0) freeze(0)
05-11 18:01:47.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:47.330+0900 D/TIMER   ( 8368): Remind time: 1123
05-11 18:01:47.370+0900 W/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_hide_animator_cb(2255) > ::UI:: end hiding animation
05-11 18:01:47.370+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-11 18:01:47.370+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-11 18:01:47.370+0900 W/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (8, 1, 0)
05-11 18:01:47.370+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=0, view_state=0
05-11 18:01:47.370+0900 I/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_view_unlock(903) > ::UI:: it is invalid object.
05-11 18:01:47.370+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [invalid object] is UNLOCK , 0000 <=== ]]]
05-11 18:01:47.370+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-11 18:01:47.370+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 2146
05-11 18:01:47.375+0900 I/wnotibp ( 4334): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 0, 0
05-11 18:01:47.375+0900 I/efl-extension( 4334): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x46956a48, obj: 0x46956a48
05-11 18:01:47.375+0900 I/efl-extension( 4334): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-11 18:01:47.390+0900 I/efl-extension( 4334): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-11 18:01:47.390+0900 I/efl-extension( 4334): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46956a48, elm_genlist, func : 0x41a25dfd
05-11 18:01:47.390+0900 I/efl-extension( 4334): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-11 18:01:47.390+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-11 18:01:47.390+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(998) > ::UI:: lock state = 0000
05-11 18:01:47.390+0900 I/efl-extension( 4334): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-11 18:01:47.395+0900 I/wnotibp ( 4334): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4568) > Panel open state: 0 for 115, 218
05-11 18:01:47.395+0900 I/efl-extension( 4334): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-11 18:01:47.395+0900 I/wnotibp ( 4334): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(2024) > ::INFO:: call lower
05-11 18:01:47.400+0900 W/APP_CORE( 4334): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:3400008
05-11 18:01:47.400+0900 I/APP_CORE( 4334): appcore-efl.c: __do_app(429) > [APP 4334] Event: PAUSE State: RUNNING
05-11 18:01:47.400+0900 I/CAPI_APPFW_APPLICATION( 4334): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-11 18:01:47.450+0900 W/wnotibp ( 4334): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-11 18:01:47.450+0900 W/wnotibp ( 4334): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-11 18:01:47.450+0900 W/wnotibp ( 4334): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [0, 0, 12, 0000]
05-11 18:01:47.455+0900 W/wnotibp ( 4334): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 0]
05-11 18:01:47.455+0900 W/wnotibp ( 4334): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1371) > [0, 1, 0, 2, 0]
05-11 18:01:47.835+0900 E/wnoti-service(  812): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
05-11 18:01:48.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:48.330+0900 D/TIMER   ( 8368): Remind time: 1122
05-11 18:01:48.390+0900 I/efl-extension( 8368): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x41897830
05-11 18:01:48.390+0900 I/efl-extension( 8368): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x41897830, obj: 0x41897830
05-11 18:01:48.390+0900 I/efl-extension( 8368): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-11 18:01:48.765+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-11 18:01:48.765+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-11 18:01:48.770+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-11 18:01:48.770+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-11 18:01:48.855+0900 W/STARTER (  678): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-11 18:01:48.945+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-11 18:01:48.945+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-11 18:01:48.965+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-11 18:01:48.965+0900 W/STARTER (  678): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-11 18:01:49.060+0900 W/STARTER (  678): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-11 18:01:49.330+0900 D/TIMER   ( 8368): Timer is start
05-11 18:01:49.330+0900 D/TIMER   ( 8368): Remind time: 1121
05-11 18:01:49.340+0900 F/EFL     ( 8368): evas_main<8368> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
05-11 18:01:49.340+0900 W/STARTER (  678): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-11 18:01:49.355+0900 W/STARTER (  678): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-11 18:01:49.415+0900 E/STARTER (  678): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-11 18:01:49.415+0900 W/AUL_AMD (  484): amd_request.c: __request_handler(646) > __request_handler: 0
05-11 18:01:49.425+0900 W/AUL_AMD (  484): amd_launch.c: _start_app(1702) > caller pid : 678
05-11 18:01:49.435+0900 W/AUL_AMD (  484): amd_launch.c: _start_app(2080) > pad pid(-5)
05-11 18:01:49.435+0900 W/AUL_PAD ( 1103): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-11 18:01:49.435+0900 W/AUL_PAD ( 1103): launchpad.c: __send_result_to_caller(272) > Check app launching
05-11 18:01:49.445+0900 E/RESOURCED(  485): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-11 18:01:49.465+0900 I/CAPI_APPFW_APPLICATION( 8261): app_main.c: app_efl_main(129) > app_efl_main
05-11 18:01:49.470+0900 I/CAPI_APPFW_APPLICATION( 8261): app_main.c: app_appcore_create(152) > app_appcore_create
05-11 18:01:49.540+0900 E/AUL     (  678): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-11 18:01:49.540+0900 E/RESOURCED(  485): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-11 18:01:49.610+0900 I/efl-extension( 8261): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445834d0 = w: 0 h: 0  obj 0x4458d2c8 w: 360 h: 360
05-11 18:01:49.610+0900 I/efl-extension( 8261): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-11 18:01:49.615+0900 I/efl-extension( 8261): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-11 18:01:49.615+0900 I/efl-extension( 8261): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-11 18:01:49.615+0900 I/efl-extension( 8261): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-11 18:01:49.615+0900 I/efl-extension( 8261): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-11 18:01:49.620+0900 I/efl-extension( 8261): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4458d2c8, elm_image, _activated_obj : 0x0, activated : 1
05-11 18:01:49.740+0900 W/CRASH_MANAGER( 8792): worker.c: worker_job(1199) > 1108368706831146295730
