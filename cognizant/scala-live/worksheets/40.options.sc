def getRow(index: Int): Option[(String, Int)] = {
  val database = Map(
    1 -> ("michael", 1234),
    2 -> ("tom", 8888)
  )

  database.get(index)
}

//Q. define a function getPassword
// it should accept an pin: Int
// if the pin supplied is 1234 return Some("pa$$")
// otherwise return None
def getPassword(pin: Int) = if(pin == 1234) Some("pa$$") else None

//Q. define a function printDetails
//.. it should accept a String, Int and String and print them
def printDetails(name: String, pin: Int, pass: String) = println(name, pin, pass)

//Q. use a for-comp to get a pin from getRow(1)
// then getPassword() using that pin
// finally printDetails() of the username, pin and password

val deets = getRow(1)

deets match {
  case Some((u, p)) => getPassword(p) match {
    case Some(pass) => printDetails(u, p, pass)
    case None => ()
  }
  case None => ()
}

for((name, pin) <- getRow(4);
           pass <- getPassword(pin)) printDetails(name, pin, pass)

//REFERENCE:
//for((u, p) <- Map("hello", 1919)) println(p)
