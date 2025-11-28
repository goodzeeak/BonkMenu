// Namespace: Mono.Security.Interface
public enum AlertLevel // TypeDefIndex: 12856
{
	// Fields
	public byte value__; // 0x0
	public const AlertLevel Warning = 1;
	public const AlertLevel Fatal = 2;
}

// Namespace: Mono.Security.Interface
public enum AlertDescription // TypeDefIndex: 12857
{
	// Fields
	public byte value__; // 0x0
	public const AlertDescription CloseNotify = 0;
	public const AlertDescription UnexpectedMessage = 10;
	public const AlertDescription BadRecordMAC = 20;
	public const AlertDescription DecryptionFailed_RESERVED = 21;
	public const AlertDescription RecordOverflow = 22;
	public const AlertDescription DecompressionFailure = 30;
	public const AlertDescription HandshakeFailure = 40;
	public const AlertDescription NoCertificate_RESERVED = 41;
	public const AlertDescription BadCertificate = 42;
	public const AlertDescription UnsupportedCertificate = 43;
	public const AlertDescription CertificateRevoked = 44;
	public const AlertDescription CertificateExpired = 45;
	public const AlertDescription CertificateUnknown = 46;
	public const AlertDescription IlegalParameter = 47;
	public const AlertDescription UnknownCA = 48;
	public const AlertDescription AccessDenied = 49;
	public const AlertDescription DecodeError = 50;
	public const AlertDescription DecryptError = 51;
	public const AlertDescription ExportRestriction = 60;
	public const AlertDescription ProtocolVersion = 70;
	public const AlertDescription InsuficientSecurity = 71;
	public const AlertDescription InternalError = 80;
	public const AlertDescription UserCancelled = 90;
	public const AlertDescription NoRenegotiation = 100;
	public const AlertDescription UnsupportedExtension = 110;
}

// Namespace: Mono.Security.Interface
public class Alert // TypeDefIndex: 12858
{
	// Fields
	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	// Properties
	public AlertLevel Level { get; }
	public AlertDescription Description { get; }

	// Methods

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public AlertLevel get_Level() { }

	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public AlertDescription get_Description() { }

	// RVA: 0x1321CB0 Offset: 0x13202B0 VA: 0x181321CB0
	public void .ctor(AlertDescription description) { }

	// RVA: 0x1321D50 Offset: 0x1320350 VA: 0x181321D50
	private void inferAlertLevel() { }

	// RVA: 0x1321C10 Offset: 0x1320210 VA: 0x181321C10 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.Interface
public class ValidationResult // TypeDefIndex: 12859
{
	// Fields
	private bool trusted; // 0x10
	private bool user_denied; // 0x11
	private int error_code; // 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; // 0x18

	// Properties
	public bool Trusted { get; }
	public bool UserDenied { get; }

	// Methods

	// RVA: 0x1335AB0 Offset: 0x13340B0 VA: 0x181335AB0
	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00
	public bool get_Trusted() { }

