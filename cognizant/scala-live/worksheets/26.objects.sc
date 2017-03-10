// Q. define a Human class and a Human object
// the Human object should have val numEyes = 2
// the Human class' constructor should accept a numEyes
// the object's apply() method should creat a new human
// using Human.numEyes as a default
/*
class Person {
  private static x
  public bool Hello() {
    x
  }
  public static Person makePerson() {
    new Person(x)
  }
}
*/


val name = "Michael"

def formatName(name: String) = name.toUpperCase

class Human(val numEyes: Int)

object Human {
  val numEyes = 2
  def apply() = new Human(Human.numEyes)
}

//Q. create a human and print out its number of eyes

val me = Human()
println(me.numEyes)

object UK {
   val capital = "London"
   val populaton = 65
   val immigrationFlow = 0.005

   def netImmigration = populaton * immigrationFlow
}

println(UK.capital)
println(UK.netImmigration)

class CarA(val numWheels: Int)

object CarA {
  val numWheels = 4
  def apply() = new CarA(CarA.numWheels)
}


case class Car(name: String, brand: String)

val mycar = Car("Michael", "UK")

val msg = mycar match {
  case Car(name, brand) => name.toUpperCase
}

println(msg)


class Tiger(val name: String)  {
  def apply() = println(name)
}

object Tiger {
  def apply() = println("HELLO")
}

val met = new Tiger("Michael")
val ust = new Tiger("Trent")

met()
ust()

Tiger()

// mutators accessors
// instance apply vs object apply






class Person(var firstName: String) {
}

val you = new Person("Jefferson")

you.firstName = "dfdss"