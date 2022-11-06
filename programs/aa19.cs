using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa19
    {
        public static void main(String[] args)
        {
            //To check wether the number is negative or positive
            Console.Write("Enter Your Number : ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine(num + " is a positive number");
            }
            else if (num == 0)
            {
                Console.WriteLine(num + " is a Zero Number");
            }
            else
            {
                Console.WriteLine(num + " is a Negative Number");
            }
            Console.ReadLine();
        }
    }
}
