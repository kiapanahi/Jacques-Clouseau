using Microsoft.AspNetCore.Mvc;

namespace Api.Tracking;

internal static class Endpoints
{
    internal static IEndpointRouteBuilder MapTrackingEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGroup("/api/v1")
            .MapPost("track", (HttpContext ctx, [FromServices] ILoggerFactory loggerFactory) =>
            {
                var logger = loggerFactory.CreateLogger("track-api");
                logger.LogInformation("tracking...");


                var headerValue = ctx.Request.Headers["X-albb-hc-event-type"].FirstOrDefault();
                if (string.IsNullOrEmpty(headerValue))
                {
                    return Results.BadRequest();
                }
                return Results.Accepted();
            })
            .Produces(StatusCodes.Status202Accepted)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithOpenApi()
            .WithName("tracker-api");
        return app;
    }
}
