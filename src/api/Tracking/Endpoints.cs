using Clouseau.Api.Tracking;

using Microsoft.AspNetCore.Mvc;

namespace Api.Tracking;

/// <summary>
/// Contains methods for mapping tracking endpoints in the API.
/// </summary>
internal static class Endpoints
{
    /// <summary>
    /// Maps the tracking endpoints in the API.
    /// </summary>
    /// <param name="app">The <see cref="IEndpointRouteBuilder"/> instance.</param>
    /// <returns>The <see cref="IEndpointRouteBuilder"/> instance.</returns>
    internal static IEndpointRouteBuilder MapTrackingEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGroup("/api/v1")
            .MapPost("track", (HttpContext ctx,
                            [FromServices] ILoggerFactory loggerFactory,
                            [FromServices] ITrackingMetrics metrics) =>
            {
                using var activity = TrackingActivity.TrackingActivitySource.StartActivity("event.tracking");

                var logger = loggerFactory.CreateLogger("tracking-api");
                logger.TrackingStarted();


                var headerValue = ctx.Request.Headers["X-clouseau-header"].FirstOrDefault();
                if (string.IsNullOrEmpty(headerValue))
                {
                    metrics.Rejected();
                    logger.EventRejected();
                    return Results.BadRequest();
                }

                metrics.Accepted();
                activity?.AddTag("header-value", headerValue);
                logger.EventTracked();

                return Results.Accepted();

            })
            .Produces(StatusCodes.Status202Accepted)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithOpenApi()
            .WithName("tracker-api");

        return app;
    }
}


internal static partial class TrackingLogger
{
    [LoggerMessage(LogLevel.Information, "Event tracking started")]
    public static partial void TrackingStarted(this ILogger logger);

    [LoggerMessage(LogLevel.Information, "Event tracked successfully")]
    public static partial void EventTracked(this ILogger logger);

    [LoggerMessage(LogLevel.Warning, "Event rejected")]
    public static partial void EventRejected(this ILogger logger);
}
