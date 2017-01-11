<?php

// the style of programming which phrases problems as an interplay between objects
// is known as object orientation -- as in, to orient the design of the program around objects

// the technical name for 'styles' is paradigms

// the paradigm which restricts itself to inert data and processes which change it,
// ie., variables and functions
// is known as procedural programming -- meaning to program with procedures (data-modifying functions)

// displined design and attention-to-detail in both paradigms leads to good programs
// and a lack of displine and clarity leads to bad programs

// historically, in PHP, most programs were very poorly designed and in a *somewhat* procedural manner
// eg. rather than have bake_cake(), add_flour(), put_on_oven(), etc.
// they may have a single function called "kitchen" that takes in every input and makes an entire larder
// and so this "do everything" function could span 100s - 1000s lnes

//therefore contemporary PHP programmers have a somewhat instinctual aversion to procedural programming

// however a lack of discpline within object oriented programming can easily lead to much greater catastrophies.

// what does 'displine' mean with respect to procedural programming?

// 1. small, well-defined, well understood functions that have one -- and only one -- small job to do
// 2. functions take input via argument and provide output via a return
//... -- no magically changing things outside functions (eg. using the global keyword)

// 3. clear and consistent data defintions (eg. using the same keys in all your associative arrays about the same item)
// 4. using many files and includes to separate out related functions from unrealted functions
// 5. clear separation between data and functions responsible for "different kinds of logic"

// if you follow those guidelines your programs will be easy to reason about (understand & predict)
// and therefore easy to modify, extend, communicate, debug, describe, test etc.

// if you do not follow these guidelines at least two things happen:
// 1. your programs become brittle (a small change at one point fractures -- breaks -- many other points)
// 2. your programs become inealistic (everything binds tightly together so you cannot modify, extend, repurpose it)

// these are not technical terms
// (technically, we would speak in terms of complexity, cohesion, coupling, modularity, abstraction, ...)
// and we may get on to what each of these mean





// let's return to point (3) -- separation into "different kinds of logic"

// what kinds of "logic" are there?
// there's no single answer but often code is split three ways:

//1. code concerned with the displaying and templating of information (eg. echo's, print_r's, etc.)
//2. code concerned with the information itself (eg. querying the database, reading files)
//3. code concerned with changing the information based on problem-domain descision
//.. ie., decisions specific to your problem, eg. if($age < 18) {}  , if($readyToLeave) { closeDoor(); } , etc.

// these three kinds are known as: display or view logic, data logic, and domain/decision/business logic
// domain meaning "problem domain", ie. the area you're working in


// when it comes to object oriented programminig, we would like to give each kind of logic to one kind of object

// so we will have objects responsible for displaying informaiton, for changing it, and for making/getting/representing it

// this is the meaning behind MVC = model, view, controller
// models are data-objects,  views are viewing objects, and controllers are controlling-objects



class Person {              // the model
    public $name;
    public $age;
    public $height;
    public $email;
    public $access;
}

class PersonDisplayer {     // the view
    public $title;

    function show($person) {
        echo $this->title . ': ' . $person->access . PHP_EOL;
        echo $person->name .   PHP_EOL;
        echo $person->age  .    PHP_EOL;
        echo $person->height . PHP_EOL;
        echo $person->email  .  PHP_EOL;
    }
}

class PersonChanger {       //the controlelr
    public $minimumAge;
    public function checkAge($person) {
        if($person->age < $this->minimumAge) {
            $person->access = 'DENIED';
        } else {
            $person->access = 'ALLOWED';
        }
    }
}

$me = new Person();             // make an empty Person
$me->name = 'Michael';
$me->age = 27;
$me->height = 1.82;
$me->email = 'michael.burgess@qa.com';          //give it some data


$controller = new PersonChanger();  // make a controller
$controller->minimumAge = 18;       // configure it
$controller->checkAge($me);         // let it "control" the person


$viewer = new PersonDisplayer();   // make a displayer (view) -- the object which displays the model
$viewer->title = "Custom Viewer"; // configure it -- give it data

$viewer->show($me);         // use view to display $me



// the system is then:

// input data -> controller -> new data -> view -> output

// with each object: the model, the controller, the view being configurable

// the view is a bit like the television set which you can say, change the contrast on
// the model is a bit like the incoming signal
// and the controller is a bit like a Sky TV box which understands the signal and modifies it


//there's something interesting about this line, above:

/*
    $controller->checkAge($me);         // let it "control" the person
*/

// there's no assignment operation on this line (no = sign)
// and yet after calling the function $me is different ($me->access has changed!)


// recall we said that functions can only influence the outside world with their return value
// they take input and return output, any changes inside are "locked inside" and do not leak out

// this is false!

// it's especially false when it comes to objects
// if you pass in an *object* , any changes to the object *will* be reflected after the function has returned
// indeed none of the functions above have return values!


// in the halcyon world of *disciplined* procedural programming
// we almost always could determine if a change occured: the line would have an equals sign (assignment operation)

// if there were no equals sign on a line, in our displined programs, it was unlikely anything was being changed

// now: who knows?
