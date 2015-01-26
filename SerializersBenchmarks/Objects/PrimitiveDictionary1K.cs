using System;
using System.Collections.Generic;
using System.Linq;

#if __PROTO_
using ProtoBuf;
#endif
#if __BINARY_SERIALIZER_
using BinarySerialization;
#endif
#if __AVRO_
using System.Runtime.Serialization;
#endif

#if __PROTO_ || __NEED_SERIALIZABLE_ATTR_ || __BINARY_SERIALIZER_ || __BOND_ || __AVRO_
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
	#if __AVRO_
	[DataContract]
	#endif
	public class PrimitiveDictionary1K
	{
		#if __PROTO_
		[ProtoMember(1)]
		#endif
		#if __BINARY_SERIALIZER_
//		[FieldCount(4096)]
		#endif
		#if __BOND_
		[global::Bond.Id(0)]
		#endif
		#if __AVRO_
		[DataMember]
		#endif
		public Dictionary<int,PrimitiveType> Dict { get; set; }

		public static bool Compare(PrimitiveDictionary1K dict1, PrimitiveDictionary1K dict2)
		{
			if (dict1 == null || dict1.Dict == null)
				throw new ArgumentNullException ("dict1");

			if (dict2 == null || dict2.Dict == null)
				throw new ArgumentNullException ("dict2");

			if (dict1.Dict.Count != dict2.Dict.Count)
				throw new ArgumentException (
					String.Format("Dictionaries are not equal in size dict1 size={0}, dict2 size={1}", dict1.Dict.Count, dict2.Dict.Count)
				);

			foreach (var key in dict1.Dict.Keys) {
				if (!PrimitiveType.Compare(dict1.Dict [key],  dict2.Dict [key]))
					throw new ArgumentException ("Lists are not equal");
			}

			return true;
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

