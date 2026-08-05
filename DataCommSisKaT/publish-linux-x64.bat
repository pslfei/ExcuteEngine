@echo off
echo Building and publishing for Linux x64...

echo Cleaning previous build...
dotnet clean

echo Building solution...
dotnet build -c Release

echo Publishing for Linux x64...
dotnet publish -c Release -r linux-x64 --self-contained true -o publish\linux-x64

echo Copying configuration files...
copy "cfg.ini" "publish\linux-x64\" 2>nul
copy "mirrors.dll" "publish\linux-x64\" 2>nul
copy "pointMSG.csv" "publish\linux-x64\" 2>nul

echo.
echo Linux x64 build completed successfully!
echo Output location: publish\linux-x64\
echo.
pause