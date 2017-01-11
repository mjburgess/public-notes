<?php
// this is an advanced section!

// so far our functions have all had a fixed number of arguments
//eg.,

function glue($prefix, $message) {
  return $prefix . $message;
}

echo glue('Logging: ', 'EVENT1');

// the function glue has two arguments, and it joins both of them together


// we can however have any number of arguments...


function glue_many($prefix, ...$messages) {
  return $prefix . implode(' ', $messages);
}

echo glue_many('Logging: ', 'EVENT1', 'EVENT2', 'EVENT3');

// ...$messages means "collect together every other argument passed into an array called $messages"

// so $messages is the array: ['EVENT1', 'EVENT2', 'EVENT3']




// recall the principles,
// "the only way to get data into functions is to pass it as a paramter"
// and, "the only way to get data out of functions is to return it"

// these are extremely good principles and the make understanding how functions work
// straightforward and easy to reason about



// however we can  break them:


$myName = 'michael';


function format_name() {
  global $myName;           // this statement makes $myName refer to $myName outside!

  return ucfirst($myName);  //make the first letter uppercase
}


echo get_name();


//"gloabls", ie. variables "taken into" functions from the outside, are generally bad
// they make it harder to see what the function is doing...


// this is much clearer:


function formatName($name) {
  return ucfirst($name);
}

echo formatName($myName); // we put $myName into the function and get a formatted name out



// the global keyword then, changes the *scoping rules*
// it breaks the boundary set by the code block braces {  }


// the static keyword changes the *lifetime rules* ...



function counter() {
  static $counter;

  return $counter++;
}


echo counter() .  "\n";
echo counter() .  "\n";
echo counter() .  "\n";


// usually all data created within a function (i.e, all variables defined there)
// only live as long as the function is being run, and are all deleted when its returned its value
// however static variables live as long as the entire program, not just one function call

// so here we have a counter that "lives past" the first return


// we can replace this with the usual in/out  parameter/return principles this way:


$myCounter = 0;

function increaseCounter($counter) {
  $counter++;

  return $counter;
}

echo increaseCounter($myCounter) . "\n";
echo increaseCounter($myCounter) . "\n";
echo increaseCounter($myCounter) . "\n"; // same effect!


// above then "static" hides the fact that we're really depending on a global variable
// that is, it lets a function create a variable that's only accessible within that funciton
// but lives as long as variables outside functions do: ie. for the whole program






// even more advanced....!


//thus far we have defined "blueprints for machines" called functions
// eg.,

function add($x, $y) {
  return $x + $y;
}


// then we use these machines:

$sum = add(10, 20); // $sum is now 30



// rather than give these machines names however, we can just put them inside a variable:


$add = function ($x, $y) {
  return $x + $y;
};


// this makes the variable $add contain the machine.. so we can call $add:


$sum = $add(10, 20);


// this allows us to pass around functions just like we pass around data:


function show($message, $formatterFunction) {
  echo $formatterFunction($message);
}

// the above is a function of two arguments
// the first argument is a string, a $message
// the second argument is a *function*, a machine for making new strings from old strings


$uppercase = function ($oldString) {
  return strtoupper($oldString);
};

// $uppercase contains a function that makes a string uppercase

$pretty = function ($oldString) {
  return 'The message was: ' . ucwords($message);
};


// we can now call "show" as:


show("my message", $uppercase);
show("my message", $pretty);
