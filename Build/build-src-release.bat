@echo off
SET ROOT=%~dp0..
%WinDir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe %ROOT%\PortableLog.sln  /verbosity:normal /p:Configuration=Release /p:Platform="Any CPU" /p:RestorePackages=false /m:4