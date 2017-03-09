// CHAPTER:   IMPORTS  
// PROBLEM:    
// TIME:       25 m
 

// OPTION
//Q. define a function getProfile() that calls scala.io.StdIn.readLine
//... expecting an input of sherlock,pa$$
//.. the function should return an Option of Person
//ie., None if the password isnt "pas$$"


//Q. define a function getDetails that calls scala.io.StdIn.readLine
//.. expecting an input of: Sherlock Holmes,27,1.81
//.. the function should return an Option of Person
//ie., None if the details are malformed


//Q. using a for-comprehension and your above functions get a username and password,
//.. also get a fullname, age and height if the password is pa$$


// TRY 
//Q. redefine getProfile, getDetails to getProfileX, getDetailsX
//in each case now throw an IllegalArgumentException exception when an error occurs 

//Q. define a function getUser which uses Try/pattern-matching and the above functions 
// to get a user details as before


// SOURCE + JSON 

//Q. use the Source scala library to read http://jsonplaceholder.typicode.com/users 
//Q. use the json4s (ie., lift-web) json library to parse this into case classes


// REVIEW: What did you learn from this exercise?