using System;
using System.Collections;

namespace OopsSeesion.Collection
{
    class Person
    {
        string name;
        ArrayList hobbies;

        public Person(string name, ArrayList hobbies)
        {
            this.Name = name;
            this.Hobbies = hobbies;
        }

        public string Name { get => name; set => name = value; }
        public ArrayList Hobbies { get => hobbies; set => hobbies = value; }
    }
    class ContainmentArrayList
    {
        static void Main(string[] args)
        {
            ArrayList plist = new ArrayList();
            do
            {
                Console.WriteLine("Enter name");
                string nm = Console.ReadLine();
                Console.WriteLine("Enter Num of hobbies u have");
                int c = int.Parse(Console.ReadLine());
                ArrayList hobbieslist = new ArrayList();
                for(int i=1;i<=c;i++)
                {
                    Console.WriteLine($"{nm}Enter ur hobby");
                    string h = Console.ReadLine();
                    hobbieslist.Add(h);
                }
                Person p = new Person(nm, hobbieslist);
                plist.Add(p);
                Console.WriteLine("Do u want add one more person objet yes/no");
                string choice = Console.ReadLine().ToLower();

                if (choice=="no")
                {
                    break;
                }

            } while (true);
        }
    }
}
