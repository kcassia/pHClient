S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 28592
Date: 2016-05-29 11:49:50+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x404a0250, r3   = 0x00000000
r4   = 0xbe83f648, r5   = 0x44c3a9c0
r6   = 0x40002238, r7   = 0x00000000
r8   = 0x44c39340, r9   = 0x44c0dfd0
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4008d490, sp   = 0xbe83f638
lr   = 0x403e91e8, pc   = 0x00000000
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     14448 KB
Buffers:     47796 KB
Cached:     112376 KB
VmPeak:     113012 KB
VmSize:     101304 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23404 KB
VmRSS:       23404 KB
VmData:      45664 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       50676 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 28592 TID = 28592
28592 28598 28601 28677 

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
43759000 4376d000 rwxp [stack:28598]
4376d000 43770000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43777000 43778000 rwxp /usr/lib/libnative-buffer.so.0.1.0
440b4000 440b6000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
44384000 44b83000 rwxp [stack:28677]
44ba6000 44ba9000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
44ba9000 44bad000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
44bad000 44bbc000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
4578c000 4608b000 rwxp [stack:28601]
4658f000 46592000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46599000 4659a000 rwxp /usr/lib/libpulse-simple.so.0.0.4
46817000 4681c000 r-xp /usr/lib/libjson.so.0.0.1
46823000 46824000 rwxp /usr/lib/libjson.so.0.0.1
4694a000 46982000 r-xp /usr/lib/libpulse.so.0.16.2
46982000 46983000 rwxp /usr/lib/libpulse.so.0.16.2
469b4000 469fc000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
469fc000 469fd000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46b00000 46b43000 r-xp /usr/lib/libsndfile.so.1.0.25
46b4a000 46b4c000 rwxp /usr/lib/libsndfile.so.1.0.25
46b50000 46b72000 r-xp /usr/lib/libvorbis.so.0.4.3
46b79000 46b7a000 rwxp /usr/lib/libvorbis.so.0.4.3
46b7a000 46b7e000 r-xp /usr/lib/libogg.so.0.7.1
46b85000 46b86000 rwxp /usr/lib/libogg.so.0.7.1
be81f000 be840000 rwxp [stack]
End of Maps Information

