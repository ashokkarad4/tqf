using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Logic
{
    class GCD
    {
        static void Main(string[] args)
        {
           
            int a = 18;
            int b = 12;
            //1,2,3,6
            int count = 0;
            for(int i=1;i<=a && i<=b;i++)
            {
                if(a%i==0 && b%i==0)
                {
                    Console.WriteLine(i);
                    count++;

                }
            }
            Console.WriteLine("Count="+count);
           
        }
    }
}
