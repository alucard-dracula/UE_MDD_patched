# UE_MDD_patched

- [简体中文](/./README.md)
- **English**
- [日本語](/.github/README-ja.md)

---

Patch for compiling the /MDD Debug version of Unreal Engine on Win64

Basic Usage:

1. Download the source code for the corresponding UE version
2. Run "%UnrealEngine_RootDir%/Setup.bat" once
3. Run "%UnrealEngine_RootDir%/GenerateProjectFiles.bat" once
4. Copy all files from the patch directory to %UnrealEngine_RootDir%
5. Run "%UnrealEngine_RootDir%/make_installed_build.bat"
6. For more detailed instructions, refer to the "readme.txt" in the patch directory

Notes:
1. The Unreal Engine root directory should ideally be placed at the root of a Windows drive to avoid excessively long path issues
2. Ensure at least 600GB of free disk space on a single drive (800GB or more recommended)

PS:
This project starts from UE version 5.7.3, and due to personal limitations, patches for all versions cannot be guaranteed