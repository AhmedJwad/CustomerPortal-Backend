# 🛍️ CustomerPortal Backend

**A RESTful API built with ASP.NET Core 10, featuring JWT authentication, secure account management, and role-based access control.**

[![.NET](https://img.shields.io/badge/.NET-10-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-CC2927?logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server)
[![JWT](https://img.shields.io/badge/JWT-Authentication-000000?logo=jsonwebtokens&logoColor=white)](https://jwt.io/)
[![API Status](https://img.shields.io/badge/API-Deployed-success)](https://customerportal-backend.runasp.net/)

---

## 📖 Overview

CustomerPortal Backend is the server-side component of a customer portal application developed using ASP.NET Core 10 and C#.

It provides authentication, authorization, profile management, and administrative functionality through RESTful API endpoints. Integrated with a React frontend, the application delivers role-specific features for regular users and administrators.

## ✨ Key Features

### 🔐 Authentication & Security

- **User Registration** — Create new user accounts.
- **Email Confirmation** — Confirm email addresses during registration.
- **JWT Authentication** — Secure access to protected endpoints using short-lived access tokens and refresh-token renewal.
- **Forgot Password** — Recover account access through password reset functionality.
- **Change Password** — Allow authenticated users to update their passwords.

### 👤 User Features

- **View Profile** — Retrieve personal account information after authentication.
- **Edit Profile** — Update profile details.
- **Protected Access** — Access authorized resources according to the user's permissions.

### 🛡️ Administrator Features

- **User Management** — View and manage registered users.
- **Administrator Management** — Create additional administrator accounts.
- **User Statistics** — Access user-related statistics through the administrative interface.
- **Role-Based Authorization** — Restrict administrative operations to authorized roles.

## 🔑 Token Lifecycle

The application uses access tokens and refresh tokens to manage authenticated sessions.

| Token | Purpose | Lifetime |
|---|---|---|
| Access Token | Authorize requests to protected API endpoints | 15 minutes |
| Refresh Token | Obtain a new access token without requiring the user to log in again | 7 days |

Short-lived access tokens help limit the period during which a stolen token can be used, while refresh tokens support session renewal.

## 🧰 Technology Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core 10 |
| Programming Language | C# |
| Database | Microsoft SQL Server |
| ORM | Entity Framework Core |
| Identity Management | ASP.NET Core Identity |
| Authentication | JWT (JSON Web Tokens) |
| Frontend | React |

## 🌐 Live Applications

- **Backend API:** [CustomerPortal Backend](https://customerportal-backend.runasp.net/)
- **Frontend Application:** [CustomerPortal Frontend](https://customerportal.runasp.net/)



## 👨‍💻 Author

**Ahmed Jawad Kadhim**  
Full-Stack Developer | ASP.NET Core & React



---

⭐ If you find this project useful, consider giving the repository a star!
