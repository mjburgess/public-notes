// CHAPTER 9:  GENERICS & COLLECTIONS 
// PROBLEM: 
// PROCESS:
// EXP?
// USE?

//PART 1 -- GENERICS 

// TUPLES AS OBJECTS
val mytuple = (1, "Hello", false)

mytuple: (Int, String, Boolean) = (1,Hello,false)

mytuple._3

val person = ("Michael", 26)
person: (String, Int) = (Michael,26)

val person = new Person("Michael", 26)

// arrow syntax 
1 -> 2

(0,0) -> 0

Set(0 -> 0, 1 -> 2, 2 -> 3)


// type aliasing tuples 
(1, "Hello", false) : (Int, String, Boolean)

type WebSite = (String, String, String)

val eg : WebSite = ("Example Site", "A website used for examples", "http://www.example.co.uk")

eg

// ALGEBRAIC DATA TYPES

class Animal
class Dog extends Animal
class Cat extends Animal

val what = new Animal
val fido = new Dog 
val fluffy = new Cat 

def speak(a: Animal) = if(a.isInstanceOf[Dog]) { "Woof!" } else if (a.isInstanceOf[Cat]) { "Meow!" } else { "..." }

speak(fido)
speak(fluffy)
speak(what)

// Animal = Dog | Cat | Animal 



// DEFINING AND USING ALGEBRAS

abstract class Animal
class Dog extends Animal
class Cat extends Animal

//pseudo-code equivalent
// type Animal = Cat OR Dog

// thus we may only have
val myAnimal : Animal = new Cat
val myAnimal : Animal = new Dog



// EXAMPLE: LOGICAL OPERATORS 

//sketch
abstract class LogicExpr

class T() extends LogicExpr
class F() extends LogicExpr

class And(val l: LogicExpr, val r: LogicExpr) extends LogicExpr
class Or(val l: LogicExpr, val r: LogicExpr) extends LogicExpr

val myX : LogicExpr = And(T(), And(F(), Or(T(), F())))



// in full 
abstract class LogicExpr {
    def meaning: Boolean
}

class T() extends LogicExpr {
    def meaning = true
}

class F() extends LogicExpr {
    def meaning = false
}

class And(val l: LogicExpr, val r: LogicExpr) extends LogicExpr {
    def meaning = l.meaning && r.meaning
}

class O(val l: LogicExpr, val r: LogicExpr) extends LogicExpr {
    def meaning = l.meaning || r.meaning
}


val myA : LogicExpr = And(T(), And(F(), Or(T(), F())))
val myO : LogicExpr = Or(T(), And(F(), Or(T(), F())))

println(myA.meaning)

// TYPE ARGUMENTS
val drinks = List("Coke", "Pepsi")
val ages: List[Double] = List(1, 2, 3)



// DEFINING GENERIC TYPES 
class Person[A](id: A)

val mike = Person[String]("Michael")

val dbuser = Person[Int](1001)


// VARIANCE 
class Animal(val name: String)
class Cat(name: String, owner: String) extends Animal(name: String)

val cats: List[Animal] = List(new Cat("Fluffy", "Tim"), new Cat("Tabs", "Tim"))


class Dog(name: String, owner: String) extends Animal(name: String)

class Person[+A](val pet: A) {
    override def toString = s"Person()"
}

val myList = List(1, 2, 3) ++ List(1.0, 2.0, 3.0)


val catOwners = List(new Person(new Cat("Fluffy", "Michael")))
val dogOwners = List(new Person(new Dog("Spot", "Tim")))

val animalOwners = catOwners ++ dogOwners

dogOwners

catOwners

animalOwners

// TYPE BOUNDS 


class Add[A, B](val x: A, val y: B)

val a = new Add[Int, Double](1, 2.0)
println(a.x + a.y)

abstract class ID
class NI extends ID
class Role extends ID
class Paye extends NI

class Person[I](val id: I)

val me: Person[NI] = new Person(new Paye)
val you = new Person[Role](new Role)

def display[I <: NI](id: I) = id






// PART 2 -- COLLECTIONS

// *COLLECTIONS DIAGRAM*

/*
The Traversable “implements the behavior common to all collections in terms of a foreach method,
Iterable trait defines an iterator, which lets you loop through a collection’s elements one at a time
An IndexedSeq indicates that random access of elements is efficient
A LinearSeq implies that the collection can be efficiently split into head and tail components
 Scala Map is a collection of key/value pairs, where all the keys must be unique. T
*/


// CREATING COLLECTIONS 

import scala.collection.immutable._

Traversable(1, 2, 3)                    // foreach: filter, ..
Iterable("x", "y", "z")                 // for(e <- xs)

IndexedSeq(1.0, 2.0)                    // fast xs(i)
LinearSeq("A", "B", "C")                // fast xs.head

Map("x" -> 24, "y" -> 25, "z" -> 26)    
Set('R', 'G', 'R', 'B')
SortedSet("hello", "world")


