//Q. define a trait Eater that provides an eat method which prints "Eating"

//Q. define a class Human which extends Eater
//Q. define a class Alien which extends Eater

//Q. define a List called eaters which includes a new Human and a new Alien

//Q. for-loop over eaters and ask each to eat


trait Eater {
  def eat() = println("Eating")
}

class Human extends Eater
class Alien extends Eater

val eaters: List[Eater] = List(new Human, new Alien)

for(e <- eaters) e.eat()

// eaters foreach { _.eat() }
