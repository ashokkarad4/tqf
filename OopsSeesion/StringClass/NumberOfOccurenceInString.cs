using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class NumberOfOccurenceInString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();
            string[] words = str.Split(" ");

            for(int i=0;i<words.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(words[i]==words[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<words.Length;j++)
                    {
                        if(words[i]==words[j])
                        {
                            count++;
                        }
                    }
                    if(count==1)
                        //if(count>1)
                    {
                        Console.WriteLine(words[i]+" "+count);
                    }
                }
            }
        }
    }
}
