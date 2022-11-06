using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa14
    {
        public static void main(String[] args)
        {
            // Factorial Program
            Console.Write("Enter The Number To Find Factorial : ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of number is  : " + fact);
            Console.ReadKey();
        }
    }
}
