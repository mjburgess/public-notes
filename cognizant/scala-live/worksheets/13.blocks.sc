
var result = {
  val population = 330
  val ak = 5.0

  ak/population
}

println(result * 100)

def bake(flour: Double, sugar: Double): Double = {
  println("BAKING!!!")
  flour + sugar
}



def sum(x: Int, y:Int): Int = {
  x + y
}

sum(5, 5)


def message(prefix: String = "Hello, ") = {
  println(prefix + " and Good Evening?")
}

message()

def sum(nums: Int*) = {
  var total = 0
  for(n <- nums) total += n
  total
}

println(sum(10, 20, 30, 40))



