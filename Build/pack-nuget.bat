@echo off
SET ROOT=%~dp0..
SET CoreNugetSpecFile=%ROOT%\Build\PortableLog.Core.nuspec
SET NLogNugetSpecFile=%ROOT%\Build\PortableLog.NLog.nuspec
SET NuGetExe=%ROOT%\Tools\NuGet.exe
SET NuGetOutDir=%ROOT%\Artifacts\NuGet

mkdir "%NuGetOutDir%"

%NuGetExe% pack %CoreNugetSpecFile% -Verbosity detailed -OutputDirectory "%NuGetOutDir%" -BasePath "%ROOT%" -Symbols
%NuGetExe% pack %NLogNugetSpecFile% -Verbosity detailed -OutputDirectory "%NuGetOutDir%" -BasePath "%ROOT%" -Symbols