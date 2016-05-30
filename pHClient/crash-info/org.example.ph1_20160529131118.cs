S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 9784
Date: 2016-05-29 13:11:18+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2f656a64

Register Information
r0   = 0x00000000, r1   = 0x41431708
r2   = 0x41431700, r3   = 0x00000000
r4   = 0x6c706d61, r5   = 0x68702e65
r6   = 0x65722f31, r7   = 0x652f2f73
r8   = 0x449b4dd8, r9   = 0x449b4358
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4142def4, sp   = 0xbec8d658
lr   = 0x400953f8, pc   = 0x2f656a64
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     33632 KB
Buffers:     49484 KB
Cached:     104088 KB
VmPeak:      98652 KB
VmSize:      63160 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23560 KB
VmRSS:       19412 KB
VmData:      34844 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       19688 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9784 TID = 9784
9784 9812 

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
41545000 4154a000 r-xp /usr/lib/libappcore-common.so.1.1
41552000 41554000 r-xp /usr/lib/libiniparser.so.0
41572000 41576000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4157f000 41581000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4158a000 41590000 r-xp /usr/lib/libappsvc.so.0.1.0
41598000 415bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415c5000 41694000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416aa000 416b4000 r-xp /lib/libnss_files-2.13.so
41b96000 41b9d000 r-xp /usr/lib/libtbm.so.1.0.0
41e39000 41e41000 r-xp /usr/lib/libdrm.so.2.4.0
433eb000 433ed000 r-xp /usr/lib/libdri2.so.0.0.0
43436000 43500000 r-xp /usr/lib/libCOREGL.so.4.0
43857000 4385b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44898000 4489d000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
44a74000 45273000 rwxp [stack:9812]
4596c000 4596f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45c19000 45c51000 r-xp /usr/lib/libpulse.so.0.16.2
45cb0000 45cb5000 r-xp /usr/lib/libjson.so.0.0.1
45cbd000 45d05000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45d06000 45d49000 r-xp /usr/lib/libsndfile.so.1.0.25
45d56000 45d78000 r-xp /usr/lib/libvorbis.so.0.4.3
45d80000 45d84000 r-xp /usr/lib/libogg.so.0.7.1
bec6d000 bec8e000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9784)
Call Stack Count: 1
 0: (0x2f656a64) (null)
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
sion( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14305355
05-29 13:11:12.041+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.041+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.041+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.066+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 13:11:12.066+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 13:11:12.326+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.326+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.326+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14305639
05-29 13:11:12.326+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.326+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.326+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.371+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.371+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.371+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14305684
05-29 13:11:12.371+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.371+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.371+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.411+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.411+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.411+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14305722
05-29 13:11:12.411+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.411+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.411+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.451+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.451+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.451+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14305765
05-29 13:11:12.451+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.451+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.451+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.501+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.501+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.501+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14305814
05-29 13:11:12.501+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.501+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.501+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.581+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.581+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.581+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14305896
05-29 13:11:12.581+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.581+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.581+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 13:11:12.801+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.801+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.801+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14306114
05-29 13:11:12.801+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.801+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.801+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.831+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.831+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.831+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14306142
05-29 13:11:12.831+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.831+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.831+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.856+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.856+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.856+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14306167
05-29 13:11:12.856+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.856+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.856+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.881+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.881+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.881+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14306193
05-29 13:11:12.881+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.881+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.881+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.926+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.926+0900 I/efl-extension( 9784): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.926+0900 I/efl-extension( 9784): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4192fc30, elm_layout, time_stamp : 14306238
05-29 13:11:12.926+0900 E/TIMER   ( 9784): (!ad->selected) -> _rotary_cb() return
05-29 13:11:12.926+0900 I/efl-extension( 9012): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:12.926+0900 I/efl-extension( 8929): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 13:11:13.811+0900 I/efl-extension( 9784): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4192fc30
05-29 13:11:13.811+0900 I/efl-extension( 9784): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4192fc30, obj: 0x4192fc30
05-29 13:11:13.811+0900 I/efl-extension( 9784): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 13:11:13.811+0900 I/efl-extension( 9784): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 13:11:13.811+0900 I/efl-extension( 9784): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 13:11:13.811+0900 I/efl-extension( 9784): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 13:11:15.896+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-29 13:11:15.896+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-29 13:11:15.901+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-29 13:11:15.901+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-29 13:11:16.026+0900 W/STARTER (  682): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-29 13:11:16.091+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-29 13:11:16.091+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-29 13:11:16.096+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-29 13:11:16.096+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-29 13:11:16.216+0900 W/STARTER (  682): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-29 13:11:16.481+0900 W/STARTER (  682): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-29 13:11:16.481+0900 W/STARTER (  682): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-29 13:11:16.511+0900 E/STARTER (  682): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-29 13:11:16.511+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 13:11:16.521+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 682
05-29 13:11:16.531+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 13:11:16.531+0900 W/AUL_PAD (13314): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 13:11:16.531+0900 W/AUL_PAD (13314): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 13:11:16.546+0900 E/RESOURCED(  488): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 13:11:16.546+0900 I/CAPI_APPFW_APPLICATION( 9645): app_main.c: app_efl_main(129) > app_efl_main
05-29 13:11:16.551+0900 I/CAPI_APPFW_APPLICATION( 9645): app_main.c: app_appcore_create(152) > app_appcore_create
05-29 13:11:16.636+0900 E/AUL     (  682): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 13:11:16.636+0900 E/RESOURCED(  488): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-29 13:11:16.721+0900 I/efl-extension( 9645): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445b5b80 = w: 0 h: 0  obj 0x445bf318 w: 360 h: 360
05-29 13:11:16.721+0900 I/efl-extension( 9645): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 13:11:16.726+0900 I/efl-extension( 9645): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 13:11:16.726+0900 I/efl-extension( 9645): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-29 13:11:16.726+0900 I/efl-extension( 9645): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-29 13:11:16.726+0900 I/efl-extension( 9645): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-29 13:11:16.726+0900 I/efl-extension( 9645): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445bf318, elm_image, _activated_obj : 0x0, activated : 1
05-29 13:11:16.826+0900 E/W_TASKMANAGER( 9645): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-29 13:11:16.826+0900 E/W_TASKMANAGER( 9645): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-29 13:11:16.826+0900 E/W_TASKMANAGER( 9645): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-29 13:11:16.871+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.871+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.876+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.876+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.876+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.876+0900 E/W_TASKMANAGER( 9645): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 13:11:16.876+0900 E/RUA     ( 9645): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 23, ncols : 5
05-29 13:11:16.921+0900 E/EFL     ( 9645): elementary<9645> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c0f98 into part 'elm.swallow.event.0'
05-29 13:11:16.966+0900 E/E17     (  382): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03600003)
05-29 13:11:16.966+0900 I/APP_CORE( 9645): appcore-efl.c: __do_app(429) > [APP 9645] Event: RESET State: CREATED
05-29 13:11:16.966+0900 I/CAPI_APPFW_APPLICATION( 9645): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 13:11:16.986+0900 I/APP_CORE( 9645): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 13:11:16.986+0900 I/APP_CORE( 9645): appcore-efl.c: __do_app(474) > [APP 9645] Initial Launching, call the resume_cb
05-29 13:11:16.986+0900 I/CAPI_APPFW_APPLICATION( 9645): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 13:11:17.031+0900 W/APP_CORE( 9645): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600003
05-29 13:11:17.036+0900 E/E17     (  382): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x03600003)
05-29 13:11:17.111+0900 I/APP_CORE( 9784): appcore-efl.c: __do_app(429) > [APP 9784] Event: PAUSE State: RUNNING
05-29 13:11:17.111+0900 I/CAPI_APPFW_APPLICATION( 9784): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 13:11:17.126+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 13:11:17.126+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 13:11:17.136+0900 I/APP_CORE( 9645): appcore-efl.c: __do_app(429) > [APP 9645] Event: RESUME State: RUNNING
05-29 13:11:17.526+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 13:11:17.551+0900 E/EFL     ( 9645): evas_main<9645> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=14310859 button=1 downs=1
05-29 13:11:17.571+0900 I/MALI    ( 9645): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-29 13:11:17.646+0900 E/EFL     ( 9645): evas_main<9645> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=14310955 button=1 downs=0
05-29 13:11:17.676+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 13:11:17.686+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9645
05-29 13:11:17.691+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 13:11:17.856+0900 E/EFL     ( 9645): elementary<9645> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573e88), freeze(1)
05-29 13:11:17.856+0900 E/EFL     ( 9645): elementary<9645> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573e88), freeze(1)
05-29 13:11:18.211+0900 I/efl-extension( 9988): efl_extension.c: eext_mod_init(40) > Init
05-29 13:11:18.231+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 13:11:18.241+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8929
05-29 13:11:18.241+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 27
05-29 13:11:18.246+0900 I/APP_CORE( 8929): appcore-efl.c: __do_app(429) > [APP 8929] Event: TERMINATE State: PAUSED
05-29 13:11:18.251+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 13:11:18.251+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 13:11:18.266+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 13:11:18.271+0900 I/UXT     ( 9988): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-29 13:11:18.276+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9784
05-29 13:11:18.281+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 27
05-29 13:11:18.306+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 13:11:18.306+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 13:11:18.306+0900 I/APP_CORE( 9784): appcore-efl.c: __do_app(429) > [APP 9784] Event: TERMINATE State: PAUSED
05-29 13:11:18.306+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 13:11:18.306+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 13:11:18.316+0900 E/APP_CORE( 9645): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 13:11:18.316+0900 I/APP_CORE( 9645): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 13:11:18.316+0900 I/APP_CORE( 9645): appcore-efl.c: __after_loop(1090) > [APP 9645] PAUSE before termination
05-29 13:11:18.316+0900 I/CAPI_APPFW_APPLICATION( 9645): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 13:11:18.316+0900 I/CAPI_APPFW_APPLICATION( 9645): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-29 13:11:18.321+0900 I/efl-extension( 9645): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44573e88, obj: 0x44573e88
05-29 13:11:18.321+0900 I/efl-extension( 9645): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 13:11:18.321+0900 I/efl-extension( 9645): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 13:11:18.321+0900 I/efl-extension( 9645): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 13:11:18.321+0900 I/efl-extension( 9645): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 13:11:18.336+0900 I/efl-extension( 9645): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445bf318
05-29 13:11:18.336+0900 I/efl-extension( 9645): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 13:11:18.336+0900 I/efl-extension( 9645): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445b5b80 is freed
05-29 13:11:18.336+0900 I/efl-extension( 9645): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 13:11:18.336+0900 I/efl-extension( 9645): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44573e88, elm_scroller, func : 0x437c8ef1
05-29 13:11:18.336+0900 I/efl-extension( 9645): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 13:11:18.336+0900 I/efl-extension( 9645): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 13:11:18.336+0900 I/efl-extension( 9645): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445bf318, elm_image, func : 0x437c8ef1
05-29 13:11:18.336+0900 I/efl-extension( 9645): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 13:11:18.336+0900 I/efl-extension( 9645): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44573e88 : elm_scroller] rotary callabck is deleted
05-29 13:11:18.376+0900 E/APP_CORE( 8929): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 13:11:18.376+0900 I/APP_CORE( 8929): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 13:11:18.376+0900 I/CAPI_APPFW_APPLICATION( 8929): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-29 13:11:18.396+0900 I/APP_CORE( 9784): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 13:11:18.396+0900 I/CAPI_APPFW_APPLICATION( 9784): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-29 13:11:18.421+0900 W/APP_CORE( 9012): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:5600003
05-29 13:11:18.421+0900 I/efl-extension( 9784): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 13:11:18.421+0900 I/efl-extension( 9784): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x41922980 is freed
05-29 13:11:18.421+0900 I/efl-extension( 9784): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x449523c8 is freed
05-29 13:11:18.421+0900 I/efl-extension( 9784): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45666a28 is freed
05-29 13:11:18.421+0900 I/efl-extension( 9784): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x41923f90 is freed
05-29 13:11:18.421+0900 I/efl-extension( 9784): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44932bb8 is freed
05-29 13:11:18.421+0900 I/efl-extension( 9784): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45301dd8 is freed
05-29 13:11:18.446+0900 W/PROCESSMGR(  382): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-29 13:11:18.446+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-29 13:11:18.446+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-29 13:11:18.446+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 13:11:18.446+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 13:11:18.446+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 13:11:18.456+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 13:11:18.456+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x45107550], circle_obj[0x45131938]!
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x45384790 = w: 0 h: 0  obj 0x45107550 w: 360 h: 360
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4535ba68 is freed
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x454042b0], circle_obj[0x45408fd8]!
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x4541ea78 = w: 0 h: 0  obj 0x454042b0 w: 360 h: 360
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x459a71f8 is freed
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x43b38d80 is freed
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x43b2a3c8, obj: 0x43b2a3c8
05-29 13:11:18.466+0900 I/efl-extension( 8929): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 13:11:18.501+0900 I/MALI    ( 9645): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-29 13:11:18.521+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 13:11:18.521+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45384790 is freed
05-29 13:11:18.521+0900 I/efl-extension( 8929): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 13:11:18.521+0900 I/efl-extension( 8929): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x43b2a3c8, elm_genlist, func : 0x41973dfd
05-29 13:11:18.521+0900 I/efl-extension( 8929): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 13:11:18.536+0900 I/MALI    ( 9645): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 13:11:18.536+0900 I/MALI    ( 9645): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=9645   close drm_fd=21 
05-29 13:11:18.536+0900 I/MALI    ( 9645): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 13:11:18.541+0900 I/UXT     ( 9784): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 13:11:18.546+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 13:11:18.546+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 13:11:18.546+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 13:11:18.551+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 13:11:18.551+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 13:11:18.556+0900 E/CAPI_NETWORK_BLUETOOTH( 8929): bluetooth-adapter.c: bt_adapter_unset_state_changed_cb(842) > [bt_adapter_unset_state_changed_cb] NOT_INITIALIZED(0xfe400101)
05-29 13:11:18.556+0900 I/efl-extension( 8929): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45107550, , _activated_obj : 0x454042b0, activated : 1
05-29 13:11:18.556+0900 I/efl-extension( 8929): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 13:11:18.556+0900 I/efl-extension( 8929): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x453eb8b8, obj: 0x453eb8b8
05-29 13:11:18.556+0900 I/efl-extension( 8929): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 13:11:18.556+0900 I/efl-extension( 8929): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 13:11:18.556+0900 I/efl-extension( 8929): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 13:11:18.556+0900 I/efl-extension( 8929): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 13:11:18.561+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 13:11:18.561+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 13:11:18.561+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 13:11:18.561+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 13:11:18.561+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
05-29 13:11:18.561+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 13:11:18.561+0900 W/W_HOME  (  714): main.c: _appcore_resume_cb(681) > appcore resume
05-29 13:11:18.561+0900 W/W_HOME  (  714): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-29 13:11:18.561+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 13:11:18.566+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 13:11:18.566+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 13:11:18.566+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 13:11:18.566+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x45d34090
05-29 13:11:18.566+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d34090, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-29 13:11:18.566+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 13:11:18.571+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 13:11:18.571+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 13:11:18.571+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 13:11:18.571+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 13:11:18.571+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 13:11:18.571+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 13:11:18.571+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 13:11:18.581+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 13:11:18.581+0900 I/efl-extension( 8929): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4541ea78 is freed
05-29 13:11:18.581+0900 I/efl-extension( 8929): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 13:11:18.581+0900 I/efl-extension( 8929): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x453eb8b8, elm_genlist, func : 0x41973dfd
05-29 13:11:18.581+0900 I/efl-extension( 8929): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 13:11:18.631+0900 I/UXT     ( 9645): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 13:11:18.646+0900 I/MALI    ( 8929): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 13:11:18.646+0900 I/MALI    ( 8929): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=8929   close drm_fd=27 
05-29 13:11:18.646+0900 I/MALI    ( 8929): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 13:11:18.656+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 13:11:18.656+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 13:11:18.656+0900 E/APP_CORE( 9012): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 13:11:18.661+0900 I/APP_CORE( 9012): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 13:11:18.661+0900 I/CAPI_APPFW_APPLICATION( 9012): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-29 13:11:18.661+0900 I/WIFI_EFL( 9012): app_main.c: app_terminate(4453) > [Enter]
05-29 13:11:18.661+0900 I/WIFI_EFL( 9012): app_main.c: _app_release(4193) > [Enter]
05-29 13:11:18.681+0900 I/CAPI_NETWORK_WIFI( 9012): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
05-29 13:11:18.681+0900 E/CAPI_NETWORK_WIFI( 9012): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 13:11:18.681+0900 E/CAPI_NETWORK_WIFI( 9012): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 13:11:18.681+0900 E/CAPI_NETWORK_WIFI( 9012): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 13:11:18.681+0900 E/CAPI_NETWORK_WIFI( 9012): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 13:11:18.681+0900 E/CAPI_NETWORK_WIFI( 9012): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 13:11:18.681+0900 E/CAPI_NETWORK_WIFI( 9012): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 13:11:18.681+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: eext_circle_surface_del(1362) > Surface[0x44a94f00] is going to free in eext_circle_surface_del API.
05-29 13:11:18.681+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x45417af0], circle_obj[0x45421930]!
05-29 13:11:18.681+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x454584c0 = w: 0 h: 0  obj 0x45417af0 w: 360 h: 360
05-29 13:11:18.681+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 13:11:18.686+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44aac0c8 is freed
05-29 13:11:18.686+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x45633e40], circle_obj[0x455ed248]!
05-29 13:11:18.686+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x45469d20 = w: 0 h: 0  obj 0x45633e40 w: 360 h: 360
05-29 13:11:18.686+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 13:11:18.686+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45640c20 is freed
05-29 13:11:18.686+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x455e92a0], circle_obj[0x454e8e08]!
05-29 13:11:18.686+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x45458d90 = w: 0 h: 0  obj 0x455e92a0 w: 360 h: 360
05-29 13:11:18.686+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 13:11:18.686+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44d0b728 is freed
05-29 13:11:18.686+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44a94f00 is freed
05-29 13:11:18.691+0900 I/WIFI_EFL( 9012): app_main.c: __main_del_cb(3767) > [Enter]
05-29 13:11:18.691+0900 I/CAPI_APPFW_APPLICATION( 9012): app_main.c: app_efl_exit(145) > app_efl_exit
05-29 13:11:18.691+0900 I/efl-extension( 9012): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44a92b60, obj: 0x44a92b60
05-29 13:11:18.691+0900 I/efl-extension( 9012): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 13:11:18.696+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 13:11:18.696+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x454584c0 is freed
05-29 13:11:18.696+0900 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 13:11:18.696+0900 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44a92b60, elm_genlist, func : 0x419f9dfd
05-29 13:11:18.696+0900 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 13:11:18.696+0900 I/WIFI_EFL( 9012): app_main.c: __scan_del_cb(1071) > [Enter]
05-29 13:11:18.696+0900 I/CAPI_APPFW_APPLICATION( 9012): app_main.c: app_efl_exit(145) > app_efl_exit
05-29 13:11:18.701+0900 I/efl-extension( 9012): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44aa65d0, obj: 0x44aa65d0
05-29 13:11:18.701+0900 I/efl-extension( 9012): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 13:11:18.706+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 13:11:18.706+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45469d20 is freed
05-29 13:11:18.706+0900 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 13:11:18.706+0900 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44aa65d0, elm_genlist, func : 0x419f9dfd
05-29 13:11:18.706+0900 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 13:11:18.711+0900 I/WIFI_EFL( 9012): app_main.c: __detail_del_cb(786) > [Enter]
05-29 13:11:18.711+0900 E/WIFI_EFL( 9012): wifi_manager.c: wifi_manager_ap_destroy(779) > 'ap_obj != NULL' failed.
05-29 13:11:18.716+0900 I/efl-extension( 9012): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x454430d8, obj: 0x454430d8
05-29 13:11:18.716+0900 I/efl-extension( 9012): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 13:11:18.716+0900 I/efl-extension( 9012): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 13:11:18.716+0900 I/efl-extension( 9012): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 13:11:18.716+0900 I/efl-extension( 9012): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 13:11:18.716+0900 I/UXT     ( 8929): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 13:11:18.736+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 13:11:18.736+0900 I/efl-extension( 9012): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45458d90 is freed
05-29 13:11:18.736+0900 I/efl-extension( 9012): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x455e92a0
05-29 13:11:18.736+0900 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 13:11:18.736+0900 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x454430d8, elm_genlist, func : 0x419f9dfd
05-29 13:11:18.736+0900 I/efl-extension( 9012): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 13:11:18.741+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 6
05-29 13:11:18.741+0900 W/AUL_AMD (  487): amd_request.c: __foward_cmd(153) > __forward_cmd: 9012 9012
05-29 13:11:18.741+0900 E/AUL     (  487): app_sock.c: __connect_client_sock(196) > connect error: 111
05-29 13:11:18.741+0900 E/AUL     (  487): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-29 13:11:18.766+0900 I/MALI    ( 9012): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 13:11:18.766+0900 I/MALI    ( 9012): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=9012   close drm_fd=28 
05-29 13:11:18.766+0900 I/MALI    ( 9012): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 13:11:18.796+0900 I/AUL_PAD ( 9988): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 13:11:18.821+0900 I/UXT     ( 9012): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 13:11:18.841+0900 E/TBM     ( 9988): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 13:11:18.846+0900 E/AUL     (  487): app_sock.c: __connect_client_sock(196) > connect error: 111
05-29 13:11:18.846+0900 E/AUL     (  487): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-29 13:11:18.906+0900 I/efl-extension( 9784): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 13:11:18.921+0900 I/efl-extension( 9645): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 13:11:18.946+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-29 13:11:18.976+0900 I/efl-extension( 8929): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 13:11:19.146+0900 E/AUL     (  487): app_sock.c: __connect_client_sock(196) > connect error: 111
05-29 13:11:19.146+0900 E/AUL     (  487): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-29 13:11:19.231+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8929
05-29 13:11:19.231+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 9645
05-29 13:11:19.241+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 9784
05-29 13:11:19.251+0900 I/efl-extension( 9012): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 13:11:19.346+0900 W/CRASH_MANAGER( 9993): worker.c: worker_job(1199) > 1109784706831146449507
