using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa30
    {
        public static void main(String[] args)
        {
            // Program to convert digit number to the String format/word
            Console.Write("Enter Number  : ");
            int num = int.Parse(Console.ReadLine());
            int rem = 0, sum = 0;

            while (num != 0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;
            }
            while (sum != 0)
            {
                rem = sum % 10;
                switch (rem)
                {
                    case 0:
                        Console.Write("ZERO ");
                        break;
                    case 1:
                        Console.Write("ONE ");
                        break;
                    case 2:
                        Console.Write("TWO ");
                        break;
                    case 3:
                        Console.Write("THREE ");
                        break;
                    case 4:
                        Console.Write("FOUR ");
                        break;
                    case 5:
                        Console.Write("FIVE ");
                        break;
                    case 6:
                        Console.Write("SIX ");
                        break;
                    case 7:
                        Console.Write("SEVEN ");
                        break;
                    case 8:
                        Console.Write("EIGHT ");
                        break;
                    case 9:
                        Console.Write("NINE ");
                        break;
                    default:
                        Console.WriteLine("Invalid Number ...... Try Again!!");
                        break;
                }
                sum = sum / 10;
            }

            Console.ReadLine();
        }
    }
}
