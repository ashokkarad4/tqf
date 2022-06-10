using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class Replace0To1
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 0, 8, 0, 4, 0 ,7};
            Console.WriteLine(String.Join(" ",a));
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                    a[i] = 1;
            }
            Console.WriteLine("Replace 0 by 1");
            Console.WriteLine(String.Join(" ",a));
        }


    }
}
