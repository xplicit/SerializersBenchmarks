using System;

namespace SerializersBenchmarks.Objects.Custom
{

	public static class BondTypeAliasConverter
	{
		public static byte[] Convert(ArraySegment<byte> value, byte[] unused)
		{
			var arr = new byte[value.Count];
			Buffer.BlockCopy(value.Array, value.Offset, arr, 0, value.Count);
			return arr;
		}

		public static ArraySegment<byte> Convert(byte[] value, ArraySegment<byte> unused)
		{
			return new ArraySegment<byte>(value);
		}
	}
}

