FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine
EXPOSE 5023
ENV ASPNETCORE_URLS=http://*:5023

WORKDIR /app
COPY . .

ENTRYPOINT ["dotnet", "Echo.Host.dll"]