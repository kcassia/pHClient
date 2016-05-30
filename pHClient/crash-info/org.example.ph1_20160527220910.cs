S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 1635
Date: 2016-05-27 22:09:10+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4049f250, r3   = 0x00000000
r4   = 0x4612f6f0, r5   = 0x00000000
r6   = 0x4612fff0, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x44327970
r10  = 0x45448828, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbebbb638
lr   = 0x403e81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     15252 KB
Buffers:     23576 KB
Cached:     182276 KB
VmPeak:     111508 KB
VmSize:      99252 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21576 KB
VmRSS:       21576 KB
VmData:      43616 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 1635 TID = 1635
1635 1642 1645 1783 

Maps Information
40000000 40007000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
4000e000 4000f000 rwxp /opt/usr/apps/org.example.ph1/bin/ph1
4000f000 4002c000 r-xp /lib/ld-2.13.so
40033000 40034000 r-xp /lib/ld-2.13.so
40034000 40035000 rwxp /lib/ld-2.13.so
40035000 40039000 r-xp /usr/lib/libsys-assert.so
40041000 40042000 rwxp /usr/lib/libsys-assert.so
40057000 4006b000 r-xp /lib/libpthread-2.13.so
40072000 40073000 r-xp /lib/libpthread-2.13.so
40073000 40074000 rwxp /lib/libpthread-2.13.so
40076000 40078000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40080000 40081000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40081000 40085000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4008c000 4008d000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4008d000 40095000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.2.5
4009c000 4009d000 rwxp /usr/lib/libcapi-appfw-preference.so.0.3.2.5
4009d000 400aa000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
400b1000 400b2000 rwxp /usr/lib/libcapi-network-connection.so.1.0.51
400b2000 400b7000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
400be000 400bf000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
400bf000 400c3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
400cb000 400cc000 rwxp /usr/lib/libcapi-system-sensor.so.0.1.18
400cc000 400d4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
400d4000 400d5000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
400d5000 400d7000 r-xp /usr/lib/libdlog.so.0.0.0
400de000 400df000 rwxp /usr/lib/libdlog.so.0.0.0
400df000 400f6000 r-xp /usr/lib/libecore.so.1.7.99
400fe000 400ff000 rwxp /usr/lib/libecore.so.1.7.99
4010d000 4012e000 r-xp /usr/lib/libefl-extension.so.0.1.0
40135000 40136000 rwxp /usr/lib/libefl-extension.so.0.1.0
40136000 40270000 r-xp /usr/lib/libelementary.so.1.7.99
40277000 4027f000 rwxp /usr/lib/libelementary.so.1.7.99
40286000 40354000 r-xp /usr/lib/libevas.so.1.7.99
4035c000 40366000 rwxp /usr/lib/libevas.so.1.7.99
40379000 40494000 r-xp /lib/libc-2.13.so
4049c000 4049e000 r-xp /lib/libc-2.13.so
4049e000 4049f000 rwxp /lib/libc-2.13.so
404a2000 404ad000 r-xp /lib/libunwind.so.8.0.1
404b4000 404b5000 rwxp /lib/libunwind.so.8.0.1
404da000 404dc000 r-xp /lib/libdl-2.13.so
404e3000 404e4000 r-xp /lib/libdl-2.13.so
404e4000 404e5000 rwxp /lib/libdl-2.13.so
404e5000 404ed000 r-xp /lib/libgcc_s-4.6.so.1
404ed000 404ee000 rwxp /lib/libgcc_s-4.6.so.1
404ee000 404fa000 r-xp /usr/lib/libaul.so.0.1.0
40502000 40503000 rwxp /usr/lib/libaul.so.0.1.0
40504000 40526000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4052d000 4052e000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
4052e000 40532000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4053a000 4053b000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4053b000 40540000 r-xp /usr/lib/libappcore-efl.so.1.1
40547000 40548000 rwxp /usr/lib/libappcore-efl.so.1.1
40548000 4054d000 r-xp /usr/lib/libappcore-common.so.1.1
40554000 40555000 rwxp /usr/lib/libappcore-common.so.1.1
40555000 40596000 r-xp /usr/lib/libeina.so.1.7.99
4059d000 4059f000 rwxp /usr/lib/libeina.so.1.7.99
4059f000 4066f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4066f000 40670000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
40670000 40674000 r-xp /usr/lib/libvconf.so.0.2.45
4067b000 4067c000 rwxp /usr/lib/libvconf.so.0.2.45
4067c000 40693000 r-xp /usr/lib/libnetwork.so.0.0.0
4069a000 4069b000 rwxp /usr/lib/libnetwork.so.0.0.0
4069b000 406a0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
406a7000 406a8000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
406a8000 4077b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40782000 40786000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
40786000 407ba000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
407c1000 407c3000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
407c3000 407e1000 r-xp /usr/lib/libsensor.so.1.1.0
407e9000 407ea000 rwxp /usr/lib/libsensor.so.1.1.0
407eb000 4087f000 r-xp /usr/lib/libstdc++.so.6.0.16
40887000 4088a000 r-xp /usr/lib/libstdc++.so.6.0.16
4088a000 4088c000 rwxp /usr/lib/libstdc++.so.6.0.16
40892000 408fb000 r-xp /lib/libm-2.13.so
40902000 40903000 r-xp /lib/libm-2.13.so
40903000 40904000 rwxp /lib/libm-2.13.so
40904000 40954000 r-xp /usr/lib/libecore_x.so.1.7.99
40954000 40956000 rwxp /usr/lib/libecore_x.so.1.7.99
40956000 40978000 r-xp /usr/lib/libecore_evas.so.1.7.99
4097f000 40981000 rwxp /usr/lib/libecore_evas.so.1.7.99
40981000 409a9000 r-xp /usr/lib/libfontconfig.so.1.8.0
409a9000 409aa000 rwxp /usr/lib/libfontconfig.so.1.8.0
409aa000 40a76000 r-xp /usr/lib/libxml2.so.2.7.8
40a7d000 40a82000 rwxp /usr/lib/libxml2.so.2.7.8
40a83000 40a95000 r-xp /usr/lib/libefl-assist.so.0.1.0
40a9c000 40a9d000 rwxp /usr/lib/libefl-assist.so.0.1.0
40a9d000 40aa3000 r-xp /lib/librt-2.13.so
40aaa000 40aab000 r-xp /lib/librt-2.13.so
40aab000 40aac000 rwxp /lib/librt-2.13.so
40aac000 40b09000 r-xp /usr/lib/libedje.so.1.7.99
40b11000 40b13000 rwxp /usr/lib/libedje.so.1.7.99
40b13000 40bcb000 r-xp /usr/lib/libcairo.so.2.11200.14
40bd2000 40bd5000 rwxp /usr/lib/libcairo.so.2.11200.14
40bd6000 40cb7000 r-xp /usr/lib/libX11.so.6.3.0
40cbe000 40cc2000 rwxp /usr/lib/libX11.so.6.3.0
40cc2000 40ccb000 r-xp /usr/lib/libXi.so.6.1.0
40cd2000 40cd3000 rwxp /usr/lib/libXi.so.6.1.0
40cd3000 40cec000 r-xp /usr/lib/libeet.so.1.7.99
40cf4000 40cf5000 rwxp /usr/lib/libeet.so.1.7.99
40cfd000 40d02000 r-xp /usr/lib/libecore_file.so.1.7.99
40d09000 40d0a000 rwxp /usr/lib/libecore_file.so.1.7.99
40d0a000 40d1b000 r-xp /usr/lib/libecore_input.so.1.7.99
40d22000 40d23000 rwxp /usr/lib/libecore_input.so.1.7.99
40d23000 40d2c000 r-xp /usr/lib/libedbus.so.1.7.99
40d33000 40d34000 rwxp /usr/lib/libedbus.so.1.7.99
40d34000 40d5e000 r-xp /usr/lib/libdbus-1.so.3.8.12
40d66000 40d67000 rwxp /usr/lib/libdbus-1.so.3.8.12
40d67000 40d81000 r-xp /usr/lib/libecore_con.so.1.7.99
40d88000 40d89000 rwxp /usr/lib/libecore_con.so.1.7.99
40d8a000 40d9d000 r-xp /usr/lib/libfribidi.so.0.3.1
40da4000 40da5000 rwxp /usr/lib/libfribidi.so.0.3.1
40da5000 40de2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40de9000 40dea000 rwxp /usr/lib/libharfbuzz.so.0.940.0
40deb000 40e41000 r-xp /usr/lib/libfreetype.so.6.11.3
40e49000 40e4d000 rwxp /usr/lib/libfreetype.so.6.11.3
40e4d000 40ea3000 r-xp /usr/lib/libpixman-1.so.0.28.2
40eab000 40eb0000 rwxp /usr/lib/libpixman-1.so.0.28.2
40eb0000 40eb3000 r-xp /usr/lib/libbundle.so.0.1.22
40eba000 40ebb000 rwxp /usr/lib/libbundle.so.0.1.22
40ebb000 40ed2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40ed9000 40eda000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
40eda000 40edf000 r-xp /usr/lib/libxdgmime.so.1.1.0
40ee6000 40ee7000 rwxp /usr/lib/libxdgmime.so.1.1.0
40ee7000 40f23000 r-xp /usr/lib/libsystemd.so.0.4.0
40f2a000 40f2b000 r-xp /usr/lib/libsystemd.so.0.4.0
40f2b000 40f2c000 rwxp /usr/lib/libsystemd.so.0.4.0
40f2c000 40f2f000 r-xp /usr/lib/libproc-stat.so.0.2.86
40f36000 40f37000 rwxp /usr/lib/libproc-stat.so.0.2.86
40f37000 40f4d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40f54000 40f55000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
40f55000 40fca000 r-xp /usr/lib/libsqlite3.so.0.8.6
40fd1000 40fd4000 rwxp /usr/lib/libsqlite3.so.0.8.6
40fd4000 40fda000 r-xp /usr/lib/libappsvc.so.0.1.0
40fe1000 40fe2000 rwxp /usr/lib/libappsvc.so.0.1.0
40fe2000 40fe8000 r-xp /usr/lib/libecore_imf.so.1.7.99
40fef000 40ff0000 rwxp /usr/lib/libecore_imf.so.1.7.99
40ff0000 40ff2000 r-xp /usr/lib/libiniparser.so.0
40ffa000 40ffb000 rwxp /usr/lib/libiniparser.so.0
40ffb000 4102c000 r-xp /usr/lib/libmdm.so.1.1.85
41033000 41034000 rwxp /usr/lib/libmdm.so.1.1.85
41034000 41035000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4103c000 4103d000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
4103d000 41042000 r-xp /usr/lib/libffi.so.5.0.10
41049000 4104a000 rwxp /usr/lib/libffi.so.5.0.10
4104a000 4104c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41053000 41054000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
41054000 4106a000 r-xp /lib/libz.so.1.2.5
41071000 41072000 rwxp /lib/libz.so.1.2.5
41072000 41082000 r-xp /lib/libresolv-2.13.so
41082000 41083000 r-xp /lib/libresolv-2.13.so
41083000 41084000 rwxp /lib/libresolv-2.13.so
41086000 4108d000 r-xp /usr/lib/libsensord-share.so
41094000 41095000 rwxp /usr/lib/libsensord-share.so
41095000 4109c000 r-xp /usr/lib/libXcursor.so.1.0.2
410a3000 410a4000 rwxp /usr/lib/libXcursor.so.1.0.2
410a4000 410a6000 r-xp /usr/lib/libXdamage.so.1.1.0
410ad000 410ae000 rwxp /usr/lib/libXdamage.so.1.1.0
410ae000 410b0000 r-xp /usr/lib/libXcomposite.so.1.0.0
410b7000 410b8000 rwxp /usr/lib/libXcomposite.so.1.0.0
410b8000 410ba000 r-xp /usr/lib/libXgesture.so.7.0.0
410c1000 410c2000 rwxp /usr/lib/libXgesture.so.7.0.0
410c3000 410c6000 r-xp /usr/lib/libXfixes.so.3.1.0
410cd000 410ce000 rwxp /usr/lib/libXfixes.so.3.1.0
410ce000 410cf000 r-xp /usr/lib/libXinerama.so.1.0.0
410d7000 410d8000 rwxp /usr/lib/libXinerama.so.1.0.0
410d8000 410de000 r-xp /usr/lib/libXrandr.so.2.2.0
410e5000 410e6000 rwxp /usr/lib/libXrandr.so.2.2.0
410e6000 410ec000 r-xp /usr/lib/libXrender.so.1.3.0
410f3000 410f4000 rwxp /usr/lib/libXrender.so.1.3.0
410f4000 410f8000 r-xp /usr/lib/libXtst.so.6.1.0
410ff000 41100000 rwxp /usr/lib/libXtst.so.6.1.0
41100000 4110a000 r-xp /usr/lib/libXext.so.6.4.0
41112000 41113000 rwxp /usr/lib/libXext.so.6.4.0
41114000 41119000 r-xp /usr/lib/libecore_fb.so.1.7.99
41120000 41122000 rwxp /usr/lib/libecore_fb.so.1.7.99
41122000 41126000 r-xp /usr/lib/libecore_ipc.so.1.7.99
4112e000 4112f000 rwxp /usr/lib/libecore_ipc.so.1.7.99
4112f000 41132000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
41139000 4113a000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
4113a000 41150000 r-xp /lib/libexpat.so.1.5.2
41158000 4115a000 rwxp /lib/libexpat.so.1.5.2
4115a000 4116c000 r-xp /usr/lib/libtts.so
41173000 41174000 rwxp /usr/lib/libtts.so
41175000 41196000 r-xp /usr/lib/libui-extension.so.0.1.0
4119e000 4119f000 rwxp /usr/lib/libui-extension.so.0.1.0
4119f000 411a6000 r-xp /usr/lib/libtbm.so.1.0.0
411ad000 411ae000 rwxp /usr/lib/libtbm.so.1.0.0
411ae000 411b5000 r-xp /usr/lib/libembryo.so.1.7.99
411bc000 411bd000 rwxp /usr/lib/libembryo.so.1.7.99
411bd000 411d4000 r-xp /usr/lib/liblua-5.1.so
411dc000 411dd000 rwxp /usr/lib/liblua-5.1.so
411dd000 411de000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
411e5000 411e6000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
411e7000 411f5000 r-xp /usr/lib/libGLESv2.so.2.0
411fd000 411fe000 rwxp /usr/lib/libGLESv2.so.2.0
411fe000 41216000 r-xp /usr/lib/libpng12.so.0.50.0
4121d000 4121e000 rwxp /usr/lib/libpng12.so.0.50.0
4121e000 4121f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41227000 41228000 rwxp /usr/lib/libxcb-shm.so.0.0.0
41228000 4122e000 r-xp /usr/lib/libxcb-render.so.0.0.0
41235000 41236000 rwxp /usr/lib/libxcb-render.so.0.0.0
41236000 41249000 r-xp /usr/lib/libxcb.so.1.1.0
41251000 41252000 rwxp /usr/lib/libxcb.so.1.1.0
41252000 41255000 r-xp /usr/lib/libEGL.so.1.4
4125c000 4125d000 rwxp /usr/lib/libEGL.so.1.4
4125e000 41281000 r-xp /usr/lib/libjpeg.so.8.0.2
41288000 41289000 rwxp /usr/lib/libjpeg.so.8.0.2
41299000 412dd000 r-xp /usr/lib/libcurl.so.4.3.0
412e4000 412e6000 rwxp /usr/lib/libcurl.so.4.3.0
412e6000 412ec000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
412f4000 412f5000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
412f5000 4130d000 r-xp /usr/lib/liblzma.so.5.0.3
41314000 41315000 rwxp /usr/lib/liblzma.so.5.0.3
41316000 41392000 r-xp /usr/lib/libgcrypt.so.20.0.3
41399000 4139e000 rwxp /usr/lib/libgcrypt.so.20.0.3
4139e000 413a0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
413a8000 413a9000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
413a9000 413ab000 r-xp /usr/lib/journal/libjournal.so.0.1.0
413b2000 413b3000 rwxp /usr/lib/journal/libjournal.so.0.1.0
413b3000 413bb000 r-xp /usr/lib/libmdm-common.so.1.0.89
413bb000 413bc000 rwxp /usr/lib/libmdm-common.so.1.0.89
413bd000 414fa000 r-xp /usr/lib/libicui18n.so.51.1
41502000 4150a000 rwxp /usr/lib/libicui18n.so.51.1
4150a000 415ee000 r-xp /usr/lib/libicuuc.so.51.1
415f5000 415ff000 rwxp /usr/lib/libicuuc.so.51.1
41603000 41606000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4160d000 4160e000 rwxp /usr/lib/libcapi-media-image-util.so.0.3.5
4160e000 41611000 r-xp /usr/lib/libsmack.so.1.0.0
41618000 41619000 rwxp /usr/lib/libsmack.so.1.0.0
41619000 41621000 r-xp /usr/lib/libdrm.so.2.4.0
41628000 41629000 rwxp /usr/lib/libdrm.so.2.4.0
4162a000 4162c000 r-xp /usr/lib/libXau.so.6.0.0
41633000 41634000 rwxp /usr/lib/libXau.so.6.0.0
41634000 4163d000 r-xp /usr/lib/libcares.so.2.1.0
41645000 41646000 rwxp /usr/lib/libcares.so.2.1.0
41646000 41674000 r-xp /usr/lib/libidn.so.11.5.44
4167b000 4167c000 rwxp /usr/lib/libidn.so.11.5.44
4167c000 416c9000 r-xp /usr/lib/libssl.so.1.0.0
416d0000 416d5000 rwxp /usr/lib/libssl.so.1.0.0
416d5000 4187d000 r-xp /usr/lib/libcrypto.so.1.0.0
4187d000 41892000 rwxp /usr/lib/libcrypto.so.1.0.0
41897000 418a2000 r-xp /usr/lib/libgpg-error.so.0.15.0
418a9000 418aa000 rwxp /usr/lib/libgpg-error.so.0.15.0
418aa000 42e29000 r-xp /usr/lib/libicudata.so.51.1
42e30000 42e31000 rwxp /usr/lib/libicudata.so.51.1
42e31000 42e36000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42e3e000 42e3f000 rwxp /usr/lib/libmmutil_jpeg.so.0.0.0
42e3f000 42e44000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42e4b000 42e4c000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
42e4d000 42e4f000 r-xp /usr/lib/libdri2.so.0.0.0
42e56000 42e57000 rwxp /usr/lib/libdri2.so.0.0.0
42e57000 42e78000 r-xp /usr/lib/libexif.so.12.3.3
42e7f000 42e8b000 rwxp /usr/lib/libexif.so.12.3.3
42e8b000 42e90000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
42e97000 42e98000 rwxp /usr/lib/libcapi-media-tool.so.0.1.5
42f9f000 43069000 r-xp /usr/lib/libCOREGL.so.4.0
43071000 43073000 rwxp /usr/lib/libCOREGL.so.4.0
4307b000 4309f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
430a6000 430a8000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
430a8000 43177000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4317e000 4318d000 rwxp /usr/lib/libscim-1.0.so.8.2.3
4318d000 431ba000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
431c1000 431c2000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
431c2000 431df000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
431e7000 431e8000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
431e8000 431ea000 r-xp /usr/lib/libiri.so
431f1000 431f2000 rwxp /usr/lib/libiri.so
431f2000 431f5000 r-xp /lib/libcap.so.2.21
431fc000 431fd000 rwxp /lib/libcap.so.2.21
431fd000 43204000 r-xp /lib/libcrypt-2.13.so
4320b000 4320c000 r-xp /lib/libcrypt-2.13.so
4320c000 4320d000 rwxp /lib/libcrypt-2.13.so
43234000 43237000 r-xp /lib/libattr.so.1.1.0
4323e000 4323f000 rwxp /lib/libattr.so.1.1.0
4323f000 43249000 r-xp /lib/libnss_files-2.13.so
43250000 43251000 r-xp /lib/libnss_files-2.13.so
43251000 43252000 rwxp /lib/libnss_files-2.13.so
43252000 43452000 r-xp /usr/share/locale/locale-archive
43452000 43583000 r-xp /usr/share/locale/locale-archive
4360a000 43752000 r-xp /usr/lib/egl/libMali.so
43752000 43757000 rwxp /usr/lib/egl/libMali.so
43758000 4376c000 rwxp [stack:1642]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44383000 44b82000 rwxp [stack:1783]
45382000 45385000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
45385000 45389000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
45389000 45398000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
453d8000 453df000 r-xs /usr/lib/gconv/gconv-modules.cache
45794000 45f93000 rwxp [stack:1645]
464e8000 464eb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
464f2000 464f3000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46532000 46537000 r-xp /usr/lib/libjson.so.0.0.1
4653e000 4653f000 rwxp /usr/lib/libjson.so.0.0.1
465cb000 46603000 r-xp /usr/lib/libpulse.so.0.16.2
46603000 46604000 rwxp /usr/lib/libpulse.so.0.16.2
4664c000 46694000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46694000 46695000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46695000 466d8000 r-xp /usr/lib/libsndfile.so.1.0.25
466df000 466e1000 rwxp /usr/lib/libsndfile.so.1.0.25
466e5000 46707000 r-xp /usr/lib/libvorbis.so.0.4.3
4670e000 4670f000 rwxp /usr/lib/libvorbis.so.0.4.3
4670f000 46713000 r-xp /usr/lib/libogg.so.0.7.1
4671a000 4671b000 rwxp /usr/lib/libogg.so.0.7.1
beb9b000 bebbc000 rwxp [stack]
End of Maps Information

