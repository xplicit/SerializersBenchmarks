using System;
using BenchmarkSuite.Framework;
using System.IO;
using SerializersBenchmarks;
using BinarySerialization;
using SerializersBenchmarks.Objects.Custom;

namespace BinarySerializerBench
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
			BinarySerializer ser = new BinarySerializer ();
			var arr = new ByteArray1(){Arr = DataFiller.FillByteArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					ser.Serialize (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

		[Bench]
		public void DeserializeBytesStream()
		{

			BinarySerializer ser = new BinarySerializer ();
			var arr = new ByteArray1(){Arr = DataFiller.FillByteArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray1 des=ser.Deserialize<ByteArray1>(ms);
				}
			}

			b.Stop ();
		}

		[Bench]
		public void DeserializeBytesArray()
		{

			BinarySerializer ser = new BinarySerializer ();
			var arr = new ByteArray1(){Arr = DataFiller.FillByteArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
					ByteArray1 des=ser.Deserialize<ByteArray1>(data);
			}

			b.Stop ();
		}

		[Bench]
		//		[Ignore("Long running")]
		public void SerializeIntsStream()
		{

			BinarySerializer ser = new BinarySerializer ();
			var arr = new IntArray1(){Arr = DataFiller.FillIntArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter/10; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					ser.Serialize (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

	}
}

