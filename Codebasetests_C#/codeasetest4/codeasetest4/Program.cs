using System;

namespace CalculatorApp
{
    delegate int CalDelegate(int n1, int n2);
    // Write a console program that uses delegates to call Calculator Functionalities like
    // 1. Addition, 2. Subtraction and 3. Multiplication by taking 2 integers and returns the answer to the user.
    // You should display the return values accordingly.

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Invalid");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                if (choice == 4)
                {
                    Console.WriteLine("QUIT");
                    break;
                }

                if (choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid option. Please select a valid operation.");
                    continue;
                }

                Console.Write("Enter the first number: ");
                int n1;
                if (!int.TryParse(Console.ReadLine(), out n1))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                Console.Write("Enter the second number: ");
                int n2;
                if (!int.TryParse(Console.ReadLine(), out n2))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                CalDelegate calculatorDelegate = null;

                switch (choice)
                {
                    case 1:
                        calculatorDelegate = Addition;
                        break;
                    case 2:
                        calculatorDelegate = Subtraction;
                        break;
                    case 3:
                        calculatorDelegate = Multiplication;
                        break;
                }

                if (calculatorDelegate != null)
                {
                    int result = calculatorDelegate(n1, n2);
                    Console.WriteLine($"Result: {result}");
                }
            }
        }

        static int Addition(int n1, int n2)
        {
            return n1 + n2;
        }

        static int Subtraction(int n1, int n2)
        {
            return n1 - n2;
        }

        static int Multiplication(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}