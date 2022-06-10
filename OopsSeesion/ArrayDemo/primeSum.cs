using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
	class primeSum
	{
		static void Main(string[] args)
		{
			int sum = 0;
			Console.WriteLine("Enter Array Size");
			int num = Convert.ToInt32(Console.ReadLine());
			int[] a = new int[num];
			Console.WriteLine("Enter Array Elements");
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = Convert.ToInt32(Console.ReadLine());
			}
			for (int i = 0; i < a.Length; i++)
			{
				int j = 2;
				int temp = 1;
				while (j < a[i])
				{
					if (a[i] % j == 0)
					{
						temp = 0;
						break;
					}
					j++;
				}

				if (temp == 1)
				{
					sum = sum + a[i];
				}
			}
			Console.Write("Sum of prime numbers:" + sum);
		}
	}
}
