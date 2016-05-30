S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 5871
Date: 2016-05-28 20:48:21+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x404a0250, r3   = 0x00000000
r4   = 0x4614e880, r5   = 0x00000000
r6   = 0x4614f180, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x4614db00
r10  = 0x440518f0, fp   = 0x00000000
ip   = 0x4008d490, sp   = 0xbedad638
lr   = 0x403e91e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     16268 KB
Buffers:     34244 KB
Cached:     152068 KB
VmPeak:     122684 KB
VmSize:     108436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23000 KB
VmRSS:       22408 KB
VmData:      52800 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5871 TID = 5871
5871 5877 5880 5938 5974 

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
43758000 4376c000 rwxp [stack:5877]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44383000 44b82000 rwxp [stack:5974]
44b82000 44b85000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b85000 44b89000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b89000 44b98000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44d80000 4557f000 rwxp [stack:5938]
45673000 4567a000 r-xs /usr/lib/gconv/gconv-modules.cache
45713000 45f12000 rwxp [stack:5880]
46508000 4650b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46512000 46513000 rwxp /usr/lib/libpulse-simple.so.0.0.4
466fa000 46732000 r-xp /usr/lib/libpulse.so.0.16.2
46732000 46733000 rwxp /usr/lib/libpulse.so.0.16.2
46786000 4678b000 r-xp /usr/lib/libjson.so.0.0.1
46792000 46793000 rwxp /usr/lib/libjson.so.0.0.1
46793000 467db000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
467db000 467dc000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
467dc000 4681f000 r-xp /usr/lib/libsndfile.so.1.0.25
46826000 46828000 rwxp /usr/lib/libsndfile.so.1.0.25
4682c000 4684e000 r-xp /usr/lib/libvorbis.so.0.4.3
46855000 46856000 rwxp /usr/lib/libvorbis.so.0.4.3
46856000 4685a000 r-xp /usr/lib/libogg.so.0.7.1
46861000 46862000 rwxp /usr/lib/libogg.so.0.7.1
bed8d000 bedae000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5871)
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
1.088+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.088+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.088+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.088+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.088+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5871
05-28 20:48:21.093+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.093+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.093+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.093+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.093+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.093+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.093+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.093+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.098+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.098+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.098+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.098+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.098+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.098+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.098+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.098+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.098+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.098+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.103+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.103+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.103+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.103+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.103+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.103+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.103+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.103+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.108+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.108+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.108+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.108+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.108+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.108+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.108+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.108+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.113+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.113+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.113+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.113+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.113+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.113+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.113+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.113+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.118+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.118+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.118+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.118+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.118+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.118+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.118+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.118+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.123+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.123+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.123+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.123+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.123+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.123+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.123+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.123+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.128+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.128+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.128+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.128+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.128+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.128+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.128+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.128+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.133+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.133+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.133+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.133+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.133+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.133+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.138+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.138+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.138+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.138+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.138+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.138+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.138+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.138+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.143+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.143+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.143+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.143+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.143+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.143+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.143+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.143+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.148+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.148+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.148+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.148+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.148+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.148+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.153+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.153+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.153+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.153+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.153+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.153+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.153+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.153+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.153+0900 I/UXT     ( 5871): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-28 20:48:21.158+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.158+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.158+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.158+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.158+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.158+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.163+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.163+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.163+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.163+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.163+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.163+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.163+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.163+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.168+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.168+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.168+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.168+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.173+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.173+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.173+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.173+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.178+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.178+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.178+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.178+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.178+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.178+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.183+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.183+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.188+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.188+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.188+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.188+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.188+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.188+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.188+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.188+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.193+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.193+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.193+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 20:48:21.198+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.198+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.198+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.198+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.198+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.198+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.198+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.198+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.203+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.203+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.203+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5871
05-28 20:48:21.203+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.203+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.203+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.203+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.208+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.208+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.208+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.208+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.208+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.208+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.208+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.208+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.213+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.213+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.213+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.213+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.213+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.213+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.213+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.213+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.218+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.218+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.218+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.218+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.218+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.218+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.218+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.218+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.223+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.223+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.223+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.223+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.223+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.223+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.223+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.223+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.228+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.228+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.228+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.228+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.228+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.228+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.228+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.228+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.233+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.233+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.233+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.233+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.233+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.233+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.233+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.233+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.238+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.238+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.238+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.238+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.238+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.238+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.238+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.238+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.243+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.243+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.243+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.243+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.243+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.243+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.243+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.243+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.248+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.248+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.248+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.248+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.248+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.248+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.248+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.248+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.253+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.253+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.253+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.253+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.253+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.253+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.258+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.258+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.258+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.258+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.258+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.258+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.258+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.258+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.263+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.263+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.263+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.263+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.263+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.263+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.263+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.263+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.268+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.268+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.268+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.268+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.268+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.268+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.268+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.268+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.273+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.273+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.273+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.273+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.273+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.273+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.278+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.278+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.278+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.278+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.278+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.278+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.283+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.283+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.283+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.283+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.283+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.283+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.283+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.283+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.288+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.288+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.288+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.288+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.288+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.288+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.293+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.293+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.293+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.293+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.293+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.293+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.293+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.293+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.298+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.298+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.298+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.298+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.298+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.298+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.303+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.303+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.303+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.303+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.303+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.303+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.303+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 20:48:21.308+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.308+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.308+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.308+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.313+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.313+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.313+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.313+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.318+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.318+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.318+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.318+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.323+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.323+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.323+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.323+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.323+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5871
05-28 20:48:21.323+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.323+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.328+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.328+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.328+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.328+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.328+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.328+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.328+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.328+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.333+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.333+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.333+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.333+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.333+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.333+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.338+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.338+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.338+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.338+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.338+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.338+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.338+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.343+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.343+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.343+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.343+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.343+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.343+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.343+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.348+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.348+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.348+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.348+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.348+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.348+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.348+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.353+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.353+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.353+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.353+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.353+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.353+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.353+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.358+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.358+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.358+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.358+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.358+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.358+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.358+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.358+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.363+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.363+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.363+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.363+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.363+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.363+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.363+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.363+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.368+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.368+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.368+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.368+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.368+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.368+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.373+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.373+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.373+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.373+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.373+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.373+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.373+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.373+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.378+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.378+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.378+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.378+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.378+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.378+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.378+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.378+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.383+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.383+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.383+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.383+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.383+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.383+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.388+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.388+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.388+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.388+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.388+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.388+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.388+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.388+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.393+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.393+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.393+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.393+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.393+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.393+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.393+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.393+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.398+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.398+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.398+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.398+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.398+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.398+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.403+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.403+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.403+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.403+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.403+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.403+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.403+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.403+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.408+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.408+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.408+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.408+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.408+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.408+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.408+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.408+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.413+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.413+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.413+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.413+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.413+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.413+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.418+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.418+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.418+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.418+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.418+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.418+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.423+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.423+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.423+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.423+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.423+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.423+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.423+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 20:48:21.433+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.433+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.438+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.438+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.438+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.438+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.443+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.443+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.443+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.443+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.448+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.448+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.448+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5871
05-28 20:48:21.448+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.448+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.448+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.448+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.453+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.453+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.453+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.453+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.453+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.453+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.453+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.458+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.458+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.458+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.458+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.458+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.458+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.458+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.463+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.463+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.463+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.463+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.463+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.463+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.468+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.468+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.468+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.468+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.468+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.468+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.468+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.468+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.473+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.473+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.473+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.473+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.473+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.473+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.473+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.473+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.478+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.478+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.478+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.478+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.478+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.478+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.483+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.483+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.483+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.483+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.483+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.483+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.483+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.483+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.488+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.488+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.488+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.488+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.488+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.488+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.493+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.493+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.493+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.493+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.493+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.493+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.498+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.498+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.498+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.498+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.498+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.498+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.503+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.503+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.503+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.503+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.503+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.503+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.503+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.503+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.508+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.508+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.508+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.508+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.508+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.508+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.513+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.513+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.513+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.513+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.513+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.513+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.513+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.513+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.518+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.518+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.518+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.518+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.518+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.518+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.518+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.518+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.523+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.523+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.528+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.528+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.528+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.528+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.533+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.533+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.533+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-28 20:48:21.533+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.533+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.533+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.533+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.543+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.543+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.543+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.543+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.543+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.543+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.543+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.543+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.548+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.548+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.548+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.548+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.548+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 20:48:21.558+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5871
05-28 20:48:21.558+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.558+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.563+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.563+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.563+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.568+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.568+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.568+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.568+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.568+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.568+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.568+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.568+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.568+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.573+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.573+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.573+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.573+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.573+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.573+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.578+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.578+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.578+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.578+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.578+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.578+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.578+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.578+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.578+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.578+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.583+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.583+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.583+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.583+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.583+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.583+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.583+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.583+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.588+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.588+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.588+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.588+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.588+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.588+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.588+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.588+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.593+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.593+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.593+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.593+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.593+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.593+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.593+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.593+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.598+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.598+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.598+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.598+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.598+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.598+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.598+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.598+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.603+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.603+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.603+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.603+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.603+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.603+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.603+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.603+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.608+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.608+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.608+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.608+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.608+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.608+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.608+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.608+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.613+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.613+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.613+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.613+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.613+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.613+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.613+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.613+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.618+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.618+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.618+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.618+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.618+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.618+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.618+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.618+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.623+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.623+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.623+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.623+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.623+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.623+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.623+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.623+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.623+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.623+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.628+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.628+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.628+0900 I/SOCKETTEST( 5871): Success to create socket
05-28 20:48:21.628+0900 I/SOCKETTEST( 5871): Bind Success
05-28 20:48:21.663+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-28 20:48:21.668+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-28 20:48:21.758+0900 I/PRIVACY-MANAGER-CLIENT( 6718): SocketClient.cpp: SocketClient(37) > Client created
05-28 20:48:21.758+0900 I/PRIVACY-MANAGER-SERVER(  455): SocketService.cpp: mainloop(227) > Got incoming connection
05-28 20:48:21.758+0900 I/PRIVACY-MANAGER-CLIENT( 6718): SocketStream.h: SocketStream(31) > Created
05-28 20:48:21.758+0900 I/PRIVACY-MANAGER-CLIENT( 6718): SocketConnection.h: SocketConnection(44) > Created
05-28 20:48:21.758+0900 I/PRIVACY-MANAGER-CLIENT( 6718): SocketClient.cpp: connect(62) > Client connected
05-28 20:48:21.763+0900 I/PRIVACY-MANAGER-SERVER(  455): SocketService.cpp: connectionThread(253) > Starting connection thread
05-28 20:48:21.763+0900 I/PRIVACY-MANAGER-SERVER(  455): SocketStream.h: SocketStream(31) > Created
05-28 20:48:21.763+0900 I/PRIVACY-MANAGER-SERVER(  455): SocketConnection.h: SocketConnection(44) > Created
05-28 20:48:21.763+0900 I/PRIVACY-MANAGER-SERVER(  455): SocketService.cpp: connectionService(304) > Calling service
05-28 20:48:21.763+0900 I/PRIVACY-MANAGER-SERVER(  455): SocketService.cpp: connectionService(307) > Removing client
05-28 20:48:21.763+0900 I/PRIVACY-MANAGER-SERVER(  455): SocketService.cpp: connectionService(311) > Call served
05-28 20:48:21.763+0900 I/PRIVACY-MANAGER-SERVER(  455): SocketService.cpp: connectionThread(262) > Client serviced
05-28 20:48:21.768+0900 I/PRIVACY-MANAGER-CLIENT( 6718): SocketClient.cpp: disconnect(72) > Client disconnected
05-28 20:48:21.773+0900 E/PKGMGR_CERT( 6718): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
05-28 20:48:21.778+0900 E/PKGMGR_CERT( 6718): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
05-28 20:48:21.818+0900 E/PKGMGR_CERT( 6718): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
05-28 20:48:21.833+0900 W/CRASH_MANAGER( 6719): worker.c: worker_job(1199) > 1105871706831146443610
