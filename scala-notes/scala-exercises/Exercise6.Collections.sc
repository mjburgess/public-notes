// CHAPTER:   6. COLLECTIONS
// OBJECTIVE: Answer the following questions.
// PROBLEM:    Use collections to analyse information about animals and ports.
// TIME:       25 m


// FOR COMPREHENSIONS REVIEW
//Q. for each author, print their name
val authors = List("Matt", "Mark", "Luke")

//Q. for each pair animal/kind print s"$animal is a $kind"
val animalTypes = Map("Cat" -> "Mammal", "Raven" -> "Bird")

// Q. from animalTypes make a new list of strings called dict
// formatted as "Cat: Mammal"

//Q. print dict

// BUFFERS
//Q. define dictBuffer using an ArrayBuffer
//ie., define an ArrayBuffer[String] of s"$animal: $kind"
import scala.collection.mutable.ArrayBuffer

//Q. print the arraybuffer

// SETS and RANGES
//Q. print all the closed ports
val ports = (1 to 200).toSet
val openPorts = Set(80, 22)


//Q. is port 100 closed?
//HINT: .contains

// ZIPPING
//Q. loop over names and cols at the same time,
// print an element from each
val names = List("Michael", "Mark", "Tim")
val cols = Array("Purple", "Green", "Blue")


//Q. print out all the colours with their index
//HINT: .zipWithIndex


// CONVERTING BETWEEN TYPES OF COLLECTION
//Q. convert letters to a list and print it
val letters = "ABCD"

//Q. convert countries to a set and print it
val countries = List("UK", "UK", "US")


//Q. convert person to a map and print it
val person = List( ("name", "sherlock"),  ("email", "s@example.com") )
println(person.toMap)


// RECURSION
// the hasEmpty method determines if any element of a list of strings
// is empty
def hasEmpty(data: List[String]): Boolean = data match {
  case head :: tail => head.isEmpty || hasEmpty(tail)
  case Nil => false
}

println(hasEmpty(List("", "Sherlock", "London")))
println(hasEmpty(List("30", "Sherlock", "London")))


//Q. define a recursive function which produces
// a comma-separated list of the first names of this list of people
val people = List("Sherlock Holmes", "Thomas Jefferson", "Elizabeth II")

//EXTRA

// Q. revise the definition of hasEmpty to create a new method any
// any should accept two parameters, data and a function (Boolean, String) => Boolean
// it should combine head with tail using this function, rather than with ||


//Q. use any to determine if a list of strings is empty

// REVIEW: What did you learn from this exercise?