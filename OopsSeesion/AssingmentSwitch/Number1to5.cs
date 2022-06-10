using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentSwitch
{
    class Number1to5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                default: Console.WriteLine("Invlid Credentials");
                    break;
            }
        }
    }
}
