# Using the offical ASP .NET Core runtime as the parent image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /api
EXPOSE 80

# Using the official ASP .NET Core SDK image to build the api
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["thecoolingeffect_api/thecoolingeffect_api.csproj", "thecoolingeffect_api/"]
RUN dotnet restore "thecoolingeffect_api/thecoolingeffect_api.csproj"
COPY . .
WORKDIR "/src/thecoolingeffect_api"
RUN dotnet build "thecoolingeffect_api.csproj" -c Release -o /api/build

# Publish the api
FROM build AS publish
RUN dotnet publish "thecoolingeffect_api.csproj" -c Release -o /api/publish

# Copy the build output to the runtime image
FROM base AS final
WORKDIR /api
COPY --from=publish /api/publish .
ENTRYPOINT ["dotnet", "thecoolingeffect_api.dll"]