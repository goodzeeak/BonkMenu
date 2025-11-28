// Namespace: Mono.Math.Prime
internal enum ConfidenceFactor // TypeDefIndex: 113
{
	// Fields
	public int value__; // 0x0
	public const ConfidenceFactor ExtraLow = 0;
	public const ConfidenceFactor Low = 1;
	public const ConfidenceFactor Medium = 2;
	public const ConfidenceFactor High = 3;
	public const ConfidenceFactor ExtraHigh = 4;
	public const ConfidenceFactor Provable = 5;
}

// Namespace: Mono.Math.Prime
internal sealed class PrimalityTest : MulticastDelegate // TypeDefIndex: 114
{
	// Methods

	// RVA: 0x132F8B0 Offset: 0x132DEB0 VA: 0x18132F8B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D4320 Offset: 0x5D2920 VA: 0x1805D4320 Slot: 13
	public virtual bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime
internal sealed class PrimalityTests // TypeDefIndex: 115
{
	// Methods

	// RVA: 0x13576C0 Offset: 0x1355CC0 VA: 0x1813576C0
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0x1357ED0 Offset: 0x13564D0 VA: 0x181357ED0
	public static bool Test(BigInteger n, ConfidenceFactor confidence) { }

	// RVA: 0x1357880 Offset: 0x1355E80 VA: 0x181357880
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }

	// RVA: 0x1357C30 Offset: 0x1356230 VA: 0x181357C30
	public static bool SmallPrimeSppTest(BigInteger bi, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime
public enum ConfidenceFactor // TypeDefIndex: 12889
{
	// Fields
	public int value__; // 0x0
	public const ConfidenceFactor ExtraLow = 0;
	public const ConfidenceFactor Low = 1;
	public const ConfidenceFactor Medium = 2;
	public const ConfidenceFactor High = 3;
	public const ConfidenceFactor ExtraHigh = 4;
	public const ConfidenceFactor Provable = 5;
}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTest : MulticastDelegate // TypeDefIndex: 12890
{
	// Methods

	// RVA: 0x132F8B0 Offset: 0x132DEB0 VA: 0x18132F8B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5D4320 Offset: 0x5D2920 VA: 0x1805D4320 Slot: 13
	public virtual bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTests // TypeDefIndex: 12891
{
	// Methods

	// RVA: 0x132F9D0 Offset: 0x132DFD0 VA: 0x18132F9D0
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0x132FB90 Offset: 0x132E190 VA: 0x18132FB90
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }
}

