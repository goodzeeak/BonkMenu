// Namespace: System.Security.Claims
[Serializable]
public class Claim // TypeDefIndex: 820
{
	// Fields
	private string m_issuer; // 0x10
	private string m_originalIssuer; // 0x18
	private string m_type; // 0x20
	private string m_value; // 0x28
	private string m_valueType; // 0x30
	private byte[] m_userSerializationData; // 0x38
	private Dictionary<string, string> m_properties; // 0x40
	private object m_propertyLock; // 0x48
	private ClaimsIdentity m_subject; // 0x50

	// Properties
	public IDictionary<string, string> Properties { get; }
	public ClaimsIdentity Subject { get; set; }
	public string Type { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x13B9180 Offset: 0x13B7780 VA: 0x1813B9180
	public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	// RVA: 0x13B9540 Offset: 0x13B7B40 VA: 0x1813B9540
	internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	// RVA: 0x13B91D0 Offset: 0x13B77D0 VA: 0x1813B91D0
	protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserialized]
	// RVA: 0x13B90A0 Offset: 0x13B76A0 VA: 0x1813B90A0
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x13B9800 Offset: 0x13B7E00 VA: 0x1813B9800
	public IDictionary<string, string> get_Properties() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800
	public ClaimsIdentity get_Subject() { }

	// RVA: 0x399830 Offset: 0x397E30 VA: 0x180399830
	internal void set_Subject(ClaimsIdentity value) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Type() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_Value() { }

	// RVA: 0x13B9030 Offset: 0x13B7630 VA: 0x1813B9030 Slot: 4
	public virtual Claim Clone(ClaimsIdentity identity) { }

	// RVA: 0x13B9100 Offset: 0x13B7700 VA: 0x1813B9100 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Security.Claims
[ComVisible(True)]
[Serializable]
public class ClaimsIdentity : IIdentity // TypeDefIndex: 822
{
	// Fields
	private byte[] m_userSerializationData; // 0x10
	private List<Claim> m_instanceClaims; // 0x18
	private Collection<IEnumerable<Claim>> m_externalClaims; // 0x20
	private string m_nameType; // 0x28
	private string m_roleType; // 0x30
	[OptionalField(VersionAdded = 2)]
	private string m_version; // 0x38
	[OptionalField(VersionAdded = 2)]
	private ClaimsIdentity m_actor; // 0x40
	[OptionalField(VersionAdded = 2)]
	private string m_authenticationType; // 0x48
	[OptionalField(VersionAdded = 2)]
	private object m_bootstrapContext; // 0x50
	[OptionalField(VersionAdded = 2)]
	private string m_label; // 0x58
	[OptionalField(VersionAdded = 2)]
	private string m_serializedNameType; // 0x60
	[OptionalField(VersionAdded = 2)]
	private string m_serializedRoleType; // 0x68
	[OptionalField(VersionAdded = 2)]
	private string m_serializedClaims; // 0x70

	// Properties
	public virtual string AuthenticationType { get; }
	public ClaimsIdentity Actor { get; set; }
	public virtual IEnumerable<Claim> Claims { get; }
	public virtual string Name { get; }

	// Methods

	// RVA: 0x13BB210 Offset: 0x13B9810 VA: 0x1813BB210
	public void .ctor() { }

	// RVA: 0x13BB1E0 Offset: 0x13B97E0 VA: 0x1813BB1E0
	public void .ctor(IEnumerable<Claim> claims) { }

	// RVA: 0x13BBA70 Offset: 0x13BA070 VA: 0x1813BBA70
	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	// RVA: 0x13BB400 Offset: 0x13B9A00 VA: 0x1813BB400
	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	// RVA: 0x13BB240 Offset: 0x13B9840 VA: 0x1813BB240
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0 Slot: 6
	public virtual string get_AuthenticationType() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public ClaimsIdentity get_Actor() { }

	// RVA: 0x13BBB50 Offset: 0x13BA150 VA: 0x1813BBB50
	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachine(typeof(ClaimsIdentity.<get_Claims>d__51))]
	// RVA: 0x13BBAA0 Offset: 0x13BA0A0 VA: 0x1813BBAA0 Slot: 7
	public virtual IEnumerable<Claim> get_Claims() { }

	// RVA: 0x13BBB20 Offset: 0x13BA120 VA: 0x1813BBB20 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x13B9910 Offset: 0x13B7F10 VA: 0x1813B9910 Slot: 9
	public virtual ClaimsIdentity Clone() { }

	// RVA: 0x13BAE00 Offset: 0x13B9400 VA: 0x1813BAE00
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	// RVA: 0x13BAD60 Offset: 0x13B9360 VA: 0x1813BAD60
	private void SafeAddClaim(Claim claim) { }

	// RVA: 0x13BA450 Offset: 0x13B8A50 VA: 0x1813BA450 Slot: 10
	public virtual Claim FindFirst(string type) { }

	[OnSerializing]
	// RVA: 0x13BACE0 Offset: 0x13B92E0 VA: 0x1813BACE0
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x13BAB20 Offset: 0x13B9120 VA: 0x1813BAB20
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializing]
	// RVA: 0x13BAC00 Offset: 0x13B9200 VA: 0x1813BAC00
	private void OnDeserializingMethod(StreamingContext context) { }

	// RVA: 0x13BA640 Offset: 0x13B8C40 VA: 0x1813BA640 Slot: 11
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x13B9AE0 Offset: 0x13B80E0 VA: 0x1813B9AE0
	private void DeserializeClaims(string serializedClaims) { }

	// RVA: 0x13BB030 Offset: 0x13B9630 VA: 0x1813BB030
	private string SerializeClaims() { }

	// RVA: 0x13BAAD0 Offset: 0x13B90D0 VA: 0x1813BAAD0
	private bool IsCircular(ClaimsIdentity subject) { }

	// RVA: 0x13B9DA0 Offset: 0x13B83A0 VA: 0x1813B9DA0
	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }
}

