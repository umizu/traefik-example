using Serilog;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapGet("/", () => "Hello World! from dummy api #2");
app.Map("/hey", () => "Hey there! from dummy api #2");
app.MapHealthChecks("/health");

app.Run();
