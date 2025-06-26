# Task Manager Application

## Overview
The Task Manager Application is a web application built using .NET 8.0 that allows users to manage tasks effectively. Users can create, edit, delete, and view tasks through a user-friendly interface.

## Features
- **Task Management**: Create, edit, and delete tasks.
- **Database Integration**: All tasks are stored in a database for persistence.
- **User Interface**: Simple and intuitive Razor views for task operations.

## Project Structure
```
TaskManagerApp
├── Controllers
│   └── TasksController.cs
├── Data
│   └── TaskManagerContext.cs
├── Models
│   └── TaskItem.cs
├── Views
│   └── Tasks
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       ├── Delete.cshtml
│       └── Index.cshtml
├── appsettings.json
├── Program.cs
├── Startup.cs
└── README.md
```

## Setup Instructions
1. **Clone the Repository**: 
   ```
   git clone <repository-url>
   cd TaskManagerApp
   ```

2. **Install Dependencies**: 
   Ensure you have the .NET SDK installed. Run the following command to restore dependencies:
   ```
   dotnet restore
   ```

3. **Configure Database**: 
   Update the `appsettings.json` file with your database connection string.

4. **Run Migrations**: 
   If using Entity Framework, run the following command to apply migrations:
   ```
   dotnet ef database update
   ```

5. **Start the Application**: 
   Run the application using:
   ```
   dotnet run
   ```

6. **Access the Application**: 
   Open your web browser and navigate to `http://localhost:5000` to access the Task Manager Application.

## Usage
- Navigate to the tasks index page to view all tasks.
- Use the "Create" button to add a new task.
- Click on a task to edit or delete it.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License
This project is licensed under the MIT License.