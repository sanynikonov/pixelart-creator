#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["PixelartCreator.Presentation/PixelartCreator.Presentation.csproj", "PixelartCreator.Presentation/"]
COPY ["PixelartCreator.Infrastructure/PixelartCreator.Infrastructure.csproj", "PixelartCreator.Infrastructure/"]
COPY ["PixelartCreator.Domain/PixelartCreator.Domain.csproj", "PixelartCreator.Domain/"]
COPY ["PixelartCreator.Business/PixelartCreator.Business.csproj", "PixelartCreator.Business/"]
RUN dotnet restore "PixelartCreator.Presentation/PixelartCreator.Presentation.csproj"
COPY . .
WORKDIR "/src/PixelartCreator.Presentation"
RUN dotnet build "PixelartCreator.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PixelartCreator.Presentation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PixelartCreator.Presentation.dll"]