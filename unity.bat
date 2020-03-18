@echo off  

echo 正在生成APK文件...  

REM D:\Program Files\Unity2018.3.5\Editor\Unity.exe -projectPath D:\UnityCreate\320 -quit -batchmode -executeMethod APKBuild.Build -logFile build.log

%1 -projectPath %2 -quit -batchmode -executeMethod APKBuild.Build -logFile build.log

echo APK文件生成完毕!  
pause 


