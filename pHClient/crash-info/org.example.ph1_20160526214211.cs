S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 3464
Date: 2016-05-26 21:42:11+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4049f250, r3   = 0x00000000
r4   = 0x44342800, r5   = 0x00000000
r6   = 0x44343100, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x44341a80
r10  = 0x44050518, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbe959638
lr   = 0x403e81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     16848 KB
Buffers:     23248 KB
Cached:     183804 KB
VmPeak:     109812 KB
VmSize:      99236 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21552 KB
VmRSS:       21552 KB
VmData:      43600 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3464 TID = 3464
3464 3471 3474 3563 

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
43758000 4376c000 rwxp [stack:3471]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44b82000 44b85000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b85000 44b89000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b89000 44b98000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44d01000 45500000 rwxp [stack:3563]
455fc000 45603000 r-xs /usr/lib/gconv/gconv-modules.cache
45694000 45f93000 rwxp [stack:3474]
46470000 46473000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4647a000 4647b000 rwxp /usr/lib/libpulse-simple.so.0.0.4
466ab000 466e3000 r-xp /usr/lib/libpulse.so.0.16.2
466e3000 466e4000 rwxp /usr/lib/libpulse.so.0.16.2
4672c000 46731000 r-xp /usr/lib/libjson.so.0.0.1
46738000 46739000 rwxp /usr/lib/libjson.so.0.0.1
46739000 46781000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46781000 46782000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46782000 467c5000 r-xp /usr/lib/libsndfile.so.1.0.25
467cc000 467ce000 rwxp /usr/lib/libsndfile.so.1.0.25
467d2000 467f4000 r-xp /usr/lib/libvorbis.so.0.4.3
467fb000 467fc000 rwxp /usr/lib/libvorbis.so.0.4.3
467fc000 46800000 r-xp /usr/lib/libogg.so.0.7.1
46807000 46808000 rwxp /usr/lib/libogg.so.0.7.1
be939000 be95a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3464)
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
900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 21:41:18.901+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:41:18.901+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:41:18.901+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:41:18.901+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 21:41:18.901+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 21:41:18.901+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 21:41:18.906+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 21:41:18.906+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 21:41:18.906+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 21:41:18.906+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 21:41:18.906+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 21:41:18.906+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 21:41:18.906+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 21:41:18.906+0900 I/APP_CORE( 3464): appcore-efl.c: __do_app(429) > [APP 3464] Event: RESUME State: RUNNING
05-26 21:41:18.911+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:41:18.911+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:41:18.911+0900 E/CAPI_APPFW_APP_CONTROL( 1120): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 21:41:18.911+0900 W/MUSIC_CONTROL_SERVICE( 1120): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1120]   [com.samsung.w-home]register msg port [false][0m
05-26 21:41:18.961+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 21:41:18.961+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:41:18.976+0900 W/APPS    (  737): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 21:41:19.126+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:41:19.126+0900 W/AUL_AMD (  496): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-26 21:41:19.271+0900 E/AUL     (  496): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 21:41:19.411+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:41:19.426+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=516392 button=1 downs=1
05-26 21:41:19.426+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=516456 button=1 downs=0
05-26 21:41:20.091+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=517138 button=1 downs=1
05-26 21:41:20.161+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=517211 button=1 downs=0
05-26 21:41:20.446+0900 I/CAPI_NETWORK_CONNECTION( 3464): connection.c: connection_create(372) > New handle created[0x44c75cd8]
05-26 21:41:20.466+0900 I/SOCKETTEST( 3464): IP : 
05-26 21:41:20.466+0900 I/SOCKETTEST( 3464): Success to create UDP socket
05-26 21:41:20.466+0900 I/SOCKETTEST( 3464): Bind Success
05-26 21:41:20.466+0900 I/SOCKETTEST( 3464): Waiting DATA...
05-26 21:41:23.331+0900 I/SOCKETTEST( 3464): Receive Data : 192.168.0.47
05-26 21:41:23.331+0900 I/SOCKETTEST( 3464): Changed IP : 192.168.0.47
05-26 21:41:23.396+0900 I/SOCKETTEST( 3464): Success to create socket
05-26 21:41:23.416+0900 I/SOCKETTEST( 3464): Success to socket connection
05-26 21:41:23.416+0900 I/SOCKETTEST( 3464): write() 성공
05-26 21:41:23.916+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: MEM_FLUSH State: PAUSED
05-26 21:41:24.996+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-26 21:41:25.066+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-26 21:41:25.116+0900 E/RESOURCED(  497): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 1200
05-26 21:41:25.136+0900 E/ALARM_MANAGER( 1200): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.ascsd] : Alarm id [2010493938]
05-26 21:41:25.136+0900 W/SNL_W   ( 1200): <on_alarm_event:642> Awake to sendKeepAlive_Alarm() - begin,  mCurrentIntervalSeconds ( 480 )
05-26 21:41:25.136+0900 W/SNL_W   ( 1200): <on_alarm_event:652> sendKeepAlive_alarmthread detached successfully
05-26 21:41:25.136+0900 W/SNL_W   ( 1200): <on_alarm_event:656> sendKeepAlive_alarmthread - end 
05-26 21:41:25.141+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_expired(1322) > alarm_id[2010493938] is expired.
05-26 21:41:25.141+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(2010493938)
05-26 21:41:25.141+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-26 21:41:25.141+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 26-5-2016, 13:33:04 (UTC).
05-26 21:41:25.141+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-26 21:41:25.141+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-26 21:41:25.146+0900 W/SNL_W   ( 1200): <sendKeepAliveAllGroup:670> sendKeepAliveAllGroup() - begin
05-26 21:41:25.171+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-26 21:41:25.171+0900 W/SNL     ( 1200): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Call()
05-26 21:41:25.171+0900 W/SNL     ( 1200): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Res( 0 )
05-26 21:41:25.171+0900 W/SNL_W   ( 1200): <util_pm_lock:1132> util_pm_lock() LOCK
05-26 21:41:25.191+0900 W/SNL_W   ( 1200): <sendKeepAliveAllGroup:706> releaseWakeLockinTimeThread detached successfully
05-26 21:41:25.191+0900 W/SNL_W   ( 1200): <sendKeepAliveAllGroup:719> 0 sendKeepAliveThread detached successfully
05-26 21:41:25.196+0900 W/SNL_W   ( 1200): <sendKeepAliveThread:863> sendKeepAliveThread() - presSendNotify(1) begin
05-26 21:41:25.196+0900 W/SCSD    ( 1200): <on_presSendNotify:426> sent keepalive (group_id: 3532130a434bf7f1bd119f41) (S:0/F:1/T:1) (msg_id: 1)
05-26 21:41:25.196+0900 W/SCSD    ( 1200): <_keepalive_cb:520> entrance
05-26 21:41:25.196+0900 W/SCSD    ( 1200): <util_dbus_send_keepalive_sent:287> entrance
05-26 21:41:25.201+0900 W/SNL_W   ( 1200): <sendKeepAliveThread:865> sendKeepAliveThread() - presSendNotify(1) end
05-26 21:41:25.201+0900 W/SNL     ( 1200): Scone_Log.cpp: dump(2972) > SNL :: sKA - group( 3532130a434bf7f1bd119f41 ) mtype( 0 ) timeout( 30000 )
05-26 21:41:25.201+0900 W/SNL     ( 1200): Scone_Log.cpp: dump(2972) > SNL :: sKA
05-26 21:41:25.211+0900 W/SNL     ( 1200): Scone_Log.cpp: dump(2972) > SNL :: send_msg - ( 0xfc ), type( 0x01 ), res( 152 ), seq( 1007 )
05-26 21:41:25.211+0900 W/SNL     ( 1200): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Call()
05-26 21:41:25.211+0900 W/SNL     ( 1200): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Res( 0 )
05-26 21:41:25.211+0900 W/SNL_W   ( 1200): <presSendNotify_i:994> presSendNotify_w ( 3532130a434bf7f1bd119f41 ) - begin
05-26 21:41:25.216+0900 W/SNL_W   ( 1200): <presSendNotify_i:1017> presSendNotify_w ( 3532130a434bf7f1bd119f41 ) - end
05-26 21:41:25.216+0900 W/SNL     ( 1200): Scone_Log.cpp: dump(2972) > SNL :: noti_ps_th - Res( )
05-26 21:41:25.276+0900 W/SNL     ( 1200): Scone_Log.cpp: dump(2972) > SNL :: recv_msg(res) - ( 0xfc ), seq( 1007 )
05-26 21:41:25.276+0900 W/SNL     ( 1200): Scone_Log.cpp: dump(2972) > SNL :: sKA - res( 0 )
05-26 21:41:25.276+0900 W/SNL_W   ( 1200): <sendKeepAliveThread:870> sendKeepAliveThread() - group_id ( 3532130a434bf7f1bd119f41 ) sendKeepAliveType ( 0 ), PING_CNT ( 0 ) 
05-26 21:41:25.276+0900 W/SNL_W   ( 1200): <sendKeepAliveThread:879> sendKeepAliveThread() - presSendNotify(0) begin
05-26 21:41:25.276+0900 W/SCSD    ( 1200): <on_presSendNotify:426> sent keepalive (group_id: 3532130a434bf7f1bd119f41) (S:1/F:1/T:2) (msg_id: 0)
05-26 21:41:25.281+0900 W/SCSD    ( 1200): <_keepalive_cb:520> entrance
05-26 21:41:25.281+0900 W/SNL_W   ( 1200): <sendKeepAliveThread:881> sendKeepAliveThread() - presSendNotify(0) end
05-26 21:41:25.296+0900 W/SNL_W   ( 1200): <sendKeepAliveAllGroup:731> sendKeepAliveAllgroup() - groupList.size() : 0(f) + 1(p)
05-26 21:41:25.296+0900 W/SNL_W   ( 1200): <setAlarm:520> setAlarm() - begin 
05-26 21:41:25.296+0900 W/SNL_W   ( 1200): <initAlarm:505> InitAlarm() - begin
05-26 21:41:25.296+0900 W/SNL_W   ( 1200): <initAlarm:511> InitAlarm() success - end
05-26 21:41:25.346+0900 I/AUL     ( 1200): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-26 21:41:25.376+0900 I/AUL     ( 1200): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-26 21:41:25.376+0900 E/ALARM_MANAGER( 1200): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(715), start(26-5-2016, 21:53:20), repeat(0), interval(0), type(-1073741822)
05-26 21:41:25.391+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-26 21:41:25.396+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-26 21:41:25.431+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-26 21:41:25.466+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-26 21:41:25.491+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-26 21:41:25.511+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-26 21:41:25.511+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-26 21:41:25.516+0900 W/ALARM_MANAGER(  492): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-26 21:41:25.531+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-26 21:41:25.551+0900 I/AUL     (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-26 21:41:25.551+0900 E/ALARM_MANAGER(  492): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464267200, Thu May 26 21:53:20 2016
05-26 21:41:25.551+0900 E/ALARM_MANAGER(  492): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 56187481, next duetime: 1464267200
05-26 21:41:25.551+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(56187481)
05-26 21:41:25.551+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464269584), due_time(1464267200)
05-26 21:41:25.556+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-26 21:41:25.556+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 26-5-2016, 12:53:20 (UTC).
05-26 21:41:25.556+0900 E/ALARM_MANAGER(  492): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-26 21:41:25.561+0900 W/SNL_W   ( 1200): <setAlarm:569> setAlarm() - end : mStatus ( 1 ) currentInterval( 720 ) interruptFlag ( 0 ) alarm_id ( 56187481 )
05-26 21:41:25.561+0900 W/SNL_W   ( 1200): <sendKeepAliveAllGroup:750> sendKeepAliveAllGroup() - set last interval ( 480 )
05-26 21:41:25.561+0900 W/SNL_W   ( 1200): <util_pm_unlock:1154> util_pm_unlock() UNLOCK
05-26 21:41:25.576+0900 W/SNL_W   ( 1200): <sendKeepAliveAllGroup:756> sendKeepAliveAllGroup () - WakeLock release
05-26 21:41:25.576+0900 W/SNL_W   ( 1200): <sendKeepAliveAllGroup:768> sendKeepAliveAllGroup() - end Error ( 0 )
05-26 21:41:25.606+0900 W/SNL_W   ( 1200): <releaseWakeLockinTimeThread:813> releaseWakeLockinTimeThread () - WakeLock already released
05-26 21:41:31.206+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=528252 button=1 downs=1
05-26 21:41:31.256+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=528305 button=1 downs=0
05-26 21:41:31.311+0900 D/TIMER   ( 3464): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:41:31.311+0900 D/TIMER   ( 3464): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:41:31.361+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:41:31.361+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 21:41:31.361+0900 I/efl-extension( 3464): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 21:41:31.366+0900 I/efl-extension( 3464): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 21:41:31.366+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c066d8, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:41:32.451+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=529499 button=1 downs=1
05-26 21:41:32.476+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=529523 button=1 downs=0
05-26 21:41:32.971+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:32.971+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:32.971+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 530018
05-26 21:41:32.971+0900 E/TIMER   ( 3464): (ad->timer) -> _rotary_cb() return
05-26 21:41:33.016+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.016+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.016+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 530065
05-26 21:41:33.016+0900 E/TIMER   ( 3464): (ad->timer) -> _rotary_cb() return
05-26 21:41:33.056+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.056+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.056+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 530105
05-26 21:41:33.056+0900 E/TIMER   ( 3464): (ad->timer) -> _rotary_cb() return
05-26 21:41:33.091+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.096+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.096+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 530143
05-26 21:41:33.096+0900 E/TIMER   ( 3464): (ad->timer) -> _rotary_cb() return
05-26 21:41:33.121+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.121+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.121+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 530171
05-26 21:41:33.121+0900 E/TIMER   ( 3464): (ad->timer) -> _rotary_cb() return
05-26 21:41:33.151+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.151+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.151+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 530202
05-26 21:41:33.151+0900 E/TIMER   ( 3464): (ad->timer) -> _rotary_cb() return
05-26 21:41:33.176+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.181+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.181+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 530228
05-26 21:41:33.181+0900 E/TIMER   ( 3464): (ad->timer) -> _rotary_cb() return
05-26 21:41:33.206+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.206+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:33.206+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c066d8, elm_layout, time_stamp : 530258
05-26 21:41:33.206+0900 E/TIMER   ( 3464): (ad->timer) -> _rotary_cb() return
05-26 21:41:34.416+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=531465 button=1 downs=1
05-26 21:41:34.496+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=531546 button=1 downs=0
05-26 21:41:35.426+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=532476 button=1 downs=1
05-26 21:41:35.516+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=532567 button=1 downs=0
05-26 21:41:35.516+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:41:35.516+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c066d8, elm_layout, func : 0x40003871
05-26 21:41:35.516+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:41:35.516+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:41:35.516+0900 I/efl-extension( 3464): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:41:35.516+0900 I/efl-extension( 3464): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:41:35.516+0900 I/efl-extension( 3464): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:41:35.516+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:41:35.516+0900 E/EFL     ( 3464): ecore<3464> ecore.c:574 _ecore_magic_fail() 
05-26 21:41:35.516+0900 E/EFL     ( 3464): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:41:35.516+0900 E/EFL     ( 3464): *** IN FUNCTION: ecore_timer_del()
05-26 21:41:35.516+0900 E/EFL     ( 3464): ecore<3464> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:41:35.516+0900 E/EFL     ( 3464):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:41:35.516+0900 E/EFL     ( 3464):     Supplied: e5933114 - <UNKNOWN>
05-26 21:41:35.516+0900 E/EFL     ( 3464): ecore<3464> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:41:35.516+0900 E/EFL     ( 3464): *** SPANK SPANK SPANK!!!
05-26 21:41:35.516+0900 E/EFL     ( 3464): *** Now go fix your code. Tut tut tut!
05-26 21:41:35.516+0900 E/EFL     ( 3464): ecore<3464> ecore.c:574 _ecore_magic_fail() 
05-26 21:41:35.516+0900 E/EFL     ( 3464): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 21:41:35.516+0900 E/EFL     ( 3464): *** IN FUNCTION: ecore_timer_del()
05-26 21:41:35.516+0900 E/EFL     ( 3464): ecore<3464> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 21:41:35.516+0900 E/EFL     ( 3464):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 21:41:35.516+0900 E/EFL     ( 3464):     Supplied: 403e8280 - <UNKNOWN>
05-26 21:41:35.516+0900 E/EFL     ( 3464): ecore<3464> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 21:41:35.516+0900 E/EFL     ( 3464): *** SPANK SPANK SPANK!!!
05-26 21:41:35.516+0900 E/EFL     ( 3464): *** Now go fix your code. Tut tut tut!
05-26 21:41:35.521+0900 I/SOCKETTEST( 3464): Success to create socket
05-26 21:41:35.526+0900 I/SOCKETTEST( 3464): Success to socket connection
05-26 21:41:35.526+0900 I/SOCKETTEST( 3464): write() 성공
05-26 21:41:36.006+0900 I/efl-extension( 3464): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c066d8
05-26 21:41:36.006+0900 I/efl-extension( 3464): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c066d8, obj: 0x44c066d8
05-26 21:41:36.006+0900 I/efl-extension( 3464): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:41:36.661+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=533707 button=1 downs=1
05-26 21:41:36.736+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=533787 button=1 downs=0
05-26 21:41:36.741+0900 D/TIMER   ( 3464): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 21:41:36.741+0900 D/TIMER   ( 3464): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 21:41:36.746+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 21:41:36.751+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c06858, elm_layout, _activated_obj : 0x0, activated : 1
05-26 21:41:37.411+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=534461 button=1 downs=1
05-26 21:41:37.501+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 21:41:37.516+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=534566 button=1 downs=0
05-26 21:41:38.211+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.216+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.216+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06858, elm_layout, time_stamp : 535262
05-26 21:41:38.311+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.316+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.316+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06858, elm_layout, time_stamp : 535362
05-26 21:41:38.381+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.381+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.381+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06858, elm_layout, time_stamp : 535431
05-26 21:41:38.421+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.421+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.421+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06858, elm_layout, time_stamp : 535469
05-26 21:41:38.471+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.471+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.471+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06858, elm_layout, time_stamp : 535520
05-26 21:41:38.526+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.526+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:38.526+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06858, elm_layout, time_stamp : 535577
05-26 21:41:39.121+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:39.126+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:39.126+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06858, elm_layout, time_stamp : 536172
05-26 21:41:39.171+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:39.176+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:39.176+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06858, elm_layout, time_stamp : 536222
05-26 21:41:39.246+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:39.246+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:39.246+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06858, elm_layout, time_stamp : 536295
05-26 21:41:40.366+0900 I/efl-extension(  737): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:40.371+0900 I/efl-extension( 3464): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 21:41:40.371+0900 I/efl-extension( 3464): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06858, elm_layout, time_stamp : 537418
05-26 21:41:42.306+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=539351 button=1 downs=1
05-26 21:41:42.351+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=539398 button=1 downs=0
05-26 21:41:42.351+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:41:42.351+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c06858, elm_layout, func : 0x40003871
05-26 21:41:42.351+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 21:41:42.351+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 21:41:42.351+0900 I/efl-extension( 3464): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:41:42.351+0900 I/efl-extension( 3464): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:41:42.351+0900 I/efl-extension( 3464): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:41:42.351+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:41:42.351+0900 D/TIMER   ( 3464): Setting time is 600
05-26 21:41:42.441+0900 I/SOCKETTEST( 3464): Success to create socket
05-26 21:41:42.446+0900 I/SOCKETTEST( 3464): Success to socket connection
05-26 21:41:42.446+0900 I/SOCKETTEST( 3464): write() 성공
05-26 21:41:42.481+0900 I/SENSOR  ( 3464): -199.850006, 41.020000, 30.240000
05-26 21:41:42.576+0900 I/SENSOR  ( 3464): -2.310000, -1.750000, 5.110000
05-26 21:41:42.686+0900 I/SENSOR  ( 3464): -1.960000, -3.220000, 6.860000
05-26 21:41:42.776+0900 I/SENSOR  ( 3464): 1.540000, -0.210000, 7.980000
05-26 21:41:42.876+0900 I/SENSOR  ( 3464): -7.280000, 6.790000, 8.680000
05-26 21:41:42.976+0900 I/SENSOR  ( 3464): -0.490000, 2.170000, 4.830000
05-26 21:41:43.076+0900 I/SENSOR  ( 3464): -1.190000, -2.380000, 4.620000
05-26 21:41:43.181+0900 I/SENSOR  ( 3464): 0.350000, -1.190000, 5.810000
05-26 21:41:43.281+0900 I/SENSOR  ( 3464): -1.540000, -2.170000, 3.290000
05-26 21:41:43.381+0900 I/SENSOR  ( 3464): -2.590000, -4.410000, 5.110000
05-26 21:41:43.506+0900 I/SENSOR  ( 3464): -3.570000, -6.370000, 3.640000
05-26 21:41:43.576+0900 I/SENSOR  ( 3464): -2.100000, -3.220000, 2.030000
05-26 21:41:43.686+0900 I/SENSOR  ( 3464): 6.580000, 2.870000, -0.280000
05-26 21:41:43.786+0900 I/SENSOR  ( 3464): 1.890000, -15.260000, -5.950000
05-26 21:41:43.876+0900 I/SENSOR  ( 3464): 2.870000, -14.280000, -5.530000
05-26 21:41:43.981+0900 I/SENSOR  ( 3464): 4.900000, -16.450001, -2.450000
05-26 21:41:44.081+0900 I/SENSOR  ( 3464): 19.180000, -27.440001, -7.490000
05-26 21:41:44.176+0900 I/SENSOR  ( 3464): 15.470000, -1.400000, 9.590000
05-26 21:41:44.176+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=541227 button=1 downs=1
05-26 21:41:44.191+0900 E/EFL     ( 3464): evas_main<3464> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=541239 button=1 downs=0
05-26 21:41:44.191+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 21:41:44.191+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c06858, elm_layout, func : 0x40003871
05-26 21:41:44.191+0900 I/efl-extension( 3464): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 21:41:44.191+0900 I/efl-extension( 3464): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 21:41:44.191+0900 I/efl-extension( 3464): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 21:41:44.191+0900 I/efl-extension( 3464): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 21:41:44.206+0900 I/SOCKETTEST( 3464): Success to create socket
05-26 21:41:44.211+0900 I/SOCKETTEST( 3464): Success to socket connection
05-26 21:41:44.211+0900 I/SOCKETTEST( 3464): write() 성공
05-26 21:41:44.706+0900 I/efl-extension( 3464): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c06858
05-26 21:41:44.706+0900 I/efl-extension( 3464): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c06858, obj: 0x44c06858
05-26 21:41:44.716+0900 I/efl-extension( 3464): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 21:41:53.731+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 21:41:53.731+0900 W/WAKEUP-SERVICE( 1115): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 21:41:53.741+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 21:41:53.741+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 21:41:53.741+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 21:41:53.741+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 21:41:53.761+0900 W/W_HOME  (  737): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 21:41:53.816+0900 W/WAKEUP-SERVICE( 1115): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 21:41:53.816+0900 W/WAKEUP-SERVICE( 1115): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 21:41:56.776+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-26 21:41:56.776+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-26 21:41:56.776+0900 E/WMS     (  491): ==========
05-26 21:41:56.776+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
05-26 21:41:56.776+0900 E/WMS     (  491): ==========
05-26 21:41:56.786+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-26 21:41:56.896+0900 W/SCSD    ( 1200): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-26 21:41:56.896+0900 W/SCSD    ( 1200): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-26 21:41:56.896+0900 W/SCSD    ( 1200): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-26 21:41:56.901+0900 W/SCSD    ( 1200): <util_scs_send:975> sent [63 / 63] bytes. 
05-26 21:41:56.916+0900 W/SHealth_Service( 1055): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-26 21:41:56.916+0900 E/SHealth_Service( 1055): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-26 21:41:59.681+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 21:41:59.686+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 21:41:59.691+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : pedometer_inactive_period error
05-26 21:41:59.691+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:41:59.691+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:41:59.696+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_10min_precaution_millisec error
05-26 21:41:59.701+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 21:41:59.701+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 21:41:59.701+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_before_10min_precaution_millisec error
05-26 21:42:00.436+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:42:04.931+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 21:42:04.931+0900 I/RESOURCED(  497): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 21:42:04.941+0900 I/RESOURCED(  497): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-26 21:42:10.991+0900 E/PKGMGR_SERVER( 3641): pkgmgr-server.c: main(2131) > package manager server start
05-26 21:42:11.076+0900 E/PKGMGR_SERVER( 3641): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_510507440], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[oFAEDmv8qExIDzboICIlQT3kyiA=], backend_flag=[0]
05-26 21:42:11.081+0900 E/PKGMGR_SERVER( 3643): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-26 21:42:11.086+0900 E/PKGMGR  ( 3635): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-26 21:42:11.151+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:42:11.161+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3464
05-26 21:42:11.161+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 21:42:11.166+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 5
05-26 21:42:11.171+0900 I/APP_CORE( 3464): appcore-efl.c: __do_app(429) > [APP 3464] Event: TERMINATE State: RUNNING
05-26 21:42:11.171+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 21:42:11.171+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(890) > app status : 4
05-26 21:42:11.171+0900 W/AUL_AMD (  496): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(3464), cmd(4)
05-26 21:42:11.171+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:42:11.186+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3464
05-26 21:42:11.241+0900 I/APP_CORE( 3464): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 21:42:11.241+0900 I/CAPI_APPFW_APPLICATION( 3464): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 21:42:11.261+0900 W/AUL_AMD (  496): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 21:42:11.261+0900 W/AUL_AMD (  496): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 21:42:11.271+0900 I/MALI    ( 3464): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f5f028] swap changed from sync to async
05-26 21:42:11.286+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:42:11.296+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3464
05-26 21:42:11.301+0900 I/MALI    ( 3464): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 21:42:11.301+0900 I/MALI    ( 3464): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3464   close drm_fd=25 
05-26 21:42:11.301+0900 I/MALI    ( 3464): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 21:42:11.351+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 21:42:11.356+0900 W/W_HOME  (  737): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 21:42:11.356+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:42:11.356+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:42:11.356+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:42:11.356+0900 W/W_HOME  (  737): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 21:42:11.356+0900 W/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 21:42:11.356+0900 I/WATCH_CORE(  778): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 21:42:11.356+0900 I/CAPI_WATCH_APPLICATION(  778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 21:42:11.356+0900 E/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 21:42:11.356+0900 I/watchface-loader(  778): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 21:42:11.366+0900 I/UXT     ( 3464): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 21:42:11.381+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(448) > Window [0x2200003] is now visible(0)
05-26 21:42:11.381+0900 W/W_HOME  (  737): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 21:42:11.381+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:42:11.381+0900 W/W_HOME  (  737): main.c: _window_visibility_cb(1189) > Window [0x2200003] is now visible(0)
05-26 21:42:11.381+0900 I/APP_CORE(  737): appcore-efl.c: __do_app(429) > [APP 737] Event: RESUME State: PAUSED
05-26 21:42:11.381+0900 I/CAPI_APPFW_APPLICATION(  737): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 21:42:11.381+0900 W/W_HOME  (  737): main.c: _appcore_resume_cb(681) > appcore resume
05-26 21:42:11.381+0900 W/W_HOME  (  737): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 21:42:11.381+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:42:11.381+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:42:11.381+0900 W/W_HOME  (  737): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 21:42:11.381+0900 W/APPS    (  737): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 21:42:11.381+0900 W/W_HOME  (  737): rotary.c: rotary_attach(138) > rotary_attach:0x47911dc0
05-26 21:42:11.381+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47911dc0, elm_layout, _activated_obj : 0x45c961a0, activated : 1
05-26 21:42:11.381+0900 I/efl-extension(  737): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 21:42:11.381+0900 I/wnotib  (  737): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 21:42:11.381+0900 E/wnotib  (  737): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 21:42:11.381+0900 W/wnotib  (  737): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 21:42:11.386+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 21:42:11.386+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:42:11.386+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:42:11.386+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 21:42:11.396+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:42:11.406+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3464
05-26 21:42:11.506+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:42:11.516+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3464
05-26 21:42:11.621+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:42:11.641+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3464
05-26 21:42:11.746+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:42:11.756+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3464
05-26 21:42:11.846+0900 I/MALI    (  737): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 21:42:11.861+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 21:42:11.866+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 21:42:11.876+0900 E/PKGMGR_SERVER( 3643): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-26 21:42:11.896+0900 E/PKGMGR_SERVER( 3641): pkgmgr-server.c: sighandler(409) > child NORMAL exit [3643]
05-26 21:42:12.041+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(646) > __request_handler: 23
05-26 21:42:12.041+0900 W/AUL_AMD (  496): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 21:42:12.041+0900 W/AUL_AMD (  496): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 3464
05-26 21:42:12.041+0900 W/AUL_AMD (  496): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-26 21:42:12.041+0900 E/AUL     ( 3650): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-26 21:42:12.051+0900 I/AUL_AMD (  496): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3464
05-26 21:42:12.116+0900 W/CRASH_MANAGER( 3648): worker.c: worker_job(1199) > 1103464706831146426653
