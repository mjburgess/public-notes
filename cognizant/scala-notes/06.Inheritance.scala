// CHAPTER 6:  TRAITS AND INHERITANCE
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// PART 1 -- INHERITANCE

// INHERITANCE 
class Animal 
class Mammal extends Animal

pig = new Mammal

pig.isInstanceOf[Animal]
pig.isInstanceOf[Mammal]



class ElectricItem {
    def switchOn() = println("turning on...")
}

class iPad extends ElectricItem {
    def changeBrightness() = println("Changing brightness")
}

val myipad = new iPad

myipad.switchOn()
myipad.changeBrightness()




// OVERRIDING METHODS
class American {
    def speak() = println("I'd like some lemonade!")
}

class NorthAmerican extends American {
    override def speak() = println("I'd like some soda")
}

class NewYorker extends NorthAmerican {
    override def speak() = println("I'd like some pop")
}

class SouthernAmerica extends American {
    override def speak() = println("I'd like some coke")
}

val john = new American()
val sue = new NewYorker()

john.speak()
sue.speak()


// CONSTRUCTING PARENTS
class Point(val x: Int, val y: Int) {
  def moveNewPoint(dx: Int, dy: Int) = new Point(x + dx, y + dy)

  override def toString = s"<$x, $y>"
}

class WeightedPoint(xw: Int, yw:Int, ww: Int) extends Point(xw * ww, yw * ww) {
    override def toString = super.toString
}


val start = new Point(0,0)
val home = start.move(10, 10)



class Jump(x: Int, y: Int) extends Point(x * 10 , y * 10 ) {
    override def move(dx: Int, dy: Int) = super.move(dx * 2, dy * 2)
}

val jump = new Jump(2, 3)


class Person(val name: String, var age: Int) {
  override def toString = s"Person(name: $name, age: $age)"
}

println(new Person("Bertrand Russell", 97))




// ABSTRACTS 
abstract class BankAccount(var balance: Double) {
    def convert(incoming: Double)

    def withdraw(some: Double) = {
        balance -= convert(some)
    }
}

class UkBankAccount(b: Double) extends BankAccount(b) {
    def convert(incoming: Double) = incoming
}


class UsBankAccount(b: Double) extends BankAccount(b) {
    def convert(incoming: Double) = incoming * 1.4
}

abstract class Animal(val name: String, val age: Int) {
   override def toString = s"Animal(name: $name, age: $age")
   def move: String
}

class Cat(val name: String, val age: Int) extends Animal(name, age) {
  override def toString = s"Cat(name: $name, age: $age)"
  def move = "pounce"
}


abstract class Animal
class Dog extends Animal
class JackRussel extends Dog

val a: Animal = new Dog

println(a.isInstanceOf[Dog])



// TYPE MEMBERS 
abstract class MyContainer {
    type Index = Int
    type Element

    def get(position: Index): Element
}

class MyCollection(val arr: Array[String]) extends MyContainer {
    type Element = String

    def get(position: Index): Element = arr(position)
}


/* EXERCISE */



// PART 2 -- TRAITS 

// TRAITS
trait Walkable {
  def walks: String
}

class Alice extends Walkable {
  def walks = "Alice Walks"
}

(new Alice).walks

(new Alice).walks



// TRAIT INHERITANCE
trait Moveable {
    def move: String = "Moves..."
}

trait Walkable extends Moveable {
    override def move: String = "Walks..."
}

trait Talkable {
  def talks: String
}

class Bob extends Walkable with Talkable {
  def talks = "Bob Talks"
}


// COMPOSING OBJECTS WITH TRAITS 

trait Mover {
    def move(distance: Int): Unit

    def convert(miles: Int) = miles * 1.6
}

trait Eater {
    def eat(amount: Int): Unit

    def goToStore() = println("buying groceries")
}

trait Talker {
    def speak() =  println("HELLO!")
}

class Person extends Mover with Eater {
    def move(distance: Int) = println(s"moving $distance km")
    def eat(amount: Int) = println(s"eating $amount kg")
}


val me = new Person with Talker

me.speak()


// THE MEANING OF SUPER 

trait Mover {
    def move = println("Moving")
}
trait Walker extends Mover {
    override def move = { println("Walk"); super.move }
}
trait Flyer extends Mover {
    override def move = { println("Flying"); super.move }
}
trait Runner extends Mover {
    override def move = { println("Runs"); super.move }
}
trait Sprinter extends Runner {
    override def move = { println("Sprint"); super.move }
}

class FastBird extends Walker with Flyer with Sprinter

(new FastBird).move



// TRAITS AS MIXINS 


// slice of functionality *without* state 

trait Speak {
    def speak() = println("Hello! I am " + name)        // can depend on state provided by mixer
}


class Person {
    def walk() = println("Walking around...")
    def name() = "Unknown"
}

class American extends Person with Speak
class Australian extends Person with Speak


val john = new American
val kevin = new Australian

john.walk
kevin.speak


// THE MEANING OF SEALED

// sealed == final except for the file

