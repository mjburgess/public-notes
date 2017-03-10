

trait Eater {
  def eats() = println("EATING!" + weight())
}

trait Walker {
  def walks() = println("WALKING")
}

class Human

val me = new Human with Eater
val you = new Human

me.eats()