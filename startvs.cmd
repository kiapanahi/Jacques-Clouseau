@ECHO OFF
SETLOCAL

:: This command launches a Visual Studio solution with environment variables required to use a local version of the .NET Core SDK.

SET sln=%~1

IF "%sln%"=="" (
    echo Solution not specified, using Clouseau.sln
    SET sln=%~dp0Clouseau.sln
)

start "" "%sln%"
