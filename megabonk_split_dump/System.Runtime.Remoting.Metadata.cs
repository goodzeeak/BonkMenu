// Namespace: System.Runtime.Remoting.Metadata
[ComVisible(True)]
public class SoapAttribute : Attribute // TypeDefIndex: 911
{
	// Fields
	private bool _useAttribute; // 0x10
	protected string ProtXmlNamespace; // 0x18
	protected object ReflectInfo; // 0x20

	// Properties
	public virtual bool UseAttribute { get; }
	public virtual string XmlNamespace { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x37AD00 Offset: 0x379300 VA: 0x18037AD00 Slot: 7
	public virtual bool get_UseAttribute() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 8
	public virtual string get_XmlNamespace() { }

	// RVA: 0x366B10 Offset: 0x365110 VA: 0x180366B10 Slot: 9
	internal virtual void SetReflectionObject(object reflectionObject) { }
}

// Namespace: System.Runtime.Remoting.Metadata
[ComVisible(True)]
[Usage(256)]
public sealed class SoapFieldAttribute : SoapAttribute // TypeDefIndex: 912
{
	// Fields
	private string _elementName; // 0x28
	private bool _isElement; // 0x30

	// Properties
	public string XmlElementName { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public string get_XmlElementName() { }

	// RVA: 0x1005190 Offset: 0x1003790 VA: 0x181005190
	public bool IsInteropXmlElement() { }

	// RVA: 0x13F5FC0 Offset: 0x13F45C0 VA: 0x1813F5FC0 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(64)]
[ComVisible(True)]
public sealed class SoapMethodAttribute : SoapAttribute // TypeDefIndex: 913
{
	// Fields
	private string _responseElement; // 0x28
	private string _responseNamespace; // 0x30
	private string _returnElement; // 0x38
	private string _soapAction; // 0x40
	private bool _useAttribute; // 0x48
	private string _namespace; // 0x50

	// Properties
	public override bool UseAttribute { get; }
	public override string XmlNamespace { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x132E3B0 Offset: 0x132C9B0 VA: 0x18132E3B0 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x399800 Offset: 0x397E00 VA: 0x180399800 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x13F6070 Offset: 0x13F4670 VA: 0x1813F6070 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(2048)]
[ComVisible(True)]
public sealed class SoapParameterAttribute : SoapAttribute // TypeDefIndex: 914
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(1052)]
[ComVisible(True)]
public sealed class SoapTypeAttribute : SoapAttribute // TypeDefIndex: 915
{
	// Fields
	private bool _useAttribute; // 0x28
	private string _xmlElementName; // 0x30
	private string _xmlNamespace; // 0x38
	private string _xmlTypeName; // 0x40
	private string _xmlTypeNamespace; // 0x48
	private bool _isType; // 0x50
	private bool _isElement; // 0x51

	// Properties
	public override bool UseAttribute { get; }
	public string XmlElementName { get; }
	public override string XmlNamespace { get; }
	public string XmlTypeName { get; }
	public string XmlTypeNamespace { get; }
	internal bool IsInteropXmlElement { get; }
	internal bool IsInteropXmlType { get; }

	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }

	// RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public string get_XmlElementName() { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x535980 Offset: 0x533F80 VA: 0x180535980
	public string get_XmlTypeName() { }

	// RVA: 0x352DD0 Offset: 0x3513D0 VA: 0x180352DD0
	public string get_XmlTypeNamespace() { }

	// RVA: 0x13F64B0 Offset: 0x13F4AB0 VA: 0x1813F64B0
	internal bool get_IsInteropXmlElement() { }

	// RVA: 0x95D0B0 Offset: 0x95B6B0 VA: 0x18095D0B0
	internal bool get_IsInteropXmlType() { }

	// RVA: 0x13F6270 Offset: 0x13F4870 VA: 0x1813F6270 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}

