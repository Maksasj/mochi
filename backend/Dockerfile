# build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /source
COPY ./ ./

WORKDIR /source/Mochi.Service
RUN dotnet publish -c release -o /app

EXPOSE 8080

# run
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app ./

RUN apt-get update && apt-get install -y curl

ENTRYPOINT ["dotnet", "Mochi.Service.dll"]