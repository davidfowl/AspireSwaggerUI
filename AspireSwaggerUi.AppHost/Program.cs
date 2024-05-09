var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AspireSwaggerUi_ApiService>("api").WithSwaggerUI();

builder.Build().Run();
