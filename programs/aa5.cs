using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa5
    {
        public static void main(String[] args)
        {
            // Program to perform Multiplication of two numbers through user end
            Console.Write("Enter First Number : ");
            String a = Console.ReadLine();
            Console.Write("Enter Second Number : ");
            String b = Console.ReadLine();
            int num = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            int mul = num * num2;
            Console.WriteLine("Multiplication Of Both Numbers Are : " + mul);
            Console.ReadLine();
        }
    }
}
