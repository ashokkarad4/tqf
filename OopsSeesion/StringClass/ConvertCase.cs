using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class ConvertCase
    {
        static void Main(string[] args)
        {
            String str = "India Is my Country";
            /* string s = str.ToLower();
             Console.WriteLine(s);*/
            String lower = " ";
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='A'&&str[i]<='Z')
                {
                    lower = lower + (char)(str[i] + 32);
                }
                else
                {
                    lower = lower + str[i];
                }
            }
            Console.WriteLine(lower);
        }
    }
}
