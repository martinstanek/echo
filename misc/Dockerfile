FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine
EXPOSE 5027
ENV ASPNETCORE_URLS=http://*:5027

WORKDIR /app
COPY . .

ENTRYPOINT ["dotnet", "Echo.Host.dll"]