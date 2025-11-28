// Namespace: UnityEngine.U2D
[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
[RequiredByNativeCode]
[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeType(1, "ScriptingSpriteBone")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[Serializable]
public struct SpriteBone // TypeDefIndex: 9801
{
	// Fields
	[SerializeField]
	[NativeName("name")]
	private string m_Name; // 0x0
	[SerializeField]
	[NativeName("guid")]
	private string m_Guid; // 0x8
	[NativeName("position")]
	[SerializeField]
	private Vector3 m_Position; // 0x10
	[NativeName("rotation")]
	[SerializeField]
	private Quaternion m_Rotation; // 0x1C
	[SerializeField]
	[NativeName("length")]
	private float m_Length; // 0x2C
	[SerializeField]
	[NativeName("parentId")]
	private int m_ParentId; // 0x30
	[SerializeField]
	[NativeName("color")]
	private Color32 m_Color; // 0x34
}

// Namespace: UnityEngine.U2D
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[StaticAccessor("GetSpriteAtlasManager()", 0)]
public class SpriteAtlasManager // TypeDefIndex: 9802
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<SpriteAtlas> atlasRegistered; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2361820 Offset: 0x235FE20 VA: 0x182361820
	private static bool RequestAtlas(string tag) { }

	[CompilerGenerated]
	// RVA: 0x23618D0 Offset: 0x235FED0 VA: 0x1823618D0
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGenerated]
	// RVA: 0x23619B0 Offset: 0x235FFB0 VA: 0x1823619B0
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[RequiredByNativeCode]
	// RVA: 0x2361710 Offset: 0x235FD10 VA: 0x182361710
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x23617B0 Offset: 0x235FDB0 VA: 0x1823617B0
	internal static void Register(SpriteAtlas spriteAtlas) { }

	// RVA: 0x2361770 Offset: 0x235FD70 VA: 0x182361770
	private static void Register_Injected(IntPtr spriteAtlas) { }
}

// Namespace: UnityEngine.U2D
[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
public class SpriteAtlas : Object // TypeDefIndex: 9803
{
	// Methods

	// RVA: 0x2361AE0 Offset: 0x23600E0 VA: 0x182361AE0
	public bool CanBindTo(Sprite sprite) { }

	// RVA: 0x2361C10 Offset: 0x2360210 VA: 0x182361C10
	public Sprite GetSprite(string name) { }

	// RVA: 0x2361A90 Offset: 0x2360090 VA: 0x182361A90
	private static bool CanBindTo_Injected(IntPtr _unity_self, IntPtr sprite) { }

	// RVA: 0x2361BC0 Offset: 0x23601C0 VA: 0x182361BC0
	private static IntPtr GetSprite_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }
}

// Namespace: UnityEngine.U2D
[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeType(Header = "Modules/SpriteShape/Public/SpriteShapeRenderer.h")]
public class SpriteShapeRenderer : Renderer // TypeDefIndex: 14291
{}

