FROM microsoft/dotnet:2.1-aspnetcore-runtime

COPY publish /app/publish
WORKDIR /app

EXPOSE 80

ENTRYPOINT ["dotnet", "publish/BasicHotelApi.dll"]
