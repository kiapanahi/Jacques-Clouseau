namespace Clouseau.Api.Tracking.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddTrackingServices(this IServiceCollection services)
    {
        services.AddSingleton<ITrackingMetrics, TrackingMetrics>();

        services.AddOpenTelemetry()
            .WithMetrics(meterProviderBuilder =>
                            meterProviderBuilder.AddMeter(TrackingMetrics.TrackingMeterName)
            )
            .WithTracing(traceProviderBuilder =>
                            traceProviderBuilder.AddSource(TrackingActivity.TrackingActivitySourceName)
            );

        return services;
    }
}
