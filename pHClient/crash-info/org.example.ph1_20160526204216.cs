S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 25896
Date: 2016-05-26 20:42:16+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 25896, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000009
r2   = 0x0000000a, r3   = 0x00000000
r4   = 0x400ee9c0, r5   = 0x4048e4b8
r6   = 0x400ee16c, r7   = 0x00000000
r8   = 0x434422e4, r9   = 0x42ecb060
r10  = 0x400fcb18, fp   = 0x00000000
ip   = 0x4048e4b8, sp   = 0xbebac298
lr   = 0x4039c08c, pc   = 0x4039c1f4
cpsr = 0x80000010

Memory Information
MemTotal:   489992 KB
MemFree:     36944 KB
Buffers:     46756 KB
Cached:     132516 KB
VmPeak:     116144 KB
VmSize:     105980 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22960 KB
VmRSS:       22960 KB
VmData:      43744 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       56492 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 25896 TID = 25896
25896 25902 25903 25906 25969 

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
4008d000 4009a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
400a1000 400a2000 rwxp /usr/lib/libcapi-network-connection.so.1.0.51
400a2000 400a7000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
400ae000 400af000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
400af000 400b3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
400bb000 400bc000 rwxp /usr/lib/libcapi-system-sensor.so.0.1.18
400bc000 400c4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
400c4000 400c5000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
400c5000 400c7000 r-xp /usr/lib/libdlog.so.0.0.0
400ce000 400cf000 rwxp /usr/lib/libdlog.so.0.0.0
400cf000 400e6000 r-xp /usr/lib/libecore.so.1.7.99
400ee000 400ef000 rwxp /usr/lib/libecore.so.1.7.99
400fd000 4011e000 r-xp /usr/lib/libefl-extension.so.0.1.0
40125000 40126000 rwxp /usr/lib/libefl-extension.so.0.1.0
40126000 40260000 r-xp /usr/lib/libelementary.so.1.7.99
40267000 4026f000 rwxp /usr/lib/libelementary.so.1.7.99
40276000 40344000 r-xp /usr/lib/libevas.so.1.7.99
4034c000 40356000 rwxp /usr/lib/libevas.so.1.7.99
40369000 40484000 r-xp /lib/libc-2.13.so
4048c000 4048e000 r-xp /lib/libc-2.13.so
4048e000 4048f000 rwxp /lib/libc-2.13.so
40492000 4049d000 r-xp /lib/libunwind.so.8.0.1
404a4000 404a5000 rwxp /lib/libunwind.so.8.0.1
404ca000 404cc000 r-xp /lib/libdl-2.13.so
404d3000 404d4000 r-xp /lib/libdl-2.13.so
404d4000 404d5000 rwxp /lib/libdl-2.13.so
404d5000 404dd000 r-xp /lib/libgcc_s-4.6.so.1
404dd000 404de000 rwxp /lib/libgcc_s-4.6.so.1
404de000 404ea000 r-xp /usr/lib/libaul.so.0.1.0
404f2000 404f3000 rwxp /usr/lib/libaul.so.0.1.0
404f4000 40516000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4051d000 4051e000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
4051e000 40522000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4052a000 4052b000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4052b000 40530000 r-xp /usr/lib/libappcore-efl.so.1.1
40537000 40538000 rwxp /usr/lib/libappcore-efl.so.1.1
40538000 4053d000 r-xp /usr/lib/libappcore-common.so.1.1
40544000 40545000 rwxp /usr/lib/libappcore-common.so.1.1
40545000 40586000 r-xp /usr/lib/libeina.so.1.7.99
4058d000 4058f000 rwxp /usr/lib/libeina.so.1.7.99
4058f000 40593000 r-xp /usr/lib/libvconf.so.0.2.45
4059a000 4059b000 rwxp /usr/lib/libvconf.so.0.2.45
4059b000 405b2000 r-xp /usr/lib/libnetwork.so.0.0.0
405b9000 405ba000 rwxp /usr/lib/libnetwork.so.0.0.0
405ba000 4068a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4068a000 4068b000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
4068b000 40690000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
40697000 40698000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
40698000 4076b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40772000 40776000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
40776000 407aa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
407b1000 407b3000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
407b3000 407d1000 r-xp /usr/lib/libsensor.so.1.1.0
407d9000 407da000 rwxp /usr/lib/libsensor.so.1.1.0
407db000 4086f000 r-xp /usr/lib/libstdc++.so.6.0.16
40877000 4087a000 r-xp /usr/lib/libstdc++.so.6.0.16
4087a000 4087c000 rwxp /usr/lib/libstdc++.so.6.0.16
40882000 408eb000 r-xp /lib/libm-2.13.so
408f2000 408f3000 r-xp /lib/libm-2.13.so
408f3000 408f4000 rwxp /lib/libm-2.13.so
408f4000 40944000 r-xp /usr/lib/libecore_x.so.1.7.99
40944000 40946000 rwxp /usr/lib/libecore_x.so.1.7.99
40946000 40968000 r-xp /usr/lib/libecore_evas.so.1.7.99
4096f000 40971000 rwxp /usr/lib/libecore_evas.so.1.7.99
40971000 40999000 r-xp /usr/lib/libfontconfig.so.1.8.0
40999000 4099a000 rwxp /usr/lib/libfontconfig.so.1.8.0
4099a000 40a66000 r-xp /usr/lib/libxml2.so.2.7.8
40a6d000 40a72000 rwxp /usr/lib/libxml2.so.2.7.8
40a73000 40a85000 r-xp /usr/lib/libefl-assist.so.0.1.0
40a8c000 40a8d000 rwxp /usr/lib/libefl-assist.so.0.1.0
40a8d000 40a93000 r-xp /lib/librt-2.13.so
40a9a000 40a9b000 r-xp /lib/librt-2.13.so
40a9b000 40a9c000 rwxp /lib/librt-2.13.so
40a9c000 40af9000 r-xp /usr/lib/libedje.so.1.7.99
40b01000 40b03000 rwxp /usr/lib/libedje.so.1.7.99
40b03000 40bbb000 r-xp /usr/lib/libcairo.so.2.11200.14
40bc2000 40bc5000 rwxp /usr/lib/libcairo.so.2.11200.14
40bc6000 40ca7000 r-xp /usr/lib/libX11.so.6.3.0
40cae000 40cb2000 rwxp /usr/lib/libX11.so.6.3.0
40cb2000 40cbb000 r-xp /usr/lib/libXi.so.6.1.0
40cc2000 40cc3000 rwxp /usr/lib/libXi.so.6.1.0
40cc3000 40cdc000 r-xp /usr/lib/libeet.so.1.7.99
40ce4000 40ce5000 rwxp /usr/lib/libeet.so.1.7.99
40ced000 40cf2000 r-xp /usr/lib/libecore_file.so.1.7.99
40cf9000 40cfa000 rwxp /usr/lib/libecore_file.so.1.7.99
40cfa000 40d0b000 r-xp /usr/lib/libecore_input.so.1.7.99
40d12000 40d13000 rwxp /usr/lib/libecore_input.so.1.7.99
40d13000 40d1c000 r-xp /usr/lib/libedbus.so.1.7.99
40d23000 40d24000 rwxp /usr/lib/libedbus.so.1.7.99
40d24000 40d4e000 r-xp /usr/lib/libdbus-1.so.3.8.12
40d56000 40d57000 rwxp /usr/lib/libdbus-1.so.3.8.12
40d57000 40d71000 r-xp /usr/lib/libecore_con.so.1.7.99
40d78000 40d79000 rwxp /usr/lib/libecore_con.so.1.7.99
40d7a000 40d8d000 r-xp /usr/lib/libfribidi.so.0.3.1
40d94000 40d95000 rwxp /usr/lib/libfribidi.so.0.3.1
40d95000 40dd2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40dd9000 40dda000 rwxp /usr/lib/libharfbuzz.so.0.940.0
40ddb000 40e31000 r-xp /usr/lib/libfreetype.so.6.11.3
40e39000 40e3d000 rwxp /usr/lib/libfreetype.so.6.11.3
40e3d000 40e93000 r-xp /usr/lib/libpixman-1.so.0.28.2
40e9b000 40ea0000 rwxp /usr/lib/libpixman-1.so.0.28.2
40ea0000 40ea3000 r-xp /usr/lib/libbundle.so.0.1.22
40eaa000 40eab000 rwxp /usr/lib/libbundle.so.0.1.22
40eab000 40ec2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40ec9000 40eca000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
40eca000 40ecf000 r-xp /usr/lib/libxdgmime.so.1.1.0
40ed6000 40ed7000 rwxp /usr/lib/libxdgmime.so.1.1.0
40ed7000 40f13000 r-xp /usr/lib/libsystemd.so.0.4.0
40f1a000 40f1b000 r-xp /usr/lib/libsystemd.so.0.4.0
40f1b000 40f1c000 rwxp /usr/lib/libsystemd.so.0.4.0
40f1c000 40f1f000 r-xp /usr/lib/libproc-stat.so.0.2.86
40f26000 40f27000 rwxp /usr/lib/libproc-stat.so.0.2.86
40f27000 40f3d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40f44000 40f45000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
40f45000 40fba000 r-xp /usr/lib/libsqlite3.so.0.8.6
40fc1000 40fc4000 rwxp /usr/lib/libsqlite3.so.0.8.6
40fc4000 40fca000 r-xp /usr/lib/libappsvc.so.0.1.0
40fd1000 40fd2000 rwxp /usr/lib/libappsvc.so.0.1.0
40fd2000 40fd8000 r-xp /usr/lib/libecore_imf.so.1.7.99
40fdf000 40fe0000 rwxp /usr/lib/libecore_imf.so.1.7.99
40fe0000 40fe2000 r-xp /usr/lib/libiniparser.so.0
40fea000 40feb000 rwxp /usr/lib/libiniparser.so.0
40feb000 4101c000 r-xp /usr/lib/libmdm.so.1.1.85
41023000 41024000 rwxp /usr/lib/libmdm.so.1.1.85
41024000 41025000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4102c000 4102d000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
4102d000 41032000 r-xp /usr/lib/libffi.so.5.0.10
41039000 4103a000 rwxp /usr/lib/libffi.so.5.0.10
4103a000 4103c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41043000 41044000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
41044000 4105a000 r-xp /lib/libz.so.1.2.5
41061000 41062000 rwxp /lib/libz.so.1.2.5
41062000 41072000 r-xp /lib/libresolv-2.13.so
41072000 41073000 r-xp /lib/libresolv-2.13.so
41073000 41074000 rwxp /lib/libresolv-2.13.so
41076000 4107d000 r-xp /usr/lib/libsensord-share.so
41084000 41085000 rwxp /usr/lib/libsensord-share.so
41085000 4108c000 r-xp /usr/lib/libXcursor.so.1.0.2
41093000 41094000 rwxp /usr/lib/libXcursor.so.1.0.2
41094000 41096000 r-xp /usr/lib/libXdamage.so.1.1.0
4109d000 4109e000 rwxp /usr/lib/libXdamage.so.1.1.0
4109e000 410a0000 r-xp /usr/lib/libXcomposite.so.1.0.0
410a7000 410a8000 rwxp /usr/lib/libXcomposite.so.1.0.0
410a8000 410aa000 r-xp /usr/lib/libXgesture.so.7.0.0
410b1000 410b2000 rwxp /usr/lib/libXgesture.so.7.0.0
410b2000 410b5000 r-xp /usr/lib/libXfixes.so.3.1.0
410bc000 410bd000 rwxp /usr/lib/libXfixes.so.3.1.0
410be000 410bf000 r-xp /usr/lib/libXinerama.so.1.0.0
410c7000 410c8000 rwxp /usr/lib/libXinerama.so.1.0.0
410c8000 410ce000 r-xp /usr/lib/libXrandr.so.2.2.0
410d5000 410d6000 rwxp /usr/lib/libXrandr.so.2.2.0
410d6000 410dc000 r-xp /usr/lib/libXrender.so.1.3.0
410e3000 410e4000 rwxp /usr/lib/libXrender.so.1.3.0
410e4000 410e8000 r-xp /usr/lib/libXtst.so.6.1.0
410ef000 410f0000 rwxp /usr/lib/libXtst.so.6.1.0
410f0000 410fa000 r-xp /usr/lib/libXext.so.6.4.0
41102000 41103000 rwxp /usr/lib/libXext.so.6.4.0
41104000 41109000 r-xp /usr/lib/libecore_fb.so.1.7.99
41110000 41112000 rwxp /usr/lib/libecore_fb.so.1.7.99
41112000 41116000 r-xp /usr/lib/libecore_ipc.so.1.7.99
4111e000 4111f000 rwxp /usr/lib/libecore_ipc.so.1.7.99
4111f000 41122000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
41129000 4112a000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
4112a000 41140000 r-xp /lib/libexpat.so.1.5.2
41148000 4114a000 rwxp /lib/libexpat.so.1.5.2
4114a000 4115c000 r-xp /usr/lib/libtts.so
41163000 41164000 rwxp /usr/lib/libtts.so
41165000 41186000 r-xp /usr/lib/libui-extension.so.0.1.0
4118e000 4118f000 rwxp /usr/lib/libui-extension.so.0.1.0
4118f000 41196000 r-xp /usr/lib/libtbm.so.1.0.0
4119d000 4119e000 rwxp /usr/lib/libtbm.so.1.0.0
4119e000 411a5000 r-xp /usr/lib/libembryo.so.1.7.99
411ac000 411ad000 rwxp /usr/lib/libembryo.so.1.7.99
411ad000 411c4000 r-xp /usr/lib/liblua-5.1.so
411cc000 411cd000 rwxp /usr/lib/liblua-5.1.so
411cd000 411ce000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
411d5000 411d6000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
411d7000 411e5000 r-xp /usr/lib/libGLESv2.so.2.0
411ed000 411ee000 rwxp /usr/lib/libGLESv2.so.2.0
411ee000 41206000 r-xp /usr/lib/libpng12.so.0.50.0
4120d000 4120e000 rwxp /usr/lib/libpng12.so.0.50.0
4120e000 4120f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41217000 41218000 rwxp /usr/lib/libxcb-shm.so.0.0.0
41218000 4121e000 r-xp /usr/lib/libxcb-render.so.0.0.0
41225000 41226000 rwxp /usr/lib/libxcb-render.so.0.0.0
41226000 41239000 r-xp /usr/lib/libxcb.so.1.1.0
41241000 41242000 rwxp /usr/lib/libxcb.so.1.1.0
41242000 41245000 r-xp /usr/lib/libEGL.so.1.4
4124c000 4124d000 rwxp /usr/lib/libEGL.so.1.4
4124e000 41271000 r-xp /usr/lib/libjpeg.so.8.0.2
41278000 41279000 rwxp /usr/lib/libjpeg.so.8.0.2
41289000 412cd000 r-xp /usr/lib/libcurl.so.4.3.0
412d4000 412d6000 rwxp /usr/lib/libcurl.so.4.3.0
412d6000 412dc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
412e4000 412e5000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
412e5000 412fd000 r-xp /usr/lib/liblzma.so.5.0.3
41304000 41305000 rwxp /usr/lib/liblzma.so.5.0.3
41306000 41382000 r-xp /usr/lib/libgcrypt.so.20.0.3
41389000 4138e000 rwxp /usr/lib/libgcrypt.so.20.0.3
4138e000 41390000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41398000 41399000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
41399000 4139b000 r-xp /usr/lib/journal/libjournal.so.0.1.0
413a2000 413a3000 rwxp /usr/lib/journal/libjournal.so.0.1.0
413a3000 413ab000 r-xp /usr/lib/libmdm-common.so.1.0.89
413ab000 413ac000 rwxp /usr/lib/libmdm-common.so.1.0.89
413ad000 414ea000 r-xp /usr/lib/libicui18n.so.51.1
414f2000 414fa000 rwxp /usr/lib/libicui18n.so.51.1
414fa000 415de000 r-xp /usr/lib/libicuuc.so.51.1
415e5000 415ef000 rwxp /usr/lib/libicuuc.so.51.1
415f3000 415f6000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
415fd000 415fe000 rwxp /usr/lib/libcapi-media-image-util.so.0.3.5
415fe000 41601000 r-xp /usr/lib/libsmack.so.1.0.0
41608000 41609000 rwxp /usr/lib/libsmack.so.1.0.0
41609000 41611000 r-xp /usr/lib/libdrm.so.2.4.0
41618000 41619000 rwxp /usr/lib/libdrm.so.2.4.0
4161a000 4161c000 r-xp /usr/lib/libXau.so.6.0.0
41623000 41624000 rwxp /usr/lib/libXau.so.6.0.0
41624000 4162d000 r-xp /usr/lib/libcares.so.2.1.0
41635000 41636000 rwxp /usr/lib/libcares.so.2.1.0
41636000 41664000 r-xp /usr/lib/libidn.so.11.5.44
4166b000 4166c000 rwxp /usr/lib/libidn.so.11.5.44
4166c000 416b9000 r-xp /usr/lib/libssl.so.1.0.0
416c0000 416c5000 rwxp /usr/lib/libssl.so.1.0.0
416c5000 4186d000 r-xp /usr/lib/libcrypto.so.1.0.0
4186d000 41882000 rwxp /usr/lib/libcrypto.so.1.0.0
41887000 41892000 r-xp /usr/lib/libgpg-error.so.0.15.0
41899000 4189a000 rwxp /usr/lib/libgpg-error.so.0.15.0
4189a000 42e19000 r-xp /usr/lib/libicudata.so.51.1
42e20000 42e21000 rwxp /usr/lib/libicudata.so.51.1
42e21000 42e26000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42e2e000 42e2f000 rwxp /usr/lib/libmmutil_jpeg.so.0.0.0
42e2f000 42e34000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42e3b000 42e3c000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
42e3d000 42e3f000 r-xp /usr/lib/libdri2.so.0.0.0
42e46000 42e47000 rwxp /usr/lib/libdri2.so.0.0.0
42e47000 42e68000 r-xp /usr/lib/libexif.so.12.3.3
42e6f000 42e7b000 rwxp /usr/lib/libexif.so.12.3.3
42e7b000 42e80000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
42e87000 42e88000 rwxp /usr/lib/libcapi-media-tool.so.0.1.5
42f8f000 43059000 r-xp /usr/lib/libCOREGL.so.4.0
43061000 43063000 rwxp /usr/lib/libCOREGL.so.4.0
4306b000 4308f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
43096000 43098000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
43098000 43167000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4316e000 4317d000 rwxp /usr/lib/libscim-1.0.so.8.2.3
4317d000 431aa000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
431b1000 431b2000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
431b2000 431cf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
431d7000 431d8000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
431d8000 431da000 r-xp /usr/lib/libiri.so
431e1000 431e2000 rwxp /usr/lib/libiri.so
431e2000 431e5000 r-xp /lib/libcap.so.2.21
431ec000 431ed000 rwxp /lib/libcap.so.2.21
431ed000 431f4000 r-xp /lib/libcrypt-2.13.so
431fb000 431fc000 r-xp /lib/libcrypt-2.13.so
431fc000 431fd000 rwxp /lib/libcrypt-2.13.so
43224000 43227000 r-xp /lib/libattr.so.1.1.0
4322e000 4322f000 rwxp /lib/libattr.so.1.1.0
4322f000 43239000 r-xp /lib/libnss_files-2.13.so
43240000 43241000 r-xp /lib/libnss_files-2.13.so
43241000 43242000 rwxp /lib/libnss_files-2.13.so
43242000 43442000 r-xp /usr/share/locale/locale-archive
43442000 43573000 r-xp /usr/share/locale/locale-archive
43573000 435ea000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
435f2000 435f4000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
435fa000 43742000 r-xp /usr/lib/egl/libMali.so
43742000 43747000 rwxp /usr/lib/egl/libMali.so
43748000 4374b000 rwxp [stack:25903]
4374b000 4374f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43756000 43757000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43757000 4375b000 rwxs /dev/mali
4375c000 4375f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43766000 43767000 rwxp /usr/lib/libnative-buffer.so.0.1.0
43768000 43f67000 rwxp [stack:25902]
43f67000 43f6f000 rwxs /dev/mali
43f6f000 43f77000 rwxs /dev/mali
43f77000 43f8b000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
4408b000 4408f000 rwxs /dev/mali
4408f000 44093000 rwxs /dev/mali
44093000 4409b000 rwxs /dev/mali
4409b000 440a3000 rwxs /dev/mali
440a3000 440a5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
440a5000 44244000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
44244000 4425b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44263000 44268000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44368000 4436a000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44371000 44372000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44b73000 45372000 rwxp [stack:25969]
45372000 45375000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
45375000 45379000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
45379000 45388000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
45388000 453c8000 rwxs /dev/mali
453c8000 453cf000 r-xs /usr/lib/gconv/gconv-modules.cache
453cf000 453d0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
453d7000 453d8000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
453dc000 45400000 rwxs /dev/mali
45500000 45540000 rwxs /dev/mali
45540000 45564000 rwxs /dev/mali
45570000 45580000 rwxs /dev/mali
45580000 45584000 rwxs /dev/mali
45584000 45588000 rwxs /dev/mali
45594000 455b8000 rwxs /dev/mali
455b8000 455bc000 rwxs /dev/mali
455bc000 455e0000 rwxs /dev/mali
455e8000 455f8000 rwxs /dev/mali
455f8000 45608000 rwxs /dev/mali
45608000 45693000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
45694000 45f93000 rwxp [stack:25906]
45f93000 45fd3000 rwxs /dev/mali
45fd3000 460e7000 rwxs /dev/mali
460e7000 46173000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
46173000 461fb000 rwxs /dev/mali
461fb000 4620b000 rwxs /dev/mali
4620b000 4621b000 rwxs /dev/mali
4621b000 4623f000 rwxs /dev/mali
4624b000 4625b000 rwxs /dev/mali
4625b000 4626b000 rwxs /dev/mali
4626b000 4628f000 rwxs /dev/mali
462a7000 462ef000 rwxs /dev/mali
462ef000 46337000 rwxs /dev/mali
46343000 46383000 rwxs /dev/mali
46383000 463c3000 rwxs /dev/mali
463c3000 4640b000 rwxs /dev/mali
4646f000 46470000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
46477000 46478000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4648d000 46494000 r-xp /usr/lib/libfeedback.so.0.1.4
4649c000 4649d000 rwxp /usr/lib/libfeedback.so.0.1.4
4649d000 4649e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
464a5000 464a6000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
464a6000 464a8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
464af000 464b0000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
464b0000 464ba000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
464c1000 464c2000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
464c2000 464c9000 r-xp /usr/lib/libmmfcommon.so.0.0.0
464d0000 464d1000 rwxp /usr/lib/libmmfcommon.so.0.0.0
464d1000 464e7000 r-xp /usr/lib/libmmfsound.so.0.1.0
464ef000 464f0000 rwxp /usr/lib/libmmfsound.so.0.1.0
464f9000 464fe000 r-xp /usr/lib/libmmfsession.so.0.0.0
46505000 46506000 rwxp /usr/lib/libmmfsession.so.0.0.0
46506000 46510000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
46518000 46519000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
4651c000 46520000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
46528000 46529000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
46529000 4653f000 r-xp /usr/lib/libavsysaudio.so.0.0.1
46547000 46548000 rwxp /usr/lib/libavsysaudio.so.0.0.1
46548000 4654d000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
46554000 46555000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
46555000 46558000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4655f000 46560000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46560000 465c1000 r-xp /usr/lib/libasound.so.2.0.0
465c8000 465cb000 rwxp /usr/lib/libasound.so.2.0.0
465cb000 46603000 r-xp /usr/lib/libpulse.so.0.16.2
46603000 46604000 rwxp /usr/lib/libpulse.so.0.16.2
46604000 46607000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4660e000 4660f000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
4660f000 4661c000 r-xp /usr/lib/libail.so.0.1.0
46624000 46625000 rwxp /usr/lib/libail.so.0.1.0
46625000 46635000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
46635000 46639000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
46656000 4665e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
46665000 46666000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
4666d000 46670000 r-xp /usr/lib/libcompress.so.0.2.0
46677000 46678000 rwxp /usr/lib/libcompress.so.0.2.0
46678000 4667d000 r-xp /usr/lib/libjson.so.0.0.1
46684000 46685000 rwxp /usr/lib/libjson.so.0.0.1
46685000 466cd000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
466cd000 466ce000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
466ce000 46711000 r-xp /usr/lib/libsndfile.so.1.0.25
46718000 4671a000 rwxp /usr/lib/libsndfile.so.1.0.25
4671e000 46740000 r-xp /usr/lib/libvorbis.so.0.4.3
46747000 46748000 rwxp /usr/lib/libvorbis.so.0.4.3
46748000 4674c000 r-xp /usr/lib/libogg.so.0.7.1
46753000 46754000 rwxp /usr/lib/libogg.so.0.7.1
46854000 4689c000 rwxs /dev/mali
4689c000 468e4000 rwxs /dev/mali
46900000 4693a000 r-xs /opt/usr/apps/org.example.ph1/res/edje/timer.edj
469c2000 46a0a000 rwxs /dev/mali
46a0a000 46a52000 rwxs /dev/mali
46a52000 46a9a000 rwxs /dev/mali
46a9a000 46ae2000 rwxs /dev/mali
46ae2000 46b2a000 rwxs /dev/mali
46b2a000 46b72000 rwxs /dev/mali
46b72000 46bba000 rwxs /dev/mali
46bba000 46c02000 rwxs /dev/mali
46c02000 46c4a000 rwxs /dev/mali
46c4a000 46c92000 rwxs /dev/mali
46c92000 46cda000 rwxs /dev/mali
46cda000 46d62000 rwxs /dev/mali
46d62000 46dea000 rwxs /dev/mali
46dea000 46f10000 r-xp /usr/share/fallback_fonts/BreezeSansKorean-RegularCondensed.ttf
beb8c000 bebad000 rwxp [stack]
End of Maps Information

