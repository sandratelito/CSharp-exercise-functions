using System;

namespace CSharpFunctions
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            IsPrimal(7);

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
