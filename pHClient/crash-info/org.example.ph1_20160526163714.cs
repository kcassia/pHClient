S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 5217
Date: 2016-05-26 16:37:14+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4048f250, r3   = 0x00000000
r4   = 0x44285768, r5   = 0x00000000
r6   = 0x44286068, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x442849e8
r10  = 0x44283f68, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbeb6a638
lr   = 0x403d81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     15096 KB
Buffers:     36120 KB
Cached:     126804 KB
VmPeak:     111152 KB
VmSize:     100428 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21892 KB
VmRSS:       21892 KB
VmData:      43636 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       51832 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 5217 TID = 5217
5217 5223 5226 5364 

Maps Information
40000000 40007000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
4000e000 4000f000 rwxp /opt/usr/apps/org.example.ph1/bin/ph1
4000f000 4002c000 r-xp /lib/ld-2.13.so
40033000 40034000 r-xp /lib/ld-2.13.so
40034000 40035000 rwxp /lib/ld-2.13.so
40035000 40039000 r-xp /usr/lib/libsys-assert.so
40041000 40042000 rwxp /usr/lib/libsys-assert.so
40056000 40057000 r-xp /usr/share/locale/locale-archive
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
43748000 4375b000 rwxp [stack:5223]
4375c000 4375f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43766000 43767000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440a3000 440a5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44373000 44b72000 rwxp [stack:5364]
44bf1000 44bf4000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44bf4000 44bf8000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44bf8000 44bfc000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/scim.mo
45580000 45587000 r-xs /usr/lib/gconv/gconv-modules.cache
45608000 45617000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
456a3000 45ea2000 rwxp [stack:5226]
461c2000 461c7000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
461ce000 461cf000 rwxp /usr/lib/scim-1.0/1.4.0/Config/socket.so
461cf000 462ee000 r-xp /usr/share/locale/locale-archive
46433000 46436000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4643d000 4643e000 rwxp /usr/lib/libpulse-simple.so.0.0.4
4643e000 46476000 r-xp /usr/lib/libpulse.so.0.16.2
46476000 46477000 rwxp /usr/lib/libpulse.so.0.16.2
4654e000 46553000 r-xp /usr/lib/libjson.so.0.0.1
4655a000 4655b000 rwxp /usr/lib/libjson.so.0.0.1
4655b000 4655f000 r-xp /usr/lib/libogg.so.0.7.1
46566000 46567000 rwxp /usr/lib/libogg.so.0.7.1
46721000 46769000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46769000 4676a000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
4676a000 467ad000 r-xp /usr/lib/libsndfile.so.1.0.25
467b4000 467b6000 rwxp /usr/lib/libsndfile.so.1.0.25
467ba000 467dc000 r-xp /usr/lib/libvorbis.so.0.4.3
467e3000 467e4000 rwxp /usr/lib/libvorbis.so.0.4.3
beb4a000 beb6b000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5217)
Call Stack Count: 2
 0: cfree + 0xc8 (0x403d81e8) [/lib/libc.so.6] + 0x6f1e8
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
eturn
05-26 16:35:58.530+0900 I/SOCKETTEST( 5217): Success to create socket
05-26 16:35:58.565+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.570+0900 I/efl-extension( 2247): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.570+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.570+0900 I/SOCKETTEST( 5217): Success to socket connection
05-26 16:35:58.570+0900 I/SOCKETTEST( 5217): write() 성공
05-26 16:35:58.570+0900 I/ROTARTY ( 5217): 뒤로
05-26 16:35:58.570+0900 I/SENSOR  ( 5217): 1.190000, -141.680008, -42.910000
05-26 16:35:58.570+0900 I/efl-extension( 5217): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.570+0900 I/efl-extension( 5217): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c11e40, elm_layout, time_stamp : 1059208
05-26 16:35:58.570+0900 D/TIMER   ( 5217): Rotary callback is called
05-26 16:35:58.570+0900 E/TIMER   ( 5217): (!ad->selected) -> _rotary_cb() return
05-26 16:35:58.570+0900 I/efl-extension( 1965): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.625+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.625+0900 I/efl-extension( 1965): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.625+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.625+0900 I/efl-extension( 5217): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.625+0900 I/efl-extension( 5217): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c11e40, elm_layout, time_stamp : 1059263
05-26 16:35:58.625+0900 D/TIMER   ( 5217): Rotary callback is called
05-26 16:35:58.625+0900 E/TIMER   ( 5217): (!ad->selected) -> _rotary_cb() return
05-26 16:35:58.625+0900 I/SOCKETTEST( 5217): Success to create socket
05-26 16:35:58.625+0900 I/efl-extension( 2247): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.630+0900 I/SOCKETTEST( 5217): Success to socket connection
05-26 16:35:58.630+0900 I/SOCKETTEST( 5217): write() 성공
05-26 16:35:58.630+0900 I/ROTARTY ( 5217): 뒤로
05-26 16:35:58.640+0900 I/SENSOR  ( 5217): 18.200001, -53.060001, -49.630001
05-26 16:35:58.675+0900 I/efl-extension( 2247): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.675+0900 I/efl-extension( 1965): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.675+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.675+0900 I/efl-extension( 5217): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.675+0900 I/efl-extension( 5217): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c11e40, elm_layout, time_stamp : 1059313
05-26 16:35:58.675+0900 D/TIMER   ( 5217): Rotary callback is called
05-26 16:35:58.675+0900 E/TIMER   ( 5217): (!ad->selected) -> _rotary_cb() return
05-26 16:35:58.675+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.745+0900 I/SENSOR  ( 5217): 33.670002, 3.290000, 9.380000
05-26 16:35:58.785+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.785+0900 I/efl-extension( 2247): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.785+0900 I/efl-extension( 1965): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.785+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.785+0900 I/efl-extension( 5217): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.785+0900 I/efl-extension( 5217): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c11e40, elm_layout, time_stamp : 1059424
05-26 16:35:58.785+0900 D/TIMER   ( 5217): Rotary callback is called
05-26 16:35:58.785+0900 E/TIMER   ( 5217): (!ad->selected) -> _rotary_cb() return
05-26 16:35:58.785+0900 I/SOCKETTEST( 5217): Success to create socket
05-26 16:35:58.790+0900 I/SOCKETTEST( 5217): Success to socket connection
05-26 16:35:58.790+0900 I/SOCKETTEST( 5217): write() 성공
05-26 16:35:58.790+0900 I/ROTARTY ( 5217): 뒤로
05-26 16:35:58.840+0900 I/SENSOR  ( 5217): 2.660000, 19.040001, 59.500000
05-26 16:35:58.865+0900 D/TIMER   ( 5217): Timer is start
05-26 16:35:58.865+0900 D/TIMER   ( 5217): Remind time: 0
05-26 16:35:58.900+0900 I/efl-extension(  726): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.900+0900 I/efl-extension( 2247): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.900+0900 I/efl-extension( 1965): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.900+0900 I/efl-extension( 4389): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.900+0900 I/efl-extension( 5217): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-26 16:35:58.900+0900 I/efl-extension( 5217): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c11e40, elm_layout, time_stamp : 1059537
05-26 16:35:58.900+0900 D/TIMER   ( 5217): Rotary callback is called
05-26 16:35:58.900+0900 E/TIMER   ( 5217): (!ad->selected) -> _rotary_cb() return
05-26 16:35:58.945+0900 I/SENSOR  ( 5217): -25.270000, -15.470000, 26.670000
05-26 16:35:59.045+0900 I/SENSOR  ( 5217): -70.349998, 139.860001, 67.550003
05-26 16:35:59.145+0900 I/SENSOR  ( 5217): 13.020000, 99.889999, 31.570000
05-26 16:35:59.250+0900 I/SENSOR  ( 5217): -8.890000, -5.670000, -2.310000
05-26 16:35:59.350+0900 I/SENSOR  ( 5217): 46.200001, 8.680000, 6.300000
05-26 16:35:59.450+0900 I/SENSOR  ( 5217): 22.049999, -56.700001, -26.530001
05-26 16:35:59.545+0900 I/SENSOR  ( 5217): 9.240000, -4.130000, 3.010000
05-26 16:35:59.590+0900 E/EFL     ( 5217): evas_main<5217> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1060228 button=1 downs=1
05-26 16:35:59.635+0900 E/EFL     ( 5217): evas_main<5217> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1060274 button=1 downs=0
05-26 16:35:59.635+0900 D/TIMER   ( 5217): Start clicked
05-26 16:35:59.650+0900 I/SOCKETTEST( 5217): Success to create socket
05-26 16:35:59.665+0900 I/SOCKETTEST( 5217): Success to socket connection
05-26 16:35:59.665+0900 I/SOCKETTEST( 5217): write() 성공
05-26 16:36:00.535+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 16:36:00.535+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 16:36:00.535+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : pedometer_inactive_period error
05-26 16:36:00.535+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 16:36:00.535+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 16:36:00.535+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_10min_precaution_millisec error
05-26 16:36:00.535+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 16:36:00.535+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 16:36:00.535+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_before_10min_precaution_millisec error
05-26 16:36:01.450+0900 W/SCSD    ( 4412): <_data_cb:507>  - length: 570
05-26 16:36:01.450+0900 W/SCSD    ( 4412): <sap_socket_send:137> sent [570 / 570] bytes
05-26 16:36:01.485+0900 W/SCSD    ( 4412): <_data_cb:507>  - length: 2089
05-26 16:36:01.485+0900 W/SCSD    ( 4412): <sap_socket_send:137> sent [2089 / 2089] bytes
05-26 16:36:01.525+0900 E/wnoti-service(  858): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(559)
05-26 16:36:01.525+0900 E/wnoti-service(  858): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
05-26 16:36:01.525+0900 E/wnoti-service(  858): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-26 16:36:01.535+0900 E/wnoti-service(  858): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 16:36:01.535+0900 E/wnoti-service(  858): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/150
05-26 16:36:01.535+0900 E/wnoti-service(  858): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
05-26 16:36:01.565+0900 E/wnoti-service(  858): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 142
05-26 16:36:01.565+0900 E/wnoti-service(  858): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 16:36:01.565+0900 E/wnoti-service(  858): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/150
05-26 16:36:01.565+0900 E/wnoti-service(  858): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_100.png
05-26 16:36:01.595+0900 E/wnoti-service(  858): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 1002/0
05-26 16:36:01.595+0900 E/wnoti-service(  858): wnoti-sap-client.c: _add_exception_handling(581) > type : 1002, application_id : 218
05-26 16:36:01.605+0900 E/wnoti-service(  858): wnoti-sap-client.c: publish_received_noti(1848) > 1002, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229456, noti_flag : 528, g_span_version : 1
05-26 16:36:01.605+0900 E/wnoti-service(  858): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-26 16:36:01.605+0900 E/wnoti-service(  858): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 1
05-26 16:36:01.605+0900 E/wnoti-service(  858): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 1
05-26 16:36:01.605+0900 E/wnoti-service(  858): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(2078)
05-26 16:36:01.605+0900 E/wnoti-service(  858): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
05-26 16:36:01.605+0900 E/wnoti-service(  858): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 1
05-26 16:36:01.605+0900 E/wnoti-service(  858): wnoti-db-server.c: insert_panel_asset(3442) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 16:36:01.605+0900 E/wnoti-service(  858): wnoti-json-parser.c: wnoti_parse_android_wear_noti_extender(793) > noti_info->label : 1,3,4,7,9
05-26 16:36:01.610+0900 E/wnoti-service(  858): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/146
05-26 16:36:01.610+0900 E/wnoti-service(  858): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 2
05-26 16:36:01.610+0900 E/wnoti-service(  858): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 1591
05-26 16:36:01.610+0900 E/wnoti-service(  858): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/144
05-26 16:36:01.610+0900 E/wnoti-service(  858): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/146
05-26 16:36:01.610+0900 E/wnoti-service(  858): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_98.png
05-26 16:36:01.610+0900 E/wnoti-service(  858): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/145
05-26 16:36:01.640+0900 E/wnoti-service(  858): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 5/229455
05-26 16:36:01.640+0900 E/wnoti-service(  858): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 218
05-26 16:36:01.650+0900 E/wnoti-service(  858): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
05-26 16:36:01.650+0900 E/wnoti-service(  858): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 0, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229457, noti_flag : 16, g_span_version : 1
05-26 16:36:01.650+0900 E/wnoti-service(  858): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 1
05-26 16:36:01.680+0900 E/wnoti-service(  858): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 1
05-26 16:36:03.065+0900 W/SCSD    ( 4412): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x05)
05-26 16:36:03.065+0900 W/SCSD    ( 4412): <on_sap_socket_recv:30>  - remain length: 5, crc_size: 4
05-26 16:36:03.065+0900 W/SCSD    ( 4412): <on_sap_socket_recv:62>  - recv 9 bytes [9 / 9] 
05-26 16:36:03.070+0900 W/SCSD    ( 4412): <util_scs_send:975> sent [11 / 11] bytes. 
05-26 16:36:03.110+0900 E/wnoti-service(  858): wnoti-sap-client.c: _get_latest_notification_card(1700) > id : 726, status : 0
05-26 16:36:03.135+0900 I/wnoti-service(  858): wnoti-sap-client.c: launch_alert_view(398) > timer_id : 0, emergency_cb_mode : 0, blocking_mode : 0 
05-26 16:36:03.135+0900 E/wnoti-service(  858): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 1
05-26 16:36:03.135+0900 I/wnoti-service(  858): wnoti-msg-builder.c: _publish_notification(1394) > operation_type : 0, source : 0, application_id : 0, display_count : 0
05-26 16:36:03.155+0900 E/wnoti-proxy(  726): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 726, caller_id : 0, listener_type : 0
05-26 16:36:03.155+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1501) > Change type : 0, op_type: 0, category_id: 0, display count: 0
05-26 16:36:03.155+0900 I/wnotib  (  726): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1556) > Handle this change type in idler.
05-26 16:36:03.155+0900 I/wnotib  (  726): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1561) > Home is background. Postpone the board update.
05-26 16:36:03.160+0900 E/wnoti-proxy( 4389): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 4389, caller_id : 0, listener_type : 0
05-26 16:36:03.160+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1502) > Handle this change type in idler.
05-26 16:36:03.160+0900 E/wnotibp ( 4389): w-notification-board-noti-manager-common.c: wnotib_noti_manager_get_noti_by_db_id(317) > No noti matched. db_id [726]
05-26 16:36:03.160+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1681) > This notification's category is expired!!!
05-26 16:36:03.160+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1684) > ::APP:: This notification is removed by wnotification service :(725),(1)
05-26 16:36:03.160+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1687) > ::APP:: delete_reserved_category_id=30, win_id=(null)
05-26 16:36:03.160+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (5, 1, 3)
05-26 16:36:03.160+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=443f2c48, view_state=3
05-26 16:36:03.160+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1953) > ::APP:: this notification is removed by service, wating ack from host. or more option excution timeout.
05-26 16:36:03.160+0900 E/wnoti-service(  858): wnoti-sap-client.c: on_timer(291) > is_exist_alert_list : 0, g_launch_popup_time : 1464248163, g_use_aul_launch : 0
05-26 16:36:03.160+0900 E/wnoti-service(  858): wnoti-sap-client.c: on_timer(293) > >> launching notification popup
05-26 16:36:03.165+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 0
05-26 16:36:03.200+0900 I/AUL_AMD (  474): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-26 16:36:03.225+0900 I/AUL_AMD (  474): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-26 16:36:03.225+0900 E/AUL_AMD (  474): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-26 16:36:03.225+0900 W/AUL_AMD (  474): amd_launch.c: _start_app(1702) > caller pid : 858
05-26 16:36:03.255+0900 W/AUL_AMD (  474): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 4389
05-26 16:36:03.255+0900 I/APP_CORE( 4389): appcore-efl.c: __do_app(429) > [APP 4389] Event: RESET State: PAUSED
05-26 16:36:03.255+0900 I/CAPI_APPFW_APPLICATION( 4389): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-26 16:36:03.270+0900 W/AUL_AMD (  474): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(4389), cmd(0)
05-26 16:36:03.290+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-26 16:36:03.295+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 16:36:03.310+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 16:36:03.310+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: wnotiboard_popup_get_block_mode(2354) > Returning false.
05-26 16:36:03.320+0900 E/wnoti-service(  858): wnoti-db-client.c: wnoti_get_alert_categories(712) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 218, db_id : 726, is_duplicated : 0
05-26 16:36:03.320+0900 E/wnoti-service(  858): wnoti-db-client.c: wnoti_get_alert_categories(851) > view_type : 1, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 0
05-26 16:36:03.345+0900 I/wnoti-proxy( 4389): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-26 16:36:03.345+0900 I/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_get_alert_list(813) > application_name: 카카오톡, application_id: 218, category_id: 30, time: 1464248161, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_218.jpg, icon_color: -5730296
05-26 16:36:03.345+0900 I/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_get_alert_list(820) > noti_type: 1
05-26 16:36:03.345+0900 W/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_convert_alert_data(77) > db_id = 726, alert_type: 1, app_feedback_type: 0
05-26 16:36:03.345+0900 I/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_convert_alert_data(372) > Activity fetch finished: -1
05-26 16:36:03.345+0900 I/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_convert_alert_data(377) > activity action count: 1
05-26 16:36:03.345+0900 I/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_convert_alert_data(382) > 1 activities retrieved.
05-26 16:36:03.350+0900 I/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_convert_alert_data(473) > Page fetch finished: -1
05-26 16:36:03.350+0900 I/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_convert_alert_data(478) > wearable_page_cnt: 1
05-26 16:36:03.350+0900 I/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_convert_alert_data(483) > 1 pages retrieved.
05-26 16:36:03.350+0900 W/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 1, list count : 2
05-26 16:36:03.350+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_app_control(1131) > ::DATA:: CHECK IN APP CONTROL : 2, 1, 1
05-26 16:36:03.350+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_app_control(1143) > ::APP:: CHECK STATE : 5, 1, 0|com.kakao.talk|-1281469112|null|10222
05-26 16:36:03.350+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_app_control(1152) > cancel destory popup
05-26 16:36:03.350+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 16:36:03.350+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 16:36:03.350+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(628) > [726, 2, 2, 9, 0000]
05-26 16:36:03.350+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(629) > [0, 1, 0, 0]
05-26 16:36:03.350+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(630) > [1, 0, 3, 443f2c48]
05-26 16:36:03.350+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-26 16:36:03.350+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4443) > wnotiboard_popup_vi_type: 2
05-26 16:36:03.350+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4449) > (726, 726)
05-26 16:36:03.365+0900 I/efl-extension( 4389): efl_extension_circle_surface.c: eext_circle_surface_layout_add(1293) > Put the surface[0x443d5ab8]'s widget[0x44351900] to layout widget[0x44350d00]
05-26 16:36:03.365+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_create_genlist(4377) > (726, 726)
05-26 16:36:03.375+0900 I/efl-extension( 4389): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-26 16:36:03.390+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_create_card_data(3979) > 0x4510e398, 0x4510e218, 0x4510e218
05-26 16:36:03.390+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 16:36:03.390+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 16:36:03.390+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 16:36:03.390+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 16:36:03.395+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: wnotiboard_popup_draw_small_view(3659) > ::UI:: window type is changed by unknown causes
05-26 16:36:03.395+0900 I/APP_CORE( 4389): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-26 16:36:03.395+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05e00008)
05-26 16:36:03.410+0900 W/wnotibp ( 4389): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2201) > Unhandled part: stack.separator
05-26 16:36:03.410+0900 I/wnotibp ( 4389): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 16:36:03.415+0900 I/wnotibp ( 4389): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 16:36:03.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 16:36:03.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 16:36:03.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 16:36:03.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 16:36:03.435+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x05e00008)
05-26 16:36:03.450+0900 W/APP_CORE( 4389): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00008
05-26 16:36:03.470+0900 E/EFL     ( 4389): evas_main<4389> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 16:36:03.470+0900 E/EFL     ( 4389): evas_main<4389> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 16:36:03.470+0900 E/EFL     ( 4389): evas_main<4389> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-26 16:36:03.470+0900 I/wnotibp ( 4389): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 16:36:03.470+0900 I/wnotibp ( 4389): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-26 16:36:03.470+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-26 16:36:03.470+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-26 16:36:03.470+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-26 16:36:03.470+0900 E/TIZEN_N_SYSTEM_SETTINGS( 4389): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-26 16:36:03.505+0900 E/EFL     ( 4389): evas_main<4389> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x46995c30 is not stable during recalc loop
05-26 16:36:03.510+0900 E/EFL     ( 4389): evas_main<4389> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x46995c30 is not stable during recalc loop
05-26 16:36:03.530+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 16:36:03.530+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 16:36:03.550+0900 I/wnotibp ( 4389): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1037) > fully_obscured: 0 [0x5e00008 0x5e0000a 0x5e00008 ]
05-26 16:36:03.550+0900 I/APP_CORE( 4389): appcore-efl.c: __do_app(429) > [APP 4389] Event: RESUME State: RUNNING
05-26 16:36:03.555+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3713) > ::UI:: VI TYPE : 2
05-26 16:36:03.555+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3719) > alert_type : 1, is_source_companion: 1
05-26 16:36:03.555+0900 W/TIZEN_N_RECORDER( 4389): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
05-26 16:36:03.555+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1272) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
05-26 16:36:03.555+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1281) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
05-26 16:36:03.555+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1315) > ::APP:: Determined feedback: sound 0, vibration: 0
05-26 16:36:03.555+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1319) > No feedback.
05-26 16:36:03.590+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_view_lock(856) > ::UI:: [[[ ===> already [small popup] is LOCK, 0010 ]]]
05-26 16:36:03.590+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_pre_cb(2194) > ::UI:: start showing animation
05-26 16:36:03.890+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_cb(2104) > ::UI:: end show animation
05-26 16:36:03.895+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-26 16:36:03.895+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 2 2
05-26 16:36:03.915+0900 E/wnoti-service(  858): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
05-26 16:36:03.920+0900 E/wnoti-service(  858): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 2
05-26 16:36:03.940+0900 E/wnoti-service(  858): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-26 16:36:03.955+0900 E/wnoti-proxy( 4389): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
05-26 16:36:03.955+0900 E/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_get_alert_list(916) > ::DATA:: No categories available.
05-26 16:36:03.955+0900 W/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 0, list count : 2
05-26 16:36:04.620+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:36:04.620+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:36:04.620+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:36:04.620+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:36:04.620+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:36:05.135+0900 E/wnoti-service(  858): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
05-26 16:36:06.395+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-26 16:36:06.395+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_main_popup_timer_cb(2324) > ::UI:: start hiding animation
05-26 16:36:06.520+0900 E/EFL     ( 4389): elementary<4389> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(45eb32f0), block(2)
05-26 16:36:06.520+0900 E/EFL     ( 4389): elementary<4389> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(45eb32f0), ev->cur.canvas.x(185) ev->cur.canvas.y(137)
05-26 16:36:06.520+0900 E/EFL     ( 4389): elementary<4389> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(45eb32f0), hold(0) freeze(0)
05-26 16:36:06.730+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_hide_animator_cb(2255) > ::UI:: end hiding animation
05-26 16:36:06.730+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-26 16:36:06.730+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 2 2
05-26 16:36:06.730+0900 W/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (8, 1, 3)
05-26 16:36:06.730+0900 I/wnotibp ( 4389): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=443f2c48, view_state=3
05-26 16:36:06.730+0900 I/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_view_unlock(903) > ::UI:: it is invalid object.
05-26 16:36:06.730+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [invalid object] is UNLOCK , 0000 <=== ]]]
05-26 16:36:06.730+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 2 2
05-26 16:36:06.730+0900 I/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 726
05-26 16:36:06.730+0900 I/wnotibp ( 4389): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 1, 1
05-26 16:36:06.730+0900 I/efl-extension( 4389): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45eb32f0, obj: 0x45eb32f0
05-26 16:36:06.730+0900 I/efl-extension( 4389): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 16:36:06.750+0900 I/efl-extension( 4389): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 16:36:06.750+0900 I/efl-extension( 4389): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45eb32f0, elm_genlist, func : 0x41a25dfd
05-26 16:36:06.750+0900 I/efl-extension( 4389): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 16:36:06.800+0900 I/wnotibp ( 4389): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1037) > fully_obscured: 1 [0x5e00008 0x5e0000a 0x5e00008 ]
05-26 16:36:06.800+0900 I/APP_CORE( 4389): appcore-efl.c: __do_app(429) > [APP 4389] Event: PAUSE State: RUNNING
05-26 16:36:06.800+0900 I/CAPI_APPFW_APPLICATION( 4389): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 16:36:06.870+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-26 16:36:06.870+0900 W/wnotibp ( 4389): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-26 16:36:06.870+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [1, 1, 9, 0000]
05-26 16:36:06.870+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 0]
05-26 16:36:06.870+0900 W/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1371) > [0, 1, 3, 2, 443f2c48]
05-26 16:36:07.140+0900 E/wnoti-service(  858): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
05-26 16:36:10.540+0900 E/WMS     (  469): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-26 16:36:10.545+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-26 16:36:10.545+0900 E/WMS     (  469): ==========
05-26 16:36:10.545+0900 E/WMS     (  469): ##WMS SEND : mgr_gear_wear_onoff_req
05-26 16:36:10.545+0900 E/WMS     (  469): ==========
05-26 16:36:10.545+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-26 16:36:10.635+0900 W/SCSD    ( 4412): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-26 16:36:10.635+0900 W/SCSD    ( 4412): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-26 16:36:10.635+0900 W/SCSD    ( 4412): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-26 16:36:10.640+0900 W/SCSD    ( 4412): <util_scs_send:975> sent [63 / 63] bytes. 
05-26 16:36:10.655+0900 W/SHealth_Service( 1056): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-26 16:36:10.655+0900 E/SHealth_Service( 1056): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-26 16:36:11.885+0900 I/APP_CORE( 4389): appcore-efl.c: __do_app(429) > [APP 4389] Event: MEM_FLUSH State: PAUSED
05-26 16:36:16.540+0900 E/WMS     (  469): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-26 16:36:16.555+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-26 16:36:16.555+0900 E/WMS     (  469): ==========
05-26 16:36:16.555+0900 E/WMS     (  469): ##WMS SEND : mgr_gear_wear_onoff_req
05-26 16:36:16.555+0900 E/WMS     (  469): ==========
05-26 16:36:16.555+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-26 16:36:16.650+0900 W/SCSD    ( 4412): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-26 16:36:16.650+0900 W/SCSD    ( 4412): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-26 16:36:16.650+0900 W/SCSD    ( 4412): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-26 16:36:16.655+0900 W/SCSD    ( 4412): <util_scs_send:975> sent [63 / 63] bytes. 
05-26 16:36:16.665+0900 W/SHealth_Service( 1056): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
05-26 16:36:16.665+0900 E/SHealth_Service( 1056): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-26 16:36:18.695+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:36:18.695+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:36:18.700+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:36:18.700+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:36:18.700+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:36:21.265+0900 E/WMS     (  469): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-26 16:36:21.275+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-26 16:36:21.275+0900 E/WMS     (  469): ==========
05-26 16:36:21.275+0900 E/WMS     (  469): ##WMS SEND : mgr_gear_wear_onoff_req
05-26 16:36:21.275+0900 E/WMS     (  469): ==========
05-26 16:36:21.275+0900 E/WMS     (  469): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-26 16:36:21.370+0900 W/SCSD    ( 4412): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-26 16:36:21.370+0900 W/SCSD    ( 4412): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-26 16:36:21.370+0900 W/SCSD    ( 4412): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-26 16:36:21.380+0900 W/SCSD    ( 4412): <util_scs_send:975> sent [63 / 63] bytes. 
05-26 16:36:21.385+0900 W/SHealth_Service( 1056): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
05-26 16:36:21.385+0900 E/SHealth_Service( 1056): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
05-26 16:36:40.325+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-26 16:36:40.325+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-26 16:36:40.325+0900 I/RESOURCED(  475): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-26 16:36:45.800+0900 E/SHealth_Common( 1056): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-26 16:36:53.585+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 93 -> 92 1464248213 240
05-26 16:36:53.585+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 92 1342 263 2058
05-26 16:36:53.585+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 92 0 0 1861
05-26 16:36:53.585+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 92 1368 204 2098
05-26 16:36:53.585+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 92 1772 5 2717
05-26 16:36:53.585+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 92 1341 7 2056
05-26 16:37:00.590+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 16:37:00.590+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 16:37:00.590+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : pedometer_inactive_period error
05-26 16:37:00.595+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 16:37:00.595+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 16:37:00.595+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_10min_precaution_millisec error
05-26 16:37:00.595+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 16:37:00.595+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 16:37:00.595+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_before_10min_precaution_millisec error
05-26 16:37:14.070+0900 E/PKGMGR_SERVER( 5551): pkgmgr-server.c: main(2131) > package manager server start
05-26 16:37:14.165+0900 E/PKGMGR_SERVER( 5551): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_-606591730], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[tkluQMJnXtk6TdhdcDZPh7XAXrc=], backend_flag=[0]
05-26 16:37:14.170+0900 E/PKGMGR_SERVER( 5552): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-26 16:37:14.175+0900 E/PKGMGR  ( 5549): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-26 16:37:14.240+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 16:37:14.250+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5217
05-26 16:37:14.250+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 12
05-26 16:37:14.255+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 5
05-26 16:37:14.260+0900 I/APP_CORE( 5217): appcore-efl.c: __do_app(429) > [APP 5217] Event: TERMINATE State: RUNNING
05-26 16:37:14.260+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 16:37:14.260+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 16:37:14.260+0900 W/AUL_AMD (  474): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(5217), cmd(4)
05-26 16:37:14.260+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 16:37:14.270+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5217
05-26 16:37:14.330+0900 I/APP_CORE( 5217): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 16:37:14.330+0900 I/CAPI_APPFW_APPLICATION( 5217): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 16:37:14.350+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 16:37:14.350+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 16:37:14.370+0900 I/efl-extension( 5217): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c11e40
05-26 16:37:14.370+0900 I/efl-extension( 5217): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c11e40, obj: 0x44c11e40
05-26 16:37:14.370+0900 I/efl-extension( 5217): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 16:37:14.370+0900 I/efl-extension( 5217): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 16:37:14.370+0900 I/efl-extension( 5217): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 16:37:14.370+0900 I/efl-extension( 5217): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 16:37:14.375+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 16:37:14.375+0900 I/MALI    ( 5217): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f4f010] swap changed from sync to async
05-26 16:37:14.380+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5217
05-26 16:37:14.400+0900 I/MALI    ( 5217): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 16:37:14.400+0900 I/MALI    ( 5217): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=5217   close drm_fd=25 
05-26 16:37:14.400+0900 I/MALI    ( 5217): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 16:37:14.450+0900 I/wnotibp ( 4389): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1037) > fully_obscured: 0 [0x5e0000a 0x5e0000a 0x5e00008 ]
05-26 16:37:14.450+0900 I/APP_CORE( 4389): appcore-efl.c: __do_app(429) > [APP 4389] Event: RESUME State: PAUSED
05-26 16:37:14.450+0900 I/CAPI_APPFW_APPLICATION( 4389): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 16:37:14.450+0900 I/wnotibp ( 4389): wnotiboard-popup.c: _wnotiboard_popup_app_resume(1380) > 
05-26 16:37:14.460+0900 I/UXT     ( 5217): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 16:37:14.485+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 16:37:14.490+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5217
05-26 16:37:14.600+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 16:37:14.610+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5217
05-26 16:37:14.710+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 16:37:14.735+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5217
05-26 16:37:14.835+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 16:37:14.850+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5217
05-26 16:37:14.950+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 14
05-26 16:37:14.960+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-26 16:37:14.970+0900 E/PKGMGR_SERVER( 5552): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-26 16:37:14.995+0900 E/PKGMGR_SERVER( 5551): pkgmgr-server.c: sighandler(409) > child NORMAL exit [5552]
05-26 16:37:15.085+0900 W/CRASH_MANAGER( 5557): worker.c: worker_job(1199) > 1105217706831146424823
