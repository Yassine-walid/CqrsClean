# ASP.NET 8 CRUD Application with CQRS, Dapper, and Three-Tier Architecture

## Overview
This project is a sample CRUD (Create, Read, Update, Delete) application built using:
- **ASP.NET Core 8** for the API
- **CQRS** (Command Query Responsibility Segregation) for separating read and write operations
- **Dapper** for lightweight and performant data access
- **Three-Tier Architecture** (API, Domain, Infrastructure) for separation of concerns and maintainability

## Project Structure
  

<pre>
CqrsCleanN_tier ├── </br>
                  ├── CqrsCleanN_tier.API (ASP.NET Core Web API)</br>
                    └── Application</br>
                    └── ProductCqrs</br>
                        └── Commands</br>
                        └── Handlers</br>
                        └── Queris</br>
                    └── Controllers</br>
                  ├── CqrsCleanN_tier.Domain (Class Library) </br>
                    └── Entities</br>
                    └── Interfaces</br>
                  ├── CqrsCleanN_tier.Infrastructure (Class Library)</br>
                    └── Data</br>
                    └── DependencyInjection</br>
                    └── Repositories</br>
</pre>


## Features
- **Product Management**: Create, read, update, and delete products.
- **CQRS Pattern**: Commands and Queries are separated for better scalability and optimization.
- **Dapper ORM**: Fast and efficient data access with direct SQL queries.

## Setup Instructions

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/Yassine-walid/CqrsClean.git
   cd CqrsClean

2. Update the connection string in appsettings.json:
3. Run The Application : dotnet run --project YourProject.API

## Details Tutorial 
<a href="https://66c8b9e6551a897818fedf32--cozy-kulfi-fbb0e4.netlify.app/" target="_blank">Visit The Full Tuto</a>

                  
