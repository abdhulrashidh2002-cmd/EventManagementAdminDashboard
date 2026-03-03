# 🛠️ Campus Event Management System – Admin Application

## 📌 Overview
This is the **Admin Application** of the Campus Event Management System.

It allows administrators to manage campus events and monitor user interactions.

Built using **Blazor WebAssembly Standalone** and connected to **Firebase Firestore**.

---

## 🛠️ Technologies Used

- Blazor WebAssembly Standalone
- .NET 8
- C#
- Firebase Firestore
- Firebase Authentication
- JavaScript Interop

---


## 🔐 Admin Features

Administrators can:

- Create new events
- Edit event details
- Delete events
- View RSVP submissions
- View user feedback
- Manage event pricing

All data operations are stored in Firebase Firestore.

---

## 🗂️ Database Design

Main Collection:
Each event document contains:
- title
- description
- date
- venue
- baseTicketPrice

Subcollections:
- rsvps
- feedback

---

## ⚙️ How to Run the Project

### 1️⃣ Clone Repository

bash:
git clone https://github.com/YOUR-USERNAME/EventAdminDashboard.git
2️⃣ Open in Visual Studio

Open .sln file and restore packages.

3️⃣ Configure Firebase

Open:

wwwroot/index.html

Replace Firebase configuration with your own project credentials.

Enable:
Firestore Database

Authentication (Email/Password)

4️⃣ Run the Application

Set as Startup Project → Press Ctrl + F5
