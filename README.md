# 🏥 Hospital Appointment Management System

## 📝 Overview
The **Hospital Appointment Management System** is a **C# Windows Forms** application integrated with a **REST API** for managing patient appointments.  
Patients can **book**, **reschedule**, and **cancel** appointments, while doctors and admins can manage schedules and generate reports.  
The system uses **layered architecture**, **dependency injection (DI)**, and follows **best software engineering practices**.

---

## ✨ Key Features

- 👥 **User Management**: Role-based access for **Patients**, **Doctors**, and **Admins**.  
- 📅 **Appointment Scheduling**: Schedule, reschedule, or cancel appointments with checks to prevent **double-booking**.  
- 🩺 **Doctor & Schedule Management**: Doctors set availability; Admins add doctors and specialties.  
- 📊 **Reporting**: Generate appointment reports and track patient visit history.

---

## 🏗 Architecture

- 🖥 **Presentation Layer**: Windows Forms UI.  
- 🔧 **Business Logic Layer**: Scheduling, validation, and notifications.  
- 🔌 **Data Access Layer**: Communicates with the REST API.  
- 🌐 **API Layer** (Optional): Manages hospital data with ASP.NET Core.

---

## 🧠 Key Concepts

- 🔄 **Dependency Injection (DI)** for modular, maintainable services.  
- 🏭 **Factory** and 📚 **Repository Patterns** for appointment handling and API communication.  
- 🔐 **Role-based authentication** with JWT for secure access.

---

## 🔗 REST API Endpoints

| Method | Endpoint                     | Description              |
|--------|------------------------------|--------------------------|
| POST   | `/api/appointments`          | Schedule an appointment  |
| GET    | `/api/appointments`          | Get appointments by patient ID |
| PUT    | `/api/appointments/{id}`     | Reschedule appointment   |
| DELETE | `/api/appointments/{id}`     | Cancel appointment       |
| GET    | `/api/doctors`               | Retrieve available doctors |

---

## 🎯 Goals

- Build a real-world **C# Windows Forms** application.  
- Gain experience with **RESTful API** integration.  
- Apply software engineering principles like **DI** and **layered architecture**.

---

