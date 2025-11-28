// Namespace: System.Text.RegularExpressions
public class Capture // TypeDefIndex: 7436
{
	// Fields
	[CompilerGenerated]
	private int <Index>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Length>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <Text>k__BackingField; // 0x18

	// Properties
	public int Index { get; set; }
	public int Length { get; set; }
	internal string Text { get; set; }
	public string Value { get; }

	// Methods

	// RVA: 0x1DE2CF0 Offset: 0x1DE12F0 VA: 0x181DE2CF0
	internal void .ctor(string text, int index, int length) { }

	[CompilerGenerated]
	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x377C60 Offset: 0x376260 VA: 0x180377C60
	internal void set_Index(int value) { }

	[CompilerGenerated]
	// RVA: 0x4E5B30 Offset: 0x4E4130 VA: 0x1804E5B30
	public int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x9A6AE0 Offset: 0x9A50E0 VA: 0x1809A6AE0
	internal void set_Length(int value) { }

	[CompilerGenerated]
	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790
	internal string get_Text() { }

	[CompilerGenerated]
	// RVA: 0x377C70 Offset: 0x376270 VA: 0x180377C70
	internal void set_Text(string value) { }

	// RVA: 0x1DE2CC0 Offset: 0x1DE12C0 VA: 0x181DE2CC0
	public string get_Value() { }

	// RVA: 0x1DE2CC0 Offset: 0x1DE12C0 VA: 0x181DE2CC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DE2B70 Offset: 0x1DE1170 VA: 0x181DE2B70
	internal ReadOnlySpan<char> GetLeftSubstring() { }

	// RVA: 0x1DE2C10 Offset: 0x1DE1210 VA: 0x181DE2C10
	internal ReadOnlySpan<char> GetRightSubstring() { }
}

// Namespace: System.Text.RegularExpressions
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Capture>))]
public class CaptureCollection : IList<Capture>, ICollection<Capture>, IEnumerable<Capture>, IEnumerable, IReadOnlyList<Capture>, IReadOnlyCollection<Capture>, IList, ICollection // TypeDefIndex: 7438
{
	// Fields
	private readonly Group _group; // 0x10
	private readonly int _capcount; // 0x18
	private Capture[] _captures; // 0x20

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public Capture Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1DE2B20 Offset: 0x1DE1120 VA: 0x181DE2B20
	internal void .ctor(Group group) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0 Slot: 32
	public int get_Count() { }

	// RVA: 0x1DE26D0 Offset: 0x1DE0CD0 VA: 0x181DE26D0 Slot: 18
	public Capture get_Item(int i) { }

	// RVA: 0x1DE2350 Offset: 0x1DE0950 VA: 0x181DE2350 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1DE2510 Offset: 0x1DE0B10 VA: 0x181DE2510 Slot: 16
	private IEnumerator<Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() { }

	// RVA: 0x1DE2110 Offset: 0x1DE0710 VA: 0x181DE2110
	private Capture GetCapture(int i) { }

	// RVA: 0x1DE1F80 Offset: 0x1DE0580 VA: 0x181DE1F80
	internal void ForceInitialized() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x1DE1EC0 Offset: 0x1DE04C0 VA: 0x181DE1EC0 Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1DE1CF0 Offset: 0x1DE02F0 VA: 0x181DE1CF0 Slot: 14
	public void CopyTo(Capture[] array, int arrayIndex) { }

	// RVA: 0x1DE2580 Offset: 0x1DE0B80 VA: 0x181DE2580 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(Capture item) { }

	// RVA: 0x1DE2630 Offset: 0x1DE0C30 VA: 0x181DE2630 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, Capture item) { }

	// RVA: 0x1DE2680 Offset: 0x1DE0C80 VA: 0x181DE2680 Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index) { }

	// RVA: 0x1DE26D0 Offset: 0x1DE0CD0 VA: 0x181DE26D0 Slot: 4
	private Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index) { }

	// RVA: 0x1DE26E0 Offset: 0x1DE0CE0 VA: 0x181DE26E0 Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, Capture value) { }

	// RVA: 0x1DE23C0 Offset: 0x1DE09C0 VA: 0x181DE23C0 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(Capture item) { }

	// RVA: 0x1DE2410 Offset: 0x1DE0A10 VA: 0x181DE2410 Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() { }

	// RVA: 0x1DE2460 Offset: 0x1DE0A60 VA: 0x181DE2460 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(Capture item) { }

	// RVA: 0x1DE24C0 Offset: 0x1DE0AC0 VA: 0x181DE24C0 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(Capture item) { }

	// RVA: 0x1DE2730 Offset: 0x1DE0D30 VA: 0x181DE2730 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1DE2780 Offset: 0x1DE0D80 VA: 0x181DE2780 Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1DE27D0 Offset: 0x1DE0DD0 VA: 0x181DE27D0 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1DE2910 Offset: 0x1DE0F10 VA: 0x181DE2910 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1DE29E0 Offset: 0x1DE0FE0 VA: 0x181DE29E0 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1DE2A80 Offset: 0x1DE1080 VA: 0x181DE2A80 Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1DE2A30 Offset: 0x1DE1030 VA: 0x181DE2A30 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1DE26D0 Offset: 0x1DE0CD0 VA: 0x181DE26D0 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1DE2AD0 Offset: 0x1DE10D0 VA: 0x181DE2AD0 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class CollectionDebuggerProxy<T> // TypeDefIndex: 7439
{}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class Group : Capture // TypeDefIndex: 7440
{
	// Fields
	internal static readonly Group s_emptyGroup; // 0x0
	internal readonly int[] _caps; // 0x20
	internal int _capcount; // 0x28
	internal CaptureCollection _capcoll; // 0x30
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x38

	// Properties
	public bool Success { get; }
	public CaptureCollection Captures { get; }

	// Methods

	// RVA: 0x1DE54E0 Offset: 0x1DE3AE0 VA: 0x181DE54E0
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x1DE5640 Offset: 0x1DE3C40 VA: 0x181DE5640
	public bool get_Success() { }

	// RVA: 0x1DE55B0 Offset: 0x1DE3BB0 VA: 0x181DE55B0
	public CaptureCollection get_Captures() { }

	// RVA: 0x1DE5360 Offset: 0x1DE3960 VA: 0x181DE5360
	private static void .cctor() { }

	// RVA: 0x1DE54B0 Offset: 0x1DE3AB0 VA: 0x181DE54B0
	internal void .ctor() { }
}

