using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Logic
{
    class AirthmaticPrigression
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2nd Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int different = 4;
            int nth = 7;
            int first = num1 - different;
            int AP = first + (nth - 1) * 4;
            Console.WriteLine(AP);
        }
    }
}
