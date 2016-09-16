@echo off
del /q *.nupkg
..\.nuget\nuget.exe pack sample_filter.nuspec -Build -Properties Version=%1
