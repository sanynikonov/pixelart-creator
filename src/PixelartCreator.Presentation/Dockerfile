#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
RUN apt-get update && apt-get install -y libgdiplus
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/PixelartCreator.Presentation/PixelartCreator.Presentation.csproj", "src/PixelartCreator.Presentation/"]
COPY ["src/PixelartCreator.Infrastructure/PixelartCreator.Infrastructure.csproj", "src/PixelartCreator.Infrastructure/"]
COPY ["src/PixelartCreator.Domain/PixelartCreator.Domain.csproj", "src/PixelartCreator.Domain/"]
COPY ["src/PixelartCreator.Business/PixelartCreator.Business.csproj", "src/PixelartCreator.Business/"]
RUN dotnet restore "src/PixelartCreator.Presentation/PixelartCreator.Presentation.csproj"
COPY . .
WORKDIR "/src/src/PixelartCreator.Presentation"
RUN dotnet build "PixelartCreator.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PixelartCreator.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PixelartCreator.Presentation.dll"]