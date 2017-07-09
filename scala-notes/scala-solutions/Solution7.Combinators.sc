// CHAPTER:   7. COMBINATORS
// OBJECTIVE: Answer the following questions.
// PROBLEM:   Use combinators to analyse some names and ages.
// TIME:      20 m

// COMBINATORS & PREDICATES
val names = List("Sherlock Holmes", "Michael John Burgess", "Thomas Jefferson", "Alex Hamilton")
val ages = List(30, 40, 50)

//Q. use foreach to print every name
names foreach { println _ }

//Q. with names, print using map:
//... obtain a list of the length of each name
//... obtain a list of bools, whether the name .isEmpty
//... obtain a list of the last names
println(names map { _.length }))
println(names map { _.isEmpty })
println(names map { _.split(" ").last })

//Q. is the last name of all of the people, >7 chars long?
//Q. does any one in your list of names have a middle name?
//HINT: forall exists
//HINT: .split .last .length

println( names forall { _.split(" ").last.length > 7 } )
println( names exists { _.split(" ").length > 2 } )

//EXTRA

//Q. using reduce, get the average age
val total = ages reduce { _ + _ }
println(s"The average is ${total/ages.length}")

// Q. get a list of birth years from the list of ages
// HINT: map
val years = ages map { 2017 - _ }

//Q. use foldLeft to join all the names/ages in sequence (ie., Sherlock Holmes 30, Thomas ...)
println(na.foldLeft("")( (acc, kv) => acc + kv._1 + kv._2))

// Q. use a for comprehension to get the same results as the above questions


// REVIEW: What did you learn from this exercise?