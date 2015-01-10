using System;

namespace SerializersBenchmarks
{
	public class BenchTypeInfo
	{
		public Type Type { get; set; }

		public string Name { get { return Type.Name; } }

		public int Iterations { get; set; }

		public BenchTypeInfo(Type type, int iter)
		{
			Type = type;
			Iterations = iter;
		}
	}
}

