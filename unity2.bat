@echo off  

echo 正在生成APK文件...  


${D:\Program Files\Unity2018.3.5\Editor\Unity.exe} -batchmode -projectPath ${D:\UnityCreate\test} -executeMethod UwaProjScan.MainScan.DoTest -logFile
${LogFile} -quit
echo APK文件生成完毕!  
pause 


