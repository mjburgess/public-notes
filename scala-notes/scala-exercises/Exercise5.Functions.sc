// CHAPTER:   5. FUNCTIONS
// OBJECTIVE: Answer the following questions.
// PROBLEM:   Define functions to handle login and profile information.
// TIME:      25 m

// This exercise has two key parts:
// 1. Defining Functions; 2. Accepting Functions

// in the first part the task is to
// *define a function* that will be passed to a method along with a list
// then call this method with your defined function and a supplied list

// in the second part the task is to do the reverse:
// to *define a method* that accepts a function as a parameter
// then use a supplied function with your method

// DEFINING FUNCTIONS
// the method calcFt that accepts a list of Double
// and makes a list of Double by multiplying them by 3.28 them and
// applying a f: Double => Double   on them
def calcFt(xs: List[Double], f: Double => Double) =
  for(i <- xs) yield f(i * 3.28)

//Q. define a function for use with calcFt which squares its input
// HINT: this function should have one argument, x: Double and return x * x


//Q. what is the type of square?

//Q. define a val areas which is the area of each of three fields bound
// by the following fences  & print it
//HINT: use calcFt with square
val fences = List(3.0, 4.0, 5.0)

// ACCEPTING FUNCTIONS
val join = (l: String, r: String) => s"! $l: $r"

//Q. define a method called printError
// which accepts a level: String, message: String
// and a third parameter, formatter: (String, String) => String
// which is a function with the same type as join above
// the printError method should use formatter
// to format the level and message then print it

val errorLevel = "WARNING"
val errorMessage = "File Not Found"

//Q. use your method with join, errorLevel and errorMessage above

// CURRYING
// Q. redefine calcFt as calcFeet so that its last argument is curried
//HINT: copy and paste the defintion, change the name
//HINT: there should be parentheses around the function argument

// Q. call calcFeet with fences, defining the square function in-line,
// ie. without using a variable

//Q. one pair of parentheses () can substituted for a pair of braces {}
// call calcFeet again with braces around the function argument

//Q. when passing a function as an argument the type of the function
//can be inferred from the method parameter
// call calcFeet again without any type hint


// EXTRA
//Q. define a function to use with login() below
// the username/password pair "guest"/"pa$$" should succeed
// HINT: .reverse

def login(username: String,
          password: String,
          compare: (String, String) => Boolean) =
  if(compare(password, "$$ap")) {
    println(s"${username} allowed!")
  } else {
    println(s"${username} denied!")
  }


// Q. call login defining a function in-line
// HINT: use _

//Q. define clogin a curried version of login
def clogin(u: String, p: String)(cmp: (String, String) => Boolean) =
      login(u, p, cmp)

//Q. call clogin using _ to define the function in-line
// and use braces to group
clogin("guest", "pa$$") { _ == _.reverse }



//Q. define a curried method called retry
// which takes a numTimes as the first argument
// and function (() => Boolean) as a second argument
// it should print "retrying" and call the function numTimes
// or until it returns true
// HINT: for-comprehension from 1 to numTimes
// HINT: use the return keyword explicitly, return unit ()

//Q. call retry, pass a function
// which returns false if a random number is <= 10
// HINT: scala.util.Random.nextInt(100)

// REVIEW: What did you learn from this exercise?