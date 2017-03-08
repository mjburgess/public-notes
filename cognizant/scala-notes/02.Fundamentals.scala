// CHAPTER 2:  FUNDAMENTALS
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// PART 1 -- VARIABLES, OBJECTS, TYPES, EXPRESSIONS

// THE LANGUAGE 
// scala programs are (primarily) expressions which connect objects 
3 + 2
 
// EXPRESSSIONS VS STATEMENTS 
val age = 27 

if(age > 18) { 
    println("Allowed") 
} else { 
    println("Not Allowed")
}


val message = if(age > 18) { "Allowed" } else { "Not Allowed" }


println( message )      // the action is delayed to the last 



// "OBJECT"S

// every value is an object 
// functions are values 
// also the 'object' keyword 

val name = "Jefferson"          // Q. what does name refer to? A. an object 

//objects have:
println(name)                           // state
println(name.getClass.getSimpleName)    // objects have a principle type (containers do too)

println((name.getClass.getMethods map { _.getName }).toSet) // valid messages, ie. methods
println(name.hashCode)                  // a uniquely identifying property (eg., a memory addresss)



// CALLING METHODS
3.+(2)
println(name.toUpperCase())
println(name.toUpperCase)           // parens group arguments, the . "sends the message", i.e., calls the method 



// METHODS FROM THE REPL 
name.

// OPERATORS AS METHODS 
// left assoc 
2 + 3
2.+(3)


//right assoc 
2 +: 3
3.+:(2)

5 +: List(1, 2, 3)


// ERRROR // 5 + List(3,4)


// DEPRECATION
readLine("Prompt? ")
// $ scala -deprecation


scala.io.StdIn.readLine("Prompt? ")

// VALUES AND VARIABLES 
val name = "Michael"
val height = 1.8
var age  = 26

// error // height += 1

age += 1

// container vs contents 
val builder = new StringBuilder("Hello ")
builder.append("World")

// changing a var 
var age = 18
age += 1

var newBuilder = new StringBuilder("Goodbye ")
newBuilder.append("World")

println(newBuilder)

newBuilder = builder

println(newBuilder)


// TYPES 
// every object has a class 

val location = "United States"          // Q. what does name refer to? A. an object 

println(name.getClass.getSimpleName)

// every container (ie., variable) has a type

val aLocation: Any = location           // the string fits into this container, because all strings are also Anys 
// belongs to multiple types 

println( name.isInstanceOf[String] )
println( name.isInstanceOf[Any] )


// THE TYPE OF EXPRESSIONS 
val isChild = if(age < 18) 1 else "Nope"

// Q.  what is the type of isChild ? A. supertype 


// REFLECTION 
import scala.reflect.runtime.universe._

val intType = typeOf[Int]
intType.baseClasses map { _.fullName }

// strings have a complex hierachy 
typeOf[java.lang.String].baseClasses map { _.fullName }


// ASIDE: THE TYPE OF EXCEPTIONS 

val x = if(true) 1 else throw new Exception("Hello")

// Q. what is the type of x? A. the type of 'throw ...' is whatever you define it to be


/** EXERCISE **/







// PART 2 -- BASIC TYPES

// ALIASING 

type Age = Int
type Name = String

def person(n: Name, a: Age) = {
    println(s"Name: $n, Age: $a")
}

// BOOLEAN
val age = 21
val name = "Fido"
val colour = "Blue"

// comparison operators 
val isAdult = age > 21
val isFido  = name == "Fido"
val isRed   = colour == "Red"


// logical operators 
println( isAdult && isRed )
println( isAdult || isRed )
println( !isAdult || isFido )

println(true  && true)
println(true  && false)
println(false && true)
println(false && false)

println(true  || true)
println(true  || false)
println(false || true)
println(false || false)



// NUMERIC TYPES 
// ints are circular
var population = 2147483647

population += 2

population


// bytes and chars
val nlByte : Byte  = 10

val nl: Char = '\n'
nl == nlByte


// UNIT
def say(message: String): Unit = println(message)

// error // say("hello")  * 2

val empty = ()
say("hello") == empty


// SYMBOLS
val option = 'Off

val choiceA = 'Off
val choiceB = 'On

option == choiceA
option == choiceB


// STRINGS
println("\tHello\n\tWorld")

// STRING INTERPOLATION
val myAge = s"I am ${18 + 8} years old!"

val name     = "Michael"
val location = "The United Kingdom"
val message  = s"$name is in $location"

println(message)


// STRING FORMATTING
val height = 1.8

val message = f"Height: $height%.2f"


// RAW STRINGS 
val path  = raw"C:\Windows\Users\Public\Documents"
val regex = raw"\b[\w|£]+\b"
val eg    = raw"a\nb"

val anotherPath = """C:\Windows\system32\Drivers\etc"""

println(path); println(regex); println(eg); println(anotherPath)


// ERROR // val stdpath  = "C:\Windows\Users\Public\Documents"

// REGEX
"""\w+""".r

raw"\w+".r

val numbers = """\d+""".r
val service = "ftps              990/tcp   #FTP control, over TLS/SSL"

numbers.findFirstIn(service)

val validate = """[^@]+@[^.]+(\.\w+)+""".r

validate.findFirstIn("invalid_email")


// STRING METHODS 

println("-" * 30)
println("HELLO" + " WORLD")

// split and join 
"Michael John Burgess".split(' ')

res5.mkString(",")

// slice 
"Michael John Burgess" split(' ') slice(1,2)

"Michael John Burgess" split(' ') slice(-1,2)

"be the change you want to see".split(" ").drop(2).takeRight(4)

// others 
val quote = "be the change you wish to see in the world"
quote: String = be the change you wish to see in the world

quote.contains("world")

quote.indexOf("change")

quote.indexOf("leader")

quote.toLowerCase

quote.toUpperCase

quote.substring(7)

quote.substring(7, 7 + 6)

quote.reverse



//PART 3 -- INTRO TO COLLECTIONS 

// tuples -- not quite collections 

val point = (10, 20)
println(point)
println(point._1)
println(point._2)


// arrays 
val locations = Array("UK", "US", "France")

println(locations(0))
println(locations.last)

// lists 
val names = List[String]("Sherlock Holmes", "Mycroft Holmes")

println(names(0))
Sherlock Holmes

println(names(1))
Mycroft Holmes

println(names)
List(Sherlock Holmes, Mycroft Holmes)

val ages = List(10, 20, 30)
ages: List[Int] = List(10, 20, 30)

// maps 
people_address = Map(
    "Sherlock" -> "London, UK",
    "Jefferson" -> "Virginia, US"
) 

println(people_address)
println(people_address("Sherlock"))
