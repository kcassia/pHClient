S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 5965
Date: 2016-05-27 22:44:39+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4049f250, r3   = 0x00000000
r4   = 0x4434c580, r5   = 0x00000000
r6   = 0x4434ce80, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x4434b800
r10  = 0x4404ff18, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbed7d638
lr   = 0x403e81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     13552 KB
Buffers:     24560 KB
Cached:     147384 KB
VmPeak:     118840 KB
VmSize:     108444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22116 KB
VmRSS:       22116 KB
VmData:      52808 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5965 TID = 5965
5965 5972 5975 6054 6059 

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
43758000 4376c000 rwxp [stack:5972]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44383000 44b82000 rwxp [stack:6059]
44b82000 44b85000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b85000 44b89000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b89000 44b98000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44d50000 44d57000 r-xs /usr/lib/gconv/gconv-modules.cache
44d80000 4557f000 rwxp [stack:6054]
45713000 45f12000 rwxp [stack:5975]
466d3000 466d6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
466dd000 466de000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46749000 46781000 r-xp /usr/lib/libpulse.so.0.16.2
46781000 46782000 rwxp /usr/lib/libpulse.so.0.16.2
467f6000 467fb000 r-xp /usr/lib/libjson.so.0.0.1
46802000 46803000 rwxp /usr/lib/libjson.so.0.0.1
46803000 4684b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4684b000 4684c000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4684c000 4688f000 r-xp /usr/lib/libsndfile.so.1.0.25
46896000 46898000 rwxp /usr/lib/libsndfile.so.1.0.25
4689c000 468be000 r-xp /usr/lib/libvorbis.so.0.4.3
468c5000 468c6000 rwxp /usr/lib/libvorbis.so.0.4.3
468c6000 468ca000 r-xp /usr/lib/libogg.so.0.7.1
468d1000 468d2000 rwxp /usr/lib/libogg.so.0.7.1
bed5d000 bed7e000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5965)
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
00 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.115+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.115+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.130+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.135+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.135+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.150+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.155+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.155+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.165+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.175+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.175+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.190+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.195+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.200+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.210+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.215+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.220+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.230+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.235+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.235+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.250+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.260+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.260+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.270+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.280+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.280+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.290+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.295+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.300+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.310+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.320+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.320+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.330+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.340+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.340+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.350+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.360+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.360+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.370+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.380+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.380+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.395+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.405+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.410+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.425+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.430+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.430+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.445+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.450+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.450+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.465+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.475+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.475+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.490+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:10.500+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:10.500+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:10.515+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:11.840+0900 E/SHealth_Common( 1006): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-27 22:44:13.530+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:13.530+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:13.545+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:13.550+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:13.555+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:13.565+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:13.570+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:13.570+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:13.585+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:13.590+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:13.590+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:13.605+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:13.610+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:13.610+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:13.625+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:13.630+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:13.630+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:13.645+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:13.650+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:13.650+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:13.665+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:13.675+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:13.680+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:13.690+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:13.700+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:13.700+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:13.715+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:14.410+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-27 22:44:14.410+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-27 22:44:16.720+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.720+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.735+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:16.740+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.740+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.755+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:16.760+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.760+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.775+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:16.780+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.780+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.795+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:16.800+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.800+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.815+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:16.820+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.825+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.835+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:16.845+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.845+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.855+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:16.865+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.865+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.875+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:16.880+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.885+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.895+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:16.900+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.900+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.920+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:16.925+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:16.930+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:16.940+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:19.950+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:19.955+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:19.975+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:19.980+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:19.980+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:19.990+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:20.000+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:20.000+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:20.010+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:20.020+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:20.020+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:20.030+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.045+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.050+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.060+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.070+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.070+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.080+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.090+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.090+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.105+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.110+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.115+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.125+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.130+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.130+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.145+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.150+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.150+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.165+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.170+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.170+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.180+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.190+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.190+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.200+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.210+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.210+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.225+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.235+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.235+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.245+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.255+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.255+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.270+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.275+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.275+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.285+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.300+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.300+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.315+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.320+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.320+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.335+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.340+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.340+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.355+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.360+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.360+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.375+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.385+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.385+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.395+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.400+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.405+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.415+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.420+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.425+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.435+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.440+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.445+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.455+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.475+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.475+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.490+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.515+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.525+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.535+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.540+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.545+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.555+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.580+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.585+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.595+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.600+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.605+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.615+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.625+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.625+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.640+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.645+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.650+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.660+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.665+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.670+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.680+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.685+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.685+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.700+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.710+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.715+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.725+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.730+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.730+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.745+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.750+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.750+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.765+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.770+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.770+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.785+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.795+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.795+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.805+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.825+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.825+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.835+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.845+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.845+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.865+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.870+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.870+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.885+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.890+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.890+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.905+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.910+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.915+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.930+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.945+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.950+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.960+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.970+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.970+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:23.980+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:23.990+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:23.990+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.000+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.010+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.015+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.025+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.030+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.030+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.045+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.050+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.050+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.065+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.070+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.070+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.085+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.090+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.090+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.100+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.110+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.110+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.125+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.150+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.150+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.160+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.170+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.170+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.180+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.185+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.185+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.200+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.205+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.205+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.220+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.225+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.225+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.240+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.245+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.245+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.260+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.265+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.265+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.280+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.285+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.285+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.295+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.305+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.305+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.320+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.325+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.325+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.340+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.345+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.345+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.360+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.365+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.365+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.375+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.385+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.385+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.395+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.405+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.410+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.420+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.430+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.430+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.440+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.450+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.450+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.465+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.475+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.475+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.485+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.490+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.495+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.505+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.515+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.515+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.530+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.535+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.540+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.550+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.555+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.560+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.570+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.580+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.580+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.595+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.605+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.605+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.615+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.630+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.630+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.640+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.645+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.650+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.660+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.670+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.670+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.680+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.685+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.690+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.700+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.705+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.705+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.720+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.730+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.730+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.740+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.745+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.750+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.760+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.770+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.770+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.780+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.785+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.790+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.800+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.805+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.810+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.820+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.825+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.825+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.840+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.855+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.855+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.865+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.870+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.875+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.885+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.890+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.890+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.905+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.910+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.910+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.925+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.935+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.935+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.945+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.960+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.960+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.970+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.980+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:24.980+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:24.990+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:24.995+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.000+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.015+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.050+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.055+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.070+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.085+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.085+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.095+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.100+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.105+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.115+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.130+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.130+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.140+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.160+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.160+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.170+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.175+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.180+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.190+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.195+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.200+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.210+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.225+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.225+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.235+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.245+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.245+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.255+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.265+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.265+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.280+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.290+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.295+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.305+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.320+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.320+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.330+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.340+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.340+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.350+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.360+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.360+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.375+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.380+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.385+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.395+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.440+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.440+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.455+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.460+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.465+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.475+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.485+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.490+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.500+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.505+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.510+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.530+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.535+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.540+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.550+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.555+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.555+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.570+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.575+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.575+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.590+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.595+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.595+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.620+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.625+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.625+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.640+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.645+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.645+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.660+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.665+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.665+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.680+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:25.690+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:25.690+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:25.705+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:28.750+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:28.755+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:28.765+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:28.955+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:28.960+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:28.970+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:29.070+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:29.075+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:29.085+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:38.360+0900 E/PKGMGR_SERVER( 6127): pkgmgr-server.c: main(2131) > package manager server start
05-27 22:44:38.470+0900 E/PKGMGR_SERVER( 6127): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_463523183], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[kKYxvy2r9elw8kItXPhY3JN1st4=], backend_flag=[0]
05-27 22:44:38.480+0900 E/PKGMGR_SERVER( 6128): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-27 22:44:38.485+0900 E/PKGMGR  ( 6125): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-27 22:44:38.570+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:44:38.580+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5965
05-27 22:44:38.580+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 22:44:38.580+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 5
05-27 22:44:38.585+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(5965), cmd(4)
05-27 22:44:38.585+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:44:38.590+0900 I/APP_CORE( 5965): appcore-efl.c: __do_app(429) > [APP 5965] Event: TERMINATE State: RUNNING
05-27 22:44:38.600+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5965
05-27 22:44:38.600+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 22:44:38.600+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(890) > app status : 4
05-27 22:44:38.680+0900 I/APP_CORE( 5965): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 22:44:38.680+0900 I/CAPI_APPFW_APPLICATION( 5965): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 22:44:38.690+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 22:44:38.690+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 22:44:38.705+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:44:38.715+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5965
05-27 22:44:38.715+0900 I/MALI    ( 5965): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f5f028] swap changed from sync to async
05-27 22:44:38.745+0900 I/MALI    ( 5965): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-27 22:44:38.745+0900 I/MALI    ( 5965): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=5965   close drm_fd=25 
05-27 22:44:38.745+0900 I/MALI    ( 5965): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-27 22:44:38.765+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-27 22:44:38.770+0900 W/WATCH_CORE(  758): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-27 22:44:38.770+0900 I/WATCH_CORE(  758): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 22:44:38.770+0900 I/CAPI_WATCH_APPLICATION(  758): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 22:44:38.770+0900 E/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 22:44:38.770+0900 I/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 22:44:38.770+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 22:44:38.770+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:44:38.770+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:44:38.770+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:44:38.770+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 22:44:38.795+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 22:44:38.795+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 22:44:38.795+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:44:38.795+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 22:44:38.795+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESUME State: PAUSED
05-27 22:44:38.795+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 22:44:38.795+0900 W/W_HOME  (  726): main.c: _appcore_resume_cb(681) > appcore resume
05-27 22:44:38.795+0900 W/W_HOME  (  726): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-27 22:44:38.795+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:44:38.795+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:44:38.795+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 22:44:38.795+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 22:44:38.800+0900 W/W_HOME  (  726): rotary.c: rotary_attach(138) > rotary_attach:0x46f631e0
05-27 22:44:38.800+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46f631e0, elm_layout, _activated_obj : 0x45c962e8, activated : 1
05-27 22:44:38.800+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 22:44:38.805+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 22:44:38.805+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 22:44:38.805+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 22:44:38.805+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 22:44:38.805+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 22:44:38.805+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 22:44:38.805+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 22:44:38.810+0900 I/UXT     ( 5965): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 22:44:38.815+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:44:38.825+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5965
05-27 22:44:38.930+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:44:38.950+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5965
05-27 22:44:39.050+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:44:39.070+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5965
05-27 22:44:39.175+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:44:39.190+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5965
05-27 22:44:39.205+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:39.205+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:39.220+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:39.225+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:39.230+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:39.240+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:39.240+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:39.240+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:39.250+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:39.255+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:39.255+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:39.265+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:39.270+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:39.270+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 22:44:39.270+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:39.280+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:39.285+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:39.285+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:39.295+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:39.295+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:44:39.305+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:39.305+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:39.310+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5965
05-27 22:44:39.315+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:39.320+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:39.320+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:39.330+0900 I/SOCKETTEST( 5965): Success to create check socket
05-27 22:44:39.330+0900 I/SOCKETTEST( 5965): Success to socket connection
05-27 22:44:39.330+0900 I/SOCKETTEST( 5965): write() check msg success
05-27 22:44:39.415+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 22:44:39.425+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-27 22:44:39.435+0900 E/PKGMGR_SERVER( 6128): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-27 22:44:39.455+0900 E/PKGMGR_SERVER( 6127): pkgmgr-server.c: sighandler(409) > child NORMAL exit [6128]
05-27 22:44:39.475+0900 W/CRASH_MANAGER( 6133): worker.c: worker_job(1199) > 1105965706831146435667
