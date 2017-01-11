<?php
// thus far programs have been comprised of two distinct parts:  state (data) and state change (behaviour)

//to represent data, we used varaibles:

//1. state = remembered data
$name = "Michael Burgess";


//to represent processes which change data we used functions:
//2. behaviour = function = process
function marry($name, $surname) {
    return $name . "-$surname";
}


// recall: these statements really only *define* what 'name' and 'marry' mean
// they don't *do* anything yet

// when we want to "take action" we call the function using variables
// ie. combine the data and the processing
$name = marry($name, 'Mattel');

echo $name, PHP_EOL;

// data is here 'inert' -- it doesnt *do* anything
// rather, things (functions) do things to it

// this is sometimes known as a verb-noun style:

echo marry($name, 'Vanderbilt'), PHP_EOL;  //verbs == actions come first, then data


//imagine now a different kind of world, where "data" *itself* does things
// it isnt static, but you can ask questions of it, or give it orders, and it will react

// this kind of data is known as an "object"
// we ask things of objects using an arrow

/* this code doesn't yet work, it's just a sketch:


echo $person->name;         // read as "ask $person for its name"

$person->eat('apple');      // ask $person to eat()

echo $person->weight;       // ask $person its weight

*/


// objects like $person, therefore, have a dual nature:
// they contain data properties like name  *and* behavioural methods like eat()

// really, all we have done is "cram related variables and functions" inside one $object
// however the concequences for how we design programs this way are far-reaching

/* compare:

person_marry($name, $new_surname);

$person->marry($new_surname);           //marry() 'already knows' what its name is

*/


//the second style is noun-verb:  the action comes after the data

//programs can be designed well in both styles (technically 'paradigms') but the latter
//is preffered in contemporary PHP development.



//above I had assumed that objects such as $person already existed.. but they do not
//the code above is broken: there is no such thing as $person
//so lets create one...


//in order to create objects we need to define a blueprint or specification
//that tells PHP how they are made...


class Person {
    public $name;

    function eat($food) {
        echo $food . ' get eaten!';
    }
}

// here we have defined a blueprint called Person
// this is purely defintional.. no opperation has taken place

// this blueprint says that when we create *particular* people, ie. Person-objects
// then each of these objects will have a publically-accesible name, and be able to eat()
// (ignore the publically-accessible bit now and just read as "having a name")

//let's create an object of type Person

$me = new Person();

// here is the 'new' operator
// on the RHS of the 'new' operator we place the name of one of the blueprints we've just defined

/*
OBJECT =  new ... (); // where ... is the blueprint, ie. the class name
*/

// it produces a particular example, an instance, of that blueprint
//ie., a person object and we assign this object to $me

// the blueprint says "every Person has a name and can eat" therefore,

$me->name = "michael";      //compare this with the class defintion above
$me->eat('apples');

//we can also make another, totally different object:

$you = new Person();
$you->name = "sherlock";
$you->eat('cherries');

//the 'new' operator works like a factory... it takes in the name of a specification and makes objects that match it

// $me and $you are both of type Person, therefore they both have a name and both can eat()
// however each has different *particular* data: my name is different to your name

// the english meaning of 'class' is 'group'
// we can also think of blueprints as telling us what everything in the group 'Person' has
// ie. what [$me, $you] have in common


// now let's create a recipie:


class Recipie {
    public $flour;
    public $sugar;
    public $butter;

    function bake() {
        echo "baking @ 180C for 15m\n";
    }
}


//this blueprint tells us what each *particular* recipe will have:
// it will have an amount of flour, an amount of sugar and an amount of butter..
// and it will be able to bake

// so if i have..

$shortbread = new Recipie();

// then i know i can write:

$shortbread->flour = 6;     // set the recipie's amount of flour
$shortbread->sugar = 6;
$shortbread->butter = 6;

$shortbread->bake();        // ask the recipie to bake


// we have a problem though: the baking function (method, when in a class-context) doesnt mention the ingredients

// the problem is that a defintion is general, but we want to mix the actual amount of ingredients we have
// so we need, in the defintion of bake() to refer to $shortbread's particular amounts...

// the general defintion doesnt know which amounts we actually gave the object
// the general defintion is just a blueprint

// so in the blueprint there needs to be someway of saying "the particular amount of flour + the particular amount of butter "

//let's create a kind of recipe which can do this:

class BakeRecipie {
    public $flour;
    public $sugar;
    public $butter;

    function bake() {
        echo "mixing $this->flour oz flour with $this->sugar oz sugar and $this->butter oz butter\n";
        echo "baking @ 180C for 15m\n";
    }
}


// $this is a placeholder-variable...

// since this is just a defintion $this->flour has no actual value...
// its just a slot that will be filled with the particular amount we assign to the particular object


$short = new BakeRecipie();
$short->flour = 6;
$short->sugar = 6;
$short->butter = 6;

$muffin = new BakeRecipie();
$muffin->flour = 8;
$muffin->sugar = 4;
$muffin->butter = 4;

// $muffin and $short are two different objects, both of type BakeRecipie
// meaning they each have flour/sugar/butter and they can each bake()

//let's see what happens when we call bake:

$muffin->bake(); // tells us we're using 8,4,4

$short->bake(); // tells us we're using 6,6,6

// it *appears* as though that asking $muffin to bake() and $short to bake() is a different operation!
// since they give differnt results, and have no different arguments

// but they *do* have, hiddenly, different arguments... $this is a "hidden argument"

// when calling $muffin->bake(),   $this becomes $muffin
// when calling $short->bake(),    $this becomes $short

// the baking process is written the same for every object
// and it uses the "$this" placehold to specialize to the particular object in question
// when it is called on that particular object


// remember: behaviour is always general, and *data* specific
// behaviour == functions == methods applies to lots of different inputs
// whereas data is how we get specific

// using objects we can give the illusion that we have specialized behaviour
// it seems as though $muffin bake()s in muffin's way, and $shortbread in its way -- but no!
// they both use the same process.. but this process is "magically aware" (via $this) which object is baking


// let's continue to demonstrate this point:
// suppose I want to describe two pens: a red pen and a blue pen
// then I could come up with a blueprint as follows:

class Pen {
    public $color;      // every pen has a colour

    function write($message) {
        echo "writing $message in $this->color\n";      // every pen will write in *its* colour
    }
}

//let's create some new pens
$redPen = new Pen();            //at this point the pen's color is empty
$redPen->color = 'red';         //now we make it red

$bluePen = new Pen();
$bluePen->color = 'blue';

$redPen->write("Hello!");
$bluePen->write("Hello!");
