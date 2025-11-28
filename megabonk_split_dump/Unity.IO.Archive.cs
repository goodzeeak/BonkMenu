// Namespace: Unity.IO.Archive
[RequiredByNativeCode]
public enum ArchiveStatus // TypeDefIndex: 9447
{
	// Fields
	public int value__; // 0x0
	public const ArchiveStatus InProgress = 0;
	public const ArchiveStatus Complete = 1;
	public const ArchiveStatus Failed = 2;
}

// Namespace: Unity.IO.Archive
[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
[RequiredByNativeCode]
public struct ArchiveFileInfo // TypeDefIndex: 9448
{
	// Fields
	public string Filename; // 0x0
	public ulong FileSize; // 0x8
}

// Namespace: Unity.IO.Archive
[RequiredByNativeCode]
[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
public struct ArchiveHandle // TypeDefIndex: 9449
{
	// Fields
	internal ulong Handle; // 0x0
}

// Namespace: Unity.IO.Archive
[RequiredByNativeCode]
[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
[StaticAccessor("GetManagedArchiveSystem()", 0)]
public static class ArchiveFileInterface // TypeDefIndex: 9450
{}

