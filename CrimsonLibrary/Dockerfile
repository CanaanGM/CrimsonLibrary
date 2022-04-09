# #See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
# WORKDIR /app
# EXPOSE 80
# EXPOSE 443

# FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
# WORKDIR /src
# COPY ["CrimsonLibrary/CrimsonLibrary.csproj", "CrimsonLibrary/"]
# RUN dotnet restore "CrimsonLibrary/CrimsonLibrary.csproj"
# COPY . .
# WORKDIR "/src/CrimsonLibrary"
# RUN dotnet user-secrets init
# RUN dotnet user-secrets set "SQLSERVER:User" "sa"
# RUN dotnet user-secrets set "SQLSERVER:Pass" "DiLb984ImW"
# RUN dotnet user-secrets set "jwtKey" "DiLb984ImW"
# RUN dotnet user-secrets set "Kestrel:Certificates:Development:Password" "Crimz0n!"
# RUN dotnet build "CrimsonLibrary.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "CrimsonLibrary.csproj" -c Release -o /app/publish

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .


# ENTRYPOINT ["dotnet", "CrimsonLibrary.dll"]


# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./

RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "CrimsonLibrary.dll"]
