using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayTwoD
{
    class RowWiseMax
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 5, 4, 1 }, { 18, 14, 44 }, { 44, 95, 66 } };
            for (int i = 0; i < a.GetLength(0); i++)
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
