/*
Q. Define class Order and class Customer so that the following code 
    will compile in your main method:

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

In Your Main Method:

Q. Write a query to select all the toys from the orders,
    ordering the results by customer name. 
    
Q. Loop over the result and write the details of each order.

Q. Perform the same query using the explict extension methods. 

Q. Write a query to select all the information from people AND orders,
    where the order's ID is even (%2 == 0)

    Return the person's Name in upper case, 
    the item name, 
    the telephone number 
    and the postcode. 
    
Q. Loop over the result and write the details of each result.
*/
