<!-- RUN THIS FILE via APACHE, ie. put it in htdocs and browse to localhost -->
<html>
<head> <title>My Shopping Cart </title> </head>
<body>
<!--

we're going to embed some PHP in HTML...

This whole page is processed by the PHP interpreter, anything not inside php tags
is left alone (eg. this HTML bit).

All the code inside php tags is run,
    and the output (eg. anything echo'd, print_r'd etc.) is kept.

 -->

<pre> <!-- this is a pre tag. It gives you a code-style output in HTML.

Everything inbetween pre-tags uses a monospace font
(a font where each character is the same width, like in code editors).

And it respects new lines, tabs, spaces, etc.

-->

<?php
// let's write a shopping cart application
// we (always) need to:
    //1. define some objects;
    //2. define some processes;
    //3. use the processes with the objects

// we begin by deciding how we're going to represent the various key aspects of a real-word shopping situation
// what are the key objects ?

//1. there is a person who shops, a shopper, who -- for example -- browsers around a clothes shop
//2. there are things they are looking for, goods or items, that the shop sells
//eg., shoes, dresses, dressing gowns, and so on

//3. there's the basket the shopper holds as they go around the shop
// the basket is just the group of items theyre holding on to

//4. finally there's the bill: their "basket total", or how much they've bought


// recall: for every single object, we should have an associative array
// an associative array is how we represent single objects with multiple relevant characteristics or properties

// a shopper is a single object, a person, who has -- say -- a name, email, wallet, etc.
$shopper = [
    'name'   => 'Michael Burgess',
    'email'  => 'michael.burgess@qa.com',
    'wallet' => 1000.0      // recall: float == partial number
];                          // 1000 would work just the same,
                            // but .0 indicates to the reader its going to be partial


// items are single objects
// let's say each item has a: colour, price, brand and type

$shoes = [
    'colour' => 'Burgandy',
    'price'  => 550,
    'brand'  => "Church's",
    'type'   => 'Chelsea Boots'
];

$dress = [
    'colour' => 'forget-me-not',
    'price'  => 125,
    'brand'  => "Marc Jacob's",    // using double quotes to include 's
    'type'   => 'Haulter Neck'
];



// baskets are collections of objects
// so we represent them as a sequence of items:

$basket = [$shoes, $dress];


// let's just print something out to see if we're on track
// and have what we expect:

echo "Checking the basket contains what we expect: \n";
print_r($basket); // recall: prints a representation of .. $basket

// print_r() is just for programmers,
// it helps you see what's inside a variable, just like var_dump()



//rather than use print_r(), we can loop over the basket ourselves and
// just write out, more neatly, exactly what we want to show:

echo "\n\nLooping over basket to see what's inside: \n";
foreach($basket as $item) { // $item is first $shoes, then $dress
    echo "\n";
    echo $item['brand'];
    echo " is £";
    echo $item['price'];        // using several echo's to demonstrate a loop's code block
                                // can contain any number of statements
}

//nb. don't let the 'as' confuse you

/* HOW TO READ THE FOREACH:

    for each element in $basket called $item {
        echo $item
    }

*/

//now let's calculate a basket total, or bill:

echo "\n\nNow we're calculating a bill:\n";
$bill = 0;

foreach($basket as $item) {         // for each element in basket called $item
    $bill += $item['price'];        // add that $item's price to the $bill

    // equivalently,
    // $bill =  $bill + $item['price'];
    // new value of $bill   =  old value of $bill + item price
}

echo "The bill is £$bill!\n";

// here we define a function called add_to_basket
// it takes an $input_basket and an $input_item


// now let's define how we're going to add items to our basket
// this is a *process*, so we're going to represent it with a function

// the function will:

// take INPUT: basket, item ->  add item to the basket -> give OUTPUT:  basket with item

//recall: parameters are the INPUT into the function, the "channel in" to the machine
function add_to_basket($input_basket, $input_item) {
    $input_basket[] = $input_item;                      //add $input_item to $input_basket

    return $input_basket; // return is the "channel out"
                          // here we send the $input_basket back out
}



// now let's use our add_to_basket() function on the basket above,
// adding a new item:

$basket = add_to_basket($basket, [
    'price' => 120,
    'brand' => 'Hanro',
    'size' => 44,
    'type' => 'Dressing Gown'
]);

// this reads:
// $basket is now the basket you get when you add_to_basket(the original basket,  a new item)
// were "a new item" is an array with price/brand/size/type keys

//and for our own sanity, let's check $basket contains the item we've just added


echo "\n\nWe've just defined & used the function add to basket, let's check the basket:\n";
print_r($basket);
?>
</pre> <!-- end the pre tag...

all the output from the previous PHP script is inside the pre-tag
-->

<!--

Let's define an HTML form:

The <form> tag encloses all the form elements.
The form tag has the attributes action and method.

Action tells the browser where to send the information.
Method tells the browser what HTTP method to use either POST or GET.
It's almost always POST.

If the action is empty, the browser will send the information to the current url,
ie., to the page itself.
-->

<form action="" method="post">

<!--
    The <input> tags are the form elements (the textboxes)
    Each has a name,
        which the browser bundles up with the information the user entered,
        and sends to the action specified in the form tag.

    Each has a type which determines what kind of form element it is.
    It can be text, in which case you get a single line textbox.
    Or it can be: checkbox, radio box, date, etc.

    There are a large variety of standard form elements you can use.
-->

  <p>Brand: <input name="brand" type="text"></p>  <!-- I've put each in a p-tag to lay them out line-by-line -->
  <p>Price: <input name="price" type="text"></p>
  <p>Size: <input name="size" type="text"></p>
  <p>Type: <input name="type" type="text"></p>

<!-- finally we have a button.

  The type determines what the button will do when pressed.

  "submit" means that when you click this button
  the browser will send the form information to the action,
  ie. it will submit the form.

-->

  <button type="submit">Send!</button>
</form>



<pre>
<!-- note that above, the action is empty, so the info is sent to *this page* -->

<?php
// when PHP is sent form information, it is processed, and stored in a special variable
// called $_POST

// $_POST is a superglobal, meaning, that it the variable "$_POST" can be written anywhere in a PHP file
// and it always means the form data PHP was sent


// when you first load this page you there will be no form information
// because when you first load it, you havent pressed submit
// so $_POST should be empty


echo "\n\nChecking the contents of _POST:\n";
print_r($_POST);


// if you've pressed the submit button, $_POST will have some data

if(!empty($_POST)) {        // recall:   ! means 'not'
                            // recall:  empty($x) is true if $x is 0, '', [], false, null...

    // if $_POST is not empty, we've hit the submit button
    // so add the contents of POST (info. for a single item)
    // to the basket:

    $basket = add_to_basket($basket, $_POST);       // $_POST has 'price', 'colour', 'size', etc. !
}


echo "\n\nLooping over basket to see what's inside: \n";
foreach($basket as $item) { // $item is first $shoes, then $dress
    echo "\n";
    echo $item['brand'];
    echo " is £";
    echo $item['price'];
}
?>
</pre>
