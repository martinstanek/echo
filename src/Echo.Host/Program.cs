using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Echo.Host.Extensions;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddCors();
builder.Services.AddHandlers();

var app = builder.Build();

app.UseCustomEndpoints();
app.UseCors(p => { p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); });
app.Run();

public partial class Program;