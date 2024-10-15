using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the simple calculator!");

            // Get the first number
            Console.Write("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            // Get the second number
            Console.Write("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            // Choose an operation
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");

            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    break;
                case 4:
                    // Check for division by zero
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            // Display the result
            Console.WriteLine("The result is: " + result);
        }
    }
}