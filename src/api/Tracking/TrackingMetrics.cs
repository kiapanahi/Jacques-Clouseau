using System.Diagnostics.Metrics;

namespace Clouseau.Api.Tracking;

/// <summary>
/// Represents the tracking metrics for the Clouseau API.
/// </summary>
internal interface ITrackingMetrics
{
    void Rejected();
    void Accepted();
}

/// <summary>
/// Represents default implementation of the <see cref="ITrackingMetrics"/> interface.
/// </summary>
internal sealed class TrackingMetrics : ITrackingMetrics
{
    public const string TrackingMeterName = @"clouseau.tracking.meter";
    public static readonly string TrackingMeterVersion = ServiceDefaults.Diagnostics.SystemVersion;

    private readonly Meter _meter;
    private readonly Histogram<long> _rejectedHistogram;
    private readonly Histogram<long> _acceptedHistogram;

    public TrackingMetrics(IMeterFactory meterFactory)
    {
        _meter = meterFactory.Create(new MeterOptions(TrackingMeterName)
        {
            Version = TrackingMeterVersion,
        });

        _rejectedHistogram = _meter.CreateHistogram<long>("events.rejected", "event", "Rejected events due to invalid schema");
        _acceptedHistogram = _meter.CreateHistogram<long>("events.accepted", "event", "Accepted events");
    }

    public void Rejected()
    {
        _rejectedHistogram.Record(1);
    }

    public void Accepted()
    {
        _acceptedHistogram.Record(1);
    }
}
