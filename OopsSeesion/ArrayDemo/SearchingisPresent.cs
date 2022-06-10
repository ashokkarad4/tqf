using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class SearchingisPresent
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 7, 2, 9 };
            Console.WriteLine("Enter Element for searching");
            int num = Convert.ToInt32(Console.ReadLine());
             bool isPresent = false;
           
            for(int i=0;i<a.Length;i++)
            {
                if(num==a[i])
                {

                    isPresent = true;
                    break;
                }
            }
            if(isPresent==true)
            {
                Console.WriteLine("Number Is Present");
            }
            else
                Console.WriteLine("Number is not Present");
        }
    }
}
