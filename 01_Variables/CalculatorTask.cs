using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class CalculatorTask
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            { 
                Console.WriteLine("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an operator (+, -, *, /): ");
                string operation = Console.ReadLine();

                double result = 0;

                if (operation == "+")
                {
                    result = num1 + num2;
                }
                else if (operation == "-")
                {
                    result = num1 - num2;
                }
                else if (operation == "*")
                {
                    result = num1 * num2;
                }
                else if (operation == "/")
                {
                   result = (num1 / num2);
                }
                else
                {
                    Console.WriteLine("Invalid operator. Please try again.");

                    Console.WriteLine($"Result: {result}");

                    Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                    string again = Console.ReadLine().ToLower();
                    if (again == "no")
                    {
                        running = false;
                    }
                }
            }

        }
    }
}
