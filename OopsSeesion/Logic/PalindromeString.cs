using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class PalindromeString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            String s = Console.ReadLine();
            /* String rev = " ";
             for(int i=s.Length-1;i>=0;i--)
             {
                 rev = rev + s[i];
             }
             Console.WriteLine(rev);
             if(rev==s)
             {
                 Console.WriteLine("Palindrome");
             }
             else
                 Console.WriteLine("not palindrome");   */
           // String s1 = "Ashok";
            bool ispalin = true;
            for (int start = 0, end= s.Length - 1; start < end;start++,end--)
            {
                if(s[start]!=s[end])
                {
                    ispalin = false;
                    break;
                }
            }
            if(ispalin==true)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Paildrome");

        }
    }
}
