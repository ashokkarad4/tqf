using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayTwoD
{
    class PassArrayPrimeOrNot
    {
        public static void checkPrime(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                bool isPrime = true;
                int n = a[i];
                for(int j=2;j<n;j++)
                {
                    if(n%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime==true)
                {
                    Console.WriteLine(a[i]+" Is prime");
                }
            }
        }

        public static bool checkArrayPrime(int n)
        {
            bool isPrime = true;
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime==true)
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
            int[] a = { 6, 7, 8, 4, 3, 9, 5 };
          //  PassArrayPrimeOrNot.checkPrime(a);
            for(int i=0;i<a.Length;i++)
            {
                bool isPrimeCheck = PassArrayPrimeOrNot.checkArrayPrime(a[i]);
                if(isPrimeCheck==true)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

    }
}
