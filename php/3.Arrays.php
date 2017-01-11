<?php


//thus far our variables have contained one value only

$websiteHeading = "My Dog's Favourite Toy!";

// we can however put multiple values inside variables
// so that one variable contains multiple items


$headings = [
  "My Dog's Toy",
  "My Cat's Toy",
  "My Rabbit's Toy"
];

//the syntax is:  [  ITEM, ITEM, ITEM ]

//compare with general assignment:
// $variable =  EXPRESSION  ;
// where EXPRESSION is any peice of code which evaluates to a value

// when defining a variable,  the square brackets mean it contains "many values"
// the name of a many-valued item of this kind is an array


// all arrays have an index (or key) associated with their items (or elements)
// this index can be used to look-up the particular element


//the index of "My Dog's Toy" is 0

echo $headings[0];  // here [0]  means "look-up the item at the index 0"

// if PHP isn't told what index your element will have, it will provide one for you:

$headings = [
  "My Dog's Toy",       //0
  "My Cat's Toy",       //1
  "My Rabbit's Toy"     //2
];


// the indexes PHP provides are always integers (whole numbers), increasing by 1 starting from 0

// arrays which only have these kinds of indexes are known as sequences, since each item is in sequence

echo $headings[0] . "\n";
echo $headings[1] . "\n";
echo $headings[2] . "\n";




// we can manually specify different indexes however...

$websiteUser = [
  "username" => "michael",             //key: username
  "email" => "michael.burgess@qa.com"  //key:  email
];

//compare with

$anotherUser = [
  "michael",                  //key:  0
  "michael.burgess@qa.com"    //key:  1
];


//so,

echo $websiteUser['username'] . "\n";

//or

echo $anotherUser[0] . "\n";



// when we manually give keys to arrays we usually use strings
// so that its easier to look things up in an array...

//its much easier to see that $websiteUser['username'] finds the username of $websiteUser
// than $anotherUser[0] finds the username of $anotherUser


// arrays which have string keys like this are known as associative:
// so there are two main types of array: sequences and associative
// or the ones where PHP gives you an index, and the ones where you specify a string yourself




// finally,  assocaitive arrays are usually used to represent one object with several parts or properties,
//eg.


$myDog = [
    'name' => 'spot',
    'breed' => 'jack russell'
];


//where as sequential arrays are usually used to represent a collection of several objects

$dogs = ['spot', 'fluffy', 'peaches'];



// with the associative array we're saying, $myDog has a name, and $myDog has a breed
// with the sequential array we're saying we have some dogs: spot, fluffy and peaches