// Namespace: System.Text.RegularExpressions
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Group>))]
[Serializable]
public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection // TypeDefIndex: 7442
{
	// Fields
	private readonly Match _match; // 0x10
	private readonly Hashtable _captureMap; // 0x18
	private Group[] _groups; // 0x20

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public Group Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x3DDF50 Offset: 0x3DC550 VA: 0x1803DDF50
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x1DE5330 Offset: 0x1DE3930 VA: 0x181DE5330 Slot: 32
	public int get_Count() { }

	// RVA: 0x1DE4EB0 Offset: 0x1DE34B0 VA: 0x181DE4EB0 Slot: 18
	public Group get_Item(int groupnum) { }

	// RVA: 0x1DE42E0 Offset: 0x1DE28E0 VA: 0x181DE42E0 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1DE4CD0 Offset: 0x1DE32D0 VA: 0x181DE4CD0 Slot: 16
	private IEnumerator<Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	// RVA: 0x1DE4700 Offset: 0x1DE2D00 VA: 0x181DE4700
	private Group GetGroup(int groupnum) { }

	// RVA: 0x1DE4350 Offset: 0x1DE2950 VA: 0x181DE4350
	private Group GetGroupImpl(int groupnum) { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x39A580 Offset: 0x398B80 VA: 0x18039A580 Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x1DE4010 Offset: 0x1DE2610 VA: 0x181DE4010 Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1DE40F0 Offset: 0x1DE26F0 VA: 0x181DE40F0 Slot: 14
	public void CopyTo(Group[] array, int arrayIndex) { }

	// RVA: 0x1DE4D40 Offset: 0x1DE3340 VA: 0x181DE4D40 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	// RVA: 0x1DE4E10 Offset: 0x1DE3410 VA: 0x181DE4E10 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	// RVA: 0x1DE4E60 Offset: 0x1DE3460 VA: 0x181DE4E60 Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	// RVA: 0x1DE4EB0 Offset: 0x1DE34B0 VA: 0x181DE4EB0 Slot: 4
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	// RVA: 0x1DE4EC0 Offset: 0x1DE34C0 VA: 0x181DE4EC0 Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	// RVA: 0x1DE4B80 Offset: 0x1DE3180 VA: 0x181DE4B80 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	// RVA: 0x1DE4BD0 Offset: 0x1DE31D0 VA: 0x181DE4BD0 Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	// RVA: 0x1DE4C20 Offset: 0x1DE3220 VA: 0x181DE4C20 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	// RVA: 0x1DE4C80 Offset: 0x1DE3280 VA: 0x181DE4C80 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	// RVA: 0x1DE4F10 Offset: 0x1DE3510 VA: 0x181DE4F10 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1DE4F60 Offset: 0x1DE3560 VA: 0x181DE4F60 Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1DE4FB0 Offset: 0x1DE35B0 VA: 0x181DE4FB0 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1DE50F0 Offset: 0x1DE36F0 VA: 0x181DE50F0 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1DE51C0 Offset: 0x1DE37C0 VA: 0x181DE51C0 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1DE5260 Offset: 0x1DE3860 VA: 0x181DE5260 Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1DE5210 Offset: 0x1DE3810 VA: 0x181DE5210 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1DE4EB0 Offset: 0x1DE34B0 VA: 0x181DE4EB0 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1DE52B0 Offset: 0x1DE38B0 VA: 0x181DE52B0 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1DE5300 Offset: 0x1DE3900 VA: 0x181DE5300
	internal void .ctor() { }
}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class Match : Group // TypeDefIndex: 7443
{
	// Fields
	internal GroupCollection _groupcoll; // 0x40
	internal Regex _regex; // 0x48
	internal int _textbeg; // 0x50
	internal int _textpos; // 0x54
	internal int _textend; // 0x58
	internal int _textstart; // 0x5C
	internal int[][] _matches; // 0x60
	internal int[] _matchcount; // 0x68
	internal bool _balancing; // 0x70
	[CompilerGenerated]
	private static readonly Match <Empty>k__BackingField; // 0x0

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x1DE7280 Offset: 0x1DE5880 VA: 0x181DE7280
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	[CompilerGenerated]
	// RVA: 0x1DE7440 Offset: 0x1DE5A40 VA: 0x181DE7440
	public static Match get_Empty() { }

	// RVA: 0x1DE6F90 Offset: 0x1DE5590 VA: 0x181DE6F90 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x1DE7490 Offset: 0x1DE5A90 VA: 0x181DE7490 Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x1DE6F10 Offset: 0x1DE5510 VA: 0x181DE6F10
	public Match NextMatch() { }

	// RVA: 0x1DE6B60 Offset: 0x1DE5160 VA: 0x181DE6B60 Slot: 6
	internal virtual ReadOnlySpan<char> GroupToStringImpl(int groupnum) { }

	// RVA: 0x1DE6DA0 Offset: 0x1DE53A0 VA: 0x181DE6DA0
	internal ReadOnlySpan<char> LastGroupToStringImpl() { }

	// RVA: 0x1DE67F0 Offset: 0x1DE4DF0 VA: 0x181DE67F0 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x1DE69F0 Offset: 0x1DE4FF0 VA: 0x181DE69F0 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x1DE6F60 Offset: 0x1DE5560 VA: 0x181DE6F60 Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x1DE6D20 Offset: 0x1DE5320 VA: 0x181DE6D20 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x1DE6DF0 Offset: 0x1DE53F0 VA: 0x181DE6DF0 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x1DE6E80 Offset: 0x1DE5480 VA: 0x181DE6E80 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x1DE7040 Offset: 0x1DE5640 VA: 0x181DE7040 Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x1DE71E0 Offset: 0x1DE57E0 VA: 0x181DE71E0
	private static void .cctor() { }

	// RVA: 0x1DE7410 Offset: 0x1DE5A10 VA: 0x181DE7410
	internal void .ctor() { }
}

// Namespace: System.Text.RegularExpressions
internal class MatchSparse : Match // TypeDefIndex: 7444
{
	// Fields
	internal readonly Hashtable _caps; // 0x78

	// Properties
	public override GroupCollection Groups { get; }

	// Methods

	// RVA: 0x1DE66A0 Offset: 0x1DE4CA0 VA: 0x181DE66A0
	internal void .ctor(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x1DE6750 Offset: 0x1DE4D50 VA: 0x181DE6750 Slot: 5
	public override GroupCollection get_Groups() { }
}

// Namespace: System.Text.RegularExpressions
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Match>))]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection // TypeDefIndex: 7446
{
	// Fields
	private readonly Regex _regex; // 0x10
	private readonly List<Match> _matches; // 0x18
	private bool _done; // 0x20
	private readonly string _input; // 0x28
	private readonly int _beginning; // 0x30
	private readonly int _length; // 0x34
	private int _startat; // 0x38
	private int _prevlen; // 0x3C

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public virtual Match Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1DE6430 Offset: 0x1DE4A30 VA: 0x181DE6430
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x1DE6590 Offset: 0x1DE4B90 VA: 0x181DE6590 Slot: 32
	public int get_Count() { }

	// RVA: 0x1DE65F0 Offset: 0x1DE4BF0 VA: 0x181DE65F0 Slot: 35
	public virtual Match get_Item(int i) { }

	// RVA: 0x1DE5A50 Offset: 0x1DE4050 VA: 0x181DE5A50 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1DE5DB0 Offset: 0x1DE43B0 VA: 0x181DE5DB0 Slot: 16
	private IEnumerator<Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	// RVA: 0x1DE5AC0 Offset: 0x1DE40C0 VA: 0x181DE5AC0
	private Match GetMatch(int i) { }

	// RVA: 0x1DE5A30 Offset: 0x1DE4030 VA: 0x181DE5A30
	private void EnsureInitialized() { }

	// RVA: 0x37A8A0 Offset: 0x378EA0 VA: 0x18037A8A0 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x423F50 Offset: 0x422550 VA: 0x180423F50 Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x1DE5950 Offset: 0x1DE3F50 VA: 0x181DE5950 Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1DE58D0 Offset: 0x1DE3ED0 VA: 0x181DE58D0 Slot: 14
	public void CopyTo(Match[] array, int arrayIndex) { }

	// RVA: 0x1DE5E20 Offset: 0x1DE4420 VA: 0x181DE5E20 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	// RVA: 0x1DE5E90 Offset: 0x1DE4490 VA: 0x181DE5E90 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	// RVA: 0x1DE5EE0 Offset: 0x1DE44E0 VA: 0x181DE5EE0 Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	// RVA: 0x1DE5F30 Offset: 0x1DE4530 VA: 0x181DE5F30 Slot: 4
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	// RVA: 0x1DE5F50 Offset: 0x1DE4550 VA: 0x181DE5F50 Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	// RVA: 0x1DE5C50 Offset: 0x1DE4250 VA: 0x181DE5C50 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	// RVA: 0x1DE5CA0 Offset: 0x1DE42A0 VA: 0x181DE5CA0 Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	// RVA: 0x1DE5CF0 Offset: 0x1DE42F0 VA: 0x181DE5CF0 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	// RVA: 0x1DE5D60 Offset: 0x1DE4360 VA: 0x181DE5D60 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	// RVA: 0x1DE5FA0 Offset: 0x1DE45A0 VA: 0x181DE5FA0 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1DE5FF0 Offset: 0x1DE45F0 VA: 0x181DE5FF0 Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1DE6040 Offset: 0x1DE4640 VA: 0x181DE6040 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1DE6180 Offset: 0x1DE4780 VA: 0x181DE6180 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1DE62C0 Offset: 0x1DE48C0 VA: 0x181DE62C0 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x39F2C0 Offset: 0x39D8C0 VA: 0x18039F2C0 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1DE6360 Offset: 0x1DE4960 VA: 0x181DE6360 Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1DE6310 Offset: 0x1DE4910 VA: 0x181DE6310 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1DE5F30 Offset: 0x1DE4530 VA: 0x181DE5F30 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1DE63B0 Offset: 0x1DE49B0 VA: 0x181DE63B0 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1DE6400 Offset: 0x1DE4A00 VA: 0x181DE6400
	internal void .ctor() { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class ExclusiveReference // TypeDefIndex: 7447
{
	// Fields
	private RegexRunner _ref; // 0x10
	private RegexRunner _obj; // 0x18
	private int _locked; // 0x20

	// Methods

	// RVA: 0x1DE3EC0 Offset: 0x1DE24C0 VA: 0x181DE3EC0
	public RegexRunner Get() { }

	// RVA: 0x1DE3F30 Offset: 0x1DE2530 VA: 0x181DE3F30
	public void Release(RegexRunner obj) { }

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	public void .ctor() { }
}

// Namespace: System.Text.RegularExpressions
public class Regex : ISerializable // TypeDefIndex: 7450
{
	// Fields
	private const int CacheDictionarySwitchLimit = 10;
	private static int s_cacheSize; // 0x0
	private static readonly Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> s_cache; // 0x8
	private static int s_cacheCount; // 0x10
	private static Regex.CachedCodeEntry s_cacheFirst; // 0x18
	private static Regex.CachedCodeEntry s_cacheLast; // 0x20
	private static readonly TimeSpan s_maximumMatchTimeout; // 0x28
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT";
	internal static readonly TimeSpan s_defaultMatchTimeout; // 0x30
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x38
	protected internal TimeSpan internalMatchTimeout; // 0x10
	internal const int MaxOptionShift = 10;
	protected internal string pattern; // 0x18
	protected internal RegexOptions roptions; // 0x20
	protected internal RegexRunnerFactory factory; // 0x28
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference _runnerref; // 0x50
	internal WeakReference<RegexReplacement> _replref; // 0x58
	internal RegexCode _code; // 0x60
	internal bool _refsInitialized; // 0x68

	// Properties
	public RegexOptions Options { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x1DF58C0 Offset: 0x1DF3EC0 VA: 0x181DF58C0
	private Regex.CachedCodeEntry GetCachedCode(Regex.CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x1DF5200 Offset: 0x1DF3800 VA: 0x181DF5200
	private Regex.CachedCodeEntry GetCachedCodeEntryInternal(Regex.CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x1DF50F0 Offset: 0x1DF36F0 VA: 0x181DF50F0
	private void FillCacheDictionary() { }

	// RVA: 0x1DF7B20 Offset: 0x1DF6120 VA: 0x181DF7B20
	private static bool TryGetCacheValue(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry) { }

	// RVA: 0x1DF79D0 Offset: 0x1DF5FD0 VA: 0x181DF79D0
	private static bool TryGetCacheValueSmall(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry) { }

	// RVA: 0x1DF61D0 Offset: 0x1DF47D0 VA: 0x181DF61D0
	private static Regex.CachedCodeEntry LookupCachedAndPromote(Regex.CachedCodeEntryKey key) { }

	// RVA: 0x1DF5E60 Offset: 0x1DF4460 VA: 0x181DF5E60
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x1DF5EE0 Offset: 0x1DF44E0 VA: 0x181DF5EE0
	public static bool IsMatch(string input, string pattern, RegexOptions options) { }

	// RVA: 0x1DF60A0 Offset: 0x1DF46A0 VA: 0x181DF60A0
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1DF5F70 Offset: 0x1DF4570 VA: 0x181DF5F70
	public bool IsMatch(string input) { }

	// RVA: 0x1DF6010 Offset: 0x1DF4610 VA: 0x181DF6010
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x1DF68D0 Offset: 0x1DF4ED0 VA: 0x181DF68D0
	public static Match Match(string input, string pattern) { }

	// RVA: 0x1DF6720 Offset: 0x1DF4D20 VA: 0x181DF6720
	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1DF6680 Offset: 0x1DF4C80 VA: 0x181DF6680
	public Match Match(string input) { }

	// RVA: 0x1DF6840 Offset: 0x1DF4E40 VA: 0x181DF6840
	public Match Match(string input, int startat) { }

	// RVA: 0x1DF6A20 Offset: 0x1DF5020 VA: 0x181DF6A20
	public Match Match(string input, int beginning, int length) { }

	// RVA: 0x1DF6AC0 Offset: 0x1DF50C0 VA: 0x181DF6AC0
	public static MatchCollection Matches(string input, string pattern) { }

	// RVA: 0x1DF6D10 Offset: 0x1DF5310 VA: 0x181DF6D10
	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1DF6B40 Offset: 0x1DF5140 VA: 0x181DF6B40
	public MatchCollection Matches(string input) { }

	// RVA: 0x1DF6F40 Offset: 0x1DF5540 VA: 0x181DF6F40
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x1DF72B0 Offset: 0x1DF58B0 VA: 0x181DF72B0
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x1DF7470 Offset: 0x1DF5A70 VA: 0x181DF7470
	public static string Replace(string input, string pattern, string replacement, RegexOptions options) { }

	// RVA: 0x1DF7110 Offset: 0x1DF5710 VA: 0x181DF7110
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1DF7340 Offset: 0x1DF5940 VA: 0x181DF7340
	public string Replace(string input, string replacement) { }

	// RVA: 0x1DF7510 Offset: 0x1DF5B10 VA: 0x181DF7510
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x1DF7DB0 Offset: 0x1DF63B0 VA: 0x181DF7DB0
	private static void .cctor() { }

	// RVA: 0x1DF7C40 Offset: 0x1DF6240 VA: 0x181DF7C40
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x1DF5B40 Offset: 0x1DF4140 VA: 0x181DF5B40
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x1DF7F20 Offset: 0x1DF6520 VA: 0x181DF7F20
	public void .ctor(string pattern) { }

	// RVA: 0x1DF8460 Offset: 0x1DF6A60 VA: 0x181DF8460
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x1DF7990 Offset: 0x1DF5F90 VA: 0x181DF7990 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x1DF7FA0 Offset: 0x1DF65A0 VA: 0x181DF7FA0
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	// RVA: 0x1DF5050 Offset: 0x1DF3650 VA: 0x181DF5050
	public static string Escape(string str) { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200
	public RegexOptions get_Options() { }

	// RVA: 0x1DF7C30 Offset: 0x1DF6230 VA: 0x181DF7C30
	public bool get_RightToLeft() { }

	// RVA: 0x375790 Offset: 0x373D90 VA: 0x180375790 Slot: 3
	public override string ToString() { }

	// RVA: 0x1DF5A30 Offset: 0x1DF4030 VA: 0x181DF5A30
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x1DF5D60 Offset: 0x1DF4360 VA: 0x181DF5D60
	protected void InitializeReferences() { }

	// RVA: 0x1DF7630 Offset: 0x1DF5C30 VA: 0x181DF7630
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x1DF7C30 Offset: 0x1DF6230 VA: 0x181DF7C30
	protected internal bool UseOptionR() { }

	// RVA: 0x1DF7C20 Offset: 0x1DF6220 VA: 0x181DF7C20
	internal bool UseOptionInvariant() { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexBoyerMoore // TypeDefIndex: 7451
{
	// Fields
	public readonly int[] Positive; // 0x10
	public readonly int[] NegativeASCII; // 0x18
	public readonly int[][] NegativeUnicode; // 0x20
	public readonly string Pattern; // 0x28
	public readonly int LowASCII; // 0x30
	public readonly int HighASCII; // 0x34
	public readonly bool RightToLeft; // 0x38
	public readonly bool CaseInsensitive; // 0x39
	private readonly CultureInfo _culture; // 0x40

	// Methods

	// RVA: 0x1DE79D0 Offset: 0x1DE5FD0 VA: 0x181DE79D0
	public void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x1DE7590 Offset: 0x1DE5B90 VA: 0x181DE7590
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x1DE7520 Offset: 0x1DE5B20 VA: 0x181DE7520
	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x1DE76D0 Offset: 0x1DE5CD0 VA: 0x181DE76D0
	public int Scan(string text, int index, int beglimit, int endlimit) { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexCharClass // TypeDefIndex: 7455
{
	// Fields
	private static readonly string s_internalRegexIgnoreCase; // 0x0
	private static readonly string s_space; // 0x8
	private static readonly string s_notSpace; // 0x10
	private static readonly string s_word; // 0x18
	private static readonly string s_notWord; // 0x20
	public static readonly string SpaceClass; // 0x28
	public static readonly string NotSpaceClass; // 0x30
	public static readonly string WordClass; // 0x38
	public static readonly string NotWordClass; // 0x40
	public static readonly string DigitClass; // 0x48
	public static readonly string NotDigitClass; // 0x50
	private static readonly Dictionary<string, string> s_definedCategories; // 0x58
	private static readonly string[][] s_propTable; // 0x60
	private static readonly RegexCharClass.LowerCaseMapping[] s_lcTable; // 0x68
	private List<RegexCharClass.SingleRange> _rangelist; // 0x10
	private StringBuilder _categories; // 0x18
	private bool _canonical; // 0x20
	private bool _negate; // 0x21
	private RegexCharClass _subtractor; // 0x28

	// Properties
	public bool CanMerge { get; }
	public bool Negate { set; }

	// Methods

	// RVA: 0x1DEFEC0 Offset: 0x1DEE4C0 VA: 0x181DEFEC0
	public void .ctor() { }

	// RVA: 0x1DEFF80 Offset: 0x1DEE580 VA: 0x181DEFF80
	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x1DF0000 Offset: 0x1DEE600 VA: 0x181DF0000
	public bool get_CanMerge() { }

	// RVA: 0x38E210 Offset: 0x38C810 VA: 0x18038E210
	public void set_Negate(bool value) { }

	// RVA: 0x1DE8390 Offset: 0x1DE6990 VA: 0x181DE8390
	public void AddChar(char c) { }

	// RVA: 0x1DE8170 Offset: 0x1DE6770 VA: 0x181DE8170
	public void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x1DE8930 Offset: 0x1DE6F30 VA: 0x181DE8930
	private void AddSet(string set) { }

	// RVA: 0x397CE0 Offset: 0x3962E0 VA: 0x180397CE0
	public void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x1DE8820 Offset: 0x1DE6E20 VA: 0x181DE8820
	public void AddRange(char first, char last) { }

	// RVA: 0x1DE7EC0 Offset: 0x1DE64C0 VA: 0x181DE7EC0
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x1DE8150 Offset: 0x1DE6750 VA: 0x181DE8150
	private void AddCategory(string category) { }

	// RVA: 0x1DE86C0 Offset: 0x1DE6CC0 VA: 0x181DE86C0
	public void AddLowercase(CultureInfo culture) { }

	// RVA: 0x1DE8450 Offset: 0x1DE6A50 VA: 0x181DE8450
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	// RVA: 0x1DE8C90 Offset: 0x1DE7290 VA: 0x181DE8C90
	public void AddWord(bool ecma, bool negate) { }

	// RVA: 0x1DE8B60 Offset: 0x1DE7160 VA: 0x181DE8B60
	public void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x1DE83A0 Offset: 0x1DE69A0 VA: 0x181DE83A0
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x1DEA1F0 Offset: 0x1DE87F0 VA: 0x181DEA1F0
	public static char SingletonChar(string set) { }

	// RVA: 0x1DE9790 Offset: 0x1DE7D90 VA: 0x181DE9790
	public static bool IsMergeable(string charClass) { }

	// RVA: 0x1DE96B0 Offset: 0x1DE7CB0 VA: 0x181DE96B0
	public static bool IsEmpty(string charClass) { }

	// RVA: 0x1DE99D0 Offset: 0x1DE7FD0 VA: 0x181DE99D0
	public static bool IsSingleton(string set) { }

	// RVA: 0x1DE9890 Offset: 0x1DE7E90 VA: 0x181DE9890
	public static bool IsSingletonInverse(string set) { }

	// RVA: 0x1DE9B10 Offset: 0x1DE8110 VA: 0x181DE9B10
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x1DE9860 Offset: 0x1DE7E60 VA: 0x181DE9860
	private static bool IsNegated(string set) { }

	// RVA: 0x1DE9610 Offset: 0x1DE7C10 VA: 0x181DE9610
	public static bool IsECMAWordChar(char ch) { }

	// RVA: 0x1DE9B70 Offset: 0x1DE8170 VA: 0x181DE9B70
	public static bool IsWordChar(char ch) { }

	// RVA: 0x1DE9550 Offset: 0x1DE7B50 VA: 0x181DE9550
	public static bool CharInClass(char ch, string set) { }

	// RVA: 0x1DE9410 Offset: 0x1DE7A10 VA: 0x181DE9410
	private static bool CharInClassRecursive(char ch, string set, int start) { }

	// RVA: 0x1DE9220 Offset: 0x1DE7820 VA: 0x181DE9220
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1DE90C0 Offset: 0x1DE76C0 VA: 0x181DE90C0
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1DE8FF0 Offset: 0x1DE75F0 VA: 0x181DE8FF0
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x1DE9C40 Offset: 0x1DE8240 VA: 0x181DE9C40
	private static string NegateCategory(string category) { }

	// RVA: 0x1DE9F10 Offset: 0x1DE8510 VA: 0x181DE9F10
	public static RegexCharClass Parse(string charClass) { }

	// RVA: 0x1DE9CD0 Offset: 0x1DE82D0 VA: 0x181DE9CD0
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x1DE9F60 Offset: 0x1DE8560 VA: 0x181DE9F60
	private int RangeCount() { }

	// RVA: 0x1DEA210 Offset: 0x1DE8810 VA: 0x181DEA210
	public string ToStringClass() { }

	// RVA: 0x1DE95B0 Offset: 0x1DE7BB0 VA: 0x181DE95B0
	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	// RVA: 0x1DE8DC0 Offset: 0x1DE73C0 VA: 0x181DE8DC0
	private void Canonicalize() { }

	// RVA: 0x1DE9FA0 Offset: 0x1DE85A0 VA: 0x181DE9FA0
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	// RVA: 0x1DEA3D0 Offset: 0x1DE89D0 VA: 0x181DEA3D0
	private static void .cctor() { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexCode // TypeDefIndex: 7456
{
	// Fields
	public const int Onerep = 0;
	public const int Notonerep = 1;
	public const int Setrep = 2;
	public const int Oneloop = 3;
	public const int Notoneloop = 4;
	public const int Setloop = 5;
	public const int Onelazy = 6;
	public const int Notonelazy = 7;
	public const int Setlazy = 8;
	public const int One = 9;
	public const int Notone = 10;
	public const int Set = 11;
	public const int Multi = 12;
	public const int Ref = 13;
	public const int Bol = 14;
	public const int Eol = 15;
	public const int Boundary = 16;
	public const int Nonboundary = 17;
	public const int Beginning = 18;
	public const int Start = 19;
	public const int EndZ = 20;
	public const int End = 21;
	public const int Nothing = 22;
	public const int Lazybranch = 23;
	public const int Branchmark = 24;
	public const int Lazybranchmark = 25;
	public const int Nullcount = 26;
	public const int Setcount = 27;
	public const int Branchcount = 28;
	public const int Lazybranchcount = 29;
	public const int Nullmark = 30;
	public const int Setmark = 31;
	public const int Capturemark = 32;
	public const int Getmark = 33;
	public const int Setjump = 34;
	public const int Backjump = 35;
	public const int Forejump = 36;
	public const int Testref = 37;
	public const int Goto = 38;
	public const int Prune = 39;
	public const int Stop = 40;
	public const int ECMABoundary = 41;
	public const int NonECMABoundary = 42;
	public const int Mask = 63;
	public const int Rtl = 64;
	public const int Back = 128;
	public const int Back2 = 256;
	public const int Ci = 512;
	public readonly int[] Codes; // 0x10
	public readonly string[] Strings; // 0x18
	public readonly int TrackCount; // 0x20
	public readonly Hashtable Caps; // 0x28
	public readonly int CapSize; // 0x30
	public readonly Nullable<RegexPrefix> FCPrefix; // 0x38
	public readonly RegexBoyerMoore BMPrefix; // 0x50
	public readonly int Anchors; // 0x58
	public readonly bool RightToLeft; // 0x5C

	// Methods

	// RVA: 0x1DF0080 Offset: 0x1DEE680 VA: 0x181DF0080
	public void .ctor(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, Nullable<RegexPrefix> fcPrefix, int anchors, bool rightToLeft) { }

	// RVA: 0x1DF0020 Offset: 0x1DEE620 VA: 0x181DF0020
	public static bool OpcodeBacktracks(int Op) { }
}

// Namespace: System.Text.RegularExpressions
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct RegexFCD // TypeDefIndex: 7457
{
	// Fields
	private readonly List<RegexFC> _fcStack; // 0x0
	private ValueListBuilder<int> _intStack; // 0x8
	private bool _skipAllChildren; // 0x28
	private bool _skipchild; // 0x29
	private bool _failed; // 0x2A

	// Methods

	// RVA: 0x1DF1750 Offset: 0x1DEFD50 VA: 0x181DF1750
	private void .ctor(Span<int> intStack) { }

	// RVA: 0x1DF0B90 Offset: 0x1DEF190 VA: 0x181DF0B90
	public static Nullable<RegexPrefix> FirstChars(RegexTree t) { }

	// RVA: 0x1DF10A0 Offset: 0x1DEF6A0 VA: 0x181DF10A0
	public static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x1DF0200 Offset: 0x1DEE800 VA: 0x181DF0200
	public static int Anchors(RegexTree tree) { }

	// RVA: 0x1DF0180 Offset: 0x1DEE780 VA: 0x181DF0180
	private static int AnchorFromType(int type) { }

	// RVA: 0x1DF13C0 Offset: 0x1DEF9C0 VA: 0x181DF13C0
	private void PushInt(int i) { }

	// RVA: 0x1DF0F60 Offset: 0x1DEF560 VA: 0x181DF0F60
	private bool IntIsEmpty() { }

	// RVA: 0x1DF1050 Offset: 0x1DEF650 VA: 0x181DF1050
	private int PopInt() { }

	// RVA: 0x1DF1310 Offset: 0x1DEF910 VA: 0x181DF1310
	private void PushFC(RegexFC fc) { }

	// RVA: 0x1DF0B50 Offset: 0x1DEF150 VA: 0x181DF0B50
	private bool FCIsEmpty() { }

	// RVA: 0x1DF0FA0 Offset: 0x1DEF5A0 VA: 0x181DF0FA0
	private RegexFC PopFC() { }

	// RVA: 0x1DF16F0 Offset: 0x1DEFCF0 VA: 0x181DF16F0
	private RegexFC TopFC() { }

	// RVA: 0x1DF0B10 Offset: 0x1DEF110 VA: 0x181DF0B10
	public void Dispose() { }

	// RVA: 0x1DF1470 Offset: 0x1DEFA70 VA: 0x181DF1470
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x1774A10 Offset: 0x1773010 VA: 0x181774A10
	private void SkipChild() { }

	// RVA: 0x1DF03C0 Offset: 0x1DEE9C0 VA: 0x181DF03C0
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexFC // TypeDefIndex: 7458
{
	// Fields
	private RegexCharClass _cc; // 0x10
	public bool _nullable; // 0x18
	[CompilerGenerated]
	private bool <CaseInsensitive>k__BackingField; // 0x19

	// Properties
	public bool CaseInsensitive { get; set; }

	// Methods

	// RVA: 0x1DF1B20 Offset: 0x1DF0120 VA: 0x181DF1B20
	public void .ctor(bool nullable) { }

	// RVA: 0x1DF1A20 Offset: 0x1DF0020 VA: 0x181DF1A20
	public void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x1DF1BA0 Offset: 0x1DF01A0 VA: 0x181DF1BA0
	public void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x1DF1820 Offset: 0x1DEFE20 VA: 0x181DF1820
	public bool AddFC(RegexFC fc, bool concatenate) { }

	[CompilerGenerated]
	// RVA: 0x4E5B20 Offset: 0x4E4120 VA: 0x1804E5B20
	public bool get_CaseInsensitive() { }

	[CompilerGenerated]
	// RVA: 0x4E5B50 Offset: 0x4E4150 VA: 0x1804E5B50
	private void set_CaseInsensitive(bool value) { }

	// RVA: 0x1DF18B0 Offset: 0x1DEFEB0 VA: 0x181DF18B0
	public string GetFirstChars(CultureInfo culture) { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexInterpreter : RegexRunner // TypeDefIndex: 7459
{
	// Fields
	private readonly RegexCode _code; // 0x80
	private readonly CultureInfo _culture; // 0x88
	private int _operator; // 0x90
	private int _codepos; // 0x94
	private bool _rightToLeft; // 0x98
	private bool _caseInsensitive; // 0x99

	// Methods

	// RVA: 0x1DF4FF0 Offset: 0x1DF35F0 VA: 0x181DF4FF0
	public void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x1DF4700 Offset: 0x1DF2D00 VA: 0x181DF4700 Slot: 6
	protected override void InitTrackCount() { }

	// RVA: 0x1DF1C70 Offset: 0x1DF0270 VA: 0x181DF1C70
	private void Advance(int i) { }

	// RVA: 0x1DF4670 Offset: 0x1DF2C70 VA: 0x181DF4670
	private void Goto(int newpos) { }

	// RVA: 0x38E1F0 Offset: 0x38C7F0 VA: 0x18038E1F0
	private void Textto(int newpos) { }

	// RVA: 0x1DF4FD0 Offset: 0x1DF35D0 VA: 0x181DF4FD0
	private void Trackto(int newpos) { }

	// RVA: 0x3CB4F0 Offset: 0x3C9AF0 VA: 0x1803CB4F0
	private int Textstart() { }

	// RVA: 0x38DD60 Offset: 0x38C360 VA: 0x18038DD60
	private int Textpos() { }

	// RVA: 0x1DF4FB0 Offset: 0x1DF35B0 VA: 0x181DF4FB0
	private int Trackpos() { }

	// RVA: 0x1DF4F70 Offset: 0x1DF3570 VA: 0x181DF4F70
	private void TrackPush() { }

	// RVA: 0x1DF4F00 Offset: 0x1DF3500 VA: 0x181DF4F00
	private void TrackPush(int I1) { }

	// RVA: 0x1DF4E70 Offset: 0x1DF3470 VA: 0x181DF4E70
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x1DF4DC0 Offset: 0x1DF33C0 VA: 0x181DF4DC0
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x1DF4D50 Offset: 0x1DF3350 VA: 0x181DF4D50
	private void TrackPush2(int I1) { }

	// RVA: 0x1DF4CC0 Offset: 0x1DF32C0 VA: 0x181DF4CC0
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x1DF1CF0 Offset: 0x1DF02F0 VA: 0x181DF1CF0
	private void Backtrack() { }

	// RVA: 0x1DF4970 Offset: 0x1DF2F70 VA: 0x181DF4970
	private void SetOperator(int op) { }

	// RVA: 0x1DF4CA0 Offset: 0x1DF32A0 VA: 0x181DF4CA0
	private void TrackPop() { }

	// RVA: 0x1DF4CB0 Offset: 0x1DF32B0 VA: 0x181DF4CB0
	private void TrackPop(int framesize) { }

	// RVA: 0x1DF4C70 Offset: 0x1DF3270 VA: 0x181DF4C70
	private int TrackPeek() { }

	// RVA: 0x1DF4C30 Offset: 0x1DF3230 VA: 0x181DF4C30
	private int TrackPeek(int i) { }

	// RVA: 0x1DF4A90 Offset: 0x1DF3090 VA: 0x181DF4A90
	private void StackPush(int I1) { }

	// RVA: 0x1DF4A30 Offset: 0x1DF3030 VA: 0x181DF4A30
	private void StackPush(int I1, int I2) { }

	// RVA: 0x1DF4A10 Offset: 0x1DF3010 VA: 0x181DF4A10
	private void StackPop() { }

	// RVA: 0x1DF4A20 Offset: 0x1DF3020 VA: 0x181DF4A20
	private void StackPop(int framesize) { }

	// RVA: 0x1DF49A0 Offset: 0x1DF2FA0 VA: 0x181DF49A0
	private int StackPeek() { }

	// RVA: 0x1DF49D0 Offset: 0x1DF2FD0 VA: 0x181DF49D0
	private int StackPeek(int i) { }

	// RVA: 0xAC7E10 Offset: 0xAC6410 VA: 0x180AC7E10
	private int Operator() { }

	// RVA: 0x1DF4740 Offset: 0x1DF2D40 VA: 0x181DF4740
	private int Operand(int i) { }

	// RVA: 0x1DF4730 Offset: 0x1DF2D30 VA: 0x181DF4730
	private int Leftchars() { }

	// RVA: 0x1DF4960 Offset: 0x1DF2F60 VA: 0x181DF4960
	private int Rightchars() { }

	// RVA: 0x1DF1DF0 Offset: 0x1DF03F0 VA: 0x181DF1DF0
	private int Bump() { }

	// RVA: 0x1DF2520 Offset: 0x1DF0B20 VA: 0x181DF2520
	private int Forwardchars() { }

	// RVA: 0x1DF2480 Offset: 0x1DF0A80 VA: 0x181DF2480
	private char Forwardcharnext() { }

	// RVA: 0x1DF4AD0 Offset: 0x1DF30D0 VA: 0x181DF4AD0
	private bool Stringmatch(string str) { }

	// RVA: 0x1DF4790 Offset: 0x1DF2D90 VA: 0x181DF4790
	private bool Refmatch(int index, int len) { }

	// RVA: 0x1DF1DD0 Offset: 0x1DF03D0 VA: 0x181DF1DD0
	private void Backwardnext() { }

	// RVA: 0x1DF1E10 Offset: 0x1DF0410 VA: 0x181DF1E10
	private char CharAt(int j) { }

	// RVA: 0x1DF1E30 Offset: 0x1DF0430 VA: 0x181DF1E30 Slot: 5
	protected override bool FindFirstChar() { }

	// RVA: 0x1DF2540 Offset: 0x1DF0B40 VA: 0x181DF2540 Slot: 4
	protected override void Go() { }
}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 7460
{
	// Fields
	[CompilerGenerated]
	private readonly string <Input>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <Pattern>k__BackingField; // 0x98
	[CompilerGenerated]
	private readonly TimeSpan <MatchTimeout>k__BackingField; // 0xA0

	// Properties
	public string Input { get; }
	public string Pattern { get; }
	public TimeSpan MatchTimeout { get; }

	// Methods

	// RVA: 0x1DFFCF0 Offset: 0x1DFE2F0 VA: 0x181DFFCF0
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x1DFFF80 Offset: 0x1DFE580 VA: 0x181DFFF80
	public void .ctor() { }

	// RVA: 0x1DFFE10 Offset: 0x1DFE410 VA: 0x181DFFE10
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1DFFC00 Offset: 0x1DFE200 VA: 0x181DFFC00 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	// RVA: 0x3AAB80 Offset: 0x3A9180 VA: 0x1803AAB80
	public string get_Input() { }

	[CompilerGenerated]
	// RVA: 0x534910 Offset: 0x532F10 VA: 0x180534910
	public string get_Pattern() { }

	[CompilerGenerated]
	// RVA: 0x14348E0 Offset: 0x1432EE0 VA: 0x1814348E0
	public TimeSpan get_MatchTimeout() { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexNode // TypeDefIndex: 7461
{
	// Fields
	public int NType; // 0x10
	public List<RegexNode> Children; // 0x18
	public string Str; // 0x20
	public char Ch; // 0x28
	public int M; // 0x2C
	public int N; // 0x30
	public readonly RegexOptions Options; // 0x34
	public RegexNode Next; // 0x38

	// Methods

	// RVA: 0x1E01340 Offset: 0x1DFF940 VA: 0x181E01340
	public void .ctor(int type, RegexOptions options) { }

	// RVA: 0x1E01380 Offset: 0x1DFF980 VA: 0x181E01380
	public void .ctor(int type, RegexOptions options, char ch) { }

	// RVA: 0x1E01250 Offset: 0x1DFF850 VA: 0x181E01250
	public void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x1E012A0 Offset: 0x1DFF8A0 VA: 0x181E012A0
	public void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x1E012F0 Offset: 0x1DFF8F0 VA: 0x181E012F0
	public void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x1E01240 Offset: 0x1DFF840 VA: 0x181E01240
	public bool UseOptionR() { }

	// RVA: 0x1E010F0 Offset: 0x1DFF6F0 VA: 0x181E010F0
	public RegexNode ReverseLeft() { }

	// RVA: 0x1E00320 Offset: 0x1DFE920 VA: 0x181E00320
	private void MakeRep(int type, int min, int max) { }

	// RVA: 0x1E00EA0 Offset: 0x1DFF4A0 VA: 0x181E00EA0
	private RegexNode Reduce() { }

	// RVA: 0x1E01160 Offset: 0x1DFF760 VA: 0x181E01160
	private RegexNode StripEnation(int emptyType) { }

	// RVA: 0x1E00B10 Offset: 0x1DFF110 VA: 0x181E00B10
	private RegexNode ReduceGroup() { }

	// RVA: 0x1E00B80 Offset: 0x1DFF180 VA: 0x181E00B80
	private RegexNode ReduceRep() { }

	// RVA: 0x1E00D40 Offset: 0x1DFF340 VA: 0x181E00D40
	private RegexNode ReduceSet() { }

	// RVA: 0x1E00330 Offset: 0x1DFE930 VA: 0x181E00330
	private RegexNode ReduceAlternation() { }

	// RVA: 0x1E00740 Offset: 0x1DFED40 VA: 0x181E00740
	private RegexNode ReduceConcatenation() { }

	// RVA: 0x1E00210 Offset: 0x1DFE810 VA: 0x181E00210
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x1E00030 Offset: 0x1DFE630 VA: 0x181E00030
	public void AddChild(RegexNode newChild) { }

	// RVA: 0x1E001B0 Offset: 0x1DFE7B0 VA: 0x181E001B0
	public RegexNode Child(int i) { }

	// RVA: 0x1E00160 Offset: 0x1DFE760 VA: 0x181E00160
	public int ChildCount() { }

	// RVA: 0x377C50 Offset: 0x376250 VA: 0x180377C50
	public int Type() { }
}

// Namespace: System.Text.RegularExpressions
[Flags]
public enum RegexOptions // TypeDefIndex: 7462
{
	// Fields
	public int value__; // 0x0
	public const RegexOptions None = 0;
	public const RegexOptions IgnoreCase = 1;
	public const RegexOptions Multiline = 2;
	public const RegexOptions ExplicitCapture = 4;
	public const RegexOptions Compiled = 8;
	public const RegexOptions Singleline = 16;
	public const RegexOptions IgnorePatternWhitespace = 32;
	public const RegexOptions RightToLeft = 64;
	public const RegexOptions ECMAScript = 256;
	public const RegexOptions CultureInvariant = 512;
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexParser // TypeDefIndex: 7463
{
	// Fields
	private RegexNode _stack; // 0x10
	private RegexNode _group; // 0x18
	private RegexNode _alternation; // 0x20
	private RegexNode _concatenation; // 0x28
	private RegexNode _unit; // 0x30
	private string _pattern; // 0x38
	private int _currentPos; // 0x40
	private CultureInfo _culture; // 0x48
	private int _autocap; // 0x50
	private int _capcount; // 0x54
	private int _captop; // 0x58
	private int _capsize; // 0x5C
	private Hashtable _caps; // 0x60
	private Hashtable _capnames; // 0x68
	private int[] _capnumlist; // 0x70
	private List<string> _capnamelist; // 0x78
	private RegexOptions _options; // 0x80
	private List<RegexOptions> _optionsStack; // 0x88
	private bool _ignoreNextParen; // 0x90
	private static readonly byte[] s_category; // 0x0

	// Methods

	// RVA: 0x1E03940 Offset: 0x1E01F40 VA: 0x181E03940
	public static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x1E036A0 Offset: 0x1E01CA0 VA: 0x181E036A0
	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x1E02A30 Offset: 0x1E01030 VA: 0x181E02A30
	public static string Escape(string input) { }

	// RVA: 0x1E07F20 Offset: 0x1E06520 VA: 0x181E07F20
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x1E07CA0 Offset: 0x1E062A0 VA: 0x181E07CA0
	private void SetPattern(string Re) { }

	// RVA: 0x1E03ED0 Offset: 0x1E024D0 VA: 0x181E03ED0
	private void Reset(RegexOptions topopts) { }

	// RVA: 0x1E072B0 Offset: 0x1E058B0 VA: 0x181E072B0
	private RegexNode ScanRegex() { }

	// RVA: 0x1E07B30 Offset: 0x1E06130 VA: 0x181E07B30
	private RegexNode ScanReplacement() { }

	// RVA: 0x1E050F0 Offset: 0x1E036F0 VA: 0x181E050F0
	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x1E06350 Offset: 0x1E04950 VA: 0x181E06350
	private RegexNode ScanGroupOpen() { }

	// RVA: 0x1E04C90 Offset: 0x1E03290 VA: 0x181E04C90
	private void ScanBlank() { }

	// RVA: 0x1E04000 Offset: 0x1E02600 VA: 0x181E04000
	private RegexNode ScanBackslash(bool scanOnly) { }

	// RVA: 0x1E045A0 Offset: 0x1E02BA0 VA: 0x181E045A0
	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	// RVA: 0x1E05F10 Offset: 0x1E04510 VA: 0x181E05F10
	private RegexNode ScanDollar() { }

	// RVA: 0x1E05030 Offset: 0x1E03630 VA: 0x181E05030
	private string ScanCapname() { }

	// RVA: 0x1E07110 Offset: 0x1E05710 VA: 0x181E07110
	private char ScanOctal() { }

	// RVA: 0x1E05E50 Offset: 0x1E04450 VA: 0x181E05E50
	private int ScanDecimal() { }

	// RVA: 0x1E06FF0 Offset: 0x1E055F0 VA: 0x181E06FF0
	private char ScanHex(int c) { }

	// RVA: 0x1E02C00 Offset: 0x1E01200 VA: 0x181E02C00
	private static int HexDigit(char ch) { }

	// RVA: 0x1E05D80 Offset: 0x1E04380 VA: 0x181E05D80
	private char ScanControl() { }

	// RVA: 0x1E02D50 Offset: 0x1E01350 VA: 0x181E02D50
	private bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x1E071B0 Offset: 0x1E057B0 VA: 0x181E071B0
	private void ScanOptions() { }

	// RVA: 0x1E059C0 Offset: 0x1E03FC0 VA: 0x181E059C0
	private char ScanCharEscape() { }

	// RVA: 0x1E034D0 Offset: 0x1E01AD0 VA: 0x181E034D0
	private string ParseProperty() { }

	// RVA: 0x1E07DB0 Offset: 0x1E063B0 VA: 0x181E07DB0
	private int TypeFromCode(char ch) { }

	// RVA: 0x1E03440 Offset: 0x1E01A40 VA: 0x181E03440
	private static RegexOptions OptionFromCode(char ch) { }

	// RVA: 0x1E024E0 Offset: 0x1E00AE0 VA: 0x181E024E0
	private void CountCaptures() { }

	// RVA: 0x1E03300 Offset: 0x1E01900 VA: 0x181E03300
	private void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x1E031B0 Offset: 0x1E017B0 VA: 0x181E031B0
	private void NoteCaptureName(string name, int pos) { }

	// RVA: 0x1E033F0 Offset: 0x1E019F0 VA: 0x181E033F0
	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x1E01D60 Offset: 0x1E00360 VA: 0x181E01D60
	private void AssignNameSlots() { }

	// RVA: 0x1E02440 Offset: 0x1E00A40 VA: 0x181E02440
	private int CaptureSlotFromName(string capname) { }

	// RVA: 0x1E02C60 Offset: 0x1E01260 VA: 0x181E02C60
	private bool IsCaptureSlot(int i) { }

	// RVA: 0x1E02C30 Offset: 0x1E01230 VA: 0x181E02C30
	private bool IsCaptureName(string capname) { }

	// RVA: 0x1E07E60 Offset: 0x1E06460 VA: 0x181E07E60
	private bool UseOptionN() { }

	// RVA: 0x1E07E40 Offset: 0x1E06440 VA: 0x181E07E40
	private bool UseOptionI() { }

	// RVA: 0x1E07E50 Offset: 0x1E06450 VA: 0x181E07E50
	private bool UseOptionM() { }

	// RVA: 0x1E07E70 Offset: 0x1E06470 VA: 0x181E07E70
	private bool UseOptionS() { }

	// RVA: 0x1E07E80 Offset: 0x1E06480 VA: 0x181E07E80
	private bool UseOptionX() { }

	// RVA: 0x1E07E30 Offset: 0x1E06430 VA: 0x181E07E30
	private bool UseOptionE() { }

	// RVA: 0x1E02E70 Offset: 0x1E01470 VA: 0x181E02E70
	private static bool IsSpecial(char ch) { }

	// RVA: 0x1E02EF0 Offset: 0x1E014F0 VA: 0x181E02EF0
	private static bool IsStopperX(char ch) { }

	// RVA: 0x1E02D70 Offset: 0x1E01370 VA: 0x181E02D70
	private static bool IsQuantifier(char ch) { }

	// RVA: 0x1E02F70 Offset: 0x1E01570 VA: 0x181E02F70
	private bool IsTrueQuantifier() { }

	// RVA: 0x1E02DF0 Offset: 0x1E013F0 VA: 0x181E02DF0
	private static bool IsSpace(char ch) { }

	// RVA: 0x1E02CD0 Offset: 0x1E012D0 VA: 0x181E02CD0
	private static bool IsMetachar(char ch) { }

	// RVA: 0x1E01680 Offset: 0x1DFFC80 VA: 0x181E01680
	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x1E03DB0 Offset: 0x1E023B0 VA: 0x181E03DB0
	private void PushGroup() { }

	// RVA: 0x1E03B90 Offset: 0x1E02190 VA: 0x181E03B90
	private void PopGroup() { }

	// RVA: 0x1A7CA80 Offset: 0x1A7B080 VA: 0x181A7CA80
	private bool EmptyStack() { }

	// RVA: 0x1E07CE0 Offset: 0x1E062E0 VA: 0x181E07CE0
	private void StartGroup(RegexNode openGroup) { }

	// RVA: 0x1E013D0 Offset: 0x1DFF9D0 VA: 0x181E013D0
	private void AddAlternate() { }

	// RVA: 0x1E01640 Offset: 0x1DFFC40 VA: 0x181E01640
	private void AddConcatenate() { }

	// RVA: 0x1E01500 Offset: 0x1DFFB00 VA: 0x181E01500
	private void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0
	private RegexNode Unit() { }

	// RVA: 0x1E01B60 Offset: 0x1E00160 VA: 0x181E01B60
	private void AddUnitOne(char ch) { }

	// RVA: 0x1E01A80 Offset: 0x1E00080 VA: 0x181E01A80
	private void AddUnitNotone(char ch) { }

	// RVA: 0x1E01C40 Offset: 0x1E00240 VA: 0x181E01C40
	private void AddUnitSet(string cc) { }

	// RVA: 0x397210 Offset: 0x395810 VA: 0x180397210
	private void AddUnitNode(RegexNode node) { }

	// RVA: 0x1E01CE0 Offset: 0x1E002E0 VA: 0x181E01CE0
	private void AddUnitType(int type) { }

	// RVA: 0x1E018B0 Offset: 0x1DFFEB0 VA: 0x181E018B0
	private void AddGroup() { }

	// RVA: 0x1E03E30 Offset: 0x1E02430 VA: 0x181E03E30
	private void PushOptions() { }

	// RVA: 0x1E03D20 Offset: 0x1E02320 VA: 0x181E03D20
	private void PopOptions() { }

	// RVA: 0x1E029E0 Offset: 0x1E00FE0 VA: 0x181E029E0
	private bool EmptyOptionsStack() { }

	// RVA: 0x1E03CC0 Offset: 0x1E022C0 VA: 0x181E03CC0
	private void PopKeepOptions() { }

	// RVA: 0x1E03100 Offset: 0x1E01700 VA: 0x181E03100
	private ArgumentException MakeException(string message) { }

	// RVA: 0x370B30 Offset: 0x36F130 VA: 0x180370B30
	private int Textpos() { }

	// RVA: 0x371800 Offset: 0x36FE00 VA: 0x180371800
	private void Textto(int pos) { }

	// RVA: 0x1E03F70 Offset: 0x1E02570 VA: 0x181E03F70
	private char RightCharMoveRight() { }

	// RVA: 0x1E03190 Offset: 0x1E01790 VA: 0x181E03190
	private void MoveRight() { }

	// RVA: 0x1E031A0 Offset: 0x1E017A0 VA: 0x181E031A0
	private void MoveRight(int i) { }

	// RVA: 0x1E03180 Offset: 0x1E01780 VA: 0x181E03180
	private void MoveLeft() { }

	// RVA: 0x1E024A0 Offset: 0x1E00AA0 VA: 0x181E024A0
	private char CharAt(int i) { }

	// RVA: 0x1E03FA0 Offset: 0x1E025A0 VA: 0x181E03FA0
	internal char RightChar() { }

	// RVA: 0x1E03FD0 Offset: 0x1E025D0 VA: 0x181E03FD0
	private char RightChar(int i) { }

	// RVA: 0x1E024C0 Offset: 0x1E00AC0 VA: 0x181E024C0
	private int CharsRight() { }

	// RVA: 0x1E07E90 Offset: 0x1E06490 VA: 0x181E07E90
	private static void .cctor() { }
}

// Namespace: System.Text.RegularExpressions
[IsReadOnly]
internal struct RegexPrefix // TypeDefIndex: 7464
{
	// Fields
	[CompilerGenerated]
	private readonly bool <CaseInsensitive>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly RegexPrefix <Empty>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly string <Prefix>k__BackingField; // 0x8

	// Properties
	internal bool CaseInsensitive { get; }
	internal static RegexPrefix Empty { get; }
	internal string Prefix { get; }

	// Methods

	// RVA: 0x1E08080 Offset: 0x1E06680 VA: 0x181E08080
	internal void .ctor(string prefix, bool ci) { }

	[CompilerGenerated]
	// RVA: 0xC08650 Offset: 0xC06C50 VA: 0x180C08650
	internal bool get_CaseInsensitive() { }

	[CompilerGenerated]
	// RVA: 0x1E080B0 Offset: 0x1E066B0 VA: 0x181E080B0
	internal static RegexPrefix get_Empty() { }

	[CompilerGenerated]
	// RVA: 0x9712A0 Offset: 0x96F8A0 VA: 0x1809712A0
	internal string get_Prefix() { }

	// RVA: 0x1E07FF0 Offset: 0x1E065F0 VA: 0x181E07FF0
	private static void .cctor() { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexReplacement // TypeDefIndex: 7465
{
	// Fields
	private const int Specials = 4;
	public const int LeftPortion = -1;
	public const int RightPortion = -2;
	public const int LastGroup = -3;
	public const int WholeString = -4;
	private readonly List<string> _strings; // 0x10
	private readonly List<int> _rules; // 0x18
	[CompilerGenerated]
	private readonly string <Pattern>k__BackingField; // 0x20

	// Properties
	public string Pattern { get; }

	// Methods

	// RVA: 0x1E08CF0 Offset: 0x1E072F0 VA: 0x181E08CF0
	public void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x1E08110 Offset: 0x1E06710 VA: 0x181E08110
	public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	[CompilerGenerated]
	// RVA: 0x3983A0 Offset: 0x3969A0 VA: 0x1803983A0
	public string get_Pattern() { }

	// RVA: 0x1E08B30 Offset: 0x1E07130 VA: 0x181E08B30
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x1E08940 Offset: 0x1E06F40 VA: 0x181E08940
	private void ReplacementImplRTL(List<string> al, Match match) { }

	// RVA: 0x1E08230 Offset: 0x1E06830 VA: 0x181E08230
	public string Replace(Regex regex, string input, int count, int startat) { }
}

// Namespace: System.Text.RegularExpressions
public abstract class RegexRunner // TypeDefIndex: 7466
{
	// Fields
	protected internal int runtextbeg; // 0x10
	protected internal int runtextend; // 0x14
	protected internal int runtextstart; // 0x18
	protected internal string runtext; // 0x20
	protected internal int runtextpos; // 0x28
	protected internal int[] runtrack; // 0x30
	protected internal int runtrackpos; // 0x38
	protected internal int[] runstack; // 0x40
	protected internal int runstackpos; // 0x48
	protected internal int[] runcrawl; // 0x50
	protected internal int runcrawlpos; // 0x58
	protected internal int runtrackcount; // 0x5C
	protected internal Match runmatch; // 0x60
	protected internal Regex runregex; // 0x68
	private int _timeout; // 0x70
	private bool _ignoreTimeout; // 0x74
	private int _timeoutOccursAt; // 0x78
	private const int TimeoutCheckFrequency = 1000;
	private int _timeoutChecksToSkip; // 0x7C

	// Methods

	// RVA: 0x35E8E0 Offset: 0x35CEE0 VA: 0x18035E8E0
	protected internal void .ctor() { }

	// RVA: 0x1E09D10 Offset: 0x1E08310 VA: 0x181E09D10
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x1E0A170 Offset: 0x1E08770 VA: 0x181E0A170
	private void StartTimeoutWatch() { }

	// RVA: 0x1E091E0 Offset: 0x1E077E0 VA: 0x181E091E0
	protected void CheckTimeout() { }

	// RVA: 0x1E093C0 Offset: 0x1E079C0 VA: 0x181E093C0
	private void DoCheckTimeout() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Go();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool FindFirstChar();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitTrackCount();

	// RVA: 0x1E097D0 Offset: 0x1E07DD0 VA: 0x181E097D0
	private void InitMatch() { }

	// RVA: 0x1E0A1A0 Offset: 0x1E087A0 VA: 0x181E0A1A0
	private Match TidyMatch(bool quick) { }

	// RVA: 0x1E09680 Offset: 0x1E07C80 VA: 0x181E09680
	protected void EnsureStorage() { }

	// RVA: 0x1E09A60 Offset: 0x1E08060 VA: 0x181E09A60
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x1E09B50 Offset: 0x1E08150 VA: 0x181E09B50
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x1E095E0 Offset: 0x1E07BE0 VA: 0x181E095E0
	protected void DoubleTrack() { }

	// RVA: 0x1E09540 Offset: 0x1E07B40 VA: 0x181E09540
	protected void DoubleStack() { }

	// RVA: 0x1E094A0 Offset: 0x1E07AA0 VA: 0x181E094A0
	protected void DoubleCrawl() { }

	// RVA: 0x1E092C0 Offset: 0x1E078C0 VA: 0x181E092C0
	protected void Crawl(int i) { }

	// RVA: 0x1E09CD0 Offset: 0x1E082D0 VA: 0x181E09CD0
	protected int Popcrawl() { }

	// RVA: 0x1E093A0 Offset: 0x1E079A0 VA: 0x181E093A0
	protected int Crawlpos() { }

	// RVA: 0x1E09150 Offset: 0x1E07750 VA: 0x181E09150
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x1E0A210 Offset: 0x1E08810 VA: 0x181E0A210
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x1E0A340 Offset: 0x1E08940 VA: 0x181E0A340
	protected void Uncapture() { }

	// RVA: 0x1E09C40 Offset: 0x1E08240 VA: 0x181E09C40
	protected bool IsMatched(int cap) { }

	// RVA: 0x1E09C70 Offset: 0x1E08270 VA: 0x181E09C70
	protected int MatchIndex(int cap) { }

	// RVA: 0x1E09CA0 Offset: 0x1E082A0 VA: 0x181E09CA0
	protected int MatchLength(int cap) { }
}

// Namespace: System.Text.RegularExpressions
public abstract class RegexRunnerFactory // TypeDefIndex: 7467
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract RegexRunner CreateInstance();
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexTree // TypeDefIndex: 7468
{
	// Fields
	public readonly RegexNode Root; // 0x10
	public readonly Hashtable Caps; // 0x18
	public readonly int[] CapNumList; // 0x20
	public readonly int CapTop; // 0x28
	public readonly Hashtable CapNames; // 0x30
	public readonly string[] CapsList; // 0x38
	public readonly RegexOptions Options; // 0x40

	// Methods

	// RVA: 0x1E0A390 Offset: 0x1E08990 VA: 0x181E0A390
	internal void .ctor(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options) { }
}

// Namespace: System.Text.RegularExpressions
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct RegexWriter // TypeDefIndex: 7469
{
	// Fields
	private ValueListBuilder<int> _emitted; // 0x0
	private ValueListBuilder<int> _intStack; // 0x20
	private readonly Dictionary<string, int> _stringHash; // 0x40
	private readonly List<string> _stringTable; // 0x48
	private Hashtable _caps; // 0x50
	private int _trackCount; // 0x58

	// Methods

	// RVA: 0x1E0BA20 Offset: 0x1E0A020 VA: 0x181E0BA20
	private void .ctor(Span<int> emittedSpan, Span<int> intStackSpan) { }

	// RVA: 0x1E0B7D0 Offset: 0x1E09DD0 VA: 0x181E0B7D0
	public static RegexCode Write(RegexTree tree) { }

	// RVA: 0x1E0A430 Offset: 0x1E08A30 VA: 0x181E0A430
	public void Dispose() { }

	// RVA: 0x1E0B100 Offset: 0x1E09700 VA: 0x181E0B100
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x1E0B0A0 Offset: 0x1E096A0 VA: 0x181E0B0A0
	private void PatchJump(int offset, int jumpDest) { }

	// RVA: 0x1E0AF00 Offset: 0x1E09500 VA: 0x181E0AF00
	private void Emit(int op) { }

	// RVA: 0x1E0AE80 Offset: 0x1E09480 VA: 0x181E0AE80
	private void Emit(int op, int opd1) { }

	// RVA: 0x1E0AF60 Offset: 0x1E09560 VA: 0x181E0AF60
	private void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x1E0B6E0 Offset: 0x1E09CE0 VA: 0x181E0B6E0
	private int StringCode(string str) { }

	// RVA: 0x1E0B000 Offset: 0x1E09600 VA: 0x181E0B000
	private int MapCapnum(int capnum) { }

	// RVA: 0x1E0A480 Offset: 0x1E08A80 VA: 0x181E0A480
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }
}

