<?php

// thus far when creating an object, it was made blank -- with no data held as it come off the factory line...

class Person  {
    public $name;
    public $email;
}

$me = new Person();

print_r($me); // $me's name and email are empty!

// we'd need to give it some:
$me->name = "Michael Burgess";
$me->email = "michael.burgess@qa.com";

//and now...

print_r($me);       //print_r() works well for both arrays and objects!

// we *can* specify what values the object's properties (its data) are going to have
// when we create it..

// to do so we need to define a magic method (function) on the class:

class User {
    public $name;
    public $email;

    function __construct($name, $email) {
        $this->name = $name;
        $this->email = $email;
    }
}

$sherlock = new User('Sherlock', 'sholmes@example.com');

print_r($sherlock);  // $sherlock is not empty!

// you can read 'new User'  as a call to the __construct() function
// which is the function which tells you how Users get made (or 'constructed')

// therefore the parentheses after User() you can imagine are exactly the same as those after __construct()

// the User's construct function takes two inputs a $name and an $email
// and assigns them to the object-in-question's name and email
// in this case, to $sherlock's name and email

$dr = new User('Watson', 'watson@example.com');

print_r($sherlock);     //sherlock has sherlcok's data
print_r($dr);           //dr has watson's data
                        // they were both created with the same constructor



// we can hide an object's data from other objects, and from the outside world...

class Customer {
    private $name;
    private $email;
}

$you = new Customer();

/* uncomment these lines and you will get an error:

$you->name = "Michael"; // error: Cannot access private property Customer::$name

// why? name has been made private, it cannot be access "externally"
*/
print_r($you);      // print_r() let's you see it nevertheless


// *where* can you access $name then? only in the methods of the customer class
// ie. from within the object's own behaviour


class Author {
    private $firstName;
    private $lastName;

    function getName() {
        return $this->firstName . ' ' . $this->lastName;        //we can access them here
    }

    function __construct($first, $last) {
        $this->firstName = $first;          // and we can assign them when we make the object
        $this->lastName = $last;            // ie., construct it
    }
}


$watson = new Author('John', 'Watson');     // set's $watson's properties correctly

/* recall: this will be an errror, because it's private...

echo $watson->firstName;

*/

//we can now only use getName()

echo $watson->getName();        // getName() can access $watson's data, because it belongs to $watson
echo PHP_EOL;  // recall: the newline constant

// what is the accessibility of functions?
// .. by default, they're public.. so may be accessed -- as we have just done above -- "from the outside"

// in PHP however we almost always write the accessibility of functions in anyway:


class Article {
    private $title;
    private $text;

    public function __construct($title, $text) {
        $this->title = $title;
        $this->text = $text;
    }

    public function getPage() {
        return $this->title . PHP_EOL . $this->text . PHP_EOL;
    }
}


$diaryMonday = new Article('One Monday, 2016', "Woe is me! My postcode has three numbers in it!");
$diaryTuesday = new Article('One Tuesday, 2016', "Prada taking over Church's? The Empire has gone!");


echo $diaryMonday->getPage();
echo $diaryTuesday->getPage();
