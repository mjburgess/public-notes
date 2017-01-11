<?php

//this line prefixes every function in this file with Blog\
namespace Blog;

function view_page() {
  echo "My Blog\n";
}


//even when calling the function:

view_page();

//is the same as,

\Blog\view_page();
