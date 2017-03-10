class Person[N, A](val name: N, val age: A) {
  def describe() = println(name, age)
}

//Q. define a generic Room with a name which may be any type
// and an location which may be any time

class Room[N, L](val name: N, val location: L) {
  def describe() = println(name, location)
}

// Q. give Room a describe() method which prints its name and location
// Q. create a room with a name "Yellow" and location ("SW", "I St", "Bentonville")
// Q. ask the room to describe itself


val yellow = new Room("Yellow", ("SW", "I St", "Bentonville"))
yellow.describe()

var ages = 60 to 63
var people = Set("JFK", "LBJ", "FDR")
var locations = Map(
  "Jefferson" -> "Virigina",
  "Franklin" -> "Boston"
)

//Q. loop over each of the above and print out their elements
//.. use a for comprehension AND  foreach {}
//Q. convert locations to a list, loop over it, and print out its elements
//Q. zip ages with people, loop over it and print out the elements

//Q. try the following function with ages, people.toList, people and locations
//-- which work, and which do not?  Why?
def write[A](as: Seq[A]) = as foreach { println(_) }
//see:   http://i.stack.imgur.com/Dsptl.png

//EXTRA:
val vs = Map("A" -> 1, "B" -> 2) map { case (k, v) => v }
//Q. obtain a list of loctions, from the locations variable using a map {}