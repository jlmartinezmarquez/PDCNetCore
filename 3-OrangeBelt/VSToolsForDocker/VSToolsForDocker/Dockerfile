FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 1418
#EXPOSE 44333

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY VSToolsForDocker/VSToolsForDocker.csproj VSToolsForDocker/
RUN dotnet restore VSToolsForDocker/VSToolsForDocker.csproj
COPY . .
WORKDIR /src/VSToolsForDocker
RUN dotnet build VSToolsForDocker.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish VSToolsForDocker.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VSToolsForDocker.dll"]
