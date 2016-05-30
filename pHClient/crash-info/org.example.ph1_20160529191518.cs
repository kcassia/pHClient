S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 3088
Date: 2016-05-29 19:15:18+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x404a0250, r3   = 0x00000000
r4   = 0xbee8a648, r5   = 0x44c68d08
r6   = 0x40002238, r7   = 0x00000000
r8   = 0x44c67688, r9   = 0x44052c38
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4008d490, sp   = 0xbee8a638
lr   = 0x403e91e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     31252 KB
Buffers:     33116 KB
Cached:     113256 KB
VmPeak:     108260 KB
VmSize:      98992 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22328 KB
VmRSS:       22328 KB
VmData:      44488 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       49712 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3088 TID = 3088
3088 3096 3099 3184 

Maps Information
40000000 40008000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
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
410c4000 410c7000 r-xp /usr/lib/libXfixes.so.3.1.0
410ce000 410cf000 rwxp /usr/lib/libXfixes.so.3.1.0
410cf000 410d0000 r-xp /usr/lib/libXinerama.so.1.0.0
410d8000 410d9000 rwxp /usr/lib/libXinerama.so.1.0.0
410d9000 410df000 r-xp /usr/lib/libXrandr.so.2.2.0
410e6000 410e7000 rwxp /usr/lib/libXrandr.so.2.2.0
410e7000 410ed000 r-xp /usr/lib/libXrender.so.1.3.0
410f4000 410f5000 rwxp /usr/lib/libXrender.so.1.3.0
410f5000 410f9000 r-xp /usr/lib/libXtst.so.6.1.0
41100000 41101000 rwxp /usr/lib/libXtst.so.6.1.0
41101000 4110b000 r-xp /usr/lib/libXext.so.6.4.0
41113000 41114000 rwxp /usr/lib/libXext.so.6.4.0
41115000 4111a000 r-xp /usr/lib/libecore_fb.so.1.7.99
41121000 41123000 rwxp /usr/lib/libecore_fb.so.1.7.99
41123000 41127000 r-xp /usr/lib/libecore_ipc.so.1.7.99
4112f000 41130000 rwxp /usr/lib/libecore_ipc.so.1.7.99
41130000 41133000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4113a000 4113b000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
4113b000 41151000 r-xp /lib/libexpat.so.1.5.2
41159000 4115b000 rwxp /lib/libexpat.so.1.5.2
4115b000 4116d000 r-xp /usr/lib/libtts.so
41174000 41175000 rwxp /usr/lib/libtts.so
41176000 41197000 r-xp /usr/lib/libui-extension.so.0.1.0
4119f000 411a0000 rwxp /usr/lib/libui-extension.so.0.1.0
411a0000 411a7000 r-xp /usr/lib/libtbm.so.1.0.0
411ae000 411af000 rwxp /usr/lib/libtbm.so.1.0.0
411af000 411b6000 r-xp /usr/lib/libembryo.so.1.7.99
411bd000 411be000 rwxp /usr/lib/libembryo.so.1.7.99
411be000 411d5000 r-xp /usr/lib/liblua-5.1.so
411dd000 411de000 rwxp /usr/lib/liblua-5.1.so
411de000 411df000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
411e6000 411e7000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
411e8000 411f6000 r-xp /usr/lib/libGLESv2.so.2.0
411fe000 411ff000 rwxp /usr/lib/libGLESv2.so.2.0
411ff000 41217000 r-xp /usr/lib/libpng12.so.0.50.0
4121e000 4121f000 rwxp /usr/lib/libpng12.so.0.50.0
4121f000 41220000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41228000 41229000 rwxp /usr/lib/libxcb-shm.so.0.0.0
41229000 4122f000 r-xp /usr/lib/libxcb-render.so.0.0.0
41236000 41237000 rwxp /usr/lib/libxcb-render.so.0.0.0
41237000 4124a000 r-xp /usr/lib/libxcb.so.1.1.0
41252000 41253000 rwxp /usr/lib/libxcb.so.1.1.0
41253000 41256000 r-xp /usr/lib/libEGL.so.1.4
4125d000 4125e000 rwxp /usr/lib/libEGL.so.1.4
4125f000 41282000 r-xp /usr/lib/libjpeg.so.8.0.2
41289000 4128a000 rwxp /usr/lib/libjpeg.so.8.0.2
4129a000 412de000 r-xp /usr/lib/libcurl.so.4.3.0
412e5000 412e7000 rwxp /usr/lib/libcurl.so.4.3.0
412e7000 412ed000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
412f5000 412f6000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
412f6000 4130e000 r-xp /usr/lib/liblzma.so.5.0.3
41315000 41316000 rwxp /usr/lib/liblzma.so.5.0.3
41317000 41393000 r-xp /usr/lib/libgcrypt.so.20.0.3
4139a000 4139f000 rwxp /usr/lib/libgcrypt.so.20.0.3
4139f000 413a1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
413a9000 413aa000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
413aa000 413ac000 r-xp /usr/lib/journal/libjournal.so.0.1.0
413b3000 413b4000 rwxp /usr/lib/journal/libjournal.so.0.1.0
413b4000 413bc000 r-xp /usr/lib/libmdm-common.so.1.0.89
413bc000 413bd000 rwxp /usr/lib/libmdm-common.so.1.0.89
413be000 414fb000 r-xp /usr/lib/libicui18n.so.51.1
41503000 4150b000 rwxp /usr/lib/libicui18n.so.51.1
4150b000 415ef000 r-xp /usr/lib/libicuuc.so.51.1
415f6000 41600000 rwxp /usr/lib/libicuuc.so.51.1
41604000 41607000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4160e000 4160f000 rwxp /usr/lib/libcapi-media-image-util.so.0.3.5
4160f000 41612000 r-xp /usr/lib/libsmack.so.1.0.0
41619000 4161a000 rwxp /usr/lib/libsmack.so.1.0.0
4161a000 41622000 r-xp /usr/lib/libdrm.so.2.4.0
41629000 4162a000 rwxp /usr/lib/libdrm.so.2.4.0
4162b000 4162d000 r-xp /usr/lib/libXau.so.6.0.0
41634000 41635000 rwxp /usr/lib/libXau.so.6.0.0
41635000 4163e000 r-xp /usr/lib/libcares.so.2.1.0
41646000 41647000 rwxp /usr/lib/libcares.so.2.1.0
41647000 41675000 r-xp /usr/lib/libidn.so.11.5.44
4167c000 4167d000 rwxp /usr/lib/libidn.so.11.5.44
4167d000 416ca000 r-xp /usr/lib/libssl.so.1.0.0
416d1000 416d6000 rwxp /usr/lib/libssl.so.1.0.0
416d6000 4187e000 r-xp /usr/lib/libcrypto.so.1.0.0
4187e000 41893000 rwxp /usr/lib/libcrypto.so.1.0.0
41898000 418a3000 r-xp /usr/lib/libgpg-error.so.0.15.0
418aa000 418ab000 rwxp /usr/lib/libgpg-error.so.0.15.0
418ab000 42e2a000 r-xp /usr/lib/libicudata.so.51.1
42e31000 42e32000 rwxp /usr/lib/libicudata.so.51.1
42e32000 42e37000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42e3f000 42e40000 rwxp /usr/lib/libmmutil_jpeg.so.0.0.0
42e40000 42e45000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42e4c000 42e4d000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
42e4e000 42e50000 r-xp /usr/lib/libdri2.so.0.0.0
42e57000 42e58000 rwxp /usr/lib/libdri2.so.0.0.0
42e58000 42e79000 r-xp /usr/lib/libexif.so.12.3.3
42e80000 42e8c000 rwxp /usr/lib/libexif.so.12.3.3
42e8c000 42e91000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
42e98000 42e99000 rwxp /usr/lib/libcapi-media-tool.so.0.1.5
42fa0000 4306a000 r-xp /usr/lib/libCOREGL.so.4.0
43072000 43074000 rwxp /usr/lib/libCOREGL.so.4.0
4307c000 430a0000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
430a7000 430a9000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
430a9000 43178000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4317f000 4318e000 rwxp /usr/lib/libscim-1.0.so.8.2.3
4318e000 431bb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
431c2000 431c3000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
431c3000 431e0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
431e8000 431e9000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
431e9000 431eb000 r-xp /usr/lib/libiri.so
431f2000 431f3000 rwxp /usr/lib/libiri.so
431f3000 431f6000 r-xp /lib/libcap.so.2.21
431fd000 431fe000 rwxp /lib/libcap.so.2.21
431fe000 43205000 r-xp /lib/libcrypt-2.13.so
4320c000 4320d000 r-xp /lib/libcrypt-2.13.so
4320d000 4320e000 rwxp /lib/libcrypt-2.13.so
43235000 43238000 r-xp /lib/libattr.so.1.1.0
4323f000 43240000 rwxp /lib/libattr.so.1.1.0
43240000 4324a000 r-xp /lib/libnss_files-2.13.so
43251000 43252000 r-xp /lib/libnss_files-2.13.so
43252000 43253000 rwxp /lib/libnss_files-2.13.so
43253000 43453000 r-xp /usr/share/locale/locale-archive
43453000 43584000 r-xp /usr/share/locale/locale-archive
4360b000 43753000 r-xp /usr/lib/egl/libMali.so
43753000 43758000 rwxp /usr/lib/egl/libMali.so
43759000 4376d000 rwxp [stack:3096]
4376d000 43770000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43777000 43778000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b4000 440b6000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44384000 44b83000 rwxp [stack:3184]
44b83000 44b86000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44b86000 44b8a000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44b8a000 44b99000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
4560b000 45e0a000 rwxp [stack:3099]
bee6a000 bee8b000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3088)
Call Stack Count: 2
 0: cfree + 0xc8 (0x403e91e8) [/lib/libc.so.6] + 0x6f1e8
 1: (0x20) (null)
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
d: 3612
05-29 19:15:17.183+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 19:15:17.293+0900 E/EFL     ( 3612): elementary<3612> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(45209e48), freeze(1)
05-29 19:15:17.293+0900 E/EFL     ( 3612): elementary<3612> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(45209e48), freeze(1)
05-29 19:15:17.608+0900 I/efl-extension( 3646): efl_extension.c: eext_mod_init(40) > Init
05-29 19:15:17.658+0900 I/UXT     ( 3646): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-29 19:15:17.668+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:15:17.678+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1797
05-29 19:15:17.678+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 27
05-29 19:15:17.698+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:15:17.703+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3088
05-29 19:15:17.708+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 27
05-29 19:15:17.708+0900 I/APP_CORE( 3088): appcore-efl.c: __do_app(429) > [APP 3088] Event: TERMINATE State: PAUSED
05-29 19:15:17.708+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 19:15:17.708+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.728+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.733+0900 I/APP_CORE( 1797): appcore-efl.c: __do_app(429) > [APP 1797] Event: TERMINATE State: PAUSED
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.733+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-29 19:15:17.738+0900 E/APP_CORE( 3612): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 19:15:17.738+0900 I/APP_CORE( 3612): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 19:15:17.738+0900 I/APP_CORE( 3612): appcore-efl.c: __after_loop(1090) > [APP 3612] PAUSE before termination
05-29 19:15:17.738+0900 I/CAPI_APPFW_APPLICATION( 3612): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 19:15:17.738+0900 I/CAPI_APPFW_APPLICATION( 3612): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-29 19:15:17.738+0900 I/efl-extension( 3612): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45209e48, obj: 0x45209e48
05-29 19:15:17.738+0900 I/efl-extension( 3612): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 19:15:17.738+0900 I/efl-extension( 3612): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 19:15:17.738+0900 I/efl-extension( 3612): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 19:15:17.738+0900 I/efl-extension( 3612): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 19:15:17.748+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 19:15:17.748+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 19:15:17.748+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 19:15:17.748+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 19:15:17.763+0900 I/efl-extension( 3612): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x45253298
05-29 19:15:17.763+0900 I/efl-extension( 3612): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 19:15:17.768+0900 I/efl-extension( 3612): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4526ebd0 is freed
05-29 19:15:17.768+0900 I/efl-extension( 3612): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:15:17.768+0900 I/efl-extension( 3612): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45209e48, elm_scroller, func : 0x437edef1
05-29 19:15:17.768+0900 I/efl-extension( 3612): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:15:17.768+0900 I/efl-extension( 3612): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:15:17.768+0900 I/efl-extension( 3612): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45253298, elm_image, func : 0x437edef1
05-29 19:15:17.768+0900 I/efl-extension( 3612): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:15:17.768+0900 I/efl-extension( 3612): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x45209e48 : elm_scroller] rotary callabck is deleted
05-29 19:15:17.838+0900 E/APP_CORE( 1797): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 19:15:17.838+0900 I/APP_CORE( 1797): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 19:15:17.838+0900 I/CAPI_APPFW_APPLICATION( 1797): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-29 19:15:17.863+0900 W/APP_CORE( 1468): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:4c00003
05-29 19:15:17.883+0900 I/APP_CORE( 3088): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 19:15:17.883+0900 I/CAPI_APPFW_APPLICATION( 3088): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-29 19:15:17.898+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 19:15:17.898+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 19:15:17.898+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 19:15:17.898+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 19:15:17.898+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 19:15:17.923+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 19:15:17.923+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x453e7fb0], circle_obj[0x4540ea90]!
05-29 19:15:17.923+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x460006f8 = w: 0 h: 0  obj 0x453e7fb0 w: 360 h: 360
05-29 19:15:17.928+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:15:17.928+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44574e80 is freed
05-29 19:15:17.928+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x45a7b340], circle_obj[0x45a65758]!
05-29 19:15:17.928+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x46000780 = w: 0 h: 0  obj 0x45a7b340 w: 360 h: 360
05-29 19:15:17.928+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:15:17.933+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45a914a8 is freed
05-29 19:15:17.933+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x445729d8 is freed
05-29 19:15:17.933+0900 I/efl-extension( 1797): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4456c9b8, obj: 0x4456c9b8
05-29 19:15:17.933+0900 I/efl-extension( 1797): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 19:15:17.953+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 19:15:17.953+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x460006f8 is freed
05-29 19:15:17.953+0900 I/efl-extension( 1797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:15:17.953+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 19:15:17.953+0900 I/efl-extension( 1797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4456c9b8, elm_genlist, func : 0x437c5dfd
05-29 19:15:17.953+0900 I/efl-extension( 1797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:15:17.958+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 19:15:17.958+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 19:15:17.958+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 1
05-29 19:15:17.958+0900 W/W_HOME  (  714): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 19:15:17.958+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:15:17.958+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
05-29 19:15:17.958+0900 W/STARTER (  682): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 19:15:17.958+0900 E/STARTER (  682): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 19:15:17.958+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 19:15:17.958+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 19:15:17.968+0900 E/CAPI_NETWORK_BLUETOOTH( 1797): bluetooth-adapter.c: bt_adapter_unset_state_changed_cb(842) > [bt_adapter_unset_state_changed_cb] NOT_INITIALIZED(0xfe400101)
05-29 19:15:17.968+0900 I/efl-extension( 1797): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x453e7fb0, , _activated_obj : 0x45a7b340, activated : 1
05-29 19:15:17.968+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 19:15:17.968+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 19:15:17.968+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 19:15:17.968+0900 I/efl-extension( 1797): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 19:15:17.973+0900 I/efl-extension( 1797): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4541c848, obj: 0x4541c848
05-29 19:15:17.973+0900 I/efl-extension( 1797): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 19:15:17.973+0900 I/efl-extension( 1797): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 19:15:17.973+0900 I/efl-extension( 1797): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 19:15:17.973+0900 I/efl-extension( 1797): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 19:15:17.988+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 19:15:17.988+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 19:15:17.988+0900 I/efl-extension( 1797): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x46000780 is freed
05-29 19:15:17.993+0900 I/efl-extension( 1797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:15:17.993+0900 I/efl-extension( 1797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4541c848, elm_genlist, func : 0x437c5dfd
05-29 19:15:17.993+0900 I/efl-extension( 1797): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:15:17.993+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 19:15:17.993+0900 W/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 19:15:17.993+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 19:15:17.993+0900 I/HIGEAR  ( 1102): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 19:15:18.073+0900 I/MALI    ( 3612): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x41d4c238] swap changed from sync to async
05-29 19:15:18.073+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 19:15:18.083+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 19:15:18.083+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 19:15:18.098+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
05-29 19:15:18.098+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 19:15:18.098+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 19:15:18.098+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 19:15:18.118+0900 W/PROCESSMGR(  382): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-29 19:15:18.118+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-29 19:15:18.118+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-29 19:15:18.118+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 19:15:18.118+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 19:15:18.118+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 19:15:18.128+0900 E/ALARM_MANAGER(  682): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 19:15:38), repeat(1), interval(20), type(-1073741822)
05-29 19:15:18.138+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 19:15:18.138+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:15:18.138+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:15:18.138+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 19:15:18.153+0900 I/efl-extension( 3088): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 19:15:18.153+0900 I/efl-extension( 3088): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x466047c0 is freed
05-29 19:15:18.153+0900 I/efl-extension( 3088): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 19:15:18.153+0900 I/efl-extension( 3088): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44c72b08 is freed
05-29 19:15:18.153+0900 I/efl-extension( 3088): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44c6a210 is freed
05-29 19:15:18.153+0900 I/efl-extension( 3088): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44c51c68 is freed
05-29 19:15:18.163+0900 I/MALI    ( 1797): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 19:15:18.163+0900 I/MALI    ( 1797): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=1797   close drm_fd=22 
05-29 19:15:18.163+0900 I/MALI    ( 1797): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 19:15:18.208+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 272856716, next duetime: 1464516938
05-29 19:15:18.208+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(272856716)
05-29 19:15:18.208+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464517601), due_time(1464516938)
05-29 19:15:18.208+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 19:15:18.213+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 10:15:38 (UTC).
05-29 19:15:18.213+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 19:15:18.233+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 19:15:18.233+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 19:15:18.238+0900 E/APP_CORE( 1468): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 19:15:18.238+0900 I/APP_CORE( 1468): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 19:15:18.238+0900 I/CAPI_APPFW_APPLICATION( 1468): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-29 19:15:18.238+0900 I/WIFI_EFL( 1468): app_main.c: app_terminate(4453) > [Enter]
05-29 19:15:18.238+0900 I/WIFI_EFL( 1468): app_main.c: _app_release(4193) > [Enter]
05-29 19:15:18.238+0900 E/WIFI_EFL( 1468): idler.c: idler_util_managed_idle_cleanup(68) > 'managed_idler_list != NULL' failed.
05-29 19:15:18.238+0900 E/WIFI_EFL( 1468): wifi_manager.c: wifi_manager_ap_destroy(779) > 'ap_obj != NULL' failed.
05-29 19:15:18.263+0900 I/MALI    ( 3612): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 19:15:18.263+0900 I/MALI    ( 3612): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3612   close drm_fd=22 
05-29 19:15:18.268+0900 I/MALI    ( 3612): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 19:15:18.308+0900 I/MALI    ( 3088): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 19:15:18.313+0900 I/MALI    ( 3088): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3088   close drm_fd=25 
05-29 19:15:18.313+0900 I/MALI    ( 3088): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 19:15:18.338+0900 I/CAPI_NETWORK_WIFI( 1468): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
05-29 19:15:18.343+0900 E/CAPI_NETWORK_WIFI( 1468): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 19:15:18.343+0900 E/CAPI_NETWORK_WIFI( 1468): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 19:15:18.343+0900 E/CAPI_NETWORK_WIFI( 1468): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 19:15:18.343+0900 E/CAPI_NETWORK_WIFI( 1468): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 19:15:18.343+0900 E/CAPI_NETWORK_WIFI( 1468): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 19:15:18.343+0900 E/CAPI_NETWORK_WIFI( 1468): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 19:15:18.343+0900 E/CAPI_NETWORK_WIFI( 1468): net_wifi_ap.c: wifi_ap_destroy(240) > Invalid parameter
05-29 19:15:18.343+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: eext_circle_surface_del(1362) > Surface[0x44bb7410] is going to free in eext_circle_surface_del API.
05-29 19:15:18.343+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x44019608], circle_obj[0x4400bf98]!
05-29 19:15:18.343+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x4565c160 = w: 0 h: 0  obj 0x44019608 w: 360 h: 360
05-29 19:15:18.373+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:15:18.373+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44bc1b38 is freed
05-29 19:15:18.378+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x455e4830], circle_obj[0x455d9e08]!
05-29 19:15:18.383+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x454c2410 = w: 0 h: 0  obj 0x455e4830 w: 360 h: 360
05-29 19:15:18.383+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:15:18.383+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x455ef4d8 is freed
05-29 19:15:18.383+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44bb7410 is freed
05-29 19:15:18.383+0900 I/WIFI_EFL( 1468): app_main.c: __main_del_cb(3767) > [Enter]
05-29 19:15:18.388+0900 I/CAPI_APPFW_APPLICATION( 1468): app_main.c: app_efl_exit(145) > app_efl_exit
05-29 19:15:18.388+0900 I/efl-extension( 1468): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44bb3e00, obj: 0x44bb3e00
05-29 19:15:18.388+0900 I/efl-extension( 1468): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 19:15:18.418+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 19:15:18.418+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4565c160 is freed
05-29 19:15:18.418+0900 I/efl-extension( 1468): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:15:18.423+0900 I/efl-extension( 1468): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44bb3e00, elm_genlist, func : 0x417f9dfd
05-29 19:15:18.423+0900 I/efl-extension( 1468): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:15:18.423+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 19:15:18.428+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:15:18.428+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:15:18.433+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:15:18.433+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 19:15:18.443+0900 I/UXT     ( 3612): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 19:15:18.443+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 19:15:18.448+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 19:15:18.448+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:15:18.448+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 19:15:18.448+0900 I/WIFI_EFL( 1468): app_main.c: __scan_del_cb(1071) > [Enter]
05-29 19:15:18.448+0900 I/APP_CORE(  714): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 19:15:18.448+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 19:15:18.448+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 19:15:18.448+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1692) > Do the postponed update job.
05-29 19:15:18.448+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: PAUSE State: PAUSED
05-29 19:15:18.448+0900 I/CAPI_APPFW_APPLICATION( 1468): app_main.c: app_efl_exit(145) > app_efl_exit
05-29 19:15:18.463+0900 I/efl-extension( 1468): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44bbe240, obj: 0x44bbe240
05-29 19:15:18.463+0900 I/efl-extension( 1468): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 19:15:18.468+0900 I/efl-extension( 1468): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 19:15:18.468+0900 I/efl-extension( 1468): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 19:15:18.468+0900 I/efl-extension( 1468): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 19:15:18.498+0900 I/UXT     ( 3088): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 19:15:18.508+0900 I/UXT     ( 1797): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 19:15:18.528+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 19:15:18.533+0900 I/efl-extension( 1468): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x454c2410 is freed
05-29 19:15:18.533+0900 I/efl-extension( 1468): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x455e4830
05-29 19:15:18.533+0900 I/efl-extension( 1468): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:15:18.533+0900 I/efl-extension( 1468): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44bbe240, elm_genlist, func : 0x417f9dfd
05-29 19:15:18.533+0900 I/efl-extension( 1468): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:15:18.593+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 6
05-29 19:15:18.593+0900 W/AUL_AMD (  487): amd_request.c: __foward_cmd(153) > __forward_cmd: 1468 1468
05-29 19:15:18.593+0900 E/AUL     (  487): app_sock.c: __connect_client_sock(196) > connect error: 111
05-29 19:15:18.593+0900 E/AUL     (  487): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-29 19:15:18.603+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1059) > idler for type: 0
05-29 19:15:18.618+0900 I/MALI    ( 1468): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 19:15:18.618+0900 I/MALI    ( 1468): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=1468   close drm_fd=29 
05-29 19:15:18.618+0900 I/MALI    ( 1468): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 19:15:18.623+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-29 19:15:18.623+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1106) > unread_count: 1
05-29 19:15:18.623+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(626) > category_id: 49, application_id: 218, application_name: 카카오톡, time_stamp: 1464516636, content_id: 0, spannable_string_version: 1
05-29 19:15:18.628+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-29 19:15:18.628+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-29 19:15:18.628+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-29 19:15:18.628+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-29 19:15:18.628+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-29 19:15:18.633+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-29 19:15:18.633+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  49, 카카오톡.
05-29 19:15:18.633+0900 W/wnotib  (  714): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(260) > Create a panel for panel_id: 1, instance_id: 49
05-29 19:15:18.633+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_initialize(4998) > Initialize the panel with id: 49
05-29 19:15:18.638+0900 W/wnotib  (  714): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(275) > Page instance, instance_id [49] has been created.
05-29 19:15:18.638+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 49, application_id: 218, type: 1
05-29 19:15:18.658+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-29 19:15:18.658+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-29 19:15:18.658+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-29 19:15:18.658+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-29 19:15:18.663+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-29 19:15:18.663+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 49, application_id: 218, type: 13
05-29 19:15:18.663+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-29 19:15:18.663+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-29 19:15:18.663+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-29 19:15:18.663+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-29 19:15:18.678+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-29 19:15:18.683+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-29 19:15:18.683+0900 I/UXT     ( 1468): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 19:15:18.693+0900 E/AUL     (  487): app_sock.c: __connect_client_sock(196) > connect error: 111
05-29 19:15:18.693+0900 E/AUL     (  487): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-29 19:15:18.708+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 49, application_id: 218, type: 12
05-29 19:15:18.708+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1387) > Num categories: 1, num total noti: 1
05-29 19:15:18.708+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(871) > Free noti manager data.
05-29 19:15:18.708+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(876) > Free previous notifications.
05-29 19:15:18.708+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(897) > Free previous categories.
05-29 19:15:18.708+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
05-29 19:15:18.708+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
05-29 19:15:18.708+0900 W/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(206) > Summary board was disabled. But receive update request
05-29 19:15:18.708+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
05-29 19:15:18.708+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1412) > num_total_panel: 1.
05-29 19:15:18.713+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x1
05-29 19:15:18.733+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1416) > unread_count_for_home: 1
05-29 19:15:18.733+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_show(478) > 
05-29 19:15:18.748+0900 I/AUL_PAD ( 3646): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 19:15:18.788+0900 I/efl-extension( 3612): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 19:15:18.803+0900 I/efl-extension( 1797): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 19:15:18.808+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-29 19:15:18.843+0900 W/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-29 19:15:18.918+0900 W/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-29 19:15:18.938+0900 I/efl-extension( 1468): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 19:15:18.978+0900 E/TBM     ( 3646): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 19:15:18.993+0900 E/AUL     (  487): app_sock.c: __connect_client_sock(196) > connect error: 111
05-29 19:15:18.993+0900 E/AUL     (  487): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 111
05-29 19:15:19.133+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 23
05-29 19:15:19.133+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 19:15:19.133+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 3088
05-29 19:15:19.133+0900 W/AUL_AMD (  487): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-29 19:15:19.148+0900 E/AUL     ( 3657): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-29 19:15:19.153+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1797
05-29 19:15:19.153+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3612
05-29 19:15:19.158+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1468
05-29 19:15:19.203+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3088
05-29 19:15:19.278+0900 W/CRASH_MANAGER( 3656): worker.c: worker_job(1199) > 1103088706831146451691
