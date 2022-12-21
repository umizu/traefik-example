FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
WORKDIR /src
COPY . .
RUN dotnet restore "./dumbapi/dumbapi.csproj" --disable-parallel
RUN dotnet publish "./dumbapi/dumbapi.csproj" -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "dumbapi.dll"]
