S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 15724
Date: 2016-05-09 20:22:42+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 15724, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x4390a638
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x44bb3ac8, r5   = 0x4390a638
r6   = 0x448bdd78, r7   = 0xbef29330
r8   = 0x00000000, r9   = 0x44bb9458
r10  = 0x44bbcd48, fp   = 0x00000001
ip   = 0x00000000, sp   = 0xbef292f0
lr   = 0x40263591, pc   = 0x40001bb0
cpsr = 0x60000030

Memory Information
MemTotal:   490584 KB
MemFree:     16224 KB
Buffers:     47696 KB
Cached:     153908 KB
VmPeak:     108124 KB
VmSize:     104056 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22232 KB
VmRSS:       22228 KB
VmData:      43488 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       54904 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 15724 TID = 15724
15724 15729 15730 15731 

Maps Information
40000000 40005000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
4000c000 4000d000 rwxp /opt/usr/apps/org.example.ph1/bin/ph1
4000d000 4002a000 r-xp /lib/ld-2.13.so
40031000 40032000 r-xp /lib/ld-2.13.so
40032000 40033000 rwxp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
4003f000 40040000 rwxp /usr/lib/libsys-assert.so
40040000 4004b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40053000 40054000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40055000 40069000 r-xp /lib/libpthread-2.13.so
40070000 40071000 r-xp /lib/libpthread-2.13.so
40071000 40072000 rwxp /lib/libpthread-2.13.so
40074000 40078000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4007f000 40080000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
40080000 4008d000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
40094000 40095000 rwxp /usr/lib/libcapi-network-connection.so.1.0.51
40095000 4009a000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
400a1000 400a2000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
400a2000 400aa000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
400aa000 400ab000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
400ab000 400ad000 r-xp /usr/lib/libdlog.so.0.0.0
400b4000 400b5000 rwxp /usr/lib/libdlog.so.0.0.0
400b5000 400d6000 r-xp /usr/lib/libefl-extension.so.0.1.0
400dd000 400de000 rwxp /usr/lib/libefl-extension.so.0.1.0
400de000 40218000 r-xp /usr/lib/libelementary.so.1.7.99
4021f000 40227000 rwxp /usr/lib/libelementary.so.1.7.99
4022e000 402fc000 r-xp /usr/lib/libevas.so.1.7.99
40304000 4030e000 rwxp /usr/lib/libevas.so.1.7.99
40321000 4043c000 r-xp /lib/libc-2.13.so
40444000 40446000 r-xp /lib/libc-2.13.so
40446000 40447000 rwxp /lib/libc-2.13.so
4044a000 40455000 r-xp /lib/libunwind.so.8.0.1
4045c000 4045d000 rwxp /lib/libunwind.so.8.0.1
40482000 40484000 r-xp /lib/libdl-2.13.so
4048b000 4048c000 r-xp /lib/libdl-2.13.so
4048c000 4048d000 rwxp /lib/libdl-2.13.so
4048d000 40495000 r-xp /lib/libgcc_s-4.6.so.1
40495000 40496000 rwxp /lib/libgcc_s-4.6.so.1
40496000 4049a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
404a2000 404a3000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
404a3000 404a5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
404ad000 404ae000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
404ae000 404b3000 r-xp /usr/lib/libappcore-efl.so.1.1
404ba000 404bb000 rwxp /usr/lib/libappcore-efl.so.1.1
404bb000 404c0000 r-xp /usr/lib/libappcore-common.so.1.1
404c7000 404c8000 rwxp /usr/lib/libappcore-common.so.1.1
404c8000 404d4000 r-xp /usr/lib/libaul.so.0.1.0
404dc000 404dd000 rwxp /usr/lib/libaul.so.0.1.0
404de000 40500000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40507000 40508000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
40508000 40549000 r-xp /usr/lib/libeina.so.1.7.99
40550000 40552000 rwxp /usr/lib/libeina.so.1.7.99
40552000 40556000 r-xp /usr/lib/libvconf.so.0.2.45
4055d000 4055e000 rwxp /usr/lib/libvconf.so.0.2.45
4055e000 40575000 r-xp /usr/lib/libnetwork.so.0.0.0
4057c000 4057d000 rwxp /usr/lib/libnetwork.so.0.0.0
4057d000 4064d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4064d000 4064e000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
4064e000 40653000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4065a000 4065b000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
4065b000 4072e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40735000 40739000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
40739000 4076d000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40774000 40776000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
40776000 407c6000 r-xp /usr/lib/libecore_x.so.1.7.99
407c6000 407c8000 rwxp /usr/lib/libecore_x.so.1.7.99
407c8000 407ea000 r-xp /usr/lib/libecore_evas.so.1.7.99
407f1000 407f3000 rwxp /usr/lib/libecore_evas.so.1.7.99
407f3000 4081b000 r-xp /usr/lib/libfontconfig.so.1.8.0
4081b000 4081c000 rwxp /usr/lib/libfontconfig.so.1.8.0
4081c000 408e8000 r-xp /usr/lib/libxml2.so.2.7.8
408ef000 408f4000 rwxp /usr/lib/libxml2.so.2.7.8
408f5000 40907000 r-xp /usr/lib/libefl-assist.so.0.1.0
4090e000 4090f000 rwxp /usr/lib/libefl-assist.so.0.1.0
4090f000 40978000 r-xp /lib/libm-2.13.so
4097f000 40980000 r-xp /lib/libm-2.13.so
40980000 40981000 rwxp /lib/libm-2.13.so
40981000 40998000 r-xp /usr/lib/libecore.so.1.7.99
409a0000 409a1000 rwxp /usr/lib/libecore.so.1.7.99
409af000 40a0c000 r-xp /usr/lib/libedje.so.1.7.99
40a14000 40a16000 rwxp /usr/lib/libedje.so.1.7.99
40a16000 40ace000 r-xp /usr/lib/libcairo.so.2.11200.14
40ad5000 40ad8000 rwxp /usr/lib/libcairo.so.2.11200.14
40ad9000 40bba000 r-xp /usr/lib/libX11.so.6.3.0
40bc1000 40bc5000 rwxp /usr/lib/libX11.so.6.3.0
40bc5000 40bce000 r-xp /usr/lib/libXi.so.6.1.0
40bd5000 40bd6000 rwxp /usr/lib/libXi.so.6.1.0
40bd6000 40bef000 r-xp /usr/lib/libeet.so.1.7.99
40bf7000 40bf8000 rwxp /usr/lib/libeet.so.1.7.99
40c00000 40c05000 r-xp /usr/lib/libecore_file.so.1.7.99
40c0c000 40c0d000 rwxp /usr/lib/libecore_file.so.1.7.99
40c0d000 40c1e000 r-xp /usr/lib/libecore_input.so.1.7.99
40c25000 40c26000 rwxp /usr/lib/libecore_input.so.1.7.99
40c26000 40c2f000 r-xp /usr/lib/libedbus.so.1.7.99
40c36000 40c37000 rwxp /usr/lib/libedbus.so.1.7.99
40c37000 40c61000 r-xp /usr/lib/libdbus-1.so.3.8.12
40c69000 40c6a000 rwxp /usr/lib/libdbus-1.so.3.8.12
40c6a000 40c84000 r-xp /usr/lib/libecore_con.so.1.7.99
40c8b000 40c8c000 rwxp /usr/lib/libecore_con.so.1.7.99
40c8d000 40ca0000 r-xp /usr/lib/libfribidi.so.0.3.1
40ca7000 40ca8000 rwxp /usr/lib/libfribidi.so.0.3.1
40ca8000 40ce5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40cec000 40ced000 rwxp /usr/lib/libharfbuzz.so.0.940.0
40cee000 40d44000 r-xp /usr/lib/libfreetype.so.6.11.3
40d4c000 40d50000 rwxp /usr/lib/libfreetype.so.6.11.3
40d50000 40da6000 r-xp /usr/lib/libpixman-1.so.0.28.2
40dae000 40db3000 rwxp /usr/lib/libpixman-1.so.0.28.2
40db3000 40db9000 r-xp /usr/lib/libappsvc.so.0.1.0
40dc0000 40dc1000 rwxp /usr/lib/libappsvc.so.0.1.0
40dc1000 40dc4000 r-xp /usr/lib/libbundle.so.0.1.22
40dcb000 40dcc000 rwxp /usr/lib/libbundle.so.0.1.22
40dcc000 40dd2000 r-xp /usr/lib/libecore_imf.so.1.7.99
40dd9000 40dda000 rwxp /usr/lib/libecore_imf.so.1.7.99
40dda000 40ddc000 r-xp /usr/lib/libiniparser.so.0
40de4000 40de5000 rwxp /usr/lib/libiniparser.so.0
40de5000 40dfc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40e03000 40e04000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
40e04000 40e09000 r-xp /usr/lib/libxdgmime.so.1.1.0
40e10000 40e11000 rwxp /usr/lib/libxdgmime.so.1.1.0
40e11000 40e4d000 r-xp /usr/lib/libsystemd.so.0.4.0
40e54000 40e55000 r-xp /usr/lib/libsystemd.so.0.4.0
40e55000 40e56000 rwxp /usr/lib/libsystemd.so.0.4.0
40e56000 40e59000 r-xp /usr/lib/libproc-stat.so.0.2.86
40e60000 40e61000 rwxp /usr/lib/libproc-stat.so.0.2.86
40e61000 40e77000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40e7e000 40e7f000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
40e7f000 40ef4000 r-xp /usr/lib/libsqlite3.so.0.8.6
40efb000 40efe000 rwxp /usr/lib/libsqlite3.so.0.8.6
40efe000 40f04000 r-xp /lib/librt-2.13.so
40f0b000 40f0c000 r-xp /lib/librt-2.13.so
40f0c000 40f0d000 rwxp /lib/librt-2.13.so
40f0d000 40f3e000 r-xp /usr/lib/libmdm.so.1.1.85
40f45000 40f46000 rwxp /usr/lib/libmdm.so.1.1.85
40f46000 40f47000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40f4e000 40f4f000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
40f4f000 40f54000 r-xp /usr/lib/libffi.so.5.0.10
40f5b000 40f5c000 rwxp /usr/lib/libffi.so.5.0.10
40f5c000 40f5e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40f65000 40f66000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
40f66000 40f7c000 r-xp /lib/libz.so.1.2.5
40f83000 40f84000 rwxp /lib/libz.so.1.2.5
40f84000 40f94000 r-xp /lib/libresolv-2.13.so
40f94000 40f95000 r-xp /lib/libresolv-2.13.so
40f95000 40f96000 rwxp /lib/libresolv-2.13.so
40f98000 40f9f000 r-xp /usr/lib/libXcursor.so.1.0.2
40fa6000 40fa7000 rwxp /usr/lib/libXcursor.so.1.0.2
40fa7000 40fa9000 r-xp /usr/lib/libXdamage.so.1.1.0
40fb0000 40fb1000 rwxp /usr/lib/libXdamage.so.1.1.0
40fb1000 40fb3000 r-xp /usr/lib/libXcomposite.so.1.0.0
40fba000 40fbb000 rwxp /usr/lib/libXcomposite.so.1.0.0
40fbb000 40fbd000 r-xp /usr/lib/libXgesture.so.7.0.0
40fc4000 40fc5000 rwxp /usr/lib/libXgesture.so.7.0.0
40fc5000 40fc8000 r-xp /usr/lib/libXfixes.so.3.1.0
40fcf000 40fd0000 rwxp /usr/lib/libXfixes.so.3.1.0
40fd0000 40fd1000 r-xp /usr/lib/libXinerama.so.1.0.0
40fd9000 40fda000 rwxp /usr/lib/libXinerama.so.1.0.0
40fda000 40fe0000 r-xp /usr/lib/libXrandr.so.2.2.0
40fe7000 40fe8000 rwxp /usr/lib/libXrandr.so.2.2.0
40fe8000 40fee000 r-xp /usr/lib/libXrender.so.1.3.0
40ff5000 40ff6000 rwxp /usr/lib/libXrender.so.1.3.0
40ff6000 40ffa000 r-xp /usr/lib/libXtst.so.6.1.0
41001000 41002000 rwxp /usr/lib/libXtst.so.6.1.0
41002000 4100c000 r-xp /usr/lib/libXext.so.6.4.0
41014000 41015000 rwxp /usr/lib/libXext.so.6.4.0
41016000 4101b000 r-xp /usr/lib/libecore_fb.so.1.7.99
41022000 41024000 rwxp /usr/lib/libecore_fb.so.1.7.99
41024000 41028000 r-xp /usr/lib/libecore_ipc.so.1.7.99
41030000 41031000 rwxp /usr/lib/libecore_ipc.so.1.7.99
41031000 41034000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4103b000 4103c000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
4103c000 41052000 r-xp /lib/libexpat.so.1.5.2
4105a000 4105c000 rwxp /lib/libexpat.so.1.5.2
4105c000 4106e000 r-xp /usr/lib/libtts.so
41075000 41076000 rwxp /usr/lib/libtts.so
41077000 41098000 r-xp /usr/lib/libui-extension.so.0.1.0
410a0000 410a1000 rwxp /usr/lib/libui-extension.so.0.1.0
410a1000 410a8000 r-xp /usr/lib/libtbm.so.1.0.0
410af000 410b0000 rwxp /usr/lib/libtbm.so.1.0.0
410b0000 410b7000 r-xp /usr/lib/libembryo.so.1.7.99
410be000 410bf000 rwxp /usr/lib/libembryo.so.1.7.99
410bf000 410d6000 r-xp /usr/lib/liblua-5.1.so
410de000 410df000 rwxp /usr/lib/liblua-5.1.so
410df000 410e0000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
410e7000 410e8000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
410e9000 410f7000 r-xp /usr/lib/libGLESv2.so.2.0
410ff000 41100000 rwxp /usr/lib/libGLESv2.so.2.0
41100000 41118000 r-xp /usr/lib/libpng12.so.0.50.0
4111f000 41120000 rwxp /usr/lib/libpng12.so.0.50.0
41120000 41121000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41129000 4112a000 rwxp /usr/lib/libxcb-shm.so.0.0.0
4112a000 41130000 r-xp /usr/lib/libxcb-render.so.0.0.0
41137000 41138000 rwxp /usr/lib/libxcb-render.so.0.0.0
41138000 4114b000 r-xp /usr/lib/libxcb.so.1.1.0
41153000 41154000 rwxp /usr/lib/libxcb.so.1.1.0
41154000 41157000 r-xp /usr/lib/libEGL.so.1.4
4115e000 4115f000 rwxp /usr/lib/libEGL.so.1.4
41160000 41183000 r-xp /usr/lib/libjpeg.so.8.0.2
4118a000 4118b000 rwxp /usr/lib/libjpeg.so.8.0.2
4119b000 411df000 r-xp /usr/lib/libcurl.so.4.3.0
411e6000 411e8000 rwxp /usr/lib/libcurl.so.4.3.0
411e8000 411ee000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
411f6000 411f7000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
411f7000 4120f000 r-xp /usr/lib/liblzma.so.5.0.3
41216000 41217000 rwxp /usr/lib/liblzma.so.5.0.3
41218000 41294000 r-xp /usr/lib/libgcrypt.so.20.0.3
4129b000 412a0000 rwxp /usr/lib/libgcrypt.so.20.0.3
412a0000 412a2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
412aa000 412ab000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
412ab000 412ad000 r-xp /usr/lib/journal/libjournal.so.0.1.0
412b4000 412b5000 rwxp /usr/lib/journal/libjournal.so.0.1.0
412b5000 412bd000 r-xp /usr/lib/libmdm-common.so.1.0.89
412bd000 412be000 rwxp /usr/lib/libmdm-common.so.1.0.89
412bf000 413fc000 r-xp /usr/lib/libicui18n.so.51.1
41404000 4140c000 rwxp /usr/lib/libicui18n.so.51.1
4140c000 414f0000 r-xp /usr/lib/libicuuc.so.51.1
414f7000 41501000 rwxp /usr/lib/libicuuc.so.51.1
41505000 41508000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4150f000 41510000 rwxp /usr/lib/libcapi-media-image-util.so.0.3.5
41510000 41513000 r-xp /usr/lib/libsmack.so.1.0.0
4151a000 4151b000 rwxp /usr/lib/libsmack.so.1.0.0
4151b000 415af000 r-xp /usr/lib/libstdc++.so.6.0.16
415b7000 415ba000 r-xp /usr/lib/libstdc++.so.6.0.16
415ba000 415bc000 rwxp /usr/lib/libstdc++.so.6.0.16
415c3000 415cb000 r-xp /usr/lib/libdrm.so.2.4.0
415d2000 415d3000 rwxp /usr/lib/libdrm.so.2.4.0
415d3000 415d5000 r-xp /usr/lib/libXau.so.6.0.0
415dc000 415dd000 rwxp /usr/lib/libXau.so.6.0.0
415dd000 415e6000 r-xp /usr/lib/libcares.so.2.1.0
415ee000 415ef000 rwxp /usr/lib/libcares.so.2.1.0
415ef000 4161d000 r-xp /usr/lib/libidn.so.11.5.44
41624000 41625000 rwxp /usr/lib/libidn.so.11.5.44
41625000 41672000 r-xp /usr/lib/libssl.so.1.0.0
41679000 4167e000 rwxp /usr/lib/libssl.so.1.0.0
4167f000 41827000 r-xp /usr/lib/libcrypto.so.1.0.0
41827000 4183c000 rwxp /usr/lib/libcrypto.so.1.0.0
41840000 4184b000 r-xp /usr/lib/libgpg-error.so.0.15.0
41852000 41853000 rwxp /usr/lib/libgpg-error.so.0.15.0
41853000 42dd2000 r-xp /usr/lib/libicudata.so.51.1
42dd9000 42dda000 rwxp /usr/lib/libicudata.so.51.1
42dda000 42ddf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42de7000 42de8000 rwxp /usr/lib/libmmutil_jpeg.so.0.0.0
42de8000 42ded000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42df4000 42df5000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
42df6000 42df8000 r-xp /usr/lib/libdri2.so.0.0.0
42dff000 42e00000 rwxp /usr/lib/libdri2.so.0.0.0
42e00000 42e21000 r-xp /usr/lib/libexif.so.12.3.3
42e28000 42e34000 rwxp /usr/lib/libexif.so.12.3.3
42e34000 42e39000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
42e40000 42e41000 rwxp /usr/lib/libcapi-media-tool.so.0.1.5
42f48000 43012000 r-xp /usr/lib/libCOREGL.so.4.0
4301a000 4301c000 rwxp /usr/lib/libCOREGL.so.4.0
43025000 43824000 rwxp [stack:15729]
43824000 43848000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4384f000 43851000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
43851000 4387e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
43885000 43886000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
43886000 438a3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
438ab000 438ac000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
438ac000 438ae000 r-xp /usr/lib/libiri.so
438b5000 438b6000 rwxp /usr/lib/libiri.so
438b6000 438b9000 r-xp /lib/libcap.so.2.21
438c0000 438c1000 rwxp /lib/libcap.so.2.21
438c1000 438c8000 r-xp /lib/libcrypt-2.13.so
438cf000 438d0000 r-xp /lib/libcrypt-2.13.so
438d0000 438d1000 rwxp /lib/libcrypt-2.13.so
438f9000 438fc000 rwxp [stack:15731]
438fc000 43900000 rwxs /dev/mali
43a00000 43acf000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43ad6000 43ae5000 rwxp /usr/lib/libscim-1.0.so.8.2.3
43ae5000 43ae8000 r-xp /lib/libattr.so.1.1.0
43aef000 43af0000 rwxp /lib/libattr.so.1.1.0
43af0000 43afa000 r-xp /lib/libnss_files-2.13.so
43b01000 43b02000 r-xp /lib/libnss_files-2.13.so
43b02000 43b03000 rwxp /lib/libnss_files-2.13.so
43b03000 43d03000 r-xp /usr/share/locale/locale-archive
43d03000 43e34000 r-xp /usr/share/locale/locale-archive
43e34000 43eab000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
43eb3000 43eb5000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
43ebb000 44003000 r-xp /usr/lib/egl/libMali.so
44003000 44008000 rwxp /usr/lib/egl/libMali.so
44008000 4400c000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44013000 44014000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44014000 4401c000 rwxs /dev/mali
4401d000 44020000 r-xp /usr/lib/libnative-buffer.so.0.1.0
44027000 44028000 rwxp /usr/lib/libnative-buffer.so.0.1.0
44029000 44828000 rwxp [stack:15730]
44828000 44830000 rwxs /dev/mali
44830000 44844000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
44944000 44948000 rwxs /dev/mali
44948000 4494c000 rwxs /dev/mali
4494c000 44954000 rwxs /dev/mali
44954000 4495c000 rwxs /dev/mali
4495c000 4495e000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
4495e000 44afd000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
44bfd000 44c14000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44c1c000 44c21000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44c21000 44c23000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44c2a000 44c2b000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45c2b000 45c2e000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
45c2e000 45c32000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
45c32000 45c41000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
45c41000 45ccc000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
45ccc000 45d0c000 rwxs /dev/mali
45e0c000 45e4c000 rwxs /dev/mali
45e4c000 45e4f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45e56000 45e57000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45e57000 45e58000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
45e5f000 45e60000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
45e60000 45e84000 rwxs /dev/mali
45e84000 45e88000 rwxs /dev/mali
45e88000 45eac000 rwxs /dev/mali
45eac000 45eb0000 rwxs /dev/mali
45eb0000 45ed4000 rwxs /dev/mali
45ed4000 45ed8000 rwxs /dev/mali
45fd8000 45fdc000 rwxs /dev/mali
45fdc000 45fec000 rwxs /dev/mali
45fec000 46078000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
46078000 46100000 rwxs /dev/mali
46100000 46188000 rwxs /dev/mali
46188000 46198000 rwxs /dev/mali
4619c000 461ac000 rwxs /dev/mali
461ac000 461d0000 rwxs /dev/mali
461d0000 461d4000 rwxs /dev/mali
461d4000 4625c000 rwxs /dev/mali
4625c000 46264000 rwxs /dev/mali
46264000 4626c000 rwxs /dev/mali
4626c000 462ac000 rwxs /dev/mali
462ac000 462d0000 rwxs /dev/mali
462d0000 462d4000 rwxs /dev/mali
462d4000 462e4000 rwxs /dev/mali
462e4000 46308000 rwxs /dev/mali
46308000 46318000 rwxs /dev/mali
46318000 4633c000 rwxs /dev/mali
4633c000 4633d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
46344000 46345000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4635a000 46361000 r-xp /usr/lib/libfeedback.so.0.1.4
46369000 4636a000 rwxp /usr/lib/libfeedback.so.0.1.4
4636a000 4636b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
46372000 46373000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
46373000 46375000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
4637c000 4637d000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
4637d000 46387000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
4638e000 4638f000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
4638f000 46396000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4639d000 4639e000 rwxp /usr/lib/libmmfcommon.so.0.0.0
4639e000 463b4000 r-xp /usr/lib/libmmfsound.so.0.1.0
463bc000 463bd000 rwxp /usr/lib/libmmfsound.so.0.1.0
463c6000 463cb000 r-xp /usr/lib/libmmfsession.so.0.0.0
463d2000 463d3000 rwxp /usr/lib/libmmfsession.so.0.0.0
463d3000 463dd000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
463e5000 463e6000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
463e9000 463ed000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
463f5000 463f6000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
463f6000 4640c000 r-xp /usr/lib/libavsysaudio.so.0.0.1
46414000 46415000 rwxp /usr/lib/libavsysaudio.so.0.0.1
46415000 4641a000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
46421000 46422000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
46422000 46425000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4642c000 4642d000 rwxp /usr/lib/libpulse-simple.so.0.0.4
4642d000 4648e000 r-xp /usr/lib/libasound.so.2.0.0
46495000 46498000 rwxp /usr/lib/libasound.so.2.0.0
46498000 464d0000 r-xp /usr/lib/libpulse.so.0.16.2
464d0000 464d1000 rwxp /usr/lib/libpulse.so.0.16.2
464d1000 464d4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
464db000 464dc000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
464dc000 464e9000 r-xp /usr/lib/libail.so.0.1.0
464f1000 464f2000 rwxp /usr/lib/libail.so.0.1.0
464f2000 46502000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
46502000 46506000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
46523000 4652b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
46532000 46533000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
4653a000 4653d000 r-xp /usr/lib/libcompress.so.0.2.0
46544000 46545000 rwxp /usr/lib/libcompress.so.0.2.0
46545000 4654a000 r-xp /usr/lib/libjson.so.0.0.1
46551000 46552000 rwxp /usr/lib/libjson.so.0.0.1
46552000 4659a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4659a000 4659b000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4659b000 465de000 r-xp /usr/lib/libsndfile.so.1.0.25
465e5000 465e7000 rwxp /usr/lib/libsndfile.so.1.0.25
465eb000 4660d000 r-xp /usr/lib/libvorbis.so.0.4.3
46614000 46615000 rwxp /usr/lib/libvorbis.so.0.4.3
46615000 46619000 r-xp /usr/lib/libogg.so.0.7.1
46620000 46621000 rwxp /usr/lib/libogg.so.0.7.1
bef09000 bef2a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:15724)
Call Stack Count: 1
 0: _auto_connect_button_click_cb + 0x13 (0x40001bb0) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x1bb0
