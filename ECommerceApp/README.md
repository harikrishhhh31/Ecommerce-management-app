# E-Commerce Product Management System
### .NET Core 8 MVC + Entity Framework Core + MySQL

---

## 📁 Project Structure

```
ECommerceApp/
├── Controllers/
│   ├── HomeController.cs         ← Dashboard
│   ├── ProductsController.cs     ← Full CRUD for Products
│   └── CategoriesController.cs   ← Full CRUD for Categories
├── Models/
│   ├── Product.cs                ← Product entity
│   └── Category.cs               ← Category entity
├── Data/
│   └── ApplicationDbContext.cs   ← EF DbContext + seed data
├── Views/
│   ├── Home/Index.cshtml         ← Dashboard with stats
│   ├── Products/                 ← Index, Create, Edit, Details, Delete
│   ├── Categories/               ← Index, Create, Edit, Details, Delete
│   └── Shared/_Layout.cshtml     ← Navbar + layout
├── wwwroot/css/site.css
├── appsettings.json              ← Connection string
└── Program.cs                    ← App startup
```

---

## ⚙️ Setup Instructions

### Step 1 — Prerequisites
- Visual Studio Code with C# extension (OmniSharp)
- .NET 8 SDK → https://dotnet.microsoft.com/download
- MySQL Server (with MySQL Workbench recommended)

### Step 2 — Configure MySQL Connection
Edit `appsettings.json` to set your MySQL credentials:
```json
"DefaultConnection": "Server=localhost;Port=3306;Database=ECommerceDB;User=root;Password=YOUR_PASSWORD;"
```
**Note**: Replace `YOUR_PASSWORD` with your actual MySQL password. If no password, use:
```json
"DefaultConnection": "Server=localhost;Port=3306;Database=ECommerceDB;User=root;"
```

### Step 3 — Create the Database
Open MySQL Workbench and create a new database:
```sql
CREATE DATABASE ECommerceDB;
```

### Step 4 — Open the Project
Open the `ECommerceApp` folder in Visual Studio Code.

### Step 5 — Restore NuGet Packages
```bash
dotnet restore
```

### Step 6 — Apply Database Migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
This creates the tables with seeded data (4 categories + 4 products).

### Step 7 — Run the App
```bash
dotnet run
```
Visit: `https://localhost:5001` or `http://localhost:5000`

---

## 🔧 Connection String (appsettings.json)

Default uses local MySQL:
```json
"DefaultConnection": "Server=localhost;Port=3306;Database=ECommerceDB;User=root;Password=YOUR_PASSWORD;"
```

For other MySQL configurations, modify the server, port, or credentials as needed.

---

## ✅ Features

| Feature              | Details                                      |
|----------------------|----------------------------------------------|
| Dashboard            | Total products, categories, stock summary    |
| Product CRUD         | Create, Read, Update, Delete with validation |
| Category CRUD        | Create, Read, Update, Delete                 |
| Search & Filter      | Search by name/description, filter by category |
| Seed Data            | 4 categories + 4 products auto-loaded         |
| Validation           | Required fields, price range, stock range     |
| Stock Status         | Color-coded badges (In Stock / Low / Out)    |
| Success Messages     | TempData alerts after every operation        |

---

## 🗂️ Database Tables

**Categories**
| Column      | Type         |
|-------------|--------------|
| Id          | int (PK)     |
| Name        | nvarchar(100)|
| Description | nvarchar(500)|

**Products**
| Column        | Type            |
|---------------|-----------------|
| Id            | int (PK)        |
| Name          | nvarchar(200)   |
| Description   | nvarchar(1000) |
| Price         | decimal(18,2)   |
| StockQuantity | int             |
| ImageUrl      | nvarchar(max)   |
| CreatedDate   | datetime2       |
| CategoryId    | int (FK)        |
