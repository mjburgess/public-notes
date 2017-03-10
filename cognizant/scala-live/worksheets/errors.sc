def getUser(pw: Int): Option[String] = if(pw == 1234) {
  Some("Michael")
} else {
  None
}

def getName(pw: Int): Option[String] = if(pw == 1234) {
  Some("Michael")
} else {
  None
}


def getAge(pw: Int): Option[String] = if(pw == 1234) {
  Some("Michael")
} else {
  None
}


val user = getUser(1234)

def useUsername(u: String) = println(u)

user match {
  case Some(u) => useUsername(u)
  case None => println("EROR")
}


for(user <- getUser(23434);
    age <- getAge(1334);
    name <- getName(232))
  useUsername(user)

