S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 12723
Date: 2016-05-27 20:30:26+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4049f250, r3   = 0x00000000
r4   = 0x461600f0, r5   = 0x00000000
r6   = 0x461609f0, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x4615f370
r10  = 0x4404ff18, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbef65638
lr   = 0x403e81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     13696 KB
Buffers:     43616 KB
Cached:     139772 KB
VmPeak:     114316 KB
VmSize:      99228 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21568 KB
VmRSS:       21568 KB
VmData:      43592 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 12723 TID = 12723
12723 12725 12728 12848 

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
43758000 4376c000 rwxp [stack:12725]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44383000 44b82000 rwxp [stack:12848]
44b82000 44b85000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b85000 44b89000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b89000 44b98000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
455fc000 45603000 r-xs /usr/lib/gconv/gconv-modules.cache
45694000 45e93000 rwxp [stack:12728]
460f4000 460f7000 r-xp /usr/lib/libpulse-simple.so.0.0.4
460fe000 460ff000 rwxp /usr/lib/libpulse-simple.so.0.0.4
4651c000 46554000 r-xp /usr/lib/libpulse.so.0.16.2
46554000 46555000 rwxp /usr/lib/libpulse.so.0.16.2
4665d000 46662000 r-xp /usr/lib/libjson.so.0.0.1
46669000 4666a000 rwxp /usr/lib/libjson.so.0.0.1
4666a000 466b2000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
466b2000 466b3000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
466b3000 466f6000 r-xp /usr/lib/libsndfile.so.1.0.25
466fd000 466ff000 rwxp /usr/lib/libsndfile.so.1.0.25
46703000 46725000 r-xp /usr/lib/libvorbis.so.0.4.3
4672c000 4672d000 rwxp /usr/lib/libvorbis.so.0.4.3
4672d000 46731000 r-xp /usr/lib/libogg.so.0.7.1
46738000 46739000 rwxp /usr/lib/libogg.so.0.7.1
bef45000 bef66000 rwxp [stack]
End of Maps Information

Callstack Information (PID:12723)
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
 -> 48 1464348617 95
