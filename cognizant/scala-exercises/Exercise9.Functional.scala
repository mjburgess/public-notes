// CHAPTER:   FUNCTIONAL 
// PROBLEM:    
// TIME:       25 m

// CURRYING 
//Q. define a curried method called retry which takes a function (() => Bool) as a second argument 
//it should print "retrying" and call the function until it returns true 

//Q. call retry, pass a function which returns false if a random number is <= 50
// HINT: scala.util.Random.nextInt(100)

// IMMUTABILITY
//Q. define an immutable BankAccount class with withdraw() and deposit() methods
//Q. define a gift method, it should accept a list of BankAccounts and give them all 100

//Q. define a Person call with an  ArrayBuffer account history

// COMBINATORS & PREDICATES
val names = List("Sherlock Holmes", "Thomas Jefferson", "Alex Hamilton")
val ages = List(30, 40, 50)

// Q. are all the names more than 3 characters?
// Q. is any age greater than 18 ?
//HINT: exists, forall

// Q. get a list of birth years from the list of ages
// HINT: map

// Q. get a list of names broken apart by space
// HINT:  split flatMap

//Q. using reduce, get the average age


//Q. convert names/ages to a Map[String, String]

//EXTRA:
// Q. use a for comprehension to get the same results as the above questions

//Q. use foldLeft to join all the names/ages in sequence (ie., Sherlock Holmes 30, Thomas ...)
println(na.foldLeft("")( (acc, kv) => acc + kv._1 + kv._2))



// REVIEW: What did you learn from this exercise?