// CHAPTER:   FUNDAMENTALS 
// PROBLEM:   Determine which bar to go to. 
// TIME:       25 m


// PART 1 -- VARIABLES & OBJECTS

//Q. define a val, name, which is your name 
//Q. define a var, age, which is your age 
//Q. define a val, isBirthday, a bool which is whether its your bithday or not 
//HINT: true false 

//Q. if today's your birthday increase your age by 1, otherwise increase it by 1.0/365
//Q. print your age



// PART 2 -- SIMPLE TYPES
val barDistance = 100
val barCrowd = 50
val barBeer = 5

//Q. define isBusy, isFar, isCheap 
/*  the bar is busy if there's more than 25 people
    the bar is close if it is less than 500m away
    the bar is cheap if beer is less than 3.50
*/

//Q. if the bar is near and not busy and cheap print "GOING TO BAR"
//Q. otherwise print "NOT GOING TO BAR"

//Q. if the bar is busy and near OR cheap, print "It'll do"
//Q. otherwise print "Nope, wont do!"



// PART 3 -- COMPLEX TYPES: STRINGS & ARRAYS 
val data = "hobbies:photography-portraiture;programming-functional;drinking-beer"

// val data = "h:p-p;pr-f;d-b"

//Q. define categories 
// it should be a comma-separated string which contains each category of hobby 
// ie., 'photography-portraiture, programming-functional'
// HINT: split :  split ;   mkString(',')

println(s"My Name is $name" )
println(s"My Age is $age")
println("My Hobbies are " + categories)


//Q. if myBirthday is birthday, print "Happy Birthday!"
val birthday = (12, 12, 1912)
val myBirthday = "12-12-1912"

// HINTS: toInt toString ._1 ._2 ._3


//Q. if it's your birthday, and the bar is expensive, print "GOING SOMEWHERE FANCY"
//... otherwise if "beer" is a hobby print, "GOING TO THE ALE HOUSE"
//... otherwise print, "GOING TO THE LOCAL"

// EXTRA


// REVIEW: What did you learn from this exercise?