05-27 20:30:17.064+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 48 101 91 88
05-27 20:30:17.064+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 48 0 0 0
05-27 20:30:17.064+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 48 110 39 95
05-27 20:30:17.064+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 48 81 5 70
05-27 20:30:17.064+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 48 112 28 97
05-27 20:30:17.084+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 48 1046 395 837
05-27 20:30:17.084+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 48 0 0 1299
05-27 20:30:17.084+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 48 873 273 698
05-27 20:30:17.084+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 48 2119 5 1695
05-27 20:30:17.084+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 48 0 0 0
05-27 20:30:17.094+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(72) > [_charging_ui_update:72] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
05-27 20:30:17.104+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(81) > [_charging_ui_update:81] [HIDE charging icon] Not connected or Battery full (5)
05-27 20:30:17.134+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-27 20:30:17.134+0900 W/W_HOME  (  732): dbox.c: _dbus_rotation_cb(1299) > angle changed:0
05-27 20:30:17.154+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(72) > [_charging_ui_update:72] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
05-27 20:30:17.154+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(81) > [_charging_ui_update:81] [HIDE charging icon] Not connected or Battery full (5)
05-27 20:30:17.154+0900 W/W_INDICATOR(  717): windicator_battery.c: _battery_charger_status_changed_cb(165) > [_battery_charger_status_changed_cb:165] Show Moment View to display TA status(unconnected)
05-27 20:30:17.164+0900 E/W_INDICATOR(  717): windicator_moment_view.c: windicator_moment_view_show(578) > [windicator_moment_view_show:578] Show Moment View : dynamic_layout(0x446a4960), type(1)
05-27 20:30:17.164+0900 W/W_INDICATOR(  717): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(155) > [wnidicator_moment_view_battery_image_update:155] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
05-27 20:30:17.164+0900 W/W_INDICATOR(  717): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(164) > [wnidicator_moment_view_battery_image_update:164] [HIDE charging icon] Not connected or Battery full (5)
05-27 20:30:17.174+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x0200000d)
05-27 20:30:17.219+0900 W/APP_CORE(  717): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000d
05-27 20:30:17.334+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: RESUME State: PAUSED
05-27 20:30:17.334+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 20:30:17.409+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-27 20:30:17.409+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-27 20:30:17.409+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1406045078)
05-27 20:30:17.409+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 20:30:17.409+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 11:30:20 (UTC).
05-27 20:30:17.409+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 20:30:17.409+0900 E/ALARM_MANAGER(  489): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1406045078] is removed.
05-27 20:30:17.419+0900 E/EFL     (  717): evas_main<717> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4843416 button=1 downs=1
05-27 20:30:17.419+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-27 20:30:17.424+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-27 20:30:17.444+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.464+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.489+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.509+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.509+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-27 20:30:17.509+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-27 20:30:17.524+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.539+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.539+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464348621, Fri May 27 20:30:21 2016
05-27 20:30:17.539+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 2079310603, next duetime: 1464348621
05-27 20:30:17.539+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(2079310603)
05-27 20:30:17.539+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464348620), due_time(1464348621)
05-27 20:30:17.539+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 20:30:17.539+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 11:30:20 (UTC).
05-27 20:30:17.539+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 20:30:17.549+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-27 20:30:17.549+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-27 20:30:17.549+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(2079310603)
05-27 20:30:17.549+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 20:30:17.554+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 11:30:20 (UTC).
05-27 20:30:17.554+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 20:30:17.554+0900 E/ALARM_MANAGER(  489): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[2079310603] is removed.
05-27 20:30:17.559+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-27 20:30:17.564+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-27 20:30:17.569+0900 E/EFL     (  717): evas_main<717> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=4843570 device=10 downs=2
05-27 20:30:17.584+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.599+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.624+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.639+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.639+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-27 20:30:17.644+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-27 20:30:17.659+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.674+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 20:30:17.674+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464352217, Fri May 27 21:30:17 2016
05-27 20:30:17.674+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 2079310603, next duetime: 1464352217
05-27 20:30:17.674+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(2079310603)
05-27 20:30:17.674+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464348620), due_time(1464352217)
05-27 20:30:17.679+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 20:30:17.679+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 11:30:20 (UTC).
05-27 20:30:17.679+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 20:30:18.004+0900 E/EFL     (  717): evas_main<717> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4844005 button=1 downs=1
05-27 20:30:18.054+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 20:30:18.054+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 20:30:18.054+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:30:18.054+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:30:18.054+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:30:18.104+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:30:18.149+0900 E/EFL     (  717): ecore_x<717> ecore_x_xi2.c:273 _ecore_x_input_handler() TouchCancel ButtonEvent: cancel time=0
05-27 20:30:18.149+0900 E/EFL     (  717): evas_main<717> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=0 device=10 downs=0
05-27 20:30:18.579+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:30:19.169+0900 E/W_INDICATOR(  717): windicator_moment_view.c: windicator_moment_view_hide(634) > [windicator_moment_view_hide:634] Hide Moment View : dynamic_layout(0x446a4960),Type(1)
05-27 20:30:19.174+0900 E/W_INDICATOR(  717): windicator_connection.c: windi_connection_pause(1552) > [windi_connection_pause:1552] There is no handle
05-27 20:30:19.389+0900 E/W_INDICATOR(  717): windicator_util.c: windi_x_input_event_unregister(223) > [windi_x_input_event_unregister:223] not registered
05-27 20:30:19.459+0900 W/APP_CORE(  717): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000d
05-27 20:30:19.459+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
05-27 20:30:19.464+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 20:30:19.999+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-27 20:30:20.074+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-27 20:30:20.134+0900 E/RESOURCED(  493): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 4809
05-27 20:30:20.159+0900 E/ALARM_MANAGER( 4809): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.ascsd] : Alarm id [663495865]
05-27 20:30:20.159+0900 W/SNL_W   ( 4809): <on_alarm_event:642> Awake to sendKeepAlive_Alarm() - begin,  mCurrentIntervalSeconds ( 480 )
05-27 20:30:20.159+0900 W/SNL_W   ( 4809): <on_alarm_event:652> sendKeepAlive_alarmthread detached successfully
05-27 20:30:20.159+0900 W/SNL_W   ( 4809): <on_alarm_event:656> sendKeepAlive_alarmthread - end 
05-27 20:30:20.164+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_expired(1322) > alarm_id[663495865] is expired.
05-27 20:30:20.164+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(663495865)
05-27 20:30:20.164+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 20:30:20.164+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 12:30:17 (UTC).
05-27 20:30:20.169+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 20:30:20.169+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-27 20:30:20.179+0900 W/SNL_W   ( 4809): <sendKeepAliveAllGroup:670> sendKeepAliveAllGroup() - begin
05-27 20:30:20.179+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Call()
05-27 20:30:20.179+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Res( 0 )
05-27 20:30:20.199+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-27 20:30:20.199+0900 W/SNL_W   ( 4809): <util_pm_lock:1132> util_pm_lock() LOCK
05-27 20:30:20.219+0900 W/SNL_W   ( 4809): <sendKeepAliveAllGroup:706> releaseWakeLockinTimeThread detached successfully
05-27 20:30:20.219+0900 W/SNL_W   ( 4809): <sendKeepAliveAllGroup:719> 0 sendKeepAliveThread detached successfully
05-27 20:30:20.229+0900 W/SNL_W   ( 4809): <sendKeepAliveThread:863> sendKeepAliveThread() - presSendNotify(1) begin
05-27 20:30:20.229+0900 W/SCSD    ( 4809): <on_presSendNotify:426> sent keepalive (group_id: 3532130a434bf7f1bd119f41) (S:0/F:1/T:1) (msg_id: 1)
05-27 20:30:20.234+0900 W/SCSD    ( 4809): <_keepalive_cb:520> entrance
05-27 20:30:20.234+0900 W/SCSD    ( 4809): <util_dbus_send_keepalive_sent:287> entrance
05-27 20:30:20.239+0900 W/SNL_W   ( 4809): <sendKeepAliveThread:865> sendKeepAliveThread() - presSendNotify(1) end
05-27 20:30:20.239+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: sKA - group( 3532130a434bf7f1bd119f41 ) mtype( 0 ) timeout( 30000 )
05-27 20:30:20.244+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: sKA
05-27 20:30:20.249+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: send_msg - ( 0xfc ), type( 0x01 ), res( 152 ), seq( 1009 )
05-27 20:30:20.249+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Call()
05-27 20:30:20.254+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Res( 0 )
05-27 20:30:20.254+0900 W/SNL_W   ( 4809): <presSendNotify_i:994> presSendNotify_w ( 3532130a434bf7f1bd119f41 ) - begin
05-27 20:30:20.254+0900 W/SNL_W   ( 4809): <presSendNotify_i:1017> presSendNotify_w ( 3532130a434bf7f1bd119f41 ) - end
05-27 20:30:20.254+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: noti_ps_th - Res( )
05-27 20:30:20.299+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 48 -> 48 1464348620 3
05-27 20:30:20.299+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 48 1046 395 837
05-27 20:30:20.304+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 48 0 0 1299
05-27 20:30:20.304+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 48 873 273 698
05-27 20:30:20.304+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 48 2119 5 1695
05-27 20:30:20.304+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 48 0 0 0
05-27 20:30:20.309+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 48 101 91 88
05-27 20:30:20.309+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 48 0 0 0
05-27 20:30:20.309+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 48 110 39 95
05-27 20:30:20.309+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 48 100 5 87
05-27 20:30:20.309+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 48 115 28 100
05-27 20:30:20.329+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(72) > [_charging_ui_update:72] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
05-27 20:30:20.334+0900 I/AUL_AMD (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-27 20:30:20.349+0900 I/AUL_AMD (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-27 20:30:20.349+0900 E/AUL_AMD (  492): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-27 20:30:20.349+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 492
05-27 20:30:20.364+0900 W/AUL_AMD (  492): amd_launch.c: start_process(580) > child process: 13058
05-27 20:30:20.369+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(76) > [_charging_ui_update:76] [SHOW charging icon] Connected / not Full / not charge -1
05-27 20:30:20.404+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(72) > [_charging_ui_update:72] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
05-27 20:30:20.404+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(76) > [_charging_ui_update:76] [SHOW charging icon] Connected / not Full / not charge -1
05-27 20:30:20.404+0900 W/W_INDICATOR(  717): windicator_battery.c: _battery_charger_status_changed_cb(170) > [_battery_charger_status_changed_cb:170] TA connected or abnormal
05-27 20:30:20.404+0900 W/W_INDICATOR(  717): windicator_battery.c: _battery_charger_status_changed_cb(186) > [_battery_charger_status_changed_cb:186] Show Moment View to display charging animation
05-27 20:30:20.409+0900 E/W_INDICATOR(  717): windicator_moment_view.c: windicator_moment_view_show(578) > [windicator_moment_view_show:578] Show Moment View : dynamic_layout(0x446a4960), type(1)
05-27 20:30:20.409+0900 W/W_INDICATOR(  717): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(155) > [wnidicator_moment_view_battery_image_update:155] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
05-27 20:30:20.409+0900 W/W_INDICATOR(  717): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(159) > [wnidicator_moment_view_battery_image_update:159] [SHOW charging icon] Connected / not Full / not charge -1
05-27 20:30:20.414+0900 W/AUL_AMD (  492): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 13058
05-27 20:30:20.419+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x0200000d)
05-27 20:30:20.429+0900 I/AUL_AMD (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-27 20:30:20.439+0900 I/AUL_AMD (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-27 20:30:20.439+0900 E/AUL_AMD (  492): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-27 20:30:20.439+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 492
05-27 20:30:20.454+0900 W/AUL_AMD (  492): amd_launch.c: start_process(580) > child process: 13062
05-27 20:30:20.484+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: recv_msg(res) - ( 0xfc ), seq( 1009 )
05-27 20:30:20.484+0900 W/SNL     ( 4809): Scone_Log.cpp: dump(2972) > SNL :: sKA - res( 0 )
05-27 20:30:20.484+0900 W/SNL_W   ( 4809): <sendKeepAliveThread:870> sendKeepAliveThread() - group_id ( 3532130a434bf7f1bd119f41 ) sendKeepAliveType ( 0 ), PING_CNT ( 0 ) 
05-27 20:30:20.484+0900 W/SNL_W   ( 4809): <sendKeepAliveThread:879> sendKeepAliveThread() - presSendNotify(0) begin
05-27 20:30:20.484+0900 W/SCSD    ( 4809): <on_presSendNotify:426> sent keepalive (group_id: 3532130a434bf7f1bd119f41) (S:1/F:1/T:2) (msg_id: 0)
05-27 20:30:20.484+0900 W/SNL_W   ( 4809): <sendKeepAliveThread:881> sendKeepAliveThread() - presSendNotify(0) end
05-27 20:30:20.484+0900 W/SCSD    ( 4809): <_keepalive_cb:520> entrance
05-27 20:30:20.509+0900 W/APP_CORE(  717): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000d
05-27 20:30:20.529+0900 E/RESOURCED(  493): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > [resourced_dbus_system_hash_drop_busname,324] Does not exist in busname hash: :1.356
05-27 20:30:20.544+0900 W/SNL_W   ( 4809): <sendKeepAliveAllGroup:731> sendKeepAliveAllgroup() - groupList.size() : 0(f) + 1(p)
05-27 20:30:20.544+0900 W/SNL_W   ( 4809): <setAlarm:520> setAlarm() - begin 
05-27 20:30:20.544+0900 W/SNL_W   ( 4809): <initAlarm:505> InitAlarm() - begin
05-27 20:30:20.544+0900 W/SNL_W   ( 4809): <initAlarm:511> InitAlarm() success - end
05-27 20:30:20.554+0900 W/AUL_AMD (  492): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 13062
05-27 20:30:20.574+0900 E/RESOURCED(  493): proc-main.c: proc_add_app_list(272) > [proc_add_app_list,272] not found previous pai : com.samsung.w-gallery.consumer
05-27 20:30:20.574+0900 E/RESOURCED(  493): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-gallery
05-27 20:30:20.589+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-27 20:30:20.589+0900 W/W_HOME  (  732): dbox.c: _dbus_rotation_cb(1302) > invalid angle, skipped:0
05-27 20:30:20.594+0900 I/AUL     ( 4809): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-27 20:30:20.594+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: RESUME State: PAUSED
05-27 20:30:20.599+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 20:30:20.614+0900 E/RESOURCED(  493): proc-main.c: proc_add_app_list(272) > [proc_add_app_list,272] not found previous pai : com.samsung.w-music-transfer.consumer
05-27 20:30:20.614+0900 I/AUL     ( 4809): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-27 20:30:20.619+0900 E/ALARM_MANAGER( 4809): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(715), start(27-5-2016, 20:42:16), repeat(0), interval(0), type(-1073741822)
05-27 20:30:20.689+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-27 20:30:20.689+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-27 20:30:20.699+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-27 20:30:20.709+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-27 20:30:20.724+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-27 20:30:20.739+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-27 20:30:20.739+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-27 20:30:20.739+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-27 20:30:20.754+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-27 20:30:20.769+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-27 20:30:20.769+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464349336, Fri May 27 20:42:16 2016
05-27 20:30:20.769+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1161054382, next duetime: 1464349336
05-27 20:30:20.769+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1161054382)
05-27 20:30:20.769+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464352217), due_time(1464349336)
05-27 20:30:20.769+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 20:30:20.769+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 11:42:16 (UTC).
05-27 20:30:20.774+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 20:30:20.774+0900 W/SNL_W   ( 4809): <setAlarm:569> setAlarm() - end : mStatus ( 1 ) currentInterval( 720 ) interruptFlag ( 0 ) alarm_id ( 1161054382 )
05-27 20:30:20.774+0900 W/SNL_W   ( 4809): <sendKeepAliveAllGroup:750> sendKeepAliveAllGroup() - set last interval ( 480 )
05-27 20:30:20.774+0900 W/SNL_W   ( 4809): <util_pm_unlock:1154> util_pm_unlock() UNLOCK
05-27 20:30:20.784+0900 W/SNL_W   ( 4809): <sendKeepAliveAllGroup:756> sendKeepAliveAllGroup () - WakeLock release
05-27 20:30:20.784+0900 W/SNL_W   ( 4809): <sendKeepAliveAllGroup:768> sendKeepAliveAllGroup() - end Error ( 0 )
05-27 20:30:20.849+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:20.859+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13058
05-27 20:30:20.859+0900 W/SNL_W   ( 4809): <releaseWakeLockinTimeThread:813> releaseWakeLockinTimeThread () - WakeLock already released
05-27 20:30:20.859+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:30:20.869+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-27 20:30:20.869+0900 W/W_HOME  (  732): dbox.c: _dbus_rotation_cb(1299) > angle changed:90
05-27 20:30:20.894+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:20.904+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13062
05-27 20:30:20.904+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:AlarmSvc.cpp     L:   80][_HIGH]CAlarmSvc::CAlarmSvc()[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:TransferCtrl.cpp L:   81][_HIGH]CTransferCtrl::CTransferCtrl()[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:SAPClient.cpp    L:   79][_HIGH][TX]CSAPClient::BindPeer(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService nChannel=4444[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:PeerList.cpp     L:  159][_HIGH][TX]CPeerList::CPeerList(0x42e76844)[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:   48][_HIGH]Creating SAP Proxy Object. 0x42e76880[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:   75][_HIGH][TX]Bind(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService Role=Consumer Channel=4444[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:ReceiverCtrl.cpp L:   65][_HIGH]CReceiverCtrl::CReceiverCtrl()[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:AutoTransfer.cpp L:  104][_HIGH]Set Event Handler. 0x40037bd0[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:SAPClient.cpp    L:   79][_HIGH][RX]CSAPClient::BindPeer(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService nChannel=4444[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:PeerList.cpp     L:  159][_HIGH][RX]CPeerList::CPeerList(0x42e789d4)[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:   75][_HIGH][RX]Bind(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService Role=Consumer Channel=4444[0m
05-27 20:30:20.964+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
05-27 20:30:20.969+0900 W/WG-CONSUMER(13058): [34m[F:consumer-app.cpp L:  134][_HIGH]Gallery file consumer SVC is started[0m
05-27 20:30:20.969+0900 I/CAPI_CONTENT_MEDIA_CONTENT(13058): media_content.c: media_content_connect(860) > [32m[13058]ref count : 0
05-27 20:30:20.974+0900 I/CAPI_CONTENT_MEDIA_CONTENT(13058): media_content.c: media_content_connect(892) > [32m[13058]ref count changed to: 1
05-27 20:30:20.974+0900 W/WG-CONSUMER(13058): [34m[F:TransferCtrl.cpp L:  115][_HIGH][TX]Connect to Peer[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:UserNotification L:  185][_HIGH]WIPC Service Created[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:SAPClient.cpp    L:   95][_HIGH][TX]CSAPClient::Connect()[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  122][_HIGH][TX]CConnection::Connect() State:SM_STATE_INITIATE[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  129][_HIGH]CSAPProxy::Connect. Size=0 pConnection=0x42e77878[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  332][_HIGH]Not BT/WFD connected. Cur type=16[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  172][_HIGH]Device dis-connected. WMS=1 BT=0 [0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
05-27 20:30:20.979+0900 E/WG-CONSUMER(13058): [31m[F:consumer-app.cpp L:  146][ERROR]TX Connection Error[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:ReceiverCtrl.cpp L:  493][_HIGH][RX]Connect to Peer[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:SAPClient.cpp    L:   95][_HIGH][RX]CSAPClient::Connect()[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  122][_HIGH][RX]CConnection::Connect() State:SM_STATE_INITIATE[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  129][_HIGH]CSAPProxy::Connect. Size=1 pConnection=0x42e78928[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  132][_HIGH]  Connection : [TX] LocalAgentID:0 ServiceHandle:0[0m
05-27 20:30:20.979+0900 E/WG-CONSUMER(13058): [31m[F:SAPProxy.cpp     L:  147][ERROR]Previous pCurrent(0x42e77878) is exist[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  332][_HIGH]Not BT/WFD connected. Cur type=16[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:SAPProxy.cpp     L:  172][_HIGH]Device dis-connected. WMS=1 BT=0 [0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:consumer-app.cpp L:  191][_HIGH]Gallery consumer SVC on Param. Handle=0x42e9b9f0[0m
05-27 20:30:20.979+0900 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
05-27 20:30:20.979+0900 W/CAPI_APPFW_APP_CONTROL(13058): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
05-27 20:30:20.979+0900 W/WG-CONSUMER(13058): [34m[F:consumer-app.cpp L:  298][_HIGH]End of Param[0m
05-27 20:30:20.989+0900 W/MUSIC_TRANSFER(13062): mt-service.c: main(92) > [33m[TID:13062]   service start[0m
05-27 20:30:20.994+0900 W/MUSIC_TRANSFER(13062): mt-service.c: _service_app_create(32) > [33m[TID:13062]   [0m
05-27 20:30:21.084+0900 I/CAPI_CONTENT_MEDIA_CONTENT(13062): media_content.c: media_content_connect(860) > [32m[13062]ref count : 0
05-27 20:30:21.089+0900 I/CAPI_CONTENT_MEDIA_CONTENT(13062): media_content.c: media_content_connect(892) > [32m[13062]ref count changed to: 1
05-27 20:30:21.124+0900 W/MUSIC_TRANSFER(13062): mt-consumer.c: __mt_consumer_on_service_agent_confirm(294) > [33m[TID:13062]   wStatusCode : [0], uwLocalAgentId : [40994][0m
05-27 20:30:21.129+0900 I/CAPI_CONTENT_MEDIA_CONTENT(13062): media_content.c: media_content_connect(860) > [32m[13062]ref count : 1
05-27 20:30:21.129+0900 I/CAPI_CONTENT_MEDIA_CONTENT(13062): media_content.c: media_content_connect(892) > [32m[13062]ref count changed to: 2
05-27 20:30:21.159+0900 W/MUSIC_TRANSFER(13062): mt-service.c: _service_app_control(74) > [33m[TID:13062]   [0m
05-27 20:30:21.159+0900 W/CAPI_APPFW_APP_CONTROL(13062): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
05-27 20:30:21.159+0900 W/MUSIC_TRANSFER(13062): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:13062]   uwLocalAgentId : [40994], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-27 20:30:21.159+0900 W/MUSIC_TRANSFER(13062): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:13062]   wStatusCode error : [1]!!![0m
05-27 20:30:22.224+0900 W/MUSIC_TRANSFER(13062): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:13062]   uwLocalAgentId : [40994], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-27 20:30:22.229+0900 W/MUSIC_TRANSFER(13062): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:13062]   wStatusCode error : [1]!!![0m
05-27 20:30:22.409+0900 E/W_INDICATOR(  717): windicator_moment_view.c: windicator_moment_view_hide(634) > [windicator_moment_view_hide:634] Hide Moment View : dynamic_layout(0x446a4960),Type(1)
05-27 20:30:22.414+0900 E/W_INDICATOR(  717): windicator_connection.c: windi_connection_pause(1552) > [windi_connection_pause:1552] There is no handle
05-27 20:30:22.544+0900 E/W_INDICATOR(  717): windicator_util.c: windi_x_input_event_unregister(223) > [windi_x_input_event_unregister:223] not registered
05-27 20:30:22.624+0900 W/APP_CORE(  717): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000d
05-27 20:30:22.624+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
05-27 20:30:22.624+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 20:30:24.369+0900 W/MUSIC_TRANSFER(13062): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:13062]   uwLocalAgentId : [40994], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-27 20:30:24.369+0900 W/MUSIC_TRANSFER(13062): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:13062]   wStatusCode error : [1]!!![0m
05-27 20:30:26.054+0900 E/PKGMGR_SERVER(13150): pkgmgr-server.c: main(2131) > package manager server start
05-27 20:30:26.129+0900 E/PKGMGR_SERVER(13150): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_1001172745], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[+cLaQOkNuS4NmfgHPtGY60ceHs0=], backend_flag=[0]
05-27 20:30:26.134+0900 E/PKGMGR_SERVER(13152): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-27 20:30:26.139+0900 E/PKGMGR  (13143): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-27 20:30:26.209+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:26.219+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12723
05-27 20:30:26.219+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:30:26.224+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 5
05-27 20:30:26.229+0900 I/APP_CORE(12723): appcore-efl.c: __do_app(429) > [APP 12723] Event: TERMINATE State: RUNNING
05-27 20:30:26.229+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 20:30:26.229+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 20:30:26.229+0900 W/AUL_AMD (  492): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(12723), cmd(4)
05-27 20:30:26.229+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:26.239+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12723
05-27 20:30:26.304+0900 I/APP_CORE(12723): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 20:30:26.304+0900 I/CAPI_APPFW_APPLICATION(12723): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 20:30:26.329+0900 I/efl-extension(12723): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 20:30:26.329+0900 I/efl-extension(12723): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x461ec188 is freed
05-27 20:30:26.329+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 20:30:26.329+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 20:30:26.329+0900 I/efl-extension(12723): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x461fdbf8 is freed
05-27 20:30:26.329+0900 I/efl-extension(12723): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x442eccf8 is freed
05-27 20:30:26.334+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-27 20:30:26.344+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:26.349+0900 I/MALI    (12723): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f5f028] swap changed from sync to async
05-27 20:30:26.354+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12723
05-27 20:30:26.374+0900 I/MALI    (12723): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-27 20:30:26.374+0900 I/MALI    (12723): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=12723   close drm_fd=25 
05-27 20:30:26.374+0900 I/MALI    (12723): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-27 20:30:26.434+0900 I/UXT     (12723): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 20:30:26.444+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-27 20:30:26.444+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 20:30:26.444+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:30:26.444+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:30:26.444+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:30:26.444+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 20:30:26.454+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:26.459+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12723
05-27 20:30:26.469+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 20:30:26.469+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 20:30:26.469+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:30:26.469+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 20:30:26.469+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-27 20:30:26.469+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 20:30:26.469+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-27 20:30:26.469+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-27 20:30:26.469+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:30:26.469+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:30:26.474+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-27 20:30:26.474+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 27->27
05-27 20:30:26.474+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x45d4d480
05-27 20:30:26.474+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d4d480, elm_layout, _activated_obj : 0x45c96570, activated : 1
05-27 20:30:26.474+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-27 20:30:26.479+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-27 20:30:26.479+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 20:30:26.479+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:30:26.479+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:30:26.479+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:30:26.489+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 20:30:26.489+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:30:26.494+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 20:30:26.494+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-27 20:30:26.494+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:30:26.494+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:30:26.494+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-27 20:30:26.564+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:26.574+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12723
05-27 20:30:26.674+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:26.714+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12723
05-27 20:30:26.819+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:26.834+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12723
05-27 20:30:26.934+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 20:30:26.934+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:26.944+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12723
05-27 20:30:27.049+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:30:27.064+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-27 20:30:27.089+0900 E/PKGMGR_SERVER(13152): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-27 20:30:27.124+0900 E/PKGMGR_SERVER(13150): pkgmgr-server.c: sighandler(409) > child NORMAL exit [13152]
05-27 20:30:27.189+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 23
05-27 20:30:27.189+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-27 20:30:27.189+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 12723
05-27 20:30:27.189+0900 W/AUL_AMD (  492): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-27 20:30:27.189+0900 E/AUL     (13160): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-27 20:30:27.204+0900 I/AUL_AMD (  492): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 12723
05-27 20:30:27.259+0900 W/CRASH_MANAGER(13158): worker.c: worker_job(1199) > 1112723706831146434862
