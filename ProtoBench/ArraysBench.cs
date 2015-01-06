using System;
using System.IO;
using BenchmarkSuite.Framework;
using ProtoBuf;
using DataFiller=SerializersBenchmarks.DataFiller;
using SerializersBenchmarks.Objects.Custom;

namespace ProtoBench
{
	public partial class ArraysBench
	{
		[Bench]
		public void SerializeBytesStreamWithCapacity()
		{

			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream (68000)) {
					ProtoBuf.Serializer.Serialize<ByteArray64K> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

		[Bench]
		public void SerializeBytesReuseStream()
		{

			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream ()) {
				for (int i = 0; i < nIter; i++) {
					byte[] res;
					ms.Position = 0;
					ProtoBuf.Serializer.Serialize<ByteArray64K> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	}
}

