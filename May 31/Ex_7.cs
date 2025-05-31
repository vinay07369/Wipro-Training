using System;

namespace Assignment
{
    class Calculator
    {
        // Add methods
        public static int Add(int a, int b) => a + b;
        public static float Add(float a, float b) => a + b;
        public static double Add(double a, double b) => a + b;

        // Subtract methods
        public static int Subtract(int a, int b) => a - b;
        public static float Subtract(float a, float b) => a - b;
        public static double Subtract(double a, double b) => a - b;

        // Multiply methods
        public static int Multiply(int a, int b) => a * b;
        public static float Multiply(float a, float b) => a * b;
        public static double Multiply(double a, double b) => a * b;
    }

    class CalculatorProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App (supports int, float, double)");
            Console.WriteLine("-------------------------------------------------");

            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            Console.Write("Choose operation (Add/Subtract/Multiply): ");
            string operation = Console.ReadLine();

            // Trying  to parse as int, then float, then double and performing the operations based on the specific type
            if (int.TryParse(input1, out int int1) && int.TryParse(input2, out int int2))
            {
                CallOperation(int1, int2, operation);
            }
            else if (float.TryParse(input1, out float float1) && float.TryParse(input2, out float float2))
            {
                CallOperation(float1, float2, operation);
            }
            else if (double.TryParse(input1, out double double1) && double.TryParse(input2, out double double2))
            {
                CallOperation(double1, double2, operation);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static void CallOperation(int a, int b, string op)
        {
            switch (op.ToLower())
            {
                case "add":
                    Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                    break;

                case "subtract":
                    Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                    break;

                case "multiply":
                    Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                    break;

                default:
                    Console.WriteLine("Unknown operation.");
                    break;
            }
        }

        static void CallOperation(float a, float b, string op)
        {
            switch (op.ToLower())
            {
                case "add":
                    Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                    break;

                case "subtract":
                    Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                    break;

                case "multiply":
                    Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                    break;

                default:
                    Console.WriteLine("Unknown operation.");
                    break;
            }
        }

        static void CallOperation(double a, double b, string op)
        {
            switch (op.ToLower())
            {
                case "add":
                    Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                    break;

                case "subtract":
                    Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                    break;

                case "multiply":
                    Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                    break;

                default:
                    Console.WriteLine("Unknown operation.");
                    break;
            }
        }
    }
}
