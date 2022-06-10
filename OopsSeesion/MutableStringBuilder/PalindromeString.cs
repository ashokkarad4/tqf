using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.MutableStringBuilder
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
           String s = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            string s1 = sb.ToString();

            Console.WriteLine("Reverse String="+s1);
            Console.WriteLine(".....................................");

            if (s1 == s)   
            {
                Console.WriteLine("String is Palindrome ");
            }
            else
            {
                Console.WriteLine("String is not Palindrome ");
            }
        }
    }
    }

