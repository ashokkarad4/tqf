using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Containment
{
    class Nibb
    {
        private String materiall;
        public String Materiall
        {
            get;
            set;

        }
    }
    class Penn
    {
               private String pencolor;
               String penname;
               Nibb nib;
        public String Pencolor
        {
            get
            {
                return pencolor;
            }
            set
            {
                pencolor = value;
            }
        }
        public String Penname
        {
            get;
            set;
        }
        public Nibb Nib
        {
            get;
            set;
        }
    }
    class Bagg
    {
        String brandname;
        String color;
        Penn pe;
        public String Brandname
        {
            get;
            set;
        }
        public String Color
        {
            get;
            set;
        }
        public Penn Pe
        {
            get;
            set;
        }

    }
    class BagPenNib
    {
        static void Main(string[] args)
        {
            Nibb s = new Nibb();
            s.Materiall = "Steel";
            Penn p = new Penn();
            p.Penname = "Flair";
            p.Pencolor = "Black";
            p.Nib = s;
            Bagg b = new Bagg();
            b.Brandname = "Safari";
            b.Color = "Blue";
            b.Pe = p;
            Console.WriteLine(b.Brandname+" "+b.Color+" "+b.Pe.Penname+" "+b.Pe.Pencolor+" "+b.Pe.Nib+" "+b.Pe.Nib.Materiall);
            


        }
    }
}
