S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 8039
Date: 2016-05-28 21:10:33+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x404a0250, r3   = 0x00000000
r4   = 0x45440428, r5   = 0x00000000
r6   = 0x45440d28, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x4543f6a8
r10  = 0x440518f0, fp   = 0x00000000
ip   = 0x4008d490, sp   = 0xbe9bc638
lr   = 0x403e91e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     12180 KB
Buffers:     37028 KB
Cached:     154396 KB
VmPeak:     115500 KB
VmSize:      99244 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21672 KB
VmRSS:       21636 KB
VmData:      43608 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8039 TID = 8039
8039 8046 8049 8193 

Maps Information
40000000 40007000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
4000f000 40010000 rwxp /opt/usr/apps/org.example.ph1/bin/ph1
40010000 4002d000 r-xp /lib/ld-2.13.so
40034000 40035000 r-xp /lib/ld-2.13.so
40035000 40036000 rwxp /lib/ld-2.13.so
40036000 4003a000 r-xp /usr/lib/libsys-assert.so
40042000 40043000 rwxp /usr/lib/libsys-assert.so
40058000 4006c000 r-xp /lib/libpthread-2.13.so
40073000 40074000 r-xp /lib/libpthread-2.13.so
40074000 40075000 rwxp /lib/libpthread-2.13.so
40077000 40079000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40081000 40082000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40082000 40086000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4008d000 4008e000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4008e000 40096000 r-xp /usr/lib/libcapi-appfw-preference.so.0.3.2.5
4009d000 4009e000 rwxp /usr/lib/libcapi-appfw-preference.so.0.3.2.5
4009e000 400ab000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
400b2000 400b3000 rwxp /usr/lib/libcapi-network-connection.so.1.0.51
400b3000 400b8000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
400bf000 400c0000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
400c0000 400c4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
400cc000 400cd000 rwxp /usr/lib/libcapi-system-sensor.so.0.1.18
400cd000 400d5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
400d5000 400d6000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
400d6000 400d8000 r-xp /usr/lib/libdlog.so.0.0.0
400df000 400e0000 rwxp /usr/lib/libdlog.so.0.0.0
400e0000 400f7000 r-xp /usr/lib/libecore.so.1.7.99
400ff000 40100000 rwxp /usr/lib/libecore.so.1.7.99
4010e000 4012f000 r-xp /usr/lib/libefl-extension.so.0.1.0
40136000 40137000 rwxp /usr/lib/libefl-extension.so.0.1.0
40137000 40271000 r-xp /usr/lib/libelementary.so.1.7.99
40278000 40280000 rwxp /usr/lib/libelementary.so.1.7.99
40287000 40355000 r-xp /usr/lib/libevas.so.1.7.99
4035d000 40367000 rwxp /usr/lib/libevas.so.1.7.99
4037a000 40495000 r-xp /lib/libc-2.13.so
4049d000 4049f000 r-xp /lib/libc-2.13.so
4049f000 404a0000 rwxp /lib/libc-2.13.so
404a3000 404ae000 r-xp /lib/libunwind.so.8.0.1
404b5000 404b6000 rwxp /lib/libunwind.so.8.0.1
404db000 404dd000 r-xp /lib/libdl-2.13.so
404e4000 404e5000 r-xp /lib/libdl-2.13.so
404e5000 404e6000 rwxp /lib/libdl-2.13.so
404e6000 404ee000 r-xp /lib/libgcc_s-4.6.so.1
404ee000 404ef000 rwxp /lib/libgcc_s-4.6.so.1
404ef000 404fb000 r-xp /usr/lib/libaul.so.0.1.0
40503000 40504000 rwxp /usr/lib/libaul.so.0.1.0
40505000 40527000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4052e000 4052f000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
4052f000 40533000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4053b000 4053c000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4053c000 40541000 r-xp /usr/lib/libappcore-efl.so.1.1
40548000 40549000 rwxp /usr/lib/libappcore-efl.so.1.1
40549000 4054e000 r-xp /usr/lib/libappcore-common.so.1.1
40555000 40556000 rwxp /usr/lib/libappcore-common.so.1.1
40556000 40597000 r-xp /usr/lib/libeina.so.1.7.99
4059e000 405a0000 rwxp /usr/lib/libeina.so.1.7.99
405a0000 40670000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40670000 40671000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
40671000 40675000 r-xp /usr/lib/libvconf.so.0.2.45
4067c000 4067d000 rwxp /usr/lib/libvconf.so.0.2.45
4067d000 40694000 r-xp /usr/lib/libnetwork.so.0.0.0
4069b000 4069c000 rwxp /usr/lib/libnetwork.so.0.0.0
4069c000 406a1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
406a8000 406a9000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
406a9000 4077c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40783000 40787000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
40787000 407bb000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
407c2000 407c4000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
407c4000 407e2000 r-xp /usr/lib/libsensor.so.1.1.0
407ea000 407eb000 rwxp /usr/lib/libsensor.so.1.1.0
407ec000 40880000 r-xp /usr/lib/libstdc++.so.6.0.16
40888000 4088b000 r-xp /usr/lib/libstdc++.so.6.0.16
4088b000 4088d000 rwxp /usr/lib/libstdc++.so.6.0.16
40893000 408fc000 r-xp /lib/libm-2.13.so
40903000 40904000 r-xp /lib/libm-2.13.so
40904000 40905000 rwxp /lib/libm-2.13.so
40905000 40955000 r-xp /usr/lib/libecore_x.so.1.7.99
40955000 40957000 rwxp /usr/lib/libecore_x.so.1.7.99
40957000 40979000 r-xp /usr/lib/libecore_evas.so.1.7.99
40980000 40982000 rwxp /usr/lib/libecore_evas.so.1.7.99
40982000 409aa000 r-xp /usr/lib/libfontconfig.so.1.8.0
409aa000 409ab000 rwxp /usr/lib/libfontconfig.so.1.8.0
409ab000 40a77000 r-xp /usr/lib/libxml2.so.2.7.8
40a7e000 40a83000 rwxp /usr/lib/libxml2.so.2.7.8
40a84000 40a96000 r-xp /usr/lib/libefl-assist.so.0.1.0
40a9d000 40a9e000 rwxp /usr/lib/libefl-assist.so.0.1.0
40a9e000 40aa4000 r-xp /lib/librt-2.13.so
40aab000 40aac000 r-xp /lib/librt-2.13.so
40aac000 40aad000 rwxp /lib/librt-2.13.so
40aad000 40b0a000 r-xp /usr/lib/libedje.so.1.7.99
40b12000 40b14000 rwxp /usr/lib/libedje.so.1.7.99
40b14000 40bcc000 r-xp /usr/lib/libcairo.so.2.11200.14
40bd3000 40bd6000 rwxp /usr/lib/libcairo.so.2.11200.14
40bd7000 40cb8000 r-xp /usr/lib/libX11.so.6.3.0
40cbf000 40cc3000 rwxp /usr/lib/libX11.so.6.3.0
40cc3000 40ccc000 r-xp /usr/lib/libXi.so.6.1.0
40cd3000 40cd4000 rwxp /usr/lib/libXi.so.6.1.0
40cd4000 40ced000 r-xp /usr/lib/libeet.so.1.7.99
40cf5000 40cf6000 rwxp /usr/lib/libeet.so.1.7.99
40cfe000 40d03000 r-xp /usr/lib/libecore_file.so.1.7.99
40d0a000 40d0b000 rwxp /usr/lib/libecore_file.so.1.7.99
40d0b000 40d1c000 r-xp /usr/lib/libecore_input.so.1.7.99
40d23000 40d24000 rwxp /usr/lib/libecore_input.so.1.7.99
40d24000 40d2d000 r-xp /usr/lib/libedbus.so.1.7.99
40d34000 40d35000 rwxp /usr/lib/libedbus.so.1.7.99
40d35000 40d5f000 r-xp /usr/lib/libdbus-1.so.3.8.12
40d67000 40d68000 rwxp /usr/lib/libdbus-1.so.3.8.12
40d68000 40d82000 r-xp /usr/lib/libecore_con.so.1.7.99
40d89000 40d8a000 rwxp /usr/lib/libecore_con.so.1.7.99
40d8b000 40d9e000 r-xp /usr/lib/libfribidi.so.0.3.1
40da5000 40da6000 rwxp /usr/lib/libfribidi.so.0.3.1
40da6000 40de3000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40dea000 40deb000 rwxp /usr/lib/libharfbuzz.so.0.940.0
40dec000 40e42000 r-xp /usr/lib/libfreetype.so.6.11.3
40e4a000 40e4e000 rwxp /usr/lib/libfreetype.so.6.11.3
40e4e000 40ea4000 r-xp /usr/lib/libpixman-1.so.0.28.2
40eac000 40eb1000 rwxp /usr/lib/libpixman-1.so.0.28.2
40eb1000 40eb4000 r-xp /usr/lib/libbundle.so.0.1.22
40ebb000 40ebc000 rwxp /usr/lib/libbundle.so.0.1.22
40ebc000 40ed3000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40eda000 40edb000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
40edb000 40ee0000 r-xp /usr/lib/libxdgmime.so.1.1.0
40ee7000 40ee8000 rwxp /usr/lib/libxdgmime.so.1.1.0
40ee8000 40f24000 r-xp /usr/lib/libsystemd.so.0.4.0
40f2b000 40f2c000 r-xp /usr/lib/libsystemd.so.0.4.0
40f2c000 40f2d000 rwxp /usr/lib/libsystemd.so.0.4.0
40f2d000 40f30000 r-xp /usr/lib/libproc-stat.so.0.2.86
40f37000 40f38000 rwxp /usr/lib/libproc-stat.so.0.2.86
40f38000 40f4e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40f55000 40f56000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
40f56000 40fcb000 r-xp /usr/lib/libsqlite3.so.0.8.6
40fd2000 40fd5000 rwxp /usr/lib/libsqlite3.so.0.8.6
40fd5000 40fdb000 r-xp /usr/lib/libappsvc.so.0.1.0
40fe2000 40fe3000 rwxp /usr/lib/libappsvc.so.0.1.0
40fe3000 40fe9000 r-xp /usr/lib/libecore_imf.so.1.7.99
40ff0000 40ff1000 rwxp /usr/lib/libecore_imf.so.1.7.99
40ff1000 40ff3000 r-xp /usr/lib/libiniparser.so.0
40ffb000 40ffc000 rwxp /usr/lib/libiniparser.so.0
40ffc000 4102d000 r-xp /usr/lib/libmdm.so.1.1.85
41034000 41035000 rwxp /usr/lib/libmdm.so.1.1.85
41035000 41036000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4103d000 4103e000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
4103e000 41043000 r-xp /usr/lib/libffi.so.5.0.10
4104a000 4104b000 rwxp /usr/lib/libffi.so.5.0.10
4104b000 4104d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41054000 41055000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
41055000 4106b000 r-xp /lib/libz.so.1.2.5
41072000 41073000 rwxp /lib/libz.so.1.2.5
41073000 41083000 r-xp /lib/libresolv-2.13.so
41083000 41084000 r-xp /lib/libresolv-2.13.so
41084000 41085000 rwxp /lib/libresolv-2.13.so
41087000 4108e000 r-xp /usr/lib/libsensord-share.so
41095000 41096000 rwxp /usr/lib/libsensord-share.so
41096000 4109d000 r-xp /usr/lib/libXcursor.so.1.0.2
410a4000 410a5000 rwxp /usr/lib/libXcursor.so.1.0.2
410a5000 410a7000 r-xp /usr/lib/libXdamage.so.1.1.0
410ae000 410af000 rwxp /usr/lib/libXdamage.so.1.1.0
410af000 410b1000 r-xp /usr/lib/libXcomposite.so.1.0.0
410b8000 410b9000 rwxp /usr/lib/libXcomposite.so.1.0.0
410b9000 410bb000 r-xp /usr/lib/libXgesture.so.7.0.0
410c2000 410c3000 rwxp /usr/lib/libXgesture.so.7.0.0
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
43758000 4376c000 rwxp [stack:8046]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44383000 44b82000 rwxp [stack:8193]
453c8000 453cb000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
453cb000 453cf000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
453cf000 453de000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
453e6000 453ed000 r-xs /usr/lib/gconv/gconv-modules.cache
455af000 45dae000 rwxp [stack:8049]
4649f000 464a2000 r-xp /usr/lib/libpulse-simple.so.0.0.4
464a9000 464aa000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46515000 4654d000 r-xp /usr/lib/libpulse.so.0.16.2
4654d000 4654e000 rwxp /usr/lib/libpulse.so.0.16.2
465c2000 465c7000 r-xp /usr/lib/libjson.so.0.0.1
465ce000 465cf000 rwxp /usr/lib/libjson.so.0.0.1
465cf000 46617000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46617000 46618000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46618000 4665b000 r-xp /usr/lib/libsndfile.so.1.0.25
46662000 46664000 rwxp /usr/lib/libsndfile.so.1.0.25
46668000 4668a000 r-xp /usr/lib/libvorbis.so.0.4.3
46691000 46692000 rwxp /usr/lib/libvorbis.so.0.4.3
46692000 46696000 r-xp /usr/lib/libogg.so.0.7.1
4669d000 4669e000 rwxp /usr/lib/libogg.so.0.7.1
be99c000 be9bd000 rwxp [stack]
End of Maps Information

