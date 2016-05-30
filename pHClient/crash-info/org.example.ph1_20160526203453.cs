S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 24467
Date: 2016-05-26 20:34:53+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4048f250, r3   = 0x00000000
r4   = 0x44caa948, r5   = 0x00000000
r6   = 0x44cab248, r7   = 0x00000000
r8   = 0x44caa948, r9   = 0x44ca9bc8
r10  = 0x44040530, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbe809638
lr   = 0x403d81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     37540 KB
Buffers:     46028 KB
Cached:     133404 KB
VmPeak:     108532 KB
VmSize:      98116 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20320 KB
VmRSS:       20320 KB
VmData:      42544 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50644 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 24467 TID = 24467
24467 24478 24481 

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
435fa000 43742000 r-xp /usr/lib/egl/libMali.so
43742000 43747000 rwxp /usr/lib/egl/libMali.so
43748000 4375c000 rwxp [stack:24478]
4375c000 4375f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43766000 43767000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440a3000 440a5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44b72000 44b75000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b75000 44b79000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b79000 44b88000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44bc8000 44bcf000 r-xs /usr/lib/gconv/gconv-modules.cache
45694000 45e93000 rwxp [stack:24481]
46329000 4632c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46333000 46334000 rwxp /usr/lib/libpulse-simple.so.0.0.4
4640a000 4640f000 r-xp /usr/lib/libjson.so.0.0.1
46416000 46417000 rwxp /usr/lib/libjson.so.0.0.1
4643f000 46443000 r-xp /usr/lib/libogg.so.0.7.1
4644a000 4644b000 rwxp /usr/lib/libogg.so.0.7.1
464e7000 4651f000 r-xp /usr/lib/libpulse.so.0.16.2
4651f000 46520000 rwxp /usr/lib/libpulse.so.0.16.2
46551000 46599000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46599000 4659a000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4659a000 465dd000 r-xp /usr/lib/libsndfile.so.1.0.25
465e4000 465e6000 rwxp /usr/lib/libsndfile.so.1.0.25
465ea000 4660c000 r-xp /usr/lib/libvorbis.so.0.4.3
46613000 46614000 rwxp /usr/lib/libvorbis.so.0.4.3
be7e9000 be80a000 rwxp [stack]
End of Maps Information

