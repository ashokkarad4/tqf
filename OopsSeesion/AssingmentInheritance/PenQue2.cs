using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentInheritance
{
    class Nib
    {
        string material;
        double width;
        public string Material
        {
            get;
            set;
        }
        public double Width
        {
            get;
            set;
        }
            
    }
    class Refill
    {
        string inkcolor;
        int length;
        Nib ni;
        public string Inkcolr
        {
            get
            {
                return inkcolor;
            }
            set
            {
                inkcolor = value;
            }
        }
        public int Length
        {
            get { return length; }
            set
            {
                length = value;
            }
        }
        public Nib Ni
        {
            get
            {
                return ni;
            }
            set
            {
                ni = value;
            }
        }
    }
    class Pen
    {
        int caplength;
        string brand;
        Refill r;
            public int Caplength
        {
            get;
            set;
        }
        public string Brand
        {
            get;
            set;
        }
        public Refill R
        {
            get;
            set;
        }


    }
    class PenQue2
    {
        static void Main(string[] args)
        {
            Nib n = new Nib();
            n.Material = "Steel";
            n.Width = 0.3;
            Refill re = new Refill();
            re.Inkcolr = "Blue";
            re.Length = 5;
            re.Ni = n;
            Pen p = new Pen();
            p.Brand = "Flair";
            p.Caplength = 3;
            p.R = re;
            Console.WriteLine(p.Brand+" "+p.Caplength+" "+p.R.Inkcolr+" "+p.R.Length+" "+p.R.Ni.Material+" "+p.R.Ni.Width);

        }
    }
}
