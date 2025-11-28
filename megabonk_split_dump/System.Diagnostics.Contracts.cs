// Namespace: System.Diagnostics.Contracts
public static class Contract // TypeDefIndex: 1413
{
	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: -1 Offset: -1
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6BC0D0 Offset: 0x6BA6D0 VA: 0x1806BC0D0
	|-Contract.ForAll<object>
	|
	|-RVA: 0x6BBDE0 Offset: 0x6BA3E0 VA: 0x1806BBDE0
	|-Contract.ForAll<__Il2CppFullySharedGenericType>
	*/
}

