using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentLooping
{
    class Odd521to229While
    {
        static void Main(string[] args)
        {
            int num= 521;
            while(num>229)
            {
                if(num%2!=0)
                {
                    Console.WriteLine(num);
                }
                num--;
            }
        }
    }
}
