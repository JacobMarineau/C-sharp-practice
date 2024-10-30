using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

Console.WriteLine("Hello, World!");

// Primitive Data Types: int, float, double, decimal, bool, char, and string.
// User-defined types: class, struct, enum.
// Reference Types: object, dynamic, string.

// Collections/Lists/Arrays:

int[] numbers = { 1, 2, 3 };
List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

//Functions:

static int Add(int a, int b)
{
    return a + b;
}

// HTTP API Development:

// ASP.NET Core is the primary framework for creating HTTP APIs. For smaller projects, Minimal APIs in .NET 6+ can simplify REST API creation without a full MVC setup.
// Database Connection:

// Entity Framework Core (EF Core) is the ORM for .NET, providing a straightforward way to work with databases.
// Other popular options include Dapper for a lightweight ORM approach.
// JSON Serialization:

// System.Text.Json and Newtonsoft.Json are popular for JSON handling in C#.

// Serialization example:
// csharp

using System.Text.Json;

var jsonString = JsonSerializer.Serialize(myObject);
var myObject = JsonSerializer.Deserialize<MyClass>(jsonString);