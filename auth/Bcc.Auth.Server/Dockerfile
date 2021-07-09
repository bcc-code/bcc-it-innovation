#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Bcc.Auth.Server/Bcc.Auth.Server.csproj", "Bcc.Auth.Server/"]
RUN dotnet restore "Bcc.Auth.Server/Bcc.Auth.Server.csproj"
COPY . .
WORKDIR "/src/Bcc.Auth.Server"
RUN dotnet build "Bcc.Auth.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bcc.Auth.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bcc.Auth.Server.dll"]