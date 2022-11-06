using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa42
    {
        public static void main(String[] args)
        {
            // Program to print area of reactangle
            Console.Write("Enter The Length : ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Enter The Breadth : ");
            int b = int.Parse(Console.ReadLine());
            Double area = l * b;
            Console.WriteLine("Area of Rectangle is : " + area);
            Console.ReadLine();
        }
    }
}
