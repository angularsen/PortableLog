@echo OFF
cd %~dp0..
SET binCount=0
SET objCount=0
@FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin 2^>NUL') DO (RMDIR /S /Q "%%G" & SET /A binCount+=1)
@FOR /F "tokens=*" %%G IN ('DIR /B /AD /S obj 2^>NUL') DO (RMDIR /S /Q "%%G" & SET /A objCount+=1)

echo Found %binCount% bin folders.
echo Found %objCount% obj folders.

SET remaining=0
echo.


@FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin 2^>NUL') DO SET /A remaining+=1
@FOR /F "tokens=*" %%G IN ('DIR /B /AD /S obj 2^>NUL') DO SET /A remaining+=1
echo.
IF %remaining% == 0 goto end
echo Remaining bin and obj folders: %remaining%
echo.
:end
pause