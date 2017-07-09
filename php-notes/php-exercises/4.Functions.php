<?php

// Q. write a login function which takes two argumnets, a username and a password.
//... if the password is 'test' then echo both arguments otherwise echo DENIED

function login($username, $password) {
    if($password == 'test') {
        echo "$username $password\n";
    } else {
        echo "DENIED!\n";
    }
}

// Q. define a function called password which randomly returns either 'test' or 'guest'.

function password() {
    $oneOrZero = rand(0, 1);

    if($oneOrZero) {
        return 'test';
    } else {
        return 'guest';
    }
}

// Q. call your login function, supplying a username and a password.
//... the password should be given by your password function.

$password = password();

login('mjburgess', $password);


// login('mjburgess', password()); -- also reasonable
