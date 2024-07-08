

using Api.Tracking;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app
    .MapDefaultEndpoints()
    .MapTrackingEndpoints();

app.MapGet("/", () => "Hello World!");

app.Run();
