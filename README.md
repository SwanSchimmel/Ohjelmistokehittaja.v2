## 🏨 Hotel Management System – Architecture

This project is a simple **CRUD hotel management system** built with **C# WinForms** and **MySQL**.
The application follows a layered architecture where the user interface, business logic, and database access are separated.

### System Architecture

```
                HOTEL MANAGEMENT SYSTEM
────────────────────────────────────────────

            👤 User (Administrator)
                     │
                     ▼
              Windows Forms UI
       ┌───────────────────────────┐
       │ LoginForm                 │
       │ MainForm                  │
       │ ManageClientsForm         │
       │ ManageRoomsForm           │
       │ ReservationsForm          │
       └─────────────┬─────────────┘
                     │
                     ▼
            Business Logic Layer
       ┌───────────────────────────┐
       │ CLIENT class              │
       │ ROOM class                │
       │ RESERVATION class         │
       │ USER class                │
       └─────────────┬─────────────┘
                     │
                     ▼
             Data Access Layer
       ┌───────────────────────────┐
       │ CONNECT class             │
       │ MySqlCommand              │
       │ MySqlDataAdapter          │
       └─────────────┬─────────────┘
                     │
                     ▼
               MySQL Database
       ┌───────────────────────────┐
       │ users                     │
       │ clients                   │
       │ rooms                     │
       │ reservations              │
       └───────────────────────────┘
```

### Data Flow Example (Adding a Client)

```
User → Form → CLIENT.insertClient() → SQL Query → MySQL Database → DataGridView
```

### Database Relationships

```
CLIENTS
-------
client_id (PK)
first_name
last_name
phone

ROOMS
-----
room_id (PK)
room_number
type
price

RESERVATIONS
------------
reservation_id (PK)
client_id (FK)
room_id (FK)
check_in
check_out
```

Relationships:

```
CLIENTS 1 ──── ∞ RESERVATIONS
ROOMS   1 ──── ∞ RESERVATIONS
```

### Technologies Used

* C#
* Windows Forms
* MySQL
* MySql.Data Connector
* ADO.NET
* CRUD operations
