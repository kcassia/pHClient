S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 8307
Date: 2016-05-10 15:06:57+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 6
      (SIGABRT)
      si_code: 0
      signal sent by kill (sent by pid 484, uid 0)

Register Information
r0   = 0xfffffffc, r1   = 0xbea8e414
r2   = 0x00000010, r3   = 0x4f86f700
r4   = 0x45c0d6d0, r5   = 0x45c515c8
r6   = 0x409aeb18, r7   = 0x0000011b
r8   = 0x409a016c, r9   = 0x00000001
r10  = 0x409a08ec, fp   = 0x409a08ec
ip   = 0x00000000, sp   = 0xbea8e370
lr   = 0x400636d8, pc   = 0x40064204
cpsr = 0x80000010

Memory Information
MemTotal:   489992 KB
MemFree:     22508 KB
Buffers:     17504 KB
Cached:     134140 KB
VmPeak:     102688 KB
VmSize:      99512 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19440 KB
VmRSS:       19436 KB
VmData:      41696 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       52916 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8307 TID = 8307
8307 8312 8313 8314 

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
43025000 43824000 rwxp [stack:8312]
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
438f9000 438fc000 rwxp [stack:8314]
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
44029000 44828000 rwxp [stack:8313]
44828000 44830000 rwxs /dev/mali
44844000 44848000 rwxs /dev/mali
44848000 4484c000 rwxs /dev/mali
4484c000 44854000 rwxs /dev/mali
44854000 4485c000 rwxs /dev/mali
4485c000 4485e000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
4485e000 44875000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4487d000 44882000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44882000 44884000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
4488b000 4488c000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
4488c000 4488f000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
4488f000 44893000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44893000 448a2000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
448e2000 448e5000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
448ec000 448ed000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
448ed000 448ee000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
448f5000 448f6000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
448f6000 448fa000 rwxs /dev/mali
448fa000 448fe000 rwxs /dev/mali
44a00000 44b9f000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
45bdf000 45be3000 rwxs /dev/mali
45d00000 45d8b000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
45d8b000 45daf000 rwxs /dev/mali
45daf000 45dd3000 rwxs /dev/mali
45dd3000 45df7000 rwxs /dev/mali
45df7000 45e83000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
46088000 460c8000 rwxs /dev/mali
bea6e000 bea8f000 rwxp [stack]
End of Maps Information

Callstack Information (PID:8307)
Call Stack Count: 2
 0: connect + 0x44 (0x40064204) [/lib/libpthread.so.0] + 0xf204
 1: remote_control_cb + 0x96 (0x4000261b) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x261b
End of Call Stack

