using System;

namespace CSharpFunctions
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Max(a, b, c);
            InRange(a, b, c);
            IsPrimal(a, b, c);
        }

        static int Max(int skaicius1, int skaicius2, int skaicius3)
        {
            if(skaicius1 > skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine(skaicius1);
                return skaicius1;
            } else if(skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine(skaicius2);
                return skaicius2;
            }
            else 
            {
                Console.WriteLine(skaicius3);
                return skaicius3;
            }
           



        }


        static bool InRange(int skaicius1, int skaicius2, int skaicius3)
        {
            if(skaicius1 > skaicius2 && skaicius1 < skaicius3)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }


        static bool IsPrimal (int skaicius1,int skaicius2,int skaicius3)
        {
            if(skaicius1 % skaicius1 == 0 || skaicius2 % skaicius2 == 0 || skaicius3 % skaicius3 == 0)
            {
                Console.WriteLine("true");
                return true;
            }

            return false;

        }



    }
}
