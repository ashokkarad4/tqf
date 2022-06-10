using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class ReverseWordExceptFirstAndLast
    {
        static void Main(string[] args)
        {
            String s = "Hello how are you  ";
            String[] str = s.Split(" ");
            String reversWord = " ";
            for (int i = 1; i < str.Length-1; i++)
            {
                String word = str[i];
                String revers = " ";
                for(int j=word.Length-1;j>=0;j--)
                {
                    revers = revers + word[j];
                }
                reversWord = reversWord + revers + " ";
            }
            Console.WriteLine(reversWord);
            Console.WriteLine(str[0]+" "+reversWord+" "+str[str.Length-1]);
        }
    }
    }

