

//1. PRODUCT
val b1: Boolean = true
val b2: Boolean = false

val x: Int = 0    // ~ 4.2billlio


val lights: (Boolean, Boolean) = (true, true)


class Lighting(val yellowOn: Boolean, val redOn: Boolean)

val l: Lighting = new Lighting(true, true)

//2. SUM TYPE

abstract class Animal
case class Dog() extends Animal
case class Cat() extends Animal

def speak(a: Animal) = if(a.isInstanceOf[Dog]) { "Woof!"
  } else if(a.isInstanceOf[Cat]) { "mewo!"} else { "??"}


val a: Animal = new Animal
val d: Dog = new Dog
val c: Cat = new Cat

println(speak(a))
println(speak(d))
println(speak(c))




def say(a: Animal) = a match {
  case Dog() => "woof"
  case Cat() => "meow!"

}

println(say(d))




