S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 10620
Date: 2016-05-28 21:33:18+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x404a0250, r3   = 0x00000000
r4   = 0x44c1cc68, r5   = 0x00000000
r6   = 0x44c1d568, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x44c1bee8
r10  = 0x44050870, fp   = 0x00000000
ip   = 0x4008d490, sp   = 0xbee20638
lr   = 0x403e91e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     28132 KB
Buffers:     39064 KB
Cached:     154908 KB
VmPeak:     113340 KB
VmSize:     100260 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22708 KB
VmRSS:       22708 KB
VmData:      44624 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10620 TID = 10620
10620 10627 10630 10705 

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
43758000 4376c000 rwxp [stack:10627]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44b82000 44b85000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b85000 44b89000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b89000 44b98000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44d50000 44d57000 r-xs /usr/lib/gconv/gconv-modules.cache
44d80000 4557f000 rwxp [stack:10705]
4560b000 45f0a000 rwxp [stack:10630]
466fb000 466fe000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46705000 46706000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46771000 467a9000 r-xp /usr/lib/libpulse.so.0.16.2
467a9000 467aa000 rwxp /usr/lib/libpulse.so.0.16.2
4681e000 46823000 r-xp /usr/lib/libjson.so.0.0.1
4682a000 4682b000 rwxp /usr/lib/libjson.so.0.0.1
4682b000 46873000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46873000 46874000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46874000 468b7000 r-xp /usr/lib/libsndfile.so.1.0.25
468be000 468c0000 rwxp /usr/lib/libsndfile.so.1.0.25
468c4000 468e6000 r-xp /usr/lib/libvorbis.so.0.4.3
468ed000 468ee000 rwxp /usr/lib/libvorbis.so.0.4.3
468ee000 468f2000 r-xp /usr/lib/libogg.so.0.7.1
468f9000 468fa000 rwxp /usr/lib/libogg.so.0.7.1
bee00000 bee21000 rwxp [stack]
End of Maps Information

