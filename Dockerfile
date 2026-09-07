# Aşama 1: Fabrika (SDK - Derleme Alanı)
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app
COPY . .
RUN dotnet publish -c Release -o /out

# Aşama 2: Nakliye Aracı (Runtime - Çalıştırma Alanı)
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /out .
ENTRYPOINT ["dotnet", "BenimProjem.dll"]