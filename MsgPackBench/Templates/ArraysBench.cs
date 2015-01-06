using System;
using BenchmarkSuite.Framework;
using System.IO;
using SerializersBenchmarks;
using SerializersBenchmarks.Objects;
using MsgPack.Serialization;

namespace MsgPackBench
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
			var ser = SerializationContext.Default.GetSerializer<ByteArray64K> ();
			var arr = ByteArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 10000; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ser.Pack(ms,arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(10000)]
		public void DeserializeByteArray64KStream()
		{

			var ser = SerializationContext.Default.GetSerializer<ByteArray64K> ();
			var arr = ByteArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Pack(ms,arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 10000; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray64K des=ser.Unpack(ms);
				}
			}

			b.Stop ();

			//Verification
			ByteArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Unpack(ms);
			}

			ByteArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(100000)]
		public void SerializeByteArray4KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser = SerializationContext.Default.GetSerializer<ByteArray4K> ();
			var arr = ByteArray4K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 100000; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ser.Pack(ms,arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(100000)]
		public void DeserializeByteArray4KStream()
		{

			var ser = SerializationContext.Default.GetSerializer<ByteArray4K> ();
			var arr = ByteArray4K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Pack(ms,arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 100000; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ByteArray4K des=ser.Unpack(ms);
				}
			}

			b.Stop ();

			//Verification
			ByteArray4K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Unpack(ms);
			}

			ByteArray4K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeIntArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser = SerializationContext.Default.GetSerializer<IntArray64K> ();
			var arr = IntArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ser.Pack(ms,arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeIntArray64KStream()
		{

			var ser = SerializationContext.Default.GetSerializer<IntArray64K> ();
			var arr = IntArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Pack(ms,arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					IntArray64K des=ser.Unpack(ms);
				}
			}

			b.Stop ();

			//Verification
			IntArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Unpack(ms);
			}

			IntArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeLongArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser = SerializationContext.Default.GetSerializer<LongArray64K> ();
			var arr = LongArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ser.Pack(ms,arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeLongArray64KStream()
		{

			var ser = SerializationContext.Default.GetSerializer<LongArray64K> ();
			var arr = LongArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Pack(ms,arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					LongArray64K des=ser.Unpack(ms);
				}
			}

			b.Stop ();

			//Verification
			LongArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Unpack(ms);
			}

			LongArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeShortArray64KStream()
		{
			//BinarySerializer ser = new BinarySerializer ();
			var ser = SerializationContext.Default.GetSerializer<ShortArray64K> ();
			var arr = ShortArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				byte[] res;
				using (MemoryStream ms = new MemoryStream ()) {
					//ser.Serialize (ms, arr);
					ser.Pack(ms,arr);
					res = ms.ToArray ();
				}
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeShortArray64KStream()
		{

			var ser = SerializationContext.Default.GetSerializer<ShortArray64K> ();
			var arr = ShortArray64K.Create();
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Pack(ms,arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				using (MemoryStream ms = new MemoryStream (data)) {
					ShortArray64K des=ser.Unpack(ms);
				}
			}

			b.Stop ();

			//Verification
			ShortArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Unpack(ms);
			}

			ShortArray64K.Compare (arr, des1);

		}

	}
}


