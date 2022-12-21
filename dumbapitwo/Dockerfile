FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
WORKDIR /src
COPY . .
RUN dotnet restore "./dumbapitwo/dumbapitwo.csproj" --disable-parallel
RUN dotnet publish "./dumbapitwo/dumbapitwo.csproj" -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "dumbapitwo.dll"]
