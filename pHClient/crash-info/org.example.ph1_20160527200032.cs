S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 8881
Date: 2016-05-27 20:00:32+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4049f250, r3   = 0x00000000
r4   = 0x4431bec8, r5   = 0x00000000
r6   = 0x4431c7c8, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x4431b148
r10  = 0x4404ff18, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbea52638
lr   = 0x403e81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     35564 KB
Buffers:     40040 KB
Cached:     145768 KB
VmPeak:     109756 KB
VmSize:      98220 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21180 KB
VmRSS:       21180 KB
VmData:      42584 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8881 TID = 8881
8881 8888 8891 9011 

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
43758000 4376c000 rwxp [stack:8888]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44b82000 44b85000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b85000 44b89000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b89000 44b98000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44bf8000 44bff000 r-xs /usr/lib/gconv/gconv-modules.cache
44d01000 45500000 rwxp [stack:9011]
45694000 45e93000 rwxp [stack:8891]
46517000 4651a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46521000 46522000 rwxp /usr/lib/libpulse-simple.so.0.0.4
4658d000 465c5000 r-xp /usr/lib/libpulse.so.0.16.2
465c5000 465c6000 rwxp /usr/lib/libpulse.so.0.16.2
4663a000 4663f000 r-xp /usr/lib/libjson.so.0.0.1
46646000 46647000 rwxp /usr/lib/libjson.so.0.0.1
46647000 4668f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4668f000 46690000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46690000 466d3000 r-xp /usr/lib/libsndfile.so.1.0.25
466da000 466dc000 rwxp /usr/lib/libsndfile.so.1.0.25
466e0000 46702000 r-xp /usr/lib/libvorbis.so.0.4.3
46709000 4670a000 rwxp /usr/lib/libvorbis.so.0.4.3
4670a000 4670e000 r-xp /usr/lib/libogg.so.0.7.1
46715000 46716000 rwxp /usr/lib/libogg.so.0.7.1
bea32000 bea53000 rwxp [stack]
End of Maps Information

