using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingnmentCondiStatement
{
    class VowelOrConsonent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Character");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == ' ')
            {
                Console.WriteLine("Character Is Vowel");
            }
            else
                Console.WriteLine("Character is Consonent");
    }   }
}
