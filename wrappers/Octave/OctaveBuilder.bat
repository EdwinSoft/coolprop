
mkdir 3.6.1
mkdir 3.6.2
mkdir 3.6.4

call "C:\Program Files (x86)\Microsoft Visual Studio 9.0\VC\vcvarsall.bat"
REM : %%~nf gives just the file name, no path or extension
REM : %%f gives the full path and extension
for %%f in (..\..\CoolProp\*.cpp) do mkoctfile -v -c -I..\..\CoolProp -o %%~nf.o %%f
mkoctfile -v -c -I..\..\CoolProp -o CoolProp_wrap.o CoolProp_wrap.cpp
mkoctfile -v -o 3.6.1\CoolProp.oct *.o
erase *.o

call "C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"
for %%f in (..\..\CoolProp\*.cpp) do c:\octave3_6_2\bin\mkoctfile -v -c -I..\..\CoolProp -o %%~nf.o %%f
c:\octave3_6_2\bin\mkoctfile -v -c -I..\..\CoolProp -o CoolProp_wrap.o CoolProp_wrap.cpp
c:\octave3_6_2\bin\mkoctfile -v -o 3.6.2\CoolProp.oct *.o
erase *.o

call "C:\Program Files (x86)\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"
for %%f in (..\..\CoolProp\*.cpp) do c:\octave3_6_4\bin\mkoctfile -v -c -I..\..\CoolProp -o %%~nf.o %%f
c:\octave3_6_4\bin\mkoctfile -v -c -I..\..\CoolProp -o CoolProp_wrap.o CoolProp_wrap.cpp
c:\octave3_6_4\bin\mkoctfile -v -o 3.6.4\CoolProp.oct *.o
erase *.o