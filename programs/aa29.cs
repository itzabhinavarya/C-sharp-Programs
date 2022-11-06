using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa29
    {
        public static void main(String[] args)
        {
            // Program to check wether a number is palindrome or not
            Console.WriteLine("Enter The Number To Check For Palindrome : ");
            int num = int.Parse(Console.ReadLine());
            int palin = num;
            int temp, rem=0;
            temp = num % 10;
            rem = (rem * 10) + temp;
            num = num / 10;
            if (rem == palin)
            {
                Console.WriteLine("Number is Plaindrome");
            }
            else
            {
                Console.WriteLine("Number is Not a Palindrome Number");
            }
            Console.ReadLine();
        }
    }
}
