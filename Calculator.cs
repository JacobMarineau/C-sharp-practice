using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Console Calculator!");

        Console.WriteLine("Supported operations: +, -, *, /, ^ (exponent), √ (square root)");

        // Input: Getting numbers and the operation from the user
        Console.Write("Enter the first number: ");
        double num1 = GetValidNumber();

        Console.Write("Enter an operator (+, -, *, /, ^, √): ");
        char operation = GetValidOperator();

        double result;

        if (operation == '√')
        {
            // Perform square root operation
            result = PerformSquareRoot(num1);
            Console.WriteLine($"Result: √{num1} = {result}");
        }
        else
        {
            // Perform regular operation
            Console.Write("Enter the second number: ");
            double num2 = GetValidNumber();
            result = PerformOperation(num1, num2, operation);
            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
        }

        Console.WriteLine("Thank you for using the calculator!");
    }

    // Function to perform the operation
    static double PerformOperation(double num1, double num2, char operation)
    {
        double result = 0;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            case '^':
                result = Math.Pow(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
        return result;
    }

    // Function to perform square root
    static double PerformSquareRoot(double num)
    {
        if (num >= 0)
        {
            return Math.Sqrt(num);
        }
        else
        {
            Console.WriteLine("Error: Cannot calculate square root of a negative number.");
            return 0;
        }
    }

    // Helper function to validate and return a number
    static double GetValidNumber()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        return number;
    }

    // Helper function to validate the operator
    static char GetValidOperator()
    {
        char op;
        while (!char.TryParse(Console.ReadLine(), out op) || !"*/+-^√".Contains(op))
        {
            Console.WriteLine("Invalid operator. Please enter one of the following: +, -, *, /, ^, √");
        }
        return op;
    }
}
