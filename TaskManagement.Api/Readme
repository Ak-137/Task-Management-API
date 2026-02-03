# Task Management API

Simple REST API for managing tasks with CRUD operations and status filtering.

## Prerequisites

Install EF Core tools (one-time setup):
```
dotnet tool install --global dotnet-ef
```

## Setup

Restore packages:
```
dotnet restore
```

## Database Migration

Create and apply migrations:
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## How to Run

```
dotnet run
```

API runs on: `http://localhost:5090`

## Swagger URL

When running in Development mode:
```
http://localhost:5090/swagger
```

## API Endpoints

- `GET /api/tasks` - Get all tasks (optional query: `?status=Pending|InProgress|Completed`)
- `GET /api/tasks/{id}` - Get task by ID
- `POST /api/tasks` - Create new task
- `PUT /api/tasks/{id}` - Update task
- `DELETE /api/tasks/{id}` - Delete task

## How to Test

Use Swagger UI at `http://localhost:5090/swagger` or any HTTP client.

Example POST request:
```json
{
  "title": "Test task",
  "description": "Some description",
  "dueDate": "2026-02-10",
  "priority": "High",
  "status": "Pending"
}
```

Enum values:
- Priority: `Low`, `Medium`, `High`
- Status: `Pending`, `InProgress`, `Completed`
