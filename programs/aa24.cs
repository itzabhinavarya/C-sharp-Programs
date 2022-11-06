using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa24
    {
        public static void main(String[] args)
        {
            //Program to convert all strings to lowercase
            Console.Write("Enter Your String : ");
            String str = Console.ReadLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("After Converting in lowercase ");
            Console.WriteLine();
            Console.WriteLine(str.ToLowerInvariant());
            Console.ReadLine();
        }
    }
}
