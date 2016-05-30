S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 28859
Date: 2016-05-26 21:26:07+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x43902408, r5   = 0x41461d61
r6   = 0x43902d08, r7   = 0x40003ac4
r8   = 0x00000000, r9   = 0x43901688
r10  = 0x41f5c488, fp   = 0x00000000
ip   = 0x4143b490, sp   = 0xbe9eb630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     14576 KB
Buffers:     47036 KB
Cached:     130200 KB
VmPeak:     100024 KB
VmSize:      93760 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25956 KB
VmRSS:       23592 KB
VmData:      39344 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23960 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 28859 TID = 28859
28859 28876 28931 

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
41c64000 41c66000 r-xp /usr/lib/libdri2.so.0.0.0
41c6e000 41c8f000 r-xp /usr/lib/libexif.so.12.3.3
41ca2000 41ca7000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41caf000 41d79000 r-xp /usr/lib/libCOREGL.so.4.0
41d9f000 41da3000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41e32000 41f64000 rw-p [heap]
4391d000 4411c000 rwxp [stack:28931]
44b4f000 44b52000 r-xp /usr/lib/libpulse-simple.so.0.0.4
44bc5000 44bfd000 r-xp /usr/lib/libpulse.so.0.16.2
44c94000 45493000 rwxp [stack:28876]
4598f000 45994000 r-xp /usr/lib/libjson.so.0.0.1
4599c000 459e4000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
459e5000 45a28000 r-xp /usr/lib/libsndfile.so.1.0.25
45a35000 45a57000 r-xp /usr/lib/libvorbis.so.0.4.3
45a5f000 45a63000 r-xp /usr/lib/libogg.so.0.7.1
be9cb000 be9ec000 rwxp [stack]
End of Maps Information

