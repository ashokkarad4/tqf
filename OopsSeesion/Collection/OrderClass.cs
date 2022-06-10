using System;
using System.Collections;

namespace OopsSeesion.Collection
{
    class Order
    {
        int orderid;
        string custname;
        string city;
        ArrayList items;

        public Order(int orderid, string custname, string city, ArrayList items)
        {
            this.Orderid = orderid;
            this.Custname = custname;
            this.City = city;
            this.Items = items;
        }

        public int Orderid { get => orderid; set => orderid = value; }
        public string Custname { get => custname; set => custname = value; }
        public string City { get => city; set => city = value; }
        public ArrayList Items { get => items; set => items = value; }
    }
    class OrderClass
    {
        static void Main(string[] args)
        {
            /*  ArrayList al = new ArrayList();
              al.Add("Watch");
              al.Add("Mobile");
              al.Add("Headphone");
              Order o = new Order(101,"ashok","parli", al);
              ArrayList al1 = new ArrayList();
              al1.Add("Snmart Wath");
              al1.Add("Iphone");
              al1.Add("Headphone");
              Order o1 = new Order(111, "rahul", "pune", al1);
            */

            //Create a arryalist of 5 orders in which data will be accepted dynamically..
            ArrayList orderlist = new ArrayList();

            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter orderid ,name,city");
                int id = int.Parse(Console.ReadLine());
                string nm = Console.ReadLine();
                string city = Console.ReadLine();
                Console.WriteLine("Enter How many Iems u want to order");
                int c = int.Parse(Console.ReadLine());

                ArrayList itemlist = new ArrayList();
                for(int j=1;j<=c;j++)
                {
                    Console.WriteLine("Add{j} items in ur order");
                    string item = Console.ReadLine();
                    itemlist.Add(item);

                }
                orderlist.Add(new Order(id, nm, city, itemlist)); 
            }
        }
    }
}
