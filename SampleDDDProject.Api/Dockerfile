FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SampleDDDProject.Api/SampleDDDProject.Api.csproj", "SampleDDDProject.Api/"]
RUN dotnet restore "SampleDDDProject.Api/SampleDDDProject.Api.csproj"
COPY . .
WORKDIR "/src/SampleDDDProject.Api"
RUN dotnet build "SampleDDDProject.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleDDDProject.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleDDDProject.Api.dll"]
