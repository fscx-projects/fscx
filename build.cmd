@echo off
cls

rem .paket\paket.bootstrapper.exe
rem if errorlevel 1 (
rem   exit /b %errorlevel%
rem )

rem .paket\paket.exe restore
rem if errorlevel 1 (
rem   exit /b %errorlevel%
rem )

rem IF NOT EXIST build.fsx (
rem   .paket\paket.exe update
rem   packages\build\FAKE\tools\FAKE.exe init.fsx
rem )

packages\FAKE.4.61.3\tools\FAKE.exe build.fsx %*
