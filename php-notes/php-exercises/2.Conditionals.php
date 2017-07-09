<?php

$oneOrZero = rand(0, 1);


// Q. $oneOrZero is, randomly, 1 or 0 -- if it is 1 echo 'blue' otherwise 'green'

if($oneOrZero == 1) {    //recall: == means 'is equal to'
    echo 'blue';
} else {
    echo 'green';
}

echo PHP_EOL;

//"truth"y -- the kind of thing which is true, in particular, any non-zero number

if($oneOrZero) { // false == 0, false, null, '', ... etc. fasle-y
    echo 'blue';
} else {
    echo 'green';
}

echo PHP_EOL; //  \n , \r\n

// Q. define a variable called $favouriteDrink with your favourite drink

$favouriteDrink = 'wine';

// Q. create an if/else statement which tests $favouriteDrink
//... for 'wine' then 'lemonade' then anything else
//... if it's wine echo "you're drunk",
//... if it's lemonade echo "too acidic!" otherwise echo "try something else!"

if($favouriteDrink == 'wine') {
    echo "you're drunk!";
} else if($favouriteDrink == 'lemonade') {
    echo "too acidic!";
} else {
    echo "try something else!";
}

echo PHP_EOL;

// Q. write a switch-case statement that does the same job as the if/else-if/else above

// "switching on $favouriteDrink"

switch($favouriteDrink) {
    case 'wine':
        echo "you're drunk!";
        break;
    case 'lemonade':
        echo "too acidic!";
        break;

    default:
        echo "try something else!";
        break;
}

echo PHP_EOL;
