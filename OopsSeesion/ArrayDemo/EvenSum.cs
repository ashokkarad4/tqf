using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class EvenSum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter Array Size");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[num];
            Console.WriteLine("Enter Array Elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("Even Sum="+sum);
        }
    }
}
