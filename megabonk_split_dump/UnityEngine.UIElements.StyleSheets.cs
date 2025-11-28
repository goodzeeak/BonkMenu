// Namespace: UnityEngine.UIElements.StyleSheets
internal abstract class HierarchyTraversal // TypeDefIndex: 4520
{
	// Methods

	// RVA: 0x2524DC0 Offset: 0x25233C0 VA: 0x182524DC0 Slot: 4
	public virtual void Traverse(VisualElement element) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void TraverseRecursive(VisualElement element, int depth);

	// RVA: 0x2524CF0 Offset: 0x25232F0 VA: 0x182524CF0
	protected void Recurse(VisualElement element, int depth) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class InitialStyle // TypeDefIndex: 4521
{
	// Fields
	private static ComputedStyle s_InitialStyle; // 0x0

	// Properties
	public static Align alignContent { get; }
	public static Align alignItems { get; }
	public static Align alignSelf { get; }
	public static Color backgroundColor { get; }
	public static Background backgroundImage { get; }
	public static BackgroundPosition backgroundPositionX { get; }
	public static BackgroundPosition backgroundPositionY { get; }
	public static BackgroundRepeat backgroundRepeat { get; }
	public static BackgroundSize backgroundSize { get; }
	public static Color borderBottomColor { get; }
	public static Length borderBottomLeftRadius { get; }
	public static Length borderBottomRightRadius { get; }
	public static float borderBottomWidth { get; }
	public static Color borderLeftColor { get; }
	public static float borderLeftWidth { get; }
	public static Color borderRightColor { get; }
	public static float borderRightWidth { get; }
	public static Color borderTopColor { get; }
	public static Length borderTopLeftRadius { get; }
	public static Length borderTopRightRadius { get; }
	public static float borderTopWidth { get; }
	public static Length bottom { get; }
	public static Color color { get; }
	public static Cursor cursor { get; }
	public static DisplayStyle display { get; }
	public static Length flexBasis { get; }
	public static FlexDirection flexDirection { get; }
	public static float flexGrow { get; }
	public static float flexShrink { get; }
	public static Wrap flexWrap { get; }
	public static Length fontSize { get; }
	public static Length height { get; }
	public static Justify justifyContent { get; }
	public static Length left { get; }
	public static Length letterSpacing { get; }
	public static Length marginBottom { get; }
	public static Length marginLeft { get; }
	public static Length marginRight { get; }
	public static Length marginTop { get; }
	public static Length maxHeight { get; }
	public static Length maxWidth { get; }
	public static Length minHeight { get; }
	public static Length minWidth { get; }
	public static float opacity { get; }
	public static OverflowInternal overflow { get; }
	public static Length paddingBottom { get; }
	public static Length paddingLeft { get; }
	public static Length paddingRight { get; }
	public static Length paddingTop { get; }
	public static Position position { get; }
	public static Length right { get; }
	public static Rotate rotate { get; }
	public static Scale scale { get; }
	public static TextOverflow textOverflow { get; }
	public static TextShadow textShadow { get; }
	public static Length top { get; }
	public static TransformOrigin transformOrigin { get; }
	public static List<TimeValue> transitionDelay { get; }
	public static List<TimeValue> transitionDuration { get; }
	public static List<StylePropertyName> transitionProperty { get; }
	public static List<EasingFunction> transitionTimingFunction { get; }
	public static Translate translate { get; }
	public static Color unityBackgroundImageTintColor { get; }
	public static Font unityFont { get; }
	public static FontDefinition unityFontDefinition { get; }
	public static FontStyle unityFontStyleAndWeight { get; }
	public static OverflowClipBox unityOverflowClipBox { get; }
	public static Length unityParagraphSpacing { get; }
	public static int unitySliceBottom { get; }
	public static int unitySliceLeft { get; }
	public static int unitySliceRight { get; }
	public static float unitySliceScale { get; }
	public static int unitySliceTop { get; }
	public static TextAnchor unityTextAlign { get; }
	public static Color unityTextOutlineColor { get; }
	public static float unityTextOutlineWidth { get; }
	public static TextOverflowPosition unityTextOverflowPosition { get; }
	public static Visibility visibility { get; }
	public static WhiteSpace whiteSpace { get; }
	public static Length width { get; }
	public static Length wordSpacing { get; }

	// Methods

	// RVA: 0x2524E80 Offset: 0x2523480 VA: 0x182524E80
	public static ref ComputedStyle Get() { }

	// RVA: 0x2524DE0 Offset: 0x25233E0 VA: 0x182524DE0
	public static ComputedStyle Acquire() { }

	// RVA: 0x2524ED0 Offset: 0x25234D0 VA: 0x182524ED0
	private static void .cctor() { }

	// RVA: 0x2525FD0 Offset: 0x25245D0 VA: 0x182525FD0
	public static Align get_alignContent() { }

	// RVA: 0x2526040 Offset: 0x2524640 VA: 0x182526040
	public static Align get_alignItems() { }

	// RVA: 0x25260B0 Offset: 0x25246B0 VA: 0x1825260B0
	public static Align get_alignSelf() { }

	// RVA: 0x2526120 Offset: 0x2524720 VA: 0x182526120
	public static Color get_backgroundColor() { }

	// RVA: 0x25261A0 Offset: 0x25247A0 VA: 0x1825261A0
	public static Background get_backgroundImage() { }

	// RVA: 0x2526220 Offset: 0x2524820 VA: 0x182526220
	public static BackgroundPosition get_backgroundPositionX() { }

	// RVA: 0x25262A0 Offset: 0x25248A0 VA: 0x1825262A0
	public static BackgroundPosition get_backgroundPositionY() { }

	// RVA: 0x2526320 Offset: 0x2524920 VA: 0x182526320
	public static BackgroundRepeat get_backgroundRepeat() { }

	// RVA: 0x2526390 Offset: 0x2524990 VA: 0x182526390
	public static BackgroundSize get_backgroundSize() { }

	// RVA: 0x2526410 Offset: 0x2524A10 VA: 0x182526410
	public static Color get_borderBottomColor() { }

	// RVA: 0x2526490 Offset: 0x2524A90 VA: 0x182526490
	public static Length get_borderBottomLeftRadius() { }

	// RVA: 0x2526500 Offset: 0x2524B00 VA: 0x182526500
	public static Length get_borderBottomRightRadius() { }

	// RVA: 0x2526570 Offset: 0x2524B70 VA: 0x182526570
	public static float get_borderBottomWidth() { }

	// RVA: 0x25265E0 Offset: 0x2524BE0 VA: 0x1825265E0
	public static Color get_borderLeftColor() { }

	// RVA: 0x2526660 Offset: 0x2524C60 VA: 0x182526660
	public static float get_borderLeftWidth() { }

	// RVA: 0x25266D0 Offset: 0x2524CD0 VA: 0x1825266D0
	public static Color get_borderRightColor() { }

	// RVA: 0x2526750 Offset: 0x2524D50 VA: 0x182526750
	public static float get_borderRightWidth() { }

	// RVA: 0x25267C0 Offset: 0x2524DC0 VA: 0x1825267C0
	public static Color get_borderTopColor() { }

	// RVA: 0x2526840 Offset: 0x2524E40 VA: 0x182526840
	public static Length get_borderTopLeftRadius() { }

	// RVA: 0x25268B0 Offset: 0x2524EB0 VA: 0x1825268B0
	public static Length get_borderTopRightRadius() { }

	// RVA: 0x2526920 Offset: 0x2524F20 VA: 0x182526920
	public static float get_borderTopWidth() { }

	// RVA: 0x2526990 Offset: 0x2524F90 VA: 0x182526990
	public static Length get_bottom() { }

	// RVA: 0x2526A00 Offset: 0x2525000 VA: 0x182526A00
	public static Color get_color() { }

	// RVA: 0x2526A70 Offset: 0x2525070 VA: 0x182526A70
	public static Cursor get_cursor() { }

	// RVA: 0x2526AF0 Offset: 0x25250F0 VA: 0x182526AF0
	public static DisplayStyle get_display() { }

	// RVA: 0x2526B60 Offset: 0x2525160 VA: 0x182526B60
	public static Length get_flexBasis() { }

	// RVA: 0x2526BD0 Offset: 0x25251D0 VA: 0x182526BD0
	public static FlexDirection get_flexDirection() { }

	// RVA: 0x2526C40 Offset: 0x2525240 VA: 0x182526C40
	public static float get_flexGrow() { }

	// RVA: 0x2526CB0 Offset: 0x25252B0 VA: 0x182526CB0
	public static float get_flexShrink() { }

	// RVA: 0x2526D20 Offset: 0x2525320 VA: 0x182526D20
	public static Wrap get_flexWrap() { }

	// RVA: 0x2526D90 Offset: 0x2525390 VA: 0x182526D90
	public static Length get_fontSize() { }

	// RVA: 0x2526E00 Offset: 0x2525400 VA: 0x182526E00
	public static Length get_height() { }

	// RVA: 0x2526E70 Offset: 0x2525470 VA: 0x182526E70
	public static Justify get_justifyContent() { }

	// RVA: 0x2526EE0 Offset: 0x25254E0 VA: 0x182526EE0
	public static Length get_left() { }

	// RVA: 0x2526F50 Offset: 0x2525550 VA: 0x182526F50
	public static Length get_letterSpacing() { }

	// RVA: 0x2526FC0 Offset: 0x25255C0 VA: 0x182526FC0
	public static Length get_marginBottom() { }

	// RVA: 0x2527030 Offset: 0x2525630 VA: 0x182527030
	public static Length get_marginLeft() { }

	// RVA: 0x25270A0 Offset: 0x25256A0 VA: 0x1825270A0
	public static Length get_marginRight() { }

	// RVA: 0x2527110 Offset: 0x2525710 VA: 0x182527110
	public static Length get_marginTop() { }

	// RVA: 0x2527180 Offset: 0x2525780 VA: 0x182527180
	public static Length get_maxHeight() { }

	// RVA: 0x25271F0 Offset: 0x25257F0 VA: 0x1825271F0
	public static Length get_maxWidth() { }

	// RVA: 0x2527260 Offset: 0x2525860 VA: 0x182527260
	public static Length get_minHeight() { }

	// RVA: 0x25272D0 Offset: 0x25258D0 VA: 0x1825272D0
	public static Length get_minWidth() { }

	// RVA: 0x2527340 Offset: 0x2525940 VA: 0x182527340
	public static float get_opacity() { }

	// RVA: 0x25273B0 Offset: 0x25259B0 VA: 0x1825273B0
	public static OverflowInternal get_overflow() { }

	// RVA: 0x2527420 Offset: 0x2525A20 VA: 0x182527420
	public static Length get_paddingBottom() { }

	// RVA: 0x2527490 Offset: 0x2525A90 VA: 0x182527490
	public static Length get_paddingLeft() { }

	// RVA: 0x2527500 Offset: 0x2525B00 VA: 0x182527500
	public static Length get_paddingRight() { }

	// RVA: 0x2527570 Offset: 0x2525B70 VA: 0x182527570
	public static Length get_paddingTop() { }

	// RVA: 0x25275E0 Offset: 0x2525BE0 VA: 0x1825275E0
	public static Position get_position() { }

	// RVA: 0x2527650 Offset: 0x2525C50 VA: 0x182527650
	public static Length get_right() { }

	// RVA: 0x25276C0 Offset: 0x2525CC0 VA: 0x1825276C0
	public static Rotate get_rotate() { }

	// RVA: 0x2527740 Offset: 0x2525D40 VA: 0x182527740
	public static Scale get_scale() { }

	// RVA: 0x25277C0 Offset: 0x2525DC0 VA: 0x1825277C0
	public static TextOverflow get_textOverflow() { }

	// RVA: 0x2527830 Offset: 0x2525E30 VA: 0x182527830
	public static TextShadow get_textShadow() { }

	// RVA: 0x25278B0 Offset: 0x2525EB0 VA: 0x1825278B0
	public static Length get_top() { }

	// RVA: 0x2527920 Offset: 0x2525F20 VA: 0x182527920
	public static TransformOrigin get_transformOrigin() { }

	// RVA: 0x25279A0 Offset: 0x2525FA0 VA: 0x1825279A0
	public static List<TimeValue> get_transitionDelay() { }

	// RVA: 0x2527A10 Offset: 0x2526010 VA: 0x182527A10
	public static List<TimeValue> get_transitionDuration() { }

	// RVA: 0x2527A80 Offset: 0x2526080 VA: 0x182527A80
	public static List<StylePropertyName> get_transitionProperty() { }

	// RVA: 0x2527AF0 Offset: 0x25260F0 VA: 0x182527AF0
	public static List<EasingFunction> get_transitionTimingFunction() { }

	// RVA: 0x2527B60 Offset: 0x2526160 VA: 0x182527B60
	public static Translate get_translate() { }

	// RVA: 0x2527BE0 Offset: 0x25261E0 VA: 0x182527BE0
	public static Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x2527D40 Offset: 0x2526340 VA: 0x182527D40
	public static Font get_unityFont() { }

	// RVA: 0x2527C60 Offset: 0x2526260 VA: 0x182527C60
	public static FontDefinition get_unityFontDefinition() { }

	// RVA: 0x2527CD0 Offset: 0x25262D0 VA: 0x182527CD0
	public static FontStyle get_unityFontStyleAndWeight() { }

	// RVA: 0x2527DB0 Offset: 0x25263B0 VA: 0x182527DB0
	public static OverflowClipBox get_unityOverflowClipBox() { }

	// RVA: 0x2527E20 Offset: 0x2526420 VA: 0x182527E20
	public static Length get_unityParagraphSpacing() { }

	// RVA: 0x2527E90 Offset: 0x2526490 VA: 0x182527E90
	public static int get_unitySliceBottom() { }

	// RVA: 0x2527F00 Offset: 0x2526500 VA: 0x182527F00
	public static int get_unitySliceLeft() { }

	// RVA: 0x2527F70 Offset: 0x2526570 VA: 0x182527F70
	public static int get_unitySliceRight() { }

	// RVA: 0x2527FE0 Offset: 0x25265E0 VA: 0x182527FE0
	public static float get_unitySliceScale() { }

	// RVA: 0x2528050 Offset: 0x2526650 VA: 0x182528050
	public static int get_unitySliceTop() { }

	// RVA: 0x25280C0 Offset: 0x25266C0 VA: 0x1825280C0
	public static TextAnchor get_unityTextAlign() { }

	// RVA: 0x2528130 Offset: 0x2526730 VA: 0x182528130
	public static Color get_unityTextOutlineColor() { }

	// RVA: 0x25281A0 Offset: 0x25267A0 VA: 0x1825281A0
	public static float get_unityTextOutlineWidth() { }

	// RVA: 0x2528210 Offset: 0x2526810 VA: 0x182528210
	public static TextOverflowPosition get_unityTextOverflowPosition() { }

	// RVA: 0x2528280 Offset: 0x2526880 VA: 0x182528280
	public static Visibility get_visibility() { }

	// RVA: 0x25282F0 Offset: 0x25268F0 VA: 0x1825282F0
	public static WhiteSpace get_whiteSpace() { }

	// RVA: 0x2528360 Offset: 0x2526960 VA: 0x182528360
	public static Length get_width() { }

	// RVA: 0x25283D0 Offset: 0x25269D0 VA: 0x1825283D0
	public static Length get_wordSpacing() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class ShorthandApplicator // TypeDefIndex: 4522
{
	// Fields
	private static List<TimeValue> s_TransitionDelayList; // 0x0
	private static List<TimeValue> s_TransitionDurationList; // 0x8
	private static List<StylePropertyName> s_TransitionPropertyList; // 0x10
	private static List<EasingFunction> s_TransitionTimingFunctionList; // 0x18

	// Methods

	// RVA: 0x252F5A0 Offset: 0x252DBA0 VA: 0x18252F5A0
	public static void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x252F670 Offset: 0x252DC70 VA: 0x18252F670
	public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x252F890 Offset: 0x252DE90 VA: 0x18252F890
	public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x252FA80 Offset: 0x252E080 VA: 0x18252FA80
	public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x252FCB0 Offset: 0x252E2B0 VA: 0x18252FCB0
	public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x252FD90 Offset: 0x252E390 VA: 0x18252FD90
	public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x252FF70 Offset: 0x252E570 VA: 0x18252FF70
	public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2530160 Offset: 0x252E760 VA: 0x182530160
	public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x25302B0 Offset: 0x252E8B0 VA: 0x1825302B0
	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2530420 Offset: 0x252EA20 VA: 0x182530420
	public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x2531230 Offset: 0x252F830 VA: 0x182531230
	private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis) { }

	// RVA: 0x2530C00 Offset: 0x252F200 VA: 0x182530C00
	private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	// RVA: 0x2530540 Offset: 0x252EB40 VA: 0x182530540
	private static void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY) { }

