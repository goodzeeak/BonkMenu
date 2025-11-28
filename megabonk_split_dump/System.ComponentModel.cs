// Namespace: System.ComponentModel
[Usage(32767)]
public class DefaultValueAttribute : Attribute // TypeDefIndex: 7551
{
	// Fields
	private object _value; // 0x10

	// Properties
	public virtual object Value { get; }

	// Methods

	// RVA: 0x1E17770 Offset: 0x1E15D70 VA: 0x181E17770
	public void .ctor(int value) { }

	// RVA: 0x1E17720 Offset: 0x1E15D20 VA: 0x181E17720
	public void .ctor(long value) { }

	// RVA: 0x1E176D0 Offset: 0x1E15CD0 VA: 0x181E176D0
	public void .ctor(bool value) { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string value) { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(object value) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 7
	public virtual object get_Value() { }

	// RVA: 0x1E17590 Offset: 0x1E15B90 VA: 0x181E17590 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
[Usage(6140)]
public sealed class EditorBrowsableAttribute : Attribute // TypeDefIndex: 7552
{
	// Fields
	private EditorBrowsableState browsableState; // 0x10

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(EditorBrowsableState state) { }

	// RVA: 0x1E183F0 Offset: 0x1E169F0 VA: 0x181E183F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
public enum EditorBrowsableState // TypeDefIndex: 7553
{
	// Fields
	public int value__; // 0x0
	public const EditorBrowsableState Always = 0;
	public const EditorBrowsableState Never = 1;
	public const EditorBrowsableState Advanced = 2;
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 7554
{
	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <Browsable>k__BackingField; // 0x10

	// Properties
	public bool Browsable { get; }

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(bool browsable) { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_Browsable() { }

	// RVA: 0x1E12070 Offset: 0x1E10670 VA: 0x181E12070 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E12130 Offset: 0x1E10730 VA: 0x181E12130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E12170 Offset: 0x1E10770 VA: 0x181E12170 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E121E0 Offset: 0x1E107E0 VA: 0x181E121E0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class ComponentCollection : ReadOnlyCollectionBase // TypeDefIndex: 7555
{
	// Properties
	public virtual IComponent Item { get; }

	// Methods

	// RVA: 0x1E126C0 Offset: 0x1E10CC0 VA: 0x181E126C0 Slot: 11
	public virtual IComponent get_Item(string name) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public class DescriptionAttribute : Attribute // TypeDefIndex: 7556
{
	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	[CompilerGenerated]
	private string <DescriptionValue>k__BackingField; // 0x10

	// Properties
	public virtual string Description { get; }
	protected string DescriptionValue { get; set; }

	// Methods

	// RVA: 0x1E179E0 Offset: 0x1E15FE0 VA: 0x181E179E0
	public void .ctor() { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string description) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 7
	public virtual string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	protected string get_DescriptionValue() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x1E177C0 Offset: 0x1E15DC0 VA: 0x181E177C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E17890 Offset: 0x1E15E90 VA: 0x181E17890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E178D0 Offset: 0x1E15ED0 VA: 0x181E178D0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E17940 Offset: 0x1E15F40 VA: 0x181E17940
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 7557
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsDesignOnly>k__BackingField; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Properties
	public bool IsDesignOnly { get; }

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(bool isDesignOnly) { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_IsDesignOnly() { }

	// RVA: 0x1E17A20 Offset: 0x1E16020 VA: 0x181E17A20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E12130 Offset: 0x1E10730 VA: 0x181E12130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E17AE0 Offset: 0x1E160E0 VA: 0x181E17AE0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E17B50 Offset: 0x1E16150 VA: 0x181E17B50
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4, AllowMultiple = False, Inherited = True)]
public sealed class DesignerCategoryAttribute : Attribute // TypeDefIndex: 7558
{
	// Fields
	public static readonly DesignerCategoryAttribute Component; // 0x0
	public static readonly DesignerCategoryAttribute Default; // 0x8
	public static readonly DesignerCategoryAttribute Form; // 0x10
	public static readonly DesignerCategoryAttribute Generic; // 0x18
	[CompilerGenerated]
	private readonly string <Category>k__BackingField; // 0x10

	// Properties
	public string Category { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x1E17F10 Offset: 0x1E16510 VA: 0x181E17F10
	public void .ctor() { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string category) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Category() { }

	// RVA: 0x1E17C40 Offset: 0x1E16240 VA: 0x181E17C40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E17CC0 Offset: 0x1E162C0 VA: 0x181E17CC0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E17F50 Offset: 0x1E16550 VA: 0x181E17F50 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x1E17D40 Offset: 0x1E16340 VA: 0x181E17D40
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public enum DesignerSerializationVisibility // TypeDefIndex: 7559
{
	// Fields
	public int value__; // 0x0
	public const DesignerSerializationVisibility Hidden = 0;
	public const DesignerSerializationVisibility Visible = 1;
	public const DesignerSerializationVisibility Content = 2;
}

// Namespace: System.ComponentModel
[Usage(960)]
public sealed class DesignerSerializationVisibilityAttribute : Attribute // TypeDefIndex: 7560
{
	// Fields
	public static readonly DesignerSerializationVisibilityAttribute Content; // 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	[CompilerGenerated]
	private readonly DesignerSerializationVisibility <Visibility>k__BackingField; // 0x10

	// Properties
	public DesignerSerializationVisibility Visibility { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(DesignerSerializationVisibility visibility) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x1E17FA0 Offset: 0x1E165A0 VA: 0x181E17FA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E18060 Offset: 0x1E16660 VA: 0x181E18060 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E180D0 Offset: 0x1E166D0 VA: 0x181E180D0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(708)]
public class DisplayNameAttribute : Attribute // TypeDefIndex: 7561
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	[CompilerGenerated]
	private string <DisplayNameValue>k__BackingField; // 0x10

	// Properties
	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; set; }

	// Methods

	// RVA: 0x1E179E0 Offset: 0x1E15FE0 VA: 0x181E179E0
	public void .ctor() { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string displayName) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 7
	public virtual string get_DisplayName() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	protected string get_DisplayNameValue() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	protected void set_DisplayNameValue(string value) { }

	// RVA: 0x1E18210 Offset: 0x1E16810 VA: 0x181E18210 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E17890 Offset: 0x1E15E90 VA: 0x181E17890 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E182E0 Offset: 0x1E168E0 VA: 0x181E182E0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E18350 Offset: 0x1E16950 VA: 0x181E18350
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public sealed class EventHandlerList // TypeDefIndex: 7563
{
	// Fields
	private EventHandlerList.ListEntry _head; // 0x10
	private Component _parent; // 0x18

	// Properties
	public Delegate Item { get; }

	// Methods

	// RVA: 0x1E18490 Offset: 0x1E16A90 VA: 0x181E18490
	public Delegate get_Item(object key) { }

	// RVA: 0x1E18470 Offset: 0x1E16A70 VA: 0x181E18470
	private EventHandlerList.ListEntry Find(object key) { }
}

// Namespace: System.ComponentModel
public interface IContainer : IDisposable // TypeDefIndex: 7564
{
	// Properties
	public abstract ComponentCollection Components { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ComponentCollection get_Components();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Remove(IComponent component);
}

// Namespace: System.ComponentModel
public interface ISite : IServiceProvider // TypeDefIndex: 7565
{
	// Properties
	public abstract IContainer Container { get; }
	public abstract bool DesignMode { get; }
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IContainer get_Container();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_DesignMode();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Name();
}

// Namespace: System.ComponentModel
public interface ISynchronizeInvoke // TypeDefIndex: 7566
{
	// Properties
	public abstract bool InvokeRequired { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_InvokeRequired();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IAsyncResult BeginInvoke(Delegate method, object[] args);
}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidEnumArgumentException : ArgumentException // TypeDefIndex: 7567
{
	// Methods

	// RVA: 0x1E184F0 Offset: 0x1E16AF0 VA: 0x181E184F0
	public void .ctor() { }

	// RVA: 0x1E18500 Offset: 0x1E16B00 VA: 0x181E18500
	public void .ctor(string message) { }

	// RVA: 0x136BF60 Offset: 0x136A560 VA: 0x18136BF60
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 7568
{
	// Fields
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <IsReadOnly>k__BackingField; // 0x10

	// Properties
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(bool isReadOnly) { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_IsReadOnly() { }

	// RVA: 0x1E19B20 Offset: 0x1E18120 VA: 0x181E19B20 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E19BE0 Offset: 0x1E181E0 VA: 0x181E19BE0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E19C50 Offset: 0x1E18250 VA: 0x181E19C50
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class AddingNewEventArgs : EventArgs // TypeDefIndex: 7569
{
	// Fields
	[CompilerGenerated]
	private object <NewObject>k__BackingField; // 0x10

	// Properties
	public object NewObject { get; }

	// Methods

	// RVA: 0x1E0F1D0 Offset: 0x1E0D7D0 VA: 0x181E0F1D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public object get_NewObject() { }
}

// Namespace: System.ComponentModel
public sealed class AddingNewEventHandler : MulticastDelegate // TypeDefIndex: 7570
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, AddingNewEventArgs e) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class AmbientValueAttribute : Attribute // TypeDefIndex: 7571
{
	// Fields
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x10

	// Properties
	public object Value { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public object get_Value() { }
}

// Namespace: System.ComponentModel
public class ArrayConverter : CollectionConverter // TypeDefIndex: 7572
{
	// Methods

	// RVA: 0x1E0F220 Offset: 0x1E0D820 VA: 0x181E0F220 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class AttributeCollection : ICollection, IEnumerable // TypeDefIndex: 7574
{
	// Fields
	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable s_defaultAttributes; // 0x8
	private readonly Attribute[] _attributes; // 0x10
	private static readonly object s_internalSyncObject; // 0x10
	private AttributeCollection.AttributeEntry[] _foundAttributeTypes; // 0x18
	private int _index; // 0x20

	// Properties
	protected virtual Attribute[] Attributes { get; }
	public int Count { get; }
	public virtual Attribute Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x1E11090 Offset: 0x1E0F690 VA: 0x181E11090
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 9
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x1E10ED0 Offset: 0x1E0F4D0 VA: 0x181E10ED0
	public int get_Count() { }

	// RVA: 0x1E11180 Offset: 0x1E0F780 VA: 0x181E11180 Slot: 10
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x1E10870 Offset: 0x1E0EE70 VA: 0x181E10870
	public bool Contains(Attribute attribute) { }

	// RVA: 0x1E10980 Offset: 0x1E0EF80 VA: 0x181E10980
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x1E10EA0 Offset: 0x1E0F4A0 VA: 0x181E10EA0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1E10ED0 Offset: 0x1E0F4D0 VA: 0x181E10ED0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1E10EA0 Offset: 0x1E0F4A0 VA: 0x181E10EA0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1E108F0 Offset: 0x1E0EEF0 VA: 0x181E108F0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1E10F00 Offset: 0x1E0F500 VA: 0x181E10F00
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(128)]
public class AttributeProviderAttribute : Attribute // TypeDefIndex: 7575
{
	// Fields
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; // 0x18

	// Properties
	public string TypeName { get; }
	public string PropertyName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_TypeName() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_PropertyName() { }
}

// Namespace: System.ComponentModel
public abstract class BaseNumberConverter : TypeConverter // TypeDefIndex: 7576
{
	// Properties
	internal virtual bool AllowHex { get; }
	internal abstract Type TargetType { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	internal void .ctor() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 10
	internal virtual bool get_AllowHex() { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract Type get_TargetType();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract object FromString(string value, int radix);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract object FromString(string value, NumberFormatInfo formatInfo);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	// RVA: 0x1E116E0 Offset: 0x1E0FCE0 VA: 0x181E116E0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E117A0 Offset: 0x1E0FDA0 VA: 0x181E117A0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E11B00 Offset: 0x1E10100 VA: 0x181E11B00 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1E11760 Offset: 0x1E0FD60 VA: 0x181E11760 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }
}

// Namespace: System.ComponentModel
public class BooleanConverter : TypeConverter // TypeDefIndex: 7577
{
	// Fields
	private static TypeConverter.StandardValuesCollection s_values; // 0x0

	// Methods

	// RVA: 0x1E116E0 Offset: 0x1E0FCE0 VA: 0x181E116E0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E11D90 Offset: 0x1E10390 VA: 0x181E11D90 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E11ED0 Offset: 0x1E104D0 VA: 0x181E11ED0 Slot: 8
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 9
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class ByteConverter : BaseNumberConverter // TypeDefIndex: 7578
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1E123F0 Offset: 0x1E109F0 VA: 0x181E123F0 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E122C0 Offset: 0x1E108C0 VA: 0x181E122C0 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E12330 Offset: 0x1E10930 VA: 0x181E12330 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E12360 Offset: 0x1E10960 VA: 0x181E12360 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class CharConverter : TypeConverter // TypeDefIndex: 7579
{
	// Methods

	// RVA: 0x1E116E0 Offset: 0x1E0FCE0 VA: 0x181E116E0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E12540 Offset: 0x1E10B40 VA: 0x181E12540 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1E12430 Offset: 0x1E10A30 VA: 0x181E12430 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public enum CollectionChangeAction // TypeDefIndex: 7580
{
	// Fields
	public int value__; // 0x0
	public const CollectionChangeAction Add = 1;
	public const CollectionChangeAction Remove = 2;
	public const CollectionChangeAction Refresh = 3;
}

// Namespace: System.ComponentModel
public class CollectionChangeEventArgs : EventArgs // TypeDefIndex: 7581
{
	// Fields
	[CompilerGenerated]
	private readonly CollectionChangeAction <Action>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly object <Element>k__BackingField; // 0x18

	// Properties
	public virtual CollectionChangeAction Action { get; }
	public virtual object Element { get; }

	// Methods

	// RVA: 0x1E12640 Offset: 0x1E10C40 VA: 0x181E12640
	public void .ctor(CollectionChangeAction action, object element) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 4
	public virtual CollectionChangeAction get_Action() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 5
	public virtual object get_Element() { }
}

// Namespace: System.ComponentModel
public sealed class CollectionChangeEventHandler : MulticastDelegate // TypeDefIndex: 7582
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, CollectionChangeEventArgs e) { }
}

// Namespace: System.ComponentModel
public class CultureInfoConverter : TypeConverter // TypeDefIndex: 7585
{
	// Fields
	private TypeConverter.StandardValuesCollection _values; // 0x10

	// Properties
	private string DefaultCultureString { get; }

	// Methods

	// RVA: 0x1E13B20 Offset: 0x1E12120 VA: 0x181E13B20
	private string get_DefaultCultureString() { }

	// RVA: 0x1E138F0 Offset: 0x1E11EF0 VA: 0x181E138F0 Slot: 10
	protected virtual string GetCultureName(CultureInfo culture) { }

	// RVA: 0x1E12B30 Offset: 0x1E11130 VA: 0x181E12B30 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E12BB0 Offset: 0x1E111B0 VA: 0x181E12BB0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E12C50 Offset: 0x1E11250 VA: 0x181E12C50 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E13420 Offset: 0x1E11A20 VA: 0x181E13420 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1E13920 Offset: 0x1E11F20 VA: 0x181E13920 Slot: 8
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 9
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 7586
{
	// Fields
	private readonly ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1E2DA40 Offset: 0x1E2C040 VA: 0x181E2DA40 Slot: 16
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x1E2DB40 Offset: 0x1E2C140 VA: 0x181E2DB40 Slot: 17
	public virtual string GetClassName() { }

	// RVA: 0x1E2DB90 Offset: 0x1E2C190 VA: 0x181E2DB90 Slot: 18
	public virtual string GetComponentName() { }

	// RVA: 0x1E2DBE0 Offset: 0x1E2C1E0 VA: 0x181E2DBE0 Slot: 19
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x1E2DCE0 Offset: 0x1E2C2E0 VA: 0x181E2DCE0 Slot: 20
	public virtual EventDescriptor GetDefaultEvent() { }

	// RVA: 0x1E2DDA0 Offset: 0x1E2C3A0 VA: 0x181E2DDA0 Slot: 21
	public virtual PropertyDescriptor GetDefaultProperty() { }

	// RVA: 0x1E2DE60 Offset: 0x1E2C460 VA: 0x181E2DE60 Slot: 22
	public virtual object GetEditor(Type editorBaseType) { }

	// RVA: 0x1E2DEC0 Offset: 0x1E2C4C0 VA: 0x181E2DEC0 Slot: 23
	public virtual EventDescriptorCollection GetEvents() { }

	// RVA: 0x1E2DFC0 Offset: 0x1E2C5C0 VA: 0x181E2DFC0 Slot: 24
	public virtual EventDescriptorCollection GetEvents(Attribute[] attributes) { }

	// RVA: 0x1E2E1E0 Offset: 0x1E2C7E0 VA: 0x181E2E1E0 Slot: 25
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x1E2E0D0 Offset: 0x1E2C6D0 VA: 0x181E2E0D0 Slot: 26
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x1E2E2E0 Offset: 0x1E2C8E0 VA: 0x181E2E2E0 Slot: 27
	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: System.ComponentModel
public class DateTimeConverter : TypeConverter // TypeDefIndex: 7587
{
	// Methods

	// RVA: 0x1E116E0 Offset: 0x1E0FCE0 VA: 0x181E116E0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E2E340 Offset: 0x1E2C940 VA: 0x181E2E340 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E2E3E0 Offset: 0x1E2C9E0 VA: 0x181E2E3E0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E2E670 Offset: 0x1E2CC70 VA: 0x181E2E670 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class DecimalConverter : BaseNumberConverter // TypeDefIndex: 7588
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	internal override bool get_AllowHex() { }

	// RVA: 0x1E30230 Offset: 0x1E2E830 VA: 0x181E30230 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E2FC40 Offset: 0x1E2E240 VA: 0x181E2FC40 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E2FCE0 Offset: 0x1E2E2E0 VA: 0x181E2FCE0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1E300D0 Offset: 0x1E2E6D0 VA: 0x181E300D0 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E30040 Offset: 0x1E2E640 VA: 0x181E30040 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E30180 Offset: 0x1E2E780 VA: 0x181E30180 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class DefaultEventAttribute : Attribute // TypeDefIndex: 7589
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultEventAttribute Default; // 0x0

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Name() { }

	// RVA: 0x1E30280 Offset: 0x1E2E880 VA: 0x181E30280 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E302F0 Offset: 0x1E2E8F0 VA: 0x181E302F0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class DefaultPropertyAttribute : Attribute // TypeDefIndex: 7590
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultPropertyAttribute Default; // 0x0

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Name() { }

	// RVA: 0x1E30370 Offset: 0x1E2E970 VA: 0x181E30370 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E303E0 Offset: 0x1E2E9E0 VA: 0x181E303E0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 7591
{
	// Fields
	private readonly Type _type; // 0x20

	// Properties
	internal TypeDescriptionProvider Provider { get; }

	// Methods

	// RVA: 0x199A250 Offset: 0x1998850 VA: 0x18199A250
	internal void .ctor(Type type) { }

	// RVA: 0x1E307B0 Offset: 0x1E2EDB0 VA: 0x181E307B0
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x1E30460 Offset: 0x1E2EA60 VA: 0x181E30460 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1E30510 Offset: 0x1E2EB10 VA: 0x181E30510 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1E30590 Offset: 0x1E2EB90 VA: 0x181E30590 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1E30610 Offset: 0x1E2EC10 VA: 0x181E30610 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1E30690 Offset: 0x1E2EC90 VA: 0x181E30690 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1E30720 Offset: 0x1E2ED20 VA: 0x181E30720 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public class ToolboxItemAttribute : Attribute // TypeDefIndex: 7592
{
	// Fields
	private string _toolboxItemTypeName; // 0x10
	public static readonly ToolboxItemAttribute Default; // 0x0
	public static readonly ToolboxItemAttribute None; // 0x8

	// Properties
	public string ToolboxItemTypeName { get; }

	// Methods

	// RVA: 0x1E490D0 Offset: 0x1E476D0 VA: 0x181E490D0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E49320 Offset: 0x1E47920 VA: 0x181E49320
	public void .ctor(bool defaultType) { }

	// RVA: 0x1E49290 Offset: 0x1E47890 VA: 0x181E49290
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x1D1DA70 Offset: 0x1D1C070 VA: 0x181D1DA70
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x1E48FC0 Offset: 0x1E475C0 VA: 0x181E48FC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E49090 Offset: 0x1E47690 VA: 0x181E49090 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E49140 Offset: 0x1E47740 VA: 0x181E49140
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(1028)]
public sealed class DesignTimeVisibleAttribute : Attribute // TypeDefIndex: 7593
{
	// Fields
	[CompilerGenerated]
	private readonly bool <Visible>k__BackingField; // 0x10
	public static readonly DesignTimeVisibleAttribute Yes; // 0x0
	public static readonly DesignTimeVisibleAttribute No; // 0x8
	public static readonly DesignTimeVisibleAttribute Default; // 0x10

	// Properties
	public bool Visible { get; }

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(bool visible) { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_Visible() { }

	// RVA: 0x1E30800 Offset: 0x1E2EE00 VA: 0x181E30800 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E30880 Offset: 0x1E2EE80 VA: 0x181E30880 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E30910 Offset: 0x1E2EF10 VA: 0x181E30910 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E30980 Offset: 0x1E2EF80 VA: 0x181E30980
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class DoubleConverter : BaseNumberConverter // TypeDefIndex: 7594
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	internal override bool get_AllowHex() { }

	// RVA: 0x1E30BC0 Offset: 0x1E2F1C0 VA: 0x181E30BC0 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E30A60 Offset: 0x1E2F060 VA: 0x181E30A60 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E30B00 Offset: 0x1E2F100 VA: 0x181E30B00 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E30B30 Offset: 0x1E2F130 VA: 0x181E30B30 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class EditorAttribute : Attribute // TypeDefIndex: 7595
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly string <EditorBaseTypeName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <EditorTypeName>k__BackingField; // 0x20

	// Properties
	public string EditorBaseTypeName { get; }
	public string EditorTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x1E30CB0 Offset: 0x1E2F2B0 VA: 0x181E30CB0
	public void .ctor(string typeName, string baseTypeName) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_EditorBaseTypeName() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_EditorTypeName() { }

	// RVA: 0x1E30D60 Offset: 0x1E2F360 VA: 0x181E30D60 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x1E30C00 Offset: 0x1E2F200 VA: 0x181E30C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
public abstract class EventDescriptor : MemberDescriptor // TypeDefIndex: 7596
{
	// Methods

	// RVA: 0x1E33BD0 Offset: 0x1E321D0 VA: 0x181E33BD0
	protected void .ctor(string name, Attribute[] attrs) { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class EventDescriptorCollection : ICollection, IEnumerable, IList // TypeDefIndex: 7598
{
	// Fields
	private EventDescriptor[] _events; // 0x10
	private string[] _namedSort; // 0x18
	private readonly IComparer _comparer; // 0x20
	private bool _eventsOwned; // 0x28
	private bool _needSort; // 0x29
	private readonly bool _readOnly; // 0x2A
	public static readonly EventDescriptorCollection Empty; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x2C

	// Properties
	public int Count { get; set; }
	public virtual EventDescriptor Item { get; }
	public virtual EventDescriptor Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: 0x1E33A00 Offset: 0x1E32000 VA: 0x181E33A00
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x1E33A90 Offset: 0x1E32090 VA: 0x181E33A90
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	[CompilerGenerated]
	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x10D2B80 Offset: 0x10D1180 VA: 0x1810D2B80
	private void set_Count(int value) { }

	// RVA: 0x1E33B50 Offset: 0x1E32150 VA: 0x181E33B50 Slot: 20
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x1E33B30 Offset: 0x1E32130 VA: 0x181E33B30 Slot: 21
	public virtual EventDescriptor get_Item(string name) { }

	// RVA: 0x1E32540 Offset: 0x1E30B40 VA: 0x181E32540
	public int Add(EventDescriptor value) { }

	// RVA: 0x1E32630 Offset: 0x1E30C30 VA: 0x181E32630
	public void Clear() { }

	// RVA: 0x1E32690 Offset: 0x1E30C90 VA: 0x181E32690
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x1E33140 Offset: 0x1E31740 VA: 0x181E33140 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1E326F0 Offset: 0x1E30CF0 VA: 0x181E326F0
	private void EnsureEventsOwned() { }

	// RVA: 0x1E327A0 Offset: 0x1E30DA0 VA: 0x181E327A0
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x1E328C0 Offset: 0x1E30EC0 VA: 0x181E328C0 Slot: 22
	public virtual EventDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x1E32A90 Offset: 0x1E31090 VA: 0x181E32A90
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x1E32AF0 Offset: 0x1E310F0 VA: 0x181E32AF0
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x1E33090 Offset: 0x1E31690 VA: 0x181E33090
	public void Remove(EventDescriptor value) { }

	// RVA: 0x1E32FD0 Offset: 0x1E315D0 VA: 0x181E32FD0
	public void RemoveAt(int index) { }

	// RVA: 0x1E329E0 Offset: 0x1E30FE0 VA: 0x181E329E0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1E32C80 Offset: 0x1E31280 VA: 0x181E32C80
	protected void InternalSort(string[] names) { }

	// RVA: 0x1E32C00 Offset: 0x1E31200 VA: 0x181E32C00
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x4A2A00 Offset: 0x4A1000 VA: 0x1804A2A00 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1E33190 Offset: 0x1E31790 VA: 0x181E33190 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1E33780 Offset: 0x1E31D80 VA: 0x181E33780 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1E337A0 Offset: 0x1E31DA0 VA: 0x181E337A0 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1E33240 Offset: 0x1E31840 VA: 0x181E33240 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1E33390 Offset: 0x1E31990 VA: 0x181E33390 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1E32630 Offset: 0x1E30C30 VA: 0x181E32630 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1E33440 Offset: 0x1E31A40 VA: 0x181E33440 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1E334F0 Offset: 0x1E31AF0 VA: 0x181E334F0 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1E33670 Offset: 0x1E31C70 VA: 0x181E33670 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1E33660 Offset: 0x1E31C60 VA: 0x181E33660 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1E33770 Offset: 0x1E31D70 VA: 0x181E33770 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1E33770 Offset: 0x1E31D70 VA: 0x181E33770 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1E33950 Offset: 0x1E31F50 VA: 0x181E33950
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class ExpandableObjectConverter : TypeConverter // TypeDefIndex: 7599
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 7600
{
	// Fields
	private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
	private readonly IExtenderProvider _provider; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	public override string DisplayName { get; }

	// Methods

	// RVA: 0x1E33CF0 Offset: 0x1E322F0 VA: 0x181E33CF0
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x1E33BE0 Offset: 0x1E321E0 VA: 0x181E33BE0 Slot: 17
	public override bool CanResetValue(object comp) { }

	// RVA: 0x1E33F90 Offset: 0x1E32590 VA: 0x181E33F90 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1E34230 Offset: 0x1E32830 VA: 0x181E34230 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1E34320 Offset: 0x1E32920 VA: 0x181E34320 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1E33FC0 Offset: 0x1E325C0 VA: 0x181E33FC0 Slot: 9
	public override string get_DisplayName() { }

	// RVA: 0x1E33C10 Offset: 0x1E32210 VA: 0x181E33C10 Slot: 18
	public override object GetValue(object comp) { }

	// RVA: 0x1E33C40 Offset: 0x1E32240 VA: 0x181E33C40 Slot: 20
	public override void ResetValue(object comp) { }

	// RVA: 0x1E33C80 Offset: 0x1E32280 VA: 0x181E33C80 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x1E33CC0 Offset: 0x1E322C0 VA: 0x181E33CC0 Slot: 22
	public override bool ShouldSerializeValue(object comp) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 7601
{
	// Fields
	[CompilerGenerated]
	private PropertyDescriptor <ExtenderProperty>k__BackingField; // 0x10
	[CompilerGenerated]
	private IExtenderProvider <Provider>k__BackingField; // 0x18
	[CompilerGenerated]
	private Type <ReceiverType>k__BackingField; // 0x20

	// Properties
	public PropertyDescriptor ExtenderProperty { get; set; }
	public IExtenderProvider Provider { get; set; }
	public Type ReceiverType { get; set; }

	// Methods

	// RVA: 0x1E34350 Offset: 0x1E32950 VA: 0x181E34350
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public PropertyDescriptor get_ExtenderProperty() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public IExtenderProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	private void set_Provider(IExtenderProvider value) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Type get_ReceiverType() { }

	[CompilerGenerated]
	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10
	private void set_ReceiverType(Type value) { }

	// RVA: 0x1E34400 Offset: 0x1E32A00 VA: 0x181E34400 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E34500 Offset: 0x1E32B00 VA: 0x181E34500 Slot: 6
	public override bool IsDefaultAttribute() { }
}

// Namespace: System.ComponentModel
public class GuidConverter : TypeConverter // TypeDefIndex: 7602
{
	// Methods

	// RVA: 0x1E116E0 Offset: 0x1E0FCE0 VA: 0x181E116E0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E34540 Offset: 0x1E32B40 VA: 0x181E34540 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E345E0 Offset: 0x1E32BE0 VA: 0x181E345E0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E346B0 Offset: 0x1E32CB0 VA: 0x181E346B0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public interface IBindingList : IList, ICollection, IEnumerable // TypeDefIndex: 7603
{
	// Properties
	public abstract bool AllowNew { get; }
	public abstract bool AllowEdit { get; }
	public abstract bool AllowRemove { get; }
	public abstract bool SupportsChangeNotification { get; }
	public abstract bool SupportsSearching { get; }
	public abstract bool SupportsSorting { get; }
	public abstract bool IsSorted { get; }
	public abstract PropertyDescriptor SortProperty { get; }
	public abstract ListSortDirection SortDirection { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_AllowNew();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object AddNew();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_AllowEdit();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_AllowRemove();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_SupportsChangeNotification();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_SupportsSearching();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSorting();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsSorted();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract PropertyDescriptor get_SortProperty();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract ListSortDirection get_SortDirection();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void AddIndex(PropertyDescriptor property);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void ApplySort(PropertyDescriptor property, ListSortDirection direction);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int Find(PropertyDescriptor property, object key);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void RemoveIndex(PropertyDescriptor property);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void RemoveSort();
}

// Namespace: System.ComponentModel
public interface ICustomTypeDescriptor // TypeDefIndex: 7604
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AttributeCollection GetAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetClassName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetComponentName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TypeConverter GetConverter();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EventDescriptor GetDefaultEvent();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract PropertyDescriptor GetDefaultProperty();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object GetEditor(Type editorBaseType);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract EventDescriptorCollection GetEvents();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract EventDescriptorCollection GetEvents(Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract PropertyDescriptorCollection GetProperties();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract PropertyDescriptorCollection GetProperties(Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract object GetPropertyOwner(PropertyDescriptor pd);
}

// Namespace: System.ComponentModel
public interface IExtenderProvider // TypeDefIndex: 7605
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanExtend(object extendee);
}

// Namespace: System.ComponentModel
public interface INestedSite : ISite, IServiceProvider // TypeDefIndex: 7606
{
	// Properties
	public abstract string FullName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_FullName();
}

// Namespace: System.ComponentModel
public interface ITypeDescriptorContext : IServiceProvider // TypeDefIndex: 7607
{
	// Properties
	public abstract IContainer Container { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IContainer get_Container();
}

// Namespace: System.ComponentModel
public interface ITypedList // TypeDefIndex: 7608
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string GetListName(PropertyDescriptor[] listAccessors);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors);
}

// Namespace: System.ComponentModel
public class Int16Converter : BaseNumberConverter // TypeDefIndex: 7609
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1E34B20 Offset: 0x1E33120 VA: 0x181E34B20 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E34A20 Offset: 0x1E33020 VA: 0x181E34A20 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E349F0 Offset: 0x1E32FF0 VA: 0x181E349F0 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E34A90 Offset: 0x1E33090 VA: 0x181E34A90 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class Int32Converter : BaseNumberConverter // TypeDefIndex: 7610
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1E34C90 Offset: 0x1E33290 VA: 0x181E34C90 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E34B60 Offset: 0x1E33160 VA: 0x181E34B60 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E34BD0 Offset: 0x1E331D0 VA: 0x181E34BD0 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E34C00 Offset: 0x1E33200 VA: 0x181E34C00 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class Int64Converter : BaseNumberConverter // TypeDefIndex: 7611
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1AA6850 Offset: 0x1AA4E50 VA: 0x181AA6850 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E34D00 Offset: 0x1E33300 VA: 0x181E34D00 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E34CD0 Offset: 0x1E332D0 VA: 0x181E34CD0 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E34D70 Offset: 0x1E33370 VA: 0x181E34D70 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ListBindableAttribute : Attribute // TypeDefIndex: 7612
{
	// Fields
	public static readonly ListBindableAttribute Yes; // 0x0
	public static readonly ListBindableAttribute No; // 0x8
	public static readonly ListBindableAttribute Default; // 0x10
	private bool _isDefault; // 0x10
	[CompilerGenerated]
	private readonly bool <ListBindable>k__BackingField; // 0x11

	// Properties
	public bool ListBindable { get; }

	// Methods

	// RVA: 0x1E34FE0 Offset: 0x1E335E0 VA: 0x181E34FE0
	public void .ctor(bool listBindable) { }

	[CompilerGenerated]
	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_ListBindable() { }

	// RVA: 0x1E34E00 Offset: 0x1E33400 VA: 0x181E34E00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E34E80 Offset: 0x1E33480 VA: 0x181E34E80 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E34F00 Offset: 0x1E33500 VA: 0x181E34F00
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class ListChangedEventArgs : EventArgs // TypeDefIndex: 7613
{
	// Fields
	[CompilerGenerated]
	private readonly ListChangedType <ListChangedType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <NewIndex>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <OldIndex>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField; // 0x20

	// Properties
	public ListChangedType ListChangedType { get; }
	public int NewIndex { get; }
	public int OldIndex { get; }

	// Methods

	// RVA: 0x1E35110 Offset: 0x1E33710 VA: 0x181E35110
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x1E35180 Offset: 0x1E33780 VA: 0x181E35180
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x1E35010 Offset: 0x1E33610 VA: 0x181E35010
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x1E35090 Offset: 0x1E33690 VA: 0x181E35090
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public ListChangedType get_ListChangedType() { }

	[CompilerGenerated]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_NewIndex() { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_OldIndex() { }
}

// Namespace: System.ComponentModel
public sealed class ListChangedEventHandler : MulticastDelegate // TypeDefIndex: 7614
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, ListChangedEventArgs e) { }
}

// Namespace: System.ComponentModel
public enum ListChangedType // TypeDefIndex: 7615
{
	// Fields
	public int value__; // 0x0
	public const ListChangedType Reset = 0;
	public const ListChangedType ItemAdded = 1;
	public const ListChangedType ItemDeleted = 2;
	public const ListChangedType ItemMoved = 3;
	public const ListChangedType ItemChanged = 4;
	public const ListChangedType PropertyDescriptorAdded = 5;
	public const ListChangedType PropertyDescriptorDeleted = 6;
	public const ListChangedType PropertyDescriptorChanged = 7;
}

// Namespace: System.ComponentModel
public enum ListSortDirection // TypeDefIndex: 7616
{
	// Fields
	public int value__; // 0x0
	public const ListSortDirection Ascending = 0;
	public const ListSortDirection Descending = 1;
}

// Namespace: System.ComponentModel
[TypeConverter(typeof(ComponentConverter))]
[DesignerCategory("Component")]
public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider // TypeDefIndex: 7617
{
	// Fields
	private static readonly object s_eventDisposed; // 0x0
	private ISite _site; // 0x10
	private EventHandlerList _events; // 0x18

	// Properties
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual ISite Site { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1E35440 Offset: 0x1E33A40 VA: 0x181E35440 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 7
	public virtual ISite get_Site() { }

	// RVA: 0x1E35210 Offset: 0x1E33810 VA: 0x181E35210 Slot: 5
	public void Dispose() { }

	// RVA: 0x1E35270 Offset: 0x1E33870 VA: 0x181E35270 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1E354B0 Offset: 0x1E33AB0 VA: 0x181E354B0 Slot: 9
	public virtual object GetService(Type service) { }

	// RVA: 0x1E35510 Offset: 0x1E33B10 VA: 0x181E35510 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E35600 Offset: 0x1E33C00 VA: 0x181E35600
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class NullableConverter : TypeConverter // TypeDefIndex: 7618
{
	// Fields
	[CompilerGenerated]
	private readonly Type <NullableType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField; // 0x20

	// Properties
	public Type NullableType { get; }
	public Type UnderlyingType { get; }
	public TypeConverter UnderlyingTypeConverter { get; }

	// Methods

	// RVA: 0x1E37430 Offset: 0x1E35A30 VA: 0x181E37430
	public void .ctor(Type type) { }

	// RVA: 0x1E36CD0 Offset: 0x1E352D0 VA: 0x181E36CD0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E36E30 Offset: 0x1E35430 VA: 0x181E36E30 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E36D80 Offset: 0x1E35380 VA: 0x181E36D80 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E36F60 Offset: 0x1E35560 VA: 0x181E36F60 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1E37170 Offset: 0x1E35770 VA: 0x181E37170 Slot: 8
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1E37130 Offset: 0x1E35730 VA: 0x181E37130 Slot: 9
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Type get_NullableType() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Type get_UnderlyingType() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public TypeConverter get_UnderlyingTypeConverter() { }
}

// Namespace: System.ComponentModel
public abstract class PropertyDescriptor : MemberDescriptor // TypeDefIndex: 7619
{
	// Fields
	private TypeConverter _converter; // 0x60
	private Hashtable _valueChangedHandlers; // 0x68
	private object[] _editors; // 0x70
	private Type[] _editorTypes; // 0x78
	private int _editorCount; // 0x80

	// Properties
	public abstract Type ComponentType { get; }
	public virtual TypeConverter Converter { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: 0x1E33BD0 Offset: 0x1E321D0 VA: 0x181E33BD0
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x1E3A2C0 Offset: 0x1E388C0 VA: 0x181E3A2C0
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Type get_ComponentType();

	// RVA: 0x1E3A2D0 Offset: 0x1E388D0 VA: 0x181E3A2D0 Slot: 14
	public virtual TypeConverter get_Converter() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool CanResetValue(object component);

	// RVA: 0x1E39C00 Offset: 0x1E38200 VA: 0x181E39C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E399F0 Offset: 0x1E37FF0 VA: 0x181E399F0
	protected object CreateInstance(Type type) { }

	// RVA: 0x1E39D80 Offset: 0x1E38380 VA: 0x181E39D80 Slot: 11
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x1E39DF0 Offset: 0x1E383F0 VA: 0x181E39DF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E39E60 Offset: 0x1E38460 VA: 0x181E39E60 Slot: 12
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x1E39FE0 Offset: 0x1E385E0 VA: 0x181E39FE0
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract object GetValue(object component);

	// RVA: 0x1E3A220 Offset: 0x1E38820 VA: 0x181E3A220 Slot: 19
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ResetValue(object component);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void SetValue(object component, object value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool ShouldSerializeValue(object component);
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary // TypeDefIndex: 7621
{
	// Fields
	public static readonly PropertyDescriptorCollection Empty; // 0x0
	private IDictionary _cachedFoundProperties; // 0x10
	private bool _cachedIgnoreCase; // 0x18
	private PropertyDescriptor[] _properties; // 0x20
	private readonly string[] _namedSort; // 0x28
	private readonly IComparer _comparer; // 0x30
	private bool _propsOwned; // 0x38
	private bool _needSort; // 0x39
	private bool _readOnly; // 0x3A
	private readonly object _internalSyncObject; // 0x40
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x48

	// Properties
	public int Count { get; set; }
	public virtual PropertyDescriptor Item { get; }
	public virtual PropertyDescriptor Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1E395F0 Offset: 0x1E37BF0 VA: 0x181E395F0
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x1E396C0 Offset: 0x1E37CC0 VA: 0x181E396C0
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	[CompilerGenerated]
	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x12DF9A0 Offset: 0x12DDFA0 VA: 0x1812DF9A0
	private void set_Count(int value) { }

	// RVA: 0x1E397A0 Offset: 0x1E37DA0 VA: 0x181E397A0 Slot: 31
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x1E39820 Offset: 0x1E37E20 VA: 0x181E39820 Slot: 32
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x1E37640 Offset: 0x1E35C40 VA: 0x181E37640
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x1E37730 Offset: 0x1E35D30 VA: 0x181E37730
	public void Clear() { }

	// RVA: 0x1E377A0 Offset: 0x1E35DA0 VA: 0x181E377A0
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x1E37800 Offset: 0x1E35E00 VA: 0x181E37800 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1E37850 Offset: 0x1E35E50 VA: 0x181E37850
	private void EnsurePropsOwned() { }

	// RVA: 0x1E37900 Offset: 0x1E35F00 VA: 0x181E37900
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x1E37A20 Offset: 0x1E36020 VA: 0x181E37A20 Slot: 33
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x1E37F30 Offset: 0x1E36530 VA: 0x181E37F30
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x1E37F90 Offset: 0x1E36590 VA: 0x181E37F90
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x1E38530 Offset: 0x1E36B30 VA: 0x181E38530
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x1E38470 Offset: 0x1E36A70 VA: 0x181E38470
	public void RemoveAt(int index) { }

	// RVA: 0x1E38120 Offset: 0x1E36720 VA: 0x181E38120
	protected void InternalSort(string[] names) { }

	// RVA: 0x1E380A0 Offset: 0x1E366A0 VA: 0x181E380A0
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x1E37E80 Offset: 0x1E36480 VA: 0x181E37E80 Slot: 34
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x12DF940 Offset: 0x12DDF40 VA: 0x1812DF940 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1E37730 Offset: 0x1E35D30 VA: 0x181E37730 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1E37730 Offset: 0x1E35D30 VA: 0x181E37730 Slot: 26
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x128A600 Offset: 0x1288C00 VA: 0x18128A600 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1E39190 Offset: 0x1E37790 VA: 0x181E39190 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1E385E0 Offset: 0x1E36BE0 VA: 0x181E385E0 Slot: 25
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x1E386A0 Offset: 0x1E36CA0 VA: 0x181E386A0 Slot: 24
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x1E38700 Offset: 0x1E36D00 VA: 0x181E38700 Slot: 29
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x13D9FE0 Offset: 0x13D85E0 VA: 0x1813D9FE0 Slot: 28
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x13D9FE0 Offset: 0x13D85E0 VA: 0x1813D9FE0 Slot: 27
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x1E38810 Offset: 0x1E36E10 VA: 0x181E38810 Slot: 20
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x1E38A00 Offset: 0x1E37000 VA: 0x181E38A00 Slot: 21
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x1E38870 Offset: 0x1E36E70 VA: 0x181E38870 Slot: 22
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x1E38930 Offset: 0x1E36F30 VA: 0x181E38930 Slot: 23
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x1E38770 Offset: 0x1E36D70 VA: 0x181E38770 Slot: 30
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x1E38E40 Offset: 0x1E37440 VA: 0x181E38E40 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1E38EC0 Offset: 0x1E374C0 VA: 0x181E38EC0 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1E38F70 Offset: 0x1E37570 VA: 0x181E38F70 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1E39020 Offset: 0x1E37620 VA: 0x181E39020 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x13D9FE0 Offset: 0x13D85E0 VA: 0x1813D9FE0 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x13D9FE0 Offset: 0x13D85E0 VA: 0x1813D9FE0 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1E391A0 Offset: 0x1E377A0 VA: 0x181E391A0 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1E392A0 Offset: 0x1E378A0 VA: 0x181E392A0 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1E392C0 Offset: 0x1E378C0 VA: 0x181E392C0 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1E39500 Offset: 0x1E37B00 VA: 0x181E39500
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4, AllowMultiple = True)]
public sealed class ProvidePropertyAttribute : Attribute // TypeDefIndex: 7622
{
	// Fields
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <ReceiverTypeName>k__BackingField; // 0x18

	// Properties
	public string PropertyName { get; }
	public string ReceiverTypeName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_PropertyName() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public string get_ReceiverTypeName() { }
}

// Namespace: System.ComponentModel
public class ReferenceConverter : TypeConverter // TypeDefIndex: 7624
{
	// Fields
	private static readonly string s_none; // 0x0
	private Type _type; // 0x10

	// Methods

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(Type type) { }

	// RVA: 0x1E3A640 Offset: 0x1E38C40 VA: 0x181E3A640 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E3A6D0 Offset: 0x1E38CD0 VA: 0x181E3A6D0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E3A950 Offset: 0x1E38F50 VA: 0x181E3A950 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1E3ACB0 Offset: 0x1E392B0 VA: 0x181E3ACB0 Slot: 8
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 9
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 10
	protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1E3B230 Offset: 0x1E39830 VA: 0x181E3B230
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
internal sealed class ReflectEventDescriptor : EventDescriptor // TypeDefIndex: 7625
{
	// Fields
	private Type _type; // 0x60
	private readonly Type _componentClass; // 0x68
	private MethodInfo _addMethod; // 0x70
	private MethodInfo _removeMethod; // 0x78
	private EventInfo _realEvent; // 0x80
	private bool _filledMethods; // 0x88

	// Methods

	// RVA: 0x1E3BE00 Offset: 0x1E3A400 VA: 0x181E3BE00
	public void .ctor(Type componentClass, EventInfo eventInfo) { }

	// RVA: 0x1E3B2A0 Offset: 0x1E398A0 VA: 0x181E3B2A0 Slot: 11
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x1E3B320 Offset: 0x1E39920 VA: 0x181E3B320
	private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes) { }

	// RVA: 0x1E3B5F0 Offset: 0x1E39BF0 VA: 0x181E3B5F0
	private void FillMethods() { }

	// RVA: 0x1E3BAF0 Offset: 0x1E3A0F0 VA: 0x181E3BAF0
	private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes) { }
}

// Namespace: System.ComponentModel
public class RefreshEventArgs : EventArgs // TypeDefIndex: 7626
{
	// Fields
	[CompilerGenerated]
	private readonly Type <TypeChanged>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1E48530 Offset: 0x1E46B30 VA: 0x181E48530
	public void .ctor(Type typeChanged) { }
}

// Namespace: System.ComponentModel
public sealed class RefreshEventHandler : MulticastDelegate // TypeDefIndex: 7627
{
	// Methods

	// RVA: 0x5C3910 Offset: 0x5C1F10 VA: 0x1805C3910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3462D0 Offset: 0x3448D0 VA: 0x1803462D0 Slot: 13
	public virtual void Invoke(RefreshEventArgs e) { }
}

// Namespace: System.ComponentModel
public class SByteConverter : BaseNumberConverter // TypeDefIndex: 7628
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1E486D0 Offset: 0x1E46CD0 VA: 0x181E486D0 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E485A0 Offset: 0x1E46BA0 VA: 0x181E485A0 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E48610 Offset: 0x1E46C10 VA: 0x181E48610 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E48640 Offset: 0x1E46C40 VA: 0x181E48640 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(128)]
public sealed class SettingsBindableAttribute : Attribute // TypeDefIndex: 7629
{
	// Fields
	public static readonly SettingsBindableAttribute Yes; // 0x0
	public static readonly SettingsBindableAttribute No; // 0x8
	[CompilerGenerated]
	private readonly bool <Bindable>k__BackingField; // 0x10

	// Properties
	public bool Bindable { get; }

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(bool bindable) { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_Bindable() { }

	// RVA: 0x1E48710 Offset: 0x1E46D10 VA: 0x181E48710 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E12130 Offset: 0x1E10730 VA: 0x181E12130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E487B0 Offset: 0x1E46DB0 VA: 0x181E487B0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class SingleConverter : BaseNumberConverter // TypeDefIndex: 7630
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	internal override bool get_AllowHex() { }

	// RVA: 0x1E489D0 Offset: 0x1E46FD0 VA: 0x181E489D0 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E488A0 Offset: 0x1E46EA0 VA: 0x181E488A0 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E48870 Offset: 0x1E46E70 VA: 0x181E48870 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E48940 Offset: 0x1E46F40 VA: 0x181E48940 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class StringConverter : TypeConverter // TypeDefIndex: 7631
{
	// Methods

	// RVA: 0x1E116E0 Offset: 0x1E0FCE0 VA: 0x181E116E0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E48A10 Offset: 0x1E47010 VA: 0x181E48A10 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class TimeSpanConverter : TypeConverter // TypeDefIndex: 7632
{
	// Methods

	// RVA: 0x1E116E0 Offset: 0x1E0FCE0 VA: 0x181E116E0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E48A80 Offset: 0x1E47080 VA: 0x181E48A80 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E48B20 Offset: 0x1E47120 VA: 0x181E48B20 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E48C90 Offset: 0x1E47290 VA: 0x181E48C90 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class TypeConverterAttribute : Attribute // TypeDefIndex: 7633
{
	// Fields
	public static readonly TypeConverterAttribute Default; // 0x0
	[CompilerGenerated]
	private readonly string <ConverterTypeName>k__BackingField; // 0x10

	// Properties
	public string ConverterTypeName { get; }

	// Methods

	// RVA: 0x1E17F10 Offset: 0x1E16510 VA: 0x181E17F10
	public void .ctor() { }

	// RVA: 0x1E49490 Offset: 0x1E47A90 VA: 0x181E49490
	public void .ctor(Type type) { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string typeName) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_ConverterTypeName() { }

	// RVA: 0x1E49390 Offset: 0x1E47990 VA: 0x181E49390 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x131A960 Offset: 0x1318F60 VA: 0x18131A960 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E49400 Offset: 0x1E47A00 VA: 0x181E49400
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public abstract class TypeDescriptionProvider // TypeDefIndex: 7635
{
	// Fields
	private readonly TypeDescriptionProvider _parent; // 0x10
	private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1E49570 Offset: 0x1E47B70 VA: 0x181E49570 Slot: 4
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1E49640 Offset: 0x1E47C40 VA: 0x181E49640 Slot: 5
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x1E49660 Offset: 0x1E47C60 VA: 0x181E49660 Slot: 6
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1E49710 Offset: 0x1E47D10 VA: 0x181E49710 Slot: 7
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x15A5160 Offset: 0x15A3760 VA: 0x1815A5160
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x1E497E0 Offset: 0x1E47DE0 VA: 0x181E497E0 Slot: 8
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1333EB0 Offset: 0x13324B0 VA: 0x181333EB0
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x1E498D0 Offset: 0x1E47ED0 VA: 0x181E498D0
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x1E49810 Offset: 0x1E47E10 VA: 0x181E49810 Slot: 9
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}

// Namespace: System.ComponentModel
[Usage(4, Inherited = True)]
public sealed class TypeDescriptionProviderAttribute : Attribute // TypeDefIndex: 7636
{
	// Fields
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; // 0x10

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x1E494F0 Offset: 0x1E47AF0 VA: 0x181E494F0
	public void .ctor(string typeName) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_TypeName() { }
}

// Namespace: System.ComponentModel
public class UInt16Converter : BaseNumberConverter // TypeDefIndex: 7637
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1E49A90 Offset: 0x1E48090 VA: 0x181E49A90 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E49960 Offset: 0x1E47F60 VA: 0x181E49960 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E499D0 Offset: 0x1E47FD0 VA: 0x181E499D0 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E49A00 Offset: 0x1E48000 VA: 0x181E49A00 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class UInt32Converter : BaseNumberConverter // TypeDefIndex: 7638
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1E49C00 Offset: 0x1E48200 VA: 0x181E49C00 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E49AD0 Offset: 0x1E480D0 VA: 0x181E49AD0 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E49B40 Offset: 0x1E48140 VA: 0x181E49B40 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E49B70 Offset: 0x1E48170 VA: 0x181E49B70 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0xC94620 Offset: 0xC92C20 VA: 0x180C94620
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class UInt64Converter : BaseNumberConverter // TypeDefIndex: 7639
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1E49D70 Offset: 0x1E48370 VA: 0x181E49D70 Slot: 11
	internal override Type get_TargetType() { }

	// RVA: 0x1E49C70 Offset: 0x1E48270 VA: 0x181E49C70 Slot: 12
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1E49C40 Offset: 0x1E48240 VA: 0x181E49C40 Slot: 13
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1E49CE0 Offset: 0x1E482E0 VA: 0x181E49CE0 Slot: 14
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }
}

// Namespace: System.ComponentModel
public interface IChangeTracking // TypeDefIndex: 7640
{
	// Properties
	public abstract bool IsChanged { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsChanged();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AcceptChanges();
}

// Namespace: System.ComponentModel
public interface IRevertibleChangeTracking : IChangeTracking // TypeDefIndex: 7641
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RejectChanges();
}

// Namespace: System.ComponentModel
public interface INotifyPropertyChanged // TypeDefIndex: 7642
{}

// Namespace: System.ComponentModel
public interface INotifyPropertyChanging // TypeDefIndex: 7643
{}

// Namespace: System.ComponentModel
public class PropertyChangedEventArgs : EventArgs // TypeDefIndex: 7644
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x1E37560 Offset: 0x1E35B60 VA: 0x181E37560
	public void .ctor(string propertyName) { }
}

// Namespace: System.ComponentModel
public sealed class PropertyChangedEventHandler : MulticastDelegate // TypeDefIndex: 7645
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, PropertyChangedEventArgs e) { }
}

// Namespace: System.ComponentModel
public class PropertyChangingEventArgs : EventArgs // TypeDefIndex: 7646
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x1E375D0 Offset: 0x1E35BD0 VA: 0x181E375D0
	public void .ctor(string propertyName) { }
}

// Namespace: System.ComponentModel
public sealed class PropertyChangingEventHandler : MulticastDelegate // TypeDefIndex: 7647
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(object sender, PropertyChangingEventArgs e) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public class CategoryAttribute : Attribute // TypeDefIndex: 7648
{
	// Fields
	private static CategoryAttribute defAttr; // 0x0
	private bool localized; // 0x10
	private string categoryValue; // 0x18

	// Properties
	public static CategoryAttribute Default { get; }
	public string Category { get; }

	// Methods

	// RVA: 0x1E2D310 Offset: 0x1E2B910 VA: 0x181E2D310
	public static CategoryAttribute get_Default() { }

	// RVA: 0x1E2D250 Offset: 0x1E2B850 VA: 0x181E2D250
	public void .ctor() { }

	// RVA: 0x12E6ED0 Offset: 0x12E54D0 VA: 0x1812E6ED0
	public void .ctor(string category) { }

	// RVA: 0x1E2D2B0 Offset: 0x1E2B8B0 VA: 0x181E2D2B0
	public string get_Category() { }

	// RVA: 0x1E2CAE0 Offset: 0x1E2B0E0 VA: 0x181E2CAE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E2CC40 Offset: 0x1E2B240 VA: 0x181E2CC40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E2CCB0 Offset: 0x1E2B2B0 VA: 0x181E2CCB0 Slot: 7
	protected virtual string GetLocalizedString(string value) { }

	// RVA: 0x1E2D0D0 Offset: 0x1E2B6D0 VA: 0x181E2D0D0 Slot: 6
	public override bool IsDefaultAttribute() { }
}

// Namespace: System.ComponentModel
public class CollectionConverter : TypeConverter // TypeDefIndex: 7649
{
	// Methods

	// RVA: 0x1E2D400 Offset: 0x1E2BA00 VA: 0x181E2D400 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[ClassInterface(1)]
[DesignerCategory("Component")]
[ComVisible(True)]
public class Component : MarshalByRefObject, IComponent, IDisposable // TypeDefIndex: 7650
{
	// Fields
	private static readonly object EventDisposed; // 0x0
	private ISite site; // 0x18
	private EventHandlerList events; // 0x20

	// Properties
	protected virtual bool CanRaiseEvents { get; }
	internal bool CanRaiseEventsInternal { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual ISite Site { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	protected bool DesignMode { get; }

	// Methods

	// RVA: 0x1369F80 Offset: 0x1368580 VA: 0x181369F80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 8
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x1531350 Offset: 0x152F950 VA: 0x181531350
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 9
	public virtual ISite get_Site() { }

	// RVA: 0x1E2D5D0 Offset: 0x1E2BBD0 VA: 0x181E2D5D0 Slot: 7
	public void Dispose() { }

	// RVA: 0x1E2D630 Offset: 0x1E2BC30 VA: 0x181E2D630 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1E2D820 Offset: 0x1E2BE20 VA: 0x181E2D820 Slot: 11
	protected virtual object GetService(Type service) { }

	// RVA: 0x1E2D9F0 Offset: 0x1E2BFF0 VA: 0x181E2D9F0
	protected bool get_DesignMode() { }

	// RVA: 0x1E2D880 Offset: 0x1E2BE80 VA: 0x181E2D880 Slot: 3
	public override string ToString() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1E2D970 Offset: 0x1E2BF70 VA: 0x181E2D970
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class ComponentConverter : ReferenceConverter // TypeDefIndex: 7651
{
	// Methods

	// RVA: 0x1E2D560 Offset: 0x1E2BB60 VA: 0x181E2D560
	public void .ctor(Type type) { }
}

// Namespace: System.ComponentModel
public class DateTimeOffsetConverter : TypeConverter // TypeDefIndex: 7652
{
	// Methods

	// RVA: 0x1E12B30 Offset: 0x1E11130 VA: 0x181E12B30 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E2EA50 Offset: 0x1E2D050 VA: 0x181E2EA50 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E2EAF0 Offset: 0x1E2D0F0 VA: 0x181E2EAF0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E2EE20 Offset: 0x1E2D420 VA: 0x181E2EE20 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class EnumConverter : TypeConverter // TypeDefIndex: 7653
{
	// Fields
	private TypeConverter.StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Properties
	protected virtual IComparer Comparer { get; }

	// Methods

	// RVA: 0x1B31CE0 Offset: 0x1B302E0 VA: 0x181B31CE0
	public void .ctor(Type type) { }

	// RVA: 0x1E30E00 Offset: 0x1E2F400 VA: 0x181E30E00 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E30EE0 Offset: 0x1E2F4E0 VA: 0x181E30EE0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E324F0 Offset: 0x1E30AF0 VA: 0x181E324F0 Slot: 10
	protected virtual IComparer get_Comparer() { }

	// RVA: 0x1E30FC0 Offset: 0x1E2F5C0 VA: 0x181E30FC0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E31410 Offset: 0x1E2FA10 VA: 0x181E31410 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1E32140 Offset: 0x1E30740 VA: 0x181E32140 Slot: 8
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 9
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }
}

// Namespace: System.ComponentModel
[TypeConverter(typeof(ComponentConverter))]
[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", True)]
[ComVisible(True)]
public interface IComponent : IDisposable // TypeDefIndex: 7654
{
	// Properties
	public abstract ISite Site { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISite get_Site();
}

// Namespace: System.ComponentModel
[ComVisible(True)]
public abstract class MemberDescriptor // TypeDefIndex: 7655
{
	// Fields
	private string name; // 0x10
	private string displayName; // 0x18
	private int nameHash; // 0x20
	private AttributeCollection attributeCollection; // 0x28
	private Attribute[] attributes; // 0x30
	private Attribute[] originalAttributes; // 0x38
	private bool attributesFiltered; // 0x40
	private bool attributesFilled; // 0x41
	private int metadataVersion; // 0x44
	private string category; // 0x48
	private string description; // 0x50
	private object lockCookie; // 0x58

	// Properties
	protected virtual Attribute[] AttributeArray { get; set; }
	public virtual AttributeCollection Attributes { get; }
	public virtual string Name { get; }
	protected virtual int NameHashCode { get; }
	public virtual string DisplayName { get; }

	// Methods

	// RVA: 0x1E367F0 Offset: 0x1E34DF0 VA: 0x181E367F0
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x1E363D0 Offset: 0x1E349D0 VA: 0x181E363D0
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x1E36970 Offset: 0x1E34F70 VA: 0x181E36970 Slot: 4
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x1E36C00 Offset: 0x1E35200 VA: 0x181E36C00 Slot: 5
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x1E369A0 Offset: 0x1E34FA0 VA: 0x181E369A0 Slot: 6
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x1E36BB0 Offset: 0x1E351B0 VA: 0x181E36BB0 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 8
	protected virtual int get_NameHashCode() { }

	// RVA: 0x1E36A80 Offset: 0x1E35080 VA: 0x181E36A80 Slot: 9
	public virtual string get_DisplayName() { }

	// RVA: 0x1E35680 Offset: 0x1E33C80 VA: 0x181E35680
	private void CheckAttributesValid() { }

	// RVA: 0x1E35740 Offset: 0x1E33D40 VA: 0x181E35740 Slot: 10
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x1E357B0 Offset: 0x1E33DB0 VA: 0x181E357B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E35A50 Offset: 0x1E34050 VA: 0x181E35A50 Slot: 11
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x1E35B70 Offset: 0x1E34170 VA: 0x181E35B70
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x1E36170 Offset: 0x1E34770 VA: 0x181E36170
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x1E360B0 Offset: 0x1E346B0 VA: 0x181E360B0
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E36200 Offset: 0x1E34800 VA: 0x181E36200 Slot: 12
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x1E36320 Offset: 0x1E34920 VA: 0x181E36320
	protected static ISite GetSite(object component) { }
}

// Namespace: System.ComponentModel
internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 7656
{
	// Fields
	private static readonly Type[] argsNone; // 0x0
	private static readonly object noValue; // 0x8
	private static TraceSwitch PropDescCreateSwitch; // 0x10
	private static TraceSwitch PropDescUsageSwitch; // 0x18
	private static readonly int BitDefaultValueQueried; // 0x20
	private static readonly int BitGetQueried; // 0x24
	private static readonly int BitSetQueried; // 0x28
	private static readonly int BitShouldSerializeQueried; // 0x2C
	private static readonly int BitResetQueried; // 0x30
	private static readonly int BitChangedQueried; // 0x34
	private static readonly int BitIPropChangedQueried; // 0x38
	private static readonly int BitReadOnlyChecked; // 0x3C
	private static readonly int BitAmbientValueQueried; // 0x40
	private static readonly int BitSetOnDemand; // 0x44
	private BitVector32 state; // 0x88
	private Type componentClass; // 0x90
	private Type type; // 0x98
	private object defaultValue; // 0xA0
	private object ambientValue; // 0xA8
	private PropertyInfo propInfo; // 0xB0
	private MethodInfo getMethod; // 0xB8
	private MethodInfo setMethod; // 0xC0
	private MethodInfo shouldSerializeMethod; // 0xC8
	private MethodInfo resetMethod; // 0xD0
	private EventDescriptor realChangedEvent; // 0xD8
	private Type receiverType; // 0xE0

	// Properties
	private object AmbientValue { get; }
	public override Type ComponentType { get; }
	private object DefaultValue { get; }
	private MethodInfo GetMethodValue { get; }
	private bool IsExtender { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	private MethodInfo ResetMethodValue { get; }
	private MethodInfo SetMethodValue { get; }
	private MethodInfo ShouldSerializeMethodValue { get; }

	// Methods

	// RVA: 0x1E3EB90 Offset: 0x1E3D190 VA: 0x181E3EB90
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x1E3EED0 Offset: 0x1E3D4D0 VA: 0x181E3EED0
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x1E3EDD0 Offset: 0x1E3D3D0 VA: 0x181E3EDD0
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x1E3F040 Offset: 0x1E3D640 VA: 0x181E3F040
	private object get_AmbientValue() { }

	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1E3F200 Offset: 0x1E3D800 VA: 0x181E3F200
	private object get_DefaultValue() { }

	// RVA: 0x1E3F510 Offset: 0x1E3DB10 VA: 0x181E3F510
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x1E3FA50 Offset: 0x1E3E050 VA: 0x181E3FA50
	private bool get_IsExtender() { }

	// RVA: 0x1E3FA90 Offset: 0x1E3E090 VA: 0x181E3FA90 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1E3FB90 Offset: 0x1E3E190 VA: 0x181E3FB90
	private MethodInfo get_ResetMethodValue() { }

	// RVA: 0x1E3FDE0 Offset: 0x1E3E3E0 VA: 0x181E3FDE0
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x1E40460 Offset: 0x1E3EA60 VA: 0x181E40460
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x1E3C1B0 Offset: 0x1E3A7B0 VA: 0x181E3C1B0
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x15B39A0 Offset: 0x15B1FA0 VA: 0x1815B39A0
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x1442A70 Offset: 0x1441070 VA: 0x181442A70
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x1E3C3E0 Offset: 0x1E3A9E0 VA: 0x181E3C3E0
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x1E3C540 Offset: 0x1E3AB40 VA: 0x181E3C540
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	// RVA: 0x1E3C910 Offset: 0x1E3AF10 VA: 0x181E3C910
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x1E3CC70 Offset: 0x1E3B270 VA: 0x181E3CC70
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x1E3BF50 Offset: 0x1E3A550 VA: 0x181E3BF50 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x1E3D010 Offset: 0x1E3B610 VA: 0x181E3D010 Slot: 11
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x1E3D9F0 Offset: 0x1E3BFF0 VA: 0x181E3D9F0 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x1E3DCF0 Offset: 0x1E3C2F0 VA: 0x181E3DCF0 Slot: 19
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x1E3DE00 Offset: 0x1E3C400 VA: 0x181E3DE00 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x1E3E100 Offset: 0x1E3C700 VA: 0x181E3E100 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x1E3E5D0 Offset: 0x1E3CBD0 VA: 0x181E3E5D0 Slot: 22
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x1E3E860 Offset: 0x1E3CE60 VA: 0x181E3E860
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 7658
{
	// Fields
	private Hashtable _typeData; // 0x20
	private static Type[] _typeConstructor; // 0x0
	private static Hashtable _editorTables; // 0x8
	private static Hashtable _intrinsicTypeConverters; // 0x10
	private static object _intrinsicReferenceKey; // 0x18
	private static object _intrinsicNullableKey; // 0x20
	private static object _dictionaryKey; // 0x28
	private static Hashtable _propertyCache; // 0x30
	private static Hashtable _eventCache; // 0x38
	private static Hashtable _attributeCache; // 0x40
	private static Hashtable _extendedPropertyCache; // 0x48
	private static readonly Guid _extenderProviderKey; // 0x50
	private static readonly Guid _extenderPropertiesKey; // 0x60
	private static readonly Guid _extenderProviderPropertiesKey; // 0x70
	private static readonly Type[] _skipInterfaceAttributeList; // 0x80
	private static object _internalSyncObject; // 0x88

	// Properties
	private static Hashtable IntrinsicTypeConverters { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x1E45BD0 Offset: 0x1E441D0 VA: 0x181E45BD0
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x1E407C0 Offset: 0x1E3EDC0 VA: 0x181E407C0 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1E406B0 Offset: 0x1E3ECB0 VA: 0x181E406B0
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x1E409B0 Offset: 0x1E3EFB0 VA: 0x181E409B0
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x1E409E0 Offset: 0x1E3EFE0 VA: 0x181E409E0 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1E40BD0 Offset: 0x1E3F1D0 VA: 0x181E40BD0
	internal string GetClassName(Type type) { }

	// RVA: 0x1E40C10 Offset: 0x1E3F210 VA: 0x181E40C10
	internal string GetComponentName(Type type, object instance) { }

	// RVA: 0x1E40CE0 Offset: 0x1E3F2E0 VA: 0x181E40CE0
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x1E40D20 Offset: 0x1E3F320 VA: 0x181E40D20
	internal EventDescriptor GetDefaultEvent(Type type, object instance) { }

	// RVA: 0x1E40D60 Offset: 0x1E3F360 VA: 0x181E40D60
	internal PropertyDescriptor GetDefaultProperty(Type type, object instance) { }

	// RVA: 0x1E41290 Offset: 0x1E3F890 VA: 0x181E41290
	internal object GetEditor(Type type, object instance, Type editorBaseType) { }

	// RVA: 0x1E40DA0 Offset: 0x1E3F3A0 VA: 0x181E40DA0
	private static Hashtable GetEditorTable(Type editorBaseType) { }

	// RVA: 0x1E412E0 Offset: 0x1E3F8E0 VA: 0x181E412E0
	internal EventDescriptorCollection GetEvents(Type type) { }

	// RVA: 0x1E41310 Offset: 0x1E3F910 VA: 0x181E41310
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x1E41360 Offset: 0x1E3F960 VA: 0x181E41360
	internal string GetExtendedClassName(object instance) { }

	// RVA: 0x1E413C0 Offset: 0x1E3F9C0 VA: 0x181E413C0
	internal string GetExtendedComponentName(object instance) { }

	// RVA: 0x1E414C0 Offset: 0x1E3FAC0 VA: 0x181E414C0
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	internal EventDescriptor GetExtendedDefaultEvent(object instance) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	internal PropertyDescriptor GetExtendedDefaultProperty(object instance) { }

	// RVA: 0x1E41520 Offset: 0x1E3FB20 VA: 0x181E41520
	internal object GetExtendedEditor(object instance, Type editorBaseType) { }

	// RVA: 0x1E41590 Offset: 0x1E3FB90 VA: 0x181E41590
	internal EventDescriptorCollection GetExtendedEvents(object instance) { }

	// RVA: 0x1E415E0 Offset: 0x1E3FBE0 VA: 0x181E415E0
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x1E41B20 Offset: 0x1E40120 VA: 0x181E41B20 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1E41DE0 Offset: 0x1E403E0 VA: 0x181E41DE0
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x1E41AB0 Offset: 0x1E400B0 VA: 0x181E41AB0
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1E42660 Offset: 0x1E40C60 VA: 0x181E42660
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x1E42690 Offset: 0x1E40C90 VA: 0x181E42690
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1E426F0 Offset: 0x1E40CF0 VA: 0x181E426F0
	private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x1E429A0 Offset: 0x1E40FA0 VA: 0x181E429A0
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x1E42A90 Offset: 0x1E41090 VA: 0x181E42A90
	internal bool IsPopulated(Type type) { }

	// RVA: 0x1E42AE0 Offset: 0x1E410E0 VA: 0x181E42AE0
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x1E42FA0 Offset: 0x1E415A0 VA: 0x181E42FA0
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x1E43460 Offset: 0x1E41A60 VA: 0x181E43460
	private static EventDescriptor[] ReflectGetEvents(Type type) { }

	// RVA: 0x1E43B70 Offset: 0x1E42170 VA: 0x181E43B70
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x1E448D0 Offset: 0x1E42ED0 VA: 0x181E448D0
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x1E44F50 Offset: 0x1E43550 VA: 0x181E44F50
	internal void Refresh(Type type) { }

	// RVA: 0x1E44FE0 Offset: 0x1E435E0 VA: 0x181E44FE0
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x1E457D0 Offset: 0x1E43DD0 VA: 0x181E457D0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[ComVisible(True)]
public class TypeConverter // TypeDefIndex: 7660
{
	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x0

	// Methods

	// RVA: 0x1E5E290 Offset: 0x1E5C890 VA: 0x181E5E290
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x1E5E220 Offset: 0x1E5C820 VA: 0x181E5E220 Slot: 4
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1E5E2B0 Offset: 0x1E5C8B0 VA: 0x181E5E2B0
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x1E5E2D0 Offset: 0x1E5C8D0 VA: 0x181E5E2D0 Slot: 5
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1E5E3A0 Offset: 0x1E5C9A0 VA: 0x181E5E3A0 Slot: 6
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E5E320 Offset: 0x1E5C920 VA: 0x181E5E320
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x1DDE690 Offset: 0x1DDCC90 VA: 0x181DDE690
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x1E5E6A0 Offset: 0x1E5CCA0 VA: 0x181E5E6A0 Slot: 7
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1E5E410 Offset: 0x1E5CA10 VA: 0x181E5E410
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x1E5E480 Offset: 0x1E5CA80 VA: 0x181E5E480
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1E5E500 Offset: 0x1E5CB00 VA: 0x181E5E500
	public string ConvertToString(object value) { }

	// RVA: 0x1E5E5E0 Offset: 0x1E5CBE0 VA: 0x181E5E5E0
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1E5E8B0 Offset: 0x1E5CEB0 VA: 0x181E5E8B0
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x1E5EA00 Offset: 0x1E5D000 VA: 0x181E5EA00
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 8
	public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 9
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public sealed class TypeDescriptor // TypeDefIndex: 7671
{
	// Fields
	private static WeakHashtable _providerTable; // 0x0
	private static Hashtable _providerTypeTable; // 0x8
	private static Hashtable _defaultProviders; // 0x10
	private static WeakHashtable _associationTable; // 0x18
	private static int _metadataVersion; // 0x20
	private static int _collisionIndex; // 0x24
	private static BooleanSwitch TraceDescriptor; // 0x28
	private static readonly Guid[] _pipelineInitializeKeys; // 0x30
	private static readonly Guid[] _pipelineMergeKeys; // 0x38
	private static readonly Guid[] _pipelineFilterKeys; // 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; // 0x48
	private static object _internalSyncObject; // 0x50
	[CompilerGenerated]
	private static RefreshEventHandler Refreshed; // 0x58

	// Properties
	[EditorBrowsable(2)]
	public static Type ComObjectType { get; }
	[EditorBrowsable(2)]
	public static Type InterfaceType { get; }
	internal static int MetadataVersion { get; }

	// Methods

	// RVA: 0x1E65A90 Offset: 0x1E64090 VA: 0x181E65A90
	public static Type get_ComObjectType() { }

	// RVA: 0x1E65AE0 Offset: 0x1E640E0 VA: 0x181E65AE0
	public static Type get_InterfaceType() { }

	// RVA: 0x1E65B30 Offset: 0x1E64130 VA: 0x181E65B30
	internal static int get_MetadataVersion() { }

	[EditorBrowsable(2)]
	// RVA: 0x1E5F1C0 Offset: 0x1E5D7C0 VA: 0x181E5F1C0
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1E5F470 Offset: 0x1E5DA70 VA: 0x181E5F470
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x1E5FB00 Offset: 0x1E5E100 VA: 0x181E5FB00
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1E5FDD0 Offset: 0x1E5E3D0 VA: 0x181E5FDD0
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x1E60000 Offset: 0x1E5E600 VA: 0x181E60000
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x1E60800 Offset: 0x1E5EE00 VA: 0x181E60800
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x1E607B0 Offset: 0x1E5EDB0 VA: 0x181E607B0
	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x1E604B0 Offset: 0x1E5EAB0 VA: 0x181E604B0
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1E608E0 Offset: 0x1E5EEE0 VA: 0x181E608E0
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x1E60990 Offset: 0x1E5EF90 VA: 0x181E60990
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x1E60C90 Offset: 0x1E5F290 VA: 0x181E60C90
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x1E60A20 Offset: 0x1E5F020 VA: 0x181E60A20
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1E61250 Offset: 0x1E5F850 VA: 0x181E61250
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x1E61110 Offset: 0x1E5F710 VA: 0x181E61110
	public static EventDescriptorCollection GetEvents(Type componentType) { }

	// RVA: 0x1E61200 Offset: 0x1E5F800 VA: 0x181E61200
	public static EventDescriptorCollection GetEvents(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x1E60DA0 Offset: 0x1E5F3A0 VA: 0x181E60DA0
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x1E61340 Offset: 0x1E5F940 VA: 0x181E61340
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x1E61570 Offset: 0x1E5FB70 VA: 0x181E61570
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x1E61AC0 Offset: 0x1E600C0 VA: 0x181E61AC0
	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	// RVA: 0x1E61C20 Offset: 0x1E60220 VA: 0x181E61C20
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x1E61BB0 Offset: 0x1E601B0 VA: 0x181E61BB0
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1E616D0 Offset: 0x1E5FCD0 VA: 0x181E616D0
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x1E61CB0 Offset: 0x1E602B0 VA: 0x181E61CB0
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x1E61D00 Offset: 0x1E60300 VA: 0x181E61D00
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x1E62070 Offset: 0x1E60670 VA: 0x181E62070
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x1E620C0 Offset: 0x1E606C0 VA: 0x181E620C0
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x1E62020 Offset: 0x1E60620 VA: 0x181E62020
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x1E61E10 Offset: 0x1E60410 VA: 0x181E61E10
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x1E62650 Offset: 0x1E60C50 VA: 0x181E62650
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x1E62AE0 Offset: 0x1E610E0 VA: 0x181E62AE0
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x1E64040 Offset: 0x1E62640 VA: 0x181E64040
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x1E64400 Offset: 0x1E62A00 VA: 0x181E64400
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x1E64E40 Offset: 0x1E63440 VA: 0x181E64E40
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x1E64EF0 Offset: 0x1E634F0 VA: 0x181E64EF0
	public static void Refresh(Type type) { }

	// RVA: 0x1E65440 Offset: 0x1E63A40 VA: 0x181E65440
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x1E65500 Offset: 0x1E63B00 VA: 0x181E65500
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x1E655D0 Offset: 0x1E63BD0 VA: 0x181E655D0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Serializable]
public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 7672
{
	// Fields
	private readonly int nativeErrorCode; // 0x90

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x1E66BB0 Offset: 0x1E651B0 VA: 0x181E66BB0
	public void .ctor() { }

	// RVA: 0x1E66CE0 Offset: 0x1E652E0 VA: 0x181E66CE0
	public void .ctor(int error) { }

	// RVA: 0x1E66CB0 Offset: 0x1E652B0 VA: 0x181E66CB0
	public void .ctor(int error, string message) { }

	// RVA: 0x1E66C20 Offset: 0x1E65220 VA: 0x181E66C20
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	public int get_NativeErrorCode() { }

	// RVA: 0x1E66AE0 Offset: 0x1E650E0 VA: 0x181E66AE0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E66010 Offset: 0x1E64610 VA: 0x181E66010
	internal static string GetErrorMessage(int error) { }
}

// Namespace: System.ComponentModel
[Usage(128)]
public sealed class NotifyParentPropertyAttribute : Attribute // TypeDefIndex: 7673
{
	// Fields
	public static readonly NotifyParentPropertyAttribute Yes; // 0x0
	public static readonly NotifyParentPropertyAttribute No; // 0x8
	public static readonly NotifyParentPropertyAttribute Default; // 0x10
	private bool notifyParent; // 0x10

	// Properties
	public bool NotifyParent { get; }

	// Methods

	// RVA: 0x34D5A0 Offset: 0x34BBA0 VA: 0x18034D5A0
	public void .ctor(bool notifyParent) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_NotifyParent() { }

	// RVA: 0x1E5B070 Offset: 0x1E59670 VA: 0x181E5B070 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E5B110 Offset: 0x1E59710 VA: 0x181E5B110 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E5B180 Offset: 0x1E59780 VA: 0x181E5B180
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public enum RefreshProperties // TypeDefIndex: 7674
{
	// Fields
	public int value__; // 0x0
	public const RefreshProperties None = 0;
	public const RefreshProperties All = 1;
	public const RefreshProperties Repaint = 2;
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 7675
{
	// Fields
	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	// Properties
	public RefreshProperties RefreshProperties { get; }

	// Methods

	// RVA: 0x593DB0 Offset: 0x5923B0 VA: 0x180593DB0
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x1E5D350 Offset: 0x1E5B950 VA: 0x181E5D350 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1E176C0 Offset: 0x1E15CC0 VA: 0x181E176C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E5D3E0 Offset: 0x1E5B9E0 VA: 0x181E5D3E0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1E5D450 Offset: 0x1E5BA50 VA: 0x181E5D450
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
internal sealed class WeakHashtable : Hashtable // TypeDefIndex: 7677
{
	// Fields
	private static IEqualityComparer _comparer; // 0x0

	// Methods

	// RVA: 0x1E65DE0 Offset: 0x1E643E0 VA: 0x181E65DE0
	internal void .ctor() { }

	// RVA: 0x1E65D40 Offset: 0x1E64340 VA: 0x181E65D40 Slot: 24
	public override void Clear() { }

	// RVA: 0x1E65D50 Offset: 0x1E64350 VA: 0x181E65D50 Slot: 39
	public override void Remove(object key) { }

	// RVA: 0x1E65D60 Offset: 0x1E64360 VA: 0x181E65D60
	private static void .cctor() { }
}

