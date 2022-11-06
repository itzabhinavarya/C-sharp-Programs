using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa13
    {
        public static void main(String[] args)
        {
            String str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            int prime = num / 2;
            int flag = 0;
            for (int i = 2; i <= prime; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Not A Prime Number");
                    flag += 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Number is Prime");
            }
            Console.ReadLine();

        }
    }
}
