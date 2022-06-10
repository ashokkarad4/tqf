using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test3
{
    class SeperateZerosQue6
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 0, 7, 0, 8, 0, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    for (int j = i; j < a.Length; j++)
                    {
                        if (a[j] > 0)
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
                Console.Write(a[i] + " ");
            }
        }
    }
}
