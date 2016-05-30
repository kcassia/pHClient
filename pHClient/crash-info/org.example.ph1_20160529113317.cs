S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 26212
Date: 2016-05-29 11:33:17+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x404a0250, r3   = 0x00000000
r4   = 0xbe86e648, r5   = 0x46440b58
r6   = 0x40002238, r7   = 0x00000000
r8   = 0x4643f4d8, r9   = 0x44050870
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4008d490, sp   = 0xbe86e638
lr   = 0x403e91e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     18468 KB
Buffers:     42628 KB
Cached:     127752 KB
VmPeak:     115524 KB
VmSize:      99244 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22224 KB
VmRSS:       21484 KB
VmData:      43608 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       50676 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 26212 TID = 26212
26212 26219 26223 26302 

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
43758000 4376c000 rwxp [stack:26219]
4376c000 4376f000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43776000 43777000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b3000 440b5000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44383000 44b82000 rwxp [stack:26302]
44bca000 44bcd000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44bcd000 44bd1000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44bd1000 44be0000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
45637000 4563e000 r-xs /usr/lib/gconv/gconv-modules.cache
4563f000 45e3e000 rwxp [stack:26223]
463cb000 463ce000 r-xp /usr/lib/libpulse-simple.so.0.0.4
463d5000 463d6000 rwxp /usr/lib/libpulse-simple.so.0.0.4
465e4000 465e9000 r-xp /usr/lib/libjson.so.0.0.1
465f0000 465f1000 rwxp /usr/lib/libjson.so.0.0.1
465f1000 465f5000 r-xp /usr/lib/libogg.so.0.7.1
465fc000 465fd000 rwxp /usr/lib/libogg.so.0.7.1
46723000 4675b000 r-xp /usr/lib/libpulse.so.0.16.2
4675b000 4675c000 rwxp /usr/lib/libpulse.so.0.16.2
4678d000 467d5000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
467d5000 467d6000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
467d6000 46819000 r-xp /usr/lib/libsndfile.so.1.0.25
46820000 46822000 rwxp /usr/lib/libsndfile.so.1.0.25
46826000 46848000 r-xp /usr/lib/libvorbis.so.0.4.3
4684f000 46850000 rwxp /usr/lib/libvorbis.so.0.4.3
be84e000 be86f000 rwxp [stack]
End of Maps Information

