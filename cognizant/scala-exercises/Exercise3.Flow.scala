// CHAPTER:   FLOW 
// PROBLEM:   Generate some different greetings. 
// TIME:      25 m


// PART 1 -- BRANCHING & MATCHING
val time = "AM"

//Q. define the val greeting to be either "Hello" if time is AM, or "Goodbye" if time is PM
//.. use one assignment (ie., an if-expression)

val dog = "spot"

// Q. add a case to handle "spot"
val message = dog match {
    case "fido" => "Hello Boy!"
    case "fluffy" => "Hello Girl!"
}

println(message)

// Q. rewrite the above if-expression as a match-expression


// PART 2 -- FOR COMPREHENSIONS
val mixed = List(1, "2", false, 3.4)

// Q. print out every element of this list


// Q. print out  "you're allowed in ${name}" for all the the adults
val people = List("Michael 10", "John 20", "Watson 40")

// HINT: .split

//Q. define ages, a Vector[Int] of the ages 
//HINT: .split .toInt 

// Q. determine the average age
//HINT: use a var total and while


println(s"The average age is ${total/ages.length}")


//Q. using a range, print out "Ho!" three times 


// EXTRA
// Q. use a for-comprehension to create a sequence of 5 '.'s called row
// HINT: the input must be the same length as the output, in this case

// Q. print out row on one line 
//HINT:  use print()

// Q. use a for-comprehension to create a sequence of 5 rows called grid
// Q. print out grid

// REVIEW: What did you learn from this exercise?