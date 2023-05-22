# Designing Classes <br> *- A broken divide*

## Content

- [Intro](#intro)
  - [Goals](#goals)
- [Running This](#running-this)
- [Test Yourself](#test-yourself)
- [Terminology](#terminology)
- [Further Reading](#further-reading)

## Intro

There are multiple strategies for designing classes. Two of the most common ones are Inheritance and Composition.

1. Inheritance <br>
Inheritance is a mechanism where a class inherits properties and behaviors from another class, known as the superclass or base class. The derived class, or subclass, extends the functionality of the base class by adding or modifying its attributes and methods. Inheritance promotes code reuse and allows for hierarchical relationships, but it can lead to tight coupling and inflexible designs when used excessively.

2. Composition - [Link to example](https://github.com/LarsGJobloop/csharp-classes-inheritance-composition)<br>
Composition involves constructing complex objects by combining simpler objects or components. Instead of inheriting behaviors, a class uses other classes as member variables to achieve the desired functionality. Composition promotes loose coupling and flexibility, as components can be easily replaced or modified without affecting the entire system. It allows for greater code modularization and favors object aggregation over specialization.
<br><br>
The example provided here shows how a program that only cares about logging messages can be made more modular by leveraging composition. Why should the program be bothered if we want to log to the console, a file or possibly to some web based API?

In summary, inheritance emphasizes the "is-a" relationship between classes, creating a hierarchy of specialization, while composition focuses on the "has-a" relationship, enabling flexible object composition and modular design. Both approaches have their strengths and should be chosen based on the specific design requirements and the desired balance between code reuse, flexibility, and maintainability.

### Goals

Explain and provide example of:
  1. A classe made by inheritance
  2. A classe made by composition

## Running This

1. Clone the repository
```sh
git clone https://github.com/LarsGJobloop/csharp-classes-inheritance-composition
```
2. Open in VS Code and open in devcontainer.
3. Test run the program
```sh
dotnet run
```

## Test Yourself

TODO

## Terminology

| Word | Description | Links |
| --- | --- | --- |
| Interface | is a description of what public members, methods (and their signature) is available on a class or function | [MS Docs](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces) |
| Implements | A class **implementing** an *Interface*, means that a class have the members and methods defined in an *Interface* | |
| Function (Methode) Signature | The signature of a function is the **type returned** by the function, as well as the **parameters and their type** | |

## Further Reading

TODO