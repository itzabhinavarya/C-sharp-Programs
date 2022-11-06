using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa48
    {
        public static void main(String[] args)
        {
            // Program to input the array and display the Sum of the array
            Double[] num = new Double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter " + i + " Index Element : ");
                num[i] = Double.Parse(Console.ReadLine());
            }
            Double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("\n\n--------------------------");
            Console.WriteLine("Sum Of Array is : " + sum);
            Console.WriteLine("------------------------------");
            Console.ReadLine();
        }
    }
}
