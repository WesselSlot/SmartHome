# SmartHome

## Setup SQL Server with docker
    docker run -d --name name_your_container -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=P@55w0rd' -e 'MSSQL_PID=Developer' -p 1433:1433     microsoft/mssql-server-linux:2017-latest
