# Converting a REST API to a GraphQL API

## Prerequisites

- Docker Desktop - running the solution via Docker is the easiest way to startup the API's and seed the database. Download it [here](https://www.docker.com/products/docker-desktop/).
- .NET CLI - included with the .NET 6 SDK - download it [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

## Create a Self-signed Certificate

The API's listen exclusively on HTTPS so a self-signed certificate must be installed on your machine and imported into the API containers. Open a PowerShell window and run the following to clean up existing dev certificates:

```powershell
dotnet dev-certs https --clean
```

Run the command below to install the self-signed certificate. **Do not change the password.**

```powershell
dotnet dev-certs https --trust -ep $env:USERPROFILE\.aspnet\https\aspnetapp.pfx -p "Strong(!)Password"
```

## Build the Docker Containers

Open a PowerShell prompt and navigate to the `ConvertRestToGraphQL` folder. Then run the following:

```powershell
docker-compose build --parallel
```

## Run the Docker Containers

Open a PowerShell prompt and navigate to the `ConvertRestToGraphQL` folder. Then run the following:

```powershell
docker-compose up
```

Wait until you see output similar to the following indicating that the database has been seeded:

```powershell
dataloader_1  | Inserting device rows...
dataloader_1  | Inserted 10 device rows.
dataloader_1  | Inserting telemetry rows...
dataloader_1  | Inserted 87610 telemetry rows.
convertresttographql_dataloader_1 exited with code 0
```

## Explore the REST API

Browse to `https://localhost:55555/swagger` to see the REST API endpoints.

## Explore the GraphQL API

Browse to `https://localhost:44444/ui/playground` to see the GraphQL interface.

## Cleanup

Press `CTRL+C` to stop the containers. Run the following command to delete the containers:

```powershell
 docker rm convertresttographql_dataloader_1 convertresttographql_graphapi_1 convertresttographql_restapi_1 convertresttographql_sql_1
```
