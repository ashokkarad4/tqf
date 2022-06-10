using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Oops
{
    class Student3
    {
        private int id;
        private string name;
        private double per;
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public double Per
        {
            get { return per; }
            set { this.per = value; }
        }
    }
    class GetterSetterMethod
    {
        static void Main(string[] args)
        {
            Student3 s = new Student3();
            s.Id = 101;
            //int sid = s.Id;
            Console.WriteLine(s.Id);
            s.Name = "Amit";
            Console.WriteLine(s.Name);
            s.Per = 65.55;
            double sper = s.Per;
            Console.WriteLine(s.Per);

        }
    }
}
