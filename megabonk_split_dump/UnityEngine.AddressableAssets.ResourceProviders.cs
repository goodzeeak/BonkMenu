// Namespace: UnityEngine.AddressableAssets.ResourceProviders
[DisplayName("Content Catalog Provider")]
public class ContentCatalogProvider : ResourceProviderBase // TypeDefIndex: 13141
{
	// Fields
	public bool DisableCatalogUpdateOnStart; // 0x20
	public bool IsLocalCatalogInBundle; // 0x21
	internal Dictionary<IResourceLocation, ContentCatalogProvider.InternalOp> m_LocationToCatalogLoadOpMap; // 0x28
	private ResourceManager m_RM; // 0x30

	// Methods

	// RVA: 0x1EB5E10 Offset: 0x1EB4410 VA: 0x181EB5E10
	public void .ctor(ResourceManager resourceManagerInstance) { }

	// RVA: 0x1EB5C00 Offset: 0x1EB4200 VA: 0x181EB5C00 Slot: 15
	public override void Release(IResourceLocation location, object obj) { }

	// RVA: 0x1EB5AA0 Offset: 0x1EB40A0 VA: 0x181EB5AA0 Slot: 17
	public override void Provide(ProvideHandle providerInterface) { }
}

