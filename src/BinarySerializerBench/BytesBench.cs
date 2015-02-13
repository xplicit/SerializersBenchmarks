using System;
using BenchmarkSuite.Framework;
using System.IO;
using SerializersBenchmarks;
using BinarySerialization;
using SerializersBenchmarks.Objects.Custom;

namespace BinarySerializerBench
{
	public partial class ArraysBench
	{
		[Bench]
		public void DeserializeBytesArray()
		{
			BinarySerializer ser = new BinarySerializer ();
			var arr = new ByteArray64K(){Arr = DataFiller.FillByteArray (65536)};
			byte[] data;

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize (ms, arr);
				data = ms.ToArray ();
			}

			var b = Benchmark.StartNew ();

			for (int i = 0; i < nIter; i++) {
					ByteArray64K des=ser.Deserialize<ByteArray64K>(data);
			}

			b.Stop ();

			//Verification
			ByteArray64K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<ByteArray64K>(ms);
			}

			ByteArray64K.Compare (arr, des1);

		}
	}
}

