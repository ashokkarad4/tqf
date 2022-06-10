using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Containment
{
    class Address
    {
        int pinc;
        string cname;
        string sname;
        public Address(int pinc,string cname,string sname)
        {
            this.pinc = pinc;
            this.cname = cname;
            this.sname = sname;
        }
        public void show()
        {
            Console.WriteLine(" PinCode "+pinc+" CityName "+cname+" StateName "+sname );
        }
    }
    class Person
    {
        int id;
        string name;
        Address add;
        public Person(int id,string name,Address add)
        {
            this.id = id;
            this.name = name;
            this.add = add;
        }
        public void display()
        {
            Console.WriteLine(" Id "+id+" Name "+name);
            add.show();
        }
    }
    class PersonContainment
    {
        static void Main(string[] args)
        {
            Address a = new Address(431530,"Parli","MH");
            Person p = new Person(123, "Ashok", a);
            p.display();

        }
    }
}
