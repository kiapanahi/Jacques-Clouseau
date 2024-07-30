using System.Diagnostics;

namespace Clouseau.Api.Tracking;

/// <summary>
/// Represents the tracking activity in the Clouseau API.
/// </summary>
internal static class TrackingActivity
{
    /// <summary>
    /// The name of the tracking activity source.
    /// </summary>
    internal const string TrackingActivitySourceName = "clouseau.tracking.activity";

    /// <summary>
    /// The version of the tracking activity.
    /// </summary>
    internal static readonly string TrackingActivityVersion = ServiceDefaults.Diagnostics.SystemVersion;

    /// <summary>
    /// The activity source for the tracking activity.
    /// </summary>
    internal static readonly ActivitySource TrackingActivitySource = new(TrackingActivitySourceName, TrackingActivityVersion);
}
