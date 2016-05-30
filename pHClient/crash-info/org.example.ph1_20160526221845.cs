S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 9815
Date: 2016-05-26 22:18:45+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9815, uid 5000)

Register Information
r0   = 0x303d5849, r1   = 0x00000025
r2   = 0xbec4c204, r3   = 0x303d5849
r4   = 0xfbad8001, r5   = 0xbec4c204
r6   = 0xbec4bcd0, r7   = 0x4049e000
r8   = 0x00000000, r9   = 0x42e9bbdc
r10  = 0x303d5849, fp   = 0xbec4bcc4
ip   = 0x400dea1c, sp   = 0xbec4b750
lr   = 0x403b5f5c, pc   = 0x403f0638
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     17276 KB
Buffers:     30412 KB
Cached:     165252 KB
VmPeak:     112968 KB
VmSize:     105988 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23620 KB
VmRSS:       23620 KB
VmData:      44784 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       55364 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 9815 TID = 9815
9815 9819 9820 9824 

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
43758000 4375b000 rwxp [stack:9820]
4375b000 4375f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43766000 43767000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43767000 4376b000 rwxs /dev/mali
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
43778000 43f77000 rwxp [stack:9819]
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
453d8000 453db000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
453e2000 453e3000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
453e3000 453e4000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
453eb000 453ec000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
453ec000 453f0000 rwxs /dev/mali
453f0000 453f4000 rwxs /dev/mali
453f4000 453f8000 rwxs /dev/mali
453f8000 453ff000 r-xs /usr/lib/gconv/gconv-modules.cache
45500000 45540000 rwxs /dev/mali
45540000 45580000 rwxs /dev/mali
45580000 455a4000 rwxs /dev/mali
455a4000 455c8000 rwxs /dev/mali
455c8000 455cc000 rwxs /dev/mali
455cc000 455f0000 rwxs /dev/mali
455f0000 45600000 rwxs /dev/mali
45600000 45608000 rwxs /dev/mali
45608000 45693000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
45694000 45f93000 rwxp [stack:9824]
45f93000 45fd3000 rwxs /dev/mali
45fd3000 45fd4000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
45fdb000 45fdc000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
45fdc000 46068000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
46068000 460f0000 rwxs /dev/mali
460f0000 46100000 rwxs /dev/mali
46100000 46110000 rwxs /dev/mali
46110000 46134000 rwxs /dev/mali
46134000 46135000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4613c000 4613d000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4613d000 46145000 rwxs /dev/mali
46148000 46158000 rwxs /dev/mali
46158000 46159000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
46160000 46161000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
46161000 46165000 rwxs /dev/mali
46266000 4637a000 rwxs /dev/mali
4637a000 4638a000 rwxs /dev/mali
4638a000 4638e000 rwxs /dev/mali
4638f000 46396000 r-xp /usr/lib/libfeedback.so.0.1.4
4639e000 4639f000 rwxp /usr/lib/libfeedback.so.0.1.4
4639f000 463a1000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
463a8000 463a9000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
463a9000 463b3000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
463ba000 463bb000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
463bb000 463c2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
463c9000 463ca000 rwxp /usr/lib/libmmfcommon.so.0.0.0
463ca000 463e0000 r-xp /usr/lib/libmmfsound.so.0.1.0
463e8000 463e9000 rwxp /usr/lib/libmmfsound.so.0.1.0
463f2000 463f7000 r-xp /usr/lib/libmmfsession.so.0.0.0
463fe000 463ff000 rwxp /usr/lib/libmmfsession.so.0.0.0
463ff000 46409000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
46411000 46412000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
46415000 46419000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
46421000 46422000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
46422000 46438000 r-xp /usr/lib/libavsysaudio.so.0.0.1
46440000 46441000 rwxp /usr/lib/libavsysaudio.so.0.0.1
46441000 46446000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
4644d000 4644e000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
4644e000 46451000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46458000 46459000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46459000 4645c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
46463000 46464000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
46464000 46471000 r-xp /usr/lib/libail.so.0.1.0
46479000 4647a000 rwxp /usr/lib/libail.so.0.1.0
4647a000 4647d000 r-xp /usr/lib/libcompress.so.0.2.0
46484000 46485000 rwxp /usr/lib/libcompress.so.0.2.0
4648a000 464ca000 rwxs /dev/mali
464ca000 464f6000 rwxs /dev/mali
46600000 46624000 rwxs /dev/mali
46624000 4662c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
46633000 46634000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
4663b000 46640000 r-xp /usr/lib/libjson.so.0.0.1
46647000 46648000 rwxp /usr/lib/libjson.so.0.0.1
46648000 46658000 rwxs /dev/mali
46658000 4665c000 r-xp /usr/lib/libogg.so.0.7.1
46663000 46664000 rwxp /usr/lib/libogg.so.0.7.1
46664000 46674000 rwxs /dev/mali
4667c000 4668c000 rwxs /dev/mali
4668c000 466ed000 r-xp /usr/lib/libasound.so.2.0.0
466f4000 466f7000 rwxp /usr/lib/libasound.so.2.0.0
466f7000 4672f000 r-xp /usr/lib/libpulse.so.0.16.2
4672f000 46730000 rwxp /usr/lib/libpulse.so.0.16.2
46730000 46740000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
46740000 46744000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
46761000 467a9000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
467a9000 467aa000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
467aa000 467ed000 r-xp /usr/lib/libsndfile.so.1.0.25
467f4000 467f6000 rwxp /usr/lib/libsndfile.so.1.0.25
467fa000 4681c000 r-xp /usr/lib/libvorbis.so.0.4.3
46823000 46824000 rwxp /usr/lib/libvorbis.so.0.4.3
46824000 46834000 rwxs /dev/mali
46834000 46844000 rwxs /dev/mali
46844000 468cc000 rwxs /dev/mali
468cc000 468dc000 rwxs /dev/mali
468dc000 468ec000 rwxs /dev/mali
468ec000 46910000 rwxs /dev/mali
46910000 46998000 rwxs /dev/mali
46998000 469a8000 rwxs /dev/mali
469a8000 469cc000 rwxs /dev/mali
46a14000 46a24000 rwxs /dev/mali
46a24000 46a5e000 r-xs /opt/usr/apps/org.example.ph1/res/edje/timer.edj
46a5e000 46ae6000 rwxs /dev/mali
bec2c000 bec4d000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9815)
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
8:36.746+0900 E/EFL     (  797): evas_main<797> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2753750 button=1 downs=1
05-26 22:18:36.746+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:18:36.746+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:18:36.746+0900 E/EFL     (  797): evas_main<797> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 22:18:36.761+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:18:36.761+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(190) ev->cur.canvas.y(74)
05-26 22:18:36.761+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:18:36.771+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), block(2)
05-26 22:18:36.771+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), ev->cur.canvas.x(198) ev->cur.canvas.y(81)
05-26 22:18:36.771+0900 E/EFL     (  737): elementary<737> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c20), hold(0) freeze(0)
05-26 22:18:36.776+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2753826 button=1 downs=0
05-26 22:18:36.791+0900 E/EFL     (  797): evas_main<797> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2753829 button=1 downs=0
05-26 22:18:36.796+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:18:36.796+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 797
05-26 22:18:36.796+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:18:36.806+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 737
05-26 22:18:36.811+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESET State: RUNNING
05-26 22:18:36.811+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 22:18:36.811+0900 W/W_HOME  (  737): main.c: _app_control(1726) > Service value : launch_apps
05-26 22:18:36.811+0900 W/W_HOME  (  737): move.c: move_move_to_apps(216) > move to apps
05-26 22:18:36.811+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47740530
05-26 22:18:36.811+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47740530, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:18:36.811+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(737), cmd(0)
05-26 22:18:36.811+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:18:36.811+0900 W/W_HOME  (  737): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-26 22:18:36.811+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:18:36.811+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:18:36.826+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-26 22:18:36.826+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-26 22:18:36.826+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-26 22:18:36.826+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:18:36.831+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:18:36.831+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:18:36.831+0900 W/W_HOME  (  737): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
05-26 22:18:36.831+0900 W/W_HOME  (  737): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-26 22:18:36.831+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-26 22:18:36.831+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:18:37.046+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:37.046+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:18:37.046+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [true][0m
05-26 22:18:37.051+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:18:37.056+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 737
05-26 22:18:37.061+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT][0m
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:18:37.061+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:37.066+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1120]   [MUSIC_PLAYER_EVENT][0m
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:18:37.066+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:37.066+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 22:18:37.066+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 22:18:37.071+0900 W/W_HOME  (  737): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 22:18:37.071+0900 E/W_HOME  (  737): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:18:37.071+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:37.096+0900 W/W_HOME  (  737): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-26 22:18:37.096+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:18:37.096+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47740530
05-26 22:18:37.096+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:18:37.096+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47740530, elm_layout, func : 0x4004b469
05-26 22:18:37.096+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:18:37.096+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:18:37.096+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:18:37.096+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47740530, activated : 1
05-26 22:18:37.096+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:18:37.096+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:18:37.096+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:18:37.096+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-26 22:18:37.101+0900 W/W_HOME  (  737): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-26 22:18:37.101+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:37.101+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:37.101+0900 W/W_HOME  (  737): main.c: home_pause(751) > clock/widget paused
05-26 22:18:37.101+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:37.101+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 22:18:37.101+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 22:18:37.101+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 22:18:37.101+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:18:37.101+0900 W/W_HOME  (  737): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-26 22:18:37.101+0900 W/W_HOME  (  737): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-26 22:18:37.101+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-26 22:18:37.101+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-26 22:18:37.101+0900 E/APPS    (  737): apps_main.c: apps_main_resume(621) >  resumed already
05-26 22:18:37.106+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:18:37.106+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:18:37.106+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:18:37.106+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:18:37.281+0900 W/W_HOME  (  737): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-26 22:18:37.361+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-26 22:18:37.396+0900 E/EFL     (  737): evas_main<737> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2754412 button=1 downs=1
05-26 22:18:37.401+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [159, 179]
05-26 22:18:37.431+0900 E/EFL     (  737): evas_main<737> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2754448 button=1 downs=0
05-26 22:18:37.431+0900 W/APPS    (  737): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [159, 179]->[167, 183]
05-26 22:18:37.431+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,19]
05-26 22:18:37.431+0900 E/APPS    (  737): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-26 22:18:37.431+0900 W/APPS    (  737): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-26 22:18:37.441+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:18:37.441+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 737
05-26 22:18:37.441+0900 I/AUL_AMD (  496): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-26 22:18:37.451+0900 W/AUL_AMD (  496): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 9815
05-26 22:18:37.451+0900 I/APP_CORE( 9815): appcore-efl.c: __do_app(429) > [APP 9815] Event: RESET State: PAUSED
05-26 22:18:37.451+0900 I/CAPI_APPFW_APPLICATION( 9815): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-26 22:18:37.451+0900 I/APP_CORE( 9815): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-26 22:18:37.451+0900 I/APP_CORE( 9815): appcore-efl.c: __do_app(481) > [APP 9815] App already running, raise the window
05-26 22:18:37.451+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(9815), cmd(0)
05-26 22:18:37.456+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:18:37.461+0900 E/E17     (  381): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-26 22:18:37.466+0900 I/APP_CORE( 9815): appcore-efl.c: __do_app(485) > [APP 9815] Call the resume_cb
05-26 22:18:37.466+0900 I/CAPI_APPFW_APPLICATION( 9815): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-26 22:18:37.491+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 22:18:37.491+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:37.491+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:37.491+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:37.491+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 22:18:37.501+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 22:18:37.501+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:18:37.506+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 22:18:37.541+0900 I/APP_CORE( 9815): appcore-efl.c: __do_app(429) > [APP 9815] Event: RESUME State: RUNNING
05-26 22:18:37.561+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(1)
05-26 22:18:37.561+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 22:18:37.561+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:37.561+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 22:18:37.561+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 22:18:37.561+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:18:37.561+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 22:18:37.561+0900 W/W_HOME  (  737): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 22:18:37.561+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:37.561+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:37.561+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 22:18:37.561+0900 W/W_HOME  (  737): rotary.c: rotary_deattach(156) > rotary_deattach:0x47911dc0
05-26 22:18:37.561+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:18:37.561+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47911dc0, elm_layout, func : 0x4004b469
05-26 22:18:37.561+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:18:37.561+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:18:37.561+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:18:37.561+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c961a0, elm_box, _activated_obj : 0x47911dc0, activated : 1
05-26 22:18:37.561+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 22:18:37.561+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:18:37.561+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:18:37.566+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:18:37.566+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:18:37.566+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 22:18:37.571+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:18:37.571+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 22:18:37.626+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 22:18:37.626+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:18:37.636+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 22:18:37.811+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:18:37.811+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-26 22:18:37.846+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 22:18:37.916+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:18:38.071+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:18:38.236+0900 E/EFL     ( 9815): evas_main<9815> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2755284 button=1 downs=1
05-26 22:18:38.286+0900 E/EFL     ( 9815): evas_main<9815> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2755338 button=1 downs=0
05-26 22:18:38.976+0900 E/EFL     ( 9815): evas_main<9815> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2756019 button=1 downs=1
05-26 22:18:39.046+0900 E/EFL     ( 9815): evas_main<9815> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2756096 button=1 downs=0
05-26 22:18:39.366+0900 I/CAPI_NETWORK_CONNECTION( 9815): connection.c: connection_create(372) > New handle created[0x454675b0]
05-26 22:18:39.396+0900 I/SOCKETTEST( 9815): IP : 
05-26 22:18:39.396+0900 I/SOCKETTEST( 9815): Success to create UDP socket
05-26 22:18:39.396+0900 I/SOCKETTEST( 9815): Bind Success
05-26 22:18:39.396+0900 I/SOCKETTEST( 9815): Waiting DATA...
05-26 22:18:41.336+0900 I/SOCKETTEST( 9815): Receive Data : 192.168.0.47
05-26 22:18:41.336+0900 I/SOCKETTEST( 9815): Changed IP : 192.168.0.47
05-26 22:18:41.411+0900 I/SOCKETTEST( 9815): Success to create socket
05-26 22:18:41.421+0900 I/SOCKETTEST( 9815): Success to socket connection
05-26 22:18:41.421+0900 I/SOCKETTEST( 9815): write() 성공
05-26 22:18:42.571+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:18:42.806+0900 E/EFL     ( 9815): evas_main<9815> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2759853 button=1 downs=1
05-26 22:18:42.866+0900 E/EFL     ( 9815): evas_main<9815> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2759915 button=1 downs=0
05-26 22:18:42.916+0900 D/TIMER   ( 9815): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:18:42.916+0900 D/TIMER   ( 9815): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:18:42.976+0900 I/efl-extension( 9815): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:18:42.976+0900 I/efl-extension( 9815): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:18:42.976+0900 I/efl-extension( 9815): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:18:42.981+0900 I/efl-extension( 9815): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:18:42.981+0900 I/efl-extension( 9815): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45404cb8, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:18:44.161+0900 E/EFL     ( 9815): evas_main<9815> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2761211 button=1 downs=1
05-26 22:18:44.216+0900 E/EFL     ( 9815): evas_main<9815> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2761266 button=1 downs=0
05-26 22:18:44.851+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:44.856+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:44.861+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:44.861+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2761902
05-26 22:18:44.861+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:44.926+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:44.926+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:44.926+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:44.926+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2761974
05-26 22:18:44.926+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:44.981+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:44.981+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:44.981+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762029
05-26 22:18:44.981+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:44.981+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.026+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.026+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.026+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762077
05-26 22:18:45.026+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.026+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.081+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.081+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.081+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762132
05-26 22:18:45.081+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.081+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.121+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.121+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.121+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762169
05-26 22:18:45.121+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.121+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.151+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.151+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.151+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762199
05-26 22:18:45.151+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.151+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.176+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.176+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.176+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762224
05-26 22:18:45.176+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.176+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.191+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.191+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.191+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762242
05-26 22:18:45.191+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.191+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.226+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.231+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.231+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762278
05-26 22:18:45.231+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.231+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.261+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.261+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.261+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762309
05-26 22:18:45.261+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.261+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.291+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.291+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.291+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762342
05-26 22:18:45.291+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.291+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.326+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.326+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.326+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762376
05-26 22:18:45.326+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.326+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.366+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.366+0900 I/efl-extension( 9815): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.366+0900 I/efl-extension( 9815): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45404cb8, elm_layout, time_stamp : 2762415
05-26 22:18:45.366+0900 E/TIMER   ( 9815): (ad->timer) -> _rotary_cb() return
05-26 22:18:45.366+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:18:45.666+0900 E/EFL     ( 9815): evas_main<9815> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2762713 button=1 downs=1
05-26 22:18:45.736+0900 E/EFL     ( 9815): evas_main<9815> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2762787 button=1 downs=0
05-26 22:18:45.741+0900 I/efl-extension( 9815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:18:45.741+0900 I/efl-extension( 9815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45404cb8, elm_layout, func : 0x400038d9
05-26 22:18:45.741+0900 I/efl-extension( 9815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:18:45.741+0900 I/efl-extension( 9815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:18:45.741+0900 I/efl-extension( 9815): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:18:45.741+0900 I/efl-extension( 9815): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:18:45.741+0900 I/efl-extension( 9815): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:18:45.741+0900 I/efl-extension( 9815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:18:45.741+0900 E/EFL     ( 9815): ecore<9815> ecore.c:574 _ecore_magic_fail() 
05-26 22:18:45.741+0900 E/EFL     ( 9815): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:18:45.741+0900 E/EFL     ( 9815): *** IN FUNCTION: ecore_timer_del()
05-26 22:18:45.741+0900 E/EFL     ( 9815): ecore<9815> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:18:45.741+0900 E/EFL     ( 9815):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:18:45.741+0900 E/EFL     ( 9815):     Supplied: e5933114 - <UNKNOWN>
05-26 22:18:45.741+0900 E/EFL     ( 9815): ecore<9815> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:18:45.741+0900 E/EFL     ( 9815): *** SPANK SPANK SPANK!!!
05-26 22:18:45.741+0900 E/EFL     ( 9815): *** Now go fix your code. Tut tut tut!
05-26 22:18:45.741+0900 E/EFL     ( 9815): ecore<9815> ecore.c:574 _ecore_magic_fail() 
05-26 22:18:45.741+0900 E/EFL     ( 9815): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:18:45.741+0900 E/EFL     ( 9815): *** IN FUNCTION: ecore_timer_del()
05-26 22:18:45.741+0900 E/EFL     ( 9815): ecore<9815> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:18:45.741+0900 E/EFL     ( 9815):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:18:45.741+0900 E/EFL     ( 9815):     Supplied: 403e8280 - <UNKNOWN>
05-26 22:18:45.741+0900 E/EFL     ( 9815): ecore<9815> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:18:45.741+0900 E/EFL     ( 9815): *** SPANK SPANK SPANK!!!
05-26 22:18:45.741+0900 E/EFL     ( 9815): *** Now go fix your code. Tut tut tut!
05-26 22:18:45.741+0900 I/SOCKETTEST( 9815): Success to create socket
05-26 22:18:45.756+0900 I/SOCKETTEST( 9815): Success to socket connection
05-26 22:18:45.756+0900 I/SOCKETTEST( 9815): write() 성공
05-26 22:18:46.126+0900 W/CRASH_MANAGER( 9884): worker.c: worker_job(1199) > 1109815706831146426872
