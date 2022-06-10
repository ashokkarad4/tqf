using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Oops
{
    class PassByRefAndValue
    {
        void swapByRef(ref int x,ref int y)
        {
            Console.WriteLine("Before Swap in swap method=="+x+" "+y);
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After swap in swap method=="+x+" "+y);
        }

        void swapByValue(int x,int y)
        {
            Console.WriteLine("Before swap in swa method=="+x+" "+y);
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After swap in swap method=="+x+" "+y);
        }
        static void Main(string[] args)
        {
            PassByRefAndValue p = new PassByRefAndValue();
            Console.WriteLine("Enter the num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            int num2 = int.Parse(Console.ReadLine());

            p.swapByRef(ref num1, ref num2);
            Console.WriteLine("After Swap in main  "+num1+" "+num2);

            Console.WriteLine("///////////////////////////////////");
            p.swapByValue(num1, num2);
            Console.WriteLine("After swap in main  "+num1+" "+num2);
        }
    }
}
