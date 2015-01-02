using System;
using System.IO;
using BenchmarkSuite.Framework;
using DataFiller=SerializersBenchmarks.DataFiller;
using SerializersBenchmarks.Objects.Custom;

namespace NetSerializerBench
{
	[BenchFixture]
	public class BytesBench
	{
		const int nIter = 10000;

		public BytesBench ()
		{
			NetSerializer.Serializer.Initialize(new Type[]{typeof(ByteArray1),typeof(IntArray1)});
		}

		[Bench]
		public void SerializeBytesStream()
		{
			var arr = new ByteArray1(){Arr = DataFiller.FillByteArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					NetSerializer.Serializer.Serialize(ms, arr);
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
				NetSerializer.Serializer.Serialize(ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray1 des=(ByteArray1)NetSerializer.Serializer.Deserialize(ms);
				}
			}

			b.Stop ();

			//Verification
			ByteArray1 des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=(ByteArray1)NetSerializer.Serializer.Deserialize(ms);
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
			var arr = new IntArray1(){Arr = DataFiller.FillIntArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter/10; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					NetSerializer.Serializer.Serialize(ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

	}
}

