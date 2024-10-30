using System;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public double PerformOperation(double num1, double num2, char operation)
        {
            return operation switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Division by zero is not allowed."),
                '^' => Math.Pow(num1, num2),
                _ => throw new InvalidOperationException("Invalid operation.")
            };
        }

        public double PerformSquareRoot(double num)
        {
            return num >= 0 ? Math.Sqrt(num) : throw new ArgumentException("Cannot calculate square root of a negative number.");
        }
    }
}

// using System;

// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, World!");
//         }
//     }
// }

// Console.WriteLine("Hello, World!");

// Primitive Data Types: int, float, double, decimal, bool, char, and string.
// User-defined types: class, struct, enum.
// Reference Types: object, dynamic, string.

// Collections/Lists/Arrays:

// int[] numbers = { 1, 2, 3 };
// List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

//Functions:

// static int Add(int a, int b)
// {
//     return a + b;
// }

// HTTP API Development:

// ASP.NET Core is the primary framework for creating HTTP APIs. For smaller projects, Minimal APIs in .NET 6+ can simplify REST API creation without a full MVC setup.
// Database Connection:

// Entity Framework Core (EF Core) is the ORM for .NET, providing a straightforward way to work with databases.
// Other popular options include Dapper for a lightweight ORM approach.
// JSON Serialization:

// System.Text.Json and Newtonsoft.Json are popular for JSON handling in C#.

// Serialization example:
// csharp

// using System.Text.Json;

// var jsonString = JsonSerializer.Serialize(myObject);
// var myObject = JsonSerializer.Deserialize<MyClass>(jsonString);
