S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 6861
Date: 2016-05-12 17:23:31+0900
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
r8   = 0x418eea90, r9   = 0x418ee610
r10  = 0x41885208, fp   = 0x00000000
ip   = 0x4142def4, sp   = 0xbeac6658
lr   = 0x400953f8, pc   = 0x652f2f72
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     34840 KB
Buffers:     32724 KB
Cached:     127340 KB
VmPeak:      95780 KB
VmSize:      89404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21308 KB
VmRSS:       19264 KB
VmData:      35080 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23928 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6861 TID = 6861
6861 6984 

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
44ca3000 454a2000 rwxp [stack:6984]
457b8000 457bb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
457c3000 457fb000 r-xp /usr/lib/libpulse.so.0.16.2
4595e000 45963000 r-xp /usr/lib/libjson.so.0.0.1
4596b000 459b3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
459b4000 459f7000 r-xp /usr/lib/libsndfile.so.1.0.25
45a04000 45a26000 r-xp /usr/lib/libvorbis.so.0.4.3
45a2e000 45a32000 r-xp /usr/lib/libogg.so.0.7.1
beaa6000 beac7000 rwxp [stack]
End of Maps Information

Callstack Information (PID:6861)
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
2503): Scone_Log.cpp: dump(2972) > SNL :: noti_ps_th - Res( )
05-12 17:18:52.363+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: recv_msg(nty) - ( 0x10 )
05-12 17:18:52.393+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake. - seq(0) conn_id(7) stub_status(1) p(1) nid(0)
05-12 17:18:52.393+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake. - conn_id(7) fic(1) r_timeout(10000)
05-12 17:18:52.413+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake - c( 7 ) succeed
05-12 17:18:52.413+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake - msg type( 3 ) id( 1 )
05-12 17:18:52.418+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake - c( 7 ) desc( 2016-05-12 17:18:54.166070 )
05-12 17:18:52.428+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake - received_n_id( 0 )
05-12 17:18:52.428+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake - set tci
05-12 17:18:52.433+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake - target version(0.2.7.0)
05-12 17:18:52.433+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: noti_pc - Call g(95065b9fd14071c50579), i(39kc4o8c10), id(7), type(1)
05-12 17:18:52.438+0900 W/SNL_W   ( 2503): <peerConnNotify_i:1109> peerConnNotify_i - begin conn_id( 7 ) conn_type( 1 )
05-12 17:18:52.438+0900 W/SNL_W   ( 2503): <appendConnIdData:171> ==== appendConnIdData Start conn_id[7], time[1463041132] ====
05-12 17:18:52.438+0900 W/SNL_W   ( 2503): <appendConnIdData:184> ==== appendConnIdData end res[0] ====
05-12 17:18:52.438+0900 W/SCSD    ( 2503): <on_peerConnNotify:345> mapped_port: 7080
05-12 17:18:52.443+0900 W/SCSD    ( 2503): <on_peerConnNotify:346> nat_type: 0
05-12 17:18:52.443+0900 W/SCSD    ( 2503): <on_peerConnNotify:347> conn_type: 1 (tcp:1, udp:2, turn_relay:4, plain_udp:8, turn_udp: 16)
05-12 17:18:52.443+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: noti_pc - Res( 0 )
05-12 17:18:52.668+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: sc_si - Call()
05-12 17:18:52.673+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: sc_si - Res()
05-12 17:18:52.693+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake. - seq(0) conn_id(6) stub_status(1) p(4) nid(0)
05-12 17:18:52.698+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake. - conn_id(6) fic(0) r_timeout(10000)
05-12 17:18:52.743+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: handshake - recv.1 c( 6 ) res( -12 )
05-12 17:18:52.743+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: sc_dis connid( 6 ), way( 4)
05-12 17:18:52.758+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: sc_dis .
05-12 17:18:53.153+0900 W/SCSD    ( 2503): <_emit_peer_connect_cb:305> 
05-12 17:18:53.158+0900 W/SCSD    ( 2503): <_connected_cb:449> SCS Peer Connected !!!
05-12 17:18:53.158+0900 W/SCSD    ( 2503): <_connected_cb:450>  - peer_id: [SAP_A353557060538172EC145B76AEB8EFA5]
05-12 17:18:53.158+0900 W/SCSD    ( 2503): <_connected_cb:451>  - conn_id: 7
05-12 17:18:53.158+0900 W/SCSD    ( 2503): <util_dbus_set_connection_status:267> set connection_status: 1
05-12 17:18:53.198+0900 W/SCSD    ( 2503): <recv_thread:174> time=1463041133, thread_id=7023, conn_id: 7
05-12 17:18:53.243+0900 W/W_INDICATOR(  699): windicator_scs.c: windicator_scs_update(39) > [windicator_scs_update:39] sales code : 0
05-12 17:18:53.248+0900 W/W_HOME  (  732): clock_event.c: _wmanager_connectivity_get(374) > network status : 0
05-12 17:18:53.253+0900 W/W_HOME  (  732): clock_event.c: _wmanager_connectivity_get(379) > sap_connected : 1
05-12 17:18:53.253+0900 W/W_HOME  (  732): clock_event.c: _wmanager_connectivity_get(385) > sap connectivity type : 16
05-12 17:18:53.253+0900 W/W_HOME  (  732): clock_event.c: _wmanager_connectivity_get(391) > network status : 2
05-12 17:18:53.253+0900 W/W_HOME  (  732): clock_event.c: _wmanager_connectivity_get(405) > scs login : 1
05-12 17:18:53.253+0900 W/W_HOME  (  732): clock_event.c: _wmanager_connectivity_get(433) > network connection via WIFI : no checking svc_type
05-12 17:18:53.253+0900 W/W_HOME  (  732): clock_view_indicator.c: _view_remove_by_type(262) > removed:4
05-12 17:18:53.253+0900 W/W_HOME  (  732): clock_indicator.c: clock_indicator_pop(370) > icon:5(0) is popped from clock indicator
05-12 17:18:53.278+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-12 17:18:53.278+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-12 17:18:53.278+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-12 17:18:53.293+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [63 / 63] bytes. 
05-12 17:18:53.298+0900 W/W_INDICATOR(  699): windicator_scs.c: windicator_scs_update(46) > [windicator_scs_update:46] sap connected : 1
05-12 17:18:53.298+0900 I/W_INDICATOR(  699): windicator.c: windicator_is_lo_connected(689) > [windicator_is_lo_connected:689] Connected target vendor : samsung
05-12 17:18:53.298+0900 W/W_INDICATOR(  699): windicator_scs.c: windicator_scs_update(81) > [windicator_scs_update:81] sap connectivity type : 16
05-12 17:18:53.303+0900 W/W_INDICATOR(  699): windicator_scs.c: windicator_scs_update(88) > [windicator_scs_update:88] network status : 2
05-12 17:18:53.303+0900 W/W_INDICATOR(  699): windicator_scs.c: windicator_scs_update(103) > [windicator_scs_update:103] scs login : 1
05-12 17:18:53.303+0900 W/W_INDICATOR(  699): windicator_scs.c: windicator_scs_update(112) > [windicator_scs_update:112] network connection via WIFI : no checking svc_type
05-12 17:18:53.303+0900 W/W_INDICATOR(  699): windicator_scs.c: windicator_scs_update(149) > [windicator_scs_update:149] ciss_request_type : 0
05-12 17:18:53.308+0900 I/W_INDICATOR(  699): windicator_scs.c: windicator_scs_update(159) > [windicator_scs_update:159] Hide (Callforwarding requested)
05-12 17:18:54.298+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:18:54.303+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:18:54.313+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-12 17:18:54.328+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-12 17:18:54.328+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-12 17:18:54.328+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-12 17:18:54.463+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.463+0900 I/efl-extension( 6861): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.463+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.528+0900 I/efl-extension( 6861): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.528+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.528+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.583+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.583+0900 I/efl-extension( 6861): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.583+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.658+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.658+0900 I/efl-extension( 6861): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.658+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.723+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.723+0900 I/efl-extension( 6861): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:54.723+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:18:55.418+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:18:55.418+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:19:00.453+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:19:00.543+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-12 17:19:00.543+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-12 17:19:00.583+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : pedometer_inactive_period error
05-12 17:19:00.583+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:19:00.593+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:19:00.603+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_10min_precaution_millisec error
05-12 17:19:00.613+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:19:00.613+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:19:00.618+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_before_10min_precaution_millisec error
05-12 17:19:10.343+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 17:19:10.343+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 17:19:40.963+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 17:19:50.993+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 17:20:00.523+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:20:03.438+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 74 -> 73 1463041203 150
05-12 17:20:03.443+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 73 1914 384 2329
05-12 17:20:03.473+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 73 0 0 2821
05-12 17:20:03.473+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 73 1532 646 1864
05-12 17:20:03.478+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 73 126 5 153
05-12 17:20:03.478+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 73 426 25 518
05-12 17:20:10.403+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 17:20:10.403+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 17:21:00.593+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:21:10.348+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 17:21:10.353+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 17:22:00.663+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:22:10.383+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 17:22:10.383+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 17:23:00.733+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:23:10.383+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 17:23:10.383+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 17:23:28.348+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:23:28.348+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:23:28.533+0900 E/EFL     ( 6861): evas_main<6861> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5019721 button=1 downs=1
05-12 17:23:28.703+0900 E/EFL     ( 6861): evas_main<6861> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5019895 button=1 downs=0
05-12 17:23:28.783+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-12 17:23:28.783+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:23:28.783+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:23:28.783+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-12 17:23:28.783+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-12 17:23:28.783+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-12 17:23:29.093+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-12 17:23:29.098+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-12 17:23:29.103+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-12 17:23:29.108+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-12 17:23:29.193+0900 W/STARTER (  698): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-12 17:23:29.268+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-12 17:23:29.268+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-12 17:23:29.288+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-12 17:23:29.288+0900 W/STARTER (  698): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-12 17:23:29.383+0900 W/STARTER (  698): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-12 17:23:29.638+0900 E/WMS     (  485): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-12 17:23:29.648+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-12 17:23:29.648+0900 E/WMS     (  485): ==========
05-12 17:23:29.648+0900 E/WMS     (  485): ##WMS SEND : mgr_gear_wear_onoff_req
05-12 17:23:29.648+0900 E/WMS     (  485): ==========
05-12 17:23:29.668+0900 W/STARTER (  698): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-12 17:23:29.673+0900 W/STARTER (  698): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-12 17:23:29.718+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-12 17:23:29.743+0900 E/STARTER (  698): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-12 17:23:29.743+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 0
05-12 17:23:29.753+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(1702) > caller pid : 698
05-12 17:23:29.763+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(2080) > pad pid(-5)
05-12 17:23:29.763+0900 W/AUL_PAD ( 1132): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-12 17:23:29.763+0900 W/AUL_PAD ( 1132): launchpad.c: __send_result_to_caller(272) > Check app launching
05-12 17:23:29.773+0900 E/RESOURCED(  494): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-12 17:23:29.793+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-12 17:23:29.798+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-12 17:23:29.798+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-12 17:23:29.798+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [63 / 63] bytes. 
05-12 17:23:29.803+0900 I/CAPI_APPFW_APPLICATION( 6972): app_main.c: app_efl_main(129) > app_efl_main
05-12 17:23:29.813+0900 I/CAPI_APPFW_APPLICATION( 6972): app_main.c: app_appcore_create(152) > app_appcore_create
05-12 17:23:29.868+0900 E/RESOURCED(  494): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-12 17:23:29.868+0900 E/AUL     (  698): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-12 17:23:29.958+0900 I/efl-extension( 6972): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445d2628 = w: 0 h: 0  obj 0x445b95e8 w: 360 h: 360
05-12 17:23:29.958+0900 I/efl-extension( 6972): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-12 17:23:29.963+0900 I/efl-extension( 6972): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-12 17:23:29.963+0900 I/efl-extension( 6972): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-12 17:23:29.963+0900 I/efl-extension( 6972): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-12 17:23:29.968+0900 I/efl-extension( 6972): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-12 17:23:29.968+0900 I/efl-extension( 6972): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445b95e8, elm_image, _activated_obj : 0x0, activated : 1
05-12 17:23:30.063+0900 E/W_TASKMANAGER( 6972): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-12 17:23:30.068+0900 E/W_TASKMANAGER( 6972): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-12 17:23:30.068+0900 E/W_TASKMANAGER( 6972): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-12 17:23:30.108+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.113+0900 E/W_TASKMANAGER( 6972): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-12 17:23:30.118+0900 E/RUA     ( 6972): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 16, ncols : 5
05-12 17:23:30.148+0900 E/EFL     ( 6972): elementary<6972> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445bb268 into part 'elm.swallow.event.0'
05-12 17:23:30.188+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x02e00003)
05-12 17:23:30.188+0900 I/APP_CORE( 6972): appcore-efl.c: __do_app(429) > [APP 6972] Event: RESET State: CREATED
05-12 17:23:30.193+0900 I/CAPI_APPFW_APPLICATION( 6972): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-12 17:23:30.208+0900 I/APP_CORE( 6972): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-12 17:23:30.208+0900 I/APP_CORE( 6972): appcore-efl.c: __do_app(474) > [APP 6972] Initial Launching, call the resume_cb
05-12 17:23:30.208+0900 I/CAPI_APPFW_APPLICATION( 6972): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-12 17:23:30.248+0900 E/E17     (  381): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02e00003)
05-12 17:23:30.258+0900 W/APP_CORE( 6972): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00003
05-12 17:23:30.328+0900 I/APP_CORE( 6861): appcore-efl.c: __do_app(429) > [APP 6861] Event: PAUSE State: RUNNING
05-12 17:23:30.328+0900 I/CAPI_APPFW_APPLICATION( 6861): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-12 17:23:30.333+0900 I/APP_CORE( 6972): appcore-efl.c: __do_app(429) > [APP 6972] Event: RESUME State: RUNNING
05-12 17:23:30.368+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-12 17:23:30.368+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-12 17:23:30.663+0900 E/EFL     ( 6972): evas_main<6972> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5021855 button=1 downs=1
05-12 17:23:30.718+0900 E/EFL     ( 6972): evas_main<6972> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5021908 button=1 downs=0
05-12 17:23:30.743+0900 E/AUL     (  493): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-12 17:23:30.808+0900 I/MALI    ( 6972): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-12 17:23:30.978+0900 E/EFL     ( 6972): elementary<6972> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(4456e2a0), freeze(1)
05-12 17:23:30.978+0900 E/EFL     ( 6972): elementary<6972> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(4456e2a0), freeze(1)
05-12 17:23:31.018+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:23:31.038+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6972
05-12 17:23:31.043+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-12 17:23:31.358+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 17:23:31.368+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6861
05-12 17:23:31.368+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 27
05-12 17:23:31.373+0900 I/APP_CORE( 6861): appcore-efl.c: __do_app(429) > [APP 6861] Event: TERMINATE State: PAUSED
05-12 17:23:31.388+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-12 17:23:31.388+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-12 17:23:31.433+0900 I/APP_CORE( 6861): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-12 17:23:31.433+0900 I/CAPI_APPFW_APPLICATION( 6861): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-12 17:23:31.463+0900 I/efl-extension( 6861): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4189bab0, obj: 0x4189bab0
05-12 17:23:31.468+0900 I/efl-extension( 6861): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-12 17:23:31.468+0900 I/efl-extension( 6861): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-12 17:23:31.468+0900 I/efl-extension( 6861): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-12 17:23:31.468+0900 I/efl-extension( 6861): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-12 17:23:31.483+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 17:23:31.493+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-12 17:23:31.493+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-12 17:23:31.493+0900 E/APP_CORE( 6972): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-12 17:23:31.493+0900 I/APP_CORE( 6972): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-12 17:23:31.493+0900 I/APP_CORE( 6972): appcore-efl.c: __after_loop(1090) > [APP 6972] PAUSE before termination
05-12 17:23:31.493+0900 I/CAPI_APPFW_APPLICATION( 6972): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-12 17:23:31.493+0900 I/CAPI_APPFW_APPLICATION( 6972): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-12 17:23:31.498+0900 I/efl-extension( 6972): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4456e2a0, obj: 0x4456e2a0
05-12 17:23:31.498+0900 I/efl-extension( 6972): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-12 17:23:31.498+0900 I/efl-extension( 6972): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-12 17:23:31.498+0900 I/efl-extension( 6972): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-12 17:23:31.498+0900 I/efl-extension( 6972): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-12 17:23:31.503+0900 I/efl-extension( 6972): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445b95e8
05-12 17:23:31.508+0900 I/efl-extension( 6972): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-12 17:23:31.508+0900 I/efl-extension( 6972): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445d2628 is freed
05-12 17:23:31.508+0900 I/efl-extension( 6972): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-12 17:23:31.508+0900 I/efl-extension( 6972): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4456e2a0, elm_scroller, func : 0x437c8ef1
05-12 17:23:31.508+0900 I/efl-extension( 6972): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-12 17:23:31.508+0900 I/efl-extension( 6972): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-12 17:23:31.508+0900 I/efl-extension( 6972): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445b95e8, elm_image, func : 0x437c8ef1
05-12 17:23:31.508+0900 I/efl-extension( 6972): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-12 17:23:31.508+0900 I/efl-extension( 6972): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x4456e2a0 : elm_scroller] rotary callabck is deleted
05-12 17:23:31.528+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-12 17:23:31.528+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-12 17:23:31.573+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-12 17:23:31.573+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-12 17:23:31.573+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
05-12 17:23:31.573+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-12 17:23:31.573+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.573+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.573+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.573+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-12 17:23:31.593+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-12 17:23:31.593+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-12 17:23:31.593+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.593+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-12 17:23:31.593+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-12 17:23:31.593+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-12 17:23:31.593+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-12 17:23:31.593+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-12 17:23:31.593+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.593+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.593+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.593+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:23:31.593+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x46f639e0
05-12 17:23:31.593+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46f639e0, elm_layout, _activated_obj : 0x45c95f90, activated : 1
05-12 17:23:31.593+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-12 17:23:31.593+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-12 17:23:31.593+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 17:23:31.593+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-12 17:23:31.593+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 17:23:31.593+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 17:23:31.593+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 17:23:31.593+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 17:23:31.608+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:23:31.608+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:23:31.633+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-12 17:23:31.633+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
05-12 17:23:31.638+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-12 17:23:31.638+0900 W/W_HOME  (  732): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-12 17:23:31.638+0900 W/W_HOME  (  732): gesture.c: _manual_render_enable(133) > 1
05-12 17:23:31.638+0900 W/W_HOME  (  732): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-12 17:23:31.638+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.638+0900 I/UXT     ( 6861): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-12 17:23:31.643+0900 W/STARTER (  698): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
05-12 17:23:31.643+0900 W/STARTER (  698): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-12 17:23:31.643+0900 E/STARTER (  698): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-12 17:23:31.643+0900 W/STARTER (  698): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-12 17:23:31.643+0900 W/STARTER (  698): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-12 17:23:31.663+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-12 17:23:31.663+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-12 17:23:31.663+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-12 17:23:31.668+0900 I/TIZEN_N_SOUND_MANAGER( 1091): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-12 17:23:31.673+0900 I/TIZEN_N_SOUND_MANAGER( 1091): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-12 17:23:31.673+0900 W/TIZEN_N_SOUND_MANAGER( 1091): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-12 17:23:31.673+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-12 17:23:31.673+0900 I/HIGEAR  ( 1091): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-12 17:23:31.693+0900 I/efl-extension( 7073): efl_extension.c: eext_mod_init(40) > Init
05-12 17:23:31.733+0900 I/UXT     ( 7073): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-12 17:23:31.773+0900 I/MALI    ( 6972): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-12 17:23:31.803+0900 W/STARTER (  698): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
05-12 17:23:31.803+0900 W/STARTER (  698): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-12 17:23:31.808+0900 W/STARTER (  698): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-12 17:23:31.808+0900 W/STARTER (  698): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-12 17:23:31.808+0900 I/MALI    ( 6972): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-12 17:23:31.808+0900 I/MALI    ( 6972): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=6972   close drm_fd=22 
05-12 17:23:31.808+0900 I/MALI    ( 6972): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-12 17:23:31.823+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: PAUSE State: RUNNING
05-12 17:23:31.823+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-12 17:23:31.823+0900 W/W_HOME  (  732): main.c: _appcore_pause_cb(690) > appcore pause
05-12 17:23:31.823+0900 W/W_HOME  (  732): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-12 17:23:31.823+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.823+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.823+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-12 17:23:31.823+0900 W/W_HOME  (  732): rotary.c: rotary_deattach(156) > rotary_deattach:0x46f639e0
05-12 17:23:31.823+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-12 17:23:31.823+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46f639e0, elm_layout, func : 0x4004b469
05-12 17:23:31.823+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-12 17:23:31.823+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-12 17:23:31.823+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-12 17:23:31.823+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c95f90, elm_box, _activated_obj : 0x46f639e0, activated : 1
05-12 17:23:31.823+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-12 17:23:31.823+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 17:23:31.823+0900 I/wnotib  (  732): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 119, 218.
05-12 17:23:31.823+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-12 17:23:31.843+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 17:23:31.843+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 17:23:31.843+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 17:23:31.843+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-12 17:23:31.843+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-12 17:23:31.843+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 17:23:31.843+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-12 17:23:31.843+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 17:23:31.863+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-12 17:23:31.863+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-12 17:23:31.863+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-12 17:23:31.863+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-12 17:23:31.863+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-12 17:23:31.863+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-12 17:23:31.863+0900 I/MESSAGE_PORT(  448): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-12 17:23:31.863+0900 I/MESSAGE_PORT(  448): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-12 17:23:31.863+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-12 17:23:31.863+0900 I/MESSAGE_PORT(  448): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-12 17:23:31.868+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 17:23:31.868+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 17:23:31.868+0900 W/MUSIC_CONTROL_SERVICE( 1163): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1163]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-12 17:23:31.878+0900 E/ALARM_MANAGER(  698): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(12-5-2016, 17:23:52), repeat(1), interval(20), type(-1073741822)
05-12 17:23:31.903+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-12 17:23:31.903+0900 W/ALARM_MANAGER(  487): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-12 17:23:31.953+0900 I/UXT     ( 6972): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-12 17:23:31.998+0900 E/CAPI_APPFW_APP_CONTROL( 1163): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-12 17:23:31.998+0900 W/MUSIC_CONTROL_SERVICE( 1163): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1163]   [com.samsung.w-home]register msg port [false][0m
05-12 17:23:32.008+0900 W/APPS    (  732): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-12 17:23:32.033+0900 E/ALARM_MANAGER(  487): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1540109440, next duetime: 1463041432
05-12 17:23:32.033+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1540109440)
05-12 17:23:32.033+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1463042169), due_time(1463041432)
05-12 17:23:32.033+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-12 17:23:32.033+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 12-5-2016, 08:23:52 (UTC).
05-12 17:23:32.033+0900 E/ALARM_MANAGER(  487): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-12 17:23:32.043+0900 I/SHealth_Common( 1035): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-12 17:23:32.043+0900 I/SHealth_Service( 1035): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-12 17:23:32.118+0900 I/AUL_PAD ( 7073): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-12 17:23:32.148+0900 E/TBM     ( 7073): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-12 17:23:32.243+0900 I/AUL_AMD (  493): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6861
05-12 17:23:32.328+0900 I/efl-extension( 6972): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-12 17:23:32.343+0900 W/CRASH_MANAGER( 7085): worker.c: worker_job(1199) > 1106861706831146304141
