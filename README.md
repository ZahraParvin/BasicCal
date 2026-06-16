# MeCalc

A simple two-operand calculator built with C# and Windows Forms.

## Features

- Addition (`+`)
- Subtraction (`-`)
- Division (`/`)
- Multiplication (`*`)
- Percentage (`%`) — calculates what percentage Value1 is of Value2: `(Value1 / Value2) * 100`

## Requirements

- Windows
- .NET Framework 4.7.2

## Getting Started

### Build & Run

1. Open `MeCalc.sln` in Visual Studio.
2. Build the solution (`Ctrl+Shift+B`).
3. Run the application (`F5`).

Alternatively, run the compiled executable directly from `bin\Debug\MeCalc.exe`.

### Usage

1. Enter a number in the **Value1** field.
2. Enter a number in the **Value2** field.
3. Click an operator button (`+`, `-`, `/`, `*`, `%`) to compute the result.
4. The result is displayed in the **Output** field.

## Project Structure

```
MeCalc/
├── Basic.cs              # Main form logic (calculator operations)
├── Basic.Designer.cs     # Windows Forms UI layout (auto-generated)
├── Program.cs            # Application entry point
├── MeCalc.csproj         # Project file (.NET Framework 4.7.2)
└── MeCalc.sln            # Solution file
```

## Tech Stack

- **Language:** C#
- **Framework:** .NET Framework 4.7.2
- **UI:** Windows Forms
- **IDE:** Visual Studio
