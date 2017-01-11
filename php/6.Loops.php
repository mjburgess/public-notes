<?php


// so far every line we wrote was run once..

echo "this line is executed once!\n";


//however we can direct PHP to run several lines many number of times

$counter = 10;

while($counter > 0) {
  echo $counter-- . "\n";       // this line is run 10x
}


// here we say that a code block (recall:  { STATEMENT; STATEMENT; ... } )
// is to be run *while* the condition ($counter > 10)  is true

// if we failed to modify $counter within the code block, $counter would always be > 10
// so this would loop forever...!

// instead, within the code block we decrease the value of counter by one (decrement)
// using the -- operator... which decreases by 1


// this process of repetition is called a loop
// while loops can accept all sorts of conditions


$names = ["Michael", "Sherlock", "Watson"];

//recall that count($x) tells you the number of elemetns in $x
// so this loops while there are more than 0 elements, ie. while the array has things in it
while(count($names) > 0) {
    // in here we need to do something so that count($names) eventually becomes 0
    // ie., so the loop stops


    echo array_pop($names) . "\n"; //recall that array_pop() removes one element from the end & returns it
}



// above, the line array_pop() removes an element at a time
// and the loop continues until the array has no elements
// so this loop outputs everythign in the array $names !





// this particular way of usin a loop is known as "iterating over an array"

// and there are two other loops which help with that (while isnt very common)


//there's the for loop:

$menu = ['Blog', 'Forum', 'Guestbook'];

for($i = 0; $i < count($menu); $i++) {
    echo $menu[$i] . "\n";
}


/* SYNTAX

FOR() {
  STATEMENT; ...
}

*/

/* IN DETAIL:


FOR ($VARIABLE_TO_RECORD_INDEX;   CONDITION;   MODIFICATION OF INDEX_VARIABLE) {
  ...
}

*/



// this loop runs through *sequential* arrays only
// it uses the fact that a sequential array has integer indexes (0, 1.., 2...)
// and lets you keep track of an index ($i in this case), whilst increasing that index ($i++) each time round the loop
// so that $menu[$i] is first $menu[0] then $menu[1] etc. all the way until the condition is false

//ie. all the way until  $i == number of elements in menu




// the for loop and the while loop are both less important than the foreach() loop
// which can deal with every type of array and quite easily


//(though its important to know how each loop works!)


foreach($menu as $page) {
  echo "$page\n";
}


/* SYNTAX:


FOREACH( $INPUT_ARRAY   as   $NAME_OF_AN_ELEMENT) {
  ...
}


HOW TO READ:

for every element in menu, call it $page {
    echo $page
}


The "as" can be confusing. Just ignore its english meaning completely.

*/

//the foreach loop has no condition!
// the condition is always "when you get to the end of the array" -- PHP keeps track of that for you.


// with  the foreach loop you specify the array you want to iterate over, eg. $menu
// and what you want to call an element of $menu as you're using it in the code block

// in the code block $page is first $menu[0] then its $menu[1] etc. until the end of $menu


//but foreach works with associative arrays too...

$users = [
  "michael"  => "admin",
  "sherlock" => "guest",
  "watson"   => "author"
];

//what are the elements of $users?

print_r(array_values($users)); //recall: array_values() gives you the values/elements of an array in sequence


//      INPUT_ARRAY   as   NAME_OF_AN_ELEMENT
foreach($users as $accessLevel) {
  echo "$accessLevel\n";
}




// if you want the key as well:


foreach($users as $username => $accessLevel) {
  echo "$username has $accessLevel access!\n";
}


//this works for sequential arrays, but of course, the index is an integer:

foreach($menu as $pageID => $page) {
  echo "$pageID: $page\n";
}
