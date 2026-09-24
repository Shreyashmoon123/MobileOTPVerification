# 📱 Mobile OTP Verification

A simple **ASP.NET Core MVC** application that provides mobile number verification using **OTP (One-Time Password)**.

The project uses **Twilio Verify** to send OTPs through SMS and verify the OTP entered by the user.

## 🚀 Technologies Used

* ASP.NET Core MVC
* C#
* Entity Framework Core
* SQL Server
* Twilio Verify API
* Bootstrap
* Razor Views
* Dependency Injection

## ✨ Features

* 📱 Mobile number input
* 🔐 OTP generation and SMS delivery through Twilio Verify
* ✅ OTP verification
* 💾 OTP-related data storage using Entity Framework Core
* 🗄️ SQL Server database integration
* 🎨 Bootstrap-based user interface
* 🔄 Separate service classes for OTP and SMS operations

## 🏗️ Project Structure

```text
MobileOTPVerification
│
├── Controllers
│   ├── HomeController.cs
│   └── OtpController.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Models
│   ├── ErrorViewModel.cs
│   └── Otp.cs
│
├── Services
│   ├── OtpServices.cs
│   └── SmsServices.cs
│
├── Migrations
│
├── Views
│   ├── Home
│   ├── OTP
│   └── Shared
│
├── wwwroot
│
├── Program.cs
├── appsettings.json
└── OtpVerification.sql
```

## 🔄 How It Works

### 1. Enter Mobile Number

The user enters their mobile number through the OTP verification form.

### 2. Send OTP

The application sends the mobile number to the OTP service.

The `SmsService` communicates with the **Twilio Verify API**, which sends an OTP to the user's mobile number through SMS.

### 3. Enter OTP

The user receives the OTP and enters it into the verification form.

### 4. Verify OTP

The entered OTP is sent to Twilio Verify for validation.

If the OTP is valid, the verification is marked as successful.

## 🗄️ Database

The project uses:

* SQL Server
* Entity Framework Core
* Code First approach
* EF Core Migrations

The database contains the required OTP-related data used by the application.

## 🔧 Configuration

Before running the project, configure your Twilio credentials:

* Twilio Account SID
* Twilio Auth Token
* Twilio Verify Service SID

Do not commit real API credentials or secrets to a public repository.

## ▶️ How to Run

### 1. Clone the repository

```bash
git clone https://github.com/Shreyashmoon123/MobileOTPVerification.git
```

### 2. Open the project

Open the project in Visual Studio or VS Code.

### 3. Configure the database

Update the SQL Server connection string according to your local environment.

### 4. Apply migrations

```bash
dotnet ef database update
```

### 5. Configure Twilio

Add your Twilio Verify credentials to the application's configuration.

### 6. Run the application

```bash
dotnet run
```

Open the application in your browser and use the mobile OTP verification form.

## 🎯 Learning Objectives

This project was built to understand practical implementation of:

* ASP.NET Core MVC
* Entity Framework Core
* SQL Server integration
* Dependency Injection
* Service Layer architecture
* Third-party API integration
* SMS-based OTP verification
* Razor Views and Bootstrap

## 👨‍💻 Author

**Shreyash Katiyar**

GitHub: [Shreyashmoon123](https://github.com/Shreyashmoon123)