Callstack Information (PID:24467)
Call Stack Count: 2
 0: cfree + 0xc8 (0x403d81e8) [/lib/libc.so.6] + 0x6f1e8
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
65) > _MessagePortService::GetKey
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 20:34:50.849+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:34:50.849+0900 E/CAPI_APPFW_APP_CONTROL( 1445): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 20:34:50.849+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1445]   [com.samsung.w-home]register msg port [true][0m
05-26 20:34:50.849+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 20:34:50.854+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 726
05-26 20:34:50.859+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1445]   [MUSIC_PLAYER_EVENT][0m
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 20:34:50.859+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:34:50.859+0900 W/W_HOME  (  726): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 20:34:50.859+0900 E/W_HOME  (  726): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 20:34:50.864+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1445]   [MUSIC_PLAYER_EVENT][0m
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 20:34:50.864+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:34:50.864+0900 W/W_HOME  (  726): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
05-26 20:34:50.864+0900 E/W_HOME  (  726): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-26 20:34:50.964+0900 W/STARTER (  696): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-26 20:34:51.034+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:51.034+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:51.049+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-26 20:34:51.049+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-26 20:34:51.049+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-26 20:34:51.049+0900 W/STARTER (  696): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-26 20:34:51.144+0900 W/STARTER (  696): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-26 20:34:51.229+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:51.229+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:51.394+0900 W/STARTER (  696): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-26 20:34:51.409+0900 W/STARTER (  696): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-26 20:34:51.424+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:51.424+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:51.429+0900 E/STARTER (  696): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-26 20:34:51.439+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 20:34:51.454+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(1702) > caller pid : 696
05-26 20:34:51.464+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(2080) > pad pid(-5)
05-26 20:34:51.464+0900 E/RESOURCED(  475): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-26 20:34:51.464+0900 W/AUL_PAD (24473): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-26 20:34:51.464+0900 W/AUL_PAD (24473): launchpad.c: __send_result_to_caller(272) > Check app launching
05-26 20:34:51.479+0900 I/CAPI_APPFW_APPLICATION(24475): app_main.c: app_efl_main(129) > app_efl_main
05-26 20:34:51.479+0900 I/CAPI_APPFW_APPLICATION(24475): app_main.c: app_appcore_create(152) > app_appcore_create
05-26 20:34:51.569+0900 E/RESOURCED(  475): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-26 20:34:51.569+0900 E/AUL     (  696): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 20:34:51.619+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:51.619+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:51.664+0900 I/efl-extension(24475): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445acd78 = w: 0 h: 0  obj 0x44594838 w: 360 h: 360
05-26 20:34:51.664+0900 I/efl-extension(24475): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-26 20:34:51.664+0900 I/efl-extension(24475): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 20:34:51.664+0900 I/efl-extension(24475): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-26 20:34:51.664+0900 I/efl-extension(24475): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-26 20:34:51.669+0900 I/efl-extension(24475): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-26 20:34:51.669+0900 I/efl-extension(24475): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44594838, elm_image, _activated_obj : 0x0, activated : 1
05-26 20:34:51.764+0900 E/W_TASKMANAGER(24475): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-26 20:34:51.764+0900 E/W_TASKMANAGER(24475): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-26 20:34:51.764+0900 E/W_TASKMANAGER(24475): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-26 20:34:51.804+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.804+0900 E/W_TASKMANAGER(24475): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-26 20:34:51.809+0900 E/RUA     (24475): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 28, ncols : 5
05-26 20:34:51.819+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:51.819+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:51.834+0900 E/EFL     (24475): elementary<24475> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445964b8 into part 'elm.swallow.event.0'
05-26 20:34:51.874+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04600003)
05-26 20:34:51.899+0900 I/APP_CORE(24475): appcore-efl.c: __do_app(429) > [APP 24475] Event: RESET State: CREATED
05-26 20:34:51.899+0900 I/CAPI_APPFW_APPLICATION(24475): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 20:34:51.909+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
05-26 20:34:51.909+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:51.909+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:51.919+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:51.919+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
05-26 20:34:51.919+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-26 20:34:51.924+0900 I/APP_CORE(24475): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-26 20:34:51.924+0900 I/APP_CORE(24475): appcore-efl.c: __do_app(474) > [APP 24475] Initial Launching, call the resume_cb
05-26 20:34:51.924+0900 I/CAPI_APPFW_APPLICATION(24475): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 20:34:51.944+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04600003)
05-26 20:34:51.959+0900 W/APP_CORE(24475): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600003
05-26 20:34:52.014+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:52.014+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:52.024+0900 I/APP_CORE(24475): appcore-efl.c: __do_app(429) > [APP 24475] Event: RESUME State: RUNNING
05-26 20:34:52.024+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
05-26 20:34:52.024+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
05-26 20:34:52.024+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:52.024+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
05-26 20:34:52.024+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: PAUSE State: RUNNING
05-26 20:34:52.024+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 20:34:52.024+0900 W/W_HOME  (  726): main.c: _appcore_pause_cb(690) > appcore pause
05-26 20:34:52.024+0900 W/W_HOME  (  726): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 20:34:52.024+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:52.024+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:52.024+0900 W/W_HOME  (  726): main.c: home_pause(751) > clock/widget paused
05-26 20:34:52.024+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 20:34:52.029+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 20:34:52.034+0900 E/CAPI_APPFW_APP_CONTROL( 1445): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 20:34:52.044+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 20:34:52.049+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 20:34:52.059+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1445]   [com.samsung.w-home]register msg port [false][0m
05-26 20:34:52.119+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
05-26 20:34:52.119+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 20:34:52.129+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_pause(1001) > widget_pause
05-26 20:34:52.129+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppPause(713) > 
05-26 20:34:52.129+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:34:52.129+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:34:52.129+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:34:52.129+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:34:52.129+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:34:52.439+0900 E/AUL     (  474): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-26 20:34:52.484+0900 I/MALI    (24475): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x432f6600] swap changed from async to sync
05-26 20:34:52.499+0900 E/EFL     (24475): evas_main<24475> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=10602979 button=1 downs=1
05-26 20:34:52.529+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: MEM_FLUSH State: PAUSED
05-26 20:34:52.559+0900 E/EFL     (24475): evas_main<24475> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=10603042 button=1 downs=0
05-26 20:34:52.604+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 20:34:52.619+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24475
05-26 20:34:52.619+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 20:34:52.819+0900 E/EFL     (24475): elementary<24475> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44549750), freeze(1)
05-26 20:34:52.819+0900 E/EFL     (24475): elementary<24475> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44549750), freeze(1)
05-26 20:34:53.029+0900 I/efl-extension(24585): efl_extension.c: eext_mod_init(40) > Init
05-26 20:34:53.064+0900 I/UXT     (24585): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-26 20:34:53.164+0900 I/AUL_PAD (24585): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-26 20:34:53.189+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 20:34:53.199+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24467
05-26 20:34:53.204+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 27
05-26 20:34:53.204+0900 E/TBM     (24585): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-26 20:34:53.209+0900 I/APP_CORE(24467): appcore-efl.c: __do_app(429) > [APP 24467] Event: TERMINATE State: PAUSED
05-26 20:34:53.214+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 20:34:53.214+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 20:34:53.224+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 20:34:53.224+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 20:34:53.224+0900 E/APP_CORE(24475): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-26 20:34:53.224+0900 I/APP_CORE(24475): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 20:34:53.224+0900 I/APP_CORE(24475): appcore-efl.c: __after_loop(1090) > [APP 24475] PAUSE before termination
05-26 20:34:53.224+0900 I/CAPI_APPFW_APPLICATION(24475): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 20:34:53.224+0900 I/CAPI_APPFW_APPLICATION(24475): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-26 20:34:53.229+0900 I/efl-extension(24475): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44549750, obj: 0x44549750
05-26 20:34:53.229+0900 I/efl-extension(24475): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 20:34:53.229+0900 I/efl-extension(24475): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 20:34:53.229+0900 I/efl-extension(24475): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 20:34:53.229+0900 I/efl-extension(24475): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 20:34:53.234+0900 I/efl-extension(24475): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44594838
05-26 20:34:53.234+0900 I/efl-extension(24475): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-26 20:34:53.234+0900 I/efl-extension(24475): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445acd78 is freed
05-26 20:34:53.234+0900 I/efl-extension(24475): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:34:53.234+0900 I/efl-extension(24475): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44549750, elm_scroller, func : 0x437ebef1
05-26 20:34:53.234+0900 I/efl-extension(24475): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:34:53.234+0900 I/efl-extension(24475): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 20:34:53.234+0900 I/efl-extension(24475): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44594838, elm_image, func : 0x437ebef1
05-26 20:34:53.234+0900 I/efl-extension(24475): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 20:34:53.234+0900 I/efl-extension(24475): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44549750 : elm_scroller] rotary callabck is deleted
05-26 20:34:53.259+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1588] swap changed from sync to async
05-26 20:34:53.259+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 20:34:53.259+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 20:34:53.324+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 20:34:53.329+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 20:34:53.329+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 20:34:53.329+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:53.329+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:53.329+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 20:34:53.334+0900 I/APP_CORE(24467): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 20:34:53.334+0900 I/CAPI_APPFW_APPLICATION(24467): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 20:34:53.334+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 20:34:53.334+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:53.334+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:53.334+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:53.334+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 20:34:53.349+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-26 20:34:53.349+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 20:34:53.349+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:53.349+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-26 20:34:53.349+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESUME State: PAUSED
05-26 20:34:53.349+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 20:34:53.349+0900 W/W_HOME  (  726): main.c: _appcore_resume_cb(681) > appcore resume
05-26 20:34:53.349+0900 W/W_HOME  (  726): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 20:34:53.349+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:53.349+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:53.349+0900 W/W_HOME  (  726): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
05-26 20:34:53.349+0900 W/W_HOME  (  726): main.c: home_resume(733) > clock/widget resumed
05-26 20:34:53.349+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:53.349+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 20:34:53.349+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 20:34:53.349+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 20:34:53.349+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4469) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-26 20:34:53.359+0900 I/efl-extension(24467): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x442711d0
05-26 20:34:53.359+0900 I/efl-extension(24467): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x442711d0, obj: 0x442711d0
05-26 20:34:53.359+0900 I/efl-extension(24467): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 20:34:53.364+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_resume(1012) > widget_resume
05-26 20:34:53.364+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppResume(721) > 
05-26 20:34:53.364+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:53.364+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:53.394+0900 I/MALI    (24467): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 20:34:53.394+0900 I/MALI    (24467): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=24467   close drm_fd=25 
05-26 20:34:53.394+0900 I/MALI    (24467): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 20:34:53.434+0900 I/MALI    (24475): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x432f6600] swap changed from sync to async
05-26 20:34:53.454+0900 I/MALI    (24475): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 20:34:53.454+0900 I/MALI    (24475): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=24475   close drm_fd=18 
05-26 20:34:53.454+0900 I/MALI    (24475): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 20:34:53.484+0900 I/UXT     (24467): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 20:34:53.524+0900 I/UXT     (24475): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 20:34:53.534+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:53.534+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:53.709+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:53.709+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:53.794+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:34:53.794+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45c96248, elm_box, time_stamp : 10604232
05-26 20:34:53.794+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_rotary_cb(568) > Pass rotary event to home.
05-26 20:34:53.824+0900 W/W_HOME  (  726): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0x45ce3638 -> 360 0 0x4662f968
05-26 20:34:53.829+0900 I/efl-extension(24475): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-26 20:34:53.844+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45c93cc8 : elm_scroller] rotary callabck is called.
05-26 20:34:53.844+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45c93cc8 : elm_scroller] block(2)
05-26 20:34:53.844+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45c93cc8 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-26 20:34:53.844+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45c93cc8 : elm_scroller] content size (w, h)(2520, 360)
05-26 20:34:53.844+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45c93cc8 : elm_scroller] viewport size (w, h)(360, 360)
05-26 20:34:53.844+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45c93cc8 : elm_scroller] CurrentPage(1) DetentCount(1)
05-26 20:34:53.844+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-26 20:34:53.844+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-26 20:34:53.844+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(360), py(0)
05-26 20:34:53.844+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45c93cc8 : elm_scroller] bring in 2 page
05-26 20:34:53.844+0900 W/W_HOME  (  726): event_manager.c: _home_scroll_cb(564) > scroll,start
05-26 20:34:53.879+0900 I/MALI    (  726): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-26 20:34:53.879+0900 W/W_HOME  (  726): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
05-26 20:34:53.879+0900 W/W_HOME  (  726): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
05-26 20:34:53.879+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-26 20:34:53.884+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:53.884+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:53.889+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 20:34:53.889+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 20:34:53.889+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-26 20:34:53.904+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:53.904+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:53.914+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:53.914+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:53.924+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:53.924+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:53.944+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:53.944+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:53.959+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:53.959+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:53.974+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:53.974+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x45c96248, elm_box, time_stamp : 10604470
05-26 20:34:53.994+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_rotary_cb(568) > Pass rotary event to home.
05-26 20:34:53.994+0900 E/W_HOME  (  726): home_navigation.c: _vi_init(941) > (scroller_info->vi_info.on == 1) -> _vi_init() return
05-26 20:34:53.994+0900 W/W_HOME  (  726): home_navigation.c: _is_rightedge(188) > (678 360) not right edge: 42 0 0x4662f968 -> 402 0 0x45222398
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0x45c93cc8 : elm_scroller] rotary callabck is called.
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0x45c93cc8 : elm_scroller] block(2)
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0x45c93cc8 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0x45c93cc8 : elm_scroller] content size (w, h)(2520, 360)
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0x45c93cc8 : elm_scroller] viewport size (w, h)(360, 360)
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0x45c93cc8 : elm_scroller] CurrentPage(1) DetentCount(1)
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(678), py(0)
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(678), py(0)
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0x45c93cc8 : elm_scroller] mx(2160), my(0), minx(0), miny(0), px(678), py(0)
05-26 20:34:53.994+0900 I/efl-extension(  726): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0x45c93cc8 : elm_scroller] bring in 3 page
05-26 20:34:53.999+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:53.999+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.014+0900 W/WATCH_CORE(  752): appcore-watch.c: __widget_pause(1001) > widget_pause
05-26 20:34:54.014+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppPause(713) > 
05-26 20:34:54.014+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:34:54.014+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:34:54.014+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:34:54.014+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:34:54.014+0900 E/watchface-viewer(  752): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
05-26 20:34:54.014+0900 I/AUL_AMD (  474): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 24475
05-26 20:34:54.014+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:54.014+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.024+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:54.024+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.039+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:54.039+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.059+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:54.059+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.074+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:54.074+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.089+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:54.089+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.104+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:54.104+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.124+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:54.124+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.139+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:54.139+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.154+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-26 20:34:54.154+0900 I/ELM_RPANEL(  726): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-26 20:34:54.174+0900 W/CRASH_MANAGER(24591): worker.c: worker_job(1199) > 1124467706831146426249
