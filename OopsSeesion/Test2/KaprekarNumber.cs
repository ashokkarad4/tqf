using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test2
{
    class KaprekarNumber
    {
        static void Main(string[] args)
        {
			int a, count = 0, s = 0, f, l;
            Console.WriteLine("Enter Number");
            a = Convert.ToInt32(Console.ReadLine());
			
			for (int i = a; i > 0; i = i / 10)
			{
				count++;
			}
			s = a * a;
			f = s / (int)Math.Pow(10, count);
			l = s % (int)Math.Pow(10, count);
			if (f + l == a)
			    Console.WriteLine("Kaprekar Number");
		else
				Console.WriteLine("Not a Kaprekar Number");
		}
	}
    
}
