// Namespace: System.IO.Enumeration
public abstract class FileSystemEnumerator<TResult> : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 1650
{
	// Fields
	private readonly string _originalRootDirectory; // 0x0
	private readonly string _rootDirectory; // 0x0
	private readonly EnumerationOptions _options; // 0x0
	private readonly object _lock; // 0x0
	private Interop.NtDll.FILE_FULL_DIR_INFORMATION* _entry; // 0x0
	private TResult _current; // 0x0
	private IntPtr _buffer; // 0x0
	private int _bufferLength; // 0x0
	private IntPtr _directoryHandle; // 0x0
	private string _currentPath; // 0x0
	private bool _lastEntryFound; // 0x0
	[TupleElementNames(new[] { "Handle", "Path" })]
	private Queue<ValueTuple<IntPtr, string>> _pending; // 0x0

	// Properties
	public TResult Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	private bool GetDataUWP() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100AB10 Offset: 0x1009110 VA: 0x18100AB10
	|-FileSystemEnumerator<object>.GetDataUWP
	|
	|-RVA: 0x100A950 Offset: 0x1008F50 VA: 0x18100A950
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.GetDataUWP
	*/

	// RVA: -1 Offset: -1
	private IntPtr CreateRelativeDirectoryHandleUWP(ReadOnlySpan<char> relativePath, string fullPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1009D30 Offset: 0x1008330 VA: 0x181009D30
	|-FileSystemEnumerator<object>.CreateRelativeDirectoryHandleUWP
	|
	|-RVA: 0x1009D00 Offset: 0x1008300 VA: 0x181009D00
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CreateRelativeDirectoryHandleUWP
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string directory, EnumerationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100CE30 Offset: 0x100B430 VA: 0x18100CE30
	|-FileSystemEnumerator<object>..ctor
	|
	|-RVA: 0x100C7F0 Offset: 0x100ADF0 VA: 0x18100C7F0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CloseDirectoryHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10097A0 Offset: 0x1007DA0 VA: 0x1810097A0
	|-FileSystemEnumerator<object>.CloseDirectoryHandle
	|
	|-RVA: 0x10097D0 Offset: 0x1007DD0 VA: 0x1810097D0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CloseDirectoryHandle
	*/

	// RVA: -1 Offset: -1
	private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1009910 Offset: 0x1007F10 VA: 0x181009910
	|-FileSystemEnumerator<object>.CreateDirectoryHandle
	|
	|-RVA: 0x1009B10 Offset: 0x1008110 VA: 0x181009B10
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CreateDirectoryHandle
	*/

	// RVA: -1 Offset: -1
	private bool ContinueOnDirectoryError(int error, bool ignoreNotFound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10098B0 Offset: 0x1007EB0 VA: 0x1810098B0
	|-FileSystemEnumerator<object>.ContinueOnDirectoryError
	|
	|-RVA: 0x1009820 Offset: 0x1007E20 VA: 0x181009820
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ContinueOnDirectoryError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100BE80 Offset: 0x100A480 VA: 0x18100BE80
	|-FileSystemEnumerator<object>.MoveNext
	|
	|-RVA: 0x100B480 Offset: 0x1009A80 VA: 0x18100B480
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void FindNextEntry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100A6C0 Offset: 0x1008CC0 VA: 0x18100A6C0
	|-FileSystemEnumerator<object>.FindNextEntry
	|
	|-RVA: 0x100A800 Offset: 0x1008E00 VA: 0x18100A800
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.FindNextEntry
	*/

	// RVA: -1 Offset: -1
	private bool DequeueNextDirectory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100A130 Offset: 0x1008730 VA: 0x18100A130
	|-FileSystemEnumerator<object>.DequeueNextDirectory
	|
	|-RVA: 0x1009F80 Offset: 0x1008580 VA: 0x181009F80
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.DequeueNextDirectory
	*/

	// RVA: -1 Offset: -1
	private void InternalDispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100B2C0 Offset: 0x10098C0 VA: 0x18100B2C0
	|-FileSystemEnumerator<object>.InternalDispose
	|
	|-RVA: 0x100AF30 Offset: 0x1009530 VA: 0x18100AF30
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.InternalDispose
	*/

	// RVA: -1 Offset: -1
	private bool GetData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100AC30 Offset: 0x1009230 VA: 0x18100AC30
	|-FileSystemEnumerator<object>.GetData
	|
	|-RVA: 0x100AD70 Offset: 0x1009370 VA: 0x18100AD70
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.GetData
	*/

	// RVA: -1 Offset: -1
	private IntPtr CreateRelativeDirectoryHandle(ReadOnlySpan<char> relativePath, string fullPath) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1009E60 Offset: 0x1008460 VA: 0x181009E60
	|-FileSystemEnumerator<object>.CreateRelativeDirectoryHandle
	|
	|-RVA: 0x1009D50 Offset: 0x1008350 VA: 0x181009D50
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CreateRelativeDirectoryHandle
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-FileSystemEnumerator<object>.ShouldIncludeEntry
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ShouldIncludeEntry
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0
	|-FileSystemEnumerator<object>.ShouldRecurseIntoEntry
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ShouldRecurseIntoEntry
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract TResult TransformEntry(ref FileSystemEntry entry);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.TransformEntry
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void OnDirectoryFinished(ReadOnlySpan<char> directory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-FileSystemEnumerator<object>.OnDirectoryFinished
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.OnDirectoryFinished
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual bool ContinueOnError(int error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0
	|-FileSystemEnumerator<object>.ContinueOnError
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ContinueOnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TResult get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	|-FileSystemEnumerator<object>.get_Current
	|
	|-RVA: 0x100D150 Offset: 0x100B750 VA: 0x18100D150
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	|-FileSystemEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x100C740 Offset: 0x100AD40 VA: 0x18100C740
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	private void DirectoryFinished() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100A350 Offset: 0x1008950 VA: 0x18100A350
	|-FileSystemEnumerator<object>.DirectoryFinished
	|
	|-RVA: 0x100A1C0 Offset: 0x10087C0 VA: 0x18100A1C0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.DirectoryFinished
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x862FE0 Offset: 0x8615E0 VA: 0x180862FE0
	|-FileSystemEnumerator<object>.Reset
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100A520 Offset: 0x1008B20 VA: 0x18100A520
	|-FileSystemEnumerator<object>.Dispose
	|
	|-RVA: 0x100A4A0 Offset: 0x1008AA0 VA: 0x18100A4A0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x346280 Offset: 0x344880 VA: 0x180346280
	|-FileSystemEnumerator<object>.Dispose
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100A640 Offset: 0x1008C40 VA: 0x18100A640
	|-FileSystemEnumerator<object>.Finalize
	|
	|-RVA: 0x100A5A0 Offset: 0x1008BA0 VA: 0x18100A5A0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Finalize
	*/
}

// Namespace: System.IO.Enumeration
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct FileSystemEntry // TypeDefIndex: 1651
{
	// Fields
	internal Interop.NtDll.FILE_FULL_DIR_INFORMATION* _info; // 0x0
	[CompilerGenerated]
	private ReadOnlySpan<char> <Directory>k__BackingField; // 0x8
	[CompilerGenerated]
	private ReadOnlySpan<char> <RootDirectory>k__BackingField; // 0x18
	[CompilerGenerated]
	private ReadOnlySpan<char> <OriginalRootDirectory>k__BackingField; // 0x28

	// Properties
	public ReadOnlySpan<char> Directory { get; set; }
	public ReadOnlySpan<char> RootDirectory { get; set; }
	public ReadOnlySpan<char> OriginalRootDirectory { get; set; }
	public ReadOnlySpan<char> FileName { get; }
	public FileAttributes Attributes { get; }
	public bool IsDirectory { get; }

	// Methods

	// RVA: 0x14DA8A0 Offset: 0x14D8EA0 VA: 0x1814DA8A0
	internal static void Initialize(ref FileSystemEntry entry, Interop.NtDll.FILE_FULL_DIR_INFORMATION* info, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1105D70 Offset: 0x1104370 VA: 0x181105D70
	public ReadOnlySpan<char> get_Directory() { }

	[CompilerGenerated]
	// RVA: 0x14DAB30 Offset: 0x14D9130 VA: 0x1814DAB30
	private void set_Directory(ReadOnlySpan<char> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x8641A0 Offset: 0x8627A0 VA: 0x1808641A0
	public ReadOnlySpan<char> get_RootDirectory() { }

	[CompilerGenerated]
	// RVA: 0x14DAB50 Offset: 0x14D9150 VA: 0x1814DAB50
	private void set_RootDirectory(ReadOnlySpan<char> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1116670 Offset: 0x1114C70 VA: 0x181116670
	public ReadOnlySpan<char> get_OriginalRootDirectory() { }

	[CompilerGenerated]
	// RVA: 0x14DAB40 Offset: 0x14D9140 VA: 0x1814DAB40
	private void set_OriginalRootDirectory(ReadOnlySpan<char> value) { }

	// RVA: 0x14DAAE0 Offset: 0x14D90E0 VA: 0x1814DAAE0
	public ReadOnlySpan<char> get_FileName() { }

	// RVA: 0x14DAAC0 Offset: 0x14D90C0 VA: 0x1814DAAC0
	public FileAttributes get_Attributes() { }

	// RVA: 0x14DAB10 Offset: 0x14D9110 VA: 0x1814DAB10
	public bool get_IsDirectory() { }

	// RVA: 0x14DA8C0 Offset: 0x14D8EC0 VA: 0x1814DA8C0
	public string ToSpecifiedFullPath() { }
}

// Namespace: System.IO.Enumeration
public class FileSystemEnumerable<TResult> : IEnumerable<TResult>, IEnumerable // TypeDefIndex: 1655
{
	// Fields
	private FileSystemEnumerable.DelegateEnumerator<TResult> _enumerator; // 0x0
	private readonly FileSystemEnumerable.FindTransform<TResult> _transform; // 0x0
	private readonly EnumerationOptions _options; // 0x0
	private readonly string _directory; // 0x0
	[CompilerGenerated]
	private FileSystemEnumerable.FindPredicate<TResult> <ShouldIncludePredicate>k__BackingField; // 0x0
	[CompilerGenerated]
	private FileSystemEnumerable.FindPredicate<TResult> <ShouldRecursePredicate>k__BackingField; // 0x0

	// Properties
	public FileSystemEnumerable.FindPredicate<TResult> ShouldIncludePredicate { get; set; }
	public FileSystemEnumerable.FindPredicate<TResult> ShouldRecursePredicate { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string directory, FileSystemEnumerable.FindTransform<TResult> transform, EnumerationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10095F0 Offset: 0x1007BF0 VA: 0x1810095F0
	|-FileSystemEnumerable<object>..ctor
	|
	|-RVA: 0x1009440 Offset: 0x1007A40 VA: 0x181009440
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public FileSystemEnumerable.FindPredicate<TResult> get_ShouldIncludePredicate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	|-FileSystemEnumerable<object>.get_ShouldIncludePredicate
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.get_ShouldIncludePredicate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_ShouldIncludePredicate(FileSystemEnumerable.FindPredicate<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	|-FileSystemEnumerable<object>.set_ShouldIncludePredicate
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.set_ShouldIncludePredicate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public FileSystemEnumerable.FindPredicate<TResult> get_ShouldRecursePredicate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3A6750 Offset: 0x3A4D50 VA: 0x1803A6750
	|-FileSystemEnumerable<object>.get_ShouldRecursePredicate
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.get_ShouldRecursePredicate
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TResult> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1009300 Offset: 0x1007900 VA: 0x181009300
	|-FileSystemEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x1009280 Offset: 0x1007880 VA: 0x181009280
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1009380 Offset: 0x1007980 VA: 0x181009380
	|-FileSystemEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1009410 Offset: 0x1007A10 VA: 0x181009410
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.IO.Enumeration
internal static class FileSystemEnumerableFactory // TypeDefIndex: 1660
{
	// Fields
	private static readonly char[] s_unixEscapeChars; // 0x0

	// Methods

	// RVA: 0x14DAE20 Offset: 0x14D9420 VA: 0x1814DAE20
	internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options) { }

	// RVA: 0x14DAB60 Offset: 0x14D9160 VA: 0x1814DAB60
	private static bool MatchesPattern(string expression, ReadOnlySpan<char> name, EnumerationOptions options) { }

	// RVA: 0x14DB850 Offset: 0x14D9E50 VA: 0x1814DB850
	internal static IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x14DB430 Offset: 0x14D9A30 VA: 0x1814DB430
	internal static IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x14DB640 Offset: 0x14D9C40 VA: 0x1814DB640
	internal static IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x14DBA60 Offset: 0x14DA060 VA: 0x1814DBA60
	private static void .cctor() { }
}

// Namespace: System.IO.Enumeration
public static class FileSystemName // TypeDefIndex: 1661
{
	// Fields
	private static readonly char[] s_wildcardChars; // 0x0
	private static readonly char[] s_simpleWildcardChars; // 0x8

	// Methods

	// RVA: 0x14DC4E0 Offset: 0x14DAAE0 VA: 0x1814DC4E0
	public static string TranslateWin32Expression(string expression) { }

	// RVA: 0x14DC450 Offset: 0x14DAA50 VA: 0x1814DC450
	public static bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = True) { }

	// RVA: 0x14DC3C0 Offset: 0x14DA9C0 VA: 0x1814DC3C0
	public static bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = True) { }

	// RVA: 0x14DBAF0 Offset: 0x14DA0F0 VA: 0x1814DBAF0
	private static bool MatchPattern(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards) { }

	// RVA: 0x14DC810 Offset: 0x14DAE10 VA: 0x1814DC810
	private static void .cctor() { }
}

