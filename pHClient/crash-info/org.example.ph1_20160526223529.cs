S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 12725
Date: 2016-05-26 22:35:29+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 12725, uid 5000)

Register Information
r0   = 0x303d5849, r1   = 0x00000025
r2   = 0xbe9c522c, r3   = 0x303d5849
r4   = 0xfbad8001, r5   = 0xbe9c522c
r6   = 0xbe9c4cf8, r7   = 0x4049e000
r8   = 0x00000000, r9   = 0x42e9bbdc
r10  = 0x303d5849, fp   = 0xbe9c4cec
ip   = 0x400dea1c, sp   = 0xbe9c4778
lr   = 0x403b5f5c, pc   = 0x403f0638
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     13556 KB
Buffers:     34796 KB
Cached:     164212 KB
VmPeak:     114464 KB
VmSize:     107020 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23536 KB
VmRSS:       23536 KB
VmData:      45896 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       55284 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 12725 TID = 12725
12725 12732 12733 12736 

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
43758000 4375b000 rwxp [stack:12733]
4375b000 4375f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43766000 43767000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43767000 4376b000 rwxs /dev/mali
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
43778000 43f77000 rwxp [stack:12732]
43f77000 43f7f000 rwxs /dev/mali
43f7f000 43f87000 rwxs /dev/mali
43f87000 43f8b000 rwxs /dev/mali
43f8b000 43f9b000 rwxs /dev/mali
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
44bd8000 44bdb000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
44be2000 44be3000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
44be3000 44be4000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
44beb000 44bec000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
44bec000 44bf0000 rwxs /dev/mali
44bf0000 44bf4000 rwxs /dev/mali
44bf4000 44bfb000 r-xs /usr/lib/gconv/gconv-modules.cache
44bfb000 44bff000 rwxs /dev/mali
45500000 45540000 rwxs /dev/mali
45540000 45580000 rwxs /dev/mali
45580000 455a4000 rwxs /dev/mali
455a4000 455c8000 rwxs /dev/mali
455c8000 455cc000 rwxs /dev/mali
455cc000 455f0000 rwxs /dev/mali
455f0000 455f1000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
455f8000 455f9000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
455f9000 455fd000 rwxs /dev/mali
455fd000 455fe000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45605000 45606000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45608000 45693000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
45694000 45f93000 rwxp [stack:12736]
45f93000 45fbf000 rwxs /dev/mali
45fbf000 45fcf000 rwxs /dev/mali
45fcf000 45fd3000 rwxs /dev/mali
45fd3000 4605f000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
4605f000 460e7000 rwxs /dev/mali
461e7000 462fb000 rwxs /dev/mali
462fb000 462ff000 rwxs /dev/mali
46400000 46410000 rwxs /dev/mali
46410000 46420000 rwxs /dev/mali
46420000 46430000 rwxs /dev/mali
46430000 46440000 rwxs /dev/mali
46440000 46450000 rwxs /dev/mali
46450000 46460000 rwxs /dev/mali
46460000 46470000 rwxs /dev/mali
46470000 46480000 rwxs /dev/mali
46480000 46488000 rwxs /dev/mali
46488000 46498000 rwxs /dev/mali
46498000 464a8000 rwxs /dev/mali
464a8000 464cc000 rwxs /dev/mali
464cc000 464dc000 rwxs /dev/mali
464dc000 464ec000 rwxs /dev/mali
464f1000 464f8000 r-xp /usr/lib/libfeedback.so.0.1.4
46500000 46501000 rwxp /usr/lib/libfeedback.so.0.1.4
46501000 46502000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
46509000 4650a000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
4650a000 4650c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
46513000 46514000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
46514000 4651e000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
46525000 46526000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
46526000 4652d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
46534000 46535000 rwxp /usr/lib/libmmfcommon.so.0.0.0
46535000 4653a000 r-xp /usr/lib/libmmfsession.so.0.0.0
46541000 46542000 rwxp /usr/lib/libmmfsession.so.0.0.0
46542000 4654c000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
46554000 46555000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
4655c000 4659c000 rwxs /dev/mali
4659c000 465dc000 rwxs /dev/mali
465dc000 465f2000 r-xp /usr/lib/libmmfsound.so.0.1.0
465fa000 465fb000 rwxp /usr/lib/libmmfsound.so.0.1.0
46604000 46608000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
46610000 46611000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
46611000 46627000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4662f000 46630000 rwxp /usr/lib/libavsysaudio.so.0.0.1
46630000 46635000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
4663c000 4663d000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
4663d000 46640000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46647000 46648000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46648000 46658000 rwxs /dev/mali
46658000 46668000 rwxs /dev/mali
46668000 46678000 rwxs /dev/mali
46678000 46688000 rwxs /dev/mali
46688000 466e9000 r-xp /usr/lib/libasound.so.2.0.0
466f0000 466f3000 rwxp /usr/lib/libasound.so.2.0.0
466f3000 4672b000 r-xp /usr/lib/libpulse.so.0.16.2
4672b000 4672c000 rwxp /usr/lib/libpulse.so.0.16.2
4672c000 4672f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
46736000 46737000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
46737000 46744000 r-xp /usr/lib/libail.so.0.1.0
4674c000 4674d000 rwxp /usr/lib/libail.so.0.1.0
4674d000 4675d000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
4675d000 46761000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
4677e000 46786000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
4678d000 4678e000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
46795000 46798000 r-xp /usr/lib/libcompress.so.0.2.0
4679f000 467a0000 rwxp /usr/lib/libcompress.so.0.2.0
467a0000 467a5000 r-xp /usr/lib/libjson.so.0.0.1
467ac000 467ad000 rwxp /usr/lib/libjson.so.0.0.1
467ad000 467f5000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
467f5000 467f6000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
467f6000 46839000 r-xp /usr/lib/libsndfile.so.1.0.25
46840000 46842000 rwxp /usr/lib/libsndfile.so.1.0.25
46846000 46868000 r-xp /usr/lib/libvorbis.so.0.4.3
4686f000 46870000 rwxp /usr/lib/libvorbis.so.0.4.3
46870000 46874000 r-xp /usr/lib/libogg.so.0.7.1
4687b000 4687c000 rwxp /usr/lib/libogg.so.0.7.1
4687c000 4688c000 rwxs /dev/mali
4688c000 4689c000 rwxs /dev/mali
4689c000 468ac000 rwxs /dev/mali
468ac000 46934000 rwxs /dev/mali
46934000 46944000 rwxs /dev/mali
46954000 46978000 rwxs /dev/mali
46978000 46a00000 rwxs /dev/mali
46b00000 46b08000 rwxs /dev/mali
46b08000 46b18000 rwxs /dev/mali
46b18000 46b3c000 rwxs /dev/mali
46b84000 46bbe000 r-xs /opt/usr/apps/org.example.ph1/res/edje/timer.edj
46bbe000 46c46000 rwxs /dev/mali
be9a5000 be9c6000 rwxp [stack]
End of Maps Information

