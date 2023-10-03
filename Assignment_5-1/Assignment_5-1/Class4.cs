﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Customer
    {
        int Customerid;
        string Name;
        int Age;
        double Phone;
        string City;
        public Customer()
        {
            Console.WriteLine(" enter the customer ID");
            this.Customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name");
            this.Name = Console.ReadLine();
            Console.WriteLine("enter the age");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the phone");
            this.Phone = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the city");
            this.City = Console.ReadLine();

        }
        public Customer(int Customer_id, string Name, int age, double phone, string city)
        {
            this.Customerid = Customer_id;
            this.Name = Name;
            this.Age = age;
            this.Phone = phone;
            this.City = city;
        }
        public void display(Customer ob)
        {

            Console.WriteLine($"{ob.Customerid}\t\t\t{ob.Name}\t{ob.Age}\t\t{ob.Phone}\t\t{ob.City}");
        }
        public static void Main(string[] args)
        {
            Customer cd1 = new Customer();
            Customer cd2 = new Customer(2, "veena", 21, 8688279968, "Bengaluru");
            Customer cd3 = new Customer(3, "hema", 23, 9148633089, "atp");
            Customer cd4 = new Customer(4, "Bhagya", 45, 9492963134, "dmm");
            Customer cd5 = new Customer(5, "Prakash", 53, 9491121905, "dmm");
            Console.WriteLine("CUSTOMER_ID\t\tNAME\t\tAGE\t\tPHONE_NO\t\tCITY");
            cd1.display(cd1);
            cd2.display(cd2);
            cd3.display(cd3);
            cd4.display(cd4);
            cd5.display(cd5);
            Console.Read();
        }
    }
}
