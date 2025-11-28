// Namespace: UnityEngine.Windows.Speech
public static class PhraseRecognitionSystem // TypeDefIndex: 9808
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static PhraseRecognitionSystem.ErrorDelegate OnError; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static PhraseRecognitionSystem.StatusDelegate OnStatusChanged; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x23598B0 Offset: 0x2357EB0 VA: 0x1823598B0
	private static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode) { }

	[RequiredByNativeCode]
	// RVA: 0x2359910 Offset: 0x2357F10 VA: 0x182359910
	private static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status) { }
}

// Namespace: UnityEngine.Windows.Speech
public abstract class PhraseRecognizer // TypeDefIndex: 9810
{
	// Fields
	protected IntPtr m_Recognizer; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x23599D0 Offset: 0x2357FD0 VA: 0x1823599D0
	private void InvokePhraseRecognizedEvent(IntPtr rawText, int rawTextLength, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks) { }

	[RequiredByNativeCode]
	// RVA: 0x2359B50 Offset: 0x2358150 VA: 0x182359B50
	private static SemanticMeaning[] MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount) { }
}

// Namespace: UnityEngine.Windows.Speech
public sealed class DictationRecognizer // TypeDefIndex: 9815
{
	// Fields
	private IntPtr m_Recognizer; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DictationRecognizer.DictationHypothesisDelegate DictationHypothesis; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DictationRecognizer.DictationResultDelegate DictationResult; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private DictationRecognizer.DictationCompletedDelegate DictationComplete; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private DictationRecognizer.DictationErrorHandler DictationError; // 0x30

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2352DD0 Offset: 0x23513D0 VA: 0x182352DD0
	private void DictationRecognizer_InvokeHypothesisGeneratedEvent(IntPtr keyword, int keywordLength) { }

	[RequiredByNativeCode]
	// RVA: 0x2352E30 Offset: 0x2351430 VA: 0x182352E30
	private void DictationRecognizer_InvokeResultGeneratedEvent(IntPtr keyword, int keywordLength, ConfidenceLevel minimumConfidence) { }

	[RequiredByNativeCode]
	// RVA: 0x2352D90 Offset: 0x2351390 VA: 0x182352D90
	private void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause) { }

	[RequiredByNativeCode]
	// RVA: 0x2352DB0 Offset: 0x23513B0 VA: 0x182352DB0
	private void DictationRecognizer_InvokeErrorEvent(string error, int hresult) { }
}

// Namespace: UnityEngine.Windows.Speech
public enum ConfidenceLevel // TypeDefIndex: 9816
{
	// Fields
	public int value__; // 0x0
	public const ConfidenceLevel High = 0;
	public const ConfidenceLevel Medium = 1;
	public const ConfidenceLevel Low = 2;
	public const ConfidenceLevel Rejected = 3;
}

// Namespace: UnityEngine.Windows.Speech
public enum SpeechSystemStatus // TypeDefIndex: 9817
{
	// Fields
	public int value__; // 0x0
	public const SpeechSystemStatus Stopped = 0;
	public const SpeechSystemStatus Running = 1;
	public const SpeechSystemStatus Failed = 2;
}

// Namespace: UnityEngine.Windows.Speech
public enum SpeechError // TypeDefIndex: 9818
{
	// Fields
	public int value__; // 0x0
	public const SpeechError NoError = 0;
	public const SpeechError TopicLanguageNotSupported = 1;
	public const SpeechError GrammarLanguageMismatch = 2;
	public const SpeechError GrammarCompilationFailure = 3;
	public const SpeechError AudioQualityFailure = 4;
	public const SpeechError PauseLimitExceeded = 5;
	public const SpeechError TimeoutExceeded = 6;
	public const SpeechError NetworkFailure = 7;
	public const SpeechError MicrophoneUnavailable = 8;
	public const SpeechError UnknownError = 9;
}

// Namespace: UnityEngine.Windows.Speech
public enum DictationCompletionCause // TypeDefIndex: 9819
{
	// Fields
	public int value__; // 0x0
	public const DictationCompletionCause Complete = 0;
	public const DictationCompletionCause AudioQualityFailure = 1;
	public const DictationCompletionCause Canceled = 2;
	public const DictationCompletionCause TimeoutExceeded = 3;
	public const DictationCompletionCause PauseLimitExceeded = 4;
	public const DictationCompletionCause NetworkFailure = 5;
	public const DictationCompletionCause MicrophoneUnavailable = 6;
	public const DictationCompletionCause UnknownError = 7;
}

// Namespace: UnityEngine.Windows.Speech
public struct SemanticMeaning // TypeDefIndex: 9820
{
	// Fields
	public string key; // 0x0
	public string[] values; // 0x8
}

// Namespace: UnityEngine.Windows.Speech
public struct PhraseRecognizedEventArgs // TypeDefIndex: 9821
{
	// Fields
	public readonly ConfidenceLevel confidence; // 0x0
	public readonly SemanticMeaning[] semanticMeanings; // 0x8
	public readonly string text; // 0x10
	public readonly DateTime phraseStartTime; // 0x18
	public readonly TimeSpan phraseDuration; // 0x20

	// Methods

	// RVA: 0x2359970 Offset: 0x2357F70 VA: 0x182359970
	internal void .ctor(string text, ConfidenceLevel confidence, SemanticMeaning[] semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration) { }
}

