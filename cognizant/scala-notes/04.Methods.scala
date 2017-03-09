// CHAPTER 4:  FUNCTIONS
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// PART 1 -- METHODS 

// CODE BLOCKS 
//braces group expressions
val firstName = {
    val parts = "Michael Burgess".split(" ")
    parts(0)                                    // this is the "return value"
}                                               // ie., the value of the entire block

println(firstName)


val amount = {
    val ratio = 2.5
    val distance = 12

    distance * ratio
}

println(amount)



// METHODS
def bake(flour: Double, sugar: Double) {
    println(s"Making ${flour + sugar} g of cookies!")
}

def mix(flour: Double, sugar: Double) = {
    val amount = flour + sugar

    return "Making ${amount} g of cookies!"
}

println(mix(30, 40.5))




def sum(a: Int, b: Int) = {
  a + b
}

sum(5,10)

def sum(a: Int, b: Int): Int = a + b

// NOT IMPLEMENTED ("PASS")
def notDefined(x: Int, y: String, z: Boolean): Double = ???     // throws NotImplementedError 

// RETURNING UNIT
def add(a: Int, b: Int): Int = {
    a + b
}

def mul(c: Int, d: Int) {
    c * d
}


// DEFAULT ARGUMENTS
def greeting(message: String = "Good Day!") {
    println("Hello and " + message)
}

greeting()
greeting("Goodbye!")




def repeat(str: String, N: Int = 10) = {
    var result = ""

    for(i <- 1 to N) result = result + str

    result
}

repeat("Ho! ", 3)



// VARIADICS 
def sum(numbers: Int*) = {
  var counter: Int = 0
  for (n <- numbers) {
    counter += n
  }
  counter
}

sum(1,2,3,5,6)


// PASSING SEQUENCES TO VARIADICS
//another way of defining sum

def sum(nums: Int*) = nums reduce { _ + _ }      
sum: (nums: Int*)Int

sum(1,2,3)

val ages = List(18, 20, 22)
sum(ages : _*)



// ARGUMENT PASSING STYLE 
def appendMark(phrase: String, mark: String = "?") = phrase + mark

appendMark("what time is it", "!!?")
appendMark("what time is it")

def config(host: String, user: String, pass: String) = println(s"$user:$pass@$host")
config(user="Michael", pass= "Test", host = "UK")



// DEF VS VAL
def helloByDef = "hello"
val helloByVal = "hello"

println(helloByDef)

println(helloByVal)

def nowByDef = new java.util.Date
val nowByVal = new java.util.Date

nowByDef
nowByVal

nowByDef
nowByVal


// LAZY VALS 
val strict = new java.util.Date //11:00:00 am

strict  //11:00:00 am
strict  //11:00:00 am

def deffered = new java.util.Data // ---

deffered //11:00:00 am
deffered //11:00:55 am

lazy val deferOnce = new java.util.Data // ---

deferOnce //11:00:00 am
deferOnce //11:00:00 am




//... !!!
//ASIDE: REFERENTIAL TRANSPARENCY 
val heightM = 1.8
val height = heightM * 100
var age = 26
age += 1

println(s"I am $height cm and $age years old")


//ASIDE: HOFs
def sendMessage(callback: (String) => String) = {
    println(callback("ERROR - BAD!"))
}

val callback = (message: String) => "OK"

sendMessage(call)




def repeat(str: String, numTimes: Int, fn: (String, String) => String) = {
    var result = ""

    for(i <- 0 to numTimes) result = fn(result, str)

    result
}


val res = repeat("Ho", 5, (l: String, r: String) => l + r)
println(res)


val result = repeat("Ho", 5 { _ + _})



//ASIDE: TYPE ALIASES 
type Repeatable =  (String, String) => String

def repeat(str: String, numTimes: Int, fn: Repeatable) {
    var result = "";

    for(i <- 0 to numTimes) result = fn(result, str)

    result
}

def repeat(str: String, N: Int, fn: Repeatable = (l,r) => l + r)  = {
    var result = "";

    for(i <- 0 to N) result = fn(result, str)

    result
}
