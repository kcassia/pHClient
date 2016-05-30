S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 5513
Date: 2016-05-12 17:08:31+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059b250, r3   = 0x00000000
r4   = 0x4413d390, r5   = 0x41461d75
r6   = 0x4413dc90, r7   = 0x40003ac4
r8   = 0x4413ca90, r9   = 0x4413c610
r10  = 0x418d0108, fp   = 0x00000000
ip   = 0x4143b490, sp   = 0xbeb4c630
lr   = 0x404e41e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     46524 KB
Buffers:     30156 KB
Cached:     126204 KB
VmPeak:      90836 KB
VmSize:      84768 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20100 KB
VmRSS:       17320 KB
VmData:      31552 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22964 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5513 TID = 5513
5513 5797 

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
41771000 41779000 r-xp /usr/lib/libmdm-common.so.1.0.89
4177a000 41828000 rw-p [heap]
41828000 41835000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
4183d000 41842000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
4184a000 4184b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41954000 41958000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41961000 41982000 r-xp /usr/lib/libefl-extension.so.0.1.0
4198a000 419a1000 r-xp /usr/lib/libnetwork.so.0.0.0
419a9000 419ae000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
419b6000 419d4000 r-xp /usr/lib/libsensor.so.1.1.0
419de000 419f0000 r-xp /usr/lib/libefl-assist.so.0.1.0
419f8000 41ab0000 r-xp /usr/lib/libcairo.so.2.11200.14
41abb000 41aec000 r-xp /usr/lib/libmdm.so.1.1.85
41af4000 41afb000 r-xp /usr/lib/libsensord-share.so
41b03000 41b15000 r-xp /usr/lib/libtts.so
41b1d000 41b3e000 r-xp /usr/lib/libui-extension.so.0.1.0
41b47000 41b4e000 r-xp /usr/lib/libtbm.so.1.0.0
41b56000 41b64000 r-xp /usr/lib/libGLESv2.so.2.0
41b6d000 41b73000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b7b000 41b7e000 r-xp /usr/lib/libEGL.so.1.4
41b86000 41cc3000 r-xp /usr/lib/libicui18n.so.51.1
41cd3000 41db7000 r-xp /usr/lib/libicuuc.so.51.1
41dcc000 41dcf000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41dd7000 41ddf000 r-xp /usr/lib/libdrm.so.2.4.0
4336e000 43373000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4337c000 43381000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43389000 4338b000 r-xp /usr/lib/libdri2.so.0.0.0
43393000 433b4000 r-xp /usr/lib/libexif.so.12.3.3
433c7000 433cc000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433d4000 4349e000 r-xp /usr/lib/libCOREGL.so.4.0
437f5000 437f9000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44bb7000 453b6000 rwxp [stack:5797]
beb2c000 beb4d000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5513)
Call Stack Count: 2
 0: cfree + 0xc8 (0x404e41e8) [/lib/libc.so.6] + 0x6f1e8
 1: (0x1) (null)
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
00 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:23.788+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:23.838+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:23.838+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:23.838+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115031
05-12 17:08:23.838+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:23.838+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:23.838+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:23.908+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:23.908+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:23.908+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115099
05-12 17:08:23.908+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:23.908+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:23.908+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:23.968+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:23.968+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:23.968+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115160
05-12 17:08:23.968+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:23.968+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:23.968+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.013+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.013+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.013+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115207
05-12 17:08:24.013+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.013+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.013+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.058+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.058+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.058+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115250
05-12 17:08:24.058+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.058+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.058+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.093+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.093+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.093+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115285
05-12 17:08:24.093+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.093+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.093+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.138+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.138+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.138+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115331
05-12 17:08:24.138+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.138+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.138+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.213+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.213+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.213+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115408
05-12 17:08:24.213+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.213+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.218+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.278+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.278+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.278+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115469
05-12 17:08:24.278+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.278+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.278+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.333+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.333+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.333+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115526
05-12 17:08:24.333+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.333+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.333+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:24.548+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.548+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.548+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115740
05-12 17:08:24.548+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.548+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.548+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.588+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.588+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.588+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115783
05-12 17:08:24.588+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.588+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.588+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.623+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.623+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.623+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115813
05-12 17:08:24.623+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.623+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.623+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.648+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.648+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.648+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115839
05-12 17:08:24.648+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.648+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.648+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.673+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.673+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.673+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115868
05-12 17:08:24.673+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.673+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.673+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.698+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.698+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.698+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115891
05-12 17:08:24.698+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.698+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.698+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.723+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.723+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.723+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115918
05-12 17:08:24.723+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.723+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.723+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.748+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.748+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.748+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115940
05-12 17:08:24.748+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.748+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.748+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.768+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.768+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.768+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115963
05-12 17:08:24.768+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.768+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.768+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.793+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.793+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.793+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4115984
05-12 17:08:24.793+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.793+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.793+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.818+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.818+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.818+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4116013
05-12 17:08:24.818+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.818+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.818+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.873+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.873+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.873+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4116067
05-12 17:08:24.873+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.873+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.873+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.928+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.928+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:24.928+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4116122
05-12 17:08:24.928+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:24.928+0900 E/TIMER   ( 5513): (ad->timer) -> _rotary_cb() return
05-12 17:08:24.928+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:25.978+0900 E/EFL     ( 5513): evas_main<5513> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4117169 button=1 downs=1
05-12 17:08:26.013+0900 E/EFL     ( 5513): evas_main<5513> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4117205 button=1 downs=0
05-12 17:08:26.013+0900 D/TIMER   ( 5513): Start clicked
05-12 17:08:26.013+0900 E/EFL     ( 5513): ecore<5513> ecore.c:574 _ecore_magic_fail() 
05-12 17:08:26.013+0900 E/EFL     ( 5513): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-12 17:08:26.013+0900 E/EFL     ( 5513): *** IN FUNCTION: ecore_timer_del()
05-12 17:08:26.013+0900 E/EFL     ( 5513): ecore<5513> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-12 17:08:26.013+0900 E/EFL     ( 5513):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-12 17:08:26.013+0900 E/EFL     ( 5513):     Supplied: 0049a1bd - <UNKNOWN>
05-12 17:08:26.013+0900 E/EFL     ( 5513): ecore<5513> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-12 17:08:26.013+0900 E/EFL     ( 5513): *** SPANK SPANK SPANK!!!
05-12 17:08:26.013+0900 E/EFL     ( 5513): *** Now go fix your code. Tut tut tut!
05-12 17:08:26.013+0900 I/SOCKETTEST( 5513): Success to create socket
05-12 17:08:26.013+0900 I/SOCKETTEST( 5513): socket connect error: Network is unreachable
05-12 17:08:26.013+0900 I/SOCKETTEST( 5513): write() error: Bad file descriptor
05-12 17:08:26.528+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.528+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.528+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4117719
05-12 17:08:26.528+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:26.528+0900 D/TIMER   ( 5513): Detent detected, obj[0x44105f70], direction[0], time_stamp[4117719]
05-12 17:08:26.528+0900 D/TIMER   ( 5513): Pre change num: 00
05-12 17:08:26.528+0900 D/TIMER   ( 5513): Post change num: 0
05-12 17:08:26.528+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.558+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.558+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.558+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.558+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4117748
05-12 17:08:26.558+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:26.558+0900 D/TIMER   ( 5513): Detent detected, obj[0x44105f70], direction[0], time_stamp[4117748]
05-12 17:08:26.558+0900 D/TIMER   ( 5513): Pre change num: 1
05-12 17:08:26.558+0900 D/TIMER   ( 5513): Post change num: 1
05-12 17:08:26.593+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.593+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.593+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4117784
05-12 17:08:26.593+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:26.593+0900 D/TIMER   ( 5513): Detent detected, obj[0x44105f70], direction[0], time_stamp[4117784]
05-12 17:08:26.593+0900 D/TIMER   ( 5513): Pre change num: 2
05-12 17:08:26.593+0900 D/TIMER   ( 5513): Post change num: 2
05-12 17:08:26.593+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.633+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.638+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.638+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4117828
05-12 17:08:26.638+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:26.638+0900 D/TIMER   ( 5513): Detent detected, obj[0x44105f70], direction[0], time_stamp[4117828]
05-12 17:08:26.638+0900 D/TIMER   ( 5513): Pre change num: 3
05-12 17:08:26.638+0900 D/TIMER   ( 5513): Post change num: 3
05-12 17:08:26.638+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.678+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.678+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.678+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4117872
05-12 17:08:26.678+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:26.678+0900 D/TIMER   ( 5513): Detent detected, obj[0x44105f70], direction[0], time_stamp[4117872]
05-12 17:08:26.678+0900 D/TIMER   ( 5513): Pre change num: 4
05-12 17:08:26.678+0900 D/TIMER   ( 5513): Post change num: 4
05-12 17:08:26.683+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.768+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.768+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.768+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4117962
05-12 17:08:26.768+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:26.768+0900 D/TIMER   ( 5513): Detent detected, obj[0x44105f70], direction[0], time_stamp[4117962]
05-12 17:08:26.768+0900 D/TIMER   ( 5513): Pre change num: 5
05-12 17:08:26.768+0900 D/TIMER   ( 5513): Post change num: 5
05-12 17:08:26.773+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.903+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.903+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.903+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4118094
05-12 17:08:26.903+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:26.903+0900 D/TIMER   ( 5513): Detent detected, obj[0x44105f70], direction[0], time_stamp[4118094]
05-12 17:08:26.903+0900 D/TIMER   ( 5513): Pre change num: 6
05-12 17:08:26.903+0900 D/TIMER   ( 5513): Post change num: 6
05-12 17:08:26.903+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.998+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.998+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:26.998+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4118192
05-12 17:08:26.998+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:26.998+0900 D/TIMER   ( 5513): Detent detected, obj[0x44105f70], direction[0], time_stamp[4118192]
05-12 17:08:26.998+0900 D/TIMER   ( 5513): Pre change num: 7
05-12 17:08:26.998+0900 D/TIMER   ( 5513): Post change num: 7
05-12 17:08:27.003+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:27.073+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:27.073+0900 I/efl-extension( 5513): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:27.073+0900 I/efl-extension( 5513): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44105f70, elm_layout, time_stamp : 4118265
05-12 17:08:27.073+0900 D/TIMER   ( 5513): Rotary callback is called
05-12 17:08:27.073+0900 D/TIMER   ( 5513): Detent detected, obj[0x44105f70], direction[0], time_stamp[4118265]
05-12 17:08:27.073+0900 D/TIMER   ( 5513): Pre change num: 8
05-12 17:08:27.073+0900 D/TIMER   ( 5513): Post change num: 8
05-12 17:08:27.078+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:08:28.288+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-12 17:08:28.288+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-12 17:08:28.293+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-12 17:08:28.293+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-12 17:08:28.388+0900 W/STARTER (  698): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-12 17:08:28.473+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-12 17:08:28.473+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-12 17:08:28.478+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-12 17:08:28.478+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-12 17:08:28.588+0900 W/STARTER (  698): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-12 17:08:28.853+0900 W/STARTER (  698): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-12 17:08:28.858+0900 W/STARTER (  698): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-12 17:08:28.893+0900 E/STARTER (  698): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-12 17:08:28.898+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 0
05-12 17:08:28.908+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(1702) > caller pid : 698
05-12 17:08:28.918+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(2080) > pad pid(-5)
05-12 17:08:28.918+0900 W/AUL_PAD ( 1132): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-12 17:08:28.918+0900 W/AUL_PAD ( 1132): launchpad.c: __send_result_to_caller(272) > Check app launching
05-12 17:08:28.923+0900 E/RESOURCED(  494): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-12 17:08:28.933+0900 I/CAPI_APPFW_APPLICATION( 5397): app_main.c: app_efl_main(129) > app_efl_main
05-12 17:08:28.943+0900 I/CAPI_APPFW_APPLICATION( 5397): app_main.c: app_appcore_create(152) > app_appcore_create
05-12 17:08:29.023+0900 E/AUL     (  698): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-12 17:08:29.023+0900 E/RESOURCED(  494): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-12 17:08:29.083+0900 I/efl-extension( 5397): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445af888 = w: 0 h: 0  obj 0x445b96f0 w: 360 h: 360
05-12 17:08:29.083+0900 I/efl-extension( 5397): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-12 17:08:29.088+0900 I/efl-extension( 5397): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-12 17:08:29.088+0900 I/efl-extension( 5397): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-12 17:08:29.088+0900 I/efl-extension( 5397): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-12 17:08:29.088+0900 I/efl-extension( 5397): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-12 17:08:29.088+0900 I/efl-extension( 5397): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445b96f0, elm_image, _activated_obj : 0x0, activated : 1
05-12 17:08:29.183+0900 E/W_TASKMANAGER( 5397): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-12 17:08:29.183+0900 E/W_TASKMANAGER( 5397): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-12 17:08:29.188+0900 E/W_TASKMANAGER( 5397): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-12 17:08:29.233+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.233+0900 E/W_TASKMANAGER( 5397): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:08:29.238+0900 E/RUA     ( 5397): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 16, ncols : 5
05-12 17:08:29.268+0900 E/EFL     ( 5397): elementary<5397> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445bb370 into part 'elm.swallow.event.0'
05-12 17:08:29.308+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04200003)
05-12 17:08:29.308+0900 I/APP_CORE( 5397): appcore-efl.c: __do_app(429) > [APP 5397] Event: RESET State: CREATED
05-12 17:08:29.308+0900 I/CAPI_APPFW_APPLICATION( 5397): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-12 17:08:29.323+0900 I/APP_CORE( 5397): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-12 17:08:29.323+0900 I/APP_CORE( 5397): appcore-efl.c: __do_app(474) > [APP 5397] Initial Launching, call the resume_cb
05-12 17:08:29.323+0900 I/CAPI_APPFW_APPLICATION( 5397): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-12 17:08:29.358+0900 E/E17     (  381): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04200003)
05-12 17:08:29.363+0900 W/APP_CORE( 5397): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4200003
05-12 17:08:29.433+0900 I/APP_CORE( 5397): appcore-efl.c: __do_app(429) > [APP 5397] Event: RESUME State: RUNNING
05-12 17:08:29.438+0900 I/APP_CORE( 5513): appcore-efl.c: __do_app(429) > [APP 5513] Event: PAUSE State: RUNNING
05-12 17:08:29.438+0900 I/CAPI_APPFW_APPLICATION( 5513): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-12 17:08:29.448+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-12 17:08:29.448+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-12 17:08:29.858+0900 E/AUL     (  493): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-12 17:08:29.898+0900 I/MALI    ( 5397): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-12 17:08:30.168+0900 E/EFL     ( 5397): evas_main<5397> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4121352 button=1 downs=1
05-12 17:08:30.203+0900 E/EFL     ( 5397): evas_main<5397> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4121392 button=1 downs=0
05-12 17:08:30.208+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:08:30.218+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5397
05-12 17:08:30.218+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-12 17:08:30.478+0900 E/EFL     ( 5397): elementary<5397> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(4456e1a8), freeze(1)
05-12 17:08:30.478+0900 E/EFL     ( 5397): elementary<5397> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(4456e1a8), freeze(1)
05-12 17:08:30.638+0900 I/efl-extension( 5870): efl_extension.c: eext_mod_init(40) > Init
05-12 17:08:30.673+0900 I/UXT     ( 5870): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-12 17:08:30.823+0900 I/AUL_PAD ( 5870): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-12 17:08:30.848+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:08:30.853+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5513
05-12 17:08:30.858+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 27
05-12 17:08:30.858+0900 I/APP_CORE( 5513): appcore-efl.c: __do_app(429) > [APP 5513] Event: TERMINATE State: PAUSED
05-12 17:08:30.868+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-12 17:08:30.868+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-12 17:08:30.873+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-12 17:08:30.873+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-12 17:08:30.878+0900 E/APP_CORE( 5397): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-12 17:08:30.878+0900 I/APP_CORE( 5397): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-12 17:08:30.878+0900 I/APP_CORE( 5397): appcore-efl.c: __after_loop(1090) > [APP 5397] PAUSE before termination
05-12 17:08:30.878+0900 I/CAPI_APPFW_APPLICATION( 5397): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-12 17:08:30.878+0900 I/CAPI_APPFW_APPLICATION( 5397): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-12 17:08:30.878+0900 I/efl-extension( 5397): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4456e1a8, obj: 0x4456e1a8
05-12 17:08:30.878+0900 I/efl-extension( 5397): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-12 17:08:30.878+0900 I/efl-extension( 5397): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-12 17:08:30.878+0900 I/efl-extension( 5397): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-12 17:08:30.878+0900 I/efl-extension( 5397): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-12 17:08:30.883+0900 I/efl-extension( 5397): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445b96f0
05-12 17:08:30.883+0900 I/efl-extension( 5397): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-12 17:08:30.883+0900 I/efl-extension( 5397): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445af888 is freed
05-12 17:08:30.888+0900 I/efl-extension( 5397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-12 17:08:30.888+0900 I/efl-extension( 5397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4456e1a8, elm_scroller, func : 0x437c8ef1
05-12 17:08:30.888+0900 I/efl-extension( 5397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-12 17:08:30.888+0900 I/efl-extension( 5397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-12 17:08:30.888+0900 I/efl-extension( 5397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445b96f0, elm_image, func : 0x437c8ef1
05-12 17:08:30.888+0900 I/efl-extension( 5397): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-12 17:08:30.888+0900 I/efl-extension( 5397): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x4456e1a8 : elm_scroller] rotary callabck is deleted
05-12 17:08:30.913+0900 E/TBM     ( 5870): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-12 17:08:30.933+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:08:30.933+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:08:30.948+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-12 17:08:30.948+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-12 17:08:30.948+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-12 17:08:30.948+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-12 17:08:30.948+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
05-12 17:08:30.953+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-12 17:08:30.953+0900 W/W_HOME  (  732): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-12 17:08:30.953+0900 W/W_HOME  (  732): gesture.c: _manual_render_enable(133) > 1
05-12 17:08:30.953+0900 W/W_HOME  (  732): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-12 17:08:30.953+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:30.953+0900 W/STARTER (  698): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
05-12 17:08:30.953+0900 W/STARTER (  698): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-12 17:08:30.958+0900 E/STARTER (  698): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-12 17:08:30.958+0900 W/STARTER (  698): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-12 17:08:30.958+0900 W/STARTER (  698): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-12 17:08:30.973+0900 I/TIZEN_N_SOUND_MANAGER( 1091): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-12 17:08:30.978+0900 I/TIZEN_N_SOUND_MANAGER( 1091): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-12 17:08:30.978+0900 W/TIZEN_N_SOUND_MANAGER( 1091): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-12 17:08:30.978+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-12 17:08:30.978+0900 I/HIGEAR  ( 1091): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-12 17:08:31.098+0900 I/MALI    ( 5397): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-12 17:08:31.113+0900 W/STARTER (  698): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
05-12 17:08:31.113+0900 W/STARTER (  698): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-12 17:08:31.113+0900 W/STARTER (  698): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-12 17:08:31.113+0900 W/STARTER (  698): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-12 17:08:31.133+0900 I/APP_CORE( 5513): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-12 17:08:31.133+0900 I/CAPI_APPFW_APPLICATION( 5513): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-12 17:08:31.148+0900 E/ALARM_MANAGER(  698): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(12-5-2016, 17:08:51), repeat(1), interval(20), type(-1073741822)
05-12 17:08:31.153+0900 I/MALI    ( 5397): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-12 17:08:31.153+0900 I/MALI    ( 5397): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=5397   close drm_fd=21 
05-12 17:08:31.153+0900 I/MALI    ( 5397): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-12 17:08:31.163+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-12 17:08:31.163+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-12 17:08:31.193+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-12 17:08:31.193+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-12 17:08:31.198+0900 W/MUSIC_CONTROL_SERVICE( 1163): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1163]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-12 17:08:31.263+0900 I/efl-extension( 5513): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44105f70
05-12 17:08:31.263+0900 I/efl-extension( 5513): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44105f70, obj: 0x44105f70
05-12 17:08:31.263+0900 I/efl-extension( 5513): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-12 17:08:31.263+0900 I/efl-extension( 5513): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-12 17:08:31.263+0900 I/efl-extension( 5513): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-12 17:08:31.263+0900 I/efl-extension( 5513): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-12 17:08:31.288+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 676589977, next duetime: 1463040531
05-12 17:08:31.288+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(676589977)
05-12 17:08:31.288+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1463040872), due_time(1463040531)
05-12 17:08:31.288+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-12 17:08:31.288+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 12-5-2016, 08:08:51 (UTC).
05-12 17:08:31.288+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-12 17:08:31.298+0900 I/SHealth_Common( 1035): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-12 17:08:31.298+0900 I/SHealth_Service( 1035): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-12 17:08:31.353+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-12 17:08:31.353+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:31.353+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:31.353+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:31.353+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-12 17:08:31.358+0900 I/UXT     ( 5397): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-12 17:08:31.363+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-12 17:08:31.363+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-12 17:08:31.363+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:31.363+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-12 17:08:31.373+0900 I/APP_CORE(  732): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-12 17:08:31.373+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-12 17:08:31.373+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 17:08:31.373+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-12 17:08:31.448+0900 I/UXT     ( 5513): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-12 17:08:31.598+0900 I/efl-extension( 5397): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-12 17:08:31.688+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1518] swap changed from async to sync
05-12 17:08:31.773+0900 I/AUL_AMD (  493): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 5397
05-12 17:08:31.773+0900 W/CRASH_MANAGER( 5781): worker.c: worker_job(1199) > 1105513706831146304051
