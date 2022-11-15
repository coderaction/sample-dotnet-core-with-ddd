FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SampleDDDProject.Application/SampleDDDProject.Application.csproj", "SampleDDDProject.Application/"]
RUN dotnet restore "SampleDDDProject.Application/SampleDDDProject.Application.csproj"
COPY . .
WORKDIR "/src/SampleDDDProject.Application"
RUN dotnet build "SampleDDDProject.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleDDDProject.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleDDDProject.Application.dll"]
