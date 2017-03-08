// CHAPTER:   FLOW 
// PROBLEM:   Generate some different greetings. 
// TIME:      25 m


// PART 1 -- BRANCHING & MATCHING
val time = "AM"

//Q. define the val greeting to be either "Hello" if time is AM, or "Goodbye" if time is PM
//.. use one assignment (ie., an if-expression)

val greeting = if(time == "AM") { "Hello" } else { "Goodbye" }


val dog = "spot"

// Q. add a case to handle "spot"
val message = dog match {
    case "fido" => "Hello Boy!"
    case "fluffy" => "Hello Girl!"
    case "spot" => "Hello Boy!"
}

println(message)

// Q. rewrite the above if-expression as a match-expression

val greeting = time match {
    case "AM" => "Good Morning"
    case _ => "Goodbye"
}

// PART 2 -- FOR COMPREHENSIONS
val mixed = List(1, "2", false, 3.4)

// Q. print out every element of this list
for(e <- mixed) println(e)


//Q. using a range, print out "Ho!" three times 

// Q. print out s"you're allowed in ${name}"
val people = List("Michael 10", "John 20", "Watson 40")

for(person <- people;
   if person.split(1).toInt >= 18
) println(s"you're allowed in ${person.split(" ")(0)}")

//OR,

for(person <- people;
    name = person.split(" ")(0)
) println(s"you're allowed in ${name}")


// HINT: .split 

//Q. define ages, a Vector[Int] of the ages 
//HINT: .split .toInt 

val ages = for(person <- people) yield person.split(" ")(1).toInt 

// Q. determine the average age
//HINT: use a var total 

var total = 0
for(age <- total) total += age

println(s"The average age is ${total/ages.length}")


// EXTRA
// Q. print out s"you're allowed in ${name}" for all the the adults

for(person <- people) println(s"you're allowed in ${person.split(" ")(0)}")

// Q. use a for-comprehension to create a sequence of 5 '.'s called row
// HINT: the input must be the same length as the output, in this case
val row = for(i <- 1 to 5) yield '.'

// Q. print out row on one line 
//HINT:  use print()
for(cell <- row) print(cell)

// Q. use a for-comprehension to create a sequence of 5 rows called grid
// Q. print out grid

// REVIEW: What did you learn from this exercise?