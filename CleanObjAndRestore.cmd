@ECHO off
FOR /f "tokens=*" %%G IN ('DIR /b /a:d .\pack\*') DO (
	IF EXIST ".\pack\%%G\obj" RMDIR /s /q ".\pack\%%G\obj"
)
FOR /f "tokens=*" %%G IN ('DIR /b /a:d .\src\*') DO (
	IF EXIST ".\src\%%G\obj" RMDIR /s /q ".\src\%%G\obj"
)
FOR /f "tokens=*" %%G IN ('DIR /b /a:d .\tst\*') DO (
	IF EXIST ".\tst\%%G\obj" RMDIR /s /q ".\tst\%%G\obj"
)
CALL .\Clean.cmd
CALL dotnet restore ".\Semantica.Lib.sln"
