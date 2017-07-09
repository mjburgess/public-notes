/*
Q. Create the class BankAccount.

Q. Give BankAccount:
    a private balance, 
    a constructor to initialize it (default of 100)
    and add UpdateBalance and GetBalance methods.

Q. In UpdateBalance ensure the balance doesn't go below 0.
 
Q. In your Main(), create several bank account objects. 
	 One which has a default balance.
	 One which has an initial balance of £1000.
	 One which has/(tries to have) an intial balance of -£1000.
 
Q. Update each balance to be £10 less than the current. 
 
Q. Create an Item class.
	 Give item the *properties* Name and Price.
	 Name should have a public getter and setter.
	 Price should have a public getter and a private setter.
 
     HINT: private set;

Q. Give Item a constructor which initializes the Price property.

Q. Ensure the following code succeds in your program:

	var lens = new Item(599.99M) {
	 Name = "Zeiss 35mm FE"
	}; 

Q. What does var do? What does M do? 




EXTRA:

Q. Revise your BankAccount class so that its balance is readonly. 

Q. What should UpdateBalance return?

Q. Ensure the following code succeds...

var account = new BankAccount(100);
account = account.UpdateBalance(-10);

Console.WriteLine(account.Balance); // 90

*/


 
 