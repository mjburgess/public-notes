

def join(strs: List[String]): String = strs match {
  case head :: rest => head + join(rest)
  case Nil => ""
}



val basket = List( ("Lemoade", 5), ("Cherries", 3.50) )

def average(cart: List[(String, Double)]): Double = cart match {
  case   head :: rest =>  head._2 + average(rest)
  case Nil => 0
}


/*

def loop( list ) = list match {
  case Nil => end-value-that-doesnt-matter
  case ... =>  ...  loop(rest)

 */