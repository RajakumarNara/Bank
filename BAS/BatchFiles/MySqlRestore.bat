@ECHO off
cls

set Password=%1%
set DBchoice=%2%
set pathchoice=%3%

@REM Remove double quotes from the path
@REM SET pathchoice=%pathchoice:"=%
@REM SET pathchoice=%pathchoice:"=%


mysql -u root --password=%Password% %DBchoice% < %pathchoice%