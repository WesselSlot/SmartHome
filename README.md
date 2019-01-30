# SmartHome

# Setup SQL Server with docker
    docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=test' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest
