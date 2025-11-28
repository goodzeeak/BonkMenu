// Namespace: UnityEngine.UIElements.Internal
internal class AutoCompletePathVisitor : ITypeVisitor, IPropertyVisitor, IPropertyBagVisitor, IListPropertyVisitor // TypeDefIndex: 4582
{
	// Fields
	private AutoCompletePathVisitor.VisitContext m_VisitContext; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <maxDepth>k__BackingField; // 0x18

	// Properties
	public int maxDepth { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_maxDepth() { }

	// RVA: 0x2538340 Offset: 0x2536940 VA: 0x182538340
	private bool HasReachedEnd(Type containerType) { }

	// RVA: 0x25383C0 Offset: 0x25369C0 VA: 0x1825383C0
	public void Reset() { }

	// RVA: -1 Offset: -1 Slot: 4
	private void Unity.Properties.ITypeVisitor.Visit<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6A9410 Offset: 0x6A7A10 VA: 0x1806A9410
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleEnum<Int32Enum>>
	|
	|-RVA: 0x6AB320 Offset: 0x6A9920 VA: 0x1806AB320
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleList<EasingFunction>>
	|
	|-RVA: 0x6AB7A0 Offset: 0x6A9DA0 VA: 0x1806AB7A0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleList<StylePropertyName>>
	|
	|-RVA: 0x6AAEA0 Offset: 0x6A94A0 VA: 0x1806AAEA0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleList<TimeValue>>
	|
	|-RVA: 0x6A2CC0 Offset: 0x6A12C0 VA: 0x1806A2CC0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Angle>
	|
	|-RVA: 0x6A3E60 Offset: 0x6A2460 VA: 0x1806A3E60
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Background>
	|
	|-RVA: 0x6A3120 Offset: 0x6A1720 VA: 0x1806A3120
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<BackgroundPosition>
	|
	|-RVA: 0x6A3580 Offset: 0x6A1B80 VA: 0x1806A3580
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<BackgroundRepeat>
	|
	|-RVA: 0x6A39E0 Offset: 0x6A1FE0 VA: 0x1806A39E0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<BackgroundSize>
	|
	|-RVA: 0x6A4780 Offset: 0x6A2D80 VA: 0x1806A4780
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Bounds>
	|
	|-RVA: 0x6A42F0 Offset: 0x6A28F0 VA: 0x1806A42F0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<BoundsInt>
	|
	|-RVA: 0x6A4C10 Offset: 0x6A3210 VA: 0x1806A4C10
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Color>
	|
	|-RVA: 0x6A5090 Offset: 0x6A3690 VA: 0x1806A5090
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Cursor>
	|
	|-RVA: 0x6A5520 Offset: 0x6A3B20 VA: 0x1806A5520
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<EasingFunction>
	|
	|-RVA: 0x6A5980 Offset: 0x6A3F80 VA: 0x1806A5980
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<FontDefinition>
	|
	|-RVA: 0x6A5E00 Offset: 0x6A4400 VA: 0x1806A5E00
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Length>
	|
	|-RVA: 0x6A6FF0 Offset: 0x6A55F0 VA: 0x1806A6FF0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<object>
	|
	|-RVA: 0x6A66E0 Offset: 0x6A4CE0 VA: 0x1806A66E0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Rect>
	|
	|-RVA: 0x6A6260 Offset: 0x6A4860 VA: 0x1806A6260
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<RectInt>
	|
	|-RVA: 0x6A6B60 Offset: 0x6A5160 VA: 0x1806A6B60
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Rotate>
	|
	|-RVA: 0x6A7450 Offset: 0x6A5A50 VA: 0x1806A7450
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Scale>
	|
	|-RVA: 0x6A8640 Offset: 0x6A6C40 VA: 0x1806A8640
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleBackground>
	|
	|-RVA: 0x6A78D0 Offset: 0x6A5ED0 VA: 0x1806A78D0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleBackgroundPosition>
	|
	|-RVA: 0x6A7D50 Offset: 0x6A6350 VA: 0x1806A7D50
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleBackgroundRepeat>
	|
	|-RVA: 0x6A81B0 Offset: 0x6A67B0 VA: 0x1806A81B0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleBackgroundSize>
	|
	|-RVA: 0x6A8B00 Offset: 0x6A7100 VA: 0x1806A8B00
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleColor>
	|
	|-RVA: 0x6A8F80 Offset: 0x6A7580 VA: 0x1806A8F80
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleCursor>
	|
	|-RVA: 0x6A9870 Offset: 0x6A7E70 VA: 0x1806A9870
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleFloat>
	|
	|-RVA: 0x6AA160 Offset: 0x6A8760 VA: 0x1806AA160
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleFont>
	|
	|-RVA: 0x6A9CD0 Offset: 0x6A82D0 VA: 0x1806A9CD0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleFontDefinition>
	|
	|-RVA: 0x6AA5E0 Offset: 0x6A8BE0 VA: 0x1806AA5E0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleInt>
	|
	|-RVA: 0x6AAA40 Offset: 0x6A9040 VA: 0x1806AAA40
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleLength>
	|
	|-RVA: 0x6ABC20 Offset: 0x6AA220 VA: 0x1806ABC20
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StylePropertyName>
	|
	|-RVA: 0x6AC0A0 Offset: 0x6AA6A0 VA: 0x1806AC0A0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleRotate>
	|
	|-RVA: 0x6AC520 Offset: 0x6AAB20 VA: 0x1806AC520
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleScale>
	|
	|-RVA: 0x6AC9A0 Offset: 0x6AAFA0 VA: 0x1806AC9A0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleTextShadow>
	|
	|-RVA: 0x6ACE30 Offset: 0x6AB430 VA: 0x1806ACE30
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleTransformOrigin>
	|
	|-RVA: 0x6AD2C0 Offset: 0x6AB8C0 VA: 0x1806AD2C0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleTranslate>
	|
	|-RVA: 0x6AD740 Offset: 0x6ABD40 VA: 0x1806AD740
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<TextShadow>
	|
	|-RVA: 0x6ADBC0 Offset: 0x6AC1C0 VA: 0x1806ADBC0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<TimeValue>
	|
	|-RVA: 0x6AE020 Offset: 0x6AC620 VA: 0x1806AE020
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<TransformOrigin>
	|
	|-RVA: 0x6AEA20 Offset: 0x6AD020 VA: 0x1806AEA20
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Translate>
	|
	|-RVA: 0x6AF310 Offset: 0x6AD910 VA: 0x1806AF310
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Vector2>
	|
	|-RVA: 0x6AEEB0 Offset: 0x6AD4B0 VA: 0x1806AEEB0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Vector2Int>
	|
	|-RVA: 0x6AFBD0 Offset: 0x6AE1D0 VA: 0x1806AFBD0
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Vector3>
	|
	|-RVA: 0x6AF770 Offset: 0x6ADD70 VA: 0x1806AF770
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Vector3Int>
	|
	|-RVA: 0x6B0030 Offset: 0x6AE630 VA: 0x1806B0030
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<Vector4>
	|
	|-RVA: 0x6AE530 Offset: 0x6ACB30 VA: 0x1806AE530
	|-AutoCompletePathVisitor.Unity.Properties.ITypeVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void Unity.Properties.IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6711B0 Offset: 0x66F7B0 VA: 0x1806711B0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleEnum<Int32Enum>>
	|
	|-RVA: 0x674030 Offset: 0x672630 VA: 0x180674030
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<EasingFunction>>
	|
	|-RVA: 0x6746E0 Offset: 0x672CE0 VA: 0x1806746E0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<StylePropertyName>>
	|
	|-RVA: 0x673980 Offset: 0x671F80 VA: 0x180673980
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<TimeValue>>
	|
	|-RVA: 0x666F70 Offset: 0x665570 VA: 0x180666F70
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Angle>
	|
	|-RVA: 0x668A00 Offset: 0x667000 VA: 0x180668A00
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Background>
	|
	|-RVA: 0x667600 Offset: 0x665C00 VA: 0x180667600
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundPosition>
	|
	|-RVA: 0x667C90 Offset: 0x666290 VA: 0x180667C90
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundRepeat>
	|
	|-RVA: 0x668320 Offset: 0x666920 VA: 0x180668320
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundSize>
	|
	|-RVA: 0x6697D0 Offset: 0x667DD0 VA: 0x1806697D0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Bounds>
	|
	|-RVA: 0x6690F0 Offset: 0x6676F0 VA: 0x1806690F0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BoundsInt>
	|
	|-RVA: 0x669EB0 Offset: 0x6684B0 VA: 0x180669EB0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Color>
	|
	|-RVA: 0x66A560 Offset: 0x668B60 VA: 0x18066A560
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Cursor>
	|
	|-RVA: 0x66AC40 Offset: 0x669240 VA: 0x18066AC40
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<EasingFunction>
	|
	|-RVA: 0x66B2D0 Offset: 0x6698D0 VA: 0x18066B2D0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<FontDefinition>
	|
	|-RVA: 0x66C0B0 Offset: 0x66A6B0 VA: 0x18066C0B0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Length>
	|
	|-RVA: 0x66DB80 Offset: 0x66C180 VA: 0x18066DB80
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<object>
	|
	|-RVA: 0x66CDF0 Offset: 0x66B3F0 VA: 0x18066CDF0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Rect>
	|
	|-RVA: 0x66C740 Offset: 0x66AD40 VA: 0x18066C740
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<RectInt>
	|
	|-RVA: 0x66D4A0 Offset: 0x66BAA0 VA: 0x18066D4A0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Rotate>
	|
	|-RVA: 0x66E210 Offset: 0x66C810 VA: 0x18066E210
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Scale>
	|
	|-RVA: 0x66FCE0 Offset: 0x66E2E0 VA: 0x18066FCE0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackground>
	|
	|-RVA: 0x66E8C0 Offset: 0x66CEC0 VA: 0x18066E8C0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundPosition>
	|
	|-RVA: 0x66EF70 Offset: 0x66D570 VA: 0x18066EF70
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundRepeat>
	|
	|-RVA: 0x66F600 Offset: 0x66DC00 VA: 0x18066F600
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundSize>
	|
	|-RVA: 0x6703E0 Offset: 0x66E9E0 VA: 0x1806703E0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleColor>
	|
	|-RVA: 0x670AC0 Offset: 0x66F0C0 VA: 0x180670AC0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleCursor>
	|
	|-RVA: 0x671840 Offset: 0x66FE40 VA: 0x180671840
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFloat>
	|
	|-RVA: 0x6725B0 Offset: 0x670BB0 VA: 0x1806725B0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFont>
	|
	|-RVA: 0x671ED0 Offset: 0x6704D0 VA: 0x180671ED0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFontDefinition>
	|
	|-RVA: 0x672C60 Offset: 0x671260 VA: 0x180672C60
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleInt>
	|
	|-RVA: 0x6732F0 Offset: 0x6718F0 VA: 0x1806732F0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleLength>
	|
	|-RVA: 0x674D90 Offset: 0x673390 VA: 0x180674D90
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StylePropertyName>
	|
	|-RVA: 0x675440 Offset: 0x673A40 VA: 0x180675440
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleRotate>
	|
	|-RVA: 0x675B20 Offset: 0x674120 VA: 0x180675B20
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleScale>
	|
	|-RVA: 0x676200 Offset: 0x674800 VA: 0x180676200
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTextShadow>
	|
	|-RVA: 0x6768F0 Offset: 0x674EF0 VA: 0x1806768F0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTransformOrigin>
	|
	|-RVA: 0x676FD0 Offset: 0x6755D0 VA: 0x180676FD0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTranslate>
	|
	|-RVA: 0x6776B0 Offset: 0x675CB0 VA: 0x1806776B0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TextShadow>
	|
	|-RVA: 0x677D90 Offset: 0x676390 VA: 0x180677D90
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TimeValue>
	|
	|-RVA: 0x678420 Offset: 0x676A20 VA: 0x180678420
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TransformOrigin>
	|
	|-RVA: 0x678B00 Offset: 0x677100 VA: 0x180678B00
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Translate>
	|
	|-RVA: 0x679870 Offset: 0x677E70 VA: 0x180679870
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector2>
	|
	|-RVA: 0x6791E0 Offset: 0x6777E0 VA: 0x1806791E0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector2Int>
	|
	|-RVA: 0x67A590 Offset: 0x678B90 VA: 0x18067A590
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector3>
	|
	|-RVA: 0x679F00 Offset: 0x678500 VA: 0x180679F00
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector3Int>
	|
	|-RVA: 0x67AC20 Offset: 0x679220 VA: 0x18067AC20
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector4>
	|
	|-RVA: 0x66B980 Offset: 0x669F80 VA: 0x18066B980
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.IPropertyVisitor.Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x67B2D0 Offset: 0x6798D0 VA: 0x18067B2D0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleEnum<Int32Enum>, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<EasingFunction>, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<StylePropertyName>, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<TimeValue>, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Angle, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundPosition, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundRepeat, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundSize, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<EasingFunction, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Length, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackground, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundPosition, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundRepeat, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundSize, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleColor, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleCursor, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFloat, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFont, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFontDefinition, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleInt, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleLength, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StylePropertyName, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleRotate, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleScale, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTextShadow, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTransformOrigin, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTranslate, Int32Enum>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TimeValue, Int32Enum>
	|
	|-RVA: 0x67B520 Offset: 0x679B20 VA: 0x18067B520
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<EasingFunction>, object>
	|
	|-RVA: 0x6995D0 Offset: 0x697BD0 VA: 0x1806995D0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<StylePropertyName>, object>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<TimeValue>, object>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Background, object>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Cursor, object>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<FontDefinition, object>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, object>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFont, object>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StylePropertyName, object>
	|
	|-RVA: 0x699120 Offset: 0x697720 VA: 0x180699120
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Angle, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Color, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Length, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Rect, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFloat, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TextShadow, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TimeValue, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TransformOrigin, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Translate, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector2, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector3, float>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector4, float>
	|
	|-RVA: 0x699380 Offset: 0x697980 VA: 0x180699380
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundPosition, Length>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundSize, Length>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleLength, Length>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TransformOrigin, Length>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Translate, Length>
	|
	|-RVA: 0x699C30 Offset: 0x698230 VA: 0x180699C30
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Bounds, Vector3>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Vector3>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Rotate, Vector3>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Scale, Vector3>
	|
	|-RVA: 0x699820 Offset: 0x697E20 VA: 0x180699820
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BoundsInt, Vector3Int>
	|
	|-RVA: 0x699EE0 Offset: 0x6984E0 VA: 0x180699EE0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Cursor, int>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, int>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<RectInt, int>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleInt, int>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector2Int, int>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector3Int, int>
	|
	|-RVA: 0x69A130 Offset: 0x698730 VA: 0x18069A130
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Cursor, Vector2>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TextShadow, Vector2>
	|
	|-RVA: 0x69DC00 Offset: 0x69C200 VA: 0x18069DC00
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleEnum<Int32Enum>>
	|
	|-RVA: 0x69F7C0 Offset: 0x69DDC0 VA: 0x18069F7C0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleList<EasingFunction>>
	|
	|-RVA: 0x69FBB0 Offset: 0x69E1B0 VA: 0x18069FBB0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleList<StylePropertyName>>
	|
	|-RVA: 0x69F3D0 Offset: 0x69D9D0 VA: 0x18069F3D0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleList<TimeValue>>
	|
	|-RVA: 0x69B2B0 Offset: 0x6998B0 VA: 0x18069B2B0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Background>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackground, Background>
	|
	|-RVA: 0x69AB00 Offset: 0x699100 VA: 0x18069AB00
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, BackgroundPosition>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundPosition, BackgroundPosition>
	|
	|-RVA: 0x69ADB0 Offset: 0x6993B0 VA: 0x18069ADB0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, BackgroundRepeat>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundRepeat, BackgroundRepeat>
	|
	|-RVA: 0x69B000 Offset: 0x699600 VA: 0x18069B000
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, BackgroundSize>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundSize, BackgroundSize>
	|
	|-RVA: 0x69B560 Offset: 0x699B60 VA: 0x18069B560
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Color>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleColor, Color>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TextShadow, Color>
	|
	|-RVA: 0x69B7E0 Offset: 0x699DE0 VA: 0x18069B7E0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, EasingFunction>
	|
	|-RVA: 0x69BBC0 Offset: 0x69A1C0 VA: 0x18069BBC0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, FontDefinition>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFontDefinition, FontDefinition>
	|
	|-RVA: 0x69BE40 Offset: 0x69A440 VA: 0x18069BE40
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Rotate>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleRotate, Rotate>
	|
	|-RVA: 0x69C100 Offset: 0x69A700 VA: 0x18069C100
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Scale>
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleScale, Scale>
	|
	|-RVA: 0x69CFB0 Offset: 0x69B5B0 VA: 0x18069CFB0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackground>
	|
	|-RVA: 0x69C380 Offset: 0x69A980 VA: 0x18069C380
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackgroundPosition>
	|
	|-RVA: 0x69C770 Offset: 0x69AD70 VA: 0x18069C770
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackgroundRepeat>
	|
	|-RVA: 0x69CB80 Offset: 0x69B180 VA: 0x18069CB80
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackgroundSize>
	|
	|-RVA: 0x69D3E0 Offset: 0x69B9E0 VA: 0x18069D3E0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleColor>
	|
	|-RVA: 0x69D7F0 Offset: 0x69BDF0 VA: 0x18069D7F0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleCursor>
	|
	|-RVA: 0x69DFE0 Offset: 0x69C5E0 VA: 0x18069DFE0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleFloat>
	|
	|-RVA: 0x69E7F0 Offset: 0x69CDF0 VA: 0x18069E7F0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleFont>
	|
	|-RVA: 0x69E3C0 Offset: 0x69C9C0 VA: 0x18069E3C0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleFontDefinition>
	|
	|-RVA: 0x69EBE0 Offset: 0x69D1E0 VA: 0x18069EBE0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleInt>
	|
	|-RVA: 0x69EFC0 Offset: 0x69D5C0 VA: 0x18069EFC0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleLength>
	|
	|-RVA: 0x69FFA0 Offset: 0x69E5A0 VA: 0x18069FFA0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StylePropertyName>
	|
	|-RVA: 0x6A0390 Offset: 0x69E990 VA: 0x1806A0390
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleRotate>
	|
	|-RVA: 0x6A07C0 Offset: 0x69EDC0 VA: 0x1806A07C0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleScale>
	|
	|-RVA: 0x6A0BD0 Offset: 0x69F1D0 VA: 0x1806A0BD0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleTextShadow>
	|
	|-RVA: 0x6A0FE0 Offset: 0x69F5E0 VA: 0x1806A0FE0
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleTransformOrigin>
	|
	|-RVA: 0x6A1410 Offset: 0x69FA10 VA: 0x1806A1410
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleTranslate>
	|
	|-RVA: 0x6A1840 Offset: 0x69FE40 VA: 0x1806A1840
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, TimeValue>
	|
	|-RVA: 0x69A720 Offset: 0x698D20 VA: 0x18069A720
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Rotate, Angle>
	|
	|-RVA: 0x6A1C20 Offset: 0x6A0220 VA: 0x1806A1C20
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleCursor, Cursor>
	|
	|-RVA: 0x6A2050 Offset: 0x6A0650 VA: 0x1806A2050
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTextShadow, TextShadow>
	|
	|-RVA: 0x6A2480 Offset: 0x6A0A80 VA: 0x1806A2480
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTransformOrigin, TransformOrigin>
	|
	|-RVA: 0x6A2890 Offset: 0x6A0E90 VA: 0x1806A2890
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTranslate, Translate>
	|
	|-RVA: 0x69A390 Offset: 0x698990 VA: 0x18069A390
	|-AutoCompletePathVisitor.Unity.Properties.IPropertyVisitor.Visit<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void Unity.Properties.IListPropertyVisitor.Visit<TContainer, TList, TElement>(Property<TContainer, TList> property, ref TContainer container, ref TList list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x666F20 Offset: 0x665520 VA: 0x180666F20
	|-AutoCompletePathVisitor.Unity.Properties.IListPropertyVisitor.Visit<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2538490 Offset: 0x2536A90 VA: 0x182538490
	private void VisitPropertyType(Type type) { }

	// RVA: 0x25387F0 Offset: 0x2536DF0 VA: 0x1825387F0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class TypePathVisitor : ITypeVisitor, IPropertyBagVisitor, IPropertyVisitor // TypeDefIndex: 4583
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private PropertyPath <Path>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Type <resolvedType>k__BackingField; // 0xA0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisitReturnCode <ReturnCode>k__BackingField; // 0xA8
	private Type m_LastType; // 0xB0
	private int m_PathIndex; // 0xB8

	// Properties
	public PropertyPath Path { get; set; }
	private Type resolvedType { set; }
	public VisitReturnCode ReturnCode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xEBC5C0 Offset: 0xEBABC0 VA: 0x180EBC5C0
	public PropertyPath get_Path() { }

	[CompilerGenerated]
	// RVA: 0x254AF60 Offset: 0x2549560 VA: 0x18254AF60
	public void set_Path(PropertyPath value) { }

	[CompilerGenerated]
	// RVA: 0x161F120 Offset: 0x161D720 VA: 0x18161F120
	private void set_resolvedType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x1C59660 Offset: 0x1C57C60 VA: 0x181C59660
	public VisitReturnCode get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x204F0B0 Offset: 0x204D6B0 VA: 0x18204F0B0
	internal void set_ReturnCode(VisitReturnCode value) { }

	// RVA: 0x254AED0 Offset: 0x25494D0 VA: 0x18254AED0
	public void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D66C0 Offset: 0x7D4CC0 VA: 0x1807D66C0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleEnum<Int32Enum>>
	|
	|-RVA: 0x7D96B0 Offset: 0x7D7CB0 VA: 0x1807D96B0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<EasingFunction>>
	|
	|-RVA: 0x7D9D90 Offset: 0x7D8390 VA: 0x1807D9D90
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<StylePropertyName>>
	|
	|-RVA: 0x7D8FD0 Offset: 0x7D75D0 VA: 0x1807D8FD0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<TimeValue>>
	|
	|-RVA: 0x7CC7E0 Offset: 0x7CADE0 VA: 0x1807CC7E0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Angle>
	|
	|-RVA: 0x7CE350 Offset: 0x7CC950 VA: 0x1807CE350
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Background>
	|
	|-RVA: 0x7CCEB0 Offset: 0x7CB4B0 VA: 0x1807CCEB0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundPosition>
	|
	|-RVA: 0x7CD580 Offset: 0x7CBB80 VA: 0x1807CD580
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundRepeat>
	|
	|-RVA: 0x7CDC50 Offset: 0x7CC250 VA: 0x1807CDC50
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundSize>
	|
	|-RVA: 0x7CF150 Offset: 0x7CD750 VA: 0x1807CF150
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Bounds>
	|
	|-RVA: 0x7CEA60 Offset: 0x7CD060 VA: 0x1807CEA60
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BoundsInt>
	|
	|-RVA: 0x7CF840 Offset: 0x7CDE40 VA: 0x1807CF840
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Color>
	|
	|-RVA: 0x7CFF20 Offset: 0x7CE520 VA: 0x1807CFF20
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Cursor>
	|
	|-RVA: 0x7D0610 Offset: 0x7CEC10 VA: 0x1807D0610
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<EasingFunction>
	|
	|-RVA: 0x7D0CE0 Offset: 0x7CF2E0 VA: 0x1807D0CE0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<FontDefinition>
	|
	|-RVA: 0x7D13C0 Offset: 0x7CF9C0 VA: 0x1807D13C0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Length>
	|
	|-RVA: 0x7D2F40 Offset: 0x7D1540 VA: 0x1807D2F40
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<object>
	|
	|-RVA: 0x7D2170 Offset: 0x7D0770 VA: 0x1807D2170
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Rect>
	|
	|-RVA: 0x7D1A90 Offset: 0x7D0090 VA: 0x1807D1A90
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<RectInt>
	|
	|-RVA: 0x7D2850 Offset: 0x7D0E50 VA: 0x1807D2850
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Rotate>
	|
	|-RVA: 0x7D3610 Offset: 0x7D1C10 VA: 0x1807D3610
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Scale>
	|
	|-RVA: 0x7D5190 Offset: 0x7D3790 VA: 0x1807D5190
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackground>
	|
	|-RVA: 0x7D3CF0 Offset: 0x7D22F0 VA: 0x1807D3CF0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundPosition>
	|
	|-RVA: 0x7D43D0 Offset: 0x7D29D0 VA: 0x1807D43D0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundRepeat>
	|
	|-RVA: 0x7D4AA0 Offset: 0x7D30A0 VA: 0x1807D4AA0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundSize>
	|
	|-RVA: 0x7D58B0 Offset: 0x7D3EB0 VA: 0x1807D58B0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleColor>
	|
	|-RVA: 0x7D5FB0 Offset: 0x7D45B0 VA: 0x1807D5FB0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleCursor>
	|
	|-RVA: 0x7D6D90 Offset: 0x7D5390 VA: 0x1807D6D90
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFloat>
	|
	|-RVA: 0x7D7B50 Offset: 0x7D6150 VA: 0x1807D7B50
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFont>
	|
	|-RVA: 0x7D7460 Offset: 0x7D5A60 VA: 0x1807D7460
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFontDefinition>
	|
	|-RVA: 0x7D8230 Offset: 0x7D6830 VA: 0x1807D8230
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleInt>
	|
	|-RVA: 0x7D8900 Offset: 0x7D6F00 VA: 0x1807D8900
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleLength>
	|
	|-RVA: 0x7DA470 Offset: 0x7D8A70 VA: 0x1807DA470
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StylePropertyName>
	|
	|-RVA: 0x7DAB50 Offset: 0x7D9150 VA: 0x1807DAB50
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleRotate>
	|
	|-RVA: 0x7DB250 Offset: 0x7D9850 VA: 0x1807DB250
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleScale>
	|
	|-RVA: 0x7DB950 Offset: 0x7D9F50 VA: 0x1807DB950
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTextShadow>
	|
	|-RVA: 0x7DC060 Offset: 0x7DA660 VA: 0x1807DC060
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTransformOrigin>
	|
	|-RVA: 0x7DC750 Offset: 0x7DAD50 VA: 0x1807DC750
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTranslate>
	|
	|-RVA: 0x7DCE50 Offset: 0x7DB450 VA: 0x1807DCE50
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TextShadow>
	|
	|-RVA: 0x7DDD60 Offset: 0x7DC360 VA: 0x1807DDD60
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TimeValue>
	|
	|-RVA: 0x7DE430 Offset: 0x7DCA30 VA: 0x1807DE430
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TransformOrigin>
	|
	|-RVA: 0x7DEB30 Offset: 0x7DD130 VA: 0x1807DEB30
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Translate>
	|
	|-RVA: 0x7DF8F0 Offset: 0x7DDEF0 VA: 0x1807DF8F0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector2>
	|
	|-RVA: 0x7DF220 Offset: 0x7DD820 VA: 0x1807DF220
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector2Int>
	|
	|-RVA: 0x7E0690 Offset: 0x7DEC90 VA: 0x1807E0690
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector3>
	|
	|-RVA: 0x7DFFC0 Offset: 0x7DE5C0 VA: 0x1807DFFC0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector3Int>
	|
	|-RVA: 0x7E0D60 Offset: 0x7DF360 VA: 0x1807E0D60
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector4>
	|
	|-RVA: 0x7DD5D0 Offset: 0x7DBBD0 VA: 0x1807DD5D0
	|-TypePathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void Unity.Properties.IPropertyVisitor.Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7E1440 Offset: 0x7DFA40 VA: 0x1807E1440
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleEnum<Int32Enum>, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<EasingFunction>, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<StylePropertyName>, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<TimeValue>, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Angle, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundPosition, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundRepeat, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundSize, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<EasingFunction, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Length, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackground, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundPosition, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundRepeat, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundSize, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleColor, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleCursor, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFloat, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFont, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFontDefinition, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleInt, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleLength, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StylePropertyName, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleRotate, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleScale, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTextShadow, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTransformOrigin, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTranslate, Int32Enum>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TimeValue, Int32Enum>
	|
	|-RVA: 0x7E19C0 Offset: 0x7DFFC0 VA: 0x1807E19C0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<EasingFunction>, object>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<StylePropertyName>, object>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<TimeValue>, object>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Background, object>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Cursor, object>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<FontDefinition, object>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, object>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFont, object>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StylePropertyName, object>
	|
	|-RVA: 0x7E1610 Offset: 0x7DFC10 VA: 0x1807E1610
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Angle, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Color, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Length, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Rect, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFloat, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TextShadow, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TimeValue, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TransformOrigin, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Translate, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector2, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector3, float>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector4, float>
	|
	|-RVA: 0x7E17F0 Offset: 0x7DFDF0 VA: 0x1807E17F0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundPosition, Length>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundSize, Length>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleLength, Length>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TransformOrigin, Length>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Translate, Length>
	|
	|-RVA: 0x7E1F10 Offset: 0x7E0510 VA: 0x1807E1F10
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Bounds, Vector3>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Vector3>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Rotate, Vector3>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Scale, Vector3>
	|
	|-RVA: 0x7E1B90 Offset: 0x7E0190 VA: 0x1807E1B90
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<BoundsInt, Vector3Int>
	|
	|-RVA: 0x7E2110 Offset: 0x7E0710 VA: 0x1807E2110
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Cursor, int>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, int>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<RectInt, int>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleInt, int>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector2Int, int>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector3Int, int>
	|
	|-RVA: 0x7E22E0 Offset: 0x7E08E0 VA: 0x1807E22E0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Cursor, Vector2>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TextShadow, Vector2>
	|
	|-RVA: 0x7E53F0 Offset: 0x7E39F0 VA: 0x1807E53F0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleEnum<Int32Enum>>
	|
	|-RVA: 0x7E6BE0 Offset: 0x7E51E0 VA: 0x1807E6BE0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleList<EasingFunction>>
	|
	|-RVA: 0x7E6F50 Offset: 0x7E5550 VA: 0x1807E6F50
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleList<StylePropertyName>>
	|
	|-RVA: 0x7E6870 Offset: 0x7E4E70 VA: 0x1807E6870
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleList<TimeValue>>
	|
	|-RVA: 0x7E3120 Offset: 0x7E1720 VA: 0x1807E3120
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Background>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackground, Background>
	|
	|-RVA: 0x7E2B40 Offset: 0x7E1140 VA: 0x1807E2B40
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, BackgroundPosition>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundPosition, BackgroundPosition>
	|
	|-RVA: 0x7E2D40 Offset: 0x7E1340 VA: 0x1807E2D40
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, BackgroundRepeat>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundRepeat, BackgroundRepeat>
	|
	|-RVA: 0x7E2F10 Offset: 0x7E1510 VA: 0x1807E2F10
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, BackgroundSize>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundSize, BackgroundSize>
	|
	|-RVA: 0x7E3330 Offset: 0x7E1930 VA: 0x1807E3330
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Color>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleColor, Color>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<TextShadow, Color>
	|
	|-RVA: 0x7E3530 Offset: 0x7E1B30 VA: 0x1807E3530
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, EasingFunction>
	|
	|-RVA: 0x7E3880 Offset: 0x7E1E80 VA: 0x1807E3880
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, FontDefinition>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFontDefinition, FontDefinition>
	|
	|-RVA: 0x7E3A80 Offset: 0x7E2080 VA: 0x1807E3A80
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Rotate>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleRotate, Rotate>
	|
	|-RVA: 0x7E3CA0 Offset: 0x7E22A0 VA: 0x1807E3CA0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Scale>
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleScale, Scale>
	|
	|-RVA: 0x7E4930 Offset: 0x7E2F30 VA: 0x1807E4930
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackground>
	|
	|-RVA: 0x7E3EA0 Offset: 0x7E24A0 VA: 0x1807E3EA0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackgroundPosition>
	|
	|-RVA: 0x7E4210 Offset: 0x7E2810 VA: 0x1807E4210
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackgroundRepeat>
	|
	|-RVA: 0x7E4590 Offset: 0x7E2B90 VA: 0x1807E4590
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackgroundSize>
	|
	|-RVA: 0x7E4CE0 Offset: 0x7E32E0 VA: 0x1807E4CE0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleColor>
	|
	|-RVA: 0x7E5060 Offset: 0x7E3660 VA: 0x1807E5060
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleCursor>
	|
	|-RVA: 0x7E5740 Offset: 0x7E3D40 VA: 0x1807E5740
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleFloat>
	|
	|-RVA: 0x7E5E30 Offset: 0x7E4430 VA: 0x1807E5E30
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleFont>
	|
	|-RVA: 0x7E5A90 Offset: 0x7E4090 VA: 0x1807E5A90
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleFontDefinition>
	|
	|-RVA: 0x7E61A0 Offset: 0x7E47A0 VA: 0x1807E61A0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleInt>
	|
	|-RVA: 0x7E64F0 Offset: 0x7E4AF0 VA: 0x1807E64F0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleLength>
	|
	|-RVA: 0x7E72C0 Offset: 0x7E58C0 VA: 0x1807E72C0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StylePropertyName>
	|
	|-RVA: 0x7E7630 Offset: 0x7E5C30 VA: 0x1807E7630
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleRotate>
	|
	|-RVA: 0x7E79E0 Offset: 0x7E5FE0 VA: 0x1807E79E0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleScale>
	|
	|-RVA: 0x7E7D60 Offset: 0x7E6360 VA: 0x1807E7D60
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleTextShadow>
	|
	|-RVA: 0x7E80F0 Offset: 0x7E66F0 VA: 0x1807E80F0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleTransformOrigin>
	|
	|-RVA: 0x7E8490 Offset: 0x7E6A90 VA: 0x1807E8490
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleTranslate>
	|
	|-RVA: 0x7E8840 Offset: 0x7E6E40 VA: 0x1807E8840
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, TimeValue>
	|
	|-RVA: 0x7E27F0 Offset: 0x7E0DF0 VA: 0x1807E27F0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<Rotate, Angle>
	|
	|-RVA: 0x7E8B90 Offset: 0x7E7190 VA: 0x1807E8B90
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleCursor, Cursor>
	|
	|-RVA: 0x7E8F30 Offset: 0x7E7530 VA: 0x1807E8F30
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTextShadow, TextShadow>
	|
	|-RVA: 0x7E92E0 Offset: 0x7E78E0 VA: 0x1807E92E0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTransformOrigin, TransformOrigin>
	|
	|-RVA: 0x7E9660 Offset: 0x7E7C60 VA: 0x1807E9660
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTranslate, Translate>
	|
	|-RVA: 0x7E24C0 Offset: 0x7E0AC0 VA: 0x1807E24C0
	|-TypePathVisitor.Unity.Properties.IPropertyVisitor.Visit<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void Unity.Properties.ITypeVisitor.Visit<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7EA800 Offset: 0x7E8E00 VA: 0x1807EA800
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleEnum<Int32Enum>>
	|
	|-RVA: 0x7EB5E0 Offset: 0x7E9BE0 VA: 0x1807EB5E0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleList<EasingFunction>>
	|
	|-RVA: 0x7EBCE0 Offset: 0x7EA2E0 VA: 0x1807EBCE0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleList<StylePropertyName>>
	|
	|-RVA: 0x7EAEE0 Offset: 0x7E94E0 VA: 0x1807EAEE0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleList<TimeValue>>
	|
	|-RVA: 0x7E9A00 Offset: 0x7E8000 VA: 0x1807E9A00
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Angle>
	|
	|-RVA: 0x7EA0E0 Offset: 0x7E86E0 VA: 0x1807EA0E0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Background>
	|
	|-RVA: 0x7EC460 Offset: 0x7EAA60 VA: 0x1807EC460
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<BackgroundPosition>
	|
	|-RVA: 0x7ECB40 Offset: 0x7EB140 VA: 0x1807ECB40
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<BackgroundRepeat>
	|
	|-RVA: 0x7ED220 Offset: 0x7EB820 VA: 0x1807ED220
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<BackgroundSize>
	|
	|-RVA: 0x7EE030 Offset: 0x7EC630 VA: 0x1807EE030
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Bounds>
	|
	|-RVA: 0x7ED930 Offset: 0x7EBF30 VA: 0x1807ED930
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<BoundsInt>
	|
	|-RVA: 0x7EE730 Offset: 0x7ECD30 VA: 0x1807EE730
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Color>
	|
	|-RVA: 0x7EEE30 Offset: 0x7ED430 VA: 0x1807EEE30
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Cursor>
	|
	|-RVA: 0x7EF530 Offset: 0x7EDB30 VA: 0x1807EF530
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<EasingFunction>
	|
	|-RVA: 0x7EFC10 Offset: 0x7EE210 VA: 0x1807EFC10
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<FontDefinition>
	|
	|-RVA: 0x7F09D0 Offset: 0x7EEFD0 VA: 0x1807F09D0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Length>
	|
	|-RVA: 0x7F25B0 Offset: 0x7F0BB0 VA: 0x1807F25B0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<object>
	|
	|-RVA: 0x7F17B0 Offset: 0x7EFDB0 VA: 0x1807F17B0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Rect>
	|
	|-RVA: 0x7F10B0 Offset: 0x7EF6B0 VA: 0x1807F10B0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<RectInt>
	|
	|-RVA: 0x7F1EB0 Offset: 0x7F04B0 VA: 0x1807F1EB0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Rotate>
	|
	|-RVA: 0x7F2C90 Offset: 0x7F1290 VA: 0x1807F2C90
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Scale>
	|
	|-RVA: 0x7F4870 Offset: 0x7F2E70 VA: 0x1807F4870
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleBackground>
	|
	|-RVA: 0x7F3390 Offset: 0x7F1990 VA: 0x1807F3390
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleBackgroundPosition>
	|
	|-RVA: 0x7F3A90 Offset: 0x7F2090 VA: 0x1807F3A90
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleBackgroundRepeat>
	|
	|-RVA: 0x7F4170 Offset: 0x7F2770 VA: 0x1807F4170
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleBackgroundSize>
	|
	|-RVA: 0x7F4FA0 Offset: 0x7F35A0 VA: 0x1807F4FA0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleColor>
	|
	|-RVA: 0x7F56B0 Offset: 0x7F3CB0 VA: 0x1807F56B0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleCursor>
	|
	|-RVA: 0x7F5DD0 Offset: 0x7F43D0 VA: 0x1807F5DD0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleFloat>
	|
	|-RVA: 0x7F6BB0 Offset: 0x7F51B0 VA: 0x1807F6BB0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleFont>
	|
	|-RVA: 0x7F64B0 Offset: 0x7F4AB0 VA: 0x1807F64B0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleFontDefinition>
	|
	|-RVA: 0x7F72B0 Offset: 0x7F58B0 VA: 0x1807F72B0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleInt>
	|
	|-RVA: 0x7F7990 Offset: 0x7F5F90 VA: 0x1807F7990
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleLength>
	|
	|-RVA: 0x7F8070 Offset: 0x7F6670 VA: 0x1807F8070
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StylePropertyName>
	|
	|-RVA: 0x7F8770 Offset: 0x7F6D70 VA: 0x1807F8770
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleRotate>
	|
	|-RVA: 0x7F8E70 Offset: 0x7F7470 VA: 0x1807F8E70
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleScale>
	|
	|-RVA: 0x7F9580 Offset: 0x7F7B80 VA: 0x1807F9580
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleTextShadow>
	|
	|-RVA: 0x7F9CA0 Offset: 0x7F82A0 VA: 0x1807F9CA0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleTransformOrigin>
	|
	|-RVA: 0x7FA3A0 Offset: 0x7F89A0 VA: 0x1807FA3A0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<StyleTranslate>
	|
	|-RVA: 0x7FAAA0 Offset: 0x7F90A0 VA: 0x1807FAAA0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<TextShadow>
	|
	|-RVA: 0x7FB1A0 Offset: 0x7F97A0 VA: 0x1807FB1A0
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<TimeValue>
	|
	|-RVA: 0x7FB880 Offset: 0x7F9E80 VA: 0x1807FB880
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<TransformOrigin>
	|
	|-RVA: 0x7FBF90 Offset: 0x7FA590 VA: 0x1807FBF90
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Translate>
	|
	|-RVA: 0x7FCD70 Offset: 0x7FB370 VA: 0x1807FCD70
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Vector2>
	|
	|-RVA: 0x7FC690 Offset: 0x7FAC90 VA: 0x1807FC690
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Vector2Int>
	|
	|-RVA: 0x7FDB30 Offset: 0x7FC130 VA: 0x1807FDB30
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Vector3>
	|
	|-RVA: 0x7FD450 Offset: 0x7FBA50 VA: 0x1807FD450
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Vector3Int>
	|
	|-RVA: 0x7FE210 Offset: 0x7FC810 VA: 0x1807FE210
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<Vector4>
	|
	|-RVA: 0x7F0310 Offset: 0x7EE910 VA: 0x1807F0310
	|-TypePathVisitor.Unity.Properties.ITypeVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x254AE30 Offset: 0x2549430 VA: 0x18254AE30
	private bool IsLastPartReached() { }

	// RVA: 0x254AC60 Offset: 0x2549260 VA: 0x18254AC60
	private static Type GetElementType(Type type) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnMovePreview : VisualElement // TypeDefIndex: 4584
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x253D4A0 Offset: 0x253BAA0 VA: 0x18253D4A0
	public void .ctor() { }

	// RVA: 0x253D400 Offset: 0x253BA00 VA: 0x18253D400
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnMoveLocationPreview : VisualElement // TypeDefIndex: 4585
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string visualUssClassName; // 0x8

	// Methods

	// RVA: 0x253D300 Offset: 0x253B900 VA: 0x18253D300
	public void .ctor() { }

	// RVA: 0x253D200 Offset: 0x253B800 VA: 0x18253D200
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class ColumnMover : PointerManipulator // TypeDefIndex: 4586
{
	// Fields
	private float m_StartPos; // 0x28
	private float m_LastPos; // 0x2C
	private bool m_Active; // 0x30
	private bool m_Moving; // 0x31
	private bool m_Cancelled; // 0x32
	private MultiColumnCollectionHeader m_Header; // 0x38
	private VisualElement m_PreviewElement; // 0x40
	private MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement; // 0x48
	private Column m_ColumnToMove; // 0x50
	private float m_ColumnToMovePos; // 0x58
	private float m_ColumnToMoveWidth; // 0x5C
	private Column m_DestinationColumn; // 0x60
	private bool m_MoveBeforeDestination; // 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ColumnLayout <columnLayout>k__BackingField; // 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ColumnMover> activeChanged; // 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ColumnMover> movingChanged; // 0x80

	// Properties
	public ColumnLayout columnLayout { get; set; }
	public bool active { get; set; }
	public bool moving { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void set_columnLayout(ColumnLayout value) { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool get_active() { }

	// RVA: 0x253B9E0 Offset: 0x2539FE0 VA: 0x18253B9E0
	public void set_active(bool value) { }

	// RVA: 0x16ADFC0 Offset: 0x16AC5C0 VA: 0x1816ADFC0
	public bool get_moving() { }

	// RVA: 0x253BA10 Offset: 0x253A010 VA: 0x18253BA10
	public void set_moving(bool value) { }

	[CompilerGenerated]
	// RVA: 0x253B700 Offset: 0x2539D00 VA: 0x18253B700
	public void add_activeChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	// RVA: 0x253B870 Offset: 0x2539E70 VA: 0x18253B870
	public void remove_activeChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	// RVA: 0x253B7B0 Offset: 0x2539DB0 VA: 0x18253B7B0
	public void add_movingChanged(Action<ColumnMover> value) { }

	[CompilerGenerated]
	// RVA: 0x253B920 Offset: 0x2539F20 VA: 0x18253B920
	public void remove_movingChanged(Action<ColumnMover> value) { }

	// RVA: 0x253B630 Offset: 0x2539C30 VA: 0x18253B630
	public void .ctor() { }

	// RVA: 0x253AB70 Offset: 0x2539170 VA: 0x18253AB70 Slot: 5
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x253AE60 Offset: 0x2539460 VA: 0x18253AE60 Slot: 6
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x253A240 Offset: 0x2538840 VA: 0x18253A240
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x253A2E0 Offset: 0x25388E0 VA: 0x18253A2E0
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x253A460 Offset: 0x2538A60 VA: 0x18253A460
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x253A160 Offset: 0x2538760 VA: 0x18253A160
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x253A1E0 Offset: 0x25387E0 VA: 0x18253A1E0
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x253A5C0 Offset: 0x2538BC0 VA: 0x18253A5C0
	protected void ProcessCancelEvent(EventBase evt, int pointerId) { }

	// RVA: 0x253A080 Offset: 0x2538680 VA: 0x18253A080
	private void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x253A720 Offset: 0x2538D20 VA: 0x18253A720
	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x253A920 Offset: 0x2538F20 VA: 0x18253A920
	private void ProcessMoveEvent(EventBase e, Vector2 localPosition) { }

	// RVA: 0x253AA60 Offset: 0x2539060 VA: 0x18253AA60
	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x2539A00 Offset: 0x2538000 VA: 0x182539A00
	private void BeginDragMove(float pos) { }

	// RVA: 0x2539F20 Offset: 0x2538520 VA: 0x182539F20
	internal void DragMove(float pos) { }

	// RVA: 0x253B340 Offset: 0x2539940 VA: 0x18253B340
	private void UpdatePreviewPosition() { }

	// RVA: 0x253B150 Offset: 0x2539750 VA: 0x18253B150
	private void UpdateMoveLocation() { }

	// RVA: 0x2539F30 Offset: 0x2538530 VA: 0x182539F30
	private void EndDragMove(bool cancelled) { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnResizePreview : VisualElement // TypeDefIndex: 4587
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string visualUssClassName; // 0x8

	// Methods

	// RVA: 0x2552090 Offset: 0x2550690 VA: 0x182552090
	public void .ctor() { }

	// RVA: 0x2551F90 Offset: 0x2550590 VA: 0x182551F90
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class ColumnResizer : PointerManipulator // TypeDefIndex: 4588
{
	// Fields
	private Vector2 m_Start; // 0x28
	protected bool m_Active; // 0x30
	private bool m_Resizing; // 0x31
	private MultiColumnCollectionHeader m_Header; // 0x38
	private Column m_Column; // 0x40
	private VisualElement m_PreviewElement; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ColumnLayout <columnLayout>k__BackingField; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <preview>k__BackingField; // 0x58

	// Properties
	public ColumnLayout columnLayout { get; set; }
	public bool preview { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_columnLayout(ColumnLayout value) { }

	[CompilerGenerated]
	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	public bool get_preview() { }

	[CompilerGenerated]
	// RVA: 0x3B9A60 Offset: 0x3B8060 VA: 0x1803B9A60
	public void set_preview(bool value) { }

	// RVA: 0x254CB40 Offset: 0x254B140 VA: 0x18254CB40
	public void .ctor(Column column) { }

	// RVA: 0x254C610 Offset: 0x254AC10 VA: 0x18254C610 Slot: 5
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x254C810 Offset: 0x254AE10 VA: 0x18254C810 Slot: 6
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x254BEC0 Offset: 0x254A4C0 VA: 0x18254BEC0
	private void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x254BF60 Offset: 0x254A560 VA: 0x18254BF60
	private void OnPointerDown(PointerDownEvent e) { }

	// RVA: 0x254C310 Offset: 0x254A910 VA: 0x18254C310
	private void OnPointerMove(PointerMoveEvent e) { }

	// RVA: 0x254C470 Offset: 0x254AA70 VA: 0x18254C470
	private void OnPointerUp(PointerUpEvent e) { }

	// RVA: 0x254BDB0 Offset: 0x254A3B0 VA: 0x18254BDB0
	private void BeginDragResize(float pos) { }

	// RVA: 0x254BE00 Offset: 0x254A400 VA: 0x18254BE00
	private void DragResize(float pos) { }

	// RVA: 0x254CA10 Offset: 0x254B010 VA: 0x18254CA10
	private void UpdatePreviewPosition() { }

	// RVA: 0x254BE50 Offset: 0x254A450 VA: 0x18254BE50
	private void EndDragResize(float pos, bool cancelled) { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnCollectionHeader : VisualElement, IDisposable // TypeDefIndex: 4595
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string columnContainerUssClassName; // 0x8
	public static readonly string handleContainerUssClassName; // 0x10
	public static readonly string reorderableUssClassName; // 0x18
	private bool m_SortingEnabled; // 0x4A8
	private List<SortColumnDescription> m_SortedColumns; // 0x4B0
	private SortColumnDescriptions m_SortDescriptions; // 0x4B8
	private List<MultiColumnCollectionHeader.SortedColumnState> m_OldSortedColumnStates; // 0x4C0
	private bool m_SortingUpdatesTemporarilyDisabled; // 0x4C8
	private MultiColumnCollectionHeader.ViewState m_ViewState; // 0x4D0
	private bool m_ApplyingViewState; // 0x4D8
	private bool m_DoLayoutScheduled; // 0x4D9
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Dictionary<Column, MultiColumnCollectionHeader.ColumnData> <columnDataMap>k__BackingField; // 0x4E0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ColumnLayout <columnLayout>k__BackingField; // 0x4E8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly VisualElement <columnContainer>k__BackingField; // 0x4F0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly VisualElement <resizeHandleContainer>k__BackingField; // 0x4F8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Columns <columns>k__BackingField; // 0x500
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<int, float> columnResized; // 0x508
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action columnSortingChanged; // 0x510
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent; // 0x518
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action viewDataRestored; // 0x520

	// Properties
	internal bool isApplyingViewState { get; }
	public Dictionary<Column, MultiColumnCollectionHeader.ColumnData> columnDataMap { get; }
	public ColumnLayout columnLayout { get; }
	public VisualElement columnContainer { get; }
	public VisualElement resizeHandleContainer { get; }
	public IEnumerable<SortColumnDescription> sortedColumns { get; }
	public SortColumnDescriptions sortDescriptions { get; set; }
	public Columns columns { get; }
	public bool sortingEnabled { get; set; }

	// Methods

	// RVA: 0x2551650 Offset: 0x254FC50 VA: 0x182551650
	internal bool get_isApplyingViewState() { }

	[CompilerGenerated]
	// RVA: 0xA49BF0 Offset: 0xA481F0 VA: 0x180A49BF0
	public Dictionary<Column, MultiColumnCollectionHeader.ColumnData> get_columnDataMap() { }

	[CompilerGenerated]
	// RVA: 0xC3F540 Offset: 0xC3DB40 VA: 0x180C3F540
	public ColumnLayout get_columnLayout() { }

	[CompilerGenerated]
	// RVA: 0xC5BBA0 Offset: 0xC5A1A0 VA: 0x180C5BBA0
	public VisualElement get_columnContainer() { }

	[CompilerGenerated]
	// RVA: 0xC3F530 Offset: 0xC3DB30 VA: 0x180C3F530
	public VisualElement get_resizeHandleContainer() { }

	// RVA: 0x2551660 Offset: 0x254FC60 VA: 0x182551660
	public IEnumerable<SortColumnDescription> get_sortedColumns() { }

	// RVA: 0x24BB360 Offset: 0x24B9960 VA: 0x1824BB360
	public SortColumnDescriptions get_sortDescriptions() { }

	// RVA: 0x2551960 Offset: 0x254FF60 VA: 0x182551960
	protected internal void set_sortDescriptions(SortColumnDescriptions value) { }

	[CompilerGenerated]
	// RVA: 0x2551640 Offset: 0x254FC40 VA: 0x182551640
	public Columns get_columns() { }

	// RVA: 0x2551670 Offset: 0x254FC70 VA: 0x182551670
	public bool get_sortingEnabled() { }

	// RVA: 0x2551A10 Offset: 0x2550010 VA: 0x182551A10
	public void set_sortingEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2551360 Offset: 0x254F960 VA: 0x182551360
	public void add_columnResized(Action<int, float> value) { }

	[CompilerGenerated]
	// RVA: 0x2551680 Offset: 0x254FC80 VA: 0x182551680
	public void remove_columnResized(Action<int, float> value) { }

	[CompilerGenerated]
	// RVA: 0x2551420 Offset: 0x254FA20 VA: 0x182551420
	public void add_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x2551740 Offset: 0x254FD40 VA: 0x182551740
	public void remove_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x25514D0 Offset: 0x254FAD0 VA: 0x1825514D0
	public void add_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[CompilerGenerated]
	// RVA: 0x25517F0 Offset: 0x254FDF0 VA: 0x1825517F0
	public void remove_contextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	[CompilerGenerated]
	// RVA: 0x2551590 Offset: 0x254FB90 VA: 0x182551590
	internal void add_viewDataRestored(Action value) { }

	[CompilerGenerated]
	// RVA: 0x25518B0 Offset: 0x254FEB0 VA: 0x1825518B0
	internal void remove_viewDataRestored(Action value) { }

	// RVA: 0x2550B80 Offset: 0x254F180 VA: 0x182550B80
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	// RVA: 0x254F410 Offset: 0x254DA10 VA: 0x18254F410
	private void ScheduleDoLayout() { }

	// RVA: 0x254F3C0 Offset: 0x254D9C0 VA: 0x18254F3C0
	private void ResizeToFit() { }

	// RVA: 0x254FEE0 Offset: 0x254E4E0 VA: 0x18254FEE0
	private void UpdateSortedColumns() { }

	// RVA: 0x254F740 Offset: 0x254DD40 VA: 0x18254F740
	private void UpdateColumnControls() { }

	// RVA: 0x254D870 Offset: 0x254BE70 VA: 0x18254D870
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x254D880 Offset: 0x254BE80 VA: 0x18254D880
	private void OnColumnAdded(Column column) { }

	// RVA: 0x254E330 Offset: 0x254C930 VA: 0x18254E330
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x254DD90 Offset: 0x254C390 VA: 0x18254DD90
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x254E5A0 Offset: 0x254CBA0 VA: 0x18254E5A0
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x254E770 Offset: 0x254CD70 VA: 0x18254E770
	private void OnColumnResized(Column column) { }

	// RVA: 0x254E7B0 Offset: 0x254CDB0 VA: 0x18254E7B0
	private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) { }

	// RVA: 0x254F0B0 Offset: 0x254D6B0 VA: 0x18254F0B0
	private void OnMoveManipulatorActivated(ColumnMover mover) { }

	// RVA: 0x254EF50 Offset: 0x254D550 VA: 0x18254EF50
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x254D810 Offset: 0x254BE10 VA: 0x18254D810
	private void DoLayout() { }

	// RVA: 0x254DFE0 Offset: 0x254C5E0 VA: 0x18254DFE0
	private void OnColumnControlGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x254DE20 Offset: 0x254C420 VA: 0x18254DE20
	private void OnColumnClicked(EventBase evt) { }

	// RVA: 0x254FC80 Offset: 0x254E280 VA: 0x18254FC80
	private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) { }

	// RVA: 0x254F4D0 Offset: 0x254DAD0 VA: 0x18254F4D0
	public void ScrollHorizontally(float horizontalOffset) { }

	// RVA: 0x254F260 Offset: 0x254D860 VA: 0x18254F260
	private void RaiseColumnResized(int columnIndex) { }

	// RVA: 0x254F380 Offset: 0x254D980 VA: 0x18254F380
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x254CC40 Offset: 0x254B240 VA: 0x18254CC40
	private void ApplyColumnSorting() { }

	// RVA: 0x25504F0 Offset: 0x254EAF0 VA: 0x1825504F0
	private void UpdateSortingStatus() { }

	// RVA: 0x254F150 Offset: 0x254D750 VA: 0x18254F150 Slot: 128
	internal override void OnViewDataReady() { }

	// RVA: 0x254E770 Offset: 0x254CD70 VA: 0x18254E770
	private void SaveViewState() { }

	// RVA: 0x254D360 Offset: 0x254B960 VA: 0x18254D360 Slot: 132
	public void Dispose() { }

	// RVA: 0x2550A10 Offset: 0x254F010 VA: 0x182550A10
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x254F3C0 Offset: 0x254D9C0 VA: 0x18254F3C0
	private void <OnContextualMenuManipulator>b__65_0(DropdownMenuAction a) { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnSortIndicator : VisualElement // TypeDefIndex: 4596
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string arrowUssClassName; // 0x8
	public static readonly string indexLabelUssClassName; // 0x10
	private Label m_IndexLabel; // 0x4A8

	// Properties
	public string sortOrderLabel { set; }

	// Methods

	// RVA: 0x2552470 Offset: 0x2550A70 VA: 0x182552470
	public void set_sortOrderLabel(string value) { }

	// RVA: 0x25522E0 Offset: 0x25508E0 VA: 0x1825522E0
	public void .ctor() { }

	// RVA: 0x2552190 Offset: 0x2550790 VA: 0x182552190
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnIcon : Image // TypeDefIndex: 4597
{
	// Fields
	public static readonly string ussClassName; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isImageInline>k__BackingField; // 0x4F0

	// Properties
	public bool isImageInline { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xC3FCC0 Offset: 0xC3E2C0 VA: 0x180C3FCC0
	public bool get_isImageInline() { }

	[CompilerGenerated]
	// RVA: 0x2551D60 Offset: 0x2550360 VA: 0x182551D60
	public void set_isImageInline(bool value) { }

	// RVA: 0x2551C70 Offset: 0x2550270 VA: 0x182551C70
	public void .ctor() { }

	// RVA: 0x2551A60 Offset: 0x2550060 VA: 0x182551A60
	public void UpdateClassList() { }

	// RVA: 0x2551BD0 Offset: 0x25501D0 VA: 0x182551BD0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2551A50 Offset: 0x2550050 VA: 0x182551A50
	private void <.ctor>b__5_0(CustomStyleResolvedEvent evt) { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumn : VisualElement // TypeDefIndex: 4598
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string sortableUssClassName; // 0x8
	public static readonly string sortedAscendingUssClassName; // 0x10
	public static readonly string sortedDescendingUssClassName; // 0x18
	public static readonly string movingUssClassName; // 0x20
	public static readonly string contentContainerUssClassName; // 0x28
	public static readonly string contentUssClassName; // 0x30
	public static readonly string defaultContentUssClassName; // 0x38
	public static readonly string hasIconUssClassName; // 0x40
	public static readonly string hasTitleUssClassName; // 0x48
	public static readonly string titleUssClassName; // 0x50
	public static readonly string iconElementName; // 0x58
	public static readonly string titleElementName; // 0x60
	private static readonly string s_BoundVEPropertyName; // 0x68
	private static readonly string s_BindingCallbackVEPropertyName; // 0x70
	private static readonly string s_UnbindingCallbackVEPropertyName; // 0x78
	private static readonly string s_DestroyCallbackVEPropertyName; // 0x80
	private VisualElement m_ContentContainer; // 0x4A8
	private VisualElement m_Content; // 0x4B0
	private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; // 0x4B8
	private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; // 0x4C0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Clickable <clickable>k__BackingField; // 0x4C8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ColumnMover <mover>k__BackingField; // 0x4D0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Column <column>k__BackingField; // 0x4D8

	// Properties
	public Clickable clickable { get; set; }
	public ColumnMover mover { get; set; }
	public string sortOrderLabel { set; }
	public Column column { get; set; }
	public VisualElement content { get; set; }
	private bool isContentBound { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24BB370 Offset: 0x24B9970 VA: 0x1824BB370
	public Clickable get_clickable() { }

	[CompilerGenerated]
	// RVA: 0x24BB3A0 Offset: 0x24B99A0 VA: 0x1824BB3A0
	private void set_clickable(Clickable value) { }

	[CompilerGenerated]
	// RVA: 0x25548B0 Offset: 0x2552EB0 VA: 0x1825548B0
	public ColumnMover get_mover() { }

	[CompilerGenerated]
	// RVA: 0xC5D260 Offset: 0xC5B860 VA: 0x180C5D260
	private void set_mover(ColumnMover value) { }

	// RVA: 0x2554B50 Offset: 0x2553150 VA: 0x182554B50
	public void set_sortOrderLabel(string value) { }

	[CompilerGenerated]
	// RVA: 0x25547D0 Offset: 0x2552DD0 VA: 0x1825547D0
	public Column get_column() { }

	[CompilerGenerated]
	// RVA: 0x25548C0 Offset: 0x2552EC0 VA: 0x1825548C0
	public void set_column(Column value) { }

	// RVA: 0x2551660 Offset: 0x254FC60 VA: 0x182551660
	public VisualElement get_content() { }

	// RVA: 0x25548E0 Offset: 0x2552EE0 VA: 0x1825548E0
	public void set_content(VisualElement value) { }

	// RVA: 0x25547E0 Offset: 0x2552DE0 VA: 0x1825547E0
	private bool get_isContentBound() { }

	// RVA: 0x2554AA0 Offset: 0x25530A0 VA: 0x182554AA0
	private void set_isContentBound(bool value) { }

	// RVA: 0x2553DE0 Offset: 0x25523E0 VA: 0x182553DE0
	public void .ctor(Column column) { }

	// RVA: 0x2552C70 Offset: 0x2551270 VA: 0x182552C70
	private void InitManipulators() { }

	// RVA: 0x25531E0 Offset: 0x25517E0 VA: 0x1825531E0
	private void UpdateDataFromColumn() { }

	// RVA: 0x25524A0 Offset: 0x2550AA0 VA: 0x1825524A0
	private void BindHeaderContent() { }

	// RVA: 0x2553100 Offset: 0x2551700 VA: 0x182553100
	private void UnbindHeaderContent() { }

	// RVA: 0x2552BA0 Offset: 0x25511A0 VA: 0x182552BA0
	private void DestroyHeaderContent() { }

	// RVA: 0x2552580 Offset: 0x2550B80 VA: 0x182552580
	private VisualElement CreateDefaultHeaderContent() { }

	// RVA: 0x25527F0 Offset: 0x2550DF0 VA: 0x1825527F0
	private void DefaultBindHeaderContent(VisualElement ve) { }

	// RVA: 0x2553410 Offset: 0x2551A10 VA: 0x182553410
	private void UpdateHeaderTemplate() { }

	// RVA: 0x25532E0 Offset: 0x25518E0 VA: 0x1825532E0
	private void UpdateGeometryFromColumn() { }

	// RVA: 0x2553830 Offset: 0x2551E30 VA: 0x182553830
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2552FE0 Offset: 0x25515E0 VA: 0x182552FE0
	private void <.ctor>b__45_0(Column c, ColumnDataType role) { }

	[CompilerGenerated]
	// RVA: 0x25530F0 Offset: 0x25516F0 VA: 0x1825530F0
	private void <.ctor>b__45_1(Column c) { }

	[CompilerGenerated]
	// RVA: 0x2552F30 Offset: 0x2551530 VA: 0x182552F30
	private void <InitManipulators>b__46_0(ColumnMover mv) { }
}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnResizeHandle : VisualElement // TypeDefIndex: 4599
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string dragAreaUssClassName; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly VisualElement <dragArea>k__BackingField; // 0x4A8

	// Properties
	public VisualElement dragArea { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x9FEDE0 Offset: 0x9FD3E0 VA: 0x1809FEDE0
	public VisualElement get_dragArea() { }

	// RVA: 0x2551E70 Offset: 0x2550470 VA: 0x182551E70
	public void .ctor() { }

	// RVA: 0x2551D70 Offset: 0x2550370 VA: 0x182551D70
	private static void .cctor() { }
}

