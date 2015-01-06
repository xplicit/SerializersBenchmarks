﻿using System;
using System.Linq;


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
	public class ShortArray64K
	{
		#if __PROTO_
		[ProtoMember(1)]
		#endif
		#if __BINARY_SERIALIZER_
		[FieldCount(65536)]
		#endif
		public short[] Arr { get; set; }

		public static bool Compare(ShortArray64K arr1, ShortArray64K arr2)
		{
			if (arr1 == null || arr1.Arr == null)
				throw new ArgumentNullException ("arr1");

			if (arr2 == null || arr2.Arr == null)
				throw new ArgumentNullException ("arr2");

			if (arr1.Arr.Length != arr2.Arr.Length)
				throw new ArgumentException (
					String.Format("Array are not equal in size arr1 size={0}, arr2 size={1}", arr1.Arr.Length, arr2.Arr.Length)
				);

			if (!Enumerable.SequenceEqual (arr1.Arr, arr2.Arr))
				throw new ArgumentException ("Arrays are not equal");

			return true;
		}

		public static ShortArray64K Create()
		{
			return new ShortArray64K (){Arr=DataFiller.FillShortArray(65536)};
		}

	}
}

