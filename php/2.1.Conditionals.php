<?php

//recall boolean values: there are only two of them!

$isNearPub = true;
$isBusyPub = false;


//--- ASIDE ---
//the values true, false represent conditions being met
//or in otherwords, they tell you if a particular description is correct or not

// if you say $isNearPub = true, then you mean the pub is near

// often the world "is" gets added to the begining of a variable which contains a boolean
// to indicate that its answering a question (is the pub near?  yes/no  true/false)

// in this way booleans are a special kind of "yes/no"
// they're "yes/no" to descriptive questions

//(NB. while you can say "yes, i'll have a beer" you cannot say, "true, i'll have a beer")
// --- ASIDE ---


//boolean values have lots of special operators...

$age = 18;
$isAdult = $age < 18;     //  the < operator means "less than"
                          // $age < 18   calculates the value false


// --- ASIDE ---
// any bit of code which "calculates a value" (eg. 2 * 4) is known as an expression
// typically, we say that "expressions evaluate to a value"  rather than "calculate a value"
// so, aprox., evaluate means calculate
// --- ASIDE ---


// the following operators all evaluate to booleans (calculate either true or false)

$isAgeEqualTo18 = $age == 18;   // == means  'is equal to'
$isAgeNot18 = $age != 18; // != means 'not equal to' -- generally in programming, ! can be read as 'not'


$isRetired = $age > 65;         // >  means greater than
$isRetired = $age >= 65; // >= means greater than or equal to

// we also have:  less than <,  less than or equal to <=, etc.



// we can combine boolean values in the same way we can combine truth in the ordinary sense:


$isNearPub = true;
$isBusyPub = false;

// is it true that the pub is BOTH near AND  busy?

$isNearBusy = $isNearPub && $isBusyPub; // && means "and" or "true if both conditions are true"

// $isNearBusy is false because both conditions, $isNear and $isBusy are not true -- $isBusyPub is false

// is it true that the pub is EITHER near OR busy?

$isNearOrBusy = $isNearPub || $isBusyPub;  // || means "or" or "true if any condition is true"

//$isNearOrBusy is true then, because one of the conditions is true, namely $isNearPub

//finally, the ! not operator reverses the condition: so that false -> true and true -> false


// is it the case that the pub is BOTH near AND NOT busy?

$isNearQuiet = $isNear && !$isBusy;
//              true  && !false ==  true && true == true



// we can use these operators to make decisions in our program


$userPassword = "test";
$correctPassword = "TEST";

$isUserAllowedIn = $userPassword == $correctPassword; // true if $uP equals $cP
//..so false: the user is not allowed in


if(!$userAllowedIn) {
  echo "You're not allowed in!\n";
}

// look at the syntax..

/*

IF ( CONDITION )  {
  COMMAND;
  COMMAND;
  COMMAND;
}


the code between { } is known as a code block, it bundles up a sequence of commands
and ties them to a particular preceeding context

here the context is that the CONDITION is true

So the code block is only run, ie. its commands executed, if the condition is met.

NB: the technically correct word for command is "statement"
cf. expression -- expressions calculate values;  statements "do something"
*/

if($userAllowedIn) {                // this code block runs if the condition is true
  echo "You're allowed in!\n";
} else {                            // this one if the condition is false
  echo "You're not allowed in\n";
}



// we can have many conditions

$age = 20;

if($age < 18) {
  echo "You're not allowed in\n!";
} else if ($age > 21) {
  echo "You're allowed in!\n";
} else {
  echo "You need special permissin to come in!\n";
}




/* syntax involving code blocks tends to follow the pattern..


KEYWORD ( CONTEXT ) {
  STATEMENT;
  STATMENT;
}

the keyword and context tell you what the block of code is for..
*/



// there is one special type of condition in programming which is so common
// it has special syntax for it...

$websitePage = 'forum';


switch($websitePage) {      //compare the value of $websitePage to various cases
  case 'forum':             // if $websitePage == 'form', ie., if its the case that $websitePage is form
    echo "You're in the forum!\n";    // run this command
    break;                            //stop

  case 'blog':
    echo "You're in the blog!\n";
    break;

  default:      // if none of the cases above matched, run this
    echo "You're somewhere else!";
    break;
}



// the keyword "break" above means "jump to the end of the braces"
// often in code blocks (ie. { STATEMENT; ... }) you can use the keyword "break"
// to leave the context you're in -- ie. get out of that particular block




// technically what we've been looking at is control flow statements (if, else, switch...)
// these statements change the flow of the program given certain conditions
// and "break" is a jump statement which changes the control flow
// and break just means "stop here and move on!"

  