Callstack Information (PID:8039)
Call Stack Count: 2
 0: cfree + 0xc8 (0x403e91e8) [/lib/libc.so.6] + 0x6f1e8
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
hface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:08:44.123+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:08:44.123+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:08:44.123+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:08:44.123+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:08:44.123+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:08:44.823+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:08:44.823+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:08:44.823+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:08:44.823+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:08:44.823+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:08:47.063+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:08:47.063+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:08:47.063+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:08:47.063+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:08:47.063+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:08:49.068+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:08:49.068+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:08:49.068+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:08:49.068+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:08:49.068+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:08:50.153+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:08:50.153+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:08:50.153+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:08:50.153+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:08:50.153+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:08:50.898+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:08:50.898+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:08:50.898+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:08:50.898+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:08:50.898+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:08:53.753+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:08:53.753+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:08:53.753+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:08:53.753+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:08:53.753+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:08:56.033+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:08:56.033+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:08:56.038+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:08:56.038+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:08:56.038+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:00.848+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 28->28
05-28 21:09:01.448+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:01.448+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:01.453+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:01.453+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:01.453+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:01.513+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-28 21:09:01.513+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-28 21:09:01.513+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-28 21:09:01.513+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:09:01.513+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:09:01.518+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-28 21:09:01.518+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:09:01.518+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:09:01.518+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-28 21:09:04.383+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-28 21:09:04.563+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:04.563+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:04.563+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:04.563+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:04.563+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:06.168+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-28 21:09:06.168+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-28 21:09:07.243+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:07.243+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:07.243+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:07.243+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:07.243+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:09.158+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:09.158+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:09.158+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:09.158+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:09.158+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:10.493+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:10.493+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:10.493+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:10.493+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:10.493+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:11.873+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:11.873+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:11.873+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:11.873+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:11.873+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:29.793+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:29.793+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:29.793+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:29.793+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:29.793+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:30.278+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:30.278+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:30.278+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:30.283+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:30.283+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:31.263+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:31.263+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:09:31.268+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:31.273+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:31.303+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:31.303+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:31.318+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:09:31.363+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:09:31.363+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:09:37.073+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:37.073+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:37.073+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:37.073+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:37.073+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:38.353+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:38.353+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:38.358+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:38.358+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:38.358+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:39.598+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:09:39.598+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:09:39.598+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:09:39.598+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:09:39.598+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:09:48.163+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-28 21:09:48.168+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-28 21:09:48.168+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(356766629)
05-28 21:09:48.168+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-28 21:09:48.168+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 28-5-2016, 15:00:00 (UTC).
05-28 21:09:48.168+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-28 21:09:48.168+0900 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[356766629] is removed.
05-28 21:09:48.193+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-28 21:09:48.198+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-28 21:09:48.228+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.253+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.273+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.298+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.298+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-28 21:09:48.303+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-28 21:09:48.323+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.338+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.338+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464437392, Sat May 28 21:09:52 2016
05-28 21:09:48.338+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1485613597, next duetime: 1464437392
05-28 21:09:48.343+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1485613597)
05-28 21:09:48.343+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464447600), due_time(1464437392)
05-28 21:09:48.343+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-28 21:09:48.343+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 28-5-2016, 12:09:52 (UTC).
05-28 21:09:48.343+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-28 21:09:48.348+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-28 21:09:48.348+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-28 21:09:48.348+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1485613597)
05-28 21:09:48.348+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-28 21:09:48.348+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 28-5-2016, 15:00:00 (UTC).
05-28 21:09:48.348+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-28 21:09:48.348+0900 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1485613597] is removed.
05-28 21:09:48.358+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-28 21:09:48.363+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-28 21:09:48.373+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.388+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.398+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.408+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.408+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-28 21:09:48.413+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-28 21:09:48.423+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.433+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
05-28 21:09:48.433+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464440988, Sat May 28 22:09:48 2016
05-28 21:09:48.433+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1485613597, next duetime: 1464440988
05-28 21:09:48.433+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1485613597)
05-28 21:09:48.438+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464447600), due_time(1464440988)
05-28 21:09:48.438+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-28 21:09:48.438+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 28-5-2016, 13:09:48 (UTC).
05-28 21:09:48.438+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-28 21:10:00.878+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 28->28
05-28 21:10:01.533+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:01.533+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:01.533+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:01.533+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:01.533+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:01.543+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-28 21:10:01.548+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-28 21:10:01.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-28 21:10:01.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:10:01.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:10:01.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-28 21:10:01.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:10:01.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:10:01.553+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-28 21:10:04.383+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-28 21:10:06.168+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-28 21:10:06.168+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-28 21:10:06.608+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:06.608+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:06.608+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:06.608+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:06.608+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:11.688+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:11.688+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:11.693+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:11.693+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:11.693+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:14.378+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:14.378+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:14.378+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:14.378+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:14.378+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:24.788+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:24.788+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:24.788+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:24.788+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:24.788+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:25.948+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:25.948+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:25.948+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:25.948+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:25.948+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:26.563+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:26.563+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:26.563+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:26.563+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:26.568+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:27.083+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:27.083+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:27.083+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:27.083+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:27.083+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:27.703+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:27.708+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:10:27.713+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:27.718+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:27.728+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:27.728+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:27.743+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:10:27.798+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:10:27.798+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:10:28.413+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:28.413+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:28.413+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:28.413+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:28.413+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:29.393+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:10:29.393+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:10:29.393+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:29.393+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:29.393+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:31.583+0900 E/WMS     (  484): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20197) > wear_monitor_status update[0] = 1 -> 2
05-28 21:10:31.593+0900 E/WMS     (  484): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-28 21:10:31.593+0900 E/WMS     (  484): ==========
05-28 21:10:31.593+0900 E/WMS     (  484): ##WMS SEND : mgr_gear_wear_onoff_req
05-28 21:10:31.593+0900 E/WMS     (  484): ==========
05-28 21:10:31.593+0900 E/WMS     (  484): wms_msg_broker.c: wms_msg_broker_send(1746) > No service connection to host. Skipping this message.
05-28 21:10:32.598+0900 E/PKGMGR_SERVER( 8851): pkgmgr-server.c: main(2131) > package manager server start
05-28 21:10:32.683+0900 E/PKGMGR_SERVER( 8851): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_-386576718], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[Y+qEI15ero7Xj6ITtReRW/dAfsM=], backend_flag=[0]
05-28 21:10:32.693+0900 E/PKGMGR_SERVER( 8853): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-28 21:10:32.693+0900 E/PKGMGR  ( 8845): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-28 21:10:32.763+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:10:32.773+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8039
05-28 21:10:32.773+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-28 21:10:32.778+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 5
05-28 21:10:32.783+0900 I/APP_CORE( 8039): appcore-efl.c: __do_app(429) > [APP 8039] Event: TERMINATE State: RUNNING
05-28 21:10:32.783+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(8039), cmd(4)
05-28 21:10:32.783+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-28 21:10:32.783+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-28 21:10:32.783+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:10:32.793+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8039
05-28 21:10:32.853+0900 I/APP_CORE( 8039): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-28 21:10:32.853+0900 I/CAPI_APPFW_APPLICATION( 8039): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-28 21:10:32.868+0900 I/efl-extension( 8039): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-28 21:10:32.868+0900 I/efl-extension( 8039): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45f2b418 is freed
05-28 21:10:32.868+0900 I/efl-extension( 8039): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-28 21:10:32.873+0900 I/efl-extension( 8039): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44005f48 is freed
05-28 21:10:32.873+0900 I/efl-extension( 8039): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45f99fe8 is freed
05-28 21:10:32.873+0900 I/efl-extension( 8039): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x454c10f8 is freed
05-28 21:10:32.873+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-28 21:10:32.873+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-28 21:10:32.883+0900 I/MALI    ( 8039): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f5f020] swap changed from sync to async
05-28 21:10:32.903+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:10:32.913+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8039
05-28 21:10:32.918+0900 I/MALI    ( 8039): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-28 21:10:32.918+0900 I/MALI    ( 8039): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=8039   close drm_fd=25 
05-28 21:10:32.918+0900 I/MALI    ( 8039): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-28 21:10:32.938+0900 W/PROCESSMGR(  382): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-28 21:10:32.938+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-28 21:10:32.938+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:10:32.938+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:10:32.938+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:10:32.938+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-28 21:10:32.938+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-28 21:10:32.938+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-28 21:10:32.943+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:10:32.943+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:10:32.943+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:10:32.968+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-28 21:10:32.968+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-28 21:10:32.968+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:10:32.968+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-28 21:10:32.968+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
05-28 21:10:32.968+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-28 21:10:32.968+0900 W/W_HOME  (  714): main.c: _appcore_resume_cb(681) > appcore resume
05-28 21:10:32.968+0900 W/W_HOME  (  714): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-28 21:10:32.968+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:10:32.968+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:10:32.968+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:10:32.968+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 28->28
05-28 21:10:32.973+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x45d34090
05-28 21:10:32.973+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d34090, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-28 21:10:32.973+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-28 21:10:32.983+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-28 21:10:32.983+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-28 21:10:32.983+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-28 21:10:32.983+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-28 21:10:32.983+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-28 21:10:32.983+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-28 21:10:32.983+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-28 21:10:33.013+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:10:33.023+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8039
05-28 21:10:33.043+0900 I/UXT     ( 8039): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-28 21:10:33.128+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:10:33.138+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8039
05-28 21:10:33.238+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:10:33.263+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8039
05-28 21:10:33.303+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 47 -> 46 1464437433 212
05-28 21:10:33.303+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 1042 475 799
05-28 21:10:33.303+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 0 0 1241
05-28 21:10:33.303+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 700 252 537
05-28 21:10:33.303+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 158 5 121
05-28 21:10:33.303+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 899 11 689
05-28 21:10:33.323+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 46 -> 46 1464437433 0
05-28 21:10:33.328+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 1042 475 799
05-28 21:10:33.328+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 0 0 1241
05-28 21:10:33.328+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 700 252 537
05-28 21:10:33.328+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 170 5 130
05-28 21:10:33.328+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 842 12 646
05-28 21:10:33.338+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 46 98 146 88
05-28 21:10:33.338+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 46 0 0 66
05-28 21:10:33.343+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 46 107 63 96
05-28 21:10:33.343+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 46 110 5 99
05-28 21:10:33.343+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 46 92 27 83
05-28 21:10:33.398+0900 I/AUL_AMD (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-28 21:10:33.413+0900 I/AUL_AMD (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-28 21:10:33.413+0900 E/AUL_AMD (  487): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-28 21:10:33.413+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 487
05-28 21:10:33.438+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-28 21:10:33.443+0900 W/AUL_AMD (  487): amd_launch.c: start_process(580) > child process: 8864
05-28 21:10:33.493+0900 W/AUL_AMD (  487): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 8864
05-28 21:10:33.513+0900 I/AUL_AMD (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-28 21:10:33.523+0900 I/AUL_AMD (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
05-28 21:10:33.523+0900 E/AUL_AMD (  487): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-28 21:10:33.523+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 487
05-28 21:10:33.533+0900 W/AUL_AMD (  487): amd_launch.c: start_process(580) > child process: 8865
05-28 21:10:33.563+0900 E/RESOURCED(  488): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > [resourced_dbus_system_hash_drop_busname,324] Does not exist in busname hash: :1.430
05-28 21:10:33.578+0900 E/RESOURCED(  488): proc-main.c: proc_add_app_list(272) > [proc_add_app_list,272] not found previous pai : com.samsung.w-gallery.consumer
05-28 21:10:33.578+0900 E/RESOURCED(  488): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-gallery
05-28 21:10:33.588+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-28 21:10:33.588+0900 W/W_HOME  (  714): dbox.c: _dbus_rotation_cb(1302) > invalid angle, skipped:0
05-28 21:10:33.638+0900 W/AUL_AMD (  487): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 8865
05-28 21:10:33.643+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:10:33.648+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8039
05-28 21:10:33.728+0900 W/W_INDICATOR(  685): windicator_battery.c: _charging_ui_update(72) > [_charging_ui_update:72] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
05-28 21:10:33.753+0900 W/W_INDICATOR(  685): windicator_battery.c: _charging_ui_update(76) > [_charging_ui_update:76] [SHOW charging icon] Connected / not Full / not charge -1
05-28 21:10:33.753+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:10:33.763+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-28 21:10:33.768+0900 E/PKGMGR_SERVER( 8853): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-28 21:10:33.788+0900 E/RESOURCED(  488): proc-main.c: proc_add_app_list(272) > [proc_add_app_list,272] not found previous pai : com.samsung.w-music-transfer.consumer
05-28 21:10:33.833+0900 E/PKGMGR_SERVER( 8851): pkgmgr-server.c: sighandler(409) > child NORMAL exit [8853]
05-28 21:10:33.853+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 23
05-28 21:10:33.853+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-28 21:10:33.853+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 8039
05-28 21:10:33.853+0900 W/AUL_AMD (  487): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-28 21:10:33.853+0900 E/AUL     ( 8872): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-28 21:10:33.883+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8039
05-28 21:10:33.883+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
05-28 21:10:33.883+0900 W/W_HOME  (  714): dbox.c: _dbus_rotation_cb(1299) > angle changed:90
05-28 21:10:33.963+0900 W/CRASH_MANAGER( 8870): worker.c: worker_job(1199) > 1108039706831146443743