	// RVA: 0x426F90 Offset: 0x425590 VA: 0x180426F90
	public bool get_UserDenied() { }
}

// Namespace: Mono.Security.Interface
public interface ICertificateValidator // TypeDefIndex: 12860
{}

// Namespace: Mono.Security.Interface
[CLSCompliant(False)]
public enum CipherSuiteCode // TypeDefIndex: 12861
{
	// Fields
	public ushort value__; // 0x0
	public const CipherSuiteCode TLS_NULL_WITH_NULL_NULL = 0;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_MD5 = 1;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_SHA = 2;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3;
	public const CipherSuiteCode TLS_RSA_WITH_RC4_128_MD5 = 4;
	public const CipherSuiteCode TLS_RSA_WITH_RC4_128_SHA = 5;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6;
	public const CipherSuiteCode TLS_RSA_WITH_IDEA_CBC_SHA = 7;
	public const CipherSuiteCode TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8;
	public const CipherSuiteCode TLS_RSA_WITH_DES_CBC_SHA = 9;
	public const CipherSuiteCode TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10;
	public const CipherSuiteCode TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11;
	public const CipherSuiteCode TLS_DH_DSS_WITH_DES_CBC_SHA = 12;
	public const CipherSuiteCode TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13;
	public const CipherSuiteCode TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14;
	public const CipherSuiteCode TLS_DH_RSA_WITH_DES_CBC_SHA = 15;
	public const CipherSuiteCode TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16;
	public const CipherSuiteCode TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_DES_CBC_SHA = 18;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19;
	public const CipherSuiteCode TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_DES_CBC_SHA = 21;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22;
	public const CipherSuiteCode TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23;
	public const CipherSuiteCode TLS_DH_anon_WITH_RC4_128_MD5 = 24;
	public const CipherSuiteCode TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25;
	public const CipherSuiteCode TLS_DH_anon_WITH_DES_CBC_SHA = 26;
	public const CipherSuiteCode TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA = 47;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA = 52;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA = 53;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA = 58;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197;
	public const CipherSuiteCode TLS_RSA_WITH_SEED_CBC_SHA = 150;
	public const CipherSuiteCode TLS_DH_DSS_WITH_SEED_CBC_SHA = 151;
	public const CipherSuiteCode TLS_DH_RSA_WITH_SEED_CBC_SHA = 152;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154;
	public const CipherSuiteCode TLS_DH_anon_WITH_SEED_CBC_SHA = 155;
	public const CipherSuiteCode TLS_PSK_WITH_RC4_128_SHA = 138;
	public const CipherSuiteCode TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA = 140;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA = 141;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_RC4_128_SHA = 142;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_RC4_128_SHA = 146;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_NULL_SHA = 49163;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_NULL_SHA = 49168;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_NULL_SHA = 49173;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_RC4_128_SHA = 49174;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176;
	public const CipherSuiteCode TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA = 44;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA = 45;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA = 46;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183;
	public const CipherSuiteCode TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184;
	public const CipherSuiteCode TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185;
	public const CipherSuiteCode TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186;
	public const CipherSuiteCode TLS_RSA_WITH_NULL_SHA256 = 59;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CBC_SHA256 = 60;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CBC_SHA256 = 61;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_GCM_SHA256 = 156;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_GCM_SHA384 = 157;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160;
	public const CipherSuiteCode TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164;
	public const CipherSuiteCode TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166;
	public const CipherSuiteCode TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_GCM_SHA256 = 168;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_GCM_SHA384 = 169;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CBC_SHA256 = 174;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CBC_SHA384 = 175;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA256 = 176;
	public const CipherSuiteCode TLS_PSK_WITH_NULL_SHA384 = 177;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA256 = 180;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_NULL_SHA384 = 181;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA256 = 184;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_NULL_SHA384 = 185;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA = 49209;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211;
	public const CipherSuiteCode TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274;
	public const CipherSuiteCode TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278;
	public const CipherSuiteCode TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280;
	public const CipherSuiteCode TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282;
	public const CipherSuiteCode TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284;
	public const CipherSuiteCode TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288;
	public const CipherSuiteCode TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292;
	public const CipherSuiteCode TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300;
	public const CipherSuiteCode TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CCM = 49308;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CCM = 49309;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM = 49310;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM = 49311;
	public const CipherSuiteCode TLS_RSA_WITH_AES_128_CCM_8 = 49312;
	public const CipherSuiteCode TLS_RSA_WITH_AES_256_CCM_8 = 49313;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CCM = 49316;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CCM = 49317;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_128_CCM = 49318;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_AES_256_CCM = 49319;
	public const CipherSuiteCode TLS_PSK_WITH_AES_128_CCM_8 = 49320;
	public const CipherSuiteCode TLS_PSK_WITH_AES_256_CCM_8 = 49321;
	public const CipherSuiteCode TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322;
	public const CipherSuiteCode TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245;
	public const CipherSuiteCode TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384;
	public const CipherSuiteCode TLS_RSA_WITH_SALSA20_SHA1 = 58385;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386;
	public const CipherSuiteCode TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388;
	public const CipherSuiteCode TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389;
	public const CipherSuiteCode TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390;
	public const CipherSuiteCode TLS_PSK_WITH_SALSA20_SHA1 = 58391;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392;
	public const CipherSuiteCode TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394;
	public const CipherSuiteCode TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396;
	public const CipherSuiteCode TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398;
	public const CipherSuiteCode TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399;
	public const CipherSuiteCode TLS_FALLBACK_SCSV = 22016;
}

// Namespace: Mono.Security.Interface
public class MonoTlsConnectionInfo // TypeDefIndex: 12862
{
	// Fields
	[CompilerGenerated]
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; // 0x10
	[CompilerGenerated]
	private TlsProtocols <ProtocolVersion>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <PeerDomainName>k__BackingField; // 0x18

