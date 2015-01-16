using System;
using Bond;
using Bond.Protocols;
using Bond.IO.Unsafe;
//using BondBench.Schemas;
using BenchmarkSuite.Framework;
using SerializersBenchmarks.Objects.Custom;

namespace BondBench
{
	[BenchFixture]
	public class MyClass
	{
		public MyClass ()
		{
		}

		[Bench]
		[Iterations(10000)]
		public static void Test()
		{
			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(ByteArray64K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(ByteArray64K));

			var arr = ByteArray64K.Create ();
			OutputBuffer output = null;
			output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			byte[] data;
			var b = Benchmark.StartNew ();
			for (int i = 0; i < 10000; i++) {
				output.Position = 0;
				ser.Serialize (arr, writer);
				//data = output.Data.Array;
				//data = new byte[output.Data.Count];
				//Buffer.BlockCopy  (output.Data.Array, output.Data.Offset, data, 0, output.Data.Count);
			}
			b.Stop ();

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var dst = deser.Deserialize<ByteArray64K>(reader);
			ByteArray64K.Compare(arr,dst);

		}
	}
}

