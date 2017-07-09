<?php

// when writing larger PHP application we will have many functions...

function user_login() {}      // these functions do nothing! they return the value null
function user_register() {}
function user_forgetpassword() {}

function view_page() {}
function view_article() {}


//putting them all in the same file would make understanding them and
//maintaining them a nightmare

// so we break them into multiple files

//for example, there are two files in this folder:  9.2.IncludeMe.php and 9.2.IncludeMeToo.php

//we can use PHP's include statement to cut-and-paste the contents of those files
//into this one...


include '9.2.IncludeMe.php';
include '9.2.IncludeMeToo.php';


//this is almost a literal cut-and-paste: whatever code is in 9.2.IncludeMe.php
// gets put exactly where the include statement is


// however: where does include know where to look?

// if its an absolute path, eg. C:\Users\Michael\foo.php then its unambiguious
// if its a relative path, eg. 'documents/myfile.php' it could be anywhere..

// thus PHP has a special configuration value called "the include path"
// which contains a list of all the directories to look in for your file
// PHP will always start looking in the present directory, and then look through the include path


// you can set the include path with the function set_include_path();
// more on how to use that function later...


// there is also 'require':

/*
require '9.2.IncludeMe.php';
*/

// require does the same job but if it cannot find the file, stops the program
// include gives you an error but its not "strong enoug" to stop the program


// finally: include_once and require_once  are safer versions
// whereas require and include will let you include the file multiple times
// include_once and require_once will ensure you've only used it once


// NB: there are cases when you may want to include a file multiple times,
//e.g. if that file just contains an echo statement & you want to echo multiple times
//in general however including the same file twice+ will give you errors
//esp. for example, if you've defined functions -- because you cannot define a funciton twice
