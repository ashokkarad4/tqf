using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            //371
            int num, sum = 0, temp;
            Console.WriteLine("Enter The number");
            num = Convert.ToInt32(Console.ReadLine());

            while(num!=0)
            {
                temp = num % 10;
                sum = sum + temp * temp * temp;
                num /= 10;
            }
            if (sum == num)
            {
                Console.WriteLine("It is an armstrong number");
            }
            else
            {
                Console.WriteLine("It is Not Armstrong Number");
            }
        }
    }
    
}
