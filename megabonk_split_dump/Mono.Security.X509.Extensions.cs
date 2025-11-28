// Namespace: Mono.Security.X509.Extensions
public class AuthorityKeyIdentifierExtension : X509Extension // TypeDefIndex: 12845
{
	// Fields
	private byte[] aki; // 0x28

	// Properties
	public byte[] Identifier { get; }

	// Methods

	// RVA: 0x1309630 Offset: 0x1307C30 VA: 0x181309630
	public void .ctor(X509Extension extension) { }

	// RVA: 0x13091E0 Offset: 0x13077E0 VA: 0x1813091E0 Slot: 4
	protected override void Decode() { }

	// RVA: 0x1309330 Offset: 0x1307930 VA: 0x181309330 Slot: 5
	protected override void Encode() { }

	// RVA: 0x1309640 Offset: 0x1307C40 VA: 0x181309640
	public byte[] get_Identifier() { }

	// RVA: 0x13094A0 Offset: 0x1307AA0 VA: 0x1813094A0 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509.Extensions
public class BasicConstraintsExtension : X509Extension // TypeDefIndex: 12846
{
	// Fields
	private bool cA; // 0x28
	private int pathLenConstraint; // 0x2C

	// Properties
	public bool CertificateAuthority { get; }

	// Methods

	// RVA: 0x1309630 Offset: 0x1307C30 VA: 0x181309630
	public void .ctor(X509Extension extension) { }

	// RVA: 0x13096C0 Offset: 0x1307CC0 VA: 0x1813096C0 Slot: 4
	protected override void Decode() { }

	// RVA: 0x1309800 Offset: 0x1307E00 VA: 0x181309800 Slot: 5
	protected override void Encode() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	public bool get_CertificateAuthority() { }

	// RVA: 0x13099E0 Offset: 0x1307FE0 VA: 0x1813099E0 Slot: 3
	public override string ToString() { }
}

