using System.Diagnostics.Metrics;

namespace Clouseau.Api.Tracking;

internal sealed class TrackingMetrics
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
