using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa27
    {
        public static void main(String[] args)
        {
            // Program to print table of the given number
            Console.Write("Enter the number to print the table : ");
            int num = int.Parse(Console.ReadLine());
            int table = 0;
            for (int i = 1; i <= 10; i++)
            {
                table = num * i;
                Console.WriteLine(table);
            }
            Console.ReadLine();
        }
    }
}
