// Namespace: Mono.Http
internal class NtlmSession // TypeDefIndex: 7326
{
	// Fields
	private MessageBase message; // 0x10

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1A82BF0 Offset: 0x1A811F0 VA: 0x181A82BF0
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }
}

// Namespace: Mono.Http
internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 7328
{
	// Fields
	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x0

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1A82790 Offset: 0x1A80D90 VA: 0x181A82790 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1A82BC0 Offset: 0x1A811C0 VA: 0x181A82BC0 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }

	// RVA: 0x1A82B30 Offset: 0x1A81130 VA: 0x181A82B30
	private static void .cctor() { }
}

