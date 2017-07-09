// CHAPTER 16:
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// SCALA. LIBRARIES

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


// EXERCISE

// SOURCE + JSON
//Q. use the Source scala library to read http://jsonplaceholder.typicode.com/users
//Q. use the json4s (ie., lift-web) json library to parse this into case classes

