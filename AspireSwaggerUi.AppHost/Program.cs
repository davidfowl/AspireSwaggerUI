var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AspireSwaggerUi_ApiService>("api").WithSwaggerUi();

builder.Build().Run();
