// CHAPTER 12:  PATTERN MATCHING
// PROBLEM:   Use pattern matching to extract information about people.
// PROCESS:   Demonstration & Discussion.
// EXP?       Destructuring assignment, pattern matching.
// USE?       Providing convenient access to data and behaviour specialization.

{
  // REVIEW: EXTRACTING ASSIGNMENT
  val (y, (_, z)) = ("File System", ("NTFS", 1024))

  case class OperatingSystem(val name: (String, String), val addressSize: Int)

  val OperatingSystem((publisher, title), _) =
    OperatingSystem(("Microsoft", "Windows 10"), 64)
}

{
  // REVIEW: CASE
  def day(name: String) = name slice (0, 2) match {
    case "Mo" => 1
    case "Tu" => 2
    case "We" => 3
    case "Th" => 4
    case "Fr" => 5
    case "Sa" => 6
    case "Su" => 7
    case _ => 0
  }
}

{
  // REVIEW: PATTERN EQUALITY & EXTRACTION
  val os = (("Microsoft", "Windows 10"), 32)

  val isMicrosoft = os match {
    case (("Microsoft", _), _) => true
    case _ => false
  }

  val whichMicrosoft = os match {
    case (("Microsoft", os), bit) => s"MS $os - $bit bit"
    case _ => "?"
  }
}


{
  //REVIEW: WHY PATTERN MATCHING & SUM TYPES
  class Animal
  case class Dog() extends Animal
  case class Cat() extends Animal

  val what = new Animal
  val fido = new Dog
  val fluffy = new Cat

  // Animal = Dog | Cat | Animal
  def speak(a: Animal) = a match {
    case Dog() => "woof"
    case Cat() => "meow"
    case _ => "grunt!"
  }

  speak(fido)               //ad-hoc polymorphism
  speak(fluffy)
  speak(what)
}

{
  //effective CASTING

  val objs = List(1, false, "Hello")

  for(o <- objs) println(o match {
    case i : Int => s"An int: $i!"
    case b : Boolean => s"A bool: $b!"
    case s : String => s"A string: $s"
  })
}

{
  // OPTION & TRY

  def getName(): Option[String] = Some("Michael")

  val mrName = getName() match {
    case Some(n) => s"Mr. $n"
    case None => "GUEST"
  }

  println(mrName)

  //better to use for-comprehensions
}

{
  // SEQUENCES
  val names = List("michael", "sherlock", "watson")

  println(
    names match {
      case head :: tail => s"Mr. $head"
      case Nil => "GUEST"
    }
  )

  def breakUp[T](seq: Seq[T]): String = seq match {
    case head +: tail => s"$head +: " + breakUp(tail)
    case Nil => "END"
  }

  breakUp(Map("type"-> "human", "height" -> 2, "weight" -> 100).toSeq)
  breakUp(IndexedSeq("Michael", "John", "Burgess"))
}

{
  // FOR-YIELD-MATCH
  val tupleList = List(("A", "B", "C"), (1, 2, 3), (false, 1, "B"))

  val eachStartsWith = for (triple <- tupleList)
    yield triple match {
      case ("A", _, _) =>  "Starts with A"
      case (1, _, _)   =>  "Starts with 1"
      case (_, _, _)   =>  "Unknown!"
    }
}

{
  // REGEX
  val people = List("Richard Dawkins", "Richard Feynman",
                    "Lewis Carol", "David Lewis", "Carol Richards")

  val Richards = raw"Richard (\w+)".r
  val Lewises = raw"(?:\w+ )?Lewis(?: \w+)?".r

  println(
    for (person <- people) yield person match {
      case Richards(name) => "a scientist named: " + name
      case Lewises() => "a logician"
      case _ => "something else"
    }
  )
}

{
  // GUARDS
  type Person = (String, Int)

  val people: Seq[Person] = Seq(("Michael", 26), ("Sarah", 15), ("John", 18))

  for(person <- people) println(
    person match {
      case (name, age) if age >= 18 => s"$name is eligible for full-time work "
      case (name, _) => s"$name is not eligible for full-time work"
    }
  )
}


{
  // THE MECHANISM OF PATTERN MATCHING
  class Person(val name: String, val age: Int)

  object Person {
    def unapply(p: Person) = Some((p.name, p.age))
  }

  val aliceSm = Person("Alice Smith", 8)
  val bobSm   = Person("Bob Smith", 35)
  val aliceDo = Person("Alice Doe", 21)

  val message = aliceDo match {
    case Person("Alice Doe", _)
    => "hello alice doe!"

    case Person(name, _)
      if name.contains("Alice")
    => "hello alice!"

    case Person(_, age)
      if age > 18
    => "hello adult!"

    case Person(_, _)
    => "hello child"
  }
}


