// CHAPTER:   FUNCTIONS 
// PROBLEM:   Define functions to handle login and profile information.
// TIME:      25 m

// Q. define a function which takes a csv string and returns its parts
val exampleCSV = "jefferson, pa$$, virginia, president"

def csvParts(csv: String) = csv.split(", ")

println(csvParts(exampleCSV)(0))

//Q. define a function called last which returns the last part of your name 
val last =  (name: String) => name.split(" ").last

//Q. define a method that accepts a function as an argument 
// the method should call the function with "Thomas Jefferson"
// and print the result


//Q. define an annoymous function to use with login() below
//.. pass the username and password above along with your annoymous function 
CORRECT = "$$ap"

def login(username: String, password: String, compare: (String, String) => Boolean) = if(compare(password, CORRECT)) {
    println(s"${username} allowed!")
} else {
    println(s"${username} denied!")
}

//Q. define printProfile, a function of an abitary number of arguments which prints all of them 
printProfile("Irene", "Paris", "45")


//Q. define a recursive function which produces a csv string of the first names of a list of people 
val people = List("Sherlock Holmes", "Thomas Jefferson", "Elizabeth II")



//EXTRA:


// REVIEW: What did you learn from this exercise?