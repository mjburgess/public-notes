
val age = 27
var myAge = 27

// age += 1

val string = new StringBuilder("Hello")
string.append("World")

println(string)

age.getClass
"hello".getClass

age.isInstanceOf[Int]
"hello".isInstanceOf[String]

age.isInstanceOf[Any]

class Mammal
class Person extends Mammal {

}

val me = new Person

me.isInstanceOf[Person]
me.isInstanceOf[Mammal]
me.isInstanceOf[Any]