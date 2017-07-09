<?php

// $news_feed is an empty array

$news_feed = [];


//how many items does it contain?

echo "News feed contains: " . count($news_feed) . " items";


// let's add an item to $news_feed
$news_feed[0] = "The First Item!"; // here we add at the zero index

//we could add at a string index,
$news_feed["top"] = "top of the news feed!";

//we can let php calculate an index for us..

$news_feed[] = "The Next Item"; // this will be the next integer index available, ie. 1

$news_feed[] = "The Next Item"; // this will be the next integer index available, ie. 2

$news_feed[] = "The Next Item"; // this will be the next integer index available, ie. 3


// therefore  $x[] = VALUE;     means "add VALUE to the end of $x"




// we can use functions with arrays...

//let's say i have an array of events where the key of the array is a priority order

$events = [
  10 => "clean the house",
  5 => "go to party",
  3 => "clean clothes"
];


//let's add some that I forgot..

$events[1] = "pick up the kids!";     // high priority


// i can display the array -- print_r means "print a representation of "
print_r($events);


// i can ask if something is in the array

if( in_array("go to party", $events) ) {
    echo "Go to Party is in the events array!\n";
}


// i can ask if there is a particular index in the array


if(array_key_exists(10, $events)) {   // is there an event at index 10 ?
  echo "there is an event with priority 10!\n";
}

// i can remove an event


$lastEvent = array_pop($events);  //removes last element & returns it

echo "the last element is $lastElement\n";

print_r($events); //now contains one less


$firstEvent = array_shift($events); //removes first element & returns it

echo "the first element is $firstEvent\n";

print_r($events); //now contains one less


//suppose i just wanted each event in alphabetical order, rather than at particular prioties..
//i could sort it:

sort($events);

print_r($events);


// let's consider associative arrays now


$user = [
  "username" => "mjburgess",
  "password" => "test",
  "email" => "michael.burgess@qa.com"
];




print_r(array_keys($user)); //array_keys() gives me a sequence of the keys
print_r(array_values($user)); //array_values() gives me a sequence of the values



// whereas sequential arrays are usually used to represent some group or collection of stuff
// an associative array usually represents a single object
// where each element of the associative array describes some feature of that object...


// compare,

$person = [
    'name' => 'Michael',
    'height' => 1.81
];                                           //one person


$people = ['Michael', 'Sherlock', 'Watson']; // three people
