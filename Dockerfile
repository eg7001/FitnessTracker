# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy solution & project files
COPY FitnessTracker.sln .
COPY FitnessTracker/ ./FitnessTracker/

# Restore dependencies
RUN dotnet restore

# Copy the rest of the code
COPY . .

# Build & publish
WORKDIR /src/FitnessTracker
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Copy the published output
COPY --from=build /app/publish .

# Expose port
EXPOSE 5000
# Force ASP.NET Core to listen on all interfaces
ENV ASPNETCORE_URLS=http://0.0.0.0:5000
# Run the app
ENTRYPOINT ["dotnet", "FitnessTracker.dll"]
