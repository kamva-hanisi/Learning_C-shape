using System.Globalization;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your height: ");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Hello, I am {name}, {age} years old, and I'm {height} meters tall.");

            Console.ReadLine();
        }
    }
}
