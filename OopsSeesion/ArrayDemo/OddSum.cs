using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class OddSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] odd = { 5, 4, 6, 8, 7, 9, 3 };
            for(int i=0;i<odd.Length;i++)
            {
                if(odd[i]%2!=0)
                {
                    sum = sum + odd[i];
                }
            }
            Console.WriteLine("Odd Sum="+sum);
        }
    }
}
