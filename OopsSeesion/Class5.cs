using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class Class5
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = str.ToLower();
            char[] ch = str1.ToCharArray();
            int count = 0;
            for(int i=0;i<str1.Length;i++)
            {
                if(ch[i]=='a'||ch[i]=='e'||ch[i]=='i'||ch[i]=='o'||ch[i]=='u')
                {
                    ch[i] = '#';
                }

            }
            Console.WriteLine(String.Join(" ",ch));
        }
    }
}
