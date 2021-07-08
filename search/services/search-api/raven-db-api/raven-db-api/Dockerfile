FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["raven-db-api/raven-db-api.csproj", "raven-db-api/"]
RUN dotnet restore "raven-db-api/raven-db-api.csproj"
COPY . .
WORKDIR "/src/raven-db-api"
RUN dotnet build "raven-db-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "raven-db-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "raven-db-api.dll"]
