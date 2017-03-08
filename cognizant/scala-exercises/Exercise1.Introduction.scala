// CHAPTER:   INTRODUCTION 
// PROBLEM:   Use the compiler, interpret and repl to run scala code.  
// TIME:       25 m

// INTRODUCTION TO EXERCISES 

// most questions are solved by writing code in the file and then running the file 
// solutions are provided -- you can have a look at these if you get stuck 
// however its best to try on your own and wait until the instructor solves the exercise

// before you start an exercise, save a copy to *your home folder* to keep track of your solutions 


// PART 1 -- RUNNING SCALA 
// create a file called HelloWorld.scala 
// it should contain the following...

object HelloWorld {
        def main() {
            println("Hello World!")
        }
}

//Q. run the file via: scala, scalac & scala, sbt, ide 


//Q. modify your main method, define a variable called message
// set message to "Good Day!" 
// print message


// PART 2 -- TRY THE REPL 

//Q. use the REPL to find out what methods today has
val today = new java.util.Date

//Q. try the following in the REPL 
val message = "Hello"
var greeting = "Hello"

greeting += " World"
message  += " World"

//Q. Why does the second operation fail?


// EXTRA

// REPL EXTRA 
//Q. what does CTRL+L, CTRL+A, CTRL+E, CTRL+U and CTRL+K do? -- Mac, Linux users only!
//Q. press CTRL+R, type val, press the right arrow key       -- Mac, Linux users only!

//Q. change the defintion of message so the above operation will work


// HelloWorld.scala EXTRA
//Q. modify the defintion of main to accept an array of strings & print it
//Q. run your program with command line arguments 

// REVIEW: What did you learn from this exercise?
