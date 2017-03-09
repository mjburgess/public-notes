// CHAPTER 3:  FLOW
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// PART 1 -- BRANCHING AND MATCHING
// CONDITIONALS 
val age = 27
val name = "Michael John Burgess"

if(age >= 18 && name.contains("John")) {
    println("You're an adult, John!")
} else {
    println("You're a child, John!")
}

val message = if(age < 21 && name.startsWith("Michael")) {
    "Go home, Michael!"
} else {
    "Come in, Michael!"
}

// simple example
val anotherMessage = if(true) { "25 "} else { 25 }

println(message)


// INTRO TO PATTERN MATCHING 
val name = "Sherlock"
val location = "London"

val message = name match {
    case "Sherlock" => "Good Evening, Holmes!"
    case "Watson"   => "Hello, Dr. Watson"
    case _ => "Bonjour!" 
}

println(message)
Good Evening, Holmes!

println(location match {
         case "UK" => "Welcome to the UK"
         case _    => "I'm afraid I do not speak that language!" 
      })


// destructuring match 


val (wname, wlocation) = List("Winston", "London")
val (jname, jlocation) = ("Jefferson", "Virginia")







//PART 2 -- FOR COMPREHENSIONS 
for(c <- "Hello") println(c)

// unitary
for( letter <- "Michael") {
     println(letter)
}

// expression 
val letters = for ( letter <- "Michael") yield letter  + 1

// ASIDE: OPTION 

val x: Any = 5
val y: Any = "X"        // Any = String | Int
val y: Int = 5


// COMPREHENSIONS OVER LISTS 
val names = List("Sherlock", "Jefferson", "Washington")

for (n <- names) {
    println(n)
}

val uNames = for (n <- names ) yield n.toUpperCase

println(uNames)


// COMPREHENSIONS OVER MAPS
val people_locations = Map(
    "Sherlock" -> "London",
    "Jefferson" -> "Virginia"
)

for( (name, location) <- people_locations) {
    println(s"${name} was born in ${location}")
}

val locations = for( (name, location) <- people_locations) yield location

println(locations)


// COMPREHENSIONS OVER RANGES
val range = 1 to 10

val numbers = for(i <- 1 to 5) yield i

for(i <- 1 to 5) println(i)
for(j <- 10 until 50 by 10) println(j)
for(z <- 100.to(200).by(50)) println(z)


val ages = for(
    age <- 18 to 19
    if age % 2 == 0
) yield age


// MULTIPLE EXTRACTION
val names = List(
    "Michael Burgess".split(" "),
    "Michael Holmes".split(" "),
    "Sherlock Holmes".split(" ")
)

for(
    parts <- names;
    part <- parts
) println(part)

println(    
    for(
        parts <- names;
        part <- parts
    ) yield part
)

for(x <- "ABCDEF"; y <- 0 until 6) yield x + y.toString


/*
for(n <- names) yield n.toUpperCase
*/


// GUARDS
println(    
    for(
        parts <- names;
        part <- parts
        if part[1] == 'Holmes'
    ) yield part
)

val myInts = for(
  x <- 1 to 100

  if x % 2 == 0
  if x < 50
) yield x


// RANGES 
1 to 5 by 2
1.to(5).by(2)

for(x <- 1 to 10 by 2) println(x * 2)

val numbers = 1 to 10 toArray

println(numbers)



// LET EXPRESSIONS
val people = List("Michael Burgess", "John Doe", "Jane Doe")

val doeNames = for(
  person <- people;                         //semi-colon required...
  lastName = person.split(' ')(1);

  if lastName == "Doe"
) yield person


// OTHER LOOPS
var population = 0
population: Int = 0

while(population < 10) {
    population += 1
}

println(population)



var line = ""
while(line != "q") {
    line = scala.io.StdIn.readLine("Message? ")
    
    if(line == "damn") {
        line = "q"                  // there are no break/contiue keywords 
    } else {
        println(line)
    }
}


// ASIDE: THE TYPE OF A FOR COMPREHENSION

val str  = for(c <- "Hello World") yield c
val chrs = for(c <- "Hello") yield c + ""

/*
* the first case defines an immutable ordered sequence of characters (ie. a `String`)
* the second case defines an immutable ordered sequence of strings (ie. a `Vector` of `String`s)
*/
