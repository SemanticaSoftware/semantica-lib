@ECHO off
IF EXIST ".\TestResults" RMDIR /s /q ".\TestResults"
FOR /f "tokens=*" %%G IN ('DIR /b /a:d .\pack\*') DO (
	IF EXIST ".\pack\%%G\bin" RMDIR /s /q ".\pack\%%G\bin"
)
FOR /f "tokens=*" %%G IN ('DIR /b /a:d .\src\*') DO (
	IF EXIST ".\src\%%G\bin" RMDIR /s /q ".\src\%%G\bin"
)
FOR /f "tokens=*" %%G IN ('DIR /b /a:d .\tst\*') DO (
	IF EXIST ".\tst\%%G\bin" RMDIR /s /q ".\tst\%%G\bin"
)
