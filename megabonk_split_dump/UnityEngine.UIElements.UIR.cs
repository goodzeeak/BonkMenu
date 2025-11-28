// Namespace: UnityEngine.UIElements.UIR
internal struct GfxUpdateBufferRange // TypeDefIndex: 4346
{
	// Fields
	public uint offsetFromWriteStart; // 0x0
	public uint size; // 0x4
	public UIntPtr source; // 0x8
}

// Namespace: UnityEngine.UIElements.UIR
internal struct DrawBufferRange // TypeDefIndex: 4347
{
	// Fields
	public int firstIndex; // 0x0
	public int indexCount; // 0x4
	public int minIndexVal; // 0x8
	public int vertsReferenced; // 0xC
}

// Namespace: UnityEngine.UIElements.UIR
[VisibleToOtherModules(new[] { "Unity.UIElements" })]
[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRendererUtility.h")]
internal class Utility // TypeDefIndex: 4350
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<bool> GraphicsResourcesRecreate; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action EngineUpdate; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action FlushPendingResources; // 0x10
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x18

	// Methods

	[CompilerGenerated]
	// RVA: 0x24F90C0 Offset: 0x24F76C0 VA: 0x1824F90C0
	public static void add_GraphicsResourcesRecreate(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x24F93D0 Offset: 0x24F79D0 VA: 0x1824F93D0
	public static void remove_GraphicsResourcesRecreate(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x24F8EC0 Offset: 0x24F74C0 VA: 0x1824F8EC0
	public static void add_EngineUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0x24F91D0 Offset: 0x24F77D0 VA: 0x1824F91D0
	public static void remove_EngineUpdate(Action value) { }

	[CompilerGenerated]
	// RVA: 0x24F8FC0 Offset: 0x24F75C0 VA: 0x1824F8FC0
	public static void add_FlushPendingResources(Action value) { }

	[CompilerGenerated]
	// RVA: 0x24F92D0 Offset: 0x24F78D0 VA: 0x1824F92D0
	public static void remove_FlushPendingResources(Action value) { }

	[RequiredByNativeCode]
	// RVA: 0x24F8B70 Offset: 0x24F7170 VA: 0x1824F8B70
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[RequiredByNativeCode]
	// RVA: 0x24F8A70 Offset: 0x24F7070 VA: 0x1824F8A70
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCode]
	// RVA: 0x24F8B00 Offset: 0x24F7100 VA: 0x1824F8B00
	internal static void RaiseFlushPendingResources() { }

	[ThreadSafe]
	// RVA: 0x24F84C0 Offset: 0x24F6AC0 VA: 0x1824F84C0
	private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer) { }

	[ThreadSafe]
	// RVA: 0x24F86A0 Offset: 0x24F6CA0 VA: 0x1824F86A0
	private static void FreeBuffer(IntPtr buffer) { }

	[ThreadSafe]
	// RVA: 0x24F8DB0 Offset: 0x24F73B0 VA: 0x1824F8DB0
	private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd) { }

	[ThreadSafe]
	// RVA: 0x24F8890 Offset: 0x24F6E90 VA: 0x1824F8890
	public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes) { }

	[ThreadSafe]
	// RVA: 0x24F8630 Offset: 0x24F6C30 VA: 0x1824F8630
	public static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl) { }

	[ThreadSafe]
	// RVA: 0x24F8C20 Offset: 0x24F7220 VA: 0x1824F8C20
	public static void SetPropertyBlock(MaterialPropertyBlock props) { }

	[ThreadSafe]
	// RVA: 0x24F8CD0 Offset: 0x24F72D0 VA: 0x1824F8CD0
	public static void SetScissorRect(RectInt scissorRect) { }

	[ThreadSafe]
	// RVA: 0x24F8600 Offset: 0x24F6C00 VA: 0x1824F8600
	public static void DisableScissor() { }

	[ThreadSafe]
	// RVA: 0x24F8590 Offset: 0x24F6B90 VA: 0x1824F8590
	public static IntPtr CreateStencilState(StencilState stencilState) { }

	[ThreadSafe]
	// RVA: 0x24F8D40 Offset: 0x24F7340 VA: 0x1824F8D40
	public static void SetStencilState(IntPtr stencilState, int stencilRef) { }

	[ThreadSafe]
	// RVA: 0x24F8970 Offset: 0x24F6F70 VA: 0x1824F8970
	public static bool HasMappedBufferRange() { }

	[ThreadSafe]
	// RVA: 0x24F89A0 Offset: 0x24F6FA0 VA: 0x1824F89A0
	public static uint InsertCPUFence() { }

	[ThreadSafe]
	// RVA: 0x24F8510 Offset: 0x24F6B10 VA: 0x1824F8510
	public static bool CPUFencePassed(uint fence) { }

	[ThreadSafe]
	// RVA: 0x24F8E20 Offset: 0x24F7420 VA: 0x1824F8E20
	public static void WaitForCPUFencePassed(uint fence) { }

	[ThreadSafe]
	// RVA: 0x24F8D80 Offset: 0x24F7380 VA: 0x1824F8D80
	public static void SyncRenderThread() { }

	[ThreadSafe]
	// RVA: 0x24F8720 Offset: 0x24F6D20 VA: 0x1824F8720
	public static RectInt GetActiveViewport() { }

	[ThreadSafe]
	// RVA: 0x24F8A10 Offset: 0x24F7010 VA: 0x1824F8A10
	public static void ProfileDrawChainBegin() { }

	[ThreadSafe]
	// RVA: 0x24F8A40 Offset: 0x24F7040 VA: 0x1824F8A40
	public static void ProfileDrawChainEnd() { }

	// RVA: 0x24F89D0 Offset: 0x24F6FD0 VA: 0x1824F89D0
	public static void NotifyOfUIREvents(bool subscribe) { }

	[ThreadSafe]
	// RVA: 0x24F87D0 Offset: 0x24F6DD0 VA: 0x1824F87D0
	public static Matrix4x4 GetUnityProjectionMatrix() { }

	// RVA: 0x24F8E60 Offset: 0x24F7460 VA: 0x1824F8E60
	private static void .cctor() { }

	// RVA: 0x24F8850 Offset: 0x24F6E50 VA: 0x1824F8850
	private static IntPtr GetVertexDeclaration_Injected(ref ManagedSpanWrapper vertexAttributes) { }

	// RVA: 0x24F8BE0 Offset: 0x24F71E0 VA: 0x1824F8BE0
	private static void SetPropertyBlock_Injected(IntPtr props) { }

	// RVA: 0x24F8C90 Offset: 0x24F7290 VA: 0x1824F8C90
	private static void SetScissorRect_Injected(in RectInt scissorRect) { }

	// RVA: 0x24F8550 Offset: 0x24F6B50 VA: 0x1824F8550
	private static IntPtr CreateStencilState_Injected(in StencilState stencilState) { }

	// RVA: 0x24F86E0 Offset: 0x24F6CE0 VA: 0x1824F86E0
	private static void GetActiveViewport_Injected(out RectInt ret) { }

	// RVA: 0x24F8790 Offset: 0x24F6D90 VA: 0x1824F8790
	private static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret) { }
}

