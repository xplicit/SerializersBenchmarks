using System;

namespace SerializersBenchmarks
{
	public class BenchTypeInfo
	{
		public string Name { get; set; }

		public int Iterations { get; set; }

		public BenchTypeInfo(string name, int iter)
		{
			Name = name;
			Iterations = iter;
		}
	}
}

