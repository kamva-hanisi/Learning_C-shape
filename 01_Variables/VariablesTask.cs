using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vairables
{
    internal class VariablesTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();


            Console.WriteLine("Please Enter first mark: ");
            int firstMark = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Sec mark: ");
            int SecMark = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter third mark: ");
            int thirdMark = Convert.ToInt32(Console.ReadLine());

            double average = (firstMark + SecMark + thirdMark) / 3.0;

            string grade;

            if (average >= 90)
            {
                grade = "A";
            }
            else if (average >= 80)
            {
                grade = "B";
            }
            else if (average >= 70)
            {
                grade = "C";
            }
            else if (average >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";

            }

            Console.WriteLine();
            Console.WriteLine($"Student: {name}");
            Console.WriteLine($"Marks: {firstMark}, {SecMark}, {thirdMark}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Grade: {grade}");


        }
    }
}
