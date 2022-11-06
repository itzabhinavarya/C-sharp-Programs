using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa18
    {
        public static void main(String[] args)
        {
            // Print number from Specific number to Specific number
            Console.Write("Enter Starting Position : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter Ending Position : ");
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
