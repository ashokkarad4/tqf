using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test3
{
    class Car
    {
        int carid;
        string carcolor;
        Engine eng;
        Gear ge;
        public Car(int carid,string carcolor,Engine eng,Gear ge)
        {
            this.carid = carid;
            this.carcolor = carcolor;
            this.eng = eng;
            this.ge = ge;
        }
        public void carDisplay()
        {
            Console.WriteLine(carid+" "+carcolor);
            eng.engineDisplay();
            ge.geardisplay();
        }
    }
    class Engine
    {
        int engineid;
        string lastenginecleandate;
        SubEngine sub;
        public Engine(int engineid,string lastenginecleandate,SubEngine sub)
        {
            this.engineid = engineid;
            this.lastenginecleandate = lastenginecleandate;
            this.sub = sub;
        }
        public void engineDisplay()
        {
            Console.WriteLine(engineid+" "+lastenginecleandate);
            sub.subdisplay();
        }
    }
    class SubEngine
    {
        string subenginetype;
        public SubEngine(string subenginetype)
        {
            this.subenginetype = subenginetype;
        }
        public void subdisplay()
        {
            Console.WriteLine(subenginetype+" ");
        }
    }
    class Gear
    {
        string type;
        public Gear(string type)
        {
            this.type = type;
        }
        public void geardisplay()
        {
            Console.WriteLine(type+" ");
        }
    }
    class CarEngineContainmentQue8
    {
        static void Main(string[] args)
        {
            SubEngine s = new SubEngine("BS6");
            Gear g = new Gear("Auto");
            Engine e = new Engine(45, "May",s);
            Car c = new Car(123, "Black",e,g);
            c.carDisplay();
        }
    }
}
