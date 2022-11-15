FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SampleDDDProjectDomain/SampleDDDProjectDomain.csproj", "SampleDDDProjectDomain/"]
RUN dotnet restore "SampleDDDProjectDomain/SampleDDDProjectDomain.csproj"
COPY . .
WORKDIR "/src/SampleDDDProjectDomain"
RUN dotnet build "SampleDDDProjectDomain.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleDDDProjectDomain.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleDDDProjectDomain.dll"]
