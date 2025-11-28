// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum BinaryHeaderEnum // TypeDefIndex: 1013
{
	// Fields
	public int value__; // 0x0
	public const BinaryHeaderEnum SerializedStreamHeader = 0;
	public const BinaryHeaderEnum Object = 1;
	public const BinaryHeaderEnum ObjectWithMap = 2;
	public const BinaryHeaderEnum ObjectWithMapAssemId = 3;
	public const BinaryHeaderEnum ObjectWithMapTyped = 4;
	public const BinaryHeaderEnum ObjectWithMapTypedAssemId = 5;
	public const BinaryHeaderEnum ObjectString = 6;
	public const BinaryHeaderEnum Array = 7;
	public const BinaryHeaderEnum MemberPrimitiveTyped = 8;
	public const BinaryHeaderEnum MemberReference = 9;
	public const BinaryHeaderEnum ObjectNull = 10;
	public const BinaryHeaderEnum MessageEnd = 11;
	public const BinaryHeaderEnum Assembly = 12;
	public const BinaryHeaderEnum ObjectNullMultiple256 = 13;
	public const BinaryHeaderEnum ObjectNullMultiple = 14;
	public const BinaryHeaderEnum ArraySinglePrimitive = 15;
	public const BinaryHeaderEnum ArraySingleObject = 16;
	public const BinaryHeaderEnum ArraySingleString = 17;
	public const BinaryHeaderEnum CrossAppDomainMap = 18;
	public const BinaryHeaderEnum CrossAppDomainString = 19;
	public const BinaryHeaderEnum CrossAppDomainAssembly = 20;
	public const BinaryHeaderEnum MethodCall = 21;
	public const BinaryHeaderEnum MethodReturn = 22;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum BinaryTypeEnum // TypeDefIndex: 1014
{
	// Fields
	public int value__; // 0x0
	public const BinaryTypeEnum Primitive = 0;
	public const BinaryTypeEnum String = 1;
	public const BinaryTypeEnum Object = 2;
	public const BinaryTypeEnum ObjectUrt = 3;
	public const BinaryTypeEnum ObjectUser = 4;
	public const BinaryTypeEnum ObjectArray = 5;
	public const BinaryTypeEnum StringArray = 6;
	public const BinaryTypeEnum PrimitiveArray = 7;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum BinaryArrayTypeEnum // TypeDefIndex: 1015
{
	// Fields
	public int value__; // 0x0
	public const BinaryArrayTypeEnum Single = 0;
	public const BinaryArrayTypeEnum Jagged = 1;
	public const BinaryArrayTypeEnum Rectangular = 2;
	public const BinaryArrayTypeEnum SingleOffset = 3;
	public const BinaryArrayTypeEnum JaggedOffset = 4;
	public const BinaryArrayTypeEnum RectangularOffset = 5;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalSerializerTypeE // TypeDefIndex: 1016
{
	// Fields
	public int value__; // 0x0
	public const InternalSerializerTypeE Soap = 1;
	public const InternalSerializerTypeE Binary = 2;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalParseTypeE // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const InternalParseTypeE Empty = 0;
	public const InternalParseTypeE SerializedStreamHeader = 1;
	public const InternalParseTypeE Object = 2;
	public const InternalParseTypeE Member = 3;
	public const InternalParseTypeE ObjectEnd = 4;
	public const InternalParseTypeE MemberEnd = 5;
	public const InternalParseTypeE Headers = 6;
	public const InternalParseTypeE HeadersEnd = 7;
	public const InternalParseTypeE SerializedStreamHeaderEnd = 8;
	public const InternalParseTypeE Envelope = 9;
	public const InternalParseTypeE EnvelopeEnd = 10;
	public const InternalParseTypeE Body = 11;
	public const InternalParseTypeE BodyEnd = 12;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalObjectTypeE // TypeDefIndex: 1018
{
	// Fields
	public int value__; // 0x0
	public const InternalObjectTypeE Empty = 0;
	public const InternalObjectTypeE Object = 1;
	public const InternalObjectTypeE Array = 2;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalObjectPositionE // TypeDefIndex: 1019
{
	// Fields
	public int value__; // 0x0
	public const InternalObjectPositionE Empty = 0;
	public const InternalObjectPositionE Top = 1;
	public const InternalObjectPositionE Child = 2;
	public const InternalObjectPositionE Headers = 3;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalArrayTypeE // TypeDefIndex: 1020
{
	// Fields
	public int value__; // 0x0
	public const InternalArrayTypeE Empty = 0;
	public const InternalArrayTypeE Single = 1;
	public const InternalArrayTypeE Jagged = 2;
	public const InternalArrayTypeE Rectangular = 3;
	public const InternalArrayTypeE Base64 = 4;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalMemberTypeE // TypeDefIndex: 1021
{
	// Fields
	public int value__; // 0x0
	public const InternalMemberTypeE Empty = 0;
	public const InternalMemberTypeE Header = 1;
	public const InternalMemberTypeE Field = 2;
	public const InternalMemberTypeE Item = 3;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalMemberValueE // TypeDefIndex: 1022
{
	// Fields
	public int value__; // 0x0
	public const InternalMemberValueE Empty = 0;
	public const InternalMemberValueE InlineValue = 1;
	public const InternalMemberValueE Nested = 2;
	public const InternalMemberValueE Reference = 3;
	public const InternalMemberValueE Null = 4;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalPrimitiveTypeE // TypeDefIndex: 1023
{
	// Fields
	public int value__; // 0x0
	public const InternalPrimitiveTypeE Invalid = 0;
	public const InternalPrimitiveTypeE Boolean = 1;
	public const InternalPrimitiveTypeE Byte = 2;
	public const InternalPrimitiveTypeE Char = 3;
	public const InternalPrimitiveTypeE Currency = 4;
	public const InternalPrimitiveTypeE Decimal = 5;
	public const InternalPrimitiveTypeE Double = 6;
	public const InternalPrimitiveTypeE Int16 = 7;
	public const InternalPrimitiveTypeE Int32 = 8;
	public const InternalPrimitiveTypeE Int64 = 9;
	public const InternalPrimitiveTypeE SByte = 10;
	public const InternalPrimitiveTypeE Single = 11;
	public const InternalPrimitiveTypeE TimeSpan = 12;
	public const InternalPrimitiveTypeE DateTime = 13;
	public const InternalPrimitiveTypeE UInt16 = 14;
	public const InternalPrimitiveTypeE UInt32 = 15;
	public const InternalPrimitiveTypeE UInt64 = 16;
	public const InternalPrimitiveTypeE Null = 17;
	public const InternalPrimitiveTypeE String = 18;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum ValueFixupEnum // TypeDefIndex: 1024
{
	// Fields
	public int value__; // 0x0
	public const ValueFixupEnum Empty = 0;
	public const ValueFixupEnum Array = 1;
	public const ValueFixupEnum Header = 2;
	public const ValueFixupEnum Member = 3;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal static class BinaryConverter // TypeDefIndex: 1025
{
	// Methods

	// RVA: 0x13F83D0 Offset: 0x13F69D0 VA: 0x1813F83D0
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	// RVA: 0x13F8750 Offset: 0x13F6D50 VA: 0x1813F8750
	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	// RVA: 0x13F9170 Offset: 0x13F7770 VA: 0x1813F9170
	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

	// RVA: 0x13F89C0 Offset: 0x13F6FC0 VA: 0x1813F89C0
	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	// RVA: 0x13F8B90 Offset: 0x13F7190 VA: 0x1813F8B90
	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal static class IOUtil // TypeDefIndex: 1026
{
	// Methods

	// RVA: 0x13FE2D0 Offset: 0x13FC8D0 VA: 0x1813FE2D0
	internal static bool FlagTest(MessageEnum flag, MessageEnum target) { }

	// RVA: 0x13FE2E0 Offset: 0x13FC8E0 VA: 0x1813FE2E0
	internal static void WriteStringWithCode(string value, __BinaryWriter sout) { }

	// RVA: 0x13FE370 Offset: 0x13FC970 VA: 0x1813FE370
	internal static void WriteWithCode(Type type, object value, __BinaryWriter sout) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryAssemblyInfo // TypeDefIndex: 1027
{
	// Fields
	internal string assemblyString; // 0x10
	private Assembly assembly; // 0x18

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	internal void .ctor(string assemblyString) { }

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	internal void .ctor(string assemblyString, Assembly assembly) { }

	// RVA: 0x13F81B0 Offset: 0x13F67B0 VA: 0x1813F81B0
	internal Assembly GetAssembly() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerializationHeaderRecord // TypeDefIndex: 1028
{
	// Fields
	internal int binaryFormatterMajorVersion; // 0x10
	internal int binaryFormatterMinorVersion; // 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x18
	internal int topId; // 0x1C
	internal int headerId; // 0x20
	internal int majorVersion; // 0x24
	internal int minorVersion; // 0x28

	// Methods

	// RVA: 0x140BB40 Offset: 0x140A140 VA: 0x18140BB40
	internal void .ctor() { }

	// RVA: 0x140BB50 Offset: 0x140A150 VA: 0x18140BB50
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x140BA70 Offset: 0x140A070 VA: 0x18140BA70 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x140B7C0 Offset: 0x1409DC0 VA: 0x18140B7C0
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x140B830 Offset: 0x1409E30 VA: 0x18140B830 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryAssembly // TypeDefIndex: 1029
{
	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13F8330 Offset: 0x13F6930 VA: 0x1813F8330
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x13F8350 Offset: 0x13F6950 VA: 0x1813F8350 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x13F82E0 Offset: 0x13F68E0 VA: 0x1813F82E0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryCrossAppDomainAssembly // TypeDefIndex: 1030
{
	// Fields
	internal int assemId; // 0x10
	internal int assemblyIndex; // 0x14

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13F93E0 Offset: 0x13F79E0 VA: 0x1813F93E0 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObject // TypeDefIndex: 1031
{
	// Fields
	internal int objectId; // 0x10
	internal int mapId; // 0x14

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13FB0D0 Offset: 0x13F96D0 VA: 0x1813FB0D0
	internal void Set(int objectId, int mapId) { }

	// RVA: 0x13FB0E0 Offset: 0x13F96E0 VA: 0x1813FB0E0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x13F93E0 Offset: 0x13F79E0 VA: 0x1813F93E0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryMethodCall // TypeDefIndex: 1032
{
	// Fields
	private string methodName; // 0x10
	private string typeName; // 0x18
	private object[] args; // 0x20
	private object callContext; // 0x28
	private Type[] argTypes; // 0x30
	private bool bArgsPrimitive; // 0x38
	private MessageEnum messageEnum; // 0x3C

	// Methods

	// RVA: 0x13F9F50 Offset: 0x13F8550 VA: 0x1813F9F50
	internal void Write(__BinaryWriter sout) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void Dump() { }

	// RVA: 0x13FA310 Offset: 0x13F8910 VA: 0x1813FA310
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryMethodReturn // TypeDefIndex: 1033
{
	// Fields
	private object returnValue; // 0x10
	private object[] args; // 0x18
	private object callContext; // 0x20
	private Type[] argTypes; // 0x28
	private bool bArgsPrimitive; // 0x30
	private MessageEnum messageEnum; // 0x34
	private Type returnType; // 0x38
	private static object instanceOfVoid; // 0x0

	// Methods

	// RVA: 0x13FA750 Offset: 0x13F8D50 VA: 0x1813FA750
	private static void .cctor() { }

	// RVA: 0x13FA810 Offset: 0x13F8E10 VA: 0x1813FA810
	internal void .ctor() { }

	// RVA: 0x13FA320 Offset: 0x13F8920 VA: 0x1813FA320 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectString // TypeDefIndex: 1034
{
	// Fields
	internal int objectId; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13F8330 Offset: 0x13F6930 VA: 0x1813F8330
	internal void Set(int objectId, string value) { }

	// RVA: 0x13FA820 Offset: 0x13F8E20 VA: 0x1813FA820 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x13F82E0 Offset: 0x13F68E0 VA: 0x1813F82E0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryCrossAppDomainString // TypeDefIndex: 1035
{
	// Fields
	internal int objectId; // 0x10
	internal int value; // 0x14

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13F93E0 Offset: 0x13F79E0 VA: 0x1813F93E0 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryCrossAppDomainMap // TypeDefIndex: 1036
{
	// Fields
	internal int crossAppDomainArrayIndex; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13F9420 Offset: 0x13F7A20 VA: 0x1813F9420 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberPrimitiveTyped // TypeDefIndex: 1037
{
	// Fields
	internal InternalPrimitiveTypeE primitiveTypeEnum; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13F8330 Offset: 0x13F6930 VA: 0x1813F8330
	internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value) { }

	// RVA: 0x13FE880 Offset: 0x13FCE80 VA: 0x1813FE880 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x13FE830 Offset: 0x13FCE30 VA: 0x1813FE830 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectWithMap // TypeDefIndex: 1038
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal int assemId; // 0x30

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x3757E0 Offset: 0x373DE0 VA: 0x1803757E0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x13FAF50 Offset: 0x13F9550 VA: 0x1813FAF50
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x13FAFB0 Offset: 0x13F95B0 VA: 0x1813FAFB0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x13FAE40 Offset: 0x13F9440 VA: 0x1813FAE40 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectWithMapTyped // TypeDefIndex: 1039
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x30
	internal object[] typeInformationA; // 0x38
	internal int[] memberAssemIds; // 0x40
	internal int assemId; // 0x48

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x3757E0 Offset: 0x373DE0 VA: 0x1803757E0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x13FABA0 Offset: 0x13F91A0 VA: 0x1813FABA0
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x13FAC40 Offset: 0x13F9240 VA: 0x1813FAC40 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x13FA8A0 Offset: 0x13F8EA0 VA: 0x1813FA8A0 Slot: 5
	public void Read(__BinaryParser input) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryArray // TypeDefIndex: 1040
{
	// Fields
	internal int objectId; // 0x10
	internal int rank; // 0x14
	internal int[] lengthA; // 0x18
	internal int[] lowerBoundA; // 0x20
	internal BinaryTypeEnum binaryTypeEnum; // 0x28
	internal object typeInformation; // 0x30
	internal int assemId; // 0x38
	private BinaryHeaderEnum binaryHeaderEnum; // 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; // 0x40

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13F8180 Offset: 0x13F6780 VA: 0x1813F8180
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x13F7D80 Offset: 0x13F6380 VA: 0x1813F7D80
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x13F7E40 Offset: 0x13F6440 VA: 0x1813F7E40 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x13F7850 Offset: 0x13F5E50 VA: 0x1813F7850 Slot: 5
	public void Read(__BinaryParser input) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberPrimitiveUnTyped // TypeDefIndex: 1041
{
	// Fields
	internal InternalPrimitiveTypeE typeInformation; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13F8330 Offset: 0x13F6930 VA: 0x1813F8330
	internal void Set(InternalPrimitiveTypeE typeInformation, object value) { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	internal void Set(InternalPrimitiveTypeE typeInformation) { }

	// RVA: 0x13FE930 Offset: 0x13FCF30 VA: 0x1813FE930 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x13FE8F0 Offset: 0x13FCEF0 VA: 0x1813FE8F0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberReference // TypeDefIndex: 1042
{
	// Fields
	internal int idRef; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	internal void Set(int idRef) { }

	// RVA: 0x13FE960 Offset: 0x13FCF60 VA: 0x1813FE960 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x13F9420 Offset: 0x13F7A20 VA: 0x1813F9420 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectNull // TypeDefIndex: 1043
{
	// Fields
	internal int nullCount; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	internal void SetNullCount(int nullCount) { }

	// RVA: 0x13FF920 Offset: 0x13FDF20 VA: 0x1813FF920 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x13FF8B0 Offset: 0x13FDEB0 VA: 0x1813FF8B0
	public void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MessageEnd // TypeDefIndex: 1044
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x13FE9C0 Offset: 0x13FCFC0 VA: 0x1813FE9C0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void Dump(Stream sout) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectMap // TypeDefIndex: 1045
{
	// Fields
	internal string objectName; // 0x10
	internal Type objectType; // 0x18
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x20
	internal object[] typeInformationA; // 0x28
	internal Type[] memberTypes; // 0x30
	internal string[] memberNames; // 0x38
	internal ReadObjectInfo objectInfo; // 0x40
	internal bool isInitObjectInfo; // 0x48
	internal ObjectReader objectReader; // 0x50
	internal int objectId; // 0x58
	internal BinaryAssemblyInfo assemblyInfo; // 0x60

	// Methods

	// RVA: 0x13FF620 Offset: 0x13FDC20 VA: 0x1813FF620
	internal void .ctor(string objectName, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x13FF130 Offset: 0x13FD730 VA: 0x1813FF130
	internal void .ctor(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	// RVA: 0x13FEF70 Offset: 0x13FD570 VA: 0x1813FEF70
	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x13FEFC0 Offset: 0x13FD5C0 VA: 0x1813FEFC0
	internal static ObjectMap Create(string name, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x13FF060 Offset: 0x13FD660 VA: 0x1813FF060
	internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectProgress // TypeDefIndex: 1046
{
	// Fields
	internal static int opRecordIdCount; // 0x0
	internal bool isInitial; // 0x10
	internal int count; // 0x14
	internal BinaryTypeEnum expectedType; // 0x18
	internal object expectedTypeInformation; // 0x20
	internal string name; // 0x28
	internal InternalObjectTypeE objectTypeEnum; // 0x30
	internal InternalMemberTypeE memberTypeEnum; // 0x34
	internal InternalMemberValueE memberValueEnum; // 0x38
	internal Type dtType; // 0x40
	internal int numItems; // 0x48
	internal BinaryTypeEnum binaryTypeEnum; // 0x4C
	internal object typeInformation; // 0x50
	internal int nullCount; // 0x58
	internal int memberLength; // 0x5C
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x60
	internal object[] typeInformationA; // 0x68
	internal string[] memberNames; // 0x70
	internal Type[] memberTypes; // 0x78
	internal ParseRecord pr; // 0x80

	// Methods

	// RVA: 0x13FFC90 Offset: 0x13FE290 VA: 0x1813FFC90
	internal void .ctor() { }

	// RVA: 0x13FFB80 Offset: 0x13FE180 VA: 0x1813FFB80
	internal void Init() { }

	// RVA: 0x13FFA10 Offset: 0x13FE010 VA: 0x1813FFA10
	internal void ArrayCountIncrement(int value) { }

	// RVA: 0x13FFA20 Offset: 0x13FE020 VA: 0x1813FFA20
	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	// RVA: 0x13FFC50 Offset: 0x13FE250 VA: 0x1813FFC50
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class Converter // TypeDefIndex: 1047
{
	// Fields
	private static int primitiveTypeEnumLength; // 0x0
	private static Type[] typeA; // 0x8
	private static Type[] arrayTypeA; // 0x10
	private static string[] valueA; // 0x18
	private static TypeCode[] typeCodeA; // 0x20
	private static InternalPrimitiveTypeE[] codeA; // 0x28
	internal static Type typeofISerializable; // 0x30
	internal static Type typeofString; // 0x38
	internal static Type typeofConverter; // 0x40
	internal static Type typeofBoolean; // 0x48
	internal static Type typeofByte; // 0x50
	internal static Type typeofChar; // 0x58
	internal static Type typeofDecimal; // 0x60
	internal static Type typeofDouble; // 0x68
	internal static Type typeofInt16; // 0x70
	internal static Type typeofInt32; // 0x78
	internal static Type typeofInt64; // 0x80
	internal static Type typeofSByte; // 0x88
	internal static Type typeofSingle; // 0x90
	internal static Type typeofTimeSpan; // 0x98
	internal static Type typeofDateTime; // 0xA0
	internal static Type typeofUInt16; // 0xA8
	internal static Type typeofUInt32; // 0xB0
	internal static Type typeofUInt64; // 0xB8
	internal static Type typeofObject; // 0xC0
	internal static Type typeofSystemVoid; // 0xC8
	internal static Assembly urtAssembly; // 0xD0
	internal static string urtAssemblyString; // 0xD8
	internal static Type typeofTypeArray; // 0xE0
	internal static Type typeofObjectArray; // 0xE8
	internal static Type typeofStringArray; // 0xF0
	internal static Type typeofBooleanArray; // 0xF8
	internal static Type typeofByteArray; // 0x100
	internal static Type typeofCharArray; // 0x108
	internal static Type typeofDecimalArray; // 0x110
	internal static Type typeofDoubleArray; // 0x118
	internal static Type typeofInt16Array; // 0x120
	internal static Type typeofInt32Array; // 0x128
	internal static Type typeofInt64Array; // 0x130
	internal static Type typeofSByteArray; // 0x138
	internal static Type typeofSingleArray; // 0x140
	internal static Type typeofTimeSpanArray; // 0x148
	internal static Type typeofDateTimeArray; // 0x150
	internal static Type typeofUInt16Array; // 0x158
	internal static Type typeofUInt32Array; // 0x160
	internal static Type typeofUInt64Array; // 0x168
	internal static Type typeofMarshalByRefObject; // 0x170

	// Methods

	// RVA: 0x13FCBD0 Offset: 0x13FB1D0 VA: 0x1813FCBD0
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x13FCA90 Offset: 0x13FB090 VA: 0x1813FCA90
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	// RVA: 0x13FD390 Offset: 0x13FB990 VA: 0x1813FD390
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

	// RVA: 0x13FCB00 Offset: 0x13FB100 VA: 0x1813FCB00
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	// RVA: 0x13FBC40 Offset: 0x13FA240 VA: 0x1813FBC40
	private static void InitTypeA() { }

	// RVA: 0x13FB410 Offset: 0x13F9A10 VA: 0x1813FB410
	private static void InitArrayTypeA() { }

	// RVA: 0x13FD2C0 Offset: 0x13FB8C0 VA: 0x1813FD2C0
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	// RVA: 0x13FB160 Offset: 0x13F9760 VA: 0x1813FB160
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	// RVA: 0x13FC7A0 Offset: 0x13FADA0 VA: 0x1813FC7A0
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	// RVA: 0x13FC440 Offset: 0x13FAA40 VA: 0x1813FC440
	private static void InitValueA() { }

	// RVA: 0x13FCCF0 Offset: 0x13FB2F0 VA: 0x1813FCCF0
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	// RVA: 0x13FC290 Offset: 0x13FA890 VA: 0x1813FC290
	private static void InitTypeCodeA() { }

	// RVA: 0x13FD050 Offset: 0x13FB650 VA: 0x1813FD050
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	// RVA: 0x13FBA70 Offset: 0x13FA070 VA: 0x1813FBA70
	private static void InitCodeA() { }

	// RVA: 0x13FCDC0 Offset: 0x13FB3C0 VA: 0x1813FCDC0
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	// RVA: 0x13FB340 Offset: 0x13F9940 VA: 0x1813FB340
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	// RVA: 0x13FD410 Offset: 0x13FBA10 VA: 0x1813FD410
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[ComVisible(True)]
public sealed class BinaryFormatter // TypeDefIndex: 1048
{
	// Fields
	internal ISurrogateSelector m_surrogates; // 0x10
	internal StreamingContext m_context; // 0x18
	internal SerializationBinder m_binder; // 0x28
	internal FormatterTypeStyle m_typeFormat; // 0x30
	internal FormatterAssemblyStyle m_assemblyFormat; // 0x34
	internal TypeFilterLevel m_securityLevel; // 0x38
	internal object[] m_crossAppDomainArray; // 0x40
	private static Dictionary<Type, TypeInformation> typeNameCache; // 0x0

	// Properties
	public FormatterAssemblyStyle AssemblyFormat { set; }
	public ISurrogateSelector SurrogateSelector { set; }

	// Methods

	// RVA: 0x10051F0 Offset: 0x10037F0 VA: 0x1810051F0
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590 Slot: 4
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x13F9E80 Offset: 0x13F8480 VA: 0x1813F9E80
	public void .ctor() { }

	// RVA: 0x13F9EF0 Offset: 0x13F84F0 VA: 0x1813F9EF0
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x13F97A0 Offset: 0x13F7DA0 VA: 0x1813F97A0 Slot: 5
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x13F9450 Offset: 0x13F7A50 VA: 0x1813F9450
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x13F9780 Offset: 0x13F7D80 VA: 0x1813F9780 Slot: 6
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x13F9DD0 Offset: 0x13F83D0 VA: 0x1813F9DD0 Slot: 7
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x13F9A30 Offset: 0x13F8030 VA: 0x1813F9A30 Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x13F9A50 Offset: 0x13F8050 VA: 0x1813F9A50
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x13F97C0 Offset: 0x13F7DC0 VA: 0x1813F97C0
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x13F9DF0 Offset: 0x13F83F0 VA: 0x1813F9DF0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class __BinaryWriter // TypeDefIndex: 1049
{
	// Fields
	internal Stream sout; // 0x10
	internal FormatterTypeStyle formatterTypeStyle; // 0x18
	internal Hashtable objectMapTable; // 0x20
	internal ObjectWriter objectWriter; // 0x28
	internal BinaryWriter dataWriter; // 0x30
	internal int m_nestedObjectCount; // 0x38
	private int nullCount; // 0x3C
	internal BinaryMethodCall binaryMethodCall; // 0x40
	internal BinaryMethodReturn binaryMethodReturn; // 0x48
	internal BinaryObject binaryObject; // 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; // 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
	internal BinaryObjectString binaryObjectString; // 0x68
	internal BinaryArray binaryArray; // 0x70
	private byte[] byteBuffer; // 0x78
	private int chunkSize; // 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
	internal ObjectNull objectNull; // 0x98
	internal MemberReference memberReference; // 0xA0
	internal BinaryAssembly binaryAssembly; // 0xA8

	// Methods

	// RVA: 0x1412EF0 Offset: 0x14114F0 VA: 0x181412EF0
	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void WriteBegin() { }

	// RVA: 0x1410A50 Offset: 0x140F050 VA: 0x181410A50
	internal void WriteEnd() { }

	// RVA: 0x14107C0 Offset: 0x140EDC0 VA: 0x1814107C0
	internal void WriteBoolean(bool value) { }

	// RVA: 0x14107F0 Offset: 0x140EDF0 VA: 0x1814107F0
	internal void WriteByte(byte value) { }

	// RVA: 0x1410820 Offset: 0x140EE20 VA: 0x181410820
	private void WriteBytes(byte[] value) { }

	// RVA: 0x1410850 Offset: 0x140EE50 VA: 0x181410850
	private void WriteBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x1410880 Offset: 0x140EE80 VA: 0x181410880
	internal void WriteChar(char value) { }

	// RVA: 0x14108B0 Offset: 0x140EEB0 VA: 0x1814108B0
	internal void WriteChars(char[] value) { }

	// RVA: 0x1410950 Offset: 0x140EF50 VA: 0x181410950
	internal void WriteDecimal(Decimal value) { }

	// RVA: 0x1412500 Offset: 0x1410B00 VA: 0x181412500
	internal void WriteSingle(float value) { }

	// RVA: 0x1410A20 Offset: 0x140F020 VA: 0x181410A20
	internal void WriteDouble(double value) { }

	// RVA: 0x1410A80 Offset: 0x140F080 VA: 0x181410A80
	internal void WriteInt16(short value) { }

	// RVA: 0x1410AB0 Offset: 0x140F0B0 VA: 0x181410AB0
	internal void WriteInt32(int value) { }

	// RVA: 0x1410AE0 Offset: 0x140F0E0 VA: 0x181410AE0
	internal void WriteInt64(long value) { }

	// RVA: 0x14107F0 Offset: 0x140EDF0 VA: 0x1814107F0
	internal void WriteSByte(sbyte value) { }

	// RVA: 0x1412530 Offset: 0x1410B30 VA: 0x181412530
	internal void WriteString(string value) { }

	// RVA: 0x1412560 Offset: 0x1410B60 VA: 0x181412560
	internal void WriteTimeSpan(TimeSpan value) { }

	// RVA: 0x14108E0 Offset: 0x140EEE0 VA: 0x1814108E0
	internal void WriteDateTime(DateTime value) { }

	// RVA: 0x14125D0 Offset: 0x1410BD0 VA: 0x1814125D0
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x1412600 Offset: 0x1410C00 VA: 0x181412600
	internal void WriteUInt32(uint value) { }

	// RVA: 0x1412630 Offset: 0x1410C30 VA: 0x181412630
	internal void WriteUInt64(ulong value) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1411E20 Offset: 0x1410420 VA: 0x181411E20
	internal void WriteSerializationHeaderEnd() { }

	// RVA: 0x1411EA0 Offset: 0x14104A0 VA: 0x181411EA0
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	// RVA: 0x1411110 Offset: 0x140F710 VA: 0x181411110
	internal void WriteMethodCall() { }

	// RVA: 0x14111A0 Offset: 0x140F7A0 VA: 0x1814111A0
	internal void WriteMethodReturn() { }

	// RVA: 0x1411480 Offset: 0x140FA80 VA: 0x181411480
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x1411370 Offset: 0x140F970 VA: 0x181411370
	internal void WriteObjectString(int objectId, string value) { }

	// RVA: 0x1411FD0 Offset: 0x14105D0 VA: 0x181411FD0
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	// RVA: 0x1410510 Offset: 0x140EB10 VA: 0x181410510
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	// RVA: 0x1410BC0 Offset: 0x140F1C0 VA: 0x181410BC0
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	// RVA: 0x1411C80 Offset: 0x1410280 VA: 0x181411C80
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	// RVA: 0x1411310 Offset: 0x140F910 VA: 0x181411310
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	// RVA: 0x1410F50 Offset: 0x140F550 VA: 0x181410F50
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x1411240 Offset: 0x140F840 VA: 0x181411240
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1410DF0 Offset: 0x140F3F0 VA: 0x181410DF0
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	// RVA: 0x1410DC0 Offset: 0x140F3C0 VA: 0x181410DC0
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	// RVA: 0x1410EF0 Offset: 0x140F4F0 VA: 0x181410EF0
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	// RVA: 0x1410B60 Offset: 0x140F160 VA: 0x181410B60
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x1411230 Offset: 0x140F830 VA: 0x181411230
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x1410A10 Offset: 0x140F010 VA: 0x181410A10
	internal void WriteDelayedNullItem() { }

	// RVA: 0x1410B10 Offset: 0x140F110 VA: 0x181410B10
	internal void WriteItemEnd() { }

	// RVA: 0x1410460 Offset: 0x140EA60 VA: 0x181410460
	private void InternalWriteItemNull() { }

	// RVA: 0x1410B20 Offset: 0x140F120 VA: 0x181410B20
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	// RVA: 0x1410680 Offset: 0x140EC80 VA: 0x181410680
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	// RVA: 0x1412660 Offset: 0x1410C60 VA: 0x181412660
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectMapInfo // TypeDefIndex: 1050
{
	// Fields
	internal int objectId; // 0x10
	private int numMembers; // 0x14
	private string[] memberNames; // 0x18
	private Type[] memberTypes; // 0x20

	// Methods

	// RVA: 0x13FEDE0 Offset: 0x13FD3E0 VA: 0x1813FEDE0
	internal void .ctor(int objectId, int numMembers, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x13FEE50 Offset: 0x13FD450 VA: 0x1813FEE50
	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class WriteObjectInfo // TypeDefIndex: 1051
{
	// Fields
	internal int objectInfoId; // 0x10
	internal object obj; // 0x18
	internal Type objectType; // 0x20
	internal bool isSi; // 0x28
	internal bool isNamed; // 0x29
	internal bool isTyped; // 0x2A
	internal bool isArray; // 0x2B
	internal SerializationInfo si; // 0x30
	internal SerObjectInfoCache cache; // 0x38
	internal object[] memberData; // 0x40
	internal ISerializationSurrogate serializationSurrogate; // 0x48
	internal StreamingContext context; // 0x50
	internal SerObjectInfoInit serObjectInfoInit; // 0x60
	internal long objectId; // 0x68
	internal long assemId; // 0x70
	private string binderTypeName; // 0x78
	private string binderAssemblyString; // 0x80

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x14102B0 Offset: 0x140E8B0 VA: 0x1814102B0
	internal void ObjectEnd() { }

	// RVA: 0x14101D0 Offset: 0x140E7D0 VA: 0x1814101D0
	private void InternalInit() { }

	// RVA: 0x14103B0 Offset: 0x140E9B0 VA: 0x1814103B0
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x140F5B0 Offset: 0x140DBB0 VA: 0x18140F5B0
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x1410310 Offset: 0x140E910 VA: 0x181410310
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x140EFB0 Offset: 0x140D5B0 VA: 0x18140EFB0
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x140FE40 Offset: 0x140E440 VA: 0x18140FE40
	private void InitSiWrite() { }

	// RVA: 0x140E490 Offset: 0x140CA90 VA: 0x18140E490
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x140EE60 Offset: 0x140D460 VA: 0x18140EE60
	private void InitNoMembers() { }

	// RVA: 0x140EA90 Offset: 0x140D090 VA: 0x18140EA90
	private void InitMemberInfo() { }

	// RVA: 0x140EA60 Offset: 0x140D060 VA: 0x18140EA60
	internal string GetTypeFullName() { }

	// RVA: 0x140E610 Offset: 0x140CC10 VA: 0x18140E610
	internal string GetAssemblyString() { }

	// RVA: 0x1410270 Offset: 0x140E870 VA: 0x181410270
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x140E720 Offset: 0x140CD20 VA: 0x18140E720
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x140E640 Offset: 0x140CC40 VA: 0x18140E640
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x140E900 Offset: 0x140CF00 VA: 0x18140E900
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x14102E0 Offset: 0x140E8E0 VA: 0x1814102E0
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ReadObjectInfo // TypeDefIndex: 1052
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void ObjectEnd() { }

	// RVA: 0x140A390 Offset: 0x1408990 VA: 0x18140A390
	internal void PrepareForReuse() { }

	// RVA: 0x1408930 Offset: 0x1406F30 VA: 0x181408930
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1409FA0 Offset: 0x14085A0 VA: 0x181409FA0
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1408A60 Offset: 0x1407060 VA: 0x181408A60
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x140A060 Offset: 0x1408660 VA: 0x18140A060
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x1409CA0 Offset: 0x14082A0 VA: 0x181409CA0
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x1409F20 Offset: 0x1408520 VA: 0x181409F20
	private void InitSiRead() { }

	// RVA: 0x1409C30 Offset: 0x1408230 VA: 0x181409C30
	private void InitNoMembers() { }

	// RVA: 0x1409990 Offset: 0x1407F90 VA: 0x181409990
	private void InitMemberInfo() { }

	// RVA: 0x1408BD0 Offset: 0x14071D0 VA: 0x181408BD0
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x14096F0 Offset: 0x1407CF0 VA: 0x1814096F0
	internal Type GetType(string name) { }

	// RVA: 0x14086D0 Offset: 0x1406CD0 VA: 0x1814086D0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x1409890 Offset: 0x1407E90 VA: 0x181409890
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x140A3A0 Offset: 0x14089A0 VA: 0x18140A3A0
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x140A170 Offset: 0x1408770 VA: 0x18140A170
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x140A200 Offset: 0x1408800 VA: 0x18140A200
	private int Position(string name) { }

	// RVA: 0x1409020 Offset: 0x1407620 VA: 0x181409020
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x1408E40 Offset: 0x1407440 VA: 0x181408E40
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x1409680 Offset: 0x1407C80 VA: 0x181409680
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerObjectInfoInit // TypeDefIndex: 1053
{
	// Fields
	internal Hashtable seenBeforeTable; // 0x10
	internal int objectInfoIdCount; // 0x18
	internal SerStack oiPool; // 0x20

	// Methods

	// RVA: 0x140B2A0 Offset: 0x14098A0 VA: 0x18140B2A0
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerObjectInfoCache // TypeDefIndex: 1054
{
	// Fields
	internal string fullTypeName; // 0x10
	internal string assemblyString; // 0x18
	internal bool hasTypeForwardedFrom; // 0x20
	internal MemberInfo[] memberInfos; // 0x28
	internal string[] memberNames; // 0x30
	internal Type[] memberTypes; // 0x38

	// Methods

	// RVA: 0x3C9F30 Offset: 0x3C8530 VA: 0x1803C9F30
	internal void .ctor(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	// RVA: 0x140B200 Offset: 0x1409800 VA: 0x18140B200
	internal void .ctor(Type type) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class TypeInformation // TypeDefIndex: 1055
{
	// Fields
	private string fullTypeName; // 0x10
	private string assemblyString; // 0x18
	private bool hasTypeForwardedFrom; // 0x20

	// Properties
	internal string FullTypeName { get; }
	internal string AssemblyString { get; }
	internal bool HasTypeForwardedFrom { get; }

	// Methods

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	internal string get_FullTypeName() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal string get_AssemblyString() { }

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	internal bool get_HasTypeForwardedFrom() { }

	// RVA: 0x3C9F30 Offset: 0x3C8530 VA: 0x1803C9F30
	internal void .ctor(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectReader // TypeDefIndex: 1058
{
	// Fields
	internal Stream m_stream; // 0x10
	internal ISurrogateSelector m_surrogates; // 0x18
	internal StreamingContext m_context; // 0x20
	internal ObjectManager m_objectManager; // 0x30
	internal InternalFE formatterEnums; // 0x38
	internal SerializationBinder m_binder; // 0x40
	internal long topId; // 0x48
	internal bool bSimpleAssembly; // 0x50
	internal object handlerObject; // 0x58
	internal object m_topObject; // 0x60
	internal Header[] headers; // 0x68
	internal HeaderHandler handler; // 0x70
	internal SerObjectInfoInit serObjectInfoInit; // 0x78
	internal IFormatterConverter m_formatterConverter; // 0x80
	internal SerStack stack; // 0x88
	private SerStack valueFixupStack; // 0x90
	internal object[] crossAppDomainArray; // 0x98
	private bool bFullDeserialization; // 0xA0
	private bool bOldFormatDetected; // 0xA1
	private IntSizedArray valTypeObjectIdTable; // 0xA8
	private NameCache typeCache; // 0xB0
	private string previousAssemblyString; // 0xB8
	private string previousName; // 0xC0
	private Type previousType; // 0xC8

	// Properties
	private SerStack ValueFixupStack { get; }
	internal object TopObject { get; set; }

	// Methods

	// RVA: 0x1404050 Offset: 0x1402650 VA: 0x181404050
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal object get_TopObject() { }

	// RVA: 0x14040E0 Offset: 0x14026E0 VA: 0x1814040E0
	internal void set_TopObject(object value) { }

	// RVA: 0x1403EF0 Offset: 0x14024F0 VA: 0x181403EF0
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x1400180 Offset: 0x13FE780 VA: 0x181400180
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x1400E10 Offset: 0x13FF410 VA: 0x181400E10
	private bool HasSurrogate(Type t) { }

	// RVA: 0x13FFD70 Offset: 0x13FE370 VA: 0x1813FFD70
	private void CheckSerializable(Type t) { }

	// RVA: 0x1400F00 Offset: 0x13FF500 VA: 0x181400F00
	private void InitFullDeserialization() { }

	// RVA: 0x1400150 Offset: 0x13FE750 VA: 0x181400150
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x13FFF70 Offset: 0x13FE570 VA: 0x1813FFF70
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x13FFFC0 Offset: 0x13FE5C0 VA: 0x1813FFFC0
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x1403A60 Offset: 0x1402060 VA: 0x181403A60
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x1402720 Offset: 0x1400D20 VA: 0x181402720
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x1403940 Offset: 0x1401F40 VA: 0x181403940
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x1403910 Offset: 0x1401F10 VA: 0x181403910
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x1403550 Offset: 0x1401B50 VA: 0x181403550
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x1403140 Offset: 0x1401740 VA: 0x181403140
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x1401E20 Offset: 0x1400420 VA: 0x181401E20
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x1401040 Offset: 0x13FF640 VA: 0x181401040
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x1401160 Offset: 0x13FF760 VA: 0x181401160
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x1401130 Offset: 0x13FF730 VA: 0x181401130
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x1402A30 Offset: 0x1401030 VA: 0x181402A30
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x1402980 Offset: 0x1400F80 VA: 0x181402980
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x1403970 Offset: 0x1401F70 VA: 0x181403970
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x1403DB0 Offset: 0x14023B0 VA: 0x181403DB0
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x1403C90 Offset: 0x1402290 VA: 0x181403C90
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x1400860 Offset: 0x13FEE60 VA: 0x181400860
	internal long GetId(long objectId) { }

	// RVA: 0x13FFD10 Offset: 0x13FE310 VA: 0x1813FFD10
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x14005E0 Offset: 0x13FEBE0 VA: 0x1814005E0
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x1403E80 Offset: 0x1402480 VA: 0x181403E80
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x1400960 Offset: 0x13FEF60 VA: 0x181400960
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x1400AF0 Offset: 0x13FF0F0 VA: 0x181400AF0
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x13FFEB0 Offset: 0x13FE4B0 VA: 0x1813FFEB0
	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectWriter // TypeDefIndex: 1059
{
	// Fields
	private Queue m_objectQueue; // 0x10
	private ObjectIDGenerator m_idGenerator; // 0x18
	private int m_currentId; // 0x20
	private ISurrogateSelector m_surrogates; // 0x28
	private StreamingContext m_context; // 0x30
	private __BinaryWriter serWriter; // 0x40
	private SerializationObjectManager m_objectManager; // 0x48
	private long topId; // 0x50
	private string topName; // 0x58
	private Header[] headers; // 0x60
	private InternalFE formatterEnums; // 0x68
	private SerializationBinder m_binder; // 0x70
	private SerObjectInfoInit serObjectInfoInit; // 0x78
	private IFormatterConverter m_formatterConverter; // 0x80
	internal object[] crossAppDomainArray; // 0x88
	private object previousObj; // 0x90
	private long previousId; // 0x98
	private Type previousType; // 0xA0
	private InternalPrimitiveTypeE previousCode; // 0xA8
	private Hashtable assemblyToIdTable; // 0xB0
	private SerStack niPool; // 0xB8

	// Properties
	internal SerializationObjectManager ObjectManager { get; }

	// Methods

	// RVA: 0x1408500 Offset: 0x1406B00 VA: 0x181408500
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x1404BA0 Offset: 0x14031A0 VA: 0x181404BA0
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x1407B20 Offset: 0x1406120 VA: 0x181407B20
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x14076B0 Offset: 0x1405CB0 VA: 0x1814076B0
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x14069C0 Offset: 0x1404FC0 VA: 0x1814069C0
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x1406B40 Offset: 0x1405140 VA: 0x181406B40
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x1405A00 Offset: 0x1404000 VA: 0x181405A00
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x1405530 Offset: 0x1403B30 VA: 0x181405530
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x1407220 Offset: 0x1405820 VA: 0x181407220
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x1404720 Offset: 0x1402D20 VA: 0x181404720
	private object GetNext(out long objID) { }

	// RVA: 0x1404900 Offset: 0x1402F00 VA: 0x181404900
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x1404B20 Offset: 0x1403120 VA: 0x181404B20
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x1404A70 Offset: 0x1403070 VA: 0x181404A70
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x14067A0 Offset: 0x1404DA0 VA: 0x1814067A0
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x1407200 Offset: 0x1405800 VA: 0x181407200
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x1407560 Offset: 0x1405B60 VA: 0x181407560
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x1404130 Offset: 0x1402730 VA: 0x181404130
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x1407430 Offset: 0x1405A30 VA: 0x181407430
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x14052F0 Offset: 0x14038F0 VA: 0x1814052F0
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x14053A0 Offset: 0x14039A0 VA: 0x1814053A0
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x1405400 Offset: 0x1403A00 VA: 0x181405400
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x1405220 Offset: 0x1403820 VA: 0x181405220
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x14054B0 Offset: 0x1403AB0 VA: 0x1814054B0
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x1404A00 Offset: 0x1403000 VA: 0x181404A00
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x1405180 Offset: 0x1403780 VA: 0x181405180
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x14042F0 Offset: 0x14028F0 VA: 0x1814042F0
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x14048E0 Offset: 0x1402EE0 VA: 0x1814048E0
	private Type GetType(object obj) { }

	// RVA: 0x1404670 Offset: 0x1402C70 VA: 0x181404670
	private NameInfo GetNameInfo() { }

	// RVA: 0x14042E0 Offset: 0x14028E0 VA: 0x1814042E0
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x1404A40 Offset: 0x1403040 VA: 0x181404A40
	private void PutNameInfo(NameInfo nameInfo) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class __BinaryParser // TypeDefIndex: 1060
{
	// Fields
	internal ObjectReader objectReader; // 0x10
	internal Stream input; // 0x18
	internal long topId; // 0x20
	internal long headerId; // 0x28
	internal SizedArray objectMapIdTable; // 0x30
	internal SizedArray assemIdToAssemblyTable; // 0x38
	internal SerStack stack; // 0x40
	internal BinaryTypeEnum expectedType; // 0x48
	internal object expectedTypeInformation; // 0x50
	internal ParseRecord PRS; // 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; // 0x60
	private BinaryReader dataReader; // 0x68
	private static Encoding encoding; // 0x0
	private SerStack opPool; // 0x70
	private BinaryObject binaryObject; // 0x78
	private BinaryObjectWithMap bowm; // 0x80
	private BinaryObjectWithMapTyped bowmt; // 0x88
	internal BinaryObjectString objectString; // 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; // 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
	private byte[] byteBuffer; // 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
	internal MemberReference memberReference; // 0xB8
	internal ObjectNull objectNull; // 0xC0
	internal static MessageEnd messageEnd; // 0x8

	// Properties
	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }

	// Methods

	// RVA: 0x142BE90 Offset: 0x142A490 VA: 0x18142BE90
	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	// RVA: 0x142C160 Offset: 0x142A760 VA: 0x18142C160
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	// RVA: 0x142C090 Offset: 0x142A690 VA: 0x18142C090
	internal SizedArray get_ObjectMapIdTable() { }

	// RVA: 0x142BFC0 Offset: 0x142A5C0 VA: 0x18142BFC0
	internal SizedArray get_AssemIdToAssemblyTable() { }

	// RVA: 0x142C230 Offset: 0x142A830 VA: 0x18142C230
	internal ParseRecord get_prs() { }

	// RVA: 0x142B830 Offset: 0x1429E30 VA: 0x18142B830
	internal void Run() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void ReadBegin() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal void ReadEnd() { }

	// RVA: 0x1426EA0 Offset: 0x14254A0 VA: 0x181426EA0
	internal bool ReadBoolean() { }

	// RVA: 0x1426ED0 Offset: 0x14254D0 VA: 0x181426ED0
	internal byte ReadByte() { }

	// RVA: 0x1426F00 Offset: 0x1425500 VA: 0x181426F00
	internal byte[] ReadBytes(int length) { }

	// RVA: 0x1426F30 Offset: 0x1425530 VA: 0x181426F30
	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x1426FD0 Offset: 0x14255D0 VA: 0x181426FD0
	internal char ReadChar() { }

	// RVA: 0x1427000 Offset: 0x1425600 VA: 0x181427000
	internal char[] ReadChars(int length) { }

	// RVA: 0x1427E00 Offset: 0x1426400 VA: 0x181427E00
	internal Decimal ReadDecimal() { }

	// RVA: 0x142B1D0 Offset: 0x14297D0 VA: 0x18142B1D0
	internal float ReadSingle() { }

	// RVA: 0x1427ED0 Offset: 0x14264D0 VA: 0x181427ED0
	internal double ReadDouble() { }

	// RVA: 0x1427F00 Offset: 0x1426500 VA: 0x181427F00
	internal short ReadInt16() { }

	// RVA: 0x1427F30 Offset: 0x1426530 VA: 0x181427F30
	internal int ReadInt32() { }

	// RVA: 0x1427F60 Offset: 0x1426560 VA: 0x181427F60
	internal long ReadInt64() { }

	// RVA: 0x1426ED0 Offset: 0x14254D0 VA: 0x181426ED0
	internal sbyte ReadSByte() { }

	// RVA: 0x142B200 Offset: 0x1429800 VA: 0x18142B200
	internal string ReadString() { }

	// RVA: 0x1427F60 Offset: 0x1426560 VA: 0x181427F60
	internal TimeSpan ReadTimeSpan() { }

	// RVA: 0x1427D90 Offset: 0x1426390 VA: 0x181427D90
	internal DateTime ReadDateTime() { }

	// RVA: 0x142B230 Offset: 0x1429830 VA: 0x18142B230
	internal ushort ReadUInt16() { }

	// RVA: 0x142B260 Offset: 0x1429860 VA: 0x18142B260
	internal uint ReadUInt32() { }

	// RVA: 0x142B290 Offset: 0x1429890 VA: 0x18142B290
	internal ulong ReadUInt64() { }

	// RVA: 0x142B110 Offset: 0x1429710 VA: 0x18142B110
	internal void ReadSerializationHeaderRecord() { }

	// RVA: 0x1426C10 Offset: 0x1425210 VA: 0x181426C10
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x142ABD0 Offset: 0x14291D0 VA: 0x18142ABD0
	private void ReadObject() { }

	// RVA: 0x1427030 Offset: 0x1425630 VA: 0x181427030
	internal void ReadCrossAppDomainMap() { }

	// RVA: 0x142A540 Offset: 0x1428B40 VA: 0x18142A540
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x142A610 Offset: 0x1428C10 VA: 0x18142A610
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	// RVA: 0x1429E30 Offset: 0x1428430 VA: 0x181429E30
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1429EF0 Offset: 0x14284F0 VA: 0x181429EF0
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	// RVA: 0x1429420 Offset: 0x1427A20 VA: 0x181429420
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1427F90 Offset: 0x1426590 VA: 0x181427F90
	private void ReadMemberPrimitiveTyped() { }

	// RVA: 0x14264F0 Offset: 0x1424AF0 VA: 0x1814264F0
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x14261D0 Offset: 0x14247D0 VA: 0x1814261D0
	private void ReadArrayAsBytes(ParseRecord pr) { }

	// RVA: 0x14285C0 Offset: 0x1426BC0 VA: 0x1814285C0
	private void ReadMemberPrimitiveUnTyped() { }

	// RVA: 0x1428B30 Offset: 0x1427130 VA: 0x181428B30
	private void ReadMemberReference() { }

	// RVA: 0x14290A0 Offset: 0x14276A0 VA: 0x1814290A0
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x1428EF0 Offset: 0x14274F0 VA: 0x181428EF0
	private void ReadMessageEnd() { }

	// RVA: 0x142B2C0 Offset: 0x14298C0 VA: 0x18142B2C0
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	// RVA: 0x1426080 Offset: 0x1424680 VA: 0x181426080
	private ObjectProgress GetOp() { }

	// RVA: 0x1426130 Offset: 0x1424730 VA: 0x181426130
	private void PutOp(ObjectProgress op) { }

	// RVA: 0x142BE10 Offset: 0x142A410 VA: 0x18142BE10
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ParseRecord // TypeDefIndex: 1061
{
	// Fields
	internal static int parseRecordIdCount; // 0x0
	internal InternalParseTypeE PRparseTypeEnum; // 0x10
	internal InternalObjectTypeE PRobjectTypeEnum; // 0x14
	internal InternalArrayTypeE PRarrayTypeEnum; // 0x18
	internal InternalMemberTypeE PRmemberTypeEnum; // 0x1C
	internal InternalMemberValueE PRmemberValueEnum; // 0x20
	internal InternalObjectPositionE PRobjectPositionEnum; // 0x24
	internal string PRname; // 0x28
	internal string PRvalue; // 0x30
	internal object PRvarValue; // 0x38
	internal string PRkeyDt; // 0x40
	internal Type PRdtType; // 0x48
	internal InternalPrimitiveTypeE PRdtTypeCode; // 0x50
	internal bool PRisEnum; // 0x54
	internal long PRobjectId; // 0x58
	internal long PRidRef; // 0x60
	internal string PRarrayElementTypeString; // 0x68
	internal Type PRarrayElementType; // 0x70
	internal bool PRisArrayVariant; // 0x78
	internal InternalPrimitiveTypeE PRarrayElementTypeCode; // 0x7C
	internal int PRrank; // 0x80
	internal int[] PRlengthA; // 0x88
	internal int[] PRpositionA; // 0x90
	internal int[] PRlowerBoundA; // 0x98
	internal int[] PRupperBoundA; // 0xA0
	internal int[] PRindexMap; // 0xA8
	internal int PRmemberIndex; // 0xB0
	internal int PRlinearlength; // 0xB4
	internal int[] PRrectangularMap; // 0xB8
	internal bool PRisLowerBound; // 0xC0
	internal long PRtopId; // 0xC8
	internal long PRheaderId; // 0xD0
	internal ReadObjectInfo PRobjectInfo; // 0xD8
	internal bool PRisValueTypeFixup; // 0xE0
	internal object PRnewObj; // 0xE8
	internal object[] PRobjectA; // 0xF0
	internal PrimitiveArray PRprimitiveArray; // 0xF8
	internal bool PRisRegistered; // 0x100
	internal object[] PRmemberData; // 0x108
	internal SerializationInfo PRsi; // 0x110
	internal int PRnullCount; // 0x118

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x141B6D0 Offset: 0x1419CD0 VA: 0x18141B6D0
	internal void Init() { }

	// RVA: 0x141B8A0 Offset: 0x1419EA0 VA: 0x18141B8A0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerStack // TypeDefIndex: 1062
{
	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x14244C0 Offset: 0x1422AC0 VA: 0x1814244C0
	internal void .ctor(string stackId) { }

	// RVA: 0x1424380 Offset: 0x1422980 VA: 0x181424380
	internal void Push(object obj) { }

	// RVA: 0x1424300 Offset: 0x1422900 VA: 0x181424300
	internal object Pop() { }

	// RVA: 0x14241E0 Offset: 0x14227E0 VA: 0x1814241E0
	internal void IncreaseCapacity() { }

	// RVA: 0x14242C0 Offset: 0x14228C0 VA: 0x1814242C0
	internal object Peek() { }

	// RVA: 0x1424280 Offset: 0x1422880 VA: 0x181424280
	internal object PeekPeek() { }

	// RVA: 0x1424270 Offset: 0x1422870 VA: 0x181424270
	internal bool IsEmpty() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[DefaultMember("Item")]
[Serializable]
internal sealed class SizedArray : ICloneable // TypeDefIndex: 1063
{
	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x1424810 Offset: 0x1422E10 VA: 0x181424810
	internal void .ctor() { }

	// RVA: 0x1424890 Offset: 0x1422E90 VA: 0x181424890
	internal void .ctor(int length) { }

	// RVA: 0x1424910 Offset: 0x1422F10 VA: 0x181424910
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x1424540 Offset: 0x1422B40 VA: 0x181424540 Slot: 4
	public object Clone() { }

	// RVA: 0x14249F0 Offset: 0x1422FF0 VA: 0x1814249F0
	internal object get_Item(int index) { }

	// RVA: 0x1424A60 Offset: 0x1423060 VA: 0x181424A60
	internal void set_Item(int index, object value) { }

	// RVA: 0x1424640 Offset: 0x1422C40 VA: 0x181424640
	internal void IncreaseCapacity(int index) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[DefaultMember("Item")]
[Serializable]
internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 1064
{
	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x1417F10 Offset: 0x1416510 VA: 0x181417F10
	public void .ctor() { }

	// RVA: 0x1417DF0 Offset: 0x14163F0 VA: 0x181417DF0
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x1417AD0 Offset: 0x14160D0 VA: 0x181417AD0 Slot: 4
	public object Clone() { }

	// RVA: 0x1417F90 Offset: 0x1416590 VA: 0x181417F90
	internal int get_Item(int index) { }

	// RVA: 0x1418000 Offset: 0x1416600 VA: 0x181418000
	internal void set_Item(int index, int value) { }

	// RVA: 0x1417C20 Offset: 0x1416220 VA: 0x181417C20
	internal void IncreaseCapacity(int index) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class NameCache // TypeDefIndex: 1065
{
	// Fields
	private static ConcurrentDictionary<string, object> ht; // 0x0
	private string name; // 0x10

	// Methods

	// RVA: 0x141B370 Offset: 0x1419970 VA: 0x18141B370
	internal object GetCachedValue(string name) { }

	// RVA: 0x141B430 Offset: 0x1419A30 VA: 0x18141B430
	internal void SetCachedValue(object value) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x141B4C0 Offset: 0x1419AC0 VA: 0x18141B4C0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ValueFixup // TypeDefIndex: 1066
{
	// Fields
	internal ValueFixupEnum valueFixupEnum; // 0x10
	internal Array arrayObj; // 0x18
	internal int[] indexMap; // 0x20
	internal object header; // 0x28
	internal object memberObject; // 0x30
	internal static MemberInfo valueInfo; // 0x0
	internal ReadObjectInfo objectInfo; // 0x38
	internal string memberName; // 0x40

	// Methods

	// RVA: 0x1425C00 Offset: 0x1424200 VA: 0x181425C00
	internal void .ctor(Array arrayObj, int[] indexMap) { }

	// RVA: 0x1425C60 Offset: 0x1424260 VA: 0x181425C60
	internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	// RVA: 0x14258C0 Offset: 0x1423EC0 VA: 0x1814258C0
	internal void Fixup(ParseRecord record, ParseRecord parent) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class InternalFE // TypeDefIndex: 1067
{
	// Fields
	internal FormatterTypeStyle FEtypeFormat; // 0x10
	internal FormatterAssemblyStyle FEassemblyFormat; // 0x14
	internal TypeFilterLevel FEsecurityLevel; // 0x18
	internal InternalSerializerTypeE FEserializerTypeEnum; // 0x1C

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class NameInfo // TypeDefIndex: 1068
{
	// Fields
	internal string NIFullName; // 0x10
	internal long NIobjectId; // 0x18
	internal long NIassemId; // 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; // 0x28
	internal Type NItype; // 0x30
	internal bool NIisSealed; // 0x38
	internal bool NIisArray; // 0x39
	internal bool NIisArrayItem; // 0x3A
	internal bool NItransmitTypeOnObject; // 0x3B
	internal bool NItransmitTypeOnMember; // 0x3C
	internal bool NIisParentTypeOnObject; // 0x3D
	internal InternalArrayTypeE NIarrayEnum; // 0x40
	private bool NIsealedStatusChecked; // 0x44

	// Properties
	public bool IsSealed { get; }
	public string NIname { get; set; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x141B550 Offset: 0x1419B50 VA: 0x18141B550
	internal void Init() { }

	// RVA: 0x141B5B0 Offset: 0x1419BB0 VA: 0x18141B5B0
	public bool get_IsSealed() { }

	// RVA: 0x141B5F0 Offset: 0x1419BF0 VA: 0x18141B5F0
	public string get_NIname() { }

	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_NIname(string value) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class PrimitiveArray // TypeDefIndex: 1069
{
	// Fields
	private InternalPrimitiveTypeE code; // 0x10
	private bool[] booleanA; // 0x18
	private char[] charA; // 0x20
	private double[] doubleA; // 0x28
	private short[] int16A; // 0x30
	private int[] int32A; // 0x38
	private long[] int64A; // 0x40
	private sbyte[] sbyteA; // 0x48
	private float[] singleA; // 0x50
	private ushort[] uint16A; // 0x58
	private uint[] uint32A; // 0x60
	private ulong[] uint64A; // 0x68

	// Methods

	// RVA: 0x141C2A0 Offset: 0x141A8A0 VA: 0x18141C2A0
	internal void .ctor(InternalPrimitiveTypeE code, Array array) { }

	// RVA: 0x141B8E0 Offset: 0x1419EE0 VA: 0x18141B8E0
	internal void Init(InternalPrimitiveTypeE code, Array array) { }

	// RVA: 0x141BEA0 Offset: 0x141A4A0 VA: 0x18141BEA0
	internal void SetValue(string value, int index) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[Flags]
[Serializable]
internal enum MessageEnum // TypeDefIndex: 1070
{
	// Fields
	public int value__; // 0x0
	public const MessageEnum NoArgs = 1;
	public const MessageEnum ArgsInline = 2;
	public const MessageEnum ArgsIsArray = 4;
	public const MessageEnum ArgsInArray = 8;
	public const MessageEnum NoContext = 16;
	public const MessageEnum ContextInline = 32;
	public const MessageEnum ContextInArray = 64;
	public const MessageEnum MethodSignatureInArray = 128;
	public const MessageEnum PropertyInArray = 256;
	public const MessageEnum NoReturnValue = 512;
	public const MessageEnum ReturnValueVoid = 1024;
	public const MessageEnum ReturnValueInline = 2048;
	public const MessageEnum ReturnValueInArray = 4096;
	public const MessageEnum ExceptionInArray = 8192;
	public const MessageEnum GenericMethod = 32768;
}

