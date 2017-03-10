

val names = List("Sherlock", "Washington", "JFK")

for (n <- names) println(n)

val upNames = for (n <- names) yield n.toUpperCase


/*

NEW = for (ELEMENT <- OLD) yield SOMETHING(ELEMENT)
 */
println(upNames)

val xs = for(n <- names) yield n.length

println(xs)

val person_address = Map(
  "Jefferson" -> "Virginia",
  "Trump" -> "New York"
)

for( (name, location) <- person_address) {
  println(name.toUpperCase + location)
}

for( pa <- person_address) {
  println(pa)
}


val person = Map(
  "name" -> "Michael",
  "location" -> "AR"
)

