S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.5
Build-Number: R720XXU2CPC5
Build-Date: 2016.03.21 17:07:12

Crash Information
Process Name: ph1
PID: 12654
Date: 2016-04-02 14:34:35+0900
Executable File Path: /opt/usr/apps/org.example.ph1/bin/ph1
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 12654, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x419da198, r5   = 0x419d0b20
r6   = 0x419b2ed0, r7   = 0xbea97320
r8   = 0x00000000, r9   = 0x44127448
r10  = 0x44141178, fp   = 0x00000001
ip   = 0x419d0b20, sp   = 0xbea972c8
lr   = 0x00000000, pc   = 0x4145fe20
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     23288 KB
Buffers:     43000 KB
Cached:     147356 KB
VmPeak:      87472 KB
VmSize:      85436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21524 KB
VmRSS:       21520 KB
VmData:      25412 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       24952 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12654 TID = 12654
12654 12900 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40055000 40061000 r-xp /usr/lib/libaul.so.0.1.0
4006b000 4006d000 r-xp /lib/libdl-2.13.so
40076000 40079000 r-xp /usr/lib/libbundle.so.0.1.22
40081000 40083000 r-xp /usr/lib/libdlog.so.0.0.0
4008b000 4009f000 r-xp /lib/libpthread-2.13.so
400aa000 401e4000 r-xp /usr/lib/libelementary.so.1.7.99
401fa000 402c8000 r-xp /usr/lib/libevas.so.1.7.99
402ed000 40304000 r-xp /usr/lib/libecore.so.1.7.99
4031b000 40378000 r-xp /usr/lib/libedje.so.1.7.99
40382000 40452000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40453000 40459000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40461000 40464000 r-xp /usr/lib/libsmack.so.1.0.0
4046c000 40474000 r-xp /lib/libgcc_s-4.6.so.1
40475000 40590000 r-xp /lib/libc-2.13.so
4059e000 405da000 r-xp /usr/lib/libsystemd.so.0.4.0
405e3000 405ee000 r-xp /lib/libunwind.so.8.0.1
4061b000 40632000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4063a000 40664000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066d000 40672000 r-xp /usr/lib/libxdgmime.so.1.1.0
4067a000 4069c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a4000 406a7000 r-xp /usr/lib/libproc-stat.so.0.2.86
406af000 406b5000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406be000 40727000 r-xp /lib/libm-2.13.so
40730000 40749000 r-xp /usr/lib/libeet.so.1.7.99
4075a000 4079b000 r-xp /usr/lib/libeina.so.1.7.99
407a4000 407c6000 r-xp /usr/lib/libecore_evas.so.1.7.99
407cf000 407d4000 r-xp /usr/lib/libecore_file.so.1.7.99
407dc000 407ed000 r-xp /usr/lib/libecore_input.so.1.7.99
407f5000 407f9000 r-xp /usr/lib/libvconf.so.0.2.45
40801000 40851000 r-xp /usr/lib/libecore_x.so.1.7.99
40853000 4085c000 r-xp /usr/lib/libedbus.so.1.7.99
40864000 4087e000 r-xp /usr/lib/libecore_con.so.1.7.99
40887000 4089a000 r-xp /usr/lib/libfribidi.so.0.3.1
408a2000 408df000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a58000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a60000 40a63000 r-xp /lib/libcap.so.2.21
40a6b000 40a83000 r-xp /usr/lib/liblzma.so.5.0.3
40a8b000 40b07000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b13000 40b23000 r-xp /lib/libresolv-2.13.so
40b27000 40bfa000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40c05000 40c39000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c42000 40c58000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c60000 40cd5000 r-xp /usr/lib/libsqlite3.so.0.8.6
40cdf000 40cf5000 r-xp /lib/libz.so.1.2.5
40cfd000 40d20000 r-xp /usr/lib/libjpeg.so.8.0.2
40d38000 40e19000 r-xp /usr/lib/libX11.so.6.3.0
40e24000 40e29000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e32000 40e36000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e3f000 40e42000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e4a000 40e51000 r-xp /usr/lib/libXcursor.so.1.0.2
40e59000 40e5b000 r-xp /usr/lib/libXdamage.so.1.1.0
40e63000 40e65000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e6d000 40e6f000 r-xp /usr/lib/libXgesture.so.7.0.0
40e77000 40e7a000 r-xp /usr/lib/libXfixes.so.3.1.0
40e82000 40e8b000 r-xp /usr/lib/libXi.so.6.1.0
40e93000 40e94000 r-xp /usr/lib/libXinerama.so.1.0.0
40e9d000 40ea3000 r-xp /usr/lib/libXrandr.so.2.2.0
40eab000 40eb1000 r-xp /usr/lib/libXrender.so.1.3.0
40eb9000 40ebd000 r-xp /usr/lib/libXtst.so.6.1.0
40ec5000 40ecf000 r-xp /usr/lib/libXext.so.6.4.0
40ed8000 40f1c000 r-xp /usr/lib/libcurl.so.4.3.0
40f25000 40f3b000 r-xp /lib/libexpat.so.1.5.2
40f45000 40f5d000 r-xp /usr/lib/libpng12.so.0.50.0
40f65000 40f82000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f8b000 4101f000 r-xp /usr/lib/libstdc++.so.6.0.16
41033000 41036000 r-xp /lib/libattr.so.1.1.0
4103e000 41049000 r-xp /usr/lib/libgpg-error.so.0.15.0
41051000 41052000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4105a000 4105f000 r-xp /usr/lib/libffi.so.5.0.10
41067000 41069000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41072000 4113e000 r-xp /usr/lib/libxml2.so.2.7.8
4114b000 4114d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41156000 41158000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41160000 41173000 r-xp /usr/lib/libxcb.so.1.1.0
4117d000 41186000 r-xp /usr/lib/libcares.so.2.1.0
4118f000 411bd000 r-xp /usr/lib/libidn.so.11.5.44
411c5000 41212000 r-xp /usr/lib/libssl.so.1.0.0
4121e000 413c6000 r-xp /usr/lib/libcrypto.so.1.0.0
413df000 413e1000 r-xp /usr/lib/libiri.so
413ea000 413f1000 r-xp /lib/libcrypt-2.13.so
41421000 41423000 r-xp /usr/lib/libXau.so.6.0.0
41430000 41434000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4143c000 41444000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41445000 4144a000 r-xp /usr/lib/libappcore-common.so.1.1
41452000 41454000 r-xp /usr/lib/libiniparser.so.0
4145d000 41461000 r-xp /opt/usr/apps/org.example.ph1/bin/ph1
41469000 41471000 r-xp /usr/lib/libmdm-common.so.1.0.89
41472000 41476000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4147f000 41481000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4148a000 41490000 r-xp /usr/lib/libappsvc.so.0.1.0
41498000 414bc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414c5000 41594000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415aa000 415b4000 r-xp /lib/libnss_files-2.13.so
415bd000 415c8000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
415d2000 415df000 r-xp /usr/lib/libcapi-network-connection.so.1.0.51
415e7000 41608000 r-xp /usr/lib/libefl-extension.so.0.1.0
41610000 41627000 r-xp /usr/lib/libnetwork.so.0.0.0
4162f000 41634000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4163c000 4164e000 r-xp /usr/lib/libefl-assist.so.0.1.0
41656000 41687000 r-xp /usr/lib/libmdm.so.1.1.85
4168f000 41696000 r-xp /usr/lib/libtbm.so.1.0.0
4169e000 4174d000 rw-p [heap]
419ec000 41aa4000 r-xp /usr/lib/libcairo.so.2.11200.14
41aaf000 41ac1000 r-xp /usr/lib/libtts.so
41ac9000 41aea000 r-xp /usr/lib/libui-extension.so.0.1.0
41af3000 41b01000 r-xp /usr/lib/libGLESv2.so.2.0
41b0a000 41b0b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41b14000 41b1a000 r-xp /usr/lib/libxcb-render.so.0.0.0
41b22000 41b25000 r-xp /usr/lib/libEGL.so.1.4
41b2d000 41c6a000 r-xp /usr/lib/libicui18n.so.51.1
41c7a000 41d5e000 r-xp /usr/lib/libicuuc.so.51.1
41d73000 41d76000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41d7e000 41d86000 r-xp /usr/lib/libdrm.so.2.4.0
43315000 4331a000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43323000 43328000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43330000 43332000 r-xp /usr/lib/libdri2.so.0.0.0
4333a000 4335b000 r-xp /usr/lib/libexif.so.12.3.3
4336e000 43373000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4337b000 43445000 r-xp /usr/lib/libCOREGL.so.4.0
43788000 43793000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4379c000 437a0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
437a8000 437bf000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
437cc000 437ce000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
437d7000 43fd6000 rwxp [stack:12900]
44b0b000 44b10000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
44c37000 44c47000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
44d4f000 44d50000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44dd7000 44dd8000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44df5000 44df6000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45000000 45007000 r-xp /usr/lib/libfeedback.so.0.1.4
45010000 45012000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
4501a000 45024000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.49
4502c000 45033000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4503b000 45051000 r-xp /usr/lib/libmmfsound.so.0.1.0
45063000 45068000 r-xp /usr/lib/libmmfsession.so.0.0.0
45070000 4507a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45086000 4508a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45093000 450a9000 r-xp /usr/lib/libavsysaudio.so.0.0.1
450b2000 450b7000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
450bf000 450c2000 r-xp /usr/lib/libpulse-simple.so.0.0.4
450ca000 4512b000 r-xp /usr/lib/libasound.so.2.0.0
45135000 4516d000 r-xp /usr/lib/libpulse.so.0.16.2
4516e000 45171000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45179000 45186000 r-xp /usr/lib/libail.so.0.1.0
4518f000 4519f000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
451c0000 451c8000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
451d7000 451da000 r-xp /usr/lib/libcompress.so.0.2.0
451e2000 451e7000 r-xp /usr/lib/libjson.so.0.0.1
451ef000 45237000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45238000 4527b000 r-xp /usr/lib/libsndfile.so.1.0.25
45288000 452aa000 r-xp /usr/lib/libvorbis.so.0.4.3
452b2000 452b6000 r-xp /usr/lib/libogg.so.0.7.1
bea77000 bea98000 rwxp [stack]
End of Maps Information

