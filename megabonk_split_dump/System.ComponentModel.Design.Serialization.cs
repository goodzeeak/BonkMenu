// Namespace: System.ComponentModel.Design.Serialization
public sealed class InstanceDescriptor // TypeDefIndex: 7686
{
	// Fields
	[CompilerGenerated]
	private readonly ICollection <Arguments>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <IsComplete>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly MemberInfo <MemberInfo>k__BackingField; // 0x20

	// Properties
	public ICollection Arguments { get; }
	public MemberInfo MemberInfo { get; }

	// Methods

	// RVA: 0x1E54C30 Offset: 0x1E53230 VA: 0x181E54C30
	public void .ctor(MemberInfo member, ICollection arguments) { }

	// RVA: 0x1E54C50 Offset: 0x1E53250 VA: 0x181E54C50
	public void .ctor(MemberInfo member, ICollection arguments, bool isComplete) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ICollection get_Arguments() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x1E54850 Offset: 0x1E52E50 VA: 0x181E54850
	public object Invoke() { }
}

// Namespace: System.ComponentModel.Design.Serialization
[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
[Usage(1028, AllowMultiple = True, Inherited = True)]
public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 7687
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly bool <Reloadable>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <SerializerTypeName>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <SerializerBaseTypeName>k__BackingField; // 0x28

	// Properties
	public string SerializerBaseTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x1E5D560 Offset: 0x1E5BB60 VA: 0x181E5D560
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x1E5D5D0 Offset: 0x1E5BBD0 VA: 0x181E5D5D0 Slot: 4
	public override object get_TypeId() { }
}

