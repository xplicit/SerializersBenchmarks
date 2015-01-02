using System;
using BenchmarkSuite.Framework;
using MsgPack.Serialization;
using SerializersBenchmarks.Objects;
using System.IO;
using SerializersBenchmarks;

namespace MsgPackBench
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

			var ser = SerializationContext.Default.GetSerializer<ByteArray64K> ();
			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					ser.Pack (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

		[Bench]
		public void DeserializeBytesStream()
		{

			var ser = SerializationContext.Default.GetSerializer<ByteArray64K> ();
			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Pack (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray64K des=ser.Unpack(ms);
				}
			}

			b.Stop ();
		}


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

		[Bench]
//		[Ignore("Long running")]
		public void SerializeIntsStream()
		{

			var ser = SerializationContext.Default.GetSerializer<IntArray64K> ();
			var arr = new IntArray64K(){Arr = DataFiller.FillIntArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter/10; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					ser.Pack (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

	}
}

