// CHAPTER 10:  PATTERN MATCHING
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// PATTERN MATCHING 
 val (y, (_, z)) = ("File System", ("NTFS", 1024))


 case class OperatingSystem(val name: (String, String), val addressSize: Int)

val OperatingSystem((publisher, title), _) =
    OperatingSystem(("Microsoft", "Windows 10"), 64)

// PATTERN EQUALITY 
1 match { case 1 => true; case _ => false }

val os = (("Microsoft", "Windows 10"), 32)

val isMicrosoft = os match {
    case (("Microsoft", _), _) => true
    case _ => false
}


// MATCHING & EXTRACTING 
val os = (("Microsoft", "Windows 10"), 32)

val whichMicrosoft = os match {
    case (("Microsoft", os), bit) => s"MS $os - $bit bit"
    case _ => 'None'
}


// CASE
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


//val name = "Michael"
//val (name, age) = ("Michael", 27)

val (name, (age, (locationCountry, locationCity))) = ("Michael", (27, ("UK", "Newport")))


println(name)
println(age)
println(locationCountry)

case class OS(val name: String, val bit: Int)

val win = OS("Windows", 32)
val lin = OS("Ubuntu", 32)

val OS(win_name, _) = win

println(win_name)



val isMicrosoft = win match {
    case OS("Windows", _) => true
    case OS("Linux", _) => false
    case _ => false
}


println(lin match {
    case OS("Ubuntu", bit) => s"You have $bit Linux"
    case _ => "Unknown"
})



// OPTION & TRY 


def getName(n: String): Option[String] = if(true) {
    Some("Michael")
} else {
    None
}

def getAge(): Option[String] = None

for(name <- getName("X");
    age <- getAge()
) println(name + age)

name = getname
age = age()

if(name != null) {
    if(age != null) {
        prinln(name + age)
    }
}


import scala.util.Try

def divZ(dd: Int, div: Int) = Try { dd / div }

println(divZ(10, 0))
println(divZ(10, 10))


def getName(): Option[String] = Some("Michael")

val mrName = getName() match {
    case Some(n) => s"Mr. $n"
    case None => "GUEST"
}

println(mrName)

val names = List("michael", "sherlock", "watson")

println(
    names match {
        case head :: tail => s"Mr. $head"
        case Nil => "GUEST"
    }
)



// SEQUENCES (REFRESH)
List("Michael", "John", "Burgess")
Vector("Michael", "John", "Burgess")
IndexedSeq("Michael", "John", "Burgess")
Map("type"-> "human", "height" -> 2, "weight" -> 100).toSeq

1 +: Seq(2,3)


def breakUp[T](seq: Seq[T]): String = seq match {
  case head +: tail => s"$head +: " + breakUp(tail)
  case Nil => "END"
}

breakUp(Map("type"-> "human", "height" -> 2, "weight" -> 100).toSeq)

breakUp(IndexedSeq("Michael", "John", "Burgess"))


// TUPLES
val startsWith = ("First", "Second", "Third") match {
    case ("A", _, _) => "Starts with A"
    case ("First", _, _) => "Starts with First"
    case (_, _, _) => "Unknown!"
}

val tupleList = List(("A", "B", "C"), (1, 2, 3), (false, 1, "B"))

val eachStartsWith = for (triple <- tupleList)
    yield triple match {
        case ("A", _, _) =>  "Starts with A"
        case (1, _, _)   =>  "Starts with 1"
        case (_, _, _)   =>  "Unknown!"
    }

startsWith

eachStartsWith
// TYPES 

type ElementFunction[R] = Seq[S] => R

def matchSequence[S, D, R](s: Seq[S], nil: D)(): R = seq match {
  case Nil => nil
  case head +: _ => {

  }
}

for {
  x <- Seq(List(5.5,5.6,5.7), List("a", "b"), Nil)
} yield {
  x match {
    case seq: Seq[_] => (s"seq ${doSeqMatch(seq)}", seq)
    case _           => ("unknown!", x)
  }
}

// REGEX

val people = List("Richard Dawkins", "Richard Feynman", "Lewis Carol", "David Lewis", "Carol Richards")

val Richards = raw"Richard (\w+)".r
val Lewises = raw"(?:\w+ )?Lewis(?: \w+)?".r

println(
        for (person <- people) yield person match {
            case Richards(name) => "a scientist named: " + name
            case Lewises() => "a logician"
            case _ => "something else"
    }
)

// GUARDS 
type Person = (String, Int)

val people: Seq[Person] = Seq(("Michael", 26), ("Sarah", 15), ("John", 18))

for(person <- people) println(
    person match {
        case (name, age) if age >= 18 => s"$name is eligible for full-time work "
        case (name, _) => s"$name is not eligible for full-time work or needs a performance licence"
    }
)


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


case class Person(val name: String, age: Int)

// WHY PATTERN MATCHING & SUM TYPES !