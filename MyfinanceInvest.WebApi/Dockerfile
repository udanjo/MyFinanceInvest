# start
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80


# Copy project
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MyfinanceInvest.WebApi/MyfinanceInvest.WebApi.csproj", "MyfinanceInvest.WebApi/"]
COPY ["MyFinanceInvest.CrossCutting/MyFinanceInvest.IoC.csproj", "MyFinanceInvest.CrossCutting/"]
COPY ["MyFinanceInvest.Service/MyFinanceInvest.Service.csproj", "MyFinanceInvest.Service/"]
COPY ["MyFinanceInvest.Domain/MyFinanceInvest.Domain.csproj", "MyFinanceInvest.Domain/"]
COPY ["MyFinanceInvest.Repository/MyFinanceInvest.Repository.csproj", "MyFinanceInvest.Repository/"]
COPY ["MyFinanceInvest.Data.Context/MyFinanceInvest.Data.Context.csproj", "MyFinanceInvest.Data.Context/"]
RUN dotnet restore "MyfinanceInvest.WebApi/MyfinanceInvest.WebApi.csproj"
COPY . .
# build
WORKDIR "/src/MyfinanceInvest.WebApi"
RUN dotnet build "MyfinanceInvest.WebApi.csproj" -c Release -o /app/build

# publish
FROM build AS publish
RUN dotnet publish "MyfinanceInvest.WebApi.csproj" -c Release -o /app/publish

# final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyfinanceInvest.WebApi.dll"]