using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.StringClass
{
    class ReplaceVowelsHash
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string str = "";
            str = Console.ReadLine();
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u' || ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U')
                {
                    ch[i] = '#';
                }
            }
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write( ch[i]+" " );

            }
        }
    }
}
