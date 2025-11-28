// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
public class ITilemap // TypeDefIndex: 14080
{
	// Fields
	internal static ITilemap s_Instance; // 0x0
	internal Tilemap m_Tilemap; // 0x10
	internal bool m_AddToList; // 0x18
	internal int m_RefreshCount; // 0x1C
	internal NativeArray<Vector3Int> m_RefreshPos; // 0x20

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: 0x24366E0 Offset: 0x2434CE0 VA: 0x1824366E0
	public void RefreshTile(Vector3Int position) { }

	[RequiredByNativeCode]
	// RVA: 0x2435FF0 Offset: 0x24345F0 VA: 0x182435FF0
	private static ITilemap CreateInstance() { }

	[RequiredByNativeCode]
	// RVA: 0x2436070 Offset: 0x2434670 VA: 0x182436070
	private static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2436450 Offset: 0x2434A50 VA: 0x182436450
	private static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr) { }
}

// Namespace: UnityEngine.Tilemaps
[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
[RequiredByNativeCode]
[Serializable]
public class Tile : TileBase // TypeDefIndex: 14082
{
	// Fields
	[SerializeField]
	private Sprite m_Sprite; // 0x18
	[SerializeField]
	private Color m_Color; // 0x20
	[SerializeField]
	private Matrix4x4 m_Transform; // 0x30
	[SerializeField]
	private GameObject m_InstancedGameObject; // 0x70
	[SerializeField]
	private TileFlags m_Flags; // 0x78
	[SerializeField]
	private Tile.ColliderType m_ColliderType; // 0x7C

	// Properties
	public Sprite sprite { get; set; }
	public Color color { get; set; }
	public Matrix4x4 transform { get; set; }
	public GameObject gameObject { get; set; }
	public TileFlags flags { get; set; }
	public Tile.ColliderType colliderType { get; set; }

	// Methods

	// RVA: 0x1096D50 Offset: 0x1095350 VA: 0x181096D50
	public Sprite get_sprite() { }

	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_sprite(Sprite value) { }

	// RVA: 0x2437200 Offset: 0x2435800 VA: 0x182437200
	public Color get_color() { }

	// RVA: 0x132E3D0 Offset: 0x132C9D0 VA: 0x18132E3D0
	public void set_color(Color value) { }

	// RVA: 0x2437220 Offset: 0x2435820 VA: 0x182437220
	public Matrix4x4 get_transform() { }

	// RVA: 0x2437250 Offset: 0x2435850 VA: 0x182437250
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x237B080 Offset: 0x2379680 VA: 0x18237B080
	public GameObject get_gameObject() { }

	// RVA: 0x4ACB50 Offset: 0x4AB150 VA: 0x1804ACB50
	public void set_gameObject(GameObject value) { }

	// RVA: 0x2437210 Offset: 0x2435810 VA: 0x182437210
	public TileFlags get_flags() { }

	// RVA: 0x18693A0 Offset: 0x18679A0 VA: 0x1818693A0
	public void set_flags(TileFlags value) { }

	// RVA: 0x24371F0 Offset: 0x24357F0 VA: 0x1824371F0
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0x1C5BAC0 Offset: 0x1C5A0C0 VA: 0x181C5BAC0
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x2437010 Offset: 0x2435610 VA: 0x182437010 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x2437170 Offset: 0x2435770 VA: 0x182437170
	public void .ctor() { }
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
public abstract class TileBase : ScriptableObject // TypeDefIndex: 14083
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2436A50 Offset: 0x2435050 VA: 0x182436A50 Slot: 4
	public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280 Slot: 5
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x2436970 Offset: 0x2434F70 VA: 0x182436970
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0x22F0DD0 Offset: 0x22EF3D0 VA: 0x1822F0DD0 Slot: 6
	public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	// RVA: 0x24368A0 Offset: 0x2434EA0 VA: 0x1824368A0
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCode]
	// RVA: 0x2436930 Offset: 0x2434F30 VA: 0x182436930
	private void GetTileAnimationDataRef(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData, ref bool hasAnimation) { }

	[RequiredByNativeCode]
	// RVA: 0x22F0DD0 Offset: 0x22EF3D0 VA: 0x1822F0DD0 Slot: 7
	public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	[RequiredByNativeCode]
	// RVA: 0x2436C20 Offset: 0x2435220 VA: 0x182436C20
	private void StartUpRef(Vector3Int position, ITilemap tilemap, GameObject go, ref bool startUpInvokedByUser) { }

	// RVA: 0x399470 Offset: 0x397A70 VA: 0x180399470
	protected void .ctor() { }
}

