#!/bin/sh
export NUGET="mono nuget.exe"
if [ ! -e nuget.exe ]; then curl -s -o "nuget.exe" -L "http://www.nuget.org/nuget.exe"; fi
$NUGET install BenchmarkSuite.ConsoleRunner -version 1.0.2
$NUGET restore ../SerializersBenchmarks.sln
xbuild /p:Configuration=Release ../SerializersBenchmarks.sln
mono $MONO_OPTIONS BenchmarkSuite.ConsoleRunner.1.0.2/tools/bench-console.exe ../src/AvroBench/bin/Release/AvroBench.dll ../src/BinarySerializerBench/bin/Release/BinarySerializerBench.dll ../src/BoisBench/bin/Release/BoisBench.dll ../src/BondBench/bin/Release/BondBench.dll ../src/MsgPackBench/bin/Release/MsgPackBench.dll ../src/NetSerializerBench/bin/Release/NetSerializerBench.dll ../src/ProtoBench/bin/Release/ProtoBench.dll

