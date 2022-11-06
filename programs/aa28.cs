using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa28
    {
        public static void main(String[] args)
        {
            // Program to print table in 2 * 1 = 2 <-this format 
            Console.WriteLine("Enter your number to print table : ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                int table = num * i;
                Console.WriteLine(num + " * " + i + " = " + table);
            }
            Console.ReadLine();
        }
    }
}
