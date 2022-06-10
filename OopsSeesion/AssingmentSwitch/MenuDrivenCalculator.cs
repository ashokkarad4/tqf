using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentSwitch
{
    class MenuDrivenCalculator
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("Enter The Value For Num1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Value For Num2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition=" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction=" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication=" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division=" + (num1 / num2));
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
