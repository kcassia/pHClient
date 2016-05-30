S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 6253
Date: 2016-05-12 17:17:03+0900
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
r8   = 0x441d71c0, r9   = 0x441d6d40
r10  = 0x418862d0, fp   = 0x00000000
ip   = 0x4142def4, sp   = 0xbea81658
lr   = 0x400953f8, pc   = 0x652f2f72
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     40404 KB
Buffers:     31616 KB
Cached:     126780 KB
VmPeak:      94156 KB
VmSize:      86308 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21128 KB
VmRSS:       18264 KB
VmData:      31984 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23928 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6253 TID = 6253
6253 6345 

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
44ba3000 453a2000 rwxp [stack:6345]
456b8000 456bb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
456c3000 456fb000 r-xp /usr/lib/libpulse.so.0.16.2
4585e000 45863000 r-xp /usr/lib/libjson.so.0.0.1
4586b000 458b3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
458b4000 458f7000 r-xp /usr/lib/libsndfile.so.1.0.25
45904000 45926000 r-xp /usr/lib/libvorbis.so.0.4.3
4592e000 45932000 r-xp /usr/lib/libogg.so.0.7.1
bea61000 bea82000 rwxp [stack]
End of Maps Information

Callstack Information (PID:6253)
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
_rotary_cb() return
05-12 17:12:19.203+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:12:19.348+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:12:19.348+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:12:19.348+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4350541
05-12 17:12:19.348+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:19.348+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:19.348+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:12:19.693+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.693+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.693+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4350885
05-12 17:12:19.693+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:19.693+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:19.693+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.723+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.723+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.723+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4350918
05-12 17:12:19.723+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:19.723+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:19.728+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.783+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.783+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.783+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4350975
05-12 17:12:19.783+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:19.783+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:19.783+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.903+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.903+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:19.903+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4351096
05-12 17:12:19.903+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:19.903+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:19.903+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:22.278+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:22.278+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:22.278+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4353470
05-12 17:12:22.278+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:22.278+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:22.278+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:22.373+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:22.373+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:22.373+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4353565
05-12 17:12:22.373+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:22.373+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:22.373+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:23.898+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:23.898+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:23.898+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4355089
05-12 17:12:23.898+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:23.898+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:23.898+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:23.933+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:23.933+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:23.933+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4355127
05-12 17:12:23.933+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:23.933+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:23.933+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:23.983+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:23.983+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4355175
05-12 17:12:23.983+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:23.983+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:23.983+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:23.983+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:26.838+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:12:26.838+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:12:28.423+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:12:28.428+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:12:28.438+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-12 17:12:28.478+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-12 17:12:28.478+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-12 17:12:28.478+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-12 17:12:32.473+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 77 -> 76 1463040752 150
05-12 17:12:32.473+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 76 1928 381 2442
05-12 17:12:32.473+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 76 0 0 2943
05-12 17:12:32.473+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 76 1538 643 1948
05-12 17:12:32.473+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 76 132 5 167
05-12 17:12:32.473+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 76 499 23 632
05-12 17:12:33.363+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:12:33.363+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:12:36.578+0900 E/WMS     (  485): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-12 17:12:36.583+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-12 17:12:36.583+0900 E/WMS     (  485): ==========
05-12 17:12:36.583+0900 E/WMS     (  485): ##WMS SEND : mgr_gear_wear_onoff_req
05-12 17:12:36.583+0900 E/WMS     (  485): ==========
05-12 17:12:36.598+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-12 17:12:36.693+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-12 17:12:36.693+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-12 17:12:36.693+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-12 17:12:36.698+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [63 / 63] bytes. 
05-12 17:12:41.488+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 17:12:41.968+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:12:41.968+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:12:41.978+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-12 17:12:41.978+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-12 17:12:41.983+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-12 17:12:41.983+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-12 17:12:42.753+0900 E/WMS     (  485): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-12 17:12:42.758+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-12 17:12:42.758+0900 E/WMS     (  485): ==========
05-12 17:12:42.758+0900 E/WMS     (  485): ##WMS SEND : mgr_gear_wear_onoff_req
05-12 17:12:42.758+0900 E/WMS     (  485): ==========
05-12 17:12:42.758+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-12 17:12:42.843+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-12 17:12:42.843+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-12 17:12:42.843+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-12 17:12:42.848+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [63 / 63] bytes. 
05-12 17:12:49.768+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.768+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.768+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4380962
05-12 17:12:49.768+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:49.768+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:49.773+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.803+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.803+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.803+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4380996
05-12 17:12:49.803+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:49.803+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:49.803+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.833+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.833+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.833+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.833+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4381027
05-12 17:12:49.833+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:49.833+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:49.878+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.878+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.878+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.878+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4381070
05-12 17:12:49.878+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:49.878+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:49.948+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.948+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.948+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:49.948+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4381138
05-12 17:12:49.948+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:49.948+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:50.013+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:50.013+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:50.013+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:50.013+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4381205
05-12 17:12:50.013+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:50.013+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:50.133+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:50.133+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:50.133+0900 I/efl-extension( 6253): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:12:50.133+0900 I/efl-extension( 6253): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x418b2d68, elm_layout, time_stamp : 4381323
05-12 17:12:50.133+0900 D/TIMER   ( 6253): Rotary callback is called
05-12 17:12:50.133+0900 E/TIMER   ( 6253): (ad->timer) -> _rotary_cb() return
05-12 17:12:54.403+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:12:54.403+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:13:00.488+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-12 17:13:00.488+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-12 17:13:00.493+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : pedometer_inactive_period error
05-12 17:13:00.493+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:13:00.493+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:13:00.493+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_10min_precaution_millisec error
05-12 17:13:00.493+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:13:00.498+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:13:00.498+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_before_10min_precaution_millisec error
05-12 17:13:00.628+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:13:10.348+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 17:13:10.353+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 17:13:40.953+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 17:14:00.473+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-12 17:14:00.473+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-12 17:14:00.508+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : pedometer_inactive_period error
05-12 17:14:00.513+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:14:00.548+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:14:00.548+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_10min_precaution_millisec error
05-12 17:14:00.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:14:00.558+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:14:00.568+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_before_10min_precaution_millisec error
05-12 17:14:00.698+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:14:10.338+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 17:14:10.338+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 17:14:31.998+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-12 17:14:32.068+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-12 17:14:32.118+0900 E/RESOURCED(  494): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 2503
05-12 17:14:32.128+0900 E/ALARM_MANAGER( 2503): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.ascsd] : Alarm id [922359837]
05-12 17:14:32.128+0900 W/SNL_W   ( 2503): <on_alarm_event:642> Awake to sendKeepAlive_Alarm() - begin,  mCurrentIntervalSeconds ( 1200 )
05-12 17:14:32.128+0900 W/SNL_W   ( 2503): <on_alarm_event:652> sendKeepAlive_alarmthread detached successfully
05-12 17:14:32.128+0900 W/SNL_W   ( 2503): <on_alarm_event:656> sendKeepAlive_alarmthread - end 
05-12 17:14:32.133+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_expired(1322) > alarm_id[922359837] is expired.
05-12 17:14:32.133+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(922359837)
05-12 17:14:32.133+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(542) > The duetime of alarm(1328323117) is OVER.
05-12 17:14:32.133+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-12 17:14:32.133+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 12-5-2016, 08:36:09 (UTC).
05-12 17:14:32.138+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-12 17:14:32.138+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-12 17:14:32.138+0900 W/SNL_W   ( 2503): <sendKeepAliveAllGroup:670> sendKeepAliveAllGroup() - begin
05-12 17:14:32.143+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Call()
05-12 17:14:32.143+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Res( 0 )
05-12 17:14:32.143+0900 W/SNL_W   ( 2503): <util_pm_lock:1132> util_pm_lock() LOCK
05-12 17:14:32.163+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-12 17:14:32.178+0900 W/SNL_W   ( 2503): <sendKeepAliveAllGroup:706> releaseWakeLockinTimeThread detached successfully
05-12 17:14:32.178+0900 W/SNL_W   ( 2503): <sendKeepAliveAllGroup:719> 0 sendKeepAliveThread detached successfully
05-12 17:14:32.178+0900 W/SNL_W   ( 2503): <sendKeepAliveThread:863> sendKeepAliveThread() - presSendNotify(1) begin
05-12 17:14:32.178+0900 W/SCSD    ( 2503): <on_presSendNotify:426> sent keepalive (group_id: bd8995065b9fd14071c50579) (S:3/F:4/T:7) (msg_id: 1)
05-12 17:14:32.183+0900 W/SCSD    ( 2503): <_keepalive_cb:520> entrance
05-12 17:14:32.183+0900 W/SCSD    ( 2503): <util_dbus_send_keepalive_sent:287> entrance
05-12 17:14:32.183+0900 W/SNL_W   ( 2503): <sendKeepAliveThread:865> sendKeepAliveThread() - presSendNotify(1) end
05-12 17:14:32.183+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: sKA - group( bd8995065b9fd14071c50579 ) mtype( 0 ) timeout( 30000 )
05-12 17:14:32.188+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: sKA
05-12 17:14:32.188+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: send_msg - ( 0xfc ), type( 0x01 ), res( 152 ), seq( 1014 )
05-12 17:14:32.193+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Call()
05-12 17:14:32.193+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Res( 0 )
05-12 17:14:32.193+0900 W/SNL_W   ( 2503): <presSendNotify_i:994> presSendNotify_w ( bd8995065b9fd14071c50579 ) - begin
05-12 17:14:32.193+0900 W/SNL_W   ( 2503): <presSendNotify_i:1017> presSendNotify_w ( bd8995065b9fd14071c50579 ) - end
05-12 17:14:32.193+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: noti_ps_th - Res( )
05-12 17:14:32.268+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: recv_msg(res) - ( 0xfc ), seq( 1014 )
05-12 17:14:32.278+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: sKA - res( 0 )
05-12 17:14:32.278+0900 W/SNL_W   ( 2503): <sendKeepAliveThread:870> sendKeepAliveThread() - group_id ( bd8995065b9fd14071c50579 ) sendKeepAliveType ( 0 ), PING_CNT ( 0 ) 
05-12 17:14:32.278+0900 W/SNL_W   ( 2503): <sendKeepAliveThread:879> sendKeepAliveThread() - presSendNotify(0) begin
05-12 17:14:32.278+0900 W/SCSD    ( 2503): <on_presSendNotify:426> sent keepalive (group_id: bd8995065b9fd14071c50579) (S:4/F:4/T:8) (msg_id: 0)
05-12 17:14:32.283+0900 W/SNL_W   ( 2503): <sendKeepAliveAllGroup:731> sendKeepAliveAllgroup() - groupList.size() : 0(f) + 1(p)
05-12 17:14:32.283+0900 W/SNL_W   ( 2503): <sendKeepAliveThread:881> sendKeepAliveThread() - presSendNotify(0) end
05-12 17:14:32.283+0900 W/SNL_W   ( 2503): <setAlarm:520> setAlarm() - begin 
05-12 17:14:32.283+0900 W/SNL_W   ( 2503): <initAlarm:505> InitAlarm() - begin
05-12 17:14:32.283+0900 W/SNL_W   ( 2503): <initAlarm:511> InitAlarm() success - end
05-12 17:14:32.283+0900 W/SNL_W   ( 2503): <setAlarm:543> changeStep() - step F -> D currentInterval ( 1200 ) MAX
05-12 17:14:32.288+0900 W/SCSD    ( 2503): <_keepalive_cb:520> entrance
05-12 17:14:32.388+0900 I/AUL     ( 2503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-12 17:14:32.428+0900 I/AUL     ( 2503): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-12 17:14:32.428+0900 E/ALARM_MANAGER( 2503): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(1195), start(12-5-2016, 17:34:27), repeat(0), interval(0), type(-1073741822)
05-12 17:14:32.443+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-12 17:14:32.443+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-12 17:14:32.473+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-12 17:14:32.493+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-12 17:14:32.513+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-12 17:14:32.528+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-12 17:14:32.528+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-12 17:14:32.533+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-12 17:14:32.543+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-12 17:14:32.558+0900 I/AUL     (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-12 17:14:32.558+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1463042067, Thu May 12 17:34:27 2016
05-12 17:14:32.558+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1478304146, next duetime: 1463042067
05-12 17:14:32.558+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1478304146)
05-12 17:14:32.563+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1463042169), due_time(1463042067)
05-12 17:14:32.563+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-12 17:14:32.563+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 12-5-2016, 08:34:27 (UTC).
05-12 17:14:32.563+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-12 17:14:32.568+0900 W/SNL_W   ( 2503): <setAlarm:569> setAlarm() - end : mStatus ( 2 ) currentInterval( 1200 ) interruptFlag ( 0 ) alarm_id ( 1478304146 )
05-12 17:14:32.568+0900 W/SNL_W   ( 2503): <sendKeepAliveAllGroup:750> sendKeepAliveAllGroup() - set last interval ( 1200 )
05-12 17:14:32.568+0900 W/SNL_W   ( 2503): <util_pm_unlock:1154> util_pm_unlock() UNLOCK
05-12 17:14:32.578+0900 W/SNL_W   ( 2503): <sendKeepAliveAllGroup:756> sendKeepAliveAllGroup () - WakeLock release
05-12 17:14:32.578+0900 W/SNL_W   ( 2503): <sendKeepAliveAllGroup:768> sendKeepAliveAllGroup() - end Error ( 0 )
05-12 17:14:32.593+0900 W/SNL_W   ( 2503): <releaseWakeLockinTimeThread:813> releaseWakeLockinTimeThread () - WakeLock already released
05-12 17:14:32.693+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 76 -> 75 1463040872 120
05-12 17:14:32.693+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 75 1923 382 2404
05-12 17:14:32.693+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 75 0 0 2902
05-12 17:14:32.693+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 75 1536 644 1920
05-12 17:14:32.693+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 75 120 5 150
05-12 17:14:32.693+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 75 484 24 605
05-12 17:14:40.958+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 17:15:00.538+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-12 17:15:00.543+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-12 17:15:00.558+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : pedometer_inactive_period error
05-12 17:15:00.558+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:15:00.563+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:15:00.568+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_10min_precaution_millisec error
05-12 17:15:00.573+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:15:00.578+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:15:00.578+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_before_10min_precaution_millisec error
05-12 17:15:00.768+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:15:10.338+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 17:15:10.343+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 17:15:40.948+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 17:16:00.518+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-12 17:16:00.518+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-12 17:16:00.533+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : pedometer_inactive_period error
05-12 17:16:00.538+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:16:00.543+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:16:00.543+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_10min_precaution_millisec error
05-12 17:16:00.548+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:16:00.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:16:00.558+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_before_10min_precaution_millisec error
05-12 17:16:00.838+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:16:10.363+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 17:16:10.368+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 17:16:40.958+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 17:17:00.498+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-12 17:17:00.503+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-12 17:17:00.503+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : pedometer_inactive_period error
05-12 17:17:00.503+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:17:00.508+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:17:00.508+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_10min_precaution_millisec error
05-12 17:17:00.508+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:17:00.508+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:17:00.508+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_before_10min_precaution_millisec error
05-12 17:17:00.903+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:17:02.653+0900 E/PKGMGR_SERVER( 6600): pkgmgr-server.c: main(2131) > package manager server start
05-12 17:17:02.728+0900 E/PKGMGR_SERVER( 6600): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_-932186380], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[81u/0GRejqC+hYhqWfDa8OJNECU=], backend_flag=[0]
05-12 17:17:02.738+0900 E/PKGMGR_SERVER( 6601): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-12 17:17:02.743+0900 E/PKGMGR  ( 6598): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-12 17:17:02.818+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:17:02.828+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6253
05-12 17:17:02.828+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-12 17:17:02.833+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 5
05-12 17:17:02.838+0900 W/AUL_AMD (  493): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(6253), cmd(4)
05-12 17:17:02.838+0900 I/APP_CORE( 6253): appcore-efl.c: __do_app(429) > [APP 6253] Event: TERMINATE State: RUNNING
05-12 17:17:02.838+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-12 17:17:02.838+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-12 17:17:02.843+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:17:02.853+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6253
05-12 17:17:02.913+0900 I/APP_CORE( 6253): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-12 17:17:02.913+0900 I/CAPI_APPFW_APPLICATION( 6253): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-12 17:17:02.938+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-12 17:17:02.938+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-12 17:17:02.953+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:17:02.963+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6253
05-12 17:17:02.963+0900 I/efl-extension( 6253): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x418b2d68
05-12 17:17:02.963+0900 I/efl-extension( 6253): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x418b2d68, obj: 0x418b2d68
05-12 17:17:02.963+0900 I/efl-extension( 6253): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-12 17:17:02.968+0900 I/efl-extension( 6253): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-12 17:17:02.968+0900 I/efl-extension( 6253): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-12 17:17:02.968+0900 I/efl-extension( 6253): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-12 17:17:03.023+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-12 17:17:03.028+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-12 17:17:03.028+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
05-12 17:17:03.028+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-12 17:17:03.028+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:17:03.028+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:17:03.028+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:17:03.028+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-12 17:17:03.048+0900 I/UXT     ( 6253): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-12 17:17:03.058+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-12 17:17:03.058+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-12 17:17:03.058+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:17:03.058+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-12 17:17:03.063+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-12 17:17:03.063+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:17:03.073+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6253
05-12 17:17:03.078+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-12 17:17:03.078+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-12 17:17:03.078+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-12 17:17:03.078+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:17:03.083+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:17:03.093+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:17:03.093+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:17:03.098+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x46f639e0
05-12 17:17:03.098+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46f639e0, elm_layout, _activated_obj : 0x45c95f90, activated : 1
05-12 17:17:03.098+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-12 17:17:03.103+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-12 17:17:03.103+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 17:17:03.103+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-12 17:17:03.108+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 17:17:03.108+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 17:17:03.108+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 17:17:03.108+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 17:17:03.178+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:17:03.188+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6253
05-12 17:17:03.288+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:17:03.303+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6253
05-12 17:17:03.408+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:17:03.418+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6253
05-12 17:17:03.518+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:17:03.533+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-12 17:17:03.538+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1518] swap changed from async to sync
05-12 17:17:03.543+0900 E/PKGMGR_SERVER( 6601): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-12 17:17:03.578+0900 E/PKGMGR_SERVER( 6600): pkgmgr-server.c: sighandler(409) > child NORMAL exit [6601]
05-12 17:17:03.628+0900 W/CRASH_MANAGER( 6608): worker.c: worker_job(1199) > 1106253706831146304102
