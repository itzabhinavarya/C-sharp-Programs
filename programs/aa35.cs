﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa35
    {
        public static void main(String[] args)
        {
            // Program to display the greater number between two numbers
            Console.Write("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("First Number is Greater");
            }
            else if(num2>num1)
            {
                Console.WriteLine("Second Number is Greater");
            }
            else
            {
                Console.WriteLine("Equal Number");
            }
            Console.ReadLine();
        }
    }
}
