using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa41
    {
        public static void main(String[] args)
        {
            // Program to print perimeter of reactangle
            Console.Write("Enter The Length : ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Enter The Breadth : ");
            int b = int.Parse(Console.ReadLine());
            Double perimeter = 2 * (l + b);
            Console.WriteLine("Perimeter of Rectangle is : " + perimeter);
            Console.ReadLine();
        }
    }
}
