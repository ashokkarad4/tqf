using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class MinFrequencyQe3
    {
        static void Main(string[] args)
        {
            char[] arr  = {'a','b','b','c','c','d'};
            char min = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(min>arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min Is "+min);
        }
    }
}
