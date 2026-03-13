@echo off

cd /d %~dp0

set ue_root=%~dp0
set ue_run_uat=%ue_root%Engine\Build\BatchFiles\RunUAT.bat

%ue_run_uat% BuildGraph ^
    -Script=%ue_root%Engine\Build\InstalledEngineBuild.xml ^
    -Target="Make Installed Build Win64" ^
    -set:GameConfigurations=Debug ^
    -set:WithWin64=true ^
    -set:WithWinArm64=false ^
    -set:WithWinArm64ec=false ^
    -set:WithMac=false ^
    -set:WithAndroid=false ^
    -set:WithIOS=false ^
    -set:WithTVOS=false ^
    -set:WithLinux=false ^
    -set:WithLinuxArm64=false ^
    -set:WithFullDebugInfo=true 

