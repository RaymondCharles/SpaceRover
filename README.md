# Rover Control Center

## Overview

The Rover Control Center is a simulation program that manages the operations of different types of space exploration rovers and satellites. It allows for tracking rover activities such as exploring surfaces and collecting data (e.g., rocks, soil). This program simulates interactions with rovers sent to explore planets and moons, such as Mars and the Moon.

![image](https://github.com/user-attachments/assets/af8a5671-5b00-4f8e-b21d-65e433dd07e2)

## Features

- Rover Management: Manages different types of rovers, including Mars rovers and Moon rovers, as well as satellites.
- Exploration Simulation: Simulates rover actions like exploring surfaces and collecting data.
- Information Display: Displays important information about each rover (e.g., alias, year landed) and their activities.
- Customizable Rover Behavior: Each rover has its own unique methods for exploration and collection based on the celestial body it explores.

## Structure

The project is organized into several C# classes, each representing a different component of the system:

- Program.cs: The main entry point of the application, where rovers and satellites are instantiated and actions are triggered.
- Rover.cs: A base class for all rovers, defining common properties like Alias and YearLanded, and virtual methods for exploration and data collection.
- MarsRover.cs: A subclass of Rover, representing a rover designed for Mars exploration. It overrides methods for Mars-specific behavior.
- MoonRover.cs: A subclass of Rover, representing a rover designed for Moon exploration. It overrides methods for Moon-specific behavior.
- Satellite.cs: Represents a satellite that can explore and collect data, similar to a rover.
- IDirectable.cs: Interface implemented by Rover and Satellite classes, providing methods like GetInfo, Explore, and Collect.

## Getting Started

### Prerequisites

Before running this project, ensure you have the following installed:

.NET SDK: Install the .NET SDK from the official site: Download .NET.
Visual Studio Code (or any other C# IDE): Use this to write, run, and debug the program.

### Installation
Clone or download the repository to your local machine.

Open a terminal and navigate to the project folder.

Run the following command to restore dependencies:

bash
Copy code
dotnet restore
Build the project:

bash
Copy code
dotnet build
Run the program:

bash
Copy code
dotnet run
The program will run and display information about various rovers and satellites, showing their exploration and data collection actions.
