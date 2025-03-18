# Stage 1: Base image for running the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Stage 2: Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy the project file and restore any dependencies (via dotnet restore)
COPY *.csproj ./
RUN dotnet restore

# Stage 3: Publish the application
FROM build AS publish
RUN dotnet publish -c Release -o out

# Stage 4: Final stage for running the application in production
FROM base AS final
WORKDIR /app

# Copy the published output from the build container to the final container
COPY --from=publish /app/publish .

# Set the entry point for the ASP.NET Core application
ENTRYPOINT ["dotnet", "PAYMENT.dll"]
