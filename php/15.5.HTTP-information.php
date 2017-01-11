<!-- RUN THIS FILE via APACHE, ie. put it in htdocs and browse to localhost -->
<pre>
<?php
// PHP receives a lot of information from "the external environment"

// PHP's immediate environment is just its neighbouring programs on the machine it's running on
// for example, the web server (eg. apache), and the operating system (eg. linux, mac, windows...)

// the web server (eg. apache) is the program which talks to the web browser over the network
// recieving HTTP requests and sending HTTP responses

// the web server forwards HTTP requests to PHP
// so that it knows everything the web server knows

//in larger sense, then, PHP is also connected to the browser
//and recieves information the user sent

//recall:

//$_GET is the informationn sent via the URL
//requests which are URL-driven are called GET-requests
print_r($_GET);


//$_POST is the information sent via (typically,) a form
//requests which are form-driven are called POST-requests
print_r($_POST);


//PHP recieves a lot of other information from the web server too..
// this is avaialble in the $_SERVER superglobal array
print_r($_SERVER);

//you can also get the operating system to provide some custom information
//typically available in the _ENV (enviornment) superglobal
print_r($_ENV); // webserver & os-provided information



//the technical name "environment" only refers to the information
// that is pumped into a program by the operating system (, and other programs)
// vs., for example, the information provided by the user
// which is *not* part of the environment
