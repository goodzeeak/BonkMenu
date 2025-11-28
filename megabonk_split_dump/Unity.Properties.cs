// Namespace: Unity.Properties
[Flags]
public enum VisitExceptionKind // TypeDefIndex: 12906
{
	// Fields
	public int value__; // 0x0
	public const VisitExceptionKind None = 0;
	public const VisitExceptionKind Internal = 1;
	public const VisitExceptionKind Visitor = 2;
	public const VisitExceptionKind All = 3;
}

// Namespace: Unity.Properties
public struct VisitParameters // TypeDefIndex: 12907
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisitExceptionKind <IgnoreExceptions>k__BackingField; // 0x0

	// Properties
	public VisitExceptionKind IgnoreExceptions { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public VisitExceptionKind get_IgnoreExceptions() { }
}

// Namespace: Unity.Properties
public static class PropertyContainer // TypeDefIndex: 12912
{
	// Methods

	// RVA: -1 Offset: -1
	public static void Accept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, VisitParameters parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x75CB70 Offset: 0x75B170 VA: 0x18075CB70
	|-PropertyContainer.Accept<StyleEnum<Int32Enum>>
	|
	|-RVA: 0x75CF70 Offset: 0x75B570 VA: 0x18075CF70
	|-PropertyContainer.Accept<StyleList<EasingFunction>>
	|
	|-RVA: 0x75D170 Offset: 0x75B770 VA: 0x18075D170
	|-PropertyContainer.Accept<StyleList<StylePropertyName>>
	|
	|-RVA: 0x75CD70 Offset: 0x75B370 VA: 0x18075CD70
	|-PropertyContainer.Accept<StyleList<TimeValue>>
	|
	|-RVA: 0x75A380 Offset: 0x758980 VA: 0x18075A380
	|-PropertyContainer.Accept<Angle>
	|
	|-RVA: 0x75AB80 Offset: 0x759180 VA: 0x18075AB80
	|-PropertyContainer.Accept<Background>
	|
	|-RVA: 0x75A580 Offset: 0x758B80 VA: 0x18075A580
	|-PropertyContainer.Accept<BackgroundPosition>
	|
	|-RVA: 0x75A780 Offset: 0x758D80 VA: 0x18075A780
	|-PropertyContainer.Accept<BackgroundRepeat>
	|
	|-RVA: 0x75A980 Offset: 0x758F80 VA: 0x18075A980
	|-PropertyContainer.Accept<BackgroundSize>
	|
	|-RVA: 0x75AD80 Offset: 0x759380 VA: 0x18075AD80
	|-PropertyContainer.Accept<Color>
	|
	|-RVA: 0x75AF80 Offset: 0x759580 VA: 0x18075AF80
	|-PropertyContainer.Accept<Cursor>
	|
	|-RVA: 0x75B180 Offset: 0x759780 VA: 0x18075B180
	|-PropertyContainer.Accept<EasingFunction>
	|
	|-RVA: 0x75B380 Offset: 0x759980 VA: 0x18075B380
	|-PropertyContainer.Accept<FontDefinition>
	|
	|-RVA: 0x75B780 Offset: 0x759D80 VA: 0x18075B780
	|-PropertyContainer.Accept<int>
	|
	|-RVA: 0x75B580 Offset: 0x759B80 VA: 0x18075B580
	|-PropertyContainer.Accept<Int32Enum>
	|
	|-RVA: 0x75B980 Offset: 0x759F80 VA: 0x18075B980
	|-PropertyContainer.Accept<Length>
	|
	|-RVA: 0x75BD80 Offset: 0x75A380 VA: 0x18075BD80
	|-PropertyContainer.Accept<object>
	|
	|-RVA: 0x75BB80 Offset: 0x75A180 VA: 0x18075BB80
	|-PropertyContainer.Accept<Rotate>
	|
	|-RVA: 0x75BF70 Offset: 0x75A570 VA: 0x18075BF70
	|-PropertyContainer.Accept<Scale>
	|
	|-RVA: 0x75C170 Offset: 0x75A770 VA: 0x18075C170
	|-PropertyContainer.Accept<float>
	|
	|-RVA: 0x75C970 Offset: 0x75AF70 VA: 0x18075C970
	|-PropertyContainer.Accept<StyleBackground>
	|
	|-RVA: 0x75C370 Offset: 0x75A970 VA: 0x18075C370
	|-PropertyContainer.Accept<StyleBackgroundPosition>
	|
	|-RVA: 0x75C570 Offset: 0x75AB70 VA: 0x18075C570
	|-PropertyContainer.Accept<StyleBackgroundRepeat>
	|
	|-RVA: 0x75C770 Offset: 0x75AD70 VA: 0x18075C770
	|-PropertyContainer.Accept<StyleBackgroundSize>
	|
	|-RVA: 0x777150 Offset: 0x775750 VA: 0x180777150
	|-PropertyContainer.Accept<StyleColor>
	|
	|-RVA: 0x777350 Offset: 0x775950 VA: 0x180777350
	|-PropertyContainer.Accept<StyleCursor>
	|
	|-RVA: 0x777550 Offset: 0x775B50 VA: 0x180777550
	|-PropertyContainer.Accept<StyleFloat>
	|
	|-RVA: 0x777950 Offset: 0x775F50 VA: 0x180777950
	|-PropertyContainer.Accept<StyleFont>
	|
	|-RVA: 0x777750 Offset: 0x775D50 VA: 0x180777750
	|-PropertyContainer.Accept<StyleFontDefinition>
	|
	|-RVA: 0x777B50 Offset: 0x776150 VA: 0x180777B50
	|-PropertyContainer.Accept<StyleInt>
	|
	|-RVA: 0x777D50 Offset: 0x776350 VA: 0x180777D50
	|-PropertyContainer.Accept<StyleLength>
	|
	|-RVA: 0x777F50 Offset: 0x776550 VA: 0x180777F50
	|-PropertyContainer.Accept<StylePropertyName>
	|
	|-RVA: 0x778150 Offset: 0x776750 VA: 0x180778150
	|-PropertyContainer.Accept<StyleRotate>
	|
	|-RVA: 0x778350 Offset: 0x776950 VA: 0x180778350
	|-PropertyContainer.Accept<StyleScale>
	|
	|-RVA: 0x778550 Offset: 0x776B50 VA: 0x180778550
	|-PropertyContainer.Accept<StyleTextShadow>
	|
	|-RVA: 0x778750 Offset: 0x776D50 VA: 0x180778750
	|-PropertyContainer.Accept<StyleTransformOrigin>
	|
	|-RVA: 0x778950 Offset: 0x776F50 VA: 0x180778950
	|-PropertyContainer.Accept<StyleTranslate>
	|
	|-RVA: 0x778B50 Offset: 0x777150 VA: 0x180778B50
	|-PropertyContainer.Accept<TextShadow>
	|
	|-RVA: 0x778D50 Offset: 0x777350 VA: 0x180778D50
	|-PropertyContainer.Accept<TimeValue>
	|
	|-RVA: 0x778F50 Offset: 0x777550 VA: 0x180778F50
	|-PropertyContainer.Accept<TransformOrigin>
	|
	|-RVA: 0x779150 Offset: 0x777750 VA: 0x180779150
	|-PropertyContainer.Accept<Translate>
	|
	|-RVA: 0x779350 Offset: 0x777950 VA: 0x180779350
	|-PropertyContainer.Accept<Vector2>
	|
	|-RVA: 0x779750 Offset: 0x777D50 VA: 0x180779750
	|-PropertyContainer.Accept<Vector3>
	|
	|-RVA: 0x779550 Offset: 0x777B50 VA: 0x180779550
	|-PropertyContainer.Accept<Vector3Int>
	|
	|-RVA: 0x776F00 Offset: 0x775500 VA: 0x180776F00
	|-PropertyContainer.Accept<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryAccept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, VisitParameters parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x783150 Offset: 0x781750 VA: 0x180783150
	|-PropertyContainer.TryAccept<StyleEnum<Int32Enum>>
	|
	|-RVA: 0x7865B0 Offset: 0x784BB0 VA: 0x1807865B0
	|-PropertyContainer.TryAccept<StyleList<EasingFunction>>
	|
	|-RVA: 0x786620 Offset: 0x784C20 VA: 0x180786620
	|-PropertyContainer.TryAccept<StyleList<StylePropertyName>>
	|
	|-RVA: 0x7858E0 Offset: 0x783EE0 VA: 0x1807858E0
	|-PropertyContainer.TryAccept<StyleList<TimeValue>>
	|
	|-RVA: 0x779950 Offset: 0x777F50 VA: 0x180779950
	|-PropertyContainer.TryAccept<Angle>
	|
	|-RVA: 0x77BA00 Offset: 0x77A000 VA: 0x18077BA00
	|-PropertyContainer.TryAccept<Background>
	|
	|-RVA: 0x77A610 Offset: 0x778C10 VA: 0x18077A610
	|-PropertyContainer.TryAccept<BackgroundPosition>
	|
	|-RVA: 0x77A680 Offset: 0x778C80 VA: 0x18077A680
	|-PropertyContainer.TryAccept<BackgroundRepeat>
	|
	|-RVA: 0x77ACF0 Offset: 0x7792F0 VA: 0x18077ACF0
	|-PropertyContainer.TryAccept<BackgroundSize>
	|
	|-RVA: 0x77BA70 Offset: 0x77A070 VA: 0x18077BA70
	|-PropertyContainer.TryAccept<Color>
	|
	|-RVA: 0x77C100 Offset: 0x77A700 VA: 0x18077C100
	|-PropertyContainer.TryAccept<Cursor>
	|
	|-RVA: 0x77C7E0 Offset: 0x77ADE0 VA: 0x18077C7E0
	|-PropertyContainer.TryAccept<EasingFunction>
	|
	|-RVA: 0x77CE50 Offset: 0x77B450 VA: 0x18077CE50
	|-PropertyContainer.TryAccept<FontDefinition>
	|
	|-RVA: 0x77E180 Offset: 0x77C780 VA: 0x18077E180
	|-PropertyContainer.TryAccept<int>
	|
	|-RVA: 0x77DB10 Offset: 0x77C110 VA: 0x18077DB10
	|-PropertyContainer.TryAccept<Int32Enum>
	|
	|-RVA: 0x77E7F0 Offset: 0x77CDF0 VA: 0x18077E7F0
	|-PropertyContainer.TryAccept<Length>
	|
	|-RVA: 0x77FB10 Offset: 0x77E110 VA: 0x18077FB10
	|-PropertyContainer.TryAccept<object>
	|
	|-RVA: 0x77EE60 Offset: 0x77D460 VA: 0x18077EE60
	|-PropertyContainer.TryAccept<Rotate>
	|
	|-RVA: 0x77FB80 Offset: 0x77E180 VA: 0x18077FB80
	|-PropertyContainer.TryAccept<Scale>
	|
	|-RVA: 0x780820 Offset: 0x77EE20 VA: 0x180780820
	|-PropertyContainer.TryAccept<float>
	|
	|-RVA: 0x782360 Offset: 0x780960 VA: 0x180782360
	|-PropertyContainer.TryAccept<StyleBackground>
	|
	|-RVA: 0x780EB0 Offset: 0x77F4B0 VA: 0x180780EB0
	|-PropertyContainer.TryAccept<StyleBackgroundPosition>
	|
	|-RVA: 0x780F20 Offset: 0x77F520 VA: 0x180780F20
	|-PropertyContainer.TryAccept<StyleBackgroundRepeat>
	|
	|-RVA: 0x7815E0 Offset: 0x77FBE0 VA: 0x1807815E0
	|-PropertyContainer.TryAccept<StyleBackgroundSize>
	|
	|-RVA: 0x782A10 Offset: 0x781010 VA: 0x180782A10
	|-PropertyContainer.TryAccept<StyleColor>
	|
	|-RVA: 0x7830E0 Offset: 0x7816E0 VA: 0x1807830E0
	|-PropertyContainer.TryAccept<StyleCursor>
	|
	|-RVA: 0x783DC0 Offset: 0x7823C0 VA: 0x180783DC0
	|-PropertyContainer.TryAccept<StyleFloat>
	|
	|-RVA: 0x784510 Offset: 0x782B10 VA: 0x180784510
	|-PropertyContainer.TryAccept<StyleFont>
	|
	|-RVA: 0x7844A0 Offset: 0x782AA0 VA: 0x1807844A0
	|-PropertyContainer.TryAccept<StyleFontDefinition>
	|
	|-RVA: 0x784BB0 Offset: 0x7831B0 VA: 0x180784BB0
	|-PropertyContainer.TryAccept<StyleInt>
	|
	|-RVA: 0x785220 Offset: 0x783820 VA: 0x180785220
	|-PropertyContainer.TryAccept<StyleLength>
	|
	|-RVA: 0x7872F0 Offset: 0x7858F0 VA: 0x1807872F0
	|-PropertyContainer.TryAccept<StylePropertyName>
	|
	|-RVA: 0x7879E0 Offset: 0x785FE0 VA: 0x1807879E0
	|-PropertyContainer.TryAccept<StyleRotate>
	|
	|-RVA: 0x788090 Offset: 0x786690 VA: 0x180788090
	|-PropertyContainer.TryAccept<StyleScale>
	|
	|-RVA: 0x788100 Offset: 0x786700 VA: 0x180788100
	|-PropertyContainer.TryAccept<StyleTextShadow>
	|
	|-RVA: 0x7887C0 Offset: 0x786DC0 VA: 0x1807887C0
	|-PropertyContainer.TryAccept<StyleTransformOrigin>
	|
	|-RVA: 0x789520 Offset: 0x787B20 VA: 0x180789520
	|-PropertyContainer.TryAccept<StyleTranslate>
	|
	|-RVA: 0x789C10 Offset: 0x788210 VA: 0x180789C10
	|-PropertyContainer.TryAccept<TextShadow>
	|
	|-RVA: 0x789C80 Offset: 0x788280 VA: 0x180789C80
	|-PropertyContainer.TryAccept<TimeValue>
	|
	|-RVA: 0x78A2F0 Offset: 0x7888F0 VA: 0x18078A2F0
	|-PropertyContainer.TryAccept<TransformOrigin>
	|
	|-RVA: 0x78B010 Offset: 0x789610 VA: 0x18078B010
	|-PropertyContainer.TryAccept<Translate>
	|
	|-RVA: 0x78B6C0 Offset: 0x789CC0 VA: 0x18078B6C0
	|-PropertyContainer.TryAccept<Vector2>
	|
	|-RVA: 0x78C440 Offset: 0x78AA40 VA: 0x18078C440
	|-PropertyContainer.TryAccept<Vector3>
	|
	|-RVA: 0x78B730 Offset: 0x789D30 VA: 0x18078B730
	|-PropertyContainer.TryAccept<Vector3Int>
	|
	|-RVA: 0x77D4F0 Offset: 0x77BAF0 VA: 0x18077D4F0
	|-PropertyContainer.TryAccept<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryAccept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, out VisitReturnCode returnCode, VisitParameters parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7831C0 Offset: 0x7817C0 VA: 0x1807831C0
	|-PropertyContainer.TryAccept<StyleEnum<Int32Enum>>
	|
	|-RVA: 0x785F80 Offset: 0x784580 VA: 0x180785F80
	|-PropertyContainer.TryAccept<StyleList<EasingFunction>>
	|
	|-RVA: 0x786690 Offset: 0x784C90 VA: 0x180786690
	|-PropertyContainer.TryAccept<StyleList<StylePropertyName>>
	|
	|-RVA: 0x785950 Offset: 0x783F50 VA: 0x180785950
	|-PropertyContainer.TryAccept<StyleList<TimeValue>>
	|
	|-RVA: 0x7799C0 Offset: 0x777FC0 VA: 0x1807799C0
	|-PropertyContainer.TryAccept<Angle>
	|
	|-RVA: 0x77B3A0 Offset: 0x7799A0 VA: 0x18077B3A0
	|-PropertyContainer.TryAccept<Background>
	|
	|-RVA: 0x779FC0 Offset: 0x7785C0 VA: 0x180779FC0
	|-PropertyContainer.TryAccept<BackgroundPosition>
	|
	|-RVA: 0x77A6F0 Offset: 0x778CF0 VA: 0x18077A6F0
	|-PropertyContainer.TryAccept<BackgroundRepeat>
	|
	|-RVA: 0x77AD60 Offset: 0x779360 VA: 0x18077AD60
	|-PropertyContainer.TryAccept<BackgroundSize>
	|
	|-RVA: 0x77BAE0 Offset: 0x77A0E0 VA: 0x18077BAE0
	|-PropertyContainer.TryAccept<Color>
	|
	|-RVA: 0x77C170 Offset: 0x77A770 VA: 0x18077C170
	|-PropertyContainer.TryAccept<Cursor>
	|
	|-RVA: 0x77C850 Offset: 0x77AE50 VA: 0x18077C850
	|-PropertyContainer.TryAccept<EasingFunction>
	|
	|-RVA: 0x77CEC0 Offset: 0x77B4C0 VA: 0x18077CEC0
	|-PropertyContainer.TryAccept<FontDefinition>
	|
	|-RVA: 0x77E1F0 Offset: 0x77C7F0 VA: 0x18077E1F0
	|-PropertyContainer.TryAccept<int>
	|
	|-RVA: 0x77DB80 Offset: 0x77C180 VA: 0x18077DB80
	|-PropertyContainer.TryAccept<Int32Enum>
	|
	|-RVA: 0x77E860 Offset: 0x77CE60 VA: 0x18077E860
	|-PropertyContainer.TryAccept<Length>
	|
	|-RVA: 0x77F540 Offset: 0x77DB40 VA: 0x18077F540
	|-PropertyContainer.TryAccept<object>
	|
	|-RVA: 0x77EED0 Offset: 0x77D4D0 VA: 0x18077EED0
	|-PropertyContainer.TryAccept<Rotate>
	|
	|-RVA: 0x77FBF0 Offset: 0x77E1F0 VA: 0x18077FBF0
	|-PropertyContainer.TryAccept<Scale>
	|
	|-RVA: 0x780210 Offset: 0x77E810 VA: 0x180780210
	|-PropertyContainer.TryAccept<float>
	|
	|-RVA: 0x781CC0 Offset: 0x7802C0 VA: 0x180781CC0
	|-PropertyContainer.TryAccept<StyleBackground>
	|
	|-RVA: 0x780890 Offset: 0x77EE90 VA: 0x180780890
	|-PropertyContainer.TryAccept<StyleBackgroundPosition>
	|
	|-RVA: 0x780F90 Offset: 0x77F590 VA: 0x180780F90
	|-PropertyContainer.TryAccept<StyleBackgroundRepeat>
	|
	|-RVA: 0x781650 Offset: 0x77FC50 VA: 0x180781650
	|-PropertyContainer.TryAccept<StyleBackgroundSize>
	|
	|-RVA: 0x7823D0 Offset: 0x7809D0 VA: 0x1807823D0
	|-PropertyContainer.TryAccept<StyleColor>
	|
	|-RVA: 0x782A80 Offset: 0x781080 VA: 0x180782A80
	|-PropertyContainer.TryAccept<StyleCursor>
	|
	|-RVA: 0x7837C0 Offset: 0x781DC0 VA: 0x1807837C0
	|-PropertyContainer.TryAccept<StyleFloat>
	|
	|-RVA: 0x784580 Offset: 0x782B80 VA: 0x180784580
	|-PropertyContainer.TryAccept<StyleFont>
	|
	|-RVA: 0x783E30 Offset: 0x782430 VA: 0x180783E30
	|-PropertyContainer.TryAccept<StyleFontDefinition>
	|
	|-RVA: 0x784C20 Offset: 0x783220 VA: 0x180784C20
	|-PropertyContainer.TryAccept<StyleInt>
	|
	|-RVA: 0x785290 Offset: 0x783890 VA: 0x180785290
	|-PropertyContainer.TryAccept<StyleLength>
	|
	|-RVA: 0x786CC0 Offset: 0x7852C0 VA: 0x180786CC0
	|-PropertyContainer.TryAccept<StylePropertyName>
	|
	|-RVA: 0x787360 Offset: 0x785960 VA: 0x180787360
	|-PropertyContainer.TryAccept<StyleRotate>
	|
	|-RVA: 0x787A50 Offset: 0x786050 VA: 0x180787A50
	|-PropertyContainer.TryAccept<StyleScale>
	|
	|-RVA: 0x788170 Offset: 0x786770 VA: 0x180788170
	|-PropertyContainer.TryAccept<StyleTextShadow>
	|
	|-RVA: 0x788830 Offset: 0x786E30 VA: 0x180788830
	|-PropertyContainer.TryAccept<StyleTransformOrigin>
	|
	|-RVA: 0x788EA0 Offset: 0x7874A0 VA: 0x180788EA0
	|-PropertyContainer.TryAccept<StyleTranslate>
	|
	|-RVA: 0x789590 Offset: 0x787B90 VA: 0x180789590
	|-PropertyContainer.TryAccept<TextShadow>
	|
	|-RVA: 0x789CF0 Offset: 0x7882F0 VA: 0x180789CF0
	|-PropertyContainer.TryAccept<TimeValue>
	|
	|-RVA: 0x78A360 Offset: 0x788960 VA: 0x18078A360
	|-PropertyContainer.TryAccept<TransformOrigin>
	|
	|-RVA: 0x78A9A0 Offset: 0x788FA0 VA: 0x18078A9A0
	|-PropertyContainer.TryAccept<Translate>
	|
	|-RVA: 0x78B080 Offset: 0x789680 VA: 0x18078B080
	|-PropertyContainer.TryAccept<Vector2>
	|
	|-RVA: 0x78BDF0 Offset: 0x78A3F0 VA: 0x18078BDF0
	|-PropertyContainer.TryAccept<Vector3>
	|
	|-RVA: 0x78B7A0 Offset: 0x789DA0 VA: 0x18078B7A0
	|-PropertyContainer.TryAccept<Vector3Int>
	|
	|-RVA: 0x77D560 Offset: 0x77BB60 VA: 0x18077D560
	|-PropertyContainer.TryAccept<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetProperty<TContainer>(ref TContainer container, in PropertyPath path, out IProperty property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78CB00 Offset: 0x78B100 VA: 0x18078CB00
	|-PropertyContainer.TryGetProperty<object>
	|
	|-RVA: 0x78C7A0 Offset: 0x78ADA0 VA: 0x18078C7A0
	|-PropertyContainer.TryGetProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetProperty<TContainer>(ref TContainer container, in PropertyPath path, out IProperty property, out VisitReturnCode returnCode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78C810 Offset: 0x78AE10 VA: 0x18078C810
	|-PropertyContainer.TryGetProperty<object>
	|
	|-RVA: 0x78C4B0 Offset: 0x78AAB0 VA: 0x18078C4B0
	|-PropertyContainer.TryGetProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetValue<TContainer, TValue>(ref TContainer container, string name, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78D1F0 Offset: 0x78B7F0 VA: 0x18078D1F0
	|-PropertyContainer.TryGetValue<object, object>
	|
	|-RVA: 0x78CEA0 Offset: 0x78B4A0 VA: 0x18078CEA0
	|-PropertyContainer.TryGetValue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetValue<TContainer, TValue>(ref TContainer container, in PropertyPath path, out TValue value, out VisitReturnCode returnCode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x78CF70 Offset: 0x78B570 VA: 0x18078CF70
	|-PropertyContainer.TryGetValue<object, object>
	|
	|-RVA: 0x78CB70 Offset: 0x78B170 VA: 0x18078CB70
	|-PropertyContainer.TryGetValue<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public enum VisitReturnCode // TypeDefIndex: 12913
{
	// Fields
	public int value__; // 0x0
	public const VisitReturnCode Ok = 0;
	public const VisitReturnCode NullContainer = 1;
	public const VisitReturnCode InvalidContainerType = 2;
	public const VisitReturnCode MissingPropertyBag = 3;
	public const VisitReturnCode InvalidPath = 4;
	public const VisitReturnCode InvalidCast = 5;
	public const VisitReturnCode AccessViolation = 6;
}

// Namespace: Unity.Properties
[Usage(384)]
public class CreatePropertyAttribute : RequiredMemberAttribute // TypeDefIndex: 12914
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ReadOnly>k__BackingField; // 0x10

	// Properties
	public bool ReadOnly { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_ReadOnly() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	public void set_ReadOnly(bool value) { }

	// RVA: 0x23BBF00 Offset: 0x23BA500 VA: 0x1823BBF00
	public void .ctor() { }
}

// Namespace: Unity.Properties
[Usage(256)]
public class DontCreatePropertyAttribute : Attribute // TypeDefIndex: 12915
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Unity.Properties
[Flags]
public enum TypeGenerationOptions // TypeDefIndex: 12916
{
	// Fields
	public int value__; // 0x0
	public const TypeGenerationOptions None = 0;
	public const TypeGenerationOptions ValueType = 2;
	public const TypeGenerationOptions ReferenceType = 4;
	public const TypeGenerationOptions Default = 6;
}

// Namespace: Unity.Properties
[Usage(1, AllowMultiple = True)]
public class GeneratePropertyBagsForTypesQualifiedWithAttribute : Attribute // TypeDefIndex: 12917
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly TypeGenerationOptions <Options>k__BackingField; // 0x18

	// Methods

	// RVA: 0x23BC130 Offset: 0x23BA730 VA: 0x1823BC130
	public void .ctor(Type type, TypeGenerationOptions options = 6) { }
}

// Namespace: Unity.Properties
[Serializable]
public class MissingPropertyBagException : Exception // TypeDefIndex: 12918
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x90

	// Methods

	// RVA: 0x23BC7A0 Offset: 0x23BADA0 VA: 0x1823BC7A0
	public void .ctor(Type type) { }

	// RVA: 0x23BC730 Offset: 0x23BAD30 VA: 0x1823BC730
	private static string GetMessageForType(Type type) { }
}

// Namespace: Unity.Properties
[IsReadOnly]
public struct AttributesScope : IDisposable // TypeDefIndex: 12919
{
	// Fields
	private readonly IAttributes m_Target; // 0x0
	private readonly List<Attribute> m_Previous; // 0x8

	// Methods

	// RVA: 0x23BB2D0 Offset: 0x23B98D0 VA: 0x1823BB2D0
	public void .ctor(IProperty target, IProperty source) { }

	// RVA: 0x23BB230 Offset: 0x23B9830 VA: 0x1823BB230
	internal void .ctor(IAttributes target, List<Attribute> attributes) { }

	// RVA: 0x23BB1E0 Offset: 0x23B97E0 VA: 0x1823BB1E0 Slot: 4
	public void Dispose() { }
}

// Namespace: Unity.Properties
public sealed class PropertyGetter<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 12920
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B6560 Offset: 0x8B4B60 VA: 0x1808B6560
	|-PropertyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TValue Invoke(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0
	|-PropertyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public sealed class PropertySetter<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 12921
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B6630 Offset: 0x8B4C30 VA: 0x1808B6630
	|-PropertySetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(ref TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0
	|-PropertySetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public class DelegateProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 12922
{
	// Fields
	private readonly PropertyGetter<TContainer, TValue> m_Getter; // 0x0
	private readonly PropertySetter<TContainer, TValue> m_Setter; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <Name>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }
	public override bool IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 12
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD39DE0 Offset: 0xD383E0 VA: 0x180D39DE0
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name, PropertyGetter<TContainer, TValue> getter, PropertySetter<TContainer, TValue> setter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD39D10 Offset: 0xD38310 VA: 0x180D39D10
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TValue GetValue(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD39A90 Offset: 0xD38090 VA: 0x180D39A90
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override void SetValue(ref TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD39BB0 Offset: 0xD381B0 VA: 0x180D39BB0
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetValue
	*/
}

// Namespace: Unity.Properties
public interface IListElementProperty // TypeDefIndex: 12923
{
	// Properties
	public abstract int Index { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Index();
}

// Namespace: Unity.Properties
public interface ISetElementProperty // TypeDefIndex: 12924
{
	// Properties
	public abstract object ObjectKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_ObjectKey();
}

// Namespace: Unity.Properties
public interface IDictionaryElementProperty // TypeDefIndex: 12925
{
	// Properties
	public abstract object ObjectKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_ObjectKey();
}

// Namespace: Unity.Properties
public interface IProperty // TypeDefIndex: 12926
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type DeclaredValueType();
}

// Namespace: Unity.Properties
public interface IProperty<TContainer> : IProperty, IPropertyAccept<TContainer> // TypeDefIndex: 12927
{}

// Namespace: Unity.Properties
public abstract class Property<TContainer, TValue> : IProperty<TContainer>, IProperty, IPropertyAccept<TContainer>, IAttributes // TypeDefIndex: 12928
{
	// Fields
	private List<Attribute> m_Attributes; // 0x0

	// Properties
	private List<Attribute> Unity.Properties.Internal.IAttributes.Attributes { get; set; }
	public abstract string Name { get; }
	public abstract bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	private List<Attribute> Unity.Properties.Internal.IAttributes.get_Attributes() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	|-Property<StyleEnum<Int32Enum>, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleList<EasingFunction>, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleList<EasingFunction>, object>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleList<StylePropertyName>, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleList<StylePropertyName>, object>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleList<TimeValue>, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleList<TimeValue>, object>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Angle, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Angle, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Background, object>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<BackgroundPosition, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<BackgroundPosition, Length>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<BackgroundRepeat, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<BackgroundSize, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<BackgroundSize, Length>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Cursor, int>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Cursor, object>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Cursor, Vector2>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<EasingFunction, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<FontDefinition, object>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Length, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Length, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleEnum<Int32Enum>>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleList<EasingFunction>>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleList<StylePropertyName>>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleList<TimeValue>>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, Background>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, BackgroundPosition>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, BackgroundRepeat>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, BackgroundSize>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, Color>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, EasingFunction>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, FontDefinition>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, object>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, Rotate>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, Scale>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleBackground>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleBackgroundPosition>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleBackgroundRepeat>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleBackgroundSize>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleColor>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleCursor>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleFloat>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleFont>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleFontDefinition>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleInt>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleLength>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StylePropertyName>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleRotate>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleScale>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleTextShadow>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleTransformOrigin>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, StyleTranslate>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, TimeValue>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<object, Vector3>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Rotate, Angle>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Rotate, Vector3>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Scale, Vector3>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleBackground, Background>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleBackground, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleBackgroundPosition, BackgroundPosition>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleBackgroundPosition, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleBackgroundRepeat, BackgroundRepeat>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleBackgroundRepeat, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleBackgroundSize, BackgroundSize>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleBackgroundSize, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleColor, Color>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleColor, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleCursor, Cursor>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleCursor, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleFloat, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleFloat, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleFont, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleFont, object>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleFontDefinition, FontDefinition>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleFontDefinition, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleInt, int>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleInt, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleLength, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleLength, Length>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StylePropertyName, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StylePropertyName, object>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleRotate, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleRotate, Rotate>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleScale, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleScale, Scale>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleTextShadow, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleTextShadow, TextShadow>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleTransformOrigin, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleTransformOrigin, TransformOrigin>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleTranslate, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<StyleTranslate, Translate>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<TextShadow, Color>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<TextShadow, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<TextShadow, Vector2>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<TimeValue, Int32Enum>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<TimeValue, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<TransformOrigin, Length>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<TransformOrigin, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Translate, Length>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Translate, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.get_Attributes
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.get_Attributes
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void Unity.Properties.Internal.IAttributes.set_Attributes(List<Attribute> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	|-Property<StyleEnum<Int32Enum>, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleList<EasingFunction>, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleList<EasingFunction>, object>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleList<StylePropertyName>, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleList<StylePropertyName>, object>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleList<TimeValue>, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleList<TimeValue>, object>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Angle, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Angle, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Background, object>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<BackgroundPosition, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<BackgroundPosition, Length>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<BackgroundRepeat, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<BackgroundSize, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<BackgroundSize, Length>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Cursor, int>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Cursor, object>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Cursor, Vector2>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<EasingFunction, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<FontDefinition, object>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Length, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Length, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleEnum<Int32Enum>>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleList<EasingFunction>>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleList<StylePropertyName>>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleList<TimeValue>>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, Background>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, BackgroundPosition>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, BackgroundRepeat>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, BackgroundSize>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, Color>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, EasingFunction>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, FontDefinition>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, object>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, Rotate>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, Scale>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleBackground>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleBackgroundPosition>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleBackgroundRepeat>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleBackgroundSize>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleColor>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleCursor>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleFloat>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleFont>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleFontDefinition>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleInt>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleLength>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StylePropertyName>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleRotate>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleScale>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleTextShadow>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleTransformOrigin>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, StyleTranslate>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, TimeValue>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<object, Vector3>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Rotate, Angle>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Rotate, Vector3>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Scale, Vector3>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleBackground, Background>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleBackground, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleBackgroundPosition, BackgroundPosition>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleBackgroundPosition, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleBackgroundRepeat, BackgroundRepeat>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleBackgroundRepeat, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleBackgroundSize, BackgroundSize>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleBackgroundSize, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleColor, Color>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleColor, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleCursor, Cursor>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleCursor, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleFloat, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleFloat, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleFont, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleFont, object>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleFontDefinition, FontDefinition>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleFontDefinition, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleInt, int>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleInt, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleLength, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleLength, Length>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StylePropertyName, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StylePropertyName, object>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleRotate, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleRotate, Rotate>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleScale, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleScale, Scale>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleTextShadow, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleTextShadow, TextShadow>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleTransformOrigin, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleTransformOrigin, TransformOrigin>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleTranslate, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<StyleTranslate, Translate>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<TextShadow, Color>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<TextShadow, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<TextShadow, Vector2>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<TimeValue, Int32Enum>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<TimeValue, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<TransformOrigin, Length>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<TransformOrigin, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Translate, Length>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Translate, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.set_Attributes
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.set_Attributes
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_Name();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_IsReadOnly();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public Type DeclaredValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B8C70 Offset: 0x8B7270 VA: 0x1808B8C70
	|-Property<StyleEnum<Int32Enum>, Int32Enum>.DeclaredValueType
	|-Property<StyleList<EasingFunction>, Int32Enum>.DeclaredValueType
	|-Property<StyleList<EasingFunction>, object>.DeclaredValueType
	|-Property<StyleList<StylePropertyName>, Int32Enum>.DeclaredValueType
	|-Property<StyleList<StylePropertyName>, object>.DeclaredValueType
	|-Property<StyleList<TimeValue>, Int32Enum>.DeclaredValueType
	|-Property<StyleList<TimeValue>, object>.DeclaredValueType
	|-Property<Angle, Int32Enum>.DeclaredValueType
	|-Property<Angle, float>.DeclaredValueType
	|-Property<Background, object>.DeclaredValueType
	|-Property<BackgroundPosition, Int32Enum>.DeclaredValueType
	|-Property<BackgroundPosition, Length>.DeclaredValueType
	|-Property<BackgroundRepeat, Int32Enum>.DeclaredValueType
	|-Property<BackgroundSize, Int32Enum>.DeclaredValueType
	|-Property<BackgroundSize, Length>.DeclaredValueType
	|-Property<Bounds, Vector3>.DeclaredValueType
	|-Property<BoundsInt, Vector3Int>.DeclaredValueType
	|-Property<Color, float>.DeclaredValueType
	|-Property<Cursor, int>.DeclaredValueType
	|-Property<Cursor, object>.DeclaredValueType
	|-Property<Cursor, Vector2>.DeclaredValueType
	|-Property<EasingFunction, Int32Enum>.DeclaredValueType
	|-Property<FontDefinition, object>.DeclaredValueType
	|-Property<Length, Int32Enum>.DeclaredValueType
	|-Property<Length, float>.DeclaredValueType
	|-Property<object, StyleEnum<Int32Enum>>.DeclaredValueType
	|-Property<object, StyleList<EasingFunction>>.DeclaredValueType
	|-Property<object, StyleList<StylePropertyName>>.DeclaredValueType
	|-Property<object, StyleList<TimeValue>>.DeclaredValueType
	|-Property<object, Background>.DeclaredValueType
	|-Property<object, BackgroundPosition>.DeclaredValueType
	|-Property<object, BackgroundRepeat>.DeclaredValueType
	|-Property<object, BackgroundSize>.DeclaredValueType
	|-Property<object, Color>.DeclaredValueType
	|-Property<object, EasingFunction>.DeclaredValueType
	|-Property<object, FontDefinition>.DeclaredValueType
	|-Property<object, int>.DeclaredValueType
	|-Property<object, Int32Enum>.DeclaredValueType
	|-Property<object, object>.DeclaredValueType
	|-Property<object, Rotate>.DeclaredValueType
	|-Property<object, Scale>.DeclaredValueType
	|-Property<object, float>.DeclaredValueType
	|-Property<object, StyleBackground>.DeclaredValueType
	|-Property<object, StyleBackgroundPosition>.DeclaredValueType
	|-Property<object, StyleBackgroundRepeat>.DeclaredValueType
	|-Property<object, StyleBackgroundSize>.DeclaredValueType
	|-Property<object, StyleColor>.DeclaredValueType
	|-Property<object, StyleCursor>.DeclaredValueType
	|-Property<object, StyleFloat>.DeclaredValueType
	|-Property<object, StyleFont>.DeclaredValueType
	|-Property<object, StyleFontDefinition>.DeclaredValueType
	|-Property<object, StyleInt>.DeclaredValueType
	|-Property<object, StyleLength>.DeclaredValueType
	|-Property<object, StylePropertyName>.DeclaredValueType
	|-Property<object, StyleRotate>.DeclaredValueType
	|-Property<object, StyleScale>.DeclaredValueType
	|-Property<object, StyleTextShadow>.DeclaredValueType
	|-Property<object, StyleTransformOrigin>.DeclaredValueType
	|-Property<object, StyleTranslate>.DeclaredValueType
	|-Property<object, TimeValue>.DeclaredValueType
	|-Property<object, Vector3>.DeclaredValueType
	|-Property<Rect, float>.DeclaredValueType
	|-Property<RectInt, int>.DeclaredValueType
	|-Property<Rotate, Angle>.DeclaredValueType
	|-Property<Rotate, Vector3>.DeclaredValueType
	|-Property<Scale, Vector3>.DeclaredValueType
	|-Property<StyleBackground, Background>.DeclaredValueType
	|-Property<StyleBackground, Int32Enum>.DeclaredValueType
	|-Property<StyleBackgroundPosition, BackgroundPosition>.DeclaredValueType
	|-Property<StyleBackgroundPosition, Int32Enum>.DeclaredValueType
	|-Property<StyleBackgroundRepeat, BackgroundRepeat>.DeclaredValueType
	|-Property<StyleBackgroundRepeat, Int32Enum>.DeclaredValueType
	|-Property<StyleBackgroundSize, BackgroundSize>.DeclaredValueType
	|-Property<StyleBackgroundSize, Int32Enum>.DeclaredValueType
	|-Property<StyleColor, Color>.DeclaredValueType
	|-Property<StyleColor, Int32Enum>.DeclaredValueType
	|-Property<StyleCursor, Cursor>.DeclaredValueType
	|-Property<StyleCursor, Int32Enum>.DeclaredValueType
	|-Property<StyleFloat, Int32Enum>.DeclaredValueType
	|-Property<StyleFloat, float>.DeclaredValueType
	|-Property<StyleFont, Int32Enum>.DeclaredValueType
	|-Property<StyleFont, object>.DeclaredValueType
	|-Property<StyleFontDefinition, FontDefinition>.DeclaredValueType
	|-Property<StyleFontDefinition, Int32Enum>.DeclaredValueType
	|-Property<StyleInt, int>.DeclaredValueType
	|-Property<StyleInt, Int32Enum>.DeclaredValueType
	|-Property<StyleLength, Int32Enum>.DeclaredValueType
	|-Property<StyleLength, Length>.DeclaredValueType
	|-Property<StylePropertyName, Int32Enum>.DeclaredValueType
	|-Property<StylePropertyName, object>.DeclaredValueType
	|-Property<StyleRotate, Int32Enum>.DeclaredValueType
	|-Property<StyleRotate, Rotate>.DeclaredValueType
	|-Property<StyleScale, Int32Enum>.DeclaredValueType
	|-Property<StyleScale, Scale>.DeclaredValueType
	|-Property<StyleTextShadow, Int32Enum>.DeclaredValueType
	|-Property<StyleTextShadow, TextShadow>.DeclaredValueType
	|-Property<StyleTransformOrigin, Int32Enum>.DeclaredValueType
	|-Property<StyleTransformOrigin, TransformOrigin>.DeclaredValueType
	|-Property<StyleTranslate, Int32Enum>.DeclaredValueType
	|-Property<StyleTranslate, Translate>.DeclaredValueType
	|-Property<TextShadow, Color>.DeclaredValueType
	|-Property<TextShadow, float>.DeclaredValueType
	|-Property<TextShadow, Vector2>.DeclaredValueType
	|-Property<TimeValue, Int32Enum>.DeclaredValueType
	|-Property<TimeValue, float>.DeclaredValueType
	|-Property<TransformOrigin, Length>.DeclaredValueType
	|-Property<TransformOrigin, float>.DeclaredValueType
	|-Property<Translate, Length>.DeclaredValueType
	|-Property<Translate, float>.DeclaredValueType
	|-Property<Vector2, float>.DeclaredValueType
	|-Property<Vector2Int, int>.DeclaredValueType
	|-Property<Vector3, float>.DeclaredValueType
	|-Property<Vector3Int, int>.DeclaredValueType
	|-Property<Vector4, float>.DeclaredValueType
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeclaredValueType
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Accept(IPropertyVisitor visitor, ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B69D0 Offset: 0x8B4FD0 VA: 0x1808B69D0
	|-Property<StyleEnum<Int32Enum>, Int32Enum>.Accept
	|-Property<StyleList<EasingFunction>, Int32Enum>.Accept
	|-Property<StyleList<EasingFunction>, object>.Accept
	|-Property<StyleList<StylePropertyName>, Int32Enum>.Accept
	|-Property<StyleList<StylePropertyName>, object>.Accept
	|-Property<StyleList<TimeValue>, Int32Enum>.Accept
	|-Property<StyleList<TimeValue>, object>.Accept
	|-Property<Angle, Int32Enum>.Accept
	|-Property<Angle, float>.Accept
	|-Property<Background, object>.Accept
	|-Property<BackgroundPosition, Int32Enum>.Accept
	|-Property<BackgroundPosition, Length>.Accept
	|-Property<BackgroundRepeat, Int32Enum>.Accept
	|-Property<BackgroundSize, Int32Enum>.Accept
	|-Property<BackgroundSize, Length>.Accept
	|-Property<Bounds, Vector3>.Accept
	|-Property<BoundsInt, Vector3Int>.Accept
	|-Property<Color, float>.Accept
	|-Property<Cursor, int>.Accept
	|-Property<Cursor, object>.Accept
	|-Property<Cursor, Vector2>.Accept
	|-Property<EasingFunction, Int32Enum>.Accept
	|-Property<FontDefinition, object>.Accept
	|-Property<Length, Int32Enum>.Accept
	|-Property<Length, float>.Accept
	|-Property<object, StyleEnum<Int32Enum>>.Accept
	|-Property<object, StyleList<EasingFunction>>.Accept
	|-Property<object, StyleList<StylePropertyName>>.Accept
	|-Property<object, StyleList<TimeValue>>.Accept
	|-Property<object, Background>.Accept
	|-Property<object, BackgroundPosition>.Accept
	|-Property<object, BackgroundRepeat>.Accept
	|-Property<object, BackgroundSize>.Accept
	|-Property<object, Color>.Accept
	|-Property<object, EasingFunction>.Accept
	|-Property<object, FontDefinition>.Accept
	|-Property<object, int>.Accept
	|-Property<object, Int32Enum>.Accept
	|-Property<object, object>.Accept
	|-Property<object, Rotate>.Accept
	|-Property<object, Scale>.Accept
	|-Property<object, float>.Accept
	|-Property<object, StyleBackground>.Accept
	|-Property<object, StyleBackgroundPosition>.Accept
	|-Property<object, StyleBackgroundRepeat>.Accept
	|-Property<object, StyleBackgroundSize>.Accept
	|-Property<object, StyleColor>.Accept
	|-Property<object, StyleCursor>.Accept
	|-Property<object, StyleFloat>.Accept
	|-Property<object, StyleFont>.Accept
	|-Property<object, StyleFontDefinition>.Accept
	|-Property<object, StyleInt>.Accept
	|-Property<object, StyleLength>.Accept
	|-Property<object, StylePropertyName>.Accept
	|-Property<object, StyleRotate>.Accept
	|-Property<object, StyleScale>.Accept
	|-Property<object, StyleTextShadow>.Accept
	|-Property<object, StyleTransformOrigin>.Accept
	|-Property<object, StyleTranslate>.Accept
	|-Property<object, TimeValue>.Accept
	|-Property<object, Vector3>.Accept
	|-Property<Rect, float>.Accept
	|-Property<RectInt, int>.Accept
	|-Property<Rotate, Angle>.Accept
	|-Property<Rotate, Vector3>.Accept
	|-Property<Scale, Vector3>.Accept
	|-Property<StyleBackground, Background>.Accept
	|-Property<StyleBackground, Int32Enum>.Accept
	|-Property<StyleBackgroundPosition, BackgroundPosition>.Accept
	|-Property<StyleBackgroundPosition, Int32Enum>.Accept
	|-Property<StyleBackgroundRepeat, BackgroundRepeat>.Accept
	|-Property<StyleBackgroundRepeat, Int32Enum>.Accept
	|-Property<StyleBackgroundSize, BackgroundSize>.Accept
	|-Property<StyleBackgroundSize, Int32Enum>.Accept
	|-Property<StyleColor, Color>.Accept
	|-Property<StyleColor, Int32Enum>.Accept
	|-Property<StyleCursor, Cursor>.Accept
	|-Property<StyleCursor, Int32Enum>.Accept
	|-Property<StyleFloat, Int32Enum>.Accept
	|-Property<StyleFloat, float>.Accept
	|-Property<StyleFont, Int32Enum>.Accept
	|-Property<StyleFont, object>.Accept
	|-Property<StyleFontDefinition, FontDefinition>.Accept
	|-Property<StyleFontDefinition, Int32Enum>.Accept
	|-Property<StyleInt, int>.Accept
	|-Property<StyleInt, Int32Enum>.Accept
	|-Property<StyleLength, Int32Enum>.Accept
	|-Property<StyleLength, Length>.Accept
	|-Property<StylePropertyName, Int32Enum>.Accept
	|-Property<StylePropertyName, object>.Accept
	|-Property<StyleRotate, Int32Enum>.Accept
	|-Property<StyleRotate, Rotate>.Accept
	|-Property<StyleScale, Int32Enum>.Accept
	|-Property<StyleScale, Scale>.Accept
	|-Property<StyleTextShadow, Int32Enum>.Accept
	|-Property<StyleTextShadow, TextShadow>.Accept
	|-Property<StyleTransformOrigin, Int32Enum>.Accept
	|-Property<StyleTransformOrigin, TransformOrigin>.Accept
	|-Property<StyleTranslate, Int32Enum>.Accept
	|-Property<StyleTranslate, Translate>.Accept
	|-Property<TextShadow, Color>.Accept
	|-Property<TextShadow, float>.Accept
	|-Property<TextShadow, Vector2>.Accept
	|-Property<TimeValue, Int32Enum>.Accept
	|-Property<TimeValue, float>.Accept
	|-Property<TransformOrigin, Length>.Accept
	|-Property<TransformOrigin, float>.Accept
	|-Property<Translate, Length>.Accept
	|-Property<Translate, float>.Accept
	|-Property<Vector2, float>.Accept
	|-Property<Vector2Int, int>.Accept
	|-Property<Vector3, float>.Accept
	|-Property<Vector3Int, int>.Accept
	|-Property<Vector4, float>.Accept
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract TValue GetValue(ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void SetValue(ref TContainer container, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetValue
	*/

	// RVA: -1 Offset: -1
	protected void AddAttribute(Attribute attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B7890 Offset: 0x8B5E90 VA: 0x1808B7890
	|-Property<StyleEnum<Int32Enum>, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B6CF0 Offset: 0x8B52F0 VA: 0x1808B6CF0
	|-Property<StyleList<EasingFunction>, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B71D0 Offset: 0x8B57D0 VA: 0x1808B71D0
	|-Property<StyleList<EasingFunction>, object>.AddAttribute
	|
	|-RVA: 0x8B6B10 Offset: 0x8B5110 VA: 0x1808B6B10
	|-Property<StyleList<StylePropertyName>, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B7470 Offset: 0x8B5A70 VA: 0x1808B7470
	|-Property<StyleList<StylePropertyName>, object>.AddAttribute
	|
	|-RVA: 0x8B6C30 Offset: 0x8B5230 VA: 0x1808B6C30
	|-Property<StyleList<TimeValue>, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B77D0 Offset: 0x8B5DD0 VA: 0x1808B77D0
	|-Property<StyleList<TimeValue>, object>.AddAttribute
	|
	|-RVA: 0x8B78F0 Offset: 0x8B5EF0 VA: 0x1808B78F0
	|-Property<Angle, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B6D50 Offset: 0x8B5350 VA: 0x1808B6D50
	|-Property<Angle, float>.AddAttribute
	|
	|-RVA: 0x8B7770 Offset: 0x8B5D70 VA: 0x1808B7770
	|-Property<Background, object>.AddAttribute
	|
	|-RVA: 0x8B6ED0 Offset: 0x8B54D0 VA: 0x1808B6ED0
	|-Property<BackgroundPosition, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B79B0 Offset: 0x8B5FB0 VA: 0x1808B79B0
	|-Property<BackgroundPosition, Length>.AddAttribute
	|
	|-RVA: 0x8B7290 Offset: 0x8B5890 VA: 0x1808B7290
	|-Property<BackgroundRepeat, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B7710 Offset: 0x8B5D10 VA: 0x1808B7710
	|-Property<BackgroundSize, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B6BD0 Offset: 0x8B51D0 VA: 0x1808B6BD0
	|-Property<BackgroundSize, Length>.AddAttribute
	|
	|-RVA: 0x8B6AB0 Offset: 0x8B50B0 VA: 0x1808B6AB0
	|-Property<Bounds, Vector3>.AddAttribute
	|
	|-RVA: 0x8B7410 Offset: 0x8B5A10 VA: 0x1808B7410
	|-Property<BoundsInt, Vector3Int>.AddAttribute
	|
	|-RVA: 0x8B6DB0 Offset: 0x8B53B0 VA: 0x1808B6DB0
	|-Property<Color, float>.AddAttribute
	|
	|-RVA: 0x8B7530 Offset: 0x8B5B30 VA: 0x1808B7530
	|-Property<Cursor, int>.AddAttribute
	|
	|-RVA: 0x8B6E10 Offset: 0x8B5410 VA: 0x1808B6E10
	|-Property<Cursor, object>.AddAttribute
	|
	|-RVA: 0x8B6FF0 Offset: 0x8B55F0 VA: 0x1808B6FF0
	|-Property<Cursor, Vector2>.AddAttribute
	|
	|-RVA: 0x8B7B30 Offset: 0x8B6130 VA: 0x1808B7B30
	|-Property<EasingFunction, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B6C90 Offset: 0x8B5290 VA: 0x1808B6C90
	|-Property<FontDefinition, object>.AddAttribute
	|
	|-RVA: 0x8B6B70 Offset: 0x8B5170 VA: 0x1808B6B70
	|-Property<Length, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B7350 Offset: 0x8B5950 VA: 0x1808B7350
	|-Property<Length, float>.AddAttribute
	|
	|-RVA: 0x8B7950 Offset: 0x8B5F50 VA: 0x1808B7950
	|-Property<object, StyleEnum<Int32Enum>>.AddAttribute
	|
	|-RVA: 0x8B6F30 Offset: 0x8B5530 VA: 0x1808B6F30
	|-Property<object, StyleList<EasingFunction>>.AddAttribute
	|
	|-RVA: 0x8B74D0 Offset: 0x8B5AD0 VA: 0x1808B74D0
	|-Property<object, StyleList<StylePropertyName>>.AddAttribute
	|
	|-RVA: 0x8B7050 Offset: 0x8B5650 VA: 0x1808B7050
	|-Property<object, StyleList<TimeValue>>.AddAttribute
	|
	|-RVA: 0x8B76B0 Offset: 0x8B5CB0 VA: 0x1808B76B0
	|-Property<object, Background>.AddAttribute
	|
	|-RVA: 0x8B70B0 Offset: 0x8B56B0 VA: 0x1808B70B0
	|-Property<object, BackgroundPosition>.AddAttribute
	|
	|-RVA: 0x8B7110 Offset: 0x8B5710 VA: 0x1808B7110
	|-Property<object, BackgroundRepeat>.AddAttribute
	|
	|-RVA: 0x8B7590 Offset: 0x8B5B90 VA: 0x1808B7590
	|-Property<object, BackgroundSize>.AddAttribute
	|
	|-RVA: 0x8B7830 Offset: 0x8B5E30 VA: 0x1808B7830
	|-Property<object, Color>.AddAttribute
	|
	|-RVA: 0x8B7A70 Offset: 0x8B6070 VA: 0x1808B7A70
	|-Property<object, EasingFunction>.AddAttribute
	|
	|-RVA: 0x8B6E70 Offset: 0x8B5470 VA: 0x1808B6E70
	|-Property<object, FontDefinition>.AddAttribute
	|
	|-RVA: 0x8B7230 Offset: 0x8B5830 VA: 0x1808B7230
	|-Property<object, int>.AddAttribute
	|
	|-RVA: 0x8B7AD0 Offset: 0x8B60D0 VA: 0x1808B7AD0
	|-Property<object, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8B7A10 Offset: 0x8B6010 VA: 0x1808B7A10
	|-Property<object, object>.AddAttribute
	|
	|-RVA: 0x8B7170 Offset: 0x8B5770 VA: 0x1808B7170
	|-Property<object, Rotate>.AddAttribute
	|
	|-RVA: 0x8B73B0 Offset: 0x8B59B0 VA: 0x1808B73B0
	|-Property<object, Scale>.AddAttribute
	|
	|-RVA: 0x8B7650 Offset: 0x8B5C50 VA: 0x1808B7650
	|-Property<object, float>.AddAttribute
	|
	|-RVA: 0x8B72F0 Offset: 0x8B58F0 VA: 0x1808B72F0
	|-Property<object, StyleBackground>.AddAttribute
	|
	|-RVA: 0x8B75F0 Offset: 0x8B5BF0 VA: 0x1808B75F0
	|-Property<object, StyleBackgroundPosition>.AddAttribute
	|
	|-RVA: 0x8B6F90 Offset: 0x8B5590 VA: 0x1808B6F90
	|-Property<object, StyleBackgroundRepeat>.AddAttribute
	|
	|-RVA: 0x8C4430 Offset: 0x8C2A30 VA: 0x1808C4430
	|-Property<object, StyleBackgroundSize>.AddAttribute
	|
	|-RVA: 0x8C5150 Offset: 0x8C3750 VA: 0x1808C5150
	|-Property<object, StyleColor>.AddAttribute
	|
	|-RVA: 0x8C3EF0 Offset: 0x8C24F0 VA: 0x1808C3EF0
	|-Property<object, StyleCursor>.AddAttribute
	|
	|-RVA: 0x8C47F0 Offset: 0x8C2DF0 VA: 0x1808C47F0
	|-Property<object, StyleFloat>.AddAttribute
	|
	|-RVA: 0x8C40D0 Offset: 0x8C26D0 VA: 0x1808C40D0
	|-Property<object, StyleFont>.AddAttribute
	|
	|-RVA: 0x8C3BF0 Offset: 0x8C21F0 VA: 0x1808C3BF0
	|-Property<object, StyleFontDefinition>.AddAttribute
	|
	|-RVA: 0x8C3C50 Offset: 0x8C2250 VA: 0x1808C3C50
	|-Property<object, StyleInt>.AddAttribute
	|
	|-RVA: 0x8C5270 Offset: 0x8C3870 VA: 0x1808C5270
	|-Property<object, StyleLength>.AddAttribute
	|
	|-RVA: 0x8C3B30 Offset: 0x8C2130 VA: 0x1808C3B30
	|-Property<object, StylePropertyName>.AddAttribute
	|
	|-RVA: 0x8C3B90 Offset: 0x8C2190 VA: 0x1808C3B90
	|-Property<object, StyleRotate>.AddAttribute
	|
	|-RVA: 0x8C4910 Offset: 0x8C2F10 VA: 0x1808C4910
	|-Property<object, StyleScale>.AddAttribute
	|
	|-RVA: 0x8C4D30 Offset: 0x8C3330 VA: 0x1808C4D30
	|-Property<object, StyleTextShadow>.AddAttribute
	|
	|-RVA: 0x8C4F70 Offset: 0x8C3570 VA: 0x1808C4F70
	|-Property<object, StyleTransformOrigin>.AddAttribute
	|
	|-RVA: 0x8C4F10 Offset: 0x8C3510 VA: 0x1808C4F10
	|-Property<object, StyleTranslate>.AddAttribute
	|
	|-RVA: 0x8C48B0 Offset: 0x8C2EB0 VA: 0x1808C48B0
	|-Property<object, TimeValue>.AddAttribute
	|
	|-RVA: 0x8C4AF0 Offset: 0x8C30F0 VA: 0x1808C4AF0
	|-Property<object, Vector3>.AddAttribute
	|
	|-RVA: 0x8C4010 Offset: 0x8C2610 VA: 0x1808C4010
	|-Property<Rect, float>.AddAttribute
	|
	|-RVA: 0x8C4490 Offset: 0x8C2A90 VA: 0x1808C4490
	|-Property<RectInt, int>.AddAttribute
	|
	|-RVA: 0x8C3DD0 Offset: 0x8C23D0 VA: 0x1808C3DD0
	|-Property<Rotate, Angle>.AddAttribute
	|
	|-RVA: 0x8C50F0 Offset: 0x8C36F0 VA: 0x1808C50F0
	|-Property<Rotate, Vector3>.AddAttribute
	|
	|-RVA: 0x8C43D0 Offset: 0x8C29D0 VA: 0x1808C43D0
	|-Property<Scale, Vector3>.AddAttribute
	|
	|-RVA: 0x8C4550 Offset: 0x8C2B50 VA: 0x1808C4550
	|-Property<StyleBackground, Background>.AddAttribute
	|
	|-RVA: 0x8C5030 Offset: 0x8C3630 VA: 0x1808C5030
	|-Property<StyleBackground, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C4A90 Offset: 0x8C3090 VA: 0x1808C4A90
	|-Property<StyleBackgroundPosition, BackgroundPosition>.AddAttribute
	|
	|-RVA: 0x8C54B0 Offset: 0x8C3AB0 VA: 0x1808C54B0
	|-Property<StyleBackgroundPosition, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C3E30 Offset: 0x8C2430 VA: 0x1808C3E30
	|-Property<StyleBackgroundRepeat, BackgroundRepeat>.AddAttribute
	|
	|-RVA: 0x8C3E90 Offset: 0x8C2490 VA: 0x1808C3E90
	|-Property<StyleBackgroundRepeat, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C4CD0 Offset: 0x8C32D0 VA: 0x1808C4CD0
	|-Property<StyleBackgroundSize, BackgroundSize>.AddAttribute
	|
	|-RVA: 0x8C4EB0 Offset: 0x8C34B0 VA: 0x1808C4EB0
	|-Property<StyleBackgroundSize, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C51B0 Offset: 0x8C37B0 VA: 0x1808C51B0
	|-Property<StyleColor, Color>.AddAttribute
	|
	|-RVA: 0x8C52D0 Offset: 0x8C38D0 VA: 0x1808C52D0
	|-Property<StyleColor, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C3D10 Offset: 0x8C2310 VA: 0x1808C3D10
	|-Property<StyleCursor, Cursor>.AddAttribute
	|
	|-RVA: 0x8C46D0 Offset: 0x8C2CD0 VA: 0x1808C46D0
	|-Property<StyleCursor, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C5090 Offset: 0x8C3690 VA: 0x1808C5090
	|-Property<StyleFloat, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C3D70 Offset: 0x8C2370 VA: 0x1808C3D70
	|-Property<StyleFloat, float>.AddAttribute
	|
	|-RVA: 0x8C4250 Offset: 0x8C2850 VA: 0x1808C4250
	|-Property<StyleFont, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C4670 Offset: 0x8C2C70 VA: 0x1808C4670
	|-Property<StyleFont, object>.AddAttribute
	|
	|-RVA: 0x8C41F0 Offset: 0x8C27F0 VA: 0x1808C41F0
	|-Property<StyleFontDefinition, FontDefinition>.AddAttribute
	|
	|-RVA: 0x8C4850 Offset: 0x8C2E50 VA: 0x1808C4850
	|-Property<StyleFontDefinition, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C4130 Offset: 0x8C2730 VA: 0x1808C4130
	|-Property<StyleInt, int>.AddAttribute
	|
	|-RVA: 0x8C42B0 Offset: 0x8C28B0 VA: 0x1808C42B0
	|-Property<StyleInt, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C3CB0 Offset: 0x8C22B0 VA: 0x1808C3CB0
	|-Property<StyleLength, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C4790 Offset: 0x8C2D90 VA: 0x1808C4790
	|-Property<StyleLength, Length>.AddAttribute
	|
	|-RVA: 0x8C4BB0 Offset: 0x8C31B0 VA: 0x1808C4BB0
	|-Property<StylePropertyName, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C4C10 Offset: 0x8C3210 VA: 0x1808C4C10
	|-Property<StylePropertyName, object>.AddAttribute
	|
	|-RVA: 0x8C3FB0 Offset: 0x8C25B0 VA: 0x1808C3FB0
	|-Property<StyleRotate, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C4FD0 Offset: 0x8C35D0 VA: 0x1808C4FD0
	|-Property<StyleRotate, Rotate>.AddAttribute
	|
	|-RVA: 0x8C5390 Offset: 0x8C3990 VA: 0x1808C5390
	|-Property<StyleScale, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C4190 Offset: 0x8C2790 VA: 0x1808C4190
	|-Property<StyleScale, Scale>.AddAttribute
	|
	|-RVA: 0x8C5450 Offset: 0x8C3A50 VA: 0x1808C5450
	|-Property<StyleTextShadow, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C4D90 Offset: 0x8C3390 VA: 0x1808C4D90
	|-Property<StyleTextShadow, TextShadow>.AddAttribute
	|
	|-RVA: 0x8C4970 Offset: 0x8C2F70 VA: 0x1808C4970
	|-Property<StyleTransformOrigin, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C4B50 Offset: 0x8C3150 VA: 0x1808C4B50
	|-Property<StyleTransformOrigin, TransformOrigin>.AddAttribute
	|
	|-RVA: 0x8C4E50 Offset: 0x8C3450 VA: 0x1808C4E50
	|-Property<StyleTranslate, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C3F50 Offset: 0x8C2550 VA: 0x1808C3F50
	|-Property<StyleTranslate, Translate>.AddAttribute
	|
	|-RVA: 0x8C4610 Offset: 0x8C2C10 VA: 0x1808C4610
	|-Property<TextShadow, Color>.AddAttribute
	|
	|-RVA: 0x8C4310 Offset: 0x8C2910 VA: 0x1808C4310
	|-Property<TextShadow, float>.AddAttribute
	|
	|-RVA: 0x8C4370 Offset: 0x8C2970 VA: 0x1808C4370
	|-Property<TextShadow, Vector2>.AddAttribute
	|
	|-RVA: 0x8C5330 Offset: 0x8C3930 VA: 0x1808C5330
	|-Property<TimeValue, Int32Enum>.AddAttribute
	|
	|-RVA: 0x8C49D0 Offset: 0x8C2FD0 VA: 0x1808C49D0
	|-Property<TimeValue, float>.AddAttribute
	|
	|-RVA: 0x8C53F0 Offset: 0x8C39F0 VA: 0x1808C53F0
	|-Property<TransformOrigin, Length>.AddAttribute
	|
	|-RVA: 0x8C4A30 Offset: 0x8C3030 VA: 0x1808C4A30
	|-Property<TransformOrigin, float>.AddAttribute
	|
	|-RVA: 0x8C5210 Offset: 0x8C3810 VA: 0x1808C5210
	|-Property<Translate, Length>.AddAttribute
	|
	|-RVA: 0x8C45B0 Offset: 0x8C2BB0 VA: 0x1808C45B0
	|-Property<Translate, float>.AddAttribute
	|
	|-RVA: 0x8C44F0 Offset: 0x8C2AF0 VA: 0x1808C44F0
	|-Property<Vector2, float>.AddAttribute
	|
	|-RVA: 0x8C5510 Offset: 0x8C3B10 VA: 0x1808C5510
	|-Property<Vector2Int, int>.AddAttribute
	|
	|-RVA: 0x8C4070 Offset: 0x8C2670 VA: 0x1808C4070
	|-Property<Vector3, float>.AddAttribute
	|
	|-RVA: 0x8C4DF0 Offset: 0x8C33F0 VA: 0x1808C4DF0
	|-Property<Vector3Int, int>.AddAttribute
	|
	|-RVA: 0x8C4C70 Offset: 0x8C3270 VA: 0x1808C4C70
	|-Property<Vector4, float>.AddAttribute
	|
	|-RVA: 0x8C4730 Offset: 0x8C2D30 VA: 0x1808C4730
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttribute
	*/

	// RVA: -1 Offset: -1
	protected void AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B8010 Offset: 0x8B6610 VA: 0x1808B8010
	|-Property<StyleEnum<Int32Enum>, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B8250 Offset: 0x8B6850 VA: 0x1808B8250
	|-Property<StyleList<EasingFunction>, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B7E90 Offset: 0x8B6490 VA: 0x1808B7E90
	|-Property<StyleList<EasingFunction>, object>.AddAttributes
	|
	|-RVA: 0x8B8430 Offset: 0x8B6A30 VA: 0x1808B8430
	|-Property<StyleList<StylePropertyName>, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B8C10 Offset: 0x8B7210 VA: 0x1808B8C10
	|-Property<StyleList<StylePropertyName>, object>.AddAttributes
	|
	|-RVA: 0x8B8910 Offset: 0x8B6F10 VA: 0x1808B8910
	|-Property<StyleList<TimeValue>, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B7D10 Offset: 0x8B6310 VA: 0x1808B7D10
	|-Property<StyleList<TimeValue>, object>.AddAttributes
	|
	|-RVA: 0x8B82B0 Offset: 0x8B68B0 VA: 0x1808B82B0
	|-Property<Angle, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B7B90 Offset: 0x8B6190 VA: 0x1808B7B90
	|-Property<Angle, float>.AddAttributes
	|
	|-RVA: 0x8B8AF0 Offset: 0x8B70F0 VA: 0x1808B8AF0
	|-Property<Background, object>.AddAttributes
	|
	|-RVA: 0x8B8310 Offset: 0x8B6910 VA: 0x1808B8310
	|-Property<BackgroundPosition, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B86D0 Offset: 0x8B6CD0 VA: 0x1808B86D0
	|-Property<BackgroundPosition, Length>.AddAttributes
	|
	|-RVA: 0x8B8B50 Offset: 0x8B7150 VA: 0x1808B8B50
	|-Property<BackgroundRepeat, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B8490 Offset: 0x8B6A90 VA: 0x1808B8490
	|-Property<BackgroundSize, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B85B0 Offset: 0x8B6BB0 VA: 0x1808B85B0
	|-Property<BackgroundSize, Length>.AddAttributes
	|
	|-RVA: 0x8B8130 Offset: 0x8B6730 VA: 0x1808B8130
	|-Property<Bounds, Vector3>.AddAttributes
	|
	|-RVA: 0x8B8A90 Offset: 0x8B7090 VA: 0x1808B8A90
	|-Property<BoundsInt, Vector3Int>.AddAttributes
	|
	|-RVA: 0x8B8730 Offset: 0x8B6D30 VA: 0x1808B8730
	|-Property<Color, float>.AddAttributes
	|
	|-RVA: 0x8B84F0 Offset: 0x8B6AF0 VA: 0x1808B84F0
	|-Property<Cursor, int>.AddAttributes
	|
	|-RVA: 0x8B8550 Offset: 0x8B6B50 VA: 0x1808B8550
	|-Property<Cursor, object>.AddAttributes
	|
	|-RVA: 0x8B8790 Offset: 0x8B6D90 VA: 0x1808B8790
	|-Property<Cursor, Vector2>.AddAttributes
	|
	|-RVA: 0x8B7E30 Offset: 0x8B6430 VA: 0x1808B7E30
	|-Property<EasingFunction, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B8610 Offset: 0x8B6C10 VA: 0x1808B8610
	|-Property<FontDefinition, object>.AddAttributes
	|
	|-RVA: 0x8B8670 Offset: 0x8B6C70 VA: 0x1808B8670
	|-Property<Length, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B7F50 Offset: 0x8B6550 VA: 0x1808B7F50
	|-Property<Length, float>.AddAttributes
	|
	|-RVA: 0x8B7DD0 Offset: 0x8B63D0 VA: 0x1808B7DD0
	|-Property<object, StyleEnum<Int32Enum>>.AddAttributes
	|
	|-RVA: 0x8B87F0 Offset: 0x8B6DF0 VA: 0x1808B87F0
	|-Property<object, StyleList<EasingFunction>>.AddAttributes
	|
	|-RVA: 0x8B8BB0 Offset: 0x8B71B0 VA: 0x1808B8BB0
	|-Property<object, StyleList<StylePropertyName>>.AddAttributes
	|
	|-RVA: 0x8B7EF0 Offset: 0x8B64F0 VA: 0x1808B7EF0
	|-Property<object, StyleList<TimeValue>>.AddAttributes
	|
	|-RVA: 0x8B8370 Offset: 0x8B6970 VA: 0x1808B8370
	|-Property<object, Background>.AddAttributes
	|
	|-RVA: 0x8B8970 Offset: 0x8B6F70 VA: 0x1808B8970
	|-Property<object, BackgroundPosition>.AddAttributes
	|
	|-RVA: 0x8B7BF0 Offset: 0x8B61F0 VA: 0x1808B7BF0
	|-Property<object, BackgroundRepeat>.AddAttributes
	|
	|-RVA: 0x8B8A30 Offset: 0x8B7030 VA: 0x1808B8A30
	|-Property<object, BackgroundSize>.AddAttributes
	|
	|-RVA: 0x8B89D0 Offset: 0x8B6FD0 VA: 0x1808B89D0
	|-Property<object, Color>.AddAttributes
	|
	|-RVA: 0x8B80D0 Offset: 0x8B66D0 VA: 0x1808B80D0
	|-Property<object, EasingFunction>.AddAttributes
	|
	|-RVA: 0x8B83D0 Offset: 0x8B69D0 VA: 0x1808B83D0
	|-Property<object, FontDefinition>.AddAttributes
	|
	|-RVA: 0x8B8070 Offset: 0x8B6670 VA: 0x1808B8070
	|-Property<object, int>.AddAttributes
	|
	|-RVA: 0x8B8190 Offset: 0x8B6790 VA: 0x1808B8190
	|-Property<object, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8B8850 Offset: 0x8B6E50 VA: 0x1808B8850
	|-Property<object, object>.AddAttributes
	|
	|-RVA: 0x8B88B0 Offset: 0x8B6EB0 VA: 0x1808B88B0
	|-Property<object, Rotate>.AddAttributes
	|
	|-RVA: 0x8B81F0 Offset: 0x8B67F0 VA: 0x1808B81F0
	|-Property<object, Scale>.AddAttributes
	|
	|-RVA: 0x8B7D70 Offset: 0x8B6370 VA: 0x1808B7D70
	|-Property<object, float>.AddAttributes
	|
	|-RVA: 0x8B7CB0 Offset: 0x8B62B0 VA: 0x1808B7CB0
	|-Property<object, StyleBackground>.AddAttributes
	|
	|-RVA: 0x8B7C50 Offset: 0x8B6250 VA: 0x1808B7C50
	|-Property<object, StyleBackgroundPosition>.AddAttributes
	|
	|-RVA: 0x8B7FB0 Offset: 0x8B65B0 VA: 0x1808B7FB0
	|-Property<object, StyleBackgroundRepeat>.AddAttributes
	|
	|-RVA: 0x8C5C90 Offset: 0x8C4290 VA: 0x1808C5C90
	|-Property<object, StyleBackgroundSize>.AddAttributes
	|
	|-RVA: 0x8C61D0 Offset: 0x8C47D0 VA: 0x1808C61D0
	|-Property<object, StyleColor>.AddAttributes
	|
	|-RVA: 0x8C6410 Offset: 0x8C4A10 VA: 0x1808C6410
	|-Property<object, StyleCursor>.AddAttributes
	|
	|-RVA: 0x8C6CB0 Offset: 0x8C52B0 VA: 0x1808C6CB0
	|-Property<object, StyleFloat>.AddAttributes
	|
	|-RVA: 0x8C5FF0 Offset: 0x8C45F0 VA: 0x1808C5FF0
	|-Property<object, StyleFont>.AddAttributes
	|
	|-RVA: 0x8C5990 Offset: 0x8C3F90 VA: 0x1808C5990
	|-Property<object, StyleFontDefinition>.AddAttributes
	|
	|-RVA: 0x8C69B0 Offset: 0x8C4FB0 VA: 0x1808C69B0
	|-Property<object, StyleInt>.AddAttributes
	|
	|-RVA: 0x8C5E70 Offset: 0x8C4470 VA: 0x1808C5E70
	|-Property<object, StyleLength>.AddAttributes
	|
	|-RVA: 0x8C6650 Offset: 0x8C4C50 VA: 0x1808C6650
	|-Property<object, StylePropertyName>.AddAttributes
	|
	|-RVA: 0x8C5D50 Offset: 0x8C4350 VA: 0x1808C5D50
	|-Property<object, StyleRotate>.AddAttributes
	|
	|-RVA: 0x8C5C30 Offset: 0x8C4230 VA: 0x1808C5C30
	|-Property<object, StyleScale>.AddAttributes
	|
	|-RVA: 0x8C5DB0 Offset: 0x8C43B0 VA: 0x1808C5DB0
	|-Property<object, StyleTextShadow>.AddAttributes
	|
	|-RVA: 0x8C5B10 Offset: 0x8C4110 VA: 0x1808C5B10
	|-Property<object, StyleTransformOrigin>.AddAttributes
	|
	|-RVA: 0x8C6950 Offset: 0x8C4F50 VA: 0x1808C6950
	|-Property<object, StyleTranslate>.AddAttributes
	|
	|-RVA: 0x8C60B0 Offset: 0x8C46B0 VA: 0x1808C60B0
	|-Property<object, TimeValue>.AddAttributes
	|
	|-RVA: 0x8C6710 Offset: 0x8C4D10 VA: 0x1808C6710
	|-Property<object, Vector3>.AddAttributes
	|
	|-RVA: 0x8C5ED0 Offset: 0x8C44D0 VA: 0x1808C5ED0
	|-Property<Rect, float>.AddAttributes
	|
	|-RVA: 0x8C67D0 Offset: 0x8C4DD0 VA: 0x1808C67D0
	|-Property<RectInt, int>.AddAttributes
	|
	|-RVA: 0x8C64D0 Offset: 0x8C4AD0 VA: 0x1808C64D0
	|-Property<Rotate, Angle>.AddAttributes
	|
	|-RVA: 0x8C6050 Offset: 0x8C4650 VA: 0x1808C6050
	|-Property<Rotate, Vector3>.AddAttributes
	|
	|-RVA: 0x8C6F50 Offset: 0x8C5550 VA: 0x1808C6F50
	|-Property<Scale, Vector3>.AddAttributes
	|
	|-RVA: 0x8C57B0 Offset: 0x8C3DB0 VA: 0x1808C57B0
	|-Property<StyleBackground, Background>.AddAttributes
	|
	|-RVA: 0x8C6230 Offset: 0x8C4830 VA: 0x1808C6230
	|-Property<StyleBackground, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C6B30 Offset: 0x8C5130 VA: 0x1808C6B30
	|-Property<StyleBackgroundPosition, BackgroundPosition>.AddAttributes
	|
	|-RVA: 0x8C6AD0 Offset: 0x8C50D0 VA: 0x1808C6AD0
	|-Property<StyleBackgroundPosition, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C6E90 Offset: 0x8C5490 VA: 0x1808C6E90
	|-Property<StyleBackgroundRepeat, BackgroundRepeat>.AddAttributes
	|
	|-RVA: 0x8C66B0 Offset: 0x8C4CB0 VA: 0x1808C66B0
	|-Property<StyleBackgroundRepeat, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C5810 Offset: 0x8C3E10 VA: 0x1808C5810
	|-Property<StyleBackgroundSize, BackgroundSize>.AddAttributes
	|
	|-RVA: 0x8C6470 Offset: 0x8C4A70 VA: 0x1808C6470
	|-Property<StyleBackgroundSize, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C6110 Offset: 0x8C4710 VA: 0x1808C6110
	|-Property<StyleColor, Color>.AddAttributes
	|
	|-RVA: 0x8C5870 Offset: 0x8C3E70 VA: 0x1808C5870
	|-Property<StyleColor, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C6BF0 Offset: 0x8C51F0 VA: 0x1808C6BF0
	|-Property<StyleCursor, Cursor>.AddAttributes
	|
	|-RVA: 0x8C6A70 Offset: 0x8C5070 VA: 0x1808C6A70
	|-Property<StyleCursor, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C6D10 Offset: 0x8C5310 VA: 0x1808C6D10
	|-Property<StyleFloat, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C5690 Offset: 0x8C3C90 VA: 0x1808C5690
	|-Property<StyleFloat, float>.AddAttributes
	|
	|-RVA: 0x8C55D0 Offset: 0x8C3BD0 VA: 0x1808C55D0
	|-Property<StyleFont, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C5750 Offset: 0x8C3D50 VA: 0x1808C5750
	|-Property<StyleFont, object>.AddAttributes
	|
	|-RVA: 0x8C6E30 Offset: 0x8C5430 VA: 0x1808C6E30
	|-Property<StyleFontDefinition, FontDefinition>.AddAttributes
	|
	|-RVA: 0x8C6DD0 Offset: 0x8C53D0 VA: 0x1808C6DD0
	|-Property<StyleFontDefinition, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C6290 Offset: 0x8C4890 VA: 0x1808C6290
	|-Property<StyleInt, int>.AddAttributes
	|
	|-RVA: 0x8C6170 Offset: 0x8C4770 VA: 0x1808C6170
	|-Property<StyleInt, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C59F0 Offset: 0x8C3FF0 VA: 0x1808C59F0
	|-Property<StyleLength, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C5A50 Offset: 0x8C4050 VA: 0x1808C5A50
	|-Property<StyleLength, Length>.AddAttributes
	|
	|-RVA: 0x8C6A10 Offset: 0x8C5010 VA: 0x1808C6A10
	|-Property<StylePropertyName, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C6D70 Offset: 0x8C5370 VA: 0x1808C6D70
	|-Property<StylePropertyName, object>.AddAttributes
	|
	|-RVA: 0x8C5E10 Offset: 0x8C4410 VA: 0x1808C5E10
	|-Property<StyleRotate, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C68F0 Offset: 0x8C4EF0 VA: 0x1808C68F0
	|-Property<StyleRotate, Rotate>.AddAttributes
	|
	|-RVA: 0x8C6EF0 Offset: 0x8C54F0 VA: 0x1808C6EF0
	|-Property<StyleScale, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C6C50 Offset: 0x8C5250 VA: 0x1808C6C50
	|-Property<StyleScale, Scale>.AddAttributes
	|
	|-RVA: 0x8C6530 Offset: 0x8C4B30 VA: 0x1808C6530
	|-Property<StyleTextShadow, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C6B90 Offset: 0x8C5190 VA: 0x1808C6B90
	|-Property<StyleTextShadow, TextShadow>.AddAttributes
	|
	|-RVA: 0x8C6350 Offset: 0x8C4950 VA: 0x1808C6350
	|-Property<StyleTransformOrigin, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C5F30 Offset: 0x8C4530 VA: 0x1808C5F30
	|-Property<StyleTransformOrigin, TransformOrigin>.AddAttributes
	|
	|-RVA: 0x8C5BD0 Offset: 0x8C41D0 VA: 0x1808C5BD0
	|-Property<StyleTranslate, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C56F0 Offset: 0x8C3CF0 VA: 0x1808C56F0
	|-Property<StyleTranslate, Translate>.AddAttributes
	|
	|-RVA: 0x8C6890 Offset: 0x8C4E90 VA: 0x1808C6890
	|-Property<TextShadow, Color>.AddAttributes
	|
	|-RVA: 0x8C6770 Offset: 0x8C4D70 VA: 0x1808C6770
	|-Property<TextShadow, float>.AddAttributes
	|
	|-RVA: 0x8C6590 Offset: 0x8C4B90 VA: 0x1808C6590
	|-Property<TextShadow, Vector2>.AddAttributes
	|
	|-RVA: 0x8C62F0 Offset: 0x8C48F0 VA: 0x1808C62F0
	|-Property<TimeValue, Int32Enum>.AddAttributes
	|
	|-RVA: 0x8C5F90 Offset: 0x8C4590 VA: 0x1808C5F90
	|-Property<TimeValue, float>.AddAttributes
	|
	|-RVA: 0x8C58D0 Offset: 0x8C3ED0 VA: 0x1808C58D0
	|-Property<TransformOrigin, Length>.AddAttributes
	|
	|-RVA: 0x8C5630 Offset: 0x8C3C30 VA: 0x1808C5630
	|-Property<TransformOrigin, float>.AddAttributes
	|
	|-RVA: 0x8C5AB0 Offset: 0x8C40B0 VA: 0x1808C5AB0
	|-Property<Translate, Length>.AddAttributes
	|
	|-RVA: 0x8C5B70 Offset: 0x8C4170 VA: 0x1808C5B70
	|-Property<Translate, float>.AddAttributes
	|
	|-RVA: 0x8C6830 Offset: 0x8C4E30 VA: 0x1808C6830
	|-Property<Vector2, float>.AddAttributes
	|
	|-RVA: 0x8C5CF0 Offset: 0x8C42F0 VA: 0x1808C5CF0
	|-Property<Vector2Int, int>.AddAttributes
	|
	|-RVA: 0x8C65F0 Offset: 0x8C4BF0 VA: 0x1808C65F0
	|-Property<Vector3, float>.AddAttributes
	|
	|-RVA: 0x8C5570 Offset: 0x8C3B70 VA: 0x1808C5570
	|-Property<Vector3Int, int>.AddAttributes
	|
	|-RVA: 0x8C63B0 Offset: 0x8C49B0 VA: 0x1808C63B0
	|-Property<Vector4, float>.AddAttributes
	|
	|-RVA: 0x8C5930 Offset: 0x8C3F30 VA: 0x1808C5930
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B8EF0 Offset: 0x8B74F0 VA: 0x1808B8EF0
	|-Property<StyleEnum<Int32Enum>, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B8DD0 Offset: 0x8B73D0 VA: 0x1808B8DD0
	|-Property<StyleList<EasingFunction>, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9C70 Offset: 0x8B8270 VA: 0x1808B9C70
	|-Property<StyleList<EasingFunction>, object>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BBBF0 Offset: 0x8BA1F0 VA: 0x1808BBBF0
	|-Property<StyleList<StylePropertyName>, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BA8D0 Offset: 0x8B8ED0 VA: 0x1808BA8D0
	|-Property<StyleList<StylePropertyName>, object>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BB890 Offset: 0x8B9E90 VA: 0x1808BB890
	|-Property<StyleList<TimeValue>, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BA7B0 Offset: 0x8B8DB0 VA: 0x1808BA7B0
	|-Property<StyleList<TimeValue>, object>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BAB10 Offset: 0x8B9110 VA: 0x1808BAB10
	|-Property<Angle, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BB2F0 Offset: 0x8B98F0 VA: 0x1808BB2F0
	|-Property<Angle, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BBE30 Offset: 0x8BA430 VA: 0x1808BBE30
	|-Property<Background, object>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BAD50 Offset: 0x8B9350 VA: 0x1808BAD50
	|-Property<BackgroundPosition, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BA330 Offset: 0x8B8930 VA: 0x1808BA330
	|-Property<BackgroundPosition, Length>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BB9B0 Offset: 0x8B9FB0 VA: 0x1808BB9B0
	|-Property<BackgroundRepeat, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9D90 Offset: 0x8B8390 VA: 0x1808B9D90
	|-Property<BackgroundSize, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9250 Offset: 0x8B7850 VA: 0x1808B9250
	|-Property<BackgroundSize, Length>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9490 Offset: 0x8B7A90 VA: 0x1808B9490
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9370 Offset: 0x8B7970 VA: 0x1808B9370
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BA0F0 Offset: 0x8B86F0 VA: 0x1808BA0F0
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BAF90 Offset: 0x8B9590 VA: 0x1808BAF90
	|-Property<Cursor, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9A30 Offset: 0x8B8030 VA: 0x1808B9A30
	|-Property<Cursor, object>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9B50 Offset: 0x8B8150 VA: 0x1808B9B50
	|-Property<Cursor, Vector2>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9FD0 Offset: 0x8B85D0 VA: 0x1808B9FD0
	|-Property<EasingFunction, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B96D0 Offset: 0x8B7CD0 VA: 0x1808B96D0
	|-Property<FontDefinition, object>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B97F0 Offset: 0x8B7DF0 VA: 0x1808B97F0
	|-Property<Length, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BA210 Offset: 0x8B8810 VA: 0x1808BA210
	|-Property<Length, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9010 Offset: 0x8B7610 VA: 0x1808B9010
	|-Property<object, StyleEnum<Int32Enum>>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BB410 Offset: 0x8B9A10 VA: 0x1808BB410
	|-Property<object, StyleList<EasingFunction>>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BA570 Offset: 0x8B8B70 VA: 0x1808BA570
	|-Property<object, StyleList<StylePropertyName>>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BA450 Offset: 0x8B8A50 VA: 0x1808BA450
	|-Property<object, StyleList<TimeValue>>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BBD10 Offset: 0x8BA310 VA: 0x1808BBD10
	|-Property<object, Background>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BB650 Offset: 0x8B9C50 VA: 0x1808BB650
	|-Property<object, BackgroundPosition>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9910 Offset: 0x8B7F10 VA: 0x1808B9910
	|-Property<object, BackgroundRepeat>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BB1D0 Offset: 0x8B97D0 VA: 0x1808BB1D0
	|-Property<object, BackgroundSize>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BAE70 Offset: 0x8B9470 VA: 0x1808BAE70
	|-Property<object, Color>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BB0B0 Offset: 0x8B96B0 VA: 0x1808BB0B0
	|-Property<object, EasingFunction>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BB530 Offset: 0x8B9B30 VA: 0x1808BB530
	|-Property<object, FontDefinition>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B95B0 Offset: 0x8B7BB0 VA: 0x1808B95B0
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BA9F0 Offset: 0x8B8FF0 VA: 0x1808BA9F0
	|-Property<object, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BAC30 Offset: 0x8B9230 VA: 0x1808BAC30
	|-Property<object, object>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9130 Offset: 0x8B7730 VA: 0x1808B9130
	|-Property<object, Rotate>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BA690 Offset: 0x8B8C90 VA: 0x1808BA690
	|-Property<object, Scale>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B8CB0 Offset: 0x8B72B0 VA: 0x1808B8CB0
	|-Property<object, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8B9EB0 Offset: 0x8B84B0 VA: 0x1808B9EB0
	|-Property<object, StyleBackground>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BB770 Offset: 0x8B9D70 VA: 0x1808BB770
	|-Property<object, StyleBackgroundPosition>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8BBAD0 Offset: 0x8BA0D0 VA: 0x1808BBAD0
	|-Property<object, StyleBackgroundRepeat>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CA370 Offset: 0x8C8970 VA: 0x1808CA370
	|-Property<object, StyleBackgroundSize>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CB0F0 Offset: 0x8C96F0 VA: 0x1808CB0F0
	|-Property<object, StyleColor>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CB450 Offset: 0x8C9A50 VA: 0x1808CB450
	|-Property<object, StyleCursor>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C7550 Offset: 0x8C5B50 VA: 0x1808C7550
	|-Property<object, StyleFloat>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CA6D0 Offset: 0x8C8CD0 VA: 0x1808CA6D0
	|-Property<object, StyleFont>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C7C10 Offset: 0x8C6210 VA: 0x1808C7C10
	|-Property<object, StyleFontDefinition>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9050 Offset: 0x8C7650 VA: 0x1808C9050
	|-Property<object, StyleInt>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CAA30 Offset: 0x8C9030 VA: 0x1808CAA30
	|-Property<object, StyleLength>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C6FB0 Offset: 0x8C55B0 VA: 0x1808C6FB0
	|-Property<object, StylePropertyName>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C7AF0 Offset: 0x8C60F0 VA: 0x1808C7AF0
	|-Property<object, StyleRotate>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9A70 Offset: 0x8C8070 VA: 0x1808C9A70
	|-Property<object, StyleScale>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CBD50 Offset: 0x8CA350 VA: 0x1808CBD50
	|-Property<object, StyleTextShadow>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C93B0 Offset: 0x8C79B0 VA: 0x1808C93B0
	|-Property<object, StyleTransformOrigin>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8990 Offset: 0x8C6F90 VA: 0x1808C8990
	|-Property<object, StyleTranslate>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8630 Offset: 0x8C6C30 VA: 0x1808C8630
	|-Property<object, TimeValue>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9DD0 Offset: 0x8C83D0 VA: 0x1808C9DD0
	|-Property<object, Vector3>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CB9F0 Offset: 0x8C9FF0 VA: 0x1808CB9F0
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9950 Offset: 0x8C7F50 VA: 0x1808C9950
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8E10 Offset: 0x8C7410 VA: 0x1808C8E10
	|-Property<Rotate, Angle>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C82D0 Offset: 0x8C68D0 VA: 0x1808C82D0
	|-Property<Rotate, Vector3>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CAEB0 Offset: 0x8C94B0 VA: 0x1808CAEB0
	|-Property<Scale, Vector3>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9830 Offset: 0x8C7E30 VA: 0x1808C9830
	|-Property<StyleBackground, Background>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C94D0 Offset: 0x8C7AD0 VA: 0x1808C94D0
	|-Property<StyleBackground, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9CB0 Offset: 0x8C82B0 VA: 0x1808C9CB0
	|-Property<StyleBackgroundPosition, BackgroundPosition>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9170 Offset: 0x8C7770 VA: 0x1808C9170
	|-Property<StyleBackgroundPosition, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8BD0 Offset: 0x8C71D0 VA: 0x1808C8BD0
	|-Property<StyleBackgroundRepeat, BackgroundRepeat>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CA910 Offset: 0x8C8F10 VA: 0x1808CA910
	|-Property<StyleBackgroundRepeat, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C78B0 Offset: 0x8C5EB0 VA: 0x1808C78B0
	|-Property<StyleBackgroundSize, BackgroundSize>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C71F0 Offset: 0x8C57F0 VA: 0x1808C71F0
	|-Property<StyleBackgroundSize, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C7790 Offset: 0x8C5D90 VA: 0x1808C7790
	|-Property<StyleColor, Color>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CB330 Offset: 0x8C9930 VA: 0x1808CB330
	|-Property<StyleColor, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C7310 Offset: 0x8C5910 VA: 0x1808C7310
	|-Property<StyleCursor, Cursor>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C70D0 Offset: 0x8C56D0 VA: 0x1808C70D0
	|-Property<StyleCursor, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8090 Offset: 0x8C6690 VA: 0x1808C8090
	|-Property<StyleFloat, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8750 Offset: 0x8C6D50 VA: 0x1808C8750
	|-Property<StyleFloat, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C7F70 Offset: 0x8C6570 VA: 0x1808C7F70
	|-Property<StyleFont, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CBC30 Offset: 0x8CA230 VA: 0x1808CBC30
	|-Property<StyleFont, object>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C7430 Offset: 0x8C5A30 VA: 0x1808C7430
	|-Property<StyleFontDefinition, FontDefinition>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CA010 Offset: 0x8C8610 VA: 0x1808CA010
	|-Property<StyleFontDefinition, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CA7F0 Offset: 0x8C8DF0 VA: 0x1808CA7F0
	|-Property<StyleInt, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CA490 Offset: 0x8C8A90 VA: 0x1808CA490
	|-Property<StyleInt, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C7D30 Offset: 0x8C6330 VA: 0x1808C7D30
	|-Property<StyleLength, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9290 Offset: 0x8C7890 VA: 0x1808C9290
	|-Property<StyleLength, Length>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8F30 Offset: 0x8C7530 VA: 0x1808C8F30
	|-Property<StylePropertyName, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C7E50 Offset: 0x8C6450 VA: 0x1808C7E50
	|-Property<StylePropertyName, object>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CBB10 Offset: 0x8CA110 VA: 0x1808CBB10
	|-Property<StyleRotate, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CA130 Offset: 0x8C8730 VA: 0x1808CA130
	|-Property<StyleRotate, Rotate>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CAD90 Offset: 0x8C9390 VA: 0x1808CAD90
	|-Property<StyleScale, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9710 Offset: 0x8C7D10 VA: 0x1808C9710
	|-Property<StyleScale, Scale>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CB7B0 Offset: 0x8C9DB0 VA: 0x1808CB7B0
	|-Property<StyleTextShadow, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C7670 Offset: 0x8C5C70 VA: 0x1808C7670
	|-Property<StyleTextShadow, TextShadow>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8510 Offset: 0x8C6B10 VA: 0x1808C8510
	|-Property<StyleTransformOrigin, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8AB0 Offset: 0x8C70B0 VA: 0x1808C8AB0
	|-Property<StyleTransformOrigin, TransformOrigin>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9B90 Offset: 0x8C8190 VA: 0x1808C9B90
	|-Property<StyleTranslate, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C81B0 Offset: 0x8C67B0 VA: 0x1808C81B0
	|-Property<StyleTranslate, Translate>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CB210 Offset: 0x8C9810 VA: 0x1808CB210
	|-Property<TextShadow, Color>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C79D0 Offset: 0x8C5FD0 VA: 0x1808C79D0
	|-Property<TextShadow, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CB690 Offset: 0x8C9C90 VA: 0x1808CB690
	|-Property<TextShadow, Vector2>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CB8D0 Offset: 0x8C9ED0 VA: 0x1808CB8D0
	|-Property<TimeValue, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CAC70 Offset: 0x8C9270 VA: 0x1808CAC70
	|-Property<TimeValue, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CA250 Offset: 0x8C8850 VA: 0x1808CA250
	|-Property<TransformOrigin, Length>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C83F0 Offset: 0x8C69F0 VA: 0x1808C83F0
	|-Property<TransformOrigin, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CAFD0 Offset: 0x8C95D0 VA: 0x1808CAFD0
	|-Property<Translate, Length>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C95F0 Offset: 0x8C7BF0 VA: 0x1808C95F0
	|-Property<Translate, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8CF0 Offset: 0x8C72F0 VA: 0x1808C8CF0
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CB570 Offset: 0x8C9B70 VA: 0x1808CB570
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CA5B0 Offset: 0x8C8BB0 VA: 0x1808CA5B0
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C9EF0 Offset: 0x8C84F0 VA: 0x1808C9EF0
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8C8870 Offset: 0x8C6E70 VA: 0x1808C8870
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.AddAttribute
	|
	|-RVA: 0x8CAB50 Offset: 0x8C9150 VA: 0x1808CAB50
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttribute
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8BCA90 Offset: 0x8BB090 VA: 0x1808BCA90
	|-Property<StyleEnum<Int32Enum>, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BC190 Offset: 0x8BA790 VA: 0x1808BC190
	|-Property<StyleList<EasingFunction>, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C1050 Offset: 0x8BF650 VA: 0x1808C1050
	|-Property<StyleList<EasingFunction>, object>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BC610 Offset: 0x8BAC10 VA: 0x1808BC610
	|-Property<StyleList<StylePropertyName>, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BCCD0 Offset: 0x8BB2D0 VA: 0x1808BCCD0
	|-Property<StyleList<StylePropertyName>, object>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C1B90 Offset: 0x8C0190 VA: 0x1808C1B90
	|-Property<StyleList<TimeValue>, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C1DD0 Offset: 0x8C03D0 VA: 0x1808C1DD0
	|-Property<StyleList<TimeValue>, object>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BEA10 Offset: 0x8BD010 VA: 0x1808BEA10
	|-Property<Angle, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C0BD0 Offset: 0x8BF1D0 VA: 0x1808C0BD0
	|-Property<Angle, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C0E10 Offset: 0x8BF410 VA: 0x1808C0E10
	|-Property<Background, object>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BFE50 Offset: 0x8BE450 VA: 0x1808BFE50
	|-Property<BackgroundPosition, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C0990 Offset: 0x8BEF90 VA: 0x1808C0990
	|-Property<BackgroundPosition, Length>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BF9D0 Offset: 0x8BDFD0 VA: 0x1808BF9D0
	|-Property<BackgroundRepeat, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C02D0 Offset: 0x8BE8D0 VA: 0x1808C02D0
	|-Property<BackgroundSize, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C1710 Offset: 0x8BFD10 VA: 0x1808C1710
	|-Property<BackgroundSize, Length>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BE7D0 Offset: 0x8BCDD0 VA: 0x1808BE7D0
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BE110 Offset: 0x8BC710 VA: 0x1808BE110
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BCF10 Offset: 0x8BB510 VA: 0x1808BCF10
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BDC90 Offset: 0x8BC290 VA: 0x1808BDC90
	|-Property<Cursor, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C2010 Offset: 0x8C0610 VA: 0x1808C2010
	|-Property<Cursor, object>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C1950 Offset: 0x8BFF50 VA: 0x1808C1950
	|-Property<Cursor, Vector2>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C0750 Offset: 0x8BED50 VA: 0x1808C0750
	|-Property<EasingFunction, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BC3D0 Offset: 0x8BA9D0 VA: 0x1808BC3D0
	|-Property<FontDefinition, object>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BF550 Offset: 0x8BDB50 VA: 0x1808BF550
	|-Property<Length, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C2250 Offset: 0x8C0850 VA: 0x1808C2250
	|-Property<Length, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BE590 Offset: 0x8BCB90 VA: 0x1808BE590
	|-Property<object, StyleEnum<Int32Enum>>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BD810 Offset: 0x8BBE10 VA: 0x1808BD810
	|-Property<object, StyleList<EasingFunction>>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BC850 Offset: 0x8BAE50 VA: 0x1808BC850
	|-Property<object, StyleList<StylePropertyName>>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BD5D0 Offset: 0x8BBBD0 VA: 0x1808BD5D0
	|-Property<object, StyleList<TimeValue>>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BF790 Offset: 0x8BDD90 VA: 0x1808BF790
	|-Property<object, Background>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BD390 Offset: 0x8BB990 VA: 0x1808BD390
	|-Property<object, BackgroundPosition>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C0510 Offset: 0x8BEB10 VA: 0x1808C0510
	|-Property<object, BackgroundRepeat>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C0090 Offset: 0x8BE690 VA: 0x1808C0090
	|-Property<object, BackgroundSize>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C1290 Offset: 0x8BF890 VA: 0x1808C1290
	|-Property<object, Color>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BF0D0 Offset: 0x8BD6D0 VA: 0x1808BF0D0
	|-Property<object, EasingFunction>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BE350 Offset: 0x8BC950 VA: 0x1808BE350
	|-Property<object, FontDefinition>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BDED0 Offset: 0x8BC4D0 VA: 0x1808BDED0
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BEC50 Offset: 0x8BD250 VA: 0x1808BEC50
	|-Property<object, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BBF50 Offset: 0x8BA550 VA: 0x1808BBF50
	|-Property<object, object>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BF310 Offset: 0x8BD910 VA: 0x1808BF310
	|-Property<object, Rotate>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BD150 Offset: 0x8BB750 VA: 0x1808BD150
	|-Property<object, Scale>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BFC10 Offset: 0x8BE210 VA: 0x1808BFC10
	|-Property<object, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BDA50 Offset: 0x8BC050 VA: 0x1808BDA50
	|-Property<object, StyleBackground>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8BEE90 Offset: 0x8BD490 VA: 0x1808BEE90
	|-Property<object, StyleBackgroundPosition>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8C14D0 Offset: 0x8BFAD0 VA: 0x1808C14D0
	|-Property<object, StyleBackgroundRepeat>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CEB70 Offset: 0x8CD170 VA: 0x1808CEB70
	|-Property<object, StyleBackgroundSize>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CC0B0 Offset: 0x8CA6B0 VA: 0x1808CC0B0
	|-Property<object, StyleColor>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CE4B0 Offset: 0x8CCAB0 VA: 0x1808CE4B0
	|-Property<object, StyleCursor>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CC770 Offset: 0x8CAD70 VA: 0x1808CC770
	|-Property<object, StyleFloat>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D13F0 Offset: 0x8CF9F0 VA: 0x1808D13F0
	|-Property<object, StyleFont>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D0430 Offset: 0x8CEA30 VA: 0x1808D0430
	|-Property<object, StyleFontDefinition>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CE270 Offset: 0x8CC870 VA: 0x1808CE270
	|-Property<object, StyleInt>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D0F70 Offset: 0x8CF570 VA: 0x1808D0F70
	|-Property<object, StyleLength>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D3A30 Offset: 0x8D2030 VA: 0x1808D3A30
	|-Property<object, StylePropertyName>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CD070 Offset: 0x8CB670 VA: 0x1808CD070
	|-Property<object, StyleRotate>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D11B0 Offset: 0x8CF7B0 VA: 0x1808D11B0
	|-Property<object, StyleScale>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D3370 Offset: 0x8D1970 VA: 0x1808D3370
	|-Property<object, StyleTextShadow>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D2A70 Offset: 0x8D1070 VA: 0x1808D2A70
	|-Property<object, StyleTransformOrigin>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CCBF0 Offset: 0x8CB1F0 VA: 0x1808CCBF0
	|-Property<object, StyleTranslate>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D4330 Offset: 0x8D2930 VA: 0x1808D4330
	|-Property<object, TimeValue>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D5530 Offset: 0x8D3B30 VA: 0x1808D5530
	|-Property<object, Vector3>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CF230 Offset: 0x8CD830 VA: 0x1808CF230
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D4C30 Offset: 0x8D3230 VA: 0x1808D4C30
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CFFB0 Offset: 0x8CE5B0 VA: 0x1808CFFB0
	|-Property<Rotate, Angle>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CE6F0 Offset: 0x8CCCF0 VA: 0x1808CE6F0
	|-Property<Rotate, Vector3>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D5770 Offset: 0x8D3D70 VA: 0x1808D5770
	|-Property<Scale, Vector3>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CEDB0 Offset: 0x8CD3B0 VA: 0x1808CEDB0
	|-Property<StyleBackground, Background>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D47B0 Offset: 0x8D2DB0 VA: 0x1808D47B0
	|-Property<StyleBackground, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CF6B0 Offset: 0x8CDCB0 VA: 0x1808CF6B0
	|-Property<StyleBackgroundPosition, BackgroundPosition>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D1CF0 Offset: 0x8D02F0 VA: 0x1808D1CF0
	|-Property<StyleBackgroundPosition, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CD730 Offset: 0x8CBD30 VA: 0x1808CD730
	|-Property<StyleBackgroundRepeat, BackgroundRepeat>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D49F0 Offset: 0x8D2FF0 VA: 0x1808D49F0
	|-Property<StyleBackgroundRepeat, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CCE30 Offset: 0x8CB430 VA: 0x1808CCE30
	|-Property<StyleBackgroundSize, BackgroundSize>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CDBB0 Offset: 0x8CC1B0 VA: 0x1808CDBB0
	|-Property<StyleBackgroundSize, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CD2B0 Offset: 0x8CB8B0 VA: 0x1808CD2B0
	|-Property<StyleColor, Color>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D1F30 Offset: 0x8D0530 VA: 0x1808D1F30
	|-Property<StyleColor, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D2EF0 Offset: 0x8D14F0 VA: 0x1808D2EF0
	|-Property<StyleCursor, Cursor>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D0670 Offset: 0x8CEC70 VA: 0x1808D0670
	|-Property<StyleCursor, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D2830 Offset: 0x8D0E30 VA: 0x1808D2830
	|-Property<StyleFloat, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CE030 Offset: 0x8CC630 VA: 0x1808CE030
	|-Property<StyleFloat, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CBE70 Offset: 0x8CA470 VA: 0x1808CBE70
	|-Property<StyleFont, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D35B0 Offset: 0x8D1BB0 VA: 0x1808D35B0
	|-Property<StyleFont, object>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D1630 Offset: 0x8CFC30 VA: 0x1808D1630
	|-Property<StyleFontDefinition, FontDefinition>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D4E70 Offset: 0x8D3470 VA: 0x1808D4E70
	|-Property<StyleFontDefinition, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CDDF0 Offset: 0x8CC3F0 VA: 0x1808CDDF0
	|-Property<StyleInt, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CC2F0 Offset: 0x8CA8F0 VA: 0x1808CC2F0
	|-Property<StyleInt, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D59B0 Offset: 0x8D3FB0 VA: 0x1808D59B0
	|-Property<StyleLength, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D2CB0 Offset: 0x8D12B0 VA: 0x1808D2CB0
	|-Property<StyleLength, Length>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CF470 Offset: 0x8CDA70 VA: 0x1808CF470
	|-Property<StylePropertyName, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D40F0 Offset: 0x8D26F0 VA: 0x1808D40F0
	|-Property<StylePropertyName, object>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D0AF0 Offset: 0x8CF0F0 VA: 0x1808D0AF0
	|-Property<StyleRotate, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D23B0 Offset: 0x8D09B0 VA: 0x1808D23B0
	|-Property<StyleRotate, Rotate>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D2170 Offset: 0x8D0770 VA: 0x1808D2170
	|-Property<StyleScale, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CC9B0 Offset: 0x8CAFB0 VA: 0x1808CC9B0
	|-Property<StyleScale, Scale>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CF8F0 Offset: 0x8CDEF0 VA: 0x1808CF8F0
	|-Property<StyleTextShadow, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D01F0 Offset: 0x8CE7F0 VA: 0x1808D01F0
	|-Property<StyleTextShadow, TextShadow>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CFB30 Offset: 0x8CE130 VA: 0x1808CFB30
	|-Property<StyleTransformOrigin, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CD970 Offset: 0x8CBF70 VA: 0x1808CD970
	|-Property<StyleTransformOrigin, TransformOrigin>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D52F0 Offset: 0x8D38F0 VA: 0x1808D52F0
	|-Property<StyleTranslate, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CD4F0 Offset: 0x8CBAF0 VA: 0x1808CD4F0
	|-Property<StyleTranslate, Translate>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D37F0 Offset: 0x8D1DF0 VA: 0x1808D37F0
	|-Property<TextShadow, Color>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CE930 Offset: 0x8CCF30 VA: 0x1808CE930
	|-Property<TextShadow, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D3EB0 Offset: 0x8D24B0 VA: 0x1808D3EB0
	|-Property<TextShadow, Vector2>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D3C70 Offset: 0x8D2270 VA: 0x1808D3C70
	|-Property<TimeValue, Int32Enum>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D50B0 Offset: 0x8D36B0 VA: 0x1808D50B0
	|-Property<TimeValue, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CC530 Offset: 0x8CAB30 VA: 0x1808CC530
	|-Property<TransformOrigin, Length>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D3130 Offset: 0x8D1730 VA: 0x1808D3130
	|-Property<TransformOrigin, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D08B0 Offset: 0x8CEEB0 VA: 0x1808D08B0
	|-Property<Translate, Length>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CEFF0 Offset: 0x8CD5F0 VA: 0x1808CEFF0
	|-Property<Translate, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D4570 Offset: 0x8D2B70 VA: 0x1808D4570
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D0D30 Offset: 0x8CF330 VA: 0x1808D0D30
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D1AB0 Offset: 0x8D00B0 VA: 0x1808D1AB0
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D25F0 Offset: 0x8D0BF0 VA: 0x1808D25F0
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8CFD70 Offset: 0x8CE370 VA: 0x1808CFD70
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.AddAttributes
	|
	|-RVA: 0x8D1870 Offset: 0x8CFE70 VA: 0x1808D1870
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool HasAttribute<TAttribute>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x607550 Offset: 0x605B50 VA: 0x180607550
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.HasAttribute<object>
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public TAttribute GetAttribute<TAttribute>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x607430 Offset: 0x605A30 VA: 0x180607430
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private AttributesScope Unity.Properties.Internal.IAttributes.CreateAttributesScope(IAttributes attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8C2990 Offset: 0x8C0F90 VA: 0x1808C2990
	|-Property<StyleEnum<Int32Enum>, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2E90 Offset: 0x8C1490 VA: 0x1808C2E90
	|-Property<StyleList<EasingFunction>, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3310 Offset: 0x8C1910 VA: 0x1808C3310
	|-Property<StyleList<EasingFunction>, object>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3A10 Offset: 0x8C2010 VA: 0x1808C3A10
	|-Property<StyleList<StylePropertyName>, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3190 Offset: 0x8C1790 VA: 0x1808C3190
	|-Property<StyleList<StylePropertyName>, object>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2A10 Offset: 0x8C1010 VA: 0x1808C2A10
	|-Property<StyleList<TimeValue>, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3690 Offset: 0x8C1C90 VA: 0x1808C3690
	|-Property<StyleList<TimeValue>, object>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3810 Offset: 0x8C1E10 VA: 0x1808C3810
	|-Property<Angle, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2690 Offset: 0x8C0C90 VA: 0x1808C2690
	|-Property<Angle, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2C90 Offset: 0x8C1290 VA: 0x1808C2C90
	|-Property<Background, object>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3290 Offset: 0x8C1890 VA: 0x1808C3290
	|-Property<BackgroundPosition, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2A90 Offset: 0x8C1090 VA: 0x1808C2A90
	|-Property<BackgroundPosition, Length>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3A90 Offset: 0x8C2090 VA: 0x1808C3A90
	|-Property<BackgroundRepeat, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3490 Offset: 0x8C1A90 VA: 0x1808C3490
	|-Property<BackgroundSize, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3410 Offset: 0x8C1A10 VA: 0x1808C3410
	|-Property<BackgroundSize, Length>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3110 Offset: 0x8C1710 VA: 0x1808C3110
	|-Property<Bounds, Vector3>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2790 Offset: 0x8C0D90 VA: 0x1808C2790
	|-Property<BoundsInt, Vector3Int>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2F90 Offset: 0x8C1590 VA: 0x1808C2F90
	|-Property<Color, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2C10 Offset: 0x8C1210 VA: 0x1808C2C10
	|-Property<Cursor, int>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2D90 Offset: 0x8C1390 VA: 0x1808C2D90
	|-Property<Cursor, object>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3210 Offset: 0x8C1810 VA: 0x1808C3210
	|-Property<Cursor, Vector2>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2910 Offset: 0x8C0F10 VA: 0x1808C2910
	|-Property<EasingFunction, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2710 Offset: 0x8C0D10 VA: 0x1808C2710
	|-Property<FontDefinition, object>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2810 Offset: 0x8C0E10 VA: 0x1808C2810
	|-Property<Length, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2F10 Offset: 0x8C1510 VA: 0x1808C2F10
	|-Property<Length, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3510 Offset: 0x8C1B10 VA: 0x1808C3510
	|-Property<object, StyleEnum<Int32Enum>>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3590 Offset: 0x8C1B90 VA: 0x1808C3590
	|-Property<object, StyleList<EasingFunction>>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2B10 Offset: 0x8C1110 VA: 0x1808C2B10
	|-Property<object, StyleList<StylePropertyName>>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2610 Offset: 0x8C0C10 VA: 0x1808C2610
	|-Property<object, StyleList<TimeValue>>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3090 Offset: 0x8C1690 VA: 0x1808C3090
	|-Property<object, Background>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3990 Offset: 0x8C1F90 VA: 0x1808C3990
	|-Property<object, BackgroundPosition>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2510 Offset: 0x8C0B10 VA: 0x1808C2510
	|-Property<object, BackgroundRepeat>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2590 Offset: 0x8C0B90 VA: 0x1808C2590
	|-Property<object, BackgroundSize>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3610 Offset: 0x8C1C10 VA: 0x1808C3610
	|-Property<object, Color>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2D10 Offset: 0x8C1310 VA: 0x1808C2D10
	|-Property<object, EasingFunction>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2490 Offset: 0x8C0A90 VA: 0x1808C2490
	|-Property<object, FontDefinition>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3710 Offset: 0x8C1D10 VA: 0x1808C3710
	|-Property<object, int>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2E10 Offset: 0x8C1410 VA: 0x1808C2E10
	|-Property<object, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3390 Offset: 0x8C1990 VA: 0x1808C3390
	|-Property<object, object>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3010 Offset: 0x8C1610 VA: 0x1808C3010
	|-Property<object, Rotate>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3790 Offset: 0x8C1D90 VA: 0x1808C3790
	|-Property<object, Scale>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3890 Offset: 0x8C1E90 VA: 0x1808C3890
	|-Property<object, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2890 Offset: 0x8C0E90 VA: 0x1808C2890
	|-Property<object, StyleBackground>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C3910 Offset: 0x8C1F10 VA: 0x1808C3910
	|-Property<object, StyleBackgroundPosition>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8C2B90 Offset: 0x8C1190 VA: 0x1808C2B90
	|-Property<object, StyleBackgroundRepeat>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D5D70 Offset: 0x8D4370 VA: 0x1808D5D70
	|-Property<object, StyleBackgroundSize>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6A70 Offset: 0x8D5070 VA: 0x1808D6A70
	|-Property<object, StyleColor>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6270 Offset: 0x8D4870 VA: 0x1808D6270
	|-Property<object, StyleCursor>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7270 Offset: 0x8D5870 VA: 0x1808D7270
	|-Property<object, StyleFloat>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D69F0 Offset: 0x8D4FF0 VA: 0x1808D69F0
	|-Property<object, StyleFont>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D70F0 Offset: 0x8D56F0 VA: 0x1808D70F0
	|-Property<object, StyleFontDefinition>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D65F0 Offset: 0x8D4BF0 VA: 0x1808D65F0
	|-Property<object, StyleInt>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D61F0 Offset: 0x8D47F0 VA: 0x1808D61F0
	|-Property<object, StyleLength>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6E70 Offset: 0x8D5470 VA: 0x1808D6E70
	|-Property<object, StylePropertyName>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6670 Offset: 0x8D4C70 VA: 0x1808D6670
	|-Property<object, StyleRotate>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6EF0 Offset: 0x8D54F0 VA: 0x1808D6EF0
	|-Property<object, StyleScale>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6D70 Offset: 0x8D5370 VA: 0x1808D6D70
	|-Property<object, StyleTextShadow>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D5CF0 Offset: 0x8D42F0 VA: 0x1808D5CF0
	|-Property<object, StyleTransformOrigin>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7770 Offset: 0x8D5D70 VA: 0x1808D7770
	|-Property<object, StyleTranslate>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D79F0 Offset: 0x8D5FF0 VA: 0x1808D79F0
	|-Property<object, TimeValue>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7D70 Offset: 0x8D6370 VA: 0x1808D7D70
	|-Property<object, Vector3>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6170 Offset: 0x8D4770 VA: 0x1808D6170
	|-Property<Rect, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D5FF0 Offset: 0x8D45F0 VA: 0x1808D5FF0
	|-Property<RectInt, int>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D5DF0 Offset: 0x8D43F0 VA: 0x1808D5DF0
	|-Property<Rotate, Angle>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6970 Offset: 0x8D4F70 VA: 0x1808D6970
	|-Property<Rotate, Vector3>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7470 Offset: 0x8D5A70 VA: 0x1808D7470
	|-Property<Scale, Vector3>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D64F0 Offset: 0x8D4AF0 VA: 0x1808D64F0
	|-Property<StyleBackground, Background>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D78F0 Offset: 0x8D5EF0 VA: 0x1808D78F0
	|-Property<StyleBackground, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6F70 Offset: 0x8D5570 VA: 0x1808D6F70
	|-Property<StyleBackgroundPosition, BackgroundPosition>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7C70 Offset: 0x8D6270 VA: 0x1808D7C70
	|-Property<StyleBackgroundPosition, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D5F70 Offset: 0x8D4570 VA: 0x1808D5F70
	|-Property<StyleBackgroundRepeat, BackgroundRepeat>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D74F0 Offset: 0x8D5AF0 VA: 0x1808D74F0
	|-Property<StyleBackgroundRepeat, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7BF0 Offset: 0x8D61F0 VA: 0x1808D7BF0
	|-Property<StyleBackgroundSize, BackgroundSize>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D71F0 Offset: 0x8D57F0 VA: 0x1808D71F0
	|-Property<StyleBackgroundSize, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7070 Offset: 0x8D5670 VA: 0x1808D7070
	|-Property<StyleColor, Color>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D5C70 Offset: 0x8D4270 VA: 0x1808D5C70
	|-Property<StyleColor, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6470 Offset: 0x8D4A70 VA: 0x1808D6470
	|-Property<StyleCursor, Cursor>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7AF0 Offset: 0x8D60F0 VA: 0x1808D7AF0
	|-Property<StyleCursor, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7B70 Offset: 0x8D6170 VA: 0x1808D7B70
	|-Property<StyleFloat, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D63F0 Offset: 0x8D49F0 VA: 0x1808D63F0
	|-Property<StyleFloat, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7870 Offset: 0x8D5E70 VA: 0x1808D7870
	|-Property<StyleFont, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7170 Offset: 0x8D5770 VA: 0x1808D7170
	|-Property<StyleFont, object>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6370 Offset: 0x8D4970 VA: 0x1808D6370
	|-Property<StyleFontDefinition, FontDefinition>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7670 Offset: 0x8D5C70 VA: 0x1808D7670
	|-Property<StyleFontDefinition, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D67F0 Offset: 0x8D4DF0 VA: 0x1808D67F0
	|-Property<StyleInt, int>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6870 Offset: 0x8D4E70 VA: 0x1808D6870
	|-Property<StyleInt, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D5EF0 Offset: 0x8D44F0 VA: 0x1808D5EF0
	|-Property<StyleLength, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7570 Offset: 0x8D5B70 VA: 0x1808D7570
	|-Property<StyleLength, Length>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6570 Offset: 0x8D4B70 VA: 0x1808D6570
	|-Property<StylePropertyName, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D75F0 Offset: 0x8D5BF0 VA: 0x1808D75F0
	|-Property<StylePropertyName, object>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D60F0 Offset: 0x8D46F0 VA: 0x1808D60F0
	|-Property<StyleRotate, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D66F0 Offset: 0x8D4CF0 VA: 0x1808D66F0
	|-Property<StyleRotate, Rotate>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7CF0 Offset: 0x8D62F0 VA: 0x1808D7CF0
	|-Property<StyleScale, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D73F0 Offset: 0x8D59F0 VA: 0x1808D73F0
	|-Property<StyleScale, Scale>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6CF0 Offset: 0x8D52F0 VA: 0x1808D6CF0
	|-Property<StyleTextShadow, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D5E70 Offset: 0x8D4470 VA: 0x1808D5E70
	|-Property<StyleTextShadow, TextShadow>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6AF0 Offset: 0x8D50F0 VA: 0x1808D6AF0
	|-Property<StyleTransformOrigin, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7DF0 Offset: 0x8D63F0 VA: 0x1808D7DF0
	|-Property<StyleTransformOrigin, TransformOrigin>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6070 Offset: 0x8D4670 VA: 0x1808D6070
	|-Property<StyleTranslate, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D62F0 Offset: 0x8D48F0 VA: 0x1808D62F0
	|-Property<StyleTranslate, Translate>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D72F0 Offset: 0x8D58F0 VA: 0x1808D72F0
	|-Property<TextShadow, Color>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D68F0 Offset: 0x8D4EF0 VA: 0x1808D68F0
	|-Property<TextShadow, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6DF0 Offset: 0x8D53F0 VA: 0x1808D6DF0
	|-Property<TextShadow, Vector2>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7370 Offset: 0x8D5970 VA: 0x1808D7370
	|-Property<TimeValue, Int32Enum>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7E70 Offset: 0x8D6470 VA: 0x1808D7E70
	|-Property<TimeValue, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6B70 Offset: 0x8D5170 VA: 0x1808D6B70
	|-Property<TransformOrigin, Length>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6BF0 Offset: 0x8D51F0 VA: 0x1808D6BF0
	|-Property<TransformOrigin, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D77F0 Offset: 0x8D5DF0 VA: 0x1808D77F0
	|-Property<Translate, Length>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7A70 Offset: 0x8D6070 VA: 0x1808D7A70
	|-Property<Translate, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6FF0 Offset: 0x8D55F0 VA: 0x1808D6FF0
	|-Property<Vector2, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D76F0 Offset: 0x8D5CF0 VA: 0x1808D76F0
	|-Property<Vector2Int, int>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D7970 Offset: 0x8D5F70 VA: 0x1808D7970
	|-Property<Vector3, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D5BF0 Offset: 0x8D41F0 VA: 0x1808D5BF0
	|-Property<Vector3Int, int>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6770 Offset: 0x8D4D70 VA: 0x1808D6770
	|-Property<Vector4, float>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	|
	|-RVA: 0x8D6C70 Offset: 0x8D5270 VA: 0x1808D6C70
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.CreateAttributesScope
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-Property<StyleEnum<Int32Enum>, Int32Enum>..ctor
	|-Property<StyleList<EasingFunction>, Int32Enum>..ctor
	|-Property<StyleList<EasingFunction>, object>..ctor
	|-Property<StyleList<StylePropertyName>, Int32Enum>..ctor
	|-Property<StyleList<StylePropertyName>, object>..ctor
	|-Property<StyleList<TimeValue>, Int32Enum>..ctor
	|-Property<StyleList<TimeValue>, object>..ctor
	|-Property<Angle, Int32Enum>..ctor
	|-Property<Angle, float>..ctor
	|-Property<Background, object>..ctor
	|-Property<BackgroundPosition, Int32Enum>..ctor
	|-Property<BackgroundPosition, Length>..ctor
	|-Property<BackgroundRepeat, Int32Enum>..ctor
	|-Property<BackgroundSize, Int32Enum>..ctor
	|-Property<BackgroundSize, Length>..ctor
	|-Property<Bounds, Vector3>..ctor
	|-Property<BoundsInt, Vector3Int>..ctor
	|-Property<Color, float>..ctor
	|-Property<Cursor, int>..ctor
	|-Property<Cursor, object>..ctor
	|-Property<Cursor, Vector2>..ctor
	|-Property<EasingFunction, Int32Enum>..ctor
	|-Property<FontDefinition, object>..ctor
	|-Property<Length, Int32Enum>..ctor
	|-Property<Length, float>..ctor
	|-Property<object, StyleEnum<Int32Enum>>..ctor
	|-Property<object, StyleList<EasingFunction>>..ctor
	|-Property<object, StyleList<StylePropertyName>>..ctor
	|-Property<object, StyleList<TimeValue>>..ctor
	|-Property<object, Background>..ctor
	|-Property<object, BackgroundPosition>..ctor
	|-Property<object, BackgroundRepeat>..ctor
	|-Property<object, BackgroundSize>..ctor
	|-Property<object, Color>..ctor
	|-Property<object, EasingFunction>..ctor
	|-Property<object, FontDefinition>..ctor
	|-Property<object, int>..ctor
	|-Property<object, Int32Enum>..ctor
	|-Property<object, object>..ctor
	|-Property<object, Rotate>..ctor
	|-Property<object, Scale>..ctor
	|-Property<object, float>..ctor
	|-Property<object, StyleBackground>..ctor
	|-Property<object, StyleBackgroundPosition>..ctor
	|-Property<object, StyleBackgroundRepeat>..ctor
	|-Property<object, StyleBackgroundSize>..ctor
	|-Property<object, StyleColor>..ctor
	|-Property<object, StyleCursor>..ctor
	|-Property<object, StyleFloat>..ctor
	|-Property<object, StyleFont>..ctor
	|-Property<object, StyleFontDefinition>..ctor
	|-Property<object, StyleInt>..ctor
	|-Property<object, StyleLength>..ctor
	|-Property<object, StylePropertyName>..ctor
	|-Property<object, StyleRotate>..ctor
	|-Property<object, StyleScale>..ctor
	|-Property<object, StyleTextShadow>..ctor
	|-Property<object, StyleTransformOrigin>..ctor
	|-Property<object, StyleTranslate>..ctor
	|-Property<object, TimeValue>..ctor
	|-Property<object, Vector3>..ctor
	|-Property<Rect, float>..ctor
	|-Property<RectInt, int>..ctor
	|-Property<Rotate, Angle>..ctor
	|-Property<Rotate, Vector3>..ctor
	|-Property<Scale, Vector3>..ctor
	|-Property<StyleBackground, Background>..ctor
	|-Property<StyleBackground, Int32Enum>..ctor
	|-Property<StyleBackgroundPosition, BackgroundPosition>..ctor
	|-Property<StyleBackgroundPosition, Int32Enum>..ctor
	|-Property<StyleBackgroundRepeat, BackgroundRepeat>..ctor
	|-Property<StyleBackgroundRepeat, Int32Enum>..ctor
	|-Property<StyleBackgroundSize, BackgroundSize>..ctor
	|-Property<StyleBackgroundSize, Int32Enum>..ctor
	|-Property<StyleColor, Color>..ctor
	|-Property<StyleColor, Int32Enum>..ctor
	|-Property<StyleCursor, Cursor>..ctor
	|-Property<StyleCursor, Int32Enum>..ctor
	|-Property<StyleFloat, Int32Enum>..ctor
	|-Property<StyleFloat, float>..ctor
	|-Property<StyleFont, Int32Enum>..ctor
	|-Property<StyleFont, object>..ctor
	|-Property<StyleFontDefinition, FontDefinition>..ctor
	|-Property<StyleFontDefinition, Int32Enum>..ctor
	|-Property<StyleInt, int>..ctor
	|-Property<StyleInt, Int32Enum>..ctor
	|-Property<StyleLength, Int32Enum>..ctor
	|-Property<StyleLength, Length>..ctor
	|-Property<StylePropertyName, Int32Enum>..ctor
	|-Property<StylePropertyName, object>..ctor
	|-Property<StyleRotate, Int32Enum>..ctor
	|-Property<StyleRotate, Rotate>..ctor
	|-Property<StyleScale, Int32Enum>..ctor
	|-Property<StyleScale, Scale>..ctor
	|-Property<StyleTextShadow, Int32Enum>..ctor
	|-Property<StyleTextShadow, TextShadow>..ctor
	|-Property<StyleTransformOrigin, Int32Enum>..ctor
	|-Property<StyleTransformOrigin, TransformOrigin>..ctor
	|-Property<StyleTranslate, Int32Enum>..ctor
	|-Property<StyleTranslate, Translate>..ctor
	|-Property<TextShadow, Color>..ctor
	|-Property<TextShadow, float>..ctor
	|-Property<TextShadow, Vector2>..ctor
	|-Property<TimeValue, Int32Enum>..ctor
	|-Property<TimeValue, float>..ctor
	|-Property<TransformOrigin, Length>..ctor
	|-Property<TransformOrigin, float>..ctor
	|-Property<Translate, Length>..ctor
	|-Property<Translate, float>..ctor
	|-Property<Vector2, float>..ctor
	|-Property<Vector2Int, int>..ctor
	|-Property<Vector3, float>..ctor
	|-Property<Vector3Int, int>..ctor
	|-Property<Vector4, float>..ctor
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public enum PropertyPathPartKind // TypeDefIndex: 12929
{
	// Fields
	public int value__; // 0x0
	public const PropertyPathPartKind Name = 0;
	public const PropertyPathPartKind Index = 1;
	public const PropertyPathPartKind Key = 2;
}

// Namespace: Unity.Properties
[IsReadOnly]
public struct PropertyPathPart : IEquatable<PropertyPathPart> // TypeDefIndex: 12930
{
	// Fields
	private readonly PropertyPathPartKind m_Kind; // 0x0
	private readonly string m_Name; // 0x8
	private readonly int m_Index; // 0x10
	private readonly object m_Key; // 0x18

	// Properties
	public bool IsName { get; }
	public bool IsIndex { get; }
	public PropertyPathPartKind Kind { get; }
	public string Name { get; }
	public int Index { get; }
	public object Key { get; }

	// Methods

	// RVA: 0x1BA5800 Offset: 0x1BA3E00 VA: 0x181BA5800
	public bool get_IsName() { }

	// RVA: 0x23D56F0 Offset: 0x23D3CF0 VA: 0x1823D56F0
	public bool get_IsIndex() { }

	// RVA: 0x591000 Offset: 0x58F600 VA: 0x180591000
	public PropertyPathPartKind get_Kind() { }

	// RVA: 0x23D5760 Offset: 0x23D3D60 VA: 0x1823D5760
	public string get_Name() { }

	// RVA: 0x23D5690 Offset: 0x23D3C90 VA: 0x1823D5690
	public int get_Index() { }

	// RVA: 0x23D5700 Offset: 0x23D3D00 VA: 0x1823D5700
	public object get_Key() { }

	// RVA: 0x23D5650 Offset: 0x23D3C50 VA: 0x1823D5650
	public void .ctor(string name) { }

	// RVA: 0x23D55F0 Offset: 0x23D3BF0 VA: 0x1823D55F0
	public void .ctor(int index) { }

	// RVA: 0x23D5590 Offset: 0x23D3B90 VA: 0x1823D5590
	public void .ctor(object key) { }

	// RVA: 0x23D5250 Offset: 0x23D3850 VA: 0x1823D5250
	private void CheckKind(PropertyPathPartKind type) { }

	// RVA: 0x23D5480 Offset: 0x23D3A80 VA: 0x1823D5480 Slot: 3
	public override string ToString() { }

	// RVA: 0x23D5360 Offset: 0x23D3960 VA: 0x1823D5360 Slot: 4
	public bool Equals(PropertyPathPart other) { }

	// RVA: 0x23D52A0 Offset: 0x23D38A0 VA: 0x1823D52A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23D53D0 Offset: 0x23D39D0 VA: 0x1823D53D0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Unity.Properties
[IsReadOnly]
[DefaultMember("Item")]
public struct PropertyPath : IEquatable<PropertyPath> // TypeDefIndex: 12932
{
	// Fields
	internal const int k_InlineCount = 4;
	private readonly PropertyPathPart m_Part0; // 0x0
	private readonly PropertyPathPart m_Part1; // 0x20
	private readonly PropertyPathPart m_Part2; // 0x40
	private readonly PropertyPathPart m_Part3; // 0x60
	private readonly PropertyPathPart[] m_AdditionalParts; // 0x80
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; // 0x88

	// Properties
	public int Length { get; }
	public bool IsEmpty { get; }
	public PropertyPathPart Item { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3AAB90 Offset: 0x3A9190 VA: 0x1803AAB90
	public int get_Length() { }

	// RVA: 0x23D9600 Offset: 0x23D7C00 VA: 0x1823D9600
	public bool get_IsEmpty() { }

	// RVA: 0x23D9610 Offset: 0x23D7C10 VA: 0x1823D9610
	public PropertyPathPart get_Item(int index) { }

	// RVA: 0x23D9140 Offset: 0x23D7740 VA: 0x1823D9140
	public void .ctor(string path) { }

	// RVA: 0x23D9040 Offset: 0x23D7640 VA: 0x1823D9040
	private void .ctor(in PropertyPathPart part) { }

	// RVA: 0x23D90B0 Offset: 0x23D76B0 VA: 0x1823D90B0
	private void .ctor(in PropertyPathPart part0, in PropertyPathPart part1) { }

	// RVA: 0x23D9250 Offset: 0x23D7850 VA: 0x1823D9250
	private void .ctor(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2) { }

	// RVA: 0x23D9540 Offset: 0x23D7B40 VA: 0x1823D9540
	private void .ctor(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2, in PropertyPathPart part3) { }

	// RVA: 0x23D9300 Offset: 0x23D7900 VA: 0x1823D9300
	internal void .ctor(List<PropertyPathPart> parts) { }

	// RVA: 0x23D7D00 Offset: 0x23D6300 VA: 0x1823D7D00
	public static PropertyPath FromIndex(int index) { }

	// RVA: 0x23D61B0 Offset: 0x23D47B0 VA: 0x1823D61B0
	public static PropertyPath Combine(in PropertyPath path, in PropertyPath pathToAppend) { }

	// RVA: 0x23D58C0 Offset: 0x23D3EC0 VA: 0x1823D58C0
	public static PropertyPath AppendPart(in PropertyPath path, in PropertyPathPart part) { }

	// RVA: 0x23D57C0 Offset: 0x23D3DC0 VA: 0x1823D57C0
	public static PropertyPath AppendIndex(in PropertyPath path, int index) { }

	// RVA: 0x23D5DD0 Offset: 0x23D43D0 VA: 0x1823D5DD0
	public static PropertyPath AppendProperty(in PropertyPath path, IProperty property) { }

	// RVA: 0x23D80D0 Offset: 0x23D66D0 VA: 0x1823D80D0
	public static PropertyPath Pop(in PropertyPath path) { }

	// RVA: 0x23D8160 Offset: 0x23D6760 VA: 0x1823D8160
	public static PropertyPath SubPath(in PropertyPath path, int startIndex, int length) { }

	// RVA: 0x23D8BC0 Offset: 0x23D71C0 VA: 0x1823D8BC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x23D60F0 Offset: 0x23D46F0 VA: 0x1823D60F0
	private static void AppendToBuilder(in PropertyPathPart part, StringBuilder builder) { }

	// RVA: 0x23D7FB0 Offset: 0x23D65B0 VA: 0x1823D7FB0
	private static void GetParts(in PropertyPath path, List<PropertyPathPart> parts) { }

	// RVA: 0x23D68D0 Offset: 0x23D4ED0 VA: 0x1823D68D0
	private static PropertyPath ConstructFromPath(string path) { }

	// RVA: 0x23D9810 Offset: 0x23D7E10 VA: 0x1823D9810
	public static bool op_Equality(PropertyPath lhs, PropertyPath rhs) { }

	// RVA: 0x23D9880 Offset: 0x23D7E80 VA: 0x1823D9880
	public static bool op_Inequality(PropertyPath lhs, PropertyPath rhs) { }

	// RVA: 0x23D7A80 Offset: 0x23D6080 VA: 0x1823D7A80 Slot: 4
	public bool Equals(PropertyPath other) { }

	// RVA: 0x23D7B90 Offset: 0x23D6190 VA: 0x1823D7B90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23D7DF0 Offset: 0x23D63F0 VA: 0x1823D7DF0 Slot: 2
	public override int GetHashCode() { }

	[CompilerGenerated]
	// RVA: 0x23D8FF0 Offset: 0x23D75F0 VA: 0x1823D8FF0
	internal static void <ConstructFromPath>g__TrimStart|36_0(ref PropertyPath.<>c__DisplayClass36_0 ) { }

	[CompilerGenerated]
	// RVA: 0x23D8EA0 Offset: 0x23D74A0 VA: 0x1823D8EA0
	internal static void <ConstructFromPath>g__ReadNext|36_1(ref PropertyPath.<>c__DisplayClass36_0 ) { }
}

// Namespace: Unity.Properties
internal interface IMemberInfo // TypeDefIndex: 12933
{
	// Properties
	public abstract string Name { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type ValueType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract object GetValue(object obj);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetValue(object obj, object value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IEnumerable<Attribute> GetCustomAttributes();
}

// Namespace: Unity.Properties
[IsReadOnly]
internal struct FieldMember : IMemberInfo // TypeDefIndex: 12934
{
	// Fields
	internal readonly FieldInfo m_FieldInfo; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	// RVA: 0x23BC020 Offset: 0x23BA620 VA: 0x1823BC020
	public void .ctor(FieldInfo fieldInfo) { }

	[CompilerGenerated]
	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0 Slot: 4
	public string get_Name() { }

	// RVA: 0x23BC050 Offset: 0x23BA650 VA: 0x1823BC050 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x23BC070 Offset: 0x23BA670 VA: 0x1823BC070 Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x23BBFD0 Offset: 0x23BA5D0 VA: 0x1823BBFD0 Slot: 7
	public object GetValue(object obj) { }

	// RVA: 0x23BC000 Offset: 0x23BA600 VA: 0x1823BC000 Slot: 8
	public void SetValue(object obj, object value) { }

	// RVA: 0x23BBFC0 Offset: 0x23BA5C0 VA: 0x1823BBFC0 Slot: 9
	public IEnumerable<Attribute> GetCustomAttributes() { }
}

// Namespace: Unity.Properties
[IsReadOnly]
internal struct PropertyMember : IMemberInfo // TypeDefIndex: 12935
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0 Slot: 4
	public string get_Name() { }

	// RVA: 0x23D51F0 Offset: 0x23D37F0 VA: 0x1823D51F0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x23D5220 Offset: 0x23D3820 VA: 0x1823D5220 Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x23BC020 Offset: 0x23BA620 VA: 0x1823BC020
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x23D51B0 Offset: 0x23D37B0 VA: 0x1823D51B0 Slot: 7
	public object GetValue(object obj) { }

	// RVA: 0x23D51D0 Offset: 0x23D37D0 VA: 0x1823D51D0 Slot: 8
	public void SetValue(object obj, object value) { }

	// RVA: 0x23BBFC0 Offset: 0x23BA5C0 VA: 0x1823BBFC0 Slot: 9
	public IEnumerable<Attribute> GetCustomAttributes() { }
}

// Namespace: Unity.Properties
public class ReflectedMemberProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 12940
{
	// Fields
	private readonly IMemberInfo m_Info; // 0x0
	private readonly bool m_IsStructContainerType; // 0x0
	private ReflectedMemberProperty.GetStructValueAction<TContainer, TValue> m_GetStructValueAction; // 0x0
	private ReflectedMemberProperty.SetStructValueAction<TContainer, TValue> m_SetStructValueAction; // 0x0
	private ReflectedMemberProperty.GetClassValueAction<TContainer, TValue> m_GetClassValueAction; // 0x0
	private ReflectedMemberProperty.SetClassValueAction<TContainer, TValue> m_SetClassValueAction; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <IsReadOnly>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }
	public override bool IsReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 12
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 13
	public override bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95D0B0 Offset: 0x95B6B0 VA: 0x18095D0B0
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IMemberInfo info, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95C930 Offset: 0x95AF30 VA: 0x18095C930
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override TValue GetValue(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95C130 Offset: 0x95A730 VA: 0x18095C130
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override void SetValue(ref TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x95C4E0 Offset: 0x95AAE0 VA: 0x18095C4E0
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetValue
	*/
}

// Namespace: Unity.Properties
public sealed class ArrayPropertyBag<TElement> : IndexedCollectionPropertyBag<TElement[], TElement> // TypeDefIndex: 12941
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 25
	protected override TElement[] InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1050A00 Offset: 0x104F000 VA: 0x181050A00
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected override TElement[] Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1050A40 Offset: 0x104F040 VA: 0x181050A40
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x969EF0 Offset: 0x9684F0 VA: 0x180969EF0
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public abstract class ContainerPropertyBag<TContainer> : PropertyBag<TContainer>, INamedProperties<TContainer> // TypeDefIndex: 12942
{
	// Fields
	private readonly List<IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly Dictionary<string, IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B06F0 Offset: 0x8AECF0 VA: 0x1808B06F0
	|-ContainerPropertyBag<StyleEnum<Int32Enum>>..cctor
	|-ContainerPropertyBag<StyleList<EasingFunction>>..cctor
	|-ContainerPropertyBag<StyleList<StylePropertyName>>..cctor
	|-ContainerPropertyBag<StyleList<TimeValue>>..cctor
	|-ContainerPropertyBag<Angle>..cctor
	|-ContainerPropertyBag<Background>..cctor
	|-ContainerPropertyBag<BackgroundPosition>..cctor
	|-ContainerPropertyBag<BackgroundRepeat>..cctor
	|-ContainerPropertyBag<BackgroundSize>..cctor
	|-ContainerPropertyBag<Bounds>..cctor
	|-ContainerPropertyBag<BoundsInt>..cctor
	|-ContainerPropertyBag<Color>..cctor
	|-ContainerPropertyBag<Cursor>..cctor
	|-ContainerPropertyBag<EasingFunction>..cctor
	|-ContainerPropertyBag<FontDefinition>..cctor
	|-ContainerPropertyBag<Length>..cctor
	|-ContainerPropertyBag<object>..cctor
	|-ContainerPropertyBag<Rect>..cctor
	|-ContainerPropertyBag<RectInt>..cctor
	|-ContainerPropertyBag<Rotate>..cctor
	|-ContainerPropertyBag<Scale>..cctor
	|-ContainerPropertyBag<StyleBackground>..cctor
	|-ContainerPropertyBag<StyleBackgroundPosition>..cctor
	|-ContainerPropertyBag<StyleBackgroundRepeat>..cctor
	|-ContainerPropertyBag<StyleBackgroundSize>..cctor
	|-ContainerPropertyBag<StyleColor>..cctor
	|-ContainerPropertyBag<StyleCursor>..cctor
	|-ContainerPropertyBag<StyleFloat>..cctor
	|-ContainerPropertyBag<StyleFont>..cctor
	|-ContainerPropertyBag<StyleFontDefinition>..cctor
	|-ContainerPropertyBag<StyleInt>..cctor
	|-ContainerPropertyBag<StyleLength>..cctor
	|-ContainerPropertyBag<StylePropertyName>..cctor
	|-ContainerPropertyBag<StyleRotate>..cctor
	|-ContainerPropertyBag<StyleScale>..cctor
	|-ContainerPropertyBag<StyleTextShadow>..cctor
	|-ContainerPropertyBag<StyleTransformOrigin>..cctor
	|-ContainerPropertyBag<StyleTranslate>..cctor
	|-ContainerPropertyBag<TextShadow>..cctor
	|-ContainerPropertyBag<TimeValue>..cctor
	|-ContainerPropertyBag<TransformOrigin>..cctor
	|-ContainerPropertyBag<Translate>..cctor
	|-ContainerPropertyBag<Vector2>..cctor
	|-ContainerPropertyBag<Vector2Int>..cctor
	|-ContainerPropertyBag<Vector3>..cctor
	|-ContainerPropertyBag<Vector3Int>..cctor
	|-ContainerPropertyBag<Vector4>..cctor
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	protected void AddProperty<TValue>(Property<TContainer, TValue> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5FD8C0 Offset: 0x5FBEC0 VA: 0x1805FD8C0
	|-ContainerPropertyBag<StyleEnum<Int32Enum>>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleList<EasingFunction>>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleList<EasingFunction>>.AddProperty<object>
	|-ContainerPropertyBag<StyleList<StylePropertyName>>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleList<StylePropertyName>>.AddProperty<object>
	|-ContainerPropertyBag<StyleList<TimeValue>>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleList<TimeValue>>.AddProperty<object>
	|-ContainerPropertyBag<Angle>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<Angle>.AddProperty<float>
	|-ContainerPropertyBag<Background>.AddProperty<object>
	|-ContainerPropertyBag<BackgroundPosition>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<BackgroundPosition>.AddProperty<Length>
	|-ContainerPropertyBag<BackgroundRepeat>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<BackgroundSize>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<BackgroundSize>.AddProperty<Length>
	|-ContainerPropertyBag<Bounds>.AddProperty<Vector3>
	|-ContainerPropertyBag<BoundsInt>.AddProperty<Vector3Int>
	|-ContainerPropertyBag<Color>.AddProperty<float>
	|-ContainerPropertyBag<Cursor>.AddProperty<int>
	|-ContainerPropertyBag<Cursor>.AddProperty<object>
	|-ContainerPropertyBag<Cursor>.AddProperty<Vector2>
	|-ContainerPropertyBag<EasingFunction>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<FontDefinition>.AddProperty<object>
	|-ContainerPropertyBag<Length>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<Length>.AddProperty<float>
	|-ContainerPropertyBag<object>.AddProperty<int>
	|-ContainerPropertyBag<Rect>.AddProperty<float>
	|-ContainerPropertyBag<RectInt>.AddProperty<int>
	|-ContainerPropertyBag<Rotate>.AddProperty<Angle>
	|-ContainerPropertyBag<Rotate>.AddProperty<Vector3>
	|-ContainerPropertyBag<Scale>.AddProperty<Vector3>
	|-ContainerPropertyBag<StyleBackground>.AddProperty<Background>
	|-ContainerPropertyBag<StyleBackground>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleBackgroundPosition>.AddProperty<BackgroundPosition>
	|-ContainerPropertyBag<StyleBackgroundPosition>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleBackgroundRepeat>.AddProperty<BackgroundRepeat>
	|-ContainerPropertyBag<StyleBackgroundRepeat>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleBackgroundSize>.AddProperty<BackgroundSize>
	|-ContainerPropertyBag<StyleBackgroundSize>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleColor>.AddProperty<Color>
	|-ContainerPropertyBag<StyleColor>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleCursor>.AddProperty<Cursor>
	|-ContainerPropertyBag<StyleCursor>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleFloat>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleFloat>.AddProperty<float>
	|-ContainerPropertyBag<StyleFont>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleFont>.AddProperty<object>
	|-ContainerPropertyBag<StyleFontDefinition>.AddProperty<FontDefinition>
	|-ContainerPropertyBag<StyleFontDefinition>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleInt>.AddProperty<int>
	|-ContainerPropertyBag<StyleInt>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleLength>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleLength>.AddProperty<Length>
	|-ContainerPropertyBag<StylePropertyName>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StylePropertyName>.AddProperty<object>
	|-ContainerPropertyBag<StyleRotate>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleRotate>.AddProperty<Rotate>
	|-ContainerPropertyBag<StyleScale>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleScale>.AddProperty<Scale>
	|-ContainerPropertyBag<StyleTextShadow>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleTextShadow>.AddProperty<TextShadow>
	|-ContainerPropertyBag<StyleTransformOrigin>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleTransformOrigin>.AddProperty<TransformOrigin>
	|-ContainerPropertyBag<StyleTranslate>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<StyleTranslate>.AddProperty<Translate>
	|-ContainerPropertyBag<TextShadow>.AddProperty<Color>
	|-ContainerPropertyBag<TextShadow>.AddProperty<float>
	|-ContainerPropertyBag<TextShadow>.AddProperty<Vector2>
	|-ContainerPropertyBag<TimeValue>.AddProperty<Int32Enum>
	|-ContainerPropertyBag<TimeValue>.AddProperty<float>
	|-ContainerPropertyBag<TransformOrigin>.AddProperty<Length>
	|-ContainerPropertyBag<TransformOrigin>.AddProperty<float>
	|-ContainerPropertyBag<Translate>.AddProperty<Length>
	|-ContainerPropertyBag<Translate>.AddProperty<float>
	|-ContainerPropertyBag<Vector2>.AddProperty<float>
	|-ContainerPropertyBag<Vector2Int>.AddProperty<int>
	|-ContainerPropertyBag<Vector3>.AddProperty<float>
	|-ContainerPropertyBag<Vector3Int>.AddProperty<int>
	|-ContainerPropertyBag<Vector4>.AddProperty<float>
	|
	|-RVA: 0x6026E0 Offset: 0x600CE0 VA: 0x1806026E0
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.AddProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override PropertyCollection<TContainer> GetProperties() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2ECF0 Offset: 0xD2D2F0 VA: 0x180D2ECF0
	|-ContainerPropertyBag<StyleEnum<Int32Enum>>.GetProperties
	|-ContainerPropertyBag<Angle>.GetProperties
	|-ContainerPropertyBag<BackgroundRepeat>.GetProperties
	|-ContainerPropertyBag<EasingFunction>.GetProperties
	|-ContainerPropertyBag<Length>.GetProperties
	|-ContainerPropertyBag<object>.GetProperties
	|-ContainerPropertyBag<StyleFloat>.GetProperties
	|-ContainerPropertyBag<StyleInt>.GetProperties
	|-ContainerPropertyBag<TimeValue>.GetProperties
	|-ContainerPropertyBag<Vector2>.GetProperties
	|-ContainerPropertyBag<Vector2Int>.GetProperties
	|
	|-RVA: 0xD2ECB0 Offset: 0xD2D2B0 VA: 0x180D2ECB0
	|-ContainerPropertyBag<StyleList<EasingFunction>>.GetProperties
	|-ContainerPropertyBag<StyleList<StylePropertyName>>.GetProperties
	|-ContainerPropertyBag<StyleList<TimeValue>>.GetProperties
	|-ContainerPropertyBag<BackgroundPosition>.GetProperties
	|-ContainerPropertyBag<Color>.GetProperties
	|-ContainerPropertyBag<FontDefinition>.GetProperties
	|-ContainerPropertyBag<Rect>.GetProperties
	|-ContainerPropertyBag<RectInt>.GetProperties
	|-ContainerPropertyBag<Scale>.GetProperties
	|-ContainerPropertyBag<StyleBackgroundPosition>.GetProperties
	|-ContainerPropertyBag<StyleBackgroundRepeat>.GetProperties
	|-ContainerPropertyBag<StyleFont>.GetProperties
	|-ContainerPropertyBag<StyleLength>.GetProperties
	|-ContainerPropertyBag<StylePropertyName>.GetProperties
	|-ContainerPropertyBag<Vector3>.GetProperties
	|-ContainerPropertyBag<Vector3Int>.GetProperties
	|-ContainerPropertyBag<Vector4>.GetProperties
	|
	|-RVA: 0xD2EDE0 Offset: 0xD2D3E0 VA: 0x180D2EDE0
	|-ContainerPropertyBag<Background>.GetProperties
	|-ContainerPropertyBag<StyleCursor>.GetProperties
	|-ContainerPropertyBag<StyleRotate>.GetProperties
	|-ContainerPropertyBag<StyleTextShadow>.GetProperties
	|-ContainerPropertyBag<StyleTranslate>.GetProperties
	|-ContainerPropertyBag<TextShadow>.GetProperties
	|
	|-RVA: 0xD2EEE0 Offset: 0xD2D4E0 VA: 0x180D2EEE0
	|-ContainerPropertyBag<BackgroundSize>.GetProperties
	|-ContainerPropertyBag<Bounds>.GetProperties
	|-ContainerPropertyBag<BoundsInt>.GetProperties
	|-ContainerPropertyBag<Cursor>.GetProperties
	|-ContainerPropertyBag<Rotate>.GetProperties
	|-ContainerPropertyBag<StyleBackgroundSize>.GetProperties
	|-ContainerPropertyBag<StyleColor>.GetProperties
	|-ContainerPropertyBag<StyleFontDefinition>.GetProperties
	|-ContainerPropertyBag<StyleScale>.GetProperties
	|-ContainerPropertyBag<StyleTransformOrigin>.GetProperties
	|-ContainerPropertyBag<TransformOrigin>.GetProperties
	|-ContainerPropertyBag<Translate>.GetProperties
	|
	|-RVA: 0xD2F060 Offset: 0xD2D660 VA: 0x180D2F060
	|-ContainerPropertyBag<StyleBackground>.GetProperties
	|
	|-RVA: 0xD2ED30 Offset: 0xD2D330 VA: 0x180D2ED30
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override PropertyCollection<TContainer> GetProperties(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2EE20 Offset: 0xD2D420 VA: 0x180D2EE20
	|-ContainerPropertyBag<StyleEnum<Int32Enum>>.GetProperties
	|-ContainerPropertyBag<Angle>.GetProperties
	|-ContainerPropertyBag<BackgroundRepeat>.GetProperties
	|-ContainerPropertyBag<EasingFunction>.GetProperties
	|-ContainerPropertyBag<Length>.GetProperties
	|-ContainerPropertyBag<object>.GetProperties
	|-ContainerPropertyBag<StyleFloat>.GetProperties
	|-ContainerPropertyBag<StyleInt>.GetProperties
	|-ContainerPropertyBag<TimeValue>.GetProperties
	|-ContainerPropertyBag<Vector2>.GetProperties
	|-ContainerPropertyBag<Vector2Int>.GetProperties
	|
	|-RVA: 0xD2EE60 Offset: 0xD2D460 VA: 0x180D2EE60
	|-ContainerPropertyBag<StyleList<EasingFunction>>.GetProperties
	|-ContainerPropertyBag<StyleList<StylePropertyName>>.GetProperties
	|-ContainerPropertyBag<StyleList<TimeValue>>.GetProperties
	|-ContainerPropertyBag<BackgroundPosition>.GetProperties
	|-ContainerPropertyBag<Color>.GetProperties
	|-ContainerPropertyBag<FontDefinition>.GetProperties
	|-ContainerPropertyBag<Rect>.GetProperties
	|-ContainerPropertyBag<RectInt>.GetProperties
	|-ContainerPropertyBag<Scale>.GetProperties
	|-ContainerPropertyBag<StyleBackgroundPosition>.GetProperties
	|-ContainerPropertyBag<StyleBackgroundRepeat>.GetProperties
	|-ContainerPropertyBag<StyleFont>.GetProperties
	|-ContainerPropertyBag<StyleLength>.GetProperties
	|-ContainerPropertyBag<StylePropertyName>.GetProperties
	|-ContainerPropertyBag<Vector3>.GetProperties
	|-ContainerPropertyBag<Vector3Int>.GetProperties
	|-ContainerPropertyBag<Vector4>.GetProperties
	|
	|-RVA: 0xD2EEA0 Offset: 0xD2D4A0 VA: 0x180D2EEA0
	|-ContainerPropertyBag<Background>.GetProperties
	|-ContainerPropertyBag<StyleCursor>.GetProperties
	|-ContainerPropertyBag<StyleRotate>.GetProperties
	|-ContainerPropertyBag<StyleTextShadow>.GetProperties
	|-ContainerPropertyBag<StyleTranslate>.GetProperties
	|-ContainerPropertyBag<TextShadow>.GetProperties
	|
	|-RVA: 0xD2EF20 Offset: 0xD2D520 VA: 0x180D2EF20
	|-ContainerPropertyBag<BackgroundSize>.GetProperties
	|-ContainerPropertyBag<Bounds>.GetProperties
	|-ContainerPropertyBag<BoundsInt>.GetProperties
	|-ContainerPropertyBag<Cursor>.GetProperties
	|-ContainerPropertyBag<Rotate>.GetProperties
	|-ContainerPropertyBag<StyleBackgroundSize>.GetProperties
	|-ContainerPropertyBag<StyleColor>.GetProperties
	|-ContainerPropertyBag<StyleFontDefinition>.GetProperties
	|-ContainerPropertyBag<StyleScale>.GetProperties
	|-ContainerPropertyBag<StyleTransformOrigin>.GetProperties
	|-ContainerPropertyBag<TransformOrigin>.GetProperties
	|-ContainerPropertyBag<Translate>.GetProperties
	|
	|-RVA: 0xD2F010 Offset: 0xD2D610 VA: 0x180D2F010
	|-ContainerPropertyBag<StyleBackground>.GetProperties
	|
	|-RVA: 0xD2EF60 Offset: 0xD2D560 VA: 0x180D2EF60
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2F0B0 Offset: 0xD2D6B0 VA: 0x180D2F0B0
	|-ContainerPropertyBag<StyleEnum<Int32Enum>>.TryGetProperty
	|-ContainerPropertyBag<StyleList<EasingFunction>>.TryGetProperty
	|-ContainerPropertyBag<StyleList<StylePropertyName>>.TryGetProperty
	|-ContainerPropertyBag<StyleList<TimeValue>>.TryGetProperty
	|-ContainerPropertyBag<Angle>.TryGetProperty
	|-ContainerPropertyBag<Background>.TryGetProperty
	|-ContainerPropertyBag<BackgroundPosition>.TryGetProperty
	|-ContainerPropertyBag<BackgroundRepeat>.TryGetProperty
	|-ContainerPropertyBag<BackgroundSize>.TryGetProperty
	|-ContainerPropertyBag<Bounds>.TryGetProperty
	|-ContainerPropertyBag<BoundsInt>.TryGetProperty
	|-ContainerPropertyBag<Color>.TryGetProperty
	|-ContainerPropertyBag<Cursor>.TryGetProperty
	|-ContainerPropertyBag<EasingFunction>.TryGetProperty
	|-ContainerPropertyBag<FontDefinition>.TryGetProperty
	|-ContainerPropertyBag<Length>.TryGetProperty
	|-ContainerPropertyBag<object>.TryGetProperty
	|-ContainerPropertyBag<Rect>.TryGetProperty
	|-ContainerPropertyBag<RectInt>.TryGetProperty
	|-ContainerPropertyBag<Rotate>.TryGetProperty
	|-ContainerPropertyBag<Scale>.TryGetProperty
	|-ContainerPropertyBag<StyleBackground>.TryGetProperty
	|-ContainerPropertyBag<StyleBackgroundPosition>.TryGetProperty
	|-ContainerPropertyBag<StyleBackgroundRepeat>.TryGetProperty
	|-ContainerPropertyBag<StyleBackgroundSize>.TryGetProperty
	|-ContainerPropertyBag<StyleColor>.TryGetProperty
	|-ContainerPropertyBag<StyleCursor>.TryGetProperty
	|-ContainerPropertyBag<StyleFloat>.TryGetProperty
	|-ContainerPropertyBag<StyleFont>.TryGetProperty
	|-ContainerPropertyBag<StyleFontDefinition>.TryGetProperty
	|-ContainerPropertyBag<StyleInt>.TryGetProperty
	|-ContainerPropertyBag<StyleLength>.TryGetProperty
	|-ContainerPropertyBag<StylePropertyName>.TryGetProperty
	|-ContainerPropertyBag<StyleRotate>.TryGetProperty
	|-ContainerPropertyBag<StyleScale>.TryGetProperty
	|-ContainerPropertyBag<StyleTextShadow>.TryGetProperty
	|-ContainerPropertyBag<StyleTransformOrigin>.TryGetProperty
	|-ContainerPropertyBag<StyleTranslate>.TryGetProperty
	|-ContainerPropertyBag<TextShadow>.TryGetProperty
	|-ContainerPropertyBag<TimeValue>.TryGetProperty
	|-ContainerPropertyBag<TransformOrigin>.TryGetProperty
	|-ContainerPropertyBag<Translate>.TryGetProperty
	|-ContainerPropertyBag<Vector2>.TryGetProperty
	|-ContainerPropertyBag<Vector2Int>.TryGetProperty
	|-ContainerPropertyBag<Vector3>.TryGetProperty
	|-ContainerPropertyBag<Vector3Int>.TryGetProperty
	|-ContainerPropertyBag<Vector4>.TryGetProperty
	|
	|-RVA: 0xD2F0F0 Offset: 0xD2D6F0 VA: 0x180D2F0F0
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.TryGetProperty
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD2F150 Offset: 0xD2D750 VA: 0x180D2F150
	|-ContainerPropertyBag<StyleEnum<Int32Enum>>..ctor
	|-ContainerPropertyBag<StyleList<EasingFunction>>..ctor
	|-ContainerPropertyBag<StyleList<StylePropertyName>>..ctor
	|-ContainerPropertyBag<StyleList<TimeValue>>..ctor
	|-ContainerPropertyBag<Angle>..ctor
	|-ContainerPropertyBag<Background>..ctor
	|-ContainerPropertyBag<BackgroundPosition>..ctor
	|-ContainerPropertyBag<BackgroundRepeat>..ctor
	|-ContainerPropertyBag<BackgroundSize>..ctor
	|-ContainerPropertyBag<Bounds>..ctor
	|-ContainerPropertyBag<BoundsInt>..ctor
	|-ContainerPropertyBag<Color>..ctor
	|-ContainerPropertyBag<Cursor>..ctor
	|-ContainerPropertyBag<EasingFunction>..ctor
	|-ContainerPropertyBag<FontDefinition>..ctor
	|-ContainerPropertyBag<Length>..ctor
	|-ContainerPropertyBag<object>..ctor
	|-ContainerPropertyBag<Rect>..ctor
	|-ContainerPropertyBag<RectInt>..ctor
	|-ContainerPropertyBag<Rotate>..ctor
	|-ContainerPropertyBag<Scale>..ctor
	|-ContainerPropertyBag<StyleBackground>..ctor
	|-ContainerPropertyBag<StyleBackgroundPosition>..ctor
	|-ContainerPropertyBag<StyleBackgroundRepeat>..ctor
	|-ContainerPropertyBag<StyleBackgroundSize>..ctor
	|-ContainerPropertyBag<StyleColor>..ctor
	|-ContainerPropertyBag<StyleCursor>..ctor
	|-ContainerPropertyBag<StyleFloat>..ctor
	|-ContainerPropertyBag<StyleFont>..ctor
	|-ContainerPropertyBag<StyleFontDefinition>..ctor
	|-ContainerPropertyBag<StyleInt>..ctor
	|-ContainerPropertyBag<StyleLength>..ctor
	|-ContainerPropertyBag<StylePropertyName>..ctor
	|-ContainerPropertyBag<StyleRotate>..ctor
	|-ContainerPropertyBag<StyleScale>..ctor
	|-ContainerPropertyBag<StyleTextShadow>..ctor
	|-ContainerPropertyBag<StyleTransformOrigin>..ctor
	|-ContainerPropertyBag<StyleTranslate>..ctor
	|-ContainerPropertyBag<TextShadow>..ctor
	|-ContainerPropertyBag<TimeValue>..ctor
	|-ContainerPropertyBag<TransformOrigin>..ctor
	|-ContainerPropertyBag<Translate>..ctor
	|-ContainerPropertyBag<Vector2>..ctor
	|-ContainerPropertyBag<Vector2Int>..ctor
	|-ContainerPropertyBag<Vector3>..ctor
	|-ContainerPropertyBag<Vector3Int>..ctor
	|-ContainerPropertyBag<Vector4>..ctor
	|
	|-RVA: 0xD2F260 Offset: 0xD2D860 VA: 0x180D2F260
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class DictionaryPropertyBag<TKey, TValue> : KeyValueCollectionPropertyBag<Dictionary<TKey, TValue>, TKey, TValue> // TypeDefIndex: 12943
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected override Dictionary<TKey, TValue> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3F080 Offset: 0xD3D680 VA: 0x180D3F080
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC0D9F0 Offset: 0xC0BFF0 VA: 0x180C0D9F0
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class HashSetPropertyBag<TElement> : SetPropertyBagBase<HashSet<TElement>, TElement> // TypeDefIndex: 12944
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected override HashSet<TElement> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD3F080 Offset: 0xD3D680 VA: 0x180D3F080
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC0D9F0 Offset: 0xC0BFF0 VA: 0x180C0D9F0
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
[IsReadOnly]
internal struct IndexedCollectionPropertyBagEnumerable<TContainer> // TypeDefIndex: 12945
{
	// Fields
	private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl; // 0x0
	private readonly TContainer m_Container; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x971180 Offset: 0x96F780 VA: 0x180971180
	|-IndexedCollectionPropertyBagEnumerable<StyleEnum<Int32Enum>>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Angle>..ctor
	|-IndexedCollectionPropertyBagEnumerable<BackgroundRepeat>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Length>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleFloat>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleInt>..ctor
	|-IndexedCollectionPropertyBagEnumerable<TimeValue>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Vector2Int>..ctor
	|
	|-RVA: 0x1093650 Offset: 0x1091C50 VA: 0x181093650
	|-IndexedCollectionPropertyBagEnumerable<StyleList<EasingFunction>>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleList<StylePropertyName>>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleList<TimeValue>>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StylePropertyName>..ctor
	|
	|-RVA: 0x1093770 Offset: 0x1091D70 VA: 0x181093770
	|-IndexedCollectionPropertyBagEnumerable<Background>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleCursor>..ctor
	|
	|-RVA: 0x970F50 Offset: 0x96F550 VA: 0x180970F50
	|-IndexedCollectionPropertyBagEnumerable<BackgroundPosition>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleBackgroundRepeat>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleLength>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Vector3>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Vector3Int>..ctor
	|
	|-RVA: 0x10935A0 Offset: 0x1091BA0 VA: 0x1810935A0
	|-IndexedCollectionPropertyBagEnumerable<BackgroundSize>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleColor>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleScale>..ctor
	|-IndexedCollectionPropertyBagEnumerable<TransformOrigin>..ctor
	|
	|-RVA: 0x1093690 Offset: 0x1091C90 VA: 0x181093690
	|-IndexedCollectionPropertyBagEnumerable<Bounds>..ctor
	|-IndexedCollectionPropertyBagEnumerable<BoundsInt>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Rotate>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleBackgroundSize>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleTransformOrigin>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Translate>..ctor
	|
	|-RVA: 0x10936D0 Offset: 0x1091CD0 VA: 0x1810936D0
	|-IndexedCollectionPropertyBagEnumerable<Color>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Rect>..ctor
	|-IndexedCollectionPropertyBagEnumerable<RectInt>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Scale>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleBackgroundPosition>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Vector4>..ctor
	|
	|-RVA: 0xA4BD70 Offset: 0xA4A370 VA: 0x180A4BD70
	|-IndexedCollectionPropertyBagEnumerable<Cursor>..ctor
	|
	|-RVA: 0x1093740 Offset: 0x1091D40 VA: 0x181093740
	|-IndexedCollectionPropertyBagEnumerable<EasingFunction>..ctor
	|
	|-RVA: 0x10937B0 Offset: 0x1091DB0 VA: 0x1810937B0
	|-IndexedCollectionPropertyBagEnumerable<FontDefinition>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleFont>..ctor
	|
	|-RVA: 0x970F90 Offset: 0x96F590 VA: 0x180970F90
	|-IndexedCollectionPropertyBagEnumerable<int>..ctor
	|-IndexedCollectionPropertyBagEnumerable<Int32Enum>..ctor
	|
	|-RVA: 0x598200 Offset: 0x596800 VA: 0x180598200
	|-IndexedCollectionPropertyBagEnumerable<object>..ctor
	|
	|-RVA: 0x10939D0 Offset: 0x1091FD0 VA: 0x1810939D0
	|-IndexedCollectionPropertyBagEnumerable<float>..ctor
	|
	|-RVA: 0x10935D0 Offset: 0x1091BD0 VA: 0x1810935D0
	|-IndexedCollectionPropertyBagEnumerable<StyleBackground>..ctor
	|
	|-RVA: 0x10937F0 Offset: 0x1091DF0 VA: 0x1810937F0
	|-IndexedCollectionPropertyBagEnumerable<StyleFontDefinition>..ctor
	|
	|-RVA: 0x1093700 Offset: 0x1091D00 VA: 0x181093700
	|-IndexedCollectionPropertyBagEnumerable<StyleRotate>..ctor
	|-IndexedCollectionPropertyBagEnumerable<StyleTranslate>..ctor
	|-IndexedCollectionPropertyBagEnumerable<TextShadow>..ctor
	|
	|-RVA: 0x1093830 Offset: 0x1091E30 VA: 0x181093830
	|-IndexedCollectionPropertyBagEnumerable<StyleTextShadow>..ctor
	|
	|-RVA: 0x1093620 Offset: 0x1091C20 VA: 0x181093620
	|-IndexedCollectionPropertyBagEnumerable<Vector2>..ctor
	|
	|-RVA: 0x1093870 Offset: 0x1091E70 VA: 0x181093870
	|-IndexedCollectionPropertyBagEnumerable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public IndexedCollectionPropertyBagEnumerator<TContainer> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1092570 Offset: 0x1090B70 VA: 0x181092570
	|-IndexedCollectionPropertyBagEnumerable<StyleEnum<Int32Enum>>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Angle>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<BackgroundRepeat>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Length>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleFloat>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleInt>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<TimeValue>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Vector2Int>.GetEnumerator
	|
	|-RVA: 0x1092490 Offset: 0x1090A90 VA: 0x181092490
	|-IndexedCollectionPropertyBagEnumerable<StyleList<EasingFunction>>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleList<StylePropertyName>>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleList<TimeValue>>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StylePropertyName>.GetEnumerator
	|
	|-RVA: 0x1092D70 Offset: 0x1091370 VA: 0x181092D70
	|-IndexedCollectionPropertyBagEnumerable<Background>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleCursor>.GetEnumerator
	|
	|-RVA: 0x10928E0 Offset: 0x1090EE0 VA: 0x1810928E0
	|-IndexedCollectionPropertyBagEnumerable<BackgroundPosition>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleBackgroundRepeat>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleLength>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Vector3>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Vector3Int>.GetEnumerator
	|
	|-RVA: 0x10929C0 Offset: 0x1090FC0 VA: 0x1810929C0
	|-IndexedCollectionPropertyBagEnumerable<BackgroundSize>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleColor>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleScale>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<TransformOrigin>.GetEnumerator
	|
	|-RVA: 0x10923A0 Offset: 0x10909A0 VA: 0x1810923A0
	|-IndexedCollectionPropertyBagEnumerable<Bounds>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<BoundsInt>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Rotate>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleBackgroundSize>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleTransformOrigin>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Translate>.GetEnumerator
	|
	|-RVA: 0x1092810 Offset: 0x1090E10 VA: 0x181092810
	|-IndexedCollectionPropertyBagEnumerable<Color>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Rect>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<RectInt>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Scale>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleBackgroundPosition>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Vector4>.GetEnumerator
	|
	|-RVA: 0x1092640 Offset: 0x1090C40 VA: 0x181092640
	|-IndexedCollectionPropertyBagEnumerable<Cursor>.GetEnumerator
	|
	|-RVA: 0x1092F30 Offset: 0x1091530 VA: 0x181092F30
	|-IndexedCollectionPropertyBagEnumerable<EasingFunction>.GetEnumerator
	|
	|-RVA: 0x1092730 Offset: 0x1090D30 VA: 0x181092730
	|-IndexedCollectionPropertyBagEnumerable<FontDefinition>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleFont>.GetEnumerator
	|
	|-RVA: 0x1092E60 Offset: 0x1091460 VA: 0x181092E60
	|-IndexedCollectionPropertyBagEnumerable<int>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x10933B0 Offset: 0x10919B0 VA: 0x1810933B0
	|-IndexedCollectionPropertyBagEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x1093000 Offset: 0x1091600 VA: 0x181093000
	|-IndexedCollectionPropertyBagEnumerable<float>.GetEnumerator
	|
	|-RVA: 0x1093490 Offset: 0x1091A90 VA: 0x181093490
	|-IndexedCollectionPropertyBagEnumerable<StyleBackground>.GetEnumerator
	|
	|-RVA: 0x1092AA0 Offset: 0x10910A0 VA: 0x181092AA0
	|-IndexedCollectionPropertyBagEnumerable<StyleFontDefinition>.GetEnumerator
	|
	|-RVA: 0x1092B90 Offset: 0x1091190 VA: 0x181092B90
	|-IndexedCollectionPropertyBagEnumerable<StyleRotate>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<StyleTranslate>.GetEnumerator
	|-IndexedCollectionPropertyBagEnumerable<TextShadow>.GetEnumerator
	|
	|-RVA: 0x10930D0 Offset: 0x10916D0 VA: 0x1810930D0
	|-IndexedCollectionPropertyBagEnumerable<StyleTextShadow>.GetEnumerator
	|
	|-RVA: 0x1092C90 Offset: 0x1091290 VA: 0x181092C90
	|-IndexedCollectionPropertyBagEnumerable<Vector2>.GetEnumerator
	|
	|-RVA: 0x10931C0 Offset: 0x10917C0 VA: 0x1810931C0
	|-IndexedCollectionPropertyBagEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	*/
}

// Namespace: Unity.Properties
internal struct IndexedCollectionPropertyBagEnumerator<TContainer> : IEnumerator<IProperty<TContainer>>, IEnumerator, IDisposable // TypeDefIndex: 12946
{
	// Fields
	private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl; // 0x0
	private readonly IndexedCollectionSharedPropertyState m_Previous; // 0x0
	private TContainer m_Container; // 0x0
	private int m_Position; // 0x0

	// Properties
	public IProperty<TContainer> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1095640 Offset: 0x1093C40 VA: 0x181095640
	|-IndexedCollectionPropertyBagEnumerator<StyleEnum<Int32Enum>>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Angle>..ctor
	|-IndexedCollectionPropertyBagEnumerator<BackgroundRepeat>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Length>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleFloat>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleInt>..ctor
	|-IndexedCollectionPropertyBagEnumerator<TimeValue>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Vector2Int>..ctor
	|
	|-RVA: 0x1095970 Offset: 0x1093F70 VA: 0x181095970
	|-IndexedCollectionPropertyBagEnumerator<StyleList<EasingFunction>>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleList<StylePropertyName>>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleList<TimeValue>>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StylePropertyName>..ctor
	|
	|-RVA: 0x1095C30 Offset: 0x1094230 VA: 0x181095C30
	|-IndexedCollectionPropertyBagEnumerator<Background>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleCursor>..ctor
	|
	|-RVA: 0x1095B80 Offset: 0x1094180 VA: 0x181095B80
	|-IndexedCollectionPropertyBagEnumerator<BackgroundPosition>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundRepeat>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleLength>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Vector3>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Vector3Int>..ctor
	|
	|-RVA: 0x1095780 Offset: 0x1093D80 VA: 0x181095780
	|-IndexedCollectionPropertyBagEnumerator<BackgroundSize>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleColor>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleScale>..ctor
	|-IndexedCollectionPropertyBagEnumerator<TransformOrigin>..ctor
	|
	|-RVA: 0x1095A20 Offset: 0x1094020 VA: 0x181095A20
	|-IndexedCollectionPropertyBagEnumerator<Bounds>..ctor
	|-IndexedCollectionPropertyBagEnumerator<BoundsInt>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Rotate>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundSize>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleTransformOrigin>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Translate>..ctor
	|
	|-RVA: 0x1095820 Offset: 0x1093E20 VA: 0x181095820
	|-IndexedCollectionPropertyBagEnumerator<Color>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Rect>..ctor
	|-IndexedCollectionPropertyBagEnumerator<RectInt>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Scale>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundPosition>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Vector4>..ctor
	|
	|-RVA: 0x1096130 Offset: 0x1094730 VA: 0x181096130
	|-IndexedCollectionPropertyBagEnumerator<Cursor>..ctor
	|
	|-RVA: 0x10956E0 Offset: 0x1093CE0 VA: 0x1810956E0
	|-IndexedCollectionPropertyBagEnumerator<EasingFunction>..ctor
	|-IndexedCollectionPropertyBagEnumerator<int>..ctor
	|-IndexedCollectionPropertyBagEnumerator<Int32Enum>..ctor
	|
	|-RVA: 0x1095FE0 Offset: 0x10945E0 VA: 0x181095FE0
	|-IndexedCollectionPropertyBagEnumerator<FontDefinition>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleFont>..ctor
	|
	|-RVA: 0x1095590 Offset: 0x1093B90 VA: 0x181095590
	|-IndexedCollectionPropertyBagEnumerator<object>..ctor
	|
	|-RVA: 0x1096090 Offset: 0x1094690 VA: 0x181096090
	|-IndexedCollectionPropertyBagEnumerator<float>..ctor
	|
	|-RVA: 0x10954D0 Offset: 0x1093AD0 VA: 0x1810954D0
	|-IndexedCollectionPropertyBagEnumerator<StyleBackground>..ctor
	|
	|-RVA: 0x1095AD0 Offset: 0x10940D0 VA: 0x181095AD0
	|-IndexedCollectionPropertyBagEnumerator<StyleFontDefinition>..ctor
	|
	|-RVA: 0x10958C0 Offset: 0x1093EC0 VA: 0x1810958C0
	|-IndexedCollectionPropertyBagEnumerator<StyleRotate>..ctor
	|-IndexedCollectionPropertyBagEnumerator<StyleTranslate>..ctor
	|-IndexedCollectionPropertyBagEnumerator<TextShadow>..ctor
	|
	|-RVA: 0x10961E0 Offset: 0x10947E0 VA: 0x1810961E0
	|-IndexedCollectionPropertyBagEnumerator<StyleTextShadow>..ctor
	|
	|-RVA: 0x1095CE0 Offset: 0x10942E0 VA: 0x181095CE0
	|-IndexedCollectionPropertyBagEnumerator<Vector2>..ctor
	|
	|-RVA: 0x1095D80 Offset: 0x1094380 VA: 0x181095D80
	|-IndexedCollectionPropertyBagEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IProperty<TContainer> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096290 Offset: 0x1094890 VA: 0x181096290
	|-IndexedCollectionPropertyBagEnumerator<StyleEnum<Int32Enum>>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleList<EasingFunction>>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleList<StylePropertyName>>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleList<TimeValue>>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Angle>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Background>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<BackgroundPosition>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<BackgroundRepeat>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<BackgroundSize>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Bounds>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<BoundsInt>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Color>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Cursor>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<EasingFunction>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<FontDefinition>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<int>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Int32Enum>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Length>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<object>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Rect>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<RectInt>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Rotate>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Scale>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<float>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleBackground>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundPosition>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundRepeat>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundSize>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleColor>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleCursor>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleFloat>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleFont>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleFontDefinition>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleInt>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleLength>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StylePropertyName>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleRotate>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleScale>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleTextShadow>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleTransformOrigin>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleTranslate>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<TextShadow>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<TimeValue>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<TransformOrigin>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Translate>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Vector2>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Vector2Int>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Vector3>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Vector3Int>.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Vector4>.get_Current
	|
	|-RVA: 0x10962F0 Offset: 0x10948F0 VA: 0x1810962F0
	|-IndexedCollectionPropertyBagEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10953E0 Offset: 0x10939E0 VA: 0x1810953E0
	|-IndexedCollectionPropertyBagEnumerator<StyleEnum<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleList<EasingFunction>>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleList<StylePropertyName>>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleList<TimeValue>>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Angle>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Background>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<BackgroundPosition>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<BackgroundRepeat>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<BackgroundSize>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Bounds>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<BoundsInt>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Color>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Cursor>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<EasingFunction>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<FontDefinition>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<int>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Length>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<object>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Rect>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<RectInt>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Rotate>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Scale>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<float>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleBackground>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundPosition>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundRepeat>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundSize>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleColor>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleCursor>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleFloat>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleFont>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleFontDefinition>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleInt>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleLength>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StylePropertyName>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleRotate>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleScale>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleTextShadow>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleTransformOrigin>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<StyleTranslate>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<TextShadow>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<TimeValue>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<TransformOrigin>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Translate>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Vector2Int>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Vector3Int>.System.Collections.IEnumerator.get_Current
	|-IndexedCollectionPropertyBagEnumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1095460 Offset: 0x1093A60 VA: 0x181095460
	|-IndexedCollectionPropertyBagEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1093A00 Offset: 0x1092000 VA: 0x181093A00
	|-IndexedCollectionPropertyBagEnumerator<StyleEnum<Int32Enum>>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Angle>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<BackgroundRepeat>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Length>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<object>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleFloat>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleInt>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<TimeValue>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Vector2>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Vector2Int>.MoveNext
	|
	|-RVA: 0x1093F40 Offset: 0x1092540 VA: 0x181093F40
	|-IndexedCollectionPropertyBagEnumerator<StyleList<EasingFunction>>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleList<StylePropertyName>>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleList<TimeValue>>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Color>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<FontDefinition>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Rect>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<RectInt>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Scale>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundPosition>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleFont>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StylePropertyName>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Vector4>.MoveNext
	|
	|-RVA: 0x1093D80 Offset: 0x1092380 VA: 0x181093D80
	|-IndexedCollectionPropertyBagEnumerator<Background>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleCursor>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleTextShadow>.MoveNext
	|
	|-RVA: 0x10942C0 Offset: 0x10928C0 VA: 0x1810942C0
	|-IndexedCollectionPropertyBagEnumerator<BackgroundPosition>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundRepeat>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleLength>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Vector3>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Vector3Int>.MoveNext
	|
	|-RVA: 0x1094100 Offset: 0x1092700 VA: 0x181094100
	|-IndexedCollectionPropertyBagEnumerator<BackgroundSize>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleColor>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleScale>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<TransformOrigin>.MoveNext
	|
	|-RVA: 0x1093BC0 Offset: 0x10921C0 VA: 0x181093BC0
	|-IndexedCollectionPropertyBagEnumerator<Bounds>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<BoundsInt>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Cursor>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Rotate>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundSize>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleFontDefinition>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleTransformOrigin>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Translate>.MoveNext
	|
	|-RVA: 0x1094790 Offset: 0x1092D90 VA: 0x181094790
	|-IndexedCollectionPropertyBagEnumerator<EasingFunction>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<float>.MoveNext
	|
	|-RVA: 0x1094640 Offset: 0x1092C40 VA: 0x181094640
	|-IndexedCollectionPropertyBagEnumerator<int>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<Int32Enum>.MoveNext
	|
	|-RVA: 0x1094480 Offset: 0x1092A80 VA: 0x181094480
	|-IndexedCollectionPropertyBagEnumerator<StyleBackground>.MoveNext
	|
	|-RVA: 0x1094950 Offset: 0x1092F50 VA: 0x181094950
	|-IndexedCollectionPropertyBagEnumerator<StyleRotate>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<StyleTranslate>.MoveNext
	|-IndexedCollectionPropertyBagEnumerator<TextShadow>.MoveNext
	|
	|-RVA: 0x1094B10 Offset: 0x1093110 VA: 0x181094B10
	|-IndexedCollectionPropertyBagEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1095070 Offset: 0x1093670 VA: 0x181095070
	|-IndexedCollectionPropertyBagEnumerator<StyleEnum<Int32Enum>>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Angle>.Reset
	|-IndexedCollectionPropertyBagEnumerator<BackgroundRepeat>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Length>.Reset
	|-IndexedCollectionPropertyBagEnumerator<object>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleFloat>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleInt>.Reset
	|-IndexedCollectionPropertyBagEnumerator<TimeValue>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Vector2>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Vector2Int>.Reset
	|
	|-RVA: 0x1094F20 Offset: 0x1093520 VA: 0x181094F20
	|-IndexedCollectionPropertyBagEnumerator<StyleList<EasingFunction>>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleList<StylePropertyName>>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleList<TimeValue>>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Color>.Reset
	|-IndexedCollectionPropertyBagEnumerator<FontDefinition>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Rect>.Reset
	|-IndexedCollectionPropertyBagEnumerator<RectInt>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Scale>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundPosition>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleFont>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StylePropertyName>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Vector4>.Reset
	|
	|-RVA: 0x10951C0 Offset: 0x10937C0 VA: 0x1810951C0
	|-IndexedCollectionPropertyBagEnumerator<Background>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleCursor>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleTextShadow>.Reset
	|
	|-RVA: 0x1095000 Offset: 0x1093600 VA: 0x181095000
	|-IndexedCollectionPropertyBagEnumerator<BackgroundPosition>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundRepeat>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleLength>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Vector3>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Vector3Int>.Reset
	|
	|-RVA: 0x10950E0 Offset: 0x10936E0 VA: 0x1810950E0
	|-IndexedCollectionPropertyBagEnumerator<BackgroundSize>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleColor>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleScale>.Reset
	|-IndexedCollectionPropertyBagEnumerator<TransformOrigin>.Reset
	|
	|-RVA: 0x1094EB0 Offset: 0x10934B0 VA: 0x181094EB0
	|-IndexedCollectionPropertyBagEnumerator<Bounds>.Reset
	|-IndexedCollectionPropertyBagEnumerator<BoundsInt>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Cursor>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Rotate>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundSize>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleFontDefinition>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleTransformOrigin>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Translate>.Reset
	|
	|-RVA: 0x1094F90 Offset: 0x1093590 VA: 0x181094F90
	|-IndexedCollectionPropertyBagEnumerator<EasingFunction>.Reset
	|-IndexedCollectionPropertyBagEnumerator<int>.Reset
	|-IndexedCollectionPropertyBagEnumerator<Int32Enum>.Reset
	|-IndexedCollectionPropertyBagEnumerator<float>.Reset
	|
	|-RVA: 0x1095150 Offset: 0x1093750 VA: 0x181095150
	|-IndexedCollectionPropertyBagEnumerator<StyleBackground>.Reset
	|
	|-RVA: 0x1095230 Offset: 0x1093830 VA: 0x181095230
	|-IndexedCollectionPropertyBagEnumerator<StyleRotate>.Reset
	|-IndexedCollectionPropertyBagEnumerator<StyleTranslate>.Reset
	|-IndexedCollectionPropertyBagEnumerator<TextShadow>.Reset
	|
	|-RVA: 0x10952A0 Offset: 0x10938A0 VA: 0x1810952A0
	|-IndexedCollectionPropertyBagEnumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-IndexedCollectionPropertyBagEnumerator<StyleEnum<Int32Enum>>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleList<EasingFunction>>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleList<StylePropertyName>>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleList<TimeValue>>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Angle>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Background>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<BackgroundPosition>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<BackgroundRepeat>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<BackgroundSize>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Bounds>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<BoundsInt>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Color>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Cursor>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<EasingFunction>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<FontDefinition>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<int>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Int32Enum>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Length>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<object>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Rect>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<RectInt>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Rotate>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Scale>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<float>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleBackground>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundPosition>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundRepeat>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleBackgroundSize>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleColor>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleCursor>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleFloat>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleFont>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleFontDefinition>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleInt>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleLength>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StylePropertyName>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleRotate>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleScale>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleTextShadow>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleTransformOrigin>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<StyleTranslate>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<TextShadow>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<TimeValue>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<TransformOrigin>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Translate>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Vector2>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Vector2Int>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Vector3>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Vector3Int>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<Vector4>.Dispose
	|-IndexedCollectionPropertyBagEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/
}

// Namespace: Unity.Properties
internal interface IIndexedCollectionPropertyBagEnumerator<TContainer> // TypeDefIndex: 12947
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetCount(ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IIndexedCollectionPropertyBagEnumerator<__Il2CppFullySharedGenericType>.GetCount
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IProperty<TContainer> GetSharedProperty();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IIndexedCollectionPropertyBagEnumerator<__Il2CppFullySharedGenericType>.GetSharedProperty
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IndexedCollectionSharedPropertyState GetSharedPropertyState();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IIndexedCollectionPropertyBagEnumerator<__Il2CppFullySharedGenericType>.GetSharedPropertyState
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetSharedPropertyState(IndexedCollectionSharedPropertyState state);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IIndexedCollectionPropertyBagEnumerator<__Il2CppFullySharedGenericType>.SetSharedPropertyState
	*/
}

// Namespace: Unity.Properties
internal struct IndexedCollectionSharedPropertyState // TypeDefIndex: 12948
{
	// Fields
	public int Index; // 0x0
	public bool IsReadOnly; // 0x4
}

// Namespace: Unity.Properties
public class IndexedCollectionPropertyBag<TList, TElement> : PropertyBag<TList>, IListPropertyBag<TList, TElement>, ICollectionPropertyBag<TList, TElement>, IPropertyBag<TList>, IPropertyBag, ICollectionPropertyBagAccept<TList>, IListPropertyBagAccept<TList>, IListPropertyAccept<TList>, IIndexedProperties<TList>, IConstructorWithCount<TList>, IConstructor, IIndexedCollectionPropertyBagEnumerator<TList> // TypeDefIndex: 12950
{
	// Fields
	private readonly IndexedCollectionPropertyBag.ListElementProperty<TList, TElement> m_Property; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public override PropertyCollection<TList> GetProperties() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096390 Offset: 0x1094990 VA: 0x181096390
	|-IndexedCollectionPropertyBag<object, EasingFunction>.GetProperties
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.GetProperties
	|-IndexedCollectionPropertyBag<object, TimeValue>.GetProperties
	|
	|-RVA: 0x96A310 Offset: 0x968910 VA: 0x18096A310
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override PropertyCollection<TList> GetProperties(ref TList container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096420 Offset: 0x1094A20 VA: 0x181096420
	|-IndexedCollectionPropertyBag<object, EasingFunction>.GetProperties
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.GetProperties
	|-IndexedCollectionPropertyBag<object, TimeValue>.GetProperties
	|
	|-RVA: 0x10964E0 Offset: 0x1094AE0 VA: 0x1810964E0
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public bool TryGetProperty(ref TList container, int index, out IProperty<TList> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10969A0 Offset: 0x1094FA0 VA: 0x1810969A0
	|-IndexedCollectionPropertyBag<object, EasingFunction>.TryGetProperty
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.TryGetProperty
	|-IndexedCollectionPropertyBag<object, TimeValue>.TryGetProperty
	|
	|-RVA: 0x1096840 Offset: 0x1094E40 VA: 0x181096840
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetProperty
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept(ICollectionPropertyBagVisitor visitor, ref TList container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096A90 Offset: 0x1095090 VA: 0x181096A90
	|-IndexedCollectionPropertyBag<object, EasingFunction>.Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept
	|-IndexedCollectionPropertyBag<object, TimeValue>.Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void Unity.Properties.IListPropertyBagAccept<TList>.Accept(IListPropertyBagVisitor visitor, ref TList list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096D90 Offset: 0x1095390 VA: 0x181096D90
	|-IndexedCollectionPropertyBag<object, EasingFunction>.Unity.Properties.IListPropertyBagAccept<TList>.Accept
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.Unity.Properties.IListPropertyBagAccept<TList>.Accept
	|-IndexedCollectionPropertyBag<object, TimeValue>.Unity.Properties.IListPropertyBagAccept<TList>.Accept
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IListPropertyBagAccept<TList>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void Unity.Properties.IListPropertyAccept<TList>.Accept<TContainer>(IListPropertyVisitor visitor, Property<TContainer, TList> property, ref TContainer container, ref TList list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x603410 Offset: 0x601A10 VA: 0x180603410
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IListPropertyAccept<TList>.Accept<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096BC0 Offset: 0x10951C0 VA: 0x181096BC0
	|-IndexedCollectionPropertyBag<object, EasingFunction>.Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount
	|-IndexedCollectionPropertyBag<object, TimeValue>.Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount
	|
	|-RVA: 0x1096AC0 Offset: 0x10950C0 VA: 0x181096AC0
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 25
	protected virtual TList InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6D740 Offset: 0xA6BD40 VA: 0x180A6D740
	|-IndexedCollectionPropertyBag<object, EasingFunction>.InstantiateWithCount
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.InstantiateWithCount
	|-IndexedCollectionPropertyBag<object, TimeValue>.InstantiateWithCount
	|
	|-RVA: 0x1096720 Offset: 0x1094D20 VA: 0x181096720
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private int Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount(ref TList container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096CB0 Offset: 0x10952B0 VA: 0x181096CB0
	|-IndexedCollectionPropertyBag<object, EasingFunction>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount
	|-IndexedCollectionPropertyBag<object, TimeValue>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount
	|
	|-RVA: 0x1096BE0 Offset: 0x10951E0 VA: 0x181096BE0
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private IProperty<TList> Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096D50 Offset: 0x1095350 VA: 0x181096D50
	|-IndexedCollectionPropertyBag<object, EasingFunction>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty
	|-IndexedCollectionPropertyBag<object, TimeValue>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private IndexedCollectionSharedPropertyState Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096D00 Offset: 0x1095300 VA: 0x181096D00
	|-IndexedCollectionPropertyBag<object, EasingFunction>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState
	|-IndexedCollectionPropertyBag<object, TimeValue>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState(IndexedCollectionSharedPropertyState state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096D60 Offset: 0x1095360 VA: 0x181096D60
	|-IndexedCollectionPropertyBag<object, EasingFunction>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState
	|-IndexedCollectionPropertyBag<object, StylePropertyName>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState
	|-IndexedCollectionPropertyBag<object, TimeValue>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1096DD0 Offset: 0x10953D0 VA: 0x181096DD0
	|-IndexedCollectionPropertyBag<object, EasingFunction>..ctor
	|-IndexedCollectionPropertyBag<object, StylePropertyName>..ctor
	|-IndexedCollectionPropertyBag<object, TimeValue>..ctor
	|
	|-RVA: 0x1096EA0 Offset: 0x10954A0 VA: 0x181096EA0
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public interface IIndexedProperties<TContainer> // TypeDefIndex: 12951
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetProperty(ref TContainer container, int index, out IProperty<TContainer> property);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IIndexedProperties<__Il2CppFullySharedGenericType>.TryGetProperty
	*/
}

// Namespace: Unity.Properties
public interface INamedProperties<TContainer> // TypeDefIndex: 12952
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INamedProperties<__Il2CppFullySharedGenericType>.TryGetProperty
	*/
}

// Namespace: Unity.Properties
public interface IKeyedProperties<TContainer, TKey> // TypeDefIndex: 12953
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetProperty(ref TContainer container, TKey key, out IProperty<TContainer> property);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IKeyedProperties<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetProperty
	*/
}

// Namespace: Unity.Properties
public interface IPropertyBag // TypeDefIndex: 12954
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Accept(ITypeVisitor visitor);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Accept(IPropertyBagVisitor visitor, ref object container);
}

// Namespace: Unity.Properties
public interface IPropertyBag<TContainer> : IPropertyBag // TypeDefIndex: 12955
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract PropertyCollection<TContainer> GetProperties();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPropertyBag<__Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract PropertyCollection<TContainer> GetProperties(ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPropertyBag<__Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Accept(IPropertyBagVisitor visitor, ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPropertyBag<__Il2CppFullySharedGenericType>.Accept
	*/
}

// Namespace: Unity.Properties
public interface ICollectionPropertyBag<TCollection, TElement> : IPropertyBag<TCollection>, IPropertyBag, ICollectionPropertyBagAccept<TCollection> // TypeDefIndex: 12956
{}

// Namespace: Unity.Properties
public interface IListPropertyBag<TList, TElement> : ICollectionPropertyBag<TList, TElement>, IPropertyBag<TList>, IPropertyBag, ICollectionPropertyBagAccept<TList>, IListPropertyBagAccept<TList>, IListPropertyAccept<TList>, IIndexedProperties<TList> // TypeDefIndex: 12957
{}

// Namespace: Unity.Properties
public interface ISetPropertyBag<TSet, TElement> : ICollectionPropertyBag<TSet, TElement>, IPropertyBag<TSet>, IPropertyBag, ICollectionPropertyBagAccept<TSet>, ISetPropertyBagAccept<TSet>, IKeyedProperties<TSet, object> // TypeDefIndex: 12958
{}

// Namespace: Unity.Properties
public interface IDictionaryPropertyBag<TDictionary, TKey, TValue> : ICollectionPropertyBag<TDictionary, KeyValuePair<TKey, TValue>>, IPropertyBag<TDictionary>, IPropertyBag, ICollectionPropertyBagAccept<TDictionary>, IDictionaryPropertyBagAccept<TDictionary>, IKeyedProperties<TDictionary, object> // TypeDefIndex: 12959
{}

// Namespace: Unity.Properties
public class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : PropertyBag<TDictionary>, IDictionaryPropertyBag<TDictionary, TKey, TValue>, ICollectionPropertyBag<TDictionary, KeyValuePair<TKey, TValue>>, IPropertyBag<TDictionary>, IPropertyBag, ICollectionPropertyBagAccept<TDictionary>, IDictionaryPropertyBagAccept<TDictionary>, IKeyedProperties<TDictionary, object> // TypeDefIndex: 12963
{
	// Fields
	private readonly KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> m_KeyValuePairProperty; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public override PropertyCollection<TDictionary> GetProperties() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96A310 Offset: 0x968910 VA: 0x18096A310
	|-KeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override PropertyCollection<TDictionary> GetProperties(ref TDictionary container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101740 Offset: 0x10FFD40 VA: 0x181101740
	|-KeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void Unity.Properties.ICollectionPropertyBagAccept<TDictionary>.Accept(ICollectionPropertyBagVisitor visitor, ref TDictionary container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96A680 Offset: 0x968C80 VA: 0x18096A680
	|-KeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.ICollectionPropertyBagAccept<TDictionary>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void Unity.Properties.IDictionaryPropertyBagAccept<TDictionary>.Accept(IDictionaryPropertyBagVisitor visitor, ref TDictionary container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96A6B0 Offset: 0x968CB0 VA: 0x18096A6B0
	|-KeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IDictionaryPropertyBagAccept<TDictionary>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool Unity.Properties.IKeyedProperties<TDictionary,System.Object>.TryGetProperty(ref TDictionary container, object key, out IProperty<TDictionary> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101970 Offset: 0x10FFF70 VA: 0x181101970
	|-KeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IKeyedProperties<TDictionary,System.Object>.TryGetProperty
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101BC0 Offset: 0x11001C0 VA: 0x181101BC0
	|-KeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class KeyValuePairPropertyBag<TKey, TValue> : PropertyBag<KeyValuePair<TKey, TValue>>, INamedProperties<KeyValuePair<TKey, TValue>> // TypeDefIndex: 12966
{
	// Fields
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TKey> s_KeyProperty; // 0x0
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TValue> s_ValueProperty; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public override PropertyCollection<KeyValuePair<TKey, TValue>> GetProperties() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101D40 Offset: 0x1100340 VA: 0x181101D40
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override PropertyCollection<KeyValuePair<TKey, TValue>> GetProperties(ref KeyValuePair<TKey, TValue> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101E90 Offset: 0x1100490 VA: 0x181101E90
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetProperties
	*/

	[IteratorStateMachine(typeof(KeyValuePairPropertyBag.<GetPropertiesEnumerable>d__4<TKey, TValue>))]
	// RVA: -1 Offset: -1
	private static IEnumerable<IProperty<KeyValuePair<TKey, TValue>>> GetPropertiesEnumerable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101C90 Offset: 0x1100290 VA: 0x181101C90
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetPropertiesEnumerable
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool TryGetProperty(ref KeyValuePair<TKey, TValue> container, string name, out IProperty<KeyValuePair<TKey, TValue>> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101FE0 Offset: 0x11005E0 VA: 0x181101FE0
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetProperty
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1102600 Offset: 0x1100C00 VA: 0x181102600
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1102140 Offset: 0x1100740 VA: 0x181102140
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Properties
public class ListPropertyBag<TElement> : IndexedCollectionPropertyBag<List<TElement>, TElement> // TypeDefIndex: 12967
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	|-ListPropertyBag<EasingFunction>.get_InstantiationKind
	|-ListPropertyBag<StylePropertyName>.get_InstantiationKind
	|-ListPropertyBag<TimeValue>.get_InstantiationKind
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 25
	protected override List<TElement> InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11226F0 Offset: 0x1120CF0 VA: 0x1811226F0
	|-ListPropertyBag<EasingFunction>.InstantiateWithCount
	|-ListPropertyBag<StylePropertyName>.InstantiateWithCount
	|-ListPropertyBag<TimeValue>.InstantiateWithCount
	|
	|-RVA: 0x1122760 Offset: 0x1120D60 VA: 0x181122760
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected override List<TElement> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11227D0 Offset: 0x1120DD0 VA: 0x1811227D0
	|-ListPropertyBag<EasingFunction>.Instantiate
	|-ListPropertyBag<StylePropertyName>.Instantiate
	|-ListPropertyBag<TimeValue>.Instantiate
	|
	|-RVA: 0x1122830 Offset: 0x1120E30 VA: 0x181122830
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1122890 Offset: 0x1120E90 VA: 0x181122890
	|-ListPropertyBag<EasingFunction>..ctor
	|-ListPropertyBag<StylePropertyName>..ctor
	|-ListPropertyBag<TimeValue>..ctor
	|
	|-RVA: 0x969EF0 Offset: 0x9684F0 VA: 0x180969EF0
	|-ListPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public static class PropertyBag // TypeDefIndex: 12968
{
	// Methods

	// RVA: -1 Offset: -1
	public static void AcceptWithSpecializedVisitor<TContainer>(IPropertyBag<TContainer> properties, IPropertyBagVisitor visitor, ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74BEF0 Offset: 0x74A4F0 VA: 0x18074BEF0
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleEnum<Int32Enum>>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleList<EasingFunction>>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleList<StylePropertyName>>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleList<TimeValue>>
	|-PropertyBag.AcceptWithSpecializedVisitor<Angle>
	|-PropertyBag.AcceptWithSpecializedVisitor<Background>
	|-PropertyBag.AcceptWithSpecializedVisitor<BackgroundPosition>
	|-PropertyBag.AcceptWithSpecializedVisitor<BackgroundRepeat>
	|-PropertyBag.AcceptWithSpecializedVisitor<BackgroundSize>
	|-PropertyBag.AcceptWithSpecializedVisitor<Bounds>
	|-PropertyBag.AcceptWithSpecializedVisitor<BoundsInt>
	|-PropertyBag.AcceptWithSpecializedVisitor<Color>
	|-PropertyBag.AcceptWithSpecializedVisitor<Cursor>
	|-PropertyBag.AcceptWithSpecializedVisitor<EasingFunction>
	|-PropertyBag.AcceptWithSpecializedVisitor<FontDefinition>
	|-PropertyBag.AcceptWithSpecializedVisitor<int>
	|-PropertyBag.AcceptWithSpecializedVisitor<Int32Enum>
	|-PropertyBag.AcceptWithSpecializedVisitor<Length>
	|-PropertyBag.AcceptWithSpecializedVisitor<object>
	|-PropertyBag.AcceptWithSpecializedVisitor<Rect>
	|-PropertyBag.AcceptWithSpecializedVisitor<RectInt>
	|-PropertyBag.AcceptWithSpecializedVisitor<Rotate>
	|-PropertyBag.AcceptWithSpecializedVisitor<Scale>
	|-PropertyBag.AcceptWithSpecializedVisitor<float>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleBackground>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleBackgroundPosition>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleBackgroundRepeat>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleBackgroundSize>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleColor>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleCursor>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleFloat>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleFont>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleFontDefinition>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleInt>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleLength>
	|-PropertyBag.AcceptWithSpecializedVisitor<StylePropertyName>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleRotate>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleScale>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleTextShadow>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleTransformOrigin>
	|-PropertyBag.AcceptWithSpecializedVisitor<StyleTranslate>
	|-PropertyBag.AcceptWithSpecializedVisitor<TextShadow>
	|-PropertyBag.AcceptWithSpecializedVisitor<TimeValue>
	|-PropertyBag.AcceptWithSpecializedVisitor<TransformOrigin>
	|-PropertyBag.AcceptWithSpecializedVisitor<Translate>
	|-PropertyBag.AcceptWithSpecializedVisitor<Vector2>
	|-PropertyBag.AcceptWithSpecializedVisitor<Vector2Int>
	|-PropertyBag.AcceptWithSpecializedVisitor<Vector3>
	|-PropertyBag.AcceptWithSpecializedVisitor<Vector3Int>
	|-PropertyBag.AcceptWithSpecializedVisitor<Vector4>
	|-PropertyBag.AcceptWithSpecializedVisitor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Register<TContainer>(PropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74C480 Offset: 0x74AA80 VA: 0x18074C480
	|-PropertyBag.Register<StyleEnum<Int32Enum>>
	|-PropertyBag.Register<StyleList<EasingFunction>>
	|-PropertyBag.Register<StyleList<StylePropertyName>>
	|-PropertyBag.Register<StyleList<TimeValue>>
	|-PropertyBag.Register<Angle>
	|-PropertyBag.Register<Background>
	|-PropertyBag.Register<BackgroundPosition>
	|-PropertyBag.Register<Bounds>
	|-PropertyBag.Register<BoundsInt>
	|-PropertyBag.Register<Rect>
	|-PropertyBag.Register<RectInt>
	|-PropertyBag.Register<Vector2Int>
	|-PropertyBag.Register<Vector4>
	|
	|-RVA: 0x74C4F0 Offset: 0x74AAF0 VA: 0x18074C4F0
	|-PropertyBag.Register<BackgroundRepeat>
	|-PropertyBag.Register<BackgroundSize>
	|-PropertyBag.Register<Color>
	|-PropertyBag.Register<Cursor>
	|-PropertyBag.Register<EasingFunction>
	|-PropertyBag.Register<FontDefinition>
	|-PropertyBag.Register<Length>
	|-PropertyBag.Register<object>
	|-PropertyBag.Register<Rotate>
	|-PropertyBag.Register<Scale>
	|-PropertyBag.Register<StyleBackground>
	|-PropertyBag.Register<StyleBackgroundPosition>
	|-PropertyBag.Register<StyleBackgroundRepeat>
	|-PropertyBag.Register<StyleBackgroundSize>
	|-PropertyBag.Register<StyleColor>
	|-PropertyBag.Register<StyleCursor>
	|-PropertyBag.Register<StyleFloat>
	|-PropertyBag.Register<StyleFont>
	|-PropertyBag.Register<StyleFontDefinition>
	|-PropertyBag.Register<StyleInt>
	|-PropertyBag.Register<StyleLength>
	|-PropertyBag.Register<StylePropertyName>
	|-PropertyBag.Register<StyleRotate>
	|-PropertyBag.Register<StyleScale>
	|-PropertyBag.Register<StyleTextShadow>
	|-PropertyBag.Register<StyleTransformOrigin>
	|-PropertyBag.Register<StyleTranslate>
	|-PropertyBag.Register<TextShadow>
	|-PropertyBag.Register<TimeValue>
	|-PropertyBag.Register<TransformOrigin>
	|-PropertyBag.Register<Translate>
	|-PropertyBag.Register<Vector2>
	|-PropertyBag.Register<Vector3>
	|-PropertyBag.Register<Vector3Int>
	|
	|-RVA: 0x74C560 Offset: 0x74AB60 VA: 0x18074C560
	|-PropertyBag.Register<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void RegisterList<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74C200 Offset: 0x74A800 VA: 0x18074C200
	|-PropertyBag.RegisterList<EasingFunction>
	|-PropertyBag.RegisterList<StylePropertyName>
	|-PropertyBag.RegisterList<TimeValue>
	|
	|-RVA: 0x74C2F0 Offset: 0x74A8F0 VA: 0x18074C2F0
	|-PropertyBag.RegisterList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void RegisterList<TContainer, TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74C3B0 Offset: 0x74A9B0 VA: 0x18074C3B0
	|-PropertyBag.RegisterList<StyleList<EasingFunction>, EasingFunction>
	|-PropertyBag.RegisterList<StyleList<StylePropertyName>, StylePropertyName>
	|-PropertyBag.RegisterList<StyleList<TimeValue>, TimeValue>
	|
	|-RVA: 0x74C2C0 Offset: 0x74A8C0 VA: 0x18074C2C0
	|-PropertyBag.RegisterList<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23D5160 Offset: 0x23D3760 VA: 0x1823D5160
	public static IPropertyBag GetPropertyBag(Type type) { }

	// RVA: -1 Offset: -1
	public static IPropertyBag<TContainer> GetPropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74C140 Offset: 0x74A740 VA: 0x18074C140
	|-PropertyBag.GetPropertyBag<StyleEnum<Int32Enum>>
	|-PropertyBag.GetPropertyBag<StyleList<EasingFunction>>
	|-PropertyBag.GetPropertyBag<StyleList<StylePropertyName>>
	|-PropertyBag.GetPropertyBag<StyleList<TimeValue>>
	|-PropertyBag.GetPropertyBag<Angle>
	|-PropertyBag.GetPropertyBag<Background>
	|-PropertyBag.GetPropertyBag<BackgroundPosition>
	|-PropertyBag.GetPropertyBag<BackgroundRepeat>
	|-PropertyBag.GetPropertyBag<BackgroundSize>
	|-PropertyBag.GetPropertyBag<Bounds>
	|-PropertyBag.GetPropertyBag<BoundsInt>
	|-PropertyBag.GetPropertyBag<Color>
	|-PropertyBag.GetPropertyBag<Cursor>
	|-PropertyBag.GetPropertyBag<EasingFunction>
	|-PropertyBag.GetPropertyBag<FontDefinition>
	|-PropertyBag.GetPropertyBag<Length>
	|-PropertyBag.GetPropertyBag<object>
	|-PropertyBag.GetPropertyBag<Rect>
	|-PropertyBag.GetPropertyBag<RectInt>
	|-PropertyBag.GetPropertyBag<Rotate>
	|-PropertyBag.GetPropertyBag<Scale>
	|-PropertyBag.GetPropertyBag<StyleBackground>
	|-PropertyBag.GetPropertyBag<StyleBackgroundPosition>
	|-PropertyBag.GetPropertyBag<StyleBackgroundRepeat>
	|-PropertyBag.GetPropertyBag<StyleBackgroundSize>
	|-PropertyBag.GetPropertyBag<StyleColor>
	|-PropertyBag.GetPropertyBag<StyleCursor>
	|-PropertyBag.GetPropertyBag<StyleFloat>
	|-PropertyBag.GetPropertyBag<StyleFont>
	|-PropertyBag.GetPropertyBag<StyleFontDefinition>
	|-PropertyBag.GetPropertyBag<StyleInt>
	|-PropertyBag.GetPropertyBag<StyleLength>
	|-PropertyBag.GetPropertyBag<StylePropertyName>
	|-PropertyBag.GetPropertyBag<StyleRotate>
	|-PropertyBag.GetPropertyBag<StyleScale>
	|-PropertyBag.GetPropertyBag<StyleTextShadow>
	|-PropertyBag.GetPropertyBag<StyleTransformOrigin>
	|-PropertyBag.GetPropertyBag<StyleTranslate>
	|-PropertyBag.GetPropertyBag<TextShadow>
	|-PropertyBag.GetPropertyBag<TimeValue>
	|-PropertyBag.GetPropertyBag<TransformOrigin>
	|-PropertyBag.GetPropertyBag<Translate>
	|-PropertyBag.GetPropertyBag<Vector2>
	|-PropertyBag.GetPropertyBag<Vector2Int>
	|-PropertyBag.GetPropertyBag<Vector3>
	|-PropertyBag.GetPropertyBag<Vector3Int>
	|-PropertyBag.GetPropertyBag<Vector4>
	|
	|-RVA: 0x74C1A0 Offset: 0x74A7A0 VA: 0x18074C1A0
	|-PropertyBag.GetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetPropertyBagForValue<TValue>(ref TValue value, out IPropertyBag propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x74D150 Offset: 0x74B750 VA: 0x18074D150
	|-PropertyBag.TryGetPropertyBagForValue<StyleEnum<Int32Enum>>
	|
	|-RVA: 0x74D4D0 Offset: 0x74BAD0 VA: 0x18074D4D0
	|-PropertyBag.TryGetPropertyBagForValue<StyleList<EasingFunction>>
	|
	|-RVA: 0x74D550 Offset: 0x74BB50 VA: 0x18074D550
	|-PropertyBag.TryGetPropertyBagForValue<StyleList<StylePropertyName>>
	|
	|-RVA: 0x74D450 Offset: 0x74BA50 VA: 0x18074D450
	|-PropertyBag.TryGetPropertyBagForValue<StyleList<TimeValue>>
	|
	|-RVA: 0x74C5D0 Offset: 0x74ABD0 VA: 0x18074C5D0
	|-PropertyBag.TryGetPropertyBagForValue<Angle>
	|
	|-RVA: 0x74C7D0 Offset: 0x74ADD0 VA: 0x18074C7D0
	|-PropertyBag.TryGetPropertyBagForValue<Background>
	|
	|-RVA: 0x74C650 Offset: 0x74AC50 VA: 0x18074C650
	|-PropertyBag.TryGetPropertyBagForValue<BackgroundPosition>
	|
	|-RVA: 0x74C6D0 Offset: 0x74ACD0 VA: 0x18074C6D0
	|-PropertyBag.TryGetPropertyBagForValue<BackgroundRepeat>
	|
	|-RVA: 0x74C750 Offset: 0x74AD50 VA: 0x18074C750
	|-PropertyBag.TryGetPropertyBagForValue<BackgroundSize>
	|
	|-RVA: 0x74C850 Offset: 0x74AE50 VA: 0x18074C850
	|-PropertyBag.TryGetPropertyBagForValue<Color>
	|
	|-RVA: 0x74C8D0 Offset: 0x74AED0 VA: 0x18074C8D0
	|-PropertyBag.TryGetPropertyBagForValue<Cursor>
	|
	|-RVA: 0x74C950 Offset: 0x74AF50 VA: 0x18074C950
	|-PropertyBag.TryGetPropertyBagForValue<EasingFunction>
	|
	|-RVA: 0x74C9D0 Offset: 0x74AFD0 VA: 0x18074C9D0
	|-PropertyBag.TryGetPropertyBagForValue<FontDefinition>
	|
	|-RVA: 0x74CB50 Offset: 0x74B150 VA: 0x18074CB50
	|-PropertyBag.TryGetPropertyBagForValue<int>
	|
	|-RVA: 0x74CAD0 Offset: 0x74B0D0 VA: 0x18074CAD0
	|-PropertyBag.TryGetPropertyBagForValue<Int32Enum>
	|
	|-RVA: 0x74CBD0 Offset: 0x74B1D0 VA: 0x18074CBD0
	|-PropertyBag.TryGetPropertyBagForValue<Length>
	|
	|-RVA: 0x74CCD0 Offset: 0x74B2D0 VA: 0x18074CCD0
	|-PropertyBag.TryGetPropertyBagForValue<object>
	|
	|-RVA: 0x74CC50 Offset: 0x74B250 VA: 0x18074CC50
	|-PropertyBag.TryGetPropertyBagForValue<Rotate>
	|
	|-RVA: 0x74CD50 Offset: 0x74B350 VA: 0x18074CD50
	|-PropertyBag.TryGetPropertyBagForValue<Scale>
	|
	|-RVA: 0x74CDD0 Offset: 0x74B3D0 VA: 0x18074CDD0
	|-PropertyBag.TryGetPropertyBagForValue<float>
	|
	|-RVA: 0x74CFD0 Offset: 0x74B5D0 VA: 0x18074CFD0
	|-PropertyBag.TryGetPropertyBagForValue<StyleBackground>
	|
	|-RVA: 0x74CE50 Offset: 0x74B450 VA: 0x18074CE50
	|-PropertyBag.TryGetPropertyBagForValue<StyleBackgroundPosition>
	|
	|-RVA: 0x74CED0 Offset: 0x74B4D0 VA: 0x18074CED0
	|-PropertyBag.TryGetPropertyBagForValue<StyleBackgroundRepeat>
	|
	|-RVA: 0x74CF50 Offset: 0x74B550 VA: 0x18074CF50
	|-PropertyBag.TryGetPropertyBagForValue<StyleBackgroundSize>
	|
	|-RVA: 0x74D050 Offset: 0x74B650 VA: 0x18074D050
	|-PropertyBag.TryGetPropertyBagForValue<StyleColor>
	|
	|-RVA: 0x74D0D0 Offset: 0x74B6D0 VA: 0x18074D0D0
	|-PropertyBag.TryGetPropertyBagForValue<StyleCursor>
	|
	|-RVA: 0x74D1D0 Offset: 0x74B7D0 VA: 0x18074D1D0
	|-PropertyBag.TryGetPropertyBagForValue<StyleFloat>
	|
	|-RVA: 0x74D2D0 Offset: 0x74B8D0 VA: 0x18074D2D0
	|-PropertyBag.TryGetPropertyBagForValue<StyleFont>
	|
	|-RVA: 0x74D250 Offset: 0x74B850 VA: 0x18074D250
	|-PropertyBag.TryGetPropertyBagForValue<StyleFontDefinition>
	|
	|-RVA: 0x74D350 Offset: 0x74B950 VA: 0x18074D350
	|-PropertyBag.TryGetPropertyBagForValue<StyleInt>
	|
	|-RVA: 0x74D3D0 Offset: 0x74B9D0 VA: 0x18074D3D0
	|-PropertyBag.TryGetPropertyBagForValue<StyleLength>
	|
	|-RVA: 0x74D5D0 Offset: 0x74BBD0 VA: 0x18074D5D0
	|-PropertyBag.TryGetPropertyBagForValue<StylePropertyName>
	|
	|-RVA: 0x74D650 Offset: 0x74BC50 VA: 0x18074D650
	|-PropertyBag.TryGetPropertyBagForValue<StyleRotate>
	|
	|-RVA: 0x74D6D0 Offset: 0x74BCD0 VA: 0x18074D6D0
	|-PropertyBag.TryGetPropertyBagForValue<StyleScale>
	|
	|-RVA: 0x74D750 Offset: 0x74BD50 VA: 0x18074D750
	|-PropertyBag.TryGetPropertyBagForValue<StyleTextShadow>
	|
	|-RVA: 0x74D7D0 Offset: 0x74BDD0 VA: 0x18074D7D0
	|-PropertyBag.TryGetPropertyBagForValue<StyleTransformOrigin>
	|
	|-RVA: 0x74D850 Offset: 0x74BE50 VA: 0x18074D850
	|-PropertyBag.TryGetPropertyBagForValue<StyleTranslate>
	|
	|-RVA: 0x74D8D0 Offset: 0x74BED0 VA: 0x18074D8D0
	|-PropertyBag.TryGetPropertyBagForValue<TextShadow>
	|
	|-RVA: 0x74D950 Offset: 0x74BF50 VA: 0x18074D950
	|-PropertyBag.TryGetPropertyBagForValue<TimeValue>
	|
	|-RVA: 0x74D9D0 Offset: 0x74BFD0 VA: 0x18074D9D0
	|-PropertyBag.TryGetPropertyBagForValue<TransformOrigin>
	|
	|-RVA: 0x74DA50 Offset: 0x74C050 VA: 0x18074DA50
	|-PropertyBag.TryGetPropertyBagForValue<Translate>
	|
	|-RVA: 0x74DAD0 Offset: 0x74C0D0 VA: 0x18074DAD0
	|-PropertyBag.TryGetPropertyBagForValue<Vector2>
	|
	|-RVA: 0x74DBD0 Offset: 0x74C1D0 VA: 0x18074DBD0
	|-PropertyBag.TryGetPropertyBagForValue<Vector3>
	|
	|-RVA: 0x74DB50 Offset: 0x74C150 VA: 0x18074DB50
	|-PropertyBag.TryGetPropertyBagForValue<Vector3Int>
	|
	|-RVA: 0x74CA50 Offset: 0x74B050 VA: 0x18074CA50
	|-PropertyBag.TryGetPropertyBagForValue<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public abstract class PropertyBag<TContainer> : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor // TypeDefIndex: 12969
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Properties
	private InstantiationKind Unity.Properties.IConstructor.InstantiationKind { get; }
	protected virtual InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B06F0 Offset: 0x8AECF0 VA: 0x1808B06F0
	|-PropertyBag<StyleEnum<Int32Enum>>..cctor
	|-PropertyBag<StyleList<EasingFunction>>..cctor
	|-PropertyBag<StyleList<StylePropertyName>>..cctor
	|-PropertyBag<StyleList<TimeValue>>..cctor
	|-PropertyBag<Angle>..cctor
	|-PropertyBag<Background>..cctor
	|-PropertyBag<BackgroundPosition>..cctor
	|-PropertyBag<BackgroundRepeat>..cctor
	|-PropertyBag<BackgroundSize>..cctor
	|-PropertyBag<Bounds>..cctor
	|-PropertyBag<BoundsInt>..cctor
	|-PropertyBag<Color>..cctor
	|-PropertyBag<Cursor>..cctor
	|-PropertyBag<EasingFunction>..cctor
	|-PropertyBag<FontDefinition>..cctor
	|-PropertyBag<Length>..cctor
	|-PropertyBag<object>..cctor
	|-PropertyBag<Rect>..cctor
	|-PropertyBag<RectInt>..cctor
	|-PropertyBag<Rotate>..cctor
	|-PropertyBag<Scale>..cctor
	|-PropertyBag<StyleBackground>..cctor
	|-PropertyBag<StyleBackgroundPosition>..cctor
	|-PropertyBag<StyleBackgroundRepeat>..cctor
	|-PropertyBag<StyleBackgroundSize>..cctor
	|-PropertyBag<StyleColor>..cctor
	|-PropertyBag<StyleCursor>..cctor
	|-PropertyBag<StyleFloat>..cctor
	|-PropertyBag<StyleFont>..cctor
	|-PropertyBag<StyleFontDefinition>..cctor
	|-PropertyBag<StyleInt>..cctor
	|-PropertyBag<StyleLength>..cctor
	|-PropertyBag<StylePropertyName>..cctor
	|-PropertyBag<StyleRotate>..cctor
	|-PropertyBag<StyleScale>..cctor
	|-PropertyBag<StyleTextShadow>..cctor
	|-PropertyBag<StyleTransformOrigin>..cctor
	|-PropertyBag<StyleTranslate>..cctor
	|-PropertyBag<TextShadow>..cctor
	|-PropertyBag<TimeValue>..cctor
	|-PropertyBag<TransformOrigin>..cctor
	|-PropertyBag<Translate>..cctor
	|-PropertyBag<Vector2>..cctor
	|-PropertyBag<Vector2Int>..cctor
	|-PropertyBag<Vector3>..cctor
	|-PropertyBag<Vector3Int>..cctor
	|-PropertyBag<Vector4>..cctor
	|-PropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void Unity.Properties.Internal.IPropertyBagRegister.Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F8920 Offset: 0x12F6F20 VA: 0x1812F8920
	|-PropertyBag<StyleEnum<Int32Enum>>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8760 Offset: 0x12F6D60 VA: 0x1812F8760
	|-PropertyBag<StyleList<EasingFunction>>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F80D0 Offset: 0x12F66D0 VA: 0x1812F80D0
	|-PropertyBag<StyleList<StylePropertyName>>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8C30 Offset: 0x12F7230 VA: 0x1812F8C30
	|-PropertyBag<StyleList<TimeValue>>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8680 Offset: 0x12F6C80 VA: 0x1812F8680
	|-PropertyBag<Angle>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8290 Offset: 0x12F6890 VA: 0x1812F8290
	|-PropertyBag<Background>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7B90 Offset: 0x12F6190 VA: 0x1812F7B90
	|-PropertyBag<BackgroundPosition>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7CE0 Offset: 0x12F62E0 VA: 0x1812F7CE0
	|-PropertyBag<BackgroundRepeat>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F88B0 Offset: 0x12F6EB0 VA: 0x1812F88B0
	|-PropertyBag<BackgroundSize>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7FF0 Offset: 0x12F65F0 VA: 0x1812F7FF0
	|-PropertyBag<Bounds>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7EA0 Offset: 0x12F64A0 VA: 0x1812F7EA0
	|-PropertyBag<BoundsInt>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8140 Offset: 0x12F6740 VA: 0x1812F8140
	|-PropertyBag<Color>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F84C0 Offset: 0x12F6AC0 VA: 0x1812F84C0
	|-PropertyBag<Cursor>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7C00 Offset: 0x12F6200 VA: 0x1812F7C00
	|-PropertyBag<EasingFunction>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7E30 Offset: 0x12F6430 VA: 0x1812F7E30
	|-PropertyBag<FontDefinition>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8840 Offset: 0x12F6E40 VA: 0x1812F8840
	|-PropertyBag<Length>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8B50 Offset: 0x12F7150 VA: 0x1812F8B50
	|-PropertyBag<object>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8A70 Offset: 0x12F7070 VA: 0x1812F8A70
	|-PropertyBag<Rect>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7960 Offset: 0x12F5F60 VA: 0x1812F7960
	|-PropertyBag<RectInt>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7DC0 Offset: 0x12F63C0 VA: 0x1812F7DC0
	|-PropertyBag<Rotate>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8610 Offset: 0x12F6C10 VA: 0x1812F8610
	|-PropertyBag<Scale>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7D50 Offset: 0x12F6350 VA: 0x1812F7D50
	|-PropertyBag<StyleBackground>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F79D0 Offset: 0x12F5FD0 VA: 0x1812F79D0
	|-PropertyBag<StyleBackgroundPosition>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8A00 Offset: 0x12F7000 VA: 0x1812F8A00
	|-PropertyBag<StyleBackgroundRepeat>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8CA0 Offset: 0x12F72A0 VA: 0x1812F8CA0
	|-PropertyBag<StyleBackgroundSize>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7C70 Offset: 0x12F6270 VA: 0x1812F7C70
	|-PropertyBag<StyleColor>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8300 Offset: 0x12F6900 VA: 0x1812F8300
	|-PropertyBag<StyleCursor>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7F10 Offset: 0x12F6510 VA: 0x1812F7F10
	|-PropertyBag<StyleFloat>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7A40 Offset: 0x12F6040 VA: 0x1812F7A40
	|-PropertyBag<StyleFont>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7B20 Offset: 0x12F6120 VA: 0x1812F7B20
	|-PropertyBag<StyleFontDefinition>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F83E0 Offset: 0x12F69E0 VA: 0x1812F83E0
	|-PropertyBag<StyleInt>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8530 Offset: 0x12F6B30 VA: 0x1812F8530
	|-PropertyBag<StyleLength>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8060 Offset: 0x12F6660 VA: 0x1812F8060
	|-PropertyBag<StylePropertyName>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8220 Offset: 0x12F6820 VA: 0x1812F8220
	|-PropertyBag<StyleRotate>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8450 Offset: 0x12F6A50 VA: 0x1812F8450
	|-PropertyBag<StyleScale>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F86F0 Offset: 0x12F6CF0 VA: 0x1812F86F0
	|-PropertyBag<StyleTextShadow>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7AB0 Offset: 0x12F60B0 VA: 0x1812F7AB0
	|-PropertyBag<StyleTransformOrigin>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F85A0 Offset: 0x12F6BA0 VA: 0x1812F85A0
	|-PropertyBag<StyleTranslate>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8AE0 Offset: 0x12F70E0 VA: 0x1812F8AE0
	|-PropertyBag<TextShadow>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F7F80 Offset: 0x12F6580 VA: 0x1812F7F80
	|-PropertyBag<TimeValue>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F87D0 Offset: 0x12F6DD0 VA: 0x1812F87D0
	|-PropertyBag<TransformOrigin>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8990 Offset: 0x12F6F90 VA: 0x1812F8990
	|-PropertyBag<Translate>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F81B0 Offset: 0x12F67B0 VA: 0x1812F81B0
	|-PropertyBag<Vector2>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8370 Offset: 0x12F6970 VA: 0x1812F8370
	|-PropertyBag<Vector2Int>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x12F8BC0 Offset: 0x12F71C0 VA: 0x1812F8BC0
	|-PropertyBag<Vector3>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x8B0680 Offset: 0x8AEC80 VA: 0x1808B0680
	|-PropertyBag<Vector3Int>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x8B05A0 Offset: 0x8AEBA0 VA: 0x1808B05A0
	|-PropertyBag<Vector4>.Unity.Properties.Internal.IPropertyBagRegister.Register
	|
	|-RVA: 0x8B0610 Offset: 0x8AEC10 VA: 0x1808B0610
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.Internal.IPropertyBagRegister.Register
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Accept(ITypeVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8AF870 Offset: 0x8ADE70 VA: 0x1808AF870
	|-PropertyBag<StyleEnum<Int32Enum>>.Accept
	|-PropertyBag<StyleList<EasingFunction>>.Accept
	|-PropertyBag<StyleList<StylePropertyName>>.Accept
	|-PropertyBag<StyleList<TimeValue>>.Accept
	|-PropertyBag<Angle>.Accept
	|-PropertyBag<Background>.Accept
	|-PropertyBag<BackgroundPosition>.Accept
	|-PropertyBag<BackgroundRepeat>.Accept
	|-PropertyBag<BackgroundSize>.Accept
	|-PropertyBag<Bounds>.Accept
	|-PropertyBag<BoundsInt>.Accept
	|-PropertyBag<Color>.Accept
	|-PropertyBag<Cursor>.Accept
	|-PropertyBag<EasingFunction>.Accept
	|-PropertyBag<FontDefinition>.Accept
	|-PropertyBag<Length>.Accept
	|-PropertyBag<object>.Accept
	|-PropertyBag<Rect>.Accept
	|-PropertyBag<RectInt>.Accept
	|-PropertyBag<Rotate>.Accept
	|-PropertyBag<Scale>.Accept
	|-PropertyBag<StyleBackground>.Accept
	|-PropertyBag<StyleBackgroundPosition>.Accept
	|-PropertyBag<StyleBackgroundRepeat>.Accept
	|-PropertyBag<StyleBackgroundSize>.Accept
	|-PropertyBag<StyleColor>.Accept
	|-PropertyBag<StyleCursor>.Accept
	|-PropertyBag<StyleFloat>.Accept
	|-PropertyBag<StyleFont>.Accept
	|-PropertyBag<StyleFontDefinition>.Accept
	|-PropertyBag<StyleInt>.Accept
	|-PropertyBag<StyleLength>.Accept
	|-PropertyBag<StylePropertyName>.Accept
	|-PropertyBag<StyleRotate>.Accept
	|-PropertyBag<StyleScale>.Accept
	|-PropertyBag<StyleTextShadow>.Accept
	|-PropertyBag<StyleTransformOrigin>.Accept
	|-PropertyBag<StyleTranslate>.Accept
	|-PropertyBag<TextShadow>.Accept
	|-PropertyBag<TimeValue>.Accept
	|-PropertyBag<TransformOrigin>.Accept
	|-PropertyBag<Translate>.Accept
	|-PropertyBag<Vector2>.Accept
	|-PropertyBag<Vector2Int>.Accept
	|-PropertyBag<Vector3>.Accept
	|-PropertyBag<Vector3Int>.Accept
	|-PropertyBag<Vector4>.Accept
	|-PropertyBag<__Il2CppFullySharedGenericType>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void Unity.Properties.IPropertyBag.Accept(IPropertyBagVisitor visitor, ref object container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F6B90 Offset: 0x12F5190 VA: 0x1812F6B90
	|-PropertyBag<StyleEnum<Int32Enum>>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Angle>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<BackgroundRepeat>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Length>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleFloat>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleInt>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<TimeValue>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Vector2Int>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x12F6990 Offset: 0x12F4F90 VA: 0x1812F6990
	|-PropertyBag<StyleList<EasingFunction>>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleList<StylePropertyName>>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleList<TimeValue>>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<FontDefinition>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<RectInt>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Scale>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleBackgroundPosition>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleFont>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StylePropertyName>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x12F6D70 Offset: 0x12F5370 VA: 0x1812F6D70
	|-PropertyBag<Background>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleCursor>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleTextShadow>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x8AFF30 Offset: 0x8AE530 VA: 0x1808AFF30
	|-PropertyBag<BackgroundPosition>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleBackgroundRepeat>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleLength>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Vector3>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Vector3Int>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x12F7160 Offset: 0x12F5760 VA: 0x1812F7160
	|-PropertyBag<BackgroundSize>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleColor>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleScale>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<TransformOrigin>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x12F6770 Offset: 0x12F4D70 VA: 0x1812F6770
	|-PropertyBag<Bounds>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<BoundsInt>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Cursor>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Rotate>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleBackgroundSize>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleFontDefinition>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleTransformOrigin>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Translate>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x8B0140 Offset: 0x8AE740 VA: 0x1808B0140
	|-PropertyBag<Color>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Rect>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<Vector4>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x12F6F80 Offset: 0x12F5580 VA: 0x1812F6F80
	|-PropertyBag<EasingFunction>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x12F7370 Offset: 0x12F5970 VA: 0x1812F7370
	|-PropertyBag<object>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x12F7540 Offset: 0x12F5B40 VA: 0x1812F7540
	|-PropertyBag<StyleBackground>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x12F6540 Offset: 0x12F4B40 VA: 0x1812F6540
	|-PropertyBag<StyleRotate>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<StyleTranslate>.Unity.Properties.IPropertyBag.Accept
	|-PropertyBag<TextShadow>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x12F7770 Offset: 0x12F5D70 VA: 0x1812F7770
	|-PropertyBag<Vector2>.Unity.Properties.IPropertyBag.Accept
	|
	|-RVA: 0x8B0340 Offset: 0x8AE940 VA: 0x1808B0340
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IPropertyBag.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void Unity.Properties.IPropertyBag<TContainer>.Accept(IPropertyBagVisitor visitor, ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8AFBC0 Offset: 0x8AE1C0 VA: 0x1808AFBC0
	|-PropertyBag<StyleEnum<Int32Enum>>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleList<EasingFunction>>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleList<StylePropertyName>>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleList<TimeValue>>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Angle>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Background>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<BackgroundPosition>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<BackgroundRepeat>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<BackgroundSize>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Bounds>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<BoundsInt>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Color>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Cursor>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<EasingFunction>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<FontDefinition>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Length>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<object>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Rect>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<RectInt>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Rotate>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Scale>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleBackground>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleBackgroundPosition>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleBackgroundRepeat>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleBackgroundSize>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleColor>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleCursor>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleFloat>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleFont>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleFontDefinition>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleInt>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleLength>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StylePropertyName>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleRotate>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleScale>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleTextShadow>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleTransformOrigin>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<StyleTranslate>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<TextShadow>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<TimeValue>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<TransformOrigin>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Translate>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Vector2>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Vector2Int>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Vector3>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Vector3Int>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<Vector4>.Unity.Properties.IPropertyBag<TContainer>.Accept
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IPropertyBag<TContainer>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F63A0 Offset: 0x12F49A0 VA: 0x1812F63A0
	|-PropertyBag<StyleEnum<Int32Enum>>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Angle>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<BackgroundRepeat>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<EasingFunction>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Length>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<object>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleFloat>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleInt>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<TimeValue>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Vector2>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Vector2Int>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|
	|-RVA: 0x8AFCA0 Offset: 0x8AE2A0 VA: 0x1808AFCA0
	|-PropertyBag<StyleList<EasingFunction>>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleList<StylePropertyName>>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleList<TimeValue>>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<BackgroundPosition>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Color>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<FontDefinition>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Rect>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<RectInt>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Scale>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleBackgroundPosition>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleBackgroundRepeat>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleFont>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleLength>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StylePropertyName>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Vector3>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Vector3Int>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Vector4>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|
	|-RVA: 0x12F62E0 Offset: 0x12F48E0 VA: 0x1812F62E0
	|-PropertyBag<Background>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleCursor>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleRotate>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleTextShadow>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleTranslate>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<TextShadow>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|
	|-RVA: 0x12F6220 Offset: 0x12F4820 VA: 0x1812F6220
	|-PropertyBag<BackgroundSize>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Bounds>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<BoundsInt>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Cursor>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Rotate>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleBackgroundSize>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleColor>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleFontDefinition>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleScale>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleTransformOrigin>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<TransformOrigin>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Translate>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|
	|-RVA: 0x12F6460 Offset: 0x12F4A60 VA: 0x1812F6460
	|-PropertyBag<StyleBackground>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|
	|-RVA: 0x8AFCF0 Offset: 0x8AE2F0 VA: 0x1808AFCF0
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F6400 Offset: 0x12F4A00 VA: 0x1812F6400
	|-PropertyBag<StyleEnum<Int32Enum>>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Angle>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<BackgroundRepeat>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<EasingFunction>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Length>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<object>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleFloat>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleInt>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<TimeValue>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Vector2>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Vector2Int>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|
	|-RVA: 0x8AFDE0 Offset: 0x8AE3E0 VA: 0x1808AFDE0
	|-PropertyBag<StyleList<EasingFunction>>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleList<StylePropertyName>>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleList<TimeValue>>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<BackgroundPosition>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Color>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<FontDefinition>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Rect>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<RectInt>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Scale>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleBackgroundPosition>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleBackgroundRepeat>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleFont>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleLength>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StylePropertyName>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Vector3>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Vector3Int>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Vector4>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|
	|-RVA: 0x12F6340 Offset: 0x12F4940 VA: 0x1812F6340
	|-PropertyBag<Background>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleCursor>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleRotate>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleTextShadow>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleTranslate>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<TextShadow>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|
	|-RVA: 0x12F6280 Offset: 0x12F4880 VA: 0x1812F6280
	|-PropertyBag<BackgroundSize>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Bounds>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<BoundsInt>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Cursor>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Rotate>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleBackgroundSize>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleColor>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleFontDefinition>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleScale>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<StyleTransformOrigin>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<TransformOrigin>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|-PropertyBag<Translate>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|
	|-RVA: 0x12F64D0 Offset: 0x12F4AD0 VA: 0x1812F64D0
	|-PropertyBag<StyleBackground>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	|
	|-RVA: 0x8AFE30 Offset: 0x8AE430 VA: 0x1808AFE30
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IPropertyBag<TContainer>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8AFBA0 Offset: 0x8AE1A0 VA: 0x1808AFBA0
	|-PropertyBag<StyleEnum<Int32Enum>>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleList<EasingFunction>>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleList<StylePropertyName>>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleList<TimeValue>>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Angle>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Background>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<BackgroundPosition>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<BackgroundRepeat>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<BackgroundSize>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Bounds>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<BoundsInt>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Color>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Cursor>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<EasingFunction>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<FontDefinition>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Length>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<object>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Rect>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<RectInt>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Rotate>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Scale>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleBackground>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleBackgroundPosition>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleBackgroundRepeat>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleBackgroundSize>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleColor>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleCursor>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleFloat>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleFont>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleFontDefinition>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleInt>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleLength>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StylePropertyName>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleRotate>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleScale>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleTextShadow>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleTransformOrigin>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<StyleTranslate>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<TextShadow>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<TimeValue>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<TransformOrigin>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Translate>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Vector2>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Vector2Int>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Vector3>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Vector3Int>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<Vector4>.Unity.Properties.IConstructor.get_InstantiationKind
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IConstructor.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F6100 Offset: 0x12F4700 VA: 0x1812F6100
	|-PropertyBag<StyleEnum<Int32Enum>>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Angle>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<BackgroundRepeat>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<EasingFunction>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Length>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<object>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleFloat>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleInt>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<TimeValue>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Vector2Int>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x8AFA30 Offset: 0x8AE030 VA: 0x1808AFA30
	|-PropertyBag<StyleList<EasingFunction>>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleList<StylePropertyName>>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleList<TimeValue>>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Color>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<FontDefinition>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Rect>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<RectInt>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Scale>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleBackgroundPosition>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleFont>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StylePropertyName>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Vector4>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x12F61D0 Offset: 0x12F47D0 VA: 0x1812F61D0
	|-PropertyBag<Background>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleCursor>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleTextShadow>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x8AFB60 Offset: 0x8AE160 VA: 0x1808AFB60
	|-PropertyBag<BackgroundPosition>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleBackgroundRepeat>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleLength>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Vector3>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Vector3Int>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x12F6120 Offset: 0x12F4720 VA: 0x1812F6120
	|-PropertyBag<BackgroundSize>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleColor>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleScale>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<TransformOrigin>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x12F6090 Offset: 0x12F4690 VA: 0x1812F6090
	|-PropertyBag<Bounds>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<BoundsInt>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Cursor>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Rotate>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleBackgroundSize>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleFontDefinition>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleTransformOrigin>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<Translate>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x12F6170 Offset: 0x12F4770 VA: 0x1812F6170
	|-PropertyBag<StyleBackground>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x12F6040 Offset: 0x12F4640 VA: 0x1812F6040
	|-PropertyBag<StyleRotate>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<StyleTranslate>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|-PropertyBag<TextShadow>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x12F60E0 Offset: 0x12F46E0 VA: 0x1812F60E0
	|-PropertyBag<Vector2>.Unity.Properties.IConstructor<TContainer>.Instantiate
	|
	|-RVA: 0x8AFA70 Offset: 0x8AE070 VA: 0x1808AFA70
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IConstructor<TContainer>.Instantiate
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public abstract PropertyCollection<TContainer> GetProperties();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PropertyBag<__Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract PropertyCollection<TContainer> GetProperties(ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PropertyBag<__Il2CppFullySharedGenericType>.GetProperties
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	protected virtual InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	|-PropertyBag<StyleEnum<Int32Enum>>.get_InstantiationKind
	|-PropertyBag<StyleList<EasingFunction>>.get_InstantiationKind
	|-PropertyBag<StyleList<StylePropertyName>>.get_InstantiationKind
	|-PropertyBag<StyleList<TimeValue>>.get_InstantiationKind
	|-PropertyBag<Angle>.get_InstantiationKind
	|-PropertyBag<Background>.get_InstantiationKind
	|-PropertyBag<BackgroundPosition>.get_InstantiationKind
	|-PropertyBag<BackgroundRepeat>.get_InstantiationKind
	|-PropertyBag<BackgroundSize>.get_InstantiationKind
	|-PropertyBag<Bounds>.get_InstantiationKind
	|-PropertyBag<BoundsInt>.get_InstantiationKind
	|-PropertyBag<Color>.get_InstantiationKind
	|-PropertyBag<Cursor>.get_InstantiationKind
	|-PropertyBag<EasingFunction>.get_InstantiationKind
	|-PropertyBag<FontDefinition>.get_InstantiationKind
	|-PropertyBag<Length>.get_InstantiationKind
	|-PropertyBag<object>.get_InstantiationKind
	|-PropertyBag<Rect>.get_InstantiationKind
	|-PropertyBag<RectInt>.get_InstantiationKind
	|-PropertyBag<Rotate>.get_InstantiationKind
	|-PropertyBag<Scale>.get_InstantiationKind
	|-PropertyBag<StyleBackground>.get_InstantiationKind
	|-PropertyBag<StyleBackgroundPosition>.get_InstantiationKind
	|-PropertyBag<StyleBackgroundRepeat>.get_InstantiationKind
	|-PropertyBag<StyleBackgroundSize>.get_InstantiationKind
	|-PropertyBag<StyleColor>.get_InstantiationKind
	|-PropertyBag<StyleCursor>.get_InstantiationKind
	|-PropertyBag<StyleFloat>.get_InstantiationKind
	|-PropertyBag<StyleFont>.get_InstantiationKind
	|-PropertyBag<StyleFontDefinition>.get_InstantiationKind
	|-PropertyBag<StyleInt>.get_InstantiationKind
	|-PropertyBag<StyleLength>.get_InstantiationKind
	|-PropertyBag<StylePropertyName>.get_InstantiationKind
	|-PropertyBag<StyleRotate>.get_InstantiationKind
	|-PropertyBag<StyleScale>.get_InstantiationKind
	|-PropertyBag<StyleTextShadow>.get_InstantiationKind
	|-PropertyBag<StyleTransformOrigin>.get_InstantiationKind
	|-PropertyBag<StyleTranslate>.get_InstantiationKind
	|-PropertyBag<TextShadow>.get_InstantiationKind
	|-PropertyBag<TimeValue>.get_InstantiationKind
	|-PropertyBag<TransformOrigin>.get_InstantiationKind
	|-PropertyBag<Translate>.get_InstantiationKind
	|-PropertyBag<Vector2>.get_InstantiationKind
	|-PropertyBag<Vector2Int>.get_InstantiationKind
	|-PropertyBag<Vector3>.get_InstantiationKind
	|-PropertyBag<Vector3Int>.get_InstantiationKind
	|-PropertyBag<Vector4>.get_InstantiationKind
	|-PropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual TContainer Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA6D740 Offset: 0xA6BD40 VA: 0x180A6D740
	|-PropertyBag<StyleEnum<Int32Enum>>.Instantiate
	|-PropertyBag<Angle>.Instantiate
	|-PropertyBag<BackgroundRepeat>.Instantiate
	|-PropertyBag<EasingFunction>.Instantiate
	|-PropertyBag<Length>.Instantiate
	|-PropertyBag<object>.Instantiate
	|-PropertyBag<StyleFloat>.Instantiate
	|-PropertyBag<StyleInt>.Instantiate
	|-PropertyBag<TimeValue>.Instantiate
	|-PropertyBag<Vector2Int>.Instantiate
	|
	|-RVA: 0x8AFA20 Offset: 0x8AE020 VA: 0x1808AFA20
	|-PropertyBag<StyleList<EasingFunction>>.Instantiate
	|-PropertyBag<StyleList<StylePropertyName>>.Instantiate
	|-PropertyBag<StyleList<TimeValue>>.Instantiate
	|-PropertyBag<Color>.Instantiate
	|-PropertyBag<FontDefinition>.Instantiate
	|-PropertyBag<Rect>.Instantiate
	|-PropertyBag<RectInt>.Instantiate
	|-PropertyBag<Scale>.Instantiate
	|-PropertyBag<StyleBackgroundPosition>.Instantiate
	|-PropertyBag<StyleFont>.Instantiate
	|-PropertyBag<StylePropertyName>.Instantiate
	|-PropertyBag<Vector4>.Instantiate
	|
	|-RVA: 0xA6F2C0 Offset: 0xA6D8C0 VA: 0x180A6F2C0
	|-PropertyBag<Background>.Instantiate
	|-PropertyBag<StyleCursor>.Instantiate
	|-PropertyBag<StyleTextShadow>.Instantiate
	|
	|-RVA: 0x8AF8E0 Offset: 0x8ADEE0 VA: 0x1808AF8E0
	|-PropertyBag<BackgroundPosition>.Instantiate
	|-PropertyBag<StyleBackgroundRepeat>.Instantiate
	|-PropertyBag<StyleLength>.Instantiate
	|-PropertyBag<Vector3>.Instantiate
	|-PropertyBag<Vector3Int>.Instantiate
	|
	|-RVA: 0xA6F330 Offset: 0xA6D930 VA: 0x180A6F330
	|-PropertyBag<BackgroundSize>.Instantiate
	|-PropertyBag<StyleColor>.Instantiate
	|-PropertyBag<StyleScale>.Instantiate
	|-PropertyBag<TransformOrigin>.Instantiate
	|
	|-RVA: 0xA6F2D0 Offset: 0xA6D8D0 VA: 0x180A6F2D0
	|-PropertyBag<Bounds>.Instantiate
	|-PropertyBag<BoundsInt>.Instantiate
	|-PropertyBag<Cursor>.Instantiate
	|-PropertyBag<Rotate>.Instantiate
	|-PropertyBag<StyleBackgroundSize>.Instantiate
	|-PropertyBag<StyleFontDefinition>.Instantiate
	|-PropertyBag<StyleTransformOrigin>.Instantiate
	|-PropertyBag<Translate>.Instantiate
	|
	|-RVA: 0xA6F340 Offset: 0xA6D940 VA: 0x180A6F340
	|-PropertyBag<StyleBackground>.Instantiate
	|
	|-RVA: 0xA6F300 Offset: 0xA6D900 VA: 0x180A6F300
	|-PropertyBag<StyleRotate>.Instantiate
	|-PropertyBag<StyleTranslate>.Instantiate
	|-PropertyBag<TextShadow>.Instantiate
	|
	|-RVA: 0x3A53D0 Offset: 0x3A39D0 VA: 0x1803A53D0
	|-PropertyBag<Vector2>.Instantiate
	|
	|-RVA: 0x8AF900 Offset: 0x8ADF00 VA: 0x1808AF900
	|-PropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B07E0 Offset: 0x8AEDE0 VA: 0x1808B07E0
	|-PropertyBag<StyleEnum<Int32Enum>>..ctor
	|-PropertyBag<StyleList<EasingFunction>>..ctor
	|-PropertyBag<StyleList<StylePropertyName>>..ctor
	|-PropertyBag<StyleList<TimeValue>>..ctor
	|-PropertyBag<Angle>..ctor
	|-PropertyBag<Background>..ctor
	|-PropertyBag<BackgroundPosition>..ctor
	|-PropertyBag<BackgroundRepeat>..ctor
	|-PropertyBag<BackgroundSize>..ctor
	|-PropertyBag<Bounds>..ctor
	|-PropertyBag<BoundsInt>..ctor
	|-PropertyBag<Color>..ctor
	|-PropertyBag<Cursor>..ctor
	|-PropertyBag<EasingFunction>..ctor
	|-PropertyBag<FontDefinition>..ctor
	|-PropertyBag<Length>..ctor
	|-PropertyBag<object>..ctor
	|-PropertyBag<Rect>..ctor
	|-PropertyBag<RectInt>..ctor
	|-PropertyBag<Rotate>..ctor
	|-PropertyBag<Scale>..ctor
	|-PropertyBag<StyleBackground>..ctor
	|-PropertyBag<StyleBackgroundPosition>..ctor
	|-PropertyBag<StyleBackgroundRepeat>..ctor
	|-PropertyBag<StyleBackgroundSize>..ctor
	|-PropertyBag<StyleColor>..ctor
	|-PropertyBag<StyleCursor>..ctor
	|-PropertyBag<StyleFloat>..ctor
	|-PropertyBag<StyleFont>..ctor
	|-PropertyBag<StyleFontDefinition>..ctor
	|-PropertyBag<StyleInt>..ctor
	|-PropertyBag<StyleLength>..ctor
	|-PropertyBag<StylePropertyName>..ctor
	|-PropertyBag<StyleRotate>..ctor
	|-PropertyBag<StyleScale>..ctor
	|-PropertyBag<StyleTextShadow>..ctor
	|-PropertyBag<StyleTransformOrigin>..ctor
	|-PropertyBag<StyleTranslate>..ctor
	|-PropertyBag<TextShadow>..ctor
	|-PropertyBag<TimeValue>..ctor
	|-PropertyBag<TransformOrigin>..ctor
	|-PropertyBag<Translate>..ctor
	|-PropertyBag<Vector2>..ctor
	|-PropertyBag<Vector2Int>..ctor
	|-PropertyBag<Vector3>..ctor
	|-PropertyBag<Vector3Int>..ctor
	|-PropertyBag<Vector4>..ctor
	|-PropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
[IsReadOnly]
public struct PropertyCollection<TContainer> : IEnumerable<IProperty<TContainer>>, IEnumerable // TypeDefIndex: 12972
{
	// Fields
	private readonly PropertyCollection.EnumeratorType<TContainer> m_Type; // 0x0
	private readonly IEnumerable<IProperty<TContainer>> m_Enumerable; // 0x0
	private readonly List<IProperty<TContainer>> m_Properties; // 0x0
	private readonly IndexedCollectionPropertyBagEnumerable<TContainer> m_IndexedCollectionPropertyBag; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly PropertyCollection<TContainer> <Empty>k__BackingField; // 0x0

	// Properties
	public static PropertyCollection<TContainer> Empty { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static PropertyCollection<TContainer> get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B6220 Offset: 0x8B4820 VA: 0x1808B6220
	|-PropertyCollection<StyleEnum<Int32Enum>>.get_Empty
	|-PropertyCollection<Angle>.get_Empty
	|-PropertyCollection<BackgroundRepeat>.get_Empty
	|-PropertyCollection<EasingFunction>.get_Empty
	|-PropertyCollection<int>.get_Empty
	|-PropertyCollection<Int32Enum>.get_Empty
	|-PropertyCollection<Length>.get_Empty
	|-PropertyCollection<object>.get_Empty
	|-PropertyCollection<float>.get_Empty
	|-PropertyCollection<StyleFloat>.get_Empty
	|-PropertyCollection<StyleInt>.get_Empty
	|-PropertyCollection<TimeValue>.get_Empty
	|-PropertyCollection<Vector2>.get_Empty
	|-PropertyCollection<Vector2Int>.get_Empty
	|
	|-RVA: 0x8B60B0 Offset: 0x8B46B0 VA: 0x1808B60B0
	|-PropertyCollection<StyleList<EasingFunction>>.get_Empty
	|-PropertyCollection<StyleList<StylePropertyName>>.get_Empty
	|-PropertyCollection<StyleList<TimeValue>>.get_Empty
	|-PropertyCollection<BackgroundPosition>.get_Empty
	|-PropertyCollection<Color>.get_Empty
	|-PropertyCollection<FontDefinition>.get_Empty
	|-PropertyCollection<Rect>.get_Empty
	|-PropertyCollection<RectInt>.get_Empty
	|-PropertyCollection<Scale>.get_Empty
	|-PropertyCollection<StyleBackgroundPosition>.get_Empty
	|-PropertyCollection<StyleBackgroundRepeat>.get_Empty
	|-PropertyCollection<StyleFont>.get_Empty
	|-PropertyCollection<StyleLength>.get_Empty
	|-PropertyCollection<StylePropertyName>.get_Empty
	|-PropertyCollection<Vector3>.get_Empty
	|-PropertyCollection<Vector3Int>.get_Empty
	|-PropertyCollection<Vector4>.get_Empty
	|
	|-RVA: 0x8B6160 Offset: 0x8B4760 VA: 0x1808B6160
	|-PropertyCollection<Background>.get_Empty
	|-PropertyCollection<StyleCursor>.get_Empty
	|-PropertyCollection<StyleRotate>.get_Empty
	|-PropertyCollection<StyleTextShadow>.get_Empty
	|-PropertyCollection<StyleTranslate>.get_Empty
	|-PropertyCollection<TextShadow>.get_Empty
	|
	|-RVA: 0x8B62D0 Offset: 0x8B48D0 VA: 0x1808B62D0
	|-PropertyCollection<BackgroundSize>.get_Empty
	|-PropertyCollection<Bounds>.get_Empty
	|-PropertyCollection<BoundsInt>.get_Empty
	|-PropertyCollection<Cursor>.get_Empty
	|-PropertyCollection<Rotate>.get_Empty
	|-PropertyCollection<StyleBackgroundSize>.get_Empty
	|-PropertyCollection<StyleColor>.get_Empty
	|-PropertyCollection<StyleFontDefinition>.get_Empty
	|-PropertyCollection<StyleScale>.get_Empty
	|-PropertyCollection<StyleTransformOrigin>.get_Empty
	|-PropertyCollection<TransformOrigin>.get_Empty
	|-PropertyCollection<Translate>.get_Empty
	|
	|-RVA: 0x8B6390 Offset: 0x8B4990 VA: 0x1808B6390
	|-PropertyCollection<StyleBackground>.get_Empty
	|
	|-RVA: 0x8B6450 Offset: 0x8B4A50 VA: 0x1808B6450
	|-PropertyCollection<__Il2CppFullySharedGenericType>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<IProperty<TContainer>> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B5650 Offset: 0x8B3C50 VA: 0x1808B5650
	|-PropertyCollection<StyleEnum<Int32Enum>>..ctor
	|-PropertyCollection<Angle>..ctor
	|-PropertyCollection<BackgroundRepeat>..ctor
	|-PropertyCollection<EasingFunction>..ctor
	|-PropertyCollection<int>..ctor
	|-PropertyCollection<Int32Enum>..ctor
	|-PropertyCollection<Length>..ctor
	|-PropertyCollection<object>..ctor
	|-PropertyCollection<float>..ctor
	|-PropertyCollection<StyleFloat>..ctor
	|-PropertyCollection<StyleInt>..ctor
	|-PropertyCollection<TimeValue>..ctor
	|-PropertyCollection<Vector2>..ctor
	|-PropertyCollection<Vector2Int>..ctor
	|
	|-RVA: 0x8B5690 Offset: 0x8B3C90 VA: 0x1808B5690
	|-PropertyCollection<StyleList<EasingFunction>>..ctor
	|-PropertyCollection<StyleList<StylePropertyName>>..ctor
	|-PropertyCollection<StyleList<TimeValue>>..ctor
	|-PropertyCollection<BackgroundPosition>..ctor
	|-PropertyCollection<Color>..ctor
	|-PropertyCollection<FontDefinition>..ctor
	|-PropertyCollection<Rect>..ctor
	|-PropertyCollection<RectInt>..ctor
	|-PropertyCollection<Scale>..ctor
	|-PropertyCollection<StyleBackgroundPosition>..ctor
	|-PropertyCollection<StyleBackgroundRepeat>..ctor
	|-PropertyCollection<StyleFont>..ctor
	|-PropertyCollection<StyleLength>..ctor
	|-PropertyCollection<StylePropertyName>..ctor
	|-PropertyCollection<Vector3>..ctor
	|-PropertyCollection<Vector3Int>..ctor
	|-PropertyCollection<Vector4>..ctor
	|
	|-RVA: 0x8B5D30 Offset: 0x8B4330 VA: 0x1808B5D30
	|-PropertyCollection<Background>..ctor
	|-PropertyCollection<StyleCursor>..ctor
	|-PropertyCollection<StyleRotate>..ctor
	|-PropertyCollection<StyleTextShadow>..ctor
	|-PropertyCollection<StyleTranslate>..ctor
	|-PropertyCollection<TextShadow>..ctor
	|
	|-RVA: 0x8B5C90 Offset: 0x8B4290 VA: 0x1808B5C90
	|-PropertyCollection<BackgroundSize>..ctor
	|-PropertyCollection<Bounds>..ctor
	|-PropertyCollection<BoundsInt>..ctor
	|-PropertyCollection<Cursor>..ctor
	|-PropertyCollection<Rotate>..ctor
	|-PropertyCollection<StyleBackgroundSize>..ctor
	|-PropertyCollection<StyleColor>..ctor
	|-PropertyCollection<StyleFontDefinition>..ctor
	|-PropertyCollection<StyleScale>..ctor
	|-PropertyCollection<StyleTransformOrigin>..ctor
	|-PropertyCollection<TransformOrigin>..ctor
	|-PropertyCollection<Translate>..ctor
	|
	|-RVA: 0x8B5F90 Offset: 0x8B4590 VA: 0x1808B5F90
	|-PropertyCollection<StyleBackground>..ctor
	|
	|-RVA: 0x8B58C0 Offset: 0x8B3EC0 VA: 0x1808B58C0
	|-PropertyCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(List<IProperty<TContainer>> properties) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B5B30 Offset: 0x8B4130 VA: 0x1808B5B30
	|-PropertyCollection<StyleEnum<Int32Enum>>..ctor
	|-PropertyCollection<Angle>..ctor
	|-PropertyCollection<BackgroundRepeat>..ctor
	|-PropertyCollection<EasingFunction>..ctor
	|-PropertyCollection<int>..ctor
	|-PropertyCollection<Int32Enum>..ctor
	|-PropertyCollection<Length>..ctor
	|-PropertyCollection<object>..ctor
	|-PropertyCollection<float>..ctor
	|-PropertyCollection<StyleFloat>..ctor
	|-PropertyCollection<StyleInt>..ctor
	|-PropertyCollection<TimeValue>..ctor
	|-PropertyCollection<Vector2>..ctor
	|-PropertyCollection<Vector2Int>..ctor
	|
	|-RVA: 0x8B5C30 Offset: 0x8B4230 VA: 0x1808B5C30
	|-PropertyCollection<StyleList<EasingFunction>>..ctor
	|-PropertyCollection<StyleList<StylePropertyName>>..ctor
	|-PropertyCollection<StyleList<TimeValue>>..ctor
	|-PropertyCollection<BackgroundPosition>..ctor
	|-PropertyCollection<Color>..ctor
	|-PropertyCollection<FontDefinition>..ctor
	|-PropertyCollection<Rect>..ctor
	|-PropertyCollection<RectInt>..ctor
	|-PropertyCollection<Scale>..ctor
	|-PropertyCollection<StyleBackgroundPosition>..ctor
	|-PropertyCollection<StyleBackgroundRepeat>..ctor
	|-PropertyCollection<StyleFont>..ctor
	|-PropertyCollection<StyleLength>..ctor
	|-PropertyCollection<StylePropertyName>..ctor
	|-PropertyCollection<Vector3>..ctor
	|-PropertyCollection<Vector3Int>..ctor
	|-PropertyCollection<Vector4>..ctor
	|
	|-RVA: 0x8B5CD0 Offset: 0x8B42D0 VA: 0x1808B5CD0
	|-PropertyCollection<Background>..ctor
	|-PropertyCollection<StyleCursor>..ctor
	|-PropertyCollection<StyleRotate>..ctor
	|-PropertyCollection<StyleTextShadow>..ctor
	|-PropertyCollection<StyleTranslate>..ctor
	|-PropertyCollection<TextShadow>..ctor
	|
	|-RVA: 0x8B5BE0 Offset: 0x8B41E0 VA: 0x1808B5BE0
	|-PropertyCollection<BackgroundSize>..ctor
	|-PropertyCollection<Bounds>..ctor
	|-PropertyCollection<BoundsInt>..ctor
	|-PropertyCollection<Cursor>..ctor
	|-PropertyCollection<Rotate>..ctor
	|-PropertyCollection<StyleBackgroundSize>..ctor
	|-PropertyCollection<StyleColor>..ctor
	|-PropertyCollection<StyleFontDefinition>..ctor
	|-PropertyCollection<StyleScale>..ctor
	|-PropertyCollection<StyleTransformOrigin>..ctor
	|-PropertyCollection<TransformOrigin>..ctor
	|-PropertyCollection<Translate>..ctor
	|
	|-RVA: 0x8B6050 Offset: 0x8B4650 VA: 0x1808B6050
	|-PropertyCollection<StyleBackground>..ctor
	|
	|-RVA: 0x8B5DF0 Offset: 0x8B43F0 VA: 0x1808B5DF0
	|-PropertyCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IndexedCollectionPropertyBagEnumerable<TContainer> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B5B80 Offset: 0x8B4180 VA: 0x1808B5B80
	|-PropertyCollection<StyleEnum<Int32Enum>>..ctor
	|-PropertyCollection<Angle>..ctor
	|-PropertyCollection<BackgroundRepeat>..ctor
	|-PropertyCollection<EasingFunction>..ctor
	|-PropertyCollection<int>..ctor
	|-PropertyCollection<Int32Enum>..ctor
	|-PropertyCollection<Length>..ctor
	|-PropertyCollection<object>..ctor
	|-PropertyCollection<float>..ctor
	|-PropertyCollection<StyleFloat>..ctor
	|-PropertyCollection<StyleInt>..ctor
	|-PropertyCollection<TimeValue>..ctor
	|-PropertyCollection<Vector2>..ctor
	|-PropertyCollection<Vector2Int>..ctor
	|
	|-RVA: 0x8B5A60 Offset: 0x8B4060 VA: 0x1808B5A60
	|-PropertyCollection<StyleList<EasingFunction>>..ctor
	|-PropertyCollection<StyleList<StylePropertyName>>..ctor
	|-PropertyCollection<StyleList<TimeValue>>..ctor
	|-PropertyCollection<BackgroundPosition>..ctor
	|-PropertyCollection<Color>..ctor
	|-PropertyCollection<FontDefinition>..ctor
	|-PropertyCollection<Rect>..ctor
	|-PropertyCollection<RectInt>..ctor
	|-PropertyCollection<Scale>..ctor
	|-PropertyCollection<StyleBackgroundPosition>..ctor
	|-PropertyCollection<StyleBackgroundRepeat>..ctor
	|-PropertyCollection<StyleFont>..ctor
	|-PropertyCollection<StyleLength>..ctor
	|-PropertyCollection<StylePropertyName>..ctor
	|-PropertyCollection<Vector3>..ctor
	|-PropertyCollection<Vector3Int>..ctor
	|-PropertyCollection<Vector4>..ctor
	|
	|-RVA: 0x8B5D80 Offset: 0x8B4380 VA: 0x1808B5D80
	|-PropertyCollection<Background>..ctor
	|-PropertyCollection<StyleCursor>..ctor
	|-PropertyCollection<StyleRotate>..ctor
	|-PropertyCollection<StyleTextShadow>..ctor
	|-PropertyCollection<StyleTranslate>..ctor
	|-PropertyCollection<TextShadow>..ctor
	|
	|-RVA: 0x8B5AD0 Offset: 0x8B40D0 VA: 0x1808B5AD0
	|-PropertyCollection<BackgroundSize>..ctor
	|-PropertyCollection<Bounds>..ctor
	|-PropertyCollection<BoundsInt>..ctor
	|-PropertyCollection<Cursor>..ctor
	|-PropertyCollection<Rotate>..ctor
	|-PropertyCollection<StyleBackgroundSize>..ctor
	|-PropertyCollection<StyleColor>..ctor
	|-PropertyCollection<StyleFontDefinition>..ctor
	|-PropertyCollection<StyleScale>..ctor
	|-PropertyCollection<StyleTransformOrigin>..ctor
	|-PropertyCollection<TransformOrigin>..ctor
	|-PropertyCollection<Translate>..ctor
	|
	|-RVA: 0x8B5FE0 Offset: 0x8B45E0 VA: 0x1808B5FE0
	|-PropertyCollection<StyleBackground>..ctor
	|
	|-RVA: 0x8B56E0 Offset: 0x8B3CE0 VA: 0x1808B56E0
	|-PropertyCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public PropertyCollection.Enumerator<TContainer> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B18D0 Offset: 0x8AFED0 VA: 0x1808B18D0
	|-PropertyCollection<StyleEnum<Int32Enum>>.GetEnumerator
	|-PropertyCollection<Angle>.GetEnumerator
	|-PropertyCollection<BackgroundRepeat>.GetEnumerator
	|-PropertyCollection<Length>.GetEnumerator
	|-PropertyCollection<StyleFloat>.GetEnumerator
	|-PropertyCollection<StyleInt>.GetEnumerator
	|-PropertyCollection<TimeValue>.GetEnumerator
	|-PropertyCollection<Vector2Int>.GetEnumerator
	|
	|-RVA: 0x8B07F0 Offset: 0x8AEDF0 VA: 0x1808B07F0
	|-PropertyCollection<StyleList<EasingFunction>>.GetEnumerator
	|-PropertyCollection<StyleList<StylePropertyName>>.GetEnumerator
	|-PropertyCollection<StyleList<TimeValue>>.GetEnumerator
	|-PropertyCollection<StylePropertyName>.GetEnumerator
	|
	|-RVA: 0x8B20E0 Offset: 0x8B06E0 VA: 0x1808B20E0
	|-PropertyCollection<Background>.GetEnumerator
	|-PropertyCollection<StyleCursor>.GetEnumerator
	|
	|-RVA: 0x8B0DB0 Offset: 0x8AF3B0 VA: 0x1808B0DB0
	|-PropertyCollection<BackgroundPosition>.GetEnumerator
	|-PropertyCollection<StyleBackgroundRepeat>.GetEnumerator
	|-PropertyCollection<StyleLength>.GetEnumerator
	|-PropertyCollection<Vector3>.GetEnumerator
	|-PropertyCollection<Vector3Int>.GetEnumerator
	|
	|-RVA: 0x8B0AD0 Offset: 0x8AF0D0 VA: 0x1808B0AD0
	|-PropertyCollection<BackgroundSize>.GetEnumerator
	|-PropertyCollection<StyleColor>.GetEnumerator
	|-PropertyCollection<StyleScale>.GetEnumerator
	|-PropertyCollection<TransformOrigin>.GetEnumerator
	|
	|-RVA: 0x8B1600 Offset: 0x8AFC00 VA: 0x1808B1600
	|-PropertyCollection<Bounds>.GetEnumerator
	|-PropertyCollection<BoundsInt>.GetEnumerator
	|-PropertyCollection<Rotate>.GetEnumerator
	|-PropertyCollection<StyleBackgroundSize>.GetEnumerator
	|-PropertyCollection<StyleTransformOrigin>.GetEnumerator
	|-PropertyCollection<Translate>.GetEnumerator
	|
	|-RVA: 0x8B1320 Offset: 0x8AF920 VA: 0x1808B1320
	|-PropertyCollection<Color>.GetEnumerator
	|-PropertyCollection<Rect>.GetEnumerator
	|-PropertyCollection<RectInt>.GetEnumerator
	|-PropertyCollection<Scale>.GetEnumerator
	|-PropertyCollection<StyleBackgroundPosition>.GetEnumerator
	|-PropertyCollection<Vector4>.GetEnumerator
	|
	|-RVA: 0x8B29A0 Offset: 0x8B0FA0 VA: 0x1808B29A0
	|-PropertyCollection<Cursor>.GetEnumerator
	|
	|-RVA: 0x8B39D0 Offset: 0x8B1FD0 VA: 0x1808B39D0
	|-PropertyCollection<EasingFunction>.GetEnumerator
	|
	|-RVA: 0x8B2C70 Offset: 0x8B1270 VA: 0x1808B2C70
	|-PropertyCollection<FontDefinition>.GetEnumerator
	|-PropertyCollection<StyleFont>.GetEnumerator
	|
	|-RVA: 0x8B23F0 Offset: 0x8B09F0 VA: 0x1808B23F0
	|-PropertyCollection<int>.GetEnumerator
	|-PropertyCollection<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x8B1B70 Offset: 0x8B0170 VA: 0x1808B1B70
	|-PropertyCollection<object>.GetEnumerator
	|
	|-RVA: 0x8B2F50 Offset: 0x8B1550 VA: 0x1808B2F50
	|-PropertyCollection<float>.GetEnumerator
	|
	|-RVA: 0x8B26A0 Offset: 0x8B0CA0 VA: 0x1808B26A0
	|-PropertyCollection<StyleBackground>.GetEnumerator
	|
	|-RVA: 0x8B1050 Offset: 0x8AF650 VA: 0x1808B1050
	|-PropertyCollection<StyleFontDefinition>.GetEnumerator
	|
	|-RVA: 0x8B1E10 Offset: 0x8B0410 VA: 0x1808B1E10
	|-PropertyCollection<StyleRotate>.GetEnumerator
	|-PropertyCollection<StyleTranslate>.GetEnumerator
	|-PropertyCollection<TextShadow>.GetEnumerator
	|
	|-RVA: 0x8B3200 Offset: 0x8B1800 VA: 0x1808B3200
	|-PropertyCollection<StyleTextShadow>.GetEnumerator
	|
	|-RVA: 0x8B3C80 Offset: 0x8B2280 VA: 0x1808B3C80
	|-PropertyCollection<Vector2>.GetEnumerator
	|
	|-RVA: 0x8B3510 Offset: 0x8B1B10 VA: 0x1808B3510
	|-PropertyCollection<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<IProperty<TContainer>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B4170 Offset: 0x8B2770 VA: 0x1808B4170
	|-PropertyCollection<StyleEnum<Int32Enum>>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Angle>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<BackgroundRepeat>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Length>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleFloat>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleInt>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<TimeValue>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Vector2Int>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B47E0 Offset: 0x8B2DE0 VA: 0x1808B47E0
	|-PropertyCollection<StyleList<EasingFunction>>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleList<StylePropertyName>>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleList<TimeValue>>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StylePropertyName>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4040 Offset: 0x8B2640 VA: 0x1808B4040
	|-PropertyCollection<Background>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleCursor>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4270 Offset: 0x8B2870 VA: 0x1808B4270
	|-PropertyCollection<BackgroundPosition>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleBackgroundRepeat>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleLength>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Vector3>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Vector3Int>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4900 Offset: 0x8B2F00 VA: 0x1808B4900
	|-PropertyCollection<BackgroundSize>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleColor>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleScale>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<TransformOrigin>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B3F20 Offset: 0x8B2520 VA: 0x1808B3F20
	|-PropertyCollection<Bounds>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<BoundsInt>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Rotate>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleBackgroundSize>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleTransformOrigin>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Translate>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B46C0 Offset: 0x8B2CC0 VA: 0x1808B46C0
	|-PropertyCollection<Color>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Rect>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<RectInt>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Scale>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleBackgroundPosition>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Vector4>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B45A0 Offset: 0x8B2BA0 VA: 0x1808B45A0
	|-PropertyCollection<Cursor>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B50D0 Offset: 0x8B36D0 VA: 0x1808B50D0
	|-PropertyCollection<EasingFunction>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4A20 Offset: 0x8B3020 VA: 0x1808B4A20
	|-PropertyCollection<FontDefinition>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleFont>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4370 Offset: 0x8B2970 VA: 0x1808B4370
	|-PropertyCollection<int>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<Int32Enum>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4ED0 Offset: 0x8B34D0 VA: 0x1808B4ED0
	|-PropertyCollection<object>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4FD0 Offset: 0x8B35D0 VA: 0x1808B4FD0
	|-PropertyCollection<float>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B51D0 Offset: 0x8B37D0 VA: 0x1808B51D0
	|-PropertyCollection<StyleBackground>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4B40 Offset: 0x8B3140 VA: 0x1808B4B40
	|-PropertyCollection<StyleFontDefinition>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4DB0 Offset: 0x8B33B0 VA: 0x1808B4DB0
	|-PropertyCollection<StyleRotate>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<StyleTranslate>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|-PropertyCollection<TextShadow>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4470 Offset: 0x8B2A70 VA: 0x1808B4470
	|-PropertyCollection<StyleTextShadow>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B5300 Offset: 0x8B3900 VA: 0x1808B5300
	|-PropertyCollection<Vector2>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	|
	|-RVA: 0x8B4C60 Offset: 0x8B3260 VA: 0x1808B4C60
	|-PropertyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B4170 Offset: 0x8B2770 VA: 0x1808B4170
	|-PropertyCollection<StyleEnum<Int32Enum>>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Angle>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<BackgroundRepeat>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Length>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleFloat>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleInt>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<TimeValue>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Vector2Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B47E0 Offset: 0x8B2DE0 VA: 0x1808B47E0
	|-PropertyCollection<StyleList<EasingFunction>>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleList<StylePropertyName>>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleList<TimeValue>>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StylePropertyName>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4040 Offset: 0x8B2640 VA: 0x1808B4040
	|-PropertyCollection<Background>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleCursor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4270 Offset: 0x8B2870 VA: 0x1808B4270
	|-PropertyCollection<BackgroundPosition>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleBackgroundRepeat>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleLength>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Vector3Int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4900 Offset: 0x8B2F00 VA: 0x1808B4900
	|-PropertyCollection<BackgroundSize>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleColor>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleScale>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<TransformOrigin>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B3F20 Offset: 0x8B2520 VA: 0x1808B3F20
	|-PropertyCollection<Bounds>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<BoundsInt>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Rotate>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleBackgroundSize>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleTransformOrigin>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Translate>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B46C0 Offset: 0x8B2CC0 VA: 0x1808B46C0
	|-PropertyCollection<Color>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Rect>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<RectInt>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Scale>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleBackgroundPosition>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Vector4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B45A0 Offset: 0x8B2BA0 VA: 0x1808B45A0
	|-PropertyCollection<Cursor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B50D0 Offset: 0x8B36D0 VA: 0x1808B50D0
	|-PropertyCollection<EasingFunction>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4A20 Offset: 0x8B3020 VA: 0x1808B4A20
	|-PropertyCollection<FontDefinition>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleFont>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4370 Offset: 0x8B2970 VA: 0x1808B4370
	|-PropertyCollection<int>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4ED0 Offset: 0x8B34D0 VA: 0x1808B4ED0
	|-PropertyCollection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4FD0 Offset: 0x8B35D0 VA: 0x1808B4FD0
	|-PropertyCollection<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B51D0 Offset: 0x8B37D0 VA: 0x1808B51D0
	|-PropertyCollection<StyleBackground>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4B40 Offset: 0x8B3140 VA: 0x1808B4B40
	|-PropertyCollection<StyleFontDefinition>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4DB0 Offset: 0x8B33B0 VA: 0x1808B4DB0
	|-PropertyCollection<StyleRotate>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<StyleTranslate>.System.Collections.IEnumerable.GetEnumerator
	|-PropertyCollection<TextShadow>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4470 Offset: 0x8B2A70 VA: 0x1808B4470
	|-PropertyCollection<StyleTextShadow>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B5300 Offset: 0x8B3900 VA: 0x1808B5300
	|-PropertyCollection<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x8B4C60 Offset: 0x8B3260 VA: 0x1808B4C60
	|-PropertyCollection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B5510 Offset: 0x8B3B10 VA: 0x1808B5510
	|-PropertyCollection<StyleEnum<Int32Enum>>..cctor
	|-PropertyCollection<Angle>..cctor
	|-PropertyCollection<BackgroundRepeat>..cctor
	|-PropertyCollection<EasingFunction>..cctor
	|-PropertyCollection<int>..cctor
	|-PropertyCollection<Int32Enum>..cctor
	|-PropertyCollection<Length>..cctor
	|-PropertyCollection<object>..cctor
	|-PropertyCollection<float>..cctor
	|-PropertyCollection<StyleFloat>..cctor
	|-PropertyCollection<StyleInt>..cctor
	|-PropertyCollection<TimeValue>..cctor
	|-PropertyCollection<Vector2>..cctor
	|-PropertyCollection<Vector2Int>..cctor
	|
	|-RVA: 0x8B54C0 Offset: 0x8B3AC0 VA: 0x1808B54C0
	|-PropertyCollection<StyleList<EasingFunction>>..cctor
	|-PropertyCollection<StyleList<StylePropertyName>>..cctor
	|-PropertyCollection<StyleList<TimeValue>>..cctor
	|-PropertyCollection<BackgroundPosition>..cctor
	|-PropertyCollection<Color>..cctor
	|-PropertyCollection<FontDefinition>..cctor
	|-PropertyCollection<Rect>..cctor
	|-PropertyCollection<RectInt>..cctor
	|-PropertyCollection<Scale>..cctor
	|-PropertyCollection<StyleBackgroundPosition>..cctor
	|-PropertyCollection<StyleBackgroundRepeat>..cctor
	|-PropertyCollection<StyleFont>..cctor
	|-PropertyCollection<StyleLength>..cctor
	|-PropertyCollection<StylePropertyName>..cctor
	|-PropertyCollection<Vector3>..cctor
	|-PropertyCollection<Vector3Int>..cctor
	|-PropertyCollection<Vector4>..cctor
	|
	|-RVA: 0x8B5460 Offset: 0x8B3A60 VA: 0x1808B5460
	|-PropertyCollection<Background>..cctor
	|-PropertyCollection<StyleCursor>..cctor
	|-PropertyCollection<StyleRotate>..cctor
	|-PropertyCollection<StyleTextShadow>..cctor
	|-PropertyCollection<StyleTranslate>..cctor
	|-PropertyCollection<TextShadow>..cctor
	|
	|-RVA: 0x8B5400 Offset: 0x8B3A00 VA: 0x1808B5400
	|-PropertyCollection<BackgroundSize>..cctor
	|-PropertyCollection<Bounds>..cctor
	|-PropertyCollection<BoundsInt>..cctor
	|-PropertyCollection<Cursor>..cctor
	|-PropertyCollection<Rotate>..cctor
	|-PropertyCollection<StyleBackgroundSize>..cctor
	|-PropertyCollection<StyleColor>..cctor
	|-PropertyCollection<StyleFontDefinition>..cctor
	|-PropertyCollection<StyleScale>..cctor
	|-PropertyCollection<StyleTransformOrigin>..cctor
	|-PropertyCollection<TransformOrigin>..cctor
	|-PropertyCollection<Translate>..cctor
	|
	|-RVA: 0x8B5570 Offset: 0x8B3B70 VA: 0x1808B5570
	|-PropertyCollection<StyleBackground>..cctor
	|
	|-RVA: 0x8B55D0 Offset: 0x8B3BD0 VA: 0x1808B55D0
	|-PropertyCollection<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Properties
public class SetPropertyBagBase<TSet, TElement> : PropertyBag<TSet>, ISetPropertyBag<TSet, TElement>, ICollectionPropertyBag<TSet, TElement>, IPropertyBag<TSet>, IPropertyBag, ICollectionPropertyBagAccept<TSet>, ISetPropertyBagAccept<TSet>, IKeyedProperties<TSet, object> // TypeDefIndex: 12975
{
	// Fields
	private readonly SetPropertyBagBase.SetElementProperty<TSet, TElement> m_Property; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	public override PropertyCollection<TSet> GetProperties() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96A310 Offset: 0x968910 VA: 0x18096A310
	|-SetPropertyBagBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetProperties
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override PropertyCollection<TSet> GetProperties(ref TSet container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96A180 Offset: 0x968780 VA: 0x18096A180
	|-SetPropertyBagBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetProperties
	*/

	[IteratorStateMachine(typeof(SetPropertyBagBase.<GetPropertiesEnumerable>d__4<TSet, TElement>))]
	// RVA: -1 Offset: -1
	private IEnumerable<IProperty<TSet>> GetPropertiesEnumerable(TSet container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96A000 Offset: 0x968600 VA: 0x18096A000
	|-SetPropertyBagBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetPropertiesEnumerable
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void Unity.Properties.ICollectionPropertyBagAccept<TSet>.Accept(ICollectionPropertyBagVisitor visitor, ref TSet container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96A680 Offset: 0x968C80 VA: 0x18096A680
	|-SetPropertyBagBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.ICollectionPropertyBagAccept<TSet>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void Unity.Properties.ISetPropertyBagAccept<TSet>.Accept(ISetPropertyBagVisitor visitor, ref TSet container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96A6B0 Offset: 0x968CB0 VA: 0x18096A6B0
	|-SetPropertyBagBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.ISetPropertyBagAccept<TSet>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool TryGetProperty(ref TSet container, object key, out IProperty<TSet> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96A440 Offset: 0x968A40 VA: 0x18096A440
	|-SetPropertyBagBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetProperty
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96A6E0 Offset: 0x968CE0 VA: 0x18096A6E0
	|-SetPropertyBagBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public abstract class ConcreteTypeVisitor : IPropertyBagVisitor // TypeDefIndex: 12976
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void VisitContainer<TContainer>(ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ConcreteTypeVisitor.VisitContainer<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void Unity.Properties.IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BB740 Offset: 0x6B9D40 VA: 0x1806BB740
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleEnum<Int32Enum>>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<EasingFunction>>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<StylePropertyName>>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<TimeValue>>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Angle>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Background>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundPosition>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundRepeat>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundSize>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Bounds>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BoundsInt>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Color>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Cursor>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<EasingFunction>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<FontDefinition>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Length>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<object>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Rect>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<RectInt>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Rotate>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Scale>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackground>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundPosition>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundRepeat>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundSize>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleColor>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleCursor>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFloat>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFont>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFontDefinition>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleInt>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleLength>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StylePropertyName>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleRotate>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleScale>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTextShadow>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTransformOrigin>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTranslate>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TextShadow>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TimeValue>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TransformOrigin>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Translate>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector2>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector2Int>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector3>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector3Int>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector4>
	|-ConcreteTypeVisitor.Unity.Properties.IPropertyBagVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Unity.Properties
public interface ICollectionPropertyBagAccept<TContainer> // TypeDefIndex: 12977
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Accept(ICollectionPropertyBagVisitor visitor, ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollectionPropertyBagAccept<__Il2CppFullySharedGenericType>.Accept
	*/
}

// Namespace: Unity.Properties
public interface IListPropertyBagAccept<TContainer> // TypeDefIndex: 12978
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Accept(IListPropertyBagVisitor visitor, ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IListPropertyBagAccept<__Il2CppFullySharedGenericType>.Accept
	*/
}

// Namespace: Unity.Properties
public interface ISetPropertyBagAccept<TContainer> // TypeDefIndex: 12979
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Accept(ISetPropertyBagVisitor visitor, ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISetPropertyBagAccept<__Il2CppFullySharedGenericType>.Accept
	*/
}

// Namespace: Unity.Properties
public interface IDictionaryPropertyBagAccept<TContainer> // TypeDefIndex: 12980
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Accept(IDictionaryPropertyBagVisitor visitor, ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionaryPropertyBagAccept<__Il2CppFullySharedGenericType>.Accept
	*/
}

// Namespace: Unity.Properties
public interface IPropertyAccept<TContainer> // TypeDefIndex: 12981
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Accept(IPropertyVisitor visitor, ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPropertyAccept<__Il2CppFullySharedGenericType>.Accept
	*/
}

// Namespace: Unity.Properties
public interface IListPropertyAccept<TList> // TypeDefIndex: 12982
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Accept<TContainer>(IListPropertyVisitor visitor, Property<TContainer, TList> property, ref TContainer container, ref TList list);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IListPropertyAccept<__Il2CppFullySharedGenericType>.Accept<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public interface ITypeVisitor // TypeDefIndex: 12983
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TContainer>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeVisitor.Visit<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public interface IPropertyBagVisitor // TypeDefIndex: 12984
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPropertyBagVisitor.Visit<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public interface ICollectionPropertyBagVisitor // TypeDefIndex: 12985
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TCollection, TElement>(ICollectionPropertyBag<TCollection, TElement> properties, ref TCollection container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollectionPropertyBagVisitor.Visit<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public interface IListPropertyBagVisitor // TypeDefIndex: 12986
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TList, TElement>(IListPropertyBag<TList, TElement> properties, ref TList container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IListPropertyBagVisitor.Visit<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public interface ISetPropertyBagVisitor // TypeDefIndex: 12987
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TSet, TValue>(ISetPropertyBag<TSet, TValue> properties, ref TSet container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISetPropertyBagVisitor.Visit<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public interface IDictionaryPropertyBagVisitor // TypeDefIndex: 12988
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TDictionary, TKey, TValue>(IDictionaryPropertyBag<TDictionary, TKey, TValue> properties, ref TDictionary container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionaryPropertyBagVisitor.Visit<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public interface IPropertyVisitor // TypeDefIndex: 12989
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IPropertyVisitor.Visit<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public interface IListPropertyVisitor // TypeDefIndex: 12990
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TContainer, TList, TElement>(Property<TContainer, TList> property, ref TContainer container, ref TList list);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IListPropertyVisitor.Visit<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public abstract class PathVisitor : IPropertyBagVisitor, IPropertyVisitor // TypeDefIndex: 12992
{
	// Fields
	private int m_PathIndex; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private PropertyPath <Path>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private IProperty <Property>k__BackingField; // 0xA8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ReadonlyVisit>k__BackingField; // 0xB0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisitReturnCode <ReturnCode>k__BackingField; // 0xB4

	// Properties
	public PropertyPath Path { get; set; }
	private IProperty Property { get; set; }
	public bool ReadonlyVisit { get; set; }
	public VisitReturnCode ReturnCode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23BC930 Offset: 0x23BAF30 VA: 0x1823BC930
	public PropertyPath get_Path() { }

	[CompilerGenerated]
	// RVA: 0x23BC990 Offset: 0x23BAF90 VA: 0x1823BC990
	public void set_Path(PropertyPath value) { }

	// RVA: 0x23BC8D0 Offset: 0x23BAED0 VA: 0x1823BC8D0 Slot: 6
	public virtual void Reset() { }

	[CompilerGenerated]
	// RVA: 0x16237C0 Offset: 0x1621DC0 VA: 0x1816237C0
	private IProperty get_Property() { }

	[CompilerGenerated]
	// RVA: 0x163E0C0 Offset: 0x163C6C0 VA: 0x18163E0C0
	private void set_Property(IProperty value) { }

	[CompilerGenerated]
	// RVA: 0x1641010 Offset: 0x163F610 VA: 0x181641010
	public bool get_ReadonlyVisit() { }

	[CompilerGenerated]
	// RVA: 0x16410A0 Offset: 0x163F6A0 VA: 0x1816410A0
	public void set_ReadonlyVisit(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3A35B0 Offset: 0x3A1BB0 VA: 0x1803A35B0
	public VisitReturnCode get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x204F0C0 Offset: 0x204D6C0 VA: 0x18204F0C0
	protected void set_ReturnCode(VisitReturnCode value) { }

	// RVA: -1 Offset: -1 Slot: 4
	private void Unity.Properties.IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x73ACB0 Offset: 0x7392B0 VA: 0x18073ACB0
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleEnum<Int32Enum>>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<EasingFunction>>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<StylePropertyName>>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleList<TimeValue>>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Angle>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Background>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundPosition>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundRepeat>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BackgroundSize>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Bounds>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<BoundsInt>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Color>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Cursor>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<EasingFunction>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<FontDefinition>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Length>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<object>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Rect>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<RectInt>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Rotate>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Scale>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackground>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundPosition>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundRepeat>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleBackgroundSize>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleColor>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleCursor>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFloat>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFont>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleFontDefinition>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleInt>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleLength>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StylePropertyName>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleRotate>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleScale>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTextShadow>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTransformOrigin>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<StyleTranslate>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TextShadow>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TimeValue>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<TransformOrigin>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Translate>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector2>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector2Int>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector3>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector3Int>
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<Vector4>
	|
	|-RVA: 0x73B300 Offset: 0x739900 VA: 0x18073B300
	|-PathVisitor.Unity.Properties.IPropertyBagVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.IPropertyVisitor.Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x73B970 Offset: 0x739F70 VA: 0x18073B970
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleEnum<Int32Enum>, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<EasingFunction>, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<StylePropertyName>, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<TimeValue>, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Angle, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundPosition, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundRepeat, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundSize, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<EasingFunction, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Length, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackground, Int32Enum>
	|
	|-RVA: 0x73C090 Offset: 0x73A690 VA: 0x18073C090
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<EasingFunction>, object>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<StylePropertyName>, object>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleList<TimeValue>, object>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Background, object>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Cursor, object>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<FontDefinition, object>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, object>
	|
	|-RVA: 0x73BBD0 Offset: 0x73A1D0 VA: 0x18073BBD0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Angle, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Color, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Length, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Rect, float>
	|
	|-RVA: 0x73BE30 Offset: 0x73A430 VA: 0x18073BE30
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundPosition, Length>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<BackgroundSize, Length>
	|
	|-RVA: 0x73C720 Offset: 0x73AD20 VA: 0x18073C720
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Bounds, Vector3>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Vector3>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Rotate, Vector3>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Scale, Vector3>
	|
	|-RVA: 0x73C2F0 Offset: 0x73A8F0 VA: 0x18073C2F0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<BoundsInt, Vector3Int>
	|
	|-RVA: 0x73C9D0 Offset: 0x73AFD0 VA: 0x18073C9D0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Cursor, int>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, int>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<RectInt, int>
	|
	|-RVA: 0x73CC30 Offset: 0x73B230 VA: 0x18073CC30
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Cursor, Vector2>
	|
	|-RVA: 0x741060 Offset: 0x73F660 VA: 0x180741060
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleEnum<Int32Enum>>
	|
	|-RVA: 0x742C70 Offset: 0x741270 VA: 0x180742C70
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleList<EasingFunction>>
	|
	|-RVA: 0x743070 Offset: 0x741670 VA: 0x180743070
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleList<StylePropertyName>>
	|
	|-RVA: 0x742870 Offset: 0x740E70 VA: 0x180742870
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleList<TimeValue>>
	|
	|-RVA: 0x73E030 Offset: 0x73C630 VA: 0x18073E030
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Background>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackground, Background>
	|
	|-RVA: 0x73D3F0 Offset: 0x73B9F0 VA: 0x18073D3F0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, BackgroundPosition>
	|
	|-RVA: 0x73D820 Offset: 0x73BE20 VA: 0x18073D820
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, BackgroundRepeat>
	|
	|-RVA: 0x73DC00 Offset: 0x73C200 VA: 0x18073DC00
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, BackgroundSize>
	|
	|-RVA: 0x73E2F0 Offset: 0x73C8F0 VA: 0x18073E2F0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Color>
	|
	|-RVA: 0x73E6F0 Offset: 0x73CCF0 VA: 0x18073E6F0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, EasingFunction>
	|
	|-RVA: 0x73EAD0 Offset: 0x73D0D0 VA: 0x18073EAD0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, FontDefinition>
	|
	|-RVA: 0x73EED0 Offset: 0x73D4D0 VA: 0x18073EED0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Rotate>
	|
	|-RVA: 0x73F310 Offset: 0x73D910 VA: 0x18073F310
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, Scale>
	|
	|-RVA: 0x740380 Offset: 0x73E980 VA: 0x180740380
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackground>
	|
	|-RVA: 0x73F710 Offset: 0x73DD10 VA: 0x18073F710
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackgroundPosition>
	|
	|-RVA: 0x73FB10 Offset: 0x73E110 VA: 0x18073FB10
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackgroundRepeat>
	|
	|-RVA: 0x73FF40 Offset: 0x73E540 VA: 0x18073FF40
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleBackgroundSize>
	|
	|-RVA: 0x740800 Offset: 0x73EE00 VA: 0x180740800
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleColor>
	|
	|-RVA: 0x740C30 Offset: 0x73F230 VA: 0x180740C30
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleCursor>
	|
	|-RVA: 0x741440 Offset: 0x73FA40 VA: 0x180741440
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleFloat>
	|
	|-RVA: 0x741C60 Offset: 0x740260 VA: 0x180741C60
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleFont>
	|
	|-RVA: 0x741820 Offset: 0x73FE20 VA: 0x180741820
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleFontDefinition>
	|
	|-RVA: 0x742060 Offset: 0x740660 VA: 0x180742060
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleInt>
	|
	|-RVA: 0x742440 Offset: 0x740A40 VA: 0x180742440
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleLength>
	|
	|-RVA: 0x743470 Offset: 0x741A70 VA: 0x180743470
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StylePropertyName>
	|
	|-RVA: 0x743870 Offset: 0x741E70 VA: 0x180743870
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleRotate>
	|
	|-RVA: 0x743CE0 Offset: 0x7422E0 VA: 0x180743CE0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleScale>
	|
	|-RVA: 0x744110 Offset: 0x742710 VA: 0x180744110
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleTextShadow>
	|
	|-RVA: 0x744540 Offset: 0x742B40 VA: 0x180744540
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleTransformOrigin>
	|
	|-RVA: 0x744980 Offset: 0x742F80 VA: 0x180744980
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, StyleTranslate>
	|
	|-RVA: 0x744DF0 Offset: 0x7433F0 VA: 0x180744DF0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<object, TimeValue>
	|
	|-RVA: 0x73D010 Offset: 0x73B610 VA: 0x18073D010
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Rotate, Angle>
	|
	|-RVA: 0x7455B0 Offset: 0x743BB0 VA: 0x1807455B0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundPosition, BackgroundPosition>
	|
	|-RVA: 0x745A20 Offset: 0x744020 VA: 0x180745A20
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundPosition, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundRepeat, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundSize, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleColor, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleCursor, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFloat, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFont, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFontDefinition, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleInt, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleLength, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StylePropertyName, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleRotate, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleScale, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTextShadow, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTransformOrigin, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTranslate, Int32Enum>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<TimeValue, Int32Enum>
	|
	|-RVA: 0x745CC0 Offset: 0x7442C0 VA: 0x180745CC0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundRepeat, BackgroundRepeat>
	|
	|-RVA: 0x7460E0 Offset: 0x7446E0 VA: 0x1807460E0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleBackgroundSize, BackgroundSize>
	|
	|-RVA: 0x746550 Offset: 0x744B50 VA: 0x180746550
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleColor, Color>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<TextShadow, Color>
	|
	|-RVA: 0x746820 Offset: 0x744E20 VA: 0x180746820
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleCursor, Cursor>
	|
	|-RVA: 0x746CA0 Offset: 0x7452A0 VA: 0x180746CA0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFloat, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<TextShadow, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<TimeValue, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<TransformOrigin, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Translate, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector2, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector3, float>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector4, float>
	|
	|-RVA: 0x747390 Offset: 0x745990 VA: 0x180747390
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFont, object>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StylePropertyName, object>
	|
	|-RVA: 0x746F50 Offset: 0x745550 VA: 0x180746F50
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleFontDefinition, FontDefinition>
	|
	|-RVA: 0x747640 Offset: 0x745C40 VA: 0x180747640
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleInt, int>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector2Int, int>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Vector3Int, int>
	|
	|-RVA: 0x7478E0 Offset: 0x745EE0 VA: 0x1807478E0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleLength, Length>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<TransformOrigin, Length>
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<Translate, Length>
	|
	|-RVA: 0x747B90 Offset: 0x746190 VA: 0x180747B90
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleRotate, Rotate>
	|
	|-RVA: 0x748010 Offset: 0x746610 VA: 0x180748010
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleScale, Scale>
	|
	|-RVA: 0x748450 Offset: 0x746A50 VA: 0x180748450
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTextShadow, TextShadow>
	|
	|-RVA: 0x748900 Offset: 0x746F00 VA: 0x180748900
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTransformOrigin, TransformOrigin>
	|
	|-RVA: 0x748D70 Offset: 0x747370 VA: 0x180748D70
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<StyleTranslate, Translate>
	|
	|-RVA: 0x7491F0 Offset: 0x7477F0 VA: 0x1807491F0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<TextShadow, Vector2>
	|
	|-RVA: 0x7451D0 Offset: 0x7437D0 VA: 0x1807451D0
	|-PathVisitor.Unity.Properties.IPropertyVisitor.Visit<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-PathVisitor.VisitPath<StyleEnum<Int32Enum>, Int32Enum>
	|-PathVisitor.VisitPath<StyleList<EasingFunction>, Int32Enum>
	|-PathVisitor.VisitPath<StyleList<EasingFunction>, object>
	|-PathVisitor.VisitPath<StyleList<StylePropertyName>, Int32Enum>
	|-PathVisitor.VisitPath<StyleList<StylePropertyName>, object>
	|-PathVisitor.VisitPath<StyleList<TimeValue>, Int32Enum>
	|-PathVisitor.VisitPath<StyleList<TimeValue>, object>
	|-PathVisitor.VisitPath<Angle, Int32Enum>
	|-PathVisitor.VisitPath<Angle, float>
	|-PathVisitor.VisitPath<Background, object>
	|-PathVisitor.VisitPath<BackgroundPosition, Int32Enum>
	|-PathVisitor.VisitPath<BackgroundPosition, Length>
	|-PathVisitor.VisitPath<BackgroundRepeat, Int32Enum>
	|-PathVisitor.VisitPath<BackgroundSize, Int32Enum>
	|-PathVisitor.VisitPath<BackgroundSize, Length>
	|-PathVisitor.VisitPath<Bounds, Vector3>
	|-PathVisitor.VisitPath<BoundsInt, Vector3Int>
	|-PathVisitor.VisitPath<Color, float>
	|-PathVisitor.VisitPath<Cursor, int>
	|-PathVisitor.VisitPath<Cursor, object>
	|-PathVisitor.VisitPath<Cursor, Vector2>
	|-PathVisitor.VisitPath<EasingFunction, Int32Enum>
	|-PathVisitor.VisitPath<FontDefinition, object>
	|-PathVisitor.VisitPath<Length, Int32Enum>
	|-PathVisitor.VisitPath<Length, float>
	|-PathVisitor.VisitPath<object, StyleEnum<Int32Enum>>
	|-PathVisitor.VisitPath<object, StyleList<EasingFunction>>
	|-PathVisitor.VisitPath<object, StyleList<StylePropertyName>>
	|-PathVisitor.VisitPath<object, StyleList<TimeValue>>
	|-PathVisitor.VisitPath<object, Background>
	|-PathVisitor.VisitPath<object, BackgroundPosition>
	|-PathVisitor.VisitPath<object, BackgroundRepeat>
	|-PathVisitor.VisitPath<object, BackgroundSize>
	|-PathVisitor.VisitPath<object, Color>
	|-PathVisitor.VisitPath<object, EasingFunction>
	|-PathVisitor.VisitPath<object, FontDefinition>
	|-PathVisitor.VisitPath<object, int>
	|-PathVisitor.VisitPath<object, Int32Enum>
	|-PathVisitor.VisitPath<object, object>
	|-PathVisitor.VisitPath<object, Rotate>
	|-PathVisitor.VisitPath<object, Scale>
	|-PathVisitor.VisitPath<object, float>
	|-PathVisitor.VisitPath<object, StyleBackground>
	|-PathVisitor.VisitPath<object, StyleBackgroundPosition>
	|-PathVisitor.VisitPath<object, StyleBackgroundRepeat>
	|-PathVisitor.VisitPath<object, StyleBackgroundSize>
	|-PathVisitor.VisitPath<object, StyleColor>
	|-PathVisitor.VisitPath<object, StyleCursor>
	|-PathVisitor.VisitPath<object, StyleFloat>
	|-PathVisitor.VisitPath<object, StyleFont>
	|-PathVisitor.VisitPath<object, StyleFontDefinition>
	|-PathVisitor.VisitPath<object, StyleInt>
	|-PathVisitor.VisitPath<object, StyleLength>
	|-PathVisitor.VisitPath<object, StylePropertyName>
	|-PathVisitor.VisitPath<object, StyleRotate>
	|-PathVisitor.VisitPath<object, StyleScale>
	|-PathVisitor.VisitPath<object, StyleTextShadow>
	|-PathVisitor.VisitPath<object, StyleTransformOrigin>
	|-PathVisitor.VisitPath<object, StyleTranslate>
	|-PathVisitor.VisitPath<object, TimeValue>
	|-PathVisitor.VisitPath<object, Vector3>
	|-PathVisitor.VisitPath<Rect, float>
	|-PathVisitor.VisitPath<RectInt, int>
	|-PathVisitor.VisitPath<Rotate, Angle>
	|-PathVisitor.VisitPath<Rotate, Vector3>
	|-PathVisitor.VisitPath<Scale, Vector3>
	|-PathVisitor.VisitPath<StyleBackground, Background>
	|-PathVisitor.VisitPath<StyleBackground, Int32Enum>
	|-PathVisitor.VisitPath<StyleBackgroundPosition, BackgroundPosition>
	|-PathVisitor.VisitPath<StyleBackgroundPosition, Int32Enum>
	|-PathVisitor.VisitPath<StyleBackgroundRepeat, BackgroundRepeat>
	|-PathVisitor.VisitPath<StyleBackgroundRepeat, Int32Enum>
	|-PathVisitor.VisitPath<StyleBackgroundSize, BackgroundSize>
	|-PathVisitor.VisitPath<StyleBackgroundSize, Int32Enum>
	|-PathVisitor.VisitPath<StyleColor, Color>
	|-PathVisitor.VisitPath<StyleColor, Int32Enum>
	|-PathVisitor.VisitPath<StyleCursor, Cursor>
	|-PathVisitor.VisitPath<StyleCursor, Int32Enum>
	|-PathVisitor.VisitPath<StyleFloat, Int32Enum>
	|-PathVisitor.VisitPath<StyleFloat, float>
	|-PathVisitor.VisitPath<StyleFont, Int32Enum>
	|-PathVisitor.VisitPath<StyleFont, object>
	|-PathVisitor.VisitPath<StyleFontDefinition, FontDefinition>
	|-PathVisitor.VisitPath<StyleFontDefinition, Int32Enum>
	|-PathVisitor.VisitPath<StyleInt, int>
	|-PathVisitor.VisitPath<StyleInt, Int32Enum>
	|-PathVisitor.VisitPath<StyleLength, Int32Enum>
	|-PathVisitor.VisitPath<StyleLength, Length>
	|-PathVisitor.VisitPath<StylePropertyName, Int32Enum>
	|-PathVisitor.VisitPath<StylePropertyName, object>
	|-PathVisitor.VisitPath<StyleRotate, Int32Enum>
	|-PathVisitor.VisitPath<StyleRotate, Rotate>
	|-PathVisitor.VisitPath<StyleScale, Int32Enum>
	|-PathVisitor.VisitPath<StyleScale, Scale>
	|-PathVisitor.VisitPath<StyleTextShadow, Int32Enum>
	|-PathVisitor.VisitPath<StyleTextShadow, TextShadow>
	|-PathVisitor.VisitPath<StyleTransformOrigin, Int32Enum>
	|-PathVisitor.VisitPath<StyleTransformOrigin, TransformOrigin>
	|-PathVisitor.VisitPath<StyleTranslate, Int32Enum>
	|-PathVisitor.VisitPath<StyleTranslate, Translate>
	|-PathVisitor.VisitPath<TextShadow, Color>
	|-PathVisitor.VisitPath<TextShadow, float>
	|-PathVisitor.VisitPath<TextShadow, Vector2>
	|-PathVisitor.VisitPath<TimeValue, Int32Enum>
	|-PathVisitor.VisitPath<TimeValue, float>
	|-PathVisitor.VisitPath<TransformOrigin, Length>
	|-PathVisitor.VisitPath<TransformOrigin, float>
	|-PathVisitor.VisitPath<Translate, Length>
	|-PathVisitor.VisitPath<Translate, float>
	|-PathVisitor.VisitPath<Vector2, float>
	|-PathVisitor.VisitPath<Vector2Int, int>
	|-PathVisitor.VisitPath<Vector3, float>
	|-PathVisitor.VisitPath<Vector3Int, int>
	|-PathVisitor.VisitPath<Vector4, float>
	|-PathVisitor.VisitPath<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: Unity.Properties
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
[IsReadOnly]
internal struct ConversionRegistry : IEqualityComparer<ConversionRegistry> // TypeDefIndex: 12995
{
	// Fields
	private static readonly ConversionRegistry.ConverterKeyComparer Comparer; // 0x0
	private readonly Dictionary<ConversionRegistry.ConverterKey, Delegate> m_Converters; // 0x0

	// Methods

	// RVA: 0x8F9B40 Offset: 0x8F8140 VA: 0x1808F9B40
	private void .ctor(Dictionary<ConversionRegistry.ConverterKey, Delegate> storage) { }

	// RVA: 0x23BBA00 Offset: 0x23BA000 VA: 0x1823BBA00
	public static ConversionRegistry Create() { }

	// RVA: 0x23BBBB0 Offset: 0x23BA1B0 VA: 0x1823BBBB0
	public void Register(Type source, Type destination, Delegate converter) { }

	// RVA: 0x23BBAC0 Offset: 0x23BA0C0 VA: 0x1823BBAC0
	public Delegate GetConverter(Type source, Type destination) { }

	// RVA: 0x23BBCB0 Offset: 0x23BA2B0 VA: 0x1823BBCB0
	public bool TryGetConverter(Type source, Type destination, out Delegate converter) { }

	// RVA: 0x23BBAB0 Offset: 0x23BA0B0 VA: 0x1823BBAB0 Slot: 4
	public bool Equals(ConversionRegistry x, ConversionRegistry y) { }

	// RVA: 0x23BBB80 Offset: 0x23BA180 VA: 0x1823BBB80 Slot: 5
	public int GetHashCode(ConversionRegistry obj) { }

	// RVA: 0x23BBD40 Offset: 0x23BA340 VA: 0x1823BBD40
	private static void .cctor() { }
}

// Namespace: Unity.Properties
public sealed class TypeConverter<TSource, TDestination> : MulticastDelegate // TypeDefIndex: 12996
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA819C0 Offset: 0xA7FFC0 VA: 0x180A819C0
	|-TypeConverter<StyleEnum<Int32Enum>, Int32Enum>..ctor
	|-TypeConverter<StyleList<EasingFunction>, Int32Enum>..ctor
	|-TypeConverter<StyleList<StylePropertyName>, Int32Enum>..ctor
	|-TypeConverter<StyleList<TimeValue>, Int32Enum>..ctor
	|-TypeConverter<bool, int>..ctor
	|-TypeConverter<bool, uint>..ctor
	|-TypeConverter<byte, int>..ctor
	|-TypeConverter<byte, uint>..ctor
	|-TypeConverter<char, int>..ctor
	|-TypeConverter<char, uint>..ctor
	|-TypeConverter<Color, Color32>..ctor
	|-TypeConverter<double, int>..ctor
	|-TypeConverter<double, uint>..ctor
	|-TypeConverter<short, int>..ctor
	|-TypeConverter<short, uint>..ctor
	|-TypeConverter<int, uint>..ctor
	|-TypeConverter<long, int>..ctor
	|-TypeConverter<long, uint>..ctor
	|-TypeConverter<sbyte, int>..ctor
	|-TypeConverter<sbyte, uint>..ctor
	|-TypeConverter<float, int>..ctor
	|-TypeConverter<float, uint>..ctor
	|-TypeConverter<StyleBackground, Int32Enum>..ctor
	|-TypeConverter<StyleBackgroundPosition, Int32Enum>..ctor
	|-TypeConverter<StyleBackgroundRepeat, Int32Enum>..ctor
	|-TypeConverter<StyleBackgroundSize, Int32Enum>..ctor
	|-TypeConverter<StyleColor, Color32>..ctor
	|-TypeConverter<StyleColor, Int32Enum>..ctor
	|-TypeConverter<StyleCursor, Int32Enum>..ctor
	|-TypeConverter<StyleFloat, int>..ctor
	|-TypeConverter<StyleFloat, Int32Enum>..ctor
	|-TypeConverter<StyleFont, Int32Enum>..ctor
	|-TypeConverter<StyleFontDefinition, Int32Enum>..ctor
	|-TypeConverter<StyleInt, int>..ctor
	|-TypeConverter<StyleInt, Int32Enum>..ctor
	|-TypeConverter<StyleLength, int>..ctor
	|-TypeConverter<StyleLength, Int32Enum>..ctor
	|-TypeConverter<StyleRotate, Int32Enum>..ctor
	|-TypeConverter<StyleScale, Int32Enum>..ctor
	|-TypeConverter<StyleTextShadow, Int32Enum>..ctor
	|-TypeConverter<StyleTransformOrigin, Int32Enum>..ctor
	|-TypeConverter<StyleTranslate, Int32Enum>..ctor
	|-TypeConverter<ushort, int>..ctor
	|-TypeConverter<ushort, uint>..ctor
	|-TypeConverter<uint, int>..ctor
	|-TypeConverter<ulong, int>..ctor
	|-TypeConverter<ulong, uint>..ctor
	|
	|-RVA: 0xA81B40 Offset: 0xA80140 VA: 0x180A81B40
	|-TypeConverter<StyleList<EasingFunction>, object>..ctor
	|-TypeConverter<StyleList<StylePropertyName>, object>..ctor
	|-TypeConverter<StyleList<TimeValue>, object>..ctor
	|-TypeConverter<bool, long>..ctor
	|-TypeConverter<bool, object>..ctor
	|-TypeConverter<bool, ulong>..ctor
	|-TypeConverter<byte, long>..ctor
	|-TypeConverter<byte, object>..ctor
	|-TypeConverter<byte, ulong>..ctor
	|-TypeConverter<char, long>..ctor
	|-TypeConverter<char, object>..ctor
	|-TypeConverter<char, ulong>..ctor
	|-TypeConverter<double, long>..ctor
	|-TypeConverter<double, object>..ctor
	|-TypeConverter<double, ulong>..ctor
	|-TypeConverter<short, long>..ctor
	|-TypeConverter<short, object>..ctor
	|-TypeConverter<short, ulong>..ctor
	|-TypeConverter<int, long>..ctor
	|-TypeConverter<int, object>..ctor
	|-TypeConverter<int, StyleFloat>..ctor
	|-TypeConverter<int, StyleInt>..ctor
	|-TypeConverter<int, ulong>..ctor
	|-TypeConverter<Int32Enum, StyleEnum<Int32Enum>>..ctor
	|-TypeConverter<Int32Enum, StyleFloat>..ctor
	|-TypeConverter<Int32Enum, StyleInt>..ctor
	|-TypeConverter<long, object>..ctor
	|-TypeConverter<long, ulong>..ctor
	|-TypeConverter<sbyte, long>..ctor
	|-TypeConverter<sbyte, object>..ctor
	|-TypeConverter<sbyte, ulong>..ctor
	|-TypeConverter<float, long>..ctor
	|-TypeConverter<float, object>..ctor
	|-TypeConverter<float, StyleFloat>..ctor
	|-TypeConverter<float, ulong>..ctor
	|-TypeConverter<StyleBackground, object>..ctor
	|-TypeConverter<StyleBackgroundRepeat, BackgroundRepeat>..ctor
	|-TypeConverter<StyleFont, object>..ctor
	|-TypeConverter<StyleFontDefinition, object>..ctor
	|-TypeConverter<StyleLength, Length>..ctor
	|-TypeConverter<ushort, long>..ctor
	|-TypeConverter<ushort, object>..ctor
	|-TypeConverter<ushort, ulong>..ctor
	|-TypeConverter<uint, long>..ctor
	|-TypeConverter<uint, object>..ctor
	|-TypeConverter<uint, ulong>..ctor
	|-TypeConverter<ulong, long>..ctor
	|-TypeConverter<ulong, object>..ctor
	|
	|-RVA: 0xA81C00 Offset: 0xA80200 VA: 0x180A81C00
	|-TypeConverter<Background, StyleBackground>..ctor
	|-TypeConverter<Int32Enum, StyleBackground>..ctor
	|
	|-RVA: 0xA81F00 Offset: 0xA80500 VA: 0x180A81F00
	|-TypeConverter<BackgroundPosition, StyleBackgroundPosition>..ctor
	|-TypeConverter<Color32, Color>..ctor
	|-TypeConverter<Int32Enum, StyleList<EasingFunction>>..ctor
	|-TypeConverter<Int32Enum, StyleList<StylePropertyName>>..ctor
	|-TypeConverter<Int32Enum, StyleList<TimeValue>>..ctor
	|-TypeConverter<Int32Enum, StyleBackgroundPosition>..ctor
	|-TypeConverter<Int32Enum, StyleFont>..ctor
	|-TypeConverter<StyleColor, Color>..ctor
	|-TypeConverter<StyleFontDefinition, FontDefinition>..ctor
	|-TypeConverter<StyleScale, Scale>..ctor
	|
	|-RVA: 0xA81A80 Offset: 0xA80080 VA: 0x180A81A80
	|-TypeConverter<BackgroundRepeat, StyleBackgroundRepeat>..ctor
	|-TypeConverter<int, StyleLength>..ctor
	|-TypeConverter<Int32Enum, StyleBackgroundRepeat>..ctor
	|-TypeConverter<Int32Enum, StyleLength>..ctor
	|-TypeConverter<Length, StyleLength>..ctor
	|-TypeConverter<float, StyleLength>..ctor
	|-TypeConverter<StyleBackgroundPosition, BackgroundPosition>..ctor
	|
	|-RVA: 0xA81CC0 Offset: 0xA802C0 VA: 0x180A81CC0
	|-TypeConverter<BackgroundSize, StyleBackgroundSize>..ctor
	|-TypeConverter<FontDefinition, StyleFontDefinition>..ctor
	|-TypeConverter<Int32Enum, StyleBackgroundSize>..ctor
	|-TypeConverter<Int32Enum, StyleFontDefinition>..ctor
	|-TypeConverter<Int32Enum, StyleTransformOrigin>..ctor
	|-TypeConverter<StyleCursor, Cursor>..ctor
	|-TypeConverter<StyleRotate, Rotate>..ctor
	|-TypeConverter<StyleTranslate, Translate>..ctor
	|-TypeConverter<TransformOrigin, StyleTransformOrigin>..ctor
	|
	|-RVA: 0x5D7960 Offset: 0x5D5F60 VA: 0x1805D7960
	|-TypeConverter<bool, byte>..ctor
	|-TypeConverter<bool, sbyte>..ctor
	|-TypeConverter<byte, bool>..ctor
	|-TypeConverter<byte, sbyte>..ctor
	|-TypeConverter<char, bool>..ctor
	|-TypeConverter<char, byte>..ctor
	|-TypeConverter<char, sbyte>..ctor
	|-TypeConverter<double, bool>..ctor
	|-TypeConverter<double, byte>..ctor
	|-TypeConverter<double, sbyte>..ctor
	|-TypeConverter<short, bool>..ctor
	|-TypeConverter<short, byte>..ctor
	|-TypeConverter<short, sbyte>..ctor
	|-TypeConverter<int, bool>..ctor
	|-TypeConverter<int, byte>..ctor
	|-TypeConverter<int, sbyte>..ctor
	|-TypeConverter<long, bool>..ctor
	|-TypeConverter<long, byte>..ctor
	|-TypeConverter<long, sbyte>..ctor
	|-TypeConverter<sbyte, bool>..ctor
	|-TypeConverter<sbyte, byte>..ctor
	|-TypeConverter<float, bool>..ctor
	|-TypeConverter<float, byte>..ctor
	|-TypeConverter<float, sbyte>..ctor
	|-TypeConverter<ushort, bool>..ctor
	|-TypeConverter<ushort, byte>..ctor
	|-TypeConverter<ushort, sbyte>..ctor
	|-TypeConverter<uint, bool>..ctor
	|-TypeConverter<uint, byte>..ctor
	|-TypeConverter<uint, sbyte>..ctor
	|-TypeConverter<ulong, bool>..ctor
	|-TypeConverter<ulong, byte>..ctor
	|-TypeConverter<ulong, sbyte>..ctor
	|
	|-RVA: 0xA81D80 Offset: 0xA80380 VA: 0x180A81D80
	|-TypeConverter<bool, char>..ctor
	|-TypeConverter<bool, short>..ctor
	|-TypeConverter<bool, ushort>..ctor
	|-TypeConverter<byte, char>..ctor
	|-TypeConverter<byte, short>..ctor
	|-TypeConverter<byte, ushort>..ctor
	|-TypeConverter<char, short>..ctor
	|-TypeConverter<char, ushort>..ctor
	|-TypeConverter<double, char>..ctor
	|-TypeConverter<double, short>..ctor
	|-TypeConverter<double, ushort>..ctor
	|-TypeConverter<short, char>..ctor
	|-TypeConverter<short, ushort>..ctor
	|-TypeConverter<int, char>..ctor
	|-TypeConverter<int, short>..ctor
	|-TypeConverter<int, ushort>..ctor
	|-TypeConverter<long, char>..ctor
	|-TypeConverter<long, short>..ctor
	|-TypeConverter<long, ushort>..ctor
	|-TypeConverter<sbyte, char>..ctor
	|-TypeConverter<sbyte, short>..ctor
	|-TypeConverter<sbyte, ushort>..ctor
	|-TypeConverter<float, char>..ctor
	|-TypeConverter<float, short>..ctor
	|-TypeConverter<float, ushort>..ctor
	|-TypeConverter<ushort, char>..ctor
	|-TypeConverter<ushort, short>..ctor
	|-TypeConverter<uint, char>..ctor
	|-TypeConverter<uint, short>..ctor
	|-TypeConverter<uint, ushort>..ctor
	|-TypeConverter<ulong, char>..ctor
	|-TypeConverter<ulong, short>..ctor
	|-TypeConverter<ulong, ushort>..ctor
	|
	|-RVA: 0xA81E40 Offset: 0xA80440 VA: 0x180A81E40
	|-TypeConverter<bool, double>..ctor
	|-TypeConverter<bool, float>..ctor
	|-TypeConverter<byte, double>..ctor
	|-TypeConverter<byte, float>..ctor
	|-TypeConverter<char, double>..ctor
	|-TypeConverter<char, float>..ctor
	|-TypeConverter<double, float>..ctor
	|-TypeConverter<short, double>..ctor
	|-TypeConverter<short, float>..ctor
	|-TypeConverter<int, double>..ctor
	|-TypeConverter<int, float>..ctor
	|-TypeConverter<long, double>..ctor
	|-TypeConverter<long, float>..ctor
	|-TypeConverter<sbyte, double>..ctor
	|-TypeConverter<sbyte, float>..ctor
	|-TypeConverter<float, double>..ctor
	|-TypeConverter<StyleFloat, float>..ctor
	|-TypeConverter<StyleLength, float>..ctor
	|-TypeConverter<ushort, double>..ctor
	|-TypeConverter<ushort, float>..ctor
	|-TypeConverter<uint, double>..ctor
	|-TypeConverter<uint, float>..ctor
	|-TypeConverter<ulong, double>..ctor
	|-TypeConverter<ulong, float>..ctor
	|
	|-RVA: 0xA82380 Offset: 0xA80980 VA: 0x180A82380
	|-TypeConverter<Color, StyleColor>..ctor
	|-TypeConverter<Color32, StyleColor>..ctor
	|-TypeConverter<Int32Enum, StyleColor>..ctor
	|-TypeConverter<Int32Enum, StyleScale>..ctor
	|-TypeConverter<Scale, StyleScale>..ctor
	|-TypeConverter<StyleBackgroundSize, BackgroundSize>..ctor
	|-TypeConverter<StyleTransformOrigin, TransformOrigin>..ctor
	|
	|-RVA: 0xA82500 Offset: 0xA80B00 VA: 0x180A82500
	|-TypeConverter<Cursor, StyleCursor>..ctor
	|-TypeConverter<Int32Enum, StyleCursor>..ctor
	|-TypeConverter<Int32Enum, StyleTextShadow>..ctor
	|-TypeConverter<StyleBackground, Background>..ctor
	|-TypeConverter<TextShadow, StyleTextShadow>..ctor
	|
	|-RVA: 0xA82080 Offset: 0xA80680 VA: 0x180A82080
	|-TypeConverter<Int32Enum, StyleRotate>..ctor
	|-TypeConverter<Int32Enum, StyleTranslate>..ctor
	|-TypeConverter<Rotate, StyleRotate>..ctor
	|-TypeConverter<StyleTextShadow, TextShadow>..ctor
	|-TypeConverter<Translate, StyleTranslate>..ctor
	|
	|-RVA: 0xA82440 Offset: 0xA80A40 VA: 0x180A82440
	|-TypeConverter<object, StyleList<EasingFunction>>..ctor
	|-TypeConverter<object, StyleList<StylePropertyName>>..ctor
	|-TypeConverter<object, StyleList<TimeValue>>..ctor
	|-TypeConverter<object, Guid>..ctor
	|-TypeConverter<object, StyleFont>..ctor
	|
	|-RVA: 0xA82200 Offset: 0xA80800 VA: 0x180A82200
	|-TypeConverter<object, bool>..ctor
	|-TypeConverter<object, byte>..ctor
	|-TypeConverter<object, sbyte>..ctor
	|
	|-RVA: 0xA82140 Offset: 0xA80740 VA: 0x180A82140
	|-TypeConverter<object, char>..ctor
	|-TypeConverter<object, short>..ctor
	|-TypeConverter<object, ushort>..ctor
	|
	|-RVA: 0xA82740 Offset: 0xA80D40 VA: 0x180A82740
	|-TypeConverter<object, double>..ctor
	|-TypeConverter<object, float>..ctor
	|
	|-RVA: 0xA82680 Offset: 0xA80C80 VA: 0x180A82680
	|-TypeConverter<object, int>..ctor
	|-TypeConverter<object, uint>..ctor
	|
	|-RVA: 0xA825C0 Offset: 0xA80BC0 VA: 0x180A825C0
	|-TypeConverter<object, long>..ctor
	|-TypeConverter<object, ulong>..ctor
	|
	|-RVA: 0xA82800 Offset: 0xA80E00 VA: 0x180A82800
	|-TypeConverter<object, StyleBackground>..ctor
	|
	|-RVA: 0xA822C0 Offset: 0xA808C0 VA: 0x180A822C0
	|-TypeConverter<object, StyleFontDefinition>..ctor
	|
	|-RVA: 0x8B6560 Offset: 0x8B4B60 VA: 0x1808B6560
	|-TypeConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual TDestination Invoke(ref TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D7950 Offset: 0x5D5F50 VA: 0x1805D7950
	|-TypeConverter<StyleEnum<Int32Enum>, Int32Enum>.Invoke
	|-TypeConverter<StyleList<EasingFunction>, Int32Enum>.Invoke
	|-TypeConverter<StyleList<EasingFunction>, object>.Invoke
	|-TypeConverter<StyleList<StylePropertyName>, Int32Enum>.Invoke
	|-TypeConverter<StyleList<StylePropertyName>, object>.Invoke
	|-TypeConverter<StyleList<TimeValue>, Int32Enum>.Invoke
	|-TypeConverter<StyleList<TimeValue>, object>.Invoke
	|-TypeConverter<bool, byte>.Invoke
	|-TypeConverter<bool, char>.Invoke
	|-TypeConverter<bool, double>.Invoke
	|-TypeConverter<bool, short>.Invoke
	|-TypeConverter<bool, int>.Invoke
	|-TypeConverter<bool, long>.Invoke
	|-TypeConverter<bool, object>.Invoke
	|-TypeConverter<bool, sbyte>.Invoke
	|-TypeConverter<bool, float>.Invoke
	|-TypeConverter<bool, ushort>.Invoke
	|-TypeConverter<bool, uint>.Invoke
	|-TypeConverter<bool, ulong>.Invoke
	|-TypeConverter<byte, bool>.Invoke
	|-TypeConverter<byte, char>.Invoke
	|-TypeConverter<byte, double>.Invoke
	|-TypeConverter<byte, short>.Invoke
	|-TypeConverter<byte, int>.Invoke
	|-TypeConverter<byte, long>.Invoke
	|-TypeConverter<byte, object>.Invoke
	|-TypeConverter<byte, sbyte>.Invoke
	|-TypeConverter<byte, float>.Invoke
	|-TypeConverter<byte, ushort>.Invoke
	|-TypeConverter<byte, uint>.Invoke
	|-TypeConverter<byte, ulong>.Invoke
	|-TypeConverter<char, bool>.Invoke
	|-TypeConverter<char, byte>.Invoke
	|-TypeConverter<char, double>.Invoke
	|-TypeConverter<char, short>.Invoke
	|-TypeConverter<char, int>.Invoke
	|-TypeConverter<char, long>.Invoke
	|-TypeConverter<char, object>.Invoke
	|-TypeConverter<char, sbyte>.Invoke
	|-TypeConverter<char, float>.Invoke
	|-TypeConverter<char, ushort>.Invoke
	|-TypeConverter<char, uint>.Invoke
	|-TypeConverter<char, ulong>.Invoke
	|-TypeConverter<Color, Color32>.Invoke
	|-TypeConverter<double, bool>.Invoke
	|-TypeConverter<double, byte>.Invoke
	|-TypeConverter<double, char>.Invoke
	|-TypeConverter<double, short>.Invoke
	|-TypeConverter<double, int>.Invoke
	|-TypeConverter<double, long>.Invoke
	|-TypeConverter<double, object>.Invoke
	|-TypeConverter<double, sbyte>.Invoke
	|-TypeConverter<double, float>.Invoke
	|-TypeConverter<double, ushort>.Invoke
	|-TypeConverter<double, uint>.Invoke
	|-TypeConverter<double, ulong>.Invoke
	|-TypeConverter<short, bool>.Invoke
	|-TypeConverter<short, byte>.Invoke
	|-TypeConverter<short, char>.Invoke
	|-TypeConverter<short, double>.Invoke
	|-TypeConverter<short, int>.Invoke
	|-TypeConverter<short, long>.Invoke
	|-TypeConverter<short, object>.Invoke
	|-TypeConverter<short, sbyte>.Invoke
	|-TypeConverter<short, float>.Invoke
	|-TypeConverter<short, ushort>.Invoke
	|-TypeConverter<short, uint>.Invoke
	|-TypeConverter<short, ulong>.Invoke
	|-TypeConverter<int, bool>.Invoke
	|-TypeConverter<int, byte>.Invoke
	|-TypeConverter<int, char>.Invoke
	|-TypeConverter<int, double>.Invoke
	|-TypeConverter<int, short>.Invoke
	|-TypeConverter<int, long>.Invoke
	|-TypeConverter<int, object>.Invoke
	|-TypeConverter<int, sbyte>.Invoke
	|-TypeConverter<int, float>.Invoke
	|-TypeConverter<int, StyleFloat>.Invoke
	|-TypeConverter<int, StyleInt>.Invoke
	|-TypeConverter<int, ushort>.Invoke
	|-TypeConverter<int, uint>.Invoke
	|-TypeConverter<int, ulong>.Invoke
	|-TypeConverter<Int32Enum, StyleEnum<Int32Enum>>.Invoke
	|-TypeConverter<Int32Enum, StyleFloat>.Invoke
	|-TypeConverter<Int32Enum, StyleInt>.Invoke
	|-TypeConverter<long, bool>.Invoke
	|-TypeConverter<long, byte>.Invoke
	|-TypeConverter<long, char>.Invoke
	|-TypeConverter<long, double>.Invoke
	|-TypeConverter<long, short>.Invoke
	|-TypeConverter<long, int>.Invoke
	|-TypeConverter<long, object>.Invoke
	|-TypeConverter<long, sbyte>.Invoke
	|-TypeConverter<long, float>.Invoke
	|-TypeConverter<long, ushort>.Invoke
	|-TypeConverter<long, uint>.Invoke
	|-TypeConverter<long, ulong>.Invoke
	|-TypeConverter<object, bool>.Invoke
	|-TypeConverter<object, byte>.Invoke
	|-TypeConverter<object, char>.Invoke
	|-TypeConverter<object, double>.Invoke
	|-TypeConverter<object, short>.Invoke
	|-TypeConverter<object, int>.Invoke
	|-TypeConverter<object, long>.Invoke
	|-TypeConverter<object, sbyte>.Invoke
	|-TypeConverter<object, float>.Invoke
	|-TypeConverter<object, ushort>.Invoke
	|-TypeConverter<object, uint>.Invoke
	|-TypeConverter<object, ulong>.Invoke
	|-TypeConverter<sbyte, bool>.Invoke
	|-TypeConverter<sbyte, byte>.Invoke
	|-TypeConverter<sbyte, char>.Invoke
	|-TypeConverter<sbyte, double>.Invoke
	|-TypeConverter<sbyte, short>.Invoke
	|-TypeConverter<sbyte, int>.Invoke
	|-TypeConverter<sbyte, long>.Invoke
	|-TypeConverter<sbyte, object>.Invoke
	|-TypeConverter<sbyte, float>.Invoke
	|-TypeConverter<sbyte, ushort>.Invoke
	|-TypeConverter<sbyte, uint>.Invoke
	|-TypeConverter<sbyte, ulong>.Invoke
	|-TypeConverter<float, bool>.Invoke
	|-TypeConverter<float, byte>.Invoke
	|-TypeConverter<float, char>.Invoke
	|-TypeConverter<float, double>.Invoke
	|-TypeConverter<float, short>.Invoke
	|-TypeConverter<float, int>.Invoke
	|-TypeConverter<float, long>.Invoke
	|-TypeConverter<float, object>.Invoke
	|-TypeConverter<float, sbyte>.Invoke
	|-TypeConverter<float, StyleFloat>.Invoke
	|-TypeConverter<float, ushort>.Invoke
	|-TypeConverter<float, uint>.Invoke
	|-TypeConverter<float, ulong>.Invoke
	|-TypeConverter<StyleBackground, Int32Enum>.Invoke
	|-TypeConverter<StyleBackground, object>.Invoke
	|-TypeConverter<StyleBackgroundPosition, Int32Enum>.Invoke
	|-TypeConverter<StyleBackgroundRepeat, BackgroundRepeat>.Invoke
	|-TypeConverter<StyleBackgroundRepeat, Int32Enum>.Invoke
	|-TypeConverter<StyleBackgroundSize, Int32Enum>.Invoke
	|-TypeConverter<StyleColor, Color32>.Invoke
	|-TypeConverter<StyleColor, Int32Enum>.Invoke
	|-TypeConverter<StyleCursor, Int32Enum>.Invoke
	|-TypeConverter<StyleFloat, int>.Invoke
	|-TypeConverter<StyleFloat, Int32Enum>.Invoke
	|-TypeConverter<StyleFloat, float>.Invoke
	|-TypeConverter<StyleFont, Int32Enum>.Invoke
	|-TypeConverter<StyleFont, object>.Invoke
	|-TypeConverter<StyleFontDefinition, Int32Enum>.Invoke
	|-TypeConverter<StyleFontDefinition, object>.Invoke
	|-TypeConverter<StyleInt, int>.Invoke
	|-TypeConverter<StyleInt, Int32Enum>.Invoke
	|-TypeConverter<StyleLength, int>.Invoke
	|-TypeConverter<StyleLength, Int32Enum>.Invoke
	|-TypeConverter<StyleLength, Length>.Invoke
	|-TypeConverter<StyleLength, float>.Invoke
	|-TypeConverter<StyleRotate, Int32Enum>.Invoke
	|-TypeConverter<StyleScale, Int32Enum>.Invoke
	|-TypeConverter<StyleTextShadow, Int32Enum>.Invoke
	|-TypeConverter<StyleTransformOrigin, Int32Enum>.Invoke
	|-TypeConverter<StyleTranslate, Int32Enum>.Invoke
	|-TypeConverter<ushort, bool>.Invoke
	|-TypeConverter<ushort, byte>.Invoke
	|-TypeConverter<ushort, char>.Invoke
	|-TypeConverter<ushort, double>.Invoke
	|-TypeConverter<ushort, short>.Invoke
	|-TypeConverter<ushort, int>.Invoke
	|-TypeConverter<ushort, long>.Invoke
	|-TypeConverter<ushort, object>.Invoke
	|-TypeConverter<ushort, sbyte>.Invoke
	|-TypeConverter<ushort, float>.Invoke
	|-TypeConverter<ushort, uint>.Invoke
	|-TypeConverter<ushort, ulong>.Invoke
	|-TypeConverter<uint, bool>.Invoke
	|-TypeConverter<uint, byte>.Invoke
	|-TypeConverter<uint, char>.Invoke
	|-TypeConverter<uint, double>.Invoke
	|-TypeConverter<uint, short>.Invoke
	|-TypeConverter<uint, int>.Invoke
	|-TypeConverter<uint, long>.Invoke
	|-TypeConverter<uint, object>.Invoke
	|-TypeConverter<uint, sbyte>.Invoke
	|-TypeConverter<uint, float>.Invoke
	|-TypeConverter<uint, ushort>.Invoke
	|-TypeConverter<uint, ulong>.Invoke
	|-TypeConverter<ulong, bool>.Invoke
	|-TypeConverter<ulong, byte>.Invoke
	|-TypeConverter<ulong, char>.Invoke
	|-TypeConverter<ulong, double>.Invoke
	|-TypeConverter<ulong, short>.Invoke
	|-TypeConverter<ulong, int>.Invoke
	|-TypeConverter<ulong, long>.Invoke
	|-TypeConverter<ulong, object>.Invoke
	|-TypeConverter<ulong, sbyte>.Invoke
	|-TypeConverter<ulong, float>.Invoke
	|-TypeConverter<ulong, ushort>.Invoke
	|-TypeConverter<ulong, uint>.Invoke
	|
	|-RVA: 0xA81940 Offset: 0xA7FF40 VA: 0x180A81940
	|-TypeConverter<Background, StyleBackground>.Invoke
	|-TypeConverter<Int32Enum, StyleBackground>.Invoke
	|-TypeConverter<object, StyleBackground>.Invoke
	|
	|-RVA: 0xA81910 Offset: 0xA7FF10 VA: 0x180A81910
	|-TypeConverter<BackgroundPosition, StyleBackgroundPosition>.Invoke
	|-TypeConverter<Color32, Color>.Invoke
	|-TypeConverter<Int32Enum, StyleList<EasingFunction>>.Invoke
	|-TypeConverter<Int32Enum, StyleList<StylePropertyName>>.Invoke
	|-TypeConverter<Int32Enum, StyleList<TimeValue>>.Invoke
	|-TypeConverter<Int32Enum, StyleBackgroundPosition>.Invoke
	|-TypeConverter<Int32Enum, StyleFont>.Invoke
	|-TypeConverter<object, StyleList<EasingFunction>>.Invoke
	|-TypeConverter<object, StyleList<StylePropertyName>>.Invoke
	|-TypeConverter<object, StyleList<TimeValue>>.Invoke
	|-TypeConverter<object, Guid>.Invoke
	|-TypeConverter<object, StyleFont>.Invoke
	|-TypeConverter<StyleColor, Color>.Invoke
	|-TypeConverter<StyleFontDefinition, FontDefinition>.Invoke
	|-TypeConverter<StyleScale, Scale>.Invoke
	|
	|-RVA: 0xA818D0 Offset: 0xA7FED0 VA: 0x180A818D0
	|-TypeConverter<BackgroundRepeat, StyleBackgroundRepeat>.Invoke
	|-TypeConverter<int, StyleLength>.Invoke
	|-TypeConverter<Int32Enum, StyleBackgroundRepeat>.Invoke
	|-TypeConverter<Int32Enum, StyleLength>.Invoke
	|-TypeConverter<Length, StyleLength>.Invoke
	|-TypeConverter<float, StyleLength>.Invoke
	|-TypeConverter<StyleBackgroundPosition, BackgroundPosition>.Invoke
	|
	|-RVA: 0xA81980 Offset: 0xA7FF80 VA: 0x180A81980
	|-TypeConverter<BackgroundSize, StyleBackgroundSize>.Invoke
	|-TypeConverter<FontDefinition, StyleFontDefinition>.Invoke
	|-TypeConverter<Int32Enum, StyleBackgroundSize>.Invoke
	|-TypeConverter<Int32Enum, StyleFontDefinition>.Invoke
	|-TypeConverter<Int32Enum, StyleTransformOrigin>.Invoke
	|-TypeConverter<object, StyleFontDefinition>.Invoke
	|-TypeConverter<StyleCursor, Cursor>.Invoke
	|-TypeConverter<StyleRotate, Rotate>.Invoke
	|-TypeConverter<StyleTranslate, Translate>.Invoke
	|-TypeConverter<TransformOrigin, StyleTransformOrigin>.Invoke
	|
	|-RVA: 0xA82040 Offset: 0xA80640 VA: 0x180A82040
	|-TypeConverter<Color, StyleColor>.Invoke
	|-TypeConverter<Color32, StyleColor>.Invoke
	|-TypeConverter<Int32Enum, StyleColor>.Invoke
	|-TypeConverter<Int32Enum, StyleScale>.Invoke
	|-TypeConverter<Scale, StyleScale>.Invoke
	|-TypeConverter<StyleBackgroundSize, BackgroundSize>.Invoke
	|-TypeConverter<StyleTransformOrigin, TransformOrigin>.Invoke
	|
	|-RVA: 0xA82000 Offset: 0xA80600 VA: 0x180A82000
	|-TypeConverter<Cursor, StyleCursor>.Invoke
	|-TypeConverter<Int32Enum, StyleCursor>.Invoke
	|-TypeConverter<Int32Enum, StyleTextShadow>.Invoke
	|-TypeConverter<StyleBackground, Background>.Invoke
	|-TypeConverter<TextShadow, StyleTextShadow>.Invoke
	|
	|-RVA: 0xA81FC0 Offset: 0xA805C0 VA: 0x180A81FC0
	|-TypeConverter<Int32Enum, StyleRotate>.Invoke
	|-TypeConverter<Int32Enum, StyleTranslate>.Invoke
	|-TypeConverter<Rotate, StyleRotate>.Invoke
	|-TypeConverter<StyleTextShadow, TextShadow>.Invoke
	|-TypeConverter<Translate, StyleTranslate>.Invoke
	|
	|-RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0
	|-TypeConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public static class TypeConversion // TypeDefIndex: 12999
{
	// Fields
	private static readonly ConversionRegistry s_GlobalConverters; // 0x0

	// Methods

	// RVA: 0x23DAC00 Offset: 0x23D9200 VA: 0x1823DAC00
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	public static void Register<TSource, TDestination>(TypeConverter<TSource, TDestination> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C6C90 Offset: 0x7C5290 VA: 0x1807C6C90
	|-TypeConversion.Register<StyleEnum<Int32Enum>, Int32Enum>
	|-TypeConversion.Register<StyleList<EasingFunction>, Int32Enum>
	|-TypeConversion.Register<StyleList<EasingFunction>, object>
	|-TypeConversion.Register<StyleList<StylePropertyName>, Int32Enum>
	|-TypeConversion.Register<StyleList<StylePropertyName>, object>
	|-TypeConversion.Register<StyleList<TimeValue>, Int32Enum>
	|-TypeConversion.Register<StyleList<TimeValue>, object>
	|-TypeConversion.Register<Background, StyleBackground>
	|-TypeConversion.Register<BackgroundPosition, StyleBackgroundPosition>
	|-TypeConversion.Register<BackgroundRepeat, StyleBackgroundRepeat>
	|-TypeConversion.Register<BackgroundSize, StyleBackgroundSize>
	|-TypeConversion.Register<Color, StyleColor>
	|-TypeConversion.Register<Color32, StyleColor>
	|-TypeConversion.Register<Cursor, StyleCursor>
	|-TypeConversion.Register<FontDefinition, StyleFontDefinition>
	|-TypeConversion.Register<int, StyleFloat>
	|-TypeConversion.Register<int, StyleInt>
	|-TypeConversion.Register<int, StyleLength>
	|-TypeConversion.Register<Int32Enum, StyleEnum<Int32Enum>>
	|-TypeConversion.Register<Int32Enum, StyleList<EasingFunction>>
	|-TypeConversion.Register<Int32Enum, StyleList<StylePropertyName>>
	|-TypeConversion.Register<Int32Enum, StyleList<TimeValue>>
	|-TypeConversion.Register<Int32Enum, StyleBackground>
	|-TypeConversion.Register<Int32Enum, StyleBackgroundPosition>
	|-TypeConversion.Register<Int32Enum, StyleBackgroundRepeat>
	|-TypeConversion.Register<Int32Enum, StyleBackgroundSize>
	|-TypeConversion.Register<Int32Enum, StyleColor>
	|-TypeConversion.Register<Int32Enum, StyleCursor>
	|-TypeConversion.Register<Int32Enum, StyleFloat>
	|-TypeConversion.Register<Int32Enum, StyleFont>
	|-TypeConversion.Register<Int32Enum, StyleFontDefinition>
	|-TypeConversion.Register<Int32Enum, StyleInt>
	|-TypeConversion.Register<Int32Enum, StyleLength>
	|-TypeConversion.Register<Int32Enum, StyleRotate>
	|-TypeConversion.Register<Int32Enum, StyleScale>
	|-TypeConversion.Register<Int32Enum, StyleTextShadow>
	|-TypeConversion.Register<Int32Enum, StyleTransformOrigin>
	|-TypeConversion.Register<Int32Enum, StyleTranslate>
	|-TypeConversion.Register<Length, StyleLength>
	|-TypeConversion.Register<object, StyleList<EasingFunction>>
	|-TypeConversion.Register<object, StyleList<StylePropertyName>>
	|-TypeConversion.Register<object, StyleList<TimeValue>>
	|-TypeConversion.Register<object, StyleBackground>
	|-TypeConversion.Register<object, StyleFont>
	|-TypeConversion.Register<object, StyleFontDefinition>
	|-TypeConversion.Register<Rotate, StyleRotate>
	|-TypeConversion.Register<Scale, StyleScale>
	|-TypeConversion.Register<float, StyleFloat>
	|-TypeConversion.Register<float, StyleLength>
	|-TypeConversion.Register<StyleBackground, Background>
	|-TypeConversion.Register<StyleBackground, Int32Enum>
	|-TypeConversion.Register<StyleBackground, object>
	|-TypeConversion.Register<StyleBackgroundPosition, BackgroundPosition>
	|-TypeConversion.Register<StyleBackgroundPosition, Int32Enum>
	|-TypeConversion.Register<StyleBackgroundRepeat, BackgroundRepeat>
	|-TypeConversion.Register<StyleBackgroundRepeat, Int32Enum>
	|-TypeConversion.Register<StyleBackgroundSize, BackgroundSize>
	|-TypeConversion.Register<StyleBackgroundSize, Int32Enum>
	|-TypeConversion.Register<StyleColor, Color>
	|-TypeConversion.Register<StyleColor, Color32>
	|-TypeConversion.Register<StyleColor, Int32Enum>
	|-TypeConversion.Register<StyleCursor, Cursor>
	|-TypeConversion.Register<StyleCursor, Int32Enum>
	|-TypeConversion.Register<StyleFloat, int>
	|-TypeConversion.Register<StyleFloat, Int32Enum>
	|-TypeConversion.Register<StyleFloat, float>
	|-TypeConversion.Register<StyleFont, Int32Enum>
	|-TypeConversion.Register<StyleFont, object>
	|-TypeConversion.Register<StyleFontDefinition, FontDefinition>
	|-TypeConversion.Register<StyleFontDefinition, Int32Enum>
	|-TypeConversion.Register<StyleFontDefinition, object>
	|-TypeConversion.Register<StyleInt, int>
	|-TypeConversion.Register<StyleInt, Int32Enum>
	|-TypeConversion.Register<StyleLength, int>
	|-TypeConversion.Register<StyleLength, Int32Enum>
	|-TypeConversion.Register<StyleLength, Length>
	|-TypeConversion.Register<StyleLength, float>
	|-TypeConversion.Register<StyleRotate, Int32Enum>
	|-TypeConversion.Register<StyleRotate, Rotate>
	|-TypeConversion.Register<StyleScale, Int32Enum>
	|-TypeConversion.Register<StyleScale, Scale>
	|-TypeConversion.Register<StyleTextShadow, Int32Enum>
	|-TypeConversion.Register<StyleTextShadow, TextShadow>
	|-TypeConversion.Register<StyleTransformOrigin, Int32Enum>
	|-TypeConversion.Register<StyleTransformOrigin, TransformOrigin>
	|-TypeConversion.Register<StyleTranslate, Int32Enum>
	|-TypeConversion.Register<StyleTranslate, Translate>
	|-TypeConversion.Register<TextShadow, StyleTextShadow>
	|-TypeConversion.Register<TransformOrigin, StyleTransformOrigin>
	|-TypeConversion.Register<Translate, StyleTranslate>
	|-TypeConversion.Register<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TDestination Convert<TSource, TDestination>(ref TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C64F0 Offset: 0x7C4AF0 VA: 0x1807C64F0
	|-TypeConversion.Convert<double, bool>
	|-TypeConversion.Convert<double, byte>
	|-TypeConversion.Convert<double, sbyte>
	|
	|-RVA: 0x7C6610 Offset: 0x7C4C10 VA: 0x1807C6610
	|-TypeConversion.Convert<double, short>
	|-TypeConversion.Convert<double, ushort>
	|
	|-RVA: 0x7C6730 Offset: 0x7C4D30 VA: 0x1807C6730
	|-TypeConversion.Convert<double, int>
	|-TypeConversion.Convert<double, uint>
	|
	|-RVA: 0x7C6850 Offset: 0x7C4E50 VA: 0x1807C6850
	|-TypeConversion.Convert<double, long>
	|-TypeConversion.Convert<double, ulong>
	|
	|-RVA: 0x7C6970 Offset: 0x7C4F70 VA: 0x1807C6970
	|-TypeConversion.Convert<double, float>
	|
	|-RVA: 0x7C6A90 Offset: 0x7C5090 VA: 0x1807C6A90
	|-TypeConversion.Convert<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryConvert<TSource, TDestination>(ref TSource source, out TDestination destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C6D70 Offset: 0x7C5370 VA: 0x1807C6D70
	|-TypeConversion.TryConvert<double, bool>
	|-TypeConversion.TryConvert<double, byte>
	|-TypeConversion.TryConvert<double, sbyte>
	|
	|-RVA: 0x7C8EA0 Offset: 0x7C74A0 VA: 0x1807C8EA0
	|-TypeConversion.TryConvert<double, short>
	|-TypeConversion.TryConvert<double, ushort>
	|
	|-RVA: 0x7C9A10 Offset: 0x7C8010 VA: 0x1807C9A10
	|-TypeConversion.TryConvert<double, int>
	|-TypeConversion.TryConvert<double, uint>
	|
	|-RVA: 0x7CA570 Offset: 0x7C8B70 VA: 0x1807CA570
	|-TypeConversion.TryConvert<double, long>
	|-TypeConversion.TryConvert<double, ulong>
	|
	|-RVA: 0x7CB0D0 Offset: 0x7C96D0 VA: 0x1807CB0D0
	|-TypeConversion.TryConvert<double, float>
	|
	|-RVA: 0x7CBC40 Offset: 0x7CA240 VA: 0x1807CBC40
	|-TypeConversion.TryConvert<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool TryConvertToUnityEngineObject<TSource, TDestination>(TSource source, out TDestination destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C78D0 Offset: 0x7C5ED0 VA: 0x1807C78D0
	|-TypeConversion.TryConvertToUnityEngineObject<double, bool>
	|-TypeConversion.TryConvertToUnityEngineObject<double, byte>
	|-TypeConversion.TryConvertToUnityEngineObject<double, sbyte>
	|
	|-RVA: 0x7C7CF0 Offset: 0x7C62F0 VA: 0x1807C7CF0
	|-TypeConversion.TryConvertToUnityEngineObject<double, short>
	|-TypeConversion.TryConvertToUnityEngineObject<double, ushort>
	|
	|-RVA: 0x7C8110 Offset: 0x7C6710 VA: 0x1807C8110
	|-TypeConversion.TryConvertToUnityEngineObject<double, int>
	|-TypeConversion.TryConvertToUnityEngineObject<double, float>
	|-TypeConversion.TryConvertToUnityEngineObject<double, uint>
	|
	|-RVA: 0x7C8530 Offset: 0x7C6B30 VA: 0x1807C8530
	|-TypeConversion.TryConvertToUnityEngineObject<double, long>
	|-TypeConversion.TryConvertToUnityEngineObject<double, ulong>
	|
	|-RVA: 0x7C8950 Offset: 0x7C6F50 VA: 0x1807C8950
	|-TypeConversion.TryConvertToUnityEngineObject<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23DABC0 Offset: 0x23D91C0 VA: 0x1823DABC0
	private static bool IsNumericType(Type t) { }
}

// Namespace: Unity.Properties
public static class TypeTraits // TypeDefIndex: 13000
{
	// Methods

	// RVA: 0x23DAD10 Offset: 0x23D9310 VA: 0x1823DAD10
	public static bool IsContainer(Type type) { }
}

// Namespace: Unity.Properties
public static class TypeTraits<T> // TypeDefIndex: 13001
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsValueType>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsPrimitive>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsInterface>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsAbstract>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsArray>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsMultidimensionalArray>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsEnum>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsEnumFlags>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsNullable>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsObject>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsString>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsContainer>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <CanBeNull>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsPrimitiveOrString>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsAbstractOrInterface>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsUnityObject>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsLazyLoadReference>k__BackingField; // 0x0

	// Properties
	public static bool IsValueType { get; }
	public static bool IsPrimitive { get; }
	public static bool IsInterface { get; }
	public static bool IsAbstract { get; }
	public static bool IsArray { get; }
	public static bool IsEnum { get; }
	public static bool IsNullable { get; }
	public static bool IsObject { get; }
	public static bool IsString { get; }
	public static bool IsContainer { get; }
	public static bool CanBeNull { get; }
	public static bool IsAbstractOrInterface { get; }
	public static bool IsUnityObject { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8EC00 Offset: 0xA8D200 VA: 0x180A8EC00
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsValueType
	|-TypeTraits<StyleList<EasingFunction>>.get_IsValueType
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsValueType
	|-TypeTraits<StyleList<TimeValue>>.get_IsValueType
	|-TypeTraits<Angle>.get_IsValueType
	|-TypeTraits<Background>.get_IsValueType
	|-TypeTraits<BackgroundPosition>.get_IsValueType
	|-TypeTraits<BackgroundRepeat>.get_IsValueType
	|-TypeTraits<BackgroundSize>.get_IsValueType
	|-TypeTraits<bool>.get_IsValueType
	|-TypeTraits<Bounds>.get_IsValueType
	|-TypeTraits<BoundsInt>.get_IsValueType
	|-TypeTraits<byte>.get_IsValueType
	|-TypeTraits<Color>.get_IsValueType
	|-TypeTraits<Cursor>.get_IsValueType
	|-TypeTraits<double>.get_IsValueType
	|-TypeTraits<EasingFunction>.get_IsValueType
	|-TypeTraits<FontDefinition>.get_IsValueType
	|-TypeTraits<short>.get_IsValueType
	|-TypeTraits<int>.get_IsValueType
	|-TypeTraits<Int32Enum>.get_IsValueType
	|-TypeTraits<long>.get_IsValueType
	|-TypeTraits<Length>.get_IsValueType
	|-TypeTraits<object>.get_IsValueType
	|-TypeTraits<Rect>.get_IsValueType
	|-TypeTraits<RectInt>.get_IsValueType
	|-TypeTraits<Rotate>.get_IsValueType
	|-TypeTraits<sbyte>.get_IsValueType
	|-TypeTraits<Scale>.get_IsValueType
	|-TypeTraits<float>.get_IsValueType
	|-TypeTraits<StyleBackground>.get_IsValueType
	|-TypeTraits<StyleBackgroundPosition>.get_IsValueType
	|-TypeTraits<StyleBackgroundRepeat>.get_IsValueType
	|-TypeTraits<StyleBackgroundSize>.get_IsValueType
	|-TypeTraits<StyleColor>.get_IsValueType
	|-TypeTraits<StyleCursor>.get_IsValueType
	|-TypeTraits<StyleFloat>.get_IsValueType
	|-TypeTraits<StyleFont>.get_IsValueType
	|-TypeTraits<StyleFontDefinition>.get_IsValueType
	|-TypeTraits<StyleInt>.get_IsValueType
	|-TypeTraits<StyleLength>.get_IsValueType
	|-TypeTraits<StylePropertyName>.get_IsValueType
	|-TypeTraits<StyleRotate>.get_IsValueType
	|-TypeTraits<StyleScale>.get_IsValueType
	|-TypeTraits<StyleTextShadow>.get_IsValueType
	|-TypeTraits<StyleTransformOrigin>.get_IsValueType
	|-TypeTraits<StyleTranslate>.get_IsValueType
	|-TypeTraits<TextShadow>.get_IsValueType
	|-TypeTraits<TimeValue>.get_IsValueType
	|-TypeTraits<TransformOrigin>.get_IsValueType
	|-TypeTraits<Translate>.get_IsValueType
	|-TypeTraits<ushort>.get_IsValueType
	|-TypeTraits<uint>.get_IsValueType
	|-TypeTraits<ulong>.get_IsValueType
	|-TypeTraits<Vector2>.get_IsValueType
	|-TypeTraits<Vector2Int>.get_IsValueType
	|-TypeTraits<Vector3>.get_IsValueType
	|-TypeTraits<Vector3Int>.get_IsValueType
	|-TypeTraits<Vector4>.get_IsValueType
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsValueType
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsPrimitive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8EA20 Offset: 0xA8D020 VA: 0x180A8EA20
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsPrimitive
	|-TypeTraits<StyleList<EasingFunction>>.get_IsPrimitive
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsPrimitive
	|-TypeTraits<StyleList<TimeValue>>.get_IsPrimitive
	|-TypeTraits<Angle>.get_IsPrimitive
	|-TypeTraits<Background>.get_IsPrimitive
	|-TypeTraits<BackgroundPosition>.get_IsPrimitive
	|-TypeTraits<BackgroundRepeat>.get_IsPrimitive
	|-TypeTraits<BackgroundSize>.get_IsPrimitive
	|-TypeTraits<bool>.get_IsPrimitive
	|-TypeTraits<Bounds>.get_IsPrimitive
	|-TypeTraits<BoundsInt>.get_IsPrimitive
	|-TypeTraits<byte>.get_IsPrimitive
	|-TypeTraits<Color>.get_IsPrimitive
	|-TypeTraits<Cursor>.get_IsPrimitive
	|-TypeTraits<double>.get_IsPrimitive
	|-TypeTraits<EasingFunction>.get_IsPrimitive
	|-TypeTraits<FontDefinition>.get_IsPrimitive
	|-TypeTraits<short>.get_IsPrimitive
	|-TypeTraits<int>.get_IsPrimitive
	|-TypeTraits<Int32Enum>.get_IsPrimitive
	|-TypeTraits<long>.get_IsPrimitive
	|-TypeTraits<Length>.get_IsPrimitive
	|-TypeTraits<object>.get_IsPrimitive
	|-TypeTraits<Rect>.get_IsPrimitive
	|-TypeTraits<RectInt>.get_IsPrimitive
	|-TypeTraits<Rotate>.get_IsPrimitive
	|-TypeTraits<sbyte>.get_IsPrimitive
	|-TypeTraits<Scale>.get_IsPrimitive
	|-TypeTraits<float>.get_IsPrimitive
	|-TypeTraits<StyleBackground>.get_IsPrimitive
	|-TypeTraits<StyleBackgroundPosition>.get_IsPrimitive
	|-TypeTraits<StyleBackgroundRepeat>.get_IsPrimitive
	|-TypeTraits<StyleBackgroundSize>.get_IsPrimitive
	|-TypeTraits<StyleColor>.get_IsPrimitive
	|-TypeTraits<StyleCursor>.get_IsPrimitive
	|-TypeTraits<StyleFloat>.get_IsPrimitive
	|-TypeTraits<StyleFont>.get_IsPrimitive
	|-TypeTraits<StyleFontDefinition>.get_IsPrimitive
	|-TypeTraits<StyleInt>.get_IsPrimitive
	|-TypeTraits<StyleLength>.get_IsPrimitive
	|-TypeTraits<StylePropertyName>.get_IsPrimitive
	|-TypeTraits<StyleRotate>.get_IsPrimitive
	|-TypeTraits<StyleScale>.get_IsPrimitive
	|-TypeTraits<StyleTextShadow>.get_IsPrimitive
	|-TypeTraits<StyleTransformOrigin>.get_IsPrimitive
	|-TypeTraits<StyleTranslate>.get_IsPrimitive
	|-TypeTraits<TextShadow>.get_IsPrimitive
	|-TypeTraits<TimeValue>.get_IsPrimitive
	|-TypeTraits<TransformOrigin>.get_IsPrimitive
	|-TypeTraits<Translate>.get_IsPrimitive
	|-TypeTraits<ushort>.get_IsPrimitive
	|-TypeTraits<uint>.get_IsPrimitive
	|-TypeTraits<ulong>.get_IsPrimitive
	|-TypeTraits<Vector2>.get_IsPrimitive
	|-TypeTraits<Vector2Int>.get_IsPrimitive
	|-TypeTraits<Vector3>.get_IsPrimitive
	|-TypeTraits<Vector3Int>.get_IsPrimitive
	|-TypeTraits<Vector4>.get_IsPrimitive
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsPrimitive
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsInterface() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8E840 Offset: 0xA8CE40 VA: 0x180A8E840
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsInterface
	|-TypeTraits<StyleList<EasingFunction>>.get_IsInterface
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsInterface
	|-TypeTraits<StyleList<TimeValue>>.get_IsInterface
	|-TypeTraits<Angle>.get_IsInterface
	|-TypeTraits<Background>.get_IsInterface
	|-TypeTraits<BackgroundPosition>.get_IsInterface
	|-TypeTraits<BackgroundRepeat>.get_IsInterface
	|-TypeTraits<BackgroundSize>.get_IsInterface
	|-TypeTraits<bool>.get_IsInterface
	|-TypeTraits<Bounds>.get_IsInterface
	|-TypeTraits<BoundsInt>.get_IsInterface
	|-TypeTraits<byte>.get_IsInterface
	|-TypeTraits<Color>.get_IsInterface
	|-TypeTraits<Cursor>.get_IsInterface
	|-TypeTraits<double>.get_IsInterface
	|-TypeTraits<EasingFunction>.get_IsInterface
	|-TypeTraits<FontDefinition>.get_IsInterface
	|-TypeTraits<short>.get_IsInterface
	|-TypeTraits<int>.get_IsInterface
	|-TypeTraits<Int32Enum>.get_IsInterface
	|-TypeTraits<long>.get_IsInterface
	|-TypeTraits<Length>.get_IsInterface
	|-TypeTraits<object>.get_IsInterface
	|-TypeTraits<Rect>.get_IsInterface
	|-TypeTraits<RectInt>.get_IsInterface
	|-TypeTraits<Rotate>.get_IsInterface
	|-TypeTraits<sbyte>.get_IsInterface
	|-TypeTraits<Scale>.get_IsInterface
	|-TypeTraits<float>.get_IsInterface
	|-TypeTraits<StyleBackground>.get_IsInterface
	|-TypeTraits<StyleBackgroundPosition>.get_IsInterface
	|-TypeTraits<StyleBackgroundRepeat>.get_IsInterface
	|-TypeTraits<StyleBackgroundSize>.get_IsInterface
	|-TypeTraits<StyleColor>.get_IsInterface
	|-TypeTraits<StyleCursor>.get_IsInterface
	|-TypeTraits<StyleFloat>.get_IsInterface
	|-TypeTraits<StyleFont>.get_IsInterface
	|-TypeTraits<StyleFontDefinition>.get_IsInterface
	|-TypeTraits<StyleInt>.get_IsInterface
	|-TypeTraits<StyleLength>.get_IsInterface
	|-TypeTraits<StylePropertyName>.get_IsInterface
	|-TypeTraits<StyleRotate>.get_IsInterface
	|-TypeTraits<StyleScale>.get_IsInterface
	|-TypeTraits<StyleTextShadow>.get_IsInterface
	|-TypeTraits<StyleTransformOrigin>.get_IsInterface
	|-TypeTraits<StyleTranslate>.get_IsInterface
	|-TypeTraits<TextShadow>.get_IsInterface
	|-TypeTraits<TimeValue>.get_IsInterface
	|-TypeTraits<TransformOrigin>.get_IsInterface
	|-TypeTraits<Translate>.get_IsInterface
	|-TypeTraits<ushort>.get_IsInterface
	|-TypeTraits<uint>.get_IsInterface
	|-TypeTraits<ulong>.get_IsInterface
	|-TypeTraits<Vector2>.get_IsInterface
	|-TypeTraits<Vector2Int>.get_IsInterface
	|-TypeTraits<Vector3>.get_IsInterface
	|-TypeTraits<Vector3Int>.get_IsInterface
	|-TypeTraits<Vector4>.get_IsInterface
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsInterface
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsAbstract() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8E5C0 Offset: 0xA8CBC0 VA: 0x180A8E5C0
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsAbstract
	|-TypeTraits<StyleList<EasingFunction>>.get_IsAbstract
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsAbstract
	|-TypeTraits<StyleList<TimeValue>>.get_IsAbstract
	|-TypeTraits<Angle>.get_IsAbstract
	|-TypeTraits<Background>.get_IsAbstract
	|-TypeTraits<BackgroundPosition>.get_IsAbstract
	|-TypeTraits<BackgroundRepeat>.get_IsAbstract
	|-TypeTraits<BackgroundSize>.get_IsAbstract
	|-TypeTraits<bool>.get_IsAbstract
	|-TypeTraits<Bounds>.get_IsAbstract
	|-TypeTraits<BoundsInt>.get_IsAbstract
	|-TypeTraits<byte>.get_IsAbstract
	|-TypeTraits<Color>.get_IsAbstract
	|-TypeTraits<Cursor>.get_IsAbstract
	|-TypeTraits<double>.get_IsAbstract
	|-TypeTraits<EasingFunction>.get_IsAbstract
	|-TypeTraits<FontDefinition>.get_IsAbstract
	|-TypeTraits<short>.get_IsAbstract
	|-TypeTraits<int>.get_IsAbstract
	|-TypeTraits<Int32Enum>.get_IsAbstract
	|-TypeTraits<long>.get_IsAbstract
	|-TypeTraits<Length>.get_IsAbstract
	|-TypeTraits<object>.get_IsAbstract
	|-TypeTraits<Rect>.get_IsAbstract
	|-TypeTraits<RectInt>.get_IsAbstract
	|-TypeTraits<Rotate>.get_IsAbstract
	|-TypeTraits<sbyte>.get_IsAbstract
	|-TypeTraits<Scale>.get_IsAbstract
	|-TypeTraits<float>.get_IsAbstract
	|-TypeTraits<StyleBackground>.get_IsAbstract
	|-TypeTraits<StyleBackgroundPosition>.get_IsAbstract
	|-TypeTraits<StyleBackgroundRepeat>.get_IsAbstract
	|-TypeTraits<StyleBackgroundSize>.get_IsAbstract
	|-TypeTraits<StyleColor>.get_IsAbstract
	|-TypeTraits<StyleCursor>.get_IsAbstract
	|-TypeTraits<StyleFloat>.get_IsAbstract
	|-TypeTraits<StyleFont>.get_IsAbstract
	|-TypeTraits<StyleFontDefinition>.get_IsAbstract
	|-TypeTraits<StyleInt>.get_IsAbstract
	|-TypeTraits<StyleLength>.get_IsAbstract
	|-TypeTraits<StylePropertyName>.get_IsAbstract
	|-TypeTraits<StyleRotate>.get_IsAbstract
	|-TypeTraits<StyleScale>.get_IsAbstract
	|-TypeTraits<StyleTextShadow>.get_IsAbstract
	|-TypeTraits<StyleTransformOrigin>.get_IsAbstract
	|-TypeTraits<StyleTranslate>.get_IsAbstract
	|-TypeTraits<TextShadow>.get_IsAbstract
	|-TypeTraits<TimeValue>.get_IsAbstract
	|-TypeTraits<TransformOrigin>.get_IsAbstract
	|-TypeTraits<Translate>.get_IsAbstract
	|-TypeTraits<ushort>.get_IsAbstract
	|-TypeTraits<uint>.get_IsAbstract
	|-TypeTraits<ulong>.get_IsAbstract
	|-TypeTraits<Vector2>.get_IsAbstract
	|-TypeTraits<Vector2Int>.get_IsAbstract
	|-TypeTraits<Vector3>.get_IsAbstract
	|-TypeTraits<Vector3Int>.get_IsAbstract
	|-TypeTraits<Vector4>.get_IsAbstract
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsAbstract
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8E660 Offset: 0xA8CC60 VA: 0x180A8E660
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsArray
	|-TypeTraits<StyleList<EasingFunction>>.get_IsArray
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsArray
	|-TypeTraits<StyleList<TimeValue>>.get_IsArray
	|-TypeTraits<Angle>.get_IsArray
	|-TypeTraits<Background>.get_IsArray
	|-TypeTraits<BackgroundPosition>.get_IsArray
	|-TypeTraits<BackgroundRepeat>.get_IsArray
	|-TypeTraits<BackgroundSize>.get_IsArray
	|-TypeTraits<bool>.get_IsArray
	|-TypeTraits<Bounds>.get_IsArray
	|-TypeTraits<BoundsInt>.get_IsArray
	|-TypeTraits<byte>.get_IsArray
	|-TypeTraits<Color>.get_IsArray
	|-TypeTraits<Cursor>.get_IsArray
	|-TypeTraits<double>.get_IsArray
	|-TypeTraits<EasingFunction>.get_IsArray
	|-TypeTraits<FontDefinition>.get_IsArray
	|-TypeTraits<short>.get_IsArray
	|-TypeTraits<int>.get_IsArray
	|-TypeTraits<Int32Enum>.get_IsArray
	|-TypeTraits<long>.get_IsArray
	|-TypeTraits<Length>.get_IsArray
	|-TypeTraits<object>.get_IsArray
	|-TypeTraits<Rect>.get_IsArray
	|-TypeTraits<RectInt>.get_IsArray
	|-TypeTraits<Rotate>.get_IsArray
	|-TypeTraits<sbyte>.get_IsArray
	|-TypeTraits<Scale>.get_IsArray
	|-TypeTraits<float>.get_IsArray
	|-TypeTraits<StyleBackground>.get_IsArray
	|-TypeTraits<StyleBackgroundPosition>.get_IsArray
	|-TypeTraits<StyleBackgroundRepeat>.get_IsArray
	|-TypeTraits<StyleBackgroundSize>.get_IsArray
	|-TypeTraits<StyleColor>.get_IsArray
	|-TypeTraits<StyleCursor>.get_IsArray
	|-TypeTraits<StyleFloat>.get_IsArray
	|-TypeTraits<StyleFont>.get_IsArray
	|-TypeTraits<StyleFontDefinition>.get_IsArray
	|-TypeTraits<StyleInt>.get_IsArray
	|-TypeTraits<StyleLength>.get_IsArray
	|-TypeTraits<StylePropertyName>.get_IsArray
	|-TypeTraits<StyleRotate>.get_IsArray
	|-TypeTraits<StyleScale>.get_IsArray
	|-TypeTraits<StyleTextShadow>.get_IsArray
	|-TypeTraits<StyleTransformOrigin>.get_IsArray
	|-TypeTraits<StyleTranslate>.get_IsArray
	|-TypeTraits<TextShadow>.get_IsArray
	|-TypeTraits<TimeValue>.get_IsArray
	|-TypeTraits<TransformOrigin>.get_IsArray
	|-TypeTraits<Translate>.get_IsArray
	|-TypeTraits<ushort>.get_IsArray
	|-TypeTraits<uint>.get_IsArray
	|-TypeTraits<ulong>.get_IsArray
	|-TypeTraits<Vector2>.get_IsArray
	|-TypeTraits<Vector2Int>.get_IsArray
	|-TypeTraits<Vector3>.get_IsArray
	|-TypeTraits<Vector3Int>.get_IsArray
	|-TypeTraits<Vector4>.get_IsArray
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsArray
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsEnum() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8E7A0 Offset: 0xA8CDA0 VA: 0x180A8E7A0
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsEnum
	|-TypeTraits<StyleList<EasingFunction>>.get_IsEnum
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsEnum
	|-TypeTraits<StyleList<TimeValue>>.get_IsEnum
	|-TypeTraits<Angle>.get_IsEnum
	|-TypeTraits<Background>.get_IsEnum
	|-TypeTraits<BackgroundPosition>.get_IsEnum
	|-TypeTraits<BackgroundRepeat>.get_IsEnum
	|-TypeTraits<BackgroundSize>.get_IsEnum
	|-TypeTraits<bool>.get_IsEnum
	|-TypeTraits<Bounds>.get_IsEnum
	|-TypeTraits<BoundsInt>.get_IsEnum
	|-TypeTraits<byte>.get_IsEnum
	|-TypeTraits<Color>.get_IsEnum
	|-TypeTraits<Cursor>.get_IsEnum
	|-TypeTraits<double>.get_IsEnum
	|-TypeTraits<EasingFunction>.get_IsEnum
	|-TypeTraits<FontDefinition>.get_IsEnum
	|-TypeTraits<short>.get_IsEnum
	|-TypeTraits<int>.get_IsEnum
	|-TypeTraits<Int32Enum>.get_IsEnum
	|-TypeTraits<long>.get_IsEnum
	|-TypeTraits<Length>.get_IsEnum
	|-TypeTraits<object>.get_IsEnum
	|-TypeTraits<Rect>.get_IsEnum
	|-TypeTraits<RectInt>.get_IsEnum
	|-TypeTraits<Rotate>.get_IsEnum
	|-TypeTraits<sbyte>.get_IsEnum
	|-TypeTraits<Scale>.get_IsEnum
	|-TypeTraits<float>.get_IsEnum
	|-TypeTraits<StyleBackground>.get_IsEnum
	|-TypeTraits<StyleBackgroundPosition>.get_IsEnum
	|-TypeTraits<StyleBackgroundRepeat>.get_IsEnum
	|-TypeTraits<StyleBackgroundSize>.get_IsEnum
	|-TypeTraits<StyleColor>.get_IsEnum
	|-TypeTraits<StyleCursor>.get_IsEnum
	|-TypeTraits<StyleFloat>.get_IsEnum
	|-TypeTraits<StyleFont>.get_IsEnum
	|-TypeTraits<StyleFontDefinition>.get_IsEnum
	|-TypeTraits<StyleInt>.get_IsEnum
	|-TypeTraits<StyleLength>.get_IsEnum
	|-TypeTraits<StylePropertyName>.get_IsEnum
	|-TypeTraits<StyleRotate>.get_IsEnum
	|-TypeTraits<StyleScale>.get_IsEnum
	|-TypeTraits<StyleTextShadow>.get_IsEnum
	|-TypeTraits<StyleTransformOrigin>.get_IsEnum
	|-TypeTraits<StyleTranslate>.get_IsEnum
	|-TypeTraits<TextShadow>.get_IsEnum
	|-TypeTraits<TimeValue>.get_IsEnum
	|-TypeTraits<TransformOrigin>.get_IsEnum
	|-TypeTraits<Translate>.get_IsEnum
	|-TypeTraits<ushort>.get_IsEnum
	|-TypeTraits<uint>.get_IsEnum
	|-TypeTraits<ulong>.get_IsEnum
	|-TypeTraits<Vector2>.get_IsEnum
	|-TypeTraits<Vector2Int>.get_IsEnum
	|-TypeTraits<Vector3>.get_IsEnum
	|-TypeTraits<Vector3Int>.get_IsEnum
	|-TypeTraits<Vector4>.get_IsEnum
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsEnum
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsNullable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8E8E0 Offset: 0xA8CEE0 VA: 0x180A8E8E0
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsNullable
	|-TypeTraits<StyleList<EasingFunction>>.get_IsNullable
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsNullable
	|-TypeTraits<StyleList<TimeValue>>.get_IsNullable
	|-TypeTraits<Angle>.get_IsNullable
	|-TypeTraits<Background>.get_IsNullable
	|-TypeTraits<BackgroundPosition>.get_IsNullable
	|-TypeTraits<BackgroundRepeat>.get_IsNullable
	|-TypeTraits<BackgroundSize>.get_IsNullable
	|-TypeTraits<bool>.get_IsNullable
	|-TypeTraits<Bounds>.get_IsNullable
	|-TypeTraits<BoundsInt>.get_IsNullable
	|-TypeTraits<byte>.get_IsNullable
	|-TypeTraits<Color>.get_IsNullable
	|-TypeTraits<Cursor>.get_IsNullable
	|-TypeTraits<double>.get_IsNullable
	|-TypeTraits<EasingFunction>.get_IsNullable
	|-TypeTraits<FontDefinition>.get_IsNullable
	|-TypeTraits<short>.get_IsNullable
	|-TypeTraits<int>.get_IsNullable
	|-TypeTraits<Int32Enum>.get_IsNullable
	|-TypeTraits<long>.get_IsNullable
	|-TypeTraits<Length>.get_IsNullable
	|-TypeTraits<object>.get_IsNullable
	|-TypeTraits<Rect>.get_IsNullable
	|-TypeTraits<RectInt>.get_IsNullable
	|-TypeTraits<Rotate>.get_IsNullable
	|-TypeTraits<sbyte>.get_IsNullable
	|-TypeTraits<Scale>.get_IsNullable
	|-TypeTraits<float>.get_IsNullable
	|-TypeTraits<StyleBackground>.get_IsNullable
	|-TypeTraits<StyleBackgroundPosition>.get_IsNullable
	|-TypeTraits<StyleBackgroundRepeat>.get_IsNullable
	|-TypeTraits<StyleBackgroundSize>.get_IsNullable
	|-TypeTraits<StyleColor>.get_IsNullable
	|-TypeTraits<StyleCursor>.get_IsNullable
	|-TypeTraits<StyleFloat>.get_IsNullable
	|-TypeTraits<StyleFont>.get_IsNullable
	|-TypeTraits<StyleFontDefinition>.get_IsNullable
	|-TypeTraits<StyleInt>.get_IsNullable
	|-TypeTraits<StyleLength>.get_IsNullable
	|-TypeTraits<StylePropertyName>.get_IsNullable
	|-TypeTraits<StyleRotate>.get_IsNullable
	|-TypeTraits<StyleScale>.get_IsNullable
	|-TypeTraits<StyleTextShadow>.get_IsNullable
	|-TypeTraits<StyleTransformOrigin>.get_IsNullable
	|-TypeTraits<StyleTranslate>.get_IsNullable
	|-TypeTraits<TextShadow>.get_IsNullable
	|-TypeTraits<TimeValue>.get_IsNullable
	|-TypeTraits<TransformOrigin>.get_IsNullable
	|-TypeTraits<Translate>.get_IsNullable
	|-TypeTraits<ushort>.get_IsNullable
	|-TypeTraits<uint>.get_IsNullable
	|-TypeTraits<ulong>.get_IsNullable
	|-TypeTraits<Vector2>.get_IsNullable
	|-TypeTraits<Vector2Int>.get_IsNullable
	|-TypeTraits<Vector3>.get_IsNullable
	|-TypeTraits<Vector3Int>.get_IsNullable
	|-TypeTraits<Vector4>.get_IsNullable
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsNullable
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8E980 Offset: 0xA8CF80 VA: 0x180A8E980
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsObject
	|-TypeTraits<StyleList<EasingFunction>>.get_IsObject
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsObject
	|-TypeTraits<StyleList<TimeValue>>.get_IsObject
	|-TypeTraits<Angle>.get_IsObject
	|-TypeTraits<Background>.get_IsObject
	|-TypeTraits<BackgroundPosition>.get_IsObject
	|-TypeTraits<BackgroundRepeat>.get_IsObject
	|-TypeTraits<BackgroundSize>.get_IsObject
	|-TypeTraits<bool>.get_IsObject
	|-TypeTraits<Bounds>.get_IsObject
	|-TypeTraits<BoundsInt>.get_IsObject
	|-TypeTraits<byte>.get_IsObject
	|-TypeTraits<Color>.get_IsObject
	|-TypeTraits<Cursor>.get_IsObject
	|-TypeTraits<double>.get_IsObject
	|-TypeTraits<EasingFunction>.get_IsObject
	|-TypeTraits<FontDefinition>.get_IsObject
	|-TypeTraits<short>.get_IsObject
	|-TypeTraits<int>.get_IsObject
	|-TypeTraits<Int32Enum>.get_IsObject
	|-TypeTraits<long>.get_IsObject
	|-TypeTraits<Length>.get_IsObject
	|-TypeTraits<object>.get_IsObject
	|-TypeTraits<Rect>.get_IsObject
	|-TypeTraits<RectInt>.get_IsObject
	|-TypeTraits<Rotate>.get_IsObject
	|-TypeTraits<sbyte>.get_IsObject
	|-TypeTraits<Scale>.get_IsObject
	|-TypeTraits<float>.get_IsObject
	|-TypeTraits<StyleBackground>.get_IsObject
	|-TypeTraits<StyleBackgroundPosition>.get_IsObject
	|-TypeTraits<StyleBackgroundRepeat>.get_IsObject
	|-TypeTraits<StyleBackgroundSize>.get_IsObject
	|-TypeTraits<StyleColor>.get_IsObject
	|-TypeTraits<StyleCursor>.get_IsObject
	|-TypeTraits<StyleFloat>.get_IsObject
	|-TypeTraits<StyleFont>.get_IsObject
	|-TypeTraits<StyleFontDefinition>.get_IsObject
	|-TypeTraits<StyleInt>.get_IsObject
	|-TypeTraits<StyleLength>.get_IsObject
	|-TypeTraits<StylePropertyName>.get_IsObject
	|-TypeTraits<StyleRotate>.get_IsObject
	|-TypeTraits<StyleScale>.get_IsObject
	|-TypeTraits<StyleTextShadow>.get_IsObject
	|-TypeTraits<StyleTransformOrigin>.get_IsObject
	|-TypeTraits<StyleTranslate>.get_IsObject
	|-TypeTraits<TextShadow>.get_IsObject
	|-TypeTraits<TimeValue>.get_IsObject
	|-TypeTraits<TransformOrigin>.get_IsObject
	|-TypeTraits<Translate>.get_IsObject
	|-TypeTraits<ushort>.get_IsObject
	|-TypeTraits<uint>.get_IsObject
	|-TypeTraits<ulong>.get_IsObject
	|-TypeTraits<Vector2>.get_IsObject
	|-TypeTraits<Vector2Int>.get_IsObject
	|-TypeTraits<Vector3>.get_IsObject
	|-TypeTraits<Vector3Int>.get_IsObject
	|-TypeTraits<Vector4>.get_IsObject
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsObject
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8EAC0 Offset: 0xA8D0C0 VA: 0x180A8EAC0
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsString
	|-TypeTraits<StyleList<EasingFunction>>.get_IsString
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsString
	|-TypeTraits<StyleList<TimeValue>>.get_IsString
	|-TypeTraits<Angle>.get_IsString
	|-TypeTraits<Background>.get_IsString
	|-TypeTraits<BackgroundPosition>.get_IsString
	|-TypeTraits<BackgroundRepeat>.get_IsString
	|-TypeTraits<BackgroundSize>.get_IsString
	|-TypeTraits<bool>.get_IsString
	|-TypeTraits<Bounds>.get_IsString
	|-TypeTraits<BoundsInt>.get_IsString
	|-TypeTraits<byte>.get_IsString
	|-TypeTraits<Color>.get_IsString
	|-TypeTraits<Cursor>.get_IsString
	|-TypeTraits<double>.get_IsString
	|-TypeTraits<EasingFunction>.get_IsString
	|-TypeTraits<FontDefinition>.get_IsString
	|-TypeTraits<short>.get_IsString
	|-TypeTraits<int>.get_IsString
	|-TypeTraits<Int32Enum>.get_IsString
	|-TypeTraits<long>.get_IsString
	|-TypeTraits<Length>.get_IsString
	|-TypeTraits<object>.get_IsString
	|-TypeTraits<Rect>.get_IsString
	|-TypeTraits<RectInt>.get_IsString
	|-TypeTraits<Rotate>.get_IsString
	|-TypeTraits<sbyte>.get_IsString
	|-TypeTraits<Scale>.get_IsString
	|-TypeTraits<float>.get_IsString
	|-TypeTraits<StyleBackground>.get_IsString
	|-TypeTraits<StyleBackgroundPosition>.get_IsString
	|-TypeTraits<StyleBackgroundRepeat>.get_IsString
	|-TypeTraits<StyleBackgroundSize>.get_IsString
	|-TypeTraits<StyleColor>.get_IsString
	|-TypeTraits<StyleCursor>.get_IsString
	|-TypeTraits<StyleFloat>.get_IsString
	|-TypeTraits<StyleFont>.get_IsString
	|-TypeTraits<StyleFontDefinition>.get_IsString
	|-TypeTraits<StyleInt>.get_IsString
	|-TypeTraits<StyleLength>.get_IsString
	|-TypeTraits<StylePropertyName>.get_IsString
	|-TypeTraits<StyleRotate>.get_IsString
	|-TypeTraits<StyleScale>.get_IsString
	|-TypeTraits<StyleTextShadow>.get_IsString
	|-TypeTraits<StyleTransformOrigin>.get_IsString
	|-TypeTraits<StyleTranslate>.get_IsString
	|-TypeTraits<TextShadow>.get_IsString
	|-TypeTraits<TimeValue>.get_IsString
	|-TypeTraits<TransformOrigin>.get_IsString
	|-TypeTraits<Translate>.get_IsString
	|-TypeTraits<ushort>.get_IsString
	|-TypeTraits<uint>.get_IsString
	|-TypeTraits<ulong>.get_IsString
	|-TypeTraits<Vector2>.get_IsString
	|-TypeTraits<Vector2Int>.get_IsString
	|-TypeTraits<Vector3>.get_IsString
	|-TypeTraits<Vector3Int>.get_IsString
	|-TypeTraits<Vector4>.get_IsString
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsString
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsContainer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8E700 Offset: 0xA8CD00 VA: 0x180A8E700
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsContainer
	|-TypeTraits<StyleList<EasingFunction>>.get_IsContainer
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsContainer
	|-TypeTraits<StyleList<TimeValue>>.get_IsContainer
	|-TypeTraits<Angle>.get_IsContainer
	|-TypeTraits<Background>.get_IsContainer
	|-TypeTraits<BackgroundPosition>.get_IsContainer
	|-TypeTraits<BackgroundRepeat>.get_IsContainer
	|-TypeTraits<BackgroundSize>.get_IsContainer
	|-TypeTraits<bool>.get_IsContainer
	|-TypeTraits<Bounds>.get_IsContainer
	|-TypeTraits<BoundsInt>.get_IsContainer
	|-TypeTraits<byte>.get_IsContainer
	|-TypeTraits<Color>.get_IsContainer
	|-TypeTraits<Cursor>.get_IsContainer
	|-TypeTraits<double>.get_IsContainer
	|-TypeTraits<EasingFunction>.get_IsContainer
	|-TypeTraits<FontDefinition>.get_IsContainer
	|-TypeTraits<short>.get_IsContainer
	|-TypeTraits<int>.get_IsContainer
	|-TypeTraits<Int32Enum>.get_IsContainer
	|-TypeTraits<long>.get_IsContainer
	|-TypeTraits<Length>.get_IsContainer
	|-TypeTraits<object>.get_IsContainer
	|-TypeTraits<Rect>.get_IsContainer
	|-TypeTraits<RectInt>.get_IsContainer
	|-TypeTraits<Rotate>.get_IsContainer
	|-TypeTraits<sbyte>.get_IsContainer
	|-TypeTraits<Scale>.get_IsContainer
	|-TypeTraits<float>.get_IsContainer
	|-TypeTraits<StyleBackground>.get_IsContainer
	|-TypeTraits<StyleBackgroundPosition>.get_IsContainer
	|-TypeTraits<StyleBackgroundRepeat>.get_IsContainer
	|-TypeTraits<StyleBackgroundSize>.get_IsContainer
	|-TypeTraits<StyleColor>.get_IsContainer
	|-TypeTraits<StyleCursor>.get_IsContainer
	|-TypeTraits<StyleFloat>.get_IsContainer
	|-TypeTraits<StyleFont>.get_IsContainer
	|-TypeTraits<StyleFontDefinition>.get_IsContainer
	|-TypeTraits<StyleInt>.get_IsContainer
	|-TypeTraits<StyleLength>.get_IsContainer
	|-TypeTraits<StylePropertyName>.get_IsContainer
	|-TypeTraits<StyleRotate>.get_IsContainer
	|-TypeTraits<StyleScale>.get_IsContainer
	|-TypeTraits<StyleTextShadow>.get_IsContainer
	|-TypeTraits<StyleTransformOrigin>.get_IsContainer
	|-TypeTraits<StyleTranslate>.get_IsContainer
	|-TypeTraits<TextShadow>.get_IsContainer
	|-TypeTraits<TimeValue>.get_IsContainer
	|-TypeTraits<TransformOrigin>.get_IsContainer
	|-TypeTraits<Translate>.get_IsContainer
	|-TypeTraits<ushort>.get_IsContainer
	|-TypeTraits<uint>.get_IsContainer
	|-TypeTraits<ulong>.get_IsContainer
	|-TypeTraits<Vector2>.get_IsContainer
	|-TypeTraits<Vector2Int>.get_IsContainer
	|-TypeTraits<Vector3>.get_IsContainer
	|-TypeTraits<Vector3Int>.get_IsContainer
	|-TypeTraits<Vector4>.get_IsContainer
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsContainer
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_CanBeNull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8E480 Offset: 0xA8CA80 VA: 0x180A8E480
	|-TypeTraits<StyleEnum<Int32Enum>>.get_CanBeNull
	|-TypeTraits<StyleList<EasingFunction>>.get_CanBeNull
	|-TypeTraits<StyleList<StylePropertyName>>.get_CanBeNull
	|-TypeTraits<StyleList<TimeValue>>.get_CanBeNull
	|-TypeTraits<Angle>.get_CanBeNull
	|-TypeTraits<Background>.get_CanBeNull
	|-TypeTraits<BackgroundPosition>.get_CanBeNull
	|-TypeTraits<BackgroundRepeat>.get_CanBeNull
	|-TypeTraits<BackgroundSize>.get_CanBeNull
	|-TypeTraits<bool>.get_CanBeNull
	|-TypeTraits<Bounds>.get_CanBeNull
	|-TypeTraits<BoundsInt>.get_CanBeNull
	|-TypeTraits<byte>.get_CanBeNull
	|-TypeTraits<Color>.get_CanBeNull
	|-TypeTraits<Cursor>.get_CanBeNull
	|-TypeTraits<double>.get_CanBeNull
	|-TypeTraits<EasingFunction>.get_CanBeNull
	|-TypeTraits<FontDefinition>.get_CanBeNull
	|-TypeTraits<short>.get_CanBeNull
	|-TypeTraits<int>.get_CanBeNull
	|-TypeTraits<Int32Enum>.get_CanBeNull
	|-TypeTraits<long>.get_CanBeNull
	|-TypeTraits<Length>.get_CanBeNull
	|-TypeTraits<object>.get_CanBeNull
	|-TypeTraits<Rect>.get_CanBeNull
	|-TypeTraits<RectInt>.get_CanBeNull
	|-TypeTraits<Rotate>.get_CanBeNull
	|-TypeTraits<sbyte>.get_CanBeNull
	|-TypeTraits<Scale>.get_CanBeNull
	|-TypeTraits<float>.get_CanBeNull
	|-TypeTraits<StyleBackground>.get_CanBeNull
	|-TypeTraits<StyleBackgroundPosition>.get_CanBeNull
	|-TypeTraits<StyleBackgroundRepeat>.get_CanBeNull
	|-TypeTraits<StyleBackgroundSize>.get_CanBeNull
	|-TypeTraits<StyleColor>.get_CanBeNull
	|-TypeTraits<StyleCursor>.get_CanBeNull
	|-TypeTraits<StyleFloat>.get_CanBeNull
	|-TypeTraits<StyleFont>.get_CanBeNull
	|-TypeTraits<StyleFontDefinition>.get_CanBeNull
	|-TypeTraits<StyleInt>.get_CanBeNull
	|-TypeTraits<StyleLength>.get_CanBeNull
	|-TypeTraits<StylePropertyName>.get_CanBeNull
	|-TypeTraits<StyleRotate>.get_CanBeNull
	|-TypeTraits<StyleScale>.get_CanBeNull
	|-TypeTraits<StyleTextShadow>.get_CanBeNull
	|-TypeTraits<StyleTransformOrigin>.get_CanBeNull
	|-TypeTraits<StyleTranslate>.get_CanBeNull
	|-TypeTraits<TextShadow>.get_CanBeNull
	|-TypeTraits<TimeValue>.get_CanBeNull
	|-TypeTraits<TransformOrigin>.get_CanBeNull
	|-TypeTraits<Translate>.get_CanBeNull
	|-TypeTraits<ushort>.get_CanBeNull
	|-TypeTraits<uint>.get_CanBeNull
	|-TypeTraits<ulong>.get_CanBeNull
	|-TypeTraits<Vector2>.get_CanBeNull
	|-TypeTraits<Vector2Int>.get_CanBeNull
	|-TypeTraits<Vector3>.get_CanBeNull
	|-TypeTraits<Vector3Int>.get_CanBeNull
	|-TypeTraits<Vector4>.get_CanBeNull
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_CanBeNull
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsAbstractOrInterface() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8E520 Offset: 0xA8CB20 VA: 0x180A8E520
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsAbstractOrInterface
	|-TypeTraits<StyleList<EasingFunction>>.get_IsAbstractOrInterface
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsAbstractOrInterface
	|-TypeTraits<StyleList<TimeValue>>.get_IsAbstractOrInterface
	|-TypeTraits<Angle>.get_IsAbstractOrInterface
	|-TypeTraits<Background>.get_IsAbstractOrInterface
	|-TypeTraits<BackgroundPosition>.get_IsAbstractOrInterface
	|-TypeTraits<BackgroundRepeat>.get_IsAbstractOrInterface
	|-TypeTraits<BackgroundSize>.get_IsAbstractOrInterface
	|-TypeTraits<bool>.get_IsAbstractOrInterface
	|-TypeTraits<Bounds>.get_IsAbstractOrInterface
	|-TypeTraits<BoundsInt>.get_IsAbstractOrInterface
	|-TypeTraits<byte>.get_IsAbstractOrInterface
	|-TypeTraits<Color>.get_IsAbstractOrInterface
	|-TypeTraits<Cursor>.get_IsAbstractOrInterface
	|-TypeTraits<double>.get_IsAbstractOrInterface
	|-TypeTraits<EasingFunction>.get_IsAbstractOrInterface
	|-TypeTraits<FontDefinition>.get_IsAbstractOrInterface
	|-TypeTraits<short>.get_IsAbstractOrInterface
	|-TypeTraits<int>.get_IsAbstractOrInterface
	|-TypeTraits<Int32Enum>.get_IsAbstractOrInterface
	|-TypeTraits<long>.get_IsAbstractOrInterface
	|-TypeTraits<Length>.get_IsAbstractOrInterface
	|-TypeTraits<object>.get_IsAbstractOrInterface
	|-TypeTraits<Rect>.get_IsAbstractOrInterface
	|-TypeTraits<RectInt>.get_IsAbstractOrInterface
	|-TypeTraits<Rotate>.get_IsAbstractOrInterface
	|-TypeTraits<sbyte>.get_IsAbstractOrInterface
	|-TypeTraits<Scale>.get_IsAbstractOrInterface
	|-TypeTraits<float>.get_IsAbstractOrInterface
	|-TypeTraits<StyleBackground>.get_IsAbstractOrInterface
	|-TypeTraits<StyleBackgroundPosition>.get_IsAbstractOrInterface
	|-TypeTraits<StyleBackgroundRepeat>.get_IsAbstractOrInterface
	|-TypeTraits<StyleBackgroundSize>.get_IsAbstractOrInterface
	|-TypeTraits<StyleColor>.get_IsAbstractOrInterface
	|-TypeTraits<StyleCursor>.get_IsAbstractOrInterface
	|-TypeTraits<StyleFloat>.get_IsAbstractOrInterface
	|-TypeTraits<StyleFont>.get_IsAbstractOrInterface
	|-TypeTraits<StyleFontDefinition>.get_IsAbstractOrInterface
	|-TypeTraits<StyleInt>.get_IsAbstractOrInterface
	|-TypeTraits<StyleLength>.get_IsAbstractOrInterface
	|-TypeTraits<StylePropertyName>.get_IsAbstractOrInterface
	|-TypeTraits<StyleRotate>.get_IsAbstractOrInterface
	|-TypeTraits<StyleScale>.get_IsAbstractOrInterface
	|-TypeTraits<StyleTextShadow>.get_IsAbstractOrInterface
	|-TypeTraits<StyleTransformOrigin>.get_IsAbstractOrInterface
	|-TypeTraits<StyleTranslate>.get_IsAbstractOrInterface
	|-TypeTraits<TextShadow>.get_IsAbstractOrInterface
	|-TypeTraits<TimeValue>.get_IsAbstractOrInterface
	|-TypeTraits<TransformOrigin>.get_IsAbstractOrInterface
	|-TypeTraits<Translate>.get_IsAbstractOrInterface
	|-TypeTraits<ushort>.get_IsAbstractOrInterface
	|-TypeTraits<uint>.get_IsAbstractOrInterface
	|-TypeTraits<ulong>.get_IsAbstractOrInterface
	|-TypeTraits<Vector2>.get_IsAbstractOrInterface
	|-TypeTraits<Vector2Int>.get_IsAbstractOrInterface
	|-TypeTraits<Vector3>.get_IsAbstractOrInterface
	|-TypeTraits<Vector3Int>.get_IsAbstractOrInterface
	|-TypeTraits<Vector4>.get_IsAbstractOrInterface
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsAbstractOrInterface
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsUnityObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8EB60 Offset: 0xA8D160 VA: 0x180A8EB60
	|-TypeTraits<StyleEnum<Int32Enum>>.get_IsUnityObject
	|-TypeTraits<StyleList<EasingFunction>>.get_IsUnityObject
	|-TypeTraits<StyleList<StylePropertyName>>.get_IsUnityObject
	|-TypeTraits<StyleList<TimeValue>>.get_IsUnityObject
	|-TypeTraits<Angle>.get_IsUnityObject
	|-TypeTraits<Background>.get_IsUnityObject
	|-TypeTraits<BackgroundPosition>.get_IsUnityObject
	|-TypeTraits<BackgroundRepeat>.get_IsUnityObject
	|-TypeTraits<BackgroundSize>.get_IsUnityObject
	|-TypeTraits<bool>.get_IsUnityObject
	|-TypeTraits<Bounds>.get_IsUnityObject
	|-TypeTraits<BoundsInt>.get_IsUnityObject
	|-TypeTraits<byte>.get_IsUnityObject
	|-TypeTraits<Color>.get_IsUnityObject
	|-TypeTraits<Cursor>.get_IsUnityObject
	|-TypeTraits<double>.get_IsUnityObject
	|-TypeTraits<EasingFunction>.get_IsUnityObject
	|-TypeTraits<FontDefinition>.get_IsUnityObject
	|-TypeTraits<short>.get_IsUnityObject
	|-TypeTraits<int>.get_IsUnityObject
	|-TypeTraits<Int32Enum>.get_IsUnityObject
	|-TypeTraits<long>.get_IsUnityObject
	|-TypeTraits<Length>.get_IsUnityObject
	|-TypeTraits<object>.get_IsUnityObject
	|-TypeTraits<Rect>.get_IsUnityObject
	|-TypeTraits<RectInt>.get_IsUnityObject
	|-TypeTraits<Rotate>.get_IsUnityObject
	|-TypeTraits<sbyte>.get_IsUnityObject
	|-TypeTraits<Scale>.get_IsUnityObject
	|-TypeTraits<float>.get_IsUnityObject
	|-TypeTraits<StyleBackground>.get_IsUnityObject
	|-TypeTraits<StyleBackgroundPosition>.get_IsUnityObject
	|-TypeTraits<StyleBackgroundRepeat>.get_IsUnityObject
	|-TypeTraits<StyleBackgroundSize>.get_IsUnityObject
	|-TypeTraits<StyleColor>.get_IsUnityObject
	|-TypeTraits<StyleCursor>.get_IsUnityObject
	|-TypeTraits<StyleFloat>.get_IsUnityObject
	|-TypeTraits<StyleFont>.get_IsUnityObject
	|-TypeTraits<StyleFontDefinition>.get_IsUnityObject
	|-TypeTraits<StyleInt>.get_IsUnityObject
	|-TypeTraits<StyleLength>.get_IsUnityObject
	|-TypeTraits<StylePropertyName>.get_IsUnityObject
	|-TypeTraits<StyleRotate>.get_IsUnityObject
	|-TypeTraits<StyleScale>.get_IsUnityObject
	|-TypeTraits<StyleTextShadow>.get_IsUnityObject
	|-TypeTraits<StyleTransformOrigin>.get_IsUnityObject
	|-TypeTraits<StyleTranslate>.get_IsUnityObject
	|-TypeTraits<TextShadow>.get_IsUnityObject
	|-TypeTraits<TimeValue>.get_IsUnityObject
	|-TypeTraits<TransformOrigin>.get_IsUnityObject
	|-TypeTraits<Translate>.get_IsUnityObject
	|-TypeTraits<ushort>.get_IsUnityObject
	|-TypeTraits<uint>.get_IsUnityObject
	|-TypeTraits<ulong>.get_IsUnityObject
	|-TypeTraits<Vector2>.get_IsUnityObject
	|-TypeTraits<Vector2Int>.get_IsUnityObject
	|-TypeTraits<Vector3>.get_IsUnityObject
	|-TypeTraits<Vector3Int>.get_IsUnityObject
	|-TypeTraits<Vector4>.get_IsUnityObject
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsUnityObject
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA8A3D0 Offset: 0xA889D0 VA: 0x180A8A3D0
	|-TypeTraits<StyleEnum<Int32Enum>>..cctor
	|
	|-RVA: 0xA86320 Offset: 0xA84920 VA: 0x180A86320
	|-TypeTraits<StyleList<EasingFunction>>..cctor
	|
	|-RVA: 0xA8BDB0 Offset: 0xA8A3B0 VA: 0x180A8BDB0
	|-TypeTraits<StyleList<StylePropertyName>>..cctor
	|
	|-RVA: 0xA87010 Offset: 0xA85610 VA: 0x180A87010
	|-TypeTraits<StyleList<TimeValue>>..cctor
	|
	|-RVA: 0xA896E0 Offset: 0xA87CE0 VA: 0x180A896E0
	|-TypeTraits<Angle>..cctor
	|
	|-RVA: 0xA85630 Offset: 0xA83C30 VA: 0x180A85630
	|-TypeTraits<Background>..cctor
	|
	|-RVA: 0xA889F0 Offset: 0xA86FF0 VA: 0x180A889F0
	|-TypeTraits<BackgroundPosition>..cctor
	|
	|-RVA: 0xA83C50 Offset: 0xA82250 VA: 0x180A83C50
	|-TypeTraits<BackgroundRepeat>..cctor
	|
	|-RVA: 0xA8D790 Offset: 0xA8BD90 VA: 0x180A8D790
	|-TypeTraits<BackgroundSize>..cctor
	|
	|-RVA: 0xA84940 Offset: 0xA82F40 VA: 0x180A84940
	|-TypeTraits<bool>..cctor
	|
	|-RVA: 0xA8CAA0 Offset: 0xA8B0A0 VA: 0x180A8CAA0
	|-TypeTraits<Bounds>..cctor
	|
	|-RVA: 0xA82F60 Offset: 0xA81560 VA: 0x180A82F60
	|-TypeTraits<BoundsInt>..cctor
	|
	|-RVA: 0xA8B0C0 Offset: 0xA896C0 VA: 0x180A8B0C0
	|-TypeTraits<byte>..cctor
	|
	|-RVA: 0xA87D00 Offset: 0xA86300 VA: 0x180A87D00
	|-TypeTraits<Color>..cctor
	|
	|-RVA: 0xAA76F0 Offset: 0xAA5CF0 VA: 0x180AA76F0
	|-TypeTraits<Cursor>..cctor
	|
	|-RVA: 0xAA1C60 Offset: 0xAA0260 VA: 0x180AA1C60
	|-TypeTraits<double>..cctor
	|
	|-RVA: 0xAC2BC0 Offset: 0xAC11C0 VA: 0x180AC2BC0
	|-TypeTraits<EasingFunction>..cctor
	|
	|-RVA: 0xAA4330 Offset: 0xAA2930 VA: 0x180AA4330
	|-TypeTraits<FontDefinition>..cctor
	|
	|-RVA: 0xAA2950 Offset: 0xAA0F50 VA: 0x180AA2950
	|-TypeTraits<short>..cctor
	|
	|-RVA: 0xABDE20 Offset: 0xABC420 VA: 0x180ABDE20
	|-TypeTraits<int>..cctor
	|
	|-RVA: 0xAB1230 Offset: 0xAAF830 VA: 0x180AB1230
	|-TypeTraits<Int32Enum>..cctor
	|
	|-RVA: 0xABEB10 Offset: 0xABD110 VA: 0x180ABEB10
	|-TypeTraits<long>..cctor
	|
	|-RVA: 0xAB4FD0 Offset: 0xAB35D0 VA: 0x180AB4FD0
	|-TypeTraits<Length>..cctor
	|
	|-RVA: 0xAB9D70 Offset: 0xAB8370 VA: 0x180AB9D70
	|-TypeTraits<object>..cctor
	|
	|-RVA: 0xAAAAB0 Offset: 0xAA90B0 VA: 0x180AAAAB0
	|-TypeTraits<Rect>..cctor
	|
	|-RVA: 0xAC1ED0 Offset: 0xAC04D0 VA: 0x180AC1ED0
	|-TypeTraits<RectInt>..cctor
	|
	|-RVA: 0xAA0F70 Offset: 0xA9F570 VA: 0x180AA0F70
	|-TypeTraits<Rotate>..cctor
	|
	|-RVA: 0xABD130 Offset: 0xABB730 VA: 0x180ABD130
	|-TypeTraits<sbyte>..cctor
	|
	|-RVA: 0xAA83E0 Offset: 0xAA69E0 VA: 0x180AA83E0
	|-TypeTraits<Scale>..cctor
	|
	|-RVA: 0xAB8390 Offset: 0xAB6990 VA: 0x180AB8390
	|-TypeTraits<float>..cctor
	|
	|-RVA: 0xAB2900 Offset: 0xAB0F00 VA: 0x180AB2900
	|-TypeTraits<StyleBackground>..cctor
	|
	|-RVA: 0xAA3640 Offset: 0xAA1C40 VA: 0x180AA3640
	|-TypeTraits<StyleBackgroundPosition>..cctor
	|
	|-RVA: 0xAB76A0 Offset: 0xAB5CA0 VA: 0x180AB76A0
	|-TypeTraits<StyleBackgroundRepeat>..cctor
	|
	|-RVA: 0xAA90D0 Offset: 0xAA76D0 VA: 0x180AA90D0
	|-TypeTraits<StyleBackgroundSize>..cctor
	|
	|-RVA: 0xAA9DC0 Offset: 0xAA83C0 VA: 0x180AA9DC0
	|-TypeTraits<StyleColor>..cctor
	|
	|-RVA: 0xAC45A0 Offset: 0xAC2BA0 VA: 0x180AC45A0
	|-TypeTraits<StyleCursor>..cctor
	|
	|-RVA: 0xAAEB60 Offset: 0xAAD160 VA: 0x180AAEB60
	|-TypeTraits<StyleFloat>..cctor
	|
	|-RVA: 0xAA5D10 Offset: 0xAA4310 VA: 0x180AA5D10
	|-TypeTraits<StyleFont>..cctor
	|
	|-RVA: 0xAC04F0 Offset: 0xABEAF0 VA: 0x180AC04F0
	|-TypeTraits<StyleFontDefinition>..cctor
	|
	|-RVA: 0xAB35F0 Offset: 0xAB1BF0 VA: 0x180AB35F0
	|-TypeTraits<StyleInt>..cctor
	|
	|-RVA: 0xABAA60 Offset: 0xAB9060 VA: 0x180ABAA60
	|-TypeTraits<StyleLength>..cctor
	|
	|-RVA: 0xAB69B0 Offset: 0xAB4FB0 VA: 0x180AB69B0
	|-TypeTraits<StylePropertyName>..cctor
	|
	|-RVA: 0xAC11E0 Offset: 0xABF7E0 VA: 0x180AC11E0
	|-TypeTraits<StyleRotate>..cctor
	|
	|-RVA: 0xAA0280 Offset: 0xA9E880 VA: 0x180AA0280
	|-TypeTraits<StyleScale>..cctor
	|
	|-RVA: 0xAA5020 Offset: 0xAA3620 VA: 0x180AA5020
	|-TypeTraits<StyleTextShadow>..cctor
	|
	|-RVA: 0xAAF850 Offset: 0xAADE50 VA: 0x180AAF850
	|-TypeTraits<StyleTransformOrigin>..cctor
	|
	|-RVA: 0xABF800 Offset: 0xABDE00 VA: 0x180ABF800
	|-TypeTraits<StyleTranslate>..cctor
	|
	|-RVA: 0xAB5CC0 Offset: 0xAB42C0 VA: 0x180AB5CC0
	|-TypeTraits<TextShadow>..cctor
	|
	|-RVA: 0xAAC490 Offset: 0xAAAA90 VA: 0x180AAC490
	|-TypeTraits<TimeValue>..cctor
	|
	|-RVA: 0xABC440 Offset: 0xABAA40 VA: 0x180ABC440
	|-TypeTraits<TransformOrigin>..cctor
	|
	|-RVA: 0xAC38B0 Offset: 0xAC1EB0 VA: 0x180AC38B0
	|-TypeTraits<Translate>..cctor
	|
	|-RVA: 0xAAD180 Offset: 0xAAB780 VA: 0x180AAD180
	|-TypeTraits<ushort>..cctor
	|
	|-RVA: 0xABB750 Offset: 0xAB9D50 VA: 0x180ABB750
	|-TypeTraits<uint>..cctor
	|
	|-RVA: 0xAB9080 Offset: 0xAB7680 VA: 0x180AB9080
	|-TypeTraits<ulong>..cctor
	|
	|-RVA: 0xAADE70 Offset: 0xAAC470 VA: 0x180AADE70
	|-TypeTraits<Vector2>..cctor
	|
	|-RVA: 0xAAB7A0 Offset: 0xAA9DA0 VA: 0x180AAB7A0
	|-TypeTraits<Vector2Int>..cctor
	|
	|-RVA: 0xAA6A00 Offset: 0xAA5000 VA: 0x180AA6A00
	|-TypeTraits<Vector3>..cctor
	|
	|-RVA: 0xAB0540 Offset: 0xAAEB40 VA: 0x180AB0540
	|-TypeTraits<Vector3Int>..cctor
	|
	|-RVA: 0xAB42E0 Offset: 0xAB28E0 VA: 0x180AB42E0
	|-TypeTraits<Vector4>..cctor
	|
	|-RVA: 0xAB1F20 Offset: 0xAB0520 VA: 0x180AB1F20
	|-TypeTraits<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Properties
public enum InstantiationKind // TypeDefIndex: 13002
{
	// Fields
	public int value__; // 0x0
	public const InstantiationKind Activator = 0;
	public const InstantiationKind PropertyBagOverride = 1;
	public const InstantiationKind NotInstantiatable = 2;
}

// Namespace: Unity.Properties
internal interface IConstructor // TypeDefIndex: 13003
{
	// Properties
	public abstract InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract InstantiationKind get_InstantiationKind();
}

// Namespace: Unity.Properties
internal interface IConstructor<T> : IConstructor // TypeDefIndex: 13004
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Instantiate();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConstructor<__Il2CppFullySharedGenericType>.Instantiate
	*/
}

// Namespace: Unity.Properties
internal interface IConstructorWithCount<T> : IConstructor // TypeDefIndex: 13005
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T InstantiateWithCount(int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConstructorWithCount<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/
}

// Namespace: Unity.Properties
[Extension]
public static class TypeUtility // TypeDefIndex: 13013
{
	// Fields
	private static readonly ConcurrentDictionary<Type, TypeUtility.ITypeConstructor> s_TypeConstructors; // 0x0
	private static readonly MethodInfo s_CreateTypeConstructor; // 0x8
	private static readonly ConcurrentDictionary<Type, string> s_CachedResolvedName; // 0x10
	private static readonly ObjectPool<StringBuilder> s_Builders; // 0x18
	private static readonly object syncedPoolObject; // 0x20

	// Methods

	// RVA: 0x23DC0B0 Offset: 0x23DA6B0 VA: 0x1823DC0B0
	private static void .cctor() { }

	// RVA: 0x23DB630 Offset: 0x23D9C30 VA: 0x1823DB630
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x23DB750 Offset: 0x23D9D50 VA: 0x1823DB750
	private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex) { }

	[Extension]
	// RVA: 0x23DB480 Offset: 0x23D9A80 VA: 0x1823DB480
	public static Type GetRootType(Type type) { }

	[Preserve]
	// RVA: 0x23DB1A0 Offset: 0x23D97A0 VA: 0x1823DB1A0
	private static TypeUtility.ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> CreateTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x800A20 Offset: 0x7FF020 VA: 0x180800A20
	|-TypeUtility.CreateTypeConstructor<StyleEnum<Int32Enum>>
	|
	|-RVA: 0x801350 Offset: 0x7FF950 VA: 0x180801350
	|-TypeUtility.CreateTypeConstructor<StyleList<EasingFunction>>
	|
	|-RVA: 0x8014A0 Offset: 0x7FFAA0 VA: 0x1808014A0
	|-TypeUtility.CreateTypeConstructor<StyleList<StylePropertyName>>
	|
	|-RVA: 0x801200 Offset: 0x7FF800 VA: 0x180801200
	|-TypeUtility.CreateTypeConstructor<StyleList<TimeValue>>
	|
	|-RVA: 0x7FEAA0 Offset: 0x7FD0A0 VA: 0x1807FEAA0
	|-TypeUtility.CreateTypeConstructor<Angle>
	|
	|-RVA: 0x7FEFE0 Offset: 0x7FD5E0 VA: 0x1807FEFE0
	|-TypeUtility.CreateTypeConstructor<Background>
	|
	|-RVA: 0x7FEBF0 Offset: 0x7FD1F0 VA: 0x1807FEBF0
	|-TypeUtility.CreateTypeConstructor<BackgroundPosition>
	|
	|-RVA: 0x7FED40 Offset: 0x7FD340 VA: 0x1807FED40
	|-TypeUtility.CreateTypeConstructor<BackgroundRepeat>
	|
	|-RVA: 0x7FEE90 Offset: 0x7FD490 VA: 0x1807FEE90
	|-TypeUtility.CreateTypeConstructor<BackgroundSize>
	|
	|-RVA: 0x7FF280 Offset: 0x7FD880 VA: 0x1807FF280
	|-TypeUtility.CreateTypeConstructor<Bounds>
	|
	|-RVA: 0x7FF130 Offset: 0x7FD730 VA: 0x1807FF130
	|-TypeUtility.CreateTypeConstructor<BoundsInt>
	|
	|-RVA: 0x7FF3D0 Offset: 0x7FD9D0 VA: 0x1807FF3D0
	|-TypeUtility.CreateTypeConstructor<Color>
	|
	|-RVA: 0x7FF520 Offset: 0x7FDB20 VA: 0x1807FF520
	|-TypeUtility.CreateTypeConstructor<Cursor>
	|
	|-RVA: 0x7FF670 Offset: 0x7FDC70 VA: 0x1807FF670
	|-TypeUtility.CreateTypeConstructor<EasingFunction>
	|
	|-RVA: 0x7FF7C0 Offset: 0x7FDDC0 VA: 0x1807FF7C0
	|-TypeUtility.CreateTypeConstructor<FontDefinition>
	|
	|-RVA: 0x7FFA60 Offset: 0x7FE060 VA: 0x1807FFA60
	|-TypeUtility.CreateTypeConstructor<Length>
	|
	|-RVA: 0x7FFFA0 Offset: 0x7FE5A0 VA: 0x1807FFFA0
	|-TypeUtility.CreateTypeConstructor<object>
	|
	|-RVA: 0x7FFD00 Offset: 0x7FE300 VA: 0x1807FFD00
	|-TypeUtility.CreateTypeConstructor<Rect>
	|
	|-RVA: 0x7FFBB0 Offset: 0x7FE1B0 VA: 0x1807FFBB0
	|-TypeUtility.CreateTypeConstructor<RectInt>
	|
	|-RVA: 0x7FFE50 Offset: 0x7FE450 VA: 0x1807FFE50
	|-TypeUtility.CreateTypeConstructor<Rotate>
	|
	|-RVA: 0x8000F0 Offset: 0x7FE6F0 VA: 0x1808000F0
	|-TypeUtility.CreateTypeConstructor<Scale>
	|
	|-RVA: 0x800630 Offset: 0x7FEC30 VA: 0x180800630
	|-TypeUtility.CreateTypeConstructor<StyleBackground>
	|
	|-RVA: 0x800240 Offset: 0x7FE840 VA: 0x180800240
	|-TypeUtility.CreateTypeConstructor<StyleBackgroundPosition>
	|
	|-RVA: 0x800390 Offset: 0x7FE990 VA: 0x180800390
	|-TypeUtility.CreateTypeConstructor<StyleBackgroundRepeat>
	|
	|-RVA: 0x8004E0 Offset: 0x7FEAE0 VA: 0x1808004E0
	|-TypeUtility.CreateTypeConstructor<StyleBackgroundSize>
	|
	|-RVA: 0x800780 Offset: 0x7FED80 VA: 0x180800780
	|-TypeUtility.CreateTypeConstructor<StyleColor>
	|
	|-RVA: 0x8008D0 Offset: 0x7FEED0 VA: 0x1808008D0
	|-TypeUtility.CreateTypeConstructor<StyleCursor>
	|
	|-RVA: 0x800B70 Offset: 0x7FF170 VA: 0x180800B70
	|-TypeUtility.CreateTypeConstructor<StyleFloat>
	|
	|-RVA: 0x800E10 Offset: 0x7FF410 VA: 0x180800E10
	|-TypeUtility.CreateTypeConstructor<StyleFont>
	|
	|-RVA: 0x800CC0 Offset: 0x7FF2C0 VA: 0x180800CC0
	|-TypeUtility.CreateTypeConstructor<StyleFontDefinition>
	|
	|-RVA: 0x800F60 Offset: 0x7FF560 VA: 0x180800F60
	|-TypeUtility.CreateTypeConstructor<StyleInt>
	|
	|-RVA: 0x8010B0 Offset: 0x7FF6B0 VA: 0x1808010B0
	|-TypeUtility.CreateTypeConstructor<StyleLength>
	|
	|-RVA: 0x8015F0 Offset: 0x7FFBF0 VA: 0x1808015F0
	|-TypeUtility.CreateTypeConstructor<StylePropertyName>
	|
	|-RVA: 0x801740 Offset: 0x7FFD40 VA: 0x180801740
	|-TypeUtility.CreateTypeConstructor<StyleRotate>
	|
	|-RVA: 0x801890 Offset: 0x7FFE90 VA: 0x180801890
	|-TypeUtility.CreateTypeConstructor<StyleScale>
	|
	|-RVA: 0x8019E0 Offset: 0x7FFFE0 VA: 0x1808019E0
	|-TypeUtility.CreateTypeConstructor<StyleTextShadow>
	|
	|-RVA: 0x801B30 Offset: 0x800130 VA: 0x180801B30
	|-TypeUtility.CreateTypeConstructor<StyleTransformOrigin>
	|
	|-RVA: 0x801C80 Offset: 0x800280 VA: 0x180801C80
	|-TypeUtility.CreateTypeConstructor<StyleTranslate>
	|
	|-RVA: 0x801DD0 Offset: 0x8003D0 VA: 0x180801DD0
	|-TypeUtility.CreateTypeConstructor<TextShadow>
	|
	|-RVA: 0x801F20 Offset: 0x800520 VA: 0x180801F20
	|-TypeUtility.CreateTypeConstructor<TimeValue>
	|
	|-RVA: 0x802070 Offset: 0x800670 VA: 0x180802070
	|-TypeUtility.CreateTypeConstructor<TransformOrigin>
	|
	|-RVA: 0x8021C0 Offset: 0x8007C0 VA: 0x1808021C0
	|-TypeUtility.CreateTypeConstructor<Translate>
	|
	|-RVA: 0x802460 Offset: 0x800A60 VA: 0x180802460
	|-TypeUtility.CreateTypeConstructor<Vector2>
	|
	|-RVA: 0x802310 Offset: 0x800910 VA: 0x180802310
	|-TypeUtility.CreateTypeConstructor<Vector2Int>
	|
	|-RVA: 0x802700 Offset: 0x800D00 VA: 0x180802700
	|-TypeUtility.CreateTypeConstructor<Vector3>
	|
	|-RVA: 0x8025B0 Offset: 0x800BB0 VA: 0x1808025B0
	|-TypeUtility.CreateTypeConstructor<Vector3Int>
	|
	|-RVA: 0x802850 Offset: 0x800E50 VA: 0x180802850
	|-TypeUtility.CreateTypeConstructor<Vector4>
	|
	|-RVA: 0x7FF910 Offset: 0x7FDF10 VA: 0x1807FF910
	|-TypeUtility.CreateTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23DB570 Offset: 0x23D9B70 VA: 0x1823DB570
	private static TypeUtility.ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> GetTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x802A50 Offset: 0x801050 VA: 0x180802A50
	|-TypeUtility.GetTypeConstructor<object>
	|
	|-RVA: 0x8029A0 Offset: 0x800FA0 VA: 0x1808029A0
	|-TypeUtility.GetTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23DAE30 Offset: 0x23D9430 VA: 0x1823DAE30
	public static bool CanBeInstantiated(Type type) { }

	// RVA: -1 Offset: -1
	public static bool CanBeInstantiated<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7FE910 Offset: 0x7FCF10 VA: 0x1807FE910
	|-TypeUtility.CanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SetExplicitInstantiationMethod<T>(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8038A0 Offset: 0x801EA0 VA: 0x1808038A0
	|-TypeUtility.SetExplicitInstantiationMethod<object>
	|
	|-RVA: 0x803790 Offset: 0x801D90 VA: 0x180803790
	|-TypeUtility.SetExplicitInstantiationMethod<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x803470 Offset: 0x801A70 VA: 0x180803470
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(out T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x803E30 Offset: 0x802430 VA: 0x180803E30
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(Type derivedType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8035D0 Offset: 0x801BD0 VA: 0x1808035D0
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(Type derivedType, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x803C50 Offset: 0x802250 VA: 0x180803C50
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x803050 Offset: 0x801650 VA: 0x180803050
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiateArray<TArray>(int count, out TArray instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8039B0 Offset: 0x801FB0 VA: 0x1808039B0
	|-TypeUtility.TryInstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(Type derivedType, int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x802C30 Offset: 0x801230 VA: 0x180802C30
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23DB020 Offset: 0x23D9620 VA: 0x1823DB020
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: -1 Offset: -1
	private static void CheckCanBeInstantiated<T>(TypeUtility.ITypeConstructor<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7FE990 Offset: 0x7FCF90 VA: 0x1807FE990
	|-TypeUtility.CheckCanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x23DAF40 Offset: 0x23D9540 VA: 0x1823DAF40
	private static void CheckCanBeInstantiated(TypeUtility.ITypeConstructor constructor, Type type) { }
}

