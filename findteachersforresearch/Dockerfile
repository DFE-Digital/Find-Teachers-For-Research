# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine3.20 AS build

# Set the working directory inside the container
#WORKDIR /src
COPY findteachersforresearch /src
WORKDIR /src

# Copy the project file and restore dependencies
# COPY ["../findteachersforresearch/findteachersforresearch.csproj", "./"]
RUN dotnet restore

# Copy the rest of the source code and publish the application
# COPY . .
RUN dotnet publish "findteachersforresearch.csproj" -c Release -o /app/publish

# Stage 2: Create the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine3.20 AS runtime

# Set environment variable for HTTPS
# ENV ASPNETCORE_URLS="https://+:7238"
ENV ASPNETCORE_URLS="http://+:3000"

# Set working directory
WORKDIR /app

# Copy the published app from the build stage
COPY --from=build /app/publish .

# Install required dependencies for globalization support
RUN apk add --no-cache tzdata icu
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

# Install Postgres client
RUN apk --no-cache add postgresql16-client

# Copy the HTTPS certificate
# COPY aspnetapp.pfx /app/aspnetapp.pfx

# Expose the HTTPS port
# EXPOSE 7238
EXPOSE 3000

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "findteachersforresearch.dll"]
