using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa49
    {
        public static void main(String[] args)
        {
            // Program to Show Grade of the student Based on their marks

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
            double per = 0;
            total = num1 + num2 + num3 + num4 + num5;
            average = total / 5;
            per = (total / 500) * 100;


            Console.WriteLine("\n\n----------------------------------");
            Console.WriteLine("You Got : " + per + "%");
            Console.WriteLine("----------------------------------");
            if (per > 95)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("You Are A Tooper Student");
                Console.WriteLine("----------------------------------");
            }
            else if (per >= 60 && per <= 95)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("You Got First Division");
                Console.WriteLine("----------------------------------");
            }
            else if (per > 30 && per < 60)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("You Got Second Position");
                Console.WriteLine("----------------------------------");
            }
            else if (per >= 15 && per <= 30)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("You Got Third Position");
                Console.WriteLine("----------------------------------");
            }
            else
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Opppss...!!! You Failed....");
                Console.WriteLine("----------------------------------");
            }
            Console.ReadLine();
        }
    }
}
