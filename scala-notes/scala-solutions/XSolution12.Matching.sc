// CHAPTER:   12. PATTERN MATCHING
// OBJECTIVE: Answer the following questions.
// PROBLEM:   Use pattern matching to extract information about people.
// TIME:       20 m

// PATTERN MATCHING
val person = ("Sherlock Holmes", 27)

//Q. assign name, age from person
val (name, age) = person

//Q. create a trait Person
//.. and a case class Worker with an id which extends Person,
//.. and a case class Customer with a role which extends Person

trait Person
case class Worker(val id: Int) extends Person
case class Customer(val role: String) extends Person

//Q. write a method which accepts any person
//.. it should print the ID if a worker is passed,
//.. and the role if a Customer is passed

def desc(p: Person) = p match {
    case Worker(id) => println(id)
    case Customer(role) => println(role)
}


def details(): List[Option[String]] =
    List(Some("Michael Burgess"), Some("United Kingdom"), None, Some("QA"))

//Q. Use a for-comprehension to produce a list of detail strings from details()
//.. where the detail provided is None, use "Unknown"


val deets = for(d <- details) yield d match {
    case Some(name) => name
    case None => "UNKNOWN"
}


println(deets)


// COMPANION OBJECT

//Q. define a companion object so that the following matches succeed
//HINT: object Detective will need an apply() and unapply()

class Detective private (val fullname: String, val address: String)

object Detective {
  def apply(info: String) = {
    val Array(fn, addr) = info.split(",")

    new Detective(fn, addr)
  }

  def unapply(d: Detective): Option[(String, String)] = {
    val Array(first, second) = d.fullname.split(" ")
    Some(first, second)
  }
}


val Detective(firstname, secondname) = Detective("Sherlock Holmes, 22B Baker St.")


// REVIEW: What did you learn from this exercise?