using System.Globalization;

namespace _02_Operators
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());


            double result = 0;

            if (operation == '+')
            { 
               result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                result = (num1 / num2);
            }
            
            if (num2 == 0 && operation == '/')
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine($"Result: {result}");
            }

            Console.ReadLine();


        }
    }
}
