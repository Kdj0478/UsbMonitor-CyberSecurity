# Consent-Based USB Activity Monitoring System

A small **defensive cybersecurity monitoring application** developed in C# and .NET using Visual Studio for an undergraduate Cybersecurity practical project.

## 📌 Project Overview

The **Consent-Based USB Activity Monitoring System** is an educational Windows application designed to demonstrate basic endpoint monitoring and data-integrity concepts in a transparent and privacy-conscious way.

The application monitors USB storage device connection and disconnection events **only after the user explicitly gives consent**. It records limited security-relevant activity, stores the information in a local log file, and generates a SHA-256 hash to demonstrate the importance of log integrity.

This project was developed as part of my Cybersecurity elective course, where the objective was to move beyond theoretical learning and gain practical exposure to cybersecurity concepts.

## 🎯 Objectives

The main objectives of this project are to:

* Implement an explicit user consent mechanism before monitoring begins.
* Detect USB storage device connection and disconnection events.
* Record basic activity information such as date, time, and event type.
* Store monitoring events in a local log file.
* Generate a SHA-256 hash of the log to demonstrate data integrity.
* Demonstrate how modifying a log file changes its integrity hash.
* Provide a simple activity report.
* Allow the user to stop monitoring at any time.
* Practice defensive security concepts in a controlled environment.

## 🔐 Privacy & Ethical Scope

This project is intentionally designed as a **transparent and consent-based security application**.

It does **not**:

* Capture keystrokes.
* Collect passwords or credentials.
* Read browser history, cookies, or saved credentials.
* Copy or inspect personal documents.
* Capture screenshots.
* Access the webcam or microphone.
* Hide itself from the user.
* Bypass Windows security mechanisms.
* Automatically execute files from USB devices.
* Send collected information secretly to external systems.
* Monitor a computer without the user's knowledge or consent.

The application is intended only for **authorized educational and laboratory use**.

> **Ethical Notice:** This project should only be tested on a computer and USB devices for which the user has permission to perform monitoring.

## 🛠️ Technologies Used

* **C#**
* **.NET**
* **Visual Studio**
* **Windows**
* Windows device/event mechanisms
* Local text/CSV/JSON logging
* SHA-256 cryptographic hashing

## 🏗️ Project Structure

```text
CyberSecurityLab/
│
├── Monitor/
│   ├── ConsentManager.cs
│   ├── USBMonitor.cs
│   ├── ActivityLogger.cs
│   └── IntegrityManager.cs
│
├── Logs/
│   └── activity.log
│
├── TestData/
│   └── Sample test files
│
├── Documentation/
│   ├── Project Report
│   ├── Test Cases
│   └── User Manual
│
└── CyberSecurityLab.sln
```

The exact structure may evolve during development as the application is improved.

## ⚙️ Main Components

### ConsentManager

Handles the application's consent/authorization process and ensures that monitoring does not begin until the user explicitly agrees.

### USBMonitor

Responsible for detecting USB storage device connection and disconnection events using appropriate Windows mechanisms.

### ActivityLogger

Records permitted monitoring events with timestamps in a local log file.

### IntegrityManager

Calculates the SHA-256 hash of the activity log and demonstrates how changes to the file affect its integrity value.

### Report

Provides a simple view of the activities recorded during the monitoring session.

## 🔄 Basic Workflow

```text
Application Starts
        ↓
Display Consent Notice
        ↓
User Gives Consent?
      /     \
    No       Yes
    ↓         ↓
   Exit    Start Monitoring
              ↓
       Detect USB Events
              ↓
        Record Event
              ↓
          Local Log
              ↓
        Generate SHA-256
              ↓
         Activity Report
              ↓
       User Stops Monitoring
```

## 🧪 Testing

The application can be tested in a controlled laboratory environment using a test USB storage device.

Example test cases include:

| Test Case            | Expected Result                      |
| -------------------- | ------------------------------------ |
| Start application    | Consent notice is displayed          |
| Select "No"          | Monitoring does not start            |
| Select "Yes/I Agree" | Monitoring starts                    |
| Connect test USB     | USB connection event is recorded     |
| Disconnect test USB  | USB disconnection event is recorded  |
| Stop monitoring      | Monitoring stops                     |
| Generate hash        | SHA-256 hash is displayed/generated  |
| Modify log file      | A different SHA-256 hash is produced |

## 🔎 Cybersecurity Concepts Demonstrated

This project provides practical exposure to several basic cybersecurity concepts:

* Endpoint monitoring
* User consent and authorization
* Security event logging
* Audit trails
* Data integrity
* Cryptographic hashing
* SHA-256
* Privacy-aware security design
* Defensive security practices
* Controlled security testing

## 🤖 AI-Assisted Development

AI tools were used extensively during the development of this project for:

* Understanding programming concepts
* Generating and explaining code
* Debugging
* Structuring the application
* Exploring Windows event mechanisms
* Improving documentation

The project was developed as a **learning and experimentation exercise**, rather than as a claim of completely independent implementation.

As part of my learning process, I am working toward understanding the implementation behind each component and being able to explain the application's functionality rather than relying only on its final output.

## 📚 Learning Purpose

One of the main purposes of this project was to gain practical exposure to cybersecurity.

Since cybersecurity involves more than theoretical knowledge, this project provided an opportunity to experiment with a small defensive security application and explore how concepts such as monitoring, logging, authorization, and data integrity can be implemented in practice.

Building the project also increased my interest in understanding how cybersecurity tools work internally and encouraged me to explore the field further.

## 🚀 Future Improvements

Possible future improvements include:

* A more polished graphical user interface.
* Exporting reports to CSV or JSON.
* Improved log management.
* Better visualization of monitoring events.
* Additional integrity-verification features.
* More comprehensive automated testing.
* Deeper understanding and independent implementation of each component.

## ⚠️ Disclaimer

This project is intended strictly for **educational, defensive, and authorized security testing**.

Do not use it to monitor systems, devices, or users without appropriate authorization and consent.
