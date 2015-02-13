using System;
using BinarySerializerBench;
using BinarySerialization;
using System.IO;
using System.Linq;
using Salar.Bois;
using System.Collections.Generic;

namespace ConsoleTest
{

	public class IntArray64K
	{
		[FieldLength(65536*sizeof(int))]
		public int[] Arr { get; set; }
	}

	[Serializable]
	public class ByteArray64K
	{
		public byte[] Arr { get; set; }
	}

	[Serializable]
	public class PrimitiveDictionary1K
	{
		public Dictionary<int,PrimitiveType> Dict  { get; set; }
	}

	[Serializable]
	public class PrimitiveType
	{
		public bool BoolVar { get; set; }

		public byte ByteVar { get; set; }

		public short ShortVart { get; set; }

		public int IntVar { get; set; }

		public long LongVar { get; set; }

		public char CharVar { get; set; }

		public float FloatVar { get; set; }

		public double DoubleVar { get; set; }

		public static PrimitiveType Create()
		{
			return new PrimitiveType ()
			{
				BoolVar=true,
				ByteVar=55,
				ShortVart=23867,
				IntVar=452371213,
				LongVar=0x55AACCEE3377DDFE,
				CharVar='C',
				FloatVar=12342134.44123f,
				DoubleVar=5123423411.3412341234
			};
		}

		public static bool Compare(PrimitiveType var1, PrimitiveType var2)
		{
			return var1.BoolVar == var2.BoolVar
				&& var1.ByteVar == var2.ByteVar
				&& var1.CharVar == var2.CharVar
				&& var1.DoubleVar == var2.DoubleVar
				&& var1.FloatVar == var2.FloatVar
				&& var1.IntVar == var2.IntVar
				&& var1.LongVar == var2.LongVar
				&& var1.ShortVart == var2.ShortVart;
		}

	}


	class MainClass
	{
		public static void Main (string[] args)
		{
			var ser = new BoisSerializer ();
			byte[] data;

			var dict = Create ();

			using (MemoryStream ms = new MemoryStream ()) {
				ser.Serialize (dict, ms);
				data = ms.ToArray ();
			}

			PrimitiveDictionary1K des1;

			using (MemoryStream ms = new MemoryStream (data)) {
				des1=ser.Deserialize<PrimitiveDictionary1K>(ms);
			}

			Console.WriteLine ("length1={0}, length2={1}", dict.Dict.Count, dict.Dict.Count);
		}

		public static PrimitiveDictionary1K Create()
		{
			Random rnd = new Random (100);
			PrimitiveDictionary1K dict = new PrimitiveDictionary1K(){Dict=new Dictionary<int, PrimitiveType> ()};

			for (int i = 0; i < 1024; i++) {
				int key;

				do {
					key = rnd.Next ();
				} while (dict.Dict.ContainsKey (key));

				dict.Dict.Add (key, new PrimitiveType () {
					BoolVar = rnd.Next () % 2 == 0,
					ByteVar = (byte)(rnd.Next () % 256),
					CharVar = (char)(rnd.Next () % 65536),
					DoubleVar = rnd.NextDouble (),
					FloatVar = (float)rnd.NextDouble (),
					IntVar = rnd.Next (),
					LongVar = (long)rnd.Next () * (long)rnd.Next (),
					ShortVart = (short)(rnd.Next () % 65536)
				});
			}
			return dict;
		}

	}
}
