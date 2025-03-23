# استخدمي صورة الدوت نت 9.0 من مايكروسوفت
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# نسخ ملفات المشروع واستعادة الـ dependencies
COPY . ./
RUN dotnet restore

# بناء التطبيق
RUN dotnet publish -c Release -o /out

# إنشاء صورة الـ runtime باستخدام .NET 9.0
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /out .

# تعيين البورت الذي سيعمل عليه التطبيق
EXPOSE 80

# الأمر الذي سيُنفّذ عند تشغيل الحاوية
ENTRYPOINT ["dotnet", "ProjectApi.Client.dll"]
