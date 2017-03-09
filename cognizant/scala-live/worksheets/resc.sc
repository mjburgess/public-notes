import scala.annotation.tailrec

var names = List("Spot", "Fido", "Tom")

/*
names match {
  case head :: tail =>
  case Nil =>
}
*/

var str = ""

str += names(0)
str += names(1)
str += names(2)


var out = ""
for(s <- names) out += s

// join(names(2), join(names(1), join("", names(0))))

@tailrec
def join(ss: List[String]): String = ss match {
  case head :: rest =>join(head + rest)
  case Nil => ""
}


join(names)


