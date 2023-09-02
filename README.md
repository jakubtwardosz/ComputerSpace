# ComputerSpace

Computer Space is a WebAssembly e-commerce application built on the Blazor platform and hosted within an ASP.NET Core environment.

## Getting Started

### Prerequisites

To run this project you will need:

 - [Following version of Visual Studio, or Visual Studio Code](https://visualstudio.microsoft.com/pl/downloads/)
 - [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
 - [SQL Server 2022 Express](https://www.microsoft.com/pl-pl/sql-server/sql-server-downloads)
 - [Stripe CLI](https://github.com/stripe/stripe-cli)

### Installing

Download the repository. Open the project folder and type in the console:

    cd .\ComputerSpace\Server\

Update the database:

    dotnet ef database update

Then run the project:

    dotnet run

## Database structure
![db](https://github.com/jakubtwardosz/ComputerSpace/assets/30162836/a2357031-7c97-49e0-9913-66d142829eae)
