S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 7067
Date: 2016-05-26 16:44:05+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4048f250, r3   = 0x00000000
r4   = 0x443095c8, r5   = 0x00000000
r6   = 0x44309ec8, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x44308848
r10  = 0x4403ff30, fp   = 0x00000000
ip   = 0x4008c490, sp   = 0xbed22638
lr   = 0x403d81e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     30784 KB
Buffers:     37932 KB
Cached:     129444 KB
VmPeak:     108740 KB
VmSize:      98116 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20924 KB
VmRSS:       20924 KB
VmData:      42544 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50644 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7067 TID = 7067
7067 7072 7075 7197 

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
43748000 4375c000 rwxp [stack:7072]
4375c000 4375f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43766000 43767000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440a3000 440a5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44373000 44b72000 rwxp [stack:7197]
44b72000 44b75000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b75000 44b79000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b79000 44b88000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
45694000 45e93000 rwxp [stack:7075]
46410000 46413000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4641a000 4641b000 rwxp /usr/lib/libpulse-simple.so.0.0.4
464e2000 4651a000 r-xp /usr/lib/libpulse.so.0.16.2
4651a000 4651b000 rwxp /usr/lib/libpulse.so.0.16.2
46563000 46568000 r-xp /usr/lib/libjson.so.0.0.1
4656f000 46570000 rwxp /usr/lib/libjson.so.0.0.1
46570000 465b8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
465b8000 465b9000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
465b9000 465fc000 r-xp /usr/lib/libsndfile.so.1.0.25
46603000 46605000 rwxp /usr/lib/libsndfile.so.1.0.25
46609000 4662b000 r-xp /usr/lib/libvorbis.so.0.4.3
46632000 46633000 rwxp /usr/lib/libvorbis.so.0.4.3
46633000 46637000 r-xp /usr/lib/libogg.so.0.7.1
4663e000 4663f000 rwxp /usr/lib/libogg.so.0.7.1
bed02000 bed23000 rwxp [stack]
End of Maps Information

