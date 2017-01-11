<?php

//thus far we have just been looking at syntax that you can use to build programs

// there's one additional kind of syntax that let's you do a lot called
// "calling a function"
// a function is a named machine for calculating values and performing operations

$message = "Welcome to your new blog\n";

$numCharacters = strlen($message);

//in the above   strlen($message)  is a function call


/*  it follows the pattern:

FUNCTION_NAME (   INPUT   )


where the FUNCTION_NAME above is strlen
and INPUT  is $message
*/



// strlen is known as a function
// it takes input and calcuates a value
// the value strlen calcuates is the number of characters in its input

// the whole expression:    strlen($messsage)     is known as a function call
// you're calling the function strlen, giving it the input $message, and listening for its output

// it's also called running a function,
// in which case the metaphor is that the function is like a machine that can be switched on or off
// strlen is switched on when it's given input between parentheses (round brackets)
// as a result of switching on strlen you get out the value it calculates, ie. the number of characters in $message

// the value a function calculates is known as its Return Value (important term!)

//compare with,

$totalUsers = 100 + 200;

// + is like a function call
// the syntax is   INPUT + INPUT

// we could write this as:     add(100, 200)
// so that add(100, 200)  calculates the value 300


// there are lots of functions provided by PHP...
// the vast majority take some input, and use it to calculate a value
// they may also perform other kinds of operations, like echo'ing


// there are two very useful functions in PHP which do not calculate new values,
//but just display their input:

var_dump($totalUser);   //var_dump()  output technical information about $totalUser

$usernames = ["Michael", "Sherlock", "Watson"];

print_r($usernames);    // displays the array $usernames -- tells you what the indexes and values are
