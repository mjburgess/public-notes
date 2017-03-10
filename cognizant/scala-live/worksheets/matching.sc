

val deets = ("JFK", ("New York", 1970))


val (n, (l, y)) = deets

n
l
y




case class Person(name: String, age: Int, location: (String, String))

val me = Person("Michael", 27, ("I st", "Bentonville"))

val Person(name, age, loc) = me

def greet(me: Person) = me match {

  case Person("Michael", age, location) if age > 30 => "Hi, Sir!"
  case Person("Michael", 45, location) => "Hi!"
  case _ => "Bye!"
}

greet(me)



val data: Option[Int] = Some(10)
val missing: Option[Int] = None

println(missing match {
  case Some(d) => d * 2
  case None => 0
})


val people = List(me, me, me, me)

for(Person(name, age, location) <- people) yield name

for(p <- people) yield p match {
  case Person("Michael", age, location) => "blue"
  case _ => "green"
}




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

