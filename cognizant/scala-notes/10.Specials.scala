// CHAPTER 10:  SPECIAL TYPES & LIBRARIES 
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// PART 1 -- SPECIAL TYPES

// STREAMS

// streams are (immutable) lazy lists 
// values calculated on demand + cached
// stream = current value + next operation = cons cell + next
// streams can be infinite

import Stream._
    
val numbers = cons(0, cons(1, Stream.empty))
val zeroOne = 0 #:: 1 #:: empty

numbers foreach { println _ }

def squares(i: Int): Stream[Int] = (i * i) #:: squares(i + 1) 

val s = sq(1) take 3

squares(1) take 3 foreach (println _)

val monotonic = Stream.from(3)             
val repeated = Stream.continually(1)
val range = Stream.range(10,20)



// OPTION
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



// TRY + EXCEPTIONS !

def brokenFunction() = throw new Exception("Some Error!")

import java.io.IOException
try {
    brokenFunction()
} catch {
    case io: IOException => println("bad io")
    case e:    Exception => println("general error")
}
// TRY 
import scala.util.Try

def division(dd: Int, divisor: Int): Try[Int] = {
  Try {
    dd / divisor
  }
}

division(10,0)
division(10,1)

// map Try , for() Try 

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


// PART 2 -- LIBRARIES 


// SOURCE  
import scala.io.Source

// reading urls 
println(Source.fromURL("http://google.com"))


//reading files
val filename = "/etc/services"

for (line <- Source.fromFile(filename).getLines) {
      println(line)
}


val bufferedSource = Source.fromFile(filename) 

for (line <- bufferedSource.getLines) {
    println(line.toUpperCase)
}

bufferedSource.close


// java for writing files... ugly!
import java.io._
var in: Option[FileInputStream]   = None
var out: Option[FileOutputStream] = None

try {
    in  = Some(new FileInputStream(filename))
    out = Some(new FileOutputStream("/tmp/services-copy")) 

    out.write(in.read(in.length()))

} catch {
    case e: IOException => e.printStackTrace
} finally {
    println("entered finally ...") 

    if (in.isDefined)  in.get.close 
    if (out.isDefined) out.get.close
} 



// JSON

// a case class to match the JSON data

val JSON_STRING = """{
    "accounts": [
        { "emailAccount": {
        "accountName": "YMail",
        "username": "USERNAME",
        "password": "PASSWORD",
        "url": "imap.yahoo.com",
        "usersOfInterest": ["barney", "betty", "wilma"]
        } },
        
        { "emailAccount": {
        "accountName": "Gmail",
        "username": "USER",
        "password": "PASS",
        "url": "imap.gmail.com",
        "usersOfInterest": ["pebbles", "bam-bam"]
        } }
    ]
}
"""

case class EmailAccount( 
    accountName: String, 
    url: String, 
    username: String, 
    password: String, 
    usersOfInterest: List[String]
)

implicit val formats = DefaultFormats
val json = parse(JSON_STRING)
val elements = (json \\ "emailAccount").children map { _.extract[EmailAccount] }

println(elements)



// PART 3 -- STRUCTURAL TYPES
// structural types == duck typing == ad hoc polym. 

def speak(d: {def quack(value: String): String}) {
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