Callstack Information (PID:26212)
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
5) > Try to read procfs status
05-29 11:32:45.386+0900 I/AUL_AMD (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/net-config, ret : 0
05-29 11:32:45.386+0900 E/AUL_AMD (  487): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 11:32:45.386+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 523
05-29 11:32:45.386+0900 E/AUL_AMD (  487): amd_launch.c: _start_app(1715) > no appinfo
05-29 11:32:45.386+0900 E/AUL_AMD (  487): amd_launch.c: __real_send(826) > send fail to client
05-29 11:32:45.391+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 11:32:45.391+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(343363534)
05-29 11:32:45.391+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 11:32:45.391+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 02:35:33 (UTC).
05-29 11:32:45.391+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 11:32:45.391+0900 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[343363534] is removed.
05-29 11:32:45.406+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(39) > [windicator_scs_update:39] sales code : 0
05-29 11:32:45.406+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(46) > [windicator_scs_update:46] sap connected : 1
05-29 11:32:45.406+0900 I/W_INDICATOR(  685): windicator.c: windicator_is_lo_connected(689) > [windicator_is_lo_connected:689] Connected target vendor : samsung
05-29 11:32:45.406+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(81) > [windicator_scs_update:81] sap connectivity type : 16
05-29 11:32:45.406+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(88) > [windicator_scs_update:88] network status : 2
05-29 11:32:45.406+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(103) > [windicator_scs_update:103] scs login : 0
05-29 11:32:45.406+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(132) > [windicator_scs_update:132] not connected icon
05-29 11:32:45.406+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(149) > [windicator_scs_update:149] ciss_request_type : 0
05-29 11:32:45.406+0900 I/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(159) > [windicator_scs_update:159] Hide (Callforwarding requested)
05-29 11:32:45.411+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(374) > network status : 0
05-29 11:32:45.411+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(379) > sap_connected : 1
05-29 11:32:45.411+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(385) > sap connectivity type : 16
05-29 11:32:45.411+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(391) > network status : 2
05-29 11:32:45.411+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(405) > scs login : 0
05-29 11:32:45.411+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(450) > not connected icon
05-29 11:32:45.411+0900 W/W_HOME  (  714): clock_indicator.c: clock_indicator_pop_icon(391) > icon:5 is popped from clock indicator
05-29 11:32:45.411+0900 W/W_HOME  (  714): clock_indicator.c: clock_indicator_icon_push(356) > icon:5 is added to clock indicator
05-29 11:32:45.416+0900 W/WPROXY  (  840): net-device.c: __proxy_address_changed_cb(94) > set netinfo, backup : config[0], status[2]
05-29 11:32:45.421+0900 I/AUL     (  466): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
05-29 11:32:45.426+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 11:32:45.436+0900 I/AUL     (  466): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
05-29 11:32:45.436+0900 E/ALARM_MANAGER(  466): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(5), start(29-5-2016, 11:32:50), repeat(0), interval(0), type(-1073741822)
05-29 11:32:45.436+0900 I/AUL_AMD (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/net-config, ret : 0
05-29 11:32:45.441+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 11:32:45.446+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 11:32:45.451+0900 I/AUL_AMD (  487): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/net-config, ret : 0
05-29 11:32:45.451+0900 E/AUL_AMD (  487): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-29 11:32:45.451+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 523
05-29 11:32:45.456+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
05-29 11:32:45.461+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 11:32:45.461+0900 W/AUL_PAD (13314): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 11:32:45.461+0900 W/AUL_PAD (13314): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 11:32:45.461+0900 E/RESOURCED(  488): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 11:32:45.476+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
05-29 11:32:45.486+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
05-29 11:32:45.501+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
05-29 11:32:45.501+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 11:32:45.501+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 11:32:45.511+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
05-29 11:32:45.526+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/weconnd, ret : 0
05-29 11:32:45.526+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464489170, Sun May 29 11:32:50 2016
05-29 11:32:45.526+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1113048248, next duetime: 1464489170
05-29 11:32:45.526+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1113048248)
05-29 11:32:45.526+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464489333), due_time(1464489170)
05-29 11:32:45.526+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 11:32:45.526+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 02:32:50 (UTC).
05-29 11:32:45.526+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 11:32:45.531+0900 I/efl-extension(27043): efl_extension.c: eext_mod_init(40) > Init
05-29 11:32:45.531+0900 I/UXT     (27043): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-29 11:32:45.551+0900 I/CAPI_APPFW_APPLICATION(27043): app_main.c: app_efl_main(129) > app_efl_main
05-29 11:32:45.556+0900 I/CAPI_APPFW_APPLICATION(27043): app_main.c: app_appcore_create(152) > app_appcore_create
05-29 11:32:45.556+0900 E/UXT     (27043): uxt_theme.c: _set_changeable_ui_data(123) > failed to get ecore_evas list.
05-29 11:32:45.571+0900 E/RESOURCED(  488): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : net.wc-syspopup
05-29 11:32:45.576+0900 E/TBM     (27043): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 11:32:45.646+0900 E/UXT     (27043): uxt_theme.c: uxt_theme_add_color_table(507) > failed to get table
05-29 11:32:45.646+0900 E/UXT     (27043): uxt_theme.c: uxt_theme_set_font_table(1136) > failed to get font table.
05-29 11:32:45.651+0900 I/APP_CORE(27043): appcore-efl.c: __do_app(429) > [APP 27043] Event: RESET State: CREATED
05-29 11:32:45.651+0900 I/CAPI_APPFW_APPLICATION(27043): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 11:32:45.761+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:45.781+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:45.886+0900 I/APP_CORE(27043): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 11:32:45.886+0900 I/APP_CORE(27043): appcore-efl.c: __do_app(474) > [APP 27043] Initial Launching, call the resume_cb
05-29 11:32:45.886+0900 I/CAPI_APPFW_APPLICATION(27043): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 11:32:45.891+0900 E/E17     (  382): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05a00006)
05-29 11:32:45.906+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:45.931+0900 W/APP_CORE(27043): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5a00006
05-29 11:32:46.006+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 11:32:46.006+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 11:32:46.011+0900 I/APP_CORE(27043): appcore-efl.c: __do_app(429) > [APP 27043] Event: RESUME State: RUNNING
05-29 11:32:46.041+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connection_state_changed_cb(511) > [Enter]
05-29 11:32:46.041+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connection_state_changed_cb(516) > [beetle] connection state = DISCONNECTED
05-29 11:32:46.051+0900 I/WIFI_EFL(26778): app_main.c: _wifi_manager_scan_start(158) > _wifi_manager_scan_start
05-29 11:32:46.051+0900 I/WIFI_EFL(26778): wifi_manager.c: wifi_manager_scan(503) > Wi-Fi Scan start.
05-29 11:32:46.051+0900 E/CAPI_NETWORK_WIFI(26778): net_wifi.c: wifi_scan(211) > Wi-Fi scan failed
05-29 11:32:46.051+0900 E/WIFI_EFL(26778): app_main.c: __wifi_manager_scan_start(384) > wifi_manager_scan() is failed. error = OPERATION_FAILED
05-29 11:32:46.051+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connection_state_changed_cb(511) > [Enter]
05-29 11:32:46.051+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connection_state_changed_cb(516) > [Jun] connection state = ASSOCIATION
05-29 11:32:46.111+0900 E/CAPI_NETWORK_WECONN(26778): <weconn_get_service_state:589> Failed to request (GDBus.Error:org.freedesktop.DBus.Error.UnknownMethod: No such interface `net.weconn.Technology' on object at path /net/weconn/technology/bluetooth)
05-29 11:32:46.111+0900 E/WIFI_EFL(26778): wifi_manager.c: wifi_manager_is_mobile_connected_via_bluetooth(1317) > is_mobile_connected_via_bluetooth() is failed. error = -5
05-29 11:32:46.176+0900 I/CAPI_NETWORK_WIFI(26778): libnetwork.c: __libnet_update_profile_iterator(227) > Wi-Fi profile count: 15
05-29 11:32:46.176+0900 I/CAPI_NETWORK_WIFI(26778): net_wifi.c: wifi_get_connected_ap(226) > Connected AP 0x456060d8, rv 0
05-29 11:32:46.241+0900 I/MALI    (26778): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x433908f0] swap changed from sync to async
05-29 11:32:46.296+0900 I/WIFI_EFL(26778): app_main.c: _scan_scroll_to_top_for_idle(498) > [Enter]
05-29 11:32:46.296+0900 I/WIFI_EFL(26778): app_main.c: _scan_scroll_to_top_for_idle(498) > [Enter]
05-29 11:32:46.296+0900 I/CAPI_NETWORK_WIFI(26778): libnetwork.c: __libnet_evt_cb(694) > state: CONFIGURATION
05-29 11:32:46.321+0900 I/CAPI_NETWORK_WIFI(26778): libnetwork.c: __libnet_evt_cb(622) > Connection open error NONE
05-29 11:32:46.321+0900 I/CAPI_NETWORK_WIFI(26778): libnetwork.c: _wifi_libnet_check_profile_name_validity(1135) > The profile is a hidden or not a regular Wi-Fi profile
05-29 11:32:46.371+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connection_state_changed_cb(511) > [Enter]
05-29 11:32:46.371+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connection_state_changed_cb(516) > [Jun] connection state = CONFIGURATION
05-29 11:32:46.391+0900 I/WIFI_EFL(26778): layout_scan.c: layout_scan_ap_list_item_move_to_top(425) > Top item skip.
05-29 11:32:46.391+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connected_cb(1273) > [Enter]
05-29 11:32:46.391+0900 I/WIFI_EFL(26778): app_main.c: __scan_ap_item_update_last_connection_error(986) > [Jun] update last error.
05-29 11:32:46.411+0900 I/WIFI_EFL(26778): wifi_manager.c: _update_wifi_config_list(179) > [Enter]
05-29 11:32:46.501+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:46.621+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:32:46.631+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 27043
05-29 11:32:46.636+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 11:32:46.681+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:46.696+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:46.756+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:46.806+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:46.846+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:46.956+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:46.971+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:46.971+0900 I/AUL_PAD (27116): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 11:32:47.056+0900 I/CAPI_NETWORK_CONNECTION(26212): libnetwork.c: __libnet_evt_cb(486) > State changed IND
05-29 11:32:47.056+0900 I/CAPI_NETWORK_CONNECTION(26212): libnetwork.c: __libnet_evt_cb(494) > state: CONNECTED
05-29 11:32:47.151+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:47.166+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:47.231+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:47.336+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connection_state_changed_cb(511) > [Enter]
05-29 11:32:47.336+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connection_state_changed_cb(516) > [Jun] connection state = CONNECTED
05-29 11:32:47.381+0900 I/WIFI_EFL(26778): layout_scan.c: layout_scan_ap_list_item_move_to_top(425) > Top item skip.
05-29 11:32:47.406+0900 E/CAPI_NETWORK_WECONN(26778): <weconn_get_service_state:589> Failed to request (GDBus.Error:org.freedesktop.DBus.Error.UnknownMethod: No such interface `net.weconn.Technology' on object at path /net/weconn/technology/bluetooth)
05-29 11:32:47.406+0900 E/WIFI_EFL(26778): wifi_manager.c: wifi_manager_is_mobile_connected_via_bluetooth(1317) > is_mobile_connected_via_bluetooth() is failed. error = -5
05-29 11:32:47.571+0900 I/CAPI_NETWORK_WIFI(26778): libnetwork.c: __libnet_update_profile_iterator(227) > Wi-Fi profile count: 13
05-29 11:32:47.571+0900 I/CAPI_NETWORK_WIFI(26778): net_wifi.c: wifi_get_connected_ap(226) > Connected AP 0x4411e000, rv 0
05-29 11:32:47.691+0900 I/WIFI_EFL(26778): app_main.c: _scan_scroll_to_top_for_idle(498) > [Enter]
05-29 11:32:47.691+0900 I/WIFI_EFL(26778): app_main.c: _scan_scroll_to_top_for_idle(498) > [Enter]
05-29 11:32:47.696+0900 I/CAPI_NETWORK_WIFI(26778): libnetwork.c: __libnet_evt_cb(694) > state: CONNECTED
05-29 11:32:47.751+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_background_scan_cb(576) > [Enter]
05-29 11:32:47.846+0900 I/CAPI_NETWORK_WIFI(26778): libnetwork.c: __libnet_update_profile_iterator(227) > Wi-Fi profile count: 13
05-29 11:32:47.846+0900 I/WIFI_EFL(26778): wifi_manager.c: __update_ap_list_foreach(316) > EAP type AP skip(No SIM model).
05-29 11:32:47.846+0900 I/WIFI_EFL(26778): wifi_manager.c: __update_ap_list_foreach(316) > EAP type AP skip(No SIM model).
05-29 11:32:47.846+0900 I/WIFI_EFL(26778): wifi_manager.c: __update_ap_list_foreach(316) > EAP type AP skip(No SIM model).
05-29 11:32:47.846+0900 I/WIFI_EFL(26778): wifi_manager.c: __update_ap_list_foreach(316) > EAP type AP skip(No SIM model).
05-29 11:32:47.846+0900 I/WIFI_EFL(26778): wifi_manager.c: __update_ap_list_foreach(316) > EAP type AP skip(No SIM model).
05-29 11:32:47.846+0900 I/WIFI_EFL(26778): layout_scan.c: layout_scan_ap_list_update(465) > [Enter]
05-29 11:32:47.846+0900 I/WIFI_EFL(26778): layout_scan.c: _ap_list_update_ap_items(273) > [Enter]
05-29 11:32:47.851+0900 I/WIFI_EFL(26778): layout_scan.c: _ap_list_update_ap_items(293) > ap list update items count 8.
05-29 11:32:47.851+0900 E/WIFI_EFL(26778): layout_scan.c: _layout_content_change(154) > 'self->state != state' failed.
05-29 11:32:47.851+0900 E/WIFI_EFL(26778): layout_scan.c: layout_scan_ap_list_show(404) > '!_is_in_naviframe(self)' failed.
05-29 11:32:47.851+0900 I/efl-extension(26778): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x455d29f0, elm_image, _activated_obj : 0x455d29f0, activated : 1
05-29 11:32:47.851+0900 I/WIFI_EFL(26778): wifi_manager.c: _update_wifi_config_list(179) > [Enter]
05-29 11:32:47.936+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:47.986+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:48.001+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:48.076+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:48.146+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:48.221+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:48.371+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:48.396+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:48.721+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:48.746+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:48.881+0900 E/CAPI_NETWORK_WIFI(26778): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
05-29 11:32:48.976+0900 W/APP_CORE(27043): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:5a00006
05-29 11:32:48.976+0900 I/APP_CORE(27043): appcore-efl.c: __do_app(429) > [APP 27043] Event: PAUSE State: RUNNING
05-29 11:32:48.976+0900 I/CAPI_APPFW_APPLICATION(27043): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 11:32:48.981+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 11:32:48.981+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 11:32:48.981+0900 E/APP_CORE(27043): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 11:32:49.021+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connection_state_changed_cb(511) > [Enter]
05-29 11:32:49.021+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_connection_state_changed_cb(516) > [Jun] connection state = CONNECTED
05-29 11:32:49.041+0900 I/WIFI_EFL(26778): layout_scan.c: layout_scan_ap_list_item_move_to_top(425) > Top item skip.
05-29 11:32:49.056+0900 E/CAPI_NETWORK_WECONN(26778): <weconn_get_service_state:589> Failed to request (GDBus.Error:org.freedesktop.DBus.Error.UnknownMethod: No such interface `net.weconn.Technology' on object at path /net/weconn/technology/bluetooth)
05-29 11:32:49.056+0900 E/WIFI_EFL(26778): wifi_manager.c: wifi_manager_is_mobile_connected_via_bluetooth(1317) > is_mobile_connected_via_bluetooth() is failed. error = -5
05-29 11:32:49.126+0900 I/APP_CORE(27043): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 11:32:49.126+0900 I/CAPI_APPFW_APPLICATION(27043): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-29 11:32:49.131+0900 I/CAPI_NETWORK_WIFI(26778): libnetwork.c: __libnet_update_profile_iterator(227) > Wi-Fi profile count: 13
05-29 11:32:49.131+0900 I/CAPI_NETWORK_WIFI(26778): net_wifi.c: wifi_get_connected_ap(226) > Connected AP 0x45631890, rv 0
05-29 11:32:49.201+0900 I/UXT     (27043): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 11:32:49.276+0900 I/MALI    (26778): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x433908f0] swap changed from async to sync
05-29 11:32:49.286+0900 I/WIFI_EFL(26778): app_main.c: _scan_scroll_to_top_for_idle(498) > [Enter]
05-29 11:32:49.331+0900 I/efl-extension(27043): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 11:32:49.611+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 27043
05-29 11:32:49.996+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-29 11:32:50.016+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-29 11:32:50.081+0900 E/RESOURCED(  488): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 466
05-29 11:32:50.096+0900 E/ALARM_MANAGER(  466): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aweconn] : Alarm id [1113048248]
05-29 11:32:50.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_expired(1322) > alarm_id[1113048248] is expired.
05-29 11:32:50.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1113048248)
05-29 11:32:50.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 11:32:50.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 02:35:33 (UTC).
05-29 11:32:50.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 11:32:50.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-29 11:32:50.131+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-29 11:32:50.131+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 11:32:50.131+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 11:32:50.131+0900 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2203) > Unable to delete the alarm! alarm_id[1113048248], return_code[-9]
05-29 11:32:50.151+0900 W/WECONN  (  466): <__wc_control_waiting_bt_connected_cb:542> sap is already connected
05-29 11:32:50.151+0900 W/WECONN  (  466): <__wc_control_waiting_bt_connected_cb:544> scs bearer changed
05-29 11:32:50.151+0900 W/WECONN  (  466): <__wifi_service_set_state:44> wifi state is changed(3)
05-29 11:32:50.986+0900 W/AUL_AMD (  487): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-29 11:32:56.086+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), block(1)
05-29 11:32:56.086+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), ev->cur.canvas.x(113) ev->cur.canvas.y(204)
05-29 11:32:56.086+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), hold(0) freeze(0)
05-29 11:32:56.086+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), block(1)
05-29 11:32:56.086+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), ev->cur.canvas.x(114) ev->cur.canvas.y(201)
05-29 11:32:56.086+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), hold(0) freeze(0)
05-29 11:32:56.106+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), block(1)
05-29 11:32:56.106+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), ev->cur.canvas.x(114) ev->cur.canvas.y(202)
05-29 11:32:56.106+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), hold(0) freeze(0)
05-29 11:32:56.106+0900 E/EFL     (26778): evas_main<26778> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=8563847 button=1 downs=1
05-29 11:32:56.116+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), block(1)
05-29 11:32:56.116+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), ev->cur.canvas.x(114) ev->cur.canvas.y(204)
05-29 11:32:56.116+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), hold(0) freeze(0)
05-29 11:32:56.131+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3966 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), block(1)
05-29 11:32:56.131+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3980 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), ev->cur.canvas.x(113) ev->cur.canvas.y(205)
05-29 11:32:56.131+0900 E/EFL     (26778): elementary<26778> elm_interface_scrollable.c:3981 _elm_scroll_mouse_move_event_cb() [DDO] obj(453cd2b8), hold(0) freeze(0)
05-29 11:32:56.141+0900 E/EFL     (26778): evas_main<26778> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=8563880 button=1 downs=0
05-29 11:32:56.161+0900 I/WIFI_EFL(26778): app_main.c: __scan_menu_ap_item_tap_cb(3619) > [Enter]
05-29 11:32:56.191+0900 I/WIFI_EFL(26778): app_main.c: __scan_menu_ap_item_tap_cb(3628) > Connected AP
05-29 11:32:56.191+0900 I/WIFI_EFL(26778): app_main.c: _is_removable_ap(957) > [Jun] is removable ap.(security type enum value is 2)
05-29 11:32:56.191+0900 I/WIFI_EFL(26778): app_main.c: _detail_create(1032) > [Enter]
05-29 11:32:56.201+0900 I/efl-extension(26778): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 11:32:56.201+0900 I/efl-extension(26778): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4418a0a0, elm_image, _activated_obj : 0x455d29f0, activated : 1
05-29 11:32:56.201+0900 I/efl-extension(26778): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 11:32:56.281+0900 I/efl-extension(26778): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x45606fc0]'s widget[0x45602b80] to layout widget[0x455928a8]
05-29 11:32:56.286+0900 I/efl-extension(26778): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x45606fc0 = w: 0 h: 0  obj 0x45602b80 w: 360 h: 360
05-29 11:32:56.291+0900 I/efl-extension(26778): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 11:32:56.781+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.781+0900 I/efl-extension(25202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.791+0900 I/efl-extension(26778): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.791+0900 I/efl-extension(26778): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4418a0a0, elm_image, time_stamp : 8564522
05-29 11:32:56.851+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.851+0900 I/efl-extension(25202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.861+0900 I/efl-extension(26778): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.861+0900 I/efl-extension(26778): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4418a0a0, elm_image, time_stamp : 8564591
05-29 11:32:56.886+0900 I/efl-extension(25202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.886+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.886+0900 I/efl-extension(26778): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.886+0900 I/efl-extension(26778): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4418a0a0, elm_image, time_stamp : 8564624
05-29 11:32:56.931+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.936+0900 I/efl-extension(25202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.941+0900 I/efl-extension(26778): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.941+0900 I/efl-extension(26778): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4418a0a0, elm_image, time_stamp : 8564673
05-29 11:32:56.981+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.981+0900 I/efl-extension(25202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.996+0900 I/efl-extension(26778): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:56.996+0900 I/efl-extension(26778): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4418a0a0, elm_image, time_stamp : 8564721
05-29 11:32:57.031+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.031+0900 I/efl-extension(25202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.031+0900 I/efl-extension(26778): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.031+0900 I/efl-extension(26778): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4418a0a0, elm_image, time_stamp : 8564769
05-29 11:32:57.086+0900 I/efl-extension(25202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.086+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.086+0900 I/efl-extension(26778): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.086+0900 I/efl-extension(26778): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4418a0a0, elm_image, time_stamp : 8564824
05-29 11:32:57.136+0900 I/efl-extension(25202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.136+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.141+0900 I/efl-extension(26778): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.141+0900 I/efl-extension(26778): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4418a0a0, elm_image, time_stamp : 8564877
05-29 11:32:57.221+0900 I/efl-extension(25202): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.221+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.221+0900 I/efl-extension(26778): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 11:32:57.221+0900 I/efl-extension(26778): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x4418a0a0, elm_image, time_stamp : 8564960
05-29 11:33:01.986+0900 E/DBG_PAD ( 2829): discovery.c: _discovery_thread(74) > Unknown packet, 5
05-29 11:33:01.986+0900 E/DBG_PAD ( 2829): 192.168.43.152:26101
05-29 11:33:01.986+0900 E/DBG_PAD ( 2829): ,23
05-29 11:33:03.816+0900 I/WIFI_EFL(26778): app_main.c: __wifi_manager_background_scan_cb(576) > [Enter]
05-29 11:33:03.991+0900 I/CAPI_NETWORK_WIFI(26778): libnetwork.c: __libnet_update_profile_iterator(227) > Wi-Fi profile count: 14
05-29 11:33:03.991+0900 I/WIFI_EFL(26778): wifi_manager.c: __update_ap_list_foreach(316) > EAP type AP skip(No SIM model).
05-29 11:33:03.991+0900 I/WIFI_EFL(26778): wifi_manager.c: __update_ap_list_foreach(316) > EAP type AP skip(No SIM model).
05-29 11:33:03.991+0900 I/WIFI_EFL(26778): wifi_manager.c: __update_ap_list_foreach(316) > EAP type AP skip(No SIM model).
05-29 11:33:03.991+0900 I/WIFI_EFL(26778): wifi_manager.c: __update_ap_list_foreach(316) > EAP type AP skip(No SIM model).
05-29 11:33:03.991+0900 I/WIFI_EFL(26778): wifi_manager.c: __update_ap_list_foreach(316) > EAP type AP skip(No SIM model).
05-29 11:33:03.991+0900 I/WIFI_EFL(26778): layout_scan.c: layout_scan_ap_list_update(465) > [Enter]
05-29 11:33:03.991+0900 I/WIFI_EFL(26778): layout_scan.c: _ap_list_update_ap_items(273) > [Enter]
05-29 11:33:04.021+0900 I/WIFI_EFL(26778): layout_scan.c: _ap_list_update_ap_items(293) > ap list update items count 9.
05-29 11:33:04.021+0900 E/WIFI_EFL(26778): layout_scan.c: _layout_content_change(154) > 'self->state != state' failed.
05-29 11:33:04.021+0900 E/WIFI_EFL(26778): layout_scan.c: layout_scan_ap_list_show(404) > '!_is_in_naviframe(self)' failed.
05-29 11:33:04.206+0900 E/CAPI_SYSTEM_INFO( 2835): system_info_parse.c: system_info_get_value_from_config_xml(279) > cannot find tizen.org/feature/container field from /etc/config/model-config.xml file!!!
05-29 11:33:04.206+0900 E/CAPI_SYSTEM_INFO( 2835): system_info.c: system_info_get_platform_bool(293) > cannot get tizen.org/feature/container
05-29 11:33:08.696+0900 I/HealthDataService( 1059): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-29 11:33:08.746+0900 I/healthData( 1036): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-29 11:33:11.626+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 11:33:11.626+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 11:33:11.626+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 11:33:11.626+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 1
05-29 11:33:11.626+0900 W/W_HOME  (  714): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 11:33:11.626+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 11:33:11.626+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-29 11:33:11.626+0900 W/STARTER (  682): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 11:33:11.631+0900 E/STARTER (  682): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 11:33:11.631+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 11:33:11.631+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 11:33:11.696+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 11:33:11.696+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 11:33:11.696+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 11:33:11.701+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 11:33:11.706+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 11:33:11.706+0900 W/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 11:33:11.706+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 11:33:11.706+0900 I/HIGEAR  ( 1102): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 11:33:11.731+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 11:33:11.731+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 11:33:11.731+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 11:33:11.731+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 11:33:11.741+0900 I/APP_CORE(26778): appcore-efl.c: __do_app(429) > [APP 26778] Event: PAUSE State: RUNNING
05-29 11:33:11.741+0900 I/CAPI_APPFW_APPLICATION(26778): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 11:33:11.741+0900 I/WIFI_EFL(26778): app_main.c: app_pause(4335) > [Enter]
05-29 11:33:11.741+0900 I/WIFI_EFL(26778): wifi_manager.c: wifi_manager_set_scan_mode(531) > Wi-Fi Scan mode 0.
05-29 11:33:11.746+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 11:33:11.746+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 11:33:11.761+0900 E/ALARM_MANAGER(  682): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 11:33:32), repeat(1), interval(20), type(-1073741822)
05-29 11:33:11.766+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 11:33:11.771+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 11:33:11.771+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 11:33:11.846+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1794022311, next duetime: 1464489212
05-29 11:33:11.846+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1794022311)
05-29 11:33:11.846+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464489333), due_time(1464489212)
05-29 11:33:11.846+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 11:33:11.846+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 02:33:32 (UTC).
05-29 11:33:11.846+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 11:33:16.751+0900 E/PKGMGR_SERVER(27247): pkgmgr-server.c: main(2131) > package manager server start
05-29 11:33:16.861+0900 E/PKGMGR_SERVER(27247): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_-162117073], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[frYN28iEJQhZX01c/VRBwzv+mxQ=], backend_flag=[0]
05-29 11:33:16.871+0900 E/PKGMGR_SERVER(27248): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-29 11:33:16.876+0900 E/PKGMGR  (27245): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-29 11:33:16.961+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:33:16.971+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26212
05-29 11:33:16.971+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 11:33:16.976+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 5
05-29 11:33:16.981+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(26212), cmd(4)
05-29 11:33:16.981+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:33:16.986+0900 I/APP_CORE(26212): appcore-efl.c: __do_app(429) > [APP 26212] Event: TERMINATE State: PAUSED
05-29 11:33:16.991+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26212
05-29 11:33:16.996+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 11:33:16.996+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 11:33:17.031+0900 I/APP_CORE(26778): appcore-efl.c: __do_app(429) > [APP 26778] Event: MEM_FLUSH State: PAUSED
05-29 11:33:17.061+0900 I/APP_CORE(26212): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 11:33:17.061+0900 I/CAPI_APPFW_APPLICATION(26212): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44318d30 is freed
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44cd7630 is freed
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44c91ce0 is freed
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4436a1a0 is freed
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4435c7a8 is freed
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4641d608 is freed
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4431fda8 is freed
05-29 11:33:17.086+0900 I/efl-extension(26212): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44c6c4f0 is freed
05-29 11:33:17.096+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:33:17.106+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26212
05-29 11:33:17.111+0900 I/MALI    (26212): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 11:33:17.111+0900 I/MALI    (26212): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=26212   close drm_fd=25 
05-29 11:33:17.111+0900 I/MALI    (26212): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 11:33:17.151+0900 I/UXT     (26212): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 11:33:17.211+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:33:17.226+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26212
05-29 11:33:17.331+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:33:17.406+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26212
05-29 11:33:17.506+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:33:17.541+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26212
05-29 11:33:17.646+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:33:17.656+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26212
05-29 11:33:17.761+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:33:17.771+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 11:33:17.781+0900 E/PKGMGR_SERVER(27248): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-29 11:33:17.796+0900 E/PKGMGR_SERVER(27247): pkgmgr-server.c: sighandler(409) > child NORMAL exit [27248]
05-29 11:33:17.876+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 23
05-29 11:33:17.876+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 11:33:17.876+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 26212
05-29 11:33:17.876+0900 W/AUL_AMD (  487): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-29 11:33:17.891+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 26212
05-29 11:33:17.891+0900 E/AUL     (27260): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-29 11:33:17.941+0900 W/CRASH_MANAGER(27257): worker.c: worker_job(1199) > 1126212706831146448919
