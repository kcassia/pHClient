S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 13864
Date: 2016-05-27 20:34:17+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4049f250, r3   = 0x00000000
r4   = 0x44c397c8, r5   = 0x00000000
r6   = 0x44c3a0c8, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x44c030c0
r10  = 0x4430f540, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbebe9638
lr   = 0x403e81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     20432 KB
Buffers:     44240 KB
Cached:     140728 KB
VmPeak:     110116 KB
VmSize:      99252 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21692 KB
VmRSS:       21692 KB
VmData:      43616 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 13864 TID = 13864
13864 13871 13875 13965 

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
43758000 4376c000 rwxp [stack:13871]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44b82000 44b85000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b85000 44b89000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b89000 44b98000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44bf8000 44bff000 r-xs /usr/lib/gconv/gconv-modules.cache
44d01000 45500000 rwxp [stack:13965]
45694000 45f93000 rwxp [stack:13875]
46680000 46683000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4668a000 4668b000 rwxp /usr/lib/libpulse-simple.so.0.0.4
466f6000 4672e000 r-xp /usr/lib/libpulse.so.0.16.2
4672e000 4672f000 rwxp /usr/lib/libpulse.so.0.16.2
467a3000 467a8000 r-xp /usr/lib/libjson.so.0.0.1
467af000 467b0000 rwxp /usr/lib/libjson.so.0.0.1
467b0000 467f8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
467f8000 467f9000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
467f9000 4683c000 r-xp /usr/lib/libsndfile.so.1.0.25
46843000 46845000 rwxp /usr/lib/libsndfile.so.1.0.25
46849000 4686b000 r-xp /usr/lib/libvorbis.so.0.4.3
46872000 46873000 rwxp /usr/lib/libvorbis.so.0.4.3
46873000 46877000 r-xp /usr/lib/libogg.so.0.7.1
4687e000 4687f000 rwxp /usr/lib/libogg.so.0.7.1
bebc9000 bebea000 rwxp [stack]
End of Maps Information

