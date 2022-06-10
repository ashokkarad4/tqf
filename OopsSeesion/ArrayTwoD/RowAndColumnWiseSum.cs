using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayTwoD
{
    class RowAndColumnWiseSum
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sumrow = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sumrow = sumrow + a[i, j];
                }
                Console.WriteLine("Sum of Row=" + sumrow);
                Console.WriteLine();
            }
            Console.WriteLine("...................................................");
            for (int i = 0; i < a.GetLength(1); i++)
            {
                int sumcol = 0;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    sumcol = sumcol + a[j, i];
                }
                Console.WriteLine("Sum of Column=" + sumcol);
                Console.WriteLine();
            }
        }
    }
}
