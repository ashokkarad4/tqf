using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class CountVowels
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str = "";
            str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    count++;
                }
            }
            Console.WriteLine("Number of Vowels in the string: " + count);
        }
    }
}
