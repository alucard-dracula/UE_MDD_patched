# UE_MDD_patched

- **简体中文**
- [English](/.github/README-en_us.md)
- [日本語](/.github/README-ja.md)  


---

针对 Unread Engine 在 Win64 上的 编译出 /MDD Debug 版本的 补丁


基本的使用方式：

1， 下载UE 对应版本的源码
2， 执行一次 "%UnrealEngine_RootDir%/Setup.bat"
3,  执行一次 "%UnrealEngine_RootDir%/GenerateProjectFiles.bat"
4,  复制补丁目录下所有文件到 %UnrealEngine_RootDir%
5,  执行 "%UnrealEngine_RootDir%/make_installed_build.bat"
6， 更详细的说明间具体补丁目录下的readme.txt

注意事项:
1，Unread Engine 的根目录需要尽量放在WINDOWS某个盘符的根目录下，可避免WINDOWS下目录路径过长问题
2，单盘符下 准备600GB以上的空闲硬盘空间（推荐800G以上）

PS:
该项目 从UE 5.7.3版本开始，由于个人能力有限不保证所有版本都有补丁

