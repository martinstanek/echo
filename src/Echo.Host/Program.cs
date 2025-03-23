using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddCors();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseCors(p => { p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); });
app.Run();

public partial class Program;