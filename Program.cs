var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapHealthChecks("/healthz");

app.MapGet("/", () =>
{
    var name = Environment.GetEnvironmentVariable("CUTIE_NAME") ?? "AYAYA";

    return $"Cute 123 Chat: {name}\n";
});

app.Run();
