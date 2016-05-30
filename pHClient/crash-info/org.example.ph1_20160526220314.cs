S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 7730
Date: 2016-05-26 22:03:14+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7730, uid 5000)

Register Information
r0   = 0x400061d8, r1   = 0x400061e1
r2   = 0x00000038, r3   = 0xbeb43073
r4   = 0x00000009, r5   = 0xbeb43128
r6   = 0xbeb43073, r7   = 0x00000009
r8   = 0x00000009, r9   = 0x42e9bbdc
r10  = 0x400062c2, fp   = 0xbeb4311c
ip   = 0xbeb4307c, sp   = 0xbeb42ba0
lr   = 0x403b9be8, pc   = 0x403e0bb8
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     19408 KB
Buffers:     27236 KB
Cached:     167336 KB
VmPeak:     111768 KB
VmSize:     104836 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22340 KB
VmRSS:       22336 KB
VmData:      43712 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       55348 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7730 TID = 7730
7730 7731 7732 7735 

Maps Information
40000000 40007000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
4000e000 4000f000 rwxp /opt/usr/apps/org.example.ph1/bin/ph1
4000f000 4002c000 r-xp /lib/ld-2.13.so
40033000 40034000 r-xp /lib/ld-2.13.so
40034000 40035000 rwxp /lib/ld-2.13.so
40035000 40039000 r-xp /usr/lib/libsys-assert.so
40041000 40042000 rwxp /usr/lib/libsys-assert.so
40042000 4004d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40055000 40056000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
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
43583000 435fa000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
43602000 43604000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
4360a000 43752000 r-xp /usr/lib/egl/libMali.so
43752000 43757000 rwxp /usr/lib/egl/libMali.so
43758000 4375b000 rwxp [stack:7732]
4375b000 4375f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43766000 43767000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43767000 4376b000 rwxs /dev/mali
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
43778000 43f77000 rwxp [stack:7731]
43f77000 43f7f000 rwxs /dev/mali
43f7f000 43f87000 rwxs /dev/mali
43f87000 43f9b000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
4409b000 4409f000 rwxs /dev/mali
4409f000 440a3000 rwxs /dev/mali
440a3000 440ab000 rwxs /dev/mali
440ab000 440b3000 rwxs /dev/mali
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
440b5000 44254000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
44254000 4426b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44273000 44278000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44378000 4437a000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44381000 44382000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45382000 45385000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
45385000 45389000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
45389000 45398000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
45398000 453d8000 rwxs /dev/mali
453d8000 453df000 r-xs /usr/lib/gconv/gconv-modules.cache
453df000 453e0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
453e7000 453e8000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
453e8000 453ec000 rwxs /dev/mali
453ec000 453f0000 rwxs /dev/mali
453f0000 453f4000 rwxs /dev/mali
453f4000 453f8000 rwxs /dev/mali
453f8000 45400000 rwxs /dev/mali
45500000 45540000 rwxs /dev/mali
45540000 4556c000 rwxs /dev/mali
4556c000 45570000 rwxs /dev/mali
45570000 45580000 rwxs /dev/mali
45580000 455a4000 rwxs /dev/mali
455a4000 455c8000 rwxs /dev/mali
455c8000 455ec000 rwxs /dev/mali
455ec000 455f4000 rwxs /dev/mali
455f4000 45604000 rwxs /dev/mali
45604000 45608000 rwxs /dev/mali
45608000 45693000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
45794000 45f93000 rwxp [stack:7735]
45f93000 45fd3000 rwxs /dev/mali
45fd3000 460e7000 rwxs /dev/mali
460e7000 46173000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
46173000 461fb000 rwxs /dev/mali
461fb000 461fc000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
46203000 46204000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
46204000 46214000 rwxs /dev/mali
46214000 46218000 rwxs /dev/mali
46219000 46220000 r-xp /usr/lib/libfeedback.so.0.1.4
46228000 46229000 rwxp /usr/lib/libfeedback.so.0.1.4
46229000 4622a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
46231000 46232000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
46232000 46234000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
4623b000 4623c000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
4623c000 46246000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
4624d000 4624e000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
4624e000 46255000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4625c000 4625d000 rwxp /usr/lib/libmmfcommon.so.0.0.0
4625d000 46262000 r-xp /usr/lib/libmmfsession.so.0.0.0
46269000 4626a000 rwxp /usr/lib/libmmfsession.so.0.0.0
4626a000 46274000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4627c000 4627d000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
46283000 46293000 rwxs /dev/mali
46293000 462b7000 rwxs /dev/mali
462b7000 462bb000 rwxs /dev/mali
462bb000 462d1000 r-xp /usr/lib/libmmfsound.so.0.1.0
462d9000 462da000 rwxp /usr/lib/libmmfsound.so.0.1.0
462e3000 462e7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
462ef000 462f0000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
462f0000 46306000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4630e000 4630f000 rwxp /usr/lib/libavsysaudio.so.0.0.1
4630f000 46314000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
4631b000 4631c000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
4631c000 4631f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46326000 46327000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46327000 4632a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
46331000 46332000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
46332000 4633f000 r-xp /usr/lib/libail.so.0.1.0
46347000 46348000 rwxp /usr/lib/libail.so.0.1.0
46348000 4634b000 r-xp /usr/lib/libcompress.so.0.2.0
46352000 46353000 rwxp /usr/lib/libcompress.so.0.2.0
46353000 46393000 rwxs /dev/mali
46393000 463d3000 rwxs /dev/mali
463d3000 4640b000 r-xp /usr/lib/libpulse.so.0.16.2
4640b000 4640c000 rwxp /usr/lib/libpulse.so.0.16.2
4640c000 46411000 r-xp /usr/lib/libjson.so.0.0.1
46418000 46419000 rwxp /usr/lib/libjson.so.0.0.1
4641b000 4642b000 rwxs /dev/mali
4642b000 46433000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
4643a000 4643b000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
46442000 46446000 r-xp /usr/lib/libogg.so.0.7.1
4644d000 4644e000 rwxp /usr/lib/libogg.so.0.7.1
4644f000 4645f000 rwxs /dev/mali
4645f000 4646f000 rwxs /dev/mali
4646f000 4647f000 rwxs /dev/mali
4647f000 464e0000 r-xp /usr/lib/libasound.so.2.0.0
464e7000 464ea000 rwxp /usr/lib/libasound.so.2.0.0
464ea000 464fa000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
464fa000 464fe000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
4651b000 46563000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46563000 46564000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46564000 465a7000 r-xp /usr/lib/libsndfile.so.1.0.25
465ae000 465b0000 rwxp /usr/lib/libsndfile.so.1.0.25
465b4000 465d6000 r-xp /usr/lib/libvorbis.so.0.4.3
465dd000 465de000 rwxp /usr/lib/libvorbis.so.0.4.3
465de000 465ee000 rwxs /dev/mali
465ee000 465fe000 rwxs /dev/mali
465fe000 4660e000 rwxs /dev/mali
4660e000 4661e000 rwxs /dev/mali
4661e000 466a6000 rwxs /dev/mali
466a6000 466b6000 rwxs /dev/mali
466b6000 466c6000 rwxs /dev/mali
466c6000 466ea000 rwxs /dev/mali
466ea000 46772000 rwxs /dev/mali
46872000 46896000 rwxs /dev/mali
468ba000 468ca000 rwxs /dev/mali
468ee000 46928000 r-xs /opt/usr/apps/org.example.ph1/res/edje/timer.edj
46928000 469b0000 rwxs /dev/mali
beb23000 beb44000 rwxp [stack]
End of Maps Information

