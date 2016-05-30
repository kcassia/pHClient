S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 2278
Date: 2016-05-29 12:32:15+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 4
      (SIGILL)
      si_code: 4
      illegal trap
      si_addr: 0x42edbf30

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x404a0250, r3   = 0x00000000
r4   = 0xbeb04648, r5   = 0x4435a028
r6   = 0x40002238, r7   = 0x00000000
r8   = 0x443589a8, r9   = 0x440521b8
r10  = 0x42edc1a8, fp   = 0x00000000
ip   = 0x4008d490, sp   = 0xbeb04638
lr   = 0x403e91e8, pc   = 0x42edbf34
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     17528 KB
Buffers:     48212 KB
Cached:     110348 KB
VmPeak:     114564 KB
VmSize:     101352 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22268 KB
VmRSS:       22268 KB
VmData:      45712 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       50676 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2278 TID = 2278
2278 2285 2288 2357 

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
43759000 4376d000 rwxp [stack:2285]
4376d000 43770000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43777000 43778000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b4000 440b6000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44bcb000 44bce000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44bce000 44bd2000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44bd2000 44be1000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
44bf9000 44c00000 r-xs /usr/lib/gconv/gconv-modules.cache
44d01000 45500000 rwxp [stack:2357]
456f7000 45ef6000 rwxp [stack:2288]
46888000 4688b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46892000 46893000 rwxp /usr/lib/libpulse-simple.so.0.0.4
468fe000 46936000 r-xp /usr/lib/libpulse.so.0.16.2
46936000 46937000 rwxp /usr/lib/libpulse.so.0.16.2
469ab000 469b0000 r-xp /usr/lib/libjson.so.0.0.1
469b7000 469b8000 rwxp /usr/lib/libjson.so.0.0.1
469b8000 46a00000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46a00000 46a01000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46a01000 46a44000 r-xp /usr/lib/libsndfile.so.1.0.25
46a4b000 46a4d000 rwxp /usr/lib/libsndfile.so.1.0.25
46a51000 46a73000 r-xp /usr/lib/libvorbis.so.0.4.3
46a7a000 46a7b000 rwxp /usr/lib/libvorbis.so.0.4.3
46a7b000 46a7f000 r-xp /usr/lib/libogg.so.0.7.1
46a86000 46a87000 rwxp /usr/lib/libogg.so.0.7.1
beae4000 beb05000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2278)
Call Stack Count: 1
 0: (0x42edbf34) (null)
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
text_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:31:51.372+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:31:51.372+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:31:51.372+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:31:51.372+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:31:51.372+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-29 12:31:51.377+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-29 12:31:51.377+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-29 12:31:51.377+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 12:31:51.382+0900 I/SENSOR  ( 2278): -74.410004, 0.350000, -57.889999
05-29 12:31:51.487+0900 I/SENSOR  ( 2278): -239.259995, 13.650000, -10.920000
05-29 12:31:51.587+0900 I/SENSOR  ( 2278): -313.179993, 89.459999, 2.590000
05-29 12:31:51.692+0900 I/SENSOR  ( 2278): -174.649994, 32.130001, -0.140000
05-29 12:31:51.792+0900 I/SENSOR  ( 2278): -79.379997, 17.780001, 7.070000
05-29 12:31:51.857+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:31:51.857+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:31:51.857+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:31:51.857+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:31:51.857+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:31:51.887+0900 I/SENSOR  ( 2278): -82.040001, 32.340000, 10.570000
05-29 12:31:51.987+0900 I/SENSOR  ( 2278): -70.699997, 28.559999, 9.660000
05-29 12:31:52.087+0900 I/SENSOR  ( 2278): -195.160004, 35.560001, 5.040000
05-29 12:31:52.187+0900 I/SENSOR  ( 2278): -188.300003, 39.830002, 3.220000
05-29 12:31:52.212+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:31:52.212+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:31:52.212+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:31:52.212+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:31:52.212+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:31:52.287+0900 I/SENSOR  ( 2278): -7.210000, 30.870001, -7.490000
05-29 12:31:52.387+0900 I/SENSOR  ( 2278): 28.980000, 6.650000, -12.250000
05-29 12:31:52.437+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:31:52.437+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:31:52.437+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:31:52.437+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:31:52.437+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:31:52.487+0900 I/SENSOR  ( 2278): 1846.390015, -127.680000, -99.889999
05-29 12:31:52.487+0900 I/SENSOR  ( 2278): 오른손 모션 앞으로 
05-29 12:31:52.487+0900 I/SOCKETTEST( 2278): Success to create socket
05-29 12:31:52.502+0900 I/SOCKETTEST( 2278): Success to socket connection
05-29 12:31:52.502+0900 I/SOCKETTEST( 2278): write() 성공
05-29 12:31:52.587+0900 I/SENSOR  ( 2278): 303.799988, -89.599998, 121.169998
05-29 12:31:52.687+0900 I/SENSOR  ( 2278): -63.000000, -4.970000, -50.330002
05-29 12:31:52.732+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:31:52.732+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:31:52.732+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:31:52.732+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:31:52.732+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:31:52.737+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-29 12:31:52.747+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : 1124362728[0;m
05-29 12:31:52.747+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-29 12:31:52.747+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 12:31:52.787+0900 I/SENSOR  ( 2278): -182.070007, 36.400002, -7.070000
05-29 12:31:52.892+0900 I/SENSOR  ( 2278): -420.489990, 94.290001, -4.760000
05-29 12:31:52.992+0900 I/SENSOR  ( 2278): -251.160004, 54.040001, 17.010000
05-29 12:31:53.087+0900 I/SENSOR  ( 2278): 96.389999, -4.200000, -12.390000
05-29 12:31:53.102+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
05-29 12:31:53.102+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
05-29 12:31:53.102+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:31:53.102+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:31:53.102+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:31:53.187+0900 I/SENSOR  ( 2278): 300.790009, -44.730000, -10.430000
05-29 12:31:53.287+0900 I/SENSOR  ( 2278): 3.780000, -10.710000, 6.230000
05-29 12:31:53.302+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 12:31:53.387+0900 I/SENSOR  ( 2278): -4.900000, -9.100000, 1.470000
05-29 12:31:53.487+0900 I/SENSOR  ( 2278): -47.880001, -9.940000, 12.250000
05-29 12:31:53.597+0900 I/SENSOR  ( 2278): -19.389999, -3.080000, -5.600000
05-29 12:31:53.672+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 12:31:53.672+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 12:31:53.697+0900 I/SENSOR  ( 2278): -0.280000, 1.540000, -0.350000
05-29 12:31:53.797+0900 I/SENSOR  ( 2278): -10.780000, 2.450000, -0.350000
05-29 12:31:53.897+0900 I/SENSOR  ( 2278): -3.080000, 2.520000, 0.350000
05-29 12:31:53.997+0900 I/SENSOR  ( 2278): 1.820000, -1.540000, 0.420000
05-29 12:31:54.092+0900 I/SENSOR  ( 2278): 0.910000, 1.890000, 0.210000
05-29 12:31:54.207+0900 I/SENSOR  ( 2278): -1.260000, -0.280000, 0.420000
05-29 12:31:54.287+0900 I/SENSOR  ( 2278): 2.520000, -0.560000, 0.490000
05-29 12:31:54.392+0900 I/SENSOR  ( 2278): -8.750000, -2.030000, -0.140000
05-29 12:31:54.497+0900 I/SENSOR  ( 2278): -11.130000, 2.520000, 0.420000
05-29 12:31:54.592+0900 I/SENSOR  ( 2278): -1.890000, -0.280000, 0.350000
05-29 12:31:54.692+0900 I/SENSOR  ( 2278): -2.380000, 3.080000, 0.490000
05-29 12:31:54.792+0900 I/SENSOR  ( 2278): 14.000000, 8.050000, 1.050000
05-29 12:31:54.892+0900 I/SENSOR  ( 2278): 1.680000, -1.960000, 0.140000
05-29 12:31:54.992+0900 I/SENSOR  ( 2278): 3.220000, -0.490000, 0.210000
05-29 12:31:55.097+0900 I/SENSOR  ( 2278): 0.910000, -2.100000, 0.140000
05-29 12:31:55.202+0900 I/SENSOR  ( 2278): -2.730000, -0.070000, 0.140000
05-29 12:31:55.292+0900 I/SENSOR  ( 2278): -0.700000, 0.070000, 0.140000
05-29 12:31:55.392+0900 I/SENSOR  ( 2278): -0.140000, -0.560000, 0.280000
05-29 12:31:55.497+0900 I/SENSOR  ( 2278): 0.560000, -0.350000, 0.210000
05-29 12:31:55.597+0900 I/SENSOR  ( 2278): 0.560000, -0.490000, 0.350000
05-29 12:31:55.692+0900 I/SENSOR  ( 2278): 0.560000, -0.490000, 0.210000
05-29 12:31:55.792+0900 I/SENSOR  ( 2278): -2.170000, 0.770000, 0.350000
05-29 12:31:55.892+0900 I/SENSOR  ( 2278): -0.630000, -0.840000, 0.420000
05-29 12:31:55.997+0900 I/SENSOR  ( 2278): 0.210000, -0.700000, 0.140000
05-29 12:31:56.092+0900 I/SENSOR  ( 2278): 0.490000, -0.490000, 0.280000
05-29 12:31:56.247+0900 I/SENSOR  ( 2278): -0.420000, -0.140000, 0.280000
05-29 12:31:56.292+0900 I/SENSOR  ( 2278): 0.840000, -0.840000, 0.490000
05-29 12:31:56.392+0900 I/SENSOR  ( 2278): 0.490000, 0.280000, 0.210000
05-29 12:31:56.497+0900 I/SENSOR  ( 2278): 0.420000, 0.280000, 0.280000
05-29 12:31:56.597+0900 I/SENSOR  ( 2278): -0.070000, -0.070000, 0.350000
05-29 12:31:56.697+0900 I/SENSOR  ( 2278): -0.420000, 0.420000, 0.140000
05-29 12:31:56.797+0900 I/SENSOR  ( 2278): -0.420000, 0.420000, 0.210000
05-29 12:31:56.897+0900 I/SENSOR  ( 2278): 0.350000, -0.210000, 0.350000
05-29 12:31:56.997+0900 I/SENSOR  ( 2278): 0.210000, -0.280000, 0.210000
05-29 12:31:57.097+0900 I/SENSOR  ( 2278): -0.560000, -0.280000, 0.280000
05-29 12:31:57.202+0900 I/SENSOR  ( 2278): -3.080000, 1.260000, 0.070000
05-29 12:31:57.292+0900 I/SENSOR  ( 2278): 0.280000, -0.630000, 0.210000
05-29 12:31:57.397+0900 I/SENSOR  ( 2278): -0.490000, -0.070000, 0.210000
05-29 12:31:57.507+0900 I/SENSOR  ( 2278): 0.420000, 0.210000, 0.280000
05-29 12:31:57.597+0900 I/SENSOR  ( 2278): 0.770000, -0.210000, 0.350000
05-29 12:31:57.697+0900 I/SENSOR  ( 2278): 0.420000, -0.420000, 0.280000
05-29 12:31:57.797+0900 I/SENSOR  ( 2278): -0.070000, -0.070000, 0.350000
05-29 12:31:57.897+0900 I/SENSOR  ( 2278): 0.210000, -0.560000, 0.350000
05-29 12:31:57.997+0900 I/SENSOR  ( 2278): -0.070000, -0.070000, 0.350000
05-29 12:31:58.097+0900 I/SENSOR  ( 2278): -0.070000, -0.350000, 0.210000
05-29 12:31:58.217+0900 I/SENSOR  ( 2278): -1.050000, -0.980000, 0.280000
05-29 12:31:58.292+0900 I/SENSOR  ( 2278): -11.410000, 2.450000, 0.210000
05-29 12:31:58.397+0900 I/SENSOR  ( 2278): 1.750000, -3.920000, 0.490000
05-29 12:31:58.497+0900 I/SENSOR  ( 2278): 8.750000, -2.170000, 0.490000
05-29 12:31:58.602+0900 I/SENSOR  ( 2278): -4.340000, -0.490000, -0.210000
05-29 12:31:58.697+0900 I/SENSOR  ( 2278): -2.800000, 2.870000, -0.140000
05-29 12:31:58.797+0900 I/SENSOR  ( 2278): 8.960000, -0.070000, 1.680000
05-29 12:31:58.897+0900 I/SENSOR  ( 2278): 1.050000, -0.770000, 0.420000
05-29 12:31:58.997+0900 I/SENSOR  ( 2278): 0.070000, -0.420000, 0.350000
05-29 12:31:59.097+0900 I/SENSOR  ( 2278): -3.570000, -2.240000, 0.210000
05-29 12:31:59.202+0900 I/SENSOR  ( 2278): -6.580000, 2.520000, 0.280000
05-29 12:31:59.292+0900 I/SENSOR  ( 2278): 6.790000, -1.680000, 0.560000
05-29 12:31:59.402+0900 I/SENSOR  ( 2278): 0.700000, -0.910000, 0.630000
05-29 12:31:59.502+0900 I/SENSOR  ( 2278): 3.080000, 0.140000, 0.630000
05-29 12:31:59.602+0900 I/SENSOR  ( 2278): -1.960000, 2.310000, 0.140000
05-29 12:31:59.697+0900 I/SENSOR  ( 2278): 0.700000, 0.210000, 0.420000
05-29 12:31:59.797+0900 I/SENSOR  ( 2278): -1.400000, 0.630000, 0.280000
05-29 12:31:59.902+0900 I/SENSOR  ( 2278): -1.750000, 0.630000, 0.280000
05-29 12:31:59.997+0900 I/SENSOR  ( 2278): -0.210000, 0.630000, 0.350000
05-29 12:32:00.097+0900 I/SENSOR  ( 2278): -0.840000, 0.630000, 0.560000
05-29 12:32:00.147+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 12:32:00.207+0900 I/SENSOR  ( 2278): 0.210000, -0.700000, 0.210000
05-29 12:32:00.297+0900 I/SENSOR  ( 2278): -0.770000, -0.420000, 0.140000
05-29 12:32:00.397+0900 I/SENSOR  ( 2278): 2.100000, -0.700000, 0.280000
05-29 12:32:00.497+0900 I/SENSOR  ( 2278): 2.520000, -0.840000, 0.350000
05-29 12:32:00.602+0900 I/SENSOR  ( 2278): 1.050000, -0.490000, 0.490000
05-29 12:32:00.697+0900 I/SENSOR  ( 2278): -0.420000, 0.630000, 0.490000
05-29 12:32:00.802+0900 I/SENSOR  ( 2278): -0.770000, 0.070000, 0.490000
05-29 12:32:00.897+0900 I/SENSOR  ( 2278): -0.210000, -0.770000, 0.210000
05-29 12:32:00.997+0900 I/SENSOR  ( 2278): 2.520000, -0.770000, 0.770000
05-29 12:32:01.097+0900 I/SENSOR  ( 2278): -4.270000, -2.310000, -0.070000
05-29 12:32:01.197+0900 I/SENSOR  ( 2278): -7.140000, 1.960000, -0.070000
05-29 12:32:01.297+0900 I/SENSOR  ( 2278): 0.980000, -1.470000, 0.700000
05-29 12:32:01.387+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 12:32:01.387+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 12:32:01.387+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-29 12:32:01.387+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 12:32:01.387+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 12:32:01.387+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-29 12:32:01.387+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 12:32:01.387+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 12:32:01.387+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-29 12:32:01.397+0900 I/SENSOR  ( 2278): 0.140000, -1.610000, 0.490000
05-29 12:32:01.502+0900 I/SENSOR  ( 2278): -1.890000, -0.770000, 0.350000
05-29 12:32:01.602+0900 I/SENSOR  ( 2278): -2.870000, -1.470000, 0.420000
05-29 12:32:01.702+0900 I/SENSOR  ( 2278): 1.050000, -0.630000, 0.490000
05-29 12:32:01.797+0900 I/SENSOR  ( 2278): -1.120000, 0.350000, 0.210000
05-29 12:32:01.902+0900 I/SENSOR  ( 2278): -0.420000, 1.120000, 0.350000
05-29 12:32:02.002+0900 I/SENSOR  ( 2278): 4.130000, -3.780000, 0.210000
05-29 12:32:02.102+0900 I/SENSOR  ( 2278): -1.190000, -0.840000, 0.280000
05-29 12:32:02.202+0900 I/SENSOR  ( 2278): -0.630000, -0.210000, 0.210000
05-29 12:32:02.297+0900 I/SENSOR  ( 2278): -4.410000, -0.490000, 0.210000
05-29 12:32:02.402+0900 I/SENSOR  ( 2278): -0.560000, -0.070000, 0.350000
05-29 12:32:02.507+0900 I/SENSOR  ( 2278): -0.350000, -0.280000, 0.210000
05-29 12:32:02.602+0900 I/SENSOR  ( 2278): -2.520000, 0.350000, 0.210000
05-29 12:32:02.702+0900 I/SENSOR  ( 2278): -0.210000, -0.490000, 0.350000
05-29 12:32:02.802+0900 I/SENSOR  ( 2278): 0.840000, 1.750000, 0.980000
05-29 12:32:02.902+0900 I/SENSOR  ( 2278): 1.330000, -3.150000, 0.140000
05-29 12:32:03.002+0900 I/SENSOR  ( 2278): -5.250000, -1.120000, 0.280000
05-29 12:32:03.102+0900 I/SENSOR  ( 2278): 1.120000, 1.260000, 0.490000
05-29 12:32:03.202+0900 I/SENSOR  ( 2278): 0.140000, -0.630000, 0.350000
05-29 12:32:03.302+0900 I/SENSOR  ( 2278): -0.070000, -0.210000, 0.210000
05-29 12:32:03.402+0900 I/SENSOR  ( 2278): 0.140000, 0.140000, 0.420000
05-29 12:32:03.502+0900 I/SENSOR  ( 2278): 0.840000, 0.070000, 0.420000
05-29 12:32:03.602+0900 I/SENSOR  ( 2278): 4.900000, 3.010000, 0.980000
05-29 12:32:03.702+0900 I/SENSOR  ( 2278): -1.680000, -2.240000, 0.210000
05-29 12:32:03.802+0900 I/SENSOR  ( 2278): 0.210000, 0.840000, 0.140000
05-29 12:32:03.902+0900 I/SENSOR  ( 2278): -0.210000, -0.070000, 0.420000
05-29 12:32:04.002+0900 I/SENSOR  ( 2278): 1.190000, 0.630000, 0.140000
05-29 12:32:04.057+0900 E/DBG_PAD (29186): discovery.c: _discovery_thread(74) > Unknown packet, 5
05-29 12:32:04.057+0900 E/DBG_PAD (29186): 192.168.123.104:26101
05-29 12:32:04.057+0900 E/DBG_PAD (29186): ,24
05-29 12:32:04.102+0900 I/SENSOR  ( 2278): 1.400000, 2.450000, 0.280000
05-29 12:32:04.242+0900 I/SENSOR  ( 2278): 4.480000, -2.170000, 0.490000
05-29 12:32:04.297+0900 I/SENSOR  ( 2278): -1.330000, -2.380000, 0.280000
05-29 12:32:04.402+0900 I/SENSOR  ( 2278): -0.490000, -0.630000, 0.210000
05-29 12:32:04.507+0900 I/SENSOR  ( 2278): 1.190000, -1.190000, 0.420000
05-29 12:32:04.602+0900 I/SENSOR  ( 2278): 3.290000, -0.420000, 0.560000
05-29 12:32:04.702+0900 I/SENSOR  ( 2278): -0.210000, -1.890000, -0.140000
05-29 12:32:04.802+0900 I/SENSOR  ( 2278): -1.190000, 0.420000, 0.140000
05-29 12:32:04.902+0900 I/SENSOR  ( 2278): 0.070000, 1.050000, 0.140000
05-29 12:32:05.002+0900 I/SENSOR  ( 2278): 0.280000, 0.070000, 0.280000
05-29 12:32:05.102+0900 I/SENSOR  ( 2278): -0.490000, 0.140000, 0.280000
05-29 12:32:05.217+0900 I/SENSOR  ( 2278): 0.700000, -0.140000, 0.350000
05-29 12:32:05.302+0900 I/SENSOR  ( 2278): -0.280000, 0.420000, 0.280000
05-29 12:32:05.407+0900 I/SENSOR  ( 2278): -0.280000, -0.350000, 0.210000
05-29 12:32:05.502+0900 I/SENSOR  ( 2278): 2.170000, -0.210000, 0.420000
05-29 12:32:05.607+0900 I/SENSOR  ( 2278): 0.910000, -0.700000, 0.280000
05-29 12:32:05.707+0900 I/SENSOR  ( 2278): -0.910000, -0.140000, 0.280000
05-29 12:32:05.807+0900 I/SENSOR  ( 2278): -1.190000, -0.140000, 0.210000
05-29 12:32:05.902+0900 I/SENSOR  ( 2278): -0.420000, 0.490000, 0.770000
05-29 12:32:06.002+0900 I/SENSOR  ( 2278): -2.520000, -0.840000, -0.140000
05-29 12:32:06.102+0900 I/SENSOR  ( 2278): 2.170000, -1.540000, -0.070000
05-29 12:32:06.202+0900 I/SENSOR  ( 2278): -2.940000, 1.470000, -0.280000
05-29 12:32:06.302+0900 I/SENSOR  ( 2278): 0.700000, -0.560000, 0.350000
05-29 12:32:06.417+0900 I/SENSOR  ( 2278): -7.070000, 1.190000, 0.070000
05-29 12:32:06.512+0900 I/SENSOR  ( 2278): 6.580000, -0.980000, 0.840000
05-29 12:32:06.602+0900 I/SENSOR  ( 2278): 0.350000, -2.520000, 0.140000
05-29 12:32:06.612+0900 E/CAPI_SYSTEM_INFO(29193): system_info_parse.c: system_info_get_value_from_config_xml(279) > cannot find tizen.org/feature/container field from /etc/config/model-config.xml file!!!
05-29 12:32:06.617+0900 E/CAPI_SYSTEM_INFO(29193): system_info.c: system_info_get_platform_bool(293) > cannot get tizen.org/feature/container
05-29 12:32:06.702+0900 I/SENSOR  ( 2278): 1.890000, -5.530000, 0.910000
05-29 12:32:06.802+0900 I/SENSOR  ( 2278): -1.400000, 0.350000, 0.420000
05-29 12:32:06.902+0900 I/SENSOR  ( 2278): 1.890000, -1.750000, 0.210000
05-29 12:32:07.002+0900 I/SENSOR  ( 2278): -0.700000, -0.070000, 0.070000
05-29 12:32:07.102+0900 I/SENSOR  ( 2278): -1.750000, -0.350000, 0.420000
05-29 12:32:07.217+0900 I/SENSOR  ( 2278): -1.260000, -0.490000, 0.210000
05-29 12:32:07.302+0900 I/SENSOR  ( 2278): -0.910000, -0.490000, 0.280000
05-29 12:32:07.402+0900 I/SENSOR  ( 2278): 0.630000, -0.840000, 0.350000
05-29 12:32:07.502+0900 I/SENSOR  ( 2278): 0.280000, -0.840000, 0.350000
05-29 12:32:07.612+0900 I/SENSOR  ( 2278): 0.280000, 0.350000, 0.210000
05-29 12:32:07.712+0900 I/SENSOR  ( 2278): 3.570000, -2.730000, 0.350000
05-29 12:32:07.812+0900 I/SENSOR  ( 2278): -3.080000, 0.490000, 0.140000
05-29 12:32:07.902+0900 I/SENSOR  ( 2278): -0.980000, -0.140000, 0.210000
05-29 12:32:08.002+0900 I/SENSOR  ( 2278): -0.630000, 2.240000, 0.350000
05-29 12:32:08.102+0900 I/SENSOR  ( 2278): -2.380000, 0.630000, 0.280000
05-29 12:32:08.202+0900 I/SENSOR  ( 2278): -2.380000, -0.700000, 0.280000
05-29 12:32:08.307+0900 I/SENSOR  ( 2278): 1.330000, -0.560000, 0.350000
05-29 12:32:08.402+0900 I/SENSOR  ( 2278): 1.680000, -0.210000, 0.350000
05-29 12:32:08.502+0900 I/SENSOR  ( 2278): -0.840000, -0.490000, 0.210000
05-29 12:32:08.602+0900 I/SENSOR  ( 2278): 4.690000, 0.560000, 1.260000
05-29 12:32:08.707+0900 I/SENSOR  ( 2278): -2.660000, -0.210000, 0.070000
05-29 12:32:08.802+0900 I/SENSOR  ( 2278): 1.750000, -0.070000, 0.210000
05-29 12:32:08.902+0900 I/SENSOR  ( 2278): -0.560000, -0.910000, 0.210000
05-29 12:32:09.002+0900 I/SENSOR  ( 2278): 0.420000, -0.840000, 0.350000
05-29 12:32:09.107+0900 I/SENSOR  ( 2278): 1.610000, -0.490000, 0.560000
05-29 12:32:09.242+0900 I/SENSOR  ( 2278): 0.910000, 0.280000, 0.420000
05-29 12:32:09.302+0900 I/SENSOR  ( 2278): 0.840000, 0.420000, 0.490000
05-29 12:32:09.407+0900 I/SENSOR  ( 2278): -2.520000, 0.210000, 0.280000
05-29 12:32:09.517+0900 I/SENSOR  ( 2278): -2.870000, -0.350000, 0.140000
05-29 12:32:09.607+0900 I/SENSOR  ( 2278): -2.870000, -0.840000, 0.420000
05-29 12:32:09.707+0900 I/SENSOR  ( 2278): 0.700000, -0.490000, 0.210000
05-29 12:32:09.812+0900 I/SENSOR  ( 2278): -0.350000, -0.980000, 0.210000
05-29 12:32:09.907+0900 I/SENSOR  ( 2278): -0.700000, 0.490000, 0.070000
05-29 12:32:10.007+0900 I/SENSOR  ( 2278): 1.120000, 1.330000, 1.260000
05-29 12:32:10.112+0900 I/SENSOR  ( 2278): -1.820000, 1.120000, 0.630000
05-29 12:32:10.207+0900 I/SENSOR  ( 2278): 1.470000, -1.330000, -0.070000
05-29 12:32:10.307+0900 I/SENSOR  ( 2278): 0.350000, 0.560000, -0.070000
05-29 12:32:10.407+0900 I/SENSOR  ( 2278): -1.400000, 1.330000, 0.140000
05-29 12:32:10.512+0900 I/SENSOR  ( 2278): -1.540000, 2.520000, 0.280000
05-29 12:32:10.612+0900 I/SENSOR  ( 2278): -3.150000, 1.330000, 0.210000
05-29 12:32:10.732+0900 I/SENSOR  ( 2278): -1.330000, 1.330000, 0.280000
05-29 12:32:10.807+0900 I/SENSOR  ( 2278): -1.750000, -1.050000, 0.630000
05-29 12:32:10.912+0900 I/SENSOR  ( 2278): 37.170002, -3.500000, 9.940000
05-29 12:32:11.007+0900 I/SENSOR  ( 2278): 37.660000, 67.970001, 76.860001
05-29 12:32:11.112+0900 I/SENSOR  ( 2278): 27.510000, 35.840000, 111.650002
05-29 12:32:11.207+0900 I/SENSOR  ( 2278): 5.460000, 21.910000, 66.989998
05-29 12:32:11.307+0900 I/SENSOR  ( 2278): -35.630001, 25.410000, 10.710000
05-29 12:32:11.407+0900 I/SENSOR  ( 2278): -15.540000, -7.980000, -13.650000
05-29 12:32:11.507+0900 I/SENSOR  ( 2278): 3.500000, -32.480000, -18.690001
05-29 12:32:11.607+0900 I/SENSOR  ( 2278): -11.760000, -1.960000, -4.410000
05-29 12:32:11.707+0900 I/SENSOR  ( 2278): 0.070000, -3.430000, 0.910000
05-29 12:32:11.812+0900 I/SENSOR  ( 2278): -7.140000, -4.060000, 8.400000
05-29 12:32:11.912+0900 I/SENSOR  ( 2278): -13.930000, 1.260000, -8.120000
05-29 12:32:12.012+0900 I/SENSOR  ( 2278): -3.500000, -0.910000, -21.770000
05-29 12:32:12.077+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-29 12:32:12.077+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-29 12:32:12.082+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-29 12:32:12.082+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
05-29 12:32:12.112+0900 I/SENSOR  ( 2278): -0.070000, 2.940000, -0.490000
05-29 12:32:12.192+0900 W/STARTER (  682): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-29 12:32:12.257+0900 I/SENSOR  ( 2278): 17.850000, -12.180000, -3.710000
05-29 12:32:12.277+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
05-29 12:32:12.277+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
05-29 12:32:12.277+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
05-29 12:32:12.277+0900 W/STARTER (  682): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 2
05-29 12:32:12.307+0900 I/SENSOR  ( 2278): -4.060000, 10.220000, -4.830000
05-29 12:32:12.402+0900 W/STARTER (  682): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
05-29 12:32:12.412+0900 I/SENSOR  ( 2278): 4.830000, 1.540000, 30.660000
05-29 12:32:12.512+0900 I/SENSOR  ( 2278): -4.480000, 3.360000, 30.660000
05-29 12:32:12.622+0900 I/SENSOR  ( 2278): -4.970000, 2.800000, -1.820000
05-29 12:32:12.677+0900 W/STARTER (  682): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[2]
05-29 12:32:12.682+0900 W/STARTER (  682): hw_key.c: _powerkey_timer_cb(911) > [_powerkey_timer_cb:911] powerkey double press
05-29 12:32:12.707+0900 I/SENSOR  ( 2278): -1.330000, 1.820000, 0.630000
05-29 12:32:12.737+0900 E/STARTER (  682): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
05-29 12:32:12.737+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 12:32:12.747+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 682
05-29 12:32:12.757+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(2080) > pad pid(-5)
05-29 12:32:12.757+0900 W/AUL_PAD (13314): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-29 12:32:12.757+0900 W/AUL_PAD (13314): launchpad.c: __send_result_to_caller(272) > Check app launching
05-29 12:32:12.772+0900 E/RESOURCED(  488): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-29 12:32:12.782+0900 I/CAPI_APPFW_APPLICATION( 2166): app_main.c: app_efl_main(129) > app_efl_main
05-29 12:32:12.792+0900 I/CAPI_APPFW_APPLICATION( 2166): app_main.c: app_appcore_create(152) > app_appcore_create
05-29 12:32:12.807+0900 I/SENSOR  ( 2278): -2.240000, 1.050000, -0.070000
05-29 12:32:12.862+0900 E/AUL     (  682): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 12:32:12.862+0900 E/RESOURCED(  488): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-taskmanager
05-29 12:32:12.907+0900 I/SENSOR  ( 2278): -3.080000, 0.980000, -0.840000
05-29 12:32:12.972+0900 I/efl-extension( 2166): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x45266018 = w: 0 h: 0  obj 0x4524feb0 w: 360 h: 360
05-29 12:32:12.972+0900 I/efl-extension( 2166): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 12:32:12.972+0900 I/efl-extension( 2166): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 12:32:12.972+0900 I/efl-extension( 2166): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-29 12:32:12.972+0900 I/efl-extension( 2166): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-29 12:32:12.977+0900 I/efl-extension( 2166): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-29 12:32:12.982+0900 I/efl-extension( 2166): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4524feb0, elm_image, _activated_obj : 0x0, activated : 1
05-29 12:32:13.007+0900 I/SENSOR  ( 2278): -2.520000, 0.280000, -0.140000
05-29 12:32:13.087+0900 E/W_TASKMANAGER( 2166): util_wc1.c: close_button_disabled_set(367) > [close_button_disabled_set:367] (ad->ly_main == NULL) -> close_button_disabled_set() return
05-29 12:32:13.087+0900 E/W_TASKMANAGER( 2166): pkgmgr.c: pkgmgr_init(396) > [pkgmgr_init:396] (pkgmgr_client_listen_status(pkg_mgr_info.listen_pc, _pkgmgr_cb, data) != PKGMGR_R_OK) -> pkgmgr_init() return
05-29 12:32:13.087+0900 E/W_TASKMANAGER( 2166): taskmanager.c: _app_create(315) > [_app_create:315] cannot init pkgmgr
05-29 12:32:13.107+0900 I/SENSOR  ( 2278): -0.420000, -0.490000, 0.070000
05-29 12:32:13.137+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/W_TASKMANAGER( 2166): task.c: _iterfunc(582) > [_iterfunc:582] Fail to get ai table !!
05-29 12:32:13.142+0900 E/RUA     ( 2166): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 23, ncols : 5
05-29 12:32:13.207+0900 I/SENSOR  ( 2278): -0.560000, -1.540000, -0.560000
05-29 12:32:13.212+0900 E/EFL     ( 2166): elementary<2166> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x45251b30 into part 'elm.swallow.event.0'
05-29 12:32:13.257+0900 E/E17     (  382): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03600003)
05-29 12:32:13.257+0900 I/APP_CORE( 2166): appcore-efl.c: __do_app(429) > [APP 2166] Event: RESET State: CREATED
05-29 12:32:13.257+0900 I/CAPI_APPFW_APPLICATION( 2166): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 12:32:13.282+0900 I/APP_CORE( 2166): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
05-29 12:32:13.282+0900 I/APP_CORE( 2166): appcore-efl.c: __do_app(474) > [APP 2166] Initial Launching, call the resume_cb
05-29 12:32:13.282+0900 I/CAPI_APPFW_APPLICATION( 2166): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 12:32:13.307+0900 I/SENSOR  ( 2278): -0.210000, -0.350000, 0.350000
05-29 12:32:13.317+0900 E/E17     (  382): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x03600003)
05-29 12:32:13.337+0900 W/APP_CORE( 2166): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600003
05-29 12:32:13.407+0900 I/SENSOR  ( 2278): 0.070000, 0.070000, 0.770000
05-29 12:32:13.412+0900 I/APP_CORE( 2278): appcore-efl.c: __do_app(429) > [APP 2278] Event: PAUSE State: RUNNING
05-29 12:32:13.412+0900 I/CAPI_APPFW_APPLICATION( 2278): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 12:32:13.437+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 12:32:13.437+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 12:32:13.467+0900 I/APP_CORE( 2166): appcore-efl.c: __do_app(429) > [APP 2166] Event: RESUME State: RUNNING
05-29 12:32:13.552+0900 I/SENSOR  ( 2278): 1.820000, -0.140000, 0.700000
05-29 12:32:13.607+0900 I/SENSOR  ( 2278): -0.420000, -0.140000, 0.490000
05-29 12:32:13.712+0900 I/SENSOR  ( 2278): -0.210000, -0.350000, 0.560000
05-29 12:32:13.812+0900 I/SENSOR  ( 2278): 0.210000, -0.560000, 0.210000
05-29 12:32:13.832+0900 E/AUL     (  487): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-29 12:32:13.872+0900 I/MALI    ( 2166): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x414f9658] swap changed from async to sync
05-29 12:32:13.907+0900 E/EFL     ( 2166): evas_main<2166> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11985616 button=1 downs=1
05-29 12:32:13.907+0900 I/SENSOR  ( 2278): 7.280000, -9.100000, -4.830000
05-29 12:32:13.952+0900 E/EFL     ( 2166): evas_main<2166> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11985668 button=1 downs=0
05-29 12:32:13.987+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 12:32:13.997+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2166
05-29 12:32:14.002+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 12:32:14.012+0900 I/SENSOR  ( 2278): -8.120000, 3.290000, 1.260000
05-29 12:32:14.107+0900 I/SENSOR  ( 2278): -0.140000, -0.070000, 0.700000
05-29 12:32:14.217+0900 E/EFL     ( 2166): elementary<2166> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(45206568), freeze(1)
05-29 12:32:14.217+0900 E/EFL     ( 2166): elementary<2166> elm_interface_scrollable.c:5304 _elm_scroll_freeze_set() [DDO] obj(45206568), freeze(1)
05-29 12:32:14.217+0900 I/SENSOR  ( 2278): -0.700000, 0.630000, 0.140000
05-29 12:32:14.307+0900 I/SENSOR  ( 2278): -0.420000, -0.910000, 1.470000
05-29 12:32:14.407+0900 I/SENSOR  ( 2278): -2.100000, 0.910000, 0.770000
05-29 12:32:14.507+0900 I/efl-extension( 3048): efl_extension.c: eext_mod_init(40) > Init
05-29 12:32:14.507+0900 I/SENSOR  ( 2278): -1.260000, 0.630000, 0.490000
05-29 12:32:14.547+0900 I/UXT     ( 3048): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-29 12:32:14.582+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 12:32:14.592+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1591
05-29 12:32:14.592+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 27
05-29 12:32:14.597+0900 E/AUL_AMD (  487): amd_request.c: __app_process_by_pid(193) > pid(11954) is dead. cmd(27) is canceled
05-29 12:32:14.597+0900 E/W_TASKMANAGER( 2166): task.c: taskmanager_remove_all_task_info(793) > [taskmanager_remove_all_task_info:793] aul_terminate_pid() failed (-3)
05-29 12:32:14.612+0900 I/SENSOR  ( 2278): -0.770000, -0.210000, 0.770000
05-29 12:32:14.612+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 12:32:14.617+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2278
05-29 12:32:14.622+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 27
05-29 12:32:14.622+0900 I/APP_CORE( 2278): appcore-efl.c: __do_app(429) > [APP 2278] Event: TERMINATE State: PAUSED
05-29 12:32:14.627+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 12:32:14.627+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 12:32:14.632+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 12:32:14.632+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 12:32:14.637+0900 E/APP_CORE( 2166): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
05-29 12:32:14.637+0900 I/APP_CORE( 2166): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 12:32:14.637+0900 I/APP_CORE( 2166): appcore-efl.c: __after_loop(1090) > [APP 2166] PAUSE before termination
05-29 12:32:14.637+0900 I/CAPI_APPFW_APPLICATION( 2166): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-29 12:32:14.637+0900 I/CAPI_APPFW_APPLICATION( 2166): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-29 12:32:14.637+0900 I/efl-extension( 2166): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45206568, obj: 0x45206568
05-29 12:32:14.637+0900 I/efl-extension( 2166): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 12:32:14.637+0900 I/efl-extension( 2166): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 12:32:14.637+0900 I/efl-extension( 2166): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 12:32:14.637+0900 I/efl-extension( 2166): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 12:32:14.652+0900 I/efl-extension( 2166): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x4524feb0
05-29 12:32:14.652+0900 I/efl-extension( 2166): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 12:32:14.652+0900 I/efl-extension( 2166): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45266018 is freed
05-29 12:32:14.652+0900 I/efl-extension( 2166): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 12:32:14.652+0900 I/efl-extension( 2166): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45206568, elm_scroller, func : 0x437c8ef1
05-29 12:32:14.652+0900 I/efl-extension( 2166): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 12:32:14.652+0900 I/efl-extension( 2166): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 12:32:14.652+0900 I/efl-extension( 2166): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4524feb0, elm_image, func : 0x437c8ef1
05-29 12:32:14.652+0900 I/efl-extension( 2166): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 12:32:14.652+0900 I/efl-extension( 2166): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x45206568 : elm_scroller] rotary callabck is deleted
05-29 12:32:14.692+0900 I/APP_CORE( 2278): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 12:32:14.692+0900 I/CAPI_APPFW_APPLICATION( 2278): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-29 12:32:14.732+0900 I/efl-extension( 2278): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c060b0
05-29 12:32:14.732+0900 I/efl-extension( 2278): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c060b0, obj: 0x44c060b0
05-29 12:32:14.732+0900 I/efl-extension( 2278): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 12:32:14.737+0900 I/SENSOR  ( 2278): 0.350000, -0.560000, 0.560000
05-29 12:32:14.747+0900 W/PROCESSMGR(  382): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-29 12:32:14.747+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-29 12:32:14.747+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-29 12:32:14.752+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 12:32:14.752+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 12:32:14.752+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 12:32:14.762+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 12:32:14.762+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 12:32:14.822+0900 I/MALI    ( 2278): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 12:32:14.822+0900 I/MALI    ( 2278): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=2278   close drm_fd=25 
05-29 12:32:14.822+0900 I/MALI    ( 2278): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 12:32:14.832+0900 I/MALI    ( 2166): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x414f9658] swap changed from sync to async
05-29 12:32:14.882+0900 I/MALI    ( 2166): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 12:32:14.882+0900 I/MALI    ( 2166): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=2166   close drm_fd=21 
05-29 12:32:14.882+0900 I/MALI    ( 2166): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 12:32:14.922+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 12:32:14.922+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:32:14.922+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:32:14.922+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:32:14.922+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 12:32:14.927+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 12:32:14.927+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 12:32:14.927+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:32:14.927+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 12:32:14.927+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
05-29 12:32:14.927+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 12:32:14.927+0900 W/W_HOME  (  714): main.c: _appcore_resume_cb(681) > appcore resume
05-29 12:32:14.927+0900 W/W_HOME  (  714): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-29 12:32:14.927+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:32:14.927+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:32:14.927+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 12:32:14.927+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 12:32:14.927+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x45d34090
05-29 12:32:14.927+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d34090, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-29 12:32:14.927+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 12:32:14.927+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 12:32:14.927+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 12:32:14.927+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 12:32:14.932+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 12:32:14.932+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 12:32:14.932+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 12:32:14.932+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 12:32:14.967+0900 I/UXT     ( 2278): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 12:32:14.987+0900 I/UXT     ( 2166): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 12:32:15.032+0900 I/AUL_PAD ( 3048): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-29 12:32:15.062+0900 E/TBM     ( 3048): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
05-29 12:32:15.262+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-29 12:32:15.272+0900 I/efl-extension( 2166): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-29 12:32:15.502+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2166
05-29 12:32:15.587+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 23
05-29 12:32:15.587+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 12:32:15.587+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 2278
05-29 12:32:15.587+0900 W/AUL_AMD (  487): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-29 12:32:15.592+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2278
05-29 12:32:15.592+0900 E/AUL     ( 3055): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-29 12:32:15.667+0900 W/CRASH_MANAGER( 3053): worker.c: worker_job(1199) > 0402278706831146449273
