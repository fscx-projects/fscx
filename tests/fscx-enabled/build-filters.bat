@echo off
set nupkg_ver=0.6.2

cd sample_functional_filter
call nupack.bat %nupkg_ver%
cd ..

cd sample_inheritable_filter
call nupack.bat %nupkg_ver%
cd ..