Callstack Information (PID:7067)
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
1.580002, 70.769997, 49.349998
05-26 16:43:44.635+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:44.635+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:44.635+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:44.635+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:44.635+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:44.715+0900 I/SENSOR  ( 7067): -9.730000, -42.700001, -11.760000
05-26 16:43:44.815+0900 I/SENSOR  ( 7067): -134.330002, -72.590004, 11.200000
05-26 16:43:44.910+0900 I/SENSOR  ( 7067): -141.820007, -58.799999, 100.169998
05-26 16:43:45.015+0900 I/SENSOR  ( 7067): -536.690002, -127.050003, 33.670002
05-26 16:43:45.120+0900 I/SENSOR  ( 7067): -430.290009, -228.550003, -62.230000
05-26 16:43:45.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:45.205+0900 D/TIMER   ( 7067): Remind time: 591
05-26 16:43:45.225+0900 D/TIMER   ( 7067): Start clicked
05-26 16:43:45.250+0900 I/SENSOR  ( 7067): 158.830002, -99.680000, 76.930000
05-26 16:43:45.320+0900 I/SENSOR  ( 7067): 709.520020, 32.270000, 72.239998
05-26 16:43:45.415+0900 I/SENSOR  ( 7067): -24.010000, 2.100000, -0.560000
05-26 16:43:45.520+0900 I/SENSOR  ( 7067): 4.550000, -8.050000, 8.190000
05-26 16:43:45.620+0900 I/SENSOR  ( 7067): -1809.709961, -201.949997, -29.469999
05-26 16:43:45.620+0900 I/SENSOR  ( 7067): 앞으로 
05-26 16:43:45.620+0900 I/SOCKETTEST( 7067): Success to create socket
05-26 16:43:45.645+0900 I/SOCKETTEST( 7067): Success to socket connection
05-26 16:43:45.645+0900 I/SOCKETTEST( 7067): write() 성공
05-26 16:43:45.720+0900 I/SENSOR  ( 7067): 953.330017, 361.970001, 23.170000
05-26 16:43:45.820+0900 I/SENSOR  ( 7067): 1075.619995, 185.919998, 41.720001
05-26 16:43:45.920+0900 I/SENSOR  ( 7067): 297.079987, 48.580002, 16.520000
05-26 16:43:46.020+0900 I/SENSOR  ( 7067): -62.160000, -16.170000, -8.400000
05-26 16:43:46.120+0900 I/SENSOR  ( 7067): -11.200000, 1.680000, -0.420000
05-26 16:43:46.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:46.205+0900 D/TIMER   ( 7067): Remind time: 590
05-26 16:43:46.255+0900 I/SENSOR  ( 7067): -36.540001, -8.330000, -1.960000
05-26 16:43:46.315+0900 I/SENSOR  ( 7067): 15.960000, -1.470000, 4.830000
05-26 16:43:46.420+0900 I/SENSOR  ( 7067): -539.770020, -260.190002, -118.160004
05-26 16:43:46.525+0900 I/SENSOR  ( 7067): -109.059998, -212.940002, 18.410000
05-26 16:43:46.620+0900 I/SENSOR  ( 7067): 88.199997, -111.860001, 79.800003
05-26 16:43:46.720+0900 I/SENSOR  ( 7067): 521.919983, 45.639999, 63.560001
05-26 16:43:46.820+0900 I/SENSOR  ( 7067): 54.110001, 33.459999, -2.030000
05-26 16:43:46.920+0900 I/SENSOR  ( 7067): 112.000000, 26.530001, 7.770000
05-26 16:43:47.020+0900 I/SENSOR  ( 7067): -135.449997, -22.400000, 13.090000
05-26 16:43:47.120+0900 I/SENSOR  ( 7067): -34.299999, -2.380000, 21.910000
05-26 16:43:47.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:47.205+0900 D/TIMER   ( 7067): Remind time: 589
05-26 16:43:47.245+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:47.245+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:47.250+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:47.250+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:47.250+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:47.255+0900 I/SENSOR  ( 7067): -6.860000, -2.310000, -1.890000
05-26 16:43:47.315+0900 I/SENSOR  ( 7067): -32.130001, 6.930000, -0.840000
05-26 16:43:47.420+0900 I/SENSOR  ( 7067): 6.790000, 10.430000, 1.330000
05-26 16:43:47.520+0900 I/SENSOR  ( 7067): 5.810000, 1.050000, 4.340000
05-26 16:43:47.620+0900 I/SENSOR  ( 7067): -2.030000, -1.680000, 4.130000
05-26 16:43:47.725+0900 I/SENSOR  ( 7067): -12.880000, -9.590000, 5.040000
05-26 16:43:47.825+0900 I/SENSOR  ( 7067): -45.500000, -7.560000, 2.520000
05-26 16:43:47.920+0900 I/SENSOR  ( 7067): -23.450001, 3.360000, 3.290000
05-26 16:43:48.020+0900 I/SENSOR  ( 7067): -6.510000, 1.050000, 3.780000
05-26 16:43:48.120+0900 I/SENSOR  ( 7067): -6.370000, -2.660000, 6.370000
05-26 16:43:48.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:48.205+0900 D/TIMER   ( 7067): Remind time: 588
05-26 16:43:48.245+0900 I/SENSOR  ( 7067): 48.090000, 27.790001, -0.070000
05-26 16:43:48.320+0900 I/SENSOR  ( 7067): 251.580002, 42.070000, 19.879999
05-26 16:43:48.425+0900 I/SENSOR  ( 7067): 245.630005, -0.350000, 46.480000
05-26 16:43:48.520+0900 I/SENSOR  ( 7067): -124.949997, -37.380001, -3.570000
05-26 16:43:48.625+0900 I/SENSOR  ( 7067): -562.799988, -86.730003, -15.120000
05-26 16:43:48.650+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:48.650+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:48.650+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:48.650+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:48.650+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:48.720+0900 I/SENSOR  ( 7067): 76.790001, 7.630000, 16.240000
05-26 16:43:48.820+0900 I/SENSOR  ( 7067): 135.100006, 40.810001, 23.450001
05-26 16:43:48.915+0900 I/SENSOR  ( 7067): 54.250000, 28.139999, 14.560000
05-26 16:43:49.015+0900 I/SENSOR  ( 7067): 70.840004, 16.030001, 17.430000
05-26 16:43:49.125+0900 I/SENSOR  ( 7067): 89.040001, 13.160000, 38.500000
05-26 16:43:49.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:49.205+0900 D/TIMER   ( 7067): Remind time: 587
05-26 16:43:49.240+0900 I/SENSOR  ( 7067): 3.780000, 15.960000, 57.400002
05-26 16:43:49.320+0900 I/SENSOR  ( 7067): 1.190000, 67.059998, 52.990002
05-26 16:43:49.425+0900 I/SENSOR  ( 7067): -29.820000, -0.280000, 23.940001
05-26 16:43:49.530+0900 I/SENSOR  ( 7067): -1.190000, 14.280000, 33.880001
05-26 16:43:49.625+0900 I/SENSOR  ( 7067): -18.270000, 6.370000, 15.960000
05-26 16:43:49.720+0900 I/SENSOR  ( 7067): -41.509998, -22.680000, 28.280001
05-26 16:43:49.825+0900 I/SENSOR  ( 7067): -12.880000, -10.080000, 31.990000
05-26 16:43:49.920+0900 I/SENSOR  ( 7067): -7.560000, 8.540000, 37.380001
05-26 16:43:50.025+0900 I/SENSOR  ( 7067): -3.500000, -3.010000, 17.150000
05-26 16:43:50.125+0900 I/SENSOR  ( 7067): -5.250000, -9.730000, -4.620000
05-26 16:43:50.200+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:50.205+0900 D/TIMER   ( 7067): Remind time: 586
05-26 16:43:50.230+0900 I/SENSOR  ( 7067): -3.080000, -18.410000, -19.180000
05-26 16:43:50.320+0900 I/SENSOR  ( 7067): 13.020000, 0.770000, 1.960000
05-26 16:43:50.425+0900 I/SENSOR  ( 7067): -7.490000, 29.680000, -7.070000
05-26 16:43:50.525+0900 I/SENSOR  ( 7067): -97.790001, -53.760002, -45.220001
05-26 16:43:50.625+0900 I/SENSOR  ( 7067): -32.270000, -25.200001, -74.900002
05-26 16:43:50.710+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:50.710+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:50.715+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:50.715+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:50.715+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:50.720+0900 I/SENSOR  ( 7067): 76.160004, 14.700000, -67.620003
05-26 16:43:50.820+0900 I/SENSOR  ( 7067): 165.410004, 27.510000, -62.439999
05-26 16:43:50.920+0900 I/SENSOR  ( 7067): 206.990005, -9.800000, -28.910000
05-26 16:43:51.025+0900 I/SENSOR  ( 7067): 39.759998, -62.299999, -13.510000
05-26 16:43:51.045+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:51.045+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:51.045+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:51.045+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:51.045+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:51.045+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 16:43:51.045+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 16:43:51.045+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 16:43:51.050+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 16:43:51.120+0900 I/SENSOR  ( 7067): -1859.619995, -321.019989, -77.209999
05-26 16:43:51.120+0900 I/SENSOR  ( 7067): 앞으로 
05-26 16:43:51.120+0900 I/SOCKETTEST( 7067): Success to create socket
05-26 16:43:51.140+0900 I/SOCKETTEST( 7067): Success to socket connection
05-26 16:43:51.140+0900 I/SOCKETTEST( 7067): write() 성공
05-26 16:43:51.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:51.205+0900 D/TIMER   ( 7067): Remind time: 585
05-26 16:43:51.235+0900 I/SENSOR  ( 7067): -11.480000, 90.650002, 31.219999
05-26 16:43:51.320+0900 I/SENSOR  ( 7067): 814.030029, 220.360001, 27.719999
05-26 16:43:51.425+0900 I/SENSOR  ( 7067): 156.169998, 51.939999, 16.799999
05-26 16:43:51.525+0900 I/SENSOR  ( 7067): -6.720000, 45.849998, -9.450000
05-26 16:43:51.625+0900 I/SENSOR  ( 7067): -67.760002, -47.599998, 0.420000
05-26 16:43:51.725+0900 I/SENSOR  ( 7067): -3.990000, 1.470000, 3.850000
05-26 16:43:51.825+0900 I/SENSOR  ( 7067): -8.610000, 5.250000, 7.350000
05-26 16:43:51.925+0900 I/SENSOR  ( 7067): -10.920000, -15.750000, 3.990000
05-26 16:43:52.025+0900 I/SENSOR  ( 7067): -15.890000, -13.510000, 9.030000
05-26 16:43:52.125+0900 I/SENSOR  ( 7067): 0.490000, -5.950000, 3.220000
05-26 16:43:52.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:52.205+0900 D/TIMER   ( 7067): Remind time: 584
05-26 16:43:52.230+0900 I/SENSOR  ( 7067): 0.910000, -3.640000, 5.600000
05-26 16:43:52.325+0900 I/SENSOR  ( 7067): 13.090000, -2.940000, 4.900000
05-26 16:43:52.425+0900 I/SENSOR  ( 7067): -5.460000, -12.670000, 4.970000
05-26 16:43:52.525+0900 I/SENSOR  ( 7067): -13.650000, -10.290000, 6.160000
05-26 16:43:52.625+0900 I/SENSOR  ( 7067): -3.010000, -7.210000, 4.900000
05-26 16:43:52.725+0900 I/SENSOR  ( 7067): -1.750000, -4.900000, 3.990000
05-26 16:43:52.825+0900 I/SENSOR  ( 7067): -8.960000, -3.710000, 4.900000
05-26 16:43:52.930+0900 I/SENSOR  ( 7067): 10.850000, 8.960000, 6.510000
05-26 16:43:53.025+0900 I/SENSOR  ( 7067): 34.020000, 25.340000, 6.090000
05-26 16:43:53.125+0900 I/SENSOR  ( 7067): 32.619999, 20.020000, -16.799999
05-26 16:43:53.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:53.205+0900 D/TIMER   ( 7067): Remind time: 583
05-26 16:43:53.230+0900 I/SENSOR  ( 7067): 51.099998, 0.490000, -39.619999
05-26 16:43:53.325+0900 I/SENSOR  ( 7067): -31.500000, -38.920002, -93.870003
05-26 16:43:53.430+0900 I/SENSOR  ( 7067): -48.860001, -114.379997, -169.259995
05-26 16:43:53.525+0900 I/SENSOR  ( 7067): -37.520000, -113.610001, -226.520004
05-26 16:43:53.595+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:53.595+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:53.595+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:53.595+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:53.595+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:53.620+0900 I/SENSOR  ( 7067): 86.449997, -58.939999, -212.169998
05-26 16:43:53.725+0900 I/SENSOR  ( 7067): 104.860001, -31.920000, -122.430000
05-26 16:43:53.825+0900 I/SENSOR  ( 7067): 111.720001, -11.200000, -44.310001
05-26 16:43:53.925+0900 I/SENSOR  ( 7067): -110.459999, -38.290001, 49.139999
05-26 16:43:54.025+0900 I/SENSOR  ( 7067): -37.939999, 10.570000, 113.330002
05-26 16:43:54.130+0900 I/SENSOR  ( 7067): -36.119999, 77.489998, 224.279999
05-26 16:43:54.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:54.205+0900 D/TIMER   ( 7067): Remind time: 582
05-26 16:43:54.265+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:54.265+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:54.265+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:54.265+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:54.265+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:54.280+0900 I/SENSOR  ( 7067): 88.480003, 119.279999, 272.929993
05-26 16:43:54.320+0900 I/SENSOR  ( 7067): 190.960007, 206.779999, 234.710007
05-26 16:43:54.425+0900 I/SENSOR  ( 7067): -30.730000, -126.559998, 14.070000
05-26 16:43:54.525+0900 I/SENSOR  ( 7067): -28.840000, 43.400002, 5.670000
05-26 16:43:54.625+0900 I/SENSOR  ( 7067): 27.790001, 8.260000, 4.480000
05-26 16:43:54.725+0900 I/SENSOR  ( 7067): 105.209999, -21.700001, 4.830000
05-26 16:43:54.825+0900 I/SENSOR  ( 7067): 10.150000, -70.000000, 15.820000
05-26 16:43:54.880+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 91 -> 90 1464248634 240
05-26 16:43:54.885+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 90 1333 265 2000
05-26 16:43:54.885+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 90 0 0 1753
05-26 16:43:54.885+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 90 1357 206 2036
05-26 16:43:54.885+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 90 1258 5 1887
05-26 16:43:54.885+0900 I/RESOURCED(  475): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 90 1090 9 1635
05-26 16:43:54.925+0900 I/SENSOR  ( 7067): -935.970032, -235.130005, 42.560001
05-26 16:43:55.030+0900 I/SENSOR  ( 7067): -570.220032, -115.919998, -97.650002
05-26 16:43:55.125+0900 I/SENSOR  ( 7067): -29.960001, -43.750000, 38.009998
05-26 16:43:55.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:55.205+0900 D/TIMER   ( 7067): Remind time: 581
05-26 16:43:55.205+0900 D/TIMER   ( 7067): Start clicked
05-26 16:43:55.255+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:55.255+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:55.255+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:55.255+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:55.255+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:55.260+0900 I/SENSOR  ( 7067): 814.450012, 132.440002, 67.340004
05-26 16:43:55.325+0900 I/SENSOR  ( 7067): 415.170013, 122.500000, 20.510000
05-26 16:43:55.425+0900 I/SENSOR  ( 7067): 84.070000, 66.430000, 11.130000
05-26 16:43:55.525+0900 I/SENSOR  ( 7067): -21.490000, 69.440002, 3.220000
05-26 16:43:55.625+0900 I/SENSOR  ( 7067): 65.309998, 19.460001, 12.460000
05-26 16:43:55.730+0900 I/SENSOR  ( 7067): 18.200001, -48.230000, 12.670000
05-26 16:43:55.830+0900 I/SENSOR  ( 7067): -1867.949951, -338.869995, -208.880005
05-26 16:43:55.830+0900 I/SENSOR  ( 7067): 앞으로 
05-26 16:43:55.835+0900 I/SOCKETTEST( 7067): Success to create socket
05-26 16:43:55.855+0900 I/SOCKETTEST( 7067): Success to socket connection
05-26 16:43:55.855+0900 I/SOCKETTEST( 7067): write() 성공
05-26 16:43:55.930+0900 I/SENSOR  ( 7067): 587.720032, 299.390015, 11.410000
05-26 16:43:56.030+0900 I/SENSOR  ( 7067): 946.049988, 204.680008, 46.130001
05-26 16:43:56.130+0900 I/SENSOR  ( 7067): 507.220001, 114.169998, 24.920000
05-26 16:43:56.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:56.205+0900 D/TIMER   ( 7067): Remind time: 580
05-26 16:43:56.230+0900 I/SENSOR  ( 7067): -79.449997, 53.410000, 24.920000
05-26 16:43:56.325+0900 I/SENSOR  ( 7067): -67.199997, -70.769997, 13.230000
05-26 16:43:56.430+0900 I/SENSOR  ( 7067): 25.900000, 23.590000, 0.280000
05-26 16:43:56.530+0900 I/SENSOR  ( 7067): 21.559999, 7.140000, 2.800000
05-26 16:43:56.630+0900 I/SENSOR  ( 7067): -9.450000, -11.200000, 4.340000
05-26 16:43:56.730+0900 I/SENSOR  ( 7067): 9.380000, -1.820000, 3.640000
05-26 16:43:56.830+0900 I/SENSOR  ( 7067): -82.180000, -60.619999, -8.960000
05-26 16:43:56.930+0900 I/SENSOR  ( 7067): -316.540009, -187.809998, -37.799999
05-26 16:43:56.995+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:56.995+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:57.000+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:57.000+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:57.000+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:57.025+0900 I/SENSOR  ( 7067): -1373.680054, -157.710007, -150.779999
05-26 16:43:57.025+0900 I/SENSOR  ( 7067): 앞으로 
05-26 16:43:57.025+0900 I/SOCKETTEST( 7067): Success to create socket
05-26 16:43:57.045+0900 I/SOCKETTEST( 7067): Success to socket connection
05-26 16:43:57.045+0900 I/SOCKETTEST( 7067): write() 성공
05-26 16:43:57.130+0900 I/SENSOR  ( 7067): -142.449997, -99.889999, 18.969999
05-26 16:43:57.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:57.205+0900 D/TIMER   ( 7067): Remind time: 579
05-26 16:43:57.230+0900 I/SENSOR  ( 7067): 892.640015, 132.089996, 81.129997
05-26 16:43:57.330+0900 I/SENSOR  ( 7067): 508.760010, 139.860001, 12.810000
05-26 16:43:57.430+0900 I/SENSOR  ( 7067): 34.930000, 28.980000, -6.300000
05-26 16:43:57.530+0900 I/SENSOR  ( 7067): -7.700000, -2.520000, 4.830000
05-26 16:43:57.635+0900 I/SENSOR  ( 7067): -58.170002, -26.670000, -1.330000
05-26 16:43:57.730+0900 I/SENSOR  ( 7067): -312.480011, -91.840004, -27.160000
05-26 16:43:57.830+0900 I/SENSOR  ( 7067): -1375.290039, -174.020004, -59.779999
05-26 16:43:57.830+0900 I/SENSOR  ( 7067): 앞으로 
05-26 16:43:57.830+0900 I/SOCKETTEST( 7067): Success to create socket
05-26 16:43:57.845+0900 I/SOCKETTEST( 7067): Success to socket connection
05-26 16:43:57.845+0900 I/SOCKETTEST( 7067): write() 성공
05-26 16:43:57.930+0900 I/SENSOR  ( 7067): -67.550003, 70.209999, 26.460001
05-26 16:43:58.030+0900 I/SENSOR  ( 7067): 263.899994, 75.949997, 30.170000
05-26 16:43:58.095+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:58.095+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:58.095+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:58.095+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:58.095+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:58.130+0900 I/SENSOR  ( 7067): 707.070007, 77.209999, 10.290000
05-26 16:43:58.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:58.205+0900 D/TIMER   ( 7067): Remind time: 578
05-26 16:43:58.225+0900 I/SENSOR  ( 7067): -55.790001, -65.099998, 15.890000
05-26 16:43:58.330+0900 I/SENSOR  ( 7067): 27.860001, -57.680000, 9.380000
05-26 16:43:58.430+0900 I/SENSOR  ( 7067): 31.570000, 42.490002, -15.330000
05-26 16:43:58.530+0900 I/SENSOR  ( 7067): 103.320000, 254.029999, -57.330002
05-26 16:43:58.630+0900 I/SENSOR  ( 7067): 192.500000, 271.250000, -93.379997
05-26 16:43:58.735+0900 I/SENSOR  ( 7067): 126.419998, 100.590004, -53.689999
05-26 16:43:58.845+0900 I/SENSOR  ( 7067): 87.989998, -50.119999, -74.620003
05-26 16:43:58.920+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:58.920+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:58.920+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:58.920+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:58.920+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:58.925+0900 I/SENSOR  ( 7067): 218.470001, -59.920002, -15.890000
05-26 16:43:59.030+0900 I/SENSOR  ( 7067): 185.289993, 3.010000, 116.410004
05-26 16:43:59.075+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 16:43:59.075+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 16:43:59.075+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 16:43:59.075+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 16:43:59.075+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:59.075+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:59.075+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:59.075+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:59.075+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:59.125+0900 I/SENSOR  ( 7067): 79.239998, 89.110001, 239.050003
05-26 16:43:59.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:43:59.205+0900 D/TIMER   ( 7067): Remind time: 577
05-26 16:43:59.225+0900 I/SENSOR  ( 7067): -69.720001, 128.309998, 95.550003
05-26 16:43:59.330+0900 I/SENSOR  ( 7067): 51.029999, -64.820000, -91.489998
05-26 16:43:59.435+0900 I/SENSOR  ( 7067): 140.210007, -5.670000, -135.449997
05-26 16:43:59.530+0900 I/SENSOR  ( 7067): 55.650002, -39.270000, -69.790001
05-26 16:43:59.550+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:43:59.550+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:43:59.550+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:43:59.550+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:43:59.550+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:43:59.555+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124343304[0;m
05-26 16:43:59.555+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-26 16:43:59.555+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-26 16:43:59.560+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-26 16:43:59.630+0900 I/SENSOR  ( 7067): 28.000000, -21.139999, -15.750000
05-26 16:43:59.735+0900 I/SENSOR  ( 7067): -55.369999, -18.340000, 30.870001
05-26 16:43:59.830+0900 I/SENSOR  ( 7067): -65.379997, -13.440001, 33.320000
05-26 16:43:59.930+0900 I/SENSOR  ( 7067): -19.670000, -8.890000, -35.279999
05-26 16:44:00.035+0900 I/SENSOR  ( 7067): -5.670000, 1.120000, -5.390000
05-26 16:44:00.135+0900 I/SENSOR  ( 7067): 17.710001, -12.390000, 7.420000
05-26 16:44:00.205+0900 D/TIMER   ( 7067): Timer is start
05-26 16:44:00.205+0900 D/TIMER   ( 7067): Remind time: 576
05-26 16:44:00.245+0900 I/SENSOR  ( 7067): 1.190000, 4.760000, -2.380000
05-26 16:44:00.330+0900 I/SENSOR  ( 7067): -0.840000, -3.780000, 4.550000
05-26 16:44:00.440+0900 I/SENSOR  ( 7067): 3.150000, -2.450000, 3.150000
05-26 16:44:00.540+0900 I/SENSOR  ( 7067): 3.990000, -2.380000, 2.660000
05-26 16:44:00.575+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-26 16:44:00.575+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-26 16:44:00.575+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : pedometer_inactive_period error
05-26 16:44:00.575+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 16:44:00.575+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 16:44:00.575+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_10min_precaution_millisec error
05-26 16:44:00.575+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-26 16:44:00.575+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-26 16:44:00.575+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1056): preference.c: preference_get_double(1214) > preference_get_double(1056) : inactive_before_10min_precaution_millisec error
05-26 16:44:00.635+0900 I/SENSOR  ( 7067): -6.650000, 4.690000, 9.380000
05-26 16:44:00.680+0900 E/EFL     ( 7067): evas_main<7067> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=1541317 button=1 downs=1
05-26 16:44:00.705+0900 E/EFL     ( 7067): evas_main<7067> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1541342 button=1 downs=0
05-26 16:44:00.705+0900 D/TIMER   ( 7067): Start clicked
05-26 16:44:00.720+0900 I/SOCKETTEST( 7067): Success to create socket
05-26 16:44:00.730+0900 I/SOCKETTEST( 7067): Success to socket connection
05-26 16:44:00.730+0900 I/SOCKETTEST( 7067): write() 성공
05-26 16:44:00.970+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 16:44:04.385+0900 I/efl-extension( 7067): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c066d8
05-26 16:44:04.385+0900 I/efl-extension( 7067): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c066d8, obj: 0x44c066d8
05-26 16:44:04.385+0900 I/efl-extension( 7067): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-26 16:44:04.385+0900 I/efl-extension( 7067): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-26 16:44:04.385+0900 I/efl-extension( 7067): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-26 16:44:04.385+0900 I/efl-extension( 7067): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-26 16:44:04.840+0900 I/CAPI_APPFW_APPLICATION( 7067): app_main.c: ui_app_exit(715) > ui_app_exit
05-26 16:44:04.840+0900 I/CAPI_APPFW_APPLICATION( 7067): app_main.c: app_efl_exit(145) > app_efl_exit
05-26 16:44:04.845+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 22
05-26 16:44:04.845+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(890) > app status : 4
05-26 16:44:05.030+0900 I/APP_CORE( 7067): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-26 16:44:05.030+0900 I/APP_CORE( 7067): appcore-efl.c: __after_loop(1090) > [APP 7067] PAUSE before termination
05-26 16:44:05.030+0900 I/CAPI_APPFW_APPLICATION( 7067): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-26 16:44:05.045+0900 I/CAPI_APPFW_APPLICATION( 7067): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-26 16:44:05.065+0900 W/AUL_AMD (  474): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-26 16:44:05.065+0900 W/AUL_AMD (  474): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-26 16:44:05.105+0900 I/MALI    ( 7067): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f4f010] swap changed from sync to async
05-26 16:44:05.135+0900 I/MALI    ( 7067): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-26 16:44:05.135+0900 I/MALI    ( 7067): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=7067   close drm_fd=25 
05-26 16:44:05.135+0900 I/MALI    ( 7067): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-26 16:44:05.180+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-26 16:44:05.180+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-26 16:44:05.180+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-26 16:44:05.180+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:44:05.180+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:44:05.180+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:44:05.185+0900 W/W_HOME  (  726): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-26 16:44:05.185+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.185+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.185+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.185+0900 W/W_HOME  (  726): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-26 16:44:05.195+0900 I/UXT     ( 7067): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-26 16:44:05.215+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-26 16:44:05.215+0900 W/W_HOME  (  726): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-26 16:44:05.215+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.215+0900 W/W_HOME  (  726): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-26 16:44:05.215+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: RESUME State: PAUSED
05-26 16:44:05.215+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-26 16:44:05.215+0900 W/W_HOME  (  726): main.c: _appcore_resume_cb(681) > appcore resume
05-26 16:44:05.215+0900 W/W_HOME  (  726): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-26 16:44:05.215+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.215+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.215+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.215+0900 W/APPS    (  726): apps_main.c: _time_changed_cb(295) >  date : 26->26
05-26 16:44:05.220+0900 W/W_HOME  (  726): rotary.c: rotary_attach(138) > rotary_attach:0x478904a8
05-26 16:44:05.240+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x478904a8, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-26 16:44:05.240+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 16:44:05.240+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-26 16:44:05.240+0900 I/WATCH_CORE(  752): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-26 16:44:05.245+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-26 16:44:05.245+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 16:44:05.245+0900 W/wnotib  (  726): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-26 16:44:05.245+0900 I/CAPI_WATCH_APPLICATION(  752): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-26 16:44:05.245+0900 E/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(740) > 
05-26 16:44:05.245+0900 I/watchface-loader(  752): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-26 16:44:05.245+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 16:44:05.245+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 16:44:05.245+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 16:44:05.245+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 16:44:05.270+0900 W/WATCH_CORE(  752): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-26 16:44:05.275+0900 W/W_HOME  (  726): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-26 16:44:05.275+0900 W/W_HOME  (  726): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-26 16:44:05.275+0900 W/W_HOME  (  726): gesture.c: _manual_render_enable(133) > 1
05-26 16:44:05.275+0900 W/W_HOME  (  726): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-26 16:44:05.275+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.275+0900 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
05-26 16:44:05.275+0900 W/STARTER (  696): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-26 16:44:05.275+0900 E/STARTER (  696): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-26 16:44:05.275+0900 W/STARTER (  696): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-26 16:44:05.275+0900 W/STARTER (  696): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-26 16:44:05.285+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-26 16:44:05.285+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-26 16:44:05.285+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-26 16:44:05.285+0900 I/TIZEN_N_SOUND_MANAGER( 1090): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-26 16:44:05.295+0900 I/TIZEN_N_SOUND_MANAGER( 1090): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-26 16:44:05.295+0900 W/TIZEN_N_SOUND_MANAGER( 1090): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-26 16:44:05.295+0900 W/WAKEUP-SERVICE( 1090): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-26 16:44:05.295+0900 I/HIGEAR  ( 1090): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-26 16:44:05.450+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1445]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-26 16:44:05.450+0900 I/SHealth_Common( 1056): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-26 16:44:05.450+0900 I/SHealth_Service( 1056): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-26 16:44:05.465+0900 I/APP_CORE(  726): appcore-efl.c: __do_app(429) > [APP 726] Event: PAUSE State: RUNNING
05-26 16:44:05.465+0900 I/CAPI_APPFW_APPLICATION(  726): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-26 16:44:05.465+0900 W/W_HOME  (  726): main.c: _appcore_pause_cb(690) > appcore pause
05-26 16:44:05.465+0900 W/W_HOME  (  726): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-26 16:44:05.465+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.465+0900 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
05-26 16:44:05.465+0900 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-26 16:44:05.465+0900 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-26 16:44:05.465+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.465+0900 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-26 16:44:05.465+0900 W/W_HOME  (  726): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-26 16:44:05.465+0900 W/W_HOME  (  726): rotary.c: rotary_deattach(156) > rotary_deattach:0x478904a8
05-26 16:44:05.465+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-26 16:44:05.465+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x478904a8, elm_layout, func : 0x4004b469
05-26 16:44:05.465+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-26 16:44:05.465+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-26 16:44:05.465+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-26 16:44:05.465+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x478904a8, activated : 1
05-26 16:44:05.465+0900 I/efl-extension(  726): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-26 16:44:05.465+0900 E/wnotib  (  726): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-26 16:44:05.465+0900 I/wnotib  (  726): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 31, 101.
05-26 16:44:05.465+0900 I/wnotib  (  726): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-26 16:44:05.480+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-26 16:44:05.480+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-26 16:44:05.480+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-26 16:44:05.495+0900 E/ALARM_MANAGER(  696): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(26-5-2016, 16:44:26), repeat(1), interval(20), type(-1073741822)
05-26 16:44:05.510+0900 W/ALARM_MANAGER(  470): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-26 16:44:05.510+0900 W/ALARM_MANAGER(  470): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-26 16:44:05.575+0900 W/APPS    (  726): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
05-26 16:44:05.615+0900 E/CAPI_APPFW_APP_CONTROL( 1445): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-26 16:44:05.615+0900 W/MUSIC_CONTROL_SERVICE( 1445): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1445]   [com.samsung.w-home]register msg port [false][0m
05-26 16:44:05.615+0900 E/ALARM_MANAGER(  470): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 62673079, next duetime: 1464248666
05-26 16:44:05.615+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(62673079)
05-26 16:44:05.615+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464249016), due_time(1464248666)
05-26 16:44:05.615+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-26 16:44:05.615+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 26-5-2016, 07:44:26 (UTC).
05-26 16:44:05.615+0900 E/ALARM_MANAGER(  470): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-26 16:44:05.850+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(646) > __request_handler: 23
05-26 16:44:05.850+0900 W/AUL_AMD (  474): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
05-26 16:44:05.850+0900 W/AUL_AMD (  474): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 7067
05-26 16:44:05.850+0900 W/AUL_AMD (  474): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-26 16:44:05.855+0900 W/CRASH_MANAGER( 7305): worker.c: worker_job(1199) > 1107067706831146424864
