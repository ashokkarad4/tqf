using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingnmentCondiStatement
{
    class Num3DigitOrNotcs
    {
        static void Main(string[] args)
        {
            int num;
            int firstDigit = 0, lastDigit = 0,sum=0;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            if (num > 99 && num < 1000)
            {
                Console.WriteLine("It is a Three Digit Number.");
                lastDigit = num % 10;
                Console.WriteLine("Last digit: " + lastDigit);
                while (num != 0)
                {
                    firstDigit = num % 10;
                    num /= 10;
                    sum = firstDigit + lastDigit;
                }
                Console.WriteLine("First digit: " + firstDigit);
                Console.WriteLine("Sum = "+sum);
            }
            else
            {
                Console.WriteLine("It is Not a Three Digit Number.");
            }
            }
        }
    } 
