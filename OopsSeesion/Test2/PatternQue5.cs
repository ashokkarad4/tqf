using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test2
{
    class PatternQue5
    {
        /*
                    1
                    10
                    101
                    1010
                    10101
*/
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=4;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    if(k%2==0)
                    {
                        Console.Write("0");
                    }
                    else
                        Console.Write("1");
                }
                Console.WriteLine();
            }
        }
    }
}
