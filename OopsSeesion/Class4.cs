using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class Class4
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter Index");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            if (num < a.Length - 1)
            {
                Console.WriteLine(a[num + 1]);
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            }
           }
        }
    }

