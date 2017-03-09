// CHAPTER 7:  Object Orientation
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 


// PART 1 -- "CLASS"s

// RECALL: ALL VALUES ARE OBJECTS
val name = "Jefferson"                  // Q. what does name refer to? A. an object 

//objects have:
println(name)                           // state
println(name.getClass.getSimpleName)    // objects have a principle type (containers do too)

println((name.getClass.getMethods map { _.getName }).toSet) // valid messages, ie. methods
println(name.hashCode)                  // a uniquely identifying property (eg., a memory addresss)



// CLASSES
// classes define a type
me = new Person 

println(me.isInstanceOf[Person])
println(me.getClass.getSimpleName)
println(me.getClass.getMethods)


//each object may have state
class Human(val name: String)

val queen = new Human("Queen Elizabeth II")
val king = new Human("Henry VIII")


println(king.name)
println(queen.name)


// every object can...
class Employee(val name: String, val id: Int) {
    def describe() = s"${name} (ID: ${id})"
}

val you = new Employee("John Doe", 101)

println(you.describe)
println(you.describe())



// all these defintions may be placed within the body 
class Counter {
    private var count = 0
    def increment() = { count += 1 }
    def value() = count
}

var c = 0

(c += 1)


// error // (c += 1) *2


// JAVA INSPECTION OF SCALA CLASSES 
class Person {
    val name : String = "Bob"
    var age : Int = 21

    def birthday = age += 1
}

// $ scalac person.scala
// $ javap Person.class


// SCALA VS JAVA
/*
* each scala file may declare a package 
* that package may define as many types (classes, traits, ..) as it wishes

* there are no access modifiers on classes nor any enforced *file* naming convention
* scalac will generate several .class files per .scala file

* for java, type defintions are usually comprised of 100+-lines and so several per file are forbidden 
* however many class definitions scala will be one line, and most under 50

* compared to java, interfaces, statics and constructors are all vary in syntax and semantics
* but are close-enough in simple cases to map to java's implementation
*/




// SIMPLE CONSTRUCTORS

class Person(val name: String, var age: Int)

class Person(val name: String, var age: Int) {
  println("Hello World")

  def x(y: Int) = y
}

new Person("Me", 100)


// AUXILIARY CONSTRUCTORS
class Database(val host: String, val user: String, val pass: String) {
    def this(user: String, pass: String) = this("localhost", user, pass)
}

val localDb = new Database("mjb", "pwd")
val remoteDb = new Database("192.0.0.2", "mjb", "pwd")



// METHOD OVERLOADING (AD HOC POLYM.)
class Room {
    val myKey = 12

    def open() = println("The Door Rattles!")

    def open(theirKey: Int) = println(
        if (theirKey == myKey)
            "The Door Opens!"
        else "The Key Breaks!"
    )
}

shed.open()
shed.open(12)
shed.open(14)


// METHOD SUGAR: GETTERS AND SETTERS
val p = new Person
p.age = 10

p.age_=(10)

class Person {
      private val name : String = "Bob"
      private var _age : Int = 21

      def birthday = _age += 1

      def age = _age

      def age_=(a: Int) {
          _age = if(a < 18) 18 else a
      }
}

val me = new Person
me.age = 18

// class defintion 
// var = both getters and setters 
// val = getters 
// none = neither getters nor setters 
// private var or val = neither

// case class = default getters -- all fields public 
// class = default none -- all fields private

// OPERATOR METHODS 
class Fraction(t: Int, b: Int) {
    val top: Int    = t / gcd(t, b)
    val bottom: Int = b / gcd(t, b)

    private def gcd(x: Int, y: Int): Int =
        if (x == 0)
            y
        else if (x < 0)
            gcd(-x, y)
        else if (y < 0)
            -gcd(x, -y)
        else
            gcd(y % x, x)

    def +(that: Fraction) = new Fraction(
        this.top * that.bottom + that.top * this.bottom, 
        this.bottom * that.bottom
    )
}

var x = new Fraction(0, 1)

for (_ <- 1 to 3) x += new Fraction(3, 8)

println(s"${x.top}/${x.bottom}")


//PART 2 -- "OBJECT"S

// THE OBJECT KEYWORD
object UnitedKingdom {
    val capital = "London"
    val population = 6E7

    var immigration = 5E5
    var emmigration = 1E5

    def netImmigration = UnitedKingdom.immigration - UnitedKingdom.emmigration
}


println(UnitedKingdom.netImmigration)



// COMPANIONS
// callable companions
class Car(val _type: String)

object Car {
    def apply() = new Car("AUDI")
}

val audi = Car() // *calling* the object

println(audi._type)


// companions as factories 
object Car {
  def apply(make: String) = {
    new Car(make, true)
  }
}

class Car private (val make: String, val isSportsCar)

val c = Car()


// CASE CLASSES 
case class Item(val name: String, val rrp: Double)

val myitem = Item("A", 10)

val message = myitem match {
    case Item("B", _) => "My ITEM IS B!"
    case Item(_, _) => "My ITEM IS SOMETHING!"
}

println(message)


// PATTERN MATCHING WITH CASE CLASSES 
case class Person(val name: String, val age: Int)
case class Pet(val name: String, val age: Int)

val me = Person("Sherlock Holmes", 27)
val dog = Pet("Winston", 5)

def greeting(thing: Any) = thing match {
    case Person(name, age) => s"Hello, $name!"
    case Pet(name, age) => s"Good $name!"
} 

println(greeting(me))
println(greeting(dog))

//ASIDE: CASE OBJECTS 
sealed trait Colour     //`sealed` restricts inheritance to within the file alone
case object Red extends Colour
case object Green extends Colour
case object Amber extends Colour


def action(signal: Colour) = signal match {
    case Red => "Stop!"
    case Green => "Go!"
    case _ => "Wait!"
}

val theSignal = Amber
println(action(theSignal))
