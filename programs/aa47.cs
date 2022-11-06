using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa47
    {
        public static void main(String[] args)
        {
            // Exception Handling Program For Division of two Numbers
            try
            {

                Console.WriteLine("--------Fully Robust Program To Perform Division-------");
                Console.Write("\n\nEnter The First Number : ");
                Double num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter The Second Number : ");
                Double num2 = int.Parse(Console.ReadLine());

                if (num1 > 0 && num2 == 0)
                {
                    Console.WriteLine("\n\nCan't Divisible By Zero....(Infinte Case)");
                }
                else
                {
                    Double division = num1 / num2;
                    Console.WriteLine("\n\nYour Result is " + division);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error Occured..... Verify Your Input...!!!");
                Console.WriteLine(err.Message);
            }
            Console.ReadLine();
        }
    }
}
