@echo off

set src_dir=%1
set find_dir=%2

for /r "%src_dir%" %%d in (.) do (
    if "%%~nxd"=="%find_dir%" (
        echo "%%d"
        rd /s /q "%%d"
    )
)
