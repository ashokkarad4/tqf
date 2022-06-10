using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentInheritance
{
    class Address
    {
        string add1;
        string city;
        int pincode;
        public Address(string add1,string city,int pincode)
        {
            this.add1 = add1;
            this.city = city;
            this.pincode = pincode;
        }
        public void show3()
        {
            Console.WriteLine("Address "+add1+"City "+city+"Pincode "+pincode);
        }


    }
    class Item
    {
        int itemid;
        string itemname;
        int price;
        public Item(int itemid,string itemname,int price)
        {
            this.itemid = itemid;
            this.itemname = itemname;
            this.price = price;
        }
        public void show2()
        {
            Console.WriteLine("ItemId "+itemid+"Itemname "+itemname+"ItemPrice "+price);
        }
    }
    class Customer
    {
        int custid;
        string custname;
        Address address;
        public Customer(int custid,string custname,Address address)
        {
            this.custid = custid;
            this.custname = custname;
            this.address = address;
        }
        public void show1()
        {
            Console.WriteLine("CustomerId "+custid+"CustomerName "+custname);
            address.show3();
        }
    }

    class Order
    {
        int orderid;
        string orderdate;
        Customer cust;
        Item item;
        public Order(int orderid,string orderdate,Customer cust,Item Item)
        {
            this.orderid = orderid;
            this.orderdate = orderdate;
            this.cust = cust;
            this.item = Item;
        }
        public void display()
        {
            Console.WriteLine("OrderId "+orderid+"OrderDate "+orderdate);
            cust.show1();
            item.show2();
            

        }
    }
    class OrderQue7
    {
        static void Main(string[] args)
        {
            Address a = new Address("Injegaon", "Parli", 431530);
            Item i = new Item(472, "Samsung",30000);
            Customer c = new Customer(332,"Rahul",a);
            Order o=new Order(145,"March",c,i);
            o.display();
        }
    }
}
