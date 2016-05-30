S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 20641
Date: 2016-05-29 14:59:09+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0x44347660

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x404a0250, r3   = 0x00000000
r4   = 0xbe92d648, r5   = 0x00000000
r6   = 0x40002240, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x00000000
r10  = 0x4000f3f4, fp   = 0x00000000
ip   = 0x4008d490, sp   = 0xbe92d638
lr   = 0x403e91e8, pc   = 0x44347660
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     18440 KB
Buffers:     45516 KB
Cached:     109012 KB
VmPeak:      96700 KB
VmSize:      88732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19200 KB
VmRSS:       17780 KB
VmData:      34256 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       49684 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20641 TID = 20641
20641 20648 

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
43759000 4376d000 rwxp [stack:20648]
4376d000 43770000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43777000 43778000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b4000 440b6000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44bef000 44bf2000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44bf2000 44bf6000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
45548000 45557000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
be90d000 be92e000 rwxp [stack]
End of Maps Information

Callstack Information (PID:20641)
Call Stack Count: 1
 0: (0x44347660) (null)
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
  (10460): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x56)
05-29 14:55:35.627+0900 W/SCSD    (10460): <on_sap_socket_recv:30>  - remain length: 86, crc_size: 4
05-29 14:55:35.627+0900 W/SCSD    (10460): <on_sap_socket_recv:62>  - recv 90 bytes [90 / 90] 
05-29 14:55:35.632+0900 W/SCSD    (10460): <util_scs_send:975> sent [92 / 92] bytes. 
05-29 14:55:35.637+0900 E/WMS     (  484): wms_event_handler.c: wms_event_handler_routine(21099) > 
05-29 14:55:35.637+0900 E/WMS     (  484): ==========
05-29 14:55:35.637+0900 E/WMS     (  484): ##WMS RECEIVED : mgr_text_template_db_sync_req
05-29 14:55:35.637+0900 E/WMS     (  484): ==========
05-29 14:55:35.637+0900 E/WMS     (  484): wms_event_handler.c: handle_mgr_text_template_db_sync_req(16834) > checked : 0, id : 0, body : 어떻게 지내요?
05-29 14:55:35.637+0900 E/WMS     (  484): wms_event_handler.c: handle_mgr_text_template_db_sync_req(16834) > checked : 1, id : 1, body : 무슨 일이에요?
05-29 14:55:35.637+0900 E/WMS     (  484): wms_event_handler.c: handle_mgr_text_template_db_sync_req(16834) > checked : 2, id : 2, body : 나중에 이야기해요.
05-29 14:55:35.637+0900 E/WMS     (  484): wms_event_handler.c: handle_mgr_text_template_db_sync_req(16834) > checked : 3, id : 3, body : 나중에 전화할게요.
05-29 14:55:35.637+0900 E/WMS     (  484): wms_event_handler.c: handle_mgr_text_template_db_sync_req(16834) > checked : 4, id : 4, body : 어디에 있나요?
05-29 14:55:35.642+0900 E/WMS     (  484): wms_event_handler.c: handle_mgr_text_template_db_sync_req(16834) > checked : 5, id : 5, body : 언제 만날까요?
05-29 14:55:35.642+0900 E/WMS     (  484): wms_event_handler.c: handle_mgr_text_template_db_sync_req(16834) > checked : 6, id : 6, body : 나중에 전화해 주세요.
05-29 14:55:35.642+0900 E/WMS     (  484): wms_db.c: remove_db_table(385) > remove_db_table is called
05-29 14:55:35.642+0900 E/WMS     (  484): wms_db.c: insert_db_table(309) > insert_db_table is called
05-29 14:55:35.642+0900 E/WMS     (  484): wms_db.c: insert_db_table(332) > id 0, checked 0, body 어떻게 지내요?
05-29 14:55:35.647+0900 E/WMS     (  484): wms_db.c: insert_db_table(332) > id 1, checked 1, body 무슨 일이에요?
05-29 14:55:35.647+0900 E/WMS     (  484): wms_db.c: insert_db_table(332) > id 2, checked 2, body 나중에 이야기해요.
05-29 14:55:35.652+0900 E/WMS     (  484): wms_db.c: insert_db_table(332) > id 3, checked 3, body 나중에 전화할게요.
05-29 14:55:35.652+0900 E/WMS     (  484): wms_db.c: insert_db_table(332) > id 4, checked 4, body 어디에 있나요?
05-29 14:55:35.652+0900 E/WMS     (  484): wms_db.c: insert_db_table(332) > id 5, checked 5, body 언제 만날까요?
05-29 14:55:35.657+0900 E/WMS     (  484): wms_db.c: insert_db_table(332) > id 6, checked 6, body 나중에 전화해 주세요.
05-29 14:55:35.657+0900 E/WMS     (  484): wms_db.c: free_tt_list(164) > free_tt_list is called
05-29 14:55:35.657+0900 E/WMS     (  484): wms_msg_broker.c: wms_msg_broker_send(1743) > 
05-29 14:55:35.657+0900 E/WMS     (  484): ==========
05-29 14:55:35.657+0900 E/WMS     (  484): ##WMS SEND : mgr_text_template_db_sync_res
05-29 14:55:35.657+0900 E/WMS     (  484): ==========
05-29 14:55:35.657+0900 E/WMS     (  484): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 81 MAX Buffer Size: 61440
05-29 14:55:35.657+0900 E/WMS     (  484): wms_event_handler.c: wms_event_handler_routine(21115) > [mgr_text_template_db_sync_req] handler success.
05-29 14:55:35.672+0900 W/SCSD    (10460): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x56)
05-29 14:55:35.672+0900 W/SCSD    (10460): <on_sap_socket_recv:30>  - remain length: 86, crc_size: 4
05-29 14:55:35.672+0900 W/SCSD    (10460): <on_sap_socket_recv:62>  - recv 90 bytes [90 / 90] 
05-29 14:55:35.672+0900 W/SCSD    (10460): <util_scs_send:975> sent [92 / 92] bytes. 
05-29 14:55:46.807+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 14:55:46.812+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 14:55:46.812+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 14:55:46.812+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 1
05-29 14:55:46.812+0900 W/W_HOME  (  714): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 14:55:46.812+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:55:46.812+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-29 14:55:46.812+0900 W/STARTER (  682): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 14:55:46.817+0900 E/STARTER (  682): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 14:55:46.817+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 14:55:46.817+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 14:55:46.852+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 14:55:46.852+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 14:55:46.852+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 14:55:46.857+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 14:55:46.867+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 14:55:46.867+0900 W/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 14:55:46.867+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 14:55:46.867+0900 I/HIGEAR  ( 1102): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 14:55:46.912+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 14:55:46.912+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 14:55:46.912+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 14:55:46.912+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 14:55:46.922+0900 I/APP_CORE(20641): appcore-efl.c: __do_app(429) > [APP 20641] Event: PAUSE State: RUNNING
05-29 14:55:46.922+0900 I/CAPI_APPFW_APPLICATION(20641): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 14:55:46.977+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 14:55:46.997+0900 E/ALARM_MANAGER(  682): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 14:56:07), repeat(1), interval(20), type(-1073741822)
05-29 14:55:47.002+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:55:47.007+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:55:47.042+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 14:55:47.042+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 14:55:47.077+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1718851486, next duetime: 1464501367
05-29 14:55:47.077+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1718851486)
05-29 14:55:47.077+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464501809), due_time(1464501367)
05-29 14:55:47.077+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:55:47.077+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:56:07 (UTC).
05-29 14:55:47.077+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:55:55.642+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-29 14:55:55.642+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-29 14:55:55.642+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 14:55:55.667+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
05-29 14:55:55.677+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
05-29 14:55:55.677+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
05-29 14:55:55.677+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 14:55:55.677+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 14:55:55.677+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 14:55:55.682+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-29 14:55:55.682+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-29 14:55:55.682+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 14:55:55.682+0900 W/W_HOME  (  714): gesture.c: _apps_status_get(123) > apps status:0
05-29 14:55:55.682+0900 W/W_HOME  (  714): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:8959
05-29 14:55:55.682+0900 W/W_HOME  (  714): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-29 14:55:55.682+0900 W/W_HOME  (  714): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-29 14:55:55.682+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:55:55.682+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [unknown] after screen off time [8959]ms
05-29 14:55:55.682+0900 W/STARTER (  682): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-29 14:55:55.692+0900 I/APP_CORE(20641): appcore-efl.c: __do_app(429) > [APP 20641] Event: RESUME State: PAUSED
05-29 14:55:55.692+0900 I/CAPI_APPFW_APPLICATION(20641): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-29 14:55:55.702+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:55:55.702+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : 1075153676[0;m
05-29 14:55:55.702+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-29 14:55:55.702+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-29 14:55:55.707+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:55:55.707+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1718851486)
05-29 14:55:55.707+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:55:55.707+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 06:03:29 (UTC).
05-29 14:55:55.707+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:55:55.707+0900 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1718851486] is removed.
05-29 14:55:55.762+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [unknown]
05-29 14:55:55.762+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-29 14:55:55.857+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 14:55:55.857+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 14:55:55.857+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-29 14:55:55.857+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:55:55.857+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:55:55.857+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-29 14:55:55.857+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:55:55.857+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:55:55.857+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-29 14:55:55.882+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-29 14:55:55.882+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 0
05-29 14:55:56.362+0900 E/EFL     (20641): evas_main<20641> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=19704230 button=1 downs=1
05-29 14:55:56.422+0900 E/EFL     (20641): evas_main<20641> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=19704290 button=1 downs=0
05-29 14:55:56.422+0900 E/SCREENTEST(20641): start_screen = 1
05-29 14:55:56.467+0900 D/TIMER   (20641): Timer edj path: /opt/usr/apps/org.example.ph1/res//edje/timer.edj
05-29 14:55:56.467+0900 D/TIMER   (20641): Timer control dot path: /opt/usr/apps/org.example.ph1/res//time_picker_control_dot.png
05-29 14:55:56.517+0900 I/efl-extension(20641): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 14:55:56.517+0900 I/efl-extension(20641): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
05-29 14:55:56.517+0900 I/efl-extension(20641): efl_extension_rotary.c: _init_Xi2_system(314) > In
05-29 14:55:56.522+0900 I/efl-extension(20641): efl_extension_rotary.c: _init_Xi2_system(375) > Done
05-29 14:55:56.522+0900 I/efl-extension(20641): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44c06858, elm_layout, _activated_obj : 0x0, activated : 1
05-29 14:55:57.502+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 14:55:57.502+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 14:56:01.247+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 14:56:01.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 14:56:01.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-29 14:56:01.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:56:01.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:56:01.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-29 14:56:01.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 14:56:01.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 14:56:01.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-29 14:56:07.902+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 14:56:11.007+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
05-29 14:56:11.012+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-29 14:56:11.012+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 14:56:11.012+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 1
05-29 14:56:11.012+0900 W/W_HOME  (  714): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-29 14:56:11.012+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:56:11.017+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-29 14:56:11.017+0900 W/STARTER (  682): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-29 14:56:11.017+0900 E/STARTER (  682): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-29 14:56:11.017+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-29 14:56:11.017+0900 W/STARTER (  682): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-29 14:56:11.032+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
05-29 14:56:11.032+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-29 14:56:11.032+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-29 14:56:11.042+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
05-29 14:56:11.052+0900 I/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-29 14:56:11.052+0900 W/TIZEN_N_SOUND_MANAGER( 1102): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-29 14:56:11.052+0900 W/WAKEUP-SERVICE( 1102): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-29 14:56:11.052+0900 I/HIGEAR  ( 1102): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-29 14:56:11.132+0900 W/STARTER (  682): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-29 14:56:11.132+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-29 14:56:11.137+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-29 14:56:11.137+0900 W/STARTER (  682): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
05-29 14:56:11.152+0900 I/APP_CORE(20641): appcore-efl.c: __do_app(429) > [APP 20641] Event: PAUSE State: RUNNING
05-29 14:56:11.152+0900 I/CAPI_APPFW_APPLICATION(20641): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-29 14:56:11.212+0900 E/ALARM_MANAGER(  682): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(29-5-2016, 14:56:31), repeat(1), interval(20), type(-1073741822)
05-29 14:56:11.222+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:56:11.227+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:56:11.252+0900 W/MUSIC_CONTROL_SERVICE( 1233): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1233]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-29 14:56:11.277+0900 I/SHealth_Common( 1036): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-29 14:56:11.277+0900 I/SHealth_Service( 1036): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-29 14:56:11.302+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 862999868, next duetime: 1464501391
05-29 14:56:11.302+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(862999868)
05-29 14:56:11.302+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464501809), due_time(1464501391)
05-29 14:56:11.302+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:56:11.302+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:56:31 (UTC).
05-29 14:56:11.302+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:56:30.997+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-29 14:56:31.057+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-29 14:56:31.162+0900 E/RESOURCED(  488): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 682
05-29 14:56:31.182+0900 E/ALARM_MANAGER(  682): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [862999868]
05-29 14:56:31.182+0900 W/STARTER (  682): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(927) > [__starter_clock_mgr_homescreen_alarm_cb:927] homescreen alarm timer expired [862999868]
05-29 14:56:31.197+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 0
05-29 14:56:31.197+0900 W/AUL_AMD (  487): amd_launch.c: _start_app(1702) > caller pid : 682
05-29 14:56:31.207+0900 W/AUL_AMD (  487): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 714
05-29 14:56:31.212+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESET State: PAUSED
05-29 14:56:31.212+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_reset(245) > app_appcore_reset
05-29 14:56:31.212+0900 W/W_HOME  (  714): main.c: _app_control(1726) > Service value : show_clock
05-29 14:56:31.212+0900 W/W_HOME  (  714): main.c: _app_control(1762) > Show clock operation
05-29 14:56:31.212+0900 W/W_HOME  (  714): gesture.c: _clock_show(228) > clock show
05-29 14:56:31.217+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(714), cmd(0)
05-29 14:56:31.217+0900 W/W_HOME  (  714): gesture.c: _clock_show(243) > home raise
05-29 14:56:31.217+0900 E/W_HOME  (  714): gesture.c: gesture_win_aux_set(396) > wm.policy.win.do.not.use.deiconify.approve:-1
05-29 14:56:31.217+0900 W/W_HOME  (  714): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
05-29 14:56:31.217+0900 W/W_HOME  (  714): gesture.c: _clock_show(246) > home raise done
05-29 14:56:31.217+0900 W/W_HOME  (  714): gesture.c: _clock_show(253) > show clock
05-29 14:56:31.217+0900 W/W_HOME  (  714): move.c: move_back_to_home_no_anim(274) > back to home no anim
05-29 14:56:31.227+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_expired(1322) > alarm_id[862999868] is expired.
05-29 14:56:31.227+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 862999868, next duetime: 1464501411
05-29 14:56:31.227+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:56:31.227+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 05:56:51 (UTC).
05-29 14:56:31.227+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:56:31.227+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-29 14:56:31.232+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x4778eb48
05-29 14:56:31.232+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4778eb48, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-29 14:56:31.232+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 14:56:31.232+0900 W/W_HOME  (  714): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
05-29 14:56:31.232+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:3, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:56:31.232+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 14:56:31.232+0900 W/W_HOME  (  714): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
05-29 14:56:31.232+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:3, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.232+0900 W/W_HOME  (  714): rotary.c: rotary_deattach(156) > rotary_deattach:0x4778eb48
05-29 14:56:31.232+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 14:56:31.232+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4778eb48, elm_layout, func : 0x4004b469
05-29 14:56:31.232+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-29 14:56:31.232+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-29 14:56:31.232+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 14:56:31.232+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c96248, elm_box, _activated_obj : 0x4778eb48, activated : 1
05-29 14:56:31.232+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 14:56:31.232+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 14:56:31.232+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
05-29 14:56:31.232+0900 W/W_HOME  (  714): scroller.c: _get_index_in_list(1913) > page:0x45ce3638 idx:1 total7 exist:1
05-29 14:56:31.237+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c93cc8), origin_x(0), origin_y(0)
05-29 14:56:31.247+0900 E/wnotibp (16510): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 14:56:31.247+0900 W/wnotibp (16510): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1735) > [0, 2, 1]
05-29 14:56:31.257+0900 W/W_HOME  (  714): gesture.c: _widget_updated_cb(190) > widget updated
05-29 14:56:31.257+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-29 14:56:31.257+0900 W/W_HOME  (  714): gesture.c: _manual_render(176) > 
05-29 14:56:31.267+0900 E/E17     (  382): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02600003)
05-29 14:56:31.277+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 14:56:31.277+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 14:56:31.282+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-29 14:56:31.282+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 14:56:31.282+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 14:56:31.287+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(862999868)
05-29 14:56:31.287+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 14:56:31.287+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 06:03:29 (UTC).
05-29 14:56:31.287+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 14:56:31.287+0900 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[862999868] is removed.
05-29 14:56:31.332+0900 W/W_HOME  (  714): gesture.c: _manual_render(176) > 
05-29 14:56:31.347+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 0
05-29 14:56:31.347+0900 W/W_HOME  (  714): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
05-29 14:56:31.347+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.352+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
05-29 14:56:31.352+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
05-29 14:56:31.352+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
05-29 14:56:31.352+0900 W/W_HOME  (  714): event_manager.c: _apptray_visibility_cb(578) > apps,hide,start
05-29 14:56:31.352+0900 W/W_HOME  (  714): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-29 14:56:31.352+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.352+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.352+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.352+0900 W/W_HOME  (  714): noti_broker.c: _apptray_visibility_cb(788) > apps,hide,start
05-29 14:56:31.352+0900 W/W_HOME  (  714): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
05-29 14:56:31.352+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
05-29 14:56:31.352+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
05-29 14:56:31.352+0900 W/W_HOME  (  714): event_manager.c: _apptray_visibility_cb(578) > apps,hide
05-29 14:56:31.352+0900 W/W_HOME  (  714): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
05-29 14:56:31.352+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.352+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.352+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.352+0900 W/W_HOME  (  714): noti_broker.c: _apptray_visibility_cb(788) > apps,hide
05-29 14:56:31.352+0900 W/W_HOME  (  714): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80001
05-29 14:56:31.352+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80001
05-29 14:56:31.352+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1709) > is_app_tray_displayed: 0
05-29 14:56:31.362+0900 E/APPS    (  714): apps_main.c: apps_main_pause(587) >  paused already
05-29 14:56:31.392+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 14:56:31.392+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.392+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.392+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.392+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 14:56:31.447+0900 I/APP_CORE(20641): appcore-efl.c: __do_app(429) > [APP 20641] Event: PAUSE State: PAUSED
05-29 14:56:31.452+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 14:56:31.452+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 14:56:31.452+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-29 14:56:31.452+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 14:56:31.452+0900 I/APP_CORE(20641): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
05-29 14:56:31.452+0900 I/APP_CORE(  714): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
05-29 14:56:31.452+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 14:56:31.452+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 14:56:31.452+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 14:56:31.477+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-29 14:57:45.984+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 14:57:46.009+0900 E/DBG_PAD (29186): discovery.c: _discovery_thread(74) > Unknown packet, 5
05-29 14:57:46.009+0900 E/DBG_PAD (29186): 192.168.123.104:26101
05-29 14:57:46.009+0900 E/DBG_PAD (29186): ,24
05-29 14:57:48.014+0900 I/APP_CORE(20641): appcore-efl.c: __do_app(429) > [APP 20641] Event: MEM_FLUSH State: PAUSED
05-29 14:57:48.229+0900 E/CAPI_SYSTEM_INFO(29193): system_info_parse.c: system_info_get_value_from_config_xml(279) > cannot find tizen.org/feature/container field from /etc/config/model-config.xml file!!!
05-29 14:57:48.234+0900 E/CAPI_SYSTEM_INFO(29193): system_info.c: system_info_get_platform_bool(293) > cannot get tizen.org/feature/container
05-29 14:58:15.999+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 73 -> 72 1464501496 287
05-29 14:58:16.009+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 72 1034 533 1241
05-29 14:58:16.014+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 72 0 0 1769
05-29 14:58:16.014+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 72 705 270 846
05-29 14:58:16.014+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 72 225 5 270
05-29 14:58:16.014+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 72 237 21 284
05-29 14:58:29.149+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 14:58:29.149+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 14:58:45.664+0900 E/SHealth_Common( 1036): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-29 14:59:08.829+0900 E/PKGMGR_SERVER(21186): pkgmgr-server.c: main(2131) > package manager server start
05-29 14:59:08.914+0900 E/PKGMGR_SERVER(21186): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_-694871019], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[6eu6K9pkHISk50jwv7MulBnpkI4=], backend_flag=[0]
05-29 14:59:08.924+0900 E/PKGMGR_SERVER(21187): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-29 14:59:08.929+0900 E/PKGMGR  (21184): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-29 14:59:08.999+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:09.009+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20641
05-29 14:59:09.009+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 14:59:09.014+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 5
05-29 14:59:09.019+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(20641), cmd(4)
05-29 14:59:09.024+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:09.024+0900 I/APP_CORE(20641): appcore-efl.c: __do_app(429) > [APP 20641] Event: TERMINATE State: PAUSED
05-29 14:59:09.034+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20641
05-29 14:59:09.034+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 14:59:09.034+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 14:59:09.134+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:09.144+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20641
05-29 14:59:09.224+0900 I/APP_CORE(20641): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 14:59:09.224+0900 I/CAPI_APPFW_APPLICATION(20641): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-29 14:59:09.254+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:09.324+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20641
05-29 14:59:09.394+0900 I/efl-extension(20641): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c06858
05-29 14:59:09.399+0900 I/efl-extension(20641): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c06858, obj: 0x44c06858
05-29 14:59:09.399+0900 I/efl-extension(20641): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 14:59:09.399+0900 I/efl-extension(20641): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 14:59:09.404+0900 I/efl-extension(20641): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 14:59:09.404+0900 I/efl-extension(20641): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 14:59:09.429+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:09.454+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20641
05-29 14:59:09.474+0900 I/MALI    (20641): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 14:59:09.474+0900 I/MALI    (20641): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=20641   close drm_fd=25 
05-29 14:59:09.474+0900 I/MALI    (20641): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 14:59:09.559+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:09.574+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20641
05-29 14:59:09.594+0900 I/UXT     (20641): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 14:59:09.679+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:09.689+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20641
05-29 14:59:09.799+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:09.874+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20641
05-29 14:59:09.979+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:09.999+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20641
05-29 14:59:10.109+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:10.119+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20641
05-29 14:59:10.224+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 14:59:10.239+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 14:59:10.254+0900 E/PKGMGR_SERVER(21187): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-29 14:59:10.294+0900 E/PKGMGR_SERVER(21186): pkgmgr-server.c: sighandler(409) > child NORMAL exit [21187]
05-29 14:59:10.384+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 23
05-29 14:59:10.384+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 14:59:10.384+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 20641
05-29 14:59:10.384+0900 W/AUL_AMD (  487): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-29 14:59:10.389+0900 E/AUL     (21208): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-29 14:59:10.414+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 20641
05-29 14:59:10.414+0900 W/CRASH_MANAGER(21205): worker.c: worker_job(1199) > 0420641706831146450154