End of Call Stack

Package Information
Package Name: org.example.ph1
Package ID : org.example.ph1
Version: 1.0.0
Package Type: rpm
App Name: pHp
App ID: org.example.ph1
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
_postponed_job(1703) > No postponed update.
05-09 20:22:38.693+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4469) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-09 20:22:38.713+0900 W/WATCH_CORE(  722): appcore-watch.c: __widget_resume(1012) > widget_resume
05-09 20:22:38.713+0900 E/watchface-loader(  722): watchface-loader.cpp: OnAppResume(721) > 
05-09 20:22:38.713+0900 I/CAPI_WATCH_APPLICATION(  722): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-09 20:22:38.713+0900 E/watchface-loader(  722): watchface-loader.cpp: OnAppTimeTick(740) > 
05-09 20:22:38.718+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  990): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-09 20:22:38.718+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  990): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-09 20:22:38.718+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  990): preference.c: preference_get_double(1214) > preference_get_double(990) : pedometer_inactive_period error
05-09 20:22:38.718+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  990): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-09 20:22:38.718+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  990): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-09 20:22:38.718+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  990): preference.c: preference_get_double(1214) > preference_get_double(990) : inactive_10min_precaution_millisec error
05-09 20:22:38.718+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  990): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-09 20:22:38.718+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  990): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-09 20:22:38.718+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(  990): preference.c: preference_get_double(1214) > preference_get_double(990) : inactive_before_10min_precaution_millisec error
05-09 20:22:38.723+0900 I/MALI    (  680): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-09 20:22:38.828+0900 E/WMS     (  484): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-09 20:22:38.828+0900 E/WMS     (  484): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-09 20:22:38.828+0900 E/WMS     (  484): ==========
05-09 20:22:38.828+0900 E/WMS     (  484): ##WMS SEND : mgr_gear_wear_onoff_req
05-09 20:22:38.828+0900 E/WMS     (  484): ==========
05-09 20:22:38.828+0900 E/WMS     (  484): wms_msg_broker.c: wms_msg_broker_send(1746) > No service connection to host. Skipping this message.
05-09 20:22:38.828+0900 W/W_HOME  (  680): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-09 20:22:38.828+0900 W/W_HOME  (  680): gesture.c: _manual_render_enable(133) > 0
05-09 20:22:38.893+0900 I/CAPI_WATCH_APPLICATION(  722): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-09 20:22:38.893+0900 E/watchface-loader(  722): watchface-loader.cpp: OnAppTimeTick(740) > 
05-09 20:22:39.078+0900 I/CAPI_WATCH_APPLICATION(  722): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-09 20:22:39.078+0900 E/watchface-loader(  722): watchface-loader.cpp: OnAppTimeTick(740) > 
05-09 20:22:39.143+0900 I/efl-extension(  680): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-09 20:22:39.143+0900 I/efl-extension(  680): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45c960a0, elm_box, time_stamp : 8059348
05-09 20:22:39.143+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_rotary_cb(568) > Pass rotary event to home.
05-09 20:22:39.153+0900 W/W_HOME  (  680): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0x45ce35f0 -> 360 0 0x466678d8
05-09 20:22:39.158+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45c93b20 : elm_scroller] rotary callabck is called.
05-09 20:22:39.158+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45c93b20 : elm_scroller] block(2)
05-09 20:22:39.158+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45c93b20 : elm_scroller] scroll_locked_x(0), scroll_locked_y(0)
05-09 20:22:39.158+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45c93b20 : elm_scroller] content size (w, h)(2520, 360)
05-09 20:22:39.158+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45c93b20 : elm_scroller] viewport size (w, h)(360, 360)
05-09 20:22:39.158+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45c93b20 : elm_scroller] CurrentPage(1) DetentCount(1)
05-09 20:22:39.158+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93b20 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-09 20:22:39.158+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93b20 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-09 20:22:39.158+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93b20 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-09 20:22:39.158+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45c93b20 : elm_scroller] bring in 2 page
05-09 20:22:39.158+0900 W/W_HOME  (  680): event_manager.c: _home_scroll_cb(564) > scroll,start
05-09 20:22:39.168+0900 W/W_HOME  (  680): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
05-09 20:22:39.168+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-09 20:22:39.168+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.168+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.173+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-09 20:22:39.183+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.183+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.203+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.203+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.208+0900 W/W_HOME  (  680): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
05-09 20:22:39.218+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.218+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.233+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.233+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.253+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.253+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.263+0900 I/CAPI_WATCH_APPLICATION(  722): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-09 20:22:39.263+0900 E/watchface-loader(  722): watchface-loader.cpp: OnAppTimeTick(740) > 
05-09 20:22:39.268+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.268+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.288+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.288+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.303+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.303+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.323+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.323+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.338+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.338+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.358+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.358+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.373+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.373+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.388+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.388+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.408+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.408+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.423+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-09 20:22:39.423+0900 I/ELM_RPANEL(  680): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-09 20:22:39.428+0900 W/wnotib  (  680): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-09 20:22:39.428+0900 I/efl-extension(  680): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93b20 : elm_scroller] CurrentPage(2)
05-09 20:22:39.448+0900 W/WATCH_CORE(  722): appcore-watch.c: __widget_pause(1001) > widget_pause
05-09 20:22:39.448+0900 E/watchface-loader(  722): watchface-loader.cpp: OnAppPause(713) > 
05-09 20:22:39.448+0900 E/watchface-viewer(  722): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-09 20:22:39.448+0900 E/watchface-viewer(  722): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-09 20:22:39.448+0900 E/watchface-viewer(  722): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-09 20:22:39.448+0900 E/watchface-viewer(  722): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-09 20:22:39.448+0900 E/watchface-viewer(  722): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-09 20:22:39.553+0900 W/W_HOME  (  680): event_manager.c: _home_scroll_cb(564) > scroll,done
05-09 20:22:39.678+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), block(2)
05-09 20:22:39.678+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), ev->cur.canvas.x(191) ev->cur.canvas.y(74)
05-09 20:22:39.678+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), hold(0) freeze(0)
05-09 20:22:39.678+0900 E/EFL     (  680): evas_main<680> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8059884 button=1 downs=1
05-09 20:22:39.683+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), block(2)
05-09 20:22:39.683+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), ev->cur.canvas.x(184) ev->cur.canvas.y(72)
05-09 20:22:39.683+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), hold(0) freeze(0)
05-09 20:22:39.693+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), block(2)
05-09 20:22:39.693+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), ev->cur.canvas.x(182) ev->cur.canvas.y(71)
05-09 20:22:39.693+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), hold(0) freeze(0)
05-09 20:22:39.693+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:39.693+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:39.693+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:39.693+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:39.693+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:39.693+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:39.693+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:39.698+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:39.698+0900 E/CAPI_APPFW_APP_CONTROL( 1082): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-09 20:22:39.698+0900 W/MUSIC_CONTROL_SERVICE( 1082): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1082]   [com.samsung.w-home]register msg port [true][0m
05-09 20:22:39.703+0900 E/EFL     (  747): evas_main<747> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8059879 button=1 downs=1
05-09 20:22:39.703+0900 E/EFL     (  747): evas_main<747> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-09 20:22:39.703+0900 E/EFL     (  747): evas_main<747> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-09 20:22:39.703+0900 E/EFL     (  747): evas_main<747> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-09 20:22:39.703+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), block(2)
05-09 20:22:39.703+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), ev->cur.canvas.x(181) ev->cur.canvas.y(70)
05-09 20:22:39.703+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), hold(0) freeze(0)
05-09 20:22:39.708+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-09 20:22:39.713+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 680
05-09 20:22:39.728+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), block(2)
05-09 20:22:39.728+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), ev->cur.canvas.x(181) ev->cur.canvas.y(69)
05-09 20:22:39.728+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), hold(0) freeze(0)
05-09 20:22:39.738+0900 W/MUSIC_CONTROL_SERVICE( 1082): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1082]   [MUSIC_PLAYER_EVENT][0m
05-09 20:22:39.738+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), block(2)
05-09 20:22:39.738+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), ev->cur.canvas.x(181) ev->cur.canvas.y(70)
05-09 20:22:39.738+0900 E/EFL     (  680): elementary<680> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93b20), hold(0) freeze(0)
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:39.738+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:39.743+0900 W/W_HOME  (  680): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-09 20:22:39.743+0900 E/W_HOME  (  680): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-09 20:22:39.743+0900 W/MUSIC_CONTROL_SERVICE( 1082): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1082]   [MUSIC_PLAYER_EVENT][0m
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:39.743+0900 W/W_HOME  (  680): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-09 20:22:39.743+0900 E/W_HOME  (  680): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:39.743+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:39.753+0900 E/EFL     (  680): evas_main<680> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8059956 button=1 downs=0
05-09 20:22:39.768+0900 E/EFL     (  747): evas_main<747> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8059962 button=1 downs=0
05-09 20:22:39.768+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-09 20:22:39.773+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 747
05-09 20:22:39.773+0900 I/AUL_AMD (  487): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-09 20:22:39.778+0900 W/AUL_AMD (  487): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 680
05-09 20:22:39.783+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(680), cmd(0)
05-09 20:22:39.783+0900 I/APP_CORE(  680): appcore-efl.c: __do_app(429) > [APP 680] Event: RESET State: RUNNING
05-09 20:22:39.783+0900 I/CAPI_APPFW_APPLICATION(  680): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-09 20:22:39.783+0900 W/W_HOME  (  680): main.c: _app_control(1726) > Service value : launch_apps
05-09 20:22:39.783+0900 W/W_HOME  (  680): move.c: move_move_to_apps(216) > move to apps
05-09 20:22:39.783+0900 W/W_HOME  (  680): rotary.c: rotary_attach(138) > rotary_attach:0x47abcda8
05-09 20:22:39.783+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47abcda8, elm_layout, _activated_obj : 0x45c960a0, activated : 1
05-09 20:22:39.783+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-09 20:22:39.783+0900 W/W_HOME  (  680): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-09 20:22:39.783+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-09 20:22:39.783+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-09 20:22:39.803+0900 I/APP_CORE(  680): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-09 20:22:39.803+0900 W/W_HOME  (  680): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-09 20:22:39.803+0900 W/W_HOME  (  680): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-09 20:22:39.803+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-09 20:22:39.803+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-09 20:22:39.803+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-09 20:22:39.803+0900 W/W_HOME  (  680): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
05-09 20:22:39.803+0900 W/W_HOME  (  680): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-09 20:22:39.803+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-09 20:22:39.803+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-09 20:22:40.078+0900 W/W_HOME  (  680): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-09 20:22:40.078+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-09 20:22:40.078+0900 W/W_HOME  (  680): rotary.c: rotary_deattach(156) > rotary_deattach:0x47abcda8
05-09 20:22:40.078+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-09 20:22:40.078+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47abcda8, elm_layout, func : 0x4004b469
05-09 20:22:40.078+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-09 20:22:40.078+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-09 20:22:40.078+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-09 20:22:40.078+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c960a0, elm_box, _activated_obj : 0x47abcda8, activated : 1
05-09 20:22:40.078+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-09 20:22:40.078+0900 E/wnotib  (  680): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-09 20:22:40.078+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-09 20:22:40.078+0900 W/W_HOME  (  680): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-09 20:22:40.083+0900 W/W_HOME  (  680): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-09 20:22:40.083+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.083+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.083+0900 W/W_HOME  (  680): main.c: home_pause(751) > clock/widget paused
05-09 20:22:40.083+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.083+0900 W/APPS    (  680): apps_main.c: _time_changed_cb(295) >  date : 9->9
05-09 20:22:40.083+0900 W/W_HOME  (  680): rotary.c: rotary_attach(138) > rotary_attach:0x46663768
05-09 20:22:40.083+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46663768, elm_layout, _activated_obj : 0x45c960a0, activated : 1
05-09 20:22:40.083+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-09 20:22:40.088+0900 W/W_HOME  (  680): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-09 20:22:40.088+0900 W/W_HOME  (  680): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-09 20:22:40.088+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-09 20:22:40.088+0900 I/wnotib  (  680): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-09 20:22:40.088+0900 E/APPS    (  680): apps_main.c: apps_main_resume(621) >  resumed already
05-09 20:22:40.088+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:40.088+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:40.088+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:40.088+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:40.258+0900 W/W_HOME  (  680): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-09 20:22:40.418+0900 I/GESTURE (  142): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-09 20:22:40.428+0900 E/EFL     (  680): evas_main<680> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8060625 button=1 downs=1
05-09 20:22:40.428+0900 W/APPS    (  680): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [218, 201]
05-09 20:22:40.503+0900 E/EFL     (  680): evas_main<680> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8060700 button=1 downs=0
05-09 20:22:40.503+0900 W/APPS    (  680): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [218, 201]->[212, 205]
05-09 20:22:40.503+0900 W/APPS    (  680): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,20]
05-09 20:22:40.503+0900 E/APPS    (  680): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-09 20:22:40.503+0900 W/APPS    (  680): AppsItem.cpp: onItemClicked(410) >  item(pHp) launched, open(0)
05-09 20:22:40.508+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-09 20:22:40.508+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 680
05-09 20:22:40.508+0900 I/AUL_AMD (  487): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-09 20:22:40.518+0900 W/AUL_AMD (  487): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 15724
05-09 20:22:40.518+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(15724), cmd(0)
05-09 20:22:40.523+0900 I/APP_CORE(15724): appcore-efl.c: __do_app(429) > [APP 15724] Event: RESET State: PAUSED
05-09 20:22:40.523+0900 I/CAPI_APPFW_APPLICATION(15724): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-09 20:22:40.523+0900 I/APP_CORE(15724): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-09 20:22:40.523+0900 I/APP_CORE(15724): appcore-efl.c: __do_app(481) > [APP 15724] App already running, raise the window
05-09 20:22:40.523+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-09 20:22:40.533+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x03c00003)
05-09 20:22:40.533+0900 I/APP_CORE(15724): appcore-efl.c: __do_app(485) > [APP 15724] Call the resume_cb
05-09 20:22:40.533+0900 I/CAPI_APPFW_APPLICATION(15724): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-09 20:22:40.548+0900 W/W_HOME  (  680): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-09 20:22:40.548+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.548+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.548+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.548+0900 W/W_HOME  (  680): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-09 20:22:40.553+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-09 20:22:40.553+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:40.588+0900 I/MALI    (  680): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-09 20:22:40.588+0900 I/APP_CORE(15724): appcore-efl.c: __do_app(429) > [APP 15724] Event: RESUME State: RUNNING
05-09 20:22:40.588+0900 W/W_HOME  (  680): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-09 20:22:40.588+0900 W/W_HOME  (  680): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-09 20:22:40.588+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.588+0900 W/W_HOME  (  680): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-09 20:22:40.588+0900 I/APP_CORE(  680): appcore-efl.c: __do_app(429) > [APP 680] Event: PAUSE State: RUNNING
05-09 20:22:40.588+0900 I/CAPI_APPFW_APPLICATION(  680): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-09 20:22:40.588+0900 W/W_HOME  (  680): main.c: _appcore_pause_cb(690) > appcore pause
05-09 20:22:40.588+0900 W/W_HOME  (  680): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-09 20:22:40.588+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.593+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.593+0900 W/W_HOME  (  680): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-09 20:22:40.593+0900 W/W_HOME  (  680): rotary.c: rotary_deattach(156) > rotary_deattach:0x46663768
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46663768, elm_layout, func : 0x4004b469
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c960a0, elm_box, _activated_obj : 0x46663768, activated : 1
05-09 20:22:40.593+0900 I/efl-extension(  680): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-09 20:22:40.593+0900 E/wnotib  (  680): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-09 20:22:40.593+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-09 20:22:40.603+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-09 20:22:40.603+0900 E/CAPI_APPFW_APP_CONTROL( 1082): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-09 20:22:40.603+0900 W/MUSIC_CONTROL_SERVICE( 1082): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1082]   [com.samsung.w-home]register msg port [false][0m
05-09 20:22:40.608+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:40.608+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-09 20:22:40.658+0900 I/wnotib  (  680): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-09 20:22:40.658+0900 E/wnotib  (  680): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-09 20:22:40.668+0900 W/APPS    (  680): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-09 20:22:40.783+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-09 20:22:40.783+0900 W/AUL_AMD (  487): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-09 20:22:40.978+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-09 20:22:41.108+0900 I/APP_CORE(  680): appcore-efl.c: __do_app(429) > [APP 680] Event: MEM_FLUSH State: PAUSED
05-09 20:22:41.113+0900 E/EFL     (15724): evas_main<15724> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8061318 button=1 downs=1
05-09 20:22:41.183+0900 E/EFL     (15724): evas_main<15724> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8061393 button=1 downs=0
05-09 20:22:42.248+0900 E/EFL     (15724): evas_main<15724> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8062452 button=1 downs=1
05-09 20:22:42.313+0900 E/EFL     (15724): evas_main<15724> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8062521 button=1 downs=0
05-09 20:22:42.738+0900 W/CRASH_MANAGER(15765): worker.c: worker_job(1199) > 1115724706831146279296
