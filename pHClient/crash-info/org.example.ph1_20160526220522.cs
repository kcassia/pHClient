S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 8228
Date: 2016-05-26 22:05:22+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4049f250, r3   = 0x00000000
r4   = 0x456d4c18, r5   = 0x00000000
r6   = 0x456d5518, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x456d3e98
r10  = 0x44050518, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbefe6638
lr   = 0x403e81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     15536 KB
Buffers:     28176 KB
Cached:     167948 KB
VmPeak:     109024 KB
VmSize:      98196 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20260 KB
VmRSS:       20164 KB
VmData:      42560 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8228 TID = 8228
8228 8231 8234 8314 

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
43758000 4376c000 rwxp [stack:8231]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44383000 44b82000 rwxp [stack:8314]
45382000 45385000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
45385000 45389000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
45389000 45398000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
453f8000 453ff000 r-xs /usr/lib/gconv/gconv-modules.cache
45794000 45f93000 rwxp [stack:8234]
46332000 46335000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4633c000 4633d000 rwxp /usr/lib/libpulse-simple.so.0.0.4
463d7000 4640f000 r-xp /usr/lib/libpulse.so.0.16.2
4640f000 46410000 rwxp /usr/lib/libpulse.so.0.16.2
46410000 46415000 r-xp /usr/lib/libjson.so.0.0.1
4641c000 4641d000 rwxp /usr/lib/libjson.so.0.0.1
46439000 4643d000 r-xp /usr/lib/libogg.so.0.7.1
46444000 46445000 rwxp /usr/lib/libogg.so.0.7.1
4652e000 46576000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46576000 46577000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46577000 465ba000 r-xp /usr/lib/libsndfile.so.1.0.25
465c1000 465c3000 rwxp /usr/lib/libsndfile.so.1.0.25
465c7000 465e9000 r-xp /usr/lib/libvorbis.so.0.4.3
465f0000 465f1000 rwxp /usr/lib/libvorbis.so.0.4.3
befc6000 befe7000 rwxp [stack]
End of Maps Information

