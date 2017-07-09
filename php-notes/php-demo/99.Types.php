<?php

// the word 'type' has a technical meaning in programming
// it tells you what kind of value is inside a varible:

//recall:

//int

$age = 18;
$height = 181;

// bool

$isReady = true;
$isCold  = false;       //there are only two values of type bool!

//float

$distance = 100.0;
$weight = 15.5;

// string

$name = "Michael Burgess";
$friend = "Sherlock Holmes";
$message = "Hello!";

// arrays

$collection = [$name, $friend];  //sequential

$person = [
    'name': $name,
    'age': $age
];                                // associative



// it's important to keep track of the type of variables

// above the type of $person is an "associative array" or just array
// the type of $name is string, and so on

// while the type of $collection is a sequential array
// the type of $collection[0] is a string

//let's show that:

echo gettype($collection) . "\n";
echo gettype($collection[0]) . "\n";


//or more obviously,

var_dump($collection);
var_dump($collection[0]);


//recall that,

echo $collection[0] . "\n";

// just echo's $name, which is a string, so $collection[0] is a string


// importantly, in PHP, you can convert between different types of variable


$isTrue = (bool) 1;
$isFalse = (bool) 0;

var_dump($isTrue);
var_dump($isFalse);


//... TODO: casting, automatic casting, etc.
