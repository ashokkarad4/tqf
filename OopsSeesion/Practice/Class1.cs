using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Practice
{
   
    
   
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int rev = 0;
            while(num>0)
            {
                int rem = num % 10;
                 rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(rev);

        }
       
    }
}
