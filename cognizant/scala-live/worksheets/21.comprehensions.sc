
var ids = List(1, 2, 3)
var pets = List("Fluffy", "Spot", "Fido")

for( id <- ids; pet <- pets) yield s"${id} ${pet}"


println(ids.flatMap { id =>
  pets.map {
    name => s"${id} ${name}"
  }
})