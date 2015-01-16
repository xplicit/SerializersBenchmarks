using System;
using System.Linq;

namespace BondBench.Schemas
{
	public partial class ByteArray64K
	{

		public static bool Compare(ByteArray64K arr1, ByteArray64K arr2)
		{
			if (arr1 == null || arr1.Arr == null)
				throw new ArgumentNullException ("arr1");

			if (arr2 == null || arr2.Arr == null)
				throw new ArgumentNullException ("arr2");

			if (arr1.Arr.Count != arr2.Arr.Count)
				throw new ArgumentException (
					String.Format("Array are not equal in size arr1 size={0}, arr2 size={1}", arr1.Arr.Array.Length, arr2.Arr.Array.Length)
				);

			if (!Enumerable.SequenceEqual (arr1.Arr, arr2.Arr))
				throw new ArgumentException ("Arrays are not equal");

			return true;
		}

		public static ByteArray64K Create()
		{
			var b = new ByteArray64K ();
			b.Arr = new ArraySegment<byte>(SerializersBenchmarks.DataFiller.FillByteArray(65536));

			return b;
		}

	}
}

