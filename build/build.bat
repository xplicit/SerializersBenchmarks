FOR /F "tokens=2*" %%A IN ('reg.exe query "HKLM\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0" /v MSBuildToolsPath 2^>NUL ^| FIND "REG_SZ"') DO SET msbuild=%%B\msbuild.exe
echo msbuild=%msbuild%
if exist nuget.exe goto install 
powershell.exe -noprofile -executionpolicy bypass -file GetNuget.ps1
:install
nuget.exe install BenchmarkSuite.ConsoleRunner -version 1.0.2
nuget.exe restore ..\SerializersBenchmarks.sln
%msbuild% /p:Configuration=Release /p:Platform="Any CPU" ..\SerializersBenchmarks.sln
BenchmarkSuite.ConsoleRunner.1.0.2\tools\bench-console.exe ..\src\AvroBench\bin\Release\AvroBench.dll ..\src\BinarySerializerBench\bin\Release\BinarySerializerBench.dll ..\src\BoisBench\bin\Release\BoisBench.dll ..\src\BondBench\bin\Release\BondBench.dll ..\src\MsgPackBench\bin\Release\MsgPackBench.dll ..\src\NetSerializerBench\bin\Release\NetSerializerBench.dll ..\src\ProtoBench\bin\Release\ProtoBench.dll