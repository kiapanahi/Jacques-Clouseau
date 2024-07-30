using System.Diagnostics;

namespace Clouseau.Api.Tracking;

internal static class TrackingActivity
{
    internal const string TrackingActivitySourceName = "clouseau.tracking.activity";

    internal static readonly string TrackingActivityVersion = ServiceDefaults.Diagnostics.SystemVersion;

    internal static readonly ActivitySource TrackingActivitySource = new(TrackingActivitySourceName, TrackingActivityVersion);
}