Callstack Information (PID:1635)
Call Stack Count: 2
 0: cfree + 0xc8 (0x403e81e8) [/lib/libc.so.6] + 0x6f1e8
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
: _process_raw_event(444) > direction: Clockwise
05-27 22:08:00.990+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:00.990+0900 I/efl-extension( 1635): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45448e28, elm_layout, time_stamp : 150022
05-27 22:08:00.990+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:01.000+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-27 22:08:01.000+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-27 22:08:01.000+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: preference_get_double(1214) > preference_get_double(1006) : pedometer_inactive_period error
05-27 22:08:01.000+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-27 22:08:01.005+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-27 22:08:01.005+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: preference_get_double(1214) > preference_get_double(1006) : inactive_10min_precaution_millisec error
05-27 22:08:01.005+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-27 22:08:01.005+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-27 22:08:01.005+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: preference_get_double(1214) > preference_get_double(1006) : inactive_before_10min_precaution_millisec error
05-27 22:08:01.385+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=150418 button=1 downs=1
05-27 22:08:01.440+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=150472 button=1 downs=0
05-27 22:08:01.560+0900 I/DOWNLOAD_PROVIDER(  801): download-provider-client-manager.c: dp_client_manager(738) > client-manager's working is done
05-27 22:08:01.565+0900 W/WIFI_DIRECT_MANAGER( 1022): wifi-direct-client.c: wfd_client_process_request(869) > Client request [3:WIFI_DIRECT_CMD_DEREGISTER], 28 bytes read from socket[6]
05-27 22:08:01.640+0900 I/CAPI_NETWORK_CONNECTION(  801): connection.c: __connection_set_type_changed_callback(163) > Successfully de-registered(0)
05-27 22:08:01.675+0900 I/CAPI_NETWORK_CONNECTION(  801): connection.c: __connection_set_ip_changed_callback(248) > Successfully de-registered(0)
05-27 22:08:01.700+0900 I/CAPI_NETWORK_CONNECTION(  801): connection.c: connection_destroy(390) > Destroy handle: 0x42f00c08
05-27 22:08:01.735+0900 I/DOWNLOAD_PROVIDER(  801): download-provider-main.c: main(64) > download-provider's working is done
05-27 22:08:03.055+0900 E/SHealth_Common( 1006): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-27 22:08:03.140+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=152172 button=1 downs=1
05-27 22:08:03.205+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=152241 button=1 downs=0
05-27 22:08:05.335+0900 E/TIZEN_N_SYSTEM_SETTINGS(  786): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-27 22:08:05.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  786): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-27 22:08:05.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  786): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-27 22:08:05.350+0900 E/TIZEN_N_SYSTEM_SETTINGS(  786): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-27 22:08:06.864+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=155899 button=1 downs=1
05-27 22:08:06.965+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=156001 button=1 downs=0
05-27 22:08:06.965+0900 D/TIMER   ( 1635): Setting time is 1800
05-27 22:08:06.965+0900 I/efl-extension( 1635): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 22:08:06.965+0900 I/efl-extension( 1635): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45448e28, elm_layout, func : 0x400038c1
05-27 22:08:06.965+0900 I/efl-extension( 1635): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 22:08:06.965+0900 I/efl-extension( 1635): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 22:08:06.965+0900 I/efl-extension( 1635): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 22:08:06.965+0900 I/efl-extension( 1635): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 22:08:06.970+0900 I/efl-extension( 1635): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 22:08:06.970+0900 I/efl-extension( 1635): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 22:08:07.050+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:07.170+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:07.305+0900 I/SENSOR  ( 1635): -4.550000, -4.270000, 1.400000
05-27 22:08:07.310+0900 I/SENSOR  ( 1635): -5.320000, -4.410000, 0.490000
05-27 22:08:07.325+0900 I/SENSOR  ( 1635): 2.100000, -2.870000, 2.520000
05-27 22:08:07.425+0900 I/SENSOR  ( 1635): -0.350000, -5.950000, 3.220000
05-27 22:08:07.525+0900 I/SENSOR  ( 1635): -5.740000, -4.900000, 2.240000
05-27 22:08:07.625+0900 I/SENSOR  ( 1635): -1.120000, -4.900000, 3.360000
05-27 22:08:07.725+0900 I/SENSOR  ( 1635): -1.540000, -3.780000, 4.480000
05-27 22:08:07.830+0900 I/SENSOR  ( 1635): -1.330000, -3.990000, 4.060000
05-27 22:08:07.925+0900 I/SENSOR  ( 1635): -4.270000, -4.550000, 2.870000
05-27 22:08:08.025+0900 I/SENSOR  ( 1635): -1.050000, -14.490000, 5.390000
05-27 22:08:08.130+0900 I/SENSOR  ( 1635): -198.869995, -142.589996, -188.229996
05-27 22:08:08.225+0900 I/SENSOR  ( 1635): -13.510000, -50.119999, 170.800003
05-27 22:08:08.325+0900 I/SENSOR  ( 1635): 31.150000, 27.930000, 4.830000
05-27 22:08:08.435+0900 I/SENSOR  ( 1635): -6.930000, -56.420002, -33.459999
05-27 22:08:08.530+0900 I/SENSOR  ( 1635): 108.010002, 55.020000, -44.590000
05-27 22:08:08.630+0900 I/SENSOR  ( 1635): -19.180000, 52.920002, -9.170000
05-27 22:08:08.730+0900 I/SENSOR  ( 1635): 18.690001, 109.620003, 88.269997
05-27 22:08:08.830+0900 I/SENSOR  ( 1635): 27.719999, 10.430000, -17.430000
05-27 22:08:08.925+0900 I/SENSOR  ( 1635): 35.139999, 11.760000, 14.000000
05-27 22:08:09.025+0900 I/SENSOR  ( 1635): 15.330000, -17.780001, 5.320000
05-27 22:08:09.050+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:09.050+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:09.050+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:09.125+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:09.125+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:09.125+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:09.125+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:09.445+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:09.445+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:10.135+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:10.135+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:10.135+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): 19.530001, -7.980000, 13.510000
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): 0.210000, -1.610000, 10.710000
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): -3.080000, -1.610000, 1.260000
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): -4.270000, -2.450000, 5.180000
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): -5.600000, -0.630000, 0.490000
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): -3.430000, -4.410000, 2.100000
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): -7.070000, -4.690000, 0.770000
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): -2.240000, -0.420000, 2.870000
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): 7.770000, -1.190000, 4.690000
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): 14.210000, -0.630000, 6.300000
05-27 22:08:10.135+0900 I/SENSOR  ( 1635): -0.210000, 5.180000, 18.830000
05-27 22:08:10.135+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:10.145+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:10.145+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:10.150+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:10.150+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:10.400+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:10.400+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:10.655+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:10.655+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.085+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.090+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.145+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.145+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.235+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.235+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.310+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.310+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.335+0900 W/WATCH_CORE(  758): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 22:08:12.335+0900 I/WATCH_CORE(  758): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 22:08:12.335+0900 I/CAPI_WATCH_APPLICATION(  758): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 22:08:12.335+0900 E/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 22:08:12.335+0900 I/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 22:08:12.335+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 22:08:12.345+0900 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 22:08:12.350+0900 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 22:08:12.350+0900 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 22:08:12.400+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.400+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.505+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.505+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.610+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.610+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.670+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.670+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.720+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.720+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.750+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.750+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.765+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.765+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.790+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.790+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.815+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.815+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.845+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.845+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.880+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.880+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.920+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.920+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.950+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.950+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.990+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:12.990+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.045+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.050+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.165+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:13.165+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:13.165+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 6.580000, 0.070000, 5.320000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 4.970000, -2.590000, 10.640000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -3.360000, 3.220000, 19.250000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 1.120000, -6.580000, 5.390000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -3.290000, 27.650000, 50.259998
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -4.410000, -2.100000, 8.400000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 1.050000, 9.450000, -5.040000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -37.099998, -48.160000, 39.130001
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 53.270000, -27.719999, 24.850000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -29.680000, -2.310000, -1.960000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 68.389999, 31.570000, -32.830002
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -75.879997, -18.549999, 109.970001
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 53.270000, -38.009998, 13.510000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -101.500000, -72.379997, -1.050000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -61.670002, -37.660000, 41.860001
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 3.360000, 29.049999, 86.940002
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 45.220001, 57.119999, -27.090000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 118.440002, 10.290000, -52.360001
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 49.770000, -6.020000, -44.310001
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 99.889999, -29.820000, -64.470001
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 26.530001, -16.870001, -25.200001
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 38.990002, -42.139999, -52.990002
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 32.200001, -52.360001, -57.889999
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 40.670002, -63.420002, -58.869999
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): 25.549999, -64.540001, -71.400002
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -11.550000, -38.849998, 3.080000
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -43.119999, 27.790001, 61.529999
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -78.540001, 48.650002, 118.160004
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -34.720001, 50.119999, 83.510002
05-27 22:08:13.170+0900 I/SENSOR  ( 1635): -12.670000, 9.730000, 19.180000
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.170+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:13.190+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:13.190+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:13.190+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:13.190+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:13.285+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:13.285+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:13.290+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:13.290+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:13.325+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:13.325+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:13.335+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:13.335+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:13.345+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:13.350+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:13.350+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:13.355+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:13.535+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:13.540+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:13.540+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:13.540+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:13.940+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.940+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.990+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:13.990+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.065+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.065+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.225+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.225+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.365+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.365+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.435+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.435+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.450+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:14.450+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:14.450+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:14.450+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:14.455+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:14.455+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:14.455+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:14.455+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:14.460+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:14.460+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:14.460+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:14.460+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:14.465+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:14.470+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:14.470+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:14.470+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:14.475+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:14.475+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:14.475+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): -30.870001, 27.580000, 4.480000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): -6.790000, 2.940000, -4.760000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): 5.530000, -3.150000, 9.730000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): -6.160000, 4.270000, 15.400000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): 4.970000, -1.540000, 1.330000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): -4.900000, -6.860000, -1.190000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): 3.360000, -1.820000, 5.530000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): -2.170000, 63.770000, 66.919998
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): -3.290000, 39.270000, 62.160000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): 0.350000, -18.690001, -1.120000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): 2.800000, -13.510000, -4.550000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): 23.520000, -11.270000, -19.670000
05-27 22:08:14.485+0900 I/SENSOR  ( 1635): 28.070000, -5.250000, -12.460000
05-27 22:08:14.485+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.485+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.485+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.485+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.485+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.485+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.485+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:14.500+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.500+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.500+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:14.500+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:14.505+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:14.505+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:14.510+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:14.510+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:14.510+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:14.510+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:14.515+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:14.515+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:14.515+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:14.520+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.520+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:14.525+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:14.530+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:14.530+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:14.535+0900 I/SENSOR  ( 1635): 46.060001, -34.509998, -36.259998
05-27 22:08:14.610+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.610+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.610+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.635+0900 I/SENSOR  ( 1635): 25.059999, -24.639999, -19.389999
05-27 22:08:14.735+0900 I/SENSOR  ( 1635): 14.350000, -28.700001, -20.580000
05-27 22:08:14.835+0900 I/SENSOR  ( 1635): 12.040000, -14.630000, -7.070000
05-27 22:08:14.850+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.850+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.850+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:14.850+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:14.860+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:14.860+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:14.860+0900 I/ROTARTY ( 1635): 앞으로
05-27 22:08:14.935+0900 I/SENSOR  ( 1635): 5.390000, -11.900000, -5.810000
05-27 22:08:15.030+0900 I/SENSOR  ( 1635): 27.510000, -31.850000, -21.000000
05-27 22:08:15.100+0900 I/efl-extension( 1635): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:15.100+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:15.100+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:15.135+0900 I/SENSOR  ( 1635): 27.020000, -14.840000, 3.290000
05-27 22:08:15.230+0900 I/SENSOR  ( 1635): 9.660000, 7.910000, 20.580000
05-27 22:08:15.330+0900 I/SENSOR  ( 1635): -18.480000, 11.830000, 28.910000
05-27 22:08:15.435+0900 I/SENSOR  ( 1635): -61.670002, 10.640000, 35.840000
05-27 22:08:15.535+0900 I/SENSOR  ( 1635): -38.849998, 8.680000, 20.090000
05-27 22:08:15.635+0900 I/SENSOR  ( 1635): -16.940001, -1.540000, 11.340000
05-27 22:08:15.735+0900 I/SENSOR  ( 1635): 1.470000, -2.800000, 8.820000
05-27 22:08:15.835+0900 I/SENSOR  ( 1635): 11.480000, -12.670000, -4.200000
05-27 22:08:15.934+0900 I/SENSOR  ( 1635): 11.480000, -14.490000, 3.220000
05-27 22:08:16.025+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=165061 button=1 downs=1
05-27 22:08:16.030+0900 I/SENSOR  ( 1635): -3.920000, -23.170000, -1.400000
05-27 22:08:16.075+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=165108 button=1 downs=0
05-27 22:08:16.075+0900 I/efl-extension( 1635): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 22:08:16.075+0900 I/efl-extension( 1635): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 22:08:16.075+0900 I/efl-extension( 1635): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 22:08:16.090+0900 I/SOCKETTEST( 1635): Success to create socket
05-27 22:08:20.580+0900 I/SOCKETTEST( 1635): Success to socket connection
05-27 22:08:20.585+0900 I/SOCKETTEST( 1635): write() 성공
05-27 22:08:20.655+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=165889 button=1 downs=1
05-27 22:08:20.660+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=165957 button=1 downs=0
05-27 22:08:20.660+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=167056 button=1 downs=1
05-27 22:08:20.660+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=167102 button=1 downs=0
05-27 22:08:20.665+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=167599 button=1 downs=1
05-27 22:08:20.665+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=167690 button=1 downs=0
05-27 22:08:20.665+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=168908 button=1 downs=1
05-27 22:08:20.670+0900 E/EFL     ( 1635): evas_main<1635> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=169010 button=1 downs=0
05-27 22:08:21.100+0900 I/efl-extension( 1635): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x45448e28
05-27 22:08:21.100+0900 I/efl-extension( 1635): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45448e28, obj: 0x45448e28
05-27 22:08:21.100+0900 I/efl-extension( 1635): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 22:08:21.915+0900 W/WATCH_CORE(  758): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 22:08:21.915+0900 I/WATCH_CORE(  758): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 22:08:21.915+0900 I/CAPI_WATCH_APPLICATION(  758): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 22:08:21.915+0900 E/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 22:08:21.915+0900 I/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 22:08:22.950+0900 W/WATCH_CORE(  758): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 22:08:22.950+0900 I/WATCH_CORE(  758): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 22:08:22.950+0900 I/CAPI_WATCH_APPLICATION(  758): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 22:08:22.950+0900 E/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 22:08:22.950+0900 I/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 22:08:23.060+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:23.060+0900 I/efl-extension( 1065): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 22:08:25.025+0900 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-27 22:08:25.025+0900 E/WMS     (  490): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-27 22:08:25.025+0900 E/WMS     (  490): ==========
05-27 22:08:25.025+0900 E/WMS     (  490): ##WMS SEND : mgr_gear_wear_onoff_req
05-27 22:08:25.025+0900 E/WMS     (  490): ==========
05-27 22:08:25.025+0900 E/WMS     (  490): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-27 22:08:25.110+0900 W/SCSD    ( 1220): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-27 22:08:25.110+0900 W/SCSD    ( 1220): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-27 22:08:25.110+0900 W/SCSD    ( 1220): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-27 22:08:25.115+0900 W/SCSD    ( 1220): <util_scs_send:975> sent [63 / 63] bytes. 
05-27 22:08:54.165+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-27 22:08:54.165+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-27 22:09:00.440+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 22:09:01.005+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-27 22:09:01.005+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-27 22:09:01.010+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: preference_get_double(1214) > preference_get_double(1006) : pedometer_inactive_period error
05-27 22:09:01.015+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-27 22:09:01.020+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-27 22:09:01.020+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: preference_get_double(1214) > preference_get_double(1006) : inactive_10min_precaution_millisec error
05-27 22:09:01.025+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-27 22:09:01.025+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-27 22:09:01.035+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1006): preference.c: preference_get_double(1214) > preference_get_double(1006) : inactive_before_10min_precaution_millisec error
05-27 22:09:03.045+0900 E/SHealth_Common( 1006): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-27 22:09:05.335+0900 E/TIZEN_N_SYSTEM_SETTINGS(  786): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-27 22:09:05.335+0900 E/TIZEN_N_SYSTEM_SETTINGS(  786): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-27 22:09:05.345+0900 E/TIZEN_N_SYSTEM_SETTINGS(  786): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-27 22:09:05.345+0900 E/TIZEN_N_SYSTEM_SETTINGS(  786): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-27 22:09:09.530+0900 E/PKGMGR_SERVER( 1877): pkgmgr-server.c: main(2131) > package manager server start
05-27 22:09:09.620+0900 E/PKGMGR_SERVER( 1877): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_-1665342382], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[YFm2uGVKBG02cjxcn6SLhF/dhGM=], backend_flag=[0]
05-27 22:09:09.635+0900 E/PKGMGR_SERVER( 1879): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-27 22:09:09.640+0900 E/PKGMGR  ( 1871): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-27 22:09:09.700+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:09:09.710+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1635
05-27 22:09:09.710+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 22:09:09.715+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 5
05-27 22:09:09.720+0900 I/APP_CORE( 1635): appcore-efl.c: __do_app(429) > [APP 1635] Event: TERMINATE State: RUNNING
05-27 22:09:09.720+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 22:09:09.720+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(890) > app status : 4
05-27 22:09:09.720+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(1635), cmd(4)
05-27 22:09:09.720+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:09:09.735+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1635
05-27 22:09:09.820+0900 I/APP_CORE( 1635): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 22:09:09.820+0900 I/CAPI_APPFW_APPLICATION( 1635): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 22:09:09.830+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 22:09:09.835+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 22:09:09.835+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:09:09.845+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1635
05-27 22:09:09.850+0900 I/MALI    ( 1635): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f5f020] swap changed from sync to async
05-27 22:09:09.870+0900 I/MALI    ( 1635): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-27 22:09:09.875+0900 I/MALI    ( 1635): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=1635   close drm_fd=25 
05-27 22:09:09.875+0900 I/MALI    ( 1635): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-27 22:09:09.910+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-27 22:09:09.910+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 22:09:09.910+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:09:09.910+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:09:09.910+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:09:09.910+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 22:09:09.910+0900 W/WATCH_CORE(  758): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-27 22:09:09.910+0900 I/WATCH_CORE(  758): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 22:09:09.910+0900 I/CAPI_WATCH_APPLICATION(  758): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 22:09:09.910+0900 E/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 22:09:09.915+0900 I/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 22:09:09.935+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 22:09:09.935+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 22:09:09.935+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:09:09.935+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 22:09:09.935+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESUME State: PAUSED
05-27 22:09:09.935+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 22:09:09.935+0900 W/W_HOME  (  726): main.c: _appcore_resume_cb(681) > appcore resume
05-27 22:09:09.935+0900 W/W_HOME  (  726): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-27 22:09:09.935+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:09:09.935+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:09:09.935+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:09:09.935+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 22:09:09.935+0900 W/W_HOME  (  726): rotary.c: rotary_attach(138) > rotary_attach:0x46f631e0
05-27 22:09:09.935+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46f631e0, elm_layout, _activated_obj : 0x45c962e8, activated : 1
05-27 22:09:09.935+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 22:09:09.940+0900 I/UXT     ( 1635): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 22:09:09.950+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:09:09.955+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1635
05-27 22:09:09.960+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 22:09:09.965+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 22:09:09.965+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 22:09:09.965+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 22:09:09.965+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 22:09:09.965+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 22:09:09.965+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 22:09:10.060+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:09:10.070+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1635
05-27 22:09:10.170+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:09:10.195+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1635
05-27 22:09:10.300+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:09:10.310+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1635
05-27 22:09:10.395+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 22:09:10.410+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:09:10.420+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-27 22:09:10.425+0900 E/PKGMGR_SERVER( 1879): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-27 22:09:10.445+0900 E/PKGMGR_SERVER( 1877): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1879]
05-27 22:09:10.540+0900 W/CRASH_MANAGER( 1881): worker.c: worker_job(1199) > 1101635706831146435455
