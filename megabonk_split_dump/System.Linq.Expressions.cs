// Namespace: System.Linq.Expressions
internal static class CachedReflectionInfo // TypeDefIndex: 10752
{
	// Fields
	private static MethodInfo s_CallSiteOps_SetNotMatched; // 0x0
	private static MethodInfo s_CallSiteOps_CreateMatchmaker; // 0x8
	private static MethodInfo s_CallSiteOps_GetMatch; // 0x10
	private static MethodInfo s_CallSiteOps_ClearMatch; // 0x18
	private static MethodInfo s_CallSiteOps_UpdateRules; // 0x20
	private static MethodInfo s_CallSiteOps_GetRules; // 0x28
	private static MethodInfo s_CallSiteOps_GetRuleCache; // 0x30
	private static MethodInfo s_CallSiteOps_GetCachedRules; // 0x38
	private static MethodInfo s_CallSiteOps_AddRule; // 0x40
	private static MethodInfo s_CallSiteOps_MoveRule; // 0x48
	private static MethodInfo s_CallSiteOps_Bind; // 0x50
	private static MethodInfo s_String_op_Equality_String_String; // 0x58
	private static MethodInfo s_Math_Pow_Double_Double; // 0x60

	// Properties
	public static MethodInfo CallSiteOps_SetNotMatched { get; }
	public static MethodInfo CallSiteOps_CreateMatchmaker { get; }
	public static MethodInfo CallSiteOps_GetMatch { get; }
	public static MethodInfo CallSiteOps_ClearMatch { get; }
	public static MethodInfo CallSiteOps_UpdateRules { get; }
	public static MethodInfo CallSiteOps_GetRules { get; }
	public static MethodInfo CallSiteOps_GetRuleCache { get; }
	public static MethodInfo CallSiteOps_GetCachedRules { get; }
	public static MethodInfo CallSiteOps_AddRule { get; }
	public static MethodInfo CallSiteOps_MoveRule { get; }
	public static MethodInfo CallSiteOps_Bind { get; }
	public static MethodInfo String_op_Equality_String_String { get; }
	public static MethodInfo Math_Pow_Double_Double { get; }

	// Methods

	// RVA: 0x19E8580 Offset: 0x19E6B80 VA: 0x1819E8580
	public static MethodInfo get_CallSiteOps_SetNotMatched() { }

	// RVA: 0x19E80A0 Offset: 0x19E66A0 VA: 0x1819E80A0
	public static MethodInfo get_CallSiteOps_CreateMatchmaker() { }

	// RVA: 0x19E8240 Offset: 0x19E6840 VA: 0x1819E8240
	public static MethodInfo get_CallSiteOps_GetMatch() { }

	// RVA: 0x19E7FD0 Offset: 0x19E65D0 VA: 0x1819E7FD0
	public static MethodInfo get_CallSiteOps_ClearMatch() { }

	// RVA: 0x19E8650 Offset: 0x19E6C50 VA: 0x1819E8650
	public static MethodInfo get_CallSiteOps_UpdateRules() { }

	// RVA: 0x19E83E0 Offset: 0x19E69E0 VA: 0x1819E83E0
	public static MethodInfo get_CallSiteOps_GetRules() { }

	// RVA: 0x19E8310 Offset: 0x19E6910 VA: 0x1819E8310
	public static MethodInfo get_CallSiteOps_GetRuleCache() { }

	// RVA: 0x19E8170 Offset: 0x19E6770 VA: 0x1819E8170
	public static MethodInfo get_CallSiteOps_GetCachedRules() { }

	// RVA: 0x19E7E30 Offset: 0x19E6430 VA: 0x1819E7E30
	public static MethodInfo get_CallSiteOps_AddRule() { }

	// RVA: 0x19E84B0 Offset: 0x19E6AB0 VA: 0x1819E84B0
	public static MethodInfo get_CallSiteOps_MoveRule() { }

	// RVA: 0x19E7F00 Offset: 0x19E6500 VA: 0x1819E7F00
	public static MethodInfo get_CallSiteOps_Bind() { }

	// RVA: 0x19E8900 Offset: 0x19E6F00 VA: 0x1819E8900
	public static MethodInfo get_String_op_Equality_String_String() { }

	// RVA: 0x19E8720 Offset: 0x19E6D20 VA: 0x1819E8720
	public static MethodInfo get_Math_Pow_Double_Double() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.BinaryExpressionProxy))]
public class BinaryExpression : Expression // TypeDefIndex: 10753
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Right>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Left>k__BackingField; // 0x18

	// Properties
	public override bool CanReduce { get; }
	public Expression Right { get; }
	public Expression Left { get; }
	public MethodInfo Method { get; }
	public LambdaExpression Conversion { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	internal bool IsLiftedLogical { get; }
	internal bool IsReferenceComparison { get; }

	// Methods

	// RVA: 0x19E78A0 Offset: 0x19E5EA0 VA: 0x1819E78A0
	internal void .ctor(Expression left, Expression right) { }

	// RVA: 0x19E7930 Offset: 0x19E5F30 VA: 0x1819E7930 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x19E5BA0 Offset: 0x19E41A0 VA: 0x1819E5BA0
	private static bool IsOpAssignment(ExpressionType op) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Expression get_Right() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Expression get_Left() { }

	// RVA: 0x14438C0 Offset: 0x1441EC0 VA: 0x1814438C0
	public MethodInfo get_Method() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 10
	internal virtual MethodInfo GetMethod() { }

	// RVA: 0x19E7360 Offset: 0x19E5960 VA: 0x1819E7360
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) { }

	// RVA: 0x19E72E0 Offset: 0x19E58E0 VA: 0x1819E72E0 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x19E5A80 Offset: 0x19E4080 VA: 0x1819E5A80
	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) { }

	// RVA: 0x19E71A0 Offset: 0x19E57A0 VA: 0x1819E71A0
	private Expression ReduceVariable() { }

	// RVA: 0x19E62D0 Offset: 0x19E48D0 VA: 0x1819E62D0
	private Expression ReduceMember() { }

	// RVA: 0x19E5BB0 Offset: 0x19E41B0 VA: 0x1819E5BB0
	private Expression ReduceIndex() { }

	// RVA: 0x187F8A0 Offset: 0x187DEA0 VA: 0x18187F8A0
	public LambdaExpression get_Conversion() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 11
	internal virtual LambdaExpression GetConversion() { }

	// RVA: 0x19E7B70 Offset: 0x19E6170 VA: 0x1819E7B70
	public bool get_IsLifted() { }

	// RVA: 0x19E7AF0 Offset: 0x19E60F0 VA: 0x1819E7AF0
	public bool get_IsLiftedToNull() { }

	// RVA: 0x19E5A50 Offset: 0x19E4050 VA: 0x1819E5A50 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x19E7960 Offset: 0x19E5F60 VA: 0x1819E7960
	internal bool get_IsLiftedLogical() { }

	// RVA: 0x19E7D40 Offset: 0x19E6340 VA: 0x1819E7D40
	internal bool get_IsReferenceComparison() { }

	// RVA: 0x19E67E0 Offset: 0x19E4DE0 VA: 0x1819E67E0
	internal Expression ReduceUserdefinedLifted() { }
}

// Namespace: System.Linq.Expressions
internal sealed class LogicalBinaryExpression : BinaryExpression // TypeDefIndex: 10754
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x1A05BD0 Offset: 0x1A041D0 VA: 0x181A05BD0
	internal void .ctor(ExpressionType nodeType, Expression left, Expression right) { }

	// RVA: 0x1A05C10 Offset: 0x1A04210 VA: 0x181A05C10 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 4
	public sealed override ExpressionType get_NodeType() { }
}

// Namespace: System.Linq.Expressions
internal class AssignBinaryExpression : BinaryExpression // TypeDefIndex: 10755
{
	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x19E5A30 Offset: 0x19E4030 VA: 0x1819E5A30
	internal void .ctor(Expression left, Expression right) { }

	// RVA: 0x197A8C0 Offset: 0x1978EC0 VA: 0x18197A8C0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x19E5A40 Offset: 0x19E4040 VA: 0x1819E5A40 Slot: 4
	public sealed override ExpressionType get_NodeType() { }
}

// Namespace: System.Linq.Expressions
internal sealed class CoalesceConversionBinaryExpression : BinaryExpression // TypeDefIndex: 10756
{
	// Fields
	private readonly LambdaExpression _conversion; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x19E8AD0 Offset: 0x19E70D0 VA: 0x1819E8AD0
	internal void .ctor(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 11
	internal override LambdaExpression GetConversion() { }

	// RVA: 0x4565D0 Offset: 0x454BD0 VA: 0x1804565D0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x16501C0 Offset: 0x164E7C0 VA: 0x1816501C0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression // TypeDefIndex: 10757
{
	// Fields
	private readonly LambdaExpression _conversion; // 0x38

	// Methods

	// RVA: 0x1A05CB0 Offset: 0x1A042B0 VA: 0x181A05CB0
	internal void .ctor(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750 Slot: 11
	internal override LambdaExpression GetConversion() { }
}

// Namespace: System.Linq.Expressions
internal class SimpleBinaryExpression : BinaryExpression // TypeDefIndex: 10758
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x28

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1A06010 Offset: 0x1A04610 VA: 0x181A06010
	internal void .ctor(ExpressionType nodeType, Expression left, Expression right, Type type) { }

	[CompilerGenerated]
	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal class MethodBinaryExpression : SimpleBinaryExpression // TypeDefIndex: 10759
{
	// Fields
	private readonly MethodInfo _method; // 0x30

	// Methods

	// RVA: 0x1A05C50 Offset: 0x1A04250 VA: 0x181A05C50
	internal void .ctor(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 10
	internal override MethodInfo GetMethod() { }
}

// Namespace: System.Linq.Expressions
public abstract class Expression // TypeDefIndex: 10788
{
	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x8
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x10

	// Properties
	public virtual ExpressionType NodeType { get; }
	public virtual Type Type { get; }
	public virtual bool CanReduce { get; }

	// Methods

	// RVA: 0x19EB740 Offset: 0x19E9D40 VA: 0x1819EB740
	public static BinaryExpression Assign(Expression left, Expression right) { }

	// RVA: 0x19F3BB0 Offset: 0x19F21B0 VA: 0x1819F3BB0
	private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x19F1FA0 Offset: 0x19F05A0 VA: 0x1819F1FA0
	private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) { }

	// RVA: 0x19F1CE0 Offset: 0x19F02E0 VA: 0x1819F1CE0
	private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x19F3950 Offset: 0x19F1F50 VA: 0x1819F3950
	private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x19F3690 Offset: 0x19F1C90 VA: 0x1819F3690
	private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) { }

	// RVA: 0x19F3FC0 Offset: 0x19F25C0 VA: 0x1819F3FC0
	private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, Type leftType, Type rightType, string name) { }

	// RVA: 0x19F6660 Offset: 0x19F4C60 VA: 0x1819F6660
	private static bool IsLiftingConditionalLogicalOperator(Type left, Type right, MethodInfo method, ExpressionType binaryType) { }

	// RVA: 0x19FDCA0 Offset: 0x19FC2A0 VA: 0x1819FDCA0
	internal static bool ParameterIsAssignable(ParameterInfo pi, Type argType) { }

	// RVA: 0x1A041A0 Offset: 0x1A027A0 VA: 0x181A041A0
	private static void ValidateParamswithOperandsOrThrow(Type paramType, Type operandType, ExpressionType exprType, string name) { }

	// RVA: 0x1A03FF0 Offset: 0x1A025F0 VA: 0x181A03FF0
	private static void ValidateOperator(MethodInfo method) { }

	// RVA: 0x1A032D0 Offset: 0x1A018D0 VA: 0x181A032D0
	private static void ValidateMethodInfo(MethodInfo method, string paramName) { }

	// RVA: 0x19F6720 Offset: 0x19F4D20 VA: 0x1819F6720
	private static bool IsNullComparison(Expression left, Expression right) { }

	// RVA: 0x19F6950 Offset: 0x19F4F50 VA: 0x1819F6950
	private static bool IsNullConstant(Expression e) { }

	// RVA: 0x1A04980 Offset: 0x1A02F80 VA: 0x181A04980
	private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, Type left, Type right, MethodInfo method) { }

	// RVA: 0x1A055C0 Offset: 0x1A03BC0 VA: 0x181A055C0
	private static void VerifyOpTrueFalse(ExpressionType nodeType, Type left, MethodInfo opTrue, string paramName) { }

	// RVA: 0x19F6C10 Offset: 0x19F5210 VA: 0x1819F6C10
	private static bool IsValidLiftedConditionalLogicalOperator(Type left, Type right, ParameterInfo[] pms) { }

	// RVA: 0x19F88F0 Offset: 0x19F6EF0 VA: 0x1819F88F0
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x19F7B20 Offset: 0x19F6120 VA: 0x1819F7B20
	public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19F0780 Offset: 0x19EED80 VA: 0x1819F0780
	public static BinaryExpression Equal(Expression left, Expression right) { }

	// RVA: 0x19F07F0 Offset: 0x19EEDF0 VA: 0x1819F07F0
	public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x19FEF20 Offset: 0x19FD520 VA: 0x1819FEF20
	public static BinaryExpression ReferenceEqual(Expression left, Expression right) { }

	// RVA: 0x19FCD00 Offset: 0x19FB300 VA: 0x1819FCD00
	public static BinaryExpression NotEqual(Expression left, Expression right) { }

