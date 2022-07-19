using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace OopsSeesion
{
  class Employee
    {
        int id;
        string name;
        double ctc;
        int mngid;

        public Employee(int id, string name, double ctc, int mngid)
        {
            this.Id = id;
            this.Name = name;
            this.Ctc = ctc;
            this.Mngid = mngid;
        }

        public int Id 
        {
            get => id;
            set => id = value; 
        }
        public string Name 
        {
            get => name;
            set => name = value; 
        }
        public double Ctc
        {
            get => ctc;
            set => ctc = value;
        }
        public int Mngid
        {
            get => mngid;
            set => mngid = value;
        }

        public override string ToString()
        {
            return id + " " + name + " " + ctc + " "+mngid+" ";
        }
    }
    class APPractice
    {
        static void Main(string[] args)
        {
           ArrayList al=new ArrayList();
                    }
    }
}