	// Properties
	[CLSCompliant(False)]
	public CipherSuiteCode CipherSuiteCode { get; set; }
	public TlsProtocols ProtocolVersion { get; set; }
	public string PeerDomainName { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xB99A10 Offset: 0xB98010 VA: 0x180B99A10
	public CipherSuiteCode get_CipherSuiteCode() { }

	[CompilerGenerated]
	// RVA: 0x132DF00 Offset: 0x132C500 VA: 0x18132DF00
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public TlsProtocols get_ProtocolVersion() { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	public void set_ProtocolVersion(TlsProtocols value) { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_PeerDomainName(string value) { }

	// RVA: 0x132DE60 Offset: 0x132C460 VA: 0x18132DE60 Slot: 3
	public override string ToString() { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: Mono.Security.Interface
[Flags]
public enum MonoSslPolicyErrors // TypeDefIndex: 12863
{
	// Fields
	public int value__; // 0x0
	public const MonoSslPolicyErrors None = 0;
	public const MonoSslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const MonoSslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const MonoSslPolicyErrors RemoteCertificateChainErrors = 4;
}

// Namespace: Mono.Security.Interface
public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 12864
{
	// Methods

	// RVA: 0x132DDA0 Offset: 0x132C3A0 VA: 0x18132DDA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x39D730 Offset: 0x39BD30 VA: 0x18039D730 Slot: 13
	public virtual bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }
}

// Namespace: Mono.Security.Interface
public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 12865
{
	// Methods

	// RVA: 0x132DCE0 Offset: 0x132C2E0 VA: 0x18132DCE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x39D730 Offset: 0x39BD30 VA: 0x18039D730 Slot: 13
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: Mono.Security.Interface
public abstract class MonoTlsProvider // TypeDefIndex: 12866
{
	// Properties
	public abstract Guid ID { get; }
	public abstract string Name { get; }
	public abstract bool SupportsSslStream { get; }
	public abstract bool SupportsConnectionInfo { get; }
	public abstract bool SupportsMonoExtensions { get; }
	public abstract SslProtocols SupportedProtocols { get; }
	internal abstract bool SupportsCleanShutdown { get; }

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Guid get_ID();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_SupportsSslStream();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_SupportsConnectionInfo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_SupportsMonoExtensions();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SslProtocols get_SupportedProtocols();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool get_SupportsCleanShutdown();
}

// Namespace: Mono.Security.Interface
public static class MonoTlsProviderFactory // TypeDefIndex: 12867
{
	// Methods

	// RVA: 0x132DF10 Offset: 0x132C510 VA: 0x18132DF10
	public static MonoTlsProvider GetProvider() { }
}

// Namespace: Mono.Security.Interface
public sealed class MonoTlsSettings // TypeDefIndex: 12868
{
	// Fields
	[CompilerGenerated]
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; // 0x10
	[CompilerGenerated]
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; // 0x18
	[CompilerGenerated]
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private X509CertificateCollection <TrustAnchors>k__BackingField; // 0x30
	[CompilerGenerated]
	private object <UserSettings>k__BackingField; // 0x38
	[CompilerGenerated]
	private string[] <CertificateSearchPaths>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <SendCloseNotify>k__BackingField; // 0x48
	[CompilerGenerated]
	private string[] <ClientCertificateIssuers>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; // 0x58
	[CompilerGenerated]
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; // 0x5C
	[CompilerGenerated]
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; // 0x68
	private bool cloned; // 0x70
	private bool checkCertName; // 0x71
	private bool checkCertRevocationStatus; // 0x72
	private Nullable<bool> useServicePointManagerCallback; // 0x73
	private bool skipSystemValidators; // 0x75
	private bool callbackNeedsChain; // 0x76
	private ICertificateValidator certificateValidator; // 0x78
	private static MonoTlsSettings defaultSettings; // 0x0

	// Properties
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback { get; set; }
	public Nullable<bool> UseServicePointManagerCallback { get; set; }
	public bool CallbackNeedsCertificateChain { get; }
	public Nullable<DateTime> CertificateValidationTime { get; set; }
	public X509CertificateCollection TrustAnchors { get; set; }
	public object UserSettings { get; set; }
	internal string[] CertificateSearchPaths { get; set; }
	internal bool SendCloseNotify { get; set; }
	public string[] ClientCertificateIssuers { get; set; }
	public bool DisallowUnauthenticatedCertificateRequest { get; set; }
	public Nullable<TlsProtocols> EnabledProtocols { get; set; }
	[CLSCompliant(False)]
	public CipherSuiteCode[] EnabledCiphers { get; set; }
	public static MonoTlsSettings DefaultSettings { get; }
	[Obsolete("Do not use outside System.dll!")]
	public ICertificateValidator CertificateValidator { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	// RVA: 0x39A590 Offset: 0x398B90 VA: 0x18039A590
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	// RVA: 0x132E3C0 Offset: 0x132C9C0 VA: 0x18132E3C0
	public Nullable<bool> get_UseServicePointManagerCallback() { }

	// RVA: 0x132E400 Offset: 0x132CA00 VA: 0x18132E400
	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

	// RVA: 0x132E300 Offset: 0x132C900 VA: 0x18132E300
	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGenerated]
	// RVA: 0x95D410 Offset: 0x95BA10 VA: 0x18095D410
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[CompilerGenerated]
	// RVA: 0x132E3D0 Offset: 0x132C9D0 VA: 0x18132E3D0
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGenerated]
	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGenerated]
	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	public object get_UserSettings() { }

	[CompilerGenerated]
	// RVA: 0x12815C0 Offset: 0x127FBC0 VA: 0x1812815C0
	public void set_UserSettings(object value) { }

	[CompilerGenerated]
	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGenerated]
	// RVA: 0x535990 Offset: 0x533F90 VA: 0x180535990
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0
	internal bool get_SendCloseNotify() { }

	[CompilerGenerated]
	// RVA: 0x132E3F0 Offset: 0x132C9F0 VA: 0x18132E3F0
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGenerated]
	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public string[] get_ClientCertificateIssuers() { }

	[CompilerGenerated]
	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	public void set_ClientCertificateIssuers(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x3AFD80 Offset: 0x3AE380 VA: 0x1803AFD80
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	[CompilerGenerated]
	// RVA: 0x3B9A60 Offset: 0x3B8060 VA: 0x1803B9A60
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x132E3A0 Offset: 0x132C9A0 VA: 0x18132E3A0
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[CompilerGenerated]
	// RVA: 0x132E3E0 Offset: 0x132C9E0 VA: 0x18132E3E0
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[CompilerGenerated]
	// RVA: 0x53F950 Offset: 0x53DF50 VA: 0x18053F950
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGenerated]
	// RVA: 0x547730 Offset: 0x545D30 VA: 0x180547730
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	// RVA: 0x132E2F0 Offset: 0x132C8F0 VA: 0x18132E2F0
	public void .ctor() { }

	// RVA: 0x132E310 Offset: 0x132C910 VA: 0x18132E310
	public static MonoTlsSettings get_DefaultSettings() { }

	// RVA: 0x132E080 Offset: 0x132C680 VA: 0x18132E080
	public static MonoTlsSettings CopyDefaultSettings() { }

	// RVA: 0x3E1400 Offset: 0x3DFA00 VA: 0x1803E1400
	public ICertificateValidator get_CertificateValidator() { }

	[Obsolete("Do not use outside System.dll!")]
	// RVA: 0x132DF80 Offset: 0x132C580 VA: 0x18132DF80
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	// RVA: 0x132E020 Offset: 0x132C620 VA: 0x18132E020
	public MonoTlsSettings Clone() { }

	// RVA: 0x132E160 Offset: 0x132C760 VA: 0x18132E160
	private void .ctor(MonoTlsSettings other) { }
}

// Namespace: Mono.Security.Interface
public sealed class TlsException : Exception // TypeDefIndex: 12869
{
	// Fields
	private Alert alert; // 0x90

