@echo off
del /q *.nupkg
..\.nuget\nuget.exe pack sample_filter.nuspec -Properties Version=%1
