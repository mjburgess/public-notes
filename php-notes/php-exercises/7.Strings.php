<?php

//Q. define a $names varible which is a string containing a comma separated list of names

$names = "michael,john,burgess"; //comma separated means ...,...,...,..

//Q. explode() this string on the comma, and save the result in $names_array

// "explode on", "split on"
$names_array = explode(',', $names); //split up $names, breaking apart on ,

//Q. echo the first name and its lenghth

echo $names_array[0] . "\n";     //recall: 0th index in $names_array, ie. the first name
echo strlen($names_array[0]);    //recall: strlen() calculates the length (num. chars) in a string

//Q. echo & replace the second name in $names with "Michael"

echo "\n";
echo str_replace('john', 'Michael', $names);

//Q. echo $names
echo "\n";
echo $names;
