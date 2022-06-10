using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentLooping
{
    class Power
    {
        static void Main(string[] args)
        {

           
                Console.WriteLine("Enter Base");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Exponent");
                int expo = Convert.ToInt32(Console.ReadLine());

                int power = 0;
                int i = 1;
                while (i <= expo)
                {
                    power = power * num;
                    i++;
               
                }
                Console.WriteLine(power);
            
        }
    }
}
