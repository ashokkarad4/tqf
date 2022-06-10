using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class DigitCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();
            Console.WriteLine(str) ;
            int count = 0;
            int sum = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='0'&&str[i]<='9')
                {
                    sum = sum + str[i] - '0';
                    count++;
                }
            }
            Console.WriteLine("Number of digits="+count);
            Console.WriteLine("Sum ="+sum);
        }
    }
}
