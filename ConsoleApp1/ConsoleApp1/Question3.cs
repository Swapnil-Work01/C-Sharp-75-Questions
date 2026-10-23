using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question3
    {
        public void Runner()
        {
            List<String> list = new List<String>();
            list.Add("a");
            list.Add("b");
            list.Add("c");

            Order o = new Order(1,"XYZ",list);
            Console.WriteLine("Original :");
            PrintObject(o);

            Console.WriteLine("After shallow copy's items update original will be:");
            Order o1 =(Order) o.clone();
            o1.Items.Add("x");
            PrintObject(o);

            Console.WriteLine("After shallow copy's items update o1 will be:");
            PrintObject(o);

            Console.WriteLine("After deep copy's items update original will be:");
            Order o2 = new Order(o);
            o2.Items.Add("abc");
            PrintObject (o);

            Console.WriteLine("After deep copy's items update o2 will be:");
            PrintObject(o2);



        }

        public void PrintObject(Order o)
        {
            Console.WriteLine("Oreder details :");
            Console.WriteLine("Id = " + o.Id);
            Console.WriteLine("Customer = "+o.Customer);
            Console.WriteLine("Items = "+string.Join(',',o.Items));

        }
    }

    public class Order
    {
        public int Id;
        public string Customer;
        public List<String> Items;

        public Order(int id, string customer, List<string> items)
        {
            Id = id;
            Customer = customer;
            Items = items;
        }

        public object clone()
        {
            return this.MemberwiseClone();
        }

        public Order(Order other)
        {
            this.Id= other.Id;
            this.Customer = other.Customer;
            List<String> l = new List<string>(other.Items);
            this.Items = l;
        }
    }
}
