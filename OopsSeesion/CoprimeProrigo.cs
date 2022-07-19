using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class CoprimeProrigo
    {
         static void isCoprime(int n)
        {
            int gcd = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (n % j == 0 && i % j == 0)
                        gcd = j;
                }

                if (gcd == 1)
                    count++;
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            CoprimeProrigo.isCoprime(4);
        }
    }
}
