// Namespace: Mono.Math.Prime.Generator
internal abstract class PrimeGeneratorBase // TypeDefIndex: 116
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1357F20 Offset: 0x1356520 VA: 0x181357F20 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1330320 Offset: 0x132E920 VA: 0x181330320 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Mono.Math.Prime.Generator
internal class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 117
{
	// Methods

	// RVA: 0x135D6A0 Offset: 0x135BCA0 VA: 0x18135D6A0 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x1333EB0 Offset: 0x13324B0 VA: 0x181333EB0 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x135D2F0 Offset: 0x135B8F0 VA: 0x18135D2F0 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Mono.Math.Prime.Generator
public abstract class PrimeGeneratorBase // TypeDefIndex: 12892
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x13301E0 Offset: 0x132E7E0 VA: 0x1813301E0 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1330320 Offset: 0x132E920 VA: 0x181330320 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Mono.Math.Prime.Generator
public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 12893
{
	// Methods

	// RVA: 0x1333ED0 Offset: 0x13324D0 VA: 0x181333ED0 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x1333EB0 Offset: 0x13324B0 VA: 0x181333EB0 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x1333B00 Offset: 0x1332100 VA: 0x181333B00 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

