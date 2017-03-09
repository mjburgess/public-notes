
def bake(lbsFl: Int, ozSugar: Double): Double = {
  val halfSugar = ozSugar / 2
  lbsFl + halfSugar
}



//Q. define a method getUser with arguments username and password
// the method should return a Map("username" -> username, "password" -> password)
// password should have a default value of "pa$$"

def getUser(username: String, password: String = "pa$$") = Map(
  "username" -> username,
  "password" -> password
)


//EXTRA:
//Q. can you add a return type to the method?
//: Map[String, String]