using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    class aa34
    {
        public static void main(String[] args)
        {
            //Program to perform various arthmetic operations
            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(" 1 : Addition  \t\t2 : Substraction");
                Console.WriteLine(" 3 : Multiplication  \t4 : Division");
                Console.WriteLine(" 5 : Remainder  \t6 : Exit");
                Console.WriteLine("-----------------------------------------");

                Console.Write("Please Enter Your Choice : ");
                int choice = int.Parse(Console.ReadLine());
                int fstNum, secNum;
                void input()
                {
                    Console.Write("Enter Your First Number : ");
                    fstNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter Your Second Number : ");
                    secNum = int.Parse(Console.ReadLine());
                }

                int res = 0;

                switch (choice)
                {

                    case 1:
                        input();
                        res = fstNum + secNum;
                        Console.WriteLine("Addition Of Both Numbers Are : " + res);
                        break;
                    case 2:
                        input();
                        res = fstNum - secNum;
                        Console.WriteLine("Substraction Of Both Numbers Are : " + res);
                        break;
                    case 3:
                        input();
                        res = fstNum * secNum;
                        Console.WriteLine("Multiplication Of Both Numbers Are : " + res);
                        break;
                    case 4:
                        input();
                        res = fstNum / secNum;
                        Console.WriteLine("Division Of Both Numbers Are : " + res);
                        break;
                    case 5:
                        input();
                        res = fstNum % secNum;
                        Console.WriteLine("Remainder Of Both Numbers Are : " + res);
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice .......Try Again");
                        break;
                }
                Console.ReadLine();
                break;
            }
        }
    }
}