	// Methods

	// RVA: 0x1334110 Offset: 0x1332710 VA: 0x181334110
	public void .ctor(Alert alert) { }

	// RVA: 0x1333F50 Offset: 0x1332550 VA: 0x181333F50
	public void .ctor(Alert alert, string message) { }

	// RVA: 0x1334050 Offset: 0x1332650 VA: 0x181334050
	public void .ctor(AlertDescription description) { }

	// RVA: 0x1333FD0 Offset: 0x13325D0 VA: 0x181333FD0
	public void .ctor(AlertDescription description, string message) { }
}

// Namespace: Mono.Security.Interface
public enum TlsProtocolCode // TypeDefIndex: 12870
{
	// Fields
	public short value__; // 0x0
	public const TlsProtocolCode Tls10 = 769;
	public const TlsProtocolCode Tls11 = 770;
	public const TlsProtocolCode Tls12 = 771;
}

// Namespace: Mono.Security.Interface
[Flags]
public enum TlsProtocols // TypeDefIndex: 12871
{
	// Fields
	public int value__; // 0x0
	public const TlsProtocols Zero = 0;
	public const TlsProtocols Tls10Client = 128;
	public const TlsProtocols Tls10Server = 64;
	public const TlsProtocols Tls10 = 192;
	public const TlsProtocols Tls11Client = 512;
	public const TlsProtocols Tls11Server = 256;
	public const TlsProtocols Tls11 = 768;
	public const TlsProtocols Tls12Client = 2048;
	public const TlsProtocols Tls12Server = 1024;
	public const TlsProtocols Tls12 = 3072;
	public const TlsProtocols ClientMask = 2688;
	public const TlsProtocols ServerMask = 1344;
}

