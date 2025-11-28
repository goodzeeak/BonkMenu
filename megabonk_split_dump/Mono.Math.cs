// Namespace: Mono.Math
internal class BigInteger // TypeDefIndex: 112
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x134D660 Offset: 0x134BC60 VA: 0x18134D660
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x134D6D0 Offset: 0x134BCD0 VA: 0x18134D6D0
	public void .ctor(BigInteger bi) { }

	// RVA: 0x134D590 Offset: 0x134BB90 VA: 0x18134D590
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x134D7C0 Offset: 0x134BDC0 VA: 0x18134D7C0
	public void .ctor(byte[] inData) { }

	// RVA: 0x134D500 Offset: 0x134BB00 VA: 0x18134D500
	public void .ctor(uint ui) { }

	// RVA: 0x134DCC0 Offset: 0x134C2C0 VA: 0x18134DCC0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x134DC20 Offset: 0x134C220 VA: 0x18134DC20
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x134E3B0 Offset: 0x134C9B0 VA: 0x18134E3B0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1327770 Offset: 0x1325D70 VA: 0x181327770
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x134DDF0 Offset: 0x134C3F0 VA: 0x18134DDF0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x134DB30 Offset: 0x134C130 VA: 0x18134DB30
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x134E0A0 Offset: 0x134C6A0 VA: 0x18134E0A0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x134DE20 Offset: 0x134C420 VA: 0x18134DE20
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x134DDE0 Offset: 0x134C3E0 VA: 0x18134DDE0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x134E3A0 Offset: 0x134C9A0 VA: 0x18134E3A0
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x134DA50 Offset: 0x134C050 VA: 0x18134DA50
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x134C450 Offset: 0x134AA50 VA: 0x18134C450
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x134C3F0 Offset: 0x134A9F0 VA: 0x18134C3F0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x134CC60 Offset: 0x134B260 VA: 0x18134CC60
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x134CE80 Offset: 0x134B480 VA: 0x18134CE80
	public void Randomize() { }

	// RVA: 0x1325A80 Offset: 0x1324080 VA: 0x181325A80
	public int BitCount() { }

	// RVA: 0x134CEE0 Offset: 0x134B4E0 VA: 0x18134CEE0
	public bool TestBit(uint bitNum) { }

	// RVA: 0x134CF20 Offset: 0x134B520 VA: 0x18134CF20
	public bool TestBit(int bitNum) { }

	// RVA: 0x1326650 Offset: 0x1324C50 VA: 0x181326650
	public void SetBit(uint bitNum) { }

	// RVA: 0x13266A0 Offset: 0x1324CA0 VA: 0x1813266A0
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x134CAD0 Offset: 0x134B0D0 VA: 0x18134CAD0
	public int LowestSetBit() { }

	// RVA: 0x134C650 Offset: 0x134AC50 VA: 0x18134C650
	public byte[] GetBytes() { }

	// RVA: 0x1327330 Offset: 0x1325930 VA: 0x181327330
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x1327670 Offset: 0x1325C70 VA: 0x181327670
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x134DB60 Offset: 0x134C160 VA: 0x18134DB60
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x134DD20 Offset: 0x134C320 VA: 0x18134DD20
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1327490 Offset: 0x1325A90 VA: 0x181327490
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1327720 Offset: 0x1325D20 VA: 0x181327720
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1327470 Offset: 0x1325A70 VA: 0x181327470
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1327700 Offset: 0x1325D00 VA: 0x181327700
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x134CFC0 Offset: 0x134B5C0 VA: 0x18134CFC0
	public string ToString(uint radix) { }

	// RVA: 0x134D050 Offset: 0x134B650 VA: 0x18134D050
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1326600 Offset: 0x1324C00 VA: 0x181326600
	private void Normalize() { }

	// RVA: 0x1325B30 Offset: 0x1324130 VA: 0x181325B30
	public void Clear() { }

	// RVA: 0x1326380 Offset: 0x1324980 VA: 0x181326380 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x134D010 Offset: 0x134B610 VA: 0x18134D010 Slot: 3
	public override string ToString() { }

	// RVA: 0x134C090 Offset: 0x134A690 VA: 0x18134C090 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x134CBC0 Offset: 0x134B1C0 VA: 0x18134CBC0
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x134CBD0 Offset: 0x134B1D0 VA: 0x18134CBD0
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x134C7E0 Offset: 0x134ADE0 VA: 0x18134C7E0
	public bool IsProbablePrime() { }

	// RVA: 0x134C380 Offset: 0x134A980 VA: 0x18134C380
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x13263C0 Offset: 0x13249C0 VA: 0x1813263C0
	public void Incr2() { }

	// RVA: 0x134D470 Offset: 0x134BA70 VA: 0x18134D470
	private static void .cctor() { }
}

