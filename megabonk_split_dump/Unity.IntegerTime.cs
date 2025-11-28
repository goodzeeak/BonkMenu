// Namespace: Unity.IntegerTime
[Serializable]
public struct DiscreteTime : IEquatable<DiscreteTime>, IFormattable, IComparable<DiscreteTime> // TypeDefIndex: 9423
{
	// Fields
	[SerializeField]
	public long Value; // 0x0
	public static readonly DiscreteTime Zero; // 0x0
	public static readonly DiscreteTime MinValue; // 0x8
	public static readonly DiscreteTime MaxValue; // 0x10
	private static readonly int TicksPerSecondBits; // 0x18
	private static readonly int NonPow2TpsBits; // 0x1C

	// Methods

	// RVA: 0x22FA170 Offset: 0x22F8770 VA: 0x1822FA170
	public void .ctor(float v) { }

	// RVA: 0x22FA100 Offset: 0x22F8700 VA: 0x1822FA100
	public void .ctor(double v) { }

	// RVA: 0x58E930 Offset: 0x58CF30 VA: 0x18058E930
	private void .ctor(long v, int _) { }

	// RVA: 0x1561B10 Offset: 0x1560110 VA: 0x181561B10
	public static DiscreteTime FromTicks(long v) { }

	// RVA: 0x22FA250 Offset: 0x22F8850 VA: 0x1822FA250
	public static float op_Explicit(DiscreteTime d) { }

	// RVA: 0x22FA230 Offset: 0x22F8830 VA: 0x1822FA230
	public static double op_Explicit(DiscreteTime d) { }

	// RVA: 0x22FA290 Offset: 0x22F8890 VA: 0x1822FA290
	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x22FA280 Offset: 0x22F8880 VA: 0x1822FA280
	public static bool op_GreaterThan(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x22FA270 Offset: 0x22F8870 VA: 0x1822FA270
	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x22FA1E0 Offset: 0x22F87E0 VA: 0x1822FA1E0
	public static DiscreteTime op_Addition(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x22FA2A0 Offset: 0x22F88A0 VA: 0x1822FA2A0
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	[IsReadOnly]
	// RVA: 0x9BD870 Offset: 0x9BBE70 VA: 0x1809BD870 Slot: 4
	public bool Equals(DiscreteTime rhs) { }

	[IsReadOnly]
	// RVA: 0x22F9E20 Offset: 0x22F8420 VA: 0x1822F9E20 Slot: 0
	public override bool Equals(object o) { }

	[IsReadOnly]
	// RVA: 0x22F9EB0 Offset: 0x22F84B0 VA: 0x1822F9EB0 Slot: 2
	public override int GetHashCode() { }

	[IsReadOnly]
	// RVA: 0x22F9F50 Offset: 0x22F8550 VA: 0x1822F9F50 Slot: 3
	public override string ToString() { }

	[IsReadOnly]
	// RVA: 0x22F9EC0 Offset: 0x22F84C0 VA: 0x1822F9EC0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	[IsReadOnly]
	// RVA: 0x22F9E10 Offset: 0x22F8410 VA: 0x1822F9E10 Slot: 6
	public int CompareTo(DiscreteTime other) { }

	// RVA: 0x22F9FC0 Offset: 0x22F85C0 VA: 0x1822F9FC0
	private static void .cctor() { }
}

// Namespace: Unity.IntegerTime
[NativeHeader("Runtime/Input/RationalTime.h")]
[Serializable]
public struct RationalTime // TypeDefIndex: 9425
{
	// Fields
	[SerializeField]
	private long m_Count; // 0x0
	[SerializeField]
	private RationalTime.TicksPerSecond m_TicksPerSecond; // 0x8

	// Properties
	public long Count { get; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public long get_Count() { }

	// RVA: 0x230EBE0 Offset: 0x230D1E0 VA: 0x18230EBE0
	public static DiscreteTime op_Explicit(RationalTime t) { }
}

// Namespace: Unity.IntegerTime
[Extension]
public static class RationalTimeExtensions // TypeDefIndex: 9426
{
	// Methods

	[Extension]
	[FreeFunction("IntegerTime::RationalTime::ConvertRate", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x230EB80 Offset: 0x230D180 VA: 0x18230EB80
	public static RationalTime Convert(RationalTime time, RationalTime.TicksPerSecond rate) { }

	// RVA: 0x230EB20 Offset: 0x230D120 VA: 0x18230EB20
	private static void Convert_Injected(in RationalTime time, in RationalTime.TicksPerSecond rate, out RationalTime ret) { }
}

