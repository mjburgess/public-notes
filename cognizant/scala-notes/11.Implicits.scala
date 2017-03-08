// CHAPTER 11:  IMPLICITS & IMPORTS
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// PART 1 -- IMPORTS

// packages
package Outer {
  package Inner {
    case class Person(val name: String)
  }
}

import Outer.Inner

object Application {
	def main(a: Array[String]) = println(Outer.Inner.Person("Mycroft"))
}



// import 
package com

package object qa {

    def say() = println("Woof")

    object Library {
        import scala.collection._
        class Door
        object Books {
            class Page
        }
    }

    object API {
        import com.qa.people
        import com.qa.people.workers
        import com.qa.finance
    }
}


// braces 

package Outer
package Inner

case class Node(val weight: Int)

import Outer.Inner

object Application {
	def main(a: Array[String]) = println(Outer.Inner.Node(10))
}

// PART 2 -- IMPLICITS

/*
* implicit parameters are execution contexts (eg. types)
* implicit functions are capabilities
* implicit classes are abstractions over types (type classes)
*/


// IMPLICIT CONVERSIONS
implicit def stringToInt(s: String): Int = s.length         //capability?

val x: Int = "Michael"          // crazy!



// let's add methods to string objects...

// String can be converted to ImprovedString   (read R2L)
implicit class ImprovedString(s: String) {
    def describe() = println(s"${s} ${s.length}")
}

"22B Baker St".describe



//... this is actually what scala does to add StringOps to strings...



// let's add methods to every object... 
// A can be converted to SpaceShip[A]       -- the generic here says forall types
implicit final class SpaceShip[A](val self: A) {
    def <-*-> [B](y: B) = self -> y
}

// converted to a SpaceShip because <-*-> exists on SpaceShips
// then <-*-> is called

val m = Map("one" <-*-> 1, "two" <-*-> 2)



// IMPLICIT PARAMTERS

implicit val prefix = "Logging: "

def myPrinter(s: String)(implicit prefix: String) = println(prefix + s)

myPrinter("Hello")


// as "contexts"


class Configuration(val host: String, val user: String)

implicit val ukContext = new Configuration("UK", "Sherlock")

def connect(pass: String)(implicit c: Configuration) = println(s"connecting to ${c.host} (u: ${c.user}, p: ${pass})")


// explicit is possible:

connect("test")(new Configuration("US", "Washington"))


// IMPLICTLY !




//context bound is written  [A : B]
//there must be an implicit value of type B[A] available
//the type on the RHS of a context bound must be generic.



trait Payment {
    def amount: Double
}

class UkDoctorSalary extends Payment {
    def amount = 40000.0
}

class UsSpeedingFine extends Payment {
    def amount = 80.0
}

class UkConverter[T](val ratio: Double)

implicit val ukcDR = new UkConverter[UkDoctorSalary](1)
implicit val ukcSF = new UkConverter[UsSpeedingFine](1.3)

def pay[T <: Payment](p: T)(implicit c: Currency[T]) = p.amount * c.ratio



def _pay[T <: Payment : Currency](p: T) = p.amount * implicitly[Currency[T]].ratio


pay(new UsSpeedingFine)


// academic exmaple 
import math.Ordering

case class MyList[A](list: List[A]) {
  //named
  def sortBy1[B](f: A => B)(implicit ord: Ordering[B]): List[A] =
    list.sortBy(f)(ord)

  //annoymous
  def sortBy2[B : Ordering](f: A => B): List[A] =
    list.sortBy(f)(implicitly[Ordering[B]])
}

val list = MyList(List(1,3,5,2,4))

list sortBy1 (i => -i)
list sortBy2 (i => -i)




// TYPE CLASSES

// some classes
case class Address(street: String, city: String)
case class Person(name: String, address: Address)

// we want to be able to add methods to these classes after defintion 
// *and* type 

// the typeclass 
trait Jsonable {
  def toJSON(): String
}

implicit class AddressToJSON(address: Address) extends Jsonable {
  def toJSON(): String = s"""{"street": "${address.street}", "city": "${address.city}" }"""
}

implicit class PersonToJSON(person: Person) extends Jsonable {
  def toJSON() = s"""{
      "name":    "${person.name}",
      "address": ${person.address.toJSON}
    }"""
}

val ldn22B = Address("22B Baker Street", "London")
val sherlock = Person("Sherlock Holmes", ldn22B)

println(sherlock.toJSON())


def send(o: Jsonable) = println(o.toJSON())     // wow! ad hoc polymorphism!

send(ldn22B)


// USING IMPLICITS IN PRACTICE

// wrap everything up
object Implicits {
    implicit def stringToInt(s: String): Int = s.length     // locked into this scope
} 

//explict about using them 
import Implicits.stringToInt