// Namespace: UnityEngine.UIElements.UIR
[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRendererJobProcessor.h")]
internal static class JobProcessor // TypeDefIndex: 4351
{
	// Methods

	// RVA: 0x24F0FD0 Offset: 0x24EF5D0 VA: 0x1824F0FD0
	internal static JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x24F0E70 Offset: 0x24EF470 VA: 0x1824F0E70
	internal static JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x24F0F20 Offset: 0x24EF520 VA: 0x1824F0F20
	internal static JobHandle ScheduleCopyMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x24F0F80 Offset: 0x24EF580 VA: 0x1824F0F80
	private static void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	// RVA: 0x24F0E20 Offset: 0x24EF420 VA: 0x1824F0E20
	private static void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	// RVA: 0x24F0ED0 Offset: 0x24EF4D0 VA: 0x1824F0ED0
	private static void ScheduleCopyMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class GCHandlePool : IDisposable // TypeDefIndex: 4352
{
	// Fields
	private List<GCHandle> m_Handles; // 0x10
	private int m_UsedHandlesCount; // 0x18
	private readonly int k_AllocBatchSize; // 0x1C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x20

	// Properties
	internal bool disposed { get; set; }

	// Methods

	// RVA: 0x24F0D80 Offset: 0x24EF380 VA: 0x1824F0D80
	public void .ctor(int capacity = 256, int allocBatchSize = 64) { }

	// RVA: 0x24F0AF0 Offset: 0x24EF0F0 VA: 0x1824F0AF0
	public GCHandle Get(object target) { }

	// RVA: 0x24F0AC0 Offset: 0x24EF0C0 VA: 0x1824F0AC0
	public IntPtr GetIntPtr(object target) { }

	// RVA: 0x24F0CA0 Offset: 0x24EF2A0 VA: 0x1824F0CA0
	public void ReturnAll() { }

	[CompilerGenerated]
	// RVA: 0x38E180 Offset: 0x38C780 VA: 0x18038E180
	internal bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x38E200 Offset: 0x38C800 VA: 0x18038E200
	private void set_disposed(bool value) { }

	// RVA: 0x24F0900 Offset: 0x24EEF00 VA: 0x1824F0900 Slot: 4
	public void Dispose() { }

	// RVA: 0x24F0960 Offset: 0x24EEF60 VA: 0x1824F0960
	private void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class Allocator2D // TypeDefIndex: 4356
{
	// Fields
	private readonly Vector2Int m_MinSize; // 0x10
	private readonly Vector2Int m_MaxSize; // 0x18
	private readonly Vector2Int m_MaxAllocSize; // 0x20
	private readonly int m_RowHeightBias; // 0x28
	private readonly Allocator2D.Row[] m_Rows; // 0x30
	private readonly List<Allocator2D.Area> m_Areas; // 0x38

	// Methods

	// RVA: 0x24EA110 Offset: 0x24E8710 VA: 0x1824EA110
	public void .ctor(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) { }

	// RVA: 0x24E9BD0 Offset: 0x24E81D0 VA: 0x1824E9BD0
	public bool TryAllocate(int width, int height, out Allocator2D.Alloc2D alloc2D) { }

	// RVA: 0x24E9960 Offset: 0x24E7F60 VA: 0x1824E9960
	public void Free(Allocator2D.Alloc2D alloc2D) { }

	// RVA: 0x24E95D0 Offset: 0x24E7BD0 VA: 0x1824E95D0
	private static void BuildAreas(List<Allocator2D.Area> areas, Vector2Int minSize, Vector2Int maxSize) { }

	// RVA: 0x24E9880 Offset: 0x24E7E80 VA: 0x1824E9880
	private static Vector2Int ComputeMaxAllocSize(List<Allocator2D.Area> areas, int rowHeightBias) { }

	// RVA: 0x24E9810 Offset: 0x24E7E10 VA: 0x1824E9810
	private static Allocator2D.Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal enum SerializedCommandType // TypeDefIndex: 4357
{
	// Fields
	public int value__; // 0x0
	public const SerializedCommandType DrawRanges = 0;
	public const SerializedCommandType SetTexture = 1;
	public const SerializedCommandType ApplyBatchProps = 2;
}

// Namespace: UnityEngine.UIElements.UIR
internal struct SerializedCommand // TypeDefIndex: 4358
{
	// Fields
	public SerializedCommandType type; // 0x0
	public IntPtr vertexBuffer; // 0x8
	public IntPtr indexBuffer; // 0x10
	public int firstRange; // 0x18
	public int rangeCount; // 0x1C
	public int textureName; // 0x20
	public Texture texture; // 0x28
	public int gpuDataOffset; // 0x30
	public Vector4 gpuData0; // 0x34
	public Vector4 gpuData1; // 0x44
}

// Namespace: UnityEngine.UIElements.UIR
internal class CommandList : IDisposable // TypeDefIndex: 4359
{
	// Fields
	public VisualElement m_Owner; // 0x10
	private readonly IntPtr m_VertexDecl; // 0x18
	private readonly IntPtr m_StencilState; // 0x20
	public MaterialPropertyBlock constantProps; // 0x28
	public MaterialPropertyBlock batchProps; // 0x30
	public GCHandle handle; // 0x38
	private List<SerializedCommand> m_Commands; // 0x40
	private Vector4[] m_GpuTextureData; // 0x48
	private NativeList<DrawBufferRange> m_DrawRanges; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x58

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x24EBEC0 Offset: 0x24EA4C0 VA: 0x1824EBEC0
	public void .ctor(VisualElement owner, IntPtr vertexDecl, IntPtr stencilState) { }

	// RVA: 0x24EBC90 Offset: 0x24EA290 VA: 0x1824EBC90
	public void Reset(VisualElement newOwner) { }

	// RVA: 0x24EB890 Offset: 0x24E9E90 VA: 0x1824EB890
	public void Execute() { }

	// RVA: 0x24EBDB0 Offset: 0x24EA3B0 VA: 0x1824EBDB0
	public void SetTexture(int name, Texture texture, int gpuDataOffset, Vector4 gpuData0, Vector4 gpuData1) { }

	// RVA: 0x24EB4E0 Offset: 0x24E9AE0 VA: 0x1824EB4E0
	public void ApplyBatchProps() { }

	// RVA: 0x24EB6F0 Offset: 0x24E9CF0 VA: 0x1824EB6F0
	public void DrawRanges(Utility.GPUBuffer<ushort> ib, Utility.GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges) { }

	[CompilerGenerated]
	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x3B9A60 Offset: 0x3B8060 VA: 0x1803B9A60
	private void set_disposed(bool value) { }

	// RVA: 0x24EB640 Offset: 0x24E9C40 VA: 0x1824EB640 Slot: 4
	public void Dispose() { }

	// RVA: 0x24EB5B0 Offset: 0x24E9BB0 VA: 0x1824EB5B0
	protected void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.UIElements.UIR
[Extension]
internal static class CommandManipulator // TypeDefIndex: 4360
{
	// Methods

	[Extension]
	// RVA: 0x24ED210 Offset: 0x24EB810 VA: 0x1824ED210
	private static bool IsParentOrAncestorOf(VisualElement ve, VisualElement child) { }

	// RVA: 0x24ED7C0 Offset: 0x24EBDC0 VA: 0x1824ED7C0
	public static void ReplaceCommands(RenderChain renderChain, VisualElement ve, EntryProcessor processor) { }

	// RVA: 0x24ECC60 Offset: 0x24EB260 VA: 0x1824ECC60
	private static void FindHeadCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	// RVA: 0x24ECED0 Offset: 0x24EB4D0 VA: 0x1824ECED0
	private static void FindTailCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	// RVA: 0x24ED2B0 Offset: 0x24EB8B0 VA: 0x1824ED2B0
	private static void RemoveChain(RenderChain renderChain, RenderChainCommand first, RenderChainCommand last) { }

	// RVA: 0x24EDCC0 Offset: 0x24EC2C0 VA: 0x1824EDCC0
	public static void ResetCommands(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x24ED0B0 Offset: 0x24EB6B0 VA: 0x1824ED0B0
	private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, RenderChainCommand prev, RenderChainCommand next) { }

	// RVA: 0x24EC090 Offset: 0x24EA690 VA: 0x1824EC090
	public static void DisableElementRendering(RenderChain renderChain, VisualElement ve, bool renderingDisabled) { }

	// RVA: 0x24ED3B0 Offset: 0x24EB9B0 VA: 0x1824ED3B0
	private static void RemoveSingleCommand(RenderChain renderChain, VisualElement ve, RenderChainCommand cmd) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class DetachedAllocator // TypeDefIndex: 4361
{
	// Fields
	private TempAllocator<Vertex> m_VertsPool; // 0x10
	private TempAllocator<ushort> m_IndexPool; // 0x18
	private List<MeshWriteData> m_MeshWriteDataPool; // 0x20
	private int m_MeshWriteDataCount; // 0x28
	private bool m_Disposed; // 0x2C

	// Methods

	// RVA: 0x24F05C0 Offset: 0x24EEBC0 VA: 0x1824F05C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x24F0670 Offset: 0x24EEC70 VA: 0x1824F0670
	protected void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal abstract class BaseElementBuilder // TypeDefIndex: 4362
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool RequiresStencilMask(VisualElement ve);

	// RVA: 0x24EA4A0 Offset: 0x24E8AA0 VA: 0x1824EA4A0
	public void Build(MeshGenerationContext mgc) { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void DrawVisualElementBackground(MeshGenerationContext mgc);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void DrawVisualElementBorder(MeshGenerationContext mgc);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void DrawVisualElementStencilMask(MeshGenerationContext mgc);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ScheduleMeshGenerationJobs(MeshGenerationContext mgc);

	// RVA: 0x24EAC40 Offset: 0x24E9240 VA: 0x1824EAC40
	private void PushVisualElementClipping(MeshGenerationContext mgc) { }

	// RVA: 0x24EAB40 Offset: 0x24E9140 VA: 0x1824EAB40
	private static void PopVisualElementClipping(MeshGenerationContext mgc) { }

	// RVA: 0x24EAA40 Offset: 0x24E9040 VA: 0x1824EAA40
	private static void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class DefaultElementBuilder : BaseElementBuilder // TypeDefIndex: 4363
{
	// Fields
	private RenderChain m_RenderChain; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(RenderChain renderChain) { }

	// RVA: 0x24F0450 Offset: 0x24EEA50 VA: 0x1824F0450 Slot: 4
	public override bool RequiresStencilMask(VisualElement ve) { }

	// RVA: 0x24EE000 Offset: 0x24EC600 VA: 0x1824EE000 Slot: 5
	protected override void DrawVisualElementBackground(MeshGenerationContext mgc) { }

	// RVA: 0x24EF570 Offset: 0x24EDB70 VA: 0x1824EF570 Slot: 6
	protected override void DrawVisualElementBorder(MeshGenerationContext mgc) { }

	// RVA: 0x24EFD30 Offset: 0x24EE330 VA: 0x1824EFD30 Slot: 7
	protected override void DrawVisualElementStencilMask(MeshGenerationContext mgc) { }

	// RVA: 0x24EFDD0 Offset: 0x24EE3D0 VA: 0x1824EFDD0
	private static void GenerateStencilClipEntryForRoundedRectBackground(MeshGenerationContext mgc) { }

	// RVA: 0x24F04D0 Offset: 0x24EEAD0 VA: 0x1824F04D0 Slot: 8
	public override void ScheduleMeshGenerationJobs(MeshGenerationContext mgc) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class MeshHandle : LinkedPoolItem<MeshHandle> // TypeDefIndex: 4364
{
	// Fields
	internal Alloc allocVerts; // 0x18
	internal Alloc allocIndices; // 0x30
	internal uint triangleCount; // 0x48
	internal Page allocPage; // 0x50
	internal uint allocTime; // 0x58
	internal uint updateAllocID; // 0x5C

	// Methods

	// RVA: 0x24F1030 Offset: 0x24EF630 VA: 0x1824F1030
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class UIRenderDevice : IDisposable // TypeDefIndex: 4371
{
	// Fields
	private readonly bool m_MockDevice; // 0x10
	private IntPtr m_DefaultStencilState; // 0x18
	private IntPtr m_VertexDecl; // 0x20
	private Page m_FirstPage; // 0x28
	private uint m_NextPageVertexCount; // 0x30
	private uint m_LargeMeshVertexCount; // 0x34
	private float m_IndexToVertexCountRatio; // 0x38
	private List<List<UIRenderDevice.AllocToFree>> m_DeferredFrees; // 0x40
	private List<List<UIRenderDevice.AllocToUpdate>> m_Updates; // 0x48
	private List<CommandList>[] m_CommandLists; // 0x50
	private uint[] m_Fences; // 0x58
	private MaterialPropertyBlock m_ConstantProps; // 0x60
	private MaterialPropertyBlock m_BatchProps; // 0x68
	private uint m_FrameIndex; // 0x70
	private uint m_NextUpdateID; // 0x74
	private UIRenderDevice.DrawStatistics m_DrawStats; // 0x78
	private readonly LinkedPool<MeshHandle> m_MeshHandles; // 0xA8
	private readonly DrawParams m_DrawParams; // 0xB0
	private readonly TextureSlotManager m_TextureSlotManager; // 0xB8
	private static LinkedList<UIRenderDevice.DeviceToFree> m_DeviceFreeQueue; // 0x0
	private static int m_ActiveDeviceCount; // 0x8
	private static bool m_SubscribedToNotifications; // 0xC
	private static bool m_SynchronousFree; // 0xD
	private static readonly int s_GradientSettingsTexID; // 0x10
	private static readonly int s_ShaderInfoTexID; // 0x14
	private static ProfilerMarker s_MarkerAllocate; // 0x18
	private static ProfilerMarker s_MarkerFree; // 0x20
	private static ProfilerMarker s_MarkerAdvanceFrame; // 0x28
	private static ProfilerMarker s_MarkerFence; // 0x30
	private static ProfilerMarker s_MarkerBeforeDraw; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <breakBatches>k__BackingField; // 0xC0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isFlat>k__BackingField; // 0xC1
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <drawsInCameras>k__BackingField; // 0xC2
	internal int currentFrameCommandListCount; // 0xC4
	private static Texture2D s_DefaultShaderInfoTexFloat; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0xC8

	// Properties
	internal static uint maxVerticesPerPage { get; }
	internal bool breakBatches { get; set; }
	internal bool isFlat { get; set; }
	internal bool drawsInCameras { get; set; }
	internal uint frameIndex { get; }
	internal List<CommandList>[] commandLists { get; }
	internal List<CommandList> currentFrameCommandLists { get; }
	internal static Texture2D defaultShaderInfoTexFloat { get; }
	private bool fullyCreated { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x1434130 Offset: 0x1432730 VA: 0x181434130
	internal static uint get_maxVerticesPerPage() { }

	[CompilerGenerated]
	// RVA: 0x1AA21F0 Offset: 0x1AA07F0 VA: 0x181AA21F0
	internal bool get_breakBatches() { }

	[CompilerGenerated]
	// RVA: 0x24F83B0 Offset: 0x24F69B0 VA: 0x1824F83B0
	internal void set_breakBatches(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24F83A0 Offset: 0x24F69A0 VA: 0x1824F83A0
	internal bool get_isFlat() { }

	[CompilerGenerated]
	// RVA: 0x24F83D0 Offset: 0x24F69D0 VA: 0x1824F83D0
	internal void set_isFlat(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24F8380 Offset: 0x24F6980 VA: 0x1824F8380
	internal bool get_drawsInCameras() { }

	[CompilerGenerated]
	// RVA: 0x24F83C0 Offset: 0x24F69C0 VA: 0x1824F83C0
	internal void set_drawsInCameras(bool value) { }

	// RVA: 0x4A42E0 Offset: 0x4A28E0 VA: 0x1804A42E0
	internal uint get_frameIndex() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	internal List<CommandList>[] get_commandLists() { }

	// RVA: 0x24F7D70 Offset: 0x24F6370 VA: 0x1824F7D70
	internal List<CommandList> get_currentFrameCommandLists() { }

	// RVA: 0x24F7290 Offset: 0x24F5890 VA: 0x1824F7290
	private static void .cctor() { }

	// RVA: 0x24F7D50 Offset: 0x24F6350 VA: 0x1824F7D50
	public void .ctor(uint initialVertexCapacity = 0, uint initialIndexCapacity = 0) { }

	// RVA: 0x24F76F0 Offset: 0x24F5CF0 VA: 0x1824F76F0
	protected void .ctor(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice) { }

	// RVA: 0x24F7DC0 Offset: 0x24F63C0 VA: 0x1824F7DC0
	internal static Texture2D get_defaultShaderInfoTexFloat() { }

	// RVA: 0x24F53B0 Offset: 0x24F39B0 VA: 0x1824F53B0
	private void InitVertexDeclaration() { }

	// RVA: 0x24F35D0 Offset: 0x24F1BD0 VA: 0x1824F35D0
	private void CompleteCreation() { }

	// RVA: 0x24F8390 Offset: 0x24F6990 VA: 0x1824F8390
	private bool get_fullyCreated() { }

	[CompilerGenerated]
	// RVA: 0x14938F0 Offset: 0x1491EF0 VA: 0x1814938F0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x182F7B0 Offset: 0x182DDB0 VA: 0x18182F7B0
	private void set_disposed(bool value) { }

	// RVA: 0x24F3AB0 Offset: 0x24F20B0 VA: 0x1824F3AB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x24F38F0 Offset: 0x24F1EF0 VA: 0x1824F38F0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x24F2810 Offset: 0x24F0E10 VA: 0x1824F2810
	public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset) { }

	// RVA: 0x24F6C50 Offset: 0x24F5250 VA: 0x1824F6C50
	public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex> vertexData) { }

	// RVA: 0x24F6E90 Offset: 0x24F5490 VA: 0x1824F6E90
	public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset) { }

	// RVA: 0x24F6A20 Offset: 0x24F5020 VA: 0x1824F6A20
	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) { }

	// RVA: 0x24F1BF0 Offset: 0x24F01F0 VA: 0x1824F1BF0
	internal List<UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) { }

	// RVA: 0x24F61C0 Offset: 0x24F47C0 VA: 0x1824F61C0
	private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived) { }

	// RVA: 0x24F28E0 Offset: 0x24F0EE0 VA: 0x1824F28E0
	private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived) { }

	// RVA: 0x24F6310 Offset: 0x24F4910 VA: 0x1824F6310
	private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out UIRenderDevice.AllocToUpdate allocToUpdate, bool copyBackIndices) { }

	// RVA: 0x24F4D40 Offset: 0x24F3340 VA: 0x1824F4D40
	public void Free(MeshHandle mesh) { }

	// RVA: 0x24F5AB0 Offset: 0x24F40B0 VA: 0x1824F5AB0
	public void OnFrameRenderingBegin() { }

	// RVA: -1 Offset: -1
	internal static NativeSlice<T> PtrToSlice<T>(void* p, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x803F90 Offset: 0x802590 VA: 0x180803F90
	|-UIRenderDevice.PtrToSlice<DrawBufferRange>
	|
	|-RVA: 0x8040A0 Offset: 0x8026A0 VA: 0x1808040A0
	|-UIRenderDevice.PtrToSlice<ushort>
	|
	|-RVA: 0x804120 Offset: 0x802720 VA: 0x180804120
	|-UIRenderDevice.PtrToSlice<Vertex>
	|
	|-RVA: 0x804010 Offset: 0x802610 VA: 0x180804010
	|-UIRenderDevice.PtrToSlice<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x24F33F0 Offset: 0x24F19F0 VA: 0x1824F33F0
	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, ref UIRenderDevice.EvaluationState st) { }

	// RVA: 0x24F30D0 Offset: 0x24F16D0 VA: 0x1824F30D0
	private void ApplyBatchState(ref UIRenderDevice.EvaluationState st) { }

	// RVA: 0x24F3E00 Offset: 0x24F2400 VA: 0x1824F3E00
	public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, ref Exception immediateException) { }

	// RVA: 0x24F6B70 Offset: 0x24F5170 VA: 0x1824F6B70
	private void UpdateFenceValue() { }

	// RVA: 0x24F5730 Offset: 0x24F3D30 VA: 0x1824F5730
	private void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage, CommandList commandList) { }

	// RVA: 0x24F3B10 Offset: 0x24F2110 VA: 0x1824F3B10
	private void DrawRanges(Utility.GPUBuffer<ushort> ib, Utility.GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges, CommandList commandList) { }

	// RVA: 0x24F7170 Offset: 0x24F5770 VA: 0x1824F7170
	private void WaitOnCpuFence(uint fence) { }

	// RVA: 0x24F1C60 Offset: 0x24F0260 VA: 0x1824F1C60
	public void AdvanceFrame() { }

	// RVA: 0x24F6090 Offset: 0x24F4690 VA: 0x1824F6090
	private void PruneUnusedPages() { }

	// RVA: 0x24F5B60 Offset: 0x24F4160 VA: 0x1824F5B60
	internal static void PrepareForGfxDeviceRecreate() { }

	// RVA: 0x24F7230 Offset: 0x24F5830 VA: 0x1824F7230
	internal static void WrapUpGfxDeviceRecreate() { }

	// RVA: 0x24F4CB0 Offset: 0x24F32B0 VA: 0x1824F4CB0
	internal static void FlushAllPendingDeviceDisposes() { }

	// RVA: 0x24F5380 Offset: 0x24F3980 VA: 0x1824F5380
	internal UIRenderDevice.DrawStatistics GatherDrawStatistics() { }

	// RVA: 0x24F5C90 Offset: 0x24F4290 VA: 0x1824F5C90
	private static void ProcessDeviceFreeQueue() { }

	// RVA: 0x24F5A10 Offset: 0x24F4010 VA: 0x1824F5A10
	private static void OnEngineUpdateGlobal() { }

	// RVA: 0x24F5A50 Offset: 0x24F4050 VA: 0x1824F5A50
	private static void OnFlushPendingResources() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct Alloc // TypeDefIndex: 4372
{
	// Fields
	public uint start; // 0x0
	public uint size; // 0x4
	internal object handle; // 0x8
	internal bool shortLived; // 0x10
}

// Namespace: UnityEngine.UIElements.UIR
internal class BestFitAllocator // TypeDefIndex: 4375
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly uint <totalSize>k__BackingField; // 0x10
	private BestFitAllocator.Block m_FirstBlock; // 0x18
	private BestFitAllocator.Block m_FirstAvailableBlock; // 0x20
	private BestFitAllocator.BlockPool m_BlockPool; // 0x28
	private uint m_HighWatermark; // 0x30

	// Properties
	public uint totalSize { get; }
	public uint highWatermark { get; }

	// Methods

	// RVA: 0x2500220 Offset: 0x24FE820 VA: 0x182500220
	public void .ctor(uint size) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public uint get_totalSize() { }

	// RVA: 0x25003B0 Offset: 0x24FE9B0 VA: 0x1825003B0
	public uint get_highWatermark() { }

	// RVA: 0x24FF980 Offset: 0x24FDF80 VA: 0x1824FF980
	public Alloc Allocate(uint size) { }

	// RVA: 0x24FFE40 Offset: 0x24FE440 VA: 0x1824FFE40
	public void Free(Alloc alloc) { }

	// RVA: 0x24FFD00 Offset: 0x24FE300 VA: 0x1824FFD00
	private BestFitAllocator.Block CoalesceBlockWithPrevious(BestFitAllocator.Block block) { }

	// RVA: 0x24FFCC0 Offset: 0x24FE2C0 VA: 0x1824FFCC0
	private BestFitAllocator.Block BestFitFindAvailableBlock(uint size) { }

	// RVA: 0x25000B0 Offset: 0x24FE6B0 VA: 0x1825000B0
	private void SplitBlock(BestFitAllocator.Block block, uint size) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class GPUBufferAllocator // TypeDefIndex: 4376
{
	// Fields
	private BestFitAllocator m_Low; // 0x10
	private BestFitAllocator m_High; // 0x18

	// Properties
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x25050C0 Offset: 0x25036C0 VA: 0x1825050C0
	public void .ctor(uint maxSize) { }

	// RVA: 0x2504E80 Offset: 0x2503480 VA: 0x182504E80
	public Alloc Allocate(uint size, bool shortLived) { }

	// RVA: 0x2505010 Offset: 0x2503610 VA: 0x182505010
	public void Free(Alloc alloc) { }

	// RVA: 0x2505170 Offset: 0x2503770 VA: 0x182505170
	public bool get_isEmpty() { }

	// RVA: 0x2505090 Offset: 0x2503690 VA: 0x182505090
	private bool HighLowCollide() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class Page : IDisposable // TypeDefIndex: 4378
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x10
	public Page.DataSet<Vertex> vertices; // 0x18
	public Page.DataSet<ushort> indices; // 0x20
	public Page next; // 0x28
	public int framesEmpty; // 0x30

	// Properties
	protected bool disposed { get; set; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x250C110 Offset: 0x250A710 VA: 0x18250C110
	public void .ctor(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage) { }

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	private void set_disposed(bool value) { }

	// RVA: 0x250C0B0 Offset: 0x250A6B0 VA: 0x18250C0B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x250C020 Offset: 0x250A620 VA: 0x18250C020 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x250C270 Offset: 0x250A870 VA: 0x18250C270
	public bool get_isEmpty() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal enum VertexFlags // TypeDefIndex: 4379
{
	// Fields
	public int value__; // 0x0
	public const VertexFlags IsSolid = 0;
	public const VertexFlags IsText = 1;
	public const VertexFlags IsTextured = 2;
	public const VertexFlags IsDynamic = 3;
	public const VertexFlags IsSvgGradients = 4;
	[Obsolete("Enum member VertexFlags.LastType has been deprecated. Use VertexFlags.IsGraphViewEdge instead.")]
	public const VertexFlags LastType = 10;
	public const VertexFlags IsGraphViewEdge = 10;
}

// Namespace: UnityEngine.UIElements.UIR
internal struct State // TypeDefIndex: 4380
{
	// Fields
	public Material material; // 0x0
	public TextureId texture; // 0x8
	public int stencilRef; // 0xC
	public float sdfScale; // 0x10
	public float sharpness; // 0x14
}

// Namespace: UnityEngine.UIElements.UIR
internal enum CommandType // TypeDefIndex: 4381
{
	// Fields
	public int value__; // 0x0
	public const CommandType Draw = 0;
	public const CommandType ImmediateCull = 1;
	public const CommandType Immediate = 2;
	public const CommandType PushView = 3;
	public const CommandType PopView = 4;
	public const CommandType PushScissor = 5;
	public const CommandType PopScissor = 6;
	public const CommandType PushRenderTexture = 7;
	public const CommandType PopRenderTexture = 8;
	public const CommandType BlitToPreviousRT = 9;
	public const CommandType PushDefaultMaterial = 10;
	public const CommandType PopDefaultMaterial = 11;
	public const CommandType BeginDisable = 12;
	public const CommandType EndDisable = 13;
	public const CommandType CutRenderChain = 14;
}

// Namespace: UnityEngine.UIElements.UIR
internal class DrawParams // TypeDefIndex: 4382
{
	// Fields
	internal static readonly Rect k_UnlimitedRect; // 0x0
	internal static readonly Rect k_FullNormalizedRect; // 0x10
	internal readonly Stack<Matrix4x4> view; // 0x10
	internal readonly Stack<Rect> scissor; // 0x18
	internal readonly List<RenderTexture> renderTexture; // 0x20
	internal readonly List<Material> defaultMaterial; // 0x28

	// Methods

	// RVA: 0x2500690 Offset: 0x24FEC90 VA: 0x182500690
	public void Reset() { }

	// RVA: 0x25008C0 Offset: 0x24FEEC0 VA: 0x1825008C0
	public void .ctor() { }

	// RVA: 0x2500860 Offset: 0x24FEE60 VA: 0x182500860
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand> // TypeDefIndex: 4383
{
	// Fields
	internal VisualElement owner; // 0x18
	internal RenderChainCommand prev; // 0x20
	internal RenderChainCommand next; // 0x28
	internal bool isTail; // 0x30
	internal CommandType type; // 0x34
	internal State state; // 0x38
	internal MeshHandle mesh; // 0x50
	internal int indexOffset; // 0x58
	internal int indexCount; // 0x5C
	internal Action callback; // 0x60
	private static readonly int k_ID_MainTex; // 0x0
	private static ProfilerMarker s_ImmediateOverheadMarker; // 0x8

	// Methods

	// RVA: 0x250F650 Offset: 0x250DC50 VA: 0x18250F650
	internal void Reset() { }

	// RVA: 0x250E770 Offset: 0x250CD70 VA: 0x18250E770
	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) { }

	// RVA: 0x250E4C0 Offset: 0x250CAC0 VA: 0x18250E4C0
	private void Blit(Texture source, RenderTexture destination, float depth) { }

	// RVA: 0x250E630 Offset: 0x250CC30 VA: 0x18250E630
	private static Rect CombineScissorRects(Rect r0, Rect r1) { }

	// RVA: 0x250F560 Offset: 0x250DB60 VA: 0x18250F560
	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	// RVA: 0x250F760 Offset: 0x250DD60 VA: 0x18250F760
	public void .ctor() { }

	// RVA: 0x250F6D0 Offset: 0x250DCD0 VA: 0x18250F6D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class EntryPool // TypeDefIndex: 4385
{
	// Fields
	private const int k_StackSize = 128;
	private Stack<Entry>[] m_ThreadEntries; // 0x10
	private ImplicitPool<Entry> m_SharedPool; // 0x18
	private static readonly Func<Entry> k_CreateAction; // 0x0
	private static readonly Action<Entry> k_ResetAction; // 0x8

	// Methods

	// RVA: 0x2500EA0 Offset: 0x24FF4A0 VA: 0x182500EA0
	public void .ctor(int maxCapacity = 1024) { }

	// RVA: 0x2500A20 Offset: 0x24FF020 VA: 0x182500A20
	public Entry Get() { }

	// RVA: 0x2500CA0 Offset: 0x24FF2A0 VA: 0x182500CA0
	public void ReturnAll() { }

	// RVA: 0x2500D50 Offset: 0x24FF350 VA: 0x182500D50
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class EntryPreProcessor // TypeDefIndex: 4387
{
	// Fields
	private int m_ChildrenIndex; // 0x10
	private List<EntryPreProcessor.AllocSize> m_Allocs; // 0x18
	private List<EntryPreProcessor.AllocSize> m_HeadAllocs; // 0x20
	private List<EntryPreProcessor.AllocSize> m_TailAllocs; // 0x28
	private List<Entry> m_FlattenedEntries; // 0x30
	private EntryPreProcessor.AllocSize m_Pending; // 0x38
	private Stack<EntryPreProcessor.AllocSize> m_Mask; // 0x40
	private bool m_IsPushingMask; // 0x48

	// Properties
	public int childrenIndex { get; }
	public List<EntryPreProcessor.AllocSize> headAllocs { get; }
	public List<EntryPreProcessor.AllocSize> tailAllocs { get; }
	public List<Entry> flattenedEntries { get; }

	// Methods

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_childrenIndex() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public List<EntryPreProcessor.AllocSize> get_headAllocs() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public List<EntryPreProcessor.AllocSize> get_tailAllocs() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public List<Entry> get_flattenedEntries() { }

	// RVA: 0x2501530 Offset: 0x24FFB30 VA: 0x182501530
	public void PreProcess(Entry root) { }

	// RVA: 0x2501160 Offset: 0x24FF760 VA: 0x182501160
	private void DoEvaluate(Entry entry) { }

	// RVA: 0x2501080 Offset: 0x24FF680 VA: 0x182501080
	private void Add(int vertexCount, int indexCount) { }

	// RVA: 0x2501480 Offset: 0x24FFA80 VA: 0x182501480
	private void Flush() { }

	// RVA: 0x2501940 Offset: 0x24FFF40 VA: 0x182501940
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class EntryProcessor // TypeDefIndex: 4389
{
	// Fields
	private EntryPreProcessor m_PreProcessor; // 0x10
	private RenderChain m_RenderChain; // 0x18
	private VisualElement m_CurrentElement; // 0x20
	private int m_MaskDepth; // 0x28
	private int m_MaskDepthPopped; // 0x2C
	private int m_MaskDepthPushed; // 0x30
	private int m_StencilRef; // 0x34
	private int m_StencilRefPopped; // 0x38
	private int m_StencilRefPushed; // 0x3C
	private BMPAlloc m_ClipRectId; // 0x40
	private BMPAlloc m_ClipRectIdPopped; // 0x48
	private BMPAlloc m_ClipRectIdPushed; // 0x50
	private bool m_IsDrawingMask; // 0x58
	private Stack<EntryProcessor.MaskMesh> m_MaskMeshes; // 0x60
	private bool m_VertexDataComputed; // 0x68
	private Matrix4x4 m_Transform; // 0x6C
	private Color32 m_TransformData; // 0xAC
	private Color32 m_OpacityData; // 0xB0
	private Color32 m_TextCoreSettingsPage; // 0xB4
	private MeshHandle m_Mesh; // 0xB8
	private NativeSlice<Vertex> m_Verts; // 0xC0
	private NativeSlice<ushort> m_Indices; // 0xD0
	private ushort m_IndexOffset; // 0xE0
	private int m_AllocVertexCount; // 0xE4
	private int m_AllocIndex; // 0xE8
	private int m_VertsFilled; // 0xEC
	private int m_IndicesFilled; // 0xF0
	private VertexFlags m_RenderType; // 0xF4
	private bool m_RemapUVs; // 0xF8
	private Rect m_AtlasRect; // 0xFC
	private int m_GradientSettingIndexOffset; // 0x10C
	private bool m_IsTail; // 0x110
	private RenderChainCommand m_FirstCommand; // 0x118
	private RenderChainCommand m_LastCommand; // 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private RenderChainCommand <firstHeadCommand>k__BackingField; // 0x128
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private RenderChainCommand <lastHeadCommand>k__BackingField; // 0x130
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private RenderChainCommand <firstTailCommand>k__BackingField; // 0x138
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private RenderChainCommand <lastTailCommand>k__BackingField; // 0x140
	private static Material s_blitMaterial_LinearToGamma; // 0x0
	private static Material s_blitMaterial_GammaToLinear; // 0x8
	private static Material s_blitMaterial_NoChange; // 0x10
	private static Shader s_blitShader; // 0x18

	// Properties
	public RenderChainCommand firstHeadCommand { get; set; }
	public RenderChainCommand lastHeadCommand { get; set; }
	public RenderChainCommand firstTailCommand { get; set; }
	public RenderChainCommand lastTailCommand { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19DB6F0 Offset: 0x19D9CF0 VA: 0x1819DB6F0
	public RenderChainCommand get_firstHeadCommand() { }

	[CompilerGenerated]
	// RVA: 0x23F6D20 Offset: 0x23F5320 VA: 0x1823F6D20
	private void set_firstHeadCommand(RenderChainCommand value) { }

	[CompilerGenerated]
	// RVA: 0x17871D0 Offset: 0x17857D0 VA: 0x1817871D0
	public RenderChainCommand get_lastHeadCommand() { }

	[CompilerGenerated]
	// RVA: 0x1AA57D0 Offset: 0x1AA3DD0 VA: 0x181AA57D0
	private void set_lastHeadCommand(RenderChainCommand value) { }

	[CompilerGenerated]
	// RVA: 0x1791C80 Offset: 0x1790280 VA: 0x181791C80
	public RenderChainCommand get_firstTailCommand() { }

	[CompilerGenerated]
	// RVA: 0x2443850 Offset: 0x2441E50 VA: 0x182443850
	private void set_firstTailCommand(RenderChainCommand value) { }

	[CompilerGenerated]
	// RVA: 0x1791C20 Offset: 0x1790220 VA: 0x181791C20
	public RenderChainCommand get_lastTailCommand() { }

	[CompilerGenerated]
	// RVA: 0x218E7B0 Offset: 0x218CDB0 VA: 0x18218E7B0
	private void set_lastTailCommand(RenderChainCommand value) { }

	// RVA: 0x25024C0 Offset: 0x2500AC0 VA: 0x1825024C0
	public void Init(Entry root, RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x2502A30 Offset: 0x2501030 VA: 0x182502A30
	public void ProcessHead() { }

	// RVA: 0x2504050 Offset: 0x2502650 VA: 0x182504050
	public void ProcessTail() { }

	// RVA: 0x2503640 Offset: 0x2501C40 VA: 0x182503640
	private void ProcessRange(int first, int last) { }

	// RVA: 0x2502B00 Offset: 0x2501100 VA: 0x182502B00
	private void ProcessMeshEntry(Entry entry, TextureId textureId) { }

	// RVA: 0x2501D70 Offset: 0x2500370 VA: 0x182501D70
	private void DrawReverseMask() { }

	// RVA: 0x2501C80 Offset: 0x2500280 VA: 0x182501C80
	private RenderChainCommand CreateMeshDrawCommand(MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture) { }

	// RVA: 0x24FDB20 Offset: 0x24FC120 VA: 0x1824FDB20
	private void AppendCommand(RenderChainCommand next) { }

	// RVA: 0x25027F0 Offset: 0x2500DF0 VA: 0x1825027F0
	private void ProcessFirstAlloc(List<EntryPreProcessor.AllocSize> allocList, ref MeshHandle mesh) { }

	// RVA: 0x25033B0 Offset: 0x25019B0 VA: 0x1825033B0
	private void ProcessNextAlloc() { }

	// RVA: 0x25041C0 Offset: 0x25027C0 VA: 0x1825041C0
	private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats) { }

	// RVA: 0x2501A90 Offset: 0x2500090 VA: 0x182501A90
	private static Material CreateBlitShader(float colorConversion) { }

	// RVA: 0x2502260 Offset: 0x2500860 VA: 0x182502260
	private static Material GetBlitMaterial(VisualElement.RenderTargetMode mode) { }

	// RVA: 0x25042E0 Offset: 0x25028E0 VA: 0x1825042E0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal enum EntryType // TypeDefIndex: 4390
{
	// Fields
	public int value__; // 0x0
	public const EntryType DrawSolidMesh = 0;
	public const EntryType DrawTexturedMesh = 1;
	public const EntryType DrawTexturedMeshSkipAtlas = 2;
	public const EntryType DrawSdfTextMesh = 3;
	public const EntryType DrawGradients = 4;
	public const EntryType DrawImmediate = 5;
	public const EntryType DrawImmediateCull = 6;
	public const EntryType DrawChildren = 7;
	public const EntryType BeginStencilMask = 8;
	public const EntryType EndStencilMask = 9;
	public const EntryType PopStencilMask = 10;
	public const EntryType PushClippingRect = 11;
	public const EntryType PopClippingRect = 12;
	public const EntryType PushScissors = 13;
	public const EntryType PopScissors = 14;
	public const EntryType PushGroupMatrix = 15;
	public const EntryType PopGroupMatrix = 16;
	public const EntryType PushRenderTexture = 17;
	public const EntryType BlitAndPopRenderTexture = 18;
	public const EntryType PushDefaultMaterial = 19;
	public const EntryType PopDefaultMaterial = 20;
	public const EntryType CutRenderChain = 21;
	public const EntryType DedicatedPlaceholder = 22;
}

// Namespace: UnityEngine.UIElements.UIR
internal class Entry // TypeDefIndex: 4391
{
	// Fields
	public EntryType type; // 0x10
	public NativeSlice<Vertex> vertices; // 0x18
	public NativeSlice<ushort> indices; // 0x28
	public Texture texture; // 0x38
	public float textScale; // 0x40
	public float fontSharpness; // 0x44
	public VectorImage gradientsOwner; // 0x48
	public Material material; // 0x50
	public Action immediateCallback; // 0x58
	public Entry nextSibling; // 0x60
	public Entry firstChild; // 0x68
	public Entry lastChild; // 0x70

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class EntryRecorder // TypeDefIndex: 4392
{
	// Fields
	private EntryPool m_EntryPool; // 0x10

	// Methods

	// RVA: 0x2504E00 Offset: 0x2503400 VA: 0x182504E00
	public void .ctor(EntryPool entryPool) { }

	// RVA: 0x2504980 Offset: 0x2502F80 VA: 0x182504980
	public void DrawMesh(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture, bool skipAtlas) { }

	// RVA: 0x2504A20 Offset: 0x2503020 VA: 0x182504A20
	public void DrawSdfText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture, float scale, float sharpness) { }

	// RVA: 0x2504870 Offset: 0x2502E70 VA: 0x182504870
	public void DrawGradients(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, VectorImage gradientsOwner) { }

	// RVA: 0x2504900 Offset: 0x2502F00 VA: 0x182504900
	public void DrawImmediate(Entry parentEntry, Action callback, bool cullingEnabled) { }

	// RVA: 0x2504830 Offset: 0x2502E30 VA: 0x182504830
	public void DrawChildren(Entry parentEntry) { }

	// RVA: 0x2504770 Offset: 0x2502D70 VA: 0x182504770
	public void BeginStencilMask(Entry parentEntry) { }

	// RVA: 0x2504AC0 Offset: 0x25030C0 VA: 0x182504AC0
	public void EndStencilMask(Entry parentEntry) { }

	// RVA: 0x2504C50 Offset: 0x2503250 VA: 0x182504C50
	public void PopStencilMask(Entry parentEntry) { }

	// RVA: 0x2504C90 Offset: 0x2503290 VA: 0x182504C90
	public void PushClippingRect(Entry parentEntry) { }

	// RVA: 0x2504B50 Offset: 0x2503150 VA: 0x182504B50
	public void PopClippingRect(Entry parentEntry) { }

	// RVA: 0x2504DC0 Offset: 0x25033C0 VA: 0x182504DC0
	public void PushScissors(Entry parentEntry) { }

	// RVA: 0x2504C10 Offset: 0x2503210 VA: 0x182504C10
	public void PopScissors(Entry parentEntry) { }

	// RVA: 0x2504D40 Offset: 0x2503340 VA: 0x182504D40
	public void PushGroupMatrix(Entry parentEntry) { }

	// RVA: 0x2504BD0 Offset: 0x25031D0 VA: 0x182504BD0
	public void PopGroupMatrix(Entry parentEntry) { }

	// RVA: 0x2504D80 Offset: 0x2503380 VA: 0x182504D80
	public void PushRenderTexture(Entry parentEntry) { }

	// RVA: 0x25047B0 Offset: 0x2502DB0 VA: 0x1825047B0
	public void BlitAndPopRenderTexture(Entry parentEntry) { }

	// RVA: 0x2504CD0 Offset: 0x25032D0 VA: 0x182504CD0
	public void PushDefaultMaterial(Entry parentEntry, Material material) { }

	// RVA: 0x2504B90 Offset: 0x2503190 VA: 0x182504B90
	public void PopDefaultMaterial(Entry parentEntry) { }

	// RVA: 0x25047F0 Offset: 0x2502DF0 VA: 0x1825047F0
	public void CutRenderChain(Entry parentEntry) { }

	// RVA: 0x2504B00 Offset: 0x2503100 VA: 0x182504B00
	public Entry InsertPlaceholder(Entry parentEntry) { }

	// RVA: 0x25044C0 Offset: 0x2502AC0 VA: 0x1825044C0
	private static void AppendMeshEntry(Entry parentEntry, Entry entry) { }

	// RVA: 0x25046A0 Offset: 0x2502CA0 VA: 0x1825046A0
	private static void Append(Entry parentEntry, Entry entry) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientSettingsAtlas : IDisposable // TypeDefIndex: 4394
{
	// Fields
	private static ProfilerMarker s_MarkerWrite; // 0x0
	private static ProfilerMarker s_MarkerCommit; // 0x8
	private readonly int m_Length; // 0x10
	private readonly int m_ElemWidth; // 0x14
	private BestFitAllocator m_Allocator; // 0x18
	private Texture2D m_Atlas; // 0x20
	private GradientSettingsAtlas.RawTexture m_RawAtlas; // 0x28
	private static int s_TextureCounter; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <MustCommit>k__BackingField; // 0x39

	// Properties
	internal int length { get; }
	protected bool disposed { get; set; }
	public Texture2D atlas { get; }
	public bool MustCommit { get; set; }

	// Methods

	// RVA: 0x2333510 Offset: 0x2331B10 VA: 0x182333510
	internal int get_length() { }

	[CompilerGenerated]
	// RVA: 0x39D630 Offset: 0x39BC30 VA: 0x18039D630
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0xADAD60 Offset: 0xAD9360 VA: 0x180ADAD60
	private void set_disposed(bool value) { }

	// RVA: 0x2505450 Offset: 0x2503A50 VA: 0x182505450 Slot: 4
	public void Dispose() { }

	// RVA: 0x25054B0 Offset: 0x2503AB0 VA: 0x1825054B0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2505C90 Offset: 0x2504290 VA: 0x182505C90
	public void .ctor(int length = 4096) { }

	// RVA: 0x2505690 Offset: 0x2503C90 VA: 0x182505690
	public void Reset() { }

	// RVA: 0x2358D20 Offset: 0x2357320 VA: 0x182358D20
	public Texture2D get_atlas() { }

	// RVA: 0x25051B0 Offset: 0x25037B0 VA: 0x1825051B0
	public Alloc Add(int count) { }

	// RVA: 0x2505750 Offset: 0x2503D50 VA: 0x182505750
	public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) { }

	[CompilerGenerated]
	// RVA: 0xADABC0 Offset: 0xAD91C0 VA: 0x180ADABC0
	public bool get_MustCommit() { }

	[CompilerGenerated]
	// RVA: 0xADB1E0 Offset: 0xAD97E0 VA: 0x180ADB1E0
	private void set_MustCommit(bool value) { }

	// RVA: 0x2505290 Offset: 0x2503890 VA: 0x182505290
	public void Commit() { }

	// RVA: 0x2505520 Offset: 0x2503B20 VA: 0x182505520
	private void PrepareAtlas() { }

	// RVA: 0x2505BF0 Offset: 0x25041F0 VA: 0x182505BF0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class ImplicitPool<T> // TypeDefIndex: 4395
{
	// Fields
	private readonly int m_StartCapacity; // 0x0
	private readonly int m_MaxCapacity; // 0x0
	private Func<T> m_CreateAction; // 0x0
	private Action<T> m_ResetAction; // 0x0
	private List<T> m_List; // 0x0
	private int m_UsedCount; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> createAction, Action<T> resetAction, int startCapacity, int maxCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1092260 Offset: 0x1090860 VA: 0x181092260
	|-ImplicitPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1091FA0 Offset: 0x10905A0 VA: 0x181091FA0
	|-ImplicitPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void ReturnAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1092180 Offset: 0x1090780 VA: 0x181092180
	|-ImplicitPool<object>.ReturnAll
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class JobManager : IDisposable // TypeDefIndex: 4396
{
	// Fields
	private NativePagedList<NudgeJobData> m_NudgeJobs; // 0x10
	private NativePagedList<ConvertMeshJobData> m_ConvertMeshJobs; // 0x18
	private NativePagedList<CopyMeshJobData> m_CopyMeshJobs; // 0x20
	private JobMerger m_JobMerger; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x30

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2505E30 Offset: 0x2504430 VA: 0x182505E30
	public void Add(ref NudgeJobData job) { }

	// RVA: 0x2505D70 Offset: 0x2504370 VA: 0x182505D70
	public void Add(ref ConvertMeshJobData job) { }

	// RVA: 0x2505DD0 Offset: 0x25043D0 VA: 0x182505DD0
	public void Add(ref CopyMeshJobData job) { }

	// RVA: 0x25064B0 Offset: 0x2504AB0 VA: 0x1825064B0
	public void CompleteNudgeJobs() { }

	// RVA: 0x2505E90 Offset: 0x2504490 VA: 0x182505E90
	public void CompleteConvertMeshJobs() { }

	// RVA: 0x25061A0 Offset: 0x25047A0 VA: 0x1825061A0
	public void CompleteCopyMeshJobs() { }

	[CompilerGenerated]
	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	private void set_disposed(bool value) { }

	// RVA: 0x2506880 Offset: 0x2504E80 VA: 0x182506880 Slot: 4
	public void Dispose() { }

	// RVA: 0x25067C0 Offset: 0x2504DC0 VA: 0x1825067C0
	protected void Dispose(bool disposing) { }

	// RVA: 0x2506960 Offset: 0x2504F60 VA: 0x182506960
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct NudgeJobData // TypeDefIndex: 4397
{
	// Fields
	public IntPtr headSrc; // 0x0
	public IntPtr headDst; // 0x8
	public int headCount; // 0x10
	public IntPtr tailSrc; // 0x18
	public IntPtr tailDst; // 0x20
	public int tailCount; // 0x28
	public Matrix4x4 transform; // 0x2C
}

// Namespace: UnityEngine.UIElements.UIR
internal struct ConvertMeshJobData // TypeDefIndex: 4398
{
	// Fields
	public IntPtr vertSrc; // 0x0
	public IntPtr vertDst; // 0x8
	public int vertCount; // 0x10
	public Matrix4x4 transform; // 0x14
	public Color32 xformClipPages; // 0x54
	public Color32 ids; // 0x58
	public Color32 addFlags; // 0x5C
	public Color32 opacityPage; // 0x60
	public Color32 textCoreSettingsPage; // 0x64
	public int isSdfText; // 0x68
	public float textureId; // 0x6C
	public int gradientSettingsIndexOffset; // 0x70
	public IntPtr indexSrc; // 0x78
	public IntPtr indexDst; // 0x80
	public int indexCount; // 0x88
	public int indexOffset; // 0x8C
	public int flipIndices; // 0x90
	public int forceZ; // 0x94
	public float positionZ; // 0x98
	public int remapUVs; // 0x9C
	public Rect atlasRect; // 0xA0
}

// Namespace: UnityEngine.UIElements.UIR
internal struct CopyMeshJobData // TypeDefIndex: 4399
{
	// Fields
	public IntPtr vertSrc; // 0x0
	public IntPtr vertDst; // 0x8
	public int vertCount; // 0x10
	public IntPtr indexSrc; // 0x18
	public IntPtr indexDst; // 0x20
	public int indexCount; // 0x28
	public int indexOffset; // 0x2C
}

// Namespace: UnityEngine.UIElements.UIR
internal class JobMerger : IDisposable // TypeDefIndex: 4400
{
	// Fields
	private NativeArray<JobHandle> m_Jobs; // 0x10
	private int m_JobCount; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x24

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2506D30 Offset: 0x2505330 VA: 0x182506D30
	public void .ctor(int capacity) { }

	// RVA: 0x2506B20 Offset: 0x2505120 VA: 0x182506B20
	public void Add(JobHandle job) { }

	// RVA: 0x2506C80 Offset: 0x2505280 VA: 0x182506C80
	public JobHandle MergeAndReset() { }

	[CompilerGenerated]
	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	private void set_disposed(bool value) { }

	// RVA: 0x2506C00 Offset: 0x2505200 VA: 0x182506C00 Slot: 4
	public void Dispose() { }

	// RVA: 0x2506BA0 Offset: 0x25051A0 VA: 0x182506BA0
	protected void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class LinkedPoolItem<T> // TypeDefIndex: 4401
{
	// Fields
	internal T poolNext; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-LinkedPoolItem<object>..ctor
	|-LinkedPoolItem<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class LinkedPool<T> // TypeDefIndex: 4402
{
	// Fields
	private readonly Func<T> m_CreateFunc; // 0x0
	private readonly Action<T> m_ResetAction; // 0x0
	private readonly int m_Limit; // 0x0
	private T m_PoolFirst; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public int Count { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> createFunc, Action<T> resetAction, int limit = 10000) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F920 Offset: 0x111DF20 VA: 0x18111F920
	|-LinkedPool<object>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	|-LinkedPool<object>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	|-LinkedPool<object>.set_Count
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F830 Offset: 0x111DE30 VA: 0x18111F830
	|-LinkedPool<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F840 Offset: 0x111DE40 VA: 0x18111F840
	|-LinkedPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Return(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F8C0 Offset: 0x111DEC0 VA: 0x18111F8C0
	|-LinkedPool<object>.Return
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class BasicNode<T> : LinkedPoolItem<BasicNode<T>> // TypeDefIndex: 4403
{
	// Fields
	public BasicNode<T> next; // 0x0
	public T data; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void AppendTo(ref BasicNode<T> first) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC84DC0 Offset: 0xC833C0 VA: 0x180C84DC0
	|-BasicNode<object>.AppendTo
	|-BasicNode<TextureEntry>.AppendTo
	|
	|-RVA: 0xC84E00 Offset: 0xC83400 VA: 0x180C84E00
	|-BasicNode<__Il2CppFullySharedGenericType>.AppendTo
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC84F10 Offset: 0xC83510 VA: 0x180C84F10
	|-BasicNode<object>..ctor
	|-BasicNode<TextureEntry>..ctor
	|
	|-RVA: 0xC0D9F0 Offset: 0xC0BFF0 VA: 0x180C0D9F0
	|-BasicNode<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class BasicNodePool<T> : LinkedPool<BasicNode<T>> // TypeDefIndex: 4404
{
	// Methods

	// RVA: -1 Offset: -1
	private static void Reset(BasicNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC84B60 Offset: 0xC83160 VA: 0x180C84B60
	|-BasicNodePool<object>.Reset
	|
	|-RVA: 0xC84BA0 Offset: 0xC831A0 VA: 0x180C84BA0
	|-BasicNodePool<TextureEntry>.Reset
	|
	|-RVA: 0xC84A60 Offset: 0xC83060 VA: 0x180C84A60
	|-BasicNodePool<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1
	private static BasicNode<T> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC849D0 Offset: 0xC82FD0 VA: 0x180C849D0
	|-BasicNodePool<object>.Create
	|-BasicNodePool<TextureEntry>.Create
	|
	|-RVA: 0xC84920 Offset: 0xC82F20 VA: 0x180C84920
	|-BasicNodePool<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC84BE0 Offset: 0xC831E0 VA: 0x180C84BE0
	|-BasicNodePool<object>..ctor
	|-BasicNodePool<TextureEntry>..ctor
	|
	|-RVA: 0xC84CD0 Offset: 0xC832D0 VA: 0x180C84CD0
	|-BasicNodePool<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal sealed class MeshGenerationCallback : MulticastDelegate // TypeDefIndex: 4405
{
	// Methods

	// RVA: 0xC193A0 Offset: 0xC179A0 VA: 0x180C193A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x593FA0 Offset: 0x5925A0 VA: 0x180593FA0 Slot: 13
	public virtual void Invoke(MeshGenerationContext meshGenerationContext, object userData) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class MeshGenerationDeferrer : IDisposable // TypeDefIndex: 4407
{
	// Fields
	private Queue<MeshGenerationDeferrer.CallbackInfo> m_Fork; // 0x10
	private Queue<MeshGenerationDeferrer.CallbackInfo> m_WorkThenFork; // 0x18
	private Queue<MeshGenerationDeferrer.CallbackInfo> m_Work; // 0x20
	private Queue<MeshGenerationDeferrer.CallbackInfo> m_JobDependentFork; // 0x28
	private Queue<MeshGenerationDeferrer.CallbackInfo> m_JobDependentWorkThenFork; // 0x30
	private Queue<MeshGenerationDeferrer.CallbackInfo> m_JobDependentWork; // 0x38
	private Queue<JobHandle> m_Dependencies; // 0x40
	private JobMerger m_DependencyMerger; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x50

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2506F90 Offset: 0x2505590 VA: 0x182506F90
	public void AddMeshGenerationJob(JobHandle jobHandle) { }

	// RVA: 0x2506DD0 Offset: 0x25053D0 VA: 0x182506DD0
	public void AddMeshGenerationCallback(MeshGenerationCallback callback, object userData, MeshGenerationCallbackType callbackType, bool isJobDependent) { }

	// RVA: 0x25071C0 Offset: 0x25057C0 VA: 0x1825071C0
	public void ProcessDeferredWork(MeshGenerationContext meshGenerationContext) { }

	// RVA: 0x25070C0 Offset: 0x25056C0 VA: 0x1825070C0
	private static void Invoke(MeshGenerationDeferrer.CallbackInfo ci, MeshGenerationContext mgc) { }

	[CompilerGenerated]
	// RVA: 0x95D0B0 Offset: 0x95B6B0 VA: 0x18095D0B0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x1031CD0 Offset: 0x10302D0 VA: 0x181031CD0
	private void set_disposed(bool value) { }

	// RVA: 0x2506FF0 Offset: 0x25055F0 VA: 0x182506FF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2507070 Offset: 0x2505670 VA: 0x182507070
	protected void Dispose(bool disposing) { }

	// RVA: 0x2507570 Offset: 0x2505B70 VA: 0x182507570
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal interface IMeshGenerator // TypeDefIndex: 4408
{
	// Properties
	public abstract VisualElement currentElement { set; }
	public abstract UITKTextJobSystem textJobSystem { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_currentElement(VisualElement value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract UITKTextJobSystem get_textJobSystem();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DrawText(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Material> materials, List<GlyphRenderMode> renderModes);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void DrawRectangle(MeshGenerator.RectangleParams rectParams);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DrawBorder(MeshGenerator.BorderParams borderParams);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void DrawRectangleRepeat(MeshGenerator.RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void ScheduleJobs(MeshGenerationContext mgc);
}

// Namespace: UnityEngine.UIElements.UIR
internal class MeshGenerator : IMeshGenerator, IDisposable // TypeDefIndex: 4414
{
	// Fields
	private static readonly ProfilerMarker k_MarkerDrawRectangle; // 0x0
	private static readonly ProfilerMarker k_MarkerDrawBorder; // 0x8
	private static readonly ProfilerMarker k_MarkerDrawVectorImage; // 0x10
	private static readonly ProfilerMarker k_MarkerDrawRectangleRepeat; // 0x18
	private MeshGenerationContext m_MeshGenerationContext; // 0x10
	private List<MeshGenerator.RepeatRectUV>[] m_RepeatRectUVList; // 0x18
	private GCHandlePool m_GCHandlePool; // 0x20
	private NativeArray<MeshGenerator.TessellationJobParameters> m_JobParameters; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VisualElement <currentElement>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UITKTextJobSystem <textJobSystem>k__BackingField; // 0x40
	private TextInfo m_TextInfo; // 0x48
	private TextGenerationSettings m_Settings; // 0x50
	private List<NativeSlice<Vertex>> m_VerticesArray; // 0x58
	private List<NativeSlice<ushort>> m_IndicesArray; // 0x60
	private List<Material> m_Materials; // 0x68
	private List<GlyphRenderMode> m_RenderModes; // 0x70
	private MeshGenerationCallback m_OnMeshGenerationDelegate; // 0x78
	private List<MeshGenerator.TessellationJobParameters> m_TesselationJobParameters; // 0x80
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x88

	// Properties
	public VisualElement currentElement { set; }
	public UITKTextJobSystem textJobSystem { get; set; }
	internal bool disposed { get; set; }

	// Methods

	// RVA: 0x250BC10 Offset: 0x250A210 VA: 0x18250BC10
	public void .ctor(MeshGenerationContext mgc) { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0 Slot: 4
	public void set_currentElement(VisualElement value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980 Slot: 5
	public UITKTextJobSystem get_textJobSystem() { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990 Slot: 12
	public void set_textJobSystem(UITKTextJobSystem value) { }

	// RVA: 0x2507F90 Offset: 0x2506590 VA: 0x182507F90
	private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) { }

	// RVA: 0x250AEF0 Offset: 0x25094F0 VA: 0x18250AEF0
	public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight) { }

	// RVA: 0x25077F0 Offset: 0x2505DF0 VA: 0x1825077F0
	public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref MeshGenerator.RectangleParams rectParams) { }

	// RVA: 0x250AEE0 Offset: 0x25094E0 VA: 0x18250AEE0 Slot: 6
	public void DrawText(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Material> materials, List<GlyphRenderMode> renderModes) { }

	// RVA: 0x250AA00 Offset: 0x2509000 VA: 0x18250AA00
	private void DrawTextInfo(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Material> materials, List<GlyphRenderMode> renderModes) { }

	// RVA: 0x24B53D0 Offset: 0x24B39D0 VA: 0x1824B53D0
	internal static Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 posOffset, bool isDynamicColor = False) { }

	// RVA: 0x250B1A0 Offset: 0x25097A0 VA: 0x18250B1A0
	private void MakeText(Texture texture, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, bool isSdf, float sdfScale, float sharpness) { }

	// RVA: 0x250A0F0 Offset: 0x25086F0 VA: 0x18250A0F0 Slot: 7
	public void DrawRectangle(MeshGenerator.RectangleParams rectParams) { }

	// RVA: 0x2509E70 Offset: 0x2508470 VA: 0x182509E70 Slot: 8
	public void DrawBorder(MeshGenerator.BorderParams borderParams) { }

	// RVA: 0x250A0C0 Offset: 0x25086C0 VA: 0x18250A0C0 Slot: 9
	public void DrawRectangleRepeat(MeshGenerator.RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	// RVA: 0x2508110 Offset: 0x2506710 VA: 0x182508110
	private void DoDrawRectangleRepeat(ref MeshGenerator.RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	// RVA: 0x250B640 Offset: 0x2509C40 VA: 0x18250B640
	private void StampRectangleWithSubRect(MeshGenerator.RectangleParams rectParams, Rect targetRect, Rect targetUV) { }

	// RVA: 0x2507BC0 Offset: 0x25061C0 VA: 0x182507BC0
	private static void AdjustSpriteWinding(Vector2[] vertices, ushort[] indices, NativeSlice<ushort> newIndices) { }

	// RVA: 0x250B300 Offset: 0x2509900 VA: 0x18250B300 Slot: 10
	public void ScheduleJobs(MeshGenerationContext mgc) { }

	// RVA: 0x250B2E0 Offset: 0x25098E0 VA: 0x18250B2E0
	private void OnMeshGeneration(MeshGenerationContext ctx, object data) { }

	[CompilerGenerated]
	// RVA: 0x3A35C0 Offset: 0x3A1BC0 VA: 0x1803A35C0
	internal bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x498D60 Offset: 0x497360 VA: 0x180498D60
	private void set_disposed(bool value) { }

	// RVA: 0x2507FF0 Offset: 0x25065F0 VA: 0x182507FF0 Slot: 11
	public void Dispose() { }

	// RVA: 0x2508090 Offset: 0x2506690 VA: 0x182508090
	private void Dispose(bool disposing) { }

	// RVA: 0x250BB00 Offset: 0x250A100 VA: 0x18250BB00
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class NativeList<T> : IDisposable // TypeDefIndex: 4415
{
	// Fields
	private NativeArray<T> m_NativeArray; // 0x0
	private int m_Count; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x0

	// Properties
	public int Count { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int initialCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A2610 Offset: 0x12A0C10 VA: 0x1812A2610
	|-NativeList<DrawBufferRange>..ctor
	|
	|-RVA: 0x12A26C0 Offset: 0x12A0CC0 VA: 0x1812A26C0
	|-NativeList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Expand(int newLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A23E0 Offset: 0x12A09E0 VA: 0x1812A23E0
	|-NativeList<DrawBufferRange>.Expand
	|
	|-RVA: 0x12A22A0 Offset: 0x12A08A0 VA: 0x1812A22A0
	|-NativeList<__Il2CppFullySharedGenericStructType>.Expand
	*/

	// RVA: -1 Offset: -1
	public void Add(NativeSlice<T> src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A1D30 Offset: 0x12A0330 VA: 0x1812A1D30
	|-NativeList<DrawBufferRange>.Add
	|
	|-RVA: 0x12A1F30 Offset: 0x12A0530 VA: 0x1812A1F30
	|-NativeList<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A20C0 Offset: 0x12A06C0 VA: 0x1812A20C0
	|-NativeList<DrawBufferRange>.Clear
	|-NativeList<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public NativeSlice<T> GetSlice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A2540 Offset: 0x12A0B40 VA: 0x1812A2540
	|-NativeList<DrawBufferRange>.GetSlice
	|
	|-RVA: 0x12A25A0 Offset: 0x12A0BA0 VA: 0x1812A25A0
	|-NativeList<__Il2CppFullySharedGenericStructType>.GetSlice
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	|-NativeList<DrawBufferRange>.get_Count
	|-NativeList<__Il2CppFullySharedGenericStructType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected bool get_disposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	|-NativeList<DrawBufferRange>.get_disposed
	|-NativeList<__Il2CppFullySharedGenericStructType>.get_disposed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_disposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	|-NativeList<DrawBufferRange>.set_disposed
	|-NativeList<__Il2CppFullySharedGenericStructType>.set_disposed
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A2180 Offset: 0x12A0780 VA: 0x1812A2180
	|-NativeList<DrawBufferRange>.Dispose
	|
	|-RVA: 0x12A20D0 Offset: 0x12A06D0 VA: 0x1812A20D0
	|-NativeList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	protected void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A2140 Offset: 0x12A0740 VA: 0x1812A2140
	|-NativeList<DrawBufferRange>.Dispose
	|
	|-RVA: 0x12A2210 Offset: 0x12A0810 VA: 0x1812A2210
	|-NativeList<__Il2CppFullySharedGenericStructType>.Dispose
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class NativePagedList<T> : IDisposable // TypeDefIndex: 4416
{
	// Fields
	private readonly int k_PoolCapacity; // 0x0
	private List<NativeArray<T>> m_Pages; // 0x0
	private NativeArray<T> m_CurrentPage; // 0x0
	private int m_CurrentPageCount; // 0x0
	private List<NativeSlice<T>> m_Enumerator; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x0

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int poolCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A4680 Offset: 0x12A2C80 VA: 0x1812A4680
	|-NativePagedList<ConvertMeshJobData>..ctor
	|
	|-RVA: 0x12A4530 Offset: 0x12A2B30 VA: 0x1812A4530
	|-NativePagedList<CopyMeshJobData>..ctor
	|
	|-RVA: 0x12A43E0 Offset: 0x12A29E0 VA: 0x1812A43E0
	|-NativePagedList<NudgeJobData>..ctor
	|
	|-RVA: 0x12A47D0 Offset: 0x12A2DD0 VA: 0x1812A47D0
	|-NativePagedList<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Add(ref T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A2920 Offset: 0x12A0F20 VA: 0x1812A2920
	|-NativePagedList<ConvertMeshJobData>.Add
	|
	|-RVA: 0x12A2C10 Offset: 0x12A1210 VA: 0x1812A2C10
	|-NativePagedList<CopyMeshJobData>.Add
	|
	|-RVA: 0x12A2770 Offset: 0x12A0D70 VA: 0x1812A2770
	|-NativePagedList<NudgeJobData>.Add
	|
	|-RVA: 0x12A2D80 Offset: 0x12A1380 VA: 0x1812A2D80
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public List<NativeSlice<T>> GetPages() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A3DA0 Offset: 0x12A23A0 VA: 0x1812A3DA0
	|-NativePagedList<ConvertMeshJobData>.GetPages
	|
	|-RVA: 0x12A3B20 Offset: 0x12A2120 VA: 0x1812A3B20
	|-NativePagedList<CopyMeshJobData>.GetPages
	|
	|-RVA: 0x12A3620 Offset: 0x12A1C20 VA: 0x1812A3620
	|-NativePagedList<NudgeJobData>.GetPages
	|
	|-RVA: 0x12A38A0 Offset: 0x12A1EA0 VA: 0x1812A38A0
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.GetPages
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A4020 Offset: 0x12A2620 VA: 0x1812A4020
	|-NativePagedList<ConvertMeshJobData>.Reset
	|-NativePagedList<CopyMeshJobData>.Reset
	|-NativePagedList<NudgeJobData>.Reset
	|
	|-RVA: 0x12A41C0 Offset: 0x12A27C0 VA: 0x1812A41C0
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Reset
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected bool get_disposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40E2E0 Offset: 0x40C8E0 VA: 0x18040E2E0
	|-NativePagedList<ConvertMeshJobData>.get_disposed
	|-NativePagedList<CopyMeshJobData>.get_disposed
	|-NativePagedList<NudgeJobData>.get_disposed
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.get_disposed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_disposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x40E2F0 Offset: 0x40C8F0 VA: 0x18040E2F0
	|-NativePagedList<ConvertMeshJobData>.set_disposed
	|-NativePagedList<CopyMeshJobData>.set_disposed
	|-NativePagedList<NudgeJobData>.set_disposed
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.set_disposed
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A2FD0 Offset: 0x12A15D0 VA: 0x1812A2FD0
	|-NativePagedList<ConvertMeshJobData>.Dispose
	|
	|-RVA: 0x12A3500 Offset: 0x12A1B00 VA: 0x1812A3500
	|-NativePagedList<CopyMeshJobData>.Dispose
	|
	|-RVA: 0x12A30F0 Offset: 0x12A16F0 VA: 0x1812A30F0
	|-NativePagedList<NudgeJobData>.Dispose
	|
	|-RVA: 0x12A3480 Offset: 0x12A1A80 VA: 0x1812A3480
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	protected void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12A3210 Offset: 0x12A1810 VA: 0x1812A3210
	|-NativePagedList<ConvertMeshJobData>.Dispose
	|-NativePagedList<CopyMeshJobData>.Dispose
	|-NativePagedList<NudgeJobData>.Dispose
	|
	|-RVA: 0x12A32F0 Offset: 0x12A18F0 VA: 0x1812A32F0
	|-NativePagedList<__Il2CppFullySharedGenericStructType>.Dispose
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class OpacityIdAccelerator : IDisposable // TypeDefIndex: 4418
{
	// Fields
	private NativeArray<JobHandle> m_Jobs; // 0x10
	private int m_NextJobIndex; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x24

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2512990 Offset: 0x2510F90 VA: 0x182512990
	public void CreateJob(NativeSlice<Vertex> oldVerts, NativeSlice<Vertex> newVerts, Color32 opacityData, int vertexCount) { }

	// RVA: 0x25128E0 Offset: 0x2510EE0 VA: 0x1825128E0
	public void CompleteJobs() { }

	[CompilerGenerated]
	// RVA: 0x38E1E0 Offset: 0x38C7E0 VA: 0x18038E1E0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x38E240 Offset: 0x38C840 VA: 0x18038E240
	private void set_disposed(bool value) { }

	// RVA: 0x2512AC0 Offset: 0x25110C0 VA: 0x182512AC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2512B20 Offset: 0x2511120 VA: 0x182512B20 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2512B80 Offset: 0x2511180 VA: 0x182512B80
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct ChainBuilderStats // TypeDefIndex: 4419
{
	// Fields
	public uint elementsAdded; // 0x0
	public uint elementsRemoved; // 0x4
	public uint recursiveClipUpdates; // 0x8
	public uint recursiveClipUpdatesExpanded; // 0xC
	public uint nonRecursiveClipUpdates; // 0x10
	public uint recursiveTransformUpdates; // 0x14
	public uint recursiveTransformUpdatesExpanded; // 0x18
	public uint recursiveOpacityUpdates; // 0x1C
	public uint recursiveOpacityUpdatesExpanded; // 0x20
	public uint opacityIdUpdates; // 0x24
	public uint colorUpdates; // 0x28
	public uint colorUpdatesExpanded; // 0x2C
	public uint recursiveVisualUpdates; // 0x30
	public uint recursiveVisualUpdatesExpanded; // 0x34
	public uint nonRecursiveVisualUpdates; // 0x38
	public uint dirtyProcessed; // 0x3C
	public uint nudgeTransformed; // 0x40
	public uint boneTransformed; // 0x44
	public uint skipTransformed; // 0x48
	public uint visualUpdateTransformed; // 0x4C
	public uint updatedMeshAllocations; // 0x50
	public uint newMeshAllocations; // 0x54
	public uint groupTransformElementsChanged; // 0x58
}

// Namespace: UnityEngine.UIElements.UIR
internal class MeshWriteDataPool : ImplicitPool<MeshWriteData> // TypeDefIndex: 4421
{
	// Fields
	private static readonly Func<MeshWriteData> k_CreateAction; // 0x0

	// Methods

	// RVA: 0x2512850 Offset: 0x2510E50 VA: 0x182512850
	public void .ctor() { }

	// RVA: 0x2512780 Offset: 0x2510D80 VA: 0x182512780
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class RenderChain : IDisposable // TypeDefIndex: 4427
{
	// Fields
	private RenderChainCommand m_FirstCommand; // 0x10
	private RenderChain.DepthOrderedDirtyTracking m_DirtyTracker; // 0x18
	private RenderChain.VisualChangesProcessor m_VisualChangesProcessor; // 0x40
	private LinkedPool<RenderChainCommand> m_CommandPool; // 0x48
	private LinkedPool<ExtraRenderChainVEData> m_ExtraDataPool; // 0x50
	private BasicNodePool<MeshHandle> m_MeshHandleNodePool; // 0x58
	private BasicNodePool<TextureEntry> m_TexturePool; // 0x60
	private Dictionary<VisualElement, ExtraRenderChainVEData> m_ExtraData; // 0x68
	private MeshGenerationDeferrer m_MeshGenerationDeferrer; // 0x70
	private Shader m_DefaultShader; // 0x78
	private Shader m_DefaultWorldSpaceShader; // 0x80
	private Material m_DefaultMat; // 0x88
	private Material m_DefaultWorldSpaceMat; // 0x90
	private bool m_BlockDirtyRegistration; // 0x98
	private int m_CustomMaterialCommands; // 0x9C
	private ChainBuilderStats m_Stats; // 0xA0
	private uint m_StatsElementsAdded; // 0xFC
	private uint m_StatsElementsRemoved; // 0x100
	private TextureRegistry m_TextureRegistry; // 0x108
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private OpacityIdAccelerator <opacityIdAccelerator>k__BackingField; // 0x110
	private static EntryPool s_SharedEntryPool; // 0x0
	private static readonly ProfilerMarker k_MarkerProcess; // 0x8
	private static readonly ProfilerMarker k_MarkerClipProcessing; // 0x10
	private static readonly ProfilerMarker k_MarkerOpacityProcessing; // 0x18
	private static readonly ProfilerMarker k_MarkerColorsProcessing; // 0x20
	private static readonly ProfilerMarker k_MarkerTransformProcessing; // 0x28
	private static readonly ProfilerMarker k_MarkerVisualsProcessing; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x118
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private BaseVisualElementPanel <panel>k__BackingField; // 0x120
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UIRenderDevice <device>k__BackingField; // 0x128
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AtlasBase <atlas>k__BackingField; // 0x130
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VectorImageManager <vectorImageManager>k__BackingField; // 0x138
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TempMeshAllocatorImpl <tempMeshAllocator>k__BackingField; // 0x140
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly MeshWriteDataPool <meshWriteDataPool>k__BackingField; // 0x148
	public EntryRecorder entryRecorder; // 0x150
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private MeshGenerationNodeManager <meshGenerationNodeManager>k__BackingField; // 0x158
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private JobManager <jobManager>k__BackingField; // 0x160
	internal UIRVEShaderInfoAllocator shaderInfoAllocator; // 0x168
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <drawStats>k__BackingField; // 0x218
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <drawInCameras>k__BackingField; // 0x219
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <isFlat>k__BackingField; // 0x21A

	// Properties
	public OpacityIdAccelerator opacityIdAccelerator { get; set; }
	protected bool disposed { get; set; }
	internal ChainBuilderStats statsByRef { get; }
	internal BaseVisualElementPanel panel { get; set; }
	internal UIRenderDevice device { get; set; }
	public BaseElementBuilder elementBuilder { get; }
	internal AtlasBase atlas { get; set; }
	internal VectorImageManager vectorImageManager { get; set; }
	internal TempMeshAllocatorImpl tempMeshAllocator { get; set; }
	internal MeshWriteDataPool meshWriteDataPool { get; }
	internal EntryPool entryPool { get; }
	public MeshGenerationDeferrer meshGenerationDeferrer { get; }
	public MeshGenerationNodeManager meshGenerationNodeManager { get; set; }
	internal JobManager jobManager { get; set; }
	internal bool drawStats { get; set; }
	internal bool drawInCameras { get; }
	internal bool isFlat { get; }
	internal Shader defaultShader { set; }
	internal Shader defaultWorldSpaceShader { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x8DB150 Offset: 0x8D9750 VA: 0x1808DB150
	public OpacityIdAccelerator get_opacityIdAccelerator() { }

	[CompilerGenerated]
	// RVA: 0x16212F0 Offset: 0x161F8F0 VA: 0x1816212F0
	private void set_opacityIdAccelerator(OpacityIdAccelerator value) { }

	// RVA: 0x25173B0 Offset: 0x25159B0 VA: 0x1825173B0
	public void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x2516780 Offset: 0x2514D80 VA: 0x182516780
	protected void .ctor(BaseVisualElementPanel panel, UIRenderDevice device, AtlasBase atlas, VectorImageManager vectorImageManager) { }

	[CompilerGenerated]
	// RVA: 0x5613D0 Offset: 0x55F9D0 VA: 0x1805613D0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x561650 Offset: 0x55FC50 VA: 0x180561650
	private void set_disposed(bool value) { }

	// RVA: 0x2513560 Offset: 0x2511B60 VA: 0x182513560 Slot: 4
	public void Dispose() { }

	// RVA: 0x2513080 Offset: 0x2511680 VA: 0x182513080
	protected void Dispose(bool disposing) { }

	// RVA: 0x2517580 Offset: 0x2515B80 VA: 0x182517580
	internal ref ChainBuilderStats get_statsByRef() { }

	// RVA: 0x2514690 Offset: 0x2512C90 VA: 0x182514690
	public void ProcessChanges() { }

	// RVA: 0x2514F30 Offset: 0x2513530 VA: 0x182514F30
	public void Render() { }

	// RVA: 0x2515850 Offset: 0x2513E50 VA: 0x182515850
	public void UIEOnChildAdded(VisualElement ve) { }

	// RVA: 0x2515C80 Offset: 0x2514280 VA: 0x182515C80
	public void UIEOnChildrenReordered(VisualElement ve) { }

	// RVA: 0x2515B70 Offset: 0x2514170 VA: 0x182515B70
	public void UIEOnChildRemoving(VisualElement ve) { }

	// RVA: 0x25162A0 Offset: 0x25148A0 VA: 0x1825162A0
	public void UIEOnRenderHintsChanged(VisualElement ve) { }

	// RVA: 0x2515F80 Offset: 0x2514580 VA: 0x182515F80
	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x2516160 Offset: 0x2514760 VA: 0x182516160
	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = False) { }

	// RVA: 0x2516020 Offset: 0x2514620 VA: 0x182516020
	public void UIEOnColorChanged(VisualElement ve) { }

	// RVA: 0x2516460 Offset: 0x2514A60 VA: 0x182516460
	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) { }

	// RVA: 0x2516510 Offset: 0x2514B10 VA: 0x182516510
	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x2516200 Offset: 0x2514800 VA: 0x182516200
	public void UIEOnOpacityIdChanged(VisualElement ve) { }

	// RVA: 0x25160C0 Offset: 0x25146C0 VA: 0x1825160C0
	public void UIEOnDisableRenderingChanged(VisualElement ve) { }

	[CompilerGenerated]
	// RVA: 0x8DA910 Offset: 0x8D8F10 VA: 0x1808DA910
	internal BaseVisualElementPanel get_panel() { }

	[CompilerGenerated]
	// RVA: 0x8DA9C0 Offset: 0x8D8FC0 VA: 0x1808DA9C0
	private void set_panel(BaseVisualElementPanel value) { }

	[CompilerGenerated]
	// RVA: 0x19DB6F0 Offset: 0x19D9CF0 VA: 0x1819DB6F0
	internal UIRenderDevice get_device() { }

	[CompilerGenerated]
	// RVA: 0x23F6D20 Offset: 0x23F5320 VA: 0x1823F6D20
	private void set_device(UIRenderDevice value) { }

	// RVA: 0x25174F0 Offset: 0x2515AF0 VA: 0x1825174F0
	public BaseElementBuilder get_elementBuilder() { }

	[CompilerGenerated]
	// RVA: 0x17871D0 Offset: 0x17857D0 VA: 0x1817871D0
	internal AtlasBase get_atlas() { }

	[CompilerGenerated]
	// RVA: 0x1AA57D0 Offset: 0x1AA3DD0 VA: 0x181AA57D0
	private void set_atlas(AtlasBase value) { }

	[CompilerGenerated]
	// RVA: 0x1791C80 Offset: 0x1790280 VA: 0x181791C80
	internal VectorImageManager get_vectorImageManager() { }

	[CompilerGenerated]
	// RVA: 0x2443850 Offset: 0x2441E50 VA: 0x182443850
	private void set_vectorImageManager(VectorImageManager value) { }

	[CompilerGenerated]
	// RVA: 0x1791C20 Offset: 0x1790220 VA: 0x181791C20
	internal TempMeshAllocatorImpl get_tempMeshAllocator() { }

	[CompilerGenerated]
	// RVA: 0x218E7B0 Offset: 0x218CDB0 VA: 0x18218E7B0
	private void set_tempMeshAllocator(TempMeshAllocatorImpl value) { }

	[CompilerGenerated]
	// RVA: 0x127C510 Offset: 0x127AB10 VA: 0x18127C510
	internal MeshWriteDataPool get_meshWriteDataPool() { }

	// RVA: 0x2517510 Offset: 0x2515B10 VA: 0x182517510
	internal EntryPool get_entryPool() { }

	// RVA: 0x384BF0 Offset: 0x3831F0 VA: 0x180384BF0
	public MeshGenerationDeferrer get_meshGenerationDeferrer() { }

	[CompilerGenerated]
	// RVA: 0x2517570 Offset: 0x2515B70 VA: 0x182517570
	public MeshGenerationNodeManager get_meshGenerationNodeManager() { }

	[CompilerGenerated]
	// RVA: 0x2517750 Offset: 0x2515D50 VA: 0x182517750
	private void set_meshGenerationNodeManager(MeshGenerationNodeManager value) { }

	[CompilerGenerated]
	// RVA: 0x1BE78F0 Offset: 0x1BE5EF0 VA: 0x181BE78F0
	internal JobManager get_jobManager() { }

	[CompilerGenerated]
	// RVA: 0x2517730 Offset: 0x2515D30 VA: 0x182517730
	private void set_jobManager(JobManager value) { }

	[CompilerGenerated]
	// RVA: 0x25174E0 Offset: 0x2515AE0 VA: 0x1825174E0
	internal bool get_drawStats() { }

	[CompilerGenerated]
	// RVA: 0x1BE7FE0 Offset: 0x1BE65E0 VA: 0x181BE7FE0
	internal void set_drawStats(bool value) { }

	[CompilerGenerated]
	// RVA: 0x25174D0 Offset: 0x2515AD0 VA: 0x1825174D0
	internal bool get_drawInCameras() { }

	[CompilerGenerated]
	// RVA: 0x2517560 Offset: 0x2515B60 VA: 0x182517560
	internal bool get_isFlat() { }

	// RVA: 0x2517590 Offset: 0x2515B90 VA: 0x182517590
	internal void set_defaultShader(Shader value) { }

	// RVA: 0x2517660 Offset: 0x2515C60 VA: 0x182517660
	internal void set_defaultWorldSpaceShader(Shader value) { }

	// RVA: 0x2514380 Offset: 0x2512980 VA: 0x182514380
	internal Material GetStandardMaterial() { }

	// RVA: 0x25144A0 Offset: 0x2512AA0 VA: 0x1825144A0
	internal Material GetStandardWorldSpaceMaterial() { }

	// RVA: 0x2513F90 Offset: 0x2512590 VA: 0x182513F90
	internal void EnsureFitsDepth(int depth) { }

	// RVA: 0x2512FD0 Offset: 0x25115D0 VA: 0x182512FD0
	internal void ChildWillBeRemoved(VisualElement ve) { }

	// RVA: 0x2512DE0 Offset: 0x25113E0 VA: 0x182512DE0
	internal RenderChainCommand AllocCommand() { }

	// RVA: 0x2513FA0 Offset: 0x25125A0 VA: 0x182513FA0
	internal void FreeCommand(RenderChainCommand cmd) { }

	// RVA: 0x25145C0 Offset: 0x2512BC0 VA: 0x1825145C0
	internal void OnRenderCommandAdded(RenderChainCommand command) { }

	// RVA: 0x2514650 Offset: 0x2512C50 VA: 0x182514650
	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) { }

	// RVA: 0x25155C0 Offset: 0x2513BC0 VA: 0x1825155C0
	internal void RepaintTexturedElements() { }

	// RVA: 0x25142B0 Offset: 0x25128B0 VA: 0x1825142B0
	public ExtraRenderChainVEData GetOrAddExtraData(VisualElement ve) { }

	// RVA: 0x2514050 Offset: 0x2512650 VA: 0x182514050
	public void FreeExtraData(VisualElement ve) { }

	// RVA: 0x2512E40 Offset: 0x2511440 VA: 0x182512E40
	public void AppendExtraMesh(VisualElement ve, MeshHandle mesh) { }

	// RVA: 0x2514150 Offset: 0x2512750 VA: 0x182514150
	public void FreeExtraMeshes(VisualElement ve) { }

	// RVA: 0x2512F10 Offset: 0x2511510 VA: 0x182512F10
	public void AppendTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas) { }

	// RVA: 0x2515720 Offset: 0x2513D20 VA: 0x182515720
	public void ResetTextures(VisualElement ve) { }

	// RVA: 0x25135C0 Offset: 0x2511BC0 VA: 0x1825135C0
	private void DrawStats() { }

	// RVA: 0x2514280 Offset: 0x2512880 VA: 0x182514280
	private static VisualElement GetFirstElementInPanel(VisualElement ve) { }

	// RVA: 0x25165B0 Offset: 0x2514BB0 VA: 0x1825165B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
[Flags]
internal enum RenderDataDirtyTypes // TypeDefIndex: 4428
{
	// Fields
	public int value__; // 0x0
	public const RenderDataDirtyTypes None = 0;
	public const RenderDataDirtyTypes Transform = 1;
	public const RenderDataDirtyTypes ClipRectSize = 2;
	public const RenderDataDirtyTypes Clipping = 4;
	public const RenderDataDirtyTypes ClippingHierarchy = 8;
	public const RenderDataDirtyTypes Visuals = 16;
	public const RenderDataDirtyTypes VisualsHierarchy = 32;
	public const RenderDataDirtyTypes VisualsOpacityId = 64;
	public const RenderDataDirtyTypes Opacity = 128;
	public const RenderDataDirtyTypes OpacityHierarchy = 256;
	public const RenderDataDirtyTypes Color = 512;
	public const RenderDataDirtyTypes AllVisuals = 112;
}

// Namespace: UnityEngine.UIElements.UIR
internal enum RenderDataDirtyTypeClasses // TypeDefIndex: 4429
{
	// Fields
	public int value__; // 0x0
	public const RenderDataDirtyTypeClasses Clipping = 0;
	public const RenderDataDirtyTypeClasses Opacity = 1;
	public const RenderDataDirtyTypeClasses Color = 2;
	public const RenderDataDirtyTypeClasses TransformSize = 3;
	public const RenderDataDirtyTypeClasses Visuals = 4;
	public const RenderDataDirtyTypeClasses Count = 5;
}

// Namespace: UnityEngine.UIElements.UIR
[Flags]
internal enum RenderDataFlags // TypeDefIndex: 4430
{
	// Fields
	public int value__; // 0x0
	public const RenderDataFlags IsInChain = 1;
	public const RenderDataFlags IsGroupTransform = 2;
	public const RenderDataFlags IsIgnoringDynamicColorHint = 4;
	public const RenderDataFlags HasExtraData = 8;
	public const RenderDataFlags HasExtraMeshes = 16;
}

// Namespace: UnityEngine.UIElements.UIR
internal struct RenderChainVEData // TypeDefIndex: 4431
{
	// Fields
	public VisualElement prev; // 0x0
	public VisualElement next; // 0x8
	public VisualElement groupTransformAncestor; // 0x10
	public VisualElement boneTransformAncestor; // 0x18
	public VisualElement prevDirty; // 0x20
	public VisualElement nextDirty; // 0x28
	public RenderDataFlags flags; // 0x30
	public int hierarchyDepth; // 0x34
	public RenderDataDirtyTypes dirtiedValues; // 0x38
	public uint dirtyID; // 0x3C
	public RenderChainCommand firstHeadCommand; // 0x40
	public RenderChainCommand lastHeadCommand; // 0x48
	public RenderChainCommand firstTailCommand; // 0x50
	public RenderChainCommand lastTailCommand; // 0x58
	public bool localFlipsWinding; // 0x60
	public bool localTransformScaleZero; // 0x61
	public bool worldFlipsWinding; // 0x62
	public bool worldTransformScaleZero; // 0x63
	public ClipMethod clipMethod; // 0x64
	public int childrenStencilRef; // 0x68
	public int childrenMaskDepth; // 0x6C
	public MeshHandle headMesh; // 0x70
	public MeshHandle tailMesh; // 0x78
	public Matrix4x4 verticesSpace; // 0x80
	public BMPAlloc transformID; // 0xC0
	public BMPAlloc clipRectID; // 0xC8
	public BMPAlloc opacityID; // 0xD0
	public BMPAlloc textCoreSettingsID; // 0xD8
	public BMPAlloc colorID; // 0xE0
	public BMPAlloc backgroundColorID; // 0xE8
	public BMPAlloc borderLeftColorID; // 0xF0
	public BMPAlloc borderTopColorID; // 0xF8
	public BMPAlloc borderRightColorID; // 0x100
	public BMPAlloc borderBottomColorID; // 0x108
	public BMPAlloc tintColorID; // 0x110
	public float compositeOpacity; // 0x118
	public float backgroundAlpha; // 0x11C
	public BasicNode<TextureEntry> textures; // 0x120
	public bool pendingRepaint; // 0x128
	public bool pendingHierarchicalRepaint; // 0x129

	// Properties
	public RenderChainCommand lastTailOrHeadCommand { get; }
	public bool isInChain { get; }
	public bool isGroupTransform { get; }
	public bool isIgnoringDynamicColorHint { get; }
	public bool hasExtraData { get; }
	public bool hasExtraMeshes { get; }

	// Methods

	// RVA: 0x2512DD0 Offset: 0x25113D0 VA: 0x182512DD0
	public RenderChainCommand get_lastTailOrHeadCommand() { }

	// RVA: 0x2512CD0 Offset: 0x25112D0 VA: 0x182512CD0
	public static bool AllocatesID(BMPAlloc alloc) { }

	// RVA: 0x2512D30 Offset: 0x2511330 VA: 0x182512D30
	public static bool InheritsID(BMPAlloc alloc) { }

	// RVA: 0x2512DC0 Offset: 0x25113C0 VA: 0x182512DC0
	public bool get_isInChain() { }

	// RVA: 0x2512DB0 Offset: 0x25113B0 VA: 0x182512DB0
	public bool get_isGroupTransform() { }

	// RVA: 0x157FC70 Offset: 0x157E270 VA: 0x18157FC70
	public bool get_isIgnoringDynamicColorHint() { }

	// RVA: 0x2512D90 Offset: 0x2511390 VA: 0x182512D90
	public bool get_hasExtraData() { }

	// RVA: 0x2512DA0 Offset: 0x25113A0 VA: 0x182512DA0
	public bool get_hasExtraMeshes() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class ExtraRenderChainVEData : LinkedPoolItem<ExtraRenderChainVEData> // TypeDefIndex: 4432
{
	// Fields
	public BasicNode<MeshHandle> extraMesh; // 0x18

	// Methods

	// RVA: 0x25124B0 Offset: 0x2510AB0 VA: 0x1825124B0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct TextureEntry // TypeDefIndex: 4433
{
	// Fields
	public Texture source; // 0x0
	public TextureId actual; // 0x8
	public bool replaced; // 0xC
}

// Namespace: UnityEngine.UIElements.UIR
internal enum ClipMethod // TypeDefIndex: 4434
{
	// Fields
	public int value__; // 0x0
	public const ClipMethod Undetermined = 0;
	public const ClipMethod NotClipped = 1;
	public const ClipMethod Scissor = 2;
	public const ClipMethod ShaderDiscard = 3;
	public const ClipMethod Stencil = 4;
}

// Namespace: UnityEngine.UIElements.UIR
internal static class RenderEvents // TypeDefIndex: 4435
{
	// Fields
	private static readonly ProfilerMarker k_NudgeVerticesMarker; // 0x0
	private static readonly float VisibilityTreshold; // 0x8

	// Methods

	// RVA: 0x251BC50 Offset: 0x251A250 VA: 0x18251BC50
	internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x251BE00 Offset: 0x251A400 VA: 0x18251BE00
	internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x251BD70 Offset: 0x251A370 VA: 0x18251BD70
	internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x251BF10 Offset: 0x251A510 VA: 0x18251BF10
	internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x251A5D0 Offset: 0x2518BD0 VA: 0x18251A5D0
	private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve) { }

	// RVA: 0x251A2E0 Offset: 0x25188E0 VA: 0x18251A2E0
	private static Vector4 GetClipRectIDClipInfo(VisualElement ve) { }

	// RVA: 0x2517770 Offset: 0x2515D70 VA: 0x182517770
	internal static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState) { }

	// RVA: 0x2517FF0 Offset: 0x25165F0 VA: 0x182517FF0
	internal static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x2519050 Offset: 0x2517650 VA: 0x182519050
	private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats) { }

	// RVA: 0x2519740 Offset: 0x2517D40 VA: 0x182519740
	private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = False) { }

	// RVA: 0x251B7C0 Offset: 0x2519DC0 VA: 0x18251B7C0
	private static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x2519C20 Offset: 0x2518220 VA: 0x182519C20
	private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats) { }

	// RVA: 0x251C900 Offset: 0x251AF00 VA: 0x18251C900
	public static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x251B1B0 Offset: 0x25197B0 VA: 0x18251B1B0
	private static bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device) { }

	// RVA: 0x251BB00 Offset: 0x251A100 VA: 0x18251BB00
	private static void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count) { }

	// RVA: 0x251A550 Offset: 0x2518B50 VA: 0x18251A550
	private static VisualElement GetLastDeepestChild(VisualElement ve) { }

	// RVA: 0x251A1E0 Offset: 0x25187E0 VA: 0x18251A1E0
	private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x251C7F0 Offset: 0x251ADF0 VA: 0x18251C7F0
	private static bool UpdateLocalFlipsWinding(VisualElement ve) { }

	// RVA: 0x251CEC0 Offset: 0x251B4C0 VA: 0x18251CEC0
	private static void UpdateZeroScaling(VisualElement ve) { }

	// RVA: 0x251B170 Offset: 0x2519770 VA: 0x18251B170
	private static bool NeedsTransformID(VisualElement ve) { }

	// RVA: 0x251B070 Offset: 0x2519670 VA: 0x18251B070
	internal static bool NeedsColorID(VisualElement ve) { }

	// RVA: 0x251B090 Offset: 0x2519690 VA: 0x18251B090
	internal static bool NeedsTextCoreSettings(VisualElement ve) { }

	// RVA: 0x251A7B0 Offset: 0x2518DB0 VA: 0x18251A7B0
	private static bool InitColorIDs(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x251BFF0 Offset: 0x251A5F0 VA: 0x18251BFF0
	public static void SetColorValues(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x251D0D0 Offset: 0x251B6D0 VA: 0x18251D0D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal abstract class BaseShaderInfoStorage : IDisposable // TypeDefIndex: 4436
{
	// Fields
	protected static int s_TextureCounter; // 0x0
	internal static ProfilerMarker s_MarkerCopyTexture; // 0x8
	internal static ProfilerMarker s_MarkerGetTextureData; // 0x10
	internal static ProfilerMarker s_MarkerUpdateTexture; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public abstract Texture2D texture { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Texture2D get_texture();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool AllocateRect(int width, int height, out RectInt uvs);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetTexel(int x, int y, Color color);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void UpdateTexture();

	[CompilerGenerated]
	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x3996B0 Offset: 0x397CB0 VA: 0x1803996B0
	private void set_disposed(bool value) { }

	// RVA: 0x25113E0 Offset: 0x250F9E0 VA: 0x1825113E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x25113D0 Offset: 0x250F9D0 VA: 0x1825113D0 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x2511440 Offset: 0x250FA40 VA: 0x182511440
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorage<T> : BaseShaderInfoStorage // TypeDefIndex: 4437
{
	// Fields
	private readonly int m_InitialSize; // 0x0
	private readonly int m_MaxSize; // 0x0
	private readonly TextureFormat m_Format; // 0x0
	private readonly Func<Color, T> m_Convert; // 0x0
	private UIRAtlasAllocator m_Allocator; // 0x0
	private Texture2D m_Texture; // 0x0
	private NativeArray<T> m_Texels; // 0x0

	// Properties
	public override Texture2D texture { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TextureFormat format, Func<Color, T> convert, int initialSize = 64, int maxSize = 4096) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9702A0 Offset: 0x96E8A0 VA: 0x1809702A0
	|-ShaderInfoStorage<Color>..ctor
	|
	|-RVA: 0x9703B0 Offset: 0x96E9B0 VA: 0x1809703B0
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96FD60 Offset: 0x96E360 VA: 0x18096FD60
	|-ShaderInfoStorage<Color>.Dispose
	|
	|-RVA: 0x96FC90 Offset: 0x96E290 VA: 0x18096FC90
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override Texture2D get_texture() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	|-ShaderInfoStorage<Color>.get_texture
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.get_texture
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool AllocateRect(int width, int height, out RectInt uvs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96EED0 Offset: 0x96D4D0 VA: 0x18096EED0
	|-ShaderInfoStorage<Color>.AllocateRect
	|
	|-RVA: 0x96F030 Offset: 0x96D630 VA: 0x18096F030
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.AllocateRect
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void SetTexel(int x, int y, Color color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x970000 Offset: 0x96E600 VA: 0x180970000
	|-ShaderInfoStorage<Color>.SetTexel
	|
	|-RVA: 0x96FE30 Offset: 0x96E430 VA: 0x18096FE30
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.SetTexel
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void UpdateTexture() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x970100 Offset: 0x96E700 VA: 0x180970100
	|-ShaderInfoStorage<Color>.UpdateTexture
	|
	|-RVA: 0x9701B0 Offset: 0x96E7B0 VA: 0x1809701B0
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.UpdateTexture
	*/

	// RVA: -1 Offset: -1
	private void CreateOrExpandTexture() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96F4C0 Offset: 0x96DAC0 VA: 0x18096F4C0
	|-ShaderInfoStorage<Color>.CreateOrExpandTexture
	|
	|-RVA: 0x96F8C0 Offset: 0x96DEC0 VA: 0x18096F8C0
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.CreateOrExpandTexture
	*/

	// RVA: -1 Offset: -1
	private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x96F3B0 Offset: 0x96D9B0 VA: 0x18096F3B0
	|-ShaderInfoStorage<Color>.CpuBlit
	|
	|-RVA: 0x96F190 Offset: 0x96D790 VA: 0x18096F190
	|-ShaderInfoStorage<__Il2CppFullySharedGenericStructType>.CpuBlit
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorageRGBAFloat : ShaderInfoStorage<Color> // TypeDefIndex: 4439
{
	// Fields
	private static readonly Func<Color, Color> s_Convert; // 0x0

	// Methods

	// RVA: 0x251D220 Offset: 0x251B820 VA: 0x18251D220
	public void .ctor(int initialSize = 64, int maxSize = 4096) { }

	// RVA: 0x251D150 Offset: 0x251B750 VA: 0x18251D150
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal static class Shaders // TypeDefIndex: 4440
{
	// Fields
	public static readonly string k_AtlasBlit; // 0x0
	public static readonly string k_Editor; // 0x8
	public static readonly string k_Runtime; // 0x10
	public static readonly string k_RuntimeWorld; // 0x18
	public static readonly string k_ColorConversionBlit; // 0x20

	// Methods

	// RVA: 0x251D2C0 Offset: 0x251B8C0 VA: 0x18251D2C0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class TempAllocator<T> : IDisposable // TypeDefIndex: 4442
{
	// Fields
	private readonly int m_ExcessMinCapacity; // 0x0
	private readonly int m_ExcessMaxCapacity; // 0x0
	private TempAllocator.Page<T> m_Pool; // 0x0
	private List<TempAllocator.Page<T>> m_Excess; // 0x0
	private int m_NextExcessSize; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x0

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int poolCapacity, int excessMinCapacity, int excessMaxCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E9580 Offset: 0x9E7B80 VA: 0x1809E9580
	|-TempAllocator<ushort>..ctor
	|
	|-RVA: 0x9E9800 Offset: 0x9E7E00 VA: 0x1809E9800
	|-TempAllocator<Vertex>..ctor
	|
	|-RVA: 0x9E96C0 Offset: 0x9E7CC0 VA: 0x1809E96C0
	|-TempAllocator<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected bool get_disposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E9940 Offset: 0x9E7F40 VA: 0x1809E9940
	|-TempAllocator<ushort>.get_disposed
	|-TempAllocator<Vertex>.get_disposed
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.get_disposed
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_disposed(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E9950 Offset: 0x9E7F50 VA: 0x1809E9950
	|-TempAllocator<ushort>.set_disposed
	|-TempAllocator<Vertex>.set_disposed
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.set_disposed
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E83C0 Offset: 0x9E69C0 VA: 0x1809E83C0
	|-TempAllocator<ushort>.Dispose
	|
	|-RVA: 0x9E82F0 Offset: 0x9E68F0 VA: 0x1809E82F0
	|-TempAllocator<Vertex>.Dispose
	|
	|-RVA: 0x9E8200 Offset: 0x9E6800 VA: 0x1809E8200
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	protected void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E8270 Offset: 0x9E6870 VA: 0x1809E8270
	|-TempAllocator<ushort>.Dispose
	|-TempAllocator<Vertex>.Dispose
	|
	|-RVA: 0x9E8150 Offset: 0x9E6750 VA: 0x1809E8150
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public NativeSlice<T> Alloc(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E8100 Offset: 0x9E6700 VA: 0x1809E8100
	|-TempAllocator<ushort>.Alloc
	|
	|-RVA: 0x9E80B0 Offset: 0x9E66B0 VA: 0x1809E80B0
	|-TempAllocator<Vertex>.Alloc
	|
	|-RVA: 0x9E8050 Offset: 0x9E6650 VA: 0x1809E8050
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Alloc
	*/

	// RVA: -1 Offset: -1
	private NativeSlice<T> DoAlloc(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E8490 Offset: 0x9E6A90 VA: 0x1809E8490
	|-TempAllocator<ushort>.DoAlloc
	|
	|-RVA: 0x9E8D50 Offset: 0x9E7350 VA: 0x1809E8D50
	|-TempAllocator<Vertex>.DoAlloc
	|
	|-RVA: 0x9E88B0 Offset: 0x9E6EB0 VA: 0x1809E88B0
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.DoAlloc
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E9540 Offset: 0x9E7B40 VA: 0x1809E9540
	|-TempAllocator<ushort>.Reset
	|-TempAllocator<Vertex>.Reset
	|
	|-RVA: 0x9E9500 Offset: 0x9E7B00 VA: 0x1809E9500
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1
	private void ReleaseExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9E9170 Offset: 0x9E7770 VA: 0x1809E9170
	|-TempAllocator<ushort>.ReleaseExcess
	|-TempAllocator<Vertex>.ReleaseExcess
	|
	|-RVA: 0x9E92F0 Offset: 0x9E78F0 VA: 0x1809E92F0
	|-TempAllocator<__Il2CppFullySharedGenericStructType>.ReleaseExcess
	*/
}

// Namespace: UnityEngine.UIElements.UIR
internal class TempMeshAllocatorImpl : IDisposable // TypeDefIndex: 4444
{
	// Fields
	private GCHandle m_GCHandle; // 0x10
	private TempMeshAllocatorImpl.ThreadData[] m_ThreadData; // 0x18
	private TempAllocator<Vertex> m_VertexPool; // 0x20
	private TempAllocator<ushort> m_IndexPool; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x30

	// Properties
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x251DA10 Offset: 0x251C010 VA: 0x18251DA10
	public void .ctor() { }

	// RVA: 0x251D8A0 Offset: 0x251BEA0 VA: 0x18251D8A0
	public void CreateNativeHandle(out TempMeshAllocator allocator) { }

	// RVA: -1 Offset: -1
	private NativeSlice<T> Allocate<T>(int count, int alignment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7C4CC0 Offset: 0x7C32C0 VA: 0x1807C4CC0
	|-TempMeshAllocatorImpl.Allocate<ushort>
	|
	|-RVA: 0x7C4E90 Offset: 0x7C3490 VA: 0x1807C4E90
	|-TempMeshAllocatorImpl.Allocate<Vertex>
	|
	|-RVA: 0x7C4AF0 Offset: 0x7C30F0 VA: 0x1807C4AF0
	|-TempMeshAllocatorImpl.Allocate<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x251D430 Offset: 0x251BA30 VA: 0x18251D430
	public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex> vertices, out NativeSlice<ushort> indices) { }

	// RVA: 0x251D6A0 Offset: 0x251BCA0 VA: 0x18251D6A0
	public void Clear() { }

	[CompilerGenerated]
	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	private void set_disposed(bool value) { }

	// RVA: 0x251D8B0 Offset: 0x251BEB0 VA: 0x18251D8B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x251D970 Offset: 0x251BF70 VA: 0x18251D970
	protected void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct TextCoreSettings : IEquatable<TextCoreSettings> // TypeDefIndex: 4445
{
	// Fields
	public Color faceColor; // 0x0
	public Color outlineColor; // 0x10
	public float outlineWidth; // 0x20
	public Color underlayColor; // 0x24
	public Vector2 underlayOffset; // 0x34
	public float underlaySoftness; // 0x3C

	// Methods

	// RVA: 0x251DBE0 Offset: 0x251C1E0 VA: 0x18251DBE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x251DC90 Offset: 0x251C290 VA: 0x18251DC90 Slot: 4
	public bool Equals(TextCoreSettings other) { }

	// RVA: 0x251DE30 Offset: 0x251C430 VA: 0x18251DE30 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class TextureBlitter : IDisposable // TypeDefIndex: 4447
{
	// Fields
	private static readonly int[] k_TextureIds; // 0x0
	private static ProfilerMarker s_CommitSampler; // 0x8
	private TextureBlitter.BlitInfo[] m_SingleBlit; // 0x10
	private Material m_BlitMaterial; // 0x18
	private MaterialPropertyBlock m_Properties; // 0x20
	private RectInt m_Viewport; // 0x28
	private RenderTexture m_PrevRT; // 0x38
	private List<TextureBlitter.BlitInfo> m_PendingBlits; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x48

	// Properties
	protected bool disposed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x132E3F0 Offset: 0x132C9F0 VA: 0x18132E3F0
	private void set_disposed(bool value) { }

	// RVA: 0x251E360 Offset: 0x251C960 VA: 0x18251E360 Slot: 4
	public void Dispose() { }

	// RVA: 0x251E3C0 Offset: 0x251C9C0 VA: 0x18251E3C0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x251ED10 Offset: 0x251D310 VA: 0x18251ED10
	private static void .cctor() { }

	// RVA: 0x251EE40 Offset: 0x251D440 VA: 0x18251EE40
	public void .ctor(int capacity = 512) { }

	// RVA: 0x251EB80 Offset: 0x251D180 VA: 0x18251EB80
	public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x251E120 Offset: 0x251C720 VA: 0x18251E120
	public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x251E260 Offset: 0x251C860 VA: 0x18251E260
	public void Commit(RenderTexture dst) { }

	// RVA: 0x251DEE0 Offset: 0x251C4E0 VA: 0x18251DEE0
	private void BeginBlit(RenderTexture dst) { }

	// RVA: 0x251E440 Offset: 0x251CA40 VA: 0x18251E440
	private void DoBlit(IList<TextureBlitter.BlitInfo> blitInfos, int startIndex) { }

	// RVA: 0x251EAE0 Offset: 0x251D0E0 VA: 0x18251EAE0
	private void EndBlit() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class TextureSlotManager // TypeDefIndex: 4448
{
	// Fields
	internal static readonly int k_SlotCount; // 0x0
	internal static readonly int k_SlotSize; // 0x4
	internal static readonly int[] slotIds; // 0x8
	internal static readonly int textureTableId; // 0x10
	private TextureId[] m_Textures; // 0x10
	private int[] m_Tickets; // 0x18
	private int m_CurrentTicket; // 0x20
	private int m_FirstUsedTicket; // 0x24
	private Vector4[] m_GpuTextures; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <FreeSlots>k__BackingField; // 0x30
	internal TextureRegistry textureRegistry; // 0x38

	// Properties
	public int FreeSlots { get; set; }

	// Methods

	// RVA: 0x251F760 Offset: 0x251DD60 VA: 0x18251F760
	private static void .cctor() { }

	// RVA: 0x251F8D0 Offset: 0x251DED0 VA: 0x18251F8D0
	public void .ctor() { }

	// RVA: 0x251F400 Offset: 0x251DA00 VA: 0x18251F400
	public void Reset() { }

	// RVA: 0x251F6F0 Offset: 0x251DCF0 VA: 0x18251F6F0
	public void StartNewBatch() { }

	// RVA: 0x251F2C0 Offset: 0x251D8C0 VA: 0x18251F2C0
	public int IndexOf(TextureId id) { }

	// RVA: 0x251F3A0 Offset: 0x251D9A0 VA: 0x18251F3A0
	public void MarkUsed(int slotIndex) { }

	[CompilerGenerated]
	// RVA: 0x4FEEF0 Offset: 0x4FD4F0 VA: 0x1804FEEF0
	public int get_FreeSlots() { }

	[CompilerGenerated]
	// RVA: 0x111F9D0 Offset: 0x111DFD0 VA: 0x18111F9D0
	private void set_FreeSlots(int value) { }

	// RVA: 0x251F200 Offset: 0x251D800 VA: 0x18251F200
	public int FindOldestSlot() { }

	// RVA: 0x251EF00 Offset: 0x251D500 VA: 0x18251EF00
	public void Bind(TextureId id, float sdfScale, float sharpness, int slot, MaterialPropertyBlock mat, CommandList commandList) { }

	// RVA: 0x251F550 Offset: 0x251DB50 VA: 0x18251F550
	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale, float sharpness) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageRenderInfoPool : LinkedPool<VectorImageRenderInfo> // TypeDefIndex: 4450
{
	// Methods

	// RVA: 0x2523230 Offset: 0x2521830 VA: 0x182523230
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo> // TypeDefIndex: 4451
{
	// Fields
	public int useCount; // 0x18
	public GradientRemap firstGradientRemap; // 0x20
	public Alloc gradientSettingsAlloc; // 0x28

	// Methods

	// RVA: 0x2523410 Offset: 0x2521A10 VA: 0x182523410
	public void Reset() { }

	// RVA: 0x2523440 Offset: 0x2521A40 VA: 0x182523440
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientRemapPool : LinkedPool<GradientRemap> // TypeDefIndex: 4453
{
	// Methods

	// RVA: 0x25124F0 Offset: 0x2510AF0 VA: 0x1825124F0
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientRemap : LinkedPoolItem<GradientRemap> // TypeDefIndex: 4454
{
	// Fields
	public int origIndex; // 0x18
	public int destIndex; // 0x1C
	public RectInt location; // 0x20
	public GradientRemap next; // 0x30
	public TextureId atlas; // 0x38

	// Methods

	// RVA: 0x25126D0 Offset: 0x2510CD0 VA: 0x1825126D0
	public void Reset() { }

	// RVA: 0x2512740 Offset: 0x2510D40 VA: 0x182512740
	public void .ctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageManager : IDisposable // TypeDefIndex: 4455
{
	// Fields
	public static List<VectorImageManager> instances; // 0x0
	private static ProfilerMarker s_MarkerRegister; // 0x8
	private static ProfilerMarker s_MarkerUnregister; // 0x10
	private readonly AtlasBase m_Atlas; // 0x10
	private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered; // 0x18
	private VectorImageRenderInfoPool m_RenderInfoPool; // 0x20
	private GradientRemapPool m_GradientRemapPool; // 0x28
	private GradientSettingsAtlas m_GradientSettingsAtlas; // 0x30
	private bool m_LoggedExhaustedSettingsAtlas; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x39

	// Properties
	public Texture2D atlas { get; }
	protected bool disposed { get; set; }

	// Methods

	// RVA: 0x2523210 Offset: 0x2521810 VA: 0x182523210
	public Texture2D get_atlas() { }

	// RVA: 0x2522CC0 Offset: 0x25212C0 VA: 0x182522CC0
	public void .ctor(AtlasBase atlas) { }

	[CompilerGenerated]
	// RVA: 0xADABC0 Offset: 0xAD91C0 VA: 0x180ADABC0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0xADB1E0 Offset: 0xAD97E0 VA: 0x180ADB1E0
	private void set_disposed(bool value) { }

	// RVA: 0x2522710 Offset: 0x2520D10 VA: 0x182522710 Slot: 4
	public void Dispose() { }

	// RVA: 0x25225F0 Offset: 0x2520BF0 VA: 0x1825225F0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x25225C0 Offset: 0x2520BC0 VA: 0x1825225C0
	public void Commit() { }

	// RVA: 0x25224C0 Offset: 0x2520AC0 VA: 0x1825224C0
	public GradientRemap AddUser(VectorImage vi, VisualElement context) { }

	// RVA: 0x2522770 Offset: 0x2520D70 VA: 0x182522770
	private VectorImageRenderInfo Register(VectorImage vi, VisualElement context) { }

	// RVA: 0x2522BC0 Offset: 0x25211C0 VA: 0x182522BC0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal enum OwnedState // TypeDefIndex: 4456
{
	// Fields
	public byte value__; // 0x0
	public const OwnedState Inherited = 0;
	public const OwnedState Owned = 1;
}

// Namespace: UnityEngine.UIElements.UIR
internal struct BMPAlloc // TypeDefIndex: 4457
{
	// Fields
	public static readonly BMPAlloc Invalid; // 0x0
	public int page; // 0x0
	public ushort pageLine; // 0x4
	public byte bitIndex; // 0x6
	public OwnedState ownedState; // 0x7

	// Methods

	// RVA: 0x25112B0 Offset: 0x250F8B0 VA: 0x1825112B0
	public bool Equals(BMPAlloc other) { }

	// RVA: 0x25112D0 Offset: 0x250F8D0 VA: 0x1825112D0
	public bool IsValid() { }

	// RVA: 0x25112E0 Offset: 0x250F8E0 VA: 0x1825112E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2511380 Offset: 0x250F980 VA: 0x182511380
	private static void .cctor() { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct BitmapAllocator32 // TypeDefIndex: 4459
{
	// Fields
	private int m_PageHeight; // 0x0
	private List<BitmapAllocator32.Page> m_Pages; // 0x8
	private List<uint> m_AllocMap; // 0x10
	private int m_EntryWidth; // 0x18
	private int m_EntryHeight; // 0x1C

	// Properties
	public int entryWidth { get; }
	public int entryHeight { get; }

	// Methods

	// RVA: 0x25119B0 Offset: 0x250FFB0 VA: 0x1825119B0
	public void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1) { }

	// RVA: 0x2511B60 Offset: 0x2510160 VA: 0x182511B60
	public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY) { }

	// RVA: 0x2511510 Offset: 0x250FB10 VA: 0x182511510
	public BMPAlloc Allocate(BaseShaderInfoStorage storage) { }

	// RVA: 0x2511D10 Offset: 0x2510310 VA: 0x182511D10
	public void Free(BMPAlloc alloc) { }

	// RVA: 0xA3D180 Offset: 0xA3B780 VA: 0x180A3D180
	public int get_entryWidth() { }

	// RVA: 0x101AB80 Offset: 0x1019180 VA: 0x18101AB80
	public int get_entryHeight() { }

	// RVA: 0x2511E50 Offset: 0x2510450 VA: 0x182511E50
	internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y) { }

	// RVA: 0x2511AD0 Offset: 0x25100D0 VA: 0x182511AD0
	private static byte CountTrailingZeroes(uint val) { }
}

// Namespace: UnityEngine.UIElements.UIR
internal struct UIRVEShaderInfoAllocator // TypeDefIndex: 4460
{
	// Fields
	private BaseShaderInfoStorage m_Storage; // 0x0
	private BitmapAllocator32 m_TransformAllocator; // 0x8
	private BitmapAllocator32 m_ClipRectAllocator; // 0x28
	private BitmapAllocator32 m_OpacityAllocator; // 0x48
	private BitmapAllocator32 m_ColorAllocator; // 0x68
	private BitmapAllocator32 m_TextSettingsAllocator; // 0x88
	private bool m_StorageReallyCreated; // 0xA8
	internal static readonly Vector2Int identityTransformTexel; // 0x0
	internal static readonly Vector2Int infiniteClipRectTexel; // 0x8
	internal static readonly Vector2Int fullOpacityTexel; // 0x10
	internal static readonly Vector2Int clearColorTexel; // 0x18
	internal static readonly Vector2Int defaultTextCoreSettingsTexel; // 0x20
	internal static readonly Matrix4x4 identityTransformValue; // 0x28
	internal static readonly Vector4 identityTransformRow0Value; // 0x68
	internal static readonly Vector4 identityTransformRow1Value; // 0x78
	internal static readonly Vector4 identityTransformRow2Value; // 0x88
	internal static readonly Vector4 infiniteClipRectValue; // 0x98
	internal static readonly Vector4 fullOpacityValue; // 0xA8
	internal static readonly Vector4 clearColorValue; // 0xB8
	internal static readonly TextCoreSettings defaultTextCoreSettingsValue; // 0xC8
	public static readonly BMPAlloc identityTransform; // 0x108
	public static readonly BMPAlloc infiniteClipRect; // 0x110
	public static readonly BMPAlloc fullOpacity; // 0x118
	public static readonly BMPAlloc clearColor; // 0x120
	public static readonly BMPAlloc defaultTextCoreSettings; // 0x128

	// Properties
	private static int pageWidth { get; }
	private static int pageHeight { get; }
	public Texture atlas { get; }

	// Methods

	// RVA: 0x25224B0 Offset: 0x2520AB0 VA: 0x1825224B0
	private static int get_pageWidth() { }

	// RVA: 0x25224A0 Offset: 0x2520AA0 VA: 0x1825224A0
	private static int get_pageHeight() { }

	// RVA: 0x2520220 Offset: 0x251E820 VA: 0x182520220
	private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc) { }

	// RVA: 0x2520320 Offset: 0x251E920 VA: 0x182520320
	private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) { }

	// RVA: 0x2522420 Offset: 0x2520A20 VA: 0x182522420
	public Texture get_atlas() { }

	// RVA: 0x25206F0 Offset: 0x251ECF0 VA: 0x1825206F0
	public void Construct() { }

	// RVA: 0x2520DF0 Offset: 0x251F3F0 VA: 0x182520DF0
	private void ReallyCreateStorage() { }

	// RVA: 0x2520900 Offset: 0x251EF00 VA: 0x182520900
	public void Dispose() { }

	// RVA: 0x2520CB0 Offset: 0x251F2B0 VA: 0x182520CB0
	public void IssuePendingStorageChanges() { }

	// RVA: 0x25202B0 Offset: 0x251E8B0 VA: 0x1825202B0
	public BMPAlloc AllocTransform() { }

	// RVA: 0x2520060 Offset: 0x251E660 VA: 0x182520060
	public BMPAlloc AllocClipRect() { }

	// RVA: 0x2520140 Offset: 0x251E740 VA: 0x182520140
	public BMPAlloc AllocOpacity() { }

	// RVA: 0x25200D0 Offset: 0x251E6D0 VA: 0x1825200D0
	public BMPAlloc AllocColor() { }

	// RVA: 0x25201B0 Offset: 0x251E7B0 VA: 0x1825201B0
	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) { }

	// RVA: 0x2521C90 Offset: 0x2520290 VA: 0x182521C90
	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) { }

	// RVA: 0x2521480 Offset: 0x251FA80 VA: 0x182521480
	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) { }

	// RVA: 0x2521750 Offset: 0x251FD50 VA: 0x182521750
	public void SetOpacityValue(BMPAlloc alloc, float opacity) { }

	// RVA: 0x25215B0 Offset: 0x251FBB0 VA: 0x1825215B0
	public void SetColorValue(BMPAlloc alloc, Color color, bool isEditorContext) { }

	// RVA: 0x2521880 Offset: 0x251FE80 VA: 0x182521880
	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext) { }

	// RVA: 0x2520C10 Offset: 0x251F210 VA: 0x182520C10
	public void FreeTransform(BMPAlloc alloc) { }

	// RVA: 0x2520990 Offset: 0x251EF90 VA: 0x182520990
	public void FreeClipRect(BMPAlloc alloc) { }

	// RVA: 0x2520AD0 Offset: 0x251F0D0 VA: 0x182520AD0
	public void FreeOpacity(BMPAlloc alloc) { }

	// RVA: 0x2520A30 Offset: 0x251F030 VA: 0x182520A30
	public void FreeColor(BMPAlloc alloc) { }

	// RVA: 0x2520B70 Offset: 0x251F170 VA: 0x182520B70
	public void FreeTextCoreSettings(BMPAlloc alloc) { }

	// RVA: 0x2522000 Offset: 0x2520600 VA: 0x182522000
	public Color32 TransformAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x25204B0 Offset: 0x251EAB0 VA: 0x1825204B0
	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x2520CD0 Offset: 0x251F2D0 VA: 0x182520CD0
	public Color32 OpacityAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x25205D0 Offset: 0x251EBD0 VA: 0x1825205D0
	public Color32 ColorAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x2521EE0 Offset: 0x25204E0 VA: 0x182521EE0
	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) { }

	// RVA: 0x2522120 Offset: 0x2520720 VA: 0x182522120
	private static void .cctor() { }
}

