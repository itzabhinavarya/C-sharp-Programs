using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa8
    {
        public static void main(String[] args)
        {
            // Program to get average of two numbers

            Console.Write("Enter First Number : ");
            String a = Console.ReadLine();
            Console.Write("Enter Second Number : ");
            String b = Console.ReadLine();
            int num = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            int ave = (num + num2)/2;
            Console.WriteLine("Average Of Both Numbers Are : " + ave);
            Console.ReadLine();
        }
    }
}
