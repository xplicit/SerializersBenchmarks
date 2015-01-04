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
			NetSerializer.Serializer.Initialize(new Type[]{typeof(ByteArray64K),typeof(IntArray64K)});
		}

		[Bench]
		public void SerializeBytesStream()
		{
			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};

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

			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray64K des=(ByteArray64K)NetSerializer.Serializer.Deserialize(ms);
				}
			}

			b.Stop ();

			//Verification
			ByteArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=(ByteArray64K)NetSerializer.Serializer.Deserialize(ms);
			}

			ByteArray64K.Compare (arr, des1);
		}


		[Bench]
		//		[Ignore("Long running")]
		public void SerializeIntsStream()
		{
			var arr = new IntArray64K(){Arr = DataFiller.FillIntArray (65536)};

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter/40; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					NetSerializer.Serializer.Serialize(ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}

		[Bench]
		public void DeserializeIntsStream()
		{

			var arr = new IntArray64K(){Arr = DataFiller.FillIntArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter/40; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					IntArray64K des=(IntArray64K)NetSerializer.Serializer.Deserialize(ms);
				}
			}

			b.Stop ();

			//Verification
			IntArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=(IntArray64K)NetSerializer.Serializer.Deserialize(ms);
			}

			IntArray64K.Compare (arr, des1);
		}


	}
}

