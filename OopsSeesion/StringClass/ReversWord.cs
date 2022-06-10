using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class ReversWord
    {
        static void Main(string[] args)
        {
            String str = "India is my country";
            String[] mywords = str.Split(" ");
            String reversString = " ";
            for(int i=0;i<mywords.Length;i++)
            {
                String s = mywords[i];
                String reverseMyword = " ";
                for(int j=s.Length-1;j>=0;j--)
                {
                    reverseMyword = reverseMyword + s[j];
                }
                reversString = reversString + reverseMyword + " ";
            }
            Console.WriteLine(reversString);
        }
    }
}
