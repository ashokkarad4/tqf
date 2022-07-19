using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class ReversWordByWord
    {
        static void Main(string[] args)
        {
            string str = "Ashok angad Karad";
            string[] word = str.Split(" ");
            string reverse = " ";
            for(int i=0;i<word.Length;i++)
            {
                string ss = word[i];
                string reverseword = " ";
                for(int j=ss.Length-1;j>=0;j--)
                {
                    reverseword = reverseword + ss[j];

                }
                reverse = reverse + reverseword + " ";
            }
            Console.WriteLine(reverse);
        }
    }
}