	// RVA: 0x19FCD70 Offset: 0x19FB370 VA: 0x1819FCD70
	public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x19FF0B0 Offset: 0x19FD6B0 VA: 0x1819FF0B0
	public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) { }

	// RVA: 0x19F1660 Offset: 0x19EFC60 VA: 0x1819F1660
	private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x19F4C10 Offset: 0x19F3210 VA: 0x1819F4C10
	public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x19F78E0 Offset: 0x19F5EE0 VA: 0x1819F78E0
	public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x19F4AF0 Offset: 0x19F30F0 VA: 0x1819F4AF0
	public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x19F77C0 Offset: 0x19F5DC0 VA: 0x1819F77C0
	public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) { }

	// RVA: 0x19F1420 Offset: 0x19EFA20 VA: 0x1819F1420
	private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) { }

	// RVA: 0x19EA8D0 Offset: 0x19E8ED0 VA: 0x1819EA8D0
	public static BinaryExpression AndAlso(Expression left, Expression right) { }

	// RVA: 0x19EA390 Offset: 0x19E8990 VA: 0x1819EA390
	public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19FD4F0 Offset: 0x19FBAF0 VA: 0x1819FD4F0
	public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19EE800 Offset: 0x19ECE00 VA: 0x1819EE800
	public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x1A01DA0 Offset: 0x1A003A0 VA: 0x181A01DA0
	private static Type ValidateCoalesceArgTypes(Type left, Type right) { }

	// RVA: 0x19EA140 Offset: 0x19E8740 VA: 0x1819EA140
	public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19E9C40 Offset: 0x19E8240 VA: 0x1819E9C40
	public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1A03D20 Offset: 0x1A02320 VA: 0x181A03D20
	private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) { }

	// RVA: 0x19E9990 Offset: 0x19E7F90 VA: 0x1819E9990
	public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19E9EF0 Offset: 0x19E84F0 VA: 0x1819E9EF0
	public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x1A003B0 Offset: 0x19FE9B0 VA: 0x181A003B0
	public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19FFEB0 Offset: 0x19FE4B0 VA: 0x1819FFEB0
	public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19FFC00 Offset: 0x19FE200 VA: 0x1819FFC00
	public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x1A00160 Offset: 0x19FE760 VA: 0x181A00160
	public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19F04B0 Offset: 0x19EEAB0 VA: 0x1819F04B0
	public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19F0200 Offset: 0x19EE800 VA: 0x1819F0200
	public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19FADD0 Offset: 0x19F93D0 VA: 0x1819FADD0
	public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19FAB20 Offset: 0x19F9120 VA: 0x1819FAB20
	public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19FB7D0 Offset: 0x19F9DD0 VA: 0x1819FB7D0
	public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19FB2D0 Offset: 0x19F98D0 VA: 0x1819FB2D0
	public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19FB020 Offset: 0x19F9620 VA: 0x1819FB020
	public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19FB580 Offset: 0x19F9B80 VA: 0x1819FB580
	public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19F69C0 Offset: 0x19F4FC0 VA: 0x1819F69C0
	private static bool IsSimpleShift(Type left, Type right) { }

	// RVA: 0x19F3520 Offset: 0x19F1B20 VA: 0x1819F3520
	private static Type GetResultTypeOfShift(Type left, Type right) { }

	// RVA: 0x19F7580 Offset: 0x19F5B80 VA: 0x1819F7580
	public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19F72E0 Offset: 0x19F58E0 VA: 0x1819F72E0
	public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19FF9C0 Offset: 0x19FDFC0 VA: 0x1819FF9C0
	public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19FF720 Offset: 0x19FDD20 VA: 0x1819FF720
	public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19EABE0 Offset: 0x19E91E0 VA: 0x1819EABE0
	public static BinaryExpression And(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19EA930 Offset: 0x19E8F30 VA: 0x1819EA930
	public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19FDA50 Offset: 0x19FC050 VA: 0x1819FDA50
	public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19FD240 Offset: 0x19FB840 VA: 0x1819FD240
	public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19F0BC0 Offset: 0x19EF1C0 VA: 0x1819F0BC0
	public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19F0910 Offset: 0x19EEF10 VA: 0x1819F0910
	public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19FE130 Offset: 0x19FC730 VA: 0x1819FE130
	public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) { }

	// RVA: 0x19FDF90 Offset: 0x19FC590 VA: 0x1819FDF90
	public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) { }

	// RVA: 0x19EB320 Offset: 0x19E9920 VA: 0x1819EB320
	public static BinaryExpression ArrayIndex(Expression array, Expression index) { }

	// RVA: 0x19EC330 Offset: 0x19EA930 VA: 0x1819EC330
	public static BlockExpression Block(Expression arg0, Expression arg1) { }

	// RVA: 0x19EC570 Offset: 0x19EAB70 VA: 0x1819EC570
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x19EC220 Offset: 0x19EA820 VA: 0x1819EC220
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x19EC440 Offset: 0x19EAA40 VA: 0x1819EC440
	public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x19EC7C0 Offset: 0x19EADC0 VA: 0x1819EC7C0
	public static BlockExpression Block(IEnumerable<Expression> expressions) { }

	// RVA: 0x19EC130 Offset: 0x19EA730 VA: 0x1819EC130
	public static BlockExpression Block(Type type, Expression[] expressions) { }

	// RVA: 0x19EC090 Offset: 0x19EA690 VA: 0x1819EC090
	public static BlockExpression Block(Type type, IEnumerable<Expression> expressions) { }

	// RVA: 0x19EC850 Offset: 0x19EAE50 VA: 0x1819EC850
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x19EC3D0 Offset: 0x19EA9D0 VA: 0x1819EC3D0
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, Expression[] expressions) { }

	// RVA: 0x19EC650 Offset: 0x19EAC50 VA: 0x1819EC650
	public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x19EBE70 Offset: 0x19EA470 VA: 0x1819EBE70
	public static BlockExpression Block(Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) { }

	// RVA: 0x19EB940 Offset: 0x19E9F40 VA: 0x1819EB940
	private static BlockExpression BlockCore(Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x1A05210 Offset: 0x1A03810 VA: 0x181A05210
	internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) { }

	// RVA: 0x19F2E70 Offset: 0x19F1470 VA: 0x1819F2E70
	private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x19F8980 Offset: 0x19F6F80 VA: 0x1819F8980
	public static CatchBlock MakeCatchBlock(Type type, ParameterExpression variable, Expression body, Expression filter) { }

	// RVA: 0x19EF110 Offset: 0x19ED710 VA: 0x1819EF110
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x19EEEA0 Offset: 0x19ED4A0 VA: 0x1819EEEA0
	public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x19F4D30 Offset: 0x19F3330 VA: 0x1819F4D30
	public static ConditionalExpression IfThen(Expression test, Expression ifTrue) { }

	// RVA: 0x19EF560 Offset: 0x19EDB60 VA: 0x1819EF560
	public static ConstantExpression Constant(object value) { }

	// RVA: 0x19EF320 Offset: 0x19ED920 VA: 0x1819EF320
	public static ConstantExpression Constant(object value, Type type) { }

	// RVA: 0x19F0700 Offset: 0x19EED00 VA: 0x1819F0700
	public static DefaultExpression Empty() { }

	// RVA: 0x19F0150 Offset: 0x19EE750 VA: 0x1819F0150
	public static DefaultExpression Default(Type type) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1A059F0 Offset: 0x1A03FF0 VA: 0x181A059F0 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x1A05AE0 Offset: 0x1A040E0 VA: 0x181A05AE0 Slot: 5
	public virtual Type get_Type() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 6
	public virtual bool get_CanReduce() { }

	// RVA: 0x19FEED0 Offset: 0x19FD4D0 VA: 0x1819FEED0 Slot: 7
	public virtual Expression Reduce() { }

	// RVA: 0x1A057A0 Offset: 0x1A03DA0 VA: 0x181A057A0 Slot: 8
	protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) { }

	// RVA: 0x19E9960 Offset: 0x19E7F60 VA: 0x1819E9960 Slot: 9
	protected internal virtual Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x19FED80 Offset: 0x19FD380 VA: 0x1819FED80
	public Expression ReduceAndCheck() { }

	// RVA: 0x1A00750 Offset: 0x19FED50 VA: 0x181A00750 Slot: 3
	public override string ToString() { }

	// RVA: 0x19FF240 Offset: 0x19FD840 VA: 0x1819FF240
	private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) { }

	// RVA: 0x19FF360 Offset: 0x19FD960 VA: 0x1819FF360
	private static void RequiresCanWrite(Expression expression, string paramName) { }

	// RVA: 0x19EC8B0 Offset: 0x19EAEB0 VA: 0x1819EC8B0
	public static GotoExpression Break(LabelTarget target) { }

	// RVA: 0x19FF5F0 Offset: 0x19FDBF0 VA: 0x1819FF5F0
	public static GotoExpression Return(LabelTarget target) { }

	// RVA: 0x19FF680 Offset: 0x19FDC80 VA: 0x1819FF680
	public static GotoExpression Return(LabelTarget target, Expression value) { }

	// RVA: 0x19F4A80 Offset: 0x19F3080 VA: 0x1819F4A80
	public static GotoExpression Goto(LabelTarget target, Type type) { }

	// RVA: 0x19F49E0 Offset: 0x19F2FE0 VA: 0x1819F49E0
	public static GotoExpression Goto(LabelTarget target, Expression value) { }

	// RVA: 0x19F8C00 Offset: 0x19F7200 VA: 0x1819F8C00
	public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	// RVA: 0x1A020F0 Offset: 0x1A006F0 VA: 0x181A020F0
	private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, Type type) { }

	// RVA: 0x1A01FA0 Offset: 0x1A005A0 VA: 0x181A01FA0
	private static void ValidateGotoType(Type expectedType, ref Expression value, string paramName) { }

	// RVA: 0x19F8DC0 Offset: 0x19F73C0 VA: 0x1819F8DC0
	public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x19EAF00 Offset: 0x19E9500 VA: 0x1819EAF00
	public static IndexExpression ArrayAccess(Expression array, Expression[] indexes) { }

	// RVA: 0x19EAF60 Offset: 0x19E9560 VA: 0x1819EAF60
	public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) { }

	// RVA: 0x19FEB30 Offset: 0x19FD130 VA: 0x1819FEB30
	public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) { }

	// RVA: 0x19F8CF0 Offset: 0x19F72F0 VA: 0x1819F8CF0
	private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x1A02390 Offset: 0x1A00990 VA: 0x181A02390
	private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) { }

	// RVA: 0x1A01380 Offset: 0x19FF980 VA: 0x181A01380
	private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x1A00EC0 Offset: 0x19FF4C0 VA: 0x181A00EC0
	private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) { }

	// RVA: 0x19F5660 Offset: 0x19F3C60 VA: 0x1819F5660
	internal static InvocationExpression Invoke(Expression expression) { }

	// RVA: 0x19F5E80 Offset: 0x19F4480 VA: 0x1819F5E80
	internal static InvocationExpression Invoke(Expression expression, Expression arg0) { }

	// RVA: 0x19F5760 Offset: 0x19F3D60 VA: 0x1819F5760
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1) { }

	// RVA: 0x19F5940 Offset: 0x19F3F40 VA: 0x1819F5940
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x19F6000 Offset: 0x19F4600 VA: 0x1819F6000
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x19F5B80 Offset: 0x19F4180 VA: 0x1819F5B80
	internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x19F4FD0 Offset: 0x19F35D0 VA: 0x1819F4FD0
	public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments) { }

	// RVA: 0x19F1AD0 Offset: 0x19F00D0 VA: 0x1819F1AD0
	internal static MethodInfo GetInvokeMethod(Expression expression) { }

	// RVA: 0x19F6E70 Offset: 0x19F5470 VA: 0x1819F6E70
	public static LabelExpression Label(LabelTarget target) { }

	// RVA: 0x19F6DA0 Offset: 0x19F53A0 VA: 0x1819F6DA0
	public static LabelExpression Label(LabelTarget target, Expression defaultValue) { }

	// RVA: 0x19F6F70 Offset: 0x19F5570 VA: 0x1819F6F70
	public static LabelTarget Label() { }

	// RVA: 0x19F6D20 Offset: 0x19F5320 VA: 0x1819F6D20
	public static LabelTarget Label(string name) { }

	// RVA: 0x19F70B0 Offset: 0x19F56B0 VA: 0x1819F70B0
	public static LabelTarget Label(Type type) { }

	// RVA: 0x19F6FF0 Offset: 0x19F55F0 VA: 0x1819F6FF0
	public static LabelTarget Label(Type type, string name) { }

	// RVA: 0x19EFA60 Offset: 0x19EE060 VA: 0x1819EFA60
	internal static LambdaExpression CreateLambda(Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FBDE0 Offset: 0x6FA3E0 VA: 0x1806FBDE0
	|-Expression.Lambda<object>
	|
	|-RVA: 0x6FBAD0 Offset: 0x6FA0D0 VA: 0x1806FBAD0
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FBEA0 Offset: 0x6FA4A0 VA: 0x1806FBEA0
	|-Expression.Lambda<object>
	|
	|-RVA: 0x6FBB50 Offset: 0x6FA150 VA: 0x1806FBB50
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FBF20 Offset: 0x6FA520 VA: 0x1806FBF20
	|-Expression.Lambda<object>
	|
	|-RVA: 0x6FBBD0 Offset: 0x6FA1D0 VA: 0x1806FBBD0
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FBC60 Offset: 0x6FA260 VA: 0x1806FBC60
	|-Expression.Lambda<object>
	|-Expression.Lambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19F7100 Offset: 0x19F5700 VA: 0x1819F7100
	public static LambdaExpression Lambda(Type delegateType, Expression body, ParameterExpression[] parameters) { }

	// RVA: 0x19F7200 Offset: 0x19F5800 VA: 0x1819F7200
	public static LambdaExpression Lambda(Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x1A02A00 Offset: 0x1A01000 VA: 0x181A02A00
	private static void ValidateLambdaArgs(Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) { }

	// RVA: 0x19F7A00 Offset: 0x19F6000 VA: 0x1819F7A00
	public static LoopExpression Loop(Expression body, LabelTarget break, LabelTarget continue) { }

	// RVA: 0x19F0F90 Offset: 0x19EF590 VA: 0x1819F0F90
	public static MemberExpression Field(Expression expression, FieldInfo field) { }

	// RVA: 0x19F0E10 Offset: 0x19EF410 VA: 0x1819F0E10
	public static MemberExpression Field(Expression expression, string fieldName) { }

	// RVA: 0x19FE9B0 Offset: 0x19FCFB0 VA: 0x1819FE9B0
	public static MemberExpression Property(Expression expression, string propertyName) { }

	// RVA: 0x19FE640 Offset: 0x19FCC40 VA: 0x1819FE640
	public static MemberExpression Property(Expression expression, PropertyInfo property) { }

	// RVA: 0x19F32D0 Offset: 0x19F18D0 VA: 0x1819F32D0
	private static PropertyInfo GetProperty(MethodInfo mi, string paramName, int index = -1) { }

	// RVA: 0x19EE6F0 Offset: 0x19ECCF0 VA: 0x1819EE6F0
	private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod) { }

	// RVA: 0x19F8F50 Offset: 0x19F7550 VA: 0x1819F8F50
	public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) { }

	// RVA: 0x19EDC00 Offset: 0x19EC200 VA: 0x1819EDC00
	internal static MethodCallExpression Call(MethodInfo method) { }

	// RVA: 0x19EDF70 Offset: 0x19EC570 VA: 0x1819EDF70
	public static MethodCallExpression Call(MethodInfo method, Expression arg0) { }

	// RVA: 0x19EE0C0 Offset: 0x19EC6C0 VA: 0x1819EE0C0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x19ED0E0 Offset: 0x19EB6E0 VA: 0x1819ED0E0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x19EDCC0 Offset: 0x19EC2C0 VA: 0x1819EDCC0
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x19ED540 Offset: 0x19EBB40 VA: 0x1819ED540
	public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x19EE290 Offset: 0x19EC890 VA: 0x1819EE290
	public static MethodCallExpression Call(MethodInfo method, Expression[] arguments) { }

	// RVA: 0x19EE690 Offset: 0x19ECC90 VA: 0x1819EE690
	public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x19EDAF0 Offset: 0x19EC0F0 VA: 0x1819EDAF0
	public static MethodCallExpression Call(Expression instance, MethodInfo method) { }

	// RVA: 0x19EE320 Offset: 0x19EC920 VA: 0x1819EE320
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression[] arguments) { }

	// RVA: 0x19EE390 Offset: 0x19EC990 VA: 0x1819EE390
	internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) { }

	// RVA: 0x19ED320 Offset: 0x19EB920 VA: 0x1819ED320
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x19ED860 Offset: 0x19EBE60 VA: 0x1819ED860
	public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x19EE530 Offset: 0x19ECB30 VA: 0x1819EE530
	public static MethodCallExpression Call(Expression instance, string methodName, Type[] typeArguments, Expression[] arguments) { }

	// RVA: 0x19EC940 Offset: 0x19EAF40 VA: 0x1819EC940
	public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) { }

	// RVA: 0x1A03110 Offset: 0x1A01710 VA: 0x181A03110
	private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) { }

	// RVA: 0x1A04280 Offset: 0x1A02880 VA: 0x181A04280
	private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) { }

	// RVA: 0x1A01D00 Offset: 0x1A00300 VA: 0x181A01D00
	private static void ValidateCallInstanceType(Type instanceType, MethodInfo method) { }

	// RVA: 0x1A01CF0 Offset: 0x1A002F0 VA: 0x181A01CF0
	private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) { }

	// RVA: 0x19F32C0 Offset: 0x19F18C0 VA: 0x1819F32C0
	private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) { }

	// RVA: 0x1A01CE0 Offset: 0x1A002E0 VA: 0x181A01CE0
	private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) { }

	// RVA: 0x1A03CE0 Offset: 0x1A022E0 VA: 0x181A03CE0
	private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) { }

	// RVA: 0x1A007D0 Offset: 0x19FEDD0 VA: 0x181A007D0
	private static bool TryQuote(Type parameterType, ref Expression argument) { }

	// RVA: 0x19F1190 Offset: 0x19EF790 VA: 0x1819F1190
	private static MethodInfo FindMethod(Type type, string methodName, Type[] typeArgs, Expression[] args, BindingFlags flags) { }

	// RVA: 0x19F62A0 Offset: 0x19F48A0 VA: 0x1819F62A0
	private static bool IsCompatible(MethodBase m, Expression[] arguments) { }

	// RVA: 0x19EAE30 Offset: 0x19E9430 VA: 0x1819EAE30
	private static MethodInfo ApplyTypeArgs(MethodInfo m, Type[] typeArgs) { }

	// RVA: 0x19FC4B0 Offset: 0x19FAAB0 VA: 0x1819FC4B0
	public static NewArrayExpression NewArrayInit(Type type, Expression[] initializers) { }

	// RVA: 0x19FC080 Offset: 0x19FA680 VA: 0x1819FC080
	public static NewArrayExpression NewArrayInit(Type type, IEnumerable<Expression> initializers) { }

	// RVA: 0x19FBDC0 Offset: 0x19FA3C0 VA: 0x1819FBDC0
	public static NewArrayExpression NewArrayBounds(Type type, IEnumerable<Expression> bounds) { }

	// RVA: 0x19FC770 Offset: 0x19FAD70 VA: 0x1819FC770
	public static NewExpression New(ConstructorInfo constructor) { }

	// RVA: 0x19FC710 Offset: 0x19FAD10 VA: 0x1819FC710
	public static NewExpression New(ConstructorInfo constructor, Expression[] arguments) { }

	// RVA: 0x19FCB30 Offset: 0x19FB130 VA: 0x1819FCB30
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments) { }

	// RVA: 0x19FC510 Offset: 0x19FAB10 VA: 0x1819FC510
	public static NewExpression New(ConstructorInfo constructor, IEnumerable<Expression> arguments, IEnumerable<MemberInfo> members) { }

	// RVA: 0x19FC7C0 Offset: 0x19FADC0 VA: 0x1819FC7C0
	public static NewExpression New(Type type) { }

	// RVA: 0x1A03360 Offset: 0x1A01960 VA: 0x181A03360
	private static void ValidateNewArgs(ConstructorInfo constructor, ref ReadOnlyCollection<Expression> arguments, ref ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x1A015F0 Offset: 0x19FFBF0 VA: 0x181A015F0
	private static void ValidateAnonymousTypeMember(ref MemberInfo member, out Type memberType, string paramName, int index) { }

	// RVA: 0x1A01F50 Offset: 0x1A00550 VA: 0x181A01F50
	private static void ValidateConstructor(ConstructorInfo constructor, string paramName) { }

	// RVA: 0x19FDD50 Offset: 0x19FC350 VA: 0x1819FDD50
	public static ParameterExpression Parameter(Type type) { }

	// RVA: 0x1A054C0 Offset: 0x1A03AC0 VA: 0x181A054C0
	public static ParameterExpression Variable(Type type) { }

	// RVA: 0x19FDE20 Offset: 0x19FC420 VA: 0x1819FDE20
	public static ParameterExpression Parameter(Type type, string name) { }

	// RVA: 0x1A05550 Offset: 0x1A03B50 VA: 0x181A05550
	public static ParameterExpression Variable(Type type, string name) { }

	// RVA: 0x1A053C0 Offset: 0x1A039C0 VA: 0x181A053C0
	private static void Validate(Type type, bool allowByRef) { }

	// RVA: 0x1A00760 Offset: 0x19FED60 VA: 0x181A00760
	public static TryExpression TryFinally(Expression body, Expression finally) { }

	// RVA: 0x19F98A0 Offset: 0x19F7EA0 VA: 0x1819F98A0
	public static TryExpression MakeTry(Type type, Expression body, Expression finally, Expression fault, IEnumerable<CatchBlock> handlers) { }

	// RVA: 0x1A04380 Offset: 0x1A02980 VA: 0x181A04380
	private static void ValidateTryAndCatchHaveSameType(Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) { }

	// RVA: 0x1A00A30 Offset: 0x19FF030 VA: 0x181A00A30
	public static TypeBinaryExpression TypeIs(Expression expression, Type type) { }

	// RVA: 0x1A00930 Offset: 0x19FEF30 VA: 0x181A00930
	public static TypeBinaryExpression TypeEqual(Expression expression, Type type) { }

	// RVA: 0x19F9AF0 Offset: 0x19F80F0 VA: 0x1819F9AF0
	public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, Type type, MethodInfo method) { }

	// RVA: 0x19F44F0 Offset: 0x19F2AF0 VA: 0x1819F44F0
	private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x19F4690 Offset: 0x19F2C90 VA: 0x1819F4690
	private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) { }

	// RVA: 0x19F2A40 Offset: 0x19F1040 VA: 0x1819F2A40
	private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) { }

	// RVA: 0x19F4280 Offset: 0x19F2880 VA: 0x1819F4280
	private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x19F43F0 Offset: 0x19F29F0 VA: 0x1819F43F0
	private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, Type convertToType) { }

	// RVA: 0x19F2630 Offset: 0x19F0C30 VA: 0x1819F2630
	private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, Type convertToType, MethodInfo method) { }

	// RVA: 0x19FBBF0 Offset: 0x19FA1F0 VA: 0x1819FBBF0
	public static UnaryExpression Negate(Expression expression, MethodInfo method) { }

	// RVA: 0x1A00B30 Offset: 0x19FF130 VA: 0x181A00B30
	public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) { }

	// RVA: 0x19FBA20 Offset: 0x19FA020 VA: 0x1819FBA20
	public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) { }

	// RVA: 0x19FCE90 Offset: 0x19FB490 VA: 0x1819FCE90
	public static UnaryExpression Not(Expression expression) { }

	// RVA: 0x19FCEE0 Offset: 0x19FB4E0 VA: 0x1819FCEE0
	public static UnaryExpression Not(Expression expression, MethodInfo method) { }

	// RVA: 0x19F64D0 Offset: 0x19F4AD0 VA: 0x1819F64D0
	public static UnaryExpression IsFalse(Expression expression, MethodInfo method) { }

	// RVA: 0x19F6A80 Offset: 0x19F5080 VA: 0x1819F6A80
	public static UnaryExpression IsTrue(Expression expression, MethodInfo method) { }

	// RVA: 0x19FD0B0 Offset: 0x19FB6B0 VA: 0x1819FD0B0
	public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) { }

	// RVA: 0x1A007E0 Offset: 0x19FEDE0 VA: 0x181A007E0
	public static UnaryExpression TypeAs(Expression expression, Type type) { }

	// RVA: 0x1A00CC0 Offset: 0x19FF2C0 VA: 0x181A00CC0
	public static UnaryExpression Unbox(Expression expression, Type type) { }

	// RVA: 0x19EFA00 Offset: 0x19EE000 VA: 0x1819EFA00
	public static UnaryExpression Convert(Expression expression, Type type) { }

	// RVA: 0x19EF7F0 Offset: 0x19EDDF0 VA: 0x1819EF7F0
	public static UnaryExpression Convert(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x19EF5C0 Offset: 0x19EDBC0 VA: 0x1819EF5C0
	public static UnaryExpression ConvertChecked(Expression expression, Type type, MethodInfo method) { }

	// RVA: 0x19EB540 Offset: 0x19E9B40 VA: 0x1819EB540
	public static UnaryExpression ArrayLength(Expression array) { }

	// RVA: 0x19FEC60 Offset: 0x19FD260 VA: 0x1819FEC60
	public static UnaryExpression Quote(Expression expression) { }

	// RVA: 0x1A00600 Offset: 0x19FEC00 VA: 0x181A00600
	public static UnaryExpression Throw(Expression value, Type type) { }

	// RVA: 0x19F4E40 Offset: 0x19F3440 VA: 0x1819F4E40
	public static UnaryExpression Increment(Expression expression, MethodInfo method) { }

	// RVA: 0x19EFFC0 Offset: 0x19EE5C0 VA: 0x1819EFFC0
	public static UnaryExpression Decrement(Expression expression, MethodInfo method) { }

	// RVA: 0x19FE5E0 Offset: 0x19FCBE0 VA: 0x1819FE5E0
	public static UnaryExpression PreIncrementAssign(Expression expression) { }

	// RVA: 0x19FE580 Offset: 0x19FCB80 VA: 0x1819FE580
	public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x19FE520 Offset: 0x19FCB20 VA: 0x1819FE520
	public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x19FDF30 Offset: 0x19FC530 VA: 0x1819FDF30
	public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x19FDED0 Offset: 0x19FC4D0 VA: 0x1819FDED0
	public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) { }

	// RVA: 0x19F95F0 Offset: 0x19F7BF0 VA: 0x1819F95F0
	private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) { }

	// RVA: 0x1A05960 Offset: 0x1A03F60 VA: 0x181A05960
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.BlockExpressionProxy))]
public class BlockExpression : Expression // TypeDefIndex: 10789
{
	// Properties
	public ReadOnlyCollection<Expression> Expressions { get; }
	public ReadOnlyCollection<ParameterExpression> Variables { get; }
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	[ExcludeFromCodeCoverage]
	internal virtual int ExpressionCount { get; }

