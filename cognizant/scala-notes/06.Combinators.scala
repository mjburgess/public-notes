// CHAPTER 6:  COMBINATORS
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// PART 1 -- COMBINATORS (VS. RECURSION)


// .MAP 

val names = List("Michael", "Sherlock", "Watson")
names.map( (e: String) => "Mr. " + e )


def prepMr(str: String) = "Mr. " + str

prepMr("michael")


names


names.map(prepMr _)


names.map( (e: String) => "Mr. " + e )


names map( (e: String) => "Mr. " + e )


names map( e => "Mr. " + e )


names map(  "Mr. " + _ )


names map {  "Mr. " + _ }


for( e <- names ) yield "Mr. " + e


val name = Some("Michael")


name map { "Mr." + _ }


val name: Option[String] = None


name map { "Mr." + _ }


val ages = List(18, 19, 20, 21)


ages map { _ > 18 }



// FLAT MAP
val names = List("Fluffy Jefferson", "Fido Holmes", "Spot Sinatra")

names map { _.split(" ") }

//peeling away the type 
names flatMap { _.split(" ") }

names flatMap { _.split(" ").toUpperCase }


// FOLDING & REDUCING

ages reduce { _ + _ }


ages.foldLeft(0)({ _ + _ })


ages.foldLeft(0) { _ + _ }


ages.foldLeft(0) { _ + _ }


ages.reduce { _ + _ }


ages map { _ > 18 }


ages map { _ > 18 } reduce { _ && _ }


val ages = List(18, 19, 20, 21)


val ages = List(19, 19, 20, 21)


ages map { _ > 18 } reduce { _ && _ }



// PREDICATES

val isAdult = (age: Int) => age > 18


// EXISTS AND FORALL
ages forall { _ > 18 }


ages exists { _ < 18 }


ages exists { _ > 18 }


def isOpen() = true


isOpen


def somethign() = false


def count(): Int = 0


count()


def count(): Option[Int] = None


count()


def count(): Option[Int] = Some(0)


count()


val names = List("Michael", "Andy")


def loc(name: String) = {
       val office = Map("Michael" -> List("London", "Newport"),
      "Andy" -> List("Cardiff", "Newport"))
     
      office(name)
      }


loc("Michael")


loc("Andy")


loc("Andy")


names


names map loc _


names flatMap loc _


List(List(1,2), List(3,4))


val ll = List(List(1,2), List(3,4))


ll(0)


ll(1)


ll(0) ++ ll(1)


// PART 2 -- FOR COMPREHENSIONS 


// yield and map 

for(id <- List(1, 2, 3)) yield id + 1000

List(1, 2, 3) map { id => id + 1000 }



for(pet <- List("Fluffy", "Spot")) println(pet)

List("Fluffy", "Spot") foreach { pet => println(pet) }


// flatMap
val ids  = List(1, 2, 3)
val pets = List("Fluffy", "Spot")

for(id <- ids; pet <- pets) yield s"${id + 1000}: $pet"

ids.flatMap { id =>
    pets.map { pet => s"${id + 1000}: $pet" }
}


for(id <- ids; pet <- pets) yield s"${id + 1000}: $pet"

1002: Spot, 1003: Fluffy, 1003: Spot)

ids.flatMap { id => pets.map { pet => s"${id + 1000}: $pet" } }

1002: Spot, 1003: Fluffy, 1003: Spot)


// for "combinators" over option and list

for(id <- ids; pet <- pets) yield s"${id + 1000}: $pet"

1002: Spot, 1003: Fluffy, 1003: Spot)

ids.flatMap { id => pets.map { pet => s"${id + 1000}: $pet" } }

1002: Spot, 1003: Fluffy, 1003: Spot)

pidsNil

pidsSome

pidsNone
