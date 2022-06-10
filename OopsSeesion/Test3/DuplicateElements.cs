using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test3
{
    class DuplicateElements
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 3, 2, 4, 9, 2 };
			int n = a.Length;
			int temp = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (j != i)
					{
						if (a[i] == a[j])
							a[j] = temp;
					}
				}
			}
            Console.WriteLine("..................................");
			Console.WriteLine("Array after removing duplication");
			for (int i = 0; i < n; i++)
			{
				if (a[i] != temp)
                {
                    Console.Write(a[i]);
                }
					
			}
		}
	}  


    }


    


