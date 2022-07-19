using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Practice
{
    interface Bikee
    {
        void type();
    }
    interface FourWheeler
    {
        void four();
    }
    interface TwoWheeler
    {
        void Two();
    }
    class BikeType:FourWheeler,TwoWheeler
    {
        public void four()
        {
            Console.WriteLine("Four Wheeler");
        }
        public void Two()
        {
            Console.WriteLine("Two Wheeler");
        }
    }
    class PracticeInterface
    {
        static void Main(string[] args)
        {
            BikeType b = new BikeType();
            b.four();
            b.Two();
        }
    }
}
