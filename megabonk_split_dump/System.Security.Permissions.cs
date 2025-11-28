// Namespace: System.Security.Permissions
public enum PermissionState // TypeDefIndex: 726
{
	// Fields
	public int value__; // 0x0
	public const PermissionState None = 0;
	public const PermissionState Unrestricted = 1;
}

// Namespace: System.Security.Permissions
[Obsolete("CAS support is not available with Silverlight applications.")]
[ComVisible(True)]
[Serializable]
public enum SecurityAction // TypeDefIndex: 727
{
	// Fields
	public int value__; // 0x0
	public const SecurityAction Demand = 2;
	public const SecurityAction Assert = 3;
	[Obsolete("This requests should not be used")]
	public const SecurityAction Deny = 4;
	public const SecurityAction PermitOnly = 5;
	public const SecurityAction LinkDemand = 6;
	public const SecurityAction InheritanceDemand = 7;
	[Obsolete("This requests should not be used")]
	public const SecurityAction RequestMinimum = 8;
	[Obsolete("This requests should not be used")]
	public const SecurityAction RequestOptional = 9;
	[Obsolete("This requests should not be used")]
	public const SecurityAction RequestRefuse = 10;
}

