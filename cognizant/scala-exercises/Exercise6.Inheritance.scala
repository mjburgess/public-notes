// CHAPTER:   INHERITANCE 
// PROBLEM:    
// TIME:       25 m


// PART 1


// Q. create an abstract class Person with a val fullname
//... and an abstract method def getID: String

abstract class Person(val fullname: String) {
    def getID: String

    def getNameID = s"$fullname is ${getId}"
}

//Q. create the classses  Worker with a ni-number whose getID returns an NI number
//.. and a FamilyMember with a role whose getID returns their role (eg. Father)

class Worker(fn: String, val ni: String) extends Person(fn) {
    def getID = ni
}

class FamilyMember(fn: String, val role: String) extends Person(fn) {
    def getID = role
}

//Q. create a List of Person with Workers and FamilyMembers
//loop through the list and print out all their IDs


val people = List(
    new Worker("Michael", "JH 00 00 00 B"),
    new FamilyMember("Michael", "son")
)

for(person <- people) {
    println(person.getID)
}



// PART 2


// 1. define a trait Talker that has a speak method that println's "Hello"

// 2. define a class Dog which extends from this trait and overrides speak to println
//.. "woof"

// 3. define a class Person

// 4. create a List of Talkers which contains Person and Dog objects
//HINT:  new ... with ...

// 5. define a function say() which takes a List of Talkers
//.. it should iterate through this list and ask each to speak




// REVIEW: What did you learn from this exercise?