// Namespace: UnityEngine.Tilemaps
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeHeader("Modules/Grid/Public/Grid.h")]
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapTile.h")]
[NativeType(Header = "Modules/Tilemap/Public/Tilemap.h")]
public sealed class Tilemap : GridLayout // TypeDefIndex: 14086
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<Tilemap, Tilemap.SyncTile[]> tilemapTileChanged; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Tilemap, NativeArray<Vector3Int>> tilemapPositionsChanged; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Tilemap, NativeArray<Vector3Int>> loopEndedForTileAnimation; // 0x10
	private bool m_BufferSyncTile; // 0x18

	// Properties
	internal bool bufferSyncTile { get; }

	// Methods

	// RVA: 0x2437BA0 Offset: 0x24361A0 VA: 0x182437BA0
	internal bool get_bufferSyncTile() { }

	// RVA: 0x2437700 Offset: 0x2435D00 VA: 0x182437700
	internal static bool HasLoopEndedForTileAnimationCallback() { }

	// RVA: 0x2437460 Offset: 0x2435A60 VA: 0x182437460
	private void HandleLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr) { }

	// RVA: 0x24379A0 Offset: 0x2435FA0 VA: 0x1824379A0
	private void SendLoopEndedForTileAnimationCallback(NativeArray<Vector3Int> positions) { }

	// RVA: 0x2437780 Offset: 0x2435D80 VA: 0x182437780
	internal static bool HasSyncTileCallback() { }

	// RVA: 0x2437740 Offset: 0x2435D40 VA: 0x182437740
	internal static bool HasPositionsChangedCallback() { }

	// RVA: 0x24375C0 Offset: 0x2435BC0 VA: 0x1824375C0
	private void HandleSyncTileCallback(Tilemap.SyncTile[] syncTiles) { }

	// RVA: 0x2437510 Offset: 0x2435B10 VA: 0x182437510
	private void HandlePositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	// RVA: 0x2437B00 Offset: 0x2436100 VA: 0x182437B00
	private void SendTilemapTileChangedCallback(Tilemap.SyncTile[] syncTiles) { }

	// RVA: 0x2437A50 Offset: 0x2436050 VA: 0x182437A50
	private void SendTilemapPositionsChangedCallback(NativeArray<Vector3Int> positions) { }

	[NativeMethod(Name = "RefreshTileAsset")]
	// RVA: 0x2437810 Offset: 0x2435E10 VA: 0x182437810
	public void RefreshTile(Vector3Int position) { }

	[FreeFunction(Name = "TilemapBindings::RefreshTileAssetsNative", HasExplicitThis = True)]
	// RVA: 0x2437900 Offset: 0x2435F00 VA: 0x182437900
	internal void RefreshTilesNative(void* positions, int count) { }

	[RequiredByNativeCode]
	// RVA: 0x2437620 Offset: 0x2435C20 VA: 0x182437620
	internal void GetLoopEndedForTileAnimationCallbackSettings(ref bool hasEndLoopForTileAnimationCallback) { }

	[RequiredByNativeCode]
	// RVA: 0x2437460 Offset: 0x2435A60 VA: 0x182437460
	private void DoLoopEndedForTileAnimationCallback(int count, IntPtr positionsIntPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2437670 Offset: 0x2435C70 VA: 0x182437670
	internal void GetSyncTileCallbackSettings(ref Tilemap.SyncTileCallbackSettings settings) { }

	[RequiredByNativeCode]
	// RVA: 0x24375C0 Offset: 0x2435BC0 VA: 0x1824375C0
	private void DoSyncTileCallback(Tilemap.SyncTile[] syncTiles) { }

	[RequiredByNativeCode]
	// RVA: 0x2437510 Offset: 0x2435B10 VA: 0x182437510
	private void DoPositionsChangedCallback(int count, IntPtr positionsIntPtr) { }

	// RVA: 0x24377C0 Offset: 0x2435DC0 VA: 0x1824377C0
	private static void RefreshTile_Injected(IntPtr _unity_self, in Vector3Int position) { }

	// RVA: 0x24378A0 Offset: 0x2435EA0 VA: 0x1824378A0
	private static void RefreshTilesNative_Injected(IntPtr _unity_self, void* positions, int count) { }
}

// Namespace: UnityEngine.Tilemaps
[Flags]
public enum TileFlags // TypeDefIndex: 14087
{
	// Fields
	public int value__; // 0x0
	public const TileFlags None = 0;
	public const TileFlags LockColor = 1;
	public const TileFlags LockTransform = 2;
	public const TileFlags InstantiateGameObjectRuntimeOnly = 4;
	public const TileFlags KeepGameObjectRuntimeOnly = 8;
	public const TileFlags LockAll = 3;
}

