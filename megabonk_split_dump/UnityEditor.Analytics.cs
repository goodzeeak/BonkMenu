// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class AssetDatabaseRefreshAnalytic : AnalyticsEventBase // TypeDefIndex: 14125
{
	// Fields
	[SerializeField]
	public bool isV2; // 0x30
	[SerializeField]
	public long Imports_Imported; // 0x38
	[SerializeField]
	public long Imports_ImportedInProcess; // 0x40
	[SerializeField]
	public long Imports_ImportedOutOfProcess; // 0x48
	[SerializeField]
	public long Imports_Refresh; // 0x50
	[SerializeField]
	public long Imports_DomainReload; // 0x58
	[SerializeField]
	public long CacheServer_MetadataRequested; // 0x60
	[SerializeField]
	public long CacheServer_MetadataDownloaded; // 0x68
	[SerializeField]
	public long CacheServer_MetadataFailedToDownload; // 0x70
	[SerializeField]
	public long CacheServer_MetadataUploaded; // 0x78
	[SerializeField]
	public long CacheServer_ArtifactsFailedToUpload; // 0x80
	[SerializeField]
	public long CacheServer_MetadataVersionsDownloaded; // 0x88
	[SerializeField]
	public long CacheServer_MetadataMatched; // 0x90
	[SerializeField]
	public long CacheServer_ArtifactsDownloaded; // 0x98
	[SerializeField]
	public long CacheServer_ArtifactFilesDownloaded; // 0xA0
	[SerializeField]
	public long CacheServer_ArtifactFilesFailedToDownload; // 0xA8
	[SerializeField]
	public long CacheServer_ArtifactsUploaded; // 0xB0
	[SerializeField]
	public long CacheServer_ArtifactFilesUploaded; // 0xB8
	[SerializeField]
	public long CacheServer_ArtifactFilesFailedToUpload; // 0xC0
	[SerializeField]
	public long CacheServer_Connects; // 0xC8
	[SerializeField]
	public long CacheServer_Disconnects; // 0xD0

	// Methods

	// RVA: 0x267F6E0 Offset: 0x267DCE0 VA: 0x18267F6E0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x267F650 Offset: 0x267DC50 VA: 0x18267F650
	internal static AssetDatabaseRefreshAnalytic CreateAssetDatabaseRefreshAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class BuildAssetBundleAnalytic : AnalyticsEventBase // TypeDefIndex: 14126
{
	// Fields
	public bool success; // 0x30
	public string error; // 0x38

	// Methods

	// RVA: 0x267F9E0 Offset: 0x267DFE0 VA: 0x18267F9E0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x267F950 Offset: 0x267DF50 VA: 0x18267F950
	internal static BuildAssetBundleAnalytic CreateBuildAssetBundleAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class CollabOperationAnalytic : AnalyticsEventBase // TypeDefIndex: 14127
{
	// Fields
	public string category; // 0x30
	public string operation; // 0x38
	public string result; // 0x40
	public long start_ts; // 0x48
	public long duration; // 0x50

	// Methods

	// RVA: 0x267FAE0 Offset: 0x267E0E0 VA: 0x18267FAE0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x267FA50 Offset: 0x267E050 VA: 0x18267FA50
	internal static CollabOperationAnalytic CreateCollabOperationAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class LicensingErrorAnalytic : AnalyticsEventBase // TypeDefIndex: 14128
{
	// Fields
	public string licensingErrorType; // 0x30
	public string additionalData; // 0x38
	public string errorMessage; // 0x40
	public string correlationId; // 0x48
	public string sessionId; // 0x50

	// Methods

	// RVA: 0x267FBE0 Offset: 0x267E1E0 VA: 0x18267FBE0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x267FB50 Offset: 0x267E150 VA: 0x18267FB50
	internal static LicensingErrorAnalytic CreateLicensingErrorAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class LicensingInitAnalytic : AnalyticsEventBase // TypeDefIndex: 14129
{
	// Fields
	public string licensingProtocolVersion; // 0x30
	public string licensingClientVersion; // 0x38
	public string channelType; // 0x40
	public double initTime; // 0x48
	public bool isLegacy; // 0x50
	public string sessionId; // 0x58
	public string correlationId; // 0x60

	// Methods

	// RVA: 0x267FCE0 Offset: 0x267E2E0 VA: 0x18267FCE0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x267FC50 Offset: 0x267E250 VA: 0x18267FC50
	internal static LicensingInitAnalytic CreateLicensingInitAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class MetalPatchShaderComputeBufferAnalytic : AnalyticsEventBase // TypeDefIndex: 14130
{
	// Methods

	// RVA: 0x267FDE0 Offset: 0x267E3E0 VA: 0x18267FDE0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x267FD50 Offset: 0x267E350 VA: 0x18267FD50
	internal static MetalPatchShaderComputeBufferAnalytic CreateMetalPatchShaderComputeBufferAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class NavmeshBakingAnalytic : AnalyticsEventBase // TypeDefIndex: 14131
{
	// Fields
	private bool new_nav_api; // 0x30
	private bool bake_at_runtime; // 0x31
	private int height_meshes_count; // 0x34
	private int offmesh_links_count; // 0x38

	// Methods

	// RVA: 0x267FEE0 Offset: 0x267E4E0 VA: 0x18267FEE0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x267FE50 Offset: 0x267E450 VA: 0x18267FE50
	internal static NavmeshBakingAnalytic CreateNavmeshBakingAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class ProjectSettingsInformationAnalytic : AnalyticsEventBase // TypeDefIndex: 14132
{
	// Fields
	private int agent_types_count; // 0x30
	private int areas_count; // 0x34

	// Methods

	// RVA: 0x26809C0 Offset: 0x267EFC0 VA: 0x1826809C0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680930 Offset: 0x267EF30 VA: 0x182680930
	internal static ProjectSettingsInformationAnalytic CreateProjectSettingsInformationAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
public class SendGameBuildAnalytic : AnalyticsEventBase // TypeDefIndex: 14133
{
	// Fields
	private int navmesh_count; // 0x30

	// Methods

	// RVA: 0x2680AC0 Offset: 0x267F0C0 VA: 0x182680AC0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680A30 Offset: 0x267F030 VA: 0x182680A30
	internal static SendGameBuildAnalytic CreateSendGameBuildAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerBaseAnalytic : AnalyticsEventBase // TypeDefIndex: 14134
{
	// Fields
	public long start_ts; // 0x30
	public long duration; // 0x38
	public bool blocking; // 0x40
	public string package_id; // 0x48
	public int status_code; // 0x50
	public string error_message; // 0x58

	// Methods

	// RVA: 0x2680080 Offset: 0x267E680 VA: 0x182680080
	public void .ctor(string eventName) { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerAddPackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 14135
{
	// Methods

	// RVA: 0x2680000 Offset: 0x267E600 VA: 0x182680000
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x267FF50 Offset: 0x267E550 VA: 0x18267FF50
	internal static PackageManagerAddPackageAnalytic CreatePackageManagerAddPackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerTestAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 14136
{
	// Methods

	// RVA: 0x26808B0 Offset: 0x267EEB0 VA: 0x1826808B0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680800 Offset: 0x267EE00 VA: 0x182680800
	internal static PackageManagerTestAnalytic CreatePackageManagerTestAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerRemovePackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 14137
{
	// Methods

	// RVA: 0x26802C0 Offset: 0x267E8C0 VA: 0x1826802C0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680210 Offset: 0x267E810 VA: 0x182680210
	internal static PackageManagerRemovePackageAnalytic CreatePackageManagerRemovePackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerResolvePackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 14138
{
	// Fields
	public string[] packages; // 0x60
	public string[] package_registries; // 0x68
	public string[] package_signatures; // 0x70
	public string[] package_sources; // 0x78
	public string[] package_types; // 0x80

	// Methods

	// RVA: 0x2680650 Offset: 0x267EC50 VA: 0x182680650
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x26805A0 Offset: 0x267EBA0 VA: 0x1826805A0
	internal static PackageManagerResolvePackageAnalytic CreatePackageManagerResolvePackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerEmbedPackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 14139
{
	// Methods

	// RVA: 0x2680190 Offset: 0x267E790 VA: 0x182680190
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x26800E0 Offset: 0x267E6E0 VA: 0x1826800E0
	internal static PackageManagerEmbedPackageAnalytic CreatePackageManagerEmbedPackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerResetPackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 14140
{
	// Methods

	// RVA: 0x26803F0 Offset: 0x267E9F0 VA: 0x1826803F0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680340 Offset: 0x267E940 VA: 0x182680340
	internal static PackageManagerResetPackageAnalytic CreatePackageManagerResetPackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerResolveErrorPackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 14141
{
	// Fields
	public string reason; // 0x60
	public string action; // 0x68

	// Methods

	// RVA: 0x2680520 Offset: 0x267EB20 VA: 0x182680520
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680470 Offset: 0x267EA70 VA: 0x182680470
	internal static PackageManagerResolveErrorPackageAnalytic CreatePackageManagerResolveErrorPackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class PackageManagerStartServerPackageAnalytic : PackageManagerBaseAnalytic // TypeDefIndex: 14142
{
	// Methods

	// RVA: 0x2680780 Offset: 0x267ED80 VA: 0x182680780
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x26806D0 Offset: 0x267ECD0 VA: 0x1826806D0
	internal static PackageManagerStartServerPackageAnalytic CreatePackageManagerStartServerPackageAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
internal class AssetImportStatusAnalytic : AnalyticsEventBase // TypeDefIndex: 14143
{
	// Fields
	public string package_name; // 0x30
	public int package_items_count; // 0x38
	public int package_import_status; // 0x3C
	public string error_message; // 0x40

	// Methods

	// RVA: 0x267F8E0 Offset: 0x267DEE0 VA: 0x18267F8E0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x267F850 Offset: 0x267DE50 VA: 0x18267F850
	public static AssetImportStatusAnalytic CreateAssetImportStatusAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
internal class AssetImportAnalytic : AnalyticsEventBase // TypeDefIndex: 14144
{
	// Fields
	public string package_name; // 0x30
	public int package_import_choice; // 0x38

	// Methods

	// RVA: 0x267F7E0 Offset: 0x267DDE0 VA: 0x18267F7E0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x267F750 Offset: 0x267DD50 VA: 0x18267F750
	public static AssetImportAnalytic CreateAssetImportAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
public class StallSummaryAnalytic : AnalyticsEventBase // TypeDefIndex: 14145
{
	// Fields
	public double Duration; // 0x30

	// Methods

	// RVA: 0x2680CC0 Offset: 0x267F2C0 VA: 0x182680CC0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680C30 Offset: 0x267F230 VA: 0x182680C30
	internal static StallSummaryAnalytic CreateStallSummaryAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
internal class StallMarkerAnalytic : AnalyticsEventBase // TypeDefIndex: 14146
{
	// Fields
	public string Name; // 0x30
	public bool HasProgressMarkup; // 0x38
	public double Duration; // 0x40

	// Methods

	// RVA: 0x2680BC0 Offset: 0x267F1C0 VA: 0x182680BC0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2680B30 Offset: 0x267F130 VA: 0x182680B30
	internal static StallMarkerAnalytic CreateStallMarkerAnalytic() { }
}

// Namespace: UnityEditor.Analytics
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
internal class TestAnalytic : AnalyticsEventBase // TypeDefIndex: 14147
{
	// Fields
	public int param; // 0x30

	// Methods

	// RVA: 0x26811B0 Offset: 0x267F7B0 VA: 0x1826811B0
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x2681120 Offset: 0x267F720 VA: 0x182681120
	public static TestAnalytic CreateTestAnalytic() { }
}

