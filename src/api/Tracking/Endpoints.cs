using Clouseau.Api.Tracking;
using Clouseau.Infrastructure.Kafka.KafkaFlow.Producers;

using Microsoft.AspNetCore.Mvc;

namespace Api.Tracking;

internal static class Endpoints
{
    internal static IEndpointRouteBuilder MapTrackingEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGroup("/api/v1")
            .MapPost("track", async (HttpContext ctx,
                    [FromServices] ICbtEventProducer producer,
                    [FromServices] ILoggerFactory loggerFactory,
                    [FromServices] TrackingMetrics metrics) =>
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

                await producer.PublishEvent();
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

internal static partial class Log
{
    [LoggerMessage(LogLevel.Information, "Event tracking started")]
    public static partial void TrackingStarted(this ILogger logger);

    [LoggerMessage(LogLevel.Information, "Event tracked successfully")]
    public static partial void EventTracked(this ILogger logger);

    [LoggerMessage(LogLevel.Warning, "Event rejected")]
    public static partial void EventRejected(this ILogger logger);
}