Callstack Information (PID:8881)
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
_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 33 97 5 108
05-27 19:59:34.202+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 33 124 13 138
05-27 19:59:34.217+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(81) > [_charging_ui_update:81] [HIDE charging icon] Not connected or Battery full (5)
05-27 19:59:34.217+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 1045 395 575
05-27 19:59:34.217+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 0 0 981
05-27 19:59:34.217+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 872 273 480
05-27 19:59:34.217+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 2053 5 1129
05-27 19:59:34.217+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 2053 5 1129
05-27 19:59:34.222+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-27 19:59:34.222+0900 W/W_HOME  (  732): dbox.c: _dbus_rotation_cb(1299) > angle changed:0
05-27 19:59:34.227+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(72) > [_charging_ui_update:72] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
05-27 19:59:34.227+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(81) > [_charging_ui_update:81] [HIDE charging icon] Not connected or Battery full (5)
05-27 19:59:34.227+0900 W/W_INDICATOR(  717): windicator_battery.c: _battery_charger_status_changed_cb(165) > [_battery_charger_status_changed_cb:165] Show Moment View to display TA status(unconnected)
05-27 19:59:34.242+0900 E/W_INDICATOR(  717): windicator_moment_view.c: windicator_moment_view_show(578) > [windicator_moment_view_show:578] Show Moment View : dynamic_layout(0x446a4960), type(1)
05-27 19:59:34.247+0900 W/W_INDICATOR(  717): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(155) > [wnidicator_moment_view_battery_image_update:155] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
05-27 19:59:34.247+0900 W/W_INDICATOR(  717): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(164) > [wnidicator_moment_view_battery_image_update:164] [HIDE charging icon] Not connected or Battery full (5)
05-27 19:59:34.252+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x0200000d)
05-27 19:59:34.322+0900 W/APP_CORE(  717): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000d
05-27 19:59:34.392+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: RESUME State: PAUSED
05-27 19:59:34.392+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 19:59:35.147+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 19:59:35.147+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 19:59:35.147+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 19:59:35.152+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 19:59:35.152+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 19:59:35.152+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 19:59:35.167+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 19:59:35.202+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 19:59:35.202+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 19:59:36.252+0900 E/W_INDICATOR(  717): windicator_moment_view.c: windicator_moment_view_hide(634) > [windicator_moment_view_hide:634] Hide Moment View : dynamic_layout(0x446a4960),Type(1)
05-27 19:59:36.252+0900 E/W_INDICATOR(  717): windicator_connection.c: windi_connection_pause(1552) > [windi_connection_pause:1552] There is no handle
05-27 19:59:36.442+0900 E/W_INDICATOR(  717): windicator_util.c: windi_x_input_event_unregister(223) > [windi_x_input_event_unregister:223] not registered
05-27 19:59:36.482+0900 W/APP_CORE(  717): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000d
05-27 19:59:36.482+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
05-27 19:59:36.482+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 19:59:36.997+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-27 19:59:37.052+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-27 19:59:37.107+0900 E/RESOURCED(  493): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 847
05-27 19:59:37.132+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_expired(1322) > alarm_id[2069685850] is expired.
05-27 19:59:37.137+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(2069685850)
05-27 19:59:37.137+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 19:59:37.137+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 11:05:43 (UTC).
05-27 19:59:37.137+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 19:59:37.137+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-27 19:59:37.157+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-27 19:59:37.157+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-27 19:59:37.162+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-27 19:59:37.182+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:37.202+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:37.222+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:37.237+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:37.237+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-27 19:59:37.237+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-27 19:59:37.257+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:37.267+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:37.267+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464347677, Fri May 27 20:14:37 2016
05-27 19:59:37.267+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1178357431, next duetime: 1464347677
05-27 19:59:37.267+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1178357431)
05-27 19:59:37.267+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464347143), due_time(1464347677)
05-27 19:59:37.272+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 19:59:37.272+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 11:05:43 (UTC).
05-27 19:59:37.272+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 19:59:37.862+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-27 19:59:37.872+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-27 19:59:37.872+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1178357431)
05-27 19:59:37.877+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 19:59:37.877+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 11:05:43 (UTC).
05-27 19:59:37.877+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 19:59:37.877+0900 E/ALARM_MANAGER(  489): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1178357431] is removed.
05-27 19:59:37.927+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-27 19:59:37.932+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-27 19:59:37.972+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:37.997+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:38.017+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:38.032+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:38.032+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-27 19:59:38.037+0900 W/ALARM_MANAGER(  489): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-27 19:59:38.052+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:38.072+0900 I/AUL     (  489): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-27 19:59:38.072+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464348577, Fri May 27 20:29:37 2016
05-27 19:59:38.072+0900 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1946383859, next duetime: 1464348577
05-27 19:59:38.072+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1946383859)
05-27 19:59:38.072+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464347143), due_time(1464348577)
05-27 19:59:38.072+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-27 19:59:38.072+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 27-5-2016, 11:05:43 (UTC).
05-27 19:59:38.072+0900 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-27 19:59:40.757+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 19:59:40.757+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 19:59:40.757+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 19:59:40.757+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 19:59:40.757+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 19:59:41.597+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 19:59:41.597+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 19:59:41.597+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 19:59:41.597+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 19:59:41.597+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 19:59:41.597+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
05-27 19:59:45.697+0900 I/RESOURCED(  493): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-27 19:59:45.697+0900 I/RESOURCED(  493): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-27 19:59:57.982+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-27 19:59:57.982+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-27 19:59:57.982+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-27 19:59:57.987+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-27 20:00:15.467+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 20:00:15.467+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 20:00:15.467+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:00:15.467+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:00:15.467+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:00:15.477+0900 I/watchface-viewer(  762): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x49225b68]
05-27 20:00:15.492+0900 I/watchface-viewer(  762): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
05-27 20:00:15.722+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-27 20:00:15.727+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-27 20:00:15.727+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 20:00:15.727+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 20:00:15.727+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:00:15.727+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:00:15.727+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:00:15.732+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-27 20:00:15.732+0900 W/WAKEUP-SERVICE( 1132): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-27 20:00:17.147+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:00:17.147+0900 I/efl-extension( 8881): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:00:17.147+0900 I/efl-extension( 8881): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c58728, elm_image, time_stamp : 3051699
05-27 20:00:17.257+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:00:17.257+0900 I/efl-extension( 8881): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-27 20:00:17.262+0900 I/efl-extension( 8881): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c58728, elm_image, time_stamp : 3051810
05-27 20:00:18.417+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-27 20:00:18.417+0900 I/efl-extension( 8881): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-27 20:00:18.417+0900 I/efl-extension( 8881): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c58728, elm_image, time_stamp : 3052969
05-27 20:00:18.807+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 20:00:18.807+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 20:00:18.807+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:00:18.807+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:00:18.807+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:00:19.307+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 20:00:19.307+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 20:00:19.312+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:00:19.312+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:00:19.312+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:00:20.902+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-27 20:00:20.902+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-27 20:00:20.907+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:00:20.907+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:00:20.907+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:00:23.462+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 33 -> 33 1464346823 49
05-27 20:00:23.462+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 1045 395 575
05-27 20:00:23.462+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 0 0 981
05-27 20:00:23.462+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 872 273 480
05-27 20:00:23.462+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 2053 5 1129
05-27 20:00:23.462+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 33 2053 5 1129
05-27 20:00:23.472+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 33 101 76 113
05-27 20:00:23.472+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 33 0 0 0
05-27 20:00:23.472+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 33 122 24 136
05-27 20:00:23.472+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 33 118 5 132
05-27 20:00:23.472+0900 I/RESOURCED(  493): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 33 132 13 147
05-27 20:00:23.537+0900 I/AUL_AMD (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-27 20:00:23.552+0900 I/AUL_AMD (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-27 20:00:23.552+0900 E/AUL_AMD (  492): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-27 20:00:23.552+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 492
05-27 20:00:23.672+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(72) > [_charging_ui_update:72] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
05-27 20:00:23.672+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(76) > [_charging_ui_update:76] [SHOW charging icon] Connected / not Full / not charge -1
05-27 20:00:23.677+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-27 20:00:23.677+0900 W/W_HOME  (  732): dbox.c: _dbus_rotation_cb(1302) > invalid angle, skipped:0
05-27 20:00:23.687+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(72) > [_charging_ui_update:72] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
05-27 20:00:23.687+0900 W/W_INDICATOR(  717): windicator_battery.c: _charging_ui_update(76) > [_charging_ui_update:76] [SHOW charging icon] Connected / not Full / not charge -1
05-27 20:00:23.687+0900 W/W_INDICATOR(  717): windicator_battery.c: _battery_charger_status_changed_cb(170) > [_battery_charger_status_changed_cb:170] TA connected or abnormal
05-27 20:00:23.687+0900 W/W_INDICATOR(  717): windicator_battery.c: _battery_charger_status_changed_cb(186) > [_battery_charger_status_changed_cb:186] Show Moment View to display charging animation
05-27 20:00:23.692+0900 E/W_INDICATOR(  717): windicator_moment_view.c: windicator_moment_view_show(578) > [windicator_moment_view_show:578] Show Moment View : dynamic_layout(0x446a4960), type(1)
05-27 20:00:23.692+0900 W/W_INDICATOR(  717): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(155) > [wnidicator_moment_view_battery_image_update:155] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
05-27 20:00:23.692+0900 W/W_INDICATOR(  717): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(159) > [wnidicator_moment_view_battery_image_update:159] [SHOW charging icon] Connected / not Full / not charge -1
05-27 20:00:23.697+0900 W/AUL_AMD (  492): amd_launch.c: start_process(580) > child process: 9170
05-27 20:00:23.747+0900 W/AUL_AMD (  492): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 9170
05-27 20:00:23.762+0900 I/AUL_AMD (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-27 20:00:23.767+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x0200000d)
05-27 20:00:23.772+0900 I/AUL_AMD (  492): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-27 20:00:23.772+0900 E/AUL_AMD (  492): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-27 20:00:23.772+0900 W/AUL_AMD (  492): amd_launch.c: _start_app(1702) > caller pid : 492
05-27 20:00:23.787+0900 W/AUL_AMD (  492): amd_launch.c: start_process(580) > child process: 9172
05-27 20:00:23.857+0900 E/RESOURCED(  493): proc-main.c: proc_add_app_list(272) > [proc_add_app_list,272] not found previous pai : com.samsung.w-gallery.consumer
05-27 20:00:23.857+0900 E/RESOURCED(  493): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-gallery
05-27 20:00:23.867+0900 W/APP_CORE(  717): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000d
05-27 20:00:23.887+0900 W/AUL_AMD (  492): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 9172
05-27 20:00:23.902+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: RESUME State: PAUSED
05-27 20:00:23.902+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 20:00:23.922+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:23.932+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9170
05-27 20:00:23.957+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-27 20:00:23.957+0900 W/W_HOME  (  732): dbox.c: _dbus_rotation_cb(1299) > angle changed:90
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:AlarmSvc.cpp     L:   80][_HIGH]CAlarmSvc::CAlarmSvc()[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:TransferCtrl.cpp L:   81][_HIGH]CTransferCtrl::CTransferCtrl()[0m
05-27 20:00:24.017+0900 W/MUSIC_TRANSFER( 9172): mt-service.c: main(92) > [33m[TID:9172]   service start[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:SAPClient.cpp    L:   79][_HIGH][TX]CSAPClient::BindPeer(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService nChannel=4444[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:PeerList.cpp     L:  159][_HIGH][TX]CPeerList::CPeerList(0x42e76844)[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:SAPProxy.cpp     L:   48][_HIGH]Creating SAP Proxy Object. 0x42e76880[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:ConnectionInfo.c L:   75][_HIGH][TX]Bind(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService Role=Consumer Channel=4444[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:ReceiverCtrl.cpp L:   65][_HIGH]CReceiverCtrl::CReceiverCtrl()[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:AutoTransfer.cpp L:  104][_HIGH]Set Event Handler. 0x40037bd0[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:SAPClient.cpp    L:   79][_HIGH][RX]CSAPClient::BindPeer(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService nChannel=4444[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:PeerList.cpp     L:  159][_HIGH][RX]CPeerList::CPeerList(0x42e789d4)[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:ConnectionInfo.c L:   75][_HIGH][RX]Bind(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService Role=Consumer Channel=4444[0m
05-27 20:00:24.017+0900 W/WG-CONSUMER( 9170): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
05-27 20:00:24.017+0900 W/MUSIC_TRANSFER( 9172): mt-service.c: _service_app_create(32) > [33m[TID:9172]   [0m
05-27 20:00:24.022+0900 W/WG-CONSUMER( 9170): [34m[F:consumer-app.cpp L:  134][_HIGH]Gallery file consumer SVC is started[0m
05-27 20:00:24.022+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 9170): media_content.c: media_content_connect(860) > [32m[9170]ref count : 0
05-27 20:00:24.022+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 9170): media_content.c: media_content_connect(892) > [32m[9170]ref count changed to: 1
05-27 20:00:24.022+0900 W/WG-CONSUMER( 9170): [34m[F:TransferCtrl.cpp L:  115][_HIGH][TX]Connect to Peer[0m
05-27 20:00:24.032+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:UserNotification L:  185][_HIGH]WIPC Service Created[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:SAPClient.cpp    L:   95][_HIGH][TX]CSAPClient::Connect()[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:ConnectionInfo.c L:  122][_HIGH][TX]CConnection::Connect() State:SM_STATE_INITIATE[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:SAPProxy.cpp     L:  129][_HIGH]CSAPProxy::Connect. Size=0 pConnection=0x42e77878[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:SAPProxy.cpp     L:  332][_HIGH]Not BT/WFD connected. Cur type=16[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:SAPProxy.cpp     L:  172][_HIGH]Device dis-connected. WMS=1 BT=0 [0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
05-27 20:00:24.042+0900 E/WG-CONSUMER( 9170): [31m[F:consumer-app.cpp L:  146][ERROR]TX Connection Error[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:ReceiverCtrl.cpp L:  493][_HIGH][RX]Connect to Peer[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:SAPClient.cpp    L:   95][_HIGH][RX]CSAPClient::Connect()[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:ConnectionInfo.c L:  122][_HIGH][RX]CConnection::Connect() State:SM_STATE_INITIATE[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:SAPProxy.cpp     L:  129][_HIGH]CSAPProxy::Connect. Size=1 pConnection=0x42e78928[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:SAPProxy.cpp     L:  132][_HIGH]  Connection : [TX] LocalAgentID:0 ServiceHandle:0[0m
05-27 20:00:24.042+0900 E/WG-CONSUMER( 9170): [31m[F:SAPProxy.cpp     L:  147][ERROR]Previous pCurrent(0x42e77878) is exist[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:SAPProxy.cpp     L:  332][_HIGH]Not BT/WFD connected. Cur type=16[0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:SAPProxy.cpp     L:  172][_HIGH]Device dis-connected. WMS=1 BT=0 [0m
05-27 20:00:24.042+0900 W/WG-CONSUMER( 9170): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
05-27 20:00:24.047+0900 E/RESOURCED(  493): proc-main.c: proc_add_app_list(272) > [proc_add_app_list,272] not found previous pai : com.samsung.w-music-transfer.consumer
05-27 20:00:24.082+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 9172): media_content.c: media_content_connect(860) > [32m[9172]ref count : 0
05-27 20:00:24.082+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 9172): media_content.c: media_content_connect(892) > [32m[9172]ref count changed to: 1
05-27 20:00:24.112+0900 W/WG-CONSUMER( 9170): [34m[F:consumer-app.cpp L:  191][_HIGH]Gallery consumer SVC on Param. Handle=0x43800478[0m
05-27 20:00:24.112+0900 W/CAPI_APPFW_APP_CONTROL( 9170): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
05-27 20:00:24.112+0900 W/CAPI_APPFW_APP_CONTROL( 9170): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
05-27 20:00:24.112+0900 W/WG-CONSUMER( 9170): [34m[F:consumer-app.cpp L:  298][_HIGH]End of Param[0m
05-27 20:00:24.157+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:24.167+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9172
05-27 20:00:24.167+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:00:24.247+0900 W/MUSIC_TRANSFER( 9172): mt-consumer.c: __mt_consumer_on_service_agent_confirm(294) > [33m[TID:9172]   wStatusCode : [0], uwLocalAgentId : [40994][0m
05-27 20:00:24.247+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 9172): media_content.c: media_content_connect(860) > [32m[9172]ref count : 1
05-27 20:00:24.252+0900 I/CAPI_CONTENT_MEDIA_CONTENT( 9172): media_content.c: media_content_connect(892) > [32m[9172]ref count changed to: 2
05-27 20:00:24.277+0900 W/MUSIC_TRANSFER( 9172): mt-service.c: _service_app_control(74) > [33m[TID:9172]   [0m
05-27 20:00:24.277+0900 W/CAPI_APPFW_APP_CONTROL( 9172): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
05-27 20:00:24.277+0900 W/MUSIC_TRANSFER( 9172): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:9172]   uwLocalAgentId : [40994], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-27 20:00:24.277+0900 W/MUSIC_TRANSFER( 9172): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:9172]   wStatusCode error : [1]!!![0m
05-27 20:00:25.367+0900 W/MUSIC_TRANSFER( 9172): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:9172]   uwLocalAgentId : [40994], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-27 20:00:25.367+0900 W/MUSIC_TRANSFER( 9172): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:9172]   wStatusCode error : [1]!!![0m
05-27 20:00:25.697+0900 E/W_INDICATOR(  717): windicator_moment_view.c: windicator_moment_view_hide(634) > [windicator_moment_view_hide:634] Hide Moment View : dynamic_layout(0x446a4960),Type(1)
05-27 20:00:25.702+0900 E/W_INDICATOR(  717): windicator_connection.c: windi_connection_pause(1552) > [windi_connection_pause:1552] There is no handle
05-27 20:00:25.912+0900 E/W_INDICATOR(  717): windicator_util.c: windi_x_input_event_unregister(223) > [windi_x_input_event_unregister:223] not registered
05-27 20:00:26.017+0900 W/APP_CORE(  717): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000d
05-27 20:00:26.017+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
05-27 20:00:26.017+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-27 20:00:27.442+0900 W/MUSIC_TRANSFER( 9172): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:9172]   uwLocalAgentId : [40994], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-27 20:00:27.442+0900 W/MUSIC_TRANSFER( 9172): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:9172]   wStatusCode error : [1]!!![0m
05-27 20:00:31.027+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
05-27 20:00:31.467+0900 W/MUSIC_TRANSFER( 9172): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:9172]   uwLocalAgentId : [40994], pPeerAgent : [(nil)], wStatusCode : [1][0m
05-27 20:00:31.467+0900 W/MUSIC_TRANSFER( 9172): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:9172]   wStatusCode error : [1]!!![0m
05-27 20:00:32.222+0900 E/PKGMGR_SERVER( 9248): pkgmgr-server.c: main(2131) > package manager server start
05-27 20:00:32.297+0900 E/PKGMGR_SERVER( 9248): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_-792650905], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[2rRi8egIezHKXE7Vxi5GbHSA8LI=], backend_flag=[0]
05-27 20:00:32.307+0900 E/PKGMGR_SERVER( 9250): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-27 20:00:32.312+0900 E/PKGMGR  ( 9241): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-27 20:00:32.372+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:32.377+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8881
05-27 20:00:32.382+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 12
05-27 20:00:32.382+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 5
05-27 20:00:32.387+0900 I/APP_CORE( 8881): appcore-efl.c: __do_app(429) > [APP 8881] Event: TERMINATE State: RUNNING
05-27 20:00:32.387+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 22
05-27 20:00:32.387+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(890) > app status : 4
05-27 20:00:32.387+0900 W/AUL_AMD (  492): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(8881), cmd(4)
05-27 20:00:32.392+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:32.402+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8881
05-27 20:00:32.457+0900 I/APP_CORE( 8881): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-27 20:00:32.457+0900 I/CAPI_APPFW_APPLICATION( 8881): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-27 20:00:32.467+0900 W/AUL_AMD (  492): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-27 20:00:32.467+0900 W/AUL_AMD (  492): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-27 20:00:32.472+0900 I/efl-extension( 8881): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 20:00:32.472+0900 I/efl-extension( 8881): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x44c58728], circle_obj[0x44cede18]!
05-27 20:00:32.472+0900 I/efl-extension( 8881): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x442fcae0 = w: 0 h: 0  obj 0x44c58728 w: 360 h: 360
05-27 20:00:32.477+0900 I/efl-extension( 8881): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-27 20:00:32.482+0900 I/efl-extension( 8881): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44c5f580 is freed
05-27 20:00:32.482+0900 I/efl-extension( 8881): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44c659f8 is freed
05-27 20:00:32.497+0900 I/efl-extension( 8881): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c06858, obj: 0x44c06858
05-27 20:00:32.497+0900 I/efl-extension( 8881): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-27 20:00:32.497+0900 I/efl-extension( 8881): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-27 20:00:32.497+0900 I/efl-extension( 8881): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-27 20:00:32.497+0900 I/efl-extension( 8881): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-27 20:00:32.502+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:32.512+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8881
05-27 20:00:32.512+0900 I/efl-extension( 8881): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-27 20:00:32.517+0900 I/efl-extension( 8881): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x442fcae0 is freed
05-27 20:00:32.517+0900 I/efl-extension( 8881): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c58728
05-27 20:00:32.517+0900 I/efl-extension( 8881): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-27 20:00:32.517+0900 I/efl-extension( 8881): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c06858, elm_genlist, func : 0x4011adfd
05-27 20:00:32.517+0900 I/efl-extension( 8881): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-27 20:00:32.527+0900 I/MALI    ( 8881): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f5f028] swap changed from sync to async
05-27 20:00:32.527+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-27 20:00:32.532+0900 W/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-27 20:00:32.532+0900 I/WATCH_CORE(  762): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-27 20:00:32.532+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:00:32.532+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:00:32.532+0900 I/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-27 20:00:32.532+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-27 20:00:32.532+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:00:32.532+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:00:32.537+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:00:32.537+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-27 20:00:32.552+0900 I/MALI    ( 8881): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-27 20:00:32.552+0900 I/MALI    ( 8881): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=8881   close drm_fd=25 
05-27 20:00:32.552+0900 I/MALI    ( 8881): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-27 20:00:32.557+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-27 20:00:32.562+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-27 20:00:32.562+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:00:32.562+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-27 20:00:32.562+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-27 20:00:32.562+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-27 20:00:32.562+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-27 20:00:32.562+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-27 20:00:32.562+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:00:32.567+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:00:32.567+0900 W/W_HOME  (  732): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
05-27 20:00:32.567+0900 W/W_HOME  (  732): main.c: home_resume(733) > clock/widget resumed
05-27 20:00:32.567+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-27 20:00:32.577+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-27 20:00:32.577+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-27 20:00:32.577+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-27 20:00:32.577+0900 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4469) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-27 20:00:32.597+0900 W/WATCH_CORE(  762): appcore-watch.c: __widget_resume(1012) > widget_resume
05-27 20:00:32.597+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppResume(721) > 
05-27 20:00:32.597+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:00:32.597+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:00:32.617+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:32.642+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8881
05-27 20:00:32.642+0900 I/UXT     ( 8881): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-27 20:00:32.742+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:32.747+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8881
05-27 20:00:32.802+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:00:32.802+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:00:32.852+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:32.887+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8881
05-27 20:00:32.987+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:33.002+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8881
05-27 20:00:33.007+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:00:33.007+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:00:33.042+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-27 20:00:33.102+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:33.112+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8881
05-27 20:00:33.207+0900 I/CAPI_WATCH_APPLICATION(  762): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-27 20:00:33.207+0900 E/watchface-loader(  762): watchface-loader.cpp: OnAppTimeTick(740) > 
05-27 20:00:33.212+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 14
05-27 20:00:33.227+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-27 20:00:33.232+0900 E/PKGMGR_SERVER( 9250): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-27 20:00:33.277+0900 E/PKGMGR_SERVER( 9248): pkgmgr-server.c: sighandler(409) > child NORMAL exit [9250]
05-27 20:00:33.297+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(646) > __request_handler: 23
05-27 20:00:33.302+0900 W/AUL_AMD (  492): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-27 20:00:33.302+0900 W/AUL_AMD (  492): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 8881
05-27 20:00:33.302+0900 W/AUL_AMD (  492): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-27 20:00:33.302+0900 E/AUL     ( 9255): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-27 20:00:33.307+0900 I/AUL_AMD (  492): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8881
05-27 20:00:33.347+0900 W/CRASH_MANAGER( 9253): worker.c: worker_job(1199) > 1108881706831146434683