Callstack Information (PID:8228)
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
1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:04:47.776+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:04:47.776+0900 W/W_HOME  (  737): main.c: home_pause(751) > clock/widget paused
05-26 22:04:47.776+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:04:47.776+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:04:47.776+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:04:47.776+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:04:47.776+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 22:04:47.776+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 22:04:47.776+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:04:47.776+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:04:47.776+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:04:47.781+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:04:47.781+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 22:04:47.786+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 22:04:47.786+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 22:04:47.786+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 22:04:47.786+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 22:04:47.786+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 22:04:47.786+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 22:04:47.786+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 22:04:47.786+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 22:04:47.786+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 22:04:47.786+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 22:04:47.791+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(1)
05-26 22:04:47.791+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: PAUSE State: RUNNING
05-26 22:04:47.791+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 22:04:47.791+0900 W/W_HOME  (  737): main.c: _appcore_pause_cb(690) > appcore pause
05-26 22:04:47.791+0900 E/W_HOME  (  737): main.c: _pause_cb(668) > paused already
05-26 22:04:47.796+0900 I/APP_CORE( 8228): appcore-efl.c: __do_app(429) > [APP 8228] Event: RESUME State: RUNNING
05-26 22:04:47.801+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 22:04:47.801+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 22:04:47.876+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 22:04:47.876+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:04:47.906+0900 W/W_HOME  (  737): noti_broker.c: _handler_indicator_hide(552) > 
05-26 22:04:47.906+0900 W/W_HOME  (  737): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-26 22:04:48.076+0900 I/AUL_PAD ( 8235): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 22:04:48.176+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 22:04:48.216+0900 I/MALI    ( 8228): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42f5f028] swap changed from async to sync
05-26 22:04:48.291+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:04:48.666+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:04:48.666+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:04:48.741+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:04:48.741+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 22:04:49.471+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1926518 button=1 downs=1
05-26 22:04:49.526+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1926576 button=1 downs=0
05-26 22:04:50.136+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1927181 button=1 downs=1
05-26 22:04:50.246+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1927298 button=1 downs=0
05-26 22:04:50.476+0900 I/CAPI_NETWORK_CONNECTION( 8228): connection.c: connection_create(372) > New handle created[0x454161e0]
05-26 22:04:50.491+0900 I/SOCKETTEST( 8228): IP : 
05-26 22:04:50.491+0900 I/SOCKETTEST( 8228): Success to create UDP socket
05-26 22:04:50.491+0900 I/SOCKETTEST( 8228): Bind Success
05-26 22:04:50.491+0900 I/SOCKETTEST( 8228): Waiting DATA...
05-26 22:04:52.796+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 22:04:53.401+0900 I/SOCKETTEST( 8228): Receive Data : 192.168.0.47
05-26 22:04:53.401+0900 I/SOCKETTEST( 8228): Changed IP : 192.168.0.47
05-26 22:04:53.481+0900 I/SOCKETTEST( 8228): Success to create socket
05-26 22:04:53.516+0900 I/SOCKETTEST( 8228): Success to socket connection
05-26 22:04:53.521+0900 I/SOCKETTEST( 8228): write() 성공
05-26 22:04:54.846+0900 E/GESTURE (  143): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=54   flick_area=55 ---> SET value to 1
05-26 22:04:54.846+0900 E/GESTURE (  143): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
05-26 22:04:54.846+0900 E/GESTURE (  143): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=54   flick_area=55 ---> SET value to 1
05-26 22:04:54.911+0900 E/GESTURE (  143): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
05-26 22:04:54.911+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1931899 button=1 downs=1
05-26 22:04:54.911+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1931959 button=1 downs=0
05-26 22:04:54.961+0900 D/TIMER   ( 8228): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:04:54.961+0900 D/TIMER   ( 8228): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:04:55.016+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:04:55.016+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 22:04:55.016+0900 I/efl-extension( 8228): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 22:04:55.021+0900 I/efl-extension( 8228): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 22:04:55.021+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44303bf0, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:04:55.671+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1932720 button=1 downs=1
05-26 22:04:55.731+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1932780 button=1 downs=0
05-26 22:04:56.956+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1934008 button=1 downs=1
05-26 22:04:56.991+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1934040 button=1 downs=0
05-26 22:04:57.516+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.516+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.516+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.516+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303bf0, elm_layout, time_stamp : 1934564
05-26 22:04:57.516+0900 E/TIMER   ( 8228): (ad->timer) -> _rotary_cb() return
05-26 22:04:57.576+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.576+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.576+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303bf0, elm_layout, time_stamp : 1934625
05-26 22:04:57.576+0900 E/TIMER   ( 8228): (ad->timer) -> _rotary_cb() return
05-26 22:04:57.576+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.606+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.606+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.606+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303bf0, elm_layout, time_stamp : 1934653
05-26 22:04:57.606+0900 E/TIMER   ( 8228): (ad->timer) -> _rotary_cb() return
05-26 22:04:57.606+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.626+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.626+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.626+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303bf0, elm_layout, time_stamp : 1934677
05-26 22:04:57.626+0900 E/TIMER   ( 8228): (ad->timer) -> _rotary_cb() return
05-26 22:04:57.626+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.661+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.661+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.661+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303bf0, elm_layout, time_stamp : 1934711
05-26 22:04:57.661+0900 E/TIMER   ( 8228): (ad->timer) -> _rotary_cb() return
05-26 22:04:57.661+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.716+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.716+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:57.716+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303bf0, elm_layout, time_stamp : 1934765
05-26 22:04:57.716+0900 E/TIMER   ( 8228): (ad->timer) -> _rotary_cb() return
05-26 22:04:57.716+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:04:58.046+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1935094 button=1 downs=1
05-26 22:04:58.126+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1935174 button=1 downs=0
05-26 22:04:58.746+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1935792 button=1 downs=1
05-26 22:04:58.811+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1935858 button=1 downs=0
05-26 22:04:59.086+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1936132 button=1 downs=1
05-26 22:04:59.151+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1936202 button=1 downs=0
05-26 22:04:59.151+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:04:59.156+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44303bf0, elm_layout, func : 0x400038e1
05-26 22:04:59.156+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:04:59.156+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:04:59.156+0900 I/efl-extension( 8228): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:04:59.156+0900 I/efl-extension( 8228): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:04:59.156+0900 I/efl-extension( 8228): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:04:59.156+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:04:59.156+0900 E/EFL     ( 8228): ecore<8228> ecore.c:574 _ecore_magic_fail() 
05-26 22:04:59.156+0900 E/EFL     ( 8228): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:04:59.156+0900 E/EFL     ( 8228): *** IN FUNCTION: ecore_timer_del()
05-26 22:04:59.156+0900 E/EFL     ( 8228): ecore<8228> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:04:59.156+0900 E/EFL     ( 8228):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:04:59.156+0900 E/EFL     ( 8228):     Supplied: e5933114 - <UNKNOWN>
05-26 22:04:59.156+0900 E/EFL     ( 8228): ecore<8228> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:04:59.156+0900 E/EFL     ( 8228): *** SPANK SPANK SPANK!!!
05-26 22:04:59.156+0900 E/EFL     ( 8228): *** Now go fix your code. Tut tut tut!
05-26 22:04:59.161+0900 E/EFL     ( 8228): ecore<8228> ecore.c:574 _ecore_magic_fail() 
05-26 22:04:59.161+0900 E/EFL     ( 8228): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 22:04:59.161+0900 E/EFL     ( 8228): *** IN FUNCTION: ecore_timer_del()
05-26 22:04:59.161+0900 E/EFL     ( 8228): ecore<8228> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 22:04:59.161+0900 E/EFL     ( 8228):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 22:04:59.161+0900 E/EFL     ( 8228):     Supplied: 403e8280 - <UNKNOWN>
05-26 22:04:59.161+0900 E/EFL     ( 8228): ecore<8228> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 22:04:59.161+0900 E/EFL     ( 8228): *** SPANK SPANK SPANK!!!
05-26 22:04:59.161+0900 E/EFL     ( 8228): *** Now go fix your code. Tut tut tut!
05-26 22:04:59.161+0900 I/SOCKETTEST( 8228): Success to create socket
05-26 22:04:59.211+0900 I/SOCKETTEST( 8228): Success to socket connection
05-26 22:04:59.211+0900 I/SOCKETTEST( 8228): write() 성공
05-26 22:04:59.661+0900 I/efl-extension( 8228): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44303bf0
05-26 22:04:59.661+0900 I/efl-extension( 8228): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44303bf0, obj: 0x44303bf0
05-26 22:04:59.666+0900 I/efl-extension( 8228): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 22:04:59.691+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 22:04:59.691+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 22:04:59.691+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : pedometer_inactive_period error
05-26 22:04:59.696+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 22:04:59.696+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 22:04:59.696+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_10min_precaution_millisec error
05-26 22:04:59.696+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 22:04:59.696+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 22:04:59.696+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_before_10min_precaution_millisec error
05-26 22:05:00.056+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1937103 button=1 downs=1
05-26 22:05:00.131+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1937182 button=1 downs=0
05-26 22:05:00.136+0900 D/TIMER   ( 8228): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 22:05:00.136+0900 D/TIMER   ( 8228): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 22:05:00.146+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 22:05:00.146+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44303d70, elm_layout, _activated_obj : 0x0, activated : 1
05-26 22:05:00.796+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1937841 button=1 downs=1
05-26 22:05:00.861+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1937912 button=1 downs=0
05-26 22:05:01.436+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.436+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.441+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.441+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1938487
05-26 22:05:01.486+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.486+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.486+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.486+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1938534
05-26 22:05:01.526+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.526+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.526+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1938577
05-26 22:05:01.531+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.561+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.561+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.566+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1938613
05-26 22:05:01.566+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.606+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.606+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.606+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1938655
05-26 22:05:01.606+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.676+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.676+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:01.676+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1938727
05-26 22:05:01.676+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.096+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.096+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.096+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1939144
05-26 22:05:02.101+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.156+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.156+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.156+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.156+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1939203
05-26 22:05:02.216+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.216+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.216+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.216+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1939265
05-26 22:05:02.266+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.266+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.271+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.271+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1939317
05-26 22:05:02.326+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.326+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.326+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1939374
05-26 22:05:02.326+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.401+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.401+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.401+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.401+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1939449
05-26 22:05:02.481+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.481+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.481+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.481+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1939529
05-26 22:05:02.546+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.546+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.546+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1939593
05-26 22:05:02.546+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.601+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.601+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.606+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.606+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1939652
05-26 22:05:02.686+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.686+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.686+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.686+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1939735
05-26 22:05:02.951+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.951+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.951+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:02.951+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1940000
05-26 22:05:03.236+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:03.236+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:03.236+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1940283
05-26 22:05:03.236+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:03.411+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:03.411+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:03.411+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1940458
05-26 22:05:03.411+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:03.886+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:03.891+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:03.891+0900 I/efl-extension( 8228): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 22:05:03.891+0900 I/efl-extension( 8228): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44303d70, elm_layout, time_stamp : 1940938
05-26 22:05:04.271+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1941320 button=1 downs=1
05-26 22:05:04.316+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1941366 button=1 downs=0
05-26 22:05:04.316+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:05:04.316+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44303d70, elm_layout, func : 0x400038e1
05-26 22:05:04.316+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 22:05:04.316+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 22:05:04.316+0900 I/efl-extension( 8228): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:05:04.316+0900 I/efl-extension( 8228): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:05:04.316+0900 I/efl-extension( 8228): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:05:04.316+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:05:04.316+0900 D/TIMER   ( 8228): Setting time is 1200
05-26 22:05:04.406+0900 I/SOCKETTEST( 8228): Success to create socket
05-26 22:05:04.426+0900 I/SOCKETTEST( 8228): Success to socket connection
05-26 22:05:04.426+0900 I/SOCKETTEST( 8228): write() 성공
05-26 22:05:04.491+0900 I/SENSOR  ( 8228): -7.840000, 9.450000, 11.410000
05-26 22:05:04.596+0900 I/SENSOR  ( 8228): -17.570000, 7.490000, 13.580000
05-26 22:05:04.696+0900 I/SENSOR  ( 8228): -19.320000, 14.420000, 16.870001
05-26 22:05:04.796+0900 I/SENSOR  ( 8228): -13.020000, 0.770000, 10.850000
05-26 22:05:04.901+0900 I/SENSOR  ( 8228): -2.940000, -1.400000, 3.290000
05-26 22:05:04.921+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 22:05:04.936+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 22:05:04.996+0900 I/SENSOR  ( 8228): 4.270000, -5.180000, -1.890000
05-26 22:05:05.101+0900 I/SENSOR  ( 8228): 2.450000, -5.320000, -1.890000
05-26 22:05:05.201+0900 I/SENSOR  ( 8228): -10.710000, 8.400000, 9.100000
05-26 22:05:05.301+0900 I/SENSOR  ( 8228): -17.150000, 17.780001, 14.350000
05-26 22:05:05.401+0900 I/SENSOR  ( 8228): -3.780000, -8.890000, 3.360000
05-26 22:05:05.496+0900 I/SENSOR  ( 8228): -6.370000, 3.290000, 4.130000
05-26 22:05:05.596+0900 I/SENSOR  ( 8228): -7.910000, 10.710000, 5.740000
05-26 22:05:05.701+0900 I/SENSOR  ( 8228): -4.760000, 7.490000, 7.070000
05-26 22:05:05.801+0900 I/SENSOR  ( 8228): -5.670000, 4.130000, 8.470000
05-26 22:05:05.901+0900 I/SENSOR  ( 8228): -4.130000, -16.240000, 7.280000
05-26 22:05:06.006+0900 I/SENSOR  ( 8228): 12.250000, -19.740000, -14.490000
05-26 22:05:06.101+0900 I/SENSOR  ( 8228): 7.000000, -26.600000, 2.520000
05-26 22:05:06.201+0900 I/SENSOR  ( 8228): -4.900000, 17.710001, 0.070000
05-26 22:05:06.306+0900 I/SENSOR  ( 8228): 17.500000, -19.250000, 5.740000
05-26 22:05:06.401+0900 I/SENSOR  ( 8228): 43.540001, -75.809998, -36.820000
05-26 22:05:06.496+0900 I/SENSOR  ( 8228): 1.400000, -20.370001, -10.360000
05-26 22:05:06.601+0900 I/SENSOR  ( 8228): -9.520000, -9.310000, 2.030000
05-26 22:05:06.706+0900 I/SENSOR  ( 8228): -1.750000, 3.710000, 5.460000
05-26 22:05:06.801+0900 I/SENSOR  ( 8228): -11.060000, 22.049999, 13.020000
05-26 22:05:06.901+0900 I/SENSOR  ( 8228): -38.080002, 30.100000, 45.220001
05-26 22:05:07.006+0900 I/SENSOR  ( 8228): -24.570000, 10.080000, 27.510000
05-26 22:05:07.101+0900 I/SENSOR  ( 8228): -13.300000, 25.200001, 24.150000
05-26 22:05:07.196+0900 I/SENSOR  ( 8228): -16.940001, 4.410000, 27.510000
05-26 22:05:07.301+0900 I/SENSOR  ( 8228): -16.450001, 2.520000, 33.389999
05-26 22:05:07.406+0900 I/SENSOR  ( 8228): -4.410000, -9.520000, 9.520000
05-26 22:05:07.501+0900 I/SENSOR  ( 8228): -11.690000, -7.630000, -3.640000
05-26 22:05:07.601+0900 I/SENSOR  ( 8228): -8.330000, -53.689999, -23.520000
05-26 22:05:07.711+0900 I/SENSOR  ( 8228): 22.049999, -43.400002, -35.349998
05-26 22:05:07.801+0900 I/SENSOR  ( 8228): -33.459999, -49.980000, -32.970001
05-26 22:05:07.901+0900 I/SENSOR  ( 8228): 10.710000, -25.690001, -9.170000
05-26 22:05:08.001+0900 I/SENSOR  ( 8228): 25.760000, -0.770000, -2.870000
05-26 22:05:08.106+0900 I/SENSOR  ( 8228): 92.540001, 65.239998, 4.340000
05-26 22:05:08.201+0900 I/SENSOR  ( 8228): 80.220001, 51.029999, 16.309999
05-26 22:05:08.306+0900 I/SENSOR  ( 8228): 10.290000, 103.250000, -13.160000
05-26 22:05:08.401+0900 I/SENSOR  ( 8228): 23.730000, 61.810001, 2.940000
05-26 22:05:08.506+0900 I/SENSOR  ( 8228): -1.820000, -12.320000, -13.230000
05-26 22:05:08.601+0900 I/SENSOR  ( 8228): -4.970000, -22.820000, -7.420000
05-26 22:05:08.711+0900 I/SENSOR  ( 8228): -7.280000, -15.190001, -5.250000
05-26 22:05:08.806+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1945857 button=1 downs=1
05-26 22:05:08.811+0900 I/SENSOR  ( 8228): -12.880000, 8.540000, -17.990000
05-26 22:05:08.846+0900 E/EFL     ( 8228): evas_main<8228> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1945897 button=1 downs=0
05-26 22:05:08.846+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 22:05:08.846+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44303d70, elm_layout, func : 0x400038e1
05-26 22:05:08.846+0900 I/efl-extension( 8228): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 22:05:08.846+0900 I/efl-extension( 8228): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 22:05:08.846+0900 I/efl-extension( 8228): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 22:05:08.846+0900 I/efl-extension( 8228): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 22:05:08.866+0900 I/SOCKETTEST( 8228): Success to create socket
05-26 22:05:08.876+0900 I/SOCKETTEST( 8228): Success to socket connection
05-26 22:05:08.876+0900 I/SOCKETTEST( 8228): write() 성공
05-26 22:05:09.386+0900 I/efl-extension( 8228): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44303d70
05-26 22:05:09.386+0900 I/efl-extension( 8228): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44303d70, obj: 0x44303d70
05-26 22:05:09.391+0900 I/efl-extension( 8228): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 22:05:22.286+0900 E/PKGMGR_SERVER( 8376): pkgmgr-server.c: main(2131) > package manager server start
05-26 22:05:22.371+0900 E/PKGMGR_SERVER( 8376): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_1901706207], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[n4xmvrok3LpYKZG33ZPRF7cRhSc=], backend_flag=[0]
05-26 22:05:22.376+0900 E/PKGMGR_SERVER( 8377): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-26 22:05:22.386+0900 E/PKGMGR  ( 8374): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-26 22:05:22.451+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:05:22.461+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8228
05-26 22:05:22.461+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 22:05:22.466+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 5
05-26 22:05:22.471+0900 I/APP_CORE( 8228): appcore-efl.c: __do_app(429) > [APP 8228] Event: TERMINATE State: RUNNING
05-26 22:05:22.471+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 22:05:22.471+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 22:05:22.471+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(8228), cmd(4)
05-26 22:05:22.471+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:05:22.481+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8228
05-26 22:05:22.561+0900 I/APP_CORE( 8228): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 22:05:22.561+0900 I/CAPI_APPFW_APPLICATION( 8228): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 22:05:22.571+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 22:05:22.571+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 22:05:22.586+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:05:22.586+0900 I/MALI    ( 8228): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f5f028] swap changed from sync to async
05-26 22:05:22.591+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8228
05-26 22:05:22.611+0900 I/MALI    ( 8228): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 22:05:22.611+0900 I/MALI    ( 8228): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=8228   close drm_fd=25 
05-26 22:05:22.611+0900 I/MALI    ( 8228): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 22:05:22.646+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 22:05:22.676+0900 I/UXT     ( 8228): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 22:05:22.691+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 22:05:22.691+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 22:05:22.691+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:05:22.691+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:05:22.691+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:05:22.691+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 22:05:22.696+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:05:22.701+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8228
05-26 22:05:22.716+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(0)
05-26 22:05:22.716+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 22:05:22.716+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:05:22.716+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(0)
05-26 22:05:22.716+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESUME State: PAUSED
05-26 22:05:22.716+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 22:05:22.716+0900 W/W_HOME  (  737): main.c: _appcore_resume_cb(681) > appcore resume
05-26 22:05:22.716+0900 W/W_HOME  (  737): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 22:05:22.716+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:05:22.716+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:05:22.716+0900 W/W_HOME  (  737): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
05-26 22:05:22.716+0900 W/W_HOME  (  737): main.c: home_resume(733) > clock/widget resumed
05-26 22:05:22.716+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 22:05:22.716+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 22:05:22.716+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 22:05:22.716+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 22:05:22.721+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 22:05:22.721+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 22:05:22.721+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 22:05:22.721+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 22:05:22.721+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 22:05:22.806+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:05:22.821+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8228
05-26 22:05:22.926+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:05:23.006+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8228
05-26 22:05:23.106+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:05:23.116+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8228
05-26 22:05:23.156+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 29 -> 28 1464267923 121
05-26 22:05:23.156+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 28 1136 328 530
05-26 22:05:23.156+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 28 0 0 674
05-26 22:05:23.156+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 28 991 210 462
05-26 22:05:23.156+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 28 162 5 76
05-26 22:05:23.156+0900 I/RESOURCED(  497): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 28 295 47 138
05-26 22:05:23.176+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 22:05:23.221+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 22:05:23.226+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 22:05:23.236+0900 E/PKGMGR_SERVER( 8377): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-26 22:05:23.256+0900 E/PKGMGR_SERVER( 8376): pkgmgr-server.c: sighandler(409) > child NORMAL exit [8377]
05-26 22:05:23.346+0900 W/CRASH_MANAGER( 8383): worker.c: worker_job(1199) > 1108228706831146426792
