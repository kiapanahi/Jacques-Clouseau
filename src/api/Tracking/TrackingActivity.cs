using System.Diagnostics;

namespace Clouseau.Api.Tracking;

public static class TrackingActivity
{
    public const string TrackingActivitySourceName = "clouseau.tracking.activity";
    public static readonly string TrackingActivityVersion = ServiceDefaults.Diagnostics.SystemVersion;

    public static readonly ActivitySource TrackingActivitySource = new(TrackingActivitySourceName, TrackingActivityVersion);
}
