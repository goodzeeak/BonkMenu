// Namespace: UnityEngine.Experimental.Playables
[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("CameraPlayableBindings", 2)]
[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
[RequiredByNativeCode]
public struct CameraPlayable : IEquatable<CameraPlayable> // TypeDefIndex: 10159
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x234D6E0 Offset: 0x234BCE0 VA: 0x18234D6E0 Slot: 4
	public bool Equals(CameraPlayable other) { }
}

// Namespace: UnityEngine.Experimental.Playables
[RequiredByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
[StaticAccessor("MaterialEffectPlayableBindings", 2)]
public struct MaterialEffectPlayable : IEquatable<MaterialEffectPlayable> // TypeDefIndex: 10160
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x2357A40 Offset: 0x2356040 VA: 0x182357A40 Slot: 4
	public bool Equals(MaterialEffectPlayable other) { }
}

// Namespace: UnityEngine.Experimental.Playables
[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("TextureMixerPlayableBindings", 2)]
[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
[RequiredByNativeCode]
public struct TextureMixerPlayable : IEquatable<TextureMixerPlayable> // TypeDefIndex: 10161
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x2364130 Offset: 0x2362730 VA: 0x182364130 Slot: 4
	public bool Equals(TextureMixerPlayable other) { }
}

// Namespace: UnityEngine.Experimental.Playables
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[StaticAccessor("TexturePlayableOutputBindings", 2)]
public struct TexturePlayableOutput // TypeDefIndex: 10162
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

