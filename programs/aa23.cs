using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa23
    {
        public static void main(String[] args)
        {
            //Program to convert all strings to UPPERCASE
            Console.Write("Enter Your String : ");
            String str = Console.ReadLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("After Converting in UPPERCASE ");
            Console.WriteLine();
            Console.WriteLine(str.ToUpperInvariant());
            Console.ReadLine();
        }
    }
}
