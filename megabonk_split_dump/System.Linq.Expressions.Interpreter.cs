// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AddInstruction : Instruction // TypeDefIndex: 10894
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A06B70 Offset: 0x1A05170 VA: 0x181A06B70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A066F0 Offset: 0x1A04CF0 VA: 0x181A066F0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AddOvfInstruction : Instruction // TypeDefIndex: 10901
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A07340 Offset: 0x1A05940 VA: 0x181A07340 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A06FA0 Offset: 0x1A055A0 VA: 0x181A06FA0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AndInstruction : Instruction // TypeDefIndex: 10911
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A08EA0 Offset: 0x1A074A0 VA: 0x181A08EA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A089A0 Offset: 0x1A06FA0 VA: 0x181A089A0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayInitInstruction : Instruction // TypeDefIndex: 10912
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _elementCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1415660 Offset: 0x1413C60 VA: 0x181415660
	internal void .ctor(Type elementType, int elementCount) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A1F600 Offset: 0x1A1DC00 VA: 0x181A1F600 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A1F570 Offset: 0x1A1DB70 VA: 0x181A1F570 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayInstruction : Instruction // TypeDefIndex: 10913
{
	// Fields
	private readonly Type _elementType; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	internal void .ctor(Type elementType) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A1F6C0 Offset: 0x1A1DCC0 VA: 0x181A1F6C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A1F630 Offset: 0x1A1DC30 VA: 0x181A1F630 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayBoundsInstruction : Instruction // TypeDefIndex: 10914
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _rank; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1415660 Offset: 0x1413C60 VA: 0x181415660
	internal void .ctor(Type elementType, int rank) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A1F290 Offset: 0x1A1D890 VA: 0x181A1F290 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A1F170 Offset: 0x1A1D770 VA: 0x181A1F170 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class GetArrayItemInstruction : Instruction // TypeDefIndex: 10915
{
	// Fields
	internal static readonly GetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A1B080 Offset: 0x1A19680 VA: 0x181A1B080 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A1AF70 Offset: 0x1A19570 VA: 0x181A1AF70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A1B010 Offset: 0x1A19610 VA: 0x181A1B010
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class SetArrayItemInstruction : Instruction // TypeDefIndex: 10916
{
	// Fields
	internal static readonly SetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A20D30 Offset: 0x1A1F330 VA: 0x181A20D30 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A20C00 Offset: 0x1A1F200 VA: 0x181A20C00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A20CC0 Offset: 0x1A1F2C0 VA: 0x181A20CC0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ArrayLengthInstruction : Instruction // TypeDefIndex: 10917
{
	// Fields
	public static readonly ArrayLengthInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A095A0 Offset: 0x1A07BA0 VA: 0x181A095A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A094B0 Offset: 0x1A07AB0 VA: 0x181A094B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A09530 Offset: 0x1A07B30 VA: 0x181A09530
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class ConvertHelper // TypeDefIndex: 10918
{
	// Methods

	// RVA: 0x1A0CDF0 Offset: 0x1A0B3F0 VA: 0x181A0CDF0
	public static int ToInt32NoNull(object val) { }
}

// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
internal struct RuntimeLabel // TypeDefIndex: 10919
{
	// Fields
	public readonly int Index; // 0x0
	public readonly int StackDepth; // 0x4
	public readonly int ContinuationStackDepth; // 0x8

	// Methods

	// RVA: 0x1A20580 Offset: 0x1A1EB80 VA: 0x181A20580
	public void .ctor(int index, int continuationStackDepth, int stackDepth) { }

	// RVA: 0x1A204A0 Offset: 0x1A1EAA0 VA: 0x181A204A0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchLabel // TypeDefIndex: 10920
{
	// Fields
	private int _targetIndex; // 0x10
	private int _stackDepth; // 0x14
	private int _continuationStackDepth; // 0x18
	private List<int> _forwardBranchFixups; // 0x20
	[CompilerGenerated]
	private int <LabelIndex>k__BackingField; // 0x28

	// Properties
	internal int LabelIndex { get; set; }
	internal bool HasRuntimeLabel { get; }
	internal int TargetIndex { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	internal int get_LabelIndex() { }

	[CompilerGenerated]
	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	internal void set_LabelIndex(int value) { }

	// RVA: 0x1A0B2C0 Offset: 0x1A098C0 VA: 0x181A0B2C0
	internal bool get_HasRuntimeLabel() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	internal int get_TargetIndex() { }

	// RVA: 0x1A0B270 Offset: 0x1A09870 VA: 0x181A0B270
	internal RuntimeLabel ToRuntimeLabel() { }

	// RVA: 0x1A0B110 Offset: 0x1A09710 VA: 0x181A0B110
	internal void Mark(InstructionList instructions) { }

	// RVA: 0x1A0AFB0 Offset: 0x1A095B0 VA: 0x181A0AFB0
	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x1A0B0E0 Offset: 0x1A096E0 VA: 0x181A0B0E0
	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x1A0B290 Offset: 0x1A09890 VA: 0x181A0B290
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class CallInstruction : Instruction // TypeDefIndex: 10921
{
	// Properties
	public abstract int ArgumentCount { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_ArgumentCount();

	// RVA: 0x1A0C390 Offset: 0x1A0A990 VA: 0x181A0C390 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0BAB0 Offset: 0x1A0A0B0 VA: 0x181A0BAB0
	public static CallInstruction Create(MethodInfo info) { }

	// RVA: 0x1A0BB10 Offset: 0x1A0A110 VA: 0x181A0BB10
	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) { }

	// RVA: 0x1A0BCB0 Offset: 0x1A0A2B0 VA: 0x181A0BCB0
	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) { }

	// RVA: 0x1A0BA10 Offset: 0x1A0A010 VA: 0x181A0BA10
	public static void ArrayItemSetter1(Array array, int index0, object value) { }

	// RVA: 0x1A0BA40 Offset: 0x1A0A040 VA: 0x181A0BA40
	public static void ArrayItemSetter2(Array array, int index0, int index1, object value) { }

	// RVA: 0x1A0BA70 Offset: 0x1A0A070 VA: 0x181A0BA70
	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) { }

	// RVA: 0x187F8A0 Offset: 0x187DEA0 VA: 0x18187F8A0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0C230 Offset: 0x1A0A830 VA: 0x181A0C230
	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) { }

	// RVA: 0x1A0C1D0 Offset: 0x1A0A7D0 VA: 0x181A0C1D0
	protected object InterpretLambdaInvoke(LightLambda targetLambda, object[] args) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class MethodInfoCallInstruction : CallInstruction // TypeDefIndex: 10922
{
	// Fields
	protected readonly MethodInfo _target; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ArgumentCount { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 11
	public override int get_ArgumentCount() { }

	// RVA: 0x1415660 Offset: 0x1413C60 VA: 0x181415660
	internal void .ctor(MethodInfo target, int argumentCount) { }

	// RVA: 0x1A0B980 Offset: 0x1A09F80 VA: 0x181A0B980 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A1EE40 Offset: 0x1A1D440 VA: 0x181A1EE40 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A1ECC0 Offset: 0x1A1D2C0 VA: 0x181A1ECC0
	protected object[] GetArgs(InterpretedFrame frame, int first, int skip) { }

	// RVA: 0x1A1F0E0 Offset: 0x1A1D6E0 VA: 0x181A1F0E0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction // TypeDefIndex: 10923
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1A0B920 Offset: 0x1A09F20 VA: 0x181A0B920
	internal void .ctor(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1A0B980 Offset: 0x1A09F80 VA: 0x181A0B980 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0B400 Offset: 0x1A09A00 VA: 0x181A0B400 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class OffsetInstruction : Instruction // TypeDefIndex: 10924
{
	// Fields
	protected int _offset; // 0x10

	// Properties
	public abstract Instruction[] Cache { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Instruction[] get_Cache();

	// RVA: 0x1A1FA80 Offset: 0x1A1E080 VA: 0x181A1FA80
	public Instruction Fixup(int offset) { }

	// RVA: 0x1A1FB30 Offset: 0x1A1E130 VA: 0x181A1FB30 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1A1FBF0 Offset: 0x1A1E1F0 VA: 0x181A1FBF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A0AB60 Offset: 0x1A09160 VA: 0x181A0AB60
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchFalseInstruction : OffsetInstruction // TypeDefIndex: 10925
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1A0AB70 Offset: 0x1A09170 VA: 0x181A0AB70 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x1A0AC00 Offset: 0x1A09200 VA: 0x181A0AC00 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0AAF0 Offset: 0x1A090F0 VA: 0x181A0AAF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0AB60 Offset: 0x1A09160 VA: 0x181A0AB60
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchTrueInstruction : OffsetInstruction // TypeDefIndex: 10926
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1A0B340 Offset: 0x1A09940 VA: 0x181A0B340 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x1A0B3D0 Offset: 0x1A099D0 VA: 0x181A0B3D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0B2D0 Offset: 0x1A098D0 VA: 0x181A0B2D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0AB60 Offset: 0x1A09160 VA: 0x181A0AB60
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CoalescingBranchInstruction : OffsetInstruction // TypeDefIndex: 10927
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1A0C5F0 Offset: 0x1A0ABF0 VA: 0x181A0C5F0 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x1A0C680 Offset: 0x1A0AC80 VA: 0x181A0C680 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0C5B0 Offset: 0x1A0ABB0 VA: 0x181A0C5B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0AB60 Offset: 0x1A09160 VA: 0x181A0AB60
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class BranchInstruction : OffsetInstruction // TypeDefIndex: 10928
{
	// Fields
	private static Instruction[][][] s_caches; // 0x0
	internal readonly bool _hasResult; // 0x18
	internal readonly bool _hasValue; // 0x19

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1A0ACA0 Offset: 0x1A092A0 VA: 0x181A0ACA0 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x1A0AC30 Offset: 0x1A09230 VA: 0x181A0AC30
	internal void .ctor() { }

	// RVA: 0x1A0AC60 Offset: 0x1A09260 VA: 0x181A0AC60
	public void .ctor(bool hasResult, bool hasValue) { }

	// RVA: 0x1A0AF70 Offset: 0x1A09570 VA: 0x181A0AF70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0AF60 Offset: 0x1A09560 VA: 0x181A0AF60 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0AFA0 Offset: 0x1A095A0 VA: 0x181A0AFA0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class IndexedBranchInstruction : Instruction // TypeDefIndex: 10929
{
	// Fields
	internal readonly int _labelIndex; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(int labelIndex) { }

	// RVA: 0x1A1B840 Offset: 0x1A19E40 VA: 0x181A1B840
	public RuntimeLabel GetLabel(InterpretedFrame frame) { }

	// RVA: 0x1A1B8A0 Offset: 0x1A19EA0 VA: 0x181A1B8A0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1A1B960 Offset: 0x1A19F60 VA: 0x181A1B960 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class GotoInstruction : IndexedBranchInstruction // TypeDefIndex: 10930
{
	// Fields
	private static readonly GotoInstruction[] s_cache; // 0x0
	private readonly bool _hasResult; // 0x18
	private readonly bool _hasValue; // 0x19
	private readonly bool _labelTargetGetsValue; // 0x1A

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1A1B570 Offset: 0x1A19B70 VA: 0x181A1B570 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0AF60 Offset: 0x1A09560 VA: 0x181A0AF60 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0AFA0 Offset: 0x1A095A0 VA: 0x181A0AFA0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A1B520 Offset: 0x1A19B20 VA: 0x181A1B520
	private void .ctor(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x1A1B260 Offset: 0x1A19860 VA: 0x181A1B260
	internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x1A1B3D0 Offset: 0x1A199D0 VA: 0x181A1B3D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A1B4B0 Offset: 0x1A19AB0 VA: 0x181A1B4B0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 10931
{
	// Fields
	private readonly bool _hasFinally; // 0x18
	private TryCatchFinallyHandler _tryHandler; // 0x20

	// Properties
	internal TryCatchFinallyHandler Handler { get; }
	public override int ProducedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	internal TryCatchFinallyHandler get_Handler() { }

	// RVA: 0x1A0AFA0 Offset: 0x1A095A0 VA: 0x181A0AFA0 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x1A0F670 Offset: 0x1A0DC70 VA: 0x181A0F670
	private void .ctor(int targetIndex, bool hasFinally) { }

	// RVA: 0x1A0F070 Offset: 0x1A0D670 VA: 0x181A0F070
	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	// RVA: 0x1A0F020 Offset: 0x1A0D620 VA: 0x181A0F020
	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	// RVA: 0x1A0F0D0 Offset: 0x1A0D6D0 VA: 0x181A0F0D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0F6B0 Offset: 0x1A0DCB0 VA: 0x181A0F6B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0F5F0 Offset: 0x1A0DBF0 VA: 0x181A0F5F0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 10932
{
	// Fields
	private TryFaultHandler _tryHandler; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ProducedContinuations { get; }
	internal TryFaultHandler Handler { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int targetIndex) { }

	// RVA: 0x1A0F9B0 Offset: 0x1A0DFB0 VA: 0x181A0F9B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal TryFaultHandler get_Handler() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void SetTryHandler(TryFaultHandler tryHandler) { }

	// RVA: 0x1A0F700 Offset: 0x1A0DD00 VA: 0x181A0F700 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 10933
{
	// Fields
	private static readonly EnterFinallyInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedContinuations { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	private void .ctor(int labelIndex) { }

	// RVA: 0x1A0EFF0 Offset: 0x1A0D5F0 VA: 0x181A0EFF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x1A0EDD0 Offset: 0x1A0D3D0 VA: 0x181A0EDD0
	internal static EnterFinallyInstruction Create(int labelIndex) { }

	// RVA: 0x1A0EEE0 Offset: 0x1A0D4E0 VA: 0x181A0EEE0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0EF80 Offset: 0x1A0D580 VA: 0x181A0EF80
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveFinallyInstruction : Instruction // TypeDefIndex: 10934
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A1D870 Offset: 0x1A1BE70 VA: 0x181A1D870 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A1D7B0 Offset: 0x1A1BDB0 VA: 0x181A1D7B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A1D800 Offset: 0x1A1BE00 VA: 0x181A1D800
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 10935
{
	// Fields
	private static readonly EnterFaultInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	private void .ctor(int labelIndex) { }

	// RVA: 0x1A0EDA0 Offset: 0x1A0D3A0 VA: 0x181A0EDA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0EBA0 Offset: 0x1A0D1A0 VA: 0x181A0EBA0
	internal static EnterFaultInstruction Create(int labelIndex) { }

	// RVA: 0x1A0ECB0 Offset: 0x1A0D2B0 VA: 0x181A0ECB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0ED30 Offset: 0x1A0D330 VA: 0x181A0ED30
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveFaultInstruction : Instruction // TypeDefIndex: 10936
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ConsumedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x1A1D780 Offset: 0x1A1BD80 VA: 0x181A1D780 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A1D6E0 Offset: 0x1A1BCE0 VA: 0x181A1D6E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A1D710 Offset: 0x1A1BD10 VA: 0x181A1D710
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterExceptionFilterInstruction : Instruction // TypeDefIndex: 10937
{
	// Fields
	internal static readonly EnterExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A0EA70 Offset: 0x1A0D070 VA: 0x181A0EA70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0EA00 Offset: 0x1A0D000 VA: 0x181A0EA00
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveExceptionFilterInstruction : Instruction // TypeDefIndex: 10938
{
	// Fields
	internal static readonly LeaveExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A1D480 Offset: 0x1A1BA80 VA: 0x181A1D480 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A1D410 Offset: 0x1A1BA10 VA: 0x181A1D410
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterExceptionHandlerInstruction : Instruction // TypeDefIndex: 10939
{
	// Fields
	internal static readonly EnterExceptionHandlerInstruction Void; // 0x0
	internal static readonly EnterExceptionHandlerInstruction NonVoid; // 0x8
	private readonly bool _hasValue; // 0x10

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	private void .ctor(bool hasValue) { }

	// RVA: 0x1A0EB70 Offset: 0x1A0D170 VA: 0x181A0EB70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0EB60 Offset: 0x1A0D160 VA: 0x181A0EB60 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0EAA0 Offset: 0x1A0D0A0 VA: 0x181A0EAA0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction // TypeDefIndex: 10940
{
	// Fields
	private static readonly LeaveExceptionHandlerInstruction[] s_cache; // 0x0
	private readonly bool _hasValue; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1A0F670 Offset: 0x1A0DC70 VA: 0x181A0F670
	private void .ctor(int labelIndex, bool hasValue) { }

	// RVA: 0x1A1D6B0 Offset: 0x1A1BCB0 VA: 0x181A1D6B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0AFA0 Offset: 0x1A095A0 VA: 0x181A0AFA0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0AFA0 Offset: 0x1A095A0 VA: 0x181A0AFA0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A1D4B0 Offset: 0x1A1BAB0 VA: 0x181A1D4B0
	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) { }

	// RVA: 0x1A1D5F0 Offset: 0x1A1BBF0 VA: 0x181A1D5F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A1D640 Offset: 0x1A1BC40 VA: 0x181A1D640
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ThrowInstruction : Instruction // TypeDefIndex: 10941
{
	// Fields
	internal static readonly ThrowInstruction Throw; // 0x0
	internal static readonly ThrowInstruction VoidThrow; // 0x8
	internal static readonly ThrowInstruction Rethrow; // 0x10
	internal static readonly ThrowInstruction VoidRethrow; // 0x18
	private readonly bool _hasResult; // 0x10
	private readonly bool _rethrow; // 0x11

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1A23400 Offset: 0x1A21A00 VA: 0x181A23400
	private void .ctor(bool hasResult, bool isRethrow) { }

	// RVA: 0x1A23440 Offset: 0x1A21A40 VA: 0x181A23440 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0EB60 Offset: 0x1A0D160 VA: 0x181A0EB60 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A230D0 Offset: 0x1A216D0 VA: 0x181A230D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A23200 Offset: 0x1A21800 VA: 0x181A23200
	private static Exception WrapThrownObject(object thrown) { }

	// RVA: 0x1A232B0 Offset: 0x1A218B0 VA: 0x181A232B0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class IntSwitchInstruction<T> : Instruction // TypeDefIndex: 10942
{
	// Fields
	private readonly Dictionary<T, int> _cases; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	|-IntSwitchInstruction<int>..ctor
	|-IntSwitchInstruction<object>..ctor
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override string get_InstructionName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C06B0 Offset: 0x10BECB0 VA: 0x1810C06B0
	|-IntSwitchInstruction<int>.get_InstructionName
	|
	|-RVA: 0x10C06E0 Offset: 0x10BECE0 VA: 0x1810C06E0
	|-IntSwitchInstruction<object>.get_InstructionName
	|
	|-RVA: 0x10C0710 Offset: 0x10BED10 VA: 0x1810C0710
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.get_InstructionName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override int get_ConsumedStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	|-IntSwitchInstruction<int>.get_ConsumedStack
	|-IntSwitchInstruction<object>.get_ConsumedStack
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.get_ConsumedStack
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override int Run(InterpretedFrame frame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C03E0 Offset: 0x10BE9E0 VA: 0x1810C03E0
	|-IntSwitchInstruction<int>.Run
	|
	|-RVA: 0x10C05F0 Offset: 0x10BEBF0 VA: 0x1810C05F0
	|-IntSwitchInstruction<object>.Run
	|
	|-RVA: 0x10C04B0 Offset: 0x10BEAB0 VA: 0x1810C04B0
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.Run
	*/
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StringSwitchInstruction : Instruction // TypeDefIndex: 10943
{
	// Fields
	private readonly Dictionary<string, int> _cases; // 0x10
	private readonly StrongBox<int> _nullCase; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	internal void .ctor(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x1A20EA0 Offset: 0x1A1F4A0 VA: 0x181A20EA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A20DD0 Offset: 0x1A1F3D0 VA: 0x181A20DD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class DecrementInstruction : Instruction // TypeDefIndex: 10952
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0D450 Offset: 0x1A0BA50 VA: 0x181A0D450 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A0CFD0 Offset: 0x1A0B5D0 VA: 0x181A0CFD0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DefaultValueInstruction : Instruction // TypeDefIndex: 10953
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	internal void .ctor(Type type) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0D980 Offset: 0x1A0BF80 VA: 0x181A0D980 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0D8E0 Offset: 0x1A0BEE0 VA: 0x181A0D8E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0D920 Offset: 0x1A0BF20 VA: 0x181A0D920 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class DivInstruction : Instruction // TypeDefIndex: 10962
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0DF90 Offset: 0x1A0C590 VA: 0x181A0DF90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A0DB10 Offset: 0x1A0C110 VA: 0x181A0DB10
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class EqualInstruction : Instruction // TypeDefIndex: 10988
{
	// Fields
	private static Instruction s_reference; // 0x0
	private static Instruction s_Boolean; // 0x8
	private static Instruction s_SByte; // 0x10
	private static Instruction s_Int16; // 0x18
	private static Instruction s_Char; // 0x20
	private static Instruction s_Int32; // 0x28
	private static Instruction s_Int64; // 0x30
	private static Instruction s_Byte; // 0x38
	private static Instruction s_UInt16; // 0x40
	private static Instruction s_UInt32; // 0x48
	private static Instruction s_UInt64; // 0x50
	private static Instruction s_Single; // 0x58
	private static Instruction s_Double; // 0x60
	private static Instruction s_BooleanLiftedToNull; // 0x68
	private static Instruction s_SByteLiftedToNull; // 0x70
	private static Instruction s_Int16LiftedToNull; // 0x78
	private static Instruction s_CharLiftedToNull; // 0x80
	private static Instruction s_Int32LiftedToNull; // 0x88
	private static Instruction s_Int64LiftedToNull; // 0x90
	private static Instruction s_ByteLiftedToNull; // 0x98
	private static Instruction s_UInt16LiftedToNull; // 0xA0
	private static Instruction s_UInt32LiftedToNull; // 0xA8
	private static Instruction s_UInt64LiftedToNull; // 0xB0
	private static Instruction s_SingleLiftedToNull; // 0xB8
	private static Instruction s_DoubleLiftedToNull; // 0xC0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A10B90 Offset: 0x1A0F190 VA: 0x181A10B90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A0FF90 Offset: 0x1A0E590 VA: 0x181A0FF90
	public static Instruction Create(Type type, bool liftedToNull) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ExclusiveOrInstruction : Instruction // TypeDefIndex: 10998
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A27450 Offset: 0x1A25A50 VA: 0x181A27450 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x1A26F50 Offset: 0x1A25550 VA: 0x181A26F50
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class FieldInstruction : Instruction // TypeDefIndex: 10999
{
	// Fields
	protected readonly FieldInfo _field; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1A27EF0 Offset: 0x1A264F0 VA: 0x181A27EF0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadStaticFieldInstruction : FieldInstruction // TypeDefIndex: 11000
{
	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1A48FE0 Offset: 0x1A475E0 VA: 0x181A48FE0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A48F20 Offset: 0x1A47520 VA: 0x181A48F20 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadFieldInstruction : FieldInstruction // TypeDefIndex: 11001
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1A48EF0 Offset: 0x1A474F0 VA: 0x181A48EF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A48DF0 Offset: 0x1A473F0 VA: 0x181A48DF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreFieldInstruction : FieldInstruction // TypeDefIndex: 11002
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1A490E0 Offset: 0x1A476E0 VA: 0x181A490E0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A49060 Offset: 0x1A47660 VA: 0x181A49060 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreStaticFieldInstruction : FieldInstruction // TypeDefIndex: 11003
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x1A49170 Offset: 0x1A47770 VA: 0x181A49170 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A49110 Offset: 0x1A47710 VA: 0x181A49110 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class GreaterThanInstruction : Instruction // TypeDefIndex: 11015
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A29240 Offset: 0x1A27840 VA: 0x181A29240 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	private void .ctor(object nullValue) { }

	// RVA: 0x1A283E0 Offset: 0x1A269E0 VA: 0x181A283E0
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class GreaterThanOrEqualInstruction : Instruction // TypeDefIndex: 11027
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A2A970 Offset: 0x1A28F70 VA: 0x181A2A970 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	private void .ctor(object nullValue) { }

	// RVA: 0x1A29B10 Offset: 0x1A28110 VA: 0x181A29B10
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class IncrementInstruction : Instruction // TypeDefIndex: 11036
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A2C230 Offset: 0x1A2A830 VA: 0x181A2C230 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x1A2BDB0 Offset: 0x1A2A3B0 VA: 0x181A2BDB0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class Instruction // TypeDefIndex: 11037
{
	// Properties
	public virtual int ConsumedStack { get; }
	public virtual int ProducedStack { get; }
	public virtual int ConsumedContinuations { get; }
	public virtual int ProducedContinuations { get; }
	public int StackBalance { get; }
	public int ContinuationsBalance { get; }
	public abstract string InstructionName { get; }

	// Methods

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 4
	public virtual int get_ConsumedStack() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public virtual int get_ProducedStack() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	public virtual int get_ConsumedContinuations() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 7
	public virtual int get_ProducedContinuations() { }

	// RVA: 0x1A31950 Offset: 0x1A2FF50 VA: 0x181A31950
	public int get_StackBalance() { }

	// RVA: 0x1A31900 Offset: 0x1A2FF00 VA: 0x181A31900
	public int get_ContinuationsBalance() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int Run(InterpretedFrame frame);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_InstructionName();

	// RVA: 0x1A318A0 Offset: 0x1A2FEA0 VA: 0x181A318A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x14B4000 Offset: 0x14B2600 VA: 0x1814B4000 Slot: 10
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1A31880 Offset: 0x1A2FE80 VA: 0x181A31880
	protected static void NullCheck(object o) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
[DebuggerTypeProxy(typeof(InstructionArray.DebugView))]
[IsReadOnly]
internal struct InstructionArray // TypeDefIndex: 11039
{
	// Fields
	internal readonly int MaxStackDepth; // 0x0
	internal readonly int MaxContinuationDepth; // 0x4
	internal readonly Instruction[] Instructions; // 0x8
	internal readonly object[] Objects; // 0x10
	internal readonly RuntimeLabel[] Labels; // 0x18
	internal readonly List<KeyValuePair<int, object>> DebugCookies; // 0x20

	// Methods

	// RVA: 0x1A2CB70 Offset: 0x1A2B170 VA: 0x181A2CB70
	internal void .ctor(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, object[] objects, RuntimeLabel[] labels, List<KeyValuePair<int, object>> debugCookies) { }
}

// Namespace: System.Linq.Expressions.Interpreter
[DebuggerTypeProxy(typeof(InstructionList.DebugView))]
internal sealed class InstructionList // TypeDefIndex: 11042
{
	// Fields
	private readonly List<Instruction> _instructions; // 0x10
	private List<object> _objects; // 0x18
	private int _currentStackDepth; // 0x20
	private int _maxStackDepth; // 0x24
	private int _currentContinuationsDepth; // 0x28
	private int _maxContinuationDepth; // 0x2C
	private int _runtimeLabelCount; // 0x30
	private List<BranchLabel> _labels; // 0x38
	private List<KeyValuePair<int, object>> _debugCookies; // 0x40
	private static Instruction s_null; // 0x0
	private static Instruction s_true; // 0x8
	private static Instruction s_false; // 0x10
	private static Instruction[] s_Ints; // 0x18
	private static Instruction[] s_loadObjectCached; // 0x20
	private static Instruction[] s_loadLocal; // 0x28
	private static Instruction[] s_loadLocalBoxed; // 0x30
	private static Instruction[] s_loadLocalFromClosure; // 0x38
	private static Instruction[] s_loadLocalFromClosureBoxed; // 0x40
	private static Instruction[] s_assignLocal; // 0x48
	private static Instruction[] s_storeLocal; // 0x50
	private static Instruction[] s_assignLocalBoxed; // 0x58
	private static Instruction[] s_storeLocalBoxed; // 0x60
	private static Instruction[] s_assignLocalToClosure; // 0x68
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; // 0x70
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; // 0x78

	// Properties
	public int Count { get; }
	public int CurrentStackDepth { get; }
	public int CurrentContinuationsDepth { get; }

	// Methods

	// RVA: 0x1A305E0 Offset: 0x1A2EBE0 VA: 0x181A305E0
	public void Emit(Instruction instruction) { }

	// RVA: 0x1A31570 Offset: 0x1A2FB70 VA: 0x181A31570
	private void UpdateStackDepth(Instruction instruction) { }

	// RVA: 0x1A31450 Offset: 0x1A2FA50 VA: 0x181A31450
	public void UnEmit() { }

	// RVA: 0x1A317E0 Offset: 0x1A2FDE0 VA: 0x181A317E0
	public int get_Count() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public int get_CurrentStackDepth() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public int get_CurrentContinuationsDepth() { }

	// RVA: 0x1A30860 Offset: 0x1A2EE60 VA: 0x181A30860
	internal Instruction GetInstruction(int index) { }

	// RVA: 0x1A31320 Offset: 0x1A2F920 VA: 0x181A31320
	public InstructionArray ToArray() { }

	// RVA: 0x1A2F820 Offset: 0x1A2DE20 VA: 0x181A2F820
	public void EmitLoad(object value) { }

	// RVA: 0x1A2F630 Offset: 0x1A2DC30 VA: 0x181A2F630
	public void EmitLoad(bool value) { }

	// RVA: 0x1A2F020 Offset: 0x1A2D620 VA: 0x181A2F020
	public void EmitLoad(object value, Type type) { }

	// RVA: 0x1A2DEC0 Offset: 0x1A2C4C0 VA: 0x181A2DEC0
	public void EmitDup() { }

	// RVA: 0x1A2FDC0 Offset: 0x1A2E3C0 VA: 0x181A2FDC0
	public void EmitPop() { }

	// RVA: 0x1A31260 Offset: 0x1A2F860 VA: 0x181A31260
	internal void SwitchToBoxed(int index, int instructionIndex) { }

	// RVA: 0x1A2EE00 Offset: 0x1A2D400 VA: 0x181A2EE00
	public void EmitLoadLocal(int index) { }

	// RVA: 0x1A2E950 Offset: 0x1A2CF50 VA: 0x181A2E950
	public void EmitLoadLocalBoxed(int index) { }

	// RVA: 0x1A30BC0 Offset: 0x1A2F1C0 VA: 0x181A30BC0
	internal static Instruction LoadLocalBoxed(int index) { }

	// RVA: 0x1A2EBE0 Offset: 0x1A2D1E0 VA: 0x181A2EBE0
	public void EmitLoadLocalFromClosure(int index) { }

	// RVA: 0x1A2E9C0 Offset: 0x1A2CFC0 VA: 0x181A2E9C0
	public void EmitLoadLocalFromClosureBoxed(int index) { }

	// RVA: 0x1A2D3B0 Offset: 0x1A2B9B0 VA: 0x181A2D3B0
	public void EmitAssignLocal(int index) { }

	// RVA: 0x1A30100 Offset: 0x1A2E700 VA: 0x181A30100
	public void EmitStoreLocal(int index) { }

	// RVA: 0x1A2D120 Offset: 0x1A2B720 VA: 0x181A2D120
	public void EmitAssignLocalBoxed(int index) { }

	// RVA: 0x1A2CBD0 Offset: 0x1A2B1D0 VA: 0x181A2CBD0
	internal static Instruction AssignLocalBoxed(int index) { }

	// RVA: 0x1A30020 Offset: 0x1A2E620 VA: 0x181A30020
	public void EmitStoreLocalBoxed(int index) { }

	// RVA: 0x1A31050 Offset: 0x1A2F650 VA: 0x181A31050
	internal static Instruction StoreLocalBoxed(int index) { }

	// RVA: 0x1A2D190 Offset: 0x1A2B790 VA: 0x181A2D190
	public void EmitAssignLocalToClosure(int index) { }

	// RVA: 0x1A30090 Offset: 0x1A2E690 VA: 0x181A30090
	public void EmitStoreLocalToClosure(int index) { }

	// RVA: 0x1A2E4D0 Offset: 0x1A2CAD0 VA: 0x181A2E4D0
	public void EmitInitializeLocal(int index, Type type) { }

	// RVA: 0x1A2E610 Offset: 0x1A2CC10 VA: 0x181A2E610
	internal void EmitInitializeParameter(int index) { }

	// RVA: 0x1A30FF0 Offset: 0x1A2F5F0 VA: 0x181A30FF0
	internal static Instruction Parameter(int index) { }

	// RVA: 0x1A30F90 Offset: 0x1A2F590 VA: 0x181A30F90
	internal static Instruction ParameterBox(int index) { }

	// RVA: 0x1A30B60 Offset: 0x1A2F160 VA: 0x181A30B60
	internal static Instruction InitReference(int index) { }

	// RVA: 0x1A30B00 Offset: 0x1A2F100 VA: 0x181A30B00
	internal static Instruction InitImmutableRefBox(int index) { }

	// RVA: 0x1A2FA70 Offset: 0x1A2E070 VA: 0x181A2FA70
	public void EmitNewRuntimeVariables(int count) { }

	// RVA: 0x1A2E300 Offset: 0x1A2C900 VA: 0x181A2E300
	public void EmitGetArrayItem() { }

	// RVA: 0x1A2FF10 Offset: 0x1A2E510 VA: 0x181A2FF10
	public void EmitSetArrayItem() { }

	// RVA: 0x1A2FA00 Offset: 0x1A2E000 VA: 0x181A2FA00
	public void EmitNewArray(Type elementType) { }

	// RVA: 0x1A2F900 Offset: 0x1A2DF00 VA: 0x181A2F900
	public void EmitNewArrayBounds(Type elementType, int rank) { }

	// RVA: 0x1A2F980 Offset: 0x1A2DF80 VA: 0x181A2F980
	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	// RVA: 0x1A2D050 Offset: 0x1A2B650 VA: 0x181A2D050
	public void EmitAdd(Type type, bool checked) { }

	// RVA: 0x1A303A0 Offset: 0x1A2E9A0 VA: 0x181A303A0
	public void EmitSub(Type type, bool checked) { }

	// RVA: 0x1A2F860 Offset: 0x1A2DE60 VA: 0x181A2F860
	public void EmitMul(Type type, bool checked) { }

	// RVA: 0x1A2DE90 Offset: 0x1A2C490 VA: 0x181A2DE90
	public void EmitDiv(Type type) { }

	// RVA: 0x1A2F830 Offset: 0x1A2DE30 VA: 0x181A2F830
	public void EmitModulo(Type type) { }

	// RVA: 0x1A2E2D0 Offset: 0x1A2C8D0 VA: 0x181A2E2D0
	public void EmitExclusiveOr(Type type) { }

	// RVA: 0x1A2D090 Offset: 0x1A2B690 VA: 0x181A2D090
	public void EmitAnd(Type type) { }

	// RVA: 0x1A2FD90 Offset: 0x1A2E390 VA: 0x181A2FD90
	public void EmitOr(Type type) { }

	// RVA: 0x1A2E870 Offset: 0x1A2CE70 VA: 0x181A2E870
	public void EmitLeftShift(Type type) { }

	// RVA: 0x1A2FEE0 Offset: 0x1A2E4E0 VA: 0x181A2FEE0
	public void EmitRightShift(Type type) { }

	// RVA: 0x1A2E290 Offset: 0x1A2C890 VA: 0x181A2E290
	public void EmitEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x1A2FB70 Offset: 0x1A2E170 VA: 0x181A2FB70
	public void EmitNotEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x1A2E8E0 Offset: 0x1A2CEE0 VA: 0x181A2E8E0
	public void EmitLessThan(Type type, bool liftedToNull) { }

	// RVA: 0x1A2E8A0 Offset: 0x1A2CEA0 VA: 0x181A2E8A0
	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x1A2E460 Offset: 0x1A2CA60 VA: 0x181A2E460
	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	// RVA: 0x1A2E420 Offset: 0x1A2CA20 VA: 0x181A2E420
	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x1A2FC50 Offset: 0x1A2E250 VA: 0x181A2FC50
	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1A2FCF0 Offset: 0x1A2E2F0 VA: 0x181A2FCF0
	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1A2DD00 Offset: 0x1A2C300 VA: 0x181A2DD00
	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1A2DC20 Offset: 0x1A2C220 VA: 0x181A2DC20
	public void EmitCast(Type toType) { }

	// RVA: 0x1A2DBB0 Offset: 0x1A2C1B0 VA: 0x181A2DBB0
	public void EmitCastToEnum(Type toType) { }

	// RVA: 0x1A2DB40 Offset: 0x1A2C140 VA: 0x181A2DB40
	public void EmitCastReferenceToEnum(Type toType) { }

	// RVA: 0x1A2FBB0 Offset: 0x1A2E1B0 VA: 0x181A2FBB0
	public void EmitNot(Type type) { }

	// RVA: 0x1A2DE20 Offset: 0x1A2C420 VA: 0x181A2DE20
	public void EmitDefaultValue(Type type) { }

	// RVA: 0x1A2FAE0 Offset: 0x1A2E0E0 VA: 0x181A2FAE0
	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	// RVA: 0x1A2D9F0 Offset: 0x1A2BFF0 VA: 0x181A2D9F0
	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	// RVA: 0x1A2DD80 Offset: 0x1A2C380 VA: 0x181A2DD80
	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	// RVA: 0x1A30510 Offset: 0x1A2EB10 VA: 0x181A30510
	public void EmitTypeEquals() { }

	// RVA: 0x1A2D0C0 Offset: 0x1A2B6C0 VA: 0x181A2D0C0
	public void EmitArrayLength() { }

	// RVA: 0x1A2F8D0 Offset: 0x1A2DED0 VA: 0x181A2F8D0
	public void EmitNegate(Type type) { }

	// RVA: 0x1A2F8A0 Offset: 0x1A2DEA0 VA: 0x181A2F8A0
	public void EmitNegateChecked(Type type) { }

	// RVA: 0x1A2E4A0 Offset: 0x1A2CAA0 VA: 0x181A2E4A0
	public void EmitIncrement(Type type) { }

	// RVA: 0x1A2DDF0 Offset: 0x1A2C3F0 VA: 0x181A2DDF0
	public void EmitDecrement(Type type) { }

	// RVA: 0x1A30570 Offset: 0x1A2EB70 VA: 0x181A30570
	public void EmitTypeIs(Type type) { }

	// RVA: 0x1A304A0 Offset: 0x1A2EAA0 VA: 0x181A304A0
	public void EmitTypeAs(Type type) { }

	// RVA: 0x1A2E920 Offset: 0x1A2CF20 VA: 0x181A2E920
	public void EmitLoadField(FieldInfo field) { }

	// RVA: 0x1A308C0 Offset: 0x1A2EEC0 VA: 0x181A308C0
	private Instruction GetLoadField(FieldInfo field) { }

	// RVA: 0x1A2FF70 Offset: 0x1A2E570 VA: 0x181A2FF70
	public void EmitStoreField(FieldInfo field) { }

	// RVA: 0x1A2DAC0 Offset: 0x1A2C0C0 VA: 0x181A2DAC0
	public void EmitCall(MethodInfo method) { }

	// RVA: 0x1A2DA90 Offset: 0x1A2C090 VA: 0x181A2DA90
	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x1A2D930 Offset: 0x1A2BF30 VA: 0x181A2D930
	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1A2FBE0 Offset: 0x1A2E1E0 VA: 0x181A2FBE0
	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x1A2CDE0 Offset: 0x1A2B3E0 VA: 0x181A2CDE0
	private RuntimeLabel[] BuildRuntimeLabels() { }

	// RVA: 0x1A30DD0 Offset: 0x1A2F3D0 VA: 0x181A30DD0
	public BranchLabel MakeLabel() { }

	// RVA: 0x1A30770 Offset: 0x1A2ED70 VA: 0x181A30770
	internal void FixupBranch(int branchIndex, int offset) { }

	// RVA: 0x1A30730 Offset: 0x1A2ED30 VA: 0x181A30730
	private int EnsureLabelIndex(BranchLabel label) { }

	// RVA: 0x1A30F30 Offset: 0x1A2F530 VA: 0x181A30F30
	public int MarkRuntimeLabel() { }

	// RVA: 0x1A30F00 Offset: 0x1A2F500 VA: 0x181A30F00
	public void MarkLabel(BranchLabel label) { }

	// RVA: 0x1A2E360 Offset: 0x1A2C960 VA: 0x181A2E360
	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x1A2D8C0 Offset: 0x1A2BEC0 VA: 0x181A2D8C0
	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	// RVA: 0x1A2D730 Offset: 0x1A2BD30 VA: 0x181A2D730
	public void EmitBranch(BranchLabel label) { }

	// RVA: 0x1A2D7E0 Offset: 0x1A2BDE0 VA: 0x181A2D7E0
	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	// RVA: 0x1A2DC50 Offset: 0x1A2C250 VA: 0x181A2DC50
	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	// RVA: 0x1A2D680 Offset: 0x1A2BC80 VA: 0x181A2D680
	public void EmitBranchTrue(BranchLabel elseLabel) { }

	// RVA: 0x1A2D5D0 Offset: 0x1A2BBD0 VA: 0x181A2D5D0
	public void EmitBranchFalse(BranchLabel elseLabel) { }

	// RVA: 0x1A30440 Offset: 0x1A2EA40 VA: 0x181A30440
	public void EmitThrow() { }

	// RVA: 0x1A303E0 Offset: 0x1A2E9E0 VA: 0x181A303E0
	public void EmitThrowVoid() { }

	// RVA: 0x1A2FE80 Offset: 0x1A2E480 VA: 0x181A2FE80
	public void EmitRethrow() { }

	// RVA: 0x1A2FE20 Offset: 0x1A2E420 VA: 0x181A2FE20
	public void EmitRethrowVoid() { }

	// RVA: 0x1A2E230 Offset: 0x1A2C830 VA: 0x181A2E230
	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x1A2E160 Offset: 0x1A2C760 VA: 0x181A2E160
	public void EmitEnterTryCatch() { }

	// RVA: 0x1A2E190 Offset: 0x1A2C790 VA: 0x181A2E190
	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	// RVA: 0x1A2E0D0 Offset: 0x1A2C6D0 VA: 0x181A2E0D0
	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x1A2E810 Offset: 0x1A2CE10 VA: 0x181A2E810
	public void EmitLeaveFinally() { }

	// RVA: 0x1A2E040 Offset: 0x1A2C640 VA: 0x181A2E040
	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	// RVA: 0x1A2E7B0 Offset: 0x1A2CDB0 VA: 0x181A2E7B0
	public void EmitLeaveFault() { }

	// RVA: 0x1A2DF20 Offset: 0x1A2C520 VA: 0x181A2DF20
	public void EmitEnterExceptionFilter() { }

	// RVA: 0x1A2E6B0 Offset: 0x1A2CCB0 VA: 0x181A2E6B0
	public void EmitLeaveExceptionFilter() { }

	// RVA: 0x1A2DF80 Offset: 0x1A2C580 VA: 0x181A2DF80
	public void EmitEnterExceptionHandlerNonVoid() { }

	// RVA: 0x1A2DFE0 Offset: 0x1A2C5E0 VA: 0x181A2DFE0
	public void EmitEnterExceptionHandlerVoid() { }

	// RVA: 0x1A2E710 Offset: 0x1A2CD10 VA: 0x181A2E710
	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	// RVA: -1 Offset: -1
	public void EmitIntSwitch<T>(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70F520 Offset: 0x70DB20 VA: 0x18070F520
	|-InstructionList.EmitIntSwitch<int>
	|-InstructionList.EmitIntSwitch<object>
	|
	|-RVA: 0x70F490 Offset: 0x70DA90 VA: 0x18070F490
	|-InstructionList.EmitIntSwitch<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A30320 Offset: 0x1A2E920 VA: 0x181A30320
	public void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x1A31760 Offset: 0x1A2FD60 VA: 0x181A31760
	public void .ctor() { }

	// RVA: 0x1A31630 Offset: 0x1A2FC30 VA: 0x181A31630
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class InterpretedFrame // TypeDefIndex: 11044
{
	// Fields
	[ThreadStatic]
	private static InterpretedFrame s_currentFrame; // 0x80000000
	internal readonly Interpreter Interpreter; // 0x10
	internal InterpretedFrame _parent; // 0x18
	private readonly int[] _continuations; // 0x20
	private int _continuationIndex; // 0x28
	private int _pendingContinuation; // 0x2C
	private object _pendingValue; // 0x30
	public readonly object[] Data; // 0x38
	public readonly IStrongBox[] Closure; // 0x40
	public int StackIndex; // 0x48
	public int InstructionIndex; // 0x4C

	// Properties
	public string Name { get; }
	public InterpretedFrame Parent { get; }

	// Methods

	// RVA: 0x1A32B80 Offset: 0x1A31180 VA: 0x181A32B80
	internal void .ctor(Interpreter interpreter, IStrongBox[] closure) { }

	// RVA: 0x1A31B40 Offset: 0x1A30140 VA: 0x181A31B40
	public DebugInfo GetDebugInfo(int instructionIndex) { }

	// RVA: 0x3A4DE0 Offset: 0x3A33E0 VA: 0x1803A4DE0
	public string get_Name() { }

	// RVA: 0x1A32170 Offset: 0x1A30770 VA: 0x181A32170
	public void Push(object value) { }

	// RVA: 0x1A32480 Offset: 0x1A30A80 VA: 0x181A32480
	public void Push(bool value) { }

	// RVA: 0x1A323E0 Offset: 0x1A309E0 VA: 0x181A323E0
	public void Push(int value) { }

	// RVA: 0x1A322A0 Offset: 0x1A308A0 VA: 0x181A322A0
	public void Push(byte value) { }

	// RVA: 0x1A32340 Offset: 0x1A30940 VA: 0x181A32340
	public void Push(sbyte value) { }

	// RVA: 0x1A32200 Offset: 0x1A30800 VA: 0x181A32200
	public void Push(short value) { }

	// RVA: 0x1A32590 Offset: 0x1A30B90 VA: 0x181A32590
	public void Push(ushort value) { }

	// RVA: 0x1A31FF0 Offset: 0x1A305F0 VA: 0x181A31FF0
	public object Pop() { }

	// RVA: 0x1A328F0 Offset: 0x1A30EF0 VA: 0x181A328F0
	internal void SetStackDepth(int depth) { }

	// RVA: 0x1A31F20 Offset: 0x1A30520 VA: 0x181A31F20
	public object Peek() { }

	// RVA: 0x1A31A20 Offset: 0x1A30020 VA: 0x181A31A20
	public void Dup() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public InterpretedFrame get_Parent() { }

	[IteratorStateMachine(typeof(InterpretedFrame.<GetStackTraceDebugInfo>d__29))]
	// RVA: 0x1A31C70 Offset: 0x1A30270 VA: 0x181A31C70
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() { }

	// RVA: 0x1A32630 Offset: 0x1A30C30 VA: 0x181A32630
	internal void SaveTraceToException(Exception exception) { }

	// RVA: 0x1A31AC0 Offset: 0x1A300C0 VA: 0x181A31AC0
	internal InterpretedFrame Enter() { }

	// RVA: 0x1A31ED0 Offset: 0x1A304D0 VA: 0x181A31ED0
	internal void Leave(InterpretedFrame prevFrame) { }

	// RVA: 0x1A31EC0 Offset: 0x1A304C0 VA: 0x181A31EC0
	internal bool IsJumpHappened() { }

	// RVA: 0xA5BAC0 Offset: 0xA5A0C0 VA: 0x180A5BAC0
	public void RemoveContinuation() { }

	// RVA: 0x1A32030 Offset: 0x1A30630 VA: 0x181A32030
	public void PushContinuation(int continuation) { }

	// RVA: 0x1A32910 Offset: 0x1A30F10 VA: 0x181A32910
	public int YieldToCurrentContinuation() { }

	// RVA: 0x1A32990 Offset: 0x1A30F90 VA: 0x181A32990
	public int YieldToPendingContinuation() { }

	// RVA: 0x1A32070 Offset: 0x1A30670 VA: 0x181A32070
	internal void PushPendingContinuation() { }

	// RVA: 0x1A31F50 Offset: 0x1A30550 VA: 0x181A31F50
	internal void PopPendingContinuation() { }

	// RVA: 0x1A31CF0 Offset: 0x1A302F0 VA: 0x181A31CF0
	public int Goto(int labelIndex, object value, bool gotoExceptionHandler) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class Interpreter // TypeDefIndex: 11045
{
	// Fields
	internal static readonly object NoValue; // 0x0
	private readonly InstructionArray _instructions; // 0x10
	internal readonly object[] _objects; // 0x38
	internal readonly RuntimeLabel[] _labels; // 0x40
	internal readonly DebugInfo[] _debugInfos; // 0x48
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly int <LocalCount>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; // 0x60

	// Properties
	internal string Name { get; }
	internal int LocalCount { get; }
	internal int ClosureSize { get; }
	internal InstructionArray Instructions { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x1A32DA0 Offset: 0x1A313A0 VA: 0x181A32DA0
	internal void .ctor(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	[CompilerGenerated]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3997F0 Offset: 0x397DF0 VA: 0x1803997F0
	internal int get_LocalCount() { }

	// RVA: 0x1A32E70 Offset: 0x1A31470 VA: 0x181A32E70
	internal int get_ClosureSize() { }

	// RVA: 0xEB3790 Offset: 0xEB1D90 VA: 0x180EB3790
	internal InstructionArray get_Instructions() { }

	[CompilerGenerated]
	// RVA: 0x3AA7F0 Offset: 0x3A8DF0 VA: 0x1803AA7F0
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x1A32CB0 Offset: 0x1A312B0 VA: 0x181A32CB0
	public void Run(InterpretedFrame frame) { }

	// RVA: 0x1A32D20 Offset: 0x1A31320 VA: 0x181A32D20
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LabelInfo // TypeDefIndex: 11047
{
	// Fields
	private readonly LabelTarget _node; // 0x10
	private BranchLabel _label; // 0x18
	private object _definitions; // 0x20
	private readonly List<LabelScopeInfo> _references; // 0x28
	private bool _acrossBlockJump; // 0x30

	// Properties
	private bool HasDefinitions { get; }
	private bool HasMultipleDefinitions { get; }

	// Methods

	// RVA: 0x1A33BF0 Offset: 0x1A321F0 VA: 0x181A33BF0
	internal void .ctor(LabelTarget node) { }

	// RVA: 0x1A336A0 Offset: 0x1A31CA0 VA: 0x181A336A0
	internal BranchLabel GetLabel(LightCompiler compiler) { }

	// RVA: 0x1A336F0 Offset: 0x1A31CF0 VA: 0x181A336F0
	internal void Reference(LabelScopeInfo block) { }

	// RVA: 0x1A33000 Offset: 0x1A31600 VA: 0x181A33000
	internal void Define(LabelScopeInfo block) { }

	// RVA: 0x1A33840 Offset: 0x1A31E40 VA: 0x181A33840
	private void ValidateJump(LabelScopeInfo reference) { }

	// RVA: 0x1A337B0 Offset: 0x1A31DB0 VA: 0x181A337B0
	internal void ValidateFinish() { }

	// RVA: 0x1A334A0 Offset: 0x1A31AA0 VA: 0x181A334A0
	private void EnsureLabel(LightCompiler compiler) { }

	// RVA: 0x1A333F0 Offset: 0x1A319F0 VA: 0x181A333F0
	private bool DefinedIn(LabelScopeInfo scope) { }

	// RVA: 0x1A33C90 Offset: 0x1A32290 VA: 0x181A33C90
	private bool get_HasDefinitions() { }

	// RVA: 0x1A334F0 Offset: 0x1A31AF0 VA: 0x181A334F0
	private LabelScopeInfo FirstDefinition() { }

	// RVA: 0x1A32EC0 Offset: 0x1A314C0 VA: 0x181A32EC0
	private void AddDefinition(LabelScopeInfo scope) { }

	// RVA: 0x1A33CA0 Offset: 0x1A322A0 VA: 0x181A33CA0
	private bool get_HasMultipleDefinitions() { }

	// RVA: -1 Offset: -1
	internal static T CommonNode<T>(T first, T second, Func<T, T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7146A0 Offset: 0x712CA0 VA: 0x1807146A0
	|-LabelInfo.CommonNode<object>
	*/
}

// Namespace: System.Linq.Expressions.Interpreter
internal enum LabelScopeKind // TypeDefIndex: 11048
{
	// Fields
	public int value__; // 0x0
	public const LabelScopeKind Statement = 0;
	public const LabelScopeKind Block = 1;
	public const LabelScopeKind Switch = 2;
	public const LabelScopeKind Lambda = 3;
	public const LabelScopeKind Try = 4;
	public const LabelScopeKind Catch = 5;
	public const LabelScopeKind Finally = 6;
	public const LabelScopeKind Filter = 7;
	public const LabelScopeKind Expression = 8;
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LabelScopeInfo // TypeDefIndex: 11049
{
	// Fields
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; // 0x10
	internal readonly LabelScopeKind Kind; // 0x18
	internal readonly LabelScopeInfo Parent; // 0x20

	// Properties
	internal bool CanJumpInto { get; }

	// Methods

	// RVA: 0x1A33EE0 Offset: 0x1A324E0 VA: 0x181A33EE0
	internal void .ctor(LabelScopeInfo parent, LabelScopeKind kind) { }

	// RVA: 0x1A33F30 Offset: 0x1A32530 VA: 0x181A33F30
	internal bool get_CanJumpInto() { }

	// RVA: 0x1A33DF0 Offset: 0x1A323F0 VA: 0x181A33DF0
	internal bool ContainsTarget(LabelTarget target) { }

	// RVA: 0x1A33E50 Offset: 0x1A32450 VA: 0x181A33E50
	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

	// RVA: 0x1A33D30 Offset: 0x1A32330 VA: 0x181A33D30
	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LeftShiftInstruction : Instruction // TypeDefIndex: 11058
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A344F0 Offset: 0x1A32AF0 VA: 0x181A344F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x1A34070 Offset: 0x1A32670 VA: 0x181A34070
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LessThanInstruction : Instruction // TypeDefIndex: 11070
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A361C0 Offset: 0x1A347C0 VA: 0x181A361C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	private void .ctor(object nullValue) { }

	// RVA: 0x1A35360 Offset: 0x1A33960 VA: 0x181A35360
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LessThanOrEqualInstruction : Instruction // TypeDefIndex: 11082
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A378F0 Offset: 0x1A35EF0 VA: 0x181A378F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	private void .ctor(object nullValue) { }

	// RVA: 0x1A36A90 Offset: 0x1A35090 VA: 0x181A36A90
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ExceptionFilter // TypeDefIndex: 11083
{
	// Fields
	public readonly int LabelIndex; // 0x10
	public readonly int StartIndex; // 0x14
	public readonly int EndIndex; // 0x18

	// Methods

	// RVA: 0x139BDD0 Offset: 0x139A3D0 VA: 0x18139BDD0
	internal void .ctor(int labelIndex, int start, int end) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ExceptionHandler // TypeDefIndex: 11084
{
	// Fields
	private readonly Type _exceptionType; // 0x10
	public readonly int LabelIndex; // 0x18
	public readonly int HandlerStartIndex; // 0x1C
	public readonly int HandlerEndIndex; // 0x20
	public readonly ExceptionFilter Filter; // 0x28

	// Methods

	// RVA: 0x1A26C60 Offset: 0x1A25260 VA: 0x181A26C60
	internal void .ctor(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter) { }

	// RVA: 0x1A26B40 Offset: 0x1A25140 VA: 0x181A26B40
	public bool Matches(Type exceptionType) { }

	// RVA: 0x1A26B70 Offset: 0x1A25170 VA: 0x181A26B70 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TryCatchFinallyHandler // TypeDefIndex: 11085
{
	// Fields
	internal readonly int TryStartIndex; // 0x10
	internal readonly int TryEndIndex; // 0x14
	internal readonly int FinallyStartIndex; // 0x18
	internal readonly int FinallyEndIndex; // 0x1C
	internal readonly int GotoEndTargetIndex; // 0x20
	private readonly ExceptionHandler[] _handlers; // 0x28

	// Properties
	internal bool IsFinallyBlockExist { get; }
	internal ExceptionHandler[] Handlers { get; }
	internal bool IsCatchBlockExist { get; }

	// Methods

	// RVA: 0x1A49670 Offset: 0x1A47C70 VA: 0x181A49670
	internal bool get_IsFinallyBlockExist() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	internal ExceptionHandler[] get_Handlers() { }

	// RVA: 0x13A5440 Offset: 0x13A3A40 VA: 0x1813A5440
	internal bool get_IsCatchBlockExist() { }

	// RVA: 0x1A49600 Offset: 0x1A47C00 VA: 0x181A49600
	internal void .ctor(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) { }

	// RVA: 0x1A49590 Offset: 0x1A47B90 VA: 0x181A49590
	internal void .ctor(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) { }

	// RVA: 0x1A49400 Offset: 0x1A47A00 VA: 0x181A49400
	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) { }

	// RVA: 0x1A491A0 Offset: 0x1A477A0 VA: 0x181A491A0
	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TryFaultHandler // TypeDefIndex: 11086
{
	// Fields
	internal readonly int TryStartIndex; // 0x10
	internal readonly int TryEndIndex; // 0x14
	internal readonly int FinallyStartIndex; // 0x18
	internal readonly int FinallyEndIndex; // 0x1C

	// Methods

	// RVA: 0x1815560 Offset: 0x1813B60 VA: 0x181815560
	internal void .ctor(int tryStart, int tryEnd, int finallyStart, int finallyEnd) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RethrowException : Exception // TypeDefIndex: 11087
{
	// Methods

	// RVA: 0x1A49010 Offset: 0x1A47610 VA: 0x181A49010
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DebugInfo // TypeDefIndex: 11089
{
	// Fields
	public int StartLine; // 0x10
	public int EndLine; // 0x14
	public int Index; // 0x18
	public string FileName; // 0x20
	public bool IsClear; // 0x28
	private static readonly DebugInfo.DebugInfoComparer s_debugComparer; // 0x0

	// Methods

	// RVA: 0x1A25DC0 Offset: 0x1A243C0 VA: 0x181A25DC0
	public static DebugInfo GetMatchingDebugInfo(DebugInfo[] debugInfos, int index) { }

	// RVA: 0x1A25EB0 Offset: 0x1A244B0 VA: 0x181A25EB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1A26150 Offset: 0x1A24750 VA: 0x181A26150
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
internal struct InterpretedFrameInfo // TypeDefIndex: 11090
{
	// Fields
	private readonly string _methodName; // 0x0
	private readonly DebugInfo _debugInfo; // 0x8

	// Methods

	// RVA: 0x598200 Offset: 0x596800 VA: 0x180598200
	public void .ctor(string methodName, DebugInfo info) { }

	// RVA: 0x1A319A0 Offset: 0x1A2FFA0 VA: 0x181A319A0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LightCompiler // TypeDefIndex: 11093
{
	// Fields
	private readonly InstructionList _instructions; // 0x10
	private readonly LocalVariables _locals; // 0x18
	private readonly List<DebugInfo> _debugInfos; // 0x20
	private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels; // 0x28
	private LabelScopeInfo _labelBlock; // 0x30
	private readonly Stack<ParameterExpression> _exceptionForRethrowStack; // 0x38
	private readonly LightCompiler _parent; // 0x40
	private readonly StackGuard _guard; // 0x48
	private static readonly LocalDefinition[] s_emptyLocals; // 0x0

	// Properties
	public InstructionList Instructions { get; }

	// Methods

	// RVA: 0x1A48B90 Offset: 0x1A47190 VA: 0x181A48B90
	public void .ctor() { }

	// RVA: 0x1A48B50 Offset: 0x1A47150 VA: 0x181A48B50
	private void .ctor(LightCompiler parent) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public InstructionList get_Instructions() { }

	// RVA: 0x1A44EE0 Offset: 0x1A434E0 VA: 0x181A44EE0
	public LightDelegateCreator CompileTop(LambdaExpression node) { }

	// RVA: 0x1A47DF0 Offset: 0x1A463F0 VA: 0x181A47DF0
	private Interpreter MakeInterpreter(string lambdaName) { }

	// RVA: 0x1A3CBD0 Offset: 0x1A3B1D0 VA: 0x181A3CBD0
	private void CompileConstantExpression(Expression expr) { }

	// RVA: 0x1A3DDA0 Offset: 0x1A3C3A0 VA: 0x181A3DDA0
	private void CompileDefaultExpression(Expression expr) { }

	// RVA: 0x1A3DCA0 Offset: 0x1A3C2A0 VA: 0x181A3DCA0
	private void CompileDefaultExpression(Type type) { }

	// RVA: 0x1A478E0 Offset: 0x1A45EE0 VA: 0x181A478E0
	private LocalVariable EnsureAvailableForClosure(ParameterExpression expr) { }

	// RVA: 0x1A48470 Offset: 0x1A46A70 VA: 0x181A48470
	private LocalVariable ResolveLocal(ParameterExpression variable) { }

	// RVA: 0x1A3E020 Offset: 0x1A3C620 VA: 0x181A3E020
	private void CompileGetVariable(ParameterExpression variable) { }

	// RVA: 0x1A47400 Offset: 0x1A45A00 VA: 0x181A47400
	private void EmitCopyValueType(Type valueType) { }

	// RVA: 0x1A47CA0 Offset: 0x1A462A0 VA: 0x181A47CA0
	private void LoadLocalNoValueTypeCopy(ParameterExpression variable) { }

	// RVA: 0x1A48270 Offset: 0x1A46870 VA: 0x181A48270
	private bool MaybeMutableValueType(Type type) { }

	// RVA: 0x1A3DF70 Offset: 0x1A3C570 VA: 0x181A3DF70
	private void CompileGetBoxedVariable(ParameterExpression variable) { }

	// RVA: 0x1A43C20 Offset: 0x1A42220 VA: 0x181A43C20
	private void CompileSetVariable(ParameterExpression variable, bool isVoid) { }

	// RVA: 0x1A43510 Offset: 0x1A41B10 VA: 0x181A43510
	private void CompileParameterExpression(Expression expr) { }

	// RVA: 0x1A3B880 Offset: 0x1A39E80 VA: 0x181A3B880
	private void CompileBlockExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1A3BA60 Offset: 0x1A3A060 VA: 0x181A3BA60
	private LocalDefinition[] CompileBlockStart(BlockExpression node) { }

	// RVA: 0x1A3B7A0 Offset: 0x1A39DA0 VA: 0x181A3B7A0
	private void CompileBlockEnd(LocalDefinition[] locals) { }

	// RVA: 0x1A3E7D0 Offset: 0x1A3CDD0 VA: 0x181A3E7D0
	private void CompileIndexExpression(Expression expr) { }

	// RVA: 0x1A474C0 Offset: 0x1A45AC0 VA: 0x181A474C0
	private void EmitIndexGet(IndexExpression index) { }

	// RVA: 0x1A3E420 Offset: 0x1A3CA20 VA: 0x181A3E420
	private void CompileIndexAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x1A40A60 Offset: 0x1A3F060 VA: 0x181A40A60
	private void CompileMemberAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x1A40410 Offset: 0x1A3EA10 VA: 0x181A40410
	private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding) { }

	// RVA: 0x1A470F0 Offset: 0x1A456F0 VA: 0x181A470F0
	private void CompileVariableAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x1A39FC0 Offset: 0x1A385C0 VA: 0x181A39FC0
	private void CompileAssignBinaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1A3A5A0 Offset: 0x1A38BA0 VA: 0x181A3A5A0
	private void CompileBinaryExpression(Expression expr) { }

	// RVA: 0x1A3DED0 Offset: 0x1A3C4D0 VA: 0x181A3DED0
	private void CompileEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x1A43380 Offset: 0x1A41980 VA: 0x181A43380
	private void CompileNotEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x1A3C730 Offset: 0x1A3AD30 VA: 0x181A3C730
	private void CompileComparison(BinaryExpression node) { }

	// RVA: 0x1A398B0 Offset: 0x1A37EB0 VA: 0x181A398B0
	private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right) { }

	// RVA: 0x1A3D320 Offset: 0x1A3B920 VA: 0x181A3D320
	private void CompileConvertUnaryExpression(Expression expr) { }

	// RVA: 0x1A3CC80 Offset: 0x1A3B280 VA: 0x181A3CC80
	private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull) { }

	// RVA: 0x1A43420 Offset: 0x1A41A20 VA: 0x181A43420
	private void CompileNotExpression(UnaryExpression node) { }

	// RVA: 0x1A467F0 Offset: 0x1A44DF0 VA: 0x181A467F0
	private void CompileUnaryExpression(Expression expr) { }

	// RVA: 0x1A477D0 Offset: 0x1A45DD0 VA: 0x181A477D0
	private void EmitUnaryMethodCall(UnaryExpression node) { }

	// RVA: 0x1A475D0 Offset: 0x1A45BD0 VA: 0x181A475D0
	private void EmitUnaryBoolCheck(UnaryExpression node) { }

	// RVA: 0x1A39830 Offset: 0x1A37E30 VA: 0x181A39830
	private void CompileAndAlsoBinaryExpression(Expression expr) { }

	// RVA: 0x1A43490 Offset: 0x1A41A90 VA: 0x181A43490
	private void CompileOrElseBinaryExpression(Expression expr) { }

	// RVA: 0x1A3FED0 Offset: 0x1A3E4D0 VA: 0x181A3FED0
	private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso) { }

	// RVA: 0x1A41A00 Offset: 0x1A40000 VA: 0x181A41A00
	private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x1A3F1B0 Offset: 0x1A3D7B0 VA: 0x181A3F1B0
	private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso) { }

	// RVA: 0x1A46FB0 Offset: 0x1A455B0 VA: 0x181A46FB0
	private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x1A3C930 Offset: 0x1A3AF30 VA: 0x181A3C930
	private void CompileConditionalExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1A40110 Offset: 0x1A3E710 VA: 0x181A40110
	private void CompileLoopExpression(Expression expr) { }

	// RVA: 0x1A444A0 Offset: 0x1A42AA0 VA: 0x181A444A0
	private void CompileSwitchExpression(Expression expr) { }

	// RVA: -1 Offset: -1
	private void CompileIntSwitchExpression<T>(SwitchExpression node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x716A70 Offset: 0x715070 VA: 0x180716A70
	|-LightCompiler.CompileIntSwitchExpression<int>
	|
	|-RVA: 0x716FA0 Offset: 0x7155A0 VA: 0x180716FA0
	|-LightCompiler.CompileIntSwitchExpression<object>
	|
	|-RVA: 0x7164B0 Offset: 0x714AB0 VA: 0x1807164B0
	|-LightCompiler.CompileIntSwitchExpression<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A43E40 Offset: 0x1A42440 VA: 0x181A43E40
	private void CompileStringSwitchExpression(SwitchExpression node) { }

	// RVA: 0x1A3EC90 Offset: 0x1A3D290 VA: 0x181A3EC90
	private void CompileLabelExpression(Expression expr) { }

	// RVA: 0x1A3E100 Offset: 0x1A3C700 VA: 0x181A3E100
	private void CompileGotoExpression(Expression expr) { }

	// RVA: 0x1A48300 Offset: 0x1A46900 VA: 0x181A48300
	private void PushLabelBlock(LabelScopeKind type) { }

	// RVA: 0x1A482D0 Offset: 0x1A468D0 VA: 0x181A482D0
	private void PopLabelBlock(LabelScopeKind kind) { }

	// RVA: 0x1A47A40 Offset: 0x1A46040 VA: 0x181A47A40
	private LabelInfo EnsureLabel(LabelTarget node) { }

	// RVA: 0x1A48390 Offset: 0x1A46990 VA: 0x181A48390
	private LabelInfo ReferenceLabel(LabelTarget node) { }

	// RVA: 0x1A47360 Offset: 0x1A45960 VA: 0x181A47360
	private LabelInfo DefineLabel(LabelTarget node) { }

	// RVA: 0x1A486D0 Offset: 0x1A46CD0 VA: 0x181A486D0
	private bool TryPushLabelBlock(Expression node) { }

	// RVA: 0x1A47230 Offset: 0x1A45830 VA: 0x181A47230
	private void DefineBlockLabels(Expression node) { }

	// RVA: 0x1A38BD0 Offset: 0x1A371D0 VA: 0x181A38BD0
	private void CheckRethrow() { }

	// RVA: 0x1A44C60 Offset: 0x1A43260 VA: 0x181A44C60
	private void CompileThrowUnaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x1A451F0 Offset: 0x1A437F0 VA: 0x181A451F0
	private void CompileTryExpression(Expression expr) { }

	// RVA: 0x1A45E30 Offset: 0x1A44430 VA: 0x181A45E30
	private void CompileTryFaultExpression(TryExpression expr) { }

	// RVA: 0x1A41960 Offset: 0x1A3FF60 VA: 0x181A41960
	private void CompileMethodCallExpression(Expression expr) { }

	// RVA: 0x1A41440 Offset: 0x1A3FA40 VA: 0x181A41440
	private void CompileMethodCallExpression(Expression object, MethodInfo method, IArgumentProvider arguments) { }

	// RVA: 0x1A39B40 Offset: 0x1A38140 VA: 0x181A39B40
	private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex) { }

	// RVA: 0x1A475C0 Offset: 0x1A45BC0 VA: 0x181A475C0
	private void EmitThisForMethodCall(Expression node) { }

	// RVA: 0x1A484E0 Offset: 0x1A46AE0 VA: 0x181A484E0
	private static bool ShouldWritebackNode(Expression node) { }

	// RVA: 0x1A38C30 Offset: 0x1A37230 VA: 0x181A38C30
	private ByRefUpdater CompileAddress(Expression node, int index) { }

	// RVA: 0x1A41BE0 Offset: 0x1A401E0 VA: 0x181A41BE0
	private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index) { }

	// RVA: 0x1A42510 Offset: 0x1A40B10 VA: 0x181A42510
	private void CompileNewExpression(Expression expr) { }

	// RVA: 0x1A40B40 Offset: 0x1A3F140 VA: 0x181A40B40
	private void CompileMemberExpression(Expression expr) { }

	// RVA: 0x1A410C0 Offset: 0x1A3F6C0 VA: 0x181A410C0
	private void CompileMember(Expression from, MemberInfo member, bool forBinding) { }

	// RVA: 0x1A42190 Offset: 0x1A40790 VA: 0x181A42190
	private void CompileNewArrayExpression(Expression expr) { }

	// RVA: 0x1A3DAB0 Offset: 0x1A3C0B0 VA: 0x181A3DAB0
	private void CompileDebugInfoExpression(Expression expr) { }

	// RVA: 0x1A43990 Offset: 0x1A41F90 VA: 0x181A43990
	private void CompileRuntimeVariablesExpression(Expression expr) { }

	// RVA: 0x1A3EF50 Offset: 0x1A3D550 VA: 0x181A3EF50
	private void CompileLambdaExpression(Expression expr) { }

	// RVA: 0x1A3BF70 Offset: 0x1A3A570 VA: 0x181A3BF70
	private void CompileCoalesceBinaryExpression(Expression expr) { }

	// RVA: 0x1A3EA10 Offset: 0x1A3D010 VA: 0x181A3EA10
	private void CompileInvocationExpression(Expression expr) { }

	// RVA: 0x1A3FB70 Offset: 0x1A3E170 VA: 0x181A3FB70
	private void CompileListInitExpression(Expression expr) { }

	// RVA: 0x1A3FC00 Offset: 0x1A3E200 VA: 0x181A3FC00
	private void CompileListInit(ReadOnlyCollection<ElementInit> initializers) { }

	// RVA: 0x1A40BF0 Offset: 0x1A3F1F0 VA: 0x181A40BF0
	private void CompileMemberInitExpression(Expression expr) { }

	// RVA: 0x1A40C80 Offset: 0x1A3F280 VA: 0x181A40C80
	private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings) { }

	// RVA: 0x1A47B10 Offset: 0x1A46110 VA: 0x181A47B10
	private static Type GetMemberType(MemberInfo member) { }

	// RVA: 0x1A43660 Offset: 0x1A41C60 VA: 0x181A43660
	private void CompileQuoteUnaryExpression(Expression expr) { }

	// RVA: 0x1A46E70 Offset: 0x1A45470 VA: 0x181A46E70
	private void CompileUnboxUnaryExpression(Expression expr) { }

	// RVA: 0x1A46340 Offset: 0x1A44940 VA: 0x181A46340
	private void CompileTypeEqualExpression(Expression expr) { }

	// RVA: 0x1A46290 Offset: 0x1A44890 VA: 0x181A46290
	private void CompileTypeAsExpression(UnaryExpression node) { }

	// RVA: 0x1A46560 Offset: 0x1A44B60 VA: 0x181A46560
	private void CompileTypeIsExpression(Expression expr) { }

	// RVA: 0x1A47210 Offset: 0x1A45810 VA: 0x181A47210
	private void Compile(Expression expr, bool asVoid) { }

	// RVA: 0x1A39E50 Offset: 0x1A38450 VA: 0x181A39E50
	private void CompileAsVoid(Expression expr) { }

	// RVA: 0x1A428E0 Offset: 0x1A40EE0 VA: 0x181A428E0
	private void CompileNoLabelPush(Expression expr) { }

	// RVA: 0x1A471A0 Offset: 0x1A457A0 VA: 0x181A471A0
	private void Compile(Expression expr) { }

	// RVA: 0x1A48A90 Offset: 0x1A47090 VA: 0x181A48A90
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ByRefUpdater // TypeDefIndex: 11094
{
	// Fields
	public readonly int ArgumentIndex; // 0x10

	// Methods

	// RVA: 0x3757E0 Offset: 0x373DE0 VA: 0x1803757E0
	public void .ctor(int argumentIndex) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update(InterpretedFrame frame, object value);

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ParameterByRefUpdater : ByRefUpdater // TypeDefIndex: 11095
{
	// Fields
	private readonly LocalVariable _parameter; // 0x18

	// Methods

	// RVA: 0x1A5FFC0 Offset: 0x1A5E5C0 VA: 0x181A5FFC0
	public void .ctor(LocalVariable parameter, int argumentIndex) { }

	// RVA: 0x1A5FE10 Offset: 0x1A5E410 VA: 0x181A5FE10 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ArrayByRefUpdater : ByRefUpdater // TypeDefIndex: 11096
{
	// Fields
	private readonly LocalDefinition _array; // 0x18
	private readonly LocalDefinition _index; // 0x28

	// Methods

	// RVA: 0x1A49E00 Offset: 0x1A48400 VA: 0x181A49E00
	public void .ctor(LocalDefinition array, LocalDefinition index, int argumentIndex) { }

	// RVA: 0x1A49CE0 Offset: 0x1A482E0 VA: 0x181A49CE0 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1A49C50 Offset: 0x1A48250 VA: 0x181A49C50 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class FieldByRefUpdater : ByRefUpdater // TypeDefIndex: 11097
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly FieldInfo _field; // 0x30

	// Methods

	// RVA: 0x1A52C70 Offset: 0x1A51270 VA: 0x181A52C70
	public void .ctor(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex) { }

	// RVA: 0x1A52BD0 Offset: 0x1A511D0 VA: 0x181A52BD0 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1A52B30 Offset: 0x1A51130 VA: 0x181A52B30 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class PropertyByRefUpdater : ByRefUpdater // TypeDefIndex: 11098
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly PropertyInfo _property; // 0x30

	// Methods

	// RVA: 0x1A52C70 Offset: 0x1A51270 VA: 0x181A52C70
	public void .ctor(Nullable<LocalDefinition> obj, PropertyInfo property, int argumentIndex) { }

	// RVA: 0x1A60220 Offset: 0x1A5E820 VA: 0x181A60220 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1A60180 Offset: 0x1A5E780 VA: 0x181A60180 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class IndexMethodByRefUpdater : ByRefUpdater // TypeDefIndex: 11099
{
	// Fields
	private readonly MethodInfo _indexer; // 0x18
	private readonly Nullable<LocalDefinition> _obj; // 0x20
	private readonly LocalDefinition[] _args; // 0x38

	// Methods

	// RVA: 0x1A536F0 Offset: 0x1A51CF0 VA: 0x181A536F0
	public void .ctor(Nullable<LocalDefinition> obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) { }

	// RVA: 0x1A534A0 Offset: 0x1A51AA0 VA: 0x181A534A0 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1A532D0 Offset: 0x1A518D0 VA: 0x181A532D0 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LightDelegateCreator // TypeDefIndex: 11100
{
	// Fields
	private readonly LambdaExpression _lambda; // 0x10
	[CompilerGenerated]
	private readonly Interpreter <Interpreter>k__BackingField; // 0x18

	// Properties
	internal Interpreter Interpreter { get; }

	// Methods

	// RVA: 0x13C63F0 Offset: 0x13C49F0 VA: 0x1813C63F0
	internal void .ctor(Interpreter interpreter, LambdaExpression lambda) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal Interpreter get_Interpreter() { }

	// RVA: 0x1A54370 Offset: 0x1A52970 VA: 0x181A54370
	public Delegate CreateDelegate() { }

	// RVA: 0x1A54380 Offset: 0x1A52980 VA: 0x181A54380
	internal Delegate CreateDelegate(IStrongBox[] closure) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class LightLambda // TypeDefIndex: 11103
{
	// Fields
	private readonly IStrongBox[] _closure; // 0x10
	private readonly Interpreter _interpreter; // 0x18
	private static readonly CacheDict<Type, Func<LightLambda, Delegate>> _runCache; // 0x0
	private readonly LightDelegateCreator _delegateCreator; // 0x20

	// Properties
	internal string DebugView { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal TRet Run0<TRet>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x717560 Offset: 0x715B60 VA: 0x180717560
	|-LightLambda.Run0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A558A0 Offset: 0x1A53EA0 VA: 0x181A558A0
	internal void RunVoid0() { }

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun0<TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A55830 Offset: 0x1A53E30 VA: 0x181A55830
	internal static Delegate MakeRunVoid0(LightLambda lambda) { }

	// RVA: -1 Offset: -1
	internal TRet Run1<T0, TRet>(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71C180 Offset: 0x71A780 VA: 0x18071C180
	|-LightLambda.Run1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid1<T0>(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7244E0 Offset: 0x722AE0 VA: 0x1807244E0
	|-LightLambda.RunVoid1<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun1<T0, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid1<T0>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid1<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run2<T0, T1, TRet>(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71CBB0 Offset: 0x71B1B0 VA: 0x18071CBB0
	|-LightLambda.Run2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid2<T0, T1>(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x724690 Offset: 0x722C90 VA: 0x180724690
	|-LightLambda.RunVoid2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun2<T0, T1, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid2<T0, T1>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run3<T0, T1, T2, TRet>(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71CF10 Offset: 0x71B510 VA: 0x18071CF10
	|-LightLambda.Run3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x724950 Offset: 0x722F50 VA: 0x180724950
	|-LightLambda.RunVoid3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun3<T0, T1, T2, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid3<T0, T1, T2>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run4<T0, T1, T2, T3, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71D340 Offset: 0x71B940 VA: 0x18071D340
	|-LightLambda.Run4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x724CE0 Offset: 0x7232E0 VA: 0x180724CE0
	|-LightLambda.RunVoid4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun4<T0, T1, T2, T3, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid4<T0, T1, T2, T3>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run5<T0, T1, T2, T3, T4, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71D840 Offset: 0x71BE40 VA: 0x18071D840
	|-LightLambda.Run5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x725150 Offset: 0x723750 VA: 0x180725150
	|-LightLambda.RunVoid5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun5<T0, T1, T2, T3, T4, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid5<T0, T1, T2, T3, T4>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run6<T0, T1, T2, T3, T4, T5, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71DE20 Offset: 0x71C420 VA: 0x18071DE20
	|-LightLambda.Run6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x725690 Offset: 0x723C90 VA: 0x180725690
	|-LightLambda.RunVoid6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun6<T0, T1, T2, T3, T4, T5, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid6<T0, T1, T2, T3, T4, T5>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run7<T0, T1, T2, T3, T4, T5, T6, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71E4D0 Offset: 0x71CAD0 VA: 0x18071E4D0
	|-LightLambda.Run7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x725CB0 Offset: 0x7242B0 VA: 0x180725CB0
	|-LightLambda.RunVoid7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun7<T0, T1, T2, T3, T4, T5, T6, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid7<T0, T1, T2, T3, T4, T5, T6>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71EC60 Offset: 0x71D260 VA: 0x18071EC60
	|-LightLambda.Run8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7263A0 Offset: 0x7249A0 VA: 0x1807263A0
	|-LightLambda.RunVoid8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71F4D0 Offset: 0x71DAD0 VA: 0x18071F4D0
	|-LightLambda.Run9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x726B70 Offset: 0x725170 VA: 0x180726B70
	|-LightLambda.RunVoid9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7176F0 Offset: 0x715CF0 VA: 0x1807176F0
	|-LightLambda.Run10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71FE10 Offset: 0x71E410 VA: 0x18071FE10
	|-LightLambda.RunVoid10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x718120 Offset: 0x716720 VA: 0x180718120
	|-LightLambda.Run11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7207A0 Offset: 0x71EDA0 VA: 0x1807207A0
	|-LightLambda.RunVoid11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x718C30 Offset: 0x717230 VA: 0x180718C30
	|-LightLambda.Run12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x721210 Offset: 0x71F810 VA: 0x180721210
	|-LightLambda.RunVoid12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x719830 Offset: 0x717E30 VA: 0x180719830
	|-LightLambda.Run13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x721D60 Offset: 0x720360 VA: 0x180721D60
	|-LightLambda.RunVoid13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71A510 Offset: 0x718B10 VA: 0x18071A510
	|-LightLambda.Run14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7229A0 Offset: 0x720FA0 VA: 0x1807229A0
	|-LightLambda.RunVoid14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x71B2D0 Offset: 0x7198D0 VA: 0x18071B2D0
	|-LightLambda.Run15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7236D0 Offset: 0x721CD0 VA: 0x1807236D0
	|-LightLambda.RunVoid15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRun15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7174E0 Offset: 0x715AE0 VA: 0x1807174E0
	|-LightLambda.MakeRunVoid15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A55E50 Offset: 0x1A54450 VA: 0x181A55E50
	internal void .ctor(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	// RVA: 0x1A55EC0 Offset: 0x1A544C0 VA: 0x181A55EC0
	internal string get_DebugView() { }

	// RVA: 0x1A54C70 Offset: 0x1A53270 VA: 0x181A54C70
	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	// RVA: 0x1A54EF0 Offset: 0x1A534F0 VA: 0x181A54EF0
	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	// RVA: 0x1A544A0 Offset: 0x1A52AA0 VA: 0x181A544A0
	private Delegate CreateCustomDelegate(Type delegateType) { }

	// RVA: 0x1A54E00 Offset: 0x1A53400 VA: 0x181A54E00
	internal Delegate MakeDelegate(Type delegateType) { }

	// RVA: 0x1A54E80 Offset: 0x1A53480 VA: 0x181A54E80
	private InterpretedFrame MakeFrame() { }

	// RVA: -1 Offset: -1
	internal void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x727420 Offset: 0x725A20 VA: 0x180727420
	|-LightLambda.RunVoidRef2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A55BB0 Offset: 0x1A541B0 VA: 0x181A55BB0
	public object Run(object[] arguments) { }

	// RVA: 0x1A559B0 Offset: 0x1A53FB0 VA: 0x181A559B0
	public object RunVoid(object[] arguments) { }

	// RVA: 0x1A55DC0 Offset: 0x1A543C0 VA: 0x181A55DC0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal interface IBoxableInstruction // TypeDefIndex: 11104
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Instruction BoxIfIndexMatches(int index);
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LocalAccessInstruction : Instruction // TypeDefIndex: 11105
{
	// Fields
	internal readonly int _index; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	protected void .ctor(int index) { }

	// RVA: 0x1A568C0 Offset: 0x1A54EC0 VA: 0x181A568C0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 11106
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A56730 Offset: 0x1A54D30 VA: 0x181A56730 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A56680 Offset: 0x1A54C80 VA: 0x181A56680 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A56610 Offset: 0x1A54C10 VA: 0x181A56610 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 11107
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A563E0 Offset: 0x1A549E0 VA: 0x181A563E0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A562C0 Offset: 0x1A548C0 VA: 0x181A562C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalFromClosureInstruction : LocalAccessInstruction // TypeDefIndex: 11108
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A565E0 Offset: 0x1A54BE0 VA: 0x181A565E0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A564F0 Offset: 0x1A54AF0 VA: 0x181A564F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 11109
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A564C0 Offset: 0x1A54AC0 VA: 0x181A564C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A56410 Offset: 0x1A54A10 VA: 0x181A56410 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 11110
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A4A090 Offset: 0x1A48690 VA: 0x181A4A090 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A49FF0 Offset: 0x1A485F0 VA: 0x181A49FF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A49F80 Offset: 0x1A48580 VA: 0x181A49F80 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 11111
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A623C0 Offset: 0x1A609C0 VA: 0x181A623C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A62320 Offset: 0x1A60920 VA: 0x181A62320 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A622B0 Offset: 0x1A608B0 VA: 0x181A622B0 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 11112
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A49F50 Offset: 0x1A48550 VA: 0x181A49F50 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A49E70 Offset: 0x1A48470 VA: 0x181A49E70 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 11113
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A62280 Offset: 0x1A60880 VA: 0x181A62280 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A62180 Offset: 0x1A60780 VA: 0x181A62180 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction // TypeDefIndex: 11114
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A4A150 Offset: 0x1A48750 VA: 0x181A4A150 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A4A0C0 Offset: 0x1A486C0 VA: 0x181A4A0C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ValueTypeCopyInstruction : Instruction // TypeDefIndex: 11115
{
	// Fields
	public static readonly ValueTypeCopyInstruction Instruction; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A66670 Offset: 0x1A64C70 VA: 0x181A66670 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A665B0 Offset: 0x1A64BB0 VA: 0x181A665B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x1A66600 Offset: 0x1A64C00 VA: 0x181A66600
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class InitializeLocalInstruction : LocalAccessInstruction // TypeDefIndex: 11124
{
	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RuntimeVariablesInstruction : Instruction // TypeDefIndex: 11125
{
	// Fields
	private readonly int _count; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(int count) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A61BD0 Offset: 0x1A601D0 VA: 0x181A61BD0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A61A20 Offset: 0x1A60020 VA: 0x181A61A20 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LocalVariable // TypeDefIndex: 11126
{
	// Fields
	public readonly int Index; // 0x10
	private int _flags; // 0x14

	// Properties
	public bool IsBoxed { get; set; }
	public bool InClosure { get; }

	// Methods

	// RVA: 0x1A56CC0 Offset: 0x1A552C0 VA: 0x181A56CC0
	public bool get_IsBoxed() { }

	// RVA: 0x1A56CD0 Offset: 0x1A552D0 VA: 0x181A56CD0
	public void set_IsBoxed(bool value) { }

	// RVA: 0x1A56CB0 Offset: 0x1A552B0 VA: 0x181A56CB0
	public bool get_InClosure() { }

	// RVA: 0x1A56C70 Offset: 0x1A55270 VA: 0x181A56C70
	internal void .ctor(int index, bool closure) { }

	// RVA: 0x1A56B90 Offset: 0x1A55190 VA: 0x181A56B90 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
internal struct LocalDefinition // TypeDefIndex: 11127
{
	// Fields
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ParameterExpression <Parameter>k__BackingField; // 0x8

	// Properties
	public int Index { get; }
	public ParameterExpression Parameter { get; }

	// Methods

	// RVA: 0xA4BD30 Offset: 0xA4A330 VA: 0x180A4BD30
	internal void .ctor(int localIndex, ParameterExpression parameter) { }

	[CompilerGenerated]
	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public ParameterExpression get_Parameter() { }

	// RVA: 0x1A56A90 Offset: 0x1A55090 VA: 0x181A56A90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A56B30 Offset: 0x1A55130 VA: 0x181A56B30 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LocalVariables // TypeDefIndex: 11129
{
	// Fields
	private readonly HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope> _variables; // 0x10
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; // 0x18
	private int _localCount; // 0x20
	private int _maxLocalCount; // 0x24

	// Properties
	public int LocalCount { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x1A56F50 Offset: 0x1A55550 VA: 0x181A56F50
	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	// RVA: 0x1A57310 Offset: 0x1A55910 VA: 0x181A57310
	public void UndefineLocal(LocalDefinition definition, int end) { }

	// RVA: 0x1A56E00 Offset: 0x1A55400 VA: 0x181A56E00
	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	// RVA: 0x3CB160 Offset: 0x3C9760 VA: 0x1803CB160
	public int get_LocalCount() { }

	// RVA: 0x1A57220 Offset: 0x1A55820 VA: 0x181A57220
	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x1A56CF0 Offset: 0x1A552F0 VA: 0x181A56CF0
	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	// RVA: 0x1A573F0 Offset: 0x1A559F0 VA: 0x181A573F0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ModuloInstruction : Instruction // TypeDefIndex: 11138
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A57F00 Offset: 0x1A56500 VA: 0x181A57F00 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A57A80 Offset: 0x1A56080 VA: 0x181A57A80
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class MulInstruction : Instruction // TypeDefIndex: 11147
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A58EA0 Offset: 0x1A574A0 VA: 0x181A58EA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A58A20 Offset: 0x1A57020 VA: 0x181A58A20
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class MulOvfInstruction : Instruction // TypeDefIndex: 11154
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A59670 Offset: 0x1A57C70 VA: 0x181A59670 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A592D0 Offset: 0x1A578D0 VA: 0x181A592D0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NegateInstruction : Instruction // TypeDefIndex: 11160
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_Single; // 0x18
	private static Instruction s_Double; // 0x20

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A5B7D0 Offset: 0x1A59DD0 VA: 0x181A5B7D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A5B4B0 Offset: 0x1A59AB0 VA: 0x181A5B4B0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NegateCheckedInstruction : Instruction // TypeDefIndex: 11164
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A5B000 Offset: 0x1A59600 VA: 0x181A5B000 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A5AE00 Offset: 0x1A59400 VA: 0x181A5AE00
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class NewInstruction : Instruction // TypeDefIndex: 11165
{
	// Fields
	protected readonly ConstructorInfo _constructor; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1415660 Offset: 0x1413C60 VA: 0x181415660
	public void .ctor(ConstructorInfo constructor, int argumentCount) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A5BDE0 Offset: 0x1A5A3E0 VA: 0x181A5BDE0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A5BB50 Offset: 0x1A5A150 VA: 0x181A5BB50 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A5BA20 Offset: 0x1A5A020 VA: 0x181A5BA20
	protected object[] GetArgs(InterpretedFrame frame, int first) { }

	// RVA: 0x1A5BC70 Offset: 0x1A5A270 VA: 0x181A5BC70 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class ByRefNewInstruction : NewInstruction // TypeDefIndex: 11166
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A0B920 Offset: 0x1A09F20 VA: 0x181A0B920
	internal void .ctor(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1A4ABA0 Offset: 0x1A491A0 VA: 0x181A4ABA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A4A9B0 Offset: 0x1A48FB0 VA: 0x181A4A9B0 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NotEqualInstruction : Instruction // TypeDefIndex: 11191
{
	// Fields
	private static Instruction s_reference; // 0x0
	private static Instruction s_Boolean; // 0x8
	private static Instruction s_SByte; // 0x10
	private static Instruction s_Int16; // 0x18
	private static Instruction s_Char; // 0x20
	private static Instruction s_Int32; // 0x28
	private static Instruction s_Int64; // 0x30
	private static Instruction s_Byte; // 0x38
	private static Instruction s_UInt16; // 0x40
	private static Instruction s_UInt32; // 0x48
	private static Instruction s_UInt64; // 0x50
	private static Instruction s_Single; // 0x58
	private static Instruction s_Double; // 0x60
	private static Instruction s_SByteLiftedToNull; // 0x68
	private static Instruction s_Int16LiftedToNull; // 0x70
	private static Instruction s_CharLiftedToNull; // 0x78
	private static Instruction s_Int32LiftedToNull; // 0x80
	private static Instruction s_Int64LiftedToNull; // 0x88
	private static Instruction s_ByteLiftedToNull; // 0x90
	private static Instruction s_UInt16LiftedToNull; // 0x98
	private static Instruction s_UInt32LiftedToNull; // 0xA0
	private static Instruction s_UInt64LiftedToNull; // 0xA8
	private static Instruction s_SingleLiftedToNull; // 0xB0
	private static Instruction s_DoubleLiftedToNull; // 0xB8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A5D070 Offset: 0x1A5B670 VA: 0x181A5D070 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A5C4D0 Offset: 0x1A5AAD0 VA: 0x181A5C4D0
	public static Instruction Create(Type type, bool liftedToNull) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NotInstruction : Instruction // TypeDefIndex: 11201
{
	// Fields
	public static Instruction s_Boolean; // 0x0
	public static Instruction s_Int64; // 0x8
	public static Instruction s_Int32; // 0x10
	public static Instruction s_Int16; // 0x18
	public static Instruction s_UInt64; // 0x20
	public static Instruction s_UInt32; // 0x28
	public static Instruction s_UInt16; // 0x30
	public static Instruction s_Byte; // 0x38
	public static Instruction s_SByte; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A5E2F0 Offset: 0x1A5C8F0 VA: 0x181A5E2F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A5DDF0 Offset: 0x1A5C3F0 VA: 0x181A5DDF0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NullCheckInstruction : Instruction // TypeDefIndex: 11202
{
	// Fields
	public static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A5E7A0 Offset: 0x1A5CDA0 VA: 0x181A5E7A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A5E6C0 Offset: 0x1A5CCC0 VA: 0x181A5E6C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A5E730 Offset: 0x1A5CD30 VA: 0x181A5E730
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NumericConvertInstruction : Instruction // TypeDefIndex: 11206
{
	// Fields
	internal readonly TypeCode _from; // 0x10
	internal readonly TypeCode _to; // 0x14
	private readonly bool _isLiftedToNull; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1A4CD30 Offset: 0x1A4B330 VA: 0x181A4CD30
	protected void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1A5ECB0 Offset: 0x1A5D2B0 VA: 0x181A5ECB0 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract object Convert(object obj);

	// RVA: 0x1A5EF50 Offset: 0x1A5D550 VA: 0x181A5EF50 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A5EDB0 Offset: 0x1A5D3B0 VA: 0x181A5EDB0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class OrInstruction : Instruction // TypeDefIndex: 11216
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A5F6D0 Offset: 0x1A5DCD0 VA: 0x181A5F6D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A5F1D0 Offset: 0x1A5D7D0 VA: 0x181A5F1D0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class RightShiftInstruction : Instruction // TypeDefIndex: 11225
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A612A0 Offset: 0x1A5F8A0 VA: 0x181A612A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A60E20 Offset: 0x1A5F420 VA: 0x181A60E20
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RuntimeVariables : IRuntimeVariables // TypeDefIndex: 11226
{
	// Fields
	private readonly IStrongBox[] _boxes; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	private void .ctor(IStrongBox[] boxes) { }

	// RVA: 0x1A61C00 Offset: 0x1A60200 VA: 0x181A61C00
	internal static IRuntimeVariables Create(IStrongBox[] boxes) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadObjectInstruction : Instruction // TypeDefIndex: 11227
{
	// Fields
	private readonly object _value; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	internal void .ctor(object value) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A56890 Offset: 0x1A54E90 VA: 0x181A56890 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A56760 Offset: 0x1A54D60 VA: 0x181A56760 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A56800 Offset: 0x1A54E00 VA: 0x181A56800 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadCachedObjectInstruction : Instruction // TypeDefIndex: 11228
{
	// Fields
	private readonly uint _index; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	internal void .ctor(uint index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A56290 Offset: 0x1A54890 VA: 0x181A56290 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A56040 Offset: 0x1A54640 VA: 0x181A56040 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A560F0 Offset: 0x1A546F0 VA: 0x181A560F0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1A56230 Offset: 0x1A54830 VA: 0x181A56230 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class PopInstruction : Instruction // TypeDefIndex: 11229
{
	// Fields
	internal static readonly PopInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A60150 Offset: 0x1A5E750 VA: 0x181A60150 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A600B0 Offset: 0x1A5E6B0 VA: 0x181A600B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A600E0 Offset: 0x1A5E6E0 VA: 0x181A600E0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DupInstruction : Instruction // TypeDefIndex: 11230
{
	// Fields
	internal static readonly DupInstruction Instance; // 0x0

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A4E780 Offset: 0x1A4CD80 VA: 0x181A4E780 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A4E6E0 Offset: 0x1A4CCE0 VA: 0x181A4E6E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A4E710 Offset: 0x1A4CD10 VA: 0x181A4E710
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class SubInstruction : Instruction // TypeDefIndex: 11239
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A629D0 Offset: 0x1A60FD0 VA: 0x181A629D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A62550 Offset: 0x1A60B50 VA: 0x181A62550
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class SubOvfInstruction : Instruction // TypeDefIndex: 11246
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A631B0 Offset: 0x1A617B0 VA: 0x181A631B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A62E10 Offset: 0x1A61410 VA: 0x181A62E10
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CreateDelegateInstruction : Instruction // TypeDefIndex: 11247
{
	// Fields
	private readonly LightDelegateCreator _creator; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	internal void .ctor(LightDelegateCreator delegateCreator) { }

	// RVA: 0x1A4D010 Offset: 0x1A4B610 VA: 0x181A4D010 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A4D040 Offset: 0x1A4B640 VA: 0x181A4D040 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A4CE60 Offset: 0x1A4B460 VA: 0x181A4CE60 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeIsInstruction : Instruction // TypeDefIndex: 11248
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	internal void .ctor(Type type) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A65260 Offset: 0x1A63860 VA: 0x181A65260 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A65190 Offset: 0x1A63790 VA: 0x181A65190 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A65200 Offset: 0x1A63800 VA: 0x181A65200 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeAsInstruction : Instruction // TypeDefIndex: 11249
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	internal void .ctor(Type type) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A65060 Offset: 0x1A63660 VA: 0x181A65060 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A64F80 Offset: 0x1A63580 VA: 0x181A64F80 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A65000 Offset: 0x1A63600 VA: 0x181A65000 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeEqualsInstruction : Instruction // TypeDefIndex: 11250
{
	// Fields
	public static readonly TypeEqualsInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A65160 Offset: 0x1A63760 VA: 0x181A65160 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A65090 Offset: 0x1A63690 VA: 0x181A65090 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A650F0 Offset: 0x1A636F0 VA: 0x181A650F0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NullableMethodCallInstruction : Instruction // TypeDefIndex: 11258
{
	// Fields
	private static NullableMethodCallInstruction s_hasValue; // 0x0
	private static NullableMethodCallInstruction s_value; // 0x8
	private static NullableMethodCallInstruction s_equals; // 0x10
	private static NullableMethodCallInstruction s_getHashCode; // 0x18
	private static NullableMethodCallInstruction s_getValueOrDefault1; // 0x20
	private static NullableMethodCallInstruction s_toString; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A5EC80 Offset: 0x1A5D280 VA: 0x181A5EC80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	private void .ctor() { }

	// RVA: 0x1A5E870 Offset: 0x1A5CE70 VA: 0x181A5E870
	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	// RVA: 0x1A5E7D0 Offset: 0x1A5CDD0 VA: 0x181A5E7D0
	public static Instruction CreateGetValue() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class CastInstruction : Instruction // TypeDefIndex: 11263
{
	// Fields
	private static CastInstruction s_Boolean; // 0x0
	private static CastInstruction s_Byte; // 0x8
	private static CastInstruction s_Char; // 0x10
	private static CastInstruction s_DateTime; // 0x18
	private static CastInstruction s_Decimal; // 0x20
	private static CastInstruction s_Double; // 0x28
	private static CastInstruction s_Int16; // 0x30
	private static CastInstruction s_Int32; // 0x38
	private static CastInstruction s_Int64; // 0x40
	private static CastInstruction s_SByte; // 0x48
	private static CastInstruction s_Single; // 0x50
	private static CastInstruction s_String; // 0x58
	private static CastInstruction s_UInt16; // 0x60
	private static CastInstruction s_UInt32; // 0x68
	private static CastInstruction s_UInt64; // 0x70

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A4B7E0 Offset: 0x1A49DE0 VA: 0x181A4B7E0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A4AF50 Offset: 0x1A49550 VA: 0x181A4AF50
	public static Instruction Create(Type t) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CastToEnumInstruction : CastInstruction // TypeDefIndex: 11264
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type t) { }

	// RVA: 0x1A4BCA0 Offset: 0x1A4A2A0 VA: 0x181A4BCA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CastReferenceToEnumInstruction : CastInstruction // TypeDefIndex: 11265
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type t) { }

	// RVA: 0x1A4B810 Offset: 0x1A49E10 VA: 0x181A4B810 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class QuoteInstruction : Instruction // TypeDefIndex: 11267
{
	// Fields
	private readonly Expression _operand; // 0x10
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; // 0x18

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A60450 Offset: 0x1A5EA50 VA: 0x181A60450 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A60310 Offset: 0x1A5E910 VA: 0x181A60310 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class DelegateHelpers // TypeDefIndex: 11269
{
	// Methods

	// RVA: 0x1A4DF00 Offset: 0x1A4C500 VA: 0x181A4DF00
	internal static Type MakeDelegate(Type[] types) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class ScriptingRuntimeHelpers // TypeDefIndex: 11270
{
	// Methods

	// RVA: 0x1A62020 Offset: 0x1A60620 VA: 0x181A62020
	public static object Int32ToObject(int i) { }

	// RVA: 0x1A61C60 Offset: 0x1A60260 VA: 0x181A61C60
	internal static object GetPrimitiveDefaultValue(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class ExceptionHelpers // TypeDefIndex: 11271
{
	// Methods

	// RVA: 0x1A50130 Offset: 0x1A4E730 VA: 0x181A50130
	public static void UnwrapAndRethrow(TargetInvocationException exception) { }
}

// Namespace: System.Linq.Expressions.Interpreter
[DefaultMember("Item")]
internal class HybridReferenceDictionary<TKey, TValue> // TypeDefIndex: 11273
{
	// Fields
	private KeyValuePair<TKey, TValue>[] _keysAndValues; // 0x0
	private Dictionary<TKey, TValue> _dict; // 0x0

	// Properties
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F400 Offset: 0x108DA00 VA: 0x18108F400
	|-HybridReferenceDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x108F4A0 Offset: 0x108DAA0 VA: 0x18108F4A0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F370 Offset: 0x108D970 VA: 0x18108F370
	|-HybridReferenceDictionary<object, object>.Remove
	|
	|-RVA: 0x108F210 Offset: 0x108D810 VA: 0x18108F210
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108EE10 Offset: 0x108D410 VA: 0x18108EE10
	|-HybridReferenceDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x108ED00 Offset: 0x108D300 VA: 0x18108ED00
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F0E0 Offset: 0x108D6E0 VA: 0x18108F0E0
	|-HybridReferenceDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x108EFF0 Offset: 0x108D5F0 VA: 0x18108EFF0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[IteratorStateMachine(typeof(HybridReferenceDictionary.<GetEnumeratorWorker>d__7<TKey, TValue>))]
	// RVA: -1 Offset: -1
	private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108EF60 Offset: 0x108D560 VA: 0x18108EF60
	|-HybridReferenceDictionary<object, object>.GetEnumeratorWorker
	|
	|-RVA: 0x108EE90 Offset: 0x108D490 VA: 0x18108EE90
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.GetEnumeratorWorker
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F830 Offset: 0x108DE30 VA: 0x18108F830
	|-HybridReferenceDictionary<object, object>.get_Item
	|
	|-RVA: 0x108F6C0 Offset: 0x108DCC0 VA: 0x18108F6C0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x108F970 Offset: 0x108DF70 VA: 0x18108F970
	|-HybridReferenceDictionary<object, object>.set_Item
	|
	|-RVA: 0x108FC90 Offset: 0x108E290 VA: 0x18108FC90
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-HybridReferenceDictionary<object, object>..ctor
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>..ctor
	*/
}

