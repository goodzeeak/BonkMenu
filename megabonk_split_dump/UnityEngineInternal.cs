// Namespace: UnityEngineInternal
[Il2CppEagerStaticClassConstruction]
public struct MathfInternal // TypeDefIndex: 9404
{
	// Fields
	public static float FloatMinNormal; // 0x0
	public static float FloatMinDenormal; // 0x4
	public static bool IsFlushToZeroEnabled; // 0x8

	// Methods

	// RVA: 0x2307590 Offset: 0x2305B90 VA: 0x182307590
	private static void .cctor() { }
}

// Namespace: UnityEngineInternal
public enum TypeInferenceRules // TypeDefIndex: 9405
{
	// Fields
	public int value__; // 0x0
	public const TypeInferenceRules TypeReferencedByFirstArgument = 0;
	public const TypeInferenceRules TypeReferencedBySecondArgument = 1;
	public const TypeInferenceRules ArrayOfTypeReferencedByFirstArgument = 2;
	public const TypeInferenceRules TypeOfFirstArgument = 3;
}

// Namespace: UnityEngineInternal
[Usage(64)]
[Serializable]
public class TypeInferenceRuleAttribute : Attribute // TypeDefIndex: 9406
{
	// Fields
	private readonly string _rule; // 0x10

	// Methods

	// RVA: 0x23148B0 Offset: 0x2312EB0 VA: 0x1823148B0
	public void .ctor(TypeInferenceRules rule) { }

	// RVA: 0x34D560 Offset: 0x34BB60 VA: 0x18034D560
	public void .ctor(string rule) { }

	// RVA: 0x101AB70 Offset: 0x1019170 VA: 0x18101AB70 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngineInternal
public class GenericStack : Stack // TypeDefIndex: 9407
{
	// Methods

	// RVA: 0x22FD450 Offset: 0x22FBA50 VA: 0x1822FD450
	public void .ctor() { }
}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils // TypeDefIndex: 13863
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x26871A0 Offset: 0x26857A0 VA: 0x1826871A0
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x2686AD0 Offset: 0x26850D0 VA: 0x182686AD0
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x2686DC0 Offset: 0x26853C0 VA: 0x182686DC0
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x26872A0 Offset: 0x26858A0 VA: 0x1826872A0
	private static string URLDecode(string encoded) { }

	// RVA: 0x26873A0 Offset: 0x26859A0 VA: 0x1826873A0
	private static void .cctor() { }
}

