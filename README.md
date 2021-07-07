# Blue Modas - Server

API with ASP.NET Core 3 and EF Core 3 using DDD, SOLID, Clean Code and CQRS principles.

## About this Project

Project that provides a REST API for an online store.

## Why?

At the time of covid 19 companies need to digitize! With that in mind, Blue Modas store needs a virtual store to allow the sale of their clothes online.

## Features

- Architecture
  - Division into layers
  - Principles of SOLID and Clean Code

- Database SqlServer
  - Repository Pattern (EF 3.0.1)
  - Migrations
  
- Documentation
  - Swagger

## Documentation

To access the documentation navigate to the endpoint /swagger
   
## Getting Started

### Prerequisites

To run this project in the development mode, you'll need to have a basic environment to run a .NET Core Application and SqlServer Database. You can get it from the following links:

- [.NET Core](https://dotnet.microsoft.com/download)
- [SqlServer](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

### Installing the Project

**Cloning the Repository**

```
$ git clone https://github.com/brunoalves9698/bluemodasserver.git

$ cd bluemodasserver
```

### Creating the Datadase using Migrations

1 - Add EF Core migration CLI

```
$ dotnet tool install --global dotnet-ef
```

2 - Create DataBase

```
$ cd src/bluemodas.infra

$ dotnet ef database update
```

### Running the Project

With all dependencies installed and the environment properly configured, you can now run the app:

```
$ cd ..

$ cd src/bluemodas.api

$ dotnet run 
```

## Built With

- [.NET Core 3](https://docs.microsoft.com/pt-br/dotnet/core/)
- [EF Core 3](https://docs.microsoft.com/pt-br/ef/core/get-started/?tabs=netcore-cli)
