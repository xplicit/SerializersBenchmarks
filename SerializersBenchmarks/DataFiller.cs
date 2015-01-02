using System;

namespace SerializersBenchmarks
{
	public class DataFiller
	{
		public static byte[] FillByteArray(int arraySize)
		{
			Random rnd = new Random (100);
			byte[] arr = new byte[arraySize]; 
			rnd.NextBytes (arr);

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
	}
}

