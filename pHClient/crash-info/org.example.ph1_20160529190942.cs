S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 2363
Date: 2016-05-29 19:09:42+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x404a0250, r3   = 0x00000000
r4   = 0xbef85648, r5   = 0x4435d940
r6   = 0x40002238, r7   = 0x00000000
r8   = 0x4435c2c0, r9   = 0x440521b8
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4008d490, sp   = 0xbef85638
lr   = 0x403e91e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     11492 KB
Buffers:     37324 KB
Cached:     120412 KB
VmPeak:     106148 KB
VmSize:      97960 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21592 KB
VmRSS:       21592 KB
VmData:      43456 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       49712 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2363 TID = 2363
2363 2370 2373 2625 

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
43759000 4376d000 rwxp [stack:2370]
4376d000 43770000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43777000 43778000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b4000 440b6000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44bee000 44bf1000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44bf1000 44bf5000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44d01000 45500000 rwxp [stack:2625]
45548000 45557000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
4562b000 45e2a000 rwxp [stack:2373]
bef65000 bef86000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2363)
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
.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:56.938+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:56.938+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:56.938+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:56.938+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23761715
05-29 19:07:56.938+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.058+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.058+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.058+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.058+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.058+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23761836
05-29 19:07:57.058+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.103+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.108+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.108+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.108+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.108+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23761882
05-29 19:07:57.108+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.158+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.158+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.158+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.158+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.158+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23761934
05-29 19:07:57.158+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.238+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.238+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.238+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.238+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.238+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762013
05-29 19:07:57.238+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.288+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.288+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.293+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.293+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.293+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762068
05-29 19:07:57.293+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.323+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.323+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.323+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.328+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.328+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762102
05-29 19:07:57.328+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.353+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.353+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.353+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.353+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.353+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762131
05-29 19:07:57.353+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.378+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.378+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.378+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.383+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.383+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762157
05-29 19:07:57.383+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.423+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.423+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.423+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.423+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.423+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762199
05-29 19:07:57.423+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.473+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.473+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.473+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.473+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.473+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762248
05-29 19:07:57.473+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.498+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.498+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.498+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.503+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.503+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762277
05-29 19:07:57.503+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.538+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.538+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.538+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.538+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.538+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762315
05-29 19:07:57.538+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.583+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.583+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.583+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.583+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.583+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762360
05-29 19:07:57.583+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.668+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.668+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.668+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.668+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.668+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762446
05-29 19:07:57.668+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.773+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.773+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.773+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.773+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.773+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762548
05-29 19:07:57.773+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.828+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.833+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.833+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.833+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.833+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762608
05-29 19:07:57.833+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.873+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.873+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.873+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.873+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.873+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762650
05-29 19:07:57.878+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.898+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.898+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.898+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.903+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.903+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762677
05-29 19:07:57.908+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.933+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.933+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.933+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.938+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.938+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.938+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762712
05-29 19:07:57.973+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.973+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.973+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.973+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:57.973+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762751
05-29 19:07:57.973+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.028+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.028+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.028+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762806
05-29 19:07:58.028+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.033+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.033+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.113+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.113+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.113+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.113+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.113+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23762889
05-29 19:07:58.113+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.243+0900 I/efl-extension(  714): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.243+0900 I/efl-extension(16510): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.243+0900 I/efl-extension( 2363): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.243+0900 I/efl-extension( 1468): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.243+0900 I/efl-extension( 1797): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-29 19:07:58.248+0900 I/efl-extension( 2363): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x44c06558, elm_layout, time_stamp : 23763021
05-29 19:07:59.363+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 19:07:59.363+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 19:07:59.363+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-29 19:07:59.363+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 19:07:59.363+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 19:07:59.363+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-29 19:07:59.363+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 19:07:59.363+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 19:07:59.363+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-29 19:08:00.088+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 19:08:14.733+0900 I/HealthDataService( 1059): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-29 19:08:14.798+0900 I/healthData( 1036): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-29 19:08:18.108+0900 E/EFL     ( 2363): evas_main<2363> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=23782883 button=1 downs=1
05-29 19:08:18.143+0900 E/EFL     ( 2363): evas_main<2363> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=23782919 button=1 downs=0
05-29 19:08:18.143+0900 I/PTESTResetClicked( 2363): 1start_clicked
05-29 19:08:18.143+0900 I/PTESTResetClicked( 2363): 2before if
05-29 19:08:18.143+0900 I/PTESTResetClicked( 2363): 4if
05-29 19:08:18.143+0900 D/TIMER   ( 2363): Setting time is 100800
05-29 19:08:18.143+0900 I/ResetClicked( 2363): save_setting _time  : 100800
05-29 19:08:18.193+0900 I/BUG     ( 2363): sett : 100, settiingTime : 100800
05-29 19:08:18.198+0900 I/efl-extension( 2363): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:08:18.198+0900 I/efl-extension( 2363): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c06558, elm_layout, func : 0x40003941
05-29 19:08:18.198+0900 I/efl-extension( 2363): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-29 19:08:18.198+0900 I/efl-extension( 2363): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-29 19:08:18.198+0900 I/efl-extension( 2363): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 19:08:18.198+0900 I/efl-extension( 2363): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 19:08:18.198+0900 I/efl-extension( 2363): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 19:08:18.198+0900 I/efl-extension( 2363): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:08:18.273+0900 I/SOCKETTEST( 2363): Success to create socket
05-29 19:08:18.273+0900 I/SOCKETTEST( 2363): socket connect error: Network is unreachable
05-29 19:08:18.273+0900 I/SOCKETTEST( 2363): write() error: Bad file descriptor
05-29 19:08:18.368+0900 I/SENSOR  ( 2363): -7.420000, 10.920000, 0.840000
05-29 19:08:18.468+0900 I/SENSOR  ( 2363): 0.490000, 2.030000, -0.420000
05-29 19:08:18.578+0900 I/SENSOR  ( 2363): -1.050000, 2.310000, 1.820000
05-29 19:08:18.673+0900 I/SENSOR  ( 2363): 2.730000, 0.210000, -1.400000
05-29 19:08:18.773+0900 I/SENSOR  ( 2363): -2.100000, -1.120000, -0.210000
05-29 19:08:18.873+0900 I/SENSOR  ( 2363): -0.420000, -1.190000, 0.840000
05-29 19:08:18.973+0900 I/SENSOR  ( 2363): 0.280000, -0.140000, 0.770000
05-29 19:08:19.073+0900 I/SENSOR  ( 2363): -1.190000, -0.910000, 1.120000
05-29 19:08:19.173+0900 I/SENSOR  ( 2363): -0.700000, -0.770000, 1.050000
05-29 19:08:19.273+0900 I/SENSOR  ( 2363): 0.630000, -0.700000, 0.420000
05-29 19:08:19.368+0900 I/SENSOR  ( 2363): -0.490000, 0.490000, 1.260000
05-29 19:08:19.478+0900 I/SENSOR  ( 2363): 0.980000, -0.070000, -1.960000
05-29 19:08:19.573+0900 I/SENSOR  ( 2363): 0.070000, -0.840000, -1.050000
05-29 19:08:19.673+0900 I/SENSOR  ( 2363): 1.120000, 0.350000, 0.700000
05-29 19:08:19.773+0900 I/SENSOR  ( 2363): 0.840000, 0.910000, -1.050000
05-29 19:08:19.878+0900 I/SENSOR  ( 2363): -1.190000, 0.910000, -1.330000
05-29 19:08:19.973+0900 I/SENSOR  ( 2363): 0.980000, -1.890000, -2.730000
05-29 19:08:20.073+0900 I/SENSOR  ( 2363): -2.660000, -0.560000, -0.840000
05-29 19:08:20.173+0900 I/SENSOR  ( 2363): -1.610000, 0.770000, 0.980000
05-29 19:08:20.273+0900 I/SENSOR  ( 2363): 5.600000, -3.150000, -0.070000
05-29 19:08:20.373+0900 I/SENSOR  ( 2363): 24.010000, -22.190001, -20.020000
05-29 19:08:20.473+0900 I/SENSOR  ( 2363): -1.260000, 2.590000, 5.390000
05-29 19:08:20.578+0900 I/SENSOR  ( 2363): -0.980000, -2.870000, -0.210000
05-29 19:08:20.593+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 19:08:20.598+0900 I/RESOURCED(  488): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-29 19:08:20.598+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 19:08:20.678+0900 I/SENSOR  ( 2363): 15.330000, -9.170000, -13.650000
05-29 19:08:20.773+0900 I/SENSOR  ( 2363): 20.440001, -37.520000, -20.440001
05-29 19:08:20.868+0900 I/SENSOR  ( 2363): 4.550000, 1.960000, 16.870001
05-29 19:08:20.878+0900 E/EFL     ( 2363): evas_main<2363> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=23785654 button=1 downs=1
05-29 19:08:20.898+0900 E/EFL     ( 2363): evas_main<2363> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=23785676 button=1 downs=0
05-29 19:08:20.898+0900 I/PTESTResetClicked( 2363): 1start_clicked
05-29 19:08:20.898+0900 I/PTESTResetClicked( 2363): 2before if
05-29 19:08:20.898+0900 I/PTESTResetClicked( 2363): 3adtimer if
05-29 19:08:20.898+0900 I/efl-extension( 2363): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 19:08:20.898+0900 I/efl-extension( 2363): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 19:08:20.898+0900 I/efl-extension( 2363): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 19:08:20.918+0900 I/SOCKETTEST( 2363): Success to create socket
05-29 19:08:20.918+0900 I/SOCKETTEST( 2363): socket connect error: Network is unreachable
05-29 19:08:20.918+0900 I/SOCKETTEST( 2363): write() error: Bad file descriptor
05-29 19:08:20.928+0900 I/BUG     ( 2363): set_num : 1, ad->crecord : 2
05-29 19:08:20.928+0900 I/ResetClicked( 2363): Reset_Clicked_cb / num,time 1 2
05-29 19:08:21.393+0900 I/efl-extension( 2363): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44c06558
05-29 19:08:21.393+0900 I/efl-extension( 2363): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c06558, obj: 0x44c06558
05-29 19:08:21.398+0900 I/efl-extension( 2363): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 19:08:27.093+0900 E/EFL     ( 2363): evas_main<2363> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=23791868 button=1 downs=1
05-29 19:08:27.148+0900 E/EFL     ( 2363): evas_main<2363> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=23791926 button=1 downs=0
05-29 19:08:27.148+0900 I/ResetClicked( 2363): input_ record start
05-29 19:08:27.148+0900 I/2ResetClicked( 2363): count : 5
05-29 19:08:27.148+0900 I/3ResetClicked( 2363): end input record function
05-29 19:08:27.148+0900 I/ResetCalTime( 2363): m s 0 2
05-29 19:08:27.148+0900 I/ResetCalTime( 2363): str 00:02
05-29 19:08:27.148+0900 I/ResetClicked( 2363): clock_time 00:02
05-29 19:08:27.148+0900 I/ResetClicked( 2363): 2clock_timee 00:02
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 3clock_timee 00:02
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): m s 1680 0
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): str 168:00
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 4clock_timee 00:02
05-29 19:08:27.153+0900 I/ResetClicked( 2363): clock_total 168:00
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 5clock_timee 00:02
05-29 19:08:27.153+0900 I/11ResetClicked( 2363): ?? 1 ???? 1. 00:02
05-29 19:08:27.153+0900 I/11ResetClicked( 2363):  / 168:00
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): m s 0 2
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): str 00:02
05-29 19:08:27.153+0900 I/ResetClicked( 2363): clock_time 00:02
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 2clock_timee 00:02
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 3clock_timee 00:02
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): m s 3600 0
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): str 360:00
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 4clock_timee 00:02
05-29 19:08:27.153+0900 I/ResetClicked( 2363): clock_total 360:00
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 5clock_timee 00:02
05-29 19:08:27.153+0900 I/11ResetClicked( 2363): ?? 2 ???? 2. 00:02
05-29 19:08:27.153+0900 I/11ResetClicked( 2363):  / 360:00
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): m s 0 24
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): str 00:24
05-29 19:08:27.153+0900 I/ResetClicked( 2363): clock_time 00:24
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 2clock_timee 00:24
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 3clock_timee 00:24
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): m s 10 0
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): str 10:00
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 4clock_timee 00:24
05-29 19:08:27.153+0900 I/ResetClicked( 2363): clock_total 10:00
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 5clock_timee 00:24
05-29 19:08:27.153+0900 I/11ResetClicked( 2363): ?? 3 ???? 3. 00:24
05-29 19:08:27.153+0900 I/11ResetClicked( 2363):  / 10:00
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): m s 0 13
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): str 00:13
05-29 19:08:27.153+0900 I/ResetClicked( 2363): clock_time 00:13
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 2clock_timee 00:13
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 3clock_timee 00:13
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): m s 60 11
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): str 60:11
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 4clock_timee 00:13
05-29 19:08:27.153+0900 I/ResetClicked( 2363): clock_total 60:11
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 5clock_timee 00:13
05-29 19:08:27.153+0900 I/11ResetClicked( 2363): ?? 4 ???? 4. 00:13
05-29 19:08:27.153+0900 I/11ResetClicked( 2363):  / 60:11
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): m s 0 50
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): str 00:50
05-29 19:08:27.153+0900 I/ResetClicked( 2363): clock_time 00:50
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 2clock_timee 00:50
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 3clock_timee 00:50
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): m s 24 0
05-29 19:08:27.153+0900 I/ResetCalTime( 2363): str 24:00
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 4clock_timee 00:50
05-29 19:08:27.153+0900 I/ResetClicked( 2363): clock_total 24:00
05-29 19:08:27.153+0900 I/ResetClicked( 2363): 5clock_timee 00:50
05-29 19:08:27.153+0900 I/11ResetClicked( 2363): ?? 5 ???? 5. 00:50
05-29 19:08:27.153+0900 I/11ResetClicked( 2363):  / 24:00
05-29 19:08:27.198+0900 I/efl-extension( 2363): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
05-29 19:08:27.203+0900 I/efl-extension( 2363): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44341f60, elm_image, _activated_obj : 0x0, activated : 1
05-29 19:08:27.223+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x4428bd00]'s widget[0x442a6c28] to layout widget[0x443423e0]
05-29 19:08:27.223+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x4428bd00 = w: 0 h: 0  obj 0x442a6c28 w: 360 h: 360
05-29 19:08:27.228+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:08:59.363+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-29 19:08:59.368+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-29 19:08:59.373+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : pedometer_inactive_period error
05-29 19:08:59.373+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 19:08:59.373+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 19:08:59.378+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_10min_precaution_millisec error
05-29 19:08:59.378+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-29 19:08:59.393+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-29 19:08:59.393+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1036): preference.c: preference_get_double(1214) > preference_get_double(1036) : inactive_before_10min_precaution_millisec error
05-29 19:09:00.133+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 19:09:20.653+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 19:09:20.653+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 19:09:41.848+0900 E/PKGMGR_SERVER( 2797): pkgmgr-server.c: main(2131) > package manager server start
05-29 19:09:41.933+0900 E/PKGMGR_SERVER( 2797): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_1453249576], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[mB4KEeGpAfQwmO05qUoYyLdj9Dw=], backend_flag=[0]
05-29 19:09:41.968+0900 E/PKGMGR_SERVER( 2799): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-29 19:09:41.973+0900 E/PKGMGR  ( 2791): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-29 19:09:42.038+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:09:42.043+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2363
05-29 19:09:42.048+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 19:09:42.053+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 5
05-29 19:09:42.058+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(2363), cmd(4)
05-29 19:09:42.058+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:09:42.063+0900 I/APP_CORE( 2363): appcore-efl.c: __do_app(429) > [APP 2363] Event: TERMINATE State: RUNNING
05-29 19:09:42.068+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2363
05-29 19:09:42.068+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 19:09:42.068+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 19:09:42.123+0900 I/APP_CORE( 2363): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 19:09:42.123+0900 I/CAPI_APPFW_APPLICATION( 2363): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-29 19:09:42.143+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 19:09:42.143+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 19:09:42.158+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 19:09:42.158+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(967) > Private Surface will be initialized for widget[0x44341f60], circle_obj[0x4431edc8]!
05-29 19:09:42.158+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x4436f940 = w: 0 h: 0  obj 0x44341f60 w: 360 h: 360
05-29 19:09:42.158+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 19:09:42.158+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4428bd00 is freed
05-29 19:09:42.158+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4436f5e0 is freed
05-29 19:09:42.168+0900 I/efl-extension( 2363): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44c066d8, obj: 0x44c066d8
05-29 19:09:42.168+0900 I/efl-extension( 2363): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
05-29 19:09:42.168+0900 I/efl-extension( 2363): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
05-29 19:09:42.168+0900 I/efl-extension( 2363): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
05-29 19:09:42.168+0900 I/efl-extension( 2363): efl_extension_rotary.c: _object_deleted_cb(601) > done
05-29 19:09:42.178+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 19:09:42.178+0900 I/efl-extension( 2363): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x4436f940 is freed
05-29 19:09:42.178+0900 I/efl-extension( 2363): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x44341f60
05-29 19:09:42.178+0900 I/efl-extension( 2363): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-29 19:09:42.178+0900 I/efl-extension( 2363): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44c066d8, elm_genlist, func : 0x4011bdfd
05-29 19:09:42.178+0900 I/efl-extension( 2363): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-29 19:09:42.183+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:09:42.183+0900 I/MALI    ( 2363): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f603f8] swap changed from sync to async
05-29 19:09:42.193+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2363
05-29 19:09:42.213+0900 I/MALI    ( 2363): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 19:09:42.213+0900 I/MALI    ( 2363): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=2363   close drm_fd=25 
05-29 19:09:42.213+0900 I/MALI    ( 2363): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 19:09:42.263+0900 I/UXT     ( 2363): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 19:09:42.268+0900 W/PROCESSMGR(  382): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-29 19:09:42.268+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-29 19:09:42.268+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-29 19:09:42.268+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 19:09:42.268+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 19:09:42.268+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 19:09:42.293+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:09:42.298+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2363
05-29 19:09:42.323+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 19:09:42.323+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:09:42.323+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:09:42.323+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:09:42.323+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 19:09:42.323+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 19:09:42.323+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 19:09:42.323+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:09:42.323+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 19:09:42.323+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
05-29 19:09:42.328+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 19:09:42.328+0900 W/W_HOME  (  714): main.c: _appcore_resume_cb(681) > appcore resume
05-29 19:09:42.328+0900 W/W_HOME  (  714): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-29 19:09:42.328+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:09:42.328+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:09:42.328+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 19:09:42.328+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 19:09:42.328+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x45d34090
05-29 19:09:42.328+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d34090, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-29 19:09:42.328+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 19:09:42.328+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 19:09:42.328+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 19:09:42.328+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
05-29 19:09:42.333+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 19:09:42.333+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 19:09:42.333+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 19:09:42.333+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 19:09:42.408+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:09:42.418+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2363
05-29 19:09:42.523+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:09:42.553+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2363
05-29 19:09:42.623+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 71 -> 70 1464516582 180
05-29 19:09:42.623+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 70 1023 552 1194
05-29 19:09:42.623+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 70 0 0 1667
05-29 19:09:42.623+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 70 704 289 821
05-29 19:09:42.623+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 70 0 0 0
05-29 19:09:42.623+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 70 0 0 0
05-29 19:09:42.658+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:09:42.668+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2363
05-29 19:09:42.768+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 19:09:42.783+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 19:09:42.788+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-29 19:09:42.793+0900 E/PKGMGR_SERVER( 2799): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-29 19:09:42.828+0900 E/PKGMGR_SERVER( 2797): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2799]
05-29 19:09:42.873+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 23
05-29 19:09:42.873+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 19:09:42.873+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 2363
05-29 19:09:42.878+0900 W/AUL_AMD (  487): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-29 19:09:42.878+0900 E/AUL     ( 2810): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
05-29 19:09:42.903+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2363
05-29 19:09:42.948+0900 W/CRASH_MANAGER( 2806): worker.c: worker_job(1199) > 1102363706831146451658
