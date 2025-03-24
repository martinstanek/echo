using System;
using Echo.Host.Configuration;
using Microsoft.AspNetCore.Http;

namespace Echo.Host.Handlers;

internal sealed class EchoHandler
{
    private readonly EchoConfiguration _configuration;

    public EchoHandler(EchoConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IResult GetIndex()
    {
        var index = """
                    <!DOCTYPE html>
                    <html lang="en">
                    <head>
                        <title>EchoTitle</title>
                        <meta charset="UTF-8">
                        <meta name="viewport" content="width=device-width, initial-scale=1.0">
                        <meta name="color-scheme" content="light dark"/>
                        <style>
                            h2 {text-align: center;}
                            p {text-align: center;}
                            div {text-align: center;}
                            body {font-family: "Noto Sans", sans-serif;}
                        </style>
                    </head>
                    <body>
                        <section id="Echo">
                            <h2>EchoTitle</h2>
                            <div>
                                <p>EchoMessage</p>
                            </div>
                        </section>
                    </body>
                    </html>
                    """;

        if (!string.IsNullOrWhiteSpace(_configuration.Title))
        {
            index = index.Replace("EchoTitle", _configuration.Title);
        }

        if (!string.IsNullOrWhiteSpace(_configuration.Message))
        {
            index = index.Replace("EchoMessage", _configuration.Message);
        }

        return Results.Content(index, "text/html");
    }

    public IResult GetEcho(string message)
    {
        var response = string.IsNullOrWhiteSpace(message)
            ? DateTime.Now.ToString("s")
            : message;

        return Results.Text(response, "text/plain");
    }
}