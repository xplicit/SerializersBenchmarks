using System;
using System.Linq;

namespace SerializersBenchmarks
{
	public class DataFiller
	{
		public static byte[] FillByteArray(int arraySize)
		{
			return FillByteArray(arraySize, 100);
		}

		public static byte[] FillByteArray(int arraySize, int seed)
		{
			Random rnd = new Random (seed);
			byte[] arr = new byte[arraySize]; 
			rnd.NextBytes (arr);

			return arr;
		}


		public static short[] FillShortArray(int arraySize)
		{
			Random rnd = new Random (100);
			short[] arr = new short[arraySize]; 

			for(int i=0;i<arraySize;i++)
				arr[i] = (short)(rnd.Next()%65536);

			return arr;
		}

		public static int[] FillIntArray(int arraySize)
		{
			Random rnd = new Random (100);
			int[] arr = new int[arraySize]; 

			for(int i=0;i<arraySize;i++)
				arr[i] = rnd.Next();

			return arr;
		}

		public static long[] FillLongArray(int arraySize)
		{
			Random rnd = new Random (100);
			long[] arr = new long[arraySize]; 

			for(int i=0;i<arraySize;i++)
				arr[i] = (long)rnd.Next() + ((long)rnd.Next())<<32;

			return arr;
		}

	}
}

