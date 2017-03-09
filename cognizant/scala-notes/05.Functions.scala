// CHAPTER 5:  FUNCTIONS
// PROBLEM: 
// PROCESS:
// EXP?
// USE? 

// PART 1 -- FUNCTIONAL PROGRAMMING 

// WHAT IS FUNCTIONAL PROGRAMMING?  

// imperative program: actions on state 
class Ingredients(var amount: Double) {

    def prep() = mix *= 2
    def mix() =  mix += 2 
    def bake() = mix /= 2.0
}

val ing = new Ingredients(100)
ing.prep()
ing.mix()
ing.bake()

println(ing.amount)             // why?!




// functional programming:   all data flow is explicit
def prep(amount: Double) = mix * 2
def mix(amount: Double) =  mix + 2 
def bake(amount: Double) = mix / 2.0

val ing = 100
val prepd = prep(ing)
val mixd  = mix(prepd)
val baked = bake(mixd)

println(baked)

//or,
println( bake(mix(prep(100))) )         // the entire applicaton is one expression


// like is substitutable for like
println( bake(mix( 200 )) )
println( bake( 202 ) )
println(101.5)


// thef. the program is easy to reason about and to parallelize 
val serialA = bake(mix(prep(100)))
val serialB = bake(mix(prep(100)))


// cf., Q. can these be parallelized? A. who knows. 
ing.prep()
ing.mix()
ing.bake()




// DEFINING 'FUNCTION' AND 'PURITY'
// a pure function is a mapping from inputs to outputs
def last_name(name: String) = name.split(" ").last                      // String -> String  
                                                                        // where String is the set of all strings 
// this is equivalent to a set of pairs..
val last = Set( ("Sherlock Holmes", "Holmes"),  ("", "") ) //... for every string 




// ANNONYMOUS FUNCTIONS 
val square = (x: Int) = x * x

val printHello = () => println("Hello")

val add = (x: Int, y: Int) => x + y
val sub = (x: Int, y: Int) => x - y



// THE FUNCTION TYPE 
// method syntax
def l(x: String): Int               // String => Int
                                    // for every string, a single integer is defined 

// function syntax 
val l: String => Int 


// Q. how could we complete these defintions? A.  x.length 



// 'FUNCTION' vs METHOD 
// scala reserves the name 'function' to mean a function which can be assigned to a variable, ie., a value -- & theref. available run-time
// scala reserve the name 'method' to mean a function defined lexically, ie., as syntax for the compiler -- & theref. not available at run-time 

val function = (name: String) => name.toUpperCase
def method(name: String) = name.toUpperCase

println(function("victoria"))
println(method("victoria"))

println(function.apply("victoria"))

val fnFromMethod = method _         // wrap up method into a function 

// FUNCTIONS vs METHODS 
def firstName(name: String) = name.split(" ")(0)

println(firstName("Fido Holmes"))
println(first("Fluffy Jefferson"))      // called the same way 

println(first)                       // scala reads a variable containing a value 

// ERROR //  println(firstName)     // scala reads a comand to call a method 


// repl // first. 

println(first.apply("Fido Holmes"))         // first.apply is an apply method of the fido object 
                                            // methods are not objects, they have no methods 


// RECURSION 
val people = List("Michael", "Sherlock", "Fluffy")

//why recursion? 
var str = ""
for(p <- people) str += people 

//or,
str = "" + people(0) + people(1) + people(2)

//or,
str = f(Nil) + f(people(0)) + f(people(1)) + f(people(2))

//or, -- what's going to keep the counter? there's no i += 1
str = f(f(f(f(people))))

// what must f do? 
// peel away list into working-on-bit and pass on rest of it 

/*
f of empty list = "" 
f of non-empty-list = work-on-first THEN work-on-rest
*/


//ASIDE: Pattern Matching lists
val point  = (1, 2)
val (x, y) = point 

val people = "Michael" :: "Sherlock" :: List()
val pets   = "Spot" :: "Fluffy" :: Nil

people match {
  case head :: rest => s"H ${head} R: ${rest}"
  case Nil => "X"
}

// infinte recursion 

def loop() =  loop()

// terminating recursion 
def loop(condition: Boolean) = condition match {
    case true => loop(condition)        //continue
    case false => 0                     //stop
}



val locations = List("UK", "US", "CA")

def join(strs: List[String], sep: String = " "): String = strs match {              // return type required
    case head :: tail => head + sep + join(tail)
    case Nil => ""                                                                  // lists are Nil-terminated
}

val basket = List( ("Lemonade", 4.50), ("Cherries", 3.45), ("Bread", 2.33) )

// def average(cart: List[(String, Double)]) = ???

def average(cart: List[(String, Double)]): Double = cart match {
    case head :: tail => head._2/cart.length + average(tail)
    case Nil => 0
}

/* EXERCISE */

