using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Containment
{
    class Engine
    {
        string ename;
        public Engine(string ename)
        {
            this.ename = ename;
        }
        public void show()
        {
            Console.WriteLine(" "+ename);
        }
    }
    class Car
    {
        int id;
        string name;
        int price;
        Engine eng;

        public Car(int id,string name,int price, Engine eng)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.eng = eng;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + price);
                eng.show();
        }

    }
    class CarContainment
    {
        static void Main(string[] args)
        {
            Engine e = new Engine("Petrol");
            Car c = new Car(123, "Swift", 900000, e);
            c.display();
        }
    }
}
