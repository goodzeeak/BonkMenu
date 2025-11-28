// Namespace: UnityEngine.ProBuilder.KdTree.Math
[Serializable]
internal class DoubleMath : TypeMath<double> // TypeDefIndex: 14010
{
	// Properties
	public override double MinValue { get; }
	public override double MaxValue { get; }
	public override double Zero { get; }
	public override double NegativeInfinity { get; }
	public override double PositiveInfinity { get; }

	// Methods

	// RVA: 0x20724E0 Offset: 0x2070AE0 VA: 0x1820724E0 Slot: 18
	public override int Compare(double a, double b) { }

	// RVA: 0x10CB370 Offset: 0x10C9970 VA: 0x1810CB370 Slot: 19
	public override bool AreEqual(double a, double b) { }

	// RVA: 0x2072680 Offset: 0x2070C80 VA: 0x182072680 Slot: 21
	public override double get_MinValue() { }

	// RVA: 0x2072670 Offset: 0x2070C70 VA: 0x182072670 Slot: 22
	public override double get_MaxValue() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 23
	public override double get_Zero() { }

	// RVA: 0x2072690 Offset: 0x2070C90 VA: 0x182072690 Slot: 24
	public override double get_NegativeInfinity() { }

	// RVA: 0x20726A0 Offset: 0x2070CA0 VA: 0x1820726A0 Slot: 25
	public override double get_PositiveInfinity() { }

	// RVA: 0x20724D0 Offset: 0x2070AD0 VA: 0x1820724D0 Slot: 26
	public override double Add(double a, double b) { }

	// RVA: 0x2072620 Offset: 0x2070C20 VA: 0x182072620 Slot: 27
	public override double Subtract(double a, double b) { }

	// RVA: 0x2072610 Offset: 0x2070C10 VA: 0x182072610 Slot: 28
	public override double Multiply(double a, double b) { }

	// RVA: 0x2072500 Offset: 0x2070B00 VA: 0x182072500 Slot: 29
	public override double DistanceSquaredBetweenPoints(double[] a, double[] b) { }

	// RVA: 0x2072630 Offset: 0x2070C30 VA: 0x182072630
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.KdTree.Math
[Serializable]
internal class FloatMath : TypeMath<float> // TypeDefIndex: 14011
{
	// Properties
	public override float MinValue { get; }
	public override float MaxValue { get; }
	public override float Zero { get; }
	public override float NegativeInfinity { get; }
	public override float PositiveInfinity { get; }

	// Methods

	// RVA: 0x2072720 Offset: 0x2070D20 VA: 0x182072720 Slot: 18
	public override int Compare(float a, float b) { }

	// RVA: 0x110ED40 Offset: 0x110D340 VA: 0x18110ED40 Slot: 19
	public override bool AreEqual(float a, float b) { }

	// RVA: 0x20728C0 Offset: 0x2070EC0 VA: 0x1820728C0 Slot: 21
	public override float get_MinValue() { }

	// RVA: 0x20728B0 Offset: 0x2070EB0 VA: 0x1820728B0 Slot: 22
	public override float get_MaxValue() { }

	// RVA: 0x3645E0 Offset: 0x362BE0 VA: 0x1803645E0 Slot: 23
	public override float get_Zero() { }

	// RVA: 0x20728D0 Offset: 0x2070ED0 VA: 0x1820728D0 Slot: 24
	public override float get_NegativeInfinity() { }

	// RVA: 0x20728E0 Offset: 0x2070EE0 VA: 0x1820728E0 Slot: 25
	public override float get_PositiveInfinity() { }

	// RVA: 0x2072710 Offset: 0x2070D10 VA: 0x182072710 Slot: 26
	public override float Add(float a, float b) { }

	// RVA: 0x2072860 Offset: 0x2070E60 VA: 0x182072860 Slot: 27
	public override float Subtract(float a, float b) { }

	// RVA: 0x2072850 Offset: 0x2070E50 VA: 0x182072850 Slot: 28
	public override float Multiply(float a, float b) { }

	// RVA: 0x2072740 Offset: 0x2070D40 VA: 0x182072740 Slot: 29
	public override float DistanceSquaredBetweenPoints(float[] a, float[] b) { }

	// RVA: 0x2072870 Offset: 0x2070E70 VA: 0x182072870
	public void .ctor() { }
}

// Namespace: UnityEngine.ProBuilder.KdTree.Math
[Serializable]
internal abstract class TypeMath<T> : ITypeMath<T> // TypeDefIndex: 14012
{
	// Properties
	public abstract T MinValue { get; }
	public abstract T MaxValue { get; }
	public abstract T Zero { get; }
	public abstract T NegativeInfinity { get; }
	public abstract T PositiveInfinity { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int Compare(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.Compare
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool AreEqual(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.AreEqual
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public virtual bool AreEqual(T[] a, T[] b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA82960 Offset: 0xA80F60 VA: 0x180A82960
	|-TypeMath<double>.AreEqual
	|
	|-RVA: 0xA828C0 Offset: 0xA80EC0 VA: 0x180A828C0
	|-TypeMath<float>.AreEqual
	|
	|-RVA: 0xA82A00 Offset: 0xA81000 VA: 0x180A82A00
	|-TypeMath<__Il2CppFullySharedGenericType>.AreEqual
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public abstract T get_MinValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.get_MinValue
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public abstract T get_MaxValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.get_MaxValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public T Min(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA82F10 Offset: 0xA81510 VA: 0x180A82F10
	|-TypeMath<double>.Min
	|-TypeMath<float>.Min
	|
	|-RVA: 0xA82D70 Offset: 0xA81370 VA: 0x180A82D70
	|-TypeMath<__Il2CppFullySharedGenericType>.Min
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public T Max(T a, T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xA82D20 Offset: 0xA81320 VA: 0x180A82D20
	|-TypeMath<double>.Max
	|-TypeMath<float>.Max
	|
	|-RVA: 0xA82B80 Offset: 0xA81180 VA: 0x180A82B80
	|-TypeMath<__Il2CppFullySharedGenericType>.Max
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public abstract T get_Zero();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.get_Zero
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public abstract T get_NegativeInfinity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.get_NegativeInfinity
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public abstract T get_PositiveInfinity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.get_PositiveInfinity
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public abstract T Add(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public abstract T Subtract(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.Subtract
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public abstract T Multiply(T a, T b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.Multiply
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public abstract T DistanceSquaredBetweenPoints(T[] a, T[] b);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeMath<__Il2CppFullySharedGenericType>.DistanceSquaredBetweenPoints
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	|-TypeMath<double>..ctor
	|-TypeMath<float>..ctor
	|-TypeMath<__Il2CppFullySharedGenericType>..ctor
	*/
}