def fact(a: Int, prd: Int = 1) = if(a == 0) prd else fact(a - 1, prd * a)


def factorial(a: Int) = {
  def fact(a: Int, prd: Int) = if(a == 0) prd else fact(a - 1, prd * a)

  fact(a, 1)
}

def fact(a: Int, prd: Int = 1): Int = a match {
    case 0 => prd
    case _ => fact(a - 1, prd * a)
}


// INTERNAL ITERATION VS RECURSION
def factorial(n: Int) = (1 to n).product

locations.mkString " "

(basket map { _._2 } reduce { _ + _ }) / basket.length


//rarely a need, in practice for recursion:
//1. methods should *appear* functional from the outside
//2. internal iterators do 90% of the work 



// HIGHER ORDER FUNCTIONS
def sendMessage(formatter: String => String) {
    println(formatter("Hello -- How are you?"))
}

sendMessage( m => m.toUpperCase )


sendMessage( _.toUpperCase )
sendMessage({ _.toUpperCase })      // braces to group expressions, even though just one here


sendMessage { _.toUpperCase }       // standard form 



// a more complex example 
val add = (x: Int, y: Int) => x + y
val sub = (x: Int, y: Int) => x - y

def reop(op: (Int, Int) => Int, x: Int, y: Int) = op(op(x, y), op(x, y))

reop(add, 1, 2)
reop(sub, 2, 4)


// type aliases may be clearer...
type PairToInt = (Int, Int) => Int
def reop(op: PairToInt, x: Int, y: Int): Int = {
    op(op(x, y), op(x, y))
}


// HOFs which transform function 
val join = (a: Char, b: Char) => "" + a + b

val flip = (f: (Char, Char) => String) => (x: Char, y: Char) => f(y, x)
val rjoin = flip(join)

join('O', 'K')
rjoin('O', 'K')
flip(join)('O', 'K')


// FUNCTIONS AS DATA 
val total = 5 + 5           // data can be combined with operations 

val first = (n: String) => n.split(' ')(0)
val upper = (n: String) => n.toUpperCase

val firstUpper = first andThen upper 
val upperFirst = first compose upper    

println(firstUpper("John Watson"))         

//cf., 
println(first(upper("John Watson")))


// why? for example, to use with HOFs ..
def sendMessage(formatter: String => String) {
    println(formatter("Hello -- How are you?"))
}

sendMessage(firstUpper)



// CURRYING 
val sum = (x: Int, y: Int) => x + y

sum(1, 2)

val sumWith = sum.curried
val sumOne = sumWith(1)
valu sumTwo = sumWith(2)

sumOne(4)
sumTwo(4)

def sum(a: Int)(b: Int)(c: Int) = a + b + c
sum: (a: Int)(b: Int)(c: Int)Int

val addOne = sum(1) _   // _ means "omitting every other argument"
addOne: Int => (Int => Int) = <function1>

addOne(2)(3)

val addOne = Function.uncurried(sum(1) _)
addOne: (Int, Int) => Int = <function2>

addOne(2,3)




// WHY CURRYING?
def configure(host: String, user: String, pass: String) = s"Configuring ${host} (u: ${user} p: ${pass})"

val configureWith = (configure _).curried               // Q. why _ ?  A. configure is a method, cannot .curried on it! 
val configureUK = configureWith("uk-host")
val configureFrance = configureWith("french-host")



//imagine...
def authService(config: (String, String) => String) {
    println(config("authUser", "authPass"))
}


authService(Function.uncurried(configureUK))
authService(Function.uncurried(configureFrance))



// a more complex example...
def repeat (str: String, numTimes: Int) (fn: (String, String) => String) = {
    var result = ""
    for(i <- 0 to numTimes) result = fn(result, str)
    result
}


repeat("!", 10) {
    _ + _
} 

//here last argument is curried so { }-syntax can be used



// RECURSION
// recursion is a form of iteration (looping)
// better-describes some algos. & avoids mutable state 
// recall: new-from-old via function call *is* FP


//return type has to be provided for recursive functions
def fact(n: Int): Int = if (n == 0) 1 else n * fact(n-1)

// tail-calls 
def fn(x: Int): Int =
    if(f(x))
        g(x)
    else
        h(x) + 1


def fac(n: Int): Int = {
    def go(i: Int, acc: Int) =
        if (i == 0)
            acc
        else
            go(i - 1, acc * i)

    go(n, 1)
}

def fac(n: Int): Int = {
    var i = n
    var acc = 1

    while (i > 0) {
        acc *= i
        i   -= 1
    }

    acc
}

// LAZYNESS
def ifS(val cond: Boolean, val trueVal: Int, falseVal: Int) =
    if(cond) trueVal else falseVal

def ifL(val cond: Boolean, val trueVal: <= Int, falseVal: <= Int) =
    if(cond) trueVal else falseVal

ifS(true, fact(100), fact(50))

ifL(true, fact(100), fact(50))



