S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 14266
Date: 2016-05-26 22:43:37+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4049f250, r3   = 0x00000000
r4   = 0x45f8b9e8, r5   = 0x00000000
r6   = 0x45f8c2e8, r7   = 0x00000000
r8   = 0x45f8c2e8, r9   = 0x45f8ac68
r10  = 0x44052370, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbee89638
lr   = 0x403e81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     14856 KB
Buffers:     36724 KB
Cached:     156380 KB
VmPeak:     111348 KB
VmSize:      99228 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21784 KB
VmRSS:       21784 KB
VmData:      43592 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 14266 TID = 14266
14266 14273 14277 14476 

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
43758000 4376c000 rwxp [stack:14273]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44b82000 44b85000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b85000 44b89000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b89000 44b98000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44bf8000 44bff000 r-xs /usr/lib/gconv/gconv-modules.cache
44d01000 45500000 rwxp [stack:14476]
45694000 45f93000 rwxp [stack:14277]
46773000 46776000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4677d000 4677e000 rwxp /usr/lib/libpulse-simple.so.0.0.4
467e9000 46821000 r-xp /usr/lib/libpulse.so.0.16.2
46821000 46822000 rwxp /usr/lib/libpulse.so.0.16.2
46896000 4689b000 r-xp /usr/lib/libjson.so.0.0.1
468a2000 468a3000 rwxp /usr/lib/libjson.so.0.0.1
468a3000 468eb000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
468eb000 468ec000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
468ec000 4692f000 r-xp /usr/lib/libsndfile.so.1.0.25
46936000 46938000 rwxp /usr/lib/libsndfile.so.1.0.25
4693c000 4695e000 r-xp /usr/lib/libvorbis.so.0.4.3
46965000 46966000 rwxp /usr/lib/libvorbis.so.0.4.3
46966000 4696a000 r-xp /usr/lib/libogg.so.0.7.1
46971000 46972000 rwxp /usr/lib/libogg.so.0.7.1
bee69000 bee8a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:14266)
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
nc : 0x40003821
05-26 22:43:05.096+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:43:05.096+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:43:05.096+0900 I/efl-extension(14266): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:43:05.096+0900 I/efl-extension(14266): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:43:05.096+0900 I/efl-extension(14266): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:43:05.096+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:43:05.096+0900 E/EFL     (14266): ecore<14266> ecore.c:574 _ecore_magic_fail() 
05-26 22:43:05.096+0900 E/EFL     (14266): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:43:05.096+0900 E/EFL     (14266): *** IN FUNCTION: ecore_timer_del()
05-26 22:43:05.096+0900 E/EFL     (14266): ecore<14266> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:43:05.096+0900 E/EFL     (14266):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:43:05.096+0900 E/EFL     (14266):     Supplied: e5933114 - <UNKNOWN>
05-26 22:43:05.096+0900 E/EFL     (14266): ecore<14266> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:43:05.096+0900 E/EFL     (14266): *** SPANK SPANK SPANK!!!
05-26 22:43:05.096+0900 E/EFL     (14266): *** Now go fix your code. Tut tut tut!
05-26 22:43:05.096+0900 E/EFL     (14266): ecore<14266> ecore.c:574 _ecore_magic_fail() 
05-26 22:43:05.096+0900 E/EFL     (14266): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:43:05.096+0900 E/EFL     (14266): *** IN FUNCTION: ecore_timer_del()
05-26 22:43:05.096+0900 E/EFL     (14266): ecore<14266> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:43:05.096+0900 E/EFL     (14266):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:43:05.096+0900 E/EFL     (14266):     Supplied: 403e8280 - <UNKNOWN>
05-26 22:43:05.096+0900 E/EFL     (14266): ecore<14266> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:43:05.096+0900 E/EFL     (14266): *** SPANK SPANK SPANK!!!
05-26 22:43:05.096+0900 E/EFL     (14266): *** Now go fix your code. Tut tut tut!
05-26 22:43:05.096+0900 I/SOCKETTEST(14266): Success to create socket
05-26 22:43:05.146+0900 I/SOCKETTEST(14266): Success to socket connection
05-26 22:43:05.146+0900 I/SOCKETTEST(14266): write() 성공
05-26 22:43:05.146+0900 I/TimeRecord(14266): time : 809326665
05-26 22:43:05.636+0900 I/efl-extension(14266): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c055c0
05-26 22:43:05.636+0900 I/efl-extension(14266): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c055c0, obj: 0x44c055c0
05-26 22:43:05.636+0900 I/efl-extension(14266): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 22:43:05.951+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4222999 button=1 downs=1
05-26 22:43:06.021+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4223070 button=1 downs=0
05-26 22:43:06.021+0900 D/TIMER   (14266): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:43:06.021+0900 D/TIMER   (14266): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:43:06.031+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:43:06.031+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c05740, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:43:08.031+0900 W/MUSIC_TRANSFER(14173): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:14173]   uwLocalAgentId : [22277], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-26 22:43:08.031+0900 W/MUSIC_TRANSFER(14173): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:14173]   wStatusCode error : [1]!!![0m
05-26 22:43:15.151+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4232201 button=1 downs=1
05-26 22:43:15.221+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4232272 button=1 downs=0
05-26 22:43:15.836+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.836+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.836+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.841+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4232885
05-26 22:43:15.901+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.901+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.901+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.901+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4232951
05-26 22:43:15.946+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.946+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.946+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.946+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4232996
05-26 22:43:15.986+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.986+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.991+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:15.991+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4233037
05-26 22:43:16.026+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:16.026+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4233073
05-26 22:43:16.026+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:16.031+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:16.111+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:16.111+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:16.111+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4233159
05-26 22:43:16.116+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:16.591+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:16.591+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:16.596+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:16.596+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4233642
05-26 22:43:17.196+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:17.196+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:17.196+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:17.196+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4234244
05-26 22:43:17.306+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:17.306+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:17.306+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4234356
05-26 22:43:17.311+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:18.121+0900 W/MUSIC_TRANSFER(14173): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:14173]   uwLocalAgentId : [22277], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-26 22:43:18.121+0900 W/MUSIC_TRANSFER(14173): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:14173]   wStatusCode error : [1]!!![0m
05-26 22:43:18.326+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:18.326+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:18.326+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4235373
05-26 22:43:18.326+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:18.381+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:18.381+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:18.386+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:18.386+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4235431
05-26 22:43:18.451+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:18.451+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:18.451+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:43:18.451+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4235500
05-26 22:43:18.746+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:18.746+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:18.746+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4235797
05-26 22:43:18.751+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:18.846+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:18.851+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:18.851+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:18.851+0900 I/efl-extension(14266): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c05740, elm_layout, time_stamp : 4235898
05-26 22:43:19.406+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4236451 button=1 downs=1
05-26 22:43:19.471+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4236521 button=1 downs=0
05-26 22:43:19.471+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:43:19.476+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c05740, elm_layout, func : 0x40003821
05-26 22:43:19.476+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:43:19.476+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:43:19.476+0900 I/efl-extension(14266): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:43:19.476+0900 I/efl-extension(14266): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:43:19.476+0900 I/efl-extension(14266): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:43:19.476+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:43:19.476+0900 D/TIMER   (14266): Setting time is 480
05-26 22:43:19.571+0900 I/SOCKETTEST(14266): Success to create socket
05-26 22:43:19.571+0900 I/SOCKETTEST(14266): Success to socket connection
05-26 22:43:19.571+0900 I/SOCKETTEST(14266): write() 성공
05-26 22:43:19.616+0900 I/SENSOR  (14266): -0.350000, -12.670000, 7.000000
05-26 22:43:19.716+0900 I/SENSOR  (14266): 1.820000, 0.490000, 6.720000
05-26 22:43:19.821+0900 I/SENSOR  (14266): 2.030000, 0.490000, 4.200000
05-26 22:43:19.916+0900 I/SENSOR  (14266): 3.710000, -0.070000, 5.040000
05-26 22:43:20.026+0900 I/SENSOR  (14266): 4.130000, -0.910000, 6.370000
05-26 22:43:20.121+0900 I/SENSOR  (14266): 3.920000, -1.190000, 5.180000
05-26 22:43:20.221+0900 I/SENSOR  (14266): 3.640000, -1.260000, 5.110000
05-26 22:43:20.326+0900 I/SENSOR  (14266): 2.660000, -1.400000, 3.150000
05-26 22:43:20.426+0900 I/SENSOR  (14266): 9.660000, -2.310000, 4.200000
05-26 22:43:20.531+0900 I/SENSOR  (14266): -14.210000, -2.660000, 14.420000
05-26 22:43:20.536+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4237579 button=1 downs=1
05-26 22:43:20.616+0900 I/SENSOR  (14266): 2.590000, -0.350000, -0.910000
05-26 22:43:20.621+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4237670 button=1 downs=0
05-26 22:43:20.716+0900 I/SENSOR  (14266): 1.820000, -1.050000, 5.950000
05-26 22:43:20.816+0900 I/SENSOR  (14266): 1.820000, -1.120000, 4.340000
05-26 22:43:20.926+0900 I/SENSOR  (14266): 1.890000, -0.420000, 3.360000
05-26 22:43:21.031+0900 I/SENSOR  (14266): 3.010000, -1.190000, 5.040000
05-26 22:43:21.121+0900 I/SENSOR  (14266): 3.080000, -0.630000, 4.410000
05-26 22:43:21.226+0900 I/SENSOR  (14266): 3.010000, -1.190000, 4.550000
05-26 22:43:21.321+0900 I/SENSOR  (14266): 3.150000, -1.120000, 4.550000
05-26 22:43:21.421+0900 I/SENSOR  (14266): 3.080000, -0.910000, 4.410000
05-26 22:43:21.521+0900 I/SENSOR  (14266): 3.290000, -0.910000, 4.480000
05-26 22:43:21.646+0900 I/SENSOR  (14266): 3.290000, -1.050000, 4.690000
05-26 22:43:21.721+0900 I/SENSOR  (14266): 2.870000, -1.330000, 3.570000
05-26 22:43:21.826+0900 I/SENSOR  (14266): 2.660000, -0.700000, 4.620000
05-26 22:43:21.931+0900 I/SENSOR  (14266): 3.850000, -0.070000, 7.070000
05-26 22:43:22.021+0900 I/SENSOR  (14266): 3.570000, -0.980000, 4.130000
05-26 22:43:22.116+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4239161 button=1 downs=1
05-26 22:43:22.116+0900 I/SENSOR  (14266): 4.690000, -0.630000, 3.850000
05-26 22:43:22.191+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4239241 button=1 downs=0
05-26 22:43:22.191+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:43:22.191+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c05740, elm_layout, func : 0x40003821
05-26 22:43:22.191+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:43:22.211+0900 I/SOCKETTEST(14266): Success to create socket
05-26 22:43:22.226+0900 I/SOCKETTEST(14266): Success to socket connection
05-26 22:43:22.226+0900 I/SOCKETTEST(14266): write() 성공
05-26 22:43:22.226+0900 I/TimeRecord(14266): time : 2
05-26 22:43:22.736+0900 I/efl-extension(14266): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c05740
05-26 22:43:22.736+0900 I/efl-extension(14266): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c05740, obj: 0x44c05740
05-26 22:43:22.736+0900 I/efl-extension(14266): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 22:43:25.276+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4242326 button=1 downs=1
05-26 22:43:25.341+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4242389 button=1 downs=0
05-26 22:43:25.341+0900 D/TIMER   (14266): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:43:25.341+0900 D/TIMER   (14266): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:43:25.351+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:43:25.351+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c05a40, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:43:26.281+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4243327 button=1 downs=1
05-26 22:43:26.346+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4243393 button=1 downs=0
05-26 22:43:26.846+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:26.846+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:26.851+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:26.916+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:26.916+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:26.921+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:26.921+0900 I/SOCKETTEST(14266): Success to create socket
05-26 22:43:26.976+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:26.976+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:26.981+0900 I/SOCKETTEST(14266): Success to socket connection
05-26 22:43:26.981+0900 I/SOCKETTEST(14266): write() 성공
05-26 22:43:26.981+0900 I/ROTARTY (14266): 앞으로
05-26 22:43:26.981+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.026+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.026+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.026+0900 I/SOCKETTEST(14266): Success to create socket
05-26 22:43:27.026+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.056+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.056+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.086+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.086+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.086+0900 I/SOCKETTEST(14266): Success to socket connection
05-26 22:43:27.091+0900 I/SOCKETTEST(14266): write() 성공
05-26 22:43:27.091+0900 I/ROTARTY (14266): 앞으로
05-26 22:43:27.091+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.091+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.091+0900 I/SOCKETTEST(14266): Success to create socket
05-26 22:43:27.116+0900 I/SOCKETTEST(14266): Success to socket connection
05-26 22:43:27.116+0900 I/SOCKETTEST(14266): write() 성공
05-26 22:43:27.116+0900 I/ROTARTY (14266): 앞으로
05-26 22:43:27.121+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.121+0900 I/efl-extension(14266): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.121+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:43:27.756+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4244803 button=1 downs=1
05-26 22:43:27.816+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4244864 button=1 downs=0
05-26 22:43:27.816+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:43:27.816+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c05a40, elm_layout, func : 0x40003821
05-26 22:43:27.816+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:43:27.816+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:43:27.816+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:43:27.816+0900 D/TIMER   (14266): Setting time is 0
05-26 22:43:27.816+0900 E/TIMER   (14266): (!ad->setting_time) -> _start_clicked_cb() return
05-26 22:43:28.211+0900 W/MUSIC_TRANSFER(14173): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:14173]   uwLocalAgentId : [22277], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-26 22:43:28.211+0900 W/MUSIC_TRANSFER(14173): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:14173]   wStatusCode error : [1]!!![0m
05-26 22:43:28.756+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4245800 button=1 downs=1
05-26 22:43:28.841+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4245890 button=1 downs=0
05-26 22:43:28.841+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:43:28.841+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c05a40, elm_layout, func : 0x40003821
05-26 22:43:28.841+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:43:28.841+0900 D/TIMER   (14266): Setting time is 0
05-26 22:43:28.841+0900 E/TIMER   (14266): (!ad->setting_time) -> _start_clicked_cb() return
05-26 22:43:29.396+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4246443 button=1 downs=1
05-26 22:43:29.471+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4246523 button=1 downs=0
05-26 22:43:29.476+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:43:29.476+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c05a40, elm_layout, func : 0x40003821
05-26 22:43:29.476+0900 I/efl-extension(14266): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:43:29.476+0900 D/TIMER   (14266): Setting time is 0
05-26 22:43:29.476+0900 E/TIMER   (14266): (!ad->setting_time) -> _start_clicked_cb() return
05-26 22:43:32.121+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4249167 button=1 downs=1
05-26 22:43:32.166+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4249214 button=1 downs=0
05-26 22:43:32.496+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4249546 button=1 downs=1
05-26 22:43:32.576+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4249627 button=1 downs=0
05-26 22:43:33.041+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4250089 button=1 downs=1
05-26 22:43:33.181+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4250230 button=1 downs=0
05-26 22:43:33.311+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4250358 button=1 downs=1
05-26 22:43:33.361+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4250410 button=1 downs=0
05-26 22:43:33.856+0900 E/EFL     (14266): evas_main<14266> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4250903 button=1 downs=1
05-26 22:43:33.941+0900 E/EFL     (14266): evas_main<14266> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4250990 button=1 downs=0
05-26 22:43:34.331+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-26 22:43:34.331+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-26 22:43:34.331+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-26 22:43:34.331+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-26 22:43:34.461+0900 W/STARTER (  709): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-26 22:43:34.551+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-26 22:43:34.551+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-26 22:43:34.571+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-26 22:43:34.586+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-26 22:43:34.681+0900 W/STARTER (  709): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-26 22:43:34.941+0900 W/STARTER (  709): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-26 22:43:34.961+0900 W/STARTER (  709): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-26 22:43:35.006+0900 E/STARTER (  709): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-26 22:43:35.006+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 22:43:35.021+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 709
05-26 22:43:35.031+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 22:43:35.031+0900 W/AUL_PAD ( 1155): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 22:43:35.031+0900 W/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 22:43:35.041+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 22:43:35.051+0900 I/CAPI_APPFW_APPLICATION(14158): app_main.c: app_efl_main(129) > app_efl_main
05-26 22:43:35.056+0900 I/CAPI_APPFW_APPLICATION(14158): app_main.c: app_appcore_create(152) > app_appcore_create
05-26 22:43:35.136+0900 E/AUL     (  709): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:43:35.136+0900 E/RESOURCED(  497): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-26 22:43:35.231+0900 I/efl-extension(14158): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445d8bd8 = w: 0 h: 0  obj 0x445be358 w: 360 h: 360
05-26 22:43:35.231+0900 I/efl-extension(14158): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-26 22:43:35.236+0900 I/efl-extension(14158): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:43:35.236+0900 I/efl-extension(14158): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:43:35.236+0900 I/efl-extension(14158): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:43:35.236+0900 I/efl-extension(14158): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:43:35.241+0900 I/efl-extension(14158): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445be358, elm_image, _activated_obj : 0x0, activated : 1
05-26 22:43:35.336+0900 E/W_TASKMANAGER(14158): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-26 22:43:35.341+0900 E/W_TASKMANAGER(14158): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-26 22:43:35.341+0900 E/W_TASKMANAGER(14158): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-26 22:43:35.386+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.386+0900 E/W_TASKMANAGER(14158): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 22:43:35.391+0900 E/RUA     (14158): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 17, ncols : 5
05-26 22:43:35.426+0900 E/EFL     (14158): elementary<14158> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445bffd8 into part 'elm.swallow.event.0'
05-26 22:43:35.471+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04000003)
05-26 22:43:35.476+0900 I/APP_CORE(14158): appcore-efl.c: __do_app(429) > [APP 14158] Event: RESET State: CREATED
05-26 22:43:35.476+0900 I/CAPI_APPFW_APPLICATION(14158): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 22:43:35.496+0900 I/APP_CORE(14158): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 22:43:35.496+0900 I/APP_CORE(14158): appcore-efl.c: __do_app(474) > [APP 14158] Initial Launching, call the resume_cb
05-26 22:43:35.501+0900 I/CAPI_APPFW_APPLICATION(14158): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 22:43:35.531+0900 E/E17     (  381): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04000003)
05-26 22:43:35.541+0900 W/APP_CORE(14158): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000003
05-26 22:43:35.611+0900 I/APP_CORE(14266): appcore-efl.c: __do_app(429) > [APP 14266] Event: PAUSE State: RUNNING
05-26 22:43:35.611+0900 I/CAPI_APPFW_APPLICATION(14266): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-26 22:43:35.611+0900 I/APP_CORE(14158): appcore-efl.c: __do_app(429) > [APP 14158] Event: RESUME State: RUNNING
05-26 22:43:35.641+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:43:35.641+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 22:43:36.021+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:43:36.061+0900 I/MALI    (14158): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-26 22:43:36.266+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:43:36.271+0900 E/EFL     (14158): evas_main<14158> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4253315 button=1 downs=1
05-26 22:43:36.281+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14158
05-26 22:43:36.286+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:43:36.301+0900 E/EFL     (14158): evas_main<14158> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4253340 button=1 downs=0
05-26 22:43:36.586+0900 E/EFL     (14158): elementary<14158> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44572fb8), freeze(1)
05-26 22:43:36.586+0900 E/EFL     (14158): elementary<14158> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44572fb8), freeze(1)
05-26 22:43:36.716+0900 I/efl-extension(14533): efl_extension.c: eext_mod_init(40) > Init
05-26 22:43:36.761+0900 I/UXT     (14533): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 22:43:36.866+0900 I/AUL_PAD (14533): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 22:43:36.911+0900 E/TBM     (14533): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 22:43:36.961+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:43:36.971+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14266
05-26 22:43:36.971+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 27
05-26 22:43:36.976+0900 I/APP_CORE(14266): appcore-efl.c: __do_app(429) > [APP 14266] Event: TERMINATE State: PAUSED
05-26 22:43:36.986+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 22:43:36.986+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 22:43:37.011+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 22:43:37.011+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 22:43:37.016+0900 E/APP_CORE(14158): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-26 22:43:37.016+0900 I/APP_CORE(14158): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 22:43:37.016+0900 I/APP_CORE(14158): appcore-efl.c: __after_loop(1090) > [APP 14158] PAUSE before termination
05-26 22:43:37.016+0900 I/CAPI_APPFW_APPLICATION(14158): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:43:37.016+0900 I/CAPI_APPFW_APPLICATION(14158): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-26 22:43:37.016+0900 I/efl-extension(14158): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44572fb8, obj: 0x44572fb8
05-26 22:43:37.016+0900 I/efl-extension(14158): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:43:37.016+0900 I/efl-extension(14158): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:43:37.016+0900 I/efl-extension(14158): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:43:37.016+0900 I/efl-extension(14158): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 22:43:37.021+0900 I/efl-extension(14158): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445be358
05-26 22:43:37.026+0900 I/efl-extension(14158): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-26 22:43:37.026+0900 I/efl-extension(14158): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445d8bd8 is freed
05-26 22:43:37.026+0900 I/efl-extension(14158): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:43:37.026+0900 I/efl-extension(14158): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44572fb8, elm_scroller, func : 0x437c8ef1
05-26 22:43:37.031+0900 I/efl-extension(14158): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:43:37.031+0900 I/efl-extension(14158): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:43:37.031+0900 I/efl-extension(14158): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445be358, elm_image, func : 0x437c8ef1
05-26 22:43:37.031+0900 I/efl-extension(14158): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:43:37.031+0900 I/efl-extension(14158): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44572fb8 : elm_scroller] rotary callabck is deleted
05-26 22:43:37.071+0900 I/APP_CORE(14266): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 22:43:37.071+0900 I/CAPI_APPFW_APPLICATION(14266): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 22:43:37.111+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 22:43:37.121+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 22:43:37.121+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:43:37.121+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:43:37.121+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 22:43:37.121+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 22:43:37.121+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:43:37.121+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 22:43:37.121+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:43:37.121+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:43:37.121+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 22:43:37.131+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:43:37.116+0900 I/efl-extension(14266): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c05a40
05-26 22:43:37.131+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 22:43:37.131+0900 I/efl-extension(14266): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c05a40, obj: 0x44c05a40
05-26 22:43:37.131+0900 I/efl-extension(14266): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 22:43:37.161+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(0)
05-26 22:43:37.161+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 22:43:37.161+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:43:37.161+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(0)
05-26 22:43:37.161+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESUME State: PAUSED
05-26 22:43:37.161+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 22:43:37.161+0900 W/W_HOME  (  737): main.c: _appcore_resume_cb(681) > appcore resume
05-26 22:43:37.161+0900 W/W_HOME  (  737): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 22:43:37.161+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:43:37.161+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:43:37.161+0900 W/W_HOME  (  737): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
05-26 22:43:37.161+0900 W/W_HOME  (  737): main.c: home_resume(733) > clock/widget resumed
05-26 22:43:37.161+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:43:37.161+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 22:43:37.161+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:43:37.161+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 22:43:37.161+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4469) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-26 22:43:37.176+0900 W/WATCH_CORE(  778): appcore-watch.c: __widget_resume(1012) > widget_resume
05-26 22:43:37.176+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppResume(721) > 
05-26 22:43:37.186+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:43:37.186+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:43:37.201+0900 I/MALI    (14158): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-26 22:43:37.216+0900 I/MALI    (14266): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 22:43:37.216+0900 I/MALI    (14266): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=14266   close drm_fd=25 
05-26 22:43:37.216+0900 I/MALI    (14266): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 22:43:37.231+0900 I/MALI    (14158): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 22:43:37.231+0900 I/MALI    (14158): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=14158   close drm_fd=21 
05-26 22:43:37.231+0900 I/MALI    (14158): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 22:43:37.326+0900 I/UXT     (14158): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 22:43:37.351+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:43:37.351+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:43:37.351+0900 I/UXT     (14266): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 22:43:37.521+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:43:37.521+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:43:37.591+0900 I/efl-extension(14158): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-26 22:43:37.641+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 22:43:37.696+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:43:37.696+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:43:37.781+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 14158
05-26 22:43:37.876+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:43:37.876+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:43:37.931+0900 W/CRASH_MANAGER(14539): worker.c: worker_job(1199) > 1114266706831146427021
