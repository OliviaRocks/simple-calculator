using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator ");
        Console.WriteLine("------------------");

        Console.WriteLine("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Enter an operator (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();

        double result = 0;

        switch (op)
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
                    Console.WriteLine("Error: Division by zero is not allowed");
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator");
                return;
        }

        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
}