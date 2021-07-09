FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Sknerus.Reporting/Sknerus.Reporting.csproj", "Sknerus.Reporting/"]
RUN dotnet restore "src/Sknerus.Reporting/Sknerus.Reporting.csproj"
COPY . .
WORKDIR "/src/Sknerus.Reporting"
RUN dotnet build "Sknerus.Reporting.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sknerus.Reporting.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sknerus.Reporting.dll"]