Callstack Information (PID:7730)
Call Stack Count: 4
 0: _IO_default_xsputn + 0x50 (0x403e0bb8) [/lib/libc.so.6] + 0x67bb8
 1: _IO_vfprintf + 0x3d24 (0x403b9be8) [/lib/libc.so.6] + 0x40be8
 2: vsprintf + 0x64 (0x403d5944) [/lib/libc.so.6] + 0x5c944
 3: $d + 0x0 (0x400061d8) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x61d8
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
[send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:02:59.471+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:02:59.576+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:02:59.576+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:02:59.646+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:02:59.646+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:02:59.681+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:02:59.681+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:02:59.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:02:59.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:02:59.686+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:02:59.686+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:02:59.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:02:59.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:02:59.686+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:02:59.686+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:02:59.691+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:02:59.691+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:02:59.691+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:02:59.691+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:02:59.691+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:02:59.691+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:02:59.691+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:02:59.691+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:02:59.691+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:02:59.691+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:02:59.691+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:02:59.701+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [true][0m
05-26 22:02:59.781+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:02:59.781+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:02:59.841+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:02:59.841+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:02:59.886+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:02:59.886+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:02:59.986+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:02:59.986+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:00.036+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:00.036+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:00.091+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:00.091+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:00.196+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:00.196+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:00.241+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:00.241+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:00.306+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:00.306+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:00.411+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:00.411+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:00.436+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:00.436+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:00.521+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:00.526+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:00.626+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:00.626+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:00.641+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:00.641+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:00.731+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:00.731+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:00.836+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:00.836+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:00.841+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:00.841+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:00.946+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:00.946+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:00.946+0900 E/RESOURCED(  497): proc-noti.c: write_response(197) > [write_response,197] Failed to write
05-26 22:03:01.041+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:01.046+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:01.051+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:01.051+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:01.151+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:01.151+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:01.196+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 22:03:01.236+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:01.236+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:01.251+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:01.251+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:01.356+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:01.356+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:01.436+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:01.436+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:01.456+0900 E/RESOURCED( 1155): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:01.461+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(285) > Failed to get the cmdline, error: -1
05-26 22:03:01.516+0900 E/AUL     ( 7721): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-26 22:03:01.541+0900 E/AUL     (  496): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-26 22:03:01.541+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2098) > Launch with legacy way : Timeout
05-26 22:03:01.556+0900 W/AUL_AMD (  496): amd_launch.c: start_process(580) > child process: 7730
05-26 22:03:01.561+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(312) > process launched, but cmdline not changed
05-26 22:03:01.561+0900 E/AUL_PAD ( 1155): launchpad.c: __real_send(253) > send failed due to EPIPE.
05-26 22:03:01.561+0900 E/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(317) > send SIGKILL: No such process
05-26 22:03:01.611+0900 E/AUL_AMD (  496): amd_launch.c: __check_cmdline(520) > error founded when being launched with 7730
05-26 22:03:01.661+0900 W/AUL_AMD (  496): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 7730
05-26 22:03:01.661+0900 E/AUL_AMD (  496): amd_launch.c: __real_send(824) > send failed due to EPIPE.
05-26 22:03:01.661+0900 E/AUL_AMD (  496): amd_launch.c: __real_send(826) > send fail to client
05-26 22:03:01.661+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:03:01.671+0900 E/RESOURCED(  497): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
05-26 22:03:01.681+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 737
05-26 22:03:01.686+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:01.686+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:01.686+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:03:01.686+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-26 22:03:01.701+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7606
05-26 22:03:01.706+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:03:01.711+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT][0m
05-26 22:03:01.721+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7730
05-26 22:03:01.726+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:03:01.736+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:01.741+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 22:03:01.741+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 22:03:01.741+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT][0m
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:03:01.746+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:01.746+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 22:03:01.746+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:03:01.751+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:01.841+0900 I/efl-extension( 7730): efl_extension.c: eext_mod_init(40) > Init
05-26 22:03:01.866+0900 I/CAPI_APPFW_APPLICATION( 7730): app_main.c: ui_app_main(704) > app_efl_main
05-26 22:03:01.871+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:01.871+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:01.911+0900 I/UXT     ( 7730): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 22:03:02.061+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:02.061+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:02.116+0900 I/CAPI_APPFW_APPLICATION( 7730): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-26 22:03:02.191+0900 E/TBM     ( 7730): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 22:03:02.251+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:02.251+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:02.376+0900 E/EFL     ( 7730): <7730> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
05-26 22:03:02.386+0900 E/EFL     ( 7730): <7730> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:03:02.391+0900 E/EFL     ( 7730): <7730> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:03:02.391+0900 E/EFL     ( 7730): <7730> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:03:02.391+0900 E/EFL     ( 7730): <7730> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:03:02.391+0900 E/EFL     ( 7730): <7730> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
05-26 22:03:02.441+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:02.441+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:02.451+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03e00003)
05-26 22:03:02.456+0900 I/APP_CORE( 7730): appcore-efl.c: __do_app(429) > [APP 7730] Event: RESET State: CREATED
05-26 22:03:02.456+0900 I/CAPI_APPFW_APPLICATION( 7730): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 22:03:02.506+0900 I/APP_CORE( 7730): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 22:03:02.506+0900 I/APP_CORE( 7730): appcore-efl.c: __do_app(474) > [APP 7730] Initial Launching, call the resume_cb
05-26 22:03:02.506+0900 I/CAPI_APPFW_APPLICATION( 7730): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 22:03:02.546+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 22:03:02.546+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:02.546+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:02.546+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:02.546+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 22:03:02.551+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-26 22:03:02.556+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 22:03:02.581+0900 E/RESOURCED( 1055): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
05-26 22:03:02.581+0900 E/AUL     ( 1055): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
05-26 22:03:02.581+0900 E/CAPI_APPFW_APP_MANAGER( 1055): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
05-26 22:03:02.591+0900 W/APP_CORE( 7730): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00003
05-26 22:03:02.631+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:03:02.636+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:03:02.641+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 22:03:02.641+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 22:03:02.641+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:02.641+0900 W/W_HOME  (  737): event_manager.c: _state_control(333) > appcore paused manually
05-26 22:03:02.641+0900 W/W_HOME  (  737): main.c: home_appcore_pause(717) > Home Appcore Paused
05-26 22:03:02.641+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 22:03:02.641+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:02.641+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:02.641+0900 W/W_HOME  (  737): main.c: home_pause(751) > clock/widget paused
05-26 22:03:02.646+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:03:02.646+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:02.646+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:02.646+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:02.646+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:03:02.646+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:03:02.646+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:02.646+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:03:02.646+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:02.651+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:03:02.651+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:03:02.651+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:03:02.651+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:03:02.651+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:03:02.651+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:03:02.651+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:03:02.651+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:03:02.651+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:03:02.651+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:03:02.651+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:03:02.651+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 22:03:02.661+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:03:02.661+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-26 22:03:02.666+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 22:03:02.671+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 22:03:02.671+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:03:02.671+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 22:03:02.671+0900 E/W_HOME  (  737): main.c: _pause_cb(668) > paused already
05-26 22:03:02.681+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:03:02.681+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 22:03:02.721+0900 I/APP_CORE( 7730): appcore-efl.c: __do_app(429) > [APP 7730] Event: RESUME State: RUNNING
05-26 22:03:02.751+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 22:03:02.751+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:03:02.756+0900 W/WATCH_CORE(  778): appcore-watch.c: __widget_pause(1001) > widget_pause
05-26 22:03:02.756+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppPause(713) > 
05-26 22:03:02.756+0900 E/watchface-viewer(  778): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 22:03:02.756+0900 E/watchface-viewer(  778): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 22:03:02.756+0900 E/watchface-viewer(  778): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 22:03:02.756+0900 E/watchface-viewer(  778): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 22:03:02.756+0900 E/watchface-viewer(  778): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 22:03:02.946+0900 I/AUL_PAD ( 7736): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 22:03:03.041+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:03:03.081+0900 I/MALI    ( 7730): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42f5f028] swap changed from async to sync
05-26 22:03:03.166+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:03:04.926+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 22:03:04.926+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 22:03:07.436+0900 E/EFL     ( 7730): evas_main<7730> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1824480 button=1 downs=1
05-26 22:03:07.461+0900 E/EFL     ( 7730): evas_main<7730> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1824507 button=1 downs=0
05-26 22:03:07.756+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:03:08.076+0900 E/EFL     ( 7730): evas_main<7730> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1825123 button=1 downs=1
05-26 22:03:08.146+0900 E/EFL     ( 7730): evas_main<7730> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1825196 button=1 downs=0
05-26 22:03:08.471+0900 I/CAPI_NETWORK_CONNECTION( 7730): connection.c: connection_create(372) > New handle created[0x442cfcc8]
05-26 22:03:08.496+0900 I/SOCKETTEST( 7730): IP : 
05-26 22:03:08.496+0900 I/SOCKETTEST( 7730): Success to create UDP socket
05-26 22:03:08.496+0900 I/SOCKETTEST( 7730): Bind Success
05-26 22:03:08.496+0900 I/SOCKETTEST( 7730): Waiting DATA...
05-26 22:03:10.091+0900 I/SOCKETTEST( 7730): Receive Data : 192.168.0.47
05-26 22:03:10.096+0900 I/SOCKETTEST( 7730): Changed IP : 192.168.0.47
05-26 22:03:10.156+0900 I/SOCKETTEST( 7730): Success to create socket
05-26 22:03:10.166+0900 I/SOCKETTEST( 7730): Success to socket connection
05-26 22:03:10.166+0900 I/SOCKETTEST( 7730): write() 성공
05-26 22:03:11.781+0900 E/EFL     ( 7730): evas_main<7730> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1828828 button=1 downs=1
05-26 22:03:11.831+0900 E/EFL     ( 7730): evas_main<7730> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1828881 button=1 downs=0
05-26 22:03:11.881+0900 D/TIMER   ( 7730): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:03:11.881+0900 D/TIMER   ( 7730): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:03:11.931+0900 I/efl-extension( 7730): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:03:11.931+0900 I/efl-extension( 7730): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:03:11.931+0900 I/efl-extension( 7730): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:03:11.931+0900 I/efl-extension( 7730): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:03:11.931+0900 I/efl-extension( 7730): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x443042a0, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:03:12.741+0900 E/EFL     ( 7730): evas_main<7730> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1829792 button=1 downs=1
05-26 22:03:12.756+0900 E/EFL     ( 7730): evas_main<7730> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1829803 button=1 downs=0
05-26 22:03:13.221+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.226+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.226+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830272
05-26 22:03:13.226+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.226+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.251+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.251+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.251+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.251+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830301
05-26 22:03:13.251+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.316+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.316+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.316+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.316+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830364
05-26 22:03:13.316+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.356+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.356+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.356+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830406
05-26 22:03:13.356+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.356+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.396+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.396+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.396+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830447
05-26 22:03:13.396+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.396+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.456+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.456+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.456+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830504
05-26 22:03:13.456+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.456+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.506+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.506+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.506+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830557
05-26 22:03:13.506+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.506+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.551+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.551+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.551+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830600
05-26 22:03:13.551+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.551+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.576+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.576+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.576+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830626
05-26 22:03:13.576+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.576+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.601+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.601+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.601+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830649
05-26 22:03:13.601+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.601+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.621+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.621+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.621+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830673
05-26 22:03:13.626+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.626+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.661+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.661+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.661+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830711
05-26 22:03:13.661+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.661+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.726+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.726+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.726+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830774
05-26 22:03:13.726+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.726+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.801+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.801+0900 I/efl-extension( 7730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:13.801+0900 I/efl-extension( 7730): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x443042a0, elm_layout, time_stamp : 1830852
05-26 22:03:13.801+0900 E/TIMER   ( 7730): (ad->timer) -> _rotary_cb() return
05-26 22:03:13.801+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:03:14.091+0900 E/EFL     ( 7730): evas_main<7730> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1831141 button=1 downs=1
05-26 22:03:14.156+0900 E/EFL     ( 7730): evas_main<7730> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1831203 button=1 downs=0
05-26 22:03:14.156+0900 I/efl-extension( 7730): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:03:14.156+0900 I/efl-extension( 7730): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x443042a0, elm_layout, func : 0x400038e1
05-26 22:03:14.156+0900 I/efl-extension( 7730): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:03:14.156+0900 I/efl-extension( 7730): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:03:14.156+0900 I/efl-extension( 7730): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:03:14.156+0900 I/efl-extension( 7730): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:03:14.156+0900 I/efl-extension( 7730): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:03:14.156+0900 I/efl-extension( 7730): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:03:14.156+0900 E/EFL     ( 7730): ecore<7730> ecore.c:574 _ecore_magic_fail() 
05-26 22:03:14.156+0900 E/EFL     ( 7730): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:03:14.156+0900 E/EFL     ( 7730): *** IN FUNCTION: ecore_timer_del()
05-26 22:03:14.156+0900 E/EFL     ( 7730): ecore<7730> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:03:14.156+0900 E/EFL     ( 7730):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:03:14.156+0900 E/EFL     ( 7730):     Supplied: e5933114 - <UNKNOWN>
05-26 22:03:14.156+0900 E/EFL     ( 7730): ecore<7730> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:03:14.156+0900 E/EFL     ( 7730): *** SPANK SPANK SPANK!!!
05-26 22:03:14.156+0900 E/EFL     ( 7730): *** Now go fix your code. Tut tut tut!
05-26 22:03:14.156+0900 E/EFL     ( 7730): ecore<7730> ecore.c:574 _ecore_magic_fail() 
05-26 22:03:14.156+0900 E/EFL     ( 7730): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:03:14.156+0900 E/EFL     ( 7730): *** IN FUNCTION: ecore_timer_del()
05-26 22:03:14.156+0900 E/EFL     ( 7730): ecore<7730> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:03:14.156+0900 E/EFL     ( 7730):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:03:14.156+0900 E/EFL     ( 7730):     Supplied: 403e8280 - <UNKNOWN>
05-26 22:03:14.156+0900 E/EFL     ( 7730): ecore<7730> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:03:14.156+0900 E/EFL     ( 7730): *** SPANK SPANK SPANK!!!
05-26 22:03:14.156+0900 E/EFL     ( 7730): *** Now go fix your code. Tut tut tut!
05-26 22:03:14.156+0900 I/SOCKETTEST( 7730): Success to create socket
05-26 22:03:14.206+0900 I/SOCKETTEST( 7730): Success to socket connection
05-26 22:03:14.206+0900 I/SOCKETTEST( 7730): write() 성공
05-26 22:03:14.511+0900 W/CRASH_MANAGER( 7778): worker.c: worker_job(1199) > 1107730706831146426779
