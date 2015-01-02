using System;
using System.IO;
using BenchmarkSuite.Framework;
using ProtoBuf;
using DataFiller=SerializersBenchmarks.DataFiller;
using SerializersBenchmarks.Objects.Custom;

namespace ProtoBench
{
	[BenchFixture]
	public class BytesBench
	{
		const int nIter = 10000;

		public BytesBench ()
		{
		}

		[Bench]
		public void SerializeBytesStream()
		{

			var arr = new ByteArray1(){Arr = DataFiller.FillByteArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					ProtoBuf.Serializer.Serialize<ByteArray1> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

		[Bench]
		public void DeserializeBytesStream()
		{

			var arr = new ByteArray1(){Arr = DataFiller.FillByteArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ProtoBuf.Serializer.Serialize<ByteArray1> (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray1 des=ProtoBuf.Serializer.Deserialize<ByteArray1> (ms);
				}
			}

			b.Stop ();
		}

		[Bench]
		public void SerializeBytesStreamWithCapacity()
		{

			var arr = new ByteArray1(){Arr = DataFiller.FillByteArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream (68000)) {
					ProtoBuf.Serializer.Serialize<ByteArray1> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

		[Bench]
		public void SerializeBytesReuseStream()
		{

			var arr = new ByteArray1(){Arr = DataFiller.FillByteArray (65536)};

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream ()) {
				for (int i = 0; i < nIter; i++) {
					byte[] res;
					ms.Position = 0;
					ProtoBuf.Serializer.Serialize<ByteArray1> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

		[Bench]
//		[Ignore("Long running")]
		public void SerializeIntsStream()
		{

			var arr = new IntArray1(){Arr = DataFiller.FillIntArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter/10; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					ProtoBuf.Serializer.Serialize<IntArray1> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

	}
}

