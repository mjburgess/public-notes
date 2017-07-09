// CHAPTER:   12. PATTERN MATCHING
// OBJECTIVE: Answer the following questions.
// PROBLEM:    
// TIME:       25 m

// PATTERN MATCHING
val person = ("Sherlock Holmes", 27)

//Q. assign name, age from person

//Q. create a trait Person
//.. and a case class Worker with an id which extends Person,
//.. and a case class Customer with a role which extends Person

//Q. write a method which accepts any person
//.. it should print the ID if a worker is passed,
//.. and the role if a Customer is passed


def details(): List[Option[String]] =
    List(Some("Michael Burgess"), Some("United Kingdom"), None, Some("QA"))

//Q. Use a for-comprehension to produce a list of detail strings from details()
//.. where the detail provided is None, use "Unknown"


// COMPANION OBJECT

//Q. define a companion object so that the following matches succeed

//HINT: object Detective will need an apply(): Detective
// ... and unapply(): Option[(String, String)]

class Detective private (val fullname: String, val address: String)

val Detective(firstname, secondname) = Detective("Sherlock Holmes, 22B Baker St.")



// REVIEW: What did you learn from this exercise?