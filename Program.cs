using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{

    // Define a static class for extension methods
    public static class MyExtensions
    {
        // Define the extension method
        public static int Square(this int number)
        {
            return number * number;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Hello, World!
            Console.WriteLine("Task 1: Hello, World!");
            Console.WriteLine("Hello, World!");

            // Task 2: Variables and User Input
            Console.WriteLine("\nTask 2: Variables and User Input");
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");

            // Task 3: Basic Arithmetic
            Console.WriteLine("\nTask 3: Basic Arithmetic");
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum: {num1 + num2}");
            Console.WriteLine($"Difference: {num1 - num2}");
            Console.WriteLine($"Product: {num1 * num2}");

            if (num2 != 0)
                Console.WriteLine($"Division: {num1 / (double)num2}");
            else
                Console.WriteLine("Cannot divide by zero!");

            Console.WriteLine($"Modulus: {num1 % num2}");

            // Task 4: Control Structures
            Console.WriteLine("\nTask 4: Control Structures");
            Console.Write("Enter an integer to check if it's even or odd: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber % 2 == 0)
                Console.WriteLine($"{userNumber} is even.");
            else
                Console.WriteLine($"{userNumber} is odd.");

            // Task 5: Loops
            Console.WriteLine("\nTask 5: Loops");
            Console.WriteLine("Numbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // Task 6: Arrays
            Console.WriteLine("\nTask 6: Arrays");
            int[] numbersArray = { 5, 10, 15, 20, 25 };
            int sum = 0;

            foreach (int num in numbersArray)
            {
                sum += num;
            }

            double average = (double)sum / numbersArray.Length;
            Console.WriteLine($"Sum: {sum}, Average: {average}");

            // Task 7: Methods
            Console.WriteLine("\nTask 7: Methods");
            Console.Write("Enter a positive integer to calculate its factorial: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {inputNumber}: {CalculateFactorial(inputNumber)}");

            // Task 8: Exception Handling
            Console.WriteLine("\nTask 8: Exception Handling");
            int age;

            while (true)
            {
                Console.Write("Enter your age: ");

                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            if (age < 18)
                Console.WriteLine("You are a minor.");
            else if (age >= 18 && age <= 65)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are a senior.");

            // Extension Method Example
            Console.WriteLine("\nExtension Method Example");
            int myNumber = 5;
            int squaredNumber = myNumber.Square();
            Console.WriteLine($"Square of {myNumber}: {squaredNumber}");

            Console.ReadLine(); // to keep the console window open
        }

        // Task 7: Methods
        static int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }
    }
}
