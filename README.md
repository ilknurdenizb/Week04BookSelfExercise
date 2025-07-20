# 📚 Book Exercise - Week 04 C# OOP Constructor Practice

This is a simple C# console application developed as part of a learning exercise to understand how **constructors** work in **Object-Oriented Programming**.

The application simulates a simple `BookClass` that holds basic information about a book using both **parameterless** and **parameterized constructors**.

---

## 🚀 What Does It Do?

- Creates book objects using both:
  - A constructor **without parameters**, which assigns default values (e.g. `"Unknown Title"`)
  - A constructor **with parameters**, where you can provide title, author, and publication year
- Displays book information using a method called `DisplayBookInfo()`
- Helps reinforce key OOP concepts like:
  - Constructors
  - Encapsulation (via public properties)
  - Class usage and object instantiation

---

## 🧱 Class Structure

### `BookClass`

| Property        | Type    | Description              |
|-----------------|---------|--------------------------|
| `Title`         | string  | The name of the book     |
| `Author`        | string  | Author of the book       |
| `YearPublished` | int     | Year of publication      |

### Constructors

```csharp
// Parameterless Constructor
public BookClass()

// Parameterized Constructor
public BookClass(string title, string author, int yearPublished)
```

---

## 📦 Sample Output

```text
Parameterized constructor çalıştı.
Parameterized constructor çalıştı.
Title: 1984
Author: George Orwell
Year Published: 1949
Title: To Kill a Mockingbird
Author: Harper Lee
Year Published: 1960
```

---

## 🖼 Output Example

Below is a sample output when running the program:

![Console Output Screenshot](./screenshot.png)

---

## 🛠 Technologies

- C#
- .NET 8.0 Console App
- Visual Studio 2022 or VS Code

---

## ▶️ How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/BookExercise.git
   ```

2. Open the `.sln` file in Visual Studio or navigate to the project folder and run:
   ```bash
   dotnet run
   ```

---

## ✅ Learning Goal

This exercise is designed to help understand:

- The purpose and use of constructors in C#
- Object creation and property assignment
- Good practices in class design

---


