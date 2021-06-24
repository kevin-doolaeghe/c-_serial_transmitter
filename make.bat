@echo off

:: Création du répertoire de compilation
if not exist .\build mkdir .\build

:: Préparation du compilateur
:: setx Path "%PATH%;C:\Windows\Microsoft.NET\Framework\v4.0.30319"
set cs=csc.exe

:: Compilation
%cs% /out:.\build\program.exe .\src\*.cs