Package Information
Package Name: org.example.ph1
Package ID : org.example.ph1
Version: 0.8.0
Package Type: rpm
App Name: pH
App ID: org.example.ph1
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
10 15:06:48.207+0900 W/STARTER (  645): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-10 15:06:48.277+0900 W/STARTER (  645): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-10 15:06:48.277+0900 W/STARTER (  645): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-10 15:06:48.277+0900 W/STARTER (  645): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-10 15:06:48.277+0900 W/STARTER (  645): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-10 15:06:48.342+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-10 15:06:48.347+0900 E/CAPI_APPFW_APP_CONTROL( 1063): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-10 15:06:48.347+0900 W/MUSIC_CONTROL_SERVICE( 1063): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1063]   [com.samsung.w-home]register msg port [true][0m
05-10 15:06:48.347+0900 W/AUL_AMD (  481): amd_request.c: __request_handler(646) > __request_handler: 14
05-10 15:06:48.352+0900 W/AUL_AMD (  481): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 688
05-10 15:06:48.352+0900 W/MUSIC_CONTROL_SERVICE( 1063): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1063]   [MUSIC_PLAYER_EVENT][0m
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-10 15:06:48.357+0900 W/MUSIC_CONTROL_SERVICE( 1063): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1063]   [MUSIC_PLAYER_EVENT][0m
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-10 15:06:48.357+0900 W/W_HOME  (  688): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-10 15:06:48.357+0900 E/W_HOME  (  688): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-10 15:06:48.357+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-10 15:06:48.357+0900 W/W_HOME  (  688): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-10 15:06:48.357+0900 E/W_HOME  (  688): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-10 15:06:48.412+0900 W/STARTER (  645): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-10 15:06:48.662+0900 W/STARTER (  645): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-10 15:06:48.662+0900 W/STARTER (  645): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-10 15:06:48.662+0900 E/STARTER (  645): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-10 15:06:48.662+0900 W/AUL_AMD (  481): amd_request.c: __request_handler(646) > __request_handler: 0
05-10 15:06:48.677+0900 W/AUL_AMD (  481): amd_launch.c: _start_app(1702) > caller pid : 645
05-10 15:06:48.682+0900 W/AUL_AMD (  481): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 8231
05-10 15:06:48.997+0900 I/CAPI_WATCH_APPLICATION( 4133): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-10 15:06:49.687+0900 W/AUL_AMD (  481): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-10 15:06:49.687+0900 W/AUL_AMD (  481): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-10 15:06:50.002+0900 I/CAPI_WATCH_APPLICATION( 4133): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-10 15:06:50.742+0900 I/efl-extension( 4157): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-10 15:06:50.742+0900 I/efl-extension(  688): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-10 15:06:50.742+0900 I/efl-extension(  688): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45c96200, elm_box, time_stamp : 2621722
05-10 15:06:50.742+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_rotary_cb(568) > Pass rotary event to home.
05-10 15:06:50.752+0900 W/W_HOME  (  688): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0x490c8958 -> 360 0 0x47c05638
05-10 15:06:50.752+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45c93c80 : elm_scroller] rotary callabck is called.
05-10 15:06:50.752+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45c93c80 : elm_scroller] block(2)
05-10 15:06:50.752+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45c93c80 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-10 15:06:50.752+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45c93c80 : elm_scroller] content size (w, h)(2520, 360)
05-10 15:06:50.752+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45c93c80 : elm_scroller] viewport size (w, h)(360, 360)
05-10 15:06:50.752+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45c93c80 : elm_scroller] CurrentPage(1) DetentCount(1)
05-10 15:06:50.752+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93c80 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-10 15:06:50.752+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93c80 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-10 15:06:50.752+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93c80 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-10 15:06:50.752+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45c93c80 : elm_scroller] bring in 2 page
05-10 15:06:50.752+0900 W/W_HOME  (  688): event_manager.c: _home_scroll_cb(564) > scroll,start
05-10 15:06:50.777+0900 W/W_HOME  (  688): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
05-10 15:06:50.777+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-10 15:06:50.777+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.777+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.782+0900 W/GESTURE (  146): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-10 15:06:50.802+0900 W/W_HOME  (  688): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
05-10 15:06:50.802+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.802+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.812+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.812+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.827+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.827+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.842+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.842+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.867+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.867+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.882+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.882+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.897+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.897+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.917+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.917+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.932+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.932+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.942+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.942+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.957+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.957+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.977+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.977+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:50.992+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:50.992+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:51.002+0900 I/CAPI_WATCH_APPLICATION( 4133): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-10 15:06:51.027+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-10 15:06:51.027+0900 I/ELM_RPANEL(  688): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-10 15:06:51.032+0900 W/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-10 15:06:51.032+0900 I/efl-extension(  688): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c93c80 : elm_scroller] CurrentPage(2)
05-10 15:06:51.052+0900 W/WATCH_CORE( 4133): appcore-watch.c: __widget_pause(1001) > widget_pause
05-10 15:06:51.162+0900 W/W_HOME  (  688): event_manager.c: _home_scroll_cb(564) > scroll,done
05-10 15:06:51.327+0900 E/EFL     (  688): elementary<688> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c80), block(2)
05-10 15:06:51.327+0900 E/EFL     (  688): elementary<688> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c80), ev->cur.canvas.x(189) ev->cur.canvas.y(80)
05-10 15:06:51.327+0900 E/EFL     (  688): elementary<688> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c93c80), hold(0) freeze(0)
05-10 15:06:51.327+0900 E/EFL     (  688): evas_main<688> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2622308 button=1 downs=1
05-10 15:06:51.347+0900 E/EFL     (  741): evas_main<741> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2622304 button=1 downs=1
05-10 15:06:51.347+0900 E/EFL     (  741): evas_main<741> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-10 15:06:51.347+0900 E/EFL     (  741): evas_main<741> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-10 15:06:51.347+0900 E/EFL     (  741): evas_main<741> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-10 15:06:51.367+0900 E/EFL     (  688): evas_main<688> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2622348 button=1 downs=0
05-10 15:06:51.382+0900 E/EFL     (  741): evas_main<741> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2622353 button=1 downs=0
05-10 15:06:51.387+0900 W/AUL_AMD (  481): amd_request.c: __request_handler(646) > __request_handler: 0
05-10 15:06:51.387+0900 W/AUL_AMD (  481): amd_launch.c: _start_app(1702) > caller pid : 741
05-10 15:06:51.387+0900 I/AUL_AMD (  481): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-10 15:06:51.397+0900 W/AUL_AMD (  481): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 688
05-10 15:06:51.397+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(429) > [APP 688] Event: RESET State: RUNNING
05-10 15:06:51.397+0900 I/CAPI_APPFW_APPLICATION(  688): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-10 15:06:51.397+0900 W/W_HOME  (  688): main.c: _app_control(1726) > Service value : launch_apps
05-10 15:06:51.397+0900 W/W_HOME  (  688): move.c: move_move_to_apps(216) > move to apps
05-10 15:06:51.397+0900 W/W_HOME  (  688): rotary.c: rotary_attach(138) > rotary_attach:0x4783f818
05-10 15:06:51.397+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4783f818, elm_layout, _activated_obj : 0x45c96200, activated : 1
05-10 15:06:51.397+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-10 15:06:51.397+0900 W/W_HOME  (  688): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-10 15:06:51.397+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-10 15:06:51.402+0900 W/AUL_AMD (  481): amd_launch.c: __reply_handler(916) > listen fd(28) , send fd(27), pid(688), cmd(0)
05-10 15:06:51.402+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-10 15:06:51.417+0900 I/APP_CORE(  688): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-10 15:06:51.417+0900 W/W_HOME  (  688): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
05-10 15:06:51.417+0900 W/W_HOME  (  688): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-10 15:06:51.417+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-10 15:06:51.417+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-10 15:06:51.417+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-10 15:06:51.417+0900 W/W_HOME  (  688): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
05-10 15:06:51.417+0900 W/W_HOME  (  688): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-10 15:06:51.417+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-10 15:06:51.417+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-10 15:06:51.692+0900 W/W_HOME  (  688): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-10 15:06:51.692+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-10 15:06:51.692+0900 W/W_HOME  (  688): rotary.c: rotary_deattach(156) > rotary_deattach:0x4783f818
05-10 15:06:51.692+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-10 15:06:51.692+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4783f818, elm_layout, func : 0x4004b469
05-10 15:06:51.692+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-10 15:06:51.692+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-10 15:06:51.692+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-10 15:06:51.692+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96200, elm_box, _activated_obj : 0x4783f818, activated : 1
05-10 15:06:51.692+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-10 15:06:51.692+0900 E/wnotib  (  688): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-10 15:06:51.692+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-10 15:06:51.692+0900 W/W_HOME  (  688): event_manager.c: _apptray_visibility_cb(578) > apps,show
05-10 15:06:51.692+0900 W/W_HOME  (  688): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
05-10 15:06:51.692+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-10 15:06:51.697+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-10 15:06:51.697+0900 W/W_HOME  (  688): main.c: home_pause(751) > clock/widget paused
05-10 15:06:51.697+0900 W/W_HOME  (  688): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-10 15:06:51.697+0900 W/APPS    (  688): apps_main.c: _time_changed_cb(295) >  date : 10->10
05-10 15:06:51.697+0900 W/W_HOME  (  688): rotary.c: rotary_attach(138) > rotary_attach:0x4775d500
05-10 15:06:51.697+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4775d500, elm_layout, _activated_obj : 0x45c96200, activated : 1
05-10 15:06:51.697+0900 I/efl-extension(  688): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-10 15:06:51.697+0900 W/W_HOME  (  688): noti_broker.c: _apptray_visibility_cb(788) > apps,show
05-10 15:06:51.697+0900 W/W_HOME  (  688): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
05-10 15:06:51.697+0900 I/wnotib  (  688): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
05-10 15:06:51.697+0900 I/wnotib  (  688): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 1
05-10 15:06:51.697+0900 E/APPS    (  688): apps_main.c: apps_main_resume(621) >  resumed already
05-10 15:06:51.702+0900 W/GESTURE (  146): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-10 15:06:51.702+0900 W/GESTURE (  146): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-10 15:06:51.702+0900 W/GESTURE (  146): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-10 15:06:51.702+0900 W/GESTURE (  146): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-10 15:06:51.872+0900 W/W_HOME  (  688): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
05-10 15:06:51.962+0900 I/GESTURE (  146): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
05-10 15:06:51.972+0900 E/EFL     (  688): evas_main<688> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2622944 button=1 downs=1
05-10 15:06:51.972+0900 W/APPS    (  688): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [205, 160]
05-10 15:06:52.022+0900 E/EFL     (  688): evas_main<688> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2623007 button=1 downs=0
05-10 15:06:52.022+0900 W/APPS    (  688): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [205, 160]->[197, 157]
05-10 15:06:52.027+0900 W/APPS    (  688): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,20]
05-10 15:06:52.027+0900 E/APPS    (  688): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-10 15:06:52.027+0900 W/APPS    (  688): AppsItem.cpp: onItemClicked(410) >  item(pH) launched, open(0)
05-10 15:06:52.027+0900 W/AUL_AMD (  481): amd_request.c: __request_handler(646) > __request_handler: 0
05-10 15:06:52.032+0900 W/AUL_AMD (  481): amd_launch.c: _start_app(1702) > caller pid : 688
05-10 15:06:52.032+0900 I/AUL_AMD (  481): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
05-10 15:06:52.042+0900 W/AUL_AMD (  481): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 8307
05-10 15:06:52.042+0900 E/AUL     (  481): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-10 15:06:52.907+0900 E/AUL_AMD (  481): amd_launch.c: __recv_timeout_handler(935) > application is not responding : pid(8307) cmd(3)
05-10 15:06:53.042+0900 W/AUL_AMD (  481): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-10 15:06:53.042+0900 W/AUL_AMD (  481): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-10 15:06:53.087+0900 E/AUL     ( 8231): app_sock.c: __app_send_raw(324) > recv timeout : cmd(1) Resource temporarily unavailable
05-10 15:06:53.087+0900 E/W_TASKMANAGER( 8231): task.c: taskmanager_launch_task_info(917) > [taskmanager_launch_task_info:917] _launch_app() failed(-6)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4524f688, elm_image, time_stamp : 2611444
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45205e88 : elm_scroller] rotary callabck is called.
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45205e88 : elm_scroller] block(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45205e88 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45205e88 : elm_scroller] content size (w, h)(601, 360)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45205e88 : elm_scroller] viewport size (w, h)(360, 360)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45205e88 : elm_scroller] CurrentPage(0) DetentCount(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45205e88 : elm_scroller] bring in 1 page
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4524f688, elm_image, time_stamp : 2611648
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45205e88 : elm_scroller] rotary callabck is called.
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45205e88 : elm_scroller] block(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45205e88 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45205e88 : elm_scroller] content size (w, h)(601, 360)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45205e88 : elm_scroller] viewport size (w, h)(360, 360)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45205e88 : elm_scroller] CurrentPage(0) DetentCount(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4524f688, elm_image, time_stamp : 2611946
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45205e88 : elm_scroller] rotary callabck is called.
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45205e88 : elm_scroller] block(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45205e88 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45205e88 : elm_scroller] content size (w, h)(601, 360)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45205e88 : elm_scroller] viewport size (w, h)(360, 360)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45205e88 : elm_scroller] CurrentPage(0) DetentCount(-1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(721) > [0x45205e88 : elm_scroller] edge left
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4524f688, elm_image, time_stamp : 2611982
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45205e88 : elm_scroller] rotary callabck is called.
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45205e88 : elm_scroller] block(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45205e88 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45205e88 : elm_scroller] content size (w, h)(601, 360)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45205e88 : elm_scroller] viewport size (w, h)(360, 360)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45205e88 : elm_scroller] CurrentPage(0) DetentCount(-1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(721) > [0x45205e88 : elm_scroller] edge left
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4524f688, elm_image, time_stamp : 2612039
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45205e88 : elm_scroller] rotary callabck is called.
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45205e88 : elm_scroller] block(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45205e88 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45205e88 : elm_scroller] content size (w, h)(601, 360)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45205e88 : elm_scroller] viewport size (w, h)(360, 360)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45205e88 : elm_scroller] CurrentPage(0) DetentCount(-1)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45205e88 : elm_scroller] mx(241), my(0), minx(0), miny(0), px(0), py(0)
05-10 15:06:53.087+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(721) > [0x45205e88 : elm_scroller] edge left
05-10 15:06:53.097+0900 I/MALI    ( 8231): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-10 15:06:53.102+0900 W/AUL_AMD (  481): amd_launch.c: __reply_handler(916) > listen fd(26) , send fd(25), pid(8231), cmd(0)
05-10 15:06:53.102+0900 E/AUL     (  645): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-10 15:06:53.107+0900 I/APP_CORE( 8231): appcore-efl.c: __do_app(429) > [APP 8231] Event: RESET State: RUNNING
05-10 15:06:53.107+0900 I/CAPI_APPFW_APPLICATION( 8231): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-10 15:06:53.107+0900 I/APP_CORE( 8231): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
05-10 15:06:53.107+0900 I/APP_CORE( 8231): appcore-efl.c: __do_app(481) > [APP 8231] App already running, raise the window
05-10 15:06:53.117+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-10 15:06:53.122+0900 W/AUL_AMD (  481): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-10 15:06:53.122+0900 W/AUL_AMD (  481): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-10 15:06:53.122+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-10 15:06:53.127+0900 E/EFL     ( 8231): evas_main<8231> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2616732 button=1 downs=1
05-10 15:06:53.127+0900 E/EFL     ( 8231): evas_main<8231> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2616779 button=1 downs=0
05-10 15:06:53.127+0900 E/EFL     ( 8231): evas_main<8231> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2616992 button=1 downs=1
05-10 15:06:53.127+0900 E/EFL     ( 8231): evas_main<8231> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2617058 button=1 downs=0
05-10 15:06:53.127+0900 E/EFL     ( 8231): elementary<8231> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(45205e88), freeze(1)
05-10 15:06:53.127+0900 E/EFL     ( 8231): elementary<8231> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(45205e88), freeze(1)
05-10 15:06:53.127+0900 I/APP_CORE( 8231): appcore-efl.c: __do_app(429) > [APP 8231] Event: PAUSE State: RUNNING
05-10 15:06:53.127+0900 I/CAPI_APPFW_APPLICATION( 8231): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-10 15:06:53.127+0900 I/efl-extension( 8231): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-10 15:06:53.132+0900 W/AUL_AMD (  481): amd_request.c: __request_handler(646) > __request_handler: 22
05-10 15:06:53.132+0900 W/AUL_AMD (  481): amd_request.c: __request_handler(890) > app status : 4
05-10 15:06:53.132+0900 E/APP_CORE( 8231): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-10 15:06:53.137+0900 I/APP_CORE( 8231): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-10 15:06:53.137+0900 I/CAPI_APPFW_APPLICATION( 8231): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-10 15:06:53.137+0900 I/efl-extension( 8231): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45205e88, obj: 0x45205e88
05-10 15:06:53.137+0900 I/efl-extension( 8231): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-10 15:06:53.137+0900 I/efl-extension( 8231): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-10 15:06:53.137+0900 I/efl-extension( 8231): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-10 15:06:53.137+0900 I/efl-extension( 8231): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-10 15:06:53.142+0900 I/efl-extension( 8231): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4524f688
05-10 15:06:53.142+0900 I/efl-extension( 8231): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-10 15:06:53.142+0900 I/efl-extension( 8231): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45269f08 is freed
05-10 15:06:53.142+0900 I/efl-extension( 8231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-10 15:06:53.142+0900 I/efl-extension( 8231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45205e88, elm_scroller, func : 0x437c8ef1
05-10 15:06:53.142+0900 I/efl-extension( 8231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-10 15:06:53.142+0900 I/efl-extension( 8231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-10 15:06:53.142+0900 I/efl-extension( 8231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4524f688, elm_image, func : 0x437c8ef1
05-10 15:06:53.142+0900 I/efl-extension( 8231): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-10 15:06:53.142+0900 I/efl-extension( 8231): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x45205e88 : elm_scroller] rotary callabck is deleted
05-10 15:06:53.387+0900 I/MALI    ( 8231): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-10 15:06:53.387+0900 I/MALI    ( 8231): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=8231   close drm_fd=21 
05-10 15:06:53.387+0900 I/MALI    ( 8231): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-10 15:06:53.427+0900 I/UXT     ( 8231): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-10 15:06:53.687+0900 I/efl-extension( 8231): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-10 15:06:54.202+0900 I/AUL_AMD (  481): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8231
05-10 15:06:55.137+0900 W/AUL_AMD (  481): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-10 15:06:57.047+0900 E/AUL_AMD (  481): amd_launch.c: __recv_timeout_handler(935) > application is not responding : pid(8307) cmd(0)
05-10 15:06:57.047+0900 W/AUL_AMD (  481): amd_launch.c: __send_watchdog_signal(425) > send a watchdog signal done: 8307
05-10 15:06:57.067+0900 E/RESOURCED(  484): proc-monitor.c: proc_dbus_watchdog_handler(743) > [proc_dbus_watchdog_handler,743] Receive watchdog signal to pid: 8307(ph1)
05-10 15:06:57.067+0900 E/RESOURCED(  484): proc-monitor.c: proc_dbus_watchdog_handler(754) > [proc_dbus_watchdog_handler,754] just kill watchdog process when debug enabled pid: 8307(ph1)
05-10 15:06:57.242+0900 E/AUL     (  688): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
05-10 15:06:57.242+0900 E/CAPI_APPFW_APP_CONTROL(  688): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
05-10 15:06:57.622+0900 W/CRASH_MANAGER( 8662): worker.c: worker_job(1199) > 0608307706831146286041
