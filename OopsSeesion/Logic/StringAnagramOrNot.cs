using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Logic
{
    class StringAnagramOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st String");
            String str1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd String");
            String str2 = Console.ReadLine();

            String s1 = str1.ToLower();
            String s2 = str2.ToLower();

            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            Console.WriteLine(String.Join(" ", ch1));
            Console.WriteLine(String.Join(" ", ch2));

            String st1 = new string(ch1);
            String st2 = new string(ch2);
            if (st1.CompareTo(st2) == 0)
            {
                Console.WriteLine("Both The String Are Anagram");
            }
            else
            {
                Console.WriteLine("Both the string are not anagram");
            }

        }
    }
}
