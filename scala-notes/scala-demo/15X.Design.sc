import java.io.IOError

import scala.util.{Failure, Success, Try}

// CHAPTER 15:  THE DESIGN OF FUNCTIONAL APPLICATIONS
// PROBLEM: 
// PROCESS:
// EXP?
// USE?


// IMPORTS

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



//... !!!
//ASIDE: REFERENTIAL TRANSPARENCY
val heightM = 1.8
val height = heightM * 100
var age = 26
age += 1

println(s"I am $height cm and $age years old")


// TYPE ALIASES



//ASIDE: TYPE ALIASES
type Repeatable =  (String, String) => String

def repeat(str: String, N: Int, fn: Repeatable = (l,r) => l + r)  = {
  var result = "";

  for(i <- 0 to N) result = fn(result, str)

  result
}


//ERROR HANDLING

// 2.12 -- Either[L, R]


def getWebPage(url: String, pin: Int) =
  if(pin == 1234) {
    Success(url)
  } else {
    Failure(new Exception("Couldn't get webpage!"))
  }

def getUsername(name: String, pin: Int) =
  if(pin == 1234) {
    Success(name)
  } else {
    Failure(new Exception("Couldn't get user!"))
  }


val result = for(user <- getUsername("Michael", 134);
                 page <- getWebPage("GOOGLE", 124) ) yield user + page

println(result)


def broken() = throw new Exception("Error!")

try {
  broken()
} catch {
  case io: IOError => println("HISLDK!")
  case e: Exception => print(e.getMessage)
}

def wrap() = Try {
  broken()
}

wrap() match {
  case Success(v) => println("Successful!")
  case Failure(e) => println("HSDH")
}

// WORKING WITH MONADS
//OPTION, COLLECTIONS, etc.

// IMMUTABILITY 


class Person(var weight: Double) {
    def eat() = this.weight += 1
    def run() = this.weight *= 0.99
    def wearBelt(): Boolean = this.weight < 100  
}

val me = new Person(100) 
me.eat()
me.eat()
me.run()
me.eat()

println(if(me.wearBelt) { "It fits!" } else { "It hurts!" })

me.run()
me.run()

println(if(me.wearBelt) { "It fits!" } else { "It hurts!" })        // why on earth does this change?




// all data flow is made explicit
class Human(val weight: Double)  {
    def eat() = new Human(this.weight + 1)
    def run() = new Human(this.weight * 0.99)
    def wearBelt(): Boolean = this.weight < 100  
}


val me = new Human(100)

println(if(me.eat().eat().run().eat().wearBelt) { "It fits!" } else { "It hurts!" })        // I see that me is transformed differently
println(if(me.run().run().eat().wearBelt) { "It fits!" } else { "It hurts!" }) 




// MONIDS

// MONADS 

// CAKE PATTERN 

// DSLs 

// (APPLICATIVES, etc. )