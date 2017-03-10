

val first = (name: String) => name.split(" ")(0)
val last =  (name: String) => name.split(" ").last


println(first("Michael Burgess"))
println(last("Michael Burgess"))

//Q. define a method that accepts a function as an argument
// the method should call the function with "Thomas Jefferson"
// and print the result


def printFn(fn : String => String ) = {
  println(fn("Thomas Jefferson"))
}


printFn(last)
printFn(first)
printFn( (m: String) => m * 30)

//NOT A VARIABLE
def firstName(name: String) = name.split(" ")(0)


println(first.apply("Michael Burgess"))


((name: String) => name.split(" ")(0))("Spot Taft")


def sendMessage(formatter: String => String) = {
  println(formatter("Hello World"))
}


sendMessage( (m: String) => m.toUpperCase )