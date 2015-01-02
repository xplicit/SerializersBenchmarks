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
			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};

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
			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray64K des=ser.Deserialize<ByteArray64K>(ms);
				}
			}

			b.Stop ();
		}

		[Bench]
		public void DeserializeBytesArray()
		{

			BinarySerializer ser = new BinarySerializer ();
			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
					ByteArray64K des=ser.Deserialize<ByteArray64K>(data);
			}

			b.Stop ();

			//Verification
			ByteArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<ByteArray64K>(ms);
			}

			ByteArray64K.Compare (arr, des1);

		}

		[Bench]
		//		[Ignore("Long running")]
		public void SerializeIntsStream()
		{

			BinarySerializer ser = new BinarySerializer ();
			var arr = new IntArray64K(){Arr = DataFiller.FillIntArray (65536)};

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

		[Bench]
		public void DeserializeIntsStream()
		{

			BinarySerializer ser = new BinarySerializer ();
			var arr = new IntArray64K(){Arr = DataFiller.FillIntArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter/10; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					IntArray64K des=ser.Deserialize<IntArray64K>(ms);

				}
				Console.WriteLine ("{0}", i);
			}

			b.Stop ();

			//Verification
			IntArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<IntArray64K>(ms);
			}

			IntArray64K.Compare (arr, des1);
		}


	}
}

