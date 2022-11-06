using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa46
    {
        public static void main(String[] args)
        {
            // Program to input the array and display the inputed array
            Console.Write("Enter Your Array : ");
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\n-------------------------------------");
            Console.WriteLine("Your Inputed Arrays Are : ");
            Console.WriteLine("-------------------------------------\n\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
