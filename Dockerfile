FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Dotnet8TodoAppBoilerplate.csproj", "./"]
RUN dotnet restore "Dotnet8TodoAppBoilerplate.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "Dotnet8TodoAppBoilerplate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dotnet8TodoAppBoilerplate.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dotnet8TodoAppBoilerplate.dll"]
