using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentLooping
{
    class Table
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                int table = num * i;
                Console.WriteLine(table);
            }
        }
    }
}
