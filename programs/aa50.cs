using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa50
    {
        public static void main(String[] args)
        {
            // Program to Print The Detais of the Person
            Console.WriteLine("----------Enter Your Details----------");
            Console.Write("\n Enter Your Name : ");
            String name = Console.ReadLine();
            Console.Write("\n Enter Your Email : ");
            String email = Console.ReadLine();
            Console.Write("\n Enter Your Phone Number : ");
            String phone = Console.ReadLine();
            Console.Write("\n Enter Your City : ");
            String city = Console.ReadLine();


            Console.WriteLine("\n\n------------------------------");
            Console.WriteLine("\nYour Name is " + name);
            Console.WriteLine("\nYour Email is " + email);
            Console.WriteLine("\nYour Phone number is " + phone);
            Console.WriteLine("\nYour City is " + city);
            Console.WriteLine("------------------------------");

            Console.ReadLine();

        }
    }
}
