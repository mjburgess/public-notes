// CHAPTER 10:  ALGEBRA & SPECIAL TYPES
// PROBLEM:   Use generic types to handle pin-protected data.
// PROCESS:   Demonstration & Discussion.
// EXP?       Polymorphism: ad-hoc & generics (parametric).
// USE?       Tools for describing relationships between objects and their behaviour.

// PART 1 -- ALGEBRAIC DATA TYPES

{
  // TUPLES TYPES
  val mytuple = (1, "Hello", false)

  val tperson = ("Michael", 26)
  val cperson = new Person("Michael", 26)

  type WebSite = (String, String, String)

  val eg : WebSite = ("Example Site", "A website used for examples", "http://www.example.co.uk")
}


{
  //ALGEBRAIC DATA TYPES
  //REVIEW: WHY PATTERN MATCHING

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

  speak(fido)
  speak(fluffy)
  speak(what)

  //NO:
  //def speak(a: Animal) =
  //  if(a.isInstanceOf[Dog]) { "Woof!" }
  //  else if (a.isInstanceOf[Cat]) { "Meow!" } else { "..." }
}



{
  // DEFINING AND USING ALGEBRAS

  abstract class Animal
  class Dog extends Animal
  class Cat extends Animal

  //pseudo-code equivalent
  // type Animal = Cat OR Dog

  // thus we may only have
  val animalA : Animal = new Cat
  val animalB : Animal = new Dog
}



{
  // EXAMPLE: LOGICAL OPERATORS
  //sketch
  abstract class LogicExpr

  case class T() extends LogicExpr
  case class F() extends LogicExpr

  case class And(val l: LogicExpr, val r: LogicExpr) extends LogicExpr
  case class Or(val l: LogicExpr, val r: LogicExpr) extends LogicExpr

  val myX : LogicExpr = And(T(), And(F(), Or(T(), F())))

}

{
  // in full
  abstract class LogicExpr {
    def meaning: Boolean
  }

  case class T() extends LogicExpr {
    def meaning = true
  }

  case class F() extends LogicExpr {
    def meaning = false
  }

  case class And(val l: LogicExpr, val r: LogicExpr) extends LogicExpr {
    def meaning = l.meaning && r.meaning
  }

  case class Or(val l: LogicExpr, val r: LogicExpr) extends LogicExpr {
    def meaning = l.meaning || r.meaning
  }


  val myA : LogicExpr = And(T(), And(F(), Or(T(), F())))
  val myO : LogicExpr = Or(T(), And(F(), Or(T(), F())))

  println(myA.meaning)
}


{
  //EXAMPLE: Document Store

  // Document = Video | Image | Text
  abstract class Document(val name: String, val ext: String)
  case class Video(n: String) extends Document(n, ".mp4")
  case class Image(n: String) extends Document(n, ".jpg")
  case class Text(n: String)  extends Document(n, ".txt")
}


// PART 2 -- GENERICS
{
  // TYPE ARGUMENTS
  val drinks = List("Coke", "Pepsi")
  val ages: List[Double] = List(1, 2, 3)


}

{
  // DEFINING GENERIC TYPES
  class Person[A](id: A)
  class Add[A, B](val x: A, val y: B)

  val mike = new Person[String]("Michael")
  val dbuser = new Person[Int](1001)

  val a = new Add[Int, Double](1, 2.0)

  println(a.x + a.y)
}

{
  // VARIANCE
  val myList = List(1, 2, 3) ++ List(1.0, 2.0, 3.0) //  List[AnyVal]

  class Animal(val name: String)
  class Cat(n: String) extends Animal(n)
  class Dog(n: String) extends Animal(n)

  class Person[+A](val pet: A) {
    override def toString = s"Person()"
  }

  val catOwners = List(new Person(new Cat("Fluffy")), new Person(new Cat("Sparkles")))
  val dogOwners = List(new Person(new Dog("Spot")),  new Person(new Dog("Fido")))

  val animalOwners = catOwners ++ dogOwners   // List[Person[Animal]]
}


{
  // TYPE BOUNDS
}

{
  // structural types ~= duck typing ~= ad hoc polym.
  def typed_speak(d: {def quack(value: String): String}) {
    println(d.quack("!"))
  }

  type Duck = { def quack(value: String): String }

  def speak(d: Duck) {
    println(d.quack("!"))
  }

  class Mallard {
    def quack(s: String) = "Quack" + s
  }

  class Doctor {
    def quack(s: String) = "Hello" + s
  }

  speak(new Mallard)
  speak(new Doctor)
}



// NOTHINGNESS
/*
* `Null`: Trait
* null: instance of Null
* corresponds to java's null

* `Nil`: empty List
* used to build lists

* `Nothing` is a Trait -- subtype of every type.
* No instances
* Used in type signatures of empty objects (eg. empty lists)

* `None`: Object
* Subtype of Option.
* used when returning an Option
* and when no senisble value can be returned

* `Unit`: Class
* () -- single instance of Unit.
* used for action ("void") situations, eg. I/O
*/




// bottom type hierachies
/*
* scala has a triadic "bottom type" structure:

* `scala.AnyVal`
* base of any typically unbox'd value in java
* child type is `scala.Nothing`
* includes `scala.Unit` type whose single value is   `()`
* `AnyVal`s of a single data property may be optimized away to just that property

* `scala.AnyRef`
* everything else (incl. java.lang.Object)
* child type is `scala.Null`

* `scala.Any` is parent (supertype) of both

* unrelated to this structure there is also `Nil`
* it means "empty sequence"
* it is `List[Nothing]`
*/





// PART 2 -- SPECIAL TYPES
{
  // WHY OPTION

  def div(x: Int, y: Int): Int = x/y

  // div: (Int, Int) => Int means fa. (Int, Int), ex. Int
  // not true!

  div(10, 0)    //div is a partial function

}

{ // DEFINING OPTION
  abstract class Maybe
  case class Just(val maybe: Int) extends Maybe
  case class Empty() extends Maybe

  val maybeAge: Maybe = Just(26)
  val maybeDay: Maybe = Empty()

  def division(dd: Int, divr: Int): Maybe =
    if(divr == 0)
      Empty()
    else
      Just(dd/divr)
}


{ //USING OPTION
  def dv(dd: Int, divr: Int): Option[Int] =
    if(divr == 0)
      None
    else
      Some(dd/divr)

  dv(10, 0)
  dv(100, 10)


  val (someX, someY, someZ) = (dv(100, 10), dv(20, 5), dv(1,0))

  for(x <- someX; y <- someY) yield x + y
  for(x <- someX; y <- someY; z <- someZ) yield x + y - z

}


{ // EXAMPLE: USER DATA
  def getName(n: String): Option[String] = if(true) {
    Some("Michael")
  } else {
    None
  }

  def getAge(): Option[String] = None

  for(name <- getName("X");
      age <- getAge()
  ) println(name + age)
}

{
  // BAD: EXCEPTIONS !
  def broken() = throw new Exception("Some Error!")

  import java.io.IOException
  try {
    broken()
  } catch {
    case io: IOException => println("bad io")
    case e:    Exception => println("general error")
  }

}



{
  // TRY
  def broken() = throw new Exception("Some Error!")

  import scala.util.{Try, Failure, Success}

  def division(dd: Int, divisor: Int): Try[Int] = {
    Try {
      dd / divisor
    }
  }

  division(10,0)
  division(10,1)

  def wrap() = Try {
    broken()
  }

  wrap() match {
    case Success(v) => println("Successful!")
    case Failure(e) => println("HSDH")
  }
}