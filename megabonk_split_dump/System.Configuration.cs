// Namespace: System.Configuration
public interface IConfigurationSectionHandler // TypeDefIndex: 7988
{}

// Namespace: System.Configuration
[DefaultMember("Item")]
public abstract class ConfigurationElement // TypeDefIndex: 14300
{
	// Properties
	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x19DE230 Offset: 0x19DC830 VA: 0x1819DE230 Slot: 4
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x19DE1A0 Offset: 0x19DC7A0 VA: 0x1819DE1A0 Slot: 5
	protected internal virtual bool IsModified() { }

	// RVA: 0x19DE200 Offset: 0x19DC800 VA: 0x1819DE200 Slot: 6
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x19DE1D0 Offset: 0x19DC7D0 VA: 0x1819DE1D0 Slot: 7
	protected internal virtual void ResetModified() { }
}

// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 14301
{
	// Methods

	// RVA: 0x19DE260 Offset: 0x19DC860 VA: 0x1819DE260 Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x19DE290 Offset: 0x19DC890 VA: 0x1819DE290 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x19DE2C0 Offset: 0x19DC8C0 VA: 0x1819DE2C0 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x19DE2F0 Offset: 0x19DC8F0 VA: 0x1819DE2F0 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }
}

// Namespace: System.Configuration
public enum ConfigurationSaveMode // TypeDefIndex: 14302
{
	// Fields
	public int value__; // 0x0
	public const ConfigurationSaveMode Full = 2;
	public const ConfigurationSaveMode Minimal = 1;
	public const ConfigurationSaveMode Modified = 0;
}

// Namespace: System.Configuration
[DefaultMember("Item")]
public class ConfigurationPropertyCollection // TypeDefIndex: 14303
{}

// Namespace: System.Configuration
[DebuggerDisplay("Count = {Count}")]
public abstract class ConfigurationElementCollection : ConfigurationElement // TypeDefIndex: 14304
{}

// Namespace: System.Configuration
[Usage(132)]
public sealed class ConfigurationCollectionAttribute : Attribute // TypeDefIndex: 14305
{
	// Methods

	// RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	public void .ctor(Type itemType) { }
}

// Namespace: System.Configuration
public class ConfigurationSectionGroup // TypeDefIndex: 14306
{}

// Namespace: System.Configuration
public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 14307
{
	// Properties
	protected internal override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x19DE410 Offset: 0x19DCA10 VA: 0x1819DE410
	public void .ctor() { }

	// RVA: 0x19DE440 Offset: 0x19DCA40 VA: 0x1819DE440 Slot: 4
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x19DE320 Offset: 0x19DC920 VA: 0x1819DE320 Slot: 8
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0x19DE350 Offset: 0x19DC950 VA: 0x1819DE350 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x19DE3B0 Offset: 0x19DC9B0 VA: 0x1819DE3B0 Slot: 6
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0x19DE380 Offset: 0x19DC980 VA: 0x1819DE380 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x19DE3E0 Offset: 0x19DC9E0 VA: 0x1819DE3E0 Slot: 9
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }
}