Callstack Information (PID:25896)
Call Stack Count: 1
 0: (0x4039c1f4) [/lib/libc.so.6] + 0x331f4
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
43.484+0900 E/AUL     (  474): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 20:41:43.519+0900 I/MALI    (25896): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42f4f010] swap changed from async to sync
05-26 20:41:43.964+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: MEM_FLUSH State: PAUSED
05-26 20:41:44.924+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:41:44.924+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:41:44.924+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:41:44.924+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:41:44.924+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:41:44.929+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 20:41:44.929+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 20:41:44.929+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 20:41:44.934+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 20:41:44.934+0900 W/W_HOME  (  726): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-26 20:41:44.994+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-26 20:41:44.994+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-26 20:41:44.994+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 20:41:44.994+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-26 20:41:44.994+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-26 20:41:44.994+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:41:44.994+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:41:44.994+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:41:44.994+0900 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [gesture] after screen off time [6174]ms
05-26 20:41:44.994+0900 W/STARTER (  696): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-26 20:41:44.994+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-26 20:41:44.994+0900 W/W_HOME  (  726): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-26 20:41:44.994+0900 W/W_HOME  (  726): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-26 20:41:44.994+0900 W/W_HOME  (  726): gesture.c: _apps_status_get(123) > apps status:0
05-26 20:41:44.994+0900 W/W_HOME  (  726): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:6174
05-26 20:41:44.994+0900 W/W_HOME  (  726): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-26 20:41:44.994+0900 W/W_HOME  (  726): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-26 20:41:44.994+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 20:41:45.004+0900 I/APP_CORE(25896): appcore-efl.c: __do_app(429) > [APP 25896] Event: RESUME State: RUNNING
05-26 20:41:45.009+0900 W/ALARM_MANAGER(  470): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-26 20:41:45.009+0900 W/ALARM_MANAGER(  470): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-26 20:41:45.009+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1868306785)
05-26 20:41:45.009+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-26 20:41:45.009+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 26-5-2016, 12:11:49 (UTC).
05-26 20:41:45.009+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-26 20:41:45.009+0900 E/ALARM_MANAGER(  470): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1868306785] is removed.
05-26 20:41:45.039+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1445]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-26 20:41:45.049+0900 I/SHealth_Common( 1056): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-26 20:41:45.049+0900 I/SHealth_Service( 1056): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-26 20:41:45.064+0900 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [gesture]
05-26 20:41:45.064+0900 W/STARTER (  696): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-26 20:41:45.174+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 20:41:45.174+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 20:41:45.174+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : pedometer_inactive_period error
05-26 20:41:45.174+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 20:41:45.174+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 20:41:45.174+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_10min_precaution_millisec error
05-26 20:41:45.174+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 20:41:45.174+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 20:41:45.174+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_before_10min_precaution_millisec error
05-26 20:41:45.194+0900 W/W_HOME  (  726): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-26 20:41:45.194+0900 W/W_HOME  (  726): gesture.c: _manual_render_enable(133) > 0
05-26 20:41:46.584+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11017069 button=1 downs=1
05-26 20:41:46.619+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11017107 button=1 downs=0
05-26 20:41:47.239+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11017711 button=1 downs=1
05-26 20:41:47.274+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11017761 button=1 downs=0
05-26 20:41:47.624+0900 I/CAPI_NETWORK_CONNECTION(25896): connection.c: connection_create(372) > New handle created[0x44312f48]
05-26 20:41:47.654+0900 I/SOCKETTEST(25896): IP : 
05-26 20:41:47.654+0900 I/SOCKETTEST(25896): Success to create UDP socket
05-26 20:41:47.654+0900 I/SOCKETTEST(25896): Bind Success
05-26 20:41:47.654+0900 I/SOCKETTEST(25896): Waiting DATA...
05-26 20:41:50.134+0900 I/SOCKETTEST(25896): Receive Data : 192.168.0.42
05-26 20:41:50.134+0900 I/SOCKETTEST(25896): Changed IP : 192.168.0.42
05-26 20:41:50.194+0900 I/SOCKETTEST(25896): Success to create socket
05-26 20:41:50.209+0900 I/SOCKETTEST(25896): Success to socket connection
05-26 20:41:50.209+0900 I/SOCKETTEST(25896): write() 성공
05-26 20:41:51.924+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11022405 button=1 downs=1
05-26 20:41:51.959+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11022444 button=1 downs=0
05-26 20:41:52.004+0900 D/TIMER   (25896): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 20:41:52.004+0900 D/TIMER   (25896): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 20:41:52.049+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 20:41:52.049+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 20:41:52.049+0900 I/efl-extension(25896): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 20:41:52.054+0900 I/efl-extension(25896): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 20:41:52.054+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45e999c0, elm_layout, _activated_obj : 0x0, activated : 1
05-26 20:41:53.494+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11023979 button=1 downs=1
05-26 20:41:53.519+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11024005 button=1 downs=0
05-26 20:41:54.034+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11024519 button=1 downs=1
05-26 20:41:54.104+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11024588 button=1 downs=0
05-26 20:41:54.589+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:54.594+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:54.594+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45e999c0, elm_layout, time_stamp : 11025075
05-26 20:41:54.594+0900 E/TIMER   (25896): (ad->timer) -> _rotary_cb() return
05-26 20:41:54.619+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:54.619+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45e999c0, elm_layout, time_stamp : 11025107
05-26 20:41:54.619+0900 E/TIMER   (25896): (ad->timer) -> _rotary_cb() return
05-26 20:41:54.619+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:54.664+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:54.664+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45e999c0, elm_layout, time_stamp : 11025151
05-26 20:41:54.664+0900 E/TIMER   (25896): (ad->timer) -> _rotary_cb() return
05-26 20:41:54.664+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:55.049+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11025534 button=1 downs=1
05-26 20:41:55.094+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11025579 button=1 downs=0
05-26 20:41:55.094+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:41:55.094+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45e999c0, elm_layout, func : 0x400037d1
05-26 20:41:55.094+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 20:41:55.094+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 20:41:55.094+0900 I/efl-extension(25896): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 20:41:55.094+0900 I/efl-extension(25896): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 20:41:55.094+0900 I/efl-extension(25896): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 20:41:55.094+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:41:55.094+0900 E/EFL     (25896): ecore<25896> ecore.c:574 _ecore_magic_fail() 
05-26 20:41:55.094+0900 E/EFL     (25896): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 20:41:55.094+0900 E/EFL     (25896): *** IN FUNCTION: ecore_timer_del()
05-26 20:41:55.094+0900 E/EFL     (25896): ecore<25896> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 20:41:55.094+0900 E/EFL     (25896):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 20:41:55.094+0900 E/EFL     (25896):     Supplied: e5933114 - <UNKNOWN>
05-26 20:41:55.094+0900 E/EFL     (25896): ecore<25896> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 20:41:55.094+0900 E/EFL     (25896): *** SPANK SPANK SPANK!!!
05-26 20:41:55.094+0900 E/EFL     (25896): *** Now go fix your code. Tut tut tut!
05-26 20:41:55.094+0900 E/EFL     (25896): ecore<25896> ecore.c:574 _ecore_magic_fail() 
05-26 20:41:55.094+0900 E/EFL     (25896): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-26 20:41:55.094+0900 E/EFL     (25896): *** IN FUNCTION: ecore_timer_del()
05-26 20:41:55.094+0900 E/EFL     (25896): ecore<25896> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-26 20:41:55.094+0900 E/EFL     (25896):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-26 20:41:55.094+0900 E/EFL     (25896):     Supplied: 403d8280 - <UNKNOWN>
05-26 20:41:55.094+0900 E/EFL     (25896): ecore<25896> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-26 20:41:55.094+0900 E/EFL     (25896): *** SPANK SPANK SPANK!!!
05-26 20:41:55.094+0900 E/EFL     (25896): *** Now go fix your code. Tut tut tut!
05-26 20:41:55.094+0900 I/SOCKETTEST(25896): Success to create socket
05-26 20:41:55.159+0900 I/SOCKETTEST(25896): Success to socket connection
05-26 20:41:55.159+0900 I/SOCKETTEST(25896): write() 성공
05-26 20:41:55.159+0900 W/efl-extension(25896): efl_extension_events.c: eext_object_event_callback_del(319) > This object(0x45e999c0) hasn't been registered before
05-26 20:41:55.929+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:55.964+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:56.354+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:56.389+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:56.449+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:56.829+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11027315 button=1 downs=1
05-26 20:41:56.864+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11027351 button=1 downs=0
05-26 20:41:56.864+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:41:56.864+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45e999c0, elm_layout, func : 0x400037d1
05-26 20:41:56.864+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:41:56.864+0900 D/TIMER   (25896): Setting time is 0
05-26 20:41:56.864+0900 E/TIMER   (25896): (!ad->setting_time) -> _start_clicked_cb() return
05-26 20:41:57.379+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:57.419+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:57.659+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 20:41:57.684+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 20:41:57.729+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 20:41:57.914+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:57.939+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:57.969+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:58.014+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:58.389+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:58.419+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:58.474+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:58.729+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:58.764+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:58.819+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:59.089+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:59.119+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:59.144+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:59.174+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:59.209+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:59.269+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:41:59.414+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 20:42:00.614+0900 I/efl-extension(25896): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x45e999c0
05-26 20:42:00.614+0900 I/efl-extension(25896): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45e999c0, obj: 0x45e999c0
05-26 20:42:00.614+0900 I/efl-extension(25896): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 20:42:00.644+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 20:42:00.644+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 20:42:00.644+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : pedometer_inactive_period error
05-26 20:42:00.644+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 20:42:00.644+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 20:42:00.644+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_10min_precaution_millisec error
05-26 20:42:00.644+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 20:42:00.644+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 20:42:00.644+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_before_10min_precaution_millisec error
05-26 20:42:00.799+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 20:42:00.799+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11031282 button=1 downs=1
05-26 20:42:00.854+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11031340 button=1 downs=0
05-26 20:42:00.854+0900 D/TIMER   (25896): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-26 20:42:00.854+0900 D/TIMER   (25896): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-26 20:42:00.864+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 20:42:00.864+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x454050b8, elm_layout, _activated_obj : 0x0, activated : 1
05-26 20:42:01.359+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11031843 button=1 downs=1
05-26 20:42:01.429+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11031915 button=1 downs=0
05-26 20:42:01.904+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:01.909+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:01.909+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x454050b8, elm_layout, time_stamp : 11032393
05-26 20:42:01.939+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:01.939+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:01.939+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x454050b8, elm_layout, time_stamp : 11032424
05-26 20:42:01.954+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:01.954+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:01.954+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x454050b8, elm_layout, time_stamp : 11032442
05-26 20:42:01.979+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:01.979+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:01.979+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x454050b8, elm_layout, time_stamp : 11032466
05-26 20:42:02.004+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.004+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.004+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x454050b8, elm_layout, time_stamp : 11032491
05-26 20:42:02.034+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.034+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x454050b8, elm_layout, time_stamp : 11032522
05-26 20:42:02.039+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.464+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.464+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x454050b8, elm_layout, time_stamp : 11032949
05-26 20:42:02.469+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.519+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.519+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.519+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x454050b8, elm_layout, time_stamp : 11033007
05-26 20:42:02.619+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.619+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.619+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x454050b8, elm_layout, time_stamp : 11033105
05-26 20:42:02.934+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.934+0900 I/efl-extension(25896): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:42:02.934+0900 I/efl-extension(25896): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x454050b8, elm_layout, time_stamp : 11033420
05-26 20:42:03.924+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11034408 button=1 downs=1
05-26 20:42:03.969+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11034455 button=1 downs=0
05-26 20:42:03.969+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:42:03.969+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x454050b8, elm_layout, func : 0x400037d1
05-26 20:42:03.969+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 20:42:03.969+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 20:42:03.969+0900 I/efl-extension(25896): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 20:42:03.969+0900 I/efl-extension(25896): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 20:42:03.969+0900 I/efl-extension(25896): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 20:42:03.969+0900 I/efl-extension(25896): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:42:03.969+0900 D/TIMER   (25896): Setting time is 10
05-26 20:42:04.049+0900 I/SOCKETTEST(25896): Success to create socket
05-26 20:42:04.054+0900 I/SOCKETTEST(25896): Success to socket connection
05-26 20:42:04.054+0900 I/SOCKETTEST(25896): write() 성공
05-26 20:42:04.089+0900 I/SENSOR  (25896): 178.779999, 149.449997, 48.160000
05-26 20:42:04.169+0900 I/SENSOR  (25896): -2.870000, -7.000000, 5.950000
05-26 20:42:04.294+0900 I/SENSOR  (25896): -2.730000, -6.370000, 5.810000
05-26 20:42:04.369+0900 I/SENSOR  (25896): -0.630000, -6.160000, 5.670000
05-26 20:42:04.474+0900 I/SENSOR  (25896): -2.520000, -2.100000, 2.450000
05-26 20:42:04.634+0900 I/SENSOR  (25896): -4.830000, -1.890000, 3.080000
05-26 20:42:04.669+0900 I/SENSOR  (25896): -2.310000, -3.640000, 6.160000
05-26 20:42:04.799+0900 I/SENSOR  (25896): -3.220000, -3.150000, 4.900000
05-26 20:42:04.869+0900 I/SENSOR  (25896): -3.150000, -4.480000, 3.990000
05-26 20:42:04.989+0900 I/SENSOR  (25896): 0.210000, -3.570000, 4.480000
05-26 20:42:05.074+0900 I/SENSOR  (25896): 2.590000, -3.010000, 4.900000
05-26 20:42:05.169+0900 I/SENSOR  (25896): 1.050000, -2.100000, 4.340000
05-26 20:42:05.289+0900 I/SENSOR  (25896): -0.210000, -2.310000, 4.550000
05-26 20:42:05.369+0900 I/SENSOR  (25896): -0.560000, -4.270000, 4.270000
05-26 20:42:05.479+0900 I/SENSOR  (25896): 0.630000, -3.500000, 4.550000
05-26 20:42:05.634+0900 I/SENSOR  (25896): -0.490000, -3.150000, 4.200000
05-26 20:42:05.669+0900 I/SENSOR  (25896): -0.770000, -2.800000, 4.410000
05-26 20:42:05.789+0900 I/SENSOR  (25896): -0.980000, -3.430000, 4.550000
05-26 20:42:05.874+0900 I/SENSOR  (25896): -0.980000, -3.570000, 4.690000
05-26 20:42:05.989+0900 I/SENSOR  (25896): -0.350000, -3.500000, 4.340000
05-26 20:42:06.134+0900 I/SENSOR  (25896): -1.120000, -3.290000, 4.690000
05-26 20:42:06.169+0900 I/SENSOR  (25896): -1.890000, -3.640000, 4.550000
05-26 20:42:06.309+0900 I/SENSOR  (25896): -1.820000, -3.430000, 4.410000
05-26 20:42:06.374+0900 I/SENSOR  (25896): -0.560000, -3.780000, 4.550000
05-26 20:42:06.474+0900 I/SENSOR  (25896): 0.700000, -3.850000, 4.830000
05-26 20:42:06.624+0900 I/SENSOR  (25896): -2.030000, -3.010000, 3.920000
05-26 20:42:06.669+0900 I/SENSOR  (25896): -0.350000, -3.220000, 4.690000
05-26 20:42:06.789+0900 I/SENSOR  (25896): -3.430000, -3.640000, 11.060000
05-26 20:42:06.874+0900 I/SENSOR  (25896): -23.309999, 33.180000, 58.029999
05-26 20:42:06.984+0900 I/SENSOR  (25896): -53.130001, -4.480000, 159.460007
05-26 20:42:07.079+0900 I/SENSOR  (25896): -109.270004, -28.490000, 106.889999
05-26 20:42:07.174+0900 I/SENSOR  (25896): -53.340000, 19.389999, 38.639999
05-26 20:42:07.289+0900 I/SENSOR  (25896): -30.730000, -6.650000, 21.559999
05-26 20:42:07.374+0900 I/SENSOR  (25896): 43.330002, 0.700000, -7.000000
05-26 20:42:07.479+0900 I/SENSOR  (25896): -6.510000, -4.130000, 17.920000
05-26 20:42:07.624+0900 I/SENSOR  (25896): -32.200001, -66.639999, -26.600000
05-26 20:42:07.674+0900 I/SENSOR  (25896): -7.840000, -52.779999, -36.889999
05-26 20:42:07.789+0900 I/SENSOR  (25896): 20.650000, -6.090000, 8.400000
05-26 20:42:07.874+0900 I/SENSOR  (25896): -8.680000, 8.960000, 32.270000
05-26 20:42:07.979+0900 I/SENSOR  (25896): -79.730003, 31.710001, 82.180000
05-26 20:42:08.079+0900 I/SENSOR  (25896): -2006.969971, -394.940002, 63.490002
05-26 20:42:08.079+0900 I/SENSOR  (25896): 앞으로 
05-26 20:42:08.079+0900 I/SOCKETTEST(25896): Success to create socket
05-26 20:42:08.114+0900 I/SOCKETTEST(25896): Success to socket connection
05-26 20:42:08.114+0900 I/SOCKETTEST(25896): write() 성공
05-26 20:42:08.184+0900 I/SENSOR  (25896): 301.489990, -51.029999, 18.620001
05-26 20:42:08.274+0900 I/SENSOR  (25896): 970.270020, 85.959999, -6.650000
05-26 20:42:08.319+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:08.319+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:08.319+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:08.319+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:08.319+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:08.374+0900 I/SENSOR  (25896): 54.110001, -74.129997, -45.290001
05-26 20:42:08.474+0900 I/SENSOR  (25896): 293.860016, 26.040001, -50.119999
05-26 20:42:08.574+0900 I/SENSOR  (25896): -8.540000, -14.070000, 3.220000
05-26 20:42:08.674+0900 I/SENSOR  (25896): -151.690002, 23.030001, 83.090004
05-26 20:42:08.824+0900 I/SENSOR  (25896): -1666.560059, -411.459991, -155.330002
05-26 20:42:08.824+0900 I/SENSOR  (25896): 앞으로 
05-26 20:42:08.824+0900 I/SOCKETTEST(25896): Success to create socket
05-26 20:42:08.864+0900 I/SOCKETTEST(25896): Success to socket connection
05-26 20:42:08.869+0900 I/SOCKETTEST(25896): write() 성공
05-26 20:42:08.879+0900 I/SENSOR  (25896): -209.580002, -68.389999, 7.630000
05-26 20:42:08.974+0900 I/SENSOR  (25896): 568.750000, -4.830000, 23.520000
05-26 20:42:09.079+0900 I/SENSOR  (25896): 793.450012, -3.220000, -132.930008
05-26 20:42:09.174+0900 I/SENSOR  (25896): -89.250000, -22.190001, 2.170000
05-26 20:42:09.274+0900 I/SENSOR  (25896): -147.279999, -34.230000, 52.779999
05-26 20:42:09.374+0900 I/SENSOR  (25896): -3.220000, -24.920000, 57.400002
05-26 20:42:09.484+0900 I/SENSOR  (25896): -318.220001, 2.870000, 136.220001
05-26 20:42:09.624+0900 I/SENSOR  (25896): -1210.020020, -197.119995, -204.680008
05-26 20:42:09.629+0900 I/SENSOR  (25896): 앞으로 
05-26 20:42:09.644+0900 I/SOCKETTEST(25896): Success to create socket
05-26 20:42:09.789+0900 I/SOCKETTEST(25896): Success to socket connection
05-26 20:42:09.794+0900 I/SOCKETTEST(25896): write() 성공
05-26 20:42:09.794+0900 I/SENSOR  (25896): 89.809998, 141.399994, 75.879997
05-26 20:42:09.799+0900 I/SENSOR  (25896): 547.539978, 197.050003, 0.980000
05-26 20:42:09.839+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:09.839+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:09.844+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:09.844+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:09.844+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:09.874+0900 I/SENSOR  (25896): 603.330017, 3.150000, -76.860001
05-26 20:42:09.974+0900 I/SENSOR  (25896): 143.850006, 9.100000, -40.670002
05-26 20:42:10.054+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 20:42:10.054+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 20:42:10.054+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 20:42:10.059+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:10.059+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:10.059+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:10.059+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:10.059+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:10.059+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 20:42:10.079+0900 I/SENSOR  (25896): -1252.579956, 59.990002, 49.770000
05-26 20:42:10.079+0900 I/SENSOR  (25896): 앞으로 
05-26 20:42:10.079+0900 I/SOCKETTEST(25896): Success to create socket
05-26 20:42:10.094+0900 I/SOCKETTEST(25896): Success to socket connection
05-26 20:42:10.094+0900 I/SOCKETTEST(25896): write() 성공
05-26 20:42:10.174+0900 I/SENSOR  (25896): 373.450012, 126.629997, -2.590000
05-26 20:42:10.274+0900 I/SENSOR  (25896): 160.229996, -237.720001, 92.959999
05-26 20:42:10.374+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:10.374+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:10.374+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:10.374+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:10.374+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:10.379+0900 I/SENSOR  (25896): 668.359985, 70.209999, 28.350000
05-26 20:42:10.474+0900 I/SENSOR  (25896): 356.579987, 31.920000, -72.590004
05-26 20:42:10.574+0900 I/SENSOR  (25896): -58.869999, -26.389999, -28.280001
05-26 20:42:10.679+0900 I/SENSOR  (25896): -203.839996, -31.850000, 41.020000
05-26 20:42:10.759+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:10.759+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:10.759+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:10.759+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:10.759+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:10.774+0900 I/SENSOR  (25896): -258.860016, -70.000000, 40.389999
05-26 20:42:10.874+0900 I/SENSOR  (25896): -239.960007, -54.950001, 13.510000
05-26 20:42:10.974+0900 I/SENSOR  (25896): 1207.920044, 163.309998, 45.639999
05-26 20:42:10.984+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:10.984+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:10.984+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:10.984+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:10.984+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:11.074+0900 I/SENSOR  (25896): 168.490005, 256.480011, -328.299988
05-26 20:42:11.174+0900 I/SENSOR  (25896): -109.270004, 10.710000, 84.840004
05-26 20:42:11.274+0900 I/SENSOR  (25896): -419.510010, -70.699997, 24.430000
05-26 20:42:11.374+0900 I/SENSOR  (25896): -480.690002, -51.029999, -9.870000
05-26 20:42:11.444+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:11.444+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:11.449+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:11.449+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:11.449+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:11.479+0900 I/SENSOR  (25896): -499.940002, -42.349998, -30.380001
05-26 20:42:11.574+0900 I/SENSOR  (25896): 538.090027, -18.200001, 49.000000
05-26 20:42:11.679+0900 I/SENSOR  (25896): 758.309998, -26.600000, -184.380005
05-26 20:42:11.779+0900 I/SENSOR  (25896): -182.559998, -8.540000, 58.170002
05-26 20:42:11.879+0900 I/SENSOR  (25896): -377.019989, -86.940002, 64.750000
05-26 20:42:11.969+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:11.969+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:11.969+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:11.969+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:11.969+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:11.994+0900 I/SENSOR  (25896): -489.440002, -92.050003, -34.090000
05-26 20:42:12.074+0900 I/SENSOR  (25896): -542.359985, -67.480003, -59.220001
05-26 20:42:12.179+0900 I/SENSOR  (25896): 1947.820068, 756.489990, -199.779999
05-26 20:42:12.274+0900 I/SENSOR  (25896): -46.340000, 84.559998, 67.059998
05-26 20:42:12.374+0900 I/SENSOR  (25896): -306.110016, -21.420000, 43.820000
05-26 20:42:12.479+0900 I/SENSOR  (25896): -625.659973, -157.919998, -57.540001
05-26 20:42:12.629+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:12.629+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:12.629+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:12.629+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:12.629+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:12.634+0900 I/SENSOR  (25896): -539.140015, -73.779999, -69.300003
05-26 20:42:12.679+0900 I/SENSOR  (25896): 1687.560059, 281.610016, 116.199997
05-26 20:42:12.779+0900 I/SENSOR  (25896): 121.239998, -14.000000, -131.460007
05-26 20:42:12.879+0900 I/SENSOR  (25896): -255.149994, -6.720000, 37.029999
05-26 20:42:12.979+0900 I/SENSOR  (25896): -661.359985, -162.889999, -101.989998
05-26 20:42:13.119+0900 I/SENSOR  (25896): -732.830017, -60.200001, -27.370001
05-26 20:42:13.144+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:13.144+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:13.149+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:13.149+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:13.149+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:13.179+0900 I/SENSOR  (25896): 1734.810059, 427.279999, 201.250000
05-26 20:42:13.279+0900 I/SENSOR  (25896): 62.369999, -39.970001, -33.110001
05-26 20:42:13.379+0900 I/SENSOR  (25896): -80.080002, -90.090004, -9.100000
05-26 20:42:13.479+0900 I/SENSOR  (25896): -60.340000, -206.850006, -82.809998
05-26 20:42:13.579+0900 I/SENSOR  (25896): 122.709999, -91.699997, 18.480000
05-26 20:42:13.584+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 20:42:13.584+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 20:42:13.584+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 20:42:13.584+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 20:42:13.584+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 20:42:13.584+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:42:13.584+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:42:13.584+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:42:13.589+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 20:42:13.679+0900 I/SENSOR  (25896): 160.089996, 10.850000, -12.600000
05-26 20:42:13.784+0900 I/SENSOR  (25896): 175.839996, 57.540001, -23.590000
05-26 20:42:13.879+0900 I/SENSOR  (25896): -25.410000, -52.639999, -17.290001
05-26 20:42:13.984+0900 I/SENSOR  (25896): -1.750000, -52.150002, -35.770000
05-26 20:42:14.124+0900 I/SENSOR  (25896): -65.660004, -45.290001, 8.820000
05-26 20:42:14.179+0900 I/SENSOR  (25896): -14.490000, -22.680000, 4.550000
05-26 20:42:14.284+0900 I/SENSOR  (25896): 43.189999, -0.350000, -67.620003
05-26 20:42:14.389+0900 I/SENSOR  (25896): -24.080000, -1.680000, 35.560001
05-26 20:42:14.484+0900 I/SENSOR  (25896): -13.160000, -44.730000, 13.440001
05-26 20:42:14.579+0900 I/SENSOR  (25896): -18.200001, 33.180000, 23.660000
05-26 20:42:14.674+0900 I/SHealth_Service( 1056): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-26 20:42:14.679+0900 I/SENSOR  (25896): -22.680000, -30.730000, 3.570000
05-26 20:42:14.774+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 20:42:14.779+0900 I/SENSOR  (25896): 11.200000, -37.939999, 26.110001
05-26 20:42:14.819+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:42:14.849+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:42:14.879+0900 W/SHealth_Common( 1056): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-26 20:42:14.879+0900 I/SENSOR  (25896): -10.430000, 10.430000, -2.310000
05-26 20:42:14.909+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
05-26 20:42:14.914+0900 I/HealthDataService(  801): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-26 20:42:14.939+0900 I/healthData( 1056): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-26 20:42:14.979+0900 I/SENSOR  (25896): -3.500000, 0.700000, 5.110000
05-26 20:42:15.104+0900 I/SENSOR  (25896): -4.900000, -5.460000, 6.440000
05-26 20:42:15.154+0900 I/efl-extension(25896): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x454050b8
05-26 20:42:15.154+0900 I/efl-extension(25896): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x454050b8, obj: 0x454050b8
05-26 20:42:15.154+0900 I/efl-extension(25896): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 20:42:15.179+0900 I/SENSOR  (25896): -5.600000, 0.070000, 0.840000
05-26 20:42:15.279+0900 I/SENSOR  (25896): -3.080000, -4.620000, 5.460000
05-26 20:42:15.324+0900 E/EFL     (25896): evas_main<25896> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11045811 button=1 downs=1
05-26 20:42:15.374+0900 E/EFL     (25896): evas_main<25896> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11045860 button=1 downs=0
05-26 20:42:15.469+0900 I/SENSOR  (25896): 3.780000, -19.809999, -8.120000
05-26 20:42:15.499+0900 I/SENSOR  (25896): -0.210000, -7.910000, 2.240000
05-26 20:42:15.579+0900 I/SENSOR  (25896): -0.070000, -2.520000, 4.620000
05-26 20:42:15.679+0900 I/SENSOR  (25896): 1.120000, -2.940000, 4.690000
05-26 20:42:15.779+0900 I/SENSOR  (25896): -2.170000, -1.750000, 5.250000
05-26 20:42:15.879+0900 I/SENSOR  (25896): -1.540000, -1.750000, 4.690000
05-26 20:42:15.984+0900 I/SENSOR  (25896): -1.400000, -1.400000, 3.850000
05-26 20:42:16.544+0900 W/CRASH_MANAGER(26014): worker.c: worker_job(1199) > 1125896706831146426293
