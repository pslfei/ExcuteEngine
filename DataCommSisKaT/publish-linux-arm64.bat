@echo off
echo Building and publishing for Linux ARM64...

echo Cleaning previous build...
dotnet clean

echo Building solution...
dotnet build -c Release

echo Publishing for Linux ARM64...
dotnet publish -c Release -r linux-arm64 --self-contained true -o publish\linux-arm64

echo Copying configuration files...
copy "cfg.ini" "publish\linux-arm64\" 2>nul
copy "mirrors.dll" "publish\linux-arm64\" 2>nul
copy "pointMSG.csv" "publish\linux-arm64\" 2>nul

echo.
echo Linux ARM64 build completed successfully!
echo Output location: publish\linux-arm64\
echo.
pause