Callstack Information (PID:13864)
Call Stack Count: 2
 0: cfree + 0xc8 (0x403e81e8) [/lib/libc.so.6] + 0x6f1e8
 1: ((nil)) (null)
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
:33:13.934+0900 E/EFL     (  780): evas_main<780> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5019849 button=1 downs=1
05-27 20:33:13.934+0900 E/EFL     (  780): evas_main<780> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-27 20:33:13.934+0900 E/EFL     (  780): evas_main<780> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-27 20:33:13.934+0900 E/EFL     (  780): evas_main<780> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-27 20:33:13.949+0900 E/EFL     (  780): evas_main<780> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5019912 button=1 downs=0
05-27 20:33:13.959+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 0
05-27 20:33:13.959+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 780
05-27 20:33:13.959+0900 I/AUL_AMD (  492): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-27 20:33:13.964+0900 W/AUL_AMD (  492): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 732
05-27 20:33:13.969+0900 W/AUL_AMD (  492): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(732), cmd(0)
05-27 20:33:13.969+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESET State: RUNNING
05-27 20:33:13.969+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-27 20:33:13.969+0900 W/W_HOME  (  732): main.c: _app_control(1726) > Service value : launch_apps
05-27 20:33:13.969+0900 W/W_HOME  (  732): move.c: move_move_to_apps(216) > move to apps
05-27 20:33:13.969+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x479122d0
05-27 20:33:13.969+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x479122d0, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 20:33:13.969+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:33:13.969+0900 W/W_HOME  (  732): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-27 20:33:13.969+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:33:13.969+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:33:13.979+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-27 20:33:13.979+0900 W/W_HOME  (  732): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-27 20:33:13.979+0900 W/W_HOME  (  732): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-27 20:33:13.979+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:33:13.984+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:33:13.984+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:33:13.984+0900 W/W_HOME  (  732): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
05-27 20:33:13.984+0900 W/W_HOME  (  732): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-27 20:33:13.984+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-27 20:33:13.984+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-27 20:33:14.264+0900 W/W_HOME  (  732): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-27 20:33:14.264+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:33:14.264+0900 W/W_HOME  (  732): rotary.c: rotary_deattach(156) > rotary_deattach:0x479122d0
05-27 20:33:14.264+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:33:14.264+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x479122d0, elm_layout, func : 0x4004b469
05-27 20:33:14.264+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 20:33:14.264+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 20:33:14.264+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:33:14.264+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96570, elm_box, _activated_obj : 0x479122d0, activated : 1
05-27 20:33:14.264+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:33:14.264+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:33:14.264+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-27 20:33:14.264+0900 W/W_HOME  (  732): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-27 20:33:14.269+0900 W/W_HOME  (  732): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-27 20:33:14.269+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:33:14.269+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:33:14.269+0900 W/W_HOME  (  732): main.c: home_pause(751) > clock/widget paused
05-27 20:33:14.269+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:33:14.269+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 20:33:14.269+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x45d4d480
05-27 20:33:14.269+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d4d480, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 20:33:14.269+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:33:14.269+0900 W/W_HOME  (  732): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-27 20:33:14.269+0900 W/W_HOME  (  732): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-27 20:33:14.269+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-27 20:33:14.269+0900 I/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-27 20:33:14.269+0900 E/APPS    (  732): apps_main.c: apps_main_resume(621) >  resumed already
05-27 20:33:14.274+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:33:14.274+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:33:14.274+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:33:14.274+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:33:14.414+0900 W/W_HOME  (  732): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
05-27 20:33:14.734+0900 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-27 20:33:14.734+0900 E/EFL     (  732): evas_main<732> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5020734 button=1 downs=1
05-27 20:33:14.734+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [180, 174]
05-27 20:33:14.789+0900 E/EFL     (  732): evas_main<732> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5020777 button=1 downs=0
05-27 20:33:14.789+0900 W/APPS    (  732): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [180, 174]->[189, 188]
05-27 20:33:14.804+0900 W/APPS    (  732): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-27 20:33:14.804+0900 E/APPS    (  732): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-27 20:33:14.804+0900 W/APPS    (  732): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-27 20:33:14.814+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 0
05-27 20:33:14.819+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 732
05-27 20:33:14.819+0900 I/AUL_AMD (  492): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-27 20:33:14.824+0900 W/AUL_AMD (  492): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 13864
05-27 20:33:14.829+0900 W/AUL_AMD (  492): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(13864), cmd(0)
05-27 20:33:14.834+0900 I/APP_CORE(13864): appcore-efl.c: __do_app(429) > [APP 13864] Event: RESET State: PAUSED
05-27 20:33:14.834+0900 I/CAPI_APPFW_APPLICATION(13864): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-27 20:33:14.834+0900 I/APP_CORE(13864): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-27 20:33:14.834+0900 I/APP_CORE(13864): appcore-efl.c: __do_app(481) > [APP 13864] App already running, raise the window
05-27 20:33:14.844+0900 E/AUL     (  492): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 20:33:14.849+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x03e00003)
05-27 20:33:14.859+0900 I/APP_CORE(13864): appcore-efl.c: __do_app(485) > [APP 13864] Call the resume_cb
05-27 20:33:14.859+0900 I/CAPI_APPFW_APPLICATION(13864): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-27 20:33:14.944+0900 I/APP_CORE(13864): appcore-efl.c: __do_app(429) > [APP 13864] Event: RESUME State: RUNNING
05-27 20:33:14.964+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-27 20:33:14.969+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 20:33:14.969+0900 W/AUL_AMD (  492): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-27 20:33:14.979+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-27 20:33:14.979+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:33:14.979+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:33:14.984+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:33:14.984+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-27 20:33:14.984+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-27 20:33:14.984+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-27 20:33:14.984+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:33:14.984+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-27 20:33:14.984+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:33:14.984+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:33:14.984+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: PAUSE State: RUNNING
05-27 20:33:14.984+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 20:33:14.984+0900 W/W_HOME  (  732): main.c: _appcore_pause_cb(690) > appcore pause
05-27 20:33:14.984+0900 W/W_HOME  (  732): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-27 20:33:14.984+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:33:14.984+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:33:14.984+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-27 20:33:14.984+0900 W/W_HOME  (  732): rotary.c: rotary_deattach(156) > rotary_deattach:0x45d4d480
05-27 20:33:14.984+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:33:14.984+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45d4d480, elm_layout, func : 0x4004b469
05-27 20:33:14.984+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 20:33:14.984+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 20:33:14.984+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:33:14.984+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96570, elm_box, _activated_obj : 0x45d4d480, activated : 1
05-27 20:33:14.984+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:33:14.984+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:33:14.984+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-27 20:33:14.999+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-27 20:33:15.009+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-27 20:33:15.009+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-27 20:33:15.009+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-27 20:33:15.009+0900 E/CAPI_APPFW_APP_CONTROL( 1241): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-27 20:33:15.009+0900 W/MUSIC_CONTROL_SERVICE( 1241): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1241]   [com.samsung.w-home]register msg port [false][0m
05-27 20:33:15.009+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:33:15.009+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:33:15.064+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-27 20:33:15.064+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:33:15.079+0900 W/APPS    (  732): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-27 20:33:15.289+0900 E/AUL     (  492): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-27 20:33:15.509+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-27 20:33:17.709+0900 E/EFL     (13864): evas_main<13864> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5023710 button=1 downs=1
05-27 20:33:17.744+0900 E/EFL     (13864): evas_main<13864> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5023743 button=1 downs=0
05-27 20:33:18.649+0900 E/EFL     (13864): evas_main<13864> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5024640 button=1 downs=1
05-27 20:33:18.774+0900 E/EFL     (13864): evas_main<13864> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5024768 button=1 downs=0
05-27 20:33:18.994+0900 I/CAPI_NETWORK_CONNECTION(13864): connection.c: connection_create(372) > New handle created[0x4407d458]
05-27 20:33:19.014+0900 I/SOCKETTEST(13864): IP : 
05-27 20:33:19.014+0900 I/SOCKETTEST(13864): Success to create UDP socket
05-27 20:33:19.014+0900 I/SOCKETTEST(13864): Bind Success
05-27 20:33:19.014+0900 I/SOCKETTEST(13864): Waiting DATA...
05-27 20:33:20.014+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: MEM_FLUSH State: PAUSED
05-27 20:33:21.019+0900 I/SOCKETTEST(13864): Receive Data : 192.168.43.140
05-27 20:33:21.019+0900 I/SOCKETTEST(13864): Changed IP : 192.168.43.140
05-27 20:33:21.084+0900 I/SOCKETTEST(13864): Success to create socket
05-27 20:33:21.089+0900 I/SOCKETTEST(13864): Success to socket connection
05-27 20:33:21.089+0900 I/SOCKETTEST(13864): write() 성공
05-27 20:33:22.849+0900 E/EFL     (13864): evas_main<13864> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5028849 button=1 downs=1
05-27 20:33:22.919+0900 E/EFL     (13864): evas_main<13864> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5028922 button=1 downs=0
05-27 20:33:22.974+0900 D/TIMER   (13864): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-27 20:33:22.974+0900 D/TIMER   (13864): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-27 20:33:23.029+0900 I/efl-extension(13864): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-27 20:33:23.029+0900 I/efl-extension(13864): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-27 20:33:23.029+0900 I/efl-extension(13864): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-27 20:33:23.029+0900 I/efl-extension(13864): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-27 20:33:23.034+0900 I/efl-extension(13864): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4430fb40, elm_layout, _activated_obj : 0x0, activated : 1
05-27 20:33:23.799+0900 E/EFL     (13864): evas_main<13864> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5029797 button=1 downs=1
05-27 20:33:23.874+0900 E/EFL     (13864): evas_main<13864> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5029877 button=1 downs=0
05-27 20:33:24.364+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.364+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.369+0900 I/efl-extension(13864): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.369+0900 I/efl-extension(13864): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4430fb40, elm_layout, time_stamp : 5030365
05-27 20:33:24.474+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.474+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.479+0900 I/efl-extension(13864): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.479+0900 I/efl-extension(13864): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4430fb40, elm_layout, time_stamp : 5030476
05-27 20:33:24.514+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.519+0900 I/efl-extension(13864): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.519+0900 I/efl-extension(13864): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4430fb40, elm_layout, time_stamp : 5030517
05-27 20:33:24.524+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.544+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.549+0900 I/efl-extension(13864): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.549+0900 I/efl-extension(13864): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4430fb40, elm_layout, time_stamp : 5030543
05-27 20:33:24.549+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.574+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.579+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.579+0900 I/efl-extension(13864): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.579+0900 I/efl-extension(13864): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4430fb40, elm_layout, time_stamp : 5030578
05-27 20:33:24.619+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.619+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.619+0900 I/efl-extension(13864): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.619+0900 I/efl-extension(13864): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4430fb40, elm_layout, time_stamp : 5030620
05-27 20:33:24.679+0900 I/efl-extension(13864): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.679+0900 I/efl-extension(13864): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4430fb40, elm_layout, time_stamp : 5030679
05-27 20:33:24.679+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.679+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.729+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.729+0900 I/efl-extension(13864): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.729+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.729+0900 I/efl-extension(13864): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4430fb40, elm_layout, time_stamp : 5030730
05-27 20:33:24.794+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.794+0900 I/efl-extension(11594): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.794+0900 I/efl-extension(13864): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:33:24.794+0900 I/efl-extension(13864): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4430fb40, elm_layout, time_stamp : 5030794
05-27 20:33:25.254+0900 E/EFL     (13864): evas_main<13864> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5031255 button=1 downs=1
05-27 20:33:25.309+0900 E/EFL     (13864): evas_main<13864> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5031309 button=1 downs=0
05-27 20:33:25.309+0900 D/TIMER   (13864): Setting time is 540
05-27 20:33:25.404+0900 I/SOCKETTEST(13864): Success to create socket
05-27 20:33:25.414+0900 I/SOCKETTEST(13864): Success to socket connection
05-27 20:33:25.414+0900 I/SOCKETTEST(13864): write() 성공
05-27 20:33:25.464+0900 I/SENSOR  (13864): 3.430000, 0.700000, 3.920000
05-27 20:33:25.559+0900 I/SENSOR  (13864): 3.710000, -1.890000, 3.080000
05-27 20:33:25.659+0900 I/SENSOR  (13864): 3.360000, -13.230000, 4.620000
05-27 20:33:25.764+0900 I/SENSOR  (13864): 0.350000, 1.190000, 3.010000
05-27 20:33:25.869+0900 I/SENSOR  (13864): 3.220000, 0.630000, 4.130000
05-27 20:33:25.964+0900 I/SENSOR  (13864): 4.200000, 0.140000, 4.060000
05-27 20:33:26.064+0900 I/SENSOR  (13864): 9.380000, 9.800000, 0.980000
05-27 20:33:26.164+0900 I/SENSOR  (13864): 3.220000, 1.050000, 4.830000
05-27 20:33:26.264+0900 I/SENSOR  (13864): -4.410000, -3.290000, 27.790001
05-27 20:33:26.364+0900 I/SENSOR  (13864): 1.120000, -1.330000, 10.500000
05-27 20:33:26.469+0900 I/SENSOR  (13864): 6.580000, 1.260000, -7.840000
05-27 20:33:26.564+0900 I/SENSOR  (13864): 4.410000, -0.210000, 1.050000
05-27 20:33:26.669+0900 I/SENSOR  (13864): 2.240000, -0.560000, 6.370000
05-27 20:33:26.769+0900 I/SENSOR  (13864): 10.500000, 4.270000, -23.240000
05-27 20:33:26.864+0900 I/SENSOR  (13864): 3.080000, -0.070000, 3.360000
05-27 20:33:26.964+0900 I/SENSOR  (13864): 3.220000, -0.280000, 2.800000
05-27 20:33:27.064+0900 I/SENSOR  (13864): 3.360000, -0.280000, 3.570000
05-27 20:33:27.164+0900 I/SENSOR  (13864): 3.220000, -0.140000, 3.570000
05-27 20:33:27.264+0900 I/SENSOR  (13864): 3.220000, -0.420000, 3.640000
05-27 20:33:27.364+0900 I/SENSOR  (13864): 3.290000, -0.140000, 3.640000
05-27 20:33:27.469+0900 I/SENSOR  (13864): 3.220000, -0.140000, 3.570000
05-27 20:33:27.564+0900 I/SENSOR  (13864): 3.290000, -0.210000, 3.780000
05-27 20:33:27.669+0900 I/SENSOR  (13864): 2.310000, 10.920000, 5.250000
05-27 20:33:27.769+0900 I/SENSOR  (13864): 1.820000, 5.670000, 5.810000
05-27 20:33:27.864+0900 I/SENSOR  (13864): 2.240000, 5.320000, 4.760000
05-27 20:33:27.969+0900 I/SENSOR  (13864): 1.820000, 5.810000, 4.340000
05-27 20:33:28.064+0900 I/SENSOR  (13864): 2.310000, 4.550000, 4.060000
05-27 20:33:28.164+0900 I/SENSOR  (13864): 2.590000, 3.640000, 3.990000
05-27 20:33:28.264+0900 I/SENSOR  (13864): 3.220000, -0.210000, 3.920000
05-27 20:33:28.369+0900 I/SENSOR  (13864): 2.940000, 0.350000, 3.710000
05-27 20:33:28.469+0900 I/SENSOR  (13864): 3.010000, 1.470000, 4.130000
05-27 20:33:28.564+0900 I/SENSOR  (13864): 3.290000, -0.350000, 3.570000
05-27 20:33:28.669+0900 I/SENSOR  (13864): 3.220000, -0.350000, 3.780000
05-27 20:33:28.769+0900 I/SENSOR  (13864): 3.220000, -0.140000, 3.570000
05-27 20:33:28.839+0900 E/EFL     (13864): evas_main<13864> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5034838 button=1 downs=1
05-27 20:33:28.864+0900 I/SENSOR  (13864): 0.140000, 12.530000, 12.460000
05-27 20:33:28.939+0900 E/EFL     (13864): evas_main<13864> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5034940 button=1 downs=0
05-27 20:33:28.964+0900 I/SENSOR  (13864): 3.150000, -0.350000, 11.410000
05-27 20:33:29.069+0900 I/SENSOR  (13864): 1.820000, -0.350000, 1.190000
05-27 20:33:29.164+0900 I/SENSOR  (13864): 2.870000, -0.070000, 4.340000
05-27 20:33:29.269+0900 I/SENSOR  (13864): 3.640000, 0.700000, 3.710000
05-27 20:33:29.369+0900 I/SENSOR  (13864): 3.360000, -0.560000, 4.200000
05-27 20:33:29.464+0900 I/SENSOR  (13864): 4.130000, 0.420000, 3.430000
05-27 20:33:29.564+0900 I/SENSOR  (13864): 3.710000, -0.140000, 3.220000
05-27 20:33:29.669+0900 I/SENSOR  (13864): 1.960000, -0.140000, 3.430000
05-27 20:33:29.769+0900 I/SENSOR  (13864): 3.920000, 0.350000, 3.920000
05-27 20:33:29.869+0900 I/SENSOR  (13864): 3.920000, 0.630000, 3.640000
05-27 20:33:29.969+0900 I/SENSOR  (13864): 3.640000, 0.420000, 3.710000
05-27 20:33:30.069+0900 I/SENSOR  (13864): 4.340000, 1.330000, 4.760000
05-27 20:33:30.169+0900 I/SENSOR  (13864): 6.230000, -0.210000, 5.320000
05-27 20:33:30.274+0900 E/EFL     (13864): evas_main<13864> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5036275 button=1 downs=1
05-27 20:33:30.279+0900 I/SENSOR  (13864): 4.340000, 1.960000, 1.680000
05-27 20:33:30.364+0900 I/SENSOR  (13864): 2.170000, -1.050000, 7.980000
05-27 20:33:30.439+0900 E/EFL     (13864): evas_main<13864> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5036442 button=1 downs=0
05-27 20:33:30.464+0900 I/SENSOR  (13864): 3.010000, 2.170000, 8.610000
05-27 20:33:30.574+0900 I/SENSOR  (13864): 2.380000, 2.100000, 3.010000
05-27 20:33:30.674+0900 I/SENSOR  (13864): 4.200000, 0.350000, 3.780000
05-27 20:33:30.769+0900 I/SENSOR  (13864): 5.390000, -0.350000, 3.500000
05-27 20:33:30.869+0900 I/SENSOR  (13864): 3.850000, 0.280000, 3.710000
05-27 20:33:30.969+0900 I/SENSOR  (13864): 2.870000, -0.840000, 3.290000
05-27 20:33:31.044+0900 E/EFL     (13864): evas_main<13864> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=5037043 button=1 downs=1
05-27 20:33:31.064+0900 I/SENSOR  (13864): -3.010000, -5.390000, 27.719999
05-27 20:33:31.164+0900 I/SENSOR  (13864): 9.380000, 19.320000, -29.469999
05-27 20:33:31.174+0900 E/EFL     (13864): evas_main<13864> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=5037177 button=1 downs=0
05-27 20:33:31.174+0900 I/efl-extension(13864): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:33:31.174+0900 I/efl-extension(13864): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4430fb40, elm_layout, func : 0x400038d9
05-27 20:33:31.174+0900 I/efl-extension(13864): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-27 20:33:31.174+0900 I/efl-extension(13864): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-27 20:33:31.174+0900 I/efl-extension(13864): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:33:31.174+0900 I/efl-extension(13864): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 20:33:31.174+0900 I/efl-extension(13864): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 20:33:31.174+0900 I/efl-extension(13864): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 20:33:31.194+0900 I/SOCKETTEST(13864): Success to create socket
05-27 20:33:34.219+0900 I/SOCKETTEST(13864): Success to socket connection
05-27 20:33:34.224+0900 I/SOCKETTEST(13864): write() 성공
05-27 20:33:34.389+0900 I/TimeRecord(13864): String_ time : 5
05-27 20:33:34.394+0900 I/TimeRecord(13864): Preference_ time : ��.D
05-27 20:33:34.399+0900 I/TimeRecord(13864): time : 5
05-27 20:33:34.869+0900 I/efl-extension(13864): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4430fb40
05-27 20:33:34.869+0900 I/efl-extension(13864): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4430fb40, obj: 0x4430fb40
05-27 20:33:34.874+0900 I/efl-extension(13864): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 20:33:46.904+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 49 -> 50 1464348826 123
05-27 20:33:46.909+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 50 101 93 84
05-27 20:33:46.939+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 50 0 0 0
05-27 20:33:46.939+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 50 109 41 91
05-27 20:33:46.939+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 50 101 5 84
05-27 20:33:46.939+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 50 114 29 95
05-27 20:33:54.314+0900 I/RESOURCED(  493): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-27 20:33:54.314+0900 I/RESOURCED(  493): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-27 20:34:00.304+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 20:34:16.789+0900 E/PKGMGR_SERVER(14042): pkgmgr-server.c: main(2131) > package manager server start
05-27 20:34:16.869+0900 E/PKGMGR_SERVER(14042): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_1231905013], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[ZRxL1wSu796y7zOqhyT+1T6j/JQ=], backend_flag=[0]
05-27 20:34:16.879+0900 E/PKGMGR_SERVER(14043): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-27 20:34:16.879+0900 E/PKGMGR  (14040): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-27 20:34:16.944+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:34:16.954+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13864
05-27 20:34:16.954+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:34:16.959+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 5
05-27 20:34:16.959+0900 I/APP_CORE(13864): appcore-efl.c: __do_app(429) > [APP 13864] Event: TERMINATE State: RUNNING
05-27 20:34:16.964+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 20:34:16.964+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 20:34:16.964+0900 W/AUL_AMD (  492): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(13864), cmd(4)
05-27 20:34:16.964+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:34:16.974+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13864
05-27 20:34:17.029+0900 I/APP_CORE(13864): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 20:34:17.029+0900 I/CAPI_APPFW_APPLICATION(13864): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 20:34:17.039+0900 I/MALI    (13864): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f5f028] swap changed from sync to async
05-27 20:34:17.049+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 20:34:17.049+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 20:34:17.069+0900 I/MALI    (13864): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-27 20:34:17.069+0900 I/MALI    (13864): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=13864   close drm_fd=25 
05-27 20:34:17.069+0900 I/MALI    (13864): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-27 20:34:17.084+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:34:17.094+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13864
05-27 20:34:17.129+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-27 20:34:17.134+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-27 20:34:17.134+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 20:34:17.134+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:34:17.134+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:34:17.134+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:34:17.134+0900 I/UXT     (13864): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 20:34:17.134+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 20:34:17.134+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:34:17.134+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:34:17.134+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:34:17.134+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 20:34:17.174+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 20:34:17.174+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 20:34:17.174+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:34:17.174+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 20:34:17.174+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-27 20:34:17.174+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 20:34:17.174+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-27 20:34:17.174+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-27 20:34:17.179+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:34:17.179+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:34:17.189+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:34:17.189+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 20:34:17.189+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x45d4d480
05-27 20:34:17.189+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d4d480, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 20:34:17.189+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:34:17.199+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:34:17.209+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13864
05-27 20:34:17.219+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 20:34:17.219+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:34:17.224+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 20:34:17.224+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:34:17.229+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:34:17.229+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:34:17.229+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:34:17.309+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:34:17.324+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13864
05-27 20:34:17.429+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:34:17.459+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13864
05-27 20:34:17.559+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:34:17.574+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13864
05-27 20:34:17.644+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 20:34:17.679+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:34:17.689+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-27 20:34:17.704+0900 E/PKGMGR_SERVER(14043): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-27 20:34:17.724+0900 E/PKGMGR_SERVER(14042): pkgmgr-server.c: sighandler(409) > child NORMAL exit [14043]
05-27 20:34:17.819+0900 W/CRASH_MANAGER(14045): worker.c: worker_job(1199) > 1113864706831146434885
