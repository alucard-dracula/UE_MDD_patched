Steps:
1. Download the source code for the corresponding UE version
2. Run "%UnrealEngine_RootDir%/Setup.bat" once
3. Run "%UnrealEngine_RootDir%/GenerateProjectFiles.bat" once
4. Copy all files from the patch directory to %UnrealEngine_RootDir%
5. Run "%UnrealEngine_RootDir%/make_installed_build.bat"

File Description:
make_installed_build.bat - Compiles the UE source code
make_installed_build_continue.bat - Incrementally compiles the UE source code (used to continue compilation after fixing errors)
run_clear.sh - Clears intermediate compilation directories

third-parts-source-bakup - You need to compile your own /MDD Debug version of third-party library directory (the patch already contains precompiled files for error recovery)