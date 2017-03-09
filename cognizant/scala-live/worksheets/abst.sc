
// Q. create an abtract class Animal(var weight: Double)
// which has an eat() and a walk() method
// the walk method accepts a distance: Int,
// the eat method accepts a amount: Int
// the eat method increases the weight of the animal
// the walk method is undefined/abstract

abstract class Animal(var weight: Double) {
  def eat(amount: Int) = weight += amount
  def walk(distance: Int): Unit


// Q. create a class Human which extends Animal(100)
// it walks weight * distance feet -- eg., prints "walking...", distance

class Human extends Animal(100) {
  def walk(distance: Int) = println(s"Walking ${weight * distance} ft")
}

// Q. create a class Bird which extends Animal(10)
// it walks weight * distance * 100 feet

class Bird extends Animal(10) {
  def walk(distance: Int) = println(s"Walking ${weight * distance * 100} ft")
}

//Q. create a bird, and a human
// have them eat something
// have them walk a distance

var b = new Bird
var h = new Human

b.walk(10)
h.walk(10)

abstract class Room {
  def setup(): Unit = {
    println("Seeting up")
    changeThermo(69)
  }

  def changeThermo(f: Int)
}
class YellowRoom extends Room {
  def changeThermo(f: Int) = println(f)
}


class GreenRoom extends Room {
  def changeThermo(f: Int) = println(f - 20)
}


