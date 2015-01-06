using System;
using BenchmarkSuite.Framework;
using MsgPack.Serialization;
using SerializersBenchmarks.Objects;
using System.IO;
using SerializersBenchmarks;

namespace MsgPackBench
{
	public partial class ArraysBench
	{
		[Bench]
		public void SerializeBytesArray()
		{

			var ser = SerializationContext.Default.GetSerializer<ByteArray64K> ();
			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				byte[] res;
				res = ser.PackSingleObject (arr);
			}

			b.Stop ();
		}

	}
}

