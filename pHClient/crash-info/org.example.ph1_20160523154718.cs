S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 21357
Date: 2016-05-23 15:47:18+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4048f250, r3   = 0x00000000
r4   = 0x44300780, r5   = 0x00000000
r6   = 0x44301080, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x442ffa00
r10  = 0x44040fb0, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbe83e638
lr   = 0x403d81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     16556 KB
Buffers:     15924 KB
Cached:     108456 KB
VmPeak:     109196 KB
VmSize:      99132 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21052 KB
VmRSS:       21052 KB
VmData:      43560 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50644 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 21357 TID = 21357
21357 21362 21365 21476 

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
43748000 4375c000 rwxp [stack:21362]
4375c000 4375f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43766000 43767000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440a3000 440a5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44bf1000 44bf4000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44bf4000 44bf8000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44d01000 45500000 rwxp [stack:21476]
45608000 45617000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
456a3000 45ea2000 rwxp [stack:21365]
46412000 46415000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4641c000 4641d000 rwxp /usr/lib/libpulse-simple.so.0.0.4
4641d000 46455000 r-xp /usr/lib/libpulse.so.0.16.2
46455000 46456000 rwxp /usr/lib/libpulse.so.0.16.2
465a3000 465a8000 r-xp /usr/lib/libjson.so.0.0.1
465af000 465b0000 rwxp /usr/lib/libjson.so.0.0.1
465b0000 465f8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
465f8000 465f9000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
465f9000 4663c000 r-xp /usr/lib/libsndfile.so.1.0.25
46643000 46645000 rwxp /usr/lib/libsndfile.so.1.0.25
46649000 4666b000 r-xp /usr/lib/libvorbis.so.0.4.3
46672000 46673000 rwxp /usr/lib/libvorbis.so.0.4.3
46673000 46677000 r-xp /usr/lib/libogg.so.0.7.1
4667e000 4667f000 rwxp /usr/lib/libogg.so.0.7.1
be81e000 be83f000 rwxp [stack]
End of Maps Information