Callstack Information (PID:10620)
Call Stack Count: 2
 0: cfree + 0xc8 (0x403e91e8) [/lib/libc.so.6] + 0x6f1e8
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
d(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:30:52.008+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:30:52.008+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:30:52.008+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:30:52.008+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:30:52.008+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:30:52.008+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:30:52.008+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:30:52.008+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:30:52.093+0900 I/SENSOR  (10620): -1438.780029, -199.500000, 73.010002
05-28 21:30:52.098+0900 I/SENSOR  (10620): 앞으로 
05-28 21:30:52.098+0900 I/SOCKETTEST(10620): Success to create socket
05-28 21:30:52.103+0900 I/SOCKETTEST(10620): Success to socket connection
05-28 21:30:52.103+0900 I/SOCKETTEST(10620): write() 성공
05-28 21:30:52.198+0900 I/SENSOR  (10620): 276.570007, -55.510002, 0.140000
05-28 21:30:52.248+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:30:52.248+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:30:52.248+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:30:52.248+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:30:52.248+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:30:52.298+0900 I/SENSOR  (10620): 81.340004, 8.470000, 28.350000
05-28 21:30:52.398+0900 I/SENSOR  (10620): 563.359985, 46.619999, -2.450000
05-28 21:30:52.498+0900 I/SENSOR  (10620): 724.640015, 18.690001, -103.320000
05-28 21:30:52.598+0900 I/SENSOR  (10620): -76.580002, -33.950001, -18.410000
05-28 21:30:52.698+0900 I/SENSOR  (10620): -719.599976, -90.580002, 50.189999
05-28 21:30:52.808+0900 I/SENSOR  (10620): -1084.300049, -74.410004, -5.600000
05-28 21:30:52.808+0900 I/SENSOR  (10620): 앞으로 
05-28 21:30:52.813+0900 I/SOCKETTEST(10620): Success to create socket
05-28 21:30:52.833+0900 I/SOCKETTEST(10620): Success to socket connection
05-28 21:30:52.838+0900 I/SOCKETTEST(10620): write() 성공
05-28 21:30:52.898+0900 I/SENSOR  (10620): 186.550003, 12.880000, 27.230000
05-28 21:30:53.003+0900 I/SENSOR  (10620): 579.950012, 41.090000, -4.270000
05-28 21:30:53.053+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:30:53.053+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:30:53.058+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:30:53.058+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:30:53.058+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:30:53.098+0900 I/SENSOR  (10620): 119.419998, 55.510002, -13.230000
05-28 21:30:53.198+0900 I/SENSOR  (10620): 461.720001, -8.540000, -73.709999
05-28 21:30:53.298+0900 I/SENSOR  (10620): 145.039993, 26.110001, -15.190001
05-28 21:30:53.398+0900 I/SENSOR  (10620): -136.080002, 10.430000, 24.780001
05-28 21:30:53.498+0900 I/SENSOR  (10620): -1296.890015, -128.309998, 78.050003
05-28 21:30:53.498+0900 I/SENSOR  (10620): 앞으로 
05-28 21:30:53.498+0900 I/SOCKETTEST(10620): Success to create socket
05-28 21:30:53.508+0900 I/SOCKETTEST(10620): Success to socket connection
05-28 21:30:53.513+0900 I/SOCKETTEST(10620): write() 성공
05-28 21:30:53.598+0900 I/SENSOR  (10620): 512.820007, -63.490002, -49.139999
05-28 21:30:53.703+0900 I/SENSOR  (10620): 314.510010, 23.730000, -4.270000
05-28 21:30:53.778+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:30:53.778+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:30:53.778+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:30:53.778+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:30:53.778+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:30:53.798+0900 I/SENSOR  (10620): 721.559998, 44.029999, -49.700001
05-28 21:30:53.898+0900 I/SENSOR  (10620): 348.809998, 35.000000, -97.790001
05-28 21:30:53.998+0900 I/SENSOR  (10620): -35.490002, -26.040001, -20.510000
05-28 21:30:54.098+0900 I/SENSOR  (10620): -827.679993, -104.860001, 91.629997
05-28 21:30:54.198+0900 I/SENSOR  (10620): -743.820007, -65.870003, -24.570000
05-28 21:30:54.308+0900 I/SENSOR  (10620): -129.919998, 28.490000, 88.059998
05-28 21:30:54.398+0900 I/SENSOR  (10620): 818.440002, 40.040001, -27.860001
05-28 21:30:54.428+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:30:54.428+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:30:54.433+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:30:54.433+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:30:54.433+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:30:54.498+0900 I/SENSOR  (10620): 519.609985, 82.040001, -113.820000
05-28 21:30:54.568+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:30:54.568+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:30:54.568+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:30:54.568+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:30:54.568+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:30:54.568+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:30:54.573+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:30:54.573+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:30:54.573+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:30:54.598+0900 I/SENSOR  (10620): 67.620003, 22.750000, -46.410000
05-28 21:30:54.698+0900 I/SENSOR  (10620): 32.619999, 16.590000, -43.680000
05-28 21:30:54.798+0900 I/SENSOR  (10620): 31.780001, 12.040000, -40.180000
05-28 21:30:54.903+0900 I/SENSOR  (10620): 35.910000, 25.480000, -20.790001
05-28 21:30:55.008+0900 I/SENSOR  (10620): -13.790000, -15.470000, -7.210000
05-28 21:30:55.108+0900 I/SENSOR  (10620): -20.160000, -26.250000, 17.430000
05-28 21:30:55.203+0900 I/SENSOR  (10620): -65.169998, -23.660000, 47.459999
05-28 21:30:55.278+0900 I/SHealth_Service( 1036): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-28 21:30:55.298+0900 I/SENSOR  (10620): -547.609985, -167.089996, 120.050003
05-28 21:30:55.333+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-28 21:30:55.398+0900 I/SENSOR  (10620): -1204.069946, -148.750000, -64.470001
05-28 21:30:55.398+0900 I/SENSOR  (10620): 앞으로 
05-28 21:30:55.398+0900 I/SOCKETTEST(10620): Success to create socket
05-28 21:30:55.403+0900 I/SOCKETTEST(10620): Success to socket connection
05-28 21:30:55.408+0900 I/SOCKETTEST(10620): write() 성공
05-28 21:30:55.428+0900 W/SHealth_Common( 1036): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-28 21:30:55.473+0900 W/SHealth_Common( 1036): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-28 21:30:55.498+0900 I/SENSOR  (10620): 56.070000, -0.280000, 44.099998
05-28 21:30:55.528+0900 W/SHealth_Common( 1036): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-28 21:30:55.578+0900 I/CAPI_WIDGET_APPLICATION(  775): widget_app.c: __provider_update_cb(279) > received updating signal
05-28 21:30:55.578+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-28 21:30:55.593+0900 I/HealthDataService( 1059): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-28 21:30:55.598+0900 I/SENSOR  (10620): 274.679993, 40.180000, 65.590004
05-28 21:30:55.628+0900 I/healthData( 1036): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-28 21:30:55.628+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:30:55.628+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:30:55.628+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:30:55.628+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:30:55.628+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:30:55.698+0900 I/SENSOR  (10620): 738.500000, 46.200001, -31.010000
05-28 21:30:55.798+0900 I/SENSOR  (10620): 335.089996, 31.710001, -71.400002
05-28 21:30:55.898+0900 I/SENSOR  (10620): 120.190002, 49.070000, -31.290001
05-28 21:30:55.998+0900 I/SENSOR  (10620): 59.500000, 44.380001, -22.049999
05-28 21:30:56.063+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:30:56.068+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:30:56.068+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:30:56.073+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:30:56.073+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:30:56.093+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:30:56.103+0900 I/SENSOR  (10620): 29.120001, 19.389999, -32.619999
05-28 21:30:56.203+0900 I/SENSOR  (10620): 12.880000, 13.090000, -29.049999
05-28 21:30:56.203+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:30:56.208+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:30:56.208+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:30:56.303+0900 I/SENSOR  (10620): 2.380000, 1.890000, -22.680000
05-28 21:30:56.408+0900 I/SENSOR  (10620): -3.640000, -4.270000, -11.830000
05-28 21:30:56.508+0900 I/SENSOR  (10620): -8.120000, -9.590000, -4.830000
05-28 21:30:56.603+0900 I/SENSOR  (10620): -11.550000, -6.790000, 1.540000
05-28 21:30:56.703+0900 I/SENSOR  (10620): -12.110000, 26.110001, -7.840000
05-28 21:30:56.803+0900 I/SENSOR  (10620): 26.950001, 7.420000, -6.230000
05-28 21:30:56.913+0900 I/SENSOR  (10620): 0.980000, 28.000000, -9.030000
05-28 21:30:57.008+0900 I/SENSOR  (10620): 20.580000, 10.010000, 1.330000
05-28 21:30:57.108+0900 I/SENSOR  (10620): -5.740000, -7.770000, 4.620000
05-28 21:30:57.203+0900 I/SENSOR  (10620): -11.480000, -3.360000, 6.370000
05-28 21:30:57.288+0900 I/SHealth_Service( 1036): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(643) > [1;35mlength of Array [1][0;m
05-28 21:30:57.303+0900 I/SENSOR  (10620): 3.570000, -7.630000, 3.920000
05-28 21:30:57.318+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-28 21:30:57.388+0900 W/SHealth_Common( 1036): SHealthWidgetConnection.cpp: Send(66) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-28 21:30:57.403+0900 I/SENSOR  (10620): -3.290000, -3.640000, 2.800000
05-28 21:30:57.443+0900 W/SHealth_Common( 1036): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-28 21:30:57.473+0900 W/SHealth_Common( 1036): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
05-28 21:30:57.503+0900 I/SENSOR  (10620): -0.700000, -3.850000, 5.530000
05-28 21:30:57.508+0900 I/CAPI_WIDGET_APPLICATION(  775): widget_app.c: __provider_update_cb(279) > received updating signal
05-28 21:30:57.513+0900 I/HealthDataService( 1059): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-28 21:30:57.548+0900 I/healthData( 1036): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-28 21:30:57.598+0900 E/EFL     (10620): evas_main<10620> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4156859 button=1 downs=1
05-28 21:30:57.603+0900 I/SENSOR  (10620): 8.400000, 52.430000, 48.230000
05-28 21:30:57.608+0900 E/EFL     (10620): evas_main<10620> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4156870 button=1 downs=0
05-28 21:30:57.703+0900 I/SENSOR  (10620): -9.100000, 12.040000, 2.240000
05-28 21:30:57.803+0900 I/SENSOR  (10620): 1.260000, -21.840000, -24.639999
05-28 21:30:57.903+0900 I/SENSOR  (10620): 37.520000, 0.210000, -15.890000
05-28 21:30:58.003+0900 I/SENSOR  (10620): 19.460001, 2.800000, -5.880000
05-28 21:30:58.108+0900 I/SENSOR  (10620): -21.770000, -15.890000, 10.430000
05-28 21:30:58.208+0900 I/SENSOR  (10620): -15.190001, -7.210000, -6.370000
05-28 21:30:58.303+0900 I/SENSOR  (10620): -9.030000, -8.260000, 7.490000
05-28 21:30:58.408+0900 I/SENSOR  (10620): -3.710000, -3.220000, 2.450000
05-28 21:30:58.508+0900 I/SENSOR  (10620): -1.400000, -3.570000, 5.110000
05-28 21:30:58.608+0900 I/SENSOR  (10620): 3.150000, -3.570000, 3.990000
05-28 21:30:58.708+0900 I/SENSOR  (10620): 20.160000, 12.460000, -8.960000
05-28 21:30:58.708+0900 E/EFL     (10620): evas_main<10620> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4157966 button=1 downs=1
05-28 21:30:58.738+0900 E/EFL     (10620): evas_main<10620> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4158000 button=1 downs=0
05-28 21:30:58.738+0900 I/PTESTResetClicked(10620): 1start_clicked
05-28 21:30:58.738+0900 I/PTESTResetClicked(10620): 2before if
05-28 21:30:58.738+0900 I/PTESTResetClicked(10620): 3adtimer if
05-28 21:30:58.738+0900 I/efl-extension(10620): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-28 21:30:58.738+0900 I/efl-extension(10620): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-28 21:30:58.738+0900 I/efl-extension(10620): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-28 21:30:58.758+0900 I/SOCKETTEST(10620): Success to create socket
05-28 21:30:58.838+0900 I/SOCKETTEST(10620): Success to socket connection
05-28 21:30:58.838+0900 I/SOCKETTEST(10620): write() 성공
05-28 21:30:58.863+0900 I/ResetClicked(10620): Reset_Clicked_cb / num,time 2 42
05-28 21:30:59.368+0900 I/efl-extension(10620): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x442b04a0
05-28 21:30:59.368+0900 I/efl-extension(10620): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x442b04a0, obj: 0x442b04a0
05-28 21:30:59.368+0900 I/efl-extension(10620): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-28 21:30:59.798+0900 E/EFL     (10620): evas_main<10620> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=4159061 button=1 downs=1
05-28 21:30:59.818+0900 E/EFL     (10620): evas_main<10620> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=4159083 button=1 downs=0
05-28 21:30:59.823+0900 I/ResetClicked(10620): input_ record start
05-28 21:30:59.823+0900 I/2ResetClicked(10620): count : 2
05-28 21:30:59.823+0900 I/3ResetClicked(10620): end input record function
05-28 21:30:59.823+0900 I/ResetCalTime(10620): str 00:39
05-28 21:30:59.823+0900 I/ResetClicked(10620): clock_time 00:39
05-28 21:30:59.823+0900 I/ResetClicked(10620): 2clock_timee 00:39
05-28 21:30:59.823+0900 I/ResetClicked(10620): 3clock_timee 00:39
05-28 21:30:59.823+0900 I/ResetCalTime(10620): str 15:05
05-28 21:30:59.823+0900 I/ResetClicked(10620): 4clock_timee 00:39
05-28 21:30:59.823+0900 I/ResetClicked(10620): clock_total 15:05
05-28 21:30:59.823+0900 I/ResetClicked(10620): 5clock_timee 00:39
05-28 21:30:59.823+0900 I/11ResetClicked(10620): ?? 1 ???? 1. 00:39
05-28 21:30:59.823+0900 I/11ResetClicked(10620):  / 15:05
05-28 21:30:59.823+0900 I/ResetCalTime(10620): str 00:42
05-28 21:30:59.823+0900 I/ResetClicked(10620): clock_time 00:42
05-28 21:30:59.823+0900 I/ResetClicked(10620): 2clock_timee 00:42
05-28 21:30:59.828+0900 I/ResetClicked(10620): 3clock_timee 00:42
05-28 21:30:59.828+0900 I/ResetCalTime(10620): str 15:00
05-28 21:30:59.828+0900 I/ResetClicked(10620): 4clock_timee 00:42
05-28 21:30:59.828+0900 I/ResetClicked(10620): clock_total 15:00
05-28 21:30:59.828+0900 I/ResetClicked(10620): 5clock_timee 00:42
05-28 21:30:59.828+0900 I/11ResetClicked(10620): ?? 2 ???? 2. 00:42
05-28 21:30:59.828+0900 I/11ResetClicked(10620):  / 15:00
05-28 21:30:59.863+0900 I/efl-extension(10620): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-28 21:30:59.863+0900 I/efl-extension(10620): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4435a9c0, elm_image, _activated_obj : 0x0, activated : 1
05-28 21:30:59.888+0900 I/efl-extension(10620): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x4436c750]'s widget[0x443682d0] to layout widget[0x4435ae40]
05-28 21:30:59.888+0900 I/efl-extension(10620): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x4436c750 = w: 0 h: 0  obj 0x443682d0 w: 360 h: 360
05-28 21:30:59.893+0900 I/efl-extension(10620): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-28 21:31:00.608+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:00.613+0900 I/efl-extension(10620): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:00.613+0900 I/efl-extension(10620): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4435a9c0, elm_image, time_stamp : 4159873
05-28 21:31:00.743+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 28->28
05-28 21:31:00.798+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:00.798+0900 I/efl-extension(10620): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:00.798+0900 I/efl-extension(10620): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4435a9c0, elm_image, time_stamp : 4160059
05-28 21:31:00.883+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:00.883+0900 I/efl-extension(10620): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:00.888+0900 I/efl-extension(10620): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4435a9c0, elm_image, time_stamp : 4160145
05-28 21:31:01.398+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-28 21:31:01.398+0900 I/efl-extension(10620): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-28 21:31:01.398+0900 I/efl-extension(10620): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x4435a9c0, elm_image, time_stamp : 4160658
05-28 21:31:01.528+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-28 21:31:01.528+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-28 21:31:01.528+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-28 21:31:01.528+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:31:01.528+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:31:01.528+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-28 21:31:01.528+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:31:01.528+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:31:01.528+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-28 21:31:01.863+0900 I/efl-extension(10620): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:01.863+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:01.863+0900 I/efl-extension(10620): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4435a9c0, elm_image, time_stamp : 4161124
05-28 21:31:01.913+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:01.913+0900 I/efl-extension(10620): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:01.913+0900 I/efl-extension(10620): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4435a9c0, elm_image, time_stamp : 4161175
05-28 21:31:01.983+0900 I/efl-extension(10620): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:01.983+0900 I/efl-extension(10620): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4435a9c0, elm_image, time_stamp : 4161244
05-28 21:31:01.983+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-28 21:31:03.358+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:31:03.358+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:31:03.358+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:31:03.358+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:31:03.358+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:31:06.158+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-28 21:31:06.158+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-28 21:31:12.143+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:31:12.148+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:31:12.153+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:31:12.153+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:31:12.153+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:31:12.188+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:31:12.223+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:31:12.223+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:31:12.228+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:31:25.303+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-28 21:31:28.588+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:31:28.588+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:31:28.588+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:31:28.588+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:31:28.588+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:31:45.633+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 44 -> 43 1464438705 180
05-28 21:31:45.633+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 43 1036 479 742
05-28 21:31:45.633+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 43 0 0 1158
05-28 21:31:45.633+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 43 693 256 497
05-28 21:31:45.633+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 43 276 5 198
05-28 21:31:45.633+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 43 554 14 397
05-28 21:31:54.163+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:31:54.163+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:31:54.168+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:31:54.168+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:31:54.168+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:31:54.168+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:31:54.198+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:31:54.263+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:31:54.263+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:31:55.613+0900 I/efl-extension(10620): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x442b0620, obj: 0x442b0620
05-28 21:31:55.613+0900 I/efl-extension(10620): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-28 21:31:55.618+0900 I/efl-extension(10620): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-28 21:31:55.618+0900 I/efl-extension(10620): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-28 21:31:55.618+0900 I/efl-extension(10620): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-28 21:31:55.658+0900 I/efl-extension(10620): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4435a9c0
05-28 21:31:55.658+0900 I/efl-extension(10620): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-28 21:31:55.663+0900 I/efl-extension(10620): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x442b0620, elm_genlist, func : 0x4011bdfd
05-28 21:31:55.663+0900 I/efl-extension(10620): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-28 21:32:00.758+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 28->28
05-28 21:32:01.613+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-28 21:32:01.618+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-28 21:32:01.623+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-28 21:32:01.628+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:32:01.628+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:32:01.638+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-28 21:32:01.643+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:32:01.648+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:32:01.663+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-28 21:32:06.148+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-28 21:32:06.148+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-28 21:32:06.148+0900 I/RESOURCED(  488): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-28 21:32:25.298+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-28 21:33:00.768+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 28->28
05-28 21:33:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-28 21:33:01.598+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-28 21:33:01.603+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-28 21:33:01.608+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:33:01.608+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:33:01.618+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-28 21:33:01.638+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-28 21:33:01.638+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-28 21:33:01.643+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-28 21:33:06.168+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-28 21:33:06.168+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-28 21:33:08.723+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:33:08.723+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:33:08.728+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:33:08.728+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:33:08.728+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:33:09.728+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:33:09.728+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:33:09.728+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:33:09.728+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:33:09.728+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:33:10.103+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-28 21:33:10.103+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-28 21:33:10.103+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-28 21:33:10.103+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-28 21:33:10.103+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:33:10.103+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:33:10.103+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:33:10.118+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-28 21:33:10.118+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-28 21:33:17.488+0900 E/PKGMGR_SERVER(10997): pkgmgr-server.c: main(2131) > package manager server start
05-28 21:33:17.593+0900 E/PKGMGR_SERVER(10997): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_978260991], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[Uk9y1Dqb4Po5kBc8K18OqZ1Ow0w=], backend_flag=[0]
05-28 21:33:17.603+0900 E/PKGMGR_SERVER(10999): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-28 21:33:17.608+0900 E/PKGMGR  (10991): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-28 21:33:17.673+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:33:17.683+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10620
05-28 21:33:17.683+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-28 21:33:17.688+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 5
05-28 21:33:17.693+0900 I/APP_CORE(10620): appcore-efl.c: __do_app(429) > [APP 10620] Event: TERMINATE State: RUNNING
05-28 21:33:17.698+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-28 21:33:17.698+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-28 21:33:17.698+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(15), pid(10620), cmd(4)
05-28 21:33:17.698+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:33:17.713+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10620
05-28 21:33:17.768+0900 I/APP_CORE(10620): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-28 21:33:17.768+0900 I/CAPI_APPFW_APPLICATION(10620): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-28 21:33:17.783+0900 I/efl-extension(10620): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-28 21:33:17.783+0900 I/efl-extension(10620): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4436c750 is freed
05-28 21:33:17.783+0900 I/efl-extension(10620): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x442920c8 is freed
05-28 21:33:17.793+0900 I/MALI    (10620): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f5f020] swap changed from sync to async
05-28 21:33:17.798+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-28 21:33:17.798+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-28 21:33:17.813+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:33:17.823+0900 I/MALI    (10620): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-28 21:33:17.823+0900 I/MALI    (10620): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=10620   close drm_fd=25 
05-28 21:33:17.823+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10620
05-28 21:33:17.823+0900 I/MALI    (10620): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-28 21:33:17.878+0900 W/PROCESSMGR(  382): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-28 21:33:17.883+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-28 21:33:17.883+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-28 21:33:17.883+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-28 21:33:17.883+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-28 21:33:17.883+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-28 21:33:17.883+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-28 21:33:17.883+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:33:17.883+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:33:17.888+0900 I/UXT     (10620): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-28 21:33:17.923+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:33:17.938+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:33:17.938+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-28 21:33:17.938+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-28 21:33:17.938+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-28 21:33:17.938+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:33:17.938+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-28 21:33:17.938+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
05-28 21:33:17.938+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-28 21:33:17.938+0900 W/W_HOME  (  714): main.c: _appcore_resume_cb(681) > appcore resume
05-28 21:33:17.938+0900 W/W_HOME  (  714): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-28 21:33:17.938+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:33:17.938+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10620
05-28 21:33:17.938+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:33:17.938+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-28 21:33:17.938+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 28->28
05-28 21:33:17.943+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x45d34090
05-28 21:33:17.943+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d34090, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-28 21:33:17.943+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-28 21:33:17.948+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-28 21:33:17.948+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-28 21:33:17.948+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-28 21:33:17.948+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-28 21:33:17.948+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-28 21:33:17.948+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-28 21:33:17.948+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-28 21:33:18.048+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:33:18.063+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10620
05-28 21:33:18.163+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:33:18.198+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10620
05-28 21:33:18.298+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:33:18.313+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10620
05-28 21:33:18.373+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-28 21:33:18.413+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 21:33:18.428+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-28 21:33:18.433+0900 E/PKGMGR_SERVER(10999): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-28 21:33:18.458+0900 E/PKGMGR_SERVER(10997): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10999]
05-28 21:33:18.548+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 23
05-28 21:33:18.548+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-28 21:33:18.548+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 10620
05-28 21:33:18.548+0900 W/AUL_AMD (  487): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-28 21:33:18.548+0900 E/AUL     (11007): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-28 21:33:18.568+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 10620
05-28 21:33:18.583+0900 W/CRASH_MANAGER(11003): worker.c: worker_job(1199) > 1110620706831146443879