	// Methods

	// RVA: 0x1A0A860 Offset: 0x1A08E60 VA: 0x181A0A860
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x14B0290 Offset: 0x14AE890 VA: 0x1814B0290
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	// RVA: 0x1A0A7E0 Offset: 0x1A08DE0 VA: 0x181A0A7E0
	internal void .ctor() { }

	// RVA: 0x1A0A570 Offset: 0x1A08B70 VA: 0x181A0A570 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A0A880 Offset: 0x1A08E80 VA: 0x181A0A880 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1A0A890 Offset: 0x1A08E90 VA: 0x181A0A890 Slot: 5
	public override Type get_Type() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A0A5A0 Offset: 0x1A08BA0 VA: 0x181A0A5A0 Slot: 10
	internal virtual Expression GetExpression(int index) { }

	// RVA: 0x1A0A830 Offset: 0x1A08E30 VA: 0x181A0A830 Slot: 11
	internal virtual int get_ExpressionCount() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A0A5D0 Offset: 0x1A08BD0 VA: 0x181A0A5D0 Slot: 12
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1A0A600 Offset: 0x1A08C00 VA: 0x181A0A600 Slot: 13
	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A0A7B0 Offset: 0x1A08DB0 VA: 0x181A0A7B0 Slot: 14
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

	// RVA: 0x1A0A650 Offset: 0x1A08C50 VA: 0x181A0A650
	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }
}

// Namespace: System.Linq.Expressions
internal sealed class Block2 : BlockExpression // TypeDefIndex: 10790
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1A09750 Offset: 0x1A07D50 VA: 0x181A09750
	internal void .ctor(Expression arg0, Expression arg1) { }

	// RVA: 0x1A095D0 Offset: 0x1A07BD0 VA: 0x181A095D0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1A09660 Offset: 0x1A07C60 VA: 0x181A09660 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1A09670 Offset: 0x1A07C70 VA: 0x181A09670 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class Block3 : BlockExpression // TypeDefIndex: 10791
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1A099A0 Offset: 0x1A07FA0 VA: 0x181A099A0
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1A097E0 Offset: 0x1A07DE0 VA: 0x181A097E0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1A09660 Offset: 0x1A07C60 VA: 0x181A09660 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1A09890 Offset: 0x1A07E90 VA: 0x181A09890 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class Block4 : BlockExpression // TypeDefIndex: 10792
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1A09C30 Offset: 0x1A08230 VA: 0x181A09C30
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1A09A40 Offset: 0x1A08040 VA: 0x181A09A40 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1A09660 Offset: 0x1A07C60 VA: 0x181A09660 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1A09B00 Offset: 0x1A08100 VA: 0x181A09B00 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class Block5 : BlockExpression // TypeDefIndex: 10793
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28
	private readonly Expression _arg4; // 0x30

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1A09F20 Offset: 0x1A08520 VA: 0x181A09F20
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1A09CF0 Offset: 0x1A082F0 VA: 0x181A09CF0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1A09660 Offset: 0x1A07C60 VA: 0x181A09660 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1A09DC0 Offset: 0x1A083C0 VA: 0x181A09DC0 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal class BlockN : BlockExpression // TypeDefIndex: 10794
{
	// Fields
	private IReadOnlyList<Expression> _expressions; // 0x10

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1A0AA30 Offset: 0x1A09030 VA: 0x181A0AA30
	internal void .ctor(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x1A0A8F0 Offset: 0x1A08EF0 VA: 0x181A0A8F0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x1A0AAA0 Offset: 0x1A090A0 VA: 0x181A0AAA0 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1A0A950 Offset: 0x1A08F50 VA: 0x181A0A950 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1A0A990 Offset: 0x1A08F90 VA: 0x181A0A990 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal class ScopeExpression : BlockExpression // TypeDefIndex: 10795
{
	// Fields
	private IReadOnlyList<ParameterExpression> _variables; // 0x10

	// Properties
	protected IReadOnlyList<ParameterExpression> VariablesList { get; }

	// Methods

	// RVA: 0x1A0AA30 Offset: 0x1A09030 VA: 0x181A0AA30
	internal void .ctor(IReadOnlyList<ParameterExpression> variables) { }

	// RVA: 0x1A20760 Offset: 0x1A1ED60 VA: 0x181A20760 Slot: 13
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	protected IReadOnlyList<ParameterExpression> get_VariablesList() { }

	// RVA: 0x1A207A0 Offset: 0x1A1EDA0 VA: 0x181A207A0
	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) { }
}

// Namespace: System.Linq.Expressions
internal sealed class Scope1 : ScopeExpression // TypeDefIndex: 10796
{
	// Fields
	private object _body; // 0x18

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1A20750 Offset: 0x1A1ED50 VA: 0x181A20750
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, Expression body) { }

	// RVA: 0x1A09750 Offset: 0x1A07D50 VA: 0x181A09750
	private void .ctor(IReadOnlyList<ParameterExpression> variables, object body) { }

	// RVA: 0x1A20590 Offset: 0x1A1EB90 VA: 0x181A20590 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1A20610 Offset: 0x1A1EC10 VA: 0x181A20610 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1A20620 Offset: 0x1A1EC20 VA: 0x181A20620 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal class ScopeN : ScopeExpression // TypeDefIndex: 10797
{
	// Fields
	private IReadOnlyList<Expression> _body; // 0x18

	// Properties
	protected IReadOnlyList<Expression> Body { get; }
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x1A09750 Offset: 0x1A07D50 VA: 0x181A09750
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	protected IReadOnlyList<Expression> get_Body() { }

	// RVA: 0x1A20830 Offset: 0x1A1EE30 VA: 0x181A20830 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x1A20A20 Offset: 0x1A1F020 VA: 0x181A20A20 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x1A20890 Offset: 0x1A1EE90 VA: 0x181A20890 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x1A208D0 Offset: 0x1A1EED0 VA: 0x181A208D0 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class ScopeWithType : ScopeN // TypeDefIndex: 10798
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1A20BC0 Offset: 0x1A1F1C0 VA: 0x181A20BC0
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> expressions, Type type) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1A20A70 Offset: 0x1A1F070 VA: 0x181A20A70 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}

// Namespace: System.Linq.Expressions
[DefaultMember("Item")]
internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable // TypeDefIndex: 10800
{
	// Fields
	private readonly BlockExpression _block; // 0x10
	private readonly Expression _arg0; // 0x18

	// Properties
	public Expression Item { get; set; }
	public int Count { get; }
	[ExcludeFromCodeCoverage]
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	internal void .ctor(BlockExpression provider, Expression arg0) { }

	// RVA: 0x1A0A390 Offset: 0x1A08990 VA: 0x181A0A390 Slot: 6
	public int IndexOf(Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A0A440 Offset: 0x1A08A40 VA: 0x181A0A440 Slot: 7
	public void Insert(int index, Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A0A470 Offset: 0x1A08A70 VA: 0x181A0A470 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x1A0A500 Offset: 0x1A08B00 VA: 0x181A0A500 Slot: 4
	public Expression get_Item(int index) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A0A540 Offset: 0x1A08B40 VA: 0x181A0A540 Slot: 5
	public void set_Item(int index, Expression value) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A09FF0 Offset: 0x1A085F0 VA: 0x181A09FF0 Slot: 11
	public void Add(Expression item) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A0A020 Offset: 0x1A08620 VA: 0x181A0A020 Slot: 12
	public void Clear() { }

	// RVA: 0x1A0A050 Offset: 0x1A08650 VA: 0x181A0A050 Slot: 13
	public bool Contains(Expression item) { }

	// RVA: 0x1A0A100 Offset: 0x1A08700 VA: 0x181A0A100 Slot: 14
	public void CopyTo(Expression[] array, int index) { }

	// RVA: 0x140B760 Offset: 0x1409D60 VA: 0x18140B760 Slot: 9
	public int get_Count() { }

	// RVA: 0x1A0A4D0 Offset: 0x1A08AD0 VA: 0x181A0A4D0 Slot: 10
	public bool get_IsReadOnly() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A0A4A0 Offset: 0x1A08AA0 VA: 0x181A0A4A0 Slot: 15
	public bool Remove(Expression item) { }

	[IteratorStateMachine(typeof(BlockExpressionList.<GetEnumerator>d__18))]
	// RVA: 0x1A0A320 Offset: 0x1A08920 VA: 0x181A0A320 Slot: 16
	public IEnumerator<Expression> GetEnumerator() { }

	// RVA: 0x1A0A320 Offset: 0x1A08920 VA: 0x181A0A320 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.CatchBlockProxy))]
public sealed class CatchBlock // TypeDefIndex: 10801
{
	// Fields
	[CompilerGenerated]
	private readonly ParameterExpression <Variable>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <Test>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Expression <Filter>k__BackingField; // 0x28

	// Properties
	public ParameterExpression Variable { get; }
	public Type Test { get; }
	public Expression Body { get; }
	public Expression Filter { get; }

	// Methods

	// RVA: 0x1A0C530 Offset: 0x1A0AB30 VA: 0x181A0C530
	internal void .ctor(Type test, ParameterExpression variable, Expression body, Expression filter) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ParameterExpression get_Variable() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Type get_Test() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Expression get_Filter() { }

	// RVA: 0x1A0C3C0 Offset: 0x1A0A9C0 VA: 0x181A0C3C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A0C490 Offset: 0x1A0AA90 VA: 0x181A0C490
	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) { }
}

// Namespace: System.Linq.Expressions
[Extension]
internal static class ArrayBuilderExtensions // TypeDefIndex: 10802
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> ToReadOnly<T>(ArrayBuilder<T> builder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6377C0 Offset: 0x635DC0 VA: 0x1806377C0
	|-ArrayBuilderExtensions.ToReadOnly<object>
	|
	|-RVA: 0x637730 Offset: 0x635D30 VA: 0x180637730
	|-ArrayBuilderExtensions.ToReadOnly<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Linq.Expressions
internal enum AnalyzeTypeIsResult // TypeDefIndex: 10803
{
	// Fields
	public int value__; // 0x0
	public const AnalyzeTypeIsResult KnownFalse = 0;
	public const AnalyzeTypeIsResult KnownTrue = 1;
	public const AnalyzeTypeIsResult KnownAssignable = 2;
	public const AnalyzeTypeIsResult Unknown = 3;
}

// Namespace: System.Linq.Expressions
internal static class ConstantCheck // TypeDefIndex: 10804
{
	// Methods

	// RVA: 0x1A0CAC0 Offset: 0x1A0B0C0 VA: 0x181A0CAC0
	internal static AnalyzeTypeIsResult AnalyzeTypeIs(TypeBinaryExpression typeIs) { }

	// RVA: 0x1A0CAF0 Offset: 0x1A0B0F0 VA: 0x181A0CAF0
	private static AnalyzeTypeIsResult AnalyzeTypeIs(Expression operand, Type testType) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ConditionalExpressionProxy))]
public class ConditionalExpression : Expression // TypeDefIndex: 10805
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Test>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <IfTrue>k__BackingField; // 0x18

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	public Expression Test { get; }
	public Expression IfTrue { get; }
	public Expression IfFalse { get; }

	// Methods

	// RVA: 0x1A0CA30 Offset: 0x1A0B030 VA: 0x181A0CA30
	internal void .ctor(Expression test, Expression ifTrue) { }

	// RVA: 0x1A0C740 Offset: 0x1A0AD40 VA: 0x181A0C740
	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x44F6B0 Offset: 0x44DCB0 VA: 0x18044F6B0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x197A8C0 Offset: 0x1978EC0 VA: 0x18197A8C0 Slot: 5
	public override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Expression get_Test() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Expression get_IfTrue() { }

	// RVA: 0x14438C0 Offset: 0x1441EC0 VA: 0x1814438C0
	public Expression get_IfFalse() { }

	// RVA: 0x1A0C6E0 Offset: 0x1A0ACE0 VA: 0x181A0C6E0 Slot: 10
	internal virtual Expression GetFalse() { }

	// RVA: 0x1A0C6B0 Offset: 0x1A0ACB0 VA: 0x181A0C6B0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A0C960 Offset: 0x1A0AF60 VA: 0x181A0C960
	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) { }
}

// Namespace: System.Linq.Expressions
internal class FullConditionalExpression : ConditionalExpression // TypeDefIndex: 10806
{
	// Fields
	private readonly Expression _false; // 0x20

	// Methods

	// RVA: 0x1A1AF30 Offset: 0x1A19530 VA: 0x181A1AF30
	internal void .ctor(Expression test, Expression ifTrue, Expression ifFalse) { }

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0 Slot: 10
	internal override Expression GetFalse() { }
}

// Namespace: System.Linq.Expressions
internal sealed class FullConditionalExpressionWithType : FullConditionalExpression // TypeDefIndex: 10807
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1A1AEE0 Offset: 0x1A194E0 VA: 0x181A1AEE0
	internal void .ctor(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ConstantExpressionProxy))]
public class ConstantExpression : Expression // TypeDefIndex: 10808
{
	// Fields
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x10

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1A0CD30 Offset: 0x1A0B330 VA: 0x181A0CD30
	internal void .ctor(object value) { }

	// RVA: 0x1A0CDA0 Offset: 0x1A0B3A0 VA: 0x181A0CDA0 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x458E50 Offset: 0x457450 VA: 0x180458E50 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public object get_Value() { }

	// RVA: 0x1A0CD00 Offset: 0x1A0B300 VA: 0x181A0CD00 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}

// Namespace: System.Linq.Expressions
internal class TypedConstantExpression : ConstantExpression // TypeDefIndex: 10809
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1A23810 Offset: 0x1A21E10 VA: 0x181A23810
	internal void .ctor(object value, Type type) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.DebugInfoExpressionProxy))]
public class DebugInfoExpression : Expression // TypeDefIndex: 10810
{
	// Fields
	[CompilerGenerated]
	private readonly SymbolDocumentInfo <Document>k__BackingField; // 0x10

	// Properties
	[ExcludeFromCodeCoverage]
	public virtual int StartLine { get; }
	[ExcludeFromCodeCoverage]
	public virtual int EndLine { get; }
	public SymbolDocumentInfo Document { get; }
	[ExcludeFromCodeCoverage]
	public virtual bool IsClear { get; }

	// Methods

	// RVA: 0x1A0CF10 Offset: 0x1A0B510 VA: 0x181A0CF10 Slot: 10
	public virtual int get_StartLine() { }

	// RVA: 0x1A0CEB0 Offset: 0x1A0B4B0 VA: 0x181A0CEB0 Slot: 11
	public virtual int get_EndLine() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public SymbolDocumentInfo get_Document() { }

	// RVA: 0x1A0CEE0 Offset: 0x1A0B4E0 VA: 0x181A0CEE0 Slot: 12
	public virtual bool get_IsClear() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.DefaultExpressionProxy))]
public sealed class DefaultExpression : Expression // TypeDefIndex: 10811
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x1A0D860 Offset: 0x1A0BE60 VA: 0x181A0D860
	internal void .ctor(Type type) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1A0D8D0 Offset: 0x1A0BED0 VA: 0x181A0D8D0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1A0D830 Offset: 0x1A0BE30 VA: 0x181A0D830 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}

// Namespace: System.Linq.Expressions
public sealed class ElementInit : IArgumentProvider // TypeDefIndex: 10812
{
	// Fields
	[CompilerGenerated]
	private readonly MethodInfo <AddMethod>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <Arguments>k__BackingField; // 0x18

	// Properties
	public MethodInfo AddMethod { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	public int ArgumentCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public MethodInfo get_AddMethod() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1A0E950 Offset: 0x1A0CF50 VA: 0x181A0E950 Slot: 4
	public Expression GetArgument(int index) { }

	// RVA: 0x1A0E9B0 Offset: 0x1A0CFB0 VA: 0x181A0E9B0 Slot: 5
	public int get_ArgumentCount() { }
}

// Namespace: System.Linq.Expressions
internal static class Error // TypeDefIndex: 10813
{
	// Methods

	// RVA: 0x1A15F00 Offset: 0x1A14500 VA: 0x181A15F00
	internal static Exception ReducibleMustOverrideReduce() { }

	// RVA: 0x1A144B0 Offset: 0x1A12AB0 VA: 0x181A144B0
	internal static Exception InvalidMetaObjectCreated(object p0) { }

	// RVA: 0x1A119A0 Offset: 0x1A0FFA0 VA: 0x181A119A0
	internal static Exception AmbiguousMatchInExpandoObject(object p0) { }

	// RVA: 0x1A16090 Offset: 0x1A14690 VA: 0x181A16090
	internal static Exception SameKeyExistsInExpando(object key) { }

	// RVA: 0x1A14790 Offset: 0x1A12D90 VA: 0x181A14790
	internal static Exception KeyDoesNotExistInExpando(object p0) { }

	// RVA: 0x1A12990 Offset: 0x1A10F90 VA: 0x181A12990
	internal static Exception CollectionModifiedWhileEnumerating() { }

	// RVA: 0x1A12A10 Offset: 0x1A11010 VA: 0x181A12A10
	internal static Exception CollectionReadOnly() { }

	// RVA: 0x1A15050 Offset: 0x1A13650 VA: 0x181A15050
	internal static Exception MustReduceToDifferent() { }

	// RVA: 0x1A12520 Offset: 0x1A10B20 VA: 0x181A12520
	internal static Exception BinderNotCompatibleWithCallSite(object p0, object p1, object p2) { }

	// RVA: 0x1A12F10 Offset: 0x1A11510 VA: 0x181A12F10
	internal static Exception DynamicBindingNeedsRestrictions(object p0, object p1) { }

	// RVA: 0x1A12FA0 Offset: 0x1A115A0 VA: 0x181A12FA0
	internal static Exception DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3) { }

	// RVA: 0x1A12E60 Offset: 0x1A11460 VA: 0x181A12E60
	internal static Exception DynamicBinderResultNotAssignable(object p0, object p1, object p2) { }

	// RVA: 0x1A125D0 Offset: 0x1A10BD0 VA: 0x181A125D0
	internal static Exception BindingCannotBeNull() { }

	// RVA: 0x1A15E80 Offset: 0x1A14480 VA: 0x181A15E80
	internal static Exception ReducedNotCompatible() { }

	// RVA: 0x1A16130 Offset: 0x1A14730 VA: 0x181A16130
	internal static Exception SetterHasNoParams(string paramName) { }

	// RVA: 0x1A15920 Offset: 0x1A13F20 VA: 0x181A15920
	internal static Exception PropertyCannotHaveRefType(string paramName) { }

	// RVA: 0x1A14100 Offset: 0x1A12700 VA: 0x181A14100
	internal static Exception IndexesOfSetGetMustMatch(string paramName) { }

	// RVA: 0x1A167B0 Offset: 0x1A14DB0 VA: 0x181A167B0
	internal static Exception TypeParameterIsNotDelegate(object p0) { }

	// RVA: 0x1A13B30 Offset: 0x1A12130 VA: 0x181A13B30
	internal static Exception FirstArgumentMustBeCallSite() { }

	// RVA: 0x1A11880 Offset: 0x1A0FE80 VA: 0x181A11880
	internal static Exception AccessorsCannotHaveVarArgs(string paramName) { }

	// RVA: 0x1A117F0 Offset: 0x1A0FDF0 VA: 0x181A117F0
	private static Exception AccessorsCannotHaveByRefArgs(string paramName) { }

