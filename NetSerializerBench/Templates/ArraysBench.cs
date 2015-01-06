using System;
using BenchmarkSuite.Framework;
using System.IO;
using SerializersBenchmarks;
using SerializersBenchmarks.Objects.Custom;

namespace NetSerializerBench
{
	[BenchFixture]
	public partial class ArraysBench
	{
		const int nIter = 10000;

		public ArraysBench ()
		{
			NetSerializer.Serializer.Initialize(new Type[]{typeof(ByteArray64K),typeof(ByteArray4K),typeof(IntArray64K),typeof(LongArray64K),typeof(ShortArray64K)});
		}

		[Bench]
		[Iterations(10000)]
		public void SerializeByteArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = ByteArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 10000; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					NetSerializer.Serializer.Serialize(ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(10000)]
		public void DeserializeByteArray64KStream()
		{

						var arr = ByteArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 10000; i++) {
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
		[Iterations(100000)]
		public void SerializeByteArray4KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = ByteArray4K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 100000; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					NetSerializer.Serializer.Serialize(ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(100000)]
		public void DeserializeByteArray4KStream()
		{

						var arr = ByteArray4K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 100000; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray4K des=(ByteArray4K)NetSerializer.Serializer.Deserialize(ms);
				}
			}

			b.Stop ();

			//Verification
			ByteArray4K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=(ByteArray4K)NetSerializer.Serializer.Deserialize(ms);
			}

			ByteArray4K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeIntArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = IntArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					NetSerializer.Serializer.Serialize(ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeIntArray64KStream()
		{

						var arr = IntArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
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

		[Bench]
		[Iterations(250)]
		public void SerializeLongArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = LongArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					NetSerializer.Serializer.Serialize(ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeLongArray64KStream()
		{

						var arr = LongArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					LongArray64K des=(LongArray64K)NetSerializer.Serializer.Deserialize(ms);
				}
			}

			b.Stop ();

			//Verification
			LongArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=(LongArray64K)NetSerializer.Serializer.Deserialize(ms);
			}

			LongArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeShortArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = ShortArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					NetSerializer.Serializer.Serialize(ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeShortArray64KStream()
		{

						var arr = ShortArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ShortArray64K des=(ShortArray64K)NetSerializer.Serializer.Deserialize(ms);
				}
			}

			b.Stop ();

			//Verification
			ShortArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=(ShortArray64K)NetSerializer.Serializer.Deserialize(ms);
			}

			ShortArray64K.Compare (arr, des1);

		}

	}
}


