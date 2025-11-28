// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioResource.h")]
public abstract class AudioResource : Object // TypeDefIndex: 14108
{}

// Namespace: UnityEngine.Audio
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[StaticAccessor("AudioClipPlayableBindings", 2)]
public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 14109
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22EBA80 Offset: 0x22EA080 VA: 0x1822EBA80 Slot: 4
	public bool Equals(AudioClipPlayable other) { }
}

// Namespace: UnityEngine.Audio
[ExcludeFromObjectFactory]
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
[ExcludeFromPreset]
public class AudioMixer : Object // TypeDefIndex: 14110
{
	// Methods

	[NativeMethod]
	// RVA: 0x22EC0C0 Offset: 0x22EA6C0 VA: 0x1822EC0C0
	public bool SetFloat(string name, float value) { }

	// RVA: 0x22EC060 Offset: 0x22EA660 VA: 0x1822EC060
	private static bool SetFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
public class AudioMixerGroup : Object // TypeDefIndex: 14111
{}

// Namespace: UnityEngine.Audio
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
[StaticAccessor("AudioMixerPlayableBindings", 2)]
[RequiredByNativeCode]
public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable> // TypeDefIndex: 14112
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x22E7300 Offset: 0x22E5900 VA: 0x1822E7300 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x22EBFE0 Offset: 0x22EA5E0 VA: 0x1822EBFE0 Slot: 4
	public bool Equals(AudioMixerPlayable other) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
public class AudioMixerSnapshot : Object // TypeDefIndex: 14113
{}

// Namespace: UnityEngine.Audio
[RequiredByNativeCode]
[StaticAccessor("AudioPlayableOutputBindings", 2)]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
public struct AudioPlayableOutput // TypeDefIndex: 14114
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

