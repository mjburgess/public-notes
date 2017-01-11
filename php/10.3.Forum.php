<?php
//this line prefixes every function in this file with Forum\
namespace Forum;

function view_page() {
  echo "My Forum\n";
}



//even when calling the function:

view_page();

//is the same as:

\Forum\view_page();