// RANGE 
val rangeInt = 1 to 10 by 2

val rangeDouble = 1.0 to 5.0 by 0.2

val rangeChr = 'a' to 'z'

('a' to 'z').toList

1 to 10 by 2

1.0 to 5.0 by 0.2

('a' to 'z')

'A' to 'Z'

'a' to 'Z

'a' to 'z' by 2
'0' to '9'
('0' to '9').toList



// ARRAY & ARRAY BUFFER
import scala.collection.mutable.ArrayBuffer

val ab = new ArrayBuffer[String]

ab += "Michaael"
ab += "Michaael"
ab += "Michaael"




// LIST & LIST BUFFER

import scala.collection.mutable._

val names = List("Michael", "Sherlcok", "Watson")
val mutNames = ListBuffer("Michael", "Sherlock", "Watson")

val numbers = Seq(1,2,3)


println(names)






(for(c <- 'a' to 'z') yield c + 1).toList


(for(c <- 'a' to 'z') yield c + 1).toList.mkString

"UK" :: "FRANCE" :: "US" :: Nil


def f(start: List[Int]) =  1 :: start

List.empty
List.empty == Nil


List.fill(3)("foo")
"foo".toList



// VECTOR 
// the best, typical-use-case collection 

val names = Vector("Fluffy", "Spot", "Fido")
val letters = for(c <- 'a' to 'z') yield c + 1
val cent = 100 +: Vector.empty
val dbl  = 200 +: 100 +: Vector.empty

for (name <- names) println(name)


// MAPs  
val point = 0 -> 1

println(point._0)
println(point._1)

val prefs = Map("Michael" -> "DrPepper", "Adam" -> "Coffee")

println("x" -> "y")

println(prefs)
println(prefs("Michael"))
println(prefs - "Michael")

val nextprefs = prefs - "Michael"


val preferences = Map(
    "Michael" -> List("Coke", "Pepsi"),
    "Tim" -> List("Apple Juice", "Water")
)

preferences + ("Lucie" -> List("Beer", "Wine"))

prefer
preferences("Michael") = List("Apple", "Banana")
preferences += ("Lucie" -> List("Beer", "Wine"))
preferences.keySet()

val value: Option[List[String]] = preferences.get("Susan")

for ((person, preference) <- prefs) println(person, preference)

for (pair <- prefs) println(pair)


// SETS 

val people = Set("Adrian", "Michael", "Sherlock")
val good = Set("Michael")
val bad = Set("Adrian")

people & good
people &~ bad

val names = List("Michael", "Michael", "Sherlock")

names.toSet
names.toSet &~ good

(names.toSet &~ good).toList



for (person <- people) println(person)

val services =  scala.io.Source.fromFile("""C:\Windows\System32\drivers\etc\services""")

val inUsePorts = (for (
    line <- services.getLines;
    port <- """\d+""".r.findFirstIn(line)
) yield port.toInt).toSet

val freePorts = Set(1 to 200: _*) &~ inUsePorts







// PART 3 -- COLLECTIONS IDIOMS

// CONVERTING BETWEEN TYPES OF COLLECTION 
"ABCD".toList
Map("S" -> 1, "A" -> 2).toList
List("UK", "UK", "US").toSet
List( List("name", "email"),  List("sherlock", "s@example.com") ).toMap 

(0 to 10).toList
(0 to 10).toArray

// EMPTY 
Nil

List.empty

List.empty[Int]

Seq.empty[Int]

Vector.empty[Int]

Map.empty[String,String]


// FOR COMPREHNSIONS REVIEW 
for(person <- List("Matt", "Mark", "Luke")) println(person)
for(pair <- Map("Cat" -> "Mammal", "Raven" -> "Bird")) println(pair)
for((animal, kind) <-  Map("Dog" -> "Mammal", "Crow" -> "Bird")) println(s"$animal is a $kind")


// FOR COMPREHNSIONS AS TRANSFORMATIONS
val simple = for(
    (animal, kind) <- Map("Dog" -> "Mammal", "Crow" -> "Bird")
) yield kind + ":" + animal


// ZIPPING
val names = List("Michael", "Mark", "Tim")
val cs = Array("Purple", "Green", "Blue")

 for((name, c) <- names.zip(cs)) println(s"$name is assigned $c")

names zip cs

names.zip(cs).toMap
    Map(Michael -> Purple, Mark -> Green, Tim -> Blue)


// with index
for((letter, index) <- alphabet.zipWithIndex) println(s"$letter is the ${index + 1}th letter of the english alphabet")

// TRAIT FACTORIES 

val orderedSupplies = Seq("Apertif", "Soup", "Starter", "Main Course", "Dessert", "Coffee", "Digestif")
val randomSupplies = IndexedSeq("Food", "Water", "Shelter")

randomSupplies

orderedSupplies


