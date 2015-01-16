using System;
using System.Collections.Generic;
using System.Linq;

#if __PROTO_
using ProtoBuf;
#endif
#if __BINARY_SERIALIZER_
using BinarySerialization;
#endif

#if __PROTO_ || __NEED_SERIALIZABLE_ATTR_ || __BINARY_SERIALIZER_ || __BOND_
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
	#if __BOND_
	[global::Bond.Schema]
	#endif
	public class IntList4K
	{
		#if __PROTO_
		[ProtoMember(1)]
		#endif
		#if __BINARY_SERIALIZER_
		[FieldCount(4096)]
		#endif
		#if __BOND_
		[global::Bond.Id(0)]
		#endif
		public List<int> Arr { get; set; }

		public static bool Compare(IntList4K arr1, IntList4K arr2)
		{
			if (arr1 == null || arr1.Arr == null)
				throw new ArgumentNullException ("arr1");

			if (arr2 == null || arr2.Arr == null)
				throw new ArgumentNullException ("arr2");

			if (arr1.Arr.Count != arr2.Arr.Count)
				throw new ArgumentException (
					String.Format("List are not equal in size arr1 size={0}, arr2 size={1}", arr1.Arr.Count, arr2.Arr.Count)
				);

			if (!Enumerable.SequenceEqual (arr1.Arr, arr2.Arr))
				throw new ArgumentException ("Lists are not equal");

			return true;
		}

		public static IntList4K Create()
		{
			return new IntList4K (){Arr=DataFiller.FillIntArray(4096).ToList()};
		}
	}
}

