// Namespace: UnityEngine.Experimental.Audio
[StaticAccessor("AudioSampleProviderBindings", 2)]
[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
public class AudioSampleProvider // TypeDefIndex: 14107
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x22EC2A0 Offset: 0x22EA8A0 VA: 0x1822EC2A0
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCode]
	// RVA: 0x22EC2C0 Offset: 0x22EA8C0 VA: 0x1822EC2C0
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }
}

