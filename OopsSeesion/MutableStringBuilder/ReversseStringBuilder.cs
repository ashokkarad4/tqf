using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.MutableStringBuilder
{
    class ReversseStringBuilder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            string s1 = sb.ToString();

            Console.WriteLine(s1);
        }
    }
}
