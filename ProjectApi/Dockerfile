# استخدام .NET 9.0 SDK كـ base image
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /app

# نسخ كل الملفات للمسار داخل الـ container
COPY . .

# استعادة الـ dependencies
RUN dotnet restore

# بناء الـ Application
RUN dotnet publish -c Release -o out

# استخدام .NET Runtime لتشغيل الـ Application
FROM mcr.microsoft.com/dotnet/aspnet:9.0

WORKDIR /app
COPY --from=build /app/out .

EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "ProjectApi.Client.dll"]
