// CHAPTER 8:  TRAITS AND INHERITANCE
// PROBLEM:   Use inheritance to define relationships between kinds of people.
// PROCESS:   Demonstration & Discussion
// EXP?       Inheritance, Interfaces, Mixins
// USE?       Tools for design: describing relationships between types.

// PART 1 -- INHERITANCE

{
  // INHERITANCE  -- A TYPE RELATION
  class Animal
  class Mammal extends Animal

  val pig = new Mammal

  pig.isInstanceOf[Animal]
  pig.isInstanceOf[Mammal]

}

{
  //INHERITANCE -- CLASS RELATIONSHIP

  class ElectricItem {
    def switchOn() = println("turning on...")
  }

  class iPad extends ElectricItem {
    def changeBrightness() = println("Changing brightness")
  }

  val myipad = new iPad

  myipad.switchOn()
  myipad.changeBrightness()

}


{
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
}

{
  //OVERRIDING toString

  class Person(val name: String, var age: Int) {
    override def toString = s"Person(name: $name, age: $age)"
  }

  println(new Person("Bertrand Russell", 97))
}

{
  // CONSTRUCTING PARENTS
  class Point(val x: Int, val y: Int) {
    override def toString = s"<$x, $y>"
  }

  class WeightedPoint(xw: Int, yw:Int, ww: Int) extends Point(xw * ww, yw * ww)

  val start = new Point(0,0)
  val next  = new WeightedPoint(10, 10, 5)

  println(start)
  println(next)
}


{
  //CALLING THE PARENT METHOD
  class American {
    def speak() = println("I'd like some ")
  }

  class NorthAmerican extends American {
    override def speak() = { super.speak(); print(" lemonade") }
  }

  class NewYorker extends NorthAmerican {
    override def speak() = { super.speak(); print(" soda") }
  }


  val john = new American()
  val sue = new NewYorker()

  john.speak()
  sue.speak()
}



{
  // ABSTRACTS
  abstract class BankAccount(var balance: Double) {
    def convert(incoming: Double): Double

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

  class Cat(n: String, a: Int) extends Animal(n, a) {
    override def toString = s"Cat(name: $name, age: $age)"
    def move = "pounce"
  }
}

{ // ABSTRACTS as TYPES

  abstract class Animal
  class Dog extends Animal
  class JackRussel extends Dog

  val a: Animal = new Dog
  val wz = new JackRussel

  println(a.isInstanceOf[Dog])
  println(wz.isInstanceOf[Animal])
}

/* EXERCISE */



// PART 2 -- TRAITS 

{
  // TRAITS
  trait Walkable {
    def walks: String
  }

  class Alice extends Walkable {
    def walks = "Alice Walks"
  }

  (new Alice).walks
}


{
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
}

{
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
}

{
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
}


{
  // TRAITS AS MIXINS
  // slice of functionality *without* state
  trait Speak {
    def name(): String                                  //abstract
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
}

// THE MEANING OF SEALED

// sealed == final except for the file

{
  // ASIDE: TYPE MEMBERS
  abstract class MyContainer {
    type Index = Int
    type Element

    def get(position: Index): Element
  }

  class MyCollection(val arr: Array[String]) extends MyContainer {
    type Element = String

    def get(position: Index): Element = arr(position)
  }
}