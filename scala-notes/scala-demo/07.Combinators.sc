// CHAPTER 6:  COMBINATORS & RECURSION
// PROBLEM:    Use collections to analyse information about animals and ports.
// PROCESS:    Demonstrations & Discussion
// EXP?        Map/Reduce/Filter
// USE?        Data transformations.

// PART 1 -- COMBINATORS (VS. RECURSION, PATTERN MATCHING)

{
  // .MAP
  val names  = List("Michael", "Sherlock", "Watson")
  val prepMs = (str: String) => "Ms. " + str

  println(names.map(prepMs))

  def prepMr(str: String) = "Mr. " + str

  names.map(prepMr _)

  names.map( (e: String) => "Mr. " + e )
  names map( (e: String) => "Mr. " + e )
  names map( e => "Mr. " + e )
  names map(  "Mr. " + _ )
  names map {  "Mr. " + _ }

  for( e <- names ) yield "Mr. " + e

  val ages = List(18, 19, 20, 21)
  ages map { _ > 18 }

}

{
  // FLAT MAP
  val names = List("Fluffy Jefferson", "Fido Holmes", "Spot Sinatra")
  names map { _.split(" ") }

  //peeling away the type
  names flatMap { _.split(" ") }
  names flatMap { _.split(" ") } map { _.toUpperCase }
}

{
  // FOLDING & REDUCING
  var total = 0
  val ages = List(10, 20, 30)

  for(a <- ages) total += a

  ages.foldLeft(0)({ _ + _ })

  ages.foldLeft(0) { _ + _ }

  val allAdults = ages.foldLeft(true) { _ && _ > 18}

  ages reduce { _ + _ }


  ages map { _ > 18 }
  ages map { _ > 18 } reduce { _ && _ }
}


{
  //FILTER

}


{
  // PREDICATES
  val ages = List(10, 20, 30)
  val isAdult = (age: Int) => age > 18


  // EXISTS AND FORALL
  ages forall { _ > 18 }
  ages exists { _ < 18 }

  ages forall isAdult
  ages exists isAdult

}


{
  val sname: Option[String] = Some("Michael")
  sname map { "Mr." + _ }

  val nname: Option[String] = None
  nname map { "Mr." + _ }

  val names = List("Michael", "Andy")
  def loc(name: String): Option[String] = {
    val office = Map(
      "Michael" -> "London",
      "Andy"    -> "Cardiff"
    )

    office.get(name)
  }


  val locations = (names map loc _)

  (names map loc _) map { opt => opt map { _.toUpperCase } }
}





// PART 2 -- FOR COMPREHENSIONS

{
  // foreach
  for(pet <- List("Fluffy", "Spot")) println(pet)

  List("Fluffy", "Spot") foreach { pet => println(pet) }


  // yield and map
  for(id <- List(1, 2, 3)) yield id + 1000

  List(1, 2, 3) map { id => id + 1000 }
}

{
  // flatMap
  val ids  = List(1, 2, 3)
  val pets = List("Fluffy", "Spot")

  for(id <- ids; pet <- pets) yield s"${id + 1000}: $pet"

  ids.flatMap { id =>
    pets.map { pet => s"${id + 1000}: $pet" }
  }


  for(id <- ids; pet <- pets) yield s"${id + 1000}: $pet"

  ids.flatMap { id => pets.map { pet => s"${id + 1000}: $pet" } }
}



// PART 3 -- RECURSION


{ //RECURSION

  //why recursion?
  val people = List("Michael", "Sherlock", "Fluffy")

  var str = ""
  for(p <- people) str += people

  //or,
  str = "" + people(0) + people(1) + people(2)

  //or,
  // str = f(Nil) + f(people(0)) + f(people(1)) + f(people(2))

  //or, -- what's going to keep the counter? there's no i += 1
  // str = f(f(f(f(people))))

  // what must f do?
  // peel away list into working-on-bit and pass on rest of it
}


{
  // RECURSION IDIOMS
  def iloop(): Unit =  iloop()

  // terminating recursion
  def loop(condition: Boolean): Int = condition match {
    case true => loop(condition)        //continue
    case false => 0                     //stop
  }

  val locations = List("UK", "US", "CA")

  def join(strs: List[String], sep: String = " "): String = strs match {
    case head :: tail => head + sep + join(tail)
    case Nil => ""                         // lists are Nil-terminated
  }
}


{
  // INTERNAL ITERATION VS RECURSION

  val basket = List(("Lemonade", 4.50), ("Cherries", 3.45), ("Bread", 2.33))
  val locations = List("UK", "US", "CA")


  def factorial(n: Int) = (1 to n).product

  val joined = locations.mkString " "
  val total  = basket map { _._2 } reduce { _ + _ }

  println(joined)
  println(total)

  //explicit recursion is rarely a need, in practice:
  //1. internal iterators do 90% of the work
  //2. methods should provide functional APIs: not necessarily implementation

  def fac(n: Int): Int = {
    var i = n
    var acc = 1

    while (i > 0) {
      acc *= i
      i   -= 1
    }

    acc
  }
}