// Namespace: UnityEngine.Tilemaps
[Flags]
public enum TileAnimationFlags // TypeDefIndex: 14088
{
	// Fields
	public int value__; // 0x0
	public const TileAnimationFlags None = 0;
	public const TileAnimationFlags LoopOnce = 1;
	public const TileAnimationFlags PauseAnimation = 2;
	public const TileAnimationFlags UpdatePhysics = 4;
	public const TileAnimationFlags UnscaledTime = 8;
}

// Namespace: UnityEngine.Tilemaps
[NativeHeader("Modules/Tilemap/TilemapRendererJobs.h")]
[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeType(Header = "Modules/Tilemap/Public/TilemapRenderer.h")]
[NativeHeader("Modules/Tilemap/Public/TilemapMarshalling.h")]
[RequireComponent(typeof(Tilemap))]
public sealed class TilemapRenderer : Renderer // TypeDefIndex: 14089
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2437380 Offset: 0x2435980 VA: 0x182437380
	internal void RegisterSpriteAtlasRegistered() { }

	[RequiredByNativeCode]
	// RVA: 0x24373F0 Offset: 0x24359F0 VA: 0x1824373F0
	internal void UnregisterSpriteAtlasRegistered() { }

	// RVA: 0x24372C0 Offset: 0x24358C0 VA: 0x1824372C0
	internal void OnSpriteAtlasRegistered(SpriteAtlas atlas) { }

	// RVA: 0x2437270 Offset: 0x2435870 VA: 0x182437270
	private static void OnSpriteAtlasRegistered_Injected(IntPtr _unity_self, IntPtr atlas) { }
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
public struct TileData // TypeDefIndex: 14090
{
	// Fields
	private int m_Sprite; // 0x0
	private Color m_Color; // 0x4
	private Matrix4x4 m_Transform; // 0x14
	private int m_GameObject; // 0x54
	private TileFlags m_Flags; // 0x58
	private Tile.ColliderType m_ColliderType; // 0x5C
	internal static readonly TileData Default; // 0x0

	// Properties
	public Sprite sprite { set; }
	public Color color { set; }
	public Matrix4x4 transform { set; }
	public GameObject gameObject { set; }
	public TileFlags flags { set; }
	public Tile.ColliderType colliderType { set; }

	// Methods

	// RVA: 0x2436F60 Offset: 0x2435560 VA: 0x182436F60
	public void set_sprite(Sprite value) { }

	// RVA: 0xD32910 Offset: 0xD30F10 VA: 0x180D32910
	public void set_color(Color value) { }

	// RVA: 0x2436FF0 Offset: 0x24355F0 VA: 0x182436FF0
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x2436ED0 Offset: 0x24354D0 VA: 0x182436ED0
	public void set_gameObject(GameObject value) { }

	// RVA: 0x399820 Offset: 0x397E20 VA: 0x180399820
	public void set_flags(TileFlags value) { }

	// RVA: 0x1C3C690 Offset: 0x1C3AC90 VA: 0x181C3C690
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x2436C60 Offset: 0x2435260 VA: 0x182436C60
	private static TileData CreateDefault() { }

	// RVA: 0x2436D90 Offset: 0x2435390 VA: 0x182436D90
	private static void .cctor() { }
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
internal struct TileDataNative // TypeDefIndex: 14091
{
	// Fields
	private int m_Sprite; // 0x0
	private Color m_Color; // 0x4
	private Matrix4x4 m_Transform; // 0x14
	private int m_GameObject; // 0x54
	private TileFlags m_Flags; // 0x58
	private Tile.ColliderType m_ColliderType; // 0x5C
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[Serializable]
public struct TileChangeData // TypeDefIndex: 14092
{
	// Fields
	[SerializeField]
	private Vector3Int m_Position; // 0x0
	[SerializeField]
	private Object m_TileAsset; // 0x10
	[SerializeField]
	private Color m_Color; // 0x18
	[SerializeField]
	private Matrix4x4 m_Transform; // 0x28
}

// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCode]
[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
public struct TileAnimationData // TypeDefIndex: 14093
{
	// Fields
	private Sprite[] m_AnimatedSprites; // 0x0
	private float m_AnimationSpeed; // 0x8
	private float m_AnimationStartTime; // 0xC
	private TileAnimationFlags m_Flags; // 0x10
}

