S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 3686
Date: 2016-05-12 16:55:00+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3686, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000009
r2   = 0x0000000a, r3   = 0x00000000
r4   = 0x400ee9c0, r5   = 0x4048e4b8
r6   = 0x400ee16c, r7   = 0x00000000
r8   = 0x434422e4, r9   = 0x42ecadd0
r10  = 0x400fcb18, fp   = 0x00000000
ip   = 0x4048e4b8, sp   = 0xbed25280
lr   = 0x4039c08c, pc   = 0x4039c1f4
cpsr = 0x80000010

Memory Information
MemTotal:   491012 KB
MemFree:     14908 KB
Buffers:     27520 KB
Cached:     121840 KB
VmPeak:     113444 KB
VmSize:     105728 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23116 KB
VmRSS:       23116 KB
VmData:      44696 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       55224 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3686 TID = 3686
3686 3692 3693 3696 3831 

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
43748000 4374b000 rwxp [stack:3693]
4374b000 4374f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43756000 43757000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43757000 4375b000 rwxs /dev/mali
4375c000 4375f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43766000 43767000 rwxp /usr/lib/libnative-buffer.so.0.1.0
43768000 43f67000 rwxp [stack:3692]
43f67000 43f6f000 rwxs /dev/mali
43f6f000 43f77000 rwxs /dev/mali
43f77000 43f7b000 rwxs /dev/mali
43f7b000 43f8b000 rwxs /dev/mali
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
44b72000 44bb2000 rwxs /dev/mali
44bb2000 44bb3000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44bba000 44bbb000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44bbb000 44bbc000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44bc3000 44bc4000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44bc4000 44bd4000 rwxs /dev/mali
44bd4000 44bd8000 rwxs /dev/mali
44bd9000 44be0000 r-xp /usr/lib/libfeedback.so.0.1.4
44be8000 44be9000 rwxp /usr/lib/libfeedback.so.0.1.4
44be9000 44bed000 rwxs /dev/mali
44bed000 44bf1000 rwxs /dev/mali
44bf1000 44bf4000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44bf4000 44bf8000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44bfc000 44c00000 rwxs /dev/mali
44d01000 45500000 rwxp [stack:3831]
45500000 45540000 rwxs /dev/mali
45540000 45580000 rwxs /dev/mali
45580000 45583000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4558a000 4558b000 rwxp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45590000 455b4000 rwxs /dev/mali
455b4000 455d8000 rwxs /dev/mali
455d8000 455dc000 rwxs /dev/mali
455dc000 45600000 rwxs /dev/mali
45600000 45604000 rwxs /dev/mali
45608000 45617000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
45617000 456a2000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
456a3000 45ea2000 rwxp [stack:3696]
45ea2000 45ee2000 rwxs /dev/mali
45ee2000 45f6e000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
45f6e000 45ff6000 rwxs /dev/mali
45ff6000 45ff7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45ffe000 45fff000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
45fff000 46001000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
46008000 46009000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
46009000 46013000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
4601a000 4601b000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.49
4601b000 46022000 r-xp /usr/lib/libmmfcommon.so.0.0.0
46029000 4602a000 rwxp /usr/lib/libmmfcommon.so.0.0.0
4602a000 4602d000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46034000 46035000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46236000 46237000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
4623e000 4623f000 rwxp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
4623f000 46353000 rwxs /dev/mali
46353000 46369000 r-xp /usr/lib/libmmfsound.so.0.1.0
46371000 46372000 rwxp /usr/lib/libmmfsound.so.0.1.0
4637b000 46380000 r-xp /usr/lib/libmmfsession.so.0.0.0
46387000 46388000 rwxp /usr/lib/libmmfsession.so.0.0.0
46388000 46392000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4639a000 4639b000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
4639e000 463a2000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
463aa000 463ab000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
463ab000 463c1000 r-xp /usr/lib/libavsysaudio.so.0.0.1
463c9000 463ca000 rwxp /usr/lib/libavsysaudio.so.0.0.1
463ca000 463cf000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
463d6000 463d7000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
463d7000 463da000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
463e1000 463e2000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
463e2000 463ef000 r-xp /usr/lib/libail.so.0.1.0
463f7000 463f8000 rwxp /usr/lib/libail.so.0.1.0
463f8000 46400000 rwxs /dev/mali
46500000 46561000 r-xp /usr/lib/libasound.so.2.0.0
46568000 4656b000 rwxp /usr/lib/libasound.so.2.0.0
4656b000 46573000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
4657a000 4657b000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
46588000 465c8000 rwxs /dev/mali
465c8000 465f4000 rwxs /dev/mali
465f4000 4662c000 r-xp /usr/lib/libpulse.so.0.16.2
4662c000 4662d000 rwxp /usr/lib/libpulse.so.0.16.2
4662d000 4663d000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
4663d000 46641000 rwxp /usr/lib/lib_SamsungRec_TizenV04014.so
4665e000 46661000 r-xp /usr/lib/libcompress.so.0.2.0
46668000 46669000 rwxp /usr/lib/libcompress.so.0.2.0
46669000 4666e000 r-xp /usr/lib/libjson.so.0.0.1
46675000 46676000 rwxp /usr/lib/libjson.so.0.0.1
46676000 466be000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
466be000 466bf000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
466bf000 46702000 r-xp /usr/lib/libsndfile.so.1.0.25
46709000 4670b000 rwxp /usr/lib/libsndfile.so.1.0.25
4670f000 46731000 r-xp /usr/lib/libvorbis.so.0.4.3
46738000 46739000 rwxp /usr/lib/libvorbis.so.0.4.3
46739000 4673d000 r-xp /usr/lib/libogg.so.0.7.1
46744000 46745000 rwxp /usr/lib/libogg.so.0.7.1
46745000 4678d000 rwxs /dev/mali
4678d000 467d5000 rwxs /dev/mali
467d5000 4681d000 rwxs /dev/mali
4681d000 46865000 rwxs /dev/mali
46865000 468ad000 rwxs /dev/mali
468ad000 468bd000 rwxs /dev/mali
468bd000 468e1000 rwxs /dev/mali
468e1000 468e9000 rwxs /dev/mali
468e9000 468f9000 rwxs /dev/mali
468f9000 4691d000 rwxs /dev/mali
4691d000 46957000 r-xs /opt/usr/apps/org.example.ph1/res/edje/timer.edj
46957000 469df000 rwxs /dev/mali
469df000 46a67000 rwxs /dev/mali
46a67000 46aef000 rwxs /dev/mali
46aef000 46b13000 rwxs /dev/mali
46b13000 46b23000 rwxs /dev/mali
bed05000 bed26000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3686)
Call Stack Count: 1
 0: (0x4039c1f4) [/lib/libc.so.6] + 0x331f4
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
d-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1556) > Handle this change type in idler.
05-12 16:54:39.143+0900 I/wnotib  (  732): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1561) > Home is background. Postpone the board update.
05-12 16:54:39.188+0900 I/SENSOR  ( 3686): -0.140000, -3.990000, 3.220000
05-12 16:54:39.228+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 32768
05-12 16:54:39.228+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [32768 / 32768] bytes
05-12 16:54:39.283+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 28852
05-12 16:54:39.283+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [28852 / 28852] bytes
05-12 16:54:39.288+0900 I/SENSOR  ( 3686): -1.470000, -3.710000, 3.640000
05-12 16:54:39.338+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 32768
05-12 16:54:39.338+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [32768 / 32768] bytes
05-12 16:54:39.373+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 28852
05-12 16:54:39.378+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [28852 / 28852] bytes
05-12 16:54:39.388+0900 I/SENSOR  ( 3686): -2.310000, -3.290000, 5.110000
05-12 16:54:39.423+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 32768
05-12 16:54:39.423+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [32768 / 32768] bytes
05-12 16:54:39.438+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 28852
05-12 16:54:39.438+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [28852 / 28852] bytes
05-12 16:54:39.488+0900 I/SENSOR  ( 3686): -1.120000, -3.780000, 3.780000
05-12 16:54:39.558+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x05)
05-12 16:54:39.558+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 5, crc_size: 4
05-12 16:54:39.558+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 9 bytes [9 / 9] 
05-12 16:54:39.563+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [11 / 11] bytes. 
05-12 16:54:39.593+0900 I/SENSOR  ( 3686): -0.910000, -3.500000, 4.200000
05-12 16:54:39.688+0900 I/SENSOR  ( 3686): 0.770000, -2.940000, 3.430000
05-12 16:54:39.798+0900 I/SENSOR  ( 3686): -2.240000, -3.290000, 3.780000
05-12 16:54:39.898+0900 I/SENSOR  ( 3686): -1.610000, -4.270000, 5.040000
05-12 16:54:39.998+0900 I/SENSOR  ( 3686): -0.210000, -2.870000, 3.430000
05-12 16:54:39.998+0900 D/TIMER   ( 3686): Timer is start
05-12 16:54:39.998+0900 D/TIMER   ( 3686): Remind time: 172
05-12 16:54:40.003+0900 D/TIMER   ( 3686): Start clicked
05-12 16:54:40.013+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 11
05-12 16:54:40.013+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [11 / 11] bytes
05-12 16:54:40.103+0900 I/SENSOR  ( 3686): -0.910000, -4.480000, 4.130000
05-12 16:54:40.188+0900 I/SENSOR  ( 3686): 1.750000, -6.160000, 0.700000
05-12 16:54:40.293+0900 I/SENSOR  ( 3686): 17.639999, -4.060000, -6.510000
05-12 16:54:40.398+0900 I/SENSOR  ( 3686): 24.360001, -15.750000, -18.270000
05-12 16:54:40.493+0900 I/SENSOR  ( 3686): 16.240000, -9.870000, -14.070000
05-12 16:54:40.593+0900 I/SENSOR  ( 3686): 7.140000, -6.930000, -3.010000
05-12 16:54:40.708+0900 I/SENSOR  ( 3686): 0.490000, -5.110000, 3.640000
05-12 16:54:40.798+0900 I/SENSOR  ( 3686): -4.970000, 0.350000, 7.700000
05-12 16:54:40.893+0900 I/SENSOR  ( 3686): 3.220000, -2.870000, 0.280000
05-12 16:54:40.993+0900 I/SENSOR  ( 3686): 4.410000, -16.450001, -9.030000
05-12 16:54:40.993+0900 D/TIMER   ( 3686): Timer is start
05-12 16:54:40.993+0900 D/TIMER   ( 3686): Remind time: 171
05-12 16:54:41.098+0900 I/SENSOR  ( 3686): -28.980000, 1.470000, 22.400000
05-12 16:54:41.098+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3292291 button=1 downs=1
05-12 16:54:41.138+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3292330 button=1 downs=0
05-12 16:54:41.138+0900 D/TIMER   ( 3686): Start clicked
05-12 16:54:41.153+0900 I/SOCKETTEST( 3686): Success to create socket
05-12 16:54:41.568+0900 I/SOCKETTEST( 3686): Success to socket connection
05-12 16:54:41.568+0900 I/SOCKETTEST( 3686): write() 성공
05-12 16:54:42.918+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3294108 button=1 downs=1
05-12 16:54:42.918+0900 D/TIMER   ( 3686): Minute selected
05-12 16:54:42.928+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3294119 button=1 downs=0
05-12 16:54:43.353+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.353+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.353+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.358+0900 I/efl-extension( 3686): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.358+0900 I/efl-extension( 3686): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4426db98, elm_layout, time_stamp : 3294546
05-12 16:54:43.358+0900 D/TIMER   ( 3686): Rotary callback is called
05-12 16:54:43.358+0900 D/TIMER   ( 3686): Detent detected, obj[0x4426db98], direction[0], time_stamp[3294546]
05-12 16:54:43.358+0900 D/TIMER   ( 3686): Pre change num: 00
05-12 16:54:43.358+0900 D/TIMER   ( 3686): Post change num: 0
05-12 16:54:43.443+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.448+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.448+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.448+0900 I/efl-extension( 3686): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.448+0900 I/efl-extension( 3686): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4426db98, elm_layout, time_stamp : 3294637
05-12 16:54:43.448+0900 D/TIMER   ( 3686): Rotary callback is called
05-12 16:54:43.448+0900 D/TIMER   ( 3686): Detent detected, obj[0x4426db98], direction[0], time_stamp[3294637]
05-12 16:54:43.448+0900 D/TIMER   ( 3686): Pre change num: 1
05-12 16:54:43.448+0900 D/TIMER   ( 3686): Post change num: 1
05-12 16:54:43.558+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.558+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.558+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.558+0900 I/efl-extension( 3686): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:43.558+0900 I/efl-extension( 3686): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4426db98, elm_layout, time_stamp : 3294751
05-12 16:54:43.558+0900 D/TIMER   ( 3686): Rotary callback is called
05-12 16:54:43.558+0900 D/TIMER   ( 3686): Detent detected, obj[0x4426db98], direction[0], time_stamp[3294751]
05-12 16:54:43.558+0900 D/TIMER   ( 3686): Pre change num: 2
05-12 16:54:43.558+0900 D/TIMER   ( 3686): Post change num: 2
05-12 16:54:44.028+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 32768
05-12 16:54:44.033+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [32768 / 32768] bytes
05-12 16:54:44.103+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3295294 button=1 downs=1
05-12 16:54:44.123+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3295316 button=1 downs=0
05-12 16:54:44.133+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 28852
05-12 16:54:44.133+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [28852 / 28852] bytes
05-12 16:54:44.148+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 32768
05-12 16:54:44.148+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [32768 / 32768] bytes
05-12 16:54:44.158+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 28852
05-12 16:54:44.158+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [28852 / 28852] bytes
05-12 16:54:44.168+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 32768
05-12 16:54:44.168+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [32768 / 32768] bytes
05-12 16:54:44.193+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 28852
05-12 16:54:44.193+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [28852 / 28852] bytes
05-12 16:54:44.228+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 32768
05-12 16:54:44.228+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [32768 / 32768] bytes
05-12 16:54:44.283+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 28852
05-12 16:54:44.283+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [28852 / 28852] bytes
05-12 16:54:44.328+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 32768
05-12 16:54:44.328+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [32768 / 32768] bytes
05-12 16:54:44.353+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 28852
05-12 16:54:44.358+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [28852 / 28852] bytes
05-12 16:54:45.058+0900 E/SHealth_Common( 1035): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-12 16:54:45.708+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x05)
05-12 16:54:45.708+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 5, crc_size: 4
05-12 16:54:45.708+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 9 bytes [9 / 9] 
05-12 16:54:45.723+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [11 / 11] bytes. 
05-12 16:54:46.338+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3297526 button=1 downs=1
05-12 16:54:46.393+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3297584 button=1 downs=0
05-12 16:54:46.393+0900 D/TIMER   ( 3686): Start clicked
05-12 16:54:46.393+0900 D/TIMER   ( 3686): Setting time is 180
05-12 16:54:46.403+0900 I/SENSOR  ( 3686): Sensor is Started
05-12 16:54:46.403+0900 I/SOCKETTEST( 3686): Success to create socket
05-12 16:54:46.418+0900 I/SOCKETTEST( 3686): Success to socket connection
05-12 16:54:46.418+0900 I/SOCKETTEST( 3686): write() 성공
05-12 16:54:46.418+0900 D/TIMER   ( 3686): Start clicked
05-12 16:54:46.498+0900 I/SENSOR  ( 3686): -15.680000, 11.200000, 9.730000
05-12 16:54:46.603+0900 I/SENSOR  ( 3686): -9.660000, 6.860000, 18.969999
05-12 16:54:46.703+0900 I/SENSOR  ( 3686): -23.590000, 7.770000, 27.650000
05-12 16:54:46.798+0900 I/SENSOR  ( 3686): -11.410000, -0.980000, 7.560000
05-12 16:54:46.903+0900 I/SENSOR  ( 3686): -1.400000, -0.280000, -1.120000
05-12 16:54:47.003+0900 I/SENSOR  ( 3686): -3.080000, -2.870000, 6.720000
05-12 16:54:47.098+0900 I/SENSOR  ( 3686): -0.910000, -2.170000, 5.810000
05-12 16:54:47.198+0900 I/SENSOR  ( 3686): 0.070000, -3.290000, 2.730000
05-12 16:54:47.303+0900 I/SENSOR  ( 3686): 0.420000, -4.970000, 5.180000
05-12 16:54:47.408+0900 I/SENSOR  ( 3686): 0.420000, -2.520000, 5.880000
05-12 16:54:47.423+0900 D/TIMER   ( 3686): Timer is start
05-12 16:54:47.423+0900 D/TIMER   ( 3686): Remind time: 180
05-12 16:54:47.498+0900 I/SENSOR  ( 3686): -0.280000, -5.460000, 2.520000
05-12 16:54:47.598+0900 I/SENSOR  ( 3686): 11.060000, -9.800000, -9.590000
05-12 16:54:47.708+0900 I/SENSOR  ( 3686): 20.440001, -18.059999, -14.700000
05-12 16:54:47.803+0900 I/SENSOR  ( 3686): 26.389999, -14.630000, -14.630000
05-12 16:54:47.898+0900 I/SENSOR  ( 3686): 34.509998, -10.150000, -19.040001
05-12 16:54:47.953+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: d_c_s_l - con_candidate seq( 2 )
05-12 16:54:47.953+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: d_c_s_l - con_candidate seq( 2 ), connid( 875643717 )
05-12 16:54:47.953+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: scs_dis-connid( 875643717 ), peer( 1075324260 )
05-12 16:54:47.968+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3299158 button=1 downs=1
05-12 16:54:47.973+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: sc_dis connid( 875643717 ), way( 4)
05-12 16:54:47.973+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: sc_dis .
05-12 16:54:47.973+0900 W/SNL     ( 2503): Scone_Log.cpp: dump(2972) > SNL :: scs_dis-res
05-12 16:54:47.998+0900 I/SENSOR  ( 3686): -8.890000, -3.780000, 22.400000
05-12 16:54:48.003+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3299196 button=1 downs=0
05-12 16:54:48.003+0900 D/TIMER   ( 3686): Start clicked
05-12 16:54:48.023+0900 I/SOCKETTEST( 3686): Success to create socket
05-12 16:54:48.433+0900 I/SOCKETTEST( 3686): Success to socket connection
05-12 16:54:48.438+0900 I/SOCKETTEST( 3686): write() 성공
05-12 16:54:49.853+0900 W/SCSD    ( 2503): <_data_cb:507>  - length: 9094
05-12 16:54:49.853+0900 W/SCSD    ( 2503): <sap_socket_send:137> sent [9094 / 9094] bytes
05-12 16:54:50.008+0900 E/wnoti-service(  849): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(625173)
05-12 16:54:50.008+0900 E/wnoti-service(  849): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
05-12 16:54:50.018+0900 E/wnoti-service(  849): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-12 16:54:50.018+0900 E/wnoti-service(  849): wnoti-db-utility.c: logging_image(1685) > [89][50][4e][47]
05-12 16:54:50.023+0900 E/wnoti-service(  849): wnoti-db-utility.c: logging_image(1685) > [89][50][4e][47]
05-12 16:54:50.023+0900 E/wnoti-service(  849): wnoti-db-server.c: insert_asset(3797) > [Replace] content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1676
05-12 16:54:50.053+0900 E/wnoti-service(  849): wnoti-db-utility.c: logging_image(1685) > [89][50][4e][47]
05-12 16:54:50.053+0900 E/wnoti-service(  849): wnoti-db-server.c: insert_asset(3792) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1687
05-12 16:54:50.068+0900 E/wnoti-service(  849): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1687
05-12 16:54:50.073+0900 E/wnoti-service(  849): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
05-12 16:54:50.073+0900 E/wnoti-service(  849): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 143
05-12 16:54:50.073+0900 E/wnoti-service(  849): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1676
05-12 16:54:50.073+0900 E/wnoti-service(  849): wnoti-db-server.c: check_asset_images(3945) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/1687
05-12 16:54:50.453+0900 E/wnoti-service(  849): wnoti-db-server.c: check_asset_images(3976) > summary_bg_image : /opt/usr/data/wnoti/.crop_201.png
05-12 16:54:50.463+0900 E/wnoti-service(  849): wnoti-db-server.c: wnoti_is_check_notification_update(4453) > 1002/0
05-12 16:54:50.463+0900 E/wnoti-service(  849): wnoti-sap-client.c: _add_exception_handling(581) > type : 1002, application_id : 218
05-12 16:54:50.468+0900 E/wnoti-service(  849): wnoti-sap-client.c: publish_received_noti(1848) > 1002, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229584, noti_flag : 528, g_span_version : 1
05-12 16:54:50.468+0900 E/wnoti-service(  849): wnoti-db-utility.c: lock_pm(519) > >> lock_pm status : 2
05-12 16:54:50.468+0900 E/wnoti-service(  849): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 1
05-12 16:54:50.468+0900 E/wnoti-service(  849): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 1
05-12 16:54:51.463+0900 W/SCSD    ( 2503): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x05)
05-12 16:54:51.463+0900 W/SCSD    ( 2503): <on_sap_socket_recv:30>  - remain length: 5, crc_size: 4
05-12 16:54:51.463+0900 W/SCSD    ( 2503): <on_sap_socket_recv:62>  - recv 9 bytes [9 / 9] 
05-12 16:54:51.473+0900 W/SCSD    ( 2503): <util_scs_send:975> sent [11 / 11] bytes. 
05-12 16:54:51.853+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3303045 button=1 downs=1
05-12 16:54:51.853+0900 D/TIMER   ( 3686): Minute selected
05-12 16:54:51.888+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3303081 button=1 downs=0
05-12 16:54:51.973+0900 E/wnoti-service(  849): wnoti-sap-client.c: _get_latest_notification_card(1700) > id : 2331, status : 0
05-12 16:54:52.003+0900 I/wnoti-service(  849): wnoti-sap-client.c: launch_alert_view(398) > timer_id : 0, emergency_cb_mode : 0, blocking_mode : 0 
05-12 16:54:52.003+0900 E/wnoti-service(  849): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 1
05-12 16:54:52.003+0900 I/wnoti-service(  849): wnoti-msg-builder.c: _publish_notification(1394) > operation_type : 0, source : 0, application_id : 0, display_count : 0
05-12 16:54:52.018+0900 E/wnoti-proxy(  732): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 732, caller_id : 0, listener_type : 0
05-12 16:54:52.018+0900 W/wnotib  (  732): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1501) > Change type : 0, op_type: 0, category_id: 0, display count: 0
05-12 16:54:52.018+0900 I/wnotib  (  732): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1556) > Handle this change type in idler.
05-12 16:54:52.018+0900 I/wnotib  (  732): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1561) > Home is background. Postpone the board update.
05-12 16:54:52.018+0900 E/wnoti-proxy( 2461): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2461, caller_id : 0, listener_type : 0
05-12 16:54:52.018+0900 I/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1502) > Handle this change type in idler.
05-12 16:54:52.023+0900 E/wnoti-service(  849): wnoti-sap-client.c: on_timer(291) > is_exist_alert_list : 0, g_launch_popup_time : 1463039692, g_use_aul_launch : 0
05-12 16:54:52.023+0900 E/wnoti-service(  849): wnoti-sap-client.c: on_timer(293) > >> launching notification popup
05-12 16:54:52.023+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 0
05-12 16:54:52.053+0900 I/AUL_AMD (  493): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-12 16:54:52.073+0900 I/AUL_AMD (  493): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
05-12 16:54:52.073+0900 E/AUL_AMD (  493): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-12 16:54:52.073+0900 W/AUL_AMD (  493): amd_launch.c: _start_app(1702) > caller pid : 849
05-12 16:54:52.088+0900 W/AUL_AMD (  493): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 2461
05-12 16:54:52.098+0900 I/APP_CORE( 2461): appcore-efl.c: __do_app(429) > [APP 2461] Event: RESET State: PAUSED
05-12 16:54:52.098+0900 I/CAPI_APPFW_APPLICATION( 2461): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-12 16:54:52.103+0900 W/AUL_AMD (  493): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(13), pid(2461), cmd(0)
05-12 16:54:52.143+0900 W/wnotibp ( 2461): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-12 16:54:52.148+0900 W/AUL_AMD (  493): amd_request.c: __request_handler(646) > __request_handler: 14
05-12 16:54:52.163+0900 W/AUL_AMD (  493): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-12 16:54:52.168+0900 I/wnotibp ( 2461): wnotiboard-popup-view.c: wnotiboard_popup_get_block_mode(2354) > Returning false.
05-12 16:54:52.178+0900 E/wnoti-service(  849): wnoti-db-client.c: wnoti_get_alert_categories(712) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 218, db_id : 2331, is_duplicated : 0
05-12 16:54:52.183+0900 E/wnoti-service(  849): wnoti-db-client.c: wnoti_get_alert_categories(851) > view_type : 1, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 0
05-12 16:54:52.208+0900 I/wnoti-proxy( 2461): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-12 16:54:52.208+0900 I/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_get_alert_list(813) > application_name: 카카오톡, application_id: 218, category_id: 119, time: 1463039677, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_218.jpg, icon_color: -5730296
05-12 16:54:52.208+0900 I/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_get_alert_list(820) > noti_type: 1
05-12 16:54:52.208+0900 W/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_convert_alert_data(77) > db_id = 2331, alert_type: 1, app_feedback_type: 0
05-12 16:54:52.208+0900 I/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_convert_alert_data(372) > Activity fetch finished: -1
05-12 16:54:52.208+0900 I/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_convert_alert_data(377) > activity action count: 1
05-12 16:54:52.208+0900 I/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_convert_alert_data(382) > 1 activities retrieved.
05-12 16:54:52.213+0900 I/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_convert_alert_data(473) > Page fetch finished: -1
05-12 16:54:52.213+0900 I/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_convert_alert_data(478) > wearable_page_cnt: 1
05-12 16:54:52.213+0900 I/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_convert_alert_data(483) > 1 pages retrieved.
05-12 16:54:52.213+0900 W/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 1, list count : 1
05-12 16:54:52.213+0900 W/wnotibp ( 2461): wnotiboard-popup.c: _wnotiboard_popup_app_control(1131) > ::DATA:: CHECK IN APP CONTROL : 1, 0, 1
05-12 16:54:52.213+0900 W/wnotibp ( 2461): wnotiboard-popup.c: _wnotiboard_popup_app_control(1143) > ::APP:: CHECK STATE : 2, 0, (null)
05-12 16:54:52.213+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-12 16:54:52.213+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-12 16:54:52.213+0900 W/wnotibp ( 2461): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(628) > [2331, 1, 1, 8, 0000]
05-12 16:54:52.213+0900 W/wnotibp ( 2461): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(629) > [0, 1, 0, 0]
05-12 16:54:52.213+0900 W/wnotibp ( 2461): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(630) > [1, 0, 0, 0]
05-12 16:54:52.213+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-12 16:54:52.213+0900 I/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4443) > wnotiboard_popup_vi_type: 2
05-12 16:54:52.213+0900 I/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4449) > (2331, 2331)
05-12 16:54:52.223+0900 I/efl-extension( 2461): efl_extension_circle_surface.c: eext_circle_surface_layout_add(1293) > Put the surface[0x4433e420]'s widget[0x46bea900] to layout widget[0x46bea180]
05-12 16:54:52.233+0900 I/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_create_genlist(4377) > (2331, 2331)
05-12 16:54:52.238+0900 I/efl-extension( 2461): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-12 16:54:52.263+0900 I/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_create_card_data(3979) > 0x451091c0, 0x45109040, 0x45109040
05-12 16:54:52.263+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-12 16:54:52.263+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-12 16:54:52.263+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-12 16:54:52.263+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-12 16:54:52.273+0900 E/E17     (  381): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05000008)
05-12 16:54:52.288+0900 I/APP_CORE( 2461): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-12 16:54:52.303+0900 W/wnotibp ( 2461): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2201) > Unhandled part: stack.separator
05-12 16:54:52.303+0900 I/wnotibp ( 2461): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-12 16:54:52.308+0900 I/wnotibp ( 2461): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-12 16:54:52.308+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-12 16:54:52.308+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-12 16:54:52.308+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-12 16:54:52.308+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-12 16:54:52.313+0900 E/E17     (  381): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x05000008)
05-12 16:54:52.338+0900 W/APP_CORE( 2461): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5000008
05-12 16:54:52.358+0900 E/EFL     ( 2461): evas_main<2461> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
05-12 16:54:52.358+0900 E/EFL     ( 2461): evas_main<2461> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
05-12 16:54:52.358+0900 E/EFL     ( 2461): evas_main<2461> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
05-12 16:54:52.358+0900 I/wnotibp ( 2461): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-12 16:54:52.358+0900 I/wnotibp ( 2461): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-12 16:54:52.358+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-12 16:54:52.358+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-12 16:54:52.358+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-12 16:54:52.358+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2461): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-12 16:54:52.393+0900 E/EFL     ( 2461): evas_main<2461> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x44346ab8 is not stable during recalc loop
05-12 16:54:52.393+0900 E/EFL     ( 2461): evas_main<2461> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x44346ab8 is not stable during recalc loop
05-12 16:54:52.413+0900 W/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3713) > ::UI:: VI TYPE : 2
05-12 16:54:52.413+0900 W/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3719) > alert_type : 1, is_source_companion: 1
05-12 16:54:52.413+0900 W/TIZEN_N_RECORDER( 2461): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
05-12 16:54:52.413+0900 W/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1272) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
05-12 16:54:52.413+0900 I/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1281) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
05-12 16:54:52.413+0900 W/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1315) > ::APP:: Determined feedback: sound 0, vibration: 0
05-12 16:54:52.413+0900 I/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1319) > No feedback.
05-12 16:54:52.418+0900 I/wnotibp ( 2461): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1037) > fully_obscured: 0 [0x5000008 0x500000a 0x5000008 ]
05-12 16:54:52.418+0900 I/APP_CORE( 2461): appcore-efl.c: __do_app(429) > [APP 2461] Event: RESUME State: RUNNING
05-12 16:54:52.418+0900 W/AUL_AMD (  493): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-12 16:54:52.418+0900 W/AUL_AMD (  493): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-12 16:54:52.453+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_view_lock(856) > ::UI:: [[[ ===> already [small popup] is LOCK, 0010 ]]]
05-12 16:54:52.453+0900 W/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_pre_cb(2194) > ::UI:: start showing animation
05-12 16:54:52.758+0900 W/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_cb(2104) > ::UI:: end show animation
05-12 16:54:52.758+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-12 16:54:52.758+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-12 16:54:52.768+0900 E/wnoti-service(  849): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
05-12 16:54:52.773+0900 E/wnoti-service(  849): wnoti-db-utility.c: set_pm_lock(503) > >> set_pm_lock status : 2
05-12 16:54:52.783+0900 E/wnoti-service(  849): wnoti-db-utility.c: unlock_pm(534) > >> unlock_pm status : 0
05-12 16:54:52.793+0900 E/wnoti-proxy( 2461): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
05-12 16:54:52.793+0900 E/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_get_alert_list(916) > ::DATA:: No categories available.
05-12 16:54:52.793+0900 W/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_get_alert_list(919) > ::DATA:: read alert list : 0, list count : 1
05-12 16:54:54.008+0900 E/wnoti-service(  849): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
05-12 16:54:54.068+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.068+0900 I/efl-extension( 3686): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.068+0900 I/efl-extension( 3686): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4426db98, elm_layout, time_stamp : 3305259
05-12 16:54:54.068+0900 D/TIMER   ( 3686): Rotary callback is called
05-12 16:54:54.068+0900 D/TIMER   ( 3686): Detent detected, obj[0x4426db98], direction[0], time_stamp[3305259]
05-12 16:54:54.068+0900 D/TIMER   ( 3686): Pre change num: 00
05-12 16:54:54.068+0900 D/TIMER   ( 3686): Post change num: 0
05-12 16:54:54.073+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.073+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.073+0900 I/MALI    ( 3686): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f4f010] swap changed from sync to async
05-12 16:54:54.123+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.123+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.123+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.123+0900 I/efl-extension( 3686): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.123+0900 I/efl-extension( 3686): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4426db98, elm_layout, time_stamp : 3305316
05-12 16:54:54.123+0900 D/TIMER   ( 3686): Rotary callback is called
05-12 16:54:54.123+0900 D/TIMER   ( 3686): Detent detected, obj[0x4426db98], direction[0], time_stamp[3305316]
05-12 16:54:54.123+0900 D/TIMER   ( 3686): Pre change num: 1
05-12 16:54:54.123+0900 D/TIMER   ( 3686): Post change num: 1
05-12 16:54:54.223+0900 I/efl-extension(  732): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.223+0900 I/efl-extension( 3589): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.223+0900 I/efl-extension( 2461): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.223+0900 I/efl-extension( 3686): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-12 16:54:54.223+0900 I/efl-extension( 3686): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4426db98, elm_layout, time_stamp : 3305415
05-12 16:54:54.223+0900 D/TIMER   ( 3686): Rotary callback is called
05-12 16:54:54.223+0900 D/TIMER   ( 3686): Detent detected, obj[0x4426db98], direction[0], time_stamp[3305415]
05-12 16:54:54.223+0900 D/TIMER   ( 3686): Pre change num: 2
05-12 16:54:54.223+0900 D/TIMER   ( 3686): Post change num: 2
05-12 16:54:55.263+0900 E/EFL     ( 2461): evas_main<2461> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3306450 button=1 downs=1
05-12 16:54:55.263+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_view_lock(859) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
05-12 16:54:55.263+0900 W/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_main_popup_timer_cb(2324) > ::UI:: start hiding animation
05-12 16:54:55.273+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), block(2)
05-12 16:54:55.273+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), ev->cur.canvas.x(194) ev->cur.canvas.y(110)
05-12 16:54:55.273+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), hold(0) freeze(0)
05-12 16:54:55.308+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), block(2)
05-12 16:54:55.308+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), ev->cur.canvas.x(194) ev->cur.canvas.y(130)
05-12 16:54:55.308+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), hold(0) freeze(0)
05-12 16:54:55.323+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), block(2)
05-12 16:54:55.323+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), ev->cur.canvas.x(194) ev->cur.canvas.y(132)
05-12 16:54:55.323+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), hold(0) freeze(0)
05-12 16:54:55.328+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), block(2)
05-12 16:54:55.328+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), ev->cur.canvas.x(196) ev->cur.canvas.y(152)
05-12 16:54:55.328+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), hold(0) freeze(0)
05-12 16:54:55.328+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:4250 _elm_scroll_mouse_move_event_cb() [DDO] animator
05-12 16:54:55.328+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3354 _elm_scroll_post_event_move() [DDO] obj(46966c10), type(elm_genlist)
05-12 16:54:55.328+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3355 _elm_scroll_post_event_move() [DDO] hold_parent(0)
05-12 16:54:55.338+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3618 _elm_scroll_hold_animator() [DDO] obj(46966c10), locked_x(0)
05-12 16:54:55.343+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), block(2)
05-12 16:54:55.343+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), ev->cur.canvas.x(196) ev->cur.canvas.y(167)
05-12 16:54:55.343+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(46966c10), hold(0) freeze(0)
05-12 16:54:55.343+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3354 _elm_scroll_post_event_move() [DDO] obj(46966c10), type(elm_genlist)
05-12 16:54:55.343+0900 E/EFL     ( 2461): elementary<2461> elm_interface_scrollable.c:3355 _elm_scroll_post_event_move() [DDO] hold_parent(0)
05-12 16:54:55.343+0900 E/EFL     ( 2461): evas_main<2461> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3306533 button=1 downs=0
05-12 16:54:55.573+0900 W/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_hide_animator_cb(2255) > ::UI:: end hiding animation
05-12 16:54:55.573+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
05-12 16:54:55.573+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-12 16:54:55.573+0900 W/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1904) > state : (8, 1, 0)
05-12 16:54:55.573+0900 I/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1917) > simple popup=0, view_state=0
05-12 16:54:55.573+0900 I/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_view_unlock(903) > ::UI:: it is invalid object.
05-12 16:54:55.573+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_view_unlock(909) > ::UI:: [[[ [invalid object] is UNLOCK , 0000 <=== ]]]
05-12 16:54:55.573+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_view_unlock(919) > ::DATA:: CHECK LIST : 1 1
05-12 16:54:55.573+0900 I/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(926) > ::DATA:: remove notification data, 2331
05-12 16:54:55.573+0900 I/wnotibp ( 2461): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(956) > ::DATA:: CHECK DATA : 0, 0
05-12 16:54:55.578+0900 I/efl-extension( 2461): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x46966c10, obj: 0x46966c10
05-12 16:54:55.578+0900 I/efl-extension( 2461): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-12 16:54:55.598+0900 I/efl-extension( 2461): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-12 16:54:55.598+0900 I/efl-extension( 2461): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46966c10, elm_genlist, func : 0x41a25dfd
05-12 16:54:55.598+0900 I/efl-extension( 2461): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-12 16:54:55.603+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-12 16:54:55.603+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(998) > ::UI:: lock state = 0000
05-12 16:54:55.608+0900 I/efl-extension( 2461): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-12 16:54:55.608+0900 I/wnotibp ( 2461): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4568) > Panel open state: 0 for 117, 218
05-12 16:54:55.608+0900 I/efl-extension( 2461): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
05-12 16:54:55.608+0900 I/wnotibp ( 2461): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(2024) > ::INFO:: call lower
05-12 16:54:55.613+0900 W/APP_CORE( 2461): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:5000008
05-12 16:54:55.613+0900 I/APP_CORE( 2461): appcore-efl.c: __do_app(429) > [APP 2461] Event: PAUSE State: RUNNING
05-12 16:54:55.613+0900 I/CAPI_APPFW_APPLICATION( 2461): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-12 16:54:55.683+0900 I/MALI    ( 3686): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42f4f010] swap changed from async to sync
05-12 16:54:55.698+0900 W/wnotibp ( 2461): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(268) > fg_app : 1
05-12 16:54:55.698+0900 W/wnotibp ( 2461): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(961) > ::UI:: lock state=0000
05-12 16:54:55.698+0900 W/wnotibp ( 2461): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [0, 0, 8, 0000]
05-12 16:54:55.698+0900 W/wnotibp ( 2461): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 0]
05-12 16:54:55.698+0900 W/wnotibp ( 2461): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1371) > [0, 1, 0, 2, 0]
05-12 16:54:55.768+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3306962 button=1 downs=1
05-12 16:54:55.843+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3307036 button=1 downs=0
05-12 16:54:56.013+0900 E/wnoti-service(  849): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
05-12 16:54:57.903+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3309093 button=1 downs=1
05-12 16:54:57.943+0900 E/EFL     ( 3686): evas_main<3686> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3309136 button=1 downs=0
05-12 16:54:57.943+0900 D/TIMER   ( 3686): Start clicked
05-12 16:54:57.943+0900 D/TIMER   ( 3686): Setting time is 180
05-12 16:54:57.953+0900 I/SENSOR  ( 3686): Sensor is Started
05-12 16:54:57.953+0900 I/SOCKETTEST( 3686): Success to create socket
05-12 16:54:57.958+0900 I/SOCKETTEST( 3686): Success to socket connection
05-12 16:54:57.963+0900 I/SOCKETTEST( 3686): write() 성공
05-12 16:54:57.963+0900 D/TIMER   ( 3686): Start clicked
05-12 16:54:58.008+0900 I/SENSOR  ( 3686): -24.430000, 8.400000, 29.049999
05-12 16:54:58.118+0900 I/SENSOR  ( 3686): -1.120000, 1.890000, 6.090000
05-12 16:54:58.218+0900 I/SENSOR  ( 3686): -8.540000, 1.750000, 20.580000
05-12 16:54:58.313+0900 I/SENSOR  ( 3686): -2.870000, 1.470000, 11.690000
05-12 16:54:58.408+0900 I/SENSOR  ( 3686): -14.280000, 3.010000, 23.030001
05-12 16:54:58.508+0900 I/SENSOR  ( 3686): -11.340000, 2.030000, -4.970000
05-12 16:54:58.613+0900 I/SENSOR  ( 3686): -3.780000, -5.880000, 10.360000
05-12 16:54:58.713+0900 I/SENSOR  ( 3686): -2.590000, -4.130000, 6.440000
05-12 16:54:58.813+0900 I/SENSOR  ( 3686): 2.800000, -8.190000, -7.000000
05-12 16:54:58.913+0900 I/SENSOR  ( 3686): 17.710001, -55.439999, -52.990002
05-12 16:54:58.963+0900 D/TIMER   ( 3686): Timer is start
05-12 16:54:58.963+0900 D/TIMER   ( 3686): Remind time: 180
05-12 16:54:59.018+0900 I/SENSOR  ( 3686): 17.710001, -36.680000, -30.520000
05-12 16:54:59.113+0900 I/SENSOR  ( 3686): -19.460001, 7.840000, 24.920000
05-12 16:54:59.213+0900 I/SENSOR  ( 3686): -5.390000, 1.470000, 4.340000
05-12 16:54:59.318+0900 I/SENSOR  ( 3686): -0.140000, 0.700000, 5.250000
05-12 16:54:59.413+0900 I/SENSOR  ( 3686): 12.040000, -8.750000, -19.879999
05-12 16:54:59.513+0900 I/SENSOR  ( 3686): 9.170000, -51.730000, -49.770000
05-12 16:54:59.613+0900 I/SENSOR  ( 3686): -4.760000, -43.540001, -25.620001
05-12 16:54:59.713+0900 I/SENSOR  ( 3686): -4.550000, 6.020000, 15.260000
05-12 16:54:59.843+0900 I/SENSOR  ( 3686): -17.920000, 52.220001, 114.870003
05-12 16:54:59.918+0900 I/SENSOR  ( 3686): -21.700001, 12.950000, 52.849998
05-12 16:54:59.973+0900 D/TIMER   ( 3686): Timer is start
05-12 16:54:59.973+0900 D/TIMER   ( 3686): Remind time: 179
05-12 16:55:00.013+0900 I/SENSOR  ( 3686): -5.810000, 5.600000, 17.150000
05-12 16:55:00.108+0900 I/SENSOR  ( 3686): 0.140000, -0.350000, 13.090000
05-12 16:55:00.233+0900 I/SENSOR  ( 3686): 6.510000, -7.980000, -1.890000
05-12 16:55:00.243+0900 I/efl-extension( 3686): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4426db98
05-12 16:55:00.243+0900 I/efl-extension( 3686): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4426db98, obj: 0x4426db98
05-12 16:55:00.243+0900 I/efl-extension( 3686): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-12 16:55:00.308+0900 I/SENSOR  ( 3686): -5.670000, -5.530000, 10.780000
05-12 16:55:00.413+0900 I/SENSOR  ( 3686): -5.320000, -4.830000, 3.640000
05-12 16:55:00.478+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-12 16:55:00.478+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-12 16:55:00.478+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : pedometer_inactive_period error
05-12 16:55:00.478+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 16:55:00.478+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 16:55:00.478+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_10min_precaution_millisec error
05-12 16:55:00.478+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-12 16:55:00.478+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-12 16:55:00.478+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1035): preference.c: preference_get_double(1214) > preference_get_double(1035) : inactive_before_10min_precaution_millisec error
05-12 16:55:00.513+0900 I/SENSOR  ( 3686): -5.530000, 0.560000, 10.920000
05-12 16:55:00.623+0900 I/SENSOR  ( 3686): -1.680000, 0.350000, 7.560000
05-12 16:55:00.713+0900 I/SENSOR  ( 3686): -1.890000, 3.920000, 10.850000
05-12 16:55:00.713+0900 I/APP_CORE( 2461): appcore-efl.c: __do_app(429) > [APP 2461] Event: MEM_FLUSH State: PAUSED
05-12 16:55:00.823+0900 I/SENSOR  ( 3686): -1.260000, 1.890000, 9.100000
05-12 16:55:00.923+0900 I/SENSOR  ( 3686): -3.080000, -3.850000, 3.710000
05-12 16:55:00.948+0900 W/APPS    (  732): apps_main.c: _time_changed_cb(295) >  date : 12->12
05-12 16:55:00.963+0900 D/TIMER   ( 3686): Timer is start
05-12 16:55:00.963+0900 D/TIMER   ( 3686): Remind time: 178
05-12 16:55:00.963+0900 F/EFL     ( 3686): evas_main<3686> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
05-12 16:55:01.483+0900 W/CRASH_MANAGER( 4004): worker.c: worker_job(1199) > 1103686706831146303970
