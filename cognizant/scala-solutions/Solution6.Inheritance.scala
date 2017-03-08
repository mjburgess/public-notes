//Q. define a generic class Person with properties name, age A, height H

class Person[A, H](val name: String, val age: A, val height: H)

//Q. define a function getDetails that calls scala.io.StdIn.readLine
//.. expecting an input  michael,27,1.81
//.. the function should return an Option of Person
//ie., None if the details arent correct
//HINT: .size should be 3

def getDetails() = {                // : Option[Person[Int, Double]]
    println("enter details:")
    val details = scala.io.StdIn.readLine().split(",")

    if(details.size == 3) {
        Some(new Person[Int, Double] (
                details(0),
                details(1).toInt,
                details(2).toDouble
            )
        )
    } else {
        None
    }
}

//Q. extract a person from getDetails in a for comprehension,
//.. print the name, age and height

for(p <- getDetails) println(s"${p.name} is ${p.age} and ${p.height}")


// PART 2

// 1. define a trait Talker that has a speak method that println's "Hello"

trait Talker {
    def speak = println("hello")
}

// 2. define a class Dog which extends from this trait and overrides speak to println
//.. "woof"

class Dog extends Talker {
    override def speak = println("Woof")
}

// 3. define a class Person

class Person

// 4. create a List of Talkers which contains Person and Dog objects

val talkers = List(
    new Person with Talker,
    new Dog
)

// 5. define a function say() which takes a List of Talkers
//.. it should iterate through this list and ask each to speak

def say(ts: List[Talker]) = for(t <- ts) t.speak

say(talkers)
