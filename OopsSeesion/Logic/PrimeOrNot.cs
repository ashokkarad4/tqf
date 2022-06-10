using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Logic
{
    class PrimeOrNot
    {
        static void Main(string[] args)
        {
             int count = 0;
            
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                if (num%i == 0)
                {
                    count++;
                    
                }
            }
          
            if(count==2)
            {
                Console.WriteLine("Prime Number");
            }
            else
                Console.WriteLine("Not Prime Number");
        }
    }
}
