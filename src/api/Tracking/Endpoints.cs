using Clouseau.Api.Tracking;

namespace Api.Tracking;

/// <summary>
/// Contains methods for mapping tracking endpoints in the API.
/// </summary>
internal static partial class Endpoints
{
    internal static IEndpointRouteBuilder MapTrackingEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGroup("/api/v1")
            .MapPost("track", V1.TrackEvent)
            .Produces(StatusCodes.Status202Accepted)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithOpenApi()
            .WithName("tracker-api");

        return app;
    }

    private static partial class V1
    {
        private const string LoggerCategory = "tracking-api.v1";
        private const string HeaderName = "X-clouseau-header";
        internal static IResult TrackEvent(HttpContext ctx, ILoggerFactory loggerFactory, ITrackingMetrics metrics)
        {
            using var activity = TrackingActivity.TrackingActivitySource.StartActivity("event.tracking");

            var logger = loggerFactory.CreateLogger(LoggerCategory);
            Log.TrackingStarted(logger);

            var headerValue = ctx.Request.Headers[HeaderName].FirstOrDefault();
            if (string.IsNullOrEmpty(headerValue))
            {
                metrics.Rejected();
                Log.EventRejected(logger);
                return Results.BadRequest();
            }

            metrics.Accepted();
            activity?.AddTag("header-value", headerValue);
            Log.EventTracked(logger);

            return Results.Accepted();
        }

        private static partial class Log
        {
            [LoggerMessage(LogLevel.Information, "Event tracking started")]
            public static partial void TrackingStarted(ILogger logger);

            [LoggerMessage(LogLevel.Information, "Event tracked successfully")]
            public static partial void EventTracked(ILogger logger);

            [LoggerMessage(LogLevel.Warning, "Event rejected")]
            public static partial void EventRejected(ILogger logger);
        }
    }

}

