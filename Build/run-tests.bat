@echo off
SET ROOT=%~dp0..
set LogDir=%ROOT%\Artifacts\Logs
set TestsBinDir=%ROOT%\Artifacts\Tests\AnyCPU_Release
mkdir %LogDir%

%ROOT%\Tools\NUnit\nunit-console.exe "%TestsBinDir%\PortableLog.Tests.dll" /framework="net-4.0" /xml:%LogDir%\PortableLog.Tests.xml