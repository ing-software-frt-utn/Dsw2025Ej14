using Dsw2025Ej14.Api.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<PersistenciaEnMemoria>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.MapGet("/health-check", () => Results.Ok("API funcionando"));

app.Run();