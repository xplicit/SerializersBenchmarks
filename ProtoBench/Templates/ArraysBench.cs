using System;
using BenchmarkSuite.Framework;
using System.IO;
using SerializersBenchmarks;
using SerializersBenchmarks.Objects.Custom;

namespace ProtoBench
{
	[BenchFixture]
	public partial class ArraysBench
	{
		const int nIter = 10000;

		public ArraysBench ()
		{
					}

		[Bench]
		public void SerializeByteArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = ByteArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 10000; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ProtoBuf.Serializer.Serialize<ByteArray64K> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		public void DeserializeByteArray64KStream()
		{

						var arr = ByteArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ProtoBuf.Serializer.Serialize<ByteArray64K> (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 10000; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray64K des=ProtoBuf.Serializer.Deserialize<ByteArray64K>(ms);
				}
			}

			b.Stop ();

			//Verification
			ByteArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ProtoBuf.Serializer.Deserialize<ByteArray64K>(ms);
			}

			ByteArray64K.Compare (arr, des1);

		}

		[Bench]
		public void SerializeIntArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = IntArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ProtoBuf.Serializer.Serialize<IntArray64K> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		public void DeserializeIntArray64KStream()
		{

						var arr = IntArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ProtoBuf.Serializer.Serialize<IntArray64K> (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					IntArray64K des=ProtoBuf.Serializer.Deserialize<IntArray64K>(ms);
				}
			}

			b.Stop ();

			//Verification
			IntArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ProtoBuf.Serializer.Deserialize<IntArray64K>(ms);
			}

			IntArray64K.Compare (arr, des1);

		}

		[Bench]
		public void SerializeLongArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = LongArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ProtoBuf.Serializer.Serialize<LongArray64K> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		public void DeserializeLongArray64KStream()
		{

						var arr = LongArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ProtoBuf.Serializer.Serialize<LongArray64K> (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					LongArray64K des=ProtoBuf.Serializer.Deserialize<LongArray64K>(ms);
				}
			}

			b.Stop ();

			//Verification
			LongArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ProtoBuf.Serializer.Deserialize<LongArray64K>(ms);
			}

			LongArray64K.Compare (arr, des1);

		}

		[Bench]
		public void SerializeShortArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = ShortArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ProtoBuf.Serializer.Serialize<ShortArray64K> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		public void DeserializeShortArray64KStream()
		{

						var arr = ShortArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ProtoBuf.Serializer.Serialize<ShortArray64K> (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ShortArray64K des=ProtoBuf.Serializer.Deserialize<ShortArray64K>(ms);
				}
			}

			b.Stop ();

			//Verification
			ShortArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ProtoBuf.Serializer.Deserialize<ShortArray64K>(ms);
			}

			ShortArray64K.Compare (arr, des1);

		}

	}
}