Callstack Information (PID:28859)
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
direction: Clockwise
05-26 21:18:45.584+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.584+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.589+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.609+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.609+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.614+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.629+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.634+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.634+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.654+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.654+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.654+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.679+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.679+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.679+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.699+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.699+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.699+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.749+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.749+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:45.754+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:46.934+0900 E/EFL     (28859): evas_main<28859> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13237420 button=1 downs=1
05-26 21:18:47.014+0900 E/EFL     (28859): evas_main<28859> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13237502 button=1 downs=0
05-26 21:18:47.019+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:18:47.019+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x438dd098, elm_layout, func : 0x414608b1
05-26 21:18:47.019+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:18:47.019+0900 D/TIMER   (28859): Setting time is 0
05-26 21:18:47.019+0900 E/TIMER   (28859): (!ad->setting_time) -> _start_clicked_cb() return
05-26 21:18:47.439+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.439+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.439+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.479+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.479+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.479+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.504+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.504+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.504+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.534+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.534+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.534+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.559+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.559+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.559+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.589+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.589+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:47.594+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:48.639+0900 I/efl-extension(28859): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x438dd098
05-26 21:18:48.639+0900 I/efl-extension(28859): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x438dd098, obj: 0x438dd098
05-26 21:18:48.639+0900 I/efl-extension(28859): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:18:48.874+0900 E/EFL     (28859): evas_main<28859> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13239355 button=1 downs=1
05-26 21:18:48.884+0900 E/EFL     (28859): evas_main<28859> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13239370 button=1 downs=0
05-26 21:18:48.884+0900 D/TIMER   (28859): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:18:48.884+0900 D/TIMER   (28859): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:18:48.894+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:18:48.894+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x438261f0, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:18:49.524+0900 E/EFL     (28859): evas_main<28859> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13240009 button=1 downs=1
05-26 21:18:49.579+0900 E/EFL     (28859): evas_main<28859> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13240068 button=1 downs=0
05-26 21:18:50.004+0900 E/EFL     (28859): evas_main<28859> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13240491 button=1 downs=1
05-26 21:18:50.059+0900 E/EFL     (28859): evas_main<28859> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13240546 button=1 downs=0
05-26 21:18:50.649+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.649+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.649+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.654+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.654+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241135
05-26 21:18:50.694+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.699+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.699+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.699+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.699+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241182
05-26 21:18:50.729+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.729+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.734+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.734+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241216
05-26 21:18:50.744+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.769+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.769+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.769+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.769+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.769+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241255
05-26 21:18:50.814+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.814+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.814+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.814+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.814+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241298
05-26 21:18:50.859+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.859+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.864+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.864+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.864+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241347
05-26 21:18:50.989+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.989+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.989+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:50.989+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241474
05-26 21:18:50.989+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.044+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.044+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.044+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.044+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.044+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241530
05-26 21:18:51.084+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.084+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.084+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.084+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.084+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241571
05-26 21:18:51.139+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.139+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.144+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.144+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.144+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241627
05-26 21:18:51.194+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.194+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.194+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.199+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241682
05-26 21:18:51.199+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.234+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.234+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.234+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.234+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241722
05-26 21:18:51.239+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.279+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.279+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.279+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.284+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.284+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241766
05-26 21:18:51.414+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.414+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.414+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241901
05-26 21:18:51.414+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.419+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.474+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.474+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241958
05-26 21:18:51.474+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.474+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.474+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.504+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.504+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.509+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.509+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.509+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13241992
05-26 21:18:51.539+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.539+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.539+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13242023
05-26 21:18:51.539+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.539+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.569+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.569+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.569+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13242057
05-26 21:18:51.569+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.574+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.604+0900 I/efl-extension(28859): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.604+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.604+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:18:51.609+0900 I/efl-extension(28859): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x438261f0, elm_layout, time_stamp : 13242092
05-26 21:18:51.609+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:19:00.679+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 21:19:00.679+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 21:19:00.684+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : pedometer_inactive_period error
05-26 21:19:00.689+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:19:00.689+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:19:00.689+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_10min_precaution_millisec error
05-26 21:19:00.694+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:19:00.694+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:19:00.699+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_before_10min_precaution_millisec error
05-26 21:19:00.939+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:19:03.694+0900 E/EFL     (28859): evas_main<28859> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13254177 button=1 downs=1
05-26 21:19:03.779+0900 E/EFL     (28859): evas_main<28859> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13254267 button=1 downs=0
05-26 21:19:05.034+0900 E/EFL     (28859): evas_main<28859> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13255516 button=1 downs=1
05-26 21:19:05.119+0900 E/EFL     (28859): evas_main<28859> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13255606 button=1 downs=0
05-26 21:19:05.119+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:19:05.119+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x438261f0, elm_layout, func : 0x414608b1
05-26 21:19:05.119+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:19:05.119+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:19:05.119+0900 I/efl-extension(28859): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:19:05.124+0900 I/efl-extension(28859): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:19:05.124+0900 I/efl-extension(28859): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:19:05.124+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:19:05.124+0900 D/TIMER   (28859): Setting time is 19
05-26 21:19:05.214+0900 I/SOCKETTEST(28859): Success to create socket
05-26 21:19:05.219+0900 I/SOCKETTEST(28859): Success to socket connection
05-26 21:19:05.219+0900 I/SOCKETTEST(28859): write() 성공
05-26 21:19:05.269+0900 I/SENSOR  (28859): -18.129999, 14.140000, 6.370000
05-26 21:19:05.314+0900 I/SENSOR  (28859): -5.670000, -6.160000, 9.450000
05-26 21:19:05.414+0900 I/SENSOR  (28859): -1.120000, -3.150000, 4.130000
05-26 21:19:05.519+0900 I/SENSOR  (28859): -3.430000, -4.410000, 5.460000
05-26 21:19:05.694+0900 I/SENSOR  (28859): -1.190000, -4.270000, 4.060000
05-26 21:19:05.714+0900 I/SENSOR  (28859): 0.560000, -4.270000, 1.890000
05-26 21:19:05.814+0900 I/SENSOR  (28859): -5.250000, -2.870000, 7.490000
05-26 21:19:05.999+0900 I/SENSOR  (28859): -1.610000, -2.450000, 5.460000
05-26 21:19:06.014+0900 I/SENSOR  (28859): -9.520000, 4.690000, 8.190000
05-26 21:19:06.119+0900 I/SENSOR  (28859): -11.410000, 19.740000, 13.020000
05-26 21:19:06.319+0900 I/SENSOR  (28859): -5.880000, 9.450000, 12.040000
05-26 21:19:06.319+0900 I/SENSOR  (28859): 0.420000, -1.400000, 3.220000
05-26 21:19:06.419+0900 I/SENSOR  (28859): 16.660000, -25.690001, -6.930000
05-26 21:19:06.644+0900 I/SENSOR  (28859): 21.000000, -30.100000, -8.820000
05-26 21:19:06.644+0900 I/SENSOR  (28859): -9.590000, -15.120000, 2.660000
05-26 21:19:06.694+0900 E/EFL     (28859): evas_main<28859> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13257179 button=1 downs=1
05-26 21:19:06.704+0900 E/EFL     (28859): evas_main<28859> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13257191 button=1 downs=0
05-26 21:19:06.714+0900 I/SENSOR  (28859): -24.990000, 19.389999, 18.760000
05-26 21:19:06.884+0900 I/SENSOR  (28859): -4.410000, 4.130000, 8.750000
05-26 21:19:06.914+0900 I/SENSOR  (28859): -2.940000, -4.760000, 5.530000
05-26 21:19:07.019+0900 I/SENSOR  (28859): -3.290000, -3.850000, 5.530000
05-26 21:19:07.124+0900 I/SENSOR  (28859): 0.140000, -5.250000, 4.410000
05-26 21:19:07.249+0900 I/SENSOR  (28859): -3.430000, -2.450000, 5.040000
05-26 21:19:07.319+0900 I/SENSOR  (28859): -2.240000, -2.940000, 5.530000
05-26 21:19:07.424+0900 I/SENSOR  (28859): -1.820000, -5.670000, 5.180000
05-26 21:19:07.569+0900 I/SENSOR  (28859): -1.750000, -3.640000, 3.710000
05-26 21:19:07.619+0900 I/SENSOR  (28859): -1.540000, -4.060000, 5.390000
05-26 21:19:07.724+0900 I/SENSOR  (28859): -1.540000, -6.090000, 5.180000
05-26 21:19:07.884+0900 I/SENSOR  (28859): -1.400000, -3.220000, 5.040000
05-26 21:19:07.919+0900 I/SENSOR  (28859): 0.630000, -5.670000, 2.450000
05-26 21:19:08.024+0900 I/SENSOR  (28859): 4.620000, -7.980000, -0.560000
05-26 21:19:08.189+0900 I/SENSOR  (28859): 5.810000, -10.640000, 0.700000
05-26 21:19:08.219+0900 I/SENSOR  (28859): -10.850000, 4.830000, 6.790000
05-26 21:19:08.259+0900 E/EFL     (28859): evas_main<28859> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13258722 button=1 downs=1
05-26 21:19:08.299+0900 E/EFL     (28859): evas_main<28859> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13258786 button=1 downs=0
05-26 21:19:08.319+0900 I/SENSOR  (28859): -13.580000, 9.940000, 12.180000
05-26 21:19:08.419+0900 I/SENSOR  (28859): -8.890000, 0.700000, 10.570000
05-26 21:19:08.519+0900 I/SENSOR  (28859): 0.630000, -2.800000, 3.430000
05-26 21:19:08.624+0900 I/SENSOR  (28859): -1.190000, -2.520000, 5.250000
05-26 21:19:08.839+0900 I/SENSOR  (28859): -1.960000, -3.010000, 4.410000
05-26 21:19:08.839+0900 I/SENSOR  (28859): -2.030000, -3.640000, 5.530000
05-26 21:19:08.919+0900 I/SENSOR  (28859): 0.840000, -3.150000, 4.480000
05-26 21:19:09.154+0900 I/SENSOR  (28859): -1.260000, -3.850000, 5.390000
05-26 21:19:09.154+0900 I/SENSOR  (28859): 1.260000, -5.460000, 3.780000
05-26 21:19:09.219+0900 I/SENSOR  (28859): 0.700000, -5.110000, 3.780000
05-26 21:19:09.319+0900 I/SENSOR  (28859): 1.470000, -4.970000, 2.380000
05-26 21:19:09.419+0900 I/SENSOR  (28859): -2.520000, -5.250000, 3.360000
05-26 21:19:09.519+0900 I/SENSOR  (28859): -0.700000, -5.740000, 5.600000
05-26 21:19:09.624+0900 I/SENSOR  (28859): -2.450000, -2.870000, 2.240000
05-26 21:19:09.784+0900 I/SENSOR  (28859): -0.910000, -3.640000, 4.760000
05-26 21:19:09.819+0900 I/SENSOR  (28859): -0.140000, -2.870000, 5.040000
05-26 21:19:09.924+0900 I/SENSOR  (28859): -0.490000, -4.340000, 4.900000
05-26 21:19:10.109+0900 I/SENSOR  (28859): -1.680000, -3.220000, 4.480000
05-26 21:19:10.124+0900 I/SENSOR  (28859): -0.070000, -2.730000, 3.430000
05-26 21:19:10.219+0900 I/SENSOR  (28859): -1.750000, -4.340000, 5.110000
05-26 21:19:10.324+0900 I/SENSOR  (28859): 0.490000, -3.640000, 3.850000
05-26 21:19:10.419+0900 I/SENSOR  (28859): -1.960000, -1.540000, 2.660000
05-26 21:19:10.524+0900 I/SENSOR  (28859): 1.470000, -3.990000, 5.180000
05-26 21:19:10.724+0900 I/SENSOR  (28859): 0.700000, -4.900000, 4.130000
05-26 21:19:10.724+0900 I/SENSOR  (28859): 19.250000, 0.280000, -1.750000
05-26 21:19:10.774+0900 E/EFL     (28859): evas_main<28859> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=13261259 button=1 downs=1
05-26 21:19:10.819+0900 I/SENSOR  (28859): -0.700000, -0.980000, 8.680000
05-26 21:19:10.824+0900 E/EFL     (28859): evas_main<28859> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=13261312 button=1 downs=0
05-26 21:19:10.824+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:19:10.824+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x438261f0, elm_layout, func : 0x414608b1
05-26 21:19:10.824+0900 I/efl-extension(28859): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:19:10.824+0900 I/efl-extension(28859): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:19:10.824+0900 I/efl-extension(28859): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:19:10.824+0900 I/efl-extension(28859): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:19:10.844+0900 I/SOCKETTEST(28859): Success to create socket
05-26 21:19:10.849+0900 I/SOCKETTEST(28859): Success to socket connection
05-26 21:19:10.849+0900 I/SOCKETTEST(28859): write() 성공
05-26 21:19:10.854+0900 I/secondTime(28859): 100
05-26 21:19:10.854+0900 W/efl-extension(28859): efl_extension_events.c: eext_object_event_callback_del(319) > This object(0x438261f0) hasn't been registered before
05-26 21:19:12.444+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:19:12.444+0900 I/efl-extension(28292): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:19:12.449+0900 I/efl-extension(28321): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:19:30.479+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:19:30.479+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:19:36.519+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 21:19:43.434+0900 E/WMS     (  469): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-26 21:19:43.439+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-26 21:19:43.439+0900 E/WMS     (  469): ==========
05-26 21:19:43.439+0900 E/WMS     (  469): ##WMS SEND : mgr_gear_wear_onoff_req
05-26 21:19:43.439+0900 E/WMS     (  469): ==========
05-26 21:19:43.449+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1746) > No service connection to host. Skipping this message.
05-26 21:19:43.529+0900 W/SHealth_Service( 1056): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-26 21:19:43.529+0900 E/SHealth_Service( 1056): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-26 21:20:00.659+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 21:20:00.659+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 21:20:00.664+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : pedometer_inactive_period error
05-26 21:20:00.669+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:20:00.669+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:20:00.674+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_10min_precaution_millisec error
05-26 21:20:00.674+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:20:00.679+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:20:00.679+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_before_10min_precaution_millisec error
05-26 21:20:00.994+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:20:30.514+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:20:30.514+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:20:30.514+0900 I/RESOURCED(  475): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-26 21:20:36.529+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 21:20:43.684+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 21:21:00.064+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:21:12.514+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 48 -> 47 1464265272 210
05-26 21:21:12.524+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 47 1193 310 935
05-26 21:21:12.529+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 47 0 0 807
05-26 21:21:12.529+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 47 1177 251 922
05-26 21:21:12.529+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 47 373 5 292
05-26 21:21:12.529+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 47 389 29 305
05-26 21:21:30.494+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:21:30.494+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:22:00.134+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:22:30.514+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:22:30.514+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:23:00.199+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:23:30.514+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:23:30.514+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:24:00.269+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:24:12.869+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 47 -> 46 1464265452 180
05-26 21:24:12.869+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 1190 311 912
05-26 21:24:12.869+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 0 0 785
05-26 21:24:12.869+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 1173 252 899
05-26 21:24:12.869+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 258 5 198
05-26 21:24:12.869+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 383 30 294
05-26 21:24:30.494+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:24:30.494+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:25:00.339+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:25:30.514+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:25:30.514+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:26:00.409+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:26:07.029+0900 E/PKGMGR_SERVER(29031): pkgmgr-server.c: main(2131) > package manager server start
05-26 21:26:07.124+0900 E/PKGMGR_SERVER(29031): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_-453472387], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[0qUQBpc8WxlljIAVp8rZRlAvUYo=], backend_flag=[0]
05-26 21:26:07.129+0900 E/PKGMGR_SERVER(29033): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-26 21:26:07.134+0900 E/PKGMGR  (29025): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-26 21:26:07.209+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:26:07.214+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28859
05-26 21:26:07.219+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:26:07.219+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 5
05-26 21:26:07.224+0900 W/AUL_AMD (  474): amd_launch.c: __reply_handler(916) > listen fd(22) , send fd(21), pid(28859), cmd(4)
05-26 21:26:07.224+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:26:07.229+0900 I/APP_CORE(28859): appcore-efl.c: __do_app(429) > [APP 28859] Event: TERMINATE State: RUNNING
05-26 21:26:07.234+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28859
05-26 21:26:07.234+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 21:26:07.234+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 21:26:07.304+0900 I/APP_CORE(28859): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 21:26:07.304+0900 I/CAPI_APPFW_APPLICATION(28859): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 21:26:07.329+0900 I/efl-extension(28859): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x438261f0
05-26 21:26:07.329+0900 I/efl-extension(28859): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x438261f0, obj: 0x438261f0
05-26 21:26:07.329+0900 I/efl-extension(28859): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:26:07.334+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:26:07.334+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:26:07.339+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:26:07.349+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28859
05-26 21:26:07.414+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 21:26:07.414+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 21:26:07.414+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 21:26:07.414+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 21:26:07.414+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 21:26:07.414+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 21:26:07.414+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 21:26:07.414+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:26:07.414+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:26:07.414+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:26:07.414+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 21:26:07.429+0900 I/UXT     (28859): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 21:26:07.439+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-26 21:26:07.439+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 21:26:07.439+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:26:07.439+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-26 21:26:07.439+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESUME State: PAUSED
05-26 21:26:07.439+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 21:26:07.439+0900 W/W_HOME  (  726): main.c: _appcore_resume_cb(681) > appcore resume
05-26 21:26:07.439+0900 W/W_HOME  (  726): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 21:26:07.439+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:26:07.439+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:26:07.439+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:26:07.439+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:26:07.439+0900 W/W_HOME  (  726): rotary.c: rotary_attach(138) > rotary_attach:0x478904a8
05-26 21:26:07.439+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x478904a8, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-26 21:26:07.439+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:26:07.444+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 21:26:07.444+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:26:07.444+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 21:26:07.444+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:26:07.444+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:26:07.444+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:26:07.444+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:26:07.449+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:26:07.459+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28859
05-26 21:26:07.559+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:26:07.579+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28859
05-26 21:26:07.684+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:26:07.719+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28859
05-26 21:26:07.824+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:26:07.839+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28859
05-26 21:26:07.904+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 21:26:07.939+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:26:07.949+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 21:26:07.959+0900 E/PKGMGR_SERVER(29033): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-26 21:26:07.974+0900 E/PKGMGR_SERVER(29031): pkgmgr-server.c: sighandler(409) > child NORMAL exit [29033]
05-26 21:26:08.079+0900 W/CRASH_MANAGER(29038): worker.c: worker_job(1199) > 1128859706831146426556
