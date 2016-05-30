S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 3938
Date: 2016-05-26 21:42:57+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3938, uid 5000)

Register Information
r0   = 0x303d5849, r1   = 0x00000025
r2   = 0xbea44204, r3   = 0x303d5849
r4   = 0xfbad8001, r5   = 0xbea44204
r6   = 0xbea43cd0, r7   = 0x4049e000
r8   = 0x00000000, r9   = 0x42e9bbdc
r10  = 0x303d5849, fp   = 0xbea43cc4
ip   = 0x400dea1c, sp   = 0xbea43750
lr   = 0x403b5f5c, pc   = 0x403f0638
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     10008 KB
Buffers:     20404 KB
Cached:     180092 KB
VmPeak:     111824 KB
VmSize:     104844 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22616 KB
VmRSS:       22616 KB
VmData:      43720 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       55348 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3938 TID = 3938
3938 3944 3945 3949 

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
43758000 4375b000 rwxp [stack:3945]
4375b000 4375f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43766000 43767000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43767000 4376b000 rwxs /dev/mali
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
43778000 43f77000 rwxp [stack:3944]
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
44b82000 44b85000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b85000 44b89000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b89000 44b98000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44b98000 44bd8000 rwxs /dev/mali
44bd8000 44bdf000 r-xs /usr/lib/gconv/gconv-modules.cache
44bdf000 44be0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44be7000 44be8000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44be8000 44bec000 rwxs /dev/mali
44bec000 44bf0000 rwxs /dev/mali
44bf0000 44bf4000 rwxs /dev/mali
44bf4000 44bf8000 rwxs /dev/mali
44bf8000 44c00000 rwxs /dev/mali
44d00000 44d08000 rwxs /dev/mali
44d08000 44d18000 rwxs /dev/mali
44d18000 44d1c000 rwxs /dev/mali
44d1c000 44d2c000 rwxs /dev/mali
44d2c000 44d50000 rwxs /dev/mali
44d50000 44d51000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44d58000 44d59000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44d59000 44d5a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44d61000 44d62000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
44d68000 44d78000 rwxs /dev/mali
4557f000 455bf000 rwxs /dev/mali
455bf000 455eb000 rwxs /dev/mali
455ef000 455ff000 rwxs /dev/mali
455ff000 45623000 rwxs /dev/mali
45623000 45647000 rwxs /dev/mali
45647000 4566b000 rwxs /dev/mali
4566b000 4567b000 rwxs /dev/mali
4567b000 4567d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
45684000 45685000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
45687000 45712000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
45713000 45f12000 rwxp [stack:3949]
45f12000 45f52000 rwxs /dev/mali
45f52000 46066000 rwxs /dev/mali
46166000 461f2000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
461f2000 4627a000 rwxs /dev/mali
4627a000 4628a000 rwxs /dev/mali
4628f000 46296000 r-xp /usr/lib/libfeedback.so.0.1.4
4629e000 4629f000 rwxp /usr/lib/libfeedback.so.0.1.4
4629f000 462a9000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
462b0000 462b1000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
462b1000 462b8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
462bf000 462c0000 rwxp /usr/lib/libmmfcommon.so.0.0.0
462c0000 462d6000 r-xp /usr/lib/libmmfsound.so.0.1.0
462de000 462df000 rwxp /usr/lib/libmmfsound.so.0.1.0
462e8000 462ed000 r-xp /usr/lib/libmmfsession.so.0.0.0
462f4000 462f5000 rwxp /usr/lib/libmmfsession.so.0.0.0
462f5000 462ff000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
46307000 46308000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
4630b000 4630f000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
46317000 46318000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
46318000 4632e000 r-xp /usr/lib/libavsysaudio.so.0.0.1
46336000 46337000 rwxp /usr/lib/libavsysaudio.so.0.0.1
46337000 4633c000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
46343000 46344000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
46344000 46347000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4634e000 4634f000 rwxp /usr/lib/libpulse-simple.so.0.0.4
4634f000 46387000 r-xp /usr/lib/libpulse.so.0.16.2
46387000 46388000 rwxp /usr/lib/libpulse.so.0.16.2
4638a000 463ca000 rwxs /dev/mali
463ca000 4640a000 rwxs /dev/mali
4640a000 4642e000 rwxs /dev/mali
4642e000 46452000 rwxs /dev/mali
46452000 46455000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4645c000 4645d000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
4645d000 4646a000 r-xp /usr/lib/libail.so.0.1.0
46472000 46473000 rwxp /usr/lib/libail.so.0.1.0
46476000 46486000 rwxs /dev/mali
46486000 464e7000 r-xp /usr/lib/libasound.so.2.0.0
464ee000 464f1000 rwxp /usr/lib/libasound.so.2.0.0
464f1000 46501000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
46501000 46505000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
46522000 4652a000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
46531000 46532000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
46539000 4653c000 r-xp /usr/lib/libcompress.so.0.2.0
46543000 46544000 rwxp /usr/lib/libcompress.so.0.2.0
46544000 46549000 r-xp /usr/lib/libjson.so.0.0.1
46550000 46551000 rwxp /usr/lib/libjson.so.0.0.1
46551000 46599000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46599000 4659a000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4659a000 465dd000 r-xp /usr/lib/libsndfile.so.1.0.25
465e4000 465e6000 rwxp /usr/lib/libsndfile.so.1.0.25
465ea000 4660c000 r-xp /usr/lib/libvorbis.so.0.4.3
46613000 46614000 rwxp /usr/lib/libvorbis.so.0.4.3
46614000 46618000 r-xp /usr/lib/libogg.so.0.7.1
4661f000 46620000 rwxp /usr/lib/libogg.so.0.7.1
46620000 46630000 rwxs /dev/mali
46630000 46640000 rwxs /dev/mali
46640000 46650000 rwxs /dev/mali
46650000 4668a000 r-xs /opt/usr/apps/org.example.ph1/res/edje/timer.edj
4668a000 46712000 rwxs /dev/mali
46712000 46736000 rwxs /dev/mali
46736000 4675a000 rwxs /dev/mali
4675a000 4676a000 rwxs /dev/mali
46794000 467a4000 rwxs /dev/mali
468c8000 46950000 rwxs /dev/mali
46950000 469d8000 rwxs /dev/mali
bea24000 bea45000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3938)
Call Stack Count: 1
 0: strchrnul + 0x14 (0x403f0638) [/lib/libc.so.6] + 0x77638
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
51+0900 I/AUL_PAD ( 3950): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 21:42:45.031+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:42:45.071+0900 I/MALI    ( 3938): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42f5f020] swap changed from async to sync
05-26 21:42:45.121+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-26 21:42:45.126+0900 I/SHealth_Common( 1055): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-26 21:42:45.126+0900 I/SHealth_Service( 1055): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-26 21:42:45.131+0900 W/WAKEUP-SERVICE( 1115): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-26 21:42:45.131+0900 W/WAKEUP-SERVICE( 1115): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-26 21:42:45.136+0900 W/WAKEUP-SERVICE( 1115): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 21:42:45.141+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-26 21:42:45.141+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-26 21:42:45.141+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 21:42:45.141+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 21:42:45.141+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 21:42:45.141+0900 W/W_HOME  (  737): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-26 21:42:45.141+0900 W/W_HOME  (  737): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-26 21:42:45.141+0900 W/W_HOME  (  737): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-26 21:42:45.141+0900 W/W_HOME  (  737): gesture.c: _apps_status_get(123) > apps status:0
05-26 21:42:45.141+0900 W/W_HOME  (  737): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:785
05-26 21:42:45.141+0900 W/W_HOME  (  737): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-26 21:42:45.141+0900 W/W_HOME  (  737): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-26 21:42:45.141+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:42:45.146+0900 W/STARTER (  709): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [785]ms
05-26 21:42:45.146+0900 W/STARTER (  709): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-26 21:42:45.146+0900 I/APP_CORE( 3938): appcore-efl.c: __do_app(429) > [APP 3938] Event: RESUME State: RUNNING
05-26 21:42:45.156+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-26 21:42:45.161+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-26 21:42:45.161+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(725467197)
05-26 21:42:45.161+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-26 21:42:45.161+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 26-5-2016, 12:53:20 (UTC).
05-26 21:42:45.161+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-26 21:42:45.161+0900 E/ALARM_MANAGER(  492): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[725467197] is removed.
05-26 21:42:45.171+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:42:45.221+0900 W/STARTER (  709): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-26 21:42:45.221+0900 W/STARTER (  709): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-26 21:42:45.231+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:42:45.301+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 21:42:45.301+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 21:42:45.301+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : pedometer_inactive_period error
05-26 21:42:45.301+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:42:45.306+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:42:45.306+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_10min_precaution_millisec error
05-26 21:42:45.306+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:42:45.306+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:42:45.306+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_before_10min_precaution_millisec error
05-26 21:42:45.341+0900 W/W_HOME  (  737): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-26 21:42:45.341+0900 W/W_HOME  (  737): gesture.c: _manual_render_enable(133) > 0
05-26 21:42:46.986+0900 W/SCSD    ( 1200): <_data_cb:507>  - length: 545
05-26 21:42:46.986+0900 W/SCSD    ( 1200): <sap_socket_send:137> sent [545 / 545] bytes
05-26 21:42:47.076+0900 E/wnoti-service(  855): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(534)
05-26 21:42:47.081+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
05-26 21:42:47.081+0900 E/wnoti-service(  855): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-26 21:42:47.096+0900 E/wnoti-service(  855): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 21:42:47.101+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/143
05-26 21:42:47.106+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
05-26 21:42:47.111+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 142
05-26 21:42:47.121+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 21:42:47.126+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/143
05-26 21:42:47.126+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3981) > image is not in gear
05-26 21:42:47.126+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3992) > images are not completed
05-26 21:42:47.126+0900 E/wnoti-service(  855): wnoti-sap-client.c: publish_received_noti(1848) > 1000, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229634, noti_flag : 528, g_span_version : 1
05-26 21:42:47.131+0900 E/wnoti-service(  855): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-26 21:42:47.131+0900 E/wnoti-service(  855): wnoti-sap-client.c: publish_received_noti(2149) > req_app_data_timer : 0
05-26 21:42:47.131+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_received_noti(2772) > INCOMPLETE IMAGES, application_id : 218, seq_num : 229634
05-26 21:42:47.151+0900 E/wnoti-service(  855): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-26 21:42:47.151+0900 E/wnoti-service(  855): wnoti-sap-client.c: on_app_data(143) > source : 0, protocol : 0, seq_num : 229634, duplicated_seq_num_count : 0, g_slot_id : 1
05-26 21:42:47.151+0900 E/wnoti-service(  855): wnoti-consumer.c: wnoti_consumer_send(785) > connect: 1, upsm : 0, connection_type : 16, len : 4, SEND HOST: [23][3][81][2][0][0]
05-26 21:42:47.171+0900 W/SCSD    ( 1200): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x09)
05-26 21:42:47.171+0900 W/SCSD    ( 1200): <on_sap_socket_recv:30>  - remain length: 9, crc_size: 4
05-26 21:42:47.171+0900 W/SCSD    ( 1200): <on_sap_socket_recv:62>  - recv 13 bytes [13 / 13] 
05-26 21:42:47.171+0900 W/SCSD    ( 1200): <util_scs_send:975> sent [15 / 15] bytes. 
05-26 21:42:47.176+0900 E/wnoti-service(  855): wnoti-consumer.c: wnoti_consumer_send(823) > send data success
05-26 21:42:47.226+0900 W/SCSD    ( 1200): <_data_cb:507>  - length: 1984
05-26 21:42:47.226+0900 W/SCSD    ( 1200): <sap_socket_send:137> sent [1984 / 1984] bytes
05-26 21:42:47.236+0900 E/wnoti-service(  855): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(1973)
05-26 21:42:47.236+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
05-26 21:42:47.241+0900 E/wnoti-service(  855): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-26 21:42:47.241+0900 E/wnoti-service(  855): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 21:42:47.241+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_noti_extender(793) > noti_info->label : 4,5,8,9
05-26 21:42:47.246+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/146
05-26 21:42:47.246+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 2
05-26 21:42:47.246+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 1597
05-26 21:42:47.251+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 21:42:47.256+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/146
05-26 21:42:47.261+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_98.png
05-26 21:42:47.261+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/145
05-26 21:42:47.281+0900 E/wnoti-service(  855): wnoti-db-server.c: _clear_summary_noti(933) > _query_step failed(no row)
05-26 21:42:47.281+0900 E/wnoti-service(  855): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 5/0
05-26 21:42:47.281+0900 E/wnoti-service(  855): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 218
05-26 21:42:47.286+0900 E/wnoti-service(  855): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
05-26 21:42:47.286+0900 E/wnoti-service(  855): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 0, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229635, noti_flag : 16, g_span_version : 1
05-26 21:42:47.286+0900 E/wnoti-service(  855): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-26 21:42:47.291+0900 E/wnoti-service(  855): wnoti-db-server.c: _wnoti_update_category(851) > re_table_id : 0
05-26 21:42:47.326+0900 E/wnoti-service(  855): wnoti-db-server.c: set_global_noti_count(1557) > pre_count : 0, count : 1
05-26 21:42:47.356+0900 I/AUL     (  855): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-26 21:42:47.381+0900 I/AUL     (  855): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-26 21:42:47.401+0900 E/APPS    (  737): AppsBadge.cpp: onBadgeChange(215) >  (!pAppsItem) -> onBadgeChange() return
05-26 21:42:47.406+0900 E/wnoti-service(  855): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-26 21:42:47.426+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=604473 button=1 downs=1
05-26 21:42:47.466+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=604515 button=1 downs=0
05-26 21:42:47.821+0900 I/wnoti-service(  855): wnoti-msg-builder.c: _publish_notification(1394) > operation_type : 0, source : 0, application_id : 0, display_count : 0
05-26 21:42:47.846+0900 E/wnoti-proxy(  737): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 737, caller_id : 0, listener_type : 0
05-26 21:42:47.846+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1501) > Change type : 0, op_type: 0, category_id: 0, display count: 0
05-26 21:42:47.846+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1556) > Handle this change type in idler.
05-26 21:42:47.846+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1561) > Home is background. Postpone the board update.
05-26 21:42:48.076+0900 W/SCSD    ( 1200): <_data_cb:507>  - length: 20737
05-26 21:42:48.076+0900 W/SCSD    ( 1200): <sap_socket_send:137> sent [20737 / 20737] bytes
05-26 21:42:48.096+0900 E/wnoti-service(  855): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(20726)
05-26 21:42:48.096+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
05-26 21:42:48.101+0900 E/wnoti-service(  855): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-26 21:42:48.101+0900 E/wnoti-service(  855): wnoti-db-utility.c: logging_image(1685) > [89][50][4e][47]
05-26 21:42:48.111+0900 E/wnoti-service(  855): wnoti-db-utility.c: logging_image(1685) > [89][50][4e][47]
05-26 21:42:48.121+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=605146 button=1 downs=1
05-26 21:42:48.126+0900 E/wnoti-service(  855): wnoti-db-server.c: insert_asset(3797) > [Replace] content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 21:42:48.141+0900 E/wnoti-service(  855): wnoti-db-utility.c: logging_image(1685) > [89][50][4e][47]
05-26 21:42:48.141+0900 E/wnoti-service(  855): wnoti-db-server.c: insert_asset(3792) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/143
05-26 21:42:48.161+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/143
05-26 21:42:48.161+0900 E/wnoti-service(  855): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
05-26 21:42:48.161+0900 E/wnoti-service(  855): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 142
05-26 21:42:48.161+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 21:42:48.161+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/143
05-26 21:42:48.181+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=605230 button=1 downs=0
05-26 21:42:48.291+0900 E/wnoti-service(  855): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_113.png
05-26 21:42:48.301+0900 E/wnoti-service(  855): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 1002/0
05-26 21:42:48.306+0900 E/wnoti-service(  855): wnoti-sap-client.c: _add_exception_handling(581) > type : 1002, application_id : 218
05-26 21:42:48.316+0900 E/wnoti-service(  855): wnoti-sap-client.c: publish_received_noti(1848) > 1002, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229634, noti_flag : 528, g_span_version : 1
05-26 21:42:48.316+0900 E/wnoti-service(  855): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-26 21:42:48.316+0900 E/wnoti-service(  855): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 1
05-26 21:42:48.316+0900 E/wnoti-service(  855): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 1
05-26 21:42:48.526+0900 I/CAPI_NETWORK_CONNECTION( 3938): connection.c: connection_create(372) > New handle created[0x4436e900]
05-26 21:42:48.566+0900 I/SOCKETTEST( 3938): IP : 
05-26 21:42:48.566+0900 W/SCSD    ( 1200): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x05)
05-26 21:42:48.566+0900 W/SCSD    ( 1200): <on_sap_socket_recv:30>  - remain length: 5, crc_size: 4
05-26 21:42:48.566+0900 W/SCSD    ( 1200): <on_sap_socket_recv:62>  - recv 9 bytes [9 / 9] 
05-26 21:42:48.571+0900 I/SOCKETTEST( 3938): Success to create UDP socket
05-26 21:42:48.571+0900 I/SOCKETTEST( 3938): Bind Success
05-26 21:42:48.571+0900 I/SOCKETTEST( 3938): Waiting DATA...
05-26 21:42:48.571+0900 W/SCSD    ( 1200): <util_scs_send:975> sent [11 / 11] bytes. 
05-26 21:42:49.336+0900 W/SCSD    ( 1200): <_data_cb:507>  - length: 11
05-26 21:42:49.336+0900 W/SCSD    ( 1200): <sap_socket_send:137> sent [11 / 11] bytes
05-26 21:42:49.676+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:42:49.821+0900 E/wnoti-service(  855): wnoti-sap-client.c: _get_latest_notification_card(1700) > id : 742, status : 0
05-26 21:42:49.891+0900 I/wnoti-service(  855): wnoti-sap-client.c: launch_alert_view(398) > timer_id : 0, emergency_cb_mode : 0, blocking_mode : 0 
05-26 21:42:49.891+0900 E/wnoti-service(  855): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 1
05-26 21:42:49.896+0900 I/wnoti-service(  855): wnoti-msg-builder.c: _publish_notification(1394) > operation_type : 0, source : 0, application_id : 0, display_count : 0
05-26 21:42:49.926+0900 E/wnoti-proxy(  737): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 737, caller_id : 0, listener_type : 0
05-26 21:42:49.926+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1501) > Change type : 0, op_type: 0, category_id: 0, display count: 0
05-26 21:42:49.926+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1556) > Handle this change type in idler.
05-26 21:42:49.926+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1561) > Home is background. Postpone the board update.
05-26 21:42:49.931+0900 E/wnoti-service(  855): wnoti-sap-client.c: on_timer(291) > is_exist_alert_list : 0, g_launch_popup_time : 1464266569, g_use_aul_launch : 0
05-26 21:42:49.931+0900 E/wnoti-service(  855): wnoti-sap-client.c: on_timer(293) > >> launching notification popup
05-26 21:42:49.941+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 21:42:49.976+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-26 21:42:49.996+0900 I/AUL_AMD (  496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-26 21:42:49.996+0900 E/AUL_AMD (  496): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-26 21:42:49.996+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 855
05-26 21:42:50.031+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 21:42:50.036+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 21:42:50.041+0900 W/AUL_PAD ( 1155): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 21:42:50.041+0900 W/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 21:42:50.161+0900 I/efl-extension( 3950): efl_extension.c: eext_mod_init(40) > Init
05-26 21:42:50.161+0900 I/UXT     ( 3950): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 21:42:50.176+0900 I/wnotibp ( 3950): wnotiboard-popup.c: main(1444) > start main
05-26 21:42:50.226+0900 I/CAPI_APPFW_APPLICATION( 3950): app_main.c: app_efl_main(129) > app_efl_main
05-26 21:42:50.226+0900 I/CAPI_APPFW_APPLICATION( 3950): app_main.c: app_appcore_create(152) > app_appcore_create
05-26 21:42:50.226+0900 I/wnoti-proxy( 3950): wnoti.c: wnoti_register_listener(2997) > type : 0
05-26 21:42:50.226+0900 I/wnoti-proxy( 3950): wnoti.c: wnoti_register_listener(2997) > type : 3
05-26 21:42:50.226+0900 I/wnoti-proxy( 3950): wnoti.c: wnoti_register_listener(2997) > type : 4
05-26 21:42:50.226+0900 I/wnoti-proxy( 3950): wnoti.c: wnoti_register_listener(2997) > type : 5
05-26 21:42:50.226+0900 I/wnoti-proxy( 3950): wnoti.c: wnoti_register_listener(2997) > type : 6
05-26 21:42:50.226+0900 I/wnoti-proxy( 3950): wnoti.c: wnoti_register_listener(2997) > type : 7
05-26 21:42:50.226+0900 I/wnoti-proxy( 3950): wnoti.c: wnoti_register_listener(2997) > type : 8
05-26 21:42:50.251+0900 E/RESOURCED(  497): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.wnotification2
05-26 21:42:50.296+0900 I/wnotibp ( 3950): wnotiboard-popup-dbus.c: wnoti_dbus_oom_priority_signal_send(521) > Sending OOM priority request signal
05-26 21:42:50.316+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-26 21:42:50.331+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_create(1093) > is_enhanced_power_saving_mode: 0
05-26 21:42:50.341+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: RESET State: CREATED
05-26 21:42:50.341+0900 I/CAPI_APPFW_APPLICATION( 3950): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 21:42:50.341+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:42:50.351+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 21:42:50.351+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: wnotiboard_popup_get_block_mode(2354) > Returning false.
05-26 21:42:50.356+0900 E/wnoti-service(  855): wnoti-db-client.c: wnoti_get_alert_categories(712) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 218, db_id : 742, is_duplicated : 0
05-26 21:42:50.361+0900 E/wnoti-service(  855): wnoti-db-client.c: wnoti_get_alert_categories(851) > view_type : 1, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 0
05-26 21:42:50.381+0900 I/wnoti-proxy( 3950): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-26 21:42:50.381+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(813) > application_name: 카카오톡, application_id: 218, category_id: 34, time: 1464266567, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_218.jpg, icon_color: -5730296
05-26 21:42:50.381+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(820) > noti_type: 1
05-26 21:42:50.386+0900 W/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(77) > db_id = 742, alert_type: 1, app_feedback_type: 0
05-26 21:42:50.386+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(372) > Activity fetch finished: -1
05-26 21:42:50.386+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(377) > activity action count: 1
05-26 21:42:50.386+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(382) > 1 activities retrieved.
05-26 21:42:50.386+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(473) > Page fetch finished: -1
05-26 21:42:50.386+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(478) > wearable_page_cnt: 1
05-26 21:42:50.386+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_convert_alert_data(483) > 1 pages retrieved.
05-26 21:42:50.386+0900 W/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 1, list count : 1
05-26 21:42:50.386+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_control(1131) > ::DATA:: CHECK IN APP CONTROL : 1, 0, 1
05-26 21:42:50.386+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_control(1143) > ::APP:: CHECK STATE : 1, 0, (null)
05-26 21:42:50.386+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_control(1174) > Screen type: 2
05-26 21:42:50.426+0900 E/TBM     ( 3950): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 21:42:50.451+0900 I/SOCKETTEST( 3938): Receive Data : 192.168.0.47
05-26 21:42:50.451+0900 I/SOCKETTEST( 3938): Changed IP : 192.168.0.47
05-26 21:42:50.456+0900 I/SOCKETTEST( 3938): Success to create socket
05-26 21:42:50.521+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05600008)
05-26 21:42:50.521+0900 I/SOCKETTEST( 3938): Success to socket connection
05-26 21:42:50.521+0900 I/SOCKETTEST( 3938): write() 성공
05-26 21:42:50.651+0900 E/EFL     ( 3950): elementary<3950> elm_widget.c:4367 elm_widget_type_check() Passing Object: 0x45105338 in function: elm_win_resize_object_add, of type: 'elm_layout' when expecting type: 'elm_win'
05-26 21:42:50.651+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x0560000a)
05-26 21:42:50.656+0900 E/EFL     ( 3950): elementary<3950> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x451063b8 into part 'elm.swallow.bg'
05-26 21:42:50.656+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_control(1254) > Window width: 360.000000, height: 360.000000
05-26 21:42:50.656+0900 I/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_window_resize_cb(80) > geometry (0 0 360 360)
05-26 21:42:50.721+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:42:50.721+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:42:50.721+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(628) > [742, 1, 1, 1, 0000]
05-26 21:42:50.721+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(629) > [0, 1, 0, 0]
05-26 21:42:50.721+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(630) > [1, 0, 0, 0]
05-26 21:42:50.721+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-26 21:42:50.721+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4443) > wnotiboard_popup_vi_type: 2
05-26 21:42:50.721+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4449) > (742, 742)
05-26 21:42:50.816+0900 I/efl-extension( 3950): efl_extension_circle_surface.c: eext_circle_surface_layout_add(1293) > Put the surface[0x45197750]'s widget[0x45178e50] to layout widget[0x451786d0]
05-26 21:42:50.826+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_create_genlist(4377) > (742, 742)
05-26 21:42:50.861+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:42:50.861+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:42:50.866+0900 I/efl-extension( 3950): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:42:50.866+0900 I/efl-extension( 3950): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:42:50.901+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_create_card_data(3979) > 0x451051b8, 0x45105038, 0x45105038
05-26 21:42:50.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 21:42:50.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:42:50.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 21:42:50.901+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 21:42:50.971+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(472) > Legacy lifecycle: 1
05-26 21:42:50.976+0900 E/E17     (  381): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x05600008)
05-26 21:42:50.981+0900 I/efl-extension( 3991): efl_extension.c: eext_mod_init(40) > Init
05-26 21:42:50.986+0900 W/APP_CORE( 3950): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5600008
05-26 21:42:50.986+0900 E/APP_CORE( 3950): appcore-efl.c: __show_cb(783) >  This is child window. Skip!!! WIN:560000a
05-26 21:42:50.991+0900 W/APP_CORE( 3950): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:560000a
05-26 21:42:50.996+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3991): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-26 21:42:50.996+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3991): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:42:50.996+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3991): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-26 21:42:50.996+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3991): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-26 21:42:51.001+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3991): system_settings.c: system_settings_set_changed_cb(534) > Enter [system_settings_set_changed_cb]
05-26 21:42:51.001+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3991): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-26 21:42:51.001+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3991): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-26 21:42:51.066+0900 E/PKGMGR  ( 3991): pkgmgr.c: pkgmgr_client_set_status_type(2914) > [0;31m[pkgmgr_client_set_status_type(): 2914](status_type == PKGMGR_CLIENT_STATUS_ALL) status_type is PKGMGR_CLIENT_STATUS_ALL[0;m
05-26 21:42:51.081+0900 W/wnotibp ( 3950): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2201) > Unhandled part: stack.separator
05-26 21:42:51.086+0900 I/wnotibp ( 3950): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:42:51.091+0900 I/wnotibp ( 3950): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:42:51.096+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 21:42:51.096+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:42:51.096+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 21:42:51.096+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 21:42:51.176+0900 E/EFL     ( 3950): evas_main<3950> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 21:42:51.176+0900 E/EFL     ( 3950): evas_main<3950> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 21:42:51.176+0900 E/EFL     ( 3950): evas_main<3950> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 21:42:51.176+0900 I/wnotibp ( 3950): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:42:51.181+0900 I/wnotibp ( 3950): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:42:51.181+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 21:42:51.181+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:42:51.181+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 21:42:51.181+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3950): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 21:42:51.231+0900 E/EFL     ( 3950): evas_main<3950> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x451c3530 is not stable during recalc loop
05-26 21:42:51.231+0900 E/EFL     ( 3950): evas_main<3950> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x451c3530 is not stable during recalc loop
05-26 21:42:51.251+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:42:51.251+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-26 21:42:51.266+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:42:51.266+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:42:51.286+0900 I/wnotibp ( 3950): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1037) > fully_obscured: 0 [0x5600008 0x560000a 0x5600008 ]
05-26 21:42:51.286+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: RESUME State: RUNNING
05-26 21:42:51.301+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3713) > ::UI:: VI TYPE : 2
05-26 21:42:51.301+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3719) > alert_type : 1, is_source_companion: 1
05-26 21:42:51.306+0900 W/TIZEN_N_RECORDER( 3950): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
05-26 21:42:51.311+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1272) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
05-26 21:42:51.311+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1281) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
05-26 21:42:51.316+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1315) > ::APP:: Determined feedback: sound 0, vibration: 0
05-26 21:42:51.316+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1319) > No feedback.
05-26 21:42:51.321+0900 I/MALI    ( 3938): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f5f020] swap changed from sync to async
05-26 21:42:51.386+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:42:51.391+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3950
05-26 21:42:51.411+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_lock(856) > ::UI:: [[[ ===> already [small popup] is LOCK, 0010 ]]]
05-26 21:42:51.411+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_pre_cb(2194) > ::UI:: start showing animation
05-26 21:42:51.536+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:42:51.716+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_cb(2104) > ::UI:: end show animation
05-26 21:42:51.716+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-26 21:42:51.716+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-26 21:42:51.726+0900 E/wnoti-service(  855): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
05-26 21:42:51.726+0900 E/wnoti-service(  855): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 2
05-26 21:42:51.736+0900 E/wnoti-service(  855): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-26 21:42:51.741+0900 E/wnoti-proxy( 3950): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
05-26 21:42:51.741+0900 E/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(916) > ::DATA:: No categories available.
05-26 21:42:51.741+0900 W/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 0, list count : 1
05-26 21:42:51.901+0900 E/wnoti-service(  855): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
05-26 21:42:52.001+0900 I/AUL_PAD ( 3996): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 21:42:53.901+0900 E/wnoti-service(  855): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
05-26 21:42:53.911+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-26 21:42:53.911+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_main_popup_timer_cb(2324) > ::UI:: start hiding animation
05-26 21:42:54.216+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_hide_animator_cb(2255) > ::UI:: end hiding animation
05-26 21:42:54.216+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-26 21:42:54.216+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-26 21:42:54.216+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (8, 1, 0)
05-26 21:42:54.216+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=0, view_state=0
05-26 21:42:54.216+0900 I/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(903) > ::UI:: it is invalid object.
05-26 21:42:54.216+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [invalid object] is UNLOCK , 0000 <=== ]]]
05-26 21:42:54.216+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-26 21:42:54.216+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 742
05-26 21:42:54.216+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 0, 0
05-26 21:42:54.226+0900 I/efl-extension( 3950): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4517a1d0, obj: 0x4517a1d0
05-26 21:42:54.226+0900 I/efl-extension( 3950): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:42:54.226+0900 I/efl-extension( 3950): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:42:54.226+0900 I/efl-extension( 3950): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:42:54.226+0900 I/efl-extension( 3950): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:42:54.241+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:42:54.241+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4517a1d0, elm_genlist, func : 0x41a25dfd
05-26 21:42:54.241+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:42:54.246+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:42:54.246+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(998) > ::UI:: lock state = 0000
05-26 21:42:54.251+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(2024) > ::INFO:: call lower
05-26 21:42:54.256+0900 W/APP_CORE( 3950): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:5600008
05-26 21:42:54.261+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: PAUSE State: RUNNING
05-26 21:42:54.261+0900 I/CAPI_APPFW_APPLICATION( 3950): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 21:42:54.341+0900 I/MALI    ( 3938): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42f5f020] swap changed from async to sync
05-26 21:42:54.361+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-26 21:42:54.361+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:42:54.361+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [0, 0, 1, 0000]
05-26 21:42:54.361+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 0]
05-26 21:42:54.361+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1371) > [0, 1, 0, 2, 0]
05-26 21:42:54.451+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=611503 button=1 downs=1
05-26 21:42:54.506+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=611558 button=1 downs=0
05-26 21:42:54.561+0900 D/TIMER   ( 3938): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:42:54.561+0900 D/TIMER   ( 3938): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:42:54.621+0900 I/efl-extension( 3938): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:42:54.621+0900 I/efl-extension( 3938): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:42:54.621+0900 I/efl-extension( 3938): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:42:54.626+0900 I/efl-extension( 3938): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:42:54.626+0900 I/efl-extension( 3938): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c113d0, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:42:55.281+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=612329 button=1 downs=1
05-26 21:42:55.336+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=612388 button=1 downs=0
05-26 21:42:55.906+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=612953 button=1 downs=1
05-26 21:42:55.981+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=613029 button=1 downs=0
05-26 21:42:56.876+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=613923 button=1 downs=1
05-26 21:42:56.941+0900 E/EFL     ( 3938): evas_main<3938> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=613992 button=1 downs=0
05-26 21:42:56.946+0900 I/efl-extension( 3938): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:42:56.946+0900 I/efl-extension( 3938): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c113d0, elm_layout, func : 0x400038e1
05-26 21:42:56.946+0900 I/efl-extension( 3938): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:42:56.946+0900 I/efl-extension( 3938): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:42:56.946+0900 I/efl-extension( 3938): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:42:56.946+0900 I/efl-extension( 3938): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:42:56.946+0900 I/efl-extension( 3938): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:42:56.946+0900 I/efl-extension( 3938): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:42:56.946+0900 E/EFL     ( 3938): ecore<3938> ecore.c:574 _ecore_magic_fail() 
05-26 21:42:56.946+0900 E/EFL     ( 3938): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:42:56.946+0900 E/EFL     ( 3938): *** IN FUNCTION: ecore_timer_del()
05-26 21:42:56.946+0900 E/EFL     ( 3938): ecore<3938> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:42:56.946+0900 E/EFL     ( 3938):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:42:56.946+0900 E/EFL     ( 3938):     Supplied: e5933114 - <UNKNOWN>
05-26 21:42:56.946+0900 E/EFL     ( 3938): ecore<3938> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:42:56.946+0900 E/EFL     ( 3938): *** SPANK SPANK SPANK!!!
05-26 21:42:56.946+0900 E/EFL     ( 3938): *** Now go fix your code. Tut tut tut!
05-26 21:42:56.946+0900 E/EFL     ( 3938): ecore<3938> ecore.c:574 _ecore_magic_fail() 
05-26 21:42:56.946+0900 E/EFL     ( 3938): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:42:56.946+0900 E/EFL     ( 3938): *** IN FUNCTION: ecore_timer_del()
05-26 21:42:56.946+0900 E/EFL     ( 3938): ecore<3938> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:42:56.946+0900 E/EFL     ( 3938):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:42:56.946+0900 E/EFL     ( 3938):     Supplied: 403e8280 - <UNKNOWN>
05-26 21:42:56.946+0900 E/EFL     ( 3938): ecore<3938> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:42:56.946+0900 E/EFL     ( 3938): *** SPANK SPANK SPANK!!!
05-26 21:42:56.946+0900 E/EFL     ( 3938): *** Now go fix your code. Tut tut tut!
05-26 21:42:56.946+0900 I/SOCKETTEST( 3938): Success to create socket
05-26 21:42:56.951+0900 I/SOCKETTEST( 3938): Success to socket connection
05-26 21:42:56.951+0900 I/SOCKETTEST( 3938): write() 성공
05-26 21:42:57.441+0900 W/CRASH_MANAGER( 4023): worker.c: worker_job(1199) > 1103938706831146426657
