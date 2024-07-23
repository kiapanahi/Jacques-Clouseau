var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Clouseau_Api>("api");

builder.Build().Run();
