var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapHealthChecks("/healthz");

app.MapGet("/", () =>
{
    var name = Environment.GetEnvironmentVariable("CUTIE_NAME") ?? "AYAYA";

    return $"Cute Chatter: {name}\n";
});

app.Run();