// CHAPTER 1:  INTRODUCTION
// PROBLEM: 
// PROCESS:
// EXP? Scala?
// USE? High-level understanding of scala, scalac, repl. 

// WHY SCALA?

// powerful 
val services =  scala.io.Source.fromFile("/etc/services") // """C:\Windows\System32\drivers\etc\services"""

val inUsePorts = (for (
    line <- services.getLines;
    port <- """\d+""".r.findFirstIn(line)
) yield port.toInt).toSet

val freePorts = Set(1 to 200: _*) &~ inUsePorts



// libraries 
//eg., futures
Future { 
    Thread.sleep(500)
    List("Sherlock Holmes", "Thomas Jefferson") 
} map { 
    _ map { _.toUpperCase } 
} map { 
    println(_)                                             // modified data
}  

// static typing 
val name = "Michael"            // statically inffered
var age = 27

def describe(name: String, age: Int) = s"${name} (${age})"          // functions as in->out

println(describe(name, age))  

// Q. what is the advantage of static typing?
// A. compiler checkes correctness of program 


// compositional syntax
println(
    describe(name, age)  + " is " + (
        if(age >= 18) { "allowed in" } else { "not allowed in" }
    )
)


// oo design easier 
class Person(val name: String, val age: Int) {
    def describe() = s"${name} (${age})"
}

println(new Person("Sherlock Holmes", 27).describe())



// functional 
// json example  -- http://jsonplaceholder.typicode.com/users
val people = List(
    Map("id" -> 1, "name" -> "Sherlock", "address" -> "London, United Kingdom"),
    Map("id" -> 2,  "name" -> "Jefferson", "address" -> "Virginia, United States")
)

println( people map { p => p("name")} mkString ", ")




// OBJECT ORIENTED PROGRAMMING
// imperatives 
var age = 26 

age += 1                            // action

println(age)

// procedural 
var my_age = 27

def show_next_age(age: Int) {       // action
    age += 1
    println(age)
}


// objects recieve messages: state + behaviour
class Human(var age: Int) {
    def grow_older() {
        age += 1
    }

    def describe() {
        println(age)
    }
} 

val me = new Human(27)

me.grow_older()                       // actions 
me.describe()                          // ugly!
 


// FUNCTONAL PROGRAMMING

// functions vs. procedures 
val age = 27

def grow_older(age: Int) = age + 1      // expression 

val new_age = grow_older(age)           // beautiful!

println(new_age)


// referential transparency 
val new = 27 + 1                        // beautiful!

println(new_age)

// vs. 
val you = new Human(27)

me.grow_older()                       //  CANNOT BE REPLACED!
me.describe()




// DUALITY OF OO & FUNCTIONAL

// basic flaw in imperative programming is state 
var population = 1000

println(population)

population *= 2

println(population)



// reuse object metaphors without state 
class Country(val population: Int)

val now_country = new Country(1000)
val then_country = new Country(now_country.population * 2)

println(now_country)
println(then_country)


//or,
val countries = List(Country(1000), Country(2000))


println(countries map { _.population * 2 })
println(countries)                      // old value still around 



// Anantomy of Scala Programs (GENERAL)
//$ scalac myapp.scala && scala MyApp
object MyApp extends App {
    println("Hello World")
}



// Anantomy of Scala Programs (JAVA)        -- EXERCISE 
//$ scalac main.scala
//$ javap HelloWorld.class
object HelloWorld {
        def main(a: Array[String]) {
            println("Hello World!")
        }
}



// REPL 
// :help
// :paste 

// TRY THE REPL
val name = "Michael"
var age = 27

println(name + " is " + age)

if(age >= 18) {
    println("You're allowed in!")
} else {
    println("You're not allowed in!")
}

def describe(name: String, age: Int) = s"${name} (${age})"

println(describe(name, age))

println(
    describe(name, age)  + " is " + (
        if(age >= 18) { "allowed in" } else { "not allowed in" }
    )
)





// SCALAC ! 
// programs are typically compiled for jvm (jvm intermediate byte code)
// jvm installed on target system 


// scalac --help


// next compiler: dotty

// SCALA INTERPRETER 

// scala linear.sc


// IDE
/*
    scala worksheets demo
*/

// SBT  
/* build file demo */

/* console demo */
//$ sbt
//> console


// Documentation 
// scala-lang.org
// books: Scala 3E, PRogramming Scala