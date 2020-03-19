@echo off  

echo creat apk ing

REM  "D:\Program Files\Unity2018.3.5\Editor\Unity.exe" -projectPath "D:\UnityCreate\test" -quit -batchmode -executeMethod UwaProjScan.MainScan.DoTest -logFile build.log

%1 -projectPath %2 -quit -batchmode -executeMethod UwaProjScan.MainScan.DoTest -logFile build.log

echo apk creat success
pause 


