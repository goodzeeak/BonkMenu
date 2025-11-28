// Namespace: System.Security.Authentication
[Serializable]
public class AuthenticationException : SystemException // TypeDefIndex: 7500
{
	// Methods

	// RVA: 0x1DF9280 Offset: 0x1DF7880 VA: 0x181DF9280
	public void .ctor() { }

	// RVA: 0x13CADD0 Offset: 0x13C93D0 VA: 0x1813CADD0
	public void .ctor(string message) { }

	// RVA: 0x13CADC0 Offset: 0x13C93C0 VA: 0x1813CADC0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x13968B0 Offset: 0x1394EB0 VA: 0x1813968B0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Security.Authentication
[Flags]
public enum SslProtocols // TypeDefIndex: 7501
{
	// Fields
	public int value__; // 0x0
	public const SslProtocols None = 0;
	public const SslProtocols Ssl2 = 12;
	public const SslProtocols Ssl3 = 48;
	public const SslProtocols Tls = 192;
	[MonoTODO("unsupported")]
	public const SslProtocols Tls11 = 768;
	[MonoTODO("unsupported")]
	public const SslProtocols Tls12 = 3072;
	public const SslProtocols Tls13 = 12288;
	public const SslProtocols Default = 240;
}

