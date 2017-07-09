<?php

// Q. create an array of your hobbies
//recall: sequential array == collection/groups of things
//recall: associative == single things with many properties

$hobbies = ["photography", "philosophy", "programming"];

// Q. echo out this information

echo $hobbies[0] . PHP_EOL;
echo $hobbies[1] . PHP_EOL;
echo $hobbies[2] . PHP_EOL;

// for each element of hobbies, where $hobby is a particular element
foreach($hobbies as $hobby) {
    echo "$hobby\n";
}

// Q. create an associative array called $me with the keys: name, height, age
//... assign these keys the appropriate values

$me = [
    "name" => "michael",
    "age" => 27.2,
    "height" => 1.81
];

$me = [];
$me['name'] = "Michael";
$me['age'] = 27.2;
$me['height'] = 1.81;

//Q. having defined $me, add username and password entries to 'me'
$me['username'] = 'mjburgess';
$me['password'] = 'test';


//Q. echo out this information

echo $me['name'] . "\n";
echo $me['age'] . "\n";
echo $me['height'] . "\n";
echo $me['username'] . "\n";
echo $me['password'] . "\n";


//for every element of me, where its key is $attribute and its value is $value
foreach($me as $attribute => $value) {
    echo "$attribute is $value\n";
}
