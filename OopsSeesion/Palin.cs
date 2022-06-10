using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class Palin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp = num;
            while(num>0)
            {
                int rem = num % 10;
                num = num / 10;
                rev = rev * 10 + rem;
            }
            Console.WriteLine(rev);
            if(temp==rev)
            {
                Console.WriteLine("Palinde");
            }
            else
                Console.WriteLine("Not");
        }
    }
}