	// RVA: 0x1A11760 Offset: 0x1A0FD60 VA: 0x181A11760
	internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) { }

	// RVA: 0x1A16610 Offset: 0x1A14C10 VA: 0x181A16610
	internal static Exception TypeMustBeDerivedFromSystemDelegate() { }

	// RVA: 0x1A152C0 Offset: 0x1A138C0 VA: 0x181A152C0
	internal static Exception NoOrInvalidRuleProduced() { }

	// RVA: 0x1A12760 Offset: 0x1A10D60 VA: 0x181A12760
	internal static Exception BoundsCannotBeLessThanOne(string paramName) { }

	// RVA: 0x1A16690 Offset: 0x1A14C90 VA: 0x181A16690
	internal static Exception TypeMustNotBeByRef(string paramName) { }

	// RVA: 0x1A16720 Offset: 0x1A14D20 VA: 0x181A16720
	internal static Exception TypeMustNotBePointer(string paramName) { }

	// RVA: 0x1A161C0 Offset: 0x1A147C0 VA: 0x181A161C0
	internal static Exception SetterMustBeVoid(string paramName) { }

	// RVA: 0x1A15CD0 Offset: 0x1A142D0 VA: 0x181A15CD0
	internal static Exception PropertyTypeMustMatchGetter(string paramName) { }

	// RVA: 0x1A15D60 Offset: 0x1A14360 VA: 0x181A15D60
	internal static Exception PropertyTypeMustMatchSetter(string paramName) { }

	// RVA: 0x1A126D0 Offset: 0x1A10CD0 VA: 0x181A126D0
	internal static Exception BothAccessorsMustBeStatic(string paramName) { }

	// RVA: 0x1A15530 Offset: 0x1A13B30 VA: 0x181A15530
	internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) { }

	// RVA: 0x1A15640 Offset: 0x1A13C40 VA: 0x181A15640
	internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) { }

	// RVA: 0x1A155C0 Offset: 0x1A13BC0 VA: 0x181A155C0
	internal static Exception OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x1A15C40 Offset: 0x1A14240 VA: 0x181A15C40
	internal static Exception PropertyTypeCannotBeVoid(string paramName) { }

	// RVA: 0x1A14700 Offset: 0x1A12D00 VA: 0x181A14700
	internal static Exception InvalidUnboxType(string paramName) { }

	// RVA: 0x1A131D0 Offset: 0x1A117D0 VA: 0x181A131D0
	internal static Exception ExpressionMustBeWriteable(string paramName) { }

	// RVA: 0x1A121B0 Offset: 0x1A107B0 VA: 0x181A121B0
	internal static Exception ArgumentMustNotHaveValueType(string paramName) { }

	// RVA: 0x1A14FD0 Offset: 0x1A135D0 VA: 0x181A14FD0
	internal static Exception MustBeReducible() { }

	// RVA: 0x1A14820 Offset: 0x1A12E20 VA: 0x181A14820
	internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) { }

	// RVA: 0x1A149D0 Offset: 0x1A12FD0 VA: 0x181A149D0
	internal static Exception LabelTypeMustBeVoid(string paramName) { }

	// RVA: 0x1A15DF0 Offset: 0x1A143F0 VA: 0x181A15DF0
	internal static Exception QuotedExpressionMustBeLambda(string paramName) { }

	// RVA: 0x1A16D20 Offset: 0x1A15320 VA: 0x181A16D20
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) { }

	// RVA: 0x1A16C70 Offset: 0x1A15270 VA: 0x181A16C70
	internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1A12D10 Offset: 0x1A11310 VA: 0x181A12D10
	private static Exception DuplicateVariable(object p0, string paramName) { }

	// RVA: 0x1A12DB0 Offset: 0x1A113B0 VA: 0x181A12DB0
	internal static Exception DuplicateVariable(object p0, string paramName, int index) { }

	// RVA: 0x1A139F0 Offset: 0x1A11FF0 VA: 0x181A139F0
	internal static Exception FaultCannotHaveCatchOrFinally(string paramName) { }

	// RVA: 0x1A16250 Offset: 0x1A14850 VA: 0x181A16250
	internal static Exception TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x1A12650 Offset: 0x1A10C50 VA: 0x181A12650
	internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x1A13960 Offset: 0x1A11F60 VA: 0x181A13960
	internal static Exception ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x1A16B30 Offset: 0x1A15130 VA: 0x181A16B30
	internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) { }

	// RVA: 0x1A16BD0 Offset: 0x1A151D0 VA: 0x181A16BD0
	internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) { }

	// RVA: 0x1A12900 Offset: 0x1A10F00 VA: 0x181A12900
	internal static Exception CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x1A16840 Offset: 0x1A14E40 VA: 0x181A16840
	internal static Exception UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x1A12470 Offset: 0x1A10A70 VA: 0x181A12470
	internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x1A15F80 Offset: 0x1A14580 VA: 0x181A15F80
	internal static Exception ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x1A156D0 Offset: 0x1A13CD0 VA: 0x181A156D0
	internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x1A15800 Offset: 0x1A13E00 VA: 0x181A15800
	internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x1A12C90 Offset: 0x1A11290 VA: 0x181A12C90
	internal static Exception ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x1A11CA0 Offset: 0x1A102A0 VA: 0x181A11CA0
	internal static Exception ArgumentMustBeArray(string paramName) { }

	// RVA: 0x1A11D30 Offset: 0x1A10330 VA: 0x181A11D30
	internal static Exception ArgumentMustBeBoolean(string paramName) { }

	// RVA: 0x1A11E50 Offset: 0x1A10450 VA: 0x181A11E50
	private static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName) { }

	// RVA: 0x1A11DC0 Offset: 0x1A103C0 VA: 0x181A11DC0
	internal static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName, int index) { }

	// RVA: 0x1A11F70 Offset: 0x1A10570 VA: 0x181A11F70
	private static Exception ArgumentMustBeInstanceMember(string paramName) { }

	// RVA: 0x1A11EE0 Offset: 0x1A104E0 VA: 0x181A11EE0
	internal static Exception ArgumentMustBeInstanceMember(string paramName, int index) { }

	// RVA: 0x1A12000 Offset: 0x1A10600 VA: 0x181A12000
	private static Exception ArgumentMustBeInteger(string paramName) { }

	// RVA: 0x1A12090 Offset: 0x1A10690 VA: 0x181A12090
	internal static Exception ArgumentMustBeInteger(string paramName, int index) { }

	// RVA: 0x1A11C10 Offset: 0x1A10210 VA: 0x181A11C10
	internal static Exception ArgumentMustBeArrayIndexType(string paramName) { }

	// RVA: 0x1A12120 Offset: 0x1A10720 VA: 0x181A12120
	internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) { }

	// RVA: 0x1A123F0 Offset: 0x1A109F0 VA: 0x181A123F0
	internal static Exception ArgumentTypesMustMatch() { }

	// RVA: 0x1A127F0 Offset: 0x1A10DF0 VA: 0x181A127F0
	internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x1A14060 Offset: 0x1A12660 VA: 0x181A14060
	internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) { }

	// RVA: 0x1A12880 Offset: 0x1A10E80 VA: 0x181A12880
	internal static Exception CoalesceUsedOnNonNullType() { }

	// RVA: 0x1A13260 Offset: 0x1A11860 VA: 0x181A13260
	internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x1A12350 Offset: 0x1A10950 VA: 0x181A12350
	private static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName) { }

	// RVA: 0x1A122A0 Offset: 0x1A108A0 VA: 0x181A122A0
	internal static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1A11B70 Offset: 0x1A10170 VA: 0x181A11B70
	private static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName) { }

	// RVA: 0x1A11AC0 Offset: 0x1A100C0 VA: 0x181A11AC0
	internal static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1A13830 Offset: 0x1A11E30 VA: 0x181A13830
	internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x1A132F0 Offset: 0x1A118F0 VA: 0x181A132F0
	internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x1A134D0 Offset: 0x1A11AD0 VA: 0x181A134D0
	internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x1A138C0 Offset: 0x1A11EC0 VA: 0x181A138C0
	internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) { }

	// RVA: 0x1A14240 Offset: 0x1A12840 VA: 0x181A14240
	internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1A13A80 Offset: 0x1A12080 VA: 0x181A13A80
	internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x1A13DC0 Offset: 0x1A123C0 VA: 0x181A13DC0
	internal static Exception IncorrectNumberOfIndexes() { }

	// RVA: 0x1A13EC0 Offset: 0x1A124C0 VA: 0x181A13EC0
	internal static Exception IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x1A13F40 Offset: 0x1A12540 VA: 0x181A13F40
	internal static Exception IncorrectNumberOfMembersForGivenConstructor() { }

	// RVA: 0x1A13CC0 Offset: 0x1A122C0 VA: 0x181A13CC0
	internal static Exception IncorrectNumberOfArgumentsForMembers() { }

	// RVA: 0x1A14A60 Offset: 0x1A13060 VA: 0x181A14A60
	internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) { }

	// RVA: 0x1A14B80 Offset: 0x1A13180 VA: 0x181A14B80
	internal static Exception MemberNotFieldOrProperty(object p0, string paramName) { }

	// RVA: 0x1A14C20 Offset: 0x1A13220 VA: 0x181A14C20
	internal static Exception MethodContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x1A14CC0 Offset: 0x1A132C0 VA: 0x181A14CC0
	internal static Exception MethodIsGeneric(object p0, string paramName) { }

	// RVA: 0x1A14D60 Offset: 0x1A13360 VA: 0x181A14D60
	private static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName) { }

	// RVA: 0x1A14E00 Offset: 0x1A13400 VA: 0x181A14E00
	internal static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1A15A50 Offset: 0x1A14050 VA: 0x181A15A50
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName) { }

	// RVA: 0x1A15AF0 Offset: 0x1A140F0 VA: 0x181A15AF0
	internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName, int index) { }

	// RVA: 0x1A159B0 Offset: 0x1A13FB0 VA: 0x181A159B0
	internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) { }

	// RVA: 0x1A15890 Offset: 0x1A13E90 VA: 0x181A15890
	internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x1A15BA0 Offset: 0x1A141A0 VA: 0x181A15BA0
	internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x1A142D0 Offset: 0x1A128D0 VA: 0x181A142D0
	internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) { }

	// RVA: 0x1A14190 Offset: 0x1A12790 VA: 0x181A14190
	internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x1A16570 Offset: 0x1A14B70 VA: 0x181A16570
	internal static Exception TypeMissingDefaultConstructor(object p0, string paramName) { }

	// RVA: 0x1A168D0 Offset: 0x1A14ED0 VA: 0x181A168D0
	internal static Exception UnhandledBinary(object p0, string paramName) { }

	// RVA: 0x1A16970 Offset: 0x1A14F70 VA: 0x181A16970
	internal static Exception UnhandledUnary(object p0, string paramName) { }

	// RVA: 0x1A16A10 Offset: 0x1A15010 VA: 0x181A16A10
	internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x1A16AA0 Offset: 0x1A150A0 VA: 0x181A16AA0
	internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x1A14AF0 Offset: 0x1A130F0 VA: 0x181A14AF0
	internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x1A14EB0 Offset: 0x1A134B0 VA: 0x181A14EB0
	internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x1A13BB0 Offset: 0x1A121B0 VA: 0x181A13BB0
	internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x1A14F40 Offset: 0x1A13540 VA: 0x181A14F40
	internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x1A11A30 Offset: 0x1A10030 VA: 0x181A11A30
	internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) { }

	// RVA: 0x1A15760 Offset: 0x1A13D60 VA: 0x181A15760
	internal static Exception OutOfRange(string paramName, object p1) { }

	// RVA: 0x1A148B0 Offset: 0x1A12EB0 VA: 0x181A148B0
	internal static Exception LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x1A14940 Offset: 0x1A12F40 VA: 0x181A14940
	internal static Exception LabelTargetUndefined(object p0) { }

	// RVA: 0x1A12C10 Offset: 0x1A11210 VA: 0x181A12C10
	internal static Exception ControlCannotLeaveFinally() { }

	// RVA: 0x1A12B90 Offset: 0x1A11190 VA: 0x181A12B90
	internal static Exception ControlCannotLeaveFilterTest() { }

	// RVA: 0x1A11910 Offset: 0x1A0FF10 VA: 0x181A11910
	internal static Exception AmbiguousJump(object p0) { }

	// RVA: 0x1A12B10 Offset: 0x1A11110 VA: 0x181A12B10
	internal static Exception ControlCannotEnterTry() { }

	// RVA: 0x1A12A90 Offset: 0x1A11090 VA: 0x181A12A90
	internal static Exception ControlCannotEnterExpression() { }

	// RVA: 0x1A153C0 Offset: 0x1A139C0 VA: 0x181A153C0
	internal static Exception NonLocalJumpWithValue(object p0) { }

	// RVA: 0x1A14400 Offset: 0x1A12A00 VA: 0x181A14400
	internal static Exception InvalidLvalue(ExpressionType p0) { }

	// RVA: 0x1A16010 Offset: 0x1A14610 VA: 0x181A16010
	internal static Exception RethrowRequiresCatch() { }

	// RVA: 0x1A15180 Offset: 0x1A13780 VA: 0x181A15180
	internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x1A150D0 Offset: 0x1A136D0 VA: 0x181A150D0
	internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x1A15230 Offset: 0x1A13830 VA: 0x181A15230
	internal static Exception MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x1A12240 Offset: 0x1A10840 VA: 0x181A12240
	internal static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x1A154E0 Offset: 0x1A13AE0 VA: 0x181A154E0
	internal static Exception NotSupported() { }

	// RVA: 0x1A15450 Offset: 0x1A13A50 VA: 0x181A15450
	internal static Exception NonStaticConstructorRequired(string paramName) { }

	// RVA: 0x1A15340 Offset: 0x1A13940 VA: 0x181A15340
	internal static Exception NonAbstractConstructorRequired() { }

	// RVA: 0x1A145E0 Offset: 0x1A12BE0 VA: 0x181A145E0
	internal static Exception InvalidProgram() { }

	// RVA: 0x1A13030 Offset: 0x1A11630 VA: 0x181A13030
	internal static Exception EnumerationIsDone() { }

	// RVA: 0x1A16380 Offset: 0x1A14980 VA: 0x181A16380
	private static Exception TypeContainsGenericParameters(object p0, string paramName) { }

	// RVA: 0x1A162D0 Offset: 0x1A148D0 VA: 0x181A162D0
	internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) { }

	// RVA: 0x1A16420 Offset: 0x1A14A20 VA: 0x181A16420
	internal static Exception TypeIsGeneric(object p0, string paramName) { }

	// RVA: 0x1A164C0 Offset: 0x1A14AC0 VA: 0x181A164C0
	internal static Exception TypeIsGeneric(object p0, string paramName, int index) { }

	// RVA: 0x1A13D40 Offset: 0x1A12340 VA: 0x181A13D40
	internal static Exception IncorrectNumberOfConstructorArguments() { }

	// RVA: 0x1A13560 Offset: 0x1A11B60 VA: 0x181A13560
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) { }

	// RVA: 0x1A13620 Offset: 0x1A11C20 VA: 0x181A13620
	internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) { }

	// RVA: 0x1A13790 Offset: 0x1A11D90 VA: 0x181A13790
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) { }

	// RVA: 0x1A136E0 Offset: 0x1A11CE0 VA: 0x181A136E0
	internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1A13E40 Offset: 0x1A12440 VA: 0x181A13E40
	internal static Exception IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x1A13FC0 Offset: 0x1A125C0 VA: 0x181A13FC0
	internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) { }

	// RVA: 0x1A13380 Offset: 0x1A11980 VA: 0x181A13380
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) { }

	// RVA: 0x1A13420 Offset: 0x1A11A20 VA: 0x181A13420
	internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) { }

	// RVA: 0x1A130B0 Offset: 0x1A116B0 VA: 0x181A130B0
	internal static Exception ExpressionMustBeReadable(string paramName) { }

	// RVA: 0x1A13140 Offset: 0x1A11740 VA: 0x181A13140
	internal static Exception ExpressionMustBeReadable(string paramName, int index) { }

	// RVA: 0x1A14370 Offset: 0x1A12970 VA: 0x181A14370
	internal static Exception InvalidArgumentValue(string paramName) { }

	// RVA: 0x1A14540 Offset: 0x1A12B40 VA: 0x181A14540
	internal static Exception InvalidNullValue(Type type, string paramName) { }

	// RVA: 0x1A14630 Offset: 0x1A12C30 VA: 0x181A14630
	internal static Exception InvalidTypeException(object value, Type type, string paramName) { }

	// RVA: 0x1A13C40 Offset: 0x1A12240 VA: 0x181A13C40
	private static string GetParamName(string paramName, int index) { }
}

// Namespace: System.Linq.Expressions
internal sealed class ExpressionStringBuilder : ExpressionVisitor // TypeDefIndex: 10814
{
	// Fields
	private readonly StringBuilder _out; // 0x10
	private Dictionary<object, int> _ids; // 0x18

	// Methods

	// RVA: 0x1A195E0 Offset: 0x1A17BE0 VA: 0x181A195E0
	private void .ctor() { }

	// RVA: 0xB98DD0 Offset: 0xB973D0 VA: 0x180B98DD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A17060 Offset: 0x1A15660 VA: 0x181A17060
	private int GetLabelId(LabelTarget label) { }

	// RVA: 0x1A17060 Offset: 0x1A15660 VA: 0x181A17060
	private int GetParamId(ParameterExpression p) { }

	// RVA: 0x1A16F50 Offset: 0x1A15550 VA: 0x181A16F50
	private int GetId(object o) { }

	// RVA: 0x1A17240 Offset: 0x1A15840 VA: 0x181A17240
	private void Out(string s) { }

	// RVA: 0x1A17260 Offset: 0x1A15860 VA: 0x181A17260
	private void Out(char c) { }

	// RVA: 0x1A16E80 Offset: 0x1A15480 VA: 0x181A16E80
	internal static string ExpressionToString(Expression node) { }

	// RVA: 0x1A0C3C0 Offset: 0x1A0A9C0 VA: 0x181A0C3C0
	internal static string CatchBlockToString(CatchBlock node) { }

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FEC80 Offset: 0x6FD280 VA: 0x1806FEC80
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: -1 Offset: -1
	private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FEA30 Offset: 0x6FD030 VA: 0x1806FEA30
	|-ExpressionStringBuilder.VisitExpressions<object>
	*/

	// RVA: 0x1A17280 Offset: 0x1A15880 VA: 0x181A17280 Slot: 5
	protected internal override Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x1A18E50 Offset: 0x1A17450 VA: 0x181A18E50 Slot: 22
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FEEC0 Offset: 0x6FD4C0 VA: 0x1806FEEC0
	|-ExpressionStringBuilder.VisitLambda<object>
	|
	|-RVA: 0x6FED20 Offset: 0x6FD320 VA: 0x1806FED20
	|-ExpressionStringBuilder.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A17C80 Offset: 0x1A16280 VA: 0x181A17C80 Slot: 7
	protected internal override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x1A17DA0 Offset: 0x1A163A0 VA: 0x181A17DA0 Slot: 8
	protected internal override Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x1A17170 Offset: 0x1A15770 VA: 0x181A17170
	private void OutMember(Expression instance, MemberInfo member) { }

	// RVA: 0x1A187E0 Offset: 0x1A16DE0 VA: 0x181A187E0 Slot: 17
	protected internal override Expression VisitMember(MemberExpression node) { }

	// RVA: 0x1A185B0 Offset: 0x1A16BB0 VA: 0x181A185B0 Slot: 12
	protected internal override Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x1A18900 Offset: 0x1A16F00 VA: 0x181A18900 Slot: 19
	protected internal override Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x1A18B00 Offset: 0x1A17100 VA: 0x181A18B00 Slot: 20
	protected internal override Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x1A18C30 Offset: 0x1A17230 VA: 0x181A18C30 Slot: 21
	protected internal override Expression VisitNew(NewExpression node) { }

