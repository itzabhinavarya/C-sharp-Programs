using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa39
    {
        public static void main(String[] args)
        {
            // Program to print cube of any number
            Console.Write("Enter The Number For Cube : ");
            int num = int.Parse(Console.ReadLine());
            int cube = num * num * num;
            Console.WriteLine("Cube of " + num + " is :" + cube);
            Console.ReadLine();
        }
    }
}
