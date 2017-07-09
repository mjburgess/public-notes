<?php

//many programming tasks require collections of collections
//... ie., arrays of arrays, or "multidimensional arrays"


// suppose we want to represent information about two users:

$userA = [
  "username" => "michael",
  "password" => "test"
];


$userB = [
  "username" => "sherlock",
  "password" => "irene"
];


// now we have two associative arrays that let us look up "username" and "password" info.
// ie.,

echo "userA's username is $userA['username'] \n";
echo "userB's password is $userB['password'] \n";


//suppose however we want to output all the information about userA and userB
// we could just write 4 echo statements (2x echo for A, 2x echo for B)
// but what happens if we keep adding users? userC ?  quickly we have to write lots of echo's

// so we put them in an array!


$users = [$userA, $userB];

//now we have

echo $users[0]['username'].  "\n";   //$user[0] *is* $userA  !
echo $users[1]['password'] . "\n";   // this just says "look up 1 in $user, then lookup password on $user[1]"


// this doesnt seem to have helped.. we still need to write lots of echo's -- but wait! we have loops:



foreach($users as $user) {  //$user is first $user[0] then its $user[1]
    echo $user['username'] . ' has password: ' . $user['password'] .  "\n";
}


// the loop above will work regardless of how many users are in $users!
// just one line to deal with however many users we have...





// let's try modelling a shopping cart

//each items has some information about it:

$item = [
  "name" => "cherries",
  "price" => 2.50
];


//and a basket is a collection of items

$basket = [];

$basket[] = $item;      //recall:  this means "add $item at the end of basket"
                        // if you write $x[1] = $y; you add $y at index 1 of $x
                        // if you write $x[] = $y; PHP infers you mean "the next index in sequence"

$basket[] = $item; // let's add it a few times
$basket[] = $item; // let's add it a few times
$basket[] = $item; // let's add it a few times
$basket[] = $item; // let's add it a few times




// now we can loop:

$total = 0;

foreach($basket as $item) {
  $total += $item['price'];         //recall that += $y is short hand for $x = $x + $y
                                    // here it means "add $item['price'] onto $total"
}

echo "the basket total is $total\n";
