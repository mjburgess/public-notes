<?php


$url = 'http://example.com/blog';

echo end(explode('/', $url));

//end() returns the last element of an array
// explode('/', $string) breaks $string up into an array, splitting on /




//echo get_include_path()
//    . PATH_SEPARATOR
//    . "C:/Somewhere";

$path = get_include_path()
    . PATH_SEPARATOR
    . "Somewhere";

set_include_path($path);

echo get_include_path();


set_include_path(
  get_include_path()  // returns string of all include-paths separated by PATH_SEPARATOR ; :



   . PATH_SEPARATOR . 'C:/Somewhwere'    // append new path
                                        // ;C:/Somewwhere

);
