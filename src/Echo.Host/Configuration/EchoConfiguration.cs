namespace Echo.Host.Configuration;

internal sealed record EchoConfiguration
{
    public required string Title { get; init; }

    public required string Message { get; init; }
}