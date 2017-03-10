
class Animal(val name: String)
class Cat(name: String, owner: String) extends Animal(name: String)

val cats: List[Animal] = List(new Cat("Fluffy", "Tim"), new Cat("Tabs", "Tim"))


class Dog(name: String, owner: String) extends Animal(name: String)

class Person[+A](val pet: A) {
  override def toString = s"Person()"
}

val myList = List(1, 2, 3) ++ List(1.0, 2.0, 3.0)


val catOwners = List(new Person(new Cat("Fluffy", "Michael")))
val animalOwners = catOwners ++ List(new Person(new Dog("Spot", "Tim")))