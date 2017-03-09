// 1. inheritance is OR-type relationship
class Animal
class Mammal extends Animal

val pig = new Mammal
val unknown = new Animal

pig.isInstanceOf[Animal]
unknown.isInstanceOf[Mammal]

// type Animal = Mammal | Animal

var cat: Animal = new Mammal


//2.
class ElectricItem {
  def switchOn() = println("tunrning...")
}

class iPad extends ElectricItem {
  def changeBrightness() = println("dimming...")

  override def switchOn(): Unit = super.switchOn()
}


val myi = new iPad
myi.switchOn()
myi.changeBrightness()


