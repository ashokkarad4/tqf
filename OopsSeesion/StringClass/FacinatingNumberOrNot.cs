using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class FacinatingNumberOrNot
    {
        public static bool isFascinating(int num)
        {
            int[] arr = new int[10];
            String str = "" +(num*1).ToString() +(num * 2).ToString() + (num * 3).ToString();

            Console.WriteLine(str);

            for (int i = 0; i < str.Length; i++)

            {
                int digit = str[i] - '0';
                if (arr[digit]!=0)
                {
                    return false;

                }
                else
                    arr[digit]++;
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            // int num = 192;
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 100)
                Console.WriteLine("No");

            else
            { 
                              
                bool ans = isFascinating(num);
                if (ans)
                    Console.WriteLine("Facinating Number");
                else
                    Console.WriteLine("No Facinating Number");
            }
        }


    }
}
