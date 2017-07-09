<?php

//Q. create a $message variable which is a string a message

$message = "Hello World!";

//Q. write $message to the file 'output.txt'


//requires a path, either absolute or relative
//recall, absolute:   /home/mj/output,  C:\users\michael\something
//recall, relative: ./output.txt                 where . means "here"
file_put_contents('output.txt', $message); // ./ is implied

//Q. echo the contents of output.txt

echo file_get_contents('output.txt');

//Q. append another message to the end of output.txt

file_put_contents('output.txt', "\nantoher message", FILE_APPEND);

//Q. echo the contents output.txt again

echo "\n\nechoing again:\n"
echo file_get_contents('output.txt');
