// Q. write a list of full names (eg. Michael Burgess, Sherlock Holmes)

val names = List("Michael Burgess", "Sherlock Holmes")

// Q. write a list of ages

val ages = (8 to 20).toList

// Q. are all the names more than 3 characters?
// Q. is any age greater than 18 ?
//HINT: exists, forall

println(names forall { _.length > 3 })
println(ages exists { _ > 18 })

// println(age.exists((a: Int) => a > 18 ))


// Q. get a list of birth years from the list of ages
// HINT: map

println(ages map { 2016 - _ })

// Q. get a list of names broken apart by space
// HINT:  .split(" ")
// HINT: flatMap

println(names flatMap { _.split(" ") })

//EXTRA:
// Q. use a for comprehension to get the same results as the above questions

println(
    for(n <- names;
        p <- n.split(" ")) yield p
)


(for(a <- ages) yield age > 18) reduce { _ && _ }
