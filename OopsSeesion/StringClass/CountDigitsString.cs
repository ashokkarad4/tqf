using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class CountDigitsString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str = "";
            str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= '0')&& (str[i]<='9'))
                {
                    count++;
                }
            }
            Console.WriteLine("Number of Digits in the string: " + count);
        }
    }
}
