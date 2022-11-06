using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa12
    {
        public static void main(String[] args)
        {
            String str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            if (num % 2 == 0)
            {
                Console.WriteLine("it's an Even number");
            }
            else
            {
                Console.WriteLine("its an odd number");
            }

            Console.ReadKey();
        }
    }
}