	// RVA: 0x2531F80 Offset: 0x2530580 VA: 0x182531F80
	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize) { }

	// RVA: 0x25310C0 Offset: 0x252F6C0 VA: 0x1825310C0
	private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	// RVA: 0x2530EF0 Offset: 0x252F4F0 VA: 0x182530EF0
	private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left) { }

	// RVA: 0x2530D50 Offset: 0x252F350 VA: 0x182530D50
	private static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left) { }

	// RVA: 0x2531430 Offset: 0x252FA30 VA: 0x182531430
	private static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth) { }

	// RVA: 0x25314F0 Offset: 0x252FAF0 VA: 0x1825314F0
	private static void CompileTransition(StylePropertyReader reader, out List<TimeValue> outDelay, out List<TimeValue> outDuration, out List<StylePropertyName> outProperty, out List<EasingFunction> outTimingFunction) { }

	// RVA: 0x2532050 Offset: 0x2530650 VA: 0x182532050
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2532040 Offset: 0x2530640 VA: 0x182532040
	internal static void <CompileBackgroundPosition>g__SwapKeyword|16_0(ref BackgroundPositionKeyword a, ref BackgroundPositionKeyword b) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StylePropertyCache // TypeDefIndex: 4523
{
	// Fields
	internal static readonly Dictionary<string, string> s_PropertySyntaxCache; // 0x0
	internal static readonly Dictionary<string, string> s_NonTerminalValues; // 0x8

	// Methods

	// RVA: 0x2532280 Offset: 0x2530880 VA: 0x182532280
	public static bool TryGetSyntax(string name, out string syntax) { }

	// RVA: 0x25321F0 Offset: 0x25307F0 VA: 0x1825321F0
	public static bool TryGetNonTerminalValue(string name, out string syntax) { }

	// RVA: 0x2532310 Offset: 0x2530910 VA: 0x182532310
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal enum StyleEnumType // TypeDefIndex: 4524
{
	// Fields
	public int value__; // 0x0
	public const StyleEnumType Align = 0;
	public const StyleEnumType Axis = 1;
	public const StyleEnumType BackgroundPositionKeyword = 2;
	public const StyleEnumType BackgroundSizeType = 3;
	public const StyleEnumType DisplayStyle = 4;
	public const StyleEnumType EasingMode = 5;
	public const StyleEnumType FlexDirection = 6;
	public const StyleEnumType FontStyle = 7;
	public const StyleEnumType Justify = 8;
	public const StyleEnumType Overflow = 9;
	public const StyleEnumType OverflowClipBox = 10;
	public const StyleEnumType OverflowInternal = 11;
	public const StyleEnumType Position = 12;
	public const StyleEnumType Repeat = 13;
	public const StyleEnumType RepeatXY = 14;
	public const StyleEnumType ScaleMode = 15;
	public const StyleEnumType TextAnchor = 16;
	public const StyleEnumType TextOverflow = 17;
	public const StyleEnumType TextOverflowPosition = 18;
	public const StyleEnumType TransformOriginOffset = 19;
	public const StyleEnumType Visibility = 20;
	public const StyleEnumType WhiteSpace = 21;
	public const StyleEnumType Wrap = 22;
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal enum StylePropertyId // TypeDefIndex: 4525
{
	// Fields
	public int value__; // 0x0
	public const StylePropertyId Unknown = 0;
	public const StylePropertyId Custom = -1;
	public const StylePropertyId AlignContent = 131072;
	public const StylePropertyId AlignItems = 131073;
	public const StylePropertyId AlignSelf = 131074;
	public const StylePropertyId All = 262144;
	public const StylePropertyId BackgroundColor = 458752;
	public const StylePropertyId BackgroundImage = 458753;
	public const StylePropertyId BackgroundPosition = 262145;
	public const StylePropertyId BackgroundPositionX = 458754;
	public const StylePropertyId BackgroundPositionY = 458755;
	public const StylePropertyId BackgroundRepeat = 458756;
	public const StylePropertyId BackgroundSize = 458757;
	public const StylePropertyId BorderBottomColor = 458758;
	public const StylePropertyId BorderBottomLeftRadius = 458759;
	public const StylePropertyId BorderBottomRightRadius = 458760;
	public const StylePropertyId BorderBottomWidth = 131075;
	public const StylePropertyId BorderColor = 262146;
	public const StylePropertyId BorderLeftColor = 458761;
	public const StylePropertyId BorderLeftWidth = 131076;
	public const StylePropertyId BorderRadius = 262147;
	public const StylePropertyId BorderRightColor = 458762;
	public const StylePropertyId BorderRightWidth = 131077;
	public const StylePropertyId BorderTopColor = 458763;
	public const StylePropertyId BorderTopLeftRadius = 458764;
	public const StylePropertyId BorderTopRightRadius = 458765;
	public const StylePropertyId BorderTopWidth = 131078;
	public const StylePropertyId BorderWidth = 262148;
	public const StylePropertyId Bottom = 131079;
	public const StylePropertyId Color = 65536;
	public const StylePropertyId Cursor = 196608;
	public const StylePropertyId Display = 131080;
	public const StylePropertyId Flex = 262149;
	public const StylePropertyId FlexBasis = 131081;
	public const StylePropertyId FlexDirection = 131082;
	public const StylePropertyId FlexGrow = 131083;
	public const StylePropertyId FlexShrink = 131084;
	public const StylePropertyId FlexWrap = 131085;
	public const StylePropertyId FontSize = 65537;
	public const StylePropertyId Height = 131086;
	public const StylePropertyId JustifyContent = 131087;
	public const StylePropertyId Left = 131088;
	public const StylePropertyId LetterSpacing = 65538;
	public const StylePropertyId Margin = 262150;
	public const StylePropertyId MarginBottom = 131089;
	public const StylePropertyId MarginLeft = 131090;
	public const StylePropertyId MarginRight = 131091;
	public const StylePropertyId MarginTop = 131092;
	public const StylePropertyId MaxHeight = 131093;
	public const StylePropertyId MaxWidth = 131094;
	public const StylePropertyId MinHeight = 131095;
	public const StylePropertyId MinWidth = 131096;
	public const StylePropertyId Opacity = 458766;
	public const StylePropertyId Overflow = 458767;
	public const StylePropertyId Padding = 262151;
	public const StylePropertyId PaddingBottom = 131097;
	public const StylePropertyId PaddingLeft = 131098;
	public const StylePropertyId PaddingRight = 131099;
	public const StylePropertyId PaddingTop = 131100;
	public const StylePropertyId Position = 131101;
	public const StylePropertyId Right = 131102;
	public const StylePropertyId Rotate = 327680;
	public const StylePropertyId Scale = 327681;
	public const StylePropertyId TextOverflow = 196609;
	public const StylePropertyId TextShadow = 65539;
	public const StylePropertyId Top = 131103;
	public const StylePropertyId TransformOrigin = 327682;
	public const StylePropertyId Transition = 262152;
	public const StylePropertyId TransitionDelay = 393216;
	public const StylePropertyId TransitionDuration = 393217;
	public const StylePropertyId TransitionProperty = 393218;
	public const StylePropertyId TransitionTimingFunction = 393219;
	public const StylePropertyId Translate = 327683;
	public const StylePropertyId UnityBackgroundImageTintColor = 196610;
	public const StylePropertyId UnityBackgroundScaleMode = 262153;
	public const StylePropertyId UnityFont = 65540;
	public const StylePropertyId UnityFontDefinition = 65541;
	public const StylePropertyId UnityFontStyleAndWeight = 65542;
	public const StylePropertyId UnityOverflowClipBox = 196611;
	public const StylePropertyId UnityParagraphSpacing = 65543;
	public const StylePropertyId UnitySliceBottom = 196612;
	public const StylePropertyId UnitySliceLeft = 196613;
	public const StylePropertyId UnitySliceRight = 196614;
	public const StylePropertyId UnitySliceScale = 196615;
	public const StylePropertyId UnitySliceTop = 196616;
	public const StylePropertyId UnityTextAlign = 65544;
	public const StylePropertyId UnityTextOutline = 262154;
	public const StylePropertyId UnityTextOutlineColor = 65545;
	public const StylePropertyId UnityTextOutlineWidth = 65546;
	public const StylePropertyId UnityTextOverflowPosition = 196617;
	public const StylePropertyId Visibility = 65547;
	public const StylePropertyId WhiteSpace = 65548;
	public const StylePropertyId Width = 131104;
	public const StylePropertyId WordSpacing = 65549;
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StylePropertyUtil // TypeDefIndex: 4526
{
	// Fields
	internal static readonly Dictionary<string, StylePropertyId> s_NameToId; // 0x0
	internal static readonly Dictionary<StylePropertyId, string> s_IdToName; // 0x8
	internal static readonly Dictionary<string, string> s_UssNameToCSharpName; // 0x10
	internal static readonly Dictionary<string, string> s_CSharpNameToUssName; // 0x18
	internal static readonly HashSet<StylePropertyId> s_AnimatableProperties; // 0x20
	internal static readonly Dictionary<StylePropertyId, UsageHints> s_AnimatableWithUsageHintProperties; // 0x28

	// Methods

	// RVA: 0x25337E0 Offset: 0x2531DE0 VA: 0x1825337E0
	public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue) { }

	// RVA: 0x2533680 Offset: 0x2531C80 VA: 0x182533680
	public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) { }

	// RVA: 0x2533600 Offset: 0x2531C00 VA: 0x182533600
	public static bool IsAnimatable(StylePropertyId id) { }

	// RVA: 0x2534800 Offset: 0x2532E00 VA: 0x182534800
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
[Serializable]
internal struct Dimension : IEquatable<Dimension> // TypeDefIndex: 4528
{
	// Fields
	public Dimension.Unit unit; // 0x0
	public float value; // 0x4

	// Methods

	// RVA: 0x253BE00 Offset: 0x253A400 VA: 0x18253BE00
	public void .ctor(float value, Dimension.Unit unit) { }

	// RVA: 0x253BC00 Offset: 0x253A200 VA: 0x18253BC00
	public Length ToLength() { }

	// RVA: 0x253BDD0 Offset: 0x253A3D0 VA: 0x18253BDD0
	public TimeValue ToTime() { }

	// RVA: 0x253BB70 Offset: 0x253A170 VA: 0x18253BB70
	public Angle ToAngle() { }

	// RVA: 0x253BE10 Offset: 0x253A410 VA: 0x18253BE10
	public static bool op_Equality(Dimension lhs, Dimension rhs) { }

	// RVA: 0x253BB00 Offset: 0x253A100 VA: 0x18253BB00 Slot: 4
	public bool Equals(Dimension other) { }

	// RVA: 0x253BA40 Offset: 0x253A040 VA: 0x18253BA40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x253BB30 Offset: 0x253A130 VA: 0x18253BB30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x253BC30 Offset: 0x253A230 VA: 0x18253BC30 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
[Serializable]
internal struct ScalableImage // TypeDefIndex: 4529
{
	// Fields
	public Texture2D normalImage; // 0x0
	public Texture2D highResolutionImage; // 0x8

	// Methods

	// RVA: 0x253DF50 Offset: 0x253C550 VA: 0x18253DF50 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct StylePropertyValue // TypeDefIndex: 4530
{
	// Fields
	public StyleSheet sheet; // 0x0
	public StyleValueHandle handle; // 0x8
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct ImageSource // TypeDefIndex: 4531
{
	// Fields
	public Texture2D texture; // 0x0
	public Sprite sprite; // 0x8
	public VectorImage vectorImage; // 0x10
	public RenderTexture renderTexture; // 0x18

	// Methods

	// RVA: 0x253CAB0 Offset: 0x253B0B0 VA: 0x18253CAB0
	public bool IsNull() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class StylePropertyReader // TypeDefIndex: 4533
{
	// Fields
	internal static StylePropertyReader.GetCursorIdFunction getCursorIdFunc; // 0x0
	private List<StylePropertyValue> m_Values; // 0x10
	private List<int> m_ValueCount; // 0x18
	private StyleVariableResolver m_Resolver; // 0x20
	private StyleSheet m_Sheet; // 0x28
	private StyleProperty[] m_Properties; // 0x30
	private StylePropertyId[] m_PropertyIds; // 0x38
	private int m_CurrentValueIndex; // 0x40
	private int m_CurrentPropertyIndex; // 0x44
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private StyleProperty <property>k__BackingField; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private StylePropertyId <propertyId>k__BackingField; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <valueCount>k__BackingField; // 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <dpiScaling>k__BackingField; // 0x58

	// Properties
	public StyleProperty property { get; set; }
	public StylePropertyId propertyId { get; set; }
	public int valueCount { get; set; }
	public float dpiScaling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public StyleProperty get_property() { }

	[CompilerGenerated]
	// RVA: 0x399810 Offset: 0x397E10 VA: 0x180399810
	private void set_property(StyleProperty value) { }

	[CompilerGenerated]
	// RVA: 0x3AA7E0 Offset: 0x3A8DE0 VA: 0x1803AA7E0
	public StylePropertyId get_propertyId() { }

	[CompilerGenerated]
	// RVA: 0x3AA880 Offset: 0x3A8E80 VA: 0x1803AA880
	private void set_propertyId(StylePropertyId value) { }

	[CompilerGenerated]
	// RVA: 0x464C80 Offset: 0x463280 VA: 0x180464C80
	public int get_valueCount() { }

	[CompilerGenerated]
	// RVA: 0x464C90 Offset: 0x463290 VA: 0x180464C90
	private void set_valueCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x187F580 Offset: 0x187DB80 VA: 0x18187F580
	public float get_dpiScaling() { }

	[CompilerGenerated]
	// RVA: 0x1F0CFA0 Offset: 0x1F0B5A0 VA: 0x181F0CFA0
	private void set_dpiScaling(float value) { }

	// RVA: 0x2542520 Offset: 0x2540B20 VA: 0x182542520
	public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1) { }

	// RVA: 0x25426F0 Offset: 0x2540CF0 VA: 0x1825426F0
	public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling = 1) { }

	// RVA: 0x253E970 Offset: 0x253CF70 VA: 0x18253E970
	public StylePropertyId MoveNextProperty() { }

	// RVA: 0x253E3E0 Offset: 0x253C9E0 VA: 0x18253E3E0
	public StylePropertyValue GetValue(int index) { }

	// RVA: 0x253E360 Offset: 0x253C960 VA: 0x18253E360
	public StyleValueType GetValueType(int index) { }

	// RVA: 0x253E500 Offset: 0x253CB00 VA: 0x18253E500
	public bool IsValueType(int index, StyleValueType type) { }

	// RVA: 0x253E460 Offset: 0x253CA60 VA: 0x18253E460
	public bool IsKeyword(int index, StyleValueKeyword keyword) { }

	// RVA: 0x253EAD0 Offset: 0x253D0D0 VA: 0x18253EAD0
	public string ReadAsString(int index) { }

	// RVA: 0x25407A0 Offset: 0x253EDA0 VA: 0x1825407A0
	public Length ReadLength(int index) { }

	// RVA: 0x2541AC0 Offset: 0x25400C0 VA: 0x182541AC0
	public TimeValue ReadTimeValue(int index) { }

	// RVA: 0x25420D0 Offset: 0x25406D0 VA: 0x1825420D0
	public Translate ReadTranslate(int index) { }

	// RVA: 0x2541CC0 Offset: 0x25402C0 VA: 0x182541CC0
	public TransformOrigin ReadTransformOrigin(int index) { }

	// RVA: 0x2541040 Offset: 0x253F640 VA: 0x182541040
	public Rotate ReadRotate(int index) { }

	// RVA: 0x25415A0 Offset: 0x253FBA0 VA: 0x1825415A0
	public Scale ReadScale(int index) { }

	// RVA: 0x253FEA0 Offset: 0x253E4A0 VA: 0x18253FEA0
	public float ReadFloat(int index) { }

	// RVA: 0x2540720 Offset: 0x253ED20 VA: 0x182540720
	public int ReadInt(int index) { }

	// RVA: 0x253F800 Offset: 0x253DE00 VA: 0x18253F800
	public Color ReadColor(int index) { }

	// RVA: 0x253FDA0 Offset: 0x253E3A0 VA: 0x18253FDA0
	public int ReadEnum(StyleEnumType enumType, int index) { }

	// RVA: 0x253FF20 Offset: 0x253E520 VA: 0x18253FF20
	public FontDefinition ReadFontDefinition(int index) { }

	// RVA: 0x2540430 Offset: 0x253EA30 VA: 0x182540430
	public Font ReadFont(int index) { }

	// RVA: 0x253F590 Offset: 0x253DB90 VA: 0x18253F590
	public Background ReadBackground(int index) { }

	// RVA: 0x253F920 Offset: 0x253DF20 VA: 0x18253F920
	public Cursor ReadCursor(int index) { }

	// RVA: 0x25416E0 Offset: 0x253FCE0 VA: 0x1825416E0
	public TextShadow ReadTextShadow(int index) { }

	// RVA: 0x253EB40 Offset: 0x253D140 VA: 0x18253EB40
	public BackgroundPosition ReadBackgroundPositionX(int index) { }

	// RVA: 0x253EB80 Offset: 0x253D180 VA: 0x18253EB80
	public BackgroundPosition ReadBackgroundPositionY(int index) { }

	// RVA: 0x253EBC0 Offset: 0x253D1C0 VA: 0x18253EBC0
	private BackgroundPosition ReadBackgroundPosition(int index, BackgroundPositionKeyword keyword) { }

	// RVA: 0x253EED0 Offset: 0x253D4D0 VA: 0x18253EED0
	public BackgroundRepeat ReadBackgroundRepeat(int index) { }

	// RVA: 0x253F250 Offset: 0x253D850 VA: 0x18253F250
	public BackgroundSize ReadBackgroundSize(int index) { }

	// RVA: 0x25408B0 Offset: 0x253EEB0 VA: 0x1825408B0
	public void ReadListEasingFunction(List<EasingFunction> list, int index) { }

	// RVA: 0x2540C80 Offset: 0x253F280 VA: 0x182540C80
	public void ReadListTimeValue(List<TimeValue> list, int index) { }

	// RVA: 0x2540AB0 Offset: 0x253F0B0 VA: 0x182540AB0
	public void ReadListStylePropertyName(List<StylePropertyName> list, int index) { }

	// RVA: 0x253E590 Offset: 0x253CB90 VA: 0x18253E590
	private void LoadProperties() { }

	// RVA: 0x2542620 Offset: 0x2540C20 VA: 0x182542620
	private void SetCurrentProperty() { }

	// RVA: 0x2541E10 Offset: 0x2540410 VA: 0x182541E10
	public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue) { }

	// RVA: 0x2541B70 Offset: 0x2540170 VA: 0x182541B70
	private static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal) { }

	// RVA: 0x2542230 Offset: 0x2540830 VA: 0x182542230
	public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x2541360 Offset: 0x253F960 VA: 0x182541360
	public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x2540E20 Offset: 0x253F420 VA: 0x182540E20
	public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) { }

	// RVA: 0x2542EC0 Offset: 0x25414C0 VA: 0x182542EC0
	private static bool TryReadEnum(StyleEnumType enumType, StylePropertyValue value, out int intValue) { }

	// RVA: 0x253FCD0 Offset: 0x253E2D0 VA: 0x18253FCD0
	private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value) { }

	// RVA: 0x253E9A0 Offset: 0x253CFA0 VA: 0x18253E9A0
	public static Angle ReadAngle(StylePropertyValue value) { }

	// RVA: 0x253ECD0 Offset: 0x253D2D0 VA: 0x18253ECD0
	public static BackgroundPosition ReadBackgroundPosition(int valCount, StylePropertyValue val1, StylePropertyValue val2, BackgroundPositionKeyword keyword) { }

	// RVA: 0x253F0C0 Offset: 0x253D6C0 VA: 0x18253F0C0
	public static BackgroundRepeat ReadBackgroundRepeat(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x253F340 Offset: 0x253D940 VA: 0x18253F340
	public static BackgroundSize ReadBackgroundSize(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x2542760 Offset: 0x2540D60 VA: 0x182542760
	internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source) { }

	// RVA: 0x2542F90 Offset: 0x2541590 VA: 0x182542F90
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct MatchResultInfo // TypeDefIndex: 4534
{
	// Fields
	public readonly bool success; // 0x0
	public readonly PseudoStates triggerPseudoMask; // 0x4
	public readonly PseudoStates dependencyPseudoMask; // 0x8

	// Methods

	// RVA: 0x253D1E0 Offset: 0x253B7E0 VA: 0x18253D1E0
	public void .ctor(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct SelectorMatchRecord // TypeDefIndex: 4535
{
	// Fields
	public StyleSheet sheet; // 0x0
	public int styleSheetIndexInStack; // 0x8
	public StyleComplexSelector complexSelector; // 0x10

	// Methods

	// RVA: 0x253E2A0 Offset: 0x253C8A0 VA: 0x18253E2A0
	public void .ctor(StyleSheet sheet, int styleSheetIndexInStack) { }

	// RVA: 0x253E130 Offset: 0x253C730 VA: 0x18253E130
	public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSelectorHelper // TypeDefIndex: 4536
{
	// Methods

	// RVA: 0x25449D0 Offset: 0x2542FD0 VA: 0x1825449D0
	public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) { }

	// RVA: 0x25447D0 Offset: 0x2542DD0 VA: 0x1825447D0
	public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult) { }

	// RVA: 0x2543F20 Offset: 0x2542520 VA: 0x182543F20
	private static void FastLookup(IDictionary<string, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record) { }

	// RVA: 0x25442F0 Offset: 0x25428F0 VA: 0x1825442F0
	public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetCache // TypeDefIndex: 4539
{
	// Fields
	private static StyleSheetCache.SheetHandleKeyComparer s_Comparer; // 0x0
	private static Dictionary<StyleSheetCache.SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache; // 0x8

	// Methods

	// RVA: 0x2544D90 Offset: 0x2543390 VA: 0x182544D90
	internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) { }

	// RVA: 0x2544F70 Offset: 0x2543570 VA: 0x182544F70
	internal static StylePropertyId[] GetPropertyIds(StyleRule rule) { }

	// RVA: 0x2544CA0 Offset: 0x25432A0 VA: 0x182544CA0
	private static StylePropertyId GetPropertyId(StyleRule rule, int index) { }

	// RVA: 0x2545040 Offset: 0x2543640 VA: 0x182545040
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetColor // TypeDefIndex: 4540
{
	// Fields
	private static Dictionary<string, Color32> s_NameToColor; // 0x0

	// Methods

	// RVA: 0x2545160 Offset: 0x2543760 VA: 0x182545160
	public static bool TryGetColor(string name, out Color color) { }

	// RVA: 0x2545140 Offset: 0x2543740 VA: 0x182545140
	private static Color32 HexToColor32(uint color) { }

	// RVA: 0x2545270 Offset: 0x2543870 VA: 0x182545270
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
[Extension]
internal static class StyleSheetExtensions // TypeDefIndex: 4541
{
	// Methods

	[Extension]
	// RVA: 0x2546D80 Offset: 0x2545380 VA: 0x182546D80
	public static string ReadAsString(StyleSheet sheet, StyleValueHandle handle) { }

	[Extension]
	// RVA: 0x2546D50 Offset: 0x2545350 VA: 0x182546D50
	public static bool IsVarFunction(StyleValueHandle handle) { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
[DebuggerDisplay("id = {id}, keyword = {keyword}, number = {number}, boolean = {boolean}, color = {color}, object = {resource}")]
internal struct StyleValue // TypeDefIndex: 4542
{
	// Fields
	public StylePropertyId id; // 0x0
	public StyleKeyword keyword; // 0x4
	public float number; // 0x8
	public Length length; // 0x8
	public Color color; // 0x8
	public GCHandle resource; // 0x8
	public BackgroundPosition position; // 0x8
	public BackgroundRepeat repeat; // 0x8
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct StyleValueManaged // TypeDefIndex: 4543
{
	// Fields
	public StylePropertyId id; // 0x0
	public StyleKeyword keyword; // 0x4
	public object value; // 0x8
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal enum MatchResultErrorCode // TypeDefIndex: 4544
{
	// Fields
	public int value__; // 0x0
	public const MatchResultErrorCode None = 0;
	public const MatchResultErrorCode Syntax = 1;
	public const MatchResultErrorCode EmptyValue = 2;
	public const MatchResultErrorCode ExpectedEndOfValue = 3;
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct MatchResult // TypeDefIndex: 4545
{
	// Fields
	public MatchResultErrorCode errorCode; // 0x0
	public string errorValue; // 0x8

	// Properties
	public bool success { get; }

	// Methods

	// RVA: 0x253D1F0 Offset: 0x253B7F0 VA: 0x18253D1F0
	public bool get_success() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal abstract class BaseStyleMatcher // TypeDefIndex: 4547
{
	// Fields
	protected static readonly Regex s_CustomIdentRegex; // 0x0
	private Stack<BaseStyleMatcher.MatchContext> m_ContextStack; // 0x10
	private BaseStyleMatcher.MatchContext m_CurrentContext; // 0x18

	// Properties
	public abstract int valueCount { get; }
	public abstract bool isCurrentVariable { get; }
	public abstract bool isCurrentComma { get; }
	public bool hasCurrent { get; }
	public int currentIndex { get; set; }
	public int matchedVariableCount { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract bool MatchKeyword(string keyword);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool MatchNumber();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract bool MatchInteger();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool MatchLength();

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract bool MatchPercentage();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract bool MatchColor();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract bool MatchResource();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract bool MatchUrl();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract bool MatchTime();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract bool MatchAngle();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract bool MatchCustomIdent();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int get_valueCount();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool get_isCurrentVariable();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_isCurrentComma();

	// RVA: 0x25399D0 Offset: 0x2537FD0 VA: 0x1825399D0
	public bool get_hasCurrent() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	public int get_currentIndex() { }

	// RVA: 0x3CB540 Offset: 0x3C9B40 VA: 0x1803CB540
	public void set_currentIndex(int value) { }

	// RVA: 0x553D30 Offset: 0x552330 VA: 0x180553D30
	public int get_matchedVariableCount() { }

	// RVA: 0x553D40 Offset: 0x552340 VA: 0x180553D40
	public void set_matchedVariableCount(int value) { }

	// RVA: 0x2538910 Offset: 0x2536F10 VA: 0x182538910
	protected void Initialize() { }

	// RVA: 0x25397E0 Offset: 0x2537DE0 VA: 0x1825397E0
	public void MoveNext() { }

	// RVA: 0x2539870 Offset: 0x2537E70 VA: 0x182539870
	public void SaveContext() { }

	// RVA: 0x2539820 Offset: 0x2537E20 VA: 0x182539820
	public void RestoreContext() { }

	// RVA: 0x25388C0 Offset: 0x2536EC0 VA: 0x1825388C0
	public void DropContext() { }

	// RVA: 0x2539640 Offset: 0x2537C40 VA: 0x182539640
	protected bool Match(Expression exp) { }

	// RVA: 0x2538F80 Offset: 0x2537580 VA: 0x182538F80
	private bool MatchExpression(Expression exp) { }

	// RVA: 0x2538E60 Offset: 0x2537460 VA: 0x182538E60
	private bool MatchExpressionWithMultiplier(Expression exp) { }

	// RVA: 0x25390A0 Offset: 0x25376A0 VA: 0x1825390A0
	private bool MatchGroup(Expression exp) { }

	// RVA: 0x25389A0 Offset: 0x2536FA0 VA: 0x1825389A0
	private bool MatchCombinator(Expression exp) { }

	// RVA: 0x2539510 Offset: 0x2537B10 VA: 0x182539510
	private bool MatchOr(Expression exp) { }

	// RVA: 0x25394F0 Offset: 0x2537AF0 VA: 0x1825394F0
	private bool MatchOrOr(Expression exp) { }

	// RVA: 0x2538960 Offset: 0x2536F60 VA: 0x182538960
	private bool MatchAndAnd(Expression exp) { }

	// RVA: 0x2539340 Offset: 0x2537940 VA: 0x182539340
	private int MatchMany(Expression exp) { }

	// RVA: 0x25391D0 Offset: 0x25377D0 VA: 0x1825391D0
	private int MatchManyByOrder(Expression exp, int* matchOrder) { }

	// RVA: 0x2539150 Offset: 0x2537750 VA: 0x182539150
	private bool MatchJuxtaposition(Expression exp) { }

	// RVA: 0x2538CE0 Offset: 0x25372E0 VA: 0x182538CE0
	private bool MatchDataType(Expression exp) { }

	// RVA: 0x2539950 Offset: 0x2537F50 VA: 0x182539950
	protected void .ctor() { }

	// RVA: 0x25398C0 Offset: 0x2537EC0 VA: 0x1825398C0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class StylePropertyValueMatcher : BaseStyleMatcher // TypeDefIndex: 4548
{
	// Fields
	private List<StylePropertyValue> m_Values; // 0x20

	// Properties
	private StylePropertyValue current { get; }
	public override int valueCount { get; }
	public override bool isCurrentVariable { get; }
	public override bool isCurrentComma { get; }

	// Methods

	// RVA: 0x2543D90 Offset: 0x2542390 VA: 0x182543D90
	private StylePropertyValue get_current() { }

	// RVA: 0x2543EE0 Offset: 0x25424E0 VA: 0x182543EE0 Slot: 15
	public override int get_valueCount() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 16
	public override bool get_isCurrentVariable() { }

	// RVA: 0x2543E30 Offset: 0x2542430 VA: 0x182543E30 Slot: 17
	public override bool get_isCurrentComma() { }

	// RVA: 0x2543A20 Offset: 0x2542020 VA: 0x182543A20
	public MatchResult Match(Expression exp, List<StylePropertyValue> values) { }

	// RVA: 0x25434B0 Offset: 0x2541AB0 VA: 0x1825434B0 Slot: 4
	protected override bool MatchKeyword(string keyword) { }

	// RVA: 0x2543410 Offset: 0x2541A10 VA: 0x182543410 Slot: 5
	protected override bool MatchNumber() { }

	// RVA: 0x2543410 Offset: 0x2541A10 VA: 0x182543410 Slot: 6
	protected override bool MatchInteger() { }

	// RVA: 0x25435C0 Offset: 0x2541BC0 VA: 0x1825435C0 Slot: 7
	protected override bool MatchLength() { }

	// RVA: 0x25436D0 Offset: 0x2541CD0 VA: 0x1825436D0 Slot: 8
	protected override bool MatchPercentage() { }

	// RVA: 0x25431A0 Offset: 0x25417A0 VA: 0x1825431A0 Slot: 9
	protected override bool MatchColor() { }

	// RVA: 0x25437E0 Offset: 0x2541DE0 VA: 0x1825437E0 Slot: 10
	protected override bool MatchResource() { }

	// RVA: 0x2543970 Offset: 0x2541F70 VA: 0x182543970 Slot: 11
	protected override bool MatchUrl() { }

	// RVA: 0x2543880 Offset: 0x2541E80 VA: 0x182543880 Slot: 12
	protected override bool MatchTime() { }

	// RVA: 0x25432D0 Offset: 0x25418D0 VA: 0x1825432D0 Slot: 14
	protected override bool MatchCustomIdent() { }

	// RVA: 0x2543090 Offset: 0x2541690 VA: 0x182543090 Slot: 13
	protected override bool MatchAngle() { }

	// RVA: 0x2543CE0 Offset: 0x25422E0 VA: 0x182543CE0
	public void .ctor() { }
}

