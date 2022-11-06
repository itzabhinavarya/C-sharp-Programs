using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa6
    {
        public static void main(String[] args)
        {
            // Program to perform Division of two numbers

            Console.Write("Enter First Number : ");
            String a = Console.ReadLine();
            Console.Write("Enter Second Number : ");
            String b = Console.ReadLine();
            int num = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            int div = num / num2;
            Console.WriteLine("Division Of Both Numbers Are : " + div);
            Console.ReadLine();
        }
    }
}
