using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentLooping
{
    class BreakDemo
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10;i++)
            {
                if(i==5)
                {
                    break;
                }
                Console.WriteLine(i);

            }
        }
    }
}
