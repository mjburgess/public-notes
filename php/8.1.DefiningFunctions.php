<?php


//recall that a function is a machine for performing operations
// generally, functions take INPUT and return OUTPUT

// for example, recal that we can calculate the number of elements in an array with count()


$basket = ["lemons", "oranges", "grapes"];

$numItems = count($basket);  // count is a function


// functions can take more than one *argument* as INPUT:


$hasGrapes = in_array("grapes", $basket); //recall: in_array($x, $y) returns true if $x is in $y

//here in_array() is a function with two *arguments* or parameters


// functions always have only one return value, but in general can take any number of paramters



// we can define our own functions:

// suppose i want a function called basket_information()
// i want basket_information() to take a $basket as input
// and echo out various bits of information about it


function basket_information($basket) {
    echo "your basket has: " . count($basket) . " number of items\n";
    echo "your basket contains: \n";

    print_r($basket); //recall: print_r() displays information about an array
}



/* SYNTAX:

function  FUNCTION_NAME (INPUT ARGUMENTS, ... ) {
  STATMENT;
  STATEMENT;
}

*/


// here we're just defining a funciton, that is, giving the blueprint for how the machine works

// this blue print says "there is a machine called basket_information that takes one argument, that is, one piece of input"
// ... "with this input it does the following { ...   CODE BLOCK ...}"


// in this case "the following code block" means echo'ing some info. and then calling print_r()

// note that we haven't yet *used* this machine, we've only defined what it does

basket_information($basket); // here we call the function we've just defined, ie. "use the machine"



// why would we want to define our own functions?


// functions basically represent the *processes* of the problem we're interested in..

// for example if we're interested in how many people are in a room then we have to
// consider a few relevant items:

// 1. people
// 2. the room
// 3. people leaving the room
// 4. people entering the room


// in the above list 1 & 2 are *data* (variables): they're describing *things*
// 3 & 4 are *functions*: they're describing *processes*




// let's break down the problem above then..


$room = []; // array of people

$personA = 'Michael';       // people...
$personB = 'Sherlock';
$personC = 'Watson';


function enter_room($room, $person) {
  $room[] = $person;    //add person to the room

  return $room;         // return the room
}

function leave_room($room) {
  array_pop($room); //remove last element of room, ie. the last person leaves

  return $room;  // return the room
}





// we've defined the machines above.. now let's use them:

// set room to be the value enter_room() returns, ie. the array with $personA in
$room = enter_room($room, $personA);
$room = enter_room($room, $personB);
$room = enter_room($room, $personC);    //all the people enter the room


print_r($room); // show the room with all the people in


$room = leave_room($room); // remove the last person

print_r($room); // now there's one less person there..



// here then we've used functions to break down our problem into simple *named* operations
// that make it clear what we're doing:  leave_room and enter_room

// that's perhaps the most important use of functions:
//helping you break down a problem into small *processes*



// the other use, as shown above, is to make it easier to repeat an operation
// as, for example, above we call enter_room() multiple times

// suppose enter_room() was very complex: then we would save having to copy and paste over and over


//NB: copying and pasting code is generally a sign you need a function to make things clearer and more reliable


// ASIDE: the following more useful, and more complex function
// removes a particular person, rather than the last one:


function leave_room_by_name($room, $person) {
  if(in_array($person, $room)) {            //if the person is in the room
    $index = array_search($room, $person);  // find the index of $person in $room

    unset($person[$index]);                 // delete that index
  }

  return $room;     // return the room
}


//eg.

$room = leave_room_by_name($room, 'Watson');
