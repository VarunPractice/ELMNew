# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy .csproj files from ALL projects
COPY ["ELM.APIs.LicenseService/ELM.APIs.LicenseService.csproj", "ELM.APIs.LicenseService/"]
COPY ["ELM.Common/ELM.Common.csproj", "ELM.Common/"] 

# Restore dependencies for the LicenseService project
RUN dotnet restore "ELM.APIs.LicenseService/ELM.APIs.LicenseService.csproj"

# Copy the entire solution
COPY . .

# Build
WORKDIR "/src/ELM.APIs.LicenseService"
RUN dotnet build -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

# Final stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ELM.APIs.LicenseService.dll"]