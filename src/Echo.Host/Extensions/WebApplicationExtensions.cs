using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Echo.Host.Handlers;

namespace Echo.Host.Extensions;

internal static class WebApplicationExtensions
{
    public static WebApplication UseCustomEndpoints(this WebApplication webApplication)
    {
        var api = webApplication.MapGroup("/");

        api.MapGet("/", ([FromServices] EchoHandler handler) => handler.GetIndex());
        api.MapGet("echo", ([FromServices] EchoHandler handler) => handler.GetEcho(string.Empty));
        api.MapGet("echo/{message}", ([FromRoute] string message, [FromServices] EchoHandler handler) => handler.GetEcho(message));

        return webApplication;
    }

    public static WebApplication UseHttpsRedirect(this WebApplication webApplication)
    {
        var variable = Environment.GetEnvironmentVariable("ECHO_HTTPSREDIRECT");

        if (bool.TryParse(variable, out var useRedirect) && useRedirect)
        {
            webApplication.UseHttpsRedirection();
        }

        return webApplication;
    }
}