using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa37
    {
        public static void main(String[] args)
        {
            // Program to display the greater number between three numbers
            Console.Write("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("First Number is Greater");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Second Number is Greater");
            }
            else if(num3 > num1 && num3 > num2)
            {
                Console.WriteLine("Third Number is Greater");
            }
            else
            {
                Console.WriteLine("All Are Equals");
            }
            Console.ReadLine();
        }
    }
}