	// RVA: 0x1A18FB0 Offset: 0x1A175B0 VA: 0x181A18FB0 Slot: 25
	protected internal override Expression VisitTypeBinary(TypeBinaryExpression node) { }

	// RVA: 0x1A190D0 Offset: 0x1A176D0 VA: 0x181A190D0 Slot: 26
	protected internal override Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x1A178A0 Offset: 0x1A15EA0 VA: 0x181A178A0 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1A17F60 Offset: 0x1A16560 VA: 0x181A17F60 Slot: 9
	protected internal override Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x1A186F0 Offset: 0x1A16CF0 VA: 0x181A186F0 Slot: 14
	protected internal override Expression VisitLabel(LabelExpression node) { }

	// RVA: 0x1A18230 Offset: 0x1A16830 VA: 0x181A18230 Slot: 11
	protected internal override Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x1A18780 Offset: 0x1A16D80 VA: 0x181A18780 Slot: 16
	protected internal override Expression VisitLoop(LoopExpression node) { }

	// RVA: 0x1A17B70 Offset: 0x1A16170 VA: 0x181A17B70 Slot: 23
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x1A18F50 Offset: 0x1A17550 VA: 0x181A18F50 Slot: 24
	protected internal override Expression VisitTry(TryExpression node) { }

	// RVA: 0x1A183C0 Offset: 0x1A169C0 VA: 0x181A183C0 Slot: 18
	protected internal override Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x1A18020 Offset: 0x1A16620 VA: 0x181A18020 Slot: 10
	protected internal override Expression VisitExtension(Expression node) { }

	// RVA: 0x1A16DC0 Offset: 0x1A153C0 VA: 0x181A16DC0
	private void DumpLabel(LabelTarget target) { }

	// RVA: 0x1A17070 Offset: 0x1A15670 VA: 0x181A17070
	private static bool IsBool(Expression node) { }
}

// Namespace: System.Linq.Expressions
public enum ExpressionType // TypeDefIndex: 10815
{
	// Fields
	public int value__; // 0x0
	public const ExpressionType Add = 0;
	public const ExpressionType AddChecked = 1;
	public const ExpressionType And = 2;
	public const ExpressionType AndAlso = 3;
	public const ExpressionType ArrayLength = 4;
	public const ExpressionType ArrayIndex = 5;
	public const ExpressionType Call = 6;
	public const ExpressionType Coalesce = 7;
	public const ExpressionType Conditional = 8;
	public const ExpressionType Constant = 9;
	public const ExpressionType Convert = 10;
	public const ExpressionType ConvertChecked = 11;
	public const ExpressionType Divide = 12;
	public const ExpressionType Equal = 13;
	public const ExpressionType ExclusiveOr = 14;
	public const ExpressionType GreaterThan = 15;
	public const ExpressionType GreaterThanOrEqual = 16;
	public const ExpressionType Invoke = 17;
	public const ExpressionType Lambda = 18;
	public const ExpressionType LeftShift = 19;
	public const ExpressionType LessThan = 20;
	public const ExpressionType LessThanOrEqual = 21;
	public const ExpressionType ListInit = 22;
	public const ExpressionType MemberAccess = 23;
	public const ExpressionType MemberInit = 24;
	public const ExpressionType Modulo = 25;
	public const ExpressionType Multiply = 26;
	public const ExpressionType MultiplyChecked = 27;
	public const ExpressionType Negate = 28;
	public const ExpressionType UnaryPlus = 29;
	public const ExpressionType NegateChecked = 30;
	public const ExpressionType New = 31;
	public const ExpressionType NewArrayInit = 32;
	public const ExpressionType NewArrayBounds = 33;
	public const ExpressionType Not = 34;
	public const ExpressionType NotEqual = 35;
	public const ExpressionType Or = 36;
	public const ExpressionType OrElse = 37;
	public const ExpressionType Parameter = 38;
	public const ExpressionType Power = 39;
	public const ExpressionType Quote = 40;
	public const ExpressionType RightShift = 41;
	public const ExpressionType Subtract = 42;
	public const ExpressionType SubtractChecked = 43;
	public const ExpressionType TypeAs = 44;
	public const ExpressionType TypeIs = 45;
	public const ExpressionType Assign = 46;
	public const ExpressionType Block = 47;
	public const ExpressionType DebugInfo = 48;
	public const ExpressionType Decrement = 49;
	public const ExpressionType Dynamic = 50;
	public const ExpressionType Default = 51;
	public const ExpressionType Extension = 52;
	public const ExpressionType Goto = 53;
	public const ExpressionType Increment = 54;
	public const ExpressionType Index = 55;
	public const ExpressionType Label = 56;
	public const ExpressionType RuntimeVariables = 57;
	public const ExpressionType Loop = 58;
	public const ExpressionType Switch = 59;
	public const ExpressionType Throw = 60;
	public const ExpressionType Try = 61;
	public const ExpressionType Unbox = 62;
	public const ExpressionType AddAssign = 63;
	public const ExpressionType AndAssign = 64;
	public const ExpressionType DivideAssign = 65;
	public const ExpressionType ExclusiveOrAssign = 66;
	public const ExpressionType LeftShiftAssign = 67;
	public const ExpressionType ModuloAssign = 68;
	public const ExpressionType MultiplyAssign = 69;
	public const ExpressionType OrAssign = 70;
	public const ExpressionType PowerAssign = 71;
	public const ExpressionType RightShiftAssign = 72;
	public const ExpressionType SubtractAssign = 73;
	public const ExpressionType AddAssignChecked = 74;
	public const ExpressionType MultiplyAssignChecked = 75;
	public const ExpressionType SubtractAssignChecked = 76;
	public const ExpressionType PreIncrementAssign = 77;
	public const ExpressionType PreDecrementAssign = 78;
	public const ExpressionType PostIncrementAssign = 79;
	public const ExpressionType PostDecrementAssign = 80;
	public const ExpressionType TypeEqual = 81;
	public const ExpressionType OnesComplement = 82;
	public const ExpressionType IsTrue = 83;
	public const ExpressionType IsFalse = 84;
}

// Namespace: System.Linq.Expressions
public abstract class ExpressionVisitor // TypeDefIndex: 10816
{
	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected void .ctor() { }

	// RVA: 0x1A1AB60 Offset: 0x1A19160 VA: 0x181A1AB60 Slot: 4
	public virtual Expression Visit(Expression node) { }

	// RVA: 0x1A1AB90 Offset: 0x1A19190 VA: 0x181A1AB90
	public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes) { }

	// RVA: 0x1A199E0 Offset: 0x1A17FE0 VA: 0x181A199E0
	private Expression[] VisitArguments(IArgumentProvider nodes) { }

	// RVA: 0x1A1A6B0 Offset: 0x1A18CB0 VA: 0x181A1A6B0
	private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName) { }

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x700050 Offset: 0x6FE650 VA: 0x180700050
	|-ExpressionVisitor.Visit<object>
	|
	|-RVA: 0x6FFBF0 Offset: 0x6FE1F0 VA: 0x1806FFBF0
	|-ExpressionVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T VisitAndConvert<T>(T node, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FF720 Offset: 0x6FDD20 VA: 0x1806FF720
	|-ExpressionVisitor.VisitAndConvert<object>
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FF800 Offset: 0x6FDE00 VA: 0x1806FF800
	|-ExpressionVisitor.VisitAndConvert<object>
	*/

	// RVA: 0x1A199F0 Offset: 0x1A17FF0 VA: 0x181A199F0 Slot: 5
	protected internal virtual Expression VisitBinary(BinaryExpression node) { }

	// RVA: 0x1A19AE0 Offset: 0x1A180E0 VA: 0x181A19AE0 Slot: 6
	protected internal virtual Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1A19D10 Offset: 0x1A18310 VA: 0x181A19D10 Slot: 7
	protected internal virtual Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470 Slot: 8
	protected internal virtual Expression VisitConstant(ConstantExpression node) { }

	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470 Slot: 9
	protected internal virtual Expression VisitDefault(DefaultExpression node) { }

	// RVA: 0x1A0CD00 Offset: 0x1A0B300 VA: 0x181A0CD00 Slot: 10
	protected internal virtual Expression VisitExtension(Expression node) { }

	// RVA: 0x1A19E60 Offset: 0x1A18460 VA: 0x181A19E60 Slot: 11
	protected internal virtual Expression VisitGoto(GotoExpression node) { }

	// RVA: 0x1A1A020 Offset: 0x1A18620 VA: 0x181A1A020 Slot: 12
	protected internal virtual Expression VisitInvocation(InvocationExpression node) { }

	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470 Slot: 13
	protected virtual LabelTarget VisitLabelTarget(LabelTarget node) { }

	// RVA: 0x1A1A0C0 Offset: 0x1A186C0 VA: 0x181A1A0C0 Slot: 14
	protected internal virtual Expression VisitLabel(LabelExpression node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal virtual Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x6FFB30 Offset: 0x6FE130 VA: 0x1806FFB30
	|-ExpressionVisitor.VisitLambda<object>
	|
	|-RVA: 0x6FFA70 Offset: 0x6FE070 VA: 0x1806FFA70
	|-ExpressionVisitor.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A1A180 Offset: 0x1A18780 VA: 0x181A1A180 Slot: 16
	protected internal virtual Expression VisitLoop(LoopExpression node) { }

	// RVA: 0x1A1A280 Offset: 0x1A18880 VA: 0x181A1A280 Slot: 17
	protected internal virtual Expression VisitMember(MemberExpression node) { }

	// RVA: 0x1A19F50 Offset: 0x1A18550 VA: 0x181A19F50 Slot: 18
	protected internal virtual Expression VisitIndex(IndexExpression node) { }

	// RVA: 0x1A1A330 Offset: 0x1A18930 VA: 0x181A1A330 Slot: 19
	protected internal virtual Expression VisitMethodCall(MethodCallExpression node) { }

	// RVA: 0x1A1A400 Offset: 0x1A18A00 VA: 0x181A1A400 Slot: 20
	protected internal virtual Expression VisitNewArray(NewArrayExpression node) { }

	// RVA: 0x1A1A580 Offset: 0x1A18B80 VA: 0x181A1A580 Slot: 21
	protected internal virtual Expression VisitNew(NewExpression node) { }

	// RVA: 0x869470 Offset: 0x867A70 VA: 0x180869470 Slot: 22
	protected internal virtual Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x1A19BD0 Offset: 0x1A181D0 VA: 0x181A19BD0 Slot: 23
	protected virtual CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x1A1A6C0 Offset: 0x1A18CC0 VA: 0x181A1A6C0 Slot: 24
	protected internal virtual Expression VisitTry(TryExpression node) { }

	// RVA: 0x1A1A890 Offset: 0x1A18E90 VA: 0x181A1A890 Slot: 25
	protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node) { }

	// RVA: 0x1A1A970 Offset: 0x1A18F70 VA: 0x181A1A970 Slot: 26
	protected internal virtual Expression VisitUnary(UnaryExpression node) { }

	// RVA: 0x1A198C0 Offset: 0x1A17EC0 VA: 0x181A198C0
	private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after) { }

	// RVA: 0x1A19650 Offset: 0x1A17C50 VA: 0x181A19650
	private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after) { }

	// RVA: 0x1A197F0 Offset: 0x1A17DF0 VA: 0x181A197F0
	private static void ValidateChildType(Type before, Type after, string methodName) { }
}

// Namespace: System.Linq.Expressions
public enum GotoExpressionKind // TypeDefIndex: 10817
{
	// Fields
	public int value__; // 0x0
	public const GotoExpressionKind Goto = 0;
	public const GotoExpressionKind Return = 1;
	public const GotoExpressionKind Break = 2;
	public const GotoExpressionKind Continue = 3;
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.GotoExpressionProxy))]
public sealed class GotoExpression : Expression // TypeDefIndex: 10818
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Value>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly GotoExpressionKind <Kind>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Value { get; }
	public LabelTarget Target { get; }
	public GotoExpressionKind Kind { get; }

	// Methods

	// RVA: 0x1A1B1A0 Offset: 0x1A197A0 VA: 0x181A1B1A0
	internal void .ctor(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1A1B250 Offset: 0x1A19850 VA: 0x181A1B250 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Expression get_Value() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public LabelTarget get_Target() { }

	[CompilerGenerated]
	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	public GotoExpressionKind get_Kind() { }

	// RVA: 0x1A1B0B0 Offset: 0x1A196B0 VA: 0x181A1B0B0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A1B0E0 Offset: 0x1A196E0 VA: 0x181A1B0E0
	public GotoExpression Update(LabelTarget target, Expression value) { }
}

// Namespace: System.Linq.Expressions
public interface IArgumentProvider // TypeDefIndex: 10819
{
	// Properties
	public abstract int ArgumentCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Expression GetArgument(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ArgumentCount();
}

// Namespace: System.Linq.Expressions
internal interface IParameterProvider // TypeDefIndex: 10820
{
	// Properties
	public abstract int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ParameterExpression GetParameter(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ParameterCount();
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.IndexExpressionProxy))]
public sealed class IndexExpression : Expression, IArgumentProvider // TypeDefIndex: 10821
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x10
	[CompilerGenerated]
	private readonly Expression <Object>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly PropertyInfo <Indexer>k__BackingField; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public Expression Object { get; }
	public PropertyInfo Indexer { get; }
	public int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1B6B0 Offset: 0x1A19CB0 VA: 0x181A1B6B0
	internal void .ctor(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments) { }

	// RVA: 0x1A1B7B0 Offset: 0x1A19DB0 VA: 0x181A1B7B0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1A1B7C0 Offset: 0x1A19DC0 VA: 0x181A1B7C0 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Expression get_Object() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public PropertyInfo get_Indexer() { }

	// RVA: 0x1A1B5D0 Offset: 0x1A19BD0 VA: 0x181A1B5D0 Slot: 10
	public Expression GetArgument(int index) { }

	// RVA: 0x1A1B760 Offset: 0x1A19D60 VA: 0x181A1B760 Slot: 11
	public int get_ArgumentCount() { }

	// RVA: 0x1A1B5A0 Offset: 0x1A19BA0 VA: 0x181A1B5A0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A1B630 Offset: 0x1A19C30 VA: 0x181A1B630
	internal Expression Rewrite(Expression instance, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.InvocationExpressionProxy))]
public class InvocationExpression : Expression, IArgumentProvider // TypeDefIndex: 10822
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Expression { get; }
	[ExcludeFromCodeCoverage]
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1CF90 Offset: 0x1A1B590 VA: 0x181A1CF90
	internal void .ctor(Expression expression, Type returnType) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x455580 Offset: 0x453B80 VA: 0x180455580 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Expression get_Expression() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A1CF30 Offset: 0x1A1B530 VA: 0x181A1CF30 Slot: 12
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x1A1D020 Offset: 0x1A1B620 VA: 0x181A1D020 Slot: 13
	public virtual int get_ArgumentCount() { }

	// RVA: 0x1A1CF00 Offset: 0x1A1B500 VA: 0x181A1CF00 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A1CF60 Offset: 0x1A1B560 VA: 0x181A1CF60 Slot: 14
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpressionN : InvocationExpression // TypeDefIndex: 10823
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1CE70 Offset: 0x1A1B470 VA: 0x181A1CE70
	public void .ctor(Expression lambda, IReadOnlyList<Expression> arguments, Type returnType) { }

	// RVA: 0x1A1CDA0 Offset: 0x1A1B3A0 VA: 0x181A1CDA0 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x1A1CEB0 Offset: 0x1A1B4B0 VA: 0x181A1CEB0 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1CE00 Offset: 0x1A1B400 VA: 0x181A1CE00 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression0 : InvocationExpression // TypeDefIndex: 10824
{
	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1C320 Offset: 0x1A1A920 VA: 0x181A1C320
	public void .ctor(Expression lambda, Type returnType) { }

	// RVA: 0x1A1C280 Offset: 0x1A1A880 VA: 0x181A1C280 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1C2D0 Offset: 0x1A1A8D0 VA: 0x181A1C2D0 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression1 : InvocationExpression // TypeDefIndex: 10825
{
	// Fields
	private object _arg0; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1C470 Offset: 0x1A1AA70 VA: 0x181A1C470
	public void .ctor(Expression lambda, Type returnType, Expression arg0) { }

	// RVA: 0x1A1C330 Offset: 0x1A1A930 VA: 0x181A1C330 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1C3D0 Offset: 0x1A1A9D0 VA: 0x181A1C3D0 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression2 : InvocationExpression // TypeDefIndex: 10826
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1C630 Offset: 0x1A1AC30 VA: 0x181A1C630
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1) { }

	// RVA: 0x1A1C4B0 Offset: 0x1A1AAB0 VA: 0x181A1C4B0 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1C560 Offset: 0x1A1AB60 VA: 0x181A1C560 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression3 : InvocationExpression // TypeDefIndex: 10827
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1C840 Offset: 0x1A1AE40 VA: 0x181A1C840
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1A1C680 Offset: 0x1A1AC80 VA: 0x181A1C680 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1C740 Offset: 0x1A1AD40 VA: 0x181A1C740 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression4 : InvocationExpression // TypeDefIndex: 10828
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30
	private readonly Expression _arg3; // 0x38

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1CA90 Offset: 0x1A1B090 VA: 0x181A1CA90
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1A1C8A0 Offset: 0x1A1AEA0 VA: 0x181A1C8A0 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1C970 Offset: 0x1A1AF70 VA: 0x181A1C970 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression5 : InvocationExpression // TypeDefIndex: 10829
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30
	private readonly Expression _arg3; // 0x38
	private readonly Expression _arg4; // 0x40

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1CD20 Offset: 0x1A1B320 VA: 0x181A1CD20
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1A1CB00 Offset: 0x1A1B100 VA: 0x181A1CB00 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1CBF0 Offset: 0x1A1B1F0 VA: 0x181A1CBF0 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.LabelExpressionProxy))]
public sealed class LabelExpression : Expression // TypeDefIndex: 10830
{
	// Fields
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <DefaultValue>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public LabelTarget Target { get; }
	public Expression DefaultValue { get; }

	// Methods

	// RVA: 0x1A1D110 Offset: 0x1A1B710 VA: 0x181A1D110
	internal void .ctor(LabelTarget label, Expression defaultValue) { }

	// RVA: 0xACFA50 Offset: 0xACE050 VA: 0x180ACFA50 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x80F2F0 Offset: 0x80D8F0 VA: 0x18080F2F0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public LabelTarget get_Target() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Expression get_DefaultValue() { }

	// RVA: 0x1A1D050 Offset: 0x1A1B650 VA: 0x181A1D050 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A1D080 Offset: 0x1A1B680 VA: 0x181A1D080
	public LabelExpression Update(LabelTarget target, Expression defaultValue) { }
}

