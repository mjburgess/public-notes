<?php

//1. isset and empty


//Q. does the variable $name exist in this file?
//A. no

// -- but how do I find out?
// I can read the file, but I have include'd many files.. and that would take forever;
// and, indeed, a variable might be defined inside a condition that ends up being false.

// if I write

/*
  if($name) {
    echo "name exists!";
  }
*/

// I get an error, because I'm using a variable that doesn't yet exist..


// PHP has some special "language constructs" (functions, basically)
// that let you ask questions about variables that might not yet be defined


if(empty($name)) {  // asks if $name has a non-empty value
    echo '$name is empty!' . "\n";
}

//empty means: not yet defined, an empty string '', an empty array [],  0, null or '0'
// everything else is not empty


// the (aprox.) reverse operation is:

$name = "something";

if(isset($name)) {
    echo "name exists, its: $name\n";
}


//isset() tells you if $name exists or if it is any other value than null
//so isset() returns true if $name is 0, false, '', etc.
// ie. it isn't testing for non-emptyness; its testing to see if it has any value at all

//isset() and empty() are two very important pieces of PHP that let you determine
// if you have any useful information or not
// they can be used without causing errors, unlike other appraoches



//2. ternary


// there is a very common pattern in programming:
// selecting a value for a variable if some condition is met


$age = 27;

if($age >= 18) {
  $message = "You're allowed in!";
} else {
  $message = "You're not allowed in!";
}


// here we're selecting between two different values for $message
// given a condition (the person is an adult)



// there is an operator that allows you to do that all in one line:


$message = $age >= 18 ? "Allowed" : "Not Allowed";


/* SYNTAX:


CONDITION ?  VALUE-IF-TRUE : VALUE-IF-FALSE

*/


echo $age >= 18 ? "Allowed" : "Not Allowed";


// everythign after echo is an expression: it calculates a value

// it calculates "Allowed" if >=18, "Not Allowed" otherwise



// 3. null-coalesing
