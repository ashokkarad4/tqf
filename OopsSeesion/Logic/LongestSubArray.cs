using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Logic
{
    class LongestSubArray
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 0, 1, 0, 1, 1, 0, 1, 0 };
            int ones = 0, zeros = 0;
            int max = 0;
            for(int i=0;i<=a.Length;i++)
            {
                zeros = 0;
                ones = 0;
                for(int j=i;j<a.Length;j++)
                {
                    if (a[j] == 0)
                    {
                        zeros++;
                    }
                    else
                        ones++;
                    if(zeros==ones)
                    {
                        if(max<j-i+1)
                        {
                            max = j - i + 1;
                        }
                        Console.WriteLine(max);

                    }
                }
            }
        }
    }
}