Callstack Information (PID:12654)
Call Stack Count: 1
 0: create_third_page + 0x1b (0x4145fe20) [/opt/usr/apps/org.example.ph1/bin/ph1] + 0x2e20
End of Call Stack

Package Information
Package Name: org.example.ph1
Package ID : org.example.ph1
Version: 1.0.0
Package Type: rpm
App Name: ph1
App ID: org.example.ph1
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 ungrab key(XF86Stop)
04-02 14:33:56.968+0900 W/AUL_AMD (  473): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
04-02 14:33:57.043+0900 I/AUL_AMD (  473): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 12556
04-02 14:33:57.078+0900 W/PROCESSMGR(  380): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
04-02 14:33:57.078+0900 W/W_HOME  (  731): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
04-02 14:33:57.078+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-02 14:33:57.078+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-02 14:33:57.078+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-02 14:33:57.078+0900 W/W_HOME  (  731): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
04-02 14:33:57.078+0900 W/WATCH_CORE(  758): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
04-02 14:33:57.078+0900 I/WATCH_CORE(  758): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
04-02 14:33:57.078+0900 I/CAPI_WATCH_APPLICATION(  758): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
04-02 14:33:57.078+0900 E/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(740) > 
04-02 14:33:57.078+0900 I/watchface-loader(  758): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
04-02 14:33:57.103+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
04-02 14:33:57.103+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
04-02 14:33:57.103+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-02 14:33:57.103+0900 W/W_HOME  (  731): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(0)
04-02 14:33:57.103+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: RESUME State: PAUSED
04-02 14:33:57.103+0900 I/CAPI_APPFW_APPLICATION(  731): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-02 14:33:57.103+0900 W/W_HOME  (  731): main.c: _appcore_resume_cb(681) > appcore resume
04-02 14:33:57.103+0900 W/W_HOME  (  731): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
04-02 14:33:57.103+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-02 14:33:57.103+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-02 14:33:57.103+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-02 14:33:57.103+0900 W/APPS    (  731): apps_main.c: _time_changed_cb(295) >  date : 2->2
04-02 14:33:57.103+0900 W/W_HOME  (  731): rotary.c: rotary_attach(138) > rotary_attach:0x47890470
04-02 14:33:57.103+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47890470, elm_layout, _activated_obj : 0x45c95d10, activated : 1
04-02 14:33:57.103+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-02 14:33:57.103+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
04-02 14:33:57.103+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:33:57.103+0900 W/wnotib  (  731): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1703) > No postponed update.
04-02 14:33:57.103+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:33:57.103+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:33:57.103+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:33:57.103+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:33:57.618+0900 I/MALI    (  731): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442e1460] swap changed from async to sync
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:33:58.108+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:33:58.108+0900 E/CAPI_APPFW_APP_CONTROL( 1107): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-02 14:33:58.108+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1107]   [com.samsung.w-home]register msg port [true][0m
04-02 14:33:58.113+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 14
04-02 14:33:58.118+0900 W/AUL_AMD (  473): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 731
04-02 14:33:58.123+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1107]   [MUSIC_PLAYER_EVENT][0m
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:33:58.128+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:33:58.133+0900 W/W_HOME  (  731): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
04-02 14:33:58.133+0900 E/W_HOME  (  731): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-02 14:33:58.133+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1107]   [MUSIC_PLAYER_EVENT][0m
04-02 14:33:58.133+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:33:58.133+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:33:58.133+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:33:58.133+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:33:58.133+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:33:58.133+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:33:58.133+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-02 14:33:58.133+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:33:58.138+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:33:58.138+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:33:58.138+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:33:58.138+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:33:58.138+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:33:58.138+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:33:58.138+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-02 14:33:58.138+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:33:58.138+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:33:58.138+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:33:58.138+0900 W/W_HOME  (  731): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
04-02 14:33:58.138+0900 E/W_HOME  (  731): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-02 14:34:00.003+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-02 14:34:00.003+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-02 14:34:00.003+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : pedometer_inactive_period error
04-02 14:34:00.003+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-02 14:34:00.003+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-02 14:34:00.003+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : inactive_10min_precaution_millisec error
04-02 14:34:00.003+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
04-02 14:34:00.003+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
04-02 14:34:00.003+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1027): preference.c: preference_get_double(1214) > preference_get_double(1027) : inactive_before_10min_precaution_millisec error
04-02 14:34:00.863+0900 W/APPS    (  731): apps_main.c: _time_changed_cb(295) >  date : 2->2
04-02 14:34:07.323+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
04-02 14:34:07.328+0900 E/EFL     (  731): evas_main<731> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7636461 button=1 downs=1
04-02 14:34:07.328+0900 W/APPS    (  731): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [186, 181]
04-02 14:34:07.373+0900 E/EFL     (  731): evas_main<731> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7636487 button=1 downs=0
04-02 14:34:07.373+0900 W/APPS    (  731): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [186, 181]->[186, 181]
04-02 14:34:07.378+0900 W/APPS    (  731): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,18]
04-02 14:34:07.383+0900 E/APPS    (  731): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
04-02 14:34:07.383+0900 W/APPS    (  731): AppsItem.cpp: onItemClicked(410) >  item(ph1) launched, open(0)
04-02 14:34:07.388+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 0
04-02 14:34:07.388+0900 W/AUL_AMD (  473): amd_launch.c: _start_app(1702) > caller pid : 731
04-02 14:34:07.388+0900 I/AUL_AMD (  473): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
04-02 14:34:07.403+0900 E/RESOURCED(  475): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.ph1, table num : 1
04-02 14:34:07.403+0900 E/RESOURCED(  475): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
04-02 14:34:07.408+0900 W/AUL_AMD (  473): amd_launch.c: _start_app(2080) > pad pid(-5)
04-02 14:34:07.408+0900 W/AUL_PAD ( 1174): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
04-02 14:34:07.408+0900 W/AUL_PAD ( 1174): launchpad.c: __send_result_to_caller(272) > Check app launching
04-02 14:34:07.443+0900 I/efl-extension(12654): efl_extension.c: eext_mod_init(40) > Init
04-02 14:34:07.443+0900 I/UXT     (12654): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
04-02 14:34:07.443+0900 I/CAPI_APPFW_APPLICATION(12654): app_main.c: ui_app_main(704) > app_efl_main
04-02 14:34:07.448+0900 I/CAPI_APPFW_APPLICATION(12654): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-02 14:34:07.488+0900 E/TBM     (12654): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
04-02 14:34:07.513+0900 E/AUL     (  473): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
04-02 14:34:07.513+0900 E/RESOURCED(  475): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.ph1
04-02 14:34:07.548+0900 E/EFL     (12654): <12654> elm_layout.c:2201 elm_layout_add() safety check failed: parent == NULL
04-02 14:34:07.553+0900 E/EFL     (12654): <12654> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:34:07.558+0900 E/EFL     (12654): <12654> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:34:07.558+0900 E/EFL     (12654): <12654> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:34:07.558+0900 E/EFL     (12654): <12654> elm_main.c:1209 elm_object_part_content_set() safety check failed: obj == NULL
04-02 14:34:07.608+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03400002)
04-02 14:34:07.608+0900 I/APP_CORE(12654): appcore-efl.c: __do_app(429) > [APP 12654] Event: RESET State: CREATED
04-02 14:34:07.608+0900 I/CAPI_APPFW_APPLICATION(12654): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-02 14:34:07.623+0900 I/APP_CORE(12654): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
04-02 14:34:07.623+0900 I/APP_CORE(12654): appcore-efl.c: __do_app(474) > [APP 12654] Initial Launching, call the resume_cb
04-02 14:34:07.623+0900 I/CAPI_APPFW_APPLICATION(12654): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-02 14:34:07.638+0900 W/W_HOME  (  731): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
04-02 14:34:07.638+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:34:07.638+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:34:07.638+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:34:07.638+0900 W/W_HOME  (  731): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
04-02 14:34:07.643+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
04-02 14:34:07.643+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:34:07.668+0900 I/MALI    (  731): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442e1460] swap changed from sync to async
04-02 14:34:07.678+0900 W/APP_CORE(12654): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400002
04-02 14:34:07.738+0900 I/APP_CORE(12654): appcore-efl.c: __do_app(429) > [APP 12654] Event: RESUME State: RUNNING
04-02 14:34:07.758+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
04-02 14:34:07.758+0900 W/W_HOME  (  731): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
04-02 14:34:07.758+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:34:07.758+0900 W/W_HOME  (  731): main.c: _window_visibility_cb(1189) > Window [0x2600003] is now visible(1)
04-02 14:34:07.763+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: PAUSE State: RUNNING
04-02 14:34:07.763+0900 I/CAPI_APPFW_APPLICATION(  731): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-02 14:34:07.763+0900 W/W_HOME  (  731): main.c: _appcore_pause_cb(690) > appcore pause
04-02 14:34:07.763+0900 W/W_HOME  (  731): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
04-02 14:34:07.763+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:34:07.763+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:34:07.763+0900 W/W_HOME  (  731): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-02 14:34:07.763+0900 W/W_HOME  (  731): rotary.c: rotary_deattach(156) > rotary_deattach:0x47890470
04-02 14:34:07.763+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-02 14:34:07.763+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47890470, elm_layout, func : 0x4004b469
04-02 14:34:07.763+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-02 14:34:07.763+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-02 14:34:07.763+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-02 14:34:07.763+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c95d10, elm_box, _activated_obj : 0x47890470, activated : 1
04-02 14:34:07.763+0900 I/efl-extension(  731): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-02 14:34:07.763+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:34:07.763+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-02 14:34:07.773+0900 I/MESSAGE_PORT(  449): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-02 14:34:07.773+0900 E/CAPI_APPFW_APP_CONTROL( 1107): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-02 14:34:07.773+0900 W/MUSIC_CONTROL_SERVICE( 1107): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1107]   [com.samsung.w-home]register msg port [false][0m
04-02 14:34:07.778+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:34:07.778+0900 W/GESTURE (  143): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
04-02 14:34:07.833+0900 I/wnotib  (  731): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
04-02 14:34:07.833+0900 E/wnotib  (  731): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
04-02 14:34:07.848+0900 W/APPS    (  731): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
04-02 14:34:08.128+0900 E/AUL     (  473): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
04-02 14:34:08.278+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
04-02 14:34:08.638+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 14
04-02 14:34:08.658+0900 W/AUL_AMD (  473): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 12654
04-02 14:34:08.663+0900 W/AUL_AMD (  473): amd_request.c: __request_handler(646) > __request_handler: 12
04-02 14:34:09.028+0900 I/AUL_PAD (12833): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
04-02 14:34:11.953+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
04-02 14:34:11.958+0900 I/RESOURCED(  475): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
04-02 14:34:12.778+0900 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
04-02 14:34:14.073+0900 E/EFL     (12654): evas_main<12654> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7643210 button=1 downs=1
04-02 14:34:14.153+0900 E/EFL     (12654): evas_main<12654> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7643290 button=1 downs=0
04-02 14:34:14.933+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:34:14.933+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:34:14.938+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:34:14.943+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:34:14.943+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:34:14.943+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:34:14.988+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:true] pos=0[0m
04-02 14:34:15.018+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:34:15.018+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:34:15.058+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:34:15.058+0900 E/E17     (  380): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x03e00003)
04-02 14:34:15.078+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:34:15.163+0900 E/AUL_AMD (  473): amd_appinfo.c: appinfo_get_value(999) > appinfo get value: Invalid argument, 9
04-02 14:34:15.523+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:34:15.538+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:34:16.893+0900 E/SHealth_Common( 1027): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
04-02 14:34:16.923+0900 E/EFL     (12654): evas_main<12654> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7646057 button=1 downs=1
04-02 14:34:17.048+0900 E/EFL     (12654): evas_main<12654> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7646187 button=1 downs=0
04-02 14:34:17.998+0900 E/EFL     (12654): evas_main<12654> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7647130 button=1 downs=1
04-02 14:34:18.108+0900 E/EFL     (12654): evas_main<12654> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7647243 button=1 downs=0
04-02 14:34:18.118+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:34:18.143+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:34:18.148+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:34:18.163+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:34:18.163+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:34:18.163+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:34:18.163+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:34:18.168+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:34:18.228+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:34:18.228+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:34:18.338+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:34:18.338+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:34:18.383+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:34:18.383+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:34:18.413+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:34:18.648+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:34:19.573+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:19.768+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:19.773+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:34:19.823+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:34:20.543+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:20.558+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:34:21.213+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [65288][0m
04-02 14:34:21.223+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:34:21.483+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:21.498+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:34:21.868+0900 E/EFL     (12654): evas_main<12654> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7651001 button=1 downs=1
04-02 14:34:21.968+0900 E/EFL     (12654): evas_main<12654> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7651104 button=1 downs=0
04-02 14:34:21.968+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:34:22.003+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:34:22.008+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:34:22.023+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:34:22.023+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:34:22.023+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:34:22.023+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:34:22.023+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:34:22.063+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:34:22.063+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:34:22.093+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:34:22.093+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:34:22.128+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:34:22.128+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:34:22.148+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:34:22.513+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:34:23.798+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:23.828+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:34:24.128+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:24.143+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:34:24.513+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:24.533+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:34:24.923+0900 E/EFL     (12654): evas_main<12654> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7654059 button=1 downs=1
04-02 14:34:25.023+0900 E/EFL     (12654): evas_main<12654> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7654157 button=1 downs=0
04-02 14:34:25.023+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:34:25.048+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:34:25.058+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:34:25.068+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:34:25.068+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:34:25.068+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:34:25.068+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:34:25.073+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:34:25.138+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:34:25.138+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:34:25.173+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:34:25.173+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:34:25.218+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:34:25.218+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:34:25.238+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:34:25.558+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:34:26.698+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:26.713+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:34:26.913+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:26.933+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:34:27.363+0900 E/EFL     (12654): evas_main<12654> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7656500 button=1 downs=1
04-02 14:34:27.448+0900 E/EFL     (12654): evas_main<12654> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7656588 button=1 downs=0
04-02 14:34:27.453+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:34:27.483+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:34:27.483+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:34:27.498+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-02 14:34:27.498+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-02 14:34:27.498+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
04-02 14:34:27.498+0900 E/TIZEN_N_SYSTEM_SETTINGS(  995): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
04-02 14:34:27.498+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:34:27.543+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=0[0m
04-02 14:34:27.543+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:34:27.573+0900 I/ISE_MULTI(  995): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff [0m
04-02 14:34:27.578+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_init(111) > [0;31mrotary_input_init[0m
04-02 14:34:27.613+0900 I/CANDIDATE(  995): soft_candidate.cpp: ui_candidate_hide(925) > [0;36mcandidate_hide[0m
04-02 14:34:27.618+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3e00003 FAILED!
04-02 14:34:27.638+0900 I/ISE_MULTI(  995): privatekeys.cpp: ise_update_globe_private_key(1801) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
04-02 14:34:27.988+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:34:29.048+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:29.078+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=1[0m
04-02 14:34:29.548+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:29.568+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=2[0m
04-02 14:34:30.053+0900 W/ISE_MULTI(  995): ise.cpp: on_event_key_clicked(974) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
04-02 14:34:30.073+0900 I/ISE_MULTI(  995): isemain.cpp: slot_update_cursor_position(1099) > [0;36m[hidden state:false] pos=3[0m
04-02 14:34:32.348+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:false][0m
04-02 14:34:32.408+0900 W/ISF_PANEL_EFL(  915): isf_panel_efl.cpp: efl_get_window_rotate_angle(3431) > WINDOW angle of 0x3400002 FAILED!
04-02 14:34:32.608+0900 E/ISE_MULTI(  995): ise-rotary-event-listener.cpp: rotary_input_clear(121) > [0;31mrotary_input_clear[0m
04-02 14:34:32.623+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
04-02 14:34:32.623+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
04-02 14:34:32.623+0900 I/efl-extension(  995): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
04-02 14:34:32.623+0900 E/ISE_MULTI(  995): rotary_input.cpp: destroy_rotary_input_layout(622) > [0;31mdestroy_rotary_input_layout[0m
04-02 14:34:32.623+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:34:33.163+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:34:35.023+0900 E/EFL     (12654): evas_main<12654> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=7664156 button=1 downs=1
04-02 14:34:35.083+0900 E/EFL     (12654): evas_main<12654> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=7664216 button=1 downs=0
04-02 14:34:35.088+0900 I/ISE_MULTI(  995): isemain.cpp: slot_reset_ise_input_context(1291) > [0;36m[hidden state:true][0m
04-02 14:34:35.118+0900 I/SWIFTKEY(  874): swiftkey_engine.cpp: IME_Learn_sentence(2528) > [0;36mDLM write[0m
04-02 14:34:35.123+0900 E/ISE_MULTI(  995): ise-ui.cpp: destroy_indicator(1035) > [0;31mdestroy_indicator[0m
04-02 14:34:35.623+0900 I/RESOURCED(  475): swap.c: swap_send_signal(549) > [swap_send_signal,549] send signal to swap thread
04-02 14:34:35.798+0900 W/CRASH_MANAGER(13017): worker.c: worker_job(1199) > 1112654706831145957527
