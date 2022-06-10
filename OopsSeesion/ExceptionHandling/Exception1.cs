using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ExceptionHandling
{
    class Exception1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age");
            /*  int age = int.Parse(Console.ReadLine());
              Console.WriteLine($"Name="+name+"Age="+age);*/
           
            try
            {
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Name=" + name + "Age=" + age);
                Console.WriteLine("Character at 5th position in name is="+name[4]);
                try
                {
                    Console.WriteLine("Enter two num");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Duvision=" + a / b);
                }
                catch(DivideByZeroException d)
                {
                    Console.WriteLine(d.Message);
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine("Age Should be num");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(SystemException ob)
            {
                Console.WriteLine(ob.Message);
            }
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
