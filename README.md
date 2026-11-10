Here’s a polished README update with icons and text for the project:

# 🔌 Interface practise in C#

This repository contains two small console applications that demonstrate how interfaces work in C#.

## ✨ What is included?

The project is divided into two examples:

- 🧩 Interface 1
  - Shows a class implementing one or more interfaces
  - Demonstrates how a class can satisfy a contract through method implementations

- 🔁 Interface 2
  - Shows multiple interfaces with different method signatures
  - Demonstrates how one class can implement more than one interface and expose different behaviors

## 📁 Project structure

```text
8-interface/
├── Interface2/
│   ├── IProgram.cs
│   ├── IExtra.cs
│   ├── Program1.cs
│   ├── Program2.cs
│   ├── Program.cs
│   ├── InterfacePart1.csproj
│   ├── Interface2.sln
│   └── README.txt
├── InterfacePart2/
│   ├── IFirst.cs
│   ├── ISecond.cs
│   ├── MyProgram.cs
│   ├── Program.cs
│   ├── InterfacePart2.csproj
│   └── README.txt
├── README.md
└── .gitignore
```

## 🧠 Concepts covered

- interfaces in C#
- implementing multiple interfaces
- polymorphism through interface references
- separating behavior from implementation
- using interface contracts in console applications

## ▶️ How to run

Open the solution in Visual Studio or use the .NET CLI to run one of the projects.

Example:

```bash
dotnet run --project Interface2/InterfacePart1.csproj
```

or

```bash
dotnet run --project InterfacePart2/InterfacePart2.csproj
```

## 🛠️ Technologies

- C#
- .NET
- Console applications
- Object-oriented programming

## 📌 Summary

This project is a beginner-friendly example of how interfaces can be used to define shared behavior and build flexible, reusable C# programs.
