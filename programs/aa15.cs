using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa15
    {
        public static void main(String[] args)
        {
            // Program to swaping two numbers
            int a = 5;
            int b = 6;
            int c = 0;
            Console.WriteLine("-------Before Swaping-------");
            Console.WriteLine("A = " + a + " And B = " + b);
            Console.ReadLine();

            c = a;
            a = b;
            b = c;


            Console.WriteLine("-------After Swaping---------");
            Console.WriteLine("A = " + a + " And B = " + b);
            Console.ReadLine();

        }

    }
}
