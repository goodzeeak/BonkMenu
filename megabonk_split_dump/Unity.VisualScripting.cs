// Namespace: Unity.VisualScripting
public abstract class Cloner<T> : ICloner // TypeDefIndex: 8848
{
	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-Cloner<object>..ctor
	|-Cloner<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Handles(Type type);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Cloner<__Il2CppFullySharedGenericType>.Handles
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void Unity.VisualScripting.ICloner.BeforeClone(Type type, object original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9EED0 Offset: 0xC9D4D0 VA: 0x180C9EED0
	|-Cloner<object>.Unity.VisualScripting.ICloner.BeforeClone
	|
	|-RVA: 0xC9EF70 Offset: 0xC9D570 VA: 0x180C9EF70
	|-Cloner<__Il2CppFullySharedGenericType>.Unity.VisualScripting.ICloner.BeforeClone
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual void BeforeClone(Type type, T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-Cloner<object>.BeforeClone
	|-Cloner<__Il2CppFullySharedGenericType>.BeforeClone
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private object Unity.VisualScripting.ICloner.ConstructClone(Type type, object original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9F190 Offset: 0xC9D790 VA: 0x180C9F190
	|-Cloner<object>.Unity.VisualScripting.ICloner.ConstructClone
	|
	|-RVA: 0xC9F060 Offset: 0xC9D660 VA: 0x180C9F060
	|-Cloner<__Il2CppFullySharedGenericType>.Unity.VisualScripting.ICloner.ConstructClone
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual T ConstructClone(Type type, T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9ECD0 Offset: 0xC9D2D0 VA: 0x180C9ECD0
	|-Cloner<object>.ConstructClone
	|
	|-RVA: 0xC9EC10 Offset: 0xC9D210 VA: 0x180C9EC10
	|-Cloner<__Il2CppFullySharedGenericType>.ConstructClone
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void Unity.VisualScripting.ICloner.FillClone(Type type, ref object clone, object original, CloningContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9F430 Offset: 0xC9DA30 VA: 0x180C9F430
	|-Cloner<object>.Unity.VisualScripting.ICloner.FillClone
	|
	|-RVA: 0xC9F230 Offset: 0xC9D830 VA: 0x180C9F230
	|-Cloner<__Il2CppFullySharedGenericType>.Unity.VisualScripting.ICloner.FillClone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void FillClone(Type type, ref T clone, T original, CloningContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-Cloner<object>.FillClone
	|-Cloner<__Il2CppFullySharedGenericType>.FillClone
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void Unity.VisualScripting.ICloner.AfterClone(Type type, object clone) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC9EE30 Offset: 0xC9D430 VA: 0x180C9EE30
	|-Cloner<object>.Unity.VisualScripting.ICloner.AfterClone
	|
	|-RVA: 0xC9ED40 Offset: 0xC9D340 VA: 0x180C9ED40
	|-Cloner<__Il2CppFullySharedGenericType>.Unity.VisualScripting.ICloner.AfterClone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void AfterClone(Type type, T clone) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-Cloner<object>.AfterClone
	|-Cloner<__Il2CppFullySharedGenericType>.AfterClone
	*/
}

// Namespace: Unity.VisualScripting
public sealed class AnimationCurveCloner : Cloner<AnimationCurve> // TypeDefIndex: 8849
{
	// Methods

	// RVA: 0x21EBAB0 Offset: 0x21EA0B0 VA: 0x1821EBAB0 Slot: 9
	public override bool Handles(Type type) { }

	// RVA: 0x21EB960 Offset: 0x21E9F60 VA: 0x1821EB960 Slot: 11
	public override AnimationCurve ConstructClone(Type type, AnimationCurve original) { }

	// RVA: 0x21EB9B0 Offset: 0x21E9FB0 VA: 0x1821EB9B0 Slot: 12
	public override void FillClone(Type type, ref AnimationCurve clone, AnimationCurve original, CloningContext context) { }

	// RVA: 0x21EBB20 Offset: 0x21EA120 VA: 0x1821EBB20
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class ArrayCloner : Cloner<Array> // TypeDefIndex: 8850
{
	// Methods

	// RVA: 0x21EC010 Offset: 0x21EA610 VA: 0x1821EC010 Slot: 9
	public override bool Handles(Type type) { }

	// RVA: 0x21EBE60 Offset: 0x21EA460 VA: 0x1821EBE60 Slot: 11
	public override Array ConstructClone(Type type, Array original) { }

	// RVA: 0x21EBEA0 Offset: 0x21EA4A0 VA: 0x1821EBEA0 Slot: 12
	public override void FillClone(Type type, ref Array clone, Array original, CloningContext context) { }

	// RVA: 0x21EC030 Offset: 0x21EA630 VA: 0x1821EC030
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class DictionaryCloner : Cloner<IDictionary> // TypeDefIndex: 8851
{
	// Methods

	// RVA: 0x21F5430 Offset: 0x21F3A30 VA: 0x1821F5430 Slot: 9
	public override bool Handles(Type type) { }

	// RVA: 0x21F50A0 Offset: 0x21F36A0 VA: 0x1821F50A0 Slot: 12
	public override void FillClone(Type type, ref IDictionary clone, IDictionary original, CloningContext context) { }

	// RVA: 0x21F54B0 Offset: 0x21F3AB0 VA: 0x1821F54B0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class EnumerableCloner : Cloner<IEnumerable> // TypeDefIndex: 8852
{
	// Fields
	private readonly Dictionary<Type, IOptimizedInvoker> addMethods; // 0x10

	// Methods

	// RVA: 0x21F8510 Offset: 0x21F6B10 VA: 0x1821F8510 Slot: 9
	public override bool Handles(Type type) { }

	// RVA: 0x21F7F60 Offset: 0x21F6560 VA: 0x1821F7F60 Slot: 12
	public override void FillClone(Type type, ref IEnumerable clone, IEnumerable original, CloningContext context) { }

	// RVA: 0x21F82D0 Offset: 0x21F68D0 VA: 0x1821F82D0
	private IOptimizedInvoker GetAddMethod(Type type) { }

	// RVA: 0x21F8620 Offset: 0x21F6C20 VA: 0x1821F8620
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class FakeSerializationCloner : ReflectedCloner // TypeDefIndex: 8854
{
	// Fields
	[CompilerGenerated]
	private fsConfig <config>k__BackingField; // 0x20

	// Properties
	public fsConfig config { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public fsConfig get_config() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_config(fsConfig value) { }

	// RVA: 0x21FA570 Offset: 0x21F8B70 VA: 0x1821FA570 Slot: 10
	public override void BeforeClone(Type type, object original) { }

	// RVA: 0x21FA510 Offset: 0x21F8B10 VA: 0x1821FA510 Slot: 13
	public override void AfterClone(Type type, object clone) { }

	// RVA: 0x21FA5D0 Offset: 0x21F8BD0 VA: 0x1821FA5D0 Slot: 14
	protected override IEnumerable<MemberInfo> GetMembers(Type type) { }

	// RVA: 0x21FA730 Offset: 0x21F8D30 VA: 0x1821FA730
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class FieldsCloner : ReflectedCloner // TypeDefIndex: 8855
{
	// Methods

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 15
	protected override bool IncludeField(FieldInfo field) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 16
	protected override bool IncludeProperty(PropertyInfo property) { }

	// RVA: 0x21FA7A0 Offset: 0x21F8DA0 VA: 0x1821FA7A0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class ListCloner : Cloner<IList> // TypeDefIndex: 8856
{
	// Methods

	// RVA: 0x2204A30 Offset: 0x2203030 VA: 0x182204A30 Slot: 9
	public override bool Handles(Type type) { }

	// RVA: 0x22044E0 Offset: 0x2202AE0 VA: 0x1822044E0 Slot: 12
	public override void FillClone(Type type, ref IList clone, IList original, CloningContext context) { }

	// RVA: 0x2204AB0 Offset: 0x22030B0 VA: 0x182204AB0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public abstract class ReflectedCloner : Cloner<object> // TypeDefIndex: 8857
{
	// Fields
	private readonly Dictionary<Type, MemberInfo[]> accessors; // 0x10
	private readonly Dictionary<Type, IOptimizedAccessor[]> optimizedAccessors; // 0x18

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 9
	public override bool Handles(Type type) { }

	// RVA: 0x220C070 Offset: 0x220A670 VA: 0x18220C070 Slot: 12
	public override void FillClone(Type type, ref object clone, object original, CloningContext context) { }

	// RVA: 0x220C650 Offset: 0x220AC50 VA: 0x18220C650
	private MemberInfo[] GetAccessors(Type type) { }

	// RVA: 0x220C960 Offset: 0x220AF60 VA: 0x18220C960
	private IOptimizedAccessor[] GetOptimizedAccessors(Type type) { }

	// RVA: 0x220C740 Offset: 0x220AD40 VA: 0x18220C740 Slot: 14
	protected virtual IEnumerable<MemberInfo> GetMembers(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 15
	protected virtual bool IncludeField(FieldInfo field) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 16
	protected virtual bool IncludeProperty(PropertyInfo property) { }

	// RVA: 0x220CDC0 Offset: 0x220B3C0 VA: 0x18220CDC0
	protected void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Extension]
public static class Cloning // TypeDefIndex: 8859
{
	// Fields
	private static readonly Dictionary<Type, bool> skippable; // 0x0
	[CompilerGenerated]
	private static readonly HashSet<ICloner> <cloners>k__BackingField; // 0x8
	[CompilerGenerated]
	private static readonly ArrayCloner <arrayCloner>k__BackingField; // 0x10
	[CompilerGenerated]
	private static readonly DictionaryCloner <dictionaryCloner>k__BackingField; // 0x18
	[CompilerGenerated]
	private static readonly EnumerableCloner <enumerableCloner>k__BackingField; // 0x20
	[CompilerGenerated]
	private static readonly ListCloner <listCloner>k__BackingField; // 0x28
	[CompilerGenerated]
	private static readonly AnimationCurveCloner <animationCurveCloner>k__BackingField; // 0x30
	[CompilerGenerated]
	private static readonly FieldsCloner <fieldsCloner>k__BackingField; // 0x38
	[CompilerGenerated]
	private static readonly FakeSerializationCloner <fakeSerializationCloner>k__BackingField; // 0x40

	// Properties
	public static HashSet<ICloner> cloners { get; }
	public static ArrayCloner arrayCloner { get; }
	public static DictionaryCloner dictionaryCloner { get; }
	public static EnumerableCloner enumerableCloner { get; }
	public static ListCloner listCloner { get; }
	public static AnimationCurveCloner animationCurveCloner { get; }
	public static FieldsCloner fieldsCloner { get; }
	public static FakeSerializationCloner fakeSerializationCloner { get; }

	// Methods

	// RVA: 0x21EFC80 Offset: 0x21EE280 VA: 0x1821EFC80
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x21F04C0 Offset: 0x21EEAC0 VA: 0x1821F04C0
	public static HashSet<ICloner> get_cloners() { }

	[CompilerGenerated]
	// RVA: 0x21F0470 Offset: 0x21EEA70 VA: 0x1821F0470
	public static ArrayCloner get_arrayCloner() { }

	[CompilerGenerated]
	// RVA: 0x21F0510 Offset: 0x21EEB10 VA: 0x1821F0510
	public static DictionaryCloner get_dictionaryCloner() { }

	[CompilerGenerated]
	// RVA: 0x21F0560 Offset: 0x21EEB60 VA: 0x1821F0560
	public static EnumerableCloner get_enumerableCloner() { }

	[CompilerGenerated]
	// RVA: 0x21F0650 Offset: 0x21EEC50 VA: 0x1821F0650
	public static ListCloner get_listCloner() { }

	[CompilerGenerated]
	// RVA: 0x21F0420 Offset: 0x21EEA20 VA: 0x1821F0420
	public static AnimationCurveCloner get_animationCurveCloner() { }

	[CompilerGenerated]
	// RVA: 0x21F0600 Offset: 0x21EEC00 VA: 0x1821F0600
	public static FieldsCloner get_fieldsCloner() { }

	[CompilerGenerated]
	// RVA: 0x21F05B0 Offset: 0x21EEBB0 VA: 0x1821F05B0
	public static FakeSerializationCloner get_fakeSerializationCloner() { }

	[Extension]
	// RVA: 0x21EF410 Offset: 0x21EDA10 VA: 0x1821EF410
	public static object Clone(object original, ICloner fallbackCloner, bool tryPreserveInstances) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T Clone<T>(T original, ICloner fallbackCloner, bool tryPreserveInstances) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B4630 Offset: 0x6B2C30 VA: 0x1806B4630
	|-Cloning.Clone<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x21EF380 Offset: 0x21ED980 VA: 0x1821EF380
	public static object CloneViaFakeSerialization(object original) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T CloneViaFakeSerialization<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B4590 Offset: 0x6B2B90 VA: 0x1806B4590
	|-Cloning.CloneViaFakeSerialization<object>
	|
	|-RVA: 0x6B4450 Offset: 0x6B2A50 VA: 0x1806B4450
	|-Cloning.CloneViaFakeSerialization<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21EF680 Offset: 0x21EDC80 VA: 0x1821EF680
	internal static object Clone(CloningContext context, object original) { }

	// RVA: 0x21EF050 Offset: 0x21ED650 VA: 0x1821EF050
	internal static void CloneInto(CloningContext context, ref object clone, object original) { }

	[CanBeNull]
	// RVA: 0x21EF6F0 Offset: 0x21EDCF0 VA: 0x1821EF6F0
	public static ICloner GetCloner(object original, Type type) { }

	// RVA: 0x21EF870 Offset: 0x21EDE70 VA: 0x1821EF870
	private static ICloner GetCloner(object original, Type type, ICloner fallbackCloner) { }

	// RVA: 0x21EFA80 Offset: 0x21EE080 VA: 0x1821EFA80
	private static bool Skippable(Type type) { }
}

// Namespace: Unity.VisualScripting
public sealed class CloningContext : IPoolable, IDisposable // TypeDefIndex: 8861
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<object, object> <clonings>k__BackingField; // 0x10
	[CompilerGenerated]
	private ICloner <fallbackCloner>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <tryPreserveInstances>k__BackingField; // 0x20
	private bool disposed; // 0x21

	// Properties
	public Dictionary<object, object> clonings { get; }
	public ICloner fallbackCloner { get; set; }
	public bool tryPreserveInstances { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Dictionary<object, object> get_clonings() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ICloner get_fallbackCloner() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_fallbackCloner(ICloner value) { }

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_tryPreserveInstances() { }

	[CompilerGenerated]
	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	private void set_tryPreserveInstances(bool value) { }

	// RVA: 0x21EEF80 Offset: 0x21ED580 VA: 0x1821EEF80 Slot: 4
	private void Unity.VisualScripting.IPoolable.New() { }

	// RVA: 0x21EEF30 Offset: 0x21ED530 VA: 0x1821EEF30 Slot: 5
	private void Unity.VisualScripting.IPoolable.Free() { }

	// RVA: 0x21EED10 Offset: 0x21ED310 VA: 0x1821EED10 Slot: 6
	public void Dispose() { }

	// RVA: 0x21EEDD0 Offset: 0x21ED3D0 VA: 0x1821EEDD0
	public static CloningContext New(ICloner fallbackCloner, bool tryPreserveInstances) { }

	// RVA: 0x21EEF90 Offset: 0x21ED590 VA: 0x1821EEF90
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public interface ICloner // TypeDefIndex: 8862
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Handles(Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object ConstructClone(Type type, object original);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void BeforeClone(Type type, object original);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void FillClone(Type type, ref object clone, object original, CloningContext context);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AfterClone(Type type, object clone);
}

// Namespace: Unity.VisualScripting
public interface ISpecifiesCloner // TypeDefIndex: 8863
{
	// Properties
	public abstract ICloner cloner { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ICloner get_cloner();
}

// Namespace: Unity.VisualScripting
public sealed class AotDictionary : OrderedDictionary // TypeDefIndex: 8864
{
	// Methods

	// RVA: 0x21EBD10 Offset: 0x21EA310 VA: 0x1821EBD10
	public void .ctor() { }

	// RVA: 0x21EBD40 Offset: 0x21EA340 VA: 0x1821EBD40
	public void .ctor(IEqualityComparer comparer) { }

	// RVA: 0x21EBD20 Offset: 0x21EA320 VA: 0x1821EBD20
	public void .ctor(int capacity) { }

	// RVA: 0x21EBD30 Offset: 0x21EA330 VA: 0x1821EBD30
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	[Preserve]
	// RVA: 0x21EBC60 Offset: 0x21EA260 VA: 0x1821EBC60
	public static void AotStubs() { }
}

// Namespace: Unity.VisualScripting
public sealed class AotList : ArrayList // TypeDefIndex: 8865
{
	// Methods

	// RVA: 0x1D60EF0 Offset: 0x1D5F4F0 VA: 0x181D60EF0
	public void .ctor() { }

	// RVA: 0x21EBE50 Offset: 0x21EA450 VA: 0x1821EBE50
	public void .ctor(int capacity) { }

	// RVA: 0x21EBE40 Offset: 0x21EA440 VA: 0x1821EBE40
	public void .ctor(ICollection c) { }

	[Preserve]
	// RVA: 0x21EBD50 Offset: 0x21EA350 VA: 0x1821EBD50
	public static void AotStubs() { }
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
public class DebugDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection // TypeDefIndex: 8866
{
	// Fields
	private readonly Dictionary<TKey, TValue> dictionary; // 0x0
	[CompilerGenerated]
	private string <label>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <debug>k__BackingField; // 0x0

	// Properties
	public TValue Item { get; set; }
	private object System.Collections.IDictionary.Item { get; set; }
	public string label { get; set; }
	public bool debug { get; set; }
	public int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	public ICollection<TKey> Keys { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	public ICollection<TValue> Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD36000 Offset: 0xD34600 VA: 0x180D36000
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD361D0 Offset: 0xD347D0 VA: 0x180D361D0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35A50 Offset: 0xD34050 VA: 0x180D35A50
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35C30 Offset: 0xD34230 VA: 0x180D35C30
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public string get_label() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_label
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_label(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_label
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public bool get_debug() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_debug
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_debug(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_debug
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35FC0 Offset: 0xD345C0 VA: 0x180D35FC0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD355B0 Offset: 0xD33BB0 VA: 0x180D355B0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35560 Offset: 0xD33B60 VA: 0x180D35560
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35BE0 Offset: 0xD341E0 VA: 0x180D35BE0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35A00 Offset: 0xD34000 VA: 0x180D35A00
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD359B0 Offset: 0xD33FB0 VA: 0x180D359B0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35440 Offset: 0xD33A40 VA: 0x180D35440
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD36150 Offset: 0xD34750 VA: 0x180D36150
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35B90 Offset: 0xD34190 VA: 0x180D35B90
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD36190 Offset: 0xD34790 VA: 0x180D36190
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35490 Offset: 0xD33A90 VA: 0x180D35490
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void Debug(string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD34DB0 Offset: 0xD333B0 VA: 0x180D34DB0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Debug
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35DB0 Offset: 0xD343B0 VA: 0x180D35DB0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD358C0 Offset: 0xD33EC0 VA: 0x180D358C0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35780 Offset: 0xD33D80 VA: 0x180D35780
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35600 Offset: 0xD33C00 VA: 0x180D35600
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD34B80 Offset: 0xD33180 VA: 0x180D34B80
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35870 Offset: 0xD33E70 VA: 0x180D35870
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD34D00 Offset: 0xD33300 VA: 0x180D34D00
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35180 Offset: 0xD33780 VA: 0x180D35180
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD352B0 Offset: 0xD338B0 VA: 0x180D352B0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35380 Offset: 0xD33980 VA: 0x180D35380
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD34F10 Offset: 0xD33510 VA: 0x180D34F10
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD34C00 Offset: 0xD33200 VA: 0x180D34C00
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD348D0 Offset: 0xD32ED0 VA: 0x180D348D0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD34FD0 Offset: 0xD335D0 VA: 0x180D34FD0
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35E00 Offset: 0xD34400 VA: 0x180D35E00
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35F00 Offset: 0xD34500 VA: 0x180D35F00
	|-DebugDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
public class FlexibleDictionary<TKey, TValue> : Dictionary<TKey, TValue> // TypeDefIndex: 8867
{
	// Properties
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100ED50 Offset: 0x100D350 VA: 0x18100ED50
	|-FlexibleDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100EEA0 Offset: 0x100D4A0 VA: 0x18100EEA0
	|-FlexibleDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100ED30 Offset: 0x100D330 VA: 0x18100ED30
	|-FlexibleDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.VisualScripting
public class GuidCollection<T> : KeyedCollection<Guid, T>, IKeyedCollection<Guid, T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 8868
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 39
	protected override Guid GetKeyForItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1034BA0 Offset: 0x10331A0 VA: 0x181034BA0
	|-GuidCollection<__Il2CppFullySharedGenericType>.GetKeyForItem
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1034CA0 Offset: 0x10332A0 VA: 0x181034CA0
	|-GuidCollection<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected override void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1034EA0 Offset: 0x10334A0 VA: 0x181034EA0
	|-GuidCollection<__Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 42
	public bool TryGetValue(Guid key, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10350A0 Offset: 0x10336A0 VA: 0x1810350A0
	|-GuidCollection<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9601F0 Offset: 0x95E7F0 VA: 0x1809601F0
	|-GuidCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private T Unity.VisualScripting.IKeyedCollection<System.Guid,T>.get_Item(Guid key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10352F0 Offset: 0x10338F0 VA: 0x1810352F0
	|-GuidCollection<__Il2CppFullySharedGenericType>.Unity.VisualScripting.IKeyedCollection<System.Guid,T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 43
	private bool Unity.VisualScripting.IKeyedCollection<System.Guid,T>.Contains(Guid key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1035230 Offset: 0x1033830 VA: 0x181035230
	|-GuidCollection<__Il2CppFullySharedGenericType>.Unity.VisualScripting.IKeyedCollection<System.Guid,T>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 44
	private bool Unity.VisualScripting.IKeyedCollection<System.Guid,T>.Remove(Guid key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1035290 Offset: 0x1033890 VA: 0x181035290
	|-GuidCollection<__Il2CppFullySharedGenericType>.Unity.VisualScripting.IKeyedCollection<System.Guid,T>.Remove
	*/
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
public interface IKeyedCollection<TKey, TItem> : ICollection<TItem>, IEnumerable<TItem>, IEnumerable // TypeDefIndex: 8869
{
	// Properties
	public abstract TItem Item { get; }
	public abstract TItem Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TItem get_Item(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TItem get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool TryGetValue(TKey key, out TItem value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Contains(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Remove(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/
}

// Namespace: Unity.VisualScripting
public interface IMergedCollection<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 8870
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Includes<TI>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMergedCollection<__Il2CppFullySharedGenericType>.Includes<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool Includes(Type elementType);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMergedCollection<__Il2CppFullySharedGenericType>.Includes
	*/
}

// Namespace: Unity.VisualScripting
public interface INotifiedCollectionItem // TypeDefIndex: 8871
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void BeforeAdd();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AfterAdd();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void BeforeRemove();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AfterRemove();
}

// Namespace: Unity.VisualScripting
public interface INotifyCollectionChanged<T> // TypeDefIndex: 8872
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_ItemAdded(Action<T> value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INotifyCollectionChanged<__Il2CppFullySharedGenericType>.add_ItemAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_ItemAdded(Action<T> value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INotifyCollectionChanged<__Il2CppFullySharedGenericType>.remove_ItemAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_ItemRemoved(Action<T> value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INotifyCollectionChanged<__Il2CppFullySharedGenericType>.add_ItemRemoved
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_ItemRemoved(Action<T> value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INotifyCollectionChanged<__Il2CppFullySharedGenericType>.remove_ItemRemoved
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_CollectionChanged(Action value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INotifyCollectionChanged<__Il2CppFullySharedGenericType>.add_CollectionChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_CollectionChanged(Action value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INotifyCollectionChanged<__Il2CppFullySharedGenericType>.remove_CollectionChanged
	*/
}

// Namespace: Unity.VisualScripting
public interface IProxyableNotifyCollectionChanged<T> // TypeDefIndex: 8873
{
	// Properties
	public abstract bool ProxyCollectionChange { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_ProxyCollectionChange();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProxyableNotifyCollectionChanged<__Il2CppFullySharedGenericType>.get_ProxyCollectionChange
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_ProxyCollectionChange(bool value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProxyableNotifyCollectionChanged<__Il2CppFullySharedGenericType>.set_ProxyCollectionChange
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void BeforeAdd(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProxyableNotifyCollectionChanged<__Il2CppFullySharedGenericType>.BeforeAdd
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AfterAdd(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProxyableNotifyCollectionChanged<__Il2CppFullySharedGenericType>.AfterAdd
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void BeforeRemove(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProxyableNotifyCollectionChanged<__Il2CppFullySharedGenericType>.BeforeRemove
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AfterRemove(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IProxyableNotifyCollectionChanged<__Il2CppFullySharedGenericType>.AfterRemove
	*/
}

// Namespace: Unity.VisualScripting
public interface ISet<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 8874
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Add(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UnionWith(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.UnionWith
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void IntersectWith(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IntersectWith
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ExceptWith(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.ExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SymmetricExceptWith(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.SymmetricExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool IsSubsetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool IsSupersetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsProperSupersetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsProperSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsProperSubsetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsProperSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Overlaps(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.Overlaps
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool SetEquals(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.SetEquals
	*/
}

// Namespace: Unity.VisualScripting
public class MergedCollection<T> : IMergedCollection<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 8876
{
	// Fields
	private readonly Dictionary<Type, ICollection<T>> collections; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CE3F0 Offset: 0x9CC9F0 VA: 0x1809CE3F0
	|-MergedCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1290570 Offset: 0x128EB70 VA: 0x181290570
	|-MergedCollection<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-MergedCollection<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public void Include<TI>(ICollection<TI> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6062A0 Offset: 0x6048A0 VA: 0x1806062A0
	|-MergedCollection<__Il2CppFullySharedGenericType>.Include<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Includes<TI>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x606390 Offset: 0x604990 VA: 0x180606390
	|-MergedCollection<__Il2CppFullySharedGenericType>.Includes<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool Includes(Type implementationType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1290390 Offset: 0x128E990 VA: 0x181290390
	|-MergedCollection<__Il2CppFullySharedGenericType>.Includes
	*/

	// RVA: -1 Offset: -1
	public ICollection<TI> ForType<TI>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x606150 Offset: 0x604750 VA: 0x180606150
	|-MergedCollection<__Il2CppFullySharedGenericType>.ForType<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8FB170 Offset: 0x8F9770 VA: 0x1808FB170
	|-MergedCollection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[IteratorStateMachine(typeof(MergedCollection.<GetEnumerator>d__11<T>))]
	// RVA: -1 Offset: -1 Slot: 13
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12902C0 Offset: 0x128E8C0 VA: 0x1812902C0
	|-MergedCollection<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private ICollection<T> GetCollectionForItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128FCF0 Offset: 0x128E2F0 VA: 0x18128FCF0
	|-MergedCollection<__Il2CppFullySharedGenericType>.GetCollectionForItem
	*/

	// RVA: -1 Offset: -1
	private ICollection<T> GetCollectionForType(Type type, bool throwOnFail = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128FF30 Offset: 0x128E530 VA: 0x18128FF30
	|-MergedCollection<__Il2CppFullySharedGenericType>.GetCollectionForType
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128F7E0 Offset: 0x128DDE0 VA: 0x18128F7E0
	|-MergedCollection<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128F3E0 Offset: 0x128D9E0 VA: 0x18128F3E0
	|-MergedCollection<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128F580 Offset: 0x128DB80 VA: 0x18128F580
	|-MergedCollection<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public virtual bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12903D0 Offset: 0x128E9D0 VA: 0x1812903D0
	|-MergedCollection<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128F980 Offset: 0x128DF80 VA: 0x18128F980
	|-MergedCollection<__Il2CppFullySharedGenericType>.CopyTo
	*/
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
public class MergedKeyedCollection<TKey, TItem> : IMergedCollection<TItem>, ICollection<TItem>, IEnumerable<TItem>, IEnumerable // TypeDefIndex: 8878
{
	// Fields
	protected readonly Dictionary<Type, IKeyedCollection<TKey, TItem>> collections; // 0x0
	protected readonly Dictionary<Type, IKeyedCollection<TKey, TItem>> collectionsLookup; // 0x0

	// Properties
	public TItem Item { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1293540 Offset: 0x1291B40 VA: 0x181293540
	|-MergedKeyedCollection<Guid, object>..ctor
	|
	|-RVA: 0x1293470 Offset: 0x1291A70 VA: 0x181293470
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TItem get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1293F50 Offset: 0x1292550 VA: 0x181293F50
	|-MergedKeyedCollection<Guid, object>.get_Item
	|
	|-RVA: 0x1293A80 Offset: 0x1292080 VA: 0x181293A80
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1293890 Offset: 0x1291E90 VA: 0x181293890
	|-MergedKeyedCollection<Guid, object>.get_Count
	|
	|-RVA: 0x1293610 Offset: 0x1291C10 VA: 0x181293610
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-MergedKeyedCollection<Guid, object>.get_IsReadOnly
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Includes<TSubItem>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6066B0 Offset: 0x604CB0 VA: 0x1806066B0
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Includes<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool Includes(Type elementType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1292A80 Offset: 0x1291080 VA: 0x181292A80
	|-MergedKeyedCollection<Guid, object>.Includes
	|
	|-RVA: 0x1292AB0 Offset: 0x12910B0 VA: 0x181292AB0
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Includes
	*/

	// RVA: -1 Offset: -1
	public IKeyedCollection<TKey, TSubItem> ForType<TSubItem>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x606420 Offset: 0x604A20 VA: 0x180606420
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ForType<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void Include<TSubItem>(IKeyedCollection<TKey, TSubItem> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x606580 Offset: 0x604B80 VA: 0x180606580
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Include<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected IKeyedCollection<TKey, TItem> GetCollectionForItem(TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1291890 Offset: 0x128FE90 VA: 0x181291890
	|-MergedKeyedCollection<Guid, object>.GetCollectionForItem
	|
	|-RVA: 0x1291970 Offset: 0x128FF70 VA: 0x181291970
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetCollectionForItem
	*/

	// RVA: -1 Offset: -1
	protected IKeyedCollection<TKey, TItem> GetCollectionForType(Type type, bool throwOnFail = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1292680 Offset: 0x1290C80 VA: 0x181292680
	|-MergedKeyedCollection<Guid, object>.GetCollectionForType
	|
	|-RVA: 0x1292250 Offset: 0x1290850 VA: 0x181292250
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetCollectionForType
	*/

	// RVA: -1 Offset: -1
	protected IKeyedCollection<TKey, TItem> GetCollectionForKey(TKey key, bool throwOnFail = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1291BA0 Offset: 0x12901A0 VA: 0x181291BA0
	|-MergedKeyedCollection<Guid, object>.GetCollectionForKey
	|
	|-RVA: 0x1291E70 Offset: 0x1290470 VA: 0x181291E70
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetCollectionForKey
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TItem value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1293360 Offset: 0x1291960 VA: 0x181293360
	|-MergedKeyedCollection<Guid, object>.TryGetValue
	|
	|-RVA: 0x1293120 Offset: 0x1291720 VA: 0x181293120
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual void Add(TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12907D0 Offset: 0x128EDD0 VA: 0x1812907D0
	|-MergedKeyedCollection<Guid, object>.Add
	|
	|-RVA: 0x1290850 Offset: 0x128EE50 VA: 0x181290850
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12909E0 Offset: 0x128EFE0 VA: 0x1812909E0
	|-MergedKeyedCollection<Guid, object>.Clear
	|
	|-RVA: 0x1290BD0 Offset: 0x128F1D0 VA: 0x181290BD0
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Contains(TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12910E0 Offset: 0x128F6E0 VA: 0x1812910E0
	|-MergedKeyedCollection<Guid, object>.Contains
	|
	|-RVA: 0x1290F50 Offset: 0x128F550 VA: 0x181290F50
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public bool Remove(TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1292AF0 Offset: 0x12910F0 VA: 0x181292AF0
	|-MergedKeyedCollection<Guid, object>.Remove
	|
	|-RVA: 0x1292D20 Offset: 0x1291320 VA: 0x181292D20
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void CopyTo(TItem[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12911A0 Offset: 0x128F7A0 VA: 0x1812911A0
	|-MergedKeyedCollection<Guid, object>.CopyTo
	|
	|-RVA: 0x1291500 Offset: 0x128FB00 VA: 0x181291500
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1291160 Offset: 0x128F760 VA: 0x181291160
	|-MergedKeyedCollection<Guid, object>.Contains
	|
	|-RVA: 0x1290E40 Offset: 0x128F440 VA: 0x181290E40
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1292EB0 Offset: 0x12914B0 VA: 0x181292EB0
	|-MergedKeyedCollection<Guid, object>.Remove
	|
	|-RVA: 0x1292B70 Offset: 0x1291170 VA: 0x181292B70
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1292FC0 Offset: 0x12915C0 VA: 0x181292FC0
	|-MergedKeyedCollection<Guid, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1293070 Offset: 0x1291670 VA: 0x181293070
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IEnumerator<TItem> System.Collections.Generic.IEnumerable<TItem>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1292FC0 Offset: 0x12915C0 VA: 0x181292FC0
	|-MergedKeyedCollection<Guid, object>.System.Collections.Generic.IEnumerable<TItem>.GetEnumerator
	|
	|-RVA: 0x1293070 Offset: 0x1291670 VA: 0x181293070
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TItem>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public MergedKeyedCollection.Enumerator<TKey, TItem> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1292990 Offset: 0x1290F90 VA: 0x181292990
	|-MergedKeyedCollection<Guid, object>.GetEnumerator
	|
	|-RVA: 0x12929D0 Offset: 0x1290FD0 VA: 0x1812929D0
	|-MergedKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/
}

// Namespace: Unity.VisualScripting
public class MergedList<T> : IMergedCollection<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 8880
{
	// Fields
	protected readonly Dictionary<Type, IList<T>> lists; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CE3F0 Offset: 0x9CC9F0 VA: 0x1809CE3F0
	|-MergedList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12953F0 Offset: 0x12939F0 VA: 0x1812953F0
	|-MergedList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-MergedList<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void Include<TI>(IList<TI> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6068A0 Offset: 0x604EA0 VA: 0x1806068A0
	|-MergedList<__Il2CppFullySharedGenericType>.Include<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Includes<TI>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x606990 Offset: 0x604F90 VA: 0x180606990
	|-MergedList<__Il2CppFullySharedGenericType>.Includes<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool Includes(Type elementType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1295160 Offset: 0x1293760 VA: 0x181295160
	|-MergedList<__Il2CppFullySharedGenericType>.Includes
	*/

	// RVA: -1 Offset: -1
	public IList<TI> ForType<TI>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x606740 Offset: 0x604D40 VA: 0x180606740
	|-MergedList<__Il2CppFullySharedGenericType>.ForType<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected IList<T> GetListForItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1294BA0 Offset: 0x12931A0 VA: 0x181294BA0
	|-MergedList<__Il2CppFullySharedGenericType>.GetListForItem
	*/

	// RVA: -1 Offset: -1
	protected IList<T> GetListForType(Type type, bool throwOnFail = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1294DF0 Offset: 0x12933F0 VA: 0x181294DF0
	|-MergedList<__Il2CppFullySharedGenericType>.GetListForType
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12945D0 Offset: 0x1292BD0 VA: 0x1812945D0
	|-MergedList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12941C0 Offset: 0x12927C0 VA: 0x1812941C0
	|-MergedList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1294360 Offset: 0x1292960 VA: 0x181294360
	|-MergedList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public virtual bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12951A0 Offset: 0x12937A0 VA: 0x1812951A0
	|-MergedList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1294770 Offset: 0x1292D70 VA: 0x181294770
	|-MergedList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1295340 Offset: 0x1293940 VA: 0x181295340
	|-MergedList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1295340 Offset: 0x1293940 VA: 0x181295340
	|-MergedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public MergedList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1294AF0 Offset: 0x12930F0 VA: 0x181294AF0
	|-MergedList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/
}

// Namespace: Unity.VisualScripting
public struct NoAllocEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 8881
{
	// Fields
	private readonly IList<T> list; // 0x0
	private int index; // 0x0
	private T current; // 0x0
	private bool exceeded; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8830 Offset: 0x12A6E30 VA: 0x1812A8830
	|-NoAllocEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-NoAllocEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8220 Offset: 0x12A6820 VA: 0x1812A8220
	|-NoAllocEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A88E0 Offset: 0x12A6EE0 VA: 0x1812A88E0
	|-NoAllocEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A86C0 Offset: 0x12A6CC0 VA: 0x1812A86C0
	|-NoAllocEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEC5250 Offset: 0xEC3850 VA: 0x180EC5250
	|-NoAllocEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: Unity.VisualScripting
public abstract class NonNullableCollection<T> : Collection<T> // TypeDefIndex: 8882
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8FB0 Offset: 0x12A75B0 VA: 0x1812A8FB0
	|-NonNullableCollection<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected override void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9150 Offset: 0x12A7750 VA: 0x1812A9150
	|-NonNullableCollection<__Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A8CC0 Offset: 0x12A72C0 VA: 0x1812A8CC0
	|-NonNullableCollection<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11203E0 Offset: 0x111E9E0 VA: 0x1811203E0
	|-NonNullableCollection<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
public class NonNullableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection // TypeDefIndex: 8883
{
	// Fields
	private readonly Dictionary<TKey, TValue> dictionary; // 0x0

	// Properties
	public TValue Item { get; set; }
	private object System.Collections.IDictionary.Item { get; set; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public bool IsReadOnly { get; }
	public ICollection<TKey> Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	public ICollection<TValue> Values { get; }
	public bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CE3F0 Offset: 0x9CC9F0 VA: 0x1809CE3F0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1035C80 Offset: 0x1034280 VA: 0x181035C80
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1035D10 Offset: 0x1034310 VA: 0x181035D10
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA070 Offset: 0x12A8670 VA: 0x1812AA070
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9FD0 Offset: 0x12A85D0 VA: 0x1812A9FD0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA100 Offset: 0x12A8700 VA: 0x1812AA100
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA280 Offset: 0x12A8880 VA: 0x1812AA280
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA470 Offset: 0x12A8A70 VA: 0x1812AA470
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9D00 Offset: 0x12A8300 VA: 0x1812A9D00
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9E60 Offset: 0x12A8460 VA: 0x1812A9E60
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA1A0 Offset: 0x12A87A0 VA: 0x1812AA1A0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public bool get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA230 Offset: 0x12A8830 VA: 0x1812AA230
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public object get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA3D0 Offset: 0x12A89D0 VA: 0x1812AA3D0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD36190 Offset: 0xD34790 VA: 0x180D36190
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9E10 Offset: 0x12A8410 VA: 0x1812A9E10
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9DC0 Offset: 0x12A83C0 VA: 0x1812A9DC0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA420 Offset: 0x12A8A20 VA: 0x1812AA420
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public bool get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA1E0 Offset: 0x12A87E0 VA: 0x1812AA1E0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9710 Offset: 0x12A7D10 VA: 0x1812A9710
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A99A0 Offset: 0x12A7FA0 VA: 0x1812A99A0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A92F0 Offset: 0x12A78F0 VA: 0x1812A92F0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public void Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9510 Offset: 0x12A7B10 VA: 0x1812A9510
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9580 Offset: 0x12A7B80 VA: 0x1812A9580
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public bool Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A96B0 Offset: 0x12A7CB0 VA: 0x1812A96B0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9CB0 Offset: 0x12A82B0 VA: 0x1812A9CB0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public void Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9940 Offset: 0x12A7F40 VA: 0x1812A9940
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9A60 Offset: 0x12A8060 VA: 0x1812A9A60
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A95B0 Offset: 0x12A7BB0 VA: 0x1812A95B0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9B20 Offset: 0x12A8120 VA: 0x1812A9B20
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9780 Offset: 0x12A7D80 VA: 0x1812A9780
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9BF0 Offset: 0x12A81F0 VA: 0x1812A9BF0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9840 Offset: 0x12A7E40 VA: 0x1812A9840
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9ED0 Offset: 0x12A84D0 VA: 0x1812A9ED0
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A9780 Offset: 0x12A7D80 VA: 0x1812A9780
	|-NonNullableDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Unity.VisualScripting
public class NonNullableHashSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 8884
{
	// Fields
	private readonly HashSet<T> set; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CE3F0 Offset: 0x9CC9F0 VA: 0x1809CE3F0
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB030 Offset: 0x12A9630 VA: 0x1812AB030
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB160 Offset: 0x12A9760 VA: 0x1812AB160
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB0C0 Offset: 0x12A96C0 VA: 0x1812AB0C0
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB1F0 Offset: 0x12A97F0 VA: 0x1812AB1F0
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA600 Offset: 0x12A8C00 VA: 0x1812AA600
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA780 Offset: 0x12A8D80 VA: 0x1812AA780
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA7B0 Offset: 0x12A8DB0 VA: 0x1812AA7B0
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA930 Offset: 0x12A8F30 VA: 0x1812AA930
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void ExceptWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA960 Offset: 0x12A8F60 VA: 0x1812AA960
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.ExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA990 Offset: 0x12A8F90 VA: 0x1812AA990
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void IntersectWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AAA50 Offset: 0x12A9050 VA: 0x1812AAA50
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.IntersectWith
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public bool IsProperSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AAA80 Offset: 0x12A9080 VA: 0x1812AAA80
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.IsProperSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool IsProperSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AAAD0 Offset: 0x12A90D0 VA: 0x1812AAAD0
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.IsProperSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool IsSubsetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AAB20 Offset: 0x12A9120 VA: 0x1812AAB20
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.IsSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool IsSupersetOf(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AAB70 Offset: 0x12A9170 VA: 0x1812AAB70
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.IsSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Overlaps(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AABC0 Offset: 0x12A91C0 VA: 0x1812AABC0
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.Overlaps
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AAC10 Offset: 0x12A9210 VA: 0x1812AAC10
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public bool SetEquals(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AADA0 Offset: 0x12A93A0 VA: 0x1812AADA0
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.SetEquals
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void SymmetricExceptWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AADF0 Offset: 0x12A93F0 VA: 0x1812AADF0
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.SymmetricExceptWith
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void UnionWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB000 Offset: 0x12A9600 VA: 0x1812AB000
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.UnionWith
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AAE20 Offset: 0x12A9420 VA: 0x1812AAE20
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AAFB0 Offset: 0x12A95B0 VA: 0x1812AAFB0
	|-NonNullableHashSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
public class NonNullableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection // TypeDefIndex: 8885
{
	// Fields
	private readonly List<T> list; // 0x0

	// Properties
	public T Item { get; set; }
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9CE3F0 Offset: 0x9CC9F0 VA: 0x1809CE3F0
	|-NonNullableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1035C80 Offset: 0x1034280 VA: 0x181035C80
	|-NonNullableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1035D10 Offset: 0x1034310 VA: 0x181035D10
	|-NonNullableList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AC1F0 Offset: 0x12AA7F0 VA: 0x1812AC1F0
	|-NonNullableList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AC310 Offset: 0x12AA910 VA: 0x1812AC310
	|-NonNullableList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AC030 Offset: 0x12AA630 VA: 0x1812AC030
	|-NonNullableList<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AC0E0 Offset: 0x12AA6E0 VA: 0x1812AC0E0
	|-NonNullableList<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD35FC0 Offset: 0xD345C0 VA: 0x180D35FC0
	|-NonNullableList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public bool get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AC1A0 Offset: 0x12AA7A0 VA: 0x1812AC1A0
	|-NonNullableList<__Il2CppFullySharedGenericType>.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public object get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AC2C0 Offset: 0x12AA8C0 VA: 0x1812AC2C0
	|-NonNullableList<__Il2CppFullySharedGenericType>.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-NonNullableList<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public bool get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AC150 Offset: 0x12AA750 VA: 0x1812AC150
	|-NonNullableList<__Il2CppFullySharedGenericType>.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB8F0 Offset: 0x12A9EF0 VA: 0x1812AB8F0
	|-NonNullableList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB520 Offset: 0x12A9B20 VA: 0x1812AB520
	|-NonNullableList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public int Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB6B0 Offset: 0x12A9CB0 VA: 0x1812AB6B0
	|-NonNullableList<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA780 Offset: 0x12A8D80 VA: 0x1812AA780
	|-NonNullableList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB890 Offset: 0x12A9E90 VA: 0x1812AB890
	|-NonNullableList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public int IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ABB90 Offset: 0x12AA190 VA: 0x1812ABB90
	|-NonNullableList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public void Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ABBF0 Offset: 0x12AA1F0 VA: 0x1812ABBF0
	|-NonNullableList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ABE40 Offset: 0x12AA440 VA: 0x1812ABE40
	|-NonNullableList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB710 Offset: 0x12A9D10 VA: 0x1812AB710
	|-NonNullableList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA930 Offset: 0x12A8F30 VA: 0x1812AA930
	|-NonNullableList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB960 Offset: 0x12A9F60 VA: 0x1812AB960
	|-NonNullableList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ABA10 Offset: 0x12AA010 VA: 0x1812ABA10
	|-NonNullableList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ABC60 Offset: 0x12AA260 VA: 0x1812ABC60
	|-NonNullableList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ABEA0 Offset: 0x12AA4A0 VA: 0x1812ABEA0
	|-NonNullableList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12ABE10 Offset: 0x12AA410 VA: 0x1812ABE10
	|-NonNullableList<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB960 Offset: 0x12A9F60 VA: 0x1812AB960
	|-NonNullableList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AB230 Offset: 0x12A9830 VA: 0x1812AB230
	|-NonNullableList<__Il2CppFullySharedGenericType>.AddRange
	*/
}

// Namespace: Unity.VisualScripting
public class VariantCollection<TBase, TImplementation> : ICollection<TBase>, IEnumerable<TBase>, IEnumerable // TypeDefIndex: 8887
{
	// Fields
	[CompilerGenerated]
	private ICollection<TImplementation> <implementation>k__BackingField; // 0x0

	// Properties
	public ICollection<TImplementation> implementation { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ICollection<TImplementation> implementation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B860 Offset: 0xB99E60 VA: 0x180B9B860
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ICollection<TImplementation> get_implementation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_implementation
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_implementation(ICollection<TImplementation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_implementation
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B8F0 Offset: 0xB99EF0 VA: 0x180B9B8F0
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B970 Offset: 0xB99F70 VA: 0x180B9B970
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8644C0 Offset: 0x862AC0 VA: 0x1808644C0
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[IteratorStateMachine(typeof(VariantCollection.<GetEnumerator>d__10<TBase, TImplementation>))]
	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<TBase> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B540 Offset: 0xB99B40 VA: 0x180B9B540
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Add(TBase item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9ABE0 Offset: 0xB991E0 VA: 0x180B9ABE0
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9AE40 Offset: 0xB99440 VA: 0x180B9AE40
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(TBase item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9AEC0 Offset: 0xB994C0 VA: 0x180B9AEC0
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TBase item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B600 Offset: 0xB99C00 VA: 0x180B9B600
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TBase[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B120 Offset: 0xB99720 VA: 0x180B9B120
	|-VariantCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
public class VariantKeyedCollection<TBase, TImplementation, TKey> : VariantCollection<TBase, TImplementation>, IKeyedCollection<TKey, TBase>, ICollection<TBase>, IEnumerable<TBase>, IEnumerable // TypeDefIndex: 8888
{
	// Fields
	[CompilerGenerated]
	private IKeyedCollection<TKey, TImplementation> <implementation>k__BackingField; // 0x0

	// Properties
	public TBase Item { get; }
	public IKeyedCollection<TKey, TImplementation> implementation { get; set; }
	private TBase Unity.VisualScripting.IKeyedCollection<TKey,TBase>.Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IKeyedCollection<TKey, TImplementation> implementation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9C0D0 Offset: 0xB9A6D0 VA: 0x180B9C0D0
	|-VariantKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public TBase get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9C130 Offset: 0xB9A730 VA: 0x180B9C130
	|-VariantKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public IKeyedCollection<TKey, TImplementation> get_implementation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-VariantKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_implementation
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_implementation(IKeyedCollection<TKey, TImplementation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	|-VariantKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_implementation
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool TryGetValue(TKey key, out TBase value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9BC50 Offset: 0xB9A250 VA: 0x180B9BC50
	|-VariantKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B9F0 Offset: 0xB99FF0 VA: 0x180B9B9F0
	|-VariantKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9BB20 Offset: 0xB9A120 VA: 0x180B9BB20
	|-VariantKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private TBase Unity.VisualScripting.IKeyedCollection<TKey,TBase>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9BF50 Offset: 0xB9A550 VA: 0x180B9BF50
	|-VariantKeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.VisualScripting.IKeyedCollection<TKey,TBase>.get_Item
	*/
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
public class VariantList<TBase, TImplementation> : IList<TBase>, ICollection<TBase>, IEnumerable<TBase>, IEnumerable // TypeDefIndex: 8889
{
	// Fields
	[CompilerGenerated]
	private IList<TImplementation> <implementation>k__BackingField; // 0x0

	// Properties
	public TBase Item { get; set; }
	public IList<TImplementation> implementation { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<TImplementation> implementation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B860 Offset: 0xB99E60 VA: 0x180B9B860
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TBase get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D780 Offset: 0xB9BD80 VA: 0x180B9D780
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, TBase value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D900 Offset: 0xB9BF00 VA: 0x180B9D900
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public IList<TImplementation> get_implementation() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_implementation
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_implementation(IList<TImplementation> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_implementation
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D680 Offset: 0xB9BC80 VA: 0x180B9D680
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D700 Offset: 0xB9BD00 VA: 0x180B9D700
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(TBase item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9C3A0 Offset: 0xB9A9A0 VA: 0x180B9C3A0
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9C600 Offset: 0xB9AC00 VA: 0x180B9C600
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(TBase item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9C680 Offset: 0xB9AC80 VA: 0x180B9C680
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(TBase item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D370 Offset: 0xB9B970 VA: 0x180B9D370
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(TBase[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9C8E0 Offset: 0xB9AEE0 VA: 0x180B9C8E0
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(TBase item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9CDB0 Offset: 0xB9B3B0 VA: 0x180B9CDB0
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, TBase item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D080 Offset: 0xB9B680 VA: 0x180B9D080
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D2E0 Offset: 0xB9B8E0 VA: 0x180B9D2E0
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D5D0 Offset: 0xB9BBD0 VA: 0x180B9D5D0
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator<TBase> System.Collections.Generic.IEnumerable<TBase>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9D5D0 Offset: 0xB9BBD0 VA: 0x180B9D5D0
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TBase>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public NoAllocEnumerator<TBase> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9CD00 Offset: 0xB9B300 VA: 0x180B9CD00
	|-VariantList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/
}

// Namespace: Unity.VisualScripting
public class WatchedList<T> : Collection<T>, INotifyCollectionChanged<T> // TypeDefIndex: 8890
{
	// Fields
	[CompilerGenerated]
	private Action<T> ItemAdded; // 0x0
	[CompilerGenerated]
	private Action<T> ItemRemoved; // 0x0
	[CompilerGenerated]
	private Action CollectionChanged; // 0x0

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 39
	public void add_ItemAdded(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4030 Offset: 0xBE2630 VA: 0x180BE4030
	|-WatchedList<__Il2CppFullySharedGenericType>.add_ItemAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 40
	public void remove_ItemAdded(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4270 Offset: 0xBE2870 VA: 0x180BE4270
	|-WatchedList<__Il2CppFullySharedGenericType>.remove_ItemAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 41
	public void add_ItemRemoved(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4100 Offset: 0xBE2700 VA: 0x180BE4100
	|-WatchedList<__Il2CppFullySharedGenericType>.add_ItemRemoved
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 42
	public void remove_ItemRemoved(Action<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE4340 Offset: 0xBE2940 VA: 0x180BE4340
	|-WatchedList<__Il2CppFullySharedGenericType>.remove_ItemRemoved
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 43
	public void add_CollectionChanged(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3F90 Offset: 0xBE2590 VA: 0x180BE3F90
	|-WatchedList<__Il2CppFullySharedGenericType>.add_CollectionChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 44
	public void remove_CollectionChanged(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE41D0 Offset: 0xBE27D0 VA: 0x180BE41D0
	|-WatchedList<__Il2CppFullySharedGenericType>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3C00 Offset: 0xBE2200 VA: 0x180BE3C00
	|-WatchedList<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3DB0 Offset: 0xBE23B0 VA: 0x180BE3DB0
	|-WatchedList<__Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3B80 Offset: 0xBE2180 VA: 0x180BE3B80
	|-WatchedList<__Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE3F70 Offset: 0xBE2570 VA: 0x180BE3F70
	|-WatchedList<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.VisualScripting
public class ConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, List<TConnection>> // TypeDefIndex: 8891
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2EC10 Offset: 0xD2D210 VA: 0x180D2EC10
	|-ConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
public class ConnectionCollectionBase<TConnection, TSource, TDestination, TCollection> : IConnectionCollection<TConnection, TSource, TDestination>, ICollection<TConnection>, IEnumerable<TConnection>, IEnumerable // TypeDefIndex: 8892
{
	// Fields
	private readonly Dictionary<TDestination, List<TConnection>> byDestination; // 0x0
	private readonly Dictionary<TSource, List<TConnection>> bySource; // 0x0
	protected readonly TCollection collection; // 0x0

	// Properties
	public IEnumerable<TConnection> Item { get; }
	public IEnumerable<TConnection> Item { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TCollection collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2E6E0 Offset: 0xD2CCE0 VA: 0x180D2E6E0
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerable<TConnection> get_Item(TSource source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2EA30 Offset: 0xD2D030 VA: 0x180D2EA30
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerable<TConnection> get_Item(TDestination destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2EB20 Offset: 0xD2D120 VA: 0x180D2EB20
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2E8C0 Offset: 0xD2CEC0 VA: 0x180D2E8C0
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public IEnumerator<TConnection> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2C930 Offset: 0xD2AF30 VA: 0x180D2C930
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x94D430 Offset: 0x94BA30 VA: 0x18094D430
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public IEnumerable<TConnection> WithSource(TSource source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2E5F0 Offset: 0xD2CBF0 VA: 0x180D2E5F0
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.WithSource
	*/

	// RVA: -1 Offset: -1
	public List<TConnection> WithSourceNoAlloc(TSource source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2E350 Offset: 0xD2C950 VA: 0x180D2E350
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.WithSourceNoAlloc
	*/

	// RVA: -1 Offset: -1
	public TConnection SingleOrDefaultWithSource(TSource source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2DBF0 Offset: 0xD2C1F0 VA: 0x180D2DBF0
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SingleOrDefaultWithSource
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IEnumerable<TConnection> WithDestination(TDestination destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2E260 Offset: 0xD2C860 VA: 0x180D2E260
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.WithDestination
	*/

	// RVA: -1 Offset: -1
	public List<TConnection> WithDestinationNoAlloc(TDestination destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2DFC0 Offset: 0xD2C5C0 VA: 0x180D2DFC0
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.WithDestinationNoAlloc
	*/

	// RVA: -1 Offset: -1
	public TConnection SingleOrDefaultWithDestination(TDestination destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2D820 Offset: 0xD2BE20 VA: 0x180D2D820
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SingleOrDefaultWithDestination
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public void Add(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2BB70 Offset: 0xD2A170 VA: 0x180D2BB70
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2C300 Offset: 0xD2A900 VA: 0x180D2C300
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public bool Contains(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2C500 Offset: 0xD2AB00 VA: 0x180D2C500
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void CopyTo(TConnection[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2C7A0 Offset: 0xD2ADA0 VA: 0x180D2C7A0
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public bool Remove(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2CF60 Offset: 0xD2B560 VA: 0x180D2CF60
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 17
	protected virtual void BeforeAdd(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeforeAdd
	*/

	// RVA: -1 Offset: -1 Slot: 18
	protected virtual void AfterAdd(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AfterAdd
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected virtual void BeforeRemove(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeforeRemove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected virtual void AfterRemove(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AfterRemove
	*/

	// RVA: -1 Offset: -1
	private void AddToDictionaries(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2B0F0 Offset: 0xD296F0 VA: 0x180D2B0F0
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddToDictionaries
	*/

	// RVA: -1 Offset: -1
	private void RemoveFromDictionaries(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2CAA0 Offset: 0xD2B0A0 VA: 0x180D2CAA0
	|-ConnectionCollectionBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveFromDictionaries
	*/
}

// Namespace: Unity.VisualScripting
public class GraphConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, GraphElementCollection<TConnection>>, IGraphElementCollection<TConnection>, IKeyedCollection<Guid, TConnection>, ICollection<TConnection>, IEnumerable<TConnection>, IEnumerable, INotifyCollectionChanged<TConnection> // TypeDefIndex: 8893
{
	// Properties
	private TConnection Unity.VisualScripting.IKeyedCollection<System.Guid,TConnection>.Item { get; }
	private TConnection Unity.VisualScripting.IKeyedCollection<System.Guid,TConnection>.Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IGraph graph) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F0B0 Offset: 0x102D6B0 VA: 0x18102F0B0
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private TConnection Unity.VisualScripting.IKeyedCollection<System.Guid,TConnection>.get_Item(Guid key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102EF20 Offset: 0x102D520 VA: 0x18102EF20
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.VisualScripting.IKeyedCollection<System.Guid,TConnection>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private TConnection Unity.VisualScripting.IKeyedCollection<System.Guid,TConnection>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102EFE0 Offset: 0x102D5E0 VA: 0x18102EFE0
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.VisualScripting.IKeyedCollection<System.Guid,TConnection>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool TryGetValue(Guid key, out TConnection value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102EED0 Offset: 0x102D4D0 VA: 0x18102EED0
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public bool Contains(Guid key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102ED20 Offset: 0x102D320 VA: 0x18102ED20
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public bool Remove(Guid key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102ED80 Offset: 0x102D380 VA: 0x18102ED80
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public void add_ItemAdded(Action<TConnection> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F1B0 Offset: 0x102D7B0 VA: 0x18102F1B0
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.add_ItemAdded
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void remove_ItemAdded(Action<TConnection> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F240 Offset: 0x102D840 VA: 0x18102F240
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.remove_ItemAdded
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void add_ItemRemoved(Action<TConnection> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F1E0 Offset: 0x102D7E0 VA: 0x18102F1E0
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.add_ItemRemoved
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public void remove_ItemRemoved(Action<TConnection> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F270 Offset: 0x102D870 VA: 0x18102F270
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.remove_ItemRemoved
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public void add_CollectionChanged(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F180 Offset: 0x102D780 VA: 0x18102F180
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.add_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public void remove_CollectionChanged(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F210 Offset: 0x102D810 VA: 0x18102F210
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.remove_CollectionChanged
	*/

	// RVA: -1 Offset: -1 Slot: 17
	protected override void BeforeAdd(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102EB40 Offset: 0x102D140 VA: 0x18102EB40
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeforeAdd
	*/

	// RVA: -1 Offset: -1 Slot: 18
	protected override void AfterAdd(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102E960 Offset: 0x102CF60 VA: 0x18102E960
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AfterAdd
	*/

	// RVA: -1 Offset: -1 Slot: 19
	protected override void BeforeRemove(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102EC30 Offset: 0x102D230 VA: 0x18102EC30
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeforeRemove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected override void AfterRemove(TConnection item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102EA50 Offset: 0x102D050 VA: 0x18102EA50
	|-GraphConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AfterRemove
	*/
}

// Namespace: Unity.VisualScripting
public interface IConnection<TSource, TDestination> // TypeDefIndex: 8894
{
	// Properties
	public abstract TSource source { get; }
	public abstract TDestination destination { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TSource get_source();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConnection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_source
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TDestination get_destination();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConnection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_destination
	*/
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
public interface IConnectionCollection<TConnection, TSource, TDestination> : ICollection<TConnection>, IEnumerable<TConnection>, IEnumerable // TypeDefIndex: 8895
{
	// Properties
	public abstract IEnumerable<TConnection> Item { get; }
	public abstract IEnumerable<TConnection> Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<TConnection> get_Item(TSource source);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerable<TConnection> get_Item(TDestination destination);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<TConnection> WithSource(TSource source);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.WithSource
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<TConnection> WithDestination(TDestination destination);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConnectionCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.WithDestination
	*/
}

// Namespace: Unity.VisualScripting
public class InvalidConnectionException : Exception // TypeDefIndex: 8896
{
	// Methods

	// RVA: 0x2204340 Offset: 0x2202940 VA: 0x182204340
	public void .ctor() { }

	// RVA: 0x22043A0 Offset: 0x22029A0 VA: 0x1822043A0
	public void .ctor(string message) { }
}

// Namespace: Unity.VisualScripting
public interface IDecoratorAttribute // TypeDefIndex: 8897
{
	// Properties
	public abstract Type type { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_type();
}

// Namespace: Unity.VisualScripting
[Usage(384)]
public class ValueAttribute : Attribute // TypeDefIndex: 8898
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class AllowsNullAttribute : Attribute // TypeDefIndex: 8899
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(4)]
public class DisableAnnotationAttribute : Attribute // TypeDefIndex: 8900
{
	// Fields
	[CompilerGenerated]
	private bool <disableIcon>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <disableGizmo>k__BackingField; // 0x11

	// Properties
	public bool disableIcon { get; set; }
	public bool disableGizmo { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_disableIcon() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_disableIcon(bool value) { }

	[CompilerGenerated]
	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_disableGizmo() { }

	[CompilerGenerated]
	// RVA: 0x14B8CA0 Offset: 0x14B72A0 VA: 0x1814B8CA0
	public void set_disableGizmo(bool value) { }

	// RVA: 0x21F54F0 Offset: 0x21F3AF0 VA: 0x1821F54F0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public static class EditorBindingUtility // TypeDefIndex: 8901
{
	// Fields
	public const string FactoryMethodWarning = "This parameterless factory method is only made public for the editor. Use the constructor instead.";
}

// Namespace: Unity.VisualScripting
public static class EditorTimeBinding // TypeDefIndex: 8903
{
	// Fields
	public static Func<int> frameBinding; // 0x0
	public static Func<float> timeBinding; // 0x8

	// Properties
	public static int frame { get; }
	public static float time { get; }

	// Methods

	// RVA: 0x21F5650 Offset: 0x21F3C50 VA: 0x1821F5650
	public static int get_frame() { }

	// RVA: 0x21F5720 Offset: 0x21F3D20 VA: 0x1821F5720
	public static float get_time() { }

	// RVA: 0x21F5500 Offset: 0x21F3B00 VA: 0x1821F5500
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(384, AllowMultiple = False, Inherited = True)]
public sealed class ExpectedTypeAttribute : Attribute // TypeDefIndex: 8904
{
	// Fields
	[CompilerGenerated]
	private readonly Type <type>k__BackingField; // 0x10

	// Properties
	public Type type { get; }

	// Methods

	// RVA: 0x21FA460 Offset: 0x21F8A60 VA: 0x1821FA460
	public void .ctor(Type type) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_type() { }
}

// Namespace: Unity.VisualScripting
public interface IInspectableAttribute // TypeDefIndex: 8905
{
	// Properties
	public abstract int order { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_order();
}

// Namespace: Unity.VisualScripting
[Usage(12, AllowMultiple = False, Inherited = True)]
public sealed class IncludeInSettingsAttribute : Attribute // TypeDefIndex: 8906
{
	// Fields
	[CompilerGenerated]
	private bool <include>k__BackingField; // 0x10

	// Properties
	public bool include { get; set; }

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(bool include) { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_include() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	private void set_include(bool value) { }
}

// Namespace: Unity.VisualScripting
[Usage(396, AllowMultiple = False, Inherited = True)]
public sealed class InspectableAttribute : Attribute, IInspectableAttribute // TypeDefIndex: 8907
{
	// Fields
	[CompilerGenerated]
	private int <order>k__BackingField; // 0x10

	// Properties
	public int order { get; set; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 7
	public int get_order() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_order(int value) { }
}

// Namespace: Unity.VisualScripting
[Usage(396, AllowMultiple = False, Inherited = True)]
public sealed class InspectableIfAttribute : Attribute, IInspectableAttribute // TypeDefIndex: 8908
{
	// Fields
	[CompilerGenerated]
	private int <order>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <conditionMember>k__BackingField; // 0x18

	// Properties
	public int order { get; set; }
	public string conditionMember { get; }

	// Methods

	// RVA: 0x1B31CE0 Offset: 0x1B302E0 VA: 0x181B31CE0
	public void .ctor(string conditionMember) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 7
	public int get_order() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	public void set_order(int value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_conditionMember() { }
}

// Namespace: Unity.VisualScripting
[Usage(2432, AllowMultiple = False, Inherited = True)]
public sealed class InspectorActionDirectionAttribute : Attribute // TypeDefIndex: 8909
{
	// Fields
	[CompilerGenerated]
	private ActionDirection <direction>k__BackingField; // 0x10

	// Properties
	public ActionDirection direction { get; set; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(ActionDirection direction) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public ActionDirection get_direction() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	private void set_direction(ActionDirection value) { }
}

// Namespace: Unity.VisualScripting
[Usage(4, AllowMultiple = False, Inherited = True)]
public sealed class InspectorAdaptiveWidthAttribute : Attribute // TypeDefIndex: 8910
{
	// Fields
	[CompilerGenerated]
	private float <width>k__BackingField; // 0x10

	// Properties
	public float width { get; set; }

	// Methods

	// RVA: 0x2034290 Offset: 0x2032890 VA: 0x182034290
	public void .ctor(float width) { }

	[CompilerGenerated]
	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	public float get_width() { }

	[CompilerGenerated]
	// RVA: 0x4722B0 Offset: 0x4708B0 VA: 0x1804722B0
	private void set_width(float value) { }
}

// Namespace: Unity.VisualScripting
[Usage(2432, AllowMultiple = False, Inherited = True)]
public sealed class InspectorDelayedAttribute : Attribute // TypeDefIndex: 8911
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class InspectorExpandTooltipAttribute : Attribute // TypeDefIndex: 8912
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class InspectorLabelAttribute : Attribute // TypeDefIndex: 8913
{
	// Fields
	[CompilerGenerated]
	private string <text>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <tooltip>k__BackingField; // 0x18
	[CompilerGenerated]
	private Texture <image>k__BackingField; // 0x20

	// Properties
	public string text { get; set; }
	public string tooltip { get; set; }
	public Texture image { get; set; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string text) { }

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(string text, string tooltip) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_text() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_text(string value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_tooltip() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_tooltip(string value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Texture get_image() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_image(Texture value) { }
}

// Namespace: Unity.VisualScripting
[Usage(2432, AllowMultiple = False, Inherited = True)]
public sealed class InspectorRangeAttribute : Attribute // TypeDefIndex: 8914
{
	// Fields
	[CompilerGenerated]
	private float <min>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <max>k__BackingField; // 0x14

	// Properties
	public float min { get; set; }
	public float max { get; set; }

	// Methods

	// RVA: 0x20342C0 Offset: 0x20328C0 VA: 0x1820342C0
	public void .ctor(float min, float max) { }

	[CompilerGenerated]
	// RVA: 0x4722A0 Offset: 0x4708A0 VA: 0x1804722A0
	public float get_min() { }

	[CompilerGenerated]
	// RVA: 0x4722B0 Offset: 0x4708B0 VA: 0x1804722B0
	private void set_min(float value) { }

	[CompilerGenerated]
	// RVA: 0x3A4AB0 Offset: 0x3A30B0 VA: 0x1803A4AB0
	public float get_max() { }

	[CompilerGenerated]
	// RVA: 0x3A4C60 Offset: 0x3A3260 VA: 0x1803A4C60
	private void set_max(float value) { }
}

// Namespace: Unity.VisualScripting
[Usage(2432, AllowMultiple = False, Inherited = True)]
public sealed class InspectorTextAreaAttribute : Attribute // TypeDefIndex: 8915
{
	// Fields
	private Nullable<float> _minLines; // 0x10
	private Nullable<float> _maxLines; // 0x18

	// Properties
	public float minLines { get; set; }
	public bool hasMinLines { get; }
	public float maxLines { get; set; }
	public bool hasMaxLines { get; }

	// Methods

	// RVA: 0x2204240 Offset: 0x2202840 VA: 0x182204240
	public float get_minLines() { }

	// RVA: 0x22042E0 Offset: 0x22028E0 VA: 0x1822042E0
	public void set_minLines(float value) { }

	// RVA: 0x22041C0 Offset: 0x22027C0 VA: 0x1822041C0
	public bool get_hasMinLines() { }

	// RVA: 0x2204200 Offset: 0x2202800 VA: 0x182204200
	public float get_maxLines() { }

	// RVA: 0x2204280 Offset: 0x2202880 VA: 0x182204280
	public void set_maxLines(float value) { }

	// RVA: 0x2204180 Offset: 0x2202780 VA: 0x182204180
	public bool get_hasMaxLines() { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(2432, AllowMultiple = False, Inherited = True)]
public sealed class InspectorToggleLeftAttribute : Attribute // TypeDefIndex: 8916
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class InspectorWideAttribute : Attribute // TypeDefIndex: 8917
{
	// Fields
	[CompilerGenerated]
	private bool <toEdge>k__BackingField; // 0x10

	// Properties
	public bool toEdge { get; set; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(bool toEdge) { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_toEdge() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	private void set_toEdge(bool value) { }
}

// Namespace: Unity.VisualScripting
[Usage(1028, AllowMultiple = False, Inherited = True)]
public sealed class InspectViaImplementationsAttribute : Attribute // TypeDefIndex: 8918
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class NullMeansSelfAttribute : Attribute // TypeDefIndex: 8919
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class PredictableAttribute : Attribute // TypeDefIndex: 8920
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(1036, AllowMultiple = False, Inherited = True)]
public sealed class TypeIconAttribute : Attribute // TypeDefIndex: 8921
{
	// Fields
	[CompilerGenerated]
	private readonly Type <type>k__BackingField; // 0x10

	// Properties
	public Type type { get; }

	// Methods

	// RVA: 0x220CE90 Offset: 0x220B490 VA: 0x18220CE90
	public void .ctor(Type type) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_type() { }
}

// Namespace: Unity.VisualScripting
[Usage(1024, AllowMultiple = False, Inherited = False)]
public sealed class TypeIconPriorityAttribute : Attribute // TypeDefIndex: 8922
{
	// Fields
	[CompilerGenerated]
	private readonly int <priority>k__BackingField; // 0x10

	// Properties
	public int priority { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(int priority) { }

	// RVA: 0x220CF40 Offset: 0x220B540 VA: 0x18220CF40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_priority() { }
}

// Namespace: Unity.VisualScripting
public enum TypeSet // TypeDefIndex: 8923
{
	// Fields
	public int value__; // 0x0
	public const TypeSet AllTypes = 0;
	public const TypeSet RuntimeTypes = 1;
	public const TypeSet SettingsTypes = 2;
	public const TypeSet SettingsAssembliesTypes = 3;
}

// Namespace: Unity.VisualScripting
[Usage(384, AllowMultiple = False, Inherited = True)]
public class TypeSetAttribute : Attribute // TypeDefIndex: 8924
{
	// Fields
	[CompilerGenerated]
	private readonly TypeSet <typeSet>k__BackingField; // 0x10

	// Properties
	public TypeSet typeSet { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(TypeSet typeSet) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public TypeSet get_typeSet() { }
}

// Namespace: Unity.VisualScripting
[Usage(384, AllowMultiple = False, Inherited = True)]
public sealed class WarnBeforeEditingAttribute : Attribute // TypeDefIndex: 8925
{
	// Fields
	[CompilerGenerated]
	private readonly string <warningTitle>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <warningMessage>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly object[] <emptyValues>k__BackingField; // 0x20

	// Properties
	public string warningTitle { get; }
	public string warningMessage { get; }
	public object[] emptyValues { get; }

	// Methods

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(string warningTitle, string warningMessage) { }

	// RVA: 0x22121A0 Offset: 0x22107A0 VA: 0x1822121A0
	public void .ctor(string warningTitle, string warningMessage, object[] emptyValues) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_warningTitle() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_warningMessage() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public object[] get_emptyValues() { }
}

// Namespace: Unity.VisualScripting
[Usage(384, AllowMultiple = False, Inherited = True)]
public sealed class WarnBeforeRemovingAttribute : Attribute // TypeDefIndex: 8926
{
	// Fields
	[CompilerGenerated]
	private readonly string <warningTitle>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <warningMessage>k__BackingField; // 0x18

	// Properties
	public string warningTitle { get; }
	public string warningMessage { get; }

	// Methods

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(string warningTitle, string warningMessage) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_warningTitle() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_warningMessage() { }
}

// Namespace: Unity.VisualScripting
public static class Ensure // TypeDefIndex: 8927
{
	// Fields
	private static readonly EnsureThat instance; // 0x0
	[CompilerGenerated]
	private static bool <IsActive>k__BackingField; // 0x8

	// Properties
	public static bool IsActive { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21F7EB0 Offset: 0x21F64B0 VA: 0x1821F7EB0
	public static bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x21F7F00 Offset: 0x21F6500 VA: 0x1821F7F00
	public static void set_IsActive(bool value) { }

	// RVA: 0x21F7B90 Offset: 0x21F6190 VA: 0x1821F7B90
	public static void Off() { }

	// RVA: 0x21F7D20 Offset: 0x21F6320 VA: 0x1821F7D20
	public static void On() { }

	// RVA: 0x21F7DB0 Offset: 0x21F63B0 VA: 0x1821F7DB0
	public static EnsureThat That(string paramName) { }

	// RVA: 0x21F7C20 Offset: 0x21F6220 VA: 0x1821F7C20
	internal static void OnRuntimeMethodLoad() { }

	// RVA: 0x21F7E30 Offset: 0x21F6430 VA: 0x1821F7E30
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public class EnsureThat // TypeDefIndex: 8928
{
	// Fields
	internal string paramName; // 0x10

	// Methods

	// RVA: 0x21F73B0 Offset: 0x21F59B0 VA: 0x1821F73B0
	public void IsTrue(bool value) { }

	// RVA: 0x21F6490 Offset: 0x21F4A90 VA: 0x1821F6490
	public void IsFalse(bool value) { }

	// RVA: -1 Offset: -1
	public void HasItems<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D51F0 Offset: 0x6D37F0 VA: 0x1806D51F0
	|-EnsureThat.HasItems<object>
	*/

	// RVA: -1 Offset: -1
	public void HasItems<T>(ICollection<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D4F00 Offset: 0x6D3500 VA: 0x1806D4F00
	|-EnsureThat.HasItems<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void HasItems<T>(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D5060 Offset: 0x6D3660 VA: 0x1806D5060
	|-EnsureThat.HasItems<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void HasNoNullItem<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D5420 Offset: 0x6D3A20 VA: 0x1806D5420
	|-EnsureThat.HasNoNullItem<object>
	*/

	// RVA: -1 Offset: -1
	public void HasItems<T>(IList<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D51A0 Offset: 0x6D37A0 VA: 0x1806D51A0
	|-EnsureThat.HasItems<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void HasItems<TKey, TValue>(IDictionary<TKey, TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D4D90 Offset: 0x6D3390 VA: 0x1806D4D90
	|-EnsureThat.HasItems<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SizeIs<T>(T[] value, int expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D8E30 Offset: 0x6D7430 VA: 0x1806D8E30
	|-EnsureThat.SizeIs<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SizeIs<T>(T[] value, long expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D8760 Offset: 0x6D6D60 VA: 0x1806D8760
	|-EnsureThat.SizeIs<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SizeIs<T>(T value, int expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D9000 Offset: 0x6D7600 VA: 0x1806D9000
	|-EnsureThat.SizeIs<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SizeIs<T>(T value, long expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D8930 Offset: 0x6D6F30 VA: 0x1806D8930
	|-EnsureThat.SizeIs<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SizeIs<T>(ICollection<T> value, int expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D8C20 Offset: 0x6D7220 VA: 0x1806D8C20
	|-EnsureThat.SizeIs<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SizeIs<T>(ICollection<T> value, long expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D84F0 Offset: 0x6D6AF0 VA: 0x1806D84F0
	|-EnsureThat.SizeIs<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SizeIs<T>(IList<T> value, int expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D8490 Offset: 0x6D6A90 VA: 0x1806D8490
	|-EnsureThat.SizeIs<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SizeIs<T>(IList<T> value, long expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D8700 Offset: 0x6D6D00 VA: 0x1806D8700
	|-EnsureThat.SizeIs<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SizeIs<TKey, TValue>(IDictionary<TKey, TValue> value, int expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D8280 Offset: 0x6D6880 VA: 0x1806D8280
	|-EnsureThat.SizeIs<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SizeIs<TKey, TValue>(IDictionary<TKey, TValue> value, long expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D8070 Offset: 0x6D6670 VA: 0x1806D8070
	|-EnsureThat.SizeIs<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void IsKeyOf<TKey, TValue>(IDictionary<TKey, TValue> value, TKey expectedKey, string keyLabel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D6280 Offset: 0x6D4880 VA: 0x1806D6280
	|-EnsureThat.IsKeyOf<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Any<T>(IList<T> value, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D4CC0 Offset: 0x6D32C0 VA: 0x1806D4CC0
	|-EnsureThat.Any<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Any<T>(ICollection<T> value, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D4B90 Offset: 0x6D3190 VA: 0x1806D4B90
	|-EnsureThat.Any<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Any<T>(T[] value, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D4B90 Offset: 0x6D3190 VA: 0x1806D4B90
	|-EnsureThat.Any<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Is<T>(T param, T expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D7DE0 Offset: 0x6D63E0 VA: 0x1806D7DE0
	|-EnsureThat.Is<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void IsNot<T>(T param, T expected) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D73A0 Offset: 0x6D59A0 VA: 0x1806D73A0
	|-EnsureThat.IsNot<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void IsLt<T>(T param, T limit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D6840 Offset: 0x6D4E40 VA: 0x1806D6840
	|-EnsureThat.IsLt<int>
	|
	|-RVA: 0x6D65B0 Offset: 0x6D4BB0 VA: 0x1806D65B0
	|-EnsureThat.IsLt<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void IsLte<T>(T param, T limit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D6A30 Offset: 0x6D5030 VA: 0x1806D6A30
	|-EnsureThat.IsLte<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void IsGt<T>(T param, T limit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D5740 Offset: 0x6D3D40 VA: 0x1806D5740
	|-EnsureThat.IsGt<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void IsGte<T>(T param, T limit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D5C60 Offset: 0x6D4260 VA: 0x1806D5C60
	|-EnsureThat.IsGte<int>
	|
	|-RVA: 0x6D59D0 Offset: 0x6D3FD0 VA: 0x1806D59D0
	|-EnsureThat.IsGte<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void IsInRange<T>(T param, T min, T max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D5E50 Offset: 0x6D4450 VA: 0x1806D5E50
	|-EnsureThat.IsInRange<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x21F6840 Offset: 0x21F4E40 VA: 0x1821F6840
	public void IsNotEmpty(Guid value) { }

	// RVA: -1 Offset: -1
	public void IsNotNull<T>(Nullable<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D7290 Offset: 0x6D5890 VA: 0x1806D7290
	|-EnsureThat.IsNotNull<Scene>
	|
	|-RVA: 0x6D7060 Offset: 0x6D5660 VA: 0x1806D7060
	|-EnsureThat.IsNotNull<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public void IsNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D7630 Offset: 0x6D5C30 VA: 0x1806D7630
	|-EnsureThat.IsNull<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void IsNotNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D7180 Offset: 0x6D5780 VA: 0x1806D7180
	|-EnsureThat.IsNotNull<object>
	|
	|-RVA: 0x6D6EE0 Offset: 0x6D54E0 VA: 0x1806D6EE0
	|-EnsureThat.IsNotNull<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21F57F0 Offset: 0x21F3DF0 VA: 0x1821F57F0
	public void HasAttribute(Type param, Type attributeType) { }

	// RVA: -1 Offset: -1
	public void HasAttribute<TAttribute>(Type param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D4D20 Offset: 0x6D3320 VA: 0x1806D4D20
	|-EnsureThat.HasAttribute<object>
	*/

	// RVA: 0x21F5A90 Offset: 0x21F4090 VA: 0x1821F5A90
	private void HasConstructorAccepting(Type param, Type[] parameterTypes, bool nonPublic) { }

	// RVA: 0x21F5CB0 Offset: 0x21F42B0 VA: 0x1821F5CB0
	public void HasConstructorAccepting(Type param, Type[] parameterTypes) { }

	// RVA: 0x21F6120 Offset: 0x21F4720 VA: 0x1821F6120
	public void HasPublicConstructorAccepting(Type param, Type[] parameterTypes) { }

	// RVA: 0x21F6EC0 Offset: 0x21F54C0 VA: 0x1821F6EC0
	public void IsNotNullOrWhiteSpace(string value) { }

	// RVA: 0x21F6CD0 Offset: 0x21F52D0 VA: 0x1821F6CD0
	public void IsNotNullOrEmpty(string value) { }

	// RVA: 0x21F70D0 Offset: 0x21F56D0 VA: 0x1821F70D0
	public void IsNotNull(string value) { }

	// RVA: 0x21F6710 Offset: 0x21F4D10 VA: 0x1821F6710
	public void IsNotEmpty(string value) { }

	// RVA: 0x21F5CD0 Offset: 0x21F42D0 VA: 0x1821F5CD0
	public void HasLengthBetween(string value, int minLength, int maxLength) { }

	// RVA: 0x21F7660 Offset: 0x21F5C60 VA: 0x1821F7660
	public void Matches(string value, string match) { }

	// RVA: 0x21F74B0 Offset: 0x21F5AB0 VA: 0x1821F74B0
	public void Matches(string value, Regex match) { }

	// RVA: 0x21F7840 Offset: 0x21F5E40 VA: 0x1821F7840
	public void SizeIs(string value, int expected) { }

	// RVA: 0x21F6140 Offset: 0x21F4740 VA: 0x1821F6140
	public void IsEqualTo(string value, string expected) { }

	// RVA: 0x21F62D0 Offset: 0x21F48D0 VA: 0x1821F62D0
	public void IsEqualTo(string value, string expected, StringComparison comparison) { }

	// RVA: 0x21F6B40 Offset: 0x21F5140 VA: 0x1821F6B40
	public void IsNotEqualTo(string value, string expected) { }

	// RVA: 0x21F6980 Offset: 0x21F4F80 VA: 0x1821F6980
	public void IsNotEqualTo(string value, string expected, StringComparison comparison) { }

	// RVA: 0x21F6590 Offset: 0x21F4B90 VA: 0x1821F6590
	public void IsGuid(string value) { }

	// RVA: 0x21F7B00 Offset: 0x21F6100 VA: 0x1821F7B00
	private bool StringEquals(string x, string y, Nullable<StringComparison> comparison) { }

	// RVA: -1 Offset: -1
	public void IsOfType<T>(T param, Type expectedType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D7BD0 Offset: 0x6D61D0 VA: 0x1806D7BD0
	|-EnsureThat.IsOfType<object>
	|
	|-RVA: 0x6D78B0 Offset: 0x6D5EB0 VA: 0x1806D78B0
	|-EnsureThat.IsOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21F71E0 Offset: 0x21F57E0 VA: 0x1821F71E0
	public void IsOfType(Type param, Type expectedType) { }

	// RVA: -1 Offset: -1
	public void IsOfType<T>(object param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D77B0 Offset: 0x6D5DB0 VA: 0x1806D77B0
	|-EnsureThat.IsOfType<object>
	|-EnsureThat.IsOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void IsOfType<T>(Type param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D7840 Offset: 0x6D5E40 VA: 0x1806D7840
	|-EnsureThat.IsOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void IsNotDefault<T>(T param) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D6CC0 Offset: 0x6D52C0 VA: 0x1806D6CC0
	|-EnsureThat.IsNotDefault<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public static class ExceptionMessages // TypeDefIndex: 8929
{
	// Fields
	[CompilerGenerated]
	private static readonly string <Common_IsNull_Failed>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly string <Common_IsNotNull_Failed>k__BackingField; // 0x8
	[CompilerGenerated]
	private static readonly string <Booleans_IsTrueFailed>k__BackingField; // 0x10
	[CompilerGenerated]
	private static readonly string <Booleans_IsFalseFailed>k__BackingField; // 0x18
	[CompilerGenerated]
	private static readonly string <Collections_Any_Failed>k__BackingField; // 0x20
	[CompilerGenerated]
	private static readonly string <Collections_ContainsKey_Failed>k__BackingField; // 0x28
	[CompilerGenerated]
	private static readonly string <Collections_HasItemsFailed>k__BackingField; // 0x30
	[CompilerGenerated]
	private static readonly string <Collections_HasNoNullItemFailed>k__BackingField; // 0x38
	[CompilerGenerated]
	private static readonly string <Collections_SizeIs_Failed>k__BackingField; // 0x40
	[CompilerGenerated]
	private static readonly string <Comp_Is_Failed>k__BackingField; // 0x48
	[CompilerGenerated]
	private static readonly string <Comp_IsNot_Failed>k__BackingField; // 0x50
	[CompilerGenerated]
	private static readonly string <Comp_IsNotLt>k__BackingField; // 0x58
	[CompilerGenerated]
	private static readonly string <Comp_IsNotLte>k__BackingField; // 0x60
	[CompilerGenerated]
	private static readonly string <Comp_IsNotGt>k__BackingField; // 0x68
	[CompilerGenerated]
	private static readonly string <Comp_IsNotGte>k__BackingField; // 0x70
	[CompilerGenerated]
	private static readonly string <Comp_IsNotInRange_ToLow>k__BackingField; // 0x78
	[CompilerGenerated]
	private static readonly string <Comp_IsNotInRange_ToHigh>k__BackingField; // 0x80
	[CompilerGenerated]
	private static readonly string <Guids_IsNotEmpty_Failed>k__BackingField; // 0x88
	[CompilerGenerated]
	private static readonly string <Strings_IsEqualTo_Failed>k__BackingField; // 0x90
	[CompilerGenerated]
	private static readonly string <Strings_IsNotEqualTo_Failed>k__BackingField; // 0x98
	[CompilerGenerated]
	private static readonly string <Strings_SizeIs_Failed>k__BackingField; // 0xA0
	[CompilerGenerated]
	private static readonly string <Strings_IsNotNullOrWhiteSpace_Failed>k__BackingField; // 0xA8
	[CompilerGenerated]
	private static readonly string <Strings_IsNotNullOrEmpty_Failed>k__BackingField; // 0xB0
	[CompilerGenerated]
	private static readonly string <Strings_HasLengthBetween_Failed_ToShort>k__BackingField; // 0xB8
	[CompilerGenerated]
	private static readonly string <Strings_HasLengthBetween_Failed_ToLong>k__BackingField; // 0xC0
	[CompilerGenerated]
	private static readonly string <Strings_Matches_Failed>k__BackingField; // 0xC8
	[CompilerGenerated]
	private static readonly string <Strings_IsNotEmpty_Failed>k__BackingField; // 0xD0
	[CompilerGenerated]
	private static readonly string <Strings_IsGuid_Failed>k__BackingField; // 0xD8
	[CompilerGenerated]
	private static readonly string <Types_IsOfType_Failed>k__BackingField; // 0xE0
	[CompilerGenerated]
	private static readonly string <Reflection_HasAttribute_Failed>k__BackingField; // 0xE8
	[CompilerGenerated]
	private static readonly string <Reflection_HasConstructor_Failed>k__BackingField; // 0xF0
	[CompilerGenerated]
	private static readonly string <Reflection_HasPublicConstructor_Failed>k__BackingField; // 0xF8
	[CompilerGenerated]
	private static readonly string <ValueTypes_IsNotDefault_Failed>k__BackingField; // 0x100

	// Properties
	public static string Common_IsNull_Failed { get; }
	public static string Common_IsNotNull_Failed { get; }
	public static string Booleans_IsTrueFailed { get; }
	public static string Booleans_IsFalseFailed { get; }
	public static string Collections_Any_Failed { get; }
	public static string Collections_ContainsKey_Failed { get; }
	public static string Collections_HasItemsFailed { get; }
	public static string Collections_HasNoNullItemFailed { get; }
	public static string Collections_SizeIs_Failed { get; }
	public static string Comp_Is_Failed { get; }
	public static string Comp_IsNot_Failed { get; }
	public static string Comp_IsNotLt { get; }
	public static string Comp_IsNotLte { get; }
	public static string Comp_IsNotGt { get; }
	public static string Comp_IsNotGte { get; }
	public static string Comp_IsNotInRange_ToLow { get; }
	public static string Comp_IsNotInRange_ToHigh { get; }
	public static string Guids_IsNotEmpty_Failed { get; }
	public static string Strings_IsEqualTo_Failed { get; }
	public static string Strings_IsNotEqualTo_Failed { get; }
	public static string Strings_SizeIs_Failed { get; }
	public static string Strings_IsNotNullOrWhiteSpace_Failed { get; }
	public static string Strings_IsNotNullOrEmpty_Failed { get; }
	public static string Strings_HasLengthBetween_Failed_ToShort { get; }
	public static string Strings_HasLengthBetween_Failed_ToLong { get; }
	public static string Strings_Matches_Failed { get; }
	public static string Strings_IsNotEmpty_Failed { get; }
	public static string Strings_IsGuid_Failed { get; }
	public static string Types_IsOfType_Failed { get; }
	public static string Reflection_HasAttribute_Failed { get; }
	public static string Reflection_HasConstructor_Failed { get; }
	public static string Reflection_HasPublicConstructor_Failed { get; }
	public static string ValueTypes_IsNotDefault_Failed { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21F9B80 Offset: 0x21F8180 VA: 0x1821F9B80
	public static string get_Common_IsNull_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21F9B30 Offset: 0x21F8130 VA: 0x1821F9B30
	public static string get_Common_IsNotNull_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21F9950 Offset: 0x21F7F50 VA: 0x1821F9950
	public static string get_Booleans_IsTrueFailed() { }

	[CompilerGenerated]
	// RVA: 0x21F9900 Offset: 0x21F7F00 VA: 0x1821F9900
	public static string get_Booleans_IsFalseFailed() { }

	[CompilerGenerated]
	// RVA: 0x21F99A0 Offset: 0x21F7FA0 VA: 0x1821F99A0
	public static string get_Collections_Any_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21F99F0 Offset: 0x21F7FF0 VA: 0x1821F99F0
	public static string get_Collections_ContainsKey_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21F9A40 Offset: 0x21F8040 VA: 0x1821F9A40
	public static string get_Collections_HasItemsFailed() { }

	[CompilerGenerated]
	// RVA: 0x21F9A90 Offset: 0x21F8090 VA: 0x1821F9A90
	public static string get_Collections_HasNoNullItemFailed() { }

	[CompilerGenerated]
	// RVA: 0x21F9AE0 Offset: 0x21F80E0 VA: 0x1821F9AE0
	public static string get_Collections_SizeIs_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21F9E10 Offset: 0x21F8410 VA: 0x1821F9E10
	public static string get_Comp_Is_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21F9DC0 Offset: 0x21F83C0 VA: 0x1821F9DC0
	public static string get_Comp_IsNot_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21F9D20 Offset: 0x21F8320 VA: 0x1821F9D20
	public static string get_Comp_IsNotLt() { }

	[CompilerGenerated]
	// RVA: 0x21F9D70 Offset: 0x21F8370 VA: 0x1821F9D70
	public static string get_Comp_IsNotLte() { }

	[CompilerGenerated]
	// RVA: 0x21F9BD0 Offset: 0x21F81D0 VA: 0x1821F9BD0
	public static string get_Comp_IsNotGt() { }

	[CompilerGenerated]
	// RVA: 0x21F9C20 Offset: 0x21F8220 VA: 0x1821F9C20
	public static string get_Comp_IsNotGte() { }

	[CompilerGenerated]
	// RVA: 0x21F9CD0 Offset: 0x21F82D0 VA: 0x1821F9CD0
	public static string get_Comp_IsNotInRange_ToLow() { }

	[CompilerGenerated]
	// RVA: 0x21F9C70 Offset: 0x21F8270 VA: 0x1821F9C70
	public static string get_Comp_IsNotInRange_ToHigh() { }

	[CompilerGenerated]
	// RVA: 0x21F9E60 Offset: 0x21F8460 VA: 0x1821F9E60
	public static string get_Guids_IsNotEmpty_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21FA0A0 Offset: 0x21F86A0 VA: 0x1821FA0A0
	public static string get_Strings_IsEqualTo_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21FA1C0 Offset: 0x21F87C0 VA: 0x1821FA1C0
	public static string get_Strings_IsNotEqualTo_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21FA340 Offset: 0x21F8940 VA: 0x1821FA340
	public static string get_Strings_SizeIs_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21FA280 Offset: 0x21F8880 VA: 0x1821FA280
	public static string get_Strings_IsNotNullOrWhiteSpace_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21FA220 Offset: 0x21F8820 VA: 0x1821FA220
	public static string get_Strings_IsNotNullOrEmpty_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21FA040 Offset: 0x21F8640 VA: 0x1821FA040
	public static string get_Strings_HasLengthBetween_Failed_ToShort() { }

	[CompilerGenerated]
	// RVA: 0x21F9FE0 Offset: 0x21F85E0 VA: 0x1821F9FE0
	public static string get_Strings_HasLengthBetween_Failed_ToLong() { }

	[CompilerGenerated]
	// RVA: 0x21FA2E0 Offset: 0x21F88E0 VA: 0x1821FA2E0
	public static string get_Strings_Matches_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21FA160 Offset: 0x21F8760 VA: 0x1821FA160
	public static string get_Strings_IsNotEmpty_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21FA100 Offset: 0x21F8700 VA: 0x1821FA100
	public static string get_Strings_IsGuid_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21FA3A0 Offset: 0x21F89A0 VA: 0x1821FA3A0
	public static string get_Types_IsOfType_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21F9EC0 Offset: 0x21F84C0 VA: 0x1821F9EC0
	public static string get_Reflection_HasAttribute_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21F9F20 Offset: 0x21F8520 VA: 0x1821F9F20
	public static string get_Reflection_HasConstructor_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21F9F80 Offset: 0x21F8580 VA: 0x1821F9F80
	public static string get_Reflection_HasPublicConstructor_Failed() { }

	[CompilerGenerated]
	// RVA: 0x21FA400 Offset: 0x21F8A00 VA: 0x1821FA400
	public static string get_ValueTypes_IsNotDefault_Failed() { }

	// RVA: 0x21F8FE0 Offset: 0x21F75E0 VA: 0x1821F8FE0
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
[Extension]
internal static class XComparable // TypeDefIndex: 8930
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	internal static bool IsLt<T>(IComparable<T> x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x813AD0 Offset: 0x8120D0 VA: 0x180813AD0
	|-XComparable.IsLt<int>
	|
	|-RVA: 0x8139E0 Offset: 0x811FE0 VA: 0x1808139E0
	|-XComparable.IsLt<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static bool IsEq<T>(IComparable<T> x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x813800 Offset: 0x811E00 VA: 0x180813800
	|-XComparable.IsEq<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	internal static bool IsGt<T>(IComparable<T> x, T y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8138F0 Offset: 0x811EF0 VA: 0x1808138F0
	|-XComparable.IsGt<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.VisualScripting
[Extension]
internal static class XString // TypeDefIndex: 8932
{
	// Methods

	[Extension]
	// RVA: 0x130DB30 Offset: 0x130C130 VA: 0x18130DB30
	internal static string Inject(string format, object[] formattingArgs) { }

	[Extension]
	// RVA: 0x2212690 Offset: 0x2210C90 VA: 0x182212690
	internal static string Inject(string format, string[] formattingArgs) { }
}

// Namespace: Unity.VisualScripting
public struct EmptyEventArgs // TypeDefIndex: 8933
{}

// Namespace: Unity.VisualScripting
public static class EventBus // TypeDefIndex: 8934
{
	// Fields
	private static readonly Dictionary<EventHook, HashSet<Delegate>> events; // 0x0

	// Methods

	// RVA: 0x21F8990 Offset: 0x21F6F90 VA: 0x1821F8990
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	public static void Register<TArgs>(EventHook hook, Action<TArgs> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F5A50 Offset: 0x6F4050 VA: 0x1806F5A50
	|-EventBus.Register<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21F8830 Offset: 0x21F6E30 VA: 0x1821F8830
	public static void Unregister(EventHook hook, Delegate handler) { }

	// RVA: -1 Offset: -1
	public static void Trigger<TArgs>(EventHook hook, TArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F5CB0 Offset: 0x6F42B0 VA: 0x1806F5CB0
	|-EventBus.Trigger<bool>
	|
	|-RVA: 0x6F6070 Offset: 0x6F4670 VA: 0x1806F6070
	|-EventBus.Trigger<EmptyEventArgs>
	|
	|-RVA: 0x6F6A40 Offset: 0x6F5040 VA: 0x1806F6A40
	|-EventBus.Trigger<int>
	|
	|-RVA: 0x6F6EC0 Offset: 0x6F54C0 VA: 0x1806F6EC0
	|-EventBus.Trigger<object>
	|
	|-RVA: 0x6F7410 Offset: 0x6F5A10 VA: 0x1806F7410
	|-EventBus.Trigger<float>
	|
	|-RVA: 0x6F78C0 Offset: 0x6F5EC0 VA: 0x1806F78C0
	|-EventBus.Trigger<Vector2>
	|
	|-RVA: 0x6F6430 Offset: 0x6F4A30 VA: 0x1806F6430
	|-EventBus.Trigger<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Trigger<TArgs>(string name, GameObject target, TArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6F5BE0 Offset: 0x6F41E0 VA: 0x1806F5BE0
	|-EventBus.Trigger<bool>
	|
	|-RVA: 0x6F6E00 Offset: 0x6F5400 VA: 0x1806F6E00
	|-EventBus.Trigger<int>
	|
	|-RVA: 0x6F7280 Offset: 0x6F5880 VA: 0x1806F7280
	|-EventBus.Trigger<object>
	|
	|-RVA: 0x6F7340 Offset: 0x6F5940 VA: 0x1806F7340
	|-EventBus.Trigger<float>
	|
	|-RVA: 0x6F77F0 Offset: 0x6F5DF0 VA: 0x1806F77F0
	|-EventBus.Trigger<Vector2>
	|
	|-RVA: 0x6F68E0 Offset: 0x6F4EE0 VA: 0x1806F68E0
	|-EventBus.Trigger<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21F87B0 Offset: 0x21F6DB0 VA: 0x1821F87B0
	public static void Trigger(EventHook hook) { }

	// RVA: 0x21F86B0 Offset: 0x21F6CB0 VA: 0x1821F86B0
	public static void Trigger(string name, GameObject target) { }
}

// Namespace: Unity.VisualScripting
public struct EventHook // TypeDefIndex: 8935
{
	// Fields
	public readonly string name; // 0x0
	public readonly object target; // 0x8
	public readonly object tag; // 0x10

	// Methods

	// RVA: 0x21F8CD0 Offset: 0x21F72D0 VA: 0x1821F8CD0
	public void .ctor(string name, object target, object tag) { }

	// RVA: 0x21F8BB0 Offset: 0x21F71B0 VA: 0x1821F8BB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21F8B30 Offset: 0x21F7130 VA: 0x1821F8B30
	public bool Equals(EventHook other) { }

	// RVA: 0x21F8C80 Offset: 0x21F7280 VA: 0x1821F8C80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21F8E80 Offset: 0x21F7480 VA: 0x1821F8E80
	public static bool op_Equality(EventHook a, EventHook b) { }

	// RVA: 0x21F8F40 Offset: 0x21F7540 VA: 0x1821F8F40
	public static bool op_Inequality(EventHook a, EventHook b) { }

	// RVA: 0x21F8F10 Offset: 0x21F7510 VA: 0x1821F8F10
	public static EventHook op_Implicit(string name) { }
}

// Namespace: Unity.VisualScripting
public class EventHookComparer : IEqualityComparer<EventHook> // TypeDefIndex: 8936
{
	// Methods

	// RVA: 0x21F8A50 Offset: 0x21F7050 VA: 0x1821F8A50 Slot: 4
	public bool Equals(EventHook x, EventHook y) { }

	// RVA: 0x21F8AE0 Offset: 0x21F70E0 VA: 0x1821F8AE0 Slot: 5
	public int GetHashCode(EventHook obj) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public static class EventHooks // TypeDefIndex: 8937
{
	// Fields
	public const string Custom = "Custom";
	public const string OnGUI = "OnGUI";
	public const string OnApplicationFocus = "OnApplicationFocus";
	public const string OnApplicationLostFocus = "OnApplicationLostFocus";
	public const string OnApplicationPause = "OnApplicationPause";
	public const string OnApplicationResume = "OnApplicationResume";
	public const string OnApplicationQuit = "OnApplicationQuit";
	public const string OnEnable = "OnEnable";
	public const string Start = "Start";
	public const string Update = "Update";
	public const string FixedUpdate = "FixedUpdate";
	public const string LateUpdate = "LateUpdate";
	public const string OnDisable = "OnDisable";
	public const string OnDestroy = "OnDestroy";
	public const string AnimationEvent = "AnimationEvent";
	public const string UnityEvent = "UnityEvent";
	public const string OnDrawGizmos = "OnDrawGizmos";
	public const string OnDrawGizmosSelected = "OnDrawGizmosSelected";
	public const string OnPointerEnter = "OnPointerEnter";
	public const string OnPointerExit = "OnPointerExit";
	public const string OnPointerDown = "OnPointerDown";
	public const string OnPointerUp = "OnPointerUp";
	public const string OnPointerClick = "OnPointerClick";
	public const string OnBeginDrag = "OnBeginDrag";
	public const string OnDrag = "OnDrag";
	public const string OnEndDrag = "OnEndDrag";
	public const string OnDrop = "OnDrop";
	public const string OnScroll = "OnScroll";
	public const string OnSelect = "OnSelect";
	public const string OnDeselect = "OnDeselect";
	public const string OnSubmit = "OnSubmit";
	public const string OnCancel = "OnCancel";
	public const string OnMove = "OnMove";
	public const string OnBecameInvisible = "OnBecameInvisible";
	public const string OnBecameVisible = "OnBecameVisible";
	public const string OnCollisionEnter = "OnCollisionEnter";
	public const string OnCollisionExit = "OnCollisionExit";
	public const string OnCollisionStay = "OnCollisionStay";
	public const string OnCollisionEnter2D = "OnCollisionEnter2D";
	public const string OnCollisionExit2D = "OnCollisionExit2D";
	public const string OnCollisionStay2D = "OnCollisionStay2D";
	public const string OnControllerColliderHit = "OnControllerColliderHit";
	public const string OnJointBreak = "OnJointBreak";
	public const string OnJointBreak2D = "OnJointBreak2D";
	public const string OnMouseDown = "OnMouseDown";
	public const string OnMouseDrag = "OnMouseDrag";
	public const string OnMouseEnter = "OnMouseEnter";
	public const string OnMouseExit = "OnMouseExit";
	public const string OnMouseOver = "OnMouseOver";
	public const string OnMouseUp = "OnMouseUp";
	public const string OnMouseUpAsButton = "OnMouseUpAsButton";
	public const string OnParticleCollision = "OnParticleCollision";
	public const string OnTransformChildrenChanged = "OnTransformChildrenChanged";
	public const string OnTransformParentChanged = "OnTransformParentChanged";
	public const string OnTriggerEnter = "OnTriggerEnter";
	public const string OnTriggerExit = "OnTriggerExit";
	public const string OnTriggerStay = "OnTriggerStay";
	public const string OnTriggerEnter2D = "OnTriggerEnter2D";
	public const string OnTriggerExit2D = "OnTriggerExit2D";
	public const string OnTriggerStay2D = "OnTriggerStay2D";
	public const string OnAnimatorMove = "OnAnimatorMove";
	public const string OnAnimatorIK = "OnAnimatorIK";
	public const string OnButtonClick = "OnButtonClick";
	public const string OnToggleValueChanged = "OnToggleValueChanged";
	public const string OnSliderValueChanged = "OnSliderValueChanged";
	public const string OnScrollbarValueChanged = "OnScrollbarValueChanged";
	public const string OnDropdownValueChanged = "OnDropdownValueChanged";
	public const string OnInputFieldValueChanged = "OnInputFieldValueChanged";
	public const string OnInputFieldEndEdit = "OnInputFieldEndEdit";
	public const string OnScrollRectValueChanged = "OnScrollRectValueChanged";
}

// Namespace: Unity.VisualScripting
public abstract class EventMachine<TGraph, TMacro> : Machine<TGraph, TMacro>, IEventMachine, IMachine, IGraphRoot, IGraphParent, IGraphNester, IAotStubbable // TypeDefIndex: 8940
{
	// Methods

	// RVA: -1 Offset: -1
	protected void TriggerEvent(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCC70 Offset: 0xFFB270 VA: 0x180FFCC70
	|-EventMachine<object, object>.TriggerEvent
	*/

	// RVA: -1 Offset: -1
	protected void TriggerEvent<TArgs>(string name, TArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602910 Offset: 0x600F10 VA: 0x180602910
	|-EventMachine<object, object>.TriggerEvent<object>
	|
	|-RVA: 0x6027A0 Offset: 0x600DA0 VA: 0x1806027A0
	|-EventMachine<object, object>.TriggerEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void TriggerUnregisteredEvent(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCDD0 Offset: 0xFFB3D0 VA: 0x180FFCDD0
	|-EventMachine<object, object>.TriggerUnregisteredEvent
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void TriggerRegisteredEvent<TArgs>(EventHook hook, TArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602A10 Offset: 0x601010 VA: 0x180602A10
	|-EventMachine<object, object>.TriggerRegisteredEvent<EmptyEventArgs>
	|
	|-RVA: 0x602BC0 Offset: 0x6011C0 VA: 0x180602BC0
	|-EventMachine<object, object>.TriggerRegisteredEvent<object>
	|
	|-RVA: 0x602AA0 Offset: 0x6010A0 VA: 0x180602AA0
	|-EventMachine<object, object>.TriggerRegisteredEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void TriggerUnregisteredEvent<TArgs>(EventHook hook, TArgs args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x602C50 Offset: 0x601250 VA: 0x180602C50
	|-EventMachine<object, object>.TriggerUnregisteredEvent<EmptyEventArgs>
	|
	|-RVA: 0x602F20 Offset: 0x601520 VA: 0x180602F20
	|-EventMachine<object, object>.TriggerUnregisteredEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFC710 Offset: 0xFFAD10 VA: 0x180FFC710
	|-EventMachine<object, object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 24
	protected override void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCA20 Offset: 0xFFB020 VA: 0x180FFCA20
	|-EventMachine<object, object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 39
	protected virtual void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCBA0 Offset: 0xFFB1A0 VA: 0x180FFCBA0
	|-EventMachine<object, object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 25
	protected override void OnInstantiateWhileEnabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCAA0 Offset: 0xFFB0A0 VA: 0x180FFCAA0
	|-EventMachine<object, object>.OnInstantiateWhileEnabled
	*/

	// RVA: -1 Offset: -1 Slot: 40
	protected virtual void Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCEA0 Offset: 0xFFB4A0 VA: 0x180FFCEA0
	|-EventMachine<object, object>.Update
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected virtual void FixedUpdate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFC740 Offset: 0xFFAD40 VA: 0x180FFC740
	|-EventMachine<object, object>.FixedUpdate
	*/

	// RVA: -1 Offset: -1 Slot: 42
	protected virtual void LateUpdate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFC7A0 Offset: 0xFFADA0 VA: 0x180FFC7A0
	|-EventMachine<object, object>.LateUpdate
	*/

	// RVA: -1 Offset: -1 Slot: 26
	protected override void OnUninstantiateWhileEnabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCB20 Offset: 0xFFB120 VA: 0x180FFCB20
	|-EventMachine<object, object>.OnUninstantiateWhileEnabled
	*/

	// RVA: -1 Offset: -1 Slot: 27
	protected override void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFC8E0 Offset: 0xFFAEE0 VA: 0x180FFC8E0
	|-EventMachine<object, object>.OnDisable
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected override void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFC800 Offset: 0xFFAE00 VA: 0x180FFC800
	|-EventMachine<object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override void TriggerAnimationEvent(AnimationEvent animationEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCC00 Offset: 0xFFB200 VA: 0x180FFCC00
	|-EventMachine<object, object>.TriggerAnimationEvent
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public override void TriggerUnityEvent(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCD60 Offset: 0xFFB360 VA: 0x180FFCD60
	|-EventMachine<object, object>.TriggerUnityEvent
	*/

	// RVA: -1 Offset: -1 Slot: 43
	protected virtual void OnDrawGizmos() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFC9C0 Offset: 0xFFAFC0 VA: 0x180FFC9C0
	|-EventMachine<object, object>.OnDrawGizmos
	*/

	// RVA: -1 Offset: -1 Slot: 44
	protected virtual void OnDrawGizmosSelected() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFC960 Offset: 0xFFAF60 VA: 0x180FFC960
	|-EventMachine<object, object>.OnDrawGizmosSelected
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFCF00 Offset: 0xFFB500 VA: 0x180FFCF00
	|-EventMachine<object, object>..ctor
	*/
}

// Namespace: Unity.VisualScripting
[Extension]
public static class XEventGraph // TypeDefIndex: 8941
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static void TriggerEventHandler<TArgs>(GraphReference reference, Func<EventHook, bool> predicate, TArgs args, Func<IGraphParentElement, bool> recurse, bool force) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x814060 Offset: 0x812660 VA: 0x180814060
	|-XEventGraph.TriggerEventHandler<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void TriggerEventHandler<TArgs>(GraphStack stack, Func<EventHook, bool> predicate, TArgs args, Func<IGraphParentElement, bool> recurse, bool force) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x813C60 Offset: 0x812260 VA: 0x180813C60
	|-XEventGraph.TriggerEventHandler<EmptyEventArgs>
	|
	|-RVA: 0x814510 Offset: 0x812B10 VA: 0x180814510
	|-XEventGraph.TriggerEventHandler<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.VisualScripting
public interface IEventMachine : IMachine, IGraphRoot, IGraphParent, IGraphNester, IAotStubbable // TypeDefIndex: 8942
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TriggerAnimationEvent(AnimationEvent animationEvent);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void TriggerUnityEvent(string name);
}

// Namespace: Unity.VisualScripting
public interface IGraphEventHandler<TArgs> // TypeDefIndex: 8943
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract EventHook GetHook(GraphReference reference);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGraphEventHandler<__Il2CppFullySharedGenericType>.GetHook
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Trigger(GraphReference reference, TArgs args);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGraphEventHandler<__Il2CppFullySharedGenericType>.Trigger
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsListening(GraphPointer pointer);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGraphEventHandler<__Il2CppFullySharedGenericType>.IsListening
	*/
}

// Namespace: Unity.VisualScripting
public static class DebugUtility // TypeDefIndex: 8944
{
	// Properties
	public static string logPath { get; }

	// Methods

	// RVA: 0x21F5030 Offset: 0x21F3630 VA: 0x1821F5030
	public static string get_logPath() { }

	// RVA: 0x21F4F90 Offset: 0x21F3590 VA: 0x1821F4F90
	public static void LogToFile(string message) { }
}

// Namespace: Unity.VisualScripting
public class InvalidConversionException : InvalidCastException // TypeDefIndex: 8945
{
	// Methods

	// RVA: 0x2204400 Offset: 0x2202A00 VA: 0x182204400
	public void .ctor() { }

	// RVA: 0x2204410 Offset: 0x2202A10 VA: 0x182204410
	public void .ctor(string message) { }

	// RVA: 0x2204420 Offset: 0x2202A20 VA: 0x182204420
	public void .ctor(string message, Exception innerException) { }
}

// Namespace: Unity.VisualScripting
public class InvalidImplementationException : Exception // TypeDefIndex: 8946
{
	// Methods

	// RVA: 0x2204430 Offset: 0x2202A30 VA: 0x182204430
	public void .ctor() { }

	// RVA: 0x2204480 Offset: 0x2202A80 VA: 0x182204480
	public void .ctor(string message) { }
}

// Namespace: Unity.VisualScripting
public class UnexpectedEnumValueException<T> : Exception // TypeDefIndex: 8947
{
	// Fields
	[CompilerGenerated]
	private T <Value>k__BackingField; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC7B70 Offset: 0xAC6170 VA: 0x180AC7B70
	|-UnexpectedEnumValueException<Int32Enum>..ctor
	|
	|-RVA: 0xAC77B0 Offset: 0xAC5DB0 VA: 0x180AC77B0
	|-UnexpectedEnumValueException<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	|-UnexpectedEnumValueException<Int32Enum>.get_Value
	|
	|-RVA: 0xAC7D60 Offset: 0xAC6360 VA: 0x180AC7D60
	|-UnexpectedEnumValueException<__Il2CppFullySharedGenericType>.get_Value
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xAC7EF0 Offset: 0xAC64F0 VA: 0x180AC7EF0
	|-UnexpectedEnumValueException<Int32Enum>.set_Value
	|
	|-RVA: 0xAC7E20 Offset: 0xAC6420 VA: 0x180AC7E20
	|-UnexpectedEnumValueException<__Il2CppFullySharedGenericType>.set_Value
	*/
}

// Namespace: Unity.VisualScripting
public abstract class Graph : IGraph, IDisposable, IPrewarmable, IAotStubbable, ISerializationDepender, ISerializationCallbackReceiver // TypeDefIndex: 8950
{
	// Fields
	[SerializeAs("elements")]
	private List<IGraphElement> _elements; // 0x10
	[CompilerGenerated]
	private readonly MergedGraphElementCollection <elements>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <title>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <summary>k__BackingField; // 0x28
	[CompilerGenerated]
	private Vector2 <pan>k__BackingField; // 0x30
	[CompilerGenerated]
	private float <zoom>k__BackingField; // 0x38
	private bool prewarmed; // 0x3C

	// Properties
	[DoNotSerialize]
	public MergedGraphElementCollection elements { get; }
	[Serialize]
	public string title { get; set; }
	[Serialize]
	[InspectorTextArea(minLines = 1, maxLines = 10)]
	public string summary { get; set; }
	[Serialize]
	public Vector2 pan { get; set; }
	[Serialize]
	public float zoom { get; set; }
	public IEnumerable<ISerializationDependency> deserializationDependencies { get; }

	// Methods

	// RVA: 0x22036F0 Offset: 0x2201CF0 VA: 0x1822036F0
	protected void .ctor() { }

	// RVA: 0x22034A0 Offset: 0x2201AA0 VA: 0x1822034A0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract IGraphData CreateData();

	// RVA: 0x22027A0 Offset: 0x2200DA0 VA: 0x1822027A0 Slot: 23
	public virtual IGraphDebugData CreateDebugData() { }

	// RVA: 0x2202B50 Offset: 0x2201150 VA: 0x182202B50 Slot: 24
	public virtual void Instantiate(GraphReference instance) { }

	// RVA: 0x2203510 Offset: 0x2201B10 VA: 0x182203510 Slot: 25
	public virtual void Uninstantiate(GraphReference instance) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 8
	public MergedGraphElementCollection get_elements() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 9
	public string get_title() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	public void set_title(string value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 10
	public string get_summary() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void set_summary(string value) { }

	[CompilerGenerated]
	// RVA: 0x22038F0 Offset: 0x2201EF0 VA: 0x1822038F0 Slot: 4
	public Vector2 get_pan() { }

	[CompilerGenerated]
	// RVA: 0x1641190 Offset: 0x163F790 VA: 0x181641190 Slot: 5
	public void set_pan(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x5590D0 Offset: 0x5576D0 VA: 0x1805590D0 Slot: 6
	public float get_zoom() { }

	[CompilerGenerated]
	// RVA: 0x559130 Offset: 0x557730 VA: 0x180559130 Slot: 7
	public void set_zoom(float value) { }

	// RVA: 0x22037D0 Offset: 0x2201DD0 VA: 0x1822037D0 Slot: 18
	public IEnumerable<ISerializationDependency> get_deserializationDependencies() { }

	// RVA: 0x2203230 Offset: 0x2201830 VA: 0x182203230 Slot: 26
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x22031E0 Offset: 0x22017E0 VA: 0x1822031E0 Slot: 21
	public void OnAfterDeserialize() { }

	// RVA: 0x2202D30 Offset: 0x2201330 VA: 0x182202D30 Slot: 27
	public virtual void OnAfterDependenciesDeserialized() { }

	// RVA: 0x22029C0 Offset: 0x2200FC0 VA: 0x1822029C0 Slot: 17
	public IEnumerable<object> GetAotStubs(HashSet<object> visited) { }

	// RVA: 0x22032B0 Offset: 0x22018B0 VA: 0x1822032B0 Slot: 16
	public void Prewarm() { }

	// RVA: 0x2202800 Offset: 0x2200E00 VA: 0x182202800 Slot: 28
	public virtual void Dispose() { }
}

// Namespace: Unity.VisualScripting
public class GraphData<TGraph> : IGraphData // TypeDefIndex: 8951
{
	// Fields
	[CompilerGenerated]
	private readonly TGraph <definition>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly Dictionary<IGraphElementWithData, IGraphElementData> <elementsData>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly Dictionary<IGraphParentElement, IGraphData> <childrenGraphsData>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly Dictionary<Guid, IGraphElementData> <phantomElementsData>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly Dictionary<Guid, IGraphData> <phantomChildrenGraphsData>k__BackingField; // 0x0

	// Properties
	protected TGraph definition { get; }
	protected Dictionary<IGraphElementWithData, IGraphElementData> elementsData { get; }
	protected Dictionary<IGraphParentElement, IGraphData> childrenGraphsData { get; }
	protected Dictionary<Guid, IGraphElementData> phantomElementsData { get; }
	protected Dictionary<Guid, IGraphData> phantomChildrenGraphsData { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TGraph definition) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102FBB0 Offset: 0x102E1B0 VA: 0x18102FBB0
	|-GraphData<object>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected TGraph get_definition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-GraphData<object>.get_definition
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected Dictionary<IGraphElementWithData, IGraphElementData> get_elementsData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	|-GraphData<object>.get_elementsData
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected Dictionary<IGraphParentElement, IGraphData> get_childrenGraphsData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-GraphData<object>.get_childrenGraphsData
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected Dictionary<Guid, IGraphElementData> get_phantomElementsData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	|-GraphData<object>.get_phantomElementsData
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected Dictionary<Guid, IGraphData> get_phantomChildrenGraphsData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-GraphData<object>.get_phantomChildrenGraphsData
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool TryGetElementData(IGraphElementWithData element, out IGraphElementData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102FB40 Offset: 0x102E140 VA: 0x18102FB40
	|-GraphData<object>.TryGetElementData
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool TryGetChildGraphData(IGraphParentElement element, out IGraphData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102FAD0 Offset: 0x102E0D0 VA: 0x18102FAD0
	|-GraphData<object>.TryGetChildGraphData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public IGraphElementData CreateElementData(IGraphElementWithData element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F510 Offset: 0x102DB10 VA: 0x18102F510
	|-GraphData<object>.CreateElementData
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void FreeElementData(IGraphElementWithData element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F910 Offset: 0x102DF10 VA: 0x18102F910
	|-GraphData<object>.FreeElementData
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public IGraphData CreateChildGraphData(IGraphParentElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F2A0 Offset: 0x102D8A0 VA: 0x18102F2A0
	|-GraphData<object>.CreateChildGraphData
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void FreeChildGraphData(IGraphParentElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102F750 Offset: 0x102DD50 VA: 0x18102F750
	|-GraphData<object>.FreeChildGraphData
	*/
}

// Namespace: Unity.VisualScripting
public class GraphDebugData : IGraphDebugData // TypeDefIndex: 8952
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<IGraphElementWithDebugData, IGraphElementDebugData> <elementsData>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Dictionary<IGraphParentElement, IGraphDebugData> <childrenGraphsData>k__BackingField; // 0x18

	// Properties
	protected Dictionary<IGraphElementWithDebugData, IGraphElementDebugData> elementsData { get; }
	protected Dictionary<IGraphParentElement, IGraphDebugData> childrenGraphsData { get; }
	private IEnumerable<IGraphElementDebugData> Unity.VisualScripting.IGraphDebugData.elementsData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	protected Dictionary<IGraphElementWithDebugData, IGraphElementDebugData> get_elementsData() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	protected Dictionary<IGraphParentElement, IGraphDebugData> get_childrenGraphsData() { }

	// RVA: 0x21FAE80 Offset: 0x21F9480 VA: 0x1821FAE80 Slot: 6
	private IEnumerable<IGraphElementDebugData> Unity.VisualScripting.IGraphDebugData.get_elementsData() { }

	// RVA: 0x21FAED0 Offset: 0x21F94D0 VA: 0x1821FAED0
	public void .ctor(IGraph definition) { }

	// RVA: 0x21FADC0 Offset: 0x21F93C0 VA: 0x1821FADC0 Slot: 4
	public IGraphElementDebugData GetOrCreateElementData(IGraphElementWithDebugData element) { }

	// RVA: 0x21FACC0 Offset: 0x21F92C0 VA: 0x1821FACC0 Slot: 5
	public IGraphDebugData GetOrCreateChildGraphData(IGraphParentElement element) { }
}

// Namespace: Unity.VisualScripting
public abstract class GraphElement<TGraph> : IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable // TypeDefIndex: 8953
{
	// Fields
	[CompilerGenerated]
	private Guid <guid>k__BackingField; // 0x0
	[CompilerGenerated]
	private TGraph <graph>k__BackingField; // 0x0

	// Properties
	[Serialize]
	public Guid guid { get; set; }
	[DoNotSerialize]
	public virtual int dependencyOrder { get; }
	[DoNotSerialize]
	public TGraph graph { get; set; }
	[DoNotSerialize]
	private IGraph Unity.VisualScripting.IGraphElement.graph { get; set; }
	[DoNotSerialize]
	private IGraph Unity.VisualScripting.IGraphItem.graph { get; }
	public virtual IEnumerable<ISerializationDependency> deserializationDependencies { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 21
	public Guid get_guid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA67320 Offset: 0xA65920 VA: 0x180A67320
	|-GraphElement<object>.get_guid
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public void set_guid(Guid value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032A10 Offset: 0x1031010 VA: 0x181032A10
	|-GraphElement<object>.set_guid
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public virtual void Instantiate(GraphReference instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032230 Offset: 0x1030830 VA: 0x181032230
	|-GraphElement<object>.Instantiate
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public virtual void Uninstantiate(GraphReference instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032700 Offset: 0x1030D00 VA: 0x181032700
	|-GraphElement<object>.Uninstantiate
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public virtual void BeforeAdd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-GraphElement<object>.BeforeAdd
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public virtual void AfterAdd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031CE0 Offset: 0x10302E0 VA: 0x181031CE0
	|-GraphElement<object>.AfterAdd
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public virtual void BeforeRemove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031E60 Offset: 0x1030460 VA: 0x181031E60
	|-GraphElement<object>.BeforeRemove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public virtual void AfterRemove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-GraphElement<object>.AfterRemove
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public virtual void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-GraphElement<object>.Dispose
	*/

	// RVA: -1 Offset: -1
	protected void InstantiateNest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032030 Offset: 0x1030630 VA: 0x181032030
	|-GraphElement<object>.InstantiateNest
	*/

	// RVA: -1 Offset: -1
	protected void UninstantiateNest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032540 Offset: 0x1030B40 VA: 0x181032540
	|-GraphElement<object>.UninstantiateNest
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public virtual int get_dependencyOrder() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	|-GraphElement<object>.get_dependencyOrder
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public virtual bool HandleDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-GraphElement<object>.HandleDependencies
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public TGraph get_graph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-GraphElement<object>.get_graph
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_graph(TGraph value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	|-GraphElement<object>.set_graph
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IGraph Unity.VisualScripting.IGraphElement.get_graph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-GraphElement<object>.Unity.VisualScripting.IGraphElement.get_graph
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.VisualScripting.IGraphElement.set_graph(IGraph value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10328C0 Offset: 0x1030EC0 VA: 0x1810328C0
	|-GraphElement<object>.Unity.VisualScripting.IGraphElement.set_graph
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IGraph Unity.VisualScripting.IGraphItem.get_graph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-GraphElement<object>.Unity.VisualScripting.IGraphItem.get_graph
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual IEnumerable<ISerializationDependency> get_deserializationDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10329E0 Offset: 0x1030FE0 VA: 0x1810329E0
	|-GraphElement<object>.get_deserializationDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public virtual IEnumerable<object> GetAotStubs(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032000 Offset: 0x1030600 VA: 0x181032000
	|-GraphElement<object>.GetAotStubs
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public virtual void Prewarm() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-GraphElement<object>.Prewarm
	*/

	// RVA: -1 Offset: -1
	protected void CopyFrom(GraphElement<TGraph> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-GraphElement<object>.CopyFrom
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032410 Offset: 0x1030A10 VA: 0x181032410
	|-GraphElement<object>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public virtual AnalyticsIdentifier GetAnalyticsIdentifier() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603570 Offset: 0x601B70 VA: 0x180603570
	|-GraphElement<object>.GetAnalyticsIdentifier
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10329B0 Offset: 0x1030FB0 VA: 0x1810329B0
	|-GraphElement<object>..ctor
	*/
}

// Namespace: Unity.VisualScripting
public sealed class GraphElementCollection<TElement> : GuidCollection<TElement>, IGraphElementCollection<TElement>, IKeyedCollection<Guid, TElement>, ICollection<TElement>, IEnumerable<TElement>, IEnumerable, INotifyCollectionChanged<TElement>, IProxyableNotifyCollectionChanged<TElement> // TypeDefIndex: 8955
{
	// Fields
	[CompilerGenerated]
	private readonly IGraph <graph>k__BackingField; // 0x0
	[CompilerGenerated]
	private Action<TElement> ItemAdded; // 0x0
	[CompilerGenerated]
	private Action<TElement> ItemRemoved; // 0x0
	[CompilerGenerated]
	private Action CollectionChanged; // 0x0
	[CompilerGenerated]
	private bool <ProxyCollectionChange>k__BackingField; // 0x0

	// Properties
	public IGraph graph { get; }
	public bool ProxyCollectionChange { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IGraph graph) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031780 Offset: 0x102FD80 VA: 0x181031780
	|-GraphElementCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public IGraph get_graph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.get_graph
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 45
	public void add_ItemAdded(Action<TElement> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10318F0 Offset: 0x102FEF0 VA: 0x1810318F0
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.add_ItemAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 46
	public void remove_ItemAdded(Action<TElement> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031B30 Offset: 0x1030130 VA: 0x181031B30
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.remove_ItemAdded
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 47
	public void add_ItemRemoved(Action<TElement> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10319C0 Offset: 0x102FFC0 VA: 0x1810319C0
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.add_ItemRemoved
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 48
	public void remove_ItemRemoved(Action<TElement> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031C00 Offset: 0x1030200 VA: 0x181031C00
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.remove_ItemRemoved
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 49
	public void add_CollectionChanged(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031850 Offset: 0x102FE50 VA: 0x181031850
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.add_CollectionChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 50
	public void remove_CollectionChanged(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031A90 Offset: 0x1030090 VA: 0x181031A90
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.remove_CollectionChanged
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 51
	public bool get_ProxyCollectionChange() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D0B0 Offset: 0x95B6B0 VA: 0x18095D0B0
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.get_ProxyCollectionChange
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 52
	public void set_ProxyCollectionChange(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031CD0 Offset: 0x10302D0 VA: 0x181031CD0
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.set_ProxyCollectionChange
	*/

	// RVA: -1 Offset: -1 Slot: 53
	public void BeforeAdd(TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1030140 Offset: 0x102E740 VA: 0x181030140
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.BeforeAdd
	*/

	// RVA: -1 Offset: -1 Slot: 54
	public void AfterAdd(TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102FD20 Offset: 0x102E320 VA: 0x18102FD20
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.AfterAdd
	*/

	// RVA: -1 Offset: -1 Slot: 55
	public void BeforeRemove(TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1030510 Offset: 0x102EB10 VA: 0x181030510
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.BeforeRemove
	*/

	// RVA: -1 Offset: -1 Slot: 56
	public void AfterRemove(TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102FED0 Offset: 0x102E4D0 VA: 0x18102FED0
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.AfterRemove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, TElement element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1030FC0 Offset: 0x102F5C0 VA: 0x181030FC0
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031300 Offset: 0x102F900 VA: 0x181031300
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10305F0 Offset: 0x102EBF0 VA: 0x1810305F0
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected override void SetItem(int index, TElement item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9F64C0 Offset: 0x9F4AC0 VA: 0x1809F64C0
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1
	public NoAllocEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1030F10 Offset: 0x102F510 VA: 0x181030F10
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private TElement Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.get_Item(Guid key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10316C0 Offset: 0x102FCC0 VA: 0x1810316C0
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 43
	private bool Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.Contains(Guid key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031600 Offset: 0x102FC00 VA: 0x181031600
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 44
	private bool Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.Remove(Guid key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1031660 Offset: 0x102FC60 VA: 0x181031660
	|-GraphElementCollection<__Il2CppFullySharedGenericType>.Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.Remove
	*/
}

// Namespace: Unity.VisualScripting
public static class GraphInstances // TypeDefIndex: 8956
{
	// Fields
	private static readonly object lock; // 0x0
	private static readonly Dictionary<IGraph, HashSet<GraphReference>> byGraph; // 0x8
	private static readonly Dictionary<IGraphParent, HashSet<GraphReference>> byParent; // 0x10

	// Methods

	// RVA: 0x21FB290 Offset: 0x21F9890 VA: 0x1821FB290
	public static void Instantiate(GraphReference instance) { }

	// RVA: 0x21FBB50 Offset: 0x21FA150 VA: 0x1821FBB50
	public static void Uninstantiate(GraphReference instance) { }

	// RVA: 0x21FB930 Offset: 0x21F9F30 VA: 0x1821FB930
	public static HashSet<GraphReference> OfPooled(IGraph graph) { }

	// RVA: 0x21FB070 Offset: 0x21F9670 VA: 0x1821FB070
	public static HashSet<GraphReference> ChildrenOfPooled(IGraphParent parent) { }

	// RVA: 0x21FC120 Offset: 0x21FA720 VA: 0x1821FC120
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class GraphNest<TGraph, TMacro> : IGraphNest, IAotStubbable // TypeDefIndex: 8958
{
	// Fields
	[CompilerGenerated]
	private IGraphNester <nester>k__BackingField; // 0x0
	[DoNotSerialize]
	private GraphSource _source; // 0x0
	[DoNotSerialize]
	private TMacro _macro; // 0x0
	[DoNotSerialize]
	private TGraph _embed; // 0x0
	[CompilerGenerated]
	private Action beforeGraphChange; // 0x0
	[CompilerGenerated]
	private Action afterGraphChange; // 0x0

	// Properties
	[DoNotSerialize]
	public IGraphNester nester { get; set; }
	[Serialize]
	public GraphSource source { get; set; }
	[Serialize]
	public TMacro macro { get; set; }
	[Serialize]
	public TGraph embed { get; set; }
	[DoNotSerialize]
	public TGraph graph { get; }
	private IMacro Unity.VisualScripting.IGraphNest.macro { get; set; }
	private IGraph Unity.VisualScripting.IGraphNest.embed { get; set; }
	private IGraph Unity.VisualScripting.IGraphNest.graph { get; }
	private Type Unity.VisualScripting.IGraphNest.graphType { get; }
	private Type Unity.VisualScripting.IGraphNest.macroType { get; }
	public IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	[DoNotSerialize]
	public bool hasBackgroundEmbed { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public IGraphNester get_nester() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-GraphNest<object, object>.get_nester
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public void set_nester(IGraphNester value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-GraphNest<object, object>.set_nester
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public GraphSource get_source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	|-GraphNest<object, object>.get_source
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void set_source(GraphSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10335C0 Offset: 0x1031BC0 VA: 0x1810335C0
	|-GraphNest<object, object>.set_source
	*/

	// RVA: -1 Offset: -1
	public TMacro get_macro() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-GraphNest<object, object>.get_macro
	*/

	// RVA: -1 Offset: -1
	public void set_macro(TMacro value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1033500 Offset: 0x1031B00 VA: 0x181033500
	|-GraphNest<object, object>.set_macro
	*/

	// RVA: -1 Offset: -1
	public TGraph get_embed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	|-GraphNest<object, object>.get_embed
	*/

	// RVA: -1 Offset: -1
	public void set_embed(TGraph value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1033490 Offset: 0x1031A90 VA: 0x181033490
	|-GraphNest<object, object>.set_embed
	*/

	// RVA: -1 Offset: -1
	public TGraph get_graph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1033270 Offset: 0x1031870 VA: 0x181033270
	|-GraphNest<object, object>.get_graph
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private IMacro Unity.VisualScripting.IGraphNest.get_macro() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-GraphNest<object, object>.Unity.VisualScripting.IGraphNest.get_macro
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void Unity.VisualScripting.IGraphNest.set_macro(IMacro value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032F70 Offset: 0x1031570 VA: 0x181032F70
	|-GraphNest<object, object>.Unity.VisualScripting.IGraphNest.set_macro
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private IGraph Unity.VisualScripting.IGraphNest.get_embed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	|-GraphNest<object, object>.Unity.VisualScripting.IGraphNest.get_embed
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void Unity.VisualScripting.IGraphNest.set_embed(IGraph value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032EA0 Offset: 0x10314A0 VA: 0x181032EA0
	|-GraphNest<object, object>.Unity.VisualScripting.IGraphNest.set_embed
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IGraph Unity.VisualScripting.IGraphNest.get_graph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032E40 Offset: 0x1031440 VA: 0x181032E40
	|-GraphNest<object, object>.Unity.VisualScripting.IGraphNest.get_graph
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private Type Unity.VisualScripting.IGraphNest.get_graphType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032E00 Offset: 0x1031400 VA: 0x181032E00
	|-GraphNest<object, object>.Unity.VisualScripting.IGraphNest.get_graphType
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private Type Unity.VisualScripting.IGraphNest.get_macroType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032E60 Offset: 0x1031460 VA: 0x181032E60
	|-GraphNest<object, object>.Unity.VisualScripting.IGraphNest.get_macroType
	*/

	// RVA: -1 Offset: -1
	public void SwitchToEmbed(TGraph embed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032CB0 Offset: 0x10312B0 VA: 0x181032CB0
	|-GraphNest<object, object>.SwitchToEmbed
	*/

	// RVA: -1 Offset: -1
	public void SwitchToMacro(TMacro macro) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032D30 Offset: 0x1031330 VA: 0x181032D30
	|-GraphNest<object, object>.SwitchToMacro
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_beforeGraphChange(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1033140 Offset: 0x1031740 VA: 0x181033140
	|-GraphNest<object, object>.add_beforeGraphChange
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_beforeGraphChange(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10333F0 Offset: 0x10319F0 VA: 0x1810333F0
	|-GraphNest<object, object>.remove_beforeGraphChange
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_afterGraphChange(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10330A0 Offset: 0x10316A0 VA: 0x1810330A0
	|-GraphNest<object, object>.add_afterGraphChange
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_afterGraphChange(Action value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1033350 Offset: 0x1031950 VA: 0x181033350
	|-GraphNest<object, object>.remove_afterGraphChange
	*/

	// RVA: -1 Offset: -1
	private void BeforeGraphChange() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032AB0 Offset: 0x10310B0 VA: 0x181032AB0
	|-GraphNest<object, object>.BeforeGraphChange
	*/

	// RVA: -1 Offset: -1
	private void AfterGraphChange() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032A20 Offset: 0x1031020 VA: 0x181032A20
	|-GraphNest<object, object>.AfterGraphChange
	*/

	[IteratorStateMachine(typeof(GraphNest.<get_deserializationDependencies>d__41<TGraph, TMacro>))]
	// RVA: -1 Offset: -1
	public IEnumerable<ISerializationDependency> get_deserializationDependencies() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10331E0 Offset: 0x10317E0 VA: 0x1810331E0
	|-GraphNest<object, object>.get_deserializationDependencies
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerable<object> GetAotStubs(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1032B40 Offset: 0x1031140 VA: 0x181032B40
	|-GraphNest<object, object>.GetAotStubs
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool get_hasBackgroundEmbed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1033330 Offset: 0x1031930 VA: 0x181033330
	|-GraphNest<object, object>.get_hasBackgroundEmbed
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1033090 Offset: 0x1031690 VA: 0x181033090
	|-GraphNest<object, object>..ctor
	*/
}

// Namespace: Unity.VisualScripting
public abstract class GraphPointer // TypeDefIndex: 8960
{
	// Fields
	[CompilerGenerated]
	private IGraphRoot <root>k__BackingField; // 0x10
	[CompilerGenerated]
	private GameObject <gameObject>k__BackingField; // 0x18
	protected readonly List<IGraphParent> parentStack; // 0x20
	protected readonly List<IGraphParentElement> parentElementStack; // 0x28
	protected readonly List<IGraph> graphStack; // 0x30
	protected readonly List<IGraphData> dataStack; // 0x38
	protected readonly List<IGraphDebugData> debugDataStack; // 0x40
	[CompilerGenerated]
	private static Func<IGraphRoot, IGraphDebugData> <fetchRootDebugDataBinding>k__BackingField; // 0x0

	// Properties
	public IGraphRoot root { get; set; }
	public Object rootObject { get; }
	public IMachine machine { get; }
	public IMacro macro { get; }
	public MonoBehaviour component { get; }
	public GameObject gameObject { get; set; }
	public GameObject self { get; }
	public ScriptableObject scriptableObject { get; }
	public Nullable<Scene> scene { get; }
	public Object serializedObject { get; }
	public IEnumerable<Guid> parentElementGuids { get; }
	public int depth { get; }
	public bool isRoot { get; }
	public bool isChild { get; }
	public IGraphParent parent { get; }
	public IGraphParentElement parentElement { get; }
	public IGraph rootGraph { get; }
	public IGraph graph { get; }
	protected IGraphData _data { get; set; }
	public IGraphData data { get; }
	protected IGraphData _parentData { get; }
	public bool hasData { get; }
	public static Func<IGraphRoot, IGraphDebugData> fetchRootDebugDataBinding { get; set; }
	public bool hasDebugData { get; }
	protected IGraphDebugData _debugData { get; set; }
	public IGraphDebugData debugData { get; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x21FE800 Offset: 0x21FCE00 VA: 0x1821FE800
	protected static bool IsValidRoot(IGraphRoot root) { }

	// RVA: 0x21FE750 Offset: 0x21FCD50 VA: 0x1821FE750
	protected static bool IsValidRoot(Object rootObject) { }

	// RVA: 0x21FF050 Offset: 0x21FD650 VA: 0x1821FF050
	internal void .ctor() { }

	// RVA: 0x21FDD80 Offset: 0x21FC380 VA: 0x1821FDD80
	protected void Initialize(IGraphRoot root) { }

	// RVA: 0x21FE2B0 Offset: 0x21FC8B0 VA: 0x1821FE2B0
	protected void Initialize(IGraphRoot root, IEnumerable<IGraphParentElement> parentElements, bool ensureValid) { }

	// RVA: 0x21FDAB0 Offset: 0x21FC0B0 VA: 0x1821FDAB0
	protected void Initialize(Object rootObject, IEnumerable<Guid> parentElementGuids, bool ensureValid) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract GraphReference AsReference();

	// RVA: 0x21FC560 Offset: 0x21FAB60 VA: 0x1821FC560 Slot: 5
	public virtual void CopyFrom(GraphPointer other) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public IGraphRoot get_root() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	protected void set_root(IGraphRoot value) { }

	// RVA: 0x21FFF40 Offset: 0x21FE540 VA: 0x1821FFF40
	public Object get_rootObject() { }

	// RVA: 0x21FFC10 Offset: 0x21FE210 VA: 0x1821FFC10
	public IMachine get_machine() { }

	// RVA: 0x21FFC50 Offset: 0x21FE250 VA: 0x1821FFC50
	public IMacro get_macro() { }

	// RVA: 0x21FF300 Offset: 0x21FD900 VA: 0x1821FF300
	public MonoBehaviour get_component() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public GameObject get_gameObject() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_gameObject(GameObject value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public GameObject get_self() { }

	// RVA: 0x22000A0 Offset: 0x21FE6A0 VA: 0x1822000A0
	public ScriptableObject get_scriptableObject() { }

	// RVA: 0x21FFFD0 Offset: 0x21FE5D0 VA: 0x1821FFFD0
	public Nullable<Scene> get_scene() { }

	// RVA: 0x2200130 Offset: 0x21FE730 VA: 0x182200130
	public Object get_serializedObject() { }

	// RVA: 0x21FFC90 Offset: 0x21FE290 VA: 0x1821FFC90
	public IEnumerable<Guid> get_parentElementGuids() { }

	// RVA: 0x21FF590 Offset: 0x21FDB90 VA: 0x1821FF590
	public int get_depth() { }

	// RVA: 0x21FF780 Offset: 0x21FDD80 VA: 0x1821FF780
	public bool get_isRoot() { }

	// RVA: 0x21FF730 Offset: 0x21FDD30 VA: 0x1821FF730
	public bool get_isChild() { }

	// RVA: 0x21FD1D0 Offset: 0x21FB7D0 VA: 0x1821FD1D0
	public void EnsureDepthValid(int depth) { }

	// RVA: 0x21FCFB0 Offset: 0x21FB5B0 VA: 0x1821FCFB0
	public void EnsureChild() { }

	// RVA: -1 Offset: -1
	public bool IsWithin<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7050B0 Offset: 0x7036B0 VA: 0x1807050B0
	|-GraphPointer.IsWithin<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void EnsureWithin<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7044D0 Offset: 0x702AD0 VA: 0x1807044D0
	|-GraphPointer.EnsureWithin<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21FFE90 Offset: 0x21FE490 VA: 0x1821FFE90
	public IGraphParent get_parent() { }

	// RVA: -1 Offset: -1
	public T GetParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x704FE0 Offset: 0x7035E0 VA: 0x180704FE0
	|-GraphPointer.GetParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21FFDB0 Offset: 0x21FE3B0 VA: 0x1821FFDB0
	public IGraphParentElement get_parentElement() { }

	// RVA: 0x21FFEF0 Offset: 0x21FE4F0 VA: 0x1821FFEF0
	public IGraph get_rootGraph() { }

	// RVA: 0x21FF610 Offset: 0x21FDC10 VA: 0x1821FF610
	public IGraph get_graph() { }

	// RVA: 0x21FF1E0 Offset: 0x21FD7E0 VA: 0x1821FF1E0
	protected IGraphData get__data() { }

	// RVA: 0x2200250 Offset: 0x21FE850 VA: 0x182200250
	protected void set__data(IGraphData value) { }

	// RVA: 0x21FF390 Offset: 0x21FD990 VA: 0x1821FF390
	public IGraphData get_data() { }

	// RVA: 0x21FF2A0 Offset: 0x21FD8A0 VA: 0x1821FF2A0
	protected IGraphData get__parentData() { }

	// RVA: 0x21FF670 Offset: 0x21FDC70 VA: 0x1821FF670
	public bool get_hasData() { }

	// RVA: 0x21FD050 Offset: 0x21FB650 VA: 0x1821FD050
	public void EnsureDataAvailable() { }

	// RVA: -1 Offset: -1
	public T GetGraphData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x704D00 Offset: 0x703300 VA: 0x180704D00
	|-GraphPointer.GetGraphData<object>
	|
	|-RVA: 0x704B70 Offset: 0x703170 VA: 0x180704B70
	|-GraphPointer.GetGraphData<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetElementData<T>(IGraphElementWithData element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7045A0 Offset: 0x702BA0 VA: 0x1807045A0
	|-GraphPointer.GetElementData<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: 0x21FF5D0 Offset: 0x21FDBD0 VA: 0x1821FF5D0
	public static Func<IGraphRoot, IGraphDebugData> get_fetchRootDebugDataBinding() { }

	[CompilerGenerated]
	// RVA: 0x2200330 Offset: 0x21FE930 VA: 0x182200330
	public static void set_fetchRootDebugDataBinding(Func<IGraphRoot, IGraphDebugData> value) { }

	// RVA: 0x21FF6D0 Offset: 0x21FDCD0 VA: 0x1821FF6D0
	public bool get_hasDebugData() { }

	// RVA: 0x21FD110 Offset: 0x21FB710 VA: 0x1821FD110
	public void EnsureDebugDataAvailable() { }

	// RVA: 0x21FF240 Offset: 0x21FD840 VA: 0x1821FF240
	protected IGraphDebugData get__debugData() { }

	// RVA: 0x22002C0 Offset: 0x21FE8C0 VA: 0x1822002C0
	protected void set__debugData(IGraphDebugData value) { }

	// RVA: 0x21FF490 Offset: 0x21FDA90 VA: 0x1821FF490
	public IGraphDebugData get_debugData() { }

	// RVA: -1 Offset: -1
	public T GetGraphDebugData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x704E50 Offset: 0x703450 VA: 0x180704E50
	|-GraphPointer.GetGraphDebugData<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetElementDebugData<T>(IGraphElementWithDebugData element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7049E0 Offset: 0x702FE0 VA: 0x1807049E0
	|-GraphPointer.GetElementDebugData<object>
	|
	|-RVA: 0x704820 Offset: 0x702E20 VA: 0x180704820
	|-GraphPointer.GetElementDebugData<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21FEE70 Offset: 0x21FD470 VA: 0x1821FEE70
	protected bool TryEnterParentElement(Guid parentElementGuid, out string error, Nullable<int> maxRecursionDepth) { }

	// RVA: 0x21FEA60 Offset: 0x21FD060 VA: 0x1821FEA60
	protected bool TryEnterParentElement(IGraphParentElement parentElement, out string error, Nullable<int> maxRecursionDepth, bool skipContainsCheck = False) { }

	// RVA: 0x21FD3B0 Offset: 0x21FB9B0 VA: 0x1821FD3B0
	protected void EnterParentElement(IGraphParentElement parentElement) { }

	// RVA: 0x21FD440 Offset: 0x21FBA40 VA: 0x1821FD440
	protected void EnterParentElement(Guid parentElementGuid) { }

	// RVA: 0x21FD4D0 Offset: 0x21FBAD0 VA: 0x1821FD4D0
	private void EnterValidParentElement(IGraphParentElement parentElement) { }

	// RVA: 0x21FD900 Offset: 0x21FBF00 VA: 0x1821FD900
	protected void ExitParentElement() { }

	// RVA: 0x21FF7D0 Offset: 0x21FDDD0 VA: 0x1821FF7D0
	public bool get_isValid() { }

	// RVA: 0x21FD340 Offset: 0x21FB940 VA: 0x1821FD340
	public void EnsureValid() { }

	// RVA: 0x21FE4E0 Offset: 0x21FCAE0 VA: 0x1821FE4E0
	public bool InstanceEquals(GraphPointer other) { }

	// RVA: 0x21FCE20 Offset: 0x21FB420 VA: 0x1821FCE20
	public bool DefinitionEquals(GraphPointer other) { }

	// RVA: 0x21FC330 Offset: 0x21FA930 VA: 0x1821FC330
	public int ComputeHashCode() { }

	// RVA: 0x21FE8C0 Offset: 0x21FCEC0 VA: 0x1821FE8C0 Slot: 3
	public override string ToString() { }
}

// Namespace: Unity.VisualScripting
public sealed class GraphPointerException : Exception // TypeDefIndex: 8961
{
	// Fields
	[CompilerGenerated]
	private readonly GraphPointer <pointer>k__BackingField; // 0x90

	// Properties
	public GraphPointer pointer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public GraphPointer get_pointer() { }

	// RVA: 0x21FC260 Offset: 0x21FA860 VA: 0x1821FC260
	public void .ctor(string message, GraphPointer pointer) { }
}

// Namespace: Unity.VisualScripting
public sealed class GraphReference : GraphPointer // TypeDefIndex: 8963
{
	// Fields
	[DoNotSerialize]
	private int hashCode; // 0x48
	private static readonly Dictionary<int, List<GraphReference>> internPool; // 0x0

	// Methods

	// RVA: 0x2201EE0 Offset: 0x22004E0 VA: 0x182201EE0
	private static void .cctor() { }

	// RVA: 0x2201FB0 Offset: 0x22005B0 VA: 0x182201FB0
	private void .ctor() { }

	// RVA: 0x2201990 Offset: 0x21FFF90 VA: 0x182201990
	public static GraphReference New(IGraphRoot root, bool ensureValid) { }

	// RVA: 0x2201780 Offset: 0x21FFD80 VA: 0x182201780
	public static GraphReference New(IGraphRoot root, IEnumerable<IGraphParentElement> parentElements, bool ensureValid) { }

	// RVA: 0x2201850 Offset: 0x21FFE50 VA: 0x182201850
	public static GraphReference New(Object rootObject, IEnumerable<Guid> parentElementGuids, bool ensureValid) { }

	// RVA: 0x2201A30 Offset: 0x2200030 VA: 0x182201A30
	private static GraphReference New(GraphPointer model) { }

	// RVA: 0x22004F0 Offset: 0x21FEAF0 VA: 0x1822004F0 Slot: 5
	public override void CopyFrom(GraphPointer other) { }

	// RVA: 0x22004A0 Offset: 0x21FEAA0 VA: 0x1822004A0
	public GraphReference Clone() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 4
	public override GraphReference AsReference() { }

	// RVA: 0x2201ED0 Offset: 0x22004D0 VA: 0x182201ED0
	public GraphStack ToStackPooled() { }

	// RVA: 0x2200570 Offset: 0x21FEB70 VA: 0x182200570
	public void CreateGraphData() { }

	// RVA: 0x2200B30 Offset: 0x21FF130 VA: 0x182200B30
	public void FreeGraphData() { }

	// RVA: 0x2200880 Offset: 0x21FEE80 VA: 0x182200880 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2201470 Offset: 0x21FFA70 VA: 0x182201470
	private void Hash() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14152B0 Offset: 0x14138B0 VA: 0x1814152B0
	public static bool op_Equality(GraphReference x, GraphReference y) { }

	// RVA: 0x2201FC0 Offset: 0x22005C0 VA: 0x182201FC0
	public static bool op_Inequality(GraphReference x, GraphReference y) { }

	// RVA: 0x2201AB0 Offset: 0x22000B0 VA: 0x182201AB0
	public GraphReference ParentReference(bool ensureValid) { }

	// RVA: 0x2200390 Offset: 0x21FE990 VA: 0x182200390
	public GraphReference ChildReference(IGraphParentElement parentElement, bool ensureValid, Nullable<int> maxRecursionDepth) { }

	// RVA: 0x2201BC0 Offset: 0x22001C0 VA: 0x182201BC0
	public GraphReference Revalidate(bool ensureValid) { }

	[IteratorStateMachine(typeof(GraphReference.<GetBreadcrumbs>d__21))]
	// RVA: 0x22013F0 Offset: 0x21FF9F0 VA: 0x1822013F0
	public IEnumerable<GraphReference> GetBreadcrumbs() { }

	// RVA: 0x2201490 Offset: 0x21FFA90 VA: 0x182201490
	public static GraphReference Intern(GraphPointer pointer) { }

	// RVA: 0x2200DF0 Offset: 0x21FF3F0 VA: 0x182200DF0
	public static void FreeInvalidInterns() { }
}

// Namespace: Unity.VisualScripting
[Extension]
public static class GraphsExceptionUtility // TypeDefIndex: 8964
{
	// Fields
	private const string handledKey = "Bolt.Core.Handled";

	// Methods

	[Extension]
	// RVA: 0x2203910 Offset: 0x2201F10 VA: 0x182203910
	public static Exception GetException(IGraphElementWithDebugData element, GraphPointer pointer) { }

	[Extension]
	// RVA: 0x2204030 Offset: 0x2202630 VA: 0x182204030
	public static void SetException(IGraphElementWithDebugData element, GraphPointer pointer, Exception ex) { }

	[Extension]
	// RVA: 0x2203A50 Offset: 0x2202050 VA: 0x182203A50
	public static void HandleException(IGraphElementWithDebugData element, GraphPointer pointer, Exception ex) { }

	[Extension]
	// RVA: 0x2203D70 Offset: 0x2202370 VA: 0x182203D70
	private static bool HandledIn(Exception ex, GraphReference reference) { }
}

// Namespace: Unity.VisualScripting
public enum GraphSource // TypeDefIndex: 8965
{
	// Fields
	public int value__; // 0x0
	public const GraphSource Embed = 0;
	[InspectorName("Graph")]
	public const GraphSource Macro = 1;
}

// Namespace: Unity.VisualScripting
public sealed class GraphStack : GraphPointer, IPoolable, IDisposable // TypeDefIndex: 8967
{
	// Methods

	// RVA: 0x2201FB0 Offset: 0x22005B0 VA: 0x182201FB0
	private void .ctor() { }

	// RVA: 0x2202120 Offset: 0x2200720 VA: 0x182202120
	private void InitializeNoAlloc(IGraphRoot root, List<IGraphParentElement> parentElements, bool ensureValid) { }

	// RVA: 0x2202320 Offset: 0x2200920 VA: 0x182202320
	internal static GraphStack New(IGraphRoot root, List<IGraphParentElement> parentElements) { }

	// RVA: 0x2202490 Offset: 0x2200A90 VA: 0x182202490
	internal static GraphStack New(GraphPointer model) { }

	// RVA: 0x2201ED0 Offset: 0x22004D0 VA: 0x182201ED0
	public GraphStack Clone() { }

	// RVA: 0x22020B0 Offset: 0x22006B0 VA: 0x1822020B0 Slot: 8
	public void Dispose() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	private void Unity.VisualScripting.IPoolable.New() { }

	// RVA: 0x2202650 Offset: 0x2200C50 VA: 0x182202650 Slot: 7
	private void Unity.VisualScripting.IPoolable.Free() { }

	// RVA: 0x2202060 Offset: 0x2200660 VA: 0x182202060 Slot: 4
	public override GraphReference AsReference() { }

	// RVA: 0x2202060 Offset: 0x2200660 VA: 0x182202060
	public GraphReference ToReference() { }

	// RVA: 0x21FD3B0 Offset: 0x21FB9B0 VA: 0x1821FD3B0
	public void EnterParentElement(IGraphParentElement parentElement) { }

	// RVA: 0x2202620 Offset: 0x2200C20 VA: 0x182202620
	public bool TryEnterParentElement(IGraphParentElement parentElement) { }

	// RVA: 0x22025F0 Offset: 0x2200BF0 VA: 0x1822025F0
	public bool TryEnterParentElementUnsafe(IGraphParentElement parentElement) { }

	// RVA: 0x2202110 Offset: 0x2200710 VA: 0x182202110
	public void ExitParentElement() { }
}

// Namespace: Unity.VisualScripting
public interface IGraph : IDisposable, IPrewarmable, IAotStubbable, ISerializationDepender, ISerializationCallbackReceiver // TypeDefIndex: 8968
{
	// Properties
	public abstract Vector2 pan { get; set; }
	public abstract float zoom { get; set; }
	public abstract MergedGraphElementCollection elements { get; }
	public abstract string title { get; }
	public abstract string summary { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector2 get_pan();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_pan(Vector2 value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_zoom();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_zoom(float value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MergedGraphElementCollection get_elements();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_title();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_summary();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IGraphData CreateData();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IGraphDebugData CreateDebugData();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Instantiate(GraphReference instance);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Uninstantiate(GraphReference instance);
}

// Namespace: Unity.VisualScripting
public interface IGraphData // TypeDefIndex: 8969
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetElementData(IGraphElementWithData element, out IGraphElementData data);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TryGetChildGraphData(IGraphParentElement element, out IGraphData data);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IGraphElementData CreateElementData(IGraphElementWithData element);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void FreeElementData(IGraphElementWithData element);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IGraphData CreateChildGraphData(IGraphParentElement element);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void FreeChildGraphData(IGraphParentElement element);
}

// Namespace: Unity.VisualScripting
public interface IGraphDebugData // TypeDefIndex: 8970
{
	// Properties
	public abstract IEnumerable<IGraphElementDebugData> elementsData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IGraphElementDebugData GetOrCreateElementData(IGraphElementWithDebugData element);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IGraphDebugData GetOrCreateChildGraphData(IGraphParentElement element);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<IGraphElementDebugData> get_elementsData();
}

// Namespace: Unity.VisualScripting
public interface IGraphElement : IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable // TypeDefIndex: 8971
{
	// Properties
	public abstract IGraph graph { get; set; }
	public abstract int dependencyOrder { get; }
	public abstract Guid guid { get; set; }
	public abstract IEnumerable<ISerializationDependency> deserializationDependencies { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IGraph get_graph();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_graph(IGraph value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool HandleDependencies();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_dependencyOrder();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_guid();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_guid(Guid value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Instantiate(GraphReference instance);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Uninstantiate(GraphReference instance);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IEnumerable<ISerializationDependency> get_deserializationDependencies();
}

// Namespace: Unity.VisualScripting
public interface IGraphElementCollection<T> : IKeyedCollection<Guid, T>, ICollection<T>, IEnumerable<T>, IEnumerable, INotifyCollectionChanged<T> // TypeDefIndex: 8972
{}

// Namespace: Unity.VisualScripting
public interface IGraphElementData // TypeDefIndex: 8973
{}

// Namespace: Unity.VisualScripting
public interface IGraphElementDebugData // TypeDefIndex: 8974
{
	// Properties
	public abstract Exception runtimeException { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Exception get_runtimeException();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_runtimeException(Exception value);
}

// Namespace: Unity.VisualScripting
public interface IGraphElementWithData : IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable // TypeDefIndex: 8975
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IGraphElementData CreateData();
}

// Namespace: Unity.VisualScripting
public interface IGraphElementWithDebugData : IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable // TypeDefIndex: 8976
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IGraphElementDebugData CreateDebugData();
}

// Namespace: Unity.VisualScripting
public interface IGraphItem // TypeDefIndex: 8977
{
	// Properties
	public abstract IGraph graph { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IGraph get_graph();
}

// Namespace: Unity.VisualScripting
public interface IGraphNest : IAotStubbable // TypeDefIndex: 8978
{
	// Properties
	public abstract IGraphNester nester { get; set; }
	public abstract GraphSource source { get; set; }
	public abstract IGraph embed { get; set; }
	public abstract IMacro macro { get; set; }
	public abstract IGraph graph { get; }
	public abstract Type graphType { get; }
	public abstract Type macroType { get; }
	public abstract bool hasBackgroundEmbed { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IGraphNester get_nester();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_nester(IGraphNester value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract GraphSource get_source();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_source(GraphSource value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IGraph get_embed();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_embed(IGraph value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMacro get_macro();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_macro(IMacro value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IGraph get_graph();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_graphType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Type get_macroType();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_hasBackgroundEmbed();
}

// Namespace: Unity.VisualScripting
public interface IGraphNester : IGraphParent // TypeDefIndex: 8979
{
	// Properties
	public abstract IGraphNest nest { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IGraphNest get_nest();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void InstantiateNest();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UninstantiateNest();
}

// Namespace: Unity.VisualScripting
public interface IGraphNesterElement : IGraphParentElement, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable, IGraphParent, IGraphNester // TypeDefIndex: 8980
{}

// Namespace: Unity.VisualScripting
public interface IGraphParent // TypeDefIndex: 8981
{
	// Properties
	public abstract IGraph childGraph { get; }
	public abstract bool isSerializationRoot { get; }
	public abstract Object serializedObject { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IGraph get_childGraph();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_isSerializationRoot();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Object get_serializedObject();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IGraph DefaultGraph();
}

// Namespace: Unity.VisualScripting
public interface IGraphParentElement : IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable, IGraphParent // TypeDefIndex: 8982
{}

// Namespace: Unity.VisualScripting
public interface IGraphRoot : IGraphParent // TypeDefIndex: 8983
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GraphPointer GetReference();
}

// Namespace: Unity.VisualScripting
public sealed class MergedGraphElementCollection : MergedKeyedCollection<Guid, IGraphElement>, INotifyCollectionChanged<IGraphElement> // TypeDefIndex: 8984
{
	// Fields
	[CompilerGenerated]
	private Action<IGraphElement> ItemAdded; // 0x20
	[CompilerGenerated]
	private Action<IGraphElement> ItemRemoved; // 0x28
	[CompilerGenerated]
	private Action CollectionChanged; // 0x30

	// Methods

	[CompilerGenerated]
	// RVA: 0x220ACD0 Offset: 0x22092D0 VA: 0x18220ACD0 Slot: 17
	public void add_ItemAdded(Action<IGraphElement> value) { }

	[CompilerGenerated]
	// RVA: 0x220AED0 Offset: 0x22094D0 VA: 0x18220AED0 Slot: 18
	public void remove_ItemAdded(Action<IGraphElement> value) { }

	[CompilerGenerated]
	// RVA: 0x220AD80 Offset: 0x2209380 VA: 0x18220AD80 Slot: 19
	public void add_ItemRemoved(Action<IGraphElement> value) { }

	[CompilerGenerated]
	// RVA: 0x220AF80 Offset: 0x2209580 VA: 0x18220AF80 Slot: 20
	public void remove_ItemRemoved(Action<IGraphElement> value) { }

	[CompilerGenerated]
	// RVA: 0x220AC30 Offset: 0x2209230 VA: 0x18220AC30 Slot: 21
	public void add_CollectionChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x220AE30 Offset: 0x2209430 VA: 0x18220AE30 Slot: 22
	public void remove_CollectionChanged(Action value) { }

	// RVA: -1 Offset: -1 Slot: 15
	public override void Include<TSubItem>(IKeyedCollection<Guid, TSubItem> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x732210 Offset: 0x730810 VA: 0x180732210
	|-MergedGraphElementCollection.Include<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x220ABF0 Offset: 0x22091F0 VA: 0x18220ABF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <Include>b__9_0<TSubItem>(TSubItem element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x732430 Offset: 0x730A30 VA: 0x180732430
	|-MergedGraphElementCollection.<Include>b__9_0<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <Include>b__9_1<TSubItem>(TSubItem element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7324F0 Offset: 0x730AF0 VA: 0x1807324F0
	|-MergedGraphElementCollection.<Include>b__9_1<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <Include>b__9_2<TSubItem>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7325B0 Offset: 0x730BB0 VA: 0x1807325B0
	|-MergedGraphElementCollection.<Include>b__9_2<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.VisualScripting
[SerializationVersion("A", new[] {  })]
public sealed class GraphGroup : GraphElement<IGraph> // TypeDefIndex: 8985
{
	// Fields
	[DoNotSerialize]
	public static readonly Color defaultColor; // 0x0
	[CompilerGenerated]
	private Rect <position>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <label>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <comment>k__BackingField; // 0x40
	[CompilerGenerated]
	private Color <color>k__BackingField; // 0x48

	// Properties
	[Serialize]
	public Rect position { get; set; }
	[Serialize]
	public string label { get; set; }
	[Serialize]
	[InspectorTextArea(minLines = 1, maxLines = 10)]
	public string comment { get; set; }
	[Serialize]
	[Inspectable]
	public Color color { get; set; }

	// Methods

	// RVA: 0x21FAFD0 Offset: 0x21F95D0 VA: 0x1821FAFD0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1116670 Offset: 0x1114C70 VA: 0x181116670
	public Rect get_position() { }

	[CompilerGenerated]
	// RVA: 0x14DAB40 Offset: 0x14D9140 VA: 0x1814DAB40
	public void set_position(Rect value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_label() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_label(string value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_comment() { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_comment(string value) { }

	[CompilerGenerated]
	// RVA: 0x494CC0 Offset: 0x4932C0 VA: 0x180494CC0
	public Color get_color() { }

	[CompilerGenerated]
	// RVA: 0x494CD0 Offset: 0x4932D0 VA: 0x180494CD0
	public void set_color(Color value) { }

	// RVA: 0x21FAF90 Offset: 0x21F9590 VA: 0x1821FAF90
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public enum MouseButton // TypeDefIndex: 8986
{
	// Fields
	public int value__; // 0x0
	public const MouseButton Left = 0;
	public const MouseButton Right = 1;
	public const MouseButton Middle = 2;
}

// Namespace: Unity.VisualScripting
public enum PressState // TypeDefIndex: 8987
{
	// Fields
	public int value__; // 0x0
	public const PressState Hold = 0;
	public const PressState Down = 1;
	public const PressState Up = 2;
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("Visual Scripting/Listeners/Animator Message Listener")]
public sealed class AnimatorMessageListener : MonoBehaviour // TypeDefIndex: 8988
{
	// Methods

	// RVA: 0x21EBBF0 Offset: 0x21EA1F0 VA: 0x1821EBBF0
	private void OnAnimatorMove() { }

	// RVA: 0x21EBB60 Offset: 0x21EA160 VA: 0x1821EBB60
	private void OnAnimatorIK(int layerIndex) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Singleton(Name = "VisualScripting GlobalEventListener", Automatic = True, Persistent = True)]
[DisableAnnotation]
[AddComponentMenu("")]
[IncludeInSettings(False)]
[TypeIcon(typeof(MessageListener))]
public sealed class GlobalMessageListener : MonoBehaviour, ISingleton // TypeDefIndex: 8989
{
	// Methods

	// RVA: 0x21FAB80 Offset: 0x21F9180 VA: 0x1821FAB80
	private void OnGUI() { }

	// RVA: 0x21FA8A0 Offset: 0x21F8EA0 VA: 0x1821FA8A0
	private void OnApplicationFocus(bool focus) { }

	// RVA: 0x21FA9A0 Offset: 0x21F8FA0 VA: 0x1821FA9A0
	private void OnApplicationPause(bool paused) { }

	// RVA: 0x21FAAA0 Offset: 0x21F90A0 VA: 0x1821FAAA0
	private void OnApplicationQuit() { }

	// RVA: 0x21FAC60 Offset: 0x21F9260 VA: 0x1821FAC60
	public static void Require() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public interface IGraphEventListener // TypeDefIndex: 8990
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void StartListening(GraphStack stack);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StopListening(GraphStack stack);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsListening(GraphPointer pointer);
}

// Namespace: Unity.VisualScripting
[Extension]
public static class XGraphEventListener // TypeDefIndex: 8991
{
	// Methods

	[Extension]
	// RVA: 0x22124D0 Offset: 0x2210AD0 VA: 0x1822124D0
	public static void StartListening(IGraphEventListener listener, GraphReference reference) { }

	[Extension]
	// RVA: 0x22125B0 Offset: 0x2210BB0 VA: 0x1822125B0
	public static void StopListening(IGraphEventListener listener, GraphReference reference) { }

	// RVA: 0x2212210 Offset: 0x2210810 VA: 0x182212210
	public static bool IsHierarchyListening(GraphReference reference) { }
}

// Namespace: Unity.VisualScripting
public interface IGraphEventListenerData : IGraphData // TypeDefIndex: 8992
{
	// Properties
	public abstract bool isListening { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_isListening();
}

// Namespace: Unity.VisualScripting
[DisableAnnotation]
[AddComponentMenu("")]
[IncludeInSettings(False)]
public abstract class MessageListener : MonoBehaviour // TypeDefIndex: 8994
{
	// Fields
	private static Type[] _listenerTypes; // 0x0

	// Properties
	[Obsolete("listenerTypes is deprecated", False)]
	public static Type[] listenerTypes { get; }

	// Methods

	// RVA: 0x220B330 Offset: 0x2209930 VA: 0x18220B330
	public static Type[] get_listenerTypes() { }

	[Obsolete("Use the overload with a messageListenerType parameter instead", False)]
	// RVA: 0x220B030 Offset: 0x2209630 VA: 0x18220B030
	public static void AddTo(GameObject gameObject) { }

	// RVA: 0x220B2D0 Offset: 0x22098D0 VA: 0x18220B2D0
	public static void AddTo(Type messageListenerType, GameObject gameObject) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnBecameInvisibleMessageListener : MessageListener // TypeDefIndex: 8995
{
	// Methods

	// RVA: 0x2210030 Offset: 0x220E630 VA: 0x182210030
	private void OnBecameInvisible() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnBecameVisibleMessageListener : MessageListener // TypeDefIndex: 8996
{
	// Methods

	// RVA: 0x22100A0 Offset: 0x220E6A0 VA: 0x1822100A0
	private void OnBecameVisible() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnCollisionEnter2DMessageListener : MessageListener // TypeDefIndex: 8997
{
	// Methods

	// RVA: 0x2210350 Offset: 0x220E950 VA: 0x182210350
	private void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnCollisionEnterMessageListener : MessageListener // TypeDefIndex: 8998
{
	// Methods

	// RVA: 0x22103E0 Offset: 0x220E9E0 VA: 0x1822103E0
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnCollisionExit2DMessageListener : MessageListener // TypeDefIndex: 8999
{
	// Methods

	// RVA: 0x2210470 Offset: 0x220EA70 VA: 0x182210470
	private void OnCollisionExit2D(Collision2D collision) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnCollisionExitMessageListener : MessageListener // TypeDefIndex: 9000
{
	// Methods

	// RVA: 0x2210500 Offset: 0x220EB00 VA: 0x182210500
	private void OnCollisionExit(Collision collision) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnCollisionStay2DMessageListener : MessageListener // TypeDefIndex: 9001
{
	// Methods

	// RVA: 0x2210590 Offset: 0x220EB90 VA: 0x182210590
	private void OnCollisionStay2D(Collision2D collision) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnCollisionStayMessageListener : MessageListener // TypeDefIndex: 9002
{
	// Methods

	// RVA: 0x2210620 Offset: 0x220EC20 VA: 0x182210620
	private void OnCollisionStay(Collision collision) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnControllerColliderHitMessageListener : MessageListener // TypeDefIndex: 9003
{
	// Methods

	// RVA: 0x22106B0 Offset: 0x220ECB0 VA: 0x1822106B0
	private void OnControllerColliderHit(ControllerColliderHit hit) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnJointBreak2DMessageListener : MessageListener // TypeDefIndex: 9004
{
	// Methods

	// RVA: 0x2210D70 Offset: 0x220F370 VA: 0x182210D70
	private void OnJointBreak2D(Joint2D brokenJoint) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnJointBreakMessageListener : MessageListener // TypeDefIndex: 9005
{
	// Methods

	// RVA: 0x2210E00 Offset: 0x220F400 VA: 0x182210E00
	private void OnJointBreak(float breakForce) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnMouseDownMessageListener : MessageListener // TypeDefIndex: 9006
{
	// Methods

	// RVA: 0x2210E90 Offset: 0x220F490 VA: 0x182210E90
	private void OnMouseDown() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnMouseDragMessageListener : MessageListener // TypeDefIndex: 9007
{
	// Methods

	// RVA: 0x2210F00 Offset: 0x220F500 VA: 0x182210F00
	private void OnMouseDrag() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnMouseEnterMessageListener : MessageListener // TypeDefIndex: 9008
{
	// Methods

	// RVA: 0x2210F70 Offset: 0x220F570 VA: 0x182210F70
	private void OnMouseEnter() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnMouseExitMessageListener : MessageListener // TypeDefIndex: 9009
{
	// Methods

	// RVA: 0x2210FE0 Offset: 0x220F5E0 VA: 0x182210FE0
	private void OnMouseExit() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnMouseOverMessageListener : MessageListener // TypeDefIndex: 9010
{
	// Methods

	// RVA: 0x2211050 Offset: 0x220F650 VA: 0x182211050
	private void OnMouseOver() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnMouseUpAsButtonMessageListener : MessageListener // TypeDefIndex: 9011
{
	// Methods

	// RVA: 0x22110C0 Offset: 0x220F6C0 VA: 0x1822110C0
	private void OnMouseUpAsButton() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnMouseUpMessageListener : MessageListener // TypeDefIndex: 9012
{
	// Methods

	// RVA: 0x2211130 Offset: 0x220F730 VA: 0x182211130
	private void OnMouseUp() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnParticleCollisionMessageListener : MessageListener // TypeDefIndex: 9013
{
	// Methods

	// RVA: 0x2211230 Offset: 0x220F830 VA: 0x182211230
	private void OnParticleCollision(GameObject other) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnTransformChildrenChangedMessageListener : MessageListener // TypeDefIndex: 9014
{
	// Methods

	// RVA: 0x2211C80 Offset: 0x2210280 VA: 0x182211C80
	private void OnTransformChildrenChanged() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnTransformParentChangedMessageListener : MessageListener // TypeDefIndex: 9015
{
	// Methods

	// RVA: 0x2211CF0 Offset: 0x22102F0 VA: 0x182211CF0
	private void OnTransformParentChanged() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnTriggerEnter2DMessageListener : MessageListener // TypeDefIndex: 9016
{
	// Methods

	// RVA: 0x2211D60 Offset: 0x2210360 VA: 0x182211D60
	private void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnTriggerEnterMessageListener : MessageListener // TypeDefIndex: 9017
{
	// Methods

	// RVA: 0x2211DF0 Offset: 0x22103F0 VA: 0x182211DF0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnTriggerExit2DMessageListener : MessageListener // TypeDefIndex: 9018
{
	// Methods

	// RVA: 0x2211E80 Offset: 0x2210480 VA: 0x182211E80
	private void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnTriggerExitMessageListener : MessageListener // TypeDefIndex: 9019
{
	// Methods

	// RVA: 0x2211F10 Offset: 0x2210510 VA: 0x182211F10
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnTriggerStay2DMessageListener : MessageListener // TypeDefIndex: 9020
{
	// Methods

	// RVA: 0x2211FA0 Offset: 0x22105A0 VA: 0x182211FA0
	private void OnTriggerStay2D(Collider2D other) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnTriggerStayMessageListener : MessageListener // TypeDefIndex: 9021
{
	// Methods

	// RVA: 0x2212030 Offset: 0x2210630 VA: 0x182212030
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnButtonClickMessageListener : MessageListener // TypeDefIndex: 9022
{
	// Methods

	// RVA: 0x22101A0 Offset: 0x220E7A0 VA: 0x1822101A0
	private void Start() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2210250 Offset: 0x220E850 VA: 0x182210250
	private void <Start>b__0_0() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnDropdownValueChangedMessageListener : MessageListener // TypeDefIndex: 9023
{
	// Methods

	// RVA: 0x22108F0 Offset: 0x220EEF0 VA: 0x1822108F0
	private void Start() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x22109B0 Offset: 0x220EFB0 VA: 0x1822109B0
	private void <Start>b__0_0(int value) { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnInputFieldEndEditMessageListener : MessageListener // TypeDefIndex: 9024
{
	// Methods

	// RVA: 0x2210AD0 Offset: 0x220F0D0 VA: 0x182210AD0
	private void Start() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2210B90 Offset: 0x220F190 VA: 0x182210B90
	private void <Start>b__0_0(string value) { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnInputFieldValueChangedMessageListener : MessageListener // TypeDefIndex: 9025
{
	// Methods

	// RVA: 0x2210C20 Offset: 0x220F220 VA: 0x182210C20
	private void Start() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2210CE0 Offset: 0x220F2E0 VA: 0x182210CE0
	private void <Start>b__0_0(string value) { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnScrollbarValueChangedMessageListener : MessageListener // TypeDefIndex: 9026
{
	// Methods

	// RVA: 0x2211770 Offset: 0x220FD70 VA: 0x182211770
	private void Start() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2211830 Offset: 0x220FE30 VA: 0x182211830
	private void <Start>b__0_0(float value) { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnScrollRectValueChangedMessageListener : MessageListener // TypeDefIndex: 9027
{
	// Methods

	// RVA: 0x2211620 Offset: 0x220FC20 VA: 0x182211620
	private void Start() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x22116E0 Offset: 0x220FCE0 VA: 0x1822116E0
	private void <Start>b__0_0(Vector2 value) { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnSliderValueChangedMessageListener : MessageListener // TypeDefIndex: 9028
{
	// Methods

	// RVA: 0x2211950 Offset: 0x220FF50 VA: 0x182211950
	private void Start() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2211A10 Offset: 0x2210010 VA: 0x182211A10
	private void <Start>b__0_0(float value) { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnToggleValueChangedMessageListener : MessageListener // TypeDefIndex: 9029
{
	// Methods

	// RVA: 0x2211B30 Offset: 0x2210130 VA: 0x182211B30
	private void Start() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2211BF0 Offset: 0x22101F0 VA: 0x182211BF0
	private void <Start>b__0_0(bool value) { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnBeginDragMessageListener : MessageListener, IBeginDragHandler, IEventSystemHandler // TypeDefIndex: 9030
{
	// Methods

	// RVA: 0x2210110 Offset: 0x220E710 VA: 0x182210110 Slot: 4
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnCancelMessageListener : MessageListener, ICancelHandler, IEventSystemHandler // TypeDefIndex: 9031
{
	// Methods

	// RVA: 0x22102C0 Offset: 0x220E8C0 VA: 0x1822102C0 Slot: 4
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnDeselectMessageListener : MessageListener, IDeselectHandler, IEventSystemHandler // TypeDefIndex: 9032
{
	// Methods

	// RVA: 0x2210740 Offset: 0x220ED40 VA: 0x182210740 Slot: 4
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnDragMessageListener : MessageListener, IDragHandler, IEventSystemHandler // TypeDefIndex: 9033
{
	// Methods

	// RVA: 0x22107D0 Offset: 0x220EDD0 VA: 0x1822107D0 Slot: 4
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnDropMessageListener : MessageListener, IDropHandler, IEventSystemHandler // TypeDefIndex: 9034
{
	// Methods

	// RVA: 0x2210860 Offset: 0x220EE60 VA: 0x182210860 Slot: 4
	public void OnDrop(PointerEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnEndDragMessageListener : MessageListener, IEndDragHandler, IEventSystemHandler // TypeDefIndex: 9035
{
	// Methods

	// RVA: 0x2210A40 Offset: 0x220F040 VA: 0x182210A40 Slot: 4
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnMoveMessageListener : MessageListener, IMoveHandler, IEventSystemHandler // TypeDefIndex: 9036
{
	// Methods

	// RVA: 0x22111A0 Offset: 0x220F7A0 VA: 0x1822111A0 Slot: 4
	public void OnMove(AxisEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnPointerClickMessageListener : MessageListener, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 9037
{
	// Methods

	// RVA: 0x22112C0 Offset: 0x220F8C0 VA: 0x1822112C0 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnPointerDownMessageListener : MessageListener, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 9038
{
	// Methods

	// RVA: 0x2211350 Offset: 0x220F950 VA: 0x182211350 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnPointerEnterMessageListener : MessageListener, IPointerEnterHandler, IEventSystemHandler // TypeDefIndex: 9039
{
	// Methods

	// RVA: 0x22113E0 Offset: 0x220F9E0 VA: 0x1822113E0 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnPointerExitMessageListener : MessageListener, IPointerExitHandler, IEventSystemHandler // TypeDefIndex: 9040
{
	// Methods

	// RVA: 0x2211470 Offset: 0x220FA70 VA: 0x182211470 Slot: 4
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnPointerUpMessageListener : MessageListener, IPointerUpHandler, IEventSystemHandler // TypeDefIndex: 9041
{
	// Methods

	// RVA: 0x2211500 Offset: 0x220FB00 VA: 0x182211500 Slot: 4
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnScrollMessageListener : MessageListener, IScrollHandler, IEventSystemHandler // TypeDefIndex: 9042
{
	// Methods

	// RVA: 0x2211590 Offset: 0x220FB90 VA: 0x182211590 Slot: 4
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnSelectMessageListener : MessageListener, ISelectHandler, IEventSystemHandler // TypeDefIndex: 9043
{
	// Methods

	// RVA: 0x22118C0 Offset: 0x220FEC0 VA: 0x1822118C0 Slot: 4
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
public sealed class UnityOnSubmitMessageListener : MessageListener, ISubmitHandler, IEventSystemHandler // TypeDefIndex: 9044
{
	// Methods

	// RVA: 0x2211AA0 Offset: 0x22100A0 VA: 0x182211AA0 Slot: 4
	public void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("")]
[Obsolete("UnityMessageListener is deprecated and has been replaced by separate message listeners for each event, eg. UnityOnCollisionEnterMessageListener or UnityOnButtonClickMessageListener.")]
public sealed class UnityMessageListener : MessageListener, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, ISelectHandler, IDeselectHandler, ISubmitHandler, ICancelHandler, IMoveHandler // TypeDefIndex: 9045
{
	// Methods

	// RVA: 0x220FBC0 Offset: 0x220E1C0 VA: 0x18220FBC0
	private void Start() { }

	// RVA: 0x220E160 Offset: 0x220C760 VA: 0x18220E160
	public void AddGUIListeners() { }

	// RVA: 0x220F420 Offset: 0x220DA20 VA: 0x18220F420 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x220F4B0 Offset: 0x220DAB0 VA: 0x18220F4B0 Slot: 5
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x220F390 Offset: 0x220D990 VA: 0x18220F390 Slot: 6
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x220F540 Offset: 0x220DB40 VA: 0x18220F540 Slot: 7
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x220F300 Offset: 0x220D900 VA: 0x18220F300 Slot: 8
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x220E660 Offset: 0x220CC60 VA: 0x18220E660 Slot: 9
	public void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x220EC00 Offset: 0x220D200 VA: 0x18220EC00 Slot: 10
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0x220ED20 Offset: 0x220D320 VA: 0x18220ED20 Slot: 11
	public void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x220EC90 Offset: 0x220D290 VA: 0x18220EC90 Slot: 12
	public void OnDrop(PointerEventData eventData) { }

	// RVA: 0x220F5D0 Offset: 0x220DBD0 VA: 0x18220F5D0 Slot: 13
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x220F660 Offset: 0x220DC60 VA: 0x18220F660 Slot: 14
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x220EB70 Offset: 0x220D170 VA: 0x18220EB70 Slot: 15
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x220F6F0 Offset: 0x220DCF0 VA: 0x18220F6F0 Slot: 16
	public void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x220E6F0 Offset: 0x220CCF0 VA: 0x18220E6F0 Slot: 17
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x220F1E0 Offset: 0x220D7E0 VA: 0x18220F1E0 Slot: 18
	public void OnMove(AxisEventData eventData) { }

	// RVA: 0x220E580 Offset: 0x220CB80 VA: 0x18220E580
	private void OnBecameInvisible() { }

	// RVA: 0x220E5F0 Offset: 0x220CBF0 VA: 0x18220E5F0
	private void OnBecameVisible() { }

	// RVA: 0x220E810 Offset: 0x220CE10 VA: 0x18220E810
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x220E930 Offset: 0x220CF30 VA: 0x18220E930
	private void OnCollisionExit(Collision collision) { }

	// RVA: 0x220EA50 Offset: 0x220D050 VA: 0x18220EA50
	private void OnCollisionStay(Collision collision) { }

	// RVA: 0x220E780 Offset: 0x220CD80 VA: 0x18220E780
	private void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x220E8A0 Offset: 0x220CEA0 VA: 0x18220E8A0
	private void OnCollisionExit2D(Collision2D collision) { }

	// RVA: 0x220E9C0 Offset: 0x220CFC0 VA: 0x18220E9C0
	private void OnCollisionStay2D(Collision2D collision) { }

	// RVA: 0x220EAE0 Offset: 0x220D0E0 VA: 0x18220EAE0
	private void OnControllerColliderHit(ControllerColliderHit hit) { }

	// RVA: 0x220EE40 Offset: 0x220D440 VA: 0x18220EE40
	private void OnJointBreak(float breakForce) { }

	// RVA: 0x220EDB0 Offset: 0x220D3B0 VA: 0x18220EDB0
	private void OnJointBreak2D(Joint2D brokenJoint) { }

	// RVA: 0x220EED0 Offset: 0x220D4D0 VA: 0x18220EED0
	private void OnMouseDown() { }

	// RVA: 0x220EF40 Offset: 0x220D540 VA: 0x18220EF40
	private void OnMouseDrag() { }

	// RVA: 0x220EFB0 Offset: 0x220D5B0 VA: 0x18220EFB0
	private void OnMouseEnter() { }

	// RVA: 0x220F020 Offset: 0x220D620 VA: 0x18220F020
	private void OnMouseExit() { }

	// RVA: 0x220F090 Offset: 0x220D690 VA: 0x18220F090
	private void OnMouseOver() { }

	// RVA: 0x220F170 Offset: 0x220D770 VA: 0x18220F170
	private void OnMouseUp() { }

	// RVA: 0x220F100 Offset: 0x220D700 VA: 0x18220F100
	private void OnMouseUpAsButton() { }

	// RVA: 0x220F270 Offset: 0x220D870 VA: 0x18220F270
	private void OnParticleCollision(GameObject other) { }

	// RVA: 0x220F780 Offset: 0x220DD80 VA: 0x18220F780
	private void OnTransformChildrenChanged() { }

	// RVA: 0x220F7F0 Offset: 0x220DDF0 VA: 0x18220F7F0
	private void OnTransformParentChanged() { }

	// RVA: 0x220F8F0 Offset: 0x220DEF0 VA: 0x18220F8F0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x220FA10 Offset: 0x220E010 VA: 0x18220FA10
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x220FB30 Offset: 0x220E130 VA: 0x18220FB30
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x220F860 Offset: 0x220DE60 VA: 0x18220F860
	private void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x220F980 Offset: 0x220DF80 VA: 0x18220F980
	private void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x220FAA0 Offset: 0x220E0A0 VA: 0x18220FAA0
	private void OnTriggerStay2D(Collider2D other) { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x220FBD0 Offset: 0x220E1D0 VA: 0x18220FBD0
	private void <AddGUIListeners>b__1_0() { }

	[CompilerGenerated]
	// RVA: 0x220FC40 Offset: 0x220E240 VA: 0x18220FC40
	private void <AddGUIListeners>b__1_1(bool value) { }

	[CompilerGenerated]
	// RVA: 0x220FCD0 Offset: 0x220E2D0 VA: 0x18220FCD0
	private void <AddGUIListeners>b__1_2(float value) { }

	[CompilerGenerated]
	// RVA: 0x220FD60 Offset: 0x220E360 VA: 0x18220FD60
	private void <AddGUIListeners>b__1_3(float value) { }

	[CompilerGenerated]
	// RVA: 0x220FDF0 Offset: 0x220E3F0 VA: 0x18220FDF0
	private void <AddGUIListeners>b__1_4(int value) { }

	[CompilerGenerated]
	// RVA: 0x220FE80 Offset: 0x220E480 VA: 0x18220FE80
	private void <AddGUIListeners>b__1_5(string value) { }

	[CompilerGenerated]
	// RVA: 0x220FF10 Offset: 0x220E510 VA: 0x18220FF10
	private void <AddGUIListeners>b__1_6(string value) { }

	[CompilerGenerated]
	// RVA: 0x220FFA0 Offset: 0x220E5A0 VA: 0x18220FFA0
	private void <AddGUIListeners>b__1_7(Vector2 value) { }
}

// Namespace: Unity.VisualScripting
public interface IMachine : IGraphRoot, IGraphParent, IGraphNester, IAotStubbable // TypeDefIndex: 9046
{
	// Properties
	public abstract IGraphData graphData { get; set; }
	public abstract GameObject threadSafeGameObject { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IGraphData get_graphData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_graphData(IGraphData value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract GameObject get_threadSafeGameObject();
}

// Namespace: Unity.VisualScripting
public abstract class Machine<TGraph, TMacro> : LudiqBehaviour, IMachine, IGraphRoot, IGraphParent, IGraphNester, IAotStubbable // TypeDefIndex: 9047
{
	// Fields
	[CompilerGenerated]
	private GraphNest<TGraph, TMacro> <nest>k__BackingField; // 0x0
	[DoNotSerialize]
	private bool _alive; // 0x0
	[DoNotSerialize]
	private bool _enabled; // 0x0
	[DoNotSerialize]
	private GameObject threadSafeGameObject; // 0x0
	[DoNotSerialize]
	private bool isReferenceCached; // 0x0
	[DoNotSerialize]
	private GraphReference _reference; // 0x0
	[CompilerGenerated]
	private IGraphData <graphData>k__BackingField; // 0x0

	// Properties
	[Serialize]
	public GraphNest<TGraph, TMacro> nest { get; set; }
	[DoNotSerialize]
	private IGraphNest Unity.VisualScripting.IGraphNester.nest { get; }
	[DoNotSerialize]
	private GameObject Unity.VisualScripting.IMachine.threadSafeGameObject { get; }
	[DoNotSerialize]
	protected GraphReference reference { get; }
	[DoNotSerialize]
	protected bool hasGraph { get; }
	[DoNotSerialize]
	public TGraph graph { get; }
	[DoNotSerialize]
	public IGraphData graphData { get; set; }
	[DoNotSerialize]
	private bool Unity.VisualScripting.IGraphParent.isSerializationRoot { get; }
	[DoNotSerialize]
	private Object Unity.VisualScripting.IGraphParent.serializedObject { get; }
	[DoNotSerialize]
	private IGraph Unity.VisualScripting.IGraphParent.childGraph { get; }
	public bool isDescriptionValid { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A750 Offset: 0x1288D50 VA: 0x18128A750
	|-Machine<object, object>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public GraphNest<TGraph, TMacro> get_nest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-Machine<object, object>.get_nest
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_nest(GraphNest<TGraph, TMacro> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	|-Machine<object, object>.set_nest
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IGraphNest Unity.VisualScripting.IGraphNester.get_nest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-Machine<object, object>.Unity.VisualScripting.IGraphNester.get_nest
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private GameObject Unity.VisualScripting.IMachine.get_threadSafeGameObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	|-Machine<object, object>.Unity.VisualScripting.IMachine.get_threadSafeGameObject
	*/

	// RVA: -1 Offset: -1
	protected GraphReference get_reference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A110 Offset: 0x1288710 VA: 0x18128A110
	|-Machine<object, object>.get_reference
	*/

	// RVA: -1 Offset: -1
	protected bool get_hasGraph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A840 Offset: 0x1288E40 VA: 0x18128A840
	|-Machine<object, object>.get_hasGraph
	*/

	// RVA: -1 Offset: -1
	public TGraph get_graph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A810 Offset: 0x1288E10 VA: 0x18128A810
	|-Machine<object, object>.get_graph
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public IGraphData get_graphData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x384C80 Offset: 0x383280 VA: 0x180384C80
	|-Machine<object, object>.get_graphData
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 12
	public void set_graphData(IGraphData value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xADB010 Offset: 0xAD9610 VA: 0x180ADB010
	|-Machine<object, object>.set_graphData
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool Unity.VisualScripting.IGraphParent.get_isSerializationRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-Machine<object, object>.Unity.VisualScripting.IGraphParent.get_isSerializationRoot
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private Object Unity.VisualScripting.IGraphParent.get_serializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A660 Offset: 0x1288C60 VA: 0x18128A660
	|-Machine<object, object>.Unity.VisualScripting.IGraphParent.get_serializedObject
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private IGraph Unity.VisualScripting.IGraphParent.get_childGraph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A620 Offset: 0x1288C20 VA: 0x18128A620
	|-Machine<object, object>.Unity.VisualScripting.IGraphParent.get_childGraph
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public IEnumerable<object> GetAotStubs(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A0E0 Offset: 0x12886E0 VA: 0x18128A0E0
	|-Machine<object, object>.GetAotStubs
	*/

	// RVA: -1 Offset: -1
	public bool get_isDescriptionValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-Machine<object, object>.get_isDescriptionValid
	*/

	// RVA: -1 Offset: -1
	public void set_isDescriptionValid(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-Machine<object, object>.set_isDescriptionValid
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1289E40 Offset: 0x1288440 VA: 0x181289E40
	|-Machine<object, object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 24
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A380 Offset: 0x1288980 VA: 0x18128A380
	|-Machine<object, object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 25
	protected virtual void OnInstantiateWhileEnabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-Machine<object, object>.OnInstantiateWhileEnabled
	*/

	// RVA: -1 Offset: -1 Slot: 26
	protected virtual void OnUninstantiateWhileEnabled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-Machine<object, object>.OnUninstantiateWhileEnabled
	*/

	// RVA: -1 Offset: -1 Slot: 27
	protected virtual void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A370 Offset: 0x1288970 VA: 0x18128A370
	|-Machine<object, object>.OnDisable
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected virtual void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A2E0 Offset: 0x12888E0 VA: 0x18128A2E0
	|-Machine<object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected virtual void OnValidate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A390 Offset: 0x1288990 VA: 0x18128A390
	|-Machine<object, object>.OnValidate
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public GraphPointer GetReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A110 Offset: 0x1288710 VA: 0x18128A110
	|-Machine<object, object>.GetReference
	*/

	// RVA: -1 Offset: -1
	private void CacheReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A050 Offset: 0x1288650 VA: 0x18128A050
	|-Machine<object, object>.CacheReference
	*/

	// RVA: -1 Offset: -1
	private void ClearCachedReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A0C0 Offset: 0x12886C0 VA: 0x18128A0C0
	|-Machine<object, object>.ClearCachedReference
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public virtual void InstantiateNest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A170 Offset: 0x1288770 VA: 0x18128A170
	|-Machine<object, object>.InstantiateNest
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public virtual void UninstantiateNest() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A3C0 Offset: 0x12889C0 VA: 0x18128A3C0
	|-Machine<object, object>.UninstantiateNest
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual void TriggerAnimationEvent(AnimationEvent animationEvent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-Machine<object, object>.TriggerAnimationEvent
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public virtual void TriggerUnityEvent(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-Machine<object, object>.TriggerUnityEvent
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public abstract TGraph DefaultGraph();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Machine<object, object>.DefaultGraph
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private IGraph Unity.VisualScripting.IGraphParent.DefaultGraph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A600 Offset: 0x1288C00 VA: 0x18128A600
	|-Machine<object, object>.Unity.VisualScripting.IGraphParent.DefaultGraph
	*/
}

// Namespace: Unity.VisualScripting
public interface IMacro : IGraphRoot, IGraphParent, ISerializationDependency, ISerializationCallbackReceiver, IAotStubbable // TypeDefIndex: 9048
{
	// Properties
	public abstract IGraph graph { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IGraph get_graph();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_graph(IGraph value);
}

// Namespace: Unity.VisualScripting
[DisableAnnotation]
public abstract class Macro<TGraph> : MacroScriptableObject, IMacro, IGraphRoot, IGraphParent, ISerializationDependency, ISerializationCallbackReceiver, IAotStubbable // TypeDefIndex: 9049
{
	// Fields
	[SerializeAs("graph")]
	private TGraph _graph; // 0x0
	[DoNotSerialize]
	private GraphReference _reference; // 0x0
	[CompilerGenerated]
	private bool <Unity.VisualScripting.ISerializationDependency.IsDeserialized>k__BackingField; // 0x0

	// Properties
	[DoNotSerialize]
	public TGraph graph { get; set; }
	[DoNotSerialize]
	private IGraph Unity.VisualScripting.IMacro.graph { get; set; }
	[DoNotSerialize]
	private IGraph Unity.VisualScripting.IGraphParent.childGraph { get; }
	[DoNotSerialize]
	private bool Unity.VisualScripting.IGraphParent.isSerializationRoot { get; }
	[DoNotSerialize]
	private Object Unity.VisualScripting.IGraphParent.serializedObject { get; }
	[DoNotSerialize]
	protected GraphReference reference { get; }
	public bool isDescriptionValid { get; set; }
	private bool Unity.VisualScripting.ISerializationDependency.IsDeserialized { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public TGraph get_graph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-Macro<object>.get_graph
	*/

	// RVA: -1 Offset: -1
	public void set_graph(TGraph value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128ACC0 Offset: 0x12892C0 VA: 0x18128ACC0
	|-Macro<object>.set_graph
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IGraph Unity.VisualScripting.IMacro.get_graph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-Macro<object>.Unity.VisualScripting.IMacro.get_graph
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void Unity.VisualScripting.IMacro.set_graph(IGraph value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128ABB0 Offset: 0x12891B0 VA: 0x18128ABB0
	|-Macro<object>.Unity.VisualScripting.IMacro.set_graph
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private IGraph Unity.VisualScripting.IGraphParent.get_childGraph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-Macro<object>.Unity.VisualScripting.IGraphParent.get_childGraph
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public IEnumerable<object> GetAotStubs(HashSet<object> visited) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A8E0 Offset: 0x1288EE0 VA: 0x18128A8E0
	|-Macro<object>.GetAotStubs
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool Unity.VisualScripting.IGraphParent.get_isSerializationRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-Macro<object>.Unity.VisualScripting.IGraphParent.get_isSerializationRoot
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private Object Unity.VisualScripting.IGraphParent.get_serializedObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	|-Macro<object>.Unity.VisualScripting.IGraphParent.get_serializedObject
	*/

	// RVA: -1 Offset: -1
	protected GraphReference get_reference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A9A0 Offset: 0x1288FA0 VA: 0x18128A9A0
	|-Macro<object>.get_reference
	*/

	// RVA: -1 Offset: -1
	public bool get_isDescriptionValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-Macro<object>.get_isDescriptionValid
	*/

	// RVA: -1 Offset: -1
	public void set_isDescriptionValid(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-Macro<object>.set_isDescriptionValid
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected override void OnBeforeDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128AA90 Offset: 0x1289090 VA: 0x18128AA90
	|-Macro<object>.OnBeforeDeserialize
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void OnAfterDeserialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128AA30 Offset: 0x1289030 VA: 0x18128AA30
	|-Macro<object>.OnAfterDeserialize
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public abstract TGraph DefaultGraph();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Macro<object>.DefaultGraph
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private IGraph Unity.VisualScripting.IGraphParent.DefaultGraph() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128AB90 Offset: 0x1289190 VA: 0x18128AB90
	|-Macro<object>.Unity.VisualScripting.IGraphParent.DefaultGraph
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128AB40 Offset: 0x1289140 VA: 0x18128AB40
	|-Macro<object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 24
	protected virtual void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128AAF0 Offset: 0x12890F0 VA: 0x18128AAF0
	|-Macro<object>.OnDisable
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public GraphPointer GetReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128A9A0 Offset: 0x1288FA0 VA: 0x18128A9A0
	|-Macro<object>.GetReference
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 20
	private bool Unity.VisualScripting.ISerializationDependency.get_IsDeserialized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	|-Macro<object>.Unity.VisualScripting.ISerializationDependency.get_IsDeserialized
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 19
	private void Unity.VisualScripting.ISerializationDependency.set_IsDeserialized(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40E2F0 Offset: 0x40C8F0 VA: 0x18040E2F0
	|-Macro<object>.Unity.VisualScripting.ISerializationDependency.set_IsDeserialized
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128AC80 Offset: 0x1289280 VA: 0x18128AC80
	|-Macro<object>..ctor
	*/
}

// Namespace: Unity.VisualScripting
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class AotIncompatibleAttribute : Attribute // TypeDefIndex: 9050
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public interface IAotStubbable // TypeDefIndex: 9051
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<object> GetAotStubs(HashSet<object> visited);
}

// Namespace: Unity.VisualScripting
[Extension]
public static class PlatformUtility // TypeDefIndex: 9052
{
	// Fields
	public static readonly bool supportsJit; // 0x0

	// Methods

	// RVA: 0x220B560 Offset: 0x2209B60 VA: 0x18220B560
	private static void .cctor() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	private static bool CheckJitSupport() { }

	[Extension]
	// RVA: 0x220B520 Offset: 0x2209B20 VA: 0x18220B520
	public static bool IsEditor(RuntimePlatform platform) { }

	[Extension]
	// RVA: 0x220B540 Offset: 0x2209B40 VA: 0x18220B540
	public static bool IsStandalone(RuntimePlatform platform) { }
}

// Namespace: Unity.VisualScripting
public static class ArrayPool<T> // TypeDefIndex: 9053
{
	// Fields
	private static readonly object lock; // 0x0
	private static readonly Dictionary<int, Stack<T[]>> free; // 0x0
	private static readonly HashSet<T[]> busy; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T[] New(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104F930 Offset: 0x104DF30 VA: 0x18104F930
	|-ArrayPool<__Il2CppFullySharedGenericType>.New
	*/

	// RVA: -1 Offset: -1
	public static void Free(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104F320 Offset: 0x104D920 VA: 0x18104F320
	|-ArrayPool<__Il2CppFullySharedGenericType>.Free
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1050670 Offset: 0x104EC70 VA: 0x181050670
	|-ArrayPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.VisualScripting
[Extension]
public static class XArrayPool // TypeDefIndex: 9054
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] ToArrayPooled<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x813450 Offset: 0x811A50 VA: 0x180813450
	|-XArrayPool.ToArrayPooled<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Free<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8133E0 Offset: 0x8119E0 VA: 0x1808133E0
	|-XArrayPool.Free<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.VisualScripting
public static class DictionaryPool<TKey, TValue> // TypeDefIndex: 9055
{
	// Fields
	private static readonly object lock; // 0x0
	private static readonly Stack<Dictionary<TKey, TValue>> free; // 0x0
	private static readonly HashSet<Dictionary<TKey, TValue>> busy; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TValue> New(Dictionary<TKey, TValue> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3E1D0 Offset: 0xD3C7D0 VA: 0x180D3E1D0
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.New
	*/

	// RVA: -1 Offset: -1
	public static void Free(Dictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3DD40 Offset: 0xD3C340 VA: 0x180D3DD40
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Free
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3ED90 Offset: 0xD3D390 VA: 0x180D3ED90
	|-DictionaryPool<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.VisualScripting
public static class GenericPool<T> // TypeDefIndex: 9056
{
	// Fields
	private static readonly object lock; // 0x0
	private static readonly Stack<T> free; // 0x0
	private static readonly HashSet<T> busy; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T New(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102A750 Offset: 0x1028D50 VA: 0x18102A750
	|-GenericPool<object>.New
	*/

	// RVA: -1 Offset: -1
	public static void Free(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102A2B0 Offset: 0x10288B0 VA: 0x18102A2B0
	|-GenericPool<object>.Free
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x102AF70 Offset: 0x1029570 VA: 0x18102AF70
	|-GenericPool<object>..cctor
	*/
}

// Namespace: Unity.VisualScripting
public static class HashSetPool<T> // TypeDefIndex: 9057
{
	// Fields
	private static readonly object lock; // 0x0
	private static readonly Stack<HashSet<T>> free; // 0x0
	private static readonly HashSet<HashSet<T>> busy; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static HashSet<T> New() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10380F0 Offset: 0x10366F0 VA: 0x1810380F0
	|-HashSetPool<object>.New
	|
	|-RVA: 0x1037BC0 Offset: 0x10361C0 VA: 0x181037BC0
	|-HashSetPool<__Il2CppFullySharedGenericType>.New
	*/

	// RVA: -1 Offset: -1
	public static void Free(HashSet<T> hashSet) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10378B0 Offset: 0x1035EB0 VA: 0x1810378B0
	|-HashSetPool<object>.Free
	|
	|-RVA: 0x10374E0 Offset: 0x1035AE0 VA: 0x1810374E0
	|-HashSetPool<__Il2CppFullySharedGenericType>.Free
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10384F0 Offset: 0x1036AF0 VA: 0x1810384F0
	|-HashSetPool<object>..cctor
	|
	|-RVA: 0x1038780 Offset: 0x1036D80 VA: 0x181038780
	|-HashSetPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.VisualScripting
[Extension]
public static class XHashSetPool // TypeDefIndex: 9058
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static HashSet<T> ToHashSetPooled<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x814E70 Offset: 0x813470 VA: 0x180814E70
	|-XHashSetPool.ToHashSetPooled<object>
	|
	|-RVA: 0x814B40 Offset: 0x813140 VA: 0x180814B40
	|-XHashSetPool.ToHashSetPooled<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Free<T>(HashSet<T> hashSet) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x814AD0 Offset: 0x8130D0 VA: 0x180814AD0
	|-XHashSetPool.Free<object>
	|
	|-RVA: 0x8133E0 Offset: 0x8119E0 VA: 0x1808133E0
	|-XHashSetPool.Free<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.VisualScripting
public interface IPoolable // TypeDefIndex: 9059
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void New();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Free();
}

// Namespace: Unity.VisualScripting
public static class ListPool<T> // TypeDefIndex: 9060
{
	// Fields
	private static readonly object lock; // 0x0
	private static readonly Stack<List<T>> free; // 0x0
	private static readonly HashSet<List<T>> busy; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> New() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1121020 Offset: 0x111F620 VA: 0x181121020
	|-ListPool<int>.New
	|-ListPool<object>.New
	|
	|-RVA: 0x1037BC0 Offset: 0x10361C0 VA: 0x181037BC0
	|-ListPool<__Il2CppFullySharedGenericType>.New
	*/

	// RVA: -1 Offset: -1
	public static void Free(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1120CA0 Offset: 0x111F2A0 VA: 0x181120CA0
	|-ListPool<int>.Free
	|
	|-RVA: 0x1120910 Offset: 0x111EF10 VA: 0x181120910
	|-ListPool<object>.Free
	|
	|-RVA: 0x1120490 Offset: 0x111EA90 VA: 0x181120490
	|-ListPool<__Il2CppFullySharedGenericType>.Free
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11221D0 Offset: 0x11207D0 VA: 0x1811221D0
	|-ListPool<int>..cctor
	|
	|-RVA: 0x1122460 Offset: 0x1120A60 VA: 0x181122460
	|-ListPool<object>..cctor
	|
	|-RVA: 0x1121EF0 Offset: 0x11204F0 VA: 0x181121EF0
	|-ListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.VisualScripting
[Extension]
public static class XListPool // TypeDefIndex: 9061
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static List<T> ToListPooled<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x815180 Offset: 0x813780 VA: 0x180815180
	|-XListPool.ToListPooled<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void Free<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8150A0 Offset: 0x8136A0 VA: 0x1808150A0
	|-XListPool.Free<int>
	|
	|-RVA: 0x815110 Offset: 0x813710 VA: 0x180815110
	|-XListPool.Free<object>
	|
	|-RVA: 0x8133E0 Offset: 0x8119E0 VA: 0x1808133E0
	|-XListPool.Free<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.VisualScripting
public static class ManualPool<T> // TypeDefIndex: 9062
{
	// Fields
	private static readonly object lock; // 0x0
	private static readonly Stack<T> free; // 0x0
	private static readonly HashSet<T> busy; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static T New(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128B560 Offset: 0x1289B60 VA: 0x18128B560
	|-ManualPool<object>.New
	*/

	// RVA: -1 Offset: -1
	public static void Free(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128B210 Offset: 0x1289810 VA: 0x18128B210
	|-ManualPool<object>.Free
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x128B930 Offset: 0x1289F30 VA: 0x18128B930
	|-ManualPool<object>..cctor
	*/
}

// Namespace: Unity.VisualScripting
public class ProfiledSegment // TypeDefIndex: 9063
{
	// Fields
	[CompilerGenerated]
	private string <name>k__BackingField; // 0x10
	[CompilerGenerated]
	private Stopwatch <stopwatch>k__BackingField; // 0x18
	[CompilerGenerated]
	private long <calls>k__BackingField; // 0x20
	[CompilerGenerated]
	private ProfiledSegment <parent>k__BackingField; // 0x28
	[CompilerGenerated]
	private ProfiledSegmentCollection <children>k__BackingField; // 0x30

	// Properties
	public string name { get; set; }
	public Stopwatch stopwatch { get; set; }
	public long calls { get; set; }
	public ProfiledSegment parent { get; set; }
	public ProfiledSegmentCollection children { get; set; }

	// Methods

	// RVA: 0x220B5E0 Offset: 0x2209BE0 VA: 0x18220B5E0
	public void .ctor(ProfiledSegment parent, string name) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_name(string value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Stopwatch get_stopwatch() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_stopwatch(Stopwatch value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public long get_calls() { }

	[CompilerGenerated]
	// RVA: 0x163E100 Offset: 0x163C700 VA: 0x18163E100
	public void set_calls(long value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public ProfiledSegment get_parent() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	private void set_parent(ProfiledSegment value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public ProfiledSegmentCollection get_children() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_children(ProfiledSegmentCollection value) { }
}

// Namespace: Unity.VisualScripting
public class ProfiledSegmentCollection : KeyedCollection<string, ProfiledSegment> // TypeDefIndex: 9064
{
	// Methods

	// RVA: 0x3CFB00 Offset: 0x3CE100 VA: 0x1803CFB00 Slot: 39
	protected override string GetKeyForItem(ProfiledSegment item) { }

	// RVA: 0x220B5A0 Offset: 0x2209BA0 VA: 0x18220B5A0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public struct ProfilingScope : IDisposable // TypeDefIndex: 9065
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void .ctor(string name) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void Dispose() { }
}

// Namespace: Unity.VisualScripting
public static class ProfilingUtility // TypeDefIndex: 9066
{
	// Fields
	private static readonly object lock; // 0x0
	[CompilerGenerated]
	private static ProfiledSegment <rootSegment>k__BackingField; // 0x8
	[CompilerGenerated]
	private static ProfiledSegment <currentSegment>k__BackingField; // 0x10

	// Properties
	public static ProfiledSegment rootSegment { get; set; }
	public static ProfiledSegment currentSegment { get; set; }

	// Methods

	// RVA: 0x220BD80 Offset: 0x220A380 VA: 0x18220BD80
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x220BF40 Offset: 0x220A540 VA: 0x18220BF40
	public static ProfiledSegment get_rootSegment() { }

	[CompilerGenerated]
	// RVA: 0x220C000 Offset: 0x220A600 VA: 0x18220C000
	private static void set_rootSegment(ProfiledSegment value) { }

	[CompilerGenerated]
	// RVA: 0x220BEF0 Offset: 0x220A4F0 VA: 0x18220BEF0
	public static ProfiledSegment get_currentSegment() { }

	[CompilerGenerated]
	// RVA: 0x220BF90 Offset: 0x220A590 VA: 0x18220BF90
	public static void set_currentSegment(ProfiledSegment value) { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x220BA90 Offset: 0x220A090 VA: 0x18220BA90
	public static void Clear() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	public static ProfilingScope SampleBlock(string name) { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x220B6D0 Offset: 0x2209CD0 VA: 0x18220B6D0
	public static void BeginSample(string name) { }

	[Conditional("ENABLE_PROFILER")]
	// RVA: 0x220BBD0 Offset: 0x220A1D0 VA: 0x18220BBD0
	public static void EndSample() { }
}

// Namespace: Unity.VisualScripting
public enum ActionDirection // TypeDefIndex: 9067
{
	// Fields
	public int value__; // 0x0
	public const ActionDirection Any = 0;
	public const ActionDirection Get = 1;
	public const ActionDirection Set = 2;
}

// Namespace: Unity.VisualScripting
[Extension]
public static class AttributeUtility // TypeDefIndex: 9070
{
	// Fields
	private static readonly Dictionary<object, AttributeUtility.AttributeCache> optimizedCaches; // 0x0

	// Methods

	// RVA: 0x21EDAE0 Offset: 0x21EC0E0 VA: 0x1821EDAE0
	private static AttributeUtility.AttributeCache GetAttributeCache(MemberInfo element) { }

	// RVA: 0x21EDF40 Offset: 0x21EC540 VA: 0x1821EDF40
	private static AttributeUtility.AttributeCache GetAttributeCache(ParameterInfo element) { }

	// RVA: 0x21EDD10 Offset: 0x21EC310 VA: 0x1821EDD10
	private static AttributeUtility.AttributeCache GetAttributeCache(IAttributeProvider element) { }

	// RVA: 0x21ED750 Offset: 0x21EBD50 VA: 0x1821ED750
	public static void CacheAttributes(MemberInfo element) { }

	[Extension]
	// RVA: -1 Offset: -1
	internal static IEnumerable<T> GetAttributeOfEnumMember<T>(Enum enumVal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666920 Offset: 0x664F20 VA: 0x180666920
	|-AttributeUtility.GetAttributeOfEnumMember<object>
	*/

	[Extension]
	// RVA: 0x21EE960 Offset: 0x21ECF60 VA: 0x1821EE960
	public static bool HasAttribute(MemberInfo element, Type attributeType, bool inherit = True) { }

	[Extension]
	// RVA: 0x21EE170 Offset: 0x21EC770 VA: 0x1821EE170
	public static Attribute GetAttribute(MemberInfo element, Type attributeType, bool inherit = True) { }

	[Extension]
	// RVA: 0x21EE620 Offset: 0x21ECC20 VA: 0x1821EE620
	public static IEnumerable<Attribute> GetAttributes(MemberInfo element, Type attributeType, bool inherit = True) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static bool HasAttribute<TAttribute>(MemberInfo element, bool inherit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666E90 Offset: 0x665490 VA: 0x180666E90
	|-AttributeUtility.HasAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool inherit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666AA0 Offset: 0x6650A0 VA: 0x180666AA0
	|-AttributeUtility.GetAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TAttribute> GetAttributes<TAttribute>(MemberInfo element, bool inherit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666C50 Offset: 0x665250 VA: 0x180666C50
	|-AttributeUtility.GetAttributes<object>
	*/

	// RVA: 0x21ED7A0 Offset: 0x21EBDA0 VA: 0x1821ED7A0
	public static void CacheAttributes(ParameterInfo element) { }

	[Extension]
	// RVA: 0x21EEAF0 Offset: 0x21ED0F0 VA: 0x1821EEAF0
	public static bool HasAttribute(ParameterInfo element, Type attributeType, bool inherit = True) { }

	[Extension]
	// RVA: 0x21EE300 Offset: 0x21EC900 VA: 0x1821EE300
	public static Attribute GetAttribute(ParameterInfo element, Type attributeType, bool inherit = True) { }

	[Extension]
	// RVA: 0x21EE6B0 Offset: 0x21ECCB0 VA: 0x1821EE6B0
	public static IEnumerable<Attribute> GetAttributes(ParameterInfo element, Type attributeType, bool inherit = True) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static bool HasAttribute<TAttribute>(ParameterInfo element, bool inherit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666D70 Offset: 0x665370 VA: 0x180666D70
	|-AttributeUtility.HasAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TAttribute GetAttribute<TAttribute>(ParameterInfo element, bool inherit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666B30 Offset: 0x665130 VA: 0x180666B30
	|-AttributeUtility.GetAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TAttribute> GetAttributes<TAttribute>(ParameterInfo element, bool inherit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666BC0 Offset: 0x6651C0 VA: 0x180666BC0
	|-AttributeUtility.GetAttributes<object>
	*/

	// RVA: 0x21ED700 Offset: 0x21EBD00 VA: 0x1821ED700
	public static void CacheAttributes(IAttributeProvider element) { }

	[Extension]
	// RVA: 0x21EE7D0 Offset: 0x21ECDD0 VA: 0x1821EE7D0
	public static bool HasAttribute(IAttributeProvider element, Type attributeType, bool inherit = True) { }

	[Extension]
	// RVA: 0x21EE490 Offset: 0x21ECA90 VA: 0x1821EE490
	public static Attribute GetAttribute(IAttributeProvider element, Type attributeType, bool inherit = True) { }

	[Extension]
	// RVA: 0x21EE740 Offset: 0x21ECD40 VA: 0x1821EE740
	public static IEnumerable<Attribute> GetAttributes(IAttributeProvider element, Type attributeType, bool inherit = True) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static bool HasAttribute<TAttribute>(IAttributeProvider element, bool inherit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666E00 Offset: 0x665400 VA: 0x180666E00
	|-AttributeUtility.HasAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static TAttribute GetAttribute<TAttribute>(IAttributeProvider element, bool inherit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666A10 Offset: 0x665010 VA: 0x180666A10
	|-AttributeUtility.GetAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<TAttribute> GetAttributes<TAttribute>(IAttributeProvider element, bool inherit = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666CE0 Offset: 0x6652E0 VA: 0x180666CE0
	|-AttributeUtility.GetAttributes<object>
	*/

	// RVA: 0x21ED7F0 Offset: 0x21EBDF0 VA: 0x1821ED7F0
	public static bool CheckCondition(Type type, object target, string conditionMemberName, bool fallback) { }

	// RVA: -1 Offset: -1
	public static bool CheckCondition<T>(T target, string conditionMemberName, bool fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666720 Offset: 0x664D20 VA: 0x180666720
	|-AttributeUtility.CheckCondition<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21EEC80 Offset: 0x21ED280 VA: 0x1821EEC80
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
[Extension]
public static class ConversionUtility // TypeDefIndex: 9077
{
	// Fields
	private const BindingFlags UserDefinedBindingFlags = 24;
	private static readonly Dictionary<ConversionUtility.ConversionQuery, ConversionUtility.ConversionType> conversionTypesCache; // 0x0
	private static readonly Dictionary<ConversionUtility.ConversionQuery, MethodInfo[]> userConversionMethodsCache; // 0x8
	private static readonly Dictionary<Type, HashSet<Type>> implicitNumericConversions; // 0x10
	private static readonly Dictionary<Type, HashSet<Type>> explicitNumericConversions; // 0x18

	// Methods

	// RVA: 0x21F2D50 Offset: 0x21F1350 VA: 0x1821F2D50
	private static bool RespectsIdentity(Type source, Type destination) { }

	// RVA: 0x17B9E00 Offset: 0x17B8400 VA: 0x1817B9E00
	private static bool IsUpcast(Type source, Type destination) { }

	// RVA: 0x21F2CA0 Offset: 0x21F12A0 VA: 0x1821F2CA0
	private static bool IsDowncast(Type source, Type destination) { }

	// RVA: 0x21F19B0 Offset: 0x21EFFB0 VA: 0x1821F19B0
	private static bool ExpectsString(Type source, Type destination) { }

	// RVA: 0x21F27E0 Offset: 0x21F0DE0 VA: 0x1821F27E0
	public static bool HasImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x21F26D0 Offset: 0x21F0CD0 VA: 0x1821F26D0
	public static bool HasExplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x21F28F0 Offset: 0x21F0EF0 VA: 0x1821F28F0
	public static bool HasNumericConversion(Type source, Type destination) { }

	// RVA: 0x21F1A00 Offset: 0x21F0000 VA: 0x1821F1A00
	private static IEnumerable<MethodInfo> FindUserDefinedConversionMethods(ConversionUtility.ConversionQuery query) { }

	// RVA: 0x21F1F20 Offset: 0x21F0520 VA: 0x1821F1F20
	private static MethodInfo[] GetUserDefinedConversionMethods(Type source, Type destination) { }

	// RVA: 0x21F20E0 Offset: 0x21F06E0 VA: 0x1821F20E0
	private static ConversionUtility.ConversionType GetUserDefinedConversionType(Type source, Type destination) { }

	// RVA: 0x21F2460 Offset: 0x21F0A60 VA: 0x1821F2460
	private static bool HasEnumerableToArrayConversion(Type source, Type destination) { }

	// RVA: 0x21F2570 Offset: 0x21F0B70 VA: 0x1821F2570
	private static bool HasEnumerableToListConversion(Type source, Type destination) { }

	// RVA: 0x21F2980 Offset: 0x21F0F80 VA: 0x1821F2980
	private static bool HasUnityHierarchyConversion(Type source, Type destination) { }

	// RVA: 0x21F2CD0 Offset: 0x21F12D0 VA: 0x1821F2CD0
	private static bool IsValidConversion(ConversionUtility.ConversionType conversionType, bool guaranteed) { }

	// RVA: 0x21F09C0 Offset: 0x21EEFC0 VA: 0x1821F09C0
	public static bool CanConvert(object value, Type type, bool guaranteed) { }

	// RVA: 0x21F0930 Offset: 0x21EEF30 VA: 0x1821F0930
	public static bool CanConvert(Type source, Type destination, bool guaranteed) { }

	// RVA: 0x21F0AF0 Offset: 0x21EF0F0 VA: 0x1821F0AF0
	public static object Convert(object value, Type type) { }

	// RVA: -1 Offset: -1
	public static T Convert<T>(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC8A0 Offset: 0x6BAEA0 VA: 0x1806BC8A0
	|-ConversionUtility.Convert<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21F2D90 Offset: 0x21F1390 VA: 0x1821F2D90
	public static bool TryConvert(object value, Type type, out object result, bool guaranteed) { }

	// RVA: -1 Offset: -1
	public static bool TryConvert<T>(object value, out T result, bool guaranteed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BCA60 Offset: 0x6BB060 VA: 0x1806BCA60
	|-ConversionUtility.TryConvert<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x21F2BE0 Offset: 0x21F11E0 VA: 0x1821F2BE0
	public static bool IsConvertibleTo(Type source, Type destination, bool guaranteed) { }

	[Extension]
	// RVA: 0x21F2B20 Offset: 0x21F1120 VA: 0x1821F2B20
	public static bool IsConvertibleTo(object source, Type type, bool guaranteed) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static bool IsConvertibleTo<T>(object source, bool guaranteed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC9C0 Offset: 0x6BAFC0 VA: 0x1806BC9C0
	|-ConversionUtility.IsConvertibleTo<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x21F0A50 Offset: 0x21EF050 VA: 0x1821F0A50
	public static object ConvertTo(object source, Type type) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T ConvertTo<T>(object source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC8A0 Offset: 0x6BAEA0 VA: 0x1806BC8A0
	|-ConversionUtility.ConvertTo<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x21F1DC0 Offset: 0x21F03C0 VA: 0x1821F1DC0
	public static ConversionUtility.ConversionType GetRequiredConversion(Type source, Type destination) { }

	// RVA: 0x21F1080 Offset: 0x21EF680 VA: 0x1821F1080
	private static ConversionUtility.ConversionType DetermineConversionType(ConversionUtility.ConversionQuery query) { }

	// RVA: 0x21F1CF0 Offset: 0x21F02F0 VA: 0x1821F1CF0
	public static ConversionUtility.ConversionType GetRequiredConversion(object value, Type type) { }

	// RVA: 0x21F2CF0 Offset: 0x21F12F0 VA: 0x1821F2CF0
	private static object NumericConversion(object value, Type type) { }

	// RVA: 0x21F3120 Offset: 0x21F1720 VA: 0x1821F3120
	private static object UserDefinedConversion(ConversionUtility.ConversionType conversion, object value, Type type) { }

	// RVA: 0x21F15D0 Offset: 0x21EFBD0 VA: 0x1821F15D0
	private static object EnumerableToArrayConversion(object value, Type arrayType) { }

	// RVA: 0x21F1740 Offset: 0x21EFD40 VA: 0x1821F1740
	private static object EnumerableToListConversion(object value, Type listType) { }

	// RVA: 0x21F2E70 Offset: 0x21F1470 VA: 0x1821F2E70
	private static object UnityHierarchyConversion(object value, Type type) { }

	// RVA: 0x21F0B60 Offset: 0x21EF160 VA: 0x1821F0B60
	private static object Convert(object value, Type type, ConversionUtility.ConversionType conversionType) { }

	// RVA: 0x21F33E0 Offset: 0x21F19E0 VA: 0x1821F33E0
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class GenericClosingException : Exception // TypeDefIndex: 9078
{
	// Methods

	// RVA: 0x21FA840 Offset: 0x21F8E40 VA: 0x1821FA840
	public void .ctor(string message) { }

	// RVA: 0x21FA7B0 Offset: 0x21F8DB0 VA: 0x1821FA7B0
	public void .ctor(Type open, Type closed) { }
}

// Namespace: Unity.VisualScripting
public interface IAttributeProvider // TypeDefIndex: 9079
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Attribute[] GetCustomAttributes(bool inherit);
}

// Namespace: Unity.VisualScripting
public interface IPrewarmable // TypeDefIndex: 9080
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Prewarm();
}

// Namespace: Unity.VisualScripting
public struct LooseAssemblyName // TypeDefIndex: 9081
{
	// Fields
	public readonly string name; // 0x0

	// Methods

	// RVA: 0x2204BC0 Offset: 0x22031C0 VA: 0x182204BC0
	public void .ctor(string name) { }

	// RVA: 0x2204AF0 Offset: 0x22030F0 VA: 0x182204AF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2204B80 Offset: 0x2203180 VA: 0x182204B80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2204C30 Offset: 0x2203230 VA: 0x182204C30
	public static bool op_Equality(LooseAssemblyName a, LooseAssemblyName b) { }

	// RVA: 0x2204E00 Offset: 0x2203400 VA: 0x182204E00
	public static bool op_Inequality(LooseAssemblyName a, LooseAssemblyName b) { }

	// RVA: 0x2204D80 Offset: 0x2203380 VA: 0x182204D80
	public static LooseAssemblyName op_Implicit(string name) { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50
	public static string op_Implicit(LooseAssemblyName name) { }

	// RVA: 0x2204CF0 Offset: 0x22032F0 VA: 0x182204CF0
	public static LooseAssemblyName op_Explicit(AssemblyName strongAssemblyName) { }

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90 Slot: 3
	public override string ToString() { }
}

// Namespace: Unity.VisualScripting
[SerializationVersion("A", new[] {  })]
public sealed class Member : ISerializationCallbackReceiver // TypeDefIndex: 9084
{
	// Fields
	[SerializeAs("name")]
	private string _name; // 0x10
	[SerializeAs("parameterTypes")]
	private Type[] _parameterTypes; // 0x18
	[SerializeAs("targetType")]
	private Type _targetType; // 0x20
	[SerializeAs("targetTypeName")]
	private string _targetTypeName; // 0x28
	[DoNotSerialize]
	private Member.Source _source; // 0x30
	[DoNotSerialize]
	private FieldInfo _fieldInfo; // 0x38
	[DoNotSerialize]
	private PropertyInfo _propertyInfo; // 0x40
	[DoNotSerialize]
	private MethodInfo _methodInfo; // 0x48
	[DoNotSerialize]
	private ConstructorInfo _constructorInfo; // 0x50
	[DoNotSerialize]
	private bool _isExtension; // 0x58
	[DoNotSerialize]
	private bool _isInvokedAsExtension; // 0x59
	[DoNotSerialize]
	private IOptimizedAccessor fieldAccessor; // 0x60
	[DoNotSerialize]
	private IOptimizedAccessor propertyAccessor; // 0x68
	[DoNotSerialize]
	private IOptimizedInvoker methodInvoker; // 0x70
	[CompilerGenerated]
	private bool <isReflected>k__BackingField; // 0x78
	public const MemberTypes SupportedMemberTypes = 29;
	public const BindingFlags SupportedBindingFlags = 124;
	private static readonly object[] EmptyObjects; // 0x0

	// Properties
	[DoNotSerialize]
	public Type targetType { get; set; }
	[DoNotSerialize]
	public string targetTypeName { get; }
	[DoNotSerialize]
	public string name { get; set; }
	[DoNotSerialize]
	public bool isReflected { get; set; }
	[DoNotSerialize]
	public Member.Source source { get; set; }
	[DoNotSerialize]
	public FieldInfo fieldInfo { get; set; }
	[DoNotSerialize]
	public PropertyInfo propertyInfo { get; set; }
	[DoNotSerialize]
	public MethodInfo methodInfo { get; set; }
	[DoNotSerialize]
	public ConstructorInfo constructorInfo { get; set; }
	[DoNotSerialize]
	public bool isExtension { get; set; }
	[DoNotSerialize]
	public bool isInvokedAsExtension { get; set; }
	[DoNotSerialize]
	public Type[] parameterTypes { get; set; }
	public MethodBase methodBase { get; }
	private MemberInfo _info { get; }
	public MemberInfo info { get; }
	public Type type { get; }
	public bool isCoroutine { get; }
	public bool isYieldInstruction { get; }
	public bool isGettable { get; }
	public bool isPubliclyGettable { get; }
	public bool isSettable { get; }
	public bool isPubliclySettable { get; }
	public bool isInvocable { get; }
	public bool isPubliclyInvocable { get; }
	public bool isAccessor { get; }
	public bool isField { get; }
	public bool isProperty { get; }
	public bool isMethod { get; }
	public bool isConstructor { get; }
	public bool requiresTarget { get; }
	public bool isOperator { get; }
	public bool isConversion { get; }
	public int order { get; }
	public Type declaringType { get; }
	public bool isInherited { get; }
	public Type pseudoDeclaringType { get; }
	public bool isPseudoInherited { get; }
	public bool isIndexer { get; }
	public bool isPredictable { get; }
	public bool allowsNull { get; }

	// Methods

	[Obsolete("This parameterless constructor is only made public for serialization. Use another constructor instead.")]
	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x2208E00 Offset: 0x2207400 VA: 0x182208E00
	public void .ctor(Type targetType, string name, Type[] parameterTypes) { }

	// RVA: 0x2208C90 Offset: 0x2207290 VA: 0x182208C90
	public void .ctor(Type targetType, FieldInfo fieldInfo) { }

	// RVA: 0x2209100 Offset: 0x2207700 VA: 0x182209100
	public void .ctor(Type targetType, PropertyInfo propertyInfo) { }

	// RVA: 0x2209500 Offset: 0x2207B00 VA: 0x182209500
	public void .ctor(Type targetType, MethodInfo methodInfo) { }

	// RVA: 0x2209270 Offset: 0x2207870 VA: 0x182209270
	public void .ctor(Type targetType, ConstructorInfo constructorInfo) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Type get_targetType() { }

	// RVA: 0x220AB10 Offset: 0x2209110 VA: 0x18220AB10
	private void set_targetType(Type value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_targetTypeName() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_name() { }

	// RVA: 0x220AAA0 Offset: 0x22090A0 VA: 0x18220AAA0
	private void set_name(string value) { }

	[CompilerGenerated]
	// RVA: 0x1C58740 Offset: 0x1C56D40 VA: 0x181C58740
	public bool get_isReflected() { }

	[CompilerGenerated]
	// RVA: 0x1918FF0 Offset: 0x19175F0 VA: 0x181918FF0
	private void set_isReflected(bool value) { }

	// RVA: 0x220A860 Offset: 0x2208E60 VA: 0x18220A860
	public Member.Source get_source() { }

	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	private void set_source(Member.Source value) { }

	// RVA: 0x2209A50 Offset: 0x2208050 VA: 0x182209A50
	public FieldInfo get_fieldInfo() { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	private void set_fieldInfo(FieldInfo value) { }

	// RVA: 0x220A380 Offset: 0x2208980 VA: 0x18220A380
	public PropertyInfo get_propertyInfo() { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	private void set_propertyInfo(PropertyInfo value) { }

	// RVA: 0x220A310 Offset: 0x2208910 VA: 0x18220A310
	public MethodInfo get_methodInfo() { }

	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	private void set_methodInfo(MethodInfo value) { }

	// RVA: 0x22099A0 Offset: 0x2207FA0 VA: 0x1822099A0
	public ConstructorInfo get_constructorInfo() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	private void set_constructorInfo(ConstructorInfo value) { }

	// RVA: 0x2209D60 Offset: 0x2208360 VA: 0x182209D60
	public bool get_isExtension() { }

	// RVA: 0x3B9A60 Offset: 0x3B8060 VA: 0x1803B9A60
	private void set_isExtension(bool value) { }

	// RVA: 0x2209F30 Offset: 0x2208530 VA: 0x182209F30
	public bool get_isInvokedAsExtension() { }

	// RVA: 0x163E0E0 Offset: 0x163C6E0 VA: 0x18163E0E0
	private void set_isInvokedAsExtension(bool value) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Type[] get_parameterTypes() { }

	// RVA: 0x220AAF0 Offset: 0x22090F0 VA: 0x18220AAF0
	private void set_parameterTypes(Type[] value) { }

	// RVA: 0x220A2B0 Offset: 0x22088B0 VA: 0x18220A2B0
	public MethodBase get_methodBase() { }

	// RVA: 0x22097D0 Offset: 0x2207DD0 VA: 0x1822097D0
	private MemberInfo get__info() { }

	// RVA: 0x2209A80 Offset: 0x2208080 VA: 0x182209A80
	public MemberInfo get_info() { }

	// RVA: 0x220A890 Offset: 0x2208E90 VA: 0x18220A890
	public Type get_type() { }

	// RVA: 0x2209CD0 Offset: 0x22082D0 VA: 0x182209CD0
	public bool get_isCoroutine() { }

	// RVA: 0x220A200 Offset: 0x2208800 VA: 0x18220A200
	public bool get_isYieldInstruction() { }

	// RVA: 0x2209DC0 Offset: 0x22083C0 VA: 0x182209DC0
	public bool get_isGettable() { }

	// RVA: 0x220A1C0 Offset: 0x22087C0 VA: 0x18220A1C0
	public bool get_isPubliclyGettable() { }

	// RVA: 0x220A1F0 Offset: 0x22087F0 VA: 0x18220A1F0
	public bool get_isSettable() { }

	// RVA: 0x220A1E0 Offset: 0x22087E0 VA: 0x18220A1E0
	public bool get_isPubliclySettable() { }

	// RVA: 0x2209E90 Offset: 0x2208490 VA: 0x182209E90
	public bool get_isInvocable() { }

	// RVA: 0x220A1D0 Offset: 0x22087D0 VA: 0x18220A1D0
	public bool get_isPubliclyInvocable() { }

	// RVA: 0x2209B80 Offset: 0x2208180 VA: 0x182209B80
	public bool get_isAccessor() { }

	// RVA: 0x2209D90 Offset: 0x2208390 VA: 0x182209D90
	public bool get_isField() { }

	// RVA: 0x220A0A0 Offset: 0x22086A0 VA: 0x18220A0A0
	public bool get_isProperty() { }

	// RVA: 0x2209F60 Offset: 0x2208560 VA: 0x182209F60
	public bool get_isMethod() { }

	// RVA: 0x2209C20 Offset: 0x2208220 VA: 0x182209C20
	public bool get_isConstructor() { }

	// RVA: 0x220A6C0 Offset: 0x2208CC0 VA: 0x18220A6C0
	public bool get_requiresTarget() { }

	// RVA: 0x2209F90 Offset: 0x2208590 VA: 0x182209F90
	public bool get_isOperator() { }

	// RVA: 0x2209C50 Offset: 0x2208250 VA: 0x182209C50
	public bool get_isConversion() { }

	// RVA: 0x220A340 Offset: 0x2208940 VA: 0x18220A340
	public int get_order() { }

	// RVA: 0x22099D0 Offset: 0x2207FD0 VA: 0x1822099D0
	public Type get_declaringType() { }

	// RVA: 0x2209E40 Offset: 0x2208440 VA: 0x182209E40
	public bool get_isInherited() { }

	// RVA: 0x220A3B0 Offset: 0x22089B0 VA: 0x18220A3B0
	public Type get_pseudoDeclaringType() { }

	// RVA: 0x220A0D0 Offset: 0x22086D0 VA: 0x18220A0D0
	public bool get_isPseudoInherited() { }

	// RVA: 0x2209DD0 Offset: 0x22083D0 VA: 0x182209DD0
	public bool get_isIndexer() { }

	// RVA: 0x220A010 Offset: 0x2208610 VA: 0x18220A010
	public bool get_isPredictable() { }

	// RVA: 0x2209890 Offset: 0x2207E90 VA: 0x182209890
	public bool get_allowsNull() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2208B40 Offset: 0x2207140 VA: 0x182208B40 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x22068D0 Offset: 0x2204ED0 VA: 0x1822068D0
	public bool IsGettable(bool nonPublic) { }

	// RVA: 0x2206C20 Offset: 0x2205220 VA: 0x182206C20
	public bool IsSettable(bool nonPublic) { }

	// RVA: 0x2206B20 Offset: 0x2205120 VA: 0x182206B20
	public bool IsInvocable(bool nonPublic) { }

	// RVA: 0x2204EC0 Offset: 0x22034C0 VA: 0x182204EC0
	private void EnsureExplicitParameterTypes() { }

	// RVA: 0x2207B50 Offset: 0x2206150 VA: 0x182207B50
	public void Reflect() { }

	// RVA: 0x2207380 Offset: 0x2205980 VA: 0x182207380
	private void ReflectField(IEnumerable<MemberInfo> candidates) { }

	// RVA: 0x2207970 Offset: 0x2205F70 VA: 0x182207970
	private void ReflectProperty(IEnumerable<MemberInfo> candidates) { }

	// RVA: 0x2206F20 Offset: 0x2205520 VA: 0x182206F20
	private void ReflectConstructor(IEnumerable<MemberInfo> candidates) { }

	// RVA: 0x2207560 Offset: 0x2205B60 VA: 0x182207560
	private void ReflectMethod(IEnumerable<MemberInfo> candidates) { }

	// RVA: 0x2206DE0 Offset: 0x22053E0 VA: 0x182206DE0
	public void Prewarm() { }

	// RVA: 0x2205350 Offset: 0x2203950 VA: 0x182205350
	public void EnsureReflected() { }

	// RVA: 0x2205210 Offset: 0x2203810 VA: 0x182205210
	public void EnsureReady(object target) { }

	// RVA: 0x22056B0 Offset: 0x2203CB0 VA: 0x1822056B0
	public object Get(object target) { }

	// RVA: -1 Offset: -1
	public T Get<T>(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72F9E0 Offset: 0x72DFE0 VA: 0x18072F9E0
	|-Member.Get<bool>
	|
	|-RVA: 0x72FA70 Offset: 0x72E070 VA: 0x18072FA70
	|-Member.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2208630 Offset: 0x2206C30 VA: 0x182208630
	public object Set(object target, object value) { }

	// RVA: 0x2204F30 Offset: 0x2203530 VA: 0x182204F30
	private void EnsureInvocable(object target) { }

	// RVA: 0x22055E0 Offset: 0x2203BE0 VA: 0x1822055E0
	public IEnumerable<ParameterInfo> GetParameterInfos() { }

	// RVA: 0x2206570 Offset: 0x2204B70 VA: 0x182206570
	public object Invoke(object target) { }

	// RVA: 0x2205F60 Offset: 0x2204560 VA: 0x182205F60
	public object Invoke(object target, object arg0) { }

	// RVA: 0x22060F0 Offset: 0x22046F0 VA: 0x1822060F0
	public object Invoke(object target, object arg0, object arg1) { }

	// RVA: 0x2206690 Offset: 0x2204C90 VA: 0x182206690
	public object Invoke(object target, object arg0, object arg1, object arg2) { }

	// RVA: 0x22062C0 Offset: 0x22048C0 VA: 0x1822062C0
	public object Invoke(object target, object arg0, object arg1, object arg2, object arg3) { }

	// RVA: 0x22058F0 Offset: 0x2203EF0 VA: 0x1822058F0
	public object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }

	// RVA: 0x2205DD0 Offset: 0x22043D0 VA: 0x182205DD0
	public object Invoke(object target, object[] arguments) { }

	// RVA: -1 Offset: -1
	public T Invoke<T>(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72FD20 Offset: 0x72E320 VA: 0x18072FD20
	|-Member.Invoke<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T Invoke<T>(object target, object arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72FFB0 Offset: 0x72E5B0 VA: 0x18072FFB0
	|-Member.Invoke<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T Invoke<T>(object target, object arg0, object arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72FED0 Offset: 0x72E4D0 VA: 0x18072FED0
	|-Member.Invoke<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T Invoke<T>(object target, object arg0, object arg1, object arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72FC30 Offset: 0x72E230 VA: 0x18072FC30
	|-Member.Invoke<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T Invoke<T>(object target, object arg0, object arg1, object arg2, object arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72FB40 Offset: 0x72E140 VA: 0x18072FB40
	|-Member.Invoke<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T Invoke<T>(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x730090 Offset: 0x72E690 VA: 0x180730090
	|-Member.Invoke<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T Invoke<T>(object target, object[] arguments) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72FDF0 Offset: 0x72E3F0 VA: 0x18072FDF0
	|-Member.Invoke<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2205360 Offset: 0x2203960 VA: 0x182205360 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2205510 Offset: 0x2203B10 VA: 0x182205510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14152B0 Offset: 0x14138B0 VA: 0x1814152B0
	public static bool op_Equality(Member a, Member b) { }

	// RVA: 0x220AA00 Offset: 0x2209000 VA: 0x18220AA00
	public static bool op_Inequality(Member a, Member b) { }

	// RVA: 0x2208A20 Offset: 0x2207020 VA: 0x182208A20
	public string ToUniqueString() { }

	// RVA: 0x22089A0 Offset: 0x2206FA0 VA: 0x1822089A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2208880 Offset: 0x2206E80 VA: 0x182208880
	public Member ToDeclarer() { }

	// RVA: 0x2208910 Offset: 0x2206F10 VA: 0x182208910
	public Member ToPseudoDeclarer() { }

	// RVA: 0x2208C20 Offset: 0x2207220 VA: 0x182208C20
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(384, Inherited = True, AllowMultiple = False)]
public sealed class MemberFilter : Attribute, ICloneable // TypeDefIndex: 9085
{
	// Fields
	[CompilerGenerated]
	private bool <Fields>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <Properties>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <Methods>k__BackingField; // 0x12
	[CompilerGenerated]
	private bool <Constructors>k__BackingField; // 0x13
	[CompilerGenerated]
	private bool <Gettable>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <Settable>k__BackingField; // 0x15
	[CompilerGenerated]
	private bool <Inherited>k__BackingField; // 0x16
	[CompilerGenerated]
	private bool <Targeted>k__BackingField; // 0x17
	[CompilerGenerated]
	private bool <NonTargeted>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <Public>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <NonPublic>k__BackingField; // 0x1A
	[CompilerGenerated]
	private bool <ReadOnly>k__BackingField; // 0x1B
	[CompilerGenerated]
	private bool <WriteOnly>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <Extensions>k__BackingField; // 0x1D
	[CompilerGenerated]
	private bool <Operators>k__BackingField; // 0x1E
	[CompilerGenerated]
	private bool <Conversions>k__BackingField; // 0x1F
	[CompilerGenerated]
	private bool <Setters>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <Parameters>k__BackingField; // 0x21
	[CompilerGenerated]
	private bool <Obsolete>k__BackingField; // 0x22
	[CompilerGenerated]
	private bool <OpenConstructedGeneric>k__BackingField; // 0x23
	[CompilerGenerated]
	private bool <TypeInitializers>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <ClsNonCompliant>k__BackingField; // 0x25

	// Properties
	public bool Fields { get; set; }
	public bool Properties { get; set; }
	public bool Methods { get; set; }
	public bool Constructors { get; set; }
	public bool Gettable { get; set; }
	public bool Settable { get; set; }
	public bool Inherited { get; set; }
	public bool Targeted { get; set; }
	public bool NonTargeted { get; set; }
	public bool Public { get; set; }
	public bool NonPublic { get; set; }
	public bool ReadOnly { get; set; }
	public bool WriteOnly { get; set; }
	public bool Extensions { get; set; }
	public bool Operators { get; set; }
	public bool Conversions { get; set; }
	public bool Setters { get; set; }
	public bool Parameters { get; set; }
	public bool Obsolete { get; set; }
	public bool OpenConstructedGeneric { get; set; }
	public bool TypeInitializers { get; set; }
	public bool ClsNonCompliant { get; set; }
	public BindingFlags validBindingFlags { get; }
	public MemberTypes validMemberTypes { get; }
	public static MemberFilter Any { get; }

	// Methods

	// RVA: 0x222A7F0 Offset: 0x2228DF0 VA: 0x18222A7F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_Fields() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_Fields(bool value) { }

	[CompilerGenerated]
	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x14B8CA0 Offset: 0x14B72A0 VA: 0x1814B8CA0
	public void set_Properties(bool value) { }

	[CompilerGenerated]
	// RVA: 0xA6C5D0 Offset: 0xA6ABD0 VA: 0x180A6C5D0
	public bool get_Methods() { }

	[CompilerGenerated]
	// RVA: 0xB69DA0 Offset: 0xB683A0 VA: 0x180B69DA0
	public void set_Methods(bool value) { }

	[CompilerGenerated]
	// RVA: 0xA6C690 Offset: 0xA6AC90 VA: 0x180A6C690
	public bool get_Constructors() { }

	[CompilerGenerated]
	// RVA: 0x197E7F0 Offset: 0x197CDF0 VA: 0x18197E7F0
	public void set_Constructors(bool value) { }

	[CompilerGenerated]
	// RVA: 0xC1EE00 Offset: 0xC1D400 VA: 0x180C1EE00
	public bool get_Gettable() { }

	[CompilerGenerated]
	// RVA: 0x1453DF0 Offset: 0x14523F0 VA: 0x181453DF0
	public void set_Gettable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x146E7F0 Offset: 0x146CDF0 VA: 0x18146E7F0
	public bool get_Settable() { }

	[CompilerGenerated]
	// RVA: 0x146E800 Offset: 0x146CE00 VA: 0x18146E800
	public void set_Settable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x222A8A0 Offset: 0x2228EA0 VA: 0x18222A8A0
	public bool get_Inherited() { }

	[CompilerGenerated]
	// RVA: 0x222A970 Offset: 0x2228F70 VA: 0x18222A970
	public void set_Inherited(bool value) { }

	[CompilerGenerated]
	// RVA: 0x222A8B0 Offset: 0x2228EB0 VA: 0x18222A8B0
	public bool get_Targeted() { }

	[CompilerGenerated]
	// RVA: 0x222A980 Offset: 0x2228F80 VA: 0x18222A980
	public void set_Targeted(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B10 Offset: 0x4E4110 VA: 0x1804E5B10
	public bool get_NonTargeted() { }

	[CompilerGenerated]
	// RVA: 0x4E5B40 Offset: 0x4E4140 VA: 0x1804E5B40
	public void set_NonTargeted(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B20 Offset: 0x4E4120 VA: 0x1804E5B20
	public bool get_Public() { }

	[CompilerGenerated]
	// RVA: 0x4E5B50 Offset: 0x4E4150 VA: 0x1804E5B50
	public void set_Public(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1698DB0 Offset: 0x16973B0 VA: 0x181698DB0
	public bool get_NonPublic() { }

	[CompilerGenerated]
	// RVA: 0x1698DC0 Offset: 0x16973C0 VA: 0x181698DC0
	public void set_NonPublic(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1897340 Offset: 0x1895940 VA: 0x181897340
	public bool get_ReadOnly() { }

	[CompilerGenerated]
	// RVA: 0x1897450 Offset: 0x1895A50 VA: 0x181897450
	public void set_ReadOnly(bool value) { }

	[CompilerGenerated]
	// RVA: 0x39A900 Offset: 0x398F00 VA: 0x18039A900
	public bool get_WriteOnly() { }

	[CompilerGenerated]
	// RVA: 0x39A910 Offset: 0x398F10 VA: 0x18039A910
	public void set_WriteOnly(bool value) { }

	[CompilerGenerated]
	// RVA: 0x197EBE0 Offset: 0x197D1E0 VA: 0x18197EBE0
	public bool get_Extensions() { }

	[CompilerGenerated]
	// RVA: 0x197E820 Offset: 0x197CE20 VA: 0x18197E820
	public void set_Extensions(bool value) { }

	[CompilerGenerated]
	// RVA: 0x197E830 Offset: 0x197CE30 VA: 0x18197E830
	public bool get_Operators() { }

	[CompilerGenerated]
	// RVA: 0x197E7E0 Offset: 0x197CDE0 VA: 0x18197E7E0
	public void set_Operators(bool value) { }

	[CompilerGenerated]
	// RVA: 0x197E800 Offset: 0x197CE00 VA: 0x18197E800
	public bool get_Conversions() { }

	[CompilerGenerated]
	// RVA: 0x197E070 Offset: 0x197C670 VA: 0x18197E070
	public void set_Conversions(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_Setters() { }

	[CompilerGenerated]
	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_Setters(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38E1B0 Offset: 0x38C7B0 VA: 0x18038E1B0
	public bool get_Parameters() { }

	[CompilerGenerated]
	// RVA: 0x38E210 Offset: 0x38C810 VA: 0x18038E210
	public void set_Parameters(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38E1C0 Offset: 0x38C7C0 VA: 0x18038E1C0
	public bool get_Obsolete() { }

	[CompilerGenerated]
	// RVA: 0x38E220 Offset: 0x38C820 VA: 0x18038E220
	public void set_Obsolete(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38E1D0 Offset: 0x38C7D0 VA: 0x18038E1D0
	public bool get_OpenConstructedGeneric() { }

	[CompilerGenerated]
	// RVA: 0x38E230 Offset: 0x38C830 VA: 0x18038E230
	public void set_OpenConstructedGeneric(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	public bool get_TypeInitializers() { }

	[CompilerGenerated]
	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	public void set_TypeInitializers(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161BB10 Offset: 0x161A110 VA: 0x18161BB10
	public bool get_ClsNonCompliant() { }

	[CompilerGenerated]
	// RVA: 0x161BB90 Offset: 0x161A190 VA: 0x18161BB90
	public void set_ClsNonCompliant(bool value) { }

	// RVA: 0x222A8C0 Offset: 0x2228EC0 VA: 0x18222A8C0
	public BindingFlags get_validBindingFlags() { }

	// RVA: 0x222A920 Offset: 0x2228F20 VA: 0x18222A920
	public MemberTypes get_validMemberTypes() { }

	// RVA: 0x2229170 Offset: 0x2227770 VA: 0x182229170 Slot: 7
	private object System.ICloneable.Clone() { }

	// RVA: 0x2229170 Offset: 0x2227770 VA: 0x182229170
	public MemberFilter Clone() { }

	// RVA: 0x2229280 Offset: 0x2227880 VA: 0x182229280 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x22293D0 Offset: 0x22279D0 VA: 0x1822293D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2229C80 Offset: 0x2228280 VA: 0x182229C80
	public bool ValidateMember(MemberInfo member, TypeFilter typeFilter) { }

	// RVA: 0x2229680 Offset: 0x2227C80 VA: 0x182229680 Slot: 3
	public override string ToString() { }

	// RVA: 0x222A830 Offset: 0x2228E30 VA: 0x18222A830
	public static MemberFilter get_Any() { }
}

// Namespace: Unity.VisualScripting
public class MemberInfoComparer : EqualityComparer<MemberInfo> // TypeDefIndex: 9086
{
	// Methods

	// RVA: 0x222A990 Offset: 0x2228F90 VA: 0x18222A990 Slot: 8
	public override bool Equals(MemberInfo x, MemberInfo y) { }

	// RVA: 0x2056D10 Offset: 0x2055310 VA: 0x182056D10 Slot: 9
	public override int GetHashCode(MemberInfo obj) { }

	// RVA: 0x222AA80 Offset: 0x2229080 VA: 0x18222AA80
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Extension]
public static class MemberUtility // TypeDefIndex: 9096
{
	// Fields
	private static readonly Lazy<ExtensionMethodCache> ExtensionMethodsCache; // 0x0
	private static readonly Lazy<Dictionary<Type, MethodInfo[]>> InheritedExtensionMethodsCache; // 0x8
	private static readonly Lazy<HashSet<MethodInfo>> GenericExtensionMethods; // 0x10

	// Methods

	// RVA: 0x222E9E0 Offset: 0x222CFE0 VA: 0x18222E9E0
	private static void .cctor() { }

	[Extension]
	// RVA: 0x222D1A0 Offset: 0x222B7A0 VA: 0x18222D1A0
	public static bool IsOperator(MethodInfo method) { }

	[Extension]
	// RVA: 0x222D7A0 Offset: 0x222BDA0 VA: 0x18222D7A0
	public static bool IsUserDefinedConversion(MethodInfo method) { }

	[Extension]
	// RVA: 0x222D860 Offset: 0x222BE60 VA: 0x18222D860
	public static MethodInfo MakeGenericMethodVia(MethodInfo openConstructedMethod, Type[] closedConstructedParameterTypes) { }

	[Extension]
	// RVA: 0x222D050 Offset: 0x222B650 VA: 0x18222D050
	public static bool IsGenericExtension(MethodInfo methodInfo) { }

	[IteratorStateMachine(typeof(MemberUtility.<GetInheritedExtensionMethods>d__8))]
	// RVA: 0x222C6F0 Offset: 0x222ACF0 VA: 0x18222C6F0
	private static IEnumerable<MethodInfo> GetInheritedExtensionMethods(Type thisArgumentType) { }

	[Extension]
	// RVA: 0x222C1F0 Offset: 0x222A7F0 VA: 0x18222C1F0
	public static IEnumerable<MethodInfo> GetExtensionMethods(Type thisArgumentType, bool inherited = True) { }

	[Extension]
	// RVA: 0x222CFF0 Offset: 0x222B5F0 VA: 0x18222CFF0
	public static bool IsExtension(MethodInfo methodInfo) { }

	[Extension]
	// RVA: 0x222CF10 Offset: 0x222B510 VA: 0x18222CF10
	public static bool IsExtensionMethod(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x1448440 Offset: 0x1446A40 VA: 0x181448440
	public static Delegate CreateDelegate(MethodInfo methodInfo, Type delegateType) { }

	[Extension]
	// RVA: 0x222CE40 Offset: 0x222B440 VA: 0x18222CE40
	public static bool IsAccessor(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x222BA60 Offset: 0x222A060 VA: 0x18222BA60
	public static Type GetAccessorType(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x222D260 Offset: 0x222B860 VA: 0x18222D260
	public static bool IsPubliclyGettable(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x222B690 Offset: 0x2229C90 VA: 0x18222B690
	private static Type ExtendedDeclaringType(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x222B7D0 Offset: 0x2229DD0 VA: 0x18222B7D0
	public static Type ExtendedDeclaringType(MemberInfo memberInfo, bool invokeAsExtension) { }

	[Extension]
	// RVA: 0x222D4D0 Offset: 0x222BAD0 VA: 0x18222D4D0
	public static bool IsStatic(PropertyInfo propertyInfo) { }

	[Extension]
	// RVA: 0x222D550 Offset: 0x222BB50 VA: 0x18222D550
	public static bool IsStatic(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x222CA40 Offset: 0x222B040 VA: 0x18222CA40
	private static IEnumerable<ParameterInfo> GetParametersWithoutThis(MethodBase methodBase) { }

	[Extension]
	// RVA: 0x222D0F0 Offset: 0x222B6F0 VA: 0x18222D0F0
	public static bool IsInvokedAsExtension(MethodBase methodBase, Type targetType) { }

	[Extension]
	// RVA: 0x222C7E0 Offset: 0x222ADE0 VA: 0x18222C7E0
	public static IEnumerable<ParameterInfo> GetInvocationParameters(MethodBase methodBase, bool invokeAsExtension) { }

	[Extension]
	// RVA: 0x222C770 Offset: 0x222AD70 VA: 0x18222C770
	public static IEnumerable<ParameterInfo> GetInvocationParameters(MethodBase methodBase, Type targetType) { }

	[Extension]
	// RVA: 0x222E960 Offset: 0x222CF60 VA: 0x18222E960
	public static Type UnderlyingParameterType(ParameterInfo parameterInfo) { }

	[Extension]
	// RVA: 0x222CD50 Offset: 0x222B350 VA: 0x18222CD50
	public static bool HasDefaultValue(ParameterInfo parameterInfo) { }

	[Extension]
	// RVA: 0x222AC00 Offset: 0x2229200 VA: 0x18222AC00
	public static object DefaultValue(ParameterInfo parameterInfo) { }

	[Extension]
	// RVA: 0x222DEC0 Offset: 0x222C4C0 VA: 0x18222DEC0
	public static object PseudoDefaultValue(ParameterInfo parameterInfo) { }

	[Extension]
	// RVA: 0x222AAC0 Offset: 0x22290C0 VA: 0x18222AAC0
	public static bool AllowsNull(ParameterInfo parameterInfo) { }

	[Extension]
	// RVA: 0x222CD80 Offset: 0x222B380 VA: 0x18222CD80
	public static bool HasOutModifier(ParameterInfo parameterInfo) { }

	[Extension]
	// RVA: 0x222ABC0 Offset: 0x22291C0 VA: 0x18222ABC0
	public static bool CanWrite(FieldInfo fieldInfo) { }

	[Extension]
	// RVA: 0x222E800 Offset: 0x222CE00 VA: 0x18222E800
	public static Member ToManipulator(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x222E440 Offset: 0x222CA40 VA: 0x18222E440
	public static Member ToManipulator(MemberInfo memberInfo, Type targetType) { }

	[Extension]
	// RVA: 0x222E8F0 Offset: 0x222CEF0 VA: 0x18222E8F0
	public static Member ToManipulator(FieldInfo fieldInfo, Type targetType) { }

	[Extension]
	// RVA: 0x222E790 Offset: 0x222CD90 VA: 0x18222E790
	public static Member ToManipulator(PropertyInfo propertyInfo, Type targetType) { }

	[Extension]
	// RVA: 0x222E880 Offset: 0x222CE80 VA: 0x18222E880
	public static Member ToManipulator(MethodInfo methodInfo, Type targetType) { }

	[Extension]
	// RVA: 0x222E720 Offset: 0x222CD20 VA: 0x18222E720
	public static Member ToManipulator(ConstructorInfo constructorInfo, Type targetType) { }

	[Extension]
	// RVA: 0x222BB90 Offset: 0x222A190 VA: 0x18222BB90
	public static ConstructorInfo GetConstructorAccepting(Type type, Type[] paramTypes, bool nonPublic) { }

	[Extension]
	// RVA: 0x222BCA0 Offset: 0x222A2A0 VA: 0x18222BCA0
	public static ConstructorInfo GetConstructorAccepting(Type type, Type[] paramTypes) { }

	[Extension]
	// RVA: 0x222CC40 Offset: 0x222B240 VA: 0x18222CC40
	public static ConstructorInfo GetPublicConstructorAccepting(Type type, Type[] paramTypes) { }

	[Extension]
	// RVA: 0x222BD00 Offset: 0x222A300 VA: 0x18222BD00
	public static ConstructorInfo GetDefaultConstructor(Type type) { }

	[Extension]
	// RVA: 0x222CCA0 Offset: 0x222B2A0 VA: 0x18222CCA0
	public static ConstructorInfo GetPublicDefaultConstructor(Type type) { }

	[Extension]
	// RVA: 0x222BDB0 Offset: 0x222A3B0 VA: 0x18222BDB0
	public static MemberInfo[] GetExtendedMember(Type type, string name, MemberTypes types, BindingFlags flags) { }

	[Extension]
	// RVA: 0x222BF90 Offset: 0x222A590 VA: 0x18222BF90
	public static MemberInfo[] GetExtendedMembers(Type type, BindingFlags flags) { }

	[Extension]
	// RVA: 0x222DCA0 Offset: 0x222C2A0 VA: 0x18222DCA0
	private static bool NameMatches(MemberInfo member, string name) { }

	[Extension]
	// RVA: 0x222DCE0 Offset: 0x222C2E0 VA: 0x18222DCE0
	private static bool ParametersMatch(MethodBase methodBase, IEnumerable<Type> parameterTypes, bool invokeAsExtension) { }

	[Extension]
	// RVA: 0x222B970 Offset: 0x2229F70 VA: 0x18222B970
	private static bool GenericArgumentsMatch(MethodInfo method, IEnumerable<Type> genericArgumentTypes) { }

	[Extension]
	// RVA: 0x222E100 Offset: 0x222C700 VA: 0x18222E100
	public static bool SignatureMatches(FieldInfo field, string name) { }

	[Extension]
	// RVA: 0x222E080 Offset: 0x222C680 VA: 0x18222E080
	public static bool SignatureMatches(PropertyInfo property, string name) { }

	[Extension]
	// RVA: 0x222E280 Offset: 0x222C880 VA: 0x18222E280
	public static bool SignatureMatches(ConstructorInfo constructor, string name, IEnumerable<Type> parameterTypes) { }

	[Extension]
	// RVA: 0x222E350 Offset: 0x222C950 VA: 0x18222E350
	public static bool SignatureMatches(MethodInfo method, string name, IEnumerable<Type> parameterTypes, bool invokeAsExtension) { }

	[Extension]
	// RVA: 0x222E180 Offset: 0x222C780 VA: 0x18222E180
	public static bool SignatureMatches(MethodInfo method, string name, IEnumerable<Type> parameterTypes, IEnumerable<Type> genericArgumentTypes, bool invokeAsExtension) { }

	[Extension]
	// RVA: 0x222C580 Offset: 0x222AB80 VA: 0x18222C580
	public static FieldInfo GetFieldUnambiguous(Type type, string name, BindingFlags flags) { }

	[Extension]
	// RVA: 0x222CAE0 Offset: 0x222B0E0 VA: 0x18222CAE0
	public static PropertyInfo GetPropertyUnambiguous(Type type, string name, BindingFlags flags) { }

	[Extension]
	// RVA: 0x222C8E0 Offset: 0x222AEE0 VA: 0x18222C8E0
	public static MethodInfo GetMethodUnambiguous(Type type, string name, BindingFlags flags) { }

	[Extension]
	// RVA: -1 Offset: -1
	private static TMemberInfo DisambiguateHierarchy<TMemberInfo>(IEnumerable<TMemberInfo> members, Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x72F6E0 Offset: 0x72DCE0 VA: 0x18072F6E0
	|-MemberUtility.DisambiguateHierarchy<object>
	*/

	[Extension]
	// RVA: 0x222ADC0 Offset: 0x22293C0 VA: 0x18222ADC0
	public static FieldInfo Disambiguate(IEnumerable<FieldInfo> fields, Type type) { }

	[Extension]
	// RVA: 0x222B150 Offset: 0x2229750 VA: 0x18222B150
	public static PropertyInfo Disambiguate(IEnumerable<PropertyInfo> properties, Type type) { }

	[Extension]
	// RVA: 0x222B260 Offset: 0x2229860 VA: 0x18222B260
	public static ConstructorInfo Disambiguate(IEnumerable<ConstructorInfo> constructors, Type type, IEnumerable<Type> parameterTypes) { }

	[Extension]
	// RVA: 0x222B470 Offset: 0x2229A70 VA: 0x18222B470
	public static MethodInfo Disambiguate(IEnumerable<MethodInfo> methods, Type type, IEnumerable<Type> parameterTypes) { }

	[Extension]
	// RVA: 0x222AED0 Offset: 0x22294D0 VA: 0x18222AED0
	public static MethodInfo Disambiguate(IEnumerable<MethodInfo> methods, Type type, IEnumerable<Type> parameterTypes, IEnumerable<Type> genericArgumentTypes) { }
}

// Namespace: Unity.VisualScripting
internal class ExtensionMethodCache // TypeDefIndex: 9098
{
	// Fields
	internal readonly MethodInfo[] Cache; // 0x10

	// Methods

	// RVA: 0x2228DF0 Offset: 0x22273F0 VA: 0x182228DF0
	internal void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class Namespace // TypeDefIndex: 9102
{
	// Fields
	[CompilerGenerated]
	private readonly Namespace <Root>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Namespace <Parent>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <FullName>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly bool <IsRoot>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly bool <IsGlobal>k__BackingField; // 0x31
	private static readonly Namespace.Collection collection; // 0x0
	[CompilerGenerated]
	private static readonly Namespace <Global>k__BackingField; // 0x8

	// Properties
	public Namespace Root { get; }
	public Namespace Parent { get; }
	public string FullName { get; }
	public string Name { get; }
	public bool IsRoot { get; }
	public bool IsGlobal { get; }
	public IEnumerable<Namespace> Ancestors { get; }
	public static Namespace Global { get; }

	// Methods

	// RVA: 0x222F0E0 Offset: 0x222D6E0 VA: 0x18222F0E0
	private void .ctor(string fullName) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Namespace get_Root() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Namespace get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_FullName() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_IsRoot() { }

	[CompilerGenerated]
	// RVA: 0x16ADFC0 Offset: 0x16AC5C0 VA: 0x1816ADFC0
	public bool get_IsGlobal() { }

	[IteratorStateMachine(typeof(Namespace.<get_Ancestors>d__20))]
	// RVA: 0x222F310 Offset: 0x222D910 VA: 0x18222F310
	public IEnumerable<Namespace> get_Ancestors() { }

	[IteratorStateMachine(typeof(Namespace.<AndAncestors>d__21))]
	// RVA: 0x222EC60 Offset: 0x222D260 VA: 0x18222EC60
	public IEnumerable<Namespace> AndAncestors() { }

	// RVA: 0x222EF90 Offset: 0x222D590 VA: 0x18222EF90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x222EFC0 Offset: 0x222D5C0 VA: 0x18222EFC0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x222F390 Offset: 0x222D990 VA: 0x18222F390
	public static Namespace get_Global() { }

	// RVA: 0x222ED70 Offset: 0x222D370 VA: 0x18222ED70
	public static Namespace FromFullName(string fullName) { }

	// RVA: 0x222ECE0 Offset: 0x222D2E0 VA: 0x18222ECE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x222F3E0 Offset: 0x222D9E0 VA: 0x18222F3E0
	public static Namespace op_Implicit(string fullName) { }

	// RVA: 0x5C6650 Offset: 0x5C4C50 VA: 0x1805C6650
	public static string op_Implicit(Namespace namespace) { }

	// RVA: 0x14152B0 Offset: 0x14138B0 VA: 0x1814152B0
	public static bool op_Equality(Namespace a, Namespace b) { }

	// RVA: 0x222F430 Offset: 0x222DA30 VA: 0x18222F430
	public static bool op_Inequality(Namespace a, Namespace b) { }
}

// Namespace: Unity.VisualScripting
public sealed class AdditionHandler : BinaryOperatorHandler // TypeDefIndex: 9104
{
	// Methods

	// RVA: 0x2212850 Offset: 0x2210E50 VA: 0x182212850
	public void .ctor() { }

	// RVA: 0x22127F0 Offset: 0x2210DF0 VA: 0x1822127F0 Slot: 5
	protected override object CustomHandling(object leftOperand, object rightOperand) { }
}

// Namespace: Unity.VisualScripting
public sealed class AmbiguousOperatorException : OperatorException // TypeDefIndex: 9105
{
	// Methods

	// RVA: 0x2218630 Offset: 0x2216C30 VA: 0x182218630
	public void .ctor(string symbol, Type leftType, Type rightType) { }
}

// Namespace: Unity.VisualScripting
public class AndHandler : BinaryOperatorHandler // TypeDefIndex: 9107
{
	// Methods

	// RVA: 0x2218820 Offset: 0x2216E20 VA: 0x182218820
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public enum BinaryOperator // TypeDefIndex: 9108
{
	// Fields
	public int value__; // 0x0
	public const BinaryOperator Addition = 0;
	public const BinaryOperator Subtraction = 1;
	public const BinaryOperator Multiplication = 2;
	public const BinaryOperator Division = 3;
	public const BinaryOperator Modulo = 4;
	public const BinaryOperator And = 5;
	public const BinaryOperator Or = 6;
	public const BinaryOperator ExclusiveOr = 7;
	public const BinaryOperator Equality = 8;
	public const BinaryOperator Inequality = 9;
	public const BinaryOperator GreaterThan = 10;
	public const BinaryOperator LessThan = 11;
	public const BinaryOperator GreaterThanOrEqual = 12;
	public const BinaryOperator LessThanOrEqual = 13;
	public const BinaryOperator LeftShift = 14;
	public const BinaryOperator RightShift = 15;
}

// Namespace: Unity.VisualScripting
public abstract class BinaryOperatorHandler : OperatorHandler // TypeDefIndex: 9111
{
	// Fields
	private readonly Dictionary<BinaryOperatorHandler.OperatorQuery, Func<object, object, object>> handlers; // 0x30
	private readonly Dictionary<BinaryOperatorHandler.OperatorQuery, IOptimizedInvoker> userDefinedOperators; // 0x38
	private readonly Dictionary<BinaryOperatorHandler.OperatorQuery, BinaryOperatorHandler.OperatorQuery> userDefinedOperandTypes; // 0x40

	// Methods

	// RVA: 0x221C4B0 Offset: 0x221AAB0 VA: 0x18221C4B0
	protected void .ctor(string name, string verb, string symbol, string customMethodName) { }

	// RVA: 0x221BA50 Offset: 0x221A050 VA: 0x18221BA50 Slot: 4
	public virtual object Operate(object leftOperand, object rightOperand) { }

	// RVA: 0x221B9A0 Offset: 0x2219FA0 VA: 0x18221B9A0 Slot: 5
	protected virtual object CustomHandling(object leftOperand, object rightOperand) { }

	// RVA: 0x221B940 Offset: 0x2219F40 VA: 0x18221B940 Slot: 6
	protected virtual object BothNullHandling() { }

	// RVA: 0x221C450 Offset: 0x221AA50 VA: 0x18221C450 Slot: 7
	protected virtual object SingleNullHandling() { }

	// RVA: -1 Offset: -1
	protected void Handle<TLeft, TRight>(Func<TLeft, TRight, object> handler, bool reverse = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B0770 Offset: 0x6AED70 VA: 0x1806B0770
	|-BinaryOperatorHandler.Handle<bool, bool>
	|-BinaryOperatorHandler.Handle<byte, byte>
	|-BinaryOperatorHandler.Handle<byte, Decimal>
	|-BinaryOperatorHandler.Handle<byte, double>
	|-BinaryOperatorHandler.Handle<byte, short>
	|-BinaryOperatorHandler.Handle<byte, int>
	|-BinaryOperatorHandler.Handle<byte, long>
	|-BinaryOperatorHandler.Handle<byte, sbyte>
	|-BinaryOperatorHandler.Handle<byte, float>
	|-BinaryOperatorHandler.Handle<byte, ushort>
	|-BinaryOperatorHandler.Handle<byte, uint>
	|-BinaryOperatorHandler.Handle<byte, ulong>
	|-BinaryOperatorHandler.Handle<Decimal, byte>
	|-BinaryOperatorHandler.Handle<Decimal, Decimal>
	|-BinaryOperatorHandler.Handle<Decimal, short>
	|-BinaryOperatorHandler.Handle<Decimal, int>
	|-BinaryOperatorHandler.Handle<Decimal, long>
	|-BinaryOperatorHandler.Handle<Decimal, sbyte>
	|-BinaryOperatorHandler.Handle<Decimal, ushort>
	|-BinaryOperatorHandler.Handle<Decimal, uint>
	|-BinaryOperatorHandler.Handle<Decimal, ulong>
	|-BinaryOperatorHandler.Handle<double, byte>
	|-BinaryOperatorHandler.Handle<double, double>
	|-BinaryOperatorHandler.Handle<double, short>
	|-BinaryOperatorHandler.Handle<double, int>
	|-BinaryOperatorHandler.Handle<double, long>
	|-BinaryOperatorHandler.Handle<double, sbyte>
	|-BinaryOperatorHandler.Handle<double, float>
	|-BinaryOperatorHandler.Handle<double, ushort>
	|-BinaryOperatorHandler.Handle<double, uint>
	|-BinaryOperatorHandler.Handle<double, ulong>
	|-BinaryOperatorHandler.Handle<short, byte>
	|-BinaryOperatorHandler.Handle<short, Decimal>
	|-BinaryOperatorHandler.Handle<short, double>
	|-BinaryOperatorHandler.Handle<short, short>
	|-BinaryOperatorHandler.Handle<short, int>
	|-BinaryOperatorHandler.Handle<short, long>
	|-BinaryOperatorHandler.Handle<short, sbyte>
	|-BinaryOperatorHandler.Handle<short, float>
	|-BinaryOperatorHandler.Handle<short, ushort>
	|-BinaryOperatorHandler.Handle<short, uint>
	|-BinaryOperatorHandler.Handle<int, byte>
	|-BinaryOperatorHandler.Handle<int, Decimal>
	|-BinaryOperatorHandler.Handle<int, double>
	|-BinaryOperatorHandler.Handle<int, short>
	|-BinaryOperatorHandler.Handle<int, int>
	|-BinaryOperatorHandler.Handle<int, long>
	|-BinaryOperatorHandler.Handle<int, sbyte>
	|-BinaryOperatorHandler.Handle<int, float>
	|-BinaryOperatorHandler.Handle<int, ushort>
	|-BinaryOperatorHandler.Handle<int, uint>
	|-BinaryOperatorHandler.Handle<long, byte>
	|-BinaryOperatorHandler.Handle<long, Decimal>
	|-BinaryOperatorHandler.Handle<long, double>
	|-BinaryOperatorHandler.Handle<long, short>
	|-BinaryOperatorHandler.Handle<long, int>
	|-BinaryOperatorHandler.Handle<long, long>
	|-BinaryOperatorHandler.Handle<long, sbyte>
	|-BinaryOperatorHandler.Handle<long, float>
	|-BinaryOperatorHandler.Handle<long, ushort>
	|-BinaryOperatorHandler.Handle<long, uint>
	|-BinaryOperatorHandler.Handle<sbyte, byte>
	|-BinaryOperatorHandler.Handle<sbyte, Decimal>
	|-BinaryOperatorHandler.Handle<sbyte, double>
	|-BinaryOperatorHandler.Handle<sbyte, short>
	|-BinaryOperatorHandler.Handle<sbyte, int>
	|-BinaryOperatorHandler.Handle<sbyte, long>
	|-BinaryOperatorHandler.Handle<sbyte, sbyte>
	|-BinaryOperatorHandler.Handle<sbyte, float>
	|-BinaryOperatorHandler.Handle<sbyte, ushort>
	|-BinaryOperatorHandler.Handle<sbyte, uint>
	|-BinaryOperatorHandler.Handle<float, byte>
	|-BinaryOperatorHandler.Handle<float, double>
	|-BinaryOperatorHandler.Handle<float, short>
	|-BinaryOperatorHandler.Handle<float, int>
	|-BinaryOperatorHandler.Handle<float, long>
	|-BinaryOperatorHandler.Handle<float, sbyte>
	|-BinaryOperatorHandler.Handle<float, float>
	|-BinaryOperatorHandler.Handle<float, ushort>
	|-BinaryOperatorHandler.Handle<float, uint>
	|-BinaryOperatorHandler.Handle<float, ulong>
	|-BinaryOperatorHandler.Handle<ushort, byte>
	|-BinaryOperatorHandler.Handle<ushort, Decimal>
	|-BinaryOperatorHandler.Handle<ushort, double>
	|-BinaryOperatorHandler.Handle<ushort, short>
	|-BinaryOperatorHandler.Handle<ushort, int>
	|-BinaryOperatorHandler.Handle<ushort, long>
	|-BinaryOperatorHandler.Handle<ushort, sbyte>
	|-BinaryOperatorHandler.Handle<ushort, float>
	|-BinaryOperatorHandler.Handle<ushort, ushort>
	|-BinaryOperatorHandler.Handle<ushort, uint>
	|-BinaryOperatorHandler.Handle<ushort, ulong>
	|-BinaryOperatorHandler.Handle<uint, byte>
	|-BinaryOperatorHandler.Handle<uint, Decimal>
	|-BinaryOperatorHandler.Handle<uint, double>
	|-BinaryOperatorHandler.Handle<uint, short>
	|-BinaryOperatorHandler.Handle<uint, int>
	|-BinaryOperatorHandler.Handle<uint, long>
	|-BinaryOperatorHandler.Handle<uint, sbyte>
	|-BinaryOperatorHandler.Handle<uint, float>
	|-BinaryOperatorHandler.Handle<uint, ushort>
	|-BinaryOperatorHandler.Handle<uint, uint>
	|-BinaryOperatorHandler.Handle<uint, ulong>
	|-BinaryOperatorHandler.Handle<ulong, byte>
	|-BinaryOperatorHandler.Handle<ulong, Decimal>
	|-BinaryOperatorHandler.Handle<ulong, double>
	|-BinaryOperatorHandler.Handle<ulong, short>
	|-BinaryOperatorHandler.Handle<ulong, int>
	|-BinaryOperatorHandler.Handle<ulong, sbyte>
	|-BinaryOperatorHandler.Handle<ulong, float>
	|-BinaryOperatorHandler.Handle<ulong, ushort>
	|-BinaryOperatorHandler.Handle<ulong, uint>
	|-BinaryOperatorHandler.Handle<ulong, ulong>
	|
	|-RVA: 0x6B0DB0 Offset: 0x6AF3B0 VA: 0x1806B0DB0
	|-BinaryOperatorHandler.Handle<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x221C370 Offset: 0x221A970 VA: 0x18221C370
	private static BinaryOperatorHandler.OperatorQuery ResolveUserDefinedOperandTypes(MethodInfo userDefinedOperator) { }
}

// Namespace: Unity.VisualScripting
public sealed class DecrementHandler : UnaryOperatorHandler // TypeDefIndex: 9113
{
	// Methods

	// RVA: 0x221C820 Offset: 0x221AE20 VA: 0x18221C820
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class DivisionHandler : BinaryOperatorHandler // TypeDefIndex: 9115
{
	// Methods

	// RVA: 0x221D1C0 Offset: 0x221B7C0 VA: 0x18221D1C0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class EqualityHandler : BinaryOperatorHandler // TypeDefIndex: 9117
{
	// Methods

	// RVA: 0x2223010 Offset: 0x2221610 VA: 0x182223010
	public void .ctor() { }

	// RVA: 0x2222FA0 Offset: 0x22215A0 VA: 0x182222FA0 Slot: 6
	protected override object BothNullHandling() { }

	// RVA: 0x2222FF0 Offset: 0x22215F0 VA: 0x182222FF0 Slot: 7
	protected override object SingleNullHandling() { }

	// RVA: 0x2222FC0 Offset: 0x22215C0 VA: 0x182222FC0 Slot: 5
	protected override object CustomHandling(object leftOperand, object rightOperand) { }
}

// Namespace: Unity.VisualScripting
public class ExclusiveOrHandler : BinaryOperatorHandler // TypeDefIndex: 9119
{
	// Methods

	// RVA: 0x2235240 Offset: 0x2233840 VA: 0x182235240
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class GreaterThanHandler : BinaryOperatorHandler // TypeDefIndex: 9121
{
	// Methods

	// RVA: 0x2238360 Offset: 0x2236960 VA: 0x182238360
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class GreaterThanOrEqualHandler : BinaryOperatorHandler // TypeDefIndex: 9123
{
	// Methods

	// RVA: 0x223E130 Offset: 0x223C730 VA: 0x18223E130
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class IncrementHandler : UnaryOperatorHandler // TypeDefIndex: 9125
{
	// Methods

	// RVA: 0x2243F00 Offset: 0x2242500 VA: 0x182243F00
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class InequalityHandler : BinaryOperatorHandler // TypeDefIndex: 9127
{
	// Methods

	// RVA: 0x22448E0 Offset: 0x2242EE0 VA: 0x1822448E0
	public void .ctor() { }

	// RVA: 0x2222FF0 Offset: 0x22215F0 VA: 0x182222FF0 Slot: 6
	protected override object BothNullHandling() { }

	// RVA: 0x2222FF0 Offset: 0x22215F0 VA: 0x182222FF0 Slot: 7
	protected override object SingleNullHandling() { }

	// RVA: 0x22448A0 Offset: 0x2242EA0 VA: 0x1822448A0 Slot: 5
	protected override object CustomHandling(object leftOperand, object rightOperand) { }
}

// Namespace: Unity.VisualScripting
public sealed class InvalidOperatorException : OperatorException // TypeDefIndex: 9128
{
	// Methods

	// RVA: 0x224A6C0 Offset: 0x2248CC0 VA: 0x18224A6C0
	public void .ctor(string symbol, Type type) { }

	// RVA: 0x224A830 Offset: 0x2248E30 VA: 0x18224A830
	public void .ctor(string symbol, Type leftType, Type rightType) { }
}

// Namespace: Unity.VisualScripting
public class LeftShiftHandler : BinaryOperatorHandler // TypeDefIndex: 9130
{
	// Methods

	// RVA: 0x224AA20 Offset: 0x2249020 VA: 0x18224AA20
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class LessThanHandler : BinaryOperatorHandler // TypeDefIndex: 9132
{
	// Methods

	// RVA: 0x224CCA0 Offset: 0x224B2A0 VA: 0x18224CCA0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class LessThanOrEqualHandler : BinaryOperatorHandler // TypeDefIndex: 9134
{
	// Methods

	// RVA: 0x225B1E0 Offset: 0x22597E0 VA: 0x18225B1E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class LogicalNegationHandler : UnaryOperatorHandler // TypeDefIndex: 9136
{
	// Methods

	// RVA: 0x2260FB0 Offset: 0x225F5B0 VA: 0x182260FB0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class ModuloHandler : BinaryOperatorHandler // TypeDefIndex: 9138
{
	// Methods

	// RVA: 0x22617C0 Offset: 0x225FDC0 VA: 0x1822617C0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class MultiplicationHandler : BinaryOperatorHandler // TypeDefIndex: 9140
{
	// Methods

	// RVA: 0x2267590 Offset: 0x2265B90 VA: 0x182267590
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class NumericNegationHandler : UnaryOperatorHandler // TypeDefIndex: 9142
{
	// Methods

	// RVA: 0x226D370 Offset: 0x226B970 VA: 0x18226D370
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public abstract class OperatorException : InvalidCastException // TypeDefIndex: 9143
{
	// Methods

	// RVA: 0x2204400 Offset: 0x2202A00 VA: 0x182204400
	protected void .ctor() { }

	// RVA: 0x2204410 Offset: 0x2202A10 VA: 0x182204410
	protected void .ctor(string message) { }

	// RVA: 0x2204420 Offset: 0x2202A20 VA: 0x182204420
	protected void .ctor(string message, Exception innerException) { }
}

// Namespace: Unity.VisualScripting
public abstract class OperatorHandler // TypeDefIndex: 9144
{
	// Fields
	[CompilerGenerated]
	private readonly string <name>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <verb>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <symbol>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <customMethodName>k__BackingField; // 0x28

	// Properties
	public string name { get; }
	public string verb { get; }
	public string symbol { get; }
	public string customMethodName { get; }

	// Methods

	// RVA: 0x226DC50 Offset: 0x226C250 VA: 0x18226DC50
	protected void .ctor(string name, string verb, string symbol, string customMethodName) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_verb() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_symbol() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_customMethodName() { }
}

// Namespace: Unity.VisualScripting
[Extension]
public static class OperatorUtility // TypeDefIndex: 9145
{
	// Fields
	public static readonly Dictionary<string, string> operatorNames; // 0x0
	public static readonly Dictionary<string, int> operatorRanks; // 0x8
	private static readonly Dictionary<UnaryOperator, UnaryOperatorHandler> unaryOperatorHandlers; // 0x10
	private static readonly Dictionary<BinaryOperator, BinaryOperatorHandler> binaryOpeatorHandlers; // 0x18
	private static readonly LogicalNegationHandler logicalNegationHandler; // 0x20
	private static readonly NumericNegationHandler numericNegationHandler; // 0x28
	private static readonly IncrementHandler incrementHandler; // 0x30
	private static readonly DecrementHandler decrementHandler; // 0x38
	private static readonly PlusHandler plusHandler; // 0x40
	private static readonly AdditionHandler additionHandler; // 0x48
	private static readonly SubtractionHandler subtractionHandler; // 0x50
	private static readonly MultiplicationHandler multiplicationHandler; // 0x58
	private static readonly DivisionHandler divisionHandler; // 0x60
	private static readonly ModuloHandler moduloHandler; // 0x68
	private static readonly AndHandler andHandler; // 0x70
	private static readonly OrHandler orHandler; // 0x78
	private static readonly ExclusiveOrHandler exclusiveOrHandler; // 0x80
	private static readonly EqualityHandler equalityHandler; // 0x88
	private static readonly InequalityHandler inequalityHandler; // 0x90
	private static readonly GreaterThanHandler greaterThanHandler; // 0x98
	private static readonly LessThanHandler lessThanHandler; // 0xA0
	private static readonly GreaterThanOrEqualHandler greaterThanOrEqualHandler; // 0xA8
	private static readonly LessThanOrEqualHandler lessThanOrEqualHandler; // 0xB0
	private static readonly LeftShiftHandler leftShiftHandler; // 0xB8
	private static readonly RightShiftHandler rightShiftHandler; // 0xC0

	// Methods

	// RVA: 0x226F0F0 Offset: 0x226D6F0 VA: 0x18226F0F0
	private static void .cctor() { }

	// RVA: 0x226E230 Offset: 0x226C830 VA: 0x18226E230
	public static UnaryOperatorHandler GetHandler(UnaryOperator operator) { }

	// RVA: 0x226E110 Offset: 0x226C710 VA: 0x18226E110
	public static BinaryOperatorHandler GetHandler(BinaryOperator operator) { }

	[Extension]
	// RVA: 0x226EF00 Offset: 0x226D500 VA: 0x18226EF00
	public static string Symbol(UnaryOperator operator) { }

	[Extension]
	// RVA: 0x226EF60 Offset: 0x226D560 VA: 0x18226EF60
	public static string Symbol(BinaryOperator operator) { }

	[Extension]
	// RVA: 0x226E870 Offset: 0x226CE70 VA: 0x18226E870
	public static string Name(UnaryOperator operator) { }

	[Extension]
	// RVA: 0x226E8D0 Offset: 0x226CED0 VA: 0x18226E8D0
	public static string Name(BinaryOperator operator) { }

	[Extension]
	// RVA: 0x226F090 Offset: 0x226D690 VA: 0x18226F090
	public static string Verb(UnaryOperator operator) { }

	[Extension]
	// RVA: 0x226F030 Offset: 0x226D630 VA: 0x18226F030
	public static string Verb(BinaryOperator operator) { }

	// RVA: 0x226EAD0 Offset: 0x226D0D0 VA: 0x18226EAD0
	public static object Operate(UnaryOperator operator, object x) { }

	// RVA: 0x226EC00 Offset: 0x226D200 VA: 0x18226EC00
	public static object Operate(BinaryOperator operator, object a, object b) { }

	// RVA: 0x226E930 Offset: 0x226CF30 VA: 0x18226E930
	public static object Negate(object x) { }

	// RVA: 0x226EA60 Offset: 0x226D060 VA: 0x18226EA60
	public static object Not(object x) { }

	// RVA: 0x226EFC0 Offset: 0x226D5C0 VA: 0x18226EFC0
	public static object UnaryPlus(object x) { }

	// RVA: 0x226E4D0 Offset: 0x226CAD0 VA: 0x18226E4D0
	public static object Increment(object x) { }

	// RVA: 0x226DEC0 Offset: 0x226C4C0 VA: 0x18226DEC0
	public static object Decrement(object x) { }

	// RVA: 0x226DE30 Offset: 0x226C430 VA: 0x18226DE30
	public static object And(object a, object b) { }

	// RVA: 0x226ED50 Offset: 0x226D350 VA: 0x18226ED50
	public static object Or(object a, object b) { }

	// RVA: 0x226E080 Offset: 0x226C680 VA: 0x18226E080
	public static object ExclusiveOr(object a, object b) { }

	// RVA: 0x226DDA0 Offset: 0x226C3A0 VA: 0x18226DDA0
	public static object Add(object a, object b) { }

	// RVA: 0x226EE70 Offset: 0x226D470 VA: 0x18226EE70
	public static object Subtract(object a, object b) { }

	// RVA: 0x226E7E0 Offset: 0x226CDE0 VA: 0x18226E7E0
	public static object Multiply(object a, object b) { }

	// RVA: 0x226DF30 Offset: 0x226C530 VA: 0x18226DF30
	public static object Divide(object a, object b) { }

	// RVA: 0x226E750 Offset: 0x226CD50 VA: 0x18226E750
	public static object Modulo(object a, object b) { }

	// RVA: 0x226DFC0 Offset: 0x226C5C0 VA: 0x18226DFC0
	public static bool Equal(object a, object b) { }

	// RVA: 0x226E9A0 Offset: 0x226CFA0 VA: 0x18226E9A0
	public static bool NotEqual(object a, object b) { }

	// RVA: 0x226E410 Offset: 0x226CA10 VA: 0x18226E410
	public static bool GreaterThan(object a, object b) { }

	// RVA: 0x226E690 Offset: 0x226CC90 VA: 0x18226E690
	public static bool LessThan(object a, object b) { }

	// RVA: 0x226E350 Offset: 0x226C950 VA: 0x18226E350
	public static bool GreaterThanOrEqual(object a, object b) { }

	// RVA: 0x226E5D0 Offset: 0x226CBD0 VA: 0x18226E5D0
	public static bool LessThanOrEqual(object a, object b) { }

	// RVA: 0x226E540 Offset: 0x226CB40 VA: 0x18226E540
	public static object LeftShift(object a, object b) { }

	// RVA: 0x226EDE0 Offset: 0x226D3E0 VA: 0x18226EDE0
	public static object RightShift(object a, object b) { }
}

// Namespace: Unity.VisualScripting
public class OrHandler : BinaryOperatorHandler // TypeDefIndex: 9147
{
	// Methods

	// RVA: 0x2270870 Offset: 0x226EE70 VA: 0x182270870
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class PlusHandler : UnaryOperatorHandler // TypeDefIndex: 9149
{
	// Methods

	// RVA: 0x2273990 Offset: 0x2271F90 VA: 0x182273990
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class RightShiftHandler : BinaryOperatorHandler // TypeDefIndex: 9151
{
	// Methods

	// RVA: 0x2274330 Offset: 0x2272930 VA: 0x182274330
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class SubtractionHandler : BinaryOperatorHandler // TypeDefIndex: 9153
{
	// Methods

	// RVA: 0x228FFE0 Offset: 0x228E5E0 VA: 0x18228FFE0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public enum UnaryOperator // TypeDefIndex: 9154
{
	// Fields
	public int value__; // 0x0
	public const UnaryOperator LogicalNegation = 0;
	public const UnaryOperator NumericNegation = 1;
	public const UnaryOperator Increment = 2;
	public const UnaryOperator Decrement = 3;
	public const UnaryOperator Plus = 4;
}

// Namespace: Unity.VisualScripting
public abstract class UnaryOperatorHandler : OperatorHandler // TypeDefIndex: 9156
{
	// Fields
	private readonly Dictionary<Type, Func<object, object>> manualHandlers; // 0x30
	private readonly Dictionary<Type, IOptimizedInvoker> userDefinedOperators; // 0x38
	private readonly Dictionary<Type, Type> userDefinedOperandTypes; // 0x40

	// Methods

	// RVA: 0x22A0930 Offset: 0x229EF30 VA: 0x1822A0930
	protected void .ctor(string name, string verb, string symbol, string customMethodName) { }

	// RVA: 0x22A0510 Offset: 0x229EB10 VA: 0x1822A0510
	public object Operate(object operand) { }

	// RVA: 0x22A0490 Offset: 0x229EA90 VA: 0x1822A0490 Slot: 4
	protected virtual object CustomHandling(object operand) { }

	// RVA: -1 Offset: -1
	protected void Handle<T>(Func<T, object> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x804DA0 Offset: 0x8033A0 VA: 0x180804DA0
	|-UnaryOperatorHandler.Handle<bool>
	|-UnaryOperatorHandler.Handle<byte>
	|-UnaryOperatorHandler.Handle<Decimal>
	|-UnaryOperatorHandler.Handle<double>
	|-UnaryOperatorHandler.Handle<short>
	|-UnaryOperatorHandler.Handle<int>
	|-UnaryOperatorHandler.Handle<long>
	|-UnaryOperatorHandler.Handle<sbyte>
	|-UnaryOperatorHandler.Handle<float>
	|-UnaryOperatorHandler.Handle<ushort>
	|-UnaryOperatorHandler.Handle<uint>
	|-UnaryOperatorHandler.Handle<ulong>
	|
	|-RVA: 0x804ED0 Offset: 0x8034D0 VA: 0x180804ED0
	|-UnaryOperatorHandler.Handle<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22A08D0 Offset: 0x229EED0 VA: 0x1822A08D0
	private static Type ResolveUserDefinedOperandType(MethodInfo userDefinedOperator) { }
}

// Namespace: Unity.VisualScripting
public sealed class Action<T1, T2, T3, T4, T5> : MulticastDelegate // TypeDefIndex: 9157
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF28A90 Offset: 0xF27090 VA: 0x180F28A90
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D4690 Offset: 0x5D2C90 VA: 0x1805D4690
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF28890 Offset: 0xF26E90 VA: 0x180F28890
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Unity.VisualScripting
public sealed class Action<T1, T2, T3, T4, T5, T6> : MulticastDelegate // TypeDefIndex: 9158
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF28ED0 Offset: 0xF274D0 VA: 0x180F28ED0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3A50 Offset: 0x5E2050 VA: 0x1805E3A50
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF28CD0 Offset: 0xF272D0 VA: 0x180F28CD0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3462C0 Offset: 0x3448C0 VA: 0x1803462C0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Unity.VisualScripting
public sealed class Func<T1, T2, T3, T4, T5, TResult> : MulticastDelegate // TypeDefIndex: 9159
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101A190 Offset: 0x1018790 VA: 0x18101A190
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3A50 Offset: 0x5E2050 VA: 0x1805E3A50
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF28890 Offset: 0xF26E90 VA: 0x180F28890
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC05E00 Offset: 0xC04400 VA: 0x180C05E00
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Unity.VisualScripting
public sealed class Func<T1, T2, T3, T4, T5, T6, TResult> : MulticastDelegate // TypeDefIndex: 9160
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101A2B0 Offset: 0x10188B0 VA: 0x18101A2B0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF29110 Offset: 0xF27710 VA: 0x180F29110
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF28CD0 Offset: 0xF272D0 VA: 0x180F28CD0
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual TResult EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC05E00 Offset: 0xC04400 VA: 0x180C05E00
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: Unity.VisualScripting
public abstract class InstanceActionInvokerBase<TTarget> : InstanceInvokerBase<TTarget> // TypeDefIndex: 9161
{
	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceActionInvokerBase<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceActionInvoker<TTarget> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 9162
{
	// Fields
	private Action<TTarget> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5EF0 Offset: 0x9B44F0 VA: 0x1809B5EF0
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override object Invoke(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7590 Offset: 0x10B5B90 VA: 0x1810B7590
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	private object InvokeUnsafe(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B74A0 Offset: 0x10B5AA0 VA: 0x1810B74A0
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5C70 Offset: 0x9B4270 VA: 0x1809B5C70
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7280 Offset: 0x10B5880 VA: 0x1810B7280
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7360 Offset: 0x10B5960 VA: 0x1810B7360
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceActionInvoker<TTarget, TParam0> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 9163
{
	// Fields
	private Action<TTarget, TParam0> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1360 Offset: 0x9AF960 VA: 0x1809B1360
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override object Invoke(object target, object arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7BA0 Offset: 0x10B61A0 VA: 0x1810B7BA0
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	private object InvokeUnsafe(object target, object arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7A10 Offset: 0x10B6010 VA: 0x1810B7A10
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7940 Offset: 0x10B5F40 VA: 0x1810B7940
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7720 Offset: 0x10B5D20 VA: 0x1810B7720
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7800 Offset: 0x10B5E00 VA: 0x1810B7800
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 9164
{
	// Fields
	private Action<TTarget, TParam0, TParam1> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1BD0 Offset: 0x9B01D0 VA: 0x1809B1BD0
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override object Invoke(object target, object arg0, object arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B82F0 Offset: 0x10B68F0 VA: 0x1810B82F0
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B80D0 Offset: 0x10B66D0 VA: 0x1810B80D0
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7F90 Offset: 0x10B6590 VA: 0x1810B7F90
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7D70 Offset: 0x10B6370 VA: 0x1810B7D70
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B7E50 Offset: 0x10B6450 VA: 0x1810B7E50
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 9165
{
	// Fields
	private Action<TTarget, TParam0, TParam1, TParam2> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2630 Offset: 0x9B0C30 VA: 0x1809B2630
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override object Invoke(object target, object arg0, object arg1, object arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B8B90 Offset: 0x10B7190 VA: 0x1810B8B90
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B88E0 Offset: 0x10B6EE0 VA: 0x1810B88E0
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B8740 Offset: 0x10B6D40 VA: 0x1810B8740
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B8520 Offset: 0x10B6B20 VA: 0x1810B8520
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B8600 Offset: 0x10B6C00 VA: 0x1810B8600
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 9166
{
	// Fields
	private Action<TTarget, TParam0, TParam1, TParam2, TParam3> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B3560 Offset: 0x9B1B60 VA: 0x1809B3560
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public override object Invoke(object target, object arg0, object arg1, object arg2, object arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B9590 Offset: 0x10B7B90 VA: 0x1810B9590
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B9250 Offset: 0x10B7850 VA: 0x1810B9250
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B9040 Offset: 0x10B7640 VA: 0x1810B9040
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B8E20 Offset: 0x10B7420 VA: 0x1810B8E20
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B8F00 Offset: 0x10B7500 VA: 0x1810B8F00
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 9167
{
	// Fields
	private Action<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B4420 Offset: 0x9B2A20 VA: 0x1809B4420
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public override object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BA0E0 Offset: 0x10B86E0 VA: 0x1810BA0E0
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B9D00 Offset: 0x10B8300 VA: 0x1810B9D00
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B9A90 Offset: 0x10B8090 VA: 0x1810B9A90
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B9870 Offset: 0x10B7E70 VA: 0x1810B9870
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10B9950 Offset: 0x10B7F50 VA: 0x1810B9950
	|-InstanceActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public class InstanceFieldAccessor<TTarget, TField> : IOptimizedAccessor // TypeDefIndex: 9168
{
	// Fields
	private readonly FieldInfo fieldInfo; // 0x0
	private Func<TTarget, TField> getter; // 0x0
	private Action<TTarget, TField> setter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BB580 Offset: 0x10B9B80 VA: 0x1810BB580
	|-InstanceFieldAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Compile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BA420 Offset: 0x10B8A20 VA: 0x1810BA420
	|-InstanceFieldAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Compile
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object GetValue(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BAAB0 Offset: 0x10B90B0 VA: 0x1810BAAB0
	|-InstanceFieldAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1
	private object GetValueUnsafe(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BA950 Offset: 0x10B8F50 VA: 0x1810BA950
	|-InstanceFieldAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValueUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void SetValue(object target, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BAE10 Offset: 0x10B9410 VA: 0x1810BAE10
	|-InstanceFieldAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1
	private void SetValueUnsafe(object target, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BAC60 Offset: 0x10B9260 VA: 0x1810BAC60
	|-InstanceFieldAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetValueUnsafe
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private TField <Compile>b__4_0(TTarget instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BB280 Offset: 0x10B9880 VA: 0x1810BB280
	|-InstanceFieldAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<Compile>b__4_0
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <Compile>b__4_1(TTarget instance, TField value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BB400 Offset: 0x10B9A00 VA: 0x1810BB400
	|-InstanceFieldAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<Compile>b__4_1
	*/
}

// Namespace: Unity.VisualScripting
public abstract class InstanceFunctionInvokerBase<TTarget, TResult> : InstanceInvokerBase<TTarget> // TypeDefIndex: 9169
{
	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BB880 Offset: 0x10B9E80 VA: 0x1810BB880
	|-InstanceFunctionInvokerBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceFunctionInvoker<TTarget, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 9170
{
	// Fields
	private Func<TTarget, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5EF0 Offset: 0x9B44F0 VA: 0x1809B5EF0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override object Invoke(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BBD60 Offset: 0x10BA360 VA: 0x1810BBD60
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BBC10 Offset: 0x10BA210 VA: 0x1810BBC10
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5C70 Offset: 0x9B4270 VA: 0x1809B5C70
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BB9F0 Offset: 0x10B9FF0 VA: 0x1810BB9F0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BBAD0 Offset: 0x10BA0D0 VA: 0x1810BBAD0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceFunctionInvoker<TTarget, TParam0, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 9171
{
	// Fields
	private Func<TTarget, TParam0, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1360 Offset: 0x9AF960 VA: 0x1809B1360
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override object Invoke(object target, object arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BC3C0 Offset: 0x10BA9C0 VA: 0x1810BC3C0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BC1E0 Offset: 0x10BA7E0 VA: 0x1810BC1E0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BC110 Offset: 0x10BA710 VA: 0x1810BC110
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BBEF0 Offset: 0x10BA4F0 VA: 0x1810BBEF0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BBFD0 Offset: 0x10BA5D0 VA: 0x1810BBFD0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 9172
{
	// Fields
	private Func<TTarget, TParam0, TParam1, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1BD0 Offset: 0x9B01D0 VA: 0x1809B1BD0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override object Invoke(object target, object arg0, object arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BCB60 Offset: 0x10BB160 VA: 0x1810BCB60
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BC8F0 Offset: 0x10BAEF0 VA: 0x1810BC8F0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BC7B0 Offset: 0x10BADB0 VA: 0x1810BC7B0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BC590 Offset: 0x10BAB90 VA: 0x1810BC590
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BC670 Offset: 0x10BAC70 VA: 0x1810BC670
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 9173
{
	// Fields
	private Func<TTarget, TParam0, TParam1, TParam2, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2630 Offset: 0x9B0C30 VA: 0x1809B2630
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override object Invoke(object target, object arg0, object arg1, object arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BD460 Offset: 0x10BBA60 VA: 0x1810BD460
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BD150 Offset: 0x10BB750 VA: 0x1810BD150
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BCFB0 Offset: 0x10BB5B0 VA: 0x1810BCFB0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BCD90 Offset: 0x10BB390 VA: 0x1810BCD90
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BCE70 Offset: 0x10BB470 VA: 0x1810BCE70
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 9174
{
	// Fields
	private Func<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B3560 Offset: 0x9B1B60 VA: 0x1809B3560
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public override object Invoke(object target, object arg0, object arg1, object arg2, object arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BDEC0 Offset: 0x10BC4C0 VA: 0x1810BDEC0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BDB20 Offset: 0x10BC120 VA: 0x1810BDB20
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BD910 Offset: 0x10BBF10 VA: 0x1810BD910
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BD6F0 Offset: 0x10BBCF0 VA: 0x1810BD6F0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BD7D0 Offset: 0x10BBDD0 VA: 0x1810BD7D0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 9175
{
	// Fields
	private Func<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B4420 Offset: 0x9B2A20 VA: 0x1809B4420
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public override object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BEA70 Offset: 0x10BD070 VA: 0x1810BEA70
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BE630 Offset: 0x10BCC30 VA: 0x1810BE630
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BE3C0 Offset: 0x10BC9C0 VA: 0x1810BE3C0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BE1A0 Offset: 0x10BC7A0 VA: 0x1810BE1A0
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BE280 Offset: 0x10BC880 VA: 0x1810BE280
	|-InstanceFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/
}

// Namespace: Unity.VisualScripting
public abstract class InstanceInvokerBase<TTarget> : InvokerBase // TypeDefIndex: 9176
{
	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BEFC0 Offset: 0x10BD5C0 VA: 0x1810BEFC0
	|-InstanceInvokerBase<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	protected sealed override void CompileExpression() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BEDB0 Offset: 0x10BD3B0 VA: 0x1810BEDB0
	|-InstanceInvokerBase<__Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-InstanceInvokerBase<__Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 22
	protected override void VerifyTarget(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BEF50 Offset: 0x10BD550 VA: 0x1810BEF50
	|-InstanceInvokerBase<__Il2CppFullySharedGenericType>.VerifyTarget
	*/
}

// Namespace: Unity.VisualScripting
public class InstancePropertyAccessor<TTarget, TProperty> : IOptimizedAccessor // TypeDefIndex: 9177
{
	// Fields
	private readonly PropertyInfo propertyInfo; // 0x0
	private Func<TTarget, TProperty> getter; // 0x0
	private Action<TTarget, TProperty> setter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10C00C0 Offset: 0x10BE6C0 VA: 0x1810C00C0
	|-InstancePropertyAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Compile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BF190 Offset: 0x10BD790 VA: 0x1810BF190
	|-InstancePropertyAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Compile
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object GetValue(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BF880 Offset: 0x10BDE80 VA: 0x1810BF880
	|-InstancePropertyAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1
	private object GetValueUnsafe(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BF730 Offset: 0x10BDD30 VA: 0x1810BF730
	|-InstancePropertyAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValueUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void SetValue(object target, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BFC60 Offset: 0x10BE260 VA: 0x1810BFC60
	|-InstancePropertyAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1
	private void SetValueUnsafe(object target, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10BFAC0 Offset: 0x10BE0C0 VA: 0x1810BFAC0
	|-InstancePropertyAccessor<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetValueUnsafe
	*/
}

// Namespace: Unity.VisualScripting
public abstract class InvokerBase : IOptimizedInvoker // TypeDefIndex: 9178
{
	// Fields
	protected readonly Type targetType; // 0x10
	protected readonly MethodInfo methodInfo; // 0x18

	// Methods

	// RVA: 0x2280ED0 Offset: 0x227F4D0 VA: 0x182280ED0
	protected void .ctor(MethodInfo methodInfo) { }

	// RVA: -1 Offset: -1
	protected void VerifyArgument<TParam>(MethodInfo methodInfo, int argIndex, object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x70FDE0 Offset: 0x70E3E0 VA: 0x18070FDE0
	|-InvokerBase.VerifyArgument<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2280950 Offset: 0x227EF50 VA: 0x182280950 Slot: 4
	public void Compile() { }

	// RVA: 0x2280A60 Offset: 0x227F060 VA: 0x182280A60
	protected ParameterExpression[] GetParameterExpressions() { }

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract Type[] GetParameterTypes();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract object Invoke(object target, object[] args);

	// RVA: 0x2280E10 Offset: 0x227F410 VA: 0x182280E10 Slot: 14
	public virtual object Invoke(object target) { }

	// RVA: 0x2280E90 Offset: 0x227F490 VA: 0x182280E90 Slot: 15
	public virtual object Invoke(object target, object arg0) { }

	// RVA: 0x2280E50 Offset: 0x227F450 VA: 0x182280E50 Slot: 16
	public virtual object Invoke(object target, object arg0, object arg1) { }

	// RVA: 0x2280D90 Offset: 0x227F390 VA: 0x182280D90 Slot: 17
	public virtual object Invoke(object target, object arg0, object arg1, object arg2) { }

	// RVA: 0x2280DD0 Offset: 0x227F3D0 VA: 0x182280DD0 Slot: 18
	public virtual object Invoke(object target, object arg0, object arg1, object arg2, object arg3) { }

	// RVA: 0x2280D50 Offset: 0x227F350 VA: 0x182280D50 Slot: 19
	public virtual object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void CompileExpression();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void CreateDelegate();

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void VerifyTarget(object target);
}

// Namespace: Unity.VisualScripting
public interface IOptimizedAccessor // TypeDefIndex: 9179
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Compile();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object GetValue(object target);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetValue(object target, object value);
}

// Namespace: Unity.VisualScripting
public interface IOptimizedInvoker // TypeDefIndex: 9180
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Compile();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object Invoke(object target);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object Invoke(object target, object arg0);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract object Invoke(object target, object arg0, object arg1);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object Invoke(object target, object arg0, object arg1, object arg2);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object Invoke(object target, object arg0, object arg1, object arg2, object arg3);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract object Invoke(object target, object[] args);
}

// Namespace: Unity.VisualScripting
[Extension]
public static class OptimizedReflection // TypeDefIndex: 9182
{
	// Fields
	private static readonly Dictionary<FieldInfo, IOptimizedAccessor> fieldAccessors; // 0x0
	private static readonly Dictionary<PropertyInfo, IOptimizedAccessor> propertyAccessors; // 0x8
	private static readonly Dictionary<MethodInfo, IOptimizedInvoker> methodInvokers; // 0x10
	public static readonly bool jitAvailable; // 0x18
	private static bool _useJitIfAvailable; // 0x19
	[CompilerGenerated]
	private static bool <safeMode>k__BackingField; // 0x1A

	// Properties
	internal static bool useJit { get; }
	public static bool useJitIfAvailable { get; set; }
	public static bool safeMode { get; set; }

	// Methods

	// RVA: 0x2287870 Offset: 0x2285E70 VA: 0x182287870
	private static void .cctor() { }

	// RVA: 0x2287AC0 Offset: 0x22860C0 VA: 0x182287AC0
	internal static bool get_useJit() { }

	// RVA: 0x2287A70 Offset: 0x2286070 VA: 0x182287A70
	public static bool get_useJitIfAvailable() { }

	// RVA: 0x2287BD0 Offset: 0x22861D0 VA: 0x182287BD0
	public static void set_useJitIfAvailable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2287A20 Offset: 0x2286020 VA: 0x182287A20
	public static bool get_safeMode() { }

	[CompilerGenerated]
	// RVA: 0x2287B70 Offset: 0x2286170 VA: 0x182287B70
	public static void set_safeMode(bool value) { }

	// RVA: 0x2286E60 Offset: 0x2285460 VA: 0x182286E60
	internal static void OnRuntimeMethodLoad() { }

	// RVA: 0x2281EB0 Offset: 0x22804B0 VA: 0x182281EB0
	public static void ClearCache() { }

	// RVA: 0x2287600 Offset: 0x2285C00 VA: 0x182287600
	internal static void VerifyStaticTarget(Type targetType, object target) { }

	// RVA: -1 Offset: -1
	internal static void VerifyInstanceTarget<TTArget>(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x73A530 Offset: 0x738B30 VA: 0x18073A530
	|-OptimizedReflection.VerifyInstanceTarget<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2287660 Offset: 0x2285C60 VA: 0x182287660
	private static void VerifyTarget(Type targetType, object target, bool static) { }

	// RVA: 0x2287190 Offset: 0x2285790 VA: 0x182287190
	private static bool SupportsOptimization(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x2286F60 Offset: 0x2285560 VA: 0x182286F60
	public static IOptimizedAccessor Prewarm(FieldInfo fieldInfo) { }

	[Extension]
	// RVA: 0x22866D0 Offset: 0x2284CD0 VA: 0x1822866D0
	public static object GetValueOptimized(FieldInfo fieldInfo, object target) { }

	[Extension]
	// RVA: 0x2287050 Offset: 0x2285650 VA: 0x182287050
	public static void SetValueOptimized(FieldInfo fieldInfo, object target, object value) { }

	[Extension]
	// RVA: 0x2287540 Offset: 0x2285B40 VA: 0x182287540
	public static bool SupportsOptimization(FieldInfo fieldInfo) { }

	// RVA: 0x2281F80 Offset: 0x2280580 VA: 0x182281F80
	private static IOptimizedAccessor GetFieldAccessor(FieldInfo fieldInfo) { }

	[Extension]
	// RVA: 0x2286FB0 Offset: 0x22855B0 VA: 0x182286FB0
	public static IOptimizedAccessor Prewarm(PropertyInfo propertyInfo) { }

	[Extension]
	// RVA: 0x2286760 Offset: 0x2284D60 VA: 0x182286760
	public static object GetValueOptimized(PropertyInfo propertyInfo, object target) { }

	[Extension]
	// RVA: 0x22870F0 Offset: 0x22856F0 VA: 0x1822870F0
	public static void SetValueOptimized(PropertyInfo propertyInfo, object target, object value) { }

	[Extension]
	// RVA: 0x2287480 Offset: 0x2285A80 VA: 0x182287480
	public static bool SupportsOptimization(PropertyInfo propertyInfo) { }

	// RVA: 0x2285F50 Offset: 0x2284550 VA: 0x182285F50
	private static IOptimizedAccessor GetPropertyAccessor(PropertyInfo propertyInfo) { }

	[Extension]
	// RVA: 0x2287000 Offset: 0x2285600 VA: 0x182287000
	public static IOptimizedInvoker Prewarm(MethodInfo methodInfo) { }

	[Extension]
	// RVA: 0x2286A30 Offset: 0x2285030 VA: 0x182286A30
	public static object InvokeOptimized(MethodInfo methodInfo, object target, object[] args) { }

	[Extension]
	// RVA: 0x22869A0 Offset: 0x2284FA0 VA: 0x1822869A0
	public static object InvokeOptimized(MethodInfo methodInfo, object target) { }

	[Extension]
	// RVA: 0x2286900 Offset: 0x2284F00 VA: 0x182286900
	public static object InvokeOptimized(MethodInfo methodInfo, object target, object arg0) { }

	[Extension]
	// RVA: 0x22867F0 Offset: 0x2284DF0 VA: 0x1822867F0
	public static object InvokeOptimized(MethodInfo methodInfo, object target, object arg0, object arg1) { }

	[Extension]
	// RVA: 0x2286C40 Offset: 0x2285240 VA: 0x182286C40
	public static object InvokeOptimized(MethodInfo methodInfo, object target, object arg0, object arg1, object arg2) { }

	[Extension]
	// RVA: 0x2286D50 Offset: 0x2285350 VA: 0x182286D50
	public static object InvokeOptimized(MethodInfo methodInfo, object target, object arg0, object arg1, object arg2, object arg3) { }

	[Extension]
	// RVA: 0x2286B30 Offset: 0x2285130 VA: 0x182286B30
	public static object InvokeOptimized(MethodInfo methodInfo, object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }

	[Extension]
	// RVA: 0x2287220 Offset: 0x2285820 VA: 0x182287220
	public static bool SupportsOptimization(MethodInfo methodInfo) { }

	// RVA: 0x22826D0 Offset: 0x2280CD0 VA: 0x1822826D0
	private static IOptimizedInvoker GetMethodInvoker(MethodInfo methodInfo) { }
}

// Namespace: Unity.VisualScripting
public sealed class ReflectionFieldAccessor : IOptimizedAccessor // TypeDefIndex: 9183
{
	// Fields
	private readonly FieldInfo fieldInfo; // 0x10

	// Methods

	// RVA: 0x2288660 Offset: 0x2286C60 VA: 0x182288660
	public void .ctor(FieldInfo fieldInfo) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void Compile() { }

	// RVA: 0x86F3B0 Offset: 0x86D9B0 VA: 0x18086F3B0 Slot: 5
	public object GetValue(object target) { }

	// RVA: 0x8701E0 Offset: 0x86E7E0 VA: 0x1808701E0 Slot: 6
	public void SetValue(object target, object value) { }
}

// Namespace: Unity.VisualScripting
public class ReflectionInvoker : IOptimizedInvoker // TypeDefIndex: 9185
{
	// Fields
	private readonly MethodInfo methodInfo; // 0x10
	private static readonly object[] EmptyObjects; // 0x0

	// Methods

	// RVA: 0x2289150 Offset: 0x2287750 VA: 0x182289150
	public void .ctor(MethodInfo methodInfo) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void Compile() { }

	// RVA: 0x2288C20 Offset: 0x2287220 VA: 0x182288C20 Slot: 11
	public object Invoke(object target, object[] args) { }

	// RVA: 0x2289060 Offset: 0x2287660 VA: 0x182289060 Slot: 5
	public object Invoke(object target) { }

	// RVA: 0x2288F90 Offset: 0x2287590 VA: 0x182288F90 Slot: 6
	public object Invoke(object target, object arg0) { }

	// RVA: 0x22888D0 Offset: 0x2286ED0 VA: 0x1822888D0 Slot: 7
	public object Invoke(object target, object arg0, object arg1) { }

	// RVA: 0x2288C40 Offset: 0x2287240 VA: 0x182288C40 Slot: 8
	public object Invoke(object target, object arg0, object arg1, object arg2) { }

	// RVA: 0x2288DC0 Offset: 0x22873C0 VA: 0x182288DC0 Slot: 9
	public object Invoke(object target, object arg0, object arg1, object arg2, object arg3) { }

	// RVA: 0x2288A00 Offset: 0x2287000 VA: 0x182288A00 Slot: 10
	public object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }

	// RVA: 0x2288770 Offset: 0x2286D70 VA: 0x182288770
	public Type[] GetParameterTypes() { }

	// RVA: 0x22890E0 Offset: 0x22876E0 VA: 0x1822890E0
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public sealed class ReflectionPropertyAccessor : IOptimizedAccessor // TypeDefIndex: 9186
{
	// Fields
	private readonly PropertyInfo propertyInfo; // 0x10

	// Methods

	// RVA: 0x2289260 Offset: 0x2287860 VA: 0x182289260
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 4
	public void Compile() { }

	// RVA: 0x86ECF0 Offset: 0x86D2F0 VA: 0x18086ECF0 Slot: 5
	public object GetValue(object target) { }

	// RVA: 0x8742A0 Offset: 0x8728A0 VA: 0x1808742A0 Slot: 6
	public void SetValue(object target, object value) { }
}

// Namespace: Unity.VisualScripting
public abstract class StaticActionInvokerBase : StaticInvokerBase // TypeDefIndex: 9187
{
	// Methods

	// RVA: 0x228F660 Offset: 0x228DC60 VA: 0x18228F660
	protected void .ctor(MethodInfo methodInfo) { }
}

// Namespace: Unity.VisualScripting
public sealed class StaticActionInvoker : StaticActionInvokerBase // TypeDefIndex: 9188
{
	// Fields
	private Action invoke; // 0x20

	// Methods

	// RVA: 0x228F660 Offset: 0x228DC60 VA: 0x18228F660
	public void .ctor(MethodInfo methodInfo) { }

	// RVA: 0x228F7D0 Offset: 0x228DDD0 VA: 0x18228F7D0 Slot: 13
	public override object Invoke(object target, object[] args) { }

	// RVA: 0x228F840 Offset: 0x228DE40 VA: 0x18228F840 Slot: 14
	public override object Invoke(object target) { }

	// RVA: 0x228F7A0 Offset: 0x228DDA0 VA: 0x18228F7A0
	private object InvokeUnsafe(object target) { }

	// RVA: 0x9B5C70 Offset: 0x9B4270 VA: 0x1809B5C70 Slot: 12
	protected override Type[] GetParameterTypes() { }

	// RVA: 0x228F670 Offset: 0x228DC70 VA: 0x18228F670 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }

	// RVA: 0x228F720 Offset: 0x228DD20 VA: 0x18228F720 Slot: 21
	protected override void CreateDelegate() { }

	[CompilerGenerated]
	// RVA: 0x228F990 Offset: 0x228DF90 VA: 0x18228F990
	private void <CreateDelegate>b__7_0() { }
}

// Namespace: Unity.VisualScripting
public sealed class StaticActionInvoker<TParam0> : StaticActionInvokerBase // TypeDefIndex: 9189
{
	// Fields
	private Action<TParam0> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1790 Offset: 0x9AFD90 VA: 0x1809B1790
	|-StaticActionInvoker<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1360 Offset: 0x9AF960 VA: 0x1809B1360
	|-StaticActionInvoker<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override object Invoke(object target, object arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B13E0 Offset: 0x9AF9E0 VA: 0x1809B13E0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	private object InvokeUnsafe(object target, object arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1270 Offset: 0x9AF870 VA: 0x1809B1270
	|-StaticActionInvoker<__Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B11A0 Offset: 0x9AF7A0 VA: 0x1809B11A0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1040 Offset: 0x9AF640 VA: 0x1809B1040
	|-StaticActionInvoker<__Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1120 Offset: 0x9AF720 VA: 0x1809B1120
	|-StaticActionInvoker<__Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <CreateDelegate>b__7_0(TParam0 param0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B15B0 Offset: 0x9AFBB0 VA: 0x1809B15B0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public sealed class StaticActionInvoker<TParam0, TParam1> : StaticActionInvokerBase // TypeDefIndex: 9190
{
	// Fields
	private Action<TParam0, TParam1> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1790 Offset: 0x9AFD90 VA: 0x1809B1790
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1BD0 Offset: 0x9B01D0 VA: 0x1809B1BD0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override object Invoke(object target, object arg0, object arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1C70 Offset: 0x9B0270 VA: 0x1809B1C70
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1A40 Offset: 0x9B0040 VA: 0x1809B1A40
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1900 Offset: 0x9AFF00 VA: 0x1809B1900
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B17A0 Offset: 0x9AFDA0 VA: 0x1809B17A0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1880 Offset: 0x9AFE80 VA: 0x1809B1880
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1EA0 Offset: 0x9B04A0 VA: 0x1809B1EA0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public sealed class StaticActionInvoker<TParam0, TParam1, TParam2> : StaticActionInvokerBase // TypeDefIndex: 9191
{
	// Fields
	private Action<TParam0, TParam1, TParam2> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1790 Offset: 0x9AFD90 VA: 0x1809B1790
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2630 Offset: 0x9B0C30 VA: 0x1809B2630
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override object Invoke(object target, object arg0, object arg1, object arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B26E0 Offset: 0x9B0CE0 VA: 0x1809B26E0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2410 Offset: 0x9B0A10 VA: 0x1809B2410
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2270 Offset: 0x9B0870 VA: 0x1809B2270
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2100 Offset: 0x9B0700 VA: 0x1809B2100
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B21E0 Offset: 0x9B07E0 VA: 0x1809B21E0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2960 Offset: 0x9B0F60 VA: 0x1809B2960
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3> : StaticActionInvokerBase // TypeDefIndex: 9192
{
	// Fields
	private Action<TParam0, TParam1, TParam2, TParam3> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1790 Offset: 0x9AFD90 VA: 0x1809B1790
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B3560 Offset: 0x9B1B60 VA: 0x1809B3560
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public override object Invoke(object target, object arg0, object arg1, object arg2, object arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B3280 Offset: 0x9B1880 VA: 0x1809B3280
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2FD0 Offset: 0x9B15D0 VA: 0x1809B2FD0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2DD0 Offset: 0x9B13D0 VA: 0x1809B2DD0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2C60 Offset: 0x9B1260 VA: 0x1809B2C60
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2D40 Offset: 0x9B1340 VA: 0x1809B2D40
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B3620 Offset: 0x9B1C20 VA: 0x1809B3620
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4> : StaticActionInvokerBase // TypeDefIndex: 9193
{
	// Fields
	private Action<TParam0, TParam1, TParam2, TParam3, TParam4> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1790 Offset: 0x9AFD90 VA: 0x1809B1790
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B4420 Offset: 0x9B2A20 VA: 0x1809B4420
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public override object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B40E0 Offset: 0x9B26E0 VA: 0x1809B40E0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B3DA0 Offset: 0x9B23A0 VA: 0x1809B3DA0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B3B30 Offset: 0x9B2130 VA: 0x1809B3B30
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B39C0 Offset: 0x9B1FC0 VA: 0x1809B39C0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B3AA0 Offset: 0x9B20A0 VA: 0x1809B3AA0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B44F0 Offset: 0x9B2AF0 VA: 0x1809B44F0
	|-StaticActionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public class StaticFieldAccessor<TField> : IOptimizedAccessor // TypeDefIndex: 9195
{
	// Fields
	private readonly FieldInfo fieldInfo; // 0x0
	private Func<TField> getter; // 0x0
	private Action<TField> setter; // 0x0
	private Type targetType; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5730 Offset: 0x9B3D30 VA: 0x1809B5730
	|-StaticFieldAccessor<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Compile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B4930 Offset: 0x9B2F30 VA: 0x1809B4930
	|-StaticFieldAccessor<__Il2CppFullySharedGenericType>.Compile
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object GetValue(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B4EE0 Offset: 0x9B34E0 VA: 0x1809B4EE0
	|-StaticFieldAccessor<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1
	private object GetValueUnsafe(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B4E30 Offset: 0x9B3430 VA: 0x1809B4E30
	|-StaticFieldAccessor<__Il2CppFullySharedGenericType>.GetValueUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void SetValue(object target, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5170 Offset: 0x9B3770 VA: 0x1809B5170
	|-StaticFieldAccessor<__Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1
	private void SetValueUnsafe(object target, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5080 Offset: 0x9B3680 VA: 0x1809B5080
	|-StaticFieldAccessor<__Il2CppFullySharedGenericType>.SetValueUnsafe
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private TField <Compile>b__5_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5580 Offset: 0x9B3B80 VA: 0x1809B5580
	|-StaticFieldAccessor<__Il2CppFullySharedGenericType>.<Compile>b__5_0
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <Compile>b__5_1(TField value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5660 Offset: 0x9B3C60 VA: 0x1809B5660
	|-StaticFieldAccessor<__Il2CppFullySharedGenericType>.<Compile>b__5_1
	*/
}

// Namespace: Unity.VisualScripting
public abstract class StaticFunctionInvokerBase<TResult> : StaticInvokerBase // TypeDefIndex: 9196
{
	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B59A0 Offset: 0x9B3FA0 VA: 0x1809B59A0
	|-StaticFunctionInvokerBase<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.VisualScripting
public sealed class StaticFunctionInvoker<TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 9197
{
	// Fields
	private Func<TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5EF0 Offset: 0x9B44F0 VA: 0x1809B5EF0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override object Invoke(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5D60 Offset: 0x9B4360 VA: 0x1809B5D60
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5CB0 Offset: 0x9B42B0 VA: 0x1809B5CB0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5C70 Offset: 0x9B4270 VA: 0x1809B5C70
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5B10 Offset: 0x9B4110 VA: 0x1809B5B10
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5BF0 Offset: 0x9B41F0 VA: 0x1809B5BF0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private TResult <CreateDelegate>b__7_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B5F60 Offset: 0x9B4560 VA: 0x1809B5F60
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public sealed class StaticFunctionInvoker<TParam0, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 9198
{
	// Fields
	private Func<TParam0, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1360 Offset: 0x9AF960 VA: 0x1809B1360
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override object Invoke(object target, object arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B64A0 Offset: 0x9B4AA0 VA: 0x1809B64A0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6350 Offset: 0x9B4950 VA: 0x1809B6350
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6280 Offset: 0x9B4880 VA: 0x1809B6280
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6120 Offset: 0x9B4720 VA: 0x1809B6120
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6200 Offset: 0x9B4800 VA: 0x1809B6200
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private TResult <CreateDelegate>b__7_0(TParam0 param0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6670 Offset: 0x9B4C70 VA: 0x1809B6670
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public sealed class StaticFunctionInvoker<TParam0, TParam1, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 9199
{
	// Fields
	private Func<TParam0, TParam1, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B1BD0 Offset: 0x9B01D0 VA: 0x1809B1BD0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override object Invoke(object target, object arg0, object arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6D30 Offset: 0x9B5330 VA: 0x1809B6D30
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6B50 Offset: 0x9B5150 VA: 0x1809B6B50
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6A10 Offset: 0x9B5010 VA: 0x1809B6A10
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B68A0 Offset: 0x9B4EA0 VA: 0x1809B68A0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6980 Offset: 0x9B4F80 VA: 0x1809B6980
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6F60 Offset: 0x9B5560 VA: 0x1809B6F60
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 9200
{
	// Fields
	private Func<TParam0, TParam1, TParam2, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B2630 Offset: 0x9B0C30 VA: 0x1809B2630
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public override object Invoke(object target, object arg0, object arg1, object arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B77A0 Offset: 0x9B5DA0 VA: 0x1809B77A0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B7530 Offset: 0x9B5B30 VA: 0x1809B7530
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B7390 Offset: 0x9B5990 VA: 0x1809B7390
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B7220 Offset: 0x9B5820 VA: 0x1809B7220
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B7300 Offset: 0x9B5900 VA: 0x1809B7300
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B7A30 Offset: 0x9B6030 VA: 0x1809B7A30
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 9201
{
	// Fields
	private Func<TParam0, TParam1, TParam2, TParam3, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B3560 Offset: 0x9B1B60 VA: 0x1809B3560
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public override object Invoke(object target, object arg0, object arg1, object arg2, object arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B8410 Offset: 0x9B6A10 VA: 0x1809B8410
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B8110 Offset: 0x9B6710 VA: 0x1809B8110
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B7F00 Offset: 0x9B6500 VA: 0x1809B7F00
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B7D90 Offset: 0x9B6390 VA: 0x1809B7D90
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B7E70 Offset: 0x9B6470 VA: 0x1809B7E70
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B86F0 Offset: 0x9B6CF0 VA: 0x1809B86F0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 9202
{
	// Fields
	private Func<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MethodInfo methodInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override object Invoke(object target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B4420 Offset: 0x9B2A20 VA: 0x1809B4420
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public override object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B9270 Offset: 0x9B7870 VA: 0x1809B9270
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3, object arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B8ED0 Offset: 0x9B74D0 VA: 0x1809B8ED0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override Type[] GetParameterTypes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B8C60 Offset: 0x9B7260 VA: 0x1809B8C60
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetParameterTypes
	*/

	// RVA: -1 Offset: -1 Slot: 23
	protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B8AF0 Offset: 0x9B70F0 VA: 0x1809B8AF0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CompileExpression
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected override void CreateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B8BD0 Offset: 0x9B71D0 VA: 0x1809B8BD0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDelegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B95B0 Offset: 0x9B7BB0 VA: 0x1809B95B0
	|-StaticFunctionInvoker<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateDelegate>b__7_0
	*/
}

// Namespace: Unity.VisualScripting
public abstract class StaticInvokerBase : InvokerBase // TypeDefIndex: 9203
{
	// Methods

	// RVA: 0x228FB90 Offset: 0x228E190 VA: 0x18228FB90
	protected void .ctor(MethodInfo methodInfo) { }

	// RVA: 0x228FA60 Offset: 0x228E060 VA: 0x18228FA60 Slot: 20
	protected sealed override void CompileExpression() { }

	// RVA: -1 Offset: -1 Slot: 23
	protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);

	// RVA: 0x228FAF0 Offset: 0x228E0F0 VA: 0x18228FAF0 Slot: 22
	protected override void VerifyTarget(object target) { }
}

// Namespace: Unity.VisualScripting
public class StaticPropertyAccessor<TProperty> : IOptimizedAccessor // TypeDefIndex: 9204
{
	// Fields
	private readonly PropertyInfo propertyInfo; // 0x0
	private Func<TProperty> getter; // 0x0
	private Action<TProperty> setter; // 0x0
	private Type targetType; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9BA780 Offset: 0x9B8D80 VA: 0x1809BA780
	|-StaticPropertyAccessor<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Compile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B9B10 Offset: 0x9B8110 VA: 0x1809B9B10
	|-StaticPropertyAccessor<__Il2CppFullySharedGenericType>.Compile
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object GetValue(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9BA090 Offset: 0x9B8690 VA: 0x1809BA090
	|-StaticPropertyAccessor<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1
	private object GetValueUnsafe(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B9FE0 Offset: 0x9B85E0 VA: 0x1809B9FE0
	|-StaticPropertyAccessor<__Il2CppFullySharedGenericType>.GetValueUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void SetValue(object target, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9BA380 Offset: 0x9B8980 VA: 0x1809BA380
	|-StaticPropertyAccessor<__Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1
	private void SetValueUnsafe(object target, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9BA290 Offset: 0x9B8890 VA: 0x1809BA290
	|-StaticPropertyAccessor<__Il2CppFullySharedGenericType>.SetValueUnsafe
	*/
}

// Namespace: Unity.VisualScripting
[Usage(1, AllowMultiple = True)]
public sealed class RenamedAssemblyAttribute : Attribute // TypeDefIndex: 9205
{
	// Fields
	[CompilerGenerated]
	private readonly string <previousName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <newName>k__BackingField; // 0x18

	// Properties
	public string previousName { get; }
	public string newName { get; }

	// Methods

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(string previousName, string newName) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_previousName() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_newName() { }
}

// Namespace: Unity.VisualScripting
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class RenamedFromAttribute : Attribute // TypeDefIndex: 9206
{
	// Fields
	[CompilerGenerated]
	private readonly string <previousName>k__BackingField; // 0x10

	// Properties
	public string previousName { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string previousName) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_previousName() { }
}

// Namespace: Unity.VisualScripting
[Usage(1, AllowMultiple = True)]
public sealed class RenamedNamespaceAttribute : Attribute // TypeDefIndex: 9207
{
	// Fields
	[CompilerGenerated]
	private readonly string <previousName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <newName>k__BackingField; // 0x18

	// Properties
	public string previousName { get; }
	public string newName { get; }

	// Methods

	// RVA: 0x14135A0 Offset: 0x1411BA0 VA: 0x1814135A0
	public void .ctor(string previousName, string newName) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_previousName() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_newName() { }
}

// Namespace: Unity.VisualScripting
public static class RuntimeCodebase // TypeDefIndex: 9210
{
	// Fields
	private static readonly object lock; // 0x0
	private static readonly List<Type> _types; // 0x8
	private static readonly List<Assembly> _assemblies; // 0x10
	public static HashSet<string> disallowedAssemblies; // 0x18
	private static readonly Dictionary<string, Type> typeSerializations; // 0x20
	private static Dictionary<string, Type> _renamedTypes; // 0x28
	private static Dictionary<string, string> _renamedNamespaces; // 0x30
	private static Dictionary<string, string> _renamedAssemblies; // 0x38
	private static readonly Dictionary<Type, Dictionary<string, string>> _renamedMembers; // 0x40

	// Properties
	public static IEnumerable<Type> types { get; }
	public static IEnumerable<Assembly> assemblies { get; }
	public static Dictionary<string, string> renamedNamespaces { get; }
	public static Dictionary<string, string> renamedAssemblies { get; }
	public static Dictionary<string, Type> renamedTypes { get; }

	// Methods

	// RVA: 0x228C5F0 Offset: 0x228ABF0 VA: 0x18228C5F0
	public static IEnumerable<Type> get_types() { }

	// RVA: 0x228C330 Offset: 0x228A930 VA: 0x18228C330
	public static IEnumerable<Assembly> get_assemblies() { }

	// RVA: 0x228BD00 Offset: 0x228A300 VA: 0x18228BD00
	private static void .cctor() { }

	// RVA: 0x228A710 Offset: 0x2288D10 VA: 0x18228A710
	public static IEnumerable<Attribute> GetAssemblyAttributes(Type attributeType) { }

	[IteratorStateMachine(typeof(RuntimeCodebase.<GetAssemblyAttributes>d__15))]
	// RVA: 0x228A680 Offset: 0x2288C80 VA: 0x18228A680
	public static IEnumerable<Attribute> GetAssemblyAttributes(Type attributeType, IEnumerable<Assembly> assemblies) { }

	// RVA: -1 Offset: -1
	public static IEnumerable<TAttribute> GetAssemblyAttributes<TAttribute>(IEnumerable<Assembly> assemblies) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x797610 Offset: 0x795C10 VA: 0x180797610
	|-RuntimeCodebase.GetAssemblyAttributes<object>
	*/

	// RVA: -1 Offset: -1
	public static IEnumerable<TAttribute> GetAssemblyAttributes<TAttribute>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x797570 Offset: 0x795B70 VA: 0x180797570
	|-RuntimeCodebase.GetAssemblyAttributes<object>
	*/

	// RVA: 0x228A810 Offset: 0x2288E10 VA: 0x18228A810
	public static void PrewarmTypeDeserialization(Type type) { }

	// RVA: 0x228AAD0 Offset: 0x22890D0 VA: 0x18228AAD0
	public static string SerializeType(Type type) { }

	// RVA: 0x228AC10 Offset: 0x2289210 VA: 0x18228AC10
	public static bool TryDeserializeType(string typeName, out Type type) { }

	// RVA: 0x22893F0 Offset: 0x22879F0 VA: 0x1822893F0
	public static Type DeserializeType(string typeName) { }

	// RVA: 0x2289370 Offset: 0x2287970 VA: 0x182289370
	public static void ClearCachedTypes() { }

	// RVA: 0x228AB80 Offset: 0x2289180 VA: 0x18228AB80
	private static bool TryCachedTypeLookup(string typeName, out Type type) { }

	// RVA: 0x228B540 Offset: 0x2289B40 VA: 0x18228B540
	private static bool TrySystemTypeLookup(string typeName, out Type type) { }

	// RVA: 0x228B930 Offset: 0x2289F30 VA: 0x18228B930
	private static bool TrySystemTypeLookup(TypeName typeName, out Type type) { }

	// RVA: 0x228AE80 Offset: 0x2289480 VA: 0x18228AE80
	private static bool TryRenamedTypeLookup(string previousTypeName, out Type type) { }

	// RVA: 0x228C450 Offset: 0x228AA50 VA: 0x18228C450
	public static Dictionary<string, string> get_renamedNamespaces() { }

	// RVA: 0x228C380 Offset: 0x228A980 VA: 0x18228C380
	public static Dictionary<string, string> get_renamedAssemblies() { }

	// RVA: 0x228C520 Offset: 0x228AB20 VA: 0x18228C520
	public static Dictionary<string, Type> get_renamedTypes() { }

	// RVA: 0x228A9E0 Offset: 0x2288FE0 VA: 0x18228A9E0
	public static Dictionary<string, string> RenamedMembers(Type type) { }

	// RVA: 0x22898A0 Offset: 0x2287EA0 VA: 0x1822898A0
	private static Dictionary<string, string> FetchRenamedMembers(Type type) { }

	// RVA: 0x2289CE0 Offset: 0x22882E0 VA: 0x182289CE0
	private static Dictionary<string, string> FetchRenamedNamespaces() { }

	// RVA: 0x22894E0 Offset: 0x2287AE0 VA: 0x1822894E0
	private static Dictionary<string, string> FetchRenamedAssemblies() { }

	// RVA: 0x228A0A0 Offset: 0x22886A0 VA: 0x18228A0A0
	private static Dictionary<string, Type> FetchRenamedTypes() { }
}

// Namespace: Unity.VisualScripting
[Usage(384, Inherited = True, AllowMultiple = False)]
public sealed class TypeFilter : Attribute, ICloneable // TypeDefIndex: 9211
{
	// Fields
	private readonly HashSet<Type> types; // 0x10
	[CompilerGenerated]
	private TypesMatching <Matching>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <Value>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <Reference>k__BackingField; // 0x1D
	[CompilerGenerated]
	private bool <Classes>k__BackingField; // 0x1E
	[CompilerGenerated]
	private bool <Interfaces>k__BackingField; // 0x1F
	[CompilerGenerated]
	private bool <Structs>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <Enums>k__BackingField; // 0x21
	[CompilerGenerated]
	private bool <Public>k__BackingField; // 0x22
	[CompilerGenerated]
	private bool <NonPublic>k__BackingField; // 0x23
	[CompilerGenerated]
	private bool <Abstract>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <Generic>k__BackingField; // 0x25
	[CompilerGenerated]
	private bool <OpenConstructedGeneric>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <Static>k__BackingField; // 0x27
	[CompilerGenerated]
	private bool <Sealed>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <Nested>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <Primitives>k__BackingField; // 0x2A
	[CompilerGenerated]
	private bool <Object>k__BackingField; // 0x2B
	[CompilerGenerated]
	private bool <NonSerializable>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <Obsolete>k__BackingField; // 0x2D

	// Properties
	public TypesMatching Matching { get; set; }
	public HashSet<Type> Types { get; }
	public bool Value { get; set; }
	public bool Reference { get; set; }
	public bool Classes { get; set; }
	public bool Interfaces { get; set; }
	public bool Structs { get; set; }
	public bool Enums { get; set; }
	public bool Public { get; set; }
	public bool NonPublic { get; set; }
	public bool Abstract { get; set; }
	public bool Generic { get; set; }
	public bool OpenConstructedGeneric { get; set; }
	public bool Static { get; set; }
	public bool Sealed { get; set; }
	public bool Nested { get; set; }
	public bool Primitives { get; set; }
	public bool Object { get; set; }
	public bool NonSerializable { get; set; }
	public bool Obsolete { get; set; }
	public bool ExpectsBoolean { get; }
	public static TypeFilter Any { get; }

	// Methods

	// RVA: 0x2297110 Offset: 0x2295710 VA: 0x182297110
	public void .ctor(TypesMatching matching, IEnumerable<Type> types) { }

	// RVA: 0x2297230 Offset: 0x2295830 VA: 0x182297230
	public void .ctor(TypesMatching matching, Type[] types) { }

	// RVA: 0x2297100 Offset: 0x2295700 VA: 0x182297100
	public void .ctor(IEnumerable<Type> types) { }

	// RVA: 0x2297100 Offset: 0x2295700 VA: 0x182297100
	public void .ctor(Type[] types) { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public TypesMatching get_Matching() { }

	[CompilerGenerated]
	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_Matching(TypesMatching value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public HashSet<Type> get_Types() { }

	[CompilerGenerated]
	// RVA: 0x39A900 Offset: 0x398F00 VA: 0x18039A900
	public bool get_Value() { }

	[CompilerGenerated]
	// RVA: 0x39A910 Offset: 0x398F10 VA: 0x18039A910
	public void set_Value(bool value) { }

	[CompilerGenerated]
	// RVA: 0x197EBE0 Offset: 0x197D1E0 VA: 0x18197EBE0
	public bool get_Reference() { }

	[CompilerGenerated]
	// RVA: 0x197E820 Offset: 0x197CE20 VA: 0x18197E820
	public void set_Reference(bool value) { }

	[CompilerGenerated]
	// RVA: 0x197E830 Offset: 0x197CE30 VA: 0x18197E830
	public bool get_Classes() { }

	[CompilerGenerated]
	// RVA: 0x197E7E0 Offset: 0x197CDE0 VA: 0x18197E7E0
	public void set_Classes(bool value) { }

	[CompilerGenerated]
	// RVA: 0x197E800 Offset: 0x197CE00 VA: 0x18197E800
	public bool get_Interfaces() { }

	[CompilerGenerated]
	// RVA: 0x197E070 Offset: 0x197C670 VA: 0x18197E070
	public void set_Interfaces(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_Structs() { }

	[CompilerGenerated]
	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	public void set_Structs(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38E1B0 Offset: 0x38C7B0 VA: 0x18038E1B0
	public bool get_Enums() { }

	[CompilerGenerated]
	// RVA: 0x38E210 Offset: 0x38C810 VA: 0x18038E210
	public void set_Enums(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38E1C0 Offset: 0x38C7C0 VA: 0x18038E1C0
	public bool get_Public() { }

	[CompilerGenerated]
	// RVA: 0x38E220 Offset: 0x38C820 VA: 0x18038E220
	public void set_Public(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38E1D0 Offset: 0x38C7D0 VA: 0x18038E1D0
	public bool get_NonPublic() { }

	[CompilerGenerated]
	// RVA: 0x38E230 Offset: 0x38C830 VA: 0x18038E230
	public void set_NonPublic(bool value) { }

	[CompilerGenerated]
	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	public bool get_Abstract() { }

	[CompilerGenerated]
	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	public void set_Abstract(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161BB10 Offset: 0x161A110 VA: 0x18161BB10
	public bool get_Generic() { }

	[CompilerGenerated]
	// RVA: 0x161BB90 Offset: 0x161A190 VA: 0x18161BB90
	public void set_Generic(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161BB00 Offset: 0x161A100 VA: 0x18161BB00
	public bool get_OpenConstructedGeneric() { }

	[CompilerGenerated]
	// RVA: 0x161BB80 Offset: 0x161A180 VA: 0x18161BB80
	public void set_OpenConstructedGeneric(bool value) { }

	[CompilerGenerated]
	// RVA: 0x161BAF0 Offset: 0x161A0F0 VA: 0x18161BAF0
	public bool get_Static() { }

	[CompilerGenerated]
	// RVA: 0x161BB70 Offset: 0x161A170 VA: 0x18161BB70
	public void set_Static(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_Sealed() { }

	[CompilerGenerated]
	// RVA: 0x3CB170 Offset: 0x3C9770 VA: 0x1803CB170
	public void set_Sealed(bool value) { }

	[CompilerGenerated]
	// RVA: 0x179F980 Offset: 0x179DF80 VA: 0x18179F980
	public bool get_Nested() { }

	[CompilerGenerated]
	// RVA: 0x1EC4A60 Offset: 0x1EC3060 VA: 0x181EC4A60
	public void set_Nested(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E33770 Offset: 0x1E31D70 VA: 0x181E33770
	public bool get_Primitives() { }

	[CompilerGenerated]
	// RVA: 0x22973E0 Offset: 0x22959E0 VA: 0x1822973E0
	public void set_Primitives(bool value) { }

	[CompilerGenerated]
	// RVA: 0x22973C0 Offset: 0x22959C0 VA: 0x1822973C0
	public bool get_Object() { }

	[CompilerGenerated]
	// RVA: 0x22973D0 Offset: 0x22959D0 VA: 0x1822973D0
	public void set_Object(bool value) { }

	[CompilerGenerated]
	// RVA: 0x54CA70 Offset: 0x54B070 VA: 0x18054CA70
	public bool get_NonSerializable() { }

	[CompilerGenerated]
	// RVA: 0x1897480 Offset: 0x1895A80 VA: 0x181897480
	public void set_NonSerializable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1897350 Offset: 0x1895950 VA: 0x181897350
	public bool get_Obsolete() { }

	[CompilerGenerated]
	// RVA: 0x1897490 Offset: 0x1895A90 VA: 0x181897490
	public void set_Obsolete(bool value) { }

	// RVA: 0x2297310 Offset: 0x2295910 VA: 0x182297310
	public bool get_ExpectsBoolean() { }

	// RVA: 0x2295DC0 Offset: 0x22943C0 VA: 0x182295DC0 Slot: 7
	private object System.ICloneable.Clone() { }

	// RVA: 0x2295DC0 Offset: 0x22943C0 VA: 0x182295DC0
	public TypeFilter Clone() { }

	// RVA: 0x2295EE0 Offset: 0x22944E0 VA: 0x182295EE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2296050 Offset: 0x2294650 VA: 0x182296050 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2296A40 Offset: 0x2295040 VA: 0x182296A40
	public bool ValidateType(Type type) { }

	// RVA: 0x2296450 Offset: 0x2294A50 VA: 0x182296450 Slot: 3
	public override string ToString() { }

	// RVA: 0x2297240 Offset: 0x2295840 VA: 0x182297240
	public static TypeFilter get_Any() { }
}

// Namespace: Unity.VisualScripting
public class TypeName // TypeDefIndex: 9214
{
	// Fields
	[CompilerGenerated]
	private string <AssemblyDescription>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <AssemblyName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <AssemblyVersion>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AssemblyCulture>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <AssemblyPublicKeyToken>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly List<TypeName> <GenericParameters>k__BackingField; // 0x38
	private readonly List<string> names; // 0x40
	private readonly List<int> genericarities; // 0x48
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x50

	// Properties
	public string AssemblyDescription { get; set; }
	public string AssemblyName { get; set; }
	public string AssemblyVersion { get; set; }
	public string AssemblyCulture { get; set; }
	public string AssemblyPublicKeyToken { get; set; }
	public List<TypeName> GenericParameters { get; }
	public string Name { get; set; }
	public bool IsArray { get; }
	public string LastName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_AssemblyDescription() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_AssemblyDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_AssemblyName() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_AssemblyName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_AssemblyVersion() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_AssemblyVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_AssemblyCulture() { }

	[CompilerGenerated]
	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	private void set_AssemblyCulture(string value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_AssemblyPublicKeyToken() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_AssemblyPublicKeyToken(string value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public List<TypeName> get_GenericParameters() { }

	[CompilerGenerated]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	private void set_Name(string value) { }

	// RVA: 0x2298ED0 Offset: 0x22974D0 VA: 0x182298ED0
	public bool get_IsArray() { }

	// RVA: 0x2298F20 Offset: 0x2297520 VA: 0x182298F20
	public string get_LastName() { }

	// RVA: 0x22974E0 Offset: 0x2295AE0 VA: 0x1822974E0
	public static TypeName Parse(string s) { }

	// RVA: 0x22984D0 Offset: 0x2296AD0 VA: 0x1822984D0
	private void .ctor(string s, ref int index) { }

	// RVA: 0x22973F0 Offset: 0x22959F0 VA: 0x1822973F0
	private static string LookForPairThenRemove(List<string> strings, string Name) { }

	// RVA: 0x2297AA0 Offset: 0x22960A0 VA: 0x182297AA0
	public void ReplaceNamespace(string oldNamespace, string newNamespace) { }

	// RVA: 0x2297550 Offset: 0x2295B50 VA: 0x182297550
	public void ReplaceAssembly(string oldAssembly, string newAssembly) { }

	// RVA: 0x22979F0 Offset: 0x2295FF0 VA: 0x1822979F0
	public void ReplaceName(string oldTypeName, Type newType) { }

	// RVA: 0x22976F0 Offset: 0x2295CF0 VA: 0x1822976F0
	public void ReplaceName(string oldTypeName, string newTypeName, AssemblyName newAssemblyName) { }

	// RVA: 0x2297FB0 Offset: 0x22965B0 VA: 0x182297FB0
	private static string ToElementTypeName(string s) { }

	// RVA: 0x2297F40 Offset: 0x2296540 VA: 0x182297F40
	private static string ToArrayOrType(string oldType, string newType) { }

	// RVA: 0x2297CF0 Offset: 0x22962F0 VA: 0x182297CF0
	public void SetAssemblyName(AssemblyName newAssemblyName) { }

	// RVA: 0x2298350 Offset: 0x2296950 VA: 0x182298350
	private void UpdateName() { }

	// RVA: 0x2298040 Offset: 0x2296640 VA: 0x182298040
	public string ToString(TypeNameDetail specification, TypeNameDetail genericsSpecification) { }

	// RVA: 0x2298340 Offset: 0x2296940 VA: 0x182298340 Slot: 3
	public override string ToString() { }

	// RVA: 0x2298030 Offset: 0x2296630 VA: 0x182298030
	public string ToLooseString() { }

	// RVA: 0x2297EC0 Offset: 0x22964C0 VA: 0x182297EC0
	public static string Simplify(string typeName) { }

	// RVA: 0x2297E10 Offset: 0x2296410 VA: 0x182297E10
	public static string SimplifyFast(string typeName) { }
}

// Namespace: Unity.VisualScripting
public enum TypeNameDetail // TypeDefIndex: 9215
{
	// Fields
	public int value__; // 0x0
	public const TypeNameDetail Name = 0;
	public const TypeNameDetail NameAndAssembly = 1;
	public const TypeNameDetail Full = 2;
}

// Namespace: Unity.VisualScripting
public enum TypeQualifier // TypeDefIndex: 9216
{
	// Fields
	public int value__; // 0x0
	public const TypeQualifier Name = 0;
	public const TypeQualifier Namespace = 1;
	public const TypeQualifier GlobalNamespace = 2;
}

// Namespace: Unity.VisualScripting
public enum TypesMatching // TypeDefIndex: 9217
{
	// Fields
	public int value__; // 0x0
	public const TypesMatching ConvertibleToAny = 0;
	public const TypesMatching AssignableToAll = 1;
	public const TypesMatching Any = 2;
}

// Namespace: Unity.VisualScripting
[Extension]
public static class TypeUtility // TypeDefIndex: 9223
{
	// Fields
	private static readonly HashSet<Type> _numericTypes; // 0x0
	private static readonly HashSet<Type> _numericConstructTypes; // 0x8
	private static readonly HashSet<Type> typesWithShortStrings; // 0x10
	private static readonly Dictionary<Type, object> defaultPrimitives; // 0x18

	// Methods

	[Extension]
	// RVA: 0x229AEA0 Offset: 0x22994A0 VA: 0x18229AEA0
	public static bool IsBasic(Type type) { }

	[Extension]
	// RVA: 0x229B250 Offset: 0x2299850 VA: 0x18229B250
	public static bool IsNumeric(Type type) { }

	[Extension]
	// RVA: 0x229B170 Offset: 0x2299770 VA: 0x18229B170
	public static bool IsNumericConstruct(Type type) { }

	[Extension]
	// RVA: 0x229BD00 Offset: 0x229A300 VA: 0x18229BD00
	public static Namespace Namespace(Type type) { }

	[Extension]
	// RVA: 0x229AC20 Offset: 0x2299220 VA: 0x18229AC20
	public static Func<object> Instantiator(Type type, bool nonPublic = True) { }

	[Extension]
	// RVA: 0x229A9F0 Offset: 0x2298FF0 VA: 0x18229A9F0
	public static Func<object[], object> Instantiator(Type type, bool nonPublic = True, Type[] parameterTypes) { }

	[Extension]
	// RVA: 0x229C560 Offset: 0x229AB60 VA: 0x18229C560
	public static object TryInstantiate(Type type, bool nonPublic = True, object[] args) { }

	[Extension]
	// RVA: 0x229A750 Offset: 0x2298D50 VA: 0x18229A750
	public static object Instantiate(Type type, bool nonPublic = True, object[] args) { }

	[Extension]
	// RVA: 0x22999B0 Offset: 0x2297FB0 VA: 0x1822999B0
	public static object Default(Type type) { }

	[Extension]
	// RVA: 0x229BD70 Offset: 0x229A370 VA: 0x18229BD70
	public static object PseudoDefault(Type type) { }

	[Extension]
	// RVA: 0x229B350 Offset: 0x2299950 VA: 0x18229B350
	public static bool IsStatic(Type type) { }

	[Extension]
	// RVA: 0x229AD50 Offset: 0x2299350 VA: 0x18229AD50
	public static bool IsAbstract(Type type) { }

	[Extension]
	// RVA: 0x229B080 Offset: 0x2299680 VA: 0x18229B080
	public static bool IsConcrete(Type type) { }

	[Extension]
	// RVA: 0x229A220 Offset: 0x2298820 VA: 0x18229A220
	public static IEnumerable<Type> GetInterfaces(Type type, bool includeInherited) { }

	[Extension]
	// RVA: 0x22991A0 Offset: 0x22977A0 VA: 0x1822991A0
	public static IEnumerable<Type> BaseTypeAndInterfaces(Type type, bool inheritedInterfaces = True) { }

	[IteratorStateMachine(typeof(TypeUtility.<Hierarchy>d__19))]
	[Extension]
	// RVA: 0x229A6D0 Offset: 0x2298CD0 VA: 0x18229A6D0
	public static IEnumerable<Type> Hierarchy(Type type) { }

	[Extension]
	// RVA: 0x2298F80 Offset: 0x2297580 VA: 0x182298F80
	public static IEnumerable<Type> AndBaseTypeAndInterfaces(Type type) { }

	[Extension]
	// RVA: 0x2299110 Offset: 0x2297710 VA: 0x182299110
	public static IEnumerable<Type> AndInterfaces(Type type) { }

	[Extension]
	// RVA: 0x2299020 Offset: 0x2297620 VA: 0x182299020
	public static IEnumerable<Type> AndHierarchy(Type type) { }

	// RVA: 0x229A330 Offset: 0x2298930 VA: 0x18229A330
	public static Type GetListElementType(Type listType, bool allowNonGeneric) { }

	// RVA: 0x2299EE0 Offset: 0x22984E0 VA: 0x182299EE0
	public static Type GetEnumerableElementType(Type enumerableType, bool allowNonGeneric) { }

	// RVA: 0x2299AF0 Offset: 0x22980F0 VA: 0x182299AF0
	public static Type GetDictionaryItemType(Type dictionaryType, bool allowNonGeneric, int genericArgumentIndex) { }

	// RVA: 0x2299E20 Offset: 0x2298420 VA: 0x182299E20
	public static Type GetDictionaryKeyType(Type dictionaryType, bool allowNonGeneric) { }

	// RVA: 0x2299E80 Offset: 0x2298480 VA: 0x182299E80
	public static Type GetDictionaryValueType(Type dictionaryType, bool allowNonGeneric) { }

	[Extension]
	// RVA: 0x229B0E0 Offset: 0x22996E0 VA: 0x18229B0E0
	public static bool IsNullable(Type type) { }

	[Extension]
	// RVA: 0x229B330 Offset: 0x2299930 VA: 0x18229B330
	public static bool IsReferenceType(Type type) { }

	[Extension]
	// RVA: 0x229B390 Offset: 0x2299990 VA: 0x18229B390
	public static bool IsStruct(Type type) { }

	[Extension]
	// RVA: 0x229AD90 Offset: 0x2299390 VA: 0x18229AD90
	public static bool IsAssignableFrom(Type type, object value) { }

	[Extension]
	// RVA: 0x2299330 Offset: 0x2297930 VA: 0x182299330
	public static bool CanMakeGenericTypeVia(Type openConstructedType, Type closedConstructedType) { }

	[Extension]
	// RVA: 0x229B3F0 Offset: 0x22999F0 VA: 0x18229B3F0
	public static Type MakeGenericTypeVia(Type openConstructedType, Type closedConstructedType, Dictionary<Type, Type> resolvedGenericParameters, bool safe = True) { }

	[Extension]
	// RVA: 0x229C100 Offset: 0x229A700 VA: 0x18229C100
	public static string ToShortString(object o, int maxLength = 20) { }

	[IteratorStateMachine(typeof(TypeUtility.<GetTypesSafely>d__35))]
	[Extension]
	// RVA: 0x229A650 Offset: 0x2298C50 VA: 0x18229A650
	public static IEnumerable<Type> GetTypesSafely(Assembly assembly) { }

	// RVA: 0x229C770 Offset: 0x229AD70 VA: 0x18229C770
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public class LooseAssemblyNameConverter : fsDirectConverter // TypeDefIndex: 9224
{
	// Properties
	public override Type ModelType { get; }

	// Methods

	// RVA: 0x22812B0 Offset: 0x227F8B0 VA: 0x1822812B0 Slot: 9
	public override Type get_ModelType() { }

	// RVA: 0x2281010 Offset: 0x227F610 VA: 0x182281010 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x22811B0 Offset: 0x227F7B0 VA: 0x1822811B0 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x2281060 Offset: 0x227F660 VA: 0x182281060 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class NamespaceConverter : fsDirectConverter // TypeDefIndex: 9225
{
	// Properties
	public override Type ModelType { get; }

	// Methods

	// RVA: 0x2281E60 Offset: 0x2280460 VA: 0x182281E60 Slot: 9
	public override Type get_ModelType() { }

	// RVA: 0x2281BC0 Offset: 0x22801C0 VA: 0x182281BC0 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x2281D50 Offset: 0x2280350 VA: 0x182281D50 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x2281C10 Offset: 0x2280210 VA: 0x182281C10 Slot: 8
	public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class Ray2DConverter : fsDirectConverter<Ray2D> // TypeDefIndex: 9226
{
	// Methods

	// RVA: 0x2287FB0 Offset: 0x22865B0 VA: 0x182287FB0 Slot: 10
	protected override fsResult DoSerialize(Ray2D model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x2287D30 Offset: 0x2286330 VA: 0x182287D30 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray2D model) { }

	// RVA: 0x2287CF0 Offset: 0x22862F0 VA: 0x182287CF0 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x2288130 Offset: 0x2286730 VA: 0x182288130
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class RayConverter : fsDirectConverter<Ray> // TypeDefIndex: 9227
{
	// Methods

	// RVA: 0x2288480 Offset: 0x2286A80 VA: 0x182288480 Slot: 10
	protected override fsResult DoSerialize(Ray model, Dictionary<string, fsData> serialized) { }

	// RVA: 0x22881D0 Offset: 0x22867D0 VA: 0x1822881D0 Slot: 11
	protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray model) { }

	// RVA: 0x2288170 Offset: 0x2286770 VA: 0x182288170 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x2288620 Offset: 0x2286C20 VA: 0x182288620
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class UnityObjectConverter : fsConverter // TypeDefIndex: 9228
{
	// Properties
	private List<Object> objectReferences { get; }

	// Methods

	// RVA: 0x22A0FF0 Offset: 0x229F5F0 VA: 0x1822A0FF0
	private List<Object> get_objectReferences() { }

	// RVA: 0x22A0A70 Offset: 0x229F070 VA: 0x1822A0A70 Slot: 9
	public override bool CanProcess(Type type) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 5
	public override bool RequestCycleSupport(Type storageType) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	public override bool RequestInheritanceSupport(Type storageType) { }

	// RVA: 0x22A0DC0 Offset: 0x229F3C0 VA: 0x1822A0DC0 Slot: 7
	public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType) { }

	// RVA: 0x22A0AF0 Offset: 0x229F0F0 VA: 0x1822A0AF0 Slot: 8
	public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType) { }

	// RVA: 0x2119520 Offset: 0x2117B20 VA: 0x182119520 Slot: 4
	public override object CreateInstance(fsData data, Type storageType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
[IncludeInSettings(False)]
public sealed class DictionaryAsset : LudiqScriptableObject, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable // TypeDefIndex: 9229
{
	// Fields
	[CompilerGenerated]
	private Dictionary<string, object> <dictionary>k__BackingField; // 0x30

	// Properties
	public object Item { get; set; }
	[Serialize]
	public Dictionary<string, object> dictionary { get; set; }
	public int Count { get; }
	public ICollection<string> Keys { get; }
	public ICollection<object> Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x22807E0 Offset: 0x227EDE0 VA: 0x1822807E0 Slot: 12
	public object get_Item(string key) { }

	// RVA: 0x22808E0 Offset: 0x227EEE0 VA: 0x1822808E0 Slot: 13
	public void set_Item(string key, object value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public Dictionary<string, object> get_dictionary() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void set_dictionary(Dictionary<string, object> value) { }

	// RVA: 0x2280790 Offset: 0x227ED90 VA: 0x182280790 Slot: 20
	public int get_Count() { }

	// RVA: 0x2280840 Offset: 0x227EE40 VA: 0x182280840 Slot: 14
	public ICollection<string> get_Keys() { }

	// RVA: 0x2280890 Offset: 0x227EE90 VA: 0x182280890 Slot: 15
	public ICollection<object> get_Values() { }

	// RVA: 0x2280600 Offset: 0x227EC00 VA: 0x182280600 Slot: 21
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly() { }

	// RVA: 0x22801B0 Offset: 0x227E7B0 VA: 0x1822801B0 Slot: 9
	protected override void OnAfterDeserialize() { }

	// RVA: 0x227FDA0 Offset: 0x227E3A0 VA: 0x18227FDA0 Slot: 23
	public void Clear() { }

	// RVA: 0x227FDF0 Offset: 0x227E3F0 VA: 0x18227FDF0 Slot: 16
	public bool ContainsKey(string key) { }

	// RVA: 0x227FD30 Offset: 0x227E330 VA: 0x18227FD30 Slot: 17
	public void Add(string key, object value) { }

	// RVA: 0x227FEE0 Offset: 0x227E4E0 VA: 0x18227FEE0
	public void Merge(DictionaryAsset other, bool overwriteExisting = True) { }

	// RVA: 0x2280230 Offset: 0x227E830 VA: 0x182280230 Slot: 18
	public bool Remove(string key) { }

	// RVA: 0x22806A0 Offset: 0x227ECA0 VA: 0x1822806A0 Slot: 19
	public bool TryGetValue(string key, out object value) { }

	// RVA: 0x227FE50 Offset: 0x227E450 VA: 0x18227FE50 Slot: 27
	public IEnumerator<KeyValuePair<string, object>> GetEnumerator() { }

	// RVA: 0x2280650 Offset: 0x227EC50 VA: 0x182280650 Slot: 28
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x22802C0 Offset: 0x227E8C0 VA: 0x1822802C0 Slot: 22
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(KeyValuePair<string, object> item) { }

	// RVA: 0x2280390 Offset: 0x227E990 VA: 0x182280390 Slot: 24
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(KeyValuePair<string, object> item) { }

	// RVA: 0x2280460 Offset: 0x227EA60 VA: 0x182280460 Slot: 25
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { }

	// RVA: 0x2280530 Offset: 0x227EB30 VA: 0x182280530 Slot: 26
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(KeyValuePair<string, object> item) { }

	[ContextMenu("Show Data...")]
	// RVA: 0x2280290 Offset: 0x227E890 VA: 0x182280290 Slot: 11
	protected override void ShowData() { }

	// RVA: 0x2280710 Offset: 0x227ED10 VA: 0x182280710
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(384, AllowMultiple = False, Inherited = True)]
public sealed class DoNotSerializeAttribute : Attribute // TypeDefIndex: 9230
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public interface ISerializationDependency : ISerializationCallbackReceiver // TypeDefIndex: 9231
{
	// Properties
	internal abstract bool IsDeserialized { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	internal abstract void set_IsDeserialized(bool value);

	// RVA: -1 Offset: -1 Slot: 1
	internal abstract bool get_IsDeserialized();
}

// Namespace: Unity.VisualScripting
public interface ISerializationDepender : ISerializationCallbackReceiver // TypeDefIndex: 9232
{
	// Properties
	public abstract IEnumerable<ISerializationDependency> deserializationDependencies { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerable<ISerializationDependency> get_deserializationDependencies();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAfterDependenciesDeserialized();
}

// Namespace: Unity.VisualScripting
[SerializationVersion("A", new[] {  })]
[Serializable]
public struct SerializableType : IEquatable<SerializableType>, IComparable<SerializableType> // TypeDefIndex: 9233
{
	// Fields
	[Serialize]
	public string Identification; // 0x0

	// Methods

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	public void .ctor(string identification) { }

	// RVA: 0x228C6E0 Offset: 0x228ACE0 VA: 0x18228C6E0 Slot: 4
	public bool Equals(SerializableType other) { }

	// RVA: 0x228C650 Offset: 0x228AC50 VA: 0x18228C650 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15A3BE0 Offset: 0x15A21E0 VA: 0x1815A3BE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x228C6F0 Offset: 0x228ACF0 VA: 0x18228C6F0
	public static bool op_Equality(SerializableType left, SerializableType right) { }

	// RVA: 0x228C700 Offset: 0x228AD00 VA: 0x18228C700
	public static bool op_Inequality(SerializableType left, SerializableType right) { }

	// RVA: 0x228C640 Offset: 0x228AC40 VA: 0x18228C640 Slot: 5
	public int CompareTo(SerializableType other) { }
}

// Namespace: Unity.VisualScripting
public class Unknown // TypeDefIndex: 9234
{
	// Fields
	public const string Identification = "__UNKNOWN";

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Extension]
public static class Serialization // TypeDefIndex: 9235
{
	// Fields
	public const string ConstructorWarning = "This parameterless constructor is only made public for serialization. Use another constructor instead.";
	private static readonly HashSet<SerializationOperation> freeOperations; // 0x0
	private static readonly HashSet<SerializationOperation> busyOperations; // 0x8
	private static readonly object lock; // 0x10
	[CompilerGenerated]
	private static bool <isUnitySerializing>k__BackingField; // 0x18
	private static readonly HashSet<ISerializationDepender> awaitingDependers; // 0x20

	// Properties
	public static bool isUnitySerializing { get; set; }
	public static bool isCustomSerializing { get; }
	public static bool isSerializing { get; }

	// Methods

	// RVA: 0x228F2D0 Offset: 0x228D8D0 VA: 0x18228F2D0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x228F580 Offset: 0x228DB80 VA: 0x18228F580
	public static bool get_isUnitySerializing() { }

	[CompilerGenerated]
	// RVA: 0x228F5D0 Offset: 0x228DBD0 VA: 0x18228F5D0
	public static void set_isUnitySerializing(bool value) { }

	// RVA: 0x228F460 Offset: 0x228DA60 VA: 0x18228F460
	public static bool get_isCustomSerializing() { }

	// RVA: 0x228F4D0 Offset: 0x228DAD0 VA: 0x18228F4D0
	public static bool get_isSerializing() { }

	// RVA: 0x228F090 Offset: 0x228D690 VA: 0x18228F090
	private static SerializationOperation StartOperation() { }

	// RVA: 0x228DD00 Offset: 0x228C300 VA: 0x18228DD00
	private static void EndOperation(SerializationOperation operation) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T CloneViaSerialization<T>(T value, bool forceReflected = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79A170 Offset: 0x798770 VA: 0x18079A170
	|-Serialization.CloneViaSerialization<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void CloneViaSerializationInto<TSource, TDestination>(TSource value, ref TDestination instance, bool forceReflected = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79A010 Offset: 0x798610 VA: 0x18079A010
	|-Serialization.CloneViaSerializationInto<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x228ED90 Offset: 0x228D390 VA: 0x18228ED90
	public static SerializationData Serialize(object value, bool forceReflected = False) { }

	[Extension]
	// RVA: 0x228D560 Offset: 0x228BB60 VA: 0x18228D560
	public static void DeserializeInto(SerializationData data, ref object instance, bool forceReflected = False) { }

	[Extension]
	// RVA: 0x228DC80 Offset: 0x228C280 VA: 0x18228DC80
	public static object Deserialize(SerializationData data, bool forceReflected = False) { }

	// RVA: 0x228EB30 Offset: 0x228D130 VA: 0x18228EB30
	private static string SerializeJson(fsSerializer serializer, object instance, bool forceReflected) { }

	// RVA: 0x228D8F0 Offset: 0x228BEF0 VA: 0x18228D8F0
	private static fsResult DeserializeJsonUtil(fsSerializer serializer, string json, ref object instance, bool forceReflected) { }

	// RVA: 0x228DA20 Offset: 0x228C020 VA: 0x18228DA20
	private static void DeserializeJson(fsSerializer serializer, string json, ref object instance, bool forceReflected) { }

	// RVA: 0x228DF50 Offset: 0x228C550 VA: 0x18228DF50
	private static void HandleResult(string label, fsResult result, Object context) { }

	// RVA: 0x228EB10 Offset: 0x228D110 VA: 0x18228EB10
	public static string PrettyPrint(string json) { }

	// RVA: 0x228D2A0 Offset: 0x228B8A0 VA: 0x18228D2A0
	public static void AwaitDependencies(ISerializationDepender depender) { }

	// RVA: 0x228EA40 Offset: 0x228D040 VA: 0x18228EA40
	public static void NotifyDependencyDeserializing(ISerializationDependency dependency) { }

	// RVA: 0x228E8C0 Offset: 0x228CEC0 VA: 0x18228E8C0
	public static void NotifyDependencyDeserialized(ISerializationDependency dependency) { }

	// RVA: 0x228EAC0 Offset: 0x228D0C0 VA: 0x18228EAC0
	public static void NotifyDependencyUnavailable(ISerializationDependency dependency) { }

	// RVA: 0x228E770 Offset: 0x228CD70 VA: 0x18228E770
	public static void NotifyDependencyAvailable(ISerializationDependency dependency) { }

	// RVA: 0x228D330 Offset: 0x228B930 VA: 0x18228D330
	private static void CheckIfDependenciesMet(ISerializationDepender depender) { }

	// RVA: 0x228E2A0 Offset: 0x228C8A0 VA: 0x18228E2A0
	public static void LogStuckDependers() { }
}

// Namespace: Unity.VisualScripting
[Serializable]
public struct SerializationData // TypeDefIndex: 9236
{
	// Fields
	[SerializeField]
	private string _json; // 0x0
	[SerializeField]
	private Object[] _objectReferences; // 0x8

	// Properties
	public string json { get; }
	public Object[] objectReferences { get; }

	// Methods

	// RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	public string get_json() { }

	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	public Object[] get_objectReferences() { }

	// RVA: 0x228CF10 Offset: 0x228B510 VA: 0x18228CF10
	public void .ctor(string json, IEnumerable<Object> objectReferences) { }

	// RVA: 0x228CF00 Offset: 0x228B500 VA: 0x18228CF00
	public void .ctor(string json, Object[] objectReferences) { }

	// RVA: 0x228C800 Offset: 0x228AE00 VA: 0x18228C800
	public string ToString(string title) { }

	// RVA: 0x228CEF0 Offset: 0x228B4F0 VA: 0x18228CEF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x228C720 Offset: 0x228AD20 VA: 0x18228C720
	public void ShowString(string title) { }
}

// Namespace: Unity.VisualScripting
public class SerializationOperation // TypeDefIndex: 9237
{
	// Fields
	[CompilerGenerated]
	private fsSerializer <serializer>k__BackingField; // 0x10
	[CompilerGenerated]
	private List<Object> <objectReferences>k__BackingField; // 0x18

	// Properties
	public fsSerializer serializer { get; set; }
	public List<Object> objectReferences { get; set; }

	// Methods

	// RVA: 0x228D020 Offset: 0x228B620 VA: 0x18228D020
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public fsSerializer get_serializer() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_serializer(fsSerializer value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public List<Object> get_objectReferences() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_objectReferences(List<Object> value) { }

	// RVA: 0x228CFC0 Offset: 0x228B5C0 VA: 0x18228CFC0
	public void Reset() { }
}

// Namespace: Unity.VisualScripting
public class SerializationVersionAttribute : fsObjectAttribute // TypeDefIndex: 9238
{
	// Methods

	// RVA: 0x228D290 Offset: 0x228B890 VA: 0x18228D290
	public void .ctor(string versionString, Type[] previousModels) { }
}

// Namespace: Unity.VisualScripting
public class SerializeAsAttribute : fsPropertyAttribute // TypeDefIndex: 9239
{
	// Methods

	// RVA: 0x228F630 Offset: 0x228DC30 VA: 0x18228F630
	public void .ctor(string name) { }
}

// Namespace: Unity.VisualScripting
[Usage(384, AllowMultiple = False, Inherited = True)]
public class SerializeAttribute : Attribute // TypeDefIndex: 9240
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public interface ISerializedPropertyProvider // TypeDefIndex: 9241
{
	// Properties
	public abstract object item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_item();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_item(object value);
}

// Namespace: Unity.VisualScripting
public abstract class SerializedPropertyProvider<T> : ScriptableObject, ISerializedPropertyProvider // TypeDefIndex: 9242
{
	// Fields
	[SerializeField]
	protected T item; // 0x0

	// Properties
	private object Unity.VisualScripting.ISerializedPropertyProvider.item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private object Unity.VisualScripting.ISerializedPropertyProvider.get_item() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969740 Offset: 0x967D40 VA: 0x180969740
	|-SerializedPropertyProvider<__Il2CppFullySharedGenericType>.Unity.VisualScripting.ISerializedPropertyProvider.get_item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.VisualScripting.ISerializedPropertyProvider.set_item(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9697F0 Offset: 0x967DF0 VA: 0x1809697F0
	|-SerializedPropertyProvider<__Il2CppFullySharedGenericType>.Unity.VisualScripting.ISerializedPropertyProvider.set_item
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	|-SerializedPropertyProvider<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.VisualScripting
[Usage(4, AllowMultiple = False, Inherited = False)]
public sealed class SerializedPropertyProviderAttribute : Attribute, IDecoratorAttribute // TypeDefIndex: 9243
{
	// Fields
	[CompilerGenerated]
	private Type <type>k__BackingField; // 0x10

	// Properties
	public Type type { get; set; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type type) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 7
	public Type get_type() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_type(Type value) { }
}

// Namespace: Unity.VisualScripting
public class StickyNote : GraphElement<IGraph> // TypeDefIndex: 9245
{
	// Fields
	[DoNotSerialize]
	public static readonly Color defaultColor; // 0x0
	[CompilerGenerated]
	private Rect <position>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <title>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <body>k__BackingField; // 0x40
	[CompilerGenerated]
	private StickyNote.ColorEnum <colorTheme>k__BackingField; // 0x48

	// Properties
	[Serialize]
	public Rect position { get; set; }
	[Serialize]
	public string title { get; set; }
	[Serialize]
	[InspectorTextArea(minLines = 1)]
	public string body { get; set; }
	[Serialize]
	[Inspectable]
	public StickyNote.ColorEnum colorTheme { get; set; }

	// Methods

	// RVA: 0x228FF80 Offset: 0x228E580 VA: 0x18228FF80
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1116670 Offset: 0x1114C70 VA: 0x181116670
	public Rect get_position() { }

	[CompilerGenerated]
	// RVA: 0x14DAB40 Offset: 0x14D9140 VA: 0x1814DAB40
	public void set_position(Rect value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public string get_title() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_title(string value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_body() { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_body(string value) { }

	[CompilerGenerated]
	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public StickyNote.ColorEnum get_colorTheme() { }

	[CompilerGenerated]
	// RVA: 0x12DF9A0 Offset: 0x12DDFA0 VA: 0x1812DF9A0
	public void set_colorTheme(StickyNote.ColorEnum value) { }

	// RVA: 0x228FDE0 Offset: 0x228E3E0 VA: 0x18228FDE0
	public static Color GetStickyColor(StickyNote.ColorEnum enumValue) { }

	// RVA: 0x228FDB0 Offset: 0x228E3B0 VA: 0x18228FDB0
	public static Color GetFontColor(StickyNote.ColorEnum enumValue) { }

	// RVA: 0x228FF40 Offset: 0x228E540 VA: 0x18228FF40
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public interface IGizmoDrawer // TypeDefIndex: 9246
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrawGizmos();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnDrawGizmosSelected();
}

// Namespace: Unity.VisualScripting
public interface ISingleton // TypeDefIndex: 9247
{}

// Namespace: Unity.VisualScripting
public interface IUnityObjectOwnable // TypeDefIndex: 9248
{
	// Properties
	public abstract Object owner { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Object get_owner();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_owner(Object value);
}

// Namespace: Unity.VisualScripting
public abstract class LudiqBehaviour : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 9249
{
	// Fields
	[SerializeField]
	[DoNotSerialize]
	protected SerializationData _data; // 0x20

	// Methods

	// RVA: 0x2281510 Offset: 0x227FB10 VA: 0x182281510 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x2281340 Offset: 0x227F940 VA: 0x182281340 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected virtual void OnBeforeSerialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	protected virtual void OnAfterSerialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected virtual void OnBeforeDeserialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	protected virtual void OnAfterDeserialize() { }

	// RVA: 0x2281300 Offset: 0x227F900 VA: 0x182281300 Slot: 10
	protected virtual void ShowData() { }

	// RVA: 0x2281330 Offset: 0x227F930 VA: 0x182281330 Slot: 3
	public override string ToString() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	protected void .ctor() { }
}

// Namespace: Unity.VisualScripting
public abstract class LudiqScriptableObject : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 9250
{
	// Fields
	[SerializeField]
	[DoNotSerialize]
	protected SerializationData _data; // 0x18
	[CompilerGenerated]
	private Action OnDestroyActions; // 0x28

	// Methods

	[CompilerGenerated]
	// RVA: 0x2281A80 Offset: 0x2280080 VA: 0x182281A80
	internal void add_OnDestroyActions(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2281B20 Offset: 0x2280120 VA: 0x182281B20
	internal void remove_OnDestroyActions(Action value) { }

	// RVA: 0x22818C0 Offset: 0x227FEC0 VA: 0x1822818C0 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x22816F0 Offset: 0x227FCF0 VA: 0x1822816F0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 6
	protected virtual void OnBeforeSerialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 7
	protected virtual void OnAfterSerialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 8
	protected virtual void OnBeforeDeserialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 9
	protected virtual void OnAfterDeserialize() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 10
	protected virtual void OnPostDeserializeInEditor() { }

	// RVA: 0x22816D0 Offset: 0x227FCD0 VA: 0x1822816D0
	private void OnDestroy() { }

	// RVA: 0x2280290 Offset: 0x227E890 VA: 0x182280290 Slot: 11
	protected virtual void ShowData() { }

	// RVA: 0x2281330 Offset: 0x227F930 VA: 0x182281330 Slot: 3
	public override string ToString() { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: Unity.VisualScripting
public class MacroScriptableObject : LudiqScriptableObject // TypeDefIndex: 9251
{
	// Methods

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Usage(32767, AllowMultiple = False, Inherited = True)]
public sealed class RequiresUnityAPIAttribute : Attribute // TypeDefIndex: 9252
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public static class SceneSingleton<T> // TypeDefIndex: 9254
{
	// Fields
	private static Dictionary<Scene, T> instances; // 0x0
	private static readonly SingletonAttribute attribute; // 0x0

	// Properties
	private static bool persistent { get; }
	private static bool automatic { get; }
	private static string name { get; }
	private static HideFlags hideFlags { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x968A20 Offset: 0x967020 VA: 0x180968A20
	|-SceneSingleton<object>..cctor
	*/

	// RVA: -1 Offset: -1
	private static bool get_persistent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x968EE0 Offset: 0x9674E0 VA: 0x180968EE0
	|-SceneSingleton<object>.get_persistent
	*/

	// RVA: -1 Offset: -1
	private static bool get_automatic() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x968D00 Offset: 0x967300 VA: 0x180968D00
	|-SceneSingleton<object>.get_automatic
	*/

	// RVA: -1 Offset: -1
	private static string get_name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x968E40 Offset: 0x967440 VA: 0x180968E40
	|-SceneSingleton<object>.get_name
	*/

	// RVA: -1 Offset: -1
	private static HideFlags get_hideFlags() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x968DA0 Offset: 0x9673A0 VA: 0x180968DA0
	|-SceneSingleton<object>.get_hideFlags
	*/

	// RVA: -1 Offset: -1
	private static void EnsureSceneValid(Scene scene) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x967280 Offset: 0x965880 VA: 0x180967280
	|-SceneSingleton<object>.EnsureSceneValid
	*/

	// RVA: -1 Offset: -1
	public static bool InstantiatedIn(Scene scene) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x967FC0 Offset: 0x9665C0 VA: 0x180967FC0
	|-SceneSingleton<object>.InstantiatedIn
	*/

	// RVA: -1 Offset: -1
	public static T InstanceIn(Scene scene) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x967CA0 Offset: 0x9662A0 VA: 0x180967CA0
	|-SceneSingleton<object>.InstanceIn
	*/

	// RVA: -1 Offset: -1
	private static T[] FindInstances(Scene scene) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x967330 Offset: 0x965930 VA: 0x180967330
	|-SceneSingleton<object>.FindInstances
	*/

	// RVA: -1 Offset: -1
	private static T FindOrCreateInstance(Scene scene) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x967590 Offset: 0x965B90 VA: 0x180967590
	|-SceneSingleton<object>.FindOrCreateInstance
	*/

	// RVA: -1 Offset: -1
	public static void Awake(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x966F60 Offset: 0x965560 VA: 0x180966F60
	|-SceneSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	public static void OnDestroy(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9681D0 Offset: 0x9667D0 VA: 0x1809681D0
	|-SceneSingleton<object>.OnDestroy
	*/
}

// Namespace: Unity.VisualScripting
public static class Singleton<T> // TypeDefIndex: 9255
{
	// Fields
	private static readonly SingletonAttribute attribute; // 0x0
	private static readonly object _lock; // 0x0
	private static readonly HashSet<T> awoken; // 0x0
	private static T _instance; // 0x0

	// Properties
	private static bool persistent { get; }
	private static bool automatic { get; }
	private static string name { get; }
	private static HideFlags hideFlags { get; }
	public static bool instantiated { get; }
	public static T instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x973170 Offset: 0x971770 VA: 0x180973170
	|-Singleton<object>..cctor
	*/

	// RVA: -1 Offset: -1
	private static bool get_persistent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x973CF0 Offset: 0x9722F0 VA: 0x180973CF0
	|-Singleton<object>.get_persistent
	*/

	// RVA: -1 Offset: -1
	private static bool get_automatic() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9734F0 Offset: 0x971AF0 VA: 0x1809734F0
	|-Singleton<object>.get_automatic
	*/

	// RVA: -1 Offset: -1
	private static string get_name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x973C50 Offset: 0x972250 VA: 0x180973C50
	|-Singleton<object>.get_name
	*/

	// RVA: -1 Offset: -1
	private static HideFlags get_hideFlags() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x973590 Offset: 0x971B90 VA: 0x180973590
	|-Singleton<object>.get_hideFlags
	*/

	// RVA: -1 Offset: -1
	public static bool get_instantiated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9739B0 Offset: 0x971FB0 VA: 0x1809739B0
	|-Singleton<object>.get_instantiated
	*/

	// RVA: -1 Offset: -1
	public static T get_instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x973630 Offset: 0x971C30 VA: 0x180973630
	|-Singleton<object>.get_instance
	*/

	// RVA: -1 Offset: -1
	private static T[] FindInstances() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9725D0 Offset: 0x970BD0 VA: 0x1809725D0
	|-Singleton<object>.FindInstances
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x972640 Offset: 0x970C40 VA: 0x180972640
	|-Singleton<object>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public static void Awake(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9721F0 Offset: 0x9707F0 VA: 0x1809721F0
	|-Singleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	public static void OnDestroy(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x972F00 Offset: 0x971500 VA: 0x180972F00
	|-Singleton<object>.OnDestroy
	*/
}

// Namespace: Unity.VisualScripting
[Usage(4, Inherited = True, AllowMultiple = False)]
public sealed class SingletonAttribute : Attribute // TypeDefIndex: 9256
{
	// Fields
	[CompilerGenerated]
	private bool <Persistent>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <Automatic>k__BackingField; // 0x11
	[CompilerGenerated]
	private HideFlags <HideFlags>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x18

	// Properties
	public bool Persistent { get; set; }
	public bool Automatic { get; set; }
	public HideFlags HideFlags { get; set; }
	public string Name { get; set; }

	// Methods

	// RVA: 0x228F640 Offset: 0x228DC40 VA: 0x18228F640
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_Persistent() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_Persistent(bool value) { }

	[CompilerGenerated]
	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_Automatic() { }

	[CompilerGenerated]
	// RVA: 0x14B8CA0 Offset: 0x14B72A0 VA: 0x1814B8CA0
	public void set_Automatic(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public HideFlags get_HideFlags() { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_HideFlags(HideFlags value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_Name(string value) { }
}

// Namespace: Unity.VisualScripting
public static class UnityObjectOwnershipUtility // TypeDefIndex: 9257
{
	// Methods

	// RVA: 0x22A1040 Offset: 0x229F640 VA: 0x1822A1040
	public static void CopyOwner(object source, object destination) { }

	// RVA: 0x22A12C0 Offset: 0x229F8C0 VA: 0x1822A12C0
	public static void RemoveOwner(object o) { }

	// RVA: 0x22A11A0 Offset: 0x229F7A0 VA: 0x1822A11A0
	public static Object GetOwner(object o) { }
}

// Namespace: Unity.VisualScripting
public static class UnityThread // TypeDefIndex: 9258
{
	// Fields
	public static Thread thread; // 0x0
	public static Action<Action> editorAsync; // 0x8
	public static ConcurrentQueue<Action> pendingQueue; // 0x10

	// Properties
	public static bool allowsAPI { get; }

	// Methods

	// RVA: 0x22A1530 Offset: 0x229FB30 VA: 0x1822A1530
	public static bool get_allowsAPI() { }

	// RVA: 0x22A1400 Offset: 0x229FA00 VA: 0x1822A1400
	internal static void RuntimeInitialize() { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x22A1320 Offset: 0x229F920 VA: 0x1822A1320
	public static void EditorAsync(Action action) { }

	// RVA: 0x22A1470 Offset: 0x229FA70 VA: 0x1822A1470
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
[Extension]
public static class ComponentHolderProtocol // TypeDefIndex: 9259
{
	// Methods

	// RVA: 0x227FB30 Offset: 0x227E130 VA: 0x18227FB30
	public static bool IsComponentHolderType(Type type) { }

	[Extension]
	// RVA: 0x227FC80 Offset: 0x227E280 VA: 0x18227FC80
	public static bool IsComponentHolder(Object uo) { }

	[Extension]
	// RVA: 0x227F2C0 Offset: 0x227D8C0 VA: 0x18227F2C0
	public static GameObject GameObject(Object uo) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T AddComponent<T>(Object uo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9780 Offset: 0x6B7D80 VA: 0x1806B9780
	|-ComponentHolderProtocol.AddComponent<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(Object uo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9D90 Offset: 0x6B8390 VA: 0x1806B9D90
	|-ComponentHolderProtocol.GetOrAddComponent<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetComponent<T>(Object uo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9A90 Offset: 0x6B8090 VA: 0x1806B9A90
	|-ComponentHolderProtocol.GetComponent<object>
	|
	|-RVA: 0x6B98E0 Offset: 0x6B7EE0 VA: 0x1806B98E0
	|-ComponentHolderProtocol.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetComponentInChildren<T>(Object uo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B98E0 Offset: 0x6B7EE0 VA: 0x1806B98E0
	|-ComponentHolderProtocol.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetComponentInParent<T>(Object uo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B98E0 Offset: 0x6B7EE0 VA: 0x1806B98E0
	|-ComponentHolderProtocol.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] GetComponents<T>(Object uo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9C40 Offset: 0x6B8240 VA: 0x1806B9C40
	|-ComponentHolderProtocol.GetComponents<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] GetComponentsInChildren<T>(Object uo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9C40 Offset: 0x6B8240 VA: 0x1806B9C40
	|-ComponentHolderProtocol.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] GetComponentsInParent<T>(Object uo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6B9C40 Offset: 0x6B8240 VA: 0x1806B9C40
	|-ComponentHolderProtocol.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x227F630 Offset: 0x227DC30 VA: 0x18227F630
	public static Component GetComponent(Object uo, Type type) { }

	[Extension]
	// RVA: 0x227F3B0 Offset: 0x227D9B0 VA: 0x18227F3B0
	public static Component GetComponentInChildren(Object uo, Type type) { }

	[Extension]
	// RVA: 0x227F4F0 Offset: 0x227DAF0 VA: 0x18227F4F0
	public static Component GetComponentInParent(Object uo, Type type) { }

	[Extension]
	// RVA: 0x227F9F0 Offset: 0x227DFF0 VA: 0x18227F9F0
	public static Component[] GetComponents(Object uo, Type type) { }

	[Extension]
	// RVA: 0x227F770 Offset: 0x227DD70 VA: 0x18227F770
	public static Component[] GetComponentsInChildren(Object uo, Type type) { }

	[Extension]
	// RVA: 0x227F8B0 Offset: 0x227DEB0 VA: 0x18227F8B0
	public static Component[] GetComponentsInParent(Object uo, Type type) { }
}

// Namespace: Unity.VisualScripting
[Singleton(Name = "VisualScripting CoroutineRunner", Automatic = True, Persistent = True)]
[AddComponentMenu("")]
[DisableAnnotation]
[IncludeInSettings(False)]
public sealed class CoroutineRunner : MonoBehaviour, ISingleton // TypeDefIndex: 9260
{
	// Properties
	public static CoroutineRunner instance { get; }

	// Methods

	// RVA: 0x22A4610 Offset: 0x22A2C10 VA: 0x1822A4610
	private void Awake() { }

	// RVA: 0x22A4670 Offset: 0x22A2C70 VA: 0x1822A4670
	private void OnDestroy() { }

	// RVA: 0x22A46E0 Offset: 0x22A2CE0 VA: 0x1822A46E0
	public static CoroutineRunner get_instance() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Extension]
public static class CSharpNameUtility // TypeDefIndex: 9262
{
	// Fields
	private static readonly Dictionary<Type, string> primitives; // 0x0
	public static readonly Dictionary<string, string> operators; // 0x8
	private static readonly HashSet<char> illegalTypeFileNameCharacters; // 0x10

	// Methods

	[Extension]
	// RVA: 0x22A3590 Offset: 0x22A1B90 VA: 0x1822A3590
	public static string CSharpName(MemberInfo member, ActionDirection direction) { }

	[Extension]
	// RVA: 0x22A2F60 Offset: 0x22A1560 VA: 0x1822A2F60
	public static string CSharpName(Type type, bool includeGenericParameters = True) { }

	[Extension]
	// RVA: 0x22A2F00 Offset: 0x22A1500 VA: 0x1822A2F00
	public static string CSharpFullName(Type type, bool includeGenericParameters = True) { }

	[Extension]
	// RVA: 0x22A3910 Offset: 0x22A1F10 VA: 0x1822A3910
	public static string CSharpUniqueName(Type type, bool includeGenericParameters = True) { }

	[Extension]
	// RVA: 0x22A2BD0 Offset: 0x22A11D0 VA: 0x1822A2BD0
	public static string CSharpFileName(Type type, bool includeNamespace, bool includeGenericParameters = False) { }

	[Extension]
	// RVA: 0x22A2FC0 Offset: 0x22A15C0 VA: 0x1822A2FC0
	private static string CSharpName(Type type, TypeQualifier qualifier, bool includeGenericParameters = True) { }

	// RVA: 0x22A3970 Offset: 0x22A1F70 VA: 0x1822A3970
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public static class Empty<T> // TypeDefIndex: 9263
{
	// Fields
	public static readonly T[] array; // 0x0
	public static readonly List<T> list; // 0x0
	public static readonly HashSet<T> hashSet; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE90BE0 Offset: 0xE8F1E0 VA: 0x180E90BE0
	|-Empty<object>..cctor
	|
	|-RVA: 0xE90E80 Offset: 0xE8F480 VA: 0x180E90E80
	|-Empty<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.VisualScripting
[Extension]
public static class EnumUtility // TypeDefIndex: 9266
{
	// Methods

	[Extension]
	// RVA: 0x22A4740 Offset: 0x22A2D40 VA: 0x1822A4740
	public static bool HasFlag(Enum value, Enum flag) { }

	// RVA: 0x22A47B0 Offset: 0x22A2DB0 VA: 0x1822A47B0
	public static Dictionary<string, Enum> ValuesByNames(Type enumType, bool obsolete = False) { }

	// RVA: -1 Offset: -1
	public static Dictionary<string, T> ValuesByNames<T>(bool obsolete = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6D9CA0 Offset: 0x6D82A0 VA: 0x1806D9CA0
	|-EnumUtility.ValuesByNames<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.VisualScripting
[Extension]
public static class ExceptionUtility // TypeDefIndex: 9267
{
	// Methods

	[Extension]
	// RVA: 0x22A4B00 Offset: 0x22A3100 VA: 0x1822A4B00
	public static Exception Relevant(Exception ex) { }
}

// Namespace: Unity.VisualScripting
public static class HashUtility // TypeDefIndex: 9268
{
	// Methods

	// RVA: -1 Offset: -1
	public static int GetHashCode<T>(T a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x709380 Offset: 0x707980 VA: 0x180709380
	|-HashUtility.GetHashCode<object>
	|
	|-RVA: 0x709120 Offset: 0x707720 VA: 0x180709120
	|-HashUtility.GetHashCode<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int GetHashCode<T1, T2>(T1 a, T2 b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x709310 Offset: 0x707910 VA: 0x180709310
	|-HashUtility.GetHashCode<object, object>
	|
	|-RVA: 0x708EC0 Offset: 0x7074C0 VA: 0x180708EC0
	|-HashUtility.GetHashCode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int GetHashCode<T1, T2, T3>(T1 a, T2 b, T3 c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x709270 Offset: 0x707870 VA: 0x180709270
	|-HashUtility.GetHashCode<object, object, object>
	|
	|-RVA: 0x708B30 Offset: 0x707130 VA: 0x180708B30
	|-HashUtility.GetHashCode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int GetHashCode<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x708660 Offset: 0x706C60 VA: 0x180708660
	|-HashUtility.GetHashCode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int GetHashCode<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x708070 Offset: 0x706670 VA: 0x180708070
	|-HashUtility.GetHashCode<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22A9FA0 Offset: 0x22A85A0 VA: 0x1822A9FA0
	public static int GetHashCodeAlloc(object[] values) { }
}

// Namespace: Unity.VisualScripting
public interface IAnalyticsIdentifiable // TypeDefIndex: 9269
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AnalyticsIdentifier GetAnalyticsIdentifier();
}

// Namespace: Unity.VisualScripting
public class AnalyticsIdentifier // TypeDefIndex: 9270
{
	// Fields
	public string Identifier; // 0x10
	public string Namespace; // 0x18
	public int Hashcode; // 0x20

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
public interface IGettable // TypeDefIndex: 9271
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetValue();
}

// Namespace: Unity.VisualScripting
[Extension]
public static class XGettable // TypeDefIndex: 9272
{
	// Methods

	[Extension]
	// RVA: 0x22B42E0 Offset: 0x22B28E0 VA: 0x1822B42E0
	public static object GetValue(IGettable gettable, Type type) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetValue<T>(IGettable gettable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8149D0 Offset: 0x812FD0 VA: 0x1808149D0
	|-XGettable.GetValue<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.VisualScripting
public interface IIdentifiable // TypeDefIndex: 9273
{
	// Properties
	public abstract Guid guid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Guid get_guid();
}

// Namespace: Unity.VisualScripting
public interface IInitializable // TypeDefIndex: 9274
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize();
}

// Namespace: Unity.VisualScripting
[Extension]
public static class LinqUtility // TypeDefIndex: 9283
{
	// Methods

	[IteratorStateMachine(typeof(LinqUtility.<Concat>d__0<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> Concat<T>(IEnumerable[] enumerables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DC610 Offset: 0x6DAC10 VA: 0x1806DC610
	|-LinqUtility.Concat<object>
	|
	|-RVA: 0x6DC4C0 Offset: 0x6DAAC0 VA: 0x1806DC4C0
	|-LinqUtility.Concat<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> DistinctBy<T, TKey>(IEnumerable<T> items, Func<T, TKey> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x727D20 Offset: 0x726320 VA: 0x180727D20
	|-LinqUtility.DistinctBy<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> NotNull<T>(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x728640 Offset: 0x726C40 VA: 0x180728640
	|-LinqUtility.NotNull<object>
	|
	|-RVA: 0x7284B0 Offset: 0x726AB0 VA: 0x1807284B0
	|-LinqUtility.NotNull<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqUtility.<Yield>d__3<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> Yield<T>(T t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6DC610 Offset: 0x6DAC10 VA: 0x1806DC610
	|-LinqUtility.Yield<object>
	|
	|-RVA: 0x729880 Offset: 0x727E80 VA: 0x180729880
	|-LinqUtility.Yield<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static HashSet<T> ToHashSet<T>(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x729810 Offset: 0x727E10 VA: 0x180729810
	|-LinqUtility.ToHashSet<object>
	|
	|-RVA: 0x7297A0 Offset: 0x727DA0 VA: 0x1807297A0
	|-LinqUtility.ToHashSet<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddRange<T>(ICollection<T> collection, IEnumerable<T> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x727710 Offset: 0x725D10 VA: 0x180727710
	|-LinqUtility.AddRange<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: 0x22AB200 Offset: 0x22A9800 VA: 0x1822AB200
	public static void AddRange(IList list, IEnumerable items) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static ICollection<T> AsReadOnlyCollection<T>(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7279F0 Offset: 0x725FF0 VA: 0x1807279F0
	|-LinqUtility.AsReadOnlyCollection<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IList<T> AsReadOnlyList<T>(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7279F0 Offset: 0x725FF0 VA: 0x1807279F0
	|-LinqUtility.AsReadOnlyList<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> Flatten<T>(IEnumerable<T> source, Func<T, IEnumerable<T>> childrenSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x727ED0 Offset: 0x7264D0 VA: 0x180727ED0
	|-LinqUtility.Flatten<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> IntersectAll<T>(IEnumerable<IEnumerable<T>> groups) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x728210 Offset: 0x726810 VA: 0x180728210
	|-LinqUtility.IntersectAll<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> OrderByDependencies<T>(IEnumerable<T> source, Func<T, IEnumerable<T>> getDependencies, bool throwOnCycle = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x728D30 Offset: 0x727330 VA: 0x180728D30
	|-LinqUtility.OrderByDependencies<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void OrderByDependenciesVisit<T>(T item, HashSet<T> visited, List<T> sorted, Func<T, IEnumerable<T>> getDependencies, bool throwOnCycle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7287C0 Offset: 0x726DC0 VA: 0x1807287C0
	|-LinqUtility.OrderByDependenciesVisit<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> OrderByDependers<T>(IEnumerable<T> source, Func<T, IEnumerable<T>> getDependers, bool throwOnCycle = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x729080 Offset: 0x727680 VA: 0x180729080
	|-LinqUtility.OrderByDependers<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(LinqUtility.<Catch>d__14<T>))]
	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> Catch<T>(IEnumerable<T> source, Action<Exception> catch) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6E3010 Offset: 0x6E1610 VA: 0x1806E3010
	|-LinqUtility.Catch<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> Catch<T>(IEnumerable<T> source, ICollection<Exception> exceptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x727BA0 Offset: 0x7261A0 VA: 0x180727BA0
	|-LinqUtility.Catch<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> CatchAsLogError<T>(IEnumerable<T> source, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x727AC0 Offset: 0x7260C0 VA: 0x180727AC0
	|-LinqUtility.CatchAsLogError<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> CatchAsLogWarning<T>(IEnumerable<T> source, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x727AC0 Offset: 0x7260C0 VA: 0x180727AC0
	|-LinqUtility.CatchAsLogWarning<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.VisualScripting
public class OverrideStack<T> // TypeDefIndex: 9284
{
	// Fields
	private readonly Func<T> getValue; // 0x0
	private readonly Action<T> setValue; // 0x0
	private readonly Action clearValue; // 0x0
	private T _value; // 0x0
	private readonly Stack<T> previous; // 0x0

	// Properties
	public T value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2870 Offset: 0x12E0E70 VA: 0x1812E2870
	|-OverrideStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> getValue, Action<T> setValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2C20 Offset: 0x12E1220 VA: 0x1812E2C20
	|-OverrideStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> getValue, Action<T> setValue, Action clearValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2B00 Offset: 0x12E1100 VA: 0x1812E2B00
	|-OverrideStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2E50 Offset: 0x12E1450 VA: 0x1812E2E50
	|-OverrideStack<__Il2CppFullySharedGenericType>.get_value
	*/

	// RVA: -1 Offset: -1
	internal void set_value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E30F0 Offset: 0x12E16F0 VA: 0x1812E30F0
	|-OverrideStack<__Il2CppFullySharedGenericType>.set_value
	*/

	// RVA: -1 Offset: -1
	public OverrideLayer<T> Override(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E25D0 Offset: 0x12E0BD0 VA: 0x1812E25D0
	|-OverrideStack<__Il2CppFullySharedGenericType>.Override
	*/

	// RVA: -1 Offset: -1
	public void BeginOverride(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E21E0 Offset: 0x12E07E0 VA: 0x1812E21E0
	|-OverrideStack<__Il2CppFullySharedGenericType>.BeginOverride
	*/

	// RVA: -1 Offset: -1
	public void EndOverride() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E23A0 Offset: 0x12E09A0 VA: 0x1812E23A0
	|-OverrideStack<__Il2CppFullySharedGenericType>.EndOverride
	*/

	// RVA: -1 Offset: -1
	public static T op_Implicit(OverrideStack<T> stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E2F20 Offset: 0x12E1520 VA: 0x1812E2F20
	|-OverrideStack<__Il2CppFullySharedGenericType>.op_Implicit
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private T <.ctor>b__0_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E26F0 Offset: 0x12E0CF0 VA: 0x1812E26F0
	|-OverrideStack<__Il2CppFullySharedGenericType>.<.ctor>b__0_0
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <.ctor>b__0_1(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E27A0 Offset: 0x12E0DA0 VA: 0x1812E27A0
	|-OverrideStack<__Il2CppFullySharedGenericType>.<.ctor>b__0_1
	*/
}

// Namespace: Unity.VisualScripting
public struct OverrideLayer<T> : IDisposable // TypeDefIndex: 9285
{
	// Fields
	[CompilerGenerated]
	private readonly OverrideStack<T> <stack>k__BackingField; // 0x0

	// Properties
	public OverrideStack<T> stack { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public OverrideStack<T> get_stack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x731C90 Offset: 0x730290 VA: 0x180731C90
	|-OverrideLayer<__Il2CppFullySharedGenericType>.get_stack
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(OverrideStack<T> stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E1FC0 Offset: 0x12E05C0 VA: 0x1812E1FC0
	|-OverrideLayer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E1EF0 Offset: 0x12E04F0 VA: 0x1812E1EF0
	|-OverrideLayer<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: Unity.VisualScripting
public class Recursion<T> : IPoolable, IDisposable // TypeDefIndex: 9287
{
	// Fields
	private readonly Stack<T> traversedOrder; // 0x0
	private readonly Dictionary<T, int> traversedCount; // 0x0
	private bool disposed; // 0x0
	protected int maxDepth; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95AB10 Offset: 0x959110 VA: 0x18095AB10
	|-Recursion<object>..ctor
	|
	|-RVA: 0x95AA40 Offset: 0x959040 VA: 0x18095AA40
	|-Recursion<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Enter(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x958E00 Offset: 0x957400 VA: 0x180958E00
	|-Recursion<object>.Enter
	|
	|-RVA: 0x958C80 Offset: 0x957280 VA: 0x180958C80
	|-Recursion<__Il2CppFullySharedGenericType>.Enter
	*/

	// RVA: -1 Offset: -1
	public bool TryEnter(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95A7C0 Offset: 0x958DC0 VA: 0x18095A7C0
	|-Recursion<object>.TryEnter
	|
	|-RVA: 0x95A2D0 Offset: 0x9588D0 VA: 0x18095A2D0
	|-Recursion<__Il2CppFullySharedGenericType>.TryEnter
	*/

	// RVA: -1 Offset: -1
	public void Exit(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9595A0 Offset: 0x957BA0 VA: 0x1809595A0
	|-Recursion<object>.Exit
	|
	|-RVA: 0x959030 Offset: 0x957630 VA: 0x180959030
	|-Recursion<__Il2CppFullySharedGenericType>.Exit
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x958C00 Offset: 0x957200 VA: 0x180958C00
	|-Recursion<object>.Dispose
	|-Recursion<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void Free() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x959860 Offset: 0x957E60 VA: 0x180959860
	|-Recursion<object>.Free
	|
	|-RVA: 0x9598D0 Offset: 0x957ED0 VA: 0x1809598D0
	|-Recursion<__Il2CppFullySharedGenericType>.Free
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void Unity.VisualScripting.IPoolable.New() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50E170 Offset: 0x50C770 VA: 0x18050E170
	|-Recursion<object>.Unity.VisualScripting.IPoolable.New
	|-Recursion<__Il2CppFullySharedGenericType>.Unity.VisualScripting.IPoolable.New
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.VisualScripting.IPoolable.Free() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95A9D0 Offset: 0x958FD0 VA: 0x18095A9D0
	|-Recursion<object>.Unity.VisualScripting.IPoolable.Free
	|
	|-RVA: 0x95A960 Offset: 0x958F60 VA: 0x18095A960
	|-Recursion<__Il2CppFullySharedGenericType>.Unity.VisualScripting.IPoolable.Free
	*/

	// RVA: -1 Offset: -1
	public static Recursion<T> New() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x959940 Offset: 0x957F40 VA: 0x180959940
	|-Recursion<object>.New
	|
	|-RVA: 0x959A00 Offset: 0x958000 VA: 0x180959A00
	|-Recursion<__Il2CppFullySharedGenericType>.New
	*/

	// RVA: -1 Offset: -1
	public static Recursion<T> New(int maxDepth) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x959F00 Offset: 0x958500 VA: 0x180959F00
	|-Recursion<object>.New
	|
	|-RVA: 0x959AF0 Offset: 0x9580F0 VA: 0x180959AF0
	|-Recursion<__Il2CppFullySharedGenericType>.New
	*/
}

// Namespace: Unity.VisualScripting
public sealed class Recursion : Recursion<object> // TypeDefIndex: 9289
{
	// Fields
	[CompilerGenerated]
	private static int <defaultMaxDepth>k__BackingField; // 0x0
	[CompilerGenerated]
	private static bool <safeMode>k__BackingField; // 0x4

	// Properties
	public static int defaultMaxDepth { get; set; }
	public static bool safeMode { get; set; }

	// Methods

	// RVA: 0x22AD180 Offset: 0x22AB780 VA: 0x1822AD180
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x22AD1C0 Offset: 0x22AB7C0 VA: 0x1822AD1C0
	public static int get_defaultMaxDepth() { }

	[CompilerGenerated]
	// RVA: 0x22AD260 Offset: 0x22AB860 VA: 0x1822AD260
	public static void set_defaultMaxDepth(int value) { }

	[CompilerGenerated]
	// RVA: 0x22AD210 Offset: 0x22AB810 VA: 0x1822AD210
	public static bool get_safeMode() { }

	[CompilerGenerated]
	// RVA: 0x22AD2C0 Offset: 0x22AB8C0 VA: 0x1822AD2C0
	public static void set_safeMode(bool value) { }

	// RVA: 0x22AD040 Offset: 0x22AB640 VA: 0x1822AD040
	internal static void OnRuntimeMethodLoad() { }

	// RVA: 0x22ACD40 Offset: 0x22AB340 VA: 0x1822ACD40 Slot: 7
	protected override void Free() { }

	// RVA: 0x22ACDA0 Offset: 0x22AB3A0 VA: 0x1822ACDA0
	public static Recursion New() { }

	// RVA: 0x22ACE30 Offset: 0x22AB430 VA: 0x1822ACE30
	public static Recursion New(int maxDepth) { }

	// RVA: 0x22AD140 Offset: 0x22AB740 VA: 0x1822AD140
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public static class ReferenceCollector // TypeDefIndex: 9291
{
	// Fields
	[CompilerGenerated]
	private static Action onSceneUnloaded; // 0x0

	// Methods

	[CompilerGenerated]
	// RVA: 0x22AD430 Offset: 0x22ABA30 VA: 0x1822AD430
	public static void add_onSceneUnloaded(Action value) { }

	[CompilerGenerated]
	// RVA: 0x22AD4F0 Offset: 0x22ABAF0 VA: 0x1822AD4F0
	public static void remove_onSceneUnloaded(Action value) { }

	// RVA: 0x22AD320 Offset: 0x22AB920 VA: 0x1822AD320
	internal static void Initialize() { }
}

// Namespace: Unity.VisualScripting
public class ReferenceEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 9292
{
	// Fields
	public static readonly ReferenceEqualityComparer Instance; // 0x0

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	private void .ctor() { }

	// RVA: 0x95BC90 Offset: 0x95A290 VA: 0x18095BC90 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object a, object b) { }

	// RVA: 0x22AD5B0 Offset: 0x22ABBB0 VA: 0x1822AD5B0 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object a) { }

	// RVA: 0x95BB90 Offset: 0x95A190 VA: 0x18095BB90
	public static int GetHashCode(object a) { }

	// RVA: 0x22AD600 Offset: 0x22ABC00 VA: 0x1822AD600
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public class ReferenceEqualityComparer<T> : IEqualityComparer<T> // TypeDefIndex: 9293
{
	// Fields
	public static readonly ReferenceEqualityComparer<T> Instance; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-ReferenceEqualityComparer<object>..ctor
	|-ReferenceEqualityComparer<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<T>.Equals(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95BC90 Offset: 0x95A290 VA: 0x18095BC90
	|-ReferenceEqualityComparer<object>.System.Collections.Generic.IEqualityComparer<T>.Equals
	|
	|-RVA: 0x95BCA0 Offset: 0x95A2A0 VA: 0x18095BCA0
	|-ReferenceEqualityComparer<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEqualityComparer<T>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<T>.GetHashCode(T a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95BDC0 Offset: 0x95A3C0 VA: 0x18095BDC0
	|-ReferenceEqualityComparer<object>.System.Collections.Generic.IEqualityComparer<T>.GetHashCode
	|
	|-RVA: 0x95BE10 Offset: 0x95A410 VA: 0x18095BE10
	|-ReferenceEqualityComparer<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEqualityComparer<T>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static int GetHashCode(T a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95BB90 Offset: 0x95A190 VA: 0x18095BB90
	|-ReferenceEqualityComparer<object>.GetHashCode
	|
	|-RVA: 0x95BBA0 Offset: 0x95A1A0 VA: 0x18095BBA0
	|-ReferenceEqualityComparer<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95C040 Offset: 0x95A640 VA: 0x18095C040
	|-ReferenceEqualityComparer<object>..cctor
	|
	|-RVA: 0x95BF20 Offset: 0x95A520 VA: 0x18095BF20
	|-ReferenceEqualityComparer<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.VisualScripting
public static class RuntimeVSUsageUtility // TypeDefIndex: 9294
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x22AD670 Offset: 0x22ABC70 VA: 0x1822AD670
	private static void RuntimeInitializeOnLoadBeforeSceneLoad() { }
}

// Namespace: Unity.VisualScripting
[Extension]
public static class StringUtility // TypeDefIndex: 9297
{
	// Fields
	private static readonly Regex guidRegex; // 0x0

	// Methods

	// RVA: 0x22AFC90 Offset: 0x22AE290 VA: 0x1822AFC90
	public static bool IsNullOrWhiteSpace(string s) { }

	// RVA: 0x22AF600 Offset: 0x22ADC00 VA: 0x1822AF600
	public static string FallbackEmpty(string s, string fallback) { }

	// RVA: 0x22AF630 Offset: 0x22ADC30 VA: 0x1822AF630
	public static string FallbackWhitespace(string s, string fallback) { }

	[Extension]
	// RVA: 0x22AF3C0 Offset: 0x22AD9C0 VA: 0x1822AF3C0
	public static void AppendLineFormat(StringBuilder sb, string format, object[] args) { }

	[Extension]
	// RVA: 0x22B0EE0 Offset: 0x22AF4E0 VA: 0x1822B0EE0
	public static string ToSeparatedString(IEnumerable enumerable, string separator) { }

	[Extension]
	// RVA: 0x22B0DB0 Offset: 0x22AF3B0 VA: 0x1822B0DB0
	public static string ToCommaSeparatedString(IEnumerable enumerable) { }

	[Extension]
	// RVA: 0x22B0E80 Offset: 0x22AF480 VA: 0x1822B0E80
	public static string ToLineSeparatedString(IEnumerable enumerable) { }

	[Extension]
	// RVA: 0x22AF3F0 Offset: 0x22AD9F0 VA: 0x1822AF3F0
	public static bool ContainsInsensitive(string haystack, string needle) { }

	[IteratorStateMachine(typeof(StringUtility.<AllIndexesOf>d__8))]
	[Extension]
	// RVA: 0x22AF330 Offset: 0x22AD930 VA: 0x1822AF330
	public static IEnumerable<int> AllIndexesOf(string haystack, string needle) { }

	[Extension]
	// RVA: 0x22AF8C0 Offset: 0x22ADEC0 VA: 0x1822AF8C0
	public static string Filter(string s, bool letters = True, bool numbers = True, bool whitespace = True, bool symbols = True, bool punctuation = True) { }

	[Extension]
	// RVA: 0x22AF6C0 Offset: 0x22ADCC0 VA: 0x1822AF6C0
	public static string FilterReplace(string s, char replacement, bool merge, bool letters = True, bool numbers = True, bool whitespace = True, bool symbols = True, bool punctuation = True) { }

	[Extension]
	// RVA: 0x22B0660 Offset: 0x22AEC60 VA: 0x1822B0660
	public static string Prettify(string s) { }

	// RVA: 0x22B0170 Offset: 0x22AE770 VA: 0x1822B0170
	public static bool IsWordDelimiter(char c) { }

	// RVA: 0x22AFE80 Offset: 0x22AE480 VA: 0x1822AFE80
	public static bool IsWordBeginning(Nullable<char> previous, char current, Nullable<char> next) { }

	// RVA: 0x22AFCD0 Offset: 0x22AE2D0 VA: 0x1822AFCD0
	public static bool IsWordBeginning(string s, int index) { }

	[Extension]
	// RVA: 0x22B0A90 Offset: 0x22AF090 VA: 0x1822B0A90
	public static string SplitWords(string s, char separator) { }

	[Extension]
	// RVA: 0x22B0850 Offset: 0x22AEE50 VA: 0x1822B0850
	public static string RemoveConsecutiveCharacters(string s, char c) { }

	[Extension]
	// RVA: 0x22B0930 Offset: 0x22AEF30 VA: 0x1822B0930
	public static string ReplaceMultiple(string s, HashSet<char> haystacks, char replacement) { }

	[Extension]
	// RVA: 0x22B1110 Offset: 0x22AF710 VA: 0x1822B1110
	public static string Truncate(string value, int maxLength, string suffix = "...") { }

	[Extension]
	// RVA: 0x22B1050 Offset: 0x22AF650 VA: 0x1822B1050
	public static string TrimEnd(string source, string value) { }

	[Extension]
	// RVA: 0x22B10B0 Offset: 0x22AF6B0 VA: 0x1822B10B0
	public static string TrimStart(string source, string value) { }

	[Extension]
	// RVA: 0x22AFA80 Offset: 0x22AE080 VA: 0x1822AFA80
	public static string FirstCharacterToLower(string s) { }

	[Extension]
	// RVA: 0x22AFB50 Offset: 0x22AE150 VA: 0x1822AFB50
	public static string FirstCharacterToUpper(string s) { }

	[Extension]
	// RVA: 0x22B02F0 Offset: 0x22AE8F0 VA: 0x1822B02F0
	public static string PartBefore(string s, char c) { }

	[Extension]
	// RVA: 0x22B0230 Offset: 0x22AE830 VA: 0x1822B0230
	public static string PartAfter(string s, char c) { }

	[Extension]
	// RVA: 0x22B03B0 Offset: 0x22AE9B0 VA: 0x1822B03B0
	public static void PartsAround(string s, char c, out string before, out string after) { }

	[Extension]
	// RVA: 0x22AF560 Offset: 0x22ADB60 VA: 0x1822AF560
	public static bool EndsWith(string s, char c) { }

	[Extension]
	// RVA: 0x22B0BB0 Offset: 0x22AF1B0 VA: 0x1822B0BB0
	public static bool StartsWith(string s, char c) { }

	[Extension]
	// RVA: 0x22AF420 Offset: 0x22ADA20 VA: 0x1822AF420
	public static bool Contains(string s, char c) { }

	[Extension]
	// RVA: 0x22B01F0 Offset: 0x22AE7F0 VA: 0x1822B01F0
	public static string NullIfEmpty(string s) { }

	[Extension]
	// RVA: 0x22B0CC0 Offset: 0x22AF2C0 VA: 0x1822B0CC0
	public static string ToBinaryString(int value) { }

	[Extension]
	// RVA: 0x22B0C50 Offset: 0x22AF250 VA: 0x1822B0C50
	public static string ToBinaryString(long value) { }

	[Extension]
	// RVA: 0x22B0D30 Offset: 0x22AF330 VA: 0x1822B0D30
	public static string ToBinaryString(Enum value) { }

	[Extension]
	// RVA: 0x22AF4F0 Offset: 0x22ADAF0 VA: 0x1822AF4F0
	public static int CountIndices(string s, char c) { }

	// RVA: 0x22AFC20 Offset: 0x22AE220 VA: 0x1822AFC20
	public static bool IsGuid(string value) { }

	// RVA: 0x22B04C0 Offset: 0x22AEAC0 VA: 0x1822B04C0
	public static string PathEllipsis(string s, int maxLength) { }

	[Extension]
	// RVA: 0x22B0E10 Offset: 0x22AF410 VA: 0x1822B0E10
	public static string ToHexString(byte[] bytes) { }

	// RVA: 0x22B1160 Offset: 0x22AF760 VA: 0x1822B1160
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
[Extension]
public static class UnityObjectUtility // TypeDefIndex: 9300
{
	// Methods

	[Extension]
	// RVA: 0x22B20F0 Offset: 0x22B06F0 VA: 0x1822B20F0
	public static bool IsDestroyed(Object target) { }

	[Extension]
	// RVA: 0x22B2150 Offset: 0x22B0750 VA: 0x1822B2150
	public static bool IsUnityNull(object obj) { }

	[Extension]
	// RVA: 0x22B2210 Offset: 0x22B0810 VA: 0x1822B2210
	public static string ToSafeString(Object uo) { }

	[Extension]
	// RVA: 0x22B2450 Offset: 0x22B0A50 VA: 0x1822B2450
	public static string ToSafeString(object obj) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T AsUnityNull<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x805000 Offset: 0x803600 VA: 0x180805000
	|-UnityObjectUtility.AsUnityNull<object>
	*/

	// RVA: 0x22B2630 Offset: 0x22B0C30 VA: 0x1822B2630
	public static bool TrulyEqual(Object a, Object b) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> NotUnityNull<T>(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x728640 Offset: 0x726C40 VA: 0x180728640
	|-UnityObjectUtility.NotUnityNull<object>
	*/

	[IteratorStateMachine(typeof(UnityObjectUtility.<FindObjectsOfTypeIncludingInactive>d__7<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> FindObjectsOfTypeIncludingInactive<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x805060 Offset: 0x803660 VA: 0x180805060
	|-UnityObjectUtility.FindObjectsOfTypeIncludingInactive<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.VisualScripting
[Extension]
public static class XColor // TypeDefIndex: 9301
{
	// Methods

	[Extension]
	// RVA: 0x22B41C0 Offset: 0x22B27C0 VA: 0x1822B41C0
	public static string ToHexString(Color color) { }
}

// Namespace: Unity.VisualScripting
public static class ApplicationVariables // TypeDefIndex: 9302
{
	// Fields
	public const string assetPath = "ApplicationVariables";
	private static VariablesAsset _asset; // 0x0
	[CompilerGenerated]
	private static VariableDeclarations <runtime>k__BackingField; // 0x8

	// Properties
	public static VariablesAsset asset { get; }
	public static VariableDeclarations runtime { get; set; }
	public static VariableDeclarations initial { get; }
	public static VariableDeclarations current { get; }

	// Methods

	// RVA: 0x22A2210 Offset: 0x22A0810 VA: 0x1822A2210
	public static VariablesAsset get_asset() { }

	// RVA: 0x22A2170 Offset: 0x22A0770 VA: 0x1822A2170
	public static void Load() { }

	[CompilerGenerated]
	// RVA: 0x22A23D0 Offset: 0x22A09D0 VA: 0x1822A23D0
	public static VariableDeclarations get_runtime() { }

	[CompilerGenerated]
	// RVA: 0x22A2410 Offset: 0x22A0A10 VA: 0x1822A2410
	private static void set_runtime(VariableDeclarations value) { }

	// RVA: 0x22A23B0 Offset: 0x22A09B0 VA: 0x1822A23B0
	public static VariableDeclarations get_initial() { }

	// RVA: 0x22A2320 Offset: 0x22A0920 VA: 0x1822A2320
	public static VariableDeclarations get_current() { }

	// RVA: 0x22A2110 Offset: 0x22A0710 VA: 0x1822A2110
	public static void OnEnterEditMode() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public static void OnExitEditMode() { }

	// RVA: 0x22A2040 Offset: 0x22A0640 VA: 0x1822A2040
	internal static void OnEnterPlayMode() { }

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	internal static void OnExitPlayMode() { }

	// RVA: 0x22A2040 Offset: 0x22A0640 VA: 0x1822A2040
	private static void CreateRuntimeDeclarations() { }

	// RVA: 0x22A2110 Offset: 0x22A0710 VA: 0x1822A2110
	private static void DestroyRuntimeDeclarations() { }
}

// Namespace: Unity.VisualScripting
public interface IGraphDataWithVariables : IGraphData // TypeDefIndex: 9303
{
	// Properties
	public abstract VariableDeclarations variables { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract VariableDeclarations get_variables();
}

// Namespace: Unity.VisualScripting
public interface IGraphWithVariables : IGraph, IDisposable, IPrewarmable, IAotStubbable, ISerializationDepender, ISerializationCallbackReceiver // TypeDefIndex: 9304
{
	// Properties
	public abstract VariableDeclarations variables { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract VariableDeclarations get_variables();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerable<string> GetDynamicVariableNames(VariableKind kind, GraphReference reference);
}

// Namespace: Unity.VisualScripting
[Usage(2432, AllowMultiple = False, Inherited = True)]
public sealed class InspectorVariableNameAttribute : Attribute // TypeDefIndex: 9305
{
	// Fields
	[CompilerGenerated]
	private ActionDirection <direction>k__BackingField; // 0x10

	// Properties
	public ActionDirection direction { get; set; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(ActionDirection direction) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public ActionDirection get_direction() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	private void set_direction(ActionDirection value) { }
}

// Namespace: Unity.VisualScripting
public static class ObjectVariables // TypeDefIndex: 9306
{
	// Methods

	// RVA: 0x22AB490 Offset: 0x22A9A90 VA: 0x1822AB490
	public static VariableDeclarations Declarations(GameObject source, bool autoAddComponent, bool throwOnMissing) { }
}

// Namespace: Unity.VisualScripting
public static class SavedVariables // TypeDefIndex: 9308
{
	// Fields
	public const string assetPath = "SavedVariables";
	public const string playerPrefsKey = "LudiqSavedVariables";
	private static VariablesAsset _asset; // 0x0
	[CompilerGenerated]
	private static VariableDeclarations <saved>k__BackingField; // 0x8
	[CompilerGenerated]
	private static VariableDeclarations <merged>k__BackingField; // 0x10

	// Properties
	public static VariablesAsset asset { get; }
	public static VariableDeclarations initial { get; }
	public static VariableDeclarations saved { get; set; }
	public static VariableDeclarations merged { get; set; }
	public static VariableDeclarations current { get; }

	// Methods

	// RVA: 0x22AEB80 Offset: 0x22AD180 VA: 0x1822AEB80
	public static VariablesAsset get_asset() { }

	// RVA: 0x22ADC90 Offset: 0x22AC290 VA: 0x1822ADC90
	public static void Load() { }

	// RVA: 0x22AE490 Offset: 0x22ACA90 VA: 0x1822AE490
	public static void OnEnterEditMode() { }

	// RVA: 0x22AE6B0 Offset: 0x22ACCB0 VA: 0x1822AE6B0
	public static void OnExitEditMode() { }

	// RVA: 0x22AE4F0 Offset: 0x22ACAF0 VA: 0x1822AE4F0
	internal static void OnEnterPlayMode() { }

	// RVA: 0x22AE6F0 Offset: 0x22ACCF0 VA: 0x1822AE6F0
	internal static void OnExitPlayMode() { }

	// RVA: 0x22AED10 Offset: 0x22AD310 VA: 0x1822AED10
	public static VariableDeclarations get_initial() { }

	[CompilerGenerated]
	// RVA: 0x22AEE70 Offset: 0x22AD470 VA: 0x1822AEE70
	public static VariableDeclarations get_saved() { }

	[CompilerGenerated]
	// RVA: 0x22AEF10 Offset: 0x22AD510 VA: 0x1822AEF10
	private static void set_saved(VariableDeclarations value) { }

	[CompilerGenerated]
	// RVA: 0x22AEE30 Offset: 0x22AD430 VA: 0x1822AEE30
	public static VariableDeclarations get_merged() { }

	[CompilerGenerated]
	// RVA: 0x22AEEB0 Offset: 0x22AD4B0 VA: 0x1822AEEB0
	private static void set_merged(VariableDeclarations value) { }

	// RVA: 0x22AEC90 Offset: 0x22AD290 VA: 0x1822AEC90
	public static VariableDeclarations get_current() { }

	// RVA: 0x22AE730 Offset: 0x22ACD30 VA: 0x1822AE730
	public static void SaveDeclarations(VariableDeclarations declarations) { }

	// RVA: 0x22ADA10 Offset: 0x22AC010 VA: 0x1822ADA10
	public static void FetchSavedDeclarations() { }

	// RVA: 0x22ADD30 Offset: 0x22AC330 VA: 0x1822ADD30
	private static void MergeInitialAndSavedDeclarations() { }

	// RVA: 0x22AD9B0 Offset: 0x22ABFB0 VA: 0x1822AD9B0
	private static void DestroyMergedDeclarations() { }

	// RVA: 0x22AE880 Offset: 0x22ACE80 VA: 0x1822AE880
	private static void WarnAndNullifyUnityObjectReferences(VariableDeclarations declarations) { }
}

// Namespace: Unity.VisualScripting
[Singleton(Name = "VisualScripting SceneVariables", Automatic = True, Persistent = False)]
[RequireComponent(typeof(Variables))]
[DisableAnnotation]
[AddComponentMenu("")]
[IncludeInSettings(False)]
public sealed class SceneVariables : MonoBehaviour, ISingleton // TypeDefIndex: 9309
{
	// Fields
	private Variables _variables; // 0x20

	// Properties
	public Variables variables { get; }

	// Methods

	// RVA: 0x22AF170 Offset: 0x22AD770 VA: 0x1822AF170
	public static SceneVariables Instance(Scene scene) { }

	// RVA: 0x22AF1D0 Offset: 0x22AD7D0 VA: 0x1822AF1D0
	public static bool InstantiatedIn(Scene scene) { }

	// RVA: 0x22AEFD0 Offset: 0x22AD5D0 VA: 0x1822AEFD0
	public static VariableDeclarations For(Nullable<Scene> scene) { }

	// RVA: 0x22AEF70 Offset: 0x22AD570 VA: 0x1822AEF70
	private void Awake() { }

	// RVA: 0x22AF230 Offset: 0x22AD830 VA: 0x1822AF230
	private void OnDestroy() { }

	// RVA: 0x22AF290 Offset: 0x22AD890 VA: 0x1822AF290
	public Variables get_variables() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[SerializationVersion("A", new[] {  })]
public sealed class VariableDeclaration // TypeDefIndex: 9310
{
	// Fields
	[CompilerGenerated]
	private string <name>k__BackingField; // 0x10
	[CompilerGenerated]
	private object <value>k__BackingField; // 0x18
	[CompilerGenerated]
	private SerializableType <typeHandle>k__BackingField; // 0x20

	// Properties
	[Serialize]
	public string name { get; set; }
	[Serialize]
	[Value]
	public object value { get; set; }
	[Serialize]
	public SerializableType typeHandle { get; set; }

	// Methods

	[Obsolete("This parameterless constructor is only made public for serialization. Use another constructor instead.")]
	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	public void .ctor(string name, object value) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_name(string value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public object get_value() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_value(object value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public SerializableType get_typeHandle() { }

	[CompilerGenerated]
	// RVA: 0x21EB300 Offset: 0x21E9900 VA: 0x1821EB300
	public void set_typeHandle(SerializableType value) { }
}

// Namespace: Unity.VisualScripting
[SerializationVersion("A", new[] {  })]
public sealed class VariableDeclarationCollection : KeyedCollection<string, VariableDeclaration>, IKeyedCollection<string, VariableDeclaration>, ICollection<VariableDeclaration>, IEnumerable<VariableDeclaration>, IEnumerable // TypeDefIndex: 9311
{
	// Methods

	// RVA: 0x3CFB00 Offset: 0x3CE100 VA: 0x1803CFB00 Slot: 39
	protected override string GetKeyForItem(VariableDeclaration item) { }

	// RVA: 0x22B26E0 Offset: 0x22B0CE0 VA: 0x1822B26E0
	public void EditorRename(VariableDeclaration item, string newName) { }

	// RVA: 0x22B2740 Offset: 0x22B0D40 VA: 0x1822B2740 Slot: 42
	public bool TryGetValue(string key, out VariableDeclaration value) { }

	// RVA: 0x22B2930 Offset: 0x22B0F30 VA: 0x1822B2930
	public void .ctor() { }

	// RVA: 0x22B28E0 Offset: 0x22B0EE0 VA: 0x1822B28E0 Slot: 40
	private VariableDeclaration Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.get_Item(string key) { }

	// RVA: 0x22B2840 Offset: 0x22B0E40 VA: 0x1822B2840 Slot: 43
	private bool Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.Contains(string key) { }

	// RVA: 0x22B2890 Offset: 0x22B0E90 VA: 0x1822B2890 Slot: 44
	private bool Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.Remove(string key) { }
}

// Namespace: Unity.VisualScripting
[DefaultMember("Item")]
[SerializationVersion("A", new[] {  })]
public sealed class VariableDeclarations : IEnumerable<VariableDeclaration>, IEnumerable, ISpecifiesCloner // TypeDefIndex: 9312
{
	// Fields
	public VariableKind Kind; // 0x10
	[Serialize]
	[InspectorWide(True)]
	private VariableDeclarationCollection collection; // 0x18
	internal Action OnVariableChanged; // 0x20

	// Properties
	public object Item { get; set; }
	private ICloner Unity.VisualScripting.ISpecifiesCloner.cloner { get; }

	// Methods

	// RVA: 0x22B32F0 Offset: 0x22B18F0 VA: 0x1822B32F0
	public void .ctor() { }

	// RVA: 0x22B3380 Offset: 0x22B1980 VA: 0x1822B3380
	public object get_Item(string variable) { }

	// RVA: 0x22B3120 Offset: 0x22B1720 VA: 0x1822B3120
	public void set_Item(string variable, object value) { }

	// RVA: 0x22B3120 Offset: 0x22B1720 VA: 0x1822B3120
	public void Set(string variable, object value) { }

	// RVA: 0x22B2EA0 Offset: 0x22B14A0 VA: 0x1822B2EA0
	public object Get(string variable) { }

	// RVA: -1 Offset: -1
	public T Get<T>(string variable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x811DC0 Offset: 0x8103C0 VA: 0x180811DC0
	|-VariableDeclarations.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x22B2FE0 Offset: 0x22B15E0 VA: 0x1822B2FE0
	public object Get(string variable, Type expectedType) { }

	// RVA: 0x22B2D40 Offset: 0x22B1340 VA: 0x1822B2D40
	public void Clear() { }

	// RVA: 0x22B3060 Offset: 0x22B1660 VA: 0x1822B3060
	public bool IsDefined(string variable) { }

	// RVA: 0x22B2D90 Offset: 0x22B1390 VA: 0x1822B2D90
	public VariableDeclaration GetDeclaration(string variable) { }

	// RVA: 0x22B2E50 Offset: 0x22B1450 VA: 0x1822B2E50 Slot: 4
	public IEnumerator<VariableDeclaration> GetEnumerator() { }

	// RVA: 0x22B3250 Offset: 0x22B1850 VA: 0x1822B3250 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x22B32A0 Offset: 0x22B18A0 VA: 0x1822B32A0 Slot: 6
	private ICloner Unity.VisualScripting.ISpecifiesCloner.get_cloner() { }
}

// Namespace: Unity.VisualScripting
public sealed class VariableDeclarationsCloner : Cloner<VariableDeclarations> // TypeDefIndex: 9313
{
	// Fields
	public static readonly VariableDeclarationsCloner instance; // 0x0

	// Methods

	// RVA: 0x22B2C00 Offset: 0x22B1200 VA: 0x1822B2C00 Slot: 9
	public override bool Handles(Type type) { }

	// RVA: 0x22B2970 Offset: 0x22B0F70 VA: 0x1822B2970 Slot: 11
	public override VariableDeclarations ConstructClone(Type type, VariableDeclarations original) { }

	// RVA: 0x22B29C0 Offset: 0x22B0FC0 VA: 0x1822B29C0 Slot: 12
	public override void FillClone(Type type, ref VariableDeclarations clone, VariableDeclarations original, CloningContext context) { }

	// RVA: 0x22B2D00 Offset: 0x22B1300 VA: 0x1822B2D00
	public void .ctor() { }

	// RVA: 0x22B2C70 Offset: 0x22B1270 VA: 0x1822B2C70
	private static void .cctor() { }
}

// Namespace: Unity.VisualScripting
public enum VariableKind // TypeDefIndex: 9314
{
	// Fields
	public int value__; // 0x0
	public const VariableKind Flow = 0;
	public const VariableKind Graph = 1;
	public const VariableKind Object = 2;
	public const VariableKind Scene = 3;
	public const VariableKind Application = 4;
	public const VariableKind Saved = 5;
}

// Namespace: Unity.VisualScripting
[Obsolete("Set VariableKind via VariableDeclarations.Kind")]
[Usage(384, AllowMultiple = False, Inherited = True)]
public sealed class VariableKindAttribute : Attribute // TypeDefIndex: 9315
{
	// Fields
	[CompilerGenerated]
	private readonly VariableKind <kind>k__BackingField; // 0x10

	// Properties
	public VariableKind kind { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(VariableKind kind) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public VariableKind get_kind() { }
}

// Namespace: Unity.VisualScripting
[AddComponentMenu("Visual Scripting/Variables")]
[DisableAnnotation]
[IncludeInSettings(False)]
public class Variables : LudiqBehaviour, IAotStubbable // TypeDefIndex: 9317
{
	// Fields
	[CompilerGenerated]
	private VariableDeclarations <declarations>k__BackingField; // 0x30

	// Properties
	[Serialize]
	[Inspectable]
	public VariableDeclarations declarations { get; set; }
	public static VariableDeclarations ActiveScene { get; }
	public static VariableDeclarations Application { get; }
	public static VariableDeclarations Saved { get; }
	public static bool ExistInActiveScene { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public VariableDeclarations get_declarations() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	internal void set_declarations(VariableDeclarations value) { }

	// RVA: 0x22B39A0 Offset: 0x22B1FA0 VA: 0x1822B39A0
	public static VariableDeclarations Graph(GraphPointer pointer) { }

	// RVA: 0x22B3930 Offset: 0x22B1F30 VA: 0x1822B3930
	public static VariableDeclarations GraphInstance(GraphPointer pointer) { }

	// RVA: 0x22B3820 Offset: 0x22B1E20 VA: 0x1822B3820
	public static VariableDeclarations GraphDefinition(GraphPointer pointer) { }

	// RVA: 0x22B38E0 Offset: 0x22B1EE0 VA: 0x1822B38E0
	public static VariableDeclarations GraphDefinition(IGraphWithVariables graph) { }

	// RVA: 0x22B3B30 Offset: 0x22B2130 VA: 0x1822B3B30
	public static VariableDeclarations Object(GameObject go) { }

	// RVA: 0x22B3B80 Offset: 0x22B2180 VA: 0x1822B3B80
	public static VariableDeclarations Object(Component component) { }

	// RVA: 0x22B3CE0 Offset: 0x22B22E0 VA: 0x1822B3CE0
	public static VariableDeclarations Scene(Nullable<Scene> scene) { }

	// RVA: 0x22B3BE0 Offset: 0x22B21E0 VA: 0x1822B3BE0
	public static VariableDeclarations Scene(GameObject go) { }

	// RVA: 0x22B3C50 Offset: 0x22B2250 VA: 0x1822B3C50
	public static VariableDeclarations Scene(Component component) { }

	// RVA: 0x22B3F10 Offset: 0x22B2510 VA: 0x1822B3F10
	public static VariableDeclarations get_ActiveScene() { }

	// RVA: 0x22B3F90 Offset: 0x22B2590 VA: 0x1822B3F90
	public static VariableDeclarations get_Application() { }

	// RVA: 0x22B4140 Offset: 0x22B2740 VA: 0x1822B4140
	public static VariableDeclarations get_Saved() { }

	// RVA: 0x22B3690 Offset: 0x22B1C90 VA: 0x1822B3690
	public static bool ExistOnObject(GameObject go) { }

	// RVA: 0x22B3710 Offset: 0x22B1D10 VA: 0x1822B3710
	public static bool ExistOnObject(Component component) { }

	// RVA: 0x22B35E0 Offset: 0x22B1BE0 VA: 0x1822B35E0
	public static bool ExistInScene(Nullable<Scene> scene) { }

	// RVA: 0x22B4020 Offset: 0x22B2620 VA: 0x1822B4020
	public static bool get_ExistInActiveScene() { }

	[ContextMenu("Show Data...")]
	// RVA: 0x22B3E80 Offset: 0x22B2480 VA: 0x1822B3E80 Slot: 10
	protected override void ShowData() { }

	[IteratorStateMachine(typeof(Variables.<GetAotStubs>d__25))]
	// RVA: 0x22B37A0 Offset: 0x22B1DA0 VA: 0x1822B37A0 Slot: 11
	public IEnumerable<object> GetAotStubs(HashSet<object> visited) { }

	// RVA: 0x22B3E90 Offset: 0x22B2490 VA: 0x1822B3E90
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[IncludeInSettings(False)]
public sealed class VariablesAsset : LudiqScriptableObject // TypeDefIndex: 9318
{
	// Fields
	[CompilerGenerated]
	private VariableDeclarations <declarations>k__BackingField; // 0x30

	// Properties
	[Serialize]
	[Inspectable]
	[InspectorWide(True)]
	public VariableDeclarations declarations { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public VariableDeclarations get_declarations() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	internal void set_declarations(VariableDeclarations value) { }

	[ContextMenu("Show Data...")]
	// RVA: 0x22B3390 Offset: 0x22B1990 VA: 0x1822B3390 Slot: 11
	protected override void ShowData() { }

	// RVA: 0x22B33A0 Offset: 0x22B19A0 VA: 0x1822B33A0
	public void .ctor() { }
}

// Namespace: Unity.VisualScripting
[Singleton(Name = "VisualScripting SavedVariablesSerializer", Automatic = True, Persistent = True)]
[AddComponentMenu("")]
[DisableAnnotation]
[IncludeInSettings(False)]
public class VariablesSaver : MonoBehaviour, ISingleton // TypeDefIndex: 9319
{
	// Properties
	public static VariablesSaver instance { get; }

	// Methods

	// RVA: 0x22B3410 Offset: 0x22B1A10 VA: 0x1822B3410
	private void Awake() { }

	// RVA: 0x22B3520 Offset: 0x22B1B20 VA: 0x1822B3520
	private void OnDestroy() { }

	// RVA: 0x22AE6F0 Offset: 0x22ACCF0 VA: 0x1822AE6F0
	private void OnApplicationQuit() { }

	// RVA: 0x22B34D0 Offset: 0x22B1AD0 VA: 0x1822B34D0
	private void OnApplicationPause(bool isPaused) { }

	// RVA: 0x22B3580 Offset: 0x22B1B80 VA: 0x1822B3580
	public static VariablesSaver get_instance() { }

	// RVA: 0x22B3470 Offset: 0x22B1A70 VA: 0x1822B3470
	public static void Instantiate() { }

	// RVA: 0x345C30 Offset: 0x344230 VA: 0x180345C30
	public void .ctor() { }
}

