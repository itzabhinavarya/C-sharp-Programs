using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa45
    {
        public static void main(String[] args)
        {
            //Program to check wether the Entered Character is vowel or Consonent
            Console.Write("Enter Your Character : ");
            char ch = Console.ReadKey().KeyChar;
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("\n\nCharacter is Vowel");
            }
            else
            {
                Console.WriteLine("\n\nCharacter is Consonent");
            }
            Console.ReadLine();
        }
    }
}
