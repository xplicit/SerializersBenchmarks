using System;
using Bond;
using Bond.Protocols;
using Bond.IO.Unsafe;
//using BondBench.Schemas;
using BenchmarkSuite.Framework;
using BondBench.Schemas;

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
		public void DeserializeArraySegment64KStream()
		{
			var output = new OutputBuffer();
			var writer = new CompactBinaryWriter<OutputBuffer>(output);

			var ser = new Serializer<CompactBinaryWriter<OutputBuffer>> (typeof(ArraySegment64K));
			var deser = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(ArraySegment64K));
			var arr = ArraySegment64K.Create(100);
			var arr1 = ArraySegment64K.Create(200);
			byte[] data;

			ser.Serialize (arr, writer);

			var input = new InputBuffer(output.Data);
			var reader = new CompactBinaryReader<InputBuffer>(input);

			var b = Benchmark.StartNew ();

			for (int i = 0; i < 10000; i++) {
				input.Position = 0;
				var des = deser.Deserialize<ArraySegment64K>(reader);
			}

			b.Stop ();

			//Verification
			ArraySegment64K des1;

			input.Position = 0;
			des1 = deser.Deserialize<ArraySegment64K>(reader);

			output.Position = 0;
			ser.Serialize (arr1, writer);


			ArraySegment64K.Compare (arr, des1);
		}
	}
}

