using System;
using Echo.Host.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Echo.Host.Handlers;

namespace Echo.Host.Extensions;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHandlers(this IServiceCollection services)
    {
        var echoTitle = Environment.GetEnvironmentVariable("ECHO_TITLE") ?? "Echo Server";
        var echoMessage = Environment.GetEnvironmentVariable("ECHO_MESSAGE") ?? DateTime.Now.ToString("s");
        var config = new EchoConfiguration
        {
            Title = echoTitle,
            Message = echoMessage
        };

        return services
            .AddSingleton(config)
            .AddSingleton<EchoHandler>();
    }
}