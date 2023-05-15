# Set the base image to the official .NET SDK image.
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

# Set the working directory.
WORKDIR /app

# Copy the project files to the working directory.
COPY . .

# Install the required packages.
RUN dotnet add package Microsoft.AspNetCore.Components.WebAssembly
RUN dotnet add package Microsoft.Extensions.Configuration
RUN dotnet add package Microsoft.Extensions.DependencyInjection
RUN dotnet add package Microsoft.Extensions.Hosting

# Build the application.
RUN dotnet build

# Run the application.
CMD ["dotnet", "run"]