<?php

//a problem quickly arises when you're including files...

// what happens if two files define the same funciton?


include '10.2.Blog.php';
include '10.3.Forum.php';


//both of the above files define a view_page() function
//however since they are namespace'd,
//all their defintions get tagged with the name of that namespace

//so we have:

\Blog\view_page();
\Forum\view_page();



/* SYNTAX:

\Blog\view_page()


the first \  means "inside the global namespace"
or just, "starting at the begining"

Blog  is the namespace we gave the file

\  means "inside Blog"

view_page is the name of the function


SO...

starting at the gobal namespace,
go look in the Blog namespace
for the function view_page

*/



// in this way namespaces are a little like folers for organizing your functions



// youre "inside" a namespace, if you've written that namespace at the top of the file
// for example the whole file 10.2.Blog.php is "inside" Blog
// meaning that you dont need to write \Blog\ in front of everything in that file



// however this file has no namespace at the top
// so its "inside" the global namespace \

//so in this file you need to write out the full name of the functions:
//, e.g.,  \Blog\view_page()

// if this file had "namespace Blog" at the top
// you would be allowed to write view_page()
// and PHP would look for \Blog\view_page()



// being inside a namespace is a little like being inside a directory..
// all the names of your functions are taken to be inside that namespace,
//ie. prefixed with its path
