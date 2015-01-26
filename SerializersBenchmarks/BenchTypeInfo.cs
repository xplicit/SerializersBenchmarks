using System;

namespace SerializersBenchmarks
{
	public class BenchTypeInfo
	{
		private int iterDeserialize;

		public Type Type { get; set; }

		public string Name { get { return Type.Name; } }

		public int Iterations { get; set; }

		public int IterationsDeserialize { 
			get { return iterDeserialize > 0 ? iterDeserialize : Iterations; } 
			set { iterDeserialize = value; }
		}

		public BenchTypeInfo(Type type, int iter) : this (type, iter, 0) {}

		public BenchTypeInfo(Type type, int iter, int iterDeserialize)
		{
			Type = type;
			Iterations = iter;
			this.iterDeserialize = iterDeserialize;
		}
	}
}

