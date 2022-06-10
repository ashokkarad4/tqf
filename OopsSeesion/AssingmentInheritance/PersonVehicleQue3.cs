using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentInheritance
{
    class Vehicle
    {
        int vid;
        string vname;
        public Vehicle(int vid,string vname)
        {
            this.vid = vid;
            this.vname = vname;
        }
        public void show()
        {
            Console.WriteLine("Vehicle Id "+vid+"Vehicle Name "+vname);
        }
    }
    class Person
    {
        int id;
        string name;
        Vehicle veh;
        public Person(int id,string name,Vehicle veh)
        {
            this.id = id;
            this.name = name;
            this.veh = veh;
        }
        public void display()
        {
            Console.WriteLine("Id "+id+"Name "+name);
            veh.show();
        }
    }
    class PersonVehicleQue3
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle(123, "Fortuner");
            Person p = new Person(1,"Rahul",v);
            p.display();
        }
    }
}
