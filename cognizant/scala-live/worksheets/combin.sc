


val names = List("Michael John Burgess", "Sherlock Holmes")


//Q. with names, using map:
//... obtain a list of the length of each name
//... obtain a list of bools, whether the name .isEmpty
//... obtain a list of the last names

names map { _.length }
names map { _.isEmpty }
names map { _.split(" ").last }

println(names map { _.contains("Michael") })


names forall { _.length > 7 }
names exists { _.length == 7 }

//Q. is the last name of all of your people, >7 chars long?
//Q. does any one in your list of names have a middle name?


names forall { _.split(" ").last.length > 7 }
names exists { _.split(" ").length > 2 }
