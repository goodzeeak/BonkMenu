// Namespace: System.Numerics
internal class ConstantHelper // TypeDefIndex: 1324
{
	// Methods

	// RVA: 0x14340F0 Offset: 0x14326F0 VA: 0x1814340F0
	public static byte GetByteWithAllBitsSet() { }

	// RVA: 0x14340F0 Offset: 0x14326F0 VA: 0x1814340F0
	public static sbyte GetSByteWithAllBitsSet() { }

	// RVA: 0x1434130 Offset: 0x1432730 VA: 0x181434130
	public static ushort GetUInt16WithAllBitsSet() { }

	// RVA: 0x37A690 Offset: 0x378C90 VA: 0x18037A690
	public static short GetInt16WithAllBitsSet() { }

	// RVA: 0x37A690 Offset: 0x378C90 VA: 0x18037A690
	public static uint GetUInt32WithAllBitsSet() { }

	// RVA: 0x37A690 Offset: 0x378C90 VA: 0x18037A690
	public static int GetInt32WithAllBitsSet() { }

	// RVA: 0x1434110 Offset: 0x1432710 VA: 0x181434110
	public static ulong GetUInt64WithAllBitsSet() { }

	// RVA: 0x1434110 Offset: 0x1432710 VA: 0x181434110
	public static long GetInt64WithAllBitsSet() { }

	// RVA: 0x1434120 Offset: 0x1432720 VA: 0x181434120
	public static float GetSingleWithAllBitsSet() { }

	// RVA: 0x1434100 Offset: 0x1432700 VA: 0x181434100
	public static double GetDoubleWithAllBitsSet() { }
}

// Namespace: System.Numerics
internal struct Register // TypeDefIndex: 1325
{
	// Fields
	internal byte byte_0; // 0x0
	internal byte byte_1; // 0x1
	internal byte byte_2; // 0x2
	internal byte byte_3; // 0x3
	internal byte byte_4; // 0x4
	internal byte byte_5; // 0x5
	internal byte byte_6; // 0x6
	internal byte byte_7; // 0x7
	internal byte byte_8; // 0x8
	internal byte byte_9; // 0x9
	internal byte byte_10; // 0xA
	internal byte byte_11; // 0xB
	internal byte byte_12; // 0xC
	internal byte byte_13; // 0xD
	internal byte byte_14; // 0xE
	internal byte byte_15; // 0xF
	internal sbyte sbyte_0; // 0x0
	internal sbyte sbyte_1; // 0x1
	internal sbyte sbyte_2; // 0x2
	internal sbyte sbyte_3; // 0x3
	internal sbyte sbyte_4; // 0x4
	internal sbyte sbyte_5; // 0x5
	internal sbyte sbyte_6; // 0x6
	internal sbyte sbyte_7; // 0x7
	internal sbyte sbyte_8; // 0x8
	internal sbyte sbyte_9; // 0x9
	internal sbyte sbyte_10; // 0xA
	internal sbyte sbyte_11; // 0xB
	internal sbyte sbyte_12; // 0xC
	internal sbyte sbyte_13; // 0xD
	internal sbyte sbyte_14; // 0xE
	internal sbyte sbyte_15; // 0xF
	internal ushort uint16_0; // 0x0
	internal ushort uint16_1; // 0x2
	internal ushort uint16_2; // 0x4
	internal ushort uint16_3; // 0x6
	internal ushort uint16_4; // 0x8
	internal ushort uint16_5; // 0xA
	internal ushort uint16_6; // 0xC
	internal ushort uint16_7; // 0xE
	internal short int16_0; // 0x0
	internal short int16_1; // 0x2
	internal short int16_2; // 0x4
	internal short int16_3; // 0x6
	internal short int16_4; // 0x8
	internal short int16_5; // 0xA
	internal short int16_6; // 0xC
	internal short int16_7; // 0xE
	internal uint uint32_0; // 0x0
	internal uint uint32_1; // 0x4
	internal uint uint32_2; // 0x8
	internal uint uint32_3; // 0xC
	internal int int32_0; // 0x0
	internal int int32_1; // 0x4
	internal int int32_2; // 0x8
	internal int int32_3; // 0xC
	internal ulong uint64_0; // 0x0
	internal ulong uint64_1; // 0x8
	internal long int64_0; // 0x0
	internal long int64_1; // 0x8
	internal float single_0; // 0x0
	internal float single_1; // 0x4
	internal float single_2; // 0x8
	internal float single_3; // 0xC
	internal double double_0; // 0x0
	internal double double_1; // 0x8
}

