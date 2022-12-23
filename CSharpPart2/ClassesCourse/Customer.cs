using System.Collections.Generic;

namespace CSharpPart2
{
    //// Constructors
    //var customer = new Customer();
    //Console.WriteLine(customer.Id);
    //        Console.WriteLine(customer.Name);
    //        Console.WriteLine();

    //        var order = new Order();
    //customer.Orders.Add(order);
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Id = id;
            this.Name = name;
        }

        
    }
}
