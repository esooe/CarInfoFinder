FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CarInfoFinder.Api/CarInfoFinder.Api.csproj", "CarInfoFinder.Api/"]
COPY ["CarInfoFinder.Application/CarInfoFinder.Application.csproj", "CarInfoFinder.Application/"]
COPY ["CarInfoFinder.Domain/CarInfoFinder.Domain.csproj", "CarInfoFinder.Domain/"]
COPY ["CarInfoFinder.Infrastructure/CarInfoFinder.Infrastructure.csproj", "CarInfoFinder.Infrastructure/"]
RUN dotnet restore "./CarInfoFinder.Api/CarInfoFinder.Api.csproj"
COPY . .
WORKDIR "/src/CarInfoFinder.Api"
RUN dotnet build "./CarInfoFinder.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CarInfoFinder.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarInfoFinder.Api.dll"]
