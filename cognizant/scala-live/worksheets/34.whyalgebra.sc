//algebraic types   + *




trait Person
case class Employee() extends  Person
case class Doctor() extends Person


def talk(p: Person) = p match {
  case Employee() =>
  case Doctor() =>
}