Callstack Information (PID:21357)
Call Stack Count: 2
 0: cfree + 0xc8 (0x403d81e8) [/lib/libc.so.6] + 0x6f1e8
 1: ((nil)) (null)
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
/SOCKETTEST(21357): Success to create socket
05-23 15:47:10.849+0900 I/efl-extension(20557): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.854+0900 I/efl-extension(20581): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.864+0900 I/SOCKETTEST(21357): Success to socket connection
05-23 15:47:10.864+0900 I/SOCKETTEST(21357): write() 성공
05-23 15:47:10.864+0900 I/ROTARTY (21357): 앞으로
05-23 15:47:10.884+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.884+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.884+0900 I/efl-extension(21357): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.884+0900 I/efl-extension(21357): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44273a00, elm_layout, time_stamp : 12524900
05-23 15:47:10.884+0900 D/TIMER   (21357): Rotary callback is called
05-23 15:47:10.884+0900 E/TIMER   (21357): (!ad->selected) -> _rotary_cb() return
05-23 15:47:10.884+0900 I/efl-extension(20581): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.884+0900 I/efl-extension(20557): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.904+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.904+0900 I/efl-extension(21357): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.904+0900 I/efl-extension(21357): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44273a00, elm_layout, time_stamp : 12524918
05-23 15:47:10.904+0900 D/TIMER   (21357): Rotary callback is called
05-23 15:47:10.904+0900 E/TIMER   (21357): (!ad->selected) -> _rotary_cb() return
05-23 15:47:10.904+0900 I/SOCKETTEST(21357): Success to create socket
05-23 15:47:10.904+0900 I/efl-extension(20557): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.904+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.904+0900 I/efl-extension(20581): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.909+0900 I/SOCKETTEST(21357): Success to socket connection
05-23 15:47:10.909+0900 I/SOCKETTEST(21357): write() 성공
05-23 15:47:10.909+0900 I/ROTARTY (21357): 앞으로
05-23 15:47:10.909+0900 I/SENSOR  (21357): 17.850000, -35.279999, -46.200001
05-23 15:47:10.949+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.949+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.949+0900 I/efl-extension(21357): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.949+0900 I/efl-extension(21357): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44273a00, elm_layout, time_stamp : 12524964
05-23 15:47:10.949+0900 D/TIMER   (21357): Rotary callback is called
05-23 15:47:10.949+0900 E/TIMER   (21357): (!ad->selected) -> _rotary_cb() return
05-23 15:47:10.949+0900 I/efl-extension(20557): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:10.949+0900 I/efl-extension(20581): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.004+0900 I/SENSOR  (21357): 4.760000, -29.960001, -18.549999
05-23 15:47:11.084+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.084+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.084+0900 I/efl-extension(21357): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.084+0900 I/efl-extension(21357): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44273a00, elm_layout, time_stamp : 12525099
05-23 15:47:11.084+0900 D/TIMER   (21357): Rotary callback is called
05-23 15:47:11.084+0900 E/TIMER   (21357): (!ad->selected) -> _rotary_cb() return
05-23 15:47:11.084+0900 I/SOCKETTEST(21357): Success to create socket
05-23 15:47:11.084+0900 I/efl-extension(20557): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.084+0900 I/efl-extension(20581): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.099+0900 I/SOCKETTEST(21357): Success to socket connection
05-23 15:47:11.099+0900 I/SOCKETTEST(21357): write() 성공
05-23 15:47:11.099+0900 I/ROTARTY (21357): 앞으로
05-23 15:47:11.104+0900 I/SENSOR  (21357): 11.690000, 2.100000, 7.280000
05-23 15:47:11.204+0900 I/SENSOR  (21357): 41.860001, 19.250000, -16.100000
05-23 15:47:11.309+0900 I/SENSOR  (21357): -2.660000, -6.160000, 22.330000
05-23 15:47:11.404+0900 I/SENSOR  (21357): 1.400000, 13.510000, 23.309999
05-23 15:47:11.509+0900 I/SENSOR  (21357): -5.670000, -15.470000, 3.500000
05-23 15:47:11.604+0900 I/SENSOR  (21357): 3.430000, -29.400000, -28.070000
05-23 15:47:11.609+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.609+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.609+0900 I/efl-extension(21357): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.609+0900 I/efl-extension(21357): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44273a00, elm_layout, time_stamp : 12525623
05-23 15:47:11.609+0900 D/TIMER   (21357): Rotary callback is called
05-23 15:47:11.609+0900 E/TIMER   (21357): (!ad->selected) -> _rotary_cb() return
05-23 15:47:11.609+0900 I/efl-extension(20581): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.609+0900 I/efl-extension(20557): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.614+0900 D/TIMER   (21357): Timer is start
05-23 15:47:11.614+0900 D/TIMER   (21357): Remind time: 293
05-23 15:47:11.679+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.679+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.679+0900 I/efl-extension(20581): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.679+0900 I/efl-extension(20557): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.679+0900 I/efl-extension(21357): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.679+0900 I/efl-extension(21357): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44273a00, elm_layout, time_stamp : 12525695
05-23 15:47:11.679+0900 D/TIMER   (21357): Rotary callback is called
05-23 15:47:11.679+0900 E/TIMER   (21357): (!ad->selected) -> _rotary_cb() return
05-23 15:47:11.679+0900 I/SOCKETTEST(21357): Success to create socket
05-23 15:47:11.699+0900 I/SOCKETTEST(21357): Success to socket connection
05-23 15:47:11.699+0900 I/SOCKETTEST(21357): write() 성공
05-23 15:47:11.699+0900 I/ROTARTY (21357): 앞으로
05-23 15:47:11.704+0900 I/SENSOR  (21357): 16.940001, -25.830000, -58.520000
05-23 15:47:11.744+0900 I/efl-extension(  730): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.744+0900 I/efl-extension( 6609): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.749+0900 I/efl-extension(21357): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.749+0900 I/efl-extension(21357): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44273a00, elm_layout, time_stamp : 12525762
05-23 15:47:11.749+0900 D/TIMER   (21357): Rotary callback is called
05-23 15:47:11.749+0900 E/TIMER   (21357): (!ad->selected) -> _rotary_cb() return
05-23 15:47:11.749+0900 I/efl-extension(20581): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.749+0900 I/efl-extension(20557): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-23 15:47:11.804+0900 I/SENSOR  (21357): -14.980000, -7.770000, 3.080000
05-23 15:47:11.904+0900 I/SENSOR  (21357): 27.580000, 2.870000, -5.390000
05-23 15:47:12.004+0900 I/SENSOR  (21357): 13.930000, -9.730000, -8.470000
05-23 15:47:12.109+0900 I/SENSOR  (21357): -6.860000, 1.050000, -2.520000
05-23 15:47:12.209+0900 I/SENSOR  (21357): -4.480000, 2.450000, -2.520000
05-23 15:47:12.309+0900 I/SENSOR  (21357): 2.240000, 4.690000, -0.490000
05-23 15:47:12.409+0900 I/SENSOR  (21357): 4.480000, -2.100000, -7.980000
05-23 15:47:12.509+0900 I/SENSOR  (21357): 2.030000, -9.940000, -10.640000
05-23 15:47:12.609+0900 I/SENSOR  (21357): -13.720000, -18.129999, 6.230000
05-23 15:47:12.614+0900 D/TIMER   (21357): Timer is start
05-23 15:47:12.614+0900 D/TIMER   (21357): Remind time: 292
05-23 15:47:12.709+0900 I/SENSOR  (21357): -3.990000, -17.290001, 0.070000
05-23 15:47:12.809+0900 I/SENSOR  (21357): 10.990000, -8.260000, -8.050000
05-23 15:47:12.914+0900 I/SENSOR  (21357): 35.420002, -57.680000, -20.580000
05-23 15:47:13.009+0900 I/SENSOR  (21357): 8.960000, -34.439999, -6.510000
05-23 15:47:13.074+0900 E/EFL     (21357): evas_main<21357> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12527088 button=1 downs=1
05-23 15:47:13.084+0900 E/EFL     (21357): evas_main<21357> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12527101 button=1 downs=0
05-23 15:47:13.104+0900 I/SENSOR  (21357): 4.550000, -3.220000, 11.690000
05-23 15:47:13.214+0900 I/SENSOR  (21357): -9.590000, 9.730000, 6.510000
05-23 15:47:13.314+0900 I/SENSOR  (21357): -4.830000, 2.170000, 3.500000
05-23 15:47:13.409+0900 I/SENSOR  (21357): 4.270000, -9.380000, 1.050000
05-23 15:47:13.509+0900 I/SENSOR  (21357): 29.820000, -50.189999, -32.759998
05-23 15:47:13.559+0900 E/EFL     (21357): evas_main<21357> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12527574 button=1 downs=1
05-23 15:47:13.604+0900 I/SENSOR  (21357): 32.689999, 0.210000, 7.140000
05-23 15:47:13.614+0900 D/TIMER   (21357): Timer is start
05-23 15:47:13.614+0900 D/TIMER   (21357): Remind time: 291
05-23 15:47:13.614+0900 D/TIMER   (21357): Start clicked
05-23 15:47:13.639+0900 E/EFL     (21357): evas_main<21357> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12527643 button=1 downs=0
05-23 15:47:13.639+0900 D/TIMER   (21357): Start clicked
05-23 15:47:13.659+0900 I/SOCKETTEST(21357): Success to create socket
05-23 15:47:13.669+0900 I/SOCKETTEST(21357): Success to socket connection
05-23 15:47:13.669+0900 I/SOCKETTEST(21357): write() 성공
05-23 15:47:15.244+0900 I/efl-extension(21357): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44273a00
05-23 15:47:15.244+0900 I/efl-extension(21357): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44273a00, obj: 0x44273a00
05-23 15:47:15.244+0900 I/efl-extension(21357): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-23 15:47:15.244+0900 I/efl-extension(21357): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-23 15:47:15.244+0900 I/efl-extension(21357): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-23 15:47:15.244+0900 I/efl-extension(21357): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-23 15:47:15.489+0900 W/STARTER (  692): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-23 15:47:15.489+0900 W/STARTER (  692): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-23 15:47:15.489+0900 W/STARTER (  692): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-23 15:47:15.489+0900 W/STARTER (  692): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-23 15:47:15.544+0900 W/STARTER (  692): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-23 15:47:15.684+0900 W/STARTER (  692): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-23 15:47:15.684+0900 W/STARTER (  692): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-23 15:47:15.689+0900 W/STARTER (  692): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-23 15:47:15.689+0900 W/STARTER (  692): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-23 15:47:15.784+0900 W/STARTER (  692): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-23 15:47:16.039+0900 W/STARTER (  692): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-23 15:47:16.049+0900 W/STARTER (  692): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-23 15:47:16.074+0900 E/STARTER (  692): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-23 15:47:16.074+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 0
05-23 15:47:16.089+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(1702) > caller pid : 692
05-23 15:47:16.094+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(2080) > pad pid(-5)
05-23 15:47:16.094+0900 W/AUL_PAD ( 1199): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-23 15:47:16.099+0900 W/AUL_PAD ( 1199): launchpad.c: __send_result_to_caller(272) > Check app launching
05-23 15:47:16.109+0900 E/RESOURCED(  496): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-23 15:47:16.114+0900 I/CAPI_APPFW_APPLICATION(21356): app_main.c: app_efl_main(129) > app_efl_main
05-23 15:47:16.119+0900 I/CAPI_APPFW_APPLICATION(21356): app_main.c: app_appcore_create(152) > app_appcore_create
05-23 15:47:16.199+0900 E/AUL     (  692): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-23 15:47:16.199+0900 E/RESOURCED(  496): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-23 15:47:16.319+0900 I/efl-extension(21356): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x445b5b80 = w: 0 h: 0  obj 0x445bf318 w: 360 h: 360
05-23 15:47:16.319+0900 I/efl-extension(21356): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-23 15:47:16.324+0900 I/efl-extension(21356): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-23 15:47:16.324+0900 I/efl-extension(21356): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-23 15:47:16.324+0900 I/efl-extension(21356): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-23 15:47:16.329+0900 I/efl-extension(21356): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-23 15:47:16.329+0900 I/efl-extension(21356): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445bf318, elm_image, _activated_obj : 0x0, activated : 1
05-23 15:47:16.469+0900 E/W_TASKMANAGER(21356): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-23 15:47:16.469+0900 E/W_TASKMANAGER(21356): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-23 15:47:16.469+0900 E/W_TASKMANAGER(21356): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-23 15:47:16.519+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.524+0900 E/W_TASKMANAGER(21356): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-23 15:47:16.529+0900 E/RUA     (21356): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 33, ncols : 5
05-23 15:47:16.569+0900 E/EFL     (21356): elementary<21356> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x445c0f98 into part 'elm.swallow.event.0'
05-23 15:47:16.609+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x06a00003)
05-23 15:47:16.609+0900 I/APP_CORE(21356): appcore-efl.c: __do_app(429) > [APP 21356] Event: RESET State: CREATED
05-23 15:47:16.609+0900 I/CAPI_APPFW_APPLICATION(21356): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-23 15:47:16.629+0900 I/APP_CORE(21356): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-23 15:47:16.629+0900 I/APP_CORE(21356): appcore-efl.c: __do_app(474) > [APP 21356] Initial Launching, call the resume_cb
05-23 15:47:16.629+0900 I/CAPI_APPFW_APPLICATION(21356): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-23 15:47:16.674+0900 E/E17     (  380): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x06a00003)
05-23 15:47:16.684+0900 W/APP_CORE(21356): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6a00003
05-23 15:47:16.759+0900 I/APP_CORE(21357): appcore-efl.c: __do_app(429) > [APP 21357] Event: PAUSE State: RUNNING
05-23 15:47:16.759+0900 I/CAPI_APPFW_APPLICATION(21357): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-23 15:47:16.779+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-23 15:47:16.779+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-23 15:47:16.779+0900 I/APP_CORE(21356): appcore-efl.c: __do_app(429) > [APP 21356] Event: RESUME State: RUNNING
05-23 15:47:17.149+0900 E/AUL     (  493): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-23 15:47:17.184+0900 I/MALI    (21356): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-23 15:47:17.234+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-23 15:47:17.249+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 21356
05-23 15:47:17.249+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 12
05-23 15:47:17.504+0900 E/EFL     (21356): evas_main<21356> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12531514 button=1 downs=1
05-23 15:47:17.564+0900 E/EFL     (21356): evas_main<21356> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12531579 button=1 downs=0
05-23 15:47:17.789+0900 I/efl-extension(21524): efl_extension.c: eext_mod_init(40) > Init
05-23 15:47:17.824+0900 E/EFL     (21356): elementary<21356> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573e88), freeze(1)
05-23 15:47:17.824+0900 E/EFL     (21356): elementary<21356> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(44573e88), freeze(1)
05-23 15:47:17.829+0900 I/UXT     (21524): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-23 15:47:18.029+0900 I/AUL_PAD (21524): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-23 15:47:18.084+0900 E/TBM     (21524): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-23 15:47:18.219+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-23 15:47:18.229+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20581
05-23 15:47:18.229+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 27
05-23 15:47:18.239+0900 I/APP_CORE(20581): appcore-efl.c: __do_app(429) > [APP 20581] Event: TERMINATE State: PAUSED
05-23 15:47:18.244+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-23 15:47:18.244+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-23 15:47:18.249+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-23 15:47:18.259+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 21357
05-23 15:47:18.259+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 27
05-23 15:47:18.264+0900 I/APP_CORE(21357): appcore-efl.c: __do_app(429) > [APP 21357] Event: TERMINATE State: PAUSED
05-23 15:47:18.264+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-23 15:47:18.264+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-23 15:47:18.274+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-23 15:47:18.274+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-23 15:47:18.274+0900 E/APP_CORE(21356): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-23 15:47:18.274+0900 I/APP_CORE(21356): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-23 15:47:18.274+0900 I/APP_CORE(21356): appcore-efl.c: __after_loop(1090) > [APP 21356] PAUSE before termination
05-23 15:47:18.274+0900 I/CAPI_APPFW_APPLICATION(21356): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-23 15:47:18.274+0900 I/CAPI_APPFW_APPLICATION(21356): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-23 15:47:18.279+0900 I/efl-extension(21356): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44573e88, obj: 0x44573e88
05-23 15:47:18.279+0900 I/efl-extension(21356): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-23 15:47:18.279+0900 I/efl-extension(21356): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-23 15:47:18.279+0900 I/efl-extension(21356): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-23 15:47:18.279+0900 I/efl-extension(21356): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-23 15:47:18.284+0900 I/efl-extension(21356): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x445bf318
05-23 15:47:18.284+0900 I/efl-extension(21356): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-23 15:47:18.284+0900 I/efl-extension(21356): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445b5b80 is freed
05-23 15:47:18.284+0900 I/efl-extension(21356): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-23 15:47:18.284+0900 I/efl-extension(21356): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44573e88, elm_scroller, func : 0x437c8ef1
05-23 15:47:18.284+0900 I/efl-extension(21356): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-23 15:47:18.284+0900 I/efl-extension(21356): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-23 15:47:18.284+0900 I/efl-extension(21356): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445bf318, elm_image, func : 0x437c8ef1
05-23 15:47:18.284+0900 I/efl-extension(21356): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-23 15:47:18.284+0900 I/efl-extension(21356): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44573e88 : elm_scroller] rotary callabck is deleted
05-23 15:47:18.349+0900 E/APP_CORE(20581): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-23 15:47:18.349+0900 I/APP_CORE(20581): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-23 15:47:18.349+0900 I/CAPI_APPFW_APPLICATION(20581): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-23 15:47:18.354+0900 I/APP_CORE(21357): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-23 15:47:18.354+0900 I/CAPI_APPFW_APPLICATION(21357): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-23 15:47:18.394+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-23 15:47:18.394+0900 W/WATCH_CORE(  763): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-23 15:47:18.394+0900 I/WATCH_CORE(  763): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-23 15:47:18.394+0900 I/CAPI_WATCH_APPLICATION(  763): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-23 15:47:18.394+0900 E/watchface-loader(  763): watchface-loader.cpp: OnAppTimeTick(740) > 
05-23 15:47:18.394+0900 I/watchface-loader(  763): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-23 15:47:18.409+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-23 15:47:18.409+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-23 15:47:18.454+0900 W/APP_CORE(20557): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:5a00003
05-23 15:47:18.454+0900 I/MALI    (21357): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-23 15:47:18.454+0900 I/MALI    (21357): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=21357   close drm_fd=25 
05-23 15:47:18.454+0900 I/MALI    (21357): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-23 15:47:18.464+0900 I/MALI    (21356): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x4457c370], circle_obj[0x445a4f20]!
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x456d7250 = w: 0 h: 0  obj 0x4457c370 w: 360 h: 360
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445b7bd8 is freed
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x4540e220], circle_obj[0x45404850]!
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x457061f8 = w: 0 h: 0  obj 0x4540e220 w: 360 h: 360
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45428400 is freed
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445729b0 is freed
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4456c8f8, obj: 0x4456c8f8
05-23 15:47:18.484+0900 I/efl-extension(20581): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-23 15:47:18.509+0900 I/UXT     (21357): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-23 15:47:18.534+0900 I/MALI    (21356): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-23 15:47:18.534+0900 I/MALI    (21356): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=21356   close drm_fd=21 
05-23 15:47:18.534+0900 I/MALI    (21356): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-23 15:47:18.544+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-23 15:47:18.544+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x456d7250 is freed
05-23 15:47:18.544+0900 I/efl-extension(20581): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-23 15:47:18.544+0900 I/efl-extension(20581): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4456c8f8, elm_genlist, func : 0x437c5dfd
05-23 15:47:18.544+0900 I/efl-extension(20581): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-23 15:47:18.574+0900 W/W_HOME  (  730): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-23 15:47:18.574+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:18.574+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:18.574+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:18.574+0900 W/W_HOME  (  730): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-23 15:47:18.584+0900 W/W_HOME  (  730): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-23 15:47:18.584+0900 W/W_HOME  (  730): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-23 15:47:18.584+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:18.584+0900 W/W_HOME  (  730): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-23 15:47:18.584+0900 I/APP_CORE(  730): appcore-efl.c: __do_app(429) > [APP 730] Event: RESUME State: PAUSED
05-23 15:47:18.584+0900 I/CAPI_APPFW_APPLICATION(  730): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-23 15:47:18.584+0900 W/W_HOME  (  730): main.c: _appcore_resume_cb(681) > appcore resume
05-23 15:47:18.584+0900 W/W_HOME  (  730): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-23 15:47:18.584+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:18.584+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:18.584+0900 W/W_HOME  (  730): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-23 15:47:18.584+0900 W/APPS    (  730): apps_main.c: _time_changed_cb(295) >  date : 23->23
05-23 15:47:18.584+0900 W/W_HOME  (  730): rotary.c: rotary_attach(138) > rotary_attach:0x46646dc8
05-23 15:47:18.584+0900 I/efl-extension(  730): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46646dc8, elm_layout, _activated_obj : 0x45c968c0, activated : 1
05-23 15:47:18.584+0900 I/efl-extension(  730): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-23 15:47:18.589+0900 E/CAPI_NETWORK_BLUETOOTH(20581): bluetooth-adapter.c: bt_adapter_unset_state_changed_cb(842) > [bt_adapter_unset_state_changed_cb] NOT_INITIALIZED(0xfe400101)
05-23 15:47:18.589+0900 I/wnotib  (  730): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-23 15:47:18.589+0900 E/wnotib  (  730): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-23 15:47:18.589+0900 W/wnotib  (  730): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-23 15:47:18.589+0900 I/efl-extension(20581): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4457c370, , _activated_obj : 0x4540e220, activated : 1
05-23 15:47:18.589+0900 I/efl-extension(20581): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-23 15:47:18.589+0900 W/GESTURE (  140): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-23 15:47:18.589+0900 W/GESTURE (  140): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-23 15:47:18.589+0900 W/GESTURE (  140): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-23 15:47:18.589+0900 W/GESTURE (  140): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-23 15:47:18.589+0900 I/efl-extension(20581): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4566ee78, obj: 0x4566ee78
05-23 15:47:18.589+0900 I/efl-extension(20581): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-23 15:47:18.589+0900 I/efl-extension(20581): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-23 15:47:18.589+0900 I/efl-extension(20581): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-23 15:47:18.589+0900 I/efl-extension(20581): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-23 15:47:18.599+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-23 15:47:18.599+0900 I/efl-extension(20581): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x457061f8 is freed
05-23 15:47:18.599+0900 I/efl-extension(20581): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-23 15:47:18.599+0900 I/efl-extension(20581): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4566ee78, elm_genlist, func : 0x437c5dfd
05-23 15:47:18.599+0900 I/efl-extension(20581): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-23 15:47:18.619+0900 I/UXT     (21356): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-23 15:47:18.629+0900 I/MALI    (20581): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-23 15:47:18.629+0900 I/MALI    (20581): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=20581   close drm_fd=22 
05-23 15:47:18.629+0900 I/MALI    (20581): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-23 15:47:18.644+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-23 15:47:18.644+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-23 15:47:18.644+0900 E/APP_CORE(20557): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-23 15:47:18.644+0900 I/APP_CORE(20557): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-23 15:47:18.644+0900 I/CAPI_APPFW_APPLICATION(20557): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-23 15:47:18.644+0900 I/WIFI_EFL(20557): app_main.c: app_terminate(4453) > [Enter]
05-23 15:47:18.644+0900 I/WIFI_EFL(20557): app_main.c: _app_release(4193) > [Enter]
05-23 15:47:18.644+0900 E/WIFI_EFL(20557): wifi_manager.c: wifi_manager_ap_destroy(779) > 'ap_obj != NULL' failed.
05-23 15:47:18.664+0900 I/CAPI_NETWORK_WIFI(20557): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
05-23 15:47:18.664+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.664+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.664+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.669+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.669+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.669+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.669+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.669+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.669+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.669+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.669+0900 E/CAPI_NETWORK_WIFI(20557): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: eext_circle_surface_del(1362) > Surface[0x44bb5d58] is going to free in eext_circle_surface_del API.
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x44111ba0], circle_obj[0x44104658]!
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44148aa0 = w: 0 h: 0  obj 0x44111ba0 w: 360 h: 360
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44bc2238 is freed
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45636608 is freed
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x44bbeb28], circle_obj[0x455e2b88]!
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44126a80 = w: 0 h: 0  obj 0x44bbeb28 w: 360 h: 360
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44c3b8c8 is freed
05-23 15:47:18.674+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44bb5d58 is freed
05-23 15:47:18.674+0900 I/WIFI_EFL(20557): app_main.c: __main_del_cb(3767) > [Enter]
05-23 15:47:18.674+0900 I/CAPI_APPFW_APPLICATION(20557): app_main.c: app_efl_exit(145) > app_efl_exit
05-23 15:47:18.689+0900 I/efl-extension(20557): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44bb2550, obj: 0x44bb2550
05-23 15:47:18.689+0900 I/efl-extension(20557): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-23 15:47:18.694+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-23 15:47:18.694+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44148aa0 is freed
05-23 15:47:18.694+0900 I/efl-extension(20557): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-23 15:47:18.694+0900 I/efl-extension(20557): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44bb2550, elm_genlist, func : 0x419b3dfd
05-23 15:47:18.694+0900 I/efl-extension(20557): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-23 15:47:18.704+0900 I/WIFI_EFL(20557): app_main.c: __scan_del_cb(1071) > [Enter]
05-23 15:47:18.704+0900 I/CAPI_APPFW_APPLICATION(20557): app_main.c: app_efl_exit(145) > app_efl_exit
05-23 15:47:18.704+0900 I/efl-extension(20557): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c43d78, obj: 0x44c43d78
05-23 15:47:18.704+0900 I/efl-extension(20557): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-23 15:47:18.704+0900 I/efl-extension(20557): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-23 15:47:18.704+0900 I/efl-extension(20557): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-23 15:47:18.704+0900 I/efl-extension(20557): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-23 15:47:18.714+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-23 15:47:18.714+0900 I/efl-extension(20557): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44126a80 is freed
05-23 15:47:18.714+0900 I/efl-extension(20557): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44bbeb28
05-23 15:47:18.714+0900 I/efl-extension(20557): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-23 15:47:18.714+0900 I/efl-extension(20557): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c43d78, elm_genlist, func : 0x419b3dfd
05-23 15:47:18.714+0900 I/efl-extension(20557): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-23 15:47:18.724+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 6
05-23 15:47:18.724+0900 W/AUL_AMD (  493): amd_request.c: __foward_cmd(153) > __forward_cmd: 20557 20557
05-23 15:47:18.724+0900 E/AUL     (  493): app_sock.c: __connect_client_sock(196) > connect error: 111
05-23 15:47:18.724+0900 E/AUL     (  493): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-23 15:47:18.739+0900 I/UXT     (20581): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-23 15:47:18.769+0900 I/MALI    (20557): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-23 15:47:18.769+0900 I/MALI    (20557): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=20557   close drm_fd=29 
05-23 15:47:18.769+0900 I/MALI    (20557): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-23 15:47:18.819+0900 I/UXT     (20557): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-23 15:47:18.824+0900 E/AUL     (  493): app_sock.c: __connect_client_sock(196) > connect error: 111
05-23 15:47:18.824+0900 E/AUL     (  493): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-23 15:47:18.879+0900 I/efl-extension(21356): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-23 15:47:18.889+0900 I/MALI    (  730): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-23 15:47:19.009+0900 I/efl-extension(20581): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-23 15:47:19.074+0900 I/efl-extension(20557): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-23 15:47:19.124+0900 E/AUL     (  493): app_sock.c: __connect_client_sock(196) > connect error: 111
05-23 15:47:19.124+0900 E/AUL     (  493): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-23 15:47:19.259+0900 I/AUL_AMD (  493): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 21356
05-23 15:47:19.264+0900 I/AUL_AMD (  493): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 20557
05-23 15:47:19.264+0900 I/AUL_AMD (  493): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 20581
05-23 15:47:19.309+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 23
05-23 15:47:19.309+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-23 15:47:19.309+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 21357
05-23 15:47:19.309+0900 W/AUL_AMD (  493): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-23 15:47:19.309+0900 E/AUL     (21533): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-23 15:47:19.354+0900 I/AUL_AMD (  493): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 21357
05-23 15:47:19.409+0900 W/CRASH_MANAGER(21531): worker.c: worker_job(1199) > 1121357706831146398603
