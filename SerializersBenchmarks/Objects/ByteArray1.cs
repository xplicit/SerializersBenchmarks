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
	public class ByteArray1
	{
		#if __PROTO_
		[ProtoMember(1)]
		#endif
		#if __BINARY_SERIALIZER_
		[FieldLength(65536)]
		#endif
		public byte[] Arr { get; set; }
	}
}

