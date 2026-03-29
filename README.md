# E-Commerce Store Management System
## ASP.NET Core 8 MVC with Entity Framework Core and MySQL

This repository contains a comprehensive web application for managing an e-commerce store's products and categories. The system is built using the Model-View-Controller (MVC) architectural pattern and utilizes Entity Framework Core for robust database interactions with MySQL.

---

## Project Architecture

The application is structured logically to separate concerns and ensure maintainability:

- **Controllers**: Handles incoming HTTP requests and coordinates data flow between Models and Views.
- **Models**: Defines the data structures and business logic for Products and Categories.
- **Data Access**: Utilizes ApplicationDbContext for Entity Framework Core operations and initial data seeding.
- **Views**: Implements a clean, responsive user interface using Razor views and Bootstrap 5.
- **Client Assets**: Standardized CSS and JavaScript located in the wwwroot directory.

---

## Technical Features

The system implements several high-level features for efficient store management:

- **Centralized Dashboard**: Provides real-time statistics on total inventory, category density, and overall stock levels.
- **Product Lifecycle Management**: Complete Create, Read, Update, and Delete (CRUD) operations for products with server-side validation.
- **Category Organization**: Dynamic categorization system to group products for better inventory management.
- **Advanced Filtering**: Integrated search functionality and category-based filtering for rapidly locating items in the catalog.
- **Automated Database Setup**: Integrated database initialization using EnsureCreated to simplify local deployment.
- **Inventory Monitoring**: Visual status indicators for out-of-stock and low-stock items.
- **Database Resilience**: Uses Pomelo.EntityFrameworkCore.MySql for high-performance integration with MySQL.

---

## Prerequisites and Requirements

To run this application locally, ensure you have the following software installed:

- **.NET 8 SDK**: The core framework for compiling and running the application.
- **MySQL Server**: Required for data persistence.
- **IDE**: Visual Studio 2022 or Visual Studio Code with C# Dev Kit is recommended.

---

## Local Deployment Guide

Follow these steps to initialize and run the application on your local environment:

### 1. Database Configuration
Locate the `appsettings.json` file in the root project directory and update the `DefaultConnection` string with your MySQL server credentials:

```json
"DefaultConnection": "Server=localhost;Port=3306;Database=EcommerceDb;User=root;Password=YOUR_PASSWORD;"
```

### 2. Environment Setup
Navigate to the project root directory in your terminal and restore the necessary NuGet packages:

```bash
dotnet restore
```

### 3. Application Execution
Start the application using the following command:

```bash
dotnet run
```

### 4. Direct Access
Once the application has started, navigate to the local hosting URL (typically `http://localhost:5000`) in your web browser. The system will automatically detect the missing database and initialize the schema along with initial seed data.

---

## Database Schema Documentation

### Categories Table
Represents logical groupings of products.
- **Id**: Primary Key (Integer, Identity)
- **Name**: Category Label (String, Required)
- **Description**: Detailed category summary (String, Optional)

### Products Table
Represents individual inventory items.
- **Id**: Primary Key (Integer, Identity)
- **Name**: Product Title (String, Required)
- **Description**: Comprehensive item description (String, Required)
- **Price**: Unit cost (Decimal, Required)
- **StockQuantity**: Current inventory level (Integer, Required)
- **ImageUrl**: Path to product imagery (String, Optional)
- **CreatedDate**: System timestamp of entry (DateTime)
- **CategoryId**: Relationship link to Category (Foreign Key)

---

## Licensing and Use
This project is developed for administrative management purposes and is optimized for use with modern web standards and database configurations.
