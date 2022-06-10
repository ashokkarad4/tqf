using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class ReversString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            String str = Console.ReadLine();
            String rev = " ";
        /* for(int i=0;i<str.Length;i++)
            {
                rev = str[i] + rev;
            }
            Console.WriteLine(rev);   */


            for(int i=str.Length-1;i>=0;i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev); 
        }
    }
}
