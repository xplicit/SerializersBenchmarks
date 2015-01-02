using System;
using BenchmarkSuite.Framework;
using SerializersBenchmarks;
using System.IO;
using Salar.Bois;
using SerializersBenchmarks.Objects;

namespace BoisBench
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

			var ser = new BoisSerializer ();
			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					ser.Serialize (arr, ms);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

		[Bench]
		public void DeserializeBytesStream()
		{

			var ser = new BoisSerializer ();
			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize (arr, ms);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray64K des=ser.Deserialize<ByteArray64K>(ms);
				}
			}

			b.Stop ();

			//Verification
			ByteArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<ByteArray64K>(ms);
			}

			if (arr.Arr.Length != des1.Arr.Length)
				throw new ArgumentException("Arrays length not equal");

			for(int i=0;i<arr.Arr.Length;i++)
			{
				if (arr.Arr[i] != des1.Arr[i]) 
				{
					throw new ArgumentException("Arrays data not equal");
				}
			}
		}


		[Bench]
//		[Ignore("Long running")]
		public void SerializeIntsStream()
		{

			var ser = new BoisSerializer ();
			var arr = new IntArray64K(){Arr = DataFiller.FillIntArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter/10; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					ser.Serialize (arr, ms);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

	}
}

