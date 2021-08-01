FROM mcr.microsoft.com/dotnet/sdk:5.0

WORKDIR /app

COPY *.csproj ./

RUN dotnet restore

EXPOSE 8001

COPY . ./

RUN dotnet publish -c Release -o out

ENTRYPOINT [ "dotnet", "watch", "run", "--no-restore", "--urls", "https://0.0.0.0:5001"]