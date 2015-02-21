@echo off
SET ROOT=%~dp0..
rmdir /Q /S %ROOT%\Artifacts

call %ROOT%\Build\nuget-restore.bat & if %ERRORLEVEL% GEQ 1 exit /b %ERRORLEVEL%
call %ROOT%\Build\update-assemblyinfo.bat & if %ERRORLEVEL% GEQ 1 exit /b %ERRORLEVEL%
call %ROOT%\Build\build-src-release.bat & if %ERRORLEVEL% GEQ 1 exit /b %ERRORLEVEL%
call %ROOT%\Build\build-tests.bat & if %ERRORLEVEL% GEQ 1 exit /b %ERRORLEVEL%
call %ROOT%\Build\run-tests.bat & if %ERRORLEVEL% GEQ 1 exit /b %ERRORLEVEL%
call %ROOT%\Build\pack-nuget.bat & if %ERRORLEVEL% GEQ 1 exit /b %ERRORLEVEL%
call %ROOT%\Build\zip-artifacts.bat & if %ERRORLEVEL% GEQ 1 exit /b %ERRORLEVEL%