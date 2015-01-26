
using System;
using BenchmarkSuite.Framework;
using System.IO;
using SerializersBenchmarks;
using SerializersBenchmarks.Objects.Custom;
using BondBench.Schemas;
using Bond;
using Bond.Protocols;
using Bond.IO.Unsafe;

namespace BondBench
{
	[BenchFixture]
	public partial class ArraysBench
	{
		const int nIter = 10000;

		public ArraysBench ()
		{
					}

		[Bench]
		[Iterations(100000)]
		public void SerializeByteArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(ByteArray64K));
			var arr = ByteArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 100000; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(100000)]
		public void DeserializeByteArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(ByteArray64K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(ByteArray64K));
			var arr = ByteArray64K.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 100000; i++) {
				input.Position = 0;
				var des = deser.Deserialize<ByteArray64K>(reader);
			}

			b.Stop ();

			//Verification
			ByteArray64K des1;

			input.Position = 0;
			des1 = deser.Deserialize<ByteArray64K>(reader);

			ByteArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(1000000)]
		public void SerializeByteArray4KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(ByteArray4K));
			var arr = ByteArray4K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000000; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(1000000)]
		public void DeserializeByteArray4KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(ByteArray4K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(ByteArray4K));
			var arr = ByteArray4K.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000000; i++) {
				input.Position = 0;
				var des = deser.Deserialize<ByteArray4K>(reader);
			}

			b.Stop ();

			//Verification
			ByteArray4K des1;

			input.Position = 0;
			des1 = deser.Deserialize<ByteArray4K>(reader);

			ByteArray4K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeIntArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(IntArray64K));
			var arr = IntArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeIntArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(IntArray64K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(IntArray64K));
			var arr = IntArray64K.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				input.Position = 0;
				var des = deser.Deserialize<IntArray64K>(reader);
			}

			b.Stop ();

			//Verification
			IntArray64K des1;

			input.Position = 0;
			des1 = deser.Deserialize<IntArray64K>(reader);

			IntArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeLongArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(LongArray64K));
			var arr = LongArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeLongArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(LongArray64K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(LongArray64K));
			var arr = LongArray64K.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				input.Position = 0;
				var des = deser.Deserialize<LongArray64K>(reader);
			}

			b.Stop ();

			//Verification
			LongArray64K des1;

			input.Position = 0;
			des1 = deser.Deserialize<LongArray64K>(reader);

			LongArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeShortArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(ShortArray64K));
			var arr = ShortArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeShortArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(ShortArray64K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(ShortArray64K));
			var arr = ShortArray64K.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				input.Position = 0;
				var des = deser.Deserialize<ShortArray64K>(reader);
			}

			b.Stop ();

			//Verification
			ShortArray64K des1;

			input.Position = 0;
			des1 = deser.Deserialize<ShortArray64K>(reader);

			ShortArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeFloatArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(FloatArray64K));
			var arr = FloatArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeFloatArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(FloatArray64K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(FloatArray64K));
			var arr = FloatArray64K.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				input.Position = 0;
				var des = deser.Deserialize<FloatArray64K>(reader);
			}

			b.Stop ();

			//Verification
			FloatArray64K des1;

			input.Position = 0;
			des1 = deser.Deserialize<FloatArray64K>(reader);

			FloatArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(250)]
		public void SerializeDoubleArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(DoubleArray64K));
			var arr = DoubleArray64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(250)]
		public void DeserializeDoubleArray64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(DoubleArray64K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(DoubleArray64K));
			var arr = DoubleArray64K.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 250; i++) {
				input.Position = 0;
				var des = deser.Deserialize<DoubleArray64K>(reader);
			}

			b.Stop ();

			//Verification
			DoubleArray64K des1;

			input.Position = 0;
			des1 = deser.Deserialize<DoubleArray64K>(reader);

			DoubleArray64K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(1000000)]
		public void SerializePrimitiveTypeStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(PrimitiveType));
			var arr = PrimitiveType.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000000; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(1000000)]
		public void DeserializePrimitiveTypeStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(PrimitiveType));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(PrimitiveType));
			var arr = PrimitiveType.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000000; i++) {
				input.Position = 0;
				var des = deser.Deserialize<PrimitiveType>(reader);
			}

			b.Stop ();

			//Verification
			PrimitiveType des1;

			input.Position = 0;
			des1 = deser.Deserialize<PrimitiveType>(reader);

			PrimitiveType.Compare (arr, des1);

		}

		[Bench]
		[Iterations(1000)]
		public void SerializeIntList4KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(IntList4K));
			var arr = IntList4K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(1000)]
		public void DeserializeIntList4KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(IntList4K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(IntList4K));
			var arr = IntList4K.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000; i++) {
				input.Position = 0;
				var des = deser.Deserialize<IntList4K>(reader);
			}

			b.Stop ();

			//Verification
			IntList4K des1;

			input.Position = 0;
			des1 = deser.Deserialize<IntList4K>(reader);

			IntList4K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(1000)]
		public void SerializePrimitiveDictionary1KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(PrimitiveDictionary1K));
			var arr = PrimitiveDictionary1K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(1000)]
		public void DeserializePrimitiveDictionary1KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(PrimitiveDictionary1K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(PrimitiveDictionary1K));
			var arr = PrimitiveDictionary1K.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 1000; i++) {
				input.Position = 0;
				var des = deser.Deserialize<PrimitiveDictionary1K>(reader);
			}

			b.Stop ();

			//Verification
			PrimitiveDictionary1K des1;

			input.Position = 0;
			des1 = deser.Deserialize<PrimitiveDictionary1K>(reader);

			PrimitiveDictionary1K.Compare (arr, des1);

		}

		[Bench]
		[Iterations(100000)]
		public void SerializeArraySegment64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(ArraySegment64K));
			var arr = ArraySegment64K.Create();

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 100000; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
			}

			b.Stop ();
		}
	
		[Bench]
		[Iterations(100000)]
		public void DeserializeArraySegment64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(ArraySegment64K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(ArraySegment64K));
			var arr = ArraySegment64K.Create();
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 100000; i++) {
				input.Position = 0;
				var des = deser.Deserialize<ArraySegment64K>(reader);
			}

			b.Stop ();

			//Verification
			ArraySegment64K des1;

			input.Position = 0;
			des1 = deser.Deserialize<ArraySegment64K>(reader);

			ArraySegment64K.Compare (arr, des1);

		}

	}
}

