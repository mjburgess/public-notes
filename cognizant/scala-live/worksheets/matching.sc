

val deets = ("JFK", ("New York", 1970))


val (n, (l, y)) = deets

n
l
y




case class Person(name: String, age: Int, location: (String, String))

val me = Person("Michael", 27, ("I st", "Bentonville"))

val Person(name, age, loc) = me




val pets = List("Richard Dawkins",
                "Richard Feynman",
                "Lewis Carol",
                "Daid Lewis",
                "Carol Richards")

val Richards = """Richard (\w+)""".r
val Lewis = """(?:\w+ )?Lewis(?: \w+)?""".r


println(for(p <- pets) yield p match {
  case Richards(name) => s"hello ${name}"
  case Lewis() => "HI!?"
  case _ => "GOOD BYES!"
})

val person = ("Sherlock Holmes", 27)
//Q. assign name, age from person
val (name, age) = person

//Q. create a trait Person
//.. and a case class Worker with an id: Int which extends Person,
//.. and a case class Customer with a role: String which extends Person
trait Person
case class Worker(id: Int) extends Person
case class Customer(role: String) extends Person

//Q. write a method called detail which accepts any person
//.. it should print the ID if a worker is passed,
//.. and the role if a Customer is passed
def detail(p: Person) = p match {
  case Worker(id) => id
  case Customer(role) => role
}

def details() = List(Some("MB"), Some("UK"), None, Some("QA"))
//Q. Use a for-yield-match to produce a list of detail strings from details()
//.. where the detail provided is None, use "Unknown"

for(d <- details())  yield d match {
  case Some(str) => str
  case None =>   "Unknown"
}

//REFERENCE...
val people = List(Person("Michael", 27, ("LDN", "UK")), Person("J", 54, ("AR", "US")))
for(p <- people) yield p match {
  case Person("Michael", age, location) => "blue"
  case _ => "green"
}

for(Person(name, age, location) <- people) yield name
