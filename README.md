### Appeal / Case Report Form System

## This project is a multi-stage full-stack GUI application that manages the complete lifecycle of a student appeal / case report form. It extends the original Appeal Form lab by persisting all form stages to files, enforcing stage-based access control, and providing administrative analytics.

The system ensures that once a stage is completed and submitted (signed), earlier stages become locked (read-only) and only the next legal stage becomes accessible.

## 🎯 Project Objectives

Implement all stages of the Case Report / Appeal Form as a GUI

Persist all form data to files for later recall

Enforce strict stage-based permissions (view vs edit)

Prevent unauthorized access to future or previous stages

Provide administrative oversight of all active cases

Analyze trends in appeal issues using keyword detection

## 🧩 Case Report Stages

Each case progresses through the following stages:

Student Submission

Student completes and submits the initial appeal form

File is created and saved

Upon submission, the student section becomes locked

Instructor Review

Instructor views student submission (read-only)

Instructor completes their section and submits

Instructor section becomes locked after submission

Department Chair Review

Chair views all prior stages (read-only)

Chair completes their section and submits

Chair section becomes locked after submission

Dean Review

Dean views the entire case history (read-only)

Dean completes final decision stage

At all times, only the current legal stage is editable.

## 🔒 Access Control Rules

Users may only:

Edit the form section assigned to their role

View completed sections from previous stages

Users may not:

Edit previous stages after submission

Access future stages

Modify data outside their role

All access rules are enforced by the system logic, not user choice.

## 📁 File Management

Each case is stored as a file on disk

Files contain all completed stages of the form

Supported operations:

Open an existing case file

Save progress at the current stage

Recall a case and resume at the correct stage

Once a stage is signed (submitted):

That section becomes permanently read-only

The next stage is unlocked

## 🖥️ Graphical User Interface (GUI)

The GUI provides:

Separate views for:

Student

Instructor

Department Chair

Dean

Administrator

Clear visual indicators for:

Current stage

Locked vs editable sections

Open / Save file dialogs

## 📊 Administration Dashboard

The Administration View allows authorized users to:

View all case files in the directory

See the current stage of each case

Track progress across all active appeals

Example dashboard data:

File name / Case ID

Current stage (Student / Instructor / Chair / Dean)

Completion status

## 🔍 Keyword Detection & Issue Analysis (Python Integration)

To support decision-making, the Dean and Department Chairs can analyze trends across cases.

Features

Search for keywords (e.g., "grading", "attendance", "medical") across all previous-stage inputs

Detect occurrences within stored case files

Report:

Which files contain the keyword

Exact locations of each instance

Implementation

A Python program scans all form files in the directory

The program:

Parses stored case data

Detects keyword occurrences

Returns results to the GUI

Bonus Feature

Highlight detected keywords directly inside the RTF text boxes

## 🧱 Tech Stack (Typical)
GUI / Frontend

.NET (Windows Forms / WPF)

RTF text boxes for form input

Backend Logic

C# application logic

File-based persistence

Analytics

Python script for keyword detection

Integrated execution and result reporting

## 📚 Learning Outcomes

This project demonstrates:

Multi-stage workflow design

File persistence and recall

GUI state management

Role-based access control

Inter-process communication (GUI ↔ Python)

Text analysis and keyword detection

## 🏁 Submission Notes

All required stages are implemented

Illegal stage access is prevented

Files are locked correctly after submission

Administrative dashboard is functional

Python keyword detection is integrated

## 📄 License

This project was developed for academic purposes.
