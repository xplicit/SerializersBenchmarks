
using System;
using BenchmarkSuite.Framework;
using System.IO;
using SerializersBenchmarks;
using SerializersBenchmarks.Objects;
using Salar.Bois;

namespace BoisSerializerBench
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
			var ser=new BoisSerializer();
			var arr = ByteArray64K.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 10000; i++) {
					ms.Position = 0;
					ser.Serialize(arr,ms);
				}

				b.Stop ();
			}
		}
	
		[Bench]
		[Iterations(10000)]
		public void DeserializeByteArray64KStream()
		{

			var ser=new BoisSerializer();
			var arr = ByteArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 10000; i++) {
					ms.Position = 0;
					ByteArray64K des=ser.Deserialize<ByteArray64K>(ms);
				}
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
		[Iterations(1000000)]
		public void SerializeByteArray4KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser=new BoisSerializer();
			var arr = ByteArray4K.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 1000000; i++) {
					ms.Position = 0;
					ser.Serialize(arr,ms);
				}

				b.Stop ();
			}
		}
	
		[Bench]
		[Iterations(1000000)]
		public void DeserializeByteArray4KStream()
		{

			var ser=new BoisSerializer();
			var arr = ByteArray4K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 1000000; i++) {
					ms.Position = 0;
					ByteArray4K des=ser.Deserialize<ByteArray4K>(ms);
				}
			}

			b.Stop ();

			//Verification
			ByteArray4K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<ByteArray4K>(ms);
			}

			ByteArray4K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeIntArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser=new BoisSerializer();
			var arr = IntArray64K.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
					ser.Serialize(arr,ms);
				}

				b.Stop ();
			}
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeIntArray64KStream()
		{

			var ser=new BoisSerializer();
			var arr = IntArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
					IntArray64K des=ser.Deserialize<IntArray64K>(ms);
				}
			}

			b.Stop ();

			//Verification
			IntArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<IntArray64K>(ms);
			}

			IntArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeLongArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser=new BoisSerializer();
			var arr = LongArray64K.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
					ser.Serialize(arr,ms);
				}

				b.Stop ();
			}
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeLongArray64KStream()
		{

			var ser=new BoisSerializer();
			var arr = LongArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
					LongArray64K des=ser.Deserialize<LongArray64K>(ms);
				}
			}

			b.Stop ();

			//Verification
			LongArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<LongArray64K>(ms);
			}

			LongArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeShortArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser=new BoisSerializer();
			var arr = ShortArray64K.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
					ser.Serialize(arr,ms);
				}

				b.Stop ();
			}
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeShortArray64KStream()
		{

			var ser=new BoisSerializer();
			var arr = ShortArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 250; i++) {
					ms.Position = 0;
					ShortArray64K des=ser.Deserialize<ShortArray64K>(ms);
				}
			}

			b.Stop ();

			//Verification
			ShortArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<ShortArray64K>(ms);
			}

			ShortArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(1000000)]
		public void SerializePrimitiveTypeStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser=new BoisSerializer();
			var arr = PrimitiveType.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 1000000; i++) {
					ms.Position = 0;
					ser.Serialize(arr,ms);
				}

				b.Stop ();
			}
		}
	
		[Bench]
		[Iterations(1000000)]
		public void DeserializePrimitiveTypeStream()
		{

			var ser=new BoisSerializer();
			var arr = PrimitiveType.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 1000000; i++) {
					ms.Position = 0;
					PrimitiveType des=ser.Deserialize<PrimitiveType>(ms);
				}
			}

			b.Stop ();

			//Verification
			PrimitiveType des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<PrimitiveType>(ms);
			}

			PrimitiveType.Compare (arr, des1);

		}

		[Bench]
		[Iterations(1000)]
		public void SerializeIntList4KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser=new BoisSerializer();
			var arr = IntList4K.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 1000; i++) {
					ms.Position = 0;
					ser.Serialize(arr,ms);
				}

				b.Stop ();
			}
		}
	
		[Bench]
		[Iterations(1000)]
		public void DeserializeIntList4KStream()
		{

			var ser=new BoisSerializer();
			var arr = IntList4K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 1000; i++) {
					ms.Position = 0;
					IntList4K des=ser.Deserialize<IntList4K>(ms);
				}
			}

			b.Stop ();

			//Verification
			IntList4K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<IntList4K>(ms);
			}

			IntList4K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(1000)]
		public void SerializePrimitiveDictionary1KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser=new BoisSerializer();
			var arr = PrimitiveDictionary1K.Create();

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);

				var b = Benchmark.StartNew ();

				for (int i = 0; i < 1000; i++) {
					ms.Position = 0;
					ser.Serialize(arr,ms);
				}

				b.Stop ();
			}
		}
	
		[Bench]
		[Iterations(1000)]
		public void DeserializePrimitiveDictionary1KStream()
		{

			var ser=new BoisSerializer();
			var arr = PrimitiveDictionary1K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize(arr,ms);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			using (MemoryStream ms = new MemoryStream (data)) {
				for (int i = 0; i < 1000; i++) {
					ms.Position = 0;
					PrimitiveDictionary1K des=ser.Deserialize<PrimitiveDictionary1K>(ms);
				}
			}

			b.Stop ();

			//Verification
			PrimitiveDictionary1K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<PrimitiveDictionary1K>(ms);
			}

			PrimitiveDictionary1K.Compare (arr, des1);

		}

	}
}