// Namespace: System.Linq.Expressions
public sealed class LabelTarget // TypeDefIndex: 10831
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public string Name { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x13C63F0 Offset: 0x13C49F0 VA: 0x1813C63F0
	internal void .ctor(Type type, string name) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Type get_Type() { }

	// RVA: 0x1A1D1A0 Offset: 0x1A1B7A0 VA: 0x181A1D1A0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.LambdaExpressionProxy))]
public abstract class LambdaExpression : Expression, IParameterProvider // TypeDefIndex: 10832
{
	// Fields
	private readonly Expression _body; // 0x10

	// Properties
	public sealed override Type Type { get; }
	internal abstract Type TypeCore { get; }
	internal abstract Type PublicType { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	internal virtual string NameCore { get; }
	public Expression Body { get; }
	public Type ReturnType { get; }
	public bool TailCall { get; }
	internal virtual bool TailCallCore { get; }
	[ExcludeFromCodeCoverage]
	private int System.Linq.Expressions.IParameterProvider.ParameterCount { get; }
	[ExcludeFromCodeCoverage]
	internal virtual int ParameterCount { get; }

	// Methods

	// RVA: 0x1A1D2E0 Offset: 0x1A1B8E0 VA: 0x181A1D2E0
	internal void .ctor(Expression body) { }

	// RVA: 0x1A0A860 Offset: 0x1A08E60 VA: 0x181A0A860 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Type get_TypeCore();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Type get_PublicType();

	// RVA: 0x45BCA0 Offset: 0x45A2A0 VA: 0x18045BCA0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x8AFBA0 Offset: 0x8AE1A0 VA: 0x1808AFBA0
	public string get_Name() { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 14
	internal virtual string get_NameCore() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Expression get_Body() { }

	// RVA: 0x1A1D380 Offset: 0x1A1B980 VA: 0x181A1D380
	public Type get_ReturnType() { }

	// RVA: 0x12F6100 Offset: 0x12F4700 VA: 0x1812F6100
	public bool get_TailCall() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 15
	internal virtual bool get_TailCallCore() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A1D2A0 Offset: 0x1A1B8A0 VA: 0x181A1D2A0 Slot: 10
	private ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A1D270 Offset: 0x1A1B870 VA: 0x181A1D270 Slot: 16
	internal virtual ParameterExpression GetParameter(int index) { }

	// RVA: 0x1A1D2C0 Offset: 0x1A1B8C0 VA: 0x181A1D2C0 Slot: 11
	private int System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }

	// RVA: 0x1A1D350 Offset: 0x1A1B950 VA: 0x181A1D350 Slot: 17
	internal virtual int get_ParameterCount() { }

	// RVA: 0x1A1D1F0 Offset: 0x1A1B7F0 VA: 0x181A1D1F0
	public Delegate Compile() { }

	// RVA: 0x1A1D1F0 Offset: 0x1A1B7F0 VA: 0x181A1D1F0
	public Delegate Compile(bool preferInterpretation) { }
}

// Namespace: System.Linq.Expressions
public class Expression<TDelegate> : LambdaExpression // TypeDefIndex: 10833
{
	// Properties
	internal sealed override Type TypeCore { get; }
	internal override Type PublicType { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression body) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFF410 Offset: 0xFFDA10 VA: 0x180FFF410
	|-Expression<object>..ctor
	|-Expression<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	internal sealed override Type get_TypeCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC08460 Offset: 0xC06A60 VA: 0x180C08460
	|-Expression<object>.get_TypeCore
	|-Expression<__Il2CppFullySharedGenericType>.get_TypeCore
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override Type get_PublicType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8B8C70 Offset: 0x8B7270 VA: 0x1808B8C70
	|-Expression<object>.get_PublicType
	|-Expression<__Il2CppFullySharedGenericType>.get_PublicType
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFF1F0 Offset: 0xFFD7F0 VA: 0x180FFF1F0
	|-Expression<object>.Compile
	|
	|-RVA: 0xFFF130 Offset: 0xFFD730 VA: 0x180FFF130
	|-Expression<__Il2CppFullySharedGenericType>.Compile
	*/

	// RVA: -1 Offset: -1
	public TDelegate Compile(bool preferInterpretation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFF060 Offset: 0xFFD660 VA: 0x180FFF060
	|-Expression<object>.Compile
	|
	|-RVA: 0xFFF2D0 Offset: 0xFFD8D0 VA: 0x180FFF2D0
	|-Expression<__Il2CppFullySharedGenericType>.Compile
	*/

	[ExcludeFromCodeCoverage]
	// RVA: -1 Offset: -1 Slot: 18
	internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFF3F0 Offset: 0xFFD9F0 VA: 0x180FFF3F0
	|-Expression<object>.Rewrite
	|-Expression<__Il2CppFullySharedGenericType>.Rewrite
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFF000 Offset: 0xFFD600 VA: 0x180FFF000
	|-Expression<object>.Accept
	|-Expression<__Il2CppFullySharedGenericType>.Accept
	*/
}

// Namespace: System.Linq.Expressions
internal static class ExpressionCreator<TDelegate> // TypeDefIndex: 10834
{
	// Methods

	// RVA: -1 Offset: -1
	public static LambdaExpression CreateExpressionFunc(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE930 Offset: 0xFFCF30 VA: 0x180FFE930
	|-ExpressionCreator<__Il2CppFullySharedGenericType>.CreateExpressionFunc
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression0<TDelegate> : Expression<TDelegate> // TypeDefIndex: 10835
{
	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x9B6100 Offset: 0x9B4700 VA: 0x1809B6100
	|-Expression0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40
	|-Expression0<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE060 Offset: 0xFFC660 VA: 0x180FFE060
	|-Expression0<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE090 Offset: 0xFFC690 VA: 0x180FFE090
	|-Expression0<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression1<TDelegate> : Expression<TDelegate> // TypeDefIndex: 10836
{
	// Fields
	private object _par0; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE2D0 Offset: 0xFFC8D0 VA: 0x180FFE2D0
	|-Expression1<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430
	|-Expression1<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE120 Offset: 0xFFC720 VA: 0x180FFE120
	|-Expression1<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE1A0 Offset: 0xFFC7A0 VA: 0x180FFE1A0
	|-Expression1<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression2<TDelegate> : Expression<TDelegate> // TypeDefIndex: 10837
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE580 Offset: 0xFFCB80 VA: 0x180FFE580
	|-Expression2<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270
	|-Expression2<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE310 Offset: 0xFFC910 VA: 0x180FFE310
	|-Expression2<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE3B0 Offset: 0xFFC9B0 VA: 0x180FFE3B0
	|-Expression2<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class Expression3<TDelegate> : Expression<TDelegate> // TypeDefIndex: 10838
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0
	private readonly ParameterExpression _par2; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE8B0 Offset: 0xFFCEB0 VA: 0x180FFE8B0
	|-Expression3<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0
	|-Expression3<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE5E0 Offset: 0xFFCBE0 VA: 0x180FFE5E0
	|-Expression3<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE690 Offset: 0xFFCC90 VA: 0x180FFE690
	|-Expression3<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal class ExpressionN<TDelegate> : Expression<TDelegate> // TypeDefIndex: 10839
{
	// Fields
	private IReadOnlyList<ParameterExpression> _parameters; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, IReadOnlyList<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFE2D0 Offset: 0xFFC8D0 VA: 0x180FFE2D0
	|-ExpressionN<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFEFB0 Offset: 0xFFD5B0 VA: 0x180FFEFB0
	|-ExpressionN<__Il2CppFullySharedGenericType>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFEE20 Offset: 0xFFD420 VA: 0x180FFEE20
	|-ExpressionN<__Il2CppFullySharedGenericType>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFFEED0 Offset: 0xFFD4D0 VA: 0x180FFEED0
	|-ExpressionN<__Il2CppFullySharedGenericType>.Rewrite
	*/
}

// Namespace: System.Linq.Expressions
internal sealed class FullExpression<TDelegate> : ExpressionN<TDelegate> // TypeDefIndex: 10840
{
	// Fields
	[CompilerGenerated]
	private readonly string <NameCore>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <TailCallCore>k__BackingField; // 0x0

	// Properties
	internal override string NameCore { get; }
	internal override bool TailCallCore { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10112D0 Offset: 0x100F8D0 VA: 0x1810112D0
	|-FullExpression<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	internal override string get_NameCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	|-FullExpression<__Il2CppFullySharedGenericType>.get_NameCore
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	internal override bool get_TailCallCore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3CB150 Offset: 0x3C9750 VA: 0x1803CB150
	|-FullExpression<__Il2CppFullySharedGenericType>.get_TailCallCore
	*/
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ListInitExpressionProxy))]
public sealed class ListInitExpression : Expression // TypeDefIndex: 10841
{
	// Fields
	[CompilerGenerated]
	private readonly NewExpression <NewExpression>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ElementInit> <Initializers>k__BackingField; // 0x18

	// Properties
	public NewExpression NewExpression { get; }
	public ReadOnlyCollection<ElementInit> Initializers { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public NewExpression get_NewExpression() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ReadOnlyCollection<ElementInit> get_Initializers() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.LoopExpressionProxy))]
public sealed class LoopExpression : Expression // TypeDefIndex: 10842
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly LabelTarget <BreakLabel>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly LabelTarget <ContinueLabel>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public LabelTarget BreakLabel { get; }
	public LabelTarget ContinueLabel { get; }

	// Methods

	// RVA: 0x1A1D960 Offset: 0x1A1BF60 VA: 0x181A1D960
	internal void .ctor(Expression body, LabelTarget break, LabelTarget continue) { }

	// RVA: 0x1A1DA10 Offset: 0x1A1C010 VA: 0x181A1DA10 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1A1DA00 Offset: 0x1A1C000 VA: 0x181A1DA00 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public LabelTarget get_BreakLabel() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public LabelTarget get_ContinueLabel() { }

	// RVA: 0x1A1D8A0 Offset: 0x1A1BEA0 VA: 0x181A1D8A0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A1D8D0 Offset: 0x1A1BED0 VA: 0x181A1D8D0
	public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body) { }
}

// Namespace: System.Linq.Expressions
public sealed class MemberAssignment : MemberBinding // TypeDefIndex: 10843
{
	// Fields
	private readonly Expression _expression; // 0x20

	// Properties
	public Expression Expression { get; }

	// Methods

	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Expression get_Expression() { }
}

// Namespace: System.Linq.Expressions
public enum MemberBindingType // TypeDefIndex: 10844
{
	// Fields
	public int value__; // 0x0
	public const MemberBindingType Assignment = 0;
	public const MemberBindingType MemberBinding = 1;
	public const MemberBindingType ListBinding = 2;
}

// Namespace: System.Linq.Expressions
public abstract class MemberBinding // TypeDefIndex: 10845
{
	// Fields
	[CompilerGenerated]
	private readonly MemberBindingType <BindingType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly MemberInfo <Member>k__BackingField; // 0x18

	// Properties
	public MemberBindingType BindingType { get; }
	public MemberInfo Member { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public MemberBindingType get_BindingType() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public MemberInfo get_Member() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.MemberExpressionProxy))]
public class MemberExpression : Expression // TypeDefIndex: 10846
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x10

	// Properties
	public MemberInfo Member { get; }
	public Expression Expression { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x14438C0 Offset: 0x1441EC0 VA: 0x1814438C0
	public MemberInfo get_Member() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Expression get_Expression() { }

	// RVA: 0x1A1DCC0 Offset: 0x1A1C2C0 VA: 0x181A1DCC0
	internal void .ctor(Expression expression) { }

	// RVA: 0x1A1DB80 Offset: 0x1A1C180 VA: 0x181A1DB80
	internal static PropertyExpression Make(Expression expression, PropertyInfo property) { }

	// RVA: 0x1A1DAD0 Offset: 0x1A1C0D0 VA: 0x181A1DAD0
	internal static FieldExpression Make(Expression expression, FieldInfo field) { }

	// RVA: 0x146AE90 Offset: 0x1469490 VA: 0x18146AE90 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A1DAA0 Offset: 0x1A1C0A0 VA: 0x181A1DAA0 Slot: 10
	internal virtual MemberInfo GetMember() { }

	// RVA: 0x1A1DA70 Offset: 0x1A1C070 VA: 0x181A1DA70 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A1DC30 Offset: 0x1A1C230 VA: 0x181A1DC30
	public MemberExpression Update(Expression expression) { }
}

// Namespace: System.Linq.Expressions
internal sealed class FieldExpression : MemberExpression // TypeDefIndex: 10847
{
	// Fields
	private readonly FieldInfo _field; // 0x18

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1A1AE20 Offset: 0x1A19420 VA: 0x181A1AE20
	public void .ctor(Expression expression, FieldInfo member) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 10
	internal override MemberInfo GetMember() { }

	// RVA: 0x1A1AEB0 Offset: 0x1A194B0 VA: 0x181A1AEB0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal sealed class PropertyExpression : MemberExpression // TypeDefIndex: 10848
{
	// Fields
	private readonly PropertyInfo _property; // 0x18

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1A1AE20 Offset: 0x1A19420 VA: 0x181A1AE20
	public void .ctor(Expression expression, PropertyInfo member) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 10
	internal override MemberInfo GetMember() { }

	// RVA: 0x1A20470 Offset: 0x1A1EA70 VA: 0x181A20470 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.MemberInitExpressionProxy))]
public sealed class MemberInitExpression : Expression // TypeDefIndex: 10849
{
	// Fields
	[CompilerGenerated]
	private readonly NewExpression <NewExpression>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<MemberBinding> <Bindings>k__BackingField; // 0x18

	// Properties
	public NewExpression NewExpression { get; }
	public ReadOnlyCollection<MemberBinding> Bindings { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public NewExpression get_NewExpression() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }
}

// Namespace: System.Linq.Expressions
public sealed class MemberListBinding : MemberBinding // TypeDefIndex: 10850
{
	// Fields
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ElementInit> <Initializers>k__BackingField; // 0x20

	// Properties
	public ReadOnlyCollection<ElementInit> Initializers { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public ReadOnlyCollection<ElementInit> get_Initializers() { }
}

// Namespace: System.Linq.Expressions
public sealed class MemberMemberBinding : MemberBinding // TypeDefIndex: 10851
{
	// Fields
	[CompilerGenerated]
	private readonly ReadOnlyCollection<MemberBinding> <Bindings>k__BackingField; // 0x20

	// Properties
	public ReadOnlyCollection<MemberBinding> Bindings { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.MethodCallExpressionProxy))]
public class MethodCallExpression : Expression, IArgumentProvider // TypeDefIndex: 10852
{
	// Fields
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; // 0x10

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public MethodInfo Method { get; }
	public Expression Object { get; }
	[ExcludeFromCodeCoverage]
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1DDD0 Offset: 0x1A1C3D0 VA: 0x181A1DDD0
	internal void .ctor(MethodInfo method) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 12
	internal virtual Expression GetInstance() { }

	// RVA: 0x45C3F0 Offset: 0x45A9F0 VA: 0x18045C3F0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1A1EC90 Offset: 0x1A1D290 VA: 0x181A1EC90 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public MethodInfo get_Method() { }

	// RVA: 0x1A0A860 Offset: 0x1A08E60 VA: 0x181A0A860
	public Expression get_Object() { }

	// RVA: 0x1A1EBD0 Offset: 0x1A1D1D0 VA: 0x181A1EBD0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A1EC30 Offset: 0x1A1D230 VA: 0x181A1EC30 Slot: 13
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x1A1EC00 Offset: 0x1A1D200 VA: 0x181A1EC00 Slot: 14
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x1A1EC60 Offset: 0x1A1D260 VA: 0x181A1EC60 Slot: 15
	public virtual int get_ArgumentCount() { }
}

// Namespace: System.Linq.Expressions
internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider // TypeDefIndex: 10853
{
	// Fields
	private readonly Expression _instance; // 0x18

	// Methods

	// RVA: 0x1A1C1F0 Offset: 0x1A1A7F0 VA: 0x181A1C1F0
	public void .ctor(MethodInfo method, Expression instance) { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 12
	internal override Expression GetInstance() { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider // TypeDefIndex: 10854
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1C1F0 Offset: 0x1A1A7F0 VA: 0x181A1C1F0
	public void .ctor(MethodInfo method, IReadOnlyList<Expression> args) { }

	// RVA: 0x1A1EAB0 Offset: 0x1A1D0B0 VA: 0x181A1EAB0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x1A1EB80 Offset: 0x1A1D180 VA: 0x181A1EB80 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1EB10 Offset: 0x1A1D110 VA: 0x181A1EB10 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 10855
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1BC10 Offset: 0x1A1A210 VA: 0x181A1BC10
	public void .ctor(MethodInfo method, Expression instance, IReadOnlyList<Expression> args) { }

	// RVA: 0x1A1C0C0 Offset: 0x1A1A6C0 VA: 0x181A1C0C0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x1A1C1A0 Offset: 0x1A1A7A0 VA: 0x181A1C1A0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1C120 Offset: 0x1A1A720 VA: 0x181A1C120 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 10856
{
	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1DDD0 Offset: 0x1A1C3D0 VA: 0x181A1DDD0
	public void .ctor(MethodInfo method) { }

	// RVA: 0x1A1DD30 Offset: 0x1A1C330 VA: 0x181A1DD30 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1DD80 Offset: 0x1A1C380 VA: 0x181A1DD80 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 10857
{
	// Fields
	private object _arg0; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1C1F0 Offset: 0x1A1A7F0 VA: 0x181A1C1F0
	public void .ctor(MethodInfo method, Expression arg0) { }

	// RVA: 0x1A1DE40 Offset: 0x1A1C440 VA: 0x181A1DE40 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1DEE0 Offset: 0x1A1C4E0 VA: 0x181A1DEE0 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 10858
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1E130 Offset: 0x1A1C730 VA: 0x181A1E130
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x1A1DF90 Offset: 0x1A1C590 VA: 0x181A1DF90 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1E040 Offset: 0x1A1C640 VA: 0x181A1E040 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression3 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 10859
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1E3B0 Offset: 0x1A1C9B0 VA: 0x181A1E3B0
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1A1E1D0 Offset: 0x1A1C7D0 VA: 0x181A1E1D0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1E290 Offset: 0x1A1C890 VA: 0x181A1E290 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 10860
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1E6A0 Offset: 0x1A1CCA0 VA: 0x181A1E6A0
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x1A1E470 Offset: 0x1A1CA70 VA: 0x181A1E470 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3F8AB0 Offset: 0x3F70B0 VA: 0x1803F8AB0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1E540 Offset: 0x1A1CB40 VA: 0x181A1E540 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 10861
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30
	private readonly Expression _arg4; // 0x38

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1E9D0 Offset: 0x1A1CFD0 VA: 0x181A1E9D0
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x1A1E770 Offset: 0x1A1CD70 VA: 0x181A1E770 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x455080 Offset: 0x453680 VA: 0x180455080 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1E860 Offset: 0x1A1CE60 VA: 0x181A1E860 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression0 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 10862
{
	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1BAA0 Offset: 0x1A1A0A0 VA: 0x181A1BAA0
	public void .ctor(MethodInfo method, Expression instance) { }

	// RVA: 0x1A1B9F0 Offset: 0x1A19FF0 VA: 0x181A1B9F0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x37AB40 Offset: 0x379140 VA: 0x18037AB40 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1BA40 Offset: 0x1A1A040 VA: 0x181A1BA40 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 10863
{
	// Fields
	private object _arg0; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1BC10 Offset: 0x1A1A210 VA: 0x181A1BC10
	public void .ctor(MethodInfo method, Expression instance, Expression arg0) { }

	// RVA: 0x1A1BAB0 Offset: 0x1A1A0B0 VA: 0x181A1BAB0 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x44F430 Offset: 0x44DA30 VA: 0x18044F430 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1BB50 Offset: 0x1A1A150 VA: 0x181A1BB50 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 10864
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1BE10 Offset: 0x1A1A410 VA: 0x181A1BE10
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1) { }

	// RVA: 0x1A1BC50 Offset: 0x1A1A250 VA: 0x181A1BC50 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x44F270 Offset: 0x44D870 VA: 0x18044F270 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1BD00 Offset: 0x1A1A300 VA: 0x181A1BD00 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 10865
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x1A1C060 Offset: 0x1A1A660 VA: 0x181A1C060
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x1A1BE60 Offset: 0x1A1A460 VA: 0x181A1BE60 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3F8AC0 Offset: 0x3F70C0 VA: 0x1803F8AC0 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x1A1BF20 Offset: 0x1A1A520 VA: 0x181A1BF20 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.NewArrayExpressionProxy))]
public class NewArrayExpression : Expression // TypeDefIndex: 10866
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <Expressions>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public ReadOnlyCollection<Expression> Expressions { get; }

	// Methods

	// RVA: 0x1A1F4E0 Offset: 0x1A1DAE0 VA: 0x181A1F4E0
	internal void .ctor(Type type, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x1A1F2F0 Offset: 0x1A1D8F0 VA: 0x181A1F2F0
	internal static NewArrayExpression Make(ExpressionType nodeType, Type type, ReadOnlyCollection<Expression> expressions) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x1A1F2C0 Offset: 0x1A1D8C0 VA: 0x181A1F2C0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A1F370 Offset: 0x1A1D970 VA: 0x181A1F370
	public NewArrayExpression Update(IEnumerable<Expression> expressions) { }
}

// Namespace: System.Linq.Expressions
internal sealed class NewArrayInitExpression : NewArrayExpression // TypeDefIndex: 10867
{
	// Properties
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x1A1F160 Offset: 0x1A1D760 VA: 0x181A1F160
	internal void .ctor(Type type, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x44EB30 Offset: 0x44D130 VA: 0x18044EB30 Slot: 4
	public sealed override ExpressionType get_NodeType() { }
}

// Namespace: System.Linq.Expressions
internal sealed class NewArrayBoundsExpression : NewArrayExpression // TypeDefIndex: 10868
{
	// Properties
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x1A1F160 Offset: 0x1A1D760 VA: 0x181A1F160
	internal void .ctor(Type type, ReadOnlyCollection<Expression> expressions) { }

	// RVA: 0x17575E0 Offset: 0x1755BE0 VA: 0x1817575E0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.NewExpressionProxy))]
public class NewExpression : Expression, IArgumentProvider // TypeDefIndex: 10869
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x10
	[CompilerGenerated]
	private readonly ConstructorInfo <Constructor>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ReadOnlyCollection<MemberInfo> <Members>k__BackingField; // 0x20

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public ConstructorInfo Constructor { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	public int ArgumentCount { get; }
	public ReadOnlyCollection<MemberInfo> Members { get; }

	// Methods

	// RVA: 0x1A1F890 Offset: 0x1A1DE90 VA: 0x181A1F890
	internal void .ctor(ConstructorInfo constructor, IReadOnlyList<Expression> arguments, ReadOnlyCollection<MemberInfo> members) { }

	// RVA: 0x1344CF0 Offset: 0x13432F0 VA: 0x181344CF0 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x1758D60 Offset: 0x1757360 VA: 0x181758D60 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ConstructorInfo get_Constructor() { }

	// RVA: 0x1A1F980 Offset: 0x1A1DF80 VA: 0x181A1F980
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x1A1F720 Offset: 0x1A1DD20 VA: 0x181A1F720 Slot: 10
	public Expression GetArgument(int index) { }

	// RVA: 0x1A1F930 Offset: 0x1A1DF30 VA: 0x181A1F930 Slot: 11
	public int get_ArgumentCount() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public ReadOnlyCollection<MemberInfo> get_Members() { }

	// RVA: 0x1A1F6F0 Offset: 0x1A1DCF0 VA: 0x181A1F6F0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A1F780 Offset: 0x1A1DD80 VA: 0x181A1F780
	public NewExpression Update(IEnumerable<Expression> arguments) { }
}

// Namespace: System.Linq.Expressions
internal sealed class NewValueTypeExpression : NewExpression // TypeDefIndex: 10870
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1A1F9C0 Offset: 0x1A1DFC0 VA: 0x181A1F9C0
	internal void .ctor(Type type, ReadOnlyCollection<Expression> arguments, ReadOnlyCollection<MemberInfo> members) { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ParameterExpressionProxy))]
public class ParameterExpression : Expression // TypeDefIndex: 10871
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	public bool IsByRef { get; }

	// Methods

	// RVA: 0x1A20400 Offset: 0x1A1EA00 VA: 0x181A20400
	internal void .ctor(string name) { }

	// RVA: 0x1A1FCA0 Offset: 0x1A1E2A0 VA: 0x181A1FCA0
	internal static ParameterExpression Make(Type type, string name, bool isByRef) { }

	// RVA: 0x16592C0 Offset: 0x16578C0 VA: 0x1816592C0 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x175B970 Offset: 0x1759F70 VA: 0x18175B970 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_Name() { }

	// RVA: 0x14438C0 Offset: 0x1441EC0 VA: 0x1814438C0
	public bool get_IsByRef() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 10
	internal virtual bool GetIsByRef() { }

	// RVA: 0x17B9E00 Offset: 0x17B8400 VA: 0x1817B9E00 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}

// Namespace: System.Linq.Expressions
internal sealed class ByRefParameterExpression : TypedParameterExpression // TypeDefIndex: 10872
{
	// Methods

	// RVA: 0x1A0BA00 Offset: 0x1A0A000 VA: 0x181A0BA00
	internal void .ctor(Type type, string name) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 10
	internal override bool GetIsByRef() { }
}

// Namespace: System.Linq.Expressions
internal class TypedParameterExpression : ParameterExpression // TypeDefIndex: 10873
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x1A238A0 Offset: 0x1A21EA0 VA: 0x181A238A0
	internal void .ctor(Type type, string name) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 5
	public sealed override Type get_Type() { }
}

// Namespace: System.Linq.Expressions
internal sealed class PrimitiveParameterExpression<T> : ParameterExpression // TypeDefIndex: 10874
{
	// Properties
	public sealed override Type Type { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F4C40 Offset: 0x12F3240 VA: 0x1812F4C40
	|-PrimitiveParameterExpression<bool>..ctor
	|-PrimitiveParameterExpression<byte>..ctor
	|-PrimitiveParameterExpression<char>..ctor
	|-PrimitiveParameterExpression<DateTime>..ctor
	|-PrimitiveParameterExpression<Decimal>..ctor
	|-PrimitiveParameterExpression<double>..ctor
	|-PrimitiveParameterExpression<short>..ctor
	|-PrimitiveParameterExpression<int>..ctor
	|-PrimitiveParameterExpression<long>..ctor
	|-PrimitiveParameterExpression<object>..ctor
	|-PrimitiveParameterExpression<sbyte>..ctor
	|-PrimitiveParameterExpression<float>..ctor
	|-PrimitiveParameterExpression<ushort>..ctor
	|-PrimitiveParameterExpression<uint>..ctor
	|-PrimitiveParameterExpression<ulong>..ctor
	|-PrimitiveParameterExpression<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public sealed override Type get_Type() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC08460 Offset: 0xC06A60 VA: 0x180C08460
	|-PrimitiveParameterExpression<bool>.get_Type
	|-PrimitiveParameterExpression<byte>.get_Type
	|-PrimitiveParameterExpression<char>.get_Type
	|-PrimitiveParameterExpression<DateTime>.get_Type
	|-PrimitiveParameterExpression<Decimal>.get_Type
	|-PrimitiveParameterExpression<double>.get_Type
	|-PrimitiveParameterExpression<short>.get_Type
	|-PrimitiveParameterExpression<int>.get_Type
	|-PrimitiveParameterExpression<long>.get_Type
	|-PrimitiveParameterExpression<object>.get_Type
	|-PrimitiveParameterExpression<sbyte>.get_Type
	|-PrimitiveParameterExpression<float>.get_Type
	|-PrimitiveParameterExpression<ushort>.get_Type
	|-PrimitiveParameterExpression<uint>.get_Type
	|-PrimitiveParameterExpression<ulong>.get_Type
	|-PrimitiveParameterExpression<__Il2CppFullySharedGenericType>.get_Type
	*/
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.RuntimeVariablesExpressionProxy))]
public sealed class RuntimeVariablesExpression : Expression // TypeDefIndex: 10875
{
	// Fields
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ParameterExpression> <Variables>k__BackingField; // 0x10

	// Properties
	public ReadOnlyCollection<ParameterExpression> Variables { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }
}

// Namespace: System.Linq.Expressions
internal sealed class StackGuard // TypeDefIndex: 10877
{
	// Fields
	private int _executionStackCount; // 0x10

	// Methods

	// RVA: 0x1A20D60 Offset: 0x1A1F360 VA: 0x181A20D60
	public bool TryEnterOnCurrentStack() { }

	// RVA: -1 Offset: -1
	public void RunOnEmptyStack<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B7F20 Offset: 0x7B6520 VA: 0x1807B7F20
	|-StackGuard.RunOnEmptyStack<object, object>
	|
	|-RVA: 0x7B7C50 Offset: 0x7B6250 VA: 0x1807B7C50
	|-StackGuard.RunOnEmptyStack<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private R RunOnEmptyStackCore<R>(Func<object, R> action, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7B7980 Offset: 0x7B5F80 VA: 0x1807B7980
	|-StackGuard.RunOnEmptyStackCore<object>
	|
	|-RVA: 0x7B7640 Offset: 0x7B5C40 VA: 0x1807B7640
	|-StackGuard.RunOnEmptyStackCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions
internal static class Strings // TypeDefIndex: 10878
{
	// Properties
	internal static string ReducibleMustOverrideReduce { get; }
	internal static string MustReduceToDifferent { get; }
	internal static string ReducedNotCompatible { get; }
	internal static string SetterHasNoParams { get; }
	internal static string PropertyCannotHaveRefType { get; }
	internal static string IndexesOfSetGetMustMatch { get; }
	internal static string AccessorsCannotHaveVarArgs { get; }
	internal static string AccessorsCannotHaveByRefArgs { get; }
	internal static string BoundsCannotBeLessThanOne { get; }
	internal static string TypeMustNotBeByRef { get; }
	internal static string TypeMustNotBePointer { get; }
	internal static string SetterMustBeVoid { get; }
	internal static string PropertyTypeMustMatchGetter { get; }
	internal static string PropertyTypeMustMatchSetter { get; }
	internal static string BothAccessorsMustBeStatic { get; }
	internal static string OnlyStaticFieldsHaveNullInstance { get; }
	internal static string OnlyStaticPropertiesHaveNullInstance { get; }
	internal static string OnlyStaticMethodsHaveNullInstance { get; }
	internal static string PropertyTypeCannotBeVoid { get; }
	internal static string InvalidUnboxType { get; }
	internal static string ExpressionMustBeWriteable { get; }
	internal static string ArgumentMustNotHaveValueType { get; }
	internal static string MustBeReducible { get; }
	internal static string LabelMustBeVoidOrHaveExpression { get; }
	internal static string LabelTypeMustBeVoid { get; }
	internal static string QuotedExpressionMustBeLambda { get; }
	internal static string CollectionModifiedWhileEnumerating { get; }
	internal static string CollectionReadOnly { get; }
	internal static string BindingCannotBeNull { get; }
	internal static string NoOrInvalidRuleProduced { get; }
	internal static string TypeMustBeDerivedFromSystemDelegate { get; }
	internal static string FirstArgumentMustBeCallSite { get; }
	internal static string FaultCannotHaveCatchOrFinally { get; }
	internal static string TryMustHaveCatchFinallyOrFault { get; }
	internal static string BodyOfCatchMustHaveSameTypeAsBodyOfTry { get; }
	internal static string ConversionIsNotSupportedForArithmeticTypes { get; }
	internal static string ArgumentMustBeArray { get; }
	internal static string ArgumentMustBeBoolean { get; }
	internal static string ArgumentMustBeFieldInfoOrPropertyInfoOrMethod { get; }
	internal static string ArgumentMustBeInstanceMember { get; }
	internal static string ArgumentMustBeInteger { get; }
	internal static string ArgumentMustBeArrayIndexType { get; }
	internal static string ArgumentMustBeSingleDimensionalArrayType { get; }
	internal static string ArgumentTypesMustMatch { get; }
	internal static string CoalesceUsedOnNonNullType { get; }
	internal static string IncorrectNumberOfIndexes { get; }
	internal static string IncorrectNumberOfLambdaDeclarationParameters { get; }
	internal static string IncorrectNumberOfMembersForGivenConstructor { get; }
	internal static string IncorrectNumberOfArgumentsForMembers { get; }
	internal static string LambdaTypeMustBeDerivedFromSystemDelegate { get; }
	internal static string ArgumentCannotBeOfTypeVoid { get; }
	internal static string ControlCannotLeaveFinally { get; }
	internal static string ControlCannotLeaveFilterTest { get; }
	internal static string ControlCannotEnterTry { get; }
	internal static string ControlCannotEnterExpression { get; }
	internal static string RethrowRequiresCatch { get; }
	internal static string NonStaticConstructorRequired { get; }
	internal static string NonAbstractConstructorRequired { get; }
	internal static string ExpressionMustBeReadable { get; }
	internal static string EnumerationIsDone { get; }
	internal static string InvalidArgumentValue { get; }
	internal static string IncorrectNumberOfLambdaArguments { get; }
	internal static string IncorrectNumberOfConstructorArguments { get; }

	// Methods

	// RVA: 0x1A22EB0 Offset: 0x1A214B0 VA: 0x181A22EB0
	internal static string get_ReducibleMustOverrideReduce() { }

	// RVA: 0x1A22C40 Offset: 0x1A21240 VA: 0x181A22C40
	internal static string get_MustReduceToDifferent() { }

	// RVA: 0x1A22E80 Offset: 0x1A21480 VA: 0x181A22E80
	internal static string get_ReducedNotCompatible() { }

	// RVA: 0x1A22F10 Offset: 0x1A21510 VA: 0x181A22F10
	internal static string get_SetterHasNoParams() { }

	// RVA: 0x1A22D90 Offset: 0x1A21390 VA: 0x181A22D90
	internal static string get_PropertyCannotHaveRefType() { }

	// RVA: 0x1A22AF0 Offset: 0x1A210F0 VA: 0x181A22AF0
	internal static string get_IndexesOfSetGetMustMatch() { }

	// RVA: 0x1A22490 Offset: 0x1A20A90 VA: 0x181A22490
	internal static string get_AccessorsCannotHaveVarArgs() { }

	// RVA: 0x1A22460 Offset: 0x1A20A60 VA: 0x181A22460
	internal static string get_AccessorsCannotHaveByRefArgs() { }

	// RVA: 0x1A22730 Offset: 0x1A20D30 VA: 0x181A22730
	internal static string get_BoundsCannotBeLessThanOne() { }

	// RVA: 0x1A22FD0 Offset: 0x1A215D0 VA: 0x181A22FD0
	internal static string get_TypeMustNotBeByRef() { }

	// RVA: 0x1A23000 Offset: 0x1A21600 VA: 0x181A23000
	internal static string get_TypeMustNotBePointer() { }

	// RVA: 0x1A22F40 Offset: 0x1A21540 VA: 0x181A22F40
	internal static string get_SetterMustBeVoid() { }

	// RVA: 0x1A22DF0 Offset: 0x1A213F0 VA: 0x181A22DF0
	internal static string get_PropertyTypeMustMatchGetter() { }

	// RVA: 0x1A22E20 Offset: 0x1A21420 VA: 0x181A22E20
	internal static string get_PropertyTypeMustMatchSetter() { }

	// RVA: 0x1A22700 Offset: 0x1A20D00 VA: 0x181A22700
	internal static string get_BothAccessorsMustBeStatic() { }

	// RVA: 0x1A22D00 Offset: 0x1A21300 VA: 0x181A22D00
	internal static string get_OnlyStaticFieldsHaveNullInstance() { }

	// RVA: 0x1A22D60 Offset: 0x1A21360 VA: 0x181A22D60
	internal static string get_OnlyStaticPropertiesHaveNullInstance() { }

	// RVA: 0x1A22D30 Offset: 0x1A21330 VA: 0x181A22D30
	internal static string get_OnlyStaticMethodsHaveNullInstance() { }

	// RVA: 0x1A22DC0 Offset: 0x1A213C0 VA: 0x181A22DC0
	internal static string get_PropertyTypeCannotBeVoid() { }

	// RVA: 0x1A22B50 Offset: 0x1A21150 VA: 0x181A22B50
	internal static string get_InvalidUnboxType() { }

	// RVA: 0x1A22940 Offset: 0x1A20F40 VA: 0x181A22940
	internal static string get_ExpressionMustBeWriteable() { }

	// RVA: 0x1A22640 Offset: 0x1A20C40 VA: 0x181A22640
	internal static string get_ArgumentMustNotHaveValueType() { }

	// RVA: 0x1A22C10 Offset: 0x1A21210 VA: 0x181A22C10
	internal static string get_MustBeReducible() { }

	// RVA: 0x1A22B80 Offset: 0x1A21180 VA: 0x181A22B80
	internal static string get_LabelMustBeVoidOrHaveExpression() { }

	// RVA: 0x1A22BB0 Offset: 0x1A211B0 VA: 0x181A22BB0
	internal static string get_LabelTypeMustBeVoid() { }

	// RVA: 0x1A22E50 Offset: 0x1A21450 VA: 0x181A22E50
	internal static string get_QuotedExpressionMustBeLambda() { }

	// RVA: 0x1A22790 Offset: 0x1A20D90 VA: 0x181A22790
	internal static string get_CollectionModifiedWhileEnumerating() { }

	// RVA: 0x1A22410 Offset: 0x1A20A10 VA: 0x181A22410
	internal static string VariableMustNotBeByRef(object p0, object p1) { }

	// RVA: 0x1A227C0 Offset: 0x1A20DC0 VA: 0x181A227C0
	internal static string get_CollectionReadOnly() { }

	// RVA: 0x1A20F10 Offset: 0x1A1F510 VA: 0x181A20F10
	internal static string AmbiguousMatchInExpandoObject(object p0) { }

	// RVA: 0x1A220E0 Offset: 0x1A206E0 VA: 0x181A220E0
	internal static string SameKeyExistsInExpando(object p0) { }

	// RVA: 0x1A21A50 Offset: 0x1A20050 VA: 0x181A21A50
	internal static string KeyDoesNotExistInExpando(object p0) { }

	// RVA: 0x1A21980 Offset: 0x1A1FF80 VA: 0x181A21980
	internal static string InvalidMetaObjectCreated(object p0) { }

	// RVA: 0x1A21060 Offset: 0x1A1F660 VA: 0x181A21060
	internal static string BinderNotCompatibleWithCallSite(object p0, object p1, object p2) { }

	// RVA: 0x1A21210 Offset: 0x1A1F810 VA: 0x181A21210
	internal static string DynamicBindingNeedsRestrictions(object p0, object p1) { }

	// RVA: 0x1A21260 Offset: 0x1A1F860 VA: 0x181A21260
	internal static string DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3) { }

	// RVA: 0x1A211A0 Offset: 0x1A1F7A0 VA: 0x181A211A0
	internal static string DynamicBinderResultNotAssignable(object p0, object p1, object p2) { }

	// RVA: 0x1A226A0 Offset: 0x1A20CA0 VA: 0x181A226A0
	internal static string get_BindingCannotBeNull() { }

	// RVA: 0x1A21160 Offset: 0x1A1F760 VA: 0x181A21160
	internal static string DuplicateVariable(object p0) { }

	// RVA: 0x1A221E0 Offset: 0x1A207E0 VA: 0x181A221E0
	internal static string TypeParameterIsNotDelegate(object p0) { }

	// RVA: 0x1A22C70 Offset: 0x1A21270 VA: 0x181A22C70
	internal static string get_NoOrInvalidRuleProduced() { }

	// RVA: 0x1A22FA0 Offset: 0x1A215A0 VA: 0x181A22FA0
	internal static string get_TypeMustBeDerivedFromSystemDelegate() { }

	// RVA: 0x1A229A0 Offset: 0x1A20FA0 VA: 0x181A229A0
	internal static string get_FirstArgumentMustBeCallSite() { }

	// RVA: 0x1A22970 Offset: 0x1A20F70 VA: 0x181A22970
	internal static string get_FaultCannotHaveCatchOrFinally() { }

	// RVA: 0x1A22F70 Offset: 0x1A21570 VA: 0x181A22F70
	internal static string get_TryMustHaveCatchFinallyOrFault() { }

	// RVA: 0x1A226D0 Offset: 0x1A20CD0 VA: 0x181A226D0
	internal static string get_BodyOfCatchMustHaveSameTypeAsBodyOfTry() { }

	// RVA: 0x1A216B0 Offset: 0x1A1FCB0 VA: 0x181A216B0
	internal static string ExtensionNodeMustOverrideProperty(object p0) { }

	// RVA: 0x1A22390 Offset: 0x1A20990 VA: 0x181A22390
	internal static string UserDefinedOperatorMustBeStatic(object p0) { }

	// RVA: 0x1A223D0 Offset: 0x1A209D0 VA: 0x181A223D0
	internal static string UserDefinedOperatorMustNotBeVoid(object p0) { }

	// RVA: 0x1A21110 Offset: 0x1A1F710 VA: 0x181A21110
	internal static string CoercionOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x1A22220 Offset: 0x1A20820 VA: 0x181A22220
	internal static string UnaryOperatorNotDefined(object p0, object p1) { }

	// RVA: 0x1A20FF0 Offset: 0x1A1F5F0 VA: 0x181A20FF0
	internal static string BinaryOperatorNotDefined(object p0, object p1, object p2) { }

	// RVA: 0x1A22090 Offset: 0x1A20690 VA: 0x181A22090
	internal static string ReferenceEqualityNotDefined(object p0, object p1) { }

	// RVA: 0x1A21E80 Offset: 0x1A20480 VA: 0x181A21E80
	internal static string OperandTypesDoNotMatchParameters(object p0, object p1) { }

	// RVA: 0x1A21F20 Offset: 0x1A20520 VA: 0x181A21F20
	internal static string OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) { }

	// RVA: 0x1A228B0 Offset: 0x1A20EB0 VA: 0x181A228B0
	internal static string get_ConversionIsNotSupportedForArithmeticTypes() { }

	// RVA: 0x1A22520 Offset: 0x1A20B20 VA: 0x181A22520
	internal static string get_ArgumentMustBeArray() { }

	// RVA: 0x1A22550 Offset: 0x1A20B50 VA: 0x181A22550
	internal static string get_ArgumentMustBeBoolean() { }

	// RVA: 0x1A22580 Offset: 0x1A20B80 VA: 0x181A22580
	internal static string get_ArgumentMustBeFieldInfoOrPropertyInfoOrMethod() { }

	// RVA: 0x1A225B0 Offset: 0x1A20BB0 VA: 0x181A225B0
	internal static string get_ArgumentMustBeInstanceMember() { }

	// RVA: 0x1A225E0 Offset: 0x1A20BE0 VA: 0x181A225E0
	internal static string get_ArgumentMustBeInteger() { }

	// RVA: 0x1A224F0 Offset: 0x1A20AF0 VA: 0x181A224F0
	internal static string get_ArgumentMustBeArrayIndexType() { }

	// RVA: 0x1A22610 Offset: 0x1A20C10 VA: 0x181A22610
	internal static string get_ArgumentMustBeSingleDimensionalArrayType() { }

	// RVA: 0x1A22670 Offset: 0x1A20C70 VA: 0x181A22670
	internal static string get_ArgumentTypesMustMatch() { }

	// RVA: 0x1A210D0 Offset: 0x1A1F6D0 VA: 0x181A210D0
	internal static string CannotAutoInitializeValueTypeMemberThroughProperty(object p0) { }

	// RVA: 0x1A217F0 Offset: 0x1A1FDF0 VA: 0x181A217F0
	internal static string IncorrectTypeForTypeAs(object p0) { }

	// RVA: 0x1A22760 Offset: 0x1A20D60 VA: 0x181A22760
	internal static string get_CoalesceUsedOnNonNullType() { }

	// RVA: 0x1A21420 Offset: 0x1A1FA20 VA: 0x181A21420
	internal static string ExpressionTypeCannotInitializeArrayType(object p0, object p1) { }

	// RVA: 0x1A20FA0 Offset: 0x1A1F5A0 VA: 0x181A20FA0
	internal static string ArgumentTypeDoesNotMatchMember(object p0, object p1) { }

	// RVA: 0x1A20F50 Offset: 0x1A1F550 VA: 0x181A20F50
	internal static string ArgumentMemberNotDeclOnType(object p0, object p1) { }

	// RVA: 0x1A21620 Offset: 0x1A1FC20 VA: 0x181A21620
	internal static string ExpressionTypeDoesNotMatchReturn(object p0, object p1) { }

	// RVA: 0x1A21470 Offset: 0x1A1FA70 VA: 0x181A21470
	internal static string ExpressionTypeDoesNotMatchAssignment(object p0, object p1) { }

	// RVA: 0x1A21510 Offset: 0x1A1FB10 VA: 0x181A21510
	internal static string ExpressionTypeDoesNotMatchLabel(object p0, object p1) { }

	// RVA: 0x1A21670 Offset: 0x1A1FC70 VA: 0x181A21670
	internal static string ExpressionTypeNotInvocable(object p0) { }

	// RVA: 0x1A218A0 Offset: 0x1A1FEA0 VA: 0x181A218A0
	internal static string InstanceFieldNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1A216F0 Offset: 0x1A1FCF0 VA: 0x181A216F0
	internal static string FieldInfoNotDefinedForType(object p0, object p1, object p2) { }

	// RVA: 0x1A22A30 Offset: 0x1A21030 VA: 0x181A22A30
	internal static string get_IncorrectNumberOfIndexes() { }

	// RVA: 0x1A22A90 Offset: 0x1A21090 VA: 0x181A22A90
	internal static string get_IncorrectNumberOfLambdaDeclarationParameters() { }

	// RVA: 0x1A22AC0 Offset: 0x1A210C0 VA: 0x181A22AC0
	internal static string get_IncorrectNumberOfMembersForGivenConstructor() { }

	// RVA: 0x1A229D0 Offset: 0x1A20FD0 VA: 0x181A229D0
	internal static string get_IncorrectNumberOfArgumentsForMembers() { }

	// RVA: 0x1A22BE0 Offset: 0x1A211E0 VA: 0x181A22BE0
	internal static string get_LambdaTypeMustBeDerivedFromSystemDelegate() { }

	// RVA: 0x1A21B60 Offset: 0x1A20160 VA: 0x181A21B60
	internal static string MemberNotFieldOrProperty(object p0) { }

	// RVA: 0x1A21BA0 Offset: 0x1A201A0 VA: 0x181A21BA0
	internal static string MethodContainsGenericParameters(object p0) { }

	// RVA: 0x1A21BE0 Offset: 0x1A201E0 VA: 0x181A21BE0
	internal static string MethodIsGeneric(object p0) { }

	// RVA: 0x1A21C20 Offset: 0x1A20220 VA: 0x181A21C20
	internal static string MethodNotPropertyAccessor(object p0, object p1) { }

	// RVA: 0x1A22000 Offset: 0x1A20600 VA: 0x181A22000
	internal static string PropertyDoesNotHaveGetter(object p0) { }

	// RVA: 0x1A21FC0 Offset: 0x1A205C0 VA: 0x181A21FC0
	internal static string PropertyDoesNotHaveAccessor(object p0) { }

	// RVA: 0x1A21F70 Offset: 0x1A20570 VA: 0x181A21F70
	internal static string ParameterExpressionNotValidAsDelegate(object p0, object p1) { }

	// RVA: 0x1A22040 Offset: 0x1A20640 VA: 0x181A22040
	internal static string PropertyNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1A218F0 Offset: 0x1A1FEF0 VA: 0x181A218F0
	internal static string InstancePropertyNotDefinedForType(object p0, object p1) { }

	// RVA: 0x1A21830 Offset: 0x1A1FE30 VA: 0x181A21830
	internal static string InstanceAndMethodTypeMismatch(object p0, object p1, object p2) { }

	// RVA: 0x1A221A0 Offset: 0x1A207A0 VA: 0x181A221A0
	internal static string TypeMissingDefaultConstructor(object p0) { }

	// RVA: 0x1A22270 Offset: 0x1A20870 VA: 0x181A22270
	internal static string UnhandledBinary(object p0) { }

	// RVA: 0x1A222B0 Offset: 0x1A208B0 VA: 0x181A222B0
	internal static string UnhandledUnary(object p0) { }

	// RVA: 0x1A222F0 Offset: 0x1A208F0 VA: 0x181A222F0
	internal static string UserDefinedOpMustHaveConsistentTypes(object p0, object p1) { }

	// RVA: 0x1A22340 Offset: 0x1A20940 VA: 0x181A22340
	internal static string UserDefinedOpMustHaveValidReturnType(object p0, object p1) { }

	// RVA: 0x1A21B10 Offset: 0x1A20110 VA: 0x181A21B10
	internal static string LogicalOperatorMustHaveBooleanOperators(object p0, object p1) { }

	// RVA: 0x1A21C70 Offset: 0x1A20270 VA: 0x181A21C70
	internal static string MethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x1A21760 Offset: 0x1A1FD60 VA: 0x181A21760
	internal static string GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) { }

	// RVA: 0x1A21CC0 Offset: 0x1A202C0 VA: 0x181A21CC0
	internal static string MethodWithMoreThanOneMatch(object p0, object p1) { }

	// RVA: 0x1A224C0 Offset: 0x1A20AC0 VA: 0x181A224C0
	internal static string get_ArgumentCannotBeOfTypeVoid() { }

	// RVA: 0x1A21ED0 Offset: 0x1A204D0 VA: 0x181A21ED0
	internal static string OutOfRange(object p0, object p1) { }

	// RVA: 0x1A21A90 Offset: 0x1A20090 VA: 0x181A21A90
	internal static string LabelTargetAlreadyDefined(object p0) { }

	// RVA: 0x1A21AD0 Offset: 0x1A200D0 VA: 0x181A21AD0
	internal static string LabelTargetUndefined(object p0) { }

	// RVA: 0x1A22880 Offset: 0x1A20E80 VA: 0x181A22880
	internal static string get_ControlCannotLeaveFinally() { }

	// RVA: 0x1A22850 Offset: 0x1A20E50 VA: 0x181A22850
	internal static string get_ControlCannotLeaveFilterTest() { }

	// RVA: 0x1A20ED0 Offset: 0x1A1F4D0 VA: 0x181A20ED0
	internal static string AmbiguousJump(object p0) { }

	// RVA: 0x1A22820 Offset: 0x1A20E20 VA: 0x181A22820
	internal static string get_ControlCannotEnterTry() { }

	// RVA: 0x1A227F0 Offset: 0x1A20DF0 VA: 0x181A227F0
	internal static string get_ControlCannotEnterExpression() { }

	// RVA: 0x1A21E40 Offset: 0x1A20440 VA: 0x181A21E40
	internal static string NonLocalJumpWithValue(object p0) { }

	// RVA: 0x1A21940 Offset: 0x1A1FF40 VA: 0x181A21940
	internal static string InvalidLvalue(object p0) { }

	// RVA: 0x1A22EE0 Offset: 0x1A214E0 VA: 0x181A22EE0
	internal static string get_RethrowRequiresCatch() { }

	// RVA: 0x1A21D80 Offset: 0x1A20380 VA: 0x181A21D80
	internal static string MustRewriteToSameNode(object p0, object p1, object p2) { }

	// RVA: 0x1A21D10 Offset: 0x1A20310 VA: 0x181A21D10
	internal static string MustRewriteChildToSameType(object p0, object p1, object p2) { }

	// RVA: 0x1A21DF0 Offset: 0x1A203F0 VA: 0x181A21DF0
	internal static string MustRewriteWithoutMethod(object p0, object p1) { }

	// RVA: 0x1A22CD0 Offset: 0x1A212D0 VA: 0x181A22CD0
	internal static string get_NonStaticConstructorRequired() { }

	// RVA: 0x1A22CA0 Offset: 0x1A212A0 VA: 0x181A22CA0
	internal static string get_NonAbstractConstructorRequired() { }

	// RVA: 0x1A22910 Offset: 0x1A20F10 VA: 0x181A22910
	internal static string get_ExpressionMustBeReadable() { }

	// RVA: 0x1A214C0 Offset: 0x1A1FAC0 VA: 0x181A214C0
	internal static string ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1) { }

	// RVA: 0x1A228E0 Offset: 0x1A20EE0 VA: 0x181A228E0
	internal static string get_EnumerationIsDone() { }

	// RVA: 0x1A22120 Offset: 0x1A20720 VA: 0x181A22120
	internal static string TypeContainsGenericParameters(object p0) { }

	// RVA: 0x1A22160 Offset: 0x1A20760 VA: 0x181A22160
	internal static string TypeIsGeneric(object p0) { }

	// RVA: 0x1A22B20 Offset: 0x1A21120 VA: 0x181A22B20
	internal static string get_InvalidArgumentValue() { }

	// RVA: 0x1A219C0 Offset: 0x1A1FFC0 VA: 0x181A219C0
	internal static string InvalidNullValue(object p0) { }

	// RVA: 0x1A21A00 Offset: 0x1A20000 VA: 0x181A21A00
	internal static string InvalidObjectType(object p0, object p1) { }

	// RVA: 0x1A21560 Offset: 0x1A1FB60 VA: 0x181A21560
	internal static string ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2) { }

	// RVA: 0x1A215D0 Offset: 0x1A1FBD0 VA: 0x181A215D0
	internal static string ExpressionTypeDoesNotMatchParameter(object p0, object p1) { }

	// RVA: 0x1A217B0 Offset: 0x1A1FDB0 VA: 0x181A217B0
	internal static string IncorrectNumberOfMethodCallArguments(object p0) { }

	// RVA: 0x1A22A60 Offset: 0x1A21060 VA: 0x181A22A60
	internal static string get_IncorrectNumberOfLambdaArguments() { }

	// RVA: 0x1A22A00 Offset: 0x1A21000 VA: 0x181A22A00
	internal static string get_IncorrectNumberOfConstructorArguments() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.SwitchCaseProxy))]
