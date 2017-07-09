<?php

// Q. echo the word welcome followed by a new line

echo "Welcome\n";

// Q. define a variable which refers to your name
$name = "Michael";

// Q. define a title which is your name concatenated to the string "'s Profile"
$title = $name . "'s Profile"; //recall: concatentation == joining together
                               //recall: . operator for concatenation

// Q. define a variable which refers to your height in cm
$height = 181;

// Q. define your age as an integer number of whole years plus a fraction of 12
$age = 27 + (2/12);

// Q. echo out all this information -- use newlines "\n" and tabs "\t" to make it pretty

echo "\n\n";
echo "$title:\n";
echo "\t$name's height is $height cm\n";
echo "\t$name's age is $age\n";
