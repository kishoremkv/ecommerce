# Project Setup

## Follow the below steps to do the setup in local machine using cli

- dotnet new sln
- dotnet new webapi API
- dotnet sln add API
- dotnet dev-certs https --trust
- dotnet run (or) dotnet watch run 
- dotnet ef migrations add InitialCreate -o Data/Migrations
- dotnet ef database update
- dotnet new classlib -o Core
- dotnet new classlib -o Infrastructure
- dotnet sln add Core
- dotnet sln add Infrastructure
- dotnet add reference ..\\Infrastructure (inside API folder)
- dotnet add reference ..\\Core (inside Infrastructure folder)
## Notes
ORM - Entity Framework

## Entity Framework Commands
dotnet tool list -g


