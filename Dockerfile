# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy only what we need (relative to compose build context = project root)
COPY ../FitnessTracker/ ./FitnessTracker/

WORKDIR /src/FitnessTracker

# Restore and publish
RUN dotnet restore
RUN dotnet publish -c Release -o /app

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app ./

# Listen on 5000 inside the container
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

ENTRYPOINT ["dotnet", "FitnessTracker.dll"]
