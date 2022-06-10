using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentSwitch
{
    class AreaMenuDriven
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("radius");
                int r = Convert.ToInt32(Console.ReadLine());
                float PI=3.14f;
                Console.WriteLine("Enter Side");
                int side = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Width");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Length");
                float length = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1.Area of Circle");
                Console.WriteLine("2.Area of Square");
                Console.WriteLine("3.Area of Rectangle");
                Console.WriteLine("4.Circumference of a circle");
                Console.WriteLine("5.perimeter of Square");
             
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Area of Circle=" + (PI*r*r));
                        break;
                    case 2:
                        Console.WriteLine("Area of square" + (side - side));
                        break;
                    case 3:
                        Console.WriteLine("Area of Rectangle" + (width*length));
                        break;
                    case 4:
                        Console.WriteLine("Circumference of circle" + (2*PI*r));
                        break;
                    case 5:
                        Console.WriteLine("Perimeter of Square"+(4*side));
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("Do you want to Continue");
                ch = Console.ReadLine()[0];
            } while (ch == 'y' || ch == 'Y');
        }
    }
}
