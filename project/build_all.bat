@echo off
set PATH="%PATH%;C:\Program Files\Unity\Hub\Editor\2019.3.6f1\Editor\"

"C:\Program Files\Unity\Hub\Editor\2019.3.6f1\Editor\Unity.exe" -batchmode -quit -projectPath "%cd%" -executeMethod Builder.Build
