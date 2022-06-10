using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test2
{
    class SeriesQue5
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter nth");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                int ans = i * i - 1;
                Console.Write(" "+ans);
            }
        }
    }
}
