<?php
// when dealing with small files there are two php functions which can do nearly
// everything:  file_get_contents and file_put_contents

//file_get_contents() reads files into memory; the whole contents of the file
// is returned from the function


$filename = 'hosts.txt';

$contents = file_get_contents($filename);

echo $contents;


//or just

echo file_get_contents('hosts.txt');


//file_put_contents() does the reverse: takes text in memory (ie., data in a variable)
//and writes it to a file


$filepath = "./output.txt";  //recall:  . means "where i am running" in relative paths
$data = "Michael,27,UK,Male";     //some text we want to write

file_put_contents($filepath, $data);



// or just,
file_put_contents('output.txt', 'Michael,27,UK,Male'); // ./output.txt is assumed


//however this way of using file_put_contents() will overwrite the entire file
// with the data you have supplied (and create the file if it doesnt exist)


//if you want to write to the end of a file (ie. append to it)
// then you can pass a special option to the function:


file_put_contents('output.txt', 'Sherlock,27,UK,Male', FILE_APPEND);

// FILE_APPEND is a constant supplied by PHP
// many functions provided by PHP take special constants that modify their behaviour
// the third argument to file_put_contents() is called a flag
// it flags, as in, "marks (an item) for attention or treatment in a specified way."



// the only problem with the above two functions is they require all their data
// to be stored in memory in one go:  either reading the file in one go, or writing to it in one go
// this is OK for smaller files -- but reading larger ones may eat-up all the memory on the computer!



// to deal with larger files we really need to know more about what a file is
// and how they work...

echo "\n\n\n";

// define file:
// any stream of information that you can read from (or write to) with a CURSOR!

// a file cursor is just like the cursor in a text editor (eg. word, atom, etc.)
// when you're typing in a file you type *from the cursor* onwards
// and you move the cursor around when you want to write to and read from
// different parts of the file

// this is the same process when using a programming language

// fopen() returns a special value called a resource
// here it represents the file we're writing to.. it remembers where the cursor is

$cursor = fopen("seek.txt", "w+");  // the second argument is the mode
                                      // w+ means we're going to read-from and write-to
                                      // starting at the begining of a *NEW* file
                                      // see http://php.net/manual/en/function.fopen.php for more modes

fwrite($cursor, "Michael");           // write Michael -- this moves the cursor
fwrite($cursor, " Burgess");          // write Burgess -- this writes Burgess *after* Michael

fseek($cursor, strlen("Michael"));     // move the cursor to just after Michael

fwrite($cursor, " John");             // write John -- *after* Michael

fseek($cursor, 0);                    // move the cursor to the begining

echo fread($cursor, 100);             //read 100 characters
                                      // echo's:   Michael Johness

                                      //Q.  Why?
                                      //A. John overwrote part of Burgess

fclose($cursor);                      //close the file



// if we want to read a file one-line-at-a-time we'd need a similar process
// involving... a loop!

/*  SOMETHING LIKE...


 while (NOT AT THE END OF THE FILE) {
  READ A LINE;
  ECHO A LINE;
}

*/


$cursor = fopen('hosts.txt', 'r');  //open for reading

while (!feof($cursor)) {	     // feof() tells you if the cursor has hit the end of the file

  $line = fgets($cursor);     //reads (and moves the cursor) till the end of a line

  echo $line;   // print line
}

fclose($fp);


// note, above, each time we go around the loop $line is overwritten with
// a call to fgets() which returns the next line in the file
// so that at any given time we're only using one-line's worth of memory
