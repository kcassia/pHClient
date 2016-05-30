S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 14311
Date: 2016-05-26 22:44:52+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x448d72d8, r5   = 0x41561cd9
r6   = 0x448d7bd8, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x448d6558
r10  = 0x418870a8, fp   = 0x00000000
ip   = 0x4153b490, sp   = 0xbe804630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     11212 KB
Buffers:     36996 KB
Cached:     155884 KB
VmPeak:      99316 KB
VmSize:      92544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24620 KB
VmRSS:       22688 KB
VmData:      38128 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23960 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14311 TID = 14311
14311 14565 14664 

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
43857000 4385b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44092000 44891000 rwxp [stack:14664]
44a2c000 4522b000 rwxp [stack:14565]
458b8000 458bb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
458c3000 458fb000 r-xp /usr/lib/libpulse.so.0.16.2
45adf000 45ae4000 r-xp /usr/lib/libjson.so.0.0.1
45aec000 45b34000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45b35000 45b78000 r-xp /usr/lib/libsndfile.so.1.0.25
45b85000 45ba7000 r-xp /usr/lib/libvorbis.so.0.4.3
45baf000 45bb3000 r-xp /usr/lib/libogg.so.0.7.1
be7e4000 be805000 rwxp [stack]
End of Maps Information

Callstack Information (PID:14311)
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
.226+0900 W/APPS    (  737): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 22:43:40.266+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:40.281+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:40.281+0900 I/efl-extension(  737): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x47911dc0, elm_layout, time_stamp : 4257314
05-26 22:43:40.281+0900 E/APPS    (  737): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
05-26 22:43:40.736+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:40.741+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:40.741+0900 I/efl-extension(  737): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x47911dc0, elm_layout, time_stamp : 4257788
05-26 22:43:40.741+0900 W/APPS    (  737): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
05-26 22:43:40.741+0900 W/APPS    (  737): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[16], __pAppsItemList.size[21]
05-26 22:43:40.741+0900 W/APPS    (  737): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[17]
05-26 22:43:40.796+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:40.801+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:40.801+0900 I/efl-extension(  737): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x47911dc0, elm_layout, time_stamp : 4257848
05-26 22:43:40.801+0900 W/APPS    (  737): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[17], __pAppsItemList.size[21]
05-26 22:43:40.801+0900 W/APPS    (  737): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[18]
05-26 22:43:40.806+0900 W/APPS    (  737): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 22:43:40.851+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:40.861+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:40.861+0900 I/efl-extension(  737): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x47911dc0, elm_layout, time_stamp : 4257899
05-26 22:43:40.861+0900 W/APPS    (  737): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[18], __pAppsItemList.size[21]
05-26 22:43:40.861+0900 W/APPS    (  737): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[19]
05-26 22:43:40.866+0900 W/APPS    (  737): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 22:43:40.956+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:40.971+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:40.971+0900 I/efl-extension(  737): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x47911dc0, elm_layout, time_stamp : 4258008
05-26 22:43:40.971+0900 W/APPS    (  737): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[19], __pAppsItemList.size[21]
05-26 22:43:40.971+0900 W/APPS    (  737): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[20]
05-26 22:43:40.976+0900 W/APPS    (  737): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 22:43:41.206+0900 W/APPS    (  737): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 22:43:41.351+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:41.351+0900 I/efl-extension(  737): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x47911dc0, elm_layout, time_stamp : 4258398
05-26 22:43:41.351+0900 W/APPS    (  737): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3169) >  __nIsEditMode[0], __focusPage[2], __focusIndex[20], __pAppsItemList.size[21]
05-26 22:43:41.351+0900 W/APPS    (  737): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[19]
05-26 22:43:41.356+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:41.586+0900 W/APPS    (  737): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
05-26 22:43:41.931+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 22:43:41.936+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4258982 button=1 downs=1
05-26 22:43:41.936+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [205, 145]
05-26 22:43:41.986+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4259026 button=1 downs=0
05-26 22:43:41.986+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [205, 145]->[204, 139]
05-26 22:43:41.986+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-26 22:43:41.991+0900 E/APPS    (  737): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-26 22:43:41.991+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-26 22:43:41.991+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:43:41.996+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 737
05-26 22:43:41.996+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:43:42.011+0900 E/RESOURCED(  497): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
05-26 22:43:42.011+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 22:43:42.011+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 22:43:42.011+0900 W/AUL_PAD ( 1155): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 22:43:42.011+0900 W/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 22:43:42.056+0900 I/efl-extension(14311): efl_extension.c: eext_mod_init(40) > Init
05-26 22:43:42.056+0900 I/UXT     (14311): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 22:43:42.066+0900 I/CAPI_APPFW_APPLICATION(14311): app_main.c: ui_app_main(704) > app_efl_main
05-26 22:43:42.071+0900 I/CAPI_APPFW_APPLICATION(14311): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-26 22:43:42.116+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:43:42.116+0900 E/TBM     (14311): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 22:43:42.231+0900 E/EFL     (14311): <14311> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-26 22:43:42.241+0900 E/EFL     (14311): <14311> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:43:42.246+0900 E/EFL     (14311): <14311> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:43:42.251+0900 E/EFL     (14311): <14311> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:43:42.256+0900 E/EFL     (14311): <14311> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:43:42.261+0900 E/EFL     (14311): <14311> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:43:42.336+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05c00002)
05-26 22:43:42.386+0900 I/APP_CORE(14311): appcore-efl.c: __do_app(429) > [APP 14311] Event: RESET State: CREATED
05-26 22:43:42.386+0900 I/CAPI_APPFW_APPLICATION(14311): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 22:43:42.396+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 22:43:42.406+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 22:43:42.406+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:43:42.406+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:43:42.406+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:43:42.406+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 22:43:42.416+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:43:42.416+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:43:42.436+0900 I/APP_CORE(14311): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 22:43:42.436+0900 I/APP_CORE(14311): appcore-efl.c: __do_app(474) > [APP 14311] Initial Launching, call the resume_cb
05-26 22:43:42.441+0900 I/CAPI_APPFW_APPLICATION(14311): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 22:43:42.506+0900 W/APP_CORE(14311): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00002
05-26 22:43:42.541+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 22:43:42.541+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 22:43:42.541+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:43:42.541+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 22:43:42.541+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 22:43:42.541+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:43:42.541+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 22:43:42.541+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 22:43:42.541+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:43:42.546+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:43:42.546+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:43:42.546+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 22:43:42.546+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:43:42.546+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 22:43:42.546+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:43:42.546+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:43:42.546+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:43:42.546+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 22:43:42.546+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:43:42.546+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:43:42.546+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:43:42.556+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:43:42.556+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:43:42.556+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:43:42.561+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:43:42.566+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:43:42.566+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:43:42.576+0900 I/APP_CORE(14311): appcore-efl.c: __do_app(429) > [APP 14311] Event: RESUME State: RUNNING
05-26 22:43:42.601+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:43:42.601+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 22:43:42.691+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 22:43:42.691+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:43:42.706+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 22:43:42.936+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:43:43.066+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:43:43.176+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:43:43.181+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14311
05-26 22:43:43.186+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:43:43.301+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4260349 button=1 downs=1
05-26 22:43:43.376+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4260424 button=1 downs=0
05-26 22:43:43.431+0900 I/AUL_PAD (14567): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 22:43:44.256+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4261300 button=1 downs=1
05-26 22:43:44.326+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4261375 button=1 downs=0
05-26 22:43:44.626+0900 I/CAPI_NETWORK_CONNECTION(14311): connection.c: connection_create(372) > New handle created[0x414d92c8]
05-26 22:43:44.646+0900 I/SOCKETTEST(14311): IP : 
05-26 22:43:44.646+0900 I/SOCKETTEST(14311): Success to create UDP socket
05-26 22:43:44.646+0900 I/SOCKETTEST(14311): Bind Success
05-26 22:43:44.646+0900 I/SOCKETTEST(14311): Waiting DATA...
05-26 22:43:47.166+0900 I/SOCKETTEST(14311): Receive Data : 192.168.0.47
05-26 22:43:47.171+0900 I/SOCKETTEST(14311): Changed IP : 192.168.0.47
05-26 22:43:47.196+0900 I/SOCKETTEST(14311): Success to create socket
05-26 22:43:47.206+0900 I/SOCKETTEST(14311): Success to socket connection
05-26 22:43:47.206+0900 I/SOCKETTEST(14311): write() 성공
05-26 22:43:47.571+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:43:48.366+0900 W/MUSIC_TRANSFER(14173): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:14173]   uwLocalAgentId : [22277], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-26 22:43:48.366+0900 W/MUSIC_TRANSFER(14173): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:14173]   wStatusCode error : [1]!!![0m
05-26 22:43:49.791+0900 W/MUSIC_TRANSFER(14173): mt-controller.c: _exit_timeout_cb(138) > [36m[TID:14173]   [MUSIC_PLAYER_EVENT]exit[0m
05-26 22:43:49.791+0900 I/CAPI_APPFW_APPLICATION(14173): service_app_main.c: service_app_exit(441) > service_app_exit
05-26 22:43:49.791+0900 W/MUSIC_TRANSFER(14173): mt-service.c: _service_app_terminate(63) > [33m[TID:14173]   [0m
05-26 22:43:49.791+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 22:43:49.791+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 22:43:49.791+0900 I/CAPI_CONTENT_MEDIA_CONTENT(14173): media_content.c: media_content_disconnect(959) > [32m[14173]ref count changed to: 1
05-26 22:43:49.796+0900 I/CAPI_CONTENT_MEDIA_CONTENT(14173): media_content.c: media_content_disconnect(948) > [32m[14173]ref count changed to: 0
05-26 22:43:49.796+0900 W/MUSIC_TRANSFER(14173): mp-log-manager.c: mp_log_mgr_destroy(134) > [36m[TID:14173]   [MUSIC_PLAYER_EVENT][0m
05-26 22:43:49.816+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4266862 button=1 downs=1
05-26 22:43:49.831+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4266881 button=1 downs=0
05-26 22:43:49.851+0900 D/TIMER   (14311): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:43:49.851+0900 D/TIMER   (14311): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:43:49.906+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:43:49.906+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:43:49.906+0900 I/efl-extension(14311): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:43:49.911+0900 I/efl-extension(14311): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:43:49.911+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45342c98, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:43:50.086+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 23
05-26 22:43:50.086+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
05-26 22:43:50.086+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 14173
05-26 22:43:50.086+0900 W/AUL_AMD (  496): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-26 22:43:50.091+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 14173
05-26 22:43:51.051+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4268100 button=1 downs=1
05-26 22:43:51.071+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4268121 button=1 downs=0
05-26 22:43:51.561+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4268611 button=1 downs=1
05-26 22:43:51.611+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4268659 button=1 downs=0
05-26 22:43:51.796+0900 W/AUL_AMD (  496): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-26 22:43:52.566+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:52.571+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:52.571+0900 I/efl-extension(14311): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:52.571+0900 I/efl-extension(14311): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45342c98, elm_layout, time_stamp : 4269618
05-26 22:43:52.571+0900 E/TIMER   (14311): (ad->timer) -> _rotary_cb() return
05-26 22:43:52.766+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:52.766+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:52.766+0900 I/efl-extension(14311): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:52.766+0900 I/efl-extension(14311): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45342c98, elm_layout, time_stamp : 4269815
05-26 22:43:52.766+0900 E/TIMER   (14311): (ad->timer) -> _rotary_cb() return
05-26 22:43:53.101+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4270147 button=1 downs=1
05-26 22:43:53.146+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4270196 button=1 downs=0
05-26 22:43:53.146+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:43:53.151+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45342c98, elm_layout, func : 0x41560821
05-26 22:43:53.151+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:43:53.151+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:43:53.151+0900 I/efl-extension(14311): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:43:53.151+0900 I/efl-extension(14311): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:43:53.151+0900 I/efl-extension(14311): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:43:53.156+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:43:53.156+0900 E/EFL     (14311): ecore<14311> ecore.c:574 _ecore_magic_fail() 
05-26 22:43:53.156+0900 E/EFL     (14311): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:43:53.156+0900 E/EFL     (14311): *** IN FUNCTION: ecore_timer_del()
05-26 22:43:53.156+0900 E/EFL     (14311): ecore<14311> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:43:53.156+0900 E/EFL     (14311):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:43:53.156+0900 E/EFL     (14311):     Supplied: 0049a1bd - <UNKNOWN>
05-26 22:43:53.156+0900 E/EFL     (14311): ecore<14311> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:43:53.156+0900 E/EFL     (14311): *** SPANK SPANK SPANK!!!
05-26 22:43:53.156+0900 E/EFL     (14311): *** Now go fix your code. Tut tut tut!
05-26 22:43:53.156+0900 I/SOCKETTEST(14311): Success to create socket
05-26 22:43:53.161+0900 I/SOCKETTEST(14311): Success to socket connection
05-26 22:43:53.161+0900 I/SOCKETTEST(14311): write() 성공
05-26 22:43:53.161+0900 I/TimeRecord(14311): time : 1882153844
05-26 22:43:53.636+0900 I/efl-extension(14311): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x45342c98
05-26 22:43:53.636+0900 I/efl-extension(14311): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45342c98, obj: 0x45342c98
05-26 22:43:53.641+0900 I/efl-extension(14311): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 22:43:58.386+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4275435 button=1 downs=1
05-26 22:43:58.436+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4275484 button=1 downs=0
05-26 22:43:59.136+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:59.136+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:59.236+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:59.236+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:44:00.106+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:44:00.846+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4277895 button=1 downs=1
05-26 22:44:00.896+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4277944 button=1 downs=0
05-26 22:44:00.896+0900 D/TIMER   (14311): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:44:00.896+0900 D/TIMER   (14311): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:44:00.901+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:44:00.901+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4193c9e8, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:44:01.591+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4278638 button=1 downs=1
05-26 22:44:01.686+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4278736 button=1 downs=0
05-26 22:44:02.301+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:44:02.301+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:44:02.301+0900 I/efl-extension(14311): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:44:02.301+0900 I/efl-extension(14311): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4193c9e8, elm_layout, time_stamp : 4279349
05-26 22:44:02.416+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:44:02.416+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:44:02.421+0900 I/efl-extension(14311): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:44:02.421+0900 I/efl-extension(14311): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4193c9e8, elm_layout, time_stamp : 4279468
05-26 22:44:03.426+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4280472 button=1 downs=1
05-26 22:44:03.471+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4280518 button=1 downs=0
05-26 22:44:04.341+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4281388 button=1 downs=1
05-26 22:44:04.441+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4281490 button=1 downs=0
05-26 22:44:04.441+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:44:04.441+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4193c9e8, elm_layout, func : 0x41560821
05-26 22:44:04.441+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:44:04.441+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:44:04.446+0900 I/efl-extension(14311): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:44:04.446+0900 I/efl-extension(14311): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:44:04.446+0900 I/efl-extension(14311): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:44:04.446+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:44:04.446+0900 D/TIMER   (14311): Setting time is 120
05-26 22:44:04.531+0900 I/SOCKETTEST(14311): Success to create socket
05-26 22:44:04.581+0900 I/SOCKETTEST(14311): Success to socket connection
05-26 22:44:04.581+0900 I/SOCKETTEST(14311): write() 성공
05-26 22:44:04.621+0900 I/SENSOR  (14311): 61.389999, -319.690002, 4.340000
05-26 22:44:04.661+0900 I/SENSOR  (14311): 4.130000, -0.770000, 3.920000
05-26 22:44:04.766+0900 I/SENSOR  (14311): 3.430000, -0.980000, 5.390000
05-26 22:44:04.861+0900 I/SENSOR  (14311): 2.590000, -0.910000, 5.040000
05-26 22:44:04.926+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 22:44:04.926+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 22:44:04.966+0900 I/SENSOR  (14311): 3.850000, -0.910000, 5.880000
05-26 22:44:05.071+0900 I/SENSOR  (14311): 2.870000, -0.770000, 6.440000
05-26 22:44:05.166+0900 I/SENSOR  (14311): 2.870000, -1.890000, 26.250000
05-26 22:44:05.271+0900 I/SENSOR  (14311): 3.500000, -0.700000, 4.760000
05-26 22:44:05.366+0900 I/SENSOR  (14311): 3.290000, -1.120000, 4.620000
05-26 22:44:05.466+0900 I/SENSOR  (14311): 3.290000, -1.190000, 4.480000
05-26 22:44:05.571+0900 I/SENSOR  (14311): 3.290000, -1.050000, 4.270000
05-26 22:44:05.701+0900 I/SENSOR  (14311): 3.220000, -1.260000, 4.480000
05-26 22:44:05.761+0900 I/SENSOR  (14311): 3.220000, -0.980000, 4.270000
05-26 22:44:05.871+0900 I/SENSOR  (14311): 3.430000, -0.980000, 4.480000
05-26 22:44:05.971+0900 I/SENSOR  (14311): 3.080000, -1.120000, 4.270000
05-26 22:44:06.066+0900 I/SENSOR  (14311): 3.150000, -1.120000, 4.410000
05-26 22:44:06.166+0900 I/SENSOR  (14311): 3.290000, -1.190000, 4.410000
05-26 22:44:06.271+0900 I/SENSOR  (14311): 3.290000, -1.260000, 4.550000
05-26 22:44:06.371+0900 I/SENSOR  (14311): 3.430000, -0.910000, 4.550000
05-26 22:44:06.466+0900 I/SENSOR  (14311): 3.360000, -0.770000, 4.480000
05-26 22:44:06.571+0900 I/SENSOR  (14311): 3.220000, -1.330000, 4.480000
05-26 22:44:06.716+0900 I/SENSOR  (14311): 3.360000, -0.980000, 4.480000
05-26 22:44:06.781+0900 I/SENSOR  (14311): 3.290000, -1.120000, 4.690000
05-26 22:44:06.866+0900 I/SENSOR  (14311): 3.290000, -1.260000, 4.480000
05-26 22:44:06.976+0900 I/SENSOR  (14311): 3.220000, -1.050000, 4.270000
05-26 22:44:07.071+0900 I/SENSOR  (14311): 3.290000, -1.540000, 4.620000
05-26 22:44:07.171+0900 I/SENSOR  (14311): 3.220000, -1.050000, 4.340000
05-26 22:44:07.271+0900 I/SENSOR  (14311): 3.290000, -1.190000, 4.550000
05-26 22:44:07.371+0900 I/SENSOR  (14311): 3.430000, -0.630000, 4.480000
05-26 22:44:07.466+0900 I/SENSOR  (14311): 2.660000, -1.050000, 3.640000
05-26 22:44:07.571+0900 I/SENSOR  (14311): 2.940000, -1.120000, 4.690000
05-26 22:44:07.736+0900 I/SENSOR  (14311): 3.080000, -1.540000, 5.250000
05-26 22:44:07.766+0900 I/SENSOR  (14311): 3.570000, -0.210000, 3.290000
05-26 22:44:07.871+0900 I/SENSOR  (14311): 2.940000, -0.910000, 4.270000
05-26 22:44:07.976+0900 I/SENSOR  (14311): 3.220000, -1.120000, 4.340000
05-26 22:44:08.071+0900 I/SENSOR  (14311): 3.360000, -1.050000, 4.410000
05-26 22:44:08.171+0900 I/SENSOR  (14311): 3.290000, -1.330000, 5.180000
05-26 22:44:08.271+0900 I/SENSOR  (14311): 3.990000, -0.770000, 4.970000
05-26 22:44:08.366+0900 I/SENSOR  (14311): 3.570000, -1.400000, 5.530000
05-26 22:44:08.466+0900 I/SENSOR  (14311): 3.010000, -0.840000, 4.130000
05-26 22:44:08.571+0900 I/SENSOR  (14311): 3.430000, -0.980000, 3.500000
05-26 22:44:08.691+0900 I/SENSOR  (14311): 3.570000, -1.120000, 4.620000
05-26 22:44:08.766+0900 I/SENSOR  (14311): 3.570000, -0.770000, 4.620000
05-26 22:44:08.866+0900 I/SENSOR  (14311): 3.220000, -1.190000, 4.130000
05-26 22:44:08.976+0900 I/SENSOR  (14311): 2.940000, -0.980000, 4.270000
05-26 22:44:09.071+0900 I/SENSOR  (14311): 3.570000, -0.910000, 3.500000
05-26 22:44:09.176+0900 I/SENSOR  (14311): 3.430000, -0.840000, 4.410000
05-26 22:44:09.276+0900 I/SENSOR  (14311): 3.290000, -0.980000, 4.340000
05-26 22:44:09.371+0900 I/SENSOR  (14311): 3.360000, -0.910000, 4.480000
05-26 22:44:09.471+0900 I/SENSOR  (14311): 3.500000, -1.120000, 4.620000
05-26 22:44:09.571+0900 I/SENSOR  (14311): 3.360000, -0.840000, 4.270000
05-26 22:44:09.696+0900 I/SENSOR  (14311): 2.940000, -1.400000, 4.620000
05-26 22:44:09.766+0900 I/SENSOR  (14311): 3.640000, -0.700000, 4.620000
05-26 22:44:09.871+0900 I/SENSOR  (14311): 3.640000, -0.910000, 4.340000
05-26 22:44:09.981+0900 I/SENSOR  (14311): 3.990000, -1.330000, 4.200000
05-26 22:44:10.086+0900 E/EFL     (14311): evas_main<14311> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4287133 button=1 downs=1
05-26 22:44:10.091+0900 I/SENSOR  (14311): 2.520000, -1.750000, 5.950000
05-26 22:44:10.146+0900 E/EFL     (14311): evas_main<14311> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4287196 button=1 downs=0
05-26 22:44:10.146+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:44:10.146+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4193c9e8, elm_layout, func : 0x41560821
05-26 22:44:10.146+0900 I/efl-extension(14311): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:44:10.166+0900 I/SOCKETTEST(14311): Success to create socket
05-26 22:44:10.191+0900 I/SOCKETTEST(14311): Success to socket connection
05-26 22:44:10.191+0900 I/SOCKETTEST(14311): write() 성공
05-26 22:44:10.191+0900 I/TimeRecord(14311): time : 5
05-26 22:44:10.671+0900 I/efl-extension(14311): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4193c9e8
05-26 22:44:10.671+0900 I/efl-extension(14311): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4193c9e8, obj: 0x4193c9e8
05-26 22:44:10.676+0900 I/efl-extension(14311): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 22:44:52.176+0900 E/PKGMGR_SERVER(14740): pkgmgr-server.c: main(2131) > package manager server start
05-26 22:44:52.266+0900 E/PKGMGR_SERVER(14740): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_-23295725], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[6b4rnQ/beGBzDjCqJH8Oo8OmmUU=], backend_flag=[0]
05-26 22:44:52.271+0900 E/PKGMGR_SERVER(14742): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-26 22:44:52.276+0900 E/PKGMGR  (14734): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-26 22:44:52.346+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:44:52.356+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14311
05-26 22:44:52.356+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:44:52.361+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 5
05-26 22:44:52.366+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(14311), cmd(4)
05-26 22:44:52.366+0900 I/APP_CORE(14311): appcore-efl.c: __do_app(429) > [APP 14311] Event: TERMINATE State: RUNNING
05-26 22:44:52.366+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 22:44:52.366+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 22:44:52.371+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:44:52.381+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14311
05-26 22:44:52.446+0900 I/APP_CORE(14311): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 22:44:52.446+0900 I/CAPI_APPFW_APPLICATION(14311): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 22:44:52.476+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:44:52.476+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 22:44:52.481+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:44:52.491+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14311
05-26 22:44:52.556+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 22:44:52.561+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 22:44:52.561+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:44:52.561+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:44:52.566+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 22:44:52.566+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 22:44:52.566+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:44:52.566+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:44:52.566+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 22:44:52.566+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:44:52.566+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 22:44:52.571+0900 I/UXT     (14311): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 22:44:52.591+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(0)
05-26 22:44:52.591+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 22:44:52.591+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:44:52.591+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(0)
05-26 22:44:52.591+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:44:52.606+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14311
05-26 22:44:52.606+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESUME State: PAUSED
05-26 22:44:52.606+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 22:44:52.606+0900 W/W_HOME  (  737): main.c: _appcore_resume_cb(681) > appcore resume
05-26 22:44:52.606+0900 W/W_HOME  (  737): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 22:44:52.606+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:44:52.611+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:44:52.611+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:44:52.611+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:44:52.611+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 22:44:52.611+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:44:52.611+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:44:52.631+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 22:44:52.631+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:44:52.631+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 22:44:52.631+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:44:52.631+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:44:52.631+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:44:52.631+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:44:52.706+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:44:52.721+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14311
05-26 22:44:52.826+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:44:52.846+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14311
05-26 22:44:52.951+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:44:52.961+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14311
05-26 22:44:53.051+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 22:44:53.066+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:44:53.071+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 22:44:53.076+0900 E/PKGMGR_SERVER(14742): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-26 22:44:53.091+0900 E/PKGMGR_SERVER(14740): pkgmgr-server.c: sighandler(409) > child NORMAL exit [14742]
05-26 22:44:53.236+0900 W/CRASH_MANAGER(14747): worker.c: worker_job(1199) > 1114311706831146427029
