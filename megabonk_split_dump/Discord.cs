// Namespace: Discord
public class ActivityManager // TypeDefIndex: 13194
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private ActivityManager.ActivityJoinHandler OnActivityJoin; // 0x20
	[CompilerGenerated]
	private ActivityManager.ActivitySpectateHandler OnActivitySpectate; // 0x28
	[CompilerGenerated]
	private ActivityManager.ActivityJoinRequestHandler OnActivityJoinRequest; // 0x30
	[CompilerGenerated]
	private ActivityManager.ActivityInviteHandler OnActivityInvite; // 0x38

	// Properties
	private ActivityManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5D2540 Offset: 0x5D0B40 VA: 0x1805D2540
	public void RegisterCommand() { }

	// RVA: 0x5D31B0 Offset: 0x5D17B0 VA: 0x1805D31B0
	private ActivityManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x5D3070 Offset: 0x5D1670 VA: 0x1805D3070
	public void add_OnActivityJoin(ActivityManager.ActivityJoinHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5D3410 Offset: 0x5D1A10 VA: 0x1805D3410
	public void remove_OnActivityJoin(ActivityManager.ActivityJoinHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5D3110 Offset: 0x5D1710 VA: 0x1805D3110
	public void add_OnActivitySpectate(ActivityManager.ActivitySpectateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5D34B0 Offset: 0x5D1AB0 VA: 0x1805D34B0
	public void remove_OnActivitySpectate(ActivityManager.ActivitySpectateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5D2FD0 Offset: 0x5D15D0 VA: 0x1805D2FD0
	public void add_OnActivityJoinRequest(ActivityManager.ActivityJoinRequestHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5D3370 Offset: 0x5D1970 VA: 0x1805D3370
	public void remove_OnActivityJoinRequest(ActivityManager.ActivityJoinRequestHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5D2F30 Offset: 0x5D1530 VA: 0x1805D2F30
	public void add_OnActivityInvite(ActivityManager.ActivityInviteHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5D32D0 Offset: 0x5D18D0 VA: 0x1805D32D0
	public void remove_OnActivityInvite(ActivityManager.ActivityInviteHandler value) { }

	// RVA: 0x5D2E50 Offset: 0x5D1450 VA: 0x1805D2E50
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref ActivityManager.FFIEvents events) { }

	// RVA: 0x5D1C30 Offset: 0x5D0230 VA: 0x1805D1C30
	private void InitEvents(IntPtr eventsPtr, ref ActivityManager.FFIEvents events) { }

	// RVA: 0x5D24A0 Offset: 0x5D0AA0 VA: 0x1805D24A0
	public void RegisterCommand(string command) { }

	// RVA: 0x5D25E0 Offset: 0x5D0BE0 VA: 0x1805D25E0
	public void RegisterSteam(uint steamId) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D2BD0 Offset: 0x5D11D0 VA: 0x1805D2BD0
	private static void UpdateActivityCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5D2CF0 Offset: 0x5D12F0 VA: 0x1805D2CF0
	public void UpdateActivity(Activity activity, ActivityManager.UpdateActivityHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D19B0 Offset: 0x5CFFB0 VA: 0x1805D19B0
	private static void ClearActivityCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5D1AD0 Offset: 0x5D00D0 VA: 0x1805D1AD0
	public void ClearActivity(ActivityManager.ClearActivityHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D2940 Offset: 0x5D0F40 VA: 0x1805D2940
	private static void SendRequestReplyCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5D2A60 Offset: 0x5D1060 VA: 0x1805D2A60
	public void SendRequestReply(long userId, ActivityJoinRequestReply reply, ActivityManager.SendRequestReplyHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D2690 Offset: 0x5D0C90 VA: 0x1805D2690
	private static void SendInviteCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5D27B0 Offset: 0x5D0DB0 VA: 0x1805D27B0
	public void SendInvite(long userId, ActivityActionType type, string content, ActivityManager.SendInviteHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D1720 Offset: 0x5CFD20 VA: 0x1805D1720
	private static void AcceptInviteCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5D1840 Offset: 0x5CFE40 VA: 0x1805D1840
	public void AcceptInvite(long userId, ActivityManager.AcceptInviteHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D2110 Offset: 0x5D0710 VA: 0x1805D2110
	private static void OnActivityJoinImpl(IntPtr ptr, string secret) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D2370 Offset: 0x5D0970 VA: 0x1805D2370
	private static void OnActivitySpectateImpl(IntPtr ptr, string secret) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D2240 Offset: 0x5D0840 VA: 0x1805D2240
	private static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D1FC0 Offset: 0x5D05C0 VA: 0x1805D1FC0
	private static void OnActivityInviteImpl(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity) { }
}

// Namespace: Discord
internal static class Constants // TypeDefIndex: 13195
{
	// Fields
	public const string DllName = "discord_game_sdk";
}

// Namespace: Discord
public enum Result // TypeDefIndex: 13196
{
	// Fields
	public int value__; // 0x0
	public const Result Ok = 0;
	public const Result ServiceUnavailable = 1;
	public const Result InvalidVersion = 2;
	public const Result LockFailed = 3;
	public const Result InternalError = 4;
	public const Result InvalidPayload = 5;
	public const Result InvalidCommand = 6;
	public const Result InvalidPermissions = 7;
	public const Result NotFetched = 8;
	public const Result NotFound = 9;
	public const Result Conflict = 10;
	public const Result InvalidSecret = 11;
	public const Result InvalidJoinSecret = 12;
	public const Result NoEligibleActivity = 13;
	public const Result InvalidInvite = 14;
	public const Result NotAuthenticated = 15;
	public const Result InvalidAccessToken = 16;
	public const Result ApplicationMismatch = 17;
	public const Result InvalidDataUrl = 18;
	public const Result InvalidBase64 = 19;
	public const Result NotFiltered = 20;
	public const Result LobbyFull = 21;
	public const Result InvalidLobbySecret = 22;
	public const Result InvalidFilename = 23;
	public const Result InvalidFileSize = 24;
	public const Result InvalidEntitlement = 25;
	public const Result NotInstalled = 26;
	public const Result NotRunning = 27;
	public const Result InsufficientBuffer = 28;
	public const Result PurchaseCanceled = 29;
	public const Result InvalidGuild = 30;
	public const Result InvalidEvent = 31;
	public const Result InvalidChannel = 32;
	public const Result InvalidOrigin = 33;
	public const Result RateLimited = 34;
	public const Result OAuth2Error = 35;
	public const Result SelectChannelTimeout = 36;
	public const Result GetGuildTimeout = 37;
	public const Result SelectVoiceForceRequired = 38;
	public const Result CaptureShortcutAlreadyListening = 39;
	public const Result UnauthorizedForAchievement = 40;
	public const Result InvalidGiftCode = 41;
	public const Result PurchaseError = 42;
	public const Result TransactionAborted = 43;
	public const Result DrawingInitFailed = 44;
}

// Namespace: Discord
public enum CreateFlags // TypeDefIndex: 13197
{
	// Fields
	public int value__; // 0x0
	public const CreateFlags Default = 0;
	public const CreateFlags NoRequireDiscord = 1;
}

// Namespace: Discord
public enum LogLevel // TypeDefIndex: 13198
{
	// Fields
	public int value__; // 0x0
	public const LogLevel Error = 1;
	public const LogLevel Warn = 2;
	public const LogLevel Info = 3;
	public const LogLevel Debug = 4;
}

// Namespace: Discord
public enum UserFlag // TypeDefIndex: 13199
{
	// Fields
	public int value__; // 0x0
	public const UserFlag Partner = 2;
	public const UserFlag HypeSquadEvents = 4;
	public const UserFlag HypeSquadHouse1 = 64;
	public const UserFlag HypeSquadHouse2 = 128;
	public const UserFlag HypeSquadHouse3 = 256;
}

// Namespace: Discord
public enum PremiumType // TypeDefIndex: 13200
{
	// Fields
	public int value__; // 0x0
	public const PremiumType None = 0;
	public const PremiumType Tier1 = 1;
	public const PremiumType Tier2 = 2;
}

// Namespace: Discord
public enum ImageType // TypeDefIndex: 13201
{
	// Fields
	public int value__; // 0x0
	public const ImageType User = 0;
}

// Namespace: Discord
public enum ActivityPartyPrivacy // TypeDefIndex: 13202
{
	// Fields
	public int value__; // 0x0
	public const ActivityPartyPrivacy Private = 0;
	public const ActivityPartyPrivacy Public = 1;
}

// Namespace: Discord
public enum ActivityType // TypeDefIndex: 13203
{
	// Fields
	public int value__; // 0x0
	public const ActivityType Playing = 0;
	public const ActivityType Streaming = 1;
	public const ActivityType Listening = 2;
	public const ActivityType Watching = 3;
}

// Namespace: Discord
public enum ActivityActionType // TypeDefIndex: 13204
{
	// Fields
	public int value__; // 0x0
	public const ActivityActionType Join = 1;
	public const ActivityActionType Spectate = 2;
}

// Namespace: Discord
public enum ActivityJoinRequestReply // TypeDefIndex: 13205
{
	// Fields
	public int value__; // 0x0
	public const ActivityJoinRequestReply No = 0;
	public const ActivityJoinRequestReply Yes = 1;
	public const ActivityJoinRequestReply Ignore = 2;
}

// Namespace: Discord
public enum Status // TypeDefIndex: 13206
{
	// Fields
	public int value__; // 0x0
	public const Status Offline = 0;
	public const Status Online = 1;
	public const Status Idle = 2;
	public const Status DoNotDisturb = 3;
}

// Namespace: Discord
public enum RelationshipType // TypeDefIndex: 13207
{
	// Fields
	public int value__; // 0x0
	public const RelationshipType None = 0;
	public const RelationshipType Friend = 1;
	public const RelationshipType Blocked = 2;
	public const RelationshipType PendingIncoming = 3;
	public const RelationshipType PendingOutgoing = 4;
	public const RelationshipType Implicit = 5;
}

// Namespace: Discord
public enum LobbyType // TypeDefIndex: 13208
{
	// Fields
	public int value__; // 0x0
	public const LobbyType Private = 1;
	public const LobbyType Public = 2;
}

// Namespace: Discord
public enum LobbySearchComparison // TypeDefIndex: 13209
{
	// Fields
	public int value__; // 0x0
	public const LobbySearchComparison LessThanOrEqual = -2;
	public const LobbySearchComparison LessThan = -1;
	public const LobbySearchComparison Equal = 0;
	public const LobbySearchComparison GreaterThan = 1;
	public const LobbySearchComparison GreaterThanOrEqual = 2;
	public const LobbySearchComparison NotEqual = 3;
}

// Namespace: Discord
public enum LobbySearchCast // TypeDefIndex: 13210
{
	// Fields
	public int value__; // 0x0
	public const LobbySearchCast String = 1;
	public const LobbySearchCast Number = 2;
}

// Namespace: Discord
public enum LobbySearchDistance // TypeDefIndex: 13211
{
	// Fields
	public int value__; // 0x0
	public const LobbySearchDistance Local = 0;
	public const LobbySearchDistance Default = 1;
	public const LobbySearchDistance Extended = 2;
	public const LobbySearchDistance Global = 3;
}

// Namespace: Discord
public enum KeyVariant // TypeDefIndex: 13212
{
	// Fields
	public int value__; // 0x0
	public const KeyVariant Normal = 0;
	public const KeyVariant Right = 1;
	public const KeyVariant Left = 2;
}

// Namespace: Discord
public enum MouseButton // TypeDefIndex: 13213
{
	// Fields
	public int value__; // 0x0
	public const MouseButton Left = 0;
	public const MouseButton Middle = 1;
	public const MouseButton Right = 2;
}

// Namespace: Discord
public enum EntitlementType // TypeDefIndex: 13214
{
	// Fields
	public int value__; // 0x0
	public const EntitlementType Purchase = 1;
	public const EntitlementType PremiumSubscription = 2;
	public const EntitlementType DeveloperGift = 3;
	public const EntitlementType TestModePurchase = 4;
	public const EntitlementType FreePurchase = 5;
	public const EntitlementType UserGift = 6;
	public const EntitlementType PremiumPurchase = 7;
}

// Namespace: Discord
public enum SkuType // TypeDefIndex: 13215
{
	// Fields
	public int value__; // 0x0
	public const SkuType Application = 1;
	public const SkuType DLC = 2;
	public const SkuType Consumable = 3;
	public const SkuType Bundle = 4;
}

// Namespace: Discord
public enum InputModeType // TypeDefIndex: 13216
{
	// Fields
	public int value__; // 0x0
	public const InputModeType VoiceActivity = 0;
	public const InputModeType PushToTalk = 1;
}

// Namespace: Discord
public struct User // TypeDefIndex: 13217
{
	// Fields
	public long Id; // 0x0
	public string Username; // 0x8
	public string Discriminator; // 0x10
	public string Avatar; // 0x18
	public bool Bot; // 0x20
}

// Namespace: Discord
public struct OAuth2Token // TypeDefIndex: 13218
{
	// Fields
	public string AccessToken; // 0x0
	public string Scopes; // 0x8
	public long Expires; // 0x10
}

// Namespace: Discord
public struct ImageHandle // TypeDefIndex: 13219
{
	// Fields
	public ImageType Type; // 0x0
	public long Id; // 0x8
	public uint Size; // 0x10

	// Methods

	// RVA: 0x5D9290 Offset: 0x5D7890 VA: 0x1805D9290
	public static ImageHandle User(long id) { }

	// RVA: 0x5D9270 Offset: 0x5D7870 VA: 0x1805D9270
	public static ImageHandle User(long id, uint size) { }
}

// Namespace: Discord
public struct ImageDimensions // TypeDefIndex: 13220
{
	// Fields
	public uint Width; // 0x0
	public uint Height; // 0x4
}

// Namespace: Discord
public struct ActivityTimestamps // TypeDefIndex: 13221
{
	// Fields
	public long Start; // 0x0
	public long End; // 0x8
}

// Namespace: Discord
public struct ActivityAssets // TypeDefIndex: 13222
{
	// Fields
	public string LargeImage; // 0x0
	public string LargeText; // 0x8
	public string SmallImage; // 0x10
	public string SmallText; // 0x18
}

// Namespace: Discord
public struct PartySize // TypeDefIndex: 13223
{
	// Fields
	public int CurrentSize; // 0x0
	public int MaxSize; // 0x4
}

// Namespace: Discord
public struct ActivityParty // TypeDefIndex: 13224
{
	// Fields
	public string Id; // 0x0
	public PartySize Size; // 0x8
	public ActivityPartyPrivacy Privacy; // 0x10
}

// Namespace: Discord
public struct ActivitySecrets // TypeDefIndex: 13225
{
	// Fields
	public string Match; // 0x0
	public string Join; // 0x8
	public string Spectate; // 0x10
}

// Namespace: Discord
public struct Activity // TypeDefIndex: 13226
{
	// Fields
	public ActivityType Type; // 0x0
	public long ApplicationId; // 0x8
	public string Name; // 0x10
	public string State; // 0x18
	public string Details; // 0x20
	public ActivityTimestamps Timestamps; // 0x28
	public ActivityAssets Assets; // 0x38
	public ActivityParty Party; // 0x58
	public ActivitySecrets Secrets; // 0x70
	public bool Instance; // 0x88
}

// Namespace: Discord
public struct Presence // TypeDefIndex: 13227
{
	// Fields
	public Status Status; // 0x0
	public Activity Activity; // 0x8
}

// Namespace: Discord
public struct Relationship // TypeDefIndex: 13228
{
	// Fields
	public RelationshipType Type; // 0x0
	public User User; // 0x8
	public Presence Presence; // 0x30
}

// Namespace: Discord
public struct Lobby // TypeDefIndex: 13229
{
	// Fields
	public long Id; // 0x0
	public LobbyType Type; // 0x8
	public long OwnerId; // 0x10
	public string Secret; // 0x18
	public uint Capacity; // 0x20
	public bool Locked; // 0x24
}

// Namespace: Discord
public struct ImeUnderline // TypeDefIndex: 13230
{
	// Fields
	public int From; // 0x0
	public int To; // 0x4
	public uint Color; // 0x8
	public uint BackgroundColor; // 0xC
	public bool Thick; // 0x10
}

// Namespace: Discord
public struct Rect // TypeDefIndex: 13231
{
	// Fields
	public int Left; // 0x0
	public int Top; // 0x4
	public int Right; // 0x8
	public int Bottom; // 0xC
}

// Namespace: Discord
public struct FileStat // TypeDefIndex: 13232
{
	// Fields
	public string Filename; // 0x0
	public ulong Size; // 0x8
	public ulong LastModified; // 0x10
}

// Namespace: Discord
public struct Entitlement // TypeDefIndex: 13233
{
	// Fields
	public long Id; // 0x0
	public EntitlementType Type; // 0x8
	public long SkuId; // 0x10
}

// Namespace: Discord
public struct SkuPrice // TypeDefIndex: 13234
{
	// Fields
	public uint Amount; // 0x0
	public string Currency; // 0x8
}

// Namespace: Discord
public struct Sku // TypeDefIndex: 13235
{
	// Fields
	public long Id; // 0x0
	public SkuType Type; // 0x8
	public string Name; // 0x10
	public SkuPrice Price; // 0x18
}

// Namespace: Discord
public struct InputMode // TypeDefIndex: 13236
{
	// Fields
	public InputModeType Type; // 0x0
	public string Shortcut; // 0x8
}

// Namespace: Discord
public struct UserAchievement // TypeDefIndex: 13237
{
	// Fields
	public long UserId; // 0x0
	public long AchievementId; // 0x8
	public byte PercentComplete; // 0x10
	public string UnlockedAt; // 0x18
}

// Namespace: Discord
public struct LobbyTransaction // TypeDefIndex: 13245
{
	// Fields
	internal IntPtr MethodsPtr; // 0x0
	internal object MethodsStructure; // 0x8

	// Properties
	private LobbyTransaction.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5E0F70 Offset: 0x5DF570 VA: 0x1805E0F70
	private LobbyTransaction.FFIMethods get_Methods() { }

	// RVA: 0x5E0ED0 Offset: 0x5DF4D0 VA: 0x1805E0ED0
	public void SetType(LobbyType type) { }

	// RVA: 0x5E0E20 Offset: 0x5DF420 VA: 0x1805E0E20
	public void SetOwner(long ownerId) { }

	// RVA: 0x5E0C10 Offset: 0x5DF210 VA: 0x1805E0C10
	public void SetCapacity(uint capacity) { }

	// RVA: 0x5E0D60 Offset: 0x5DF360 VA: 0x1805E0D60
	public void SetMetadata(string key, string value) { }

	// RVA: 0x5E0B70 Offset: 0x5DF170 VA: 0x1805E0B70
	public void DeleteMetadata(string key) { }

	// RVA: 0x5E0CB0 Offset: 0x5DF2B0 VA: 0x1805E0CB0
	public void SetLocked(bool locked) { }
}

// Namespace: Discord
public struct LobbyMemberTransaction // TypeDefIndex: 13249
{
	// Fields
	internal IntPtr MethodsPtr; // 0x0
	internal object MethodsStructure; // 0x8

	// Properties
	private LobbyMemberTransaction.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5E03E0 Offset: 0x5DE9E0 VA: 0x1805E03E0
	private LobbyMemberTransaction.FFIMethods get_Methods() { }

	// RVA: 0x5E0330 Offset: 0x5DE930 VA: 0x1805E0330
	public void SetMetadata(string key, string value) { }

	// RVA: 0x5E0290 Offset: 0x5DE890 VA: 0x1805E0290
	public void DeleteMetadata(string key) { }
}

// Namespace: Discord
public struct LobbySearchQuery // TypeDefIndex: 13255
{
	// Fields
	internal IntPtr MethodsPtr; // 0x0
	internal object MethodsStructure; // 0x8

	// Properties
	private LobbySearchQuery.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5E0A60 Offset: 0x5DF060 VA: 0x1805E0A60
	private LobbySearchQuery.FFIMethods get_Methods() { }

	// RVA: 0x5E0810 Offset: 0x5DEE10 VA: 0x1805E0810
	public void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value) { }

	// RVA: 0x5E0990 Offset: 0x5DEF90 VA: 0x1805E0990
	public void Sort(string key, LobbySearchCast cast, string value) { }

	// RVA: 0x5E08F0 Offset: 0x5DEEF0 VA: 0x1805E08F0
	public void Limit(uint limit) { }

	// RVA: 0x5E0770 Offset: 0x5DED70 VA: 0x1805E0770
	public void Distance(LobbySearchDistance distance) { }
}

// Namespace: Discord
public class ResultException : Exception // TypeDefIndex: 13256
{
	// Fields
	public readonly Result Result; // 0x90

	// Methods

	// RVA: 0x5E36C0 Offset: 0x5E1CC0 VA: 0x1805E36C0
	public void .ctor(Result result) { }
}

// Namespace: Discord
public class Discord : IDisposable // TypeDefIndex: 13277
{
	// Fields
	private GCHandle SelfHandle; // 0x10
	private IntPtr EventsPtr; // 0x18
	private Discord.FFIEvents Events; // 0x20
	private IntPtr ApplicationEventsPtr; // 0x28
	private ApplicationManager.FFIEvents ApplicationEvents; // 0x30
	internal ApplicationManager ApplicationManagerInstance; // 0x38
	private IntPtr UserEventsPtr; // 0x40
	private UserManager.FFIEvents UserEvents; // 0x48
	internal UserManager UserManagerInstance; // 0x50
	private IntPtr ImageEventsPtr; // 0x58
	private ImageManager.FFIEvents ImageEvents; // 0x60
	internal ImageManager ImageManagerInstance; // 0x68
	private IntPtr ActivityEventsPtr; // 0x70
	private ActivityManager.FFIEvents ActivityEvents; // 0x78
	internal ActivityManager ActivityManagerInstance; // 0x98
	private IntPtr RelationshipEventsPtr; // 0xA0
	private RelationshipManager.FFIEvents RelationshipEvents; // 0xA8
	internal RelationshipManager RelationshipManagerInstance; // 0xB8
	private IntPtr LobbyEventsPtr; // 0xC0
	private LobbyManager.FFIEvents LobbyEvents; // 0xC8
	internal LobbyManager LobbyManagerInstance; // 0x108
	private IntPtr NetworkEventsPtr; // 0x110
	private NetworkManager.FFIEvents NetworkEvents; // 0x118
	internal NetworkManager NetworkManagerInstance; // 0x128
	private IntPtr OverlayEventsPtr; // 0x130
	private OverlayManager.FFIEvents OverlayEvents; // 0x138
	internal OverlayManager OverlayManagerInstance; // 0x140
	private IntPtr StorageEventsPtr; // 0x148
	private StorageManager.FFIEvents StorageEvents; // 0x150
	internal StorageManager StorageManagerInstance; // 0x158
	private IntPtr StoreEventsPtr; // 0x160
	private StoreManager.FFIEvents StoreEvents; // 0x168
	internal StoreManager StoreManagerInstance; // 0x178
	private IntPtr VoiceEventsPtr; // 0x180
	private VoiceManager.FFIEvents VoiceEvents; // 0x188
	internal VoiceManager VoiceManagerInstance; // 0x190
	private IntPtr AchievementEventsPtr; // 0x198
	private AchievementManager.FFIEvents AchievementEvents; // 0x1A0
	internal AchievementManager AchievementManagerInstance; // 0x1A8
	private IntPtr MethodsPtr; // 0x1B0
	private object MethodsStructure; // 0x1B8
	private Nullable<GCHandle> setLogHook; // 0x1C0

	// Properties
	private Discord.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5D5210 Offset: 0x5D3810 VA: 0x1805D5210
	private static extern Result DiscordCreate(uint version, ref Discord.FFICreateParams createParams, out IntPtr manager) { }

	// RVA: 0x5D6FD0 Offset: 0x5D55D0 VA: 0x1805D6FD0
	private Discord.FFIMethods get_Methods() { }

	// RVA: 0x5D6A60 Offset: 0x5D5060 VA: 0x1805D6A60
	public void .ctor(long clientId, ulong flags) { }

	// RVA: 0x5D6640 Offset: 0x5D4C40 VA: 0x1805D6640
	private void InitEvents(IntPtr eventsPtr, ref Discord.FFIEvents events) { }

	// RVA: 0x5D52B0 Offset: 0x5D38B0 VA: 0x1805D52B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x5D66B0 Offset: 0x5D4CB0 VA: 0x1805D66B0
	public void RunCallbacks() { }

	[MonoPInvokeCallback]
	// RVA: 0x5D6760 Offset: 0x5D4D60 VA: 0x1805D6760
	private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message) { }

	// RVA: 0x5D6870 Offset: 0x5D4E70 VA: 0x1805D6870
	public void SetLogHook(LogLevel minLevel, Discord.SetLogHookHandler callback) { }

	// RVA: 0x5D56F0 Offset: 0x5D3CF0 VA: 0x1805D56F0
	public ApplicationManager GetApplicationManager() { }

	// RVA: 0x5D6270 Offset: 0x5D4870 VA: 0x1805D6270
	public UserManager GetUserManager() { }

	// RVA: 0x5D58C0 Offset: 0x5D3EC0 VA: 0x1805D58C0
	public ImageManager GetImageManager() { }

	// RVA: 0x5D5560 Offset: 0x5D3B60 VA: 0x1805D5560
	public ActivityManager GetActivityManager() { }

	// RVA: 0x5D5EC0 Offset: 0x5D44C0 VA: 0x1805D5EC0
	public RelationshipManager GetRelationshipManager() { }

	// RVA: 0x5D5A90 Offset: 0x5D4090 VA: 0x1805D5A90
	public LobbyManager GetLobbyManager() { }

	// RVA: 0x5D5C20 Offset: 0x5D4220 VA: 0x1805D5C20
	public NetworkManager GetNetworkManager() { }

	// RVA: 0x5D5DC0 Offset: 0x5D43C0 VA: 0x1805D5DC0
	public OverlayManager GetOverlayManager() { }

	// RVA: 0x5D6060 Offset: 0x5D4660 VA: 0x1805D6060
	public StorageManager GetStorageManager() { }

	// RVA: 0x5D6170 Offset: 0x5D4770 VA: 0x1805D6170
	public StoreManager GetStoreManager() { }

	// RVA: 0x5D6530 Offset: 0x5D4B30 VA: 0x1805D6530
	public VoiceManager GetVoiceManager() { }

	// RVA: 0x5D5450 Offset: 0x5D3A50 VA: 0x1805D5450
	public AchievementManager GetAchievementManager() { }
}

// Namespace: Discord
internal class MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 13278
{
	// Methods

	// RVA: 0x34A4D0 Offset: 0x348AD0 VA: 0x18034A4D0
	public void .ctor() { }
}

// Namespace: Discord
public class ApplicationManager // TypeDefIndex: 13292
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private ApplicationManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5D3FD0 Offset: 0x5D25D0 VA: 0x1805D3FD0
	private ApplicationManager.FFIMethods get_Methods() { }

	// RVA: 0x5D3EB0 Offset: 0x5D24B0 VA: 0x1805D3EB0
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref ApplicationManager.FFIEvents events) { }

	// RVA: 0x5D3BD0 Offset: 0x5D21D0 VA: 0x1805D3BD0
	private void InitEvents(IntPtr eventsPtr, ref ApplicationManager.FFIEvents events) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D3C40 Offset: 0x5D2240 VA: 0x1805D3C40
	private static void ValidateOrExitCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5D3D60 Offset: 0x5D2360 VA: 0x1805D3D60
	public void ValidateOrExit(ApplicationManager.ValidateOrExitHandler callback) { }

	// RVA: 0x5D3600 Offset: 0x5D1C00 VA: 0x1805D3600
	public string GetCurrentLocale() { }

	// RVA: 0x5D3550 Offset: 0x5D1B50 VA: 0x1805D3550
	public string GetCurrentBranch() { }

	[MonoPInvokeCallback]
	// RVA: 0x5D36B0 Offset: 0x5D1CB0 VA: 0x1805D36B0
	private static void GetOAuth2TokenCallbackImpl(IntPtr ptr, Result result, ref OAuth2Token oauth2Token) { }

	// RVA: 0x5D37E0 Offset: 0x5D1DE0 VA: 0x1805D37E0
	public void GetOAuth2Token(ApplicationManager.GetOAuth2TokenHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D3940 Offset: 0x5D1F40 VA: 0x1805D3940
	private static void GetTicketCallbackImpl(IntPtr ptr, Result result, ref string data) { }

	// RVA: 0x5D3A70 Offset: 0x5D2070 VA: 0x1805D3A70
	public void GetTicket(ApplicationManager.GetTicketHandler callback) { }
}

// Namespace: Discord
public class UserManager // TypeDefIndex: 13303
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private UserManager.CurrentUserUpdateHandler OnCurrentUserUpdate; // 0x20

	// Properties
	private UserManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5E59B0 Offset: 0x5E3FB0 VA: 0x1805E59B0
	private UserManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x5E5910 Offset: 0x5E3F10 VA: 0x1805E5910
	public void add_OnCurrentUserUpdate(UserManager.CurrentUserUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E5AC0 Offset: 0x5E40C0 VA: 0x1805E5AC0
	public void remove_OnCurrentUserUpdate(UserManager.CurrentUserUpdateHandler value) { }

	// RVA: 0x5E5720 Offset: 0x5E3D20 VA: 0x1805E5720
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref UserManager.FFIEvents events) { }

	// RVA: 0x5E54B0 Offset: 0x5E3AB0 VA: 0x1805E54B0
	private void InitEvents(IntPtr eventsPtr, ref UserManager.FFIEvents events) { }

	// RVA: 0x5E5180 Offset: 0x5E3780 VA: 0x1805E5180
	public User GetCurrentUser() { }

	[MonoPInvokeCallback]
	// RVA: 0x5E5220 Offset: 0x5E3820 VA: 0x1805E5220
	private static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user) { }

	// RVA: 0x5E5350 Offset: 0x5E3950 VA: 0x1805E5350
	public void GetUser(long userId, UserManager.GetUserHandler callback) { }

	// RVA: 0x5E50E0 Offset: 0x5E36E0 VA: 0x1805E50E0
	public PremiumType GetCurrentUserPremiumType() { }

	// RVA: 0x5E5020 Offset: 0x5E3620 VA: 0x1805E5020
	public bool CurrentUserHasFlag(UserFlag flag) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E5600 Offset: 0x5E3C00 VA: 0x1805E5600
	private static void OnCurrentUserUpdateImpl(IntPtr ptr) { }
}

// Namespace: Discord
public class ImageManager // TypeDefIndex: 13311
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private ImageManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5D9DE0 Offset: 0x5D83E0 VA: 0x1805D9DE0
	private ImageManager.FFIMethods get_Methods() { }

	// RVA: 0x5D9CC0 Offset: 0x5D82C0 VA: 0x1805D9CC0
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref ImageManager.FFIEvents events) { }

	// RVA: 0x5D9C50 Offset: 0x5D8250 VA: 0x1805D9C50
	private void InitEvents(IntPtr eventsPtr, ref ImageManager.FFIEvents events) { }

	[MonoPInvokeCallback]
	// RVA: 0x5D92D0 Offset: 0x5D78D0 VA: 0x1805D92D0
	private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult) { }

	// RVA: 0x5D9410 Offset: 0x5D7A10 VA: 0x1805D9410
	public void Fetch(ImageHandle handle, bool refresh, ImageManager.FetchHandler callback) { }

	// RVA: 0x5D9980 Offset: 0x5D7F80 VA: 0x1805D9980
	public ImageDimensions GetDimensions(ImageHandle handle) { }

	// RVA: 0x5D9750 Offset: 0x5D7D50 VA: 0x1805D9750
	public void GetData(ImageHandle handle, byte[] data) { }

	// RVA: 0x5D95B0 Offset: 0x5D7BB0 VA: 0x1805D95B0
	public void Fetch(ImageHandle handle, ImageManager.FetchHandler callback) { }

	// RVA: 0x5D9840 Offset: 0x5D7E40 VA: 0x1805D9840
	public byte[] GetData(ImageHandle handle) { }

	// RVA: 0x5D9A60 Offset: 0x5D8060 VA: 0x1805D9A60
	public Texture2D GetTexture(ImageHandle handle) { }
}

// Namespace: Discord
public class RelationshipManager // TypeDefIndex: 13324
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private RelationshipManager.RefreshHandler OnRefresh; // 0x20
	[CompilerGenerated]
	private RelationshipManager.RelationshipUpdateHandler OnRelationshipUpdate; // 0x28

	// Properties
	private RelationshipManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5E3340 Offset: 0x5E1940 VA: 0x1805E3340
	private RelationshipManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x5E3200 Offset: 0x5E1800 VA: 0x1805E3200
	public void add_OnRefresh(RelationshipManager.RefreshHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E3450 Offset: 0x5E1A50 VA: 0x1805E3450
	public void remove_OnRefresh(RelationshipManager.RefreshHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E32A0 Offset: 0x5E18A0 VA: 0x1805E32A0
	public void add_OnRelationshipUpdate(RelationshipManager.RelationshipUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E34F0 Offset: 0x5E1AF0 VA: 0x1805E34F0
	public void remove_OnRelationshipUpdate(RelationshipManager.RelationshipUpdateHandler value) { }

	// RVA: 0x5E3120 Offset: 0x5E1720 VA: 0x1805E3120
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref RelationshipManager.FFIEvents events) { }

	// RVA: 0x5E2CC0 Offset: 0x5E12C0 VA: 0x1805E2CC0
	private void InitEvents(IntPtr eventsPtr, ref RelationshipManager.FFIEvents events) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E28D0 Offset: 0x5E0ED0 VA: 0x1805E28D0
	private static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship) { }

	// RVA: 0x5E29D0 Offset: 0x5E0FD0 VA: 0x1805E29D0
	public void Filter(RelationshipManager.FilterHandler callback) { }

	// RVA: 0x5E2820 Offset: 0x5E0E20 VA: 0x1805E2820
	public int Count() { }

	// RVA: 0x5E2C00 Offset: 0x5E1200 VA: 0x1805E2C00
	public Relationship Get(long userId) { }

	// RVA: 0x5E2B30 Offset: 0x5E1130 VA: 0x1805E2B30
	public Relationship GetAt(uint index) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	private static void OnRefreshImpl(IntPtr ptr) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E2FF0 Offset: 0x5E15F0 VA: 0x1805E2FF0
	private static void OnRelationshipUpdateImpl(IntPtr ptr, ref Relationship relationship) { }
}

// Namespace: Discord
public class LobbyManager // TypeDefIndex: 13398
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private LobbyManager.LobbyUpdateHandler OnLobbyUpdate; // 0x20
	[CompilerGenerated]
	private LobbyManager.LobbyDeleteHandler OnLobbyDelete; // 0x28
	[CompilerGenerated]
	private LobbyManager.MemberConnectHandler OnMemberConnect; // 0x30
	[CompilerGenerated]
	private LobbyManager.MemberUpdateHandler OnMemberUpdate; // 0x38
	[CompilerGenerated]
	private LobbyManager.MemberDisconnectHandler OnMemberDisconnect; // 0x40
	[CompilerGenerated]
	private LobbyManager.LobbyMessageHandler OnLobbyMessage; // 0x48
	[CompilerGenerated]
	private LobbyManager.SpeakingHandler OnSpeaking; // 0x50
	[CompilerGenerated]
	private LobbyManager.NetworkMessageHandler OnNetworkMessage; // 0x58

	// Properties
	private LobbyManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5DFC20 Offset: 0x5DE220 VA: 0x1805DFC20
	private LobbyManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x5DF860 Offset: 0x5DDE60 VA: 0x1805DF860
	public void add_OnLobbyUpdate(LobbyManager.LobbyUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DFED0 Offset: 0x5DE4D0 VA: 0x1805DFED0
	public void remove_OnLobbyUpdate(LobbyManager.LobbyUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DF720 Offset: 0x5DDD20 VA: 0x1805DF720
	public void add_OnLobbyDelete(LobbyManager.LobbyDeleteHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DFD90 Offset: 0x5DE390 VA: 0x1805DFD90
	public void remove_OnLobbyDelete(LobbyManager.LobbyDeleteHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DF900 Offset: 0x5DDF00 VA: 0x1805DF900
	public void add_OnMemberConnect(LobbyManager.MemberConnectHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DFF70 Offset: 0x5DE570 VA: 0x1805DFF70
	public void remove_OnMemberConnect(LobbyManager.MemberConnectHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DFA40 Offset: 0x5DE040 VA: 0x1805DFA40
	public void add_OnMemberUpdate(LobbyManager.MemberUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E00B0 Offset: 0x5DE6B0 VA: 0x1805E00B0
	public void remove_OnMemberUpdate(LobbyManager.MemberUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DF9A0 Offset: 0x5DDFA0 VA: 0x1805DF9A0
	public void add_OnMemberDisconnect(LobbyManager.MemberDisconnectHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E0010 Offset: 0x5DE610 VA: 0x1805E0010
	public void remove_OnMemberDisconnect(LobbyManager.MemberDisconnectHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DF7C0 Offset: 0x5DDDC0 VA: 0x1805DF7C0
	public void add_OnLobbyMessage(LobbyManager.LobbyMessageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DFE30 Offset: 0x5DE430 VA: 0x1805DFE30
	public void remove_OnLobbyMessage(LobbyManager.LobbyMessageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DFB80 Offset: 0x5DE180 VA: 0x1805DFB80
	public void add_OnSpeaking(LobbyManager.SpeakingHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E01F0 Offset: 0x5DE7F0 VA: 0x1805E01F0
	public void remove_OnSpeaking(LobbyManager.SpeakingHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5DFAE0 Offset: 0x5DE0E0 VA: 0x1805DFAE0
	public void add_OnNetworkMessage(LobbyManager.NetworkMessageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E0150 Offset: 0x5DE750 VA: 0x1805E0150
	public void remove_OnNetworkMessage(LobbyManager.NetworkMessageHandler value) { }

	// RVA: 0x5DF640 Offset: 0x5DDC40 VA: 0x1805DF640
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref LobbyManager.FFIEvents events) { }

	// RVA: 0x5DCF20 Offset: 0x5DB520 VA: 0x1805DCF20
	private void InitEvents(IntPtr eventsPtr, ref LobbyManager.FFIEvents events) { }

	// RVA: 0x5DBA60 Offset: 0x5DA060 VA: 0x1805DBA60
	public LobbyTransaction GetLobbyCreateTransaction() { }

	// RVA: 0x5DBFE0 Offset: 0x5DA5E0 VA: 0x1805DBFE0
	public LobbyTransaction GetLobbyUpdateTransaction(long lobbyId) { }

	// RVA: 0x5DC570 Offset: 0x5DAB70 VA: 0x1805DC570
	public LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DAB00 Offset: 0x5D9100 VA: 0x1805DAB00
	private static void CreateLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby) { }

	// RVA: 0x5DAC30 Offset: 0x5D9230 VA: 0x1805DAC30
	public void CreateLobby(LobbyTransaction transaction, LobbyManager.CreateLobbyHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DF040 Offset: 0x5DD640 VA: 0x1805DF040
	private static void UpdateLobbyCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5DF160 Offset: 0x5DD760 VA: 0x1805DF160
	public void UpdateLobby(long lobbyId, LobbyTransaction transaction, LobbyManager.UpdateLobbyHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DAE00 Offset: 0x5D9400 VA: 0x1805DAE00
	private static void DeleteLobbyCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5DAF20 Offset: 0x5D9520 VA: 0x1805DAF20
	public void DeleteLobby(long lobbyId, LobbyManager.DeleteLobbyHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DA100 Offset: 0x5D8700 VA: 0x1805DA100
	private static void ConnectLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby) { }

	// RVA: 0x5DA530 Offset: 0x5D8B30 VA: 0x1805DA530
	public void ConnectLobby(long lobbyId, string secret, LobbyManager.ConnectLobbyHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DA230 Offset: 0x5D8830 VA: 0x1805DA230
	private static void ConnectLobbyWithActivitySecretCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby) { }

	// RVA: 0x5DA360 Offset: 0x5D8960 VA: 0x1805DA360
	public void ConnectLobbyWithActivitySecret(string activitySecret, LobbyManager.ConnectLobbyWithActivitySecretHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DB0F0 Offset: 0x5D96F0 VA: 0x1805DB0F0
	private static void DisconnectLobbyCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5DB210 Offset: 0x5D9810 VA: 0x1805DB210
	public void DisconnectLobby(long lobbyId, LobbyManager.DisconnectLobbyHandler callback) { }

	// RVA: 0x5DC110 Offset: 0x5DA710 VA: 0x1805DC110
	public Lobby GetLobby(long lobbyId) { }

	// RVA: 0x5DB8F0 Offset: 0x5D9EF0 VA: 0x1805DB8F0
	public string GetLobbyActivitySecret(long lobbyId) { }

	// RVA: 0x5DBE50 Offset: 0x5DA450 VA: 0x1805DBE50
	public string GetLobbyMetadataValue(long lobbyId, string key) { }

	// RVA: 0x5DBCC0 Offset: 0x5DA2C0 VA: 0x1805DBCC0
	public string GetLobbyMetadataKey(long lobbyId, int index) { }

	// RVA: 0x5DD690 Offset: 0x5DBC90 VA: 0x1805DD690
	public int LobbyMetadataCount(long lobbyId) { }

	// RVA: 0x5DD7D0 Offset: 0x5DBDD0 VA: 0x1805DD7D0
	public int MemberCount(long lobbyId) { }

	// RVA: 0x5DC6C0 Offset: 0x5DACC0 VA: 0x1805DC6C0
	public long GetMemberUserId(long lobbyId, int index) { }

	// RVA: 0x5DC800 Offset: 0x5DAE00 VA: 0x1805DC800
	public User GetMemberUser(long lobbyId, long userId) { }

	// RVA: 0x5DC3E0 Offset: 0x5DA9E0 VA: 0x1805DC3E0
	public string GetMemberMetadataValue(long lobbyId, long userId, string key) { }

	// RVA: 0x5DC250 Offset: 0x5DA850 VA: 0x1805DC250
	public string GetMemberMetadataKey(long lobbyId, long userId, int index) { }

	// RVA: 0x5DD910 Offset: 0x5DBF10 VA: 0x1805DD910
	public int MemberMetadataCount(long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DF330 Offset: 0x5DD930 VA: 0x1805DF330
	private static void UpdateMemberCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5DF450 Offset: 0x5DDA50 VA: 0x1805DF450
	public void UpdateMember(long lobbyId, long userId, LobbyMemberTransaction transaction, LobbyManager.UpdateMemberHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DE9C0 Offset: 0x5DCFC0 VA: 0x1805DE9C0
	private static void SendLobbyMessageCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5DECF0 Offset: 0x5DD2F0 VA: 0x1805DECF0
	public void SendLobbyMessage(long lobbyId, byte[] data, LobbyManager.SendLobbyMessageHandler callback) { }

	// RVA: 0x5DCE00 Offset: 0x5DB400 VA: 0x1805DCE00
	public LobbySearchQuery GetSearchQuery() { }

	[MonoPInvokeCallback]
	// RVA: 0x5DE6D0 Offset: 0x5DCCD0 VA: 0x1805DE6D0
	private static void SearchCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5DE7F0 Offset: 0x5DCDF0 VA: 0x1805DE7F0
	public void Search(LobbySearchQuery query, LobbyManager.SearchHandler callback) { }

	// RVA: 0x5DD5B0 Offset: 0x5DBBB0 VA: 0x1805DD5B0
	public int LobbyCount() { }

	// RVA: 0x5DBB80 Offset: 0x5DA180 VA: 0x1805DBB80
	public long GetLobbyId(int index) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DA810 Offset: 0x5D8E10 VA: 0x1805DA810
	private static void ConnectVoiceCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5DA930 Offset: 0x5D8F30 VA: 0x1805DA930
	public void ConnectVoice(long lobbyId, LobbyManager.ConnectVoiceHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DB4F0 Offset: 0x5D9AF0 VA: 0x1805DB4F0
	private static void DisconnectVoiceCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5DB610 Offset: 0x5D9C10 VA: 0x1805DB610
	public void DisconnectVoice(long lobbyId, LobbyManager.DisconnectVoiceHandler callback) { }

	// RVA: 0x5DA700 Offset: 0x5D8D00 VA: 0x1805DA700
	public void ConnectNetwork(long lobbyId) { }

	// RVA: 0x5DB3E0 Offset: 0x5D99E0 VA: 0x1805DB3E0
	public void DisconnectNetwork(long lobbyId) { }

	// RVA: 0x5DB7E0 Offset: 0x5D9DE0 VA: 0x1805DB7E0
	public void FlushNetwork() { }

	// RVA: 0x5DE580 Offset: 0x5DCB80 VA: 0x1805DE580
	public void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable) { }

	// RVA: 0x5DEEE0 Offset: 0x5DD4E0 VA: 0x1805DEEE0
	public void SendNetworkMessage(long lobbyId, long userId, byte channelId, byte[] data) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DDD60 Offset: 0x5DC360 VA: 0x1805DDD60
	private static void OnLobbyUpdateImpl(IntPtr ptr, long lobbyId) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DDA50 Offset: 0x5DC050 VA: 0x1805DDA50
	private static void OnLobbyDeleteImpl(IntPtr ptr, long lobbyId, uint reason) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DDE90 Offset: 0x5DC490 VA: 0x1805DDE90
	private static void OnMemberConnectImpl(IntPtr ptr, long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DE110 Offset: 0x5DC710 VA: 0x1805DE110
	private static void OnMemberUpdateImpl(IntPtr ptr, long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DDFD0 Offset: 0x5DC5D0 VA: 0x1805DDFD0
	private static void OnMemberDisconnectImpl(IntPtr ptr, long lobbyId, long userId) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DDB90 Offset: 0x5DC190 VA: 0x1805DDB90
	private static void OnLobbyMessageImpl(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DE430 Offset: 0x5DCA30 VA: 0x1805DE430
	private static void OnSpeakingImpl(IntPtr ptr, long lobbyId, long userId, bool speaking) { }

	[MonoPInvokeCallback]
	// RVA: 0x5DE250 Offset: 0x5DC850 VA: 0x1805DE250
	private static void OnNetworkMessageImpl(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x5DC940 Offset: 0x5DAF40 VA: 0x1805DC940
	public IEnumerable<User> GetMemberUsers(long lobbyID) { }

	// RVA: 0x5DEAE0 Offset: 0x5DD0E0 VA: 0x1805DEAE0
	public void SendLobbyMessage(long lobbyID, string data, LobbyManager.SendLobbyMessageHandler handler) { }
}

// Namespace: Discord
public class NetworkManager // TypeDefIndex: 13413
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private NetworkManager.MessageHandler OnMessage; // 0x20
	[CompilerGenerated]
	private NetworkManager.RouteUpdateHandler OnRouteUpdate; // 0x28

	// Properties
	private NetworkManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5E20D0 Offset: 0x5E06D0 VA: 0x1805E20D0
	private NetworkManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x5E1F90 Offset: 0x5E0590 VA: 0x1805E1F90
	public void add_OnMessage(NetworkManager.MessageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E21F0 Offset: 0x5E07F0 VA: 0x1805E21F0
	public void remove_OnMessage(NetworkManager.MessageHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E2030 Offset: 0x5E0630 VA: 0x1805E2030
	public void add_OnRouteUpdate(NetworkManager.RouteUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E2290 Offset: 0x5E0890 VA: 0x1805E2290
	public void remove_OnRouteUpdate(NetworkManager.RouteUpdateHandler value) { }

	// RVA: 0x5E1EB0 Offset: 0x5E04B0 VA: 0x1805E1EB0
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref NetworkManager.FFIEvents events) { }

	// RVA: 0x5E1660 Offset: 0x5DFC60 VA: 0x1805E1660
	private void InitEvents(IntPtr eventsPtr, ref NetworkManager.FFIEvents events) { }

	// RVA: 0x5E1600 Offset: 0x5DFC00 VA: 0x1805E1600
	public ulong GetPeerId() { }

	// RVA: 0x5E1550 Offset: 0x5DFB50 VA: 0x1805E1550
	public void Flush() { }

	// RVA: 0x5E1C50 Offset: 0x5E0250 VA: 0x1805E1C50
	public void OpenPeer(ulong peerId, string routeData) { }

	// RVA: 0x5E1DF0 Offset: 0x5E03F0 VA: 0x1805E1DF0
	public void UpdatePeer(ulong peerId, string routeData) { }

	// RVA: 0x5E14B0 Offset: 0x5DFAB0 VA: 0x1805E14B0
	public void ClosePeer(ulong peerId) { }

	// RVA: 0x5E1B80 Offset: 0x5E0180 VA: 0x1805E1B80
	public void OpenChannel(ulong peerId, byte channelId, bool reliable) { }

	// RVA: 0x5E13F0 Offset: 0x5DF9F0 VA: 0x1805E13F0
	public void CloseChannel(ulong peerId, byte channelId) { }

	// RVA: 0x5E1D00 Offset: 0x5E0300 VA: 0x1805E1D00
	public void SendMessage(ulong peerId, byte channelId, byte[] data) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E1870 Offset: 0x5DFE70 VA: 0x1805E1870
	private static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E1A50 Offset: 0x5E0050 VA: 0x1805E1A50
	private static void OnRouteUpdateImpl(IntPtr ptr, string routeData) { }
}

// Namespace: Discord
public class OverlayManager // TypeDefIndex: 13449
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private OverlayManager.ToggleHandler OnToggle; // 0x20

	// Properties
	private OverlayManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5E9F70 Offset: 0x5E8570 VA: 0x1805E9F70
	private OverlayManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x5E9ED0 Offset: 0x5E84D0 VA: 0x1805E9ED0
	public void add_OnToggle(OverlayManager.ToggleHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5EA0D0 Offset: 0x5E86D0 VA: 0x1805EA0D0
	public void remove_OnToggle(OverlayManager.ToggleHandler value) { }

	// RVA: 0x5E9CE0 Offset: 0x5E82E0 VA: 0x1805E9CE0
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref OverlayManager.FFIEvents events) { }

	// RVA: 0x5E8800 Offset: 0x5E6E00 VA: 0x1805E8800
	private void InitEvents(IntPtr eventsPtr, ref OverlayManager.FFIEvents events) { }

	// RVA: 0x5E8950 Offset: 0x5E6F50 VA: 0x1805E8950
	public bool IsEnabled() { }

	// RVA: 0x5E89B0 Offset: 0x5E6FB0 VA: 0x1805E89B0
	public bool IsLocked() { }

	[MonoPInvokeCallback]
	// RVA: 0x5E9A60 Offset: 0x5E8060 VA: 0x1805E9A60
	private static void SetLockedCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5E9B80 Offset: 0x5E8180 VA: 0x1805E9B80
	public void SetLocked(bool locked, OverlayManager.SetLockedHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E8DA0 Offset: 0x5E73A0 VA: 0x1805E8DA0
	private static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5E8EC0 Offset: 0x5E74C0 VA: 0x1805E8EC0
	public void OpenActivityInvite(ActivityActionType type, OverlayManager.OpenActivityInviteHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E9030 Offset: 0x5E7630 VA: 0x1805E9030
	private static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5E9150 Offset: 0x5E7750 VA: 0x1805E9150
	public void OpenGuildInvite(string code, OverlayManager.OpenGuildInviteHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E92B0 Offset: 0x5E78B0 VA: 0x1805E92B0
	private static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5E93D0 Offset: 0x5E79D0 VA: 0x1805E93D0
	public void OpenVoiceSettings(OverlayManager.OpenVoiceSettingsHandler callback) { }

	// RVA: 0x5E8740 Offset: 0x5E6D40 VA: 0x1805E8740
	public void InitDrawingDxgi(IntPtr swapchain, bool useMessageForwarding) { }

	// RVA: 0x5E8C20 Offset: 0x5E7220 VA: 0x1805E8C20
	public void OnPresent() { }

	// RVA: 0x5E85A0 Offset: 0x5E6BA0 VA: 0x1805E85A0
	public void ForwardMessage(IntPtr message) { }

	// RVA: 0x5E8A90 Offset: 0x5E7090 VA: 0x1805E8A90
	public void KeyEvent(bool down, string keyCode, KeyVariant variant) { }

	// RVA: 0x5E8540 Offset: 0x5E6B40 VA: 0x1805E8540
	public void CharEvent(string character) { }

	// RVA: 0x5E8B10 Offset: 0x5E7110 VA: 0x1805E8B10
	public void MouseButtonEvent(byte down, int clickCount, MouseButton which, int x, int y) { }

	// RVA: 0x5E8BB0 Offset: 0x5E71B0 VA: 0x1805E8BB0
	public void MouseMotionEvent(int x, int y) { }

	// RVA: 0x5E8650 Offset: 0x5E6C50 VA: 0x1805E8650
	public void ImeCommitText(string text) { }

	// RVA: 0x5E86B0 Offset: 0x5E6CB0 VA: 0x1805E86B0
	public void ImeSetComposition(string text, ImeUnderline underlines, int from, int to) { }

	// RVA: 0x5E8600 Offset: 0x5E6C00 VA: 0x1805E8600
	public void ImeCancelComposition() { }

	[MonoPInvokeCallback]
	// RVA: 0x5E9530 Offset: 0x5E7B30 VA: 0x1805E9530
	private static void SetImeCompositionRangeCallbackCallbackImpl(IntPtr ptr, int from, int to, ref Rect bounds) { }

	// RVA: 0x5E9660 Offset: 0x5E7C60 VA: 0x1805E9660
	public void SetImeCompositionRangeCallback(OverlayManager.SetImeCompositionRangeCallbackHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E97B0 Offset: 0x5E7DB0 VA: 0x1805E97B0
	private static void SetImeSelectionBoundsCallbackCallbackImpl(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst) { }

	// RVA: 0x5E9900 Offset: 0x5E7F00 VA: 0x1805E9900
	public void SetImeSelectionBoundsCallback(OverlayManager.SetImeSelectionBoundsCallbackHandler callback) { }

	// RVA: 0x5E8A20 Offset: 0x5E7020 VA: 0x1805E8A20
	public bool IsPointInsideClickZone(int x, int y) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E8C70 Offset: 0x5E7270 VA: 0x1805E8C70
	private static void OnToggleImpl(IntPtr ptr, bool locked) { }
}

// Namespace: Discord
public class StorageManager // TypeDefIndex: 13469
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18

	// Properties
	private StorageManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5ECB80 Offset: 0x5EB180 VA: 0x1805ECB80
	private StorageManager.FFIMethods get_Methods() { }

	// RVA: 0x5ECA60 Offset: 0x5EB060 VA: 0x1805ECA60
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref StorageManager.FFIEvents events) { }

	// RVA: 0x5EBDE0 Offset: 0x5EA3E0 VA: 0x1805EBDE0
	private void InitEvents(IntPtr eventsPtr, ref StorageManager.FFIEvents events) { }

	// RVA: 0x5EC460 Offset: 0x5EAA60 VA: 0x1805EC460
	public uint Read(string name, byte[] data) { }

	[MonoPInvokeCallback]
	// RVA: 0x5EBE50 Offset: 0x5EA450 VA: 0x1805EBE50
	private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x5EC2F0 Offset: 0x5EA8F0 VA: 0x1805EC2F0
	public void ReadAsync(string name, StorageManager.ReadAsyncHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5EBFE0 Offset: 0x5EA5E0 VA: 0x1805EBFE0
	private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	// RVA: 0x5EC170 Offset: 0x5EA770 VA: 0x1805EC170
	public void ReadAsyncPartial(string name, ulong offset, ulong length, StorageManager.ReadAsyncPartialHandler callback) { }

	// RVA: 0x5EC990 Offset: 0x5EAF90 VA: 0x1805EC990
	public void Write(string name, byte[] data) { }

	[MonoPInvokeCallback]
	// RVA: 0x5EC6E0 Offset: 0x5EACE0 VA: 0x1805EC6E0
	private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5EC800 Offset: 0x5EAE00 VA: 0x1805EC800
	public void WriteAsync(string name, byte[] data, StorageManager.WriteAsyncHandler callback) { }

	// RVA: 0x5EB920 Offset: 0x5E9F20 VA: 0x1805EB920
	public void Delete(string name) { }

	// RVA: 0x5EB9D0 Offset: 0x5E9FD0 VA: 0x1805EB9D0
	public bool Exists(string name) { }

	// RVA: 0x5EB8B0 Offset: 0x5E9EB0 VA: 0x1805EB8B0
	public int Count() { }

	// RVA: 0x5EC620 Offset: 0x5EAC20 VA: 0x1805EC620
	public FileStat Stat(string name) { }

	// RVA: 0x5EC550 Offset: 0x5EAB50 VA: 0x1805EC550
	public FileStat StatAt(int index) { }

	// RVA: 0x5EBCE0 Offset: 0x5EA2E0 VA: 0x1805EBCE0
	public string GetPath() { }

	// RVA: 0x5EBA90 Offset: 0x5EA090 VA: 0x1805EBA90
	public IEnumerable<FileStat> Files() { }
}

// Namespace: Discord
public class StoreManager // TypeDefIndex: 13492
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private StoreManager.EntitlementCreateHandler OnEntitlementCreate; // 0x20
	[CompilerGenerated]
	private StoreManager.EntitlementDeleteHandler OnEntitlementDelete; // 0x28

	// Properties
	private StoreManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5EE450 Offset: 0x5ECA50 VA: 0x1805EE450
	private StoreManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x5EE310 Offset: 0x5EC910 VA: 0x1805EE310
	public void add_OnEntitlementCreate(StoreManager.EntitlementCreateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5EE580 Offset: 0x5ECB80 VA: 0x1805EE580
	public void remove_OnEntitlementCreate(StoreManager.EntitlementCreateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5EE3B0 Offset: 0x5EC9B0 VA: 0x1805EE3B0
	public void add_OnEntitlementDelete(StoreManager.EntitlementDeleteHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5EE620 Offset: 0x5ECC20 VA: 0x1805EE620
	public void remove_OnEntitlementDelete(StoreManager.EntitlementDeleteHandler value) { }

	// RVA: 0x5EE230 Offset: 0x5EC830 VA: 0x1805EE230
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref StoreManager.FFIEvents events) { }

	// RVA: 0x5EDB30 Offset: 0x5EC130 VA: 0x1805EDB30
	private void InitEvents(IntPtr eventsPtr, ref StoreManager.FFIEvents events) { }

	[MonoPInvokeCallback]
	// RVA: 0x5ED000 Offset: 0x5EB600 VA: 0x1805ED000
	private static void FetchSkusCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5ED120 Offset: 0x5EB720 VA: 0x1805ED120
	public void FetchSkus(StoreManager.FetchSkusHandler callback) { }

	// RVA: 0x5ECD20 Offset: 0x5EB320 VA: 0x1805ECD20
	public int CountSkus() { }

	// RVA: 0x5ED710 Offset: 0x5EBD10 VA: 0x1805ED710
	public Sku GetSku(long skuId) { }

	// RVA: 0x5ED640 Offset: 0x5EBC40 VA: 0x1805ED640
	public Sku GetSkuAt(int index) { }

	[MonoPInvokeCallback]
	// RVA: 0x5ECD90 Offset: 0x5EB390 VA: 0x1805ECD90
	private static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5ECEB0 Offset: 0x5EB4B0 VA: 0x1805ECEB0
	public void FetchEntitlements(StoreManager.FetchEntitlementsHandler callback) { }

	// RVA: 0x5ECCB0 Offset: 0x5EB2B0 VA: 0x1805ECCB0
	public int CountEntitlements() { }

	// RVA: 0x5ED340 Offset: 0x5EB940 VA: 0x1805ED340
	public Entitlement GetEntitlement(long entitlementId) { }

	// RVA: 0x5ED270 Offset: 0x5EB870 VA: 0x1805ED270
	public Entitlement GetEntitlementAt(int index) { }

	// RVA: 0x5EDA70 Offset: 0x5EC070 VA: 0x1805EDA70
	public bool HasSkuEntitlement(long skuId) { }

	[MonoPInvokeCallback]
	// RVA: 0x5EDFA0 Offset: 0x5EC5A0 VA: 0x1805EDFA0
	private static void StartPurchaseCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5EE0C0 Offset: 0x5EC6C0 VA: 0x1805EE0C0
	public void StartPurchase(long skuId, StoreManager.StartPurchaseHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5EDD40 Offset: 0x5EC340 VA: 0x1805EDD40
	private static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement) { }

	[MonoPInvokeCallback]
	// RVA: 0x5EDE70 Offset: 0x5EC470 VA: 0x1805EDE70
	private static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement) { }

	// RVA: 0x5ED400 Offset: 0x5EBA00 VA: 0x1805ED400
	public IEnumerable<Entitlement> GetEntitlements() { }

	// RVA: 0x5ED7E0 Offset: 0x5EBDE0 VA: 0x1805ED7E0
	public IEnumerable<Sku> GetSkus() { }
}

// Namespace: Discord
public class VoiceManager // TypeDefIndex: 13509
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private VoiceManager.SettingsUpdateHandler OnSettingsUpdate; // 0x20

	// Properties
	private VoiceManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5EF7B0 Offset: 0x5EDDB0 VA: 0x1805EF7B0
	private VoiceManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x5EF710 Offset: 0x5EDD10 VA: 0x1805EF710
	public void add_OnSettingsUpdate(VoiceManager.SettingsUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5EF8E0 Offset: 0x5EDEE0 VA: 0x1805EF8E0
	public void remove_OnSettingsUpdate(VoiceManager.SettingsUpdateHandler value) { }

	// RVA: 0x5EF520 Offset: 0x5EDB20 VA: 0x1805EF520
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref VoiceManager.FFIEvents events) { }

	// RVA: 0x5EEB10 Offset: 0x5ED110 VA: 0x1805EEB10
	private void InitEvents(IntPtr eventsPtr, ref VoiceManager.FFIEvents events) { }

	// RVA: 0x5EE9B0 Offset: 0x5ECFB0 VA: 0x1805EE9B0
	public InputMode GetInputMode() { }

	[MonoPInvokeCallback]
	// RVA: 0x5EEFA0 Offset: 0x5ED5A0 VA: 0x1805EEFA0
	private static void SetInputModeCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5EF0C0 Offset: 0x5ED6C0 VA: 0x1805EF0C0
	public void SetInputMode(InputMode inputMode, VoiceManager.SetInputModeHandler callback) { }

	// RVA: 0x5EEDD0 Offset: 0x5ED3D0 VA: 0x1805EEDD0
	public bool IsSelfMute() { }

	// RVA: 0x5EF470 Offset: 0x5EDA70 VA: 0x1805EF470
	public void SetSelfMute(bool mute) { }

	// RVA: 0x5EED20 Offset: 0x5ED320 VA: 0x1805EED20
	public bool IsSelfDeaf() { }

	// RVA: 0x5EF3C0 Offset: 0x5ED9C0 VA: 0x1805EF3C0
	public void SetSelfDeaf(bool deaf) { }

	// RVA: 0x5EEC60 Offset: 0x5ED260 VA: 0x1805EEC60
	public bool IsLocalMute(long userId) { }

	// RVA: 0x5EF240 Offset: 0x5ED840 VA: 0x1805EF240
	public void SetLocalMute(long userId, bool mute) { }

	// RVA: 0x5EEA50 Offset: 0x5ED050 VA: 0x1805EEA50
	public byte GetLocalVolume(long userId) { }

	// RVA: 0x5EF300 Offset: 0x5ED900 VA: 0x1805EF300
	public void SetLocalVolume(long userId, byte volume) { }

	[MonoPInvokeCallback]
	// RVA: 0x5EEE80 Offset: 0x5ED480 VA: 0x1805EEE80
	private static void OnSettingsUpdateImpl(IntPtr ptr) { }
}

// Namespace: Discord
public class AchievementManager // TypeDefIndex: 13523
{
	// Fields
	private IntPtr MethodsPtr; // 0x10
	private object MethodsStructure; // 0x18
	[CompilerGenerated]
	private AchievementManager.UserAchievementUpdateHandler OnUserAchievementUpdate; // 0x20

	// Properties
	private AchievementManager.FFIMethods Methods { get; }

	// Methods

	// RVA: 0x5E6890 Offset: 0x5E4E90 VA: 0x1805E6890
	private AchievementManager.FFIMethods get_Methods() { }

	[CompilerGenerated]
	// RVA: 0x5E67F0 Offset: 0x5E4DF0 VA: 0x1805E67F0
	public void add_OnUserAchievementUpdate(AchievementManager.UserAchievementUpdateHandler value) { }

	[CompilerGenerated]
	// RVA: 0x5E69B0 Offset: 0x5E4FB0 VA: 0x1805E69B0
	public void remove_OnUserAchievementUpdate(AchievementManager.UserAchievementUpdateHandler value) { }

	// RVA: 0x5E6600 Offset: 0x5E4C00 VA: 0x1805E6600
	internal void .ctor(IntPtr ptr, IntPtr eventsPtr, ref AchievementManager.FFIEvents events) { }

	// RVA: 0x5E60F0 Offset: 0x5E46F0 VA: 0x1805E60F0
	private void InitEvents(IntPtr eventsPtr, ref AchievementManager.FFIEvents events) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E6370 Offset: 0x5E4970 VA: 0x1805E6370
	private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5E6490 Offset: 0x5E4A90 VA: 0x1805E6490
	public void SetUserAchievement(long achievementId, byte percentComplete, AchievementManager.SetUserAchievementHandler callback) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E5CD0 Offset: 0x5E42D0 VA: 0x1805E5CD0
	private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result) { }

	// RVA: 0x5E5DF0 Offset: 0x5E43F0 VA: 0x1805E5DF0
	public void FetchUserAchievements(AchievementManager.FetchUserAchievementsHandler callback) { }

	// RVA: 0x5E5C70 Offset: 0x5E4270 VA: 0x1805E5C70
	public int CountUserAchievements() { }

	// RVA: 0x5E6020 Offset: 0x5E4620 VA: 0x1805E6020
	public UserAchievement GetUserAchievement(long userAchievementId) { }

	// RVA: 0x5E5F50 Offset: 0x5E4550 VA: 0x1805E5F50
	public UserAchievement GetUserAchievementAt(int index) { }

	[MonoPInvokeCallback]
	// RVA: 0x5E6240 Offset: 0x5E4840 VA: 0x1805E6240
	private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement) { }
}

