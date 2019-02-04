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
            IsPrimal(7);

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


        static bool IsPrimal(int sk1)
        {
            for (int i = 2; i < sk1; i++)
            {
                if (sk1 % i == 0)
                {
                    Console.WriteLine("Is Not Primal");
                    return false;
                }
            }
            Console.WriteLine("Is Primal");
            return true;
        }


    }

}
