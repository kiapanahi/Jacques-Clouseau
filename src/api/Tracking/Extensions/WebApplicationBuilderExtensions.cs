namespace Clouseau.Api.Tracking.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder AddTrackingServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder, nameof(builder));

        builder.Services
            .AddTrackingServices();


        return builder;
    }
}
