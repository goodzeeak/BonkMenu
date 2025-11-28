// Namespace: Unity.Properties.Internal
internal interface IAttributes // TypeDefIndex: 13014
{
	// Properties
	public abstract List<Attribute> Attributes { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract List<Attribute> get_Attributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Attributes(List<Attribute> value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddAttribute(Attribute attribute);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddAttributes(IEnumerable<Attribute> attributes);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract AttributesScope CreateAttributesScope(IAttributes attributes);
}

// Namespace: Unity.Properties.Internal
[VisibleToOtherModules(new[] { "UnityEditor.PropertiesModule" })]
internal static class PropertiesInitialization // TypeDefIndex: 13015
{
	// Methods

	[RequiredByNativeCode(False)]
	// RVA: 0x23D3910 Offset: 0x23D1F10 VA: 0x1823D3910
	public static void InitializeProperties() { }
}

// Namespace: Unity.Properties.Internal
internal class ColorPropertyBag : ContainerPropertyBag<Color> // TypeDefIndex: 13020
{
	// Methods

	// RVA: 0x23BB830 Offset: 0x23B9E30 VA: 0x1823BB830
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector2PropertyBag : ContainerPropertyBag<Vector2> // TypeDefIndex: 13023
{
	// Methods

	// RVA: 0x23DE8B0 Offset: 0x23DCEB0 VA: 0x1823DE8B0
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector3PropertyBag : ContainerPropertyBag<Vector3> // TypeDefIndex: 13027
{
	// Methods

	// RVA: 0x23DEB50 Offset: 0x23DD150 VA: 0x1823DEB50
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector4PropertyBag : ContainerPropertyBag<Vector4> // TypeDefIndex: 13032
{
	// Methods

	// RVA: 0x23DECD0 Offset: 0x23DD2D0 VA: 0x1823DECD0
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int> // TypeDefIndex: 13035
{
	// Methods

	// RVA: 0x23DE790 Offset: 0x23DCD90 VA: 0x1823DE790
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class Vector3IntPropertyBag : ContainerPropertyBag<Vector3Int> // TypeDefIndex: 13039
{
	// Methods

	// RVA: 0x23DE9D0 Offset: 0x23DCFD0 VA: 0x1823DE9D0
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class RectPropertyBag : ContainerPropertyBag<Rect> // TypeDefIndex: 13044
{
	// Methods

	// RVA: 0x23D9C50 Offset: 0x23D8250 VA: 0x1823D9C50
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class RectIntPropertyBag : ContainerPropertyBag<RectInt> // TypeDefIndex: 13049
{
	// Methods

	// RVA: 0x23D9A80 Offset: 0x23D8080 VA: 0x1823D9A80
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class BoundsPropertyBag : ContainerPropertyBag<Bounds> // TypeDefIndex: 13052
{
	// Methods

	// RVA: 0x23BB580 Offset: 0x23B9B80 VA: 0x1823BB580
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt> // TypeDefIndex: 13055
{
	// Methods

	// RVA: 0x23BB460 Offset: 0x23B9A60 VA: 0x1823BB460
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal class SystemVersionPropertyBag : ContainerPropertyBag<Version> // TypeDefIndex: 13060
{
	// Methods

	// RVA: 0x23DA8C0 Offset: 0x23D8EC0 VA: 0x1823DA8C0
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
internal interface IPropertyBagRegister // TypeDefIndex: 13061
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Register();
}

// Namespace: Unity.Properties.Internal
internal static class PropertyBagStore // TypeDefIndex: 13063
{
	// Fields
	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags; // 0x0
	private static readonly List<Type> s_RegisteredTypes; // 0x8
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; // 0x10

	// Properties
	private static ReflectedPropertyBagProvider ReflectedPropertyBagProvider { get; }

	// Methods

	// RVA: 0x23D5090 Offset: 0x23D3690 VA: 0x1823D5090
	private static ReflectedPropertyBagProvider get_ReflectedPropertyBagProvider() { }

	// RVA: 0x23D4A00 Offset: 0x23D3000 VA: 0x1823D4A00
	internal static void CreatePropertyBagProvider() { }

	// RVA: -1 Offset: -1
	internal static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74B8D0 Offset: 0x749ED0 VA: 0x18074B8D0
	|-PropertyBagStore.AddPropertyBag<StyleEnum<Int32Enum>>
	|-PropertyBagStore.AddPropertyBag<StyleList<EasingFunction>>
	|-PropertyBagStore.AddPropertyBag<StyleList<StylePropertyName>>
	|-PropertyBagStore.AddPropertyBag<StyleList<TimeValue>>
	|-PropertyBagStore.AddPropertyBag<Angle>
	|-PropertyBagStore.AddPropertyBag<Background>
	|-PropertyBagStore.AddPropertyBag<BackgroundPosition>
	|-PropertyBagStore.AddPropertyBag<Bounds>
	|-PropertyBagStore.AddPropertyBag<BoundsInt>
	|-PropertyBagStore.AddPropertyBag<Rect>
	|-PropertyBagStore.AddPropertyBag<RectInt>
	|-PropertyBagStore.AddPropertyBag<Vector2Int>
	|-PropertyBagStore.AddPropertyBag<Vector4>
	|
	|-RVA: 0x74DC50 Offset: 0x74C250 VA: 0x18074DC50
	|-PropertyBagStore.AddPropertyBag<BackgroundRepeat>
	|-PropertyBagStore.AddPropertyBag<BackgroundSize>
	|-PropertyBagStore.AddPropertyBag<Color>
	|-PropertyBagStore.AddPropertyBag<Cursor>
	|-PropertyBagStore.AddPropertyBag<EasingFunction>
	|-PropertyBagStore.AddPropertyBag<FontDefinition>
	|-PropertyBagStore.AddPropertyBag<Length>
	|-PropertyBagStore.AddPropertyBag<object>
	|-PropertyBagStore.AddPropertyBag<Rotate>
	|-PropertyBagStore.AddPropertyBag<Scale>
	|-PropertyBagStore.AddPropertyBag<StyleBackground>
	|-PropertyBagStore.AddPropertyBag<StyleBackgroundPosition>
	|-PropertyBagStore.AddPropertyBag<StyleBackgroundRepeat>
	|-PropertyBagStore.AddPropertyBag<StyleBackgroundSize>
	|-PropertyBagStore.AddPropertyBag<StyleColor>
	|-PropertyBagStore.AddPropertyBag<StyleCursor>
	|-PropertyBagStore.AddPropertyBag<StyleFloat>
	|-PropertyBagStore.AddPropertyBag<StyleFont>
	|-PropertyBagStore.AddPropertyBag<StyleFontDefinition>
	|-PropertyBagStore.AddPropertyBag<StyleInt>
	|-PropertyBagStore.AddPropertyBag<StyleLength>
	|-PropertyBagStore.AddPropertyBag<StylePropertyName>
	|-PropertyBagStore.AddPropertyBag<StyleRotate>
	|-PropertyBagStore.AddPropertyBag<StyleScale>
	|-PropertyBagStore.AddPropertyBag<StyleTextShadow>
	|-PropertyBagStore.AddPropertyBag<StyleTransformOrigin>
	|-PropertyBagStore.AddPropertyBag<StyleTranslate>
	|-PropertyBagStore.AddPropertyBag<TextShadow>
	|-PropertyBagStore.AddPropertyBag<TimeValue>
	|-PropertyBagStore.AddPropertyBag<TransformOrigin>
	|-PropertyBagStore.AddPropertyBag<Translate>
	|-PropertyBagStore.AddPropertyBag<Vector2>
	|-PropertyBagStore.AddPropertyBag<Vector3>
	|-PropertyBagStore.AddPropertyBag<Vector3Int>
	|
	|-RVA: 0x74E200 Offset: 0x74C800 VA: 0x18074E200
	|-PropertyBagStore.AddPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static IPropertyBag<TContainer> GetPropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74E730 Offset: 0x74CD30 VA: 0x18074E730
	|-PropertyBagStore.GetPropertyBag<StyleEnum<Int32Enum>>
	|-PropertyBagStore.GetPropertyBag<StyleList<EasingFunction>>
	|-PropertyBagStore.GetPropertyBag<StyleList<StylePropertyName>>
	|-PropertyBagStore.GetPropertyBag<StyleList<TimeValue>>
	|-PropertyBagStore.GetPropertyBag<Angle>
	|-PropertyBagStore.GetPropertyBag<Background>
	|-PropertyBagStore.GetPropertyBag<BackgroundPosition>
	|-PropertyBagStore.GetPropertyBag<BackgroundRepeat>
	|-PropertyBagStore.GetPropertyBag<BackgroundSize>
	|-PropertyBagStore.GetPropertyBag<Bounds>
	|-PropertyBagStore.GetPropertyBag<BoundsInt>
	|-PropertyBagStore.GetPropertyBag<Color>
	|-PropertyBagStore.GetPropertyBag<Cursor>
	|-PropertyBagStore.GetPropertyBag<EasingFunction>
	|-PropertyBagStore.GetPropertyBag<FontDefinition>
	|-PropertyBagStore.GetPropertyBag<int>
	|-PropertyBagStore.GetPropertyBag<Int32Enum>
	|-PropertyBagStore.GetPropertyBag<Length>
	|-PropertyBagStore.GetPropertyBag<object>
	|-PropertyBagStore.GetPropertyBag<Rect>
	|-PropertyBagStore.GetPropertyBag<RectInt>
	|-PropertyBagStore.GetPropertyBag<Rotate>
	|-PropertyBagStore.GetPropertyBag<Scale>
	|-PropertyBagStore.GetPropertyBag<float>
	|-PropertyBagStore.GetPropertyBag<StyleBackground>
	|-PropertyBagStore.GetPropertyBag<StyleBackgroundPosition>
	|-PropertyBagStore.GetPropertyBag<StyleBackgroundRepeat>
	|-PropertyBagStore.GetPropertyBag<StyleBackgroundSize>
	|-PropertyBagStore.GetPropertyBag<StyleColor>
	|-PropertyBagStore.GetPropertyBag<StyleCursor>
	|-PropertyBagStore.GetPropertyBag<StyleFloat>
	|-PropertyBagStore.GetPropertyBag<StyleFont>
	|-PropertyBagStore.GetPropertyBag<StyleFontDefinition>
	|-PropertyBagStore.GetPropertyBag<StyleInt>
	|-PropertyBagStore.GetPropertyBag<StyleLength>
	|-PropertyBagStore.GetPropertyBag<StylePropertyName>
	|-PropertyBagStore.GetPropertyBag<StyleRotate>
	|-PropertyBagStore.GetPropertyBag<StyleScale>
	|-PropertyBagStore.GetPropertyBag<StyleTextShadow>
	|-PropertyBagStore.GetPropertyBag<StyleTransformOrigin>
	|-PropertyBagStore.GetPropertyBag<StyleTranslate>
	|-PropertyBagStore.GetPropertyBag<TextShadow>
	|-PropertyBagStore.GetPropertyBag<TimeValue>
	|-PropertyBagStore.GetPropertyBag<TransformOrigin>
	|-PropertyBagStore.GetPropertyBag<Translate>
	|-PropertyBagStore.GetPropertyBag<Vector2>
	|-PropertyBagStore.GetPropertyBag<Vector2Int>
	|-PropertyBagStore.GetPropertyBag<Vector3>
	|-PropertyBagStore.GetPropertyBag<Vector3Int>
	|-PropertyBagStore.GetPropertyBag<Vector4>
	|-PropertyBagStore.GetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23D4A90 Offset: 0x23D3090 VA: 0x1823D4A90
	internal static IPropertyBag GetPropertyBag(Type type) { }

	// RVA: -1 Offset: -1
	internal static bool TryGetPropertyBagForValue<TValue>(ref TValue value, out IPropertyBag propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x754790 Offset: 0x752D90 VA: 0x180754790
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleEnum<Int32Enum>>
	|
	|-RVA: 0x7564A0 Offset: 0x754AA0 VA: 0x1807564A0
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleList<EasingFunction>>
	|
	|-RVA: 0x756910 Offset: 0x754F10 VA: 0x180756910
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleList<StylePropertyName>>
	|
	|-RVA: 0x756030 Offset: 0x754630 VA: 0x180756030
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleList<TimeValue>>
	|
	|-RVA: 0x74E880 Offset: 0x74CE80 VA: 0x18074E880
	|-PropertyBagStore.TryGetPropertyBagForValue<Angle>
	|
	|-RVA: 0x74F990 Offset: 0x74DF90 VA: 0x18074F990
	|-PropertyBagStore.TryGetPropertyBagForValue<Background>
	|
	|-RVA: 0x74ECE0 Offset: 0x74D2E0 VA: 0x18074ECE0
	|-PropertyBagStore.TryGetPropertyBagForValue<BackgroundPosition>
	|
	|-RVA: 0x74F180 Offset: 0x74D780 VA: 0x18074F180
	|-PropertyBagStore.TryGetPropertyBagForValue<BackgroundRepeat>
	|
	|-RVA: 0x74F570 Offset: 0x74DB70 VA: 0x18074F570
	|-PropertyBagStore.TryGetPropertyBagForValue<BackgroundSize>
	|
	|-RVA: 0x74FE20 Offset: 0x74E420 VA: 0x18074FE20
	|-PropertyBagStore.TryGetPropertyBagForValue<Color>
	|
	|-RVA: 0x750220 Offset: 0x74E820 VA: 0x180750220
	|-PropertyBagStore.TryGetPropertyBagForValue<Cursor>
	|
	|-RVA: 0x750660 Offset: 0x74EC60 VA: 0x180750660
	|-PropertyBagStore.TryGetPropertyBagForValue<EasingFunction>
	|
	|-RVA: 0x750A50 Offset: 0x74F050 VA: 0x180750A50
	|-PropertyBagStore.TryGetPropertyBagForValue<FontDefinition>
	|
	|-RVA: 0x7515E0 Offset: 0x74FBE0 VA: 0x1807515E0
	|-PropertyBagStore.TryGetPropertyBagForValue<int>
	|
	|-RVA: 0x751180 Offset: 0x74F780 VA: 0x180751180
	|-PropertyBagStore.TryGetPropertyBagForValue<Int32Enum>
	|
	|-RVA: 0x751A40 Offset: 0x750040 VA: 0x180751A40
	|-PropertyBagStore.TryGetPropertyBagForValue<Length>
	|
	|-RVA: 0x752270 Offset: 0x750870 VA: 0x180752270
	|-PropertyBagStore.TryGetPropertyBagForValue<object>
	|
	|-RVA: 0x751E30 Offset: 0x750430 VA: 0x180751E30
	|-PropertyBagStore.TryGetPropertyBagForValue<Rotate>
	|
	|-RVA: 0x752630 Offset: 0x750C30 VA: 0x180752630
	|-PropertyBagStore.TryGetPropertyBagForValue<Scale>
	|
	|-RVA: 0x752A30 Offset: 0x751030 VA: 0x180752A30
	|-PropertyBagStore.TryGetPropertyBagForValue<float>
	|
	|-RVA: 0x753AF0 Offset: 0x7520F0 VA: 0x180753AF0
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleBackground>
	|
	|-RVA: 0x752E90 Offset: 0x751490 VA: 0x180752E90
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleBackgroundPosition>
	|
	|-RVA: 0x753290 Offset: 0x751890 VA: 0x180753290
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleBackgroundRepeat>
	|
	|-RVA: 0x7536B0 Offset: 0x751CB0 VA: 0x1807536B0
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleBackgroundSize>
	|
	|-RVA: 0x753F50 Offset: 0x752550 VA: 0x180753F50
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleColor>
	|
	|-RVA: 0x754370 Offset: 0x752970 VA: 0x180754370
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleCursor>
	|
	|-RVA: 0x754BF0 Offset: 0x7531F0 VA: 0x180754BF0
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleFloat>
	|
	|-RVA: 0x755420 Offset: 0x753A20 VA: 0x180755420
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleFont>
	|
	|-RVA: 0x754FE0 Offset: 0x7535E0 VA: 0x180754FE0
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleFontDefinition>
	|
	|-RVA: 0x755820 Offset: 0x753E20 VA: 0x180755820
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleInt>
	|
	|-RVA: 0x755C10 Offset: 0x754210 VA: 0x180755C10
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleLength>
	|
	|-RVA: 0x756D80 Offset: 0x755380 VA: 0x180756D80
	|-PropertyBagStore.TryGetPropertyBagForValue<StylePropertyName>
	|
	|-RVA: 0x757180 Offset: 0x755780 VA: 0x180757180
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleRotate>
	|
	|-RVA: 0x7575D0 Offset: 0x755BD0 VA: 0x1807575D0
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleScale>
	|
	|-RVA: 0x7579F0 Offset: 0x755FF0 VA: 0x1807579F0
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleTextShadow>
	|
	|-RVA: 0x757E10 Offset: 0x756410 VA: 0x180757E10
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleTransformOrigin>
	|
	|-RVA: 0x758250 Offset: 0x756850 VA: 0x180758250
	|-PropertyBagStore.TryGetPropertyBagForValue<StyleTranslate>
	|
	|-RVA: 0x7586A0 Offset: 0x756CA0 VA: 0x1807586A0
	|-PropertyBagStore.TryGetPropertyBagForValue<TextShadow>
	|
	|-RVA: 0x758AF0 Offset: 0x7570F0 VA: 0x180758AF0
	|-PropertyBagStore.TryGetPropertyBagForValue<TimeValue>
	|
	|-RVA: 0x758EE0 Offset: 0x7574E0 VA: 0x180758EE0
	|-PropertyBagStore.TryGetPropertyBagForValue<TransformOrigin>
	|
	|-RVA: 0x759300 Offset: 0x757900 VA: 0x180759300
	|-PropertyBagStore.TryGetPropertyBagForValue<Translate>
	|
	|-RVA: 0x759740 Offset: 0x757D40 VA: 0x180759740
	|-PropertyBagStore.TryGetPropertyBagForValue<Vector2>
	|
	|-RVA: 0x759F60 Offset: 0x758560 VA: 0x180759F60
	|-PropertyBagStore.TryGetPropertyBagForValue<Vector3>
	|
	|-RVA: 0x759B40 Offset: 0x758140 VA: 0x180759B40
	|-PropertyBagStore.TryGetPropertyBagForValue<Vector3Int>
	|
	|-RVA: 0x750E50 Offset: 0x74F450 VA: 0x180750E50
	|-PropertyBagStore.TryGetPropertyBagForValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23D4F70 Offset: 0x23D3570 VA: 0x1823D4F70
	private static void .cctor() { }
}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagAttribute : Attribute // TypeDefIndex: 13064
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
[ReflectedPropertyBag]
internal class ReflectedPropertyBag<TContainer> : ContainerPropertyBag<TContainer> // TypeDefIndex: 13065
{
	// Methods

	// RVA: -1 Offset: -1
	internal void AddProperty<TValue>(Property<TContainer, TValue> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x608890 Offset: 0x606E90 VA: 0x180608890
	|-ReflectedPropertyBag<__Il2CppFullySharedGenericType>.AddProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D0C0 Offset: 0x95B6C0 VA: 0x18095D0C0
	|-ReflectedPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagProvider // TypeDefIndex: 13068
{
	// Fields
	private readonly MethodInfo m_CreatePropertyMethod; // 0x10
	private readonly MethodInfo m_CreatePropertyBagMethod; // 0x18
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; // 0x20
	private readonly MethodInfo m_CreateSetPropertyBagMethod; // 0x28
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; // 0x30
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; // 0x38
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; // 0x40
	private readonly MethodInfo m_CreateListPropertyBagMethod; // 0x48
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; // 0x50
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; // 0x58

	// Methods

	// RVA: 0x23DA220 Offset: 0x23D8820 VA: 0x1823DA220
	public void .ctor() { }

	// RVA: 0x23D9E20 Offset: 0x23D8420 VA: 0x1823D9E20
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: -1 Offset: -1
	public IPropertyBag<TContainer> CreatePropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78DF00 Offset: 0x78C500 VA: 0x18078DF00
	|-ReflectedPropertyBagProvider.CreatePropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private void CreateProperty<TContainer, TValue>(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78F9F0 Offset: 0x78DFF0 VA: 0x18078F9F0
	|-ReflectedPropertyBagProvider.CreateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78DEA0 Offset: 0x78C4A0 VA: 0x18078DEA0
	|-ReflectedPropertyBagProvider.CreateIndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78DEA0 Offset: 0x78C4A0 VA: 0x18078DEA0
	|-ReflectedPropertyBagProvider.CreateSetPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78DEA0 Offset: 0x78C4A0 VA: 0x18078DEA0
	|-ReflectedPropertyBagProvider.CreateKeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78DEA0 Offset: 0x78C4A0 VA: 0x18078DEA0
	|-ReflectedPropertyBagProvider.CreateKeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78DEA0 Offset: 0x78C4A0 VA: 0x18078DEA0
	|-ReflectedPropertyBagProvider.CreateArrayPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<List<TElement>> CreateListPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78DEA0 Offset: 0x78C4A0 VA: 0x18078DEA0
	|-ReflectedPropertyBagProvider.CreateListPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<HashSet<TElement>> CreateHashSetPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78DEA0 Offset: 0x78C4A0 VA: 0x18078DEA0
	|-ReflectedPropertyBagProvider.CreateHashSetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78DEA0 Offset: 0x78C4A0 VA: 0x18078DEA0
	|-ReflectedPropertyBagProvider.CreateDictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(ReflectedPropertyBagProvider.<GetPropertyMembers>d__22))]
	// RVA: 0x23D9F70 Offset: 0x23D8570 VA: 0x1823D9F70
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x23D9FF0 Offset: 0x23D85F0 VA: 0x1823D9FF0
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x23DA130 Offset: 0x23D8730 VA: 0x1823DA130
	private static bool IsValidPropertyType(Type type) { }
}

// Namespace: Unity.Properties.Internal
internal static class ReflectionUtilities // TypeDefIndex: 13069
{
	// Methods

	// RVA: 0x23DA660 Offset: 0x23D8C60 VA: 0x1823DA660
	public static string SanitizeMemberName(MemberInfo info) { }
}

