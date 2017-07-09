<?php

// from some user input, either Rock, Paper or Scissors
// determine if the user wins in a game against a randomly-selected match-up (by the computer)


// 1. sketch inputs (the data, or state) using sensible defaults
// 2. sketch simple version of processes that use these values


$user_choice      = 'ROCK';
$computer_choice  = 'PAPER';
$result           =  null;         //recall: null means "without a sensible value"

if($user_choice == $computer_choice) {
    $result = "DRAW";
}

// 3. revise default state / actually get the input

//3.1  get the right input from the user
echo "Choose something:\n";
$from_keyboard = stream_get_line(STDIN, 100, "\n"); //get 100 characters from the keyboard (STDIN)
                                                    //, until the user presses enter (\n)

$user_choice = strtoupper(trim($from_keyboard)); // make it upper case and remove any whitespace from the ends

//by making everything uppercase, the user can enter Rock RoCK ROCK etc. and it will all be treated the same,
// ie., as ROCK

//3.2 get the right input for the computer
$choices = ['ROCK', 'PAPER', 'SCISSORS'];
$computer_choice = $choices[array_rand($choices)];  // array_rand() gives you a random index


// 4. exapnd sketch of complex processes until they "do the right thing"


//4.1 SOLUTION THAT USES ARRAYS:

$needed_to_win = [
    "ROCK"  => "PAPER",
    "PAPER" => "SCISSORS",
    "SCISSORS" => "ROCK"
];

if($user_choice == $needed_to_win[$computer_choice]) {
    echo "USER WINS";
} else if($user_choice == $computer_choice) {
    echo "DRAW";
} else {
    echo "LOSE";
}


//4.2 SOLUTION THAT USES if-elseif-else


if($user_choice == $computer_choice) {
    echo "DRAW";
} else if($user_choice == "ROCK" && $computer_choice == "SCISSORS") {
    echo "USER WIN";
} else if($user_choice == "PAPER" && $computer_choice == "ROCK") {
    echo "USER WIN";
} else if($user_choice == "SCISSORS" && $computer_choice == "PAPER") {
    echo "USER WIN";
} else if($user_choice == "SCISSORS" && $computer_choice == "ROCK") {
    echo "COMPUTER WIN";
} else if($user_choice == "ROCK" && $computer_choice == "PAPER") {
    echo "COMPUTER WIN";
} else if($user_choice == "PAPER" && $computer_choice == "SCISSORS") {
    echo "COMPUTER WIN";
} else {
    echo "ERROR -- UNKNOWN";
}