// Namespace: System.Numerics
[Intrinsic]
[DefaultMember("Item")]
public struct Vector<T> : IEquatable<Vector<T>>, IFormattable // TypeDefIndex: 1327
{
	// Fields
	private Register register; // 0x0
	private static readonly int s_count; // 0x0
	private static readonly Vector<T> s_zero; // 0x0
	private static readonly Vector<T> s_one; // 0x0
	private static readonly Vector<T> s_allOnes; // 0x0

	// Properties
	public static int Count { get; }
	public static Vector<T> Zero { get; }
	public T Item { get; }

	// Methods

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA6D30 Offset: 0xBA5330 VA: 0x180BA6D30
	|-Vector<ushort>.get_Count
	|-Vector<ulong>.get_Count
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static Vector<T> get_Zero() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA7830 Offset: 0xBA5E30 VA: 0x180BA7830
	|-Vector<ushort>.get_Zero
	|-Vector<ulong>.get_Zero
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Zero
	*/

	// RVA: -1 Offset: -1
	private static int InitializeCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA2830 Offset: 0xBA0E30 VA: 0x180BA2830
	|-Vector<ushort>.InitializeCount
	|-Vector<ulong>.InitializeCount
	|-Vector<__Il2CppFullySharedGenericStructType>.InitializeCount
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA4000 Offset: 0xBA2600 VA: 0x180BA4000
	|-Vector<ushort>..ctor
	|
	|-RVA: 0xBB74A0 Offset: 0xBB5AA0 VA: 0x180BB74A0
	|-Vector<ulong>..ctor
	|
	|-RVA: 0xBBA190 Offset: 0xBB8790 VA: 0x180BBA190
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA33C0 Offset: 0xBA19C0 VA: 0x180BA33C0
	|-Vector<ushort>..ctor
	|-Vector<ulong>..ctor
	|
	|-RVA: 0xBBE020 Offset: 0xBBC620 VA: 0x180BBE020
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(void* dataPointer, int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA3460 Offset: 0xBA1A60 VA: 0x180BA3460
	|-Vector<ushort>..ctor
	|-Vector<ulong>..ctor
	|
	|-RVA: 0xBBD490 Offset: 0xBBBA90 VA: 0x180BBD490
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(ref Register existingRegister) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A43C0 Offset: 0x3A29C0 VA: 0x1803A43C0
	|-Vector<ushort>..ctor
	|-Vector<ulong>..ctor
	|-Vector<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA6DD0 Offset: 0xBA53D0 VA: 0x180BA6DD0
	|-Vector<ushort>.get_Item
	|
	|-RVA: 0xBBEBB0 Offset: 0xBBD1B0 VA: 0x180BBEBB0
	|-Vector<ulong>.get_Item
	|
	|-RVA: 0xBBE0F0 Offset: 0xBBC6F0 VA: 0x180BBE0F0
	|-Vector<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8BB10 Offset: 0xB8A110 VA: 0x180B8BB10
	|-Vector<ushort>.Equals
	|
	|-RVA: 0xBA7C70 Offset: 0xBA6270 VA: 0x180BA7C70
	|-Vector<ulong>.Equals
	|
	|-RVA: 0xBA7AE0 Offset: 0xBA60E0 VA: 0x180BA7AE0
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(Vector<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9FF40 Offset: 0xB9E540 VA: 0x180B9FF40
	|-Vector<ushort>.Equals
	|
	|-RVA: 0xBAEC80 Offset: 0xBAD280 VA: 0x180BAEC80
	|-Vector<ulong>.Equals
	|
	|-RVA: 0xBAF440 Offset: 0xBADA40 VA: 0x180BAF440
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA0700 Offset: 0xB9ED00 VA: 0x180BA0700
	|-Vector<ushort>.GetHashCode
	|
	|-RVA: 0xBB2B00 Offset: 0xBB1100 VA: 0x180BB2B00
	|-Vector<ulong>.GetHashCode
	|
	|-RVA: 0xBB0700 Offset: 0xBAED00 VA: 0x180BB0700
	|-Vector<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA2CD0 Offset: 0xBA12D0 VA: 0x180BA2CD0
	|-Vector<ushort>.ToString
	|
	|-RVA: 0xBB64F0 Offset: 0xBB4AF0 VA: 0x180BB64F0
	|-Vector<ulong>.ToString
	|
	|-RVA: 0xBB63E0 Offset: 0xBB49E0 VA: 0x180BB63E0
	|-Vector<__Il2CppFullySharedGenericStructType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA2DB0 Offset: 0xBA13B0 VA: 0x180BA2DB0
	|-Vector<ushort>.ToString
	|
	|-RVA: 0xBB65D0 Offset: 0xBB4BD0 VA: 0x180BB65D0
	|-Vector<ulong>.ToString
	|
	|-RVA: 0xBB69E0 Offset: 0xBB4FE0 VA: 0x180BB69E0
	|-Vector<__Il2CppFullySharedGenericStructType>.ToString
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA78D0 Offset: 0xBA5ED0 VA: 0x180BA78D0
	|-Vector<ushort>.op_Equality
	|
	|-RVA: 0xBBF610 Offset: 0xBBDC10 VA: 0x180BBF610
	|-Vector<ulong>.op_Equality
	|
	|-RVA: 0xBBF6B0 Offset: 0xBBDCB0 VA: 0x180BBF6B0
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA79D0 Offset: 0xBA5FD0 VA: 0x180BA79D0
	|-Vector<ushort>.op_Inequality
	|
	|-RVA: 0xBBF800 Offset: 0xBBDE00 VA: 0x180BBF800
	|-Vector<ulong>.op_Inequality
	|
	|-RVA: 0xBBF910 Offset: 0xBBDF10 VA: 0x180BBF910
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	[Intrinsic]
	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public static Vector<ulong> op_Explicit(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA7970 Offset: 0xBA5F70 VA: 0x180BA7970
	|-Vector<ushort>.op_Explicit
	|
	|-RVA: 0xBBF780 Offset: 0xBBDD80 VA: 0x180BBF780
	|-Vector<ulong>.op_Explicit
	|
	|-RVA: 0xBBF7C0 Offset: 0xBBDDC0 VA: 0x180BBF7C0
	|-Vector<__Il2CppFullySharedGenericStructType>.op_Explicit
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	internal static Vector<T> Equals(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9DB60 Offset: 0xB9C160 VA: 0x180B9DB60
	|-Vector<ushort>.Equals
	|
	|-RVA: 0xBA9DA0 Offset: 0xBA83A0 VA: 0x180BA9DA0
	|-Vector<ulong>.Equals
	|
	|-RVA: 0xBAC150 Offset: 0xBAA750 VA: 0x180BAC150
	|-Vector<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1
	private static bool ScalarEquals(T left, T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x807980 Offset: 0x805F80 VA: 0x180807980
	|-Vector<ushort>.ScalarEquals
	|
	|-RVA: 0xBA90D0 Offset: 0xBA76D0 VA: 0x180BA90D0
	|-Vector<ulong>.ScalarEquals
	|
	|-RVA: 0xBB55F0 Offset: 0xBB3BF0 VA: 0x180BB55F0
	|-Vector<__Il2CppFullySharedGenericStructType>.ScalarEquals
	*/

	// RVA: -1 Offset: -1
	private static T GetOneValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8C5F0 Offset: 0xB8ABF0 VA: 0x180B8C5F0
	|-Vector<ushort>.GetOneValue
	|
	|-RVA: 0xBA8750 Offset: 0xBA6D50 VA: 0x180BA8750
	|-Vector<ulong>.GetOneValue
	|
	|-RVA: 0xBB4C30 Offset: 0xBB3230 VA: 0x180BB4C30
	|-Vector<__Il2CppFullySharedGenericStructType>.GetOneValue
	*/

	// RVA: -1 Offset: -1
	private static T GetAllBitsSetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB8BC70 Offset: 0xB8A270 VA: 0x180B8BC70
	|-Vector<ushort>.GetAllBitsSetValue
	|
	|-RVA: 0xBA7DD0 Offset: 0xBA63D0 VA: 0x180BA7DD0
	|-Vector<ulong>.GetAllBitsSetValue
	|
	|-RVA: 0xBAFD40 Offset: 0xBAE340 VA: 0x180BAFD40
	|-Vector<__Il2CppFullySharedGenericStructType>.GetAllBitsSetValue
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBA31C0 Offset: 0xBA17C0 VA: 0x180BA31C0
	|-Vector<ushort>..cctor
	|
	|-RVA: 0xBB6F20 Offset: 0xBB5520 VA: 0x180BB6F20
	|-Vector<ulong>..cctor
	|
	|-RVA: 0xBB7120 Offset: 0xBB5720 VA: 0x180BB7120
	|-Vector<__Il2CppFullySharedGenericStructType>..cctor
	*/
}

// Namespace: System.Numerics
[Intrinsic]
public static class Vector // TypeDefIndex: 1328
{
	// Properties
	public static bool IsHardwareAccelerated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x812090 Offset: 0x810690 VA: 0x180812090
	|-Vector.Equals<ushort>
	|
	|-RVA: 0x811FE0 Offset: 0x8105E0 VA: 0x180811FE0
	|-Vector.Equals<__Il2CppFullySharedGenericStructType>
	*/

	[Intrinsic]
	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public static bool get_IsHardwareAccelerated() { }

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x811F50 Offset: 0x810550 VA: 0x180811F50
	|-Vector.AsVectorUInt64<ushort>
	|
	|-RVA: 0x811EC0 Offset: 0x8104C0 VA: 0x180811EC0
	|-Vector.AsVectorUInt64<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: System.Numerics
public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 13633
{
	// Fields
	public float X; // 0x0
	public float Y; // 0x4
	public float Z; // 0x8

	// Methods

	// RVA: 0x1BAF8D0 Offset: 0x1BADED0 VA: 0x181BAF8D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BAF810 Offset: 0x1BADE10 VA: 0x181BAF810 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BAFBC0 Offset: 0x1BAE1C0 VA: 0x181BAFBC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BAF980 Offset: 0x1BADF80 VA: 0x181BAF980 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	[Intrinsic]
	// RVA: 0x17E7430 Offset: 0x17E5A30 VA: 0x1817E7430
	public void .ctor(float x, float y, float z) { }

	[Intrinsic]
	// RVA: 0x18142B0 Offset: 0x18128B0 VA: 0x1818142B0 Slot: 4
	public bool Equals(Vector3 other) { }
}

// Namespace: System.Numerics
[IsReadOnly]
[Serializable]
public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 13635
{
	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Properties
	public static BigInteger Zero { get; }
	public static BigInteger MinusOne { get; }
	public bool IsZero { get; }

	// Methods

	// RVA: 0x1BA5780 Offset: 0x1BA3D80 VA: 0x181BA5780
	public void .ctor(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA4FC0 Offset: 0x1BA35C0 VA: 0x181BA4FC0
	public void .ctor(uint value) { }

	// RVA: 0x1BA4E20 Offset: 0x1BA3420 VA: 0x181BA4E20
	public void .ctor(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA4700 Offset: 0x1BA2D00 VA: 0x181BA4700
	public void .ctor(ulong value) { }

	// RVA: 0x1BA4DC0 Offset: 0x1BA33C0 VA: 0x181BA4DC0
	public void .ctor(float value) { }

	// RVA: 0x1BA4820 Offset: 0x1BA2E20 VA: 0x181BA4820
	public void .ctor(double value) { }

	// RVA: 0x1BA4BB0 Offset: 0x1BA31B0 VA: 0x181BA4BB0
	public void .ctor(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA4610 Offset: 0x1BA2C10 VA: 0x181BA4610
	public void .ctor(byte[] value) { }

	// RVA: 0x1BA5080 Offset: 0x1BA3680 VA: 0x181BA5080
	public void .ctor(ReadOnlySpan<byte> value, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0xA4BD30 Offset: 0xA4A330 VA: 0x180A4BD30
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x1BA4410 Offset: 0x1BA2A10 VA: 0x181BA4410
	internal void .ctor(uint[] value, bool negative) { }

	// RVA: 0x1BA5870 Offset: 0x1BA3E70 VA: 0x181BA5870
	public static BigInteger get_Zero() { }

	// RVA: 0x1BA5810 Offset: 0x1BA3E10 VA: 0x181BA5810
	public static BigInteger get_MinusOne() { }

	// RVA: 0x1BA5800 Offset: 0x1BA3E00 VA: 0x181BA5800
	public bool get_IsZero() { }

	// RVA: 0x1BA3440 Offset: 0x1BA1A40 VA: 0x181BA3440
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x1BA34E0 Offset: 0x1BA1AE0 VA: 0x181BA34E0
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1BA3320 Offset: 0x1BA1920 VA: 0x181BA3320 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BA3210 Offset: 0x1BA1810 VA: 0x181BA3210 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1BA3190 Offset: 0x1BA1790 VA: 0x181BA3190
	public bool Equals(long other) { }

	// RVA: 0x1BA3080 Offset: 0x1BA1680 VA: 0x181BA3080 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x1BA2EC0 Offset: 0x1BA14C0 VA: 0x181BA2EC0
	public int CompareTo(long other) { }

	// RVA: 0x1BA2D10 Offset: 0x1BA1310 VA: 0x181BA2D10 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x1BA2F70 Offset: 0x1BA1570 VA: 0x181BA2F70 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x1BA3810 Offset: 0x1BA1E10 VA: 0x181BA3810
	public byte[] ToByteArray() { }

	// RVA: 0x1BA3760 Offset: 0x1BA1D60 VA: 0x181BA3760
	public byte[] ToByteArray(bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x1BA4010 Offset: 0x1BA2610 VA: 0x181BA4010
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x1BA40D0 Offset: 0x1BA26D0 VA: 0x181BA40D0
	internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = False, bool isBigEndian = False) { }

	// RVA: 0x1BA3AF0 Offset: 0x1BA20F0 VA: 0x181BA3AF0
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	// RVA: 0x1BA3860 Offset: 0x1BA1E60 VA: 0x181BA3860 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BA3920 Offset: 0x1BA1F20 VA: 0x181BA3920
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1BA39F0 Offset: 0x1BA1FF0 VA: 0x181BA39F0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1BA2B50 Offset: 0x1BA1150 VA: 0x181BA2B50
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x1BA7C70 Offset: 0x1BA6270 VA: 0x181BA7C70
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x1BA3540 Offset: 0x1BA1B40 VA: 0x181BA3540
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x1BA6B30 Offset: 0x1BA5130 VA: 0x181BA6B30
	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA6A90 Offset: 0x1BA5090 VA: 0x181BA6A90
	public static BigInteger op_Implicit(sbyte value) { }

	// RVA: 0x1BA6B00 Offset: 0x1BA5100 VA: 0x181BA6B00
	public static BigInteger op_Implicit(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA6B80 Offset: 0x1BA5180 VA: 0x181BA6B80
	public static BigInteger op_Implicit(ushort value) { }

	// RVA: 0x1BA6A70 Offset: 0x1BA5070 VA: 0x181BA6A70
	public static BigInteger op_Implicit(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA6AE0 Offset: 0x1BA50E0 VA: 0x181BA6AE0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1BA6B60 Offset: 0x1BA5160 VA: 0x181BA6B60
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA6AC0 Offset: 0x1BA50C0 VA: 0x181BA6AC0
	public static BigInteger op_Implicit(ulong value) { }

	// RVA: 0x1BA68C0 Offset: 0x1BA4EC0 VA: 0x181BA68C0
	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA63D0 Offset: 0x1BA49D0 VA: 0x181BA63D0
	public static sbyte op_Explicit(BigInteger value) { }

	// RVA: 0x1BA60D0 Offset: 0x1BA46D0 VA: 0x181BA60D0
	public static short op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA6840 Offset: 0x1BA4E40 VA: 0x181BA6840
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x1BA62A0 Offset: 0x1BA48A0 VA: 0x181BA62A0
	public static int op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA65A0 Offset: 0x1BA4BA0 VA: 0x181BA65A0
	public static uint op_Explicit(BigInteger value) { }

	// RVA: 0x1BA6940 Offset: 0x1BA4F40 VA: 0x181BA6940
	public static long op_Explicit(BigInteger value) { }

	[CLSCompliant(False)]
	// RVA: 0x1BA6770 Offset: 0x1BA4D70 VA: 0x181BA6770
	public static ulong op_Explicit(BigInteger value) { }

	// RVA: 0x1BA6450 Offset: 0x1BA4A50 VA: 0x181BA6450
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x1BA6650 Offset: 0x1BA4C50 VA: 0x181BA6650
	public static double op_Explicit(BigInteger value) { }

	// RVA: 0x1BA6150 Offset: 0x1BA4750 VA: 0x181BA6150
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x1BA6C80 Offset: 0x1BA5280 VA: 0x181BA6C80
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x1BA77A0 Offset: 0x1BA5DA0 VA: 0x181BA77A0
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x1BA8000 Offset: 0x1BA6600 VA: 0x181BA8000
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x1BA58D0 Offset: 0x1BA3ED0 VA: 0x181BA58D0
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x1BA7490 Offset: 0x1BA5A90 VA: 0x181BA7490
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x1BA5C80 Offset: 0x1BA4280 VA: 0x181BA5C80
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x1BA71A0 Offset: 0x1BA57A0 VA: 0x181BA71A0
	public static BigInteger op_Modulus(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x1BA6FB0 Offset: 0x1BA55B0 VA: 0x181BA6FB0
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x1BA6C10 Offset: 0x1BA5210 VA: 0x181BA6C10
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x1BA7140 Offset: 0x1BA5740 VA: 0x181BA7140
	public static bool op_LessThan(BigInteger left, long right) { }

	// RVA: 0x1BA7020 Offset: 0x1BA5620 VA: 0x181BA7020
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	// RVA: 0x1BA6070 Offset: 0x1BA4670 VA: 0x181BA6070
	public static bool op_Equality(BigInteger left, long right) { }

	// RVA: 0x1BA6BB0 Offset: 0x1BA51B0 VA: 0x181BA6BB0
	public static bool op_Inequality(BigInteger left, long right) { }

	// RVA: 0x1BA70E0 Offset: 0x1BA56E0 VA: 0x181BA70E0
	public static bool op_LessThan(long left, BigInteger right) { }

	// RVA: 0x1BA7080 Offset: 0x1BA5680 VA: 0x181BA7080
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	// RVA: 0x1BA3370 Offset: 0x1BA1970 VA: 0x181BA3370
	private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl) { }

	// RVA: 0x1BA32C0 Offset: 0x1BA18C0 VA: 0x181BA32C0
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x1BA4180 Offset: 0x1BA2780 VA: 0x181BA4180
	private static void .cctor() { }
}

// Namespace: System.Numerics
internal static class BigIntegerCalculator // TypeDefIndex: 13636
{
	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x1BA0E60 Offset: 0x1B9F460 VA: 0x181BA0E60
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x1BA0F30 Offset: 0x1B9F530 VA: 0x181BA0F30
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x1BA0DB0 Offset: 0x1B9F3B0 VA: 0x181BA0DB0
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x1BA0D40 Offset: 0x1B9F340 VA: 0x181BA0D40
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x1BA2A10 Offset: 0x1BA1010 VA: 0x181BA2A10
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x1BA27D0 Offset: 0x1BA0DD0 VA: 0x181BA27D0
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x1BA2960 Offset: 0x1BA0F60 VA: 0x181BA2960
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x1BA1040 Offset: 0x1B9F640 VA: 0x181BA1040
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x1BA15C0 Offset: 0x1B9FBC0 VA: 0x181BA15C0
	public static uint[] Divide(uint[] left, uint right) { }

	// RVA: 0x1BA20B0 Offset: 0x1BA06B0 VA: 0x181BA20B0
	public static uint Remainder(uint[] left, uint right) { }

	// RVA: 0x1BA1670 Offset: 0x1B9FC70 VA: 0x181BA1670
	public static uint[] Divide(uint[] left, uint[] right) { }

	// RVA: 0x1BA1FB0 Offset: 0x1BA05B0 VA: 0x181BA1FB0
	public static uint[] Remainder(uint[] left, uint[] right) { }

	// RVA: 0x1BA1190 Offset: 0x1B9F790 VA: 0x181BA1190
	private static void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x1BA0D10 Offset: 0x1B9F310 VA: 0x181BA0D10
	private static uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x1BA2770 Offset: 0x1BA0D70 VA: 0x181BA2770
	private static uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q) { }

	// RVA: 0x1BA1150 Offset: 0x1B9F750 VA: 0x181BA1150
	private static bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo) { }

	// RVA: 0x1BA10D0 Offset: 0x1B9F6D0 VA: 0x181BA10D0
	private static uint[] CreateCopy(uint[] value) { }

	// RVA: 0x1BA17B0 Offset: 0x1B9FDB0 VA: 0x181BA17B0
	private static int LeadingZeros(uint value) { }

	// RVA: 0x1BA2580 Offset: 0x1BA0B80 VA: 0x181BA2580
	public static uint[] Square(uint[] value) { }

	// RVA: 0x1BA2110 Offset: 0x1BA0710 VA: 0x181BA2110
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x1BA1EF0 Offset: 0x1BA04F0 VA: 0x181BA1EF0
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x1BA1820 Offset: 0x1B9FE20 VA: 0x181BA1820
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x1BA1940 Offset: 0x1B9FF40 VA: 0x181BA1940
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x1BA2660 Offset: 0x1BA0C60 VA: 0x181BA2660
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x1BA2AD0 Offset: 0x1BA10D0 VA: 0x181BA2AD0
	private static void .cctor() { }
}

// Namespace: System.Numerics
internal static class BigNumber // TypeDefIndex: 13638
{
	// Methods

	// RVA: 0x1BAA370 Offset: 0x1BA8970 VA: 0x181BAA370
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x1BAA040 Offset: 0x1BA8640 VA: 0x181BAA040
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x1BA9B80 Offset: 0x1BA8180 VA: 0x181BA9B80
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1BA9D80 Offset: 0x1BA8380 VA: 0x181BA9D80
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1BA95C0 Offset: 0x1BA7BC0 VA: 0x181BA95C0
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x1BA9860 Offset: 0x1BA7E60 VA: 0x181BA9860
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x1BA9EF0 Offset: 0x1BA84F0 VA: 0x181BA9EF0
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x1BA80A0 Offset: 0x1BA66A0 VA: 0x181BA80A0
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }

	// RVA: 0x1BA8830 Offset: 0x1BA6E30 VA: 0x181BA8830
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x1BA8920 Offset: 0x1BA6F20 VA: 0x181BA8920
	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }
}

// Namespace: System.Numerics
internal struct DoubleUlong // TypeDefIndex: 13639
{
	// Fields
	public double dbl; // 0x0
	public ulong uu; // 0x0
}

// Namespace: System.Numerics
internal static class NumericsHelpers // TypeDefIndex: 13640
{
	// Methods

	// RVA: 0x1BAEBB0 Offset: 0x1BAD1B0 VA: 0x181BAEBB0
	public static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite) { }

	// RVA: 0x1BAEA50 Offset: 0x1BAD050 VA: 0x181BAEA50
	public static double GetDoubleFromParts(int sign, int exp, ulong man) { }

	// RVA: 0x1BAE9C0 Offset: 0x1BACFC0 VA: 0x181BAE9C0
	public static void DangerousMakeTwosComplement(uint[] d) { }

	// RVA: 0x1BAEC40 Offset: 0x1BAD240 VA: 0x181BAEC40
	public static ulong MakeUlong(uint uHi, uint uLo) { }

	// RVA: 0x1BAE900 Offset: 0x1BACF00 VA: 0x181BAE900
	public static uint Abs(int a) { }

	// RVA: 0x1BAE9B0 Offset: 0x1BACFB0 VA: 0x181BAE9B0
	public static uint CombineHash(uint u1, uint u2) { }

	// RVA: 0x1BAE9B0 Offset: 0x1BACFB0 VA: 0x181BAE9B0
	public static int CombineHash(int n1, int n2) { }

	// RVA: 0x1BA17B0 Offset: 0x1B9FDB0 VA: 0x181BA17B0
	public static int CbitHighZero(uint u) { }

	// RVA: 0x1BAE910 Offset: 0x1BACF10 VA: 0x181BAE910
	public static int CbitHighZero(ulong uu) { }
}

