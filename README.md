# Classic Snake Game (C# WinForms)
This is my implementation of classic Snake game built in C# and WinForms. I made it to test my proficiency in the C# language (particularly delegates and events), System.Drawing library,
Object-Oriented Programming principles, as well as demonstrate an understanding of the Model-View-Pattern by decoupling the underlying logic from the UI, mediated by a GRASP controller. 

## Core Technical Achievements
- C# Language and Data Structure: Demonstrating strong fundamentals in C# language: Object-Oriented Programming, Generics, and efficient data structures
(specifically, using the lightweight record struct `Position` to map coordinates as well as using `LinkedList<T>` for efficient snake growth and movement).
- WinForms Proficiency: Utilizing System.Drawing library for rendering the visuals. The project also uses a custom-made `DoubleBufferedPanel` control to address screen flickering issue common in WinForms UI visuals.
- Architectural Clarity: Implemented Model-View pattern and GRASP Controller for clear separation of concerns. As well as using the publisher-subscriber model to handle events and further decouple different classes.

## Features
- Classic Gameplay: Grow the snake by eating food, avoiding walls, and the snake's own body.
- Score Tracking: Displays the current score based on food consumption.
- Gradual Difficulty Increase: The higher the score, the faster the snake moves.
- Visual Polish: Detailed visual implementation for the snake's head, including eyes and a tongue for four directional states for added aesthetic pop.
- Game State Management: Clear Game Over and New Game states.
- Responsive Control: Uses keyboard WASD keys for movement.

## Installation and Setup

This project requires Visual Studio and .NET 8+.

1. Clone the Repository

```
git clone https://github.com/OpaliteArchitect/Snake.git
cd Snake
```

2. Open in Visual Studio
   - Open the `.sln` solution file in Visual Studio.

3. Run the Project
   - Press F5 or click Start (the green arrow) to build and run the application.

## How to Play
- Controls: Use WASD to change the direction of the snake.
- Objective: Eat the food to grow and score points.
- Game Over: The game ends if the snake hits the boundary or collides with its own body.

## License

Copyright (c) 2025 OpaliteArchitect. Licensed under [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/).
