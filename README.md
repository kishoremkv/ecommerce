Project Setup

-- Follow the below steps to do the setup in local machine using cli

dotnet new sln
dotnet new webapi API
dotnet sln add API
dotnet dev-certs https --trust
dotnet run

