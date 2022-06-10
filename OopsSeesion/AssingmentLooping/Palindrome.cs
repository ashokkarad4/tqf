using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentLooping
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            //1221
            int num, rem, sum = 0, temp;
            Console.Write(" Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                sum = sum * 10 + rem;
            }
            if (temp == sum)
            {
                Console.WriteLine("\n Number is Palindrome \n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n");
            }
        }
    }
}
