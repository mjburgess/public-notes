using System;
using System.Collections.Generic;
using System.Linq;


class Customer
{
    public string Name;
    public string Telephone;
    public int ID;
}

class Order
{
    public int ID;
    public string CustomerName;
    public string ItemName;
    public string PostCode;
}

class Solution14_1
{
    public static void Solution()
    {
        List<Order> orders = new List<Order>
        {
            new Order { ID = 0, CustomerName = "Alice", ItemName = "toy", PostCode = "AB1 2CD"},
            new Order { ID = 1, CustomerName = "Alice", ItemName = "toy", PostCode = "AB1 2CD"},
            new Order { ID = 2, CustomerName = "Bob", ItemName = "toy", PostCode = "EC1V 2NR"},
            new Order { ID = 3, CustomerName = "Bob", ItemName = "sweets", PostCode = "EC1V 2NR"},
            new Order { ID = 4, CustomerName = "Bob", ItemName = "chocolate", PostCode = "EC1V 2NR"},

        };

        List<Customer> people = new List<Customer>
        {
            new Customer { ID = 0, Name = "Alice", Telephone = "+44-123456789" },
            new Customer { ID = 1, Name = "Bob", Telephone = "+44-987654321" }
        };


        var toys = from order in orders
                   where order.ItemName == "toy"
                   orderby order.CustomerName
                   select order;

        var _toys = orders
            .Where(order => order.ItemName == "toy")
            .OrderBy(order => order.CustomerName)
            .Select(order => order);


        Console.WriteLine("Orders for Toys:");
        foreach (var order in toys)
        {
            Console.WriteLine($@"
                Name: {order.ItemName} 
                ID: {order.ID}");
        }

        foreach (var order in _toys)
        {
            Console.WriteLine($@"
                Name: {order.ItemName} 
                ID: {order.ID}");
        }

        var orderDetails = 
            from person in people
            join order in orders
            on person.Name equals order.CustomerName
            where order.ID % 2 == 0
            select new
            {
                Name = person.Name.ToUpper(),
                Item = order.ItemName,
                Tel = person.Telephone,
                PostCode = order.PostCode
            };

        Console.WriteLine("Even Order Details:");
        foreach (var info in orderDetails)
        {
            Console.WriteLine($@"
                Name: {info.Name} 
                Item: {info.Item} 
                Tel:  {info.Tel} 
                PC:   {info.PostCode}");
        }

    }
}
