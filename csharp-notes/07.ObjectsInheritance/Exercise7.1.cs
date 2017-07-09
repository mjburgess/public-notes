/*
Q. Create the class heirachy:
 Item 
     Food : Item
     PickAndMix : Item
     
Q. Every Item should have a private price.

Q. Every Item should have the methods GetPrice() and SetPrice()
    OR, more advanced: a property Price with a get {} and set {} 

Q. Every Food should have a public Weight.

Q. Every Food should override their parent's GetPrice()
 GetPrice() should return Volume * their parent's price
    (or the getter for the property)
 
 HINT: you'll need to call the parent's GetPrice
         *from* the child's GetPrice
         
     How?  base.
     
Q. Every Food should have a WeightInG/GetPrice which follows
 the formulate Weight * Price


Q. Every PickAndMix should have a Count with a price formula Price * Count * 2

In Your Main Method:

Q. Create an array of Items with an Item, Food and a PickAndMix 

Q. Write a static method which accepts an array of Items 
     and iterates over every element summing 
     their individual prices into a total.

 Console.WriteLine() this total. 

*/