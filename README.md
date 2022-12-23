# Project Setup

## Follow the below steps to do the setup in local machine using cli

- dotnet new sln
- dotnet new webapi API
- dotnet sln add API
- dotnet dev-certs https --trust
- dotnet run (or) dotnet watch run 
- dotnet ef migrations add InitialCreate -o Data/Migrations
- dotnet ef database update

## Notes
ORM - Entity Framework

## Entity Framework Commands
dotnet tool list -g


