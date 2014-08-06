@ECHO OFF
:: delims is a TAB followed by a space
FOR /F "tokens=2* delims=	 " %%A IN ('REG QUERY "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\InnerSpace.exe" /v "Path"') DO SET InnerSpacePath=%%B


copy ISXEQ2WrapperTest.exe "%InnerSpacePath%\.NET Programs"
REM copy ISXEQ2Wrapper.XML "%InnerSpacePath%\.NET Programs"
REM copy ISXEQ2Wrapper.dll "s:\.NET Programs"