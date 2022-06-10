using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test2
{
    class PatternQue4
    {
        /*
       
                1
                21
                321
                4321
                54321
        */

        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
