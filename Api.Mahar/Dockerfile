FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY Api.Mahar/Api.Mahar.csproj Api.Mahar/
RUN dotnet restore Api.Mahar/Api.Mahar.csproj
COPY . .
WORKDIR /src/Api.Mahar
RUN dotnet build Api.Mahar.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Api.Mahar.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Api.Mahar.dll"]
