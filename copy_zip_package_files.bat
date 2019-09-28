rem delete existing
rmdir "ZipPackage" /Q /S

rem Create required folders
mkdir "ZipPackage"
mkdir "ZipPackage\x64"
mkdir "ZipPackage\x86"

set "CONFIGURATION=bin\Release\net45"

rem Copy output files
copy "src\OpenSora.Viewer\%CONFIGURATION%\OpenSora.Viewer.exe" ZipPackage /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\Myra.dll" "ZipPackage" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\Nursia.dll" "ZipPackage" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\OpenSora.dll" "ZipPackage" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\MonoGame.Framework.dll" "ZipPackage" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\MonoGame.Framework.dll.config" "ZipPackage" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\x64\libSDL2-2.0.so.0" "ZipPackage\x64" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\x64\libopenal.so.1" "ZipPackage\x64" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\x64\SDL2.dll" "ZipPackage\x64" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\x64\soft_oal.dll" "ZipPackage\x64" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\x86\libSDL2-2.0.so.0" "ZipPackage\x86" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\x86\libopenal.so.1" "ZipPackage\x86" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\x86\SDL2.dll" "ZipPackage\x86" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\x86\soft_oal.dll" "ZipPackage\x86" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\libSDL2-2.0.0.dylib" "ZipPackage" /Y
copy "src\OpenSora.Viewer\%CONFIGURATION%\libopenal.1.dylib" "ZipPackage" /Y

xcopy "samples\models\*.*" "ZipPackage\samples\*.*" /s
