<?php

//in the conditionals section, every condition used was obviously a boolean: either true or false

// for example,

$amountOfLuck = 10;

$isLucky = $amountOfLuck > 100;  // false, since 10 is not greater than 100

// so,

if($isLucky) {
    echo "You win!\n";
} else {
    echo "You Lose!\n";         // this one is run!
}


// in PHP, however, we can convert every non-boolean value (int, float, string, etc.)
// into a boolean very easily



$numberOfPeople = 0;
$amountOfApples = null;
$message = '';
$id = '0';
$collection = [];  //empty array, we'll discuss arrays next


// all of the above variables, whilst not boolean, evaluate to false
// when put into a context that requires a boolean, for example, an if-else statement


if($numberOfPeople) {           // 0 == false
    echo "NumPeople > 0\n";
} else {
    echo "NumPeople is 0\n";
}
                            //recall:  ! means not
if(!$message) {             //  '' == false therefore   !'' == true
    echo "message was empty!\n";
}
