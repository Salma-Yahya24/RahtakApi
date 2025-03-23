# RahtakApi

## 📌 Project Description
RahtakApi is a powerful .NET 9 Web API designed using a clean N-Tier architecture. This API serves as the backend for a service booking system, offering comprehensive CRUD operations for various entities such as Users, Bookings, Payments, and Services. The project implements the Repository and Unit of Work patterns for efficient data management.

## 🚀 Technologies Used
- .NET 9
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Repository Pattern
- Unit of Work Pattern
- Dependency Injection

## 📂 Project Structure
- **ProjectApi.Client:** The API Layer containing Controllers, Middleware, and Configuration files.
- **ProjectApi.DAL:** Data Access Layer containing `AppDbContext` and Entity Configurations.
- **ProjectApi.Entities:** Models representing the database tables.
- **Interfaces:** Interface definitions for Repository and UnitOfWork patterns.
- **Repository:** Implementation of Generic Repositories and UnitOfWork.

## 🔧 Setup & Usage
### 1. Clone the Repository
```bash
git clone https://github.com/Salma-Yahya24/RahtakApi.git
cd RahtakApi
```

### 2. Open the solution
- Open the solution in Visual Studio or Visual Studio Code.

### 3. Configure Database Connection
Update `appsettings.json` with your connection string:
```json
"ConnectionStrings": {
    "con": "Server=(localdb)\\MSSQLLocalDB;Database=YourDatabaseName;Trusted_Connection=True;"
}
```

### 4. Apply Migrations & Update Database
```bash
dotnet ef migrations add InitialMigration
```
```bash
dotnet ef database update
```

### 5. Run the Application
```bash
dotnet run
```
Or use Visual Studio to run the project.

## 🌐 API Endpoints
### Users
- `GET /api/Users` - Retrieve all users
- `GET /api/Users/{id}` - Retrieve a specific user by ID
- `POST /api/Users` - Add a new user
- `PUT /api/Users/{id}` - Update an existing user
- `DELETE /api/Users/{id}` - Delete a user

### Bookings
- `GET /api/Bookings` - Retrieve all bookings
- `GET /api/Bookings/{id}` - Retrieve a specific booking by ID
- `POST /api/Bookings` - Add a new booking
- `PUT /api/Bookings/{id}` - Update an existing booking
- `DELETE /api/Bookings/{id}` - Delete a booking

### Services
- `GET /api/SubServices` - Retrieve all services
- `GET /api/SubServices/{id}` - Retrieve a specific service by ID
- `POST /api/SubServices` - Add a new service
- `PUT /api/SubServices/{id}` - Update an existing service
- `DELETE /api/SubServices/{id}` - Delete a service

### Payments
- `GET /api/Payments`
- `POST /api/Payments`
- `PUT /api/Payments/{id}`
- `DELETE /api/Payments/{id}`

... (Add more endpoints as needed)

## 📌 Testing the API
- Use tools like **Postman** or **Swagger** (if enabled) to test the API endpoints.
- Make sure your database is properly configured and migrations are applied before testing.

## 👥 Contributors
- [Salma Yahya](https://github.com/Salma-Yahya24)

## 📄 License
This project is licensed under the MIT License.

