// Namespace: System.Runtime.ConstrainedExecution
public enum Cer // TypeDefIndex: 1117
{
	// Fields
	public int value__; // 0x0
	public const Cer None = 0;
	public const Cer MayFail = 1;
	public const Cer Success = 2;
}

// Namespace: System.Runtime.ConstrainedExecution
public enum Consistency // TypeDefIndex: 1118
{
	// Fields
	public int value__; // 0x0
	public const Consistency MayCorruptProcess = 0;
	public const Consistency MayCorruptAppDomain = 1;
	public const Consistency MayCorruptInstance = 2;
	public const Consistency WillNotCorruptState = 3;
}

// Namespace: System.Runtime.ConstrainedExecution
[Usage(1133, Inherited = False)]
public sealed class ReliabilityContractAttribute : Attribute // TypeDefIndex: 1119
{
	// Fields
	[CompilerGenerated]
	private readonly Consistency <ConsistencyGuarantee>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Cer <Cer>k__BackingField; // 0x14

	// Methods

	// RVA: 0x141C2E0 Offset: 0x141A8E0 VA: 0x18141C2E0
	public void .ctor(Consistency consistencyGuarantee, Cer cer) { }
}

// Namespace: System.Runtime.ConstrainedExecution
[Usage(96, Inherited = False)]
public sealed class PrePrepareMethodAttribute : Attribute // TypeDefIndex: 1120
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.ConstrainedExecution
public abstract class CriticalFinalizerObject // TypeDefIndex: 1121
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1415480 Offset: 0x1413A80 VA: 0x181415480 Slot: 1
	protected override void Finalize() { }
}

