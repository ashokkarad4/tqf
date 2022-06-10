using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class SearchingCountVariable
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 3, 7, 99, 44, 85, 75, 23 };
            int count = 0;
            Console.WriteLine("Enter Number Which is Present or not");
            int num = Convert.ToInt32(Console.ReadLine());
          
            for(int i=0;i<a.Length;i++)
            {
                if(num==a[i])
                {
                    count = count + 1;
                    break;
                }
            }
            if(count==1)
            {
                Console.WriteLine("Number Is Present");
            }
            else
            {
                Console.WriteLine("Number Is not Present");
            }
        }
    }
}
