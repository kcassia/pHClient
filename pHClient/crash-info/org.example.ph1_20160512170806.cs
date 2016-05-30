S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 5502
Date: 2016-05-12 17:08:06+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4048f250, r3   = 0x00000000
r4   = 0x464030f0, r5   = 0x00000000
r6   = 0x464039f0, r7   = 0x00000000
r8   = 0x464027f0, r9   = 0x46402370
r10  = 0x44040fb0, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbef2a638
lr   = 0x403d81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     44384 KB
Buffers:     29952 KB
Cached:     126108 KB
VmPeak:     108596 KB
VmSize:      99156 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21068 KB
VmRSS:       21068 KB
VmData:      43584 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50644 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5502 TID = 5502
5502 5508 5511 

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
43748000 4375c000 rwxp [stack:5508]
4375c000 4375f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43766000 43767000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440a3000 440a5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44b72000 44b75000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b75000 44b79000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b79000 44b88000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
45694000 45f93000 rwxp [stack:5511]
4615b000 4615e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46165000 46166000 rwxp /usr/lib/libpulse-simple.so.0.0.4
465d5000 4660d000 r-xp /usr/lib/libpulse.so.0.16.2
4660d000 4660e000 rwxp /usr/lib/libpulse.so.0.16.2
46682000 46687000 r-xp /usr/lib/libjson.so.0.0.1
4668e000 4668f000 rwxp /usr/lib/libjson.so.0.0.1
4668f000 466d7000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
466d7000 466d8000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
466d8000 4671b000 r-xp /usr/lib/libsndfile.so.1.0.25
46722000 46724000 rwxp /usr/lib/libsndfile.so.1.0.25
46728000 4674a000 r-xp /usr/lib/libvorbis.so.0.4.3
46751000 46752000 rwxp /usr/lib/libvorbis.so.0.4.3
46752000 46756000 r-xp /usr/lib/libogg.so.0.7.1
4675d000 4675e000 rwxp /usr/lib/libogg.so.0.7.1
bef0a000 bef2b000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5502)
Call Stack Count: 2
 0: cfree + 0xc8 (0x403d81e8) [/lib/libc.so.6] + 0x6f1e8
 1: (0x20) (null)
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
(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:07:00.423+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_before_10min_precaution_millisec error
05-12 17:07:00.623+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.623+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.623+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4031815
05-12 17:07:00.623+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:00.623+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:00.623+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.663+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.663+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.663+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4031857
05-12 17:07:00.663+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:00.663+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:00.663+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.688+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:07:00.723+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.723+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.723+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4031913
05-12 17:07:00.723+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:00.723+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:00.723+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.788+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.788+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.788+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4031979
05-12 17:07:00.788+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:00.788+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:00.788+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.843+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.843+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.843+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4032035
05-12 17:07:00.843+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:00.843+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:00.843+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.888+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.893+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.893+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4032083
05-12 17:07:00.893+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:00.893+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:00.893+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.943+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.943+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.943+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4032135
05-12 17:07:00.943+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:00.943+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:00.943+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.988+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.988+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:00.988+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4032181
05-12 17:07:00.988+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:00.988+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:00.988+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:01.043+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:01.043+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:01.043+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4032235
05-12 17:07:01.043+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:01.043+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:01.043+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:01.528+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.528+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.528+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4032722
05-12 17:07:01.533+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:01.533+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:01.533+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.633+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.633+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.633+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4032827
05-12 17:07:01.633+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:01.633+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:01.633+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.668+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 80 -> 79 1463040421 120
05-12 17:07:01.673+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 79 1943 378 2558
05-12 17:07:01.673+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 79 0 0 3067
05-12 17:07:01.673+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 79 1545 640 2034
05-12 17:07:01.673+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 79 150 5 198
05-12 17:07:01.673+0900 I/RESOURCED(  494): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 79 559 20 736
05-12 17:07:01.683+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.688+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.688+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4032877
05-12 17:07:01.688+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:01.688+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:01.688+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.723+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.723+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.723+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4032914
05-12 17:07:01.723+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:01.723+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:01.723+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.763+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.763+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.768+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4032958
05-12 17:07:01.768+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:01.768+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:01.768+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.883+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.883+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:01.883+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4033077
05-12 17:07:01.883+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:01.883+0900 E/TIMER   ( 5502): (ad->timer) -> _rotary_cb() return
05-12 17:07:01.883+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:07:04.323+0900 E/EFL     ( 5502): evas_main<5502> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4035516 button=1 downs=1
05-12 17:07:04.408+0900 E/EFL     ( 5502): evas_main<5502> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4035600 button=1 downs=0
05-12 17:07:04.408+0900 D/TIMER   ( 5502): Start clicked
05-12 17:07:04.408+0900 E/EFL     ( 5502): ecore<5502> ecore.c:574 _ecore_magic_fail() 
05-12 17:07:04.408+0900 E/EFL     ( 5502): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-12 17:07:04.408+0900 E/EFL     ( 5502): *** IN FUNCTION: ecore_timer_del()
05-12 17:07:04.408+0900 E/EFL     ( 5502): ecore<5502> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-12 17:07:04.408+0900 E/EFL     ( 5502):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-12 17:07:04.408+0900 E/EFL     ( 5502):     Supplied: e5933114 - <UNKNOWN>
05-12 17:07:04.408+0900 E/EFL     ( 5502): ecore<5502> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-12 17:07:04.408+0900 E/EFL     ( 5502): *** SPANK SPANK SPANK!!!
05-12 17:07:04.408+0900 E/EFL     ( 5502): *** Now go fix your code. Tut tut tut!
05-12 17:07:04.408+0900 E/EFL     ( 5502): ecore<5502> ecore.c:574 _ecore_magic_fail() 
05-12 17:07:04.408+0900 E/EFL     ( 5502): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-12 17:07:04.408+0900 E/EFL     ( 5502): *** IN FUNCTION: ecore_timer_del()
05-12 17:07:04.408+0900 E/EFL     ( 5502): ecore<5502> ecore.c:584 _ecore_magic_fail()   Input handle is wrong type
05-12 17:07:04.408+0900 E/EFL     ( 5502):     Expected: f7d713f4 - Ecore_Timer (Timer)
05-12 17:07:04.408+0900 E/EFL     ( 5502):     Supplied: 403d8280 - <UNKNOWN>
05-12 17:07:04.408+0900 E/EFL     ( 5502): ecore<5502> ecore.c:587 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-12 17:07:04.408+0900 E/EFL     ( 5502): *** SPANK SPANK SPANK!!!
05-12 17:07:04.408+0900 E/EFL     ( 5502): *** Now go fix your code. Tut tut tut!
05-12 17:07:04.408+0900 I/SOCKETTEST( 5502): Success to create socket
05-12 17:07:04.488+0900 I/SOCKETTEST( 5502): Success to socket connection
05-12 17:07:04.488+0900 I/SOCKETTEST( 5502): write() 성공
05-12 17:07:07.328+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.333+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.333+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4038523
05-12 17:07:07.333+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:07.333+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4038523]
05-12 17:07:07.333+0900 D/TIMER   ( 5502): Pre change num: 00
05-12 17:07:07.333+0900 D/TIMER   ( 5502): Post change num: 0
05-12 17:07:07.333+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.388+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.388+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.388+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.388+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4038579
05-12 17:07:07.388+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:07.388+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4038579]
05-12 17:07:07.388+0900 D/TIMER   ( 5502): Pre change num: 1
05-12 17:07:07.388+0900 D/TIMER   ( 5502): Post change num: 1
05-12 17:07:07.453+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.453+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.453+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.453+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4038644
05-12 17:07:07.453+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:07.453+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4038644]
05-12 17:07:07.453+0900 D/TIMER   ( 5502): Pre change num: 2
05-12 17:07:07.453+0900 D/TIMER   ( 5502): Post change num: 2
05-12 17:07:07.513+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.513+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.513+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.513+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4038705
05-12 17:07:07.513+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:07.513+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4038705]
05-12 17:07:07.513+0900 D/TIMER   ( 5502): Pre change num: 3
05-12 17:07:07.513+0900 D/TIMER   ( 5502): Post change num: 3
05-12 17:07:07.563+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.563+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.568+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.568+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4038758
05-12 17:07:07.568+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:07.568+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4038758]
05-12 17:07:07.568+0900 D/TIMER   ( 5502): Pre change num: 4
05-12 17:07:07.568+0900 D/TIMER   ( 5502): Post change num: 4
05-12 17:07:07.693+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.693+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.693+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.693+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4038887
05-12 17:07:07.693+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:07.693+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4038887]
05-12 17:07:07.693+0900 D/TIMER   ( 5502): Pre change num: 5
05-12 17:07:07.693+0900 D/TIMER   ( 5502): Post change num: 5
05-12 17:07:07.813+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.813+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.813+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:07.813+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4039006
05-12 17:07:07.813+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:07.813+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4039006]
05-12 17:07:07.813+0900 D/TIMER   ( 5502): Pre change num: 6
05-12 17:07:07.813+0900 D/TIMER   ( 5502): Post change num: 6
05-12 17:07:10.333+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-12 17:07:10.333+0900 I/RESOURCED(  494): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-12 17:07:12.853+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:07:12.853+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:07:13.443+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:07:13.443+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:07:15.778+0900 E/WMS     (  485): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-12 17:07:15.778+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-12 17:07:15.778+0900 E/WMS     (  485): ==========
05-12 17:07:15.778+0900 E/WMS     (  485): ##WMS SEND : mgr_gear_wear_onoff_req
05-12 17:07:15.778+0900 E/WMS     (  485): ==========
05-12 17:07:15.778+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-12 17:07:15.818+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-12 17:07:15.818+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-12 17:07:15.818+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-12 17:07:15.823+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [63 / 63] bytes. 
05-12 17:07:25.873+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:07:25.873+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:07:26.248+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:07:26.248+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:07:26.248+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-12 17:07:26.248+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-12 17:07:26.248+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-12 17:07:26.248+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-12 17:07:26.988+0900 E/WMS     (  485): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-12 17:07:26.988+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-12 17:07:26.988+0900 E/WMS     (  485): ==========
05-12 17:07:26.988+0900 E/WMS     (  485): ##WMS SEND : mgr_gear_wear_onoff_req
05-12 17:07:26.988+0900 E/WMS     (  485): ==========
05-12 17:07:26.988+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-12 17:07:27.073+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-12 17:07:27.073+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-12 17:07:27.073+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-12 17:07:27.078+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [63 / 63] bytes. 
05-12 17:07:29.863+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:07:29.863+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:07:32.748+0900 E/WMS     (  485): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-12 17:07:32.753+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-12 17:07:32.753+0900 E/WMS     (  485): ==========
05-12 17:07:32.753+0900 E/WMS     (  485): ##WMS SEND : mgr_gear_wear_onoff_req
05-12 17:07:32.753+0900 E/WMS     (  485): ==========
05-12 17:07:32.753+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-12 17:07:32.828+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-12 17:07:32.828+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-12 17:07:32.828+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-12 17:07:32.828+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [63 / 63] bytes. 
05-12 17:07:37.058+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 17:07:55.008+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:07:55.008+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:07:55.708+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-12 17:07:55.708+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-12 17:07:55.713+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
05-12 17:07:55.718+0900 W/W_HOME  (  732): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-12 17:07:55.748+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-12 17:07:55.748+0900 W/WAKEUP-SERVICE( 1091): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-12 17:07:56.218+0900 E/WMS     (  485): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 2 -> 1
05-12 17:07:56.223+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-12 17:07:56.223+0900 E/WMS     (  485): ==========
05-12 17:07:56.223+0900 E/WMS     (  485): ##WMS SEND : mgr_gear_wear_onoff_req
05-12 17:07:56.223+0900 E/WMS     (  485): ==========
05-12 17:07:56.228+0900 E/WMS     (  485): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
05-12 17:07:56.308+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
05-12 17:07:56.308+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
05-12 17:07:56.308+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
05-12 17:07:56.313+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [63 / 63] bytes. 
05-12 17:07:56.958+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:56.958+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:56.958+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4088152
05-12 17:07:56.958+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:56.958+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4088152]
05-12 17:07:56.963+0900 D/TIMER   ( 5502): Pre change num: 7
05-12 17:07:56.963+0900 D/TIMER   ( 5502): Post change num: 7
05-12 17:07:56.963+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.003+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.003+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.003+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4088197
05-12 17:07:57.003+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:57.003+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4088197]
05-12 17:07:57.003+0900 D/TIMER   ( 5502): Pre change num: 8
05-12 17:07:57.003+0900 D/TIMER   ( 5502): Post change num: 8
05-12 17:07:57.008+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.053+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.053+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.053+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.053+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4088245
05-12 17:07:57.053+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:57.053+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4088245]
05-12 17:07:57.053+0900 D/TIMER   ( 5502): Pre change num: 9
05-12 17:07:57.053+0900 D/TIMER   ( 5502): Post change num: 9
05-12 17:07:57.128+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.128+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.128+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.128+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4088322
05-12 17:07:57.128+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:57.128+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4088322]
05-12 17:07:57.128+0900 D/TIMER   ( 5502): Pre change num: 10
05-12 17:07:57.128+0900 D/TIMER   ( 5502): Post change num: 10
05-12 17:07:57.208+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.208+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.208+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.208+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4088401
05-12 17:07:57.208+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:57.208+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4088401]
05-12 17:07:57.208+0900 D/TIMER   ( 5502): Pre change num: 11
05-12 17:07:57.208+0900 D/TIMER   ( 5502): Post change num: 11
05-12 17:07:57.278+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.283+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.283+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.283+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4088473
05-12 17:07:57.283+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:57.283+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4088473]
05-12 17:07:57.283+0900 D/TIMER   ( 5502): Pre change num: 12
05-12 17:07:57.283+0900 D/TIMER   ( 5502): Post change num: 12
05-12 17:07:57.378+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.378+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.383+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:57.383+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4088572
05-12 17:07:57.383+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:57.383+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4088572]
05-12 17:07:57.383+0900 D/TIMER   ( 5502): Pre change num: 13
05-12 17:07:57.383+0900 D/TIMER   ( 5502): Post change num: 13
05-12 17:07:58.358+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:58.358+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:58.358+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4089551
05-12 17:07:58.358+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:58.358+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4089551]
05-12 17:07:58.358+0900 D/TIMER   ( 5502): Pre change num: 14
05-12 17:07:58.358+0900 D/TIMER   ( 5502): Post change num: 14
05-12 17:07:58.363+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:58.443+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:58.443+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:58.443+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 17:07:58.443+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4089633
05-12 17:07:58.443+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:07:58.443+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[0], time_stamp[4089633]
05-12 17:07:58.443+0900 D/TIMER   ( 5502): Pre change num: 15
05-12 17:07:58.443+0900 D/TIMER   ( 5502): Post change num: 15
05-12 17:08:00.058+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:00.058+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:00.058+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4091251
05-12 17:08:00.058+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:08:00.063+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[1], time_stamp[4091251]
05-12 17:08:00.063+0900 D/TIMER   ( 5502): Pre change num: 16
05-12 17:08:00.063+0900 D/TIMER   ( 5502): Post change num: 16
05-12 17:08:00.063+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:00.123+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:00.123+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:00.123+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:00.123+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4091316
05-12 17:08:00.123+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:08:00.123+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[1], time_stamp[4091316]
05-12 17:08:00.123+0900 D/TIMER   ( 5502): Pre change num: 15
05-12 17:08:00.123+0900 D/TIMER   ( 5502): Post change num: 15
05-12 17:08:00.183+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:00.183+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:00.183+0900 I/efl-extension( 5502): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-12 17:08:00.183+0900 I/efl-extension( 5502): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x44c06b58, elm_layout, time_stamp : 4091373
05-12 17:08:00.183+0900 D/TIMER   ( 5502): Rotary callback is called
05-12 17:08:00.183+0900 D/TIMER   ( 5502): Detent detected, obj[0x44c06b58], direction[1], time_stamp[4091373]
05-12 17:08:00.183+0900 D/TIMER   ( 5502): Pre change num: 14
05-12 17:08:00.183+0900 D/TIMER   ( 5502): Post change num: 14
05-12 17:08:00.483+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-12 17:08:00.483+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-12 17:08:00.483+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : pedometer_inactive_period error
05-12 17:08:00.483+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:08:00.483+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:08:00.483+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_10min_precaution_millisec error
05-12 17:08:00.483+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 17:08:00.483+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 17:08:00.483+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_before_10min_precaution_millisec error
05-12 17:08:00.693+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:08:04.223+0900 E/EFL     ( 5502): evas_main<5502> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4095412 button=1 downs=1
05-12 17:08:04.323+0900 E/EFL     ( 5502): evas_main<5502> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4095515 button=1 downs=0
05-12 17:08:04.878+0900 E/GESTURE (  144): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=46   flick_area=55 ---> SET value to 1
05-12 17:08:04.878+0900 E/GESTURE (  144): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
05-12 17:08:04.878+0900 E/GESTURE (  144): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=46   flick_area=55 ---> SET value to 1
05-12 17:08:04.968+0900 E/GESTURE (  144): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
05-12 17:08:05.413+0900 I/efl-extension( 5502): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c06b58
05-12 17:08:05.413+0900 I/efl-extension( 5502): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c06b58, obj: 0x44c06b58
05-12 17:08:05.413+0900 I/efl-extension( 5502): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-12 17:08:05.413+0900 I/efl-extension( 5502): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-12 17:08:05.413+0900 I/efl-extension( 5502): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-12 17:08:05.413+0900 I/efl-extension( 5502): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-12 17:08:06.028+0900 E/GESTURE (  144): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=45   flick_area=55 ---> SET value to 1
05-12 17:08:06.028+0900 E/GESTURE (  144): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
05-12 17:08:06.028+0900 E/GESTURE (  144): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=45   flick_area=55 ---> SET value to 1
05-12 17:08:06.118+0900 E/GESTURE (  144): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
05-12 17:08:06.123+0900 I/CAPI_APPFW_APPLICATION( 5502): app_main.c: ui_app_exit(715) > ui_app_exit
05-12 17:08:06.123+0900 I/CAPI_APPFW_APPLICATION( 5502): app_main.c: app_efl_exit(145) > app_efl_exit
05-12 17:08:06.123+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 22
05-12 17:08:06.123+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(890) > app status : 4
05-12 17:08:06.228+0900 I/APP_CORE( 5502): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-12 17:08:06.228+0900 I/APP_CORE( 5502): appcore-efl.c: __after_loop(1090) > [APP 5502] PAUSE before termination
05-12 17:08:06.228+0900 I/CAPI_APPFW_APPLICATION( 5502): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-12 17:08:06.233+0900 I/CAPI_APPFW_APPLICATION( 5502): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-12 17:08:06.253+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-12 17:08:06.253+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-12 17:08:06.278+0900 I/MALI    ( 5502): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f4f010] swap changed from sync to async
05-12 17:08:06.298+0900 I/MALI    ( 5502): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-12 17:08:06.298+0900 I/MALI    ( 5502): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=5502   close drm_fd=25 
05-12 17:08:06.298+0900 I/MALI    ( 5502): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-12 17:08:06.338+0900 W/PROCESSMGR(  381): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-12 17:08:06.338+0900 W/WATCH_CORE(  761): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-12 17:08:06.338+0900 I/WATCH_CORE(  761): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
05-12 17:08:06.348+0900 I/UXT     ( 5502): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-12 17:08:06.348+0900 W/W_HOME  (  732): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-12 17:08:06.348+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:06.348+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:06.348+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:06.348+0900 W/W_HOME  (  732): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-12 17:08:06.378+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-12 17:08:06.378+0900 W/W_HOME  (  732): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-12 17:08:06.378+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:06.378+0900 W/W_HOME  (  732): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-12 17:08:06.378+0900 I/APP_CORE(  732): appcore-efl.c: __do_app(429) > [APP 732] Event: RESUME State: PAUSED
05-12 17:08:06.378+0900 I/CAPI_APPFW_APPLICATION(  732): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-12 17:08:06.378+0900 W/W_HOME  (  732): main.c: _appcore_resume_cb(681) > appcore resume
05-12 17:08:06.378+0900 W/W_HOME  (  732): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-12 17:08:06.378+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:06.378+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:06.378+0900 W/W_HOME  (  732): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-12 17:08:06.378+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 17:08:06.378+0900 W/W_HOME  (  732): rotary.c: rotary_attach(138) > rotary_attach:0x46f639e0
05-12 17:08:06.378+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46f639e0, elm_layout, _activated_obj : 0x45c95f90, activated : 1
05-12 17:08:06.378+0900 I/efl-extension(  732): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-12 17:08:06.393+0900 I/wnotib  (  732): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-12 17:08:06.393+0900 E/wnotib  (  732): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-12 17:08:06.393+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-12 17:08:06.398+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-12 17:08:06.398+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 17:08:06.398+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 17:08:06.398+0900 W/GESTURE (  144): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-12 17:08:06.838+0900 I/MALI    (  732): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1518] swap changed from async to sync
05-12 17:08:07.098+0900 W/CRASH_MANAGER( 5781): worker.c: worker_job(1199) > 1105502706831146304048
