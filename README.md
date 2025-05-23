# CourseEnrollmentSystem

A basic ASP.NET MVC web application that allows users to manage students and course enrollments. The project demonstrates the use of foreign key relationships between Courses and Students using Entity Framework with a responsive Bootstrap UI.

## 🔧 Features

- Add, view, update, and delete Students  
- Add, view, update, and delete Courses  
- Link each student to a course (1-to-many relationship)  
- Responsive design using Bootstrap  
- CRUD operations using Entity Framework  

## 🧱 Technologies Used

- ASP.NET MVC (.NET Framework)  
- Entity Framework (Code First)  
- SQL Server  
- Bootstrap 5  
- HTML/CSS  

## 📁 Project Structure

1. **Models** – Contains the Student and Course classes, defining the data structure and relationships (including foreign keys).  
2. **Controllers** – Handles application logic and routes user requests for Students and Courses.  
3. **Views** – Razor-based pages to display and interact with data (Courses`, `Students`, `Shared` layouts).  
4. **Migrations** – Manages database schema changes and version control using Entity Framework Code First.  
5. **Web.config** – Stores project configuration settings and database connection strings.  
6. **Scripts & Content** – Includes Bootstrap, jQuery, and custom CSS files for styling and interactivity.  

## 🚀 How to Run

1. Clone or download the repository.  
2. Open the solution (.sln` file) in **Visual Studio**.  
3. Build the project to restore all dependencies.  
4. Run the application using **Ctrl + F5** or the "Start Without Debugging" option.  
5. The database will be automatically created using **Entity Framework Migrations** if it's configured correctly in Web.config`.  
6. Navigate to /Students or /Courses in the browser to manage records.  

## ✍️ Author

Created by **A S Srividhya** — aspiring ASP.NET MVC developer.



