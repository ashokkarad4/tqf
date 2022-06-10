using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test2
{
    class HighestNumber
    {
        static void Main(string[] args)
        {
            int num1, num2,num3;
            Console.WriteLine("Enter Num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                if(num2>num3)
                {
                    Console.WriteLine("Second Largest Number"+num2);
                }
                else
                {
                    Console.WriteLine("Second Largest number"+num3);
                }
                Console.WriteLine( num1+"Is First Largest Number");
            }
            else if (num2 > num1 && num2 > num3)
            {
                if(num1>num3)
                {
                    Console.WriteLine("second largest number"+num1);
                }
                else
                {
                    Console.WriteLine("second largest number"+num3);
                }
                Console.WriteLine("First Largest Number"+num2);
            }
            else if(num1>num2)
            {
                Console.WriteLine("Second Largest Number"+num1);
            }
            else
            {
                Console.WriteLine("second Largest Number"+num2);
                Console.WriteLine("first largest number"+num3);
            }

        }
    }
}
