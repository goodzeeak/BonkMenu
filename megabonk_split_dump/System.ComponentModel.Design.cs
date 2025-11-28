// Namespace: System.ComponentModel.Design
[Serializable]
public class CheckoutException : ExternalException // TypeDefIndex: 7678
{
	// Fields
	public static readonly CheckoutException Canceled; // 0x0

	// Methods

	// RVA: 0x1E4A380 Offset: 0x1E48980 VA: 0x181E4A380
	public void .ctor() { }

	// RVA: 0x1E4A370 Offset: 0x1E48970 VA: 0x181E4A370
	public void .ctor(string message) { }

	// RVA: 0x1E4A390 Offset: 0x1E48990 VA: 0x181E4A390
	public void .ctor(string message, int errorCode) { }

	// RVA: 0x14154C0 Offset: 0x1413AC0 VA: 0x1814154C0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1E4A2E0 Offset: 0x1E488E0 VA: 0x181E4A2E0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel.Design
public interface IComponentChangeService // TypeDefIndex: 7679
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnComponentChanging(object component, MemberDescriptor member);
}

// Namespace: System.ComponentModel.Design
public interface IDesigner : IDisposable // TypeDefIndex: 7680
{}

// Namespace: System.ComponentModel.Design
public interface IDesignerHost : IServiceProvider // TypeDefIndex: 7681
{
	// Properties
	public abstract IComponent RootComponent { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IComponent get_RootComponent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDesigner GetDesigner(IComponent component);
}

// Namespace: System.ComponentModel.Design
public interface IDictionaryService // TypeDefIndex: 7682
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetValue(object key);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetValue(object key, object value);
}

// Namespace: System.ComponentModel.Design
public interface IExtenderListService // TypeDefIndex: 7683
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IExtenderProvider[] GetExtenderProviders();
}

// Namespace: System.ComponentModel.Design
public interface IReferenceService // TypeDefIndex: 7684
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetReference(string name);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetName(object reference);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object[] GetReferences(Type baseType);
}

// Namespace: System.ComponentModel.Design
public interface ITypeDescriptorFilterService // TypeDefIndex: 7685
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool FilterAttributes(IComponent component, IDictionary attributes);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool FilterEvents(IComponent component, IDictionary events);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool FilterProperties(IComponent component, IDictionary properties);
}

