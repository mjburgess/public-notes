
// Q. define an Item class with properties: name and rrp

class Item(val name: String, val rrp: Double)

// Q. define a ReducedItem class with properties: name, rrp, discount
//.. give ReducedItem a secondary constructor with a default discount of
// 0.1 * rrp

class ReducedItem(val name: String, val rrp: Double, val discount: Double) {
  def this(name: String, rrp: Double) = this(name, rrp, 0.1)

  def price(): Double = {
    rrp * (1 - discount)
  }
}


// Q. create a ReducedItem and print out its rrp
val ri = new ReducedItem("X", 20)
println(ri.price)



class Person
val me = new Person

me.asInstanceOf[Person]
me.asInstanceOf[Any]

class Human(val name: String) {
  def eat() = println("Yum!")
}

val president = new Human("Trump")
val queen = new Human("Elizabeth II")

println(president.name)

class Database(val host: String, val u: String, val pw: Int) {
  def this(u: String) = this("US", u, 128)
}

val db = new Database("TEST")

println(db.pw)



class Room {
  private val myKey = 123

  def open() = println("The door rattles!")

  def open(theirKey: Int) = println(
    if(theirKey == this.myKey) {
      "The Door Opens"
    } else {
      "The Door Breaks!"
    }
  )
}


val rm = new Room
rm.open()
rm.open(234)
rm.open(123)


class Animal(val name: String) {
  def +(other: Animal) = {
    name + " loves " + other.name
  }
}

val animalA = new Animal("Fluffy")
val animalB = new Animal("Spot")

println(animalA + animalB)