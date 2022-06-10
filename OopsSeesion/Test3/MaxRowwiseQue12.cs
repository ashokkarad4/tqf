using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test3
{
    class MaxRowwiseQue12
    {
        static void Main(string[] args)
        {
            int[,]a= new int[,] { { 22, 31, 9 }, { 12, 25, 16 } };
            for(int i=0;i<a.GetLength(0);i++)
            {
                int max = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine("Max " + max);
            }
}
    }
}