public sealed class SwitchCase // TypeDefIndex: 10879
{
	// Fields
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <TestValues>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x18

	// Properties
	public ReadOnlyCollection<Expression> TestValues { get; }
	public Expression Body { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public ReadOnlyCollection<Expression> get_TestValues() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Expression get_Body() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.SwitchExpressionProxy))]
public sealed class SwitchExpression : Expression // TypeDefIndex: 10880
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <SwitchValue>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<SwitchCase> <Cases>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <DefaultBody>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly MethodInfo <Comparison>k__BackingField; // 0x28

	// Properties
	public Expression SwitchValue { get; }
	public ReadOnlyCollection<SwitchCase> Cases { get; }
	public Expression DefaultBody { get; }
	public MethodInfo Comparison { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public Expression get_SwitchValue() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public ReadOnlyCollection<SwitchCase> get_Cases() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Expression get_DefaultBody() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public MethodInfo get_Comparison() { }
}

// Namespace: System.Linq.Expressions
public class SymbolDocumentInfo // TypeDefIndex: 10881
{
	// Fields
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x10
	internal static readonly Guid DocumentType_Text; // 0x0

	// Properties
	public string FileName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580
	public string get_FileName() { }

	// RVA: 0x1A23030 Offset: 0x1A21630 VA: 0x181A23030
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.TryExpressionProxy))]
public sealed class TryExpression : Expression // TypeDefIndex: 10882
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x1A235A0 Offset: 0x1A21BA0 VA: 0x181A235A0
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1A23670 Offset: 0x1A21C70 VA: 0x181A23670 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public Expression get_Finally() { }

	[CompilerGenerated]
	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	public Expression get_Fault() { }

	// RVA: 0x1A23470 Offset: 0x1A21A70 VA: 0x181A23470 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A234A0 Offset: 0x1A21AA0 VA: 0x181A234A0
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.TypeBinaryExpressionProxy))]
public sealed class TypeBinaryExpression : Expression // TypeDefIndex: 10883
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Type <TypeOperand>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Expression { get; }
	public Type TypeOperand { get; }

	// Methods

	// RVA: 0x1A23770 Offset: 0x1A21D70 VA: 0x181A23770
	internal void .ctor(Expression expression, Type typeOperand, ExpressionType nodeType) { }

	// RVA: 0x1A05C10 Offset: 0x1A04210 VA: 0x181A05C10 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	public Expression get_Expression() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Type get_TypeOperand() { }

	// RVA: 0x1A23680 Offset: 0x1A21C80 VA: 0x181A23680 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A236B0 Offset: 0x1A21CB0 VA: 0x181A236B0
	public TypeBinaryExpression Update(Expression expression) { }
}

// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.UnaryExpressionProxy))]
public sealed class UnaryExpression : Expression // TypeDefIndex: 10884
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x1A24F30 Offset: 0x1A23530 VA: 0x181A24F30
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGenerated]
	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public Expression get_Operand() { }

	[CompilerGenerated]
	// RVA: 0x397CD0 Offset: 0x3962D0 VA: 0x180397CD0
	public MethodInfo get_Method() { }

	// RVA: 0x1A25090 Offset: 0x1A23690 VA: 0x181A25090
	public bool get_IsLifted() { }

	// RVA: 0x1A25010 Offset: 0x1A23610 VA: 0x181A25010
	public bool get_IsLiftedToNull() { }

	// RVA: 0x1A23B50 Offset: 0x1A22150 VA: 0x181A23B50 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1A24FE0 Offset: 0x1A235E0 VA: 0x181A24FE0 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x1A24DE0 Offset: 0x1A233E0 VA: 0x181A24DE0 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x1A25300 Offset: 0x1A23900 VA: 0x181A25300
	private bool get_IsPrefix() { }

	// RVA: 0x1A23B80 Offset: 0x1A22180 VA: 0x181A23B80
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x1A24A90 Offset: 0x1A23090 VA: 0x181A24A90
	private Expression ReduceVariable() { }

	// RVA: 0x1A24470 Offset: 0x1A22A70 VA: 0x181A24470
	private Expression ReduceMember() { }

	// RVA: 0x1A23CD0 Offset: 0x1A222D0 VA: 0x181A23CD0
	private Expression ReduceIndex() { }

	// RVA: 0x1A24E60 Offset: 0x1A23460 VA: 0x181A24E60
	public UnaryExpression Update(Expression operand) { }
}

// Namespace: System.Linq.Expressions
internal static class Utils // TypeDefIndex: 10885
{
	// Fields
	public static readonly object BoxedFalse; // 0x0
	public static readonly object BoxedTrue; // 0x8
	public static readonly object BoxedIntM1; // 0x10
	public static readonly object BoxedInt0; // 0x18
	public static readonly object BoxedInt1; // 0x20
	public static readonly object BoxedInt2; // 0x28
	public static readonly object BoxedInt3; // 0x30
	public static readonly object BoxedDefaultSByte; // 0x38
	public static readonly object BoxedDefaultChar; // 0x40
	public static readonly object BoxedDefaultInt16; // 0x48
	public static readonly object BoxedDefaultInt64; // 0x50
	public static readonly object BoxedDefaultByte; // 0x58
	public static readonly object BoxedDefaultUInt16; // 0x60
	public static readonly object BoxedDefaultUInt32; // 0x68
	public static readonly object BoxedDefaultUInt64; // 0x70
	public static readonly object BoxedDefaultSingle; // 0x78
	public static readonly object BoxedDefaultDouble; // 0x80
	public static readonly object BoxedDefaultDecimal; // 0x88
	public static readonly object BoxedDefaultDateTime; // 0x90
	private static readonly ConstantExpression s_true; // 0x98
	private static readonly ConstantExpression s_false; // 0xA0
	private static readonly ConstantExpression s_m1; // 0xA8
	private static readonly ConstantExpression s_0; // 0xB0
	private static readonly ConstantExpression s_1; // 0xB8
	private static readonly ConstantExpression s_2; // 0xC0
	private static readonly ConstantExpression s_3; // 0xC8
	public static readonly DefaultExpression Empty; // 0xD0
	public static readonly ConstantExpression Null; // 0xD8

	// Methods

	// RVA: 0x1A254F0 Offset: 0x1A23AF0 VA: 0x181A254F0
	public static ConstantExpression Constant(bool value) { }

	// RVA: 0x1A25350 Offset: 0x1A23950 VA: 0x181A25350
	public static ConstantExpression Constant(int value) { }

	// RVA: 0x1A25580 Offset: 0x1A23B80 VA: 0x181A25580
	private static void .cctor() { }
}

