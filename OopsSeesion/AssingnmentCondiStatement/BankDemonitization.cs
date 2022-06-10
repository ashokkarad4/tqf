using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingnmentCondiStatement
{
    class BankDemonitization
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount");
            int amt = int.Parse(Console.ReadLine());
            if(amt==0)
            {
                Console.WriteLine("Invalid Amount");
            }
            else
            {
                int[] a = { 2000, 500, 100, 50, 20, 10, 5, 2, 1 };
                int i, p, r, b, t;

                p = amt;
                for (i = 0; i < a.Length; i++)
                {
                    t = amt / a[i];
                    if (t != 0)
                    {
                        Console.WriteLine(a[i] + "X" + t + "=" + (t * a[i]));
                        amt = amt % a[i];
                    }
                }

               
                r = 0;
                while (p > 0)
                {
                    r = r * 10 + p % 10;
                    p /= 10;
                }

                while (r > 0)
                {
                    b = r % 10;
                    r /= 10;
                }
            }
        }
        }
    }

