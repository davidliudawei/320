@echo off  

echo creat apk ing

REM  "D:\Program Files\Unity2018.3.5\Editor\Unity.exe" -projectPath "D:\UnityCreate\test" -quit -batchmode -executeMethod APKBuild.Build -logFile build.log

%1 -projectPath %2 -quit -batchmode -executeMethod APKBuild.Build -logFile build.log

echo apk creat success
pause 


