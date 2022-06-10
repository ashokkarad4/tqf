using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Oops
{
    class ConstructorThis
    {
        int id;
        string name;
        long mob;
        public ConstructorThis( int id,string name,long mob)
        {
            this.id = id;
            this.name = name;
            this.mob = mob;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name+" "+mob);
        }

       //passbyvalueandref
       public void add(ref int x,ref int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum="+sum);
        }

        public void add2(int x,int y)
        {
            int sum = x + y;
            Console.WriteLine("Sum="+sum);
        }

        static void Main(string[] args)
        {
            ConstructorThis c = new ConstructorThis(101,"rahul",545987785);
            c.display();
            Console.WriteLine("///////////////////////");
            //CallByReference
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            sum = num1 + num2;
            c.add(ref num1, ref num2) ;
            Console.WriteLine("Sum in main="+sum);
            Console.WriteLine("////////////////////////////////");
            //callbyvalue
            c.add2(num2, num2);
            Console.WriteLine("Sum in main="+sum);
        }
    }
}
