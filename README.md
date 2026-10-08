# Random String Analysis — Random String Analysis & Quiz

A C# console application developed as an academic programming project. The program generates random strings, analyzes their distinct characters, evaluates user-provided answers, and reports performance statistics.

## Overview

The application creates a configurable number of questions. For each question, two random strings are generated using a predefined character set.

The user determines:

- The number of distinct characters in the first string
- The number of distinct characters in the second string
- The combined length of both strings

The program compares the user's answers with the calculated results and classifies each question as completely correct, partially correct, or completely incorrect.

## Features

- Configurable number of questions
- Configurable random string length
- Random string generation
- Distinct-character detection
- User answer validation
- Partial and complete answer evaluation
- Performance statistics
- Interactive console menu
- `IGNORE` option for skipping questions

## Technologies

- C#
- .NET 8
- Console Application
- Visual Studio

## How It Works

### 1. User Setup

The program asks the user for the required configuration and input before starting the quiz.

### 2. Random String Generation

Two random strings are generated for every question using a predefined collection of letters, digits, and punctuation characters.

### 3. Character Analysis

The application calculates the number of unique characters appearing in each generated string.

For example:

```text
String: AAABBC123
Distinct characters: A B C 1 2 3
Count: 6
```

### 4. Answer Evaluation

The user provides three answers for each question:

1. Distinct characters in string 1
2. Distinct characters in string 2
3. Combined length of both strings

The answers are evaluated individually and the overall result is classified according to the number of correct answers.

### 5. Statistics

After completing the questions, the application provides options for reviewing completely false, partially true, and completely true answers as well as overall user statistics.

## Project Structure

```text
Random String Analysis/
├── Random String Analysis.sln
├── README.md
├── .gitignore
└── Random String Analysis/
    ├── Random String Analysis.csproj
    ├── Random String Analysis.sln
    └── Random String Analysis.cs
```

## Requirements

- .NET 8 SDK
- Visual Studio 2022 or another IDE supporting .NET 8

## Running the Project

### Using the .NET CLI

```bash
dotnet restore
dotnet run --project Random String Analysis/Random String Analysis.csproj
```

### Using Visual Studio

Open `Random String Analysis.sln` in Visual Studio and run the project.

## Concepts Practiced

This project demonstrates fundamental programming concepts including:

- Variables and data types
- Strings and character processing
- Loops and conditional statements
- Methods and program decomposition
- Random number generation
- User input and validation
- Basic algorithm design
- Result classification
- Console-based user interfaces

## Project Information

* **Status:** Completed
* **Developed:** 2024
