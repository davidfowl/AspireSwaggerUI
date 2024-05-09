var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseSwagger();

app.MapGet("/", () => "Hello World!");
app.MapGet("/foo", () => "foo");
app.MapGet("/bar", () => "bar");

app.Run();
