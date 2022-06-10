using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test2
{
    class MobileNoFreq
    {
        static void Main(string[] args)
        {
            long number,temp,digit;
            Console.WriteLine("Enter Number");
            number =long.Parse(Console.ReadLine());
            temp = number;
            for(int i=1;i<=10;i++)
            {
                int count = 0;
              
                temp = number;
                while (temp > 0)
                {
                    digit = temp % 10;
                    if (digit == i)
                    {
                        count++;
                    }
                    temp = temp / 10;
                }
                if (count > 0)
                {
                    Console.WriteLine(i + "\t" + count);
                }
            }
        }
    }
}
