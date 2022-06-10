using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test2
{
    class PowerWithoutusingMainMethod
    {
        static void Main(string[] args)
        {
            int b, exponent ;
            int ans=1;
            Console.WriteLine("Enter Base");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Exponent");
            exponent = Convert.ToInt32(Console.ReadLine());

            for (; exponent != 0; --exponent)
            {
                ans =ans* b;
            }
            Console.WriteLine("Answer="+ans);
        }
    }
}
