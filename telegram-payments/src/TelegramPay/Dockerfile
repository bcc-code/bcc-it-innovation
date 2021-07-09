FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers

COPY ["/telegram-payments/src/TelegramPay/*.csproj", "./telegram-payments/src/TelegramPay/"]

RUN dotnet restore 'telegram-payments/src/TelegramPay/TelegramPay.csproj'

COPY ["/telegram-payments/src/TelegramPay/", "./telegram-payments/src/TelegramPay/"]
RUN dotnet publish 'telegram-payments/src/TelegramPay/TelegramPay.csproj' -c Release -o out

# build runtime image
FROM mcr.microsoft.com/dotnet/runtime:5.0
WORKDIR /app
COPY --from=build-env /app/out ./
ENTRYPOINT ["dotnet", "TelegramPay.Bot.dll"]
