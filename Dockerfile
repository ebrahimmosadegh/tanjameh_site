FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
# کپی کردن فایل‌های csproj و restore کردن وابستگی‌ها
COPY ["Tanjameh/Tanjameh.csproj", "Tanjameh/"]
COPY ["Tanjameh.Core/Tanjameh.Core.csproj", "Tanjameh.Core/"]
COPY ["Tanjameh.Infrastructure/Tanjameh.Infrastructure.csproj", "Tanjameh.Infrastructure/"]
COPY ["Tanjameh.sln", "./"]
RUN dotnet restore "Tanjameh.sln"

# کپی کردن بقیه فایل‌های سورس
COPY . .

# Build کردن پروژه
WORKDIR "/src/Tanjameh"
RUN dotnet build "Tanjameh.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tanjameh.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tanjameh.dll"]