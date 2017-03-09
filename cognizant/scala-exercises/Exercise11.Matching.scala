// CHAPTER:   PATTERN MATCHING 
// PROBLEM:    
// TIME:       25 m


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


// REVIEW: What did you learn from this exercise?