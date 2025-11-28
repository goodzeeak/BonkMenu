// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
public interface ILease // TypeDefIndex: 863
{
	// Properties
	public abstract TimeSpan CurrentLeaseTime { get; }
	public abstract LeaseState CurrentState { get; }
	public abstract TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan get_CurrentLeaseTime();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract LeaseState get_CurrentState();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TimeSpan get_RenewOnCallTime();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TimeSpan Renew(TimeSpan renewalTime);
}

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
public interface ISponsor // TypeDefIndex: 864
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan Renewal(ILease lease);
}

// Namespace: System.Runtime.Remoting.Lifetime
internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 866
{
	// Fields
	private DateTime _leaseExpireTime; // 0x18
	private LeaseState _currentState; // 0x20
	private TimeSpan _initialLeaseTime; // 0x28
	private TimeSpan _renewOnCallTime; // 0x30
	private TimeSpan _sponsorshipTimeout; // 0x38
	private ArrayList _sponsors; // 0x40
	private Queue _renewingSponsors; // 0x48
	private Lease.RenewalDelegate _renewalDelegate; // 0x50

	// Properties
	public TimeSpan CurrentLeaseTime { get; }
	public LeaseState CurrentState { get; }
	public TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: 0x13C51B0 Offset: 0x13C37B0 VA: 0x1813C51B0
	public void .ctor() { }

	// RVA: 0x13C5320 Offset: 0x13C3920 VA: 0x1813C5320 Slot: 6
	public TimeSpan get_CurrentLeaseTime() { }

	// RVA: 0x543200 Offset: 0x541800 VA: 0x180543200 Slot: 7
	public LeaseState get_CurrentState() { }

	// RVA: 0x13C4470 Offset: 0x13C2A70 VA: 0x1813C4470
	public void Activate() { }

	// RVA: 0x396DA0 Offset: 0x3953A0 VA: 0x180396DA0 Slot: 8
	public TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x13C4DE0 Offset: 0x13C33E0 VA: 0x1813C4DE0 Slot: 9
	public TimeSpan Renew(TimeSpan renewalTime) { }

	// RVA: 0x13C4EB0 Offset: 0x13C34B0 VA: 0x1813C4EB0 Slot: 10
	public void Unregister(ISponsor obj) { }

	// RVA: 0x13C5000 Offset: 0x13C3600 VA: 0x1813C5000
	internal void UpdateState() { }

	// RVA: 0x13C4480 Offset: 0x13C2A80 VA: 0x1813C4480
	private void CheckNextSponsor() { }

	// RVA: 0x13C4830 Offset: 0x13C2E30 VA: 0x1813C4830
	private void ProcessSponsorResponse(object state, bool timedOut) { }
}

// Namespace: System.Runtime.Remoting.Lifetime
internal class LeaseManager // TypeDefIndex: 867
{
	// Fields
	private ArrayList _objects; // 0x10
	private Timer _timer; // 0x18

	// Methods

	// RVA: 0x13C3C30 Offset: 0x13C2230 VA: 0x1813C3C30
	public void SetPollTime(TimeSpan timeSpan) { }

	// RVA: 0x13C3EC0 Offset: 0x13C24C0 VA: 0x1813C3EC0
	public void TrackLifetime(ServerIdentity identity) { }

	// RVA: 0x13C3D00 Offset: 0x13C2300 VA: 0x1813C3D00
	public void StartManager() { }

	// RVA: 0x13C3E80 Offset: 0x13C2480 VA: 0x1813C3E80
	public void StopManager() { }

	// RVA: 0x13C39D0 Offset: 0x13C1FD0 VA: 0x1813C39D0
	public void ManageLeases(object state) { }

	// RVA: 0x13C4140 Offset: 0x13C2740 VA: 0x1813C4140
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Lifetime
internal class LeaseSink : IMessageSink // TypeDefIndex: 868
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x39A8C0 Offset: 0x398EC0 VA: 0x18039A8C0
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x13C4400 Offset: 0x13C2A00 VA: 0x1813C4400 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x13C41B0 Offset: 0x13C27B0 VA: 0x1813C41B0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x13C4230 Offset: 0x13C2830 VA: 0x1813C4230
	private void RenewLease(IMessage msg) { }
}

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
[Serializable]
public enum LeaseState // TypeDefIndex: 869
{
	// Fields
	public int value__; // 0x0
	public const LeaseState Null = 0;
	public const LeaseState Initial = 1;
	public const LeaseState Active = 2;
	public const LeaseState Renewing = 3;
	public const LeaseState Expired = 4;
}

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
public sealed class LifetimeServices // TypeDefIndex: 870
{
	// Fields
	private static TimeSpan _leaseManagerPollTime; // 0x0
	private static TimeSpan _leaseTime; // 0x8
	private static TimeSpan _renewOnCallTime; // 0x10
	private static TimeSpan _sponsorshipTimeout; // 0x18
	private static LeaseManager _leaseManager; // 0x20

	// Properties
	public static TimeSpan LeaseManagerPollTime { get; set; }
	public static TimeSpan LeaseTime { get; set; }
	public static TimeSpan RenewOnCallTime { get; set; }
	public static TimeSpan SponsorshipTimeout { get; set; }

	// Methods

	// RVA: 0x13C53F0 Offset: 0x13C39F0 VA: 0x1813C53F0
	private static void .cctor() { }

	// RVA: 0x13C5560 Offset: 0x13C3B60 VA: 0x1813C5560
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x13C56A0 Offset: 0x13C3CA0 VA: 0x1813C56A0
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x13C55B0 Offset: 0x13C3BB0 VA: 0x1813C55B0
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x13C5720 Offset: 0x13C3D20 VA: 0x1813C5720
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x13C5600 Offset: 0x13C3C00 VA: 0x1813C5600
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x13C5780 Offset: 0x13C3D80 VA: 0x1813C5780
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x13C5650 Offset: 0x13C3C50 VA: 0x1813C5650
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x13C57E0 Offset: 0x13C3DE0 VA: 0x1813C57E0
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x13C5380 Offset: 0x13C3980 VA: 0x1813C5380
	internal static void TrackLifetime(ServerIdentity identity) { }
}

