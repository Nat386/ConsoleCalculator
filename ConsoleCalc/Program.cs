using System;
using System.Text;

class Calculator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Calculator:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Please choose operation (1/2/3/4/5): ");


            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Please choose your first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please choose your second number: ");
                int secondNumber = int.Parse(Console.ReadLine());
                var result = firstNumber + secondNumber;
                Console.WriteLine("Your result is " + result);
            }
            if (num == 2)
            {
                Console.WriteLine("Please choose your first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please choose your second number: ");
                int secondNumber = int.Parse(Console.ReadLine());
                var result = firstNumber - secondNumber;
                Console.WriteLine("Your result is " + result);
                    }
            if (num == 3)
            {
                Console.WriteLine("Please choose your first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please choose your second number: ");
                int secondNumber = int.Parse(Console.ReadLine());
                var result = firstNumber * secondNumber;
                Console.WriteLine("Your result is " + result);
            }
            if (num == 4)
            {
                Console.WriteLine("Please choose your first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please choose your second number: ");
                int secondNumber = int.Parse(Console.ReadLine());
                var result = firstNumber / secondNumber;
                Console.WriteLine("Your result is " + result);
            }
            if (num == 5)
            {
                Console.WriteLine("Thank you for using Calculator! Goodbye!");
            }
            break;
        }
    }
}






