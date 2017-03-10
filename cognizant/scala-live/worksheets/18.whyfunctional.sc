val names = List("Michael", "Sherlock", "Watson")

def format(n: String): String = n.toUpperCase

val newN = for (n <- names) yield format(n)

println(newN)
/*
val newN = for (n <- ..?..) yield ..?..(n)
*/
// type      (String) => String

def transform(strs: List[String], f: String => String) =
  for (n <- strs) yield f(n)

val reformat = (s: String) => s.toUpperCase

println(transform(names, reformat))



//Q. define a method transformNumbers that accepts a list of
// Ints and makes a list of Ints by doubling them AND
// applying a f: Int => Int   on them

def transformNumbers(ints: List[Int], f: Int => Int) = {
  for (i <- ints) yield f(i * 2)
}

//Q. call transformNumbers with the function
val square = (x: Int) => x * x

transformNumbers(List(1, 2, 3), square)


def price(items: List[Double], discount: Double => Double): Unit = {
  //store look
  //contacts resellers

  discount(items(0))
}



price(List(3.5), _ * 0.2 )
price(List(3.5), (p: Double) => p * 0.2)
price(List(3.5), (p: Double) => p * 0.8 + 5)



price(List(3.5), _ * 0.2 )
price(List(3.5), _ * 0.5)
price(List(3.5), _ * 0.8 + 5)










