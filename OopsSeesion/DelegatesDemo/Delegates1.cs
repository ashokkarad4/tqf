using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.DelegatesDemo
{
    class Delegates1
    {
        static void add(int a, int b)
        {
            Console.WriteLine("Sum=" + (a + b));
        }


        static int factorial(int n)
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        static bool isEven(int num)
        {
            if(num%2==0)
            {
               return true;
            }
            else
            {
               return false;
            }
        }
        static void Main(string[] args)
        {
            Action<int, int> a1 = add;
            a1(10, 20);

            Func<int, int> a2 = factorial;
            int result = a2(5);
            Console.WriteLine(" "+result);

            Predicate<int> a3 = isEven;
            bool isResult=a3(6);
            Console.WriteLine( " "+isResult);
        }
    }
}
