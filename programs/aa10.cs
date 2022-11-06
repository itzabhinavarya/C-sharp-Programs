using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa10
    {
        public static void main(String[] args)
        {
            // Program to get percentage of five subjects

            Console.Write("Enter First Subject : ");
            double num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Subject : ");
            double num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third Subject : ");
            double num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter Fourth Subject : ");
            double num4 = int.Parse(Console.ReadLine());
            Console.Write("Enter Fivth Subject : ");
            double num5 = int.Parse(Console.ReadLine());
            double total = 0;
            double average = 0;
            double percentage = 0;
            total = num1 + num2 + num3 + num4 + num5;
            average = total / 5;
            percentage = (total / 500) * 100;
            Console.WriteLine("You Got : " + percentage + "%");
            Console.ReadLine();
        }
    }
}
