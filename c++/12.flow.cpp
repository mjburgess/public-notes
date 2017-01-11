#include <iostream>
#include <string>
#include <cstdlib>          //for rand()   

using namespace std;

int main(void) {

    // CODE BLOCKS

    int x = 5, y = 5;

    //thus far programs have been composed of linear, sequential statements
    //we can group statements into code blocks...
    {
        int x = 0, y = 0;
        cout << "the position is " << x << "," << y << endl;
    }

    //this grouping has only one effect in this case, to isolate the declaration of the variables
    //so that x and y retain the original values:
    cout << "the position is " << x << "," << y << endl;       


    // LOOPS

    //however we can do other things with groups of statements, for example:
    //1. repeat the grouping -- loops: do/while, while, for, range-for (aka. for-in, for-each)
    //2. conditionally execute (aka. select) the group -- if/else if/else,  switch

    //in each case we are redirecting the execution flow of the program: 
    //the program returns to earlier or later points in its instructions rather than moving forward sequentially 

    //GOAL: keep asking user for their name until they've entered a valid one
    string name = "Michael";
    while(name.size() < 3) {                //validity condition        < . body of the while loop is repeated
        cout << "What's your name?";        //                            . while the condition is true
        // cin >> name;                     //                            . 
    }                                       //                          < . then control flow returns to this point
    cout << name;


    //do-while loops will always execute their code block at least once, and then while the condition is true

    //GOAL: accept a series of shopping baskets with various amounts of items in them, calculate how many there are
    int basket = 0, total = 0;
    do {                                                        // < . 
        cout << "how many items are in your basket?";           //   . ask the question at least once
        // cin >> basket;                                       //   . get the number items in one basket 
        basket = rand() % 5;                                    //   . (using rand() for convenience)
        total += basket;                                        //   . add that to the total
                                                                //   .
        cout << " accepting: " << basket;                       //   .
        cout << " the total is now " << total << endl;          //   .
    } while(basket > 0);  //SEMI-COLON!                         // < . repeat while the users basket has more items in it



    //loops can be phrased so that their conditions are always true
    //these are known as infinte loops -- infinte fom the POV of the program; the OS may terminate

    //most infinte loops are used as event-loops: 
    //they have internal termination conditions sensative to events external to the program (eg. a mouse click)
    //here the event is the random-number-generater providing a given value, say, for the position of the mouse pointer
    int postn = 0;
    while(true) {                                                 //< . true is always true
        postn = rand() % 10;                                      //  . rand() % 10 generates a number between 0 and 10
                                                                  //  .
        if(postn == 5) {                                          //  . internal termination condition
            break;                                                //  . break causes control flow to return to end of the loop
        }                                                         //  .
                                                                  //  .  
        cout << "the mouse position was: " << postn << endl;      //  .
    }                                                             //< . loop terminates here only if break is hit


    // continue is another jump statement whereas break exits a loop, continue restarts it
    
    //GOAL: process a list of ids, skip any admins (ids begining with A) 
    const char *ids[] = {"ABC-1", "DEF-2", "DEF-3"};
    int i = -1;
    while(++i < 3) {                                            // < . start of the loop: increases i up to num elements
        if(ids[i][0] == 'A') {                                  //   . access the ith element of ids
            continue;                                           //   . return control to the start of the loop
        }                                                       //   .
                                                                //   .
        cout << "processing the ID " << ids[i] << endl;         //   .
    }                                                          //  < .


    //above we used a loop to iterate through an array: 
    //the repeated operaton was sensitive to a changing array position (ids[i])

    //the for loop is the most common way of achiving the same effect 
    //it wraps up the creation of an iteration variable (i), the test condition, and the incrementing step
    //..which are common to the iteration of data structures

    for(int i = 0; i < 3; i++) {
        cout << ids[i] << endl;
    }

    // and we may go in reverse:
    for(int i = 10; i > 0; i--) {
        cout << i * i << endl;
    }

    //C++11 introduces the range-for loop (aka. the for-in loop or the foreach loop)

    string names[] = { "Michael Burgess", "Sherlock Holmes", "Dr. John Watson" }; 
    for(string name : names) {          // may be read as "for each name in names"
        cout << name << endl;           // cout that name
    }

    //in the above form the names array may not be modified 

    //and even.. 

    for(int i : {10, 20, 30}) {
        cout << i ** i << endl;
    }

    /* we will discuss this form later which permits modification of each name in the body of the loop..
    
    for(string &name : names) {
        name = reformat_name(name);
    }
    
    */

    // CONDTIONAL/SELECTION STATEMENTS
    
    // finally some selection statements:
    // the familiar if/else...
    string address = "United Kingdom";
    int age = 19;

    if(address.empty() || age < 18) {
        cout << "you've enetered an empty address" << endl;
    } else {
        cout << "proceed!" << endl;
    }


    //GOAL: given a character that represents a menu choice, perform a relevant operation; eg. q -> quit, a -> answer
    char option = 'B';
    switch(option) {                                    // switch on option, compare it to each case
        case 'A':                                       // if option == 'A'
            cout << "the answer is 42" << endl;
            break;

        case 'q': case 'Q':                             // means *either* 'q' or 'Q'
            cout << "...quitting!" << endl;
            break;
        
        default:                                        // if no prior case has matched
            cout << "the option you chose wasn't found!" << endl;
            break;
    }


    // the switch-case statement appears as though it invites your program to jump around
    // but it executes far more linearly than it first appears

    // the first case that matches the switch'd value begins the execution and
    // statements thereafter are executed in turn until a 'break' is hit
    

    return 0;
}


/* OUTPUT (notes/12.flow.cpp):
the position is 0,0
the position is 5,5
Michaelhow many items are in your basket? accepting: 2 the total is now 2
how many items are in your basket? accepting: 4 the total is now 6
how many items are in your basket? accepting: 3 the total is now 9
how many items are in your basket? accepting: 3 the total is now 12
how many items are in your basket? accepting: 0 the total is now 12
the mouse position was: 2
the mouse position was: 4
the mouse position was: 8
the mouse position was: 3
the mouse position was: 9
the mouse position was: 0
processing the ID DEF-2
processing the ID DEF-3
ABC-1
DEF-2
DEF-3
100
81
64
49
36
25
16
9
4
1
Michael Burgess
Sherlock Holmes
Dr. John Watson
proceed!
the option you chose wasn't found!

*/