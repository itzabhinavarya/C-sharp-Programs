using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa40
    {
        public static void main(String[] args)
        {
            // Program to print area of circle
            Console.Write("Enter The Radius of the Circle : ");
            int rad = int.Parse(Console.ReadLine());
            Double area = 3.1415 * rad * rad;
            Console.WriteLine("Area of the circle is : "+ rad);
            Console.ReadLine();
        }
    }
}
