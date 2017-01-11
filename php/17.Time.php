<?php
//OPTIONAL


// How do we measure time?

// there's time relative to "a now"

$oneHourFromNow = 60 * 60; // one hour from now is +3600 seconds in the future

// there's time relative to a fixed historical point

$year = 2016; // officially, two thousand and sixteen years since the birth of jesus

// times need to be relative to a fixed historical point in order to compare them

$hastings = 1066;       // 1066 years AD (ie., 1 AD + 1065)
$ww1 = 1914;            // 1914 years AD (ie., 1 AD + 1913)

var_dump($hastings < $ww1);  // true, hastings is earlier than ww1

$yearsBetween = $ww1 - $hastings;
            // years WW1 has been since 1 AD - years hasting has been since 1 AD
            // (1 AD + 1913) - (1 AD + 1065) = 1 AD - 1 AD + 1913 - 1065
            // = 848 years


// its not really clear what this means:

$oneHourFromY = 3600;
$oneMinuteFromX = 60;

var_dump($oneHourFromY < $oneMinuteFromX);

//it could be that Y = 6pm,  X = 5pm
// so it might mean that one hour past 6pm, is earlier than one minute past 5pm -- which is false
// or it could be that Y = 10am, and X = 10pm
// so that one hour after 10am is earlier than one minute after 10pm -- which is true

// it just depends what fixed time $oneMinuteFrom and $oneHourFrom are being added to


// in the programming world we do not use 1 AD as the starting point for comparing times,
// but 1970 AD, or "the unix epoch"

$now = time(); // no. seconds since 1/1/1970

// the time() function returns a larger number, ~10 billion, the number of seconds since 1/1/1970


$oneMinuteFromNow = time() + 60;
                  // now + 1 minute

$oneHourFromTomorrow = time() + (24 * 3600) + 3600;
                     //now + 1 day + 1 hour


$secondInBetween = $oneHourFromTomorrow - $oneMinuteFromNow;

//  (seconds since 1970 + 1 day + 1 hour) - (seconds since 1970 + 1 minute)
// == (secons since 1970 - seconds since 1970) +1 day + 1 hour - 1 minute
// ==  1 day + 1 hour - 1 minute
// == 89940 seconds



// so if we're reporting fixed times, that is not "an hour from now" but a defininte time
// we do so in seconds from 1/1/1970, using the time() function
