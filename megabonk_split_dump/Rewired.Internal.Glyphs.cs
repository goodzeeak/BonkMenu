// Namespace: Rewired.Internal.Glyphs
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal interface ITryGetGlyph // TypeDefIndex: 2835
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TryGetGlyph(out object value);
}

// Namespace: Rewired.Internal.Glyphs
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal class KeyedGlyph // TypeDefIndex: 2839
{
	// Fields
	public const uint INVALID_VERSION = 0;
	private uint OLhGZIwNEeTaYzXQTmECgTOBxtnl; // 0x10
	private uint ymRuYefIaYlAbyfaLIDwgInRvleuA; // 0x14
	private object kVcnBIDbiYnQyYYKchDriTQLroDG; // 0x18
	private bool kJVTIplGZSGiMeiPQPKCNcONULeUA; // 0x20
	private string CoZNuUAnUcTobiPmUHYUFeGBsTiRA; // 0x28

	// Properties
	public bool hasCachedValue { get; }
	public object cachedValue { get; set; }
	public string cachedKey { get; }

	// Methods

	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	public bool get_hasCachedValue() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public object get_cachedValue() { }

	// RVA: 0x17B15B0 Offset: 0x17AFBB0 VA: 0x1817B15B0
	public void set_cachedValue(object value) { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_cachedKey() { }

	// RVA: 0x1799860 Offset: 0x1797E60 VA: 0x181799860
	public void .ctor() { }

	// RVA: 0x17B1540 Offset: 0x17AFB40 VA: 0x1817B1540
	public void .ctor(KeyedGlyph ) { }

	// RVA: 0x17B1290 Offset: 0x17AF890 VA: 0x1817B1290
	public void Clear() { }

	// RVA: 0x17B12D0 Offset: 0x17AF8D0 VA: 0x1817B12D0
	public bool TryGetValue(string key, IGlyphProvider glyphProvider, uint glyphProviderVersion, uint userVersion, out bool versionChanged, out object result) { }
}

// Namespace: Rewired.Internal.Glyphs
[CustomObfuscation(rename = False)]
[CustomClassObfuscation(renamePubIntMembers = False, renamePrivateMembers = True)]
internal static class GlyphManager // TypeDefIndex: 2860
{
	// Fields
	private static GlyphManager.YuMVzxzTtokzHnnPhZtXNtJDPUvE uXFSZDHNNfhKDCZAdBVfjGIhMZAS; // 0x0
	private static StringBuilder vCHiqnEYwGayRerHsjYsdhcQiTgWA; // 0x8

	// Properties
	public static bool isEnabled { get; }
	public static uint version { get; }
	public static IGlyphProvider glyphProvider { get; set; }
	public static bool autoPrefetch { get; set; }

	// Methods

	// RVA: 0x17AF180 Offset: 0x17AD780 VA: 0x1817AF180
	public static void Initialize() { }

	// RVA: 0x17AECF0 Offset: 0x17AD2F0 VA: 0x1817AECF0
	public static void Deinitialize() { }

	// RVA: 0x17AFAB0 Offset: 0x17AE0B0 VA: 0x1817AFAB0
	public static bool get_isEnabled() { }

	// RVA: 0x17AFB00 Offset: 0x17AE100 VA: 0x1817AFB00
	public static uint get_version() { }

	// RVA: 0x17AFA60 Offset: 0x17AE060 VA: 0x1817AFA60
	public static IGlyphProvider get_glyphProvider() { }

	// RVA: 0x17AFCF0 Offset: 0x17AE2F0 VA: 0x1817AFCF0
	public static void set_glyphProvider(IGlyphProvider value) { }

	// RVA: 0x17AFA10 Offset: 0x17AE010 VA: 0x1817AFA10
	public static bool get_autoPrefetch() { }

	// RVA: 0x17AFC40 Offset: 0x17AE240 VA: 0x1817AFC40
	public static void set_autoPrefetch(bool value) { }

	// RVA: 0x17AEC40 Offset: 0x17AD240 VA: 0x1817AEC40
	public static void Add(IPrefetch obj, ref Id id) { }

	// RVA: 0x17AF780 Offset: 0x17ADD80 VA: 0x1817AF780
	public static bool Remove(ref Id id) { }

	// RVA: 0x17AF600 Offset: 0x17ADC00 VA: 0x1817AF600
	public static void Prefetch() { }

	// RVA: 0x17AF690 Offset: 0x17ADC90 VA: 0x1817AF690
	public static void Reload() { }

	// RVA: 0x17AFB50 Offset: 0x17AE150 VA: 0x1817AFB50
	private static void oVbpRFVRHrRrUxYkJsLoqpJJplYI() { }

	// RVA: 0x17AF830 Offset: 0x17ADE30 VA: 0x1817AF830
	public static bool TryGetCachedGlyph(KeyedGlyph keyedGlyph, uint glyphProviderVersion, uint dependenciesVersion, out bool glyphProviderVersionChanged, out object result) { }

	// RVA: 0x17AF900 Offset: 0x17ADF00 VA: 0x1817AF900
	public static bool TryGetGlyph(KeyedGlyph keyedGlyph, string key, uint glyphProviderVersion, uint dependenciesVersion, out object result) { }

	// RVA: 0x17AED50 Offset: 0x17AD350 VA: 0x1817AED50
	public static GlyphManager.GetAndUpdateGlyphResultFlags GetAndUpdateGlyph(KeyedGlyph keyedGlyph, IReadOnlyList<string> parentKeys, string keyCategory, out object result) { }

	// RVA: 0x17AEEF0 Offset: 0x17AD4F0 VA: 0x1817AEEF0
	public static GlyphManager.GetAndUpdateGlyphResultFlags GetAndUpdateGlyph(KeyedGlyph keyedGlyph, string key, string keyCategory, IReadOnlyList<string> parentKeys, out object result) { }

	// RVA: 0x17AF3C0 Offset: 0x17AD9C0 VA: 0x1817AF3C0
	private static bool PIjHoYYbvQzcgOaOtLGODcUkSPYK(KeyedGlyph , IReadOnlyList<string> , string , out object ) { }

	// RVA: 0x17AFDB0 Offset: 0x17AE3B0 VA: 0x1817AFDB0
	private static bool tbpOccAAIzPZRpYQiRMYcYuPoKTJ(KeyedGlyph , string , string , IReadOnlyList<string> , out object ) { }

	[CustomObfuscation(rename = False)]
	// RVA: 0x17AF0B0 Offset: 0x17AD6B0 VA: 0x1817AF0B0
	public static StringBuilder GetSharedStringBuilder() { }
}

