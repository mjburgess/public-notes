<?php

// the state of a system is "its remembered data at any given moment"
// the state of a light switch might be "on"
// the state of a coin might be "tails"
// the state of a program is all of its present data 

// you can think of a program as comprised of two parts:
// 1. it's state  and 2. the processes that change this state
// or its data and behaviour,  or its variables / functions

// a program is then like a ball of clay (state) that is changed
// into the right shape by a series of mutations (changes) that operate on it


// state comes in two forms: internal and external

//internal state, is as we've seen, just ordinary variables:

$age = 27;
$location = "London";


// let's change this state...

$age++;                                 //recall:  $x++ means "add one to $x"
$location .= ", United Kingdom";        //recall:  $x .= $y means "append $y on to the end of $x "


// and look at the state

echo $age;
echo "\n";
echo $location;



// *external* state, in PHP, also can come in the form of variables:

//1. external *user* state

print_r($_GET);         //recall:  $_GET is information from the URL portion of an HTTP Request
print_r($_POST);        //recall: $_POST is the form information from the request body of an HTTP Request


//2. external *environment* (program/operating system) state

print_r($_SERVER);  // recall: $_SERVER is information from the web server which runs PHP
print_r($_ENV);     // recall: $_ENV is typically information from the operating system or web server
                    // it's about the machine
