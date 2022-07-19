using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Practice
{
    class Searchinginarray
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 2, 6, 4, 34, 78, 5, 46, 95, 12 };
            Console.WriteLine("Enter Number which is find");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(num==a[i])
                {
                    count++;
                    break;
                }
            }
            if(count==1)
            {
                Console.WriteLine("Number is present");
            }
            else
            {
                Console.WriteLine("Number is not present");
            }
        }
    }
}
