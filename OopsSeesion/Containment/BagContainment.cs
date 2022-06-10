using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Containment
{
    class Nib
    {
        string material;
        public Nib(string material)
        {
            this.material = material;
        }
        public void show()
        {
            Console.WriteLine(" "+material);
        }
    }
    class Pen
    {
        string pcolor;
        string pname;
        Nib nib;
        public Pen(string pcolor,string pname,Nib nib)
        {
            this.pcolor = pcolor;
            this.pname = pname;
            this.nib = nib;
        }
        public void show2()
        {
            Console.WriteLine(" "+pcolor+" "+pname);
            nib.show();
        }
    }
    class Bag
    {
        string brand;
        string color;
        Pen pen;
        public Bag(string brand,string color,Pen pen)
        {
            this.brand = brand;
            this.color = color;
            this.pen = pen;
        }
        public void display()
        {
            Console.WriteLine(" "+brand+" "+color);
            pen.show2();
        }

    }
    class BagContainment
    {
        static void Main(string[] args)
        {
            Nib n = new Nib("Steel");
            Pen p = new Pen("Black","Flair",n);
            Bag b = new Bag("Safari", "Blue", p);
            b.display();
        }
    }
}
