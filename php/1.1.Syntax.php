<?php
// this is a single line comment

/*

  This is a comment which spans multiple lines

*/


// this is a variable
$website_title = "My Blog";       // the = operator means "assign"
                                  // it places the text "My Blog"
                                  // into the box called $website_title

const MESSAGE = 'Welcome to...';  // this is a constant
                                  // the assignment operator = places 'Welcome to...'
                                  // in the box named MESSAGE
                                  // but the contents of this box cannot change -- it is constant


/* ERROR:

MESSAGE = 'Something New';

*/


// --- ASIDE ---

//note something so far, every "complete thought" or "smallest meaninful command" in PHP ends with ;
// a semicolon

//the following two commands above (create a variable and create a comment)
//both follow the pattern...

//identifier operator literal-value end
//eg.,   $x = 5;

// --- ASIDE ---

echo $website_title;  // echo means "write out"
echo "\n";            // inside double quotes, \n means a newline



echo "Double quotes support interpolation: $website_title\n"; // interpolation means subtitution
// inside double quotes, variables will be replaced with their values (contents)
// and \n will be replaced with a newline


echo 'Single quotes are strictly literal: $website_title\n';
//inside single quotes all text is treated literally... so that $x means $ then x
//it isnt replaced with the contents of the variable named $x



//variables can contain values of differnt kinds or *types*
// the followings kinds of values are the some of the most important:

//bools or booleans
$isAdult = true;
$isNear = false;    //there are only two values of this kind

//integers (whole numbers)
$heightCM = 180;
$distanceM = 10100; // there are infinitely many integers (on a real machine, memory limitations determine max size)


//floats (partial numbers)
$heightM = 1.81;
$distanceKM = 10.1;

//strings
$name = 'Michael';

//null

$somethingEmpty = null;   // null is the only value of its type
                          // null typically means "without any sensible value"





//each type has special operators...


$myHeight = 181;
$yourHeight = 175;

$averageHeight = ($myHeight + $yourHeight) / 2;

// +  means addition
// /  means division

//these operators can be used with numeric types (eg. int, float)


// there's also increment and decrement which means "add one" or "subtract one"


$website_counter = 0;
$website_counter++;       //add 1
$website_counter++;
$website_counter--;       // sub 1

echo "$website_counter\n";


$numApples = 10;

//we can double numApples in three ways...

echo $numApples * 2;    // this does not change $numApples, which is still 10


$numApples = $numApples * 2;
// this means "update $numApples to be the old value of $numApples * 2"

echo $numApples; // now numApples is different


//finally we can write the above in a shorthand fashion

$numApples *= 2;    // *= 2 means "set to 2x-itself"


// string concatenation (joining)

// the dot operator joins strings together


echo 'this is ' . 'a' . ' test' . "\n";


$prefix = "Logging:  ";
$message = "some event!";

echo $prefix . $message . "\n";
