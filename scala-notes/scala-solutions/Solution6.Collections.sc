// CHAPTER:   6. COLLECTIONS
// OBJECTIVE: Answer the following questions.
// PROBLEM:   Use collections to analyse information about animals and ports.
// TIME:      25 m


// FOR COMPREHENSIONS REVIEW
//Q. for each author, print their name
val authors = List("Matt", "Mark", "Luke")
for(a <- authors) println(a)

//Q. for each pair animal/kind print s"$animal is a $kind"
val animalTypes = Map("Cat" -> "Mammal", "Raven" -> "Bird")
for((animal, kind) <- animalTypes) println(s"$animal is a $kind")

// Q. from animalTypes make a new list of strings called dict
// formatted as "Cat: Mammal"
val dict = for((animal, kind) <- animalTypes) yield s"$animal: $kind"

//Q. print dict
dict foreach { println _ }

// BUFFERS
//Q. define dictBuffer using an ArrayBuffer
//ie., define an ArrayBuffer[String] of s"$animal: $kind"
import scala.collection.mutable.ArrayBuffer

val dictBuffer: ArrayBuffer[String] = ArrayBuffer()
for((animal, kind) <- animalTypes) dictBuffer.append(s"$animal: $kind")

//Q. print the arraybuffer
dictBuffer foreach { println _ }

// SETS and RANGES
//Q. print all the closed ports
val ports = (1 to 200).toSet
val openPorts = Set(80, 22)

println(ports &~ openPorts)

//Q. is port 100 open?
//HINT: .contains
println((ports &~ openPorts) contains 100)

// ZIPPING
//Q. loop over names and cols at the same time,
// print an element from each
val names = List("Michael", "Mark", "Tim")
val cols = Array("Purple", "Green", "Blue")

for((n, c) <- names.zip(cols)) println(s"$n $c")

//Q. print out all the colours with their index
//HINT: .zipWithIndex

for( (i, c) <- cols.zipWithIndex ) println(s"$i $c")


// CONVERTING BETWEEN TYPES OF COLLECTION
//Q. convert letters to a list and print it
val letters = "ABCD"
println(letters.toList)

//Q. convert countries to a set and print it
val countries = List("UK", "UK", "US")
println(countries.toSet)

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

def join(people: List[String]): String = people match {
  case head :: tail => head + ", " + join(tail)
  case Nil => ""
}

join(people)

//EXTRA

// Q. revise the definition of hasEmpty to create a new method any
// any should accept two parameters, data and a function (Boolean, String) => Boolean
// it should combine head with tail using this function, rather than with ||
def any(data: List[String], f: (Boolean, String) => Boolean): Boolean = data match {
  case head :: tail => f(any(tail, f), head)
  case Nil => false
}

//Q. use any to determine if a list of strings is empty

val data = List("", "Hello")

println(any(data, { _ || _.isEmpty }))

// REVIEW: What did you learn from this exercise?