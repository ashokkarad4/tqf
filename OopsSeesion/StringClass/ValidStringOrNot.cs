using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class ValidStringOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
          
            int sumfirst = 0;
            int sumlast = 0;

            for (int i = 0; i < 3; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {

                    int a = int.Parse(str[i].ToString());

                    sumfirst = sumfirst + a;
                }
            }
            for (int i = str.Length - 1; i > str.Length - 4; i--)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    int b = int.Parse(str[i].ToString());
                    sumlast = sumlast + b;
                }
            }
            Console.WriteLine("First 3 Digit Sum="+sumfirst);
            Console.WriteLine("Last 3 Digit Sum="+sumlast);
            if (sumfirst == sumlast)
            {
                Console.WriteLine("String is a valid String");
            }
            else
            {
                Console.WriteLine("String is not a valid string");
            }

      






        }
    }
}
    
