// Namespace: Mono.Security.Protocol.Ntlm
[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
public class ChallengeResponse : IDisposable // TypeDefIndex: 12847
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x130BE50 Offset: 0x130A450 VA: 0x18130BE50
	public void .ctor() { }

	// RVA: 0x130BC80 Offset: 0x130A280 VA: 0x18130BC80
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x130B500 Offset: 0x1309B00 VA: 0x18130B500 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x130C100 Offset: 0x130A700 VA: 0x18130C100
	public void set_Password(string value) { }

	// RVA: 0x130BFB0 Offset: 0x130A5B0 VA: 0x18130BFB0
	public void set_Challenge(byte[] value) { }

	// RVA: 0x130BED0 Offset: 0x130A4D0 VA: 0x18130BED0
	public byte[] get_LM() { }

	// RVA: 0x130BF40 Offset: 0x130A540 VA: 0x18130BF40
	public byte[] get_NT() { }

	// RVA: 0x130B3E0 Offset: 0x13099E0 VA: 0x18130B3E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x130B490 Offset: 0x1309A90 VA: 0x18130B490
	private void Dispose(bool disposing) { }

	// RVA: 0x130B610 Offset: 0x1309C10 VA: 0x18130B610
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x130B9A0 Offset: 0x1309FA0 VA: 0x18130B9A0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x130B850 Offset: 0x1309E50 VA: 0x18130B850
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x130BB90 Offset: 0x130A190 VA: 0x18130BB90
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public static class ChallengeResponse2 // TypeDefIndex: 12848
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x1309F60 Offset: 0x1308560 VA: 0x181309F60
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x130A240 Offset: 0x1308840 VA: 0x18130A240
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x130A350 Offset: 0x1308950 VA: 0x18130A350
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x130A3C0 Offset: 0x13089C0 VA: 0x18130A3C0
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x130A5F0 Offset: 0x1308BF0 VA: 0x18130A5F0
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x130AB30 Offset: 0x1309130 VA: 0x18130AB30
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x130AD40 Offset: 0x1309340 VA: 0x18130AD40
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x130B100 Offset: 0x1309700 VA: 0x18130B100
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x130AF90 Offset: 0x1309590 VA: 0x18130AF90
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x130B2F0 Offset: 0x13098F0 VA: 0x18130B2F0
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public abstract class MessageBase // TypeDefIndex: 12849
{
	// Fields
	private static byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Properties
	public NtlmFlags Flags { get; set; }
	public int Type { get; }

	// Methods

	// RVA: 0x3757E0 Offset: 0x373DE0 VA: 0x1803757E0
	protected void .ctor(int messageType) { }

	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public NtlmFlags get_Flags() { }

	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_Type() { }

	// RVA: 0x132CDB0 Offset: 0x132B3B0 VA: 0x18132CDB0
	protected byte[] PrepareMessage(int messageSize) { }

	// RVA: 0x132CB40 Offset: 0x132B140 VA: 0x18132CB40 Slot: 4
	protected virtual void Decode(byte[] message) { }

	// RVA: 0x132CA40 Offset: 0x132B040 VA: 0x18132CA40
	protected bool CheckHeader(byte[] message) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetBytes();

	// RVA: 0x132CEA0 Offset: 0x132B4A0 VA: 0x18132CEA0
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public enum NtlmAuthLevel // TypeDefIndex: 12850
{
	// Fields
	public int value__; // 0x0
	public const NtlmAuthLevel LM_and_NTLM = 0;
	public const NtlmAuthLevel LM_and_NTLM_and_try_NTLMv2_Session = 1;
	public const NtlmAuthLevel NTLM_only = 2;
	public const NtlmAuthLevel NTLMv2_only = 3;
}

// Namespace: Mono.Security.Protocol.Ntlm
[Flags]
public enum NtlmFlags // TypeDefIndex: 12851
{
	// Fields
	public int value__; // 0x0
	public const NtlmFlags NegotiateUnicode = 1;
	public const NtlmFlags NegotiateOem = 2;
	public const NtlmFlags RequestTarget = 4;
	public const NtlmFlags NegotiateNtlm = 512;
	public const NtlmFlags NegotiateDomainSupplied = 4096;
	public const NtlmFlags NegotiateWorkstationSupplied = 8192;
	public const NtlmFlags NegotiateAlwaysSign = 32768;
	public const NtlmFlags NegotiateNtlm2Key = 524288;
	public const NtlmFlags Negotiate128 = 536870912;
	public const NtlmFlags Negotiate56 = -2147483648;
}

// Namespace: Mono.Security.Protocol.Ntlm
public static class NtlmSettings // TypeDefIndex: 12852
{
	// Fields
	private static NtlmAuthLevel defaultAuthLevel; // 0x0

	// Properties
	public static NtlmAuthLevel DefaultAuthLevel { get; }

	// Methods

	// RVA: 0x132E450 Offset: 0x132CA50 VA: 0x18132E450
	public static NtlmAuthLevel get_DefaultAuthLevel() { }

	// RVA: 0x132E410 Offset: 0x132CA10 VA: 0x18132E410
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type1Message : MessageBase // TypeDefIndex: 12853
{
	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x1334570 Offset: 0x1332B70 VA: 0x181334570
	public void .ctor() { }

	// RVA: 0x1334600 Offset: 0x1332C00 VA: 0x181334600
	public void set_Domain(string value) { }

	// RVA: 0x1334680 Offset: 0x1332C80 VA: 0x181334680
	public void set_Host(string value) { }

	// RVA: 0x1334190 Offset: 0x1332790 VA: 0x181334190 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x13342A0 Offset: 0x13328A0 VA: 0x1813342A0 Slot: 5
	public override byte[] GetBytes() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type2Message : MessageBase // TypeDefIndex: 12854
{
	// Fields
	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	// Properties
	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }

	// Methods

	// RVA: 0x13349D0 Offset: 0x1332FD0 VA: 0x1813349D0
	public void .ctor(byte[] message) { }

	// RVA: 0x1334890 Offset: 0x1332E90 VA: 0x181334890 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1334A70 Offset: 0x1333070 VA: 0x181334A70
	public byte[] get_Nonce() { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_TargetName() { }

	// RVA: 0x1334AF0 Offset: 0x13330F0 VA: 0x181334AF0
	public byte[] get_TargetInfo() { }

	// RVA: 0x1334700 Offset: 0x1332D00 VA: 0x181334700 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1334900 Offset: 0x1332F00 VA: 0x181334900 Slot: 5
	public override byte[] GetBytes() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type3Message : MessageBase // TypeDefIndex: 12855
{
	// Fields
	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	// Properties
	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }

	// Methods

	// RVA: 0x13357A0 Offset: 0x1333DA0 VA: 0x1813357A0
	public void .ctor(Type2Message type2) { }

	// RVA: 0x1334F30 Offset: 0x1333530 VA: 0x181334F30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1335A30 Offset: 0x1334030 VA: 0x181335A30
	public void set_Domain(string value) { }

	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	public void set_Password(string value) { }

	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_Username(string value) { }

	// RVA: 0x1334BE0 Offset: 0x13331E0 VA: 0x181334BE0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1334B70 Offset: 0x1333170 VA: 0x181334B70
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1334EA0 Offset: 0x13334A0 VA: 0x181334EA0
	private byte[] EncodeString(string text) { }

	// RVA: 0x1334FE0 Offset: 0x13335E0 VA: 0x181334FE0 Slot: 5
	public override byte[] GetBytes() { }
}

