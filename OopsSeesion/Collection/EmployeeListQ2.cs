using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Collection
{

    class Employee
    {
        string name;
        string desig;
        double salary;

        public Employee(string name, string desig, double salary)
        {
            this.Name = name;
            this.Desig = desig;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Desig { get => desig; set => desig = value; }
        public double Salary { get => salary; set => salary = value; }
        public override string ToString()
        {
            return name + " " + desig + " "+salary+" ";
        }


      


    }
    class EmployeeListQ2
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            emp.Add(new Employee("Raj", "Manager", 40000));
            emp.Add(new Employee("Nisha", "HR", 45000));

            emp.Add(new Employee("Om", "Developer", 50000));
            emp.Add(new Employee("Rahul", "tester", 55000));
            emp.Add(new Employee("Nisha", "HR", 45000));


            foreach (Employee e in emp)

            {
                Console.WriteLine(e);
            }


        }
    }
}
