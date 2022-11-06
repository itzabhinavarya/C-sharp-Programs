using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa3
    {
        public static void main(String[] args)
        {
            // Program to Add two numbers from user side 
            Console.Write("Enter First Number : ");
            String a = Console.ReadLine();
            Console.Write("Enter Second Number : ");
            String b = Console.ReadLine();
            int num = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            int add = num + num2;
            Console.WriteLine("Addition Of Both Numbers Are : " + add);
            Console.ReadLine();

        }
    }
}
