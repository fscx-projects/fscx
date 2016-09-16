@echo off
set nupkg_ver=0.5.1

cd sample_delegatable_filter
call nupack.bat %nupkg_ver%
cd ..

cd sample_functional_filter
call nupack.bat %nupkg_ver%
cd ..

cd sample_inheritable_filter
call nupack.bat %nupkg_ver%
cd ..
