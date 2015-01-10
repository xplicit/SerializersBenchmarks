using System;

#if __PROTO_
using ProtoBuf;
#endif
#if __BINARY_SERIALIZER_
using BinarySerialization;
#endif

#if __PROTO_ || __NEED_SERIALIZABLE_ATTR_ || __BINARY_SERIALIZER_
namespace SerializersBenchmarks.Objects.Custom
#else
namespace SerializersBenchmarks.Objects
#endif
{
	#if __PROTO_ 
	[ProtoContract] 
	#endif
	#if __NEED_SERIALIZABLE_ATTR_
	[Serializable]
	#endif	
	public class PrimitiveType
	{
		#if __PROTO_
		[ProtoMember(1)]
		#endif
		public bool BoolVar { get; set; }

		#if __PROTO_
		[ProtoMember(2)]
		#endif
		public byte ByteVar { get; set; }

		#if __PROTO_
		[ProtoMember(3)]
		#endif
		public short ShortVart { get; set; }

		#if __PROTO_
		[ProtoMember(4)]
		#endif
		public int IntVar { get; set; }

		#if __PROTO_
		[ProtoMember(5)]
		#endif
		public long LongVar { get; set; }

		#if __PROTO_
		[ProtoMember(6)]
		#endif
		public char CharVar { get; set; }

		#if __PROTO_
		[ProtoMember(7)]
		#endif
		public float FloatVar { get; set; }

		#if __PROTO_
		[ProtoMember(8)]
		#endif
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
}