// Namespace: Mono.Math
public class BigInteger // TypeDefIndex: 12888
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1326DC0 Offset: 0x13253C0 VA: 0x181326DC0
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1326CD0 Offset: 0x13252D0 VA: 0x181326CD0
	public void .ctor(BigInteger bi) { }

	[CLSCompliant(False)]
	// RVA: 0x1327150 Offset: 0x1325750 VA: 0x181327150
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1326E30 Offset: 0x1325430 VA: 0x181326E30
	public void .ctor(byte[] inData) { }

	[CLSCompliant(False)]
	// RVA: 0x13270C0 Offset: 0x13256C0 VA: 0x1813270C0
	public void .ctor(uint ui) { }

	[CLSCompliant(False)]
	// RVA: 0x13274B0 Offset: 0x1325AB0 VA: 0x1813274B0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1327510 Offset: 0x1325B10 VA: 0x181327510
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1327AE0 Offset: 0x13260E0 VA: 0x181327AE0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	// RVA: 0x1327770 Offset: 0x1325D70 VA: 0x181327770
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1327740 Offset: 0x1325D40 VA: 0x181327740
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1327300 Offset: 0x1325900 VA: 0x181327300
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x13277D0 Offset: 0x1325DD0 VA: 0x1813277D0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x13276F0 Offset: 0x1325CF0 VA: 0x1813276F0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1327AD0 Offset: 0x13260D0 VA: 0x181327AD0
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1327220 Offset: 0x1325820 VA: 0x181327220
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1325EE0 Offset: 0x13244E0 VA: 0x181325EE0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x13260E0 Offset: 0x13246E0 VA: 0x1813260E0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1325A80 Offset: 0x1324080 VA: 0x181325A80
	public int BitCount() { }

	// RVA: 0x1326700 Offset: 0x1324D00 VA: 0x181326700
	public bool TestBit(int bitNum) { }

	[CLSCompliant(False)]
	// RVA: 0x1326650 Offset: 0x1324C50 VA: 0x181326650
	public void SetBit(uint bitNum) { }

	[CLSCompliant(False)]
	// RVA: 0x13266A0 Offset: 0x1324CA0 VA: 0x1813266A0
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1326470 Offset: 0x1324A70 VA: 0x181326470
	public int LowestSetBit() { }

	// RVA: 0x13261F0 Offset: 0x13247F0 VA: 0x1813261F0
	public byte[] GetBytes() { }

	[CLSCompliant(False)]
	// RVA: 0x1327330 Offset: 0x1325930 VA: 0x181327330
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliant(False)]
	// RVA: 0x1327670 Offset: 0x1325C70 VA: 0x181327670
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x13273B0 Offset: 0x13259B0 VA: 0x1813273B0
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x13275B0 Offset: 0x1325BB0 VA: 0x1813275B0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1327490 Offset: 0x1325A90 VA: 0x181327490
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1327720 Offset: 0x1325D20 VA: 0x181327720
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1327470 Offset: 0x1325A70 VA: 0x181327470
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1327700 Offset: 0x1325D00 VA: 0x181327700
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	// RVA: 0x1326BB0 Offset: 0x13251B0 VA: 0x181326BB0
	public string ToString(uint radix) { }

	[CLSCompliant(False)]
	// RVA: 0x13267A0 Offset: 0x1324DA0 VA: 0x1813267A0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1326600 Offset: 0x1324C00 VA: 0x181326600
	private void Normalize() { }

	// RVA: 0x1325B30 Offset: 0x1324130 VA: 0x181325B30
	public void Clear() { }

	// RVA: 0x1326380 Offset: 0x1324980 VA: 0x181326380 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1326C00 Offset: 0x1325200 VA: 0x181326C00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1325B80 Offset: 0x1324180 VA: 0x181325B80 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1326560 Offset: 0x1324B60 VA: 0x181326560
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1326570 Offset: 0x1324B70 VA: 0x181326570
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x1325E70 Offset: 0x1324470 VA: 0x181325E70
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x13263C0 Offset: 0x13249C0 VA: 0x1813263C0
	public void Incr2() { }

	// RVA: 0x1326C40 Offset: 0x1325240 VA: 0x181326C40
	private static void .cctor() { }
}

