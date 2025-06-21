# cashTracker

cashTracker is a simple ASP.NET Core MVC web application for tracking personal expenses. It allows users to register, log in, and manage their expenses by category, with secure authentication and a modern UI using Bootstrap.

## Features

- User registration and authentication (with ASP.NET Core Identity)
- Add, edit, and delete expenses
- Expense categorization
- View total expenses
- Responsive UI with Bootstrap
- SQL Server database with Entity Framework Core

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or update connection string for another provider)
- (Optional) Visual Studio 2022+ or VS Code

### Setup

1. **Clone the repository:**
   ```sh
   git clone https://github.com/yourusername/cashTracker.git
   cd cashTracker
   ```

2. **Configure the database:**
   - Update the connection string in [`appsettings.json`](appsettings.json) if needed.

3. **Apply migrations:**
   ```sh
   dotnet ef database update
   ```

4. **Run the application:**
   ```sh
   dotnet run
   ```
   The app will be available at `https://localhost:7043` or `http://localhost:5130` by default.

## Project Structure

- `Controllers/` - MVC controllers for authentication and expense management
- `Models/` - Entity models (User, Expense)
- `ViewModels/` - View models for forms
- `Views/` - Razor views for UI
- `Data/` - Entity Framework Core DbContext
- `Migrations/` - EF Core migrations
- `wwwroot/` - Static files (CSS, JS, libraries)

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- ASP.NET Core Identity
- Bootstrap 5
- jQuery
---

**Note:** This project is for educational/demo purposes. For production use, review security, validation, and deployment best
