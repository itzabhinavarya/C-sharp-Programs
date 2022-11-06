using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa44
    {
        public static void main(String[] args)
        {
            //Program to print fibonacci series
            int a = 0, b = 1;
            Console.Write("Enter The Number Of Finonacci Element : ");
            int limit = int.Parse(Console.ReadLine());
            Console.Write(a + " ");
            Console.Write(b + " ");
            for (int i = 2; i < limit; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}