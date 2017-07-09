<?php

$username = "michael";

function get_username() {
  return $username;
}

echo get_username(); // Q. what does this function return?
                    // A. *not* 'michael' (its an error)


// when dealing with functions in PHP everything within a code block { ... }
// belongs to that function *and only that function*

// recall that a function defintion is really just a blueprint for a machine
// it doesnt actually do anything it only tells you what running the function will do

// so in the blueprint above, we're saying "return $username" but we havent
// any username in our defintion to return!

// this is called "scope" -- functions have their own scope, meaning that everything inside them is just theirs
// there is also the file "scope" sometimes called the gloabl scope
// everything at the file-level is "just the files" it doesnt bleed into functions



// if, when we're defining a function, we're not actually *doing* anything
// when do we actually do it?  -- well, the *call time*, the time when we call it..


function get_fullname($first, $second) {
  return $first . $second;
}


echo get_fullname("michael", "burgess"); // here's the call-time

// at the call time, the time when the function gets called,
//PHP copies the arguments you've listed *into* the variables $first and $second
// then runs the code block

// when calling is finished, ie. when the function returns, all those variables:
// -- the parameters & any defined inside the code block --
// disappear! -- they get deleted because theyre no longer needed

// so in addition to having a "scope" (a place to live)
// variables also have a lifetime: how long they live
// the lifetime of variables inside a funciton is just however long it takes to run that function

// they do not live after the funciton has calculated its return value





//Now, there are some extra features we can use when defininig funcitons...


//1. we can let an argument (aka. paramater) assume a default value if one isnt passed
// when the function is called:


// this defines a machine which takes two inputs
// it's going to return true if the user manages to login
//otherwise false

function login($username, $password) {
    return $username == 'admin' && $password == 'test'; //*
}

//* recall:  && means "true when both conditions are true"
// $x == $y means "true when $x is equal to $y"

// so the entire expression is true when the username is admin
// and the password is 'test'
// otherwise, it's false


//so,

$givenUserName = 'admin';
$givenPassword = '1234';  //suppose from some user input

if(login($givenUserName, $givenPassword)) {
  echo "you're allowed in!\n";
} else {
  echo "you're not allowed in!\n";
}


//now let's modify the login function to assume some defaults

function login_default($password, $username = 'admin') {
    return login($username, $password);       //just call the ordinary login() function
}


$givenPassword = 'test';

if(login_default($givenPassword)) {     // if we only supply the password, $username is assumed to be
  echo "you're allowed in!\n";          // admin
}


if(login_default($givenPassword, 'admin')) {    // we *can* supply the value though..
  echo "you're allowed in!\n";
}


//notice that above in the login_default() definition we've reversed the order of the parameters
// this is, unfortunately, required for default parameters: they must come last in the defintion



//2. calling functions


//suppose we had the following functions:


function output_blog() {
  echo "THE BLOG!\n";
}

function output_homepage() {
  echo "THE HOMEPAGE\n";
}

// and we had the url...

$url = 'http://example.com/blog';


//how could we call output_blog() *given* the url? well...


switch ($url) {
  case 'http://example.com/blog':
    output_blog();
    break;

  case 'http://example.com/':
    output_homepage();
    break;
}



// we could also get just the 'blog' part of the url, ie. the final bit


$finalBitOfUrl = 'blog';  //pretend we can easily get the last bit

//NB: an expression which would get the last bit: array_slice(explode('/', $url), -1)[0]


//now how can we connect $finalBitOfUrl to the function output_blog?

//there's a special function in php called call_user_func() which takes a string as input
// and calls the function with the same name as that string...


call_user_func("output_$finalBitOfUrl"); // calls output_blog !
