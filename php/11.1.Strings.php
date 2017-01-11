<?php
// now let's look at strings in detail

//Q. what is string?

//A. text within quotes
//A. a sequence of characters  (a character is "one symbol of text")



$message = 'Hello';

//recall:   $x[0] means lookup 0 in $x

echo $message[0];   // so this is H
echo $message[1];   // and this is e
echo "\n";

//and so on...

//Every sequence has a "length", ie. the number of items in that sequence...

// strings have a length
echo strlen($message);   // length == number of items == number of characters


// we can change the case of strings:

echo strtolower("this is a message!");
echo strtoupper("this is a message!");
echo ucwords("this is a message");   // sometimes called "title case"



// we can replace "substrings" (parts of a string) with other strings..

$quote = "be the change you want to see in the world!\n";

$new_quote = str_replace("world", "bedroom", $quote);

echo $new_quote;
echo $quote;      // $quote is unchanged



// str_replace() takes in a string and makes a new string
// it replaces all the occurances of its first argument with its second argument
// in its final argument




// now suppose we want to get an array of pieces of a string:

$pieces = explode(' ', $quote); // this breaks a part $quote, splitting it at every space

print_r($pieces); // $pieces is an array of all the bits


// suppose we have an array of strings and we want to join them all together:


$names = ["Sherlock", "Watson", "Fluffy"];

$joined = implode(',', $names);   // this glues each piece together, putting a comma between them


echo "At the crime scene there were: $joined\n";


// implode() and explode() are important functions

// often you will want to look at just the individual parts of a string
// or you'll want to take lots of strings and join them up.

//remember:    ['strings'] -> 'string'    is implode()
//             'string' -> ['strings']    is explode()


// there is a more advanced usage of str_replace()

echo str_replace(["the", "you"], ["a", "she"], $quote); // advanced!

echo $quote;  //recall: this doesnt change quote, it makes a new one


// in the advanced case, str_replace() replaces all the strings in the first array
// with the strings in the second array
// in its final argument

// this is a bit like a mail merge, or templating, usage
// you could imagine:

/* FOR EXAMPLE:

str_repalce(['#NAME', '#TITLE', '#COUNTRY', ['Michael', 'Mr.', 'UK'], $letter);

*/



// substr() is a function which gets part of string
$firstPart = substr($quote, 0, 2);  // start at 0 and get 2 characters

echo "$fistPart\n";

// with substr() and some other functions in php, you can supply a negative position:

$restOfQuote = substr($quote, 2);
              // from $quote, start at 2, copy till the end

echo "$firstPart\n";

// concatenation == joining
echo  "I don't like " . $restOfQuote . "\n"; // the . operator joins strings together



// interpolation == substitution

echo "$newMessage, you're early!\n";  //recall: *double quotes* interpolate
echo '$message, you\'re early!';      //recall: *single quotes* do not


// formatting strings -- ADVANCED:

$height = 1.8133908;
echo "$height\n"; // gives us the all the information

printf("%.2f\n", $height); // just gives us two decimal places


// printf() takes one required parameter (the first) and then any number of subsequent ones

// the first paramter is a string which defines how every other parameter will be printed
// specifically, how they will be formatted

// in the format string every % sign is replaced with a parameter
// the .2f means the first parameter will be formatted as a float (partial number)
// with 2 decimal places


// the printf() function is quite powerful and complex..
// though not used that much in web programming, because a lot of formatting is
// done through CSS
