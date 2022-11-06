using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa7
    {
        public static void main(String[] args)
        {
            // Program to perform Modulo/Modulous of two numbers

            Console.Write("Enter First Number : ");
            String a = Console.ReadLine();
            Console.Write("Enter Second Number : ");
            String b = Console.ReadLine();
            int num = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            int mod = num % num2;
            Console.WriteLine("Modulous Of Both Numbers Are : " + mod);
            Console.ReadLine();
        }
    }
}
