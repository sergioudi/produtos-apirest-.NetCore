FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy csproj e restaurar as camadas
COPY . ./
RUN dotnet restore

RUN dotnet publish -c Release -o out

# Build com a imagem do runtime
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .

# Usa porta dinâmica do Heroku
CMD ASPNETCORE_URLS="http://*:$PORT" dotnet apirest.WebApi.dll 
