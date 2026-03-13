操作步骤:
1，下载UE 对应版本的源码
2，执行一次 "%UnrealEngine_RootDir%/Setup.bat"
3,  执行一次 "%UnrealEngine_RootDir%/GenerateProjectFiles.bat"
4,  复制补丁目录下所有文件到 %UnrealEngine_RootDir%
5,  执行 "%UnrealEngine_RootDir%/make_installed_build.bat"

文件说明：
make_installed_build.bat 编译UE源码
make_installed_build_continue.bat 增量编译UE源码 （编译发生错误修正后继续编译使用）
run_clear.sh 清除编译的中间目录

third-parts-source-bakup 需要自己编译成/MDD Debug版本的第三方库目录（补丁中已有预编译的文件，用于发生错误时补救）

