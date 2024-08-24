# OOP Principles in C#

This project is a demonstration of the four Object-Oriented Programming (OOP) principles using C#. It contains examples of:

1. **Encapsulation** - Encapsulation refers to bundling data and the methods that operate on it into a single unit, while restricting direct access to certain internal details. This is done using private fields and public properties in the `Vehicle` class.

---

2. **Abstraction** - Abstracting away complex implementation details. The `Vehicle` class is an abstract class that provides the base blueprint for all vehicles, leaving certain implementations (e.g., starting the engine) to its derived classes.

---

3. **Inheritance** - The concept of one class inheriting from another. The `Car` and `Motorcycle` classes inherit from the `Vehicle` base class, sharing common functionality and attributes.

---

4. **Polymorphism** - The ability to treat objects of different types in a similar way. Both the `Car` and `Motorcycle` classes override the `StartEngine` method, demonstrating runtime polymorphism.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

### Running the Application

1. Clone the repository:
   ```bash
   git clone git@github.com:yasser-mohamed1/OOP.git
   ```
2. Navigate to the project directory:

   ```bash
   cd OOPPrinciples
   ```

3. Run the project:
   ```bash
   dotnet run
   ```

### Example Output

```
  Toyota Corolla 2020 with 4 doors.
  Car engine started.
  Car engine stopped with the key.

  *****************************

  Harley-Davidson Sportster 2018 with sidecar: False
  Motorcycle engine started.
  Engine stopped.
```
