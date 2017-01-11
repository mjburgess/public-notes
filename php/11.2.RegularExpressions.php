<?php

//ADVANCED:


// regular expressions allow you to search for a given pattern in some text


// in the simplest case the pattern you're looking for is just a word:

$quote = 'western civilization? It would be a good idea!';

$isWesternFound = preg_match('/western/', $quote);  //look for /western/ in $quote

if($isWesternFound) {
  echo "'western' was found in the quote\n";
}

// regex patterns are usually delimited (enclosed by) forward-slashes, /


// we can look for more general kinds of patterns
//for example,  \d  means "a single digit character"

$bill = "You're meal came to £150.00";

$containsPrice = preg_match('/£\d\d\d.\d\d/', $bill);

if($containsPrice) {
  echo "the bill contains the price!\n";
}

// above the pattern £\d\d\d.\d\d  means:

// £ symbol, followed by 3 digits, followed by . followed by 2 digits
// this pattern is in $bill, so we get a match


$billWithoutPrice = "You're meal was expensive!";


if(preg_match('/£\d\d\d.\d\d/', $billWithoutPrice)) {   // does not match now
  echo "the bill contains the price!\n";
} else {
  echo "the bill does not contain the price\n";         // so we get this!
}



// when processing documents we often need to find text, replace text, or "make a note of text"
// within that document

// for example, suppose we had a stack of medical records, then we might want to:

//1. Match Text -- see if each document contains a date
//2. Remember Text -- record what month the document has
//3. Replace Text -- change the format of the date


// the regular expression for matching a simple date is:
// \d\d-\d\d-\d\d\d\d   that is, 2 digits - 2 digits - 4 digits

$datePattern = '/(\d\d)-(\d\d)-(\d\d\d\d)/';
// in regular expression patterns, wrapping something in parentheses -- ()
// means "remember what the actual value was", ie., here we want to remember:
// the day, the month and the year

$documents = [
  "Mr. Michael Burgess has an appointment on 01-10-2016\n",
  "Ms. Irene Adler has an appointment on 31-12-2016\n",
  "Mrs. Watson has an appointment on 01-12-2016\n"
];


foreach($documents as $document) {
  echo "\n\n";
  echo "ORIGINAL: $document\n";

  //1. MATCH  -- does the document contain a date?

  if(preg_match($datePattern, $document, $rememberedBits)) {
    echo "The document contains a date!\n\n";
  }



  //2. REMEMBER -- what bits are in the date?

  //$rememberedBits contains everything we wanted to remember: ie., the day, month, year
  echo "This is what we remembered:\n";
  print_r($rememberedBits);
  echo "\n\n";



  //3. REPLACE -- change the format of the date

  $newDocument = preg_replace($datePattern, '\1/\2/\3', $document);
  // \1/\2/\3 means
  //"put the thing we remembered 1st (ie. the day) first, then a /, then month 2nd..."

  echo "NEW: $newDocument\n";
}



// this is not an exhaustive discussion of regular expressions
// -- just enough to show you what's possible

// regular expressions can find all sorts of patterns in text and are very powerful ways to search
