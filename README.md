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
- To list all the tools - `dotnet tool list -g` 
- To add migrations - `dotnet ef migrations add InitialCreate -p Infrastructure/ -s API/ -o Data/Migrations`

- To drop the database - `dotnet ef database drop -p Infrastructure/ -s API/`

- To remove the migrations - `dotnet ef migrations remove -p Infrastructure/ -s API/`


## Generic Repository
- Intuition - Same repository for all entities instead of using many
- Cons - Cannot implement specific functionalities (like including different entities in the resultset of a given entity)

## Specification Design Pattern
- It is a behavioral pattern
- Resolved the problems faced by Generic Repository
- This pattern allows us to seperate the search criteria from the object that performs the search
- It is used upon Generic repository to reap the benefits of it

## Automapper 
- Used to map ORM objects to DTO ( Data transfer objects) automatically
- We should add automapper -> Nuget package as a service in startup.cs file

## Pagination


## CORS Header
It is required inorder to not allow any cyber attacks to take place while loading an address from the browser. 
API has to send the CORS headers to the browser inorder to permit the information. 
