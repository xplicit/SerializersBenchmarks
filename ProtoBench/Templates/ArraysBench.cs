
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
					ProtoBuf.Serializer.Serialize<ByteArray64K> (ms, arr);
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
					ProtoBuf.Serializer.Serialize<ByteArray4K> (ms, arr);
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
				ProtoBuf.Serializer.Serialize<ByteArray4K> (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 100000; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray4K des=ProtoBuf.Serializer.Deserialize<ByteArray4K>(ms);
				}
			}

			b.Stop ();

			//Verification
			ByteArray4K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ProtoBuf.Serializer.Deserialize<ByteArray4K>(ms);
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
					ProtoBuf.Serializer.Serialize<IntArray64K> (ms, arr);
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
					ProtoBuf.Serializer.Serialize<LongArray64K> (ms, arr);
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
					ProtoBuf.Serializer.Serialize<ShortArray64K> (ms, arr);
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

		[Bench]
		[Iterations(1000000)]
		public void SerializePrimitiveTypeStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = PrimitiveType.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000000; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ProtoBuf.Serializer.Serialize<PrimitiveType> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(1000000)]
		public void DeserializePrimitiveTypeStream()
		{

						var arr = PrimitiveType.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ProtoBuf.Serializer.Serialize<PrimitiveType> (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000000; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					PrimitiveType des=ProtoBuf.Serializer.Deserialize<PrimitiveType>(ms);
				}
			}

			b.Stop ();

			//Verification
			PrimitiveType des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ProtoBuf.Serializer.Deserialize<PrimitiveType>(ms);
			}

			PrimitiveType.Compare (arr, des1);

		}

		[Bench]
		[Iterations(1000)]
		public void SerializeIntList4KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = IntList4K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ProtoBuf.Serializer.Serialize<IntList4K> (ms, arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(1000)]
		public void DeserializeIntList4KStream()
		{

						var arr = IntList4K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ProtoBuf.Serializer.Serialize<IntList4K> (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					IntList4K des=ProtoBuf.Serializer.Deserialize<IntList4K>(ms);
				}
			}

			b.Stop ();

			//Verification
			IntList4K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ProtoBuf.Serializer.Deserialize<IntList4K>(ms);
			}

			IntList4K.Compare (arr, des1);

		}

	}
}


