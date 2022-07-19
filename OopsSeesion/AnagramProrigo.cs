using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{ 
class Anagram
    {
        public static void isAnagram(string s1,string s2)
        {
            string str1 = s1.ToLower();
            string str2 = s2.ToLower();

            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string ss1 = new string(ch1);
            string ss2 = new string(ch2);
            if(ss1.CompareTo(ss2)==0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
class AnagramProrigo
{
    static void Main(string[] args)
    {
        Anagram.isAnagram("build", "Dubli");
        Anagram.isAnagram("peek", "jeep");

    }
}
}