Callstack Information (PID:12725)
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
imerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-26 22:35:20.666+0900 E/weather-widget(  801): WidgetMain.cpp: ResumeWidgetInstance(1474) > [0;40;31mhomerun[0;m
05-26 22:35:20.666+0900 I/CAPI_WIDGET_APPLICATION(  801): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
05-26 22:35:20.666+0900 I/CAPI_WIDGET_APPLICATION(  801): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
05-26 22:35:20.666+0900 E/weather-widget(  801): WidgetMain.cpp: UpdateWidgetInstance(1691) > [0;40;31mUpdateWidgetInstance[0;m
05-26 22:35:20.666+0900 I/CAPI_WIDGET_APPLICATION(  801): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 22:35:20.706+0900 W/W_HOME  (  737): event_manager.c: _home_scroll_cb(564) > scroll,done
05-26 22:35:20.866+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:35:20.866+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:35:20.866+0900 I/efl-extension(  737): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x45c961a0, elm_box, time_stamp : 3757915
05-26 22:35:20.866+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_rotary_cb(568) > Pass rotary event to home.
05-26 22:35:20.871+0900 W/W_HOME  (  737): home_navigation.c: _is_rightedge(188) > (1080 360) not right edge: 0 0 0x479da3b8 -> 360 0 0x4777ee48
05-26 22:35:20.876+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45c93c20 : elm_scroller] rotary callabck is called.
05-26 22:35:20.876+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45c93c20 : elm_scroller] block(2)
05-26 22:35:20.876+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45c93c20 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-26 22:35:20.876+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45c93c20 : elm_scroller] content size (w, h)(2520, 360)
05-26 22:35:20.876+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45c93c20 : elm_scroller] viewport size (w, h)(360, 360)
05-26 22:35:20.876+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45c93c20 : elm_scroller] CurrentPage(3) DetentCount(-1)
05-26 22:35:20.876+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93c20 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(1080), py(0)
05-26 22:35:20.876+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93c20 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(1080), py(0)
05-26 22:35:20.876+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93c20 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(1080), py(0)
05-26 22:35:20.876+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45c93c20 : elm_scroller] bring in 2 page
05-26 22:35:20.876+0900 W/W_HOME  (  737): event_manager.c: _home_scroll_cb(564) > scroll,start
05-26 22:35:20.876+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:20.876+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:20.891+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:20.891+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:20.906+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:20.906+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:20.921+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:20.921+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:20.926+0900 W/W_HOME  (  737): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
05-26 22:35:20.941+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:20.941+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:20.956+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:20.956+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:20.966+0900 E/weather-widget(  801): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1574) > [0;40;31mUpdateWidgetInstanceTimerCb[0;m
05-26 22:35:20.981+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:20.981+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:20.981+0900 E/weather-widget(  801): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1615) > [0;40;31mcontent is NULL[0;m
05-26 22:35:21.001+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:21.001+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:21.006+0900 E/weather-widget(  801): WidgetView.cpp: UpdateViewPage(299) > [0;40;31mUpdateViewPage locationId : 4111000000[0;m
05-26 22:35:21.011+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:21.011+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:21.031+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:21.031+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:21.046+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:21.046+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:21.061+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:21.061+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:21.076+0900 E/weather-widget(  801): WidgetView.cpp: SetBackgroundImage(155) > [0;40;31mbackground color code:AO098[0;m
05-26 22:35:21.076+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:21.076+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:21.086+0900 E/weather-widget(  801): WidgetView.cpp: SetBackgroundImage(165) > [0;40;31mbackground image color code:AO0953[0;m
05-26 22:35:21.096+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:21.096+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:21.096+0900 W/LOCATION(  801): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
05-26 22:35:21.101+0900 E/weather-common(  801): Location.cpp: IsLocationServiceAvailable(297) > [0;40;31menabled : 0[0;m
05-26 22:35:21.101+0900 E/weather-widget(  801): WidgetMain.cpp: CheckAndRequestAutoRefresh(1151) > [0;40;31m[CheckAndRequestAutoRefresh(): 1151] (locationPtr->IsLocationServiceAvailable() == false) [break][0;m
05-26 22:35:21.101+0900 E/EFL     (  801): edje<801> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'timeSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 22:35:21.106+0900 E/EFL     (  801): edje<801> edje_util.c:3770 edje_object_size_min_restricted_calc() group highLowTemperature has a non-fixed part 'low'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 22:35:21.106+0900 E/EFL     (  801): edje<801> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'weatherIconSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-26 22:35:21.111+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:21.111+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:21.126+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 22:35:21.126+0900 I/ELM_RPANEL(  737): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 22:35:21.141+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 22:35:21.141+0900 E/weather-widget(  801): WidgetMain.cpp: PauseWidgetInstance(1395) > [0;40;31mPauseWidgetInstance[0;m
05-26 22:35:21.141+0900 I/efl-extension(  737): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93c20 : elm_scroller] CurrentPage(2)
05-26 22:35:21.146+0900 E/weather-widget(  801): WidgetView.cpp: HideActivityIndicator(753) > [0;40;31m[HideActivityIndicator(): 753] (refreshButtonLayout == NULL) [return][0;m
05-26 22:35:21.146+0900 E/weather-widget(  801): WidgetView.cpp: Pause(1739) > [0;40;31mOnClosed[0;m
05-26 22:35:21.146+0900 E/weather-widget(  801): WidgetMain.cpp: DeleteUpdateTimerData(267) > [0;40;31m[DeleteUpdateTimerData(): 267] (size < 1) [return][0;m
05-26 22:35:21.156+0900 E/weather-widget(  801): WidgetMain.cpp: PauseWidgetInstance(1436) > [0;40;31mlocationID : 4111000000[0;m
05-26 22:35:21.156+0900 I/CAPI_WIDGET_APPLICATION(  801): widget_app.c: __provider_pause_cb(296) > widget obj was paused
05-26 22:35:21.161+0900 I/CAPI_WIDGET_APPLICATION(  801): widget_app.c: __check_status_for_cgroup(145) > enter background group
05-26 22:35:21.256+0900 W/W_HOME  (  737): event_manager.c: _home_scroll_cb(564) > scroll,done
05-26 22:35:21.431+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:35:21.431+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(172) ev->cur.canvas.y(88)
05-26 22:35:21.431+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:35:21.431+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3758477 button=1 downs=1
05-26 22:35:21.456+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:35:21.456+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(174) ev->cur.canvas.y(92)
05-26 22:35:21.456+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:35:21.456+0900 E/EFL     (  797): evas_main<797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3758472 button=1 downs=1
05-26 22:35:21.456+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:35:21.456+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:35:21.456+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:35:21.471+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3758515 button=1 downs=0
05-26 22:35:21.486+0900 E/EFL     (  797): evas_main<797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3758524 button=1 downs=0
05-26 22:35:21.496+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:35:21.496+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 797
05-26 22:35:21.496+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:35:21.506+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 737
05-26 22:35:21.511+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESET State: RUNNING
05-26 22:35:21.511+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 22:35:21.511+0900 W/W_HOME  (  737): main.c: _app_control(1726) > Service value : launch_apps
05-26 22:35:21.511+0900 W/W_HOME  (  737): move.c: move_move_to_apps(216) > move to apps
05-26 22:35:21.511+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47740530
05-26 22:35:21.511+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47740530, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:35:21.511+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:35:21.511+0900 W/W_HOME  (  737): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-26 22:35:21.511+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:35:21.511+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:35:21.511+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(737), cmd(0)
05-26 22:35:21.526+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-26 22:35:21.526+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-26 22:35:21.526+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-26 22:35:21.526+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:35:21.526+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:35:21.526+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:35:21.526+0900 W/W_HOME  (  737): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
05-26 22:35:21.526+0900 W/W_HOME  (  737): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-26 22:35:21.526+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-26 22:35:21.526+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-26 22:35:21.696+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 22:35:21.801+0900 W/W_HOME  (  737): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-26 22:35:21.801+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:35:21.801+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47740530
05-26 22:35:21.801+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:35:21.801+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47740530, elm_layout, func : 0x4004b469
05-26 22:35:21.801+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:35:21.801+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:35:21.801+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:35:21.801+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47740530, activated : 1
05-26 22:35:21.801+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:35:21.801+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:35:21.801+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:35:21.801+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-26 22:35:21.801+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-26 22:35:21.801+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:35:21.806+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:35:21.806+0900 W/W_HOME  (  737): main.c: home_pause(751) > clock/widget paused
05-26 22:35:21.806+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:35:21.806+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:35:21.806+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 22:35:21.806+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:35:21.806+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:35:21.806+0900 W/W_HOME  (  737): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-26 22:35:21.806+0900 W/W_HOME  (  737): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-26 22:35:21.806+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-26 22:35:21.806+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-26 22:35:21.806+0900 E/APPS    (  737): apps_main.c: apps_main_resume(621) >  resumed already
05-26 22:35:21.811+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:35:21.811+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:35:21.811+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:35:21.811+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:35:21.976+0900 W/W_HOME  (  737): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-26 22:35:22.046+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 22:35:22.056+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3759095 button=1 downs=1
05-26 22:35:22.056+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [178, 205]
05-26 22:35:22.116+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3759156 button=1 downs=0
05-26 22:35:22.116+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [178, 205]->[181, 210]
05-26 22:35:22.116+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-26 22:35:22.116+0900 E/APPS    (  737): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-26 22:35:22.116+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-26 22:35:22.121+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:35:22.121+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 737
05-26 22:35:22.121+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:35:22.136+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 12725
05-26 22:35:22.136+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(12725), cmd(0)
05-26 22:35:22.136+0900 I/APP_CORE(12725): appcore-efl.c: __do_app(429) > [APP 12725] Event: RESET State: PAUSED
05-26 22:35:22.136+0900 I/CAPI_APPFW_APPLICATION(12725): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 22:35:22.136+0900 I/APP_CORE(12725): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-26 22:35:22.141+0900 I/APP_CORE(12725): appcore-efl.c: __do_app(481) > [APP 12725] App already running, raise the window
05-26 22:35:22.141+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:35:22.151+0900 E/E17     (  381): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x03e00003)
05-26 22:35:22.156+0900 I/APP_CORE(12725): appcore-efl.c: __do_app(485) > [APP 12725] Call the resume_cb
05-26 22:35:22.156+0900 I/CAPI_APPFW_APPLICATION(12725): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 22:35:22.206+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 22:35:22.211+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 22:35:22.211+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:35:22.211+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:35:22.211+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:35:22.211+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 22:35:22.221+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:35:22.221+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:35:22.231+0900 I/APP_CORE(12725): appcore-efl.c: __do_app(429) > [APP 12725] Event: RESUME State: RUNNING
05-26 22:35:22.241+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 22:35:22.241+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 22:35:22.241+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:35:22.241+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 22:35:22.246+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 22:35:22.246+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:35:22.246+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 22:35:22.246+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 22:35:22.246+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:35:22.246+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:35:22.246+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:35:22.246+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 22:35:22.246+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:35:22.246+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 22:35:22.246+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:35:22.246+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:35:22.246+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:35:22.246+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 22:35:22.246+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:35:22.246+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:35:22.246+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:35:22.256+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:35:22.256+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:35:22.256+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 22:35:22.256+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:35:22.256+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:35:22.301+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 22:35:22.301+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:35:22.311+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 22:35:22.511+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:35:22.511+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-26 22:35:22.601+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:35:22.756+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:35:22.776+0900 E/EFL     (12725): evas_main<12725> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3759821 button=1 downs=1
05-26 22:35:22.846+0900 E/EFL     (12725): evas_main<12725> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3759896 button=1 downs=0
05-26 22:35:23.756+0900 E/EFL     (12725): evas_main<12725> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3760800 button=1 downs=1
05-26 22:35:23.846+0900 E/EFL     (12725): evas_main<12725> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3760895 button=1 downs=0
05-26 22:35:24.121+0900 I/CAPI_NETWORK_CONNECTION(12725): connection.c: connection_create(372) > New handle created[0x46306870]
05-26 22:35:24.146+0900 I/SOCKETTEST(12725): IP : 
05-26 22:35:24.146+0900 I/SOCKETTEST(12725): Success to create UDP socket
05-26 22:35:24.146+0900 I/SOCKETTEST(12725): Bind Success
05-26 22:35:24.146+0900 I/SOCKETTEST(12725): Waiting DATA...
05-26 22:35:25.726+0900 I/SOCKETTEST(12725): Receive Data : 192.168.0.47
05-26 22:35:25.726+0900 I/SOCKETTEST(12725): Changed IP : 192.168.0.47
05-26 22:35:25.776+0900 I/SOCKETTEST(12725): Success to create socket
05-26 22:35:25.791+0900 I/SOCKETTEST(12725): Success to socket connection
05-26 22:35:25.796+0900 I/SOCKETTEST(12725): write() 성공
05-26 22:35:26.676+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-26 22:35:26.676+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-26 22:35:26.676+0900 E/WMS     (  491): ==========
05-26 22:35:26.676+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
05-26 22:35:26.676+0900 E/WMS     (  491): ==========
05-26 22:35:26.676+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-26 22:35:26.771+0900 W/SHealth_Service( 1055): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-26 22:35:26.771+0900 E/SHealth_Service( 1055): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-26 22:35:26.771+0900 W/SCSD    ( 1200): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-26 22:35:26.771+0900 W/SCSD    ( 1200): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-26 22:35:26.771+0900 W/SCSD    ( 1200): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-26 22:35:26.786+0900 W/SCSD    ( 1200): <util_scs_send:975> sent [63 / 63] bytes. 
05-26 22:35:27.141+0900 E/EFL     (12725): evas_main<12725> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3764190 button=1 downs=1
05-26 22:35:27.221+0900 E/EFL     (12725): evas_main<12725> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3764272 button=1 downs=0
05-26 22:35:27.261+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:35:27.276+0900 D/TIMER   (12725): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:35:27.276+0900 D/TIMER   (12725): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:35:27.331+0900 I/efl-extension(12725): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:35:27.331+0900 I/efl-extension(12725): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:35:27.331+0900 I/efl-extension(12725): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:35:27.331+0900 I/efl-extension(12725): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:35:27.336+0900 I/efl-extension(12725): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c066d8, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:35:27.961+0900 E/EFL     (12725): evas_main<12725> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3765012 button=1 downs=1
05-26 22:35:28.041+0900 E/EFL     (12725): evas_main<12725> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3765094 button=1 downs=0
05-26 22:35:28.536+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.541+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.541+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.541+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765587
05-26 22:35:28.541+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.581+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.581+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.581+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765631
05-26 22:35:28.581+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.581+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.621+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.621+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.621+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765669
05-26 22:35:28.621+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.621+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.641+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.641+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.646+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.646+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765693
05-26 22:35:28.646+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.666+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.666+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.666+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765716
05-26 22:35:28.666+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.666+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.691+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.691+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.691+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765742
05-26 22:35:28.691+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.691+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.726+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.731+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.731+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.731+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765778
05-26 22:35:28.731+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.751+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.751+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.751+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765802
05-26 22:35:28.751+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.751+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.771+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.771+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.771+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765822
05-26 22:35:28.771+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.771+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.796+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.796+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.796+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765845
05-26 22:35:28.796+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.796+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.816+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.816+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.816+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765868
05-26 22:35:28.816+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.816+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.831+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.831+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.831+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765882
05-26 22:35:28.831+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.831+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.861+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.861+0900 I/efl-extension(12725): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:28.861+0900 I/efl-extension(12725): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 3765912
05-26 22:35:28.861+0900 E/TIMER   (12725): (ad->timer) -> _rotary_cb() return
05-26 22:35:28.861+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:35:29.306+0900 E/EFL     (12725): evas_main<12725> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3766355 button=1 downs=1
05-26 22:35:29.351+0900 E/EFL     (12725): evas_main<12725> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3766399 button=1 downs=0
05-26 22:35:29.351+0900 I/efl-extension(12725): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:35:29.351+0900 I/efl-extension(12725): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c066d8, elm_layout, func : 0x40003869
05-26 22:35:29.351+0900 I/efl-extension(12725): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:35:29.351+0900 I/efl-extension(12725): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:35:29.351+0900 I/efl-extension(12725): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:35:29.351+0900 I/efl-extension(12725): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:35:29.351+0900 I/efl-extension(12725): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:35:29.351+0900 I/efl-extension(12725): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:35:29.351+0900 E/EFL     (12725): ecore<12725> ecore.c:574 _ecore_magic_fail() 
05-26 22:35:29.351+0900 E/EFL     (12725): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:35:29.351+0900 E/EFL     (12725): *** IN FUNCTION: ecore_timer_del()
05-26 22:35:29.351+0900 E/EFL     (12725): ecore<12725> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:35:29.351+0900 E/EFL     (12725):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:35:29.351+0900 E/EFL     (12725):     Supplied: e5933114 - <UNKNOWN>
05-26 22:35:29.351+0900 E/EFL     (12725): ecore<12725> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:35:29.351+0900 E/EFL     (12725): *** SPANK SPANK SPANK!!!
05-26 22:35:29.351+0900 E/EFL     (12725): *** Now go fix your code. Tut tut tut!
05-26 22:35:29.351+0900 E/EFL     (12725): ecore<12725> ecore.c:574 _ecore_magic_fail() 
05-26 22:35:29.351+0900 E/EFL     (12725): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:35:29.351+0900 E/EFL     (12725): *** IN FUNCTION: ecore_timer_del()
05-26 22:35:29.351+0900 E/EFL     (12725): ecore<12725> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:35:29.351+0900 E/EFL     (12725):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:35:29.351+0900 E/EFL     (12725):     Supplied: 403e8280 - <UNKNOWN>
05-26 22:35:29.351+0900 E/EFL     (12725): ecore<12725> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:35:29.351+0900 E/EFL     (12725): *** SPANK SPANK SPANK!!!
05-26 22:35:29.351+0900 E/EFL     (12725): *** Now go fix your code. Tut tut tut!
05-26 22:35:29.691+0900 W/CRASH_MANAGER(12810): worker.c: worker_job(1199) > 1112725706831146426972
