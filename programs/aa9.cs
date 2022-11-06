using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa9
    {
        public static void main(String[] args)
        {
            // Program to get average of five numbers

            Console.Write("Enter First Number : ");
            String a = Console.ReadLine();
            Console.Write("Enter Second Number : ");
            String b = Console.ReadLine();
            Console.Write("Enter Third Number : ");
            String c = Console.ReadLine();
            Console.Write("Enter Fourth Number : ");
            String d = Console.ReadLine();
            Console.Write("Enter Fivth Number : ");
            String e = Console.ReadLine();
            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            int num3 = Convert.ToInt32(c);
            int num4 = Convert.ToInt32(d);
            int num5 = Convert.ToInt32(e);
            int ave = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.WriteLine("Average Of Five Numbers Are : " + ave);
            Console.ReadLine();
        }
    }
}
