S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 5103
Date: 2016-05-26 21:47:24+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4049f250, r3   = 0x00000000
r4   = 0x4431b558, r5   = 0x00000000
r6   = 0x4431be58, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x4431a7d8
r10  = 0x44050f98, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbef5d638
lr   = 0x403e81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     14704 KB
Buffers:     21396 KB
Cached:     171616 KB
VmPeak:     113556 KB
VmSize:      99228 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21440 KB
VmRSS:       21440 KB
VmData:      43592 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 5103 TID = 5103
5103 5110 5114 5245 

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
43758000 4376c000 rwxp [stack:5110]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44b82000 44b85000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b85000 44b89000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b89000 44b98000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44bf4000 44bfb000 r-xs /usr/lib/gconv/gconv-modules.cache
44d80000 4557f000 rwxp [stack:5245]
45713000 45f12000 rwxp [stack:5114]
46467000 4646a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46471000 46472000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46586000 465be000 r-xp /usr/lib/libpulse.so.0.16.2
465be000 465bf000 rwxp /usr/lib/libpulse.so.0.16.2
4661d000 46622000 r-xp /usr/lib/libjson.so.0.0.1
46629000 4662a000 rwxp /usr/lib/libjson.so.0.0.1
4662a000 46672000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46672000 46673000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46673000 466b6000 r-xp /usr/lib/libsndfile.so.1.0.25
466bd000 466bf000 rwxp /usr/lib/libsndfile.so.1.0.25
466c3000 466e5000 r-xp /usr/lib/libvorbis.so.0.4.3
466ec000 466ed000 rwxp /usr/lib/libvorbis.so.0.4.3
466ed000 466f1000 r-xp /usr/lib/libogg.so.0.7.1
466f8000 466f9000 rwxp /usr/lib/libogg.so.0.7.1
bef3d000 bef5e000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5103)
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
-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:10.096+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4428b3d8, elm_layout, time_stamp : 867144
05-26 21:47:10.096+0900 E/TIMER   ( 5103): (ad->timer) -> _rotary_cb() return
05-26 21:47:10.096+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:10.136+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:10.136+0900 I/efl-extension( 3950): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:10.136+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:10.136+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4428b3d8, elm_layout, time_stamp : 867185
05-26 21:47:10.136+0900 E/TIMER   ( 5103): (ad->timer) -> _rotary_cb() return
05-26 21:47:10.161+0900 E/wnoti-service(  855): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
05-26 21:47:11.071+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-26 21:47:11.071+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_main_popup_timer_cb(2324) > ::UI:: start hiding animation
05-26 21:47:11.381+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_hide_animator_cb(2255) > ::UI:: end hiding animation
05-26 21:47:11.381+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-26 21:47:11.381+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-26 21:47:11.381+0900 W/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (8, 1, 0)
05-26 21:47:11.381+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=0, view_state=0
05-26 21:47:11.386+0900 I/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(903) > ::UI:: it is invalid object.
05-26 21:47:11.386+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [invalid object] is UNLOCK , 0000 <=== ]]]
05-26 21:47:11.386+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-26 21:47:11.386+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 745
05-26 21:47:11.386+0900 I/wnotibp ( 3950): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 0, 0
05-26 21:47:11.396+0900 I/efl-extension( 3950): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45201e98, obj: 0x45201e98
05-26 21:47:11.396+0900 I/efl-extension( 3950): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:47:11.396+0900 I/efl-extension( 3950): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:47:11.401+0900 I/efl-extension( 3950): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:47:11.401+0900 I/efl-extension( 3950): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:47:11.431+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:47:11.431+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45201e98, elm_genlist, func : 0x41a25dfd
05-26 21:47:11.431+0900 I/efl-extension( 3950): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:47:11.441+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:47:11.441+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(998) > ::UI:: lock state = 0000
05-26 21:47:11.446+0900 I/wnotibp ( 3950): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(2024) > ::INFO:: call lower
05-26 21:47:11.496+0900 W/APP_CORE( 3950): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:5600008
05-26 21:47:11.496+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: PAUSE State: RUNNING
05-26 21:47:11.496+0900 I/CAPI_APPFW_APPLICATION( 3950): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 21:47:11.546+0900 I/MALI    ( 5103): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42f5f028] swap changed from async to sync
05-26 21:47:11.581+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-26 21:47:11.581+0900 W/wnotibp ( 3950): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 21:47:11.581+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [0, 0, 3, 0000]
05-26 21:47:11.581+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 0]
05-26 21:47:11.581+0900 W/wnotibp ( 3950): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1371) > [0, 1, 0, 2, 0]
05-26 21:47:11.671+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=868721 button=1 downs=1
05-26 21:47:11.731+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=868783 button=1 downs=0
05-26 21:47:11.731+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:47:11.731+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4428b3d8, elm_layout, func : 0x40003871
05-26 21:47:11.736+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:47:11.736+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:47:11.736+0900 I/efl-extension( 5103): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:47:11.736+0900 I/efl-extension( 5103): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:47:11.736+0900 I/efl-extension( 5103): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:47:11.736+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:47:11.736+0900 E/EFL     ( 5103): ecore<5103> ecore.c:574 _ecore_magic_fail() 
05-26 21:47:11.736+0900 E/EFL     ( 5103): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:47:11.736+0900 E/EFL     ( 5103): *** IN FUNCTION: ecore_timer_del()
05-26 21:47:11.736+0900 E/EFL     ( 5103): ecore<5103> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:47:11.736+0900 E/EFL     ( 5103):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:47:11.736+0900 E/EFL     ( 5103):     Supplied: e5933114 - <UNKNOWN>
05-26 21:47:11.736+0900 E/EFL     ( 5103): ecore<5103> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:47:11.736+0900 E/EFL     ( 5103): *** SPANK SPANK SPANK!!!
05-26 21:47:11.736+0900 E/EFL     ( 5103): *** Now go fix your code. Tut tut tut!
05-26 21:47:11.736+0900 E/EFL     ( 5103): ecore<5103> ecore.c:574 _ecore_magic_fail() 
05-26 21:47:11.736+0900 E/EFL     ( 5103): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:47:11.736+0900 E/EFL     ( 5103): *** IN FUNCTION: ecore_timer_del()
05-26 21:47:11.736+0900 E/EFL     ( 5103): ecore<5103> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:47:11.736+0900 E/EFL     ( 5103):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:47:11.736+0900 E/EFL     ( 5103):     Supplied: 403e8280 - <UNKNOWN>
05-26 21:47:11.736+0900 E/EFL     ( 5103): ecore<5103> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:47:11.736+0900 E/EFL     ( 5103): *** SPANK SPANK SPANK!!!
05-26 21:47:11.736+0900 E/EFL     ( 5103): *** Now go fix your code. Tut tut tut!
05-26 21:47:11.736+0900 I/SOCKETTEST( 5103): Success to create socket
05-26 21:47:11.746+0900 I/SOCKETTEST( 5103): Success to socket connection
05-26 21:47:11.746+0900 I/SOCKETTEST( 5103): write() 성공
05-26 21:47:12.241+0900 I/efl-extension( 5103): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4428b3d8
05-26 21:47:12.241+0900 I/efl-extension( 5103): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4428b3d8, obj: 0x4428b3d8
05-26 21:47:12.241+0900 I/efl-extension( 5103): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:47:12.616+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=869663 button=1 downs=1
05-26 21:47:12.681+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=869732 button=1 downs=0
05-26 21:47:12.686+0900 D/TIMER   ( 5103): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:47:12.686+0900 D/TIMER   ( 5103): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:47:12.696+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:47:12.696+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c12020, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:47:13.376+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=870425 button=1 downs=1
05-26 21:47:13.446+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=870495 button=1 downs=0
05-26 21:47:13.946+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=870994 button=1 downs=1
05-26 21:47:14.011+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=871059 button=1 downs=0
05-26 21:47:14.761+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:14.761+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:14.761+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 871809
05-26 21:47:14.816+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:14.816+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:14.816+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 871863
05-26 21:47:14.861+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:14.861+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:14.861+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 871911
05-26 21:47:14.916+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:14.921+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:14.921+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 871967
05-26 21:47:14.966+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:14.966+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:14.966+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 872014
05-26 21:47:15.026+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:15.026+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:15.026+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 872076
05-26 21:47:16.181+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:16.181+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:16.181+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 873231
05-26 21:47:16.206+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:16.211+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:16.211+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 873256
05-26 21:47:16.581+0900 I/APP_CORE( 3950): appcore-efl.c: __do_app(429) > [APP 3950] Event: MEM_FLUSH State: PAUSED
05-26 21:47:16.611+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:16.611+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:16.611+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 873659
05-26 21:47:17.676+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:17.681+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:17.681+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 874727
05-26 21:47:17.911+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:17.911+0900 I/efl-extension( 5103): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:47:17.911+0900 I/efl-extension( 5103): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c12020, elm_layout, time_stamp : 874961
05-26 21:47:18.576+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=875623 button=1 downs=1
05-26 21:47:18.641+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=875692 button=1 downs=0
05-26 21:47:18.646+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:47:18.646+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c12020, elm_layout, func : 0x40003871
05-26 21:47:18.646+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:47:18.646+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:47:18.646+0900 I/efl-extension( 5103): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:47:18.646+0900 I/efl-extension( 5103): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:47:18.646+0900 I/efl-extension( 5103): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:47:18.646+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:47:18.646+0900 D/TIMER   ( 5103): Setting time is 11
05-26 21:47:18.736+0900 I/SOCKETTEST( 5103): Success to create socket
05-26 21:47:18.741+0900 I/SOCKETTEST( 5103): Success to socket connection
05-26 21:47:18.741+0900 I/SOCKETTEST( 5103): write() 성공
05-26 21:47:18.816+0900 I/SENSOR  ( 5103): -9.940000, 6.860000, 8.890000
05-26 21:47:18.916+0900 I/SENSOR  ( 5103): 0.700000, -2.730000, 14.000000
05-26 21:47:19.041+0900 I/SENSOR  ( 5103): -5.390000, -3.220000, 4.480000
05-26 21:47:19.191+0900 I/SENSOR  ( 5103): -5.390000, -2.380000, 5.390000
05-26 21:47:19.231+0900 I/SENSOR  ( 5103): -3.360000, 2.520000, 5.600000
05-26 21:47:19.366+0900 I/SENSOR  ( 5103): 9.660000, -1.610000, -4.900000
05-26 21:47:19.416+0900 I/SENSOR  ( 5103): 11.550000, -14.560000, -9.100000
05-26 21:47:19.556+0900 I/SENSOR  ( 5103): -3.430000, -3.640000, -2.450000
05-26 21:47:19.616+0900 I/SENSOR  ( 5103): 1.050000, -7.350000, -0.350000
05-26 21:47:19.741+0900 I/SENSOR  ( 5103): -4.550000, -4.620000, 5.600000
05-26 21:47:19.816+0900 I/SENSOR  ( 5103): -2.240000, -3.920000, 5.460000
05-26 21:47:19.926+0900 I/SENSOR  ( 5103): -4.340000, -3.780000, 5.040000
05-26 21:47:20.016+0900 I/SENSOR  ( 5103): -6.370000, -5.320000, 4.830000
05-26 21:47:20.121+0900 I/SENSOR  ( 5103): -2.450000, -4.410000, 5.530000
05-26 21:47:20.286+0900 I/SENSOR  ( 5103): -0.140000, -2.450000, 4.900000
05-26 21:47:20.321+0900 I/SENSOR  ( 5103): -5.390000, -2.030000, 0.770000
05-26 21:47:20.481+0900 I/SENSOR  ( 5103): 5.600000, -14.420000, 5.250000
05-26 21:47:20.521+0900 I/SENSOR  ( 5103): 15.190001, -19.250000, -8.260000
05-26 21:47:20.656+0900 I/SENSOR  ( 5103): 4.830000, -7.630000, -11.690000
05-26 21:47:20.656+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=877700 button=1 downs=1
05-26 21:47:20.691+0900 E/EFL     ( 5103): evas_main<5103> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=877741 button=1 downs=0
05-26 21:47:20.691+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:47:20.691+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c12020, elm_layout, func : 0x40003871
05-26 21:47:20.691+0900 I/efl-extension( 5103): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:47:20.691+0900 I/efl-extension( 5103): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:47:20.691+0900 I/efl-extension( 5103): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:47:20.691+0900 I/efl-extension( 5103): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:47:20.711+0900 I/SOCKETTEST( 5103): Success to create socket
05-26 21:47:20.711+0900 I/SOCKETTEST( 5103): Success to socket connection
05-26 21:47:20.711+0900 I/SOCKETTEST( 5103): write() 성공
05-26 21:47:21.216+0900 I/efl-extension( 5103): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c12020
05-26 21:47:21.216+0900 I/efl-extension( 5103): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c12020, obj: 0x44c12020
05-26 21:47:21.216+0900 I/efl-extension( 5103): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:47:22.006+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-26 21:47:22.006+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-26 21:47:22.006+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-26 21:47:22.006+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-26 21:47:22.101+0900 W/STARTER (  709): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-26 21:47:22.206+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-26 21:47:22.206+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-26 21:47:22.216+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-26 21:47:22.216+0900 W/STARTER (  709): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-26 21:47:22.306+0900 W/STARTER (  709): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-26 21:47:22.571+0900 W/STARTER (  709): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-26 21:47:22.586+0900 W/STARTER (  709): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-26 21:47:22.626+0900 E/STARTER (  709): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-26 21:47:22.626+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 21:47:22.636+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(1702) > caller pid : 709
05-26 21:47:22.646+0900 W/AUL_AMD (  496): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 21:47:22.646+0900 W/AUL_PAD ( 1155): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 21:47:22.646+0900 W/AUL_PAD ( 1155): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 21:47:22.661+0900 E/RESOURCED(  497): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 21:47:22.666+0900 I/CAPI_APPFW_APPLICATION( 4993): app_main.c: app_efl_main(129) > app_efl_main
05-26 21:47:22.671+0900 I/CAPI_APPFW_APPLICATION( 4993): app_main.c: app_appcore_create(152) > app_appcore_create
05-26 21:47:22.751+0900 E/AUL     (  709): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:47:22.751+0900 E/RESOURCED(  497): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-26 21:47:22.846+0900 I/efl-extension( 4993): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445b67e8 = w: 0 h: 0  obj 0x445be8e0 w: 360 h: 360
05-26 21:47:22.846+0900 I/efl-extension( 4993): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-26 21:47:22.846+0900 I/efl-extension( 4993): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:47:22.846+0900 I/efl-extension( 4993): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:47:22.846+0900 I/efl-extension( 4993): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:47:22.851+0900 I/efl-extension( 4993): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:47:22.851+0900 I/efl-extension( 4993): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445be8e0, elm_image, _activated_obj : 0x0, activated : 1
05-26 21:47:22.946+0900 E/W_TASKMANAGER( 4993): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-26 21:47:22.946+0900 E/W_TASKMANAGER( 4993): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-26 21:47:22.946+0900 E/W_TASKMANAGER( 4993): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-26 21:47:22.986+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.986+0900 E/W_TASKMANAGER( 4993): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 21:47:22.991+0900 E/RUA     ( 4993): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 16, ncols : 5
05-26 21:47:23.016+0900 E/EFL     ( 4993): elementary<4993> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c0560 into part 'elm.swallow.event.0'
05-26 21:47:23.051+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04000003)
05-26 21:47:23.056+0900 I/APP_CORE( 4993): appcore-efl.c: __do_app(429) > [APP 4993] Event: RESET State: CREATED
05-26 21:47:23.056+0900 I/CAPI_APPFW_APPLICATION( 4993): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 21:47:23.076+0900 I/APP_CORE( 4993): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 21:47:23.076+0900 I/APP_CORE( 4993): appcore-efl.c: __do_app(474) > [APP 4993] Initial Launching, call the resume_cb
05-26 21:47:23.076+0900 I/CAPI_APPFW_APPLICATION( 4993): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 21:47:23.121+0900 E/E17     (  381): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04000003)
05-26 21:47:23.126+0900 W/APP_CORE( 4993): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000003
05-26 21:47:23.206+0900 I/APP_CORE( 5103): appcore-efl.c: __do_app(429) > [APP 5103] Event: PAUSE State: RUNNING
05-26 21:47:23.206+0900 I/CAPI_APPFW_APPLICATION( 5103): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-26 21:47:23.236+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:47:23.236+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:47:23.251+0900 I/APP_CORE( 4993): appcore-efl.c: __do_app(429) > [APP 4993] Event: RESUME State: RUNNING
05-26 21:47:23.616+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:47:23.626+0900 E/EFL     ( 4993): evas_main<4993> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=880666 button=1 downs=1
05-26 21:47:23.651+0900 I/MALI    ( 4993): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-26 21:47:23.736+0900 E/EFL     ( 4993): evas_main<4993> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=880784 button=1 downs=0
05-26 21:47:23.801+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:47:23.811+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4993
05-26 21:47:23.816+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:47:23.956+0900 E/EFL     ( 4993): elementary<4993> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573520), freeze(1)
05-26 21:47:23.956+0900 E/EFL     ( 4993): elementary<4993> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573520), freeze(1)
05-26 21:47:24.206+0900 I/efl-extension( 5273): efl_extension.c: eext_mod_init(40) > Init
05-26 21:47:24.246+0900 I/UXT     ( 5273): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 21:47:24.326+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:47:24.336+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5103
05-26 21:47:24.336+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 27
05-26 21:47:24.341+0900 I/APP_CORE( 5103): appcore-efl.c: __do_app(429) > [APP 5103] Event: TERMINATE State: PAUSED
05-26 21:47:24.346+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 21:47:24.346+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 21:47:24.356+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 21:47:24.356+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 21:47:24.361+0900 E/APP_CORE( 4993): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-26 21:47:24.361+0900 I/APP_CORE( 4993): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 21:47:24.361+0900 I/APP_CORE( 4993): appcore-efl.c: __after_loop(1090) > [APP 4993] PAUSE before termination
05-26 21:47:24.361+0900 I/CAPI_APPFW_APPLICATION( 4993): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 21:47:24.361+0900 I/CAPI_APPFW_APPLICATION( 4993): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-26 21:47:24.361+0900 I/efl-extension( 4993): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44573520, obj: 0x44573520
05-26 21:47:24.361+0900 I/efl-extension( 4993): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:47:24.361+0900 I/efl-extension( 4993): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:47:24.361+0900 I/efl-extension( 4993): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:47:24.361+0900 I/efl-extension( 4993): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:47:24.371+0900 I/efl-extension( 4993): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445be8e0
05-26 21:47:24.371+0900 I/efl-extension( 4993): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-26 21:47:24.371+0900 I/efl-extension( 4993): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445b67e8 is freed
05-26 21:47:24.371+0900 I/efl-extension( 4993): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:47:24.371+0900 I/efl-extension( 4993): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44573520, elm_scroller, func : 0x437c8ef1
05-26 21:47:24.371+0900 I/efl-extension( 4993): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:47:24.371+0900 I/efl-extension( 4993): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:47:24.376+0900 I/efl-extension( 4993): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445be8e0, elm_image, func : 0x437c8ef1
05-26 21:47:24.376+0900 I/efl-extension( 4993): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:47:24.376+0900 I/efl-extension( 4993): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44573520 : elm_scroller] rotary callabck is deleted
05-26 21:47:24.446+0900 I/APP_CORE( 5103): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 21:47:24.446+0900 I/CAPI_APPFW_APPLICATION( 5103): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 21:47:24.476+0900 I/MALI    ( 5103): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 21:47:24.476+0900 I/MALI    ( 5103): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=5103   close drm_fd=25 
05-26 21:47:24.476+0900 I/MALI    ( 5103): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 21:47:24.481+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 21:47:24.481+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 21:47:24.481+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 21:47:24.481+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 21:47:24.481+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 21:47:24.481+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 21:47:24.511+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:47:24.511+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:47:24.526+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 21:47:24.526+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:47:24.526+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:47:24.526+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:47:24.526+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 21:47:24.526+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(0)
05-26 21:47:24.526+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 21:47:24.526+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:47:24.526+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(0)
05-26 21:47:24.526+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESUME State: PAUSED
05-26 21:47:24.526+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 21:47:24.526+0900 W/W_HOME  (  737): main.c: _appcore_resume_cb(681) > appcore resume
05-26 21:47:24.526+0900 W/W_HOME  (  737): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 21:47:24.526+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:47:24.536+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:47:24.536+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:47:24.536+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:47:24.536+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 21:47:24.536+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 21:47:24.536+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:47:24.551+0900 I/MALI    ( 4993): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-26 21:47:24.551+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 21:47:24.551+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:47:24.551+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1692) > Do the postponed update job.
05-26 21:47:24.561+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:47:24.561+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:47:24.561+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1059) > idler for type: 0
05-26 21:47:24.561+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:47:24.561+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:47:24.561+0900 I/UXT     ( 5103): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 21:47:24.581+0900 I/MALI    ( 4993): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 21:47:24.581+0900 I/MALI    ( 4993): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=4993   close drm_fd=21 
05-26 21:47:24.581+0900 I/MALI    ( 4993): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 21:47:24.606+0900 I/wnoti-proxy(  737): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-26 21:47:24.611+0900 I/wnoti-proxy(  737): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-26 21:47:24.611+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1106) > unread_count: 2
05-26 21:47:24.611+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(626) > category_id: 34, application_id: 218, application_name: 카카오톡, time_stamp: 1464266825, content_id: 0, spannable_string_version: 1
05-26 21:47:24.616+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-26 21:47:24.616+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-26 21:47:24.616+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-26 21:47:24.616+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-26 21:47:24.616+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-26 21:47:24.616+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-26 21:47:24.616+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-26 21:47:24.621+0900 I/AUL_PAD ( 5273): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 21:47:24.626+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-26 21:47:24.626+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-26 21:47:24.626+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-26 21:47:24.626+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-26 21:47:24.626+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-26 21:47:24.626+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  34, 카카오톡.
05-26 21:47:24.626+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 34, application_id: 218, type: 1
05-26 21:47:24.641+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 21:47:24.641+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:47:24.641+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 21:47:24.641+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 21:47:24.641+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-26 21:47:24.641+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 34, application_id: 218, type: 13
05-26 21:47:24.641+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 21:47:24.641+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 21:47:24.641+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 21:47:24.641+0900 E/TIZEN_N_SYSTEM_SETTINGS(  737): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 21:47:24.641+0900 I/wnotib  (  737): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:47:24.651+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1378) > This noti will be removed from panel: 34, 카카오톡.
05-26 21:47:24.651+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 34, application_id: 218, type: 2
05-26 21:47:24.651+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2986) > We don't need to delete the item for second_depth_type: 0.
05-26 21:47:24.661+0900 E/EFL     (  737): elementary<737> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
05-26 21:47:24.661+0900 I/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 34, application_id: 218, type: 12
05-26 21:47:24.661+0900 I/wnotib  (  737): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 21:47:24.666+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1387) > Num categories: 1, num total noti: 2
05-26 21:47:24.666+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(871) > Free noti manager data.
05-26 21:47:24.666+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(876) > Free previous notifications.
05-26 21:47:24.666+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(897) > Free previous categories.
05-26 21:47:24.666+0900 I/wnotib  (  737): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
05-26 21:47:24.666+0900 I/wnotib  (  737): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
05-26 21:47:24.666+0900 I/wnotib  (  737): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
05-26 21:47:24.666+0900 I/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1412) > num_total_panel: 1.
05-26 21:47:24.671+0900 W/W_HOME  (  737): noti_broker.c: _handler_indicator_update(562) > 0x1
05-26 21:47:24.671+0900 I/UXT     ( 4993): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 21:47:24.686+0900 E/TBM     ( 5273): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 21:47:24.716+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1416) > unread_count_for_home: 2
05-26 21:47:24.716+0900 W/W_HOME  (  737): noti_broker.c: _handler_noti_indicator_show(478) > 
05-26 21:47:24.721+0900 W/wnotib  (  737): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-26 21:47:24.906+0900 I/efl-extension( 4993): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-26 21:47:24.981+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 21:47:25.096+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4993
05-26 21:47:25.176+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 23
05-26 21:47:25.176+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 21:47:25.176+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 5103
05-26 21:47:25.176+0900 W/AUL_AMD (  496): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-26 21:47:25.176+0900 E/AUL     ( 5281): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-26 21:47:25.226+0900 W/CRASH_MANAGER( 5279): worker.c: worker_job(1199) > 1105103706831146426684