Callstack Information (PID:28592)
Call Stack Count: 2
 0: cfree + 0xc8 (0x403e91e8) [/lib/libc.so.6] + 0x6f1e8
 1: (0x9876123b) (null)
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
37] TimeToFull: 24 104 65 132
05-29 11:45:31.796+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 24 102 5 129
05-29 11:45:31.796+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 24 111 12 141
05-29 11:45:37.646+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 11:45:37.646+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 11:46:00.666+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 11:46:37.646+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 11:46:37.646+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 11:46:37.646+0900 I/RESOURCED(  488): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
05-29 11:46:38.176+0900 E/EFL     (28592): evas_main<28592> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9385914 button=1 downs=1
05-29 11:46:38.246+0900 E/EFL     (28592): evas_main<28592> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9385983 button=1 downs=0
05-29 11:46:38.326+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x45627d70]'s widget[0x4566ab78] to layout widget[0x45629b50]
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x456281c0]'s widget[0x4566aff8] to layout widget[0x45629b50]
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45627d70 is freed
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x45628298]'s widget[0x4566b478] to layout widget[0x45629b50]
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x456281c0 is freed
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x456cbfa8]'s widget[0x4566b8f8] to layout widget[0x45629b50]
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x45628298 is freed
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_naviframe_item_view_add(846) > Put the surface[0x456cc020]'s widget[0x4566bd78] to layout widget[0x45629b50]
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x456cbfa8 is freed
05-29 11:46:38.331+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x456cc020 = w: 0 h: 0  obj 0x4566bd78 w: 360 h: 360
05-29 11:46:38.336+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
05-29 11:46:40.446+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:46:40.446+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x456cc020 is freed
05-29 11:46:44.441+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 24 -> 25 1464490004 73
05-29 11:46:44.446+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 25 98 161 123
05-29 11:46:44.446+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 25 0 0 102
05-29 11:46:44.446+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 25 103 66 129
05-29 11:46:44.446+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 25 92 5 115
05-29 11:46:44.446+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 25 107 13 134
05-29 11:47:00.706+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 11:47:37.691+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 11:47:37.696+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 11:48:00.746+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 11:48:12.996+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_handler_idle(1360) > Lock the display not to enter LCD OFF
05-29 11:48:13.051+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __display_lock_state(1692) > Lock LCD OFF is successfully done
05-29 11:48:13.106+0900 E/RESOURCED(  488): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 23598
05-29 11:48:13.116+0900 E/ALARM_MANAGER(23598): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.ascsd] : Alarm id [1876955833]
05-29 11:48:13.116+0900 W/SNL_W   (23598): <on_alarm_event:642> Awake to sendKeepAlive_Alarm() - begin,  mCurrentIntervalSeconds ( 240 )
05-29 11:48:13.116+0900 W/SNL_W   (23598): <on_alarm_event:652> sendKeepAlive_alarmthread detached successfully
05-29 11:48:13.116+0900 W/SNL_W   (23598): <on_alarm_event:656> sendKeepAlive_alarmthread - end 
05-29 11:48:13.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_expired(1322) > alarm_id[1876955833] is expired.
05-29 11:48:13.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1876955833)
05-29 11:48:13.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 11:48:13.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 03:02:45 (UTC).
05-29 11:48:13.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 11:48:13.116+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_handler_idle(1386) > Unlock the display from LCD OFF
05-29 11:48:13.131+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __display_unlock_state(1735) > Unlock LCD OFF is successfully done
05-29 11:48:13.131+0900 W/SNL_W   (23598): <sendKeepAliveAllGroup:670> sendKeepAliveAllGroup() - begin
05-29 11:48:13.136+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Call()
05-29 11:48:13.136+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Res( 0 )
05-29 11:48:13.136+0900 W/SNL_W   (23598): <util_pm_lock:1132> util_pm_lock() LOCK
05-29 11:48:13.156+0900 W/SNL_W   (23598): <sendKeepAliveAllGroup:706> releaseWakeLockinTimeThread detached successfully
05-29 11:48:13.156+0900 W/SNL_W   (23598): <sendKeepAliveAllGroup:719> 0 sendKeepAliveThread detached successfully
05-29 11:48:13.156+0900 W/SNL_W   (23598): <sendKeepAliveThread:863> sendKeepAliveThread() - presSendNotify(1) begin
05-29 11:48:13.156+0900 W/SCSD    (23598): <on_presSendNotify:426> sent keepalive (group_id: 3532130a434bf7f1bd119f41) (S:2/F:3/T:5) (msg_id: 1)
05-29 11:48:13.156+0900 W/SCSD    (23598): <_keepalive_cb:520> entrance
05-29 11:48:13.156+0900 W/SCSD    (23598): <util_dbus_send_keepalive_sent:287> entrance
05-29 11:48:13.156+0900 W/SNL_W   (23598): <sendKeepAliveThread:865> sendKeepAliveThread() - presSendNotify(1) end
05-29 11:48:13.156+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: sKA - group( 3532130a434bf7f1bd119f41 ) mtype( 1 ) timeout( 30000 )
05-29 11:48:13.156+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: sKAP
05-29 11:48:13.161+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: send_msg - ( 0xfd ), type( 0x01 ), res( 40 ), seq( 1012 )
05-29 11:48:13.161+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Call()
05-29 11:48:13.161+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Res( 0 )
05-29 11:48:13.161+0900 W/SNL_W   (23598): <presSendNotify_i:994> presSendNotify_w ( 3532130a434bf7f1bd119f41 ) - begin
05-29 11:48:13.161+0900 W/SNL_W   (23598): <presSendNotify_i:1017> presSendNotify_w ( 3532130a434bf7f1bd119f41 ) - end
05-29 11:48:13.161+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: noti_ps_th - Res( )
05-29 11:48:13.541+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: recv_msg(res) - ( 0xfd ), seq( 1012 )
05-29 11:48:13.546+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: sKA - res( 0 )
05-29 11:48:13.546+0900 W/SNL_W   (23598): <sendKeepAliveThread:870> sendKeepAliveThread() - group_id ( 3532130a434bf7f1bd119f41 ) sendKeepAliveType ( 1 ), PING_CNT ( 2 ) 
05-29 11:48:13.546+0900 W/SNL_W   (23598): <sendKeepAliveThread:879> sendKeepAliveThread() - presSendNotify(0) begin
05-29 11:48:13.546+0900 W/SCSD    (23598): <on_presSendNotify:426> sent keepalive (group_id: 3532130a434bf7f1bd119f41) (S:3/F:3/T:6) (msg_id: 0)
05-29 11:48:13.546+0900 W/SCSD    (23598): <_keepalive_cb:520> entrance
05-29 11:48:13.551+0900 W/SNL_W   (23598): <sendKeepAliveThread:881> sendKeepAliveThread() - presSendNotify(0) end
05-29 11:48:13.556+0900 W/SNL_W   (23598): <sendKeepAliveAllGroup:731> sendKeepAliveAllgroup() - groupList.size() : 0(f) + 1(p)
05-29 11:48:13.556+0900 W/SNL_W   (23598): <setAlarm:520> setAlarm() - begin 
05-29 11:48:13.556+0900 W/SNL_W   (23598): <initAlarm:505> InitAlarm() - begin
05-29 11:48:13.556+0900 W/SNL_W   (23598): <initAlarm:511> InitAlarm() success - end
05-29 11:48:13.631+0900 I/AUL     (23598): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-29 11:48:13.666+0900 I/AUL     (23598): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-29 11:48:13.666+0900 E/ALARM_MANAGER(23598): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(235), start(29-5-2016, 11:52:09), repeat(0), interval(0), type(-1073741822)
05-29 11:48:13.686+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
05-29 11:48:13.691+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
05-29 11:48:13.716+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-29 11:48:13.736+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-29 11:48:13.751+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-29 11:48:13.766+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-29 11:48:13.766+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __get_caller_unique_name(1587) > Try to read procfs cmdline
05-29 11:48:13.766+0900 W/ALARM_MANAGER(  485): alarm-manager.c: __get_caller_unique_name(1592) > Read procfs cmdline successfully
05-29 11:48:13.786+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-29 11:48:13.801+0900 I/AUL     (  485): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
05-29 11:48:13.801+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1464490329, Sun May 29 11:52:09 2016
05-29 11:48:13.801+0900 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1284895822, next duetime: 1464490329
05-29 11:48:13.801+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1284895822)
05-29 11:48:13.801+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1464490965), due_time(1464490329)
05-29 11:48:13.801+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-29 11:48:13.801+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 29-5-2016, 02:52:09 (UTC).
05-29 11:48:13.801+0900 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-29 11:48:13.806+0900 W/SNL_W   (23598): <setAlarm:569> setAlarm() - end : mStatus ( 2 ) currentInterval( 240 ) interruptFlag ( 0 ) alarm_id ( 1284895822 )
05-29 11:48:13.806+0900 W/SNL_W   (23598): <sendKeepAliveAllGroup:750> sendKeepAliveAllGroup() - set last interval ( 240 )
05-29 11:48:13.806+0900 W/SNL_W   (23598): <util_pm_unlock:1154> util_pm_unlock() UNLOCK
05-29 11:48:13.816+0900 W/SNL_W   (23598): <sendKeepAliveAllGroup:756> sendKeepAliveAllGroup () - WakeLock release
05-29 11:48:13.816+0900 W/SNL_W   (23598): <sendKeepAliveAllGroup:768> sendKeepAliveAllGroup() - end Error ( 0 )
05-29 11:48:13.861+0900 W/SNL_W   (23598): <releaseWakeLockinTimeThread:813> releaseWakeLockinTimeThread () - WakeLock already released
05-29 11:48:37.651+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 11:48:37.651+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 11:48:38.596+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 25 -> 26 1464490118 114
05-29 11:48:38.606+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 26 98 162 121
05-29 11:48:38.606+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 26 0 0 100
05-29 11:48:38.606+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 26 103 67 127
05-29 11:48:38.611+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 26 84 5 104
05-29 11:48:38.611+0900 I/RESOURCED(  488): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToFull: 26 104 14 128
05-29 11:48:39.026+0900 W/SNL_W   (23598): <checkTimeStamp:264> checkTimeStamp delete timestamp ( 1464489879 ) of conn_id( 2 ) - Current ( 1464490119 )
05-29 11:48:39.026+0900 W/SNL_W   (23598): <d2d_timeout_notify_callback:428> d2d_timeout_notify - begin conn_id ( 2 )
05-29 11:48:39.026+0900 W/SCSD    (23598): <on_d2dTimeoutNotify:522> conn_id: 2
05-29 11:48:39.026+0900 W/SCSD    (23598): <_disconnected_cb:492> SCS Peer Disconnected !!!
05-29 11:48:39.026+0900 W/SCSD    (23598): <_disconnected_cb:493>  - conn_id: 2
05-29 11:48:39.026+0900 W/SCSD    (23598): <util_dbus_set_connection_status:267> set connection_status: 0
05-29 11:48:39.051+0900 W/SNL_W   (23598): <d2d_timeout_notify_callback:430> d2d_timeout_notify - end conn_id ( 2 )
05-29 11:48:39.051+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: close - Call ConnID( 2 ), Timeout ( 1 )
05-29 11:48:39.066+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(374) > network status : 0
05-29 11:48:39.066+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(379) > sap_connected : 1
05-29 11:48:39.071+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(39) > [windicator_scs_update:39] sales code : 0
05-29 11:48:39.076+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(385) > sap connectivity type : 16
05-29 11:48:39.076+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(391) > network status : 2
05-29 11:48:39.081+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(405) > scs login : 1
05-29 11:48:39.081+0900 W/W_HOME  (  714): clock_event.c: _wmanager_connectivity_get(433) > network connection via WIFI : no checking svc_type
05-29 11:48:39.081+0900 W/W_HOME  (  714): clock_view_indicator.c: _view_remove_by_type(262) > removed:4
05-29 11:48:39.081+0900 W/W_HOME  (  714): clock_indicator.c: clock_indicator_pop(370) > icon:5(0) is popped from clock indicator
05-29 11:48:39.086+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: release_conn(2) read(5808), sent(1008)
05-29 11:48:39.086+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(46) > [windicator_scs_update:46] sap connected : 1
05-29 11:48:39.091+0900 I/W_INDICATOR(  685): windicator.c: windicator_is_lo_connected(689) > [windicator_is_lo_connected:689] Connected target vendor : samsung
05-29 11:48:39.091+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(81) > [windicator_scs_update:81] sap connectivity type : 16
05-29 11:48:39.091+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(88) > [windicator_scs_update:88] network status : 2
05-29 11:48:39.091+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(103) > [windicator_scs_update:103] scs login : 1
05-29 11:48:39.091+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(112) > [windicator_scs_update:112] network connection via WIFI : no checking svc_type
05-29 11:48:39.091+0900 W/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(149) > [windicator_scs_update:149] ciss_request_type : 0
05-29 11:48:39.091+0900 I/W_INDICATOR(  685): windicator_scs.c: windicator_scs_update(159) > [windicator_scs_update:159] Hide (Callforwarding requested)
05-29 11:48:39.306+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: recv - ConnID( 2 ), Res( -1 )
05-29 11:48:39.306+0900 E/SCSD    (23598): <recv_thread:183> sec_recv() ret: -1
05-29 11:48:39.306+0900 W/SNL_W   (23598): <sec_close_w:321> sec_close_w - sec_close_w begin()
05-29 11:48:39.306+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: close - Call ConnID( 2 ), Timeout ( 0 )
05-29 11:48:39.311+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: sc_dis connid( 2 ), way( 1)
05-29 11:48:39.311+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: sc_dis .
05-29 11:48:39.311+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: close - Res( 0 )
05-29 11:48:39.311+0900 W/SNL_W   (23598): <deleteConnIdData:205> ==== deleteConnIdData Start conn_id[2] ====
05-29 11:48:39.316+0900 W/SNL_W   (23598): <deleteConnIdData:218> deleteConnIdData timestamp( 1464489879 )
05-29 11:48:39.316+0900 W/SNL_W   (23598): <deleteConnIdData:233> ==== deleteConnIdData end res[0] ====
05-29 11:48:39.321+0900 W/SNL     (23598): Scone_Log.cpp: dump(2972) > SNL :: close - Res( -1 )
05-29 11:48:39.321+0900 W/SNL_W   (23598): <deleteConnIdData:205> ==== deleteConnIdData Start conn_id[2] ====
05-29 11:48:39.321+0900 W/SNL_W   (23598): <deleteConnIdData:233> ==== deleteConnIdData end res[0] ====
05-29 11:48:39.321+0900 W/SNL_W   (23598): <sec_close_w:325> sec_close_w - D2D close is Running -conn_id ( 2) deleted 
05-29 11:48:39.321+0900 W/SNL_W   (23598): <sec_close_w:328> sec_close_w - sec_close_w res( -1 )
05-29 11:48:39.321+0900 E/SCSD    (23598): <util_scs_close:1227> sec_close() failed. (ret:-1)
05-29 11:48:39.321+0900 E/SCSD    (23598): <util_scs_close:1231> message: Object Not Found
05-29 11:48:39.321+0900 W/SCSD    (23598): <_disconnected_cb:492> SCS Peer Disconnected !!!
05-29 11:48:39.321+0900 W/SCSD    (23598): <_disconnected_cb:493>  - conn_id: 2
05-29 11:48:39.321+0900 W/SCSD    (23598): <util_dbus_set_connection_status:263> same status(0)
05-29 11:49:00.776+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 11:49:21.031+0900 E/DBG_PAD (29186): bridge_g.c: _bt_thread(283) > bt sdb socket create failed.[0xFE400102]
05-29 11:49:22.696+0900 E/CAPI_SYSTEM_INFO(29193): system_info_parse.c: system_info_get_value_from_config_xml(279) > cannot find tizen.org/feature/container field from /etc/config/model-config.xml file!!!
05-29 11:49:22.701+0900 E/CAPI_SYSTEM_INFO(29193): system_info.c: system_info_get_platform_bool(293) > cannot get tizen.org/feature/container
05-29 11:49:37.641+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-29 11:49:37.646+0900 I/RESOURCED(  488): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-29 11:49:40.066+0900 W/WG-CONSUMER(29083): [34m[F:consumer-app.cpp L:  303][_HIGH]Checking consumer's state.[0m
05-29 11:49:40.076+0900 W/WG-CONSUMER(29083): [34m[F:SAPProxy.cpp     L:  332][_HIGH]Not BT/WFD connected. Cur type=16[0m
05-29 11:49:40.076+0900 W/WG-CONSUMER(29083): [34m[F:SAPProxy.cpp     L:  172][_HIGH]Device dis-connected. WMS=1 BT=0 [0m
05-29 11:49:40.076+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  113][_HIGH]SAP is not conneced.[0m
05-29 11:49:40.076+0900 W/WG-CONSUMER(29083): [34m[F:consumer-app.cpp L:  312][_HIGH]Transfer can be exit[0m
05-29 11:49:40.076+0900 W/WG-CONSUMER(29083): [34m[F:SAPProxy.cpp     L:  332][_HIGH]Not BT/WFD connected. Cur type=16[0m
05-29 11:49:40.076+0900 W/WG-CONSUMER(29083): [34m[F:SAPProxy.cpp     L:  172][_HIGH]Device dis-connected. WMS=1 BT=0 [0m
05-29 11:49:40.081+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  113][_HIGH]SAP is not conneced.[0m
05-29 11:49:40.081+0900 W/WG-CONSUMER(29083): [34m[F:consumer-app.cpp L:  317][_HIGH]Receiver can be exit[0m
05-29 11:49:40.081+0900 W/WG-CONSUMER(29083): [34m[F:consumer-app.cpp L:  320][_HIGH]Exit Condition. Tx=1 Rx=1[0m
05-29 11:49:40.081+0900 I/CAPI_APPFW_APPLICATION(29083): service_app_main.c: service_app_exit(441) > service_app_exit
05-29 11:49:40.091+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 11:49:40.091+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 11:49:40.096+0900 W/WG-CONSUMER(29083): [34m[F:consumer-app.cpp L:  165][_HIGH]Gallery consumer SVC is terminated[0m
05-29 11:49:40.096+0900 W/WG-CONSUMER(29083): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
05-29 11:49:40.096+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
05-29 11:49:40.096+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0x42e77878) Disconnect(155)[0m
05-29 11:49:40.096+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
05-29 11:49:40.096+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
05-29 11:49:40.096+0900 W/WG-CONSUMER(29083): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
05-29 11:49:40.096+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
05-29 11:49:40.191+0900 W/WG-CONSUMER(29083): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
05-29 11:49:40.191+0900 W/WG-CONSUMER(29083): [34m[F:ReceiverCtrl.cpp L:  502][_HIGH][RX]Disconnect to Peer[0m
05-29 11:49:40.191+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
05-29 11:49:40.191+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e78928) Disconnect(155)[0m
05-29 11:49:40.191+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
05-29 11:49:40.191+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
05-29 11:49:40.191+0900 W/WG-CONSUMER(29083): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
05-29 11:49:40.191+0900 W/WG-CONSUMER(29083): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
05-29 11:49:40.236+0900 I/CAPI_CONTENT_MEDIA_CONTENT(29083): media_content.c: media_content_disconnect(948) > [32m[29083]ref count changed to: 0
05-29 11:49:40.346+0900 E/WG-CONSUMER(29083): [31m[F:consumer-app.cpp L:  389][ERROR]Terminate main. nRet=0[0m
05-29 11:49:40.346+0900 W/WG-CONSUMER(29083): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
05-29 11:49:40.346+0900 W/WG-CONSUMER(29083): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e789d4)[0m
05-29 11:49:40.346+0900 W/WG-CONSUMER(29083): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
05-29 11:49:40.346+0900 W/WG-CONSUMER(29083): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
05-29 11:49:40.346+0900 W/WG-CONSUMER(29083): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e76844)[0m
05-29 11:49:40.421+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 23
05-29 11:49:40.421+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
05-29 11:49:40.421+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 29083
05-29 11:49:40.421+0900 W/AUL_AMD (  487): amd_request.c: __send_app_termination_signal(511) > send dead signal done
05-29 11:49:40.441+0900 I/AUL_AMD (  487): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 29083
05-29 11:49:42.096+0900 W/AUL_AMD (  487): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-29 11:49:49.611+0900 E/PKGMGR_SERVER(29284): pkgmgr-server.c: main(2131) > package manager server start
05-29 11:49:49.711+0900 E/PKGMGR_SERVER(29284): pkgmgr-server.c: req_cb(650) > req_id=[org.example.ph1_830780187], req_type=[12], pkg_type=[rpm], pkgid=[org.example.ph1], args=[], cookie=[1RpuON8dPF9Eyx/FJkk6lM17M54=], backend_flag=[0]
05-29 11:49:49.721+0900 E/PKGMGR_SERVER(29286): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[org.example.ph1]
05-29 11:49:49.726+0900 E/PKGMGR  (29278): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.ph1, -1]
05-29 11:49:49.786+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:49:49.796+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28592
05-29 11:49:49.796+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 12
05-29 11:49:49.801+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 5
05-29 11:49:49.806+0900 I/APP_CORE(28592): appcore-efl.c: __do_app(429) > [APP 28592] Event: TERMINATE State: RUNNING
05-29 11:49:49.806+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 22
05-29 11:49:49.806+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(890) > app status : 4
05-29 11:49:49.806+0900 W/AUL_AMD (  487): amd_launch.c: __reply_handler(916) > listen fd(20) , send fd(15), pid(28592), cmd(4)
05-29 11:49:49.806+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:49:49.816+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28592
05-29 11:49:49.876+0900 I/APP_CORE(28592): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
05-29 11:49:49.876+0900 I/CAPI_APPFW_APPLICATION(28592): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44293560 is freed
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44c1f280 is freed
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44c22780 is freed
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x442b8790 is freed
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x442c7950 is freed
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x442e58a8 is freed
05-29 11:49:49.886+0900 I/efl-extension(28592): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44375480 is freed
05-29 11:49:49.891+0900 I/MALI    (28592): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x42f60020] swap changed from sync to async
05-29 11:49:49.901+0900 W/AUL_AMD (  487): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-29 11:49:49.901+0900 W/AUL_AMD (  487): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
05-29 11:49:49.916+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:49:49.926+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28592
05-29 11:49:49.931+0900 I/MALI    (28592): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
05-29 11:49:49.931+0900 I/MALI    (28592): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=28592   close drm_fd=25 
05-29 11:49:49.931+0900 I/MALI    (28592): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
05-29 11:49:49.986+0900 W/PROCESSMGR(  382): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
05-29 11:49:49.986+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
05-29 11:49:49.986+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 11:49:49.986+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 11:49:49.986+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 11:49:49.986+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
05-29 11:49:49.986+0900 W/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
05-29 11:49:49.986+0900 I/WATCH_CORE(  745): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
05-29 11:49:49.986+0900 I/CAPI_WATCH_APPLICATION(  745): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
05-29 11:49:49.986+0900 E/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(740) > 
05-29 11:49:49.986+0900 I/watchface-loader(  745): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
05-29 11:49:49.991+0900 I/UXT     (28592): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
05-29 11:49:50.006+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
05-29 11:49:50.006+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
05-29 11:49:50.006+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 11:49:50.006+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
05-29 11:49:50.006+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
05-29 11:49:50.006+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-29 11:49:50.006+0900 W/W_HOME  (  714): main.c: _appcore_resume_cb(681) > appcore resume
05-29 11:49:50.006+0900 W/W_HOME  (  714): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-29 11:49:50.006+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 11:49:50.006+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 11:49:50.006+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-29 11:49:50.006+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 29->29
05-29 11:49:50.011+0900 W/W_HOME  (  714): rotary.c: rotary_attach(138) > rotary_attach:0x45d34090
05-29 11:49:50.011+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45d34090, elm_layout, _activated_obj : 0x45c96248, activated : 1
05-29 11:49:50.011+0900 I/efl-extension(  714): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-29 11:49:50.011+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
05-29 11:49:50.011+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
05-29 11:49:50.011+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1692) > Do the postponed update job.
05-29 11:49:50.011+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1059) > idler for type: 0
05-29 11:49:50.011+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
05-29 11:49:50.011+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 11:49:50.011+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 11:49:50.011+0900 W/GESTURE (  142): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
05-29 11:49:50.026+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:49:50.036+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28592
05-29 11:49:50.041+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-29 11:49:50.041+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
05-29 11:49:50.051+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1106) > unread_count: 2
05-29 11:49:50.051+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(626) > category_id: 42, application_id: 218, application_name: 카카오톡, time_stamp: 1464489827, content_id: 0, spannable_string_version: 1
05-29 11:49:50.051+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-29 11:49:50.051+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-29 11:49:50.051+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-29 11:49:50.051+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-29 11:49:50.051+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-29 11:49:50.051+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-29 11:49:50.051+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  42, 카카오톡.
05-29 11:49:50.051+0900 W/wnotib  (  714): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(260) > Create a panel for panel_id: 1, instance_id: 42
05-29 11:49:50.051+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_initialize(4998) > Initialize the panel with id: 42
05-29 11:49:50.051+0900 W/wnotib  (  714): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(275) > Page instance, instance_id [42] has been created.
05-29 11:49:50.051+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 42, application_id: 218, type: 1
05-29 11:49:50.066+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-29 11:49:50.071+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-29 11:49:50.071+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-29 11:49:50.071+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-29 11:49:50.071+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-29 11:49:50.071+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(412) > Activity fetch finished: -1
05-29 11:49:50.071+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(417) > activity action count: 1
05-29 11:49:50.071+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(422) > 1 activities retrieved.
05-29 11:49:50.071+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(512) > Page fetch finished: -1
05-29 11:49:50.071+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(517) > wearable_page_cnt: 1
05-29 11:49:50.071+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(522) > 1 pages retrieved. start_scroll_bottom: 1
05-29 11:49:50.071+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1343) > New noti is here. Add it on panel  42, 카카오톡.
05-29 11:49:50.071+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 42, application_id: 218, type: 1
05-29 11:49:50.076+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-29 11:49:50.076+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-29 11:49:50.076+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-29 11:49:50.076+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-29 11:49:50.076+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4629) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
05-29 11:49:50.076+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 42, application_id: 218, type: 13
05-29 11:49:50.076+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
05-29 11:49:50.076+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-29 11:49:50.076+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
05-29 11:49:50.076+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
05-29 11:49:50.086+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-29 11:49:50.086+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2271) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
05-29 11:49:50.091+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1378) > This noti will be removed from panel: 41, 카카오톡.
05-29 11:49:50.091+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1378) > This noti will be removed from panel: 41, 카카오톡.
05-29 11:49:50.091+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4312) > New event with category_id: 42, application_id: 218, type: 12
05-29 11:49:50.091+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1387) > Num categories: 1, num total noti: 2
05-29 11:49:50.091+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(871) > Free noti manager data.
05-29 11:49:50.091+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(876) > Free previous notifications.
05-29 11:49:50.091+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(897) > Free previous categories.
05-29 11:49:50.091+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
05-29 11:49:50.091+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
05-29 11:49:50.091+0900 W/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(206) > Summary board was disabled. But receive update request
05-29 11:49:50.091+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
05-29 11:49:50.091+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1412) > num_total_panel: 1.
05-29 11:49:50.091+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x1
05-29 11:49:50.106+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1416) > unread_count_for_home: 2
05-29 11:49:50.106+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_show(478) > 
05-29 11:49:50.131+0900 W/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-29 11:49:50.136+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:49:50.141+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28592
05-29 11:49:50.246+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:49:50.251+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28592
05-29 11:49:50.261+0900 W/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(339) > body is NULL and no attachments found.
05-29 11:49:50.356+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:49:50.366+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28592
05-29 11:49:50.466+0900 W/AUL_AMD (  487): amd_request.c: __request_handler(646) > __request_handler: 14
05-29 11:49:50.476+0900 W/AUL_AMD (  487): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-29 11:49:50.481+0900 I/MALI    (  714): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1588] swap changed from async to sync
05-29 11:49:50.491+0900 E/PKGMGR_SERVER(29286): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-29 11:49:50.516+0900 E/PKGMGR_SERVER(29284): pkgmgr-server.c: sighandler(409) > child NORMAL exit [29286]
05-29 11:49:50.601+0900 W/CRASH_MANAGER(29289): worker.c: worker_job(1199) > 1128592706831146449019
