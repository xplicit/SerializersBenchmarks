
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
			NetSerializer.Serializer.Initialize(new Type[]{typeof(ByteArray64K),typeof(ByteArray4K),typeof(IntArray64K),typeof(LongArray64K),typeof(ShortArray64K),typeof(PrimitiveType),typeof(IntList4K)});
		}

		[Bench]
		[Iterations(10000)]
		public void SerializeByteArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = ByteArray64K.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 10000; i++) {
					ms.Position = 0;
					NetSerializer.Serializer.Serialize(ms, arr);
				}

				b.Stop ();
			}
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

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 10000; i++) {
					ms.Position = 0;
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

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 100000; i++) {
					ms.Position = 0;
					NetSerializer.Serializer.Serialize(ms, arr);
				}

				b.Stop ();
			}
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

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 100000; i++) {
					ms.Position = 0;
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

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
					NetSerializer.Serializer.Serialize(ms, arr);
				}

				b.Stop ();
			}
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

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
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

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
					NetSerializer.Serializer.Serialize(ms, arr);
				}

				b.Stop ();
			}
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

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
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

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
					NetSerializer.Serializer.Serialize(ms, arr);
				}

				b.Stop ();
			}
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

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
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

		[Bench]
		[Iterations(1000000)]
		public void SerializePrimitiveTypeStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = PrimitiveType.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 1000000; i++) {
					ms.Position = 0;
					NetSerializer.Serializer.Serialize(ms, arr);
				}

				b.Stop ();
			}
		}
	
		[Bench]
		[Iterations(1000000)]
		public void DeserializePrimitiveTypeStream()
		{

						var arr = PrimitiveType.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 1000000; i++) {
					ms.Position = 0;
					PrimitiveType des=(PrimitiveType)NetSerializer.Serializer.Deserialize(ms);
				}
			}

			b.Stop ();

			//Verification
			PrimitiveType des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=(PrimitiveType)NetSerializer.Serializer.Deserialize(ms);
			}

			PrimitiveType.Compare (arr, des1);

		}

		[Bench]
		[Iterations(1000)]
		public void SerializeIntList4KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
						var arr = IntList4K.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 1000; i++) {
					ms.Position = 0;
					NetSerializer.Serializer.Serialize(ms, arr);
				}

				b.Stop ();
			}
		}
	
		[Bench]
		[Iterations(1000)]
		public void DeserializeIntList4KStream()
		{

						var arr = IntList4K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				NetSerializer.Serializer.Serialize(ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 1000; i++) {
					ms.Position = 0;
					IntList4K des=(IntList4K)NetSerializer.Serializer.Deserialize(ms);
				}
			}

			b.Stop ();

			//Verification
			IntList4K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=(IntList4K)NetSerializer.Serializer.Deserialize(ms);
			}

			IntList4K.Compare (arr, des1);

		}

	}
}


