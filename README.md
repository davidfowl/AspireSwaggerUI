## SwaggerUi.Aspire.Hosting

This repository shows a sample of how use aspire to show a swagger ui for any resource that exposes an open api endpoint.

Just add `WithSwaggerUi()` to any project resource builder and you are good to go!

```C#
var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.AspireSwaggerUi_ApiService>("api").WithSwaggerUi();

builder.Build().Run();
```

