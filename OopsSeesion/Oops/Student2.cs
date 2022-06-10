using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class Student2
    {
        int id;
        string name = null;
        double p, c, m,sum=0,per;

        
        public void accept()
        {
            id = 101;
            name = "Rahul";
            p = 56.45;
            c = 85.25;
            m = 55.78;

        }
        public void percentage()
        {
            sum = p + c + m;
            per = (sum * 100) / 300;
        }
        public void display()
        {
            Console.WriteLine("Id="+id);
            Console.WriteLine("Name="+name);
            Console.WriteLine("Percentage="+per);
        }

        static void Main(string[] args)
        {
            Student2 s = new Student2();
            s.accept();
            s.percentage();
            s.display();
        }
    }
}
