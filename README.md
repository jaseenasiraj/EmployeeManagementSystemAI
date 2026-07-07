# Employee Management System API

A RESTful Web API built using ASP.NET Core 8 with a clean architecture approach.

## 🚀 Features

- Create Employee
- Get All Employees
- Get Employee by ID
- Update Employee
- Delete Employee

## 🛠️ Technologies Used

- C#
- ASP.NET Core 8 Web API
- Entity Framework Core
- SQL Server
- Repository Pattern
- DTO Pattern
- AutoMapper
- Swagger / OpenAPI
- Git & GitHub

## 🏗️ Architecture

The project follows a clean separation of concerns:
Controller
↓
DTO
↓
Repository Interface
↓
Repository Implementation
↓
Entity Framework Core
↓
SQL Server

## 📌 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /api/employees | Get all employees |
| GET | /api/employees/{id} | Get employee by ID |
| POST | /api/employees | Create employee |
| PUT | /api/employees/{id} | Update employee |
| DELETE | /api/employees/{id} | Delete employee |

## ▶️ How to Run

1. Clone the repository

2. Update SQL Server connection string in:
3. Apply database migration:
4. Run the application:
5. Open Swagger:
   
## 📚 Learning Goals

This project demonstrates:

- Building RESTful APIs using ASP.NET Core
- Entity Framework Core database operations
- Repository Pattern implementation
- DTO-based API design
- Async programming
- API documentation using Swagger


